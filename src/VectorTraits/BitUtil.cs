using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits {
    /// <summary>
    /// Bit manipulation util (位操控工具).
    /// </summary>
    /// <seealso cref="BitConverter"/>
    /// <seealso cref="BitOperations"/>
    /// <seealso cref="Math"/>
    public static partial class BitUtil {

        // == My ==

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
        /// <param name="x">The 1st 1-bit value (第1个2位值).</param>
        /// <param name="y">The 0th 1-bit value (第0个2位值).</param>
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

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Min(sbyte val1, sbyte val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Min(byte val1, byte val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Min(short val1, short val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Min(ushort val1, ushort val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(int val1, int val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Min(uint val1, uint val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Min(long val1, long val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Min(ulong val1, ulong val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Min(nint val1, nint val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint Min(nuint val1, nuint val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(float val1, float val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Min(double val1, double val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

#if NET5_0_OR_GREATER

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Min(Half val1, Half val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

#endif // NET5_0_OR_GREATER

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Max(sbyte val1, sbyte val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Max(byte val1, byte val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Max(short val1, short val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Max(ushort val1, ushort val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(int val1, int val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Max(uint val1, uint val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Max(long val1, long val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Max(ulong val1, ulong val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Max(nint val1, nint val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint Max(nuint val1, nuint val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(float val1, float val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Max(double val1, double val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

#if NET5_0_OR_GREATER

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Max(Half val1, Half val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

#endif // NET5_0_OR_GREATER

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(sbyte, sbyte, sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Clamp(sbyte value, sbyte amin, sbyte amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(byte, byte, byte)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Clamp(byte value, byte amin, byte amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(short, short, short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Clamp(short value, short amin, short amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(ushort, ushort, ushort)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Clamp(ushort value, ushort amin, ushort amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(int, int, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int value, int amin, int amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(uint, uint, uint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint value, uint amin, uint amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(long, long, long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(long value, long amin, long amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(ulong, ulong, ulong)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(ulong value, ulong amin, ulong amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(nint, nint, nint)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Clamp(nint value, nint amin, nint amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(nuint, nuint, nuint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint Clamp(nuint value, nuint amin, nuint amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(float, float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float value, float amin, float amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(double, double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(double value, double amin, double amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

#if NET5_0_OR_GREATER

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(Half, Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Clamp(Half value, Half amin, Half amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
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


        /// <summary>
        /// Returns the absolute value of a 8-bit signed integer (返回 8 位有符号整数的绝对值). No exception, <c>Abs(MinValue) := MinValue</c> .
        /// </summary>
        /// <param name="value">A number (一个数值).</param>
        /// <returns>Returns the absolute value (返回绝对值)</returns>
        /// <seealso cref="Math.Abs(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Abs(sbyte value) {
            sbyte mask = (sbyte)ToInt32Mask(0 > value);
            return (sbyte)((value ^ mask) - mask); // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
        }

        /// <summary>
        /// Returns the absolute value of a 16-bit signed integer (返回 16 位有符号整数的绝对值). No exception, <c>Abs(MinValue) := MinValue</c> .
        /// </summary>
        /// <param name="value">A number (一个数值).</param>
        /// <returns>Returns the absolute value (返回绝对值)</returns>
        /// <seealso cref="Math.Abs(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Abs(short value) {
            short mask = (short)ToInt32Mask(0 > value);
            return (short)((value ^ mask) - mask); // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
        }

        /// <summary>
        /// Returns the absolute value of a 32-bit signed integer (返回 32 位有符号整数的绝对值). No exception, <c>Abs(MinValue) := MinValue</c> .
        /// </summary>
        /// <param name="value">A number (一个数值).</param>
        /// <returns>Returns the absolute value (返回绝对值)</returns>
        /// <seealso cref="Math.Abs(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(int value) {
            int mask = ToInt32Mask(0 > value);
            return (value ^ mask) - mask; // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
        }

        /// <summary>
        /// Returns the absolute value of a 64-bit signed integer (返回 64 位有符号整数的绝对值). No exception, <c>Abs(MinValue) := MinValue</c> .
        /// </summary>
        /// <param name="value">A number (一个数值).</param>
        /// <returns>Returns the absolute value (返回绝对值)</returns>
        /// <seealso cref="Math.Abs(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Abs(long value) {
            long mask = ToInt32Mask(0 > value);
            return (value ^ mask) - mask; // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
        }

        /// <summary>
        /// Returns the absolute value of a native signed integer (返回本机有符号整数的绝对值). No exception, <c>Abs(MinValue) := MinValue</c> .
        /// </summary>
        /// <param name="value">A number (一个数值).</param>
        /// <returns>Returns the absolute value (返回绝对值)</returns>
        /// <seealso cref="Math.Abs(nint)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Abs(nint value) {
            nint mask = ToInt32Mask(0 > value);
            return ((value ^ mask) - mask); // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
        }

        /// <summary>
        /// Produces the full product of signed big numbers (产生有符号大数字的完整乘积) (`w = u * v`). Use little endian to store (使用小端存储).
        /// </summary>
        /// <param name="w">The full product of the specified numbers (指定数字的完整乘积).</param>
        /// <param name="u">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="v">The second number to multiply (要相乘的第二个数).</param>
        [CLSCompliant(false)]
        public static void BigNumMultiplySigned(Span<uint> w, ReadOnlySpan<uint> u, ReadOnlySpan<uint> v) {
            const int L = 32; // sizeof(uint) * 8;
            const int L2 = L * 2 - 1;
            int m = u.Length;
            int n = v.Length;
            ulong t, b;
            int i, j;
            BigNumMultiplyUnsigned(w, u, v);
            if ((int)u[m - 1] < 0) {
                b = 0;
                for (j = 0; j < n; j++) {
                    t = (ulong)w[j + m] - v[j] - b;
                    w[j + m] = (uint)t;
                    b = t >> L2;
                }
            }
            if ((int)v[n - 1] < 0) {
                b = 0;
                for (i = 0; i < m; i++) {
                    t = (ulong)w[i + n] - u[i] - b;
                    w[i + n] = (uint)t;
                    b = t >> L2;
                }
            }
        }

        /// <summary>
        /// Produces the full product of unsigned big numbers (产生无符号大数字的完整乘积) (`w = u * v`). Use little endian to store (使用小端存储).
        /// </summary>
        /// <param name="w">The full product of the specified numbers (指定数字的完整乘积).</param>
        /// <param name="u">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="v">The second number to multiply (要相乘的第二个数).</param>
        [CLSCompliant(false)]
        public static void BigNumMultiplyUnsigned(Span<uint> w, ReadOnlySpan<uint> u, ReadOnlySpan<uint> v) {
            const int L = 32; // sizeof(uint) * 8;
            int m = u.Length;
            int n = v.Length;
            ulong k, t;
            int i, j;
            for (i = 0; i < m; i++) {
                w[i] = 0;
            }
            for (j = 0; j < n; j++) {
                k = 0;
                for (i = 0; i < m; i++) {
                    t = (ulong)u[i] * v[j] + w[i + j] + k;
                    w[i + j] = (uint)t; // 等价于 t & 0xFFFFFFFFU
                    k = t >> L;
                }
                w[m + j] = (uint)k;
            }
        }

        /// <summary>
        /// Produces the full product of two signed 64-bit numbers (生成两个有符号 64 位数的完整乘积).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="b">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BigMul (long a, long b, out long low) {
#pragma warning disable CS0618 // Type or member is obsolete
#if NET5_0_OR_GREATER
            return Math.BigMul(a, b, out low);
#else
            return BigMul_BigNum(a, b, out low);
#endif // NET5_0_OR_GREATER
#pragma warning restore CS0618 // Type or member is obsolete
        }

        /// <summary>
        /// Produces the full product of two unsigned 64-bit numbers (生成两个无符号 64 位数的完整乘积).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="b">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BigMul (ulong a, ulong b, out ulong low) {
#pragma warning disable CS0618 // Type or member is obsolete
#if NET5_0_OR_GREATER
            return Math.BigMul(a, b, out low);
#else
            return BigMul_BigNum(a, b, out low);
#endif // NET5_0_OR_GREATER
#pragma warning restore CS0618 // Type or member is obsolete
        }

        /// <summary>
        /// Produces the full product of two signed 64-bit numbers - BigNum (生成两个有符号 64 位数的完整乘积 - 大数算法).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="b">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        public static long BigMul_BigNum (long a, long b, out long low) {
            const int L = 32; // sizeof(uint) * 8;
            Span<uint> w = stackalloc uint[4];
            Span<uint> u = stackalloc uint[2];
            Span<uint> v = stackalloc uint[2];
            u[0] = (uint)a;
            u[1] = (uint)(a >> L);
            v[0] = (uint)b;
            v[1] = (uint)(b >> L);
            BigNumMultiplySigned(w, u, v);
            low = ((long)w[1] << L) | w[0];
            return ((long)w[3] << L) | w[2];
        }

        /// <summary>
        /// Produces the full product of two unsigned 64-bit numbers - BigNum (生成两个无符号 64 位数的完整乘积 - 大数算法).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="b">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        public static ulong BigMul_BigNum (ulong a, ulong b, out ulong low) {
            const int L = 32; // sizeof(uint) * 8;
            Span<uint> w = stackalloc uint[4];
            Span<uint> u = stackalloc uint[2];
            Span<uint> v = stackalloc uint[2];
            u[0] = (uint)a;
            u[1] = (uint)(a >> L);
            v[0] = (uint)b;
            v[1] = (uint)(b >> L);
            BigNumMultiplyUnsigned(w, u, v);
            low = ((ulong)w[1] << L) | w[0];
            return ((ulong)w[3] << L) | w[2];
        }

        /// <summary>
        /// Produces the full product of two signed 64-bit numbers - Length is two (生成两个有符号 64 位数的完整乘积 - 长度为二).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="b">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        public static long BigMul_Two(long u, long v, out long low) {
            const int L = 32; // sizeof(uint) * 8;
            const long MASK = (1L << L) - 1;
            ulong w0;
            long u0, v0;
            long u1, v1, w1, w2, t, high;
            u0 = u & MASK; u1 = u >> L;
            v0 = v & MASK; v1 = v >> L;
            // u*v = (u1*v1)<<(2*L) + (u0*v1)<<L + (u1*v0)<<L + u0*v0
            // Part1 = u0*v0
            w0 = (ulong)u0 * (ulong)v0;
            // Part2 = (u1*v0)<<L + Part1
            t = u1 * v0 + (long)(w0 >> L);
            w1 = t & MASK;
            w2 = t >> L;
            // Part3 = (u0*v1)<<L + Part2
            w1 = u0 * v1 + w1;
            // Part4 = (u1*v1)<<(2*L) + Part3
            low = (w1 << L) + (long)(w0 & MASK);
            high = (u1 * v1) + w2 + (w1 >> L);
            return high;
        }

        /// <summary>
        /// Produces the full product of two unsigned 64-bit numbers - Length is two (生成两个无符号 64 位数的完整乘积 - 长度为二).
        /// </summary>
        /// <param name="u">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="v">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        public static ulong BigMul_Two(ulong u, ulong v, out ulong low) {
            const int L = 32; // sizeof(uint) * 8;
            const ulong MASK = (1L << L) - 1;
            ulong u0, v0, w0;
            ulong u1, v1, w1, w2, t, high;
            u0 = u & MASK; u1 = u >> L;
            v0 = v & MASK; v1 = v >> L;
            // u*v = (u1*v1)<<(2*L) + (u0*v1)<<L + (u1*v0)<<L + u0*v0
            // Part1 = u0*v0
            w0 = u0 * v0;
            // Part2 = (u1*v0)<<L + Part1
            t = u1 * v0 + (w0 >> L);
            w1 = t & MASK;
            w2 = t >> L;
            // Part3 = (u0*v1)<<L + Part2
            w1 = u0 * v1 + w1;
            // Part4 = (u1*v1)<<(2*L) + Part3
            low = (w1 << L) + (w0 & MASK);
            high = (u1 * v1) + w2 + (w1 >> L);
            return high;
        }

    }
}
