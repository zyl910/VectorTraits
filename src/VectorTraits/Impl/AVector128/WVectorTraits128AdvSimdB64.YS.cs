using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.CompilerServices;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128AdvSimd.Statics;

    partial class WVectorTraits128AdvSimdB64 {

        partial class Statics {

#if NET5_0_OR_GREATER


#endif // NET5_0_OR_GREATER
        }
    }
}
