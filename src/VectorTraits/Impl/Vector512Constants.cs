﻿//#define FALLBACK_USE_T

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
    /// The constants used in <see cref="Vector512{T}"/> methods (<see cref="Vector512{T}"/> 方法所用的常数).
    /// </summary>
    public static partial class Vector512Constants {
#if NET8_0_OR_GREATER

        #region Vectors_T
        // == Vectors_T: originate from Vector512s<T> ==

        // -- Vectors_T: Vector512s<Single> --

        /// <inheritdoc cref="ScalarConstants.Single_SignMask"/>
        public static Vector512<float> Single_SignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector512.Create(ScalarConstants.Single_SignMask).AsSingle();
#else
                return Vector512s<float>.SignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_ExponentMask"/>
        public static Vector512<float> Single_ExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector512s<float>.ExponentMask;
                return Vector512.Create(ScalarConstants.SingleVal_ExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_MantissaMask"/>
        public static Vector512<float> Single_MantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector512s<float>.MantissaMask;
                return Vector512.Create(ScalarConstants.SingleVal_MantissaMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonSignMask"/>
        public static Vector512<float> Single_NonSignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector512.Create(ScalarConstants.Single_NonSignMask).AsSingle();
#else
                return Vector512s<float>.NonSignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonExponentMask"/>
        public static Vector512<float> Single_NonExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector512s<float>.NonExponentMask;
                return Vector512.Create(ScalarConstants.SingleVal_NonExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Single_NonMantissaMask"/>
        public static Vector512<float> Single_NonMantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector512s<float>.NonMantissaMask;
                return Vector512.Create(ScalarConstants.SingleVal_NonMantissaMask);
            }
        }

        // -- Vectors_T: Vector512s<Double> --

        /// <inheritdoc cref="ScalarConstants.Double_SignMask"/>
        public static Vector512<double> Double_SignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector512.Create(ScalarConstants.Double_SignMask).AsDouble();
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector512.Create(ScalarConstants.Double_SignMask).AsDouble();
                } else {
                    return Vector512s<double>.SignMask;
                }
#else
                return Vector512s<double>.SignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_ExponentMask"/>
        public static Vector512<double> Double_ExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector512s<double>.ExponentMask;
                return Vector512.Create(ScalarConstants.DoubleVal_ExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_MantissaMask"/>
        public static Vector512<double> Double_MantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector512s<double>.MantissaMask;
                return Vector512.Create(ScalarConstants.DoubleVal_MantissaMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonSignMask"/>
        public static Vector512<double> Double_NonSignMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector512.Create(ScalarConstants.Double_NonSignMask).AsDouble();
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector512.Create(ScalarConstants.Double_NonSignMask).AsDouble();
                } else {
                    return Vector512s<double>.NonSignMask;
                }
#else
                return Vector512s<double>.NonSignMask;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonExponentMask"/>
        public static Vector512<double> Double_NonExponentMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector512s<double>.NonExponentMask;
                return Vector512.Create(ScalarConstants.DoubleVal_NonExponentMask);
            }
        }

        /// <inheritdoc cref="ScalarConstants.Double_NonMantissaMask"/>
        public static Vector512<double> Double_NonMantissaMask {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                //return Vector512s<double>.NonMantissaMask;
                return Vector512.Create(ScalarConstants.DoubleVal_NonMantissaMask);
            }
        }

        // -- Vectors_T: Vector512s<Byte> --

        /// <inheritdoc cref="Vector512s{T}.V1"/>
        /// <remarks>For Byte.</remarks>
        public static Vector512<byte> Byte_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector512<byte>.One;
#elif USE_VECTOR_CREATE
                return Vector512.Create((byte)1);
#else
                return Vector512s<byte>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vector512s<Int16> --

        /// <inheritdoc cref="Vector512s{T}.V1"/>
        /// <remarks>For Int16.</remarks>
        public static Vector512<short> Int16_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector512<short>.One;
