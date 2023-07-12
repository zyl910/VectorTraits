using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits {
    /// <summary>
    /// Environment information related to vector types. Its members are similar to <see cref="Environment"/>,<see cref="RuntimeInformation"/>. It caches properties, improving performance (向量类型相关的环境信息. 它的成员类似 <see cref="Environment"/>,<see cref="RuntimeInformation"/>. 它会对属性进行缓存, 提高了性能).
    /// </summary>
    /// <seealso cref="Environment"/>
    /// <seealso cref="RuntimeInformation"/>
    public static class VectorEnvironment {

        /// <summary>
        /// Gets a value that indicates whether the current process is a 64-bit process (获取一个值，该值指示当前进程是否为 64 位进程).
        /// </summary>
        /// <value>true if the process is 64-bit; otherwise, false (如果进程为 64 位进程，则为 true；否则为 false).</value>
        public static bool Is64BitProcess {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NETSTANDARD1_0_OR_GREATER && !NETSTANDARD2_0_OR_GREATER
                return sizeof(long) == IntPtr.Size;
#else
                return Environment.Is64BitProcess;
#endif
            }
        }

    }
}
