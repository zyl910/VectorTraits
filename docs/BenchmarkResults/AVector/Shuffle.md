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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	364.049	720.079
SumBase	414.876	631.861	0.877489
SumTraits	411.968	636.322	0.883684
SumTraits_Args	419.727	624.559	0.867348
SumTraitsIf	402.173	651.820	0.905206
SumKernelTraits	368.223	711.917	0.988666
SumKernelTraits_Args	371.774	705.117	0.979223

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	523.746	500.518
SumBase	511.049	512.952	1.024844
SumTraits	499.734	524.567	1.048049
SumTraits_Args	557.632	470.102	0.939231
SumKernelTraits	494.553	530.063	1.059029
SumKernelTraits_Args	529.675	494.915	0.988807

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	751.643	348.761
SumBase	784.108	334.321	0.958597
SumTraits	706.027	371.295	1.064609
SumTraits_Args	675.206	388.243	1.113206
SumKernelTraits	725.812	361.174	1.035590
SumKernelTraits_Args	814.979	321.657	0.922285

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	320.822	817.101
SumBase	331.632	790.467	0.967403
SumTraits	317.795	824.883	1.009523
SumTraits_Args0	306.081	856.454	1.048161
SumTraits_Args	313.816	835.343	1.022325
SumTraitsIf	312.701	838.323	1.025972
SumKernelTraits	339.209	772.810	0.945794
SumKernelTraits_Args0	309.313	847.505	1.037209
SumKernelTraits_Args	357.770	732.717	0.896727

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	361.103	725.953
SumBase	376.110	696.988	0.960102
SumTraits	349.464	750.132	1.033307
SumTraits_Args	350.500	747.914	1.030252
SumTraitsIf	366.547	715.171	0.985148
SumKernelTraits	348.100	753.072	1.037357
SumKernelTraits_Args	352.523	743.623	1.024341

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	475.409	551.408
SumBase	453.673	577.825	1.047909
SumTraits	457.333	573.201	1.039523
SumTraits_Args	469.117	558.804	1.013412
SumKernelTraits	460.160	569.680	1.033137
SumKernelTraits_Args	468.486	559.555	1.014776

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	713.232	367.544
SumBase	710.738	368.833	1.003509
SumTraits	713.881	367.210	0.999092
SumTraits_Args	709.817	369.312	1.004812
SumKernelTraits	716.845	365.691	0.994961
SumKernelTraits_Args	694.879	377.252	1.026413

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	281.814	930.202
SumBase	289.014	907.027	0.975086
SumTraits	286.206	915.927	0.984654
SumTraits_Args0	320.730	817.335	0.878664
SumTraits_Args	300.178	873.297	0.938824
SumTraitsIf	284.303	922.057	0.991244
SumKernelTraits	306.214	856.082	0.920318
SumKernelTraits_Args0	333.210	786.724	0.845755
SumKernelTraits_Args	299.627	874.900	0.940548

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	261.589	1002.120
SumBase	261.463	1002.604	1.000483
SumTraits	48.256	5432.360	5.420867
SumTraits_Args0	18.019	14548.168	14.517388
SumTraits_Args	18.252	14362.619	14.332232
SumTraitsIf	50.644	5176.227	5.165276
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	48.750	5377.273	5.365897
SumKernelTraits	42.901	6110.396	6.097469
SumKernelTraits_Args0	18.689	14026.949	13.997273
SumKernelTraits_Args	18.748	13982.499	13.952916
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	38.514	6806.498	6.792097
SumKernel256_Avx2_ShiftLane	33.953	7720.794	7.704460
SumKernel256Traits	38.981	6724.979	6.710752
SumKernel256Traits_Args0	18.932	13846.778	13.817483
SumKernel256Traits_Args	18.134	14455.580	14.424997
SumKernel256Traits_ArgsX	128.938	2033.098	2.028796

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	363.557	721.053
SumBase	362.976	722.207	1.001600
SumTraits	53.838	4869.148	6.752826
SumTraits_Args0	28.562	9178.164	12.728829
SumTraits_Args	28.560	9178.835	12.729759
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	52.097	5031.848	6.978469
SumKernelTraits	25.621	10231.718	14.189961
SumKernelTraits_Args0	25.006	10483.109	14.538605
SumKernelTraits_Args	27.033	9697.305	13.448805
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	27.805	9427.886	13.075159
SumKernel256Traits_Args0	27.475	9541.233	13.232355
SumKernel256Traits_Args	26.743	9802.221	13.594308
SumKernel256Traits_ArgsX	261.795	1001.332	1.388707

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	581.044	451.160
SumBase	592.200	442.661	0.981161
SumTraits	152.582	1718.058	3.808087
SumTraits_Args0	64.175	4084.857	9.054113
SumTraits_Args	68.813	3809.490	8.443760
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	161.534	1622.846	3.597049
SumKernelTraits	108.658	2412.565	5.347467
SumKernelTraits_Args0	63.720	4114.005	9.118718
SumKernelTraits_Args	81.133	3231.030	7.161599
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	96.692	2711.116	6.009205
SumKernel256_Avx2_DuplicateEven	119.760	2188.915	4.851744
SumKernel256_Avx2_Multiply	208.084	1259.801	2.792356
SumKernel256_Avx2_ShiftLane	84.081	3117.751	6.910515
SumKernel256Traits	84.834	3090.072	6.849164
SumKernel256Traits_Args0	55.472	4725.678	10.474495
SumKernel256Traits_Args	60.311	4346.573	9.634207
SumKernel256Traits_ArgsX	528.971	495.573	1.098441

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	221.895	1181.388
SumBase	220.601	1188.316	1.005864
SumTraits	18.349	14286.595	12.093056
SumTraits_Args0	8.726	30041.305	25.428814
SumTraits_Args	8.876	29533.209	24.998730
SumTraitsIf	19.626	13356.780	11.306002
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	21.773	12040.114	10.191496
Sum256_Avx2_Add2	21.994	11918.770	10.088782
Sum256_Avx2_Cmp2	19.367	13535.703	11.457454
Sum256Traits	17.477	14999.484	12.696489
SumKernelTraits	11.580	22636.983	19.161339
SumKernelTraits_Args0	8.201	31966.611	27.058512
SumKernelTraits_Args	8.403	31197.724	26.407679
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	13.634	19226.759	16.274715
SumKernel256Traits_Args0	8.731	30026.148	25.415985
SumKernel256Traits_Args	8.831	29686.074	25.128125
SumKernel256Traits_ArgsX	64.542	4061.622	3.438008

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	409.440	640.250
SumBase	466.879	561.482	0.876973
SumTraits	34.789	7535.322	11.769346
SumTraits_Args0	18.916	13858.001	21.644677
SumTraits_Args	17.989	14572.117	22.760048
SumTraitsIf	36.371	7207.413	11.257188
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	30.507	8592.878	13.421133
SumKernelTraits	29.662	8837.738	13.803577
SumKernelTraits_Args0	18.356	14280.957	22.305288
SumKernelTraits_Args	17.740	14777.306	23.080531
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	25.591	10243.729	15.999582
SumKernel256_Avx2_ShiftLane	26.991	9712.368	15.169654
SumKernel256Traits	25.722	10191.529	15.918051
SumKernel256Traits_Args0	18.000	14563.404	22.746440
SumKernel256Traits_Args	17.539	14946.754	23.345191
SumKernel256Traits_ArgsX	272.704	961.277	1.501409

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	674.750	388.505
SumBase	795.240	329.641	0.848486
SumTraits	55.030	4763.636	12.261439
SumTraits_Args0	33.353	7859.752	20.230738
SumTraits_Args	30.685	8543.048	21.989519
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	37.723	6949.108	17.886772
SumKernelTraits	39.004	6720.985	17.299591
SumKernelTraits_Args0	27.946	9380.232	24.144404
SumKernelTraits_Args	24.889	10532.355	27.109929
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	27.326	9593.368	24.693007
SumKernel256Traits_Args0	23.959	10941.415	28.162837
SumKernel256Traits_Args	25.419	10312.775	26.544737
SumKernel256Traits_ArgsX	254.626	1029.526	2.649965

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	554.094	473.104
SumBase	555.743	471.700	0.997033
SumTraits	94.850	2763.767	5.841780
SumTraits_Args0	69.776	3756.956	7.941084
SumTraits_Args	68.246	3841.176	8.119102
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	105.624	2481.871	5.245936
SumKernelTraits	82.555	3175.395	6.711838
SumKernelTraits_Args0	53.074	4939.172	10.439937
SumKernelTraits_Args	50.281	5213.557	11.019906
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_AdvSimd_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	79.770	3286.242	6.946136
SumKernel256_Avx2_DuplicateEven	78.120	3355.645	7.092834
SumKernel256_Avx2_Multiply	119.951	2185.421	4.619329
SumKernel256_Avx2_ShiftLane	78.403	3343.534	7.067233
SumKernel256Traits	78.455	3341.324	7.062564
SumKernel256Traits_Args0	50.043	5238.326	11.072260
SumKernel256Traits_Args	49.543	5291.286	11.184202
SumKernel256Traits_ArgsX	508.514	515.509	1.089633

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	205.391	1276.319
SumBase	258.979	1012.221	0.793078
SumTraits	14.347	18271.298	14.315623
SumTraits_Args0	8.812	29749.289	23.308668
SumTraits_Args	8.325	31488.322	24.671207
SumTraitsIf	14.183	18483.143	14.481605
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	15.050	17417.900	13.646983
Sum256_Avx2_Add2	14.651	17892.073	14.018499
Sum256_Avx2_Cmp2	13.419	19535.171	15.305873
Sum256Traits	13.114	19989.362	15.661732
SumKernelTraits	11.162	23485.443	18.400924
SumKernelTraits_Args0	8.356	31372.423	24.580399
SumKernelTraits_Args	8.374	31305.099	24.527651
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	10.721	24450.863	19.157334
SumKernel256Traits_Args0	8.255	31756.908	24.881645
SumKernel256Traits_Args	8.848	29626.979	23.212837
SumKernel256Traits_ArgsX	65.403	4008.110	3.140367

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	254.360	1030.604
SumBase	258.710	1013.275	0.983185
SumTraits	31.266	8384.318	8.135343
SumTraits_Args0	17.743	14774.390	14.335659
SumTraits_Args	17.860	14677.612	14.241755
SumTraitsIf	34.300	7642.777	7.415821
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	27.795	9431.433	9.151363
SumKernelTraits	27.720	9456.968	9.176140
SumKernelTraits_Args0	18.376	14265.217	13.841606
SumKernelTraits_Args	18.287	14335.162	13.909474
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	25.378	10329.669	10.022926
SumKernel256_Avx2_ShiftLane	26.939	9731.122	9.442153
SumKernel256Traits	24.054	10898.324	10.574694
SumKernel256Traits_Args0	18.597	14095.705	13.677127
SumKernel256Traits_Args	18.081	14498.622	14.068080
SumKernel256Traits_ArgsX	136.873	1915.238	1.858364

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	372.163	704.380
SumBase	368.973	710.470	1.008646
SumTraits	40.952	6401.298	9.087850
SumTraits_Args0	29.722	8819.942	12.521571
SumTraits_Args	30.227	8672.573	12.312353
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	31.174	8409.179	11.938415
SumKernelTraits	37.647	6963.272	9.885679
SumKernelTraits_Args0	26.978	9717.053	13.795190
SumKernelTraits_Args	26.359	9945.093	14.118935
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	24.926	10516.948	14.930792
SumKernel256Traits_Args0	24.221	10823.037	15.365343
SumKernel256Traits_Args	24.560	10673.596	15.153183
SumKernel256Traits_ArgsX	253.032	1036.011	1.470812

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	579.384	452.453
SumBase	573.608	457.009	1.010069
SumTraits	84.312	3109.226	6.871936
SumTraits_Args0	59.701	4390.965	9.704805
SumTraits_Args	64.119	4088.380	9.036038
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	91.756	2856.960	6.314384
SumKernelTraits	90.569	2894.418	6.397173
SumKernelTraits_Args0	53.235	4924.255	10.883470
SumKernelTraits_Args	50.844	5155.827	11.395285
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_AdvSimd_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	86.453	3032.197	6.701689
SumKernel256_Avx2_DuplicateEven	79.598	3293.350	7.278883
SumKernel256_Avx2_Multiply	115.942	2260.998	4.997203
SumKernel256_Avx2_ShiftLane	81.147	3230.491	7.139953
SumKernel256Traits	81.282	3225.102	7.128044
SumKernel256Traits_Args0	56.036	4678.115	10.339457
SumKernel256Traits_Args	49.730	5271.309	11.650521
SumKernel256Traits_ArgsX	645.802	405.920	0.897155

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	233.277	1123.744
SumBase	220.494	1188.893	1.057975
SumTraits	13.462	19472.402	17.328141
SumTraits_Args0	9.133	28703.448	25.542684
SumTraits_Args	8.610	30446.358	27.093668
SumTraitsIf	14.101	18590.433	16.543293
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	15.166	17284.459	15.381130
Sum256_Avx2_Add2	14.463	18124.641	16.128794
Sum256_Avx2_Cmp2	11.479	22836.687	20.321958
Sum256Traits	13.077	20046.823	17.839308
SumKernelTraits	12.050	21755.175	19.359541
SumKernelTraits_Args0	8.762	29919.959	26.625236
SumKernelTraits_Args	8.256	31753.230	28.256630
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	10.466	25047.684	22.289485
SumKernel256Traits_Args0	8.356	31370.307	27.915874
SumKernel256Traits_Args	8.867	29564.974	26.309340
SumKernel256Traits_ArgsX	64.157	4085.947	3.636011

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	262.340	999.254
SumBase	262.827	997.400	0.998145
SumTraits	26.119	10036.469	10.043963
SumTraits_Args0	17.550	14936.945	14.948099
SumTraits_Args	18.184	14416.231	14.426996
SumTraitsIf	28.662	9146.139	9.152968
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	338.825	773.685	0.774262
Sum256Traits	23.202	11298.503	11.306940
SumKernelTraits	22.291	11760.335	11.769117
SumKernelTraits_Args0	18.191	14410.451	14.421212
SumKernelTraits_Args	18.587	14103.479	14.114010
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	19.677	13322.406	13.332354
SumKernel256_Avx2_ShiftLane	23.775	11026.035	11.034268
SumKernel256Traits	18.213	14393.301	14.404049
SumKernel256Traits_Args0	17.924	14625.006	14.635926
SumKernel256Traits_Args	18.179	14420.499	14.431267
SumKernel256Traits_ArgsX	19.804	13236.677	13.246561

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	350.571	747.763
SumBase	352.169	744.370	0.995462
SumTraits	28.537	9185.949	12.284573
SumTraits_Args0	28.251	9279.126	12.409180
SumTraits_Args	28.350	9246.596	12.365678
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	428.132	612.297	0.818838
Sum256Traits	29.942	8754.993	11.708246
SumKernelTraits	26.901	9744.936	13.032118
SumKernelTraits_Args0	24.988	10490.592	14.029301
SumKernelTraits_Args	24.360	10761.289	14.391310
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	23.609	11103.420	14.848849
SumKernel256Traits_Args0	23.696	11062.919	14.794686
SumKernel256Traits_Args	23.931	10954.157	14.649236
SumKernel256Traits_ArgsX	28.318	9257.020	12.379618

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	587.904	445.896
SumBase	567.595	461.850	1.035780
SumTraits	83.690	3132.322	7.024776
SumTraits_Args0	60.518	4331.686	9.714558
SumTraits_Args	63.972	4097.802	9.190034
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	530.464	494.179	1.108282
Sum256Traits	74.073	3538.980	7.936778
SumKernelTraits	65.823	3982.585	8.931638
SumKernelTraits_Args0	51.690	5071.424	11.373551
SumKernelTraits_Args	52.884	4956.971	11.116869
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_AdvSimd_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	69.918	3749.329	8.408523
SumKernel256_Avx2_DuplicateEven	60.264	4349.963	9.755548
SumKernel256_Avx2_Multiply	127.548	2055.258	4.609273
SumKernel256_Avx2_ShiftLane	60.708	4318.090	9.684069
SumKernel256Traits	61.790	4242.528	9.514607
SumKernel256Traits_Args0	54.952	4770.449	10.698562
SumKernel256Traits_Args	52.655	4978.567	11.165303
SumKernel256Traits_ArgsX	81.818	3203.998	7.185523

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	216.722	1209.587
SumBase	215.774	1214.899	1.004392
SumTraits	11.147	23517.824	19.442862
SumTraits_Args0	8.389	31248.159	25.833752
SumTraits_Args	8.838	29659.342	24.520231
SumTraitsIf	12.142	21589.596	17.848740
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	299.760	874.514	0.722986
Sum256_Avx2_Add1	11.474	22846.314	18.887705
Sum256_Avx2_Add2	11.635	22531.317	18.627288
Sum256_Avx2_Cmp2	11.286	23226.673	19.202159
Sum256Traits	9.166	28598.289	23.643028
SumKernelTraits	9.692	27047.597	22.361027
SumKernelTraits_Args0	8.682	30194.072	24.962308
SumKernelTraits_Args	8.830	29686.895	24.543010
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	8.836	29666.696	24.526312
SumKernel256Traits_Args0	9.119	28747.614	23.766480
SumKernel256Traits_Args	8.526	30747.501	25.419844
SumKernel256Traits_ArgsX	8.635	30357.849	25.097708

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
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	False
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
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Debug/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	3187.620	82.238
SumBase	3414.460	76.775	0.933565
SumTraits	3615.382	72.508	0.881683
SumTraits_Args	4088.393	64.119	0.779676
SumTraitsIf	3516.412	74.549	0.906498
SumKernelTraits	3794.537	69.085	0.840055
SumKernelTraits_Args	4262.082	61.506	0.747902

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	4478.182	58.538
SumBase	4863.120	53.904	0.920845
SumTraits	5270.370	49.739	0.849690
SumTraits_Args	6254.281	41.914	0.716019
SumKernelTraits	5690.629	46.066	0.786940
SumKernelTraits_Args	6662.572	39.346	0.672140

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	7398.816	35.431
SumBase	8296.050	31.599	0.891848
SumTraits	9095.770	28.820	0.813435
SumTraits_Args	11080.976	23.657	0.667704
SumKernelTraits	9861.740	26.582	0.750255
SumKernelTraits_Args	11764.165	22.283	0.628928

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	2389.155	109.722
SumBase	2482.882	105.581	0.962251
SumTraits	2582.314	101.515	0.925199
SumTraits_Args0	2702.396	97.004	0.884088
SumTraits_Args	2819.974	92.960	0.847226
SumTraitsIf	2519.513	104.045	0.948260
SumKernelTraits	2687.743	97.533	0.888907
SumKernelTraits_Args0	2808.365	93.344	0.850728
SumKernelTraits_Args	2917.298	89.858	0.818961

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

