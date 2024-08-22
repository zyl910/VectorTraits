# Traits method list

## Arithmetic methods for vectors  (向量的算术方法)
### Vector traits method of official BCL library (官方BCL库的向量特性方法)
Types: Vector, Vector128, Vector256, Vector512 .

Summary (概要):
- Support for `.NET Standard 2.1` new vector methods (支持 `.NET Standard 2.1` 新增的向量方法): ConvertToDouble, ConvertToInt32, ConvertToInt64, ConvertToSingle, ConvertToUInt32, ConvertToUInt64, Narrow, Widen .
- Support for `.NET 5.0` new vector methods (支持 `.NET 5.0` 新增的向量方法): Ceiling, Floor .
- Support for `.NET 6.0` new vector methods (支持 `.NET 6.0` 新增的向量方法): Sum .
- Support for `.NET 7.0` new vector methods (支持 `.NET 7.0` 新增的向量方法): ExtractMostSignificantBits, ShiftLeft, ShiftRightArithmetic, ShiftRightLogical, Shuffle .
- Support for `.NET 8.0` new vector methods (支持 `.NET 8.0` 新增的向量方法): WidenLower, WidenUpper.

List (列表):
- `Ceiling`: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: `MidpointRounding.ToPositiveInfinity`.
  Mnemonic: `rt[i] := ceiling(value[i])` .
- `ConvertToDouble[/_Range52]`: Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量).
  Mnemonic: `rt[i] := (Double)(value[i])` .
- `ConvertToInt32`: Convert to a vector whose elements are of type Int32 (转换为元素类型是Int32的向量).
  Mnemonic: `rt[i] := (Int32)(value[i])` .
- `ConvertToInt64[/_Range52/Range52RoundToEven]`: Convert to a vector whose elements are of type Int64 (转换为元素类型是Int64的向量).
  Mnemonic: `rt[i] := (Int64)(value[i])` .
- `ConvertToSingle`: Convert to a vector whose elements are of type Single (转换为元素类型是Single的向量).
  Mnemonic: `rt[i] := (Single)(value[i])` .
- `ConvertToUInt32`: Convert to a vector whose elements are of type UInt32 (转换为元素类型是UInt32的向量).
  Mnemonic: `rt[i] := (UInt32)(value[i])` .
- `ConvertToUInt64[/_Range52/Range52RoundToEven]`: Convert to a vector whose elements are of type UInt64 (转换为元素类型是UInt64的向量).
  Mnemonic: `rt[i] := (UInt64)(value[i])` .
- `ExtractMostSignificantBits`①: Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
  Mnemonic: `rt |= getMostSignificantBit(vector[i]) << i = ( vector[i] >>> (sizeof(T)*8-1) ) << i` .
- `Floor`: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: `MidpointRounding.ToNegativeInfinity`.
  Mnemonic: `rt[i] := floor(value[i])` .
- `Narrow`: Narrows two Vector instances into one Vector  (将两个 Vector 实例缩窄为一个 Vector ).
  Mnemonic: `rt[i] := narrow(element_ref(i, lower, upper))`.
- `ShiftLeft[/_Args/_Core/_Const/_ConstCore/_Fast]`: Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
  Mnemonic: `rt[i] := value[i] << shiftAmount`, `shiftAmount &= (T.BitSize-1)`.
- `ShiftRightArithmetic[/_Args/_Core/_Const/_ConstCore/_Fast]`: Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
  Mnemonic: `rt[i] := value[i] >> shiftAmount`, `shiftAmount &= (T.BitSize-1)`.
- `ShiftRightLogical[/_Args/_Core/_Const/_ConstCore/_Fast]`: Shifts (unsigned) each element of a vector right by the specified amount (将向量的每个无符号元素逻辑右移指定量).
  Mnemonic: `rt[i] := value[i] >>> shiftAmount`, `shiftAmount &= (T.BitSize-1)`.
