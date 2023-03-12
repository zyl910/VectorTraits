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
SumMultiplyScalar	158.536	1653.533
SumMultiplyBcl	40.061	6543.695	3.957402
SumMultiplyVectorTraits	40.334	6499.269	3.930534
SumMultiplyVector128Traits	79.773	3286.124	1.987335
SumMultiplyVector256Traits	40.104	6536.641	3.953136

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 19479!=-11701
SumMultiplyScalar	146.343	1791.300
SumMultiplyBcl	9.079	28873.943	16.118985
SumMultiplyVectorTraits	9.100	28807.352	16.081810
SumMultiplyVector128Traits	12.349	21228.027	11.850624
SumMultiplyVector256Traits	9.099	28809.020	16.082742

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 575072105!=-452441065
SumMultiplyScalar	120.901	2168.260
SumMultiplyBcl	18.480	14185.276	6.542241
SumMultiplyVectorTraits	18.794	13947.946	6.432784
SumMultiplyVector128Traits	26.068	10056.205	4.637916
SumMultiplyVector256Traits	18.584	14105.919	6.505641

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! -113!=-41
SumMultiplyScalar	142.130	1844.396
SumMultiplyBcl	130.726	2005.292	1.087235
SumMultiplyBcl_Widen	10.104	25943.454	14.066096
SumMultiplyVectorTraits	130.975	2001.489	1.085173
SumMultiplyVector128Traits	198.315	1321.854	0.716687
SumMultiplyVector256Traits	131.001	2001.077	1.084949

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.883
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.988!=32717.883
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.988!=32717.883
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32717.883
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32717.883
SumMultiplyScalar	155.872	1681.787
SumMultiplyBcl	19.588	13382.852	7.957517
SumMultiplyVectorTraits	19.643	13345.564	7.935345
SumMultiplyVector128Traits	39.053	6712.536	3.991310
SumMultiplyVector256Traits	19.615	13364.360	7.946521

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 12862679336949715101!=12001033377966188484
SumMultiplyScalar	140.361	1867.643
SumMultiplyBcl	249.255	1051.708	0.563120
SumMultiplyVectorTraits	80.649	3250.416	1.740384
SumMultiplyVector128Traits	406.100	645.516	0.345631
SumMultiplyVector256Traits	80.998	3236.406	1.732882
SumMultiplyVector256Avx	81.378	3221.324	1.724807

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

