using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Impl;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;
#if ALLOW_VECTOR_TUPLES
using Zyl.VectorTraits.Tuples;
#endif // ALLOW_VECTOR_TUPLES

namespace Zyl.VectorTraits {
    static partial class Vector512s {

#if NET8_0_OR_GREATER

        /// <summary>
        /// Compares two vectors to determine which is unsigned greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个是无符号更大).
        /// Mnemonic: <c>rt[i] := (T)to_mask(asUnsigned(left[i]) &gt; asUnsigned(right[i]))</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector512.GreaterThan{T}(Vector512{T}, Vector512{T})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> GreaterThan_Unsigned(Vector512<sbyte> left, Vector512<sbyte> right) {
            return GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector512{sbyte}, Vector512{sbyte})"/>
        public static Vector512<byte> GreaterThan_Unsigned(Vector512<byte> left, Vector512<byte> right) {
            return GreaterThan(left, right);
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector512{sbyte}, Vector512{sbyte})"/>
        public static Vector512<short> GreaterThan_Unsigned(Vector512<short> left, Vector512<short> right) {
            return GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        public static Vector512<ushort> GreaterThan_Unsigned(Vector512<ushort> left, Vector512<ushort> right) {
            return GreaterThan(left, right);
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector512{sbyte}, Vector512{sbyte})"/>
        public static Vector512<int> GreaterThan_Unsigned(Vector512<int> left, Vector512<int> right) {
            return GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        public static Vector512<uint> GreaterThan_Unsigned(Vector512<uint> left, Vector512<uint> right) {
            return GreaterThan(left, right);
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector512{sbyte}, Vector512{sbyte})"/>
        public static Vector512<long> GreaterThan_Unsigned(Vector512<long> left, Vector512<long> right) {
            return GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        public static Vector512<ulong> GreaterThan_Unsigned(Vector512<ulong> left, Vector512<ulong> right) {
            return GreaterThan(left, right);
        }


        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances - Generic version (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TOut">The element type of the output parameter (输出参数的元素类型).</typeparam>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TOut"/>) are not supported.</exception>
        /// <seealso cref="Vector512.Widen(Vector512{float})" />
        /// <seealso cref="IWVectorTraits512.Widen(Vector512{float}, out Vector512{double}, out Vector512{double})" />
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Widen<T, TOut>(Vector512<T> source, out Vector512<TOut> lower, out Vector512<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector512<double> a, Vector512<double> b) = Widen(source.As<T, float>());
                lower = a.As<double, TOut>();
                upper = b.As<double, TOut>();
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector512<short> a, Vector512<short> b) = Widen(source.As<T, sbyte>());
                lower = a.As<short, TOut>();
                upper = b.As<short, TOut>();
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector512<ushort> a, Vector512<ushort> b) = Widen(source.As<T, byte>());
                lower = a.As<ushort, TOut>();
                upper = b.As<ushort, TOut>();
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector512<int> a, Vector512<int> b) = Widen(source.As<T, short>());
                lower = a.As<int, TOut>();
                upper = b.As<int, TOut>();
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector512<uint> a, Vector512<uint> b) = Widen(source.As<T, ushort>());
                lower = a.As<uint, TOut>();
                upper = b.As<uint, TOut>();
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector512<long> a, Vector512<long> b) = Widen(source.As<T, int>());
                lower = a.As<long, TOut>();
                upper = b.As<long, TOut>();
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector512<ulong> a, Vector512<ulong> b) = Widen(source.As<T, uint>());
                lower = a.As<ulong, TOut>();
                upper = b.As<ulong, TOut>();
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances - Generic version (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector512.Widen(Vector512{float})" />
        /// <seealso cref="IWVectorTraits512.Widen(Vector512{float}, out Vector512{double}, out Vector512{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Lower, Vector512<double> Upper) Widen(Vector512<float> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances - Generic version (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector512.Widen(Vector512{sbyte})" />
        /// <seealso cref="IWVectorTraits512.Widen(Vector512{sbyte}, out Vector512{short}, out Vector512{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Lower, Vector512<short> Upper) Widen(Vector512<sbyte> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances - Generic version (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector512.Widen(Vector512{byte})" />
        /// <seealso cref="IWVectorTraits512.Widen(Vector512{byte}, out Vector512{ushort}, out Vector512{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Lower, Vector512<ushort> Upper) Widen(Vector512<byte> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances - Generic version (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector512.Widen(Vector512{short})" />
        /// <seealso cref="IWVectorTraits512.Widen(Vector512{short}, out Vector512{int}, out Vector512{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Lower, Vector512<int> Upper) Widen(Vector512<short> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances - Generic version (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector512.Widen(Vector512{ushort})" />
        /// <seealso cref="IWVectorTraits512.Widen(Vector512{ushort}, out Vector512{uint}, out Vector512{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Lower, Vector512<uint> Upper) Widen(Vector512<ushort> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances - Generic version (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector512.Widen(Vector512{int})" />
        /// <seealso cref="IWVectorTraits512.Widen(Vector512{int}, out Vector512{long}, out Vector512{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Lower, Vector512<long> Upper) Widen(Vector512<int> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances - Generic version (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector512.Widen(Vector512{uint})" />
        /// <seealso cref="IWVectorTraits512.Widen(Vector512{uint}, out Vector512{ulong}, out Vector512{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Lower, Vector512<ulong> Upper) Widen(Vector512<uint> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }


        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft(Vector512{byte}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector512<T> args0, Vector512<T> args1) ShiftLeft_Args<T>(Vector512<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args(dummy.As<T, sbyte>(), shiftAmount);
                return (args0.As<sbyte, T>(), args1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args(dummy.As<T, byte>(), shiftAmount);
                return (args0.As<byte, T>(), args1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args(dummy.As<T, short>(), shiftAmount);
                return (args0.As<short, T>(), args1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args(dummy.As<T, ushort>(), shiftAmount);
                return (args0.As<ushort, T>(), args1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args(dummy.As<T, int>(), shiftAmount);
                return (args0.As<int, T>(), args1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args(dummy.As<T, uint>(), shiftAmount);
                return (args0.As<uint, T>(), args1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args(dummy.As<T, long>(), shiftAmount);
                return (args0.As<long, T>(), args1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args(dummy.As<T, ulong>(), shiftAmount);
                return (args0.As<ulong, T>(), args1.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft(Vector512{sbyte}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1) ShiftLeft_Args(Vector512<sbyte> dummy, int shiftAmount) {
            var args0 = ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft(Vector512{byte}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1) ShiftLeft_Args(Vector512<byte> dummy, int shiftAmount) {
            var args0 = ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft(Vector512{short}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1) ShiftLeft_Args(Vector512<short> dummy, int shiftAmount) {
            var args0 = ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft(Vector512{ushort}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1) ShiftLeft_Args(Vector512<ushort> dummy, int shiftAmount) {
            var args0 = ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft(Vector512{int}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1) ShiftLeft_Args(Vector512<int> dummy, int shiftAmount) {
            var args0 = ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft(Vector512{uint}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1) ShiftLeft_Args(Vector512<uint> dummy, int shiftAmount) {
            var args0 = ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft(Vector512{long}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1) ShiftLeft_Args(Vector512<long> dummy, int shiftAmount) {
            var args0 = ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft(Vector512{ulong}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1) ShiftLeft_Args(Vector512<ulong> dummy, int shiftAmount) {
            var args0 = ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector512<T> args0, Vector512<T> args1) ShiftRightArithmetic_Args<T>(Vector512<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args(dummy.As<T, sbyte>(), shiftAmount);
                return (args0.As<sbyte, T>(), args1.As<sbyte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args(dummy.As<T, short>(), shiftAmount);
                return (args0.As<short, T>(), args1.As<short, T>());
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args(dummy.As<T, int>(), shiftAmount);
                return (args0.As<int, T>(), args1.As<int, T>());
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args(dummy.As<T, long>(), shiftAmount);
                return (args0.As<long, T>(), args1.As<long, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1) ShiftRightArithmetic_Args(Vector512<sbyte> dummy, int shiftAmount) {
            var args0 = ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{short}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1) ShiftRightArithmetic_Args(Vector512<short> dummy, int shiftAmount) {
            var args0 = ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{int}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1) ShiftRightArithmetic_Args(Vector512<int> dummy, int shiftAmount) {
            var args0 = ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{long}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1) ShiftRightArithmetic_Args(Vector512<long> dummy, int shiftAmount) {
            var args0 = ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical(Vector512{byte}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector512<T> args0, Vector512<T> args1) ShiftRightLogical_Args<T>(Vector512<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args(dummy.As<T, sbyte>(), shiftAmount);
                return (args0.As<sbyte, T>(), args1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args(dummy.As<T, byte>(), shiftAmount);
                return (args0.As<byte, T>(), args1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args(dummy.As<T, short>(), shiftAmount);
                return (args0.As<short, T>(), args1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args(dummy.As<T, ushort>(), shiftAmount);
                return (args0.As<ushort, T>(), args1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args(dummy.As<T, int>(), shiftAmount);
                return (args0.As<int, T>(), args1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args(dummy.As<T, uint>(), shiftAmount);
                return (args0.As<uint, T>(), args1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args(dummy.As<T, long>(), shiftAmount);
                return (args0.As<long, T>(), args1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args(dummy.As<T, ulong>(), shiftAmount);
                return (args0.As<ulong, T>(), args1.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical(Vector512{sbyte}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1) ShiftRightLogical_Args(Vector512<sbyte> dummy, int shiftAmount) {
            var args0 = ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical(Vector512{byte}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1) ShiftRightLogical_Args(Vector512<byte> dummy, int shiftAmount) {
            var args0 = ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical(Vector512{short}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1) ShiftRightLogical_Args(Vector512<short> dummy, int shiftAmount) {
            var args0 = ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical(Vector512{ushort}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1) ShiftRightLogical_Args(Vector512<ushort> dummy, int shiftAmount) {
            var args0 = ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical(Vector512{int}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1) ShiftRightLogical_Args(Vector512<int> dummy, int shiftAmount) {
            var args0 = ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical(Vector512{uint}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1) ShiftRightLogical_Args(Vector512<uint> dummy, int shiftAmount) {
            var args0 = ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical(Vector512{long}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1) ShiftRightLogical_Args(Vector512<long> dummy, int shiftAmount) {
            var args0 = ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>The arguments provided for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical(Vector512{ulong}, int)"/>
        /// <seealso cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1) ShiftRightLogical_Args(Vector512<ulong> dummy, int shiftAmount) {
            var args0 = ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Shuffle_Args<TIdx>(Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args(indices.As<TIdx, sbyte>());
                args0 = a.As<sbyte, TIdx>();
                args1 = b.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args(indices.As<TIdx, byte>());
                args0 = a.As<byte, TIdx>();
                args1 = b.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args(indices.As<TIdx, short>());
                args0 = a.As<short, TIdx>();
                args1 = b.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args(indices.As<TIdx, ushort>());
                args0 = a.As<ushort, TIdx>();
                args1 = b.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args(indices.As<TIdx, int>());
                args0 = a.As<int, TIdx>();
                args1 = b.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args(indices.As<TIdx, uint>());
                args0 = a.As<uint, TIdx>();
                args1 = b.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args(indices.As<TIdx, long>());
                args0 = a.As<long, TIdx>();
                args1 = b.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args(indices.As<TIdx, ulong>());
                args0 = a.As<ulong, TIdx>();
                args1 = b.As<ulong, TIdx>();
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector512s.Shuffle_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1) Shuffle_Args<TIdx>(Vector512<TIdx> indices)
                where TIdx : struct {
            Shuffle_Args<TIdx>(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1) Shuffle_Args(Vector512<sbyte> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1) Shuffle_Args(Vector512<byte> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Args(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1) Shuffle_Args(Vector512<short> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1) Shuffle_Args(Vector512<ushort> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Args(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1) Shuffle_Args(Vector512<int> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1) Shuffle_Args(Vector512<uint> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Args(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1) Shuffle_Args(Vector512<long> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1) Shuffle_Args(Vector512<ulong> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }


        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Core(Vector512{float}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Shuffle_Core(Vector512<float> vector, (Vector512<int> args0, Vector512<int> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Core(Vector512{double}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Shuffle_Core(Vector512<double> vector, (Vector512<long> args0, Vector512<long> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Shuffle_Core(Vector512<sbyte> vector, (Vector512<sbyte> args0, Vector512<sbyte> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Core(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> Shuffle_Core(Vector512<byte> vector, (Vector512<byte> args0, Vector512<byte> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Core(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Shuffle_Core(Vector512<short> vector, (Vector512<short> args0, Vector512<short> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Shuffle_Core(Vector512<ushort> vector, (Vector512<ushort> args0, Vector512<ushort> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Core(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Shuffle_Core(Vector512<int> vector, (Vector512<int> args0, Vector512<int> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Core(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Shuffle_Core(Vector512<uint> vector, (Vector512<uint> args0, Vector512<uint> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Core(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Shuffle_Core(Vector512<long> vector, (Vector512<long> args0, Vector512<long> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> Shuffle_Core(Vector512<ulong> vector, (Vector512<ulong> args0, Vector512<ulong> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }


#endif // NET8_0_OR_GREATER
    }
}
