using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl {
    using SuperStatics = WVectorTraits256Base.Statics;

    /// <summary>
    /// <see cref="Vector256{T}"/> traits - Avx2 .
    /// </summary>
    public sealed partial class WVectorTraits256Avx2 : WVectorTraits256Avx2Abstract {
        private static readonly WVectorTraits256Avx2 _instance = new WVectorTraits256Avx2(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits256Avx2 Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector256{T}"/> traits.Statics - Avx2.
        /// </summary>
        public static partial class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
                    return GetIsSupported();
                }
            }

            /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
            public static bool GetIsSupported(bool noStrict = false) {
                bool rt = false;
#if NETCOREAPP3_0_OR_GREATER
                rt = Avx.IsSupported && Avx2.IsSupported;
#else
#endif // NETCOREAPP3_0_OR_GREATER
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Requires hardware support Avx, Avx2!";
#if NETCOREAPP3_0_OR_GREATER
#else
                rt = "Vector256 type is not supported! " + rt;
#endif // NETCOREAPP3_0_OR_GREATER
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Ceiling(Vector256<float> value) {
                return Avx.Ceiling(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Ceiling(Vector256<double> value) {
                return Avx.Ceiling(value);
            }


            /// <inheritdoc cref="IWVectorTraits256.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Floor(Vector256<float> value) {
                return Avx.Floor(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Floor(Vector256<double> value) {
                return Avx.Floor(value);
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeftFast(Vector256<sbyte> value, int shiftAmount) {
                return ShiftLeftFast(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeftFast(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> t = Avx2.And(value, Vector256s<byte>.GetMaskBits(8 - shiftAmount));
                return Avx2.ShiftLeftLogical(t.AsUInt16(), (byte)shiftAmount).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeftFast(Vector256<short> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeftFast(Vector256<ushort> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeftFast(Vector256<int> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeftFast(Vector256<uint> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeftFast(Vector256<long> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeftFast(Vector256<ulong> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmeticFast(Vector256<sbyte> value, int shiftAmount) {
                //return ShiftRightArithmeticFast_Widen(value, shiftAmount);
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmeticFast_Widen(Vector256<sbyte> value, int shiftAmount) {
                Vector256<short> lowerToHigh = Avx2.ShiftLeftLogical(value.AsInt16(), 8);
                Vector256<short> lowerShifted = Avx2.ShiftRightArithmetic(lowerToHigh, (byte)shiftAmount);
                Vector256<sbyte> upper = Avx2.ShiftRightArithmetic(value.AsInt16(), (byte)shiftAmount).AsSByte();
                Vector256<sbyte> lower = Avx2.ShiftRightLogical(lowerShifted, 8).AsSByte();
                Vector256<sbyte> rt = Avx2.Or(Avx2.And(Vector256s<sbyte>.XyYMask, upper), lower);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmeticFast_Negative(Vector256<sbyte> value, int shiftAmount) {
                Vector256<sbyte> mask = Vector256s<sbyte>.GetMaskBits(8 - shiftAmount);
                Vector256<sbyte> shifted = Avx2.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsSByte();
                Vector256<sbyte> sign = Avx2.CompareGreaterThan(Vector256<sbyte>.Zero, value);
                Vector256<sbyte> rt = ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmeticFast(Vector256<short> value, int shiftAmount) {
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmeticFast(Vector256<int> value, int shiftAmount) {
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmeticFast(Vector256<long> value, int shiftAmount) {
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmeticFast_Narrow(Vector256<long> value, int shiftAmount) {
                if (0 == shiftAmount) {
                    return value;
                }
                Vector256<long> rt;
                Vector256<int> lower, upper;
                Vector256<int> XyXMask = Vector256s<int>.XyXMask;
                const byte controlInputUpper = ShuffleControlG4.YYWW; // BitUtil._MM_SHUFFLE(3, 3, 1, 1) = 0xF5 = 0b11_11_01_01;
                Vector256<int> upperAtLower = Avx2.Shuffle(value.AsInt32(), controlInputUpper); // f({ v0.lower, v0.upper, v1.lower, v1.upper, ... }) = { v0.upper, v0.upper, v1.upper, v1.upper, ... }
                upperAtLower = Avx2.And(XyXMask, upperAtLower); // = { v0.upper, 0, v1.upper, 0, ... }
                Vector256<int> upperOld = Avx2.AndNot(XyXMask, value.AsInt32()); // = { 0, v0.upper, 0, v1.upper, ... }
                if (32 <= shiftAmount) {
                    // Scalar algorithm:
                    //    uint lower = (uint)((int)value._upper >> (shiftAmount & 31));
                    //    uint upper = (uint)((int)value._upper >> 31);
                    lower = Avx2.ShiftRightArithmetic(upperAtLower, (byte)(shiftAmount & 31));
                    upper = Avx2.ShiftRightArithmetic(upperOld, 31);
                    rt = Avx2.Or(lower, upper).AsInt64();
                } else {
                    // Scalar algorithm:
                    //    uint lower = (value._lower >> shiftAmount) | (value._upper << (32 - shiftAmount));
                    //    uint upper = (uint)((int)value._upper >> shiftAmount);
                    Vector256<int> lowerOld = Avx2.And(XyXMask, value.AsInt32());
                    lower = Avx2.Or(Avx2.ShiftRightLogical(lowerOld, (byte)shiftAmount), Avx2.ShiftLeftLogical(upperAtLower, (byte)(32 - shiftAmount)));
                    upper = Avx2.ShiftRightArithmetic(upperOld, (byte)shiftAmount);
                    rt = Avx2.Or(lower, upper).AsInt64();
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmeticFast_NarrowIfLess(Vector256<long> value, int shiftAmount) {
                if (0 == shiftAmount) {
                    return value;
                }
                Vector256<int> XyXMask = Vector256s<int>.XyXMask;
                const byte controlInputUpper = ShuffleControlG4.YYWW; // BitUtil._MM_SHUFFLE(3, 3, 1, 1) = 0xF5 = 0b11_11_01_01;
                Vector256<int> upperAtLower = Avx2.Shuffle(value.AsInt32(), controlInputUpper); // f({ v0.lower, v0.upper, v1.lower, v1.upper, ... }) = { v0.upper, v0.upper, v1.upper, v1.upper, ... }
                byte shiftAmountUpper = (byte)BitUtil.Min(31, shiftAmount);
                byte shiftAmountLeft = (byte)BitUtil.Max(0, 32 - shiftAmount);
                Vector256<int> lowerUse1Mask = Vector256.Create(BitUtil.ToInt32Mask(32 <= shiftAmount));
                upperAtLower = Avx2.And(XyXMask, upperAtLower); // = { v0.upper, 0, v1.upper, 0, ... }
                Vector256<int> lowerOld = Avx2.And(XyXMask, value.AsInt32());
                Vector256<int> upperOld = Avx2.AndNot(XyXMask, value.AsInt32()); // = { 0, v0.upper, 0, v1.upper, ... }
                Vector256<int> lower2 = Avx2.Or(Avx2.ShiftRightLogical(lowerOld, (byte)shiftAmount), Avx2.ShiftLeftLogical(upperAtLower, shiftAmountLeft));
                Vector256<int> upper = Avx2.ShiftRightArithmetic(upperOld, shiftAmountUpper);
                Vector256<int> lower1 = Avx2.ShiftRightArithmetic(upperAtLower, (byte)(shiftAmount & 31));
                Vector256<int> lower = ConditionalSelect(lowerUse1Mask, lower1, lower2);
                Vector256<long> rt = Avx2.Or(lower, upper).AsInt64();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmeticFast_Negative(Vector256<long> value, int shiftAmount) {
                Vector256<long> sign = Avx2.CompareGreaterThan(Vector256<long>.Zero, value);
                byte shiftAmountLeft = (byte)(64 - shiftAmount);
                Vector256<long> rt = Avx2.Or(Avx2.ShiftRightLogical(value, (byte)shiftAmount), Avx2.ShiftLeftLogical(sign, shiftAmountLeft));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical(Vector256<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogicalFast(Vector256<sbyte> value, int shiftAmount) {
                return ShiftRightLogicalFast(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogicalFast(Vector256<byte> value, int shiftAmount) {
                return ShiftRightLogicalFast_FirstShift(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogicalFast_FirstAnd(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> t = Avx2.AndNot(Vector256s<byte>.GetMaskBits(shiftAmount), value);
                Vector256<byte> rt = Avx2.ShiftRightLogical(t.AsUInt16(), (byte)shiftAmount).AsByte();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogicalFast_FirstShift(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> t = Avx2.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsByte();
                Vector256<byte> rt = Avx2.And(t, Vector256s<byte>.GetMaskBits(8 - shiftAmount));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogicalFast(Vector256<short> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogicalFast(Vector256<ushort> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogicalFast(Vector256<int> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogicalFast(Vector256<uint> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogicalFast(Vector256<long> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogicalFast(Vector256<ulong> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }


            /// <inheritdoc cref="IWVectorTraits256.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<float> source, out Vector256<double> lower, out Vector256<double> upper) {
                lower = Avx.ConvertToVector256Double(source.GetLower());
                upper = Avx.ConvertToVector256Double(source.GetUpper());
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper) {
                // vmovupd     ymm0,ymmword ptr [rbp-790h]  
                // vpermq      ymm0,ymm0,0D4h  
                // vxorps      ymm1,ymm1,ymm1  
                // vpcmpgtb    ymm1,ymm1,ymm0  
                // vpunpcklbw  ymm0,ymm0,ymm1  
                // vmovupd     ymmword ptr [rbp-70h],ymm0  
                // vmovupd     ymm0,ymmword ptr [rbp-790h]  
                // vpermq      ymm0,ymm0,0E8h  
                // vxorps      ymm1,ymm1,ymm1  
                // vpcmpgtb    ymm1,ymm1,ymm0  
                // vpunpckhbw  ymm0,ymm0,ymm1  
                // vmovupd     ymmword ptr [rbp-90h],ymm0  
                Vector256<sbyte> zero = Vector256<sbyte>.Zero;
                Vector256<sbyte> lower0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XYYW).AsSByte(); // UnpackLow uses only `X_Y_`.
                Vector256<sbyte> lowerMask = Avx2.CompareGreaterThan(zero, lower0);
                lower = Avx2.UnpackLow(lower0, lowerMask).AsInt16();
                Vector256<sbyte> upper0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XZZW).AsSByte(); // UnpackHigh uses only `_Z_W`.
                Vector256<sbyte> upperMask = Avx2.CompareGreaterThan(zero, upper0);
                upper = Avx2.UnpackHigh(upper0, upperMask).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper) {
                // vmovupd     ymm0,ymmword ptr [rbp-7D0h]  
                // vpermq      ymm0,ymm0,0D4h  
                // vxorps      ymm1,ymm1,ymm1  
                // vpunpcklbw  ymm0,ymm0,ymm1  
                // vmovupd     ymmword ptr [rbp-0B0h],ymm0  
                // vmovupd     ymm0,ymmword ptr [rbp-7D0h]  
                // vpermq      ymm0,ymm0,0E8h  
                // vxorps      ymm1,ymm1,ymm1  
                // vpunpckhbw  ymm0,ymm0,ymm1  
                // vmovupd     ymmword ptr [rbp-0D0h],ymm0  
                Vector256<byte> zero = Vector256<byte>.Zero;
                Vector256<byte> lower0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XYYW).AsByte(); // UnpackLow uses only `X_Y_`.
                lower = Avx2.UnpackLow(lower0, zero).AsUInt16();
                Vector256<byte> upper0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XZZW).AsByte(); // UnpackHigh uses only `_Z_W`.
                upper = Avx2.UnpackHigh(upper0, zero).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper) {
                Vector256<short> zero = Vector256<short>.Zero;
                Vector256<short> lower0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XYYW).AsInt16();
                Vector256<short> lowerMask = Avx2.CompareGreaterThan(zero, lower0);
                lower = Avx2.UnpackLow(lower0, lowerMask).AsInt32();
                Vector256<short> upper0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XZZW).AsInt16();
                Vector256<short> upperMask = Avx2.CompareGreaterThan(zero, upper0);
                upper = Avx2.UnpackHigh(upper0, upperMask).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper) {
                Vector256<ushort> zero = Vector256<ushort>.Zero;
                Vector256<ushort> lower0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XYYW).AsUInt16();
                lower = Avx2.UnpackLow(lower0, zero).AsUInt32();
                Vector256<ushort> upper0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XZZW).AsUInt16();
                upper = Avx2.UnpackHigh(upper0, zero).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper) {
                Vector256<int> zero = Vector256<int>.Zero;
                Vector256<int> lower0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XYYW).AsInt32();
                Vector256<int> lowerMask = Avx2.CompareGreaterThan(zero, lower0);
                lower = Avx2.UnpackLow(lower0, lowerMask).AsInt64();
                Vector256<int> upper0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XZZW).AsInt32();
                Vector256<int> upperMask = Avx2.CompareGreaterThan(zero, upper0);
                upper = Avx2.UnpackHigh(upper0, upperMask).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper) {
                Vector256<uint> zero = Vector256<uint>.Zero;
                Vector256<uint> lower0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XYYW).AsUInt32();
                lower = Avx2.UnpackLow(lower0, zero).AsUInt64();
                Vector256<uint> upper0 = Avx2.Permute4x64(source.AsUInt64(), ShuffleControlG4.XZZW).AsUInt32();
                upper = Avx2.UnpackHigh(upper0, zero).AsUInt64();
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
