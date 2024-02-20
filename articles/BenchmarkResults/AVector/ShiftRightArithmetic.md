# Benchmark - ShiftRightArithmetic
([← Back](README.md))

See [Group](ShiftRightArithmetic_Group.md)

## X86

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
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	446.370	587.279
SumSRA_Base_Basic	524.311	499.978	0.851347
SumSRA_Base	169.016	1550.998	2.640990
SumSRA_Base_Core	148.814	1761.556	2.999521
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	168.134	1559.138	2.654850
SumSRATraits_Core	143.758	1823.509	3.105013
SumSRAConstTraits	144.914	1808.965	3.080247
SumSRAConstTraits_Core	144.789	1810.527	3.082907
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	149.417	1754.440	2.987405

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	367.834	712.668
SumSRA_Base_Basic	824.375	317.991	0.446198
SumSRA_Base	316.041	829.461	1.163881
SumSRA_Base_Core	300.706	871.763	1.223237
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	336.174	779.787	1.094179
SumSRATraits_Core	286.701	914.346	1.282990
SumSRAConstTraits	296.237	884.914	1.241691
SumSRAConstTraits_Core	284.819	920.389	1.291468
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	299.356	875.693	1.228752

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	365.286	717.640
SumSRA_Base_Basic	1330.569	197.017	0.274534
SumSRA_Base	571.528	458.672	0.639140
SumSRA_Base_Create	592.009	442.804	0.617029
SumSRA_Base_LoadArray	726.084	361.038	0.503091
SumSRA_Base_Core	1313.846	199.524	0.278028
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	580.022	451.956	0.629781
SumSRATraits_Core	602.380	435.180	0.606405
SumSRAConstTraits	598.777	437.799	0.610054
SumSRAConstTraits_Core	600.670	436.419	0.608131
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	603.611	434.293	0.605168

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	453.720	577.766
SumSRA_Base_Basic	393.284	666.552	1.153671
SumSRA_Base	86.602	3026.992	5.239132
SumSRA_Base_Core	76.370	3432.558	5.941086
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	87.638	2991.228	5.177231
SumSRATraits_Core	74.276	3529.326	6.108573
SumSRAConstTraits	75.412	3476.138	6.016515
SumSRAConstTraits_Core	73.267	3577.927	6.192692
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	75.831	3456.946	5.983298

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

#### .NET 5.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
Check-SumSRAConstTraits	Check `SumSRAConstTraits` mismatch. -24614!=-12499
SumSRAScalar	484.406	541.166
SumSRA_Base_Basic	558.961	468.984	0.866619
SumSRA_Base	174.180	1505.018	2.781065
SumSRA_Base_Core	153.409	1708.796	3.157619
SumSRA_AdvSimd	53.113	4935.548	9.120211
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	52.953	4950.480	9.147803
SumSRATraits_Core	31.249	8388.956	15.501632
SumSRAConstTraits	39.780	6589.881	12.177190
SumSRAConstTraits_Core	31.234	8392.943	15.509000
SumSRAFast_AdvSimd	33.441	7839.053	14.485488
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	39.793	6587.622	12.173017

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	351.086	746.666
SumSRA_Base_Basic	793.372	330.418	0.442524
SumSRA_Base	667.019	393.008	0.526351
SumSRA_Base_Core	273.014	960.185	1.285964
SumSRA_AdvSimd	93.338	2808.552	3.761458
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	89.038	2944.169	3.943088
SumSRATraits_Core	63.539	4125.748	5.525562
SumSRAConstTraits	80.258	3266.272	4.374476
SumSRAConstTraits_Core	63.409	4134.164	5.536833
SumSRAFast_AdvSimd	68.421	3831.355	5.131286
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	68.172	3845.319	5.149987

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	353.122	742.361
SumSRA_Base_Basic	541.363	484.230	0.652283
SumSRA_Base	541.164	484.408	0.652523
SumSRA_Base_Create	545.533	480.529	0.647298
SumSRA_Base_LoadArray	650.260	403.137	0.543047
SumSRA_Base_Core	549.167	477.348	0.643013
SumSRA_AdvSimd	186.158	1408.181	1.896895
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	212.189	1235.429	1.664188
SumSRATraits_Core	132.884	1972.734	2.657378
SumSRAConstTraits	133.605	1962.084	2.643031
SumSRAConstTraits_Core	124.872	2099.303	2.827872
SumSRAFast_AdvSimd	133.786	1959.429	2.639454
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	133.777	1959.553	2.639622

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	429.274	610.669
SumSRA_Base_Basic	367.815	712.706	1.167091
SumSRA_Base	77.118	3399.260	5.566454
SumSRA_Base_Core	66.977	3913.964	6.409307
SumSRA_AdvSimd	23.283	11259.027	18.437205
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.237	11281.229	18.473562
SumSRATraits_Core	15.587	16818.297	27.540782
SumSRAConstTraits	16.717	15680.873	25.678193
SumSRAConstTraits_Core	15.592	16813.202	27.532438
SumSRAFast_AdvSimd	16.748	15651.930	25.630798
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	16.707	15691.023	25.694815

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