- `Shuffle[/_Args/_Core]`①: Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<Count)?( vector[indices[i]] ):0`.
- `Sum`: Computes the sum of all elements in a vector (计算向量中所有元素的总和).
  Mnemonic: `rt := value[0] + value[1] + value[2] + ... + value[Count-1]` .
- `Widen`: Widens a Vector into two Vector instances (将一个 Vector 扩宽为两个 Vector 实例).
  Mnemonic: `element_ref(i, lower, upper) := widen(source[i])`.
- `WidenLower`: Widens the lower half of a Vector into a Vector (将向量的低半部分扩宽为一个向量).
  Mnemonic: `rt[i] := widen(source[i])`.
- `WidenUpper`: Widens the upper half of a Vector into a Vector (将向量的高半部分扩宽为一个向量).
  Mnemonic: `rt[i] := widen(source[i - Count/2])`.

### Fixed width Vector supplement traits methods (固定宽度向量补充的特性方法)
Types: Vector128, Vector256, Vector512 .

List (列表):
- `Abs`: Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
  Mnemonic: `rt[i] := abs(vector[i])`.
- `Add`: Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
  Mnemonic: `rt[i] := left[i] + right[i]`.
- `AndNot`: Computes the bitwise-and of a given vector and the ones complement of another vector (计算一个给定的向量和另一个向量反码的位与).
  Mnemonic: `rt[i] := left[i] & ~right[i]`.
- `BitwiseAnd`: Computes the bitwise-and of two vectors (计算两个向量的位与).
  Mnemonic: `rt[i] := left[i] & right[i]`.
- `BitwiseOr`: Computes the bitwise-or of two vectors (计算两个向量的位或).
  Mnemonic: `rt[i] := left[i] | right[i]`.
- `ConditionalSelect`: Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
  Mnemonic: `rt[i] := (left[i] & condition[i]) | (right[i] & ~condition[i])`.
- `Divide`: Divides two vectors to compute their quotient (将两个向量相除来计算它们的商).
  Mnemonic: `rt[i] := left[i] / right[i]`.
- `Dot`①: Computes the dot product of two vectors (计算两个向量的点积).
  Mnemonic: `rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]` .
- `Equals`: Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
  Mnemonic: `rt[i] := to_mask(left[i] == right[i])`.
- `EqualsAll`: Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
  Mnemonic: `rt := (left[0] == right[0]) && (left[1] == right[1]) && ... && (left[Count-1] == right[Count-1])`.
- `EqualsAny`: Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
  Mnemonic: `rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])`.
- `GreaterThan[/_Unsigned]`: Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
  Mnemonic: `rt[i] := to_mask(left[i] > right[i])`.
- `GreaterThanAll`: Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
  Mnemonic: `rt := (left[0] > right[0]) && (left[1] > right[1]) && ... && (left[Count-1] > right[Count-1])`.
- `GreaterThanAny`: Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
  Mnemonic: `rt := (left[0] > right[0]) || (left[1] > right[1]) || ... || (left[Count-1] > right[Count-1])`.
- `GreaterThanOrEqual`: Compares two vectors to determine which is greater or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大或等于).
  Mnemonic: `rt[i] := to_mask(left[i] >= right[i])`.
- `GreaterThanOrEqualAll`: Compares two vectors to determine if all elements are greater or equal (比较两个向量以判定所有元素是否大于或等于).
  Mnemonic: `rt := (left[0] >= right[0]) && (left[1] >= right[1]) && ... && (left[Count-1] >= right[Count-1])`.
- `GreaterThanOrEqualAny`: Compares two vectors to determine if any elements are greater or equal (比较两个向量以判定任一元素是否大于或等于).
  Mnemonic: `rt := (left[0] >= right[0]) || (left[1] >= right[1]) || ... || (left[Count-1] >= right[Count-1])`.
- `LessThan`: Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
  Mnemonic: `rt[i] := to_mask(left[i] < right[i])`.
- `LessThanAll`: Compares two vectors to determine if all elements are less (比较两个向量以判定所有元素是否小于).
  Mnemonic: `rt := (left[0] < right[0]) && (left[1] < right[1]) && ... && (left[Count-1] < right[Count-1])`.
- `LessThanAny`: Compares two vectors to determine if any elements are less (比较两个向量以判定任一元素是否小于).
  Mnemonic: `rt := (left[0] < right[0]) || (left[1] < right[1]) || ... || (left[Count-1] < right[Count-1])`.
- `LessThanOrEqual`: Compares two vectors to determine which is less or equal on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小或等于).
  Mnemonic: `rt[i] := to_mask(left[i] <= right[i])`.
- `LessThanOrEqualAll`: Compares two vectors to determine if all elements are less or equal (比较两个向量以判定所有元素是否小于或等于).
  Mnemonic: `rt := (left[0] <= right[0]) && (left[1] <= right[1]) && ... && (left[Count-1] <= right[Count-1])`.
- `LessThanOrEqualAny`: Compares two vectors to determine if any elements are less or equal (比较两个向量以判定任一元素是否小于或等于).
  Mnemonic: `rt := (left[0] <= right[0]) || (left[1] <= right[1]) || ... || (left[Count-1] <= right[Count-1])`.
- `Max`: Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
  Mnemonic: `rt[i] := max(left[i], right[i])`.
- `Min`: Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
  Mnemonic: `rt[i] := min(left[i], right[i])`.
- `Multiply`①: Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
  Mnemonic: `rt[i] := left[i] * right[i]`.
- `Negate`: Computes the negate of a vector (计算向量的相反数).
  Mnemonic: `rt[i] := -vector[i]`.
- `OnesComplement`: Computes the ones-complement of a vector (计算向量的反码).
  Mnemonic: `rt[i] := ~vector[i]`.
- `Sqrt`①: Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
  Mnemonic: `rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)`. When x is less than 0, floating-point types return NaN, integer types return 0.
- `Subtract`: Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
  Mnemonic: `rt[i] := left[i] - right[i]`.
- `Xor`: Computes the exclusive-or of two vectors (计算两个向量的位异或).
  Mnemonic: `rt[i] := left[i] ^ right[i]`.

### Vector traits method appended by this library (由本库追加的向量特性方法)
Types: Vector, Vector128, Vector256, Vector512 .

##### Methods of group (组的方法)
Summary (概要):
- Provides vector methods for de-interleave (提供解交织的向量方法): YGroup2Unzip, YGroup2UnzipEven, YGroup2UnzipOdd.
- Provides vector methods for interleave (提供交织的向量方法): YGroup2Zip, YGroup2ZipHigh, YGroup2ZipLow.

List (列表):
- `YGroup2Unzip[/_Bit128]`: De-Interleave 2-element groups into 2 vectors. It converts the 2-element groups AoS to SoA (将2-元素组解交织为2个向量. 它能将2元素组的 数组结构体 转为 结构体数组).
  Mnemonic: `x[i] =: element_ref(2*i, data0, data1)`, `y[i] =: element_ref(2*i+1, data0, data1)`.
- `YGroup2UnzipEven`: De-Interleave the 2-element groups into 2 vectors, and return the vector of even positions (将2-元素组解交织为2个向量, 并返回偶数位置的数据).
  Mnemonic: `rt[i] =: element_ref(2*i, data0, data1)`.
- `YGroup2UnzipOdd`: De-Interleave the 2-element groups into 2 vectors, and return the vector of odd positions (将2-元素组解交织为2个向量, 并返回奇数位置的数据).
  Mnemonic: `rt[i] =: element_ref(2*i+1, data0, data1)`.
- `YGroup2Zip[/_Bit128]`: Interleave 2 vectors into 2-element groups. It converts the 2-element groups SoA to AoS (将2个向量交织为2-元素组. 它能将2元素组的 结构体数组 转为 数组结构体).
  Mnemonic: `element_ref(i, data0, data1) := (0==(i&1))?( x[i2] ):( y[i2] )`, `i2 := i/2`.
- `YGroup2ZipHigh`: Interleave 2 vectors into 2-element groups and returns the data in the high position. (将2个向量交织为2-元素组, 并返回高位置的数据).
  Mnemonic: `rt[i] := (0==(i&1))?( x[i2] ):( y[i2] )`, `i2 := (i+T.Count)/2`.
- `YGroup2ZipLow`: Interleave 2 vectors into 2-element groups and returns the data in the low position. (将2个向量交织为2-元素组, 并返回低位置的数据).
  Mnemonic: `rt[i] := (0==(i&1))?( x[i2] ):( y[i2] )`, `i2 := i/2`.
- `YGroup3Unzip[/_Bit128]`: De-Interleave 3-element groups into 3 vectors. It converts the 3-element groups AoS to SoA. It can also deinterleave packed RGB pixel data into R,G,B planar data (将3-元素组解交织为3个向量. 它能将3元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGB像素数据, 解交织为 R,G,B 平面数据).
  Mnemonic: `x[i] =: element_ref(3*i, data0, data1, data2)`, `y[i] =: element_ref(3*i+1, data0, data1, data2)`, `z[i] =: element_ref(3*i+2, data0, data1, data2)`.
- `YGroup3UnzipX2[/_Bit128]`: De-Interleave 3-element groups into 3 vectors and process 2x data (将3-元素组解交织为3个向量, 且处理2倍数据).
  Mnemonic: `(x, y, z) = YGroup3Unzip(data0, data1, data2)`, `(xB, yB, zB) = YGroup3Unzip(data3, data4, data5)`.
- `YGroup3Zip[/_Bit128]`: Interleave 3 vectors into 3-element groups. It converts the 3-element groups SoA to AoS. It can also interleave R,G,B planar data into packed RGB pixel data (将3-元素组解交织为3个向量. 它能将3元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B 平面数据, 交织为 已打包的RGB像素数据).
  Mnemonic: `element_ref(i, data0, data1, data2) := (0==(i%3))?( x[i2] ):( (1==(i%3))?( y[i2] ):( z[i2] ) )`, `i2 := i/3`.
- `YGroup3ZipX2[/_Bit128]`: Interleave 3 vectors into 3-element groups and process 2x data (将3-元素组解交织为3个向量, 且处理2倍数据).
  Mnemonic: `(data0, data1, data2) = YGroup3Zip(x, y, z)`, `(data3, data4, data5) = YGroup3Zip(xB, yB, zB)`.
- `YGroup4Unzip[/_Bit128]`: De-Interleave 4-element groups into 4 vectors. It converts the 4-element groups AoS to SoA. It can also deinterleave packed RGBA pixel data into R,G,B,A planar data (将4-元素组解交织为4个向量. 它能将4元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGBA像素数据, 解交织为 R,G,B,A 平面数据).
  Mnemonic: `x[i] =: element_ref(4*i, data0, data1, data2, data3)`, `y[i] =: element_ref(4*i+1, data0, data1, data2, data3)`, `z[i] =: element_ref(4*i+2, data0, data1, data2, data3)`, `w[i] =: element_ref(4*i+3, data0, data1, data2, data3)`.
- `YGroup4Zip[/_Bit128]`: Interleave 4 vectors into 4-element groups. It converts the 4-element groups SoA to AoS. It can also interleave R,G,B,A planar data into packed RGBA pixel data (将4个向量交织为4-元素组. 它能将4元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B,A 平面数据, 交织为 已打包的RGBA像素数据).
  Mnemonic: `element_ref(i, data0, data1, data2, data3) := (0==(i&3))?( x[i2] ):( (1==(i&3))?( y[i2] ):( (2==(i&3))?( z[i2] ):( w[i2] ) ) )`, `i2 := i/4`.
- `YGroup6Unzip_Bit128`: De-Interleave 6-element groups into 6 vectors. It converts the 6-element groups AoS to SoA  (将6-元素组解交织为6个向量. 它能将6元素组的 数组结构体 转为 结构体数组). It is specialized for process 128-bit element (它专门用于处理128位元素).
  Mnemonic: `x[i] =: element_ref(6*i, data0, data1, data2, data3, data4, data5)`, `y[i] =: element_ref(6*i+1, data0, data1, data2, data3, data4, data5)`, `z[i] =: element_ref(6*i+2, data0, data1, data2, data3, data4, data5)`, `w[i] =: element_ref(6*i+3, data0, data1, data2, data3, data4, data5)`, `u[i] =: element_ref(6*i+4, data0, data1, data2, data3, data4, data5)`, `v[i] =: element_ref(6*i+5, data0, data1, data2, data3, data4, data5)`.
- `YGroup6Zip_Bit128`: Interleave 6 vectors into 6-element groups. It converts the 6-element groups SoA to AoS (将6个向量交织为6-元素组. 它能将6元素组的 结构体数组 转为 数组结构体). It is specialized for process 128-bit element (它专门用于处理128位元素).
  Mnemonic: `element_ref(i, data0, data1, data2, data3, data4, data5) := (0==(i%6))?( x[i2] ):( (1==(i%6))?( y[i2] ):( (2==(i%6))?( z[i2] ):( (3==(i%6))?( w[i2] ):( (4==(i%6))?( u[i2] ):( v[i2] ) ) ) ) )`, `i2 := i/6`.

##### Methods of INumber (数字性接口的方法)
Summary (概要):
- Provides the vector methods of clamp (提供限制的向量方法): YClamp, YMaxNumber, YMinNumber .
- Provides the vector methods of check sign (提供符号判断的向量方法): YCopySign, YSign, YSignFloat .

List (列表):
- `YClamp`: Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
  Mnemonic: `rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])` .
- `YCopySign`: Copies the sign of a value to the sign of another value (将一个值的符号复制到另一个值).
  Mnemonic: `rt[i] := copySign(value[i], sign[i])`.
- `YMaxNumber`: Computes the maximum number of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大数值). The maxNumber method matches the IEEE 754:2019 maximumNumber function. This requires `NaN` inputs to not be propagated back to the caller and for `-0.0` to be treated as less than `+0.0` (maxNumber方法与 IEEE 754:2019 maximumNumber 函数匹配。 这要求 `NaN` 输入不传播回调用方，且 `-0.0` 被视为小于 `+0.0`).
  Mnemonic: `rt[i] := maxNumber(left[i], right[i]).
