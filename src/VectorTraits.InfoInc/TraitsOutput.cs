using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits {
#nullable enable

    /// <summary>
    /// VectorTraits output info.
    /// </summary>
    internal partial class TraitsOutput {
        /// <summary>Wait debug prefix.</summary>
        public static readonly string WaitDebugPrefix = "-waitdebug";
        /// <summary>Wait debug hint.</summary>
        public static readonly string WaitDebugHint = "(Press Any Key to Continue)";
        /// <summary>Wait debug default timeout. Unit is milliseconds.</summary>
        public const int WaitDebugTimeoutDefault = 10 * 60 * 1000;
        /// <summary>Wait debug has.</summary>
        public static bool WaitDebug { get; set; }
        /// <summary>Wait debug timeout. Unit is milliseconds.</summary>
        public static int WaitDebugTimeout { get; set; }

        /// <summary>
        /// Is release make.
        /// </summary>
        public static readonly bool IsRelease =
#if DEBUG
            false
#else
            true
#endif
        ;

        /// <summary>
        /// Output Environment.
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        public static void OutputEnvironment(TextWriter writer, string? indent = null) {
            if (null == writer) return;
            if (null == indent) indent = "";
            //string indentNext = indent + "\t";
            // VectorTraitsGlobal
            VectorTraitsGlobal.Init();
#if NETSTANDARD1_3_OR_GREATER || NETCOREAPP2_0_OR_GREATER || NET461_OR_GREATER
            // No need to set up `ProcessUtil.TypeOfProcess` properties. 
#else
            Zyl.VectorTraits.Impl.Util.ProcessUtil.TypeOfProcess = typeof(System.Diagnostics.Process);
#endif

            writer.WriteLine(indent + string.Format("IsRelease:\t{0}", IsRelease));
            writer.WriteLine(indent + string.Format("Environment.ProcessorCount:\t{0}", Environment.ProcessorCount));
            //writer.WriteLine(indent + string.Format("Environment.Is64BitOperatingSystem:\t{0}", Environment.Is64BitOperatingSystem));
            writer.WriteLine(indent + string.Format("Environment.Is64BitProcess:\t{0}", Environment.Is64BitProcess));
            writer.WriteLine(indent + string.Format("Environment.OSVersion:\t{0}", Environment.OSVersion)); // Same RuntimeInformation.OSDescription. .Net framework does not recognize Windows 10 .
            writer.WriteLine(indent + string.Format("Environment.Version:\t{0}", Environment.Version));
            writer.WriteLine(indent + string.Format("Stopwatch.Frequency:\t{0}", Stopwatch.Frequency));
#if NETCOREAPP3_0_OR_GREATER
            writer.WriteLine(indent + string.Format("RuntimeFeature.IsDynamicCodeCompiled:\t{0}", RuntimeFeature.IsDynamicCodeCompiled));
            writer.WriteLine(indent + string.Format("RuntimeFeature.IsDynamicCodeSupported:\t{0}", RuntimeFeature.IsDynamicCodeSupported));
#endif // NETCOREAPP3_0_OR_GREATER
            //writer.WriteLine(indent + string.Format("RuntimeEnvironment.GetSystemVersion:\t{0}", System.Runtime.InteropServices.RuntimeEnvironment.GetSystemVersion())); // Same Environment.Version
            writer.WriteLine(indent + string.Format("RuntimeEnvironment.GetRuntimeDirectory:\t{0}", System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory()));
#if (NET47 || NET462 || NET461 || NET46 || NET452 || NET451 || NET45 || NET40 || NET35 || NET20) || (NETSTANDARD1_0)
#else
            writer.WriteLine(indent + string.Format("RuntimeInformation.FrameworkDescription:\t{0}", System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription));
            writer.WriteLine(indent + string.Format("RuntimeInformation.OSArchitecture:\t{0}", System.Runtime.InteropServices.RuntimeInformation.OSArchitecture));
            writer.WriteLine(indent + string.Format("RuntimeInformation.OSDescription:\t{0}", System.Runtime.InteropServices.RuntimeInformation.OSDescription)); // Same Environment.OSVersion. It's more accurate.
            //writer.WriteLine(indent + string.Format("RuntimeInformation.ProcessArchitecture:\t{0}", System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)); Same OSArchitecture.
#endif
#if NET5_0_OR_GREATER
            writer.WriteLine(indent + string.Format("RuntimeInformation.RuntimeIdentifier:\t{0}", System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier)); // e.g. win10-x64
#endif // NET5_0_OR_GREATER
#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD1_6_OR_GREATER || NET471_OR_GREATER
            // writer.WriteLine(indent + string.Format("RUNTIME_IDENTIFIER:\t{0}", AppContext.GetData("RUNTIME_IDENTIFIER"))); // Need NET5_0+
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD1_6_OR_GREATER || NET471_OR_GREATER
            writer.WriteLine(indent + string.Format("IntPtr.Size:\t{0}", IntPtr.Size));
            writer.WriteLine(indent + string.Format("BitConverter.IsLittleEndian:\t{0}", BitConverter.IsLittleEndian));
            writer.WriteLine(indent + string.Format("Vector.IsHardwareAccelerated:\t{0}", Vector.IsHardwareAccelerated));
            writer.WriteLine(indent + string.Format("Vector<byte>.Count:\t{0}\t# {1}bit", Vector<byte>.Count, Vector<byte>.Count * sizeof(byte) * 8));
            writer.WriteLine(indent + string.Format("Vector<float>.Count:\t{0}\t# {1}bit", Vector<float>.Count, Vector<float>.Count * sizeof(float) * 8));
            //writer.WriteLine(indent + string.Format("Vector<double>.Count:\t{0}\t# {1}bit", Vector<double>.Count, Vector<double>.Count * sizeof(double) * 8));
#if NET7_0_OR_GREATER
            writer.WriteLine(indent + string.Format("Vector128.IsHardwareAccelerated:\t{0}", Vector128.IsHardwareAccelerated));
            writer.WriteLine(indent + string.Format("Vector256.IsHardwareAccelerated:\t{0}", Vector256.IsHardwareAccelerated));
#endif // NET7_0_OR_GREATER
#if NET8_0_OR_GREATER
            writer.WriteLine(indent + string.Format("Vector512.IsHardwareAccelerated:\t{0}", Vector512.IsHardwareAccelerated));
#endif // NET8_0_OR_GREATER

            // Assembly
#pragma warning disable SYSLIB0012 // Type or member is obsolete
            Assembly assembly;
            //assembly = typeof(Vector4).GetTypeInfo().Assembly;
            //writer.WriteLine(string.Format("Vector4.Assembly:\t{0}", assembly));
            //writer.WriteLine(string.Format("Vector4.Assembly.CodeBase:\t{0}", assembly.CodeBase));
            assembly = typeof(Vector<float>).GetTypeInfo().Assembly;
            string? codeBase;
            try {
                codeBase = GetCodeBase(assembly);
            } catch (Exception ex) {
                codeBase = ex.Message;
            }
            writer.WriteLine(string.Format("Vector<T>.Assembly.CodeBase:\t{0}", codeBase));
            //assembly = typeof(Vector128<float>).GetTypeInfo().Assembly;
            //writer.WriteLine(string.Format("Vector128<T>.Assembly.CodeBase:\t{0}", assembly.CodeBase));
#if (NET35 || NET20)
#else
            writer.WriteLine(indent + string.Format("GetTargetFrameworkDisplayName(VectorTextUtil):\t{0}", VectorTextUtil.GetTargetFrameworkDisplayName(typeof(VectorTextUtil).Assembly)));
            writer.WriteLine(indent + string.Format("GetTargetFrameworkDisplayName(TraitsOutput):\t{0}", VectorTextUtil.GetTargetFrameworkDisplayName(typeof(TraitsOutput).Assembly)));
#endif
#pragma warning restore SYSLIB0012 // Type or member is obsolete

            writer.WriteLine(indent + string.Format("VectorTraitsGlobal.InitCheckSum:\t{0}\t# 0x{0:X8}", VectorTraitsGlobal.InitCheckSum));
            writer.WriteLine(indent + string.Format("VectorEnvironment.CpuModelName:\t{0}", VectorEnvironment.CpuModelName));
            if (!string.IsNullOrEmpty(VectorEnvironment.CpuFlags)) {
                writer.WriteLine(indent + string.Format("VectorEnvironment.CpuFlags:\t{0}", VectorEnvironment.CpuFlags));
            }
            writer.WriteLine(indent + string.Format("VectorEnvironment.SupportedInstructionSets:\t{0}", VectorEnvironment.SupportedInstructionSets));
#if NETCOREAPP3_0_OR_GREATER
            writer.WriteLine(indent + string.Format("Vector128s.Instance:\t{0}\t// {1}", Vector128s.Instance.GetType().Name, Vector128s.Instance.UsedInstructionSets));
            bool flag;
#if NET7_0_OR_GREATER
            flag = Vector256.IsHardwareAccelerated;
#else
            flag = Vector<byte>.Count >= Vector256<byte>.Count;
#endif // NET7_0_OR_GREATER
            if (Vector<byte>.Count >= Vector256<byte>.Count) {
                writer.WriteLine(indent + string.Format("Vector256s.Instance:\t{0}\t// {1}", Vector256s.Instance.GetType().Name, Vector256s.Instance.UsedInstructionSets));
            }
#endif // NETCOREAPP3_0_OR_GREATER
#if NET8_0_OR_GREATER
            if (Vector512.IsHardwareAccelerated) {
                writer.WriteLine(indent + string.Format("Vector512s.Instance:\t{0}\t// {1}", Vector512s.Instance.GetType().Name, Vector512s.Instance.UsedInstructionSets));
            }
#endif // NET8_0_OR_GREATER
            writer.WriteLine(indent + string.Format("Vectors.Instance:\t{0}\t// {1}", Vectors.Instance.GetType().Name, Vectors.Instance.UsedInstructionSets));
            //writer.WriteLine();
        }

        /// <summary>
        /// Get CodeBase.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <returns>Returns CodeBase.</returns>
#if NET5_0_OR_GREATER
        [UnconditionalSuppressMessage("SingleFile", "IL3002:Avoid calling members marked with 'RequiresAssemblyFilesAttribute' when publishing as a single-file", Justification = "Try catch")]
#endif // NET5_0_OR_GREATER
        private static string? GetCodeBase(Assembly assembly) {
#pragma warning disable SYSLIB0012 // Type or member is obsolete
            return assembly.CodeBase;
#pragma warning restore SYSLIB0012 // Type or member is obsolete
        }

        /// <summary>
        /// Parse <see cref="WaitDebug"/> by <paramref name="args"/>, and <see cref="Console.ReadKey"/> with timeout (从 <paramref name="args"/> 解析出 <see cref="WaitDebug"/> 参数, 并以超时方式运行 <see cref="Console.ReadKey"/> ).
        /// </summary>
        /// <param name="args">The command args (命令行参数).</param>
        /// <param name="hint">A hint of waiting (等待时的提示). null is <see cref="WaitDebugHint"/> </param>
        /// <param name="defaultTimout">Default timeout (默认超时). Unit is milliseconds (单位为毫秒). 0 is <see cref="WaitDebugTimeoutDefault"/></param>
        /// <param name="onParseDone">On parse done (当解析完毕时触发). Prototype: `void onParseDone(bool WaitDebug, int WaitDebugTimeout)`.</param>
        /// <returns>Returns ConsoleKeyInfo if a key is received, or null otherwise (若收到按键便返回 ConsoleKeyInfo, 否则返回null)</returns>
        public static ConsoleKeyInfo? ParseWaitDebugAndReadKey(string[] args, string? hint = null, int defaultTimout = 0, Action<bool, int>? onParseDone = null) {
            ConsoleKeyInfo? rt = null;
            WaitDebug = VectorTextUtil.TryParseArgsByPrefix(out int timeout, args, WaitDebugPrefix, defaultTimout);
            if (WaitDebug) {
                WaitDebugTimeout = timeout;
            }
            onParseDone?.Invoke(WaitDebug, timeout);
            if (WaitDebug) {
                if (null == hint) hint = WaitDebugHint;
                if (!string.IsNullOrEmpty(hint)) {
                    Console.WriteLine(hint);
                }
                rt = WaitDebugReadKey();
            }
            return rt;
        }

        /// <summary>
        /// WaitDebug - <see cref="Console.ReadKey"/> with timeout (以超时方式运行 <see cref="Console.ReadKey"/> ).
        /// </summary>
        /// <param name="intercept">Determines whether to display the pressed key in the console window. true to not display the pressed key; otherwise, false (确定是否在控制台窗口中显示按下的键。 如果为 true，则不显示按下的键；否则为 false).</param>
        /// <returns>Returns ConsoleKeyInfo if a key is received, or null otherwise (若收到按键便返回 ConsoleKeyInfo, 否则返回null)</returns>
        public static ConsoleKeyInfo? WaitDebugReadKey(bool intercept = false) {
            int timeout = WaitDebugTimeout;
            if (0 == timeout) timeout = WaitDebugTimeoutDefault;
            return ReadKeyTimeout(timeout, intercept);
        }

        /// <summary>
        /// WaitDebug - <see cref="Console.ReadKey"/> with timeout (以超时方式运行 <see cref="Console.ReadKey"/> ).
        /// </summary>
        /// <param name="timeout">Timeout milliseconds (超时毫秒数). When it is negative, no timeout control is performed (当它为负数时, 不进行超时控制).</param>
        /// <param name="intercept">Determines whether to display the pressed key in the console window. true to not display the pressed key; otherwise, false (确定是否在控制台窗口中显示按下的键。 如果为 true，则不显示按下的键；否则为 false).</param>
        /// <returns>Returns ConsoleKeyInfo if a key is received, or null otherwise (若收到按键便返回 ConsoleKeyInfo, 否则返回null)</returns>
        /// <exception cref="InvalidOperationException">The <see cref="Console.In"/> property is redirected from some stream other than the console.</exception>
        public static ConsoleKeyInfo? ReadKeyTimeout(int timeout, bool intercept = false) {
            if (timeout >= 0) {
                int tickBegin = Environment.TickCount;
                int used;
                bool isAvailable;
                do {
                    isAvailable = Console.KeyAvailable;
                    if (isAvailable) break;
                    used = Environment.TickCount - tickBegin;
                }while(used <= timeout);
                if (!isAvailable) return null;
            }
#pragma warning disable CA1416
            return Console.ReadKey(intercept);
#pragma warning restore CA1416
        }
    }

#nullable restore
}
