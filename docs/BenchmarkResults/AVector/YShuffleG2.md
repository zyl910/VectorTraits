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
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	28917
SumYShuffleG2Scalar	437.657	598.971
SumYShuffleG2VectorBase	435.666	601.708	1.004569
SumYShuffleG2VectorTraits	12.415	21114.983	35.252083
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	17.129	15304.508	25.551325
SumYShuffleG2_ConstVectorTraits	18.285	14336.796	23.935702
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	18.325	14305.168	23.882897

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-1234767990
SumYShuffleG2Scalar	545.222	480.802
SumYShuffleG2VectorBase	526.550	497.852	1.035462
SumYShuffleG2VectorTraits	42.826	6121.160	12.731141
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256_AvxByte	44.423	5901.065	12.273376
SumYShuffleG2Vector256_AvxInt32	50.643	5176.347	10.766066
SumYShuffleG2Vector256Traits	44.351	5910.731	12.293479
SumYShuffleG2_ConstVectorTraits	44.445	5898.200	12.267416
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	46.617	5623.332	11.695729

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-5475020453166212109
SumYShuffleG2Scalar	551.628	475.219
SumYShuffleG2VectorBase	525.533	498.816	1.049655
SumYShuffleG2VectorTraits	70.885	3698.185	7.782072
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	72.345	3623.517	7.624950
SumYShuffleG2_ConstVectorTraits	73.581	3562.651	7.496869
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	73.016	3590.205	7.554851

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-47
SumYShuffleG2Scalar	390.820	670.755
SumYShuffleG2VectorBase	389.200	673.546	1.004162
SumYShuffleG2VectorTraits	10.777	24324.225	36.263970
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	10.884	24086.108	35.908971
SumYShuffleG2_ConstVectorTraits	11.001	23828.161	35.524410
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	14.401	18203.133	27.138290

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
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
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	28917
SumYShuffleG2Scalar	437.657	598.971
SumYShuffleG2VectorBase	435.666	601.708	1.004569
SumYShuffleG2VectorTraits	12.415	21114.983	35.252083
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	17.129	15304.508	25.551325
SumYShuffleG2_ConstVectorTraits	18.285	14336.796	23.935702
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	18.325	14305.168	23.882897

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-1234767990
SumYShuffleG2Scalar	545.222	480.802
SumYShuffleG2VectorBase	526.550	497.852	1.035462
SumYShuffleG2VectorTraits	42.826	6121.160	12.731141
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256_AvxByte	44.423	5901.065	12.273376
SumYShuffleG2Vector256_AvxInt32	50.643	5176.347	10.766066
SumYShuffleG2Vector256Traits	44.351	5910.731	12.293479
SumYShuffleG2_ConstVectorTraits	44.445	5898.200	12.267416
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	46.617	5623.332	11.695729

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-5475020453166212109
SumYShuffleG2Scalar	551.628	475.219
SumYShuffleG2VectorBase	525.533	498.816	1.049655
SumYShuffleG2VectorTraits	70.885	3698.185	7.782072
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	72.345	3623.517	7.624950
SumYShuffleG2_ConstVectorTraits	73.581	3562.651	7.496869
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	73.016	3590.205	7.554851

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-47
SumYShuffleG2Scalar	390.820	670.755
SumYShuffleG2VectorBase	389.200	673.546	1.004162
SumYShuffleG2VectorTraits	10.777	24324.225	36.263970
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	10.884	24086.108	35.908971
SumYShuffleG2_ConstVectorTraits	11.001	23828.161	35.524410
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	14.401	18203.133	27.138290

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

