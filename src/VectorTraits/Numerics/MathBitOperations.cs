#if NETCOREAPP3_0_OR_GREATER
#define BCL_TYPE_THIS
#endif // NETCOREAPP3_0_OR_GREATER

using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif // NETCOREAPP3_0_OR_GREATER
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics.X86;
#endif // NETCOREAPP3_0_OR_GREATER
using System.Text;

namespace Zyl.VectorTraits.Numerics {
    /// <summary>
    /// Math functions of <see cref="BitOperations"/> (BitOperations 的数学函数).
    /// </summary>
    /// <seealso cref="BitOperations"/>
    public static class MathBitOperations {

        // C# no-alloc optimization that directly wraps the data section of the dll (similar to string constants)
        // https://github.com/dotnet/roslyn/pull/24621

        private static ReadOnlySpan<byte> TrailingZeroCountDeBruijn => // 32
        [
            00, 01, 28, 02, 29, 14, 24, 03,
            30, 22, 20, 15, 25, 17, 04, 08,
            31, 27, 13, 23, 21, 19, 16, 07,
            26, 12, 18, 06, 11, 05, 10, 09
        ];

        private static ReadOnlySpan<byte> Log2DeBruijn => // 32
        [
            00, 09, 01, 10, 13, 21, 02, 29,
            11, 14, 16, 18, 22, 25, 03, 30,
            08, 12, 20, 28, 15, 17, 24, 07,
            19, 27, 23, 06, 26, 05, 04, 31
        ];

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
        /// Evaluate whether a given integral value is a power of 2.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPow2(int value) => (value & (value - 1)) == 0 && value > 0;

        /// <summary>
        /// Evaluate whether a given integral value is a power of 2.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static bool IsPow2(uint value) => (value & (value - 1)) == 0 && value != 0;

        /// <summary>
        /// Evaluate whether a given integral value is a power of 2.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPow2(long value) => (value & (value - 1)) == 0 && value > 0;

        /// <summary>
        /// Evaluate whether a given integral value is a power of 2.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static bool IsPow2(ulong value) => (value & (value - 1)) == 0 && value != 0;

        /// <summary>
        /// Evaluate whether a given integral value is a power of 2.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPow2(nint value) => (value & (value - 1)) == 0 && value > 0;

        /// <summary>
        /// Evaluate whether a given integral value is a power of 2.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static bool IsPow2(nuint value) => (value & (value - 1)) == 0 && value != 0;

        /// <summary>Round the given integral value up to a power of 2.</summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The smallest power of 2 which is greater than or equal to <paramref name="value"/>.
        /// If <paramref name="value"/> is 0 or the result overflows, returns 0.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static uint RoundUpToPowerOf2(uint value) {
#if BCL_TYPE_THIS && NET6_0_OR_GREATER
            return BitOperations.RoundUpToPowerOf2(value);
#else
#if NET5_0_OR_GREATER
            if (X86Base.IsSupported || ArmBase.IsSupported
#if NETX_0_OR_GREATER
                || WasmBase.IsSupported
#endif // NETX_0_OR_GREATER
                ) {
                if (Is64Bit) {
                    return (uint)(0x1_0000_0000ul >> LeadingZeroCount(value - 1));
                } else {
                    int shift = 32 - LeadingZeroCount(value - 1);
                    return (1u ^ (uint)(shift >> 5)) << shift;
                }
            }
#endif // NET5_0_OR_GREATER

            // Based on https://graphics.stanford.edu/~seander/bithacks.html#RoundUpPowerOf2
            --value;
            value |= value >> 1;
            value |= value >> 2;
            value |= value >> 4;
            value |= value >> 8;
            value |= value >> 16;
            return value + 1;
#endif // BCL_TYPE_THIS && NET6_0_OR_GREATER
        }

