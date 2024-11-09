# ChangeLog (变更日志)

#### [2024-11-09] v3.0

Summary (摘要):
- Supports Vector512 type and X86 architecture's Avx512 family instruction sets; Supports Wasm(WebAssembly) architecture, supports PackedSimd instruction set; also provides innovative vector methods such as multi vector shuffle (YShuffleX2、YShuffleX3), interleave (Group2Zip, Group2Unzip) (支持Vector512类型及 X86架构的Avx512系列指令集; 支持 Wasm架构及PackedSimd指令集; 还提供了 多向量换位（YShuffleX2、YShuffleX3）、交织(Group2Zip, Group2Unzip) 等原创的向量方法).

Detail (明细):
- Supports Vector512 type and X86 architecture's Avx512 family instruction sets (支持Vector512类型及 X86架构的Avx512系列指令集).
- Improved algorithms for 128/256 bit vectors using the Avx512 family instruction sets (使用Avx512系列指令集, 改进了128/256位向量的算法).
- Supports Wasm(WebAssembly) architecture, supports PackedSimd instruction set (支持 Wasm(WebAssembly)架构及PackedSimd指令集).
- Added `VectorTraits.Benchmarks.Wasm` project. Used for unit test and benchmark vector types on the Wasm architecture (增加了 `VectorTraits.Benchmarks.Wasm` 项目. 用于在 Wasm 架构上对向量类型进行单元测试与基准测试).
- Support for `.NET 8.0` new vector methods (支持 `.NET 8.0` 新增的向量方法): WidenLower, WidenUpper.
- Provides vector methods for de-interleave (提供解交织的向量方法): YGroup2Unzip, YGroup2UnzipEven, YGroup2UnzipOdd, YGroup3Unzip, YGroup3UnzipX2, YGroup4Unzip, YGroup6Unzip_Bit128.
- Provides vector methods for interleave (提供交织的向量方法): YGroup2Zip, YGroup2ZipHigh, YGroup2ZipLow, YGroup3Zip, YGroup3ZipX2, YGroup4Unzip, YGroup6Zip_Bit128.
- Provides vector methods for reconstruction groups (提供重新构造组的向量方法): YGroup1ToGroup3, YGroup1ToGroup4, YGroup1ToGroup4WithW, YGroup3ToGroup4, YGroup4ToGroup3.
- Provides vector methods for multi vector shuffle (提供多向量换位的向量方法): YShuffleX2, YShuffleX2Insert, YShuffleX2Kernel, YShuffleX3, YShuffleX3Insert, YShuffleX3Kernel, YShuffleX4, YShuffleX4Insert, YShuffleX4Kernel.
- Provides vector methods for transpose (提供转置的向量方法): YGroup2Transpose, YGroup2TransposeEven, YGroup2TransposeOdd.
- Provides vector methods for compare (提供比较的向量方法): GreaterThan_Unsigned.
- Provides extension method for vectors (提供向量的扩展方法): AsSigned, AsUnsigned.
- VectorSameWExtensions add `As` method. `Vector<T>` add `As` Extension Methods (`Vector<T>` 增加 `As` 扩展方法). 
- The IsHardwareAccelerated property has been added to the Vectors(/Vector128s/Vector256s/Vector512s) classes (Vectors(/Vector128s/Vector256s/Vector512s) 类增加了 IsHardwareAccelerated 属性).
- Added 128-bit integer type - ExInt128/ExUInt128 (增加了128位整数类型 - ExInt128/ExUInt128).
- (Experimental) Experimentally added the ExType(Extended type) mechanism to enable vector types to support 128-bit integers(ExInt128/ExUInt128). However, it is found that some functions do not work properly under some .NET versions. Therefore, it is recommended to prioritize using functions with the suffix "_Bit128" instead of ExType (实验性的增加了 ExType(扩展类型) 机制, 使向量类型能支持128位整数(ExInt128/ExUInt128). 但发现某些.NET版本下，个别函数的工作不正常. 故建议优先使用“_Bit128”后缀的函数, 而不是 ExType).
- The MathBitOperations class has been added. It provides these functions (增加了 MathBitOperations 类. 它提供了这些函数): Crc32C, IsPow2, LeadingZeroCount, Log2, PopCount, RoundUpToPowerOf2, RotateLeft, RotateRight, TrailingZeroCount.
- Package "System.Runtime.CompilerServices.Unsafe" upgraded to version `5.0.0`. UnsafeUtil obsoletes methods such as IsNullRef, NullRef, SkipInit (Unsafe包升级到 `5.0.0` 版. UnsafeUtil 废弃了 IsNullRef 等函数).
- The UnsafeUtil class add methods (UnsafeUtil类增加了方法): GetArrayDataReference, Dec, Inc, PreDec, PreInc, PostDec, PostDecExcept, PostDecExceptZero, PostInc, PostIncExcept, PostIncExceptZero .
- Optimize type conversion for vector generic types by replacing `(object)` with the As method (优化向量泛型类型的类型转换, 用 As 方法取代 `(object)`).
- Optimize the combining of two vectors, using WithUpper instead of Create (优化两个向量的组合, 用 WithUpper 代替 Create). e,g, Narrow and more.
- Optimized hardware acceleration of YBitToByte, YBitToInt16, YBitToInt32, YBitToInt64 methods on all architecture. It no longer uses OnesComplement (优化YBitToByte, YBitToInt16, YBitToInt32, YBitToInt64方法在所有架构的硬件加速. 它不再使用 OnesComplement).
- Optimized hardware acceleration of Shuffle/YShuffleInsert methods on X86 architecture. Use EqualsShift arithmetic (优化Shuffle/YShuffleInsert方法在X86架构的硬件加速. 使用 EqualsShift 算法). For 16~64 bit types.
- Fix all YShuffleG4X2 methods, remove redundant ConstantExpected attribute(修正所有 YShuffleG4X2 方法, 移除多余的 ConstantExpected 特性).
- Removal of obsolete project file `VectorTraits_vs2019.sln` (移除过时的项目文件 `VectorTraits_vs2019.sln`).
- Deprecation notice: Deprecation notice: The next version will remove such as WVectorTraits128AdvSimdB64/WVectorTraits128Avx2 classes (废弃预告: 下个版本将会移除 WVectorTraits128AdvSimdB64, WVectorTraits128Avx2 等类).

