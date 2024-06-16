# Traits method list

## Vector traits method of official BCL library (官方BCL库的向量特性方法)
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

Remarks:
- ①: It also works for Vector (它也适用于Vector).

## Fixed width Vector supplement traits methods (固定宽度向量补充的特性方法)
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

Remarks:
- ①: It also works for Vector (它也适用于Vector).


## Vector traits method appended by this library (由本库追加的向量特性方法)
Types: Vector, Vector128, Vector256, Vector512 .

### Methods of group (组的方法)
Summary (概要):
- Provides vector methods for de-interleave (提供解交织的向量方法): YGroup2Unzip, YGroup2UnzipEven, YGroup2UnzipOdd.
- Provides vector methods for interleave (提供交织的向量方法): YGroup2Zip, YGroup2ZipHigh, YGroup2ZipLow.

- `YGroup2Unzip`: De-Interleave 2-element groups into 2 vectors (将2-元素组解交织为2个向量).
  Mnemonic: `x[i] =: element_ref(2*i, data0, data1)`, `y[i] =: element_ref(2*i+1, data0, data1)`.
- `YGroup2UnzipEven`: De-Interleave the 2-element group into 2 vectors, and return the vector of even positions (将2-元素组解交织为2个向量, 并返回偶数位置的数据).
  Mnemonic: `rt[i] =: element_ref(2*i, data0, data1)`.
- `YGroup2UnzipOdd`: De-Interleave the 2-element group into 2 vectors, and return the vector of odd positions (将2-元素组解交织为2个向量, 并返回奇数位置的数据).
  Mnemonic: `rt[i] =: element_ref(2*i+1, data0, data1)`.
- `YGroup2Zip`: Interleave 2 vectors into 2-element groups (将2个向量交织为2-元素组).
  Mnemonic: `element_ref(i, data0, data1) := (0==(i&1))?( x[i2] ):( y[i2] )`, `i2 := i/2`.
- `YGroup2ZipHigh`: Interleave 2 vectors into 2-element groups and returns the data in the high position. (将2个向量交织为2-元素组, 并返回高位置的数据).
  Mnemonic: `rt[i] := (0==(i&1))?( x[i2] ):( y[i2] )`, `i2 := (i+T.Count)/2`.
- `YGroup2ZipLow`: Interleave 2 vectors into 2-element groups and returns the data in the low position. (将2个向量交织为2-元素组, 并返回低位置的数据).
  Mnemonic: `rt[i] := (0==(i&1))?( x[i2] ):( y[i2] )`, `i2 := i/2`.

### Methods of INumber (数字性接口的方法)
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

### Methods of INumberBase (数字基本性接口的方法)
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

### Methods of shuffle (换位的方法)
Summary (概要):
- Provides vector methods for group-based shuffle (提供基于组的换位的向量方法): YShuffleG2, YShuffleG4, YShuffleG4X2. Also provides ShuffleControlG2/ShuffleControlG4 enum.
- Provides vector methods for indices-based shuffle (提供基于索引的换位的向量方法): YShuffleInsert, YShuffleKernel, YShuffleX2Kernel.

List (列表):
- `YShuffleG2`: For each 2-element group in a vector, shuffle is performed (对于一个向量中的每个 2-元素组, 进行换位).
  Mnemonic: View for group: `rt.xy = shuffleG2_ref(control, source)`. View for element: `rt[i] := source[(i&(~1)) | ((control >> (i&1)) & 1)]`.
- `YShuffleG4[/_Const]`: For each 4-element group in a vector, shuffle is performed (对于一个向量中的每个 4-元素组, 进行换位). If the count of elements in a vector is less than 4, please use YShuffleG4X2 instead (如果向量的元素数量小于4，请使用 YShuffleG4X2 代替).
  Mnemonic: View for group: `rt.xyzw = shuffleG4_ref(control, source)`. View for element: `rt[i] := source[(i&(~3)) | ((control >> ((i&3)*2)) & 3)]`.
- `YShuffleG4X2[/_Const]`: For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
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
- `YShuffleX3Kernel[/_Args/_Core]`: Only shuffle on 3 vectors (在3个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的).
  Mnemonic: `rt[i] := element_ref(indices[i], vector0, vector1, vector2)`. Conditions: `0<=indices[i] && indices[i]<(Count*3)`.
- `YShuffleX4[/_Args/_Core]`: Shuffle and clear on 4 vectors (在4个向量上进行换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):0`.
- `YShuffleX4Insert[/_Args/_Core]`: Shuffle and insert on 4 vectors (在4个向量上进行换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):back[i]`.
- `YShuffleX4Kernel[/_Args/_Core]`: Only shuffle on 4 vectors (在4个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the IndexMask mask to constrain the parameters (可使用 IndexMask 掩码来约束参数).
  Mnemonic: `rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)`. Conditions: `0<=indices[i] && indices[i]<(Count*4)`.

### Others (其他)
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

