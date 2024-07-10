#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits {

    partial class Vector64s {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Returns a value that indicates whether this instance is binary equal to a specified vector (返回一个值，该值指示此实例是否与指定的向量二进制相等).
        /// </summary>
        /// <typeparam name="T">The type of the vector element (向量元素的类型).</typeparam>
        /// <param name="vector">Current vector (当前的向量).</param>
        /// <param name="other">Another vector (另一个向量).</param>
        /// <returns><c>true</c> if <paramref name="other"/> has the same value as this instance; otherwise, <c>false</c> (当 <paramref name="other"/> 相等时返回 <c>true</c>, 否则为 <c>false</c>).</returns>
        public static bool BitEquals<T>(this Vector64<T> vector, Vector64<T> other) where T : struct {
            return vector.ExAsUInt64().Equals(other.ExAsUInt64());
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector64{T}" /> of type <typeparamref name="TFrom"/> as a new <see cref="Vector64{T}" /> of type <typeparamref name="TTo"/>. It supports ExType, so there is no element type check (将 <typeparamref name="TFrom"/> 类型的 <see cref="Vector64{T}" /> 重新解释为 <typeparamref name="TTo"/> 类型的新 <see cref="Vector64{T}" />. 它支持扩展类型, 故没有元素类型检查).
        /// </summary>
        /// <typeparam name="TFrom">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <typeparam name="TTo">The type that the vector <paramref name="vector"/> should be reinterpreted as (向量 <paramref name="vector"/> 应重新解释为的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a <see cref="Vector64{T}" /> of type <typeparamref name="TTo"/> (重新解释为 <typeparamref name="TTo"/> 类型的 <see cref="Vector64{T}" /> 向量).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<TTo> ExAs<TFrom, TTo>(this Vector64<TFrom> vector) where TFrom : struct where TTo : struct {
            return Unsafe.As<Vector64<TFrom>, Vector64<TTo>>(ref vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector64{T}" /> as a new <see cref="Vector64{T}" /> of type <see cref="float" /> (将 <see cref="Vector64{T}" /> 重新解释为 <see cref="float" /> 类型的新 <see cref="Vector64{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector64{T}" /> of type <see cref="float" /> (重新解释为 <see cref="float" /> 类型的 <see cref="Vector64{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector64{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<float> ExAsSingle<T>(this Vector64<T> vector) where T : struct {
            return ExAs<T, float>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector64{T}" /> as a new <see cref="Vector64{T}" /> of type <see cref="double" /> (将 <see cref="Vector64{T}" /> 重新解释为 <see cref="double" /> 类型的新 <see cref="Vector64{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector64{T}" /> of type <see cref="double" /> (重新解释为 <see cref="double" /> 类型的 <see cref="Vector64{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector64{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<double> ExAsDouble<T>(this Vector64<T> vector) where T : struct {
            return ExAs<T, double>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector64{T}" /> as a new <see cref="Vector64{T}" /> of type <see cref="sbyte" /> (将 <see cref="Vector64{T}" /> 重新解释为 <see cref="sbyte" /> 类型的新 <see cref="Vector64{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector64{T}" /> of type <see cref="sbyte" /> (重新解释为 <see cref="sbyte" /> 类型的 <see cref="Vector64{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector64{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<sbyte> ExAsSByte<T>(this Vector64<T> vector) where T : struct {
            return ExAs<T, sbyte>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector64{T}" /> as a new <see cref="Vector64{T}" /> of type <see cref="byte" /> (将 <see cref="Vector64{T}" /> 重新解释为 <see cref="byte" /> 类型的新 <see cref="Vector64{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector64{T}" /> of type <see cref="byte" /> (重新解释为 <see cref="byte" /> 类型的 <see cref="Vector64{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector64{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<byte> ExAsByte<T>(this Vector64<T> vector) where T : struct {
            return ExAs<T, byte>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector64{T}" /> as a new <see cref="Vector64{T}" /> of type <see cref="short" /> (将 <see cref="Vector64{T}" /> 重新解释为 <see cref="short" /> 类型的新 <see cref="Vector64{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector64{T}" /> of type <see cref="short" /> (重新解释为 <see cref="short" /> 类型的 <see cref="Vector64{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector64{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<short> ExAsInt16<T>(this Vector64<T> vector) where T : struct {
            return ExAs<T, short>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector64{T}" /> as a new <see cref="Vector64{T}" /> of type <see cref="ushort" /> (将 <see cref="Vector64{T}" /> 重新解释为 <see cref="ushort" /> 类型的新 <see cref="Vector64{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector64{T}" /> of type <see cref="ushort" /> (重新解释为 <see cref="ushort" /> 类型的 <see cref="Vector64{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector64{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<ushort> ExAsUInt16<T>(this Vector64<T> vector) where T : struct {
            return ExAs<T, ushort>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector64{T}" /> as a new <see cref="Vector64{T}" /> of type <see cref="int" /> (将 <see cref="Vector64{T}" /> 重新解释为 <see cref="int" /> 类型的新 <see cref="Vector64{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector64{T}" /> of type <see cref="int" /> (重新解释为 <see cref="int" /> 类型的 <see cref="Vector64{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector64{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<int> ExAsInt32<T>(this Vector64<T> vector) where T : struct {
            return ExAs<T, int>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector64{T}" /> as a new <see cref="Vector64{T}" /> of type <see cref="uint" /> (将 <see cref="Vector64{T}" /> 重新解释为 <see cref="uint" /> 类型的新 <see cref="Vector64{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector64{T}" /> of type <see cref="uint" /> (重新解释为 <see cref="uint" /> 类型的 <see cref="Vector64{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector64{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<uint> ExAsUInt32<T>(this Vector64<T> vector) where T : struct {
            return ExAs<T, uint>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector64{T}" /> as a new <see cref="Vector64{T}" /> of type <see cref="long" /> (将 <see cref="Vector64{T}" /> 重新解释为 <see cref="long" /> 类型的新 <see cref="Vector64{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector64{T}" /> of type <see cref="long" /> (重新解释为 <see cref="long" /> 类型的 <see cref="Vector64{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector64{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<long> ExAsInt64<T>(this Vector64<T> vector) where T : struct {
            return ExAs<T, long>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector64{T}" /> as a new <see cref="Vector64{T}" /> of type <see cref="ulong" /> (将 <see cref="Vector64{T}" /> 重新解释为 <see cref="ulong" /> 类型的新 <see cref="Vector64{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector64{T}" /> of type <see cref="ulong" /> (重新解释为 <see cref="ulong" /> 类型的 <see cref="Vector64{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector64{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<ulong> ExAsUInt64<T>(this Vector64<T> vector) where T : struct {
            return ExAs<T, ulong>(vector);
        }

        /// <summary>
        /// (ExType) Gets the element at the specified index. It is unsafe method, it ignores the index range check (获取指定索引处的元素. 它是非安全的, 它忽略了索引的范围检查).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to get the element from (要从中获取元素的向量).</param>
        /// <param name="index">The index of the element to get (要获取的元素的索引).</param>
        /// <returns>The element at the specified index(指定索引处的元素).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ExGetElement<T>(in this Vector64<T> vector, int index) where T : struct {
            ref T address = ref Unsafe.As<Vector64<T>, T>(ref Unsafe.AsRef(in vector));
            return Unsafe.Add(ref address, index);
        }

        /// <summary>Converts the given vector to a scalar containing the value of the first element (将给定向量转换为首个元素的值的标量).</summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to get the first element from.</param>
        /// <returns>A scalar <typeparamref name="T" /> containing the value of the first element.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ExToScalar<T>(this Vector64<T> vector) where T : struct {
            return vector.ExGetElement(0);
        }

        /// <summary>Converts the given vector to a new <see cref="Vector128{T}" /> with the lower 64-bits set to the value of the given vector and the upper 64-bits initialized to zero (将给定向量转换为新 <see cref="Vector128{T}" /> 向量，其中较低的 64 位设置为给定向量的值，并将高 64 位初始化为零).</summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to extend (要扩展的向量).</param>
        /// <returns>A new <see cref="Vector128{T}" /> with the lower 64-bits set to the value of <paramref name="vector" /> and the upper 64-bits initialized to zero (一个新的 <see cref="Vector128{T}" />, 将较低的 64 位设置为 <paramref name="vector" />的值， 而高 64 位初始化为零).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> ExToVector128<T>(this Vector64<T> vector) where T : struct {
            return vector.ExAsUInt64().ToVector128().ExAs<ulong, T>();
        }

        /// <summary>Converts the given vector to a new <see cref="Vector128{T}" /> with the lower 64-bits set to the value of the given vector and the upper 64-bits left uninitialized (将给定向量转换为新 <see cref="Vector128{T}" /> 向量，其中低 64 位设置为给定向量的值，而高 64 位则未初始化).</summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to extend (要扩展的向量).</param>
        /// <returns>A new <see cref="Vector128{T}" /> with the lower 64-bits set to the value of <paramref name="vector" /> and the upper 64-bits left uninitialized (一个新的 <see cref="Vector128{T}" />, 将较低的 64 位设置为 <paramref name="vector" />的值， 而高 64 位保留未初始化).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> ExToVector128Unsafe<T>(this Vector64<T> vector) where T : struct {
            return vector.ExAsUInt64().ToVector128Unsafe().ExAs<ulong, T>();
        }

#endif
    }
}
