# Benchmark - ShiftRightArithmetic
([← Back](README.md))

See [Group](ShiftRightArithmetic_Group.md)

- `ShiftRightArithmetic[/_Args/_Core/_Const/_ConstCore/_Fast]`: Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
  Mnemonic: `rt[i] := value[i] >> shiftAmount`, `shiftAmount &= (T.BitSize-1)`.

## X86

### AMD Ryzen 7 7840H
`AMD Ryzen 7 7840H w/ Radeon 780M Graphics`

#### .NET Framework

```
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9232.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks/bin/Release/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	223.787	1171.399
SumSRA_Base_Basic	164.806	1590.621	1.357882
SumSRA_Base	136.381	1922.147	1.640899
SumSRA_Base_Core	133.663	1961.224	1.674258
SumSRATraits	135.559	1933.799	1.650846
SumSRATraits_Core	136.725	1917.312	1.636771
SumSRAConstTraits	137.261	1909.825	1.630380
SumSRAConstTraits_Core	135.928	1928.549	1.646364
SumSRAFastTraits	136.040	1926.959	1.645007

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	179.712	1458.693
SumSRA_Base_Basic	280.374	934.980	0.640971
SumSRA_Base	284.911	920.090	0.630763
SumSRA_Base_Core	267.362	980.484	0.672166
SumSRATraits	274.601	954.635	0.654445
SumSRATraits_Core	271.244	966.451	0.662546
SumSRAConstTraits	272.934	960.465	0.658442
SumSRAConstTraits_Core	270.290	969.862	0.664884
SumSRAFastTraits	272.660	961.432	0.659105

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	178.082	1472.038
SumSRA_Base_Basic	506.559	517.500	0.351553
SumSRA_Base	508.372	515.654	0.350299
SumSRA_Base_Create	540.203	485.269	0.329658
SumSRA_Base_LoadArray	562.890	465.711	0.316372
SumSRA_Base_Core	505.616	518.465	0.352209
SumSRATraits	505.428	518.658	0.352340
SumSRATraits_Core	480.038	546.090	0.370976
SumSRAConstTraits	482.286	543.545	0.369247
SumSRAConstTraits_Core	481.903	543.977	0.369540
SumSRAFastTraits	481.954	543.920	0.369501

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	239.296	1095.479
SumSRA_Base_Basic	137.801	1902.343	1.736540
SumSRA_Base	67.915	3859.903	3.523484
SumSRA_Base_Core	67.627	3876.342	3.538491
SumSRATraits	67.507	3883.197	3.544748
SumSRATraits_Core	67.440	3887.064	3.548278
SumSRAConstTraits	67.325	3893.712	3.554347
SumSRAConstTraits_Core	67.636	3875.812	3.538006
SumSRAFastTraits	67.974	3856.509	3.520385

```

#### .NET Core 2.1

```
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:	.NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	224.815	1166.041
SumSRA_Base_Basic	162.665	1611.562	1.382081
SumSRA_Base	134.205	1953.305	1.675160
SumSRA_Base_Core	134.755	1945.339	1.668328
SumSRATraits	134.294	1952.008	1.674048
SumSRATraits_Core	133.806	1959.130	1.680156
SumSRAConstTraits	134.153	1954.068	1.675814
SumSRAConstTraits_Core	133.829	1958.795	1.679869
SumSRAFastTraits	134.452	1949.727	1.672092

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	179.194	1462.908
SumSRA_Base_Basic	269.385	973.119	0.665195
SumSRA_Base	273.122	959.804	0.656093
SumSRA_Base_Core	265.859	986.026	0.674017
SumSRATraits	272.273	962.797	0.658139
SumSRATraits_Core	268.203	977.410	0.668128
SumSRAConstTraits	267.846	978.713	0.669018
SumSRAConstTraits_Core	269.266	973.550	0.665489
SumSRAFastTraits	270.030	970.796	0.663607

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	180.149	1455.150
SumSRA_Base_Basic	497.517	526.905	0.362096
SumSRA_Base	498.111	526.276	0.361664
SumSRA_Base_Create	541.063	484.498	0.332954
SumSRA_Base_LoadArray	538.823	486.512	0.334338
SumSRA_Base_Core	499.238	525.088	0.360848
SumSRATraits	498.947	525.394	0.361058
SumSRATraits_Core	479.531	546.667	0.375677
SumSRAConstTraits	479.450	546.760	0.375741
SumSRAConstTraits_Core	480.019	546.112	0.375296
SumSRAFastTraits	478.377	547.986	0.376584

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	237.205	1105.136
SumSRA_Base_Basic	133.744	1960.038	1.773571
SumSRA_Base	67.130	3905.026	3.533524
SumSRA_Base_Core	66.821	3923.078	3.549859
SumSRATraits	66.859	3920.857	3.547849
SumSRATraits_Core	67.421	3888.188	3.518288
SumSRAConstTraits	67.102	3906.667	3.535009
SumSRAConstTraits_Core	67.062	3908.952	3.537076
SumSRAFastTraits	67.388	3890.058	3.519980

```

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	184.659	1419.611
SumSRA_Base_Basic	176.147	1488.214	1.048325
SumSRA_Base	141.969	1846.490	1.300701
SumSRA_Base_Core	139.078	1884.877	1.327742
SumSRA_Avx2	8.010	32725.115	23.052172
SumSRATraits	8.086	32420.647	22.837699
SumSRATraits_Core	6.043	43382.862	30.559685
SumSRAConstTraits	8.020	32684.978	23.023899
SumSRAConstTraits_Core	6.072	43171.777	30.410993
SumSRA128Traits	15.072	17392.658	12.251708
SumSRA128Traits_Core	11.628	22545.143	15.881213
SumSRA128ConstTraits	15.323	17108.197	12.051328
SumSRA128ConstTraits_Core	11.879	22067.636	15.544848
SumSRAFast_Avx2	7.868	33317.556	23.469499
SumSRAFastTraits	7.553	34707.695	24.448738

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	166.350	1575.854
SumSRA_Base_Basic	287.238	912.638	0.579139
SumSRA_Base	280.059	936.030	0.593983
SumSRA_Base_Core	268.072	977.887	0.620544
SumSRA_Avx2	16.288	16094.575	10.213240
SumSRATraits	16.632	15761.197	10.001687
SumSRATraits_Core	11.642	22516.825	14.288650
SumSRAConstTraits	16.054	16328.673	10.361793
SumSRAConstTraits_Core	11.576	22645.903	14.370560
SumSRA128Traits	30.675	8545.948	5.423058
SumSRA128Traits_Core	20.054	13071.966	8.295163
SumSRA128ConstTraits	31.185	8406.100	5.334314
SumSRA128ConstTraits_Core	21.425	12235.400	7.764298
SumSRAFast_Avx2	16.196	16185.477	10.270924
SumSRAFastTraits	15.871	16517.599	10.481681

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	153.672	1705.865
SumSRA_Base_Basic	499.303	525.020	0.307774
SumSRA_Base	503.421	520.725	0.305256
SumSRA_Base_Create	558.382	469.470	0.275210
SumSRA_Base_LoadArray	562.499	466.034	0.273195
SumSRA_Base_Core	504.791	519.312	0.304427
SumSRA_Avx2	43.741	5993.131	3.513251
SumSRATraits	43.880	5974.104	3.502097
SumSRATraits_Core	34.902	7510.838	4.402950
SumSRAConstTraits	40.397	6489.149	3.804022
SumSRAConstTraits_Core	34.962	7497.869	4.395347
SumSRA128Traits	86.732	3022.467	1.771809
SumSRA128Traits_Core	73.318	3575.415	2.095954
SumSRA128ConstTraits	79.590	3293.671	1.930792
SumSRA128ConstTraits_Core	78.632	3333.819	1.954327
SumSRAFast_Avx2	40.255	6512.126	3.817492
SumSRAFast_Avx2_Negative	50.409	5200.320	3.048494
SumSRAFastTraits	40.689	6442.557	3.776710

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	160.853	1629.709
SumSRA_Base128_Basic	372.221	704.270	0.432144
SumSRA_Base128_Basic_Ref	368.944	710.524	0.435982
SumSRA_Base_Basic	156.855	1671.255	1.025493
SumSRA_Base	71.056	3689.283	2.263767
SumSRA_Base_Core	69.742	3758.786	2.306415
SumSRA_Avx2	9.089	28841.037	17.697043
SumSRATraits	9.194	28511.694	17.494956
SumSRATraits_Core	4.617	56774.363	34.837109
SumSRAConstTraits	7.517	34871.565	21.397413
SumSRAConstTraits_Core	4.617	56781.118	34.841254
SumSRA128Traits	17.664	14840.956	9.106505
SumSRA128Traits_Core	9.085	28855.615	17.705988
SumSRA128ConstTraits	14.935	17552.058	10.770054
SumSRA128ConstTraits_Core	9.167	28597.527	17.547624
SumSRAFast_Avx2	7.475	35070.162	21.519274
SumSRAFastTraits	7.506	34922.808	21.428857

