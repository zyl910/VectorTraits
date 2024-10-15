using System;
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
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl {
    partial interface IWVectorTraits128 {
#if NETCOREAPP3_0_OR_GREATER

        // == mY style  ==

        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToByte</c> (运行 <c>YBitToByte</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector128{byte})"/>.</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YBitToByte"/>: Converts binary bits to each element of the Byte vector (将各个二进制位转换为 Byte 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt16"/>: Converts binary bits to each element of the Int16 vector (将各个二进制位转换为 Int16 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt32"/>: Converts binary bits to each element of the Int32 vector (将各个二进制位转换为 Int32 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt64"/>: Converts binary bits to each element of the Int64 vector (将各个二进制位转换为 Int64 向量的每个元素).</para>
        /// </remarks>
        /// <seealso cref="YBitToByte"/>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        bool YBitToByte_IsAccelerated { get; }

        /// <summary>
        /// Converts binary bits to each element of the Byte vector (将各个二进制位转换为 Byte 向量的每个元素). Bit 0 meaning is 0, bit 1 meaning is 1 for all bits (<see cref="byte.MaxValue"/>).
        /// Mnemonic: <c>rt[i] := to_mask(0 != ((mask&gt;&gt;i)&amp;1))</c>.
        /// </summary>
        /// <param name="value">Source value (源值).</param>
        /// <returns>Returns the converted vector (返回转换后的向量).</returns>
        /// <seealso cref="YBitToByte_IsAccelerated"/>
        Vector128<byte> YBitToByte(uint value);


        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToInt16</c> (运行 <c>YBitToInt16</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector128{short})"/>.</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YBitToByte"/>: Converts binary bits to each element of the Byte vector (将各个二进制位转换为 Byte 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt16"/>: Converts binary bits to each element of the Int16 vector (将各个二进制位转换为 Int16 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt32"/>: Converts binary bits to each element of the Int32 vector (将各个二进制位转换为 Int32 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt64"/>: Converts binary bits to each element of the Int64 vector (将各个二进制位转换为 Int64 向量的每个元素).</para>
        /// </remarks>
        /// <seealso cref="YBitToInt16"/>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        bool YBitToInt16_IsAccelerated { get; }

        /// <summary>
        /// Converts binary bits to each element of the Int16 vector (将各个二进制位转换为 Int16 向量的每个元素). Bit 0 meaning is 0, bit 1 meaning is 1 for all bits (-1).
        /// Mnemonic: <c>rt[i] := to_mask(0 != ((mask&gt;&gt;i)&amp;1))</c>.
        /// </summary>
        /// <param name="value">Source value (源值).</param>
        /// <returns>Returns the converted vector (返回转换后的向量).</returns>
        /// <seealso cref="YBitToInt16_IsAccelerated"/>
        Vector128<short> YBitToInt16(uint value);


        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToInt32</c> (运行 <c>YBitToInt32</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector128{int})"/>.</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YBitToByte"/>: Converts binary bits to each element of the Byte vector (将各个二进制位转换为 Byte 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt16"/>: Converts binary bits to each element of the Int16 vector (将各个二进制位转换为 Int16 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt32"/>: Converts binary bits to each element of the Int32 vector (将各个二进制位转换为 Int32 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt64"/>: Converts binary bits to each element of the Int64 vector (将各个二进制位转换为 Int64 向量的每个元素).</para>
        /// </remarks>
        /// <seealso cref="YBitToInt32"/>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        bool YBitToInt32_IsAccelerated { get; }

        /// <summary>
        /// Converts binary bits to each element of the Int32 vector (将各个二进制位转换为 Int32 向量的每个元素). Bit 0 meaning is 0, bit 1 meaning is 1 for all bits (-1).
        /// Mnemonic: <c>rt[i] := to_mask(0 != ((mask&gt;&gt;i)&amp;1))</c>.
        /// </summary>
        /// <param name="value">Source value (源值).</param>
        /// <returns>Returns the converted vector (返回转换后的向量).</returns>
        /// <seealso cref="YBitToInt32_IsAccelerated"/>
        Vector128<int> YBitToInt32(uint value);


        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToInt64</c> (运行 <c>YBitToInt64</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector128{long})"/>.</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YBitToByte"/>: Converts binary bits to each element of the Byte vector (将各个二进制位转换为 Byte 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt16"/>: Converts binary bits to each element of the Int16 vector (将各个二进制位转换为 Int16 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt32"/>: Converts binary bits to each element of the Int32 vector (将各个二进制位转换为 Int32 向量的每个元素).</para>
        /// <para>- <see cref="YBitToInt64"/>: Converts binary bits to each element of the Int64 vector (将各个二进制位转换为 Int64 向量的每个元素).</para>
        /// </remarks>
        /// <seealso cref="YBitToInt64"/>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        bool YBitToInt64_IsAccelerated { get; }

        /// <summary>
        /// Converts binary bits to each element of the Int64 vector (将各个二进制位转换为 Int64 向量的每个元素). Bit 0 meaning is 0, bit 1 meaning is 1 for all bits (-1).
        /// Mnemonic: <c>rt[i] := to_mask(0 != ((mask&gt;&gt;i)&amp;1))</c>.
        /// </summary>
        /// <param name="value">Source value (源值).</param>
        /// <returns>Returns the converted vector (返回转换后的向量).</returns>
        /// <seealso cref="YBitToInt64_IsAccelerated"/>
        Vector128<long> YBitToInt64(uint value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YClamp</c> (运行 <c>YClamp</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YClamp(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
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
        Vector128<float> YClamp(Vector128<float> value, Vector128<float> amin, Vector128<float> amax);

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
        Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax);

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
        Vector128<sbyte> YClamp(Vector128<sbyte> value, Vector128<sbyte> amin, Vector128<sbyte> amax);

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
        Vector128<byte> YClamp(Vector128<byte> value, Vector128<byte> amin, Vector128<byte> amax);

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
        Vector128<short> YClamp(Vector128<short> value, Vector128<short> amin, Vector128<short> amax);

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
        Vector128<ushort> YClamp(Vector128<ushort> value, Vector128<ushort> amin, Vector128<ushort> amax);

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
        Vector128<int> YClamp(Vector128<int> value, Vector128<int> amin, Vector128<int> amax);

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
        Vector128<uint> YClamp(Vector128<uint> value, Vector128<uint> amin, Vector128<uint> amax);

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
        Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax);

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
        Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax);


        /// <summary>
        /// Types with hardware acceleration when running <c>YCopySign</c> (运行 <c>YCopySign</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YCopySign(Vector128{float}, Vector128{float})"/>
        TypeCodeFlags YCopySign_AcceleratedTypes { get; }

        /// <summary>
        /// Copies the sign of a value to the sign of another value (将一个值的符号复制到另一个值).
        /// Mnemonic: <c>rt[i] := copySign(value[i], sign[i])</c>.
        /// </summary>
        /// <param name="value">The value whose magnitude is used in the result (结果中使用的幅度).</param>
        /// <param name="sign">The value whose sign is used in the result (结果中使用符号的值).</param>
        /// <returns>Returns a vector where each element is a value based on the magnitude of <paramref name="value"/> and the sign of <paramref name="sign"/> (返回一个向量，其中每个元素是根据 value的幅度和sign的符号而生成的值).</returns>
        /// <seealso cref="YCopySign_AcceleratedTypes"/>
        /// <seealso cref="MathINumber.CopySign(float, float)"/>
        Vector128<float> YCopySign(Vector128<float> value, Vector128<float> sign);

        /// <inheritdoc cref="YCopySign(Vector128{float}, Vector128{float})"/>
        /// <seealso cref="MathINumber.CopySign(double, double)"/>
        Vector128<double> YCopySign(Vector128<double> value, Vector128<double> sign);

        /// <inheritdoc cref="YCopySign(Vector128{float}, Vector128{float})"/>
        /// <seealso cref="MathINumber.CopySign(sbyte, sbyte)"/>
        Vector128<sbyte> YCopySign(Vector128<sbyte> value, Vector128<sbyte> sign);

        /// <inheritdoc cref="YCopySign(Vector128{float}, Vector128{float})"/>
        /// <seealso cref="MathINumber.CopySign(short, short)"/>
        Vector128<short> YCopySign(Vector128<short> value, Vector128<short> sign);

        /// <inheritdoc cref="YCopySign(Vector128{float}, Vector128{float})"/>
        /// <seealso cref="MathINumber.CopySign(int, int)"/>
        Vector128<int> YCopySign(Vector128<int> value, Vector128<int> sign);

        /// <inheritdoc cref="YCopySign(Vector128{float}, Vector128{float})"/>
        /// <seealso cref="MathINumber.CopySign(long, long)"/>
        Vector128<long> YCopySign(Vector128<long> value, Vector128<long> sign);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup1ToGroup3</c> (运行 <c>YGroup1ToGroup3</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YGroup1ToGroup3(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup1ToGroup4_AcceleratedTypes"/>
        /// <seealso cref="YGroup1ToGroup4WithW_AcceleratedTypes"/>
        /// <seealso cref="YGroup3Zip_AcceleratedTypes"/>
        TypeCodeFlags YGroup1ToGroup3_AcceleratedTypes { get; }

        /// <summary>
        /// Convert a 1-element group, to a 3-element group. It also converts grayscale pixel data to packed RGB pixel data (将1-元素组, 转为3-元素组. 它还能将 灰度像素数据, 转换为 已打包的RGB像素数据).
        /// Mnemonic: View for group: <c>(result0, result1, result2) = YGroup3Zip(x, x, x)</c>. View for element: <c>element_ref(i, result0, result1, result2) := x[i/3]</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="result1">Returns part 1 of the converted data (返回转换后数据的第1部分).</param>
        /// <param name="result2">Returns part 2 of the converted data (返回转换后数据的第2部分).</param>
        /// <returns>Returns part 0 of the converted data (返回转换后数据的第0部分).</returns>
        /// <seealso cref="YGroup1ToGroup3_AcceleratedTypes"/>
        Vector128<float> YGroup1ToGroup3(Vector128<float> x, out Vector128<float> result1, out Vector128<float> result2);

        /// <inheritdoc cref="YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup1ToGroup3(Vector128<double> x, out Vector128<double> result1, out Vector128<double> result2);

        /// <inheritdoc cref="YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup1ToGroup3(Vector128<sbyte> x, out Vector128<sbyte> result1, out Vector128<sbyte> result2);

        /// <inheritdoc cref="YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup1ToGroup3(Vector128<byte> x, out Vector128<byte> result1, out Vector128<byte> result2);

        /// <inheritdoc cref="YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup1ToGroup3(Vector128<short> x, out Vector128<short> result1, out Vector128<short> result2);

        /// <inheritdoc cref="YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup1ToGroup3(Vector128<ushort> x, out Vector128<ushort> result1, out Vector128<ushort> result2);

        /// <inheritdoc cref="YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup1ToGroup3(Vector128<int> x, out Vector128<int> result1, out Vector128<int> result2);

        /// <inheritdoc cref="YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup1ToGroup3(Vector128<uint> x, out Vector128<uint> result1, out Vector128<uint> result2);

        /// <inheritdoc cref="YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup1ToGroup3(Vector128<long> x, out Vector128<long> result1, out Vector128<long> result2);

        /// <inheritdoc cref="YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup1ToGroup3(Vector128<ulong> x, out Vector128<ulong> result1, out Vector128<ulong> result2);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup1ToGroup4</c> (运行 <c>YGroup1ToGroup4</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YGroup1ToGroup4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup1ToGroup3_AcceleratedTypes"/>
        /// <seealso cref="YGroup1ToGroup4WithW_AcceleratedTypes"/>
        /// <seealso cref="YGroup4Zip_AcceleratedTypes"/>
        TypeCodeFlags YGroup1ToGroup4_AcceleratedTypes { get; }

        /// <summary>
        /// Convert a 1-element group, to a 4-element group. It also converts grayscale pixel data to packed RGBA pixel data (将1-元素组, 转为4-元素组. 它还能将 灰度像素数据, 转换为 已打包的RGBA像素数据).
        /// Mnemonic: View for group: <c>(result0, result1, result2, result4) = YGroup4Zip(x, x, x, x)</c>. View for element: <c>element_ref(i, result0, result1, result2, result4) := x[i/4]</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="result1">Returns part 1 of the converted data (返回转换后数据的第1部分).</param>
        /// <param name="result2">Returns part 2 of the converted data (返回转换后数据的第2部分).</param>
        /// <param name="result3">Returns part 3 of the converted data (返回转换后数据的第3部分).</param>
        /// <returns>Returns part 0 of the interleaved result (返回交织后数据的第0部分).</returns>
        Vector128<float> YGroup1ToGroup4(Vector128<float> x, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3);

        /// <inheritdoc cref="YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup1ToGroup4(Vector128<double> x, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3);

        /// <inheritdoc cref="YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup1ToGroup4(Vector128<sbyte> x, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3);

        /// <inheritdoc cref="YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup1ToGroup4(Vector128<byte> x, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3);

        /// <inheritdoc cref="YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup1ToGroup4(Vector128<short> x, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3);

        /// <inheritdoc cref="YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup1ToGroup4(Vector128<ushort> x, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3);

        /// <inheritdoc cref="YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup1ToGroup4(Vector128<int> x, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3);

        /// <inheritdoc cref="YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup1ToGroup4(Vector128<uint> x, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3);

        /// <inheritdoc cref="YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup1ToGroup4(Vector128<long> x, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3);

        /// <inheritdoc cref="YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup1ToGroup4(Vector128<ulong> x, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup1ToGroup4WithW</c> (运行 <c>YGroup1ToGroup4WithW</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YGroup1ToGroup4WithW(Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup1ToGroup3_AcceleratedTypes"/>
        /// <seealso cref="YGroup1ToGroup4_AcceleratedTypes"/>
        /// <seealso cref="YGroup4Zip_AcceleratedTypes"/>
        TypeCodeFlags YGroup1ToGroup4WithW_AcceleratedTypes { get; }

        /// <summary>
        /// Convert a 1-element group and w argument, to a 4-element group. It also converts grayscale pixel data to packed RGBA pixel data (将1-元素组及w参数, 转为4-元素组. 它还能将 灰度像素数据, 转换为 已打包的RGBA像素数据).
        /// Mnemonic: View for group: <c>(result0, result1, result2, result4) = YGroup4Zip(x, x, x, w)</c>. View for element: <c>element_ref(i, result0, result1, result2, result4) := ((i%4)&lt;3)?( x[i2] ):( w[i2] )</c>, <c>i2 := i/4</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="w">A vector consisting purely of W-components (纯由W分量所组成的向量).</param>
        /// <param name="result1">Returns part 1 of the converted data (返回转换后数据的第1部分).</param>
        /// <param name="result2">Returns part 2 of the converted data (返回转换后数据的第2部分).</param>
        /// <param name="result3">Returns part 3 of the converted data (返回转换后数据的第3部分).</param>
        /// <returns>Returns part 0 of the interleaved result (返回交织后数据的第0部分).</returns>
        Vector128<float> YGroup1ToGroup4WithW(Vector128<float> x, Vector128<float> w, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3);

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup1ToGroup4WithW(Vector128<double> x, Vector128<double> w, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3);

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup1ToGroup4WithW(Vector128<sbyte> x, Vector128<sbyte> w, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3);

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup1ToGroup4WithW(Vector128<byte> x, Vector128<byte> w, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3);

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup1ToGroup4WithW(Vector128<short> x, Vector128<short> w, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3);

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup1ToGroup4WithW(Vector128<ushort> x, Vector128<ushort> w, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3);

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup1ToGroup4WithW(Vector128<int> x, Vector128<int> w, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3);

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup1ToGroup4WithW(Vector128<uint> x, Vector128<uint> w, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3);

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup1ToGroup4WithW(Vector128<long> x, Vector128<long> w, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3);

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup1ToGroup4WithW(Vector128<ulong> x, Vector128<ulong> w, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2Transpose</c> (运行 <c>YGroup2Transpose</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2TransposeEven + YGroup2TransposeOdd = YGroup2Transpose</c>.</para>
        /// <para>Inverse function (逆函数): self (自身).</para>
        /// <para>Sample (示例).</para>
        /// <list type="table">
        ///    <listheader>
        ///        <term>Elements</term>
        ///        <description>Result</description>
        ///    </listheader>
        ///    <item>
        ///        <term>1</term>
        ///        <description><c>f({x[0]}, {y[0]}) = ({x[0]}, {y[0]})</c>. (Fallback)</description>
        ///    </item>
        ///    <item>
        ///        <term>2</term>
        ///        <description><c>f({x[0], x[1]}, {y[0], y[1]}) = ({x[0], y[0]}, {x[1], y[1]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>4</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3]}, {y[0], y[1], y[2], y[3]}) = ({x[0], y[0], x[2], y[2]}, {x[1], y[1], x[3], y[3]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>8</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7]}) = ({x[0], y[0], x[2], y[2], x[4], y[4], x[6], y[6]}, {x[1], y[1], x[3], y[3], x[5], y[5], x[7], y[7]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>16</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8], x[9], x[10], x[11], x[12], x[13], x[14], x[15]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7], y[8], y[9], y[10], y[11], y[12], y[13], y[14], y[15]}) = ({x[0], y[0], x[2], y[2], x[4], y[4], x[6], y[6], x[8], y[8], x[10], y[10], x[12], y[12], x[14], y[14]}, {x[1], y[1], x[3], y[3], x[5], y[5], x[7], y[7], x[9], y[9], x[11], y[11], x[13], y[13], x[15], y[15]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>...</term>
        ///        <description>...</description>
        ///    </item>
        /// </list>
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
        ///        <description><see cref="AdvSimd.Arm64.TransposeEven(Vector128{byte}, Vector128{byte})">vtrn1q_u8</see>,<see cref="AdvSimd.Arm64.TransposeOdd(Vector128{byte}, Vector128{byte})">vtrn2q_u8</see></description>
        ///        <description><see cref="AdvSimd.Arm64.TransposeEven(Vector128{ushort}, Vector128{ushort})">vtrn1q_u16</see>,<see cref="AdvSimd.Arm64.TransposeOdd(Vector128{ushort}, Vector128{ushort})">vtrn2q_u16</see></description>
        ///        <description><see cref="AdvSimd.Arm64.TransposeEven(Vector128{uint}, Vector128{uint})">vtrn1q_u32</see>,<see cref="AdvSimd.Arm64.TransposeOdd(Vector128{uint}, Vector128{uint})">vtrn2q_u32</see></description>
        ///        <description><see cref="AdvSimd.Arm64.TransposeEven(Vector128{ulong}, Vector128{ulong})">vtrn1q_u64</see>,<see cref="AdvSimd.Arm64.TransposeOdd(Vector128{ulong}, Vector128{ulong})">vtrn2q_u64</see></description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YGroup2Transpose(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup2TransposeEven_AcceleratedTypes"/>
        /// <seealso cref="YGroup2TransposeOdd_AcceleratedTypes"/>
        TypeCodeFlags YGroup2Transpose_AcceleratedTypes { get; }

        /// <summary>
        /// Transpose a 2*2 matrix (对2*2矩阵进行转置).
        /// Mnemonic: <c>result0[i] := (0==(i&amp;1))?( x[i&amp;~1] ):( y[i&amp;~1] )</c>, <c>result1[i] := (0==(i&amp;1))?( x[(i&amp;~1) + 1] ):( y[(i&amp;~1) + 1] )</c>.
        /// </summary>
        /// <param name="data0">Part 0 of the vector data (向量数据的第0部分).</param>
        /// <param name="data1">Part 1 of the vector data (向量数据的第1部分).</param>
        /// <param name="result1">Returns part 1 of the transposed data (返回转置后数据的第1部分).</param>
        /// <returns>Returns part 0 of the transposed data (返回转置后数据的第0部分).</returns>
        /// <seealso cref="YGroup2Transpose_AcceleratedTypes"/>
        Vector128<float> YGroup2Transpose(Vector128<float> data0, Vector128<float> data1, out Vector128<float> result1);

        /// <inheritdoc cref="YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup2Transpose(Vector128<double> data0, Vector128<double> data1, out Vector128<double> result1);

        /// <inheritdoc cref="YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup2Transpose(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> result1);

        /// <inheritdoc cref="YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup2Transpose(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> result1);

        /// <inheritdoc cref="YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup2Transpose(Vector128<short> data0, Vector128<short> data1, out Vector128<short> result1);

        /// <inheritdoc cref="YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup2Transpose(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> result1);

        /// <inheritdoc cref="YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup2Transpose(Vector128<int> data0, Vector128<int> data1, out Vector128<int> result1);

        /// <inheritdoc cref="YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup2Transpose(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> result1);

        /// <inheritdoc cref="YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup2Transpose(Vector128<long> data0, Vector128<long> data1, out Vector128<long> result1);

        /// <inheritdoc cref="YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup2Transpose(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> result1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2TransposeEven</c> (运行 <c>YGroup2TransposeEven</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2TransposeEven + YGroup2TransposeOdd = YGroup2Transpose</c>. See more: <see cref="YGroup2Transpose_AcceleratedTypes"/>.</para>
        /// </remarks>
        /// <seealso cref="YGroup2TransposeEven(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags YGroup2TransposeEven_AcceleratedTypes { get; }

        /// <summary>
        /// Transpose a 2*2 matrix and return a data in even positions (对2*2矩阵进行转置, 并返回偶数位置的数据).
        /// Mnemonic: <c>rt[i] =: (0==(i&amp;1))?( x[i&amp;~1] ):( y[i&amp;~1] )</c>.
        /// </summary>
        /// <param name="data0">Part 0 of the vector data (向量数据的第0部分).</param>
        /// <param name="data1">Part 1 of the vector data (向量数据的第1部分).</param>
        /// <returns>Returns part 0 of the transposed data (返回转置后数据的第0部分).</returns>
        /// <seealso cref="YGroup2TransposeEven_AcceleratedTypes"/>
        Vector128<float> YGroup2TransposeEven(Vector128<float> data0, Vector128<float> data1);

        /// <inheritdoc cref="YGroup2TransposeEven(Vector128{float}, Vector128{float})"/>
        Vector128<double> YGroup2TransposeEven(Vector128<double> data0, Vector128<double> data1);

        /// <inheritdoc cref="YGroup2TransposeEven(Vector128{float}, Vector128{float})"/>
        Vector128<sbyte> YGroup2TransposeEven(Vector128<sbyte> data0, Vector128<sbyte> data1);

        /// <inheritdoc cref="YGroup2TransposeEven(Vector128{float}, Vector128{float})"/>
        Vector128<byte> YGroup2TransposeEven(Vector128<byte> data0, Vector128<byte> data1);

        /// <inheritdoc cref="YGroup2TransposeEven(Vector128{float}, Vector128{float})"/>
        Vector128<short> YGroup2TransposeEven(Vector128<short> data0, Vector128<short> data1);

        /// <inheritdoc cref="YGroup2TransposeEven(Vector128{float}, Vector128{float})"/>
        Vector128<ushort> YGroup2TransposeEven(Vector128<ushort> data0, Vector128<ushort> data1);

        /// <inheritdoc cref="YGroup2TransposeEven(Vector128{float}, Vector128{float})"/>
        Vector128<int> YGroup2TransposeEven(Vector128<int> data0, Vector128<int> data1);

        /// <inheritdoc cref="YGroup2TransposeEven(Vector128{float}, Vector128{float})"/>
        Vector128<uint> YGroup2TransposeEven(Vector128<uint> data0, Vector128<uint> data1);

        /// <inheritdoc cref="YGroup2TransposeEven(Vector128{float}, Vector128{float})"/>
        Vector128<long> YGroup2TransposeEven(Vector128<long> data0, Vector128<long> data1);

        /// <inheritdoc cref="YGroup2TransposeEven(Vector128{float}, Vector128{float})"/>
        Vector128<ulong> YGroup2TransposeEven(Vector128<ulong> data0, Vector128<ulong> data1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2TransposeOdd</c> (运行 <c>YGroup2TransposeOdd</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2TransposeEven + YGroup2TransposeOdd = YGroup2Transpose</c>. See more: <see cref="YGroup2Transpose_AcceleratedTypes"/>.</para>
        /// </remarks>
        /// <seealso cref="YGroup2TransposeOdd(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags YGroup2TransposeOdd_AcceleratedTypes { get; }

        /// <summary>
        /// Transpose a 2*2 matrix and return a data in odd positions (对2*2矩阵进行转置, 并返回奇数位置的数据).
        /// Mnemonic: <c>rt[i] =: (0==(i&amp;1))?( x[(i&amp;~1) + 1] ):( y[(i&amp;~1) + 1] )</c>.
        /// </summary>
        /// <param name="data0">A vector made of 2-element groups - Part 0 (由2元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 2-element groups - Part 1 (由2元素组所组成的向量 - 第1部分).</param>
        /// <returns>Returns part 1 of the transposed data (返回转置后数据的第1部分).</returns>
        /// <seealso cref="YGroup2TransposeOdd_AcceleratedTypes"/>
        Vector128<float> YGroup2TransposeOdd(Vector128<float> data0, Vector128<float> data1);

        /// <inheritdoc cref="YGroup2TransposeOdd(Vector128{float}, Vector128{float})"/>
        Vector128<double> YGroup2TransposeOdd(Vector128<double> data0, Vector128<double> data1);

        /// <inheritdoc cref="YGroup2TransposeOdd(Vector128{float}, Vector128{float})"/>
        Vector128<sbyte> YGroup2TransposeOdd(Vector128<sbyte> data0, Vector128<sbyte> data1);

        /// <inheritdoc cref="YGroup2TransposeOdd(Vector128{float}, Vector128{float})"/>
        Vector128<byte> YGroup2TransposeOdd(Vector128<byte> data0, Vector128<byte> data1);

        /// <inheritdoc cref="YGroup2TransposeOdd(Vector128{float}, Vector128{float})"/>
        Vector128<short> YGroup2TransposeOdd(Vector128<short> data0, Vector128<short> data1);

        /// <inheritdoc cref="YGroup2TransposeOdd(Vector128{float}, Vector128{float})"/>
        Vector128<ushort> YGroup2TransposeOdd(Vector128<ushort> data0, Vector128<ushort> data1);

        /// <inheritdoc cref="YGroup2TransposeOdd(Vector128{float}, Vector128{float})"/>
        Vector128<int> YGroup2TransposeOdd(Vector128<int> data0, Vector128<int> data1);

        /// <inheritdoc cref="YGroup2TransposeOdd(Vector128{float}, Vector128{float})"/>
        Vector128<uint> YGroup2TransposeOdd(Vector128<uint> data0, Vector128<uint> data1);

        /// <inheritdoc cref="YGroup2TransposeOdd(Vector128{float}, Vector128{float})"/>
        Vector128<long> YGroup2TransposeOdd(Vector128<long> data0, Vector128<long> data1);

        /// <inheritdoc cref="YGroup2TransposeOdd(Vector128{float}, Vector128{float})"/>
        Vector128<ulong> YGroup2TransposeOdd(Vector128<ulong> data0, Vector128<ulong> data1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2Unzip</c> (运行 <c>YGroup2Unzip</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2UnzipEven + YGroup2UnzipOdd = YGroup2Unzip</c>.</para>
        /// <para>Inverse function (逆函数): <see cref="YGroup2Zip_AcceleratedTypes">YGroup2Zip</see>.</para>
        /// <para>Sample (示例).</para>
        /// <list type="table">
        ///    <listheader>
        ///        <term>Elements</term>
        ///        <description>Result</description>
        ///    </listheader>
        ///    <item>
        ///        <term>1</term>
        ///        <description><c>f({x[0]}, {y[0]}) = ({x[0]}, {y[0]})</c>. (Fallback)</description>
        ///    </item>
        ///    <item>
        ///        <term>2</term>
        ///        <description><c>f({x[0], y[0]}, {x[1], y[1]}) = ({x[0], x[1]}, {y[0], y[1]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>4</term>
        ///        <description><c>f({x[0], y[0], x[1], y[1]}, {x[2], y[2], x[3], y[3]}) = ({x[0], x[1], x[2], x[3]}, {y[0], y[1], y[2], y[3]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>8</term>
        ///        <description><c>f({x[0], y[0], x[1], y[1], x[2], y[2], x[3], y[3]}, {x[4], y[4], x[5], y[5], x[6], y[6], x[7], y[7]}) = ({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>16</term>
        ///        <description><c>f({x[0], y[0], x[1], y[1], x[2], y[2], x[3], y[3], x[4], y[4], x[5], y[5], x[6], y[6], x[7], y[7]}, {x[8], y[8], x[9], y[9], x[10], y[10], x[11], y[11], x[12], y[12], x[13], y[13], x[14], y[14], x[15], y[15]}) = ({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8], x[9], x[10], x[11], x[12], x[13], x[14], x[15]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7], y[8], y[9], y[10], y[11], y[12], y[13], y[14], y[15]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>...</term>
        ///        <description>...</description>
        ///    </item>
        /// </list>
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
        ///        <description><see cref="AdvSimd.Arm64.UnzipEven(Vector128{byte}, Vector128{byte})">vuzp1q_u8</see>,<see cref="AdvSimd.Arm64.UnzipOdd(Vector128{byte}, Vector128{byte})">vuzp2q_u8</see></description>
        ///        <description><see cref="AdvSimd.Arm64.UnzipEven(Vector128{ushort}, Vector128{ushort})">vuzp1q_u16</see>,<see cref="AdvSimd.Arm64.UnzipOdd(Vector128{ushort}, Vector128{ushort})">vuzp2q_u16</see></description>
        ///        <description><see cref="AdvSimd.Arm64.UnzipEven(Vector128{uint}, Vector128{uint})">vuzp1q_u32</see>,<see cref="AdvSimd.Arm64.UnzipOdd(Vector128{uint}, Vector128{uint})">vuzp2q_u32</see></description>
        ///        <description><see cref="AdvSimd.Arm64.UnzipEven(Vector128{ulong}, Vector128{ulong})">vuzp1q_u64</see>,<see cref="AdvSimd.Arm64.UnzipOdd(Vector128{ulong}, Vector128{ulong})">vuzp2q_u64</see></description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YGroup2Unzip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
        TypeCodeFlags YGroup2Unzip_AcceleratedTypes { get; }

        /// <summary>
        /// De-Interleave 2-element groups into 2 vectors. It converts the 2-element groups AoS to SoA (将2-元素组解交织为2个向量. 它能将2元素组的 数组结构体 转为 结构体数组).
        /// Mnemonic: <c>x[i] =: element_ref(2*i, data0, data1)</c>, <c>y[i] =: element_ref(2*i+1, data0, data1)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 2-element groups - Part 0 (由2元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 2-element groups - Part 1 (由2元素组所组成的向量 - 第1部分).</param>
        /// <param name="y">Returns the vector made of the Y-components (返回Y分量所组成的向量).</param>
        /// <returns>Returns the vector made of the X-components (返回X分量所组成的向量).</returns>
        /// <seealso cref="YGroup2Unzip_AcceleratedTypes"/>
        Vector128<float> YGroup2Unzip(Vector128<float> data0, Vector128<float> data1, out Vector128<float> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup2Unzip(Vector128<double> data0, Vector128<double> data1, out Vector128<double> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup2Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup2Unzip(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup2Unzip(Vector128<short> data0, Vector128<short> data1, out Vector128<short> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup2Unzip(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup2Unzip(Vector128<int> data0, Vector128<int> data1, out Vector128<int> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup2Unzip(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup2Unzip(Vector128<long> data0, Vector128<long> data1, out Vector128<long> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup2Unzip(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<ExInt128> YGroup2Unzip(Vector128<ExInt128> data0, Vector128<ExInt128> data1, out Vector128<ExInt128> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<ExUInt128> YGroup2Unzip(Vector128<ExUInt128> data0, Vector128<ExUInt128> data1, out Vector128<ExUInt128> y);

        /// <summary>
        /// De-Interleave 2-element groups into 2 vectors. It converts the 2-element groups AoS to SoA (将2-元素组解交织为2个向量. 它能将2元素组的 数组结构体 转为 结构体数组). It is specialized for process 128-bit element (它专门用于处理128位元素).
        /// Mnemonic: <c>x[i] =: element_ref(2*i, data0, data1)</c>, <c>y[i] =: element_ref(2*i+1, data0, data1)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="data0">A vector made of 2-element groups - Part 0 (由2元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 2-element groups - Part 1 (由2元素组所组成的向量 - 第1部分).</param>
        /// <param name="y">Returns the vector made of the Y-components (返回Y分量所组成的向量).</param>
        /// <returns>Returns the vector made of the X-components (返回X分量所组成的向量).</returns>
        /// <seealso cref="YGroup2Unzip_AcceleratedTypes"/>
        Vector128<T> YGroup2Unzip_Bit128<T>(Vector128<T> data0, Vector128<T> data1, out Vector128<T> y) where T : struct;

        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2UnzipEven</c> (运行 <c>YGroup2UnzipEven</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2UnzipEven + YGroup2UnzipOdd = YGroup2Unzip</c>. See more: <see cref="YGroup2Unzip_AcceleratedTypes"/>.</para>
        /// </remarks>
        /// <seealso cref="YGroup2UnzipEven(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes { get; }

        /// <summary>
        /// De-Interleave the 2-element groups into 2 vectors, and return the vector of even positions (将2-元素组解交织为2个向量, 并返回偶数位置的数据).
        /// Mnemonic: <c>rt[i] =: element_ref(2*i, data0, data1)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 2-element groups - Part 0 (由2元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 2-element groups - Part 1 (由2元素组所组成的向量 - 第1部分).</param>
        /// <returns>Returns the vector made of the X-components (返回X分量所组成的向量).</returns>
        /// <seealso cref="YGroup2UnzipEven_AcceleratedTypes"/>
        Vector128<float> YGroup2UnzipEven(Vector128<float> data0, Vector128<float> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        Vector128<double> YGroup2UnzipEven(Vector128<double> data0, Vector128<double> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        Vector128<sbyte> YGroup2UnzipEven(Vector128<sbyte> data0, Vector128<sbyte> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        Vector128<byte> YGroup2UnzipEven(Vector128<byte> data0, Vector128<byte> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        Vector128<short> YGroup2UnzipEven(Vector128<short> data0, Vector128<short> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        Vector128<ushort> YGroup2UnzipEven(Vector128<ushort> data0, Vector128<ushort> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        Vector128<int> YGroup2UnzipEven(Vector128<int> data0, Vector128<int> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        Vector128<uint> YGroup2UnzipEven(Vector128<uint> data0, Vector128<uint> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        Vector128<long> YGroup2UnzipEven(Vector128<long> data0, Vector128<long> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        Vector128<ulong> YGroup2UnzipEven(Vector128<ulong> data0, Vector128<ulong> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        Vector128<ExInt128> YGroup2UnzipEven(Vector128<ExInt128> data0, Vector128<ExInt128> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
        Vector128<ExUInt128> YGroup2UnzipEven(Vector128<ExUInt128> data0, Vector128<ExUInt128> data1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2UnzipOdd</c> (运行 <c>YGroup2UnzipOdd</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2UnzipEven + YGroup2UnzipOdd = YGroup2Unzip</c>. See more: <see cref="YGroup2Unzip_AcceleratedTypes"/>.</para>
        /// </remarks>
        /// <seealso cref="YGroup2UnzipOdd(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes { get; }

        /// <summary>
        /// De-Interleave the 2-element groups into 2 vectors, and return the vector of odd positions (将2-元素组解交织为2个向量, 并返回奇数位置的数据).
        /// Mnemonic: <c>rt[i] =: element_ref(2*i+1, data0, data1)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 2-element groups - Part 0 (由2元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 2-element groups - Part 1 (由2元素组所组成的向量 - 第1部分).</param>
        /// <returns>Returns the vector made of the Y-components (返回Y分量所组成的向量).</returns>
        /// <seealso cref="YGroup2UnzipOdd_AcceleratedTypes"/>
        Vector128<float> YGroup2UnzipOdd(Vector128<float> data0, Vector128<float> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        Vector128<double> YGroup2UnzipOdd(Vector128<double> data0, Vector128<double> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        Vector128<sbyte> YGroup2UnzipOdd(Vector128<sbyte> data0, Vector128<sbyte> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        Vector128<byte> YGroup2UnzipOdd(Vector128<byte> data0, Vector128<byte> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        Vector128<short> YGroup2UnzipOdd(Vector128<short> data0, Vector128<short> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        Vector128<ushort> YGroup2UnzipOdd(Vector128<ushort> data0, Vector128<ushort> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        Vector128<int> YGroup2UnzipOdd(Vector128<int> data0, Vector128<int> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        Vector128<uint> YGroup2UnzipOdd(Vector128<uint> data0, Vector128<uint> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        Vector128<long> YGroup2UnzipOdd(Vector128<long> data0, Vector128<long> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        Vector128<ulong> YGroup2UnzipOdd(Vector128<ulong> data0, Vector128<ulong> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        Vector128<ExInt128> YGroup2UnzipOdd(Vector128<ExInt128> data0, Vector128<ExInt128> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
        Vector128<ExUInt128> YGroup2UnzipOdd(Vector128<ExUInt128> data0, Vector128<ExUInt128> data1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2Zip</c> (运行 <c>YGroup2Zip</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2ZipLow + YGroup2ZipHigh = YGroup2Zip </c>.</para>
        /// <para>Inverse function (逆函数): <see cref="YGroup2Unzip_AcceleratedTypes">YGroup2Unzip</see>.</para>
        /// <para>Sample (示例).</para>
        /// <list type="table">
        ///    <listheader>
        ///        <term>Elements</term>
        ///        <description>Result</description>
        ///    </listheader>
        ///    <item>
        ///        <term>1</term>
        ///        <description><c>f({x[0]}, {y[0]}) = ({x[0]}, {y[0]})</c>. (Fallback)</description>
        ///    </item>
        ///    <item>
        ///        <term>2</term>
        ///        <description><c>f({x[0], x[1]}, {y[0], y[1]}) = ({x[0], y[0]}, {x[1], y[1]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>4</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3]}, {y[0], y[1], y[2], y[3]}) = ({x[0], y[0], x[1], y[1]}, {x[2], y[2], x[3], y[3]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>8</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7]}) = ({x[0], y[0], x[1], y[1], x[2], y[2], x[3], y[3]}, {x[4], y[4], x[5], y[5], x[6], y[6], x[7], y[7]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>16</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8], x[9], x[10], x[11], x[12], x[13], x[14], x[15]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7], y[8], y[9], y[10], y[11], y[12], y[13], y[14], y[15]}) = ({x[0], y[0], x[1], y[1], x[2], y[2], x[3], y[3], x[4], y[4], x[5], y[5], x[6], y[6], x[7], y[7]}, {x[8], y[8], x[9], y[9], x[10], y[10], x[11], y[11], x[12], y[12], x[13], y[13], x[14], y[14], x[15], y[15]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>...</term>
        ///        <description>...</description>
        ///    </item>
        /// </list>
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
        ///        <description><see cref="AdvSimd.Arm64.ZipLow(Vector128{byte}, Vector128{byte})">vzip1q_u8</see>,<see cref="AdvSimd.Arm64.ZipHigh(Vector128{byte}, Vector128{byte})">vzip2q_u8</see></description>
        ///        <description><see cref="AdvSimd.Arm64.ZipLow(Vector128{ushort}, Vector128{ushort})">vzip1q_u16</see>,<see cref="AdvSimd.Arm64.ZipHigh(Vector128{ushort}, Vector128{ushort})">vzip2q_u16</see></description>
        ///        <description><see cref="AdvSimd.Arm64.ZipLow(Vector128{uint}, Vector128{uint})">vzip1q_u32</see>,<see cref="AdvSimd.Arm64.ZipHigh(Vector128{uint}, Vector128{uint})">vzip2q_u32</see></description>
        ///        <description><see cref="AdvSimd.Arm64.ZipLow(Vector128{ulong}, Vector128{ulong})">vzip1q_u64</see>,<see cref="AdvSimd.Arm64.ZipHigh(Vector128{ulong}, Vector128{ulong})">vzip2q_u64</see></description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description><see cref="Sse2.UnpackLow(Vector128{byte}, Vector128{byte})">_mm_unpacklo_epi8</see>,<see cref="Sse2.UnpackHigh(Vector128{byte}, Vector128{byte})">_mm_unpackhi_epi8</see>(Sse2)</description>
        ///        <description><see cref="Sse2.UnpackLow(Vector128{ushort}, Vector128{ushort})">_mm_unpacklo_epi16</see>,<see cref="Sse2.UnpackHigh(Vector128{ushort}, Vector128{ushort})">_mm_unpackhi_epi16</see>(Sse2)</description>
        ///        <description><see cref="Sse2.UnpackLow(Vector128{uint}, Vector128{uint})">_mm_unpacklo_epi32</see>,<see cref="Sse2.UnpackHigh(Vector128{uint}, Vector128{uint})">_mm_unpackhi_epi32</see>(Sse2)</description>
        ///        <description><see cref="Sse2.UnpackLow(Vector128{ulong}, Vector128{ulong})">_mm_unpacklo_epi64</see>,<see cref="Sse2.UnpackHigh(Vector128{ulong}, Vector128{ulong})">_mm_unpackhi_epi64</see>(Sse2)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YGroup2Zip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
        TypeCodeFlags YGroup2Zip_AcceleratedTypes { get; }

        /// <summary>
        /// Interleave 2 vectors into 2-element groups. It converts the 2-element groups SoA to AoS (将2个向量交织为2-元素组. 它能将2元素组的 结构体数组 转为 数组结构体).
        /// Mnemonic: <c>element_ref(i, data0, data1) := (0==(i&amp;1))?( x[i2] ):( y[i2] )</c>, <c>i2 := i/2</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <param name="data1">Returns part 1 of the interleaved data (返回交织后数据的第1部分).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        /// <seealso cref="YGroup2Zip_AcceleratedTypes"/>
        Vector128<float> YGroup2Zip(Vector128<float> x, Vector128<float> y, out Vector128<float> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup2Zip(Vector128<double> x, Vector128<double> y, out Vector128<double> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup2Zip(Vector128<sbyte> x, Vector128<sbyte> y, out Vector128<sbyte> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup2Zip(Vector128<byte> x, Vector128<byte> y, out Vector128<byte> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup2Zip(Vector128<short> x, Vector128<short> y, out Vector128<short> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup2Zip(Vector128<ushort> x, Vector128<ushort> y, out Vector128<ushort> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup2Zip(Vector128<int> x, Vector128<int> y, out Vector128<int> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup2Zip(Vector128<uint> x, Vector128<uint> y, out Vector128<uint> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup2Zip(Vector128<long> x, Vector128<long> y, out Vector128<long> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup2Zip(Vector128<ulong> x, Vector128<ulong> y, out Vector128<ulong> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<ExInt128> YGroup2Zip(Vector128<ExInt128> x, Vector128<ExInt128> y, out Vector128<ExInt128> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
        Vector128<ExUInt128> YGroup2Zip(Vector128<ExUInt128> x, Vector128<ExUInt128> y, out Vector128<ExUInt128> data1);

        /// <summary>
        /// Interleave 2 vectors into 2-element groups. It converts the 2-element groups SoA to AoS (将2个向量交织为2-元素组. 它能将2元素组的 结构体数组 转为 数组结构体). It is specialized for process 128-bit element (它专门用于处理128位元素).
        /// Mnemonic: <c>element_ref(i, data0, data1) := (0==(i&amp;1))?( x[i2] ):( y[i2] )</c>, <c>i2 := i/2</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <param name="data1">Returns part 1 of the interleaved data (返回交织后数据的第1部分).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        /// <seealso cref="YGroup2Zip_AcceleratedTypes"/>
        Vector128<T> YGroup2Zip_Bit128<T>(Vector128<T> x, Vector128<T> y, out Vector128<T> data1) where T : struct;

        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2ZipHigh</c> (运行 <c>YGroup2ZipHigh</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2ZipLow + YGroup2ZipHigh = YGroup2Zip </c>. See more: <see cref="YGroup2Zip_AcceleratedTypes"/>.</para>
        /// </remarks>
        /// <seealso cref="YGroup2ZipHigh(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes { get; }

        /// <summary>
        /// Interleave 2 vectors into 2-element groups and returns the data in the high position. (将2个向量交织为2-元素组, 并返回高位置的数据).
        /// Mnemonic: <c>rt[i] := (0==(i&amp;1))?( x[i2] ):( y[i2] )</c>, <c>i2 := (i+T.Count)/2</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <returns>Returns part 1 of the interleaved data (返回交织后数据的第1部分).</returns>
        /// <seealso cref="YGroup2ZipHigh_AcceleratedTypes"/>
        Vector128<float> YGroup2ZipHigh(Vector128<float> x, Vector128<float> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        Vector128<double> YGroup2ZipHigh(Vector128<double> x, Vector128<double> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        Vector128<sbyte> YGroup2ZipHigh(Vector128<sbyte> x, Vector128<sbyte> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        Vector128<byte> YGroup2ZipHigh(Vector128<byte> x, Vector128<byte> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        Vector128<short> YGroup2ZipHigh(Vector128<short> x, Vector128<short> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        Vector128<ushort> YGroup2ZipHigh(Vector128<ushort> x, Vector128<ushort> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        Vector128<int> YGroup2ZipHigh(Vector128<int> x, Vector128<int> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        Vector128<uint> YGroup2ZipHigh(Vector128<uint> x, Vector128<uint> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        Vector128<long> YGroup2ZipHigh(Vector128<long> x, Vector128<long> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        Vector128<ulong> YGroup2ZipHigh(Vector128<ulong> x, Vector128<ulong> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        Vector128<ExInt128> YGroup2ZipHigh(Vector128<ExInt128> x, Vector128<ExInt128> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
        Vector128<ExUInt128> YGroup2ZipHigh(Vector128<ExUInt128> x, Vector128<ExUInt128> y);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2ZipLow</c> (运行 <c>YGroup2ZipLow</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2ZipLow + YGroup2ZipHigh = YGroup2Zip </c>. See more: <see cref="YGroup2Zip_AcceleratedTypes"/>.</para>
        /// </remarks>
        /// <seealso cref="YGroup2ZipLow(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags YGroup2ZipLow_AcceleratedTypes { get; }

        /// <summary>
        /// Interleave 2 vectors into 2-element groups and returns the data in the low position. (将2个向量交织为2-元素组, 并返回低位置的数据).
        /// Mnemonic: <c>rt[i] := (0==(i&amp;1))?( x[i2] ):( y[i2] )</c>, <c>i2 := i/2</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        /// <seealso cref="YGroup2ZipLow_AcceleratedTypes"/>
        Vector128<float> YGroup2ZipLow(Vector128<float> x, Vector128<float> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        Vector128<double> YGroup2ZipLow(Vector128<double> x, Vector128<double> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        Vector128<sbyte> YGroup2ZipLow(Vector128<sbyte> x, Vector128<sbyte> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        Vector128<byte> YGroup2ZipLow(Vector128<byte> x, Vector128<byte> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        Vector128<short> YGroup2ZipLow(Vector128<short> x, Vector128<short> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        Vector128<ushort> YGroup2ZipLow(Vector128<ushort> x, Vector128<ushort> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        Vector128<int> YGroup2ZipLow(Vector128<int> x, Vector128<int> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        Vector128<uint> YGroup2ZipLow(Vector128<uint> x, Vector128<uint> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        Vector128<long> YGroup2ZipLow(Vector128<long> x, Vector128<long> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        Vector128<ulong> YGroup2ZipLow(Vector128<ulong> x, Vector128<ulong> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        Vector128<ExInt128> YGroup2ZipLow(Vector128<ExInt128> x, Vector128<ExInt128> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
        Vector128<ExUInt128> YGroup2ZipLow(Vector128<ExUInt128> x, Vector128<ExUInt128> y);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup3ToGroup4</c> (运行 <c>YGroup3ToGroup4</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (逆函数): <see cref="YGroup4ToGroup3_AcceleratedTypes">YGroup4ToGroup3</see>.</para>
        /// <para>Sample (示例).</para>
        /// <list type="table">
        ///    <listheader>
        ///        <term>Elements</term>
        ///        <description>Result</description>
        ///    </listheader>
        ///    <item>
        ///        <term>1</term>
        ///        <description><c>f({x[0]}, {y[0]}, {z[0]}) = ({x[0]}, {y[0]}, {z[0]}, {0})</c>. (Fallback)</description>
        ///    </item>
        ///    <item>
        ///        <term>2</term>
        ///        <description><c>f({x[0], y[0]}, {z[0], x[1]}, {y[1], z[1]}) = ({x[0], y[0]}, {z[0], 0}, {x[1], y[1]}, {z[1], 0})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>4</term>
        ///        <description><c>f({x[0], y[0], z[0], x[1]}, {y[1], z[1], x[2], y[2]}, {z[2], x[3], y[3], z[3]}) = ({x[0], y[0], z[0], 0}, {x[1], y[1], z[1], 0}, {x[2], y[2], z[2], 0}, {x[3], y[3], z[3], 0})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>8</term>
        ///        <description><c>f({x[0], y[0], z[0], x[1], y[1], z[1], x[2], y[2]}, {z[2], x[3], y[3], z[3], x[4], y[4], z[4], x[5]}, {y[5], z[5], x[6], y[6], z[6], x[7], y[7], z[7]}) = ({x[0], y[0], z[0], 0, x[1], y[1], z[1], 0}, {x[2], y[2], z[2], 0, x[3], y[3], z[3], 0}, {x[4], y[4], z[4], 0, x[5], y[5], z[5], 0}, {x[6], y[6], z[6], 0, x[7], y[7], z[7], 0})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>16</term>
        ///        <description><c>f({x[0], y[0], z[0], x[1], y[1], z[1], x[2], y[2], z[2], x[3], y[3], z[3], x[4], y[4], z[4], x[5]}, {y[5], z[5], x[6], y[6], z[6], x[7], y[7], z[7], x[8], y[8], z[8], x[9], y[9], z[9], x[10], y[10]}, {z[10], x[11], y[11], z[11], x[12], y[12], z[12], x[13], y[13], z[13], x[14], y[14], z[14], x[15], y[15], z[15]}) = ({x[0], y[0], z[0], 0, x[1], y[1], z[1], 0, x[2], y[2], z[2], 0, x[3], y[3], z[3], 0}, {x[4], y[4], z[4], 0, x[5], y[5], z[5], 0, x[6], y[6], z[6], 0, x[7], y[7], z[7], 0}, {x[8], y[8], z[8], 0, x[9], y[9], z[9], 0, x[10], y[10], z[10], 0, x[11], y[11], z[11], 0, {x[12], y[12], z[12], 0, x[13], y[13], z[13], 0, x[14], y[14], z[14], 0, x[15], y[15], z[15], 0})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>...</term>
        ///        <description>...</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YGroup3ToGroup4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup4ToGroup3_AcceleratedTypes"/>
        /// <seealso cref="YGroup3Unzip_AcceleratedTypes"/>
        /// <seealso cref="YGroup4Zip_AcceleratedTypes"/>
        TypeCodeFlags YGroup3ToGroup4_AcceleratedTypes { get; }

        /// <summary>
        /// Convert a 3-element group, to a 4-element group. It also converts packed RGB pixel data to packed RGBA pixel data (将3-元素组, 转为4-元素组. 它还能将 已打包的RGB像素数据, 转换为 已打包的RGBA像素数据).
        /// Mnemonic: View for group: <c>(result0, result1, result2, result3) = YGroup4Zip(YGroup3Unzip(data0, data1, data2), Vector.Zero))</c>. View for element: <c>element_ref(i, result0, result1, result2, result3) := (3!=(i%4))?element_ref((i/4)*3+(i%4), data0, data1, data2):0</c>.
        /// </summary>
        /// <param name="data0">A vector made of 4-element groups - Part 0 (由4元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 4-element groups - Part 1 (由4元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 4-element groups - Part 2 (由4元素组所组成的向量 - 第2部分).</param>
        /// <param name="result1">Returns part 1 of the converted data (返回转换后数据的第1部分).</param>
        /// <param name="result2">Returns part 2 of the converted data (返回转换后数据的第2部分).</param>
        /// <param name="result3">Returns part 3 of the converted data (返回转换后数据的第3部分).</param>
        /// <returns>Returns part 0 of the converted data (返回转换后数据的第0部分).</returns>
        /// <seealso cref="YGroup3ToGroup4_AcceleratedTypes"/>
        Vector128<float> YGroup3ToGroup4(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup3ToGroup4(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup3ToGroup4(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup3ToGroup4(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup3ToGroup4(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup3ToGroup4(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup3ToGroup4(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup3ToGroup4(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup3ToGroup4(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup3ToGroup4(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup3Unzip</c> (运行 <c>YGroup3Unzip</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (逆函数): <see cref="YGroup3Zip_AcceleratedTypes">YGroup3Zip</see>.</para>
        /// <para>Sample (示例).</para>
        /// <list type="table">
        ///    <listheader>
        ///        <term>Elements</term>
        ///        <description>Result</description>
        ///    </listheader>
        ///    <item>
        ///        <term>1</term>
        ///        <description><c>f({x[0]}, {y[0]}, {z[0]}) = ({x[0]}, {y[0]}, {z[0]})</c>. (Fallback)</description>
        ///    </item>
        ///    <item>
        ///        <term>2</term>
        ///        <description><c>f({x[0], y[0]}, {z[0], x[1]}, {y[1], z[1]}) = ({x[0], x[1]}, {y[0], y[1]}, {z[0], z[1]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>4</term>
        ///        <description><c>f({x[0], y[0], z[0], x[1]}, {y[1], z[1], x[2], y[2]}, {z[2], x[3], y[3], z[3]}) = ({x[0], x[1], x[2], x[3]}, {y[0], y[1], y[2], y[3]}, {z[0], z[1], z[2], z[3]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>8</term>
        ///        <description><c>f({x[0], y[0], z[0], x[1], y[1], z[1], x[2], y[2]}, {z[2], x[3], y[3], z[3], x[4], y[4], z[4], x[5]}, {y[5], z[5], x[6], y[6], z[6], x[7], y[7], z[7]}) = ({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7]}, {z[0], z[1], z[2], z[3], z[4], z[5], z[6], z[7]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>16</term>
        ///        <description><c>f({x[0], y[0], z[0], x[1], y[1], z[1], x[2], y[2], z[2], x[3], y[3], z[3], x[4], y[4], z[4], x[5]}, {y[5], z[5], x[6], y[6], z[6], x[7], y[7], z[7], x[8], y[8], z[8], x[9], y[9], z[9], x[10], y[10]}, {z[10], x[11], y[11], z[11], x[12], y[12], z[12], x[13], y[13], z[13], x[14], y[14], z[14], x[15], y[15], z[15]}) = ({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8], x[9], x[10], x[11], x[12], x[13], x[14], x[15]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7], y[8], y[9], y[10], y[11], y[12], y[13], y[14], y[15]}, {z[0], z[1], z[2], z[3], z[4], z[5], z[6], z[7], z[8], z[9], z[10], z[11], z[12], z[13], z[14], z[15]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>...</term>
        ///        <description>...</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YGroup3Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup3Zip_AcceleratedTypes"/>
        /// <seealso cref="YGroup3UnzipX2_AcceleratedTypes"/>
        TypeCodeFlags YGroup3Unzip_AcceleratedTypes { get; }

        /// <summary>
        /// De-Interleave 3-element groups into 3 vectors. It converts the 3-element groups AoS to SoA. It can also deinterleave packed RGB pixel data into R,G,B planar data (将3-元素组解交织为3个向量. 它能将3元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGB像素数据, 解交织为 R,G,B 平面数据).
        /// Mnemonic: <c>x[i] =: element_ref(3*i, data0, data1, data2)</c>, <c>y[i] =: element_ref(3*i+1, data0, data1, data2)</c>, <c>z[i] =: element_ref(3*i+2, data0, data1, data2)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 3-element groups - Part 0 (由3元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 3-element groups - Part 1 (由3元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 3-element groups - Part 2 (由3元素组所组成的向量 - 第2部分).</param>
        /// <param name="y">Returns the vector made of the Y-components (返回Y分量所组成的向量).</param>
        /// <param name="z">Returns the vector made of the Z-components (返回Z分量所组成的向量).</param>
        /// <returns>Returns the vector made of the X-components (返回X分量所组成的向量).</returns>
        /// <seealso cref="YGroup3Unzip_AcceleratedTypes"/>
        Vector128<float> YGroup3Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> y, out Vector128<float> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup3Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> y, out Vector128<double> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup3Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> y, out Vector128<sbyte> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup3Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> y, out Vector128<byte> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup3Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> y, out Vector128<short> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup3Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> y, out Vector128<ushort> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup3Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> y, out Vector128<int> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup3Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> y, out Vector128<uint> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup3Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> y, out Vector128<long> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup3Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> y, out Vector128<ulong> z);

        /// <summary>
        /// De-Interleave 3-element groups into 3 vectors. It converts the 3-element groups AoS to SoA. It can also deinterleave packed RGB pixel data into R,G,B planar data (将3-元素组解交织为3个向量. 它能将3元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGB像素数据, 解交织为 R,G,B 平面数据). It is specialized for process 128-bit element (它专门用于处理128位元素).
        /// Mnemonic: <c>x[i] =: element_ref(3*i, data0, data1, data2)</c>, <c>y[i] =: element_ref(3*i+1, data0, data1, data2)</c>, <c>z[i] =: element_ref(3*i+2, data0, data1, data2)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="data0">A vector made of 3-element groups - Part 0 (由3元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 3-element groups - Part 1 (由3元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 3-element groups - Part 2 (由3元素组所组成的向量 - 第2部分).</param>
        /// <param name="y">Returns the vector made of the Y-components (返回Y分量所组成的向量).</param>
        /// <param name="z">Returns the vector made of the Z-components (返回Z分量所组成的向量).</param>
        /// <returns>Returns the vector made of the X-components (返回X分量所组成的向量).</returns>
        /// <seealso cref="YGroup3Unzip_AcceleratedTypes"/>
        Vector128<T> YGroup3Unzip_Bit128<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, out Vector128<T> y, out Vector128<T> z) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup3UnzipX2</c> (运行 <c>YGroup3UnzipX2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>It has the same functionality as the <see cref="YGroup3Unzip_AcceleratedTypes">YGroup3Unzip</see> method. It is optimized for process 2x data (它的功能与 <see cref="YGroup3Unzip_AcceleratedTypes">YGroup3Unzip</see> 方法相同. 它为处理2倍数据做了专门的优化).</para>
        /// <para>Inverse function (逆函数): <see cref="YGroup3ZipX2_AcceleratedTypes">YGroup3ZipX2</see>.</para>
        /// </remarks>
        /// <seealso cref="YGroup3UnzipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup3Unzip_AcceleratedTypes"/>
        TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes { get; }

        /// <summary>
        /// De-Interleave 3-element groups into 3 vectors and process 2x data (将3-元素组解交织为3个向量, 且处理2倍数据).
        /// Mnemonic: <c>(x, y, z) = YGroup3Unzip(data0, data1, data2)</c>, <c>(xB, yB, zB) = YGroup3Unzip(data3, data4, data5)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 3-element groups - Part 0 (由3元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 3-element groups - Part 1 (由3元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 3-element groups - Part 2 (由3元素组所组成的向量 - 第2部分).</param>
        /// <param name="data3">A vector made of 3-element groups - Part 3 (由3元素组所组成的向量 - 第3部分).</param>
        /// <param name="data4">A vector made of 3-element groups - Part 4 (由3元素组所组成的向量 - 第4部分).</param>
        /// <param name="data5">A vector made of 3-element groups - Part 5 (由3元素组所组成的向量 - 第5部分).</param>
        /// <param name="xB">Returns the vector made of the X-components - Part 1 (返回X分量所组成的向量 - 第1部分).</param>
        /// <param name="y">Returns the vector made of the Y-components - Part 0 (返回Y分量所组成的向量 - 第0部分).</param>
        /// <param name="yB">Returns the vector made of the Y-components - Part 1 (返回Y分量所组成的向量 - 第1部分).</param>
        /// <param name="z">Returns the vector made of the Z-components - Part 0 (返回Z分量所组成的向量 - 第0部分).</param>
        /// <param name="zB">Returns the vector made of the Z-components - Part 1 (返回Z分量所组成的向量 - 第1部分).</param>
        /// <returns>Returns the vector made of the X-components - Part 0 (返回X分量所组成的向量 - 第0部分).</returns>
        /// <seealso cref="YGroup3UnzipX2_AcceleratedTypes"/>
        Vector128<float> YGroup3UnzipX2(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, Vector128<float> data4, Vector128<float> data5, out Vector128<float> xB, out Vector128<float> y, out Vector128<float> yB, out Vector128<float> z, out Vector128<float> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup3UnzipX2(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, Vector128<double> data4, Vector128<double> data5, out Vector128<double> xB, out Vector128<double> y, out Vector128<double> yB, out Vector128<double> z, out Vector128<double> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup3UnzipX2(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, Vector128<sbyte> data4, Vector128<sbyte> data5, out Vector128<sbyte> xB, out Vector128<sbyte> y, out Vector128<sbyte> yB, out Vector128<sbyte> z, out Vector128<sbyte> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup3UnzipX2(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, Vector128<byte> data4, Vector128<byte> data5, out Vector128<byte> xB, out Vector128<byte> y, out Vector128<byte> yB, out Vector128<byte> z, out Vector128<byte> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup3UnzipX2(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, Vector128<short> data4, Vector128<short> data5, out Vector128<short> xB, out Vector128<short> y, out Vector128<short> yB, out Vector128<short> z, out Vector128<short> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup3UnzipX2(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, Vector128<ushort> data4, Vector128<ushort> data5, out Vector128<ushort> xB, out Vector128<ushort> y, out Vector128<ushort> yB, out Vector128<ushort> z, out Vector128<ushort> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup3UnzipX2(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, Vector128<int> data4, Vector128<int> data5, out Vector128<int> xB, out Vector128<int> y, out Vector128<int> yB, out Vector128<int> z, out Vector128<int> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup3UnzipX2(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, Vector128<uint> data4, Vector128<uint> data5, out Vector128<uint> xB, out Vector128<uint> y, out Vector128<uint> yB, out Vector128<uint> z, out Vector128<uint> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup3UnzipX2(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, Vector128<long> data4, Vector128<long> data5, out Vector128<long> xB, out Vector128<long> y, out Vector128<long> yB, out Vector128<long> z, out Vector128<long> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup3UnzipX2(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, Vector128<ulong> data4, Vector128<ulong> data5, out Vector128<ulong> xB, out Vector128<ulong> y, out Vector128<ulong> yB, out Vector128<ulong> z, out Vector128<ulong> zB);

        /// <summary>
        /// De-Interleave 3-element groups into 3 vectors and process 2x data (将3-元素组解交织为3个向量, 且处理2倍数据). It is specialized for process 128-bit element (它专门用于处理128位元素).
        /// Mnemonic: <c>(x, y, z) = YGroup3Unzip(data0, data1, data2)</c>, <c>(xB, yB, zB) = YGroup3Unzip(data3, data4, data5)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="data0">A vector made of 3-element groups - Part 0 (由3元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 3-element groups - Part 1 (由3元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 3-element groups - Part 2 (由3元素组所组成的向量 - 第2部分).</param>
        /// <param name="data3">A vector made of 3-element groups - Part 3 (由3元素组所组成的向量 - 第3部分).</param>
        /// <param name="data4">A vector made of 3-element groups - Part 4 (由3元素组所组成的向量 - 第4部分).</param>
        /// <param name="data5">A vector made of 3-element groups - Part 5 (由3元素组所组成的向量 - 第5部分).</param>
        /// <param name="xB">Returns the vector made of the X-components - Part 1 (返回X分量所组成的向量 - 第1部分).</param>
        /// <param name="y">Returns the vector made of the Y-components - Part 0 (返回Y分量所组成的向量 - 第0部分).</param>
        /// <param name="yB">Returns the vector made of the Y-components - Part 1 (返回Y分量所组成的向量 - 第1部分).</param>
        /// <param name="z">Returns the vector made of the Z-components - Part 0 (返回Z分量所组成的向量 - 第0部分).</param>
        /// <param name="zB">Returns the vector made of the Z-components - Part 1 (返回Z分量所组成的向量 - 第1部分).</param>
        /// <returns>Returns the vector made of the X-components - Part 0 (返回X分量所组成的向量 - 第0部分).</returns>
        /// <seealso cref="YGroup3UnzipX2_AcceleratedTypes"/>
        Vector128<T> YGroup3UnzipX2_Bit128<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3, Vector128<T> data4, Vector128<T> data5, out Vector128<T> xB, out Vector128<T> y, out Vector128<T> yB, out Vector128<T> z, out Vector128<T> zB) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup3Zip</c> (运行 <c>YGroup3Zip</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (逆函数): <see cref="YGroup3Unzip_AcceleratedTypes">YGroup3Unzip</see>.</para>
        /// <para>Sample (示例).</para>
        /// <list type="table">
        ///    <listheader>
        ///        <term>Elements</term>
        ///        <description>Result</description>
        ///    </listheader>
        ///    <item>
        ///        <term>1</term>
        ///        <description><c>f({x[0]}, {y[0]}, {z[0]}) = ({x[0]}, {y[0]}, {z[0]})</c>. (Fallback)</description>
        ///    </item>
        ///    <item>
        ///        <term>2</term>
        ///        <description><c>f({x[0], x[1]}, {y[0], y[1]}, {z[0], z[1]}) = ({x[0], y[0]}, {z[0], x[1]}, {y[1], z[1]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>4</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3]}, {y[0], y[1], y[2], y[3]}, {z[0], z[1], z[2], z[3]}) = ({x[0], y[0], z[0], x[1]}, {y[1], z[1], x[2], y[2]}, {z[2], x[3], y[3], z[3]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>8</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7]}, {z[0], z[1], z[2], z[3], z[4], z[5], z[6], z[7]}) = ({x[0], y[0], z[0], x[1], y[1], z[1], x[2], y[2]}, {z[2], x[3], y[3], z[3], x[4], y[4], z[4], x[5]}, {y[5], z[5], x[6], y[6], z[6], x[7], y[7], z[7]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>16</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8], x[9], x[10], x[11], x[12], x[13], x[14], x[15]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7], y[8], y[9], y[10], y[11], y[12], y[13], y[14], y[15]}, {z[0], z[1], z[2], z[3], z[4], z[5], z[6], z[7], z[8], z[9], z[10], z[11], z[12], z[13], z[14], z[15]}) = ({x[0], y[0], z[0], x[1], y[1], z[1], x[2], y[2], z[2], x[3], y[3], z[3], x[4], y[4], z[4], x[5]}, {y[5], z[5], x[6], y[6], z[6], x[7], y[7], z[7], x[8], y[8], z[8], x[9], y[9], z[9], x[10], y[10]}, {z[10], x[11], y[11], z[11], x[12], y[12], z[12], x[13], y[13], z[13], x[14], y[14], z[14], x[15], y[15], z[15]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>...</term>
        ///        <description>...</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YGroup3Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup3Unzip_AcceleratedTypes"/>
        /// <seealso cref="YGroup3ZipX2_AcceleratedTypes"/>
        TypeCodeFlags YGroup3Zip_AcceleratedTypes { get; }

        /// <summary>
        ///  Interleave 3 vectors into 3-element groups. It converts the 3-element groups SoA to AoS. It can also interleave R,G,B planar data into packed RGB pixel data (将3-元素组解交织为3个向量. 它能将3元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B 平面数据, 交织为 已打包的RGB像素数据).
        /// Mnemonic: <c>element_ref(i, data0, data1, data2) := (0==(i%3))?( x[i2] ):( (1==(i%3))?( y[i2] ):( z[i2] ) )</c>, <c>i2 := i/3</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <param name="z">A vector consisting purely of Z-components (纯由Z分量所组成的向量).</param>
        /// <param name="data1">Returns part 1 of the interleaved data (返回交织后数据的第1部分).</param>
        /// <param name="data2">Returns part 2 of the interleaved data (返回交织后数据的第2部分).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        Vector128<float> YGroup3Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, out Vector128<float> data1, out Vector128<float> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup3Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, out Vector128<double> data1, out Vector128<double> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup3Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, out Vector128<sbyte> data1, out Vector128<sbyte> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup3Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, out Vector128<byte> data1, out Vector128<byte> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup3Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, out Vector128<short> data1, out Vector128<short> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup3Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, out Vector128<ushort> data1, out Vector128<ushort> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup3Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, out Vector128<int> data1, out Vector128<int> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup3Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, out Vector128<uint> data1, out Vector128<uint> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup3Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, out Vector128<long> data1, out Vector128<long> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup3Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, out Vector128<ulong> data1, out Vector128<ulong> data2);

        /// <summary>
        ///  Interleave 3 vectors into 3-element groups. It converts the 3-element groups SoA to AoS. It can also interleave R,G,B planar data into packed RGB pixel data (将3-元素组解交织为3个向量. 它能将3元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B 平面数据, 交织为 已打包的RGB像素数据).
        /// Mnemonic: <c>element_ref(i, data0, data1, data2) := (0==(i%3))?( x[i2] ):( (1==(i%3))?( y[i2] ):( z[i2] ) )</c>, <c>i2 := i/3</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <param name="z">A vector consisting purely of Z-components (纯由Z分量所组成的向量).</param>
        /// <param name="data1">Returns part 1 of the interleaved data (返回交织后数据的第1部分).</param>
        /// <param name="data2">Returns part 2 of the interleaved data (返回交织后数据的第2部分).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        Vector128<T> YGroup3Zip_Bit128<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z, out Vector128<T> data1, out Vector128<T> data2) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup3ZipX2</c> (运行 <c>YGroup3ZipX2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (逆函数): <see cref="YGroup3UnzipX2_AcceleratedTypes">YGroup3UnzipX2</see>.</para>
        /// </remarks>
        /// <seealso cref="YGroup3ZipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup3Zip_AcceleratedTypes"/>
        TypeCodeFlags YGroup3ZipX2_AcceleratedTypes { get; }

        /// <summary>
        /// Interleave 3 vectors into 3-element groups and process 2x data (将3-元素组解交织为3个向量, 且处理2倍数据).
        /// Mnemonic: <c>(data0, data1, data2) = YGroup3Zip(x, y, z)</c>, <c>(data3, data4, data5) = YGroup3Zip(xB, yB, zB)</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components - Part 0 (纯由X分量所组成的向量 - 第0部分).</param>
        /// <param name="xB">A vector consisting purely of X-components - Part 1 (纯由X分量所组成的向量 - 第1部分).</param>
        /// <param name="y">A vector consisting purely of Y-components - Part 0 (纯由Y分量所组成的向量 - 第0部分).</param>
        /// <param name="yB">A vector consisting purely of Y-components - Part 1 (纯由Y分量所组成的向量 - 第1部分).</param>
        /// <param name="z">A vector consisting purely of Z-components - Part 0 (纯由Z分量所组成的向量 - 第0部分).</param>
        /// <param name="zB">A vector consisting purely of Z-components - Part 1 (纯由Z分量所组成的向量 - 第1部分).</param>
        /// <param name="data1">Returns part 1 of the interleaved data (返回交织后数据的第1部分).</param>
        /// <param name="data2">Returns part 2 of the interleaved data (返回交织后数据的第2部分).</param>
        /// <param name="data3">Returns part 3 of the interleaved data (返回交织后数据的第3部分).</param>
        /// <param name="data4">Returns part 4 of the interleaved data (返回交织后数据的第4部分).</param>
        /// <param name="data5">Returns part 5 of the interleaved data (返回交织后数据的第5部分).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        Vector128<float> YGroup3ZipX2(Vector128<float> x, Vector128<float> xB, Vector128<float> y, Vector128<float> yB, Vector128<float> z, Vector128<float> zB, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3, out Vector128<float> data4, out Vector128<float> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup3ZipX2(Vector128<double> x, Vector128<double> xB, Vector128<double> y, Vector128<double> yB, Vector128<double> z, Vector128<double> zB, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3, out Vector128<double> data4, out Vector128<double> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup3ZipX2(Vector128<sbyte> x, Vector128<sbyte> xB, Vector128<sbyte> y, Vector128<sbyte> yB, Vector128<sbyte> z, Vector128<sbyte> zB, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3, out Vector128<sbyte> data4, out Vector128<sbyte> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup3ZipX2(Vector128<byte> x, Vector128<byte> xB, Vector128<byte> y, Vector128<byte> yB, Vector128<byte> z, Vector128<byte> zB, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3, out Vector128<byte> data4, out Vector128<byte> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup3ZipX2(Vector128<short> x, Vector128<short> xB, Vector128<short> y, Vector128<short> yB, Vector128<short> z, Vector128<short> zB, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3, out Vector128<short> data4, out Vector128<short> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup3ZipX2(Vector128<ushort> x, Vector128<ushort> xB, Vector128<ushort> y, Vector128<ushort> yB, Vector128<ushort> z, Vector128<ushort> zB, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3, out Vector128<ushort> data4, out Vector128<ushort> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup3ZipX2(Vector128<int> x, Vector128<int> xB, Vector128<int> y, Vector128<int> yB, Vector128<int> z, Vector128<int> zB, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3, out Vector128<int> data4, out Vector128<int> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup3ZipX2(Vector128<uint> x, Vector128<uint> xB, Vector128<uint> y, Vector128<uint> yB, Vector128<uint> z, Vector128<uint> zB, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3, out Vector128<uint> data4, out Vector128<uint> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup3ZipX2(Vector128<long> x, Vector128<long> xB, Vector128<long> y, Vector128<long> yB, Vector128<long> z, Vector128<long> zB, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3, out Vector128<long> data4, out Vector128<long> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup3ZipX2(Vector128<ulong> x, Vector128<ulong> xB, Vector128<ulong> y, Vector128<ulong> yB, Vector128<ulong> z, Vector128<ulong> zB, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3, out Vector128<ulong> data4, out Vector128<ulong> data5);

        /// <summary>
        /// Interleave 3 vectors into 3-element groups and process 2x data (将3-元素组解交织为3个向量, 且处理2倍数据).
        /// Mnemonic: <c>(data0, data1, data2) = YGroup3Zip(x, y, z)</c>, <c>(data3, data4, data5) = YGroup3Zip(xB, yB, zB)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="x">A vector consisting purely of X-components - Part 0 (纯由X分量所组成的向量 - 第0部分).</param>
        /// <param name="xB">A vector consisting purely of X-components - Part 1 (纯由X分量所组成的向量 - 第1部分).</param>
        /// <param name="y">A vector consisting purely of Y-components - Part 0 (纯由Y分量所组成的向量 - 第0部分).</param>
        /// <param name="yB">A vector consisting purely of Y-components - Part 1 (纯由Y分量所组成的向量 - 第1部分).</param>
        /// <param name="z">A vector consisting purely of Z-components - Part 0 (纯由Z分量所组成的向量 - 第0部分).</param>
        /// <param name="zB">A vector consisting purely of Z-components - Part 1 (纯由Z分量所组成的向量 - 第1部分).</param>
        /// <param name="data1">Returns part 1 of the interleaved data (返回交织后数据的第1部分).</param>
        /// <param name="data2">Returns part 2 of the interleaved data (返回交织后数据的第2部分).</param>
        /// <param name="data3">Returns part 3 of the interleaved data (返回交织后数据的第3部分).</param>
        /// <param name="data4">Returns part 4 of the interleaved data (返回交织后数据的第4部分).</param>
        /// <param name="data5">Returns part 5 of the interleaved data (返回交织后数据的第5部分).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        Vector128<T> YGroup3ZipX2_Bit128<T>(Vector128<T> x, Vector128<T> xB, Vector128<T> y, Vector128<T> yB, Vector128<T> z, Vector128<T> zB, out Vector128<T> data1, out Vector128<T> data2, out Vector128<T> data3, out Vector128<T> data4, out Vector128<T> data5) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup4ToGroup3</c> (运行 <c>YGroup4ToGroup3</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (逆函数): <see cref="YGroup3ToGroup4_AcceleratedTypes">YGroup4ToYGroup4</see>.</para>
        /// <para>Sample (示例).</para>
        /// <list type="table">
        ///    <listheader>
        ///        <term>Elements</term>
        ///        <description>Result</description>
        ///    </listheader>
        ///    <item>
        ///        <term>1</term>
        ///        <description><c>f({x[0]}, {y[0]}, {z[0]}, w[0]) = ({x[0]}, {y[0]}, {z[0]})</c>. (Fallback)</description>
        ///    </item>
        ///    <item>
        ///        <term>2</term>
        ///        <description><c>f({x[0], y[0]}, {z[0], w[0]}, {x[1], y[1]}, {z[1], w[1]}) = ({x[0], y[0]}, {z[0], x[1]}, {y[1], z[1]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>4</term>
        ///        <description><c>f({x[0], y[0], z[0], w[0]}, {x[1], y[1], z[1], w[1]}, {x[2], y[2], z[2], w[2]}, {x[3], y[3], z[3], w[3]}) = ({x[0], y[0], z[0], x[1]}, {y[1], z[1], x[2], y[2]}, {z[2], x[3], y[3], z[3]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>8</term>
        ///        <description><c>f({x[0], y[0], z[0], w[0], x[1], y[1], z[1], w[1]}, {x[2], y[2], z[2], w[2], x[3], y[3], z[3], w[3]}, {x[4], y[4], z[4], w[4], x[5], y[5], z[5], w[5]}, {x[6], y[6], z[6], w[6], x[7], y[7], z[7], w[7]}) = ({x[0], y[0], z[0], x[1], y[1], z[1], x[2], y[2]}, {z[2], x[3], y[3], z[3], x[4], y[4], z[4], x[5]}, {y[5], z[5], x[6], y[6], z[6], x[7], y[7], z[7]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>16</term>
        ///        <description><c>f({x[0], y[0], z[0], w[0], x[1], y[1], z[1], w[1], x[2], y[2], z[2], w[2], x[3], y[3], z[3], w[3]}, {x[4], y[4], z[4], w[4], x[5], y[5], z[5], w[5], x[6], y[6], z[6], w[6], x[7], y[7], z[7], w[7]}, {x[8], y[8], z[8], w[8], x[9], y[9], z[9], w[9], x[10], y[10], z[10], w[10], x[11], y[11], z[11], w[11]}, {x[12], y[12], z[12], w[12], x[13], y[13], z[13], w[13], x[14], y[14], z[14], w[14], x[15], y[15], z[15], w[15]}) = ({x[0], y[0], z[0], x[1], y[1], z[1], x[2], y[2], z[2], x[3], y[3], z[3], x[4], y[4], z[4], x[5]}, {y[5], z[5], x[6], y[6], z[6], x[7], y[7], z[7], x[8], y[8], z[8], x[9], y[9], z[9], x[10], y[10]}, {z[10], x[11], y[11], z[11], x[12], y[12], z[12], x[13], y[13], z[13], x[14], y[14], z[14], x[15], y[15], z[15]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>...</term>
        ///        <description>...</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YGroup4ToGroup3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup3ToGroup4_AcceleratedTypes"/>
        /// <seealso cref="YGroup3Zip_AcceleratedTypes"/>
        /// <seealso cref="YGroup4Unzip_AcceleratedTypes"/>
        TypeCodeFlags YGroup4ToGroup3_AcceleratedTypes { get; }

        /// <summary>
        /// Convert a 4-element group, to a 3-element group. It also converts packed RGBA pixel data to packed RGB pixel data (将4-元素组, 转为3-元素组. 它还能将 已打包的RGBA像素数据, 转换为 已打包的RGB像素数据).
        /// Mnemonic: View for group: <c>(result0, result1, result2) = YGroup3Zip(YGroup4Unzip(data0, data1, data2, data3)))</c>. View for element: <c>element_ref(i, result0, result1, result2) := element_ref((i/3)*4+(i%3), data0, data1, data2, data3)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 4-element groups - Part 0 (由4元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 4-element groups - Part 1 (由4元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 4-element groups - Part 2 (由4元素组所组成的向量 - 第2部分).</param>
        /// <param name="data3">A vector made of 4-element groups - Part 3 (由4元素组所组成的向量 - 第3部分).</param>
        /// <param name="result1">Returns part 1 of the converted data (返回转换后数据的第1部分).</param>
        /// <param name="result2">Returns part 2 of the converted data (返回转换后数据的第2部分).</param>
        /// <returns>Returns part 0 of the converted data (返回转换后数据的第0部分).</returns>
        /// <seealso cref="YGroup4ToGroup3_AcceleratedTypes"/>
        Vector128<float> YGroup4ToGroup3(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> result1, out Vector128<float> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup4ToGroup3(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> result1, out Vector128<double> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup4ToGroup3(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> result1, out Vector128<sbyte> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup4ToGroup3(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> result1, out Vector128<byte> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup4ToGroup3(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> result1, out Vector128<short> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup4ToGroup3(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> result1, out Vector128<ushort> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup4ToGroup3(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> result1, out Vector128<int> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup4ToGroup3(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> result1, out Vector128<uint> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup4ToGroup3(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> result1, out Vector128<long> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup4ToGroup3(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> result1, out Vector128<ulong> result2);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup4Unzip</c> (运行 <c>YGroup4Unzip</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (逆函数): <see cref="YGroup4Zip_AcceleratedTypes">YGroup4Zip</see>.</para>
        /// <para>Sample (示例).</para>
        /// <list type="table">
        ///    <listheader>
        ///        <term>Elements</term>
        ///        <description>Result</description>
        ///    </listheader>
        ///    <item>
        ///        <term>1</term>
        ///        <description><c>f({x[0]}, {y[0]}, {z[0]}, {w[0]}) = ({x[0]}, {y[0]}, {z[0]}, {w[0]})</c>. (Fallback)</description>
        ///    </item>
        ///    <item>
        ///        <term>2</term>
        ///        <description><c>f({x[0], y[0]}, {z[0], w[0]}, {x[1], y[1]}, {z[1], w[1]}) = ({x[0], x[1]}, {y[0], y[1]}, {z[0], z[1]}, {w[0], w[1]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>4</term>
        ///        <description><c>f({x[0], y[0], z[0], w[0]}, {x[1], y[1], z[1], w[1]}, {x[2], y[2], z[2], w[2]}, {x[3], y[3], z[3], w[3]}) = ({x[0], x[1], x[2], x[3]}, {y[0], y[1], y[2], y[3]}, {z[0], z[1], z[2], z[3]}, {w[0], w[1], w[2], w[3]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>8</term>
        ///        <description><c>f({x[0], y[0], z[0], w[0], x[1], y[1], z[1], w[1]}, {x[2], y[2], z[2], w[2], x[3], y[3], z[3], w[3]}, {x[4], y[4], z[4], w[4], x[5], y[5], z[5], w[5]}, {x[6], y[6], z[6], w[6], x[7], y[7], z[7], w[7]}) = ({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7]}, {z[0], z[1], z[2], z[3], z[4], z[5], z[6], z[7]}, {w[0], w[1], w[2], w[3], w[4], w[5], w[6], w[7]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>16</term>
        ///        <description><c>f({x[0], y[0], z[0], w[0], x[1], y[1], z[1], w[1], x[2], y[2], z[2], w[2], x[3], y[3], z[3], w[3]}, {x[4], y[4], z[4], w[4], x[5], y[5], z[5], w[5], x[6], y[6], z[6], w[6], x[7], y[7], z[7], w[7]}, {x[8], y[8], z[8], w[8], x[9], y[9], z[9], w[9], x[10], y[10], z[10], w[10], x[11], y[11], z[11], w[11]}, {x[12], y[12], z[12], w[12], x[13], y[13], z[13], w[13], x[14], y[14], z[14], w[14], x[15], y[15], z[15], w[15]}) = ({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8], x[9], x[10], x[11], x[12], x[13], x[14], x[15]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7], y[8], y[9], y[10], y[11], y[12], y[13], y[14], y[15]}, {z[0], z[1], z[2], z[3], z[4], z[5], z[6], z[7], z[8], z[9], z[10], z[11], z[12], z[13], z[14], z[15]}, {w[0], w[1], w[2], w[3], w[4], w[5], w[6], w[7], w[8], w[9], w[10], w[11], w[12], w[13], w[14], w[15]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>...</term>
        ///        <description>...</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup2Zip_AcceleratedTypes"/>
        TypeCodeFlags YGroup4Unzip_AcceleratedTypes { get; }

        /// <summary>
        /// De-Interleave 4-element groups into 4 vectors. It converts the 4-element groups AoS to SoA. It can also deinterleave packed RGBA pixel data into R,G,B,A planar data (将4-元素组解交织为4个向量. 它能将4元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGBA像素数据, 解交织为 R,G,B,A 平面数据).
        /// Mnemonic: <c>x[i] =: element_ref(4*i, data0, data1, data2, data3)</c>, <c>y[i] =: element_ref(4*i+1, data0, data1, data2, data3)</c>, <c>z[i] =: element_ref(4*i+2, data0, data1, data2, data3)</c>, <c>w[i] =: element_ref(4*i+3, data0, data1, data2, data3)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 4-element groups - Part 0 (由4元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 4-element groups - Part 1 (由4元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 4-element groups - Part 2 (由4元素组所组成的向量 - 第2部分).</param>
        /// <param name="data3">A vector made of 4-element groups - Part 3 (由4元素组所组成的向量 - 第3部分).</param>
        /// <param name="y">Returns the vector made of the Y-components (返回Y分量所组成的向量).</param>
        /// <param name="z">Returns the vector made of the Z-components (返回Z分量所组成的向量).</param>
        /// <param name="w">Returns the vector made of the W-components (返回W分量所组成的向量).</param>
        /// <returns>Returns the vector made of the X-components (返回X分量所组成的向量).</returns>
        /// <seealso cref="YGroup4Unzip_AcceleratedTypes"/>
        Vector128<float> YGroup4Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> y, out Vector128<float> z, out Vector128<float> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup4Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> y, out Vector128<double> z, out Vector128<double> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup4Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> y, out Vector128<sbyte> z, out Vector128<sbyte> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup4Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> y, out Vector128<byte> z, out Vector128<byte> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup4Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> y, out Vector128<short> z, out Vector128<short> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup4Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> y, out Vector128<ushort> z, out Vector128<ushort> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup4Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> y, out Vector128<int> z, out Vector128<int> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup4Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> y, out Vector128<uint> z, out Vector128<uint> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup4Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> y, out Vector128<long> z, out Vector128<long> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup4Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> y, out Vector128<ulong> z, out Vector128<ulong> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ExInt128> YGroup4Unzip(Vector128<ExInt128> data0, Vector128<ExInt128> data1, Vector128<ExInt128> data2, Vector128<ExInt128> data3, out Vector128<ExInt128> y, out Vector128<ExInt128> z, out Vector128<ExInt128> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ExUInt128> YGroup4Unzip(Vector128<ExUInt128> data0, Vector128<ExUInt128> data1, Vector128<ExUInt128> data2, Vector128<ExUInt128> data3, out Vector128<ExUInt128> y, out Vector128<ExUInt128> z, out Vector128<ExUInt128> w);

        /// <summary>
        /// De-Interleave 4-element groups into 4 vectors. It converts the 4-element groups AoS to SoA. It can also deinterleave packed RGBA pixel data into R,G,B,A planar data (将4-元素组解交织为4个向量. 它能将4元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGBA像素数据, 解交织为 R,G,B,A 平面数据). It is specialized for process 128-bit element (它专门用于处理128位元素).
        /// Mnemonic: <c>x[i] =: element_ref(4*i, data0, data1, data2, data3)</c>, <c>y[i] =: element_ref(4*i+1, data0, data1, data2, data3)</c>, <c>z[i] =: element_ref(4*i+2, data0, data1, data2, data3)</c>, <c>w[i] =: element_ref(4*i+3, data0, data1, data2, data3)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="data0">A vector made of 4-element groups - Part 0 (由4元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 4-element groups - Part 1 (由4元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 4-element groups - Part 2 (由4元素组所组成的向量 - 第2部分).</param>
        /// <param name="data3">A vector made of 4-element groups - Part 3 (由4元素组所组成的向量 - 第3部分).</param>
        /// <param name="y">Returns the vector made of the Y-components (返回Y分量所组成的向量).</param>
        /// <param name="z">Returns the vector made of the Z-components (返回Z分量所组成的向量).</param>
        /// <param name="w">Returns the vector made of the W-components (返回W分量所组成的向量).</param>
        /// <returns>Returns the vector made of the X-components (返回X分量所组成的向量).</returns>
        Vector128<T> YGroup4Unzip_Bit128<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3, out Vector128<T> y, out Vector128<T> z, out Vector128<T> w) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup4Zip</c> (运行 <c>YGroup4Zip</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (逆函数): <see cref="YGroup4Unzip_AcceleratedTypes">YGroup4Unzip</see>.</para>
        /// <para>Sample (示例).</para>
        /// <list type="table">
        ///    <listheader>
        ///        <term>Elements</term>
        ///        <description>Result</description>
        ///    </listheader>
        ///    <item>
        ///        <term>1</term>
        ///        <description><c>f({x[0]}, {y[0]}, {z[0]}, {w[0]}) = ({x[0]}, {y[0]}, {z[0]}, {w[0]})</c>. (Fallback)</description>
        ///    </item>
        ///    <item>
        ///        <term>2</term>
        ///        <description><c>f({x[0], x[1]}, {y[0], y[1]}, {z[0], z[1]}, {w[0], w[1]}) = ({x[0], y[0]}, {z[0], w[0]}, {x[1], y[1]}, {z[1], w[1]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>4</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3]}, {y[0], y[1], y[2], y[3]}, {z[0], z[1], z[2], z[3]}, {w[0], w[1], w[2], w[3]}) = ({x[0], y[0], z[0], w[0]}, {x[1], y[1], z[1], w[1]}, {x[2], y[2], z[2], w[2]}, {x[3], y[3], z[3], w[3]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>8</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7]}, {z[0], z[1], z[2], z[3], z[4], z[5], z[6], z[7]}, {w[0], w[1], w[2], w[3], w[4], w[5], w[6], w[7]}) = ({x[0], y[0], z[0], w[0], x[1], y[1], z[1], w[1]}, {x[2], y[2], z[2], w[2], x[3], y[3], z[3], w[3]}, {x[4], y[4], z[4], w[4], x[5], y[5], z[5], w[5]}, {x[6], y[6], z[6], w[6], x[7], y[7], z[7], w[7]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>16</term>
        ///        <description><c>f({x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8], x[9], x[10], x[11], x[12], x[13], x[14], x[15]}, {y[0], y[1], y[2], y[3], y[4], y[5], y[6], y[7], y[8], y[9], y[10], y[11], y[12], y[13], y[14], y[15]}, {z[0], z[1], z[2], z[3], z[4], z[5], z[6], z[7], z[8], z[9], z[10], z[11], z[12], z[13], z[14], z[15]}, {w[0], w[1], w[2], w[3], w[4], w[5], w[6], w[7], w[8], w[9], w[10], w[11], w[12], w[13], w[14], w[15]}) = ({x[0], y[0], z[0], w[0], x[1], y[1], z[1], w[1], x[2], y[2], z[2], w[2], x[3], y[3], z[3], w[3]}, {x[4], y[4], z[4], w[4], x[5], y[5], z[5], w[5], x[6], y[6], z[6], w[6], x[7], y[7], z[7], w[7]}, {x[8], y[8], z[8], w[8], x[9], y[9], z[9], w[9], x[10], y[10], z[10], w[10], x[11], y[11], z[11], w[11]}, {x[12], y[12], z[12], w[12], x[13], y[13], z[13], w[13], x[14], y[14], z[14], w[14], x[15], y[15], z[15], w[15]})</c></description>
        ///    </item>
        ///    <item>
        ///        <term>...</term>
        ///        <description>...</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YGroup4Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YGroup2Unzip_AcceleratedTypes"/>
        TypeCodeFlags YGroup4Zip_AcceleratedTypes { get; }

        /// <summary>
        /// Interleave 4 vectors into 4-element groups. It converts the 4-element groups SoA to AoS. It can also interleave R,G,B,A planar data into packed RGBA pixel data (将4个向量交织为4-元素组. 它能将4元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B,A 平面数据, 交织为 已打包的RGBA像素数据).
        /// Mnemonic: <c>element_ref(i, data0, data1, data2, data3) := (0==(i&amp;3))?( x[i2] ):( (1==(i&amp;3))?( y[i2] ):( (2==(i&amp;s3))?( z[i2] ):( w[i2] ) ) )</c>, <c>i2 := i/4</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <param name="z">A vector consisting purely of Z-components (纯由Z分量所组成的向量).</param>
        /// <param name="w">A vector consisting purely of W-components (纯由W分量所组成的向量).</param>
        /// <param name="data1">Returns part 1 of the interleaved data (返回交织后数据的第1部分).</param>
        /// <param name="data2">Returns part 2 of the interleaved data (返回交织后数据的第2部分).</param>
        /// <param name="data3">Returns part 3 of the interleaved data (返回交织后数据的第3部分).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        Vector128<float> YGroup4Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, Vector128<float> w, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<double> YGroup4Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, Vector128<double> w, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<sbyte> YGroup4Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<byte> YGroup4Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<short> YGroup4Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ushort> YGroup4Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<int> YGroup4Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, Vector128<int> w, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<uint> YGroup4Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, Vector128<uint> w, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<long> YGroup4Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, Vector128<long> w, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ulong> YGroup4Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, Vector128<ulong> w, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ExInt128> YGroup4Zip(Vector128<ExInt128> x, Vector128<ExInt128> y, Vector128<ExInt128> z, Vector128<ExInt128> w, out Vector128<ExInt128> data1, out Vector128<ExInt128> data2, out Vector128<ExInt128> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        Vector128<ExUInt128> YGroup4Zip(Vector128<ExUInt128> x, Vector128<ExUInt128> y, Vector128<ExUInt128> z, Vector128<ExUInt128> w, out Vector128<ExUInt128> data1, out Vector128<ExUInt128> data2, out Vector128<ExUInt128> data3);

        /// <summary>
        /// Interleave 4 vectors into 4-element groups. It converts the 4-element groups SoA to AoS. It can also interleave R,G,B,A planar data into packed RGBA pixel data (将4个向量交织为4-元素组. 它能将4元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B,A 平面数据, 交织为 已打包的RGBA像素数据). It is specialized for process 128-bit element (它专门用于处理128位元素).
        /// Mnemonic: <c>element_ref(i, data0, data1, data2, data3) := (0==(i&amp;3))?( x[i2] ):( (1==(i&amp;3))?( y[i2] ):( (2==(i&amp;s3))?( z[i2] ):( w[i2] ) ) )</c>, <c>i2 := i/4</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <param name="z">A vector consisting purely of Z-components (纯由Z分量所组成的向量).</param>
        /// <param name="w">A vector consisting purely of W-components (纯由W分量所组成的向量).</param>
        /// <param name="data1">Returns part 1 of the interleaved data (返回交织后数据的第1部分).</param>
        /// <param name="data2">Returns part 2 of the interleaved data (返回交织后数据的第2部分).</param>
        /// <param name="data3">Returns part 3 of the interleaved data (返回交织后数据的第3部分).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        Vector128<T> YGroup4Zip_Bit128<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z, Vector128<T> w, out Vector128<T> data1, out Vector128<T> data2, out Vector128<T> data3) where T : struct;


        /// <summary>
        /// De-Interleave 6-element groups into 6 vectors. It converts the 6-element groups AoS to SoA. (将6-元素组解交织为6个向量. 它能将6元素组的 数组结构体 转为 结构体数组). It is specialized for process 128-bit element (它专门用于处理128位元素).
        /// Mnemonic: <c>x[i] =: element_ref(6*i, data0, data1, data2, data3, data4, data5)</c>, <c>y[i] =: element_ref(6*i+1, data0, data1, data2, data3, data4, data5)</c>, <c>z[i] =: element_ref(6*i+2, data0, data1, data2, data3, data4, data5)</c>, <c>w[i] =: element_ref(6*i+3, data0, data1, data2, data3, data4, data5)</c>, <c>u[i] =: element_ref(6*i+4, data0, data1, data2, data3, data4, data5)</c>, <c>v[i] =: element_ref(6*i+5, data0, data1, data2, data3, data4, data5)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="data0">A vector made of 6-element groups - Part 0 (由元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 6-element groups - Part 1 (由6元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 6-element groups - Part 2 (由6元素组所组成的向量 - 第2部分).</param>
        /// <param name="data3">A vector made of 6-element groups - Part 3 (由6元素组所组成的向量 - 第3部分).</param>
        /// <param name="data4">A vector made of 6-element groups - Part 4 (由6元素组所组成的向量 - 第4部分).</param>
        /// <param name="data5">A vector made of 6-element groups - Part 5 (由6元素组所组成的向量 - 第5部分).</param>
        /// <param name="y">Returns the vector made of the Y-components (返回Y分量所组成的向量).</param>
        /// <param name="z">Returns the vector made of the Z-components (返回Z分量所组成的向量).</param>
        /// <param name="w">Returns the vector made of the W-components (返回W分量所组成的向量).</param>
        /// <param name="u">Returns the vector made of the U-components (返回U分量所组成的向量).</param>
        /// <param name="v">Returns the vector made of the V-components (返回V分量所组成的向量).</param>
        /// <returns>Returns the vector made of the X-components (返回X分量所组成的向量).</returns>
        /// <seealso cref="YGroup6Zip_Bit128"/>
        Vector128<T> YGroup6Unzip_Bit128<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3, Vector128<T> data4, Vector128<T> data5, out Vector128<T> y, out Vector128<T> z, out Vector128<T> w, out Vector128<T> u, out Vector128<T> v) where T : struct;


        /// <summary>
        /// Interleave 6 vectors into 6-element groups. It converts the 6-element groups SoA to AoS (将6个向量交织为6-元素组. 它能将6元素组的 结构体数组 转为 数组结构体. It is specialized for process 128-bit element (它专门用于处理128位元素).
        /// Mnemonic: <c>element_ref(i, data0, data1, data2, data3, data4, data5) := (0==(i%6))?( x[i2] ):( (1==(i%6))?( y[i2] ):( (2==(i%6))?( z[i2] ):( (3==(i%6))?( w[i2] ):( (4==(i%6))?( u[i2] ):( v[i2] ) ) ) ) )</c>, <c>i2 := i/6</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <param name="z">A vector consisting purely of Z-components (纯由Z分量所组成的向量).</param>
        /// <param name="w">A vector consisting purely of W-components (纯由W分量所组成的向量).</param>
        /// <param name="u">A vector consisting purely of U-components (纯由U分量所组成的向量).</param>
        /// <param name="v">A vector consisting purely of V-components (纯由V分量所组成的向量).</param>
        /// <param name="data1">Returns part 1 of the interleaved data (返回交织后数据的第1部分).</param>
        /// <param name="data2">Returns part 2 of the interleaved data (返回交织后数据的第2部分).</param>
        /// <param name="data3">Returns part 3 of the interleaved data (返回交织后数据的第3部分).</param>
        /// <param name="data4">Returns part 4 of the interleaved data (返回交织后数据的第4部分).</param>
        /// <param name="data5">Returns part 5 of the interleaved data (返回交织后数据的第5部分).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        /// <seealso cref="YGroup6Unzip_Bit128"/>
        Vector128<T> YGroup6Zip_Bit128<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z, Vector128<T> w, Vector128<T> u, Vector128<T> v, out Vector128<T> data1, out Vector128<T> data2, out Vector128<T> data3, out Vector128<T> data4, out Vector128<T> data5) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsAllTrue</c> (运行 <c>YIsAllTrue</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsAllTrue{T}(Vector128{T})"/>
        TypeCodeFlags YIsAllTrue_AcceleratedTypes { get; }

        /// <summary>
        /// Checks if all elements of the vector is true (检查向量中所有元素是不是都为true).
        /// Mnemonic: <c>rt := value[0] &amp;&amp; value[1] &amp;&amp; value[2] &amp;&amp; ... &amp;&amp; value[Count-1]</c>. The element of value must be 0 or <see cref="Scalars{T}.AllBitsSet">AllBitsSet</see> (Signed integer value -1).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector whose elements will be checked. The return value of a comparison category function can be assigned to it (将检查其元素的向量. 可将比较类函数的返回值赋值给它). e.g. <see cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>.</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="value"/> is true. (<paramref name="value" /> 中所有元素为true时返回<c>true</c>).</returns>
        /// <seealso cref="YIsAllTrue_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAll{T}(Vector128{T}, Vector128{T})" />
        bool YIsAllTrue<T>(Vector128<T> value) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsAnyTrue</c> (运行 <c>YIsAnyTrue</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsAnyTrue{T}(Vector128{T})"/>
        TypeCodeFlags YIsAnyTrue_AcceleratedTypes { get; }

        /// <summary>
        /// Checks if any elements of the vector is true (检查向量中任一元素是不是为true).
        /// Mnemonic: <c>rt := value[0] || value[1] || value[2] || ... || value[Count-1]</c>. The element of value must be 0 or <see cref="Scalars{T}.AllBitsSet">AllBitsSet</see> (Signed integer value -1).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector whose elements will be checked. The return value of a comparison category function can be assigned to it (将检查其元素的向量. 可将比较类函数的返回值赋值给它). e.g. <see cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>.</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="value"/> is true. (<paramref name="value" /> 中任一元素为true时返回<c>true</c>).</returns>
        /// <seealso cref="YIsAnyTrue_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAny{T}(Vector128{T}, Vector128{T})" />
        bool YIsAnyTrue<T>(Vector128<T> value) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsEvenInteger</c> (运行 <c>YIsEvenInteger</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsEvenInteger(Vector128{float})"/>
        TypeCodeFlags YIsEvenInteger_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents an even integral number (确定元素是否为偶数整数).
        /// Mnemonic: <c>rt[i] := to_mask(isEvenInteger(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is even integral number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为偶数整数).</returns>
        /// <seealso cref="YIsEvenInteger_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(float)"/>
        Vector128<int> YIsEvenInteger(Vector128<float> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(double)"/>
        Vector128<long> YIsEvenInteger(Vector128<double> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(sbyte)"/>
        Vector128<sbyte> YIsEvenInteger(Vector128<sbyte> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(byte)"/>
        Vector128<byte> YIsEvenInteger(Vector128<byte> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(short)"/>
        Vector128<short> YIsEvenInteger(Vector128<short> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(ushort)"/>
        Vector128<ushort> YIsEvenInteger(Vector128<ushort> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(int)"/>
        Vector128<int> YIsEvenInteger(Vector128<int> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(uint)"/>
        Vector128<uint> YIsEvenInteger(Vector128<uint> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(long)"/>
        Vector128<long> YIsEvenInteger(Vector128<long> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(ulong)"/>
        Vector128<ulong> YIsEvenInteger(Vector128<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsFinite</c> (运行 <c>YIsFinite</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsFinite(Vector128{float})"/>
        TypeCodeFlags YIsFinite_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is finite. It contains zero, subnormal, and normal. It does not contain infinity, NaN (确定元素是否为有限值. 它包含 零、次正规数、正规数. 它不含无穷大、非数).
        /// Mnemonic: <c>rt[i] := to_mask(isFinite(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is finite (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为有限的).</returns>
        /// <seealso cref="YIsFinite_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsFinite(float)"/>
        Vector128<int> YIsFinite(Vector128<float> value);

        /// <inheritdoc cref="YIsFinite(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsFinite(double)"/>
        Vector128<long> YIsFinite(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsInfinity</c> (运行 <c>YIsInfinity</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsInfinity(Vector128{float})"/>
        TypeCodeFlags YIsInfinity_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is infinite (确定元素是否为无穷大).
        /// Mnemonic: <c>rt[i] := to_mask(isInfinity(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is infinite (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为无穷大).</returns>
        /// <seealso cref="YIsInfinity_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsInfinity(float)"/>
        Vector128<int> YIsInfinity(Vector128<float> value);

        /// <inheritdoc cref="YIsInfinity(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsInfinity(double)"/>
        Vector128<long> YIsInfinity(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsInfinityOrNaN</c> (运行 <c>YIsInfinityOrNaN</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsInfinityOrNaN(Vector128{float})"/>
        TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is infinite or NaN (确定元素是否为无穷大或非数).
        /// Mnemonic: <c>rt[i] := to_mask(isInfinityOrNaN(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is infinite or NaN (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为无穷大或非数).</returns>
        /// <seealso cref="YIsInfinityOrNaN_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsInfinityOrNaN(float)"/>
        Vector128<int> YIsInfinityOrNaN(Vector128<float> value);

        /// <inheritdoc cref="YIsInfinityOrNaN(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsInfinityOrNaN(double)"/>
        Vector128<long> YIsInfinityOrNaN(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsInteger</c> (运行 <c>YIsInteger</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsInteger(Vector128{float})"/>
        TypeCodeFlags YIsInteger_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents an integral number (确定元素是否为整数).
        /// Mnemonic: <c>rt[i] := to_mask(isInteger(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is integral number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为整数).</returns>
        /// <seealso cref="YIsInteger_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsInteger(float)"/>
        Vector128<int> YIsInteger(Vector128<float> value);

        /// <inheritdoc cref="YIsInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsInteger(double)"/>
        Vector128<long> YIsInteger(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNaN</c> (运行 <c>YIsNaN</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNaN(Vector128{float})"/>
        TypeCodeFlags YIsNaN_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is NaN (确定元素是否为非数).
        /// Mnemonic: <c>rt[i] := to_mask(isNaN(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is NaN (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为非数).</returns>
        /// <seealso cref="YIsNaN_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNaN(float)"/>
        Vector128<int> YIsNaN(Vector128<float> value);

        /// <inheritdoc cref="YIsNaN(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsNaN(double)"/>
        Vector128<long> YIsNaN(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNegative</c> (运行 <c>YIsNegative</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNegative(Vector128{float})"/>
        TypeCodeFlags YIsNegative_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents a negative number or negative zero (确定元素是否为负数或负零).
        /// Mnemonic: <c>rt[i] := to_mask(isNegative(value[i])) = to_mask((value[i]&lt;0) || isNegativeZero(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is negative number or negative zero (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为负数或负零).</returns>
        /// <seealso cref="YIsNegative_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNegative(float)"/>
        Vector128<int> YIsNegative(Vector128<float> value);

        /// <inheritdoc cref="YIsNegative(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(double)"/>
        Vector128<long> YIsNegative(Vector128<double> value);

        /// <inheritdoc cref="YIsNegative(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(sbyte)"/>
        Vector128<sbyte> YIsNegative(Vector128<sbyte> value);

        /// <inheritdoc cref="YIsNegative(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(short)"/>
        Vector128<short> YIsNegative(Vector128<short> value);

        /// <inheritdoc cref="YIsNegative(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(int)"/>
        Vector128<int> YIsNegative(Vector128<int> value);

        /// <inheritdoc cref="YIsNegative(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(long)"/>
        Vector128<long> YIsNegative(Vector128<long> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNegativeInfinity</c> (运行 <c>YIsNegativeInfinity</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNegativeInfinity(Vector128{float})"/>
        TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is negative infinity (确定元素是否为负无穷大).
        /// Mnemonic: <c>rt[i] := to_mask(isNegativeInfinity(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is negative infinity (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为负无穷大).</returns>
        /// <seealso cref="YIsNegativeInfinity_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNegativeInfinity(float)"/>
        Vector128<int> YIsNegativeInfinity(Vector128<float> value);

        /// <inheritdoc cref="YIsNegativeInfinity(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsNegativeInfinity(double)"/>
        Vector128<long> YIsNegativeInfinity(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNegativeZero</c> (运行 <c>YIsNegativeZero</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNegativeZero(Vector128{float})"/>
        TypeCodeFlags YIsNegativeZero_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents a negative zero (确定元素是否为负零).
        /// Mnemonic: <c>rt[i] := to_mask(isNegativeZero(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is finite (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为有限的).</returns>
        /// <seealso cref="YIsNegativeZero_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNegativeZero(float)"/>
        Vector128<int> YIsNegativeZero(Vector128<float> value);

        /// <inheritdoc cref="YIsNegativeZero(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsNegativeZero(double)"/>
        Vector128<long> YIsNegativeZero(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNormal</c> (运行 <c>YIsNormal</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNormal(Vector128{float})"/>
        TypeCodeFlags YIsNormal_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is normal (确定元素是否为正规数).
        /// Mnemonic: <c>rt[i] := to_mask(isFinite(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is normal (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为正规数).</returns>
        /// <seealso cref="YIsNormal_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNormal(float)"/>
        Vector128<int> YIsNormal(Vector128<float> value);

        /// <inheritdoc cref="YIsNormal(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsNormal(double)"/>
        Vector128<long> YIsNormal(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNotEquals</c> (运行 <c>YIsNotEquals</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNotEquals(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags YIsNotEquals_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>
        Vector128<float> YIsNotEquals(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>
        Vector128<double> YIsNotEquals(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>
        Vector128<sbyte> YIsNotEquals(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>
        Vector128<byte> YIsNotEquals(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>
        Vector128<short> YIsNotEquals(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>
        Vector128<ushort> YIsNotEquals(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>
        Vector128<int> YIsNotEquals(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>
        Vector128<uint> YIsNotEquals(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>
        Vector128<long> YIsNotEquals(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/>
        Vector128<ulong> YIsNotEquals(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNotNaN</c> (运行 <c>YIsNotNaN</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNotNaN(Vector128{float})"/>
        TypeCodeFlags YIsNotNaN_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is not NaN (确定元素是否不为非数).
        /// Mnemonic: <c>rt[i] := to_mask(isNotNaN(value[i])) = to_mask(!isNaN(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is not NaN (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否不为非数).</returns>
        /// <seealso cref="YIsNotNaN_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNotNaN(float)"/>
        Vector128<int> YIsNotNaN(Vector128<float> value);

        /// <inheritdoc cref="YIsNotNaN(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsNotNaN(double)"/>
        Vector128<long> YIsNotNaN(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsOddInteger</c> (运行 <c>YIsOddInteger</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsOddInteger(Vector128{float})"/>
        TypeCodeFlags YIsOddInteger_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents an odd integral number (确定元素是否为奇数整数).
        /// Mnemonic: <c>rt[i] := to_mask(isOddInteger(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is odd integral number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为奇数整数).</returns>
        /// <seealso cref="YIsOddInteger_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(float)"/>
        Vector128<int> YIsOddInteger(Vector128<float> value);

        /// <inheritdoc cref="YIsOddInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(double)"/>
        Vector128<long> YIsOddInteger(Vector128<double> value);

        /// <inheritdoc cref="YIsOddInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(sbyte)"/>
        Vector128<sbyte> YIsOddInteger(Vector128<sbyte> value);

        /// <inheritdoc cref="YIsOddInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(byte)"/>
        Vector128<byte> YIsOddInteger(Vector128<byte> value);

        /// <inheritdoc cref="YIsOddInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(short)"/>
        Vector128<short> YIsOddInteger(Vector128<short> value);

        /// <inheritdoc cref="YIsOddInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(ushort)"/>
        Vector128<ushort> YIsOddInteger(Vector128<ushort> value);

        /// <inheritdoc cref="YIsOddInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(int)"/>
        Vector128<int> YIsOddInteger(Vector128<int> value);

        /// <inheritdoc cref="YIsOddInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(uint)"/>
        Vector128<uint> YIsOddInteger(Vector128<uint> value);

        /// <inheritdoc cref="YIsOddInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(long)"/>
        Vector128<long> YIsOddInteger(Vector128<long> value);

        /// <inheritdoc cref="YIsOddInteger(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(ulong)"/>
        Vector128<ulong> YIsOddInteger(Vector128<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsPositive</c> (运行 <c>YIsPositive</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsPositive(Vector128{float})"/>
        TypeCodeFlags YIsPositive_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents zero or a positive number (确定元素是否为零或正数).
        /// Mnemonic: <c>rt[i] := to_mask(isNegative(value[i])) = to_mask((value[i]&lt;0) || isNegativeZero(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is zero or a positive number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为零或正数).</returns>
        /// <seealso cref="YIsPositive_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsPositive(float)"/>
        Vector128<int> YIsPositive(Vector128<float> value);

        /// <inheritdoc cref="YIsPositive(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(double)"/>
        Vector128<long> YIsPositive(Vector128<double> value);

        /// <inheritdoc cref="YIsPositive(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(sbyte)"/>
        Vector128<sbyte> YIsPositive(Vector128<sbyte> value);

        /// <inheritdoc cref="YIsPositive(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(short)"/>
        Vector128<short> YIsPositive(Vector128<short> value);

        /// <inheritdoc cref="YIsPositive(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(int)"/>
        Vector128<int> YIsPositive(Vector128<int> value);

        /// <inheritdoc cref="YIsPositive(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(long)"/>
        Vector128<long> YIsPositive(Vector128<long> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsPositiveInfinity</c> (运行 <c>YIsPositiveInfinity</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsPositiveInfinity(Vector128{float})"/>
        TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is positive infinity (确定元素是否为正无穷大).
        /// Mnemonic: <c>rt[i] := to_mask(isNegativeInfinity(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is positive infinity (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为正无穷大).</returns>
        /// <seealso cref="YIsPositiveInfinity_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsPositiveInfinity(float)"/>
        Vector128<int> YIsPositiveInfinity(Vector128<float> value);

        /// <inheritdoc cref="YIsPositiveInfinity(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsPositiveInfinity(double)"/>
        Vector128<long> YIsPositiveInfinity(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsSubnormal</c> (运行 <c>YIsSubnormal</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsSubnormal(Vector128{float})"/>
        TypeCodeFlags YIsSubnormal_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is subnormal (确定元素是否为次正规数).
        /// Mnemonic: <c>rt[i] := to_mask(IsSubnormal(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is subnormal (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为次正规数).</returns>
        /// <seealso cref="YIsSubnormal_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsSubnormal(float)"/>
        Vector128<int> YIsSubnormal(Vector128<float> value);

        /// <inheritdoc cref="YIsSubnormal(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsSubnormal(double)"/>
        Vector128<long> YIsSubnormal(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsZero</c> (运行 <c>YIsZero</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsZero(Vector128{float})"/>
        TypeCodeFlags YIsZero_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is zero (确定元素是否为零).
        /// Mnemonic: <c>rt[i] := to_mask(0==value[i])</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is zero (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为零).</returns>
        /// <seealso cref="YIsZero_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsZero(float)"/>
        Vector128<int> YIsZero(Vector128<float> value);

        /// <inheritdoc cref="YIsZero(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(double)"/>
        Vector128<long> YIsZero(Vector128<double> value);

        /// <inheritdoc cref="YIsZero(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(sbyte)"/>
        Vector128<sbyte> YIsZero(Vector128<sbyte> value);

        /// <inheritdoc cref="YIsZero(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(byte)"/>
        Vector128<byte> YIsZero(Vector128<byte> value);

        /// <inheritdoc cref="YIsZero(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(short)"/>
        Vector128<short> YIsZero(Vector128<short> value);

        /// <inheritdoc cref="YIsZero(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(ushort)"/>
        Vector128<ushort> YIsZero(Vector128<ushort> value);

        /// <inheritdoc cref="YIsZero(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(int)"/>
        Vector128<int> YIsZero(Vector128<int> value);

        /// <inheritdoc cref="YIsZero(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(uint)"/>
        Vector128<uint> YIsZero(Vector128<uint> value);

        /// <inheritdoc cref="YIsZero(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(long)"/>
        Vector128<long> YIsZero(Vector128<long> value);

        /// <inheritdoc cref="YIsZero(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(ulong)"/>
        Vector128<ulong> YIsZero(Vector128<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsZeroOrSubnormal</c> (运行 <c>YIsZeroOrSubnormal</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsZeroOrSubnormal(Vector128{float})"/>
        TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is zero or subnormal (确定元素是否为零或次正规数).
        /// Mnemonic: <c>rt[i] := to_mask(isZeroOrSubnormal(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is zero or subnormal (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为零或次正规数).</returns>
        /// <seealso cref="YIsZeroOrSubnormal_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsZeroOrSubnormal(float)"/>
        Vector128<int> YIsZeroOrSubnormal(Vector128<float> value);

        /// <inheritdoc cref="YIsZeroOrSubnormal(Vector128{float})"/>
        /// <seealso cref="MathINumberBase.IsZeroOrSubnormal(double)"/>
        Vector128<long> YIsZeroOrSubnormal(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YMaxNumber</c> (运行 <c>YMaxNumber</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YMaxNumber(Vector128{float}, Vector128{float})"/>
        TypeCodeFlags YMaxNumber_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the maximum number of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大数值). The maxNumber method matches the IEEE 754:2019 maximumNumber function. This requires <c>NaN</c> inputs to not be propagated back to the caller and for <c>-0.0</c> to be treated as less than <c>+0.0</c> (maxNumber方法与 IEEE 754:2019 maximumNumber 函数匹配。 这要求 <c>NaN</c> 输入不传播回调用方，且 <c>-0.0</c> 被视为小于 <c>+0.0</c>).
        /// Mnemonic: <c>rt[i] := maxNumber(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum number of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大数值).</returns>
        /// <seealso cref="YMaxNumber_AcceleratedTypes"/>
        /// <seealso cref="MathINumber.MaxNumber(float, float)"/>
        Vector128<float> YMaxNumber(Vector128<float> left, Vector128<float> right);

        /// <inheritdoc cref="YMaxNumber(Vector128{float}, Vector128{float})"/>
        /// <seealso cref="MathINumber.MaxNumber(double, double)"/>
        Vector128<double> YMaxNumber(Vector128<double> left, Vector128<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>YMinNumber</c> (运行 <c>YMinNumber</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YMinNumber(Vector128{float}, Vector128{float})"/>
        TypeCodeFlags YMinNumber_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the minimum number of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小数值). The minNumber method matches the IEEE 754:2019 minimumNumber function. This requires <c>NaN</c> inputs to not be propagated back to the caller and for <c>-0.0</c> to be treated as less than <c>+0.0</c> (minNumber方法与 IEEE 754:2019 minimumNumber 函数匹配。 这要求 <c>NaN</c> 输入不传播回调用方，且 <c>-0.0</c> 被视为小于 <c>+0.0</c>).
        /// Mnemonic: <c>rt[i] := minNumber(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum number of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小数值).</returns>
        /// <seealso cref="YMinNumber_AcceleratedTypes"/>
        /// <seealso cref="MathINumber.MinNumber(float, float)"/>
        Vector128<float> YMinNumber(Vector128<float> left, Vector128<float> right);

        /// <inheritdoc cref="YMinNumber(Vector128{float}, Vector128{float})"/>
        /// <seealso cref="MathINumber.MinNumber(double, double)"/>
        Vector128<double> YMinNumber(Vector128<double> left, Vector128<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>YNarrowSaturate</c> (运行 <c>YNarrowSaturate</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YNarrowSaturate(Vector128{short}, Vector128{short})"/>
        /// <seealso cref="YNarrowSaturate_FullAcceleratedTypes"/>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturate_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>YNarrowSaturate</c> (运行 <c>YNarrowSaturate</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="YNarrowSaturate(Vector128{short}, Vector128{short})"/>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes { get; }

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{short})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{sbyte}, Vector128{short})"/>
        Vector128<sbyte> YNarrowSaturate(Vector128<short> lower, Vector128<short> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{ushort})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{byte}, Vector128{ushort})"/>
        Vector128<byte> YNarrowSaturate(Vector128<ushort> lower, Vector128<ushort> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{int})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{short}, Vector128{int})"/>
        Vector128<short> YNarrowSaturate(Vector128<int> lower, Vector128<int> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{uint})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{ushort}, Vector128{uint})"/>
        Vector128<ushort> YNarrowSaturate(Vector128<uint> lower, Vector128<uint> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{long})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{int}, Vector128{long})"/>
        Vector128<int> YNarrowSaturate(Vector128<long> lower, Vector128<long> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{ulong})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{uint}, Vector128{ulong})"/>
        Vector128<uint> YNarrowSaturate(Vector128<ulong> lower, Vector128<ulong> upper);


        /// <summary>
        /// Types with hardware acceleration when running <c>YNarrowSaturateUnsigned</c> (运行 <c>YNarrowSaturateUnsigned</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YNarrowSaturateUnsigned(Vector128{short}, Vector128{short})"/>
        /// <seealso cref="YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>YNarrowSaturateUnsigned</c> (运行 <c>YNarrowSaturateUnsigned</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="YNarrowSaturateUnsigned(Vector128{short}, Vector128{short})"/>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes { get; }

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector128{T}"/> instances into one unsigned <seealso cref="Vector128{T}"/>"  (将两个有符号 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedLower(Vector128{short})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedUpper(Vector64{byte}, Vector128{short})"/>
        Vector128<byte> YNarrowSaturateUnsigned(Vector128<short> lower, Vector128<short> upper);

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector128{T}"/> instances into one unsigned <seealso cref="Vector128{T}"/>"  (将两个有符号 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedLower(Vector128{int})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedUpper(Vector64{ushort}, Vector128{int})"/>
        Vector128<ushort> YNarrowSaturateUnsigned(Vector128<int> lower, Vector128<int> upper);

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector128{T}"/> instances into one unsigned <seealso cref="Vector128{T}"/>"  (将两个有符号 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedLower(Vector128{long})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedUpper(Vector64{uint}, Vector128{long})"/>
        Vector128<uint> YNarrowSaturateUnsigned(Vector128<long> lower, Vector128<long> upper);


        /// <summary>
        /// Types with hardware acceleration when running <c>YOrNot</c> (运行 <c>YOrNot</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YOrNot"/>
        TypeCodeFlags YOrNot_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the bitwise-or of a given vector or the ones complement of another vector (计算一个给定的向量和另一个向量反码的位或).
        /// Mnemonic: <c>rt[i] := left[i] | ~right[i]</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="left">The vector to bitwise-or with <paramref name="right" /> (将会与<paramref name="right" />进行位或运算的向量).</param>
        /// <param name="right">The vector to that is ones-complemented before being bitwise-or with <paramref name="left" /> (将会与<paramref name="left" />进行位或运算, 并使用反码的向量).</param>
        /// <returns>The bitwise-or of <paramref name="left" /> or the ones-complement of <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />反码 的位或运算结果).</returns>
        /// <seealso cref="YOrNot_AcceleratedTypes"/>
        Vector128<T> YOrNot<T>(Vector128<T> left, Vector128<T> right) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YRoundToEven</c> (运行 <c>YRoundToEven</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Methods used to calculate rounding (用于计算舍入的方法):</para>
        /// <para>- <see cref="Ceiling(Vector128{float})"/>: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.</para>
        /// <para>- <see cref="Floor(Vector128{float})"/>: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.</para>
        /// <para>- <see cref="YRoundToEven(Vector128{float})"/>: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.</para>
        /// <para>- <see cref="YRoundToZero(Vector128{float})"/>: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.</para>
        /// </remarks>
        /// <seealso cref="YRoundToEven(Vector128{float})"/>
        TypeCodeFlags YRoundToEven_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.
        /// Mnemonic: <c>rt[i] := round_to_even(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to even computed (将计算向偶数舍入的向量).</param>
        /// <returns>A vector whose elements are the round to even of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向偶数舍入).</returns>
        /// <seealso cref="YRoundToEven_AcceleratedTypes"/>
        Vector128<float> YRoundToEven(Vector128<float> value);

        /// <summary>
        /// Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.
        /// Mnemonic: <c>rt[i] := round_to_even(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to even computed (将计算向偶数舍入的向量).</param>
        /// <returns>A vector whose elements are the round to even of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向偶数舍入).</returns>
        /// <seealso cref="YRoundToEven_AcceleratedTypes"/>
        Vector128<double> YRoundToEven(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YRoundToZero</c> (运行 <c>YRoundToZero</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Methods used to calculate rounding (用于计算舍入的方法):</para>
        /// <para>- <see cref="Ceiling(Vector128{float})"/>: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.</para>
        /// <para>- <see cref="Floor(Vector128{float})"/>: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.</para>
        /// <para>- <see cref="YRoundToEven(Vector128{float})"/>: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.</para>
        /// <para>- <see cref="YRoundToZero(Vector128{float})"/>: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.</para>
        /// </remarks>
        /// <seealso cref="YRoundToZero(Vector128{float})"/>
        TypeCodeFlags YRoundToZero_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.
        /// Mnemonic: <c>rt[i] := round_to_zero(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to zero computed (将计算向零舍入的向量).</param>
        /// <returns>A vector whose elements are the round to zero of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向零舍入).</returns>
        /// <seealso cref="YRoundToZero_AcceleratedTypes"/>
        Vector128<float> YRoundToZero(Vector128<float> value);

        /// <summary>
        /// Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.
        /// Mnemonic: <c>rt[i] := round_to_zero(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to zero computed (将计算向零舍入的向量).</param>
        /// <returns>A vector whose elements are the round to zero of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向零舍入).</returns>
        /// <seealso cref="YRoundToZero_AcceleratedTypes"/>
        Vector128<double> YRoundToZero(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleG2</c> (运行 <c>YShuffleG2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).</para>
        /// <para>- <see cref="YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>
        /// <seealso cref="YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>
        /// <seealso cref="YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
        TypeCodeFlags YShuffleG2_AcceleratedTypes { get; }

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<float> YShuffleG2(Vector128<float> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<double> YShuffleG2(Vector128<double> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<sbyte> YShuffleG2(Vector128<sbyte> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<byte> YShuffleG2(Vector128<byte> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<short> YShuffleG2(Vector128<short> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<ushort> YShuffleG2(Vector128<ushort> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<int> YShuffleG2(Vector128<int> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<uint> YShuffleG2(Vector128<uint> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<long> YShuffleG2(Vector128<long> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<ulong> YShuffleG2(Vector128<ulong> source, ShuffleControlG2 control);

#if !REDUCE_MEMORY_USAGE
        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<float> YShuffleG2_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<double> YShuffleG2_Const(Vector128<double> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<sbyte> YShuffleG2_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<byte> YShuffleG2_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<short> YShuffleG2_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<ushort> YShuffleG2_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<int> YShuffleG2_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<uint> YShuffleG2_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<long> YShuffleG2_Const(Vector128<long> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector128<ulong> YShuffleG2_Const(Vector128<ulong> source, [ConstantExpected] ShuffleControlG2 control);
#endif // !REDUCE_MEMORY_USAGE


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleG4</c> (运行 <c>YShuffleG4</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).</para>
        /// <para>- <see cref="YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>
        /// <seealso cref="YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>
        /// <seealso cref="YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
        TypeCodeFlags YShuffleG4_AcceleratedTypes { get; }

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<float> YShuffleG4(Vector128<float> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<sbyte> YShuffleG4(Vector128<sbyte> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<byte> YShuffleG4(Vector128<byte> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<short> YShuffleG4(Vector128<short> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<ushort> YShuffleG4(Vector128<ushort> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<int> YShuffleG4(Vector128<int> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<uint> YShuffleG4(Vector128<uint> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<float> YShuffleG4_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<sbyte> YShuffleG4_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<byte> YShuffleG4_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<short> YShuffleG4_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<ushort> YShuffleG4_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<int> YShuffleG4_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector128<uint> YShuffleG4_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG4 control);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleG4X2</c> (运行 <c>YShuffleG4X2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).</para>
        /// <para>- <see cref="YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>
        /// <seealso cref="YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>
        /// <seealso cref="YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
        TypeCodeFlags YShuffleG4X2_AcceleratedTypes { get; }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<float> YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control, out Vector128<float> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<double> YShuffleG4X2(Vector128<double> source0, Vector128<double> source1, ShuffleControlG4 control, out Vector128<double> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<sbyte> YShuffleG4X2(Vector128<sbyte> source0, Vector128<sbyte> source1, ShuffleControlG4 control, out Vector128<sbyte> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<byte> YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control, out Vector128<byte> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<short> YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control, out Vector128<short> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<ushort> YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control, out Vector128<ushort> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<int> YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control, out Vector128<int> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<uint> YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control, out Vector128<uint> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<long> YShuffleG4X2(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control, out Vector128<long> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<ulong> YShuffleG4X2(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control, out Vector128<ulong> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<float> YShuffleG4X2_Const(Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<float> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<double> YShuffleG4X2_Const(Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<double> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<sbyte> YShuffleG4X2_Const(Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<sbyte> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<byte> YShuffleG4X2_Const(Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<byte> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<short> YShuffleG4X2_Const(Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<short> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<ushort> YShuffleG4X2_Const(Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ushort> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<int> YShuffleG4X2_Const(Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<int> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<uint> YShuffleG4X2_Const(Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<uint> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<long> YShuffleG4X2_Const(Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<long> result1);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <param name="result1">Returns the 1st vector after shuffle (返回换位后的第1个向量).</param>
        /// <returns>Returns the 0th vector after shuffle (返回换位后的第0个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        Vector128<ulong> YShuffleG4X2_Const(Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ulong> result1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleInsert</c> (运行 <c>YShuffleInsert</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="Shuffle(Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleKernel(Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookupExtension(Vector128{byte}, Vector128{byte}, Vector128{byte})">vqvtbx1q_u8</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>Combine by <see cref="PackedSimd.Swizzle(Vector128{byte}, Vector128{byte})">i8x16.swizzle</see></description>
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
        /// <seealso cref="YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags YShuffleInsert_AcceleratedTypes { get; }

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{float}, Vector128{int})"/>
        Vector128<float> YShuffleInsert(Vector128<float> back, Vector128<float> vector, Vector128<int> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{double}, Vector128{long})"/>
        Vector128<double> YShuffleInsert(Vector128<double> back, Vector128<double> vector, Vector128<long> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{sbyte}, Vector128{sbyte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookupExtension(Vector64{sbyte}, Vector128{sbyte}, Vector64{sbyte})"/>
        Vector128<sbyte> YShuffleInsert(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookupExtension(Vector64{byte}, Vector128{byte}, Vector64{byte})"/>
        Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{short}, Vector128{short})"/>
        Vector128<short> YShuffleInsert(Vector128<short> back, Vector128<short> vector, Vector128<short> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
        Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{int}, Vector128{int})"/>
        Vector128<int> YShuffleInsert(Vector128<int> back, Vector128<int> vector, Vector128<int> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{uint}, Vector128{uint})"/>
        Vector128<uint> YShuffleInsert(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{long}, Vector128{long})"/>
        Vector128<long> YShuffleInsert(Vector128<long> back, Vector128<long> vector, Vector128<long> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{ulong}, Vector128{ulong})"/>
        Vector128<ulong> YShuffleInsert(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices);


        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleInsert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleInsert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleInsert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleInsert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleInsert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleInsert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleInsert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void YShuffleInsert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2);


        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleInsert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleInsert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> YShuffleInsert_Core(Vector128<float> back, Vector128<float> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2);

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleInsert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleInsert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> YShuffleInsert_Core(Vector128<double> back, Vector128<double> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2);

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleInsert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleInsert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookupExtension(Vector64{sbyte}, Vector128{sbyte}, Vector64{sbyte})"/>
        Vector128<sbyte> YShuffleInsert_Core(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2);

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleInsert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleInsert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookupExtension(Vector64{byte}, Vector128{byte}, Vector64{byte})"/>
        Vector128<byte> YShuffleInsert_Core(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2);

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleInsert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleInsert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> YShuffleInsert_Core(Vector128<short> back, Vector128<short> vector, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2);

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleInsert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleInsert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> YShuffleInsert_Core(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2);

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleInsert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleInsert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> YShuffleInsert_Core(Vector128<int> back, Vector128<int> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2);

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleInsert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleInsert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> YShuffleInsert_Core(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2);

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleInsert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleInsert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> YShuffleInsert_Core(Vector128<long> back, Vector128<long> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2);

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleInsert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleInsert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> YShuffleInsert_Core(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleKernel</c> (运行 <c>Shuffle</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="Shuffle(Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleKernel(Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="Ssse3.Shuffle(Vector128{byte}, Vector128{byte})">_mm_shuffle_epi8</see>(Ssse3)</description>
        ///        <description><see cref="Avx512BW.VL.PermuteVar8x16(Vector128{ushort}, Vector128{ushort})">_mm_permutexvar_epi16</see>(Avx512BW)</description>
        ///        <description>Same <see cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})">_mm256_permutevar8x32_epi32</see>(Avx2)</description>
        ///        <description>Same <see cref="Avx512F.VL.PermuteVar4x64(Vector256{ulong}, Vector256{ulong})">_mm256_permute4x64_pd</see>(Avx512F)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags YShuffleKernel_AcceleratedTypes { get; }

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{float}, Vector128{int})"/>
        Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{double}, Vector128{long})"/>
        Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{sbyte}, Vector128{sbyte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{sbyte}, Vector64{sbyte})"/>
        Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{byte}, Vector64{byte})"/>
        Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{short}, Vector128{short})"/>
        Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
        Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{int}, Vector128{int})"/>
        Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{uint}, Vector128{uint})"/>
        Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{long}, Vector128{long})"/>
        Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{ulong}, Vector128{ulong})"/>
        Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices);


        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleKernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleKernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleKernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleKernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleKernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleKernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleKernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void YShuffleKernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1);


        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> YShuffleKernel_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> YShuffleKernel_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{sbyte}, Vector64{sbyte})"/>
        Vector128<sbyte> YShuffleKernel_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{byte}, Vector64{byte})"/>
        Vector128<byte> YShuffleKernel_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> YShuffleKernel_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> YShuffleKernel_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> YShuffleKernel_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> YShuffleKernel_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> YShuffleKernel_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> YShuffleKernel_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX2</c> (运行 <c>YShuffleX2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的参数计算). Provide arguments for YShuffleX2_Core (为 YShuffleX2_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的核心计算). Its arguments are derived from YShuffleX2_Args (其参数来源于 YShuffleX2_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX2(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX2Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX2Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}}, Vector128{byte})">vqtbl2q_u8</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>Combine by <see cref="Avx512Vbmi.VL.PermuteVar16x8x2(Vector128{byte}, Vector128{byte}, Vector128{byte})">_mm_permutex2var_epi8</see>(Avx512Vbmi)</description>
        ///        <description>Combine by <see cref="Avx512BW.VL.PermuteVar8x16x2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})">_mm_permutex2var_epi16</see>(Avx512BW)</description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar4x32x2(Vector128{uint}, Vector128{uint}, Vector128{uint})">_mm_permutex2var_epi32</see>(Avx512F)</description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar2x64x2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})">_mm_permutex2var_epi64</see>(Avx512F)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX2(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="YShuffleX2_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// 
        TypeCodeFlags YShuffleX2_AcceleratedTypes { get; }

        /// <summary>
        /// Shuffle and clear on 2 vectors (在2个向量上进行换位并清零). Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):0</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX2_AcceleratedTypes"/>
        Vector128<float> YShuffleX2(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<double> YShuffleX2(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<sbyte> YShuffleX2(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices);

        /// <inheritdoc cref="YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<byte> YShuffleX2(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices);

        /// <inheritdoc cref="YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<short> YShuffleX2(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices);

        /// <inheritdoc cref="YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ushort> YShuffleX2(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices);

        /// <inheritdoc cref="YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<int> YShuffleX2(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<uint> YShuffleX2(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices);

        /// <inheritdoc cref="YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<long> YShuffleX2(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ulong> YShuffleX2(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices);

        /// <summary>
        /// Arguments calculation for shuffle and clear on 2 vectors (在2个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX2_Core (为 YShuffleX2_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX2_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX2_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX2_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX2_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX2_Core .</param>
        /// <seealso cref="YShuffleX2_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX2_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleX2_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleX2_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleX2_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleX2_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleX2_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleX2_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleX2_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void YShuffleX2_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4);

        /// <summary>
        /// Core calculation for shuffle and clear on 2 vectors (在2个向量上进行换位并清零的核心计算). Its arguments are derived from YShuffleX2_Args (其参数来源于 YShuffleX2_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):0</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleX2_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleX2_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleX2_Args .</param>
        /// <param name="args3">Arguments 3 (参数3). Derived from YShuffleX2_Args .</param>
        /// <param name="args4">Arguments 4 (参数4). Derived from YShuffleX2_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX2_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX2_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> YShuffleX2_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> YShuffleX2_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        Vector128<sbyte> YShuffleX2_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        Vector128<byte> YShuffleX2_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> YShuffleX2_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> YShuffleX2_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> YShuffleX2_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> YShuffleX2_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> YShuffleX2_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> YShuffleX2_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX2Insert</c> (运行 <c>YShuffleX2Insert</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的参数计算). Provide arguments for YShuffleX2Insert_Core (为 YShuffleX2Insert_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的核心计算). Its arguments are derived from YShuffleX2Insert_Args (其参数来源于 YShuffleX2Insert_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX2(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX2Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX2Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookupExtension(Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}}, Vector128{byte})">vqtbx2q_u8</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>Combine by <see cref="Avx512Vbmi.VL.PermuteVar16x8x2(Vector128{byte}, Vector128{byte}, Vector128{byte})">_mm_permutex2var_epi8</see>(Avx512Vbmi)</description>
        ///        <description>Combine by <see cref="Avx512BW.VL.PermuteVar8x16x2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})">_mm_permutex2var_epi16</see>(Avx512BW)</description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar4x32x2(Vector128{uint}, Vector128{uint}, Vector128{uint})">_mm_permutex2var_epi32</see>(Avx512F)</description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar2x64x2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})">_mm_permutex2var_epi64</see>(Avx512F)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX2Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// 
        TypeCodeFlags YShuffleX2Insert_AcceleratedTypes { get; }

        /// <summary>
        /// Shuffle and insert on 2 vectors (在2个向量上进行换位并插入) Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX2Insert_AcceleratedTypes"/>
        Vector128<float> YShuffleX2Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<double> YShuffleX2Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<sbyte> YShuffleX2Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<byte> YShuffleX2Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<short> YShuffleX2Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ushort> YShuffleX2Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<int> YShuffleX2Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<uint> YShuffleX2Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<long> YShuffleX2Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ulong> YShuffleX2Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices);

        /// <summary>
        /// Arguments calculation for shuffle and insert on 2 vectors (在2个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX2Insert_Core (为 YShuffleX2Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX2Insert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX2Insert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX2Insert_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX2Insert_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX2Insert_Core .</param>
        /// <seealso cref="YShuffleX2Insert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleX2Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleX2Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleX2Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleX2Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleX2Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleX2Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleX2Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void YShuffleX2Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4);

        /// <summary>
        /// Core calculation for shuffle and insert on 2 vectors (在2个向量上进行换位并插入的核心计算). Its arguments are derived from YShuffleX2Insert_Args (其参数来源于 YShuffleX2Insert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleX2Insert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleX2Insert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleX2Insert_Args .</param>
        /// <param name="args3">Arguments 3 (参数3). Derived from YShuffleX2Insert_Args .</param>
        /// <param name="args4">Arguments 4 (参数4). Derived from YShuffleX2Insert_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX2Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> YShuffleX2Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> YShuffleX2Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        Vector128<sbyte> YShuffleX2Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        Vector128<byte> YShuffleX2Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> YShuffleX2Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> YShuffleX2Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> YShuffleX2Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> YShuffleX2Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> YShuffleX2Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> YShuffleX2Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX2Kernel</c> (运行 <c>YShuffleX2Kernel</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle on 2 vectors 在2个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX2Kernel_Args (其参数来源于 YShuffleX2Kernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX2(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX2Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX2Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}}, Vector128{byte})">vqtbl2q_u8</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description><see cref="Avx512Vbmi.VL.PermuteVar16x8x2(Vector128{byte}, Vector128{byte}, Vector128{byte})">_mm_permutex2var_epi8</see>(Avx512Vbmi)</description>
        ///        <description><see cref="Avx512BW.VL.PermuteVar8x16x2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})">_mm_permutex2var_epi16</see>(Avx512BW)</description>
        ///        <description><see cref="Avx512F.VL.PermuteVar4x32x2(Vector128{uint}, Vector128{uint}, Vector128{uint})">_mm_permutex2var_epi32</see>(Avx512F)</description>
        ///        <description><see cref="Avx512F.VL.PermuteVar2x64x2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})">_mm_permutex2var_epi64</see>(Avx512F)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX2Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// 
        TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes { get; }

        /// <summary>
        /// Only shuffle on 2 vectors (在2个向量上进行仅换位). Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector128s{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vector128s{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX2Kernel_AcceleratedTypes"/>
        Vector128<float> YShuffleX2Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<double> YShuffleX2Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<sbyte> YShuffleX2Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<byte> YShuffleX2Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<short> YShuffleX2Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ushort> YShuffleX2Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<int> YShuffleX2Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<uint> YShuffleX2Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<long> YShuffleX2Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ulong> YShuffleX2Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices);

        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector128s{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vector128s{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX2Kernel_Core .</param>
        /// <seealso cref="YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleX2Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleX2Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleX2Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleX2Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleX2Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleX2Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleX2Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void YShuffleX2Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3);

        /// <summary>
        /// Core calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX2Kernel_Args (其参数来源于 YShuffleX2Kernel_Args).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleX2Kernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleX2Kernel_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleX2Kernel_Args .</param>
        /// <param name="args3">Arguments 3 (参数3). Derived from YShuffleX2Kernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> YShuffleX2Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> YShuffleX2Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        Vector128<sbyte> YShuffleX2Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        Vector128<byte> YShuffleX2Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> YShuffleX2Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> YShuffleX2Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> YShuffleX2Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> YShuffleX2Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> YShuffleX2Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> YShuffleX2Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX3</c> (运行 <c>YShuffleX3</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的参数计算). Provide arguments for YShuffleX3_Core (为 YShuffleX3_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的核心计算). Its arguments are derived from YShuffleX3_Args (其参数来源于 YShuffleX3_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX3Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX3Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">vqtbl3q_u8</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="YShuffleX3_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// 
        TypeCodeFlags YShuffleX3_AcceleratedTypes { get; }

        /// <summary>
        /// Shuffle and clear on 3 vectors (在3个向量上进行换位并清零). Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):0</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX3_AcceleratedTypes"/>
        Vector128<float> YShuffleX3(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<double> YShuffleX3(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<sbyte> YShuffleX3(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices);

        /// <inheritdoc cref="YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<byte> YShuffleX3(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices);

        /// <inheritdoc cref="YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<short> YShuffleX3(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices);

        /// <inheritdoc cref="YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ushort> YShuffleX3(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices);

        /// <inheritdoc cref="YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<int> YShuffleX3(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<uint> YShuffleX3(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices);

        /// <inheritdoc cref="YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<long> YShuffleX3(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ulong> YShuffleX3(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices);

        /// <summary>
        /// Arguments calculation for shuffle and clear on 3 vectors (在3个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX3_Core (为 YShuffleX3_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX3_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX3_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX3_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX3_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX3_Core .</param>
        /// <seealso cref="YShuffleX3_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX3_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleX3_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleX3_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleX3_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleX3_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleX3_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleX3_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleX3_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void YShuffleX3_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4);

        /// <summary>
        /// Core calculation for shuffle and clear on 3 vectors (在3个向量上进行换位并清零的核心计算). Its arguments are derived from YShuffleX3_Args (其参数来源于 YShuffleX3_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):0</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleX3_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleX3_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleX3_Args .</param>
        /// <param name="args3">Arguments 3 (参数3). Derived from YShuffleX3_Args .</param>
        /// <param name="args4">Arguments 4 (参数4). Derived from YShuffleX3_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX3_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX3_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> YShuffleX3_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> YShuffleX3_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        Vector128<sbyte> YShuffleX3_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        Vector128<byte> YShuffleX3_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> YShuffleX3_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> YShuffleX3_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> YShuffleX3_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> YShuffleX3_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> YShuffleX3_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> YShuffleX3_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX3Insert</c> (运行 <c>YShuffleX3Insert</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的参数计算). Provide arguments for YShuffleX3Insert_Core (为 YShuffleX3Insert_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的核心计算). Its arguments are derived from YShuffleX3Insert_Args (其参数来源于 YShuffleX3Insert_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX3Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX3Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookupExtension(Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">vqtbx3q_u8</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX3Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// 
        TypeCodeFlags YShuffleX3Insert_AcceleratedTypes { get; }

        /// <summary>
        /// Shuffle and insert on 3 vectors (在3个向量上进行换位并插入) Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX3Insert_AcceleratedTypes"/>
        Vector128<float> YShuffleX3Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<double> YShuffleX3Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<sbyte> YShuffleX3Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<byte> YShuffleX3Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<short> YShuffleX3Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ushort> YShuffleX3Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<int> YShuffleX3Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<uint> YShuffleX3Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<long> YShuffleX3Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ulong> YShuffleX3Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices);

        /// <summary>
        /// Arguments calculation for shuffle and insert on 3 vectors (在3个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX3Insert_Core (为 YShuffleX3Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX3Insert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX3Insert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX3Insert_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX3Insert_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX3Insert_Core .</param>
        /// <seealso cref="YShuffleX3Insert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleX3Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleX3Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleX3Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleX3Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleX3Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleX3Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleX3Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void YShuffleX3Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4);

        /// <summary>
        /// Core calculation for shuffle and insert on 3 vectors (在3个向量上进行换位并插入的核心计算). Its arguments are derived from YShuffleX3Insert_Args (其参数来源于 YShuffleX3Insert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleX3Insert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleX3Insert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleX3Insert_Args .</param>
        /// <param name="args3">Arguments 3 (参数3). Derived from YShuffleX3Insert_Args .</param>
        /// <param name="args4">Arguments 4 (参数4). Derived from YShuffleX3Insert_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX3Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> YShuffleX3Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> YShuffleX3Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        Vector128<sbyte> YShuffleX3Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        Vector128<byte> YShuffleX3Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> YShuffleX3Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> YShuffleX3Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> YShuffleX3Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> YShuffleX3Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> YShuffleX3Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> YShuffleX3Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX3Kernel</c> (运行 <c>YShuffleX3Kernel</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle on 3 vectors (在3个向量上进行仅换位的参数计算). Provide arguments for YShuffleX3Kernel_Core (为 YShuffleX3Kernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle on 3 vectors 在3个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX3Kernel_Args (其参数来源于 YShuffleX3Kernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX3Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX3Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">vqtbl3q_u8</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX3Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// 
        TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes { get; }

        /// <summary>
        /// Only shuffle on 3 vectors (在3个向量上进行仅换位). Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX3Kernel_AcceleratedTypes"/>
        Vector128<float> YShuffleX3Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<double> YShuffleX3Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<sbyte> YShuffleX3Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<byte> YShuffleX3Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<short> YShuffleX3Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ushort> YShuffleX3Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<int> YShuffleX3Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<uint> YShuffleX3Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<long> YShuffleX3Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ulong> YShuffleX3Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices);

        /// <summary>
        /// Arguments calculation for only shuffle on 3 vectors (在3个向量上进行仅换位的参数计算). Provide arguments for YShuffleX3Kernel_Core (为 YShuffleX3Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX3Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX3Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX3Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX3Kernel_Core .</param>
        /// <seealso cref="YShuffleX3Kernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleX3Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleX3Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleX3Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleX3Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleX3Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleX3Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleX3Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void YShuffleX3Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3);

        /// <summary>
        /// Core calculation for only shuffle on 3 vectors (在3个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX3Kernel_Args (其参数来源于 YShuffleX3Kernel_Args).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 1 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleX3Kernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleX3Kernel_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleX3Kernel_Args .</param>
        /// <param name="args3">Arguments 3 (参数3). Derived from YShuffleX3Kernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX3Kernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> YShuffleX3Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> YShuffleX3Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        Vector128<sbyte> YShuffleX3Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        Vector128<byte> YShuffleX3Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> YShuffleX3Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> YShuffleX3Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> YShuffleX3Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> YShuffleX3Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> YShuffleX3Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> YShuffleX3Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX4</c> (运行 <c>YShuffleX4</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的参数计算). Provide arguments for YShuffleX4_Core (为 YShuffleX4_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的核心计算). Its arguments are derived from YShuffleX4_Args (其参数来源于 YShuffleX4_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX4Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX4Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">vqtbl4q_u8</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="YShuffleX4_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// 
        TypeCodeFlags YShuffleX4_AcceleratedTypes { get; }

        /// <summary>
        /// Shuffle and clear on 4 vectors (在4个向量上进行换位并清零). Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):0</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX4_AcceleratedTypes"/>
        Vector128<float> YShuffleX4(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<double> YShuffleX4(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<sbyte> YShuffleX4(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices);

        /// <inheritdoc cref="YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<byte> YShuffleX4(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices);

        /// <inheritdoc cref="YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<short> YShuffleX4(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices);

        /// <inheritdoc cref="YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ushort> YShuffleX4(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices);

        /// <inheritdoc cref="YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<int> YShuffleX4(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<uint> YShuffleX4(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices);

        /// <inheritdoc cref="YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<long> YShuffleX4(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ulong> YShuffleX4(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices);

        /// <summary>
        /// Arguments calculation for shuffle and clear on 4 vectors (在4个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX4_Core (为 YShuffleX4_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX4_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX4_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX4_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX4_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX4_Core .</param>
        /// <seealso cref="YShuffleX4_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX4_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleX4_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleX4_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleX4_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleX4_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleX4_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleX4_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleX4_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void YShuffleX4_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4);

        /// <summary>
        /// Core calculation for shuffle and clear on 4 vectors (在4个向量上进行换位并清零的核心计算). Its arguments are derived from YShuffleX4_Args (其参数来源于 YShuffleX4_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):0</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleX4_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleX4_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleX4_Args .</param>
        /// <param name="args3">Arguments 3 (参数3). Derived from YShuffleX4_Args .</param>
        /// <param name="args4">Arguments 4 (参数4). Derived from YShuffleX4_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX4_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX4_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> YShuffleX4_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> YShuffleX4_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        Vector128<sbyte> YShuffleX4_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        Vector128<byte> YShuffleX4_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> YShuffleX4_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> YShuffleX4_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> YShuffleX4_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> YShuffleX4_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> YShuffleX4_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> YShuffleX4_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX4Insert</c> (运行 <c>YShuffleX4Insert</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的参数计算). Provide arguments for YShuffleX4Insert_Core (为 YShuffleX4Insert_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的核心计算). Its arguments are derived from YShuffleX4Insert_Args (其参数来源于 YShuffleX4Insert_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX4Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX4Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description>Same <see cref="AdvSimd.Arm64.VectorTableLookupExtension(Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">vqtbx4q_u8</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX4Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// 
        TypeCodeFlags YShuffleX4Insert_AcceleratedTypes { get; }

        /// <summary>
        /// Shuffle and insert on 4 vectors (在4个向量上进行换位并插入) Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX4Insert_AcceleratedTypes"/>
        Vector128<float> YShuffleX4Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<double> YShuffleX4Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<sbyte> YShuffleX4Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<byte> YShuffleX4Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<short> YShuffleX4Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ushort> YShuffleX4Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<int> YShuffleX4Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<uint> YShuffleX4Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<long> YShuffleX4Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ulong> YShuffleX4Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices);

        /// <summary>
        /// Arguments calculation for shuffle and insert on 4 vectors (在4个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX4Insert_Core (为 YShuffleX4Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX4Insert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX4Insert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX4Insert_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX4Insert_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX4Insert_Core .</param>
        /// <seealso cref="YShuffleX4Insert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleX4Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleX4Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleX4Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleX4Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleX4Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleX4Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleX4Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void YShuffleX4Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4);

        /// <summary>
        /// Core calculation for shuffle and insert on 4 vectors (在4个向量上进行换位并插入的核心计算). Its arguments are derived from YShuffleX4Insert_Args (其参数来源于 YShuffleX4Insert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleX4Insert_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleX4Insert_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleX4Insert_Args .</param>
        /// <param name="args3">Arguments 3 (参数3). Derived from YShuffleX4Insert_Args .</param>
        /// <param name="args4">Arguments 4 (参数4). Derived from YShuffleX4Insert_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX4Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> YShuffleX4Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> YShuffleX4Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        Vector128<sbyte> YShuffleX4Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        Vector128<byte> YShuffleX4Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> YShuffleX4Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> YShuffleX4Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> YShuffleX4Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> YShuffleX4Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> YShuffleX4Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> YShuffleX4Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX4Kernel</c> (运行 <c>YShuffleX4Kernel</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle on 4 vectors 在4个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX4Kernel_Args (其参数来源于 YShuffleX4Kernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX4Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX4Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">vqtbl4q_u8</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX4Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        /// 
        TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes { get; }

        /// <summary>
        /// Only shuffle on 4 vectors (在4个向量上进行仅换位). Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector128s{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vector128s{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX4Kernel_AcceleratedTypes"/>
        Vector128<float> YShuffleX4Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<double> YShuffleX4Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<sbyte> YShuffleX4Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<byte> YShuffleX4Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<short> YShuffleX4Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ushort> YShuffleX4Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<int> YShuffleX4Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<uint> YShuffleX4Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<long> YShuffleX4Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
        Vector128<ulong> YShuffleX4Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices);

        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector128s{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vector128s{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX4Kernel_Core .</param>
        /// <seealso cref="YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleX4Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleX4Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleX4Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleX4Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleX4Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleX4Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleX4Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void YShuffleX4Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3);

        /// <summary>
        /// Core calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX4Kernel_Args (其参数来源于 YShuffleX4Kernel_Args).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleX4Kernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleX4Kernel_Args .</param>
        /// <param name="args2">Arguments 2 (参数2). Derived from YShuffleX4Kernel_Args .</param>
        /// <param name="args3">Arguments 3 (参数3). Derived from YShuffleX4Kernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> YShuffleX4Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> YShuffleX4Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        Vector128<sbyte> YShuffleX4Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        Vector128<byte> YShuffleX4Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> YShuffleX4Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> YShuffleX4Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> YShuffleX4Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> YShuffleX4Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> YShuffleX4Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> YShuffleX4Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YSign</c> (运行 <c>YSign</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YSign(Vector128{float})"/>
        TypeCodeFlags YSign_AcceleratedTypes { get; }

        /// <summary>
        /// Determine the sign of each element (判断各个元素的符号).
        /// Mnemonic: <c>rt[i] := sign(value[i])</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements depend on the sign of the corresponding element of <paramref name="value" />:  Returns 1 if the value is positive, 0 if the value is zero, and -1 if the value is negative (一个向量，其元素取决于value的对应元素的符号情况: 值为正数时返回1, 值为0时返回0, 值为负数时返回-1).</returns>
        /// <seealso cref="YSign_AcceleratedTypes"/>
        /// <seealso cref="MathINumber.Sign(float)"/>
        Vector128<int> YSign(Vector128<float> value);

        /// <inheritdoc cref="YSign(Vector128{float})"/>
        /// <seealso cref="MathINumber.Sign(double)"/>
        Vector128<long> YSign(Vector128<double> value);

        /// <inheritdoc cref="YSign(Vector128{float})"/>
        /// <seealso cref="MathINumber.Sign(sbyte)"/>
        Vector128<sbyte> YSign(Vector128<sbyte> value);

        /// <inheritdoc cref="YSign(Vector128{float})"/>
        /// <seealso cref="MathINumber.Sign(short)"/>
        Vector128<short> YSign(Vector128<short> value);

        /// <inheritdoc cref="YSign(Vector128{float})"/>
        /// <seealso cref="MathINumber.Sign(int)"/>
        Vector128<int> YSign(Vector128<int> value);

        /// <inheritdoc cref="YSign(Vector128{float})"/>
        /// <seealso cref="MathINumber.Sign(long)"/>
        Vector128<long> YSign(Vector128<long> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YSignFloat</c> (运行 <c>YSignFloat</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YSignFloat(Vector128{float})"/>
        TypeCodeFlags YSignFloat_AcceleratedTypes { get; }

        /// <summary>
        /// Determine the sign of each element and returns a floating point number (判断各个元素的符号并返回浮点数).
        /// Mnemonic: <c>rt[i] := signFloat(value[i])</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements depend on the sign of the corresponding element of <paramref name="value" />: Returns 1 if the value is positive, 0 if the value is zero, -1 if the value is negative, and <c>NaN</c> if the value is <c>NaN</c> (一个向量，其元素取决于value的对应元素的符号情况: 值为正数时返回1, 值为0时返回0, 值为负数时返回-1, 值为<c>NaN</c>时返回<c>NaN</c>).</returns>
        /// <seealso cref="YSignFloat_AcceleratedTypes"/>
        /// <seealso cref="MathINumber.Sign(float)"/>
        Vector128<float> YSignFloat(Vector128<float> value);

        /// <inheritdoc cref="YSignFloat(Vector128{float})"/>
        /// <seealso cref="MathINumber.Sign(double)"/>
        Vector128<double> YSignFloat(Vector128<double> value);

#endif
    }
}