#elif USE_VECTOR_CREATE
                return Vector512.Create((short)1);
#else
                return Vector512s<short>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vector512s<UInt16> --

        /// <inheritdoc cref="Vector512s{T}.VMaxByte"/>
        /// <remarks>For UInt16.</remarks>
        [CLSCompliant(false)]
        public static Vector512<ushort> UInt16_VMaxByte {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector512.Create((ushort)byte.MaxValue);
#else
                return Vector512s<ushort>.VMaxByte;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector512s{T}.VMaxUInt16"/>
        /// <remarks>For UInt32.</remarks>
        [CLSCompliant(false)]
        public static Vector512<uint> UInt32_VMaxUInt16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE
                return Vector512.Create((uint)0x0FFFFU);
#else
                return Vector512s<uint>.VMaxUInt16;
#endif // USE_VECTOR_CREATE
            }
        }

        // -- Vectors_T: Vector512s<Int32> --

        /// <inheritdoc cref="Vector512s{T}.V1"/>
        /// <remarks>For Int32.</remarks>
        public static Vector512<int> Int32_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector512<int>.One;
#elif USE_VECTOR_CREATE
                return Vector512.Create((int)1);
#else
                return Vector512s<int>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        // -- Vectors_T: Vector512s<Int64> --

        /// <inheritdoc cref="Vector512s{T}.V1"/>
        /// <remarks>For Int64.</remarks>
        public static Vector512<long> Int64_One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET8_0_OR_GREATER
                return Vector512<long>.One;
#elif USE_VECTOR_CREATE_INT64
                return Vector512.Create((long)1);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector512.Create((long)1);
                } else {
                    return Vector512s<long>.V1;
                }
#else
                return Vector512s<long>.V1;
#endif // NET8_0_OR_GREATER
            }
        }

        /// <inheritdoc cref="Vector512s{T}.MinValue"/>
        /// <remarks>For Int64.</remarks>
        public static Vector512<long> Int64_MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector512.Create(long.MinValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector512.Create(long.MinValue);
                } else {
                    return Vector512s<long>.MinValue;
                }
#else
                return Vector512s<long>.MinValue;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <summary>Int64 - `long.MinValue + 4 = 0x8000000000000004 = -9223372036854775804`.</summary>
        public static Vector512<long> Int64_MinValue_4 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE_INT64
            get => Vector512.Create(long.MinValue + 4);
        }
#else
            get;
        } = Vector512.Create(long.MinValue + 4);
#endif // USE_VECTOR_CREATE_INT64

        /// <inheritdoc cref="Vector512s{T}.VMaxInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector512<long> Int64_VMaxInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector512.Create((long)int.MaxValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector512.Create((long)int.MaxValue);
                } else {
                    return Vector512s<long>.VMaxInt32;
                }
#else
                return Vector512s<long>.VMaxInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector512s{T}.VMinInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector512<long> Int64_VMinInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector512.Create((long)int.MinValue);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector512.Create((long)int.MinValue);
                } else {
                    return Vector512s<long>.VMinInt32;
                }
#else
                return Vector512s<long>.VMinInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        /// <inheritdoc cref="Vector512s{T}.VMaxUInt32"/>
        /// <remarks>For Int64.</remarks>
        public static Vector512<long> Int64_VMaxUInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if USE_VECTOR_CREATE_INT64
                return Vector512.Create(ScalarConstants.Int_VMaxUInt32);
#elif USE_VECTOR_CREATE
                if (VectorEnvironment.Is64BitProcess) {
                    return Vector512.Create(ScalarConstants.Int_VMaxUInt32);
                } else {
                    return Vector512s<long>.VMaxUInt32;
                }
#else
                return Vector512s<long>.VMaxUInt32;
