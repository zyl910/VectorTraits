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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-24614
SumShuffleScalar	324.137	808.745
SumShuffleVectorBase	340.018	770.972	0.953294
SumShuffleVectorTraits	144.733	1811.230	2.239557
SumShuffleVectorTraits_Args	37.368	7015.289	8.674293
SumShuffleVectorTraitsIf	70.666	3709.601	4.586863
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	51.481	5092.102	6.296303
SumYShuffleKernelVectorTraits	54.642	4797.481	5.932009
SumYShuffleKernelVectorTraits_Args	28.023	9354.600	11.566814
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	56.493	4640.268	5.737617
SumYShuffleKernelVector256_Avx2_ShiftLane	43.677	6001.890	7.421241
SumYShuffleKernelVector256Traits	46.213	5672.470	7.013919
SumYShuffleKernelVector256Traits_Args0	26.207	10002.659	12.368128
SumYShuffleKernelVector256Traits_Args	25.777	10169.750	12.574734
SumYShuffleKernelVector256Traits_ArgsX	163.475	1603.572	1.982792

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	520.662	503.483
SumShuffleVectorBase	427.160	613.691	1.218893
SumShuffleVectorTraits	52.996	4946.514	9.824599
SumShuffleVectorTraits_Args	36.959	7092.927	14.087733
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	50.111	5231.317	10.390265
SumYShuffleKernelVectorTraits	52.812	4963.729	9.858791
SumYShuffleKernelVectorTraits_Args	34.482	7602.347	15.099526
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	37.436	7002.425	13.907981
SumYShuffleKernelVector256Traits_Args0	34.955	7499.527	14.895309
SumYShuffleKernelVector256Traits_Args	36.673	7148.089	14.197293
SumYShuffleKernelVector256Traits_ArgsX	365.281	717.651	1.425374

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	819.469	319.895
SumShuffleVectorBase	850.524	308.215	0.963487
SumShuffleVectorTraits	206.517	1269.359	3.968049
SumShuffleVectorTraits_Args	124.641	2103.186	6.574613
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	149.767	1750.349	5.471634
SumYShuffleKernelVectorTraits	117.836	2224.651	6.954314
SumYShuffleKernelVectorTraits_Args	87.436	2998.132	9.372236
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	102.189	2565.293	8.019170
SumYShuffleKernelVector256_Avx2_DuplicateEven	112.163	2337.168	7.306046
SumYShuffleKernelVector256_Avx2_Multiply	453.997	577.413	1.805008
SumYShuffleKernelVector256_Avx2_ShiftLane	94.219	2782.278	8.697470
SumYShuffleKernelVector256Traits	99.868	2624.892	8.205481
SumYShuffleKernelVector256Traits_Args0	74.649	3511.665	10.977556
SumYShuffleKernelVector256Traits_Args	67.397	3889.522	12.158746
SumYShuffleKernelVector256Traits_ArgsX	559.604	468.446	1.464373

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	311.016	842.863
SumShuffleVectorBase	330.717	792.653	0.940430
SumShuffleVectorTraits	28.576	9173.646	10.883913
SumShuffleVectorTraits_Args0	13.262	19765.939	23.450954
SumShuffleVectorTraits_Args	12.824	20440.939	24.251796
SumShuffleVectorTraitsIf	25.338	10345.915	12.274730
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	47.636	5503.052	6.529001
SumShuffleVector256_Avx2_Add2	25.222	10393.511	12.331200
SumShuffleVector256_Avx2_Cmp2	20.514	12778.787	15.161169
SumShuffleVector256Traits	22.205	11805.483	14.006409
SumYShuffleKernelVectorTraits	16.215	16166.530	19.180497
SumYShuffleKernelVectorTraits_Args0	10.560	24825.207	29.453434
SumYShuffleKernelVectorTraits_Args	10.789	24297.593	28.827456
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	16.614	15778.120	18.719675
SumYShuffleKernelVector256Traits_Args0	10.608	24711.705	29.318772
SumYShuffleKernelVector256Traits_Args	11.577	22644.367	26.866015
SumYShuffleKernelVector256Traits_ArgsX	69.879	3751.394	4.450776

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-24614
SumShuffleScalar	361.191	725.776
SumShuffleVectorBase	449.377	583.350	0.803760
SumShuffleVectorTraits	185.435	1413.669	1.947803
SumShuffleVectorTraits_Args	44.673	5868.019	8.085163
SumShuffleVectorTraitsIf	78.215	3351.599	4.617951
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	71.620	3660.182	5.043128
SumYShuffleKernelVectorTraits	97.541	2687.518	3.702957
SumYShuffleKernelVectorTraits_Args	37.435	7002.691	9.648555
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	63.979	4097.350	5.645473
SumYShuffleKernelVector256_Avx2_ShiftLane	52.716	4972.745	6.851624
SumYShuffleKernelVector256Traits	57.898	4527.670	6.238384
SumYShuffleKernelVector256Traits_Args0	26.387	9934.450	13.688035
SumYShuffleKernelVector256Traits_Args	24.001	10922.332	15.049175
SumYShuffleKernelVector256Traits_ArgsX	162.687	1611.342	2.220163

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	497.296	527.138
SumShuffleVectorBase	493.504	531.189	1.007685
SumShuffleVectorTraits	53.801	4872.474	9.243257
SumShuffleVectorTraits_Args	51.249	5115.120	9.703564
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	52.604	4983.358	9.453608
SumYShuffleKernelVectorTraits	65.045	4030.224	7.645477
SumYShuffleKernelVectorTraits_Args	50.297	5211.952	9.887259
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	70.305	3728.653	7.073387
SumYShuffleKernelVector256Traits_Args0	52.167	5025.061	9.532719
SumYShuffleKernelVector256Traits_Args	46.237	5669.537	10.755313
SumYShuffleKernelVector256Traits_ArgsX	366.743	714.788	1.355979

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	851.452	307.879
SumShuffleVectorBase	752.032	348.581	1.132202
SumShuffleVectorTraits	170.495	1537.548	4.994003
SumShuffleVectorTraits_Args	108.784	2409.774	7.827017
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256Traits	129.716	2020.907	6.563966
SumYShuffleKernelVectorTraits	124.867	2099.388	6.818876
SumYShuffleKernelVectorTraits_Args	73.636	3560.002	11.562993
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	170.033	1541.729	5.007581
SumYShuffleKernelVector256_Avx2_DuplicateEven	121.900	2150.486	6.984842
SumYShuffleKernelVector256_Avx2_Multiply	493.338	531.368	1.725899
SumYShuffleKernelVector256_Avx2_ShiftLane	127.008	2063.988	6.703895
SumYShuffleKernelVector256Traits	99.335	2639.000	8.571553
SumYShuffleKernelVector256Traits_Args0	86.252	3039.293	9.871714
SumYShuffleKernelVector256Traits_Args	84.308	3109.344	10.099242
SumYShuffleKernelVector256Traits_ArgsX	644.842	406.525	1.320404

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	285.373	918.600
SumShuffleVectorBase	287.505	911.788	0.992584
SumShuffleVectorTraits	21.966	11934.204	12.991729
SumShuffleVectorTraits_Args0	11.539	22718.296	24.731430
SumShuffleVectorTraits_Args	12.093	21678.041	23.598995
SumShuffleVectorTraitsIf	21.874	11984.131	13.046080
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Avx2_Add1	47.511	5517.587	6.006517
SumShuffleVector256_Avx2_Add2	26.869	9756.509	10.621062
SumShuffleVector256_Avx2_Cmp2	20.693	12668.303	13.790878
SumShuffleVector256Traits	16.703	15694.320	17.085039
SumYShuffleKernelVectorTraits	17.081	15346.950	16.706888
SumYShuffleKernelVectorTraits_Args0	11.668	22467.241	24.458128
SumYShuffleKernelVectorTraits_Args	13.362	19618.182	21.356606
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	19.796	13242.139	14.415563
SumYShuffleKernelVector256Traits_Args0	11.699	22408.081	24.393726
SumYShuffleKernelVector256Traits_Args	13.019	20135.086	21.919315
SumYShuffleKernelVector256Traits_ArgsX	75.262	3483.084	3.791730

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
SumShuffleScalar	358.134	731.972
SumShuffleVectorBase	358.782	730.651	0.998194
SumShuffleVectorTraits	55.077	4759.615	6.502451
SumShuffleVectorTraits_Args	26.403	9928.487	13.564016
SumShuffleVectorTraitsIf	57.752	4539.168	6.201283
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	469.290	558.596	0.763139
SumShuffleVector256Traits	53.185	4928.923	6.733755
SumYShuffleKernelVectorTraits	63.023	4159.500	5.682591
SumYShuffleKernelVectorTraits_Args	28.465	9209.449	12.581688
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_Multiply	53.044	4941.979	6.751592
SumYShuffleKernelVector256_Avx2_ShiftLane	57.191	4583.681	6.262096
SumYShuffleKernelVector256Traits	53.897	4863.829	6.644825
SumYShuffleKernelVector256Traits_Args0	26.218	9998.737	13.659991
SumYShuffleKernelVector256Traits_Args	24.042	10903.555	14.896127
SumYShuffleKernelVector256Traits_ArgsX	29.734	8816.186	12.044423

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	470.830	556.770
SumShuffleVectorBase	435.829	601.484	1.080309
SumShuffleVectorTraits	34.800	7532.969	13.529756
SumShuffleVectorTraits_Args	35.519	7380.385	13.255704
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	524.290	499.998	0.898032
SumShuffleVector256Traits	43.015	6094.212	10.945645
SumYShuffleKernelVectorTraits	32.496	8066.966	14.488854
SumYShuffleKernelVectorTraits_Args	29.874	8775.029	15.760586
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	29.318	8941.284	16.059192
SumYShuffleKernelVector256Traits_Args0	39.574	6624.191	11.897525
SumYShuffleKernelVector256Traits_Args	37.072	7071.175	12.700340
SumYShuffleKernelVector256Traits_ArgsX	43.902	5971.121	10.724564

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	788.553	332.437
SumShuffleVectorBase	748.788	350.091	1.053106
SumShuffleVectorTraits	157.331	1666.193	5.012059
SumShuffleVectorTraits_Args	84.496	3102.429	9.332388
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	640.719	409.140	1.230731
SumShuffleVector256Traits	116.853	2243.365	6.748245
SumYShuffleKernelVectorTraits	134.674	1946.514	5.855291
SumYShuffleKernelVectorTraits_Args	79.484	3298.072	9.920900
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256_Avx2_AlignRight	132.218	1982.661	5.964024
SumYShuffleKernelVector256_Avx2_DuplicateEven	115.691	2265.896	6.816020
SumYShuffleKernelVector256_Avx2_Multiply	224.213	1169.171	3.516974
SumYShuffleKernelVector256_Avx2_ShiftLane	108.302	2420.492	7.281057
SumYShuffleKernelVector256Traits	95.290	2751.020	8.275318
SumYShuffleKernelVector256Traits_Args0	65.930	3976.068	11.960372
SumYShuffleKernelVector256Traits_Args	74.795	3504.841	10.542879
SumYShuffleKernelVector256Traits_ArgsX	109.276	2398.923	7.216177

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	275.912	950.101
SumShuffleVectorBase	273.473	958.575	1.008918
SumShuffleVectorTraits	21.555	12161.729	12.800453
SumShuffleVectorTraits_Args0	11.435	22924.616	24.128598
SumShuffleVectorTraits_Args	11.333	23131.339	24.346178
SumShuffleVectorTraitsIf	20.846	12575.404	13.235854
SumShuffleVector128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumShuffleVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumShuffleVector256_Bcl	375.571	697.989	0.734646
SumShuffleVector256_Avx2_Add1	22.472	11665.437	12.278096
SumShuffleVector256_Avx2_Add2	25.959	10098.518	10.628884
SumShuffleVector256_Avx2_Cmp2	17.008	15413.110	16.222594
SumShuffleVector256Traits	15.341	17088.011	17.985459
SumYShuffleKernelVectorTraits	18.663	14046.271	14.783970
SumYShuffleKernelVectorTraits_Args0	12.001	21842.632	22.989789
SumYShuffleKernelVectorTraits_Args	11.134	23543.773	24.780273
SumYShuffleKernelVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleKernelVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleKernelVector256Traits	21.644	12111.862	12.747967
SumYShuffleKernelVector256Traits_Args0	13.770	19036.746	20.036541
SumYShuffleKernelVector256Traits_Args	13.504	19412.131	20.431640
SumYShuffleKernelVector256Traits_ArgsX	14.195	18467.848	19.437764

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
SumShuffleScalar	368.649	711.094
SumShuffleVectorBase	365.275	717.662	1.009237
SumShuffleVectorTraits	379.116	691.461	0.972390
SumShuffleVectorTraits_Args	374.038	700.848	0.985591
SumShuffleVectorTraitsIf	358.304	731.624	1.028871
SumYShuffleKernelVectorTraits	338.649	774.089	1.088589
SumYShuffleKernelVectorTraits_Args	324.561	807.689	1.135840

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	-467755046
SumShuffleScalar	473.439	553.701
SumShuffleVectorBase	486.132	539.245	0.973891
SumShuffleVectorTraits	657.506	398.695	0.720054
SumShuffleVectorTraits_Args	507.396	516.645	0.933076
SumYShuffleKernelVectorTraits	488.761	536.344	0.968652
SumYShuffleKernelVectorTraits_Args	504.451	519.662	0.938524

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	5910372263572008452
SumShuffleScalar	744.186	352.256
SumShuffleVectorBase	741.151	353.699	1.004096
SumShuffleVectorTraits	723.607	362.274	1.028440
SumShuffleVectorTraits_Args	748.973	350.005	0.993610
SumYShuffleKernelVectorTraits	730.883	358.668	1.018202
SumYShuffleKernelVectorTraits_Args	703.102	372.839	1.058433

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumShuffleScalar	114
SumShuffleScalar	263.306	995.586
SumShuffleVectorBase	288.264	909.390	0.913422
SumShuffleVectorTraits	275.370	951.970	0.956190
SumShuffleVectorTraits_Args	300.801	871.487	0.875351
SumShuffleVectorTraitsIf	298.471	878.290	0.882184
SumYShuffleKernelVectorTraits	271.487	965.585	0.969866
SumYShuffleKernelVectorTraits_Args	312.075	840.002	0.843726

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
SumShuffleScalar	622.784	420.923
SumShuffleVectorBase	623.265	420.598	0.999228
SumShuffleVectorTraits	175.291	1495.477	3.552853
SumShuffleVectorTraits_Args	93.146	2814.344	6.686129
SumShuffleVectorTraitsIf	70.798	3702.718	8.796667
SumShuffleVector128_Arm	102.612	2554.715	6.069320
SumShuffleVector128Traits	66.590	3936.706	9.352560
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	66.140	3963.489	9.416191
SumYShuffleKernelVectorTraits_Args	93.282	2810.219	6.676328
SumYShuffleKernelVector128_Arm	95.089	2756.830	6.549491
SumYShuffleKernelVector128Traits	63.521	4126.889	9.804386
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
SumShuffleScalar	620.672	422.355
SumShuffleVectorBase	620.562	422.430	1.000178
SumShuffleVectorTraits	172.409	1520.473	3.599989
SumShuffleVectorTraits_Args	88.124	2974.718	7.043170
SumShuffleVectorTraitsIf	66.624	3934.696	9.316089
SumShuffleVector128_Arm	98.832	2652.425	6.280084
SumShuffleVector128Traits	64.585	4058.872	9.610098
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	60.946	4301.227	10.183916
SumYShuffleKernelVectorTraits_Args	88.156	2973.621	7.040574
SumYShuffleKernelVector128_Arm	95.190	2753.905	6.520357
SumYShuffleKernelVector128Traits	59.450	4409.500	10.440272
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
SumShuffleScalar	498.475	525.892
SumShuffleVectorBase	499.707	524.596	0.997535
SumShuffleVectorTraits	67.239	3898.703	7.413504
SumShuffleVectorTraits_Args	27.331	9591.477	18.238488
SumShuffleVectorTraitsIf	66.792	3924.771	7.463073
SumShuffleVector128_Bcl	546.944	479.289	0.911382
SumShuffleVector128_Arm	112.847	2322.999	4.417255
SumShuffleVector128Traits	66.954	3915.269	7.445004
SumShuffleVector256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
SumShuffleVector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleKernelVectorTraits	57.841	4532.183	8.618085
SumYShuffleKernelVectorTraits_Args	27.221	9630.176	18.312075
SumYShuffleKernelVector128_Arm	96.528	2715.729	5.164042
SumYShuffleKernelVector128Traits	57.930	4525.183	8.604775
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

