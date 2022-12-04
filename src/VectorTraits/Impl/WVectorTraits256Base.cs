using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector256{T}"/> traits - Base.
    /// </summary>
    public sealed class WVectorTraits256Base : WVectorTraits256Abstract {
        private static readonly WVectorTraits256Base _instance = new WVectorTraits256Base(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits256Base Instance {
            get { return _instance; }
        }

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
                    return GetIsSupported();
                }
            }

            /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
            public static bool GetIsSupported(bool noStrict = false) {
                bool rt = false;
#if NETCOREAPP3_0_OR_GREATER
                rt = true;
#else
#endif // NETCOREAPP3_0_OR_GREATER
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Vector256 type is not supported!";
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET_X_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET_X_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft(Vector256<short> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft(Vector256<int> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft(Vector256<long> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftLeft_Base(Vector256<sbyte> value, int shiftCount) {
                shiftCount &= 7;
                return ShiftLeftFast_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> ShiftLeft_Base(Vector256<byte> value, int shiftCount) {
                shiftCount &= 7;
                return ShiftLeftFast_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftLeft_Base(Vector256<short> value, int shiftCount) {
                shiftCount &= 0x0F;
                return ShiftLeftFast_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> ShiftLeft_Base(Vector256<ushort> value, int shiftCount) {
                shiftCount &= 0x0F;
                return ShiftLeftFast_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftLeft_Base(Vector256<int> value, int shiftCount) {
                shiftCount &= 0x1F;
                return ShiftLeftFast_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> ShiftLeft_Base(Vector256<uint> value, int shiftCount) {
                shiftCount &= 0x1F;
                return ShiftLeftFast_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftLeft_Base(Vector256<long> value, int shiftCount) {
                shiftCount &= 0x3F;
                return ShiftLeftFast_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> ShiftLeft_Base(Vector256<ulong> value, int shiftCount) {
                shiftCount &= 0x3F;
                return ShiftLeftFast_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeftFast(Vector256<sbyte> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET_X_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeftFast(Vector256<byte> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET_X_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeftFast(Vector256<short> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeftFast(Vector256<ushort> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeftFast(Vector256<int> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeftFast(Vector256<uint> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeftFast(Vector256<long> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeftFast(Vector256<ulong> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_FIXED && (NET7_0_OR_GREATER)
                return Vector256.ShiftLeft(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftLeftFast_Base(Vector256<sbyte> value, int shiftCount) {
                return ShiftLeftFast_Base(value.AsByte(), shiftCount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> ShiftLeftFast_Base(Vector256<byte> value, int shiftCount) {
                Vector256<byte> rt = value;
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftLeftFast_Base(Vector256<short> value, int shiftCount) {
                Vector256<short> rt = value;
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> ShiftLeftFast_Base(Vector256<ushort> value, int shiftCount) {
                return ShiftLeftFast_Base(value.AsInt16(), shiftCount).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftLeftFast_Base(Vector256<int> value, int shiftCount) {
                Vector256<int> rt = value;
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

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> ShiftLeftFast_Base(Vector256<uint> value, int shiftCount) {
                return ShiftLeftFast_Base(value.AsInt32(), shiftCount).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftLeftFast_Base(Vector256<long> value, int shiftCount) {
                Vector256<long> rt = value;
                long* p = (long*)&rt;
                p[0] <<= shiftCount;
                p[1] <<= shiftCount;
                p[2] <<= shiftCount;
                p[3] <<= shiftCount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> ShiftLeftFast_Base(Vector256<ulong> value, int shiftCount) {
                return ShiftLeftFast_Base(value.AsInt64(), shiftCount).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftCount) {
                Vector256<int> rt = value;
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

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
