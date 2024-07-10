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

    partial class Vector512s {
#if NET8_0_OR_GREATER

        /// <summary>
        /// Returns a value that indicates whether this instance is binary equal to a specified vector (返回一个值，该值指示此实例是否与指定的向量二进制相等).
        /// </summary>
        /// <typeparam name="T">The type of the vector element (向量元素的类型).</typeparam>
        /// <param name="vector">Current vector (当前的向量).</param>
        /// <param name="other">Another vector (另一个向量).</param>
        /// <returns><c>true</c> if <paramref name="other"/> has the same value as this instance; otherwise, <c>false</c> (当 <paramref name="other"/> 相等时返回 <c>true</c>, 否则为 <c>false</c>).</returns>
        public static bool BitEquals<T>(this Vector512<T> vector, Vector512<T> other) where T : struct {
            return vector.ExAsUInt64().Equals(other.ExAsUInt64());
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> of type <typeparamref name="TFrom"/> as a new <see cref="Vector512{T}" /> of type <typeparamref name="TTo"/>. It supports ExType, so there is no element type check (将 <typeparamref name="TFrom"/> 类型的 <see cref="Vector512{T}" /> 重新解释为 <typeparamref name="TTo"/> 类型的新 <see cref="Vector512{T}" />. 它支持扩展类型, 故没有元素类型检查).
        /// </summary>
        /// <typeparam name="TFrom">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <typeparam name="TTo">The type that the vector <paramref name="vector"/> should be reinterpreted as (向量 <paramref name="vector"/> 应重新解释为的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a <see cref="Vector512{T}" /> of type <typeparamref name="TTo"/> (重新解释为 <typeparamref name="TTo"/> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<TTo> ExAs<TFrom, TTo>(this Vector512<TFrom> vector) where TFrom : struct where TTo : struct {
            return Unsafe.As<Vector512<TFrom>, Vector512<TTo>>(ref vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="float" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="float" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="float" /> (重新解释为 <see cref="float" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> ExAsSingle<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, float>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="double" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="double" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="double" /> (重新解释为 <see cref="double" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> ExAsDouble<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, double>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="sbyte" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="sbyte" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="sbyte" /> (重新解释为 <see cref="sbyte" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ExAsSByte<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, sbyte>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="byte" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="byte" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="byte" /> (重新解释为 <see cref="byte" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ExAsByte<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, byte>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="short" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="short" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="short" /> (重新解释为 <see cref="short" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ExAsInt16<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, short>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="ushort" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="ushort" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="ushort" /> (重新解释为 <see cref="ushort" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ExAsUInt16<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, ushort>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="int" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="int" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="int" /> (重新解释为 <see cref="int" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ExAsInt32<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, int>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="uint" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="uint" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="uint" /> (重新解释为 <see cref="uint" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ExAsUInt32<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, uint>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="long" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="long" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="long" /> (重新解释为 <see cref="long" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ExAsInt64<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, long>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="ulong" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="ulong" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="ulong" /> (重新解释为 <see cref="ulong" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ExAsUInt64<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, ulong>(vector);
        }

#if BCL_TYPE_INT128

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="Int128" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="Int128" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="Int128" /> (重新解释为 <see cref="Int128" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> ExAsInt128<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, Int128>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="UInt128" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="UInt128" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="UInt128" /> (重新解释为 <see cref="UInt128" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> ExAsUInt128<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, UInt128>(vector);
        }
#endif // BCL_TYPE_INT128

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="ExInt128" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="ExInt128" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="ExInt128" /> (重新解释为 <see cref="ExInt128" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> ExAsExInt128<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, ExInt128>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}" /> as a new <see cref="Vector512{T}" /> of type <see cref="ExUInt128" /> (将 <see cref="Vector512{T}" /> 重新解释为 <see cref="ExUInt128" /> 类型的新 <see cref="Vector512{T}" />).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector512{T}" /> of type <see cref="ExUInt128" /> (重新解释为 <see cref="ExUInt128" /> 类型的 <see cref="Vector512{T}" /> 向量).</returns>
        /// <seealso cref="ExAs{TFrom, TTo}(Vector512{TFrom})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> ExAsExUInt128<T>(this Vector512<T> vector) where T : struct {
            return ExAs<T, ExUInt128>(vector);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector512{T}"/> as a new <see cref="Vector{T}"/> (将 <see cref="Vector512{T}"/> 重新解释为新的 <see cref="Vector{T}"/>). It supports ExType, so there is no element type check (它支持扩展类型, 故没有元素类型检查).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>value reinterpreted as a new <see cref="Vector{T}"/> (重新解释后新的 <see cref="Vector{T}"/>)值.</returns>
        /// <seealso cref="Vector512.AsVector{T}(Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> ExAsVector<T>(this Vector512<T> value) where T : struct {
            return Vectors.AsVector(value);
        }

        /// <summary>
        /// (ExType) Reinterprets a <see cref="Vector{T}"/> as a new <see cref="Vector512{T}"/> (将 <see cref="Vector{T}"/> 重新解释为新的 <see cref="Vector512{T}"/>). It supports ExType, so there is no element type check (它支持扩展类型, 故没有元素类型检查).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>value reinterpreted as a new <see cref="Vector512{T}"/> (重新解释后新的 <see cref="Vector512{T}"/>)值.</returns>
        /// <seealso cref="Vector512.AsVector512{T}(Vector{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> ExAsVector512<T>(this Vector<T> value) where T : struct {
            return Vectors.AsVector512(value);
        }

        /// <summary>
        /// (ExType) Gets the element at the specified index. It is unsafe method, it ignores the index range check (获取指定索引处的元素. 它是非安全的, 它忽略了索引的范围检查).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to get the element from (要从中获取元素的向量).</param>
        /// <param name="index">The index of the element to get (要获取的元素的索引).</param>
        /// <returns>The element at the specified index(指定索引处的元素).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ExGetElement<T>(in this Vector512<T> vector, int index) where T : struct {
            ref T address = ref Unsafe.As<Vector512<T>, T>(ref Unsafe.AsRef(in vector));
            return Unsafe.Add(ref address, index);
        }

        /// <summary>Gets the value of the lower 256-bits as a new <see cref="Vector256{T}" /> (获取低 256 位的值作为新的 <see cref="Vector256{T}" />).</summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to get the lower 256-bits from (要从中获取低 256 位的向量).</param>
        /// <returns>The value of the lower 256-bits as a new <see cref="Vector256{T}" /> (低 256 位的值作为新的 <see cref="Vector256{T}" />).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> ExGetLower<T>(this Vector512<T> vector) where T : struct {
            return vector.ExAsUInt64().GetLower().ExAs<ulong, T>();
        }

        /// <summary>Gets the value of the upper 256-bits as a new <see cref="Vector256{T}" /> (获取高 256 位的值作为新的 <see cref="Vector256{T}" />).</summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to get the upper 256-bits from (要从中获取高 256 位的向量).</param>
        /// <returns>The value of the upper 256-bits as a new <see cref="Vector256{T}" /> (高 256 位的值作为新的 <see cref="Vector256{T}" />).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> ExGetUpper<T>(this Vector512<T> vector) where T : struct {
            return vector.ExAsUInt64().GetUpper().ExAs<ulong, T>();
        }

        /// <summary>Converts the given vector to a scalar containing the value of the first element (将给定向量转换为首个元素的值的标量).</summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to get the first element from.</param>
        /// <returns>A scalar <typeparamref name="T" /> containing the value of the first element.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ExToScalar<T>(this Vector512<T> vector) where T : struct {
            return vector.ExGetElement(0);
        }

        /// <summary>Creates a new <see cref="Vector512{T}" /> with the lower 256-bits set to the specified value and the upper 256-bits set to the same value as that in the given vector (创建一个新的 <see cref="Vector512{T}" />，将低 256 位设置为指定值，并将高 256 位设置为与给定向量中的值相同的值).</summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to get the upper 256-bits from (要从中获取高 128 位的向量).</param>
        /// <param name="value">The value of the lower 256-bits (低 128 位).</param>
        /// <returns>A new <see cref="Vector512{T}" /> with the lower 256-bits set to <paramref name="value" /> and the upper 256-bits set to the same value as that in <paramref name="vector" /> (一个新向量，将低 256 位设置为指定值，并将高 256 位设置为与 <paramref name="vector" /> 中的值相同的值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> ExWithLower<T>(this Vector512<T> vector, Vector256<T> value) where T : struct {
            return vector.ExAsUInt64().WithLower(value.ExAsUInt64()).ExAs<ulong, T>();
        }

        /// <summary>Creates a new <see cref="Vector512{T}" /> with the upper 256-bits set to the specified value and the lower 256-bits set to the same value as that in the given vector (创建一个新的 <see cref="Vector512{T}" />，将高 256 位设置为指定值，并将低 256 位设置为与给定向量中的值相同的值).</summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="vector">The vector to get the lower 256-bits from (要从中获取低 128 位的向量).</param>
        /// <param name="value">The value of the upper 256-bits (高 128 位).</param>
        /// <returns>A new <see cref="Vector512{T}" /> with the upper 256-bits set to <paramref name="value" /> and the lower 256-bits set to the same value as that in <paramref name="vector" /> (一个新向量，将高 256 位设置为指定值，并将低 256 位设置为与 <paramref name="vector" /> 中的值相同的值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> ExWithUpper<T>(this Vector512<T> vector, Vector256<T> value) where T : struct {
            return vector.ExAsUInt64().WithUpper(value.ExAsUInt64()).ExAs<ulong, T>();
        }

#endif
    }
}
