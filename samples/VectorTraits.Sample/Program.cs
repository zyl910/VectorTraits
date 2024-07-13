#nullable enable

using System;
using System.IO;
using System.Numerics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Sample {
    class Program {
        private static readonly TextWriter writer = Console.Out;
        static void Main(string[] args) {
            writer.WriteLine("VectorTraits.Sample");
            writer.WriteLine();
            VectorTraitsGlobal.Init(); // Initialization (初始化).
            TraitsOutput.OutputEnvironment(writer); // Output environment info. It depends on `VectorTraits.InfoInc`. This row can be deleted when only VectorTraits are used (输出环境信息. 它依赖 `VectorTraits.InfoInc`. 当仅使用 VectorTraits 时, 可以删除本行).
            writer.WriteLine();

            // -- Start --
            Vector<short> src = Vectors.CreateRotate<short>(0, 1, 2, 3, 4, 5, 6, 7); // The `Vectors` class provides some methods. For example, 'CreateRotate' is rotate fill (`Vectors` 类提供了许多方法. 例如 `CreateRotate` 是旋转填充).
            VectorTextUtil.WriteLine(writer, "src:\t{0}", src); // It can not only format the string, but also display the hexadecimal of each element in the vector on the right Easy to view vector data (它不仅能格式化字符串, 且会在右侧显示向量中各元素的十六进制. 便于查看向量数据).

            // ShiftLeft. It is a new vector method in `.NET 7.0` (左移位. 它是 `.NET 7.0` 新增的向量方法)
            const int shiftAmount = 1;
            Vector<short> shifted = Vectors.ShiftLeft(src, shiftAmount); // shifted[i] = src[i] << shiftAmount.
            VectorTextUtil.WriteLine(writer, "ShiftLeft:\t{0}", shifted);
#if NET7_0_OR_GREATER
            // Compare BCL function (与BCL的函数做对比).
            Vector<short> shiftedBCL = Vector.ShiftLeft(src, shiftAmount);
            VectorTextUtil.WriteLine(writer, "Equals to BCL ShiftLeft:\t{0}", shifted.Equals(shiftedBCL));
#endif
            // ShiftLeft_Const
            VectorTextUtil.WriteLine(writer, "Equals to ShiftLeft_Const:\t{0}", shifted.Equals(Vectors.ShiftLeft_Const(src, shiftAmount))); // If the parameter shiftAmount is a constant, you can also use the Vectors' ShiftLeft_Const method. It is faster in many scenarios (若参数 shiftAmount 是常数, 还可以使用 Vectors 的 ShiftLeft_Const 方法. 它在不少场景下更快).
            writer.WriteLine();

            // Shuffle. It is a new vector method in `.NET 7.0` (换位. 它是 `.NET 7.0` 新增的向量方法)
            Vector<short> desc = Vectors<short>.SerialDesc; // The generic structure 'Vectors<T>' provides fields for commonly used constants. For example, 'SerialDesc' is a descending order value (泛型结构体 `Vectors<T>` 为常用常数提供了字段. 例如 `SerialDesc` 是降序的顺序值).
            VectorTextUtil.WriteLine(writer, "desc:\t{0}", desc);
            Vector<short> dst = Vectors.Shuffle(shifted, desc); // dst[i] = shifted[desc[i]].
            VectorTextUtil.WriteLine(writer, "Shuffle:\t{0}", dst);
#if NET7_0_OR_GREATER
            // Compare BCL function (与BCL的函数做对比). 
            Vector<short> dstBCL = default; // Since `.NET 7.0`, the Shuffle method has been provided in Vector128/Vector256, but the Shuffle method has not yet been provided in Vector (自 `.NET 7.0` 开始, Vector128/Vector256 里提供了 Shuffle 方法, 但 Vector 里尚未提供 Shuffle 方法).
            if (Vector<short>.Count == Vector128<short>.Count) {
                dstBCL = Vector128.Shuffle(shifted.AsVector128(), desc.AsVector128()).AsVector();
            } else if (Vector<short>.Count == Vector256<short>.Count) {
                dstBCL = Vector256.Shuffle(shifted.AsVector256(), desc.AsVector256()).AsVector();
            }
            VectorTextUtil.WriteLine(writer, "Equals to BCL Shuffle:\t{0}", dst.Equals(dstBCL));
#endif
            // Shuffle_Args and Shuffle_Core
            Vectors.Shuffle_Args(desc, out var args0, out var args1); // The suffix is the `Args' method used for parameter calculation, which involves processing such as parameter transformation in advance It is suitable for external loop (后缀是 `Args` 的方法, 用于参数计算, 即提前进行参数变换等处理. 它适合放在外循环).
            Vector<short> dst2 = Vectors.Shuffle_Core(shifted, args0, args1); // The suffix is the `Core` method used for core calculations, which calculates based on cached parameters It is suitable for internal loop to improve performance (后缀是 `Core` 方法, 用于核心计算, 既根据已缓存的参数进行计算. 它适合放在内循环, 便于改善性能).
            VectorTextUtil.WriteLine(writer, "Equals to Shuffle_Core:\t{0}", dst.Equals(dst2));
            writer.WriteLine();

            // Show AcceleratedTypes.
            VectorTextUtil.WriteLine(writer, "ShiftLeft_AcceleratedTypes:\t{0}", Vectors.ShiftLeft_AcceleratedTypes);
            VectorTextUtil.WriteLine(writer, "Shuffle_AcceleratedTypes:\t{0}", Vectors.Shuffle_AcceleratedTypes);
            writer.WriteLine();

            // ExTypes.
            ShowExTypes();
            ShowYGroup2Zip();

            // Show cpu info.
            ShowCpuInfo();
        }

        /// <summary>
        /// Show ExTypes.
        /// </summary>
        private static void ShowExTypes() {
            writer.WriteLine("[ExTypes]");
            var src = Vectors<long>.Serial;
            var temp = src.ExAsExInt128();
            VectorTextUtil.WriteLine(writer, "Source:\t{0}", src);
            VectorTextUtil.WriteLine(writer, "ExAsExInt128:\t{0}", temp);
            // InterpolatedString.
            // Bug! - writer.WriteLine($"InterpolatedString:\t{temp}."); // System.NotSupportedException: Specified type is not supported
#if NETCOREAPP1_0_OR_GREATER || NET461_OR_GREATER
            writer.WriteLine(ExVectorUtil.ToString($"InterpolatedString:\t{temp}."));
#endif
#if NETCOREAPP1_0_OR_GREATER || NET46_OR_GREATER || NETSTANDARD1_3_OR_GREATER
            writer.WriteLine(ToString($"this-InterpolatedString:\t{temp}."));
#endif
            writer.WriteLine();
            // Output of 256-bit vectors on X86 architecture:
            // Source: <0, 1, 2, 3>    # (0000000000000000 0000000000000001 0000000000000002 0000000000000003)
            // ExAsExInt128:   <18446744073709551616, 55340232221128654850>    # (00000000000000010000000000000000 00000000000000030000000000000002)
            // InterpolatedString:     <18446744073709551616, 55340232221128654850>.
            // this-InterpolatedString:        <18446744073709551616, 55340232221128654850>.
        }

        /// <summary>
        /// Show YGroup2Zip.
        /// </summary>
        private static void ShowYGroup2Zip() {
            writer.WriteLine("[YGroup2Zip]");
#if NETCOREAPP3_0_OR_GREATER
            // Int64
            var a0 = Vector256s.CreateByDoubleLoop<long>(0, 2);
            var a1 = Vector256s.CreateByDoubleLoop<long>(1, 2);
            var s0 = Vector256s.YGroup2Zip(a0, a1, out var s1);
            var t0 = Vector256s.YGroup2Unzip(s0, s1, out var t1);
            VectorTextUtil.WriteLine(writer, "Before      :\t{0}, {1}", a0, a1);
            VectorTextUtil.WriteLine(writer, "YGroup2Zip  :\t{0}, {1}", s0, s1);
            VectorTextUtil.WriteLine(writer, "YGroup2Unzip:\t{0}, {1}", t0, t1);
            // Int128
            var b0 = a0.ExAsExInt128();
            var b1 = a1.ExAsExInt128();
            var c0 = Vector256s.YGroup2Zip(b0, b1, out var c1);
            var d0 = c0.ExAsInt64();
            var d1 = c1.ExAsInt64();
            VectorTextUtil.WriteLine(writer, "ExAsExInt128:\t{0}, {1}", b0, b1);
            VectorTextUtil.WriteLine(writer, "YGroup2Zip  :\t{0}, {1}", c0, c1);
            VectorTextUtil.WriteLine(writer, "ExAsInt64   :\t{0}, {1}", d0, d1);
#endif // NETCOREAPP3_0_OR_GREATER
            writer.WriteLine();
            // Output of 256-bit vectors on X86 architecture:
            // Before      :   <0, 2, 4, 6>, <1, 3, 5, 7>      # (0000000000000000 0000000000000002 0000000000000004 0000000000000006), (0000000000000001 0000000000000003 0000000000000005 0000000000000007)
            // YGroup2Zip  :   <0, 1, 2, 3>, <4, 5, 6, 7>      # (0000000000000000 0000000000000001 0000000000000002 0000000000000003), (0000000000000004 0000000000000005 0000000000000006 0000000000000007)
            // YGroup2Unzip:   <0, 2, 4, 6>, <1, 3, 5, 7>      # (0000000000000000 0000000000000002 0000000000000004 0000000000000006), (0000000000000001 0000000000000003 0000000000000005 0000000000000007)
            // ExAsExInt128:   <36893488147419103232, 110680464442257309700>, <55340232221128654849, 129127208515966861317>    # (00000000000000020000000000000000 00000000000000060000000000000004), (00000000000000030000000000000001 00000000000000070000000000000005)
            // YGroup2Zip  :   <36893488147419103232, 55340232221128654849>, <110680464442257309700, 129127208515966861317>    # (00000000000000020000000000000000 00000000000000030000000000000001), (00000000000000060000000000000004 00000000000000070000000000000005)
            // ExAsInt64   :   <0, 2, 1, 3>, <4, 6, 5, 7>      # (0000000000000000 0000000000000002 0000000000000001 0000000000000003), (0000000000000004 0000000000000006 0000000000000005 0000000000000007)
        }

        /// <summary>
        /// Show CpuInfo.
        /// </summary>
        private static void ShowCpuInfo() {
            writer.WriteLine("[CpuInfo]");
            writer.WriteLine("CpuModelName: {0}", VectorEnvironment.CpuModelName);
            writer.WriteLine("CpuFlags: {0}", VectorEnvironment.CpuFlags);
            writer.WriteLine("CpuDetectionException: {0}", VectorEnvironment.CpuDetectionException);
            writer.WriteLine("CpuDetectionCommand: {0}", VectorEnvironment.CpuDetectionCommand);
            writer.Write("CpuDetectionResult:\t");
            VectorTextUtil.WriteLines(writer, VectorEnvironment.CpuDetectionResult);
            writer.WriteLine();
        }

#if NETCOREAPP1_0_OR_GREATER || NET46_OR_GREATER || NETSTANDARD1_3_OR_GREATER
        // FormattableString: .NET Core 1.0+, .NET Framework 4.6+, .NET Standard 1.3+
        public static string ToString(FormattableString message) {
            return message.ToString(ExVectorFormatter.Instance);
        }
#endif

#if NETCOREAPP3_0_OR_GREATER
        public static Vector256<ExInt128> YGroup2Zip(Vector256<ExInt128> x, Vector256<ExInt128> y, out Vector256<ExInt128> data1) {
            VectorMessageFormats.ThrowForUnsupported(Avx.IsSupported, "Avx");
            // Unhandled exception. System.NotSupportedException: Specified type is not supported //var d0 = Avx.Permute2x128(x.AsUInt64(), y.AsUInt64(), (byte)ShuffleControl2X4Use4.XZ);
            var d0 = Avx.Permute2x128(x.ExAsUInt64(), y.ExAsUInt64(), (byte)ShuffleControl2X4Use4.XZ);
            var d1 = Avx.Permute2x128(x.ExAsUInt64(), y.ExAsUInt64(), (byte)ShuffleControl2X4Use4.YW);
            data1 = d1.ExAsExInt128();
            return d0.ExAsExInt128();
        }
#endif
    }

}
