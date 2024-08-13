//#define FALLBACK_USE_T

#if NET5_0_OR_GREATER
#define USE_VECTOR_CREATE // .NET5+ has better performance (Without int64/uint64 on 32bit system) .
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
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
    /// The constants used in <see cref="Vector256{T}"/> methods (<see cref="Vector256{T}"/> 方法所用的常数).
    /// </summary>
    public static class Vector256Constants {
#if NETCOREAPP3_0_OR_GREATER

        #region Vectors_T
        // == Vectors_T: originate from Vector256s<T> ==

        // -- Vectors_T: Vector256s<Single> --

        /// <inheritdoc cref="ScalarConstants.Single_SignMask"/>
        public static Vector256<float> Single_SignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector256.Create(ScalarConstants.Single_SignMask).AsSingle();
#else
                return Vector256s<float>.SignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_ExponentMask"/>
        public static Vector256<float> Single_ExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector256s<float>.ExponentMask;
                return Vector256.Create(ScalarConstants.SingleVal_ExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_MantissaMask"/>
        public static Vector256<float> Single_MantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector256s<float>.MantissaMask;
                return Vector256.Create(ScalarConstants.SingleVal_MantissaMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonSignMask"/>
        public static Vector256<float> Single_NonSignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector256.Create(ScalarConstants.Single_NonSignMask).AsSingle();
#else
                return Vector256s<float>.NonSignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonExponentMask"/>
        public static Vector256<float> Single_NonExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector256s<float>.NonExponentMask;
                return Vector256.Create(ScalarConstants.SingleVal_NonExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonMantissaMask"/>
        public static Vector256<float> Single_NonMantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector256s<float>.NonMantissaMask;
                return Vector256.Create(ScalarConstants.SingleVal_NonMantissaMask);
            }
        }

        // -- Vectors_T: Vector256s<Double> --

        /// <inheritdoc cref="ScalarConstants.Double_SignMask"/>
        public static Vector256<double> Double_SignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector256.Create(ScalarConstants.Double_SignMask).AsDouble();
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector256.Create(ScalarConstants.Double_SignMask).AsDouble();
                } else {
                    return Vector256s<double>.SignMask;
                }
#else
                return Vector256s<double>.SignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_ExponentMask"/>
        public static Vector256<double> Double_ExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector256s<double>.ExponentMask;
                return Vector256.Create(ScalarConstants.DoubleVal_ExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_MantissaMask"/>
        public static Vector256<double> Double_MantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector256s<double>.MantissaMask;
                return Vector256.Create(ScalarConstants.DoubleVal_MantissaMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonSignMask"/>
        public static Vector256<double> Double_NonSignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector256.Create(ScalarConstants.Double_NonSignMask).AsDouble();
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector256.Create(ScalarConstants.Double_NonSignMask).AsDouble();
                } else {
                    return Vector256s<double>.NonSignMask;
                }
#else
                return Vector256s<double>.NonSignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonExponentMask"/>
        public static Vector256<double> Double_NonExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector256s<double>.NonExponentMask;
                return Vector256.Create(ScalarConstants.DoubleVal_NonExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonMantissaMask"/>
        public static Vector256<double> Double_NonMantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector256s<double>.NonMantissaMask;
                return Vector256.Create(ScalarConstants.DoubleVal_NonMantissaMask);
            }
        }

        // -- Vectors_T: Vector256s<Byte> --

        /// <inheritdoc cref="Vector256s{T}.V1"/>
        /// <remarks>For Byte.</remarks>
        public static Vector256<byte> Byte_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector256<byte>.One;
#elif USE_VECTOR_CREATE
                return Vector256.Create((byte)1);
#else
                return Vector256s<byte>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        /// <inheritdoc cref="Vector256s{T}.VMinSByte"/>
        /// <remarks>For SByte.</remarks>
        [CLSCompliant(false)]
        public static Vector256<byte> Byte_VMinSByte {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector256.Create(sbyte.MinValue).AsByte();
#else
                return Vector256s<byte>.VMinSByte;
#endif // USE_VECTOR_CREATE
            }
        }

        // -- Vectors_T: Vector256s<Int16> --

        /// <inheritdoc cref="Vector256s{T}.V1"/>
        /// <remarks>For Int16.</remarks>
        public static Vector256<short> Int16_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector256<short>.One;
#elif USE_VECTOR_CREATE
                return Vector256.Create((short)1);
#else
                return Vector256s<short>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vector256s<UInt16> --

        /// <inheritdoc cref="Vector256s{T}.VMaxByte"/>
        /// <remarks>For UInt16.</remarks>
        [CLSCompliant(false)]
        public static Vector256<ushort> UInt16_VMaxByte {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector256.Create((ushort)byte.MaxValue);
#else
                return Vector256s<ushort>.VMaxByte;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector256s{T}.VMaxUInt16"/>
        /// <remarks>For UInt32.</remarks>
        [CLSCompliant(false)]
        public static Vector256<uint> UInt32_VMaxUInt16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector256.Create((uint)0x0FFFFU);
#else
                return Vector256s<uint>.VMaxUInt16;
#endif // USE_VECTOR_CREATE
            }
        }

        // -- Vectors_T: Vector256s<Int32> --

        /// <inheritdoc cref="Vector256s{T}.V1"/>
        /// <remarks>For Int32.</remarks>
        public static Vector256<int> Int32_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector256<int>.One;
