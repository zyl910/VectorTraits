//#define FALLBACK_USE_T

#if NETX_0_OR_GREATER
#define USE_VECTOR_CREATE // .NET?+ has better performance .
#else
#endif // NETX_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.ExTypes;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants used in <see cref="Vector{T}"/> methods (<see cref="Vector{T}"/> 方法所用的常数).
    /// </summary>
    public static class VectorConstants {

        #region Vectors_T
        // == Vectors_T: originate from Vectors<T> ==

        // -- Vectors_T: Vectors<Single> --

        /// <inheritdoc cref="ScalarConstants.Single_SignMask"/>
        public static Vector<float> Single_SignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return new Vector<long>(ScalarConstants.Single_SignMask).AsSingle();
#else
                return Vectors<float>.SignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_ExponentMask"/>
        public static Vector<float> Single_ExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vectors<float>.ExponentMask;
                return new Vector<float>(ScalarConstants.SingleVal_ExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_MantissaMask"/>
        public static Vector<float> Single_MantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vectors<float>.MantissaMask;
                return new Vector<float>(ScalarConstants.SingleVal_MantissaMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonSignMask"/>
        public static Vector<float> Single_NonSignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return new Vector<long>(ScalarConstants.Single_NonSignMask).AsSingle();
#else
                return Vectors<float>.NonSignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonExponentMask"/>
        public static Vector<float> Single_NonExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vectors<float>.NonExponentMask;
                return new Vector<float>(ScalarConstants.SingleVal_NonExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonMantissaMask"/>
        public static Vector<float> Single_NonMantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vectors<float>.NonMantissaMask;
                return new Vector<float>(ScalarConstants.SingleVal_NonMantissaMask);
            }
        }

        // -- Vectors_T: Vectors<Double> --

        /// <inheritdoc cref="ScalarConstants.Double_SignMask"/>
        public static Vector<double> Double_SignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return new Vector<long>(ScalarConstants.Double_SignMask).AsDouble();
#else
                return Vectors<double>.SignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_ExponentMask"/>
        public static Vector<double> Double_ExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vectors<double>.ExponentMask;
                return new Vector<double>(ScalarConstants.DoubleVal_ExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_MantissaMask"/>
        public static Vector<double> Double_MantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vectors<double>.MantissaMask;
                return new Vector<double>(ScalarConstants.DoubleVal_MantissaMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonSignMask"/>
        public static Vector<double> Double_NonSignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return new Vector<long>(ScalarConstants.Double_NonSignMask).AsDouble();
#else
                return Vectors<double>.NonSignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonExponentMask"/>
        public static Vector<double> Double_NonExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vectors<double>.NonExponentMask;
                return new Vector<double>(ScalarConstants.DoubleVal_NonExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonMantissaMask"/>
        public static Vector<double> Double_NonMantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vectors<double>.NonMantissaMask;
                return new Vector<double>(ScalarConstants.DoubleVal_NonMantissaMask);
            }
        }

        // -- Vectors_T: Vectors<Byte> --

        /// <inheritdoc cref="Vectors{T}.V1"/>
        /// <remarks>For Byte.</remarks>
        public static Vector<byte> Byte_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector<byte>.One;
#elif USE_VECTOR_CREATE
                return new Vector<byte>((byte)1);
#else
                return Vectors<byte>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vectors<Int16> --

        /// <inheritdoc cref="Vectors{T}.V1"/>
        /// <remarks>For Int16.</remarks>
        public static Vector<short> Int16_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector<short>.One;
#elif USE_VECTOR_CREATE
                return new Vector<short>((short)1);
#else
                return Vectors<short>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vectors<UInt16> --

        /// <inheritdoc cref="Vectors{T}.VMaxByte"/>
        /// <remarks>For UInt16.</remarks>
        [CLSCompliant(false)]
        public static Vector<ushort> UInt16_VMaxByte {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return new Vector<ushort>((ushort)byte.MaxValue);
#else
                return Vectors<ushort>.VMaxByte;
#endif // USE_VECTOR_CREATE
            }
        }

        // -- Vectors_T: Vectors<Int32> --

        /// <inheritdoc cref="Vectors{T}.V1"/>
        /// <remarks>For Int32.</remarks>
        public static Vector<int> Int32_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector<int>.One;
#elif USE_VECTOR_CREATE
                return new Vector<int>(1);
#else
                return Vectors<int>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vectors<Int64> --

        /// <inheritdoc cref="Vectors{T}.V1"/>
        /// <remarks>For Int64.</remarks>
        public static Vector<long> Int64_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector<long>.One;
#elif USE_VECTOR_CREATE_INT64
                return new Vector<long>(1L);
#else
                return Vectors<long>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        /// <inheritdoc cref="Vectors{T}.MinValue"/>
        /// <remarks>For Int64.</remarks>
        public static Vector<long> Int64_MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return new Vector<long>(long.MinValue);
#else
                return Vectors<long>.MinValue;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <summary>Int64 - `long.MinValue + 4 = 0x8000000000000004 = -9223372036854775804`.</summary>
        public static Vector<long> Int64_MinValue_4 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => new Vector<long>(long.MinValue + 4);
        }
#else
            get;
        } = new Vector<long>(long.MinValue + 4);
