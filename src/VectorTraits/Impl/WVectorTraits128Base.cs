﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector128{T}"/> traits - Base.
    /// </summary>
    public sealed class WVectorTraits128Base : WVectorTraits128Abstract {
        private static readonly WVectorTraits128Base _instance = new WVectorTraits128Base(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits128Base Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector128{T}"/> traits.Statics - Base.
        /// </summary>
        public static class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
                    return true;
                }
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported() {
                if (IsSupported) return;
                // No exceptions are thrown because of the software implementation.
                // throw new NotSupportedException("The Vector128 does not support hardware acceleration!");
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IVectorWTraits128.ShiftLeft(Vector128{Int16}, int)">
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<Int16> ShiftLeft(Vector128<Int16> value, int shiftCount) {
                Vector128<Int16> rt = value;
                Int16* p = (Int16*)&rt;
                p[0] <<= shiftCount;
                p[1] <<= shiftCount;
                p[2] <<= shiftCount;
                p[3] <<= shiftCount;
                p[4] <<= shiftCount;
                p[5] <<= shiftCount;
                p[6] <<= shiftCount;
                p[7] <<= shiftCount;
                return rt;
            }

            /// <inheritdoc cref="IVectorWTraits128.ShiftLeft(Vector128{Int32}, int)">
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<Int32> ShiftLeft(Vector128<Int32> value, int shiftCount) {
                Vector128<Int32> rt = value;
                Int32* p = (Int32*)&rt;
                p[0] <<= shiftCount;
                p[1] <<= shiftCount;
                p[2] <<= shiftCount;
                p[3] <<= shiftCount;
                return rt;
            }

            /// <inheritdoc cref="IVectorWTraits128.ShiftRightArithmetic(Vector128{Int32}, int)">
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<Int32> ShiftRightArithmetic(Vector128<Int32> value, int shiftCount) {
                Vector128<Int32> rt = value;
                Int32* p = (Int32*)&rt;
                p[0] >>= shiftCount;
                p[1] >>= shiftCount;
                p[2] >>= shiftCount;
                p[3] >>= shiftCount;
                return rt;
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}