- `YMinNumber`: Computes the minimum number of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小数值). The minNumber method matches the IEEE 754:2019 minimumNumber function. This requires `NaN` inputs to not be propagated back to the caller and for `-0.0` to be treated as less than `+0.0` (minNumber方法与 IEEE 754:2019 minimumNumber 函数匹配。 这要求 `NaN` 输入不传播回调用方，且 `-0.0` 被视为小于 `+0.0`).
  Mnemonic: `rt[i] := minNumber(left[i], right[i]).
- `YSign`: Determine the sign of each element (判断各个元素的符号).
  Mnemonic: `rt[i] := sign(value[i])`.
- `YSignFloat`: Determine the sign of each element and returns a floating point number (判断各个元素的符号并返回浮点数).
  Mnemonic: `rt[i] := signFloat(value[i])`.

##### Methods of INumberBase (数字基本性接口的方法)
Summary (概要):
- Provides the vector methods of check floating number (提供浮点数判断的向量方法): YIsEvenInteger, YIsFinite, YIsInfinity, YIsInfinityOrNaN, YIsInteger, YIsNaN, YIsNegative, YIsNegativeZero, YIsNegativeInfinity, YIsNormal, YIsNotNaN, YIsOddInteger, YIsPositive, YIsPositiveInfinity, YIsSubnormal, YIsZero, YIsZeroOrSubnormal.

List (列表):
- `YIsEvenInteger`: Determines if a element represents an even integral number (确定元素是否为偶数整数).
  Mnemonic: `rt[i] := to_mask(isEvenInteger(value[i]))` .
- `YIsFinite`: Determines if a element is finite. It contains zero, subnormal, and normal. It does not contain infinity, NaN (确定元素是否为有限值. 它包含 零、次正规数、正规数. 它不含无穷大、非数).
  Mnemonic: `rt[i] := to_mask(isFinite(value[i]))` .
- `YIsInfinity`: Determines if a element is infinite (确定元素是否为无穷大).
  Mnemonic: `rt[i] := to_mask(isInfinity(value[i]))` .
- `YIsInfinityOrNaN`: Determines if a element is infinite or NaN (确定元素是否为无穷大或非数).
  Mnemonic: `rt[i] := to_mask(isInfinityOrNaN(value[i]))` .
- `YIsInteger`: Determines if a element represents an integral number (确定元素是否为整数).
  Mnemonic: `rt[i] := to_mask(isInteger(value[i]))` .
- `YIsNaN`: Determines if a element is NaN (确定元素是否为非数).
  Mnemonic: `rt[i] := to_mask(isNaN(value[i]))` .
- `YIsNegative`: Determines if a element represents a negative number or negative zero (确定元素是否为负数或负零).
  Mnemonic: `rt[i] := to_mask(isNegative(value[i])) = to_mask((value[i]<0) || isNegativeZero(value[i]))` .
- `YIsNegativeInfinity`: Determines if a element is negative infinity (确定元素是否为负无穷大).
  Mnemonic: `rt[i] := to_mask(isNegativeInfinity(value[i]))` .
- `YIsNegativeZero`: Determines if a element represents a negative zero (确定元素是否为负零).
  Mnemonic: `rt[i] := to_mask(isNegativeZero(value[i]))` .
- `YIsNormal`: Determines if a element is normal (确定元素是否为正规数).
  Mnemonic: `rt[i] := to_mask(isNormal(value[i]))` .
- `YIsNotNaN`: Determines if a element is not NaN (确定元素是否不为非数).
  Mnemonic: `rt[i] := to_mask(isNotNaN(value[i])) = to_mask(!isNaN(value[i]))` .
- `YIsOddInteger`: Determines if a element represents an odd integral number (确定元素是否为奇数整数).
  Mnemonic: `rt[i] := to_mask(isOddInteger(value[i]))` .
- `YIsPositive`: Determines if a element represents zero or a positive number (确定元素是否为零或正数).
  Mnemonic: `rt[i] := to_mask(isPositive(value[i]))` .
- `YIsPositiveInfinity`: Determines if a element is positive infinity (确定元素是否为正无穷大).
  Mnemonic: `rt[i] := to_mask(isPositiveInfinity(value[i]))` .
- `YIsSubnormal`: Determines if a element is subnormal (确定元素是否为次正规数).
  Mnemonic: `rt[i] := to_mask(isSubnormal(value[i]))` .
- `YIsZero`: Determines if a element is zero (确定元素是否为零).
  Mnemonic: `rt[i] := to_mask(0==value[i])` .
- `YIsZeroOrSubnormal`: Determines if a element is zero or subnormal (确定元素是否为零或次正规数).
  Mnemonic: `rt[i] := to_mask(isZeroOrSubnormal(value[i]))` .

##### Methods of shuffle (换位的方法)
Summary (概要):
- Provides vector methods for group-based shuffle (提供基于组的换位的向量方法): YShuffleG2, YShuffleG4, YShuffleG4X2. Also provides ShuffleControlG2/ShuffleControlG4 enum.
- Provides vector methods for indices-based shuffle (提供基于索引的换位的向量方法): YShuffleInsert, YShuffleKernel, YShuffleX2, YShuffleX2Insert, YShuffleX2Kernel, YShuffleX3, YShuffleX3Insert, YShuffleX3Kernel, YShuffleX4, YShuffleX4Insert, YShuffleX4Kernel.

List (列表):
- `YShuffleG2`: For each 2-element groups in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
  Mnemonic: View for group: `rt.xy = shuffleG2_ref(control, source)`. View for element: `rt[i] := source[(i&(~1)) | ((control >> (i&1)) & 1)]`.
- `YShuffleG4[/_Const]`: For each 4-element groups in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
  Mnemonic: View for group: `rt.xyzw = shuffleG4_ref(control, source)`. View for element: `rt[i] := source[(i&(~3)) | ((control >> ((i&3)*2)) & 3)]`.
- `YShuffleG4X2[/_Const]`: For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
  Mnemonic: View for group: `rt.xyzw = shuffleG4_ref(control, source0, source1)`. View for element: `element_ref(i, result0, result1) := element_ref((i&(~3)) | ((control >> ((i&3)*2)) & 3), source0, source1)`.
- `YShuffleInsert[/_Args/_Core]`: Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<Count)?( vector[indices[i]] ):back[i]`.
- `YShuffleKernel[/_Args/_Core]`: Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the IndexMask mask to constrain the parameters (可使用 IndexMask 掩码来约束参数).
  Mnemonic: `rt[i] := vector[indices[i]]`. Conditions: `0<=indices[i] && indices[i]<Count`.
