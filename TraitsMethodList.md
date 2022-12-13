# Traits method list

## Vector traits methods (向量特性方法)
Types: Vector, Vector128, Vector256 .

- `ShiftLeft`: Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
  Mnemonic: `f({ value[i] }, shiftAmount) = { value[i] << shiftAmount }`, `shiftAmount &= (T.BitSize-1)`.
- `ShiftLeftFast`: Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check `shiftAmount`, please use `Scalars.LimitShiftCount` first.
  Mnemonic: `f({ value[i] }, shiftAmount) = { value[i] << shiftAmount }`.
- `ShiftRightArithmetic`: Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
  Mnemonic: `f({ value[i] }, shiftAmount) = { value[i] >> shiftAmount }`, `shiftAmount &= (T.BitSize-1)`.
- `ShiftRightArithmeticFast`: Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check `shiftAmount`, please use `Scalars.LimitShiftCount` first, and shiftAmount must not be 0 .
  Mnemonic: `f({ value[i] }, shiftAmount) = { value[i] >> shiftAmount }`.
- `ShiftRightLogical`: Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
  Mnemonic: `f({ value[i] }, shiftAmount) = { value[i] >>> shiftAmount }`, `shiftAmount &= (T.BitSize-1)`.
- `ShiftRightLogicalFast`: Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check `shiftAmount`, please use `Scalars.LimitShiftCount` first, and shiftAmount must not be 0 .
  Mnemonic: `f({ value[i] }, shiftAmount) = { value[i] >>> shiftAmount }`.

## WVector supplementary traits methods (W向量增补的特性方法)
Types: Vector128, Vector256 .

- `ConditionalSelect`: Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
  Mnemonic: `f(condition, left, right) = (left & condition) | (right & ~condition)`.
