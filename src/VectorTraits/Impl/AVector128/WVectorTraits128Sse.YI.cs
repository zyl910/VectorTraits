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

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128Sse {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector128<T> value) where T : struct {
                if (Sse41.IsSupported) {
                    Vector128<int> mask = OnesComplement(value).AsInt32();
                    return Sse41.TestZ(mask, mask);
                } else {
                    int matches = Sse2.MoveMask(value.AsByte());
                    return 0x0FFFF == matches;
                }
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector128<T> value) where T : struct {
                if (Sse41.IsSupported) {
                    return !Sse41.TestZ(value.AsInt32(), value.AsInt32());
                } else {
                    int matches = Sse2.MoveMask(value.AsByte());
                    return 0 != matches;
                }
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
