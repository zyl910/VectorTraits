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
        /// Creates a new vector tuple with 2 components by ValueTuple (根据值元组, 创建含有 2 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="val">The value (值).</param>
        /// <returns>A vector tuple with 2 components (具有2个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<T> Create<T>((Vector256<T>, Vector256<T>) val) where T : struct {
            return new Vector256X2<T>(val);
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
