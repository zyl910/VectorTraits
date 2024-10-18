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
- [YGroup1ToGroup3](YGroup1ToGroup3.md): Convert a 1-element group, to a 3-element group. It also converts grayscale pixel data to packed RGB pixel data (将1-元素组, 转为3-元素组. 它还能将 灰度像素数据, 转换为 已打包的RGB像素数据).
- [YGroup2Transpose](YGroup2Transpose.md): Transpose a 2*2 matrix (对2*2矩阵进行转置).
- [YGroup2Unzip](YGroup2Unzip.md): De-Interleave 2-element groups into 2 vectors. It converts the 2-element groups AoS to SoA (将2-元素组解交织为2个向量. 它能将2元素组的 数组结构体 转为 结构体数组).
- [YGroup2Zip](YGroup2Unzip.md): Interleave 2 vectors into 2-element groups. It converts the 2-element groups SoA to AoS (将2个向量交织为2-元素组. 它能将2元素组的 结构体数组 转为 数组结构体).
- [YGroup3ToGroup4](YGroup3ToGroup4.md): Convert a 3-element group, to a 4-element group. It also converts packed RGB pixel data to packed RGBA pixel data (将3-元素组, 转为4-元素组. 它还能将 已打包的RGB像素数据, 转换为 已打包的RGBA像素数据).
- [YGroup3Unzip](YGroup3Unzip.md): De-Interleave 3-element groups into 3 vectors. It converts the 3-element groups AoS to SoA. It can also deinterleave packed RGB pixel data into R,G,B planar data (将3-元素组解交织为3个向量. 它能将3元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGB像素数据, 解交织为 R,G,B 平面数据).
- [YGroup3Zip](YGroup3Unzip.md): Interleave 3 vectors into 3-element groups. It converts the 3-element groups SoA to AoS. It can also interleave R,G,B planar data into packed RGB pixel data (将3-元素组解交织为3个向量. 它能将3元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B 平面数据, 交织为 已打包的RGB像素数据).
- [YGroup4ToGroup3](YGroup3ToGroup4.md): Convert a 4-element group, to a 3-element group. It also converts packed RGBA pixel data to packed RGB pixel data (将4-元素组, 转为3-元素组. 它还能将 已打包的RGBA像素数据, 转换为 已打包的RGB像素数据).
- [YGroup4Unzip](YGroup4Unzip.md): De-Interleave 4-element groups into 4 vectors. It converts the 4-element groups AoS to SoA. It can also deinterleave packed RGBA pixel data into R,G,B,A planar data (将4-元素组解交织为4个向量. 它能将4元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGBA像素数据, 解交织为 R,G,B,A 平面数据).
- [YGroup4Zip](YGroup4Unzip.md): Interleave 4 vectors into 4-element groups. It converts the 4-element groups SoA to AoS. It can also interleave R,G,B,A planar data into packed RGBA pixel data (将4个向量交织为4-元素组. 它能将4元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B,A 平面数据, 交织为 已打包的RGBA像素数据).
- [YNarrowSaturate](YNarrowSaturate.md): Saturate narrows two Vector instances into one Vector  (将两个 Vector 实例饱和缩窄为一个 Vector ).
- [YNarrowSaturateUnsigned](YNarrowSaturateUnsigned.md): Saturate narrows two signed Vector instances into one unsigned Vector  (将两个有符号 Vector 实例饱和缩窄为一个无符号 Vector ).
- [YRoundToEven](Ceiling.md): Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: `MidpointRounding.ToEven`.
- [YRoundToZero](Ceiling.md): Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: `MidpointRounding.ToZero`.
- [YShuffleG2](YShuffleG2.md): For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
- [YShuffleG4X2](YShuffleG4X2.md): For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
- [YShuffleX2Kernel](YShuffleX2Kernel.md): Only shuffle on 2 vectors (在2个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). 
- [YShuffleX3Kernel](YShuffleX2Kernel.md): Only shuffle on 3 vectors (在3个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). 
- [YShuffleX4Kernel](YShuffleX2Kernel.md): Only shuffle on 4 vectors (在4个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). 


