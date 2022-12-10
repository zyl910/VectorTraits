using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// WVector(<see cref="Vector64{T}"/>, <see cref="Vector128{T}"/>, <see cref="Vector256{T}"/>...) traits interface (固定位宽向量的特征接口).
    /// </summary>
    public interface IWVectorTraits: IBaseTraits {
    }
}