        /// <summary>
        /// Round the given integral value up to a power of 2.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The smallest power of 2 which is greater than or equal to <paramref name="value"/>.
        /// If <paramref name="value"/> is 0 or the result overflows, returns 0.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static ulong RoundUpToPowerOf2(ulong value) {
#if BCL_TYPE_THIS && NET6_0_OR_GREATER
            return BitOperations.RoundUpToPowerOf2(value);
#else
#if NET5_0_OR_GREATER
            if (X86Base.IsSupported || ArmBase.IsSupported
#if NETX_0_OR_GREATER
                || WasmBase.IsSupported
#endif // NETX_0_OR_GREATER
                ) {
                int shift = 64 - LeadingZeroCount(value - 1);
                return (1ul ^ (ulong)(shift >> 6)) << shift;
            }
#endif // NET5_0_OR_GREATER

            // Based on https://graphics.stanford.edu/~seander/bithacks.html#RoundUpPowerOf2
            --value;
            value |= value >> 1;
            value |= value >> 2;
            value |= value >> 4;
            value |= value >> 8;
            value |= value >> 16;
            value |= value >> 32;
            return value + 1;
#endif // BCL_TYPE_THIS && NET6_0_OR_GREATER
        }

        /// <summary>
        /// Round the given integral value up to a power of 2.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The smallest power of 2 which is greater than or equal to <paramref name="value"/>.
        /// If <paramref name="value"/> is 0 or the result overflows, returns 0.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static nuint RoundUpToPowerOf2(nuint value) {
#if BCL_TYPE_THIS && NET7_0_OR_GREATER
            return BitOperations.RoundUpToPowerOf2(value);
#else
            if (Is64Bit) {
                return (nuint)RoundUpToPowerOf2((ulong)value);
            } else {
                return (nuint)RoundUpToPowerOf2((uint)value);
            }
#endif // BCL_TYPE_THIS && NET7_0_OR_GREATER
        }

        /// <summary>
        /// Count the number of leading zero bits in a mask.
        /// Similar in behavior to the x86 instruction LZCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static int LeadingZeroCount(uint value) {
#if BCL_TYPE_THIS
            return BitOperations.LeadingZeroCount(value);
