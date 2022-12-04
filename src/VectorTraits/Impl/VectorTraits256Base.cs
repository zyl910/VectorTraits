using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.ComponentModel;

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


            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft(Vector<byte> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET_X_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft(Vector<short> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft(Vector<int> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftLeft_Base(Vector<byte> value, int shiftCount) {
                shiftCount &= 7;
                return ShiftLeftFast_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftLeft_Base(Vector<short> value, int shiftCount) {
                shiftCount &= 0x0F;
                return ShiftLeftFast_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftLeft_Base(Vector<int> value, int shiftCount) {
                shiftCount &= 0x1F;
                return ShiftLeftFast_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET_X_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeftFast(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeftFast(Vector<short> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeftFast(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeftFast(Vector<int> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeftFast(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftLeftFast_Base(Vector<byte> value, int shiftCount) {
                Vector<byte> rt = value;
                byte* p = (byte*)&rt;
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
                p[16] <<= shiftCount;
                p[17] <<= shiftCount;
                p[18] <<= shiftCount;
                p[19] <<= shiftCount;
                p[20] <<= shiftCount;
                p[21] <<= shiftCount;
                p[22] <<= shiftCount;
                p[23] <<= shiftCount;
                p[24] <<= shiftCount;
                p[25] <<= shiftCount;
                p[26] <<= shiftCount;
                p[27] <<= shiftCount;
                p[28] <<= shiftCount;
                p[29] <<= shiftCount;
                p[30] <<= shiftCount;
                p[31] <<= shiftCount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftLeftFast_Base(Vector<short> value, int shiftCount) {
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

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftLeftFast_Base(Vector<int> value, int shiftCount) {
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
                shiftCount &= 0x1F;
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
