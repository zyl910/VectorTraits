﻿#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Extensions {

    partial class VectorExtensions {

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> of type <typeparamref name="TFrom"/> as a new <see cref="Vector{T}" /> of type <typeparamref name="TTo"/>. It supports ExType, so there is no element type check (将 <typeparamref name="TFrom"/> 类型的 <see cref="Vector{T}" /> 重新解释为 <typeparamref name="TTo"/> 类型的新 <see cref="Vector{T}" />. 它支持 ExType, 故没有元素类型检查).
        /// </summary>
        /// <typeparam name="TFrom">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <typeparam name="TTo">The type that the vector <paramref name="vector"/> should be reinterpreted as (向量 <paramref name="vector"/> 应重新解释为的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a <see cref="Vector{T}" /> of type <typeparamref name="TTo"/> (重新解释为 <typeparamref name="TTo"/> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<TTo> ExAs<TFrom, TTo>(this Vector<TFrom> vector) where TFrom : struct where TTo : struct {
            return Unsafe.As<Vector<TFrom>, Vector<TTo>>(ref vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="float" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="float" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="float" /> (重新解释为 <see cref="float" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> ExAsSingle<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, float>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="double" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="double" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="double" /> (重新解释为 <see cref="double" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> ExAsDouble<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, double>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="sbyte" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="sbyte" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="sbyte" /> (重新解释为 <see cref="sbyte" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ExAsSByte<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, sbyte>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="byte" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="byte" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="byte" /> (重新解释为 <see cref="byte" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ExAsByte<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, byte>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="short" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="short" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="short" /> (重新解释为 <see cref="short" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ExAsInt16<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, short>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="ushort" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="ushort" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="ushort" /> (重新解释为 <see cref="ushort" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ExAsUInt16<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, ushort>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="int" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="int" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="int" /> (重新解释为 <see cref="int" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ExAsInt32<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, int>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="uint" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="uint" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="uint" /> (重新解释为 <see cref="uint" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ExAsUInt32<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, uint>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="long" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="long" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="long" /> (重新解释为 <see cref="long" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ExAsInt64<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, long>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="ulong" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="ulong" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="ulong" /> (重新解释为 <see cref="ulong" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ExAsUInt64<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, ulong>(vector);
        }

#if BCL_TYPE_INT128

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="Int128" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="Int128" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="Int128" /> (重新解释为 <see cref="Int128" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> ExAsInt128<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, Int128>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="UInt128" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="UInt128" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="UInt128" /> (重新解释为 <see cref="UInt128" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> ExAsUInt128<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, UInt128>(vector);
        }
#endif // BCL_TYPE_INT128

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="ExInt128" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="ExInt128" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="ExInt128" /> (重新解释为 <see cref="ExInt128" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExInt128> ExAsExInt128<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, ExInt128>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector{T}" /> of type <see cref="ExUInt128" /> (将 <see cref="Vector{T}" /> 重新解释为 <see cref="ExUInt128" /> 类型的新 <see cref="Vector{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}" /> of type <see cref="ExUInt128" /> (重新解释为 <see cref="ExUInt128" /> 类型的 <see cref="Vector{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExUInt128> ExAsExUInt128<T>(this Vector<T> vector) where T : struct {
            return ExAs<T, ExUInt128>(vector);
        }

    }
}