#endif // USE_VECTOR_CREATE
            }
        }

        // -- Vectors_T: others --

        /// <inheritdoc cref="Vector512s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 8-bit.</remarks>
        /// <seealso cref="Vector512s{T}.MaskBitPosSerialRotate"/>
        public static Vector512<byte> MaskBitPosSerialRotate8 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80);
        }
#else
            get;
        } = Vector512s<byte>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <inheritdoc cref="Vector512s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 16-bit.</remarks>
        /// <seealso cref="Vector512s{T}.MaskBitPosSerialRotate"/>
        public static Vector512<short> MaskBitPosSerialRotate16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((short)1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 0x100, 0x200, 0x400, 0x800, 0x1000, 0x2000, 0x4000, unchecked((short)0x8000), 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 0x100, 0x200, 0x400, 0x800, 0x1000, 0x2000, 0x4000, unchecked((short)0x8000));
        }
#else
            get;
        } = Vector512s<short>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <inheritdoc cref="Vector512s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 32-bit.</remarks>
        /// <seealso cref="Vector512s{T}.MaskBitPosSerialRotate"/>
        public static Vector512<int> MaskBitPosSerialRotate32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((int)1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80, 1, 2, 4, 8, 0x10, 0x20, 0x40, 0x80);
        }
#else
            get;
        } = Vector512s<int>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <inheritdoc cref="Vector512s{T}.MaskBitPosSerialRotate"/>
        /// <remarks>For 64-bit.</remarks>
        /// <seealso cref="Vector512s{T}.MaskBitPosSerialRotate"/>
        public static Vector512<long> MaskBitPosSerialRotate64 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((long)1, 2, 4, 8, 1, 2, 4, 8);
        }
#else
            get;
        } = Vector512s<long>.MaskBitPosSerialRotate;
