using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;

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

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported() {
                if (IsSupported) return;
                // No exceptions are thrown because of the software implementation.
                // throw new NotSupportedException("The Vector does not support hardware acceleration!");
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int16}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<Int16> ShiftLeft(Vector<Int16> value, int shiftCount) {
                Vector<Int16> rt = value;
                int cnt = Vector<Int16>.Count;
                Int16* p = (Int16*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] <<= shiftCount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int32}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<Int32> ShiftLeft(Vector<Int32> value, int shiftCount) {
                Vector<Int32> rt = value;
                int cnt = Vector<Int32>.Count;
                Int32* p = (Int32*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] <<= shiftCount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{Int32}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftCount) {
                Vector<Int32> rt = value;
                int cnt = Vector<Int32>.Count;
                Int32* p = (Int32*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] >>= shiftCount;
                }
                return rt;
            }

        } // Statics

    }
}
