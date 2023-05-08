#if !OFF_VECTOR_TUPLES
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;

namespace Zyl.VectorTraits.Tuples {
    /// <summary>
    /// Provides static methods for creating <see cref="Vector256"/> tuples (提供用于创建向量256元组的静态方法).
    /// </summary>
    public static partial class Vector256XTuple {

        /// <summary>
        /// Creates a new vector tuple with 2 components (创建含有 2 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="item1">The value of the 1st component (第1个组件的值).</param>
        /// <param name="item2">The value of the 2nd component (第2个组件的值).</param>
        /// <returns>A vector tuple with 2 components (具有2个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<T> Create<T>(Vector256<T> item1, Vector256<T> item2) where T : struct {
            return new Vector256X2<T>((item1, item2));
        }

        /// <summary>
        /// Creates a new vector tuple with 3 components (创建含有 3 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="item1">The value of the 1st component (第1个组件的值).</param>
        /// <param name="item2">The value of the 2nd component (第2个组件的值).</param>
        /// <param name="item3">The value of the 3rd component (第3个组件的值).</param>
        /// <returns>A vector tuple with 3 components (具有3个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X3<T> Create<T>(Vector256<T> item1, Vector256<T> item2, Vector256<T> item3) where T : struct {
            return new Vector256X3<T>((item1, item2, item3));
        }

        /// <summary>
        /// Creates a new vector tuple with 4 components (创建含有 4 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="item1">The value of the 1st component (第1个组件的值).</param>
        /// <param name="item2">The value of the 2nd component (第2个组件的值).</param>
        /// <param name="item3">The value of the 3rd component (第3个组件的值).</param>
        /// <param name="item4">The value of the 4th component (第4个组件的值).</param>
        /// <returns>A vector tuple with 4 components (具有4个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X4<T> Create<T>(Vector256<T> item1, Vector256<T> item2, Vector256<T> item3, Vector256<T> item4) where T : struct {
            return new Vector256X4<T>((item1, item2, item3, item4));
        }

        /// <summary>
        /// Creates a new vector tuple with 5 components (创建含有 5 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="item1">The value of the 1st component (第1个组件的值).</param>
        /// <param name="item2">The value of the 2nd component (第2个组件的值).</param>
        /// <param name="item3">The value of the 3rd component (第3个组件的值).</param>
        /// <param name="item4">The value of the 4th component (第4个组件的值).</param>
        /// <param name="item5">The value of the 5th component (第5个组件的值).</param>
        /// <returns>A vector tuple with 5 components (具有5个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X5<T> Create<T>(Vector256<T> item1, Vector256<T> item2, Vector256<T> item3, Vector256<T> item4, Vector256<T> item5) where T : struct {
            return new Vector256X5<T>((item1, item2, item3, item4, item5));
        }

        /// <summary>
        /// Creates a new vector tuple with 6 components (创建含有 6 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="item1">The value of the 1st component (第1个组件的值).</param>
        /// <param name="item2">The value of the 2nd component (第2个组件的值).</param>
        /// <param name="item3">The value of the 3rd component (第3个组件的值).</param>
        /// <param name="item4">The value of the 4th component (第4个组件的值).</param>
        /// <param name="item5">The value of the 5th component (第5个组件的值).</param>
        /// <param name="item6">The value of the 6th component (第6个组件的值).</param>
        /// <returns>A vector tuple with 6 components (具有6个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X6<T> Create<T>(Vector256<T> item1, Vector256<T> item2, Vector256<T> item3, Vector256<T> item4, Vector256<T> item5, Vector256<T> item6) where T : struct {
            return new Vector256X6<T>((item1, item2, item3, item4, item5, item6));
        }

        /// <summary>
        /// Creates a new vector tuple with 7 components (创建含有 7 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="item1">The value of the 1st component (第1个组件的值).</param>
        /// <param name="item2">The value of the 2nd component (第2个组件的值).</param>
        /// <param name="item3">The value of the 3rd component (第3个组件的值).</param>
        /// <param name="item4">The value of the 4th component (第4个组件的值).</param>
        /// <param name="item5">The value of the 5th component (第5个组件的值).</param>
        /// <param name="item6">The value of the 6th component (第6个组件的值).</param>
        /// <param name="item7">The value of the 7th component (第7个组件的值).</param>
        /// <returns>A vector tuple with 7 components (具有7个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X7<T> Create<T>(Vector256<T> item1, Vector256<T> item2, Vector256<T> item3, Vector256<T> item4, Vector256<T> item5, Vector256<T> item6, Vector256<T> item7) where T : struct {
            return new Vector256X7<T>((item1, item2, item3, item4, item5, item6, item7));
        }

        /// <summary>
        /// Creates a new vector tuple with 8 components (创建含有 8 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="item1">The value of the 1st component (第1个组件的值).</param>
        /// <param name="item2">The value of the 2nd component (第2个组件的值).</param>
        /// <param name="item3">The value of the 3rd component (第3个组件的值).</param>
        /// <param name="item4">The value of the 4th component (第4个组件的值).</param>
        /// <param name="item5">The value of the 5th component (第5个组件的值).</param>
        /// <param name="item6">The value of the 6th component (第6个组件的值).</param>
        /// <param name="item7">The value of the 7th component (第7个组件的值).</param>
        /// <param name="item8">The value of the 8th component (第8个组件的值).</param>
        /// <returns>A vector tuple with 8 components (具有8个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X8<T> Create<T>(Vector256<T> item1, Vector256<T> item2, Vector256<T> item3, Vector256<T> item4, Vector256<T> item5, Vector256<T> item6, Vector256<T> item7, Vector256<T> item8) where T : struct {
            return new Vector256X8<T>((item1, item2, item3, item4, item5, item6, item7, item8));
        }

        /// <summary>
        /// Creates a new vector tuple with 2 components by ValueTuple (根据值元组, 创建含有 2 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="val">The value (值).</param>
        /// <returns>A vector tuple with 2 components (具有2个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<T> Create<T>((Vector256<T>, Vector256<T>) val) where T : struct {
            return new Vector256X2<T>(val);
        }

        /// <summary>
        /// Creates a new vector tuple with 3 components by ValueTuple (根据值元组, 创建含有 3 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="val">The value (值).</param>
        /// <returns>A vector tuple with 3 components (具有3个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X3<T> Create<T>((Vector256<T>, Vector256<T>, Vector256<T>) val) where T : struct {
            return new Vector256X3<T>(val);
        }

        /// <summary>
        /// Creates a new vector tuple with 4 components by ValueTuple (根据值元组, 创建含有 4 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="val">The value (值).</param>
        /// <returns>A vector tuple with 4 components (具有4个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X4<T> Create<T>((Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>) val) where T : struct {
            return new Vector256X4<T>(val);
        }

        /// <summary>
        /// Creates a new vector tuple with 5 components by ValueTuple (根据值元组, 创建含有 5 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="val">The value (值).</param>
        /// <returns>A vector tuple with 5 components (具有5个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X5<T> Create<T>((Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>) val) where T : struct {
            return new Vector256X5<T>(val);
        }

        /// <summary>
        /// Creates a new vector tuple with 6 components by ValueTuple (根据值元组, 创建含有 6 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="val">The value (值).</param>
        /// <returns>A vector tuple with 6 components (具有6个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X6<T> Create<T>((Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>) val) where T : struct {
            return new Vector256X6<T>(val);
        }

        /// <summary>
        /// Creates a new vector tuple with 7 components by ValueTuple (根据值元组, 创建含有 7 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="val">The value (值).</param>
        /// <returns>A vector tuple with 7 components (具有7个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X7<T> Create<T>((Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>) val) where T : struct {
            return new Vector256X7<T>(val);
        }

        /// <summary>
        /// Creates a new vector tuple with 8 components by ValueTuple (根据值元组, 创建含有 8 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="val">The value (值).</param>
        /// <returns>A vector tuple with 8 components (具有8个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X8<T> Create<T>((Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>) val) where T : struct {
            return new Vector256X8<T>(val);
        }


        /// <summary>Reinterprets a <see cref="Vector256X2{T}" /> as a new <see cref="VectorX2{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="VectorX2{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX2<T> AsVector<T>(this Vector256X2<T> value) where T : struct {
            return Unsafe.As<Vector256X2<T>, VectorX2<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="VectorX2{T}" /> as a new <see cref="Vector256X2{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="Vector256X2{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<T> AsVector256<T>(this VectorX2<T> value) where T : struct {
            return Unsafe.As<VectorX2<T>, Vector256X2<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="Vector256X2{TFrom}" /> as a new <see cref="Vector256X2{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="Vector256X2{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<TTo> As<TFrom, TTo>(this Vector256X2<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<Vector256X2<TFrom>, Vector256X2<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<byte> AsByte<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<sbyte> AsSByte<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<ushort> AsUInt16<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<short> AsInt16<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<uint> AsUInt32<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<int> AsInt32<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<ulong> AsUInt64<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<long> AsInt64<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<float> AsSingle<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<double> AsDouble<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<nint> AsNInt<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<nuint> AsNUInt<T>(this Vector256X2<T> value) where T : struct {
            return value.As<T, nuint>();
        }

    }
}
#endif // NETCOREAPP3_0_OR_GREATER
#endif // !OFF_VECTOR_TUPLES
