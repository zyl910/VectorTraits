# VectorTraits
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
- 提供换位的向量方法: YShuffleEach128, YShuffleInsert, YShuffleInsertEach128, YShuffleG4, YShuffleG4X2 . Also provides ShuffleControlG4 classes.
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

## 范例
范例代码在 `samples/VectorTraits.Sample` 文件夹.
源代码如下。
```cs
using System;
using System.IO;
using System.Numerics;

namespace Zyl.VectorTraits.Sample {
    class Program {
        private static readonly TextWriter writer = Console.Out;
        static void Main(string[] args) {
            writer.WriteLine("VectorTraits.Sample");
            writer.WriteLine();
            VectorTraitsGlobal.Init(); // Initialization (初始化).
            //TraitsOutput.OutputEnvironment(writer); // Output environment info (输出环境信息).
            writer.WriteLine(string.Format("Vectors.Instance:\t{0}", Vectors.Instance.GetType().Name));
            writer.WriteLine();

            // -- Start --
            Vector<short> src = Vectors.CreateRotate<short>(0, 1, 2, 3, 4, 5, 6, 7); // The `Vectors` class provides some methods. For example, 'CreateRotate' is rotate fill (`Vectors` 类提供了许多方法. 例如 `CreateRotate` 是旋转填充).
            VectorTextUtil.WriteLine(writer, "src:\t{0}", src); // It can not only format the string, but also display the hexadecimal of each element in the vector on the right Easy to view vector data (它不仅能格式化字符串, 且会在右侧显示向量中各元素的十六进制. 便于查看向量数据).

            // ShiftLeft. It is a new vector method in `.NET 7.0` (左移位. 它是 `.NET 7.0` 新增的向量方法)
            Vector<short> shifted = Vectors.ShiftLeft(src, 1); // shifted[i] = src[i] << 1.
            VectorTextUtil.WriteLine(writer, "ShiftLeft:\t{0}", shifted);
#if NET7_0_OR_GREATER
            VectorTextUtil.WriteLine(writer, "Equals to BCL ShiftLeft:\t{0}", shifted.Equals(Vector.ShiftLeft(src, 1))); // Compare the results of the same function in BCL with it (将BCL里相同函数的结果与它做对比).
#endif
            VectorTextUtil.WriteLine(writer, "Equals to ShiftLeft_Const:\t{0}", shifted.Equals(Vectors.ShiftLeft_Const(src, 1))); // If the parameter shiftAmount is a constant, you can also use the ShiftLeft of Vectors_ Const method It is faster in many scenarios (若参数 shiftAmount 是常数, 还可以使用 Vectors 的 ShiftLeft_Const 方法. 它在不少场景下更快).
            writer.WriteLine();

            // Shuffle. It is a new vector method in `.NET 7.0` (换位. 它是 `.NET 7.0` 新增的向量方法)
            Vector<short> desc = Vectors<short>.SerialDesc; // The generic structure 'Vectors<T>' provides fields for commonly used constants For example, 'SerialDesc' is a descending order value (泛型结构体 `Vectors<T>` 为常用常数提供了字段. 例如 `SerialDesc` 是降序的顺序值).
            VectorTextUtil.WriteLine(writer, "desc:\t{0}", desc);
            Vector<short> dst = Vectors.Shuffle(shifted, desc);
            VectorTextUtil.WriteLine(writer, "Shuffle:\t{0}", dst);
#if NET7_0_OR_GREATER
            VectorTextUtil.WriteLine(writer, "Equals to BCL Shuffle:\t{0}", dst.Equals(Vectors.Shuffle(shifted, desc))); // Compare the results of the same function in BCL with it (将BCL里相同函数的结果与它做对比).
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

`Vectors` 类提供了许多方法. 详见该列表: [TraitsMethodList](TraitsMethodList.md)

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

注: `Vectors.Instance` 及之前的文本, 是环境信息. 而从 `src` 开始的, 才是主要的测试代码.

### Arm `.NET7.0`中的运行结果
程序: `VectorTraits.Sample`

```
```

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
且从 ShiftLeft_AcceleratedTypes 中可以看出, Int16类型的ShiftLeft方法是存在硬件加速的. 本库巧妙利用了其他向量方法, 实现了ShiftLeft的硬件加速.

## 基准测试结果

## 变更日志

完整列表: [ChangeLog](ChangeLog.md)