#### .NET 6.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	431.705	607.230
SumSRA_Base_Basic	499.842	524.454	0.863682
SumSRA_Base	374.423	700.127	1.152985
SumSRA_Base_Core	135.073	1940.752	3.196073
SumSRA_AdvSimd	46.442	5644.488	9.295468
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	46.434	5645.497	9.297130
SumSRATraits_Core	33.164	7904.366	13.017084
SumSRAConstTraits	33.215	7892.407	12.997391
SumSRAConstTraits_Core	33.199	7896.220	13.003670
SumSRAFast_AdvSimd	33.189	7898.538	13.007488
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	31.162	8412.310	13.853578

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	350.903	747.055
SumSRA_Base_Basic	790.944	331.432	0.443651
SumSRA_Base	666.696	393.199	0.526332
SumSRA_Base_Core	270.425	969.376	1.297597
SumSRA_AdvSimd	106.249	2467.260	3.302648
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	89.012	2945.026	3.942181
SumSRATraits_Core	63.391	4135.353	5.535540
SumSRAConstTraits	67.354	3892.016	5.209812
SumSRAConstTraits_Core	67.336	3893.088	5.211247
SumSRAFast_AdvSimd	63.524	4126.674	5.523922
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	67.198	3901.047	5.221901

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	353.133	742.337
SumSRA_Base_Basic	542.201	483.481	0.651296
SumSRA_Base	542.529	483.189	0.650903
SumSRA_Base_Create	541.613	484.006	0.652003
SumSRA_Base_LoadArray	601.682	435.685	0.586910
SumSRA_Base_Core	549.734	476.856	0.642372
SumSRA_AdvSimd	186.112	1408.528	1.897424
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	212.466	1233.818	1.662072
SumSRATraits_Core	133.271	1966.992	2.649729
SumSRAConstTraits	133.275	1966.946	2.649666
SumSRAConstTraits_Core	124.991	2097.296	2.825260
SumSRAFast_AdvSimd	124.931	2098.306	2.826621
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	133.046	1970.332	2.654228

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	389.639	672.786
SumSRA_Base_Basic	368.363	711.647	1.057760
SumSRA_Base	76.118	3443.934	5.118911
SumSRA_Base_Core	154.119	1700.917	2.528167
SumSRA_AdvSimd	23.394	11205.761	16.655746
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.248	11275.758	16.759786
SumSRATraits_Core	15.578	16827.844	25.012161
SumSRAConstTraits	15.576	16829.920	25.015247
SumSRAConstTraits_Core	16.631	15762.243	23.428299
SumSRAFast_AdvSimd	16.591	15800.184	23.484693
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	16.612	15780.403	23.455291

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

#### .NET 7.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	318.685	822.580
SumSRANetBcl	26.369	9941.333	12.085549
SumSRANetBcl_Const	26.377	9938.477	12.082077
SumSRA_Base_Basic	477.864	548.575	0.666895
SumSRA_Base	26.360	9944.813	12.089780
SumSRA_Base_Core	26.379	9937.640	12.081059
SumSRA_AdvSimd	46.091	5687.558	6.914290
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	26.377	9938.217	12.081761
SumSRATraits_Core	26.376	9938.584	12.082207
SumSRAConstTraits	26.556	9871.343	12.000463
SumSRAConstTraits_Core	26.411	9925.543	12.066353
SumSRAFast_AdvSimd	26.362	9944.129	12.088949
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	26.380	9937.396	12.080763

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	220.558	1188.551
SumSRANetBcl	53.918	4861.897	4.090610
SumSRANetBcl_Const	53.941	4859.816	4.088859
SumSRA_Base_Basic	772.611	339.296	0.285471
SumSRA_Base	54.095	4846.014	4.077247
SumSRA_Base_Core	54.067	4848.500	4.079338
SumSRA_AdvSimd	79.784	3285.681	2.764444
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	53.841	4868.865	4.096473
SumSRATraits_Core	53.916	4862.075	4.090760
SumSRAConstTraits	54.147	4841.364	4.073334
SumSRAConstTraits_Core	54.113	4844.364	4.075859
SumSRAFast_AdvSimd	53.813	4871.387	4.098595
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	53.814	4871.318	4.098537

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	220.303	1189.925
SumSRANetBcl	106.209	2468.196	2.074245
SumSRANetBcl_Const	106.070	2471.434	2.076967
SumSRA_Base_Basic	551.948	474.944	0.399137
SumSRA_Base	106.280	2466.542	2.072855
SumSRA_Base_Create	147.056	1782.609	1.498086
SumSRA_Base_LoadArray	197.744	1325.673	1.114081
SumSRA_Base_Core	106.211	2468.146	2.074204
SumSRA_AdvSimd	184.537	1420.547	1.193813
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	184.593	1420.116	1.193450
SumSRATraits_Core	106.306	2465.932	2.072343
SumSRAConstTraits	106.096	2470.825	2.076455
SumSRAConstTraits_Core	106.168	2469.149	2.075046
SumSRAFast_AdvSimd	106.220	2467.935	2.074026
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	106.463	2462.309	2.069298

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	283.241	925.515
SumSRANetBcl	13.244	19792.701	21.385605
SumSRANetBcl_Const	13.245	19792.641	21.385540
SumSRA_Base_Basic	344.059	761.916	0.823235
SumSRA_Base	32.907	7966.148	8.607258
SumSRA_Base_Core	23.107	11344.947	12.257981
SumSRA_AdvSimd	23.097	11349.802	12.263226
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.082	11356.994	12.270997
SumSRATraits_Core	13.240	19798.924	21.392328
SumSRAConstTraits	13.257	19774.470	21.365907
SumSRAConstTraits_Core	13.267	19759.552	21.349788
SumSRAFast_AdvSimd	13.212	19841.339	21.438157
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	13.247	19789.471	21.382115

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

