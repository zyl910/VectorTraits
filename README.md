# VectorTraits
English | [Chinese(中文)](README_Chinese.md)

VectorTraits: SIMD Vector type traits methods (SIMD向量类型的特征方法).

This library provides many important arithmetic methods(e.g. Shift, Shuffle, NarrowSaturate) and constants for vector types, making them more convenient to use. It takes full advantage of the X86 and Arm architectures' intrinsic functions to achieve hardware acceleration and can enjoy inline compilation optimization.

Commonly Used Types:
- `Vectors`: For vector types, common tool functions are provided, e.g. Create(T/T[]/Span/ReadOnlySpan), CreatePadding, CreateRotate, CreateByFunc, CreateByDouble ... It also provides traits methods for vectors, e.g. ShiftLeft、ShiftRightArithmetic、ShiftRightLogical、Shuffle ...
- `Vectors<T>`: For vector types, constants are provided for various element types. e.g. Serial, SerialDesc, XyzwWMask, MantissaMask, MaxValue, MinValue, NormOne, FixedOne, E, Pi, Tau, VMaxByte, VReciprocalMaxSByte ...
- `Vector64s/Vector128s/Vector256s`: Common tool functions and traits methods are provided for vectors of fixed bit width (Vector64/Vector128/Vector256).
- `Vector64s<T>/Vector128s<T>/Vector256s<T>`: Provides constants of various element types for vectors of fixed bit width.
- `Scalars`: For scalar types, various tool functions are provided. e.g. GetByDouble, GetFixedByDouble, GetByBits, GetBitsMask ...
- `Scalars<T>`: For scalar types, a number of constants are provided. e.g. ExponentBits, MantissaBits, MantissaMask, MaxValue, MinValue, NormOne, FixedOne, E, Pi, Tau, VMaxByte, VReciprocalMaxSByte ...
- `VectorTextUtil`: Provides some textual instrumental functions for vectors. e.g. GetHex, Format, WriteLine ...

Traits methods:
- Support for `.NET Standard 2.1` new vector methods: ConvertToDouble, ConvertToInt32, ConvertToInt64, ConvertToSingle, ConvertToUInt32, ConvertToUInt64, Narrow, Widen .
- Support for `.NET 5.0` new vector methods: Ceiling, Floor .
- Support for `.NET 6.0` new vector methods: Sum .
- Support for `.NET 7.0` new vector methods: ExtractMostSignificantBits, Shuffle, ShiftLeft, ShiftRightArithmetic, ShiftRightLogical .
- Provides the vector methods of narrow saturate: YNarrowSaturate, YNarrowSaturateUnsigned .
- Provides the vector methods of shuffle: YShuffleEach128, YShuffleInsert, YShuffleInsertEach128, YShuffleG4, YShuffleG4X2 . Also provides ShuffleControlG4 classes.
- ...
- Full list: [TraitsMethodList](TraitsMethodList.md)

Feature:
- Support for lower versions of `.NET` programs. Although `.NET Core 1.0` in 2016 already supports vector types such as `Vector<T>`, the lack of important vector functions such as ShiftLeft, ShiftRightArithmetic, ShiftRightLogical, Shuffle, etc. makes it difficult to implement many algorithms with vector types. It was not until 2022 when `.NET 7.0` was released that the problem of not supporting vector functions such as ShiftLeft was solved. If the class library only supports `.NET 7.0`, it will cause a lot of inconvenience. This library solves this problem by enabling lower versions of `.NET` programs (`.NET Standard 1.1`, `.NET Core 1.0`, `.NET Framework 4.5`, ...) to use vector functions such as ShiftLeft.
- Powerful functions . In addition to referencing vector methods from higher versions of `.NET`, this library also provides many useful vector methods by referring to intrinsic functions. e.g. ShiftLeftFast, YNarrowSaturate ...
- High performance. This library can take full advantage of the X86 and Arm architecture's intrinsic functions for hardware acceleration of vector type computations, and can enjoy inline compilation optimization.
- Software algorithms are also fast. If you find a method of vector type does not support hardware acceleration, `.NET Bcl` will switch to software algorithm, but many of its software algorithms contain branching statements, so the performance is poor.  The software algorithm of this library is a highly optimized branchless algorithm.
- Easy to use. This library supports not only `Vector<T>`, but also `Vector128<T>`/`Vector256<T>` and other vector types. The class name of the tool class is easy to remember (Vectors/Vector64s/Vector128s/Vector256s) and provides many common vector constants through a generic class of the same name.
- Provides the vector tuples. e.g. VectorXTuple, VectorX2, VectorX3, VectorX4, Vector128X2, Vector256X2 ...

The Disassembly window in Visual Studio allows you to view the assembly code at runtime.  For example, when running on a machine that supports the Avx instruction set, `Vectors.ShiftLeft` will be compiled inline and optimized to use the `vpsllw` instruction.
![Vectors.ShiftLeft_use_inline.png](docs/Vectors.ShiftLeft_use_inline.png)


## ChangeLog

Full list: [ChangeLog](ChangeLog.md)

### [Latest version] v1.0