IsRelease:	False
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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	4491.798	58.361
SumBase	4543.233	57.700	0.988679
SumTraits	4754.390	55.137	0.944769
SumTraits_Args	5521.839	47.474	0.813461
SumTraitsIf	4540.311	57.737	0.989315
SumKernelTraits	5060.926	51.798	0.887545
SumKernelTraits_Args	5711.174	45.900	0.786493

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	6114.802	42.870
SumBase	6694.475	39.158	0.913410
SumTraits	7279.529	36.011	0.840000
SumTraits_Args	8369.761	31.320	0.730583
SumKernelTraits	7578.830	34.589	0.806827
SumKernelTraits_Args	9032.710	29.022	0.676962

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	9984.363	26.255
SumBase	11209.057	23.387	0.890741
SumTraits	12067.927	21.722	0.827347
SumTraits_Args	14755.641	17.766	0.676647
SumKernelTraits	12873.776	20.363	0.775558
SumKernelTraits_Args	17284.581	15.166	0.577646

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	3608.444	72.647
SumBase	3632.204	72.172	0.993459
SumTraits	3703.495	70.783	0.974335
SumTraits_Args0	3920.343	66.868	0.920441
SumTraits_Args	3918.909	66.892	0.920778
SumTraitsIf	3712.279	70.615	0.972029
SumKernelTraits	3903.608	67.154	0.924387
SumKernelTraits_Args0	4101.343	63.917	0.879820
SumKernelTraits_Args	4065.897	64.474	0.887490

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

