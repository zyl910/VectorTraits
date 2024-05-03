#if NET5_0_OR_GREATER
#define USE_VECTOR_CREATE // .NET5+ has better performance (Without int64/uint64 on 32bit system) .
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define USE_VECTOR_CREATE_INT64 // .NET7+ has better performance of int64/uint64 on 32bit system .
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants used in <see cref="Vector128{T}"/> methods (<see cref="Vector128{T}"/> 方法所用的常数).
    /// </summary>
    public static class Vector128Constants {
#if NETCOREAPP3_0_OR_GREATER

        #region Vectors_T
        // == Vectors_T: originate from Vector128s<T> ==

        // -- Vectors_T: Vector128s<Single> --

        /// <inheritdoc cref="ScalarConstants.Single_SignMask"/>
        public static Vector128<float> Single_SignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector128.Create(ScalarConstants.Single_SignMask).AsSingle();
#else
                return Vector128s<float>.SignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_ExponentMask"/>
        public static Vector128<float> Single_ExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector128s<float>.ExponentMask;
                return Vector128.Create(ScalarConstants.SingleVal_ExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_MantissaMask"/>
        public static Vector128<float> Single_MantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector128s<float>.MantissaMask;
                return Vector128.Create(ScalarConstants.SingleVal_MantissaMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonSignMask"/>
        public static Vector128<float> Single_NonSignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector128.Create(ScalarConstants.Single_NonSignMask).AsSingle();
#else
                return Vector128s<float>.NonSignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonExponentMask"/>
        public static Vector128<float> Single_NonExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector128s<float>.NonExponentMask;
                return Vector128.Create(ScalarConstants.SingleVal_NonExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonMantissaMask"/>
        public static Vector128<float> Single_NonMantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector128s<float>.NonMantissaMask;
                return Vector128.Create(ScalarConstants.SingleVal_NonMantissaMask);
            }
        }

        // -- Vectors_T: Vector128s<Double> --

        /// <inheritdoc cref="ScalarConstants.Double_SignMask"/>
        public static Vector128<double> Double_SignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector128.Create(ScalarConstants.Double_SignMask).AsDouble();
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector128.Create(ScalarConstants.Double_SignMask).AsDouble();
                } else {
                    return Vector128s<double>.SignMask;
                }
#else
                return Vector128s<double>.SignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_ExponentMask"/>
        public static Vector128<double> Double_ExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector128s<double>.ExponentMask;
                return Vector128.Create(ScalarConstants.DoubleVal_ExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_MantissaMask"/>
        public static Vector128<double> Double_MantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector128s<double>.MantissaMask;
                return Vector128.Create(ScalarConstants.DoubleVal_MantissaMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonSignMask"/>
        public static Vector128<double> Double_NonSignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector128.Create(ScalarConstants.Double_NonSignMask).AsDouble();
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector128.Create(ScalarConstants.Double_NonSignMask).AsDouble();
                } else {
                    return Vector128s<double>.NonSignMask;
                }
#else
                return Vector128s<double>.NonSignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonExponentMask"/>
        public static Vector128<double> Double_NonExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector128s<double>.NonExponentMask;
                return Vector128.Create(ScalarConstants.DoubleVal_NonExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonMantissaMask"/>
        public static Vector128<double> Double_NonMantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector128s<double>.NonMantissaMask;
                return Vector128.Create(ScalarConstants.DoubleVal_NonMantissaMask);
            }
        }

        // -- Vectors_T: Vector128s<Byte> --

        /// <inheritdoc cref="Vector128s{T}.V1"/>
        /// <remarks>For Byte.</remarks>
        public static Vector128<byte> Byte_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector128<byte>.One;
#elif USE_VECTOR_CREATE
                return Vector128.Create((byte)1);
#else
                return Vector128s<byte>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vector128s<Int16> --

        /// <inheritdoc cref="Vector128s{T}.V1"/>
        /// <remarks>For Int16.</remarks>
        public static Vector128<short> Int16_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector128<short>.One;
#elif USE_VECTOR_CREATE
                return Vector128.Create((short)1);
#else
                return Vector128s<short>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vector128s<UInt16> --

        /// <inheritdoc cref="Vector128s{T}.VMaxByte"/>
        /// <remarks>For UInt16.</remarks>
        [CLSCompliant(false)]
        public static Vector128<ushort> UInt16_VMaxByte {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector128.Create((ushort)byte.MaxValue);
#else
                return Vector128s<ushort>.VMaxByte;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector128s{T}.VMaxUInt16"/>
        /// <remarks>For UInt32.</remarks>
        [CLSCompliant(false)]
        public static Vector128<uint> UInt32_VMaxUInt16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector128.Create((uint)0x0FFFFU);
#else
                return Vector128s<uint>.VMaxUInt16;
#endif // USE_VECTOR_CREATE
            }
        }

        // -- Vectors_T: Vector128s<Int32> --

        /// <inheritdoc cref="Vector128s{T}.V1"/>
        /// <remarks>For Int32.</remarks>
        public static Vector128<int> Int32_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector128<int>.One;
