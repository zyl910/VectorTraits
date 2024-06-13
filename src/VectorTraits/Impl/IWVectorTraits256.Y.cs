using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl {
    partial interface IWVectorTraits256 {
#if NETCOREAPP3_0_OR_GREATER

        // == mY style  ==

        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToByte</c> (运行 <c>YBitToByte</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector256{byte})"/>.</para>
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
        Vector256<byte> YBitToByte(uint value);


        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToInt16</c> (运行 <c>YBitToInt16</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector256{short})"/>.</para>
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
        Vector256<short> YBitToInt16(uint value);


        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToInt32</c> (运行 <c>YBitToInt32</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector256{int})"/>.</para>
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
        Vector256<int> YBitToInt32(uint value);


        /// <summary>
        /// Is it has hardware accelerated when running <c>YBitToInt64</c> (运行 <c>YBitToInt64</c> 时是否具有硬件加速).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="ExtractMostSignificantBits(Vector256{long})"/>.</para>
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
        Vector256<long> YBitToInt64(uint value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YClamp</c> (运行 <c>YClamp</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YClamp(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
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
        Vector256<float> YClamp(Vector256<float> value, Vector256<float> amin, Vector256<float> amax);

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
        Vector256<double> YClamp(Vector256<double> value, Vector256<double> amin, Vector256<double> amax);

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
        Vector256<sbyte> YClamp(Vector256<sbyte> value, Vector256<sbyte> amin, Vector256<sbyte> amax);

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
        Vector256<byte> YClamp(Vector256<byte> value, Vector256<byte> amin, Vector256<byte> amax);

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
        Vector256<short> YClamp(Vector256<short> value, Vector256<short> amin, Vector256<short> amax);

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
        Vector256<ushort> YClamp(Vector256<ushort> value, Vector256<ushort> amin, Vector256<ushort> amax);

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
        Vector256<int> YClamp(Vector256<int> value, Vector256<int> amin, Vector256<int> amax);

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
        Vector256<uint> YClamp(Vector256<uint> value, Vector256<uint> amin, Vector256<uint> amax);

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
        Vector256<long> YClamp(Vector256<long> value, Vector256<long> amin, Vector256<long> amax);

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
        Vector256<ulong> YClamp(Vector256<ulong> value, Vector256<ulong> amin, Vector256<ulong> amax);


        /// <summary>
        /// Types with hardware acceleration when running <c>YCopySign</c> (运行 <c>YCopySign</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YCopySign(Vector256{float}, Vector256{float})"/>
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
        Vector256<float> YCopySign(Vector256<float> value, Vector256<float> sign);

        /// <inheritdoc cref="YCopySign(Vector256{float}, Vector256{float})"/>
        /// <seealso cref="MathINumber.CopySign(double, double)"/>
        Vector256<double> YCopySign(Vector256<double> value, Vector256<double> sign);

        /// <inheritdoc cref="YCopySign(Vector256{float}, Vector256{float})"/>
        /// <seealso cref="MathINumber.CopySign(sbyte, sbyte)"/>
        Vector256<sbyte> YCopySign(Vector256<sbyte> value, Vector256<sbyte> sign);

        /// <inheritdoc cref="YCopySign(Vector256{float}, Vector256{float})"/>
        /// <seealso cref="MathINumber.CopySign(short, short)"/>
        Vector256<short> YCopySign(Vector256<short> value, Vector256<short> sign);

        /// <inheritdoc cref="YCopySign(Vector256{float}, Vector256{float})"/>
        /// <seealso cref="MathINumber.CopySign(int, int)"/>
        Vector256<int> YCopySign(Vector256<int> value, Vector256<int> sign);

        /// <inheritdoc cref="YCopySign(Vector256{float}, Vector256{float})"/>
        /// <seealso cref="MathINumber.CopySign(long, long)"/>
        Vector256<long> YCopySign(Vector256<long> value, Vector256<long> sign);


        /// <summary>
        /// Types with hardware acceleration when running <c>YGroup2Zip</c> (运行 <c>YGroup2Zip</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Sample (示例).</para>
        /// <list type="table">
        ///    <listheader>
        ///        <term>Elements</term>
        ///        <description>Result</description>
        ///    </listheader>
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
        /// <seealso cref="YGroup2Zip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
        TypeCodeFlags YGroup2Zip_AcceleratedTypes { get; }

        /// <summary>
        /// Interleave 2 vectors into 2-element groups (将2个向量交织为2-元素组).
        /// Mnemonic: <c>element_ref(i, data0, data1) := (0==(i&amp;1))?( x[i2] ):( y[i2] )</c>, <c>i2 := i/2</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <param name="data1">Returns part 1 of the interleaved data (返回交织后数据的第1部分).</param>
        /// <returns>Returns part 0 of the interleaved data (返回交织后数据的第0部分).</returns>
        /// <seealso cref="YGroup2Zip_AcceleratedTypes"/>
        Vector256<float> YGroup2Zip(Vector256<float> x, Vector256<float> y, out Vector256<float> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
        Vector256<double> YGroup2Zip(Vector256<double> x, Vector256<double> y, out Vector256<double> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
        Vector256<sbyte> YGroup2Zip(Vector256<sbyte> x, Vector256<sbyte> y, out Vector256<sbyte> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
        Vector256<byte> YGroup2Zip(Vector256<byte> x, Vector256<byte> y, out Vector256<byte> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
        Vector256<short> YGroup2Zip(Vector256<short> x, Vector256<short> y, out Vector256<short> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
        Vector256<ushort> YGroup2Zip(Vector256<ushort> x, Vector256<ushort> y, out Vector256<ushort> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
        Vector256<int> YGroup2Zip(Vector256<int> x, Vector256<int> y, out Vector256<int> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
        Vector256<uint> YGroup2Zip(Vector256<uint> x, Vector256<uint> y, out Vector256<uint> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
        Vector256<long> YGroup2Zip(Vector256<long> x, Vector256<long> y, out Vector256<long> data1);

        /// <inheritdoc cref="YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
        Vector256<ulong> YGroup2Zip(Vector256<ulong> x, Vector256<ulong> y, out Vector256<ulong> data1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsAllTrue</c> (运行 <c>YIsAllTrue</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsAllTrue{T}(Vector256{T})"/>
        TypeCodeFlags YIsAllTrue_AcceleratedTypes { get; }

        /// <summary>
        /// Checks if all elements of the vector is true (检查向量中所有元素是不是都为true).
        /// Mnemonic: <c>rt := value[0] &amp;&amp; value[1] &amp;&amp; value[2] &amp;&amp; ... &amp;&amp; value[Count-1]</c>. The element of value must be 0 or <see cref="Scalars{T}.AllBitsSet">AllBitsSet</see> (Signed integer value -1).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector whose elements will be checked. The return value of a comparison category function can be assigned to it (将检查其元素的向量. 可将比较类函数的返回值赋值给它). e.g. <see cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>.</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="value"/> is true. (<paramref name="value" /> 中所有元素为true时返回<c>true</c>).</returns>
        /// <seealso cref="YIsAllTrue_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAll{T}(Vector256{T}, Vector256{T})" />
        bool YIsAllTrue<T>(Vector256<T> value) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsAnyTrue</c> (运行 <c>YIsAnyTrue</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsAnyTrue{T}(Vector256{T})"/>
        TypeCodeFlags YIsAnyTrue_AcceleratedTypes { get; }

        /// <summary>
        /// Checks if any elements of the vector is true (检查向量中任一元素是不是为true).
        /// Mnemonic: <c>rt := value[0] || value[1] || value[2] || ... || value[Count-1]</c>. The element of value must be 0 or <see cref="Scalars{T}.AllBitsSet">AllBitsSet</see> (Signed integer value -1).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector whose elements will be checked. The return value of a comparison category function can be assigned to it (将检查其元素的向量. 可将比较类函数的返回值赋值给它). e.g. <see cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>.</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="value"/> is true. (<paramref name="value" /> 中任一元素为true时返回<c>true</c>).</returns>
        /// <seealso cref="YIsAnyTrue_AcceleratedTypes"/>
        /// <seealso cref="Vector256.EqualsAny{T}(Vector256{T}, Vector256{T})" />
        bool YIsAnyTrue<T>(Vector256<T> value) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsEvenInteger</c> (运行 <c>YIsEvenInteger</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsEvenInteger(Vector256{float})"/>
        TypeCodeFlags YIsEvenInteger_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents an even integral number (确定元素是否为偶数整数).
        /// Mnemonic: <c>rt[i] := to_mask(isEvenInteger(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is even integral number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为偶数整数).</returns>
        /// <seealso cref="YIsEvenInteger_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(float)"/>
        Vector256<int> YIsEvenInteger(Vector256<float> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(double)"/>
        Vector256<long> YIsEvenInteger(Vector256<double> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(sbyte)"/>
        Vector256<sbyte> YIsEvenInteger(Vector256<sbyte> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(byte)"/>
        Vector256<byte> YIsEvenInteger(Vector256<byte> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(short)"/>
        Vector256<short> YIsEvenInteger(Vector256<short> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(ushort)"/>
        Vector256<ushort> YIsEvenInteger(Vector256<ushort> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(int)"/>
        Vector256<int> YIsEvenInteger(Vector256<int> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(uint)"/>
        Vector256<uint> YIsEvenInteger(Vector256<uint> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(long)"/>
        Vector256<long> YIsEvenInteger(Vector256<long> value);

        /// <inheritdoc cref="YIsEvenInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsEvenInteger(ulong)"/>
        Vector256<ulong> YIsEvenInteger(Vector256<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsFinite</c> (运行 <c>YIsFinite</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsFinite(Vector256{float})"/>
        TypeCodeFlags YIsFinite_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is finite. It contains zero, subnormal, and normal. It does not contain infinity, NaN (确定元素是否为有限值. 它包含 零、次正规数、正规数. 它不含无穷大、非数).
        /// Mnemonic: <c>rt[i] := to_mask(isFinite(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is finite (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为有限的).</returns>
        /// <seealso cref="YIsFinite_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsFinite(float)"/>
        Vector256<int> YIsFinite(Vector256<float> value);

        /// <inheritdoc cref="YIsFinite(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsFinite(double)"/>
        Vector256<long> YIsFinite(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsInfinity</c> (运行 <c>YIsInfinity</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsInfinity(Vector256{float})"/>
        TypeCodeFlags YIsInfinity_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is infinite (确定元素是否为无穷大).
        /// Mnemonic: <c>rt[i] := to_mask(isInfinity(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is infinite (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为无穷大).</returns>
        /// <seealso cref="YIsInfinity_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsInfinity(float)"/>
        Vector256<int> YIsInfinity(Vector256<float> value);

        /// <inheritdoc cref="YIsInfinity(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsInfinity(double)"/>
        Vector256<long> YIsInfinity(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsInfinityOrNaN</c> (运行 <c>YIsInfinityOrNaN</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsInfinityOrNaN(Vector256{float})"/>
        TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is infinite or NaN (确定元素是否为无穷大或非数).
        /// Mnemonic: <c>rt[i] := to_mask(isInfinityOrNaN(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is infinite or NaN (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为无穷大或非数).</returns>
        /// <seealso cref="YIsInfinityOrNaN_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsInfinityOrNaN(float)"/>
        Vector256<int> YIsInfinityOrNaN(Vector256<float> value);

        /// <inheritdoc cref="YIsInfinityOrNaN(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsInfinityOrNaN(double)"/>
        Vector256<long> YIsInfinityOrNaN(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsInteger</c> (运行 <c>YIsInteger</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsInteger(Vector256{float})"/>
        TypeCodeFlags YIsInteger_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents an integral number (确定元素是否为整数).
        /// Mnemonic: <c>rt[i] := to_mask(isInteger(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is integral number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为整数).</returns>
        /// <seealso cref="YIsInteger_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsInteger(float)"/>
        Vector256<int> YIsInteger(Vector256<float> value);

        /// <inheritdoc cref="YIsInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsInteger(double)"/>
        Vector256<long> YIsInteger(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNaN</c> (运行 <c>YIsNaN</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNaN(Vector256{float})"/>
        TypeCodeFlags YIsNaN_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is NaN (确定元素是否为非数).
        /// Mnemonic: <c>rt[i] := to_mask(isNaN(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is NaN (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为非数).</returns>
        /// <seealso cref="YIsNaN_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNaN(float)"/>
        Vector256<int> YIsNaN(Vector256<float> value);

        /// <inheritdoc cref="YIsNaN(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsNaN(double)"/>
        Vector256<long> YIsNaN(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNegative</c> (运行 <c>YIsNegative</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNegative(Vector256{float})"/>
        TypeCodeFlags YIsNegative_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents a negative number or negative zero (确定元素是否为负数或负零).
        /// Mnemonic: <c>rt[i] := to_mask(isNegative(value[i])) = to_mask((value[i]&lt;0) || isNegativeZero(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is negative number or negative zero (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为负数或负零).</returns>
        /// <seealso cref="YIsNegative_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNegative(float)"/>
        Vector256<int> YIsNegative(Vector256<float> value);

        /// <inheritdoc cref="YIsNegative(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(double)"/>
        Vector256<long> YIsNegative(Vector256<double> value);

        /// <inheritdoc cref="YIsNegative(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(sbyte)"/>
        Vector256<sbyte> YIsNegative(Vector256<sbyte> value);

        /// <inheritdoc cref="YIsNegative(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(short)"/>
        Vector256<short> YIsNegative(Vector256<short> value);

        /// <inheritdoc cref="YIsNegative(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(int)"/>
        Vector256<int> YIsNegative(Vector256<int> value);

        /// <inheritdoc cref="YIsNegative(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsNegative(long)"/>
        Vector256<long> YIsNegative(Vector256<long> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNegativeInfinity</c> (运行 <c>YIsNegativeInfinity</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNegativeInfinity(Vector256{float})"/>
        TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is negative infinity (确定元素是否为负无穷大).
        /// Mnemonic: <c>rt[i] := to_mask(isNegativeInfinity(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is negative infinity (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为负无穷大).</returns>
        /// <seealso cref="YIsNegativeInfinity_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNegativeInfinity(float)"/>
        Vector256<int> YIsNegativeInfinity(Vector256<float> value);

        /// <inheritdoc cref="YIsNegativeInfinity(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsNegativeInfinity(double)"/>
        Vector256<long> YIsNegativeInfinity(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNegativeZero</c> (运行 <c>YIsNegativeZero</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNegativeZero(Vector256{float})"/>
        TypeCodeFlags YIsNegativeZero_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents a negative zero (确定元素是否为负零).
        /// Mnemonic: <c>rt[i] := to_mask(isNegativeZero(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is finite (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为有限的).</returns>
        /// <seealso cref="YIsNegativeZero_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNegativeZero(float)"/>
        Vector256<int> YIsNegativeZero(Vector256<float> value);

        /// <inheritdoc cref="YIsNegativeZero(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsNegativeZero(double)"/>
        Vector256<long> YIsNegativeZero(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNormal</c> (运行 <c>YIsNormal</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNormal(Vector256{float})"/>
        TypeCodeFlags YIsNormal_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is normal (确定元素是否为正规数).
        /// Mnemonic: <c>rt[i] := to_mask(isFinite(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is normal (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为正规数).</returns>
        /// <seealso cref="YIsNormal_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNormal(float)"/>
        Vector256<int> YIsNormal(Vector256<float> value);

        /// <inheritdoc cref="YIsNormal(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsNormal(double)"/>
        Vector256<long> YIsNormal(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNotEquals</c> (运行 <c>YIsNotEquals</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNotEquals(Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags YIsNotEquals_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>
        Vector256<float> YIsNotEquals(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>
        Vector256<double> YIsNotEquals(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>
        Vector256<sbyte> YIsNotEquals(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>
        Vector256<byte> YIsNotEquals(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>
        Vector256<short> YIsNotEquals(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>
        Vector256<ushort> YIsNotEquals(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>
        Vector256<int> YIsNotEquals(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>
        Vector256<uint> YIsNotEquals(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>
        Vector256<long> YIsNotEquals(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] != right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" />were not equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否不相等).</returns>
        /// <seealso cref="YIsNotEquals_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Equals{T}(Vector256{T}, Vector256{T})"/>
        Vector256<ulong> YIsNotEquals(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsNotNaN</c> (运行 <c>YIsNotNaN</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsNotNaN(Vector256{float})"/>
        TypeCodeFlags YIsNotNaN_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is not NaN (确定元素是否不为非数).
        /// Mnemonic: <c>rt[i] := to_mask(isNotNaN(value[i])) = to_mask(!isNaN(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is not NaN (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否不为非数).</returns>
        /// <seealso cref="YIsNotNaN_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsNotNaN(float)"/>
        Vector256<int> YIsNotNaN(Vector256<float> value);

        /// <inheritdoc cref="YIsNotNaN(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsNotNaN(double)"/>
        Vector256<long> YIsNotNaN(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsOddInteger</c> (运行 <c>YIsOddInteger</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsOddInteger(Vector256{float})"/>
        TypeCodeFlags YIsOddInteger_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents an odd integral number (确定元素是否为奇数整数).
        /// Mnemonic: <c>rt[i] := to_mask(isOddInteger(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is odd integral number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为奇数整数).</returns>
        /// <seealso cref="YIsOddInteger_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(float)"/>
        Vector256<int> YIsOddInteger(Vector256<float> value);

        /// <inheritdoc cref="YIsOddInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(double)"/>
        Vector256<long> YIsOddInteger(Vector256<double> value);

        /// <inheritdoc cref="YIsOddInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(sbyte)"/>
        Vector256<sbyte> YIsOddInteger(Vector256<sbyte> value);

        /// <inheritdoc cref="YIsOddInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(byte)"/>
        Vector256<byte> YIsOddInteger(Vector256<byte> value);

        /// <inheritdoc cref="YIsOddInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(short)"/>
        Vector256<short> YIsOddInteger(Vector256<short> value);

        /// <inheritdoc cref="YIsOddInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(ushort)"/>
        Vector256<ushort> YIsOddInteger(Vector256<ushort> value);

        /// <inheritdoc cref="YIsOddInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(int)"/>
        Vector256<int> YIsOddInteger(Vector256<int> value);

        /// <inheritdoc cref="YIsOddInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(uint)"/>
        Vector256<uint> YIsOddInteger(Vector256<uint> value);

        /// <inheritdoc cref="YIsOddInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(long)"/>
        Vector256<long> YIsOddInteger(Vector256<long> value);

        /// <inheritdoc cref="YIsOddInteger(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsOddInteger(ulong)"/>
        Vector256<ulong> YIsOddInteger(Vector256<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsPositive</c> (运行 <c>YIsPositive</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsPositive(Vector256{float})"/>
        TypeCodeFlags YIsPositive_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element represents zero or a positive number (确定元素是否为零或正数).
        /// Mnemonic: <c>rt[i] := to_mask(isNegative(value[i])) = to_mask((value[i]&lt;0) || isNegativeZero(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is zero or a positive number (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为零或正数).</returns>
        /// <seealso cref="YIsPositive_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsPositive(float)"/>
        Vector256<int> YIsPositive(Vector256<float> value);

        /// <inheritdoc cref="YIsPositive(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(double)"/>
        Vector256<long> YIsPositive(Vector256<double> value);

        /// <inheritdoc cref="YIsPositive(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(sbyte)"/>
        Vector256<sbyte> YIsPositive(Vector256<sbyte> value);

        /// <inheritdoc cref="YIsPositive(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(short)"/>
        Vector256<short> YIsPositive(Vector256<short> value);

        /// <inheritdoc cref="YIsPositive(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(int)"/>
        Vector256<int> YIsPositive(Vector256<int> value);

        /// <inheritdoc cref="YIsPositive(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsPositive(long)"/>
        Vector256<long> YIsPositive(Vector256<long> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsPositiveInfinity</c> (运行 <c>YIsPositiveInfinity</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsPositiveInfinity(Vector256{float})"/>
        TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is positive infinity (确定元素是否为正无穷大).
        /// Mnemonic: <c>rt[i] := to_mask(isNegativeInfinity(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is positive infinity (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为正无穷大).</returns>
        /// <seealso cref="YIsPositiveInfinity_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsPositiveInfinity(float)"/>
        Vector256<int> YIsPositiveInfinity(Vector256<float> value);

        /// <inheritdoc cref="YIsPositiveInfinity(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsPositiveInfinity(double)"/>
        Vector256<long> YIsPositiveInfinity(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsSubnormal</c> (运行 <c>YIsSubnormal</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsSubnormal(Vector256{float})"/>
        TypeCodeFlags YIsSubnormal_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is subnormal (确定元素是否为次正规数).
        /// Mnemonic: <c>rt[i] := to_mask(IsSubnormal(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is subnormal (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为次正规数).</returns>
        /// <seealso cref="YIsSubnormal_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsSubnormal(float)"/>
        Vector256<int> YIsSubnormal(Vector256<float> value);

        /// <inheritdoc cref="YIsSubnormal(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsSubnormal(double)"/>
        Vector256<long> YIsSubnormal(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsZero</c> (运行 <c>YIsZero</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsZero(Vector256{float})"/>
        TypeCodeFlags YIsZero_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is zero (确定元素是否为零).
        /// Mnemonic: <c>rt[i] := to_mask(0==value[i])</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is zero (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为零).</returns>
        /// <seealso cref="YIsZero_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsZero(float)"/>
        Vector256<int> YIsZero(Vector256<float> value);

        /// <inheritdoc cref="YIsZero(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(double)"/>
        Vector256<long> YIsZero(Vector256<double> value);

        /// <inheritdoc cref="YIsZero(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(sbyte)"/>
        Vector256<sbyte> YIsZero(Vector256<sbyte> value);

        /// <inheritdoc cref="YIsZero(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(byte)"/>
        Vector256<byte> YIsZero(Vector256<byte> value);

        /// <inheritdoc cref="YIsZero(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(short)"/>
        Vector256<short> YIsZero(Vector256<short> value);

        /// <inheritdoc cref="YIsZero(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(ushort)"/>
        Vector256<ushort> YIsZero(Vector256<ushort> value);

        /// <inheritdoc cref="YIsZero(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(int)"/>
        Vector256<int> YIsZero(Vector256<int> value);

        /// <inheritdoc cref="YIsZero(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(uint)"/>
        Vector256<uint> YIsZero(Vector256<uint> value);

        /// <inheritdoc cref="YIsZero(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(long)"/>
        Vector256<long> YIsZero(Vector256<long> value);

        /// <inheritdoc cref="YIsZero(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsZero(ulong)"/>
        Vector256<ulong> YIsZero(Vector256<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YIsZeroOrSubnormal</c> (运行 <c>YIsZeroOrSubnormal</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YIsZeroOrSubnormal(Vector256{float})"/>
        TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes { get; }

        /// <summary>
        /// Determines if a element is zero or subnormal (确定元素是否为零或次正规数).
        /// Mnemonic: <c>rt[i] := to_mask(isZeroOrSubnormal(value[i]))</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="value" /> were is zero or subnormal (一个向量，其元素是全位为1或0，取决于<paramref name="value" />的对应元素中是否为零或次正规数).</returns>
        /// <seealso cref="YIsZeroOrSubnormal_AcceleratedTypes"/>
        /// <seealso cref="MathINumberBase.IsZeroOrSubnormal(float)"/>
        Vector256<int> YIsZeroOrSubnormal(Vector256<float> value);

        /// <inheritdoc cref="YIsZeroOrSubnormal(Vector256{float})"/>
        /// <seealso cref="MathINumberBase.IsZeroOrSubnormal(double)"/>
        Vector256<long> YIsZeroOrSubnormal(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YMaxNumber</c> (运行 <c>YMaxNumber</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YMaxNumber(Vector256{float}, Vector256{float})"/>
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
        Vector256<float> YMaxNumber(Vector256<float> left, Vector256<float> right);

        /// <inheritdoc cref="YMaxNumber(Vector256{float}, Vector256{float})"/>
        /// <seealso cref="MathINumber.MaxNumber(double, double)"/>
        Vector256<double> YMaxNumber(Vector256<double> left, Vector256<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>YMinNumber</c> (运行 <c>YMinNumber</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YMinNumber(Vector256{float}, Vector256{float})"/>
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
        Vector256<float> YMinNumber(Vector256<float> left, Vector256<float> right);

        /// <inheritdoc cref="YMinNumber(Vector256{float}, Vector256{float})"/>
        /// <seealso cref="MathINumber.MinNumber(double, double)"/>
        Vector256<double> YMinNumber(Vector256<double> left, Vector256<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>YNarrowSaturate</c> (运行 <c>YNarrowSaturate</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YNarrowSaturate(Vector256{short}, Vector256{short})"/>
        /// <seealso cref="YNarrowSaturate_FullAcceleratedTypes"/>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturate_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>YNarrowSaturate</c> (运行 <c>YNarrowSaturate</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="YNarrowSaturate(Vector256{short}, Vector256{short})"/>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes { get; }

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="Avx2.PackSignedSaturate(Vector256{short}, Vector256{short})"/>
        Vector256<sbyte> YNarrowSaturate(Vector256<short> lower, Vector256<short> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector256<byte> YNarrowSaturate(Vector256<ushort> lower, Vector256<ushort> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        /// <seealso cref="Avx2.PackSignedSaturate(Vector256{int}, Vector256{int})"/>
        Vector256<short> YNarrowSaturate(Vector256<int> lower, Vector256<int> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector256<ushort> YNarrowSaturate(Vector256<uint> lower, Vector256<uint> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector256<int> YNarrowSaturate(Vector256<long> lower, Vector256<long> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector256<uint> YNarrowSaturate(Vector256<ulong> lower, Vector256<ulong> upper);


        /// <summary>
        /// Types with hardware acceleration when running <c>YNarrowSaturateUnsigned</c> (运行 <c>YNarrowSaturateUnsigned</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YNarrowSaturateUnsigned(Vector256{short}, Vector256{short})"/>
        /// <seealso cref="YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>YNarrowSaturateUnsigned</c> (运行 <c>YNarrowSaturateUnsigned</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="YNarrowSaturateUnsigned(Vector256{short}, Vector256{short})"/>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes { get; }

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector256{T}"/> instances into one unsigned <seealso cref="Vector256{T}"/>"  (将两个有符号 <seealso cref="Vector256{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        /// <seealso cref="Avx2.PackUnsignedSaturate(Vector256{short}, Vector256{short})"/>
        Vector256<byte> YNarrowSaturateUnsigned(Vector256<short> lower, Vector256<short> upper);

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector256{T}"/> instances into one unsigned <seealso cref="Vector256{T}"/>"  (将两个有符号 <seealso cref="Vector256{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        /// <seealso cref="Avx2.PackUnsignedSaturate(Vector256{int}, Vector256{int})"/>
        Vector256<ushort> YNarrowSaturateUnsigned(Vector256<int> lower, Vector256<int> upper);

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector256{T}"/> instances into one unsigned <seealso cref="Vector256{T}"/>"  (将两个有符号 <seealso cref="Vector256{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        Vector256<uint> YNarrowSaturateUnsigned(Vector256<long> lower, Vector256<long> upper);


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
        Vector256<T> YOrNot<T>(Vector256<T> left, Vector256<T> right) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>YRoundToEven</c> (运行 <c>YRoundToEven</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Methods used to calculate rounding (用于计算舍入的方法):</para>
        /// <para>- <see cref="Ceiling(Vector256{float})"/>: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.</para>
        /// <para>- <see cref="Floor(Vector256{float})"/>: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.</para>
        /// <para>- <see cref="YRoundToEven(Vector256{float})"/>: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.</para>
        /// <para>- <see cref="YRoundToZero(Vector256{float})"/>: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.</para>
        /// </remarks>
        /// <seealso cref="YRoundToEven(Vector256{float})"/>
        TypeCodeFlags YRoundToEven_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.
        /// Mnemonic: <c>rt[i] := round_to_even(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to even computed (将计算向偶数舍入的向量).</param>
        /// <returns>A vector whose elements are the round to even of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向偶数舍入).</returns>
        /// <seealso cref="YRoundToEven_AcceleratedTypes"/>
        Vector256<float> YRoundToEven(Vector256<float> value);

        /// <summary>
        /// Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.
        /// Mnemonic: <c>rt[i] := round_to_even(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to even computed (将计算向偶数舍入的向量).</param>
        /// <returns>A vector whose elements are the round to even of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向偶数舍入).</returns>
        /// <seealso cref="YRoundToEven_AcceleratedTypes"/>
        Vector256<double> YRoundToEven(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YRoundToZero</c> (运行 <c>YRoundToZero</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Methods used to calculate rounding (用于计算舍入的方法):</para>
        /// <para>- <see cref="Ceiling(Vector256{float})"/>: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.</para>
        /// <para>- <see cref="Floor(Vector256{float})"/>: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.</para>
        /// <para>- <see cref="YRoundToEven(Vector256{float})"/>: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.</para>
        /// <para>- <see cref="YRoundToZero(Vector256{float})"/>: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.</para>
        /// </remarks>
        /// <seealso cref="YRoundToZero(Vector256{float})"/>
        TypeCodeFlags YRoundToZero_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.
        /// Mnemonic: <c>rt[i] := round_to_zero(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to zero computed (将计算向零舍入的向量).</param>
        /// <returns>A vector whose elements are the round to zero of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向零舍入).</returns>
        /// <seealso cref="YRoundToZero_AcceleratedTypes"/>
        Vector256<float> YRoundToZero(Vector256<float> value);

        /// <summary>
        /// Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.
        /// Mnemonic: <c>rt[i] := round_to_zero(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its round to zero computed (将计算向零舍入的向量).</param>
        /// <returns>A vector whose elements are the round to zero of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向零舍入).</returns>
        /// <seealso cref="YRoundToZero_AcceleratedTypes"/>
        Vector256<double> YRoundToZero(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleG2</c> (运行 <c>YShuffleG2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2(Vector256{byte}, ShuffleControlG2)"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4(Vector256{byte}, ShuffleControlG4)"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).</para>
        /// <para>- <see cref="YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2(Vector256{byte}, ShuffleControlG2)"/>
        /// <seealso cref="YShuffleG4(Vector256{byte}, ShuffleControlG4)"/>
        /// <seealso cref="YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>
        TypeCodeFlags YShuffleG2_AcceleratedTypes { get; }

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<float> YShuffleG2(Vector256<float> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<double> YShuffleG2(Vector256<double> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<sbyte> YShuffleG2(Vector256<sbyte> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<byte> YShuffleG2(Vector256<byte> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<short> YShuffleG2(Vector256<short> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<ushort> YShuffleG2(Vector256<ushort> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<int> YShuffleG2(Vector256<int> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<uint> YShuffleG2(Vector256<uint> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<long> YShuffleG2(Vector256<long> source, ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<ulong> YShuffleG2(Vector256<ulong> source, ShuffleControlG2 control);

#if !REDUCE_MEMORY_USAGE
        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<float> YShuffleG2_Const(Vector256<float> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<double> YShuffleG2_Const(Vector256<double> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<sbyte> YShuffleG2_Const(Vector256<sbyte> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<byte> YShuffleG2_Const(Vector256<byte> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<short> YShuffleG2_Const(Vector256<short> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<ushort> YShuffleG2_Const(Vector256<ushort> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<int> YShuffleG2_Const(Vector256<int> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<uint> YShuffleG2_Const(Vector256<uint> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<long> YShuffleG2_Const(Vector256<long> source, [ConstantExpected] ShuffleControlG2 control);

        /// <summary>
        /// For each 2-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 2-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xy = shuffleG2_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~1)) | ((control &gt;&gt; (i&amp;1)) &amp; 1)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG2_AcceleratedTypes"/>
        Vector256<ulong> YShuffleG2_Const(Vector256<ulong> source, [ConstantExpected] ShuffleControlG2 control);
#endif // !REDUCE_MEMORY_USAGE


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleG4</c> (运行 <c>YShuffleG4</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2(Vector256{byte}, ShuffleControlG2)"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4(Vector256{byte}, ShuffleControlG4)"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).</para>
        /// <para>- <see cref="YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2(Vector256{byte}, ShuffleControlG2)"/>
        /// <seealso cref="YShuffleG4(Vector256{byte}, ShuffleControlG4)"/>
        /// <seealso cref="YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>
        TypeCodeFlags YShuffleG4_AcceleratedTypes { get; }

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<float> YShuffleG4(Vector256<float> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<double> YShuffleG4(Vector256<double> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<sbyte> YShuffleG4(Vector256<sbyte> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<byte> YShuffleG4(Vector256<byte> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<short> YShuffleG4(Vector256<short> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<ushort> YShuffleG4(Vector256<ushort> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<int> YShuffleG4(Vector256<int> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<uint> YShuffleG4(Vector256<uint> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<long> YShuffleG4(Vector256<long> source, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<ulong> YShuffleG4(Vector256<ulong> source, ShuffleControlG4 control);

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
        Vector256<float> YShuffleG4_Const(Vector256<float> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.Permute4x64(Vector256{double}, byte)"/>
        Vector256<double> YShuffleG4_Const(Vector256<double> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<sbyte> YShuffleG4_Const(Vector256<sbyte> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        Vector256<byte> YShuffleG4_Const(Vector256<byte> source, [ConstantExpected] ShuffleControlG4 control);

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
        Vector256<short> YShuffleG4_Const(Vector256<short> source, [ConstantExpected] ShuffleControlG4 control);

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
        Vector256<ushort> YShuffleG4_Const(Vector256<ushort> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{int}, byte)"/>
        Vector256<int> YShuffleG4_Const(Vector256<int> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{uint}, byte)"/>
        Vector256<uint> YShuffleG4_Const(Vector256<uint> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.Permute4x64(Vector256{long}, byte)"/>
        Vector256<long> YShuffleG4_Const(Vector256<long> source, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in a vector, shuffle is performed - Constant version (对于一个向量中的每个 4-元素组, 进行换位 - 常量版). If the count of the vector is less than 4, please use YShuffleG4X2_Const instead (如果向量的数量小于4，请使用 YShuffleG4X2_Const 代替).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source)</c>. View for element: <c>rt[i] := source[(i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3)]</c>.
        /// </summary>
        /// <param name="source">The input source from which values are selected (从中选择值的输入向量).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>A new source containing the values from <paramref name="source" /> selected by the given <paramref name="control" /> (一个新向量，其中包含给定 <paramref name="control" /> 从 <paramref name="source" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleG4_AcceleratedTypes"/>
        /// <seealso cref="Avx2.Permute4x64(Vector256{ulong}, byte)"/>
        Vector256<ulong> YShuffleG4_Const(Vector256<ulong> source, [ConstantExpected] ShuffleControlG4 control);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleG4X2</c> (运行 <c>YShuffleG4X2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2(Vector256{byte}, ShuffleControlG2)"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4(Vector256{byte}, ShuffleControlG4)"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).</para>
        /// <para>- <see cref="YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2(Vector256{byte}, ShuffleControlG2)"/>
        /// <seealso cref="YShuffleG4(Vector256{byte}, ShuffleControlG4)"/>
        /// <seealso cref="YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>
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
        Vector256<float> YShuffleG4X2(Vector256<float> source0, Vector256<float> source1, ShuffleControlG4 control, out Vector256<float> result1);

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
        Vector256<double> YShuffleG4X2(Vector256<double> source0, Vector256<double> source1, ShuffleControlG4 control, out Vector256<double> result1);

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
        Vector256<sbyte> YShuffleG4X2(Vector256<sbyte> source0, Vector256<sbyte> source1, ShuffleControlG4 control, out Vector256<sbyte> result1);

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
        Vector256<byte> YShuffleG4X2(Vector256<byte> source0, Vector256<byte> source1, ShuffleControlG4 control, out Vector256<byte> result1);

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
        Vector256<short> YShuffleG4X2(Vector256<short> source0, Vector256<short> source1, ShuffleControlG4 control, out Vector256<short> result1);

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
        Vector256<ushort> YShuffleG4X2(Vector256<ushort> source0, Vector256<ushort> source1, ShuffleControlG4 control, out Vector256<ushort> result1);

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
        Vector256<int> YShuffleG4X2(Vector256<int> source0, Vector256<int> source1, ShuffleControlG4 control, out Vector256<int> result1);

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
        Vector256<uint> YShuffleG4X2(Vector256<uint> source0, Vector256<uint> source1, ShuffleControlG4 control, out Vector256<uint> result1);

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
        Vector256<long> YShuffleG4X2(Vector256<long> source0, Vector256<long> source1, ShuffleControlG4 control, out Vector256<long> result1);

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
        Vector256<ulong> YShuffleG4X2(Vector256<ulong> source0, Vector256<ulong> source1, ShuffleControlG4 control, out Vector256<ulong> result1);

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
        Vector256<float> YShuffleG4X2_Const(Vector256<float> source0, Vector256<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<float> result1);

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
        Vector256<double> YShuffleG4X2_Const(Vector256<double> source0, Vector256<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<double> result1);

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
        Vector256<sbyte> YShuffleG4X2_Const(Vector256<sbyte> source0, Vector256<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<sbyte> result1);

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
        Vector256<byte> YShuffleG4X2_Const(Vector256<byte> source0, Vector256<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<byte> result1);

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
        Vector256<short> YShuffleG4X2_Const(Vector256<short> source0, Vector256<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<short> result1);

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
        Vector256<ushort> YShuffleG4X2_Const(Vector256<ushort> source0, Vector256<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<ushort> result1);

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
        Vector256<int> YShuffleG4X2_Const(Vector256<int> source0, Vector256<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<int> result1);

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
        Vector256<uint> YShuffleG4X2_Const(Vector256<uint> source0, Vector256<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<uint> result1);

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
        Vector256<long> YShuffleG4X2_Const(Vector256<long> source0, Vector256<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<long> result1);

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
        Vector256<ulong> YShuffleG4X2_Const(Vector256<ulong> source0, Vector256<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<ulong> result1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleInsert</c> (运行 <c>YShuffleInsert</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="Shuffle(Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleKernel(Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>Combine by <see cref="Avx512Vbmi.VL.PermuteVar32x8(Vector256{byte}, Vector256{byte})">VPERMB(_mm256_permutevar32x8_epi8)</see></description>
        ///        <description>Combine by <see cref="Avx512BW.VL.PermuteVar16x16(Vector256{ushort}, Vector256{ushort})">VPERMW(_mm256_permutevar16x16_epi16)</see></description>
        ///        <description>Combine by <see cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})">VPERMD(_mm256_permutevar8x32_epi32)</see>
        ///        /<see cref="Avx2.PermuteVar8x32(Vector256{float}, Vector256{int})">VPERMPS(_mm256_permutevar8x32_ps)</see></description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar4x64(Vector256{ulong}, Vector256{ulong})">VPERMQ(_mm256_permute4x64_pd)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar4x64(Vector256{double}, Vector256{long})">VPERMPD(_mm256_permute4x64_pd)</see></description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
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
        /// <seealso cref="Vector256.Shuffle(Vector256{float}, Vector256{int})"/>
        Vector256<float> YShuffleInsert(Vector256<float> back, Vector256<float> vector, Vector256<int> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{double}, Vector256{long})"/>
        Vector256<double> YShuffleInsert(Vector256<double> back, Vector256<double> vector, Vector256<long> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleInsert(Vector256<sbyte> back, Vector256<sbyte> vector, Vector256<sbyte> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        Vector256<byte> YShuffleInsert(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{short}, Vector256{short})"/>
        Vector256<short> YShuffleInsert(Vector256<short> back, Vector256<short> vector, Vector256<short> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
        Vector256<ushort> YShuffleInsert(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{int}, Vector256{int})"/>
        Vector256<int> YShuffleInsert(Vector256<int> back, Vector256<int> vector, Vector256<int> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{uint}, Vector256{uint})"/>
        Vector256<uint> YShuffleInsert(Vector256<uint> back, Vector256<uint> vector, Vector256<uint> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{long}, Vector256{long})"/>
        Vector256<long> YShuffleInsert(Vector256<long> back, Vector256<long> vector, Vector256<long> indices);

        /// <summary>
        /// Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{ulong}, Vector256{ulong})"/>
        Vector256<ulong> YShuffleInsert(Vector256<ulong> back, Vector256<ulong> vector, Vector256<ulong> indices);


        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleInsert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleInsert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleInsert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleInsert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleInsert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleInsert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleInsert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2);

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <seealso cref="YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="YShuffleInsert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        void YShuffleInsert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2);


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
        /// <seealso cref="YShuffleInsert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<float> YShuffleInsert_Core(Vector256<float> back, Vector256<float> vector, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<double> YShuffleInsert_Core(Vector256<double> back, Vector256<double> vector, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleInsert_Core(Vector256<sbyte> back, Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        Vector256<byte> YShuffleInsert_Core(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        Vector256<short> YShuffleInsert_Core(Vector256<short> back, Vector256<short> vector, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        Vector256<ushort> YShuffleInsert_Core(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<int> YShuffleInsert_Core(Vector256<int> back, Vector256<int> vector, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        Vector256<uint> YShuffleInsert_Core(Vector256<uint> back, Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<long> YShuffleInsert_Core(Vector256<long> back, Vector256<long> vector, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2);

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
        /// <seealso cref="YShuffleInsert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        Vector256<ulong> YShuffleInsert_Core(Vector256<ulong> back, Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleKernel</c> (运行 <c>Shuffle</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="Shuffle(Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleKernel(Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description><see cref="Avx512Vbmi.VL.PermuteVar32x8(Vector256{byte}, Vector256{byte})">VPERMB(_mm256_permutevar32x8_epi8)</see></description>
        ///        <description><see cref="Avx512BW.VL.PermuteVar16x16(Vector256{ushort}, Vector256{ushort})">VPERMW(_mm256_permutevar16x16_epi16)</see></description>
        ///        <description><see cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})">VPERMD(_mm256_permutevar8x32_epi32)</see>
        ///        /<see cref="Avx2.PermuteVar8x32(Vector256{float}, Vector256{int})">VPERMPS(_mm256_permutevar8x32_ps)</see></description>
        ///        <description><see cref="Avx512F.VL.PermuteVar4x64(Vector256{ulong}, Vector256{ulong})">VPERMQ(_mm256_permute4x64_pd)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar4x64(Vector256{double}, Vector256{long})">VPERMPD(_mm256_permute4x64_pd)</see></description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="YShuffleKernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        TypeCodeFlags YShuffleKernel_AcceleratedTypes { get; }

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{float}, Vector256{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{float}, Vector256{int})"/>
        Vector256<float> YShuffleKernel(Vector256<float> vector, Vector256<int> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{double}, Vector256{long})"/>
        Vector256<double> YShuffleKernel(Vector256<double> vector, Vector256<long> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleKernel(Vector256<sbyte> vector, Vector256<sbyte> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{byte}, Vector256{byte})"/>
        Vector256<byte> YShuffleKernel(Vector256<byte> vector, Vector256<byte> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{short}, Vector256{short})"/>
        Vector256<short> YShuffleKernel(Vector256<short> vector, Vector256<short> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
        Vector256<ushort> YShuffleKernel(Vector256<ushort> vector, Vector256<ushort> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{int}, Vector256{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{int}, Vector256{int})"/>
        Vector256<int> YShuffleKernel(Vector256<int> vector, Vector256<int> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{uint}, Vector256{uint})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})"/>
        Vector256<uint> YShuffleKernel(Vector256<uint> vector, Vector256<uint> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{long}, Vector256{long})"/>
        Vector256<long> YShuffleKernel(Vector256<long> vector, Vector256<long> indices);

        /// <summary>
        /// Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{ulong}, Vector256{ulong})"/>
        Vector256<ulong> YShuffleKernel(Vector256<ulong> vector, Vector256<ulong> indices);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleKernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleKernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleKernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleKernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleKernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleKernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleKernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        void YShuffleKernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{float}, Vector256{int})"/>
        Vector256<float> YShuffleKernel_Core(Vector256<float> vector, Vector256<int> args0, Vector256<int> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<double> YShuffleKernel_Core(Vector256<double> vector, Vector256<long> args0, Vector256<long> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleKernel_Core(Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{byte}, Vector256{byte})"/>
        Vector256<byte> YShuffleKernel_Core(Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        Vector256<short> YShuffleKernel_Core(Vector256<short> vector, Vector256<short> args0, Vector256<short> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        Vector256<ushort> YShuffleKernel_Core(Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{int}, Vector256{int})"/>
        Vector256<int> YShuffleKernel_Core(Vector256<int> vector, Vector256<int> args0, Vector256<int> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})"/>
        Vector256<uint> YShuffleKernel_Core(Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<long> YShuffleKernel_Core(Vector256<long> vector, Vector256<long> args0, Vector256<long> args1);

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from YShuffleKernel_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        Vector256<ulong> YShuffleKernel_Core(Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX2</c> (运行 <c>YShuffleX2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的参数计算). Provide arguments for YShuffleX2_Core (为 YShuffleX2_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的核心计算). Its arguments are derived from YShuffleX2_Args (其参数来源于 YShuffleX2_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX2(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX2Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX2Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description>Combine by <see cref="Avx512Vbmi.VL.PermuteVar32x8x2(Vector256{byte}, Vector256{byte}, Vector256{byte})">VPERMI2B(_mm256_permutex2var_epi8)</see></description>
        ///        <description>Combine by <see cref="Avx512BW.VL.PermuteVar16x16x2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})">VPERMI2W(_mm256_permutex2var_epi16)</see></description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar8x32x2(Vector256{uint}, Vector256{uint}, Vector256{uint})">VPERMI2D(_mm256_permutex2var_epi32)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar8x32x2(Vector256{float}, Vector256{int}, Vector256{float})">VPERMI2PS(_mm256_permutex2var_ps)</see></description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar4x64x2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})">VPERMI2Q(_mm256_permutex2var_epi64)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar4x64x2(Vector256{double}, Vector256{long}, Vector256{double})">VPERMI2PD(_mm256_permutex2var_pd)</see></description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX2(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="YShuffleX2_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
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
        Vector256<float> YShuffleX2(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<double> YShuffleX2(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<sbyte> YShuffleX2(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices);

        /// <inheritdoc cref="YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<byte> YShuffleX2(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices);

        /// <inheritdoc cref="YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<short> YShuffleX2(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices);

        /// <inheritdoc cref="YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ushort> YShuffleX2(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices);

        /// <inheritdoc cref="YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<int> YShuffleX2(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<uint> YShuffleX2(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices);

        /// <inheritdoc cref="YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<long> YShuffleX2(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ulong> YShuffleX2(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices);

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
        /// <seealso cref="YShuffleX2_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleX2_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleX2_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleX2_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleX2_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleX2_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleX2_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleX2_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        void YShuffleX2_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4);

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
        /// <seealso cref="YShuffleX2_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<float> YShuffleX2_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<double> YShuffleX2_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleX2_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        Vector256<byte> YShuffleX2_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        Vector256<short> YShuffleX2_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        Vector256<ushort> YShuffleX2_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<int> YShuffleX2_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        Vector256<uint> YShuffleX2_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<long> YShuffleX2_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        Vector256<ulong> YShuffleX2_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX2Insert</c> (运行 <c>YShuffleX2Insert</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的参数计算). Provide arguments for YShuffleX2Insert_Core (为 YShuffleX2Insert_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 2 vectors (在2个向量上进行换位的核心计算). Its arguments are derived from YShuffleX2Insert_Args (其参数来源于 YShuffleX2Insert_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX2(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX2Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX2Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description>Combine by <see cref="Avx512Vbmi.VL.PermuteVar32x8x2(Vector256{byte}, Vector256{byte}, Vector256{byte})">VPERMI2B(_mm256_permutex2var_epi8)</see></description>
        ///        <description>Combine by <see cref="Avx512BW.VL.PermuteVar16x16x2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})">VPERMI2W(_mm256_permutex2var_epi16)</see></description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar8x32x2(Vector256{uint}, Vector256{uint}, Vector256{uint})">VPERMI2D(_mm256_permutex2var_epi32)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar8x32x2(Vector256{float}, Vector256{int}, Vector256{float})">VPERMI2PS(_mm256_permutex2var_ps)</see></description>
        ///        <description>Combine by <see cref="Avx512F.VL.PermuteVar4x64x2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})">VPERMI2Q(_mm256_permutex2var_epi64)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar4x64x2(Vector256{double}, Vector256{long}, Vector256{double})">VPERMI2PD(_mm256_permutex2var_pd)</see></description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX2Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
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
        Vector256<float> YShuffleX2Insert(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<double> YShuffleX2Insert(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<sbyte> YShuffleX2Insert(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<byte> YShuffleX2Insert(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<short> YShuffleX2Insert(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ushort> YShuffleX2Insert(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<int> YShuffleX2Insert(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<uint> YShuffleX2Insert(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<long> YShuffleX2Insert(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ulong> YShuffleX2Insert(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices);

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
        /// <seealso cref="YShuffleX2Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleX2Insert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleX2Insert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleX2Insert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleX2Insert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleX2Insert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleX2Insert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleX2Insert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        void YShuffleX2Insert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4);

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
        /// <seealso cref="YShuffleX2Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<float> YShuffleX2Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<double> YShuffleX2Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleX2Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        Vector256<byte> YShuffleX2Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        Vector256<short> YShuffleX2Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        Vector256<ushort> YShuffleX2Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<int> YShuffleX2Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        Vector256<uint> YShuffleX2Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<long> YShuffleX2Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        Vector256<ulong> YShuffleX2Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX2Kernel</c> (运行 <c>YShuffleX2Kernel</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle on 2 vectors 在2个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX2Kernel_Args (其参数来源于 YShuffleX2Kernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX2(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX2Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX2Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        ///        <description><see cref="Avx512Vbmi.VL.PermuteVar32x8x2(Vector256{byte}, Vector256{byte}, Vector256{byte})">VPERMI2B(_mm256_permutex2var_epi8)</see></description>
        ///        <description><see cref="Avx512BW.VL.PermuteVar16x16x2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})">VPERMI2W(_mm256_permutex2var_epi16)</see></description>
        ///        <description><see cref="Avx512F.VL.PermuteVar8x32x2(Vector256{uint}, Vector256{uint}, Vector256{uint})">VPERMI2D(_mm256_permutex2var_epi32)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar8x32x2(Vector256{float}, Vector256{int}, Vector256{float})">VPERMI2PS(_mm256_permutex2var_ps)</see></description>
        ///        <description><see cref="Avx512F.VL.PermuteVar4x64x2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})">VPERMI2Q(_mm256_permutex2var_epi64)</see>
        ///        /<see cref="Avx512F.VL.PermuteVar4x64x2(Vector256{double}, Vector256{long}, Vector256{double})">VPERMI2PD(_mm256_permutex2var_pd)</see></description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="YShuffleX2Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        /// 
        TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes { get; }

        /// <summary>
        /// Only shuffle on 2 vectors (在2个向量上进行仅换位). Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector256s{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vector256s{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX2Kernel_AcceleratedTypes"/>
        Vector256<float> YShuffleX2Kernel(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<double> YShuffleX2Kernel(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<sbyte> YShuffleX2Kernel(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<byte> YShuffleX2Kernel(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<short> YShuffleX2Kernel(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ushort> YShuffleX2Kernel(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<int> YShuffleX2Kernel(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<uint> YShuffleX2Kernel(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<long> YShuffleX2Kernel(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ulong> YShuffleX2Kernel(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices);

        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector256s{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vector256s{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX2Kernel_Core .</param>
        /// <seealso cref="YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleX2Kernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleX2Kernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleX2Kernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleX2Kernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleX2Kernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleX2Kernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleX2Kernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX2Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        void YShuffleX2Kernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3);

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
        /// <seealso cref="YShuffleX2Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<float> YShuffleX2Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<double> YShuffleX2Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleX2Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        Vector256<byte> YShuffleX2Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        Vector256<short> YShuffleX2Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        Vector256<ushort> YShuffleX2Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<int> YShuffleX2Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        Vector256<uint> YShuffleX2Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<long> YShuffleX2Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3);

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX2Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        Vector256<ulong> YShuffleX2Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX3</c> (运行 <c>YShuffleX3</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的参数计算). Provide arguments for YShuffleX3_Core (为 YShuffleX3_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的核心计算). Its arguments are derived from YShuffleX3_Args (其参数来源于 YShuffleX3_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX3(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX3Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX3Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        /// <seealso cref="YShuffleX3(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="YShuffleX3_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
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
        Vector256<float> YShuffleX3(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX3(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<double> YShuffleX3(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX3(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<sbyte> YShuffleX3(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> indices);

        /// <inheritdoc cref="YShuffleX3(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<byte> YShuffleX3(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> indices);

        /// <inheritdoc cref="YShuffleX3(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<short> YShuffleX3(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> indices);

        /// <inheritdoc cref="YShuffleX3(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ushort> YShuffleX3(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> indices);

        /// <inheritdoc cref="YShuffleX3(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<int> YShuffleX3(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX3(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<uint> YShuffleX3(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> indices);

        /// <inheritdoc cref="YShuffleX3(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<long> YShuffleX3(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX3(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ulong> YShuffleX3(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> indices);

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
        /// <seealso cref="YShuffleX3_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleX3_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleX3_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleX3_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleX3_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleX3_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleX3_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleX3_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        void YShuffleX3_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4);

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
        /// <seealso cref="YShuffleX3_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<float> YShuffleX3_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<double> YShuffleX3_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleX3_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        Vector256<byte> YShuffleX3_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        Vector256<short> YShuffleX3_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        Vector256<ushort> YShuffleX3_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<int> YShuffleX3_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        Vector256<uint> YShuffleX3_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<long> YShuffleX3_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        Vector256<ulong> YShuffleX3_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX3Insert</c> (运行 <c>YShuffleX3Insert</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的参数计算). Provide arguments for YShuffleX3Insert_Core (为 YShuffleX3Insert_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 3 vectors (在3个向量上进行换位的核心计算). Its arguments are derived from YShuffleX3Insert_Args (其参数来源于 YShuffleX3Insert_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX3(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX3Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX3Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        /// <seealso cref="YShuffleX3Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
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
        Vector256<float> YShuffleX3Insert(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<double> YShuffleX3Insert(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<sbyte> YShuffleX3Insert(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<byte> YShuffleX3Insert(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<short> YShuffleX3Insert(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ushort> YShuffleX3Insert(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<int> YShuffleX3Insert(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<uint> YShuffleX3Insert(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<long> YShuffleX3Insert(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX3Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ulong> YShuffleX3Insert(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> indices);

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
        /// <seealso cref="YShuffleX3Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleX3Insert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleX3Insert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleX3Insert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleX3Insert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleX3Insert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleX3Insert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleX3Insert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        void YShuffleX3Insert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4);

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
        /// <seealso cref="YShuffleX3Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<float> YShuffleX3Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<double> YShuffleX3Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleX3Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        Vector256<byte> YShuffleX3Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        Vector256<short> YShuffleX3Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        Vector256<ushort> YShuffleX3Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<int> YShuffleX3Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        Vector256<uint> YShuffleX3Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<long> YShuffleX3Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        Vector256<ulong> YShuffleX3Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX3Kernel</c> (运行 <c>YShuffleX3Kernel</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle on 3 vectors (在3个向量上进行仅换位的参数计算). Provide arguments for YShuffleX3Kernel_Core (为 YShuffleX3Kernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle on 3 vectors 在3个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX3Kernel_Args (其参数来源于 YShuffleX3Kernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX3(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX3Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX3Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        /// <seealso cref="YShuffleX3Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
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
        Vector256<float> YShuffleX3Kernel(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<double> YShuffleX3Kernel(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<sbyte> YShuffleX3Kernel(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<byte> YShuffleX3Kernel(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<short> YShuffleX3Kernel(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ushort> YShuffleX3Kernel(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<int> YShuffleX3Kernel(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<uint> YShuffleX3Kernel(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<long> YShuffleX3Kernel(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ulong> YShuffleX3Kernel(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> indices);

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
        /// <seealso cref="YShuffleX3Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleX3Kernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleX3Kernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleX3Kernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleX3Kernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleX3Kernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleX3Kernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleX3Kernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX3Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        void YShuffleX3Kernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3);

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
        /// <seealso cref="YShuffleX3Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<float> YShuffleX3Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<double> YShuffleX3Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleX3Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        Vector256<byte> YShuffleX3Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        Vector256<short> YShuffleX3Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        Vector256<ushort> YShuffleX3Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<int> YShuffleX3Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        Vector256<uint> YShuffleX3Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<long> YShuffleX3Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3);

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX3Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        Vector256<ulong> YShuffleX3Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX4</c> (运行 <c>YShuffleX4</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的参数计算). Provide arguments for YShuffleX4_Core (为 YShuffleX4_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的核心计算). Its arguments are derived from YShuffleX4_Args (其参数来源于 YShuffleX4_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX4(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX4Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX4Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        /// <seealso cref="YShuffleX4(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="YShuffleX4_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
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
        Vector256<float> YShuffleX4(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX4(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<double> YShuffleX4(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX4(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<sbyte> YShuffleX4(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> indices);

        /// <inheritdoc cref="YShuffleX4(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<byte> YShuffleX4(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> indices);

        /// <inheritdoc cref="YShuffleX4(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<short> YShuffleX4(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> indices);

        /// <inheritdoc cref="YShuffleX4(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ushort> YShuffleX4(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> indices);

        /// <inheritdoc cref="YShuffleX4(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<int> YShuffleX4(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX4(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<uint> YShuffleX4(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> indices);

        /// <inheritdoc cref="YShuffleX4(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<long> YShuffleX4(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX4(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ulong> YShuffleX4(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> indices);

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
        /// <seealso cref="YShuffleX4_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleX4_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleX4_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleX4_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleX4_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleX4_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleX4_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleX4_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        void YShuffleX4_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4);

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
        /// <seealso cref="YShuffleX4_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<float> YShuffleX4_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<double> YShuffleX4_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleX4_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        Vector256<byte> YShuffleX4_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        Vector256<short> YShuffleX4_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        Vector256<ushort> YShuffleX4_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<int> YShuffleX4_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        Vector256<uint> YShuffleX4_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<long> YShuffleX4_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        Vector256<ulong> YShuffleX4_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX4Insert</c> (运行 <c>YShuffleX4Insert</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的参数计算). Provide arguments for YShuffleX4Insert_Core (为 YShuffleX4Insert_Core 提供参数).</para>
        /// <para>- Core. Core calculation for shuffle and clear on 4 vectors (在4个向量上进行换位的核心计算). Its arguments are derived from YShuffleX4Insert_Args (其参数来源于 YShuffleX4Insert_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX4(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX4Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX4Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        /// <seealso cref="YShuffleX4Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
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
        Vector256<float> YShuffleX4Insert(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<double> YShuffleX4Insert(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<sbyte> YShuffleX4Insert(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<byte> YShuffleX4Insert(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<short> YShuffleX4Insert(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ushort> YShuffleX4Insert(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<int> YShuffleX4Insert(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<uint> YShuffleX4Insert(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<long> YShuffleX4Insert(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX4Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ulong> YShuffleX4Insert(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> indices);

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
        /// <seealso cref="YShuffleX4Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleX4Insert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleX4Insert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleX4Insert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleX4Insert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleX4Insert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleX4Insert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleX4Insert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        void YShuffleX4Insert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4);

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
        /// <seealso cref="YShuffleX4Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<float> YShuffleX4Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<double> YShuffleX4Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleX4Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        Vector256<byte> YShuffleX4Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        Vector256<short> YShuffleX4Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        Vector256<ushort> YShuffleX4Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<int> YShuffleX4Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        Vector256<uint> YShuffleX4Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<long> YShuffleX4Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4);

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        Vector256<ulong> YShuffleX4Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleX4Kernel</c> (运行 <c>YShuffleX4Kernel</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle on 4 vectors 在4个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX4Kernel_Args (其参数来源于 YShuffleX4Kernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleX4(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleX4Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleX4Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
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
        /// <seealso cref="YShuffleX4Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        /// 
        TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes { get; }

        /// <summary>
        /// Only shuffle on 4 vectors (在4个向量上进行仅换位). Creates a new vector by selecting values from an input vectors using a set of indices (通过使用一组索引从输入向量集中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector256s{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vector256s{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从输入向量集中选择的值).</returns>
        /// <seealso cref="YShuffleX4Kernel_AcceleratedTypes"/>
        Vector256<float> YShuffleX4Kernel(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<double> YShuffleX4Kernel(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<sbyte> YShuffleX4Kernel(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<byte> YShuffleX4Kernel(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<short> YShuffleX4Kernel(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ushort> YShuffleX4Kernel(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<int> YShuffleX4Kernel(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<uint> YShuffleX4Kernel(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<long> YShuffleX4Kernel(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> indices);

        /// <inheritdoc cref="YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        Vector256<ulong> YShuffleX4Kernel(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> indices);

        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector256s{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vector256s{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX4Kernel_Core .</param>
        /// <seealso cref="YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleX4Kernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleX4Kernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleX4Kernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleX4Kernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleX4Kernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleX4Kernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleX4Kernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        /// <seealso cref="YShuffleX4Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        void YShuffleX4Kernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3);

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
        /// <seealso cref="YShuffleX4Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<float> YShuffleX4Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<double> YShuffleX4Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        Vector256<sbyte> YShuffleX4Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        Vector256<byte> YShuffleX4Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        Vector256<short> YShuffleX4Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        Vector256<ushort> YShuffleX4Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        Vector256<int> YShuffleX4Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        Vector256<uint> YShuffleX4Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        Vector256<long> YShuffleX4Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3);

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        /// <seealso cref="YShuffleX4Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        Vector256<ulong> YShuffleX4Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3);


        /// <summary>
        /// Types with hardware acceleration when running <c>YSign</c> (运行 <c>YSign</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YSign(Vector256{float})"/>
        TypeCodeFlags YSign_AcceleratedTypes { get; }

        /// <summary>
        /// Determine the sign of each element (判断各个元素的符号).
        /// Mnemonic: <c>rt[i] := sign(value[i])</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements depend on the sign of the corresponding element of <paramref name="value" />:  Returns 1 if the value is positive, 0 if the value is zero, and -1 if the value is negative (一个向量，其元素取决于value的对应元素的符号情况: 值为正数时返回1, 值为0时返回0, 值为负数时返回-1).</returns>
        /// <seealso cref="YSign_AcceleratedTypes"/>
        /// <seealso cref="MathINumber.Sign(float)"/>
        Vector256<int> YSign(Vector256<float> value);

        /// <inheritdoc cref="YSign(Vector256{float})"/>
        /// <seealso cref="MathINumber.Sign(double)"/>
        Vector256<long> YSign(Vector256<double> value);

        /// <inheritdoc cref="YSign(Vector256{float})"/>
        /// <seealso cref="MathINumber.Sign(sbyte)"/>
        Vector256<sbyte> YSign(Vector256<sbyte> value);

        /// <inheritdoc cref="YSign(Vector256{float})"/>
        /// <seealso cref="MathINumber.Sign(short)"/>
        Vector256<short> YSign(Vector256<short> value);

        /// <inheritdoc cref="YSign(Vector256{float})"/>
        /// <seealso cref="MathINumber.Sign(int)"/>
        Vector256<int> YSign(Vector256<int> value);

        /// <inheritdoc cref="YSign(Vector256{float})"/>
        /// <seealso cref="MathINumber.Sign(long)"/>
        Vector256<long> YSign(Vector256<long> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>YSignFloat</c> (运行 <c>YSignFloat</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YSignFloat(Vector256{float})"/>
        TypeCodeFlags YSignFloat_AcceleratedTypes { get; }

        /// <summary>
        /// Determine the sign of each element and returns a floating point number (判断各个元素的符号并返回浮点数).
        /// Mnemonic: <c>rt[i] := signFloat(value[i])</c>.
        /// </summary>
        /// <param name="value">The vectors that will be checked (将进行检查的向量).</param>
        /// <returns>A vector whose elements depend on the sign of the corresponding element of <paramref name="value" />: Returns 1 if the value is positive, 0 if the value is zero, -1 if the value is negative, and <c>NaN</c> if the value is <c>NaN</c> (一个向量，其元素取决于value的对应元素的符号情况: 值为正数时返回1, 值为0时返回0, 值为负数时返回-1, 值为<c>NaN</c>时返回<c>NaN</c>).</returns>
        /// <seealso cref="YSignFloat_AcceleratedTypes"/>
        /// <seealso cref="MathINumber.Sign(float)"/>
        Vector256<float> YSignFloat(Vector256<float> value);

        /// <inheritdoc cref="YSignFloat(Vector256{float})"/>
        /// <seealso cref="MathINumber.Sign(double)"/>
        Vector256<double> YSignFloat(Vector256<double> value);

#endif
    }
}
