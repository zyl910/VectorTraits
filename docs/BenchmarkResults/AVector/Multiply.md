# Benchmark - Multiply
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
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
SumMultiplyScalar	143.740	1823.733
SumMultiplyBcl	512.867	511.135	0.280268
SumMultiplyVector256Traits	86.123	3043.819	1.669005
SumMultiplyVector256Avx	83.444	3141.573	1.722606

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


[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
SumMultiplyScalar	142.741	1836.505
SumMultiplyBcl	389.977	672.204	0.366023
SumMultiplyVector256Traits	69.905	3749.990	2.041917
SumMultiplyVector256Avx	70.839	3700.547	2.014995

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


[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
SumMultiplyScalar	142.655	1837.603
SumMultiplyBcl	277.063	946.154	0.514885
SumMultiplyVector256Traits	71.229	3680.274	2.002758
SumMultiplyVector256Avx	72.620	3609.803	1.964409

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.618471138187
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumMultiplyScalar	159.407	1644.493
SumMultiplyBcl	40.304	6504.162	3.955117
SumMultiplyVectorTraits	40.374	6492.811	3.948214
SumMultiplyVector128Traits	79.789	3285.446	1.997847
SumMultiplyVector256Traits	40.608	6455.493	3.925521

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 19479!=-11701
SumMultiplyScalar	146.756	1786.263
SumMultiplyBcl	9.020	29062.180	16.269825
SumMultiplyVectorTraits	9.053	28956.092	16.210434
SumMultiplyVector128Traits	12.363	21204.431	11.870836
SumMultiplyVector256Traits	9.033	29022.226	16.247458

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 575072105!=-452441065
SumMultiplyScalar	120.914	2168.019
SumMultiplyBcl	18.517	14157.296	6.530060
SumMultiplyVectorTraits	18.475	14189.488	6.544909
SumMultiplyVector128Traits	26.336	9953.966	4.591272
SumMultiplyVector256Traits	20.416	12840.107	5.922506

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! -113!=-41
SumMultiplyScalar	141.677	1850.298
SumMultiplyBcl	130.501	2008.757	1.085640
SumMultiplyVectorTraits	130.761	2004.759	1.083479
SumMultiplyVector128Traits	155.413	1686.758	0.911614
SumMultiplyVector256Traits	131.049	2000.349	1.081095

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.883
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.988!=32717.883
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.988!=32717.883
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32717.883
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32717.883
SumMultiplyScalar	156.679	1673.124
SumMultiplyBcl	20.028	13088.803	7.822973
SumMultiplyVectorTraits	20.902	12541.319	7.495750
SumMultiplyVector128Traits	39.837	6580.435	3.933023
SumMultiplyVector256Traits	20.194	12981.279	7.758707

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 12862679336949715101!=12001033377966188484
SumMultiplyScalar	137.860	1901.517
SumMultiplyBcl	253.089	1035.779	0.544712
SumMultiplyVectorTraits	81.055	3234.145	1.700824
SumMultiplyVector128Traits	405.564	646.369	0.339923
SumMultiplyVector256Traits	81.096	3232.498	1.699958
SumMultiplyVector256Avx	81.429	3219.295	1.693014

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