#elif USE_VECTOR_CREATE
                return Vector128.Create((int)1);
#else
                return Vector128s<int>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vector128s<Int64> --

        /// <inheritdoc cref="Vector128s{T}.V1"/>
        /// <remarks>For Int64.</remarks>
        public static Vector128<long> Int64_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector128<long>.One;
#elif USE_VECTOR_CREATE_INT64
                return Vector128.Create((long)1);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector128.Create((long)1);
                } else {
                    return Vector128s<long>.V1;
                }
#else
                return Vector128s<long>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        /// <inheritdoc cref="Vector128s{T}.MinValue"/>
        /// <remarks>For Int64.</remarks>
        public static Vector128<long> Int64_MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector128.Create(long.MinValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector128.Create(long.MinValue);
                } else {
                    return Vector128s<long>.MinValue;
                }
#else
                return Vector128s<long>.MinValue;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <summary>Int64 - `long.MinValue + 2 = 0x8000000000000002 = -9223372036852775802`.</summary>
        public static Vector128<long> Int64_MinValue_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE_INT64
            get => Vector128.Create(long.MinValue + 2);
        }
#else
            get;
        } = Vector128.Create(long.MinValue + 2);
#endif // USE_VECTOR_CREATE_INT64

        /// <summary>Int64 - `long.MinValue + 4 = 0x8000000000000004 = -9223372036854775804`.</summary>
        public static Vector128<long> Int64_MinValue_4 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE_INT64
            get => Vector128.Create(long.MinValue + 4);
        }
#else
            get;
        } = Vector128.Create(long.MinValue + 4);
#endif // USE_VECTOR_CREATE_INT64

        /// <inheritdoc cref="Vector128s{T}.VMaxInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector128<long> Int64_VMaxInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector128.Create((long)int.MaxValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector128.Create((long)int.MaxValue);
                } else {
                    return Vector128s<long>.VMaxInt32;
                }
#else
                return Vector128s<long>.VMaxInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector128s{T}.VMinInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector128<long> Int64_VMinInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector128.Create((long)int.MinValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector128.Create((long)int.MinValue);
                } else {
                    return Vector128s<long>.VMinInt32;
                }
#else
                return Vector128s<long>.VMinInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector128s{T}.VMaxUInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector128<long> Int64_VMaxUInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                // Even with net7, there's still a bug under Arm: Int64_VMaxUInt32(Vector128.Create(ScalarConstants.Int_VMaxUInt32)) return `<-1,-1>`.
#if NETX_0_OR_GREATER
                return Vector128.Create(ScalarConstants.Int_VMaxUInt32);
#elif USE_VECTOR_CREATE_INT64
                if (!VectorEnvironment.ProcessIsArmFamily) {
                    return Vector128.Create(ScalarConstants.Int_VMaxUInt32);
                } else {
                    return Vector128s<long>.VMaxUInt32;
                }
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess && !VectorEnvironment.ProcessIsArmFamily) {
                    return Vector128.Create(ScalarConstants.Int_VMaxUInt32);
                } else {
                    return Vector128s<long>.VMaxUInt32;
                }
#else
                return Vector128s<long>.VMaxUInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        // -- Vectors_T: others --

        /// <inheritdoc cref="Vector128s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 8-bit.</remarks>
        /// <seealso cref="Vector128s{T}.MaskBitPosSerialRotate"/>
        public static Vector128<byte> MaskBitPosSerialRotate8 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80);
        }
