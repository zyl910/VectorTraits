using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// WVector(<see cref="Vector64{T}"/>, <see cref="Vector128{T}"/>, <see cref="Vector256{T}"/>) traits interface.
    /// </summary>
    public interface IWVectorTraits: IBaseTraits {
    }
}
