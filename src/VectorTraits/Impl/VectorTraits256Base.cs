using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;

namespace Zyl.VectorTraits.Impl {
    using BaseStatics = VectorTraitsBase.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 256 - base.
    /// </summary>
    public sealed class VectorTraits256Base : VectorTraits256Abstract {
        private static readonly VectorTraits256Base _instance = new VectorTraits256Base(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraits256Base Instance {
            get { return _instance; }
        }

        /// <summary>
        /// <see cref="Vector{T}"/> traits.Statics 256 - base.
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
                bool rt = (Vector<byte>.Count == ByteCountValue);
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, ByteCountValue);
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }


            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftLeft(Vector<short> value, int shiftCount) {
#if SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft_Multiply(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftLeft(Vector<int> value, int shiftCount) {
#if SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft_Multiply(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // SOFTWARE_OPTIMIZATION
            }

            // ShiftLeft - Base.
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftLeft_Base(Vector<short> value, int shiftCount) {
                Vector<short> rt = value;
                short* p = (short*)&rt;
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
                return rt;
            }

            // ShiftLeft - Base.
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftLeft_Base(Vector<int> value, int shiftCount) {
                Vector<int> rt = value;
                int* p = (int*)&rt;
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


            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftCount) {
                Vector<int> rt = value;
                int* p = (int*)&rt;
                p[0] >>= shiftCount;
                p[1] >>= shiftCount;
                p[2] >>= shiftCount;
                p[3] >>= shiftCount;
                p[4] >>= shiftCount;
                p[5] >>= shiftCount;
                p[6] >>= shiftCount;
                p[7] >>= shiftCount;
                return rt;
            }

        } // Statics
    }
}
