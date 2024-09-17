#if NET8_0_OR_GREATER
#define SHORT_CIRCUIT_WASM
#endif // NET8_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Impl;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits {
    static partial class Vector128s {

#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Compares two vectors to determine which is unsigned greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个是无符号更大).
        /// Mnemonic: <c>rt[i] := (T)to_mask(asUnsigned(left[i]) &gt; asUnsigned(right[i]))</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThan{T}(Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> GreaterThan_Unsigned(Vector128<sbyte> left, Vector128<sbyte> right) {
            return GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector128{sbyte}, Vector128{sbyte})"/>
        public static Vector128<byte> GreaterThan_Unsigned(Vector128<byte> left, Vector128<byte> right) {
            return GreaterThan(left, right);
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector128{sbyte}, Vector128{sbyte})"/>
        public static Vector128<short> GreaterThan_Unsigned(Vector128<short> left, Vector128<short> right) {
            return GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        public static Vector128<ushort> GreaterThan_Unsigned(Vector128<ushort> left, Vector128<ushort> right) {
            return GreaterThan(left, right);
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector128{sbyte}, Vector128{sbyte})"/>
        public static Vector128<int> GreaterThan_Unsigned(Vector128<int> left, Vector128<int> right) {
            return GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        public static Vector128<uint> GreaterThan_Unsigned(Vector128<uint> left, Vector128<uint> right) {
            return GreaterThan(left, right);
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector128{sbyte}, Vector128{sbyte})"/>
        public static Vector128<long> GreaterThan_Unsigned(Vector128<long> left, Vector128<long> right) {
            return GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        public static Vector128<ulong> GreaterThan_Unsigned(Vector128<ulong> left, Vector128<ulong> right) {
            return GreaterThan(left, right);
        }


        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TOut">The element type of the output parameter (输出参数的元素类型).</typeparam>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TOut"/>) are not supported.</exception>
        /// <seealso cref="Vector128.Widen(Vector128{float})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})" />
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Widen<T, TOut>(Vector128<T> source, out Vector128<TOut> lower, out Vector128<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector128<double> a, Vector128<double> b) = Widen(source.As<T, float>());
                lower = a.As<double, TOut>();
                upper = b.As<double, TOut>();
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector128<short> a, Vector128<short> b) = Widen(source.As<T, sbyte>());
                lower = a.As<short, TOut>();
                upper = b.As<short, TOut>();
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector128<ushort> a, Vector128<ushort> b) = Widen(source.As<T, byte>());
                lower = a.As<ushort, TOut>();
                upper = b.As<ushort, TOut>();
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector128<int> a, Vector128<int> b) = Widen(source.As<T, short>());
                lower = a.As<int, TOut>();
                upper = b.As<int, TOut>();
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector128<uint> a, Vector128<uint> b) = Widen(source.As<T, ushort>());
                lower = a.As<uint, TOut>();
                upper = b.As<uint, TOut>();
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector128<long> a, Vector128<long> b) = Widen(source.As<T, int>());
                lower = a.As<long, TOut>();
                upper = b.As<long, TOut>();
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector128<ulong> a, Vector128<ulong> b) = Widen(source.As<T, uint>());
                lower = a.As<ulong, TOut>();
                upper = b.As<ulong, TOut>();
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{float})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Lower, Vector128<double> Upper) Widen(Vector128<float> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return Vector128.Widen(source);
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{sbyte})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Lower, Vector128<short> Upper) Widen(Vector128<sbyte> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return Vector128.Widen(source);
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{byte})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Lower, Vector128<ushort> Upper) Widen(Vector128<byte> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return Vector128.Widen(source);
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{short})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Lower, Vector128<int> Upper) Widen(Vector128<short> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return Vector128.Widen(source);
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{ushort})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Lower, Vector128<uint> Upper) Widen(Vector128<ushort> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return Vector128.Widen(source);
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{int})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Lower, Vector128<long> Upper) Widen(Vector128<int> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return Vector128.Widen(source);
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{uint})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Lower, Vector128<ulong> Upper) Widen(Vector128<uint> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return Vector128.Widen(source);
            }