#elif USE_VECTOR_CREATE
                return Vector256.Create((int)1);
#else
                return Vector256s<int>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vector256s<Int64> --

        /// <inheritdoc cref="Vector256s{T}.V1"/>
        /// <remarks>For Int64.</remarks>
        public static Vector256<long> Int64_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector256<long>.One;
#elif USE_VECTOR_CREATE_INT64
                return Vector256.Create((long)1);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector256.Create((long)1);
                } else {
                    return Vector256s<long>.V1;
                }
#else
                return Vector256s<long>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        /// <inheritdoc cref="Vector256s{T}.MinValue"/>
        /// <remarks>For Int64.</remarks>
        public static Vector256<long> Int64_MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector256.Create(long.MinValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector256.Create(long.MinValue);
                } else {
                    return Vector256s<long>.MinValue;
                }
#else
                return Vector256s<long>.MinValue;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <summary>Int64 - `long.MinValue + 4 = 0x8000000000000004 = -9223372036854775804`.</summary>
        public static Vector256<long> Int64_MinValue_4 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE_INT64
            get => Vector256.Create(long.MinValue + 4);
        }
#else
            get;
        } = Vector256.Create(long.MinValue + 4);
#endif // USE_VECTOR_CREATE_INT64

        /// <inheritdoc cref="Vector256s{T}.VMaxInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector256<long> Int64_VMaxInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector256.Create((long)int.MaxValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector256.Create((long)int.MaxValue);
                } else {
                    return Vector256s<long>.VMaxInt32;
                }
#else
                return Vector256s<long>.VMaxInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector256s{T}.VMinInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector256<long> Int64_VMinInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector256.Create((long)int.MinValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector256.Create((long)int.MinValue);
                } else {
                    return Vector256s<long>.VMinInt32;
                }
#else
                return Vector256s<long>.VMinInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector256s{T}.VMaxUInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector256<long> Int64_VMaxUInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector256.Create(ScalarConstants.Int_VMaxUInt32);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector256.Create(ScalarConstants.Int_VMaxUInt32);
                } else {
                    return Vector256s<long>.VMaxUInt32;
                }
#else
                return Vector256s<long>.VMaxUInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        // -- Vectors_T: others --

        /// <inheritdoc cref="Vector256s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 8-bit.</remarks>
        /// <seealso cref="Vector256s{T}.MaskBitPosSerialRotate"/>
        public static Vector256<byte> MaskBitPosSerialRotate8 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80);
        }
#else
            get;
        } = Vector256s<byte>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <inheritdoc cref="Vector256s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 16-bit.</remarks>
        /// <seealso cref="Vector256s{T}.MaskBitPosSerialRotate"/>
        public static Vector256<short> MaskBitPosSerialRotate16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((short)1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 0x100, 0x200, 0x400, 0x800, 0x1000, 0x2000, 0x4000, unchecked((short)0x8000));
        }
#else
            get;
        } = Vector256s<short>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <inheritdoc cref="Vector256s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 32-bit.</remarks>
        /// <seealso cref="Vector256s{T}.MaskBitPosSerialRotate"/>
        public static Vector256<int> MaskBitPosSerialRotate32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((int)1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80);
        }
#else
            get;
        } = Vector256s<int>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <inheritdoc cref="Vector256s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 64-bit.</remarks>
        /// <seealso cref="Vector256s{T}.MaskBitPosSerialRotate"/>
        public static Vector256<long> MaskBitPosSerialRotate64 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((long)1, 2, 4, 8);
        }
#else
            get;
        } = Vector256s<long>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> GetMaskBits<T>(int index) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_SByte(index);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_Byte(index);
            } else if (typeof(short) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_Int16(index);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_UInt16(index);
            } else if (typeof(int) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_Int32(index);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_UInt32(index);
            } else if (typeof(long) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_Int64(index);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_UInt64(index);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_ExInt128(index);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_ExUInt128(index);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_Int128(index);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector256<T>)(object)GetMaskBits_UInt128(index);
