# VectorTraits (向量特征)
[English](README.md) | Chinese(中文)

VectorTraits: SIMD Vector type traits methods (SIMD向量类型的特征方法).

本库为向量类型提供了许多重要的算术方法(如 Shift, Shuffle, NarrowSaturate)及常数, 使您能更方便的编写跨平台的SIMD运算代码。它充分利用了 X86、Arm架构的内在函数实现硬件加速，且能够享受内联编译优化。

常用类型：
- `Vectors`: 为向量类型, 提供了常用工具函数, e.g. Create(T/T[]/Span/ReadOnlySpan), CreatePadding, CreateRotate, CreateByFunc, CreateByDouble ... 它还为向量提供了特征方法, e.g. ShiftLeft、ShiftRightArithmetic、ShiftRightLogical、Shuffle ...
- `Vectors<T>`: 为向量类型, 提供了各种元素类型的常数. e.g. Serial, SerialDesc, XyzwWMask, MantissaMask, MaxValue, MinValue, NormOne, FixedOne, E, Pi, Tau, VMaxByte, VReciprocalMaxSByte ...
- `Vector64s/Vector128s/Vector256s`: 为固定位宽的向量（Vector64/Vector128/Vector256），提供了常用工具函数与特征方法.
- `Vector64s<T>/Vector128s<T>/Vector256s<T>`: 为固定位宽的向量，提供了各种元素类型的常数.
- `Scalars`: 为标量类型, 提供了各种工具函数. e.g. GetByDouble, GetFixedByDouble, GetByBits, GetBitsMask ...
- `Scalars<T>`: 为标量类型, 提供了许多常数. e.g. ExponentBits, MantissaBits, MantissaMask, MaxValue, MinValue, NormOne, FixedOne, E, Pi, Tau, VMaxByte, VReciprocalMaxSByte ...
- `VectorTextUtil`: 提供了一些向量的文本性工具函数. e.g. GetHex, Format, WriteLine ...

特征方法:
- 支持 `.NET Standard 2.1` 新增的向量方法: ConvertToDouble, ConvertToInt32, ConvertToInt64, ConvertToSingle, ConvertToUInt32, ConvertToUInt64, Narrow, Widen .
- 支持 `.NET 5.0` 新增的向量方法: Ceiling, Floor .
- 支持 `.NET 6.0` 新增的向量方法: Sum .
- 支持 `.NET 7.0` 新增的向量方法: ExtractMostSignificantBits, Shuffle, ShiftLeft, ShiftRightArithmetic, ShiftRightLogical .
- 提供缩窄饱和的向量方法: YNarrowSaturate, YNarrowSaturateUnsigned .
- 提供舍入的向量方法: YRoundToEven, YRoundToZero .
- 提供换位的向量方法: YShuffleInsert, YShuffleKernel, YShuffleG2, YShuffleG4, YShuffleG4X2 . 且提供了 ShuffleControlG2/ShuffleControlG4 enum.
- ...
- 完整列表: [TraitsMethodList](TraitsMethodList.md)

支持的指令集:
- x86
  - 256位向量: Avx, Avx2 .
- Arm
  - 128位向量: AdvSimd .

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
![Vectors.ShiftLeft_use_inline.png](docs/Vectors.ShiftLeft_use_inline.png)

例2: 使用 `Vectors.ShiftLeft_Args` 与 `Vectors.ShiftLeft_Core`, 能将部分运算挪到循环外去提前处理. 例如在支持 Avx指令集的机器上运行时, 会在循环外设置好 `xmm1`, 随后在内循环的`vpsllw`指令里使用了它. 且这里展示了: 内联编译优化消除了冗余的 xmm/ymm 转换.
![Vectors.ShiftLeft_Core_use_inline.png](docs/Vectors.ShiftLeft_Core_use_inline.png)

## 入门指南
范例代码在 `samples/VectorTraits.Sample` 文件夹.

`Vectors` 类提供了许多方法, 例如 CreateRotate, ShiftLeft, Shuffle. 特征方法的清单见: [TraitsMethodList](TraitsMethodList.md)
泛型结构体 `Vectors<T>` 为常用常数提供了字段.

范例源代码如下。
```cs
using System;
using System.IO;
using System.Numerics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Sample {
    class Program {
        private static readonly TextWriter writer = Console.Out;
        static void Main(string[] args) {
            writer.WriteLine("VectorTraits.Sample");
            writer.WriteLine();
            VectorTraitsGlobal.Init(); // Initialization (初始化).
            TraitsOutput.OutputEnvironment(writer); // Output environment info (输出环境信息).
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
            Vector<short> desc = Vectors<short>.SerialDesc; // The generic structure 'Vectors<T>' provides fields for commonly used constants For example, 'SerialDesc' is a descending order value (泛型结构体 `Vectors<T>` 为常用常数提供了字段. 例如 `SerialDesc` 是降序的顺序值).
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

### X86 `.NET7.0`中的运行结果
程序: `VectorTraits.Sample`

```
VectorTraits.Sample

IsRelease:      True
EnvironmentVariable(PROCESSOR_IDENTIFIER):      Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:     8
Environment.Is64BitProcess:     True
Environment.OSVersion:  Microsoft Windows NT 10.0.19045.0
Environment.Version:    7.0.3
Stopwatch.Frequency:    10000000
RuntimeEnvironment.GetRuntimeDirectory: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.3\
RuntimeInformation.FrameworkDescription:        .NET 7.0.3
RuntimeInformation.OSArchitecture:      X64
RuntimeInformation.OSDescription:       Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:   win10-x64
IntPtr.Size:    8
BitConverter.IsLittleEndian:    True
Vector.IsHardwareAccelerated:   True
Vector<byte>.Count:     32      # 256bit
Vector<float>.Count:    8       # 256bit
VectorTraitsGlobal.InitCheckSum:        7960959 # 0x0079797F
Vector<T>.Assembly.CodeBase:    file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):  .NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):    .NET 7.0
Vectors.Instance:       VectorTraits256Avx2

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

注: `Vectors.Instance` 及之前的文本, 是`TraitsOutput.OutputEnvironment`输出的环境信息. 而从 `src` 开始的, 才是主要的测试代码.
因CPU支持X86的Avx2指令集, 于是 `Vector<byte>.Count` 为 32(256bit), `Vectors.Instance` 为 `VectorTraits256Avx2`.

