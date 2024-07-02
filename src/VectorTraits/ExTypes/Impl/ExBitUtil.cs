#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.ExTypes.Impl {

    /// <summary>
    /// Bitwise arithmetic utilities for extended types (扩展类型的位运算工具函数).
    /// </summary>
    public static class ExBitUtil {

        /// <inheritdoc cref="MemoryExtensions.ContainsAnyExcept{T}(ReadOnlySpan{T}, T)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ContainsAnyExcept<T>(ReadOnlySpan<T> span, T value) where T : IEquatable<T> {
#if NET8_0_OR_GREATER
            return MemoryExtensions.ContainsAnyExcept(span, value);
#else
            foreach (var p in span) {
                if (!value.Equals(p)) return true;
            }
            return false;
#endif // NET8_0_OR_GREATER
        }

        /// <summary>
        /// Decode <see cref="decimal"/> type by 64 bits (按64位来解码 <see cref="decimal"/> 类型).
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <param name="high">Returns the high 32 bits (返回高32位).</param>
        /// <returns>Returns the low 64 bits (返回低64位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong DecodeDecimalOn64(decimal src, out uint high) {
            ref byte p = ref Unsafe.As<decimal, byte>(ref src);
            ref uint pHigh = ref Unsafe.As<byte, uint>(ref Unsafe.Add(ref p, 4));
            ref ulong pLow64 = ref Unsafe.As<byte, ulong>(ref Unsafe.Add(ref p, 8));
            high = pHigh;
            return pLow64;
        }

        /// <summary>
        /// Decode <see cref="decimal"/> type by 32 bits (按32位来解码 <see cref="decimal"/> 类型).
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <param name="high">Returns the high 32 bits (返回高32位).</param>
        /// <param name="mid">Returns the middle 32 bits (返回中间32位).</param>
        /// <returns>Returns the low 32 bits (返回低32位).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint DecodeDecimalOn32(decimal src, out uint high, out uint mid) {
            ulong lo64 = DecodeDecimalOn64(src, out high);
            mid = (uint)(lo64 >> 32);
            uint low = (uint)lo64;
            return low;
        }

#if BCL_TYPE_HALF
        /// <summary>Computes the unary negation of a value (计算值的一元求反).</summary>
        /// <param name="value">The value for which to compute its unary negation.</param>
        /// <returns>The unary negation of <paramref name="value" />.</returns>
        public static Half UnaryNegation(Half value) {
#if NET7_0_OR_GREATER
            return -value;
#else
            ushort temp = MathBitConverter.HalfToUInt16Bits(value);
            temp ^= (ushort)0x8000U;
            return MathBitConverter.UInt16BitsToHalf(temp);
#endif // NET7_0_OR_GREATER
        }
#endif

        /// <inheritdoc cref="IUnaryNegationOperators{TSelf, TResult}.op_UnaryNegation(TSelf)" />
        public static TSelf UnaryNegation<TSelf>(TSelf value)
#if GENERICS_MATH
            where TSelf : IBinaryInteger<TSelf>
#endif // GENERICS_MATH
            {
#if GENERICS_MATH
            return -value;
#else
#pragma warning disable CS8605 // Unboxing a possibly null value.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            if (typeof(TSelf) == typeof(sbyte)) {
                return (TSelf)(object)(sbyte)(-(sbyte)(object)value);
            } else if (typeof(TSelf) == typeof(short)) {
                return (TSelf)(object)(short)(-(short)(object)value);
            } else if (typeof(TSelf) == typeof(int)) {
                return (TSelf)(object)(int)(-(int)(object)value);
            } else if (typeof(TSelf) == typeof(long)) {
                return (TSelf)(object)(long)(-(long)(object)value);
            } else if (typeof(TSelf) == typeof(nint)) {
                return (TSelf)(object)(nint)(-(nint)(object)value);
            } else if (typeof(TSelf) == typeof(ExInt128)) {
                return (TSelf)(object)(ExInt128)(-(ExInt128)(object)value);
#if BCL_TYPE_INT128
            } else if (typeof(TSelf) == typeof(Int128)) {
                return (TSelf)(object)(Int128)(-(Int128)(object)value);
#endif // BCL_TYPE_INT128
            } else if (typeof(TSelf) == typeof(float)) {
                return (TSelf)(object)(float)(-(float)(object)value);
            } else if (typeof(TSelf) == typeof(double)) {
                return (TSelf)(object)(double)(-(double)(object)value);
#if BCL_TYPE_HALF
            } else if (typeof(TSelf) == typeof(Half)) {
                return (TSelf)(object)UnaryNegation((Half)(object)value);
#endif // BCL_TYPE_HALF
            }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8605 // Unboxing a possibly null value.
            throw new NotSupportedException();
#endif
        }

    }

}