#else
#if NETCOREAPP3_0_OR_GREATER
            if (Lzcnt.IsSupported) {
                // LZCNT contract is 0->32
                return (int)Lzcnt.LeadingZeroCount(value);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (ArmBase.IsSupported) {
                return ArmBase.LeadingZeroCount(value);
            }
#endif // NET5_0_OR_GREATER


#if NETX_0_OR_GREATER
            if (WasmBase.IsSupported) {
                return WasmBase.LeadingZeroCount(value);
            }
#endif // NETX_0_OR_GREATER

            // Unguarded fallback contract is 0->31, BSR contract is 0->undefined
            if (value == 0) {
                return 32;
            }

#if NETX_0_OR_GREATER
            if (X86Base.IsSupported) {
                // LZCNT returns index starting from MSB, whereas BSR gives the index from LSB.
                // 31 ^ BSR here is equivalent to 31 - BSR since the BSR result is always between 0 and 31.
                // This saves an instruction, as subtraction from constant requires either MOV/SUB or NEG/ADD.
                return 31 ^ (int)X86Base.BitScanReverse(value);
            }
#endif // NETX_0_OR_GREATER

            return 31 ^ Log2SoftwareFallback(value);
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Count the number of leading zero bits in a mask.
        /// Similar in behavior to the x86 instruction LZCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static int LeadingZeroCount(ulong value) {
#if BCL_TYPE_THIS
            return BitOperations.LeadingZeroCount(value);
#else
#if NETCOREAPP3_0_OR_GREATER
            if (Lzcnt.X64.IsSupported) {
                // LZCNT contract is 0->64
                return (int)Lzcnt.X64.LeadingZeroCount(value);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (ArmBase.Arm64.IsSupported) {
                return ArmBase.Arm64.LeadingZeroCount(value);
            }
#endif // NET5_0_OR_GREATER


#if NETX_0_OR_GREATER
            if (WasmBase.IsSupported) {
                return WasmBase.LeadingZeroCount(value);
            }
#endif // NETX_0_OR_GREATER

#if NETX_0_OR_GREATER
            if (X86Base.X64.IsSupported) {
                // BSR contract is 0->undefined
                return value == 0 ? 64 : 63 ^ (int)X86Base.X64.BitScanReverse(value);
            }
#endif // NETX_0_OR_GREATER

            uint hi = (uint)(value >> 32);

            if (hi == 0) {
                return 32 + LeadingZeroCount((uint)value);
            }

            return LeadingZeroCount(hi);
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Count the number of leading zero bits in a mask.
        /// Similar in behavior to the x86 instruction LZCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static int LeadingZeroCount(nuint value) {
#if BCL_TYPE_THIS && NET7_0_OR_GREATER
            return BitOperations.LeadingZeroCount(value);
#else
            if (Is64Bit) {
                return LeadingZeroCount((ulong)value);
            } else {
                return LeadingZeroCount((uint)value);
            }
#endif // BCL_TYPE_THIS && NET7_0_OR_GREATER
        }

        /// <summary>
        /// Returns the integer (floor) log of the specified value, base 2.
        /// Note that by convention, input value 0 returns 0 since log(0) is undefined.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static int Log2(uint value) {
#if BCL_TYPE_THIS
            return BitOperations.Log2(value);
#else
            // The 0->0 contract is fulfilled by setting the LSB to 1.
            // Log(1) is 0, and setting the LSB for values > 1 does not change the log2 result.
            value |= 1;

            // value    lzcnt   actual  expected
            // ..0001   31      31-31    0
            // ..0010   30      31-30    1
            // 0010..    2      31-2    29
            // 0100..    1      31-1    30
            // 1000..    0      31-0    31
#if NETCOREAPP3_0_OR_GREATER
            if (Lzcnt.IsSupported) {
                return 31 ^ (int)Lzcnt.LeadingZeroCount(value);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (ArmBase.IsSupported) {
                return 31 ^ ArmBase.LeadingZeroCount(value);
            }
#endif // NET5_0_OR_GREATER

#if NETX_0_OR_GREATER
            if (WasmBase.IsSupported) {
                return 31 ^ WasmBase.LeadingZeroCount(value);
            }
#endif // NETX_0_OR_GREATER

            // BSR returns the log2 result directly. However BSR is slower than LZCNT
            // on AMD processors, so we leave it as a fallback only.
#if NETX_0_OR_GREATER
            if (X86Base.IsSupported) {
                return (int)X86Base.BitScanReverse(value);
            }
#endif // NETX_0_OR_GREATER

            // Fallback contract is 0->0
            return Log2SoftwareFallback(value);
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Returns the integer (floor) log of the specified value, base 2.
        /// Note that by convention, input value 0 returns 0 since log(0) is undefined.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static int Log2(ulong value) {
#if BCL_TYPE_THIS
            return BitOperations.Log2(value);
#else
            value |= 1;

#if NETCOREAPP3_0_OR_GREATER
            if (Lzcnt.X64.IsSupported) {
                return 63 ^ (int)Lzcnt.X64.LeadingZeroCount(value);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (ArmBase.Arm64.IsSupported) {
                return 63 ^ ArmBase.Arm64.LeadingZeroCount(value);
            }
#endif // NET5_0_OR_GREATER

#if NETX_0_OR_GREATER
            if (X86Base.X64.IsSupported) {
                return (int)X86Base.X64.BitScanReverse(value);
            }

            if (WasmBase.IsSupported) {
                return 63 ^ WasmBase.LeadingZeroCount(value);
            }
#endif // NETX_0_OR_GREATER

            uint hi = (uint)(value >> 32);

            if (hi == 0) {
                return Log2((uint)value);
            }

            return 32 + Log2(hi);
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Returns the integer (floor) log of the specified value, base 2.
        /// Note that by convention, input value 0 returns 0 since log(0) is undefined.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static int Log2(nuint value) {
#if BCL_TYPE_THIS && NET7_0_OR_GREATER
            return BitOperations.Log2(value);
#else
            if (Is64Bit) {
                return Log2((ulong)value);
            } else {
                return Log2((uint)value);
            }
#endif // BCL_TYPE_THIS && NET7_0_OR_GREATER
        }

        /// <summary>
        /// Returns the integer (floor) log of the specified value, base 2.
        /// Note that by convention, input value 0 returns 0 since Log(0) is undefined.
        /// Does not directly use any hardware intrinsics, nor does it incur branching.
        /// </summary>
        /// <param name="value">The value.</param>
        private static int Log2SoftwareFallback(uint value) {
            // No AggressiveInlining due to large method size
            // Has conventional contract 0->0 (Log(0) is undefined)

            // Fill trailing zeros with ones, eg 00010010 becomes 00011111
            value |= value >> 01;
            value |= value >> 02;
            value |= value >> 04;
            value |= value >> 08;
            value |= value >> 16;

            // uint.MaxValue >> 27 is always in range [0 - 31] so we use Unsafe.AddByteOffset to avoid bounds check
            return Unsafe.AddByteOffset(
                // Using deBruijn sequence, k=2, n=5 (2^5=32) : 0b_0000_0111_1100_0100_1010_1100_1101_1101u
                ref MemoryMarshal.GetReference(Log2DeBruijn),
                // uint|long -> IntPtr cast on 32-bit platforms does expensive overflow checks not needed here
                (IntPtr)(int)((value * 0x07C4ACDDu) >> 27));
        }

        /// <summary>Returns the integer (ceiling) log of the specified value, base 2.</summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int Log2Ceiling(uint value) {
            int result = Log2(value);
            if (PopCount(value) != 1) {
                result++;
            }
            return result;
        }

        /// <summary>Returns the integer (ceiling) log of the specified value, base 2.</summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int Log2Ceiling(ulong value) {
            int result = Log2(value);
            if (PopCount(value) != 1) {
                result++;
            }
            return result;
        }

        /// <summary>
        /// Returns the population count (number of bits set) of a mask.
        /// Similar in behavior to the x86 instruction POPCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static int PopCount(uint value) {