### Arm `.NET7.0`中的运行结果
程序: `VectorTraits.Sample`

```
VectorTraits.Sample

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64

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
因CPU支持Arm的AdvSimd指令集, 于是 `Vector<byte>.Count` 为 16(128bit), `Vectors.Instance` 为 `VectorTraits128AdvSimdB64`.

### X86 `.NET Framework 4.5`中的运行结果
程序: `VectorTraits.Sample.NetFw`.

```
VectorTraits.Sample

IsRelease:      True
EnvironmentVariable(PROCESSOR_IDENTIFIER):      Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:     8
Environment.Is64BitProcess:     True
Environment.OSVersion:  Microsoft Windows NT 6.2.9200.0
Environment.Version:    4.0.30319.42000
Stopwatch.Frequency:    10000000
RuntimeEnvironment.GetRuntimeDirectory: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:        .NET Framework 4.8.9167.0
RuntimeInformation.OSArchitecture:      X64
RuntimeInformation.OSDescription:       Microsoft Windows 10.0.19045
IntPtr.Size:    8
BitConverter.IsLittleEndian:    True
Vector.IsHardwareAccelerated:   True
Vector<byte>.Count:     32      # 256bit
Vector<float>.Count:    8       # 256bit
VectorTraitsGlobal.InitCheckSum:        -25396097       # 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:    file:///E:/zylSelf/Code/cs/base/VectorTraits/samples/VectorTraits.Sample.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):  .NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):    .NET Framework 4.5
Vectors.Instance:       VectorTraits256Base

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
因CPU支持X86的Avx2指令集, 于是 `Vector<byte>.Count` 为 32(256bit). `Vectors.Instance` 为 `VectorTraits256Base`, 是因为 `.NET Framework` 不支持内在函数（Intrinsics Functions. 直到 `.NET Core 3.0` 才支持）.
且从 ShiftLeft_AcceleratedTypes 中的“Int16”可以看出, Int16类型的ShiftLeft方法是存在硬件加速的. 本库巧妙利用了其他向量方法, 实现了ShiftLeft的硬件加速.

## 基准测试结果
数据的单位: 百万次操作/秒. 数字越大, 性能越好.

### ShiftLeft
ShiftLeft: 将向量的每个元素左移指定量.
它是`.NET 7.0`所新增的向量方法.

#### ShiftLeft - x86 - lntel Core i5-8250U
| Type  | Method                 | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---- | :--------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| Byte  | SumSLLScalar           |        853.802 |       817.528 |      1104.993 |  1118.381 |  1374.255 |  1480.225 |
| Byte  | SumSLLNetBcl           |                |               |               |           |           |  1128.290 |
| Byte  | SumSLLNetBcl_Const     |                |               |               |           |           |  1137.564 |
| Byte  | SumSLLTraits           |       8296.682 |      8114.085 |     21811.573 | 19960.732 | 21044.192 | 23074.627 |
| Byte  | SumSLLTraits_Core      |      33328.333 |     35503.285 |     41644.146 | 35703.816 | 36615.138 | 32872.874 |
| Byte  | SumSLLConstTraits      |      10849.899 |     10168.754 |     25029.290 | 29761.737 | 33785.502 | 32862.094 |
| Byte  | SumSLLConstTraits_Core |      36537.668 |     31837.586 |     39307.523 | 35698.909 | 35679.744 | 33994.997 |
| Int16 | SumSLLScalar           |        823.668 |       806.395 |      1176.133 |  1183.966 |  1379.498 |  1486.900 |
| Int16 | SumSLLNetBcl           |                |               |               |           |           | 18445.571 |
| Int16 | SumSLLNetBcl_Const     |                |               |               |           |           | 19054.243 |
| Int16 | SumSLLTraits           |       5076.036 |      5047.453 |     16986.361 | 16653.329 | 16496.182 | 16114.543 |
| Int16 | SumSLLTraits_Core      |      20318.984 |     18959.033 |     20182.655 | 17683.717 | 18500.302 | 18439.182 |
| Int16 | SumSLLConstTraits      |       5899.256 |      5693.084 |     16944.673 | 19378.434 | 21059.682 | 19572.551 |
| Int16 | SumSLLConstTraits_Core |      20172.952 |     19339.311 |     18407.673 | 19850.711 | 21232.279 | 18136.492 |
| Int32 | SumSLLScalar           |        803.506 |       820.639 |      1307.614 |  1328.703 |  2199.685 |  1587.071 |
| Int32 | SumSLLNetBcl           |                |               |               |           |           |  9469.894 |
| Int32 | SumSLLNetBcl_Const     |                |               |               |           |           | 10657.900 |
| Int32 | SumSLLTraits           |       2571.456 |      2678.866 |      8246.402 |  7799.748 |  8221.382 |  9594.126 |
| Int32 | SumSLLTraits_Core      |       8574.361 |      8465.712 |     10320.833 | 10408.381 | 10626.910 | 10035.217 |
| Int32 | SumSLLConstTraits      |       1493.590 |      2922.103 |      8155.046 |  9293.148 | 10579.400 | 10185.431 |
| Int32 | SumSLLConstTraits_Core |       8467.974 |      8554.920 |      9784.699 | 10384.732 |  9790.898 | 10329.112 |
| Int64 | SumSLLScalar           |        797.703 |       816.504 |      1295.009 |  1305.611 |  2043.527 |  1535.809 |
| Int64 | SumSLLNetBcl           |                |               |               |           |           |  4143.077 |
| Int64 | SumSLLNetBcl_Const     |                |               |               |           |           |  4903.130 |
| Int64 | SumSLLTraits           |        426.950 |       458.517 |      3867.136 |  3941.999 |  3964.762 |  3713.754 |
| Int64 | SumSLLTraits_Core      |        441.378 |       463.537 |      4802.911 |  4813.018 |  4776.182 |  4653.104 |
| Int64 | SumSLLConstTraits      |        490.135 |       536.949 |      3929.109 |  4018.072 |  4725.293 |  4712.366 |
| Int64 | SumSLLConstTraits_Core |        491.263 |       531.946 |      4930.099 |  4737.462 |  4782.430 |  4371.649 |

