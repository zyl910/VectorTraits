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
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits256Avx2.Statics;
    using BaseStatics = VectorTraitsBase.Statics;

    partial class VectorTraits256Avx2 {
#if NETCOREAPP3_0_OR_GREATER
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
                return WStatics.YIsAllTrue(value.AsVector256());
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
                return WStatics.YIsAnyTrue(value.AsVector256());
            }

        }
#endif // NETCOREAPP3_0_OR_GREATER
    }
}
