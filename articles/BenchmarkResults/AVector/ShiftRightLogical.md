# Benchmark - ShiftRightLogical
([← Back](README.md))

See [Group](ShiftRightLogical.md)

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	309.630	846.637
SumSRL_Basic	77.370	3388.194	4.001945
SumSRL_Base_Core	78.342	3346.155	3.952291
SumSRLTraits	76.756	3415.293	4.033953
SumSRLTraits_Core	77.720	3372.916	3.983900
SumSRLConstTraits	66.834	3922.329	4.632835
SumSRLConstTraits_Core	66.761	3926.592	4.637871
SumSRLFastTraits	72.490	3616.264	4.271328

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	317.526	825.584
SumSRL_Basic	151.426	1731.170	2.096905
SumSRL_Base_Core	152.953	1713.890	2.075975
SumSRLTraits	154.037	1701.820	2.061354
SumSRLTraits_Core	151.513	1730.177	2.095702
SumSRLConstTraits	132.604	1976.898	2.394546
SumSRLConstTraits_Core	132.942	1971.872	2.388459
SumSRLFastTraits	143.377	1828.354	2.214620

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	319.012	821.736
SumSRL_Basic	307.401	852.776	1.037773
SumSRL_Base_Core	305.748	857.385	1.043382
SumSRLTraits	306.107	856.380	1.042159
SumSRLTraits_Core	307.468	852.589	1.037545
SumSRLConstTraits	267.874	978.609	1.190904
SumSRLConstTraits_Core	264.003	992.959	1.208368
SumSRLFastTraits	284.569	921.198	1.121038

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	322.794	812.110
SumSRL_Basic	566.373	462.847	0.569931
SumSRL_Base_Core	595.978	439.855	0.541620
SumSRLTraits	568.338	461.246	0.567960
SumSRLTraits_Core	572.345	458.018	0.563985
SumSRLConstTraits	486.009	539.381	0.664172
SumSRLConstTraits_Core	481.098	544.886	0.670951
SumSRLFastTraits	524.317	499.972	0.615645

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	306.253	855.971
SumSRL_Basic	76.487	3427.285	4.003972
SumSRL_Base_Core	78.437	3342.096	3.904449
SumSRLTraits	76.748	3415.641	3.990369
SumSRLTraits_Core	77.220	3394.753	3.965967
SumSRLConstTraits	66.852	3921.254	4.581059
SumSRLConstTraits_Core	67.076	3908.174	4.565778
SumSRLFastTraits	71.819	3650.058	4.264230

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	316.768	827.558
SumSRL_Basic	151.470	1730.669	2.091296
SumSRL_Base_Core	153.708	1705.463	2.060837
SumSRLTraits	154.302	1698.905	2.052912
SumSRLTraits_Core	151.457	1730.818	2.091475
SumSRLConstTraits	132.642	1976.327	2.388142
SumSRLConstTraits_Core	132.962	1971.569	2.382393
SumSRLFastTraits	143.111	1831.754	2.213444

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	318.999	821.770
SumSRL_Basic	307.178	853.393	1.038482
SumSRL_Base_Core	308.993	848.381	1.032382
SumSRLTraits	308.200	850.566	1.035041
SumSRLTraits_Core	308.074	850.913	1.035463
SumSRLConstTraits	266.579	983.363	1.196639
SumSRLConstTraits_Core	265.689	986.657	1.200648
SumSRLFastTraits	285.964	916.701	1.115520

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	322.752	812.216
SumSRL_Basic	568.223	461.340	0.568001
SumSRL_Base_Core	565.524	463.542	0.570712
SumSRLTraits	559.790	468.290	0.576559
SumSRLTraits_Core	587.695	446.054	0.549182
SumSRLConstTraits	482.959	542.788	0.668280
SumSRLConstTraits_Core	483.818	541.824	0.667093
SumSRLFastTraits	525.652	498.702	0.614002

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	236.930	1106.418
SumSRL_Basic	78.780	3327.549	3.007498
SumSRL_Base_Core	78.660	3332.617	3.012079
SumSRL_Avx2	12.296	21319.875	19.269283
SumSRLTraits	12.146	21582.691	19.506820
SumSRLTraits_Core	6.543	40066.847	36.213130
SumSRLConstTraits	10.393	25223.486	22.797436
SumSRLConstTraits_Core	6.727	38967.067	35.219129
SumSRL128Traits	23.793	11017.751	9.958040
SumSRL128Traits_Core	11.669	22465.586	20.304797
SumSRL128ConstTraits	20.024	13091.539	11.832366
SumSRL128ConstTraits_Core	11.642	22517.888	20.352068
SumSRLFast_Avx2	10.141	25850.815	23.364427
SumSRLFastTraits	10.087	25988.998	23.489319

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	222.085	1180.376
SumSRL_Basic	157.800	1661.240	1.407381
SumSRL_Base_Core	156.372	1676.415	1.420237
SumSRL_Avx2	15.451	16966.170	14.373525
SumSRLTraits	15.568	16839.045	14.265826
SumSRLTraits_Core	14.561	18003.733	15.252536
SumSRLConstTraits	15.687	16711.196	14.157514
SumSRLConstTraits_Core	14.174	18494.805	15.668566
SumSRL128Traits	26.446	9912.608	8.397837
SumSRL128Traits_Core	22.220	11797.568	9.994751
SumSRL128ConstTraits	24.449	10722.172	9.083689
SumSRL128ConstTraits_Core	22.355	11726.457	9.934506
SumSRLFast_Avx2	14.785	17729.872	15.020524
SumSRLFastTraits	15.176	17273.637	14.634008

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	195.595	1340.238
SumSRL_Basic	310.603	843.983	0.629726
SumSRL_Base_Core	309.413	847.231	0.632149
SumSRL_Avx2	28.262	9275.591	6.920853
SumSRLTraits	29.286	8951.065	6.678712
SumSRLTraits_Core	23.542	11135.217	8.308388
SumSRLConstTraits	28.785	9106.979	6.795046
SumSRLConstTraits_Core	23.586	11114.345	8.292814
SumSRL128Traits	50.958	5144.303	3.838351
SumSRL128Traits_Core	40.756	6432.075	4.799204
SumSRL128ConstTraits	48.844	5366.957	4.004480
SumSRL128ConstTraits_Core	40.788	6427.011	4.795425
SumSRLFast_Avx2	26.436	9916.057	7.398728
SumSRLFastTraits	27.518	9526.200	7.107842

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	198.606	1319.922
SumSRL_Basic	558.719	469.188	0.355466
SumSRL_Base_Core	560.885	467.376	0.354093
SumSRL_Avx2	62.173	4216.370	3.194408
SumSRLTraits	62.522	4192.816	3.176564
SumSRLTraits_Core	49.103	5338.684	4.044697
SumSRLConstTraits	63.515	4127.309	3.126934
SumSRLConstTraits_Core	53.738	4878.151	3.695787
SumSRL128Traits	101.968	2570.845	1.947725
SumSRL128Traits_Core	106.854	2453.284	1.858658
SumSRL128ConstTraits	98.228	2668.736	2.021890
SumSRL128ConstTraits_Core	81.137	3230.894	2.447792
SumSRLFast_Avx2	63.230	4145.861	3.140989
SumSRLFastTraits	63.961	4098.516	3.105120

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	237.390	1104.273
SumSRL_Basic	74.019	3541.578	3.207157
SumSRL_Base_Core	74.040	3540.556	3.206231
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	12.835	20423.376	18.494856
SumSRLTraits	12.165	21548.188	19.513455
SumSRLTraits_Core	7.303	35893.636	32.504303
SumSRLConstTraits	8.762	29917.452	27.092433
SumSRLConstTraits_Core	6.997	37463.494	33.925924
SumSRL128Traits	23.824	11003.411	9.964391
SumSRL128Traits_Core	12.018	21811.726	19.752107
SumSRL128ConstTraits	12.123	21623.952	19.582064
SumSRL128ConstTraits_Core	11.935	21963.671	19.889705
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	8.150	32163.089	29.126021
SumSRLFastTraits	8.374	31304.963	28.348925

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	224.330	1168.565
SumSRL_Basic	157.570	1663.669	1.423686
SumSRL_Base_Core	149.897	1748.822	1.496555
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	14.731	17794.939	15.228031
SumSRLTraits	14.993	17484.293	14.962195
SumSRLTraits_Core	13.236	19806.127	16.949106
SumSRLConstTraits	13.534	19369.441	16.575412
SumSRLConstTraits_Core	13.959	18779.613	16.070666
SumSRL128Traits	25.792	10163.713	8.697604
SumSRL128Traits_Core	22.196	11810.273	10.106649
SumSRL128ConstTraits	22.122	11850.039	10.140679
SumSRL128ConstTraits_Core	22.061	11882.444	10.168409
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	13.792	19007.423	16.265614
SumSRLFastTraits	12.879	20353.861	17.417830

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	199.862	1311.624
SumSRL_Basic	297.093	882.363	0.672725
SumSRL_Base_Core	297.455	881.291	0.671908
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	31.158	8413.389	6.414483
SumSRLTraits	32.178	8146.749	6.211194
SumSRLTraits_Core	25.061	10460.397	7.975151
SumSRLConstTraits	29.132	8998.348	6.860464
SumSRLConstTraits_Core	24.695	10615.475	8.093384
SumSRL128Traits	52.660	4978.035	3.795323
SumSRL128Traits_Core	40.634	6451.324	4.918578
SumSRL128ConstTraits	42.628	6149.632	4.688564
SumSRL128ConstTraits_Core	39.962	6559.794	5.001277
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	28.047	9346.708	7.126058
SumSRLFastTraits	26.328	9956.808	7.591207

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	202.912	1291.908
SumSRL_Basic	571.398	458.777	0.355116
SumSRL_Base_Core	572.597	457.816	0.354372
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	61.484	4263.621	3.300251
SumSRLTraits	60.168	4356.844	3.372410
SumSRLTraits_Core	52.387	5003.987	3.873330
SumSRLConstTraits	61.677	4250.279	3.289924
SumSRLConstTraits_Core	53.739	4878.053	3.775851
SumSRL128Traits	106.569	2459.854	1.904047
SumSRL128Traits_Core	85.880	3052.458	2.362752
SumSRL128ConstTraits	102.616	2554.615	1.977397
SumSRL128ConstTraits_Core	87.184	3006.803	2.327412
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	54.605	4800.706	3.715981
SumSRLFastTraits	58.996	4443.424	3.439427

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	198.719	1319.166
SumSRL_Basic	76.225	3439.085	2.607014
SumSRL_Base_Core	76.554	3424.303	2.595809
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	12.870	20368.902	15.440741
SumSRLTraits	12.611	20786.307	15.757157
SumSRLTraits_Core	6.898	38000.428	28.806401
SumSRLConstTraits	7.138	36724.204	27.838954
SumSRLConstTraits_Core	7.390	35472.758	26.890289
SumSRL128Traits	24.054	10898.263	8.261479
SumSRL128Traits_Core	11.759	22292.328	16.898803
SumSRL128ConstTraits	11.964	21910.307	16.609211
SumSRL128ConstTraits_Core	12.017	21813.615	16.535912
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	7.322	35803.209	27.140790
SumSRLFastTraits	7.554	34701.803	26.305864

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	190.644	1375.047
SumSRL_Basic	150.860	1737.664	1.263713
SumSRL_Base_Core	151.269	1732.970	1.260299
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	14.753	17769.067	12.922517
SumSRLTraits	13.626	19238.495	13.991156
SumSRLTraits_Core	12.850	20400.232	14.836027
SumSRLConstTraits	11.872	22080.690	16.058136
SumSRLConstTraits_Core	12.051	21753.710	15.820341
SumSRL128Traits	26.236	9991.871	7.266567
SumSRL128Traits_Core	22.217	11799.390	8.581082
SumSRL128ConstTraits	20.260	12938.813	9.409725
SumSRL128ConstTraits_Core	20.288	12920.862	9.396670
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	13.275	19747.689	14.361466
SumSRLFastTraits	13.247	19789.267	14.391704

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	159.718	1641.294
SumSRL_Basic	299.461	875.387	0.533351
SumSRL_Base_Core	302.042	867.906	0.528794
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	29.362	8928.063	5.439647
SumSRLTraits	32.071	8173.928	4.980172
SumSRLTraits_Core	27.428	9557.404	5.823089
SumSRLConstTraits	26.866	9757.615	5.945073
SumSRLConstTraits_Core	23.791	11018.422	6.713251
SumSRL128Traits	53.236	4924.207	3.000198
SumSRL128Traits_Core	41.875	6260.201	3.814185
SumSRL128ConstTraits	43.448	6033.465	3.676040
SumSRL128ConstTraits_Core	44.085	5946.371	3.622977
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	30.010	8735.296	5.322199
SumSRLFastTraits	30.419	8617.842	5.250637

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	199.886	1311.469
SumSRL_Basic	539.715	485.709	0.370355
SumSRL_Base_Core	539.268	486.111	0.370662
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	62.447	4197.849	3.200876
SumSRLTraits	62.708	4180.362	3.187542
SumSRLTraits_Core	51.693	5071.174	3.866790
SumSRLConstTraits	48.964	5353.840	4.082323
SumSRLConstTraits_Core	47.316	5540.260	4.224469
SumSRL128Traits	105.798	2477.777	1.889314
SumSRL128Traits_Core	84.123	3116.196	2.376111
SumSRL128ConstTraits	87.564	2993.759	2.282752
SumSRL128ConstTraits_Core	87.161	3007.577	2.293289
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	55.752	4701.980	3.585277
SumSRLFastTraits	54.194	4837.104	3.688310

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	161.445	1623.736
SumSRLNetBcl	224.419	1168.100	0.719390
SumSRLNetBcl_Const	224.960	1165.292	0.717661
SumSRL_Basic	12.059	21738.679	13.388059
SumSRL_Base_Core	11.887	22053.927	13.582208
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	11.250	23301.034	14.350256
SumSRLTraits	10.636	24647.471	15.179478
SumSRLTraits_Core	6.859	38217.831	23.536967
SumSRLConstTraits	8.817	29731.002	18.310239
SumSRLConstTraits_Core	7.229	36265.253	22.334445
SumSRL128Traits	20.427	12833.095	7.903435
SumSRL128Traits_Core	12.942	20255.182	12.474428
SumSRL128ConstTraits	12.751	20558.752	12.661385
SumSRL128ConstTraits_Core	12.613	20784.327	12.800309
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	7.126	36787.421	22.656030
SumSRLFastTraits	7.374	35550.132	21.894029

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	162.283	1615.351
SumSRLNetBcl	13.066	20062.992	12.420204
SumSRLNetBcl_Const	12.011	21824.747	13.510837
SumSRL_Basic	13.888	18875.087	11.684820
SumSRL_Base_Core	14.768	17751.265	10.989105
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	15.677	16721.673	10.351726
SumSRLTraits	14.076	18623.991	11.529376
SumSRLTraits_Core	13.599	19276.084	11.933061
SumSRLConstTraits	12.556	20878.242	12.924894
SumSRLConstTraits_Core	12.081	21699.206	13.433120
SumSRL128Traits	24.433	10728.948	6.641867
SumSRL128Traits_Core	22.706	11544.962	7.147029
SumSRL128ConstTraits	22.808	11493.354	7.115081
SumSRL128ConstTraits_Core	21.790	12030.515	7.447616
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	15.169	17281.355	10.698203
SumSRLFastTraits	14.751	17770.748	11.001167

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	119.662	2190.696
SumSRLNetBcl	29.099	9008.726	4.112267
SumSRLNetBcl_Const	26.929	9734.574	4.443600
SumSRL_Basic	28.955	9053.415	4.132667
SumSRL_Base_Core	28.137	9316.648	4.252826
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	32.096	8167.605	3.728316
SumSRLTraits	29.082	9013.879	4.114620
SumSRLTraits_Core	24.397	10744.795	4.904742
SumSRLConstTraits	27.937	9383.367	4.283282
SumSRLConstTraits_Core	27.857	9410.497	4.295666
SumSRL128Traits	49.112	5337.709	2.436536
SumSRL128Traits_Core	44.745	5858.617	2.674318
SumSRL128ConstTraits	45.577	5751.690	2.625509
SumSRL128ConstTraits_Core	45.766	5727.912	2.614654
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	28.222	9288.494	4.239975
SumSRLFastTraits	27.977	9370.003	4.277182

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	159.516	1643.369
SumSRLNetBcl	54.461	4813.450	2.929014
SumSRLNetBcl_Const	48.734	5379.103	3.273217
SumSRL_Basic	56.608	4630.865	2.817909
SumSRL_Base_Core	56.931	4604.559	2.801903
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	62.030	4226.073	2.571591
SumSRLTraits	64.928	4037.473	2.456827
SumSRLTraits_Core	54.348	4823.454	2.935101
SumSRLConstTraits	54.107	4844.908	2.948156
SumSRLConstTraits_Core	52.016	5039.676	3.066674
SumSRL128Traits	105.663	2480.940	1.509667
SumSRL128Traits_Core	83.265	3148.293	1.915756
SumSRL128ConstTraits	86.711	3023.183	1.839625
SumSRL128ConstTraits_Core	86.201	3041.082	1.850517
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	56.528	4637.409	2.821892
SumSRLFastTraits	54.850	4779.293	2.908229

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	429.765	609.971
SumSRL_Basic	74.149	3535.363	5.795951
SumSRL_Base_Core	74.107	3537.350	5.799208
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	70.061	3741.637	6.134122
SumSRLTraits_Core	70.123	3738.350	6.128733
SumSRLConstTraits	68.559	3823.629	6.268540
SumSRLConstTraits_Core	68.542	3824.594	6.270122
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	68.925	3803.316	6.235240

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	432.124	606.641
SumSRL_Basic	148.320	1767.420	2.913453
SumSRL_Base_Core	148.473	1765.596	2.910447
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	138.565	1891.842	3.118553
SumSRLTraits_Core	138.464	1893.230	3.120842
SumSRLConstTraits	136.558	1919.649	3.164391
SumSRLConstTraits_Core	136.443	1921.276	3.167072
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	136.822	1915.946	3.158287

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	350.570	747.766
SumSRL_Basic	275.969	949.905	1.270323
SumSRL_Base_Core	679.196	385.962	0.516154
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	279.450	938.073	1.254500
SumSRLTraits_Core	279.358	938.379	1.254909
SumSRLConstTraits	276.631	947.631	1.267283
SumSRLConstTraits_Core	273.343	959.031	1.282528
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	272.367	962.467	1.287123

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	354.044	740.429
SumSRL_Basic	539.613	485.800	0.656106
SumSRL_Base_Core	534.307	490.624	0.662622
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	556.197	471.315	0.636543
SumSRLTraits_Core	556.365	471.172	0.636351
SumSRLConstTraits	557.536	470.183	0.635014
SumSRLConstTraits_Core	557.508	470.207	0.635047
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	557.664	470.075	0.634869

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	429.151	610.843
SumSRL_Basic	73.221	3580.168	5.861027
SumSRL_Base_Core	71.538	3664.403	5.998926
SumSRL_AdvSimd	23.106	11345.178	18.572980
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	22.005	11913.021	19.502587
SumSRLTraits_Core	15.436	16982.614	27.801924
SumSRLConstTraits	16.505	15882.629	26.001158
SumSRLConstTraits_Core	15.422	16997.625	27.826497
SumSRLFast_AdvSimd	16.520	15868.754	25.978445
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	16.501	15886.504	26.007502

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	431.708	607.225
SumSRL_Basic	145.783	1798.180	2.961308
SumSRL_Base_Core	146.665	1787.371	2.943506
SumSRL_AdvSimd	46.205	5673.453	9.343245
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	46.141	5681.334	9.356224
SumSRLTraits_Core	30.898	8484.151	13.972002
SumSRLConstTraits	209.653	1250.372	2.059157
SumSRLConstTraits_Core	30.935	8473.922	13.955157
SumSRLFast_AdvSimd	33.091	7921.829	13.045951
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	39.652	6611.060	10.887330

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	351.131	746.570
SumSRL_Basic	268.519	976.257	1.307656
SumSRL_Base_Core	267.875	978.606	1.310802
SumSRL_AdvSimd	80.044	3274.991	4.386716
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	80.008	3276.459	4.388681
SumSRLTraits_Core	67.189	3901.594	5.226024
SumSRLConstTraits	67.281	3896.249	5.218865
SumSRLConstTraits_Core	67.168	3902.825	5.227673
SumSRLFast_AdvSimd	67.561	3880.117	5.197257
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	67.423	3888.059	5.207894

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	353.535	741.494
SumSRL_Basic	541.139	484.430	0.653317
SumSRL_Base_Core	541.052	484.508	0.653421
SumSRL_AdvSimd	184.729	1419.077	1.913807
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	184.530	1420.603	1.915865
SumSRLTraits_Core	123.631	2120.369	2.859590
SumSRLConstTraits	132.755	1974.648	2.663066
SumSRLConstTraits_Core	132.268	1981.918	2.672871
SumSRLFast_AdvSimd	132.584	1977.193	2.666499
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	132.381	1980.220	2.670582

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	400.480	654.575
SumSRL_Basic	73.447	3569.164	5.452642
SumSRL_Base_Core	72.487	3616.444	5.524872
SumSRL_AdvSimd	23.120	11338.244	17.321532
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	23.085	11355.501	17.347896
SumSRLTraits_Core	16.515	15872.815	24.249036
SumSRLConstTraits	16.521	15867.157	24.240391
SumSRLConstTraits_Core	15.443	16974.903	25.932705
SumSRLFast_AdvSimd	15.417	17003.082	25.975754
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	15.423	16996.865	25.966256

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	432.071	606.715
SumSRL_Basic	147.388	1778.601	2.931528
SumSRL_Base_Core	146.130	1793.904	2.956751
SumSRL_AdvSimd	44.214	5929.012	9.772323
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	44.127	5940.648	9.791501
SumSRLTraits_Core	33.271	7879.072	12.986453
SumSRLConstTraits	33.250	7884.014	12.994599
SumSRLConstTraits_Core	33.287	7875.343	12.980307
SumSRLFast_AdvSimd	33.340	7862.685	12.959444
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	31.243	8390.470	13.829349

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	350.023	748.934
SumSRL_Basic	268.659	975.748	1.302849
SumSRL_Base_Core	268.654	975.768	1.302875
SumSRL_AdvSimd	79.934	3279.505	4.378895
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	79.903	3280.786	4.380606
SumSRLTraits_Core	62.707	4180.485	5.581911
SumSRLConstTraits	66.929	3916.718	5.229722
SumSRLConstTraits_Core	66.818	3923.265	5.238463
SumSRLFast_AdvSimd	62.824	4172.700	5.571516
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	66.883	3919.469	5.233395

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	353.116	742.373
SumSRL_Basic	538.167	487.105	0.656146
SumSRL_Base_Core	550.040	476.591	0.641983
SumSRL_AdvSimd	184.627	1419.860	1.912597
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	184.495	1420.872	1.913960
SumSRLTraits_Core	123.525	2122.190	2.858657
SumSRLConstTraits	123.599	2120.920	2.856947
SumSRLConstTraits_Core	132.228	1982.508	2.670501
SumSRLFast_AdvSimd	158.441	1654.524	2.228697
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	158.487	1654.040	2.228044

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	294.266	890.839
SumSRLNetBcl	13.384	19586.726	21.986831
SumSRLNetBcl_Const	13.381	19590.775	21.991376
SumSRL_Basic	33.042	7933.745	8.905925
SumSRL_Base_Core	33.053	7930.950	8.902788
SumSRL_AdvSimd	19.911	13165.746	14.779041
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	19.896	13175.619	14.790124
SumSRLTraits_Core	13.388	19580.851	21.980236
SumSRLConstTraits	13.480	19447.280	21.830298
SumSRLConstTraits_Core	13.490	19432.662	21.813888
SumSRLFast_AdvSimd	13.372	19603.444	22.005598
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	13.396	19568.992	21.966924

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	319.447	820.618
SumSRLNetBcl	27.579	9505.360	11.583171
SumSRLNetBcl_Const	27.569	9508.811	11.587376
SumSRL_Basic	27.532	9521.524	11.602867
SumSRL_Base_Core	27.584	9503.337	11.580705
SumSRL_AdvSimd	40.259	6511.443	7.934803
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	27.579	9505.102	11.582856
SumSRLTraits_Core	27.568	9509.063	11.587683
SumSRLConstTraits	27.762	9442.549	11.506630
SumSRLConstTraits_Core	27.770	9439.698	11.503155
SumSRLFast_AdvSimd	27.528	9522.792	11.604413
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	27.563	9510.709	11.589689

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	224.058	1169.981
SumSRLNetBcl	55.092	4758.308	4.066995
SumSRLNetBcl_Const	55.221	4747.163	4.057469
SumSRL_Basic	55.224	4746.886	4.057233
SumSRL_Base_Core	55.173	4751.345	4.061044
SumSRL_AdvSimd	79.911	3280.461	2.803858
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	55.335	4737.385	4.049113
SumSRLTraits_Core	55.146	4753.624	4.062992
SumSRLConstTraits	55.566	4717.740	4.032321
SumSRLConstTraits_Core	55.658	4709.911	4.025630
SumSRLFast_AdvSimd	55.348	4736.323	4.048205
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	55.195	4749.435	4.059412

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	220.335	1189.752
SumSRLNetBcl	107.682	2434.417	2.046156
SumSRLNetBcl_Const	107.696	2434.110	2.045898
SumSRL_Basic	108.167	2423.514	2.036992
SumSRL_Base_Core	111.423	2352.692	1.977465
SumSRL_AdvSimd	160.513	1633.169	1.372697
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	158.991	1648.802	1.385838
SumSRLTraits_Core	109.643	2390.895	2.009575
SumSRLConstTraits	108.761	2410.270	2.025860
SumSRLConstTraits_Core	109.253	2399.429	2.016748
SumSRLFast_AdvSimd	110.150	2379.890	2.000325
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	110.143	2380.027	2.000441

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

