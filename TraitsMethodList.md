# Traits method list

## Vector traits methods (向量特性方法)
Types: Vector, Vector128, Vector256 .

- `Ceiling`: Computes the ceiling of each element in a vector (计算向量中每个元素的向上舍入).
  Mnemonic: `rt[i] := ceiling(value[i])` .
- `Floor`: Computes the floor of each element in a vector (计算向量中每个元素的向下舍入).
  Mnemonic: `rt[i] := floor(value[i])` .
- `ShiftLeft`: Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
  Mnemonic: `rt[i] := value[i] << shiftAmount`, `shiftAmount &= (T.BitSize-1)`.
- `ShiftLeftFast`: Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check `shiftAmount`, please use `Scalars.LimitShiftCount` first.
  Mnemonic: `rt[i] := value[i] << shiftAmount`.
- `ShiftRightArithmetic`: Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
  Mnemonic: `rt[i] := value[i] >> shiftAmount`, `shiftAmount &= (T.BitSize-1)`.
- `ShiftRightArithmeticFast`: Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check `shiftAmount`, please use `Scalars.LimitShiftCount` first, and shiftAmount must not be 0 .
  Mnemonic: `rt[i] := value[i] >> shiftAmount`.
- `ShiftRightLogical`: Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
  Mnemonic: `rt[i] := value[i] >>> shiftAmount`, `shiftAmount &= (T.BitSize-1)`.
- `ShiftRightLogicalFast`: Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check `shiftAmount`, please use `Scalars.LimitShiftCount` first, and shiftAmount must not be 0 .
  Mnemonic: `rt[i] := value[i] >>> shiftAmount`.

- `YClamp`: Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
  Mnemonic: `rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])` .

## WVector supplement traits methods (W向量补充的特性方法)
Types: Vector128, Vector256 .

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
- `GreaterThan`: Compares two vectors to determine which is greater on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更大).
  Mnemonic: `rt[i] := to_mask(left[i] > right[i])`.
- `LessThan`: Compares two vectors to determine which is less on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更小).
  Mnemonic: `rt[i] := to_mask(left[i] < right[i])`.
- `Max`: Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
  Mnemonic: `rt[i] := max(left[i], right[i])`.
- `Min`: Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
  Mnemonic: `rt[i] := min(left[i], right[i])`.
- `Multiply`: Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
  Mnemonic: `rt[i] := left[i] * right[i]`.
- `Negate`: Computes the negate of a vector (计算向量的相反数).
  Mnemonic: `rt[i] := -vector[i]`.
- `OnesComplement`: Computes the ones-complement of a vector (计算向量的反码).
  Mnemonic: `rt[i] := ~vector[i]`.
- `Subtract`: Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
  Mnemonic: `rt[i] := left[i] - right[i]`.
- `Xor`: Computes the exclusive-or of two vectors (计算两个向量的位异或).
  Mnemonic: `rt[i] := left[i] ^ right[i]`.
