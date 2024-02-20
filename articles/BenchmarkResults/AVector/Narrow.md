# Benchmark - Narrow
([← Back](README.md))

## X86

### Intel Core i5-8250U
`Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework

```
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.4614.0
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.6
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.6
SumNarrowScalar	332.385	788.676
SumNarrowBcl	52.905	4955.031	6.282723
SumNarrowVectorBase	51.843	5056.533	6.411422
SumNarrowVectorTraits	52.594	4984.273	6.319799

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	157.447	1664.962
SumNarrowBcl	13.142	19946.708	11.980281
SumNarrowVectorBase	13.087	20030.152	12.030399
SumNarrowVectorTraits	13.496	19424.176	11.666441

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	172.131	1522.937
SumNarrowBcl	73.259	3578.334	2.349627
SumNarrowVectorBase	80.573	3253.500	2.136332
SumNarrowVectorTraits	76.513	3426.141	2.249692

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
```

#### .NET Core 2.1

```
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:	.NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.6
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.6
SumNarrowScalar	320.650	817.538
SumNarrowBcl	51.166	5123.446	6.266920
SumNarrowVectorBase	50.432	5198.017	6.358134
SumNarrowVectorTraits	50.073	5235.215	6.403633

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	160.969	1628.539
SumNarrowBcl	14.928	17560.243	10.782817
SumNarrowVectorBase	14.864	17636.329	10.829538
SumNarrowVectorTraits	14.808	17703.276	10.870647

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	172.532	1519.397
SumNarrowBcl	74.414	3522.801	2.318552
SumNarrowVectorBase	75.516	3471.377	2.284707
SumNarrowVectorTraits	74.608	3513.624	2.312512

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
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
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	319.201	821.252
SumNarrowBcl	51.428	5097.287	6.206730
SumNarrowVectorBase	50.311	5210.447	6.344519
SumNarrowVectorTraits	51.925	5048.487	6.147308
SumNarrowVector128Traits	1383.278	189.509	0.230757
SumNarrowVector256Traits	273.422	958.752	1.167427

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	158.859	1650.168
SumNarrowBcl	13.787	19013.797	11.522343
SumNarrowVectorBase	14.736	17788.962	10.780094
SumNarrowVectorTraits	25.799	10160.896	6.157493
SumNarrowVector128Traits	360.877	726.408	0.440202
SumNarrowVector256Traits	11.684	22435.526	13.595907

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	157.824	1660.992
SumNarrowBcl	70.119	3738.573	2.250807
SumNarrowVectorBase	70.392	3724.081	2.242082
SumNarrowVectorTraits	44.531	5886.711	3.544093
SumNarrowVector128Traits	975.913	268.614	0.161719
SumNarrowVector256Traits	57.662	4546.254	2.737071

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 5

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	5.0.17
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.17\
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	350.928	747.002
SumNarrowBcl	58.797	4458.440	5.968444
SumNarrowVectorBase	55.342	4736.787	6.341063
SumNarrowVectorTraits	52.519	4991.367	6.681866
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_AdvSimdB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	1353.031	193.746	0.259364
SumNarrowVector256Traits	262.298	999.412	1.337897

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	156.713	1672.760
SumNarrowBcl	14.596	17960.142	10.736834
SumNarrowVectorBase	14.113	18574.971	11.104388
SumNarrowVectorTraits	25.371	10332.393	6.176855
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	355.009	738.415	0.441435
SumNarrowVector256Traits	13.259	19770.730	11.819230

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	174.361	1503.454
SumNarrowBcl	76.228	3438.955	2.287370
SumNarrowVectorBase	77.557	3379.996	2.248154
SumNarrowVectorTraits	50.536	5187.229	3.450209
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	876.771	298.988	0.198867
SumNarrowVector256Traits	48.048	5455.908	3.628916

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 6

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.14
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.14\
RuntimeInformation.FrameworkDescription:	.NET 6.0.14
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	318.851	822.151
SumNarrowBcl	47.440	5525.849	6.721209
SumNarrowVectorBase	47.446	5525.085	6.720281
SumNarrowVectorTraits	46.716	5611.390	6.825255
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_AdvSimdB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	1365.727	191.945	0.233467
SumNarrowVector256Traits	260.201	1007.467	1.225404

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	161.469	1623.491
SumNarrowBcl	13.993	18733.836	11.539229
SumNarrowVectorBase	14.275	18364.141	11.311513
SumNarrowVectorTraits	24.497	10700.904	6.591292
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	356.554	735.215	0.452860
SumNarrowVector256Traits	13.047	20092.067	12.375841

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	166.604	1573.460
SumNarrowBcl	77.468	3383.896	2.150609
SumNarrowVectorBase	76.300	3435.694	2.183528
SumNarrowVectorTraits	57.900	4527.496	2.877414
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	874.868	299.638	0.190433
SumNarrowVector256Traits	54.086	4846.844	3.080374

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
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
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	319.566	820.312
SumNarrowBcl	49.158	5332.672	6.500788
SumNarrowVectorBase	52.182	5023.694	6.124129
SumNarrowVectorTraits	51.093	5130.718	6.254596
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_AdvSimdB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	80.711	3247.950	3.959410
SumNarrowVector256Traits	51.501	5090.033	6.204999

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	155.345	1687.493
SumNarrowBcl	17.718	14795.391	8.767673
SumNarrowVectorBase	11.908	22013.759	13.045241
SumNarrowVectorTraits	10.908	24032.546	14.241564
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	16.704	15693.384	9.299819
SumNarrowVector256Traits	10.979	23877.066	14.149428

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	105.295	2489.626
SumNarrowBcl	45.404	5773.532	2.319035
SumNarrowVectorBase	45.567	5752.873	2.310738
SumNarrowVectorTraits	50.340	5207.492	2.091676
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	64.828	4043.678	1.624211
SumNarrowVector256Traits	52.582	4985.410	2.002473

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
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	3.1.31
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.31
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	292.234	897.034
SumNarrowBcl	85.001	3084.003	3.438002
SumNarrowVectorBase	84.631	3097.487	3.453034
SumNarrowVectorTraits	84.811	3090.914	3.445707
SumNarrowVector128Traits	1906.359	137.510	0.153295
SumNarrowVector256Traits	2022.475	129.615	0.144493

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	351.271	746.273
SumNarrowBcl	19.054	13758.104	18.435758
SumNarrowVectorBase	18.948	13834.817	18.538552
SumNarrowVectorTraits	18.951	13832.597	18.535577
SumNarrowVector128Traits	484.517	541.042	0.724992
SumNarrowVector256Traits	520.906	503.247	0.674347

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	314.501	833.523
SumNarrowBcl	75.371	3478.045	4.172703
SumNarrowVectorBase	80.422	3259.603	3.910632
SumNarrowVectorTraits	75.245	3483.857	4.179675
SumNarrowVector128Traits	1384.846	189.295	0.227102
SumNarrowVector256Traits	1387.759	188.897	0.226625

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 5.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimdB64	Check `SumNarrowVector128_AdvSimdB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	290.354	902.841
SumNarrowBcl	81.007	3236.050	3.584296
SumNarrowVectorBase	75.113	3489.994	3.865568
SumNarrowVectorTraits	81.215	3227.759	3.575112
SumNarrowVector128_AdvSimd	562.115	466.353	0.516539
SumNarrowVector128_AdvSimdB64	82.825	3165.039	3.505643
SumNarrowVector128Traits	579.494	452.367	0.501048
SumNarrowVector256Traits	1304.321	200.981	0.222610

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	348.389	752.447
SumNarrowBcl	20.872	12559.431	16.691461
SumNarrowVectorBase	20.901	12542.386	16.668808
SumNarrowVectorTraits	20.892	12547.789	16.675989
SumNarrowVector128_AdvSimd	20.073	13059.461	17.355999
SumNarrowVector128Traits	19.838	13214.069	17.561473
SumNarrowVector256Traits	391.835	669.017	0.889122

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	312.581	838.644
SumNarrowBcl	79.242	3308.158	3.944651
SumNarrowVectorBase	83.340	3145.471	3.750663
SumNarrowVectorTraits	79.116	3313.423	3.950929
SumNarrowVector128_AdvSimd	79.170	3311.155	3.948224
SumNarrowVector128Traits	83.061	3156.056	3.763284
SumNarrowVector256Traits	880.877	297.594	0.354852

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	6.0.11
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/
RuntimeInformation.FrameworkDescription:	.NET 6.0.11
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimdB64	Check `SumNarrowVector128_AdvSimdB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	290.303	903.002
SumNarrowBcl	75.130	3489.223	3.864026
SumNarrowVectorBase	81.086	3232.929	3.580201
SumNarrowVectorTraits	75.071	3491.952	3.867048
SumNarrowVector128_AdvSimd	561.076	467.217	0.517404
SumNarrowVector128_AdvSimdB64	75.248	3483.750	3.857965
SumNarrowVector128Traits	792.276	330.874	0.366416
SumNarrowVector256Traits	1291.282	203.011	0.224818

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	347.281	754.846
SumNarrowBcl	19.662	13332.469	17.662492
SumNarrowVectorBase	19.665	13330.678	17.660121
SumNarrowVectorTraits	19.784	13250.364	17.553722
SumNarrowVector128_AdvSimd	19.803	13237.430	17.536588
SumNarrowVector128Traits	19.587	13383.242	17.729756
SumNarrowVector256Traits	392.386	668.077	0.885050

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	312.726	838.254
SumNarrowBcl	79.271	3306.919	3.945006
SumNarrowVectorBase	82.884	3162.797	3.773076
SumNarrowVectorTraits	82.803	3165.871	3.776743
SumNarrowVector128_AdvSimd	79.086	3314.682	3.954267
SumNarrowVector128Traits	82.753	3167.792	3.779034
SumNarrowVector256Traits	872.872	300.324	0.358273

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 7.0

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimdB64	Check `SumNarrowVector128_AdvSimdB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	210.605	1244.722
SumNarrowBcl	75.298	3481.401	2.796932
SumNarrowVectorBase	75.476	3473.223	2.790362
SumNarrowVectorTraits	74.895	3500.169	2.812009
SumNarrowVector128_AdvSimd	75.439	3474.922	2.791726
SumNarrowVector128_AdvSimdB64	75.376	3477.835	2.794066
SumNarrowVector128Traits	75.593	3467.840	2.786036
SumNarrowVector256Traits	958.777	273.415	0.219660

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	253.988	1032.113
SumNarrowBcl	16.991	15428.521	14.948478
SumNarrowVectorBase	16.972	15445.908	14.965325
SumNarrowVectorTraits	16.981	15437.910	14.957575
SumNarrowVector128_AdvSimd	16.988	15430.867	14.950752
SumNarrowVector128Traits	16.962	15454.345	14.973499
SumNarrowVector256Traits	687.066	381.541	0.369670

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	226.683	1156.432
SumNarrowBcl	64.490	4064.873	3.515011
SumNarrowVectorBase	64.229	4081.370	3.529276
SumNarrowVectorTraits	64.266	4079.025	3.527248
SumNarrowVector128_AdvSimd	64.668	4053.662	3.505317
SumNarrowVector128Traits	64.421	4069.220	3.518770
SumNarrowVector256Traits	933.311	280.875	0.242881

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