说明:
- SumSLLScalar: 使用标量算法.
- SumSLLNetBcl: 使用BCL的方法(`Vector.ShiftLeft`), 参数是变量. 注意 `.NET 7.0` 才提供该方法.
- SumSLLNetBcl_Const: 使用BCL的方法(`Vector.ShiftLeft`), 参数是常量. 注意 `.NET 7.0` 才提供该方法.
- SumSLLTraits: 使用本库的普通方法(`Vectors.ShiftLeft`), 参数是变量.
- SumSLLTraits_Core: 使用本库的 `Core` 后缀的方法(`Vectors.ShiftLeft_Args`, `Vectors.ShiftLeft_Core`), 参数是变量.
- SumSLLConstTraits: 使用本库的 `Const` 后缀的方法(`Vectors.ShiftLeft_Const`), 参数是常量.
- SumSLLConstTraits_Core: 使用本库的 `ConstCore` 后缀的方法(`Vectors.ShiftLeft_Args`, `Vectors.ShiftLeft_ConstCore`), 参数是常量.

BCL的方法(`Vector.ShiftLeft`) 在X86平台运行时, 仅 Int16/Int32/Int64 有硬件加速, 而 Byte 没有硬件加速. 这是可能是因为 Avx2 指令集仅有 16~64位 的左移位指令, 未提供其他类型的指令, BCL便转为软件算法了.
而本库对于这些数字类型, 会换成由其他指令组合实现的高效算法. 例如对于 Byte类型, SumSLLConstTraits_Core 在`.NET 7.0`的值为“32872.874”, 性能是 标量算法的 `32872.874/1480.225≈22.2080` 倍, 且是BCL方法的 `32872.874/1137.564≈28.8976` 倍.
因为从 `.NET Core 3.0`开始, 才提供了 X86的内在函数. 故对于 Int64类型, 在 `.NET Core 3.0` 之后才有硬件加速.

对于ShiftLeft来说, 当参数`shiftAmount` 是常量时, 性能一般会比用变量时更高. 无论是 BCL还是本库的方法, 都是如此.
使用本库的 `Core` 后缀的方法,  能将部分运算挪到循环外去提前处理, 从而优化了性能. 而当 CPU提供了常数参数的指令时（专业术语是“立即数参数的指令”）, 该指令的性能一般会更高. 于是本库还提供了 `ConstCore` 后缀的方法, 会选择该平台最快的指令.
因“CPU睿频”、“其他进程抢占CPU资源”等因素, 有时性能波动比较大. 但请放心, 已经检查过了Release的程序运行时的汇编指令, 它已经是按最佳硬件指令运行的. 例如下图.
![Vectors.ShiftLeft_Core_use_inline.png](docs/Vectors.ShiftLeft_Core_use_inline.png)

#### ShiftLeft - Arm - AWS Arm t4g.small
| Type  | Method                 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---- | :--------------------- | ------------: | --------: | --------: | --------: |
| Byte  | SumSLLScalar           |       610.192 |   610.563 |   653.197 |   891.088 |
| Byte  | SumSLLNetBcl           |               |           |           | 19580.464 |
| Byte  | SumSLLNetBcl_Const     |               |           |           | 19599.073 |
| Byte  | SumSLLTraits           |      5668.036 | 13252.891 | 13253.575 | 13241.598 |
| Byte  | SumSLLTraits_Core      |     14341.895 | 15888.315 | 15887.520 | 19595.005 |
| Byte  | SumSLLConstTraits      |      9946.663 | 13243.304 | 15895.672 | 19466.408 |
| Byte  | SumSLLConstTraits_Core |     13201.657 | 15896.748 | 15894.093 | 19447.318 |
| Int16 | SumSLLScalar           |       606.942 |   607.226 |   607.742 |   765.154 |
| Int16 | SumSLLNetBcl           |               |           |           |  9332.186 |
| Int16 | SumSLLNetBcl_Const     |               |           |           |  9240.256 |
| Int16 | SumSLLTraits           |      4231.310 |  6553.072 |  6603.431 |  9351.061 |
| Int16 | SumSLLTraits_Core      |      7881.834 |  7897.878 |  8449.502 |  9356.142 |
| Int16 | SumSLLConstTraits      |      6577.829 |  6620.078 |  8444.304 |  9359.246 |
| Int16 | SumSLLConstTraits_Core |      8383.107 |  7923.119 |  8443.802 |  9317.663 |
| Int32 | SumSLLScalar           |       749.491 |   746.414 |   747.273 |  1403.533 |
| Int32 | SumSLLNetBcl           |               |           |           |  4537.804 |
| Int32 | SumSLLNetBcl_Const     |               |           |           |  4533.257 |
| Int32 | SumSLLTraits           |      3233.214 |  3531.441 |  3530.389 |  4545.497 |
| Int32 | SumSLLTraits_Core      |      3901.975 |  4140.171 |  4142.377 |  4505.555 |
| Int32 | SumSLLConstTraits      |      3510.471 |  3865.285 |  4134.108 |  4568.054 |
| Int32 | SumSLLConstTraits_Core |      3905.829 |  3895.898 |  3896.719 |  4547.294 |
| Int64 | SumSLLScalar           |       743.187 |   742.685 |   743.760 |  1372.299 |
| Int64 | SumSLLNetBcl           |               |           |           |  2473.172 |
| Int64 | SumSLLNetBcl_Const     |               |           |           |  2468.456 |
| Int64 | SumSLLTraits           |       482.056 |  1637.232 |  1640.547 |  1981.831 |
| Int64 | SumSLLTraits_Core      |       488.072 |  1970.152 |  2088.793 |  2468.202 |
| Int64 | SumSLLConstTraits      |       467.942 |  1958.432 |  2099.095 |  2460.619 |
| Int64 | SumSLLConstTraits_Core |       470.112 |  1971.898 |  2097.693 |  2465.419 |

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

