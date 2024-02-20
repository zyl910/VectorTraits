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
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	3.1.31
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.31
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1587.760	165.103
SumClamp_MinMax	2178.762	120.318	0.728744
SumClamp_Math	1474.440	177.792	1.076856
SumClamp_BitUtil	1596.014	164.249	0.994828
SumClampVectorScalar	385.613	679.811	4.117494
SumClampVectorBase	134.909	1943.113	11.769091
SumClampVectorTraits	134.523	1948.691	11.802874
SumClampVector128Traits	2949.064	88.891	0.538394
SumClampVector256Traits	7154.960	36.638	0.221910

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1529.624	171.378
SumClamp_MinMax	1621.412	161.676	0.943390
SumClamp_Math	1621.400	161.678	0.943397
SumClamp_BitUtil	1189.230	220.432	1.286231
SumClampVectorScalar	613.607	427.218	2.492838
SumClampVectorBase	39.638	6613.497	38.590105
SumClampVectorTraits	33.320	7867.359	45.906454
SumClampVector128Traits	1751.056	149.706	0.873544
SumClampVector256Traits	2684.773	97.641	0.569741

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1563.886	167.624
SumClamp_MinMax	1529.022	171.446	1.022802
SumClamp_Math	1506.342	174.027	1.038201
SumClamp_BitUtil	947.644	276.627	1.650288
SumClampVectorScalar	421.654	621.704	3.708930
SumClampVectorBase	79.618	3292.520	19.642350
SumClampVectorTraits	79.724	3288.143	19.616237
SumClampVector128Traits	3316.644	79.039	0.471527
SumClampVector256Traits	5210.626	50.310	0.300134

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1591.384	164.727
SumClamp_MinMax	1733.247	151.244	0.918152
SumClamp_Math	1553.532	168.741	1.024365
SumClamp_BitUtil	1056.874	248.037	1.505747
SumClampVectorScalar	716.438	365.899	2.221244
SumClampVectorBase	284.392	921.771	5.595750
SumClampVectorTraits	284.577	921.170	5.592097
SumClampVector128Traits	2319.325	113.026	0.686141
SumClampVector256Traits	4416.653	59.354	0.360314

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1645.522	159.307
SumClamp_MinMax	1596.838	164.164	1.030488
SumClamp_Math	1640.774	159.768	1.002894
SumClamp_BitUtil	1158.909	226.199	1.419889
SumClampVectorScalar	594.904	440.649	2.766031
SumClampVectorBase	19.825	13223.016	83.003112
SumClampVectorTraits	19.838	13214.068	82.946948
SumClampVector128Traits	1061.056	247.060	1.550834
SumClampVector256Traits	1576.512	166.281	1.043774

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1570.506	166.917
SumClamp_MinMax	2168.072	120.911	0.724379
SumClamp_Math	1471.624	178.132	1.067193
SumClamp_BitUtil	1521.857	172.253	1.031967
SumClampVectorScalar	383.035	684.387	4.100168
SumClampVectorBase	67.553	3880.545	23.248371
SumClampVectorTraits	67.589	3878.492	23.236073
SumClampVector128Traits	3266.738	80.246	0.480757
SumClampVector256Traits	5130.562	51.095	0.306108

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
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
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
SumClamp_If	1545.658	169.600
SumClamp_MinMax	2004.861	130.754	0.770955
SumClamp_Math	1465.969	178.820	1.054359
SumClamp_BitUtil	2320.424	112.972	0.666110
SumClampVectorScalar	389.378	673.237	3.969551
SumClampVectorBase	133.863	1958.302	11.546574
SumClampVectorTraits	133.869	1958.206	11.546006
SumClampVector128_AdvSimd	1485.092	176.517	1.040783
SumClampVector128Traits	133.392	1965.215	11.587332
SumClampVector256Traits	3008.985	87.120	0.513681

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1551.573	168.954
SumClamp_MinMax	1531.442	171.175	1.013145
SumClamp_Math	1557.712	168.288	0.996059
SumClamp_BitUtil	1553.268	168.769	0.998909
SumClampVectorScalar	614.415	426.656	2.525286
SumClampVectorBase	40.043	6546.640	38.748137
SumClampVectorTraits	34.095	7688.617	45.507251
SumClampVector128_AdvSimd	33.918	7728.677	45.744359
SumClampVector128Traits	40.314	6502.519	38.486995
SumClampVector256Traits	2387.483	109.799	0.649878

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1480.971	177.008
SumClamp_MinMax	1581.713	165.734	0.936309
SumClamp_Math	1528.743	171.477	0.968751
SumClamp_BitUtil	1242.354	211.006	1.192069
SumClampVectorScalar	399.912	655.504	3.703241
SumClampVectorBase	68.779	3811.396	21.532319
SumClampVectorTraits	68.541	3824.629	21.607079
SumClampVector128_AdvSimd	80.577	3253.323	18.379512
SumClampVector128Traits	80.209	3268.265	18.463925
SumClampVector256Traits	3175.573	82.550	0.466364

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1633.783	160.452
SumClamp_MinMax	1707.506	153.525	0.956824
SumClamp_Math	1599.495	163.892	1.021437
SumClamp_BitUtil	1377.648	190.284	1.185922
SumClampVectorScalar	467.718	560.475	3.493096
SumClampVectorBase	184.843	1418.196	8.838744
SumClampVectorTraits	186.486	1405.707	8.760906
SumClampVector128_AdvSimd	1433.062	182.926	1.140064
SumClampVector128_AdvSimd64	184.592	1420.127	8.850777
SumClampVector128Traits	184.916	1417.636	8.835252
SumClampVector256Traits	2571.964	101.924	0.635228

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1576.240	166.310
SumClamp_MinMax	1706.391	153.625	0.923728
SumClamp_Math	1641.762	159.672	0.960091
SumClamp_BitUtil	1502.352	174.489	1.049182
SumClampVectorScalar	598.317	438.135	2.634455
SumClampVectorBase	16.892	15518.749	93.312369
SumClampVectorTraits	16.965	15452.052	92.911328
SumClampVector128_AdvSimd	20.029	13088.214	78.697854
SumClampVector128Traits	20.017	13096.164	78.745654
SumClampVector256Traits	1828.070	143.399	0.862243

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1462.712	179.218
SumClamp_MinMax	2017.755	129.919	0.724920
SumClamp_Math	1511.019	173.488	0.968030
SumClamp_BitUtil	2055.388	127.540	0.711648
SumClampVectorScalar	383.274	683.960	3.816363
SumClampVectorBase	80.646	3250.539	18.137367
SumClampVectorTraits	68.422	3831.290	21.377847
SumClampVector128_AdvSimd	68.899	3804.758	21.229801
SumClampVector128Traits	68.923	3803.452	21.222516
SumClampVector256Traits	3089.452	84.851	0.473454

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
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	6.0.11
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/
RuntimeInformation.FrameworkDescription:	.NET 6.0.11
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
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
SumClamp_If	1490.817	175.839
SumClamp_MinMax	1931.634	135.711	0.771791
SumClamp_Math	1425.787	183.859	1.045610
SumClamp_BitUtil	2337.483	112.148	0.637788
SumClampVectorScalar	426.213	615.053	3.497819
SumClampVectorBase	134.121	1954.541	11.115508
SumClampVectorTraits	133.522	1963.298	11.165311
SumClampVector128_AdvSimd	1481.306	176.968	1.006421
SumClampVector128Traits	134.207	1953.280	11.108339
SumClampVector256Traits	3199.120	81.943	0.466009

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1558.021	168.255
SumClamp_MinMax	1687.553	155.340	0.923243
SumClamp_Math	1591.123	164.754	0.979196
SumClamp_BitUtil	1551.969	168.911	1.003900
SumClampVectorScalar	616.165	425.445	2.528577
SumClampVectorBase	33.748	7767.658	46.166123
SumClampVectorTraits	34.062	7696.191	45.741370
SumClampVector128_AdvSimd	34.062	7696.195	45.741390
SumClampVector128Traits	34.016	7706.450	45.802340
SumClampVector256Traits	2529.319	103.642	0.615984

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1476.857	177.501
SumClamp_MinMax	1572.279	166.729	0.939310
SumClamp_Math	1531.052	171.218	0.964603
SumClamp_BitUtil	1246.213	210.353	1.185077
SumClampVectorScalar	408.270	642.084	3.617352
SumClampVectorBase	68.809	3809.717	21.463049
SumClampVectorTraits	68.795	3810.521	21.467577
SumClampVector128_AdvSimd	68.485	3827.758	21.564685
SumClampVector128Traits	68.780	3811.325	21.472103
SumClampVector256Traits	3205.332	81.784	0.460750

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1586.389	165.246
SumClamp_MinMax	1646.458	159.217	0.963516
SumClamp_Math	1568.312	167.150	1.011526
SumClamp_BitUtil	1374.063	190.780	1.154524
SumClampVectorScalar	507.200	516.846	3.127739
SumClampVectorBase	184.843	1418.199	8.582366
SumClampVectorTraits	184.533	1420.583	8.596791
SumClampVector128_AdvSimd	1428.160	183.554	1.110792
SumClampVector128_AdvSimd64	184.449	1421.224	8.600668
SumClampVector128Traits	186.012	1409.283	8.528407
SumClampVector256Traits	2702.764	96.991	0.586951

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1583.729	165.523
SumClamp_MinMax	1630.137	160.811	0.971531
SumClamp_Math	1558.250	168.230	1.016351
SumClamp_BitUtil	1469.260	178.419	1.077909
SumClampVectorScalar	566.095	463.074	2.797636
SumClampVectorBase	17.036	15387.905	92.965177
SumClampVectorTraits	17.035	15388.486	92.968686
SumClampVector128_AdvSimd	16.940	15474.626	93.489100
SumClampVector128Traits	17.058	15367.514	92.841987
SumClampVector256Traits	1908.234	137.375	0.829944

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1475.081	177.715
SumClamp_MinMax	2032.980	128.946	0.725576
SumClamp_Math	1458.920	179.684	1.011078
SumClamp_BitUtil	2047.835	128.010	0.720312
SumClampVectorScalar	425.848	615.581	3.463865
SumClampVectorBase	69.252	3785.379	21.300284
SumClampVectorTraits	69.797	3755.782	21.133740
SumClampVector128_AdvSimd	69.067	3795.518	21.357336
SumClampVector128Traits	69.155	3790.700	21.330227
SumClampVector256Traits	3164.462	82.840	0.466140

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
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	7.0.1
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/
RuntimeInformation.FrameworkDescription:	.NET 7.0.1
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
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
SumClamp_If	1242.012	211.064
SumClamp_MinMax	211.667	1238.472	5.867754
SumClamp_Math	1218.118	215.204	1.019615
SumClamp_BitUtil	1018.869	257.289	1.219010
SumClampVectorScalar	308.497	849.746	4.026009
SumClampVectorBase	112.888	2322.158	11.002150
SumClampVectorTraits	112.892	2322.076	11.001762
SumClampVector128_AdvSimd	1465.925	178.825	0.847255
SumClampVector128Traits	136.025	1927.171	9.130739
SumClampVector256Traits	3018.289	86.852	0.411495

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1323.253	198.106
SumClamp_MinMax	1383.570	189.469	0.956405
SumClamp_Math	1341.639	195.391	0.986295
SumClamp_BitUtil	1231.898	212.797	1.074158
SumClampVectorScalar	469.642	558.178	2.817575
SumClampVectorBase	26.780	9788.683	49.411401
SumClampVectorTraits	26.843	9765.709	49.295434
SumClampVector128_AdvSimd	33.195	7897.137	39.863238
SumClampVector128Traits	33.165	7904.151	39.898645
SumClampVector256Traits	4170.027	62.864	0.317325

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1304.687	200.925
SumClamp_MinMax	1353.238	193.716	0.964123
SumClamp_Math	1253.535	209.124	1.040806
SumClamp_BitUtil	936.393	279.951	1.393312
SumClampVectorScalar	265.359	987.884	4.916686
SumClampVectorBase	55.208	4748.260	23.632030
SumClampVectorTraits	55.197	4749.250	23.636953
SumClampVector128_AdvSimd	67.499	3883.688	19.329065
SumClampVector128Traits	67.505	3883.312	19.327194
SumClampVector256Traits	3604.374	72.729	0.361973

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1315.407	199.287
SumClamp_MinMax	1284.572	204.071	1.024005
SumClamp_Math	1361.282	192.571	0.966301
SumClamp_BitUtil	1065.777	245.965	1.234224
SumClampVectorScalar	508.650	515.372	2.586075
SumClampVectorBase	153.943	1702.859	8.544743
SumClampVectorTraits	153.899	1703.353	8.547222
SumClampVector128_AdvSimd	1423.875	184.106	0.923822
SumClampVector128_AdvSimd64	187.516	1397.983	7.014911
SumClampVector128Traits	187.715	1396.501	7.007476
SumClampVector256Traits	3090.383	84.826	0.425645

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1318.346	198.843
SumClamp_MinMax	1285.266	203.961	1.025737
SumClamp_Math	1287.821	203.556	1.023702
SumClamp_BitUtil	1136.966	230.565	1.159530
SumClampVectorScalar	429.084	610.939	3.072465
SumClampVectorBase	13.477	19450.689	97.819251
SumClampVectorTraits	13.466	19467.714	97.904871
SumClampVector128_AdvSimd	16.624	15768.957	79.303491
SumClampVector128Traits	16.640	15753.675	79.226640
SumClampVector256Traits	3059.376	85.685	0.430920

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_AdvSimd	Check `SumClampVector128_AdvSimd` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1239.933	211.418
SumClamp_MinMax	212.646	1232.772	5.830974
SumClamp_Math	1220.643	214.759	1.015803
SumClamp_BitUtil	937.140	279.728	1.323103
SumClampVectorScalar	307.763	851.772	4.028856
SumClampVectorBase	55.491	4724.083	22.344763
SumClampVectorTraits	55.541	4719.848	22.324734
SumClampVector128_AdvSimd	68.011	3854.423	18.231298
SumClampVector128Traits	67.863	3862.869	18.271251
SumClampVector256Traits	2887.323	90.791	0.429440

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