#endif // BCL_TYPE_INT128
            } else {
#if FALLBACK_USE_T
                return Vector256s<T>.GetMaskBits(index);
#else
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
#endif // FALLBACK_USE_T
            }
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - SByte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> GetMaskBits_SByte(int index) {
            return GetMaskBits_Byte(index).AsSByte();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Byte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GetMaskBits_Byte(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector256.Create((byte)((1U << index) - 1));
#else
            return Vector256s<byte>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> GetMaskBits_Int16(int index) {
            return GetMaskBits_UInt16(index).AsInt16();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> GetMaskBits_UInt16(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector256.Create((ushort)((1U << index) - 1));
#else
            return Vector256s<ushort>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> GetMaskBits_Int32(int index) {
            return GetMaskBits_UInt32(index).AsInt32();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> GetMaskBits_UInt32(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector256.Create((uint)((1U << index) - 1));
#else
            return Vector256s<uint>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> GetMaskBits_Int64(int index) {
            return GetMaskBits_UInt64(index).AsInt64();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> GetMaskBits_UInt64(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector256.Create((ulong)((1UL << index) - 1));
#else
            return Vector256s<ulong>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - ExInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> GetMaskBits_ExInt128(int index) {
            return GetMaskBits_ExUInt128(index).ExAsExInt128();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - ExUInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> GetMaskBits_ExUInt128(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector256s.Create((ExUInt128)(((ExUInt128)1UL << index) - 1));
#else
            return Vector256s<ExUInt128>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

#if BCL_TYPE_INT128

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> GetMaskBits_Int128(int index) {
            return GetMaskBits_ExUInt128(index).ExAsInt128();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> GetMaskBits_UInt128(int index) {
            return GetMaskBits_ExUInt128(index).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetResidueMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> GetResidueMaskBits<T>(int index) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_SByte(index);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_Byte(index);
            } else if (typeof(short) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_Int16(index);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_UInt16(index);
            } else if (typeof(int) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_Int32(index);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_UInt32(index);
            } else if (typeof(long) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_Int64(index);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_UInt64(index);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_ExInt128(index);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_ExUInt128(index);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_Int128(index);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector256<T>)(object)GetResidueMaskBits_UInt128(index);
#endif // BCL_TYPE_INT128
            } else {
#if FALLBACK_USE_T
                return Vector256s<T>.GetMaskBits(Scalars<T>.BitSize - index);
#else
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
#endif // FALLBACK_USE_T
            }
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - SByte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetResidueMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> GetResidueMaskBits_SByte(int index) {
            return GetResidueMaskBits_Byte(index).AsSByte();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Byte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GetResidueMaskBits_Byte(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector256.Create((byte)(byte.MaxValue >> index));
#else
            return Vector256s<byte>.GetMaskBits(8 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> GetResidueMaskBits_Int16(int index) {
            return GetResidueMaskBits_UInt16(index).AsInt16();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> GetResidueMaskBits_UInt16(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector256.Create((ushort)(ushort.MaxValue >> index));
#else
            return Vector256s<ushort>.GetMaskBits(16 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> GetResidueMaskBits_Int32(int index) {
            return GetResidueMaskBits_UInt32(index).AsInt32();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> GetResidueMaskBits_UInt32(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector256.Create((uint)(uint.MaxValue >> index));
#else
            return Vector256s<uint>.GetMaskBits(32 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> GetResidueMaskBits_Int64(int index) {
            return GetResidueMaskBits_UInt64(index).AsInt64();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> GetResidueMaskBits_UInt64(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector256.Create((ulong)(ulong.MaxValue >> index));
#else
            return Vector256s<ulong>.GetMaskBits(64 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - ExInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> GetResidueMaskBits_ExInt128(int index) {
            return GetResidueMaskBits_ExUInt128(index).ExAsExInt128();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - ExUInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> GetResidueMaskBits_ExUInt128(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector256s.Create((ExUInt128)(ExUInt128.MaxValue >> index));
#else
            return Vector256s<ExUInt128>.GetMaskBits(64 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

#if BCL_TYPE_INT128

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> GetResidueMaskBits_Int128(int index) {
            return GetResidueMaskBits_ExUInt128(index).ExAsInt128();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector256s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector256s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector256s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> GetResidueMaskBits_UInt128(int index) {
            return GetResidueMaskBits_ExUInt128(index).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        #endregion // Vectors_T

        #region Shared
        // == Shared ==

        #endregion // Shared

        #region TraitsMethod
        // == TraitsMethod ==

        /// <summary>YBitToByte - Shuffle - Indices .</summary>
        public static Vector256<byte> YBitToByte_Shuffle_Indices {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3);
        }
#else
            get;
        } = Vector256.Create((byte)0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>ExtractMostSignificantBits - Shuffle - Get high byte of 16bit.</summary>
        public static Vector256<byte> ExtractMostSignificantBits_Shuffle_HiByteOf16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80);
        }
#else
            get;
        } = Vector256.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80);
#endif // USE_VECTOR_CREATE


        /// <summary>Shuffle - Byte - LaneAdd - K0 .</summary>
        public static Vector256<byte> Shuffle_Byte_LaneAdd_K0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create(0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0);
        }
#else
            get;
        } = Vector256.Create(0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - Byte - LaneAdd - K1 .</summary>
        public static Vector256<byte> Shuffle_Byte_LaneAdd_K1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create(0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70);
        }
#else
            get;
        } = Vector256.Create(0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt16 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> Shuffle_UInt16_Multiplier {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0x202);
        }
#else
            get;
        } = Vector256.Create((ushort)0x202);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt16 - The offset of each byte within an element.</summary>
        public static Vector256<byte> Shuffle_UInt16_ByteOffset {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1);
        }
#else
            get;
        } = Vector256s.CreateRotate<byte>(0, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt64 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> Shuffle_UInt64_Multiplier {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0x200000002UL);
        }
#else
            get;
        } = Vector256.Create((ulong)0x200000002UL);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt64 - The offset of each byte within an element.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> Shuffle_UInt64_UInt32Offset {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 1, 0, 1, 0, 1, 0, 1);
        }
#else
            get;
        } = Vector256s.CreateRotate<uint>(0, 1);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of X.</summary>
        public static Vector256<byte> YGroup2Unzip_ShuffleX2_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62);
        }
#else
            get;
        } = Vector256.Create((byte)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of Y.</summary>
        public static Vector256<byte> YGroup2Unzip_ShuffleX2_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63);
        }
#else
            get;
        } = Vector256.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup2Unzip_ShuffleX2_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup2Unzip_ShuffleX2_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31);
        }
#else
            get;
        } = Vector256.Create((ushort)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup2Unzip_ShuffleX2_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 2, 4, 6, 8, 10, 12, 14);
        }
#else
            get;
        } = Vector256.Create((uint)0, 2, 4, 6, 8, 10, 12, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup2Unzip_ShuffleX2_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)1, 3, 5, 7, 9, 11, 13, 15);
        }
#else
            get;
        } = Vector256.Create((uint)1, 3, 5, 7, 9, 11, 13, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup2Unzip_ShuffleX2_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 2, 4, 6);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 2, 4, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup2Unzip_ShuffleX2_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)1, 3, 5, 7);
        }
