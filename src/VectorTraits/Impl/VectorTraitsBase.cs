using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.ComponentModel;

namespace Zyl.VectorTraits.Impl {

    /// <summary>
    /// <see cref="Vector{T}"/> traits - Variable base.
    /// </summary>
    public sealed class VectorTraitsBase : VectorTraitsAbstract {
        private static readonly VectorTraitsBase _instance = new VectorTraitsBase(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraitsBase Instance {
            get { return _instance; }
        }

        /// <summary>
        /// <see cref="Vector{T}"/> traits.Statics - Variable base.
        /// </summary>
        public static class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return Vector<byte>.Count; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
                    return true;
                }
            }

            /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
            public static bool GetIsSupported(bool noStrict = false) {
                if (!noStrict) {
                }
                return true;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                if (!noStrict) {
                }
                return "Vector type is not supported!";
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft(Vector<byte> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_VAR && (NET_X_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Multiply(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft(Vector<short> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_VAR && (NET7_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Multiply(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft(Vector<int> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_VAR && (NET7_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Multiply(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftLeft_Base(Vector<byte> value, int shiftCount) {
                shiftCount &= 7;
                return ShiftLeft_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftLeft_Base(Vector<short> value, int shiftCount) {
                shiftCount &= 0x0F;
                return ShiftLeft_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftLeft_Base(Vector<int> value, int shiftCount) {
                shiftCount &= 0x1F;
                return ShiftLeft_Base(value, shiftCount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Multiply(Vector<byte> value, int shiftCount) {
                shiftCount &= 7;
                return ShiftLeftFast_Multiply(value, shiftCount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Multiply(Vector<short> value, int shiftCount) {
                shiftCount &= 0x0F;
                return ShiftLeftFast_Multiply(value, shiftCount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Multiply(Vector<int> value, int shiftCount) {
                shiftCount &= 0x1F;
                return ShiftLeftFast_Multiply(value, shiftCount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_VAR && (NET_X_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeftFast_Multiply(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeftFast(Vector<short> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_VAR && (NET7_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeftFast_Multiply(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeftFast(Vector<int> value, int shiftCount) {
#if BCL_OVERRIDE_BASE_VAR && (NET7_0_OR_GREATER)
                return Vector.ShiftLeft(value, shiftCount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeftFast_Multiply(value, shiftCount);
#else
                return ShiftLeftFast_Base(value, shiftCount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftLeftFast_Base(Vector<byte> value, int shiftCount) {
                Vector<byte> rt = value;
                int cnt = Vector<byte>.Count;
                byte* p = (byte*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] <<= shiftCount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftLeftFast_Base(Vector<short> value, int shiftCount) {
                Vector<short> rt = value;
                int cnt = Vector<short>.Count;
                short* p = (short*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] <<= shiftCount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftLeftFast_Base(Vector<int> value, int shiftCount) {
                Vector<int> rt = value;
                int cnt = Vector<int>.Count;
                int* p = (int*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] <<= shiftCount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeftFast_Multiply(Vector<byte> value, int shiftCount) {
                Vector<byte> t = Vector.BitwiseAnd(value, Vectors<byte>.GetMaskBits(8 - shiftCount));
                int m = 1 << shiftCount;
                return Vector.AsVectorByte(Vector.Multiply(Vector.AsVectorInt32(t), m));
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeftFast_Multiply(Vector<short> value, int shiftCount) {
                short m = (short)(1 << shiftCount);
                return Vector.Multiply(value, m);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeftFast_Multiply(Vector<int> value, int shiftCount) {
                int m = 1 << shiftCount;
                return Vector.Multiply(value, m);
            }


            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftCount) {
                Vector<int> rt = value;
                shiftCount &= 0x1F;
                int cnt = Vector<int>.Count;
                int* p = (int*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] >>= shiftCount;
                }
                return rt;
            }

        } // Statics

    }
}
