using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector128{T}"/> traits - AdvSimd .
    /// </summary>
    public sealed class WVectorTraits128AdvSimd : WVectorTraits128AdvSimdAbstract {
        private static readonly WVectorTraits128AdvSimd _instance = new WVectorTraits128AdvSimd(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits128AdvSimd Instance {
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
#if NET5_0_OR_GREATER
                    return AdvSimd.IsSupported;
#else
                    return false;
#endif // NET5_0_OR_GREATER
                }
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported() {
                if (IsSupported) return;
                throw new NotSupportedException("Not supported AdvSimd!");
            }

#if NET5_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft(Vector128<short> value, int shiftCount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftCount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft(Vector128<int> value, int shiftCount) {
                return Vector128.AsInt32(AdvSimd.ShiftLeftLogical(Vector128.AsUInt32(value), (byte)shiftCount));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftCount) {
                return AdvSimd.ShiftRightArithmetic(value, (byte)shiftCount);
            }

#endif // NET5_0_OR_GREATER
        }

    }
}
