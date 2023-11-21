using System;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits128AdvSimdB64.Statics;
    using BaseStatics = VectorTraits128Base.Statics;

    partial class VectorTraits128AdvSimdB64 {
#if NET5_0_OR_GREATER
        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.Dot_AcceleratedTypes"/>
            public static TypeCodeFlags Dot_AcceleratedTypes {
                get {
                    return WStatics.Dot_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot(Vector<double> left, Vector<double> right) {
                return WStatics.Dot(left.AsVector128(), right.AsVector128());
            }


            /// <inheritdoc cref="IVectorTraits.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    return WStatics.Multiply_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    return WStatics.Multiply_FullAcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Multiply(Vector<double> left, Vector<double> right) {
                return WStatics.Multiply(left.AsVector128(), right.AsVector128()).AsVector();
            }

        }
#endif // NET5_0_OR_GREATER
    }
}