#else
            get;
        } = Vector128s<byte>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <inheritdoc cref="Vector128s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 16-bit.</remarks>
        /// <seealso cref="Vector128s{T}.MaskBitPosSerialRotate"/>
        public static Vector128<short> MaskBitPosSerialRotate16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((short)1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80);
        }
#else
            get;
        } = Vector128s<short>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <inheritdoc cref="Vector128s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 32-bit.</remarks>
        /// <seealso cref="Vector128s{T}.MaskBitPosSerialRotate"/>
        public static Vector128<int> MaskBitPosSerialRotate32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((int)1, 2, 4, 8);
        }
#else
            get;
        } = Vector128s<int>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <inheritdoc cref="Vector128s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 64-bit.</remarks>
        /// <seealso cref="Vector128s{T}.MaskBitPosSerialRotate"/>
        public static Vector128<long> MaskBitPosSerialRotate64 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((long)1, 2);
        }
#else
            get;
        } = Vector128s<long>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> GetMaskBits<T>(int index) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                return (Vector128<T>)(object)GetMaskBits_SByte(index);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector128<T>)(object)GetMaskBits_Byte(index);
            } else if (typeof(short) == typeof(T)) {
                return (Vector128<T>)(object)GetMaskBits_Int16(index);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector128<T>)(object)GetMaskBits_UInt16(index);
            } else if (typeof(int) == typeof(T)) {
                return (Vector128<T>)(object)GetMaskBits_Int32(index);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector128<T>)(object)GetMaskBits_UInt32(index);
            } else if (typeof(long) == typeof(T)) {
                return (Vector128<T>)(object)GetMaskBits_Int64(index);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector128<T>)(object)GetMaskBits_UInt64(index);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - SByte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> GetMaskBits_SByte(int index) {
            return GetMaskBits_Byte(index).AsSByte();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Byte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> GetMaskBits_Byte(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector128.Create((byte)((1U << index) - 1));
#else
            return Vector128s<byte>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> GetMaskBits_Int16(int index) {
            return GetMaskBits_UInt16(index).AsInt16();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> GetMaskBits_UInt16(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector128.Create((ushort)((1U << index) - 1));
#else
            return Vector128s<ushort>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> GetMaskBits_Int32(int index) {
            return GetMaskBits_UInt32(index).AsInt32();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> GetMaskBits_UInt32(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector128.Create((uint)((1U << index) - 1));
#else
            return Vector128s<uint>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> GetMaskBits_Int64(int index) {
            return GetMaskBits_UInt64(index).AsInt64();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> GetMaskBits_UInt64(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector128.Create((ulong)((1UL << index) - 1));
#else
            return Vector128s<ulong>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }


        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetResidueMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> GetResidueMaskBits<T>(int index) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                return (Vector128<T>)(object)GetResidueMaskBits_SByte(index);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector128<T>)(object)GetResidueMaskBits_Byte(index);
            } else if (typeof(short) == typeof(T)) {
                return (Vector128<T>)(object)GetResidueMaskBits_Int16(index);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector128<T>)(object)GetResidueMaskBits_UInt16(index);
            } else if (typeof(int) == typeof(T)) {
                return (Vector128<T>)(object)GetResidueMaskBits_Int32(index);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector128<T>)(object)GetResidueMaskBits_UInt32(index);
            } else if (typeof(long) == typeof(T)) {
                return (Vector128<T>)(object)GetResidueMaskBits_Int64(index);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector128<T>)(object)GetResidueMaskBits_UInt64(index);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - SByte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetResidueMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> GetResidueMaskBits_SByte(int index) {
            return GetResidueMaskBits_Byte(index).AsSByte();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Byte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> GetResidueMaskBits_Byte(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector128.Create((byte)(byte.MaxValue >> index));
#else
            return Vector128s<byte>.GetMaskBits(8 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> GetResidueMaskBits_Int16(int index) {
            return GetResidueMaskBits_UInt16(index).AsInt16();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> GetResidueMaskBits_UInt16(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector128.Create((ushort)(ushort.MaxValue >> index));
#else
            return Vector128s<ushort>.GetMaskBits(16 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> GetResidueMaskBits_Int32(int index) {
            return GetResidueMaskBits_UInt32(index).AsInt32();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> GetResidueMaskBits_UInt32(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector128.Create((uint)(uint.MaxValue >> index));
#else
            return Vector128s<uint>.GetMaskBits(32 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> GetResidueMaskBits_Int64(int index) {
            return GetResidueMaskBits_UInt64(index).AsInt64();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector128s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector128s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector128s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> GetResidueMaskBits_UInt64(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector128.Create((ulong)(ulong.MaxValue >> index));
#else
            return Vector128s<ulong>.GetMaskBits(64 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }


        #endregion // Vectors_T

        #region Shared
        // == Shared ==

        /// <summary>Serial value with rotate 8.</summary>
        public static Vector128<byte> SerialRotate8 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);
#endif // USE_VECTOR_CREATE

        #endregion // Shared

        #region TraitsMethod
        // == TraitsMethod ==

        /// <summary>YBitToByte - Shuffle - Indices .</summary>
        public static Vector128<byte> YBitToByte_Shuffle_Indices {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1);
        }
#else
            get;
        } = Vector128.Create((byte)0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1);
#endif // USE_VECTOR_CREATE


        /// <summary>ExtractMostSignificantBits - Shuffle - Get high byte of 16bit.</summary>
        public static Vector128<byte> ExtractMostSignificantBits_Shuffle_HiByteOf16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80);
        }
#else
            get;
        } = Vector128.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80);
#endif // USE_VECTOR_CREATE


        /// <summary>Narrow - Int64 - The indices of BigEndian - 0.</summary>
        public static Vector128<byte> Narrow_Int64_Indices_BE0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 5, 6, 7, 12, 13, 14, 15, 255, 255, 255, 255, 255, 255, 255, 255);
        }
#else
            get;
        } = Vector128.Create((byte)4, 5, 6, 7, 12, 13, 14, 15, 255, 255, 255, 255, 255, 255, 255, 255);
#endif // USE_VECTOR_CREATE

        /// <summary>Narrow - Int64 - The indices of BigEndian - 1.</summary>
        public static Vector128<byte> Narrow_Int64_Indices_BE1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)255, 255, 255, 255, 255, 255, 255, 255, 4, 5, 6, 7, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector128.Create((byte)255, 255, 255, 255, 255, 255, 255, 255, 4, 5, 6, 7, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>Narrow - Int64 - The indices of LittleEndian - 0.</summary>
        public static Vector128<byte> Narrow_Int64_Indices_LE0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 8, 9, 10, 11, 255, 255, 255, 255, 255, 255, 255, 255);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 8, 9, 10, 11, 255, 255, 255, 255, 255, 255, 255, 255);
#endif // USE_VECTOR_CREATE

        /// <summary>Narrow - Int64 - The indices of LittleEndian - 1.</summary>
        public static Vector128<byte> Narrow_Int64_Indices_LE1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)255, 255, 255, 255, 255, 255, 255, 255, 0, 1, 2, 3, 8, 9, 10, 11);
        }
