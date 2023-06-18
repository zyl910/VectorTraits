# Benchmark - ConvertToSingle
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 4.5

```
```

#### .NET Core 2.1

```
```

#### .NET Core 3.1

```
```

#### .NET 5

```
```

#### .NET 6

```
```

#### .NET 7

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.3
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.3\
RuntimeInformation.FrameworkDescription:	.NET 7.0.3
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	314.508	833.504
SumBcl	39.209	6685.817	8.021337
SumTraits	39.204	6686.654	8.022342
Sum128Bcl	78.227	3351.053	4.020440
Sum128Base_Basic	467.944	560.204	0.672107
Sum128Base	78.130	3355.221	4.025441
Sum128Traits	78.195	3352.450	4.022116
Sum256Bcl	39.043	6714.178	8.055364
Sum256Base_Basic	294.395	890.450	1.068321
Sum256Base	39.169	6692.632	8.029514
Sum256Traits	39.225	6683.152	8.018140

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	323.229	811.015
SumBcl	40.745	6433.749	7.932955
SumTraits	40.492	6474.010	7.982598
Sum128Bcl	79.775	3286.037	4.051756
Sum128Base_Basic	546.751	479.458	0.591182
Sum128Base	79.446	3299.644	4.068534
Sum128Traits	79.585	3293.867	4.061411
Sum256Bcl	41.859	6262.618	7.721947
Sum256Base_Basic	350.271	748.404	0.922799
Sum256Base	40.762	6431.069	7.929650
Sum256Avx2_Add	39.538	6630.138	8.175107
Sum256Avx2_Multiply	40.490	6474.282	7.982933
Sum256Traits	39.801	6586.422	8.121205

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
[Vectors.Instance: VectorTraits256Avx2]
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
IsSupported:	True
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single, Double	# (00006780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32	# (00000780)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32	# (00000280)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

WVectorTraits128Base: OK.
WVectorTraits128AdvSimd: Requires hardware support AdvSimd!
WVectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
[Vector128s.Instance: WVectorTraits128Base]
Abs_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
Add_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
AndNot_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseAnd_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseOr_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConditionalSelect_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
GreaterThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
IsSupported:	True
LessThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Max_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Min_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
Negate_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
OnesComplement_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ShiftLeft_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
ShiftRightArithmetic_AcceleratedTypes:	Int16, Int32	# (00000280)
ShiftRightLogical_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
Shuffle_AcceleratedTypes:	None	# (00000000)
Subtract_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32	# (000007E0)
Xor_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

WVectorTraits256Base: OK.
WVectorTraits256Avx2: OK.
[Vector256s.Instance: WVectorTraits256Avx2]
Abs_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
Add_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
AndNot_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseAnd_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseOr_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConditionalSelect_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	Single, Double	# (00006000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
GreaterThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
IsSupported:	True
LessThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Max_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Min_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single, Double	# (00006780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
Negate_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
OnesComplement_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Subtract_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
Xor_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32	# (00000780)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32	# (00000280)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
```

## Arm

### AWS Arm t4g.small
`AWS Arm t4g.small`

#### .NET Core 3.1

```
```

#### .NET 5

```
```

#### .NET 6

```
```

#### .NET 7

```
```

