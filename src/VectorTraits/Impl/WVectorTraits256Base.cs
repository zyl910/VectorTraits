using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector256{T}"/> traits - Base.
    /// </summary>
    public sealed class WVectorTraits256Base : WVectorTraits256Abstract {
#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector256{T}"/> traits.Statics - Base.
        /// </summary>
        public static class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
#if NET7_0_OR_GREATER
                    return Vector256.IsSupported;
#else
                    return false;
#endif // NET7_0_OR_GREATER
                }
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported() {
                if (IsSupported) return;
                // No exceptions are thrown because of the software implementation.
                // throw new NotSupportedException("The Vector256 does not support hardware acceleration!");
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IVectorWTraits256.ShiftLeft(Vector256{Int16}, int)">
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<Int16> ShiftLeft(Vector256<Int16> value, int shiftCount) {
                Int16* p = (Int16*)&value;
                p[0] <<= shiftCount;
                p[1] <<= shiftCount;
                p[2] <<= shiftCount;
                p[3] <<= shiftCount;
                p[4] <<= shiftCount;
                p[5] <<= shiftCount;
                p[6] <<= shiftCount;
                p[7] <<= shiftCount;
                p[8] <<= shiftCount;
                p[9] <<= shiftCount;
                p[10] <<= shiftCount;
                p[11] <<= shiftCount;
                p[12] <<= shiftCount;
                p[13] <<= shiftCount;
                p[14] <<= shiftCount;
                p[15] <<= shiftCount;
                return value;
            }

            /// <inheritdoc cref="IVectorWTraits256.ShiftLeft(Vector256{Int32}, int)">
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<Int32> ShiftLeft(Vector256<Int32> value, int shiftCount) {
                Int32* p = (Int32*)&value;
                p[0] <<= shiftCount;
                p[1] <<= shiftCount;
                p[2] <<= shiftCount;
                p[3] <<= shiftCount;
                p[4] <<= shiftCount;
                p[5] <<= shiftCount;
                p[6] <<= shiftCount;
                p[7] <<= shiftCount;
                return value;
            }

            /// <inheritdoc cref="IVectorWTraits256.ShiftRightArithmetic(Vector256{Int32}, int)">
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<Int32> ShiftRightArithmetic(Vector256<Int32> value, int shiftCount) {
                Int32* p = (Int32*)&value;
                p[0] >>= shiftCount;
                p[1] >>= shiftCount;
                p[2] >>= shiftCount;
                p[3] >>= shiftCount;
                p[4] >>= shiftCount;
                p[5] >>= shiftCount;
                p[6] >>= shiftCount;
                p[7] >>= shiftCount;
                return value;
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