## [2024-03-17] v2.0

- Major: Support for the X86 Sse family instruction set; supplement all vector methods for Vector128/Vector256; also provides innovative vector methods such as check floating number (YIsNaN, YIsInfinity), sign (YCopySign, YSign) (支持 x86的Sse系列指令集; 为 Vector128/Vector256 补充全部的向量方法; 还提供了 浮点数判断(YIsNaN, YIsinfinity)、符号判断(YCopySign, YSign) 等原创的向量方法).
- Provides the CPU model info (提供CPU型号信息). VectorEnvironment adds members: CpuModelName, CpuFlags, CpuDetectionCommand, CpuDetectionException, CpuDetectionResult .
- Provides information about the supported instruction set (提供所支持的指令集信息). e.g. `VectorEnvironment.SupportedInstructionSets`, `IBaseTraits.UsedInstructionSets`
- Supplement all vector methods for Vector128/Vector256 (为 Vector128/Vector256 补充全部的向量方法): Dot, Equals, EqualsAll, EqualsAny, GreaterThanAll, GreaterThanAny, GreaterThanOrEqual, GreaterThanOrEqualAll, GreaterThanOrEqualAny, LessThanAll, LessThanAny, LessThanOrEqual, LessThanOrEqualAll, LessThanOrEqualAny, Sqrt .
- Provides the vector methods of bitwise operations (提供位运算的向量方法): YBitToByte, YBitToInt16, YBitToInt32, YBitToInt64, YOrNot .
- Provides the vector methods of check floating number (提供浮点数判断的向量方法): YIsEvenInteger, YIsFinite, YIsInfinity, YIsInfinityOrNaN, YIsInteger, YIsNaN, YIsNegative, YIsNegativeZero, YIsNegativeInfinity, YIsNormal, YIsNotNaN, YIsOddInteger, YIsPositive, YIsPositiveInfinity, YIsSubnormal, YIsZero, YIsZeroOrSubnormal.
- Provides the vector methods of check sign (提供符号判断的向量方法): YCopySign, YSign, YSignFloat .
- Provides the vector methods of clamp (提供限制的向量方法): YMaxNumber, YMinNumber .
- Provides the vector methods of compare (提供比较的向量方法): YIsAllTrue, YIsAnyTrue, YIsNotEquals.
- VectorTraits.dll: Add TargetFrameworks `net8.0` and `netstandard2.1` (增加目标框架 `net8.0` 与 `netstandard2.1` ).
- Provides arrays of fixed length (提供固定长度的数组). e.g. FixedArray2, FixedArray4 ...
- BitMath changed from static to abstract class. Add namespace Zyl.VectorTraits.Numerics, add some math functions (BitMath从静态类改为抽象类. 新增名称空间 Zyl.VectorTraits.Numerics, 增加一些的数学函数).
- Benchmark programs add command line parameter (基准测试程序增加命令行参数): -accelerated0 -allowFakeBenchmark -cpuDetection0 -fixedVector0 -test0
- Add tool program (增加工具程序): UpdateBenchmarkResults.
- Optimized hardware acceleration of ExtractMostSignificantBits methods in the Arm architecture (优化ExtractMostSignificantBits方法在Arm架构的硬件加速). For 8~64 bit types.


