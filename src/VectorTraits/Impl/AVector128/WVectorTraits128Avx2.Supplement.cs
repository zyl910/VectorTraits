using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Sse.Statics;

    partial class WVectorTraits128Avx2 {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> ConditionalSelect_Relaxed<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
                return SuperStatics.ConditionalSelect_Relaxed(condition, left, right);
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
