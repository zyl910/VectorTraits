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

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft(Vector<short> value, int shiftCount) {
#if SOFTWARE_OPTIMIZATION
                return ShiftLeft_Multiply(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // SOFTWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft(Vector<int> value, int shiftCount) {
#if SOFTWARE_OPTIMIZATION
                return ShiftLeft_Multiply(value, shiftCount);
#else
                return ShiftLeft_Base(value, shiftCount);
#endif // SOFTWARE_OPTIMIZATION
            }

            // ShiftLeft - Base.
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftLeft_Base(Vector<short> value, int shiftCount) {
                Vector<short> rt = value;
                int cnt = Vector<short>.Count;
                short* p = (short*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] <<= shiftCount;
                }
                return rt;
            }

            // ShiftLeft - Base.
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftLeft_Base(Vector<int> value, int shiftCount) {
                Vector<int> rt = value;
                int cnt = Vector<int>.Count;
                int* p = (int*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] <<= shiftCount;
                }
                return rt;
            }

            // ShiftLeft - Multiply.
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Multiply(Vector<short> value, int shiftCount) {
                short m = (short)(1 << (shiftCount & 0x0F));
                return Vector.Multiply(value, m);
            }

            // ShiftLeft - Multiply.
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Multiply(Vector<int> value, int shiftCount) {
                int m = 1 << (shiftCount & 0x1F);
                return Vector.Multiply(value, m);
            }


            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftCount) {
                Vector<int> rt = value;
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
