//#define FALLBACK_USE_T

#if NET5_0_OR_GREATER
#define USE_VECTOR_CREATE // .NET5+ has better performance (Without int64/uint64 on 32bit system) .
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define USE_VECTOR_CREATE_INT64 // .NET7+ has better performance of int64/uint64 on 32bit system .
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.ExTypes;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants used in <see cref="Vector64{T}"/> methods (<see cref="Vector64{T}"/> 方法所用的常数).
    /// </summary>
    public static class Vector64Constants {
#if NETCOREAPP3_0_OR_GREATER

        #region Vectors_T
        // == Vectors_T: originate from Vector64s<T> ==

        // -- Vectors_T: Vector64s<Single> --

        /// <inheritdoc cref="ScalarConstants.Single_SignMask"/>
        public static Vector64<float> Single_SignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector64.Create(ScalarConstants.Single_SignMask).AsSingle();
#else
                return Vector64s<float>.SignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_ExponentMask"/>
        public static Vector64<float> Single_ExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector64s<float>.ExponentMask;
                return Vector64.Create(ScalarConstants.SingleVal_ExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_MantissaMask"/>
        public static Vector64<float> Single_MantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector64s<float>.MantissaMask;
                return Vector64.Create(ScalarConstants.SingleVal_MantissaMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonSignMask"/>
        public static Vector64<float> Single_NonSignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector64.Create(ScalarConstants.Single_NonSignMask).AsSingle();
#else
                return Vector64s<float>.NonSignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonExponentMask"/>
        public static Vector64<float> Single_NonExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector64s<float>.NonExponentMask;
                return Vector64.Create(ScalarConstants.SingleVal_NonExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonMantissaMask"/>
        public static Vector64<float> Single_NonMantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector64s<float>.NonMantissaMask;
                return Vector64.Create(ScalarConstants.SingleVal_NonMantissaMask);
            }
        }

        // -- Vectors_T: Vector64s<Double> --

        /// <inheritdoc cref="ScalarConstants.Double_SignMask"/>
        public static Vector64<double> Double_SignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector64.Create(ScalarConstants.Double_SignMask).AsDouble();
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector64.Create(ScalarConstants.Double_SignMask).AsDouble();
                } else {
                    return Vector64s<double>.SignMask;
                }
#else
                return Vector64s<double>.SignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_ExponentMask"/>
        public static Vector64<double> Double_ExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector64s<double>.ExponentMask;
                return Vector64.Create(ScalarConstants.DoubleVal_ExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_MantissaMask"/>
        public static Vector64<double> Double_MantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector64s<double>.MantissaMask;
                return Vector64.Create(ScalarConstants.DoubleVal_MantissaMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonSignMask"/>
        public static Vector64<double> Double_NonSignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector64.Create(ScalarConstants.Double_NonSignMask).AsDouble();
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector64.Create(ScalarConstants.Double_NonSignMask).AsDouble();
                } else {
                    return Vector64s<double>.NonSignMask;
                }
#else
                return Vector64s<double>.NonSignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonExponentMask"/>
        public static Vector64<double> Double_NonExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector64s<double>.NonExponentMask;
                return Vector64.Create(ScalarConstants.DoubleVal_NonExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonMantissaMask"/>
        public static Vector64<double> Double_NonMantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector64s<double>.NonMantissaMask;
                return Vector64.Create(ScalarConstants.DoubleVal_NonMantissaMask);
            }
        }

        // -- Vectors_T: Vector64s<Byte> --

        /// <inheritdoc cref="Vector64s{T}.V1"/>
        /// <remarks>For Byte.</remarks>
        public static Vector64<byte> Byte_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector64<byte>.One;
#elif USE_VECTOR_CREATE
                return Vector64.Create((byte)1);
#else
                return Vector64s<byte>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vector64s<Int16> --

        /// <inheritdoc cref="Vector64s{T}.V1"/>
        /// <remarks>For Int16.</remarks>
        public static Vector64<short> Int16_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector64<short>.One;
#elif USE_VECTOR_CREATE
                return Vector64.Create((short)1);
#else
                return Vector64s<short>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vector64s<UInt16> --

        /// <inheritdoc cref="Vector64s{T}.VMaxByte"/>
        /// <remarks>For UInt16.</remarks>
        [CLSCompliant(false)]
        public static Vector64<ushort> UInt16_VMaxByte {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector64.Create((ushort)byte.MaxValue);
#else
                return Vector64s<ushort>.VMaxByte;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector64s{T}.VMaxUInt16"/>
        /// <remarks>For UInt32.</remarks>
        [CLSCompliant(false)]
        public static Vector64<uint> UInt32_VMaxUInt16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector64.Create((uint)0x0FFFFU);
#else
                return Vector64s<uint>.VMaxUInt16;
#endif // USE_VECTOR_CREATE
            }
        }

        // -- Vectors_T: Vector64s<Int32> --

        /// <inheritdoc cref="Vector64s{T}.V1"/>
        /// <remarks>For Int32.</remarks>
        public static Vector64<int> Int32_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector64<int>.One;
