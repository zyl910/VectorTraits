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
SumShuffleScalar	261.133	1003.873
SumShuffleVectorBase	273.444	958.674	0.954975
SumShuffleVectorTraits	55.500	4723.340	4.705117
SumShuffleVectorTraits_Args2	17.785	14740.009	14.683142
SumShuffleVectorTraitsIf	43.352	6046.850	6.023521
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	47.883	5474.653	5.453532
SumYShuffleKernelVectorTraits	38.796	6756.975	6.730906
SumYShuffleKernelVectorTraits_Args2	17.769	14752.987	14.696070
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	33.346	7861.439	7.831110
SumYShuffleKernelVector256_Avx2_ShiftLane	28.866	9081.332	9.046296
SumYShuffleKernelVector256Traits	33.618	7797.733	7.767649
SumYShuffleKernelVector256Traits_Args	17.744	14773.751	14.716754
SumYShuffleKernelVector256Traits_Args2	18.075	14503.405	14.447451
SumYShuffleKernelVector256Traits_ArgsX	128.215	2044.573	2.036685

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	369.364	709.718
SumShuffleVectorBase	364.195	719.790	1.014192
SumShuffleVectorTraits	52.789	4965.884	6.996986
SumShuffleVectorTraits_Args2	29.179	8983.858	12.658356
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	54.434	4815.842	6.785574
SumYShuffleKernelVectorTraits	24.369	10757.215	15.157035
SumYShuffleKernelVectorTraits_Args2	24.342	10769.286	15.174044
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	25.479	10288.524	14.496644
SumYShuffleKernelVector256Traits_Args	25.619	10232.355	14.417502
SumYShuffleKernelVector256Traits_Args2	26.196	10007.009	14.099987
SumYShuffleKernelVector256Traits_ArgsX	254.435	1030.298	1.451701

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	645.213	406.291
SumShuffleVectorBase	576.918	454.387	1.118378
SumShuffleVectorTraits	130.100	2014.949	4.959377
SumShuffleVectorTraits_Args2	57.882	4528.968	11.147114
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	133.333	1966.087	4.839115
SumYShuffleKernelVectorTraits	71.680	3657.146	9.001304
SumYShuffleKernelVectorTraits_Args2	60.463	4335.596	10.671169
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	108.184	2423.130	5.964031
SumYShuffleKernelVector256_Avx2_DuplicateEven	71.185	3682.597	9.063948
SumYShuffleKernelVector256_Avx2_Multiply	171.142	1531.734	3.770045
SumYShuffleKernelVector256_Avx2_ShiftLane	78.997	3318.397	8.167544
SumYShuffleKernelVector256Traits	72.424	3619.595	8.908881
SumYShuffleKernelVector256Traits_Args	55.906	4689.001	11.541001
SumYShuffleKernelVector256Traits_Args2	47.963	5465.554	13.452324
SumYShuffleKernelVector256Traits_ArgsX	1055.282	248.411	0.611413

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	209.288	1252.550
SumShuffleVectorBase	209.561	1250.922	0.998700
SumShuffleVectorTraits	17.462	15012.586	11.985622
SumShuffleVectorTraits_Args2	9.623	27240.698	21.748198
SumShuffleVectorTraitsIf	18.629	14071.853	11.234567
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	18.497	14172.164	11.314652
SumShuffleVector256_Avx2_Add2	21.007	12479.030	9.962903
SumShuffleVector256_Avx2_Cmp2	18.977	13813.786	11.028534
SumShuffleVector256Traits	19.038	13769.412	10.993107
SumYShuffleKernelVectorTraits	13.417	19537.860	15.598471
SumYShuffleKernelVectorTraits_Args2	8.546	30673.733	24.489036
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	12.828	20435.753	16.315324
SumYShuffleKernelVector256Traits_Args	8.431	31093.717	24.824339
SumYShuffleKernelVector256Traits_Args2	8.330	31469.350	25.124234
SumYShuffleKernelVector256Traits_ArgsX	129.295	2027.482	1.618684

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
SumShuffleScalar	262.852	997.306
SumShuffleVectorBase	261.603	1002.068	1.004776
SumShuffleVectorTraits	35.328	7420.333	7.440381
SumShuffleVectorTraits_Args2	17.622	14876.163	14.916354
SumShuffleVectorTraitsIf	35.795	7323.545	7.343332
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	329.066	796.631	0.798783
SumShuffleVector256Traits	38.505	6808.013	6.826407
SumYShuffleKernelVectorTraits	36.208	7239.898	7.259459
SumYShuffleKernelVectorTraits_Args2	18.134	14455.927	14.494983
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	37.649	6962.795	6.981606
SumYShuffleKernelVector256_Avx2_ShiftLane	36.850	7113.886	7.133106
SumYShuffleKernelVector256Traits	37.071	7071.470	7.090576
SumYShuffleKernelVector256Traits_Args	18.207	14397.701	14.436600
SumYShuffleKernelVector256Traits_Args2	20.237	12953.407	12.988404
SumYShuffleKernelVector256Traits_ArgsX	18.105	14479.009	14.518127

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	350.520	747.872
SumShuffleVectorBase	350.072	748.830	1.001280
SumShuffleVectorTraits	30.796	8512.179	11.381862
SumShuffleVectorTraits_Args2	27.885	9400.914	12.570212
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	427.833	612.726	0.819292
SumShuffleVector256Traits	32.784	7996.006	10.691673
SumYShuffleKernelVectorTraits	22.632	11582.971	15.487900
SumYShuffleKernelVectorTraits_Args2	23.484	11162.428	14.925579
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	23.639	11089.453	14.828003
SumYShuffleKernelVector256Traits_Args	23.014	11390.581	15.230649
SumYShuffleKernelVector256Traits_Args2	23.419	11193.477	14.967096
SumYShuffleKernelVector256Traits_ArgsX	29.906	8765.503	11.720588

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	554.207	473.008
SumShuffleVectorBase	556.887	470.731	0.995187
SumShuffleVectorTraits	90.703	2890.143	6.110142
SumShuffleVectorTraits_Args2	58.780	4459.773	9.428544
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	509.571	514.441	1.087595
SumShuffleVector256Traits	85.127	3079.456	6.510373
SumYShuffleKernelVectorTraits	69.605	3766.184	7.962208
SumYShuffleKernelVectorTraits_Args2	47.792	5485.073	11.596162
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	75.016	3494.521	7.387876
SumYShuffleKernelVector256_Avx2_DuplicateEven	67.842	3864.016	8.169036
SumYShuffleKernelVector256_Avx2_Multiply	154.477	1696.975	3.587628
SumYShuffleKernelVector256_Avx2_ShiftLane	69.984	3745.755	7.919016
SumYShuffleKernelVector256Traits	71.052	3689.456	7.799994
SumYShuffleKernelVector256Traits_Args	48.110	5448.853	11.519590
SumYShuffleKernelVector256Traits_Args2	48.359	5420.812	11.460306
SumYShuffleKernelVector256Traits_ArgsX	78.119	3355.691	7.094370

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	205.323	1276.738
SumShuffleVectorBase	205.883	1273.270	0.997283
SumShuffleVectorTraits	13.063	20067.006	15.717400
SumShuffleVectorTraits_Args2	7.816	33540.933	26.270798
SumShuffleVectorTraitsIf	13.617	19251.547	15.078695
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	287.328	912.351	0.714595
SumShuffleVector256_Avx2_Add1	16.272	16109.839	12.617965
SumShuffleVector256_Avx2_Add2	16.376	16007.658	12.537932
SumShuffleVector256_Avx2_Cmp2	13.100	20010.666	15.673272
SumShuffleVector256Traits	12.593	20816.502	16.304440
SumYShuffleKernelVectorTraits	12.860	20383.662	15.965419
SumYShuffleKernelVectorTraits_Args2	7.835	33456.541	26.204698
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	12.474	21015.244	16.460103
SumYShuffleKernelVector256Traits_Args	7.962	32924.288	25.787813
SumYShuffleKernelVector256Traits_Args2	8.006	32744.221	25.646777
SumYShuffleKernelVector256Traits_ArgsX	8.232	31843.593	24.941364

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

