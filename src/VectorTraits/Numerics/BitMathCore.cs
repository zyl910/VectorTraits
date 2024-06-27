﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Numerics {
    using static MathBitConverter;

    /// <summary>
    /// Provides constants and static methods for binary operations, and other common mathematical functions (为二进制运算和其他通用数学函数提供常数和静态方法).
    /// </summary>
    public abstract class BitMathCore {

        /// <summary>
        /// Is 64bit system (是不是64位系统).
        /// </summary>
        public static bool Is64Bit {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                return IntPtr.Size == sizeof(ulong);
            }
        }

        /// <summary>
        /// Make the shuffle control code for selecting four 2-bit values (制作shuffle控制码, 用于选择4个2位值).
        /// </summary>
        /// <param name="fp3">The 3rd 2-bit value (第3个2位值).</param>
        /// <param name="fp2">The 2nd 2-bit value (第2个2位值).</param>
        /// <param name="fp1">The 1st 2-bit value (第1个2位值).</param>
        /// <param name="fp0">The 0th 2-bit value (第0个2位值).</param>
        /// <returns>Returns shuffle control code (返回shuffle控制码).</returns>
        /// <remarks>
        /// <para>"xmmintrin.h": MACRO for shuffle parameter for _mm_shuffle_ps().</para>
        /// <para>Argument fp3 is a digit[0123] that represents the fp from argument "b" of mm_shuffle_ps that will be placed in fp3 of result. fp2 is the same for fp2 in result.</para>
        /// <para>fp1 is a digit[0123] that represents the fp from argument "a" of mm_shuffle_ps that will be places in fp1 of result. fp0 is the same for fp0 of result.</para>
        /// </remarks>
        /// <seealso cref="GetByteByBit2"/>
        /// <seealso cref="_MM_SHUFFLE2"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte _MM_SHUFFLE(byte fp3, byte fp2, byte fp1, byte fp0) {
            return GetByteByBit2(fp3, fp2, fp1, fp0);
        }

        /// <summary>
        /// Make the shuffle control code for selecting two 1-bit values (制作shuffle控制码, 用于选择2个1位值).
        /// </summary>
        /// <param name="x">The 1st 1-bit value (第1个1位值).</param>
        /// <param name="y">The 0th 1-bit value (第0个1位值).</param>
        /// <returns>Returns shuffle control code (返回shuffle控制码).</returns>
        /// <remarks>
        /// <para>"emmintrin.h": Macro function for shuffle.</para>
        /// </remarks>
        /// <seealso cref="_MM_SHUFFLE"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte _MM_SHUFFLE2(byte x, byte y) {
            return (byte)((x << 1) | y);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte BitSelect(sbyte condition, sbyte left, sbyte right) {
            return (sbyte)((left & condition) | (right & ~condition));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte BitSelect(byte condition, byte left, byte right) {
            return (byte)((left & condition) | (right & ~condition));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short BitSelect(short condition, short left, short right) {
            return (short)((left & condition) | (right & ~condition));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort BitSelect(ushort condition, ushort left, ushort right) {
            return (ushort)((left & condition) | (right & ~condition));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int BitSelect(int condition, int left, int right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint BitSelect(uint condition, uint left, uint right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BitSelect(long condition, long left, long right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BitSelect(ulong condition, ulong left, ulong right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint BitSelect(nint condition, nint left, nint right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint BitSelect(nuint condition, nuint left, nuint right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BitSelect(int condition, float left, float right) {
            return Int32BitsToSingle(BitSelect(condition, SingleToInt32Bits(left), SingleToInt32Bits(right)));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BitSelect(float condition, float left, float right) {
            return BitSelect(SingleToInt32Bits(condition), left, right);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double BitSelect(long condition, double left, double right) {
            return Int64BitsToDouble(BitSelect(condition, DoubleToInt64Bits(left), DoubleToInt64Bits(right)));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double BitSelect(double condition, double left, double right) {
            return BitSelect(DoubleToInt64Bits(condition), left, right);
        }

#if NET5_0_OR_GREATER

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half BitSelect(short condition, Half left, Half right) {
            return Int16BitsToHalf(BitSelect(condition, HalfToInt16Bits(left), HalfToInt16Bits(right)));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half BitSelect(Half condition, Half left, Half right) {
            return BitSelect(HalfToInt16Bits(condition), left, right);
        }

#endif // NET5_0_OR_GREATER

        ///// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        ///// <param name="value">The value to be clamped (要限制的值).</param>
        ///// <param name="amin">The lower bound of the result (结果的下限).</param>
        ///// <param name="amax">The upper bound of the result (结果的上限).</param>
        ///// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        ///// <seealso cref="Math.Clamp(decimal, decimal, decimal)"/>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static decimal Clamp(decimal value, decimal amin, decimal amax) {
        //    //return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        //    return Math.Min(Math.Max(value, amin), amax);
        //}

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of 0 and <paramref name="amax" /> (返回限制在 0 和 <paramref name="amax" /> 范围内的 <paramref name="value" />). <paramref name="amax" /> must be a `Pow(2,n)-1`.</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amax">The upper bound of the result (结果的上限). It must be a `Pow(2,n)-1`.</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;0)?value:0 ):amax</c>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ClampToBitMax(int value, int amax) {
            Debug.Assert(0 == (amax & (amax + 1)));
            return (value & ToInt32Mask(value >= 0) | ToInt32Mask(value > amax)) & amax;
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of 0 and <paramref name="amax" /> (返回限制在 0 和 <paramref name="amax" /> 范围内的 <paramref name="value" />). <paramref name="amax" /> must be a `Pow(2,n)-1`.</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amax">The upper bound of the result (结果的上限). It must be a `Pow(2,n)-1`.</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;0)?value:0 ):amax</c>.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ClampToBitMax(uint value, uint amax) {
            Debug.Assert(0 == (amax & (amax + 1)));
            return (value | (uint)ToInt32Mask(value > amax)) & amax;
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of 0 and <paramref name="amax" /> (返回限制在 0 和 <paramref name="amax" /> 范围内的 <paramref name="value" />). <paramref name="amax" /> must be a `Pow(2,n)-1`.</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amax">The upper bound of the result (结果的上限). It must be a `Pow(2,n)-1`.</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;0)?value:0 ):amax</c>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ClampToBitMax(long value, long amax) {
            Debug.Assert(0 == (amax & (amax + 1)));
            return (value & (long)ToInt32Mask(value >= 0) | (long)ToInt32Mask(value > amax)) & amax;
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of 0 and <paramref name="amax" /> (返回限制在 0 和 <paramref name="amax" /> 范围内的 <paramref name="value" />). <paramref name="amax" /> must be a `Pow(2,n)-1`.</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amax">The upper bound of the result (结果的上限). It must be a `Pow(2,n)-1`.</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;0)?value:0 ):amax</c>.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ClampToBitMax(ulong value, ulong amax) {
            Debug.Assert(0 == (amax & (amax + 1)));
            return (value | (ulong)(long)ToInt32Mask(value > amax)) & amax;
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of 0 and <c>byte.MaxValue</c> (返回限制在 0 和 <c>byte.MaxValue</c> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <returns>Returns clamped value (返回限制后的值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ClampToByte(int value) {
            return (byte)(value & ToInt32Mask(value >= 0) | ToInt32Mask(value > byte.MaxValue));
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of 0 and <c>byte.MaxValue</c> (返回限制在 0 和 <c>byte.MaxValue</c> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <returns>Returns clamped value (返回限制后的值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ClampToByte(uint value) {
            return (byte)(value | (uint)ToInt32Mask(value > byte.MaxValue));
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of 0 and <c>byte.MaxValue</c> (返回限制在 0 和 <c>byte.MaxValue</c> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <returns>Returns clamped value (返回限制后的值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ClampToByte(long value) {
            return (byte)(value & (long)ToInt32Mask(value >= 0) | (long)ToInt32Mask(value > byte.MaxValue));
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of 0 and <c>byte.MaxValue</c> (返回限制在 0 和 <c>byte.MaxValue</c> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <returns>Returns clamped value (返回限制后的值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ClampToByte(ulong value) {
            return (byte)(value | (ulong)(long)ToInt32Mask(value > byte.MaxValue));
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ConditionalSelect(bool condition, sbyte left, sbyte right) {
            return BitSelect((sbyte)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ConditionalSelect(bool condition, byte left, byte right) {
            return BitSelect((byte)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ConditionalSelect(bool condition, short left, short right) {
            return BitSelect((short)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ConditionalSelect(bool condition, ushort left, ushort right) {
            return BitSelect((ushort)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConditionalSelect(bool condition, int left, int right) {
            return BitSelect((int)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ConditionalSelect(bool condition, uint left, uint right) {
            return BitSelect((uint)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ConditionalSelect(bool condition, long left, long right) {
            return BitSelect((long)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ConditionalSelect(bool condition, ulong left, ulong right) {
            return BitSelect((ulong)(long)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint ConditionalSelect(bool condition, nint left, nint right) {
            return BitSelect((nint)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint ConditionalSelect(bool condition, nuint left, nuint right) {
            return BitSelect((nuint)(nint)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ConditionalSelect(bool condition, float left, float right) {
            return Int32BitsToSingle(ConditionalSelect(condition, SingleToInt32Bits(left), SingleToInt32Bits(right)));
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ConditionalSelect(bool condition, double left, double right) {
            return Int64BitsToDouble(ConditionalSelect(condition, DoubleToInt64Bits(left), DoubleToInt64Bits(right)));
        }

#if NET5_0_OR_GREATER

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ConditionalSelect(bool condition, Half left, Half right) {
            return Int16BitsToHalf(ConditionalSelect(condition, HalfToInt16Bits(left), HalfToInt16Bits(right)));
        }

#endif // NET5_0_OR_GREATER

        /// <summary>
        /// Get the byte made by the 2-bit value (获取由2位值构成的字节). Generally used to make shuffle control codes, like <see cref="_MM_SHUFFLE"/> (一般用于制作 shuffle 控制码, 类似 <see cref="_MM_SHUFFLE"/>).
        /// </summary>
        /// <param name="n3">The 3rd 2-bit value (第3个2位值).</param>
        /// <param name="n2">The 2nd 2-bit value (第2个2位值).</param>
        /// <param name="n1">The 1st 2-bit value (第1个2位值).</param>
        /// <param name="n0">The 0th 2-bit value (第0个2位值).</param>
        /// <returns>Return the byte of made (返回所构成的字节).</returns>
        /// <seealso cref="GetByteByBit2R"/>
        /// <seealso cref="_MM_SHUFFLE"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetByteByBit2(byte n3, byte n2, byte n1, byte n0) {
            return (byte)((n3 << 6) | (n2 << 4) | (n1 << 2) | n0);
        }

        /// <summary>
        /// Get the byte made by the 2-bit value - reversed (获取由2位值构成的字节 - 逆序). Generally used to make shuffle control codes, like <see cref="_MM_SHUFFLE"/> (一般用于制作 shuffle 控制码, 类似 <see cref="_MM_SHUFFLE"/>).
        /// </summary>
        /// <param name="n0">The 0th 2-bit value (第0个2位值).</param>
        /// <param name="n1">The 1st 2-bit value (第1个2位值).</param>
        /// <param name="n2">The 2nd 2-bit value (第2个2位值).</param>
        /// <param name="n3">The 3rd 2-bit value (第3个2位值).</param>
        /// <returns>Return the byte of made (返回所构成的字节).</returns>
        /// <seealso cref="GetByteByBit2"/>
        /// <seealso cref="_MM_SHUFFLE"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetByteByBit2R(byte n0, byte n1, byte n2, byte n3) {
            return GetByteByBit2(n3, n2, n1, n0);
        }

        /// <summary>
        /// Get the byte made by the 4-bit value (获取由4位值构成的字节). Generally used to make shuffle control codes, like <see cref="_MM_SHUFFLE"/> (一般用于制作 shuffle 控制码, 类似 <see cref="_MM_SHUFFLE"/>).
        /// </summary>
        /// <param name="n1">The 1st 4-bit value (第1个4位值).</param>
        /// <param name="n0">The 0th 4-bit value (第0个4位值).</param>
        /// <returns>Return the byte of made (返回所构成的字节).</returns>
        /// <seealso cref="GetByteByBit4R"/>
        /// <seealso cref="_MM_SHUFFLE"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetByteByBit4(byte n1, byte n0) {
            return (byte)((n1 << 4) | n0);
        }

        /// <summary>
        /// Get the byte made by the 4-bit value - reversed (获取由4位值构成的字节 - 逆序). Generally used to make shuffle control codes, like <see cref="_MM_SHUFFLE"/> (一般用于制作 shuffle 控制码, 类似 <see cref="_MM_SHUFFLE"/>).
        /// </summary>
        /// <param name="n0">The 0th 4-bit value (第0个4位值).</param>
        /// <param name="n1">The 1st 4-bit value (第1个4位值).</param>
        /// <returns>Return the byte of made (返回所构成的字节).</returns>
        /// <seealso cref="GetByteByBit4"/>
        /// <seealso cref="_MM_SHUFFLE"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetByteByBit4R(byte n0, byte n1) {
            return GetByteByBit4(n1, n0);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetMostSignificantBit(float src) {
            return GetMostSignificantBit(BitMath.SingleToUInt32Bits(src));
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetMostSignificantBit(double src) {
            return GetMostSignificantBit(BitMath.DoubleToUInt64Bits(src));
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetMostSignificantBit(sbyte src) {
            return GetMostSignificantBit((byte)src);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetMostSignificantBit(byte src) {
            return (uint)(src >> 7);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetMostSignificantBit(short src) {
            return GetMostSignificantBit((ushort)src);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetMostSignificantBit(ushort src) {
            return (uint)(src >> 15);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetMostSignificantBit(int src) {
            return GetMostSignificantBit((uint)src);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetMostSignificantBit(uint src) {
            return src >> 31;
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetMostSignificantBit(long src) {
            return GetMostSignificantBit((ulong)src);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GetMostSignificantBit(ulong src) {
            return (uint)(src >> 63);
        }

        /// <summary>
        /// Mapping old flags to new flags (将旧标志映射为新标志).
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <param name="matchFlag">Flags to be matched (欲匹配的标志)</param>
        /// <param name="newFlag">New flag (新的标志).</param>
        /// <returns>Returns the mapped value(返回映射后的值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MapFlags(int src, int matchFlag, int newFlag) {
            //int rt = (0 != (src & matchFlag)) ? newFlag : 0;
            int rt = ToInt32Mask(0 != (src & matchFlag)) & newFlag;
            return rt;
        }

        /// <summary>
        /// Mapping 2 groups of old flags to new flags (将2组旧标志映射为新标志).
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <param name="matchFlag0">Flags to be matched 0 (欲匹配的标志0)</param>
        /// <param name="newFlag0">New flag 0 (新的标志0).</param>
        /// <param name="matchFlag1">Flags to be matched 1 (欲匹配的标志1)</param>
        /// <param name="newFlag1">New flag 1 (新的标志1).</param>
        /// <returns>Returns the mapped value(返回映射后的值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MapFlags(int src, int matchFlag0, int newFlag0, int matchFlag1, int newFlag1) {
            int rt = MapFlags(src, matchFlag0, newFlag0);
            rt |= MapFlags(src, matchFlag1, newFlag1);
            return rt;
        }

        /// <summary>
        /// Convert bool to Int32 (将 bool 转为 Int32).
        /// </summary>
        /// <param name="b">Source bool value (源 bool 值)</param>
        /// <returns>A int value (一个整数值). false is 0, true is 1 . </returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(bool b) {
            //return Convert.ToInt32(b);
            //return ToInt32_Ptr(b);
            return Unsafe.As<bool, sbyte>(ref b);
        }

#if UNSAFE
        /// <summary>
        /// Convert bool to Int32 - Pointer (将 bool 转为 Int32 - 指针).
        /// </summary>
        /// <param name="b">Source bool value (源 bool 值)</param>
        /// <returns>A int value (一个整数值). false is 0, true is 1 . </returns>
        //[CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("This method is for testing purposes only. Please use ToInt32 instead.")]
        private static unsafe int ToInt32_Ptr(bool b) {
            return *(sbyte*)&b;
        }
#endif // UNSAFE

        /// <summary>
        /// Convert bool to Int32 mask (将 bool 转为 Int32 掩码).
        /// </summary>
        /// <param name="b">Source bool value (源 bool 值)</param>
        /// <returns>A int value (一个整数值). false is 0, true is -1 . </returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32Mask(bool b) {
            return -ToInt32(b);
        }

    }
}