#if BCL_TYPE_THIS
            return BitOperations.PopCount(value);
#else
#if NETCOREAPP3_0_OR_GREATER
            if (Popcnt.IsSupported) {
                return (int)Popcnt.PopCount(value);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (AdvSimd.Arm64.IsSupported) {
                // PopCount works on vector so convert input value to vector first.

                Vector64<uint> input = Vector64.CreateScalar(value);
                Vector64<byte> aggregated = AdvSimd.Arm64.AddAcross(AdvSimd.PopCount(input.AsByte()));
                return aggregated.ToScalar();
            }
#endif // NET5_0_OR_GREATER

            return SoftwareFallback(value);

            static int SoftwareFallback(uint value) {
                const uint c1 = 0x_55555555u;
                const uint c2 = 0x_33333333u;
                const uint c3 = 0x_0F0F0F0Fu;
                const uint c4 = 0x_01010101u;

                value -= (value >> 1) & c1;
                value = (value & c2) + ((value >> 2) & c2);
                value = (((value + (value >> 4)) & c3) * c4) >> 24;

                return (int)value;
            }
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Returns the population count (number of bits set) of a mask.
        /// Similar in behavior to the x86 instruction POPCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static int PopCount(ulong value) {
#if BCL_TYPE_THIS
            return BitOperations.PopCount(value);
#else
#if NETCOREAPP3_0_OR_GREATER
            if (Popcnt.X64.IsSupported) {
                return (int)Popcnt.X64.PopCount(value);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (AdvSimd.Arm64.IsSupported) {
                // PopCount works on vector so convert input value to vector first.
                Vector64<ulong> input = Vector64.Create(value);
                Vector64<byte> aggregated = AdvSimd.Arm64.AddAcross(AdvSimd.PopCount(input.AsByte()));
                return aggregated.ToScalar();
            }
#endif // NET5_0_OR_GREATER

            if (Is64Bit) {
                return SoftwareFallback(value);

                static int SoftwareFallback(ulong value) {
                    const ulong c1 = 0x_55555555_55555555ul;
                    const ulong c2 = 0x_33333333_33333333ul;
                    const ulong c3 = 0x_0F0F0F0F_0F0F0F0Ful;
                    const ulong c4 = 0x_01010101_01010101ul;

                    value -= (value >> 1) & c1;
                    value = (value & c2) + ((value >> 2) & c2);
                    value = (((value + (value >> 4)) & c3) * c4) >> 56;

                    return (int)value;
                }
            } else {
                return PopCount((uint)value) // lo
                    + PopCount((uint)(value >> 32)); // hi
            }
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Returns the population count (number of bits set) of a mask.
        /// Similar in behavior to the x86 instruction POPCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static int PopCount(nuint value) {
#if BCL_TYPE_THIS && NET7_0_OR_GREATER
            return BitOperations.PopCount(value);
#else
            if (Is64Bit) {
                return PopCount((ulong)value);
            } else {
                return PopCount((uint)value);
            }
#endif // BCL_TYPE_THIS && NET7_0_OR_GREATER
        }

        /// <summary>
        /// Count the number of trailing zero bits in an integer value.
        /// Similar in behavior to the x86 instruction TZCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int TrailingZeroCount(int value)
            => TrailingZeroCount((uint)value);

        /// <summary>
        /// Count the number of trailing zero bits in an integer value.
        /// Similar in behavior to the x86 instruction TZCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int TrailingZeroCount(uint value) {
#if BCL_TYPE_THIS
            return BitOperations.TrailingZeroCount(value);
#else
#if NETCOREAPP3_0_OR_GREATER
            if (Bmi1.IsSupported) {
                // TZCNT contract is 0->32
                return (int)Bmi1.TrailingZeroCount(value);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (ArmBase.IsSupported) {
                return ArmBase.LeadingZeroCount(ArmBase.ReverseElementBits(value));
            }
#endif // NET5_0_OR_GREATER

#if NETX_0_OR_GREATER
            if (WasmBase.IsSupported) {
                return WasmBase.TrailingZeroCount(value);
            }
#endif // NETX_0_OR_GREATER

            // Unguarded fallback contract is 0->0, BSF contract is 0->undefined
            if (value == 0) {
                return 32;
            }

#if NETX_0_OR_GREATER
            if (X86Base.IsSupported) {
                return (int)X86Base.BitScanForward(value);
            }
#endif // NETX_0_OR_GREATER

            // uint.MaxValue >> 27 is always in range [0 - 31] so we use Unsafe.AddByteOffset to avoid bounds check
            return Unsafe.AddByteOffset(
                // Using deBruijn sequence, k=2, n=5 (2^5=32) : 0b_0000_0111_0111_1100_1011_0101_0011_0001u
                ref MemoryMarshal.GetReference(TrailingZeroCountDeBruijn),
                // uint|long -> IntPtr cast on 32-bit platforms does expensive overflow checks not needed here
                (IntPtr)(int)(((value & (uint)-(int)value) * 0x077CB531u) >> 27)); // Multi-cast mitigates redundant conv.u8
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Count the number of trailing zero bits in a mask.
        /// Similar in behavior to the x86 instruction TZCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int TrailingZeroCount(long value)
            => TrailingZeroCount((ulong)value);

        /// <summary>
        /// Count the number of trailing zero bits in a mask.
        /// Similar in behavior to the x86 instruction TZCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static int TrailingZeroCount(ulong value) {
#if BCL_TYPE_THIS
            return BitOperations.TrailingZeroCount(value);
#else
#if NETCOREAPP3_0_OR_GREATER
            if (Bmi1.X64.IsSupported) {
                // TZCNT contract is 0->64
                return (int)Bmi1.X64.TrailingZeroCount(value);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (ArmBase.Arm64.IsSupported) {
                return ArmBase.Arm64.LeadingZeroCount(ArmBase.Arm64.ReverseElementBits(value));
            }
#endif // NET5_0_OR_GREATER

#if NETX_0_OR_GREATER
            if (WasmBase.IsSupported) {
                return WasmBase.TrailingZeroCount(value);
            }

            if (X86Base.X64.IsSupported) {
                // BSF contract is 0->undefined
                return value == 0 ? 64 : (int)X86Base.X64.BitScanForward(value);
            }
#endif // NETX_0_OR_GREATER

            uint lo = (uint)value;

            if (lo == 0) {
                return 32 + TrailingZeroCount((uint)(value >> 32));
            }

            return TrailingZeroCount(lo);
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Count the number of trailing zero bits in a mask.
        /// Similar in behavior to the x86 instruction TZCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int TrailingZeroCount(nint value) {
#if BCL_TYPE_THIS && NET7_0_OR_GREATER
            return BitOperations.TrailingZeroCount(value);
#else
            if (Is64Bit) {
                return TrailingZeroCount((ulong)(nuint)value);
            } else {
                return TrailingZeroCount((uint)(nuint)value);
            }
#endif // BCL_TYPE_THIS && NET7_0_OR_GREATER
        }

        /// <summary>
        /// Count the number of trailing zero bits in a mask.
        /// Similar in behavior to the x86 instruction TZCNT.
        /// </summary>
        /// <param name="value">The value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static int TrailingZeroCount(nuint value) {
#if BCL_TYPE_THIS && NET7_0_OR_GREATER
            return BitOperations.TrailingZeroCount(value);
#else
            if (Is64Bit) {
                return TrailingZeroCount((ulong)value);
            } else {
                return TrailingZeroCount((uint)value);
            }
#endif // BCL_TYPE_THIS && NET7_0_OR_GREATER
        }

        /// <summary>
        /// Rotates the specified value left by the specified number of bits.
        /// Similar in behavior to the x86 instruction ROL.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="offset">The number of bits to rotate by.
        /// Any value outside the range [0..31] is treated as congruent mod 32.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static uint RotateLeft(uint value, int offset) {
#if BCL_TYPE_THIS
            return BitOperations.RotateLeft(value, offset);
#else
            return (value << offset) | (value >> (32 - offset));
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Rotates the specified value left by the specified number of bits.
        /// Similar in behavior to the x86 instruction ROL.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="offset">The number of bits to rotate by.
        /// Any value outside the range [0..63] is treated as congruent mod 64.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static ulong RotateLeft(ulong value, int offset) {
#if BCL_TYPE_THIS
            return BitOperations.RotateLeft(value, offset);
#else
            return (value << offset) | (value >> (64 - offset));
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Rotates the specified value left by the specified number of bits.
        /// Similar in behavior to the x86 instruction ROL.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="offset">The number of bits to rotate by.
        /// Any value outside the range [0..31] is treated as congruent mod 32 on a 32-bit process,
        /// and any value outside the range [0..63] is treated as congruent mod 64 on a 64-bit process.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static nuint RotateLeft(nuint value, int offset) {
#if BCL_TYPE_THIS && NET7_0_OR_GREATER
            return BitOperations.RotateLeft(value, offset);
#else
            if (Is64Bit) {
                return (nuint)RotateLeft((ulong)value, offset);
            } else {
                return (nuint)RotateLeft((uint)value, offset);
            }
#endif // BCL_TYPE_THIS && NET7_0_OR_GREATER
        }

        /// <summary>
        /// Rotates the specified value right by the specified number of bits.
        /// Similar in behavior to the x86 instruction ROR.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="offset">The number of bits to rotate by.
        /// Any value outside the range [0..31] is treated as congruent mod 32.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static uint RotateRight(uint value, int offset) {