#### ShiftRightArithmetic - x86 - lntel Core i5-8250U
| Type  | Method                 | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---- | :--------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| Int16 | SumSRAScalar           |        823.804 |       827.734 |      1180.933 |  1182.307 |  1341.171 |  1592.939 |
| Int16 | SumSRANetBcl           |                |               |               |           |           | 18480.038 |
| Int16 | SumSRANetBcl_Const     |                |               |               |           |           | 21052.686 |
| Int16 | SumSRATraits           |       1557.132 |      1559.674 |     17325.184 | 17699.944 | 16372.799 | 17193.661 |
| Int16 | SumSRATraits_Core      |       1653.816 |      1653.714 |     18414.632 | 19664.147 | 17938.068 | 18476.248 |
| Int16 | SumSRAConstTraits      |       1672.258 |      1675.044 |     17658.703 | 20409.889 | 20233.738 | 20835.294 |
| Int16 | SumSRAConstTraits_Core |       1714.582 |      1667.090 |     20076.043 | 20212.774 | 20994.717 | 21053.837 |
| Int32 | SumSRAScalar           |        825.056 |       829.789 |      1275.799 |  1342.349 |  1621.295 |  1620.315 |
| Int32 | SumSRANetBcl           |                |               |               |           |           | 10132.774 |
| Int32 | SumSRANetBcl_Const     |                |               |               |           |           | 11033.258 |
| Int32 | SumSRATraits           |        764.013 |       759.588 |      8195.470 |  8298.404 |  8314.921 |  9937.082 |
| Int32 | SumSRATraits_Core      |        826.612 |       825.854 |     10576.367 | 10449.535 |  9783.716 | 11108.074 |
| Int32 | SumSRAConstTraits      |        837.650 |       834.126 |      8484.959 |  9238.089 |  9979.236 | 10053.944 |
| Int32 | SumSRAConstTraits_Core |        856.397 |       859.426 |     10201.125 | 10314.334 | 11009.384 | 10772.948 |
| Int64 | SumSRAScalar           |        815.238 |       811.645 |      1300.052 |  1280.982 |  1322.441 |  1602.916 |
| Int64 | SumSRANetBcl           |                |               |               |           |           |   578.499 |
| Int64 | SumSRANetBcl_Const     |                |               |               |           |           |   553.963 |
| Int64 | SumSRATraits           |        447.196 |       441.690 |      3032.903 |  2830.935 |  2988.130 |  2922.851 |
| Int64 | SumSRATraits_Core      |        459.781 |       458.269 |      3639.092 |  3352.255 |  3336.974 |  3488.018 |
| Int64 | SumSRAConstTraits      |        491.449 |       491.420 |      3074.926 |  2820.864 |  3365.642 |  3397.660 |
| Int64 | SumSRAConstTraits_Core |        496.174 |       491.022 |      3660.380 |  3365.210 |  3398.657 |  3237.150 |
| SByte | SumSRAScalar           |        827.231 |       823.643 |      1101.518 |  1105.244 |  1348.340 |  1619.984 |
| SByte | SumSRANetBcl           |                |               |               |           |           |  1161.428 |
| SByte | SumSRANetBcl_Const     |                |               |               |           |           |  1156.552 |
| SByte | SumSRATraits           |       3108.569 |      3100.703 |     17944.555 | 17103.399 | 17926.975 | 20115.939 |
| SByte | SumSRATraits_Core      |       3298.491 |      3288.742 |     30742.095 | 30212.469 | 29604.498 | 33040.654 |
| SByte | SumSRAConstTraits      |       3320.813 |      3327.910 |     18297.669 | 25989.446 | 28437.425 | 31118.235 |
| SByte | SumSRAConstTraits_Core |       3423.868 |      3427.681 |     29454.032 | 27559.316 | 30075.338 | 30565.076 |

说明:
- SumSRAScalar: 使用标量算法.
- SumSRANetBcl: 使用BCL的方法(`Vector.ShiftRightArithmetic`), 参数是变量. 注意 `.NET 7.0` 才提供该方法.
- SumSRANetBcl_Const: 使用BCL的方法(`Vector.ShiftRightArithmetic`), 参数是常量. 注意 `.NET 7.0` 才提供该方法.
- SumSRATraits: 使用本库的普通方法(`Vectors.ShiftRightArithmetic`), 参数是变量.
- SumSRATraits_Core: 使用本库的 `Core` 后缀的方法(`Vectors.ShiftRightArithmetic_Args`, `Vectors.ShiftRightArithmetic_Core`), 参数是变量.
- SumSRAConstTraits: 使用本库的 `Const` 后缀的方法(`Vectors.ShiftRightArithmetic_Const`), 参数是常量.
- SumSRAConstTraits_Core: 使用本库的 `ConstCore` 后缀的方法(`Vectors.ShiftRightArithmetic_Args`, `Vectors.ShiftRightArithmetic_ConstCore`), 参数是常量.

BCL的方法(`Vector.ShiftRightArithmetic`) 在X86平台运行时, 仅 Int16/Int32 有硬件加速, 而 SByte/Int64 没有硬件加速. 这是可能是因为 Avx2 指令集仅有 16~32位 的算术右移位指令.
而本库对于这些数字类型, 会换成由其他指令组合实现的高效算法. 从 `.NET Core 3.0` 开始, 具有硬件加速.

