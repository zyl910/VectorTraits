# Traits method list

## Vector traits method list (向量特性方法列表)
Types: Vector, Vector128, Vector256 .

- `ConditionalSelect`: Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
  Mnemonic: `f(condition, left, right) = (left & condition) | (right & ~condition)`.
- `ShiftLeft`: Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
  Mnemonic: `f({ value[i] }, shiftCount) = { value[i] << shiftCount }`, `shiftCount &= (T.BitSize-1)`.
- `ShiftLeftFast`: Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check `shiftCount`, please use `Scalars.LimitShiftCount` first.
  Mnemonic: `f({ value[i] }, shiftCount) = { value[i] << shiftCount }`.
- `ShiftRightArithmetic`: Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
  Mnemonic: `f({ value[i] }, shiftCount) = { value[i] >> shiftCount }`, `shiftCount &= (T.BitSize-1)`.
- `ShiftRightArithmeticFast`: Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check `shiftCount`, please use `Scalars.LimitShiftCount` first.
  Mnemonic: `f({ value[i] }, shiftCount) = { value[i] >> shiftCount }`.
- `ShiftRightLogical`: Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
  Mnemonic: `f({ value[i] }, shiftCount) = { value[i] >>> shiftCount }`, `shiftCount &= (T.BitSize-1)`.
- `ShiftRightLogicalFast`: Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check `shiftCount`, please use `Scalars.LimitShiftCount` first.
  Mnemonic: `f({ value[i] }, shiftCount) = { value[i] >>> shiftCount }`.