#if BCL_TYPE_THIS
            return BitOperations.RotateRight(value, offset);
#else
            return (value >> offset) | (value << (32 - offset));
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Rotates the specified value right by the specified number of bits.
        /// Similar in behavior to the x86 instruction ROR.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="offset">The number of bits to rotate by.
        /// Any value outside the range [0..63] is treated as congruent mod 64.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static ulong RotateRight(ulong value, int offset) {
#if BCL_TYPE_THIS
            return BitOperations.RotateRight(value, offset);
#else
            return (value >> offset) | (value << (64 - offset));
#endif // BCL_TYPE_THIS
        }

        /// <summary>
        /// Rotates the specified value right by the specified number of bits.
        /// Similar in behavior to the x86 instruction ROR.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="offset">The number of bits to rotate by.
        /// Any value outside the range [0..31] is treated as congruent mod 32 on a 32-bit process,
        /// and any value outside the range [0..63] is treated as congruent mod 64 on a 64-bit process.</param>
        /// <returns>The rotated value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static nuint RotateRight(nuint value, int offset) {
#if BCL_TYPE_THIS && NET7_0_OR_GREATER
            return BitOperations.RotateRight(value, offset);
#else
            if (Is64Bit) {
                return (nuint)RotateRight((ulong)value, offset);
            } else {
                return (nuint)RotateRight((uint)value, offset);
            }
