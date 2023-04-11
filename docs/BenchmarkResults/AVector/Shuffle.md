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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-24614
SumShuffleScalar	268.281	977.125
SumShuffleVectorBase	265.091	988.882	1.012032
SumShuffleVectorTraits	41.416	6329.495	6.477674
SumShuffleVectorTraits_Args	17.286	15165.277	15.520310
SumShuffleVectorTraitsIf	42.121	6223.567	6.369267
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	40.658	6447.521	6.598463
SumYShuffleKernelVectorTraits	39.837	6580.357	6.734409
SumYShuffleKernelVectorTraits_Args	23.038	11378.707	11.645093
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	36.045	7272.680	7.442940
SumYShuffleKernelVector256_Avx2_ShiftLane	39.272	6675.097	6.831367
SumYShuffleKernelVector256Traits	43.253	6060.693	6.202579
SumYShuffleKernelVector256Traits_Args0	18.106	14478.387	14.817339
SumYShuffleKernelVector256Traits_Args	18.060	14514.909	14.854716
SumYShuffleKernelVector256Traits_ArgsX	128.866	2034.242	2.081865

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	364.299	719.585
SumShuffleVectorBase	363.987	720.202	1.000858
SumShuffleVectorTraits	43.255	6060.470	8.422179
SumShuffleVectorTraits_Args	28.806	9100.437	12.646792
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	42.398	6182.926	8.592354
SumYShuffleKernelVectorTraits	23.708	11057.054	15.365884
SumYShuffleKernelVectorTraits_Args	23.991	10926.760	15.184816
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	23.948	10946.444	15.212171
SumYShuffleKernelVector256Traits_Args0	25.706	10197.880	14.171898
SumYShuffleKernelVector256Traits_Args	37.299	7028.223	9.767056
SumYShuffleKernelVector256Traits_ArgsX	328.831	797.199	1.107860

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	674.086	388.888
SumShuffleVectorBase	675.765	387.922	0.997515
SumShuffleVectorTraits	172.260	1521.789	3.913178
SumShuffleVectorTraits_Args	73.527	3565.280	9.167879
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	155.497	1685.850	4.335049
SumYShuffleKernelVectorTraits	74.351	3525.779	9.066305
SumYShuffleKernelVectorTraits_Args	48.648	5388.578	13.856365
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	71.641	3659.143	9.409240
SumYShuffleKernelVector256_Avx2_DuplicateEven	69.129	3792.101	9.751132
SumYShuffleKernelVector256_Avx2_Multiply	169.368	1547.779	3.980009
SumYShuffleKernelVector256_Avx2_ShiftLane	71.057	3689.215	9.486567
SumYShuffleKernelVector256Traits	67.971	3856.706	9.917261
SumYShuffleKernelVector256Traits_Args0	53.253	4922.613	12.658169
SumYShuffleKernelVector256Traits_Args	52.963	4949.546	12.727425
SumYShuffleKernelVector256Traits_ArgsX	509.173	514.843	1.323883

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	208.541	1257.038
SumShuffleVectorBase	207.775	1261.674	1.003688
SumShuffleVectorTraits	15.584	16821.005	13.381463
SumShuffleVectorTraits_Args	8.636	30353.444	24.146803
SumShuffleVectorTraitsIf	16.517	15871.565	12.626164
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	18.636	14066.849	11.190474
SumShuffleVector256_Avx2_Add2	20.975	12497.801	9.942264
SumShuffleVector256_Avx2_Cmp2	18.856	13902.477	11.059713
SumShuffleVector256Traits	16.756	15644.366	12.445422
SumYShuffleKernelVectorTraits	12.211	21468.321	17.078501
SumYShuffleKernelVectorTraits_Args	8.641	30336.903	24.133644
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	12.615	20780.846	16.531600
SumYShuffleKernelVector256Traits_Args0	8.630	30376.894	24.165458
SumYShuffleKernelVector256Traits_Args	8.614	30433.525	24.210509
SumYShuffleKernelVector256Traits_ArgsX	63.979	4097.357	3.259533

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-24614
SumShuffleScalar	262.021	1000.470
SumShuffleVectorBase	264.087	992.643	0.992177
SumShuffleVectorTraits	35.288	7428.649	7.425158
SumShuffleVectorTraits_Args	17.534	14950.958	14.943934
SumShuffleVectorTraitsIf	35.243	7438.165	7.434671
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	329.676	795.157	0.794784
SumShuffleVector256Traits	35.209	7445.420	7.441922
SumYShuffleKernelVectorTraits	34.942	7502.279	7.498754
SumYShuffleKernelVectorTraits_Args	17.558	14929.846	14.922831
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	35.947	7292.527	7.289101
SumYShuffleKernelVector256_Avx2_ShiftLane	35.429	7399.235	7.395758
SumYShuffleKernelVector256Traits	34.971	7496.140	7.492618
SumYShuffleKernelVector256Traits_Args0	18.611	14085.065	14.078447
SumYShuffleKernelVector256Traits_Args	18.761	13972.953	13.966388
SumYShuffleKernelVector256Traits_ArgsX	19.360	13540.327	13.533965

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	350.095	748.779
SumShuffleVectorBase	349.209	750.679	1.002538
SumShuffleVectorTraits	24.989	10490.556	14.010209
SumShuffleVectorTraits_Args	25.163	10417.781	13.913017
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	429.059	610.974	0.815960
SumShuffleVector256Traits	25.389	10324.973	13.789072
SumYShuffleKernelVectorTraits	21.351	12277.920	16.397245
SumYShuffleKernelVectorTraits_Args	24.883	10535.200	14.069831
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	22.787	11504.115	15.363823
SumYShuffleKernelVector256Traits_Args0	23.203	11297.758	15.088232
SumYShuffleKernelVector256Traits_Args	23.238	11280.770	15.065544
SumYShuffleKernelVector256Traits_ArgsX	28.054	9344.374	12.479474

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	541.325	484.264
SumShuffleVectorBase	545.739	480.346	0.991910
SumShuffleVectorTraits	73.488	3567.148	7.366124
SumShuffleVectorTraits_Args	60.270	4349.488	8.981647
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	509.594	514.417	1.062267
SumShuffleVector256Traits	74.976	3496.389	7.220008
SumYShuffleKernelVectorTraits	70.656	3710.142	7.661405
SumYShuffleKernelVectorTraits_Args	54.165	4839.698	9.993927
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	75.070	3492.006	7.210957
SumYShuffleKernelVector256_Avx2_DuplicateEven	69.895	3750.545	7.744837
SumYShuffleKernelVector256_Avx2_Multiply	145.229	1805.039	3.727387
SumYShuffleKernelVector256_Avx2_ShiftLane	68.686	3816.579	7.881196
SumYShuffleKernelVector256Traits	70.705	3707.550	7.656052
SumYShuffleKernelVector256Traits_Args0	48.609	5392.885	11.136251
SumYShuffleKernelVector256Traits_Args	53.949	4859.118	10.034030
SumYShuffleKernelVector256Traits_ArgsX	78.006	3360.557	6.939515

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	206.229	1271.129
SumShuffleVectorBase	205.533	1275.434	1.003387
SumShuffleVectorTraits	11.066	23688.260	18.635611
SumShuffleVectorTraits_Args	7.804	33589.780	26.425160
SumShuffleVectorTraitsIf	11.610	22578.991	17.762946
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	280.712	933.853	0.734665
SumShuffleVector256_Avx2_Add1	16.053	16330.117	12.846942
SumShuffleVector256_Avx2_Add2	16.365	16018.142	12.601510
SumShuffleVector256_Avx2_Cmp2	13.344	19645.362	15.455053
SumShuffleVector256Traits	11.694	22417.412	17.635832
SumYShuffleKernelVectorTraits	12.307	21299.601	16.756447
SumYShuffleKernelVectorTraits_Args	7.783	33680.383	26.496438
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	12.718	20611.792	16.215346
SumYShuffleKernelVector256Traits_Args0	8.055	32542.570	25.601318
SumYShuffleKernelVector256Traits_Args	7.859	33357.251	26.242229
SumYShuffleKernelVector256Traits_ArgsX	10.766	24348.853	19.155301

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-24614
SumShuffleScalar	497.923	526.475
SumShuffleVectorBase	495.401	529.155	1.005090
SumShuffleVectorTraits	115.793	2263.910	4.300129
SumShuffleVectorTraits_Args	501.040	523.199	0.993778
SumShuffleVectorTraitsIf	498.516	525.848	0.998810
SumShuffleVector128_Bcl	550.795	475.937	0.904008
SumShuffleVector128_Arm	113.684	2305.904	4.379894
SumShuffleVector128Traits	115.536	2268.928	4.309661
SumShuffleVector256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	496.091	528.419	1.003693
SumYShuffleKernelVectorTraits_Args	503.384	520.764	0.989152
SumYShuffleKernelVector128_Arm	99.338	2638.902	5.012398
SumYShuffleKernelVector128Traits	98.953	2649.170	5.031901
SumYShuffleKernelVector256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleKernelVector256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleKernelVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
Check-SumShuffleVectorTraits	Fail! Check `SumShuffleVectorTraits` fail! -450784851!=-467755046
Check-SumShuffleVector128_Arm	Fail! Check `SumShuffleVector128_Arm` fail! -450784851!=-467755046
Check-SumShuffleVector128Traits	Fail! Check `SumShuffleVector128Traits` fail! -450784851!=-467755046
Check-SumYShuffleKernelVector128_Arm	Fail! Check `SumYShuffleKernelVector128_Arm` fail! -450784851!=-467755046
Check-SumYShuffleKernelVector128Traits	Fail! Check `SumYShuffleKernelVector128Traits` fail! -450784851!=-467755046
SumShuffleScalar	825.182	317.680
SumShuffleVectorBase	827.547	316.772	0.997142
SumShuffleVectorTraits	231.013	1134.757	3.572013
SumShuffleVectorTraits_Args	842.614	311.108	0.979312
SumShuffleVector128_Bcl	863.194	303.691	0.955964
SumShuffleVector128_Arm	230.674	1136.427	3.577270
SumShuffleVector128Traits	231.314	1133.280	3.567363
SumShuffleVector256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	827.506	316.788	0.997192
SumYShuffleKernelVectorTraits_Args	841.708	311.443	0.980367
SumYShuffleKernelVector128_Arm	198.583	1320.071	4.155348
SumYShuffleKernelVector128Traits	198.837	1318.389	4.150055
SumYShuffleKernelVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
Check-SumShuffleVectorTraits	Fail! Check `SumShuffleVectorTraits` fail! -7528318136335369236!=5910372263572008452
Check-SumShuffleVector128_Arm	Fail! Check `SumShuffleVector128_Arm` fail! -7528318136335369236!=5910372263572008452
Check-SumShuffleVector128Traits	Fail! Check `SumShuffleVector128Traits` fail! -7528318136335369236!=5910372263572008452
Check-SumYShuffleKernelVector128_Arm	Fail! Check `SumYShuffleKernelVector128_Arm` fail! -7528318136335369236!=5910372263572008452
Check-SumYShuffleKernelVector128_Arm_Multiply	Fail! Check `SumYShuffleKernelVector128_Arm_Multiply` fail! -7528318136335369236!=5910372263572008452
Check-SumYShuffleKernelVector128Traits	Fail! Check `SumYShuffleKernelVector128Traits` fail! -7528318136335369236!=5910372263572008452
SumShuffleScalar	474.526	552.433
SumShuffleVectorBase	474.449	552.522	1.000162
SumShuffleVectorTraits	837.556	312.987	0.566561
SumShuffleVectorTraits_Args	528.680	495.846	0.897569
SumShuffleVector128_Bcl	368.261	711.842	1.288559
SumShuffleVector128_Arm	838.562	312.611	0.565881
SumShuffleVector128Traits	837.793	312.898	0.566400
SumShuffleVector256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	474.527	552.433	0.999999
SumYShuffleKernelVectorTraits_Args	528.638	495.886	0.897640
SumYShuffleKernelVector128_Arm	407.499	643.299	1.164484
SumYShuffleKernelVector128_Arm_Multiply	602.658	434.980	0.787390
SumYShuffleKernelVector128Traits	407.805	642.817	1.163611
SumYShuffleKernelVector256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleKernelVector256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleKernelVector256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleKernelVector256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleKernelVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	312.302	839.393
SumShuffleVectorBase	314.592	833.284	0.992721
SumShuffleVectorTraits	18.402	14245.352	16.971007
SumShuffleVectorTraits_Args	315.256	831.526	0.990627
SumShuffleVectorTraitsIf	314.130	834.507	0.994179
SumShuffleVector128_Bcl	401.620	652.717	0.777606
SumShuffleVector128_Arm	18.410	14239.463	16.963991
SumShuffleVector128Traits	18.394	14251.245	16.978027
SumShuffleVector256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
SumShuffleVector256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	314.692	833.019	0.992405
SumYShuffleKernelVectorTraits_Args	315.441	831.040	0.990048
SumYShuffleKernelVector128_Arm	18.396	14250.198	16.976780
SumYShuffleKernelVector128Traits	18.399	14247.958	16.974111
SumYShuffleKernelVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

