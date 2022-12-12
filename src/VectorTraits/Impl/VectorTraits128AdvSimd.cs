using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;

namespace Zyl.VectorTraits.Impl {
    using WStatics = WVectorTraits128AdvSimd.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - AdvSimd .
    /// </summary>
    public sealed class VectorTraits128AdvSimd : VectorTraits128AdvSimdAbstract {
        private static readonly VectorTraits128AdvSimd _instance = new VectorTraits128AdvSimd(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraits128AdvSimd Instance {
            get { return _instance; }
        }

#if NET5_0_OR_GREATER


#endif // NET5_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector128{T}"/> traits.Statics - AdvSimd.
        /// </summary>
        public static class Statics {

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
                bool rt = (Vector<byte>.Count == ByteCountValue) && WStatics.GetIsSupported(noStrict);
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = WStatics.GetUnsupportedMessage(noStrict);
                VectorTraits128Abstract.GetUnsupportedMessage_VectorCount(ref rt);
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

#if NET5_0_OR_GREATER

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    return ShiftLeftFast_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft(Vector<uint> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeftFast_AcceleratedTypes {
                get {
                    return WStatics.ShiftLeftFast_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeftFast(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeftFast(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeftFast(Vector<ushort> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeftFast(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeftFast(Vector<uint> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeftFast(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeftFast(Vector<ulong> value, int shiftAmount) {
                return WStatics.ShiftLeftFast(value.AsVector128(), shiftAmount).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    return ShiftRightArithmeticFast_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmeticFast_AcceleratedTypes {
                get {
                    return WStatics.ShiftRightArithmeticFast_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmeticFast(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmeticFast(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmeticFast(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmeticFast(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightArithmeticFast(value.AsVector128(), shiftAmount).AsVector();
            }


#endif // NET5_0_OR_GREATER
        }

    }
}
