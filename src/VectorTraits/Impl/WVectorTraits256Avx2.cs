using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector256{T}"/> traits - Avx2 .
    /// </summary>
    public sealed class WVectorTraits256Avx2 : WVectorTraits256Avx2Abstract {
#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector256{T}"/> traits.Statics - Avx2.
        /// </summary>
        public static class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
#if NETCOREAPP3_0_OR_GREATER
                    return Avx2.IsSupported;
#else
                    return false;
#endif // NETCOREAPP3_0_OR_GREATER
                }
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported() {
                if (IsSupported) return;
                throw new NotSupportedException("Not supported Avx2!");
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{Int16}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<Int16> ShiftLeft(Vector256<Int16> value, int shiftCount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftCount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{Int32}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<Int32> ShiftLeft(Vector256<Int32> value, int shiftCount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftCount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{Int32}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<Int32> ShiftRightArithmetic(Vector256<Int32> value, int shiftCount) {
                return Avx2.ShiftRightArithmetic(value, (byte)shiftCount);
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
