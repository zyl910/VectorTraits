# Benchmark - YClamp
([← Back](README.md))

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1588.049	165.073
SumClamp_MinMax	2158.829	121.429	0.735607
SumClamp_Math	1472.245	178.057	1.078658
SumClamp_BitMath	1624.806	161.339	0.977377
SumClampVectorScalar	386.308	678.588	4.110834
SumClampVectorBase	132.601	1976.940	11.976155
SumClampVectorTraits	158.338	1655.595	10.029471
SumClampVector128Traits	4521.650	57.975	0.351210
SumClampVector256Traits	9388.687	27.921	0.169145

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1618.982	161.919
SumClamp_MinMax	1536.722	170.586	1.053530
SumClamp_Math	1513.758	173.174	1.069512
SumClamp_BitMath	1188.237	220.616	1.362508
SumClampVectorScalar	606.618	432.140	2.668868
SumClampVectorBase	33.494	7826.693	48.337089
SumClampVectorTraits	33.500	7825.292	48.328434
SumClampVector128Traits	1802.716	145.416	0.898079
SumClampVector256Traits	2783.975	94.162	0.581536

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1563.830	167.629
SumClamp_MinMax	1571.772	166.782	0.994947
SumClamp_Math	1553.471	168.747	1.006668
SumClamp_BitMath	947.749	276.596	1.650046
SumClampVectorScalar	421.355	622.145	3.711428
SumClampVectorBase	79.894	3281.144	19.573790
SumClampVectorTraits	79.500	3297.408	19.670815
SumClampVector128Traits	3307.649	79.254	0.472792
SumClampVector256Traits	5126.769	51.132	0.305032

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1677.197	156.299
SumClamp_MinMax	1707.800	153.498	0.982081
SumClamp_Math	1590.627	164.805	1.054425
SumClamp_BitMath	1062.793	246.656	1.578103
SumClampVectorScalar	716.728	365.751	2.340075
SumClampVectorBase	309.219	847.762	5.423980
SumClampVectorTraits	309.472	847.069	5.419547
SumClampVector128Traits	4041.513	64.863	0.414992
SumClampVector256Traits	9512.647	27.557	0.176312

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1694.529	154.700
SumClamp_MinMax	1679.898	156.048	1.008710
SumClamp_Math	1623.828	161.436	1.043540
SumClamp_BitMath	1159.307	226.121	1.461674
SumClampVectorScalar	591.701	443.035	2.863827
SumClampVectorBase	16.823	15582.326	100.725964
SumClampVectorTraits	16.835	15571.467	100.655772
SumClampVector128Traits	1155.280	226.910	1.466770
SumClampVector256Traits	1367.281	191.727	1.239343

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1507.688	173.871
SumClamp_MinMax	2423.954	108.147	0.621995
SumClamp_Math	1472.268	178.055	1.024059
SumClamp_BitMath	1522.782	172.148	0.990088
SumClampVectorScalar	381.840	686.528	3.948481
SumClampVectorBase	67.773	3867.973	22.246165
SumClampVectorTraits	67.649	3875.048	22.286856
SumClampVector128Traits	3290.297	79.672	0.458223
SumClampVector256Traits	4908.271	53.409	0.307173

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1497.256	175.083
SumClamp_MinMax	1995.446	131.371	0.750336
SumClamp_Math	1495.693	175.266	1.001045
SumClamp_BitMath	2290.986	114.424	0.653542
SumClampVectorScalar	386.111	678.935	3.877790
SumClampVectorBase	132.432	1979.468	11.305885
SumClampVectorTraits	132.499	1978.454	11.300092
SumClampVector128_AdvSimd	1821.997	143.877	0.821766
SumClampVector128Traits	132.459	1979.062	11.303565
SumClampVector256Traits	4581.469	57.218	0.326807

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1515.387	172.988
SumClamp_MinMax	1620.949	161.723	0.934877
SumClamp_Math	1574.604	166.482	0.962392
SumClamp_BitMath	1535.846	170.684	0.986679
SumClampVectorScalar	610.731	429.230	2.481267
SumClampVectorBase	33.537	7816.561	45.185528
SumClampVectorTraits	39.716	6600.392	38.155166
SumClampVector128_AdvSimd	39.563	6626.016	38.303293
SumClampVector128Traits	33.571	7808.673	45.139929
SumClampVector256Traits	2851.723	91.925	0.531394

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1521.338	172.312
SumClamp_MinMax	1566.104	167.386	0.971415
SumClamp_Math	1599.858	163.854	0.950920
SumClamp_BitMath	1234.324	212.379	1.232527
SumClampVectorScalar	397.869	658.870	3.823716
SumClampVectorBase	80.025	3275.757	19.010668
SumClampVectorTraits	79.641	3291.572	19.102445
SumClampVector128_AdvSimd	67.912	3860.075	22.401725
SumClampVector128Traits	68.157	3846.174	22.321047
SumClampVector256Traits	3949.279	66.378	0.385219

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1576.254	166.308
SumClamp_MinMax	1699.611	154.238	0.927420
SumClamp_Math	1628.939	160.929	0.967657
SumClamp_BitMath	1359.801	192.781	1.159180
SumClampVectorScalar	472.423	554.892	3.336530
SumClampVectorBase	182.696	1434.866	8.627752
SumClampVectorTraits	182.793	1434.107	8.623187
SumClampVector128_AdvSimd	1796.486	145.920	0.877410
SumClampVector128_Arm64	182.132	1439.311	8.654481
SumClampVector128Traits	182.188	1438.866	8.651806
SumClampVector256Traits	4497.154	58.291	0.350500

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1624.306	161.388
SumClamp_MinMax	1700.806	154.129	0.955021
SumClamp_Math	1677.856	156.237	0.968084
SumClamp_BitMath	1496.355	175.188	1.085509
SumClampVectorScalar	595.851	439.949	2.726026
SumClampVectorBase	19.947	13141.723	81.429217
SumClampVectorTraits	19.942	13145.372	81.451827
SumClampVector128_AdvSimd	16.836	15570.587	96.479029
SumClampVector128Traits	16.854	15553.970	96.376066
SumClampVector256Traits	1479.542	177.179	1.097844

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1528.479	171.506
SumClamp_MinMax	1994.344	131.444	0.766407
SumClamp_Math	1453.763	180.321	1.051395
SumClamp_BitMath	2030.580	129.098	0.752731
SumClampVectorScalar	382.448	685.437	3.996569
SumClampVectorBase	68.131	3847.645	22.434406
SumClampVectorTraits	80.145	3270.883	19.071492
SumClampVector128_AdvSimd	79.995	3276.997	19.107138
SumClampVector128Traits	80.029	3275.621	19.099114
SumClampVector256Traits	3895.904	67.287	0.392330

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1480.153	177.106
SumClamp_MinMax	1939.639	135.151	0.763108
SumClamp_Math	1545.128	169.658	0.957948
SumClamp_BitMath	2320.392	112.974	0.637889
SumClampVectorScalar	401.202	653.397	3.689296
SumClampVectorBase	133.360	1965.685	11.098918
SumClampVectorTraits	158.973	1648.988	9.310743
SumClampVector128_AdvSimd	1853.457	141.435	0.798590
SumClampVector128Traits	158.999	1648.710	9.309170
SumClampVector256Traits	4572.715	57.328	0.323692

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1518.971	172.580
SumClamp_MinMax	1758.447	149.077	0.863814
SumClamp_Math	1576.136	166.321	0.963731
SumClamp_BitMath	1535.231	170.752	0.989409
SumClampVectorScalar	614.734	426.435	2.470941
SumClampVectorBase	34.180	7669.598	44.440832
SumClampVectorTraits	34.212	7662.379	44.399005
SumClampVector128_AdvSimd	34.243	7655.475	44.358998
SumClampVector128Traits	34.156	7674.842	44.471220
SumClampVector256Traits	2766.798	94.746	0.549000

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1519.893	172.475
SumClamp_MinMax	1643.194	159.533	0.924962
SumClamp_Math	1602.646	163.570	0.948365
SumClamp_BitMath	1237.813	211.780	1.227885
SumClampVectorScalar	407.832	642.775	3.726763
SumClampVectorBase	68.272	3839.679	22.262190
SumClampVectorTraits	68.278	3839.369	22.260394
SumClampVector128_AdvSimd	68.395	3832.793	22.222263
SumClampVector128Traits	68.467	3828.781	22.199003
SumClampVector256Traits	3673.165	71.367	0.413783

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1565.666	167.433
SumClamp_MinMax	1584.451	165.448	0.988144
SumClamp_Math	1561.132	167.919	1.002904
SumClamp_BitMath	1359.643	192.804	1.151527
SumClampVectorScalar	511.553	512.447	3.060612
SumClampVectorBase	183.528	1428.361	8.530942
SumClampVectorTraits	183.715	1426.904	8.522244
SumClampVector128_AdvSimd	1793.450	146.167	0.872991
SumClampVector128_Arm64	184.787	1418.628	8.472816
SumClampVector128Traits	183.971	1424.916	8.510371
SumClampVector256Traits	4588.614	57.129	0.341207

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1564.782	167.527
SumClamp_MinMax	1675.927	156.417	0.933682
SumClamp_Math	1549.903	169.136	1.009600
SumClamp_BitMath	1460.180	179.529	1.071636
SumClampVectorScalar	567.185	462.184	2.758856
SumClampVectorBase	16.864	15544.478	92.787645
SumClampVectorTraits	16.879	15531.098	92.707778
SumClampVector128_AdvSimd	16.878	15531.832	92.712159
SumClampVector128Traits	16.872	15537.514	92.746073
SumClampVector256Traits	1502.235	174.503	1.041636

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1471.450	178.153
SumClamp_MinMax	2137.969	122.614	0.688247
SumClamp_Math	1450.927	180.673	1.014145
SumClamp_BitMath	2041.818	128.388	0.720657
SumClampVectorScalar	422.820	619.989	3.480085
SumClampVectorBase	68.712	3815.119	21.414789
SumClampVectorTraits	68.740	3813.554	21.406003
SumClampVector128_AdvSimd	68.675	3817.158	21.426235
SumClampVector128Traits	68.754	3812.774	21.401623
SumClampVector256Traits	3616.583	72.484	0.406862

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1240.182	211.375
SumClamp_MinMax	211.952	1236.810	5.851248
SumClamp_Math	1218.701	215.101	1.017626
SumClamp_BitMath	1008.949	259.819	1.229182
SumClampVectorScalar	308.887	848.672	4.015000
SumClampVectorBase	112.978	2320.303	10.977165
SumClampVectorTraits	112.977	2320.341	10.977344
SumClampVector128_AdvSimd	750.996	349.062	1.651383
SumClampVector128Traits	135.653	1932.453	9.142279
SumClampVector256Traits	3024.040	86.687	0.410108

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1320.443	198.527
SumClamp_MinMax	1384.209	189.382	0.953933
SumClamp_Math	1338.732	195.815	0.986338
SumClamp_BitMath	1229.297	213.247	1.074145
SumClampVectorScalar	476.332	550.339	2.772109
SumClampVectorBase	26.711	9814.223	49.435116
SumClampVectorTraits	26.720	9810.699	49.417370
SumClampVector128_AdvSimd	33.126	7913.656	39.861795
SumClampVector128Traits	33.112	7916.946	39.878366
SumClampVector256Traits	4157.065	63.060	0.317638

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1298.534	201.877
SumClamp_MinMax	1349.077	194.314	0.962536
SumClamp_Math	1248.954	209.891	1.039697
SumClamp_BitMath	935.188	280.312	1.388527
SumClampVectorScalar	265.279	988.181	4.894972
SumClampVectorBase	55.065	4760.626	23.581835
SumClampVectorTraits	55.061	4760.959	23.583486
SumClampVector128_AdvSimd	67.445	3886.755	19.253103
SumClampVector128Traits	67.383	3890.375	19.271034
SumClampVector256Traits	3659.145	71.641	0.354874

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1314.582	199.412
SumClamp_MinMax	1280.980	204.643	1.026231
SumClamp_Math	1353.910	193.620	0.970952
SumClamp_BitMath	1066.152	245.879	1.233015
SumClampVectorScalar	508.969	515.049	2.582833
SumClampVectorBase	154.150	1700.577	8.527937
SumClampVectorTraits	154.162	1700.449	8.527293
SumClampVector128_AdvSimd	1768.547	148.226	0.743312
SumClampVector128_Arm64	187.456	1398.432	7.012762
SumClampVector128Traits	187.115	1400.979	7.025534
SumClampVector256Traits	3084.887	84.977	0.426136

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1316.078	199.186
SumClamp_MinMax	1292.445	202.828	1.018286
SumClamp_Math	1290.745	203.095	1.019627
SumClamp_BitMath	1132.571	231.459	1.162027
SumClampVectorScalar	428.192	612.211	3.073571
SumClampVectorBase	13.452	19486.919	97.832897
SumClampVectorTraits	13.449	19491.937	97.858090
SumClampVector128_AdvSimd	16.622	15770.986	79.177280
SumClampVector128Traits	16.624	15769.093	79.167778
SumClampVector256Traits	3055.926	85.782	0.430664

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1237.488	211.836
SumClamp_MinMax	211.828	1237.532	5.841948
SumClamp_Math	1217.233	215.361	1.016641
SumClamp_BitMath	935.907	280.096	1.322234
SumClampVectorScalar	307.324	852.990	4.026663
SumClampVectorBase	55.382	4733.386	22.344631
SumClampVectorTraits	55.354	4735.763	22.355849
SumClampVector128_AdvSimd	67.489	3884.225	18.336043
SumClampVector128Traits	67.645	3875.290	18.293865
SumClampVector256Traits	2895.015	90.550	0.427455

```

