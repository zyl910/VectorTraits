using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Zyl.VectorTraits.Numerics {
#if NET7_0_OR_GREATER

    /// <summary>
    /// Call <see cref="IBinaryNumber{TSelf}"/> (调用 <see cref="IBinaryNumber{TSelf}"/>).
    /// </summary>
    public static class CallIBinaryNumber {

        /// <inheritdoc cref="IBinaryNumber{TSelf}.AllBitsSet"/>
        /// <typeparam name="TSelf">Target type (目标类型).</typeparam>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TSelf GetAllBitsSet<TSelf>() where TSelf : IBinaryNumber<TSelf> {
            return TSelf.AllBitsSet;
        }

    }

#endif // NET7_0_OR_GREATER
}