#### ShiftRightArithmetic - Arm - AWS Arm t4g.small
| Type  | Method                 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---- | :--------------------- | ------------: | --------: | --------: | --------: |
| Int16 | SumSRAScalar           |       587.279 |   541.166 |   607.230 |   822.580 |
| Int16 | SumSRANetBcl           |               |           |           |  9941.333 |
| Int16 | SumSRANetBcl_Const     |               |           |           |  9938.477 |
| Int16 | SumSRATraits           |      1559.138 |  4950.480 |  5645.497 |  9938.217 |
| Int16 | SumSRATraits_Core      |      1823.509 |  8388.956 |  7904.366 |  9938.584 |
| Int16 | SumSRAConstTraits      |      1808.965 |  6589.881 |  7892.407 |  9871.343 |
| Int16 | SumSRAConstTraits_Core |      1810.527 |  8392.943 |  7896.220 |  9925.543 |
| Int32 | SumSRAScalar           |       712.668 |   746.666 |   747.055 |  1188.551 |
| Int32 | SumSRANetBcl           |               |           |           |  4861.897 |
| Int32 | SumSRANetBcl_Const     |               |           |           |  4859.816 |
| Int32 | SumSRATraits           |       779.787 |  2944.169 |  2945.026 |  4868.865 |
| Int32 | SumSRATraits_Core      |       914.346 |  4125.748 |  4135.353 |  4862.075 |
| Int32 | SumSRAConstTraits      |       884.914 |  3266.272 |  3892.016 |  4841.364 |
| Int32 | SumSRAConstTraits_Core |       920.389 |  4134.164 |  3893.088 |  4844.364 |
| Int64 | SumSRAScalar           |       717.640 |   742.361 |   742.337 |  1189.925 |
| Int64 | SumSRANetBcl           |               |           |           |  2468.196 |
| Int64 | SumSRANetBcl_Const     |               |           |           |  2471.434 |
| Int64 | SumSRATraits           |       451.956 |  1235.429 |  1233.818 |  1420.116 |
| Int64 | SumSRATraits_Core      |       435.180 |  1972.734 |  1966.992 |  2465.932 |
| Int64 | SumSRAConstTraits      |       437.799 |  1962.084 |  1966.946 |  2470.825 |
| Int64 | SumSRAConstTraits_Core |       436.419 |  2099.303 |  2097.296 |  2469.149 |
| SByte | SumSRAScalar           |       577.766 |   610.669 |   672.786 |   925.515 |
| SByte | SumSRANetBcl           |               |           |           | 19792.701 |
| SByte | SumSRANetBcl_Const     |               |           |           | 19792.641 |
| SByte | SumSRATraits           |      2991.228 | 11281.229 | 11275.758 | 11356.994 |
| SByte | SumSRATraits_Core      |      3529.326 | 16818.297 | 16827.844 | 19798.924 |
| SByte | SumSRAConstTraits      |      3476.138 | 15680.873 | 16829.920 | 19774.470 |
| SByte | SumSRAConstTraits_Core |      3577.927 | 16813.202 | 15762.243 | 19759.552 |

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

#### Shuffle - x86 - lntel Core i5-8250U
| Type  | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---- | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| Int16 | SumScalar             |       1009.132 |      1007.748 |       992.299 |  1004.370 |  1034.912 |   989.043 |
| Int16 | Sum256_Bcl            |                |               |               |           |           |   775.841 |
| Int16 | SumTraits             |       1012.626 |      1008.900 |      6025.629 |  8058.075 |  8017.278 |  9060.106 |
| Int16 | SumTraits_Args0       |       1008.925 |       988.646 |     14845.370 | 14590.246 | 14413.193 | 14209.436 |
| Int16 | SumTraits_Args        |       1008.981 |       991.790 |     14644.219 | 14527.035 | 14198.718 | 14024.591 |
| Int16 | SumKernelTraits       |       1011.528 |      1009.289 |      7566.266 |  9381.227 |  9585.573 | 10330.592 |
| Int16 | SumKernelTraits_Args0 |       1006.331 |       989.488 |     15045.753 | 14575.460 | 14464.147 | 14484.413 |
| Int16 | SumKernelTraits_Args  |       1017.264 |       990.161 |     14900.553 | 13672.167 | 14556.627 | 14280.139 |
| Int32 | SumScalar             |        723.019 |       725.013 |       704.809 |   708.372 |   735.378 |   747.651 |
| Int32 | Sum256_Bcl            |                |               |               |           |           |   611.393 |
| Int32 | SumTraits             |        716.509 |       724.369 |      5216.757 |  5813.206 |  7139.337 |  9250.625 |
| Int32 | SumTraits_Args0       |        716.520 |       703.636 |      9278.507 |  9221.310 |  9159.683 |  9728.639 |
| Int32 | SumTraits_Args        |        722.854 |       709.654 |      9010.834 |  9164.854 |  8992.356 |  9828.623 |
| Int32 | SumKernelTraits       |        722.441 |       725.218 |      9554.766 |  7064.711 |  6932.192 |  9996.960 |
| Int32 | SumKernelTraits_Args0 |        724.689 |       706.345 |     11017.874 | 11092.301 | 11134.924 | 11279.116 |
| Int32 | SumKernelTraits_Args  |        727.981 |       701.155 |     11030.886 | 10970.116 | 10510.208 | 11324.558 |
| Int64 | SumScalar             |        459.881 |       457.952 |       188.562 |   477.806 |   459.242 |   462.021 |
| Int64 | Sum256_Bcl            |                |               |               |           |           |   515.863 |
| Int64 | SumTraits             |        459.302 |       459.876 |      2143.129 |  2518.325 |  2433.449 |  3524.309 |
| Int64 | SumTraits_Args0       |        465.064 |       441.576 |      4508.754 |  4449.098 |  4406.994 |  4484.512 |
| Int64 | SumTraits_Args        |        459.786 |       408.545 |      4466.028 |  4214.808 |  4293.438 |  4270.565 |
| Int64 | SumKernelTraits       |        460.058 |       458.858 |      2702.105 |  3195.810 |  1714.735 |  4046.124 |
| Int64 | SumKernelTraits_Args0 |        464.705 |       438.224 |      4820.767 |  4705.843 |  4042.262 |  4882.344 |
| Int64 | SumKernelTraits_Args  |        463.218 |       411.905 |      4884.277 |  5433.558 |  4140.529 |  4788.233 |
| SByte | SumScalar             |       1263.210 |      1262.732 |       844.749 |  1013.924 |  1077.513 |  1261.932 |
| SByte | Sum256_Bcl            |                |               |               |           |           |   930.329 |
| SByte | SumTraits             |       1264.393 |      1264.667 |     13239.408 | 17766.242 | 16140.964 | 24537.440 |
| SByte | SumTraits_Args0       |       1262.368 |      1242.503 |     31793.487 | 31423.344 | 31314.488 | 34322.789 |
| SByte | SumTraits_Args        |       1221.542 |      1248.121 |     31118.400 | 31615.120 | 31980.794 | 33156.240 |
| SByte | SumKernelTraits       |       1260.097 |      1266.056 |     19996.806 | 23032.250 | 23853.314 | 29612.169 |
| SByte | SumKernelTraits_Args0 |       1260.461 |      1245.530 |     31084.955 | 30974.022 | 31913.287 | 33643.052 |
| SByte | SumKernelTraits_Args  |       1260.272 |      1249.316 |     30827.152 | 30734.831 | 32311.418 | 32977.071 |

