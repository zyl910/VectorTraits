using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits {

    partial class Vector128s {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector128{T}" /> of type <typeparamref name="TFrom"/> as a new <see cref="Vector128{T}" /> of type <typeparamref name="TTo"/>. It supports ExType, so there is no element type check (将 <typeparamref name="TFrom"/> 类型的 <see cref="Vector128{T}" /> 重新解释为 <typeparamref name="TTo"/> 类型的新 <see cref="Vector128{T}" />. 它支持 ExType, 故没有元素类型检查).
        /// </summary>
        /// <typeparam name="TFrom">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <typeparam name="TTo">The type that the vector <paramref name="vector"/> should be reinterpreted as (向量 <paramref name="vector"/> 应重新解释为的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a <see cref="Vector128{T}" /> of type <typeparamref name="TTo"/> (重新解释为 <typeparamref name="TTo"/> 类型的 <see cref="Vector128{T}" /> 向量).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<TTo> ExAs<TFrom, TTo>(this Vector128<TFrom> vector) where TFrom : struct where TTo : struct {
            return Unsafe.As<Vector128<TFrom>, Vector128<TTo>>(ref vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector128{T}" /> as a new <see cref="Vector128{T}" /> of type <see cref="float" /> (将 <see cref="Vector128{T}" /> 重新解释为 <see cref="float" /> 类型的新 <see cref="Vector128{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector128{T}" /> of type <see cref="float" /> (重新解释为 <see cref="float" /> 类型的 <see cref="Vector128{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector128{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> ExAsSingle<T>(this Vector128<T> vector) where T : struct {
            return ExAs<T, float>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector128{T}" /> as a new <see cref="Vector128{T}" /> of type <see cref="double" /> (将 <see cref="Vector128{T}" /> 重新解释为 <see cref="double" /> 类型的新 <see cref="Vector128{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector128{T}" /> of type <see cref="double" /> (重新解释为 <see cref="double" /> 类型的 <see cref="Vector128{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector128{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> ExAsDouble<T>(this Vector128<T> vector) where T : struct {
            return ExAs<T, double>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector128{T}" /> as a new <see cref="Vector128{T}" /> of type <see cref="sbyte" /> (将 <see cref="Vector128{T}" /> 重新解释为 <see cref="sbyte" /> 类型的新 <see cref="Vector128{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector128{T}" /> of type <see cref="sbyte" /> (重新解释为 <see cref="sbyte" /> 类型的 <see cref="Vector128{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector128{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> ExAsSByte<T>(this Vector128<T> vector) where T : struct {
            return ExAs<T, sbyte>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector128{T}" /> as a new <see cref="Vector128{T}" /> of type <see cref="byte" /> (将 <see cref="Vector128{T}" /> 重新解释为 <see cref="byte" /> 类型的新 <see cref="Vector128{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector128{T}" /> of type <see cref="byte" /> (重新解释为 <see cref="byte" /> 类型的 <see cref="Vector128{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector128{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> ExAsByte<T>(this Vector128<T> vector) where T : struct {
            return ExAs<T, byte>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector128{T}" /> as a new <see cref="Vector128{T}" /> of type <see cref="short" /> (将 <see cref="Vector128{T}" /> 重新解释为 <see cref="short" /> 类型的新 <see cref="Vector128{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector128{T}" /> of type <see cref="short" /> (重新解释为 <see cref="short" /> 类型的 <see cref="Vector128{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector128{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> ExAsInt16<T>(this Vector128<T> vector) where T : struct {
            return ExAs<T, short>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector128{T}" /> as a new <see cref="Vector128{T}" /> of type <see cref="ushort" /> (将 <see cref="Vector128{T}" /> 重新解释为 <see cref="ushort" /> 类型的新 <see cref="Vector128{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector128{T}" /> of type <see cref="ushort" /> (重新解释为 <see cref="ushort" /> 类型的 <see cref="Vector128{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector128{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> ExAsUInt16<T>(this Vector128<T> vector) where T : struct {
            return ExAs<T, ushort>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector128{T}" /> as a new <see cref="Vector128{T}" /> of type <see cref="int" /> (将 <see cref="Vector128{T}" /> 重新解释为 <see cref="int" /> 类型的新 <see cref="Vector128{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector128{T}" /> of type <see cref="int" /> (重新解释为 <see cref="int" /> 类型的 <see cref="Vector128{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector128{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ExAsInt32<T>(this Vector128<T> vector) where T : struct {
            return ExAs<T, int>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector128{T}" /> as a new <see cref="Vector128{T}" /> of type <see cref="uint" /> (将 <see cref="Vector128{T}" /> 重新解释为 <see cref="uint" /> 类型的新 <see cref="Vector128{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector128{T}" /> of type <see cref="uint" /> (重新解释为 <see cref="uint" /> 类型的 <see cref="Vector128{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector128{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> ExAsUInt32<T>(this Vector128<T> vector) where T : struct {
            return ExAs<T, uint>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector128{T}" /> as a new <see cref="Vector128{T}" /> of type <see cref="long" /> (将 <see cref="Vector128{T}" /> 重新解释为 <see cref="long" /> 类型的新 <see cref="Vector128{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector128{T}" /> of type <see cref="long" /> (重新解释为 <see cref="long" /> 类型的 <see cref="Vector128{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector128{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> ExAsInt64<T>(this Vector128<T> vector) where T : struct {
            return ExAs<T, long>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector128{T}" /> as a new <see cref="Vector128{T}" /> of type <see cref="ulong" /> (将 <see cref="Vector128{T}" /> 重新解释为 <see cref="ulong" /> 类型的新 <see cref="Vector128{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element(输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector128{T}" /> of type <see cref="ulong" /> (重新解释为 <see cref="ulong" /> 类型的 <see cref="Vector128{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector128{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> ExAsUInt64<T>(this Vector128<T> vector) where T : struct {
            return ExAs<T, ulong>(vector);
        }

#endif
    }
}