```

#### .NET 5.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	5.0.17
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.17\
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	185.200	1415.467
SumSRA_Base_Basic	177.493	1476.930	1.043422
SumSRA_Base	138.416	1893.883	1.337991
SumSRA_Base_Core	129.708	2021.035	1.427821
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	8.073	32473.655	22.942001
SumSRATraits	7.924	33084.184	23.373327
SumSRATraits_Core	5.846	44840.297	31.678790
SumSRAConstTraits	5.887	44530.875	31.460190
SumSRAConstTraits_Core	5.897	44455.457	31.406908
SumSRA128Traits	15.206	17240.063	12.179767
SumSRA128Traits_Core	11.436	22923.099	16.194720
SumSRA128ConstTraits	11.614	22572.140	15.946774
SumSRA128ConstTraits_Core	11.745	22318.709	15.767730
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	5.925	44243.162	31.256926
SumSRAFastTraits	5.865	44696.095	31.576914

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	165.470	1584.234
SumSRA_Base_Basic	269.953	971.072	0.612960
SumSRA_Base	273.159	959.674	0.605765
SumSRA_Base_Core	276.836	946.929	0.597720
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	16.308	16074.176	10.146338
SumSRATraits	16.450	15936.050	10.059150
SumSRATraits_Core	11.216	23373.253	14.753659
SumSRAConstTraits	12.358	21212.596	13.389810
SumSRAConstTraits_Core	11.182	23443.513	14.798009
SumSRA128Traits	30.436	8612.988	5.436688
SumSRA128Traits_Core	20.223	12962.481	8.182174
SumSRA128ConstTraits	24.077	10887.755	6.872566
SumSRA128ConstTraits_Core	20.263	12936.786	8.165955
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	12.261	21381.102	13.496174
SumSRAFastTraits	12.347	21230.649	13.401205

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	154.835	1693.052
SumSRA_Base_Basic	479.011	547.261	0.323239
SumSRA_Base	486.764	538.545	0.318091
SumSRA_Base_Create	533.704	491.179	0.290114
SumSRA_Base_LoadArray	553.069	473.980	0.279956
SumSRA_Base_Core	481.275	544.687	0.321719
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	42.916	6108.272	3.607847
SumSRATraits	43.394	6041.064	3.568151
SumSRATraits_Core	34.704	7553.755	4.461620
SumSRAConstTraits	39.869	6575.149	3.883607
SumSRAConstTraits_Core	34.732	7547.555	4.457958
SumSRA128Traits	86.069	3045.744	1.798966
SumSRA128Traits_Core	70.383	3724.513	2.199881
SumSRA128ConstTraits	68.191	3844.280	2.270621
SumSRA128ConstTraits_Core	68.205	3843.451	2.270132
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	38.889	6740.909	3.981513
SumSRAFast_Avx2_Negative	50.157	5226.502	3.087030
SumSRAFastTraits	38.683	6776.645	4.002621

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	157.938	1659.794
SumSRA_Base128_Basic	367.253	713.797	0.430051
SumSRA_Base128_Basic_Ref	366.000	716.240	0.431523
SumSRA_Base_Basic	162.163	1616.544	0.973943
SumSRA_Base	69.710	3760.506	2.265646
SumSRA_Base_Core	64.641	4055.376	2.443301
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	8.854	29607.287	17.837928
SumSRATraits	9.085	28854.697	17.384504
SumSRATraits_Core	4.609	56878.490	34.268401
SumSRAConstTraits	5.006	52370.752	31.552560
SumSRAConstTraits_Core	4.569	57368.576	34.563670
SumSRA128Traits	18.234	14376.426	8.661572
SumSRA128Traits_Core	9.102	28802.226	17.352891
SumSRA128ConstTraits	9.811	26720.736	16.098826
SumSRA128ConstTraits_Core	9.125	28727.908	17.308115
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	5.639	46486.783	28.007560
SumSRAFastTraits	5.558	47164.557	28.415909

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.29
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.29\
RuntimeInformation.FrameworkDescription:	.NET 6.0.29
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.29/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	188.530	1390.466
SumSRA_Base_Basic	174.188	1504.945	1.082332
SumSRA_Base	138.101	1898.200	1.365154
SumSRA_Base_Core	132.761	1974.559	1.420070
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	7.857	33366.433	23.996588
SumSRATraits	7.985	32828.436	23.609670
SumSRATraits_Core	5.832	44950.322	32.327530
SumSRAConstTraits	5.169	50718.535	36.475934
SumSRAConstTraits_Core	5.136	51038.405	36.705979
SumSRA128Traits	15.095	17366.137	12.489439
SumSRA128Traits_Core	11.041	23742.533	17.075238
SumSRA128ConstTraits	9.839	26644.285	19.162130
SumSRA128ConstTraits_Core	9.824	26685.114	19.191494
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	6.554	39995.471	28.764083
SumSRAFastTraits	6.598	39733.406	28.575610

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	91.507	2864.744
SumSRA_Base_Basic	268.696	975.615	0.340559
SumSRA_Base	269.702	971.975	0.339289
SumSRA_Base_Core	277.479	944.734	0.329780
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	16.194	16187.903	5.650733
SumSRATraits	16.206	16176.071	5.646603
SumSRATraits_Core	11.249	23304.194	8.134826
SumSRAConstTraits	19.711	13299.587	4.642505
SumSRAConstTraits_Core	11.026	23775.141	8.299220
SumSRA128Traits	30.279	8657.604	3.022122
SumSRA128Traits_Core	20.026	13090.368	4.569472
SumSRA128ConstTraits	19.871	13192.491	4.605121
SumSRA128ConstTraits_Core	19.911	13166.031	4.595884
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	14.530	18041.730	6.297851
SumSRAFastTraits	14.614	17937.382	6.261426

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	153.381	1709.106
SumSRA_Base_Basic	481.177	544.797	0.318762
SumSRA_Base	480.270	545.826	0.319364
SumSRA_Base_Create	518.932	505.160	0.295570
SumSRA_Base_LoadArray	540.388	485.104	0.283835
SumSRA_Base_Core	481.862	544.023	0.318309
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	43.210	6066.710	3.549640
SumSRATraits	43.348	6047.414	3.538350
SumSRATraits_Core	34.551	7587.176	4.439266
SumSRAConstTraits	34.708	7552.906	4.419214
SumSRAConstTraits_Core	34.436	7612.583	4.454132
SumSRA128Traits	85.618	3061.796	1.791461
SumSRA128Traits_Core	67.810	3865.838	2.261907
SumSRA128ConstTraits	67.224	3899.565	2.281640
SumSRA128ConstTraits_Core	67.811	3865.816	2.261894
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	38.629	6786.223	3.970628
SumSRAFast_Avx2_Negative	50.014	5241.382	3.066739
SumSRAFastTraits	38.705	6772.848	3.962802

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	191.452	1369.240
SumSRA_Base128_Basic	361.631	724.894	0.529414
SumSRA_Base128_Basic_Ref	366.797	714.684	0.521956
SumSRA_Base_Basic	156.309	1677.088	1.224831
SumSRA_Base	69.121	3792.543	2.769817
SumSRA_Base_Core	66.337	3951.688	2.886046
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	8.974	29211.188	21.333874
SumSRATraits	8.827	29697.144	21.688784
SumSRATraits_Core	4.550	57618.877	42.080927
SumSRAConstTraits	4.926	53219.953	38.868251
SumSRAConstTraits_Core	4.532	57836.888	42.240147
SumSRA128Traits	17.382	15081.583	11.014567
SumSRA128Traits_Core	9.182	28549.035	20.850282
SumSRA128ConstTraits	9.827	26677.083	19.483136
SumSRA128ConstTraits_Core	9.062	28927.881	21.126966
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	4.906	53437.455	39.027099
SumSRAFastTraits	4.903	53465.455	39.047548

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.18
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.18\
RuntimeInformation.FrameworkDescription:	.NET 7.0.18
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.18/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	165.611	1582.887
SumSRANetBcl	6.723	38990.211	24.632334
SumSRANetBcl_Const	5.131	51085.883	32.273859
SumSRA_Base_Basic	157.293	1666.601	1.052887
SumSRA_Base	6.621	39591.374	25.012124
SumSRA_Base_Core	6.734	38930.269	24.594466
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	8.021	32682.764	20.647561
SumSRATraits	6.678	39253.313	24.798551
SumSRATraits_Core	5.852	44797.366	28.301045
SumSRAConstTraits	5.179	50617.180	31.977753
SumSRAConstTraits_Core	5.122	51180.952	32.333919
SumSRA128Traits	14.997	17479.882	11.043036
SumSRA128Traits_Core	11.207	23392.030	14.778076
SumSRA128ConstTraits	9.998	26219.577	16.564399
SumSRA128ConstTraits_Core	9.887	26514.269	16.750572
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	6.616	39625.110	25.033436
SumSRAFastTraits	6.634	39517.096	24.965198

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	82.567	3174.914
SumSRANetBcl	12.223	21447.389	6.755266
SumSRANetBcl_Const	11.595	22607.586	7.120692
SumSRA_Base_Basic	276.804	947.040	0.298288
SumSRA_Base	12.164	21551.082	6.787926
SumSRA_Base_Core	12.261	21380.896	6.734323
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	15.804	16587.529	5.224560
SumSRATraits	12.225	21443.963	6.754187
SumSRATraits_Core	11.661	22481.135	7.080864
SumSRAConstTraits	11.462	22870.142	7.203390
SumSRAConstTraits_Core	12.281	21346.188	6.723391
SumSRA128Traits	23.925	10956.943	3.451099
SumSRA128Traits_Core	20.129	13023.422	4.101976
SumSRA128ConstTraits	20.968	12502.208	3.937810
SumSRA128ConstTraits_Core	21.001	12482.674	3.931657
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	15.272	17165.242	5.406522
SumSRAFastTraits	12.307	21300.184	6.708901

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	129.396	2025.909
SumSRANetBcl	487.632	537.586	0.265355
SumSRANetBcl_Const	462.637	566.630	0.279692
SumSRA_Base_Basic	489.374	535.672	0.264411
SumSRA_Base	78.166	3353.664	1.655387
SumSRA_Base_Create	43.119	6079.612	3.000931
SumSRA_Base_LoadArray	53.351	4913.547	2.425355
SumSRA_Base_Core	40.496	6473.303	3.195259
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	43.823	5981.920	2.952709
SumSRATraits	43.224	6064.753	2.993596
SumSRATraits_Core	35.374	7410.538	3.657883
SumSRAConstTraits	35.238	7439.295	3.672078
SumSRAConstTraits_Core	34.499	7598.535	3.750680
SumSRA128Traits	86.684	3024.116	1.492721
SumSRA128Traits_Core	67.048	3909.786	1.929892
SumSRA128ConstTraits	67.294	3895.479	1.922830
SumSRA128ConstTraits_Core	68.256	3840.621	1.895752
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	38.858	6746.194	3.329959
SumSRAFast_Avx2_Negative	50.290	5212.670	2.573003
SumSRAFastTraits	38.290	6846.256	3.379351

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	171.876	1525.190
SumSRANetBcl	193.533	1354.521	0.888100
SumSRANetBcl_Const	194.320	1349.030	0.884499
SumSRA_Base128_Basic	145.963	1795.966	1.177535
SumSRA_Base128_Basic_Ref	145.270	1804.524	1.183146
SumSRA_Base_Basic	133.724	1960.341	1.285309
SumSRA_Base	8.770	29890.024	19.597570
SumSRA_Base_Core	5.950	44058.022	28.886901
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	8.500	30840.622	20.220835
SumSRATraits	8.425	31116.322	20.401599
SumSRATraits_Core	4.582	57217.526	37.515007
SumSRAConstTraits	5.008	52347.268	34.321794
SumSRAConstTraits_Core	4.999	52437.244	34.380787
SumSRA128Traits	17.282	15168.298	9.945184
SumSRA128Traits_Core	9.178	28561.929	18.726797
SumSRA128ConstTraits	9.972	26288.261	17.236053
SumSRA128ConstTraits_Core	9.904	26469.254	17.354722
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	4.938	53082.799	34.804049
SumSRAFastTraits	4.933	53138.415	34.840514

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.4
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.4\
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector512.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.4/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844161	# 0x8177F7FF
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Avx512BW, Avx512CD, Avx512DQ, Avx512F, Avx512Vbmi, Avx512VL, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2, Avx512VL
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vector512s.Instance:	WVectorTraits512Avx512	// Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi, Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	154.880	1692.560
SumSRANetBcl	5.764	45480.708	26.870965
SumSRANetBcl_Const	5.263	49811.815	29.429875
SumSRA_Base_Basic	161.967	1618.503	0.956246
SumSRA_Base	5.765	45473.189	26.866522
SumSRA_Base_Core	5.247	49962.608	29.518966
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	7.345	35690.353	21.086616
SumSRATraits	5.237	50056.396	29.574379
SumSRATraits_Core	5.768	45448.335	26.851839
SumSRAConstTraits	5.272	49720.815	29.376110
SumSRAConstTraits_Core	5.258	49852.919	29.454160
SumSRA128Traits	9.816	26706.118	15.778540
SumSRA128Traits_Core	12.276	21353.490	12.616094
SumSRA128ConstTraits	9.845	26627.219	15.731925
SumSRA128ConstTraits_Core	9.790	26776.935	15.820380
SumSRA512Bcl	5.272	49726.778	29.379633
SumSRA512Traits	5.273	49712.336	29.371101
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	5.850	44814.026	26.477075
SumSRAFastTraits	5.263	49812.826	29.430472

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	82.743	3168.167
SumSRANetBcl	13.215	19836.499	6.261191
SumSRANetBcl_Const	12.789	20497.688	6.469889
SumSRA_Base_Basic	268.144	977.624	0.308577
SumSRA_Base	13.289	19725.837	6.226262
SumSRA_Base_Core	12.572	20851.055	6.581426
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	15.074	17390.386	5.489100
SumSRATraits	12.690	20658.167	6.520543
SumSRATraits_Core	13.880	18886.492	5.961331
SumSRAConstTraits	12.588	20824.286	6.572976
SumSRAConstTraits_Core	12.720	20608.459	6.504853
SumSRA128Traits	20.059	13068.369	4.124899
SumSRA128Traits_Core	19.999	13107.812	4.137349
SumSRA128ConstTraits	20.021	13093.670	4.132885
SumSRA128ConstTraits_Core	19.972	13125.608	4.142966
SumSRA512Bcl	12.491	20985.960	6.624007
SumSRA512Traits	12.655	20713.851	6.538119
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	13.105	20004.089	6.314089
SumSRAFastTraits	12.807	20468.399	6.460644

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	84.022	3119.944
SumSRANetBcl	24.072	10890.092	3.490477
SumSRANetBcl_Const	25.936	10107.206	3.239547
SumSRA_Base_Basic	479.964	546.175	0.175059
SumSRA_Base	37.060	7073.438	2.267168
SumSRA_Base_Create	39.298	6670.713	2.138088
SumSRA_Base_LoadArray	36.930	7098.344	2.275151
SumSRA_Base_Core	34.361	7629.063	2.445256
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	29.689	8829.775	2.830107
SumSRATraits	29.596	8857.532	2.839003
SumSRATraits_Core	25.806	10158.073	3.255851
SumSRAConstTraits	25.723	10190.974	3.266396
SumSRAConstTraits_Core	24.536	10684.150	3.424468
SumSRA128Traits	48.791	5372.762	1.722070
SumSRA128Traits_Core	39.825	6582.417	2.109787
SumSRA128ConstTraits	39.722	6599.390	2.115227
SumSRA128ConstTraits_Core	39.727	6598.573	2.114965
SumSRA512Bcl	24.597	10657.570	3.415949
SumSRA512Traits	29.287	8950.917	2.868935
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	24.261	10805.081	3.463229
SumSRAFast_Avx2_Negative	40.245	6513.693	2.087760
SumSRAFastTraits	25.722	10191.593	3.266595

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	165.216	1586.676
SumSRANetBcl	192.178	1364.070	0.859703
SumSRANetBcl_Const	190.095	1379.015	0.869122
SumSRA_Base128_Basic	144.513	1813.976	1.143256
SumSRA_Base128_Basic_Ref	143.455	1827.361	1.151692
SumSRA_Base_Basic	124.641	2103.191	1.325533
SumSRA_Base	7.736	33885.007	21.355976
SumSRA_Base_Core	4.322	60653.542	38.226805
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	4.745	55241.797	34.816061
SumSRATraits	4.714	55613.988	35.050634
SumSRATraits_Core	4.204	62361.830	39.303451
SumSRAConstTraits	4.326	60593.016	38.188659
SumSRAConstTraits_Core	4.222	62094.753	39.135127
SumSRA128Traits	8.516	30784.243	19.401724
SumSRA128Traits_Core	8.501	30837.909	19.435547
SumSRA128ConstTraits	8.348	31401.848	19.790968
SumSRA128ConstTraits_Core	8.390	31244.859	19.692026
SumSRA512Bcl	521.985	502.206	0.316514
SumSRA512Traits	4.237	61876.950	38.997857
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	4.230	61977.088	39.060969
SumSRAFastTraits	4.325	60609.099	38.198795

```