- `YShuffleX2[/_Args/_Core]`: Shuffle and clear on 2 vectors (在2个向量上进行换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<(Count*2))?( element_ref(indices[i], vector0, vector1) ):0`.
- `YShuffleX2Insert[/_Args/_Core]`: Shuffle and insert on 2 vectors (在2个向量上进行换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<(Count*2))?( element_ref(indices[i], vector0, vector1) ):back[i]`.
- `YShuffleX2Kernel[/_Args/_Core]`: Only shuffle on 2 vectors (在2个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the IndexMask mask to constrain the parameters (可使用 IndexMask 掩码来约束参数).
  Mnemonic: `rt[i] := element_ref(indices[i], vector0, vector1)`. Conditions: `0<=indices[i] && indices[i]<(Count*2)`.
- `YShuffleX3[/_Args/_Core]`: Shuffle and clear on 3 vectors (在3个向量上进行换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<3*Count)?( element_ref(indices[i], vector0, vector1, vector2) ):0`.
- `YShuffleX3Insert[/_Args/_Core]`: Shuffle and insert on 3 vectors (在3个向量上进行换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<3*Count)?( element_ref(indices[i], vector0, vector1, vector2) ):back[i]`.
- `YShuffleX3Kernel[/_Args/_Core]`: Only shuffle on 3 vectors (在3个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的).
  Mnemonic: `rt[i] := element_ref(indices[i], vector0, vector1, vector2)`. Conditions: `0<=indices[i] && indices[i]<(Count*3)`.
- `YShuffleX4[/_Args/_Core]`: Shuffle and clear on 4 vectors (在4个向量上进行换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):0`.
- `YShuffleX4Insert[/_Args/_Core]`: Shuffle and insert on 4 vectors (在4个向量上进行换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):back[i]`.
- `YShuffleX4Kernel[/_Args/_Core]`: Only shuffle on 4 vectors (在4个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the IndexMask mask to constrain the parameters (可使用 IndexMask 掩码来约束参数).
  Mnemonic: `rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)`. Conditions: `0<=indices[i] && indices[i]<(Count*4)`.

##### Others (其他)
Summary (概要):
- Provides the vector methods of bitwise operations (提供位运算的向量方法): YBitToByte, YBitToInt16, YBitToInt32, YBitToInt64, YOrNot.
- Provides the vector methods of compare (提供比较的向量方法): YIsAllTrue, YIsAnyTrue, YIsNotEquals.
- Provides the vector methods of narrow saturate (提供缩窄饱和的向量方法): YNarrowSaturate, YNarrowSaturateUnsigned .
- Provides the vector methods of round (提供舍入的向量方法): YRoundToEven, YRoundToZero .

List (列表):
- `YBitToByte`: Converts binary bits to each element of the Byte vector (将各个二进制位转换为 Byte 向量的每个元素). Bit 0 meaning is 0, bit 1 meaning is 1 for all bits (`byte.MaxValue`).
  Mnemonic: `rt[i] := to_mask(0 != ((value>>i)&1))` .
- `YBitToInt16`: Converts binary bits to each element of the Int16 vector (将各个二进制位转换为 Int16 向量的每个元素). Bit 0 meaning is 0, bit 1 meaning is 1 for all bits (-1).
  Mnemonic: `rt[i] := to_mask(0 != ((value>>i)&1))` .
- `YBitToInt32`: Converts binary bits to each element of the Int32 vector (将各个二进制位转换为 Int32 向量的每个元素). Bit 0 meaning is 0, bit 1 meaning is 1 for all bits (-1).
  Mnemonic: `rt[i] := to_mask(0 != ((value>>i)&1))` .
- `YBitToInt64`: Converts binary bits to each element of the Int64 vector (将各个二进制位转换为 Int64 向量的每个元素). Bit 0 meaning is 0, bit 1 meaning is 1 for all bits (-1).
  Mnemonic: `rt[i] := to_mask(0 != ((value>>i)&1))` .
- `YIsAllTrue`: Checks if all elements of the vector is true (检查向量中所有元素是不是都为true).
  Mnemonic: `rt := value[0] && value[1] && value[2] && ... && value[Count-1]` . The element of value must be 0 or AllBitsSet (Signed integer value -1).
- `YIsAnyTrue`: Checks if any elements of the vector is true (检查向量中任一元素是不是为true).
  Mnemonic: `rt := value[0] || value[1] || value[2] || ... || value[Count-1]` . The element of value must be 0 or AllBitsSet (Signed integer value -1).
- `YIsNotEquals`: Compares two vectors to determine if they are not equal on a per-element basis (比较两个向量，确定它们每个元素是否不相等).
  Mnemonic: `rt[i] := to_mask(left[i] != right[i])`.
- `YNarrowSaturate`: Saturate narrows two Vector instances into one Vector  (将两个 Vector 实例饱和缩窄为一个 Vector ).
  Mnemonic: `rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))`.
- `YNarrowSaturateUnsigned`: Saturate narrows two signed Vector instances into one unsigned Vector  (将两个有符号 Vector 实例饱和缩窄为一个无符号 Vector ).
  Mnemonic: `rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))`.
- `YOrNot`: Computes the bitwise-or of a given vector and the ones complement of another vector (计算一个给定的向量和另一个向量反码的位或).
  Mnemonic: `rt[i] := left[i] | ~right[i]`.
- `YRoundToEven`: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: `MidpointRounding.ToEven`.
  Mnemonic: `rt[i] := round_to_even(value[i])` .
- `YRoundToZero`: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: `MidpointRounding.ToZero`.
  Mnemonic: `rt[i] := round_to_zero(value[i])` .


## Base methods for vectors  (向量的基本方法)
Its supports ExType,and the element type can also be (它们支持扩展类型, 元素类型还可以为): ExInt128, ExUInt128, Int128, UInt128.

### Static methods (静态方法)
Types: Vectors, Vector128s, Vector256s, Vector512s .

List of generic methods (泛型方法的列表):
- `Count<T>(TVector<T>)`: Returns the number of elements stored in the vector (返回存储在向量中的元素数量).
- `Create<T>(TVectorShorter<T>, TVectorShorter<T>)`②: Create a new vector instance from two shorter vector instances. (从两个更短的向量实例, 来创建新的向量实例).
- `Create<T>(T)`: Creates a new vector instance with all elements initialized to the specified value (创建新的向量实例，其中所有元素已初始化为指定值).
- `Create<T>(T[])`: Creates a new vector from a given array (从给定数组创建一个新的向量).
- `Create<T>(T[], int)`: Creates a new vector from a given array starting at a specified index position (于指定索引位置开始，从指定数组创建一个向量).
- `Create<T>(ReadOnlySpan<T>)`: Creates a new vector from a given read-only span of bytes (根据给定的只读跨度构造一个向量).
- `Create<T>(Span<T>)`: Creates a new vector from a given span of bytes (根据给定的跨度构造一个向量).
- `CreatePadding<T>(ReadOnlySpan<T>)`: Padding creates a new vector from a given span (从指定跨度补齐创建一个向量). The element after values is initialized to 0(values 之后的元素会初始化为0).
- `CreatePadding<T>(T[], int, int)`: Padding creates a new vector from a given span starting at a specified index position (于指定索引位置开始，从指定跨度补齐创建一个向量). The element after values is initialized to 0(values 之后的元素会初始化为0).
- `CreatePadding<T>(params T[])`: Padding creates a new vector from a given array (从给定数组补齐创建一个新的向量). The element after values is initialized to 0(values 之后的元素会初始化为0).
- `CreateRotate<T>(ReadOnlySpan<T>)`: Rotate creates a new vector from a given span starting at a specified index position (于指定索引位置开始，从指定跨度旋转创建一个向量).
- `CreateRotate<T>(T[], int, int)`: Rotate creates a new <see cref="Vector256{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度旋转创建一个向量).
- `CreateRotate<T>(params T[])`: Padding creates a new vector from a given array (从给定数组旋转创建一个新的向量).
- `CreateByFunc<T>(Func<int, T>)`: Creates a new vector from a from the given Func (从给定 Func 创建一个新的向量 ) .
- `CreateByDouble<T>(double)`: Creates a vector whose components are of a specified double value (创建一个向量，其元素为指定的双精度浮点值).
- `CreateByDoubleLoop<T>(double, double)`: Creates a vector from double value `for` loop (创建一个向量，其元素来自双精度浮点值的`for`循环).
- `CreateByBits<T>(long)`: Creates a vector whose components are of a specified integer bits (创建一个向量，其元素为指定的整数位).
- `CreateBy128Bits<T>(ExInt128)`: Creates a vector whose components are of a specified 128-bits integer (创建一个向量，其元素为指定的128位整数).
- `IsNativeSupported<T>()`: Determines if this element type is native supported (判断是否原生支持这种元素类型).

List of non-generic methods (非泛型方法的列表):
- `Create(ExInt128)`: Creates a new vector instance of element type ExInt128 with all elements initialized to the specified value (创建新的元素类型为UInt128的向量实例，其中所有元素已初始化为指定值).
- `Create(ExUInt128)`: Creates a new vector instance of element type ExUInt128 with all elements initialized to the specified value (创建新的元素类型为UInt128的向量实例，其中所有元素已初始化为指定值).
- `Create(Int128)`: Creates a new vector instance of element type Int128 with all elements initialized to the specified value (创建新的元素类型为UInt128的向量实例，其中所有元素已初始化为指定值).
- `Create(UInt128)`: Creates a new vector instance of element type UInt128 with all elements initialized to the specified value (创建新的元素类型为UInt128的向量实例，其中所有元素已初始化为指定值).
- `CreateScalar(ExInt128)`: Creates a new vector instance of element type ExInt128 with the first element initialized to the specified value and the remaining elements initialized to zero (创建新的元素类型为UInt128的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零).
- `CreateScalar(ExUInt128)`: Creates a new vector instance of element type ExUInt128 with the first element initialized to the specified value and the remaining elements initialized to zero (创建新的元素类型为UInt128的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零).
- `CreateScalar(Int128)`: Creates a new vector instance of element type Int128 with the first element initialized to the specified value and the remaining elements initialized to zero (创建新的元素类型为UInt128的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零).
- `CreateScalar(UInt128)`: Creates a new vector instance of element type UInt128 with the first element initialized to the specified value and the remaining elements initialized to zero (创建新的元素类型为UInt128的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零).
- `CreateScalarUnsafe(ExInt128)`: Creates a new vector instance of element type ExInt128 with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为UInt128的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).
- `CreateScalarUnsafe(ExUInt128)`: Creates a new vector instance of element type ExUInt128 with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为UInt128的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).
- `CreateScalarUnsafe(Int128)`: Creates a new vector instance of element type Int128 with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为UInt128的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).
- `CreateScalarUnsafe(UInt128)`: Creates a new vector instance of element type UInt128 with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为UInt128的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).