#else
            get;
        } = Vector128.Create((byte)255, 255, 255, 255, 255, 255, 255, 255, 0, 1, 2, 3, 8, 9, 10, 11);
#endif // USE_VECTOR_CREATE


        /// <summary>Shuffle - UInt16 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> Shuffle_UInt16_Multiplier {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)0x202);
        }
#else
            get;
        } = Vector128.Create((ushort)0x202);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt16 - The offset of each byte within an element.</summary>
        public static Vector128<byte> Shuffle_UInt16_ByteOffset {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1);
        }
#else
            get;
        } = Vector128s.CreateRotate<byte>(0, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt32 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> Shuffle_UInt32_Multiplier {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)0x4040404U);
        }
#else
            get;
        } = Vector128.Create((uint)0x4040404U);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt32 - The offset of each byte within an element.</summary>
        public static Vector128<byte> Shuffle_UInt32_ByteOffset {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3);
        }
#else
            get;
        } = Vector128s.CreateRotate<byte>(0, 1, 2, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt64 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> Shuffle_UInt64_Multiplier {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)0x808080808080808UL);
        }
#else
            get;
        } = Vector128.Create((ulong)0x808080808080808UL);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt64 - The offset of each byte within an element.</summary>
        public static Vector128<byte> Shuffle_UInt64_ByteOffset {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);
        }
#else
            get;
        } = Vector128s.CreateRotate<byte>(0, 1, 2, 3, 4, 5, 6, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt64 - The offset of each byte within an element.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> Shuffle_UInt64_UInt32Offset {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)0, 1, 0, 1);
        }
#else
            get;
        } = Vector128s.CreateRotate<uint>(0, 1);