### Intel Core i5-8250U
`Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 
``` 
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9195.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/910Soft/MyCode/VectorTraits_test/RunBenchmarks_All/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	312.021	840.149
SumSRA_Base_Basic	251.582	1041.984	1.240237
SumSRA_Base	165.928	1579.861	1.880454
SumSRA_Base_Core	152.280	1721.463	2.048997
SumSRATraits	165.487	1584.078	1.885473
SumSRATraits_Core	156.232	1677.911	1.997160
SumSRAConstTraits	154.529	1696.402	2.019168
SumSRAConstTraits_Core	150.463	1742.252	2.073743
SumSRAFastTraits	158.045	1658.668	1.974255

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	312.900	837.789
SumSRA_Base_Basic	484.961	540.547	0.645206
SumSRA_Base	339.992	771.030	0.920315
SumSRA_Base_Core	309.671	846.524	1.010426
SumSRATraits	340.161	770.647	0.919858
SumSRATraits_Core	312.207	839.648	1.002219
SumSRAConstTraits	309.677	846.509	1.010408
SumSRAConstTraits_Core	301.021	870.848	1.039460
SumSRAFastTraits	317.621	825.336	0.985135

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	313.425	836.385
SumSRA_Base_Basic	579.685	452.218	0.540682
SumSRA_Base	602.405	435.162	0.520289
SumSRA_Base_Create	619.390	423.229	0.506022
SumSRA_Base_LoadArray	614.533	426.574	0.510022
SumSRA_Base_Core	580.518	451.569	0.539906
SumSRATraits	603.368	434.468	0.519460
SumSRATraits_Core	560.588	467.624	0.559101
SumSRAConstTraits	523.349	500.897	0.598884
SumSRAConstTraits_Core	522.591	501.624	0.599752
SumSRAFastTraits	538.627	486.690	0.581897

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	310.218	845.031
SumSRA_Base_Basic	283.422	924.925	1.094545
SumSRA_Base	83.041	3156.803	3.735724
SumSRA_Base_Core	76.431	3429.808	4.058795
SumSRATraits	83.134	3153.252	3.731522
SumSRATraits_Core	78.107	3356.234	3.971728
SumSRAConstTraits	77.424	3385.809	4.006727
SumSRAConstTraits_Core	75.384	3477.428	4.115148
SumSRAFastTraits	79.255	3307.606	3.914183

