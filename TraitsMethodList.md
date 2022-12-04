# Traits method list

## Vector/Vector128/Vector256

- `ShiftLeft`: Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
  Mnemonic: `f({ value[i] }, shiftCount) = { value[i] << shiftCount }`, `shiftCount &= (T.BitSize-1)`.
- `ShiftRightArithmetic`: Shifts (signed) each element of a vector right by the specified amount (将向量的每个带符号元素算术右移指定量).
  Mnemonic: `f({ value[i] }, shiftCount) = { value[i] >> shiftCount }`, `shiftCount &= (T.BitSize-1)`.
