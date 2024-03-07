# ChangeLog (变更日志)

## [2023-?-?] v2.0

- Major: Support for the X86 Sse family instruction set; supplement all vector methods for Vector128/Vector256; also provides innovative vector methods such as check floating number (YIsNaN, YIsInfinity), sign (YCopySign, YSign) (支持 x86的Sse系列指令集; 为 Vector128/Vector256 补充全部的向量方法; 还提供了 浮点数判断(YIsNaN, YIsinfinity)、符号判断(YCopySign, YSign) 等原创的向量方法).
- Provides the CPU model name (提供CPU型号名). VectorEnvironment adds members: Refresh, CpuModelName, CpuFlags, CpuDetectionCommand, CpuDetectionException, CpuDetectionResult .
- Provides information about the supported instruction set (提供所支持的指令集信息). e.g. `VectorEnvironment.SupportedInstructionSets`, `IBaseTraits.UsedInstructionSets`
- Supplement all vector methods for Vector128/Vector256 (为 Vector128/Vector256 补充全部的向量方法): Dot, Equals, EqualsAll, EqualsAny, GreaterThanAll, GreaterThanAny, GreaterThanOrEqual, GreaterThanOrEqualAll, GreaterThanOrEqualAny, LessThanAll, LessThanAny, LessThanOrEqual, LessThanOrEqualAll, LessThanOrEqualAny, Sqrt .
- Provides the vector methods of bitwise operations (提供位运算的向量方法): YOrNot, YBitToByte, YBitToInt16, YBitToInt32, YBitToInt64 .
- Provides the vector methods of check floating number (提供浮点数判断的向量方法): YIsEvenInteger, YIsFinite, YIsInfinity, YIsInfinityOrNaN, YIsInteger, YIsNaN, YIsNegative, YIsNegativeZero, YIsNegativeInfinity, YIsNormal, YIsNotNaN, YIsOddInteger, YIsPositive, YIsPositiveInfinity, YIsSubnormal, YIsZero, YIsZeroOrSubnormal.
- Provides the vector methods of check sign (提供符号判断的向量方法): YCopySign, YSign, YSignFloat .
- Provides the vector methods of clamp (提供限制的向量方法): YMaxNumber, YMinNumber .
- Provides the vector methods of compare (提供比较的向量方法): YIsAllTrue, YIsAnyTrue, YIsNotEquals.
- VectorTraits.dll: Add TargetFrameworks `net8.0` and `netstandard2.1` (增加目标框架 `net8.0` 与 `netstandard2.1` ).
- Provides arrays of fixed length (提供固定长度的数组). e.g. FixedArray2, FixedArray4 ...
- BitMath changed from static to abstract class. Add namespace Zyl.VectorTraits.Numerics, add some math functions (BitMath从静态类改为抽象类. 新增名称空间 Zyl.VectorTraits.Numerics, 增加一些的数学函数).
- Benchmark programs add command line parameter (基准测试程序增加命令行参数): -accelerated0 -fixedVector0 -test0 -cpuDetection0 -allowFakeBenchmark
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