#else
            get;
        } = Vector256.Create((ulong)1, 3, 5, 7);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup2Zip - ShuffleX2 - Byte - The index of data0.</summary>
        public static Vector256<byte> YGroup2Zip_ShuffleX2_Byte_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 32, 1, 33, 2, 34, 3, 35, 4, 36, 5, 37, 6, 38, 7, 39, 8, 40, 9, 41, 10, 42, 11, 43, 12, 44, 13, 45, 14, 46, 15, 47);
        }
#else
            get;
        } = Vector256.Create((byte)0, 32, 1, 33, 2, 34, 3, 35, 4, 36, 5, 37, 6, 38, 7, 39, 8, 40, 9, 41, 10, 42, 11, 43, 12, 44, 13, 45, 14, 46, 15, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - Byte - The index of data1.</summary>
        public static Vector256<byte> YGroup2Zip_ShuffleX2_Byte_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)16, 48, 17, 49, 18, 50, 19, 51, 20, 52, 21, 53, 22, 54, 23, 55, 24, 56, 25, 57, 26, 58, 27, 59, 28, 60, 29, 61, 30, 62, 31, 63);
        }
#else
            get;
        } = Vector256.Create((byte)16, 48, 17, 49, 18, 50, 19, 51, 20, 52, 21, 53, 22, 54, 23, 55, 24, 56, 25, 57, 26, 58, 27, 59, 28, 60, 29, 61, 30, 62, 31, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt16 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup2Zip_ShuffleX2_UInt16_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 16, 1, 17, 2, 18, 3, 19, 4, 20, 5, 21, 6, 22, 7, 23);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 16, 1, 17, 2, 18, 3, 19, 4, 20, 5, 21, 6, 22, 7, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt16 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup2Zip_ShuffleX2_UInt16_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)8, 24, 9, 25, 10, 26, 11, 27, 12, 28, 13, 29, 14, 30, 15, 31);
        }
#else
            get;
        } = Vector256.Create((ushort)8, 24, 9, 25, 10, 26, 11, 27, 12, 28, 13, 29, 14, 30, 15, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt32 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup2Zip_ShuffleX2_UInt32_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 8, 1, 9, 2, 10, 3, 11);
        }
#else
            get;
        } = Vector256.Create((uint)0, 8, 1, 9, 2, 10, 3, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt32 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup2Zip_ShuffleX2_UInt32_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)4, 12, 5, 13, 6, 14, 7, 15);
        }
#else
            get;
        } = Vector256.Create((uint)4, 12, 5, 13, 6, 14, 7, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt64 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup2Zip_ShuffleX2_UInt64_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 4, 1, 5);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 4, 1, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt64 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup2Zip_ShuffleX2_UInt64_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)2, 6, 3, 7);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 6, 3, 7);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93);
        }
#else
            get;
        } = Vector256.Create((byte)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Sub part2 combine 0|1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 2, 5, 8, 11, 14, 17, 20, 23, 26, 29);
        }
#else
            get;
        } = Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 2, 5, 8, 11, 14, 17, 20, 23, 26, 29);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94);
        }
#else
            get;
        } = Vector256.Create((byte)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Sub part2 combine 0|1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30);
        }
#else
            get;
        } = Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92, 95);
        }
#else
            get;
        } = Vector256.Create((byte)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Sub part2 combine 0|1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31);
        }
#else
            get;
        } = Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 1, 4, 7, 10, 13);
        }
#else
            get;
        } = Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 1, 4, 7, 10, 13);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46);
        }
#else
            get;
        } = Vector256.Create((ushort)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 2, 5, 8, 11, 14);
        }
