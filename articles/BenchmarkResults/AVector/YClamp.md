# Benchmark - YClamp
([← Back](README.md))

See [Group](YClamp_Group.md)

- `YClamp`: Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
  Mnemonic: `rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])` .

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9277.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.256844812
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.256844812!=130882.256844812
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. ��!=130882.256844812
SumClamp_If	1293.232	202.705
SumClamp_MinMax	1346.976	194.617	0.960100
SumClamp_BitMath	780.370	335.923	1.657203
SumClampVectorScalar	232.243	1128.746	5.568431
SumClampVectorBase	58.205	4503.828	22.218678
SumClampVectorTraits	115.405	2271.512	11.206021

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1216.639	215.466
SumClamp_MinMax	1344.824	194.928	0.904683
SumClamp_BitMath	1155.419	226.882	1.052985
SumClampVectorScalar	287.030	913.299	4.238720
SumClampVectorBase	7.709	34003.589	157.814338
SumClampVectorTraits	9.113	28764.817	133.500627

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1157.217	226.530
SumClamp_MinMax	1261.798	207.754	0.917117
SumClamp_BitMath	510.826	513.177	2.265385
SumClampVectorScalar	194.850	1345.361	5.939006
SumClampVectorBase	16.811	15593.722	68.837427
SumClampVectorTraits	17.638	14862.737	65.610545

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 7714737504780401444!=-141951893350734
SumClamp_If	1218.741	215.094
SumClamp_MinMax	1295.447	202.358	0.940788
SumClamp_BitMath	555.280	472.093	2.194821
SumClampVectorScalar	282.564	927.733	4.313148
SumClampVectorBase	58.177	4505.962	20.948798
SumClampVectorTraits	72.968	3592.604	16.702476

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1362.115	192.454
SumClamp_MinMax	1285.282	203.958	1.059779
SumClamp_BitMath	853.262	307.226	1.596362
SumClampVectorScalar	286.600	914.667	4.752663
SumClampVectorBase	3.659	71641.753	372.254546
SumClampVectorTraits	4.248	61717.118	320.685589

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.5
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.3!=130883.5
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.3!=130883.5
SumClamp_If	1299.117	201.786
SumClamp_MinMax	1411.668	185.698	0.920271
SumClamp_BitMath	781.898	335.266	1.661492
SumClampVectorScalar	232.052	1129.678	5.598388
SumClampVectorBase	30.224	8673.371	42.982958
SumClampVectorTraits	30.030	8729.298	43.260115

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.256844812
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.256844812!=130882.256844812
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. ��!=130882.256844812
SumClamp_If	1328.531	197.319
SumClamp_MinMax	1452.912	180.427	0.914392
SumClamp_Math	1349.330	194.277	0.984586
SumClamp_BitMath	804.063	326.024	1.652272
SumClampVectorScalar	230.875	1135.436	5.754329
SumClampVectorBase	58.388	4489.727	22.753690
SumClampVectorTraits	115.731	2265.122	11.479514

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1285.858	203.867
SumClamp_MinMax	1289.614	203.273	0.997087
SumClamp_Math	1278.589	205.026	1.005685
SumClamp_BitMath	1160.487	225.891	1.108033
SumClampVectorScalar	312.840	837.948	4.110270
SumClampVectorBase	7.750	33825.858	165.921222
SumClampVectorTraits	9.593	27327.585	134.046159

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1149.461	228.058
SumClamp_MinMax	1243.517	210.809	0.924363
SumClamp_Math	1238.639	211.639	0.928003
SumClamp_BitMath	543.469	482.353	2.115043
SumClampVectorScalar	204.083	1284.497	5.632322
SumClampVectorBase	17.883	14658.927	64.277143
SumClampVectorTraits	19.881	13185.539	57.816563

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 7714737504780401444!=-141951893350734
SumClamp_If	1304.727	200.919
SumClamp_MinMax	1302.729	201.227	1.001534
SumClamp_Math	1299.664	201.701	1.003895
SumClamp_BitMath	592.410	442.505	2.202406
SumClampVectorScalar	306.183	856.166	4.261258
SumClampVectorBase	63.920	4101.117	20.411826
SumClampVectorTraits	79.430	3300.309	16.426093

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1413.724	185.428
SumClamp_MinMax	1272.487	206.009	1.110994
SumClamp_Math	1336.860	196.089	1.057497
SumClamp_BitMath	863.002	303.758	1.638146
SumClampVectorScalar	313.077	837.315	4.515583
SumClampVectorBase	3.802	68956.263	371.876364
SumClampVectorTraits	4.679	56028.755	302.159202

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.5
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.3!=130883.5
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.3!=130883.5
SumClamp_If	1325.199	197.815
SumClamp_MinMax	1395.647	187.830	0.949523
SumClamp_Math	1332.902	196.672	0.994221
SumClamp_BitMath	834.064	314.297	1.588846
SumClampVectorScalar	231.171	1133.984	5.732555
SumClampVectorBase	30.046	8724.618	44.104985
SumClampVectorTraits	30.146	8695.793	43.959265

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. ��!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1341.415	195.424
SumClamp_MinMax	2048.681	127.957	0.654770
SumClamp_Math	1357.457	193.114	0.988182
SumClamp_BitMath	839.883	312.120	1.597145
SumClampVectorScalar	230.847	1135.577	5.810848
SumClampVectorBase	58.326	4494.474	22.998632
SumClampVectorTraits	115.539	2268.877	11.610048
SumClampVector128Base	6288.473	41.686	0.213313
SumClampVector128Traits	116.106	2257.797	11.553350
SumClampVector256Traits	58.808	4457.659	22.810247

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1237.117	211.899
SumClamp_MinMax	1251.584	209.450	0.988441
SumClamp_Math	1301.943	201.348	0.950208
SumClamp_BitMath	805.357	325.500	1.536110
SumClampVectorScalar	330.082	794.180	3.747913
SumClampVectorBase	8.331	31464.923	148.490118
SumClampVectorTraits	9.718	26973.996	127.296411
SumClampVector128Base	2069.264	126.685	0.597854
SumClampVector128Traits	14.880	17616.863	83.137974
SumClampVector256Traits	8.065	32504.630	153.396728

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1157.817	226.412
SumClamp_MinMax	1226.686	213.701	0.943858
SumClamp_Math	1186.751	220.892	0.975619
SumClamp_BitMath	547.807	478.533	2.113549
SumClampVectorScalar	205.757	1274.048	5.627118
SumClampVectorBase	17.678	14829.074	65.495896
SumClampVectorTraits	18.953	13831.556	61.090137
SumClampVector128Base	3208.208	81.710	0.360892
SumClampVector128Traits	40.459	6479.275	28.617155
SumClampVector256Traits	16.369	16014.514	70.731659

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 7714737504780401444!=-141951893350734
SumClamp_If	1289.743	203.253
SumClamp_MinMax	1291.458	202.983	0.998672
SumClamp_Math	1225.567	213.896	1.052364
SumClamp_BitMath	608.613	430.724	2.119151
SumClampVectorScalar	340.498	769.884	3.787812
SumClampVectorBase	64.583	4059.022	19.970298
SumClampVectorTraits	57.051	4594.900	22.606803
SumClampVector128Base	6034.206	43.443	0.213739
SumClampVector128Traits	123.541	2121.924	10.439816
SumClampVector256Traits	43.026	6092.719	29.976041

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1297.183	202.087
SumClamp_MinMax	1326.952	197.554	0.977566
SumClamp_Math	1341.958	195.344	0.966634
SumClamp_BitMath	803.337	326.319	1.614743
SumClampVectorScalar	326.047	804.008	3.978519
SumClampVectorBase	3.808	68832.941	340.610119
SumClampVectorTraits	5.129	51113.469	252.927808
SumClampVector128Base	1319.225	198.711	0.983291
SumClampVector128Traits	9.567	27402.284	135.596344
SumClampVector256Traits	3.921	66856.394	330.829455

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1334.144	196.489
SumClamp_MinMax	2054.292	127.608	0.649442
SumClamp_Math	1357.707	193.078	0.982645
SumClamp_BitMath	801.953	326.882	1.663618
SumClampVectorScalar	230.801	1135.803	5.780504
SumClampVectorBase	30.026	8730.685	44.433559
SumClampVectorTraits	30.055	8722.288	44.390823
SumClampVector128Base	3313.803	79.107	0.402602
SumClampVector128Traits	58.898	4450.811	22.651758
SumClampVector256Traits	30.137	8698.360	44.269045

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. ��!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1347.351	194.562
SumClamp_MinMax	1751.629	149.657	0.769199
SumClamp_Math	1355.726	193.361	0.993822
SumClamp_BitMath	1209.863	216.672	1.113639
SumClampVectorScalar	231.289	1133.406	5.825407
SumClampVectorBase	58.082	4513.376	23.197566
SumClampVectorTraits	115.268	2274.214	11.688863
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	6743.354	38.874	0.199804
SumClampVector128Traits	115.697	2265.779	11.645511
SumClampVector256Traits	58.090	4512.731	23.194252

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1297.567	202.027
SumClamp_MinMax	1273.296	205.878	1.019061
SumClamp_Math	1206.040	217.359	1.075890
SumClamp_BitMath	1447.318	181.124	0.896532
SumClampVectorScalar	316.813	827.440	4.095683
SumClampVectorBase	7.601	34488.939	170.714159
SumClampVectorTraits	7.490	35001.367	173.250590
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	2464.542	106.366	0.526494
SumClampVector128Traits	14.306	18323.806	90.699606
SumClampVector256Traits	7.830	33477.547	165.707949

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1202.711	217.961
SumClamp_MinMax	1291.806	202.928	0.931031
SumClamp_Math	1214.292	215.882	0.990463
SumClamp_BitMath	1151.138	227.726	1.044802
SumClampVectorScalar	203.350	1289.125	5.914478
SumClampVectorBase	16.507	15881.108	72.862199
SumClampVectorTraits	17.535	14949.978	68.590196
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	3368.308	77.827	0.357067
SumClampVector128Traits	30.750	8524.922	39.112168
SumClampVector256Traits	17.074	15353.667	70.442312

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 7714737504780401444!=-141951893350734
SumClamp_If	1232.800	212.641
SumClamp_MinMax	1322.002	198.293	0.932525
SumClamp_Math	1256.413	208.645	0.981206
SumClamp_BitMath	1237.704	211.799	0.996038
SumClampVectorScalar	307.307	853.037	4.011630
SumClampVectorBase	61.234	4280.986	20.132450
SumClampVectorTraits	53.677	4883.761	22.967155
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	6436.099	40.730	0.191545
SumClampVector128Traits	80.667	3249.693	15.282525
SumClampVector256Traits	41.997	6241.974	29.354506

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1366.312	191.862
SumClamp_MinMax	1329.545	197.168	1.027653
SumClamp_Math	1328.719	197.291	1.028293
SumClamp_BitMath	1418.532	184.800	0.963187
SumClampVectorScalar	321.391	815.654	4.251241
SumClampVectorBase	3.855	67999.561	354.418204
SumClampVectorTraits	3.781	69327.479	361.339400
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	1505.354	174.141	0.907635
SumClampVector128Traits	6.973	37595.755	195.951561
SumClampVector256Traits	4.088	64120.199	334.198714

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1355.572	193.383
SumClamp_MinMax	1760.860	148.873	0.769835
SumClamp_Math	1357.103	193.164	0.998872
SumClamp_BitMath	1199.185	218.602	1.130411
SumClampVectorScalar	230.850	1135.559	5.872086
SumClampVectorBase	30.186	8684.232	44.907005
SumClampVectorTraits	30.143	8696.538	44.970640
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	3721.436	70.442	0.364260
SumClampVector128Traits	58.866	4453.261	23.028245
SumClampVector256Traits	29.500	8886.137	45.951077

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.33
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.33\
RuntimeInformation.FrameworkDescription:	.NET 6.0.33
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.33/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. ��!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1326.531	197.616
SumClamp_MinMax	1648.090	159.059	0.804890
SumClamp_Math	1355.432	193.403	0.978678
SumClamp_BitMath	968.136	270.772	1.370191
SumClampVectorScalar	230.969	1134.976	5.743339
SumClampVectorBase	58.218	4502.763	22.785398
SumClampVectorTraits	115.266	2274.245	11.508396
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	6791.862	38.597	0.195312
SumClampVector128Traits	119.624	2191.398	11.089166
SumClampVector256Traits	58.146	4508.344	22.813642

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1234.906	212.278
SumClamp_MinMax	1365.868	191.925	0.904118
SumClamp_Math	1261.084	207.872	0.979242
SumClamp_BitMath	1272.303	206.039	0.970607
SumClampVectorScalar	308.610	849.433	4.001505
SumClampVectorBase	7.458	35149.309	165.581136
SumClampVectorTraits	7.534	34795.193	163.912970
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	2390.818	109.646	0.516520
SumClampVector128Traits	15.036	17434.459	82.130135
SumClampVector256Traits	7.551	34717.813	163.548449

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1192.075	219.906
SumClamp_MinMax	1244.889	210.576	0.957575
SumClamp_Math	1178.034	222.527	1.011918
SumClamp_BitMath	1151.057	227.742	1.035635
SumClampVectorScalar	199.396	1314.694	5.978443
SumClampVectorBase	16.697	15700.335	71.395760
SumClampVectorTraits	16.670	15725.476	71.510091
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	3411.108	76.850	0.349468
SumClampVector128Traits	29.483	8891.235	40.432035
SumClampVector256Traits	17.948	14605.358	66.416458

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 7714737504780401444!=-141951893350734
SumClamp_If	1219.025	215.044
SumClamp_MinMax	1243.838	210.754	0.980051
SumClamp_Math	1268.278	206.693	0.961166
SumClamp_BitMath	1236.214	212.054	0.986096
SumClampVectorScalar	265.694	986.640	4.588083
SumClampVectorBase	61.788	4242.662	19.729272
SumClampVectorTraits	53.939	4859.989	22.599975
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	6599.097	39.724	0.184726
SumClampVector128Traits	81.734	3207.283	14.914543
SumClampVector256Traits	41.978	6244.790	29.039591

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1308.799	200.294
SumClamp_MinMax	1386.689	189.043	0.943830
SumClamp_Math	1331.713	196.847	0.982793
SumClamp_BitMath	1294.767	202.464	1.010837
SumClampVectorScalar	306.822	854.385	4.265664
SumClampVectorBase	3.786	69247.135	345.728117
SumClampVectorTraits	3.642	71981.626	359.380530
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	1501.953	174.535	0.871398
SumClampVector128Traits	7.590	34536.431	172.429016
SumClampVector256Traits	3.836	68332.899	341.163638

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1315.518	199.270
SumClamp_MinMax	1773.696	147.795	0.741682
SumClamp_Math	1320.378	198.537	0.996320
SumClamp_BitMath	1056.409	248.146	1.245274
SumClampVectorScalar	230.373	1137.909	5.710375
SumClampVectorBase	30.365	8633.009	43.323065
SumClampVectorTraits	29.838	8785.652	44.089075
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Base	3731.589	70.250	0.352536
SumClampVector128Traits	59.367	4415.646	22.159057
SumClampVector256Traits	30.231	8671.404	43.515745

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.20
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.20\
RuntimeInformation.FrameworkDescription:	.NET 7.0.20
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.20/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. ��!=130882.25684481156
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1272.445	206.016
SumClamp_MinMax	231.110	1134.282	5.505794
SumClamp_Math	1285.277	203.959	0.990016
SumClamp_BitMath	865.239	302.973	1.470627
SumClampVectorScalar	232.161	1129.145	5.480861
SumClampVectorBase	58.200	4504.164	21.863174
SumClampVectorTraits	115.891	2261.978	10.979622
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	115.531	2269.028	11.013842
SumClampVector128Base	115.634	2267.013	11.004062
SumClampVector128Traits	115.904	2261.736	10.978448
SumClampVector256Traits	58.478	4482.762	21.759289

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1262.940	207.566
SumClamp_MinMax	1216.198	215.544	1.038433
SumClamp_Math	1246.083	210.374	1.013528
SumClamp_BitMath	905.356	289.548	1.394966
SumClampVectorScalar	340.233	770.484	3.711988
SumClampVectorBase	7.155	36636.559	176.505183
SumClampVectorTraits	8.252	31765.814	153.039232
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	19.033	13773.367	66.356412
SumClampVector128Base	18.876	13887.490	66.906227
SumClampVector128Traits	18.354	14282.583	68.809679
SumClampVector256Traits	11.108	23600.182	113.699393

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1289.249	203.331
SumClamp_MinMax	1275.922	205.455	1.010445
SumClamp_Math	1171.586	223.751	1.100431
SumClamp_BitMath	680.860	385.019	1.893560
SumClampVectorScalar	190.492	1376.144	6.768009
SumClampVectorBase	15.266	17171.860	84.452857
SumClampVectorTraits	17.379	15083.751	74.183334
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	62.100	4221.327	20.760889
SumClampVector128Base	61.944	4231.925	20.813015
SumClampVector128Traits	35.800	7322.451	36.012515
SumClampVector256Traits	19.940	13146.386	64.655189

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 7714737504780401444!=-141951893350734
SumClamp_If	1229.923	213.139
SumClamp_MinMax	1241.060	211.226	0.991026
SumClamp_Math	1226.840	213.674	1.002513
SumClamp_BitMath	772.251	339.454	1.592646
SumClampVectorScalar	206.530	1269.281	5.955191
SumClampVectorBase	42.137	6221.302	29.189007
SumClampVectorTraits	55.603	4714.530	22.119558
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	123.015	2130.986	9.998127
SumClampVector128Base	120.833	2169.477	10.178716
SumClampVector128Traits	119.319	2197.010	10.307896
SumClampVector256Traits	66.296	3954.167	18.552098

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1336.589	196.129
SumClamp_MinMax	1213.171	216.082	1.101732
SumClamp_Math	1234.456	212.356	1.082736
SumClamp_BitMath	874.994	299.595	1.527541
SumClampVectorScalar	326.919	801.863	4.088446
SumClampVectorBase	3.350	78262.320	399.034808
SumClampVectorTraits	3.922	66843.145	340.812050
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	25.291	10365.285	52.849307
SumClampVector128Base	26.089	10048.041	51.231780
SumClampVector128Traits	9.179	28559.388	145.615283
SumClampVector256Traits	4.767	54991.642	280.384985

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130881.91!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1267.730	206.782
SumClamp_MinMax	232.631	1126.868	5.449541
SumClamp_Math	1277.764	205.158	0.992147
SumClamp_BitMath	785.176	333.867	1.614581
SumClampVectorScalar	232.165	1129.127	5.460466
SumClampVectorBase	30.096	8710.176	42.122456
SumClampVectorTraits	30.301	8651.231	41.837398
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	59.797	4383.896	21.200543
SumClampVector128Base	59.500	4405.787	21.306408
SumClampVector128Traits	59.419	4411.788	21.335430
SumClampVector256Traits	30.381	8628.455	41.727254

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.8
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.8\
RuntimeInformation.FrameworkDescription:	.NET 8.0.8
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.8/System.Private.CoreLib.dll
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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. ��!=130882.25684481156
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector512Bcl	Check `SumClampVector512Bcl` mismatch. 130882.25684481146!=130882.25684481156
Check-SumClampVector512Traits	Check `SumClampVector512Traits` mismatch. 130882.25684481146!=130882.25684481156
SumClamp_If	1324.499	197.919
SumClamp_MinMax	231.457	1132.580	5.722431
SumClamp_Math	1296.240	202.234	1.021800
SumClamp_BitMath	506.339	517.724	2.615832
SumClampVectorScalar	232.569	1127.167	5.695082
SumClampVectorBase	59.044	4439.795	22.432337
SumClampVectorTraits	115.680	2266.109	11.449656
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	116.309	2253.852	11.387726
SumClampVector128Base	116.192	2256.121	11.399191
SumClampVector128Traits	115.912	2261.582	11.426784
SumClampVector256Traits	58.730	4463.539	22.552305
SumClampVector512Bcl	31.598	8296.225	41.917188
SumClampVector512Traits	31.695	8270.874	41.789100

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1169.643	224.123
SumClamp_MinMax	1306.102	200.707	0.895522
SumClamp_Math	1108.851	236.411	1.054825
SumClamp_BitMath	613.911	427.007	1.905233
SumClampVectorScalar	213.730	1226.517	5.472515
SumClampVectorBase	7.049	37189.723	165.934344
SumClampVectorTraits	8.262	31727.791	141.564116
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	13.151	19933.459	88.939770
SumClampVector128Base	15.676	16723.158	74.615942
SumClampVector128Traits	13.037	20107.497	89.716298
SumClampVector256Traits	6.901	37987.496	169.493877
SumClampVector512Bcl	6.477	40475.392	180.594453
SumClampVector512Traits	6.408	40905.765	182.514707

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1129.971	231.992
SumClamp_MinMax	1212.122	216.269	0.932225
SumClamp_Math	1059.374	247.452	1.066640
SumClamp_BitMath	499.193	525.135	2.263593
SumClampVectorScalar	172.423	1520.352	6.553471
SumClampVectorBase	18.542	14138.012	60.941839
SumClampVectorTraits	19.537	13418.049	57.838443
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	28.941	9057.856	39.043850
SumClampVector128Base	30.348	8638.000	37.234061
SumClampVector128Traits	26.754	9798.382	42.235884
SumClampVector256Traits	16.734	15664.950	67.523697
SumClampVector512Bcl	15.033	17437.689	75.165082
SumClampVector512Traits	13.914	18840.593	81.212296

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 7714737504780401444!=-141951893350734
SumClamp_If	1165.014	225.014
SumClamp_MinMax	1246.023	210.385	0.934986
SumClamp_Math	1253.710	209.095	0.929253
SumClamp_BitMath	523.666	500.594	2.224727
SumClampVectorScalar	171.034	1532.698	6.811577
SumClampVectorBase	32.857	7978.284	35.456891
SumClampVectorTraits	49.839	5259.836	23.375632
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	62.612	4186.822	18.606971
SumClampVector128Base	62.311	4207.011	18.696693
SumClampVector128Traits	61.256	4279.492	19.018813
SumClampVector256Traits	32.577	8047.015	35.762344
SumClampVector512Bcl	26.777	9789.734	43.507293
SumClampVector512Traits	27.062	9686.884	43.050206

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1267.911	206.753
SumClamp_MinMax	1222.450	214.441	1.037188
SumClamp_Math	1222.686	214.400	1.036989
SumClamp_BitMath	614.570	426.549	2.063087
SumClampVectorScalar	220.001	1191.558	5.763208
SumClampVectorBase	3.992	65671.095	317.631244
SumClampVectorTraits	3.650	71816.071	347.352637
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	6.816	38460.261	186.020663
SumClampVector128Base	7.139	36721.546	177.611023
SumClampVector128Traits	6.595	39746.202	192.240371
SumClampVector256Traits	3.481	75306.149	364.233092
SumClampVector512Bcl	2.977	88069.503	425.965579
SumClampVector512Traits	2.957	88637.514	428.712875

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130881.91!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
Check-SumClampVector512Bcl	Check `SumClampVector512Bcl` mismatch. 130882.27!=130883.55
Check-SumClampVector512Traits	Check `SumClampVector512Traits` mismatch. 130882.27!=130883.55
SumClamp_If	1319.025	198.741
SumClamp_MinMax	230.764	1135.984	5.715911
SumClamp_Math	1303.184	201.157	1.012156
SumClamp_BitMath	529.166	495.391	2.492648
SumClampVectorScalar	231.781	1130.998	5.690822
SumClampVectorBase	30.026	8730.698	43.930090
SumClampVectorTraits	30.002	8737.662	43.965127
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Wasm_NoPseudo	Run fail! Requires hardware support PackedSimd!
SumClampVector128_Wasm_Pseudo	Run fail! Requires hardware support PackedSimd!
SumClampVector128Bcl	59.016	4441.950	22.350477
SumClampVector128Base	58.924	4448.867	22.385280
SumClampVector128Traits	59.474	4407.714	22.178212
SumClampVector256Traits	30.098	8709.607	43.823964
SumClampVector512Bcl	16.457	15929.418	80.151753
SumClampVector512Traits	17.631	14868.400	74.813047

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.256844812
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.256844812!=130882.256844812
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.256844812!=130882.256844812
SumClamp_If	1273.623	205.825
SumClamp_MinMax	1354.750	193.500	0.940116
SumClamp_BitMath	885.624	295.999	1.438107
SumClampVectorScalar	310.125	845.285	4.106802
SumClampVectorBase	77.690	3374.246	16.393722
SumClampVectorTraits	77.679	3374.714	16.395996

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1216.419	215.505
SumClamp_MinMax	1239.564	211.481	0.981328
SumClamp_BitMath	1159.982	225.990	1.048654
SumClampVectorScalar	399.264	656.569	3.046657
SumClampVectorBase	12.127	21616.386	100.305895
SumClampVectorTraits	12.588	20824.271	96.630265

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1192.405	219.845
SumClamp_MinMax	1172.823	223.515	1.016697
SumClamp_BitMath	536.257	488.841	2.223572
SumClampVectorScalar	233.959	1120.472	5.096650
SumClampVectorBase	25.876	10130.762	46.081442
SumClampVectorTraits	25.986	10088.042	45.887121

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1330.045	197.094
SumClamp_MinMax	1354.432	193.545	0.981995
SumClamp_BitMath	590.035	444.285	2.254178
SumClampVectorScalar	424.015	618.242	3.136786
SumClampVectorBase	90.250	2904.650	14.737377
SumClampVectorTraits	92.480	2834.597	14.381945

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1352.351	193.843
SumClamp_MinMax	1458.815	179.697	0.927020
SumClamp_BitMath	823.490	318.333	1.642218
SumClampVectorScalar	410.363	638.811	3.295501
SumClampVectorBase	6.598	39729.614	204.957465
SumClampVectorTraits	5.800	45198.930	233.172616

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.5
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.3!=130883.5
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.3!=130883.5
SumClamp_If	1331.372	196.898
SumClamp_MinMax	1396.906	187.660	0.953087
SumClamp_BitMath	907.346	288.913	1.467326
SumClampVectorScalar	313.500	836.185	4.246801
SumClampVectorBase	40.682	6443.775	32.726530
SumClampVectorTraits	42.686	6141.176	31.189695

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.256844812
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.256844812!=130882.256844812
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.256844812!=130882.256844812
SumClamp_If	1255.388	208.815
SumClamp_MinMax	1314.247	199.463	0.955215
SumClamp_Math	1230.247	213.082	1.020436
SumClamp_BitMath	1285.210	203.970	0.976796
SumClampVectorScalar	310.140	845.245	4.047814
SumClampVectorBase	77.910	3364.716	16.113372
SumClampVectorTraits	77.914	3364.539	16.112524

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1213.946	215.944
SumClamp_MinMax	1187.633	220.728	1.022156
SumClamp_Math	1186.698	220.902	1.022962
SumClamp_BitMath	1158.006	226.375	1.048307
SumClampVectorScalar	398.470	657.876	3.046516
SumClampVectorBase	12.902	20317.518	94.087133
SumClampVectorTraits	13.244	19793.967	91.662653

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1193.316	219.677
SumClamp_MinMax	1175.861	222.938	1.014844
SumClamp_Math	1172.618	223.554	1.017651
SumClamp_BitMath	536.654	488.479	2.223623
SumClampVectorScalar	233.809	1121.187	5.103797
SumClampVectorBase	26.244	9988.734	45.470102
SumClampVectorTraits	25.981	10089.874	45.930506

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1332.121	196.787
SumClamp_MinMax	1353.836	193.631	0.983960
SumClamp_Math	1328.618	197.306	1.002636
SumClamp_BitMath	578.101	453.457	2.304304
SumClampVectorScalar	419.741	624.538	3.173674
SumClampVectorBase	101.162	2591.328	13.168187
SumClampVectorTraits	104.300	2513.360	12.771983

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1523.565	172.060
SumClamp_MinMax	1373.699	190.831	1.109097
SumClamp_Math	1346.513	194.684	1.131490
SumClamp_BitMath	824.423	317.973	1.848038
SumClampVectorScalar	412.093	636.129	3.697142
SumClampVectorBase	5.777	45375.640	263.720480
SumClampVectorTraits	5.849	44821.813	260.501671

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.5
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.3!=130883.5
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.3!=130883.5
SumClamp_If	1275.263	205.561
SumClamp_MinMax	1306.073	200.712	0.976410
SumClamp_Math	1305.371	200.820	0.976935
SumClamp_BitMath	853.621	307.096	1.493945
SumClampVectorScalar	309.882	845.947	4.115316
SumClampVectorBase	38.874	6743.423	32.805018
SumClampVectorTraits	38.930	6733.703	32.757731

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1261.233	207.847
SumClamp_MinMax	1888.625	138.801	0.667805
SumClamp_Math	1291.846	202.922	0.976303
SumClamp_BitMath	883.028	296.870	1.428305
SumClampVectorScalar	310.477	844.327	4.062247
SumClampVectorBase	77.877	3366.126	16.195184
SumClampVectorTraits	77.933	3363.727	16.183639
SumClampVector128Traits	155.211	1688.951	8.125921
SumClampVector256Traits	77.737	3372.207	16.224437

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1226.222	213.782
SumClamp_MinMax	1202.664	217.970	1.019588
SumClamp_Math	1200.790	218.310	1.021179
SumClamp_BitMath	756.006	346.748	1.621973
SumClampVectorScalar	392.934	667.144	3.120678
SumClampVectorBase	12.869	20370.312	95.285492
SumClampVectorTraits	12.909	20306.705	94.987958
SumClampVector128Traits	22.914	11440.144	53.513160
SumClampVector256Traits	12.953	20237.825	94.665759

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1195.211	219.329
SumClamp_MinMax	1218.019	215.222	0.981274
SumClamp_Math	1190.024	220.285	1.004359
SumClamp_BitMath	540.600	484.913	2.210898
SumClampVectorScalar	232.495	1127.523	5.140795
SumClampVectorBase	25.800	10160.643	46.326123
SumClampVectorTraits	25.829	10149.406	46.274889
SumClampVector128Traits	53.084	4938.305	22.515557
SumClampVector256Traits	25.898	10122.132	46.150538

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1354.340	193.559
SumClamp_MinMax	1326.509	197.620	1.020981
SumClamp_Math	1325.075	197.833	1.022085
SumClamp_BitMath	579.448	452.403	2.337293
SumClampVectorScalar	425.974	615.399	3.179397
SumClampVectorBase	101.337	2586.842	13.364652
SumClampVectorTraits	84.996	3084.178	15.934084
SumClampVector128Traits	194.862	1345.280	6.950250
SumClampVector256Traits	84.846	3089.639	15.962298

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1400.323	187.203
SumClamp_MinMax	1338.498	195.849	1.046190
SumClamp_Math	1364.883	192.063	1.025965
SumClamp_BitMath	770.838	340.077	1.816624
SumClampVectorScalar	415.713	630.588	3.368481
SumClampVectorBase	5.762	45497.961	243.041348
SumClampVectorTraits	5.748	45606.563	243.621481
SumClampVector128Traits	14.089	18606.347	99.391525
SumClampVector256Traits	5.741	45664.168	243.929195

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1257.644	208.440
SumClamp_MinMax	1829.761	143.267	0.687327
SumClamp_Math	1206.654	217.249	1.042258
SumClamp_BitMath	854.694	306.711	1.471456
SumClampVectorScalar	310.268	844.895	4.053411
SumClampVectorBase	38.818	6753.187	32.398634
SumClampVectorTraits	38.889	6740.842	32.339408
SumClampVector128Traits	77.610	3377.724	16.204737
SumClampVector256Traits	38.919	6735.586	32.314192

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1350.939	194.046
SumClamp_MinMax	1756.451	149.246	0.769130
SumClamp_Math	1223.303	214.292	1.104337
SumClamp_BitMath	1157.229	226.527	1.167391
SumClampVectorScalar	310.345	844.684	4.353016
SumClampVectorBase	77.813	3368.893	17.361328
SumClampVectorTraits	77.815	3368.829	17.361000
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	155.328	1687.685	8.697353
SumClampVector256Traits	77.721	3372.865	17.381796

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1179.760	222.201
SumClamp_MinMax	1220.647	214.758	0.966504
SumClamp_Math	1190.726	220.155	0.990790
SumClamp_BitMath	1131.454	231.688	1.042693
SumClampVectorScalar	390.395	671.484	3.021963
SumClampVectorBase	12.926	20279.612	91.266880
SumClampVectorTraits	13.030	20117.733	90.538355
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	22.986	11404.378	51.324550
SumClampVector256Traits	12.906	20312.038	91.412812

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1230.782	212.990
SumClamp_MinMax	1179.702	222.212	1.043299
SumClamp_Math	1170.981	223.867	1.051069
SumClamp_BitMath	856.667	306.004	1.436709
SumClampVectorScalar	232.467	1127.664	5.294447
SumClampVectorBase	25.785	10166.501	47.732328
SumClampVectorTraits	25.921	10112.996	47.481118
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	45.782	5725.903	26.883454
SumClampVector256Traits	25.834	10147.300	47.642173

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1337.208	196.038
SumClamp_MinMax	1350.804	194.065	0.989935
SumClamp_Math	1358.484	192.968	0.984338
SumClamp_BitMath	951.071	275.630	1.406001
SumClampVectorScalar	422.414	620.586	3.165635
SumClampVectorBase	100.454	2609.587	13.311615
SumClampVectorTraits	84.968	3085.217	15.737823
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	135.313	1937.321	9.882360
SumClampVector256Traits	84.913	3087.198	15.747929

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1408.479	186.118
SumClamp_MinMax	1444.920	181.425	0.974780
SumClamp_Math	1417.033	184.995	0.993964
SumClamp_BitMath	1129.841	232.019	1.246617
SumClampVectorScalar	413.706	633.648	3.404540
SumClampVectorBase	5.759	45519.977	244.575271
SumClampVectorTraits	5.753	45565.155	244.818005
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	11.203	23398.557	125.718611
SumClampVector256Traits	5.789	45286.542	243.321038

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1324.440	197.928
SumClamp_MinMax	1685.422	155.536	0.785821
SumClamp_Math	1213.496	216.024	1.091425
SumClamp_BitMath	1071.303	244.696	1.236288
SumClampVectorScalar	310.380	844.592	4.267161
SumClampVectorBase	38.971	6726.650	33.985306
SumClampVectorTraits	39.621	6616.221	33.427384
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	86.452	3032.265	15.320026
SumClampVector256Traits	38.926	6734.416	34.024544

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1220.232	214.831
SumClamp_MinMax	1659.382	157.977	0.735353
SumClamp_Math	1276.637	205.340	0.955818
SumClamp_BitMath	1038.580	252.406	1.174904
SumClampVectorScalar	310.795	843.462	3.926161
SumClampVectorBase	77.788	3369.998	15.686720
SumClampVectorTraits	77.779	3370.384	15.688519
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	155.336	1687.598	7.855459
SumClampVector256Traits	77.759	3371.251	15.692555

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1202.626	217.976
SumClamp_MinMax	1294.145	202.562	0.929283
SumClamp_Math	1200.937	218.283	1.001406
SumClamp_BitMath	910.093	288.041	1.321432
SumClampVectorScalar	398.966	657.058	3.014355
SumClampVectorBase	12.949	20244.028	92.872623
SumClampVectorTraits	13.365	19613.893	89.981780
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	23.001	11397.032	52.285653
SumClampVector256Traits	12.895	20329.650	93.265427

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1249.157	209.857
SumClamp_MinMax	1294.049	202.577	0.965309
SumClamp_Math	1167.347	224.564	1.070083
SumClamp_BitMath	854.804	306.671	1.461337
SumClampVectorScalar	233.940	1120.558	5.339637
SumClampVectorBase	26.036	10068.411	47.977563
SumClampVectorTraits	25.880	10129.216	48.267310
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	45.837	5718.994	27.251907
SumClampVector256Traits	25.892	10124.446	48.244580

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1288.436	203.459
SumClamp_MinMax	1317.907	198.909	0.977638
SumClamp_Math	1328.856	197.270	0.969583
SumClamp_BitMath	951.415	275.531	1.354232
SumClampVectorScalar	424.334	617.778	3.036376
SumClampVectorBase	100.017	2620.991	12.882159
SumClampVectorTraits	84.760	3092.766	15.200928
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	133.596	1962.211	9.644257
SumClampVector256Traits	84.703	3094.869	15.211268

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1374.210	190.760
SumClamp_MinMax	1382.457	189.622	0.994035
SumClamp_Math	1309.745	200.149	1.049219
SumClamp_BitMath	906.781	289.093	1.515482
SumClampVectorScalar	398.529	657.779	3.448205
SumClampVectorBase	5.766	45463.157	238.326765
SumClampVectorTraits	5.751	45581.443	238.946845
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	11.176	23455.320	122.957376
SumClampVector256Traits	5.755	45554.075	238.803379

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1216.318	215.523
SumClamp_MinMax	1795.399	146.009	0.677464
SumClamp_Math	1273.305	205.877	0.955245
SumClamp_BitMath	983.079	266.656	1.237253
SumClampVectorScalar	309.842	846.056	3.925604
SumClampVectorBase	38.988	6723.729	31.197324
SumClampVectorTraits	38.878	6742.713	31.285407
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	77.590	3378.593	15.676282
SumClampVector256Traits	38.878	6742.660	31.285161

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1163.261	225.353
SumClamp_MinMax	310.020	845.571	3.752211
SumClamp_Math	1171.738	223.722	0.992765
SumClamp_BitMath	828.381	316.453	1.404259
SumClampVectorScalar	310.011	845.594	3.752317
SumClampVectorBase	77.791	3369.851	14.953678
SumClampVectorTraits	77.701	3373.745	14.970958
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	155.547	1685.305	7.478524
SumClampVector256Traits	77.745	3371.862	14.962605

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1165.370	224.945
SumClamp_MinMax	1178.557	222.428	0.988811
SumClamp_Math	1158.901	226.201	1.005582
SumClamp_BitMath	694.958	377.209	1.676893
SumClampVectorScalar	371.178	706.250	3.139656
SumClampVectorBase	13.129	19966.751	88.762870
SumClampVectorTraits	12.914	20299.686	90.242943
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	22.015	11907.665	52.935928
SumClampVector256Traits	12.938	20261.190	90.071806

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1180.724	222.020
SumClamp_MinMax	1290.305	203.164	0.915074
SumClamp_Math	1153.405	227.278	1.023686
SumClamp_BitMath	537.052	488.117	2.198529
SumClampVectorScalar	194.449	1348.137	6.072151
SumClampVectorBase	24.458	10717.997	48.274995
SumClampVectorTraits	24.376	10754.191	48.438016
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	44.248	5924.448	26.684342
SumClampVector256Traits	24.496	10701.682	48.201508

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1289.969	203.217
SumClamp_MinMax	1295.025	202.424	0.996095
SumClamp_Math	1271.518	206.166	1.014511
SumClamp_BitMath	603.108	434.655	2.138867
SumClampVectorScalar	329.245	796.198	3.917964
SumClampVectorBase	85.583	3063.056	15.072806
SumClampVectorTraits	85.596	3062.579	15.070460
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	194.276	1349.337	6.639869
SumClampVector256Traits	99.741	2628.240	12.933146

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1316.886	199.064
SumClamp_MinMax	1316.621	199.104	1.000201
SumClamp_Math	1306.988	200.571	1.007573
SumClamp_BitMath	689.186	380.367	1.910783
SumClampVectorScalar	369.284	709.871	3.566052
SumClampVectorBase	5.282	49631.375	249.324241
SumClampVectorTraits	5.528	47417.469	238.202639
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	10.754	24376.665	122.456682
SumClampVector256Traits	5.581	46972.153	235.965582

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1251.474	209.468
SumClamp_MinMax	310.214	845.042	4.034226
SumClamp_Math	1142.759	229.396	1.095134
SumClamp_BitMath	758.950	345.403	1.648954
SumClampVectorScalar	309.844	846.052	4.039048
SumClampVectorBase	38.804	6755.599	32.251193
SumClampVectorTraits	38.806	6755.329	32.249907
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	77.894	3365.415	16.066472
SumClampVector256Traits	38.831	6750.943	32.228969

