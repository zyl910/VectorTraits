using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits {
    partial class Scalars {

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (原值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        public static uint GetMostSignificantBit(float src) {
            return GetMostSignificantBit(BitMath.SingleToUInt32Bits(src));
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (原值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        public static uint GetMostSignificantBit(double src) {
            return GetMostSignificantBit(BitMath.DoubleToUInt64Bits(src));
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (原值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        public static uint GetMostSignificantBit(sbyte src) {
            return GetMostSignificantBit((byte)src);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (原值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        public static uint GetMostSignificantBit(byte src) {
            return (uint)(src >> 7);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (原值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        public static uint GetMostSignificantBit(short src) {
            return GetMostSignificantBit((ushort)src);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (原值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        public static uint GetMostSignificantBit(ushort src) {
            return (uint)(src >> 15);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (原值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        public static uint GetMostSignificantBit(int src) {
            return GetMostSignificantBit((uint)src);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (原值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        public static uint GetMostSignificantBit(uint src) {
            return src >> 31;
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (原值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        public static uint GetMostSignificantBit(long src) {
            return GetMostSignificantBit((ulong)src);
        }

        /// <summary>
        /// Get the most significant bit (取得最高有效位).
        /// Mnemonic: <c>rt := src &gt;&gt;&gt; (sizeof(T)*8-1)</c>.
        /// </summary>
        /// <param name="src">Source value (原值).</param>
        /// <returns>The most significant bit (最高有效位).</returns>
        [CLSCompliant(false)]
        public static uint GetMostSignificantBit(ulong src) {
            return (uint)(src >> 63);
        }

    }
}
