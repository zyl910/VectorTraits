using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

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
                } else if (typeof(T) == typeof(Byte)) {
                    return (T)(object)((0 != (Byte)src) ? (Byte)src : (Byte)(SByte)src);
                } else if (typeof(T) == typeof(UInt16)) {
                    return (T)(object)((0 != (UInt16)src) ? (UInt16)src : (UInt16)(Int16)src);
                } else if (typeof(T) == typeof(UInt32)) {
                    return (T)(object)((0 != (UInt32)src) ? (UInt32)src : (UInt32)(Int32)src);
                } else if (typeof(T) == typeof(UInt64)) {
                    return (T)(object)((0 != (UInt64)src) ? (UInt64)src : (UInt64)(Int64)src);
                } else if (typeof(T) == typeof(IntPtr)) {
                    return (T)(object)(IntPtr)(long)src;
                } else if (typeof(T) == typeof(UIntPtr)) {
#if NET7_0_OR_GREATER
                    return (T)(object)((0 != (UIntPtr)src) ? (UIntPtr)src : (UIntPtr)(IntPtr)src);
#else
                    return (T)(object)((0 != (ulong)(UIntPtr)src) ? (UIntPtr)src : (UIntPtr)(long)src);
#endif // NET7_0_OR_GREATER
#if NET5_0_OR_GREATER
                } else if (typeof(T) == typeof(Half)) {
                    return (T)(object)(Half)src;
#endif // NET5_0_OR_GREATER
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
            } else if (typeof(T) == typeof(IntPtr)) {
                return (T)(object)(IntPtr)(long)src;
            } else if (typeof(T) == typeof(UIntPtr)) {
                return (T)(object)(UIntPtr)(ulong)src;
#if NET5_0_OR_GREATER
            } else if (typeof(T) == typeof(Half)) {
                return (T)(object)BitMath.Int16BitsToHalf((short)src);
#endif // NET5_0_OR_GREATER
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
            } else if (typeof(T) == typeof(IntPtr)) {
                return (double)(IntPtr)(object)src;
            } else if (typeof(T) == typeof(UIntPtr)) {
                return (double)(UIntPtr)(object)src;
#if NET5_0_OR_GREATER
            } else if (typeof(T) == typeof(Half)) {
                return (double)(Half)(object)src;
#endif // NET5_0_OR_GREATER
            } else {
                return (double)Convert.ChangeType(src, typeof(double));
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
            } else if (typeof(T) == typeof(IntPtr)) {
                return (long)(IntPtr)(object)src;
            } else if (typeof(T) == typeof(UIntPtr)) {
                return (long)(UIntPtr)(object)src;
#if NET5_0_OR_GREATER
            } else if (typeof(T) == typeof(Half)) {
                return (long)BitMath.HalfToInt16Bits((Half)(object)src);
#endif // NET5_0_OR_GREATER
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
        /// Get bits mask (取得位掩码).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="start">Bits start (起始位).</param>
        /// <param name="len">Bits length (位长度).</param>
        /// <returns>Returns mask (返回掩码).</returns>
        public static T GetBitsMask<T>(int start, int len) {
            return GetByBits<T>(GetBitsMask64(start, len));
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
            long m = ~GetInt64BitsFrom(src);
            return GetByBits<T>(m);
        }

    }

}