```

## Arm

### Apple M2
`Apple M2`

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	6.0.33
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.33/
RuntimeInformation.FrameworkDescription:	.NET 6.0.33
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.15-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.33/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, ArmBase, Crc32
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. ∞!=130882.25684481156
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1078.728	243.012
SumClamp_MinMax	1289.856	203.235	0.836317
SumClamp_Math	1051.775	249.240	1.025626
SumClamp_BitMath	525.271	499.064	2.053660
SumClampVectorScalar	231.200	1133.840	4.665776
SumClampVectorBase	115.578	2268.115	9.333342
SumClampVectorTraits	231.171	1133.982	4.666358
SumClampVector128_AdvSimd	1301.861	201.361	0.828604
SumClampVector128Base	1833.767	142.954	0.588258
SumClampVector128Traits	115.576	2268.162	9.333533
SumClampVector256Traits	2168.498	120.887	0.497454

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1001.063	261.866
SumClamp_MinMax	1075.031	243.848	0.931194
SumClamp_Math	1027.901	255.028	0.973890
SumClamp_BitMath	466.397	562.062	2.146374
SumClampVectorScalar	192.703	1360.349	5.194836
SumClampVectorBase	19.264	13608.109	51.965987
SumClampVectorTraits	19.262	13609.046	51.969564
SumClampVector128_AdvSimd	19.264	13607.945	51.965358
SumClampVector128Base	751.867	348.657	1.331436
SumClampVector128Traits	19.265	13607.567	51.963918
SumClampVector256Traits	1171.854	223.700	0.854256

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	998.710	262.483
SumClamp_MinMax	1047.097	250.353	0.953789
SumClamp_Math	998.907	262.431	0.999803
SumClamp_BitMath	310.326	844.737	3.218260
SumClampVectorScalar	154.163	1700.439	6.478292
SumClampVectorBase	38.534	6802.976	25.917806
SumClampVectorTraits	38.531	6803.371	25.919313
SumClampVector128_AdvSimd	38.542	6801.594	25.912544
SumClampVector128Base	1034.036	253.515	0.965836
SumClampVector128Traits	38.530	6803.692	25.920534
SumClampVector256Traits	1432.970	182.938	0.696951

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 8566072936161031304!=-141951893350734
SumClamp_If	1014.899	258.296
SumClamp_MinMax	1016.590	257.866	0.998337
SumClamp_Math	1013.953	258.537	1.000933
SumClamp_BitMath	349.735	749.550	2.901909
SumClampVectorScalar	173.416	1511.648	5.852394
SumClampVectorBase	77.067	3401.518	13.169090
SumClampVectorTraits	154.109	1701.025	6.585575
SumClampVector128_AdvSimd	1281.716	204.526	0.791828
SumClampVector128_Arm64	77.074	3401.207	13.167887
SumClampVector128Base	1630.470	160.778	0.622458
SumClampVector128Traits	77.091	3400.458	13.164984
SumClampVector256Traits	1979.142	132.453	0.512798

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	989.970	264.800
SumClamp_MinMax	1026.995	255.253	0.963948
SumClamp_Math	971.867	269.732	1.018627
SumClamp_BitMath	445.320	588.665	2.223055
SumClampVectorScalar	183.072	1431.918	5.407543
SumClampVectorBase	9.660	27136.283	102.478387
SumClampVectorTraits	9.646	27175.139	102.625124
SumClampVector128_AdvSimd	9.649	27167.352	102.595718
SumClampVector128Base	584.687	448.350	1.693163
SumClampVector128Traits	9.649	27168.146	102.598715
SumClampVector256Traits	586.821	446.719	1.687005

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1052.859	248.983
SumClamp_MinMax	1361.683	192.515	0.773204
SumClamp_Math	1051.944	249.200	1.000870
SumClamp_BitMath	497.362	527.069	2.116888
SumClampVectorScalar	231.213	1133.778	4.553637
SumClampVectorBase	57.788	4536.291	18.219284
SumClampVectorTraits	57.774	4537.388	18.223690
SumClampVector128_AdvSimd	57.785	4536.514	18.220179
SumClampVector128Base	1175.129	223.077	0.895952
SumClampVector128Traits	57.785	4536.572	18.220413
SumClampVector256Traits	1511.810	173.397	0.696423

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	7.0.20
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.20/
RuntimeInformation.FrameworkDescription:	.NET 7.0.20
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.15-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.20/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. ∞!=130882.25684481156
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	919.153	285.202
SumClamp_MinMax	224.839	1165.919	4.088051
SumClamp_Math	929.826	281.928	0.988521
SumClamp_BitMath	263.344	995.442	3.490310
SumClampVectorScalar	231.156	1134.055	3.976326
SumClampVectorBase	115.589	2267.900	7.951917
SumClampVectorTraits	224.803	1166.103	4.088697
SumClampVector128_AdvSimd	265.566	987.115	3.461113
SumClampVector128Bcl	115.613	2267.429	7.950263
SumClampVector128Base	115.602	2267.642	7.951010
SumClampVector128Traits	115.604	2267.611	7.950902
SumClampVector256Traits	1765.179	148.508	0.520714

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	832.426	314.916
SumClamp_MinMax	833.326	314.576	0.998919
SumClamp_Math	861.405	304.322	0.966358
SumClamp_BitMath	358.753	730.709	2.320332
SumClampVectorScalar	172.294	1521.490	4.831419
SumClampVectorBase	19.256	13613.490	43.228977
SumClampVectorTraits	19.255	13614.464	43.232070
SumClampVector128_AdvSimd	19.269	13604.368	43.200009
SumClampVector128Bcl	19.272	13602.069	43.192708
SumClampVector128Base	19.276	13599.684	43.185135
SumClampVector128Traits	19.267	13605.515	43.203652
SumClampVector256Traits	2551.361	102.747	0.326267

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	829.958	315.852
SumClamp_MinMax	865.637	302.834	0.958782
SumClamp_Math	826.331	317.238	1.004389
SumClamp_BitMath	238.592	1098.712	3.478565
SumClampVectorScalar	105.985	2473.395	7.830863
SumClampVectorBase	38.523	6804.790	21.544224
SumClampVectorTraits	38.525	6804.519	21.543363
SumClampVector128_AdvSimd	38.541	6801.772	21.534666
SumClampVector128Bcl	38.543	6801.281	21.533113
SumClampVector128Base	38.551	6799.886	21.528696
SumClampVector128Traits	38.539	6801.987	21.535348
SumClampVector256Traits	1526.430	171.737	0.543725

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 8566072936161031304!=-141951893350734
SumClamp_If	833.125	314.651
SumClamp_MinMax	843.672	310.718	0.987499
SumClamp_Math	836.804	313.268	0.995604
SumClamp_BitMath	278.164	942.408	2.995085
SumClampVectorScalar	144.544	1813.596	5.763825
SumClampVectorBase	77.092	3400.420	10.806943
SumClampVectorTraits	154.134	1700.750	5.405187
SumClampVector128_AdvSimd	1280.682	204.691	0.650532
SumClampVector128_Arm64	77.884	3365.816	10.696966
SumClampVector128Bcl	77.899	3365.182	10.694952
SumClampVector128Base	78.024	3359.794	10.677827
SumClampVector128Traits	77.885	3365.796	10.696904
SumClampVector256Traits	1723.995	152.056	0.483252

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	870.243	301.231
SumClamp_MinMax	892.853	293.603	0.974676
SumClamp_Math	884.113	296.505	0.984311
SumClamp_BitMath	364.341	719.502	2.388540
SumClampVectorScalar	171.975	1524.314	5.060283
SumClampVectorBase	9.642	27187.582	90.254940
SumClampVectorTraits	9.643	27186.221	90.250421
SumClampVector128_AdvSimd	9.658	27142.180	90.104220
SumClampVector128Bcl	9.661	27134.579	90.078987
SumClampVector128Base	9.663	27129.805	90.063138
SumClampVector128Traits	9.658	27142.497	90.105272
SumClampVector256Traits	1577.896	166.135	0.551521

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130881.91!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	894.007	293.224
SumClamp_MinMax	224.896	1165.622	3.975196
SumClamp_Math	928.335	282.381	0.963022
SumClamp_BitMath	257.156	1019.395	3.476510
SumClampVectorScalar	226.870	1155.479	3.940605
SumClampVectorBase	56.191	4665.190	15.910004
SumClampVectorTraits	56.191	4665.217	15.910096
SumClampVector128_AdvSimd	57.798	4535.554	15.467897
SumClampVector128Bcl	57.803	4535.116	15.466405
SumClampVector128Base	57.805	4534.952	15.465844
SumClampVector128Traits	57.793	4535.952	15.469253
SumClampVector256Traits	1507.041	173.946	0.593220

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	8.0.4
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.4/
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.4/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844159	# 0x8177F801
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. ∞!=130882.25684481156
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector512Bcl	Check `SumClampVector512Bcl` mismatch. 130882.25684481146!=130882.25684481156
Check-SumClampVector512Traits	Check `SumClampVector512Traits` mismatch. 130882.25684481146!=130882.25684481156
SumClamp_If	898.601	291.725
SumClamp_MinMax	1150.432	227.866	0.781098
SumClamp_Math	887.247	295.458	1.012797
SumClamp_BitMath	231.327	1133.217	3.884543
SumClampVectorScalar	224.842	1165.902	3.996584
SumClampVectorBase	112.411	2332.009	7.993869
SumClampVectorTraits	224.799	1166.128	3.997358
SumClampVector128_AdvSimd	1187.574	220.739	0.756669
SumClampVector128Bcl	112.403	2332.187	7.994480
SumClampVector128Base	112.407	2332.102	7.994187
SumClampVector128Traits	112.415	2331.928	7.993590
SumClampVector256Traits	57.795	4535.718	15.547938
SumClampVector512Bcl	28.971	9048.528	31.017350
SumClampVector512Traits	28.975	9047.123	31.012536

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	795.288	329.622
SumClamp_MinMax	834.547	314.115	0.952957
SumClamp_Math	824.069	318.109	0.965074
SumClamp_BitMath	307.248	853.201	2.588425
SumClampVectorScalar	167.398	1565.991	4.750874
SumClampVectorBase	19.252	13616.759	41.310275
SumClampVectorTraits	19.250	13617.738	41.313245
SumClampVector128_AdvSimd	19.259	13611.721	41.294991
SumClampVector128Bcl	19.255	13614.565	41.303620
SumClampVector128Base	19.255	13613.980	41.301845
SumClampVector128Traits	19.256	13613.917	41.301652
SumClampVector256Traits	9.654	27155.178	82.382884
SumClampVector512Bcl	7.324	35790.261	108.579841
SumClampVector512Traits	7.324	35792.447	108.586473

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	822.937	318.547
SumClamp_MinMax	827.207	316.902	0.994837
SumClamp_Math	812.779	322.528	1.012497
SumClamp_BitMath	225.355	1163.249	3.651736
SumClampVectorScalar	96.344	2720.929	8.541691
SumClampVectorBase	38.515	6806.300	21.366713
SumClampVectorTraits	38.520	6805.358	21.363755
SumClampVector128_AdvSimd	38.533	6803.127	21.356753
SumClampVector128Bcl	38.527	6804.217	21.360174
SumClampVector128Base	38.534	6803.015	21.356400
SumClampVector128Traits	38.525	6804.536	21.361175
SumClampVector256Traits	19.324	13565.560	42.585756
SumClampVector512Bcl	14.676	17861.886	56.073020
SumClampVector512Traits	14.677	17860.722	56.069365

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 8566072936161031304!=-141951893350734
SumClamp_If	840.632	311.841
SumClamp_MinMax	840.275	311.974	1.000425
SumClamp_Math	820.196	319.611	1.024916
SumClamp_BitMath	264.122	992.510	3.182739
SumClampVectorScalar	118.274	2216.410	7.107490
SumClampVectorBase	77.077	3401.046	10.906328
SumClampVectorTraits	154.156	1700.515	5.453139
SumClampVector128_AdvSimd	1240.112	211.387	0.677868
SumClampVector128_Arm64	77.069	3401.404	10.907477
SumClampVector128Bcl	77.080	3400.938	10.905983
SumClampVector128Base	77.071	3401.326	10.907229
SumClampVector128Traits	77.087	3400.628	10.904988
SumClampVector256Traits	50.012	5241.594	16.808520
SumClampVector512Bcl	50.901	5150.042	16.514936
SumClampVector512Traits	50.938	5146.372	16.503167

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	849.453	308.603
SumClamp_MinMax	851.547	307.844	0.997541
SumClamp_Math	851.964	307.694	0.997052
SumClamp_BitMath	309.777	846.236	2.742147
SumClampVectorScalar	167.526	1564.793	5.070566
SumClampVectorBase	9.632	27216.839	88.193620
SumClampVectorTraits	9.628	27228.030	88.229885
SumClampVector128_AdvSimd	9.637	27201.924	88.145288
SumClampVector128Bcl	9.636	27204.948	88.155086
SumClampVector128Base	9.636	27205.170	88.155808
SumClampVector128Traits	9.641	27191.636	88.111953
SumClampVector256Traits	4.851	54036.025	175.098681
SumClampVector512Bcl	3.657	71676.384	232.260615
SumClampVector512Traits	3.658	71671.860	232.245953

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130881.91!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
Check-SumClampVector512Bcl	Check `SumClampVector512Bcl` mismatch. 130882.27!=130883.55
Check-SumClampVector512Traits	Check `SumClampVector512Traits` mismatch. 130882.27!=130883.55
SumClamp_If	892.209	293.815
SumClamp_MinMax	1146.759	228.596	0.778027
SumClamp_Math	892.750	293.637	0.999395
SumClamp_BitMath	231.245	1133.622	3.858289
SumClampVectorScalar	224.837	1165.928	3.968243
SumClampVectorBase	56.188	4665.489	15.879026
SumClampVectorTraits	56.185	4665.699	15.879740
SumClampVector128_AdvSimd	56.182	4665.971	15.880667
SumClampVector128_Wasm_NoPseudo	Run fail! Requires hardware support PackedSimd!
SumClampVector128_Wasm_Pseudo	Run fail! Requires hardware support PackedSimd!
SumClampVector128Bcl	57.767	4537.921	15.444847
SumClampVector128Base	56.185	4665.691	15.879714
SumClampVector128Traits	57.042	4595.601	15.641160
SumClampVector256Traits	28.900	9070.795	30.872516
SumClampVector512Bcl	14.566	17997.323	61.254017
SumClampVector512Traits	14.568	17994.827	61.245524

```