#else
            get;
        } = Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 2, 5, 8, 11, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47);
        }
#else
            get;
        } = Vector256.Create((ushort)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 0, 3, 6, 9, 12, 15);
        }
#else
            get;
        } = Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 0, 3, 6, 9, 12, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 3, 6, 9, 12, 15, 18, 21);
        }
#else
            get;
        } = Vector256.Create((uint)0, 3, 6, 9, 12, 15, 18, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)8, 9, 10, 11, 12, 13, 2, 5);
        }
#else
            get;
        } = Vector256.Create((uint)8, 9, 10, 11, 12, 13, 2, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)1, 4, 7, 10, 13, 16, 19, 22);
        }
#else
            get;
        } = Vector256.Create((uint)1, 4, 7, 10, 13, 16, 19, 22);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)8, 9, 10, 11, 12, 0, 3, 6);
        }
#else
            get;
        } = Vector256.Create((uint)8, 9, 10, 11, 12, 0, 3, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)2, 5, 8, 11, 14, 17, 20, 23);
        }
#else
            get;
        } = Vector256.Create((uint)2, 5, 8, 11, 14, 17, 20, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)8, 9, 10, 11, 12, 1, 4, 7);
        }
#else
            get;
        } = Vector256.Create((uint)8, 9, 10, 11, 12, 1, 4, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 3, 6, 9);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 3, 6, 9);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)4, 5, 6, 1);
        }
#else
            get;
        } = Vector256.Create((ulong)4, 5, 6, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)1, 4, 7, 10);
        }
#else
            get;
        } = Vector256.Create((ulong)1, 4, 7, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)4, 5, 6, 2);
        }
#else
            get;
        } = Vector256.Create((ulong)4, 5, 6, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)2, 5, 8, 11);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 5, 8, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)4, 5, 0, 3);
        }
#else
            get;
        } = Vector256.Create((ulong)4, 5, 0, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 6, 7, 12, 13, 18, 19, 24, 25, 30, 31, 36, 37, 42, 43, 48, 49, 54, 55, 60, 61, 66, 67, 72, 73, 78, 79, 84, 85, 90, 91);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 6, 7, 12, 13, 18, 19, 24, 25, 30, 31, 36, 37, 42, 43, 48, 49, 54, 55, 60, 61, 66, 67, 72, 73, 78, 79, 84, 85, 90, 91);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)2, 3, 8, 9, 14, 15, 20, 21, 26, 27, 32, 33, 38, 39, 44, 45, 50, 51, 56, 57, 62, 63, 68, 69, 74, 75, 80, 81, 86, 87, 92, 93);
        }
#else
            get;
        } = Vector256.Create((byte)2, 3, 8, 9, 14, 15, 20, 21, 26, 27, 32, 33, 38, 39, 44, 45, 50, 51, 56, 57, 62, 63, 68, 69, 74, 75, 80, 81, 86, 87, 92, 93);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)4, 5, 10, 11, 16, 17, 22, 23, 28, 29, 34, 35, 40, 41, 46, 47, 52, 53, 58, 59, 64, 65, 70, 71, 76, 77, 82, 83, 88, 89, 94, 95);
        }
#else
            get;
        } = Vector256.Create((byte)4, 5, 10, 11, 16, 17, 22, 23, 28, 29, 34, 35, 40, 41, 46, 47, 52, 53, 58, 59, 64, 65, 70, 71, 76, 77, 82, 83, 88, 89, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 12, 13, 14, 15, 24, 25, 26, 27, 36, 37, 38, 39, 48, 49, 50, 51, 60, 61, 62, 63, 72, 73, 74, 75, 84, 85, 86, 87);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 12, 13, 14, 15, 24, 25, 26, 27, 36, 37, 38, 39, 48, 49, 50, 51, 60, 61, 62, 63, 72, 73, 74, 75, 84, 85, 86, 87);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)4, 5, 6, 7, 16, 17, 18, 19, 28, 29, 30, 31, 40, 41, 42, 43, 52, 53, 54, 55, 64, 65, 66, 67, 76, 77, 78, 79, 88, 89, 90, 91);
        }
#else
            get;
        } = Vector256.Create((byte)4, 5, 6, 7, 16, 17, 18, 19, 28, 29, 30, 31, 40, 41, 42, 43, 52, 53, 54, 55, 64, 65, 66, 67, 76, 77, 78, 79, 88, 89, 90, 91);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 20, 21, 22, 23, 32, 33, 34, 35, 44, 45, 46, 47, 56, 57, 58, 59, 68, 69, 70, 71, 80, 81, 82, 83, 92, 93, 94, 95);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 20, 21, 22, 23, 32, 33, 34, 35, 44, 45, 46, 47, 56, 57, 58, 59, 68, 69, 70, 71, 80, 81, 82, 83, 92, 93, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31, 48, 49, 50, 51, 52, 53, 54, 55, 72, 73, 74, 75, 76, 77, 78, 79);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31, 48, 49, 50, 51, 52, 53, 54, 55, 72, 73, 74, 75, 76, 77, 78, 79);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 32, 33, 34, 35, 36, 37, 38, 39, 56, 57, 58, 59, 60, 61, 62, 63, 80, 81, 82, 83, 84, 85, 86, 87);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 32, 33, 34, 35, 36, 37, 38, 39, 56, 57, 58, 59, 60, 61, 62, 63, 80, 81, 82, 83, 84, 85, 86, 87);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 40, 41, 42, 43, 44, 45, 46, 47, 64, 65, 66, 67, 68, 69, 70, 71, 88, 89, 90, 91, 92, 93, 94, 95);
        }
