# ChangeLog (变更日志)

## [2023-0?-??] v1.0

- Major: Support for the X86 Avx instruction set, as well as Arm AdvSimd instruction set; supports NET 5.0-7.0 new vector methods; also provides innovative vector methods such as 4-element shuffle (YShuffleG4), saturation narrow (YNarrowSaturate, YNarrowSaturateUnsigned) (支持 x86的Avx指令集, 以及Arm的 AdvSimd 指令集; 支持 NET 5.0-7.0 新增的向量方法; 还提供了 4元素换位(YShuffleG4)、饱和变窄(YNarrowSaturate, YNarrowSaturateUnsigned) 等原创的向量方法).
- Provides some instrumental methods and constants for vector types (为向量类型提供了一些工具方法及常数). e.g. Vectors, Vector64s, Vector128s, Vector256s, VectorTextUtil ...
- Provides the vector tuples (提供了向量元祖). e.g. VectorXTuple, VectorX2, VectorX3, VectorX4, Vector128X2, Vector256X2 ...
- Support for `.NET Standard 2.1` new vector methods (支持 `.NET Standard 2.1` 新增的向量方法): Narrow, Widen .
- Support for `.NET 5.0` new vector methods (支持 `.NET 5.0` 新增的向量方法): Ceiling, Floor .
- Support for `.NET 6.0` new vector methods (支持 `.NET 6.0` 新增的向量方法): Sum .
- Support for `.NET 7.0` new vector methods (支持 `.NET 7.0` 新增的向量方法): ExtractMostSignificantBits, Shuffle, ShiftLeft, ShiftRightArithmetic, ShiftRightLogical .
- Supplement vector methods for Vector128/Vector256 (为 Vector128/Vector256 补充向量方法): Abs, Add, AndNot, BitwiseAnd, BitwiseOr, ConditionalSelect, Divide, GreaterThan, LessThan, Max, Min, Multiply, Negate, OnesComplement, Subtract, Xor .
- Provides the vector methods of clamp (提供限制的向量方法): YClamp .
- Provides the vector methods of narrow (提供缩窄的向量方法): YNarrowSaturate, YNarrowSaturateUnsigned .
- Provides the vector methods of shuffle (提供换位的向量方法): XShuffle, XShuffleInsert, YShuffleInsert, YShuffleG4, YShuffleG4X2 . Also provides ShuffleControlG4 classes.



