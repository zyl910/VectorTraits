#nullable enable

using System;
using System.IO;
using System.Numerics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Sample {
    class Program {
        static void Main(string[] args) {
            TextWriter writer = Console.Out;

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
            ShowExTypes(writer);
            ShowYGroup2Zip(writer);

            // Unzip.
            ShowYGroup3Unzip(writer);

            // Show cpu info.
            ShowCpuInfo(writer);
        }

        /// <summary>
        /// Show ExTypes.
        /// </summary>
        private static void ShowExTypes(TextWriter writer) {
            writer.WriteLine("[ExTypes]");
            // -- Create (创建) --
            //Vector<ExInt128> temp = new Vector<ExInt128>((ExInt128)0x102); // System.NotSupportedException: Specified type is not supported
            Vector<ExInt128> temp = Vectors.Create((ExInt128)0x102);

            // -- ToString (转字符串) --
            //writer.WriteLine("ToString:\t" + temp.ToString()); // System.NotSupportedException: Specified type is not supported
            //writer.WriteLine(string.Format("Format:\t{0}", temp)); // System.NotSupportedException: Specified type is not supported
            //writer.WriteLine($"InterpolatedString:\t{temp}."); // System.NotSupportedException: Specified type is not supported
            writer.WriteLine("ToString:\t" + ExVectorUtil.Format(temp));
            writer.WriteLine(ExVectorUtil.Format("Format:\t{0}", temp));
#if NETCOREAPP1_0_OR_GREATER || NET461_OR_GREATER
            writer.WriteLine(ExVectorUtil.ToString($"InterpolatedString:\t{temp}."));
#endif
            VectorTextUtil.WriteLine(writer, "ValueWithHex:\t{0}", temp);

            // -- Property (属性) --
            //VectorTextUtil.WriteLine(writer, "Count:\t{0}", Vector<ExInt128>.Count); // System.NotSupportedException: Specified type is not supported
            //VectorTextUtil.WriteLine(writer, "Zero:\t{0}", Vector<ExInt128>.Zero); // System.NotSupportedException: Specified type is not supported
            VectorTextUtil.WriteLine(writer, "Count:\t{0}", Vectors<ExInt128>.Count);
            VectorTextUtil.WriteLine(writer, "Zero:\t{0}", Vectors<ExInt128>.Zero);

            // -- Equals (相等) --
            //VectorTextUtil.WriteLine(writer, "Equals zero:\t{0}", Vectors<ExInt128>.Zero.Equals(temp)); // System.NotSupportedException: Specified type is not supported
            VectorTextUtil.WriteLine(writer, "Equals zero:\t{0}", Vectors<ExInt128>.Zero.BitEquals(temp));

            // -- Reinterprets (重新解释) --
            VectorTextUtil.WriteLine(writer, "ExAsInt64:\t{0}", temp.ExAsInt64());

            // -- Done --
            writer.WriteLine();
            // Output of 256-bit vectors on X86 architecture:
            // ToString:       <258, 258>
            // Format: <258, 258>
            // InterpolatedString:     <258, 258>.
            // ValueWithHex:   <258, 258>      # (00000000000000000000000000000102 00000000000000000000000000000102)
            // Count:  2       # (2)
            // Zero:   <0, 0>  # (00000000000000000000000000000000 00000000000000000000000000000000)
            // Equals zero:    False
            // ExAsInt64:      <258, 0, 258, 0>        # (0000000000000102 0000000000000000 0000000000000102 0000000000000000)
        }

        /// <summary>
        /// Show YGroup2Zip.
        /// </summary>
        private static void ShowYGroup2Zip(TextWriter writer) {
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
        /// Show YGroup3Unzip.
        /// </summary>
        private static void ShowYGroup3Unzip(TextWriter writer) {
            writer.WriteLine("[YGroup3Unzip]");
            // Byte
            int cnt = Vector<byte>.Count;
            var a0 = Vectors.CreateByDoubleLoop<byte>(0, 1);
            var a1 = Vectors.CreateByDoubleLoop<byte>(cnt * 1, 1);
            var a2 = Vectors.CreateByDoubleLoop<byte>(cnt * 2, 1);
            var s0 = Vectors.YGroup3Unzip(a0, a1, a2, out var s1, out var s2);
            var t0 = Vectors.YGroup3Zip(s0, s1, s2, out var t1, out var t2);
            VectorTextUtil.WriteLine(writer, "Before      :\t{0}, {1}, {2}", a0, a1, a2);
            VectorTextUtil.WriteLine(writer, "YGroup3Unzip:\t{0}, {1}, {2}", s0, s1, s2);
            VectorTextUtil.WriteLine(writer, "YGroup3Zip  :\t{0}, {1}, {2}", t0, t1, t2);
            writer.WriteLine();
            // Output of 256-bit vectors on X86 architecture:
            // [YGroup3Unzip]
            // Before      :   <0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31>, <32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63>, <64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95>      # (00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10 11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F), (20 21 22 23 24 25 26 27 28 29 2A 2B 2C 2D 2E 2F 30 31 32 33 34 35 36 37 38 39 3A 3B 3C 3D 3E 3F), (40 41 42 43 44 45 46 47 48 49 4A 4B 4C 4D 4E 4F 50 51 52 53 54 55 56 57 58 59 5A 5B 5C 5D 5E 5F)
            // YGroup3Unzip:   <0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93>, <1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94>, <2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92, 95>      # (00 03 06 09 0C 0F 12 15 18 1B 1E 21 24 27 2A 2D 30 33 36 39 3C 3F 42 45 48 4B 4E 51 54 57 5A 5D), (01 04 07 0A 0D 10 13 16 19 1C 1F 22 25 28 2B 2E 31 34 37 3A 3D 40 43 46 49 4C 4F 52 55 58 5B 5E), (02 05 08 0B 0E 11 14 17 1A 1D 20 23 26 29 2C 2F 32 35 38 3B 3E 41 44 47 4A 4D 50 53 56 59 5C 5F)
            // YGroup3Zip  :   <0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31>, <32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63>, <64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95>      # (00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10 11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F), (20 21 22 23 24 25 26 27 28 29 2A 2B 2C 2D 2E 2F 30 31 32 33 34 35 36 37 38 39 3A 3B 3C 3D 3E 3F), (40 41 42 43 44 45 46 47 48 49 4A 4B 4C 4D 4E 4F 50 51 52 53 54 55 56 57 58 59 5A 5B 5C 5D 5E 5F)
        }

        /// <summary>
        /// Show CpuInfo.
        /// </summary>
        private static void ShowCpuInfo(TextWriter writer) {
            writer.WriteLine("[CpuInfo]");
            writer.WriteLine("CpuModelName: {0}", VectorEnvironment.CpuModelName);
            writer.WriteLine("CpuFlags: {0}", VectorEnvironment.CpuFlags);
            writer.WriteLine("CpuDetectionException: {0}", VectorEnvironment.CpuDetectionException);
            writer.WriteLine("CpuDetectionCommand: {0}", VectorEnvironment.CpuDetectionCommand);
            writer.Write("CpuDetectionResult:\t");
            VectorTextUtil.WriteLines(writer, VectorEnvironment.CpuDetectionResult);
            writer.WriteLine();
        }

    }

}
