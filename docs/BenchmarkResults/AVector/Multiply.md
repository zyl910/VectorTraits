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
SumMultiplyScalar	158.054	1658.569
SumMultiplyBcl	40.109	6535.871	3.940670
SumMultiplyVectorTraits	40.749	6433.190	3.878760
SumMultiplyVector128Traits	79.637	3291.724	1.984677
SumMultiplyVector256Traits	41.076	6381.991	3.847890

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 19479!=-11701
SumMultiplyScalar	145.873	1797.074
SumMultiplyBcl	9.011	29090.206	16.187542
SumMultiplyVectorTraits	9.366	27988.810	15.574659
SumMultiplyVector128Traits	13.396	19568.921	10.889326
SumMultiplyVector256Traits	9.020	29062.563	16.172160

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 575072105!=-452441065
SumMultiplyScalar	121.159	2163.632
SumMultiplyBcl	20.662	12687.343	5.863910
SumMultiplyVectorTraits	20.724	12649.399	5.846373
SumMultiplyVector128Traits	27.100	9673.360	4.470890
SumMultiplyVector256Traits	19.124	13707.771	6.335538

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! -113!=-41
SumMultiplyScalar	141.837	1848.211
SumMultiplyBcl	131.816	1988.709	1.076018
SumMultiplyBcl_Widen	10.099	25958.595	14.045254
SumMultiplyVectorTraits	10.112	25924.751	14.026942
SumMultiplyVector128Traits	155.109	1690.064	0.914432
SumMultiplyVector256Traits	10.137	25861.260	13.992589

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.883
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.988!=32717.883
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.988!=32717.883
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32717.883
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32717.883
SumMultiplyScalar	156.242	1677.803
SumMultiplyBcl	19.593	13379.792	7.974590
SumMultiplyVectorTraits	19.586	13384.229	7.977234
SumMultiplyVector128Traits	38.992	6723.024	4.007039
SumMultiplyVector256Traits	19.611	13366.906	7.966909

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 12862679336949715101!=12001033377966188484
SumMultiplyScalar	141.000	1859.174
SumMultiplyBcl	263.626	994.380	0.534851
SumMultiplyVectorTraits	80.759	3245.992	1.745932
SumMultiplyVector128Traits	406.977	644.125	0.346458
SumMultiplyVector256Traits	80.639	3250.851	1.748546
SumMultiplyVector256Avx	80.592	3252.710	1.749546

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