``` 

#### .NET Core 2.1 
``` 
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:	.NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	310.878	843.238
SumSRA_Base_Basic	250.333	1047.181	1.241856
SumSRA_Base	160.040	1637.991	1.942501
SumSRA_Base_Core	148.406	1766.398	2.094779
SumSRATraits	160.307	1635.261	1.939263
SumSRATraits_Core	150.583	1740.862	2.064496
SumSRAConstTraits	143.846	1822.398	2.161189
SumSRAConstTraits_Core	140.671	1863.526	2.209964
SumSRAFastTraits	153.866	1703.712	2.020440

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	312.659	838.434
SumSRA_Base_Basic	485.271	540.201	0.644297
SumSRA_Base	327.625	800.133	0.954318
SumSRA_Base_Core	296.488	884.163	1.054540
SumSRATraits	328.421	798.196	0.952008
SumSRATraits_Core	301.098	870.626	1.038395
SumSRAConstTraits	287.617	911.435	1.087068
SumSRAConstTraits_Core	281.586	930.956	1.110351
SumSRAFastTraits	307.920	851.338	1.015391

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	313.839	835.282
SumSRA_Base_Basic	583.471	449.284	0.537883
SumSRA_Base	556.366	471.172	0.564087
SumSRA_Base_Create	598.958	437.667	0.523975
SumSRA_Base_LoadArray	618.362	423.933	0.507533
SumSRA_Base_Core	583.218	449.479	0.538116
SumSRATraits	555.950	471.525	0.564509
SumSRATraits_Core	541.780	483.857	0.579274
SumSRAConstTraits	477.523	548.966	0.657222
SumSRAConstTraits_Core	477.849	548.592	0.656774
SumSRAFastTraits	520.488	503.650	0.602970

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	310.195	845.094
SumSRA_Base_Basic	225.603	1161.971	1.374961
SumSRA_Base	80.149	3270.693	3.870211
SumSRA_Base_Core	74.281	3529.103	4.175987
SumSRATraits	80.389	3260.950	3.858682
SumSRATraits_Core	75.543	3470.118	4.106190
SumSRAConstTraits	71.990	3641.392	4.308859
SumSRAConstTraits_Core	70.388	3724.250	4.406905
SumSRAFastTraits	75.633	3465.987	4.101302