#endif // BCL_TYPE_THIS && NET7_0_OR_GREATER
        }

        /// <summary>
        /// Accumulates the CRC (Cyclic redundancy check) checksum.
        /// </summary>
        /// <param name="crc">The base value to calculate checksum on</param>
        /// <param name="data">The data for which to compute the checksum</param>
        /// <returns>The CRC-checksum</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Crc32C(uint crc, byte data) {
#if BCL_TYPE_THIS && NET8_0_OR_GREATER
            return BitOperations.Crc32C(crc, data);
#else
#if NETCOREAPP3_0_OR_GREATER
            if (Sse42.IsSupported) {
                return Sse42.Crc32(crc, data);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (Crc32.IsSupported) {
                return Crc32.ComputeCrc32C(crc, data);
            }
#endif // NET5_0_OR_GREATER

            return Crc32Fallback.Crc32C(crc, data);
#endif // BCL_TYPE_THIS && NET8_0_OR_GREATER
        }

        /// <summary>
        /// Accumulates the CRC (Cyclic redundancy check) checksum.
        /// </summary>
        /// <param name="crc">The base value to calculate checksum on</param>
        /// <param name="data">The data for which to compute the checksum</param>
        /// <returns>The CRC-checksum</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Crc32C(uint crc, ushort data) {