#endif // USE_VECTOR_CREATE

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> GetMaskBits<T>(int index) where T : struct {
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
                return Vector512s<T>.GetMaskBits(index);
#else
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
#endif // FALLBACK_USE_T
            }
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - SByte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> GetMaskBits_SByte(int index) {
            return GetMaskBits_Byte(index).AsSByte();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Byte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GetMaskBits_Byte(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector512.Create((byte)((1U << index) - 1));
#else
            return Vector512s<byte>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> GetMaskBits_Int16(int index) {
            return GetMaskBits_UInt16(index).AsInt16();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> GetMaskBits_UInt16(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector512.Create((ushort)((1U << index) - 1));
#else
            return Vector512s<ushort>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> GetMaskBits_Int32(int index) {
            return GetMaskBits_UInt32(index).AsInt32();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> GetMaskBits_UInt32(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector512.Create((uint)((1U << index) - 1));
#else
            return Vector512s<uint>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> GetMaskBits_Int64(int index) {
            return GetMaskBits_UInt64(index).AsInt64();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> GetMaskBits_UInt64(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector512.Create((ulong)((1UL << index) - 1));
#else
            return Vector512s<ulong>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - ExInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> GetMaskBits_ExInt128(int index) {
            return GetMaskBits_ExUInt128(index).ExAsExInt128();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - ExUInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> GetMaskBits_ExUInt128(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector512s.Create((ExUInt128)(((ExUInt128)1UL << index) - 1));
#else
            return Vector512s<ExUInt128>.GetMaskBits(index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

#if BCL_TYPE_INT128

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - Int128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> GetMaskBits_Int128(int index) {
            return GetMaskBits_ExUInt128(index).ExAsInt128();
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码) - UInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> GetMaskBits_UInt128(int index) {
            return GetMaskBits_ExUInt128(index).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetResidueMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> GetResidueMaskBits<T>(int index) where T : struct {
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
                return Vector512s<T>.GetMaskBits(Scalars<T>.BitSize - index);
#else
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
#endif // FALLBACK_USE_T
            }
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - SByte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetResidueMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> GetResidueMaskBits_SByte(int index) {
            return GetResidueMaskBits_Byte(index).AsSByte();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Byte. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GetResidueMaskBits_Byte(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector512.Create((byte)(byte.MaxValue >> index));
#else
            return Vector512s<byte>.GetMaskBits(8 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> GetResidueMaskBits_Int16(int index) {
            return GetResidueMaskBits_UInt16(index).AsInt16();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt16. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> GetResidueMaskBits_UInt16(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector512.Create((ushort)(ushort.MaxValue >> index));
#else
            return Vector512s<ushort>.GetMaskBits(16 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> GetResidueMaskBits_Int32(int index) {
            return GetResidueMaskBits_UInt32(index).AsInt32();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt32. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> GetResidueMaskBits_UInt32(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector512.Create((uint)(uint.MaxValue >> index));
#else
            return Vector512s<uint>.GetMaskBits(32 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> GetResidueMaskBits_Int64(int index) {
            return GetResidueMaskBits_UInt64(index).AsInt64();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt64. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> GetResidueMaskBits_UInt64(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector512.Create((ulong)(ulong.MaxValue >> index));
#else
            return Vector512s<ulong>.GetMaskBits(64 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - ExInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> GetResidueMaskBits_ExInt128(int index) {
            return GetResidueMaskBits_ExUInt128(index).ExAsExInt128();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - ExUInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> GetResidueMaskBits_ExUInt128(int index) {
#if USE_VECTOR_CREATE_BY_ARRAY
            return Vector512s.Create((ExUInt128)(ExUInt128.MaxValue >> index));
#else
            return Vector512s<ExUInt128>.GetMaskBits(64 - index);
#endif // USE_VECTOR_CREATE_BY_ARRAY
        }

#if BCL_TYPE_INT128

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - Int128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> GetResidueMaskBits_Int128(int index) {
            return GetResidueMaskBits_ExUInt128(index).ExAsInt128();
        }

        /// <summary>
        /// Get residue bits mask by index (根据索引获取剩余的位集掩码) - UInt128. The index value ranges from 0 to <c>sizeof(T)*8-1</c> (索引值的范围是 0 ~ <c>sizeof(T)*8-1</c>).
        /// The equivalent of <c>Vector512s&lt;T&gt;.GetMaskBits(sizeof(T)*8 - index)</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>sizeof(T)*8-1</c> (值的范围是 0 ~ <c>sizeof(T)*8-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        /// <remarks>
        /// It performs better than <see cref="Vector512s{T}.GetMaskBits(int)"/> when running net5+.
        /// </remarks>
        /// <seealso cref="Vector512s{T}.GetMaskBits(int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> GetResidueMaskBits_UInt128(int index) {
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
        public static Vector512<byte> YBitToByte_Shuffle_Indices {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7);
        }
#else
            get;
        } = Vector512.Create((byte)0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>ExtractMostSignificantBits - Shuffle - Get high byte of 16bit.</summary>
        public static Vector512<byte> ExtractMostSignificantBits_Shuffle_HiByteOf16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80);
        }
#else
            get;
        } = Vector512.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80);
#endif // USE_VECTOR_CREATE

        /// <summary>NarrowSaturate - Permute index - Int64.</summary>
        [CLSCompliant(false)]
        public static Vector512<long> NarrowSaturate_Permute_Index64 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((long)0L, 2, 4, 6, 1, 3, 5, 7);
        }
#else
            get;
        } = Vector512.Create((long)0L, 2, 4, 6, 1, 3, 5, 7);
#endif // USE_VECTOR_CREATE


        /// <summary>Shuffle - UInt16 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> Shuffle_UInt16_Multiplier {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)0x202);
        }
#else
            get;
        } = Vector512.Create((ushort)0x202);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt16 - The offset of each byte within an element.</summary>
        public static Vector512<byte> Shuffle_UInt16_ByteOffset {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1);
        }
#else
            get;
        } = Vector512s.CreateRotate<byte>(0, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt64 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> Shuffle_UInt64_Multiplier {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0x200000002UL);
        }
#else
            get;
        } = Vector512.Create((ulong)0x200000002UL);
#endif // USE_VECTOR_CREATE

        /// <summary>Shuffle - UInt64 - The offset of each byte within an element.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> Shuffle_UInt64_UInt32Offset {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1);
        }
#else
            get;
        } = Vector512s.CreateRotate<uint>(0, 1);
#endif // USE_VECTOR_CREATE


        private static readonly Vector512<byte>[] m_YShuffleG2_Byte_Indices = {
            Vector512.Create((byte)0, 0, 2, 2, 4, 4, 6, 6, 8, 8, 10, 10, 12, 12, 14, 14, 16, 16, 18, 18, 20, 20, 22, 22, 24, 24, 26, 26, 28, 28, 30, 30, 32, 32, 34, 34, 36, 36, 38, 38, 40, 40, 42, 42, 44, 44, 46, 46, 48, 48, 50, 50, 52, 52, 54, 54, 56, 56, 58, 58, 60, 60, 62, 62), // XX
            Vector512.Create((byte)1, 0, 3, 2, 5, 4, 7, 6, 9, 8, 11, 10, 13, 12, 15, 14, 17, 16, 19, 18, 21, 20, 23, 22, 25, 24, 27, 26, 29, 28, 31, 30, 33, 32, 35, 34, 37, 36, 39, 38, 41, 40, 43, 42, 45, 44, 47, 46, 49, 48, 51, 50, 53, 52, 55, 54, 57, 56, 59, 58, 61, 60, 63, 62), // YX
            Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63), // XY
            Vector512.Create((byte)1, 1, 3, 3, 5, 5, 7, 7, 9, 9, 11, 11, 13, 13, 15, 15, 17, 17, 19, 19, 21, 21, 23, 23, 25, 25, 27, 27, 29, 29, 31, 31, 33, 33, 35, 35, 37, 37, 39, 39, 41, 41, 43, 43, 45, 45, 47, 47, 49, 49, 51, 51, 53, 53, 55, 55, 57, 57, 59, 59, 61, 61, 63, 63), // YY
        };
        /// <summary>YShuffleG2 - Byte - The indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GetYShuffleG2_Byte_Indices(ShuffleControlG2 index) {
            return m_YShuffleG2_Byte_Indices[(byte)index];
        }

        private static readonly Vector512<byte>[] m_YShuffleG2_UInt16_ByteIndices = {
            Vector512.Create((byte)0, 1, 0, 1, 4, 5, 4, 5, 8, 9,  8,  9, 12, 13, 12, 13, 16, 17, 16, 17, 20, 21, 20, 21, 24, 25, 24, 25, 28, 29, 28, 29, 32, 33, 32, 33, 36, 37, 36, 37, 40, 41, 40, 41, 44, 45, 44, 45, 48, 49, 48, 49, 52, 53, 52, 53, 56, 57, 56, 57, 60, 61, 60, 61), // XX
            Vector512.Create((byte)2, 3, 0, 1, 6, 7, 4, 5, 10, 11, 8, 9, 14, 15, 12, 13, 18, 19, 16, 17, 22, 23, 20, 21, 26, 27, 24, 25, 30, 31, 28, 29, 34, 35, 32, 33, 38, 39, 36, 37, 42, 43, 40, 41, 46, 47, 44, 45, 50, 51, 48, 49, 54, 55, 52, 53, 58, 59, 56, 57, 62, 63, 60, 61), // YX
            Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63), // XY
            Vector512.Create((byte)2, 3, 2, 3, 6, 7, 6, 7,10,11, 10, 11, 14, 15, 14, 15, 18, 19, 18, 19, 22, 23, 22, 23, 26, 27, 26, 27, 30, 31, 30, 31, 34, 35, 34, 35, 38, 39, 38, 39, 42, 43, 42, 43, 46, 47, 46, 47, 50, 51, 50, 51, 54, 55, 54, 55, 58, 59, 58, 59, 62, 63, 62, 63), // YY
        };
        /// <summary>YShuffleG2 - UInt16 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GetYShuffleG2_UInt16_ByteIndices(ShuffleControlG2 index) {
            return m_YShuffleG2_UInt16_ByteIndices[(byte)index];
        }

#if !REDUCE_MEMORY_USAGE
        private static readonly Vector512<uint>[] m_YShuffleG2_UInt32_Indices = {
            Vector512.Create((uint)0, 0, 2, 2, 4, 4, 6, 6, 0, 0, 2, 2, 4, 4, 6, 6), // XX
            Vector512.Create((uint)1, 0, 3, 2, 5, 4, 7, 6, 1, 0, 3, 2, 5, 4, 7, 6), // YX
            Vector512.Create((uint)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7), // XY
            Vector512.Create((uint)1, 1, 3, 3, 5, 5, 7, 7, 1, 1, 3, 3, 5, 5, 7, 7), // YY
        };
        /// <summary>YShuffleG2 - UInt32 - The uint32 indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> GetYShuffleG2_UInt32_Indices(ShuffleControlG2 index) {
            return m_YShuffleG2_UInt32_Indices[(byte)index];
        }
#endif // !REDUCE_MEMORY_USAGE

        private static readonly Vector512<byte>[] m_YShuffleG2_UInt32_ByteIndices = {
            Vector512.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 8, 9, 10, 11,  8,  9, 10, 11, 16, 17, 18, 19, 16, 17, 18, 19, 24, 25, 26, 27, 24, 25, 26, 27, 32, 33, 34, 35, 32, 33, 34, 35, 40, 41, 42, 43, 40, 41, 42, 43, 48, 49, 50, 51, 48, 49, 50, 51, 56, 57, 58, 59, 56, 57, 58, 59), // XX
            Vector512.Create((byte)4, 5, 6, 7, 0, 1, 2, 3, 12, 13, 14, 15, 8, 9, 10, 11, 20, 21, 22, 23, 16, 17, 18, 19, 28, 29, 30, 31, 24, 25, 26, 27, 36, 37, 38, 39, 32, 33, 34, 35, 44, 45, 46, 47, 40, 41, 42, 43, 52, 53, 54, 55, 48, 49, 50, 51, 60, 61, 62, 63, 56, 57, 58, 59), // YX
            Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63), // XY
            Vector512.Create((byte)4, 5, 6, 7, 4, 5, 6, 7,12,13, 14, 15, 12, 13, 14, 15, 20, 21, 22, 23, 20, 21, 22, 23, 28, 29, 30, 31, 28, 29, 30, 31, 36, 37, 38, 39, 36, 37, 38, 39, 44, 45, 46, 47, 44, 45, 46, 47, 52, 53, 54, 55, 52, 53, 54, 55, 60, 61, 62, 63, 60, 61, 62, 63), // YY
        };
        /// <summary>YShuffleG2 - UInt32 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GetYShuffleG2_UInt32_ByteIndices(ShuffleControlG2 index) {
            return m_YShuffleG2_UInt32_ByteIndices[(byte)index];
        }

        private static readonly Vector512<byte>[] m_YShuffleG2_UInt64_ByteIndices = {
            Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1,  2,  3,  4,  5,  6,  7, 16, 17, 18, 19, 20, 21, 22, 23, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 32, 33, 34, 35, 36, 37, 38, 39, 48, 49, 50, 51, 52, 53, 54, 55, 48, 49, 50, 51, 52, 53, 54, 55), // XX
            Vector512.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31, 16, 17, 18, 19, 20, 21, 22, 23, 40, 41, 42, 43, 44, 45, 46, 47, 32, 33, 34, 35, 36, 37, 38, 39, 56, 57, 58, 59, 60, 61, 62, 63, 48, 49, 50, 51, 52, 53, 54, 55), // YX
            Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63), // XY
            Vector512.Create((byte)8, 9,10,11,12,13,14,15, 8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31, 40, 41, 42, 43, 44, 45, 46, 47, 40, 41, 42, 43, 44, 45, 46, 47, 56, 57, 58, 59, 60, 61, 62, 63, 56, 57, 58, 59, 60, 61, 62, 63), // YY
        };
        /// <summary>YShuffleG2 - UInt64 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GetYShuffleG2_UInt64_ByteIndices(ShuffleControlG2 index) {
            return m_YShuffleG2_UInt64_ByteIndices[(byte)index];
        }


        private static readonly Vector512<byte>[] m_YShuffleG4_Byte_Indices = new Vector512<byte>[512];
        /// <summary>YShuffleG4 - Byte - The indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GetYShuffleG4_Byte_Indices(ShuffleControlG4 index) {
            return m_YShuffleG4_Byte_Indices[(byte)index];
        }

        private static readonly Vector512<byte>[] m_YShuffleG4_UInt16_ByteIndices = new Vector512<byte>[512];
        /// <summary>YShuffleG4 - UInt16 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GetYShuffleG4_UInt16_ByteIndices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt16_ByteIndices[(byte)index];
        }