说明:
- SumScalar: 使用标量算法.
- Sum256_Bcl: 使用BCL的方法(`Vector256.Shuffle`).
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
| Type  | Method                | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---- | :-------------------- | ------------: | --------: | --------: | --------: |
| Int16 | SumScalar             |       424.835 |   422.286 |   423.070 |   526.071 |
| Int16 | Sum128_Bcl            |               |           |           |   482.320 |
| Int16 | SumTraits             |       423.942 |  4925.034 |  4938.077 |  5853.245 |
| Int16 | SumTraits_Args0       |       423.872 |  8381.395 |  7862.055 |  9821.786 |
| Int16 | SumTraits_Args        |       400.767 |  2982.755 |  2976.138 |  9769.321 |
| Int16 | Sum128_AdvSimd        |               |  3169.036 |  3115.859 |  3239.207 |
| Int16 | SumKernelTraits       |       424.317 |  5644.808 |  6565.519 |  7904.834 |
| Int16 | SumKernelTraits_Args0 |       423.899 |  7881.823 |  7847.868 |  9835.768 |
| Int16 | SumKernelTraits_Args  |       399.772 |  2982.013 |  2868.286 |  9778.383 |
| Int32 | SumScalar             |       288.211 |   281.081 |   276.668 |   317.268 |
| Int32 | Sum128_Bcl            |               |           |           |   303.702 |
| Int32 | SumTraits             |       287.942 |  2447.812 |  2561.501 |  2912.918 |
| Int32 | SumTraits_Args0       |       286.646 |  4103.084 |  4110.550 |  4796.704 |
| Int32 | SumTraits_Args        |       268.613 |  1487.180 |  1483.994 |  4775.891 |
| Int32 | SumKernelTraits       |       287.900 |  2805.355 |  3237.345 |  3909.519 |
| Int32 | SumKernelTraits_Args0 |       286.556 |  4112.689 |  4128.402 |  4825.180 |
| Int32 | SumKernelTraits_Args  |       268.858 |  1487.021 |  1430.400 |  4755.708 |
| Int64 | SumScalar             |       378.628 |   188.199 |   447.044 |   552.523 |
| Int64 | Sum128_Bcl            |               |           |           |   712.025 |
| Int64 | SumTraits             |       379.643 |  1015.811 |  1089.628 |  1242.552 |
| Int64 | SumTraits_Args0       |       380.133 |  2091.948 |  1967.766 |  2465.800 |
| Int64 | SumTraits_Args        |       326.603 |   743.033 |   744.908 |  2452.967 |
| Int64 | SumKernelTraits       |       379.696 |  1221.923 |  1480.182 |  1756.478 |
| Int64 | SumKernelTraits_Args0 |       379.788 |  2096.124 |  2095.536 |  2464.674 |
| Int64 | SumKernelTraits_Args  |       170.957 |   715.532 |   717.549 |  2457.398 |
| SByte | SumScalar             |       668.450 |   650.673 |   659.984 |   833.921 |
| SByte | Sum128_Bcl            |               |           |           |   648.985 |
| SByte | SumTraits             |       667.527 | 13135.356 | 16713.009 | 19730.059 |
| SByte | SumTraits_Args0       |       664.988 | 15734.264 | 15708.758 | 19741.441 |
| SByte | SumTraits_Args        |       625.410 |  5723.523 |  5948.766 | 19692.665 |
| SByte | SumKernelTraits       |       667.280 | 15584.505 | 15643.225 | 19741.523 |
| SByte | SumKernelTraits_Args0 |       664.914 | 16731.942 | 16685.534 | 19726.599 |
| SByte | SumKernelTraits_Args  |       625.761 |  5723.910 |  5950.549 | 19685.073 |

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

### Multiply
Multiply: 将两个向量相乘来计算它们各元素的积.

#### Multiply - x86 - lntel Core i5-8250U
| Type   | Method    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :----- | :-------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| Double | SumScalar |       1600.703 |      1632.773 |      1611.595 |  1642.460 |  1249.202 |  1358.019 |
| Double | SumBcl    |       6284.448 |      6189.051 |      6102.798 |  6587.568 |  5658.033 |  5055.220 |
| Double | SumTraits |       6506.623 |      6418.409 |      5944.404 |  6428.924 |  5751.874 |  5190.834 |
| Int16  | SumScalar |       1680.612 |      1658.796 |      1683.030 |  1685.798 |  1190.349 |  1553.884 |
| Int16  | SumBcl    |      28756.603 |     27777.105 |     28163.609 | 26379.883 | 22013.923 | 23065.311 |
| Int16  | SumTraits |      28711.354 |     25955.926 |     26610.600 | 26887.192 | 21145.370 | 22954.619 |
| Int32  | SumScalar |       2014.740 |      1967.770 |      2005.266 |  1976.627 |  1290.147 |  1907.866 |
| Int32  | SumBcl    |      12475.013 |     12445.946 |     10239.998 | 12688.560 | 10083.688 | 11056.881 |
| Int32  | SumTraits |      12495.143 |     12543.215 |     11114.444 | 12563.478 | 10617.979 | 10782.628 |
| SByte  | SumScalar |       1680.166 |      1654.827 |      1673.627 |  1534.960 |  1522.136 |  1567.444 |
| SByte  | SumBcl    |       1104.475 |      1287.646 |      1250.073 |  1763.937 |  1818.500 |  1716.780 |
| SByte  | SumTraits |       1100.749 |      1298.894 |     25183.529 | 23727.417 | 20322.526 | 25706.158 |
| Single | SumScalar |       1675.948 |      1677.392 |      1669.507 |  1652.659 |  1352.087 |  1681.432 |
| Single | SumBcl    |      13204.865 |     13118.285 |     12646.910 | 12720.198 | 10365.531 | 13337.825 |
| Single | SumTraits |      13250.074 |     12086.453 |     12041.076 | 12375.944 | 10273.737 | 13248.124 |
| UInt32 | SumScalar |       1997.307 |      1995.796 |      2009.839 |  2007.057 |  1452.694 |  2181.241 |
| UInt32 | SumBcl    |        584.143 |       768.549 |       819.057 |  1128.172 | 10337.032 | 12342.446 |
| UInt32 | SumTraits |      13909.507 |     12848.825 |     12920.682 | 12450.954 | 10552.328 | 12985.813 |
| UInt64 | SumScalar |       1830.579 |      1774.180 |      1833.726 |  1826.332 |  1613.602 |  1946.179 |
| UInt64 | SumBcl    |        324.010 |       487.569 |       507.394 |   655.983 |   878.917 |  1020.305 |
| UInt64 | SumTraits |        328.584 |       494.795 |      3510.915 |  3676.509 |  3023.884 |  3612.814 |

