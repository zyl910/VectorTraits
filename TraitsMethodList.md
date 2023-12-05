# Traits method list

## Vector traits method of official BCL library (官方BCL库的向量特性方法)
Types: Vector, Vector128, Vector256 .

Summary (概要):
- Support for `.NET Standard 2.1` new vector methods (支持 `.NET Standard 2.1` 新增的向量方法): ConvertToDouble, ConvertToInt32, ConvertToInt64, ConvertToSingle, ConvertToUInt32, ConvertToUInt64, Narrow, Widen .
- Support for `.NET 5.0` new vector methods (支持 `.NET 5.0` 新增的向量方法): Ceiling, Floor .
- Support for `.NET 6.0` new vector methods (支持 `.NET 6.0` 新增的向量方法): Sum .
- Support for `.NET 7.0` new vector methods (支持 `.NET 7.0` 新增的向量方法): ExtractMostSignificantBits, ShiftLeft, ShiftRightArithmetic, ShiftRightLogical, Shuffle .

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

Remarks:
- ①: It also works for Vector (它也适用于Vector).

## Fixed width Vector supplement traits methods (固定宽度向量补充的特性方法)
Types: Vector128, Vector256 .

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
- `GreaterThan`: Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
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
Types: Vector, Vector128, Vector256 .

Summary (概要):
- Provides the vector methods of bitwise operations (提供位运算的向量方法): YOrNot, YBitToElement .
- Provides the vector methods of clamp (提供限制的向量方法): YClamp .
- Provides the vector methods of compare (提供比较的向量方法): YIsAllTrue, YIsAnyTrue.
- Provides the vector methods of narrow saturate (提供缩窄饱和的向量方法): YNarrowSaturate, YNarrowSaturateUnsigned .
- Provides the vector methods of round (提供舍入的向量方法): YRoundToEven, YRoundToZero .
- Provides the vector methods of shuffle (提供换位的向量方法): YShuffleInsert, YShuffleKernel, YShuffleG2, YShuffleG4, YShuffleG4X2 . Also provides ShuffleControlG2/ShuffleControlG4 enum.

List (列表):
- `YClamp`: Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
  Mnemonic: `rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])` .
- `YIsAllTrue`: Checks if all elements of the vector is true (检查向量中所有元素是不是都为true).
  Mnemonic: `rt := value[0] && value[1] && value[2] && ... && value[Count-1]` . The element of value must be 0 or AllBitsSet (Signed integer value -1).
- `YIsAnyTrue`: Checks if any elements of the vector is true (检查向量中任一元素是不是为true).
  Mnemonic: `rt := value[0] || value[1] || value[2] || ... || value[Count-1]` . The element of value must be 0 or AllBitsSet (Signed integer value -1).
- `YOrNot`: Computes the bitwise-or of a given vector and the ones complement of another vector (计算一个给定的向量和另一个向量反码的位或).
  Mnemonic: `rt[i] := left[i] | ~right[i]`.
- `YRoundToEven`: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: `MidpointRounding.ToEven`.
  Mnemonic: `rt[i] := round_to_even(value[i])` .
- `YRoundToZero`: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: `MidpointRounding.ToZero`.
  Mnemonic: `rt[i] := round_to_zero(value[i])` .
- `YNarrowSaturate`: Saturate narrows two Vector instances into one Vector  (将两个 Vector 实例饱和缩窄为一个 Vector ).
  Mnemonic: `rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))`.
- `YNarrowSaturateUnsigned`: Saturate narrows two signed Vector instances into one unsigned Vector  (将两个有符号 Vector 实例饱和缩窄为一个无符号 Vector ).
  Mnemonic: `rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))`.
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