#if BCL_TYPE_THIS && NET8_0_OR_GREATER
            return BitOperations.Crc32C(crc, data);
#else
#if NETCOREAPP3_0_OR_GREATER
            if (Sse42.IsSupported) {
                return Sse42.Crc32(crc, data);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (Crc32.IsSupported) {
                return Crc32.ComputeCrc32C(crc, data);
            }
#endif // NET5_0_OR_GREATER

            return Crc32Fallback.Crc32C(crc, data);
#endif // BCL_TYPE_THIS && NET8_0_OR_GREATER
        }

        /// <summary>
        /// Accumulates the CRC (Cyclic redundancy check) checksum.
        /// </summary>
        /// <param name="crc">The base value to calculate checksum on</param>
        /// <param name="data">The data for which to compute the checksum</param>
        /// <returns>The CRC-checksum</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Crc32C(uint crc, uint data) {
#if BCL_TYPE_THIS && NET8_0_OR_GREATER
            return BitOperations.Crc32C(crc, data);
#else
#if NETCOREAPP3_0_OR_GREATER
            if (Sse42.IsSupported) {
                return Sse42.Crc32(crc, data);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (Crc32.IsSupported) {
                return Crc32.ComputeCrc32C(crc, data);
            }
#endif // NET5_0_OR_GREATER

            return Crc32Fallback.Crc32C(crc, data);
#endif // BCL_TYPE_THIS && NET8_0_OR_GREATER
        }

        /// <summary>
        /// Accumulates the CRC (Cyclic redundancy check) checksum.
        /// </summary>
        /// <param name="crc">The base value to calculate checksum on</param>
        /// <param name="data">The data for which to compute the checksum</param>
        /// <returns>The CRC-checksum</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Crc32C(uint crc, ulong data) {
#if BCL_TYPE_THIS && NET8_0_OR_GREATER
            return BitOperations.Crc32C(crc, data);
#else
#if NETCOREAPP3_0_OR_GREATER
            if (Sse42.X64.IsSupported) {
                // This intrinsic returns a 64-bit register with the upper 32-bits set to 0.
                return (uint)Sse42.X64.Crc32(crc, data);
            }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
            if (Crc32.Arm64.IsSupported) {
                return Crc32.Arm64.ComputeCrc32C(crc, data);
            }
#endif // NET5_0_OR_GREATER

            return Crc32C(Crc32C(crc, (uint)(data)), (uint)(data >> 32));
#endif // BCL_TYPE_THIS && NET8_0_OR_GREATER
        }