### Extension methods (扩展方法)
Types: Vector, Vector128, Vector256, Vector512 .
Namespace: Zyl.VectorTraits

List of generic methods (泛型方法的列表):
- `BitEquals<T>(TVector<T>, TVector<T>)`: Returns a value that indicates whether this instance is binary equal to a specified vector (返回一个值，该值指示此实例是否与指定的向量二进制相等).
- `ExAs<TFrom,TTo>(TVector<TFrom>)`: Reinterprets a vector of type  as a new vector of type TTo. It supports ExType, so there is no element type check (将 TFrom类型的向量 重新解释为 TTo类型的新向量. 它支持扩展类型, 故没有元素类型检查).
- `ExAsVector<T>(TVector<T>)`③: Reinterprets a `Vector128<T>`(/`Vector256<T>`/`Vector512<T>`) as a new Vector (将 `Vector128<T>`(/`Vector256<T>`/`Vector512<T>`) 重新解释为新的 `Vector<T>`). It supports ExType, so there is no element type check (它支持扩展类型, 故没有元素类型检查).
- `ExAsVector128<T>(TVector<T>)`③:  Reinterprets a  `Vector<T>` as a new `Vector128<T>` (将 Vector 重新解释为新的 `Vector128<T>`). It supports ExType, so there is no element type check (它支持扩展类型, 故没有元素类型检查).
- `ExAsVector256<T>(TVector<T>)`③: Reinterprets a  `Vector<T>` as a new `Vector256<T>` (将 Vector 重新解释为新的 `Vector256<T>`). It supports ExType, so there is no element type check (它支持扩展类型, 故没有元素类型检查).
- `ExAsVector512<T>(TVector<T>)`③:  Reinterprets a  `Vector<T>` as a new `Vector512<T>` (将 Vector 重新解释为新的 `Vector512<T>`). It supports ExType, so there is no element type check (它支持扩展类型, 故没有元素类型检查).
- `ExGetElement<T>(TVector<T>, Int32)`: Gets the element at the specified index. It is unsafe method, it ignores the index range check (获取指定索引处的元素. 它是非安全的, 它忽略了索引的范围检查).
- `ExGetLower<T>(TVector<T>)`: Gets the value of the lower bits as a new shorter vector (获取低位的值作为新的较短向量).
- `ExGetUpper<T>(TVector<T>)`: Gets the value of the upper bits as a new shorter vector (获取高位的值作为新的较短向量).
- `ExToScalar<T>(TVector<T>)`: Converts the given vector to a scalar containing the value of the first element (将给定向量转换为首个元素的值的标量).
- `ExToVector128<T>(TVector<T>)`③: Converts the given vector to a new `Vector128<T>` with the lower 64-bits set to the value of the given vector and the upper 64-bits initialized to zero (将给定向量转换为新 `Vector128<T>` 向量，其中较低的 64 位设置为给定向量的值，并将高 64 位初始化为零).
- `ExToVector128Unsafe<T>(TVector<T>)`③: Converts the given vector to a new `Vector128<T>` with the lower 64-bits set to the value of the given vector and the upper 64-bits left uninitialized (将给定向量转换为新 `Vector128<T>` 向量，其中低 64 位设置为给定向量的值，而高 64 位则未初始化).
- `ExToVector256<T>(TVector<T>)`③: Converts the given vector to a new `Vector256<T>` with the lower 128-bits set to the value of the given vector and the upper 128-bits initialized to zero (将给定向量转换为新 `Vector256<T>` 向量，其中较低的 128 位设置为给定向量的值，并将高 128 位初始化为零).
- `ExToVector256Unsafe<T>(TVector<T>)`③: Converts the given vector to a new `Vector256<T>` with the lower 128-bits set to the value of the given vector and the upper 128-bits left uninitialized (将给定向量转换为新 `Vector256<T>` 向量，其中低 128 位设置为给定向量的值，而高 128 位则未初始化).
- `ExToVector512<T>(TVector<T>)`③: Converts the given vector to a new `Vector512<T>` with the lower 256-bits set to the value of the given vector and the upper 256-bits initialized to zero (将给定向量转换为新 `Vector512<T>` 向量，其中较低的 256 位设置为给定向量的值，并将高 256 位初始化为零).
- `ExToVector512Unsafe<T>(TVector<T>)`③: Converts the given vector to a new `Vector512<T>` with the lower 256-bits set to the value of the given vector and the upper 256-bits left uninitialized (将给定向量转换为新 `Vector512<T>` 向量，其中低 256 位设置为给定向量的值，而高 256 位则未初始化).
- `ExWithLower<T>(TVector<T>, TVectorShorter<T>)`③: Creates a new `Vector256<T>` with the lower 128-bits set to the specified value and the upper 128-bits set to the same value as that in the given vector (创建一个新的 <see cref="Vector256{T}" />，将低 128 位设置为指定值，并将高 128 位设置为与给定向量中的值相同的值).
- `ExWithUpper<T>(TVector<T>, TVectorShorter<T>)`③: Creates a new `Vector256<T>` with the upper 128-bits set to the specified value and the lower 128-bits set to the same value as that in the given vector (创建一个新的 <see cref="Vector256{T}" />，将高 128 位设置为指定值，并将低 128 位设置为与给定向量中的值相同的值).

