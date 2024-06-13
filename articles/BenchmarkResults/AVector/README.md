# AVector
([← Back](../README.md))

## Benchmark results of Vector (向量的基准测试结果)

- [Ceiling](Ceiling.md): Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: `MidpointRounding.ToPositiveInfinity`.
- [ConvertToDouble](ConvertToDouble.md): Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量).
- [ConvertToInt32](ConvertToSingle.md): Convert to a vector whose elements are of type Int32 (转换为元素类型是Int32的向量).
- [ConvertToInt64](ConvertToDouble.md): Convert to a vector whose elements are of type Int64 (转换为元素类型是Int64的向量).
- [ConvertToSingle](ConvertToSingle.md): Convert to a vector whose elements are of type Single (转换为元素类型是Single的向量).
- [ConvertToUInt32](ConvertToSingle.md): Convert to a vector whose elements are of type UInt32 (转换为元素类型是UInt32的向量).
- [ConvertToUInt64](ConvertToDouble.md): Convert to a vector whose elements are of type UInt64 (转换为元素类型是UInt64的向量).
- [Floor](Ceiling.md): Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: `MidpointRounding.ToNegativeInfinity`.
- [Multiply](Multiply.md): Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
- [Narrow](Narrow.md): Narrows two Vector instances into one Vector  (将两个 Vector 实例缩窄为一个 Vector ).
- [ShiftLeft](ShiftLeft.md): Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
- [ShiftRightArithmetic](ShiftRightArithmetic.md): Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
- [ShiftRightLogical](ShiftRightLogical.md): Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
- [Shuffle](Shuffle.md): Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
- [Widen](Widen.md): Widens a Vector into two Vector instances (将一个 Vector 扩宽为两个 Vector 实例).
- [YClamp](YClamp.md): Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制)
- [YNarrowSaturate](YNarrowSaturate.md): Saturate narrows two Vector instances into one Vector  (将两个 Vector 实例饱和缩窄为一个 Vector ).
- [YNarrowSaturateUnsigned](YNarrowSaturateUnsigned.md): Saturate narrows two signed Vector instances into one unsigned Vector  (将两个有符号 Vector 实例饱和缩窄为一个无符号 Vector ).
- [YRoundToEven](Ceiling.md): Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: `MidpointRounding.ToEven`.
- [YRoundToZero](Ceiling.md): Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: `MidpointRounding.ToZero`.
- [YShuffleG2](YShuffleG2.md): For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
- [YShuffleG4X2](YShuffleG4X2.md): For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
- [YShuffleX2Kernel](YShuffleX2Kernel.md): Only shuffle on 2 vectors (在2个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). 
- [YShuffleX3Kernel](YShuffleX3Kernel.md): Only shuffle on 3 vectors (在3个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). 
- [YShuffleX4Kernel](YShuffleX4Kernel.md): Only shuffle on 4 vectors (在4个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). 