``` 

#### .NET Core 3.1 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	219.721	1193.076
SumSRA_Base_Basic	270.808	968.008	0.811355
SumSRA_Base	162.579	1612.411	1.351474
SumSRA_Base_Core	153.400	1708.891	1.432341
SumSRA_Avx2	14.636	17911.182	15.012612
SumSRATraits	14.529	18042.836	15.122961
SumSRATraits_Core	12.649	20725.141	17.371188
SumSRAConstTraits	14.433	18163.434	15.224042
SumSRAConstTraits_Core	11.941	21952.651	18.400049
SumSRA128Traits	25.343	10343.697	8.669775
SumSRA128Traits_Core	22.464	11669.697	9.781188
SumSRA128ConstTraits	25.631	10227.651	8.572508
SumSRA128ConstTraits_Core	22.358	11725.080	9.827609
SumSRAFast_Avx2	12.993	20175.655	16.910626
SumSRAFastTraits	13.053	20083.459	16.833350

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	193.756	1352.958
SumSRA_Base_Basic	484.380	541.195	0.400008
SumSRA_Base	329.553	795.454	0.587937
SumSRA_Base_Core	306.761	854.554	0.631619
SumSRA_Avx2	29.044	9025.787	6.671153
SumSRATraits	28.561	9178.232	6.783828
SumSRATraits_Core	22.299	11755.884	8.689026
SumSRAConstTraits	28.131	9318.611	6.887585
SumSRAConstTraits_Core	24.735	10597.903	7.833137
SumSRA128Traits	50.624	5178.258	3.827362
SumSRA128Traits_Core	42.758	6130.943	4.531512
SumSRA128ConstTraits	50.615	5179.182	3.828045
SumSRA128ConstTraits_Core	42.823	6121.559	4.524576
SumSRAFast_Avx2	26.468	9904.295	7.320476
SumSRAFastTraits	27.463	9545.249	7.055098

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	194.128	1350.369
SumSRA_Base_Basic	536.557	488.567	0.361802
SumSRA_Base	536.212	488.881	0.362036
SumSRA_Base_Create	617.258	424.691	0.314500
SumSRA_Base_LoadArray	641.256	408.798	0.302731
SumSRA_Base_Core	536.545	488.578	0.361811
SumSRA_Avx2	81.423	3219.514	2.384174
SumSRATraits	82.314	3184.687	2.358383
SumSRATraits_Core	68.124	3848.049	2.849628
SumSRAConstTraits	81.292	3224.715	2.388025
SumSRAConstTraits_Core	68.017	3854.123	2.854126
SumSRA128Traits	138.548	1892.076	1.401155
SumSRA128Traits_Core	115.925	2261.331	1.674603
SumSRA128ConstTraits	136.751	1916.937	1.419566
SumSRA128ConstTraits_Core	116.296	2254.113	1.669257
SumSRAFast_Avx2	78.162	3353.874	2.483673
SumSRAFast_Avx2_Negative	100.177	2616.804	1.937844
SumSRAFastTraits	78.108	3356.166	2.485370

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	234.081	1119.888
SumSRA_Base128_Basic	398.216	658.295	0.587823
SumSRA_Base128_Basic_Ref	397.975	658.694	0.588179
SumSRA_Base_Basic	221.834	1181.715	1.055208
SumSRA_Base	81.421	3219.602	2.874933
SumSRA_Base_Core	76.660	3419.576	3.053499
SumSRA_Avx2	14.166	18504.842	16.523838
SumSRATraits	14.258	18386.183	16.417882
SumSRATraits_Core	8.376	31296.211	27.945849
SumSRAConstTraits	11.837	22145.325	19.774596
SumSRAConstTraits_Core	8.322	31498.676	28.126640
SumSRA128Traits	29.231	8968.038	8.007980
SumSRA128Traits_Core	14.825	17683.142	15.790104
SumSRA128ConstTraits	20.902	12541.420	11.198820
SumSRA128ConstTraits_Core	14.871	17627.373	15.740305
SumSRAFast_Avx2	10.716	24462.338	21.843565
SumSRAFastTraits	10.794	24286.313	21.686384

``` 

