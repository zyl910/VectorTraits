# Benchmark - ShiftRightArithmetic
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 
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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9167.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	318.211	823.804
SumSRA_Base_Basic	253.790	1032.916	1.253836
SumSRA_Base	169.230	1549.041	1.880350
SumSRA_Base_Core	154.793	1693.516	2.055725
SumSRATraits	168.351	1557.132	1.890171
SumSRATraits_Core	158.509	1653.816	2.007534
SumSRAConstTraits	156.760	1672.258	2.029921
SumSRAConstTraits_Core	152.891	1714.582	2.081298
SumSRAFastTraits	160.889	1629.345	1.977830

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	317.729	825.056
SumSRA_Base_Basic	494.591	530.022	0.642407
SumSRA_Base	344.019	762.004	0.923578
SumSRA_Base_Core	310.663	843.821	1.022743
SumSRATraits	343.115	764.013	0.926013
SumSRATraits_Core	317.131	826.612	1.001885
SumSRAConstTraits	312.952	837.650	1.015264
SumSRAConstTraits_Core	306.101	856.397	1.037986
SumSRAFastTraits	321.473	815.447	0.988353

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	321.555	815.238
SumSRA_Base_Basic	611.587	428.629	0.525772
SumSRA_Base	582.185	450.276	0.552325
SumSRA_Base_Create	630.764	415.598	0.509787
SumSRA_Base_LoadArray	628.091	417.366	0.511956
SumSRA_Base_Core	593.358	441.798	0.541924
SumSRATraits	586.195	447.196	0.548546
SumSRATraits_Core	570.149	459.781	0.563984
SumSRAConstTraits	533.410	491.449	0.602829
SumSRAConstTraits_Core	528.331	496.174	0.608624
SumSRAFastTraits	549.795	476.803	0.584864

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	316.893	827.231
SumSRA_Base_Basic	232.563	1127.196	1.362613
SumSRA_Base	84.499	3102.320	3.750247
SumSRA_Base_Core	77.760	3371.189	4.075270
SumSRATraits	84.329	3108.569	3.757801
SumSRATraits_Core	79.474	3298.491	3.987389
SumSRAConstTraits	78.940	3320.813	4.014373
SumSRAConstTraits_Core	76.564	3423.868	4.138951
SumSRAFastTraits	79.239	3308.286	3.999229

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	316.701	827.734
SumSRA_Base_Basic	254.580	1029.712	1.244013
SumSRA_Base	167.897	1561.338	1.886279
SumSRA_Base_Core	155.340	1687.546	2.038752
SumSRATraits	168.076	1559.674	1.884268
SumSRATraits_Core	158.518	1653.714	1.997880
SumSRAConstTraits	156.500	1675.044	2.023649
SumSRAConstTraits_Core	157.247	1667.090	2.014039
SumSRAFastTraits	160.367	1634.647	1.974844

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	315.916	829.789
SumSRA_Base_Basic	492.211	532.584	0.641831
SumSRA_Base	348.314	752.609	0.906989
SumSRA_Base_Core	310.230	845.000	1.018331
SumSRATraits	345.113	759.588	0.915399
SumSRATraits_Core	317.422	825.854	0.995258
SumSRAConstTraits	314.274	834.126	1.005226
SumSRAConstTraits_Core	305.022	859.426	1.035716
SumSRAFastTraits	323.811	809.559	0.975620

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	322.979	811.645
SumSRA_Base_Basic	591.047	443.525	0.546451
SumSRA_Base	593.988	441.329	0.543746
SumSRA_Base_Create	626.142	418.665	0.515823
SumSRA_Base_LoadArray	628.776	416.912	0.513662
SumSRA_Base_Core	610.525	429.375	0.529018
SumSRATraits	593.502	441.690	0.544191
SumSRATraits_Core	572.031	458.269	0.564618
SumSRAConstTraits	533.442	491.420	0.605461
SumSRAConstTraits_Core	533.874	491.022	0.604971
SumSRAFastTraits	553.612	473.515	0.583402

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	318.274	823.643
SumSRA_Base_Basic	207.060	1266.031	1.537111
SumSRA_Base	84.346	3107.965	3.773438
SumSRA_Base_Core	77.807	3369.161	4.090561
SumSRATraits	84.543	3100.703	3.764621
SumSRATraits_Core	79.709	3288.742	3.992923
SumSRAConstTraits	78.771	3327.910	4.040478
SumSRAConstTraits_Core	76.479	3427.681	4.161611
SumSRAFastTraits	79.183	3310.614	4.019478

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	221.980	1180.933
SumSRA_Base_Basic	277.741	943.844	0.799236
SumSRA_Base	170.383	1538.558	1.302833
SumSRA_Base_Core	160.648	1631.792	1.381783
SumSRA_Avx2	14.921	17568.571	14.876861
SumSRATraits	15.131	17325.184	14.670763
SumSRATraits_Core	14.236	18414.632	15.593294
SumSRAConstTraits	14.845	17658.703	14.953182
SumSRAConstTraits_Core	13.058	20076.043	17.000158
SumSRAFast_Avx2	14.231	18420.197	15.598007
SumSRAFastTraits	14.928	17560.755	14.870242

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	205.474	1275.799
SumSRA_Base_Basic	512.265	511.736	0.401110
SumSRA_Base	340.601	769.652	0.603270
SumSRA_Base_Core	312.740	838.216	0.657012
SumSRA_Avx2	31.333	8366.383	6.557757
SumSRATraits	31.986	8195.470	6.423792
SumSRATraits_Core	24.786	10576.367	8.289992
SumSRAConstTraits	30.895	8484.959	6.650699
SumSRAConstTraits_Core	25.698	10201.125	7.995869
SumSRAFast_Avx2	26.834	9768.933	7.657107
SumSRAFastTraits	30.041	8726.308	6.839875

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	201.641	1300.052
SumSRA_Base_Basic	569.207	460.542	0.354249
SumSRA_Base	565.997	463.155	0.356259
SumSRA_Base_Create	646.027	405.779	0.312125
SumSRA_Base_LoadArray	663.847	394.886	0.303746
SumSRA_Base_Core	566.332	462.880	0.356047
SumSRA_Avx2	87.040	3011.767	2.316651
SumSRATraits	86.433	3032.903	2.332909
SumSRATraits_Core	72.036	3639.092	2.799189
SumSRAConstTraits	85.252	3074.926	2.365233
SumSRAConstTraits_Core	71.617	3660.380	2.815564
SumSRAFast_Avx2	86.401	3034.031	2.333777
SumSRAFast_Avx2_Negative	107.771	2432.419	1.871016
SumSRAFastTraits	85.287	3073.680	2.364274

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	237.984	1101.518
SumSRA_Base_Basic	228.532	1147.076	1.041359
SumSRA_Base	85.580	3063.148	2.780842
SumSRA_Base_Core	80.252	3266.519	2.965470
SumSRA_Avx2	15.356	17071.054	15.497750
SumSRATraits	14.609	17944.555	16.290747
SumSRATraits_Core	8.527	30742.095	27.908839
SumSRAConstTraits	14.327	18297.669	16.611317
SumSRAConstTraits_Core	8.900	29454.032	26.739487
SumSRAFast_Avx2	11.141	23529.355	21.360841
SumSRAFastTraits	10.955	23929.818	21.724396

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 5.0 
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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	221.722	1182.307
SumSRA_Base_Basic	275.716	950.774	0.804168
SumSRA_Base	169.655	1545.158	1.306900
SumSRA_Base_Core	158.938	1649.343	1.395020
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.762	17757.737	15.019560
SumSRATraits	14.810	17699.944	14.970679
SumSRATraits_Core	13.331	19664.147	16.632009
SumSRAConstTraits	12.844	20409.889	17.262761
SumSRAConstTraits_Core	12.969	20212.774	17.096041
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	13.180	19889.547	16.822653
SumSRAFastTraits	13.160	19919.721	16.848174

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	195.287	1342.349
SumSRA_Base_Basic	496.595	527.883	0.393253
SumSRA_Base	332.414	788.607	0.587483
SumSRA_Base_Core	307.053	853.742	0.636006
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	29.738	8815.251	6.567031
SumSRATraits	31.590	8298.404	6.182000
SumSRATraits_Core	25.087	10449.535	7.784512
SumSRAConstTraits	28.376	9238.089	6.882030
SumSRAConstTraits_Core	25.416	10314.334	7.683792
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	28.065	9340.696	6.958468
SumSRAFastTraits	26.717	9811.890	7.309490

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	204.643	1280.982
SumSRA_Base_Basic	592.971	442.086	0.345115
SumSRA_Base	593.785	441.480	0.344642
SumSRA_Base_Create	659.792	397.313	0.310163
SumSRA_Base_LoadArray	671.218	390.550	0.304883
SumSRA_Base_Core	593.048	442.029	0.345070
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	89.693	2922.690	2.281601
SumSRATraits	92.600	2830.935	2.209972
SumSRATraits_Core	78.199	3352.255	2.616941
SumSRAConstTraits	92.930	2820.864	2.202110
SumSRAConstTraits_Core	77.898	3365.210	2.627054
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	88.062	2976.801	2.323842
SumSRAFast_Avx2_Negative	110.041	2382.229	1.859689
SumSRAFastTraits	87.623	2991.710	2.335481

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	237.182	1105.244
SumSRA_Base_Basic	225.718	1161.380	1.050791
SumSRA_Base	83.673	3132.968	2.834639
SumSRA_Base_Core	78.450	3341.562	3.023371
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.814	17695.738	16.010708
SumSRATraits	15.327	17103.399	15.474773
SumSRATraits_Core	8.677	30212.469	27.335566
SumSRAConstTraits	10.087	25989.446	23.514670
SumSRAConstTraits_Core	9.512	27559.316	24.935053
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	10.778	24322.214	22.006195
SumSRAFastTraits	10.827	24211.858	21.906348

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 6.0 
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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	195.459	1341.171
SumSRA_Base_Basic	274.250	955.858	0.712705
SumSRA_Base	165.181	1587.007	1.183300
SumSRA_Base_Core	157.529	1664.105	1.240786
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	15.101	17359.287	12.943385
SumSRATraits	16.011	16372.799	12.207843
SumSRATraits_Core	14.614	17938.068	13.374935
SumSRAConstTraits	12.956	20233.738	15.086626
SumSRAConstTraits_Core	12.486	20994.717	15.654025
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	14.351	18267.126	13.620286
SumSRAFastTraits	13.880	18887.005	14.082479

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	161.688	1621.295
SumSRA_Base_Basic	508.180	515.849	0.318171
SumSRA_Base	327.908	799.443	0.493089
SumSRA_Base_Core	321.520	815.326	0.502886
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	31.673	8276.508	5.104876
SumSRATraits	31.527	8314.921	5.128569
SumSRATraits_Core	26.794	9783.716	6.034508
SumSRAConstTraits	26.269	9979.236	6.155103
SumSRAConstTraits_Core	23.811	11009.384	6.790489
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	29.464	8897.085	5.487642
SumSRAFastTraits	27.408	9564.517	5.899309

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	198.227	1322.441
SumSRA_Base_Basic	540.484	485.017	0.366759
SumSRA_Base	543.574	482.260	0.364674
SumSRA_Base_Create	628.256	417.257	0.315520
SumSRA_Base_LoadArray	649.315	403.724	0.305287
SumSRA_Base_Core	565.099	463.891	0.350784
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	89.813	2918.762	2.207102
SumSRATraits	87.728	2988.130	2.259556
SumSRATraits_Core	78.557	3336.974	2.523345
SumSRAConstTraits	77.888	3365.642	2.545022
SumSRAConstTraits_Core	77.132	3398.657	2.569988
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	88.913	2948.319	2.229452
SumSRAFast_Avx2_Negative	112.766	2324.667	1.757861
SumSRAFastTraits	88.488	2962.468	2.240152

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	194.420	1348.340
SumSRA_Base_Basic	226.058	1159.633	0.860045
SumSRA_Base	82.555	3175.370	2.355022
SumSRA_Base_Core	79.255	3307.588	2.453082
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.690	17844.601	13.234499
SumSRATraits	14.623	17926.975	13.295592
SumSRATraits_Core	8.855	29604.498	21.956260
SumSRAConstTraits	9.218	28437.425	21.090697
SumSRAConstTraits_Core	8.716	30075.338	22.305460
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	9.582	27359.201	20.291029
SumSRAFastTraits	9.658	27143.567	20.131103

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 7.0 
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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	164.566	1592.939
SumSRANetBcl	14.185	18480.038	11.601222
SumSRANetBcl_Const	12.452	21052.686	13.216255
SumSRA_Base_Basic	221.560	1183.175	0.742762
SumSRA_Base	14.707	17824.535	11.189717
SumSRA_Base_Core	15.332	17097.896	10.733554
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	16.063	16319.782	10.245077
SumSRATraits	15.247	17193.661	10.793672
SumSRATraits_Core	14.188	18476.248	11.598843
SumSRAConstTraits	12.582	20835.294	13.079782
SumSRAConstTraits_Core	12.451	21053.837	13.216977
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	14.537	18033.470	11.320880
SumSRAFastTraits	14.957	17526.843	11.002835

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	161.786	1620.315
SumSRANetBcl	25.871	10132.774	6.253582
SumSRANetBcl_Const	23.759	11033.258	6.809328
SumSRA_Base_Basic	507.333	516.710	0.318895
SumSRA_Base	26.263	9981.499	6.160221
SumSRA_Base_Core	26.943	9729.643	6.004784
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	30.334	8641.937	5.333491
SumSRATraits	26.380	9937.082	6.132808
SumSRATraits_Core	23.599	11108.074	6.855502
SumSRAConstTraits	26.074	10053.944	6.204931
SumSRAConstTraits_Core	24.334	10772.948	6.648675
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	29.765	8807.258	5.435522
SumSRAFastTraits	27.467	9543.983	5.890202

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	163.542	1602.916
SumSRANetBcl	453.145	578.499	0.360904
SumSRANetBcl_Const	473.215	553.963	0.345597
SumSRA_Base_Basic	547.480	478.819	0.298718
SumSRA_Base	130.524	2008.403	1.252968
SumSRA_Base_Create	87.309	3002.479	1.873136
SumSRA_Base_LoadArray	98.677	2656.594	1.657351
SumSRA_Base_Core	87.704	2988.949	1.864695
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	87.609	2992.220	1.866736
SumSRATraits	89.688	2922.851	1.823459
SumSRATraits_Core	75.156	3488.018	2.176046
SumSRAConstTraits	77.154	3397.660	2.119675
SumSRAConstTraits_Core	80.980	3237.150	2.019538
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	89.026	2944.581	1.837016
SumSRAFast_Avx2_Negative	110.486	2372.645	1.480206
SumSRAFastTraits	85.162	3078.174	1.920359

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	161.819	1619.984
SumSRANetBcl	225.708	1161.428	0.716938
SumSRANetBcl_Const	226.660	1156.552	0.713928
SumSRA_Base_Basic	206.496	1269.490	0.783643
SumSRA_Base	13.778	19026.065	11.744601
SumSRA_Base_Core	10.345	25340.837	15.642648
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	12.515	20946.140	12.929845
SumSRATraits	13.032	20115.939	12.417370
SumSRATraits_Core	7.934	33040.654	20.395669
SumSRAConstTraits	8.424	31118.235	19.208978
SumSRAConstTraits_Core	8.577	30565.076	18.867519
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	9.165	28602.638	17.656125
SumSRAFastTraits	8.969	29227.714	18.041979

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