#elif USE_VECTOR_CREATE
                return Vector64.Create((int)1);
#else
                return Vector64s<int>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vector64s<Int64> --

        /// <inheritdoc cref="Vector64s{T}.V1"/>
        /// <remarks>For Int64.</remarks>
        public static Vector64<long> Int64_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector64<long>.One;
#elif USE_VECTOR_CREATE_INT64
                return Vector64.Create((long)1);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector64.Create((long)1);
                } else {
                    return Vector64s<long>.V1;
                }
#else
                return Vector64s<long>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        /// <inheritdoc cref="Vector64s{T}.MinValue"/>
        /// <remarks>For Int64.</remarks>
        public static Vector64<long> Int64_MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector64.Create(long.MinValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector64.Create(long.MinValue);
                } else {
                    return Vector64s<long>.MinValue;
                }
#else
                return Vector64s<long>.MinValue;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <summary>Int64 - `long.MinValue + 2 = 0x8000000000000002 = -9223372036852775802`.</summary>
        public static Vector64<long> Int64_MinValue_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE_INT64
            get => Vector64.Create(long.MinValue + 2);
        }
#else
            get;
        } = Vector64.Create(long.MinValue + 2);
#endif // USE_VECTOR_CREATE_INT64

        /// <summary>Int64 - `long.MinValue + 4 = 0x8000000000000004 = -9223372036854775804`.</summary>
        public static Vector64<long> Int64_MinValue_4 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE_INT64
            get => Vector64.Create(long.MinValue + 4);
        }
#else
            get;
        } = Vector64.Create(long.MinValue + 4);
#endif // USE_VECTOR_CREATE_INT64

        /// <inheritdoc cref="Vector64s{T}.VMaxInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector64<long> Int64_VMaxInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector64.Create((long)int.MaxValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector64.Create((long)int.MaxValue);
                } else {
                    return Vector64s<long>.VMaxInt32;
                }
#else
                return Vector64s<long>.VMaxInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector64s{T}.VMinInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector64<long> Int64_VMinInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector64.Create((long)int.MinValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector64.Create((long)int.MinValue);
                } else {
                    return Vector64s<long>.VMinInt32;
                }
#else
                return Vector64s<long>.VMinInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector64s{T}.VMaxUInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector64<long> Int64_VMaxUInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                // Even with net7, there's still a bug under Arm: Int64_VMaxUInt32(Vector64.Create(ScalarConstants.Int_VMaxUInt32)) return `<-1,-1>`.
#if NETX_0_OR_GREATER
                return Vector64.Create(ScalarConstants.Int_VMaxUInt32);
#elif USE_VECTOR_CREATE_INT64
                if (!VectorEnvironment.ProcessIsArmFamily) {
                    return Vector64.Create(ScalarConstants.Int_VMaxUInt32);
                } else {
                    return Vector64s<long>.VMaxUInt32;
                }
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess && !VectorEnvironment.ProcessIsArmFamily) {
                    return Vector64.Create(ScalarConstants.Int_VMaxUInt32);
                } else {
                    return Vector64s<long>.VMaxUInt32;
                }