#endif // SHORT_CIRCUIT_WASM
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
        /// <seealso cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector128<T> args0, Vector128<T> args1) ShiftLeft_Args<T>(Vector128<T> dummy, int shiftAmount) where T : struct {
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
        /// <seealso cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft(Vector128{sbyte}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1) ShiftLeft_Args(Vector128<sbyte> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1) ShiftLeft_Args(Vector128<byte> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1) ShiftLeft_Args(Vector128<short> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft(Vector128{ushort}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1) ShiftLeft_Args(Vector128<ushort> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1) ShiftLeft_Args(Vector128<int> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft(Vector128{uint}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1) ShiftLeft_Args(Vector128<uint> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft(Vector128{long}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1) ShiftLeft_Args(Vector128<long> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft(Vector128{ulong}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftLeft_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1) ShiftLeft_Args(Vector128<ulong> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector128<T> args0, Vector128<T> args1) ShiftRightArithmetic_Args<T>(Vector128<T> dummy, int shiftAmount) where T : struct {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1) ShiftRightArithmetic_Args(Vector128<sbyte> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{short}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1) ShiftRightArithmetic_Args(Vector128<short> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1) ShiftRightArithmetic_Args(Vector128<int> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{long}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1) ShiftRightArithmetic_Args(Vector128<long> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical(Vector128{byte}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector128<T> args0, Vector128<T> args1) ShiftRightLogical_Args<T>(Vector128<T> dummy, int shiftAmount) where T : struct {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical(Vector128{sbyte}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1) ShiftRightLogical_Args(Vector128<sbyte> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical(Vector128{byte}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1) ShiftRightLogical_Args(Vector128<byte> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical(Vector128{short}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1) ShiftRightLogical_Args(Vector128<short> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical(Vector128{ushort}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1) ShiftRightLogical_Args(Vector128<ushort> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical(Vector128{int}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1) ShiftRightLogical_Args(Vector128<int> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical(Vector128{uint}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1) ShiftRightLogical_Args(Vector128<uint> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical(Vector128{long}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1) ShiftRightLogical_Args(Vector128<long> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical(Vector128{ulong}, int)"/>
        /// <seealso cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1) ShiftRightLogical_Args(Vector128<ulong> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Shuffle_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1)
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
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128s.Shuffle_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1) Shuffle_Args<TIdx>(Vector128<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1) Shuffle_Args(Vector128<sbyte> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1) Shuffle_Args(Vector128<byte> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1) Shuffle_Args(Vector128<short> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1) Shuffle_Args(Vector128<ushort> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1) Shuffle_Args(Vector128<int> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1) Shuffle_Args(Vector128<uint> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1) Shuffle_Args(Vector128<long> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1) Shuffle_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> Shuffle_Core(Vector128<float> vector, (Vector128<int> args0, Vector128<int> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> Shuffle_Core(Vector128<double> vector, (Vector128<long> args0, Vector128<long> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> Shuffle_Core(Vector128<sbyte> vector, (Vector128<sbyte> args0, Vector128<sbyte> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> Shuffle_Core(Vector128<byte> vector, (Vector128<byte> args0, Vector128<byte> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> Shuffle_Core(Vector128<short> vector, (Vector128<short> args0, Vector128<short> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> Shuffle_Core(Vector128<ushort> vector, (Vector128<ushort> args0, Vector128<ushort> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> Shuffle_Core(Vector128<int> vector, (Vector128<int> args0, Vector128<int> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> Shuffle_Core(Vector128<uint> vector, (Vector128<uint> args0, Vector128<uint> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> Shuffle_Core(Vector128<long> vector, (Vector128<long> args0, Vector128<long> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> Shuffle_Core(Vector128<ulong> vector, (Vector128<ulong> args0, Vector128<ulong> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }


#endif // NETCOREAPP3_0_OR_GREATER
    }
}
