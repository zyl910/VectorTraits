# Benchmark - YNarrowSaturate
([← Back](README.md))

See [Group](YNarrowSaturate_Group.md)

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1251.628	209.442
SumNarrow_IfUnrolling4	1237.751	211.791	1.011211
SumNarrow_MinMax	1293.174	202.714	0.967872
SumNarrow_MinMaxUnrolling4	1295.851	202.295	0.965873
SumNarrow_BitMath	1202.204	218.053	1.041111
SumNarrow_BitMathUnrolling4	844.019	310.590	1.482938
SumNarrowVectorBase	20.018	13095.098	62.523604
SumNarrowVectorTraits	20.127	13024.364	62.185880

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1243.369	210.834
SumNarrow_MinMax	1235.951	212.099	1.006002
SumNarrow_BitMath	601.838	435.572	2.065953
SumNarrowVectorBase	37.811	6933.036	32.883923
SumNarrowVectorTraits	38.233	6856.456	32.520698

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1343.447	195.128
SumNarrow_MinMax	1385.472	189.209	0.969667
SumNarrow_BitMath	778.538	336.713	1.725603
SumNarrowVectorBase	133.760	1959.806	10.043697
SumNarrowVectorTraits	133.958	1956.908	10.028850

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	245.720	1066.840
SumNarrow_IfUnrolling4	243.647	1075.915	1.008506
SumNarrow_MinMax	245.707	1066.895	1.000051
SumNarrow_MinMaxUnrolling4	222.202	1179.758	1.105843
SumNarrow_BitMath	441.408	593.881	0.556673
SumNarrow_BitMathUnrolling4	550.898	475.848	0.446035
SumNarrowVectorBase	15.526	16884.658	15.826789
SumNarrowVectorTraits	15.546	16862.587	15.806102

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	234.808	1116.417
SumNarrow_MinMax	235.001	1115.502	0.999181
SumNarrow_BitMath	511.487	512.514	0.459071
SumNarrowVectorBase	33.502	7824.674	7.008740
SumNarrowVectorTraits	33.269	7879.556	7.057899

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	262.847	997.327
SumNarrow_MinMax	302.909	865.420	0.867740
SumNarrow_BitMath	367.303	713.699	0.715611
SumNarrowVectorBase	130.075	2015.328	2.020728
SumNarrowVectorTraits	129.748	2020.405	2.025820

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1250.571	209.620
SumNarrow_IfUnrolling4	1221.327	214.639	1.023944
SumNarrow_MinMax	1216.724	215.451	1.027818
SumNarrow_MinMaxUnrolling4	1205.824	217.398	1.037109
SumNarrow_BitMath	1199.074	218.622	1.042947
SumNarrow_BitMathUnrolling4	841.977	311.343	1.485279
SumNarrowVectorBase	19.031	13774.472	65.711784
SumNarrowVectorTraits	19.187	13662.396	65.177118

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1234.174	212.404
SumNarrow_MinMax	1237.776	211.786	0.997090
SumNarrow_BitMath	600.852	436.287	2.054038
SumNarrowVectorBase	40.699	6441.062	30.324509
SumNarrowVectorTraits	40.969	6398.525	30.124247

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1403.030	186.841
SumNarrow_MinMax	1464.727	178.971	0.957878
SumNarrow_BitMath	777.067	337.350	1.805546
SumNarrowVectorBase	139.533	1878.724	10.055189
SumNarrowVectorTraits	139.999	1872.465	10.021690

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	290.459	902.516
SumNarrow_IfUnrolling4	239.598	1094.100	1.212278
SumNarrow_MinMax	290.265	903.120	1.000669
SumNarrow_MinMaxUnrolling4	219.632	1193.562	1.322484
SumNarrow_BitMath	442.609	592.270	0.656243
SumNarrow_BitMathUnrolling4	550.315	476.352	0.527805
SumNarrowVectorBase	15.372	17052.914	18.894864
SumNarrowVectorTraits	15.442	16975.925	18.809560

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	272.566	961.764
SumNarrow_MinMax	290.621	902.014	0.937874
SumNarrow_BitMath	513.861	510.146	0.530427
SumNarrowVectorBase	37.364	7015.984	7.294909
SumNarrowVectorTraits	37.319	7024.438	7.303699

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	309.340	847.431
SumNarrow_MinMax	241.956	1083.437	1.278496
SumNarrow_BitMath	368.567	711.252	0.839303
SumNarrowVectorBase	132.934	1971.981	2.327010
SumNarrowVectorTraits	132.458	1979.078	2.335385

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1242.811	210.928
SumNarrow_IfUnrolling4	1282.832	204.348	0.968802
SumNarrow_MinMax	1235.224	212.224	1.006142
SumNarrow_MinMaxUnrolling4	1221.147	214.670	1.017740
SumNarrow_BitMath	1194.103	219.532	1.040791
SumNarrow_BitMathUnrolling4	782.501	335.008	1.588254
SumNarrowVectorBase	19.918	13161.165	62.396380
SumNarrowVectorTraits	9.323	28118.834	133.309889
SumNarrowVector128Traits	1617.031	162.114	0.768575
SumNarrowVector256Traits	9.259	28311.621	134.223881

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1226.489	213.735
SumNarrow_MinMax	1244.335	210.670	0.985658
SumNarrow_BitMath	745.655	351.562	1.644849
SumNarrowVectorBase	39.815	6584.000	30.804454
SumNarrowVectorTraits	20.915	12533.505	58.640309
SumNarrowVector128Traits	2753.874	95.191	0.445369
SumNarrowVector256Traits	20.911	12535.974	58.651862

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1338.400	195.864
SumNarrow_MinMax	1337.028	196.065	1.001026
SumNarrow_BitMath	775.449	338.055	1.725968
SumNarrowVectorBase	131.008	2000.976	10.216161
SumNarrowVectorTraits	101.306	2587.636	13.211406
SumNarrowVector128Traits	5104.332	51.357	0.262209
SumNarrowVector256Traits	100.779	2601.186	13.280588

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	243.055	1078.540
SumNarrow_IfUnrolling4	243.210	1077.851	0.999362
SumNarrow_MinMax	290.792	901.484	0.835838
SumNarrow_MinMaxUnrolling4	220.310	1189.887	1.103240
SumNarrow_BitMath	444.220	590.122	0.547149
SumNarrow_BitMathUnrolling4	537.834	487.407	0.451914
SumNarrowVectorBase	17.306	15147.602	14.044550
SumNarrowVectorTraits	12.399	21142.034	19.602466
SumNarrowVector128Traits	950.113	275.908	0.255817
SumNarrowVector256Traits	11.380	23034.836	21.357433

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	306.146	856.272
SumNarrow_MinMax	291.156	900.357	1.051485
SumNarrow_BitMath	592.652	442.323	0.516569
SumNarrowVectorBase	30.420	8617.594	10.064084
SumNarrowVectorTraits	21.520	12181.180	14.225829
SumNarrowVector128Traits	1590.666	164.801	0.192464
SumNarrowVector256Traits	24.583	10663.709	12.453645

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	300.686	871.820
SumNarrow_MinMax	236.662	1107.671	1.270528
SumNarrow_BitMath	363.249	721.666	0.827769
SumNarrowVectorBase	142.966	1833.610	2.103199
SumNarrowVectorTraits	89.811	2918.828	3.347973
SumNarrowVector128Traits	2853.405	91.871	0.105378
SumNarrowVector256Traits	88.591	2959.039	3.394096

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1314.134	199.480
SumNarrow_IfUnrolling4	1260.914	207.900	1.042207
SumNarrow_MinMax	1219.880	214.893	1.077265
SumNarrow_MinMaxUnrolling4	1213.995	215.935	1.082487
SumNarrow_BitMath	1214.241	215.891	1.082268
SumNarrow_BitMathUnrolling4	1139.865	229.978	1.152885
SumNarrowVectorBase	20.144	13013.472	65.236821
SumNarrowVectorTraits	10.465	25049.004	125.571202
SumNarrowVector128Traits	1662.242	157.705	0.790579
SumNarrowVector256Traits	9.315	28142.430	141.078617

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1220.352	214.810
SumNarrow_MinMax	1278.573	205.029	0.954464
SumNarrow_BitMath	1036.798	252.840	1.177039
SumNarrowVectorBase	35.510	7382.254	34.366398
SumNarrowVectorTraits	18.378	14263.835	66.402030
SumNarrowVector128Traits	2788.627	94.005	0.437617
SumNarrowVector256Traits	23.151	11323.214	52.712640

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1314.271	199.460
SumNarrow_MinMax	1370.822	191.231	0.958747
SumNarrow_BitMath	955.602	274.323	1.375333
SumNarrowVectorBase	123.719	2118.858	10.622989
SumNarrowVectorTraits	94.867	2763.282	13.853839
SumNarrowVector128Traits	4993.501	52.497	0.263196
SumNarrowVector256Traits	94.180	2783.439	13.954900

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	268.935	974.749
SumNarrow_IfUnrolling4	240.541	1089.810	1.118041
SumNarrow_MinMax	273.187	959.577	0.984435
SumNarrow_MinMaxUnrolling4	223.297	1173.972	1.204384
SumNarrow_BitMath	902.082	290.599	0.298127
SumNarrow_BitMathUnrolling4	898.315	291.817	0.299377
SumNarrowVectorBase	15.335	17094.243	17.537064
SumNarrowVectorTraits	10.036	26121.170	26.797832
SumNarrowVector128Traits	949.061	276.214	0.283369
SumNarrowVector256Traits	10.580	24778.069	25.419938

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	290.860	901.272
SumNarrow_MinMax	298.788	877.358	0.973467
SumNarrow_BitMath	1013.096	258.755	0.287100
SumNarrowVectorBase	32.059	8176.926	9.072655
SumNarrowVectorTraits	24.469	10713.260	11.886829
SumNarrowVector128Traits	1566.213	167.374	0.185709
SumNarrowVector256Traits	25.579	10248.304	11.370940

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	299.406	875.547
SumNarrow_MinMax	239.278	1095.561	1.251287
SumNarrow_BitMath	462.992	566.196	0.646677
SumNarrowVectorBase	107.157	2446.346	2.794078
SumNarrowVectorTraits	80.442	3258.796	3.722012
SumNarrowVector128Traits	2723.482	96.253	0.109935
SumNarrowVector256Traits	79.671	3290.313	3.758008

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1241.576	211.138
SumNarrow_IfUnrolling4	1259.355	208.157	0.985883
SumNarrow_MinMax	1497.120	175.099	0.829310
SumNarrow_MinMaxUnrolling4	1321.990	198.295	0.939172
SumNarrow_BitMath	942.838	278.037	1.316850
SumNarrow_BitMathUnrolling4	942.413	278.162	1.317443
SumNarrowVectorBase	19.907	13168.239	62.367903
SumNarrowVectorTraits	9.296	28198.282	133.553754
SumNarrowVector128Traits	1667.792	157.180	0.744443
SumNarrowVector256Traits	10.547	24854.897	117.718691

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1254.370	208.985
SumNarrow_MinMax	1246.327	210.333	1.006453
SumNarrow_BitMath	1050.492	249.544	1.194079
SumNarrowVectorBase	38.961	6728.319	32.195276
SumNarrowVectorTraits	20.339	12888.771	61.673286
SumNarrowVector128Traits	2811.101	93.253	0.446220
SumNarrowVector256Traits	18.923	13852.952	66.286928

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1354.927	193.475
SumNarrow_MinMax	1368.182	191.600	0.990312
SumNarrow_BitMath	962.099	272.471	1.408302
SumNarrowVectorBase	132.646	1976.264	10.214585
SumNarrowVectorTraits	97.454	2689.931	13.903271
SumNarrowVector128Traits	5036.791	52.046	0.269006
SumNarrowVector256Traits	97.591	2686.148	13.883718

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	245.507	1067.768
SumNarrow_IfUnrolling4	241.052	1087.498	1.018479
SumNarrow_MinMax	291.197	900.228	0.843093
SumNarrow_MinMaxUnrolling4	342.292	765.848	0.717242
SumNarrow_BitMath	902.476	290.472	0.272037
SumNarrow_BitMathUnrolling4	952.865	275.111	0.257651
SumNarrowVectorBase	15.241	17200.043	16.108414
SumNarrowVectorTraits	9.914	26440.908	24.762793
SumNarrowVector128Traits	948.832	276.281	0.258746
SumNarrowVector256Traits	10.445	25097.226	23.504390

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	300.344	872.811
SumNarrow_MinMax	312.314	839.361	0.961675
SumNarrow_BitMath	1018.512	257.379	0.294886
SumNarrowVectorBase	32.524	8059.923	9.234440
SumNarrowVectorTraits	23.694	11063.765	12.676011
SumNarrowVector128Traits	1560.083	168.032	0.192518
SumNarrowVector256Traits	23.478	11165.307	12.792350

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	305.508	858.060
SumNarrow_MinMax	295.744	886.387	1.033014
SumNarrow_BitMath	464.665	564.157	0.657480
SumNarrowVectorBase	99.442	2636.137	3.072207
SumNarrowVectorTraits	78.458	3341.184	3.893884
SumNarrowVector128Traits	2720.818	96.348	0.112285
SumNarrowVector256Traits	78.017	3360.081	3.915906

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1215.353	215.694
SumNarrow_IfUnrolling4	1266.089	207.050	0.959927
SumNarrow_MinMax	1192.907	219.752	1.018817
SumNarrow_MinMaxUnrolling4	1242.276	211.019	0.978328
SumNarrow_BitMath	734.102	357.095	1.655563
SumNarrow_BitMathUnrolling4	785.704	333.642	1.546833
SumNarrowVectorBase	16.421	15964.293	74.013721
SumNarrowVectorTraits	9.423	27819.176	128.975380
SumNarrowVector128Traits	24.122	10867.358	50.383293
SumNarrowVector256Traits	10.390	25229.736	116.970209

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1177.661	222.597
SumNarrow_MinMax	1256.844	208.573	0.936999
SumNarrow_BitMath	606.325	432.349	1.942294
SumNarrowVectorBase	34.029	7703.530	34.607509
SumNarrowVectorTraits	18.734	13992.887	62.861951
SumNarrowVector128Traits	89.339	2934.273	13.181995
SumNarrowVector256Traits	18.384	14259.430	64.059375

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1283.359	204.264
SumNarrow_MinMax	1290.071	203.201	0.994798
SumNarrow_BitMath	608.026	431.140	2.110699
SumNarrowVectorBase	98.592	2658.885	13.016908
SumNarrowVectorTraits	108.391	2418.496	11.840054
SumNarrowVector128Traits	181.346	1445.545	7.076850
SumNarrowVector256Traits	108.831	2408.717	11.792179

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	242.026	1083.124
SumNarrow_IfUnrolling4	242.439	1081.280	0.998297
SumNarrow_MinMax	318.183	823.878	0.760650
SumNarrow_MinMaxUnrolling4	328.397	798.253	0.736992
SumNarrow_BitMath	444.728	589.448	0.544211
SumNarrow_BitMathUnrolling4	439.253	596.794	0.550994
SumNarrowVectorBase	13.295	19717.119	18.203938
SumNarrowVectorTraits	10.667	24575.123	22.689117
SumNarrowVector128Traits	29.092	9010.950	8.319409
SumNarrowVector256Traits	11.273	23255.032	21.470336

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	235.943	1111.046
SumNarrow_MinMax	306.829	854.364	0.768973
SumNarrow_BitMath	404.631	647.860	0.583108
SumNarrowVectorBase	29.785	8801.283	7.921619
SumNarrowVectorTraits	23.168	11314.953	10.184055
SumNarrowVector128Traits	74.621	3513.006	3.161891
SumNarrowVector256Traits	22.984	11405.584	10.265627

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	236.374	1109.023
SumNarrow_MinMax	356.363	735.609	0.663295
SumNarrow_BitMath	399.681	655.883	0.591406
SumNarrowVectorBase	78.563	3336.732	3.008712
SumNarrowVectorTraits	84.340	3108.173	2.802622
SumNarrowVector128Traits	117.090	2238.816	2.018728
SumNarrowVector256Traits	81.132	3231.091	2.913456

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1694.345	154.717
SumNarrow_IfUnrolling4	1639.083	159.933	1.033715
SumNarrow_MinMax	1631.732	160.654	1.038372
SumNarrow_MinMaxUnrolling4	1605.929	163.235	1.055056
SumNarrow_BitMath	1241.988	211.068	1.364220
SumNarrow_BitMathUnrolling4	1257.642	208.441	1.347239
SumNarrowVectorBase	42.802	6124.516	39.585271
SumNarrowVectorTraits	42.798	6125.113	39.589126
SumNarrowVector128Traits	2131.819	122.967	0.794788
SumNarrowVector256Traits	3146.617	83.310	0.538466

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1599.363	163.905
SumNarrow_MinMax	1686.906	155.399	0.948104
SumNarrow_BitMath	1046.052	250.603	1.528952
SumNarrowVectorBase	97.025	2701.810	16.483973
SumNarrowVectorTraits	96.957	2703.709	16.495556
SumNarrowVector128Traits	4045.927	64.792	0.395302
SumNarrowVector256Traits	5970.135	43.909	0.267894

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1618.323	161.985
SumNarrow_MinMax	1699.537	154.244	0.952214
SumNarrow_BitMath	1054.207	248.665	1.535110
SumNarrowVectorBase	365.673	716.880	4.425599
SumNarrowVectorTraits	365.785	716.661	4.424244
SumNarrowVector128Traits	5798.661	45.208	0.279086
SumNarrowVector256Traits	6741.292	38.886	0.240061

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	499.227	525.100
SumNarrow_IfUnrolling4	515.757	508.270	0.967950
SumNarrow_MinMax	496.080	528.430	1.006342
SumNarrow_MinMaxUnrolling4	477.411	549.095	1.045696
SumNarrow_BitMath	797.785	328.590	0.625766
SumNarrow_BitMathUnrolling4	813.462	322.257	0.613706
SumNarrowVectorBase	32.992	7945.777	15.131931
SumNarrowVectorTraits	33.003	7943.115	15.126861
SumNarrowVector128Traits	1352.735	193.788	0.369050
SumNarrowVector256Traits	1857.518	141.126	0.268760

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	481.112	544.871
SumNarrow_MinMax	483.911	541.719	0.994215
SumNarrow_BitMath	709.435	369.511	0.678161
SumNarrowVectorBase	65.510	4001.590	7.344101
SumNarrowVectorTraits	65.229	4018.815	7.375715
SumNarrowVector128Traits	2480.055	105.701	0.193992
SumNarrowVector256Traits	3497.182	74.959	0.137571

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.535	620.408
SumNarrow_MinMax	422.805	620.012	0.999362
SumNarrow_BitMath	672.267	389.940	0.628522
SumNarrowVectorBase	203.047	1291.051	2.080970
SumNarrowVectorTraits	202.585	1293.997	2.085719
SumNarrowVector128Traits	3287.391	79.742	0.128532
SumNarrowVector256Traits	4175.524	62.781	0.101193

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1604.804	163.350
SumNarrow_IfUnrolling4	1615.382	162.280	0.993452
SumNarrow_MinMax	1626.909	161.130	0.986413
SumNarrow_MinMaxUnrolling4	1622.368	161.581	0.989174
SumNarrow_BitMath	1583.638	165.533	1.013366
SumNarrow_BitMathUnrolling4	1611.776	162.643	0.995674
SumNarrowVectorBase	50.307	5210.880	31.900185
SumNarrowVectorTraits	19.312	13574.329	83.099898
SumNarrowVector128Traits	19.916	13162.718	80.580081
SumNarrowVector256Traits	3268.582	80.201	0.490979

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1586.347	165.250
SumNarrow_MinMax	1690.608	155.059	0.938329
SumNarrow_BitMath	1348.434	194.406	1.176436
SumNarrowVectorBase	81.429	3219.290	19.481319
SumNarrowVectorTraits	41.570	6306.022	38.160469
SumNarrowVector128Traits	42.539	6162.376	37.291201
SumNarrowVector256Traits	5077.907	51.624	0.312402

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1617.283	162.089
SumNarrow_MinMax	1702.456	153.980	0.949971
SumNarrow_BitMath	1362.689	192.373	1.186832
SumNarrowVectorBase	220.439	1189.192	7.336657
SumNarrowVectorTraits	79.862	3282.455	20.250924
SumNarrowVector128Traits	83.587	3136.169	19.348423
SumNarrowVector256Traits	7704.702	34.024	0.209909

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	494.098	530.550
SumNarrow_IfUnrolling4	515.932	508.098	0.957682
SumNarrow_MinMax	496.950	527.506	0.994261
SumNarrow_MinMaxUnrolling4	485.801	539.612	1.017080
SumNarrow_BitMath	1010.686	259.372	0.488874
SumNarrow_BitMathUnrolling4	1058.267	247.711	0.466894
SumNarrowVectorBase	29.995	8739.615	16.472737
SumNarrowVectorTraits	18.515	14158.586	26.686607
SumNarrowVector128Traits	18.518	14156.330	26.682354
SumNarrowVector256Traits	1730.068	151.522	0.285595

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	485.213	540.266
SumNarrow_MinMax	488.420	536.718	0.993434
SumNarrow_BitMath	918.405	285.434	0.528322
SumNarrowVectorBase	65.169	4022.504	7.445420
SumNarrowVectorTraits	38.411	6824.637	12.632005
SumNarrowVector128Traits	38.463	6815.464	12.615026
SumNarrowVector256Traits	2375.271	110.364	0.204277

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.200	620.900
SumNarrow_MinMax	422.945	619.806	0.998238
SumNarrow_BitMath	889.527	294.700	0.474634
SumNarrowVectorBase	140.670	1863.543	3.001357
SumNarrowVectorTraits	81.066	3233.726	5.208124
SumNarrowVector128Traits	81.270	3225.596	5.195030
SumNarrowVector256Traits	3720.313	70.463	0.113485

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1664.232	157.517
SumNarrow_IfUnrolling4	1628.646	160.958	1.021850
SumNarrow_MinMax	2412.608	108.656	0.689806
SumNarrow_MinMaxUnrolling4	1775.218	147.669	0.937480
SumNarrow_BitMath	1578.987	166.020	1.053987
SumNarrow_BitMathUnrolling4	1594.236	164.432	1.043905
SumNarrowVectorBase	43.289	6055.721	38.444994
SumNarrowVectorTraits	19.514	13433.471	85.282940
SumNarrowVector128Traits	20.613	12717.414	80.737027
SumNarrowVector256Traits	4430.470	59.168	0.375633

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1634.150	160.416
SumNarrow_MinMax	1647.749	159.092	0.991747
SumNarrow_BitMath	1346.768	194.647	1.213387
SumNarrowVectorBase	94.765	2766.267	17.244319
SumNarrowVectorTraits	42.208	6210.719	38.716303
SumNarrowVector128Traits	42.185	6214.182	38.737889
SumNarrowVector256Traits	5100.212	51.399	0.320408

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1630.200	160.805
SumNarrow_MinMax	1585.400	165.349	1.028258
SumNarrow_BitMath	1360.385	192.698	1.198337
SumNarrowVectorBase	226.645	1156.627	7.192741
SumNarrowVectorTraits	79.825	3283.969	20.422081
SumNarrowVector128Traits	79.727	3288.015	20.447246
SumNarrowVector256Traits	7755.180	33.802	0.210208

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	498.418	525.952
SumNarrow_IfUnrolling4	516.501	507.538	0.964990
SumNarrow_MinMax	486.273	539.088	1.024977
SumNarrow_MinMaxUnrolling4	483.279	542.428	1.031326
SumNarrow_BitMath	1010.398	259.446	0.493289
SumNarrow_BitMathUnrolling4	1049.666	249.740	0.474835
SumNarrowVectorBase	32.991	7945.913	15.107684
SumNarrowVectorTraits	18.505	14166.207	26.934423
SumNarrowVector128Traits	18.525	14150.934	26.905384
SumNarrowVector256Traits	1829.907	143.255	0.272374

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	486.669	538.649
SumNarrow_MinMax	489.286	535.769	0.994652
SumNarrow_BitMath	917.816	285.617	0.530247
SumNarrowVectorBase	66.286	3954.723	7.341923
SumNarrowVectorTraits	40.954	6400.947	11.883324
SumNarrowVector128Traits	38.037	6891.766	12.794529
SumNarrowVector256Traits	2614.252	100.275	0.186160

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	421.402	622.076
SumNarrow_MinMax	421.317	622.201	1.000201
SumNarrow_BitMath	882.303	297.113	0.477616
SumNarrowVectorBase	140.191	1869.904	3.005908
SumNarrowVectorTraits	75.083	3491.369	5.612448
SumNarrowVector128Traits	81.107	3232.074	5.195625
SumNarrowVector256Traits	3629.701	72.222	0.116098

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1441.188	181.894
SumNarrow_IfUnrolling4	1406.561	186.372	1.024618
SumNarrow_MinMax	1419.201	184.712	1.015492
SumNarrow_MinMaxUnrolling4	1406.301	186.407	1.024807
SumNarrow_BitMath	1282.035	204.475	1.124141
SumNarrow_BitMathUnrolling4	1274.991	205.605	1.130351
SumNarrowVectorBase	36.584	7165.511	39.393791
SumNarrowVectorTraits	16.904	15507.867	85.257509
SumNarrowVector128Traits	16.919	15494.383	85.183380
SumNarrowVector256Traits	4242.157	61.795	0.339730

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1373.222	190.897
SumNarrow_MinMax	1337.567	195.986	1.026657
SumNarrow_BitMath	1014.959	258.280	1.352983
SumNarrowVectorBase	86.647	3025.432	15.848498
SumNarrowVectorTraits	32.755	8003.142	41.923858
SumNarrowVector128Traits	32.876	7973.790	41.770099
SumNarrowVector256Traits	4538.541	57.760	0.302569

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1276.440	205.371
SumNarrow_MinMax	1330.643	197.005	0.959266
SumNarrow_BitMath	1064.614	246.234	1.198970
SumNarrowVectorBase	213.246	1229.301	5.985756
SumNarrowVectorTraits	66.847	3921.550	19.094944
SumNarrowVector128Traits	65.231	4018.683	19.567910
SumNarrowVector256Traits	4069.181	64.422	0.313685

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	430.487	608.947
SumNarrow_IfUnrolling4	372.718	703.331	1.154996
SumNarrow_MinMax	430.267	609.259	1.000513
SumNarrow_MinMaxUnrolling4	378.186	693.162	1.138296
SumNarrow_BitMath	785.126	333.888	0.548303
SumNarrow_BitMathUnrolling4	786.939	333.118	0.547040
SumNarrowVectorBase	29.400	8916.311	14.642179
SumNarrowVectorTraits	18.977	13814.007	22.685071
SumNarrowVector128Traits	17.998	14565.067	23.918446
SumNarrowVector256Traits	1392.367	188.272	0.309177

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	422.059	621.107
SumNarrow_MinMax	421.851	621.414	1.000494
SumNarrow_BitMath	645.748	405.954	0.653598
SumNarrowVectorBase	59.857	4379.473	7.051077
SumNarrowVectorTraits	38.996	6722.416	10.823284
SumNarrowVector128Traits	39.370	6658.424	10.720255
SumNarrowVector256Traits	1621.123	161.705	0.260350

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	316.249	828.917
SumNarrow_MinMax	316.383	828.565	0.999576
SumNarrow_BitMath	626.708	418.287	0.504619
SumNarrowVectorBase	144.294	1816.732	2.191694
SumNarrowVectorTraits	74.871	3501.256	4.223894
SumNarrowVector128Traits	75.207	3485.648	4.205065
SumNarrowVector256Traits	1746.632	150.085	0.181062

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

