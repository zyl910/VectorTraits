using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;

namespace Zyl.VectorTraits {
    partial class Vector256s {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// (ExType) Returns the number of elements stored in the vector (返回存储在向量中的元素数量).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <returns>The number of elements stored in the vector (存储在向量中的元素数量).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ExCount<T>() where T : struct {
            return Vector256<byte>.Count / Unsafe.SizeOf<T>();
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
