using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Zyl.VectorTraits.Impl.Util;

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

#if NET7_0_OR_GREATER
#else
        private static readonly Architecture _ProcessArchitecture = RuntimeInformation.ProcessArchitecture;
#endif
        /// <summary>
        /// Gets the process architecture of the currently running app (获取当前正在运行的应用的进程架构).
        /// </summary>
        /// <value>The process architecture of the currently running app (当前正在运行的应用的进程架构).</value>
        public static Architecture ProcessArchitecture {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET7_0_OR_GREATER
                return RuntimeInformation.ProcessArchitecture; // inline on net7.0 .
#else
                return _ProcessArchitecture;
#endif
            }
        }

#if NET5_0_OR_GREATER
#else
        private static readonly bool _ProcessIsX86Family = _ProcessArchitecture <= Architecture.X64;
#endif
        /// <summary>
        /// Gets a value that indicates whether the current process architecture is a X86 family (获取一个值，该值指示当前进程架构是否为 X86 家族的). e.g. X86, X64 .
        /// </summary>
        public static bool ProcessIsX86Family {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return System.Runtime.Intrinsics.X86.X86Base.IsSupported;
//#elif NETCOREAPP3_0_OR_GREATER
//                return RuntimeInformation.ProcessArchitecture <= Architecture.X64; // inline?.
#else
                return _ProcessIsX86Family;
#endif
            }
        }

#if NET5_0_OR_GREATER
#else
        private static readonly bool _ProcessIsArmFamily = (Architecture.Arm <= _ProcessArchitecture) && (_ProcessArchitecture <= Architecture.Arm64);
#endif
        /// <summary>
        /// Gets a value that indicates whether the current process architecture is a Arm family (获取一个值，该值指示当前进程架构是否为 Arm 家族的). e.g. Arm, Arm64, Armv6 .
        /// </summary>
        public static bool ProcessIsArmFamily {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return System.Runtime.Intrinsics.Arm.ArmBase.IsSupported;
#else
                return _ProcessIsArmFamily;
#endif
            }
        }

        /// <summary>The separator of the instruction set (指令集的分隔符).</summary>
        public static string InstructionSetsSeparator { get; } = ", ";

        /// <summary>Supported instruction sets. The separator is a comma char ',' (支持的指令集. 分隔符是逗号 ',').</summary>
        public static string SupportedInstructionSets { get; } = MakeSupportedInstructionSets();

        /// <summary>
        /// Make for supported instruction sets. The separator is a comma char ',' (构造支持的指令集信息. 分隔符是逗号 ',').
        /// </summary>
        /// <returns>Returns supported instruction sets string.</returns>
        private static string MakeSupportedInstructionSets() {
            string rt = "";
#if NETCOREAPP3_0_OR_GREATER
            string separator = InstructionSetsSeparator;
            // -- Arm --
#if NET5_0_OR_GREATER
            if (System.Runtime.Intrinsics.Arm.AdvSimd.IsSupported) rt += separator + "AdvSimd";
            if (System.Runtime.Intrinsics.Arm.Aes.IsSupported) rt += separator + "Aes";
            if (System.Runtime.Intrinsics.Arm.ArmBase.IsSupported) rt += separator + "ArmBase";
            if (System.Runtime.Intrinsics.Arm.Crc32.IsSupported) rt += separator + "Crc32";
            if (System.Runtime.Intrinsics.Arm.Dp.IsSupported) rt += separator + "Dp";
            if (System.Runtime.Intrinsics.Arm.Rdm.IsSupported) rt += separator + "Rdm";
            if (System.Runtime.Intrinsics.Arm.Sha1.IsSupported) rt += separator + "Sha1";
            if (System.Runtime.Intrinsics.Arm.Sha256.IsSupported) rt += separator + "Sha256";
#endif // NET5_0_OR_GREATER
            // -- X86 --
            if (System.Runtime.Intrinsics.X86.Aes.IsSupported) rt += separator + "Aes";
            if (System.Runtime.Intrinsics.X86.Avx.IsSupported) rt += separator + "Avx";
            if (System.Runtime.Intrinsics.X86.Avx2.IsSupported) rt += separator + "Avx2";
#if NET6_0_OR_GREATER
            // // Error	CA2252	Using 'IsSupported' requires opting into preview features. See https://aka.ms/dotnet-warnings/preview-features for more information.
            // if (System.Runtime.Intrinsics.X86.AvxVnni.IsSupported) rt += separator + "AvxVnni";
#endif // NET6_0_OR_GREATER
            if (System.Runtime.Intrinsics.X86.Bmi1.IsSupported) rt += separator + "Bmi1";
            if (System.Runtime.Intrinsics.X86.Bmi2.IsSupported) rt += separator + "Bmi2";
            if (System.Runtime.Intrinsics.X86.Fma.IsSupported) rt += separator + "Fma";
            if (System.Runtime.Intrinsics.X86.Lzcnt.IsSupported) rt += separator + "Lzcnt";
            if (System.Runtime.Intrinsics.X86.Pclmulqdq.IsSupported) rt += separator + "Pclmulqdq";
            if (System.Runtime.Intrinsics.X86.Popcnt.IsSupported) rt += separator + "Popcnt";
            if (System.Runtime.Intrinsics.X86.Sse.IsSupported) rt += separator + "Sse";
            if (System.Runtime.Intrinsics.X86.Sse2.IsSupported) rt += separator + "Sse2";
            if (System.Runtime.Intrinsics.X86.Sse3.IsSupported) rt += separator + "Sse3";
            if (System.Runtime.Intrinsics.X86.Sse41.IsSupported) rt += separator + "Sse41";
            if (System.Runtime.Intrinsics.X86.Sse42.IsSupported) rt += separator + "Sse42";
            if (System.Runtime.Intrinsics.X86.Ssse3.IsSupported) rt += separator + "Ssse3";
#if NET5_0_OR_GREATER
            if (System.Runtime.Intrinsics.X86.X86Base.IsSupported) rt += separator + "X86Base";
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
            if (System.Runtime.Intrinsics.X86.X86Serialize.IsSupported) rt += separator + "X86Serialize";
#endif // NET7_0_OR_GREATER
            // done.
            if (!string.IsNullOrEmpty(rt)) {
                rt = rt.Substring(separator.Length);
            }
#else
#endif // NETCOREAPP3_0_OR_GREATER
            return rt;
        }

        /// <inheritdoc cref="CpuDetectionHelper.CpuModelName"/>
        public static string CpuModelName {
            get {
                return CpuDetectionHelper.Instance.CpuModelName;
            }
        }

        /// <inheritdoc cref="CpuDetectionHelper.CpuFlags"/>
        public static string CpuFlags {
            get {
                return CpuDetectionHelper.Instance.CpuFlags;
            }
        }

        /// <inheritdoc cref="CpuDetectionHelper.CpuDetectionCommand"/>
        public static string CpuDetectionCommand {
            get {
                return CpuDetectionHelper.Instance.CpuDetectionCommand;
            }
        }

        /// <inheritdoc cref="CpuDetectionHelper.CpuDetectionException"/>
        public static Exception? CpuDetectionException {
            get {
                return CpuDetectionHelper.Instance.CpuDetectionException;
            }
        }

        /// <inheritdoc cref="CpuDetectionHelper.CpuDetectionResult"/>
        public static IReadOnlyList<string>? CpuDetectionResult {
            get {
                return CpuDetectionHelper.Instance.CpuDetectionResult;
            }
        }

    }
}
