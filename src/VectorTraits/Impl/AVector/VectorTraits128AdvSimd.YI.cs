using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits128AdvSimd.Statics;
    using BaseStatics = VectorTraitsBase.Statics;

    partial class VectorTraits128AdvSimd {
#if NET5_0_OR_GREATER
        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return WStatics.YIsAllTrue_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsAllTrue{T}(Vector{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector<T> value) where T : struct {
                return WStatics.YIsAllTrue(value.AsVector128());
            }


            /// <inheritdoc cref="IVectorTraits.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return WStatics.YIsAnyTrue_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsAnyTrue{T}(Vector{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector<T> value) where T : struct {
                return WStatics.YIsAnyTrue(value.AsVector128());
            }

        }
#endif // NET5_0_OR_GREATER
    }
}