IsRelease:	False
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
# SumScalar	-24614
SumScalar	4479.058	58.527
SumBase	4611.496	56.846	0.971281
SumTraits	3922.071	66.838	1.142013
SumTraits_Args	3819.500	68.633	1.172682
SumTraitsIf	4699.095	55.786	0.953175
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	3304.974	79.318	1.355248
SumKernelTraits	3405.680	76.973	1.315173
SumKernelTraits_Args	3690.256	71.037	1.213753
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	1203.338	217.847	3.722195
SumKernel256_Avx2_ShiftLane	1049.932	249.677	4.266048
SumKernel256Traits	2700.502	97.072	1.658602
SumKernel256Traits_Args0	1852.122	141.537	2.418339
SumKernel256Traits_Args	2289.409	114.503	1.956425
SumKernel256Traits_ArgsX	2040.146	128.493	2.195459

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	5675.411	46.189
SumBase	5347.569	49.021	1.061307
SumTraits	6916.693	37.900	0.820538
SumTraits_Args	7271.279	36.052	0.780524
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4105.668	63.849	1.382336
SumKernelTraits	5069.946	51.705	1.119422
SumKernelTraits_Args	6090.297	43.043	0.931878
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	2402.556	109.110	2.362239
SumKernel256Traits_Args0	3383.797	77.470	1.677232
SumKernel256Traits_Args	3536.218	74.131	1.604938
SumKernel256Traits_ArgsX	3630.973	72.197	1.563055

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	8302.264	31.575
SumBase	8213.200	31.917	1.010844
SumTraits	13419.624	19.534	0.618666
SumTraits_Args	14535.873	18.034	0.571157
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	9140.941	28.678	0.908250
SumKernelTraits	11252.104	23.297	0.737841
SumKernelTraits_Args	12340.534	21.243	0.672764
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	2704.404	96.932	3.069905
SumKernel256_Avx2_DuplicateEven	2661.071	98.511	3.119895
SumKernel256_Avx2_Multiply	8175.939	32.063	1.015451
SumKernel256_Avx2_ShiftLane	3010.419	87.079	2.757843
SumKernel256Traits	8597.283	30.491	0.965685
SumKernel256Traits_Args0	5984.397	43.805	1.387318
SumKernel256Traits_Args	7460.451	35.138	1.112837
SumKernel256Traits_ArgsX	7411.221	35.371	1.120229

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	3111.142	84.260
SumBase	3115.156	84.151	0.998712
SumTraits	1731.107	151.431	1.797198
SumTraits_Args0	1771.971	147.939	1.755752
SumTraits_Args	1831.607	143.122	1.698586
SumTraitsIf	1910.871	137.186	1.628128
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	604.187	433.879	5.149302
Sum256_Avx2_Add2	876.580	299.053	3.549182
Sum256_Avx2_Cmp2	644.942	406.462	4.823914
Sum256Traits	1210.058	216.638	2.571070
SumKernelTraits	1520.943	172.356	2.045535
SumKernelTraits_Args0	1818.604	144.146	1.710731
SumKernelTraits_Args	1818.013	144.193	1.711287
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	971.749	269.765	3.201591
SumKernel256Traits_Args0	838.177	312.755	3.711798
SumKernel256Traits_Args	921.409	284.503	3.376506
SumKernel256Traits_ArgsX	890.979	294.220	3.491825

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

