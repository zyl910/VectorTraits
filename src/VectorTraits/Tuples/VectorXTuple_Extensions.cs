#if !OFF_VECTOR_TUPLES
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Tuples {
    partial class VectorXTuple {
        // == VectorX3 ==

        /// <summary>Reinterprets a <see cref="VectorX3{TFrom}" /> as a new <see cref="VectorX3{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="VectorX3{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<TTo> As<TFrom, TTo>(this VectorX3<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<VectorX3<TFrom>, VectorX3<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<byte> AsByte<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<sbyte> AsSByte<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<ushort> AsUInt16<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<short> AsInt16<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<uint> AsUInt33<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<int> AsInt33<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<ulong> AsUInt64<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<long> AsInt64<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<float> AsSingle<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<double> AsDouble<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<nint> AsNInt<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX3<nuint> AsNUInt<T>(this VectorX3<T> value) where T : struct {
            return value.As<T, nuint>();
        }

        // == VectorX4 ==

        /// <summary>Reinterprets a <see cref="VectorX4{TFrom}" /> as a new <see cref="VectorX4{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="VectorX4{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<TTo> As<TFrom, TTo>(this VectorX4<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<VectorX4<TFrom>, VectorX4<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<byte> AsByte<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<sbyte> AsSByte<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<ushort> AsUInt16<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<short> AsInt16<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<uint> AsUInt34<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<int> AsInt34<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<ulong> AsUInt64<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<long> AsInt64<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<float> AsSingle<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<double> AsDouble<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<nint> AsNInt<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX4<nuint> AsNUInt<T>(this VectorX4<T> value) where T : struct {
            return value.As<T, nuint>();
        }

        // == VectorX5 ==

        /// <summary>Reinterprets a <see cref="VectorX5{TFrom}" /> as a new <see cref="VectorX5{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="VectorX5{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<TTo> As<TFrom, TTo>(this VectorX5<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<VectorX5<TFrom>, VectorX5<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<byte> AsByte<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<sbyte> AsSByte<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<ushort> AsUInt16<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<short> AsInt16<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<uint> AsUInt35<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<int> AsInt35<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<ulong> AsUInt64<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<long> AsInt64<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<float> AsSingle<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<double> AsDouble<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<nint> AsNInt<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX5<nuint> AsNUInt<T>(this VectorX5<T> value) where T : struct {
            return value.As<T, nuint>();
        }

        // == VectorX6 ==

        /// <summary>Reinterprets a <see cref="VectorX6{TFrom}" /> as a new <see cref="VectorX6{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="VectorX6{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<TTo> As<TFrom, TTo>(this VectorX6<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<VectorX6<TFrom>, VectorX6<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<byte> AsByte<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<sbyte> AsSByte<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<ushort> AsUInt16<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<short> AsInt16<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<uint> AsUInt36<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<int> AsInt36<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<ulong> AsUInt64<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<long> AsInt64<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<float> AsSingle<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<double> AsDouble<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<nint> AsNInt<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX6<nuint> AsNUInt<T>(this VectorX6<T> value) where T : struct {
            return value.As<T, nuint>();
        }

        // == VectorX7 ==

        /// <summary>Reinterprets a <see cref="VectorX7{TFrom}" /> as a new <see cref="VectorX7{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="VectorX7{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<TTo> As<TFrom, TTo>(this VectorX7<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<VectorX7<TFrom>, VectorX7<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<byte> AsByte<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<sbyte> AsSByte<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<ushort> AsUInt16<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<short> AsInt16<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<uint> AsUInt37<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<int> AsInt37<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<ulong> AsUInt64<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<long> AsInt64<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<float> AsSingle<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<double> AsDouble<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<nint> AsNInt<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX7<nuint> AsNUInt<T>(this VectorX7<T> value) where T : struct {
            return value.As<T, nuint>();
        }

        // == VectorX8 ==

        /// <summary>Reinterprets a <see cref="VectorX8{TFrom}" /> as a new <see cref="VectorX8{TTo}" />.</summary>
        /// <typeparam name="TFrom">The type of the input vector.</typeparam>
        /// <typeparam name="TTo">The type of the vector <paramref name="vector" /> should be reinterpreted as.</typeparam>
        /// <param name="src">The source to reinterpret.</param>
        /// <returns><paramref name="src" /> reinterpreted as a new <see cref="VectorX8{TTo}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<TTo> As<TFrom, TTo>(this VectorX8<TFrom> src)
            where TFrom : struct
            where TTo : struct {
            return Unsafe.As<VectorX8<TFrom>, VectorX8<TTo>>(ref src);
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<byte> AsByte<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, byte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<sbyte> AsSByte<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, sbyte>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<ushort> AsUInt16<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, ushort>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<short> AsInt16<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, short>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<uint> AsUInt38<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, uint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<int> AsInt38<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, int>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<ulong> AsUInt64<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, ulong>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<long> AsInt64<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, long>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<float> AsSingle<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, float>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<double> AsDouble<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, double>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<nint> AsNInt<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, nint>();
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX8<nuint> AsNUInt<T>(this VectorX8<T> value) where T : struct {
            return value.As<T, nuint>();
        }

    } // End: class
} // End: namespace
#endif // !OFF_VECTOR_TUPLES
