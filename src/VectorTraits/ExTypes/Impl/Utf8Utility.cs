using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.ExTypes.Impl {
    internal class Utf8Utility {

        /// <summary>
        /// The maximum number of bytes that can result from UTF-8 transcoding
        /// any Unicode scalar value.
        /// </summary>
        internal const int MaxBytesPerScalar = 4;

        /// <summary>
        /// Returns true iff the UInt32 represents four ASCII UTF-8 characters in machine endianness.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool AllBytesInUInt32AreAscii(uint value) => (value & ~0x7F7F_7F7Fu) == 0;

        /// <summary>
        /// Returns true iff the UInt64 represents eighty ASCII UTF-8 characters in machine endianness.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool AllBytesInUInt64AreAscii(ulong value) => (value & ~0x7F7F_7F7F_7F7F_7F7Ful) == 0;

        /// <summary>
        /// Given two UInt32s that represent four ASCII UTF-8 characters each, returns true iff
        /// the two inputs are equal using an ordinal case-insensitive comparison.
        /// </summary>
        /// <remarks>
        /// This is a branchless implementation.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool UInt32OrdinalIgnoreCaseAscii(uint valueA, uint valueB) {
            // Not currently intrinsified in mono interpreter, the UTF16 version is
            // ASSUMPTION: Caller has validated that input values are ASCII.
            Debug.Assert(AllBytesInUInt32AreAscii(valueA));
            Debug.Assert(AllBytesInUInt32AreAscii(valueB));

            // The logic here is very simple and is doing SIMD Within A Register (SWAR)
            //
            // First we want to create a mask finding the upper-case ASCII characters
            //
            // To do that, we can take the above presumption that all characters are ASCII
            // and therefore between 0x00 and 0x7F, inclusive. This means that `0x80 + char`
            // will never overflow and will at most produce 0xFF.
            //
            // Given that, we can check if a byte is greater than a value by adding it to
            // 0x80 and then subtracting the constant we're comparing against. So, for example,
            // if we want to find all characters greater than 'A' we do `value + 0x80 - 'A'`.
            //
            // Given that 'A' is 0x41, we end up with `0x41 + 0x80 == 0xC1` then we subtract 'A'
            // giving us `0xC1 - 0x41 == 0x80` and up to `0xBE` for 'DEL' (0x7F). This means that
            // any character greater than or equal to 'A' will have the most significant bit set.
            //
            // This can itself be simplified down to `val + (0x80 - 'A')` or `val + 0x3F`
            //
            // We also want to find the characters less than or equal to 'Z' as well. This follows
            // the same general principle but relies on finding the inverse instead. That is, we
            // want to find all characters greater than or equal to ('Z' + 1) and then inverse it.
            //
            // To confirm this, lets look at 'Z' which has the value of '0x5A'. So we first do
            // `0x5A + 0x80 == 0xDA`, then we subtract `[' (0x5B) giving us `0xDA - 0x5B == 0x80`.
            // This means that any character greater than 'Z' will now have the most significant bit set.
            //
            // It then follows that taking the ones complement will give us a mask representing the bytes
            // which are less than or equal to 'Z' since `!(val >= 0x5B) == (val <= 0x5A)`
            //
            // This then gives us that `('A' <= val) && (val <= 'Z')` is representable as
            // `(val + 0x3F) & ~(val + 0x25)`
            //
            // However, since a `val` cannot be simultaneously less than 'A' and greater than 'Z' we
            // are able to simplify this further to being just `(val + 0x3F) ^ (val + 0x25)`
            //
            // We then want to mask off the excess bits that aren't important to the mask and right
            // shift by two. This gives us `0x20` for a byte which is an upper-case ASCII character
            // and `0x00` otherwise.
            //
            // We now have a super efficient implementation that does a correct comparison in
            // 12 instructions and with zero branching.

            uint letterMaskA = (((valueA + 0x3F3F3F3F) ^ (valueA + 0x25252525)) & 0x80808080) >> 2;
            uint letterMaskB = (((valueB + 0x3F3F3F3F) ^ (valueB + 0x25252525)) & 0x80808080) >> 2;

            return (valueA | letterMaskA) == (valueB | letterMaskB);
        }

        /// <summary>
        /// Given two UInt64s that represent eight ASCII UTF-8 characters each, returns true iff
        /// the two inputs are equal using an ordinal case-insensitive comparison.
        /// </summary>
        /// <remarks>
        /// This is a branchless implementation.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool UInt64OrdinalIgnoreCaseAscii(ulong valueA, ulong valueB) {
            // Not currently intrinsified in mono interpreter, the UTF16 version is
            // ASSUMPTION: Caller has validated that input values are ASCII.
            Debug.Assert(AllBytesInUInt64AreAscii(valueA));
            Debug.Assert(AllBytesInUInt64AreAscii(valueB));

            // Duplicate of logic in UInt32OrdinalIgnoreCaseAscii, but using 64-bit consts.
            // See comments in that method for more info.

            ulong letterMaskA = (((valueA + 0x3F3F3F3F3F3F3F3F) ^ (valueA + 0x2525252525252525)) & 0x8080808080808080) >> 2;
            ulong letterMaskB = (((valueB + 0x3F3F3F3F3F3F3F3F) ^ (valueB + 0x2525252525252525)) & 0x8080808080808080) >> 2;

            return (valueA | letterMaskA) == (valueB | letterMaskB);
        }

    }
}
