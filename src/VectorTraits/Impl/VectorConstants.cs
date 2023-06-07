using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Extensions.SameW;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants used in <see cref="Vector{T}"/> methods (<see cref="Vector{T}"/> 方法所用的常数).
    /// </summary>
    public static class VectorConstants {

        #region Vectors_T
        // == Vectors_T: originate from Vectors<T> ==

        /// <summary>Sign mask (符号掩码) - Single.</summary>
        public static Vector<float> SignMask_Single {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<uint>(0x80000000U).AsSingle(); // .NET5+ has better performance .
#else
                return Vectors<float>.SignMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Sign mask (符号掩码) - Double.</summary>
        public static Vector<double> SignMask_Double {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<ulong>(0x8000000000000000L).AsDouble();
#else
                return Vectors<double>.SignMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Exponent mask (指数掩码) - Single.</summary>
        public static Vector<float> ExponentMask_Single {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<int>(0x7F800000).AsSingle();
#else
                return Vectors<float>.ExponentMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Exponent mask (指数掩码) - Double.</summary>
        public static Vector<double> ExponentMask_Double {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<long>(0x7FF0000000000000L).AsDouble();
#else
                return Vectors<double>.ExponentMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Mantissa mask (尾数掩码) - Single.</summary>
        public static Vector<float> MantissaMask_Single {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<int>(0x007FFFFF).AsSingle();
#else
                return Vectors<float>.MantissaMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Mantissa mask (尾数掩码) - Double.</summary>
        public static Vector<double> MantissaMask_Double {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<long>(0x000FFFFFFFFFFFFFL).AsDouble();
#else
                return Vectors<double>.MantissaMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Value 255 (byte.MaxValue) - UInt16.</summary>
        [CLSCompliant(false)]
        public static Vector<ushort> VMaxByte_UInt16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<ushort>((ushort)byte.MaxValue);
#else
                return Vectors<ushort>.VMaxByte;
#endif // NET5_0_OR_GREATER
            }
        }


        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - SByte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net6+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> GetMaskBits_SByte(int index) {
            return GetMaskBits_Byte(index).AsSByte();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Byte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net6+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> GetMaskBits_Byte(int index) {
            return new Vector<byte>((byte)((1U << index) - 1));
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net6+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> GetMaskBits_Int16(int index) {
            return GetMaskBits_UInt16(index).AsInt16();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net6+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> GetMaskBits_UInt16(int index) {
            return new Vector<ushort>((ushort)((1U << index) - 1));
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net6+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> GetMaskBits_Int32(int index) {
            return GetMaskBits_UInt32(index).AsInt32();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net6+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> GetMaskBits_UInt32(int index) {
            return new Vector<uint>((uint)((1U << index) - 1));
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net6+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> GetMaskBits_Int64(int index) {
            return GetMaskBits_UInt64(index).AsInt64();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码). The equivalent of <c>Vectors.Create(Scalars.GetBitsMask&lt;T&gt;(0, index))</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>ElementBitSize</c> (值的范围是 0 ~ <c>ElementBitSize</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net6+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> GetMaskBits_UInt64(int index) {
            return new Vector<ulong>((ulong)((1UL << index) - 1));
        }

        #endregion // Vectors_T

        #region Shared
        // == Shared ==

        #endregion // Shared

        #region TraitsMethod
        // == TraitsMethod ==

        #endregion // TraitsMethod


    }
}
