#if NET8_0_OR_GREATER
#define SHORT_CIRCUIT_WASM
#endif // NET8_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER
using System.Text;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Impl;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits {
    static partial class Vectors {

        /// <summary>
        /// Compares two vectors to determine which is unsigned greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个是无符号更大).
        /// Mnemonic: <c>rt[i] := (T)to_mask(asUnsigned(left[i]) &gt; asUnsigned(right[i]))</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="Vector.GreaterThan{T}(Vector{T}, Vector{T})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> GreaterThan_Unsigned(Vector<sbyte> left, Vector<sbyte> right) {
            return Vector.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector{sbyte}, Vector{sbyte})"/>
        public static Vector<byte> GreaterThan_Unsigned(Vector<byte> left, Vector<byte> right) {
            return Vector.GreaterThan(left, right);
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector{sbyte}, Vector{sbyte})"/>
        public static Vector<short> GreaterThan_Unsigned(Vector<short> left, Vector<short> right) {
            return Vector.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        public static Vector<ushort> GreaterThan_Unsigned(Vector<ushort> left, Vector<ushort> right) {
            return Vector.GreaterThan(left, right);
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector{sbyte}, Vector{sbyte})"/>
        public static Vector<int> GreaterThan_Unsigned(Vector<int> left, Vector<int> right) {
            return Vector.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        public static Vector<uint> GreaterThan_Unsigned(Vector<uint> left, Vector<uint> right) {
            return Vector.GreaterThan(left, right);
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector{sbyte}, Vector{sbyte})"/>
        public static Vector<long> GreaterThan_Unsigned(Vector<long> left, Vector<long> right) {
            return Vector.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="GreaterThan_Unsigned(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        public static Vector<ulong> GreaterThan_Unsigned(Vector<ulong> left, Vector<ulong> right) {
            return Vector.GreaterThan(left, right);
        }


        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TOut">The element type of the output parameter (输出参数的元素类型).</typeparam>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TOut"/>) are not supported.</exception>
        /// <seealso cref="Vector.Widen(Vector{float}, out Vector{double}, out Vector{double})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})" />
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Widen<T, TOut>(Vector<T> source, out Vector<TOut> lower, out Vector<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector<double> a, Vector<double> b) = Widen((Vector<float>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector<short> a, Vector<short> b) = Widen((Vector<sbyte>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector<ushort> a, Vector<ushort> b) = Widen((Vector<byte>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector<int> a, Vector<int> b) = Widen((Vector<short>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector<uint> a, Vector<uint> b) = Widen((Vector<ushort>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector<long> a, Vector<long> b) = Widen((Vector<int>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector<ulong> a, Vector<ulong> b) = Widen((Vector<uint>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{float}, out Vector{double}, out Vector{double})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Lower, Vector<double> Upper) Widen(Vector<float> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                (var a1, var b1) = Vector128.Widen(source.AsVector128());
                return (a1.AsVector(), b1.AsVector());
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Lower, Vector<short> Upper) Widen(Vector<sbyte> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                (var a1, var b1) = Vector128.Widen(source.AsVector128());
                return (a1.AsVector(), b1.AsVector());
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Lower, Vector<ushort> Upper) Widen(Vector<byte> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                (var a1, var b1) = Vector128.Widen(source.AsVector128());
                return (a1.AsVector(), b1.AsVector());
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{short}, out Vector{int}, out Vector{int})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Lower, Vector<int> Upper) Widen(Vector<short> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                (var a1, var b1) = Vector128.Widen(source.AsVector128());
                return (a1.AsVector(), b1.AsVector());
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Lower, Vector<uint> Upper) Widen(Vector<ushort> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                (var a1, var b1) = Vector128.Widen(source.AsVector128());
                return (a1.AsVector(), b1.AsVector());
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{int}, out Vector{long}, out Vector{long})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Lower, Vector<long> Upper) Widen(Vector<int> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                (var a1, var b1) = Vector128.Widen(source.AsVector128());
                return (a1.AsVector(), b1.AsVector());
            }
#endif // SHORT_CIRCUIT_WASM
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Lower, Vector<ulong> Upper) Widen(Vector<uint> source) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                (var a1, var b1) = Vector128.Widen(source.AsVector128());
                return (a1.AsVector(), b1.AsVector());
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
        /// <seealso cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftLeft_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector<T> args0, Vector<T> args1) ShiftLeft_Args<T>(Vector<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector<sbyte>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector<byte>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector<short>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector<ushort>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector<int>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector<uint>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector<long>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector<ulong>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
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
        /// <seealso cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftLeft_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1) ShiftLeft_Args(Vector<sbyte> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftLeft_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1) ShiftLeft_Args(Vector<byte> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftLeft_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1) ShiftLeft_Args(Vector<short> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftLeft_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1) ShiftLeft_Args(Vector<ushort> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftLeft_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1) ShiftLeft_Args(Vector<int> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftLeft_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1) ShiftLeft_Args(Vector<uint> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftLeft_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1) ShiftLeft_Args(Vector<long> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftLeft_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1) ShiftLeft_Args(Vector<ulong> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector<T> args0, Vector<T> args1) ShiftRightArithmetic_Args<T>(Vector<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args((Vector<sbyte>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args((Vector<short>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args((Vector<int>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args((Vector<long>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
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
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1) ShiftRightArithmetic_Args(Vector<sbyte> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1) ShiftRightArithmetic_Args(Vector<short> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1) ShiftRightArithmetic_Args(Vector<int> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1) ShiftRightArithmetic_Args(Vector<long> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector<T> args0, Vector<T> args1) ShiftRightLogical_Args<T>(Vector<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector<sbyte>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector<byte>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector<short>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector<ushort>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector<int>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector<uint>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector<long>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector<ulong>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
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
        /// <seealso cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1) ShiftRightLogical_Args(Vector<sbyte> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1) ShiftRightLogical_Args(Vector<byte> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1) ShiftRightLogical_Args(Vector<short> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1) ShiftRightLogical_Args(Vector<ushort> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1) ShiftRightLogical_Args(Vector<int> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1) ShiftRightLogical_Args(Vector<uint> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1) ShiftRightLogical_Args(Vector<long> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
        /// <seealso cref="IVectorTraits.ShiftRightLogical_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1) ShiftRightLogical_Args(Vector<ulong> dummy, int shiftAmount) {
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
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Shuffle_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
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
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vectors.Shuffle_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1) Shuffle_Args<TIdx>(Vector<TIdx> indices)
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
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1) Shuffle_Args(Vector<sbyte> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1) Shuffle_Args(Vector<byte> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1) Shuffle_Args(Vector<short> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1) Shuffle_Args(Vector<ushort> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1) Shuffle_Args(Vector<int> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1) Shuffle_Args(Vector<uint> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1) Shuffle_Args(Vector<long> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1) Shuffle_Args(Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Core(Vector{float}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> Shuffle_Core(Vector<float> vector, (Vector<int> args0, Vector<int> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Core(Vector{double}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> Shuffle_Core(Vector<double> vector, (Vector<long> args0, Vector<long> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> Shuffle_Core(Vector<sbyte> vector, (Vector<sbyte> args0, Vector<sbyte> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Shuffle_Core(Vector<byte> vector, (Vector<byte> args0, Vector<byte> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Core(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> Shuffle_Core(Vector<short> vector, (Vector<short> args0, Vector<short> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Shuffle_Core(Vector<ushort> vector, (Vector<ushort> args0, Vector<ushort> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Core(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> Shuffle_Core(Vector<int> vector, (Vector<int> args0, Vector<int> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> Shuffle_Core(Vector<uint> vector, (Vector<uint> args0, Vector<uint> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Core(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> Shuffle_Core(Vector<long> vector, (Vector<long> args0, Vector<long> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> Shuffle_Core(Vector<ulong> vector, (Vector<ulong> args0, Vector<ulong> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }


    }
}
