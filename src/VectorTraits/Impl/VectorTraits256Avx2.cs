using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;

namespace Zyl.VectorTraits.Impl {
    using WStatics = WVectorTraits256Avx2.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 256 - Avx2 .
    /// </summary>
    public sealed class VectorTraits256Avx2 : VectorTraits256Avx2Abstract {
        private static readonly VectorTraits256Avx2 _instance = new VectorTraits256Avx2(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraits256Avx2 Instance {
            get { return _instance; }
        }

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
                    return WStatics.IsSupported;
                }
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported() {
                WStatics.ThrowForUnsupported();
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int16}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<Int16> ShiftLeft(Vector<Int16> value, int shiftCount) {
                Vector256<Int16> vtemp = WStatics.ShiftLeft(Vectors.AsVector256(value), shiftCount);
                return Vectors.AsVector(vtemp);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int32}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<Int32> ShiftLeft(Vector<Int32> value, int shiftCount) {
                var vtemp = WStatics.ShiftLeft(Vectors.AsVector256(value), shiftCount);
                return Vectors.AsVector(vtemp);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{Int32}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<Int32> ShiftRightArithmetic(Vector<Int32> value, int shiftCount) {
                Vector256<Int32> vtemp = WStatics.ShiftRightArithmetic(Vectors.AsVector256(value), shiftCount);
                return Vectors.AsVector(vtemp);
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
