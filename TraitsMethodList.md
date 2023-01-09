# Traits method list

## Vector traits methods (向量特性方法)
Types: Vector, Vector128, Vector256 .

- `Ceiling`: Computes the ceiling of each element in a vector (计算向量中每个元素的向上舍入).
  Mnemonic: `r[i] := ceiling(value[i])` .
- `Floor`: Computes the floor of each element in a vector (计算向量中每个元素的向下舍入).
  Mnemonic: `r[i] := floor(value[i])` .
- `ShiftLeft`: Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
  Mnemonic: `r[i] := value[i] << shiftAmount`, `shiftAmount &= (T.BitSize-1)`.
- `ShiftLeftFast`: Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check `shiftAmount`, please use `Scalars.LimitShiftCount` first.
  Mnemonic: `r[i] := value[i] << shiftAmount`.
- `ShiftRightArithmetic`: Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
  Mnemonic: `r[i] := value[i] >> shiftAmount`, `shiftAmount &= (T.BitSize-1)`.
- `ShiftRightArithmeticFast`: Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check `shiftAmount`, please use `Scalars.LimitShiftCount` first, and shiftAmount must not be 0 .
  Mnemonic: `r[i] := value[i] >> shiftAmount`.
- `ShiftRightLogical`: Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
  Mnemonic: `r[i] := value[i] >>> shiftAmount`, `shiftAmount &= (T.BitSize-1)`.
- `ShiftRightLogicalFast`: Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check `shiftAmount`, please use `Scalars.LimitShiftCount` first, and shiftAmount must not be 0 .
  Mnemonic: `r[i] := value[i] >>> shiftAmount`.

## WVector supplement traits methods (W向量补充的特性方法)
Types: Vector128, Vector256 .

- `AndNot`: Computes the bitwise-and of a given vector and the ones complement of another vector (计算一个给定的向量和另一个向量反码的位与).
  Mnemonic: `r[i] := left[i] & ~right[i]`.
- `BitwiseAnd`: Computes the bitwise-and of two vectors (计算两个向量的位与).
  Mnemonic: `r[i] := left[i] & right[i]`.
- `BitwiseOr`: Computes the bitwise-or of two vectors (计算两个向量的位或).
  Mnemonic: `r[i] := left[i] | right[i]`.
- `ConditionalSelect`: Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
  Mnemonic: `r[i] := (left[i] & condition[i]) | (right[i] & ~condition[i])`.
- `Negate`: Computes the negate of a vector (计算向量的相反数).
  Mnemonic: `r[i] := -vector[i]`.
- `OnesComplement`: Computes the ones-complement of a vector (计算向量的反码).
  Mnemonic: `r[i] := ~vector[i]`.
- `Xor`: Computes the exclusive-or of two vectors (计算两个向量的位异或).
  Mnemonic: `r[i] := left[i] ^ right[i]`.
