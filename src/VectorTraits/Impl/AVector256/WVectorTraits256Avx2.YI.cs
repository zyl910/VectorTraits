using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector256 {
    using SuperStatics = WVectorTraits256Base.Statics;

    partial class WVectorTraits256Avx2 {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector256<T> value) where T : struct {
                Vector256<int> mask = OnesComplement(value).AsInt32();
                return Avx.TestZ(mask, mask);
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector256<T> value) where T : struct {
                return !Avx.TestZ(value.AsInt32(), value.AsInt32());
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
