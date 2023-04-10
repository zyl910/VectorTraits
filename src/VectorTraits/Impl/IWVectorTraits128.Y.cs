using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    partial interface IWVectorTraits128 {
#if NETCOREAPP3_0_OR_GREATER

        // == mY style  ==

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
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector128<sbyte> YNarrowSaturate(Vector128<short> lower, Vector128<short> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector128<byte> YNarrowSaturate(Vector128<ushort> lower, Vector128<ushort> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector128<short> YNarrowSaturate(Vector128<int> lower, Vector128<int> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector128<ushort> YNarrowSaturate(Vector128<uint> lower, Vector128<uint> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector128<int> YNarrowSaturate(Vector128<long> lower, Vector128<long> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector128<uint> YNarrowSaturate(Vector128<ulong> lower, Vector128<ulong> upper);


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
        /// Saturate narrows two signed <seealso cref="Vector128{T}"/> instances into one unsigned <seealso cref="Vector128{T}"/>"  (将两个有符号 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        Vector128<byte> YNarrowSaturateUnsigned(Vector128<short> lower, Vector128<short> upper);

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector128{T}"/> instances into one unsigned <seealso cref="Vector128{T}"/>"  (将两个有符号 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        Vector128<ushort> YNarrowSaturateUnsigned(Vector128<int> lower, Vector128<int> upper);

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector128{T}"/> instances into one unsigned <seealso cref="Vector128{T}"/>"  (将两个有符号 <seealso cref="Vector128{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        Vector128<uint> YNarrowSaturateUnsigned(Vector128<long> lower, Vector128<long> upper);


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleInsert</c> (运行 <c>YShuffleInsert</c> 时具有硬件加速的类型).
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
        /// <seealso cref="YShuffleInsert"/>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <seealso cref="YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{int})"/>
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
        /// <seealso cref="YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{int})"/>
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
        /// <para>- <see cref="Shuffle"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleInsert"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleKernel"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
        /// </remarks>
        /// <seealso cref="YShuffleKernel"/>
        /// <seealso cref="YShuffleKernel_Args"/>
        /// <seealso cref="YShuffleKernel_Core"/>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void YShuffleKernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void YShuffleKernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        void YShuffleKernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void YShuffleKernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        void YShuffleKernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void YShuffleKernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        void YShuffleKernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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

#endif
    }
}