IsRelease:	False
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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	3659.446	71.635
SumBase	4156.109	63.074	0.880498
SumTraits	2605.297	100.620	1.404617
SumTraits_Args	1895.233	138.318	1.930869
SumTraitsIf	2606.960	100.555	1.403721
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	2545.968	102.964	1.437350
SumKernelTraits	2126.156	123.295	1.721156
SumKernelTraits_Args	1901.477	137.863	1.924528
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	1277.449	205.209	2.864650
SumKernel256_Avx2_ShiftLane	1254.164	209.019	2.917838
SumKernel256Traits	2220.467	118.058	1.648052
SumKernel256Traits_Args0	1803.249	145.373	2.029363
SumKernel256Traits_Args	1963.836	133.486	1.863417
SumKernel256Traits_ArgsX	2001.314	130.986	1.828522

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	4869.898	53.829
SumBase	5060.029	51.807	0.962425
SumTraits	3025.435	86.647	1.609653
SumTraits_Args	3063.728	85.564	1.589534
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	3690.144	71.039	1.319704
SumKernelTraits	1918.563	136.636	2.538305
SumKernelTraits_Args	2832.623	92.545	1.719219
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	2428.839	107.930	2.005031
SumKernel256Traits_Args0	2932.497	89.393	1.660666
SumKernel256Traits_Args	3191.248	82.145	1.526017
SumKernel256Traits_ArgsX	3259.118	80.434	1.494238

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	7077.051	37.041
SumBase	8673.831	30.222	0.815908
SumTraits	7464.542	35.119	0.948089
SumTraits_Args	6702.249	39.113	1.055922
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	9496.496	27.604	0.745228
SumKernelTraits	6803.024	38.533	1.040280
SumKernelTraits_Args	6344.770	41.317	1.115415
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_AdvSimd_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	3324.865	78.843	2.128523
SumKernel256_Avx2_DuplicateEven	3380.308	77.550	2.093611
SumKernel256_Avx2_Multiply	6513.509	40.246	1.086519
SumKernel256_Avx2_ShiftLane	3228.741	81.191	2.191892
SumKernel256Traits	7230.816	36.254	0.978735
SumKernel256Traits_Args0	5960.993	43.977	1.187227
SumKernel256Traits_Args	6627.594	39.553	1.067816
SumKernel256Traits_ArgsX	6006.490	43.643	1.178234

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	3294.127	79.579
SumBase	2954.426	88.729	1.114980
SumTraits	1030.290	254.437	3.197280
SumTraits_Args0	635.962	412.201	5.179756
SumTraits_Args	779.519	336.289	4.225843
SumTraitsIf	1179.966	222.162	2.791714
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	658.782	397.922	5.000326
Sum256_Avx2_Add2	813.638	322.188	4.048641
Sum256_Avx2_Cmp2	784.775	334.037	4.197544
Sum256Traits	1518.394	172.646	2.169480
SumKernelTraits	910.236	287.996	3.618983
SumKernelTraits_Args0	784.636	334.096	4.198285
SumKernelTraits_Args	883.418	296.738	3.728842
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	991.568	264.373	3.322139
SumKernel256Traits_Args0	796.369	329.174	4.136431
SumKernel256Traits_Args	906.205	289.277	3.635080
SumKernel256Traits_ArgsX	906.825	289.079	3.632594

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