List of non-generic methods (非泛型方法的列表):
- `ExAsByte<T>(TVector<T>)`: Reinterprets a vector as a new vector of type Byte (将向量重新解释为 Byte类型的新向量).
- `ExAsDouble<T>(TVector<T>)`: Reinterprets a vector as a new vector of type Double (将向量重新解释为 Double类型的新向量).
- `ExAsExInt128<T>(TVector<T>)`③: Reinterprets a vector as a new vector of type ExInt128 (将向量重新解释为 ExInt128类型的新向量).
- `ExAsExUInt128<T>(TVector<T>)`③: Reinterprets a vector as a new vector of type ExUInt128 (将向量重新解释为 ExUInt128类型的新向量).
- `ExAsInt16<T>(TVector<T>)`: Reinterprets a vector as a new vector of type Int16 (将向量重新解释为 Int16类型的新向量).
- `ExAsInt32<T>(TVector<T>)`: Reinterprets a vector as a new vector of type Int32 (将向量重新解释为 Int32类型的新向量).
- `ExAsInt64<T>(TVector<T>)`: Reinterprets a vector as a new vector of type Int64 (将向量重新解释为 Int64类型的新向量).
- `ExAsInt128<T>(TVector<T>)`③: Reinterprets a vector as a new vector of type Int128 (将向量重新解释为 Int128类型的新向量).
- `ExAsSByte<T>(TVector<T>)`: Reinterprets a vector as a new vector of type SByte (将向量重新解释为 SByte类型的新向量).
- `ExAsSingle<T>(TVector<T>)`: Reinterprets a vector as a new vector of type Single (将向量重新解释为 Single类型的新向量).
- `ExAsUInt16<T>(TVector<T>)`: Reinterprets a vector as a new vector of type UInt16 (将向量重新解释为 UInt16类型的新向量).
- `ExAsUInt32<T>(TVector<T>)`: Reinterprets a vector as a new vector of type UInt32 (将向量重新解释为 UInt32类型的新向量).
- `ExAsUInt64<T>(TVector<T>)`: Reinterprets a vector as a new vector of type UInt64 (将向量重新解释为 UInt64类型的新向量).
- `ExAsUInt128<T>(TVector<T>)`③: Reinterprets a vector as a new vector of type UInt128 (将向量重新解释为 UInt128类型的新向量).