#if NET8_0_OR_GREATER
#else
        private static class Crc32Fallback {
            // CRC-32 transition table.
            // While this implementation is based on the Castagnoli CRC-32 polynomial (CRC-32C),
            // x32 + x28 + x27 + x26 + x25 + x23 + x22 + x20 + x19 + x18 + x14 + x13 + x11 + x10 + x9 + x8 + x6 + x0,
            // this version uses reflected bit ordering, so 0x1EDC6F41 becomes 0x82F63B78u.
            // This is computed lazily so as to avoid increasing the assembly size for data that's
            // only needed on a fallback path.
            private static readonly uint[] s_crcTable = Crc32ReflectedTable.Generate(0x82F63B78u);

            internal static uint Crc32C(uint crc, byte data) {
#if NET5_0_OR_GREATER
                ref uint lookupTable = ref MemoryMarshal.GetArrayDataReference(s_crcTable);
#else
                ref uint lookupTable = ref s_crcTable[0];
#endif // NET5_0_OR_GREATER
                crc = Unsafe.Add(ref lookupTable, (nint)(byte)(crc ^ data)) ^ (crc >> 8);

                return crc;
            }

            internal static uint Crc32C(uint crc, ushort data) {
#if NET5_0_OR_GREATER
                ref uint lookupTable = ref MemoryMarshal.GetArrayDataReference(s_crcTable);
#else
                ref uint lookupTable = ref s_crcTable[0];
#endif // NET5_0_OR_GREATER

                crc = Unsafe.Add(ref lookupTable, (nint)(byte)(crc ^ (byte)data)) ^ (crc >> 8);
                data >>= 8;
                crc = Unsafe.Add(ref lookupTable, (nint)(byte)(crc ^ data)) ^ (crc >> 8);

                return crc;
            }

            internal static uint Crc32C(uint crc, uint data) {
#if NET5_0_OR_GREATER
                ref uint lookupTable = ref MemoryMarshal.GetArrayDataReference(s_crcTable);
#else
                ref uint lookupTable = ref s_crcTable[0];
#endif // NET5_0_OR_GREATER
                return Crc32CCore(ref lookupTable, crc, data);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static uint Crc32CCore(ref uint lookupTable, uint crc, uint data) {
                crc = Unsafe.Add(ref lookupTable, (nint)(byte)(crc ^ (byte)data)) ^ (crc >> 8);
                data >>= 8;
                crc = Unsafe.Add(ref lookupTable, (nint)(byte)(crc ^ (byte)data)) ^ (crc >> 8);
                data >>= 8;
                crc = Unsafe.Add(ref lookupTable, (nint)(byte)(crc ^ (byte)data)) ^ (crc >> 8);
                data >>= 8;
                crc = Unsafe.Add(ref lookupTable, (nint)(byte)(crc ^ data)) ^ (crc >> 8);

                return crc;
            }
        }

        /// <summary>
        /// Reset the lowest significant bit in the given value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint ResetLowestSetBit(uint value) {
            // It's lowered to BLSR on x86
            return value & (value - 1);
        }

        /// <summary>
        /// Reset specific bit in the given value
        /// Reset the lowest significant bit in the given value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong ResetLowestSetBit(ulong value) {
            // It's lowered to BLSR on x86
            return value & (value - 1);
        }

        /// <summary>
        /// Flip the bit at a specific position in a given value.
        /// Similar in behavior to the x86 instruction BTC (Bit Test and Complement).
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="index">The zero-based index of the bit to flip.
        /// Any value outside the range [0..31] is treated as congruent mod 32.</param>
        /// <returns>The new value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint FlipBit(uint value, int index) {
            return value ^ (1u << index);
        }

        /// <summary>
        /// Flip the bit at a specific position in a given value.
        /// Similar in behavior to the x86 instruction BTC (Bit Test and Complement).
        /// /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="index">The zero-based index of the bit to flip.
        /// Any value outside the range [0..63] is treated as congruent mod 64.</param>
        /// <returns>The new value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong FlipBit(ulong value, int index) {
            return value ^ (1ul << index);
        }
#endif // NET8_0_OR_GREATER

    }

#if NET8_0_OR_GREATER
#else
    internal static class Crc32ReflectedTable {
        internal static uint[] Generate(uint reflectedPolynomial) {
            uint[] table = new uint[256];

            for (int i = 0; i < 256; i++) {
                uint val = (uint)i;

                for (int j = 0; j < 8; j++) {
                    if ((val & 0b0000_0001) == 0) {
                        val >>= 1;
                    } else {
                        val = (val >> 1) ^ reflectedPolynomial;
                    }
                }

                table[i] = val;
            }

            return table;
        }
    }
#endif // NET8_0_OR_GREATER

}
