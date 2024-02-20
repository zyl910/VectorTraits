# Benchmark - ShiftLeft
([← Back](README.md))

See [Group](ShiftLeft_Group.md)

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9181.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	307.182	853.384
SumSLL_Basic	33.201	7895.665	9.252188
SumSLL_Base_Core	7.994	32791.342	38.425094
SumSLL_Multiply	31.011	8453.374	9.905715
SumSLLTraits	47.835	5480.183	6.421712
SumSLLTraits_Core	14.391	18216.062	21.345692
SumSLLConstTraits	23.475	11167.138	13.085720
SumSLLConstTraits_Core	7.636	34331.575	40.229948
SumSLLFast_Multiply	25.928	10110.465	11.847504
SumSLLFastTraits	24.910	10523.754	12.331798

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	318.717	822.499
SumSLL_Basic	47.549	5513.095	6.702863
SumSLL_Base_Core	13.206	19850.255	24.134091
SumSLL_Base_Core_Element	51.658	5074.626	6.169768
SumSLL_Base_Core_Mov	54.703	4792.145	5.826326
SumSLL_Multiply	52.771	4967.597	6.039642
SumSLLTraits	51.705	5070.018	6.164167
SumSLLTraits_Core	12.492	20985.011	25.513736
SumSLLConstTraits	45.787	5725.282	6.960841
SumSLLConstTraits_Core	12.986	20187.378	24.543968
SumSLLFast_Multiply	45.714	5734.456	6.971995
SumSLLFastTraits	45.747	5730.266	6.966902

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	317.400	825.911
SumSLL_Basic	103.934	2522.211	3.053854
SumSLL_Base_Core	32.408	8088.798	9.793794
SumSLL_Multiply	93.893	2791.950	3.380450
SumSLLTraits	93.905	2791.590	3.380015
SumSLLTraits_Core	28.533	9187.514	11.124103
SumSLLConstTraits	85.401	3069.549	3.716563
SumSLLConstTraits_Core	30.790	8514.029	10.308656
SumSLLFast_Multiply	81.420	3219.649	3.898302
SumSLLFastTraits	80.249	3266.638	3.955196

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	318.332	823.494
SumSLL_Basic	561.261	467.062	0.567172
SumSLL_Base_Core	562.426	466.095	0.565997
SumSLLTraits	559.776	468.301	0.568676
SumSLLTraits_Core	564.497	464.385	0.563921
SumSLLConstTraits	483.959	541.666	0.657766
SumSLLConstTraits_Core	484.704	540.833	0.656754
SumSLLFastTraits	524.226	500.060	0.607241

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Vector128 type is not supported! Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Vector128 type is not supported! Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	318.405	823.304
SumSLL_Basic	34.190	7667.323	9.312872
SumSLL_Base_Core	7.547	34735.484	42.190361
SumSLL_Multiply	29.748	8812.012	10.703233
SumSLLTraits	29.705	8824.873	10.718854
SumSLLTraits_Core	6.988	37513.886	45.565059
SumSLLConstTraits	27.874	9404.750	11.423183
SumSLLConstTraits_Core	7.998	32777.144	39.811725
SumSLLFast_Multiply	23.255	11272.642	13.691960
SumSLLFastTraits	23.899	10968.897	13.323025

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	321.547	815.259
SumSLL_Basic	48.210	5437.536	6.669707
SumSLL_Base_Core	12.920	20289.099	24.886703
SumSLL_Base_Core_Element	55.240	4745.586	5.820958
SumSLL_Base_Core_Mov	53.231	4924.650	6.040599
SumSLL_Multiply	49.992	5243.761	6.432021
SumSLLTraits	50.960	5144.087	6.309760
SumSLLTraits_Core	13.970	18765.012	23.017251
SumSLLConstTraits	47.379	5532.866	6.786639
SumSLLConstTraits_Core	14.404	18199.964	22.324159
SumSLLFast_Multiply	46.881	5591.679	6.858779
SumSLLFastTraits	44.450	5897.488	7.233886

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	321.112	816.364
SumSLL_Basic	111.054	2360.516	2.891499
SumSLL_Base_Core	34.156	7674.876	9.401292
SumSLL_Multiply	97.290	2694.473	3.300578
SumSLLTraits	101.620	2579.646	3.159922
SumSLLTraits_Core	30.653	8551.941	10.475647
SumSLLConstTraits	91.310	2870.920	3.516715
SumSLLConstTraits_Core	30.790	8513.920	10.429073
SumSLLFast_Multiply	81.198	3228.436	3.954652
SumSLLFastTraits	84.665	3096.263	3.792748

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	329.555	795.448
SumSLL_Basic	573.726	456.915	0.574412
SumSLL_Base_Core	597.571	438.683	0.551492
SumSLLTraits	567.436	461.980	0.580780
SumSLLTraits_Core	564.672	464.241	0.583622
SumSLLConstTraits	488.568	536.556	0.674533
SumSLLConstTraits_Core	483.763	541.885	0.681232
SumSLLFastTraits	527.552	496.906	0.624688

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Vector128 type is not supported! Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Vector128 type is not supported! Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	235.177	1114.668
SumSLL_Basic	18.198	14404.884	12.923032
SumSLL_Base_Core	6.196	42310.002	37.957509
SumSLL_Multiply	16.719	15679.849	14.066840
SumSLL_Avx2	11.844	22132.593	19.855780
SumSLLTraits	11.852	22117.945	19.842639
SumSLLTraits_Core	6.782	38654.504	34.678057
SumSLLConstTraits	9.987	26249.415	23.549098
SumSLLConstTraits_Core	6.809	38501.136	34.540467
SumSLL128Traits	25.100	10443.985	9.369597
SumSLL128Traits_Core	11.639	22522.197	20.205305
SumSLL128ConstTraits	19.811	13232.127	11.870919
SumSLL128ConstTraits_Core	11.759	22292.974	19.999662
SumSLLFast_Multiply	9.971	26289.342	23.584918
SumSLLFast_Avx2	9.916	26437.406	23.717751
SumSLLFastTraits	10.122	25898.387	23.234181

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	223.690	1171.910
SumSLL_Basic	23.028	11383.541	9.713665
SumSLL_Base_Core	11.702	22402.523	19.116248
SumSLL_Base_Core_Element	24.854	10547.470	9.000238
SumSLL_Base_Core_Mov	25.584	10246.339	8.743281
SumSLL_Multiply	22.707	11544.818	9.851283
SumSLL_Avx2	15.601	16802.630	14.337815
SumSLLTraits	15.790	16601.649	14.166317
SumSLLTraits_Core	17.900	14645.055	12.496740
SumSLLConstTraits	16.719	15679.676	13.379590
SumSLLConstTraits_Core	13.146	19941.424	17.016173
SumSLL128Traits	27.625	9489.397	8.097376
SumSLL128Traits_Core	23.538	11137.258	9.503509
SumSLL128ConstTraits	26.036	10068.604	8.591618
SumSLL128ConstTraits_Core	22.903	11445.996	9.766958
SumSLLFast_Multiply	16.957	15459.256	13.191504
SumSLLFast_Avx2	14.274	18365.604	15.671513
SumSLLFastTraits	14.777	17739.662	15.137392

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	200.234	1309.191
SumSLL_Basic	42.878	6113.749	4.669869
SumSLL_Base_Core	30.130	8700.323	6.645573
SumSLL_Multiply	44.393	5905.135	4.510523
SumSLL_Avx2	32.100	8166.367	6.237721
SumSLLTraits	31.289	8378.096	6.399446
SumSLLTraits_Core	25.037	10470.154	7.997424
SumSLLConstTraits	31.085	8433.174	6.441517
SumSLLConstTraits_Core	24.914	10521.964	8.036998
SumSLL128Traits	51.650	5075.419	3.876761
SumSLL128Traits_Core	44.907	5837.496	4.458858
SumSLL128ConstTraits	51.849	5055.877	3.861833
SumSLL128ConstTraits_Core	44.299	5917.662	4.520091
SumSLLFast_Multiply	34.491	7600.457	5.805462
SumSLLFast_Avx2	28.887	9074.834	6.931636
SumSLLFastTraits	29.128	8999.691	6.874240

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	243.156	1078.088
SumSLL_Basic	656.003	399.608	0.370663
SumSLL_Base_Core	633.320	413.920	0.383939
SumSLL_Avx2	64.978	4034.325	3.742110
SumSLLTraits	63.014	4160.085	3.858762
SumSLLTraits_Core	49.803	5263.632	4.882377
SumSLLConstTraits	65.391	4008.883	3.718511
SumSLLConstTraits_Core	52.130	5028.654	4.664418
SumSLL128Traits	107.492	2438.719	2.262078
SumSLL128Traits_Core	89.046	2943.903	2.730670
SumSLL128ConstTraits	108.948	2406.145	2.231863
SumSLL128ConstTraits_Core	86.813	3019.629	2.800911
SumSLLFast_Avx2	63.344	4138.414	3.838660
SumSLLFastTraits	62.255	4210.823	3.905825

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	236.766	1107.187
SumSLL_Basic	17.957	14598.474	13.185194
SumSLL_Base_Core	7.284	35987.079	32.503167
SumSLL_Multiply	18.884	13881.843	12.537941
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	13.070	20056.273	18.114624
SumSLLTraits	11.949	21938.912	19.815004
SumSLLTraits_Core	7.276	36029.479	32.541462
SumSLLConstTraits	8.988	29164.925	26.341466
SumSLLConstTraits_Core	7.112	36861.873	33.293273
SumSLL128Traits	23.824	11003.247	9.938021
SumSLL128Traits_Core	11.896	22035.474	19.902218
SumSLL128ConstTraits	12.764	20537.896	18.549621
SumSLL128ConstTraits_Core	11.657	22487.211	20.310222
SumSLLFast_Multiply	10.961	23916.127	21.600805
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	8.350	31395.302	28.355920
SumSLLFastTraits	8.382	31274.979	28.247246

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	223.646	1172.140
SumSLL_Basic	23.945	10947.805	9.340012
SumSLL_Base_Core	12.696	20648.090	17.615715
SumSLL_Base_Core_Element	24.776	10580.505	9.026654
SumSLL_Base_Core_Mov	25.996	10084.104	8.603154
SumSLL_Multiply	21.561	12158.416	10.372833
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	14.513	18062.965	15.410241
SumSLLTraits	15.649	16751.210	14.291130
SumSLLTraits_Core	13.638	19222.022	16.399079
SumSLLConstTraits	14.122	18563.247	15.837051
SumSLLConstTraits_Core	14.468	18118.265	15.457419
SumSLL128Traits	26.681	9825.239	8.382306
SumSLL128Traits_Core	23.045	11375.431	9.704837
SumSLL128ConstTraits	22.715	11540.363	9.845547
SumSLL128ConstTraits_Core	22.643	11577.295	9.877055
SumSLLFast_Multiply	16.415	15970.090	13.624725
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	13.522	19386.233	16.539174
SumSLLFastTraits	12.851	20398.819	17.403052

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	195.307	1342.214
SumSLL_Basic	45.700	5736.214	4.273696
SumSLL_Base_Core	30.850	8497.490	6.330951
SumSLL_Multiply	45.661	5741.091	4.277330
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	29.131	8998.942	6.704552
SumSLLTraits	30.798	8511.797	6.341611
SumSLLTraits_Core	24.642	10637.885	7.925627
SumSLLConstTraits	26.345	9950.372	7.413403
SumSLLConstTraits_Core	24.019	10914.119	8.131431
SumSLL128Traits	58.417	4487.490	3.343349
SumSLL128Traits_Core	43.799	5985.160	4.459171
SumSLL128ConstTraits	47.203	5553.559	4.137611
SumSLL128ConstTraits_Core	42.227	6208.037	4.625222
SumSLLFast_Multiply	34.686	7557.605	5.630702
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	27.720	9456.816	7.045686
SumSLLFastTraits	27.709	9460.558	7.048474

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	202.192	1296.513
SumSLL_Basic	561.523	466.845	0.360077
SumSLL_Base_Core	567.130	462.229	0.356517
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	63.161	4150.397	3.201200
SumSLLTraits	67.650	3874.979	2.988770
SumSLLTraits_Core	56.670	4625.810	3.567885
SumSLLConstTraits	65.549	3999.204	3.084585
SumSLLConstTraits_Core	53.639	4887.199	3.769495
SumSLL128Traits	111.714	2346.573	1.809911
SumSLL128Traits_Core	94.565	2772.104	2.138123
SumSLL128ConstTraits	113.442	2310.826	1.782339
SumSLL128ConstTraits_Core	90.748	2888.690	2.228046
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	59.684	4392.174	3.387682
SumSLLFastTraits	59.179	4429.696	3.416623

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.14
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.14\
RuntimeInformation.FrameworkDescription:	.NET 6.0.14
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	187.635	1397.096
SumSLL_Basic	16.224	16158.177	11.565549
SumSLL_Base_Core	7.238	36219.562	25.924899
SumSLL_Multiply	16.986	15433.161	11.046603
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	11.998	21848.630	15.638608
SumSLLTraits	11.956	21925.956	15.693955
SumSLLTraits_Core	7.297	35926.896	25.715417
SumSLLConstTraits	6.939	37779.230	27.041263
SumSLLConstTraits_Core	6.848	38281.511	27.400781
SumSLL128Traits	23.443	11182.127	8.003838
SumSLL128Traits_Core	12.182	21519.225	15.402830
SumSLL128ConstTraits	11.841	22137.812	15.845596
SumSLL128ConstTraits_Core	11.572	22654.177	16.215195
SumSLLFast_Multiply	9.990	26240.618	18.782264
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.805	33588.749	24.041840
SumSLLFastTraits	7.326	35780.354	25.610527

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	188.456	1391.007
SumSLL_Basic	19.802	13238.475	9.517189
SumSLL_Base_Core	12.514	20948.669	15.060076
SumSLL_Base_Core_Element	22.596	11601.115	8.340085
SumSLL_Base_Core_Mov	23.497	11156.456	8.020418
SumSLL_Multiply	20.964	12504.758	8.989717
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	16.517	15871.174	11.409846
SumSLLTraits	16.446	15939.896	11.459251
SumSLLTraits_Core	14.360	18255.371	13.123854
SumSLLConstTraits	13.575	19310.625	13.882481
SumSLLConstTraits_Core	12.934	20267.616	14.570465
SumSLL128Traits	25.730	10188.276	7.324390
SumSLL128Traits_Core	22.711	11542.802	8.298163
SumSLL128ConstTraits	21.700	12080.474	8.684698
SumSLL128ConstTraits_Core	21.747	12054.031	8.665688
SumSLLFast_Multiply	15.372	17053.526	12.259844
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	15.148	17305.017	12.440641
SumSLLFastTraits	13.066	20062.605	14.423081

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	117.509	2230.839
SumSLL_Basic	40.302	6504.465	2.915704
SumSLL_Base_Core	30.386	8627.041	3.867173
SumSLL_Multiply	44.654	5870.513	2.631527
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	31.346	8362.883	3.748762
SumSLLTraits	32.257	8126.712	3.642895
SumSLLTraits_Core	22.935	11429.839	5.123561
SumSLLConstTraits	25.023	10476.206	4.696084
SumSLLConstTraits_Core	23.130	11333.746	5.080486
SumSLL128Traits	56.574	4633.607	2.077070
SumSLL128Traits_Core	44.397	5904.565	2.646791
SumSLL128ConstTraits	46.808	5600.425	2.510457
SumSLL128ConstTraits_Core	46.848	5595.677	2.508329
SumSLLFast_Multiply	34.198	7665.503	3.436153
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	28.231	9285.713	4.162431
SumSLLFastTraits	25.762	10175.678	4.561369

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	125.649	2086.324
SumSLL_Basic	541.496	484.111	0.232040
SumSLL_Base_Core	541.804	483.836	0.231908
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	60.438	4337.399	2.078967
SumSLLTraits	67.662	3874.301	1.856999
SumSLLTraits_Core	54.864	4778.081	2.290191
SumSLLConstTraits	55.902	4689.309	2.247642
SumSLLConstTraits_Core	54.755	4787.558	2.294734
SumSLL128Traits	105.241	2490.889	1.193913
SumSLL128Traits_Core	89.659	2923.783	1.401404
SumSLL128ConstTraits	90.871	2884.782	1.382711
SumSLL128ConstTraits_Core	88.351	2967.064	1.422150
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	57.720	4541.674	2.176879
SumSLLFastTraits	61.845	4238.705	2.031662

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.3
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.3\
RuntimeInformation.FrameworkDescription:	.NET 7.0.3
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	169.337	1548.058
SumSLLNetBcl	224.478	1167.793	0.754360
SumSLLNetBcl_Const	224.404	1168.176	0.754608
SumSLL_Basic	13.303	19705.802	12.729368
SumSLL_Base_Core	6.764	38757.745	25.036362
SumSLL_Multiply	13.570	19318.388	12.479110
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	10.875	24105.680	15.571560
SumSLLTraits	11.663	22476.367	14.519071
SumSLLTraits_Core	6.950	37718.523	24.365055
SumSLLConstTraits	7.532	34803.661	22.482140
SumSLLConstTraits_Core	6.829	38387.169	24.796981
SumSLL128Traits	20.846	12575.019	8.123092
SumSLL128Traits_Core	12.702	20637.494	13.331214
SumSLL128ConstTraits	12.616	20778.532	13.422320
SumSLL128ConstTraits_Core	12.656	20713.170	13.380098
SumSLLFast_Multiply	8.434	31082.447	20.078345
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.106	36892.069	23.831190
SumSLLFastTraits	6.863	38195.377	24.673089

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	170.814	1534.675
SumSLLNetBcl	13.615	19253.455	12.545622
SumSLLNetBcl_Const	12.614	20781.535	13.541325
SumSLL_Basic	14.439	18155.039	11.829891
SumSLL_Base_Core	14.544	18024.551	11.744864
SumSLL_Base_Core_Element	17.305	15148.806	9.871018
SumSLL_Base_Core_Mov	16.043	16340.248	10.647366
SumSLL_Multiply	18.685	14029.810	9.141876
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	15.409	17012.930	11.085688
SumSLLTraits	14.237	18412.228	11.997476
SumSLLTraits_Core	13.458	19478.878	12.692509
SumSLLConstTraits	13.700	19134.904	12.468374
SumSLLConstTraits_Core	13.623	19242.494	12.538480
SumSLL128Traits	22.620	11588.889	7.551363
SumSLL128Traits_Core	23.002	11396.574	7.426050
SumSLL128ConstTraits	21.454	12219.069	7.961990
SumSLL128ConstTraits_Core	20.401	12849.500	8.372782
SumSLLFast_Multiply	13.608	19264.205	12.552627
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	14.611	17941.423	11.690697
SumSLLFastTraits	13.591	19287.782	12.567990

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	102.828	2549.342
SumSLLNetBcl	26.400	9929.723	3.895014
SumSLLNetBcl_Const	25.898	10122.276	3.970545
SumSLL_Basic	25.106	10441.575	4.095793
SumSLL_Base_Core	25.829	10149.339	3.981160
SumSLL_Multiply	34.218	7660.892	3.005047
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	28.381	9236.585	3.623125
SumSLLTraits	26.431	9918.101	3.890456
SumSLLTraits_Core	23.787	11020.577	4.322911
SumSLLConstTraits	24.805	10568.107	4.145426
SumSLLConstTraits_Core	25.145	10425.267	4.089395
SumSLL128Traits	43.726	5995.151	2.351647
SumSLL128Traits_Core	41.097	6378.673	2.502086
SumSLL128ConstTraits	41.612	6299.721	2.471117
SumSLL128ConstTraits_Core	44.012	5956.200	2.336368
SumSLLFast_Multiply	29.623	8849.395	3.471247
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	27.892	9398.523	3.686647
SumSLLFastTraits	26.445	9912.974	3.888444

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	108.312	2420.276
SumSLLNetBcl	55.091	4758.372	1.966045
SumSLLNetBcl_Const	46.740	5608.585	2.317332
SumSLL_Basic	57.361	4570.112	1.888261
SumSLL_Base_Core	58.569	4475.797	1.849292
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	67.263	3897.313	1.610276
SumSLLTraits	66.982	3913.657	1.617029
SumSLLTraits_Core	48.521	5402.729	2.232278
SumSLLConstTraits	51.329	5107.104	2.110133
SumSLLConstTraits_Core	55.225	4746.873	1.961294
SumSLL128Traits	103.966	2521.434	1.041796
SumSLL128Traits_Core	80.210	3268.239	1.350358
SumSLL128ConstTraits	81.843	3202.992	1.323399
SumSLL128ConstTraits_Core	81.417	3219.768	1.330331
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	57.873	4529.625	1.871532
SumSLLFastTraits	59.876	4378.093	1.808923

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
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
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	429.609	610.192
SumSLL_Basic	46.184	5676.064	9.302090
SumSLL_Base_Core	18.268	14349.939	23.517074
SumSLL_Multiply	46.183	5676.185	9.302288
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	46.250	5668.036	9.288933
SumSLLTraits_Core	18.278	14341.895	23.503891
SumSLLConstTraits	26.355	9946.663	16.300865
SumSLLConstTraits_Core	19.857	13201.657	21.635238
SumSLLFast_Multiply	26.355	9946.629	16.300809
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.379	9937.536	16.285907

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	431.910	606.942
SumSLL_Basic	62.039	4225.475	6.961910
SumSLL_Base_Core	33.284	7876.033	12.976586
SumSLL_Base_Core_Element	66.166	3961.926	6.527685
SumSLL_Base_Core_Mov	61.881	4236.260	6.979680
SumSLL_Multiply	61.829	4239.837	6.985573
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	61.953	4231.310	6.971524
SumSLLTraits_Core	33.259	7881.834	12.986143
SumSLLConstTraits	39.853	6577.829	10.837659
SumSLLConstTraits_Core	31.271	8383.107	13.812042
SumSLLFast_Multiply	47.381	5532.640	9.115602
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	52.682	4975.958	8.198410

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	349.763	749.491
SumSLL_Basic	80.635	3251.006	4.337620
SumSLL_Base_Core	63.178	4149.315	5.536180
SumSLL_Multiply	81.011	3235.925	4.317499
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	81.078	3233.214	4.313882
SumSLLTraits_Core	67.182	3901.975	5.206170
SumSLLConstTraits	74.675	3510.471	4.683808
SumSLLConstTraits_Core	67.116	3905.829	5.211311
SumSLLFast_Multiply	80.587	3252.916	4.340169
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	74.737	3507.561	4.679927

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	352.730	743.187
SumSLL_Basic	544.543	481.402	0.647754
SumSLL_Base_Core	541.368	484.225	0.651552
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	543.804	482.056	0.648633
SumSLLTraits_Core	537.101	488.072	0.656729
SumSLLConstTraits	560.206	467.942	0.629643
SumSLLConstTraits_Core	557.621	470.112	0.632562
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	556.305	471.224	0.634058

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
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	429.348	610.563
SumSLL_Basic	46.132	5682.492	9.306973
SumSLL_Base_Core	16.594	15797.770	25.874107
SumSLL_Multiply	46.131	5682.654	9.307238
SumSLL_AdvSimd	19.801	13239.258	21.683692
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.780	13252.891	21.706020
SumSLLTraits_Core	16.499	15888.315	26.022404
SumSLLConstTraits	19.794	13243.304	21.690319
SumSLLConstTraits_Core	16.490	15896.748	26.036217
SumSLLFast_Multiply	26.334	9954.522	16.303843
SumSLLFast_AdvSimd	16.494	15893.590	26.031045
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	16.495	15892.019	26.028471

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	431.708	607.226
SumSLL_Basic	62.947	4164.512	6.858263
SumSLL_Base_Core	33.298	7872.607	12.964882
SumSLL_Base_Core_Element	60.799	4311.659	7.100590
SumSLL_Base_Core_Mov	66.039	3969.535	6.537168
SumSLL_Multiply	60.712	4317.808	7.110716
SumSLL_AdvSimd	39.834	6580.871	10.837606
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	40.003	6553.072	10.791825
SumSLLTraits_Core	33.192	7897.878	13.006499
SumSLLConstTraits	39.598	6620.078	10.902173
SumSLLConstTraits_Core	33.086	7923.119	13.048066
SumSLLFast_Multiply	47.357	5535.524	9.116093
SumSLLFast_AdvSimd	33.331	7864.969	12.952303
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	33.352	7860.008	12.944132

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	351.204	746.414
SumSLL_Basic	81.774	3205.726	4.294834
SumSLL_Base_Core	63.677	4116.747	5.515364
SumSLL_Multiply	81.298	3224.488	4.319970
SumSLL_AdvSimd	79.954	3278.702	4.392603
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	74.231	3531.441	4.731207
SumSLLTraits_Core	63.317	4140.171	5.546747
SumSLLConstTraits	67.820	3865.285	5.178470
SumSLLConstTraits_Core	67.287	3895.898	5.219484
SumSLLFast_Multiply	80.893	3240.639	4.341609
SumSLLFast_AdvSimd	80.123	3271.777	4.383325
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	79.828	3283.848	4.399497

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	352.968	742.685
SumSLL_Basic	548.659	477.791	0.643328
SumSLL_Base_Core	547.245	479.025	0.644990
SumSLL_AdvSimd	159.940	1639.016	2.206878
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	160.114	1637.232	2.204477
SumSLLTraits_Core	133.058	1970.152	2.652741
SumSLLConstTraits	133.854	1958.432	2.636961
SumSLLConstTraits_Core	132.940	1971.898	2.655092
SumSLLFast_AdvSimd	133.774	1959.602	2.638536
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	159.258	1646.035	2.216329

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
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	401.325	653.197
SumSLL_Basic	37.192	7048.387	10.790600
SumSLL_Base_Core	19.784	13250.518	20.285640
SumSLL_Multiply	37.126	7060.939	10.809816
SumSLL_AdvSimd	19.834	13216.883	20.234148
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.779	13253.575	20.290320
SumSLLTraits_Core	16.500	15887.520	24.322711
SumSLLConstTraits	16.492	15895.672	24.335190
SumSLLConstTraits_Core	16.493	15894.093	24.332774
SumSLLFast_Multiply	23.571	11121.366	17.026054
SumSLLFast_AdvSimd	15.400	17022.639	26.060501
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	15.410	17010.920	26.042560

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	431.341	607.742
SumSLL_Basic	46.585	5627.246	9.259268
SumSLL_Base_Core	33.281	7876.791	12.960748
SumSLL_Base_Core_Element	49.730	5271.394	8.673736
SumSLL_Base_Core_Mov	51.264	5113.562	8.414035
SumSLL_Multiply	46.475	5640.580	9.281208
SumSLL_AdvSimd	39.934	6564.405	10.801303
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	39.698	6603.431	10.865517
SumSLLTraits_Core	31.025	8449.502	13.903106
SumSLLConstTraits	31.044	8444.304	13.894553
SumSLLConstTraits_Core	31.046	8443.802	13.893728
SumSLLFast_Multiply	40.347	6497.237	10.690782
SumSLLFast_AdvSimd	31.020	8450.845	13.905317
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	31.045	8444.011	13.894072

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	350.801	747.273
SumSLL_Basic	87.267	3003.930	4.019857
SumSLL_Base_Core	63.549	4125.050	5.520138
SumSLL_Multiply	87.161	3007.593	4.024759
SumSLL_AdvSimd	79.786	3285.599	4.396787
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	74.254	3530.389	4.724364
SumSLLTraits_Core	63.283	4142.377	5.543325
SumSLLConstTraits	63.410	4134.108	5.532260
SumSLLConstTraits_Core	67.273	3896.719	5.214586
SumSLLFast_Multiply	82.299	3185.249	4.262499
SumSLLFast_AdvSimd	67.183	3901.965	5.221607
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	67.227	3899.394	5.218166

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	352.458	743.760
SumSLL_Basic	540.845	484.694	0.651680
SumSLL_Base_Core	541.026	484.531	0.651462
SumSLL_AdvSimd	160.402	1634.294	2.197339
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	159.791	1640.547	2.205746
SumSLLTraits_Core	125.500	2088.793	2.808421
SumSLLConstTraits	124.884	2099.095	2.822274
SumSLLConstTraits_Core	124.968	2097.693	2.820388
SumSLLFast_AdvSimd	133.044	1970.355	2.649180
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	124.763	2101.135	2.825015

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
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	294.184	891.088
SumSLLNetBcl	13.388	19580.464	21.973654
SumSLLNetBcl_Const	13.375	19599.073	21.994538
SumSLL_Basic	13.363	19616.914	22.014559
SumSLL_Base_Core	13.398	19565.182	21.956504
SumSLL_Multiply	35.423	7400.391	8.304892
SumSLL_AdvSimd	19.812	13231.639	14.848854
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.797	13241.598	14.860030
SumSLLTraits_Core	13.378	19595.005	21.989972
SumSLLConstTraits	13.466	19466.408	21.845657
SumSLLConstTraits_Core	13.480	19447.318	21.824235
SumSLLFast_Multiply	22.919	11437.932	12.835914
SumSLLFast_AdvSimd	13.365	19613.913	22.011192
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	13.378	19595.664	21.990712

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	342.603	765.154
SumSLLNetBcl	28.090	9332.186	12.196478
SumSLLNetBcl_Const	28.370	9240.256	12.076332
SumSLL_Basic	28.036	9350.349	12.220215
SumSLL_Base_Core	27.833	9418.617	12.309436
SumSLL_Base_Core_Element	39.135	6698.495	8.754438
SumSLL_Base_Core_Mov	35.177	7452.238	9.739524
SumSLL_Multiply	45.762	5728.366	7.486551
SumSLL_AdvSimd	42.719	6136.411	8.019836
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	28.034	9351.061	12.221146
SumSLLTraits_Core	28.018	9356.142	12.227786
SumSLLConstTraits	28.009	9359.246	12.231843
SumSLLConstTraits_Core	28.134	9317.663	12.177497
SumSLLFast_Multiply	38.378	6830.659	8.927167
SumSLLFast_AdvSimd	27.449	9550.069	12.481235
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	27.847	9413.761	12.303089

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	186.774	1403.533
SumSLLNetBcl	57.769	4537.804	3.233131
SumSLLNetBcl_Const	57.827	4533.257	3.229891
SumSLL_Basic	56.936	4604.189	3.280429
SumSLL_Base_Core	57.240	4579.735	3.263006
SumSLL_Multiply	86.170	3042.178	2.167515
SumSLL_AdvSimd	71.570	3662.748	2.609664
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	57.671	4545.497	3.238612
SumSLLTraits_Core	58.182	4505.555	3.210154
SumSLLConstTraits	57.386	4568.054	3.254683
SumSLLConstTraits_Core	57.648	4547.294	3.239892
SumSLLFast_Multiply	74.970	3496.673	2.491338
SumSLLFast_AdvSimd	53.719	4879.927	3.476889
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	53.486	4901.191	3.492040

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	191.025	1372.299
SumSLLNetBcl	105.995	2473.172	1.802210
SumSLLNetBcl_Const	106.198	2468.456	1.798774
SumSLL_Basic	107.068	2448.377	1.784143
SumSLL_Base_Core	106.641	2458.194	1.791296
SumSLL_AdvSimd	132.447	1979.243	1.442282
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	132.274	1981.831	1.444168
SumSLLTraits_Core	106.208	2468.202	1.798589
SumSLLConstTraits	106.536	2460.619	1.793064
SumSLLConstTraits_Core	106.328	2465.419	1.796561
SumSLLFast_AdvSimd	106.471	2462.124	1.794160
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	106.526	2460.834	1.793220

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

