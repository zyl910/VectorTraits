# Benchmark - YNarrowSaturate
([← Back](README.md))

See [Group](YNarrowSaturate_Group.md)

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1254.919	208.893
SumNarrow_IfUnrolling4	1207.159	217.158	1.039564
SumNarrow_MinMax	1226.211	213.784	1.023412
SumNarrow_MinMaxUnrolling4	1241.321	211.181	1.010954
SumNarrow_BitMath	1140.374	229.875	1.100445
SumNarrow_BitMathUnrolling4	828.306	316.482	1.515042
SumNarrowVectorBase	10.424	25148.748	120.390479
SumNarrowVectorTraits	10.177	25758.138	123.307712

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1174.483	223.199
SumNarrow_MinMax	1152.838	227.390	1.018776
SumNarrow_BitMath	522.304	501.900	2.248660
SumNarrowVectorBase	23.635	11091.485	49.693163
SumNarrowVectorTraits	23.641	11088.565	49.680081

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1154.637	227.036
SumNarrow_MinMax	1173.940	223.303	0.983557
SumNarrow_BitMath	730.805	358.706	1.579952
SumNarrowVectorBase	79.606	3293.013	14.504376
SumNarrowVectorTraits	78.179	3353.125	14.769141

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	172.381	1520.727
SumNarrow_IfUnrolling4	187.328	1399.387	0.920209
SumNarrow_MinMax	183.065	1431.974	0.941638
SumNarrow_MinMaxUnrolling4	172.217	1522.170	1.000949
SumNarrow_BitMath	391.750	669.162	0.440028
SumNarrow_BitMathUnrolling4	536.260	488.838	0.321450
SumNarrowVectorBase	8.803	29778.616	19.581835
SumNarrowVectorTraits	8.680	30199.224	19.858418

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	158.745	1651.350
SumNarrow_MinMax	158.726	1651.554	1.000124
SumNarrow_BitMath	460.680	569.038	0.344589
SumNarrowVectorBase	18.390	14254.628	8.632108
SumNarrowVectorTraits	18.242	14370.000	8.701973

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	158.031	1658.814
SumNarrow_MinMax	236.776	1107.141	0.667429
SumNarrow_BitMath	328.043	799.115	0.481739
SumNarrowVectorBase	71.606	3660.947	2.206967
SumNarrowVectorTraits	71.525	3665.085	2.209461

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1255.850	208.738
SumNarrow_IfUnrolling4	1210.102	216.630	1.037805
SumNarrow_MinMax	1183.597	221.481	1.061046
SumNarrow_MinMaxUnrolling4	1146.743	228.599	1.095145
SumNarrow_BitMath	1142.252	229.498	1.099452
SumNarrow_BitMathUnrolling4	823.970	318.147	1.524145
SumNarrowVectorBase	10.747	24393.350	116.860957
SumNarrowVectorTraits	10.834	24197.346	115.921963

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1137.996	230.356
SumNarrow_MinMax	1161.702	225.655	0.979594
SumNarrow_BitMath	515.470	508.553	2.207686
SumNarrowVectorBase	22.431	11686.841	50.733873
SumNarrowVectorTraits	22.669	11563.786	50.199678

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1222.001	214.520
SumNarrow_MinMax	1244.883	210.577	0.981619
SumNarrow_BitMath	730.089	359.058	1.673769
SumNarrowVectorBase	79.148	3312.063	15.439388
SumNarrowVectorTraits	79.503	3297.276	15.370457

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	193.729	1353.149
SumNarrow_IfUnrolling4	191.530	1368.684	1.011481
SumNarrow_MinMax	182.656	1435.180	1.060622
SumNarrow_MinMaxUnrolling4	163.976	1598.674	1.181447
SumNarrow_BitMath	392.569	667.766	0.493490
SumNarrow_BitMathUnrolling4	536.334	488.770	0.361210
SumNarrowVectorBase	8.531	30727.711	22.708301
SumNarrowVectorTraits	8.727	30039.151	22.199444

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	158.254	1656.474
SumNarrow_MinMax	159.881	1639.616	0.989823
SumNarrow_BitMath	460.550	569.198	0.343620
SumNarrowVectorBase	18.824	13925.895	8.406953
SumNarrowVectorTraits	18.902	13868.776	8.372471

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	158.997	1648.733
SumNarrow_MinMax	157.799	1661.253	1.007594
SumNarrow_BitMath	326.033	804.042	0.487673
SumNarrowVectorBase	70.924	3696.134	2.241802
SumNarrowVectorTraits	71.511	3665.804	2.223407

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1245.033	210.552
SumNarrow_IfUnrolling4	1199.034	218.629	1.038363
SumNarrow_MinMax	1176.983	222.725	1.057817
SumNarrow_MinMaxUnrolling4	1141.989	229.550	1.090232
SumNarrow_BitMath	1145.480	228.851	1.086910
SumNarrow_BitMathUnrolling4	755.215	347.112	1.648582
SumNarrowVectorBase	11.048	23728.273	112.695635
SumNarrowVectorTraits	5.069	51719.249	245.636657
SumNarrowVector128Traits	6.770	38722.607	183.910088
SumNarrowVector256Traits	5.121	51188.180	243.114385

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1171.192	223.827
SumNarrow_MinMax	1140.011	229.949	1.027351
SumNarrow_BitMath	718.536	364.831	1.629970
SumNarrowVectorBase	21.541	12169.744	54.371280
SumNarrowVectorTraits	11.075	23670.278	105.752701
SumNarrowVector128Traits	14.464	18123.739	80.972193
SumNarrowVector256Traits	11.168	23472.809	104.870457

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1188.483	220.570
SumNarrow_MinMax	1180.569	222.049	1.006704
SumNarrow_BitMath	731.429	358.400	1.624877
SumNarrowVectorBase	78.490	3339.831	15.141797
SumNarrowVectorTraits	46.684	5615.250	25.457873
SumNarrowVector128Traits	110.218	2378.404	10.782975
SumNarrowVector256Traits	48.302	5427.186	24.605243

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	184.899	1417.767
SumNarrow_IfUnrolling4	193.203	1356.830	0.957019
SumNarrow_MinMax	185.307	1414.646	0.997799
SumNarrow_MinMaxUnrolling4	173.172	1513.781	1.067722
SumNarrow_BitMath	394.345	664.758	0.468877
SumNarrow_BitMathUnrolling4	534.017	490.891	0.346242
SumNarrowVectorBase	8.693	30155.728	21.269879
SumNarrowVectorTraits	6.501	40324.075	28.441966
SumNarrowVector128Traits	10.856	24148.204	17.032564
SumNarrowVector256Traits	6.584	39812.323	28.081009

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	158.166	1657.393
SumNarrow_MinMax	157.773	1661.525	1.002493
SumNarrow_BitMath	538.127	487.142	0.293921
SumNarrowVectorBase	17.722	14791.805	8.924742
SumNarrowVectorTraits	13.224	19823.383	11.960581
SumNarrowVector128Traits	22.198	11809.487	7.125339
SumNarrowVector256Traits	13.067	20061.105	12.104012

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	157.471	1664.711
SumNarrow_MinMax	235.526	1113.017	0.668595
SumNarrow_BitMath	330.510	793.151	0.476450
SumNarrowVectorBase	69.921	3749.138	2.252126
SumNarrowVectorTraits	47.096	5566.215	3.343654
SumNarrowVector128Traits	98.841	2652.182	1.593179
SumNarrowVector256Traits	47.008	5576.564	3.349870

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1255.103	208.863
SumNarrow_IfUnrolling4	1183.477	221.503	1.060522
SumNarrow_MinMax	1228.151	213.446	1.021945
SumNarrow_MinMaxUnrolling4	1158.934	226.194	1.082981
SumNarrow_BitMath	1542.570	169.940	0.813644
SumNarrow_BitMathUnrolling4	1429.749	183.350	0.877849
SumNarrowVectorBase	10.880	24093.755	115.356985
SumNarrowVectorTraits	5.136	51042.196	244.381740
SumNarrowVector128Traits	6.832	38370.034	183.709484
SumNarrowVector256Traits	5.090	51498.152	246.564779

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1201.425	218.194
SumNarrow_MinMax	1165.045	225.008	1.031226
SumNarrow_BitMath	1310.835	199.982	0.916534
SumNarrowVectorBase	21.973	11930.394	54.677863
SumNarrowVectorTraits	10.698	24502.961	112.298853
SumNarrowVector128Traits	14.040	18671.542	85.573036
SumNarrowVector256Traits	10.654	24605.776	112.770059

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1179.239	222.299
SumNarrow_MinMax	1195.361	219.301	0.986512
SumNarrow_BitMath	1209.199	216.791	0.975223
SumNarrowVectorBase	78.814	3326.127	14.962376
SumNarrowVectorTraits	45.243	5794.109	26.064441
SumNarrowVector128Traits	75.871	3455.114	15.542616
SumNarrowVector256Traits	45.084	5814.520	26.156258

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	189.671	1382.095
SumNarrow_IfUnrolling4	195.717	1339.406	0.969113
SumNarrow_MinMax	190.707	1374.594	0.994572
SumNarrow_MinMaxUnrolling4	176.919	1481.718	1.072081
SumNarrow_BitMath	1422.188	184.324	0.133366
SumNarrow_BitMathUnrolling4	1219.722	214.921	0.155504
SumNarrowVectorBase	8.426	31110.346	22.509558
SumNarrowVectorTraits	5.112	51284.626	37.106442
SumNarrowVector128Traits	8.558	30630.747	22.162549
SumNarrowVector256Traits	5.156	50842.782	36.786750

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	157.373	1665.748
SumNarrow_MinMax	160.412	1634.196	0.981059
SumNarrow_BitMath	1144.330	229.081	0.137524
SumNarrowVectorBase	18.165	14431.598	8.663734
SumNarrowVectorTraits	12.807	20468.961	12.288149
SumNarrowVector128Traits	17.629	14870.154	8.927012
SumNarrowVector256Traits	13.074	20051.064	12.037272

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	159.848	1639.963
SumNarrow_MinMax	161.021	1628.014	0.992714
SumNarrow_BitMath	514.313	509.697	0.310798
SumNarrowVectorBase	64.935	4037.009	2.461647
SumNarrowVectorTraits	41.469	6321.435	3.854621
SumNarrowVector128Traits	71.834	3649.313	2.225242
SumNarrowVector256Traits	40.931	6404.596	3.905330

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1228.364	213.409
SumNarrow_IfUnrolling4	1172.615	223.555	1.047543
SumNarrow_MinMax	1247.806	210.084	0.984419
SumNarrow_MinMaxUnrolling4	1254.961	208.886	0.978807
SumNarrow_BitMath	1276.567	205.351	0.962240
SumNarrow_BitMathUnrolling4	1184.357	221.339	1.037157
SumNarrowVectorBase	10.794	24287.096	113.805386
SumNarrowVectorTraits	5.024	52181.566	244.514340
SumNarrowVector128Traits	6.585	39811.769	186.551481
SumNarrowVector256Traits	5.054	51863.824	243.025452

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1164.732	225.068
SumNarrow_MinMax	1129.331	232.123	1.031347
SumNarrow_BitMath	1308.684	200.311	0.890003
SumNarrowVectorBase	21.893	11974.088	53.202066
SumNarrowVectorTraits	10.554	24837.367	110.354894
SumNarrowVector128Traits	13.636	19224.280	85.415393
SumNarrowVector256Traits	10.450	25084.681	111.453736

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1171.964	223.679
SumNarrow_MinMax	1175.205	223.062	0.997242
SumNarrow_BitMath	1207.316	217.130	0.970718
SumNarrowVectorBase	76.407	3430.894	15.338455
SumNarrowVectorTraits	44.705	5863.833	26.215366
SumNarrowVector128Traits	75.942	3451.902	15.432375
SumNarrowVector256Traits	44.378	5907.132	26.408941

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	194.537	1347.531
SumNarrow_IfUnrolling4	184.425	1421.410	1.054825
SumNarrow_MinMax	180.501	1452.314	1.077759
SumNarrow_MinMaxUnrolling4	201.521	1300.826	0.965341
SumNarrow_BitMath	1345.168	194.878	0.144619
SumNarrow_BitMathUnrolling4	1208.573	216.904	0.160964
SumNarrowVectorBase	11.171	23465.819	17.413936
SumNarrowVectorTraits	6.647	39436.541	29.265776
SumNarrowVector128Traits	10.792	24290.683	18.026066
SumNarrowVector256Traits	6.553	40001.161	29.684779

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	201.820	1298.902
SumNarrow_MinMax	159.005	1648.652	1.269266
SumNarrow_BitMath	1138.752	230.203	0.177229
SumNarrowVectorBase	17.848	14687.760	11.307831
SumNarrowVectorTraits	12.047	21760.055	16.752659
SumNarrowVector128Traits	17.078	15349.610	11.817378
SumNarrowVector256Traits	11.901	22027.699	16.958713

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	157.096	1668.689
SumNarrow_MinMax	158.524	1653.652	0.990989
SumNarrow_BitMath	511.344	512.657	0.307221
SumNarrowVectorBase	58.762	4461.080	2.673403
SumNarrowVectorTraits	35.401	7404.890	4.437548
SumNarrowVector128Traits	66.398	3948.044	2.365955
SumNarrowVector256Traits	34.460	7607.278	4.558834

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1177.019	222.719
SumNarrow_IfUnrolling4	1147.937	228.361	1.025333
SumNarrow_MinMax	1104.309	237.383	1.065842
SumNarrow_MinMaxUnrolling4	1097.207	238.919	1.072740
SumNarrow_BitMath	859.474	305.005	1.369464
SumNarrow_BitMathUnrolling4	874.295	299.835	1.346249
SumNarrowVectorBase	11.405	22984.550	103.199932
SumNarrowVectorTraits	5.044	51971.868	233.352113
SumNarrowVector128Traits	5.966	43939.067	197.285081
SumNarrowVector256Traits	5.040	52017.120	233.555291

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1084.160	241.795
SumNarrow_MinMax	1114.914	235.125	0.972415
SumNarrow_BitMath	631.058	415.404	1.718005
SumNarrowVectorBase	22.930	11432.451	47.281661
SumNarrowVectorTraits	11.066	23689.904	97.975313
SumNarrowVector128Traits	13.096	20016.846	82.784497
SumNarrowVector256Traits	10.994	23843.890	98.612160

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1135.442	230.874
SumNarrow_MinMax	1099.978	238.317	1.032241
SumNarrow_BitMath	694.867	377.258	1.634042
SumNarrowVectorBase	46.257	5667.124	24.546408
SumNarrowVectorTraits	58.498	4481.222	19.409826
SumNarrowVector128Traits	79.146	3312.175	14.346252
SumNarrowVector256Traits	59.161	4431.031	19.192432

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	185.707	1411.599
SumNarrow_IfUnrolling4	176.574	1484.609	1.051722
SumNarrow_MinMax	239.384	1095.078	0.775772
SumNarrow_MinMaxUnrolling4	203.627	1287.374	0.911997
SumNarrow_BitMath	473.567	553.552	0.392146
SumNarrow_BitMathUnrolling4	449.777	582.831	0.412887
SumNarrowVectorBase	9.458	27716.652	19.634940
SumNarrowVectorTraits	6.871	38153.013	27.028232
SumNarrowVector128Traits	11.592	22613.799	16.019994
SumNarrowVector256Traits	6.823	38420.223	27.217529

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	156.634	1673.605
SumNarrow_MinMax	237.356	1104.436	0.659914
SumNarrow_BitMath	401.315	653.212	0.390303
SumNarrowVectorBase	17.471	15004.943	8.965642
SumNarrowVectorTraits	14.322	18303.374	10.936497
SumNarrowVector128Traits	23.850	10991.567	6.567600
SumNarrowVector256Traits	14.543	18025.863	10.770680

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	158.912	1649.613
SumNarrow_MinMax	235.111	1114.979	0.675903
SumNarrow_BitMath	419.298	625.198	0.378997
SumNarrowVectorBase	45.602	5748.578	3.484804
SumNarrowVectorTraits	48.674	5385.713	3.264834
SumNarrowVector128Traits	76.907	3408.569	2.066284
SumNarrowVector256Traits	48.232	5435.066	3.294753

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1100.182	238.273
SumNarrow_IfUnrolling4	1112.874	235.556	0.988595
SumNarrow_MinMax	1175.550	222.997	0.935887
SumNarrow_MinMaxUnrolling4	1106.793	236.850	0.994027
SumNarrow_BitMath	497.434	526.992	2.211715
SumNarrow_BitMathUnrolling4	484.852	540.668	2.269108
SumNarrowVectorBase	9.292	28211.297	118.398916
SumNarrowVectorTraits	5.064	51767.160	217.259623
SumNarrowVector128Traits	7.339	35718.360	149.905024
SumNarrowVector256Traits	5.012	52301.998	219.504262
SumNarrowVector512Base	9.685	27065.764	113.591273
SumNarrowVector512Traits	5.345	49044.283	205.832084
SumNarrowVector512_Convert	5.490	47750.744	200.403276

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1035.382	253.186
SumNarrow_MinMax	1084.181	241.790	0.954990
SumNarrow_BitMath	378.428	692.718	2.736007
SumNarrowVectorBase	18.826	13924.358	54.996584
SumNarrowVectorTraits	12.093	21677.977	85.620802
SumNarrowVector128Traits	15.351	17077.070	67.448748
SumNarrowVector256Traits	12.086	21690.533	85.670392
SumNarrowVector512Base	17.252	15195.383	60.016709
SumNarrowVector512Traits	12.392	21155.123	83.555701
SumNarrowVector512_Convert	12.680	20674.293	81.656585

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1098.507	238.637
SumNarrow_MinMax	1098.332	238.675	1.000160
SumNarrow_BitMath	433.396	604.860	2.534650
SumNarrowVectorBase	36.851	7113.656	29.809580
SumNarrowVectorTraits	26.070	10055.485	42.137233
SumNarrowVector128Traits	28.069	9339.261	39.135914
SumNarrowVector256Traits	25.527	10269.472	43.033937
SumNarrowVector512Base	33.503	7824.437	32.788084
SumNarrowVector512Traits	25.711	10195.687	42.724745
SumNarrowVector512_Clamp	33.898	7733.377	32.406500
SumNarrowVector512_Convert	25.777	10169.827	42.616377

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	155.507	1685.738
SumNarrow_IfUnrolling4	144.645	1812.324	1.075092
SumNarrow_MinMax	181.832	1441.681	0.855222
SumNarrow_MinMaxUnrolling4	146.841	1785.229	1.059019
SumNarrow_BitMath	294.213	891.000	0.528552
SumNarrow_BitMathUnrolling4	298.102	879.378	0.521657
SumNarrowVectorBase	6.989	37510.004	22.251379
SumNarrowVectorTraits	5.012	52303.410	31.027004
SumNarrowVector128Traits	5.991	43753.780	25.955262
SumNarrowVector256Traits	5.120	51197.369	30.370887
SumNarrowVector512Base	7.144	36692.778	21.766591
SumNarrowVector512Traits	5.423	48338.964	28.675247
SumNarrowVector512_Convert	5.436	48223.648	28.606841
SumNarrowVector512_Pack	7.185	36487.277	21.644686

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	155.588	1684.855
SumNarrow_MinMax	155.628	1684.422	0.999743
SumNarrow_BitMath	235.857	1111.454	0.659673
SumNarrowVectorBase	13.686	19154.035	11.368358
SumNarrowVectorTraits	12.182	21518.294	12.771600
SumNarrowVector128Traits	14.258	18385.223	10.912050
SumNarrowVector256Traits	11.909	22011.407	13.064273
SumNarrowVector512Base	11.822	22173.591	13.160533
SumNarrowVector512Traits	11.581	22636.186	13.435094
SumNarrowVector512_Convert	11.559	22677.879	13.459840
SumNarrowVector512_Pack	11.918	21995.081	13.054583

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	111.908	2342.503
SumNarrow_MinMax	111.596	2349.051	1.002795
SumNarrow_BitMath	258.696	1013.328	0.432583
SumNarrowVectorBase	28.112	9324.829	3.980712
SumNarrowVectorTraits	26.309	9964.018	4.253578
SumNarrowVector128Traits	25.105	10441.784	4.457534
SumNarrowVector256Traits	26.266	9980.185	4.260480
SumNarrowVector512Base	24.839	10553.714	4.505316
SumNarrowVector512Traits	24.978	10494.880	4.480200
SumNarrowVector512_Clamp	24.707	10610.265	4.529457
SumNarrowVector512_Convert	25.072	10455.842	4.463535

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1233.406	212.537
SumNarrow_IfUnrolling4	1221.919	214.535	1.009401
SumNarrow_MinMax	1268.312	206.687	0.972479
SumNarrow_MinMaxUnrolling4	1279.208	204.927	0.964196
SumNarrow_BitMath	1210.385	216.579	1.019020
SumNarrow_BitMathUnrolling4	835.984	313.575	1.475395
SumNarrowVectorBase	17.657	14846.291	69.852870
SumNarrowVectorTraits	17.596	14897.766	70.095060

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1215.114	215.736
SumNarrow_MinMax	1234.663	212.320	0.984167
SumNarrow_BitMath	594.091	441.252	2.045334
SumNarrowVectorBase	35.490	7386.495	34.238576
SumNarrowVectorTraits	35.651	7353.112	34.083833

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1344.172	195.023
SumNarrow_MinMax	1409.034	186.045	0.953967
SumNarrow_BitMath	772.635	339.286	1.739724
SumNarrowVectorBase	118.514	2211.928	11.341907
SumNarrowVectorTraits	117.735	2226.565	11.416958

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	222.227	1179.622
SumNarrow_IfUnrolling4	241.140	1087.103	0.921569
SumNarrow_MinMax	205.417	1276.156	1.081835
SumNarrow_MinMaxUnrolling4	220.004	1191.541	1.010104
SumNarrow_BitMath	439.266	596.777	0.505905
SumNarrow_BitMathUnrolling4	549.718	476.870	0.404257
SumNarrowVectorBase	16.336	16046.720	13.603275
SumNarrowVectorTraits	16.544	15844.787	13.432090

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	233.768	1121.385
SumNarrow_MinMax	233.264	1123.806	1.002159
SumNarrow_BitMath	503.501	520.642	0.464285
SumNarrowVectorBase	31.125	8422.320	7.510641
SumNarrowVectorTraits	31.005	8454.984	7.539769

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	232.956	1125.294
SumNarrow_MinMax	262.025	1000.454	0.889060
SumNarrow_BitMath	360.256	727.660	0.646640
SumNarrowVectorBase	129.449	2025.081	1.799602
SumNarrowVectorTraits	130.745	2005.004	1.781761

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1216.856	215.427
SumNarrow_IfUnrolling4	1227.266	213.600	0.991518
SumNarrow_MinMax	1226.291	213.770	0.992306
SumNarrow_MinMaxUnrolling4	1201.085	218.256	1.013131
SumNarrow_BitMath	1202.933	217.921	1.011574
SumNarrow_BitMathUnrolling4	834.924	313.974	1.457445
SumNarrowVectorBase	18.609	14087.110	65.391487
SumNarrowVectorTraits	18.512	14160.671	65.732951

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1218.156	215.197
SumNarrow_MinMax	1225.654	213.881	0.993883
SumNarrow_BitMath	593.596	441.620	2.052164
SumNarrowVectorBase	38.825	6751.995	31.375820
SumNarrowVectorTraits	38.765	6762.353	31.423953

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1361.171	192.587
SumNarrow_MinMax	1451.883	180.554	0.937521
SumNarrow_BitMath	772.879	339.179	1.761170
SumNarrowVectorBase	137.102	1912.031	9.928133
SumNarrowVectorTraits	137.165	1911.157	9.923596

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	257.910	1016.416
SumNarrow_IfUnrolling4	241.088	1087.338	1.069777
SumNarrow_MinMax	295.911	885.888	0.871581
SumNarrow_MinMaxUnrolling4	218.982	1197.103	1.177770
SumNarrow_BitMath	438.947	597.211	0.587565
SumNarrow_BitMathUnrolling4	548.632	477.814	0.470097
SumNarrowVectorBase	14.634	17912.836	17.623535
SumNarrowVectorTraits	14.353	18264.191	17.969215

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	279.848	936.738
SumNarrow_MinMax	282.625	927.532	0.990173
SumNarrow_BitMath	491.834	532.992	0.568988
SumNarrowVectorBase	34.478	7603.276	8.116758
SumNarrowVectorTraits	34.439	7611.850	8.125912

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	273.240	959.392
SumNarrow_MinMax	295.697	886.529	0.924053
SumNarrow_BitMath	359.546	729.096	0.759957
SumNarrowVectorBase	127.687	2053.017	2.139915
SumNarrowVectorTraits	127.672	2053.259	2.140168

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1246.928	210.232
SumNarrow_IfUnrolling4	1251.392	209.482	0.996432
SumNarrow_MinMax	1219.894	214.891	1.022161
SumNarrow_MinMaxUnrolling4	1230.423	213.052	1.013413
SumNarrow_BitMath	1194.686	219.425	1.043728
SumNarrow_BitMathUnrolling4	779.163	336.443	1.600341
SumNarrowVectorBase	19.464	13468.290	64.063961
SumNarrowVectorTraits	9.221	28429.208	135.227832
SumNarrowVector128Traits	12.327	21265.910	101.154517
SumNarrowVector256Traits	9.231	28397.933	135.079066

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1214.261	215.888
SumNarrow_MinMax	1245.679	210.443	0.974778
SumNarrow_BitMath	739.428	354.523	1.642162
SumNarrowVectorBase	39.494	6637.639	30.745787
SumNarrowVectorTraits	18.743	13986.307	64.785089
SumNarrowVector128Traits	24.614	10650.155	49.331912
SumNarrowVector256Traits	18.334	14297.940	66.228586

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1292.534	202.814
SumNarrow_MinMax	1346.590	194.672	0.959857
SumNarrow_BitMath	773.866	338.746	1.670230
SumNarrowVectorBase	127.261	2059.889	10.156546
SumNarrowVectorTraits	99.874	2624.759	12.941705
SumNarrowVector128Traits	232.718	1126.444	5.554077
SumNarrowVector256Traits	99.727	2628.627	12.960779

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	241.208	1086.797
SumNarrow_IfUnrolling4	241.131	1087.144	1.000319
SumNarrow_MinMax	268.082	977.852	0.899756
SumNarrow_MinMaxUnrolling4	220.929	1186.553	1.091789
SumNarrow_BitMath	439.255	596.792	0.549129
SumNarrow_BitMathUnrolling4	533.319	491.534	0.452277
SumNarrowVectorBase	16.953	15463.393	14.228410
SumNarrowVectorTraits	11.276	23247.067	21.390441
SumNarrowVector128Traits	16.666	15729.433	14.473202
SumNarrowVector256Traits	11.365	23065.049	21.222959

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	304.097	862.041
SumNarrow_MinMax	308.516	849.694	0.985678
SumNarrow_BitMath	588.634	445.343	0.516615
SumNarrowVectorBase	30.446	8610.053	9.987988
SumNarrowVectorTraits	21.113	12416.410	14.403506
SumNarrowVector128Traits	33.328	7865.636	9.124436
SumNarrowVector256Traits	21.424	12236.051	14.194283

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	232.999	1125.086
SumNarrow_MinMax	262.697	997.897	0.886952
SumNarrow_BitMath	363.732	720.707	0.640579
SumNarrowVectorBase	128.179	2045.137	1.817762
SumNarrowVectorTraits	87.581	2993.174	2.660397
SumNarrowVector128Traits	155.978	1680.652	1.493799
SumNarrowVector256Traits	87.930	2981.285	2.649830

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1295.559	202.340
SumNarrow_IfUnrolling4	1239.471	211.497	1.045251
SumNarrow_MinMax	1216.833	215.431	1.064698
SumNarrow_MinMaxUnrolling4	1207.611	217.077	1.072829
SumNarrow_BitMath	1207.504	217.096	1.072923
SumNarrow_BitMathUnrolling4	1135.439	230.875	1.141020
SumNarrowVectorBase	19.993	13111.910	64.801232
SumNarrowVectorTraits	9.319	28128.607	139.016239
SumNarrowVector128Traits	12.311	21293.082	105.233943
SumNarrowVector256Traits	9.216	28445.982	140.584759

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1231.621	212.845
SumNarrow_MinMax	1225.968	213.826	1.004610
SumNarrow_BitMath	1037.425	252.687	1.187190
SumNarrowVectorBase	38.698	6774.121	31.826578
SumNarrowVectorTraits	18.224	14384.912	67.584049
SumNarrowVector128Traits	24.532	10685.906	50.205161
SumNarrowVector256Traits	18.526	14150.012	66.480430

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1329.593	197.161
SumNarrow_MinMax	1318.750	198.782	1.008222
SumNarrow_BitMath	951.124	275.615	1.397917
SumNarrowVectorBase	121.477	2157.975	10.945240
SumNarrowVectorTraits	92.066	2847.360	14.441796
SumNarrowVector128Traits	140.858	1861.054	9.439256
SumNarrowVector256Traits	92.298	2840.202	14.405491

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	294.282	890.792
SumNarrow_IfUnrolling4	239.085	1096.445	1.230865
SumNarrow_MinMax	285.303	918.826	1.031470
SumNarrow_MinMaxUnrolling4	220.642	1188.095	1.333751
SumNarrow_BitMath	897.603	292.049	0.327853
SumNarrow_BitMathUnrolling4	895.225	292.825	0.328724
SumNarrowVectorBase	15.330	17100.289	19.196718
SumNarrowVectorTraits	10.026	26147.027	29.352551
SumNarrowVector128Traits	14.838	17667.422	19.833379
SumNarrowVector256Traits	9.960	26319.795	29.546500

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	283.592	924.369
SumNarrow_MinMax	284.259	922.200	0.997653
SumNarrow_BitMath	1011.144	259.255	0.280467
SumNarrowVectorBase	31.703	8268.696	8.945229
SumNarrowVectorTraits	24.021	10913.129	11.806026
SumNarrowVector128Traits	29.657	8839.065	9.562265
SumNarrowVector256Traits	22.945	11425.101	12.359886

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	306.314	855.803
SumNarrow_MinMax	233.063	1124.778	1.314295
SumNarrow_BitMath	463.772	565.243	0.660483
SumNarrowVectorBase	101.730	2576.865	3.011050
SumNarrowVectorTraits	75.395	3476.921	4.062760
SumNarrowVector128Traits	119.131	2200.474	2.571240
SumNarrowVector256Traits	75.303	3481.194	4.067752

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1218.814	215.081
SumNarrow_IfUnrolling4	1243.584	210.797	0.980082
SumNarrow_MinMax	1273.235	205.888	0.957257
SumNarrow_MinMaxUnrolling4	1290.553	203.125	0.944412
SumNarrow_BitMath	938.341	279.370	1.298902
SumNarrow_BitMathUnrolling4	941.889	278.317	1.294010
SumNarrowVectorBase	19.806	13235.857	61.538863
SumNarrowVectorTraits	9.243	28360.517	131.859535
SumNarrowVector128Traits	12.384	21167.205	98.414911
SumNarrowVector256Traits	9.221	28427.650	132.171662

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1232.513	212.691
SumNarrow_MinMax	1226.518	213.730	1.004887
SumNarrow_BitMath	1037.824	252.590	1.187593
SumNarrowVectorBase	35.259	7434.739	34.955633
SumNarrowVectorTraits	18.297	14327.294	67.362100
SumNarrowVector128Traits	24.515	10693.391	50.276716
SumNarrowVector256Traits	18.265	14351.983	67.478182

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1335.509	196.288
SumNarrow_MinMax	1349.215	194.294	0.989842
SumNarrow_BitMath	951.031	275.642	1.404276
SumNarrowVectorBase	121.324	2160.685	11.007747
SumNarrowVectorTraits	92.089	2846.629	14.502331
SumNarrowVector128Traits	140.805	1861.747	9.484789
SumNarrowVector256Traits	92.084	2846.789	14.503147

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	290.842	901.329
SumNarrow_IfUnrolling4	237.331	1104.548	1.225467
SumNarrow_MinMax	280.957	933.039	1.035182
SumNarrow_MinMaxUnrolling4	335.364	781.670	0.867242
SumNarrow_BitMath	897.762	291.997	0.323963
SumNarrow_BitMathUnrolling4	895.027	292.890	0.324953
SumNarrowVectorBase	15.461	16955.355	18.811508
SumNarrowVectorTraits	10.075	26019.558	28.867994
SumNarrowVector128Traits	14.535	18035.155	20.009516
SumNarrowVector256Traits	9.831	26664.041	29.583031

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	281.518	931.181
SumNarrow_MinMax	282.943	926.491	0.994963
SumNarrow_BitMath	1013.064	258.764	0.277887
SumNarrowVectorBase	31.769	8251.533	8.861359
SumNarrowVectorTraits	23.360	11221.684	12.051018
SumNarrowVector128Traits	29.179	8983.880	9.647829
SumNarrowVector256Traits	23.262	11269.070	12.101906

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	305.206	858.908
SumNarrow_MinMax	286.731	914.250	1.064433
SumNarrow_BitMath	459.916	569.982	0.663612
SumNarrowVectorBase	100.404	2610.890	3.039779
SumNarrowVectorTraits	74.482	3519.585	4.097745
SumNarrowVector128Traits	136.723	1917.330	2.232289
SumNarrowVector256Traits	73.569	3563.263	4.148599

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1202.140	218.064
SumNarrow_IfUnrolling4	1245.522	210.469	0.965170
SumNarrow_MinMax	1190.652	220.168	1.009649
SumNarrow_MinMaxUnrolling4	1235.481	212.180	0.973014
SumNarrow_BitMath	727.422	360.374	1.652603
SumNarrow_BitMathUnrolling4	775.736	337.929	1.549676
SumNarrowVectorBase	16.852	15555.509	71.334462
SumNarrowVectorTraits	9.223	28421.514	130.335395
SumNarrowVector128Traits	12.228	21438.466	98.312530
SumNarrowVector256Traits	9.171	28585.371	131.086812

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1180.523	222.057
SumNarrow_MinMax	1231.503	212.865	0.958603
SumNarrow_BitMath	603.519	434.359	1.956067
SumNarrowVectorBase	29.479	8892.525	40.046058
SumNarrowVectorTraits	18.169	14428.024	64.974290
SumNarrowVector128Traits	25.740	10184.370	45.863674
SumNarrowVector256Traits	20.163	13000.954	58.547708

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1288.992	203.371
SumNarrow_MinMax	1270.539	206.325	1.014524
SumNarrow_BitMath	607.676	431.388	2.121185
SumNarrowVectorBase	94.252	2781.300	13.675970
SumNarrowVectorTraits	103.221	2539.630	12.487652
SumNarrowVector128Traits	174.911	1498.731	7.369430
SumNarrowVector256Traits	103.277	2538.271	12.480970

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	241.527	1085.363
SumNarrow_IfUnrolling4	236.433	1108.743	1.021542
SumNarrow_MinMax	330.083	794.177	0.731716
SumNarrow_MinMaxUnrolling4	297.509	881.130	0.811830
SumNarrow_BitMath	443.038	591.696	0.545160
SumNarrow_BitMathUnrolling4	436.630	600.380	0.553160
SumNarrowVectorBase	12.886	20342.540	18.742614
SumNarrowVectorTraits	10.509	24943.556	22.981763
SumNarrowVector128Traits	16.748	15652.327	14.421283
SumNarrowVector256Traits	10.535	24883.433	22.926369

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	233.157	1124.325
SumNarrow_MinMax	304.401	861.181	0.765954
SumNarrow_BitMath	385.655	679.738	0.604574
SumNarrowVectorBase	25.404	10319.090	9.178032
SumNarrowVectorTraits	21.072	12440.105	11.064511
SumNarrowVector128Traits	33.522	7819.961	6.955251
SumNarrowVector256Traits	20.785	12612.260	11.217629

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	233.192	1124.154
SumNarrow_MinMax	312.998	837.526	0.745028
SumNarrow_BitMath	395.156	663.393	0.590127
SumNarrowVectorBase	76.967	3405.935	3.029777
SumNarrowVectorTraits	77.112	3399.524	3.024074
SumNarrowVector128Traits	120.023	2184.109	1.942891
SumNarrowVector256Traits	77.241	3393.832	3.019010

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1665.282	157.417
SumNarrow_IfUnrolling4	1639.341	159.908	1.015824
SumNarrow_MinMax	1628.664	160.956	1.022483
SumNarrow_MinMaxUnrolling4	1618.041	162.013	1.029196
SumNarrow_BitMath	1241.922	211.079	1.340891
SumNarrow_BitMathUnrolling4	1257.566	208.453	1.324210
SumNarrowVectorBase	43.369	6044.523	38.398109
SumNarrowVectorTraits	43.407	6039.229	38.364477
SumNarrowVector128Traits	2133.136	122.891	0.780673
SumNarrowVector256Traits	3180.455	82.423	0.523599

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1585.783	165.309
SumNarrow_MinMax	1618.084	162.009	0.980037
SumNarrow_BitMath	1045.480	250.740	1.516798
SumNarrowVectorBase	85.351	3071.364	18.579542
SumNarrowVectorTraits	86.920	3015.939	18.244258
SumNarrowVector128Traits	4038.667	64.909	0.392650
SumNarrowVector256Traits	5819.471	45.046	0.272496

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1613.490	162.470
SumNarrow_MinMax	1699.953	154.207	0.949138
SumNarrow_BitMath	1054.083	248.694	1.530704
SumNarrowVectorBase	366.306	715.642	4.404761
SumNarrowVectorTraits	366.621	715.027	4.400972
SumNarrowVector128Traits	5763.494	45.484	0.279950
SumNarrowVector256Traits	6780.334	38.662	0.237966

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	496.304	528.192
SumNarrow_IfUnrolling4	515.684	508.343	0.962420
SumNarrow_MinMax	455.122	575.986	1.090487
SumNarrow_MinMaxUnrolling4	477.216	549.319	1.039998
SumNarrow_BitMath	797.804	328.582	0.622088
SumNarrow_BitMathUnrolling4	813.325	322.312	0.610217
SumNarrowVectorBase	29.943	8754.855	16.575137
SumNarrowVectorTraits	30.420	8617.492	16.315074
SumNarrowVector128Traits	1353.267	193.712	0.366745
SumNarrowVector256Traits	1832.053	143.088	0.270901

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	484.553	541.002
SumNarrow_MinMax	481.064	544.926	1.007252
SumNarrow_BitMath	708.870	369.806	0.683557
SumNarrowVectorBase	66.209	3959.347	7.318542
SumNarrowVectorTraits	66.269	3955.773	7.311934
SumNarrowVector128Traits	2471.507	106.066	0.196056
SumNarrowVector256Traits	3414.190	76.781	0.141923

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.550	620.385
SumNarrow_MinMax	422.780	620.048	0.999456
SumNarrow_BitMath	672.212	389.972	0.628597
SumNarrowVectorBase	203.578	1287.681	2.075614
SumNarrowVectorTraits	203.747	1286.616	2.073898
SumNarrowVector128Traits	3242.981	80.834	0.130297
SumNarrowVector256Traits	4175.752	62.778	0.101191

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1694.624	154.692
SumNarrow_IfUnrolling4	1653.823	158.508	1.024671
SumNarrow_MinMax	1581.722	165.733	1.071379
SumNarrow_MinMaxUnrolling4	1604.437	163.387	1.056211
SumNarrow_BitMath	1583.953	165.500	1.069870
SumNarrow_BitMathUnrolling4	1611.837	162.637	1.051362
SumNarrowVectorBase	42.323	6193.938	40.040580
SumNarrowVectorTraits	19.475	13460.358	87.014196
SumNarrowVector128Traits	19.520	13429.272	86.813246
SumNarrowVector256Traits	3225.966	81.261	0.525307

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1585.374	165.352
SumNarrow_MinMax	1617.984	162.019	0.979845
SumNarrow_BitMath	1345.535	194.825	1.178248
SumNarrowVectorBase	80.193	3268.933	19.769595
SumNarrowVectorTraits	42.823	6121.553	37.021451
SumNarrowVector128Traits	42.813	6122.989	37.030135
SumNarrowVector256Traits	4891.129	53.596	0.324133

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1631.368	160.690
SumNarrow_MinMax	1662.772	157.655	0.981114
SumNarrow_BitMath	1367.111	191.750	1.193296
SumNarrowVectorBase	226.552	1157.104	7.200864
SumNarrowVectorTraits	84.163	3114.720	19.383452
SumNarrowVector128Traits	84.996	3084.209	19.193577
SumNarrowVector256Traits	7963.162	32.920	0.204864

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	508.943	515.076
SumNarrow_IfUnrolling4	515.835	508.194	0.986639
SumNarrow_MinMax	498.933	525.410	1.020063
SumNarrow_MinMaxUnrolling4	481.064	544.925	1.057951
SumNarrow_BitMath	1010.621	259.389	0.503594
SumNarrow_BitMathUnrolling4	1058.937	247.554	0.480617
SumNarrowVectorBase	31.061	8439.577	16.385123
SumNarrowVectorTraits	20.001	13106.613	25.445998
SumNarrowVector128Traits	20.010	13100.479	25.434088
SumNarrowVector256Traits	1760.020	148.944	0.289169

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	490.247	534.718
SumNarrow_MinMax	488.138	537.029	1.004321
SumNarrow_BitMath	917.617	285.679	0.534261
SumNarrowVectorBase	65.191	4021.154	7.520135
SumNarrowVectorTraits	41.341	6340.994	11.858569
SumNarrowVector128Traits	38.236	6855.859	12.821441
SumNarrowVector256Traits	2475.436	105.898	0.198045

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.051	621.120
SumNarrow_MinMax	422.710	620.151	0.998440
SumNarrow_BitMath	882.894	296.914	0.478031
SumNarrowVectorBase	143.938	1821.232	2.932175
SumNarrowVectorTraits	75.128	3489.303	5.617762
SumNarrowVector128Traits	81.051	3234.292	5.207196
SumNarrowVector256Traits	3737.696	70.135	0.112917

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1666.966	157.258
SumNarrow_IfUnrolling4	1617.078	162.110	1.030851
SumNarrow_MinMax	2415.064	108.545	0.690237
SumNarrow_MinMaxUnrolling4	1784.294	146.918	0.934244
SumNarrow_BitMath	1582.041	165.700	1.053681
SumNarrow_BitMathUnrolling4	1596.018	164.249	1.044453
SumNarrowVectorBase	43.837	5979.916	38.026121
SumNarrowVectorTraits	21.748	12053.732	76.649348
SumNarrowVector128Traits	20.709	12658.154	80.492853
SumNarrowVector256Traits	5405.592	48.495	0.308378

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1543.604	169.826
SumNarrow_MinMax	1708.746	153.413	0.903355
SumNarrow_BitMath	1347.186	194.586	1.145799
SumNarrowVectorBase	83.093	3154.830	18.576845
SumNarrowVectorTraits	42.526	6164.284	36.297663
SumNarrowVector128Traits	42.659	6145.077	36.184563
SumNarrowVector256Traits	5167.005	50.734	0.298743

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1633.810	160.450
SumNarrow_MinMax	1580.886	165.821	1.033477
SumNarrow_BitMath	1363.272	192.290	1.198448
SumNarrowVectorBase	230.436	1137.600	7.090080
SumNarrowVectorTraits	84.159	3114.881	19.413462
SumNarrowVector128Traits	84.983	3084.659	19.225108
SumNarrowVector256Traits	7857.028	33.364	0.207942

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	506.249	517.816
SumNarrow_IfUnrolling4	517.110	506.940	0.978997
SumNarrow_MinMax	456.759	573.922	1.108351
SumNarrow_MinMaxUnrolling4	483.596	542.072	1.046842
SumNarrow_BitMath	1012.556	258.893	0.499971
SumNarrow_BitMathUnrolling4	1052.384	249.095	0.481050
SumNarrowVectorBase	33.393	7850.298	15.160391
SumNarrowVectorTraits	19.449	13478.400	26.029307
SumNarrowVector128Traits	19.448	13479.084	26.030629
SumNarrowVector256Traits	1774.820	147.702	0.285240

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	490.806	534.109
SumNarrow_MinMax	494.815	529.782	0.991898
SumNarrow_BitMath	917.871	285.600	0.534722
SumNarrowVectorBase	62.402	4200.870	7.865193
SumNarrowVectorTraits	41.726	6282.575	11.762722
SumNarrowVector128Traits	39.009	6720.106	12.581902
SumNarrowVector256Traits	2495.518	105.046	0.196675

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	423.938	618.355
SumNarrow_MinMax	424.308	617.816	0.999128
SumNarrow_BitMath	884.775	296.283	0.479147
SumNarrowVectorBase	141.352	1854.543	2.999156
SumNarrowVectorTraits	76.146	3442.668	5.567461
SumNarrowVector128Traits	81.842	3203.035	5.179929
SumNarrowVector256Traits	3600.020	72.817	0.117760

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1440.815	181.941
SumNarrow_IfUnrolling4	1405.700	186.487	1.024981
SumNarrow_MinMax	1419.995	184.609	1.014662
SumNarrow_MinMaxUnrolling4	1406.922	186.324	1.024090
SumNarrow_BitMath	1275.647	205.499	1.129478
SumNarrow_BitMathUnrolling4	1276.037	205.436	1.129133
SumNarrowVectorBase	38.670	6778.968	37.259061
SumNarrowVectorTraits	16.943	15472.104	85.038917
SumNarrowVector128Traits	17.256	15191.105	83.494471
SumNarrowVector256Traits	4282.214	61.217	0.336465

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1371.861	191.086
SumNarrow_MinMax	1337.883	195.939	1.025397
SumNarrow_BitMath	1010.096	259.524	1.358149
SumNarrowVectorBase	74.714	3508.643	18.361550
SumNarrowVectorTraits	33.795	7756.942	40.593890
SumNarrowVector128Traits	34.194	7666.446	40.120301
SumNarrowVector256Traits	4540.156	57.739	0.302162

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1276.641	205.339
SumNarrow_MinMax	1327.646	197.450	0.961582
SumNarrow_BitMath	1065.359	246.062	1.198320
SumNarrowVectorBase	210.741	1243.915	6.057865
SumNarrowVectorTraits	66.228	3958.193	19.276393
SumNarrowVector128Traits	64.843	4042.758	19.688222
SumNarrowVector256Traits	4076.431	64.307	0.313176

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	430.557	608.849
SumNarrow_IfUnrolling4	373.288	702.256	1.153416
SumNarrow_MinMax	430.777	608.538	0.999490
SumNarrow_MinMaxUnrolling4	378.714	692.196	1.136893
SumNarrow_BitMath	785.872	333.571	0.547871
SumNarrow_BitMathUnrolling4	787.055	333.070	0.547048
SumNarrowVectorBase	29.579	8862.558	14.556252
SumNarrowVectorTraits	18.640	14063.862	23.099100
SumNarrowVector128Traits	18.428	14225.569	23.364694
SumNarrowVector256Traits	1387.054	188.993	0.310411

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	422.334	620.704
SumNarrow_MinMax	422.233	620.851	1.000238
SumNarrow_BitMath	645.835	405.899	0.653934
SumNarrowVectorBase	60.954	4300.706	6.928759
SumNarrowVectorTraits	40.177	6524.682	10.511750
SumNarrowVector128Traits	40.294	6505.829	10.481375
SumNarrowVector256Traits	1638.500	159.990	0.257756

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	316.566	828.085
SumNarrow_MinMax	316.668	827.820	0.999679
SumNarrow_BitMath	626.514	418.417	0.505282
SumNarrowVectorBase	144.701	1811.620	2.187721
SumNarrowVectorTraits	75.086	3491.233	4.216030
SumNarrowVector128Traits	75.261	3483.151	4.206271
SumNarrowVector256Traits	1757.176	149.185	0.180156

```