### AWS Arm t4g.small
`AWS Arm t4g.small`

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. Infinity!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1473.780	177.872
SumClamp_MinMax	2144.443	122.243	0.687256
SumClamp_Math	1513.026	173.258	0.974061
SumClamp_BitMath	1599.497	163.892	0.921403
SumClampVectorScalar	422.977	619.760	3.484305
SumClampVectorBase	159.465	1643.899	9.242043
SumClampVectorTraits	211.406	1240.001	6.971319
SumClampVector128Base	4094.095	64.030	0.359977
SumClampVector128Traits	4389.671	59.718	0.335738
SumClampVector256Traits	8343.735	31.418	0.176633

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1518.642	172.617
SumClamp_MinMax	1565.807	167.418	0.969878
SumClamp_Math	1559.617	168.082	0.973727
SumClamp_BitMath	1190.615	220.175	1.275510
SumClampVectorScalar	613.958	426.974	2.473525
SumClampVectorBase	39.506	6635.492	38.440456
SumClampVectorTraits	39.567	6625.248	38.381106
SumClampVector128Base	1754.976	149.372	0.865334
SumClampVector128Traits	1757.216	149.181	0.864232
SumClampVector256Traits	2595.724	100.991	0.585055

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1478.989	177.245
SumClamp_MinMax	1618.174	162.000	0.913986
SumClamp_Math	1539.830	170.242	0.960488
SumClamp_BitMath	949.254	276.158	1.558054
SumClampVectorScalar	397.356	659.722	3.722081
SumClampVectorBase	66.593	3936.514	22.209407
SumClampVectorTraits	66.592	3936.545	22.209580
SumClampVector128Base	3037.068	86.315	0.486979
SumClampVector128Traits	3021.067	86.772	0.489559
SumClampVector256Traits	4729.081	55.432	0.312744

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 8566072936161031304!=-141951893350734
SumClamp_If	1681.429	155.905
SumClamp_MinMax	1710.414	153.264	0.983054
SumClamp_Math	1594.311	164.425	1.054644
SumClamp_BitMath	1064.347	246.296	1.579776
SumClampVectorScalar	716.380	365.929	2.347121
SumClampVectorBase	284.250	922.230	5.915314
SumClampVectorTraits	326.700	802.399	5.146703
SumClampVector128Base	3995.100	65.616	0.420873
SumClampVector128Traits	3965.897	66.100	0.423972
SumClampVector256Traits	8292.160	31.613	0.202773

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1615.426	162.275
SumClamp_MinMax	1603.329	163.500	1.007545
SumClamp_Math	1608.881	162.936	1.004068
SumClamp_BitMath	1161.566	225.682	1.390731
SumClampVectorScalar	597.149	438.992	2.705231
SumClampVectorBase	16.582	15809.204	97.422045
SumClampVectorTraits	16.578	15812.858	97.444560
SumClampVector128Base	1147.401	228.468	1.407900
SumClampVector128Traits	1146.787	228.590	1.408654
SumClampVector256Traits	1358.497	192.966	1.189128

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1569.551	167.018
SumClamp_MinMax	2148.847	121.993	0.730415
SumClamp_Math	1508.852	173.737	1.040229
SumClamp_BitMath	1526.809	171.694	1.027995
SumClampVectorScalar	422.164	620.953	3.717873
SumClampVectorBase	66.430	3946.140	23.626974
SumClampVectorTraits	66.463	3944.212	23.615428
SumClampVector128Base	3077.190	85.189	0.510060
SumClampVector128Traits	3070.421	85.377	0.511184
SumClampVector256Traits	4618.551	56.759	0.339836