## [2023-09-07] v1.0

- Major: Support for the X86 Avx instruction set, as well as Arm AdvSimd instruction set; supports NET 5.0-7.0 new vector methods; also provides innovative vector methods such as 4-element shuffle (YShuffleG4), saturation narrow (YNarrowSaturate, YNarrowSaturateUnsigned) (支持 x86的Avx指令集, 以及Arm的 AdvSimd 指令集; 支持 NET 5.0-7.0 新增的向量方法; 还提供了 4元素换位(YShuffleG4)、饱和变窄(YNarrowSaturate, YNarrowSaturateUnsigned) 等原创的向量方法).
- Provides some instrumental methods and constants for vector types (为向量类型提供了一些工具方法及常数). e.g. Vectors, Vector64s, Vector128s, Vector256s, VectorTextUtil ...
- Support for `.NET Standard 2.1` new vector methods (支持 `.NET Standard 2.1` 新增的向量方法): ConvertToDouble, ConvertToInt32, ConvertToInt64, ConvertToSingle, ConvertToUInt32, ConvertToUInt64, Narrow, Widen .
- Support for `.NET 5.0` new vector methods (支持 `.NET 5.0` 新增的向量方法): Ceiling, Floor .
- Support for `.NET 6.0` new vector methods (支持 `.NET 6.0` 新增的向量方法): Sum .
- Support for `.NET 7.0` new vector methods (支持 `.NET 7.0` 新增的向量方法): ExtractMostSignificantBits, ShiftLeft, ShiftRightArithmetic, ShiftRightLogical, Shuffle .
- Supplement vector methods for Vector128/Vector256 (为 Vector128/Vector256 补充向量方法): Abs, Add, AndNot, BitwiseAnd, BitwiseOr, ConditionalSelect, Divide, GreaterThan, LessThan, Max, Min, Multiply, Negate, OnesComplement, Subtract, Xor .
- Provides the vector methods of clamp (提供限制的向量方法): YClamp .
- Provides the vector methods of narrow saturate (提供缩窄饱和的向量方法): YNarrowSaturate, YNarrowSaturateUnsigned .
- Provides the vector methods of round (提供舍入的向量方法): YRoundToEven, YRoundToZero .
- Provides the vector methods of shuffle (提供换位的向量方法): YShuffleInsert, YShuffleKernel, YShuffleG2, YShuffleG4, YShuffleG4X2 . Also provides ShuffleControlG2/ShuffleControlG4 enum.