IsRelease:	False
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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	3983.320	65.810
SumBase	4301.353	60.945	0.926062
SumTraits	2527.111	103.733	1.576235
SumTraits_Args	1947.288	134.620	2.045573
SumTraitsIf	2621.263	100.007	1.519619
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	3278.303	79.963	1.215055
SumKernelTraits	2278.241	115.064	1.748419
SumKernelTraits_Args	1964.366	133.450	2.027790
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	1521.159	172.332	2.618609
SumKernel256_Avx2_ShiftLane	1551.875	168.921	2.566780
SumKernel256Traits	2550.463	102.783	1.561803
SumKernel256Traits_Args0	1725.574	151.917	2.308402
SumKernel256Traits_Args	1747.015	150.053	2.280072
SumKernel256Traits_ArgsX	2020.983	129.711	1.970982

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	5558.443	47.161
SumBase	5207.476	50.340	1.067397
SumTraits	2897.688	90.467	1.918234
SumTraits_Args	3166.130	82.796	1.755595
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	3769.495	69.544	1.474585
SumKernelTraits	1635.267	160.306	3.399103
SumKernelTraits_Args	3063.181	85.579	1.814598
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	2270.328	115.465	2.448300
SumKernel256Traits_Args0	2760.348	94.968	2.013675
SumKernel256Traits_Args	3138.839	83.516	1.770859
SumKernel256Traits_ArgsX	3100.279	84.555	1.792884

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	7259.248	36.112
SumBase	7650.651	34.264	0.948841
SumTraits	6964.601	37.639	1.042306
SumTraits_Args	6271.435	41.800	1.157510
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	9703.593	27.015	0.748099
SumKernelTraits	6014.187	43.588	1.207021
SumKernelTraits_Args	6090.595	43.041	1.191878
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_AdvSimd_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	3838.350	68.296	1.891242
SumKernel256_Avx2_DuplicateEven	3898.068	67.250	1.862268
SumKernel256_Avx2_Multiply	5951.690	44.045	1.219695
SumKernel256_Avx2_ShiftLane	3950.675	66.354	1.837470
SumKernel256Traits	7361.169	35.612	0.986154
SumKernel256Traits_Args0	5610.795	46.721	1.293800
SumKernel256Traits_Args	6270.597	41.805	1.157664
SumKernel256Traits_ArgsX	5767.491	45.452	1.258649

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	3244.245	80.803
SumBase	3338.599	78.519	0.971738
SumTraits	881.727	297.307	3.679419
SumTraits_Args0	740.103	354.199	4.383506
SumTraits_Args	931.447	281.437	3.483016
SumTraitsIf	981.226	267.160	3.306317
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	563.724	465.022	5.755020
Sum256_Avx2_Add2	751.966	348.611	4.314349
Sum256_Avx2_Cmp2	591.620	443.095	5.483665
Sum256Traits	1112.453	235.645	2.916298
SumKernelTraits	647.107	405.101	5.013459
SumKernelTraits_Args0	572.659	457.766	5.665231
SumKernelTraits_Args	754.168	347.594	4.301753
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	1010.158	259.508	3.211622
SumKernel256Traits_Args0	746.207	351.302	4.347646
SumKernel256Traits_Args	786.848	333.157	4.123090
SumKernel256Traits_ArgsX	893.608	293.354	3.630500

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

