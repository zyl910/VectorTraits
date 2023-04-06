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
SumShuffleScalar	264.537	990.956
SumShuffleVectorBase	264.706	990.321	0.999359
SumShuffleVectorTraits	49.285	5318.912	5.367456
SumShuffleVectorTraitsIf	49.119	5336.897	5.385605
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	44.896	5838.958	5.892249
SumYShuffleKernelVectorTraits	34.582	7580.370	7.649554
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	34.384	7623.971	7.693553
SumYShuffleKernelVector256_Avx2_ShiftLane	32.352	8102.850	8.176802
SumYShuffleKernelVector256Traits	38.000	6898.529	6.961490
SumYShuffleKernelVector256Traits_Args	16.423	15962.422	16.108107
SumYShuffleKernelVector256Traits_ArgsX	127.913	2049.399	2.068103

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	371.422	705.784
SumShuffleVectorBase	383.982	682.699	0.967291
SumShuffleVectorTraits	86.200	3041.104	4.308830
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	68.912	3804.033	5.389796
SumYShuffleKernelVectorTraits	31.012	8452.876	11.976574
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	31.823	8237.517	11.671439
SumYShuffleKernelVector256Traits_Args	32.959	7953.557	11.269106
SumYShuffleKernelVector256Traits_ArgsX	301.848	868.463	1.230494

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	745.621	351.578
SumShuffleVectorBase	773.163	339.054	0.964378
SumShuffleVectorTraits	157.628	1663.058	4.730269
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	248.903	1053.198	2.995633
SumYShuffleKernelVectorTraits	100.314	2613.243	7.432898
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	142.927	1834.107	5.216787
SumYShuffleKernelVector256_Avx2_DuplicateEven	94.794	2765.417	7.865731
SumYShuffleKernelVector256_Avx2_Multiply	180.605	1451.479	4.128470
SumYShuffleKernelVector256_Avx2_ShiftLane	105.761	2478.635	7.050030
SumYShuffleKernelVector256Traits	101.665	2578.510	7.334106
SumYShuffleKernelVector256Traits_Args	72.419	3619.808	10.295889
SumYShuffleKernelVector256Traits_ArgsX	608.302	430.944	1.225742

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	378.106	693.308
SumShuffleVectorBase	392.073	668.610	0.964377
SumShuffleVectorTraits	22.309	11750.766	16.948829
SumShuffleVectorTraitsIf	27.389	9570.980	13.804794
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	22.727	11534.227	16.636502
SumShuffleVector256_Avx2_Add2	25.644	10222.390	14.744361
SumShuffleVector256_Avx2_Cmp2	32.658	8027.039	11.577876
SumShuffleVector256Traits	31.362	8358.752	12.056325
SumYShuffleKernelVectorTraits	22.220	11797.813	17.016687
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	23.082	11356.859	16.380674
SumYShuffleKernelVector256Traits_Args	10.653	24608.032	35.493628
SumYShuffleKernelVector256Traits_ArgsX	69.735	3759.129	5.422016

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
SumShuffleScalar	258.287	1014.934
SumShuffleVectorBase	257.595	1017.661	1.002687
SumShuffleVectorTraits	35.538	7376.449	7.267908
SumShuffleVectorTraitsIf	35.568	7370.225	7.261776
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	332.368	788.716	0.777111
SumShuffleVector256Traits	35.749	7332.809	7.224911
SumYShuffleKernelVectorTraits	34.020	7705.502	7.592120
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	35.502	7383.901	7.275251
SumYShuffleKernelVector256_Avx2_ShiftLane	36.251	7231.326	7.124921
SumYShuffleKernelVector256Traits	35.538	7376.510	7.267969
SumYShuffleKernelVector256Traits_Args	17.633	14866.254	14.647505
SumYShuffleKernelVector256Traits_ArgsX	18.137	14453.446	14.240771

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	361.591	724.973
SumShuffleVectorBase	361.695	724.765	0.999713
SumShuffleVectorTraits	32.558	8051.677	11.106174
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	433.242	605.075	0.834618
SumShuffleVector256Traits	32.112	8163.302	11.260145
SumYShuffleKernelVectorTraits	24.710	10608.684	14.633211
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	22.339	11734.909	16.186683
SumYShuffleKernelVector256Traits_Args	22.508	11646.841	16.065206
SumYShuffleKernelVector256Traits_ArgsX	26.970	9719.699	13.406980

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	598.382	438.088
SumShuffleVectorBase	577.678	453.789	1.035840
SumShuffleVectorTraits	82.012	3196.391	7.296230
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	507.793	516.241	1.178397
SumShuffleVector256Traits	83.336	3145.623	7.180344
SumYShuffleKernelVectorTraits	68.906	3804.374	8.684038
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	75.446	3474.610	7.931305
SumYShuffleKernelVector256_Avx2_DuplicateEven	70.457	3720.613	8.492842
SumYShuffleKernelVector256_Avx2_Multiply	163.409	1604.222	3.661870
SumYShuffleKernelVector256_Avx2_ShiftLane	72.033	3639.203	8.307012
SumYShuffleKernelVector256Traits	73.113	3585.443	8.184296
SumYShuffleKernelVector256Traits_Args	50.556	5185.181	11.835933
SumYShuffleKernelVector256Traits_ArgsX	77.489	3382.964	7.722110

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	209.303	1252.462
SumShuffleVectorBase	212.689	1232.522	0.984079
SumShuffleVectorTraits	12.846	20406.566	16.293162
SumShuffleVectorTraitsIf	13.567	19322.669	15.427749
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	285.061	919.607	0.734239
SumShuffleVector256_Avx2_Add1	16.182	16199.866	12.934417
SumShuffleVector256_Avx2_Add2	16.361	16022.024	12.792423
SumShuffleVector256_Avx2_Cmp2	13.536	19366.488	15.462735
SumShuffleVector256Traits	13.538	19364.018	15.460763
SumYShuffleKernelVectorTraits	12.912	20303.038	16.210503
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	12.599	20806.368	16.612375
SumYShuffleKernelVector256Traits_Args	7.606	34466.871	27.519295
SumYShuffleKernelVector256Traits_ArgsX	7.720	33957.201	27.112361

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

