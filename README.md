# VectorTraits
English | [Chinese(中文)](README_Chinese.md)

VectorTraits: SIMD Vector type traits methods (SIMD向量类型的特征方法).

This library provides many important arithmetic methods(e.g. Shift, Shuffle, NarrowSaturate) and constants for vector types, making it easier for you to write cross-platform SIMD code. It takes full advantage of the X86 and Arm architectures' intrinsic functions to achieve hardware acceleration and can enjoy inline compilation optimization.

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
- Provides the vector methods of round: YRoundToEven, YRoundToZero .
- Provides the vector methods of shuffle: YShuffleInsert, YShuffleKernel, YShuffleG2, YShuffleG4, YShuffleG4X2 . Also provides ShuffleControlG2/ShuffleControlG4 enum.
- ...
- Full list: [TraitsMethodList](TraitsMethodList.md)

Supported instruction set:
- x86
  - 256-bit vector: Avx, Avx2 .
- Arm
  - 128-bit vector: AdvSimd .

## Purpose
The SIMD instruction set is known to accelerate multimedia processing (graphics, images, audio, video, ...) , artificial intelligence, scientific computing, etc.
However, traditional SIMD programming suffers from the following pain points.
- Difficult to cross-platform. Because different CPU systems provide different SIMD instruction sets, for example, there are many differences between the SIMD instruction sets of X86 and Arm platforms. If you want to port the program to another platform, you need to find the SIMD instruction set manual of that platform and develop it again.
- Bit widths are difficult to upgrade. Even for the same platform, as it evolves, instruction sets with wider bit widths are gradually added. For example, the X86 platform, in addition to the obsolete 64-bit MMX series instructions, provides a 128-bit SSE instruction set, a 256-bit AVX instruction set, and some high-end processors are starting to support the 512-bit AVX-512 instruction set. Algorithms previously written with 128-bit SSE series instructions need to be redeveloped to take full advantage of the wider SIMD instruction set if they are to be ported to the 256-bit AVX instruction set.
- Poor code readability and high development threshold. Many modern C compilers map `Intrinsic Functions` for SIMD instructions, which is much easier and more readable than writing assembly code. However, due to the use of some obscure abbreviations for function names, and the fact that C does not support function name overloading, as well as the complexity of the C language itself, there is still a high threshold for code readability and development difficulty.

`NET Core 1.0` in 2016 added vector types such as `Vector<T>`, which largely solves the above pain points.
- Easy cross-platform. NET platform is run by JIT (Just-In-Time Compiler). Only one set of algorithms based on vector methods is written and compiled into only one set of programs. When that program is subsequently run on a different platform, the vector method is compiled by JIT into a platform-specific SIMD instruction set, thus taking full advantage of hardware acceleration.
- Bitwidth can be upgraded automatically. For the `Vector<T>` type, its length is not fixed, but is the same as the longest vector register for that processor. Specifically, if the CPU supports the AVX instruction set (strictly AVX2 and above), the `Vector<T>` type is 256 bits; if the CPU only supports the SSE instruction set (strictly SSE2 and above), the `Vector<T>` type is 128 bits. Simply put, you can write your program using only the `Vector<T>` type, and when the program runs, JIT will automatically use the widest SIMD instruction set.
- The code is more readable and lowers the development threshold. `.NET` platform, the method names of vector types are composed of complete English words, and make full use of C# syntax features such as function name overloading, so that these method names are both concise and clear. The readability of the code has been greatly improved.

The vector type `Vector<T>` although well designed, it lacks many important vector functions such as Ceiling, Sum, Shift, Shuffle, etc. This led to many algorithms that were difficult to implement with vector types.
When `.NET` platform versions are upgraded, sometimes several vector methods are added. `.NET 7.0` released in 2022, for example, added ShiftRightArithmetic, Shuffle and other methods. However, there are still few vector methods, such as the lack of saturation processing.
To address the lack of vector methods, `.NET Core 3.0` starts to support intrinsic functions. This allows developers to use the SIMD instruction set directly, but again, this faces problems such as difficulty in cross-platform and bit-width upgrades. As the `.NET` platform is upgraded, more intrinsic functions will be added. For example, `.NET 5.0` adds intrinsic functions for the Arm platform.
For developing libraries, you can't just support `.NET 7.0`, but you need to support multiple `.NET` versions. So you will face tedious version checking and conditional processing. And the highest version of the `.NET Standard` class library (2.1) still does not support vector methods like Ceiling, which makes version checking even more tedious. 

This library is dedicated to solve the above troubles, so that you can write cross-platform SIMD algorithms more easily.
Feature:
- Support for low versions of `.NET` programs (`.NET Standard 1.1`, `.NET Core 1.0`, `.NET Framework 4.5`, ...).  Enables low version of `.NET` programs to use the latest vector functions.  For example, ShiftRightArithmetic, Shuffle, etc. are new in `.NET 7.0`.
- Powerful functions . In addition to referencing vector methods from higher versions of `.NET`, this library also provides many useful vector methods by referring to intrinsic functions. e.g. ShiftLeft_Fast, YNarrowSaturate ...
- High performance. This library can take full advantage of the X86 and Arm architecture's intrinsic functions for hardware acceleration of vector type computations, and can enjoy inline compilation optimization. This library solves the problem that some of BCL's vector methods (e.g. Multiply, Shuffle, etc.) are not hardware-accelerated on some platforms, because it supplements the hardware-accelerated algorithms.
- Software algorithms are also fast. If you find a method of vector type does not support hardware acceleration, `.NET Bcl` will switch to software algorithm, but many of its software algorithms contain branching statements, so the performance is poor.  The software algorithm of this library is a highly optimized branchless algorithm.
- Easy to use. This library supports not only `Vector<T>`, but also `Vector128<T>`/`Vector256<T>` and other vector types. The class name of the tool class is easy to remember (Vectors/Vector64s/Vector128s/Vector256s) and provides many common vector constants through a generic class of the same name.
- For each traits method, some properties are added to obtain information. e.g. `_AcceleratedTypes`, `_FullAcceleratedTypes` .

Tip: The Disassembly window in Visual Studio allows you to view the assembly code at runtime.  For example, when running on a machine that supports the Avx instruction set, `Vectors.ShiftLeft_Const` will be compiled inline and optimized to use the `vpsllw` instruction. And for constant value(1), it will be compiled as the immediate number of the instruction.
![Vectors.ShiftLeft_use_inline.png](docs/Vectors.ShiftLeft_use_inline.png)

Example 2: Using `Vectors.ShiftLeft_Args` and `Vectors.ShiftLeft_Core`, you can move some of the operations outside the loop to be processed earlier.   For example, when running on a machine that supports the Avx instruction set, `xmm1` is set outside the loop, and then used it in the `vpsllw` instruction of the inner loop.   And here it is shown: the inline compilation optimization eliminates redundant xmm/ymm conversions.
![Vectors.ShiftLeft_Core_use_inline.png](docs/Vectors.ShiftLeft_Core_use_inline.png)

## Getting started

## Documentation

- Traits method list: [TraitsMethodList](TraitsMethodList.md)
- Doxygen: Run the Doxywizard and click File ->Open on the menu bar. Select the `Doxyfile` file and click "OK". Click on the "Run" tab and click on the "Run doxygen" button. It will generate documents in the "doc_gen" folder.

## ChangeLog

Full list: [ChangeLog](ChangeLog.md)
