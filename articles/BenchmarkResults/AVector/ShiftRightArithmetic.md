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