#endif // USE_VECTOR_CREATE

        /// <inheritdoc cref="Vectors{T}.VMaxInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector<long> Int64_VMaxInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return new Vector<long>((long)int.MaxValue);
#else
                return Vectors<long>.VMaxInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vectors{T}.VMinInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector<long> Int64_VMinInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return new Vector<long>((long)int.MinValue);
#else
                return Vectors<long>.VMinInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vectors{T}.VMaxUInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector<long> Int64_VMaxUInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return new Vector<long>(ScalarConstants.Int_VMaxUInt32);
#else
                return Vectors<long>.VMaxUInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        // -- Vectors_T: others --


        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> GetMaskBits<T>(int index) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                return GetMaskBits_SByte(index).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T)) {
                return GetMaskBits_Byte(index).As<byte, T>();
            } else if (typeof(short) == typeof(T)) {
                return GetMaskBits_Int16(index).As<short, T>();
            } else if (typeof(ushort) == typeof(T)) {
                return GetMaskBits_UInt16(index).As<ushort, T>();
            } else if (typeof(int) == typeof(T)) {
                return GetMaskBits_Int32(index).As<int, T>();
            } else if (typeof(uint) == typeof(T)) {
                return GetMaskBits_UInt32(index).As<uint, T>();
            } else if (typeof(long) == typeof(T)) {
                return GetMaskBits_Int64(index).As<long, T>();
            } else if (typeof(ulong) == typeof(T)) {
                return GetMaskBits_UInt64(index).As<ulong, T>();
            } else if (typeof(ExInt128) == typeof(T)) {
                return GetMaskBits_ExInt128(index).ExAs<ExInt128, T>();
            } else if (typeof(ExUInt128) == typeof(T)) {
                return GetMaskBits_ExUInt128(index).ExAs<ExUInt128, T>();
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return GetMaskBits_Int128(index).ExAs<Int128, T>();
            } else if (typeof(UInt128) == typeof(T)) {
                return GetMaskBits_UInt128(index).ExAs<UInt128, T>();
#endif // BCL_TYPE_INT128
            } else {
#if FALLBACK_USE_T
                return Vectors<T>.GetMaskBits(index);
#else
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
#endif // FALLBACK_USE_T
            }
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - SByte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
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
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> GetMaskBits_Byte(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return new Vector<byte>((byte)((1U << index) - 1));
#else
            return Vectors<byte>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
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
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> GetMaskBits_UInt16(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return new Vector<ushort>((ushort)((1U << index) - 1));
#else
            return Vectors<ushort>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
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
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> GetMaskBits_UInt32(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return new Vector<uint>((uint)((1U << index) - 1));
#else
            return Vectors<uint>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> GetMaskBits_Int64(int index) {
            return GetMaskBits_UInt64(index).AsInt64();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> GetMaskBits_UInt64(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return new Vector<ulong>((ulong)((1UL << index) - 1));
#else
            return Vectors<ulong>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - ExInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExInt128> GetMaskBits_ExInt128(int index) {
            return GetMaskBits_ExUInt128(index).ExAsExInt128();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - ExUInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExUInt128> GetMaskBits_ExUInt128(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vectors.Create((ExUInt128)(((ExUInt128)1UL << index) - 1));
#else
            return Vectors<ExUInt128>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

#if BCL_TYPE_INT128

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> GetMaskBits_Int128(int index) {
            return GetMaskBits_ExUInt128(index).ExAsInt128();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> GetMaskBits_UInt128(int index) {
            return GetMaskBits_ExUInt128(index).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetResidueMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> GetResidueMaskBits<T>(int index) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                return GetResidueMaskBits_SByte(index).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T)) {
                return GetResidueMaskBits_Byte(index).As<byte, T>();
            } else if (typeof(short) == typeof(T)) {
                return GetResidueMaskBits_Int16(index).As<short, T>();
            } else if (typeof(ushort) == typeof(T)) {
                return GetResidueMaskBits_UInt16(index).As<ushort, T>();
            } else if (typeof(int) == typeof(T)) {
                return GetResidueMaskBits_Int32(index).As<int, T>();
            } else if (typeof(uint) == typeof(T)) {
                return GetResidueMaskBits_UInt32(index).As<uint, T>();
            } else if (typeof(long) == typeof(T)) {
                return GetResidueMaskBits_Int64(index).As<long, T>();
            } else if (typeof(ulong) == typeof(T)) {
                return GetResidueMaskBits_UInt64(index).As<ulong, T>();
            } else if (typeof(ExInt128) == typeof(T)) {
                return GetResidueMaskBits_ExInt128(index).ExAs<ExInt128, T>();
            } else if (typeof(ExUInt128) == typeof(T)) {
                return GetResidueMaskBits_ExUInt128(index).ExAs<ExUInt128, T>();
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return GetResidueMaskBits_Int128(index).ExAs<Int128, T>();
            } else if (typeof(UInt128) == typeof(T)) {
                return GetResidueMaskBits_UInt128(index).ExAs<UInt128, T>();
#endif // BCL_TYPE_INT128
            } else {
#if FALLBACK_USE_T
                return Vectors<T>.GetMaskBits(Scalars<T>.BitSize - index);
#else
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
#endif // FALLBACK_USE_T
            }
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - SByte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetResidueMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> GetResidueMaskBits_SByte(int index) {
            return GetResidueMaskBits_Byte(index).AsSByte();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Byte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> GetResidueMaskBits_Byte(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return new Vector<byte>((byte)(byte.MaxValue >> index));
#else
            return Vectors<byte>.GetMaskBits(8 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> GetResidueMaskBits_Int16(int index) {
            return GetResidueMaskBits_UInt16(index).AsInt16();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> GetResidueMaskBits_UInt16(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return new Vector<ushort>((ushort)(ushort.MaxValue >> index));
#else
            return Vectors<ushort>.GetMaskBits(16 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> GetResidueMaskBits_Int32(int index) {
            return GetResidueMaskBits_UInt32(index).AsInt32();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> GetResidueMaskBits_UInt32(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return new Vector<uint>((uint)(uint.MaxValue >> index));
#else
            return Vectors<uint>.GetMaskBits(32 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> GetResidueMaskBits_Int64(int index) {
            return GetResidueMaskBits_UInt64(index).AsInt64();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> GetResidueMaskBits_UInt64(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return new Vector<ulong>((ulong)(ulong.MaxValue >> index));
#else
            return Vectors<ulong>.GetMaskBits(64 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - ExInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExInt128> GetResidueMaskBits_ExInt128(int index) {
            return GetResidueMaskBits_ExUInt128(index).ExAsExInt128();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - ExUInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExUInt128> GetResidueMaskBits_ExUInt128(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vectors.Create((ExUInt128)(ExUInt128.MaxValue >> index));
#else
            return Vectors<ExUInt128>.GetMaskBits(64 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

#if BCL_TYPE_INT128

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> GetResidueMaskBits_Int128(int index) {
            return GetResidueMaskBits_ExUInt128(index).ExAsInt128();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vectors&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vectors{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vectors{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> GetResidueMaskBits_UInt128(int index) {
            return GetResidueMaskBits_ExUInt128(index).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        #endregion // Vectors_T

        #region Shared
        // == Shared ==

        #endregion // Shared

        #region TraitsMethod
        // == TraitsMethod ==

        #endregion // TraitsMethod


    }
}