#else
            get;
        } = Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 40, 41, 42, 43, 44, 45, 46, 47, 64, 65, 66, 67, 68, 69, 70, 71, 88, 89, 90, 91, 92, 93, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4Unzip - ShuffleX2 Longer - Byte - The index of X/Y.</summary>
        public static Vector256<byte> YGroup4Unzip_ShuffleX2Longer_Byte_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61);
        }
#else
            get;
        } = Vector256.Create((byte)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - Byte - The index of Z/W.</summary>
        public static Vector256<byte> YGroup4Unzip_ShuffleX2Longer_Byte_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63);
        }
#else
            get;
        } = Vector256.Create((byte)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt16 - The index of X/Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4Unzip_ShuffleX2Longer_UInt16_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 4, 8, 12, 16, 20, 24, 28, 1, 5, 9, 13, 17, 21, 25, 29);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 4, 8, 12, 16, 20, 24, 28, 1, 5, 9, 13, 17, 21, 25, 29);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt16 - The index of Z/W.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4Unzip_ShuffleX2Longer_UInt16_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)2, 6, 10, 14, 18, 22, 26, 30, 3, 7, 11, 15, 19, 23, 27, 31);
        }
#else
            get;
        } = Vector256.Create((ushort)2, 6, 10, 14, 18, 22, 26, 30, 3, 7, 11, 15, 19, 23, 27, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt32 - The index of X/Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4Unzip_ShuffleX2Longer_UInt32_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 4, 8, 12, 1, 5, 9, 13);
        }
#else
            get;
        } = Vector256.Create((uint)0, 4, 8, 12, 1, 5, 9, 13);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt32 - The index of Z/W.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4Unzip_ShuffleX2Longer_UInt32_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)2, 6, 10, 14, 3, 7, 11, 15);
        }
#else
            get;
        } = Vector256.Create((uint)2, 6, 10, 14, 3, 7, 11, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt64 - The index of X/Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4Unzip_ShuffleX2Longer_UInt64_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 4, 1, 5);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 4, 1, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt64 - The index of Z/W.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4Unzip_ShuffleX2Longer_UInt64_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)2, 6, 3, 7);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 6, 3, 7);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4Zip - ShuffleX2 Longer - Byte - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<byte> YGroup4Zip_ShuffleX2Longer_Byte_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 16, 32, 48, 1, 17, 33, 49, 2, 18, 34, 50, 3, 19, 35, 51, 4, 20, 36, 52, 5, 21, 37, 53, 6, 22, 38, 54, 7, 23, 39, 55);
        }
#else
            get;
        } = Vector256.Create((byte)0, 16, 32, 48, 1, 17, 33, 49, 2, 18, 34, 50, 3, 19, 35, 51, 4, 20, 36, 52, 5, 21, 37, 53, 6, 22, 38, 54, 7, 23, 39, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - Byte - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector256<byte> YGroup4Zip_ShuffleX2Longer_Byte_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 24, 40, 56, 9, 25, 41, 57, 10, 26, 42, 58, 11, 27, 43, 59, 12, 28, 44, 60, 13, 29, 45, 61, 14, 30, 46, 62, 15, 31, 47, 63);
        }
#else
            get;
        } = Vector256.Create((byte)8, 24, 40, 56, 9, 25, 41, 57, 10, 26, 42, 58, 11, 27, 43, 59, 12, 28, 44, 60, 13, 29, 45, 61, 14, 30, 46, 62, 15, 31, 47, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt16 - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4Zip_ShuffleX2Longer_UInt16_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 8, 16, 24, 1, 9, 17, 25, 2, 10, 18, 26, 3, 11, 19, 27);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 8, 16, 24, 1, 9, 17, 25, 2, 10, 18, 26, 3, 11, 19, 27);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt16 - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4Zip_ShuffleX2Longer_UInt16_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)4, 12, 20, 28, 5, 13, 21, 29, 6, 14, 22, 30, 7, 15, 23, 31);
        }
#else
            get;
        } = Vector256.Create((ushort)4, 12, 20, 28, 5, 13, 21, 29, 6, 14, 22, 30, 7, 15, 23, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt32 - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4Zip_ShuffleX2Longer_UInt32_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 4, 8, 12, 1, 5, 9, 13);
        }
#else
            get;
        } = Vector256.Create((uint)0, 4, 8, 12, 1, 5, 9, 13);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt32 - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4Zip_ShuffleX2Longer_UInt32_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)2, 6, 10, 14, 3, 7, 11, 15);
        }
