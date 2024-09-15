﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Extensions.SameW {
    /// <summary>
    /// <see cref="Vector"/> same WVector(e.g. Vector256) extensions.
    /// </summary>
    public static class VectorSameWExtensions {

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> AsByte<T>(this Vector<T> value) where T : struct {
            return (Vector<byte>)value;
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of signed bytes.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> AsSByte<T>(this Vector<T> value) where T : struct {
            return (Vector<sbyte>)value;
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> AsUInt16<T>(this Vector<T> value) where T : struct {
            return (Vector<ushort>)value;
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of 16-bit integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> AsInt16<T>(this Vector<T> value) where T : struct {
            return (Vector<short>)value;
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> AsUInt32<T>(this Vector<T> value) where T : struct {
            return (Vector<uint>)value;
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> AsInt32<T>(this Vector<T> value) where T : struct {
            return (Vector<int>)value;
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> AsUInt64<T>(this Vector<T> value) where T : struct {
            return (Vector<ulong>)value;
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of long integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> AsInt64<T>(this Vector<T> value) where T : struct {
            return (Vector<long>)value;
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a single-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> AsSingle<T>(this Vector<T> value) where T : struct {
            return (Vector<float>)value;
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a double-precision floating-point vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> AsDouble<T>(this Vector<T> value) where T : struct {
            return (Vector<double>)value;
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<nint> AsNInt<T>(this Vector<T> value) where T : struct {
#if NET6_0_OR_GREATER
            return (Vector<nint>)value;
#else
            return Unsafe.As<Vector<T>, Vector<nint>>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>Reinterprets the bits of a specified vector into those of a vector of unsigned native integers.</summary>
        /// <param name="value">The source vector.</param>
        /// <typeparam name="T">The vector type. <typeparamref name="T" /> can be any primitive numeric type.</typeparam>
        /// <returns>The reinterpreted vector.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<nuint> AsNUInt<T>(this Vector<T> value) where T : struct {
#if NET6_0_OR_GREATER
            return (Vector<nuint>)value;
#else
            return Unsafe.As<Vector<T>, Vector<nuint>>(ref value);
#endif // NET6_0_OR_GREATER
        }

#if NET6_0_OR_GREATER
#else
        /// <summary>
        /// Reinterprets a <see langword="Vector&lt;TFrom&gt;" /> as a new <see langword="Vector&lt;TTo&gt;" /> (将 <see langword="Vector&lt;TFrom&gt;" /> 重新解释为新的 <see langword="Vector&lt;TTo&gt;" />).
        /// </summary>
        /// <typeparam name="TFrom">The type of the input vector (输入向量的类型).</typeparam>
        /// <typeparam name="TTo">The type of the vector vector should be reinterpreted as (向量 vector 的类型应重新解释为).</typeparam>
        /// <param name="vector">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>vector reinterpreted as a new <see cref="Vector{T}"/> (重新解释后的 vector).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<TTo> As<TFrom, TTo>(this Vector<TFrom> vector) where TFrom : struct where TTo : struct {
            return Unsafe.As<Vector<TFrom>, Vector<TTo>>(ref vector);
        }
#endif // NET6_0_OR_GREATER

    }
}