#else
                return Vector64s<long>.VMaxUInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        // -- Vectors_T: others --

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<T> GetMaskBits<T>(int index) where T : struct {
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
            } else {
#if FALLBACK_USE_T
                return Vector64s<T>.GetMaskBits(index);
#else
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
#endif // FALLBACK_USE_T
            }
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - SByte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<sbyte> GetMaskBits_SByte(int index) {
            return GetMaskBits_Byte(index).AsSByte();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Byte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<byte> GetMaskBits_Byte(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector64.Create((byte)((1U << index) - 1));
#else
            return Vector64s<byte>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<short> GetMaskBits_Int16(int index) {
            return GetMaskBits_UInt16(index).AsInt16();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<ushort> GetMaskBits_UInt16(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector64.Create((ushort)((1U << index) - 1));
#else
            return Vector64s<ushort>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<int> GetMaskBits_Int32(int index) {
            return GetMaskBits_UInt32(index).AsInt32();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<uint> GetMaskBits_UInt32(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector64.Create((uint)((1U << index) - 1));
#else
            return Vector64s<uint>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<long> GetMaskBits_Int64(int index) {
            return GetMaskBits_UInt64(index).AsInt64();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<ulong> GetMaskBits_UInt64(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector64.Create((ulong)((1UL << index) - 1));
#else
            return Vector64s<ulong>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }


        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetResidueMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<T> GetResidueMaskBits<T>(int index) where T : struct {
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
            } else {
#if FALLBACK_USE_T
                return Vector64s<T>.GetMaskBits(Scalars<T>.BitSize - index);
#else
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
#endif // FALLBACK_USE_T
            }
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - SByte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetResidueMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<sbyte> GetResidueMaskBits_SByte(int index) {
            return GetResidueMaskBits_Byte(index).AsSByte();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Byte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<byte> GetResidueMaskBits_Byte(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector64.Create((byte)(byte.MaxValue >> index));
#else
            return Vector64s<byte>.GetMaskBits(8 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<short> GetResidueMaskBits_Int16(int index) {
            return GetResidueMaskBits_UInt16(index).AsInt16();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<ushort> GetResidueMaskBits_UInt16(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector64.Create((ushort)(ushort.MaxValue >> index));
#else
            return Vector64s<ushort>.GetMaskBits(16 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<int> GetResidueMaskBits_Int32(int index) {
            return GetResidueMaskBits_UInt32(index).AsInt32();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<uint> GetResidueMaskBits_UInt32(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector64.Create((uint)(uint.MaxValue >> index));
#else
            return Vector64s<uint>.GetMaskBits(32 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<long> GetResidueMaskBits_Int64(int index) {
            return GetResidueMaskBits_UInt64(index).AsInt64();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector64s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector64s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector64s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<ulong> GetResidueMaskBits_UInt64(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector64.Create((ulong)(ulong.MaxValue >> index));
#else
            return Vector64s<ulong>.GetMaskBits(64 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }


        #endregion // Vectors_T

        #region Shared
        // == Shared ==


        #endregion // Shared

        #region TraitsMethod
        // == TraitsMethod ==

        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of X.</summary>
        public static Vector64<byte> YGroup2Unzip_ShuffleX2_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((byte)0, 2, 4, 6, 8, 10, 12, 14);
        }
#else
            get;
        } = Vector64.Create((byte)0, 2, 4, 6, 8, 10, 12, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of Y.</summary>
        public static Vector64<byte> YGroup2Unzip_ShuffleX2_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((byte)1, 3, 5, 7, 9, 11, 13, 15);
        }
#else
            get;
        } = Vector64.Create((byte)1, 3, 5, 7, 9, 11, 13, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector64<ushort> YGroup2Unzip_ShuffleX2_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((ushort)0, 2, 4, 6);
        }
#else
            get;
        } = Vector64.Create((ushort)0, 2, 4, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector64<ushort> YGroup2Unzip_ShuffleX2_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((ushort)1, 3, 5, 7);
        }
#else
            get;
        } = Vector64.Create((ushort)1, 3, 5, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector64<uint> YGroup2Unzip_ShuffleX2_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((uint)0, 2);
        }
#else
            get;
        } = Vector64.Create((uint)0, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector64<uint> YGroup2Unzip_ShuffleX2_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((uint)1, 3);
        }
#else
            get;
        } = Vector64.Create((uint)1, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector64<ulong> YGroup2Unzip_ShuffleX2_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((ulong)0);
        }
#else
            get;
        } = Vector64.Create((ulong)0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector64<ulong> YGroup2Unzip_ShuffleX2_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((ulong)1);
        }
#else
            get;
        } = Vector64.Create((ulong)1);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt16 - The index of X.</summary>
        public static Vector64<byte> YGroup2Unzip_ShuffleX2OnByte_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((byte)0, 1, 4, 5, 8, 9, 12, 13);
        }
#else
            get;
        } = Vector64.Create((byte)0, 1, 4, 5, 8, 9, 12, 13);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt16 - The index of Y.</summary>
        public static Vector64<byte> YGroup2Unzip_ShuffleX2OnByte_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((byte)2, 3, 6, 7, 10, 11, 14, 15);
        }
#else
            get;
        } = Vector64.Create((byte)2, 3, 6, 7, 10, 11, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt32 - The index of X.</summary>
        public static Vector64<byte> YGroup2Unzip_ShuffleX2OnByte_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((byte)0, 1, 2, 3, 8, 9, 10, 11);
        }
#else
            get;
        } = Vector64.Create((byte)0, 1, 2, 3, 8, 9, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt32 - The index of Y.</summary>
        public static Vector64<byte> YGroup2Unzip_ShuffleX2OnByte_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((byte)4, 5, 6, 7, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector64.Create((byte)4, 5, 6, 7, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt64 - The index of X.</summary>
        public static Vector64<byte> YGroup2Unzip_ShuffleX2OnByte_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((byte)0, 1, 2, 3, 4, 5, 6, 7);
        }
#else
            get;
        } = Vector64.Create((byte)0, 1, 2, 3, 4, 5, 6, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt64 - The index of Y.</summary>
        public static Vector64<byte> YGroup2Unzip_ShuffleX2OnByte_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector64.Create((byte)8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector64.Create((byte)8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE


        #endregion // TraitsMethod


        //static Vector64Constants() {
        //}

#endif
    }
}
