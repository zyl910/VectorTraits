# VectorTraits

[English](README.md) | Chinese(中文)

VectorTraits 是一个增强SIMD向量运算的跨平台类库.

[![NuGet](https://buildstats.info/nuget/VectorTraits)](https://www.nuget.org/packages/VectorTraits)

本库为向量类型提供了许多重要的算术方法(如 Shift, Shuffle, NarrowSaturate)及常数, 使您能更方便的编写跨平台的SIMD运算代码。它充分利用了 X86、Arm架构的内在函数实现硬件加速，且能够享受内联编译优化。

常用类型：
- `Vectors`: 为向量类型, 提供了常用工具函数, e.g. Create(T/T[]/Span/ReadOnlySpan), CreatePadding, CreateRotate, CreateByFunc, CreateByDouble ... 它还为向量提供了特征方法, e.g. ShiftLeft、ShiftRightArithmetic、ShiftRightLogical、Shuffle ...
- `Vectors<T>`: 为向量类型, 提供了各种元素类型的常数. e.g. Serial, SerialDesc, XyzwWMask, MantissaMask, MaxValue, MinValue, NormOne, FixedOne, E, Pi, Tau, VMaxByte, VReciprocalMaxSByte ...
- `Vector64s/Vector128s/Vector256s/Vector512s`: 为固定位宽的向量（Vector64/Vector128/Vector256/Vector512），提供了常用工具函数与特征方法.
- `Vector64s<T>/Vector128s<T>/Vector256s<T>/Vector512s<T>`: 为固定位宽的向量，提供了各种元素类型的常数.
- `Scalars`: 为标量类型, 提供了各种工具函数. e.g. GetByDouble, GetFixedByDouble, GetByBits, GetBitsMask ...
- `Scalars<T>`: 为标量类型, 提供了许多常数. e.g. ExponentBits, MantissaBits, MantissaMask, MaxValue, MinValue, NormOne, FixedOne, E, Pi, Tau, VMaxByte, VReciprocalMaxSByte ...
- `VectorTextUtil`: 提供了一些向量的文本性工具函数. e.g. GetHex, Format, WriteLine ...

支持的指令集:
- x86 (需要 .NET Core 3.0+)
  - 128位向量: Sse, Sse2, Sse3, Ssse3, Sse41, Sse42. And 128-bit instructions from Avx family.
  - 256位向量: Avx, Avx2. And 256-bit instructions from Avx512VL.
  - 512位向量: Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi.
- Arm (需要 .NET 5.0+)
  - 128位向量: AdvSimd.
- Wasm (需要 .NET 8.0+)
  - 128位向量: PackedSimd.

特征方法:
- 支持 `.NET Standard 2.1` 新增的向量方法: ConvertToDouble, ConvertToInt32, ConvertToInt64, ConvertToSingle, ConvertToUInt32, ConvertToUInt64, Narrow, Widen .
- 支持 `.NET 5.0` 新增的向量方法: Ceiling, Floor .
- 支持 `.NET 6.0` 新增的向量方法: Sum .
- 支持 `.NET 7.0` 新增的向量方法: ExtractMostSignificantBits, Shuffle, ShiftLeft, ShiftRightArithmetic, ShiftRightLogical .
- 支持 `.NET 8.0` 新增的向量方法: WidenLower, WidenUpper.
- 提供缩窄饱和的向量方法: YNarrowSaturate, YNarrowSaturateUnsigned .
- 提供舍入的向量方法: YRoundToEven, YRoundToZero .
- 提供换位的向量方法: YShuffleInsert, YShuffleKernel, YShuffleG2, YShuffleG4, YShuffleG4X2 . 且提供了 ShuffleControlG2/ShuffleControlG4 enum.
- 提供解交织的向量方法: YGroup2Unzip, YGroup2UnzipEven, YGroup2UnzipOdd, YGroup3Unzip, YGroup3UnzipX2, YGroup4Unzip, YGroup6Unzip_Bit128.
- 提供交织的向量方法: YGroup2Zip, YGroup2ZipHigh, YGroup2ZipLow, YGroup3Zip, YGroup3ZipX2, YGroup4Unzip, YGroup6Zip_Bit128.
- ...
- 完整列表: [TraitsMethodList](TraitsMethodList.md)

## 用途
总所周知，使用SIMD指令集，能够加速 多媒体处理（图形、图像、音频、视频...）、人工智能、科学计算 等。
然而，传统的SIMD编程存在以下痛点：
- 难以跨平台。因为不同的CPU体系，提供了不同的SIMD指令集，例如 X86与Arm平台的SIMD指令集存在很多差异。如果程序欲移植到另一平台下，则需要查找该平台的SIMD指令集手册，重新开发一遍。
- 位宽难以升级。即使是同一个平台，随着发展，会逐渐增加位数更宽的指令集。例如X86平台，除了已淘汰的64位MMX系列指令外，提供了了 128位SSE指令集、256位的AVX指令集，且部分高端处理器开始支持 512位的AVX-512指令集。以前用128位SSE系列指令编写的算法，若想移植到256位的AVX指令集，需要重新开发一遍，才能充分利用更宽的SIMD指令集。
- 代码可读性差，开发门槛高。很多现代C语言编译器为SIMD指令，映射了`内在函数`（Intrinsic Functions），比编写汇编代码要容易了不少，且可读性提升了不少。但是由于函数名使用了一些晦涩的缩写，且C语言不支持函数名重载，以及C语言本身的复杂性，导致代码可读性与开发难度，仍有较高的门槛。

2016年的 `.NET Core 1.0` 新增了 `Vector<T>` 等向量类型，在很大程度上解决了以上痛点。
- 容易跨平台。`.NET`平台的程序，是通过JIT（Just-In-Time Compiler，即时编译器）运行的。只编写一套基于向量方法的算法，且仅需编译为一套程序。随后该程序在不同平台上运行时，向量方法会被JIT编译为平台特有的SIMD指令集，从而充分的享用硬件加速。
- 位宽能自动升级。对于`Vector<T>`类型，它的长度不是固定的，而是与该处理器的最长向量寄存器相同。具体来说，若CPU支持AVX指令集（严格来说是AVX2及以上），`Vector<T>`类型便是256位；若CPU仅支持SSE指令集（严格来说是SSE2及以上），`Vector<T>`类型便是128位。简单来说，在编写程序时仅使用`Vector<T>`类型就行，程序运行时，JIT会自动使用最宽的SIMD指令集。
- 代码可读性较高，降低了开发门槛。`.NET`平台下，向量类型的方法名都是用完整英文单词所组成，并充分利用了函数名重载等 C# 语法特点，使这些方法名既简洁、又清晰。使得代码可读性有了很大的提高。

向量类型`Vector<T>` 虽然设计的好，但它缺少许多重要的向量函数，如 Ceiling、Sum、Shift、Shuffle 等。导致很多算法，难以用向量类型来实现。
当 `.NET` 平台版本升级时, 有时会增加若干个向量方法。例如2022年发布的 `.NET 7.0`，增加了ShiftRightArithmetic、Shuffle 等函数。但目前的向量方法还是较少, 例如缺少饱和处理等.
为了解决缺少向量方法的问题，`.NET Core 3.0`开始支持了内在函数。这能让开发者直接使用SIMD指令集，但这又面临了难以跨平台与位宽难以升级等问题。随着 `.NET` 平台的不断升级，会增加了更多的内在函数。例如 `.NET 5.0` 增加了 Arm平台的内在函数。
对于开发类库, 不能仅支持 `.NET 7.0`，而是需要支持多个 `.NET` 版本。于是你会面临繁琐的版本检查与条件处理. 而且 `.NET Standard` 类库的最高版本(2.1)，仍是是不支持Ceiling等向量方法的，导致版本检查更加繁琐. 

本库致力于解决以上麻烦, 使您能更方便的编写跨平台的SIMD算法。
特点:
- 支持低版本的 `.NET` 程序（`.NET Standard 1.1`, `.NET Core 1.0`, `.NET Framework 4.5`, ...）。能使低版本的 `.NET` 程序，也能使用最新的向量函数. 例如 `.NET 7.0`所新增的 ShiftRightArithmetic、Shuffle 等。
- 功能强. 除了参考高版本 `.NET` 的向量方法外，本库还参考内在函数，提供了很多有用的向量方法。例如 YClamp, YNarrowSaturate ...
- 性能高。本库能充分利用 X86、Arm架构的内在函数对向量类型的运算进行硬件加速，且能够享受内联编译优化。且本库解决了BCL的部分向量方法（如Multiply, Shuffle等）在一些平台上没有硬件加速的问题, 因它补充了硬件加速算法.
- 软件算法也很快。若发现向量类型的某个方法不支持硬件加速时，.NET Bcl会切换为软件算法，但它软件算法很多是含有分支语句的，性能较差。而本库的软件算法，是高度优化的无分支算法。
- 使用方便。本库不仅支持 `Vector<T>`，还支持 `Vector128<T>`/`Vector256<T>` 等向量类型。工具类的类名很好记（Vectors/Vector64s/Vector128s/Vector256s），且通过同名的泛型类提供了许多常用的向量常数。
- 为每一个特征方法, 增加了一些获取信息的的属性. e.g. `_AcceleratedTypes`, `_FullAcceleratedTypes` .

提示: 在 Visual Studio 的 Disassembly窗口可以查看运行时的汇编代码. 例如在支持 Avx指令集的机器上运行时, `Vectors.ShiftLeft_Const` 会被内联编译优化为使用 `vpsllw` 指令. 且对于常量值(1), 会被编译为指令的立即数.
![Vectors.ShiftLeft_use_inline.png](images/Vectors.ShiftLeft_use_inline.png)

例2: 使用 `Vectors.ShiftLeft_Args` 与 `Vectors.ShiftLeft_Core`, 能将部分运算挪到循环外去提前处理. 例如在支持 Avx指令集的机器上运行时, 会在循环外设置好 `xmm1`, 随后在内循环的`vpsllw`指令里使用了它. 且这里展示了: 内联编译优化消除了冗余的 xmm/ymm 转换.
![Vectors.ShiftLeft_Core_use_inline.png](images/Vectors.ShiftLeft_Core_use_inline.png)

## 入门指南

### 1) 通过NuGet安装
可在'包管理器控制台'里输入以下命令, 或是使用'包管理器'GUI来安装本库.

NuGet: `PM> Install-Package VectorTraits` 

### 2) 用法示例

静态类 `Vectors` 提供了许多方法, 例如 CreateRotate, ShiftLeft, Shuffle.
泛型结构体 `Vectors<T>` 为常用常数提供了字段.

范例代码在 `samples/VectorTraits.Sample` 文件夹. 源代码如下.
```cs
using System;
using System.IO;
using System.Numerics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits;

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
        }
    }
}
```

### 3) 示例的运行结果
#### `.NET8.0` on X86
程序: `VectorTraits.Sample`

```
VectorTraits.Sample

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.8
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.8\
RuntimeInformation.FrameworkDescription:	.NET 8.0.8
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector512.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844161	# 0x8177F7FF
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Avx512BW, Avx512CD, Avx512DQ, Avx512F, Avx512Vbmi, Avx512VL, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2, Avx512VL
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vector512s.Instance:	WVectorTraits512Avx512	// Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi, Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vectors.BaseInstance:	VectorTraits256Base

src:    <0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7>        # (0000 0001 0002 0003 0004 0005 0006 0007 0000 0001 0002 0003 0004 0005 0006 0007)
ShiftLeft:      <0, 2, 4, 6, 8, 10, 12, 14, 0, 2, 4, 6, 8, 10, 12, 14>  # (0000 0002 0004 0006 0008 000A 000C 000E 0000 0002 0004 0006 0008 000A 000C 000E)
Equals to BCL ShiftLeft:        True
Equals to ShiftLeft_Const:      True

desc:   <15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0>  # (000F 000E 000D 000C 000B 000A 0009 0008 0007 0006 0005 0004 0003 0002 0001 0000)
Shuffle:        <14, 12, 10, 8, 6, 4, 2, 0, 14, 12, 10, 8, 6, 4, 2, 0>  # (000E 000C 000A 0008 0006 0004 0002 0000 000E 000C 000A 0008 0006 0004 0002 0000)
Equals to BCL Shuffle:  True
Equals to Shuffle_Core: True

ShiftLeft_AcceleratedTypes:     SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64        # (00001FE0)
Shuffle_AcceleratedTypes:       SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double        # (00007FE0)
```

注: `Vectors.BaseInstance` 及之前的文本, 是`TraitsOutput.OutputEnvironment`输出的环境信息. 而从 `src` 开始的, 才是示例的主体代码.
由于CPU支持X86的Avx2指令集, 于是 `Vector<byte>.Count` 为 32(256bit), `Vectors.Instance` 为 `VectorTraits256Avx2`.

#### `.NET8.0` on Arm
程序: `VectorTraits.Sample`

```
VectorTraits.Sample

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	8.0.7
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/
RuntimeInformation.FrameworkDescription:	.NET 8.0.7
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Ubuntu 22.04.2 LTS
RuntimeInformation.RuntimeIdentifier:	linux-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844159	# 0x8177F801
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base

src:	<0, 1, 2, 3, 4, 5, 6, 7>	# (0000 0001 0002 0003 0004 0005 0006 0007)
ShiftLeft:	<0, 2, 4, 6, 8, 10, 12, 14>	# (0000 0002 0004 0006 0008 000A 000C 000E)
Equals to BCL ShiftLeft:	True
Equals to ShiftLeft_Const:	True

desc:	<7, 6, 5, 4, 3, 2, 1, 0>	# (0007 0006 0005 0004 0003 0002 0001 0000)
Shuffle:	<14, 12, 10, 8, 6, 4, 2, 0>	# (000E 000C 000A 0008 0006 0004 0002 0000)
Equals to BCL Shuffle:	True
Equals to Shuffle_Core:	True

ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
```

运算结果与X86的相同，只是环境信息不同。
由于CPU支持Arm的AdvSimd指令集, 于是 `Vector<byte>.Count` 为 16(128bit), `Vectors.Instance` 为 `VectorTraits128AdvSimdB64`.

#### `.NET Framework 4.5` on X86
程序: `VectorTraits.Sample.NetFw`.

```
VectorTraits.Sample

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9277.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base

src:    <0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7>        # (0000 0001 0002 0003 0004 0005 0006 0007 0000 0001 0002 0003 0004 0005 0006 0007)
ShiftLeft:      <0, 2, 4, 6, 8, 10, 12, 14, 0, 2, 4, 6, 8, 10, 12, 14>  # (0000 0002 0004 0006 0008 000A 000C 000E 0000 0002 0004 0006 0008 000A 000C 000E)
Equals to ShiftLeft_Const:      True

desc:   <15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0>  # (000F 000E 000D 000C 000B 000A 0009 0008 0007 0006 0005 0004 0003 0002 0001 0000)
Shuffle:        <14, 12, 10, 8, 6, 4, 2, 0, 14, 12, 10, 8, 6, 4, 2, 0>  # (000E 000C 000A 0008 0006 0004 0002 0000 000E 000C 000A 0008 0006 0004 0002 0000)
Equals to Shuffle_Core: True

ShiftLeft_AcceleratedTypes:     SByte, Byte, Int16, UInt16, Int32, UInt32       # (000007E0)
Shuffle_AcceleratedTypes:       None    # (00000000)
```

Vectors 的 ShiftLeft/Shuffle 都能正常工作.
由于CPU支持X86的Avx2指令集, 于是 `Vector<byte>.Count` 为 32(256bit). `Vectors.Instance` 为 `VectorTraits256Base`. 它不是 `VectorTraits256Avx2`, 是因为直到 `.NET Core 3.0` 才支持内在函数.
ShiftLeft_AcceleratedTypes的值含有“Int16”等类型，这表示ShiftLeft在使用这些类型时, 是存在硬件加速的. 本库巧妙的利用了向量算法, 即使在没有内在函数时，也尽量实现了硬件加速.

## 基准测试结果
数据的单位: 百万次操作/秒. 数字越大, 性能越好.

### ShiftLeft
ShiftLeft: 将向量的每个元素左移指定量.
它是`.NET 7.0`所新增的向量方法.

#### ShiftLeft - X86 - AMD Ryzen 7 7840H
| Type  | Method                 | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :---- | :--------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| Byte  | SumSLLScalar           |       1062.046 |      1025.936 |      1287.865 |  1265.446 |  1445.575 |  1416.712 |  1693.330 |
| Byte  | SumSLLNetBcl           |                |               |               |           |           |  1344.738 |  1109.752 |
| Byte  | SumSLLNetBcl_Const     |                |               |               |           |           |  1281.901 |  1164.382 |
| Byte  | SumSLLTraits           |      11312.499 |     10715.920 |     28897.868 | 28611.234 | 28219.205 | 34068.741 | 57456.802 |
| Byte  | SumSLLTraits_Core      |      55791.675 |     52165.732 |     53563.421 | 68653.359 | 59916.622 | 67868.291 | 74889.177 |
| Byte  | SumSLLConstTraits      |      13408.916 |     12604.412 |     38925.388 | 57842.081 | 57095.294 | 62012.692 | 62729.225 |
| Byte  | SumSLLConstTraits_Core |      56843.523 |     55673.528 |     53642.484 | 62674.397 | 65797.708 | 50869.840 | 73873.979 |
| Int16 | SumSLLScalar           |       1081.716 |       999.767 |      1261.475 |  1198.111 |  1218.767 |  1365.754 |  1547.294 |
| Int16 | SumSLLNetBcl           |                |               |               |           |           | 32011.646 | 34816.284 |
| Int16 | SumSLLNetBcl_Const     |                |               |               |           |           | 39975.924 | 37368.541 |
| Int16 | SumSLLTraits           |       6752.349 |      6185.968 |     25221.856 | 26382.708 | 27125.955 | 32617.944 | 36448.716 |
| Int16 | SumSLLTraits_Core      |      34727.283 |     31457.238 |     31800.310 | 32231.553 | 35687.996 | 37750.305 | 30731.745 |
| Int16 | SumSLLConstTraits      |       6037.367 |      6498.819 |     27783.526 | 37605.559 | 40699.914 | 39598.663 | 36242.630 |
| Int16 | SumSLLConstTraits_Core |      37678.435 |     34784.616 |     32625.543 | 33694.338 | 40019.325 | 39380.404 | 36914.775 |
| Int32 | SumSLLScalar           |       1369.140 |      1315.852 |      1514.690 |  1521.516 |  2284.670 |  2484.407 |  2409.358 |
| Int32 | SumSLLNetBcl           |                |               |               |           |           | 17373.567 | 15954.004 |
| Int32 | SumSLLNetBcl_Const     |                |               |               |           |           | 17967.080 | 15983.409 |
| Int32 | SumSLLTraits           |       3762.374 |      3511.433 |     13343.304 | 12906.293 | 12661.423 | 17279.760 | 15886.410 |
| Int32 | SumSLLTraits_Core      |      17324.275 |     15468.381 |     14587.937 | 17407.823 | 17886.651 | 18052.162 | 14126.571 |
| Int32 | SumSLLConstTraits      |       3910.600 |      3724.412 |     12646.545 | 15290.340 | 17745.992 | 17829.078 | 15991.615 |
| Int32 | SumSLLConstTraits_Core |      16235.154 |     14216.598 |     15282.565 | 16088.400 | 17940.330 | 15961.166 | 16378.506 |
| Int64 | SumSLLScalar           |       1394.719 |      1281.156 |      1517.938 |  1441.160 |  2270.521 |  2508.577 |  2421.558 |
| Int64 | SumSLLNetBcl           |                |               |               |           |           |  7528.184 |  8530.835 |
| Int64 | SumSLLNetBcl_Const     |                |               |               |           |           |  8743.504 |  8471.981 |
| Int64 | SumSLLTraits           |        483.430 |       494.335 |      6677.544 |  6570.711 |  6635.070 |  6891.705 |  7469.236 |
| Int64 | SumSLLTraits_Core      |        479.761 |       488.827 |      7758.515 |  8525.784 |  8596.290 |  8267.855 |  7879.060 |
| Int64 | SumSLLConstTraits      |        509.585 |       525.195 |      7036.223 |  6787.101 |  8246.601 |  8254.880 |  8526.022 |
| Int64 | SumSLLConstTraits_Core |        512.652 |       528.381 |      8229.954 |  8747.125 |  8711.523 |  8871.948 |  8647.339 |

说明:
- SumSLLScalar: 使用标量算法.
- SumSLLNetBcl: 使用BCL的方法(`Vector.ShiftLeft`), 参数是变量. 注意 `.NET 7.0` 才提供该方法.
- SumSLLNetBcl_Const: 使用BCL的方法(`Vector.ShiftLeft`), 参数是常量. 注意 `.NET 7.0` 才提供该方法.
- SumSLLTraits: 使用本库的普通方法(`Vectors.ShiftLeft`), 参数是变量.
- SumSLLTraits_Core: 使用本库的 `Core` 后缀的方法(`Vectors.ShiftLeft_Args`, `Vectors.ShiftLeft_Core`), 参数是变量.
- SumSLLConstTraits: 使用本库的 `Const` 后缀的方法(`Vectors.ShiftLeft_Const`), 参数是常量.
- SumSLLConstTraits_Core: 使用本库的 `ConstCore` 后缀的方法(`Vectors.ShiftLeft_Args`, `Vectors.ShiftLeft_ConstCore`), 参数是常量.

BCL的方法(`Vector.ShiftLeft`) 在X86平台运行时, 仅 Int16/Int32/Int64 有硬件加速, 而 Byte 没有硬件加速. 这是可能是因为 Avx2 指令集仅有 16~64位 的左移位指令, 未提供其他类型的指令, BCL便转为软件算法了.
而本库对于这些数字类型, 会换成由其他指令组合实现的高效算法. 例如对于 Byte类型, SumSLLConstTraits_Core 在`.NET 8.0`的值为“73873.979”, 性能是 标量算法的 `73873.979/1693.330≈43.6264` 倍, 且是BCL方法的 `73873.979/1164.382≈63.4448` 倍.
因为X86的内在函数是从`.NET Core 3.0`开始才提供的. 故对于 Int64类型, 在 `.NET Core 3.0` 之后才有硬件加速.

对于ShiftLeft来说, 当参数`shiftAmount` 是常量时, 性能一般会比用变量时更高. 无论是 BCL还是本库的方法, 都是如此.
使用本库的 `Core` 后缀的方法,  能将部分运算挪到循环外去提前处理, 从而优化了性能. 而当 CPU提供了常数参数的指令时（专业术语是“立即数参数”）, 该指令的性能一般会更高. 于是本库还提供了 `ConstCore` 后缀的方法, 会选择该平台最快的指令.
因“CPU睿频”、“其他进程抢占CPU资源”等因素, 有时性能波动比较大. 但请放心, 已经检查过了Release的程序运行时的汇编指令, 它已经是按最佳硬件指令运行的. 例如下图.

![Vectors.ShiftLeft_Core_use_inline.png](images/Vectors.ShiftLeft_Core_use_inline.png)

#### ShiftLeft - Arm - AWS Arm t4g.small
| Type  | Method                 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :---- | :--------------------- | ------------: | --------: | --------: | --------: | --------: |
| Byte  | SumSLLScalar           |       606.721 |   607.751 |   674.256 |   890.878 |  1238.814 |
| Byte  | SumSLLNetBcl           |               |           |           | 19585.982 | 19831.927 |
| Byte  | SumSLLNetBcl_Const     |               |           |           | 19564.840 | 19840.232 |
| Byte  | SumSLLTraits           |      5541.532 | 13075.259 | 13190.705 | 13209.927 | 19844.497 |
| Byte  | SumSLLTraits_Core      |     14048.511 | 16947.485 | 15828.571 | 19589.430 | 19841.525 |
| Byte  | SumSLLConstTraits      |      9734.870 | 15699.315 | 15853.772 | 19511.952 | 19811.385 |
| Byte  | SumSLLConstTraits_Core |     13007.028 | 16817.247 | 15838.060 | 19422.222 | 19839.627 |
| Int16 | SumSLLScalar           |       606.135 |   603.800 |   605.734 |   820.880 |  1031.035 |
| Int16 | SumSLLNetBcl           |               |           |           |  9943.220 |  9803.495 |
| Int16 | SumSLLNetBcl_Const     |               |           |           |  9937.639 |  9837.136 |
| Int16 | SumSLLTraits           |      4215.369 |  6547.514 |  6558.299 |  9923.088 |  9839.256 |
| Int16 | SumSLLTraits_Core      |      7918.688 |  8431.934 |  7892.235 |  9939.469 |  9839.496 |
| Int16 | SumSLLConstTraits      |      6568.606 |  7829.860 |  7887.842 |  9925.988 |  9839.534 |
| Int16 | SumSLLConstTraits_Core |      8494.550 |  8416.796 |  7902.444 |  9914.384 |  9823.608 |
| Int32 | SumSLLScalar           |       747.656 |   746.013 |   749.108 |  1406.122 |  1410.137 |
| Int32 | SumSLLNetBcl           |               |           |           |  4926.651 |  4826.909 |
| Int32 | SumSLLNetBcl_Const     |               |           |           |  4917.732 |  4840.232 |
| Int32 | SumSLLTraits           |      3293.943 |  3269.129 |  3278.303 |  4925.488 |  4836.941 |
| Int32 | SumSLLTraits_Core      |      4210.811 |  3930.619 |  3927.408 |  4923.867 |  4844.083 |
| Int32 | SumSLLConstTraits      |      3275.986 |  3249.809 |  3923.176 |  4926.463 |  4846.238 |
| Int32 | SumSLLConstTraits_Core |      4205.245 |  4199.155 |  4156.634 |  4925.448 |  4844.679 |
| Int64 | SumSLLScalar           |       739.137 |   729.158 |   741.673 |  1372.480 |  1296.655 |
| Int64 | SumSLLNetBcl           |               |           |           |  2477.025 |  2264.032 |
| Int64 | SumSLLNetBcl_Const     |               |           |           |  2473.102 |  2251.272 |
| Int64 | SumSLLTraits           |       486.734 |  1638.835 |  1636.233 |  1985.596 |  2285.512 |
| Int64 | SumSLLTraits_Core      |       489.554 |  2075.273 |  1967.902 |  2474.105 |  2289.521 |
| Int64 | SumSLLConstTraits      |       467.393 |  1930.821 |  1968.798 |  2471.124 |  2308.745 |
| Int64 | SumSLLConstTraits_Core |       466.293 |  2074.656 |  1968.834 |  2476.602 |  2281.018 |

说明:
- SumSLLScalar: 使用标量算法.
- SumSLLNetBcl: 使用BCL的方法(`Vector.ShiftLeft`), 参数是变量. 注意 `.NET 7.0` 才提供该方法.
- SumSLLNetBcl_Const: 使用BCL的方法(`Vector.ShiftLeft`), 参数是常量. 注意 `.NET 7.0` 才提供该方法.
- SumSLLTraits: 使用本库的普通方法(`Vectors.ShiftLeft`), 参数是变量.
- SumSLLTraits_Core: 使用本库的 `Core` 后缀的方法(`Vectors.ShiftLeft_Args`, `Vectors.ShiftLeft_Core`), 参数是变量.
- SumSLLConstTraits: 使用本库的 `Const` 后缀的方法(`Vectors.ShiftLeft_Const`), 参数是常量.
- SumSLLConstTraits_Core: 使用本库的 `ConstCore` 后缀的方法(`Vectors.ShiftLeft_Args`, `Vectors.ShiftLeft_ConstCore`), 参数是常量.

BCL的方法(`Vector.ShiftLeft`) 在Arm平台运行时, 整数类型都有硬件加速. 对于8~64位整数的左移位, AdvSimd指令集都提供了专用指令.
本库在Arm平台运行时, 也使用了同样的指令. 于是性能接近.
因为从 `.NET 5.0`开始, 才提供了 Arm的内在函数. 故对于 Int64类型, 在 `.NET 5.0` 之后才有硬件加速.


### ShiftRightArithmetic
ShiftRightArithmetic: 将向量的每个有符号元素算术右移指定量.
它是`.NET 7.0`所新增的向量方法.

#### ShiftRightArithmetic - X86 - AMD Ryzen 7 7840H
| Type  | Method                 | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :---- | :--------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| Int16 | SumSRAScalar           |       1085.176 |      1043.731 |      1227.822 |  1215.729 |  1209.230 |  1310.645 |  1397.378 |
| Int16 | SumSRANetBcl           |                |               |               |           |           | 31888.645 | 35102.079 |
| Int16 | SumSRANetBcl_Const     |                |               |               |           |           | 39751.018 | 36630.458 |
| Int16 | SumSRATraits           |       1829.405 |      1861.938 |     25643.096 | 26584.675 | 26634.093 | 31578.602 | 37184.123 |
| Int16 | SumSRATraits_Core      |       1837.663 |      1874.262 |     33248.481 | 36967.972 | 36890.508 | 37648.798 | 37673.670 |
| Int16 | SumSRAConstTraits      |       1836.653 |      1880.351 |     28724.613 | 36985.528 | 39429.041 | 32925.588 | 37356.009 |
| Int16 | SumSRAConstTraits_Core |       1830.444 |      1879.354 |     33935.625 | 37498.165 | 38127.794 | 33120.549 | 35752.947 |
| Int32 | SumSRAScalar           |       1362.876 |      1321.507 |      1508.831 |  1508.378 |  2226.648 |  2555.622 |  2327.611 |
| Int32 | SumSRANetBcl           |                |               |               |           |           | 16806.958 | 15967.982 |
| Int32 | SumSRANetBcl_Const     |                |               |               |           |           | 18365.861 | 16092.208 |
| Int32 | SumSRATraits           |        883.925 |       895.137 |     12901.507 | 12508.762 | 11931.480 | 17609.103 | 16282.512 |
| Int32 | SumSRATraits_Core      |        919.507 |       931.419 |     15956.786 | 15252.829 | 17412.025 | 18296.493 | 16230.128 |
| Int32 | SumSRAConstTraits      |        911.750 |       942.523 |     13450.043 | 17314.816 | 14198.095 | 16799.445 | 16393.351 |
| Int32 | SumSRAConstTraits_Core |        917.228 |       938.789 |     15344.136 | 15470.629 | 17084.816 | 18274.411 | 16054.229 |
| Int32 | SumSRAFastTraits       |        915.754 |       946.521 |     13266.168 | 15337.171 | 14562.129 | 17003.224 | 16124.004 |
| Int64 | SumSRAScalar           |       1393.540 |      1331.963 |      1532.719 |  1544.306 |  1513.245 |  1801.859 |  2560.284 |
| Int64 | SumSRANetBcl           |                |               |               |           |           |   524.702 |  8652.579 |
| Int64 | SumSRANetBcl_Const     |                |               |               |           |           |   557.152 |  8870.207 |
| Int64 | SumSRATraits           |        482.604 |       490.804 |      4949.328 |  4970.328 |  4932.277 |  4902.239 |  7541.726 |
| Int64 | SumSRATraits_Core      |        509.432 |       521.769 |      5941.547 |  6050.322 |  6104.433 |  6043.337 |  8537.297 |
| Int64 | SumSRAConstTraits      |        510.778 |       529.298 |      5526.893 |  5360.460 |  5834.075 |  6217.509 |  7562.071 |
| Int64 | SumSRAConstTraits_Core |        509.597 |       531.344 |      5899.752 |  5978.398 |  6049.756 |  6171.211 |  7720.979 |
| SByte | SumSRAScalar           |        997.067 |       974.147 |      1278.049 |  1350.082 |  1227.788 |  1328.380 |  1387.993 |
| SByte | SumSRANetBcl           |                |               |               |           |           |  1135.177 |  1113.944 |
| SByte | SumSRANetBcl_Const     |                |               |               |           |           |  1165.780 |  1061.118 |
| SByte | SumSRATraits           |       3635.592 |      3696.780 |     24686.302 | 22906.323 | 22437.129 | 24879.962 | 44225.353 |
| SByte | SumSRATraits_Core      |       3652.670 |      3743.427 |     41915.608 | 45147.925 | 45375.300 | 46792.941 | 45642.076 |
| SByte | SumSRAConstTraits      |       3651.109 |      3753.761 |     29819.076 | 42019.515 | 43095.169 | 44048.300 | 47091.982 |
| SByte | SumSRAConstTraits_Core |       3662.694 |      3753.270 |     39588.701 | 46397.665 | 47507.648 | 43046.477 | 46878.753 |

说明:
- SumSRAScalar: 使用标量算法.
- SumSRANetBcl: 使用BCL的方法(`Vector.ShiftRightArithmetic`), 参数是变量. 注意 `.NET 7.0` 才提供该方法.
- SumSRANetBcl_Const: 使用BCL的方法(`Vector.ShiftRightArithmetic`), 参数是常量. 注意 `.NET 7.0` 才提供该方法.
- SumSRATraits: 使用本库的普通方法(`Vectors.ShiftRightArithmetic`), 参数是变量.
- SumSRATraits_Core: 使用本库的 `Core` 后缀的方法(`Vectors.ShiftRightArithmetic_Args`, `Vectors.ShiftRightArithmetic_Core`), 参数是变量.
- SumSRAConstTraits: 使用本库的 `Const` 后缀的方法(`Vectors.ShiftRightArithmetic_Const`), 参数是常量.
- SumSRAConstTraits_Core: 使用本库的 `ConstCore` 后缀的方法(`Vectors.ShiftRightArithmetic_Args`, `Vectors.ShiftRightArithmetic_ConstCore`), 参数是常量.

BCL的方法(`Vector.ShiftRightArithmetic`) 在X86平台运行时, 仅 Int16/Int32 有硬件加速, 而 SByte/Int64 没有硬件加速. 这是可能是因为 Avx2 指令集仅有 16~32位 的算术右移位指令. Avx512 指令集增加了64位的算术右移位指令.
而本库对于这些数字类型, 会换成由其他指令组合实现的高效算法. 从 `.NET Core 3.0` 开始, 具有硬件加速.

#### ShiftRightArithmetic - Arm - AWS Arm t4g.small
| Type  | Method                 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :---- | :--------------------- | ------------: | --------: | --------: | --------: | --------: |
| Int16 | SumSRAScalar           |       604.429 |   602.027 |   606.297 |   818.740 |   830.302 |
| Int16 | SumSRANetBcl           |               |           |           |  9941.412 |  9837.372 |
| Int16 | SumSRANetBcl_Const     |               |           |           |  9931.397 |  9838.530 |
| Int16 | SumSRATraits           |      1713.818 |  5611.316 |  4949.502 |  9932.269 |  9837.893 |
| Int16 | SumSRATraits_Core      |      1928.197 |  7881.850 |  8435.043 |  9930.918 |  9707.757 |
| Int16 | SumSRAConstTraits      |      1936.057 |  7776.346 |  8432.064 |  9926.348 |  9834.469 |
| Int16 | SumSRAConstTraits_Core |      1895.291 |  7825.036 |  8426.085 |  9923.414 |  9834.395 |
| Int32 | SumSRAScalar           |       745.287 |   749.467 |   747.486 |  1181.651 |  1244.019 |
| Int32 | SumSRANetBcl           |               |           |           |  4929.438 |  4848.848 |
| Int32 | SumSRANetBcl_Const     |               |           |           |  4937.824 |  4854.964 |
| Int32 | SumSRATraits           |       859.173 |  2815.113 |  2819.116 |  4937.562 |  4813.108 |
| Int32 | SumSRATraits_Core      |       945.694 |  3917.314 |  3916.943 |  4933.939 |  4787.843 |
| Int32 | SumSRAConstTraits      |       967.576 |  3904.750 |  4188.713 |  4901.680 |  4849.051 |
| Int32 | SumSRAConstTraits_Core |       947.955 |  3906.471 |  4192.951 |  4908.354 |  4853.184 |
| Int64 | SumSRAScalar           |       738.902 |   734.754 |   741.343 |  1185.217 |  1243.954 |
| Int64 | SumSRANetBcl           |               |           |           |  2474.620 |  2433.159 |
| Int64 | SumSRANetBcl_Const     |               |           |           |  2478.519 |  2438.677 |
| Int64 | SumSRATraits           |       467.838 |  1233.506 |  1233.401 |  1418.970 |  2424.896 |
| Int64 | SumSRATraits_Core      |       468.470 |  1952.967 |  1971.453 |  2478.229 |  2424.819 |
| Int64 | SumSRAConstTraits      |       467.182 |  1939.969 |  1970.321 |  2474.340 |  2413.790 |
| Int64 | SumSRAConstTraits_Core |       468.634 |  2095.352 |  2102.958 |  2474.473 |  2432.455 |
| SByte | SumSRAScalar           |       608.671 |   609.771 |   652.251 |   889.935 |   830.400 |
| SByte | SumSRANetBcl           |               |           |           | 19779.972 | 19615.987 |
| SByte | SumSRANetBcl_Const     |               |           |           | 19803.799 | 19613.758 |
| SByte | SumSRATraits           |      3482.537 | 11212.340 |  9894.245 | 11352.199 | 19512.654 |
| SByte | SumSRATraits_Core      |      3857.464 | 16756.195 | 15733.712 | 19816.163 | 19419.454 |
| SByte | SumSRAConstTraits      |      3905.027 | 15518.199 | 15732.344 | 19791.972 | 19617.529 |
| SByte | SumSRAConstTraits_Core |      3796.018 | 16708.142 | 16787.090 | 19791.891 | 19619.300 |

说明:
- SumSRAScalar: 使用标量算法.
- SumSRANetBcl: 使用BCL的方法(`Vector.ShiftRightArithmetic`), 参数是变量. 注意 `.NET 7.0` 才提供该方法.
- SumSRANetBcl_Const: 使用BCL的方法(`Vector.ShiftRightArithmetic`), 参数是常量. 注意 `.NET 7.0` 才提供该方法.
- SumSRATraits: 使用本库的普通方法(`Vectors.ShiftRightArithmetic`), 参数是变量.
- SumSRATraits_Core: 使用本库的 `Core` 后缀的方法(`Vectors.ShiftRightArithmetic_Args`, `Vectors.ShiftRightArithmetic_Core`), 参数是变量.
- SumSRAConstTraits: 使用本库的 `Const` 后缀的方法(`Vectors.ShiftRightArithmetic_Const`), 参数是常量.
- SumSRAConstTraits_Core: 使用本库的 `ConstCore` 后缀的方法(`Vectors.ShiftRightArithmetic_Args`, `Vectors.ShiftRightArithmetic_ConstCore`), 参数是常量.

BCL的方法(`Vector.ShiftRightArithmetic`) 在Arm平台运行时, 整数类型都有硬件加速. 对于8~64位整数的算术右移位, AdvSimd指令集都提供了专用指令.
本库在Arm平台运行时, 也使用了同样的指令. 于是性能接近. 从 `.NET 5.0` 开始, 具有硬件加速.

### Shuffle
Shuffle: 换位并清零. 通过使用一组索引从输入向量中选择值，来创建一个新向量.
它是`.NET 7.0`所新增的向量方法. 自 `.NET 7.0` 开始, Vector128/Vector256 里提供了 Shuffle 方法, 但 Vector 里尚未提供 Shuffle 方法.

Shuffle 允许索引超过有效范围, 此次会将对应元素置0. 这个特性会稍微拖慢性能, 于是本库还提供了 YShuffleKernel 方法(仅换位). 若能确保索引总是在有效范围内, 用 YShuffleKernel 更快.

#### Shuffle - X86 - AMD Ryzen 7 7840H
| Type  | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :---- | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| Int16 | SumScalar             |       1236.944 |      1263.908 |      1214.484 |  1278.657 |  1195.188 |  1408.179 |  1235.365 |
| Int16 | Sum256_Bcl            |                |               |               |           |           |  1074.656 |   938.447 |
| Int16 | Sum512_Bcl            |                |               |               |           |           |           |   918.911 |
| Int16 | SumTraits             |       1221.046 |      1255.341 |      8067.493 | 10943.134 | 10421.696 | 14194.280 | 32579.746 |
| Int16 | SumTraits_Args0       |       1278.650 |      1211.361 |     22661.648 | 25363.988 | 24123.555 | 26722.243 | 34671.910 |
| Int16 | SumTraits_Args        |       1255.109 |      1154.801 |     22911.649 | 26138.766 | 24804.170 | 26585.684 | 33172.777 |
| Int16 | SumKernelTraits       |       1269.733 |      1192.079 |      8698.117 | 12377.326 | 11972.407 | 17610.477 | 35632.301 |
| Int16 | SumKernelTraits_Args0 |       1297.765 |      1199.697 |     23028.564 | 25852.122 | 25176.482 | 24261.582 | 36741.022 |
| Int16 | SumKernelTraits_Args  |       1270.852 |      1142.885 |     23265.595 | 25960.405 | 21744.418 | 23156.078 | 37227.607 |
| Int32 | SumScalar             |        850.057 |       829.782 |       816.013 |   859.672 |   817.223 |   853.140 |   837.720 |
| Int32 | Sum256_Bcl            |                |               |               |           |           |   755.314 |   770.558 |
| Int32 | Sum512_Bcl            |                |               |               |           |           |           |   930.330 |
| Int32 | SumTraits             |        821.394 |       844.388 |     10852.534 | 10832.760 | 10943.342 | 12695.692 | 15067.794 |
| Int32 | SumTraits_Args0       |        864.447 |       818.042 |     12704.591 | 15953.127 | 15574.554 | 14391.785 | 15559.766 |
| Int32 | SumTraits_Args        |        810.166 |       762.183 |     12531.310 | 14746.991 | 14125.335 | 13524.193 | 15368.528 |
| Int32 | SumKernelTraits       |        825.747 |       841.229 |     14515.308 | 14407.190 | 14545.131 | 16276.648 | 15999.993 |
| Int32 | SumKernelTraits_Args0 |        856.015 |       814.055 |     14754.810 | 14880.916 | 17262.390 | 14319.199 | 16261.174 |
| Int32 | SumKernelTraits_Args  |        806.479 |       765.218 |     15073.768 | 14604.621 | 16999.007 | 16367.119 | 16422.220 |
| Int64 | SumScalar             |        425.474 |       430.216 |       457.179 |   497.203 |   465.105 |   432.348 |   425.921 |
| Int64 | Sum256_Bcl            |                |               |               |           |           |   506.686 |   515.520 |
| Int64 | Sum512_Bcl            |                |               |               |           |           |           |   688.892 |
| Int64 | SumTraits             |        474.906 |       431.296 |      3789.327 |  4192.951 |  4280.568 |  4155.819 |  8171.028 |
| Int64 | SumTraits_Args0       |        423.703 |       461.664 |      6979.885 |  7855.241 |  8501.271 |  7846.303 |  8198.449 |
| Int64 | SumTraits_Args        |        446.260 |       420.925 |      6704.874 |  8599.441 |  8317.550 |  7312.362 |  8378.340 |
| Int64 | SumKernelTraits       |        473.823 |       426.081 |      4854.793 |  5862.440 |  5735.074 |  5938.699 |  8560.856 |
| Int64 | SumKernelTraits_Args0 |        424.508 |       458.248 |      7804.575 |  8108.408 |  9181.086 |  8364.106 |  8701.155 |
| Int64 | SumKernelTraits_Args  |        446.097 |       428.538 |      8386.279 |  9239.331 |  9198.798 |  8344.952 |  8673.715 |
| SByte | SumScalar             |       1496.783 |      1403.348 |      1448.660 |  1239.277 |  1468.827 |  1415.139 |  1213.582 |
| SByte | Sum256_Bcl            |                |               |               |           |           |   901.114 |  1022.223 |
| SByte | Sum512_Bcl            |                |               |               |           |           |           |   989.131 |
| SByte | SumTraits             |       1476.771 |      1494.144 |     17086.314 | 24231.464 | 24097.622 | 30243.434 | 60885.250 |
| SByte | SumTraits_Args0       |       1392.158 |      1331.083 |     45038.802 | 50540.409 | 49090.081 | 46979.783 | 60672.985 |
| SByte | SumTraits_Args        |       1389.074 |      1295.641 |     46794.997 | 51069.265 | 50078.249 | 46518.750 | 65261.554 |
| SByte | SumKernelTraits       |       1476.637 |      1242.198 |     27650.933 | 32894.218 | 32711.664 | 39630.939 | 72350.167 |
| SByte | SumKernelTraits_Args0 |       1523.543 |      1440.011 |     44451.891 | 49973.813 | 51540.236 | 48754.502 | 72615.251 |
| SByte | SumKernelTraits_Args  |       1395.106 |      1274.943 |     41001.996 | 50067.099 | 49654.805 | 45904.504 | 71412.964 |

说明:
- SumScalar: 使用标量算法.
- Sum256_Bcl: 使用BCL的256位向量方法(`Vector256.Shuffle`).
- Sum512_Bcl: 使用BCL的512位向量方法(`Vector512.Shuffle`).
- SumTraits: 使用本库的普通方法(`Vectors.Shuffle`).
- SumTraits_Args0: 使用本库的 `Core` 后缀的方法(`Vectors.Shuffle_Args`, `Vectors.Shuffle_Core`), 不使用ValueTuple, 而是用“out”关键字返回多个值.
- SumTraits_Args: 使用本库的 `Core` 后缀的方法(`Vectors.Shuffle_Args`, `Vectors.Shuffle_Core`), 使用ValueTuple.
- SumKernelTraits: 使用本库的YShuffleKernel的普通方法(`Vectors.YShuffleKernel`).
- SumKernelTraits_Args0: 使用本库的YShuffleKernel的 `Core` 后缀的方法(`Vectors.YShuffleKernel_Args`, `Vectors.YShuffleKernel_Core`), 不使用ValueTuple, 而是用“out”关键字返回多个值.
- SumKernelTraits_Args: 使用本库的YShuffleKernel的 `Core` 后缀的方法(`Vectors.YShuffleKernel_Args`, `Vectors.YShuffleKernel_Core`), 使用ValueTuple.

BCL的方法(`Vector.Shuffle`) 在X86平台运行时, 所有数字类型, 均没有硬件加速.
而本库对于这些数字类型, 会换成由其他指令组合实现的高效算法. 从 `.NET Core 3.0` 开始, 具有硬件加速.
使用本库的 `Core` 后缀的方法,  能将部分运算挪到循环外去提前处理, 从而优化了性能. 特别对于Shuffle方法来说, 性能提升幅度较大.
若能确保索引总是在有效范围内, 能用 YShuffleKernel 替代Shuffle. 它更快.
对于`Args` 后缀的方法, 除了可以用“out”关键字返回多个值外, 还可以用 ValueTuple 来接收多个值, 简化了代码. 但得注意 ValueTuple 有时会降低性能.

#### Shuffle - Arm - AWS Arm t4g.small
| Type  | Method                | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :---- | :-------------------- | ------------: | --------: | --------: | --------: | --------: |
| Int16 | SumScalar             |       427.276 |   421.887 |   421.454 |   526.589 |   516.294 |
| Int16 | Sum128_Bcl            |               |           |           |   482.907 |   468.383 |
| Int16 | SumTraits             |       428.281 |  4922.876 |  5555.655 |  5864.193 |  9711.569 |
| Int16 | SumTraits_Args0       |       428.928 |  7902.420 |  8416.624 |  9925.441 |  9709.555 |
| Int16 | SumTraits_Args        |       405.537 |  2809.483 |  2798.925 |  9880.804 |  9707.490 |
| Int16 | SumKernelTraits       |       427.637 |  5650.913 |  6540.446 |  7957.175 |  9833.813 |
| Int16 | SumKernelTraits_Args0 |       427.578 |  7897.224 |  7891.894 |  9929.863 |  9819.774 |
| Int16 | SumKernelTraits_Args  |       405.223 |  2811.195 |  2797.170 |  9861.330 |  9829.822 |
| Int32 | SumScalar             |       286.900 |   281.167 |   281.838 |   317.876 |   309.427 |
| Int32 | Sum128_Bcl            |               |           |           |   304.320 |   301.222 |
| Int32 | SumTraits             |       286.596 |  2311.209 |  2472.592 |  2917.343 |  4801.979 |
| Int32 | SumTraits_Args0       |       288.066 |  4185.430 |  3928.604 |  4934.590 |  4821.784 |
| Int32 | SumTraits_Args        |       270.249 |  1396.323 |  1401.742 |  4886.669 |  4806.886 |
| Int32 | SumKernelTraits       |       287.386 |  2677.394 |  3247.692 |  3953.573 |  4846.437 |
| Int32 | SumKernelTraits_Args0 |       286.724 |  3919.619 |  4182.617 |  4930.469 |  4852.808 |
| Int32 | SumKernelTraits_Args  |       270.724 |  1399.968 |  1395.953 |  4899.359 |  4853.093 |
| Int64 | SumScalar             |       448.592 |   440.758 |   444.884 |   552.061 |   534.531 |
| Int64 | Sum128_Bcl            |               |           |           |   708.356 |   692.663 |
| Int64 | SumTraits             |       190.913 |  1005.614 |  1064.650 |  1255.025 |  2448.365 |
| Int64 | SumTraits_Args0       |       426.809 |  2090.887 |  2100.527 |  2479.821 |  2451.574 |
| Int64 | SumTraits_Args        |       179.534 |   698.013 |   699.200 |  2457.898 |  2451.414 |
| Int64 | SumKernelTraits       |       448.065 |  1237.258 |  1412.876 |  1753.457 |  2434.096 |
| Int64 | SumKernelTraits_Args0 |       449.857 |  2101.411 |  1967.152 |  2469.054 |  2443.626 |
| Int64 | SumKernelTraits_Args  |       345.877 |   701.805 |   698.753 |  2456.761 |  2451.680 |
| SByte | SumScalar             |       665.739 |   664.224 |   658.168 |   834.224 |   803.566 |
| SByte | Sum128_Bcl            |               |           |           |   647.757 |   610.244 |
| SByte | SumTraits             |       680.590 | 13176.730 | 16739.161 | 19723.567 | 19531.685 |
| SByte | SumTraits_Args0       |       660.595 | 15704.393 | 15724.340 | 19723.852 | 19530.241 |
| SByte | SumTraits_Args        |       637.568 |  5597.644 |  5602.803 | 19605.289 | 19527.338 |
| SByte | SumKernelTraits       |       672.784 | 15604.597 | 16732.629 | 19692.571 | 19533.892 |
| SByte | SumKernelTraits_Args0 |       675.236 | 16718.959 | 15715.512 | 19729.144 | 19534.508 |
| SByte | SumKernelTraits_Args  |       642.795 |  5573.999 |  5598.168 | 19588.655 | 19538.006 |

说明:
- SumScalar: 使用标量算法.
- Sum128_Bcl: 使用BCL的方法(`Vector128.Shuffle`).
- SumTraits: 使用本库的普通方法(`Vectors.Shuffle`).
- SumTraits_Args0: 使用本库的 `Core` 后缀的方法(`Vectors.Shuffle_Args`, `Vectors.Shuffle_Core`), 不使用ValueTuple, 而是用“out”关键字返回多个值.
- SumTraits_Args: 使用本库的 `Core` 后缀的方法(`Vectors.Shuffle_Args`, `Vectors.Shuffle_Core`), 使用ValueTuple.
- SumKernelTraits: 使用本库的YShuffleKernel的普通方法(`Vectors.YShuffleKernel`).
- SumKernelTraits_Args0: 使用本库的YShuffleKernel的 `Core` 后缀的方法(`Vectors.YShuffleKernel_Args`, `Vectors.YShuffleKernel_Core`), 不使用ValueTuple, 而是用“out”关键字返回多个值.
- SumKernelTraits_Args: 使用本库的YShuffleKernel的 `Core` 后缀的方法(`Vectors.YShuffleKernel_Args`, `Vectors.YShuffleKernel_Core`), 使用ValueTuple.

BCL的方法(`Vector.Shuffle`) 在Arm平台运行时, 所有数字类型, 均没有硬件加速.
而本库对于这些数字类型, 会换成由其他指令组合实现的高效算法. 从 `.NET 5.0` 开始, 具有硬件加速.
注意在`.NET 7.0`之前, SumTraits_Args 有时与 SumTraits_Args0 的性能相差较大, 这是因为ValueTuple 在Arm下的性能损失较大.

### YNarrowSaturate
YNarrowSaturate: 将两个 Vector 实例饱和缩窄为一个 Vector .

#### YNarrowSaturate - X86 - AMD Ryzen 7 7840H
| Type   | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :----- | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| Int16  | SumNarrow_If          |        208.976 |       197.924 |       195.466 |   200.430 |   197.261 |   205.623 |   221.224 |
| Int16  | SumNarrow_MinMax      |        200.034 |       201.184 |       197.505 |   208.715 |   199.736 |   222.635 |   208.102 |
| Int16  | SumNarrowVectorBase   |      21160.119 |     19565.035 |     19063.346 | 19960.925 | 19532.398 | 19258.689 | 24197.090 |
| Int16  | SumNarrowVectorTraits |      20477.038 |     18251.731 |     44050.630 | 45196.128 | 43674.654 | 44677.389 | 47325.429 |
| Int32  | SumNarrow_If          |        211.070 |       218.235 |       225.479 |   211.761 |   207.353 |   223.740 |   232.860 |
| Int32  | SumNarrow_MinMax      |        221.396 |       206.735 |       214.815 |   214.341 |   211.238 |   210.944 |   223.415 |
| Int32  | SumNarrowVectorBase   |       9753.258 |      9549.313 |      9743.042 |  9519.188 |  9577.993 | 10513.071 | 12059.829 |
| Int32  | SumNarrowVectorTraits |       9117.869 |      9253.891 |     20503.088 | 20225.447 | 19198.947 | 19012.815 | 19398.087 |
| Int64  | SumNarrow_If          |        207.654 |       206.920 |       215.020 |   207.405 |   207.239 |   220.198 |   227.592 |
| Int64  | SumNarrow_MinMax      |        205.724 |       201.036 |       203.815 |   200.292 |   213.422 |   213.819 |   231.741 |
| Int64  | SumNarrowVectorBase   |       2951.264 |      2720.663 |      2835.882 |  2949.423 |  2915.473 |  4372.612 |  5917.536 |
| Int64  | SumNarrowVectorTraits |       2941.336 |      2696.543 |      4690.391 |  4875.851 |  4917.149 |  3808.744 |  9411.507 |
| UInt16 | SumNarrow_If          |       1263.960 |      1205.876 |      1247.409 |  1184.537 |  1124.520 |  1175.733 |  1387.128 |
| UInt16 | SumNarrow_MinMax      |       1363.298 |      1283.027 |      1336.103 |  1178.860 |  1344.978 |   761.908 |  1487.848 |
| UInt16 | SumNarrowVectorBase   |      25617.831 |     25358.182 |     25019.795 | 25056.656 | 26527.170 | 25337.769 | 30941.796 |
| UInt16 | SumNarrowVectorTraits |      24795.433 |     24950.279 |     33163.801 | 41303.846 | 40678.067 | 29966.481 | 45560.104 |
| UInt32 | SumNarrow_If          |       1446.297 |      1396.148 |      1364.953 |  1339.805 |  1382.470 |  1240.158 |  1507.078 |
| UInt32 | SumNarrow_MinMax      |       1461.884 |      1346.542 |      1363.853 |  1376.390 |  1373.016 |   960.104 |  1383.498 |
| UInt32 | SumNarrowVectorBase   |      12509.780 |     11160.711 |     11971.259 | 11511.978 | 11080.158 | 11897.237 | 15997.508 |
| UInt32 | SumNarrowVectorTraits |      12962.030 |     11581.014 |     14895.009 | 16343.372 | 17051.602 | 14727.107 | 19760.603 |
| UInt64 | SumNarrow_If          |       1003.570 |      1326.642 |       913.881 |   912.071 |   878.848 |  1312.352 |  1874.180 |
| UInt64 | SumNarrow_MinMax      |       1455.402 |      1404.391 |      1392.157 |   891.629 |   902.245 |   937.792 |   895.795 |
| UInt64 | SumNarrowVectorBase   |       3340.377 |      3102.954 |      3033.044 |  3449.113 |  3649.422 |  5104.550 |  7693.314 |
| UInt64 | SumNarrowVectorTraits |       3306.018 |      3050.492 |      4497.385 |  5401.914 |  5969.621 |  4527.588 |  9530.757 |

说明:
- SumNarrow_If: 基于if语句的标量算法.
- SumNarrow_MinMax: 基于Math类的 Min/Max 方法的标量算法.
- SumNarrowVectorBase: 使用本库的基础方法(`VectorTraitsBase.Statics.YNarrowSaturate`). 它是通过组合使用BCL的向量方法来实现的, 能够利用硬件加速.
- SumNarrowVectorTraits: 使用本库的特征方法(`Vectors.YNarrowSaturate`). 它是通过内在函数来实现的, 能获得更佳硬件加速.

对于 16~32位整数, 在 `.NET Core 3.1` 之后, SumNarrowVectorTraits的性能比SumNarrowVectorBase强很多. 这是因为 X86提供了专门的指令。
对于 64位整数（Int64/UInt64）, 虽然X86没有提供对应指令. 但由于 SumNarrowVectorTraits 版代码使用了更佳的内在函数算法, 所以在很多时候它的性能仍是比SumNarrowVectorBase 更强。

#### YNarrowSaturate - Arm - AWS Arm t4g.small
| Type   | Method                | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :----- | :-------------------- | ------------: | --------: | --------: | --------: | --------: |
| Int16  | SumNarrow_If          |       157.270 |   154.692 |   157.383 |   181.610 |   193.265 |
| Int16  | SumNarrow_MinMax      |       160.909 |   165.733 |   108.425 |   184.240 |   189.973 |
| Int16  | SumNarrowVectorBase   |      6100.275 |  6193.938 |  6308.118 |  7201.735 |  8261.974 |
| Int16  | SumNarrowVectorTraits |      6102.238 | 13460.358 | 13445.824 | 15514.261 | 13674.647 |
| Int32  | SumNarrow_If          |       163.854 |   165.352 |   165.160 |   190.240 |   213.807 |
| Int32  | SumNarrow_MinMax      |       154.976 |   162.019 |   161.884 |   195.349 |   194.881 |
| Int32  | SumNarrowVectorBase   |      3047.923 |  3268.933 |  3253.378 |  3532.128 |  4034.752 |
| Int32  | SumNarrowVectorTraits |      3125.498 |  6121.553 |  6162.533 |  7914.641 |  6782.358 |
| Int64  | SumNarrow_If          |       161.788 |   160.690 |   161.656 |   203.670 |   190.163 |
| Int64  | SumNarrow_MinMax      |       160.836 |   157.655 |   164.693 |   194.496 |   201.793 |
| Int64  | SumNarrowVectorBase   |       728.629 |  1157.104 |  1139.372 |  1231.877 |  1326.584 |
| Int64  | SumNarrowVectorTraits |       727.603 |  3114.720 |  3307.205 |  4088.677 |  3409.341 |
| UInt16 | SumNarrow_If          |       527.761 |   515.076 |   531.818 |   608.056 |   832.441 |
| UInt16 | SumNarrow_MinMax      |       573.087 |   525.410 |   576.628 |   608.744 |   893.594 |
| UInt16 | SumNarrowVectorBase   |      8361.120 |  8439.577 |  7945.486 |  8853.731 | 11829.808 |
| UInt16 | SumNarrowVectorTraits |      8307.680 | 13106.613 | 14179.297 | 13964.213 | 16532.648 |
| UInt32 | SumNarrow_If          |       537.550 |   534.718 |   539.467 |   620.874 |   989.646 |
| UInt32 | SumNarrow_MinMax      |       539.997 |   537.029 |   545.333 |   620.923 |   827.472 |
| UInt32 | SumNarrowVectorBase   |      4099.703 |  4021.154 |  3963.463 |  4356.804 |  5896.924 |
| UInt32 | SumNarrowVectorTraits |      4024.310 |  6340.994 |  6977.151 |  6619.009 |  7993.300 |
| UInt64 | SumNarrow_If          |       619.788 |   621.120 |   620.256 |   827.649 |   995.113 |
| UInt64 | SumNarrow_MinMax      |       619.494 |   620.151 |   620.119 |   818.259 |   994.695 |
| UInt64 | SumNarrowVectorBase   |      1229.723 |  1821.232 |  1848.632 |  1805.499 |  2169.309 |
| UInt64 | SumNarrowVectorTraits |      1228.911 |  3489.303 |  3526.548 |  3480.212 |  4100.727 |

说明:
- SumNarrow_If: 基于if语句的标量算法.
- SumNarrow_MinMax: 基于Math类的 Min/Max 方法的标量算法.
- SumNarrowVectorBase: 使用本库的基础方法(`VectorTraitsBase.Statics.YNarrowSaturate`). 它是通过组合使用BCL的向量方法来实现的, 能够利用硬件加速.
- SumNarrowVectorTraits: 使用本库的特征方法(`Vectors.YNarrowSaturate`). 它是通过内在函数来实现的, 能获得更佳硬件加速.

因为从 `.NET 5.0`开始，提供了 Arm的内在函数. 故从 `.NET 5.0` 开始, SumNarrowVectorTraits的性能比SumNarrowVectorBase强很多.

### YGroup3Unzip
YGroup3Unzip: 将3-元素组解交织为3个向量. 它能将3元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGB像素数据, 解交织为 R,G,B 平面数据 .

YGroup3UnzipX2: 将3-元素组解交织为3个向量, 且处理2倍数据.

#### YGroup3Unzip - X86 - AMD Ryzen 7 7840H
| Type  | Method        | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :---- | :------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| Byte  | SumBase_Basic |        255.172 |       496.713 |       501.725 |   499.601 |   566.925 |   505.052 |   670.702 |
| Byte  | SumBase       |       1140.616 |      1053.352 |      1089.103 |  1138.235 |  1111.114 |  1478.675 |  1463.708 |
| Byte  | SumTraits     |       1121.904 |      1086.799 |      7468.216 | 11280.246 | 11541.671 | 12438.171 | 21865.365 |
| Byte  | SumX2Base     |       2169.025 |      2088.353 |      2171.143 |  2111.332 |  2179.099 |  2812.575 |  2973.122 |
| Byte  | SumX2Traits   |       2229.977 |      2160.516 |     10419.951 | 10989.673 | 10985.330 | 11472.251 | 22393.695 |
| Int16 | SumBase_Basic |        213.465 |       389.617 |       439.760 |   352.833 |   453.870 |   404.842 |   533.252 |
| Int16 | SumBase       |        738.972 |       723.809 |       686.669 |   739.079 |   728.061 |  1015.709 |  1008.942 |
| Int16 | SumTraits     |        759.109 |       691.273 |      3767.055 |  5383.595 |  5638.094 |  6270.971 | 10452.168 |
| Int16 | SumX2Base     |       1327.217 |      1262.400 |      1260.547 |  1312.866 |  1288.727 |  1723.543 |  1761.102 |
| Int16 | SumX2Traits   |       1320.545 |      1227.530 |      6120.175 |  6190.444 |  6208.993 |  5798.718 | 10909.299 |
| Int32 | SumBase_Basic |        186.128 |       276.261 |       295.992 |   219.993 |   323.416 |   280.863 |   391.511 |
| Int32 | SumBase       |        184.001 |       273.403 |       306.846 |   224.431 |   320.332 |   551.148 |   555.068 |
| Int32 | SumTraits     |        189.108 |       277.059 |      6262.687 |  6454.641 |  6392.289 |  6488.127 |  6951.683 |
| Int32 | SumX2Base     |        155.218 |       257.316 |       284.894 |   247.659 |   318.492 |  1072.598 |  1093.091 |
| Int32 | SumX2Traits   |        160.252 |       253.319 |      5049.720 |  6341.390 |  6285.681 |  6215.097 |  7422.183 |
| Int64 | SumBase_Basic |        136.976 |       170.057 |       187.362 |   131.130 |   193.633 |   175.953 |   240.232 |
| Int64 | SumBase       |        135.652 |       170.323 |       187.933 |   125.485 |   192.634 |   168.300 |   238.422 |
| Int64 | SumTraits     |        135.704 |       167.900 |      4095.410 |  3868.199 |  4015.411 |  4061.920 |  4385.505 |
| Int64 | SumX2Base     |        108.319 |       151.252 |       178.444 |   137.145 |   182.990 |   155.501 |   243.663 |
| Int64 | SumX2Traits   |        109.441 |       151.243 |      2684.613 |  3883.237 |  3978.648 |  3893.358 |  4785.675 |

说明:
- SumBase_Basic: 使用标量算法.
- SumBase: 使用本库的基础方法(`VectorTraitsBase.Statics.YGroup3Unzip`). 它是通过组合使用BCL的向量方法来实现的, 能够利用硬件加速.
- SumTraits: 使用本库的特征方法(`Vectors.YGroup3Unzip`). 它是通过内在函数来实现的, 能获得更佳硬件加速.
- SumX2Base: 使用 `VectorTraitsBase.Statics.YGroup3UnzipX2`. 对于 8~16位整数, YGroup3UnzipX2 一般比 YGroup3Unzip 更快, 在早期版本的.NET下更明显.
- SumX2Traits: 使用 `Vectors.YGroup3UnzipX2`.

#### YGroup3Unzip - Arm - AWS Arm t4g.small
| Type  | Method        | .NET Core 3.1 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :---- | :------------ | ------------: | -------: | -------: | -------: |
| Byte  | SumBase_Basic |       263.957 |  265.524 |  327.819 |  381.159 |
| Byte  | SumBase       |       380.369 |  406.259 |  430.545 |  443.813 |
| Byte  | SumTraits     |       378.710 | 4381.575 | 4113.304 | 6510.157 |
| Byte  | SumX2Base     |       702.851 |  728.691 |  740.690 |  767.491 |
| Byte  | SumX2Traits   |       700.539 | 4412.785 | 4273.763 | 5294.112 |
| Int16 | SumBase_Basic |       188.885 |  189.823 |  222.856 |  279.398 |
| Int16 | SumBase       |       213.360 |  228.410 |  235.157 |  242.377 |
| Int16 | SumTraits     |       213.356 | 1926.559 | 2134.925 | 3037.124 |
| Int16 | SumX2Base     |       419.434 |  448.638 |  466.043 |  475.565 |
| Int16 | SumX2Traits   |       419.442 | 2413.794 | 2650.031 | 2638.161 |
| Int32 | SumBase_Basic |       138.088 |  143.089 |  154.241 |  196.818 |
| Int32 | SumBase       |       141.071 |  143.390 |  186.784 |  198.177 |
| Int32 | SumTraits     |       144.696 | 1033.899 | 1069.974 | 1494.205 |
| Int32 | SumX2Base     |       121.726 |  138.986 |  275.479 |  310.983 |
| Int32 | SumX2Traits   |       119.468 | 1598.185 | 1547.795 | 1618.239 |
| Int64 | SumBase_Basic |       109.766 |  100.523 |   84.039 |  189.270 |
| Int64 | SumBase       |       109.531 |  102.084 |   81.358 |  185.056 |
| Int64 | SumTraits     |       107.335 | 1153.333 | 1176.315 | 1191.362 |
| Int64 | SumX2Base     |        97.857 |   96.111 |   79.729 |  203.008 |
| Int64 | SumX2Traits   |        98.162 | 1216.716 | 1155.302 | 1374.619 |

### 更多结果
详见: [BenchmarkResults](articles/BenchmarkResults/AVector/README.md)

## 文档

- 特征方法列表: [TraitsMethodList](TraitsMethodList.md)
- 在线文档: https://zyl910.github.io/VectorTraits_doc/
- DocFX: 运行 `docfx_serve.bat`. 随后浏览  http://localhost:8080/ .
- Doxygen: 运行 Doxywizard, 点击菜单栏的 File->Open. 选择 `Doxyfile` 文件，并点击“OK”. 点击“Run”Tab, 点击“Run doxygen”按钮. 它会在“doc_gen”文件夹生成文档.

### 更多样例

- `VectorTraits.Sample.Benchmarks`(简单样例的基准测试): https://github.com/zyl910/VectorTraits.Sample.Benchmarks

## 变更日志

完整列表: [ChangeLog](ChangeLog.md)
