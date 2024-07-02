#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#define GENERICS_MATH
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.ExTypes.Impl {

    /// <summary>
    /// Extensions of <see cref="BigInteger"/>
    /// </summary>
    internal static class BigIntegerExtensions {
        public static BigInteger Add(this BigInteger left, uint value) {
            return BigInteger.Add(left, value);
        }

        public static uint CountSignificantBits(uint value) {
            return 32 - (uint)MathBitOperations.LeadingZeroCount(value);
        }

        public static uint CountSignificantBits(ulong value) {
            return 64 - (uint)MathBitOperations.LeadingZeroCount(value);
        }

        public static uint CountSignificantBits(ref BigInteger value) {
            if (value.IsZero) {
                return 0;
            }

            //// We don't track any unused blocks, so we only need to do a BSR on the
            //// last index and add that to the number of bits we skipped.
            //uint lastIndex = (uint)(value._length - 1);
            //return (lastIndex * BitsPerBlock) + CountSignificantBits(value._blocks[lastIndex]);
            if (value < 0) return 0;
            double logValue = BigInteger.Log(value, 2.0);
            uint n = (uint)(1 + Math.Floor(logValue));
            return n;
        }

        public static void DivRem(scoped ref BigInteger lhs, scoped ref BigInteger rhs, out BigInteger quo, out BigInteger rem) {
            quo = BigInteger.DivRem(lhs, rhs, out rem);
        }

        public static BigInteger MultiplyPow10(this BigInteger left, uint exponent) {
            BigInteger poweredValue = BigInteger.Pow(10, (int)exponent);
            return BigInteger.Multiply(left, poweredValue);
        }

        public static void Pow10(uint exponent, out BigInteger result) {
            result = BigInteger.Pow(10, (int)exponent);
        }

        public static BigInteger ShiftLeft(this BigInteger left, uint shift) {
#if GENERICS_MATH
            return left << (int)shift;
#else
            BigInteger poweredValue = BigInteger.Pow(2, (int)shift);
            return BigInteger.Multiply(left, poweredValue);
#endif // GENERICS_MATH
        }

    }

}
