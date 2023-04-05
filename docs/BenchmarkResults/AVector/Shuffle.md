# Benchmark - Shuffle
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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-24614
SumShuffleScalar	268.450	976.511
SumShuffleVectorBase	266.168	984.880	1.008570
SumShuffleVectorTraits	266.677	983.000	1.006645
SumShuffleVectorTraitsIf	269.559	972.490	0.995882
SumYShuffleKernelVectorTraits	267.788	978.924	1.002471

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	374.179	700.585
SumShuffleVectorBase	374.888	699.259	0.998108
SumShuffleVectorTraits	374.018	700.887	1.000431
SumYShuffleKernelVectorTraits	373.103	702.604	1.002882

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	598.513	437.992
SumShuffleVectorBase	599.354	437.377	0.998596
SumShuffleVectorTraits	595.043	440.547	1.005832
SumYShuffleKernelVectorTraits	593.543	441.660	1.008373

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	209.861	1249.133
SumShuffleVectorBase	212.431	1234.018	0.987900
SumShuffleVectorTraits	212.906	1231.265	0.985695
SumShuffleVectorTraitsIf	218.306	1200.810	0.961315
SumYShuffleKernelVectorTraits	212.311	1234.718	0.988460

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-24614
SumShuffleScalar	260.018	1008.177
SumShuffleVectorBase	260.989	1004.425	0.996279
SumShuffleVectorTraits	261.445	1002.674	0.994542
SumShuffleVectorTraitsIf	261.006	1004.360	0.996214
SumYShuffleKernelVectorTraits	259.898	1008.640	1.000460

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	365.411	717.395
SumShuffleVectorBase	372.549	703.650	0.980841
SumShuffleVectorTraits	362.134	723.887	1.009050
SumYShuffleKernelVectorTraits	361.863	724.430	1.009806

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	570.228	459.718
SumShuffleVectorBase	565.418	463.629	1.008508
SumShuffleVectorTraits	568.056	461.476	1.003824
SumYShuffleKernelVectorTraits	565.273	463.748	1.008766

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	246.527	1063.349
SumShuffleVectorBase	266.801	982.545	0.924010
SumShuffleVectorTraits	233.546	1122.450	1.055580
SumShuffleVectorTraitsIf	211.297	1240.642	1.166731
SumYShuffleKernelVectorTraits	234.998	1115.516	1.049059

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-24614
SumShuffleScalar	261.576	1002.172
SumShuffleVectorBase	262.910	997.087	0.994927
SumShuffleVectorTraits	47.477	5521.546	5.509581
SumShuffleVectorTraitsIf	41.181	6365.637	6.351843
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	47.860	5477.319	5.465450
SumYShuffleKernelVectorTraits	41.937	6250.935	6.237389
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	43.368	6044.588	6.031490
SumYShuffleKernelVector256_Avx2_ShiftLane	34.738	7546.339	7.529987
SumYShuffleKernelVector256Traits	37.449	6999.971	6.984802

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	365.771	716.688
SumShuffleVectorBase	387.991	675.644	0.942731
SumShuffleVectorTraits	55.299	4740.525	6.614488
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	49.700	5274.533	7.359593
SumYShuffleKernelVectorTraits	23.091	11352.509	15.840234
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	26.783	9787.704	13.656852

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	571.860	458.406
SumShuffleVectorBase	564.829	464.112	1.012449
SumShuffleVectorTraits	130.431	2009.836	4.384403
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	222.687	1177.184	2.567994
SumYShuffleKernelVectorTraits	114.690	2285.666	4.986118
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	132.475	1978.818	4.316738
SumYShuffleKernelVector256_Avx2_Multiply	243.287	1077.509	2.350557
SumYShuffleKernelVector256_Avx2_ShiftLane	102.727	2551.839	5.566769
SumYShuffleKernelVector256Traits	103.180	2540.642	5.542341

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	282.469	928.046
SumShuffleVectorBase	264.822	989.888	1.066637
SumShuffleVectorTraits	20.886	12550.977	13.524091
SumShuffleVectorTraitsIf	21.048	12454.718	13.420370
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	18.909	13863.405	14.938275
SumShuffleVector256_Avx2_Add2	21.596	12138.665	13.079812
SumShuffleVector256_Avx2_Cmp2	18.975	13815.354	14.886499
SumShuffleVector256Traits	17.375	15087.324	16.257089
SumYShuffleKernelVectorTraits	12.104	21658.451	23.337695
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	12.874	20362.823	21.941613

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-24614
SumShuffleScalar	327.928	799.395
SumShuffleVectorBase	283.281	925.386	1.157608
SumShuffleVectorTraits	43.861	5976.662	7.476484
SumShuffleVectorTraitsIf	42.838	6119.425	7.655072
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	42.512	6166.316	7.713731
SumYShuffleKernelVectorTraits	37.083	7069.157	8.843137
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	36.548	7172.650	8.972601
SumYShuffleKernelVector256_Avx2_ShiftLane	31.361	8358.998	10.456658
SumYShuffleKernelVector256Traits	42.218	6209.342	7.767554

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	367.683	712.962
SumShuffleVectorBase	349.837	749.333	1.051014
SumShuffleVectorTraits	38.818	6753.087	9.471881
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	39.310	6668.701	9.353522
SumYShuffleKernelVectorTraits	23.310	11245.771	15.773321
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	23.388	11208.468	15.721000

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	567.884	461.615
SumShuffleVectorBase	545.062	480.943	1.041870
SumShuffleVectorTraits	113.441	2310.848	5.006001
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	121.760	2152.964	4.663977
SumYShuffleKernelVectorTraits	76.380	3432.124	7.435027
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	102.957	2546.141	5.515719
SumYShuffleKernelVector256_Avx2_Multiply	191.560	1368.469	2.964523
SumYShuffleKernelVector256_Avx2_ShiftLane	81.117	3231.683	7.000812
SumYShuffleKernelVector256Traits	73.427	3570.122	7.733975

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	236.470	1108.571
SumShuffleVectorBase	362.609	722.939	0.652136
SumShuffleVectorTraits	20.433	12829.338	11.572860
SumShuffleVectorTraitsIf	21.936	11950.160	10.779787
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	16.337	16045.815	14.474323
SumShuffleVector256_Avx2_Add2	18.804	13940.630	12.575315
SumShuffleVector256_Avx2_Cmp2	15.963	16421.946	14.813616
SumShuffleVector256Traits	16.432	15953.429	14.390985
SumYShuffleKernelVectorTraits	13.059	20073.364	18.107422
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	13.326	19671.717	17.745112

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-24614
SumShuffleScalar	254.167	1031.387
SumShuffleVectorBase	254.298	1030.854	0.999483
SumShuffleVectorTraits	39.234	6681.637	6.478303
SumShuffleVectorTraitsIf	40.292	6506.151	6.308157
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	36.726	7137.918	6.920699
SumYShuffleKernelVectorTraits	35.976	7286.593	7.064850
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	35.795	7323.498	7.100631
SumYShuffleKernelVector256_Avx2_ShiftLane	73.049	3588.613	3.479405
SumYShuffleKernelVector256Traits	34.747	7544.304	7.314718

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	349.968	749.051
SumShuffleVectorBase	348.951	751.235	1.002916
SumShuffleVectorTraits	31.436	8338.923	11.132654
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	34.647	7566.122	10.100947
SumYShuffleKernelVectorTraits	23.348	11227.509	14.988983
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	23.415	11195.796	14.946644

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	583.382	449.352
SumShuffleVectorBase	568.000	461.521	1.027081
SumShuffleVectorTraits	91.246	2872.929	6.393495
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	92.410	2836.750	6.312981
SumYShuffleKernelVectorTraits	73.712	3556.306	7.914300
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	78.762	3328.313	7.406918
SumYShuffleKernelVector256_Avx2_Multiply	145.824	1797.676	4.000598
SumYShuffleKernelVector256_Avx2_ShiftLane	138.905	1887.217	4.199863
SumYShuffleKernelVector256Traits	71.633	3659.561	8.144085

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	209.638	1250.463
SumShuffleVectorBase	209.916	1248.802	0.998672
SumShuffleVectorTraits	14.173	18496.615	14.791819
SumShuffleVectorTraitsIf	13.204	19854.114	15.877416
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	17.516	14965.705	11.968136
SumShuffleVector256_Avx2_Add2	19.262	13609.407	10.883498
SumShuffleVector256_Avx2_Cmp2	12.800	20479.980	16.377924
SumShuffleVector256Traits	13.574	19312.856	15.444570
SumYShuffleKernelVectorTraits	13.095	20018.328	16.008739
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	13.426	19524.607	15.613908

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-24614
SumShuffleScalar	257.543	1017.865
SumShuffleVectorBase	261.534	1002.332	0.984739
SumShuffleVectorTraits	36.329	7215.832	7.089182
SumShuffleVectorTraitsIf	35.109	7466.547	7.335496
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	329.464	795.669	0.781703
SumShuffleVector256Traits	36.203	7241.032	7.113940
SumYShuffleKernelVectorTraits	35.625	7358.524	7.229370
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	36.086	7264.342	7.136841
SumYShuffleKernelVector256_Avx2_ShiftLane	34.330	7635.973	7.501949
SumYShuffleKernelVector256Traits	36.037	7274.390	7.146713

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	349.440	750.183
SumShuffleVectorBase	349.056	751.010	1.001101
SumShuffleVectorTraits	30.027	8730.199	11.637423
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	426.646	614.429	0.819039
SumShuffleVector256Traits	30.144	8696.374	11.592334
SumYShuffleKernelVectorTraits	21.116	12414.339	16.548409
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	23.475	11167.051	14.885765

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	568.788	460.882
SumShuffleVectorBase	575.775	455.289	0.987865
SumShuffleVectorTraits	84.615	3098.088	6.722092
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	508.191	515.838	1.119241
SumShuffleVector256Traits	86.425	3033.199	6.581298
SumYShuffleKernelVectorTraits	64.550	4061.084	8.811556
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	68.203	3843.581	8.339629
SumYShuffleKernelVector256_Avx2_Multiply	139.782	1875.383	4.069121
SumYShuffleKernelVector256_Avx2_ShiftLane	70.307	3728.555	8.090051
SumYShuffleKernelVector256Traits	62.757	4177.117	9.063320

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	203.290	1289.505
SumShuffleVectorBase	204.530	1281.688	0.993938
SumShuffleVectorTraits	12.415	21115.647	16.375002
SumShuffleVectorTraitsIf	12.433	21083.719	16.350243
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	280.536	934.438	0.724649
SumShuffleVector256_Avx2_Add1	14.907	17585.829	13.637659
SumShuffleVector256_Avx2_Add2	14.892	17603.386	13.651274
SumShuffleVector256_Avx2_Cmp2	12.410	21123.661	16.381217
SumShuffleVector256Traits	13.193	19869.433	15.408574
SumYShuffleKernelVectorTraits	12.144	21586.930	16.740478
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	12.102	21660.543	16.797565

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

### lntel Core i5-8250U - Debug
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

