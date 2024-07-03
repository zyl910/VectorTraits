#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits {
    /// <summary>
    /// Methods of scalar (标量的方法).
    /// </summary>
    public static partial class Scalars {

        /// <summary>
        /// Converts a <see cref="double"/> to the target type value (将 <see cref="double"/> 转换为目标类型值).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>Returns target type value (返回目标类型的值).</returns>
        public static T GetByDouble<T>(double src) {
            unchecked {
                if (typeof(T) == typeof(Single)) {
                    return (T)(object)(Single)src;
                } else if (typeof(T) == typeof(Double)) {
                    return (T)(object)src;
                } else if (typeof(T) == typeof(SByte)) {
                    return (T)(object)(SByte)src;
                } else if (typeof(T) == typeof(Int16)) {
                    return (T)(object)(Int16)src;
                } else if (typeof(T) == typeof(Int32)) {
                    return (T)(object)(Int32)src;
                } else if (typeof(T) == typeof(Int64)) {
                    return (T)(object)(Int64)src;
                } else if (typeof(T) == typeof(ExInt128)) {
                    return (T)(object)(ExInt128)src;
#if BCL_TYPE_INT128
                } else if (typeof(T) == typeof(Int128)) {
                    return (T)(object)(Int128)src;
#endif // BCL_TYPE_INT128
                } else if (typeof(T) == typeof(Byte)) {
                    return (T)(object)((src >= 0) ? (Byte)src : (Byte)(SByte)src);
                } else if (typeof(T) == typeof(UInt16)) {
                    return (T)(object)((src >= 0) ? (UInt16)src : (UInt16)(Int16)src);
                } else if (typeof(T) == typeof(UInt32)) {
                    return (T)(object)((src >= 0) ? (UInt32)src : (UInt32)(Int32)src);
                } else if (typeof(T) == typeof(UInt64)) {
                    return (T)(object)((src >= 0) ? (UInt64)src : (UInt64)(Int64)src);
                } else if (typeof(T) == typeof(ExUInt128)) {
                    return (T)(object)((src >= 0) ? (ExUInt128)src : (ExUInt128)(ExInt128)src);
#if BCL_TYPE_INT128
                } else if (typeof(T) == typeof(UInt128)) {
                    return (T)(object)((src >= 0) ? (UInt128)src : (UInt128)(Int128)src);
#endif // BCL_TYPE_INT128
                } else if (typeof(T) == typeof(IntPtr)) {
                    return (T)(object)(IntPtr)(long)src;
                } else if (typeof(T) == typeof(UIntPtr)) {
#if NET7_0_OR_GREATER
                    return (T)(object)((src >= 0) ? (UIntPtr)src : (UIntPtr)(IntPtr)src);
#else
                    return (T)(object)((src >= 0) ? (UIntPtr)src : (UIntPtr)(long)src);
#endif // NET7_0_OR_GREATER
#if BCL_TYPE_HALF
                } else if (typeof(T) == typeof(Half)) {
                    return (T)(object)(Half)src;
#endif // BCL_TYPE_HALF
                } else {
                    return (T)Convert.ChangeType(src, typeof(T));
                }
            }
        }

        /// <summary>
        /// Converts a <see cref="double"/> to the fixed point number of the target type (将 <see cref="double"/> 转换为目标类型的定点数). Use the <paramref name="fixedOne"/> parameter (使用 <paramref name="fixedOne"/> 参数).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <param name="fixedOne">The fixed point number of the value 1 (值1的定点数)</param>
        /// <returns>Returns target type value (返回目标类型的值).</returns>
        public static T GetFixedByDoubleUseOne<T>(double src, double fixedOne) {
            return GetByDouble<T>(src * fixedOne);
        }

        /// <summary>
        /// Converts a <see cref="double"/> to the fixed point number of the target type (将 <see cref="double"/> 转换为目标类型的定点数).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <param name="shift">Binary shift of fixed point number (定点数的位移).</param>
        /// <returns>Returns target type value (返回目标类型的值).</returns>
        public static T GetFixedByDouble<T>(double src, int shift) {
            double fixedOne = Math.Pow(2.0, shift);
            return GetFixedByDoubleUseOne<T>(src, fixedOne);
        }

        /// <summary>
        /// Converts a 128-bits to the target type value (将128位整数位转换为目标类型值).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>Returns target type value (返回目标类型的值).</returns>
        public static T GetBy128Bits<T>(ExInt128 src) {
            if (typeof(T) == typeof(float)) {
                return (T)(object)BitMath.Int32BitsToSingle((int)src);
            } else if (typeof(T) == typeof(double)) {
                return (T)(object)BitMath.Int64BitsToDouble((long)src);
            } else if (typeof(T) == typeof(sbyte)) {
                return (T)(object)(sbyte)src;
            } else if (typeof(T) == typeof(short)) {
                return (T)(object)(short)src;
            } else if (typeof(T) == typeof(int)) {
                return (T)(object)(int)src;
            } else if (typeof(T) == typeof(long)) {
                return (T)(object)(long)src;
            } else if (typeof(T) == typeof(byte)) {
                return (T)(object)(byte)src;
            } else if (typeof(T) == typeof(ushort)) {
                return (T)(object)(ushort)src;
            } else if (typeof(T) == typeof(uint)) {
                return (T)(object)(uint)src;
            } else if (typeof(T) == typeof(ulong)) {
                return (T)(object)(ulong)src;
            } else if (typeof(T) == typeof(ExInt128)) {
                return (T)(object)(ExInt128)src;
            } else if (typeof(T) == typeof(ExUInt128)) {
                return (T)(object)(ExUInt128)src;
#if BCL_TYPE_INT128
            } else if (typeof(T) == typeof(Int128)) {
                return (T)(object)(Int128)src;
            } else if (typeof(T) == typeof(UInt128)) {
                return (T)(object)(UInt128)src;
#endif // BCL_TYPE_INT128
            } else if (typeof(T) == typeof(IntPtr)) {
                return (T)(object)(IntPtr)(long)src;
            } else if (typeof(T) == typeof(UIntPtr)) {
                return (T)(object)(UIntPtr)(ulong)src;
#if BCL_TYPE_HALF
            } else if (typeof(T) == typeof(Half)) {
                return (T)(object)BitMath.Int16BitsToHalf((short)src);
#endif // BCL_TYPE_HALF
            } else {
                return (T)Convert.ChangeType(src, typeof(T));
            }
        }

        /// <summary>
        /// Converts a bits to the target type value (将整数位转换为目标类型值).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>Returns target type value (返回目标类型的值).</returns>
        public static T GetByBits<T>(long src) {
            if (typeof(T) == typeof(float)) {
                return (T)(object)BitMath.Int32BitsToSingle((int)src);
            } else if (typeof(T) == typeof(double)) {
                return (T)(object)BitMath.Int64BitsToDouble(src);
            } else if (typeof(T) == typeof(sbyte)) {
                return (T)(object)(sbyte)src;
            } else if (typeof(T) == typeof(short)) {
                return (T)(object)(short)src;
            } else if (typeof(T) == typeof(int)) {
                return (T)(object)(int)src;
            } else if (typeof(T) == typeof(long)) {
                return (T)(object)(long)src;
            } else if (typeof(T) == typeof(byte)) {
                return (T)(object)(byte)src;
            } else if (typeof(T) == typeof(ushort)) {
                return (T)(object)(ushort)src;
            } else if (typeof(T) == typeof(uint)) {
                return (T)(object)(uint)src;
            } else if (typeof(T) == typeof(ulong)) {
                return (T)(object)(ulong)src;
            } else if (typeof(T) == typeof(ExInt128)) {
                return (T)(object)(ExInt128)src;
            } else if (typeof(T) == typeof(ExUInt128)) {
                return (T)(object)(ExUInt128)src;
#if BCL_TYPE_INT128
            } else if (typeof(T) == typeof(Int128)) {
                return (T)(object)(Int128)src;
            } else if (typeof(T) == typeof(UInt128)) {
                return (T)(object)(UInt128)src;
#endif // BCL_TYPE_INT128
            } else if (typeof(T) == typeof(IntPtr)) {
                return (T)(object)(IntPtr)(long)src;
            } else if (typeof(T) == typeof(UIntPtr)) {
                return (T)(object)(UIntPtr)(ulong)src;
#if BCL_TYPE_HALF
            } else if (typeof(T) == typeof(Half)) {
                return (T)(object)BitMath.Int16BitsToHalf((short)src);
#endif // BCL_TYPE_HALF
            } else {
                return (T)Convert.ChangeType(src, typeof(T));
            }
        }

        /// <summary>
        /// Get a <see cref="double"/> from target type value (从目标类型取得 <see cref="double"/> 类型的值).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>Returns a <see cref="double"/> value (返回 <see cref="double"/> 类型的值).</returns>
        public static double GetDoubleFrom<T>(T src) where T : struct {
            if (typeof(T) == typeof(float)) {
                return (double)(float)(object)src;
            } else if (typeof(T) == typeof(double)) {
                return (double)(double)(object)src;
            } else if (typeof(T) == typeof(sbyte)) {
                return (double)(sbyte)(object)src;
            } else if (typeof(T) == typeof(short)) {
                return (double)(short)(object)src;
            } else if (typeof(T) == typeof(int)) {
                return (double)(int)(object)src;
            } else if (typeof(T) == typeof(long)) {
                return (double)(long)(object)src;
            } else if (typeof(T) == typeof(byte)) {
                return (double)(byte)(object)src;
            } else if (typeof(T) == typeof(ushort)) {
                return (double)(ushort)(object)src;
            } else if (typeof(T) == typeof(uint)) {
                return (double)(uint)(object)src;
            } else if (typeof(T) == typeof(ulong)) {
                return (double)(ulong)(object)src;
            } else if (typeof(T) == typeof(ExInt128)) {
                return (double)(ExInt128)(object)src;
            } else if (typeof(T) == typeof(ExUInt128)) {
                return (double)(ExUInt128)(object)src;
#if BCL_TYPE_INT128
            } else if (typeof(T) == typeof(Int128)) {
                return (double)(Int128)(object)src;
            } else if (typeof(T) == typeof(UInt128)) {
                return (double)(UInt128)(object)src;
#endif // BCL_TYPE_INT128
            } else if (typeof(T) == typeof(IntPtr)) {
                return (double)(IntPtr)(object)src;
            } else if (typeof(T) == typeof(UIntPtr)) {
                return (double)(UIntPtr)(object)src;
#if BCL_TYPE_HALF
            } else if (typeof(T) == typeof(Half)) {
                return (double)(Half)(object)src;
#endif // BCL_TYPE_HALF
            } else {
                return (double)Convert.ChangeType(src, typeof(double));
            }
        }

        /// <summary>
        /// Get a <see cref="ExInt128"/> bits from target type value (从目标类型取得 <see cref="ExInt128"/> 类型的128位值).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>Returns a <see cref="ExInt128"/> bits (返回 <see cref="ExInt128"/> 类型的128位值).</returns>
        public static ExInt128 GetInt128BitsFrom<T>(T src) where T : struct {
            if (typeof(T) == typeof(float)) {
                return (ExInt128)BitMath.SingleToInt32Bits((float)(object)src);
            } else if (typeof(T) == typeof(double)) {
                return (ExInt128)BitMath.DoubleToInt64Bits((double)(object)src);
            } else if (typeof(T) == typeof(sbyte)) {
                return (ExInt128)(sbyte)(object)src;
            } else if (typeof(T) == typeof(short)) {
                return (ExInt128)(short)(object)src;
            } else if (typeof(T) == typeof(int)) {
                return (ExInt128)(int)(object)src;
            } else if (typeof(T) == typeof(long)) {
                return (ExInt128)(long)(object)src;
            } else if (typeof(T) == typeof(byte)) {
                return (ExInt128)(byte)(object)src;
            } else if (typeof(T) == typeof(ushort)) {
                return (ExInt128)(ushort)(object)src;
            } else if (typeof(T) == typeof(uint)) {
                return (ExInt128)(uint)(object)src;
            } else if (typeof(T) == typeof(ulong)) {
                return (ExInt128)(ulong)(object)src;
            } else if (typeof(T) == typeof(ExInt128)) {
                return (ExInt128)(ExInt128)(object)src;
            } else if (typeof(T) == typeof(ExUInt128)) {
                return (ExInt128)(ExUInt128)(object)src;
#if BCL_TYPE_INT128
            } else if (typeof(T) == typeof(Int128)) {
                return (ExInt128)(Int128)(object)src;
            } else if (typeof(T) == typeof(UInt128)) {
                return (ExInt128)(UInt128)(object)src;
#endif // BCL_TYPE_INT128
            } else if (typeof(T) == typeof(IntPtr)) {
                return (ExInt128)(IntPtr)(object)src;
            } else if (typeof(T) == typeof(UIntPtr)) {
                return (ExInt128)(UIntPtr)(object)src;
#if BCL_TYPE_HALF
            } else if (typeof(T) == typeof(Half)) {
                return (ExInt128)BitMath.HalfToInt16Bits((Half)(object)src);
#endif // BCL_TYPE_HALF
            } else {
                return (ExInt128)Convert.ChangeType(src, typeof(long));
            }
        }

        /// <summary>
        /// Get a <see cref="long"/> bits from target type value (从目标类型取得 <see cref="long"/> 类型的64位值).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>Returns a <see cref="long"/> bits (返回 <see cref="long"/> 类型的64位值).</returns>
        public static long GetInt64BitsFrom<T>(T src) where T:struct {
            if (typeof(T) == typeof(float)) {
                return (long)BitMath.SingleToInt32Bits((float)(object)src);
            } else if (typeof(T) == typeof(double)) {
                return (long)BitMath.DoubleToInt64Bits((double)(object)src);
            } else if (typeof(T) == typeof(sbyte)) {
                return (long)(sbyte)(object)src;
            } else if (typeof(T) == typeof(short)) {
                return (long)(short)(object)src;
            } else if (typeof(T) == typeof(int)) {
                return (long)(int)(object)src;
            } else if (typeof(T) == typeof(long)) {
                return (long)(long)(object)src;
            } else if (typeof(T) == typeof(byte)) {
                return (long)(byte)(object)src;
            } else if (typeof(T) == typeof(ushort)) {
                return (long)(ushort)(object)src;
            } else if (typeof(T) == typeof(uint)) {
                return (long)(uint)(object)src;
            } else if (typeof(T) == typeof(ulong)) {
                return (long)(ulong)(object)src;
            } else if (typeof(T) == typeof(ExInt128)) {
                return (long)(ExInt128)(object)src;
            } else if (typeof(T) == typeof(ExUInt128)) {
                return (long)(ExUInt128)(object)src;
#if BCL_TYPE_INT128
            } else if (typeof(T) == typeof(Int128)) {
                return (long)(Int128)(object)src;
            } else if (typeof(T) == typeof(UInt128)) {
                return (long)(UInt128)(object)src;
#endif // BCL_TYPE_INT128
            } else if (typeof(T) == typeof(IntPtr)) {
                return (long)(IntPtr)(object)src;
            } else if (typeof(T) == typeof(UIntPtr)) {
                return (long)(UIntPtr)(object)src;
#if BCL_TYPE_HALF
            } else if (typeof(T) == typeof(Half)) {
                return (long)BitMath.HalfToInt16Bits((Half)(object)src);
#endif // BCL_TYPE_HALF
            } else {
                return (long)Convert.ChangeType(src, typeof(long));
            }
        }

        /// <summary>
        /// Get 64-bit's bits mask (取得64位的掩码).
        /// </summary>
        /// <param name="start">Bits start (起始位).</param>
        /// <param name="len">Bits length (位长度).</param>
        /// <returns>Returns mask (返回掩码).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long GetBitsMask64(int start, int len) {
            unchecked {
                if (len <= 0) return 0L;
                int n = sizeof(long) * 8 - len;
                if (n < 0) n = 0;
                ulong rt = (((ulong)~0L) >> n) << start;
                return (long)rt;
            }
        }

        /// <summary>
        /// Get 128-bit's bits mask (取得128位的掩码).
        /// </summary>
        /// <param name="start">Bits start (起始位).</param>
        /// <param name="len">Bits length (位长度).</param>
        /// <returns>Returns mask (返回掩码).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExInt128 GetBitsMask128(int start, int len) {
            const int BitTotal = 128; // Unsafe.SizeOf<ExInt128>() * 8
            unchecked {
                if (len <= 0) return 0;
                int n = BitTotal - len;
                if (n < 0) n = 0;
                ExUInt128 rt = (((ExUInt128)~0L) >> n) << start;
                return (ExInt128)rt;
            }
        }

        /// <summary>
        /// Get bits mask (取得位掩码).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="start">Bits start (起始位).</param>
        /// <param name="len">Bits length (位长度).</param>
        /// <returns>Returns mask (返回掩码).</returns>
        public static T GetBitsMask<T>(int start, int len) {
            if (IsLeast128<T>()) {
                return GetBy128Bits<T>(GetBitsMask128(start, len));
            } else {
                return GetByBits<T>(GetBitsMask64(start, len));
            }
        }

        /// <summary>
        /// Does it have at least 128 bits (它是否至少有128位).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <returns><c>true</c> if it have at least 128 bits; otherwise is <c>false</c> (它至少有128位时返回 <c>true</c>, 否则返回<c>false</c>).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLeast128<T>() {
            return Unsafe.SizeOf<T>() >= 16;
        }

        /// <summary>
        /// Limit shift amount to a valid range by <paramref name="bitSize"/> (根据 <paramref name="bitSize"/> 将位移量限制在有效范围).
        /// </summary>
        /// <param name="shiftAmount">Shift amount (位移量).</param>
        /// <param name="bitSize">Bit size (位数).</param>
        /// <returns>Returns the value of <paramref name="shiftAmount"/> after it has been limited (返回 <paramref name="shiftAmount"/> 被限制后的值).</returns>
        public static int LimitShiftAmountByBitSize(int shiftAmount, int bitSize) {
            return shiftAmount & (bitSize - 1);
        }

        /// <summary>
        /// Limit shift amount to a valid range (将位移量限制在有效范围).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="shiftAmount">Shift amount (位移量).</param>
        /// <returns>Returns the value of <paramref name="shiftAmount"/> after it has been limited (返回 <paramref name="shiftAmount"/> 被限制后的值).</returns>
        public static int LimitShiftAmount<T>(int shiftAmount) where T : struct {
            return LimitShiftAmountByBitSize(shiftAmount, Scalars<T>.BitSize);
        }


        /// <summary>
        /// Computes the ones-complement(~) (按位取反运算).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The ones-complement value (按位取反后的值).</returns>
        public static T OnesComplement<T>(T src) where T:struct {
            if (IsLeast128<T>()) {
                ExInt128 m = ~GetInt128BitsFrom(src);
                return GetBy128Bits<T>(m);
            } else {
                long m = ~GetInt64BitsFrom(src);
                return GetByBits<T>(m);
            }
        }

    }

}