说明:
- SumScalar: 使用标量算法.
- SumBcl: 使用BCL的方法(`Vector.Multiply`).
- SumTraits: 使用本库的方法(`Vectors.Multiply`).

`Vector<T> 结构`的早期文档里说, 仅4种类型(Single, Double, Int16, Int32)支持乘法的硬件加速. SumBcl的测试结果验证了这一点, 直至`.NET 5.0`, 只有那4种类型支持硬件加速.
按照二进制补码的规则, 无符号乘法结果的低半部分, 与带符号乘法结果的低半部分其实是相同的. 于是在 `.NET 6.0`之后, BCL方法(`Vector.Multiply`) 对 UInt16/UInt32 也提供了硬件加速. 但BCL对于 SByte/Byte/Int64/UInt64, X86下仍不支持硬件加速.
而本库对于这些数字类型, 会换成由其他指令组合实现的高效算法. 从 `.NET Core 3.0` 开始, 具有硬件加速.

#### Multiply - Arm - AWS Arm t4g.small
| Type   | Method    | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :----- | :-------- | ------------: | --------: | --------: | --------: |
| Double | SumScalar |       765.649 |   766.031 |   758.644 |  1014.141 |
| Double | SumBcl    |      3833.182 |  3822.467 |  3179.536 |  3657.731 |
| Double | SumTraits |      3809.391 |  3251.397 |  3174.551 |  3663.085 |
| Int16  | SumScalar |       650.489 |   650.396 |   643.146 |  1017.731 |
| Int16  | SumBcl    |     12744.213 | 12510.831 | 12356.476 | 19315.192 |
| Int16  | SumTraits |     12752.871 | 12530.809 | 13142.016 | 19287.033 |
| Int32  | SumScalar |       719.822 |   720.207 |   715.185 |  1417.429 |
| Int32  | SumBcl    |      6445.950 |  5984.031 |  6002.410 |  8699.250 |
| Int32  | SumTraits |      6107.703 |  6445.327 |  5897.187 |  8675.644 |
| SByte  | SumScalar |       777.348 |   777.209 |   771.615 |  1182.606 |
| SByte  | SumBcl    |     27273.217 | 27168.474 | 26008.455 | 37928.181 |
| SByte  | SumTraits |     27374.533 | 26883.131 | 26265.614 | 37845.492 |
| Single | SumScalar |       826.930 |   795.700 |   816.759 |  1240.768 |
| Single | SumBcl    |      6616.223 |  6508.489 |  6365.412 |  8544.382 |
| Single | SumTraits |      6643.543 |  6033.227 |  6395.990 |  8584.911 |
| UInt32 | SumScalar |       720.362 |   721.428 |   714.216 |  1419.062 |
| UInt32 | SumBcl    |      7292.554 |  7283.484 |  6303.880 |  6890.616 |
| UInt32 | SumTraits |      6288.001 |  6251.358 |  6233.388 |  6903.825 |
| UInt64 | SumScalar |       328.914 |   673.337 |   669.157 |  1105.758 |
| UInt64 | SumBcl    |       383.406 |   715.446 |   978.539 |  1114.218 |
| UInt64 | SumTraits |       383.557 |  1141.141 |  1128.562 |  1112.795 |

说明:
- SumScalar: 使用标量算法.
- SumBcl: 使用BCL的方法(`Vector.Multiply`).
- SumTraits: 使用本库的方法(`Vectors.Multiply`).

BCL的方法(`Vector.Shuffle`) 在Arm平台运行时, 不仅对4种类型(Single, Double, Int16, Int32)有硬件加速, 且对 “SByte, UInt32”等类型有硬件加速 . 只是64位整数的性能不佳, 直到 `.NET 7.0` 才修正了它的性能问题.
而本库对于64位整数, 会换成由其他指令组合实现的高效算法. 从 `.NET 5.0` 开始, 具有硬件加速.

### YNarrowSaturate
YNarrowSaturate: 将两个 Vector 实例饱和缩窄为一个 Vector .

#### YNarrowSaturate - x86 - lntel Core i5-8250U
| Type   | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :----- | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| Int16  | SumNarrow_If          |        209.442 |       209.620 |       210.928 |   199.480 |   211.138 |   215.694 |
| Int16  | SumNarrow_MinMax      |        202.714 |       215.451 |       212.224 |   214.893 |   175.099 |   219.752 |
| Int16  | SumNarrowVectorBase   |      13095.098 |     13774.472 |     13161.165 | 13013.472 | 13168.239 | 15964.293 |
| Int16  | SumNarrowVectorTraits |      13024.364 |     13662.396 |     28118.834 | 25049.004 | 28198.282 | 27819.176 |
| Int32  | SumNarrow_If          |        210.834 |       212.404 |       213.735 |   214.810 |   208.985 |   222.597 |
| Int32  | SumNarrow_MinMax      |        212.099 |       211.786 |       210.670 |   205.029 |   210.333 |   208.573 |
| Int32  | SumNarrowVectorBase   |       6933.036 |      6441.062 |      6584.000 |  7382.254 |  6728.319 |  7703.530 |
| Int32  | SumNarrowVectorTraits |       6856.456 |      6398.525 |     12533.505 | 14263.835 | 12888.771 | 13992.887 |
| Int64  | SumNarrow_If          |        195.128 |       186.841 |       195.864 |   199.460 |   193.475 |   204.264 |
| Int64  | SumNarrow_MinMax      |        189.209 |       178.971 |       196.065 |   191.231 |   191.600 |   203.201 |
| Int64  | SumNarrowVectorBase   |       1959.806 |      1878.724 |      2000.976 |  2118.858 |  1976.264 |  2658.885 |
| Int64  | SumNarrowVectorTraits |       1956.908 |      1872.465 |      2587.636 |  2763.282 |  2689.931 |  2418.496 |
| UInt16 | SumNarrow_If          |       1066.840 |       902.516 |      1078.540 |   974.749 |  1067.768 |  1083.124 |
| UInt16 | SumNarrow_MinMax      |       1066.895 |       903.120 |       901.484 |   959.577 |   900.228 |   823.878 |
| UInt16 | SumNarrowVectorBase   |      16884.658 |     17052.914 |     15147.602 | 17094.243 | 17200.043 | 19717.119 |
| UInt16 | SumNarrowVectorTraits |      16862.587 |     16975.925 |     21142.034 | 26121.170 | 26440.908 | 24575.123 |
| UInt32 | SumNarrow_If          |       1116.417 |       961.764 |       856.272 |   901.272 |   872.811 |  1111.046 |
| UInt32 | SumNarrow_MinMax      |       1115.502 |       902.014 |       900.357 |   877.358 |   839.361 |   854.364 |
| UInt32 | SumNarrowVectorBase   |       7824.674 |      7015.984 |      8617.594 |  8176.926 |  8059.923 |  8801.283 |
| UInt32 | SumNarrowVectorTraits |       7879.556 |      7024.438 |     12181.180 | 10713.260 | 11063.765 | 11314.953 |
| UInt64 | SumNarrow_If          |        997.327 |       847.431 |       871.820 |   875.547 |   858.060 |  1109.023 |
| UInt64 | SumNarrow_MinMax      |        865.420 |      1083.437 |      1107.671 |  1095.561 |   886.387 |   735.609 |
| UInt64 | SumNarrowVectorBase   |       2015.328 |      1971.981 |      1833.610 |  2446.346 |  2636.137 |  3336.732 |
| UInt64 | SumNarrowVectorTraits |       2020.405 |      1979.078 |      2918.828 |  3258.796 |  3341.184 |  3108.173 |

