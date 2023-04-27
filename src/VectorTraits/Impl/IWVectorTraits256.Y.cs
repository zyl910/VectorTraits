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
using System.Text;

namespace Zyl.VectorTraits.Impl {
    partial interface IWVectorTraits256 {
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
        /// Types with hardware acceleration when running <c>YShuffleG2</c> (运行 <c>YShuffleG2</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Const. Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use <see cref="YShuffleG4X2"/> instead (如果向量的元素数量小于4，请使用 <see cref="YShuffleG4X2"/> 代替).</para>
        /// <para>- <see cref="YShuffleG4X2"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2"/>
        /// <seealso cref="YShuffleG4"/>
        /// <seealso cref="YShuffleG4X2"/>
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


        /// <summary>
        /// Types with hardware acceleration when running <c>YShuffleG4</c> (运行 <c>YShuffleG4</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Const. Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use <see cref="YShuffleG4X2"/> instead (如果向量的元素数量小于4，请使用 <see cref="YShuffleG4X2"/> 代替).</para>
        /// <para>- <see cref="YShuffleG4X2"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2"/>
        /// <seealso cref="YShuffleG4"/>
        /// <seealso cref="YShuffleG4X2"/>
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
        /// <para>- Const. Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="YShuffleG2"/>: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).</para>
        /// <para>- <see cref="YShuffleG4"/>: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use <see cref="YShuffleG4X2"/> instead (如果向量的元素数量小于4，请使用 <see cref="YShuffleG4X2"/> 代替).</para>
        /// <para>- <see cref="YShuffleG4X2"/>: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).</para>
        /// </remarks>
        /// <seealso cref="YShuffleG2"/>
        /// <seealso cref="YShuffleG4"/>
        /// <seealso cref="YShuffleG4X2"/>
        TypeCodeFlags YShuffleG4X2_AcceleratedTypes { get; }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<float> Result0, Vector256<float> Result1) YShuffleG4X2(Vector256<float> source0, Vector256<float> source1, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<double> Result0, Vector256<double> Result1) YShuffleG4X2(Vector256<double> source0, Vector256<double> source1, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<sbyte> Result0, Vector256<sbyte> Result1) YShuffleG4X2(Vector256<sbyte> source0, Vector256<sbyte> source1, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<byte> Result0, Vector256<byte> Result1) YShuffleG4X2(Vector256<byte> source0, Vector256<byte> source1, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<short> Result0, Vector256<short> Result1) YShuffleG4X2(Vector256<short> source0, Vector256<short> source1, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<ushort> Result0, Vector256<ushort> Result1) YShuffleG4X2(Vector256<ushort> source0, Vector256<ushort> source1, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<int> Result0, Vector256<int> Result1) YShuffleG4X2(Vector256<int> source0, Vector256<int> source1, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<uint> Result0, Vector256<uint> Result1) YShuffleG4X2(Vector256<uint> source0, Vector256<uint> source1, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<long> Result0, Vector256<long> Result1) YShuffleG4X2(Vector256<long> source0, Vector256<long> source1, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<ulong> Result0, Vector256<ulong> Result1) YShuffleG4X2(Vector256<ulong> source0, Vector256<ulong> source1, ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<float> Result0, Vector256<float> Result1) YShuffleG4X2_Const(Vector256<float> source0, Vector256<float> source1, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<double> Result0, Vector256<double> Result1) YShuffleG4X2_Const(Vector256<double> source0, Vector256<double> source1, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<sbyte> Result0, Vector256<sbyte> Result1) YShuffleG4X2_Const(Vector256<sbyte> source0, Vector256<sbyte> source1, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<byte> Result0, Vector256<byte> Result1) YShuffleG4X2_Const(Vector256<byte> source0, Vector256<byte> source1, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<short> Result0, Vector256<short> Result1) YShuffleG4X2_Const(Vector256<short> source0, Vector256<short> source1, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<ushort> Result0, Vector256<ushort> Result1) YShuffleG4X2_Const(Vector256<ushort> source0, Vector256<ushort> source1, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<int> Result0, Vector256<int> Result1) YShuffleG4X2_Const(Vector256<int> source0, Vector256<int> source1, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<uint> Result0, Vector256<uint> Result1) YShuffleG4X2_Const(Vector256<uint> source0, Vector256<uint> source1, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<long> Result0, Vector256<long> Result1) YShuffleG4X2_Const(Vector256<long> source0, Vector256<long> source1, [ConstantExpected] ShuffleControlG4 control);

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        (Vector256<ulong> Result0, Vector256<ulong> Result1) YShuffleG4X2_Const(Vector256<ulong> source0, Vector256<ulong> source1, [ConstantExpected] ShuffleControlG4 control);


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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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
        /// <seealso cref="YShuffleInsert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{int})"/>
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
        /// <seealso cref="YShuffleInsert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{int})"/>
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
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        void YShuffleKernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        void YShuffleKernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
        void YShuffleKernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        void YShuffleKernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
        void YShuffleKernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        void YShuffleKernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <seealso cref="YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="YShuffleKernel_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
        void YShuffleKernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1);

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
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

#endif
    }
}
