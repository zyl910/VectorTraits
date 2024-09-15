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
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl {
    partial interface IVectorTraits {

        // == mY style  ==

        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToByte</c> (运行 <c>YBitToByte</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector{byte})"/>.</para>
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
        Vector<byte> YBitToByte(ulong value);


        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToInt16</c> (运行 <c>YBitToInt16</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector{short})"/>.</para>
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
        Vector<short> YBitToInt16(ulong value);


        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToInt32</c> (运行 <c>YBitToInt32</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector{int})"/>.</para>
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
        Vector<int> YBitToInt32(ulong value);


        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToInt64</c> (运行 <c>YBitToInt64</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector{long})"/>.</para>
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
        Vector<long> YBitToInt64(ulong value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YClamp</c> (运行 <c>YClamp</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YClamp(Vector{byte}, Vector{byte}, Vector{byte})"/>
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
        /// Types with hardware acceleration when running <c>YCopySign</c> (运行 <c>YCopySign</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YCopySign(Vector{float}, Vector{float})"/>
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
        Vector<float> YCopySign(Vector<float> value, Vector<float> sign);

        /// <inheritdoc cref="YCopySign(Vector{float}, Vector{float})"/>
        /// <seealso cref="MathINumber.CopySign(double, double)"/>
        Vector<double> YCopySign(Vector<double> value, Vector<double> sign);

        /// <inheritdoc cref="YCopySign(Vector{float}, Vector{float})"/>
        /// <seealso cref="MathINumber.CopySign(sbyte, sbyte)"/>
        Vector<sbyte> YCopySign(Vector<sbyte> value, Vector<sbyte> sign);

        /// <inheritdoc cref="YCopySign(Vector{float}, Vector{float})"/>
        /// <seealso cref="MathINumber.CopySign(short, short)"/>
        Vector<short> YCopySign(Vector<short> value, Vector<short> sign);

        /// <inheritdoc cref="YCopySign(Vector{float}, Vector{float})"/>
        /// <seealso cref="MathINumber.CopySign(int, int)"/>
        Vector<int> YCopySign(Vector<int> value, Vector<int> sign);

        /// <inheritdoc cref="YCopySign(Vector{float}, Vector{float})"/>
        /// <seealso cref="MathINumber.CopySign(long, long)"/>
        Vector<long> YCopySign(Vector<long> value, Vector<long> sign);


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
        ///        <description><see cref="AdvSimd.Arm64.UnzipEven(Vector128{byte}, Vector128{byte})">UZP1(vuzp1q_u8)</see>/<see cref="AdvSimd.Arm64.UnzipOdd(Vector128{byte}, Vector128{byte})">UZP2(vuzp2q_u8)</see></description>
        ///        <description><see cref="AdvSimd.Arm64.UnzipEven(Vector128{ushort}, Vector128{ushort})">UZP1(vuzp1q_u16)</see>/<see cref="AdvSimd.Arm64.UnzipOdd(Vector128{ushort}, Vector128{ushort})">UZP2(vuzp2q_u16)</see></description>
        ///        <description><see cref="AdvSimd.Arm64.UnzipEven(Vector128{uint}, Vector128{uint})">UZP1(vuzp1q_u32)</see>/<see cref="AdvSimd.Arm64.UnzipOdd(Vector128{uint}, Vector128{uint})">UZP2(vuzp2q_u32)</see></description>
        ///        <description><see cref="AdvSimd.Arm64.UnzipEven(Vector128{ulong}, Vector128{ulong})">UZP1(vuzp1q_u64)</see>/<see cref="AdvSimd.Arm64.UnzipOdd(Vector128{ulong}, Vector128{ulong})">UZP2(vuzp2q_u64)</see></description>
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
        /// <seealso cref="YGroup2Unzip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
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
        Vector<float> YGroup2Unzip(Vector<float> data0, Vector<float> data1, out Vector<float> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<double> YGroup2Unzip(Vector<double> data0, Vector<double> data1, out Vector<double> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<sbyte> YGroup2Unzip(Vector<sbyte> data0, Vector<sbyte> data1, out Vector<sbyte> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<byte> YGroup2Unzip(Vector<byte> data0, Vector<byte> data1, out Vector<byte> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<short> YGroup2Unzip(Vector<short> data0, Vector<short> data1, out Vector<short> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<ushort> YGroup2Unzip(Vector<ushort> data0, Vector<ushort> data1, out Vector<ushort> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<int> YGroup2Unzip(Vector<int> data0, Vector<int> data1, out Vector<int> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<uint> YGroup2Unzip(Vector<uint> data0, Vector<uint> data1, out Vector<uint> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<long> YGroup2Unzip(Vector<long> data0, Vector<long> data1, out Vector<long> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<ulong> YGroup2Unzip(Vector<ulong> data0, Vector<ulong> data1, out Vector<ulong> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<ExInt128> YGroup2Unzip(Vector<ExInt128> data0, Vector<ExInt128> data1, out Vector<ExInt128> y);

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<ExUInt128> YGroup2Unzip(Vector<ExUInt128> data0, Vector<ExUInt128> data1, out Vector<ExUInt128> y);

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
        Vector<T> YGroup2Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, out Vector<T> y) where T : struct;

        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2UnzipEven</c> (运行 <c>YGroup2UnzipEven</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2UnzipEven + YGroup2UnzipOdd = YGroup2Unzip</c>. See more: <see cref="YGroup2Unzip_AcceleratedTypes"/>.</para>
        /// </remarks>
        /// <seealso cref="YGroup2UnzipEven(Vector{byte}, Vector{byte})"/>
        TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes { get; }

        /// <summary>
        /// De-Interleave the 2-element groups into 2 vectors, and return the vector of even positions (将2-元素组解交织为2个向量, 并返回偶数位置的数据).
        /// Mnemonic: <c>rt[i] =: element_ref(2*i, data0, data1)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 2-element groups - Part 0 (由2元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 2-element groups - Part 1 (由2元素组所组成的向量 - 第1部分).</param>
        /// <returns>Returns the vector made of the X-components (返回X分量所组成的向量).</returns>
        /// <seealso cref="YGroup2UnzipEven_AcceleratedTypes"/>
        Vector<float> YGroup2UnzipEven(Vector<float> data0, Vector<float> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        Vector<double> YGroup2UnzipEven(Vector<double> data0, Vector<double> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        Vector<sbyte> YGroup2UnzipEven(Vector<sbyte> data0, Vector<sbyte> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        Vector<byte> YGroup2UnzipEven(Vector<byte> data0, Vector<byte> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        Vector<short> YGroup2UnzipEven(Vector<short> data0, Vector<short> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        Vector<ushort> YGroup2UnzipEven(Vector<ushort> data0, Vector<ushort> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        Vector<int> YGroup2UnzipEven(Vector<int> data0, Vector<int> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        Vector<uint> YGroup2UnzipEven(Vector<uint> data0, Vector<uint> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        Vector<long> YGroup2UnzipEven(Vector<long> data0, Vector<long> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        Vector<ulong> YGroup2UnzipEven(Vector<ulong> data0, Vector<ulong> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        Vector<ExInt128> YGroup2UnzipEven(Vector<ExInt128> data0, Vector<ExInt128> data1);

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{float}, Vector{float})"/>
        Vector<ExUInt128> YGroup2UnzipEven(Vector<ExUInt128> data0, Vector<ExUInt128> data1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2UnzipOdd</c> (运行 <c>YGroup2UnzipOdd</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2UnzipEven + YGroup2UnzipOdd = YGroup2Unzip</c>. See more: <see cref="YGroup2Unzip_AcceleratedTypes"/>.</para>
        /// </remarks>
        /// <seealso cref="YGroup2UnzipOdd(Vector{byte}, Vector{byte})"/>
        TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes { get; }

        /// <summary>
        /// De-Interleave the 2-element groups into 2 vectors, and return the vector of odd positions (将2-元素组解交织为2个向量, 并返回奇数位置的数据).
        /// Mnemonic: <c>rt[i] =: element_ref(2*i+1, data0, data1)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 2-element groups - Part 0 (由2元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 2-element groups - Part 1 (由2元素组所组成的向量 - 第1部分).</param>
        /// <returns>Returns the vector made of the Y-components (返回Y分量所组成的向量).</returns>
        /// <seealso cref="YGroup2UnzipOdd_AcceleratedTypes"/>
        Vector<float> YGroup2UnzipOdd(Vector<float> data0, Vector<float> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        Vector<double> YGroup2UnzipOdd(Vector<double> data0, Vector<double> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        Vector<sbyte> YGroup2UnzipOdd(Vector<sbyte> data0, Vector<sbyte> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        Vector<byte> YGroup2UnzipOdd(Vector<byte> data0, Vector<byte> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        Vector<short> YGroup2UnzipOdd(Vector<short> data0, Vector<short> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        Vector<ushort> YGroup2UnzipOdd(Vector<ushort> data0, Vector<ushort> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        Vector<int> YGroup2UnzipOdd(Vector<int> data0, Vector<int> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        Vector<uint> YGroup2UnzipOdd(Vector<uint> data0, Vector<uint> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        Vector<long> YGroup2UnzipOdd(Vector<long> data0, Vector<long> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        Vector<ulong> YGroup2UnzipOdd(Vector<ulong> data0, Vector<ulong> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        Vector<ExInt128> YGroup2UnzipOdd(Vector<ExInt128> data0, Vector<ExInt128> data1);

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
        Vector<ExUInt128> YGroup2UnzipOdd(Vector<ExUInt128> data0, Vector<ExUInt128> data1);


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
        ///        <description><see cref="AdvSimd.Arm64.ZipLow(Vector128{byte}, Vector128{byte})">ZIP1(vzip1q_u8)</see>/<see cref="AdvSimd.Arm64.ZipHigh(Vector128{byte}, Vector128{byte})">ZIP2(vzip2q_u8)</see></description>
        ///        <description><see cref="AdvSimd.Arm64.ZipLow(Vector128{ushort}, Vector128{ushort})">ZIP1(vzip1q_u16)</see>/<see cref="AdvSimd.Arm64.ZipHigh(Vector128{ushort}, Vector128{ushort})">ZIP2(vzip2q_u16)</see></description>
        ///        <description><see cref="AdvSimd.Arm64.ZipLow(Vector128{uint}, Vector128{uint})">ZIP1(vzip1q_u32)</see>/<see cref="AdvSimd.Arm64.ZipHigh(Vector128{uint}, Vector128{uint})">ZIP2(vzip2q_u32)</see></description>
        ///        <description><see cref="AdvSimd.Arm64.ZipLow(Vector128{ulong}, Vector128{ulong})">ZIP1(vzip1q_u64)</see>/<see cref="AdvSimd.Arm64.ZipHigh(Vector128{ulong}, Vector128{ulong})">ZIP2(vzip2q_u64)</see></description>
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
        ///        <description><see cref="Sse2.UnpackLow(Vector128{byte}, Vector128{byte})">PUNPCKLBW(_mm_unpacklo_epi8)</see>/<see cref="Sse2.UnpackHigh(Vector128{byte}, Vector128{byte})">PUNPCKHBW(_mm_unpackhi_epi8)</see></description>
        ///        <description><see cref="Sse2.UnpackLow(Vector128{ushort}, Vector128{ushort})">PUNPCKLWD(_mm_unpacklo_epi16)</see>/<see cref="Sse2.UnpackHigh(Vector128{ushort}, Vector128{ushort})">PUNPCKHWD(_mm_unpackhi_epi16)</see></description>
        ///        <description><see cref="Sse2.UnpackLow(Vector128{uint}, Vector128{uint})">PUNPCKLDQ(_mm_unpacklo_epi32)</see>/<see cref="Sse2.UnpackHigh(Vector128{uint}, Vector128{uint})">PUNPCKHDQ(_mm_unpackhi_epi32)</see></description>
        ///        <description><see cref="Sse2.UnpackLow(Vector128{ulong}, Vector128{ulong})">PUNPCKLQDQ(_mm_unpacklo_epi64)</see>/<see cref="Sse2.UnpackHigh(Vector128{ulong}, Vector128{ulong})">PUNPCKHQDQ(_mm_unpackhi_epi64)</see></description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YGroup2Zip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
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
        Vector<float> YGroup2Zip(Vector<float> x, Vector<float> y, out Vector<float> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<double> YGroup2Zip(Vector<double> x, Vector<double> y, out Vector<double> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<sbyte> YGroup2Zip(Vector<sbyte> x, Vector<sbyte> y, out Vector<sbyte> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<byte> YGroup2Zip(Vector<byte> x, Vector<byte> y, out Vector<byte> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<short> YGroup2Zip(Vector<short> x, Vector<short> y, out Vector<short> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<ushort> YGroup2Zip(Vector<ushort> x, Vector<ushort> y, out Vector<ushort> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<int> YGroup2Zip(Vector<int> x, Vector<int> y, out Vector<int> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<uint> YGroup2Zip(Vector<uint> x, Vector<uint> y, out Vector<uint> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<long> YGroup2Zip(Vector<long> x, Vector<long> y, out Vector<long> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<ulong> YGroup2Zip(Vector<ulong> x, Vector<ulong> y, out Vector<ulong> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<ExInt128> YGroup2Zip(Vector<ExInt128> x, Vector<ExInt128> y, out Vector<ExInt128> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
        Vector<ExUInt128> YGroup2Zip(Vector<ExUInt128> x, Vector<ExUInt128> y, out Vector<ExUInt128> data1);

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
        Vector<T> YGroup2Zip_Bit128<T>(Vector<T> x, Vector<T> y, out Vector<T> data1) where T : struct;

        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2ZipHigh</c> (运行 <c>YGroup2ZipHigh</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2ZipLow + YGroup2ZipHigh = YGroup2Zip </c>. See more: <see cref="YGroup2Zip_AcceleratedTypes"/>.</para>
        /// </remarks>
        /// <seealso cref="YGroup2ZipHigh(Vector{byte}, Vector{byte})"/>
        TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes { get; }

        /// <summary>
        /// Interleave 2 vectors into 2-element groups and returns the data in the high position. (将2个向量交织为2-元素组, 并返回高位置的数据).
        /// Mnemonic: <c>rt[i] := (0==(i&amp;1))?( x[i2] ):( y[i2] )</c>, <c>i2 := (i+T.Count)/2</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <returns>Returns part 1 of the interleaved data (返回交织后数据的第1部分).</returns>
        /// <seealso cref="YGroup2ZipHigh_AcceleratedTypes"/>
        Vector<float> YGroup2ZipHigh(Vector<float> x, Vector<float> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        Vector<double> YGroup2ZipHigh(Vector<double> x, Vector<double> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        Vector<sbyte> YGroup2ZipHigh(Vector<sbyte> x, Vector<sbyte> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        Vector<byte> YGroup2ZipHigh(Vector<byte> x, Vector<byte> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        Vector<short> YGroup2ZipHigh(Vector<short> x, Vector<short> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        Vector<ushort> YGroup2ZipHigh(Vector<ushort> x, Vector<ushort> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        Vector<int> YGroup2ZipHigh(Vector<int> x, Vector<int> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        Vector<uint> YGroup2ZipHigh(Vector<uint> x, Vector<uint> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        Vector<long> YGroup2ZipHigh(Vector<long> x, Vector<long> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        Vector<ulong> YGroup2ZipHigh(Vector<ulong> x, Vector<ulong> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        Vector<ExInt128> YGroup2ZipHigh(Vector<ExInt128> x, Vector<ExInt128> y);

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        Vector<ExUInt128> YGroup2ZipHigh(Vector<ExUInt128> x, Vector<ExUInt128> y);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2ZipLow</c> (运行 <c>YGroup2ZipLow</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para><c>YGroup2ZipLow + YGroup2ZipHigh = YGroup2Zip </c>. See more: <see cref="YGroup2Zip_AcceleratedTypes"/>.</para>
        /// </remarks>
        /// <seealso cref="YGroup2ZipLow(Vector{byte}, Vector{byte})"/>
        TypeCodeFlags YGroup2ZipLow_AcceleratedTypes { get; }

        /// <summary>
        /// Interleave 2 vectors into 2-element groups and returns the data in the low position. (将2个向量交织为2-元素组, 并返回低位置的数据).
        /// Mnemonic: <c>rt[i] := (0==(i&amp;1))?( x[i2] ):( y[i2] )</c>, <c>i2 := i/2</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        /// <seealso cref="YGroup2ZipLow_AcceleratedTypes"/>
        Vector<float> YGroup2ZipLow(Vector<float> x, Vector<float> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        Vector<double> YGroup2ZipLow(Vector<double> x, Vector<double> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        Vector<sbyte> YGroup2ZipLow(Vector<sbyte> x, Vector<sbyte> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        Vector<byte> YGroup2ZipLow(Vector<byte> x, Vector<byte> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        Vector<short> YGroup2ZipLow(Vector<short> x, Vector<short> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        Vector<ushort> YGroup2ZipLow(Vector<ushort> x, Vector<ushort> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        Vector<int> YGroup2ZipLow(Vector<int> x, Vector<int> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        Vector<uint> YGroup2ZipLow(Vector<uint> x, Vector<uint> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        Vector<long> YGroup2ZipLow(Vector<long> x, Vector<long> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        Vector<ulong> YGroup2ZipLow(Vector<ulong> x, Vector<ulong> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        Vector<ExInt128> YGroup2ZipLow(Vector<ExInt128> x, Vector<ExInt128> y);

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        Vector<ExUInt128> YGroup2ZipLow(Vector<ExUInt128> x, Vector<ExUInt128> y);


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
        /// <seealso cref="YGroup3ToGroup4(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
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
        Vector<float> YGroup3ToGroup4(Vector<float> data0, Vector<float> data1, Vector<float> data2, out Vector<float> result1, out Vector<float> result2, out Vector<float> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<double> YGroup3ToGroup4(Vector<double> data0, Vector<double> data1, Vector<double> data2, out Vector<double> result1, out Vector<double> result2, out Vector<double> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<sbyte> YGroup3ToGroup4(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, out Vector<sbyte> result1, out Vector<sbyte> result2, out Vector<sbyte> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<byte> YGroup3ToGroup4(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, out Vector<byte> result1, out Vector<byte> result2, out Vector<byte> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<short> YGroup3ToGroup4(Vector<short> data0, Vector<short> data1, Vector<short> data2, out Vector<short> result1, out Vector<short> result2, out Vector<short> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ushort> YGroup3ToGroup4(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, out Vector<ushort> result1, out Vector<ushort> result2, out Vector<ushort> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<int> YGroup3ToGroup4(Vector<int> data0, Vector<int> data1, Vector<int> data2, out Vector<int> result1, out Vector<int> result2, out Vector<int> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<uint> YGroup3ToGroup4(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, out Vector<uint> result1, out Vector<uint> result2, out Vector<uint> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<long> YGroup3ToGroup4(Vector<long> data0, Vector<long> data1, Vector<long> data2, out Vector<long> result1, out Vector<long> result2, out Vector<long> result3);

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ulong> YGroup3ToGroup4(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, out Vector<ulong> result1, out Vector<ulong> result2, out Vector<ulong> result3);


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
        /// <seealso cref="YGroup3Unzip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
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
        Vector<float> YGroup3Unzip(Vector<float> data0, Vector<float> data1, Vector<float> data2, out Vector<float> y, out Vector<float> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<double> YGroup3Unzip(Vector<double> data0, Vector<double> data1, Vector<double> data2, out Vector<double> y, out Vector<double> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<sbyte> YGroup3Unzip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, out Vector<sbyte> y, out Vector<sbyte> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<byte> YGroup3Unzip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, out Vector<byte> y, out Vector<byte> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<short> YGroup3Unzip(Vector<short> data0, Vector<short> data1, Vector<short> data2, out Vector<short> y, out Vector<short> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ushort> YGroup3Unzip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, out Vector<ushort> y, out Vector<ushort> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<int> YGroup3Unzip(Vector<int> data0, Vector<int> data1, Vector<int> data2, out Vector<int> y, out Vector<int> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<uint> YGroup3Unzip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, out Vector<uint> y, out Vector<uint> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<long> YGroup3Unzip(Vector<long> data0, Vector<long> data1, Vector<long> data2, out Vector<long> y, out Vector<long> z);

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ulong> YGroup3Unzip(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, out Vector<ulong> y, out Vector<ulong> z);

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
        Vector<T> YGroup3Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, out Vector<T> y, out Vector<T> z) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup3UnzipX2</c> (运行 <c>YGroup3UnzipX2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>It has the same functionality as the <see cref="YGroup3Unzip_AcceleratedTypes">YGroup3Unzip</see> method. It is optimized for process 2x data (它的功能与 <see cref="YGroup3Unzip_AcceleratedTypes">YGroup3Unzip</see> 方法相同. 它为处理2倍数据做了专门的优化).</para>
        /// <para>Inverse function (逆函数): <see cref="YGroup3ZipX2_AcceleratedTypes">YGroup3ZipX2</see>.</para>
        /// </remarks>
        /// <seealso cref="YGroup3UnzipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
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
        Vector<float> YGroup3UnzipX2(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, Vector<float> data4, Vector<float> data5, out Vector<float> xB, out Vector<float> y, out Vector<float> yB, out Vector<float> z, out Vector<float> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<double> YGroup3UnzipX2(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, Vector<double> data4, Vector<double> data5, out Vector<double> xB, out Vector<double> y, out Vector<double> yB, out Vector<double> z, out Vector<double> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<sbyte> YGroup3UnzipX2(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, Vector<sbyte> data4, Vector<sbyte> data5, out Vector<sbyte> xB, out Vector<sbyte> y, out Vector<sbyte> yB, out Vector<sbyte> z, out Vector<sbyte> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<byte> YGroup3UnzipX2(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, Vector<byte> data4, Vector<byte> data5, out Vector<byte> xB, out Vector<byte> y, out Vector<byte> yB, out Vector<byte> z, out Vector<byte> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<short> YGroup3UnzipX2(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, Vector<short> data4, Vector<short> data5, out Vector<short> xB, out Vector<short> y, out Vector<short> yB, out Vector<short> z, out Vector<short> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ushort> YGroup3UnzipX2(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, Vector<ushort> data4, Vector<ushort> data5, out Vector<ushort> xB, out Vector<ushort> y, out Vector<ushort> yB, out Vector<ushort> z, out Vector<ushort> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<int> YGroup3UnzipX2(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, Vector<int> data4, Vector<int> data5, out Vector<int> xB, out Vector<int> y, out Vector<int> yB, out Vector<int> z, out Vector<int> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<uint> YGroup3UnzipX2(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, Vector<uint> data4, Vector<uint> data5, out Vector<uint> xB, out Vector<uint> y, out Vector<uint> yB, out Vector<uint> z, out Vector<uint> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<long> YGroup3UnzipX2(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, Vector<long> data4, Vector<long> data5, out Vector<long> xB, out Vector<long> y, out Vector<long> yB, out Vector<long> z, out Vector<long> zB);

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ulong> YGroup3UnzipX2(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, Vector<ulong> data4, Vector<ulong> data5, out Vector<ulong> xB, out Vector<ulong> y, out Vector<ulong> yB, out Vector<ulong> z, out Vector<ulong> zB);

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
        Vector<T> YGroup3UnzipX2_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3, Vector<T> data4, Vector<T> data5, out Vector<T> xB, out Vector<T> y, out Vector<T> yB, out Vector<T> z, out Vector<T> zB) where T : struct;


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
        /// <seealso cref="YGroup3Zip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
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
        Vector<float> YGroup3Zip(Vector<float> x, Vector<float> y, Vector<float> z, out Vector<float> data1, out Vector<float> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<double> YGroup3Zip(Vector<double> x, Vector<double> y, Vector<double> z, out Vector<double> data1, out Vector<double> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<sbyte> YGroup3Zip(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, out Vector<sbyte> data1, out Vector<sbyte> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<byte> YGroup3Zip(Vector<byte> x, Vector<byte> y, Vector<byte> z, out Vector<byte> data1, out Vector<byte> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<short> YGroup3Zip(Vector<short> x, Vector<short> y, Vector<short> z, out Vector<short> data1, out Vector<short> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ushort> YGroup3Zip(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, out Vector<ushort> data1, out Vector<ushort> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<int> YGroup3Zip(Vector<int> x, Vector<int> y, Vector<int> z, out Vector<int> data1, out Vector<int> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<uint> YGroup3Zip(Vector<uint> x, Vector<uint> y, Vector<uint> z, out Vector<uint> data1, out Vector<uint> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<long> YGroup3Zip(Vector<long> x, Vector<long> y, Vector<long> z, out Vector<long> data1, out Vector<long> data2);

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ulong> YGroup3Zip(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, out Vector<ulong> data1, out Vector<ulong> data2);

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
        Vector<T> YGroup3Zip_Bit128<T>(Vector<T> x, Vector<T> y, Vector<T> z, out Vector<T> data1, out Vector<T> data2) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup3ZipX2</c> (运行 <c>YGroup3ZipX2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (逆函数): <see cref="YGroup3UnzipX2_AcceleratedTypes">YGroup3UnzipX2</see>.</para>
        /// </remarks>
        /// <seealso cref="YGroup3ZipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
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
        Vector<float> YGroup3ZipX2(Vector<float> x, Vector<float> xB, Vector<float> y, Vector<float> yB, Vector<float> z, Vector<float> zB, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3, out Vector<float> data4, out Vector<float> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<double> YGroup3ZipX2(Vector<double> x, Vector<double> xB, Vector<double> y, Vector<double> yB, Vector<double> z, Vector<double> zB, out Vector<double> data1, out Vector<double> data2, out Vector<double> data3, out Vector<double> data4, out Vector<double> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<sbyte> YGroup3ZipX2(Vector<sbyte> x, Vector<sbyte> xB, Vector<sbyte> y, Vector<sbyte> yB, Vector<sbyte> z, Vector<sbyte> zB, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3, out Vector<sbyte> data4, out Vector<sbyte> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<byte> YGroup3ZipX2(Vector<byte> x, Vector<byte> xB, Vector<byte> y, Vector<byte> yB, Vector<byte> z, Vector<byte> zB, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3, out Vector<byte> data4, out Vector<byte> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<short> YGroup3ZipX2(Vector<short> x, Vector<short> xB, Vector<short> y, Vector<short> yB, Vector<short> z, Vector<short> zB, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3, out Vector<short> data4, out Vector<short> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ushort> YGroup3ZipX2(Vector<ushort> x, Vector<ushort> xB, Vector<ushort> y, Vector<ushort> yB, Vector<ushort> z, Vector<ushort> zB, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3, out Vector<ushort> data4, out Vector<ushort> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<int> YGroup3ZipX2(Vector<int> x, Vector<int> xB, Vector<int> y, Vector<int> yB, Vector<int> z, Vector<int> zB, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3, out Vector<int> data4, out Vector<int> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<uint> YGroup3ZipX2(Vector<uint> x, Vector<uint> xB, Vector<uint> y, Vector<uint> yB, Vector<uint> z, Vector<uint> zB, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3, out Vector<uint> data4, out Vector<uint> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<long> YGroup3ZipX2(Vector<long> x, Vector<long> xB, Vector<long> y, Vector<long> yB, Vector<long> z, Vector<long> zB, out Vector<long> data1, out Vector<long> data2, out Vector<long> data3, out Vector<long> data4, out Vector<long> data5);

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ulong> YGroup3ZipX2(Vector<ulong> x, Vector<ulong> xB, Vector<ulong> y, Vector<ulong> yB, Vector<ulong> z, Vector<ulong> zB, out Vector<ulong> data1, out Vector<ulong> data2, out Vector<ulong> data3, out Vector<ulong> data4, out Vector<ulong> data5);

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
        Vector<T> YGroup3ZipX2_Bit128<T>(Vector<T> x, Vector<T> xB, Vector<T> y, Vector<T> yB, Vector<T> z, Vector<T> zB, out Vector<T> data1, out Vector<T> data2, out Vector<T> data3, out Vector<T> data4, out Vector<T> data5) where T : struct;


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
        /// <seealso cref="YGroup4ToGroup3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
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
        Vector<float> YGroup4ToGroup3(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, out Vector<float> result1, out Vector<float> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<double> YGroup4ToGroup3(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, out Vector<double> result1, out Vector<double> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<sbyte> YGroup4ToGroup3(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, out Vector<sbyte> result1, out Vector<sbyte> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<byte> YGroup4ToGroup3(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, out Vector<byte> result1, out Vector<byte> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<short> YGroup4ToGroup3(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, out Vector<short> result1, out Vector<short> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ushort> YGroup4ToGroup3(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, out Vector<ushort> result1, out Vector<ushort> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<int> YGroup4ToGroup3(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, out Vector<int> result1, out Vector<int> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<uint> YGroup4ToGroup3(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, out Vector<uint> result1, out Vector<uint> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<long> YGroup4ToGroup3(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, out Vector<long> result1, out Vector<long> result2);

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ulong> YGroup4ToGroup3(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, out Vector<ulong> result1, out Vector<ulong> result2);


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
        /// <seealso cref="YGroup4Unzip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
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
        Vector<float> YGroup4Unzip(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, out Vector<float> y, out Vector<float> z, out Vector<float> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<double> YGroup4Unzip(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, out Vector<double> y, out Vector<double> z, out Vector<double> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<sbyte> YGroup4Unzip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, out Vector<sbyte> y, out Vector<sbyte> z, out Vector<sbyte> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<byte> YGroup4Unzip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, out Vector<byte> y, out Vector<byte> z, out Vector<byte> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<short> YGroup4Unzip(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, out Vector<short> y, out Vector<short> z, out Vector<short> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ushort> YGroup4Unzip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, out Vector<ushort> y, out Vector<ushort> z, out Vector<ushort> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<int> YGroup4Unzip(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, out Vector<int> y, out Vector<int> z, out Vector<int> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<uint> YGroup4Unzip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, out Vector<uint> y, out Vector<uint> z, out Vector<uint> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<long> YGroup4Unzip(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, out Vector<long> y, out Vector<long> z, out Vector<long> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ulong> YGroup4Unzip(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, out Vector<ulong> y, out Vector<ulong> z, out Vector<ulong> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ExInt128> YGroup4Unzip(Vector<ExInt128> data0, Vector<ExInt128> data1, Vector<ExInt128> data2, Vector<ExInt128> data3, out Vector<ExInt128> y, out Vector<ExInt128> z, out Vector<ExInt128> w);

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ExUInt128> YGroup4Unzip(Vector<ExUInt128> data0, Vector<ExUInt128> data1, Vector<ExUInt128> data2, Vector<ExUInt128> data3, out Vector<ExUInt128> y, out Vector<ExUInt128> z, out Vector<ExUInt128> w);

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
        Vector<T> YGroup4Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3, out Vector<T> y, out Vector<T> z, out Vector<T> w) where T : struct;


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
        /// <seealso cref="YGroup4Zip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
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
        Vector<float> YGroup4Zip(Vector<float> x, Vector<float> y, Vector<float> z, Vector<float> w, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<double> YGroup4Zip(Vector<double> x, Vector<double> y, Vector<double> z, Vector<double> w, out Vector<double> data1, out Vector<double> data2, out Vector<double> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<sbyte> YGroup4Zip(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, Vector<sbyte> w, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<byte> YGroup4Zip(Vector<byte> x, Vector<byte> y, Vector<byte> z, Vector<byte> w, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<short> YGroup4Zip(Vector<short> x, Vector<short> y, Vector<short> z, Vector<short> w, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ushort> YGroup4Zip(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, Vector<ushort> w, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<int> YGroup4Zip(Vector<int> x, Vector<int> y, Vector<int> z, Vector<int> w, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<uint> YGroup4Zip(Vector<uint> x, Vector<uint> y, Vector<uint> z, Vector<uint> w, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<long> YGroup4Zip(Vector<long> x, Vector<long> y, Vector<long> z, Vector<long> w, out Vector<long> data1, out Vector<long> data2, out Vector<long> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ulong> YGroup4Zip(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, Vector<ulong> w, out Vector<ulong> data1, out Vector<ulong> data2, out Vector<ulong> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ExInt128> YGroup4Zip(Vector<ExInt128> x, Vector<ExInt128> y, Vector<ExInt128> z, Vector<ExInt128> w, out Vector<ExInt128> data1, out Vector<ExInt128> data2, out Vector<ExInt128> data3);

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
        Vector<ExUInt128> YGroup4Zip(Vector<ExUInt128> x, Vector<ExUInt128> y, Vector<ExUInt128> z, Vector<ExUInt128> w, out Vector<ExUInt128> data1, out Vector<ExUInt128> data2, out Vector<ExUInt128> data3);

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
        Vector<T> YGroup4Zip_Bit128<T>(Vector<T> x, Vector<T> y, Vector<T> z, Vector<T> w, out Vector<T> data1, out Vector<T> data2, out Vector<T> data3) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsAllTrue</c> (运行 <c>YIsAllTrue</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsAllTrue{T}(Vector{T})"/>
        TypeCodeFlags YIsAllTrue_AcceleratedTypes { get; }

        /// <summary>
        /// Checks if all elements of the vector is true (检查向量中所有元素是不是都为true).
        /// Mnemonic: <c>rt := value[0] &amp;&amp; value[1] &amp;&amp; value[2] &amp;&amp; ... &amp;&amp; value[Count-1]</c>. The element of value must be 0 or <see cref="Scalars{T}.AllBitsSet">AllBitsSet</see> (Signed integer value -1).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector whose elements will be checked. The return value of a comparison category function can be assigned to it (将检查其元素的向量. 可将比较类函数的返回值赋值给它). e.g. <see cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>.</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="value"/> is true. (<paramref name="value" /> 中所有元素为true时返回<c>true</c>).</returns>
        /// <seealso cref="YIsAllTrue_AcceleratedTypes"/>
        /// <seealso cref="Vector.EqualsAll{T}(Vector{T}, Vector{T})" />
        bool YIsAllTrue<T>(Vector<T> value) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsAnyTrue</c> (运行 <c>YIsAnyTrue</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsAnyTrue{T}(Vector{T})"/>
        TypeCodeFlags YIsAnyTrue_AcceleratedTypes { get; }

        /// <summary>
        /// Checks if any elements of the vector is true (检查向量中任一元素是不是为true).
        /// Mnemonic: <c>rt := value[0] || value[1] || value[2] || ... || value[Count-1]</c>. The element of value must be 0 or <see cref="Scalars{T}.AllBitsSet">AllBitsSet</see> (Signed integer value -1).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector whose elements will be checked. The return value of a comparison category function can be assigned to it (将检查其元素的向量. 可将比较类函数的返回值赋值给它). e.g. <see cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>.</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="value"/> is true. (<paramref name="value" /> 中任一元素为true时返回<c>true</c>).</returns>
        /// <seealso cref="YIsAnyTrue_AcceleratedTypes"/>
        /// <seealso cref="Vector.EqualsAny{T}(Vector{T}, Vector{T})" />
        bool YIsAnyTrue<T>(Vector<T> value) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsEvenInteger</c> (运行 <c>YIsEvenInteger</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsEvenInteger(Vector{float})"/>
        TypeCodeFlags YIsEvenInteger_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents an even integral number (确定元素是否为偶数整数).
        /// Mnemonic: <c>rt[i] := to_mask(isEvenInteger(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is even integral number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为偶数整数).</returns>
        /// <seealso cref="YIsEvenInteger_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(float)"/>
        Vector<int> YIsEvenInteger(Vector<float> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(double)"/>
        Vector<long> YIsEvenInteger(Vector<double> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(sbyte)"/>
        Vector<sbyte> YIsEvenInteger(Vector<sbyte> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(byte)"/>
        Vector<byte> YIsEvenInteger(Vector<byte> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(short)"/>
        Vector<short> YIsEvenInteger(Vector<short> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(ushort)"/>
        Vector<ushort> YIsEvenInteger(Vector<ushort> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(int)"/>
        Vector<int> YIsEvenInteger(Vector<int> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(uint)"/>
        Vector<uint> YIsEvenInteger(Vector<uint> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(long)"/>
        Vector<long> YIsEvenInteger(Vector<long> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(ulong)"/>
        Vector<ulong> YIsEvenInteger(Vector<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsFinite</c> (运行 <c>YIsFinite</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsFinite(Vector{float})"/>
        TypeCodeFlags YIsFinite_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is finite. It contains zero, subnormal, and normal. It does not contain infinity, NaN (确定元素是否为有限值. 它包含 零、次正规数、正规数. 它不含无穷大、非数).
        /// Mnemonic: <c>rt[i] := to_mask(isFinite(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is finite (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为有限的).</returns>
        /// <seealso cref="YIsFinite_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsFinite(float)"/>
        Vector<int> YIsFinite(Vector<float> value);

        /// <inheritdoc cref="YIsFinite(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsFinite(double)"/>
        Vector<long> YIsFinite(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsInfinity</c> (运行 <c>YIsInfinity</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsInfinity(Vector{float})"/>
        TypeCodeFlags YIsInfinity_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is infinite (确定元素是否为无穷大).
        /// Mnemonic: <c>rt[i] := to_mask(isInfinity(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is infinite (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为无穷大).</returns>
        /// <seealso cref="YIsInfinity_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsInfinity(float)"/>
        Vector<int> YIsInfinity(Vector<float> value);

        /// <inheritdoc cref="YIsInfinity(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsInfinity(double)"/>
        Vector<long> YIsInfinity(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsInfinityOrNaN</c> (运行 <c>YIsInfinityOrNaN</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsInfinityOrNaN(Vector{float})"/>
        TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is infinite or NaN (确定元素是否为无穷大或非数).
        /// Mnemonic: <c>rt[i] := to_mask(isInfinityOrNaN(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is infinite or NaN (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为无穷大或非数).</returns>
        /// <seealso cref="YIsInfinityOrNaN_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsInfinityOrNaN(float)"/>
        Vector<int> YIsInfinityOrNaN(Vector<float> value);

        /// <inheritdoc cref="YIsInfinityOrNaN(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsInfinityOrNaN(double)"/>
        Vector<long> YIsInfinityOrNaN(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsInteger</c> (运行 <c>YIsInteger</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsInteger(Vector{float})"/>
        TypeCodeFlags YIsInteger_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents an integral number (确定元素是否为整数).
        /// Mnemonic: <c>rt[i] := to_mask(isInteger(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is integral number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为整数).</returns>
        /// <seealso cref="YIsInteger_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsInteger(float)"/>
        Vector<int> YIsInteger(Vector<float> value);

        /// <inheritdoc cref="YIsInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsInteger(double)"/>
        Vector<long> YIsInteger(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNaN</c> (运行 <c>YIsNaN</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNaN(Vector{float})"/>
        TypeCodeFlags YIsNaN_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is NaN (确定元素是否为非数).
        /// Mnemonic: <c>rt[i] := to_mask(isNaN(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is NaN (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为非数).</returns>
        /// <seealso cref="YIsNaN_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNaN(float)"/>
        Vector<int> YIsNaN(Vector<float> value);

        /// <inheritdoc cref="YIsNaN(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsNaN(double)"/>
        Vector<long> YIsNaN(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNegative</c> (运行 <c>YIsNegative</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNegative(Vector{float})"/>
        TypeCodeFlags YIsNegative_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents a negative number or negative zero (确定元素是否为负数或负零).
        /// Mnemonic: <c>rt[i] := to_mask(isNegative(value[i])) = to_mask((value[i]&lt;0) || isNegativeZero(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is negative number or negative zero (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为负数或负零).</returns>
        /// <seealso cref="YIsNegative_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNegative(float)"/>
        Vector<int> YIsNegative(Vector<float> value);

        /// <inheritdoc cref="YIsNegative(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(double)"/>
        Vector<long> YIsNegative(Vector<double> value);

        /// <inheritdoc cref="YIsNegative(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(sbyte)"/>
        Vector<sbyte> YIsNegative(Vector<sbyte> value);

        /// <inheritdoc cref="YIsNegative(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(short)"/>
        Vector<short> YIsNegative(Vector<short> value);

        /// <inheritdoc cref="YIsNegative(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(int)"/>
        Vector<int> YIsNegative(Vector<int> value);

        /// <inheritdoc cref="YIsNegative(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(long)"/>
        Vector<long> YIsNegative(Vector<long> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNegativeInfinity</c> (运行 <c>YIsNegativeInfinity</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNegativeInfinity(Vector{float})"/>
        TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is negative infinity (确定元素是否为负无穷大).
        /// Mnemonic: <c>rt[i] := to_mask(isNegativeInfinity(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is negative infinity (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为负无穷大).</returns>
        /// <seealso cref="YIsNegativeInfinity_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNegativeInfinity(float)"/>
        Vector<int> YIsNegativeInfinity(Vector<float> value);

        /// <inheritdoc cref="YIsNegativeInfinity(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsNegativeInfinity(double)"/>
        Vector<long> YIsNegativeInfinity(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNegativeZero</c> (运行 <c>YIsNegativeZero</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNegativeZero(Vector{float})"/>
        TypeCodeFlags YIsNegativeZero_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents a negative zero (确定元素是否为负零).
        /// Mnemonic: <c>rt[i] := to_mask(isNegativeZero(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is finite (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为有限的).</returns>
        /// <seealso cref="YIsNegativeZero_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNegativeZero(float)"/>
        Vector<int> YIsNegativeZero(Vector<float> value);

        /// <inheritdoc cref="YIsNegativeZero(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsNegativeZero(double)"/>
        Vector<long> YIsNegativeZero(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNormal</c> (运行 <c>YIsNormal</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNormal(Vector{float})"/>
        TypeCodeFlags YIsNormal_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is normal (确定元素是否为正规数).
        /// Mnemonic: <c>rt[i] := to_mask(isFinite(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is normal (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为正规数).</returns>
        /// <seealso cref="YIsNormal_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNormal(float)"/>
        Vector<int> YIsNormal(Vector<float> value);

        /// <inheritdoc cref="YIsNormal(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsNormal(double)"/>
        Vector<long> YIsNormal(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNotEquals</c> (运行 <c>YIsNotEquals</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNotEquals(Vector{byte}, Vector{byte})"/>
        TypeCodeFlags YIsNotEquals_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>
        Vector<float> YIsNotEquals(Vector<float> left, Vector<float> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>
        Vector<double> YIsNotEquals(Vector<double> left, Vector<double> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>
        Vector<sbyte> YIsNotEquals(Vector<sbyte> left, Vector<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>
        Vector<byte> YIsNotEquals(Vector<byte> left, Vector<byte> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>
        Vector<short> YIsNotEquals(Vector<short> left, Vector<short> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>
        Vector<ushort> YIsNotEquals(Vector<ushort> left, Vector<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>
        Vector<int> YIsNotEquals(Vector<int> left, Vector<int> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>
        Vector<uint> YIsNotEquals(Vector<uint> left, Vector<uint> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>
        Vector<long> YIsNotEquals(Vector<long> left, Vector<long> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector.Equals{T}(Vector{T}, Vector{T})"/>
        Vector<ulong> YIsNotEquals(Vector<ulong> left, Vector<ulong> right);

        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNotNaN</c> (运行 <c>YIsNotNaN</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNotNaN(Vector{float})"/>
        TypeCodeFlags YIsNotNaN_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is not NaN (确定元素是否不为非数).
        /// Mnemonic: <c>rt[i] := to_mask(isNotNaN(value[i])) = to_mask(!isNaN(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is not NaN (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否不为非数).</returns>
        /// <seealso cref="YIsNotNaN_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNotNaN(float)"/>
        Vector<int> YIsNotNaN(Vector<float> value);

        /// <inheritdoc cref="YIsNotNaN(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsNotNaN(double)"/>
        Vector<long> YIsNotNaN(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsOddInteger</c> (运行 <c>YIsOddInteger</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsOddInteger(Vector{float})"/>
        TypeCodeFlags YIsOddInteger_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents an odd integral number (确定元素是否为奇数整数).
        /// Mnemonic: <c>rt[i] := to_mask(isOddInteger(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is odd integral number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为奇数整数).</returns>
        /// <seealso cref="YIsOddInteger_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(float)"/>
        Vector<int> YIsOddInteger(Vector<float> value);

        /// <inheritdoc cref="YIsOddInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(double)"/>
        Vector<long> YIsOddInteger(Vector<double> value);

        /// <inheritdoc cref="YIsOddInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(sbyte)"/>
        Vector<sbyte> YIsOddInteger(Vector<sbyte> value);

        /// <inheritdoc cref="YIsOddInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(byte)"/>
        Vector<byte> YIsOddInteger(Vector<byte> value);

        /// <inheritdoc cref="YIsOddInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(short)"/>
        Vector<short> YIsOddInteger(Vector<short> value);

        /// <inheritdoc cref="YIsOddInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(ushort)"/>
        Vector<ushort> YIsOddInteger(Vector<ushort> value);

        /// <inheritdoc cref="YIsOddInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(int)"/>
        Vector<int> YIsOddInteger(Vector<int> value);

        /// <inheritdoc cref="YIsOddInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(uint)"/>
        Vector<uint> YIsOddInteger(Vector<uint> value);

        /// <inheritdoc cref="YIsOddInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(long)"/>
        Vector<long> YIsOddInteger(Vector<long> value);

        /// <inheritdoc cref="YIsOddInteger(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(ulong)"/>
        Vector<ulong> YIsOddInteger(Vector<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsPositive</c> (运行 <c>YIsPositive</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsPositive(Vector{float})"/>
        TypeCodeFlags YIsPositive_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents zero or a positive number (确定元素是否为零或正数).
        /// Mnemonic: <c>rt[i] := to_mask(isNegative(value[i])) = to_mask((value[i]&lt;0) || isNegativeZero(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is zero or a positive number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为零或正数).</returns>
        /// <seealso cref="YIsPositive_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsPositive(float)"/>
        Vector<int> YIsPositive(Vector<float> value);

        /// <inheritdoc cref="YIsPositive(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(double)"/>
        Vector<long> YIsPositive(Vector<double> value);

        /// <inheritdoc cref="YIsPositive(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(sbyte)"/>
        Vector<sbyte> YIsPositive(Vector<sbyte> value);

        /// <inheritdoc cref="YIsPositive(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(short)"/>
        Vector<short> YIsPositive(Vector<short> value);

        /// <inheritdoc cref="YIsPositive(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(int)"/>
        Vector<int> YIsPositive(Vector<int> value);

        /// <inheritdoc cref="YIsPositive(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(long)"/>
        Vector<long> YIsPositive(Vector<long> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsPositiveInfinity</c> (运行 <c>YIsPositiveInfinity</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsPositiveInfinity(Vector{float})"/>
        TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is positive infinity (确定元素是否为正无穷大).
        /// Mnemonic: <c>rt[i] := to_mask(isNegativeInfinity(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is positive infinity (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为正无穷大).</returns>
        /// <seealso cref="YIsPositiveInfinity_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsPositiveInfinity(float)"/>
        Vector<int> YIsPositiveInfinity(Vector<float> value);

        /// <inheritdoc cref="YIsPositiveInfinity(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsPositiveInfinity(double)"/>
        Vector<long> YIsPositiveInfinity(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsSubnormal</c> (运行 <c>YIsSubnormal</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsSubnormal(Vector{float})"/>
        TypeCodeFlags YIsSubnormal_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is subnormal (确定元素是否为次正规数).
        /// Mnemonic: <c>rt[i] := to_mask(IsSubnormal(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is subnormal (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为次正规数).</returns>
        /// <seealso cref="YIsSubnormal_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsSubnormal(float)"/>
        Vector<int> YIsSubnormal(Vector<float> value);

        /// <inheritdoc cref="YIsSubnormal(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsSubnormal(double)"/>
        Vector<long> YIsSubnormal(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsZero</c> (运行 <c>YIsZero</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsZero(Vector{float})"/>
        TypeCodeFlags YIsZero_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is zero (确定元素是否为零).
        /// Mnemonic: <c>rt[i] := to_mask(0==value[i])</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is zero (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为零).</returns>
        /// <seealso cref="YIsZero_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsZero(float)"/>
        Vector<int> YIsZero(Vector<float> value);

        /// <inheritdoc cref="YIsZero(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(double)"/>
        Vector<long> YIsZero(Vector<double> value);

        /// <inheritdoc cref="YIsZero(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(sbyte)"/>
        Vector<sbyte> YIsZero(Vector<sbyte> value);

        /// <inheritdoc cref="YIsZero(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(byte)"/>
        Vector<byte> YIsZero(Vector<byte> value);

        /// <inheritdoc cref="YIsZero(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(short)"/>
        Vector<short> YIsZero(Vector<short> value);

        /// <inheritdoc cref="YIsZero(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(ushort)"/>
        Vector<ushort> YIsZero(Vector<ushort> value);

        /// <inheritdoc cref="YIsZero(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(int)"/>
        Vector<int> YIsZero(Vector<int> value);

        /// <inheritdoc cref="YIsZero(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(uint)"/>
        Vector<uint> YIsZero(Vector<uint> value);

        /// <inheritdoc cref="YIsZero(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(long)"/>
        Vector<long> YIsZero(Vector<long> value);

        /// <inheritdoc cref="YIsZero(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(ulong)"/>
        Vector<ulong> YIsZero(Vector<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsZeroOrSubnormal</c> (运行 <c>YIsZeroOrSubnormal</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsZeroOrSubnormal(Vector{float})"/>
        TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is zero or subnormal (确定元素是否为零或次正规数).
        /// Mnemonic: <c>rt[i] := to_mask(isZeroOrSubnormal(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is zero or subnormal (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为零或次正规数).</returns>
        /// <seealso cref="YIsZeroOrSubnormal_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsZeroOrSubnormal(float)"/>
        Vector<int> YIsZeroOrSubnormal(Vector<float> value);

        /// <inheritdoc cref="YIsZeroOrSubnormal(Vector{float})"/>
        /// <seealso cref="MathINumberBase.IsZeroOrSubnormal(double)"/>
        Vector<long> YIsZeroOrSubnormal(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YMaxNumber</c> (运行 <c>YMaxNumber</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YMaxNumber(Vector{float}, Vector{float})"/>
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
        Vector<float> YMaxNumber(Vector<float> left, Vector<float> right);

        /// <inheritdoc cref="YMaxNumber(Vector{float}, Vector{float})"/>
        /// <seealso cref="MathINumber.MaxNumber(double, double)"/>
        Vector<double> YMaxNumber(Vector<double> left, Vector<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>YMinNumber</c> (运行 <c>YMinNumber</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YMinNumber(Vector{float}, Vector{float})"/>
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
        Vector<float> YMinNumber(Vector<float> left, Vector<float> right);

        /// <inheritdoc cref="YMinNumber(Vector{float}, Vector{float})"/>
        /// <seealso cref="MathINumber.MinNumber(double, double)"/>
        Vector<double> YMinNumber(Vector<double> left, Vector<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>YNarrowSaturate</c> (运行 <c>YNarrowSaturate</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YNarrowSaturate(Vector{short}, Vector{short})"/>
        /// <seealso cref="YNarrowSaturate_FullAcceleratedTypes"/>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturate_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>YNarrowSaturate</c> (运行 <c>YNarrowSaturate</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="YNarrowSaturate(Vector{short}, Vector{short})"/>
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
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{short})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{sbyte}, Vector128{short})"/>
        /// <seealso cref="Avx2.PackSignedSaturate(Vector256{short}, Vector256{short})"/>
        Vector<sbyte> YNarrowSaturate(Vector<short> lower, Vector<short> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{ushort})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{byte}, Vector128{ushort})"/>
        Vector<byte> YNarrowSaturate(Vector<ushort> lower, Vector<ushort> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{int})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{short}, Vector128{int})"/>
        /// <seealso cref="Avx2.PackSignedSaturate(Vector256{int}, Vector256{int})"/>
        Vector<short> YNarrowSaturate(Vector<int> lower, Vector<int> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{uint})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{ushort}, Vector128{uint})"/>
        Vector<ushort> YNarrowSaturate(Vector<uint> lower, Vector<uint> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{long})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{int}, Vector128{long})"/>
        Vector<int> YNarrowSaturate(Vector<long> lower, Vector<long> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateLower(Vector128{ulong})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUpper(Vector64{uint}, Vector128{ulong})"/>
        Vector<uint> YNarrowSaturate(Vector<ulong> lower, Vector<ulong> upper);


        /// <summary>
        /// Types with hardware acceleration when running <c>YNarrowSaturateUnsigned</c> (运行 <c>YNarrowSaturateUnsigned</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YNarrowSaturateUnsigned(Vector{short}, Vector{short})"/>
        /// <seealso cref="YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>YNarrowSaturateUnsigned</c> (运行 <c>YNarrowSaturateUnsigned</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="YNarrowSaturateUnsigned(Vector{short}, Vector{short})"/>
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
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedLower(Vector128{short})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedUpper(Vector64{byte}, Vector128{short})"/>
        /// <seealso cref="Avx2.PackUnsignedSaturate(Vector256{short}, Vector256{short})"/>
        Vector<byte> YNarrowSaturateUnsigned(Vector<short> lower, Vector<short> upper);

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector{T}"/> instances into one unsigned <seealso cref="Vector{T}"/>"  (将两个有符号 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedLower(Vector128{int})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedUpper(Vector64{ushort}, Vector128{int})"/>
        /// <seealso cref="Avx2.PackUnsignedSaturate(Vector256{int}, Vector256{int})"/>
        Vector<ushort> YNarrowSaturateUnsigned(Vector<int> lower, Vector<int> upper);

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector{T}"/> instances into one unsigned <seealso cref="Vector{T}"/>"  (将两个有符号 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedLower(Vector128{long})"/>
        /// <seealso cref="AdvSimd.ExtractNarrowingSaturateUnsignedUpper(Vector64{uint}, Vector128{long})"/>
        Vector<uint> YNarrowSaturateUnsigned(Vector<long> lower, Vector<long> upper);


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
        Vector<T> YOrNot<T>(Vector<T> left, Vector<T> right) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YRoundToEven</c> (运行 <c>YRoundToEven</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Methods used to calculate rounding (用于计算舍入的方法):</para>
        /// <para>- <see cref="Ceiling(Vector{float})"/>: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.</para>
        /// <para>- <see cref="Floor(Vector{float})"/>: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.</para>
        /// <para>- <see cref="YRoundToEven(Vector{float})"/>: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.</para>
        /// <para>- <see cref="YRoundToZero(Vector{float})"/>: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.</para>
        /// </remarks>
        /// <seealso cref="YRoundToEven(Vector{float})"/>
        TypeCodeFlags YRoundToEven_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.
        /// Mnemonic: <c>rt[i] := round_to_even(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to even computed (将计算向偶数舍入的向量).</param>
        /// <returns>A vector whose elements are the round to even of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向偶数舍入).</returns>
        /// <seealso cref="YRoundToEven_AcceleratedTypes"/>
        Vector<float> YRoundToEven(Vector<float> value);

        /// <summary>
        /// Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.
        /// Mnemonic: <c>rt[i] := round_to_even(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to even computed (将计算向偶数舍入的向量).</param>
        /// <returns>A vector whose elements are the round to even of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向偶数舍入).</returns>
        /// <seealso cref="YRoundToEven_AcceleratedTypes"/>
        Vector<double> YRoundToEven(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YRoundToZero</c> (运行 <c>YRoundToZero</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Methods used to calculate rounding (用于计算舍入的方法):</para>
        /// <para>- <see cref="Ceiling(Vector{float})"/>: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.</para>
        /// <para>- <see cref="Floor(Vector{float})"/>: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.</para>
        /// <para>- <see cref="YRoundToEven(Vector{float})"/>: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.</para>
        /// <para>- <see cref="YRoundToZero(Vector{float})"/>: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.</para>
        /// </remarks>
        /// <seealso cref="YRoundToZero(Vector{float})"/>
        TypeCodeFlags YRoundToZero_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.
        /// Mnemonic: <c>rt[i] := round_to_zero(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to zero computed (将计算向零舍入的向量).</param>
        /// <returns>A vector whose elements are the round to zero of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向零舍入).</returns>
        /// <seealso cref="YRoundToZero_AcceleratedTypes"/>
        Vector<float> YRoundToZero(Vector<float> value);

        /// <summary>
        /// Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.
        /// Mnemonic: <c>rt[i] := round_to_zero(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to zero computed (将计算向零舍入的向量).</param>
        /// <returns>A vector whose elements are the round to zero of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向零舍入).</returns>
        /// <seealso cref="YRoundToZero_AcceleratedTypes"/>
        Vector<double> YRoundToZero(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleG2</c> (运行 <c>YShuffleG2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2(Vector{byte}, ShuffleControlG2)"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4(Vector{byte}, ShuffleControlG4)"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).</para>
        /// <para>- <see cref="YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2(Vector{byte}, ShuffleControlG2)"/>
        /// <seealso cref="YShuffleG4(Vector{byte}, ShuffleControlG4)"/>
        /// <seealso cref="YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
        TypeCodeFlags YShuffleG2_AcceleratedTypes { get; }

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<float> YShuffleG2(Vector<float> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<double> YShuffleG2(Vector<double> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<sbyte> YShuffleG2(Vector<sbyte> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<byte> YShuffleG2(Vector<byte> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<short> YShuffleG2(Vector<short> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<ushort> YShuffleG2(Vector<ushort> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<int> YShuffleG2(Vector<int> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<uint> YShuffleG2(Vector<uint> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<long> YShuffleG2(Vector<long> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<ulong> YShuffleG2(Vector<ulong> source, ShuffleControlG2 control);

#if !REDUCE_MEMORY_USAGE
        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<float> YShuffleG2_Const(Vector<float> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<double> YShuffleG2_Const(Vector<double> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<sbyte> YShuffleG2_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<byte> YShuffleG2_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<short> YShuffleG2_Const(Vector<short> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<ushort> YShuffleG2_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<int> YShuffleG2_Const(Vector<int> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<uint> YShuffleG2_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<long> YShuffleG2_Const(Vector<long> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector<ulong> YShuffleG2_Const(Vector<ulong> source, [ConstantExpected] ShuffleControlG2 control);
#endif // !REDUCE_MEMORY_USAGE


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleG4</c> (运行 <c>YShuffleG4</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2(Vector{byte}, ShuffleControlG2)"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4(Vector{byte}, ShuffleControlG4)"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).</para>
        /// <para>- <see cref="YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2(Vector{byte}, ShuffleControlG2)"/>
        /// <seealso cref="YShuffleG4(Vector{byte}, ShuffleControlG4)"/>
        /// <seealso cref="YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
        TypeCodeFlags YShuffleG4_AcceleratedTypes { get; }

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector<float> YShuffleG4(Vector<float> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <exception cref="NotSupportedException">The count of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead (向量的元素数量不能小于4! 请使用 YShuffleG4X2 代替).</exception>
        Vector<double> YShuffleG4(Vector<double> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector<sbyte> YShuffleG4(Vector<sbyte> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector<byte> YShuffleG4(Vector<byte> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector<short> YShuffleG4(Vector<short> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector<ushort> YShuffleG4(Vector<ushort> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector<int> YShuffleG4(Vector<int> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector<uint> YShuffleG4(Vector<uint> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <exception cref="NotSupportedException">The count of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead (向量的元素数量不能小于4! 请使用 YShuffleG4X2 代替).</exception>
        Vector<long> YShuffleG4(Vector<long> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <exception cref="NotSupportedException">The count of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead (向量的元素数量不能小于4! 请使用 YShuffleG4X2 代替).</exception>
        Vector<ulong> YShuffleG4(Vector<ulong> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx.Permute(Vector256{float}, byte)"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{int}, byte)"/>
        Vector<float> YShuffleG4_Const(Vector<float> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.Permute4x64(Vector256{double}, byte)"/>
        Vector<double> YShuffleG4_Const(Vector<double> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector<sbyte> YShuffleG4_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector<byte> YShuffleG4_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.ShuffleHigh(Vector256{short}, byte)"/>
        /// <seealso cref="Avx2.ShuffleLow(Vector256{short}, byte)"/>
        Vector<short> YShuffleG4_Const(Vector<short> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.ShuffleHigh(Vector256{ushort}, byte)"/>
        /// <seealso cref="Avx2.ShuffleLow(Vector256{ushort}, byte)"/>
        Vector<ushort> YShuffleG4_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{int}, byte)"/>
        Vector<int> YShuffleG4_Const(Vector<int> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{uint}, byte)"/>
        Vector<uint> YShuffleG4_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.Permute4x64(Vector256{long}, byte)"/>
        Vector<long> YShuffleG4_Const(Vector<long> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.Permute4x64(Vector256{ulong}, byte)"/>
        Vector<ulong> YShuffleG4_Const(Vector<ulong> source, [ConstantExpected] ShuffleControlG4 control);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleG4X2</c> (运行 <c>YShuffleG4X2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2(Vector{byte}, ShuffleControlG2)"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4(Vector{byte}, ShuffleControlG4)"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).</para>
        /// <para>- <see cref="YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2(Vector{byte}, ShuffleControlG2)"/>
        /// <seealso cref="YShuffleG4(Vector{byte}, ShuffleControlG4)"/>
        /// <seealso cref="YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
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
        Vector<float> YShuffleG4X2(Vector<float> source0, Vector<float> source1, ShuffleControlG4 control, out Vector<float> result1);

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
        Vector<double> YShuffleG4X2(Vector<double> source0, Vector<double> source1, ShuffleControlG4 control, out Vector<double> result1);

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
        Vector<sbyte> YShuffleG4X2(Vector<sbyte> source0, Vector<sbyte> source1, ShuffleControlG4 control, out Vector<sbyte> result1);

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
        Vector<byte> YShuffleG4X2(Vector<byte> source0, Vector<byte> source1, ShuffleControlG4 control, out Vector<byte> result1);

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
        Vector<short> YShuffleG4X2(Vector<short> source0, Vector<short> source1, ShuffleControlG4 control, out Vector<short> result1);

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
        Vector<ushort> YShuffleG4X2(Vector<ushort> source0, Vector<ushort> source1, ShuffleControlG4 control, out Vector<ushort> result1);

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
        Vector<int> YShuffleG4X2(Vector<int> source0, Vector<int> source1, ShuffleControlG4 control, out Vector<int> result1);

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
        Vector<uint> YShuffleG4X2(Vector<uint> source0, Vector<uint> source1, ShuffleControlG4 control, out Vector<uint> result1);

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
        Vector<long> YShuffleG4X2(Vector<long> source0, Vector<long> source1, ShuffleControlG4 control, out Vector<long> result1);

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
        Vector<ulong> YShuffleG4X2(Vector<ulong> source0, Vector<ulong> source1, ShuffleControlG4 control, out Vector<ulong> result1);

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
        Vector<float> YShuffleG4X2_Const(Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<float> result1);

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
        Vector<double> YShuffleG4X2_Const(Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<double> result1);

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
        Vector<sbyte> YShuffleG4X2_Const(Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<sbyte> result1);

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
        Vector<byte> YShuffleG4X2_Const(Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<byte> result1);

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
        Vector<short> YShuffleG4X2_Const(Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<short> result1);

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
        Vector<ushort> YShuffleG4X2_Const(Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ushort> result1);

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
        Vector<int> YShuffleG4X2_Const(Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<int> result1);

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
        Vector<uint> YShuffleG4X2_Const(Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<uint> result1);

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
        Vector<long> YShuffleG4X2_Const(Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<long> result1);

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
        Vector<ulong> YShuffleG4X2_Const(Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ulong> result1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleInsert</c> (运行 <c>YShuffleInsert</c> 时具有硬件加速的类型).
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookupExtension(Vector128{byte}, Vector128{byte}, Vector128{byte})">TBX(vqvtbx1q_u8)</see></description>
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
        ///        <description>Combine by <see cref="Ssse3.Shuffle(Vector128{byte}, Vector128{byte})">PSHUFB(_mm_shuffle_epi8)</see>
        ///        /<see cref="Avx512Vbmi.VL.PermuteVar16x8(Vector128{byte}, Vector128{byte})">VPERMB(_mm128_permutevar16x8_epi8)</see></description>
        ///        <description>Combine by <see cref="Avx512BW.VL.PermuteVar8x16(Vector128{ushort}, Vector128{ushort})">VPERMW(_mm128_permutevar8x16_epi16)</see></description>
        ///        <description>Combine by <see cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})">VPERMD(_mm256_permutevar8x32_epi32)</see>
        ///        /<see cref="Avx2.PermuteVar8x32(Vector256{float}, Vector256{int})">VPERMPS(_mm256_permutevar8x32_ps)</see></description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar4x64(Vector256{ulong}, Vector256{ulong})">VPERMQ(_mm256_permute4x64_pd)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar4x64(Vector256{double}, Vector256{long})">VPERMPD(_mm256_permute4x64_pd)</see></description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>
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
        Vector<float> YShuffleInsert(Vector<float> back, Vector<float> vector, Vector<int> indices);

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
        Vector<double> YShuffleInsert(Vector<double> back, Vector<double> vector, Vector<long> indices);

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
        Vector<sbyte> YShuffleInsert(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> indices);

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
        Vector<byte> YShuffleInsert(Vector<byte> back, Vector<byte> vector, Vector<byte> indices);

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
        Vector<short> YShuffleInsert(Vector<short> back, Vector<short> vector, Vector<short> indices);

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
        Vector<ushort> YShuffleInsert(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> indices);

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
        Vector<int> YShuffleInsert(Vector<int> back, Vector<int> vector, Vector<int> indices);

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
        Vector<uint> YShuffleInsert(Vector<uint> back, Vector<uint> vector, Vector<uint> indices);

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
        Vector<long> YShuffleInsert(Vector<long> back, Vector<long> vector, Vector<long> indices);

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
        Vector<ulong> YShuffleInsert(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> indices);


        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void YShuffleInsert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        void YShuffleInsert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        void YShuffleInsert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void YShuffleInsert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        void YShuffleInsert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        void YShuffleInsert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        void YShuffleInsert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void YShuffleInsert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2);


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
        /// <seealso cref="YShuffleInsert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<float> YShuffleInsert_Core(Vector<float> back, Vector<float> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> YShuffleInsert_Core(Vector<double> back, Vector<double> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookupExtension(Vector64{sbyte}, Vector128{sbyte}, Vector64{sbyte})"/>
        Vector<sbyte> YShuffleInsert_Core(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookupExtension(Vector64{byte}, Vector128{byte}, Vector64{byte})"/>
        Vector<byte> YShuffleInsert_Core(Vector<byte> back, Vector<byte> vector, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> YShuffleInsert_Core(Vector<short> back, Vector<short> vector, Vector<short> args0, Vector<short> args1, Vector<short> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> YShuffleInsert_Core(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<int> YShuffleInsert_Core(Vector<int> back, Vector<int> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        Vector<uint> YShuffleInsert_Core(Vector<uint> back, Vector<uint> vector, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> YShuffleInsert_Core(Vector<long> back, Vector<long> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> YShuffleInsert_Core(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleKernel</c> (运行 <c>Shuffle</c> 时具有硬件加速的类型).
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(Vector128{byte}, Vector128{byte})">TBL(vqvtbl1q_u8)</see></description>
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
        ///        <description><see cref="Ssse3.Shuffle(Vector128{byte}, Vector128{byte})">PSHUFB(_mm_shuffle_epi8)</see>
        ///        /<see cref="Avx512Vbmi.VL.PermuteVar16x8(Vector128{byte}, Vector128{byte})">VPERMB(_mm128_permutevar16x8_epi8)</see></description>
        ///        <description><see cref="Avx512BW.VL.PermuteVar8x16(Vector128{ushort}, Vector128{ushort})">VPERMW(_mm128_permutevar8x16_epi16)</see></description>
        ///        <description><see cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})">VPERMD(_mm256_permutevar8x32_epi32)</see>
        ///        /<see cref="Avx2.PermuteVar8x32(Vector256{float}, Vector256{int})">VPERMPS(_mm256_permutevar8x32_ps)</see></description>
        ///        <description><see cref="Avx512F.VL.PermuteVar4x64(Vector256{ulong}, Vector256{ulong})">VPERMQ(_mm256_permute4x64_pd)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar4x64(Vector256{double}, Vector256{long})">VPERMPD(_mm256_permute4x64_pd)</see></description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleKernel(Vector{byte}, Vector{byte})"/>
        /// <seealso cref="YShuffleKernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="YShuffleKernel_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
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
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{float}, Vector256{int})"/>
        Vector<float> YShuffleKernel(Vector<float> vector, Vector<int> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{double}, Vector128{long})"/>
        Vector<double> YShuffleKernel(Vector<double> vector, Vector<long> indices);

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
        /// <seealso cref="Avx2.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        Vector<sbyte> YShuffleKernel(Vector<sbyte> vector, Vector<sbyte> indices);

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
        /// <seealso cref="Avx2.Shuffle(Vector256{byte}, Vector256{byte})"/>
        Vector<byte> YShuffleKernel(Vector<byte> vector, Vector<byte> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{short}, Vector128{short})"/>
        Vector<short> YShuffleKernel(Vector<short> vector, Vector<short> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
        Vector<ushort> YShuffleKernel(Vector<ushort> vector, Vector<ushort> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{int}, Vector128{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{int}, Vector256{int})"/>
        Vector<int> YShuffleKernel(Vector<int> vector, Vector<int> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{uint}, Vector128{uint})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})"/>
        Vector<uint> YShuffleKernel(Vector<uint> vector, Vector<uint> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{long}, Vector128{long})"/>
        Vector<long> YShuffleKernel(Vector<long> vector, Vector<long> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{ulong}, Vector128{ulong})"/>
        Vector<ulong> YShuffleKernel(Vector<ulong> vector, Vector<ulong> indices);


        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void YShuffleKernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
        void YShuffleKernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector{short}, Vector{short}, Vector{short})"/>
        void YShuffleKernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void YShuffleKernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector{int}, Vector{int}, Vector{int})"/>
        void YShuffleKernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
        void YShuffleKernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector{long}, Vector{long}, Vector{long})"/>
        void YShuffleKernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void YShuffleKernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1);


        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{float}, Vector256{int})"/>
        Vector<float> YShuffleKernel_Core(Vector<float> vector, Vector<int> args0, Vector<int> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> YShuffleKernel_Core(Vector<double> vector, Vector<long> args0, Vector<long> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{sbyte}, Vector64{sbyte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        Vector<sbyte> YShuffleKernel_Core(Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{byte}, Vector64{byte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{byte}, Vector256{byte})"/>
        Vector<byte> YShuffleKernel_Core(Vector<byte> vector, Vector<byte> args0, Vector<byte> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> YShuffleKernel_Core(Vector<short> vector, Vector<short> args0, Vector<short> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> YShuffleKernel_Core(Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{int}, Vector256{int})"/>
        Vector<int> YShuffleKernel_Core(Vector<int> vector, Vector<int> args0, Vector<int> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})"/>
        Vector<uint> YShuffleKernel_Core(Vector<uint> vector, Vector<uint> args0, Vector<uint> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> YShuffleKernel_Core(Vector<long> vector, Vector<long> args0, Vector<long> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> YShuffleKernel_Core(Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX2</c> (运行 <c>YShuffleX2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的参数计算). Provide arguments for YShuffleX2_Core (为 YShuffleX2_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的核心计算). Its arguments are derived from YShuffleX2_Args (其参数来源于 YShuffleX2_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX2(Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX2Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX2Kernel(Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}}, Vector128{byte})">TBL(vqtbl2q_u8)</see></description>
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
        ///        <description>Combine by <see cref="Avx512Vbmi.VL.PermuteVar16x8x2(Vector128{byte}, Vector128{byte}, Vector128{byte})">VPERMI2B(_mm_permutex2var_epi8)</see></description>
        ///        <description>Combine by <see cref="Avx512BW.VL.PermuteVar8x16x2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})">VPERMI2W(_mm_permutex2var_epi16)</see></description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar4x32x2(Vector128{uint}, Vector128{uint}, Vector128{uint})">VPERMI2D(_mm_permutex2var_epi32)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar4x32x2(Vector128{float}, Vector128{int}, Vector128{float})">VPERMI2PS(_mm_permutex2var_ps)</see></description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar2x64x2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})">VPERMI2Q(_mm_permutex2var_epi64)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar2x64x2(Vector128{double}, Vector128{long}, Vector128{double})">VPERMI2PD(_mm_permutex2var_pd)</see></description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX2(Vector{byte}, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="YShuffleX2_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
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
        Vector<float> YShuffleX2(Vector<float> vector0, Vector<float> vector1, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<double> YShuffleX2(Vector<double> vector0, Vector<double> vector1, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<sbyte> YShuffleX2(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices);

        /// <inheritdoc cref="YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<byte> YShuffleX2(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices);

        /// <inheritdoc cref="YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<short> YShuffleX2(Vector<short> vector0, Vector<short> vector1, Vector<short> indices);

        /// <inheritdoc cref="YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ushort> YShuffleX2(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices);

        /// <inheritdoc cref="YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<int> YShuffleX2(Vector<int> vector0, Vector<int> vector1, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<uint> YShuffleX2(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices);

        /// <inheritdoc cref="YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<long> YShuffleX2(Vector<long> vector0, Vector<long> vector1, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ulong> YShuffleX2(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices);

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
        /// <seealso cref="YShuffleX2_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void YShuffleX2_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        void YShuffleX2_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        void YShuffleX2_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void YShuffleX2_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        void YShuffleX2_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        void YShuffleX2_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        void YShuffleX2_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void YShuffleX2_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4);

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
        /// <seealso cref="YShuffleX2_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<float> YShuffleX2_Core(Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> YShuffleX2_Core(Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        Vector<sbyte> YShuffleX2_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        Vector<byte> YShuffleX2_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> YShuffleX2_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> YShuffleX2_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<int> YShuffleX2_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        Vector<uint> YShuffleX2_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> YShuffleX2_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> YShuffleX2_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX2Insert</c> (运行 <c>YShuffleX2Insert</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的参数计算). Provide arguments for YShuffleX2Insert_Core (为 YShuffleX2Insert_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的核心计算). Its arguments are derived from YShuffleX2Insert_Args (其参数来源于 YShuffleX2Insert_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX2(Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX2Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX2Kernel(Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookupExtension(Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}}, Vector128{byte})">TBX(vqtbx2q_u8)</see></description>
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
        ///        <description>Combine by <see cref="Avx512Vbmi.VL.PermuteVar16x8x2(Vector128{byte}, Vector128{byte}, Vector128{byte})">VPERMI2B(_mm_permutex2var_epi8)</see></description>
        ///        <description>Combine by <see cref="Avx512BW.VL.PermuteVar8x16x2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})">VPERMI2W(_mm_permutex2var_epi16)</see></description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar4x32x2(Vector128{uint}, Vector128{uint}, Vector128{uint})">VPERMI2D(_mm_permutex2var_epi32)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar4x32x2(Vector128{float}, Vector128{int}, Vector128{float})">VPERMI2PS(_mm_permutex2var_ps)</see></description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar2x64x2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})">VPERMI2Q(_mm_permutex2var_epi64)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar2x64x2(Vector128{double}, Vector128{long}, Vector128{double})">VPERMI2PD(_mm_permutex2var_pd)</see></description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX2Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
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
        Vector<float> YShuffleX2Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<double> YShuffleX2Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<sbyte> YShuffleX2Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<byte> YShuffleX2Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<short> YShuffleX2Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ushort> YShuffleX2Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<int> YShuffleX2Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<uint> YShuffleX2Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<long> YShuffleX2Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ulong> YShuffleX2Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices);

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
        /// <seealso cref="YShuffleX2Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void YShuffleX2Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        void YShuffleX2Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        void YShuffleX2Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void YShuffleX2Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        void YShuffleX2Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        void YShuffleX2Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        void YShuffleX2Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void YShuffleX2Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4);

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
        /// <seealso cref="YShuffleX2Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<float> YShuffleX2Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> YShuffleX2Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        Vector<sbyte> YShuffleX2Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        Vector<byte> YShuffleX2Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> YShuffleX2Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> YShuffleX2Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<int> YShuffleX2Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        Vector<uint> YShuffleX2Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> YShuffleX2Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> YShuffleX2Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX2Kernel</c> (运行 <c>YShuffleX2Kernel</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle on 2 vectors 在2个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX2Kernel_Args (其参数来源于 YShuffleX2Kernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX2(Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX2Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX2Kernel(Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}}, Vector128{byte})">TBL(vqtbl2q_u8)</see></description>
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
        ///        <description><see cref="Avx512Vbmi.VL.PermuteVar16x8x2(Vector128{byte}, Vector128{byte}, Vector128{byte})">VPERMI2B(_mm_permutex2var_epi8)</see></description>
        ///        <description><see cref="Avx512BW.VL.PermuteVar8x16x2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})">VPERMI2W(_mm_permutex2var_epi16)</see></description>
        ///        <description><see cref="Avx512F.VL.PermuteVar4x32x2(Vector128{uint}, Vector128{uint}, Vector128{uint})">VPERMI2D(_mm_permutex2var_epi32)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar4x32x2(Vector128{float}, Vector128{int}, Vector128{float})">VPERMI2PS(_mm_permutex2var_ps)</see></description>
        ///        <description><see cref="Avx512F.VL.PermuteVar2x64x2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})">VPERMI2Q(_mm_permutex2var_epi64)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar2x64x2(Vector128{double}, Vector128{long}, Vector128{double})">VPERMI2PD(_mm_permutex2var_pd)</see></description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX2Kernel(Vector{byte}, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        /// 
        TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes { get; }

        /// <summary>
        /// Only shuffle on 2 vectors (在2个向量上进行仅换位). Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX2Kernel_AcceleratedTypes"/>
        Vector<float> YShuffleX2Kernel(Vector<float> vector0, Vector<float> vector1, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<double> YShuffleX2Kernel(Vector<double> vector0, Vector<double> vector1, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<sbyte> YShuffleX2Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<byte> YShuffleX2Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<short> YShuffleX2Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ushort> YShuffleX2Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<int> YShuffleX2Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<uint> YShuffleX2Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<long> YShuffleX2Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ulong> YShuffleX2Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices);

        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX2Kernel_Core .</param>
        /// <seealso cref="YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void YShuffleX2Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        void YShuffleX2Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        void YShuffleX2Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void YShuffleX2Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        void YShuffleX2Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        void YShuffleX2Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        void YShuffleX2Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void YShuffleX2Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3);

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
        /// <seealso cref="YShuffleX2Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<float> YShuffleX2Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> YShuffleX2Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        Vector<sbyte> YShuffleX2Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        Vector<byte> YShuffleX2Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> YShuffleX2Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> YShuffleX2Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<int> YShuffleX2Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        Vector<uint> YShuffleX2Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> YShuffleX2Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> YShuffleX2Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX3</c> (运行 <c>YShuffleX3</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的参数计算). Provide arguments for YShuffleX3_Core (为 YShuffleX3_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的核心计算). Its arguments are derived from YShuffleX3_Args (其参数来源于 YShuffleX3_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX3Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX3Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">TBL(vqtbl3q_u8)</see></description>
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
        /// <seealso cref="YShuffleX3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="YShuffleX3_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
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
        Vector<float> YShuffleX3(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<double> YShuffleX3(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<sbyte> YShuffleX3(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices);

        /// <inheritdoc cref="YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<byte> YShuffleX3(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices);

        /// <inheritdoc cref="YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<short> YShuffleX3(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices);

        /// <inheritdoc cref="YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ushort> YShuffleX3(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices);

        /// <inheritdoc cref="YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<int> YShuffleX3(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<uint> YShuffleX3(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices);

        /// <inheritdoc cref="YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<long> YShuffleX3(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ulong> YShuffleX3(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices);

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
        /// <seealso cref="YShuffleX3_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void YShuffleX3_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        void YShuffleX3_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        void YShuffleX3_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void YShuffleX3_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        void YShuffleX3_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        void YShuffleX3_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        void YShuffleX3_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void YShuffleX3_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4);

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
        /// <seealso cref="YShuffleX3_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<float> YShuffleX3_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> YShuffleX3_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        Vector<sbyte> YShuffleX3_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        Vector<byte> YShuffleX3_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> YShuffleX3_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> YShuffleX3_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<int> YShuffleX3_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        Vector<uint> YShuffleX3_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> YShuffleX3_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> YShuffleX3_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX3Insert</c> (运行 <c>YShuffleX3Insert</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的参数计算). Provide arguments for YShuffleX3Insert_Core (为 YShuffleX3Insert_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的核心计算). Its arguments are derived from YShuffleX3Insert_Args (其参数来源于 YShuffleX3Insert_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX3Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX3Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookupExtension(Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">TBX(vqtbx3q_u8)</see></description>
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
        /// <seealso cref="YShuffleX3Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
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
        Vector<float> YShuffleX3Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<double> YShuffleX3Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<sbyte> YShuffleX3Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<byte> YShuffleX3Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<short> YShuffleX3Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ushort> YShuffleX3Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<int> YShuffleX3Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<uint> YShuffleX3Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<long> YShuffleX3Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ulong> YShuffleX3Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices);

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
        /// <seealso cref="YShuffleX3Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void YShuffleX3Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        void YShuffleX3Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        void YShuffleX3Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void YShuffleX3Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        void YShuffleX3Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        void YShuffleX3Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        void YShuffleX3Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void YShuffleX3Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4);

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
        /// <seealso cref="YShuffleX3Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<float> YShuffleX3Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> YShuffleX3Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        Vector<sbyte> YShuffleX3Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        Vector<byte> YShuffleX3Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> YShuffleX3Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> YShuffleX3Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<int> YShuffleX3Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        Vector<uint> YShuffleX3Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> YShuffleX3Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> YShuffleX3Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX3Kernel</c> (运行 <c>YShuffleX3Kernel</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle on 3 vectors (在3个向量上进行仅换位的参数计算). Provide arguments for YShuffleX3Kernel_Core (为 YShuffleX3Kernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle on 3 vectors 在3个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX3Kernel_Args (其参数来源于 YShuffleX3Kernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX3Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX3Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">TBL(vqtbl3q_u8)</see></description>
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
        /// <seealso cref="YShuffleX3Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
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
        Vector<float> YShuffleX3Kernel(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<double> YShuffleX3Kernel(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<sbyte> YShuffleX3Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<byte> YShuffleX3Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<short> YShuffleX3Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ushort> YShuffleX3Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<int> YShuffleX3Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<uint> YShuffleX3Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<long> YShuffleX3Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ulong> YShuffleX3Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices);

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
        /// <seealso cref="YShuffleX3Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void YShuffleX3Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        void YShuffleX3Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        void YShuffleX3Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void YShuffleX3Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        void YShuffleX3Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        void YShuffleX3Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        void YShuffleX3Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void YShuffleX3Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3);

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
        /// <seealso cref="YShuffleX3Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<float> YShuffleX3Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> YShuffleX3Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        Vector<sbyte> YShuffleX3Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        Vector<byte> YShuffleX3Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> YShuffleX3Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> YShuffleX3Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<int> YShuffleX3Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        Vector<uint> YShuffleX3Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> YShuffleX3Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> YShuffleX3Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX4</c> (运行 <c>YShuffleX4</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的参数计算). Provide arguments for YShuffleX4_Core (为 YShuffleX4_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的核心计算). Its arguments are derived from YShuffleX4_Args (其参数来源于 YShuffleX4_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX4(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX4Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX4Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">TBL(vqtbl4q_u8)</see></description>
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
        /// <seealso cref="YShuffleX4(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="YShuffleX4_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
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
        Vector<float> YShuffleX4(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<double> YShuffleX4(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<sbyte> YShuffleX4(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices);

        /// <inheritdoc cref="YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<byte> YShuffleX4(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices);

        /// <inheritdoc cref="YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<short> YShuffleX4(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices);

        /// <inheritdoc cref="YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ushort> YShuffleX4(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices);

        /// <inheritdoc cref="YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<int> YShuffleX4(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<uint> YShuffleX4(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices);

        /// <inheritdoc cref="YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<long> YShuffleX4(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ulong> YShuffleX4(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices);

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
        /// <seealso cref="YShuffleX4_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void YShuffleX4_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        void YShuffleX4_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        void YShuffleX4_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void YShuffleX4_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        void YShuffleX4_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        void YShuffleX4_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        void YShuffleX4_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void YShuffleX4_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4);

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
        /// <seealso cref="YShuffleX4_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<float> YShuffleX4_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> YShuffleX4_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        Vector<sbyte> YShuffleX4_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        Vector<byte> YShuffleX4_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> YShuffleX4_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> YShuffleX4_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<int> YShuffleX4_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        Vector<uint> YShuffleX4_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> YShuffleX4_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> YShuffleX4_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX4Insert</c> (运行 <c>YShuffleX4Insert</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的参数计算). Provide arguments for YShuffleX4Insert_Core (为 YShuffleX4Insert_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的核心计算). Its arguments are derived from YShuffleX4Insert_Args (其参数来源于 YShuffleX4Insert_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX4(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX4Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX4Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookupExtension(Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">TBX(vqtbx4q_u8)</see></description>
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
        /// <seealso cref="YShuffleX4Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
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
        Vector<float> YShuffleX4Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<double> YShuffleX4Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<sbyte> YShuffleX4Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<byte> YShuffleX4Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<short> YShuffleX4Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ushort> YShuffleX4Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<int> YShuffleX4Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<uint> YShuffleX4Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<long> YShuffleX4Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ulong> YShuffleX4Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices);

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
        /// <seealso cref="YShuffleX4Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void YShuffleX4Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        void YShuffleX4Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        void YShuffleX4Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void YShuffleX4Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        void YShuffleX4Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        void YShuffleX4Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        void YShuffleX4Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void YShuffleX4Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4);

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
        /// <seealso cref="YShuffleX4Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<float> YShuffleX4Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> YShuffleX4Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        Vector<sbyte> YShuffleX4Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        Vector<byte> YShuffleX4Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> YShuffleX4Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> YShuffleX4Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<int> YShuffleX4Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        Vector<uint> YShuffleX4Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> YShuffleX4Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> YShuffleX4Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX4Kernel</c> (运行 <c>YShuffleX4Kernel</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle on 4 vectors 在4个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX4Kernel_Args (其参数来源于 YShuffleX4Kernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX4(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX4Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX4Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}}, Vector128{byte})">TBL(vqtbl4q_u8)</see></description>
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
        /// <seealso cref="YShuffleX4Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        /// 
        TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes { get; }

        /// <summary>
        /// Only shuffle on 4 vectors (在4个向量上进行仅换位). Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX4Kernel_AcceleratedTypes"/>
        Vector<float> YShuffleX4Kernel(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<double> YShuffleX4Kernel(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<sbyte> YShuffleX4Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<byte> YShuffleX4Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<short> YShuffleX4Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ushort> YShuffleX4Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<int> YShuffleX4Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<uint> YShuffleX4Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<long> YShuffleX4Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
        Vector<ulong> YShuffleX4Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices);

        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX4Kernel_Core .</param>
        /// <seealso cref="YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void YShuffleX4Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        void YShuffleX4Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        void YShuffleX4Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void YShuffleX4Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        void YShuffleX4Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        void YShuffleX4Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        void YShuffleX4Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void YShuffleX4Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3);

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
        /// <seealso cref="YShuffleX4Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<float> YShuffleX4Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> YShuffleX4Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        Vector<sbyte> YShuffleX4Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        Vector<byte> YShuffleX4Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> YShuffleX4Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> YShuffleX4Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        Vector<int> YShuffleX4Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        Vector<uint> YShuffleX4Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> YShuffleX4Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> YShuffleX4Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YSign</c> (运行 <c>YSign</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YSign(Vector{float})"/>
        TypeCodeFlags YSign_AcceleratedTypes { get; }

        /// <summary>
        /// Determine the sign of each element (判断各个元素的符号).
        /// Mnemonic: <c>rt[i] := sign(value[i])</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements depend on the sign of the corresponding element of <paramref name="value" />:  Returns 1 if the value is positive, 0 if the value is zero, and -1 if the value is negative (一个向量，其元素取决于value的对应元素的符号情况: 值为正数时返回1, 值为0时返回0, 值为负数时返回-1).</returns>
        /// <seealso cref="YSign_AcceleratedTypes"/>
        /// <seealso cref="MathINumber.Sign(float)"/>
        Vector<int> YSign(Vector<float> value);

        /// <inheritdoc cref="YSign(Vector{float})"/>
        /// <seealso cref="MathINumber.Sign(double)"/>
        Vector<long> YSign(Vector<double> value);

        /// <inheritdoc cref="YSign(Vector{float})"/>
        /// <seealso cref="MathINumber.Sign(sbyte)"/>
        Vector<sbyte> YSign(Vector<sbyte> value);

        /// <inheritdoc cref="YSign(Vector{float})"/>
        /// <seealso cref="MathINumber.Sign(short)"/>
        Vector<short> YSign(Vector<short> value);

        /// <inheritdoc cref="YSign(Vector{float})"/>
        /// <seealso cref="MathINumber.Sign(int)"/>
        Vector<int> YSign(Vector<int> value);

        /// <inheritdoc cref="YSign(Vector{float})"/>
        /// <seealso cref="MathINumber.Sign(long)"/>
        Vector<long> YSign(Vector<long> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YSignFloat</c> (运行 <c>YSignFloat</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YSignFloat(Vector{float})"/>
        TypeCodeFlags YSignFloat_AcceleratedTypes { get; }

        /// <summary>
        /// Determine the sign of each element and returns a floating point number (判断各个元素的符号并返回浮点数).
        /// Mnemonic: <c>rt[i] := signFloat(value[i])</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements depend on the sign of the corresponding element of <paramref name="value" />: Returns 1 if the value is positive, 0 if the value is zero, -1 if the value is negative, and <c>NaN</c> if the value is <c>NaN</c> (一个向量，其元素取决于value的对应元素的符号情况: 值为正数时返回1, 值为0时返回0, 值为负数时返回-1, 值为<c>NaN</c>时返回<c>NaN</c>).</returns>
        /// <seealso cref="YSignFloat_AcceleratedTypes"/>
        /// <seealso cref="MathINumber.Sign(float)"/>
        Vector<float> YSignFloat(Vector<float> value);

        /// <inheritdoc cref="YSignFloat(Vector{float})"/>
        /// <seealso cref="MathINumber.Sign(double)"/>
        Vector<double> YSignFloat(Vector<double> value);

    }
}
