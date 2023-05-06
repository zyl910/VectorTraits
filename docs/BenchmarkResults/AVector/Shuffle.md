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
# SumShuffleScalar	-24614
SumShuffleScalar	364.049	720.079
SumShuffleVectorBase	414.876	631.861	0.877489
SumShuffleVectorTraits	411.968	636.322	0.883684
SumShuffleVectorTraits_Args	419.727	624.559	0.867348
SumShuffleVectorTraitsIf	402.173	651.820	0.905206
SumYShuffleKernelVectorTraits	368.223	711.917	0.988666
SumYShuffleKernelVectorTraits_Args	371.774	705.117	0.979223

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	523.746	500.518
SumShuffleVectorBase	511.049	512.952	1.024844
SumShuffleVectorTraits	499.734	524.567	1.048049
SumShuffleVectorTraits_Args	557.632	470.102	0.939231
SumYShuffleKernelVectorTraits	494.553	530.063	1.059029
SumYShuffleKernelVectorTraits_Args	529.675	494.915	0.988807

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	751.643	348.761
SumShuffleVectorBase	784.108	334.321	0.958597
SumShuffleVectorTraits	706.027	371.295	1.064609
SumShuffleVectorTraits_Args	675.206	388.243	1.113206
SumYShuffleKernelVectorTraits	725.812	361.174	1.035590
SumYShuffleKernelVectorTraits_Args	814.979	321.657	0.922285

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	320.822	817.101
SumShuffleVectorBase	331.632	790.467	0.967403
SumShuffleVectorTraits	317.795	824.883	1.009523
SumShuffleVectorTraits_Args0	306.081	856.454	1.048161
SumShuffleVectorTraits_Args	313.816	835.343	1.022325
SumShuffleVectorTraitsIf	312.701	838.323	1.025972
SumYShuffleKernelVectorTraits	339.209	772.810	0.945794
SumYShuffleKernelVectorTraits_Args0	309.313	847.505	1.037209
SumYShuffleKernelVectorTraits_Args	357.770	732.717	0.896727

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
# SumShuffleScalar	-24614
SumShuffleScalar	361.103	725.953
SumShuffleVectorBase	376.110	696.988	0.960102
SumShuffleVectorTraits	349.464	750.132	1.033307
SumShuffleVectorTraits_Args	350.500	747.914	1.030252
SumShuffleVectorTraitsIf	366.547	715.171	0.985148
SumYShuffleKernelVectorTraits	348.100	753.072	1.037357
SumYShuffleKernelVectorTraits_Args	352.523	743.623	1.024341

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	475.409	551.408
SumShuffleVectorBase	453.673	577.825	1.047909
SumShuffleVectorTraits	457.333	573.201	1.039523
SumShuffleVectorTraits_Args	469.117	558.804	1.013412
SumYShuffleKernelVectorTraits	460.160	569.680	1.033137
SumYShuffleKernelVectorTraits_Args	468.486	559.555	1.014776

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	713.232	367.544
SumShuffleVectorBase	710.738	368.833	1.003509
SumShuffleVectorTraits	713.881	367.210	0.999092
SumShuffleVectorTraits_Args	709.817	369.312	1.004812
SumYShuffleKernelVectorTraits	716.845	365.691	0.994961
SumYShuffleKernelVectorTraits_Args	694.879	377.252	1.026413

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	281.814	930.202
SumShuffleVectorBase	289.014	907.027	0.975086
SumShuffleVectorTraits	286.206	915.927	0.984654
SumShuffleVectorTraits_Args0	320.730	817.335	0.878664
SumShuffleVectorTraits_Args	300.178	873.297	0.938824
SumShuffleVectorTraitsIf	284.303	922.057	0.991244
SumYShuffleKernelVectorTraits	306.214	856.082	0.920318
SumYShuffleKernelVectorTraits_Args0	333.210	786.724	0.845755
SumYShuffleKernelVectorTraits_Args	299.627	874.900	0.940548

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
# SumShuffleScalar	-24614
SumShuffleScalar	262.907	997.098
SumShuffleVectorBase	263.105	996.346	0.999246
SumShuffleVectorTraits	45.156	5805.331	5.822229
SumShuffleVectorTraits_Args0	17.948	14606.083	14.648595
SumShuffleVectorTraits_Args	19.387	13521.406	13.560761
SumShuffleVectorTraitsIf	68.688	3816.440	3.827548
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	43.599	6012.598	6.030098
SumYShuffleKernelVectorTraits	43.886	5973.344	5.990731
SumYShuffleKernelVectorTraits_Args0	18.226	14383.075	14.424938
SumYShuffleKernelVectorTraits_Args	18.258	14358.118	14.399909
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	38.753	6764.431	6.784120
SumYShuffleKernelVector256_Avx2_ShiftLane	33.593	7803.632	7.826346
SumYShuffleKernelVector256Traits	38.555	6799.271	6.819061
SumYShuffleKernelVector256Traits_Args0	17.676	14830.113	14.873278
SumYShuffleKernelVector256Traits_Args	17.408	15058.567	15.102396
SumYShuffleKernelVector256Traits_ArgsX	128.555	2039.162	2.045097

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	362.901	722.358
SumShuffleVectorBase	362.236	723.684	1.001836
SumShuffleVectorTraits	42.446	6176.010	8.549795
SumShuffleVectorTraits_Args0	29.913	8763.472	12.131763
SumShuffleVectorTraits_Args	27.294	9604.380	13.295879
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	42.239	6206.173	8.591552
SumYShuffleKernelVectorTraits	28.096	9330.420	12.916621
SumYShuffleKernelVectorTraits_Args0	21.824	12011.611	16.628343
SumYShuffleKernelVectorTraits_Args	24.740	10595.995	14.668627
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	26.226	9995.668	13.837561
SumYShuffleKernelVector256Traits_Args0	25.277	10370.786	14.356857
SumYShuffleKernelVector256Traits_Args	23.656	11081.446	15.340664
SumYShuffleKernelVector256Traits_ArgsX	253.557	1033.867	1.431240

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	569.518	460.291
SumShuffleVectorBase	569.228	460.525	1.000508
SumShuffleVectorTraits	131.095	1999.653	4.344323
SumShuffleVectorTraits_Args0	56.369	4650.494	10.103375
SumShuffleVectorTraits_Args	60.100	4361.796	9.476168
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	132.299	1981.453	4.304782
SumYShuffleKernelVectorTraits	89.254	2937.057	6.380869
SumYShuffleKernelVectorTraits_Args0	50.778	5162.581	11.215904
SumYShuffleKernelVectorTraits_Args	48.524	5402.320	11.736745
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	80.508	3256.140	7.074089
SumYShuffleKernelVector256_Avx2_DuplicateEven	75.727	3461.710	7.520697
SumYShuffleKernelVector256_Avx2_Multiply	140.388	1867.284	4.056746
SumYShuffleKernelVector256_Avx2_ShiftLane	72.297	3625.927	7.877464
SumYShuffleKernelVector256Traits	67.214	3900.134	8.473191
SumYShuffleKernelVector256Traits_Args0	44.484	5893.010	12.802790
SumYShuffleKernelVector256Traits_Args	47.057	5570.782	12.102737
SumYShuffleKernelVector256Traits_ArgsX	511.025	512.977	1.114461

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	207.305	1264.532
SumShuffleVectorBase	207.557	1262.998	0.998786
SumShuffleVectorTraits	16.631	15762.480	12.465065
SumShuffleVectorTraits_Args0	8.175	32067.314	25.359028
SumShuffleVectorTraits_Args	8.606	30462.230	24.089718
SumShuffleVectorTraitsIf	19.031	13774.305	10.892804
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	21.731	12063.155	9.539617
SumShuffleVector256_Avx2_Add2	21.126	12408.348	9.812598
SumShuffleVector256_Avx2_Cmp2	17.294	15158.510	11.987443
SumShuffleVector256Traits	16.099	16283.347	12.876971
SumYShuffleKernelVectorTraits	11.899	22030.037	17.421488
SumYShuffleKernelVectorTraits_Args0	7.928	33065.867	26.148689
SumYShuffleKernelVectorTraits_Args	8.132	32235.275	25.491852
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	13.047	20092.777	15.889491
SumYShuffleKernelVector256Traits_Args0	8.039	32607.519	25.786225
SumYShuffleKernelVector256Traits_Args	8.066	32500.530	25.701618
SumYShuffleKernelVector256Traits_ArgsX	63.869	4104.390	3.245776

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
# SumShuffleScalar	-24614
SumShuffleScalar	252.470	1038.318
SumShuffleVectorBase	258.626	1013.601	0.976195
SumShuffleVectorTraits	34.993	7491.359	7.214898
SumShuffleVectorTraits_Args0	17.985	14576.049	14.038135
SumShuffleVectorTraits_Args	17.946	14607.777	14.068692
SumShuffleVectorTraitsIf	34.733	7547.353	7.268826
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	31.743	8258.416	7.953648
SumYShuffleKernelVectorTraits	36.156	7250.349	6.982783
SumYShuffleKernelVectorTraits_Args0	26.064	10057.707	9.686538
SumYShuffleKernelVectorTraits_Args	22.933	11430.687	11.008849
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	31.281	8380.172	8.070910
SumYShuffleKernelVector256_Avx2_ShiftLane	32.941	7957.966	7.664286
SumYShuffleKernelVector256Traits	31.161	8412.448	8.101995
SumYShuffleKernelVector256Traits_Args0	22.609	11594.590	11.166704
SumYShuffleKernelVector256Traits_Args	23.404	11200.827	10.787473
SumYShuffleKernelVector256Traits_ArgsX	156.681	1673.109	1.611365

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	454.162	577.204
SumShuffleVectorBase	456.324	574.469	0.995261
SumShuffleVectorTraits	48.300	5427.460	9.403018
SumShuffleVectorTraits_Args0	35.627	7357.980	12.747624
SumShuffleVectorTraits_Args	35.395	7406.156	12.831089
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	48.698	5383.075	9.326121
SumYShuffleKernelVectorTraits	47.182	5556.061	9.625818
SumYShuffleKernelVectorTraits_Args0	31.661	8279.644	14.344398
SumYShuffleKernelVectorTraits_Args	29.362	8928.002	15.467671
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	33.825	7750.064	13.426906
SumYShuffleKernelVector256Traits_Args0	33.760	7764.983	13.452752
SumYShuffleKernelVector256Traits_Args	30.114	8705.145	15.081574
SumYShuffleKernelVector256Traits_ArgsX	292.466	896.322	1.552868

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	614.701	426.458
SumShuffleVectorBase	629.337	416.540	0.976744
SumShuffleVectorTraits	110.075	2381.507	5.584391
SumShuffleVectorTraits_Args0	59.795	4384.031	10.280104
SumShuffleVectorTraits_Args	57.067	4593.616	10.771561
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	81.454	3218.301	7.546586
SumYShuffleKernelVectorTraits	76.032	3447.827	8.084802
SumYShuffleKernelVectorTraits_Args0	96.024	2729.978	6.401519
SumYShuffleKernelVectorTraits_Args	183.872	1425.688	3.343093
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	256.806	1020.785	2.393637
SumYShuffleKernelVector256_Avx2_DuplicateEven	227.831	1150.608	2.698059
SumYShuffleKernelVector256_Avx2_Multiply	354.598	739.271	1.733515
SumYShuffleKernelVector256_Avx2_ShiftLane	216.800	1209.153	2.835340
SumYShuffleKernelVector256Traits	211.740	1238.045	2.903090
SumYShuffleKernelVector256Traits_Args0	172.538	1519.337	3.562690
SumYShuffleKernelVector256Traits_Args	87.382	2999.994	7.034679
SumYShuffleKernelVector256Traits_ArgsX	597.528	438.714	1.028740

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	253.612	1033.644
SumShuffleVectorBase	299.581	875.035	0.846553
SumShuffleVectorTraits	14.433	18162.685	17.571511
SumShuffleVectorTraits_Args0	17.068	15358.617	14.858712
SumShuffleVectorTraits_Args	22.013	11908.439	11.520833
SumShuffleVectorTraitsIf	32.598	8041.771	7.780021
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	27.584	9503.509	9.194182
SumShuffleVector256_Avx2_Add2	35.533	7377.398	7.137272
SumShuffleVector256_Avx2_Cmp2	34.497	7599.087	7.351745
SumShuffleVector256Traits	32.750	8004.509	7.743972
SumYShuffleKernelVectorTraits	14.815	17694.421	17.118488
SumYShuffleKernelVectorTraits_Args0	9.060	28934.962	27.993163
SumYShuffleKernelVectorTraits_Args	9.999	26218.025	25.364659
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	9.747	26893.503	26.018151
SumYShuffleKernelVector256Traits_Args0	8.290	31621.715	30.592466
SumYShuffleKernelVector256Traits_Args	8.324	31491.239	30.466237
SumYShuffleKernelVector256Traits_ArgsX	64.593	4058.422	3.926326

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
# SumShuffleScalar	-24614
SumShuffleScalar	258.355	1014.668
SumShuffleVectorBase	253.517	1034.029	1.019082
SumShuffleVectorTraits	31.693	8271.430	8.151862
SumShuffleVectorTraits_Args0	17.668	14837.099	14.622620
SumShuffleVectorTraits_Args	18.542	14137.636	13.933269
SumShuffleVectorTraitsIf	31.632	8287.270	8.167473
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	25.467	10293.349	10.144553
SumYShuffleKernelVectorTraits	25.329	10349.645	10.200035
SumYShuffleKernelVectorTraits_Args0	17.616	14881.062	14.665948
SumYShuffleKernelVectorTraits_Args	17.560	14928.310	14.712513
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	23.231	11284.332	11.121211
SumYShuffleKernelVector256_Avx2_ShiftLane	24.650	10634.506	10.480778
SumYShuffleKernelVector256Traits	24.153	10853.302	10.696411
SumYShuffleKernelVector256Traits_Args0	17.704	14806.920	14.592878
SumYShuffleKernelVector256Traits_Args	18.020	14547.525	14.337233
SumYShuffleKernelVector256Traits_ArgsX	128.162	2045.418	2.015850

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	365.822	716.588
SumShuffleVectorBase	357.531	733.207	1.023192
SumShuffleVectorTraits	38.137	6873.807	9.592411
SumShuffleVectorTraits_Args0	28.205	9294.214	12.970093
SumShuffleVectorTraits_Args	28.571	9175.206	12.804018
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	28.128	9319.675	13.005625
SumYShuffleKernelVectorTraits	36.056	7270.519	10.146024
SumYShuffleKernelVectorTraits_Args0	23.536	11137.931	15.543004
SumYShuffleKernelVectorTraits_Args	23.538	11137.169	15.541941
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	23.226	11286.420	15.750221
SumYShuffleKernelVector256Traits_Args0	23.564	11124.741	15.524598
SumYShuffleKernelVector256Traits_Args	23.193	11302.782	15.773055
SumYShuffleKernelVector256Traits_ArgsX	237.331	1104.549	1.541400

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	571.895	458.377
SumShuffleVectorBase	575.098	455.825	0.994431
SumShuffleVectorTraits	89.745	2920.982	6.372437
SumShuffleVectorTraits_Args0	57.449	4563.045	9.954775
SumShuffleVectorTraits_Args	58.764	4460.943	9.732029
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	79.881	3281.700	7.159382
SumYShuffleKernelVectorTraits	78.075	3357.595	7.324956
SumYShuffleKernelVectorTraits_Args0	47.944	5467.686	11.928348
SumYShuffleKernelVectorTraits_Args	48.069	5453.472	11.897337
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	76.119	3443.886	7.513209
SumYShuffleKernelVector256_Avx2_DuplicateEven	74.343	3526.151	7.692680
SumYShuffleKernelVector256_Avx2_Multiply	108.340	2419.636	5.278697
SumYShuffleKernelVector256_Avx2_ShiftLane	73.629	3560.318	7.767217
SumYShuffleKernelVector256Traits	75.387	3477.316	7.586140
SumYShuffleKernelVector256Traits_Args0	47.392	5531.378	12.067298
SumYShuffleKernelVector256Traits_Args	48.329	5424.111	11.833284
SumYShuffleKernelVector256Traits_ArgsX	468.306	559.771	1.221200

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	207.998	1260.323
SumShuffleVectorBase	210.969	1242.573	0.985917
SumShuffleVectorTraits	14.964	17517.846	13.899491
SumShuffleVectorTraits_Args0	10.917	24012.558	19.052705
SumShuffleVectorTraits_Args	9.755	26872.655	21.322042
SumShuffleVectorTraitsIf	13.926	18823.589	14.935530
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	11.856	22110.432	17.543468
SumShuffleVector256_Avx2_Add2	13.024	20128.258	15.970716
SumShuffleVector256_Avx2_Cmp2	12.359	21211.358	16.830100
SumShuffleVector256Traits	11.234	23335.219	18.515272
SumYShuffleKernelVectorTraits	11.051	23721.070	18.821424
SumYShuffleKernelVectorTraits_Args0	8.147	32176.997	25.530759
SumYShuffleKernelVectorTraits_Args	8.095	32382.982	25.694197
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	10.255	25561.386	20.281619
SumYShuffleKernelVector256Traits_Args0	8.483	30900.802	24.518165
SumYShuffleKernelVector256Traits_Args	8.986	29171.548	23.146092
SumYShuffleKernelVector256Traits_ArgsX	67.763	3868.532	3.069477

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
# SumShuffleScalar	-24614
SumShuffleScalar	259.120	1011.669
SumShuffleVectorBase	264.498	991.100	0.979668
SumShuffleVectorTraits	27.440	9553.329	9.443134
SumShuffleVectorTraits_Args0	17.726	14788.700	14.618117
SumShuffleVectorTraits_Args	17.813	14716.528	14.546778
SumShuffleVectorTraitsIf	30.328	8643.627	8.543925
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	330.143	794.033	0.784874
SumShuffleVector256Traits	21.590	12142.193	12.002137
SumYShuffleKernelVectorTraits	23.391	11206.857	11.077589
SumYShuffleKernelVectorTraits_Args0	17.459	15015.118	14.841923
SumYShuffleKernelVectorTraits_Args	17.515	14966.546	14.793912
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	18.510	14162.179	13.998822
SumYShuffleKernelVector256_Avx2_ShiftLane	23.667	11076.430	10.948667
SumYShuffleKernelVector256Traits	18.138	14453.036	14.286325
SumYShuffleKernelVector256Traits_Args0	17.426	15043.252	14.869733
SumYShuffleKernelVector256Traits_Args	17.379	15083.883	14.909895
SumYShuffleKernelVector256Traits_ArgsX	17.933	14618.033	14.449419

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	349.359	750.356
SumShuffleVectorBase	352.548	743.569	0.990955
SumShuffleVectorTraits	27.538	9519.410	12.686523
SumShuffleVectorTraits_Args0	26.773	9791.304	13.048877
SumShuffleVectorTraits_Args	26.813	9776.854	13.029619
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	426.475	614.676	0.819179
SumShuffleVector256Traits	28.380	9237.060	12.310235
SumYShuffleKernelVectorTraits	25.067	10457.540	13.936770
SumYShuffleKernelVectorTraits_Args0	23.455	11176.260	14.894608
SumYShuffleKernelVectorTraits_Args	22.825	11485.041	15.306121
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	23.663	11078.177	14.763894
SumYShuffleKernelVector256Traits_Args0	25.842	10144.182	13.519158
SumYShuffleKernelVector256Traits_Args	25.596	10241.528	13.648890
SumYShuffleKernelVector256Traits_ArgsX	29.706	8824.616	11.760571

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	571.309	458.848
SumShuffleVectorBase	565.736	463.368	1.009851
SumShuffleVectorTraits	91.053	2879.034	6.274485
SumShuffleVectorTraits_Args0	58.400	4488.774	9.782708
SumShuffleVectorTraits_Args	58.022	4518.036	9.846481
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	510.621	513.383	1.118852
SumShuffleVector256Traits	60.588	4326.683	9.429451
SumYShuffleKernelVectorTraits	64.498	4064.386	8.857808
SumYShuffleKernelVectorTraits_Args0	52.091	5032.398	10.967467
SumYShuffleKernelVectorTraits_Args	47.306	5541.460	12.076902
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	66.689	3930.841	8.566764
SumYShuffleKernelVector256_Avx2_DuplicateEven	59.095	4435.995	9.667683
SumYShuffleKernelVector256_Avx2_Multiply	115.173	2276.095	4.960456
SumYShuffleKernelVector256_Avx2_ShiftLane	57.217	4581.583	9.984972
SumYShuffleKernelVector256Traits	54.916	4773.548	10.403337
SumYShuffleKernelVector256Traits_Args0	47.752	5489.694	11.964085
SumYShuffleKernelVector256Traits_Args	47.457	5523.807	12.038428
SumYShuffleKernelVector256Traits_ArgsX	74.516	3517.946	7.666913

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	206.230	1271.125
SumShuffleVectorBase	206.283	1270.797	0.999742
SumShuffleVectorTraits	10.826	24214.904	19.049973
SumShuffleVectorTraits_Args0	7.682	34123.811	26.845354
SumShuffleVectorTraits_Args	7.725	33932.407	26.694776
SumShuffleVectorTraitsIf	12.074	21711.000	17.080140
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	280.563	934.351	0.735058
SumShuffleVector256_Avx2_Add1	9.959	26322.452	20.707990
SumShuffleVector256_Avx2_Add2	11.400	22995.240	18.090457
SumShuffleVector256_Avx2_Cmp2	9.991	26239.050	20.642377
SumShuffleVector256Traits	7.998	32777.740	25.786394
SumYShuffleKernelVectorTraits	8.353	31384.489	24.690317
SumYShuffleKernelVectorTraits_Args0	8.002	32760.252	25.772636
SumYShuffleKernelVectorTraits_Args	7.813	33554.340	26.397349
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	7.715	33977.554	26.730293
SumYShuffleKernelVector256Traits_Args0	7.912	33131.863	26.064984
SumYShuffleKernelVector256Traits_Args	7.759	33784.439	26.578368
SumYShuffleKernelVector256Traits_ArgsX	8.345	31412.990	24.712739

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
# SumShuffleScalar	-24614
SumShuffleScalar	3187.620	82.238
SumShuffleVectorBase	3414.460	76.775	0.933565
SumShuffleVectorTraits	3615.382	72.508	0.881683
SumShuffleVectorTraits_Args	4088.393	64.119	0.779676
SumShuffleVectorTraitsIf	3516.412	74.549	0.906498
SumYShuffleKernelVectorTraits	3794.537	69.085	0.840055
SumYShuffleKernelVectorTraits_Args	4262.082	61.506	0.747902

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	4478.182	58.538
SumShuffleVectorBase	4863.120	53.904	0.920845
SumShuffleVectorTraits	5270.370	49.739	0.849690
SumShuffleVectorTraits_Args	6254.281	41.914	0.716019
SumYShuffleKernelVectorTraits	5690.629	46.066	0.786940
SumYShuffleKernelVectorTraits_Args	6662.572	39.346	0.672140

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	7398.816	35.431
SumShuffleVectorBase	8296.050	31.599	0.891848
SumShuffleVectorTraits	9095.770	28.820	0.813435
SumShuffleVectorTraits_Args	11080.976	23.657	0.667704
SumYShuffleKernelVectorTraits	9861.740	26.582	0.750255
SumYShuffleKernelVectorTraits_Args	11764.165	22.283	0.628928

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	2389.155	109.722
SumShuffleVectorBase	2482.882	105.581	0.962251
SumShuffleVectorTraits	2582.314	101.515	0.925199
SumShuffleVectorTraits_Args0	2702.396	97.004	0.884088
SumShuffleVectorTraits_Args	2819.974	92.960	0.847226
SumShuffleVectorTraitsIf	2519.513	104.045	0.948260
SumYShuffleKernelVectorTraits	2687.743	97.533	0.888907
SumYShuffleKernelVectorTraits_Args0	2808.365	93.344	0.850728
SumYShuffleKernelVectorTraits_Args	2917.298	89.858	0.818961

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
# SumShuffleScalar	-24614
SumShuffleScalar	4491.798	58.361
SumShuffleVectorBase	4543.233	57.700	0.988679
SumShuffleVectorTraits	4754.390	55.137	0.944769
SumShuffleVectorTraits_Args	5521.839	47.474	0.813461
SumShuffleVectorTraitsIf	4540.311	57.737	0.989315
SumYShuffleKernelVectorTraits	5060.926	51.798	0.887545
SumYShuffleKernelVectorTraits_Args	5711.174	45.900	0.786493

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	6114.802	42.870
SumShuffleVectorBase	6694.475	39.158	0.913410
SumShuffleVectorTraits	7279.529	36.011	0.840000
SumShuffleVectorTraits_Args	8369.761	31.320	0.730583
SumYShuffleKernelVectorTraits	7578.830	34.589	0.806827
SumYShuffleKernelVectorTraits_Args	9032.710	29.022	0.676962

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	9984.363	26.255
SumShuffleVectorBase	11209.057	23.387	0.890741
SumShuffleVectorTraits	12067.927	21.722	0.827347
SumShuffleVectorTraits_Args	14755.641	17.766	0.676647
SumYShuffleKernelVectorTraits	12873.776	20.363	0.775558
SumYShuffleKernelVectorTraits_Args	17284.581	15.166	0.577646

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	3608.444	72.647
SumShuffleVectorBase	3632.204	72.172	0.993459
SumShuffleVectorTraits	3703.495	70.783	0.974335
SumShuffleVectorTraits_Args0	3920.343	66.868	0.920441
SumShuffleVectorTraits_Args	3918.909	66.892	0.920778
SumShuffleVectorTraitsIf	3712.279	70.615	0.972029
SumYShuffleKernelVectorTraits	3903.608	67.154	0.924387
SumYShuffleKernelVectorTraits_Args0	4101.343	63.917	0.879820
SumYShuffleKernelVectorTraits_Args	4065.897	64.474	0.887490

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
# SumShuffleScalar	-24614
SumShuffleScalar	4479.058	58.527
SumShuffleVectorBase	4611.496	56.846	0.971281
SumShuffleVectorTraits	3922.071	66.838	1.142013
SumShuffleVectorTraits_Args	3819.500	68.633	1.172682
SumShuffleVectorTraitsIf	4699.095	55.786	0.953175
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	3304.974	79.318	1.355248
SumYShuffleKernelVectorTraits	3405.680	76.973	1.315173
SumYShuffleKernelVectorTraits_Args	3690.256	71.037	1.213753
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	1203.338	217.847	3.722195
SumYShuffleKernelVector256_Avx2_ShiftLane	1049.932	249.677	4.266048
SumYShuffleKernelVector256Traits	2700.502	97.072	1.658602
SumYShuffleKernelVector256Traits_Args0	1852.122	141.537	2.418339
SumYShuffleKernelVector256Traits_Args	2289.409	114.503	1.956425
SumYShuffleKernelVector256Traits_ArgsX	2040.146	128.493	2.195459

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	5675.411	46.189
SumShuffleVectorBase	5347.569	49.021	1.061307
SumShuffleVectorTraits	6916.693	37.900	0.820538
SumShuffleVectorTraits_Args	7271.279	36.052	0.780524
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	4105.668	63.849	1.382336
SumYShuffleKernelVectorTraits	5069.946	51.705	1.119422
SumYShuffleKernelVectorTraits_Args	6090.297	43.043	0.931878
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	2402.556	109.110	2.362239
SumYShuffleKernelVector256Traits_Args0	3383.797	77.470	1.677232
SumYShuffleKernelVector256Traits_Args	3536.218	74.131	1.604938
SumYShuffleKernelVector256Traits_ArgsX	3630.973	72.197	1.563055

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	8302.264	31.575
SumShuffleVectorBase	8213.200	31.917	1.010844
SumShuffleVectorTraits	13419.624	19.534	0.618666
SumShuffleVectorTraits_Args	14535.873	18.034	0.571157
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	9140.941	28.678	0.908250
SumYShuffleKernelVectorTraits	11252.104	23.297	0.737841
SumYShuffleKernelVectorTraits_Args	12340.534	21.243	0.672764
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	2704.404	96.932	3.069905
SumYShuffleKernelVector256_Avx2_DuplicateEven	2661.071	98.511	3.119895
SumYShuffleKernelVector256_Avx2_Multiply	8175.939	32.063	1.015451
SumYShuffleKernelVector256_Avx2_ShiftLane	3010.419	87.079	2.757843
SumYShuffleKernelVector256Traits	8597.283	30.491	0.965685
SumYShuffleKernelVector256Traits_Args0	5984.397	43.805	1.387318
SumYShuffleKernelVector256Traits_Args	7460.451	35.138	1.112837
SumYShuffleKernelVector256Traits_ArgsX	7411.221	35.371	1.120229

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	3111.142	84.260
SumShuffleVectorBase	3115.156	84.151	0.998712
SumShuffleVectorTraits	1731.107	151.431	1.797198
SumShuffleVectorTraits_Args0	1771.971	147.939	1.755752
SumShuffleVectorTraits_Args	1831.607	143.122	1.698586
SumShuffleVectorTraitsIf	1910.871	137.186	1.628128
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	604.187	433.879	5.149302
SumShuffleVector256_Avx2_Add2	876.580	299.053	3.549182
SumShuffleVector256_Avx2_Cmp2	644.942	406.462	4.823914
SumShuffleVector256Traits	1210.058	216.638	2.571070
SumYShuffleKernelVectorTraits	1520.943	172.356	2.045535
SumYShuffleKernelVectorTraits_Args0	1818.604	144.146	1.710731
SumYShuffleKernelVectorTraits_Args	1818.013	144.193	1.711287
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	971.749	269.765	3.201591
SumYShuffleKernelVector256Traits_Args0	838.177	312.755	3.711798
SumYShuffleKernelVector256Traits_Args	921.409	284.503	3.376506
SumYShuffleKernelVector256Traits_ArgsX	890.979	294.220	3.491825

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
# SumShuffleScalar	-24614
SumShuffleScalar	3659.446	71.635
SumShuffleVectorBase	4156.109	63.074	0.880498
SumShuffleVectorTraits	2605.297	100.620	1.404617
SumShuffleVectorTraits_Args	1895.233	138.318	1.930869
SumShuffleVectorTraitsIf	2606.960	100.555	1.403721
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	2545.968	102.964	1.437350
SumYShuffleKernelVectorTraits	2126.156	123.295	1.721156
SumYShuffleKernelVectorTraits_Args	1901.477	137.863	1.924528
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	1277.449	205.209	2.864650
SumYShuffleKernelVector256_Avx2_ShiftLane	1254.164	209.019	2.917838
SumYShuffleKernelVector256Traits	2220.467	118.058	1.648052
SumYShuffleKernelVector256Traits_Args0	1803.249	145.373	2.029363
SumYShuffleKernelVector256Traits_Args	1963.836	133.486	1.863417
SumYShuffleKernelVector256Traits_ArgsX	2001.314	130.986	1.828522

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	4869.898	53.829
SumShuffleVectorBase	5060.029	51.807	0.962425
SumShuffleVectorTraits	3025.435	86.647	1.609653
SumShuffleVectorTraits_Args	3063.728	85.564	1.589534
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	3690.144	71.039	1.319704
SumYShuffleKernelVectorTraits	1918.563	136.636	2.538305
SumYShuffleKernelVectorTraits_Args	2832.623	92.545	1.719219
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	2428.839	107.930	2.005031
SumYShuffleKernelVector256Traits_Args0	2932.497	89.393	1.660666
SumYShuffleKernelVector256Traits_Args	3191.248	82.145	1.526017
SumYShuffleKernelVector256Traits_ArgsX	3259.118	80.434	1.494238

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	7077.051	37.041
SumShuffleVectorBase	8673.831	30.222	0.815908
SumShuffleVectorTraits	7464.542	35.119	0.948089
SumShuffleVectorTraits_Args	6702.249	39.113	1.055922
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	9496.496	27.604	0.745228
SumYShuffleKernelVectorTraits	6803.024	38.533	1.040280
SumYShuffleKernelVectorTraits_Args	6344.770	41.317	1.115415
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	3324.865	78.843	2.128523
SumYShuffleKernelVector256_Avx2_DuplicateEven	3380.308	77.550	2.093611
SumYShuffleKernelVector256_Avx2_Multiply	6513.509	40.246	1.086519
SumYShuffleKernelVector256_Avx2_ShiftLane	3228.741	81.191	2.191892
SumYShuffleKernelVector256Traits	7230.816	36.254	0.978735
SumYShuffleKernelVector256Traits_Args0	5960.993	43.977	1.187227
SumYShuffleKernelVector256Traits_Args	6627.594	39.553	1.067816
SumYShuffleKernelVector256Traits_ArgsX	6006.490	43.643	1.178234

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	3294.127	79.579
SumShuffleVectorBase	2954.426	88.729	1.114980
SumShuffleVectorTraits	1030.290	254.437	3.197280
SumShuffleVectorTraits_Args0	635.962	412.201	5.179756
SumShuffleVectorTraits_Args	779.519	336.289	4.225843
SumShuffleVectorTraitsIf	1179.966	222.162	2.791714
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	658.782	397.922	5.000326
SumShuffleVector256_Avx2_Add2	813.638	322.188	4.048641
SumShuffleVector256_Avx2_Cmp2	784.775	334.037	4.197544
SumShuffleVector256Traits	1518.394	172.646	2.169480
SumYShuffleKernelVectorTraits	910.236	287.996	3.618983
SumYShuffleKernelVectorTraits_Args0	784.636	334.096	4.198285
SumYShuffleKernelVectorTraits_Args	883.418	296.738	3.728842
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	991.568	264.373	3.322139
SumYShuffleKernelVector256Traits_Args0	796.369	329.174	4.136431
SumYShuffleKernelVector256Traits_Args	906.205	289.277	3.635080
SumYShuffleKernelVector256Traits_ArgsX	906.825	289.079	3.632594

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
# SumShuffleScalar	-24614
SumShuffleScalar	3983.320	65.810
SumShuffleVectorBase	4301.353	60.945	0.926062
SumShuffleVectorTraits	2527.111	103.733	1.576235
SumShuffleVectorTraits_Args	1947.288	134.620	2.045573
SumShuffleVectorTraitsIf	2621.263	100.007	1.519619
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	3278.303	79.963	1.215055
SumYShuffleKernelVectorTraits	2278.241	115.064	1.748419
SumYShuffleKernelVectorTraits_Args	1964.366	133.450	2.027790
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	1521.159	172.332	2.618609
SumYShuffleKernelVector256_Avx2_ShiftLane	1551.875	168.921	2.566780
SumYShuffleKernelVector256Traits	2550.463	102.783	1.561803
SumYShuffleKernelVector256Traits_Args0	1725.574	151.917	2.308402
SumYShuffleKernelVector256Traits_Args	1747.015	150.053	2.280072
SumYShuffleKernelVector256Traits_ArgsX	2020.983	129.711	1.970982

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	5558.443	47.161
SumShuffleVectorBase	5207.476	50.340	1.067397
SumShuffleVectorTraits	2897.688	90.467	1.918234
SumShuffleVectorTraits_Args	3166.130	82.796	1.755595
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	3769.495	69.544	1.474585
SumYShuffleKernelVectorTraits	1635.267	160.306	3.399103
SumYShuffleKernelVectorTraits_Args	3063.181	85.579	1.814598
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	2270.328	115.465	2.448300
SumYShuffleKernelVector256Traits_Args0	2760.348	94.968	2.013675
SumYShuffleKernelVector256Traits_Args	3138.839	83.516	1.770859
SumYShuffleKernelVector256Traits_ArgsX	3100.279	84.555	1.792884

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	7259.248	36.112
SumShuffleVectorBase	7650.651	34.264	0.948841
SumShuffleVectorTraits	6964.601	37.639	1.042306
SumShuffleVectorTraits_Args	6271.435	41.800	1.157510
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	9703.593	27.015	0.748099
SumYShuffleKernelVectorTraits	6014.187	43.588	1.207021
SumYShuffleKernelVectorTraits_Args	6090.595	43.041	1.191878
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	3838.350	68.296	1.891242
SumYShuffleKernelVector256_Avx2_DuplicateEven	3898.068	67.250	1.862268
SumYShuffleKernelVector256_Avx2_Multiply	5951.690	44.045	1.219695
SumYShuffleKernelVector256_Avx2_ShiftLane	3950.675	66.354	1.837470
SumYShuffleKernelVector256Traits	7361.169	35.612	0.986154
SumYShuffleKernelVector256Traits_Args0	5610.795	46.721	1.293800
SumYShuffleKernelVector256Traits_Args	6270.597	41.805	1.157664
SumYShuffleKernelVector256Traits_ArgsX	5767.491	45.452	1.258649

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	3244.245	80.803
SumShuffleVectorBase	3338.599	78.519	0.971738
SumShuffleVectorTraits	881.727	297.307	3.679419
SumShuffleVectorTraits_Args0	740.103	354.199	4.383506
SumShuffleVectorTraits_Args	931.447	281.437	3.483016
SumShuffleVectorTraitsIf	981.226	267.160	3.306317
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	563.724	465.022	5.755020
SumShuffleVector256_Avx2_Add2	751.966	348.611	4.314349
SumShuffleVector256_Avx2_Cmp2	591.620	443.095	5.483665
SumShuffleVector256Traits	1112.453	235.645	2.916298
SumYShuffleKernelVectorTraits	647.107	405.101	5.013459
SumYShuffleKernelVectorTraits_Args0	572.659	457.766	5.665231
SumYShuffleKernelVectorTraits_Args	754.168	347.594	4.301753
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	1010.158	259.508	3.211622
SumYShuffleKernelVector256Traits_Args0	746.207	351.302	4.347646
SumYShuffleKernelVector256Traits_Args	786.848	333.157	4.123090
SumYShuffleKernelVector256Traits_ArgsX	893.608	293.354	3.630500

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
# SumShuffleScalar	-24614
SumShuffleScalar	2787.258	94.051
SumShuffleVectorBase	3386.582	77.407	0.823030
SumShuffleVectorTraits	2473.216	105.993	1.126977
SumShuffleVectorTraits_Args	1436.954	182.430	1.939698
SumShuffleVectorTraitsIf	2281.088	114.921	1.221899
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	529.430	495.143	5.264635
SumShuffleVector256Traits	3098.736	84.597	0.899482
SumYShuffleKernelVectorTraits	1916.682	136.770	1.454210
SumYShuffleKernelVectorTraits_Args	1556.126	168.459	1.791152
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	1060.641	247.156	2.627899
SumYShuffleKernelVector256_Avx2_ShiftLane	919.023	285.242	3.032849
SumYShuffleKernelVector256Traits	2541.399	103.149	1.096742
SumYShuffleKernelVector256Traits_Args0	1673.268	156.666	1.665757
SumYShuffleKernelVector256Traits_Args	1921.812	136.405	1.450328
SumYShuffleKernelVector256Traits_ArgsX	1646.543	159.209	1.692794

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	6931.497	37.819
SumShuffleVectorBase	4729.130	55.432	1.465703
SumShuffleVectorTraits	3128.273	83.798	2.215759
SumShuffleVectorTraits_Args	2563.590	102.257	2.703824
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	861.936	304.134	8.041780
SumShuffleVector256Traits	4125.250	63.546	1.680261
SumYShuffleKernelVectorTraits	2130.014	123.072	3.254203
SumYShuffleKernelVectorTraits_Args	2199.750	119.170	3.151039
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	3013.245	86.997	2.300343
SumYShuffleKernelVector256Traits_Args0	2347.921	111.649	2.952185
SumYShuffleKernelVector256Traits_Args	2693.992	97.307	2.572946
SumYShuffleKernelVector256Traits_ArgsX	2706.765	96.848	2.560805

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	6241.420	42.001
SumShuffleVectorBase	6942.365	37.760	0.899034
SumShuffleVectorTraits	8311.859	31.539	0.750905
SumShuffleVectorTraits_Args	6023.945	43.517	1.036102
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	1290.491	203.135	4.836469
SumShuffleVector256Traits	10161.791	25.797	0.614205
SumYShuffleKernelVectorTraits	5646.499	46.426	1.105361
SumYShuffleKernelVectorTraits_Args	4416.646	59.354	1.413158
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	2265.330	115.720	2.755192
SumYShuffleKernelVector256_Avx2_DuplicateEven	2166.179	121.017	2.881303
SumYShuffleKernelVector256_Avx2_Multiply	4737.779	55.331	1.317372
SumYShuffleKernelVector256_Avx2_ShiftLane	2004.695	130.765	3.113402
SumYShuffleKernelVector256Traits	8139.004	32.208	0.766853
SumYShuffleKernelVector256Traits_Args0	5405.837	48.493	1.154570
SumYShuffleKernelVector256Traits_Args	6034.321	43.442	1.034320
SumYShuffleKernelVector256Traits_ArgsX	5984.466	43.804	1.042937

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	2536.058	103.367
SumShuffleVectorBase	2697.163	97.193	0.940269
SumShuffleVectorTraits	1043.204	251.287	2.431028
SumShuffleVectorTraits_Args0	1061.393	246.981	2.389367
SumShuffleVectorTraits_Args	770.834	340.079	3.290020
SumShuffleVectorTraitsIf	1085.963	241.393	2.335308
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	555.141	472.212	4.568314
SumShuffleVector256_Avx2_Add1	626.746	418.262	4.046385
SumShuffleVector256_Avx2_Add2	856.114	306.202	2.962289
SumShuffleVector256_Avx2_Cmp2	641.681	408.527	3.952208
SumShuffleVector256Traits	1439.798	182.070	1.761399
SumYShuffleKernelVectorTraits	988.408	265.218	2.565800
SumYShuffleKernelVectorTraits_Args0	796.109	329.282	3.185568
SumYShuffleKernelVectorTraits_Args	800.907	327.309	3.166483
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	1134.404	231.085	2.235586
SumYShuffleKernelVector256Traits_Args0	916.218	286.115	2.767963
SumYShuffleKernelVector256Traits_Args	928.761	282.251	2.730582
SumYShuffleKernelVector256Traits_ArgsX	755.367	347.042	3.357386

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
# SumShuffleScalar	-24614
SumShuffleScalar	611.494	428.694
SumShuffleVectorBase	610.860	429.139	1.001038
SumShuffleVectorTraits	612.169	428.221	0.998898
SumShuffleVectorTraits_Args	649.603	403.545	0.941336
SumShuffleVectorTraitsIf	614.013	426.935	0.995898
SumShuffleVector128Traits	1066.598	245.776	0.573313
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	610.455	429.424	1.001702
SumYShuffleKernelVectorTraits_Args	647.348	404.950	0.944614
SumYShuffleKernelVector128Traits	1066.577	245.781	0.573324
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
SumShuffleScalar	902.458	290.478
SumShuffleVectorBase	902.620	290.426	0.999821
SumShuffleVectorTraits	901.826	290.681	1.000701
SumShuffleVectorTraits_Args	970.602	270.084	0.929792
SumShuffleVector128Traits	1705.465	153.708	0.529157
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	901.921	290.651	1.000595
SumYShuffleKernelVectorTraits_Args	970.916	269.997	0.929491
SumYShuffleKernelVector128Traits	1708.383	153.446	0.528253
SumYShuffleKernelVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	687.308	381.407
SumShuffleVectorBase	689.518	380.185	0.996796
SumShuffleVectorTraits	689.822	380.017	0.996356
SumShuffleVectorTraits_Args	799.392	327.929	0.859788
SumShuffleVector128Traits	1658.512	158.060	0.414412
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	1471.949	178.093	0.466937
SumYShuffleKernelVectorTraits_Args	793.131	330.518	0.866576
SumYShuffleKernelVector128Traits	1221.561	214.598	0.562647
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
SumShuffleScalar	387.075	677.244
SumShuffleVectorBase	386.726	677.854	1.000901
SumShuffleVectorTraits	386.203	678.773	1.002257
SumShuffleVectorTraits_Args0	397.247	659.901	0.974392
SumShuffleVectorTraits_Args	412.164	636.018	0.939127
SumShuffleVectorTraitsIf	398.078	658.524	0.972358
SumShuffleVector128Traits	634.098	413.412	0.610433
SumShuffleVector256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	388.807	674.227	0.995545
SumYShuffleKernelVectorTraits_Args0	387.810	675.959	0.998103
SumYShuffleKernelVectorTraits_Args	415.638	630.702	0.931278
SumYShuffleKernelVector128Traits	634.184	413.356	0.610350
SumYShuffleKernelVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

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
# SumShuffleScalar	-24614
SumShuffleScalar	620.653	422.368
SumShuffleVectorBase	620.441	422.512	1.000341
SumShuffleVectorTraits	66.413	3947.189	9.345371
SumShuffleVectorTraits_Args	93.057	2817.035	6.669617
SumShuffleVectorTraitsIf	66.211	3959.244	9.373913
SumShuffleVector128_Arm	99.839	2625.679	6.216562
SumShuffleVector128Traits	65.825	3982.432	9.428811
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	59.606	4397.982	10.412669
SumYShuffleKernelVectorTraits_Args	93.054	2817.128	6.669837
SumYShuffleKernelVector128_Arm	91.525	2864.191	6.781262
SumYShuffleKernelVector128Traits	53.336	4914.954	11.636653
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
SumShuffleScalar	932.023	281.263
SumShuffleVectorBase	932.101	281.240	0.999916
SumShuffleVectorTraits	142.726	1836.693	6.530152
SumShuffleVectorTraits_Args	187.356	1399.179	4.974622
SumShuffleVector128_Arm	205.241	1277.249	4.541113
SumShuffleVector128Traits	133.871	1958.185	6.962102
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	132.337	1980.877	7.042781
SumYShuffleKernelVectorTraits_Args	186.187	1407.957	5.005830
SumYShuffleKernelVector128_Arm	190.328	1377.328	4.896934
SumYShuffleKernelVector128Traits	120.468	2176.053	7.736706
SumYShuffleKernelVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	594.230	441.149
SumShuffleVectorBase	593.972	441.340	1.000433
SumShuffleVectorTraits	308.265	850.386	1.927661
SumShuffleVectorTraits_Args	371.787	705.092	1.598307
SumShuffleVector128_Arm	482.669	543.113	1.231132
SumShuffleVector128Traits	283.506	924.651	2.096006
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	269.113	974.103	2.208104
SumYShuffleKernelVectorTraits_Args	371.608	705.432	1.599078
SumYShuffleKernelVector128_Arm	349.798	749.416	1.698781
SumYShuffleKernelVector128_Arm_Multiply	689.891	379.979	0.861339
SumYShuffleKernelVector128Traits	264.000	992.971	2.250874
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
SumShuffleScalar	395.245	663.245
SumShuffleVectorBase	396.144	661.740	0.997731
SumShuffleVectorTraits	16.766	15635.033	23.573546
SumShuffleVectorTraits_Args0	15.648	16752.295	25.258085
SumShuffleVectorTraits_Args	46.595	5626.027	8.482579
SumShuffleVectorTraitsIf	19.923	13157.656	19.838308
SumShuffleVector128_Arm	23.296	11252.733	16.966182
SumShuffleVector128Traits	15.624	16777.767	25.296490
SumShuffleVector256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	19.916	13162.651	19.845839
SumYShuffleKernelVectorTraits_Args0	16.641	15752.524	23.750692
SumYShuffleKernelVectorTraits_Args	46.798	5601.623	8.445785
SumYShuffleKernelVector128_Arm	23.281	11259.840	16.976897
SumYShuffleKernelVector128Traits	15.611	16792.138	25.318159
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
# SumShuffleScalar	-24614
SumShuffleScalar	618.811	423.625
SumShuffleVectorBase	618.742	423.673	1.000112
SumShuffleVectorTraits	61.315	4275.388	10.092381
SumShuffleVectorTraits_Args	93.001	2818.713	6.653789
SumShuffleVectorTraitsIf	66.070	3967.668	9.365984
SumShuffleVector128_Arm	97.448	2690.098	6.350183
SumShuffleVector128Traits	60.470	4335.109	10.233357
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	53.333	4915.201	11.602708
SumYShuffleKernelVectorTraits_Args	93.036	2817.669	6.651323
SumYShuffleKernelVector128_Arm	93.553	2802.091	6.614552
SumYShuffleKernelVector128Traits	53.007	4945.423	11.674050
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
SumShuffleScalar	924.535	283.542
SumShuffleVectorBase	927.864	282.524	0.996412
SumShuffleVectorTraits	132.833	1973.491	6.960149
SumShuffleVectorTraits_Args	182.527	1436.191	5.065188
SumShuffleVector128_Arm	199.672	1312.872	4.630263
SumShuffleVector128Traits	129.465	2024.828	7.141205
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	120.699	2171.876	7.659816
SumYShuffleKernelVectorTraits_Args	175.982	1489.608	5.253580
SumYShuffleKernelVector128_Arm	189.997	1379.726	4.866046
SumYShuffleKernelVector128Traits	123.057	2130.265	7.513063
SumYShuffleKernelVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	584.751	448.300
SumShuffleVectorBase	586.932	446.634	0.996284
SumShuffleVectorTraits	290.947	901.004	2.009823
SumShuffleVectorTraits_Args	352.529	743.609	1.658732
SumShuffleVector128_Arm	474.527	552.432	1.232282
SumShuffleVector128Traits	290.987	900.879	2.009544
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	245.559	1067.540	2.381306
SumYShuffleKernelVectorTraits_Args	352.492	743.689	1.658908
SumYShuffleKernelVector128_Arm	346.691	756.131	1.686663
SumYShuffleKernelVector128_Arm_Multiply	704.309	372.200	0.830248
SumYShuffleKernelVector128Traits	264.006	992.948	2.214918
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
SumShuffleScalar	393.825	665.636
SumShuffleVectorBase	397.508	659.468	0.990734
SumShuffleVectorTraits	15.602	16802.420	25.242667
SumShuffleVectorTraits_Args0	16.626	15766.774	23.686792
SumShuffleVectorTraits_Args	44.098	5944.612	8.930729
SumShuffleVectorTraitsIf	15.616	16786.394	25.218590
SumShuffleVector128_Arm	23.283	11258.989	16.914642
SumShuffleVector128Traits	16.620	15772.353	23.695174
SumShuffleVector256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	15.606	16797.796	25.235720
SumYShuffleKernelVectorTraits_Args0	16.635	15758.383	23.674186
SumYShuffleKernelVectorTraits_Args	44.107	5943.303	8.928763
SumYShuffleKernelVector128_Arm	22.287	11762.419	17.670956
SumYShuffleKernelVector128Traits	15.603	16800.985	25.240511
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
SumShuffleScalar	497.264	527.172
SumShuffleVectorBase	497.635	526.780	0.999255
SumShuffleVectorTraits	62.816	4173.186	7.916169
SumShuffleVectorTraits_Args	26.530	9880.960	18.743315
SumShuffleVectorTraitsIf	62.935	4165.300	7.901209
SumShuffleVector128_Bcl	544.491	481.447	0.913264
SumShuffleVector128_Arm	114.105	2297.395	4.357958
SumShuffleVector128Traits	62.944	4164.730	7.900128
SumShuffleVector256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	50.400	5201.276	9.866364
SumYShuffleKernelVectorTraits_Args	26.497	9893.193	18.766521
SumYShuffleKernelVector128_Arm	94.844	2763.945	5.242961
SumYShuffleKernelVector128Traits	50.407	5200.515	9.864921
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
SumShuffleScalar	829.108	316.176
SumShuffleVectorBase	825.919	317.397	1.003861
SumShuffleVectorTraits	134.135	1954.332	6.181156
SumShuffleVectorTraits_Args	54.877	4776.975	15.108604
SumShuffleVector128_Bcl	864.953	303.073	0.958559
SumShuffleVector128_Arm	227.391	1152.834	3.646179
SumShuffleVector128Traits	134.773	1945.075	6.151877
SumShuffleVector256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	116.239	2255.214	7.132785
SumYShuffleKernelVectorTraits_Args	54.681	4794.104	15.162779
SumYShuffleKernelVector128_Arm	194.068	1350.784	4.272255
SumYShuffleKernelVector128Traits	116.244	2255.124	7.132500
SumYShuffleKernelVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVector256Traits_ArgsX	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	1176.435	222.829
SumShuffleVectorBase	476.187	550.507	2.470532
SumShuffleVectorTraits	275.951	949.966	4.263202
SumShuffleVectorTraits_Args	107.321	2442.621	10.961854
SumShuffleVector128_Bcl	369.911	708.668	3.180321
SumShuffleVector128_Arm	510.795	513.208	2.303145
SumShuffleVector128Traits	276.476	948.162	4.255106
SumShuffleVector256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	244.416	1072.534	4.813255
SumYShuffleKernelVectorTraits_Args	107.086	2447.984	10.985924
SumYShuffleKernelVector128_Arm	393.956	665.414	2.986207
SumYShuffleKernelVector128_Arm_Multiply	606.241	432.409	1.940541
SumYShuffleKernelVector128Traits	244.702	1071.277	4.807614
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
SumShuffleScalar	314.933	832.381
SumShuffleVectorBase	314.985	832.243	0.999834
SumShuffleVectorTraits	13.263	19765.186	23.745351
SumShuffleVectorTraits_Args0	13.268	19757.494	23.736110
SumShuffleVectorTraits_Args	13.339	19652.204	23.609617
SumShuffleVectorTraitsIf	13.253	19779.977	23.763120
SumShuffleVector128_Bcl	405.292	646.803	0.777051
SumShuffleVector128_Arm	19.965	13130.488	15.774606
SumShuffleVector128Traits	13.249	19785.960	23.770307
SumShuffleVector256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
SumShuffleVector256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	13.235	19806.687	23.795209
SumYShuffleKernelVectorTraits_Args0	13.260	19769.040	23.749980
SumYShuffleKernelVectorTraits_Args	13.269	19755.439	23.733641
SumYShuffleKernelVector128_Arm	19.967	13129.169	15.773022
SumYShuffleKernelVector128Traits	13.265	19762.352	23.741946
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

