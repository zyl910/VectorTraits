#if !OFF_VECTOR_TUPLES
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;

namespace Zyl.VectorTraits.Tuples {
    partial class Vector128XTuple {
        // == Vector128X3 ==

        /// <summary>Reinterprets a <see cref="Vector128X3{T}" /> as a new <see cref="VectorX3{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="VectorX3{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<T> AsVector<T>(this Vector128X3<T> value) where T : struct {
            return Unsafe.As<Vector128X3<T>, VectorX3<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="VectorX3{T}" /> as a new <see cref="Vector128X3{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="Vector128X3{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<T> AsVector128<T>(this VectorX3<T> value) where T : struct {
            return Unsafe.As<VectorX3<T>, Vector128X3<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="Vector128X3{TFrom}" /> as a new <see cref="Vector128X3{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="Vector128X3{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<TTo> As<TFrom, TTo>(this Vector128X3<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<Vector128X3<TFrom>, Vector128X3<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<byte> AsByte<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<sbyte> AsSByte<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<ushort> AsUInt16<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<short> AsInt16<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<uint> AsUInt32<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<int> AsInt32<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<ulong> AsUInt64<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<long> AsInt64<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<float> AsSingle<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<double> AsDouble<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<nint> AsNInt<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X3<nuint> AsNUInt<T>(this Vector128X3<T> value) where T : struct {
            return value.As<T, nuint>();
        }

        // == Vector128X4 ==

        /// <summary>Reinterprets a <see cref="Vector128X4{T}" /> as a new <see cref="VectorX4{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="VectorX4{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<T> AsVector<T>(this Vector128X4<T> value) where T : struct {
            return Unsafe.As<Vector128X4<T>, VectorX4<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="VectorX4{T}" /> as a new <see cref="Vector128X4{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="Vector128X4{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<T> AsVector128<T>(this VectorX4<T> value) where T : struct {
            return Unsafe.As<VectorX4<T>, Vector128X4<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="Vector128X4{TFrom}" /> as a new <see cref="Vector128X4{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="Vector128X4{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<TTo> As<TFrom, TTo>(this Vector128X4<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<Vector128X4<TFrom>, Vector128X4<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<byte> AsByte<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<sbyte> AsSByte<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<ushort> AsUInt16<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<short> AsInt16<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<uint> AsUInt32<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<int> AsInt32<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<ulong> AsUInt64<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<long> AsInt64<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<float> AsSingle<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<double> AsDouble<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<nint> AsNInt<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X4<nuint> AsNUInt<T>(this Vector128X4<T> value) where T : struct {
            return value.As<T, nuint>();
        }

        // == Vector128X5 ==

        /// <summary>Reinterprets a <see cref="Vector128X5{T}" /> as a new <see cref="VectorX5{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="VectorX5{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<T> AsVector<T>(this Vector128X5<T> value) where T : struct {
            return Unsafe.As<Vector128X5<T>, VectorX5<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="VectorX5{T}" /> as a new <see cref="Vector128X5{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="Vector128X5{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<T> AsVector128<T>(this VectorX5<T> value) where T : struct {
            return Unsafe.As<VectorX5<T>, Vector128X5<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="Vector128X5{TFrom}" /> as a new <see cref="Vector128X5{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="Vector128X5{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<TTo> As<TFrom, TTo>(this Vector128X5<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<Vector128X5<TFrom>, Vector128X5<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<byte> AsByte<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<sbyte> AsSByte<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<ushort> AsUInt16<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<short> AsInt16<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<uint> AsUInt32<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<int> AsInt32<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<ulong> AsUInt64<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<long> AsInt64<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<float> AsSingle<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<double> AsDouble<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<nint> AsNInt<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X5<nuint> AsNUInt<T>(this Vector128X5<T> value) where T : struct {
            return value.As<T, nuint>();
        }

        // == Vector128X6 ==

        /// <summary>Reinterprets a <see cref="Vector128X6{T}" /> as a new <see cref="VectorX6{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="VectorX6{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<T> AsVector<T>(this Vector128X6<T> value) where T : struct {
            return Unsafe.As<Vector128X6<T>, VectorX6<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="VectorX6{T}" /> as a new <see cref="Vector128X6{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="Vector128X6{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<T> AsVector128<T>(this VectorX6<T> value) where T : struct {
            return Unsafe.As<VectorX6<T>, Vector128X6<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="Vector128X6{TFrom}" /> as a new <see cref="Vector128X6{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="Vector128X6{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<TTo> As<TFrom, TTo>(this Vector128X6<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<Vector128X6<TFrom>, Vector128X6<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<byte> AsByte<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<sbyte> AsSByte<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<ushort> AsUInt16<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<short> AsInt16<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<uint> AsUInt32<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<int> AsInt32<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<ulong> AsUInt64<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<long> AsInt64<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<float> AsSingle<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<double> AsDouble<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<nint> AsNInt<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X6<nuint> AsNUInt<T>(this Vector128X6<T> value) where T : struct {
            return value.As<T, nuint>();
        }

        // == Vector128X7 ==

        /// <summary>Reinterprets a <see cref="Vector128X7{T}" /> as a new <see cref="VectorX7{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="VectorX7{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<T> AsVector<T>(this Vector128X7<T> value) where T : struct {
            return Unsafe.As<Vector128X7<T>, VectorX7<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="VectorX7{T}" /> as a new <see cref="Vector128X7{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="Vector128X7{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<T> AsVector128<T>(this VectorX7<T> value) where T : struct {
            return Unsafe.As<VectorX7<T>, Vector128X7<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="Vector128X7{TFrom}" /> as a new <see cref="Vector128X7{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="Vector128X7{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<TTo> As<TFrom, TTo>(this Vector128X7<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<Vector128X7<TFrom>, Vector128X7<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<byte> AsByte<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<sbyte> AsSByte<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<ushort> AsUInt16<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<short> AsInt16<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<uint> AsUInt32<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<int> AsInt32<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<ulong> AsUInt64<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<long> AsInt64<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<float> AsSingle<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<double> AsDouble<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<nint> AsNInt<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X7<nuint> AsNUInt<T>(this Vector128X7<T> value) where T : struct {
            return value.As<T, nuint>();
        }

        // == Vector128X8 ==

        /// <summary>Reinterprets a <see cref="Vector128X8{T}" /> as a new <see cref="VectorX8{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="VectorX8{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<T> AsVector<T>(this Vector128X8<T> value) where T : struct {
            return Unsafe.As<Vector128X8<T>, VectorX8<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="VectorX8{T}" /> as a new <see cref="Vector128X8{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="Vector128X8{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<T> AsVector128<T>(this VectorX8<T> value) where T : struct {
            return Unsafe.As<VectorX8<T>, Vector128X8<T>>(ref value);
        }

        /// <summary>Reinterprets a <see cref="Vector128X8{TFrom}" /> as a new <see cref="Vector128X8{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="Vector128X8{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<TTo> As<TFrom, TTo>(this Vector128X8<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<Vector128X8<TFrom>, Vector128X8<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<byte> AsByte<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<sbyte> AsSByte<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<ushort> AsUInt16<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<short> AsInt16<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<uint> AsUInt32<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<int> AsInt32<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<ulong> AsUInt64<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<long> AsInt64<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<float> AsSingle<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<double> AsDouble<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<nint> AsNInt<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128X8<nuint> AsNUInt<T>(this Vector128X8<T> value) where T : struct {
            return value.As<T, nuint>();
        }

    } // End: class
} // End: namespace
#endif // NETCOREAPP3_0_OR_GREATER
#endif // !OFF_VECTOR_TUPLES
