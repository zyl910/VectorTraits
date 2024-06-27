#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.ExTypes.Impl {

    /// <summary>
    /// Bitwise arithmetic utilities for extended types (扩展类型的位运算工具函数).
    /// </summary>
    public static class ExBitUtil
    {

        /// <inheritdoc cref="MemoryExtensions.Contains{T}(ReadOnlySpan{T}, T)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ContainsAnyExcept(ReadOnlySpan<byte> span, byte value) {
#if NET8_0_OR_GREATER
            return span.ContainsAnyExcept(value);
#else
            foreach (byte p in span) {
                if (p != value) return true;
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
        public static ulong DecodeDecimalOn64(decimal src, out uint high)
        {
            ref byte p = ref Unsafe.As<decimal, byte>(ref src);
            ref uint pHigh = ref Unsafe.As<byte, uint>(ref Unsafe.Add(ref p, 4));
            ref ulong pLow64 = ref Unsafe.As<byte, ulong>(ref Unsafe.Add(ref p, 8));
            high = pHigh;
            return pLow64;
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

    }

}
