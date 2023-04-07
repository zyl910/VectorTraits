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
SumShuffleScalar	271.546	965.377
SumShuffleVectorBase	266.061	985.277	1.020615
SumShuffleVectorTraits	49.859	5257.674	5.446242
SumShuffleVectorTraitsIf	52.933	4952.352	5.129969
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	45.003	5825.025	6.033940
SumYShuffleKernelVectorTraits	34.558	7585.640	7.857700
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	42.949	6103.661	6.322570
SumYShuffleKernelVector256_Avx2_ShiftLane	36.675	7147.803	7.404160
SumYShuffleKernelVector256Traits	38.984	6724.466	6.965640
SumYShuffleKernelVector256Traits_Args	18.013	14553.347	15.075305
SumYShuffleKernelVector256Traits_Args2	17.070	15357.311	15.908103
SumYShuffleKernelVector256Traits_ArgsX	147.082	1782.297	1.846219

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	451.092	581.132
SumShuffleVectorBase	392.610	667.695	1.148957
SumShuffleVectorTraits	56.346	4652.410	8.005777
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	67.810	3865.884	6.652338
SumYShuffleKernelVectorTraits	35.986	7284.671	12.535321
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	24.745	10593.654	18.229354
SumYShuffleKernelVector256Traits_Args	23.933	10953.298	18.848223
SumYShuffleKernelVector256Traits_Args2	23.651	11083.837	19.072852
SumYShuffleKernelVector256Traits_ArgsX	258.473	1014.204	1.745223

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	588.038	445.794
SumShuffleVectorBase	573.216	457.321	1.025857
SumShuffleVectorTraits	135.140	1939.791	4.351313
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	139.705	1876.404	4.209126
SumYShuffleKernelVectorTraits	77.479	3383.438	7.589685
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	87.412	2998.957	6.727221
SumYShuffleKernelVector256_Avx2_DuplicateEven	79.968	3278.121	7.353439
SumYShuffleKernelVector256_Avx2_Multiply	192.421	1362.349	3.056004
SumYShuffleKernelVector256_Avx2_ShiftLane	80.221	3267.779	7.330239
SumYShuffleKernelVector256Traits	70.695	3708.109	8.317982
SumYShuffleKernelVector256Traits_Args	46.985	5579.277	12.515361
SumYShuffleKernelVector256Traits_Args2	47.350	5536.264	12.418875
SumYShuffleKernelVector256Traits_ArgsX	508.336	515.691	1.156791

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	206.985	1266.489
SumShuffleVectorBase	207.629	1262.562	0.996899
SumShuffleVectorTraits	18.535	14143.465	11.167462
SumShuffleVectorTraitsIf	18.943	13838.665	10.926797
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	19.994	13111.297	10.352478
SumShuffleVector256_Avx2_Add2	21.814	12017.107	9.488522
SumShuffleVector256_Avx2_Cmp2	19.289	13590.082	10.730519
SumShuffleVector256Traits	17.675	14830.983	11.710316
SumYShuffleKernelVectorTraits	12.887	20341.978	16.061713
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	13.502	19415.464	15.330151
SumYShuffleKernelVector256Traits_Args	8.125	32262.322	25.473832
SumYShuffleKernelVector256Traits_Args2	8.516	30781.492	24.304592
SumYShuffleKernelVector256Traits_ArgsX	64.051	4092.744	3.231568

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
SumShuffleScalar	276.217	949.050
SumShuffleVectorBase	273.730	957.673	1.009086
SumShuffleVectorTraits	37.614	6969.245	7.343390
SumShuffleVectorTraitsIf	35.705	7342.013	7.736170
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	331.235	791.413	0.833900
SumShuffleVector256Traits	35.785	7325.465	7.718735
SumYShuffleKernelVectorTraits	33.928	7726.565	8.141367
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	34.953	7499.863	7.902494
SumYShuffleKernelVector256_Avx2_ShiftLane	42.784	6127.148	6.456085
SumYShuffleKernelVector256Traits	35.210	7445.251	7.844951
SumYShuffleKernelVector256Traits_Args	18.605	14090.046	14.846473
SumYShuffleKernelVector256Traits_Args2	18.510	14162.574	14.922895
SumYShuffleKernelVector256Traits_ArgsX	19.604	13371.749	14.089614

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	348.805	751.548
SumShuffleVectorBase	349.059	751.002	0.999273
SumShuffleVectorTraits	32.801	7992.027	10.634081
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	433.926	604.122	0.803837
SumShuffleVector256Traits	31.211	8399.020	11.175621
SumYShuffleKernelVectorTraits	27.683	9469.458	12.599931
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	26.065	10057.284	13.382083
SumYShuffleKernelVector256Traits_Args	24.176	10843.190	14.427800
SumYShuffleKernelVector256Traits_Args2	24.426	10732.063	14.279936
SumYShuffleKernelVector256Traits_ArgsX	28.386	9235.008	12.287975

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	745.622	351.578
SumShuffleVectorBase	570.943	459.142	1.305948
SumShuffleVectorTraits	104.854	2500.095	7.111075
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	536.241	488.854	1.390460
SumShuffleVector256Traits	96.760	2709.210	7.705867
SumYShuffleKernelVectorTraits	75.679	3463.881	9.852394
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	85.672	3059.858	8.703223
SumYShuffleKernelVector256_Avx2_DuplicateEven	75.362	3478.477	9.893910
SumYShuffleKernelVector256_Avx2_Multiply	160.603	1632.251	4.642647
SumYShuffleKernelVector256_Avx2_ShiftLane	75.255	3483.394	9.907895
SumYShuffleKernelVector256Traits	77.734	3372.338	9.592017
SumYShuffleKernelVector256Traits_Args	52.931	4952.518	14.086560
SumYShuffleKernelVector256Traits_Args2	54.058	4849.275	13.792903
SumYShuffleKernelVector256Traits_ArgsX	80.005	3276.602	9.319712

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	219.363	1195.025
SumShuffleVectorBase	207.385	1264.042	1.057754
SumShuffleVectorTraits	13.279	19741.574	16.519803
SumShuffleVectorTraitsIf	13.196	19864.822	16.622937
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	285.010	919.770	0.769666
SumShuffleVector256_Avx2_Add1	16.393	15991.530	13.381756
SumShuffleVector256_Avx2_Add2	16.922	15491.532	12.963356
SumShuffleVector256_Avx2_Cmp2	13.570	19318.501	16.165774
SumShuffleVector256Traits	13.437	19509.522	16.325621
SumYShuffleKernelVectorTraits	13.212	19841.019	16.603019
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	13.465	19469.173	16.291856
SumYShuffleKernelVector256Traits_Args	9.601	27303.895	22.847973
SumYShuffleKernelVector256Traits_Args2	8.813	29745.721	24.891300
SumYShuffleKernelVector256Traits_ArgsX	8.676	30214.307	25.283414

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

