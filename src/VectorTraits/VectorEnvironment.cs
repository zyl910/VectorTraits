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

#if NETCOREAPP3_0_OR_GREATER
#else
        private static readonly Architecture _ProcessArchitecture = RuntimeInformation.ProcessArchitecture;
        private static readonly bool _ProcessIsX86Family = _ProcessArchitecture <= Architecture.X64;
        private static readonly bool _ProcessIsArmFamily = (Architecture.Arm <= _ProcessArchitecture) && (_ProcessArchitecture <= Architecture.Arm64);
#endif

        /// <summary>
        /// Gets the process architecture of the currently running app (获取当前正在运行的应用的进程架构).
        /// </summary>
        /// <value>The process architecture of the currently running app (当前正在运行的应用的进程架构).</value>
        public static Architecture ProcessArchitecture {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_0_OR_GREATER
                return RuntimeInformation.ProcessArchitecture;
#else
                return _ProcessArchitecture;
#endif
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the current process architecture is a X86 family (获取一个值，该值指示当前进程架构是否为 X86 家族的). e.g. X86, X64 .
        /// </summary>
        public static bool ProcessIsX86Family {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return System.Runtime.Intrinsics.X86.X86Base.IsSupported;
#elif NETCOREAPP3_0_OR_GREATER
                return VectorEnvironment.ProcessIsX86Family;
#else
                return _ProcessIsX86Family;
#endif
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the current process architecture is a Arm family (获取一个值，该值指示当前进程架构是否为 Arm 家族的). e.g. Arm, Arm64, Armv6 .
        /// </summary>
        public static bool ProcessIsArmFamily {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return System.Runtime.Intrinsics.Arm.ArmBase.IsSupported;
#elif NETCOREAPP3_0_OR_GREATER
                return (Architecture.Arm <= ProcessArchitecture) && (ProcessArchitecture <= Architecture.Arm64);
#else
                return _ProcessIsArmFamily;
#endif
            }
        }

    }
}
