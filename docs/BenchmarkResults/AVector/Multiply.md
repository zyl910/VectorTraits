# Benchmark - Multiply
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 4.5

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.6184711382
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.6184711381!=32712.6184711382
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.6184711381!=32712.6184711382
SumMultiplyScalar	162.527	1612.928
SumMultiplyBcl	42.258	6203.448	3.846079
SumMultiplyVectorTraits	41.285	6349.673	3.936737

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
SumMultiplyScalar	156.781	1672.036
SumMultiplyBcl	9.456	27723.674	16.580791
SumMultiplyVectorTraits	9.321	28123.490	16.819910

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
SumMultiplyScalar	133.016	1970.772
SumMultiplyBcl	18.640	14063.846	7.136212
SumMultiplyVectorTraits	18.711	14010.361	7.109073

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
SumMultiplyScalar	156.080	1679.551
SumMultiplyBcl	232.688	1126.591	0.670770
SumMultiplyBcl_Widen	318.064	824.186	0.490718
SumMultiplyVectorTraits	231.809	1130.862	0.673312

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.88
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.99!=32717.88
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.99!=32717.88
SumMultiplyScalar	156.284	1677.353
SumMultiplyBcl	20.251	12944.886	7.717447
SumMultiplyVectorTraits	19.985	13117.304	7.820238

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
SumMultiplyScalar	144.083	1819.396
SumMultiplyBcl	825.320	317.627	0.174578
SumMultiplyVectorTraits	817.066	320.836	0.176342

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.6184711382
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.6184711381!=32712.6184711382
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.6184711381!=32712.6184711382
SumMultiplyScalar	159.354	1645.039
SumMultiplyBcl	40.915	6406.962	3.894716
SumMultiplyVectorTraits	41.230	6358.129	3.865032

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
SumMultiplyScalar	156.726	1672.622
SumMultiplyBcl	9.480	27651.485	16.531817
SumMultiplyVectorTraits	9.413	27848.337	16.649508

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
SumMultiplyScalar	130.484	2009.018
SumMultiplyBcl	19.789	13246.692	6.593616
SumMultiplyVectorTraits	20.104	13039.200	6.490336

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
SumMultiplyScalar	160.740	1630.857
SumMultiplyBcl	203.859	1285.908	0.788486
SumMultiplyBcl_Widen	260.657	1005.706	0.616674
SumMultiplyVectorTraits	204.076	1284.541	0.787648

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.88
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.99!=32717.88
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.99!=32717.88
SumMultiplyScalar	159.377	1644.803
SumMultiplyBcl	20.223	12962.610	7.880951
SumMultiplyVectorTraits	20.349	12882.324	7.832139

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
SumMultiplyScalar	144.646	1812.316
SumMultiplyBcl	518.060	506.011	0.279207
SumMultiplyVectorTraits	510.100	513.907	0.283564

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
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
SumMultiplyScalar	174.398	1503.136
SumMultiplyBcl	53.056	4940.900	3.287061
SumMultiplyVectorTraits	42.208	6210.739	4.131854
SumMultiplyVector128Traits	866.519	302.525	0.201263
SumMultiplyVector256Traits	41.762	6277.059	4.175975

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 19479!=-11701
SumMultiplyScalar	157.674	1662.569
SumMultiplyBcl	9.750	26886.528	16.171681
SumMultiplyVectorTraits	9.314	28146.617	16.929598
SumMultiplyVector128Traits	287.017	913.339	0.549354
SumMultiplyVector256Traits	9.380	27947.750	16.809984

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 575072105!=-452441065
SumMultiplyScalar	133.446	1964.424
SumMultiplyBcl	19.916	13162.399	6.700385
SumMultiplyVectorTraits	21.439	12227.622	6.224532
SumMultiplyVector128Traits	499.568	524.742	0.267122
SumMultiplyVector256Traits	22.293	11759.007	5.985981

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! -113!=-41
SumMultiplyScalar	162.247	1615.713
SumMultiplyBcl	214.292	1223.303	0.757129
SumMultiplyBcl_Widen	269.474	972.800	0.602087
SumMultiplyVectorTraits	13.117	19985.133	12.369238
SumMultiplyVector128Traits	187.628	1397.150	0.864727
SumMultiplyVector256Traits	12.885	20344.700	12.591782

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.883
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.988!=32717.883
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.988!=32717.883
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32717.883
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32717.883
SumMultiplyScalar	160.200	1636.355
SumMultiplyBcl	20.384	12860.090	7.858986
SumMultiplyVectorTraits	20.950	12512.565	7.646609
SumMultiplyVector128Traits	473.210	553.970	0.338539
SumMultiplyVector256Traits	20.646	12696.814	7.759206

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 12862679336949715101!=12001033377966188484
SumMultiplyScalar	164.991	1588.842
SumMultiplyBcl	507.171	516.875	0.325315
SumMultiplyVectorTraits	89.234	2937.699	1.848956
SumMultiplyVector128Traits	815.006	321.647	0.202441
SumMultiplyVector256Traits	93.672	2798.543	1.761373
SumMultiplyVector256Avx	97.385	2691.828	1.694207

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
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
SumMultiplyScalar	166.910	1570.574
SumMultiplyBcl	42.371	6186.909	3.939267
SumMultiplyVectorTraits	41.244	6355.902	4.046867
SumMultiplyVector128Traits	848.266	309.035	0.196766
SumMultiplyVector256Traits	41.996	6242.075	3.974392

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 19479!=-11701
SumMultiplyScalar	158.091	1658.186
SumMultiplyBcl	9.610	27278.545	16.450831
SumMultiplyVectorTraits	9.780	26804.244	16.164795
SumMultiplyVector128Traits	281.519	931.177	0.561563
SumMultiplyVector256Traits	9.663	27128.497	16.360342

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 575072105!=-452441065
SumMultiplyScalar	134.565	1948.078
SumMultiplyBcl	20.742	12638.209	6.487527
SumMultiplyVectorTraits	19.438	13486.313	6.922881
SumMultiplyVector128Traits	431.607	607.367	0.311778
SumMultiplyVector256Traits	21.681	12090.824	6.206539

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! -113!=-41
SumMultiplyScalar	158.178	1657.271
SumMultiplyBcl	146.775	1786.024	1.077690
SumMultiplyBcl_Widen	195.896	1338.179	0.807459
SumMultiplyVectorTraits	10.266	25534.744	15.407710
SumMultiplyVector128Traits	185.426	1413.736	0.853051
SumMultiplyVector256Traits	10.337	25360.119	15.302341

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.883
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.988!=32717.883
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.988!=32717.883
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32717.883
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32717.883
SumMultiplyScalar	157.123	1668.403
SumMultiplyBcl	20.548	12757.941	7.646798
SumMultiplyVectorTraits	20.650	12694.710	7.608899
SumMultiplyVector128Traits	460.291	569.518	0.341355
SumMultiplyVector256Traits	20.588	12732.953	7.631821

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 12862679336949715101!=12001033377966188484
SumMultiplyScalar	144.630	1812.516
SumMultiplyBcl	398.547	657.750	0.362893
SumMultiplyVectorTraits	74.397	3523.580	1.944027
SumMultiplyVector128Traits	798.484	328.302	0.181131
SumMultiplyVector256Traits	72.773	3602.196	1.987401
SumMultiplyVector256Avx	73.762	3553.915	1.960763

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
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
SumMultiplyScalar	164.248	1596.029
SumMultiplyBcl	40.448	6480.969	4.060682
SumMultiplyVectorTraits	41.072	6382.513	3.998995
SumMultiplyVector128Traits	849.028	308.758	0.193454
SumMultiplyVector256Traits	44.784	5853.542	3.667565

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 19479!=-11701
SumMultiplyScalar	154.500	1696.724
SumMultiplyBcl	9.571	27390.561	16.143200
SumMultiplyVectorTraits	9.652	27158.611	16.006495
SumMultiplyVector128Traits	281.919	929.854	0.548029
SumMultiplyVector256Traits	9.847	26621.519	15.689949

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 575072105!=-452441065
SumMultiplyScalar	145.741	1798.704
SumMultiplyBcl	20.019	13094.789	7.280126
SumMultiplyVectorTraits	18.949	13833.902	7.691041
SumMultiplyVector128Traits	436.858	600.067	0.333611
SumMultiplyVector256Traits	21.363	12270.680	6.821958

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! -113!=-41
SumMultiplyScalar	151.480	1730.553
SumMultiplyBcl	124.422	2106.893	1.217468
SumMultiplyBcl_Widen	13.980	18750.729	10.835109
SumMultiplyVectorTraits	10.380	25255.209	14.593723
SumMultiplyVector128Traits	184.399	1421.610	0.821477
SumMultiplyVector256Traits	10.500	24966.127	14.426677

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.883
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.988!=32717.883
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.988!=32717.883
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32717.883
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32717.883
SumMultiplyScalar	159.231	1646.312
SumMultiplyBcl	20.445	12822.090	7.788372
SumMultiplyVectorTraits	20.638	12701.986	7.715418
SumMultiplyVector128Traits	458.269	572.031	0.347462
SumMultiplyVector256Traits	19.672	13325.875	8.094380

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 12862679336949715101!=12001033377966188484
SumMultiplyScalar	141.018	1858.940
SumMultiplyBcl	277.227	945.594	0.508673
SumMultiplyVectorTraits	71.560	3663.264	1.970620
SumMultiplyVector128Traits	799.333	327.954	0.176420
SumMultiplyVector256Traits	72.736	3604.060	1.938771
SumMultiplyVector256Avx	71.668	3657.730	1.967643

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
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
SumMultiplyScalar	165.042	1588.349
SumMultiplyBcl	41.837	6265.832	3.944870
SumMultiplyVectorTraits	41.815	6269.113	3.946936
SumMultiplyVector128Traits	80.752	3246.276	2.043805
SumMultiplyVector256Traits	40.878	6412.852	4.037432

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 19479!=-11701
SumMultiplyScalar	148.320	1767.427
SumMultiplyBcl	9.871	26557.256	15.025945
SumMultiplyVectorTraits	9.366	27989.181	15.836121
SumMultiplyVector128Traits	12.593	20817.273	11.778295
SumMultiplyVector256Traits	9.542	27472.556	15.543817

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 575072105!=-452441065
SumMultiplyScalar	124.138	2111.707
SumMultiplyBcl	20.450	12818.508	6.070211
SumMultiplyVectorTraits	18.680	14033.609	6.645623
SumMultiplyVector128Traits	28.181	9302.262	4.405091
SumMultiplyVector256Traits	18.843	13911.823	6.587951

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! -113!=-41
SumMultiplyScalar	145.982	1795.730
SumMultiplyBcl	132.060	1985.044	1.105425
SumMultiplyBcl_Widen	10.405	25193.012	14.029398
SumMultiplyVectorTraits	10.404	25196.182	14.031164
SumMultiplyVector128Traits	156.613	1673.832	0.932118
SumMultiplyVector256Traits	10.345	25340.460	14.111509

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.883
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.988!=32717.883
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.988!=32717.883
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32717.883
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32717.883
SumMultiplyScalar	157.899	1660.201
SumMultiplyBcl	20.047	13076.751	7.876605
SumMultiplyVectorTraits	20.002	13106.008	7.894228
SumMultiplyVector128Traits	39.520	6633.259	3.995454
SumMultiplyVector256Traits	19.825	13223.132	7.964776

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 12862679336949715101!=12001033377966188484
SumMultiplyScalar	135.853	1929.618
SumMultiplyBcl	241.081	1087.370	0.563516
SumMultiplyVectorTraits	83.311	3146.588	1.630679
SumMultiplyVector128Traits	412.050	636.195	0.329700
SumMultiplyVector256Traits	83.121	3153.754	1.634393
SumMultiplyVector256Avx	84.573	3099.608	1.606332

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32672.199721873145
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumMultiplyScalar	342.112	766.252
SumMultiplyBcl	76.789	3413.826	4.455224
SumMultiplyVectorTraits	78.362	3345.308	4.365804
SumMultiplyVector128Traits	625.754	418.925	0.546720
SumMultiplyVector256Traits	1113.353	235.455	0.307281

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	19479
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -11701!=19479
SumMultiplyScalar	410.414	638.731
SumMultiplyBcl	20.521	12774.465	19.999754
SumMultiplyVectorTraits	20.424	12834.954	20.094457
SumMultiplyVector128Traits	435.532	601.893	0.942327
SumMultiplyVector256Traits	408.156	642.264	1.005531

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	575072105
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -452441065!=575072105
SumMultiplyScalar	363.217	721.729
SumMultiplyBcl	35.943	7293.341	10.105372
SumMultiplyVectorTraits	35.795	7323.575	10.147263
SumMultiplyVector128Traits	716.830	365.699	0.506698
SumMultiplyVector256Traits	707.267	370.643	0.513549

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-113
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -41!=-113
SumMultiplyScalar	337.088	777.673
SumMultiplyBcl	8.458	30993.948	39.854715
SumMultiplyBcl_Widen	21.780	12035.845	15.476736
SumMultiplyVectorTraits	8.485	30894.276	39.726549
SumMultiplyVector128Traits	256.831	1020.688	1.312489
SumMultiplyVector256Traits	275.012	953.209	1.225719

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.652
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.596!=32712.652
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32712.652
SumMultiplyScalar	317.548	825.526
SumMultiplyBcl	35.417	7401.638	8.965971
SumMultiplyVectorTraits	35.362	7413.232	8.980015
SumMultiplyVector128Traits	740.342	354.085	0.428921
SumMultiplyVector256Traits	719.828	364.176	0.441145

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12862679336949715101
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! 12001033377966188484!=12862679336949715101
SumMultiplyScalar	792.344	330.846
SumMultiplyBcl	682.982	383.823	1.160124
SumMultiplyVectorTraits	683.482	383.542	1.159275
SumMultiplyVector128Traits	607.664	431.396	1.303918
SumMultiplyVector256Traits	1131.115	231.757	0.700498
SumMultiplyVector256Avx	Run fail! Requires hardware support Avx, Avx2!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 5

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32672.199721873145
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumMultiplyScalar	760.201	344.835
SumMultiplyBcl	68.591	3821.845	11.083114
SumMultiplyVectorTraits	80.413	3259.988	9.453764
SumMultiplyVector128Traits	80.446	3258.623	9.449804
SumMultiplyVector256Traits	577.624	453.832	1.316084

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	19479
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -11701!=19479
SumMultiplyScalar	402.778	650.839
SumMultiplyBcl	20.768	12622.723	19.394534
SumMultiplyVectorTraits	20.862	12565.594	19.306756
SumMultiplyVector128Traits	19.669	13328.007	20.478187
SumMultiplyVector256Traits	296.474	884.207	1.358564

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	575072105
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -452441065!=575072105
SumMultiplyScalar	363.009	722.142
SumMultiplyBcl	40.724	6437.041	8.913813
SumMultiplyVectorTraits	40.644	6449.709	8.931356
SumMultiplyVector128Traits	42.584	6155.926	8.524534
SumMultiplyVector256Traits	444.413	589.865	0.816827

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-113
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -41!=-113
SumMultiplyScalar	337.181	777.458
SumMultiplyBcl	9.729	26945.077	34.657937
SumMultiplyBcl_Widen	21.370	12267.138	15.778531
SumMultiplyVectorTraits	9.743	26906.634	34.608491
SumMultiplyVector128Traits	9.641	27190.797	34.973993
SumMultiplyVector256Traits	221.663	1182.627	1.521146

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.652
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.596!=32712.652
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32712.652
SumMultiplyScalar	317.083	826.737
SumMultiplyBcl	42.980	6099.273	7.377527
SumMultiplyVectorTraits	43.567	6017.100	7.278132
SumMultiplyVector128Traits	43.692	5999.854	7.257272
SumMultiplyVector256Traits	453.693	577.801	0.698893

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12862679336949715101
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! 12001033377966188484!=12862679336949715101
SumMultiplyScalar	395.597	662.654
SumMultiplyBcl	326.218	803.586	1.212679
SumMultiplyVectorTraits	231.969	1130.080	1.705385
SumMultiplyVector128Traits	232.639	1126.828	1.700477
SumMultiplyVector256Traits	621.063	422.089	0.636968
SumMultiplyVector256Avx	Run fail! Requires hardware support Avx, Avx2!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 6

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32672.199721873145
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumMultiplyScalar	342.906	764.477
SumMultiplyBcl	80.750	3246.380	4.246537
SumMultiplyVectorTraits	83.272	3148.059	4.117926
SumMultiplyVector128Traits	84.128	3116.025	4.076022
SumMultiplyVector256Traits	576.726	454.538	0.594574

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	19479
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -11701!=19479
SumMultiplyScalar	402.733	650.913
SumMultiplyBcl	20.748	12634.531	19.410475
SumMultiplyVectorTraits	20.737	12641.198	19.420718
SumMultiplyVector128Traits	19.629	13354.796	20.517020
SumMultiplyVector256Traits	296.223	884.954	1.359557

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	575072105
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -452441065!=575072105
SumMultiplyScalar	363.585	720.997
SumMultiplyBcl	43.024	6092.939	8.450708
SumMultiplyVectorTraits	43.000	6096.391	8.455496
SumMultiplyVector128Traits	40.828	6420.710	8.905317
SumMultiplyVector256Traits	452.038	579.916	0.804324

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-113
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -41!=-113
SumMultiplyScalar	337.127	777.583
SumMultiplyBcl	9.683	27073.943	34.818091
SumMultiplyBcl_Widen	21.792	12029.261	15.470074
SumMultiplyVectorTraits	9.716	26979.779	34.696994
SumMultiplyVector128Traits	9.731	26940.328	34.646258
SumMultiplyVector256Traits	221.155	1185.343	1.524395

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.652
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.596!=32712.652
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32712.652
SumMultiplyScalar	330.176	793.952
SumMultiplyBcl	40.440	6482.280	8.164575
SumMultiplyVectorTraits	40.442	6482.040	8.164273
SumMultiplyVector128Traits	40.462	6478.835	8.160237
SumMultiplyVector256Traits	457.981	572.391	0.720939

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12862679336949715101
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! 12001033377966188484!=12862679336949715101
SumMultiplyScalar	388.602	674.582
SumMultiplyBcl	621.484	421.803	0.625280
SumMultiplyVectorTraits	231.796	1130.927	1.676485
SumMultiplyVector128Traits	232.088	1129.501	1.674370
SumMultiplyVector256Traits	608.804	430.589	0.638304
SumMultiplyVector256Avx	Run fail! Requires hardware support Avx, Avx2!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32672.199721873145
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumMultiplyScalar	238.314	1099.993
SumMultiplyBcl	72.339	3623.849	3.294428
SumMultiplyVectorTraits	71.954	3643.204	3.312023
SumMultiplyVector128Traits	72.173	3632.176	3.301999
SumMultiplyVector256Traits	662.136	395.907	0.359917

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	19479
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -11701!=19479
SumMultiplyScalar	258.419	1014.415
SumMultiplyBcl	14.082	18615.851	18.351317
SumMultiplyVectorTraits	14.195	18467.730	18.205301
SumMultiplyVector128Traits	14.076	18623.862	18.359215
SumMultiplyVector256Traits	445.428	588.521	0.580158

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	575072105
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -452441065!=575072105
SumMultiplyScalar	185.286	1414.804
SumMultiplyBcl	30.043	8725.607	6.167359
SumMultiplyVectorTraits	30.196	8681.454	6.136152
SumMultiplyVector128Traits	30.201	8679.865	6.135029
SumMultiplyVector256Traits	554.870	472.442	0.333927

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-113
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -41!=-113
SumMultiplyScalar	223.039	1175.330
SumMultiplyBcl	6.967	37625.106	32.012367
SumMultiplyBcl_Widen	21.730	12063.533	10.263951
SumMultiplyVectorTraits	6.979	37562.876	31.959420
SumMultiplyVector128Traits	6.938	37786.097	32.149342
SumMultiplyVector256Traits	393.923	665.471	0.566199

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.652
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.596!=32712.652
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32712.652
SumMultiplyScalar	211.796	1237.721
SumMultiplyBcl	30.790	8513.919	6.878707
SumMultiplyVectorTraits	31.514	8318.409	6.720748
SumMultiplyVector128Traits	30.839	8500.478	6.867848
SumMultiplyVector256Traits	500.815	523.434	0.422902

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12862679336949715101
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! 12001033377966188484!=12862679336949715101
SumMultiplyScalar	238.313	1100.000
SumMultiplyBcl	237.356	1104.432	1.004030
SumMultiplyVectorTraits	236.731	1107.348	1.006680
SumMultiplyVector128Traits	236.731	1107.348	1.006680
SumMultiplyVector256Traits	673.743	389.086	0.353715
SumMultiplyVector256Avx	Run fail! Requires hardware support Avx, Avx2!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

