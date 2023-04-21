# Benchmark - YShuffleG2
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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	28917
SumYShuffleG2Scalar	418.647	626.170
SumYShuffleG2VectorBase	411.328	637.311	1.017793
SumYShuffleG2VectorTraits	18.300	14325.197	22.877503
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	19.312	13574.022	21.677868
SumYShuffleG2_ConstVectorTraits	106.415	2463.420	3.934110
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	110.569	2370.874	3.786312

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-1234767990
SumYShuffleG2Scalar	530.272	494.357
SumYShuffleG2VectorBase	532.324	492.452	0.996146
SumYShuffleG2VectorTraits	33.730	7771.883	15.721189
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256_AvxByte	32.139	8156.671	16.499549
SumYShuffleG2Vector256_AvxInt32	32.412	8087.912	16.360463
SumYShuffleG2Vector256Traits	34.100	7687.569	15.550636
SumYShuffleG2_ConstVectorTraits	126.040	2079.843	4.207167
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	113.908	2301.370	4.655278

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-5475020453166212109
SumYShuffleG2Scalar	600.536	436.516
SumYShuffleG2VectorBase	782.330	335.081	0.767625
SumYShuffleG2VectorTraits	140.398	1867.155	4.277400
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	144.235	1817.473	4.163585
SumYShuffleG2_ConstVectorTraits	313.424	836.387	1.916049
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	323.833	809.503	1.854461

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-47
SumYShuffleG2Scalar	458.408	571.857
SumYShuffleG2VectorBase	375.612	697.912	1.220431
SumYShuffleG2VectorTraits	9.890	26506.153	46.350995
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	8.553	30650.111	53.597485
SumYShuffleG2_ConstVectorTraits	8.037	32618.564	57.039696
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	8.023	32673.291	57.135397

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
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