#### .NET 5.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	5.0.17
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.17\
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	218.569	1199.367
SumSRA_Base_Basic	265.109	988.818	0.824450
SumSRA_Base	163.681	1601.558	1.335337
SumSRA_Base_Core	153.138	1711.819	1.427269
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.294	18339.131	15.290681
SumSRATraits	14.400	18204.327	15.178286
SumSRATraits_Core	13.036	20109.157	16.766482
SumSRAConstTraits	13.530	19374.320	16.153794
SumSRAConstTraits_Core	13.500	19418.466	16.190602
SumSRA128Traits	25.630	10228.038	8.527867
SumSRA128Traits_Core	22.423	11690.713	9.747407
SumSRA128ConstTraits	22.506	11647.592	9.711454
SumSRA128ConstTraits_Core	22.506	11647.923	9.711729
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	11.887	22053.164	18.387344
SumSRAFastTraits	12.578	20841.444	17.377044

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	193.827	1352.467
SumSRA_Base_Basic	496.259	528.241	0.390576
SumSRA_Base	320.071	819.018	0.605573
SumSRA_Base_Core	315.814	830.059	0.613737
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	28.531	9188.153	6.793624
SumSRATraits	28.382	9236.354	6.829263
SumSRATraits_Core	22.373	11716.871	8.663331
SumSRAConstTraits	23.785	11021.465	8.149156
SumSRAConstTraits_Core	23.309	11246.438	8.315498
SumSRA128Traits	51.028	5137.243	3.798424
SumSRA128Traits_Core	42.896	6111.172	4.518536
SumSRA128ConstTraits	44.871	5842.198	4.319660
SumSRA128ConstTraits_Core	39.714	6600.870	4.880614
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	24.713	10607.503	7.843077
SumSRAFastTraits	25.064	10458.977	7.733258

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	195.309	1342.203
SumSRA_Base_Basic	559.281	468.716	0.349214
SumSRA_Base	571.912	458.364	0.341501
SumSRA_Base_Create	618.029	424.161	0.316019
SumSRA_Base_LoadArray	638.466	410.584	0.305903
SumSRA_Base_Core	559.703	468.363	0.348951
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	81.586	3213.113	2.393910
SumSRATraits	81.247	3226.498	2.403882
SumSRATraits_Core	68.001	3855.016	2.872156
SumSRAConstTraits	81.020	3235.547	2.410624
SumSRAConstTraits_Core	68.003	3854.902	2.872071
SumSRA128Traits	138.306	1895.394	1.412152
SumSRA128Traits_Core	115.121	2277.126	1.696558
SumSRA128ConstTraits	119.908	2186.209	1.628822
SumSRA128ConstTraits_Core	114.508	2289.301	1.705630
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	78.653	3332.934	2.483182
SumSRAFast_Avx2_Negative	100.044	2620.282	1.952225
SumSRAFastTraits	78.224	3351.205	2.496794

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	232.676	1126.648
SumSRA_Base128_Basic	397.719	659.118	0.585026
SumSRA_Base128_Basic_Ref	398.125	658.447	0.584430
SumSRA_Base_Basic	234.819	1116.367	0.990875
SumSRA_Base	82.506	3177.271	2.820110
SumSRA_Base_Core	76.438	3429.507	3.043993
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.151	18524.654	16.442278
SumSRATraits	14.142	18536.103	16.452439
SumSRATraits_Core	8.359	31360.721	27.835428
SumSRAConstTraits	9.222	28425.517	25.230174
SumSRAConstTraits_Core	8.327	31479.345	27.940717
SumSRA128Traits	29.283	8952.113	7.945796
SumSRA128Traits_Core	14.793	17720.560	15.728573
SumSRA128ConstTraits	16.381	16002.988	14.204075
SumSRA128ConstTraits_Core	14.901	17592.686	15.615073
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	9.794	26765.635	23.756881
SumSRAFastTraits	9.892	26500.990	23.521985

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.24
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.24\
RuntimeInformation.FrameworkDescription:	.NET 6.0.24
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.24/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	186.800	1403.341
SumSRA_Base_Basic	271.253	966.420	0.688656
SumSRA_Base	162.871	1609.517	1.146918
SumSRA_Base_Core	155.412	1686.769	1.201967
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.651	17892.176	12.749702
SumSRATraits	14.476	18109.365	12.904468
SumSRATraits_Core	11.946	21944.186	15.637105
SumSRAConstTraits	12.303	21308.042	15.183798
SumSRAConstTraits_Core	11.901	22027.138	15.696215
SumSRA128Traits	25.415	10314.569	7.350011
SumSRA128Traits_Core	22.441	11681.519	8.324079
SumSRA128ConstTraits	21.521	12181.129	8.680094
SumSRA128ConstTraits_Core	20.393	12854.584	9.159988
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	12.946	20249.540	14.429525
SumSRAFastTraits	12.916	20296.236	14.462800

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	158.384	1655.116
SumSRA_Base_Basic	495.316	529.246	0.319764
SumSRA_Base	327.359	800.784	0.483824
SumSRA_Base_Core	923.338	283.909	0.171534
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	28.223	9288.160	5.611788
SumSRATraits	29.536	8875.456	5.362437
SumSRATraits_Core	23.304	11248.856	6.796415
SumSRAConstTraits	23.333	11235.045	6.788070
SumSRAConstTraits_Core	23.403	11201.392	6.767738
SumSRA128Traits	50.663	5174.259	3.126221
SumSRA128Traits_Core	40.318	6501.870	3.928346
SumSRA128ConstTraits	42.885	6112.789	3.693269
SumSRA128ConstTraits_Core	42.829	6120.695	3.698046
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	27.216	9632.066	5.819571
SumSRAFastTraits	27.111	9669.190	5.842001

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	193.925	1351.779
SumSRA_Base_Basic	553.467	473.640	0.350382
SumSRA_Base	554.419	472.826	0.349781
SumSRA_Base_Create	618.040	424.154	0.313774
SumSRA_Base_LoadArray	639.909	409.658	0.303051
SumSRA_Base_Core	537.137	488.039	0.361035
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	81.531	3215.280	2.378554
SumSRATraits	81.461	3218.040	2.380596
SumSRATraits_Core	67.935	3858.747	2.854569
SumSRAConstTraits	67.966	3857.005	2.853281
SumSRAConstTraits_Core	68.147	3846.748	2.845693
SumSRA128Traits	138.438	1893.580	1.400806
SumSRA128Traits_Core	119.032	2202.295	1.629182
SumSRA128ConstTraits	114.131	2296.869	1.699145
SumSRA128ConstTraits_Core	113.888	2301.770	1.702771
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	78.644	3333.292	2.465855
SumSRAFast_Avx2_Negative	99.978	2622.024	1.939683
SumSRAFastTraits	78.184	3352.930	2.480383

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	186.662	1404.378
SumSRA_Base128_Basic	398.459	657.895	0.468460
SumSRA_Base128_Basic_Ref	397.897	658.824	0.469122
SumSRA_Base_Basic	233.308	1123.595	0.800066
SumSRA_Base	81.600	3212.566	2.287537
SumSRA_Base_Core	77.708	3373.462	2.402104
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.210	18447.697	13.135848
SumSRATraits	14.152	18522.999	13.189467
SumSRATraits_Core	8.368	31328.676	22.307864
SumSRAConstTraits	8.501	30836.577	21.957461
SumSRAConstTraits_Core	8.336	31447.480	22.392459
SumSRA128Traits	28.146	9313.649	6.631867
SumSRA128Traits_Core	14.924	17564.807	12.507178
SumSRA128ConstTraits	15.028	17443.902	12.421087
SumSRA128ConstTraits_Core	14.914	17577.020	12.515874
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	8.734	30013.622	21.371468
SumSRAFastTraits	8.885	29505.447	21.009617

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.13
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.13\
RuntimeInformation.FrameworkDescription:	.NET 7.0.13
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.13/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	160.453	1633.772
SumSRANetBcl	12.414	21116.651	12.925089
SumSRANetBcl_Const	11.491	22813.874	13.963927
SumSRA_Base_Basic	216.121	1212.951	0.742424
SumSRA_Base	12.492	20984.369	12.844122
SumSRA_Base_Core	13.294	19718.622	12.069383
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.731	17795.119	10.892045
SumSRATraits	14.032	18681.471	11.434563
SumSRATraits_Core	13.384	19586.359	11.988428
SumSRAConstTraits	12.859	20385.321	12.477457
SumSRAConstTraits_Core	12.658	20710.309	12.676375
SumSRA128Traits	21.843	12001.044	7.345605
SumSRA128Traits_Core	21.043	12457.610	7.625060
SumSRA128ConstTraits	20.008	13101.970	8.019460
SumSRA128ConstTraits_Core	20.140	13015.871	7.966761
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	12.742	20573.984	12.592934
SumSRAFastTraits	13.216	19834.879	12.140542

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	155.334	1687.610
SumSRANetBcl	23.413	11196.449	6.634499
SumSRANetBcl_Const	22.249	11782.312	6.981654
SumSRA_Base_Basic	495.946	528.573	0.313208
SumSRA_Base	23.426	11190.487	6.630965
SumSRA_Base_Core	24.384	10750.685	6.370360
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	27.948	9379.651	5.557948
SumSRATraits	24.430	10730.525	6.358413
SumSRATraits_Core	23.716	11053.369	6.549716
SumSRAConstTraits	23.042	11376.847	6.741394
SumSRAConstTraits_Core	25.128	10432.148	6.181609
SumSRA128Traits	42.086	6228.702	3.690841
SumSRA128Traits_Core	39.997	6554.065	3.883636
SumSRA128ConstTraits	40.620	6453.534	3.824066
SumSRA128ConstTraits_Core	40.174	6525.161	3.866509
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	24.335	10772.310	6.383173
SumSRAFastTraits	24.374	10755.118	6.372986

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	155.696	1683.693
SumSRANetBcl	444.102	590.279	0.350586
SumSRANetBcl_Const	464.104	564.839	0.335476
SumSRA_Base_Basic	534.033	490.876	0.291548
SumSRA_Base	114.581	2287.847	1.358827
SumSRA_Base_Create	84.337	3108.309	1.846126
SumSRA_Base_LoadArray	88.637	2957.485	1.756547
SumSRA_Base_Core	83.632	3134.477	1.861668
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	82.026	3195.879	1.898136
SumSRATraits	81.721	3207.783	1.905207
SumSRATraits_Core	70.252	3731.461	2.216236
SumSRAConstTraits	70.159	3736.409	2.219175
SumSRAConstTraits_Core	74.358	3525.451	2.093880
SumSRA128Traits	137.631	1904.689	1.131257
SumSRA128Traits_Core	117.789	2225.535	1.321818
SumSRA128ConstTraits	107.120	2447.205	1.453475
SumSRA128ConstTraits_Core	106.503	2461.380	1.461894
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	78.416	3342.997	1.985515
SumSRAFast_Avx2_Negative	100.010	2621.174	1.556800
SumSRAFastTraits	78.266	3349.395	1.989315

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	161.407	1624.119
SumSRANetBcl	222.154	1180.012	0.726555
SumSRANetBcl_Const	222.707	1177.082	0.724751
SumSRA_Base128_Basic	167.826	1562.003	0.961754
SumSRA_Base128_Basic_Ref	167.714	1563.038	0.962392
SumSRA_Base_Basic	203.477	1288.323	0.793244
SumSRA_Base	12.947	20247.087	12.466506
SumSRA_Base_Core	9.612	27273.709	16.792928
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	12.325	21268.607	13.095475
SumSRATraits	12.359	21210.612	13.059767
SumSRATraits_Core	7.983	32838.468	20.219253
SumSRAConstTraits	7.882	33258.277	20.477738
SumSRAConstTraits_Core	7.668	34186.649	21.049353
SumSRA128Traits	24.341	10769.494	6.630977
SumSRA128Traits_Core	14.044	18665.642	11.492781
SumSRA128ConstTraits	14.842	17662.646	10.875218
SumSRA128ConstTraits_Core	14.842	17661.984	10.874811
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	8.188	32016.128	19.712923
SumSRAFastTraits	8.247	31784.911	19.570558