```

#### .NET 5.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. Infinity!=130882.25684481156
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1531.591	171.158
SumClamp_MinMax	1993.276	131.514	0.768379
SumClamp_Math	1528.344	171.522	1.002125
SumClamp_BitMath	2277.739	115.090	0.672418
SumClampVectorScalar	388.008	675.615	3.947321
SumClampVectorBase	133.037	1970.459	11.512517
SumClampVectorTraits	210.787	1243.642	7.266051
SumClampVector128_AdvSimd	1827.058	143.479	0.838283
SumClampVector128Base	5371.333	48.804	0.285142
SumClampVector128Traits	132.358	1980.561	11.571539
SumClampVector256Traits	4562.084	57.461	0.335722

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1565.681	167.431
SumClamp_MinMax	1575.706	166.366	0.993638
SumClamp_Math	1547.457	169.403	1.011777
SumClamp_BitMath	1545.277	169.642	1.013204
SumClampVectorScalar	608.375	430.892	2.573545
SumClampVectorBase	39.727	6598.702	39.411410
SumClampVectorTraits	33.641	7792.358	46.540639
SumClampVector128_AdvSimd	33.700	7778.730	46.459244
SumClampVector128Base	2406.822	108.917	0.650518
SumClampVector128Traits	33.664	7786.995	46.508605
SumClampVector256Traits	2655.888	98.703	0.589513

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1523.350	172.084
SumClamp_MinMax	1571.732	166.787	0.969217
SumClamp_Math	1608.315	162.993	0.947171
SumClamp_BitMath	1243.535	210.805	1.225015
SumClampVectorScalar	397.875	658.860	3.828715
SumClampVectorBase	79.889	3281.355	19.068337
SumClampVectorTraits	79.645	3291.395	19.126682
SumClampVector128_AdvSimd	67.713	3871.415	22.497246
SumClampVector128Base	3690.174	71.038	0.412812
SumClampVector128Traits	67.454	3886.249	22.583447
SumClampVector256Traits	3517.695	74.522	0.433053

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 8566072936161031304!=-141951893350734
SumClamp_If	1624.761	161.343
SumClamp_MinMax	1631.380	160.688	0.995942
SumClamp_Math	1562.866	167.733	1.039604
SumClamp_BitMath	1369.564	191.407	1.186334
SumClampVectorScalar	469.009	558.932	3.464242
SumClampVectorBase	185.261	1414.997	8.770113
SumClampVectorTraits	226.128	1159.274	7.185144
SumClampVector128_AdvSimd	1777.831	147.452	0.913901
SumClampVector128_Arm64	183.359	1429.676	8.861093
SumClampVector128Base	5381.415	48.713	0.301921
SumClampVector128Traits	183.733	1426.764	8.843039
SumClampVector256Traits	4572.373	57.332	0.355343

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1609.415	162.882
SumClamp_MinMax	1640.285	159.816	0.981180
SumClamp_Math	1589.859	164.885	1.012300
SumClamp_BitMath	1501.918	174.540	1.071573
SumClampVectorScalar	595.706	440.056	2.701691
SumClampVectorBase	19.918	13161.023	80.801177
SumClampVectorTraits	20.002	13105.808	80.462187
SumClampVector128_AdvSimd	16.949	15467.001	94.958563
SumClampVector128Base	1584.930	165.398	1.015448
SumClampVector128Traits	16.853	15554.875	95.498060
SumClampVector256Traits	1496.287	175.196	1.075605

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1458.311	179.759
SumClamp_MinMax	1970.632	133.025	0.740022
SumClamp_Math	1530.973	171.227	0.952538
SumClamp_BitMath	2057.328	127.420	0.708837
SumClampVectorScalar	382.429	685.472	3.813290
SumClampVectorBase	67.663	3874.249	21.552507
SumClampVectorTraits	79.436	3300.060	18.358285
SumClampVector128_AdvSimd	79.554	3295.164	18.331048
SumClampVector128Base	3770.000	69.534	0.386820
SumClampVector128Traits	67.709	3871.644	21.538016
SumClampVector256Traits	3476.369	75.407	0.419493

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. Infinity!=130882.25684481156
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1522.958	172.128
SumClamp_MinMax	1905.365	137.582	0.799300
SumClamp_Math	1450.146	180.771	1.050210
SumClamp_BitMath	2316.509	113.163	0.657437
SumClampVectorScalar	400.304	654.862	3.804504
SumClampVectorBase	132.430	1979.492	11.500105
SumClampVectorTraits	210.938	1242.753	7.219928
SumClampVector128_AdvSimd	1858.743	141.033	0.819348
SumClampVector128Base	5289.913	49.555	0.287898
SumClampVector128Traits	158.434	1654.593	9.612561
SumClampVector256Traits	4485.126	58.447	0.339557

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1563.961	167.615
SumClamp_MinMax	1713.164	153.017	0.912908
SumClamp_Math	1548.822	169.254	1.009774
SumClamp_BitMath	1540.650	170.152	1.015131
SumClampVectorScalar	612.911	427.703	2.551694
SumClampVectorBase	33.555	7812.440	46.609299
SumClampVectorTraits	33.561	7810.993	46.600665
SumClampVector128_AdvSimd	33.552	7813.157	46.613575
SumClampVector128Base	2406.363	108.938	0.649927
SumClampVector128Traits	33.611	7799.330	46.531082
SumClampVector256Traits	2879.020	91.053	0.543227

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1522.752	172.151
SumClamp_MinMax	1568.187	167.164	0.971027
SumClamp_Math	1572.345	166.722	0.968460
SumClamp_BitMath	1238.929	211.589	1.229088
SumClampVectorScalar	424.042	618.203	3.591040
SumClampVectorBase	68.059	3851.721	22.374030
SumClampVectorTraits	67.632	3876.027	22.515218
SumClampVector128_AdvSimd	67.321	3893.951	22.619337
SumClampVector128Base	3673.911	71.353	0.414477
SumClampVector128Traits	67.455	3886.188	22.574244
SumClampVector256Traits	3818.429	68.652	0.398790

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 8566072936161031304!=-141951893350734
SumClamp_If	1560.600	167.976
SumClamp_MinMax	1589.056	164.968	0.982092
SumClamp_Math	1566.706	167.322	0.996102
SumClamp_BitMath	1369.069	191.476	1.139899
SumClampVectorScalar	482.661	543.122	3.233321
SumClampVectorBase	182.170	1439.011	8.566743
SumClampVectorTraits	226.909	1155.283	6.877648
SumClampVector128_AdvSimd	1807.298	145.047	0.863499
SumClampVector128_Arm64	182.442	1436.864	8.553961
SumClampVector128Base	5377.707	48.746	0.290198
SumClampVector128Traits	182.681	1434.984	8.542767
SumClampVector256Traits	4626.440	56.662	0.337322

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1569.005	167.077
SumClamp_MinMax	1678.753	156.154	0.934625
SumClamp_Math	1552.500	168.853	1.010631
SumClamp_BitMath	1472.144	178.070	1.065796
SumClampVectorScalar	569.158	460.582	2.756713
SumClampVectorBase	16.841	15565.576	93.164297
SumClampVectorTraits	16.854	15553.648	93.092909
SumClampVector128_AdvSimd	16.871	15538.005	92.999278
SumClampVector128Base	1581.801	165.725	0.991910
SumClampVector128Traits	16.863	15545.707	93.045375
SumClampVector256Traits	1493.806	175.487	1.050341

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1472.416	178.037
SumClamp_MinMax	2145.386	122.190	0.686318
SumClamp_Math	1450.371	180.743	1.015200
SumClamp_BitMath	2075.885	126.281	0.709296
SumClampVectorScalar	422.378	620.639	3.486019
SumClampVectorBase	67.314	3894.369	21.873978
SumClampVectorTraits	68.029	3853.405	21.643890
SumClampVector128_AdvSimd	67.504	3883.408	21.812414
SumClampVector128Base	3760.220	69.715	0.391577
SumClampVector128Traits	67.507	3883.198	21.811236
SumClampVector256Traits	3612.797	72.560	0.407556

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. Infinity!=130882.25684481156
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1244.033	210.721
SumClamp_MinMax	212.021	1236.406	5.867502
SumClamp_Math	1218.088	215.209	1.021300
SumClamp_BitMath	1011.002	259.291	1.230495
SumClampVectorScalar	309.890	845.926	4.014434
SumClampVectorBase	111.876	2343.170	11.119771
SumClampVectorTraits	211.271	1240.796	5.888334
SumClampVector128_AdvSimd	752.561	348.336	1.653066
SumClampVector128Bcl	135.450	1935.349	9.184414
SumClampVector128Base	135.109	1940.234	9.207594
SumClampVector128Traits	135.554	1933.877	9.177427
SumClampVector256Traits	3031.323	86.478	0.410393

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1322.434	198.228
SumClamp_MinMax	1385.198	189.247	0.954689
SumClamp_Math	1341.218	195.452	0.985994
SumClamp_BitMath	1231.122	212.931	1.074170
SumClampVectorScalar	473.910	553.151	2.790472
SumClampVectorBase	26.710	9814.435	49.510720
SumClampVectorTraits	26.697	9819.164	49.534578
SumClampVector128_AdvSimd	33.161	7905.218	39.879323
SumClampVector128Bcl	33.438	7839.706	39.548836
SumClampVector128Base	33.264	7880.709	39.755686
SumClampVector128Traits	33.233	7888.087	39.792901
SumClampVector256Traits	4163.471	62.963	0.317628

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1300.132	201.629
SumClamp_MinMax	1351.300	193.994	0.962134
SumClamp_Math	1252.302	209.330	1.038194
SumClamp_BitMath	941.925	278.307	1.380293
SumClampVectorScalar	264.729	990.234	4.911174
SumClampVectorBase	54.713	4791.270	23.762822
SumClampVectorTraits	54.728	4789.949	23.756269
SumClampVector128_AdvSimd	67.063	3908.929	19.386756
SumClampVector128Bcl	67.026	3911.099	19.397521
SumClampVector128Base	67.030	3910.848	19.396275
SumClampVector128Traits	67.002	3912.493	19.404434
SumClampVector256Traits	3542.218	74.006	0.367039

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 8566072936161031304!=-141951893350734
SumClamp_If	1314.535	199.420
SumClamp_MinMax	1314.119	199.483	1.000316
SumClamp_Math	1376.910	190.386	0.954699
SumClamp_BitMath	1068.637	245.307	1.230104
SumClampVectorScalar	509.127	514.889	2.581937
SumClampVectorBase	154.303	1698.887	8.519159
SumClampVectorTraits	212.644	1232.783	6.181855
SumClampVector128_AdvSimd	1778.516	147.395	0.739119
SumClampVector128_Arm64	187.015	1401.730	7.029049
SumClampVector128Bcl	187.396	1398.875	7.014735
SumClampVector128Base	187.345	1399.256	7.016645
SumClampVector128Traits	187.305	1399.559	7.018164
SumClampVector256Traits	3031.555	86.472	0.433617

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1320.704	198.488
SumClamp_MinMax	1292.336	202.845	1.021951
SumClamp_Math	1297.136	202.094	1.018169
SumClamp_BitMath	1135.346	230.894	1.163261
SumClampVectorScalar	429.229	610.733	3.076924
SumClampVectorBase	13.455	19483.520	98.159643
SumClampVectorTraits	13.460	19475.604	98.119763
SumClampVector128_AdvSimd	16.672	15724.011	79.218912
SumClampVector128Bcl	16.760	15641.000	78.800696
SumClampVector128Base	16.813	15592.102	78.554345
SumClampVector128Traits	16.667	15728.368	79.240866
SumClampVector256Traits	3067.229	85.466	0.430585

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130881.91!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1235.885	212.110
SumClamp_MinMax	211.208	1241.166	5.851510
SumClamp_Math	1222.047	214.512	1.011323
SumClamp_BitMath	937.651	279.575	1.318065
SumClampVectorScalar	309.562	846.823	3.992369
SumClampVectorBase	54.374	4821.109	22.729244
SumClampVectorTraits	54.369	4821.586	22.731494
SumClampVector128_AdvSimd	66.917	3917.471	18.469021
SumClampVector128Bcl	66.792	3924.753	18.503351
SumClampVector128Base	66.843	3921.758	18.489234
SumClampVector128Traits	66.817	3923.308	18.496538
SumClampVector256Traits	2918.797	89.812	0.423423

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	8.0.7
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/
RuntimeInformation.FrameworkDescription:	.NET 8.0.7
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Ubuntu 22.04.2 LTS
RuntimeInformation.RuntimeIdentifier:	linux-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844159	# 0x8177F801
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. Infinity!=130882.25684481156
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector512Bcl	Check `SumClampVector512Bcl` mismatch. 130882.25684481146!=130882.25684481156
Check-SumClampVector512Traits	Check `SumClampVector512Traits` mismatch. 130882.25684481146!=130882.25684481156
SumClamp_If	1166.117	224.801
SumClamp_MinMax	1782.158	147.094	0.654329
SumClamp_Math	1160.554	225.878	1.004793
SumClamp_BitMath	673.075	389.472	1.732522
SumClampVectorScalar	238.794	1097.784	4.883365
SumClampVectorBase	107.556	2437.285	10.841980
SumClampVectorTraits	210.932	1242.787	5.528393
SumClampVector128_AdvSimd	1741.962	150.488	0.669428
SumClampVector128Bcl	107.392	2441.002	10.858516
SumClampVector128Base	107.380	2441.278	10.859741
SumClampVector128Traits	107.316	2442.729	10.866200
SumClampVector256Traits	87.509	2995.611	13.325631
SumClampVector512Bcl	82.329	3184.094	14.164075
SumClampVector512Traits	82.035	3195.519	14.214895

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1329.458	197.181
SumClamp_MinMax	1378.383	190.182	0.964506
SumClamp_Math	1288.990	203.372	1.031396
SumClamp_BitMath	875.129	299.549	1.519156
SumClampVectorScalar	313.317	836.674	4.243176
SumClampVectorBase	27.277	9610.311	48.738501
SumClampVectorTraits	27.285	9607.779	48.725664
SumClampVector128_AdvSimd	27.401	9567.060	48.519158
SumClampVector128Bcl	27.331	9591.590	48.643558
SumClampVector128Base	27.337	9589.323	48.632063
SumClampVector128Traits	27.557	9512.823	48.244092
SumClampVector256Traits	23.739	11042.571	56.002180
SumClampVector512Bcl	22.561	11619.540	58.928268
SumClampVector512Traits	22.571	11614.050	58.900425

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1204.327	217.668
SumClamp_MinMax	1316.768	199.081	0.914609
SumClamp_Math	1169.082	224.231	1.030148
SumClamp_BitMath	675.127	388.288	1.783852
SumClampVectorScalar	248.526	1054.795	4.845879
SumClampVectorBase	55.744	4702.639	21.604597
SumClampVectorTraits	56.091	4673.562	21.471014
SumClampVector128_AdvSimd	56.028	4678.842	21.495273
SumClampVector128Bcl	55.983	4682.599	21.512531
SumClampVector128Base	56.143	4669.202	21.450983
SumClampVector128Traits	56.013	4680.058	21.500859
SumClampVector256Traits	48.245	5433.573	24.962615
SumClampVector512Bcl	45.618	5746.482	26.400162
SumClampVector512Traits	45.690	5737.426	26.358560

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 8566072936161031304!=-141951893350734
SumClamp_If	1378.948	190.104
SumClamp_MinMax	1298.863	201.826	1.061657
SumClamp_Math	1419.703	184.647	0.971293
SumClamp_BitMath	780.129	336.027	1.767590
SumClampVectorScalar	359.773	728.638	3.832833
SumClampVectorBase	171.605	1527.601	8.035591
SumClampVectorTraits	221.299	1184.569	6.231153
SumClampVector128_AdvSimd	1739.427	150.707	0.792760
SumClampVector128_Arm64	172.190	1522.410	8.008288
SumClampVector128Bcl	171.889	1525.076	8.022309
SumClampVector128Base	172.003	1524.067	8.017005
SumClampVector128Traits	171.708	1526.688	8.030788
SumClampVector256Traits	155.944	1681.013	8.842581
SumClampVector512Bcl	152.495	1719.035	9.042587
SumClampVector512Traits	152.743	1716.239	9.027880

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1329.316	197.202
SumClamp_MinMax	1311.135	199.937	1.013866
SumClamp_Math	1335.295	196.319	0.995522
SumClamp_BitMath	814.598	321.808	1.631868
SumClampVectorScalar	282.755	927.106	4.701296
SumClampVectorBase	13.731	19091.196	96.810256
SumClampVectorTraits	13.721	19104.693	96.878701
SumClampVector128_AdvSimd	13.729	19094.676	96.827903
SumClampVector128Bcl	13.746	19070.673	96.706189
SumClampVector128Base	13.762	19048.761	96.595073
SumClampVector128Traits	13.722	19104.087	96.875627
SumClampVector256Traits	11.945	21945.467	111.284087
SumClampVector512Bcl	11.086	23647.038	119.912646
SumClampVector512Traits	11.085	23647.760	119.916310

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130881.91!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
Check-SumClampVector512Bcl	Check `SumClampVector512Bcl` mismatch. 130882.27!=130883.55
Check-SumClampVector512Traits	Check `SumClampVector512Traits` mismatch. 130882.27!=130883.55
SumClamp_If	1163.831	225.242
SumClamp_MinMax	1777.919	147.444	0.654602
SumClamp_Math	1156.782	226.615	1.006093
SumClamp_BitMath	584.426	448.550	1.991408
SumClampVectorScalar	235.623	1112.555	4.939368
SumClampVectorBase	56.330	4653.687	20.660793
SumClampVectorTraits	56.500	4639.709	20.598737
SumClampVector128_AdvSimd	56.287	4657.250	20.676609
SumClampVector128_Wasm_NoPseudo	Run fail! Requires hardware support PackedSimd!
SumClampVector128_Wasm_Pseudo	Run fail! Requires hardware support PackedSimd!
SumClampVector128Bcl	56.433	4645.216	20.623184
SumClampVector128Base	56.253	4660.110	20.689310
SumClampVector128Traits	55.959	4684.554	20.797831
SumClampVector256Traits	48.600	5393.865	23.946933
SumClampVector512Bcl	45.879	5713.782	25.367254
SumClampVector512Traits	45.931	5707.295	25.338457

```

