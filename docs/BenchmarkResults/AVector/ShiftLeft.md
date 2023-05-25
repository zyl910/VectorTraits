# Benchmark - ShiftLeft
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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	171.395	1529.471
SumSLLNetBcl	223.553	1172.624	0.766686
SumSLL_Multiply	13.432	19516.064	12.760014
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	12.553	20882.328	13.653306
SumSLLTraits	12.976	20201.485	13.208156
SumSLLConstTraits	8.180	32045.614	20.952096
SumSLLFast_Multiply	9.849	26616.614	17.402502
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.676	34150.946	22.328607
SumSLLFastTraits	8.801	29786.715	19.475181

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	170.187	1540.325
SumSLLNetBcl	13.012	20145.554	13.078766
SumSLLNetBcl_Const	11.257	23287.353	15.118465
SumSLL_Base	12.816	20455.039	13.279688
SumSLL_Base_Args	14.905	17587.501	11.418044
SumSLL_Base_Args_Element	15.976	16409.024	10.652960
SumSLL_Multiply	17.278	15172.276	9.850047
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	14.981	17498.578	11.360314
SumSLLTraits	15.041	17428.240	11.314650
SumSLLTraits_Args	12.564	20865.138	13.545930
SumSLLConstTraits	11.229	23345.259	15.156058
SumSLLFast_Multiply	13.367	19612.009	12.732382
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	12.734	20586.416	13.364980
SumSLLFastTraits	12.815	20456.510	13.280643

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	167.698	1563.192
SumSLLNetBcl	25.533	10266.949	6.567939
SumSLL_Multiply	37.725	6948.806	4.445268
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	30.266	8661.315	5.540788
SumSLLTraits	27.882	9401.989	6.014610
SumSLLConstTraits	24.766	10584.695	6.771207
SumSLLFast_Multiply	32.238	8131.447	5.201822
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	25.899	10121.824	6.475100
SumSLLFastTraits	25.720	10192.109	6.520063

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	159.401	1644.558
SumSLLNetBcl	46.687	5614.892	3.414227
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	67.135	3904.735	2.374338
SumSLLTraits	66.093	3966.266	2.411753
SumSLLConstTraits	55.089	4758.569	2.893525
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	60.772	4313.593	2.622951
SumSLLFastTraits	61.000	4297.469	2.613146

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
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	7.0.1
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/
RuntimeInformation.FrameworkDescription:	.NET 7.0.1
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	321.819	814.569
SumSLLNetBcl	26.529	9881.346	12.130759
SumSLLNetBcl_Const	26.617	9848.674	12.090649
SumSLL_Base	26.648	9837.342	12.076737
SumSLL_Base_Args	33.283	7876.192	9.669147
SumSLL_Base_Args_Element	36.576	7167.016	8.798533
SumSLL_Multiply	43.041	6090.591	7.477068
SumSLL_AdvSimd	101.162	2591.336	3.181234
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	101.353	2586.434	3.175216
SumSLLTraits_Args	33.160	7905.428	9.705038
SumSLLConstTraits	26.721	9810.412	12.043678
SumSLLFast_Multiply	35.835	7315.206	8.980456
SumSLLFast_AdvSimd	93.129	2814.858	3.455638
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	106.214	2468.065	3.029901

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