``` 


## Arm

### AWS Arm t4g.small
`AWS Arm t4g.small`

#### .NET Core 3.1
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	
Vector128s.Instance:	WVectorTraits128Base	// 
Vectors.Instance:	VectorTraits128Base	// 
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	431.280	607.828
SumSRA_Base_Basic	501.230	523.001	0.860443
SumSRA_Base	163.161	1606.660	2.643281
SumSRA_Base_Core	141.360	1854.449	3.050944
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	161.709	1621.081	2.667006
SumSRATraits_Core	137.288	1909.445	3.141424
SumSRAConstTraits	138.614	1891.182	3.111378
SumSRAConstTraits_Core	137.481	1906.767	3.137018
SumSRA128Traits	895.614	292.698	0.481547
SumSRA128Traits_Core	887.957	295.222	0.485699
SumSRA128ConstTraits	900.677	291.052	0.478840
SumSRA128ConstTraits_Core	896.652	292.359	0.480989
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	142.613	1838.148	3.024126

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	349.229	750.637
SumSRA_Base_Basic	799.178	328.017	0.436985
SumSRA_Base	302.747	865.885	1.153533
SumSRA_Base_Core	283.855	923.515	1.230308
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	322.071	813.933	1.084324
SumSRATraits_Core	272.068	963.525	1.283610
SumSRAConstTraits	278.832	940.151	1.252472
SumSRAConstTraits_Core	275.954	949.954	1.265531
SumSRA128Traits	1446.132	181.273	0.241492
SumSRA128Traits_Core	1447.417	181.112	0.241277
SumSRA128ConstTraits	1447.364	181.118	0.241286
SumSRA128ConstTraits_Core	1445.898	181.302	0.241531
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	285.097	919.492	1.224949

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	352.789	743.062
SumSRA_Base_Basic	547.618	478.699	0.644225
SumSRA_Base	1250.187	209.684	0.282189
SumSRA_Base_Create	1270.519	206.328	0.277673
SumSRA_Base_LoadArray	674.171	388.839	0.523293
SumSRA_Base_Core	545.448	480.603	0.646788
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	556.465	471.088	0.633982
SumSRATraits_Core	555.967	471.510	0.634550
SumSRAConstTraits	556.053	471.437	0.634452
SumSRAConstTraits_Core	557.376	470.318	0.632946
SumSRA128Traits	1022.878	256.281	0.344898
SumSRA128Traits_Core	1015.561	258.127	0.347383
SumSRA128ConstTraits	1017.527	257.629	0.346712
SumSRA128ConstTraits_Core	1030.121	254.479	0.342473
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	556.340	471.194	0.634124

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	429.494	610.356
SumSRA_Base128_Basic	569.373	460.408	0.754328
SumSRA_Base128_Basic_Ref	564.452	464.422	0.760905
SumSRA_Base_Basic	365.136	717.935	1.176256
SumSRA_Base	81.229	3227.227	5.287455
SumSRA_Base_Core	70.268	3730.648	6.112254
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	80.817	3243.691	5.314429
SumSRATraits_Core	67.856	3863.241	6.329492
SumSRAConstTraits	69.163	3790.213	6.209845
SumSRAConstTraits_Core	68.791	3810.742	6.243480
SumSRA128Traits	563.738	465.010	0.761868
SumSRA128Traits_Core	566.230	462.964	0.758515
SumSRA128ConstTraits	565.615	463.467	0.759339
SumSRA128ConstTraits_Core	564.287	464.558	0.761127
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	70.611	3712.494	6.082511

```

#### .NET 5.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
Check-SumSRAConstTraits	Check `SumSRAConstTraits` mismatch. -24614!=-12499
Check-SumSRA128ConstTraits	Check `SumSRA128ConstTraits` mismatch. -24614!=-12499
SumSRAScalar	431.623	607.345
SumSRA_Base_Basic	500.990	523.252	0.861540
SumSRA_Base	154.493	1696.802	2.793801
SumSRA_Base_Core	134.018	1956.042	3.220642
SumSRA_AdvSimd	46.565	5629.659	9.269290
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	52.863	4958.905	8.164887
SumSRATraits_Core	31.089	8432.141	13.883605
SumSRAConstTraits	39.535	6630.722	10.917550
SumSRAConstTraits_Core	31.105	8427.578	13.876091
SumSRA128Traits	46.448	5643.810	9.292589
SumSRA128Traits_Core	31.118	8424.151	13.870449
SumSRA128ConstTraits	33.372	7855.149	12.933582
SumSRA128ConstTraits_Core	31.128	8421.416	13.865946
SumSRAFast_AdvSimd	33.399	7848.911	12.923310
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	39.688	6605.093	10.875351

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	350.404	748.119
SumSRA_Base_Basic	792.410	330.819	0.442200
SumSRA_Base	289.255	906.274	1.211404
SumSRA_Base_Core	271.731	964.718	1.289524
SumSRA_AdvSimd	89.169	2939.852	3.929656
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	106.093	2470.893	3.302806
SumSRATraits_Core	66.975	3914.050	5.231853
SumSRAConstTraits	67.470	3885.333	5.193467
SumSRAConstTraits_Core	66.937	3916.259	5.234806
SumSRA128Traits	89.103	2942.021	3.932556
SumSRA128Traits_Core	67.133	3904.869	5.219581
SumSRA128ConstTraits	80.101	3272.652	4.374506
SumSRA128ConstTraits_Core	66.922	3917.178	5.236034
SumSRAFast_AdvSimd	67.862	3862.874	5.163446
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	67.827	3864.866	5.166109

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	353.309	741.969
SumSRA_Base_Basic	552.020	474.881	0.640029
SumSRA_Base	551.306	475.496	0.640858
SumSRA_Base_Create	547.026	479.217	0.645872
SumSRA_Base_LoadArray	639.023	410.226	0.552889
SumSRA_Base_Core	544.768	481.203	0.648549
SumSRA_AdvSimd	212.966	1230.920	1.658993
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	186.032	1409.135	1.899184
SumSRATraits_Core	124.789	2100.695	2.831245
SumSRAConstTraits	133.654	1961.367	2.643464
SumSRAConstTraits_Core	133.185	1968.264	2.652759
SumSRA128Traits	213.138	1229.928	1.657655
SumSRA128Traits_Core	125.313	2091.913	2.819410
SumSRA128ConstTraits	134.095	1954.913	2.634766
SumSRA128ConstTraits_Core	133.349	1965.847	2.649501
SumSRAFast_AdvSimd	133.935	1957.254	2.637920
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	133.995	1956.370	2.636729

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	429.693	610.073
SumSRA_Base128_Basic	551.455	475.368	0.779198
SumSRA_Base128_Basic_Ref	547.174	479.087	0.785294
SumSRA_Base_Basic	368.287	711.793	1.166733
SumSRA_Base	76.327	3434.471	5.629603
SumSRA_Base_Core	67.775	3867.873	6.340015
SumSRA_AdvSimd	23.289	11256.112	18.450426
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.238	11280.956	18.491149
SumSRATraits_Core	15.588	16817.227	27.565914
SumSRAConstTraits	16.773	15628.914	25.618094
SumSRAConstTraits_Core	15.588	16816.889	27.565360
SumSRA128Traits	23.262	11269.353	18.472130
SumSRA128Traits_Core	16.649	15745.013	25.808397
SumSRA128ConstTraits	16.717	15681.627	25.704498
SumSRA128ConstTraits_Core	16.623	15769.839	25.849090
SumSRAFast_AdvSimd	19.900	13172.874	21.592282
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	19.908	13167.475	21.583432