#endif // USE_VECTOR_CREATE


        private static readonly Vector128<byte>[] m_YShuffleG2_Byte_Indices = {
            Vector128.Create((byte)0, 0, 2, 2, 4, 4, 6, 6, 8, 8, 10, 10, 12, 12, 14, 14), // XX
            Vector128.Create((byte)1, 0, 3, 2, 5, 4, 7, 6, 9, 8, 11, 10, 13, 12, 15, 14), // YX
            Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), // XY
            Vector128.Create((byte)1, 1, 3, 3, 5, 5, 7, 7, 9, 9, 11, 11, 13, 13, 15, 15), // YY
        };
        /// <summary>YShuffleG2 - Byte - The indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> GetYShuffleG2_Byte_Indices(ShuffleControlG2 index) {
            return m_YShuffleG2_Byte_Indices[(byte)index];
        }

        private static readonly Vector128<byte>[] m_YShuffleG2_UInt16_ByteIndices = {
            Vector128.Create((byte)0, 1, 0, 1, 4, 5, 4, 5, 8, 9,  8,  9, 12, 13, 12, 13), // XX
            Vector128.Create((byte)2, 3, 0, 1, 6, 7, 4, 5, 10, 11, 8, 9, 14, 15, 12, 13), // YX
            Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), // XY
            Vector128.Create((byte)2, 3, 2, 3, 6, 7, 6, 7,10,11, 10, 11, 14, 15, 14, 15), // YY
        };
        /// <summary>YShuffleG2 - UInt16 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> GetYShuffleG2_UInt16_ByteIndices(ShuffleControlG2 index) {
            return m_YShuffleG2_UInt16_ByteIndices[(byte)index];
        }

        private static readonly Vector128<byte>[] m_YShuffleG2_UInt32_ByteIndices = {
            Vector128.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 8, 9, 10, 11,  8,  9, 10, 11), // XX
            Vector128.Create((byte)4, 5, 6, 7, 0, 1, 2, 3, 12, 13, 14, 15, 8, 9, 10, 11), // YX
            Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), // XY
            Vector128.Create((byte)4, 5, 6, 7, 4, 5, 6, 7,12,13, 14, 15, 12, 13, 14, 15), // YY
        };
        /// <summary>YShuffleG2 - UInt32 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> GetYShuffleG2_UInt32_ByteIndices(ShuffleControlG2 index) {
            return m_YShuffleG2_UInt32_ByteIndices[(byte)index];
        }

        private static readonly Vector128<byte>[] m_YShuffleG2_UInt64_ByteIndices = {
            Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1,  2,  3,  4,  5,  6,  7), // XX
            Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7), // YX
            Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), // XY
            Vector128.Create((byte)8, 9,10,11,12,13,14,15, 8, 9, 10, 11, 12, 13, 14, 15), // YY
        };
        /// <summary>YShuffleG2 - UInt64 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> GetYShuffleG2_UInt64_ByteIndices(ShuffleControlG2 index) {
            return m_YShuffleG2_UInt64_ByteIndices[(byte)index];
        }


        private static readonly Vector128<byte>[] m_YShuffleG4_Byte_Indices = new Vector128<byte>[256];
        /// <summary>YShuffleG4 - Byte - The indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> GetYShuffleG4_Byte_Indices(ShuffleControlG4 index) {
            return m_YShuffleG4_Byte_Indices[(byte)index];
        }

        private static readonly Vector128<byte>[] m_YShuffleG4_UInt16_ByteIndices = new Vector128<byte>[256];
        /// <summary>YShuffleG4 - UInt16 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> GetYShuffleG4_UInt16_ByteIndices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt16_ByteIndices[(byte)index];
        }

        private static readonly Vector128<byte>[] m_YShuffleG4_UInt32_ByteIndices = new Vector128<byte>[256];
        /// <summary>YShuffleG4 - UInt32 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> GetYShuffleG4_UInt32_ByteIndices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt32_ByteIndices[(byte)index];
        }

        private static readonly Vector128<byte>[] m_YShuffleG4X2_UInt64_ByteIndices = new Vector128<byte>[256 * 4];
        /// <summary>YShuffleG4X2 - UInt64 - The byte indices (result0_indices0, result0_indices1, result1_indices0, result1_indices1) .</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Returns the first reference to the four vector values(result0_indices0, result0_indices1, result1_indices0, result1_indices1) (返回4个向量值的首个引用).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref Vector128<byte> GetYShuffleG4X2_UInt64_ByteIndices(ShuffleControlG4 index) {
            return ref m_YShuffleG4X2_UInt64_ByteIndices[(byte)index * 4];
        }

        #endregion // TraitsMethod


        static Vector128Constants() {
            // == YShuffleG4, YShuffleG4X2 ==
            int idx = 0;
            var vectorX4Bytes = new byte[Vector128<byte>.Count * 4];
            for (int ctl = 0; ctl <= 255; ++ctl) {
                Vector128<byte> indices = default;
                ref byte q = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
                // -- Byte --
                for (int i = 0; i < Vector128<byte>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = (byte)selectedIndex;
                }
                m_YShuffleG4_Byte_Indices[ctl] = indices;
                // -- UInt16 --
                //Vector128<ushort> indicesUInt16 = default;
                //ref ushort qUInt16 = ref Unsafe.As<Vector128<ushort>, ushort>(ref indicesUInt16);
                idx = 0;
                for (int i = 0; i < Vector128<ushort>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    // Byte indices
                    int byteSize = sizeof(ushort);
                    int m = selectedIndex * byteSize;
                    for (int j = 0; j < byteSize; ++j) {
                        Unsafe.Add(ref q, idx++) = (byte)(m + j);
                    }
                }
                m_YShuffleG4_UInt16_ByteIndices[ctl] = indices;
                // -- UInt32 --
                //Vector128<uint> indicesUInt32 = default;
                //ref uint qUInt32 = ref Unsafe.As<Vector128<uint>, uint>(ref indicesUInt32);
                idx = 0;
                for (int i = 0; i < Vector128<uint>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    //Unsafe.Add(ref qUInt32, i) = (uint)selectedIndex;
                    // Byte indices
                    int byteSize = sizeof(uint);
                    int m = selectedIndex * byteSize;
                    for (int j = 0; j < byteSize; ++j) {
                        Unsafe.Add(ref q, idx++) = (byte)(m + j);
                    }
                }
                m_YShuffleG4_UInt32_ByteIndices[ctl] = indices;
                // -- UInt64 - X2 --
                const byte byFillZero = (byte)0xFFU; // VectorTableLookup: 0xFF is is out of range, so it will be set to 0. That can be used for the next `or` operation.
                for (int i = 0; i < 4; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    // Byte indices
                    int byteSize = sizeof(ulong);
                    int m = (selectedIndex & 1) * byteSize;
                    idx = (i & 1) * byteSize;
                    if (i >= 2) {
                        idx += Vector128<byte>.Count * 2;
                    }
                    for (int j = 0; j < byteSize; ++j) {
                        byte by = (byte)(m + j);
                        if (selectedIndex < 2) {
                            // lo
                            vectorX4Bytes[idx + Vector128<byte>.Count * 0] = by;
                            vectorX4Bytes[idx + Vector128<byte>.Count * 1] = byFillZero;
                        } else {
                            // hi
                            vectorX4Bytes[idx + Vector128<byte>.Count * 0] = byFillZero;
                            vectorX4Bytes[idx + Vector128<byte>.Count * 1] = by;
                        }
                        //if (i < 2) {
                        //    // (result0_indices0, result0_indices1)
                        //    if (selectedIndex < 2) {
                        //        // lo
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 0] = by;
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 1] = byFillZero;
                        //    } else {
                        //        // hi
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 2] = by;
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 3] = byFillZero;
                        //    }
                        //} else {
                        //    // (result1_indices0, result1_indices1)
                        //    if (selectedIndex < 2) {
                        //        // lo
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 0] = byFillZero;
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 2] = by;
                        //    } else {
                        //        // hi
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 1] = byFillZero;
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 3] = by;
                        //    }
                        //}
                        ++idx;
                    }
                }
                idx = ctl * 4;
                for (int i = 0; i < 4; ++i) {
                    //int n = ((i & 2) >> 1) | ((i & 1) << 1);
                    int n = i;
                    m_YShuffleG4X2_UInt64_ByteIndices[idx + i] = Unsafe.As<byte, Vector128<byte>>(ref vectorX4Bytes[Vector128<byte>.Count * n]);
                }
            } // ctl
            // Done.
            // Debug.Break.
            //Trace.WriteLine(string.Format("YShuffleG4X2_UInt64_ByteIndices.Length: {0}", YShuffleG4X2_UInt64_ByteIndices.Length));
        }

#endif
    }
}