#else
            get;
        } = Vector256.Create((uint)2, 6, 10, 14, 3, 7, 11, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt64 - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4Zip_ShuffleX2Longer_UInt64_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 2, 4, 6);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 4, 1, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt64 - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4Zip_ShuffleX2Longer_UInt64_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)1, 3, 5, 7);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 6, 3, 7);
#endif // USE_VECTOR_CREATE


        private static readonly Vector256<byte>[] m_YShuffleG2_Byte_Indices = {
            Vector256.Create((byte)0, 0, 2, 2, 4, 4, 6, 6, 8, 8, 10, 10, 12, 12, 14, 14, 16, 16, 18, 18, 20, 20, 22, 22, 24, 24, 26, 26, 28, 28, 30, 30), // XX
            Vector256.Create((byte)1, 0, 3, 2, 5, 4, 7, 6, 9, 8, 11, 10, 13, 12, 15, 14, 17, 16, 19, 18, 21, 20, 23, 22, 25, 24, 27, 26, 29, 28, 31, 30), // YX
            Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31), // XY
            Vector256.Create((byte)1, 1, 3, 3, 5, 5, 7, 7, 9, 9, 11, 11, 13, 13, 15, 15, 17, 17, 19, 19, 21, 21, 23, 23, 25, 25, 27, 27, 29, 29, 31, 31), // YY
        };
        /// <summary>YShuffleG2 - Byte - The indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GetYShuffleG2_Byte_Indices(ShuffleControlG2 index) {
            return m_YShuffleG2_Byte_Indices[(byte)index];
        }

        private static readonly Vector256<byte>[] m_YShuffleG2_UInt16_ByteIndices = {
            Vector256.Create((byte)0, 1, 0, 1, 4, 5, 4, 5, 8, 9,  8,  9, 12, 13, 12, 13, 16, 17, 16, 17, 20, 21, 20, 21, 24, 25, 24, 25, 28, 29, 28, 29), // XX
            Vector256.Create((byte)2, 3, 0, 1, 6, 7, 4, 5, 10, 11, 8, 9, 14, 15, 12, 13, 18, 19, 16, 17, 22, 23, 20, 21, 26, 27, 24, 25, 30, 31, 28, 29), // YX
            Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31), // XY
            Vector256.Create((byte)2, 3, 2, 3, 6, 7, 6, 7,10,11, 10, 11, 14, 15, 14, 15, 18, 19, 18, 19, 22, 23, 22, 23, 26, 27, 26, 27, 30, 31, 30, 31), // YY
        };
        /// <summary>YShuffleG2 - UInt16 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GetYShuffleG2_UInt16_ByteIndices(ShuffleControlG2 index) {
            return m_YShuffleG2_UInt16_ByteIndices[(byte)index];
        }

#if !REDUCE_MEMORY_USAGE
        private static readonly Vector256<uint>[] m_YShuffleG2_UInt32_Indices = {
            Vector256.Create((uint)0, 0, 2, 2, 4, 4, 6, 6), // XX
            Vector256.Create((uint)1, 0, 3, 2, 5, 4, 7, 6), // YX
            Vector256.Create((uint)0, 1, 2, 3, 4, 5, 6, 7), // XY
            Vector256.Create((uint)1, 1, 3, 3, 5, 5, 7, 7), // YY
        };
        /// <summary>YShuffleG2 - UInt32 - The uint32 indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> GetYShuffleG2_UInt32_Indices(ShuffleControlG2 index) {
            return m_YShuffleG2_UInt32_Indices[(byte)index];
        }
#endif // !REDUCE_MEMORY_USAGE

        private static readonly Vector256<byte>[] m_YShuffleG2_UInt32_ByteIndices = {
            Vector256.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 8, 9, 10, 11,  8,  9, 10, 11, 16, 17, 18, 19, 16, 17, 18, 19, 24, 25, 26, 27, 24, 25, 26, 27), // XX
            Vector256.Create((byte)4, 5, 6, 7, 0, 1, 2, 3, 12, 13, 14, 15, 8, 9, 10, 11, 20, 21, 22, 23, 16, 17, 18, 19, 28, 29, 30, 31, 24, 25, 26, 27), // YX
            Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31), // XY
            Vector256.Create((byte)4, 5, 6, 7, 4, 5, 6, 7,12,13, 14, 15, 12, 13, 14, 15, 20, 21, 22, 23, 20, 21, 22, 23, 28, 29, 30, 31, 28, 29, 30, 31), // YY
        };
        /// <summary>YShuffleG2 - UInt32 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GetYShuffleG2_UInt32_ByteIndices(ShuffleControlG2 index) {
            return m_YShuffleG2_UInt32_ByteIndices[(byte)index];
        }

        private static readonly Vector256<byte>[] m_YShuffleG2_UInt64_ByteIndices = {
            Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1,  2,  3,  4,  5,  6,  7, 16, 17, 18, 19, 20, 21, 22, 23, 16, 17, 18, 19, 20, 21, 22, 23), // XX
            Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31, 16, 17, 18, 19, 20, 21, 22, 23), // YX
            Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31), // XY
            Vector256.Create((byte)8, 9,10,11,12,13,14,15, 8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31), // YY
        };
        /// <summary>YShuffleG2 - UInt64 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GetYShuffleG2_UInt64_ByteIndices(ShuffleControlG2 index) {
            return m_YShuffleG2_UInt64_ByteIndices[(byte)index];
        }


        private static readonly Vector256<byte>[] m_YShuffleG4_Byte_Indices = new Vector256<byte>[256];
        /// <summary>YShuffleG4 - Byte - The indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GetYShuffleG4_Byte_Indices(ShuffleControlG4 index) {
            return m_YShuffleG4_Byte_Indices[(byte)index];
        }

        private static readonly Vector256<byte>[] m_YShuffleG4_UInt16_ByteIndices = new Vector256<byte>[256];
        /// <summary>YShuffleG4 - UInt16 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GetYShuffleG4_UInt16_ByteIndices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt16_ByteIndices[(byte)index];
        }