#if !REDUCE_MEMORY_USAGE
        private static readonly Vector512<uint>[] m_YShuffleG4_UInt32_Indices = new Vector512<uint>[512];
        /// <summary>YShuffleG4 - UInt32 - The indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> GetYShuffleG4_UInt32_Indices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt32_Indices[(nint)(uint)index];
        }
#endif // !REDUCE_MEMORY_USAGE

        private static readonly Vector512<byte>[] m_YShuffleG4_UInt32_ByteIndices = new Vector512<byte>[512];
        /// <summary>YShuffleG4 - UInt32 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GetYShuffleG4_UInt32_ByteIndices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt32_ByteIndices[(byte)index];
        }

        private static readonly Vector512<byte>[] m_YShuffleG4_UInt64_ByteIndices = new Vector512<byte>[512];
        /// <summary>YShuffleG4 - UInt64 - The byte indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GetYShuffleG4_UInt64_ByteIndices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt64_ByteIndices[(byte)index];
        }

        private static readonly Vector512<uint>[] m_YShuffleG4_UInt64_UInt32Indices = new Vector512<uint>[512];
        /// <summary>YShuffleG4 - UInt64 - The UInt32 indices.</summary>
        /// <param name="index">The index (索引).</param>
        /// <returns>Return vector value (返回向量值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> GetYShuffleG4_UInt64_UInt32Indices(ShuffleControlG4 index) {
            return m_YShuffleG4_UInt64_UInt32Indices[(nint)(uint)index];
        }

        #endregion // TraitsMethod

        static Vector512Constants() {
            // == YShuffleG4 ==
            for (int ctl = 0; ctl <= 255; ++ctl) {
                int idx;
                Vector512<byte> indices = default;
                ref byte q = ref Unsafe.As<Vector512<byte>, byte>(ref indices);
                // -- Byte --
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = (byte)selectedIndex;
                }
                m_YShuffleG4_Byte_Indices[ctl] = indices;
                // -- UInt16 --
                Vector512<ushort> indicesUInt16 = default;
                ref ushort qUInt16 = ref Unsafe.As<Vector512<ushort>, ushort>(ref indicesUInt16);
                idx = 0;
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
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
                Vector512<uint> indicesUInt32 = default;
                ref uint qUInt32 = ref Unsafe.As<Vector512<uint>, uint>(ref indicesUInt32);
                idx = 0;
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
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
                Vector512<ulong> indicesUInt64 = default;
                ref ulong qUInt64 = ref Unsafe.As<Vector512<ulong>, ulong>(ref indicesUInt64);
                idx = 0;
                int idxUInt32 = 0;
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
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
