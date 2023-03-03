using System;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    using WStatics = WVectorTraits128AdvSimdB64.Statics;
    using BaseStatics = VectorTraits128Base.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - AdvSimd 64bit .
    /// </summary>
    public sealed class VectorTraits128AdvSimdB64 : VectorTraits128AdvSimdB64Abstract {
        private static readonly VectorTraits128AdvSimdB64 _instance = new VectorTraits128AdvSimdB64(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraits128AdvSimdB64 Instance {
            get { return _instance; }
        }

#if NET5_0_OR_GREATER


#endif // NET5_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector128{T}"/> traits.Statics - AdvSimd architecture-64bit .
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
                bool rt = (Vector<byte>.Count == ByteCountValue) && WStatics.GetIsSupported(noStrict);
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = WStatics.GetUnsupportedMessage(noStrict);
                VectorTraits128Abstract.GetUnsupportedMessage_VectorCount(ref rt);
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

#if NET5_0_OR_GREATER

            /// <inheritdoc cref="IVectorTraits.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    return WStatics.Ceiling_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Ceiling(Vector<double> value) {
                return WStatics.Ceiling(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    return WStatics.Floor_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Floor(Vector<double> value) {
                return WStatics.Floor(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    return WStatics.Narrow_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{double}, Vector{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Narrow(Vector<double> lower, Vector<double> upper) {
                return WStatics.Narrow(lower.AsVector128(), upper.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
#if BCL_OVERRIDE_BASE_FIXED && !NET7_0_OR_GREATER // Prior to 7.0, the ARM version of the function was not as good as the system library.
                    return BaseStatics.Widen_AcceleratedTypes;
#else
                    return WStatics.Widen_AcceleratedTypes;
#endif // BCL_OVERRIDE_BASE_FIXED && !NET7_0_OR_GREATER
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
#if BCL_OVERRIDE_BASE_FIXED && !NET7_0_OR_GREATER
                Vector.Widen(source, out lower, out upper);
#else
                WStatics.Widen(source.AsVector128(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
#endif // BCL_OVERRIDE_BASE_FIXED && !NET7_0_OR_GREATER
            }



#endif // NET5_0_OR_GREATER
        }

    }
}