#if !REDUCE_MEMORY_USAGE
        private static readonly Vector256<uint>[] m_YShuffleG4_UInt32_Indices = new Vector256<uint>[256];
        /// <summary>YShuffleG4 - UInt32 - The indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> GetYShuffleG4_UInt32_Indices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt32_Indices[(nint)(uint)index];
        }
#endif // !REDUCE_MEMORY_USAGE

        private static readonly Vector256<byte>[] m_YShuffleG4_UInt32_ByteIndices = new Vector256<byte>[256];
        /// <summary>YShuffleG4 - UInt32 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GetYShuffleG4_UInt32_ByteIndices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt32_ByteIndices[(byte)index];
        }

        private static readonly Vector256<byte>[] m_YShuffleG4_UInt64_ByteIndices = new Vector256<byte>[256];
        /// <summary>YShuffleG4 - UInt64 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GetYShuffleG4_UInt64_ByteIndices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt64_ByteIndices[(byte)index];
        }

        private static readonly Vector256<uint>[] m_YShuffleG4_UInt64_UInt32Indices = new Vector256<uint>[256];
        /// <summary>YShuffleG4 - UInt64 - The UInt32 indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> GetYShuffleG4_UInt64_UInt32Indices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt64_UInt32Indices[(nint)(uint)index];
        }

        #endregion // TraitsMethod

        static Vector256Constants() {
            // == YShuffleG4 ==
            for (int ctl = 0; ctl <= 255; ++ctl) {
                int idx;
                Vector256<byte> indices = default;
                ref byte q = ref Unsafe.As<Vector256<byte>, byte>(ref indices);
                // -- Byte --
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = (byte)selectedIndex;
                }
                m_YShuffleG4_Byte_Indices[ctl] = indices;
                // -- UInt16 --
                Vector256<ushort> indicesUInt16 = default;
                ref ushort qUInt16 = ref Unsafe.As<Vector256<ushort>, ushort>(ref indicesUInt16);
                idx = 0;
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref qUInt16, i) = (ushort)selectedIndex;
                    // Byte indices
                    int byteSize = sizeof(ushort);
                    int m = selectedIndex * byteSize;
                    for (int j = 0; j < byteSize; ++j) {
                        Unsafe.Add(ref q, idx++) = (byte)(m + j);
                    }
                }
                m_YShuffleG4_UInt16_ByteIndices[ctl] = indices;
                // -- UInt32 --
                Vector256<uint> indicesUInt32 = default;
                ref uint qUInt32 = ref Unsafe.As<Vector256<uint>, uint>(ref indicesUInt32);
                idx = 0;
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref qUInt32, i) = (uint)selectedIndex;
                    // Byte indices
                    int byteSize = sizeof(uint);
                    int m = selectedIndex * byteSize;
                    for (int j = 0; j < byteSize; ++j) {
                        Unsafe.Add(ref q, idx++) = (byte)(m + j);
                    }
                }
#if !REDUCE_MEMORY_USAGE
                m_YShuffleG4_UInt32_Indices[ctl] = indicesUInt32;
#endif // !REDUCE_MEMORY_USAGE
                m_YShuffleG4_UInt32_ByteIndices[ctl] = indices;
                // -- UInt64 --
                Vector256<ulong> indicesUInt64 = default;
                ref ulong qUInt64 = ref Unsafe.As<Vector256<ulong>, ulong>(ref indicesUInt64);
                idx = 0;
                int idxUInt32 = 0;
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref qUInt64, i) = (ulong)selectedIndex;
                    // Byte indices
                    int byteSize = sizeof(ulong);
                    int m = selectedIndex * byteSize;
                    for (int j = 0; j < byteSize; ++j) {
                        Unsafe.Add(ref q, idx++) = (byte)(m + j);
                    }
                    // UInt32 indices
                    int itemSize = sizeof(ulong) / sizeof(uint);
                    m = selectedIndex * itemSize;
                    for (int j = 0; j < itemSize; ++j) {
                        Unsafe.Add(ref qUInt32, idxUInt32++) = (byte)(m + j);
                    }
                }
                m_YShuffleG4_UInt64_ByteIndices[ctl] = indices;
                m_YShuffleG4_UInt64_UInt32Indices[ctl] = indicesUInt32;
            } // ctl

        }

#endif
            }
        }