## Wasm

### Wasm on AMD Ryzen 7 7840H
``

#### .NET 8.0

```
VectorTraits.Benchmarks.Wasm


IsRelease:	True
Environment.ProcessorCount:	1
Environment.Is64BitProcess:	False
Environment.OSVersion:	Other 1.0.0.0
Environment.Version:	8.0.7
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/
RuntimeInformation.FrameworkDescription:	.NET 8.0.7
RuntimeInformation.OSArchitecture:	Wasm
RuntimeInformation.OSDescription:	Browser
RuntimeInformation.RuntimeIdentifier:	browser-wasm
IntPtr.Size:	4
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	False
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844158	# 0x8177F802
VectorEnvironment.CpuModelName:	
VectorEnvironment.SupportedInstructionSets:	PackedSimd
Vector128s.Instance:	WVectorTraits128PackedSimd	// PackedSimd
Vectors.Instance:	VectorTraits128PackedSimd	// PackedSimd
Vectors.BaseInstance:	VectorTraits128Base


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. ∞!=130882.25684481156
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector512Bcl	Check `SumClampVector512Bcl` mismatch. 130882.25684481146!=130882.25684481156
Check-SumClampVector512Traits	Check `SumClampVector512Traits` mismatch. 130882.25684481146!=130882.25684481156
SumClamp_If	10709.375	24.478
SumClamp_MinMax	10205.208	25.687	1.049403
SumClamp_Math	15337.500	17.092	0.698248
SumClamp_BitMath	21947.917	11.944	0.487945
SumClampVectorScalar	163550.000	1.603	0.065481
SumClampVectorBase	96291.667	2.722	0.111218
SumClampVectorTraits	40575.000	6.461	0.263940
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	176183.333	1.488	0.060785
SumClampVector128Base	175950.000	1.490	0.060866
SumClampVector128Traits	8083.333	32.430	1.324871
SumClampVector256Traits	186733.333	1.404	0.057351
SumClampVector512Bcl	178433.334	1.469	0.060019
SumClampVector512Traits	174616.667	1.501	0.061331

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	11210.417	23.384
SumClamp_MinMax	15168.750	17.282	0.739047
SumClamp_Math	14923.958	17.565	0.751169
SumClamp_BitMath	23260.417	11.270	0.481953
SumClampVectorScalar	332166.667	0.789	0.033749
SumClampVectorBase	41054.167	6.385	0.273064
SumClampVectorTraits	4015.625	65.281	2.791699
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	54766.667	4.787	0.204694
SumClampVector128Base	53666.667	4.885	0.208890
SumClampVector128Traits	1971.615	132.959	5.685907
SumClampVector256Traits	62983.333	4.162	0.177990
SumClampVector512Bcl	65850.000	3.981	0.170242
SumClampVector512Traits	65950.000	3.975	0.169984

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	10822.917	24.221
SumClamp_MinMax	14463.542	18.124	0.748290
SumClamp_Math	13788.542	19.012	0.784921
SumClamp_BitMath	18512.500	14.160	0.584628
SumClampVectorScalar	200966.666	1.304	0.053854
SumClampVectorBase	43100.000	6.082	0.251112
SumClampVectorTraits	7859.896	33.352	1.376980
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	72300.000	3.626	0.149695
SumClampVector128Base	71475.000	3.668	0.151422
SumClampVector128Traits	4093.750	64.035	2.643766
SumClampVector256Traits	96966.667	2.703	0.111615
SumClampVector512Bcl	98450.000	2.663	0.109933
SumClampVector512Traits	98183.333	2.670	0.110232

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 8566072936161031304!=-141951893350734
SumClamp_If	10409.375	25.183
SumClamp_MinMax	13706.250	19.126	0.759462
SumClamp_Math	14096.875	18.596	0.738417
SumClamp_BitMath	20450.000	12.819	0.509016
SumClampVectorScalar	130783.333	2.004	0.079593
SumClampVectorBase	79016.667	3.318	0.131736
SumClampVectorTraits	149866.667	1.749	0.069458
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
SumClampVector128Bcl	157366.666	1.666	0.066147
SumClampVector128Base	160083.333	1.638	0.065025
SumClampVector128Traits	122050.000	2.148	0.085288
SumClampVector256Traits	160166.667	1.637	0.064991
SumClampVector512Bcl	166650.000	1.573	0.062462
SumClampVector512Traits	158800.000	1.651	0.065550

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	11090.625	23.637
SumClamp_MinMax	15147.917	17.306	0.732155
SumClamp_Math	14620.833	17.929	0.758549
SumClamp_BitMath	22362.500	11.722	0.495947
SumClampVectorScalar	524550.000	0.500	0.021143
SumClampVectorBase	30764.583	8.521	0.360500
SumClampVectorTraits	1948.437	134.541	5.692061
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128Bcl	36500.000	7.182	0.303853
SumClampVector128Base	37616.667	6.969	0.294833
SumClampVector128Traits	907.943	288.723	12.215115
SumClampVector256Traits	42266.667	6.202	0.262396
SumClampVector512Bcl	45483.333	5.764	0.243839
SumClampVector512Traits	44941.667	5.833	0.246778

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_Wasm_NoPseudo	Check `SumClampVector128_Wasm_NoPseudo` mismatch. 130881.91!=130883.55
Check-SumClampVector128_Wasm_Pseudo	Check `SumClampVector128_Wasm_Pseudo` mismatch. 130881.91!=130883.55
Check-SumClampVector128Bcl	Check `SumClampVector128Bcl` mismatch. 130881.91!=130883.55
Check-SumClampVector128Base	Check `SumClampVector128Base` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
Check-SumClampVector512Bcl	Check `SumClampVector512Bcl` mismatch. 130882.27!=130883.55
Check-SumClampVector512Traits	Check `SumClampVector512Traits` mismatch. 130882.27!=130883.55
SumClamp_If	10463.542	25.053
SumClamp_MinMax	21406.250	12.246	0.488808
SumClamp_Math	14458.333	18.131	0.723703
SumClamp_BitMath	18604.167	14.091	0.562430
SumClampVectorScalar	260533.333	1.006	0.040162
SumClampVectorBase	58558.333	4.477	0.178686
SumClampVectorTraits	7779.167	33.698	1.345072
SumClampVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Wasm_NoPseudo	4004.688	65.459	2.612824
SumClampVector128_Wasm_Pseudo	3999.479	65.545	2.616226
SumClampVector128Bcl	85858.333	3.053	0.121870
SumClampVector128Base	86900.000	3.017	0.120409
SumClampVector128Traits	4095.312	64.011	2.555004
SumClampVector256Traits	105333.333	2.489	0.099337
SumClampVector512Bcl	107933.333	2.429	0.096944
SumClampVector512Traits	110400.000	2.374	0.094778

```