```

#### .NET 6.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	438.074	598.402
SumSRA_Base_Basic	507.666	516.371	0.862918
SumSRA_Base	351.097	746.642	1.247727
SumSRA_Base_Core	137.261	1909.820	3.191535
SumSRA_AdvSimd	47.418	5528.339	9.238511
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	53.604	4890.378	8.172403
SumSRATraits_Core	31.716	8265.428	13.812512
SumSRAConstTraits	31.980	8197.125	13.698369
SumSRAConstTraits_Core	31.629	8288.203	13.850572
SumSRA128Traits	47.089	5566.951	9.303037
SumSRA128Traits_Core	32.045	8180.479	13.670552
SumSRA128ConstTraits	33.945	7722.716	12.905576
SumSRA128ConstTraits_Core	32.043	8180.930	13.671306
SumSRAFast_AdvSimd	31.991	8194.233	13.693537
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	33.953	7720.844	12.902448

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	354.110	740.289
SumSRA_Base_Basic	799.693	327.806	0.442808
SumSRA_Base	292.593	895.934	1.210249
SumSRA_Base_Core	272.792	960.968	1.298098
SumSRA_AdvSimd	90.300	2903.020	3.921469
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	107.240	2444.451	3.302022
SumSRATraits_Core	67.947	3858.082	5.211589
SumSRAConstTraits	64.175	4084.852	5.517915
SumSRAConstTraits_Core	64.138	4087.165	5.521039
SumSRA128Traits	107.061	2448.542	3.307548
SumSRA128Traits_Core	64.033	4093.903	5.530141
SumSRA128ConstTraits	63.635	4119.499	5.564716
SumSRA128ConstTraits_Core	67.810	3865.873	5.222113
SumSRAFast_AdvSimd	63.957	4098.781	5.536731
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	67.471	3885.305	5.248362

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	353.813	740.910
SumSRA_Base_Basic	553.625	473.504	0.639085
SumSRA_Base	544.359	481.564	0.649963
SumSRA_Base_Create	554.506	472.752	0.638069
SumSRA_Base_LoadArray	609.897	429.817	0.580119
SumSRA_Base_Core	547.480	478.819	0.646258
SumSRA_AdvSimd	187.624	1397.176	1.885755
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	214.139	1224.179	1.652263
SumSRATraits_Core	134.350	1951.205	2.633524
SumSRAConstTraits	134.569	1948.020	2.629225
SumSRAConstTraits_Core	126.500	2072.287	2.796947
SumSRA128Traits	188.311	1392.079	1.878876
SumSRA128Traits_Core	134.358	1951.087	2.633364
SumSRA128ConstTraits	126.553	2071.421	2.795778
SumSRA128ConstTraits_Core	127.634	2053.870	2.772089
SumSRAFast_AdvSimd	126.403	2073.874	2.799088
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	135.550	1933.926	2.610202

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	399.215	656.649
SumSRA_Base128_Basic	549.259	477.269	0.726824
SumSRA_Base128_Basic_Ref	556.607	470.968	0.717229
SumSRA_Base_Basic	371.207	706.193	1.075449
SumSRA_Base	77.779	3370.373	5.132683
SumSRA_Base_Core	67.740	3869.859	5.893341
SumSRA_AdvSimd	26.794	9783.594	14.899266
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	26.689	9822.260	14.958151
SumSRATraits_Core	16.695	15701.835	23.912053
SumSRAConstTraits	16.611	15781.410	24.033237
SumSRAConstTraits_Core	15.694	16703.652	25.437703
SumSRA128Traits	23.223	11287.905	17.190155
SumSRA128Traits_Core	16.672	15723.169	23.944542
SumSRA128ConstTraits	15.757	16637.017	25.336226
SumSRA128ConstTraits_Core	15.724	16671.725	25.389081
SumSRAFast_AdvSimd	15.643	16758.243	25.520838
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	15.667	16732.268	25.481281

```

#### .NET 7.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	318.513	823.024
SumSRANetBcl	26.335	9954.129	12.094585
SumSRANetBcl_Const	26.342	9951.495	12.091385
SumSRA_Base_Basic	477.114	549.437	0.667584
SumSRA_Base	26.319	9960.099	12.101838
SumSRA_Base_Core	26.373	9939.727	12.077086
SumSRA_AdvSimd	46.091	5687.521	6.910520
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	26.350	9948.477	12.087718
SumSRATraits_Core	26.340	9952.180	12.092217
SumSRAConstTraits	26.388	9934.293	12.070484
SumSRAConstTraits_Core	26.380	9937.380	12.074235
SumSRA128Traits	26.363	9943.661	12.081865
SumSRA128Traits_Core	26.370	9941.077	12.078726
SumSRA128ConstTraits	26.406	9927.420	12.062132
SumSRA128ConstTraits_Core	26.401	9929.214	12.064312
SumSRAFast_AdvSimd	26.322	9959.014	12.100520
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	26.344	9950.795	12.090533

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	222.811	1176.531
SumSRANetBcl	53.868	4866.387	4.136216
SumSRANetBcl_Const	53.825	4870.302	4.139544
SumSRA_Base_Basic	774.110	338.639	0.287829
SumSRA_Base	53.832	4869.642	4.138983
SumSRA_Base_Core	53.983	4856.067	4.127445
SumSRA_AdvSimd	79.757	3286.766	2.793608
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	53.822	4870.535	4.139742
SumSRATraits_Core	53.836	4869.283	4.138677
SumSRAConstTraits	54.120	4843.771	4.116993
SumSRAConstTraits_Core	54.025	4852.290	4.124234
SumSRA128Traits	53.871	4866.181	4.136041
SumSRA128Traits_Core	54.089	4846.512	4.119323
SumSRA128ConstTraits	54.182	4838.237	4.112290
SumSRA128ConstTraits_Core	54.159	4840.303	4.114046
SumSRAFast_AdvSimd	53.884	4864.979	4.135019
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	53.851	4867.942	4.137538

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	221.667	1182.604
SumSRANetBcl	106.489	2461.702	2.081594
SumSRANetBcl_Const	106.451	2462.585	2.082341
SumSRA_Base_Basic	540.403	485.090	0.410188
SumSRA_Base	106.740	2455.917	2.076703
SumSRA_Base_Create	147.475	1777.550	1.503081
SumSRA_Base_LoadArray	198.409	1321.231	1.117222
SumSRA_Base_Core	106.438	2462.884	2.082594
SumSRA_AdvSimd	185.085	1416.348	1.197652
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	185.167	1415.718	1.197119
SumSRATraits_Core	106.594	2459.283	2.079549
SumSRAConstTraits	106.570	2459.839	2.080019
SumSRAConstTraits_Core	106.640	2458.221	2.078651
SumSRA128Traits	185.083	1416.358	1.197660
SumSRA128Traits_Core	106.657	2457.825	2.078316
SumSRA128ConstTraits	106.581	2459.579	2.079800
SumSRA128ConstTraits_Core	106.716	2456.472	2.077172
SumSRAFast_AdvSimd	106.286	2466.410	2.085576
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	106.616	2458.773	2.079118

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	283.143	925.837
SumSRANetBcl	13.238	19802.147	21.388384
SumSRANetBcl_Const	13.236	19805.305	21.391794
SumSRA_Base128_Basic	268.523	976.242	1.054444
SumSRA_Base128_Basic_Ref	268.549	976.148	1.054341
SumSRA_Base_Basic	344.388	761.188	0.822163
SumSRA_Base	32.926	7961.707	8.599474
SumSRA_Base_Core	23.143	11326.963	12.234301
SumSRA_AdvSimd	23.123	11336.728	12.244848
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.075	11360.525	12.270552
SumSRATraits_Core	13.234	19808.274	21.395001
SumSRAConstTraits	13.258	19773.174	21.357090
SumSRAConstTraits_Core	13.249	19785.247	21.370130
SumSRA128Traits	23.098	11349.048	12.258155
SumSRA128Traits_Core	13.233	19810.270	21.397158
SumSRA128ConstTraits	13.256	19775.467	21.359567
SumSRA128ConstTraits_Core	13.252	19781.344	21.365914
SumSRAFast_AdvSimd	13.214	19838.051	21.427164
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	13.232	19810.999	21.397945

```