IsRelease:	False
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
# SumScalar	-24614
SumScalar	2787.258	94.051
SumBase	3386.582	77.407	0.823030
SumTraits	2473.216	105.993	1.126977
SumTraits_Args	1436.954	182.430	1.939698
SumTraitsIf	2281.088	114.921	1.221899
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	529.430	495.143	5.264635
Sum256Traits	3098.736	84.597	0.899482
SumKernelTraits	1916.682	136.770	1.454210
SumKernelTraits_Args	1556.126	168.459	1.791152
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	1060.641	247.156	2.627899
SumKernel256_Avx2_ShiftLane	919.023	285.242	3.032849
SumKernel256Traits	2541.399	103.149	1.096742
SumKernel256Traits_Args0	1673.268	156.666	1.665757
SumKernel256Traits_Args	1921.812	136.405	1.450328
SumKernel256Traits_ArgsX	1646.543	159.209	1.692794

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	6931.497	37.819
SumBase	4729.130	55.432	1.465703
SumTraits	3128.273	83.798	2.215759
SumTraits_Args	2563.590	102.257	2.703824
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	861.936	304.134	8.041780
Sum256Traits	4125.250	63.546	1.680261
SumKernelTraits	2130.014	123.072	3.254203
SumKernelTraits_Args	2199.750	119.170	3.151039
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	3013.245	86.997	2.300343
SumKernel256Traits_Args0	2347.921	111.649	2.952185
SumKernel256Traits_Args	2693.992	97.307	2.572946
SumKernel256Traits_ArgsX	2706.765	96.848	2.560805

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	6241.420	42.001
SumBase	6942.365	37.760	0.899034
SumTraits	8311.859	31.539	0.750905
SumTraits_Args	6023.945	43.517	1.036102
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	1290.491	203.135	4.836469
Sum256Traits	10161.791	25.797	0.614205
SumKernelTraits	5646.499	46.426	1.105361
SumKernelTraits_Args	4416.646	59.354	1.413158
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_AdvSimd_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	2265.330	115.720	2.755192
SumKernel256_Avx2_DuplicateEven	2166.179	121.017	2.881303
SumKernel256_Avx2_Multiply	4737.779	55.331	1.317372
SumKernel256_Avx2_ShiftLane	2004.695	130.765	3.113402
SumKernel256Traits	8139.004	32.208	0.766853
SumKernel256Traits_Args0	5405.837	48.493	1.154570
SumKernel256Traits_Args	6034.321	43.442	1.034320
SumKernel256Traits_ArgsX	5984.466	43.804	1.042937

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	2536.058	103.367
SumBase	2697.163	97.193	0.940269
SumTraits	1043.204	251.287	2.431028
SumTraits_Args0	1061.393	246.981	2.389367
SumTraits_Args	770.834	340.079	3.290020
SumTraitsIf	1085.963	241.393	2.335308
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	555.141	472.212	4.568314
Sum256_Avx2_Add1	626.746	418.262	4.046385
Sum256_Avx2_Add2	856.114	306.202	2.962289
Sum256_Avx2_Cmp2	641.681	408.527	3.952208
Sum256Traits	1439.798	182.070	1.761399
SumKernelTraits	988.408	265.218	2.565800
SumKernelTraits_Args0	796.109	329.282	3.185568
SumKernelTraits_Args	800.907	327.309	3.166483
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	1134.404	231.085	2.235586
SumKernel256Traits_Args0	916.218	286.115	2.767963
SumKernel256Traits_Args	928.761	282.251	2.730582
SumKernel256Traits_ArgsX	755.367	347.042	3.357386

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	611.494	428.694
SumBase	610.860	429.139	1.001038
SumTraits	612.169	428.221	0.998898
SumTraits_Args	649.603	403.545	0.941336
SumTraitsIf	614.013	426.935	0.995898
Sum128Traits	1066.598	245.776	0.573313
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	610.455	429.424	1.001702
SumKernelTraits_Args	647.348	404.950	0.944614
SumKernel128Traits	1066.577	245.781	0.573324
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	902.458	290.478
SumBase	902.620	290.426	0.999821
SumTraits	901.826	290.681	1.000701
SumTraits_Args	970.602	270.084	0.929792
Sum128Traits	1705.465	153.708	0.529157
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	901.921	290.651	1.000595
SumKernelTraits_Args	970.916	269.997	0.929491
SumKernel128Traits	1708.383	153.446	0.528253
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	687.308	381.407
SumBase	689.518	380.185	0.996796
SumTraits	689.822	380.017	0.996356
SumTraits_Args	799.392	327.929	0.859788
Sum128Traits	1658.512	158.060	0.414412
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	1471.949	178.093	0.466937
SumKernelTraits_Args	793.131	330.518	0.866576
SumKernel128Traits	1221.561	214.598	0.562647
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	387.075	677.244
SumBase	386.726	677.854	1.000901
SumTraits	386.203	678.773	1.002257
SumTraits_Args0	397.247	659.901	0.974392
SumTraits_Args	412.164	636.018	0.939127
SumTraitsIf	398.078	658.524	0.972358
Sum128Traits	634.098	413.412	0.610433
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	388.807	674.227	0.995545
SumKernelTraits_Args0	387.810	675.959	0.998103
SumKernelTraits_Args	415.638	630.702	0.931278
SumKernel128Traits	634.184	413.356	0.610350
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	620.653	422.368
SumBase	620.441	422.512	1.000341
SumTraits	66.413	3947.189	9.345371
SumTraits_Args	93.057	2817.035	6.669617
SumTraitsIf	66.211	3959.244	9.373913
Sum128_AdvSimd	99.839	2625.679	6.216562
Sum128Traits	65.825	3982.432	9.428811
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	59.606	4397.982	10.412669
SumKernelTraits_Args	93.054	2817.128	6.669837
SumKernel128_AdvSimd	91.525	2864.191	6.781262
SumKernel128Traits	53.336	4914.954	11.636653
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	932.023	281.263
SumBase	932.101	281.240	0.999916
SumTraits	142.726	1836.693	6.530152
SumTraits_Args	187.356	1399.179	4.974622
Sum128_AdvSimd	205.241	1277.249	4.541113
Sum128Traits	133.871	1958.185	6.962102
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	132.337	1980.877	7.042781
SumKernelTraits_Args	186.187	1407.957	5.005830
SumKernel128_AdvSimd	190.328	1377.328	4.896934
SumKernel128Traits	120.468	2176.053	7.736706
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	594.230	441.149
SumBase	593.972	441.340	1.000433
SumTraits	308.265	850.386	1.927661
SumTraits_Args	371.787	705.092	1.598307
Sum128_AdvSimd	482.669	543.113	1.231132
Sum128Traits	283.506	924.651	2.096006
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	269.113	974.103	2.208104
SumKernelTraits_Args	371.608	705.432	1.599078
SumKernel128_AdvSimd	349.798	749.416	1.698781
SumKernel128_AdvSimd_Multiply	689.891	379.979	0.861339
SumKernel128Traits	264.000	992.971	2.250874
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	395.245	663.245
SumBase	396.144	661.740	0.997731
SumTraits	16.766	15635.033	23.573546
SumTraits_Args0	15.648	16752.295	25.258085
SumTraits_Args	46.595	5626.027	8.482579
SumTraitsIf	19.923	13157.656	19.838308
Sum128_AdvSimd	23.296	11252.733	16.966182
Sum128Traits	15.624	16777.767	25.296490
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	19.916	13162.651	19.845839
SumKernelTraits_Args0	16.641	15752.524	23.750692
SumKernelTraits_Args	46.798	5601.623	8.445785
SumKernel128_AdvSimd	23.281	11259.840	16.976897
SumKernel128Traits	15.611	16792.138	25.318159
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	618.811	423.625
SumBase	618.742	423.673	1.000112
SumTraits	61.315	4275.388	10.092381
SumTraits_Args	93.001	2818.713	6.653789
SumTraitsIf	66.070	3967.668	9.365984
Sum128_AdvSimd	97.448	2690.098	6.350183
Sum128Traits	60.470	4335.109	10.233357
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	53.333	4915.201	11.602708
SumKernelTraits_Args	93.036	2817.669	6.651323
SumKernel128_AdvSimd	93.553	2802.091	6.614552
SumKernel128Traits	53.007	4945.423	11.674050
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	924.535	283.542
SumBase	927.864	282.524	0.996412
SumTraits	132.833	1973.491	6.960149
SumTraits_Args	182.527	1436.191	5.065188
Sum128_AdvSimd	199.672	1312.872	4.630263
Sum128Traits	129.465	2024.828	7.141205
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	120.699	2171.876	7.659816
SumKernelTraits_Args	175.982	1489.608	5.253580
SumKernel128_AdvSimd	189.997	1379.726	4.866046
SumKernel128Traits	123.057	2130.265	7.513063
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	584.751	448.300
SumBase	586.932	446.634	0.996284
SumTraits	290.947	901.004	2.009823
SumTraits_Args	352.529	743.609	1.658732
Sum128_AdvSimd	474.527	552.432	1.232282
Sum128Traits	290.987	900.879	2.009544
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	245.559	1067.540	2.381306
SumKernelTraits_Args	352.492	743.689	1.658908
SumKernel128_AdvSimd	346.691	756.131	1.686663
SumKernel128_AdvSimd_Multiply	704.309	372.200	0.830248
SumKernel128Traits	264.006	992.948	2.214918
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	393.825	665.636
SumBase	397.508	659.468	0.990734
SumTraits	15.602	16802.420	25.242667
SumTraits_Args0	16.626	15766.774	23.686792
SumTraits_Args	44.098	5944.612	8.930729
SumTraitsIf	15.616	16786.394	25.218590
Sum128_AdvSimd	23.283	11258.989	16.914642
Sum128Traits	16.620	15772.353	23.695174
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	15.606	16797.796	25.235720
SumKernelTraits_Args0	16.635	15758.383	23.674186
SumKernelTraits_Args	44.107	5943.303	8.928763
SumKernel128_AdvSimd	22.287	11762.419	17.670956
SumKernel128Traits	15.603	16800.985	25.240511
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	497.264	527.172
SumBase	497.635	526.780	0.999255
SumTraits	62.816	4173.186	7.916169
SumTraits_Args	26.530	9880.960	18.743315
SumTraitsIf	62.935	4165.300	7.901209
Sum128_Bcl	544.491	481.447	0.913264
Sum128_AdvSimd	114.105	2297.395	4.357958
Sum128Traits	62.944	4164.730	7.900128
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	50.400	5201.276	9.866364
SumKernelTraits_Args	26.497	9893.193	18.766521
SumKernel128_AdvSimd	94.844	2763.945	5.242961
SumKernel128Traits	50.407	5200.515	9.864921
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	829.108	316.176
SumBase	825.919	317.397	1.003861
SumTraits	134.135	1954.332	6.181156
SumTraits_Args	54.877	4776.975	15.108604
Sum128_Bcl	864.953	303.073	0.958559
Sum128_AdvSimd	227.391	1152.834	3.646179
Sum128Traits	134.773	1945.075	6.151877
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	116.239	2255.214	7.132785
SumKernelTraits_Args	54.681	4794.104	15.162779
SumKernel128_AdvSimd	194.068	1350.784	4.272255
SumKernel128Traits	116.244	2255.124	7.132500
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	1176.435	222.829
SumBase	476.187	550.507	2.470532
SumTraits	275.951	949.966	4.263202
SumTraits_Args	107.321	2442.621	10.961854
Sum128_Bcl	369.911	708.668	3.180321
Sum128_AdvSimd	510.795	513.208	2.303145
Sum128Traits	276.476	948.162	4.255106
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	244.416	1072.534	4.813255
SumKernelTraits_Args	107.086	2447.984	10.985924
SumKernel128_AdvSimd	393.956	665.414	2.986207
SumKernel128_AdvSimd_Multiply	606.241	432.409	1.940541
SumKernel128Traits	244.702	1071.277	4.807614
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	314.933	832.381
SumBase	314.985	832.243	0.999834
SumTraits	13.263	19765.186	23.745351
SumTraits_Args0	13.268	19757.494	23.736110
SumTraits_Args	13.339	19652.204	23.609617
SumTraitsIf	13.253	19779.977	23.763120
Sum128_Bcl	405.292	646.803	0.777051
Sum128_AdvSimd	19.965	13130.488	15.774606
Sum128Traits	13.249	19785.960	23.770307
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	13.235	19806.687	23.795209
SumKernelTraits_Args0	13.260	19769.040	23.749980
SumKernelTraits_Args	13.269	19755.439	23.733641
SumKernel128_AdvSimd	19.967	13129.169	15.773022
SumKernel128Traits	13.265	19762.352	23.741946
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

