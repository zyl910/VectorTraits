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
using Zyl.VectorTraits.Impl;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;
#if !OFF_VECTOR_TUPLES
using Zyl.VectorTraits.Tuples;
#endif // !OFF_VECTOR_TUPLES

namespace Zyl.VectorTraits {
    static partial class Vector256s {

#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TOut">The element type of the output parameter (输出参数的元素类型).</typeparam>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TOut"/>) are not supported.</exception>
        /// <seealso cref="Vector256.Widen(Vector256{float})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})" />
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Widen<T, TOut>(Vector256<T> source, out Vector256<TOut> lower, out Vector256<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector256<double> a, Vector256<double> b) = Widen((Vector256<float>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector256<short> a, Vector256<short> b) = Widen((Vector256<sbyte>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector256<ushort> a, Vector256<ushort> b) = Widen((Vector256<byte>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector256<int> a, Vector256<int> b) = Widen((Vector256<short>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector256<uint> a, Vector256<uint> b) = Widen((Vector256<ushort>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector256<long> a, Vector256<long> b) = Widen((Vector256<int>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector256<ulong> a, Vector256<ulong> b) = Widen((Vector256<uint>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{float})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> Lower, Vector256<double> Upper) Widen(Vector256<float> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{sbyte})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> Lower, Vector256<short> Upper) Widen(Vector256<sbyte> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{byte})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> Lower, Vector256<ushort> Upper) Widen(Vector256<byte> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{short})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> Lower, Vector256<int> Upper) Widen(Vector256<short> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{ushort})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> Lower, Vector256<uint> Upper) Widen(Vector256<ushort> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{int})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> Lower, Vector256<long> Upper) Widen(Vector256<int> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{uint})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> Lower, Vector256<ulong> Upper) Widen(Vector256<uint> source) {
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
        /// <seealso cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft_Core"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector256<T> args0, Vector256<T> args1) ShiftLeft_Args<T>(Vector256<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector256<sbyte>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector256<byte>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector256<short>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector256<ushort>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector256<int>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector256<uint>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector256<long>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = ShiftLeft_Args((Vector256<ulong>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
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
        /// <seealso cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1) ShiftLeft_Args(Vector256<sbyte> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft_Core(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1) ShiftLeft_Args(Vector256<byte> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1) ShiftLeft_Args(Vector256<short> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft_Core(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1) ShiftLeft_Args(Vector256<ushort> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1) ShiftLeft_Args(Vector256<int> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft_Core(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1) ShiftLeft_Args(Vector256<uint> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1) ShiftLeft_Args(Vector256<long> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftLeft_Core(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1) ShiftLeft_Args(Vector256<ulong> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic_Core"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector256<T> args0, Vector256<T> args1) ShiftRightArithmetic_Args<T>(Vector256<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args((Vector256<sbyte>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args((Vector256<short>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args((Vector256<int>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = ShiftRightArithmetic_Args((Vector256<long>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
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
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1) ShiftRightArithmetic_Args(Vector256<sbyte> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1) ShiftRightArithmetic_Args(Vector256<short> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1) ShiftRightArithmetic_Args(Vector256<int> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1) ShiftRightArithmetic_Args(Vector256<long> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_Core"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector256<T> args0, Vector256<T> args1) ShiftRightLogical_Args<T>(Vector256<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector256<sbyte>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector256<byte>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector256<short>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector256<ushort>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector256<int>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector256<uint>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector256<long>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = ShiftRightLogical_Args((Vector256<ulong>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
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
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1) ShiftRightLogical_Args(Vector256<sbyte> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1) ShiftRightLogical_Args(Vector256<byte> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1) ShiftRightLogical_Args(Vector256<short> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1) ShiftRightLogical_Args(Vector256<ushort> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1) ShiftRightLogical_Args(Vector256<int> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1) ShiftRightLogical_Args(Vector256<uint> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1) ShiftRightLogical_Args(Vector256<long> dummy, int shiftAmount) {
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
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
        /// <seealso cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1) ShiftRightLogical_Args(Vector256<ulong> dummy, int shiftAmount) {
            var args0 = ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Args"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Shuffle_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = Shuffle_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector256s.Shuffle_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1) Shuffle_Args<TIdx>(Vector256<TIdx> indices)
                where TIdx : struct {
            Shuffle_Args<TIdx>(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1) Shuffle_Args(Vector256<sbyte> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1) Shuffle_Args(Vector256<byte> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1) Shuffle_Args(Vector256<short> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1) Shuffle_Args(Vector256<ushort> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1) Shuffle_Args(Vector256<int> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1) Shuffle_Args(Vector256<uint> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1) Shuffle_Args(Vector256<long> indices) {
            Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for Shuffle_Core (为 Shuffle_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1) Shuffle_Args(Vector256<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Shuffle_Core(Vector256<float> vector, (Vector256<int> args0, Vector256<int> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Shuffle_Core(Vector256<double> vector, (Vector256<long> args0, Vector256<long> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Shuffle_Core(Vector256<sbyte> vector, (Vector256<sbyte> args0, Vector256<sbyte> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Shuffle_Core(Vector256<byte> vector, (Vector256<byte> args0, Vector256<byte> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Shuffle_Core(Vector256<short> vector, (Vector256<short> args0, Vector256<short> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Core(Vector256{ushort}, Vector256X2{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Shuffle_Core(Vector256<ushort> vector, (Vector256<ushort> args0, Vector256<ushort> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Shuffle_Core(Vector256<int> vector, (Vector256<int> args0, Vector256<int> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> Shuffle_Core(Vector256<uint> vector, (Vector256<uint> args0, Vector256<uint> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> Shuffle_Core(Vector256<long> vector, (Vector256<long> args0, Vector256<long> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> Shuffle_Core(Vector256<ulong> vector, (Vector256<ulong> args0, Vector256<ulong> args1) args) {
            return Shuffle_Core(vector, args.args0, args.args1);
        }


#endif // NETCOREAPP3_0_OR_GREATER
    }
}
