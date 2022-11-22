using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace Zyl.VectorTraits {
    /// <summary>
    /// VectorTraits output info.
    /// </summary>
    internal partial class TraitsOutput {

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
            writer.WriteLine(indent + string.Format("IsRelease:\t{0}", IsRelease));
            writer.WriteLine(indent + string.Format("EnvironmentVariable(PROCESSOR_IDENTIFIER):\t{0}", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")));
            writer.WriteLine(indent + string.Format("Environment.ProcessorCount:\t{0}", Environment.ProcessorCount));
            //writer.WriteLine(indent + string.Format("Environment.Is64BitOperatingSystem:\t{0}", Environment.Is64BitOperatingSystem));
            writer.WriteLine(indent + string.Format("Environment.Is64BitProcess:\t{0}", Environment.Is64BitProcess));
            writer.WriteLine(indent + string.Format("Environment.OSVersion:\t{0}", Environment.OSVersion));
            writer.WriteLine(indent + string.Format("Environment.Version:\t{0}", Environment.Version));
            //writer.WriteLine(indent + string.Format("RuntimeEnvironment.GetSystemVersion:\t{0}", System.Runtime.InteropServices.RuntimeEnvironment.GetSystemVersion())); // Same Environment.Version
            writer.WriteLine(indent + string.Format("RuntimeEnvironment.GetRuntimeDirectory:\t{0}", System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory()));
#if (NET47 || NET462 || NET461 || NET46 || NET452 || NET451 || NET45 || NET40 || NET35 || NET20) || (NETSTANDARD1_0)
#else
            writer.WriteLine(indent + string.Format("RuntimeInformation.FrameworkDescription:\t{0}", System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription));
            writer.WriteLine(indent + string.Format("RuntimeInformation.OSArchitecture:\t{0}", System.Runtime.InteropServices.RuntimeInformation.OSArchitecture));
#endif
            writer.WriteLine(indent + string.Format("IntPtr.Size:\t{0}", IntPtr.Size));
            writer.WriteLine(indent + string.Format("BitConverter.IsLittleEndian:\t{0}", BitConverter.IsLittleEndian));
            writer.WriteLine(indent + string.Format("Vector.IsHardwareAccelerated:\t{0}", Vector.IsHardwareAccelerated));
            writer.WriteLine(indent + string.Format("Vector<byte>.Count:\t{0}\t# {1}bit", Vector<byte>.Count, Vector<byte>.Count * sizeof(byte) * 8));
            writer.WriteLine(indent + string.Format("Vector<float>.Count:\t{0}\t# {1}bit", Vector<float>.Count, Vector<float>.Count * sizeof(float) * 8));
            //writer.WriteLine(indent + string.Format("Vector<double>.Count:\t{0}\t# {1}bit", Vector<double>.Count, Vector<double>.Count * sizeof(double) * 8));
#pragma warning disable SYSLIB0012 // Type or member is obsolete
            Assembly assembly;
            //assembly = typeof(Vector4).GetTypeInfo().Assembly;
            //writer.WriteLine(string.Format("Vector4.Assembly:\t{0}", assembly));
            //writer.WriteLine(string.Format("Vector4.Assembly.CodeBase:\t{0}", assembly.CodeBase));
            assembly = typeof(Vector<float>).GetTypeInfo().Assembly;
            writer.WriteLine(string.Format("Vector<T>.Assembly.CodeBase:\t{0}", assembly.CodeBase));
            //assembly = typeof(Vector128<float>).GetTypeInfo().Assembly;
            //writer.WriteLine(string.Format("Vector128<T>.Assembly.CodeBase:\t{0}", assembly.CodeBase));
#if (NET35 || NET20)
#else
            writer.WriteLine(indent + string.Format("GetTargetFrameworkDisplayName(TraitsUtil):\t{0}", TraitsUtil.GetTargetFrameworkDisplayName(typeof(TraitsUtil).Assembly)));
            writer.WriteLine(indent + string.Format("GetTargetFrameworkDisplayName(TraitsOutput):\t{0}", TraitsUtil.GetTargetFrameworkDisplayName(typeof(TraitsOutput).Assembly)));
#endif
#pragma warning restore SYSLIB0012 // Type or member is obsolete

            //writer.WriteLine();
        }

    }
}