### Other extension methods (其他扩展方法)
Types: Vector, Vector128, Vector256, Vector512 .
Namespace:  Zyl.VectorTraits.Extensions

List of generic methods (泛型方法的列表):
- `AsSigned<T>(TVector<T>)`④: Reinterprets a unsigned integer vector as a new signed integer vector (将无符号整数向量, 重新解释为有符号整数向量).
- `AsUnsigned<T>(TVector<T>)`④: Reinterprets a signed integer vector as a new unsigned integer vector (将有符号整数向量, 重新解释为无符号整数向量).

### Utility methods (工具方法)

- `ExVectorUtil.Format`: Safely Format or ToString function. It can safely format vector types as strings, or simply convert vector types to strings (安全地的 Format 或 ToString 函数. 它能安全的将向量类型 进行字符串格式化，或简单的将向量类型转为字符串).
- `ExVectorUtil.ToString`: Safely convert interpolated string to String (安全地将内插字符串转为 String).
- `VectorTextUtil.Format`: Format a string, append a hexadecimal string intelligently to the end of the line (格式化字符串，智能在行尾追加十六进制字符串).
- `VectorTextUtil.WriteLine`: Writes formatted strings and hexadecimal values, new lines in the text stream (在文本流写入 已格式化的字符串和十六进制值、新行).

## Endnote (尾注)

Endnote (尾注):
- ①: It also works for Vector (它也适用于Vector).
- ②: (它仅适用于固定大小的向量).
- ③: (它仅适用于特定大小的向量).
- ④: (它支持不同元素类型的重载, 用 T 代表重载的类型).