说明:
- SumNarrow_If: 基于if语句的标量算法.
- SumNarrow_MinMax: 基于Math类的 Min/Max 方法的标量算法.
- SumNarrowVectorBase: 使用本库的基础方法(`VectorTraitsBase.Statics.YNarrowSaturate`). 它是通过组合使用BCL的向量方法来实现的, 能够利用硬件加速.
- SumNarrowVectorTraits: 使用本库的特征方法(`Vectors.YNarrowSaturate`). 它是通过内在函数来实现的, 能获得更佳硬件加速.

对于 16~32位整数, 在 `.NET Core 3.1` 之后, SumNarrowVectorTraits的性能比SumNarrowVectorBase强很多. 这是因为 X86提供了专门的指令。
对于 64位整数（Int64/UInt64）, 虽然X86没有提供对应指令. 但由于 SumNarrowVectorTraits 版代码使用了更佳的内在函数算法, 所以在很多时候它的性能仍是比SumNarrowVectorBase 更强。

#### YNarrowSaturate - Arm - AWS Arm t4g.small
| Type   | Method                | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :----- | :-------------------- | ------------: | --------: | --------: | --------: |
| Int16  | SumNarrow_If          |       154.717 |   163.350 |   157.517 |   181.894 |
| Int16  | SumNarrow_MinMax      |       160.654 |   161.130 |   108.656 |   184.712 |
| Int16  | SumNarrowVectorBase   |      6124.516 |  5210.880 |  6055.721 |  7165.511 |
| Int16  | SumNarrowVectorTraits |      6125.113 | 13574.329 | 13433.471 | 15507.867 |
| Int32  | SumNarrow_If          |       163.905 |   165.250 |   160.416 |   190.897 |
| Int32  | SumNarrow_MinMax      |       155.399 |   155.059 |   159.092 |   195.986 |
| Int32  | SumNarrowVectorBase   |      2701.810 |  3219.290 |  2766.267 |  3025.432 |
| Int32  | SumNarrowVectorTraits |      2703.709 |  6306.022 |  6210.719 |  8003.142 |
| Int64  | SumNarrow_If          |       161.985 |   162.089 |   160.805 |   205.371 |
| Int64  | SumNarrow_MinMax      |       154.244 |   153.980 |   165.349 |   197.005 |
| Int64  | SumNarrowVectorBase   |       716.880 |  1189.192 |  1156.627 |  1229.301 |
| Int64  | SumNarrowVectorTraits |       716.661 |  3282.455 |  3283.969 |  3921.550 |
| UInt16 | SumNarrow_If          |       525.100 |   530.550 |   525.952 |   608.947 |
| UInt16 | SumNarrow_MinMax      |       528.430 |   527.506 |   539.088 |   609.259 |
| UInt16 | SumNarrowVectorBase   |      7945.777 |  8739.615 |  7945.913 |  8916.311 |
| UInt16 | SumNarrowVectorTraits |      7943.115 | 14158.586 | 14166.207 | 13814.007 |
| UInt32 | SumNarrow_If          |       544.871 |   540.266 |   538.649 |   621.107 |
| UInt32 | SumNarrow_MinMax      |       541.719 |   536.718 |   535.769 |   621.414 |
| UInt32 | SumNarrowVectorBase   |      4001.590 |  4022.504 |  3954.723 |  4379.473 |
| UInt32 | SumNarrowVectorTraits |      4018.815 |  6824.637 |  6400.947 |  6722.416 |
| UInt64 | SumNarrow_If          |       620.408 |   620.900 |   622.076 |   828.917 |
| UInt64 | SumNarrow_MinMax      |       620.012 |   619.806 |   622.201 |   828.565 |
| UInt64 | SumNarrowVectorBase   |      1291.051 |  1863.543 |  1869.904 |  1816.732 |
| UInt64 | SumNarrowVectorTraits |      1293.997 |  3233.726 |  3491.369 |  3501.256 |

说明:
- SumNarrow_If: 基于if语句的标量算法.
- SumNarrow_MinMax: 基于Math类的 Min/Max 方法的标量算法.
- SumNarrowVectorBase: 使用本库的基础方法(`VectorTraitsBase.Statics.YNarrowSaturate`). 它是通过组合使用BCL的向量方法来实现的, 能够利用硬件加速.
- SumNarrowVectorTraits: 使用本库的特征方法(`Vectors.YNarrowSaturate`). 它是通过内在函数来实现的, 能获得更佳硬件加速.

因为从 `.NET 5.0`开始，提供了 Arm的内在函数. 故从 `.NET 5.0` 开始, SumNarrowVectorTraits的性能比SumNarrowVectorBase强很多.

### 更多结果
详见: [BenchmarkResults](docs/BenchmarkResults/AVector/README.md)

## 变更日志

完整列表: [ChangeLog](ChangeLog.md)
