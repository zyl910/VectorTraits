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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1254.420	208.976
SumNarrow_IfUnrolling4	1222.806	214.379	1.025854
SumNarrow_MinMax	1310.499	200.034	0.957208
SumNarrow_MinMaxUnrolling4	1269.854	206.436	0.987846
SumNarrow_BitMath	1135.160	230.931	1.105060
SumNarrow_BitMathUnrolling4	854.686	306.714	1.467696
SumNarrowVectorBase	12.389	21160.119	101.256113
SumNarrowVectorTraits	12.802	20477.038	97.987414

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1241.974	211.070
SumNarrow_MinMax	1184.050	221.396	1.048920
SumNarrow_BitMath	564.457	464.418	2.200300
SumNarrowVectorBase	26.878	9753.258	46.208555
SumNarrowVectorTraits	28.751	9117.869	43.198235

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1262.408	207.654
SumNarrow_MinMax	1274.251	205.724	0.990706
SumNarrow_BitMath	749.625	349.700	1.684052
SumNarrowVectorBase	88.824	2951.264	14.212422
SumNarrowVectorTraits	89.124	2941.336	14.164609

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	207.399	1263.960
SumNarrow_IfUnrolling4	213.325	1228.848	0.972221
SumNarrow_MinMax	192.287	1363.298	1.078593
SumNarrow_MinMaxUnrolling4	194.720	1346.263	1.065115
SumNarrow_BitMath	428.229	612.158	0.484318
SumNarrow_BitMathUnrolling4	545.909	480.198	0.379915
SumNarrowVectorBase	10.233	25617.831	20.267913
SumNarrowVectorTraits	10.572	24795.433	19.617261

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	181.252	1446.297
SumNarrow_MinMax	179.319	1461.884	1.010777
SumNarrow_BitMath	471.340	556.167	0.384545
SumNarrowVectorBase	20.955	12509.780	8.649521
SumNarrowVectorTraits	20.224	12962.030	8.962216

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	261.211	1003.570
SumNarrow_MinMax	180.118	1455.402	1.450224
SumNarrow_BitMath	358.466	731.295	0.728693
SumNarrowVectorBase	78.477	3340.377	3.328494
SumNarrowVectorTraits	79.293	3306.018	3.294256

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
SumNarrow_If	1324.471	197.924
SumNarrow_IfUnrolling4	1261.748	207.763	1.049712
SumNarrow_MinMax	1303.006	201.184	1.016473
SumNarrow_MinMaxUnrolling4	1242.903	210.913	1.065627
SumNarrow_BitMath	1131.382	231.703	1.170667
SumNarrow_BitMathUnrolling4	867.919	302.037	1.526030
SumNarrowVectorBase	13.399	19565.035	98.851482
SumNarrowVectorTraits	14.363	18251.731	92.216074

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1201.202	218.235
SumNarrow_MinMax	1268.017	206.735	0.947308
SumNarrow_BitMath	619.155	423.390	1.940067
SumNarrowVectorBase	27.452	9549.313	43.757088
SumNarrowVectorTraits	28.328	9253.891	42.403398

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1266.888	206.920
SumNarrow_MinMax	1303.967	201.036	0.971564
SumNarrow_BitMath	760.638	344.637	1.665559
SumNarrowVectorBase	96.353	2720.663	13.148408
SumNarrowVectorTraits	97.215	2696.543	13.031839

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	217.389	1205.876
SumNarrow_IfUnrolling4	233.356	1123.366	0.931576
SumNarrow_MinMax	204.317	1283.027	1.063979
SumNarrow_MinMaxUnrolling4	201.562	1300.561	1.078519
SumNarrow_BitMath	447.841	585.350	0.485415
SumNarrow_BitMathUnrolling4	552.018	474.883	0.393808
SumNarrowVectorBase	10.338	25358.182	21.028845
SumNarrowVectorTraits	10.507	24950.279	20.690583

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	187.762	1396.148
SumNarrow_MinMax	194.679	1346.542	0.964469
SumNarrow_BitMath	475.023	551.856	0.395270
SumNarrowVectorBase	23.488	11160.711	7.993930
SumNarrowVectorTraits	22.636	11581.014	8.294975

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	197.600	1326.642
SumNarrow_MinMax	186.660	1404.391	1.058606
SumNarrow_BitMath	382.489	685.363	0.516614
SumNarrowVectorBase	84.482	3102.954	2.338953
SumNarrowVectorTraits	85.935	3050.492	2.299408

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
SumNarrow_If	1341.120	195.466
SumNarrow_IfUnrolling4	1276.056	205.433	1.050988
SumNarrow_MinMax	1327.279	197.505	1.010429
SumNarrow_MinMaxUnrolling4	1242.096	211.050	1.079723
SumNarrow_BitMath	1133.697	231.229	1.182962
SumNarrow_BitMathUnrolling4	810.435	323.461	1.654815
SumNarrowVectorBase	13.751	19063.346	97.527446
SumNarrowVectorTraits	5.951	44050.630	225.361571
SumNarrowVector128Traits	7.988	32817.086	167.891128
SumNarrowVector256Traits	5.964	43953.618	224.865257

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1162.610	225.479
SumNarrow_MinMax	1220.323	214.815	0.952707
SumNarrow_BitMath	746.363	351.229	1.557701
SumNarrowVectorBase	26.906	9743.042	43.210456
SumNarrowVectorTraits	12.786	20503.088	90.931332
SumNarrowVector128Traits	16.351	16032.722	71.105229
SumNarrowVector256Traits	12.853	20395.395	90.453715

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1219.161	215.020
SumNarrow_MinMax	1286.187	203.815	0.947888
SumNarrow_BitMath	758.488	345.614	1.607356
SumNarrowVectorBase	92.438	2835.882	13.188919
SumNarrowVectorTraits	55.890	4690.391	21.813739
SumNarrowVector128Traits	130.675	2006.083	9.329747
SumNarrowVector256Traits	52.815	4963.393	23.083394

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	210.151	1247.409
SumNarrow_IfUnrolling4	225.814	1160.886	0.930638
SumNarrow_MinMax	196.200	1336.103	1.071102
SumNarrow_MinMaxUnrolling4	203.690	1286.975	1.031719
SumNarrow_BitMath	443.754	590.742	0.473575
SumNarrow_BitMathUnrolling4	550.163	476.484	0.381979
SumNarrowVectorBase	10.477	25019.795	20.057414
SumNarrowVectorTraits	7.905	33163.801	26.586152
SumNarrowVector128Traits	13.203	19854.583	15.916661
SumNarrowVector256Traits	7.775	33716.319	27.029085

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	192.054	1364.953
SumNarrow_MinMax	192.208	1363.853	0.999195
SumNarrow_BitMath	564.003	464.792	0.340519
SumNarrowVectorBase	21.898	11971.259	8.770457
SumNarrowVectorTraits	17.599	14895.009	10.912472
SumNarrowVector128Traits	28.259	9276.632	6.796302
SumNarrowVector256Traits	17.974	14585.027	10.685372

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	286.847	913.881
SumNarrow_MinMax	188.301	1392.157	1.523345
SumNarrow_BitMath	383.254	683.996	0.748451
SumNarrowVectorBase	86.429	3033.044	3.318859
SumNarrowVectorTraits	58.288	4497.385	4.921192
SumNarrowVector128Traits	122.704	2136.396	2.337717
SumNarrowVector256Traits	56.963	4602.012	5.035678

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
SumNarrow_If	1307.909	200.430
SumNarrow_IfUnrolling4	1254.168	209.018	1.042849
SumNarrow_MinMax	1255.990	208.715	1.041337
SumNarrow_MinMaxUnrolling4	1225.949	213.829	1.066854
SumNarrow_BitMath	1570.159	166.954	0.832979
SumNarrow_BitMathUnrolling4	1465.957	178.821	0.892188
SumNarrowVectorBase	13.133	19960.925	99.590551
SumNarrowVectorTraits	5.800	45196.128	225.495925
SumNarrowVector128Traits	8.651	30303.181	151.190913
SumNarrowVector256Traits	5.793	45254.059	225.784959

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1237.923	211.761
SumNarrow_MinMax	1223.025	214.341	1.012182
SumNarrow_BitMath	1324.049	197.987	0.934953
SumNarrowVectorBase	27.538	9519.188	44.952489
SumNarrowVectorTraits	12.961	20225.447	95.510690
SumNarrowVector128Traits	24.347	10767.055	50.845300
SumNarrowVector256Traits	13.211	19843.148	93.705359

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1263.924	207.405
SumNarrow_MinMax	1308.811	200.292	0.965704
SumNarrow_BitMath	1237.290	211.870	1.021527
SumNarrowVectorBase	88.880	2949.423	14.220611
SumNarrowVectorTraits	53.764	4875.851	23.508862
SumNarrowVector128Traits	88.684	2955.944	14.252051
SumNarrowVector256Traits	52.420	5000.887	24.111722

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	221.305	1184.537
SumNarrow_IfUnrolling4	236.145	1110.098	0.937158
SumNarrow_MinMax	222.371	1178.860	0.995207
SumNarrow_MinMaxUnrolling4	200.642	1306.523	1.102982
SumNarrow_BitMath	1329.720	197.142	0.166430
SumNarrow_BitMathUnrolling4	1198.070	218.805	0.184718
SumNarrowVectorBase	10.462	25056.656	21.153117
SumNarrowVectorTraits	6.347	41303.846	34.869182
SumNarrowVector128Traits	10.396	25215.196	21.286958
SumNarrowVector256Traits	6.450	40643.683	34.311864

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	195.658	1339.805
SumNarrow_MinMax	190.458	1376.390	1.027306
SumNarrow_BitMath	1173.665	223.355	0.166707
SumNarrowVectorBase	22.771	11511.978	8.592277
SumNarrowVectorTraits	16.040	16343.372	12.198319
SumNarrowVector128Traits	22.909	11443.000	8.540794
SumNarrowVector256Traits	15.665	16733.952	12.489839

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	287.416	912.071
SumNarrow_MinMax	294.006	891.629	0.977587
SumNarrow_BitMath	573.318	457.240	0.501320
SumNarrowVectorBase	76.003	3449.113	3.781626
SumNarrowVectorTraits	48.528	5401.914	5.922688
SumNarrowVector128Traits	84.084	3117.646	3.418203
SumNarrowVector256Traits	51.496	5090.608	5.581370

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1328.923	197.261
SumNarrow_IfUnrolling4	1257.522	208.461	1.056779
SumNarrow_MinMax	1312.452	199.736	1.012549
SumNarrow_MinMaxUnrolling4	1318.277	198.853	1.008075
SumNarrow_BitMath	1380.153	189.938	0.962881
SumNarrow_BitMathUnrolling4	1281.782	204.515	1.036778
SumNarrowVectorBase	13.421	19532.398	99.018283
SumNarrowVectorTraits	6.002	43674.654	221.405956
SumNarrowVector128Traits	8.067	32497.518	164.744156
SumNarrowVector256Traits	5.995	43728.433	221.678583

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1264.238	207.353
SumNarrow_MinMax	1240.987	211.238	1.018735
SumNarrow_BitMath	1315.537	199.268	0.961005
SumNarrowVectorBase	27.369	9577.993	46.191638
SumNarrowVectorTraits	13.654	19198.947	92.590460
SumNarrowVector128Traits	19.385	13522.821	65.216295
SumNarrowVector256Traits	14.459	18130.482	87.437590

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1264.934	207.239
SumNarrow_MinMax	1228.290	213.422	1.029834
SumNarrow_BitMath	1226.672	213.703	1.031192
SumNarrowVectorBase	89.915	2915.473	14.068150
SumNarrowVectorTraits	53.312	4917.149	23.726923
SumNarrowVector128Traits	90.351	2901.395	14.000219
SumNarrowVector256Traits	52.778	4966.963	23.967289

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	233.116	1124.520
SumNarrow_IfUnrolling4	229.496	1142.262	1.015778
SumNarrow_MinMax	194.906	1344.978	1.196047
SumNarrow_MinMaxUnrolling4	241.945	1083.484	0.963508
SumNarrow_BitMath	1338.756	195.812	0.174129
SumNarrow_BitMathUnrolling4	1209.096	216.810	0.192802
SumNarrowVectorBase	9.882	26527.170	23.589774
SumNarrowVectorTraits	6.444	40678.067	36.173720
SumNarrowVector128Traits	10.618	24688.707	21.954887
SumNarrowVector256Traits	6.007	43639.630	38.807344

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	189.620	1382.470
SumNarrow_MinMax	190.926	1373.016	0.993161
SumNarrow_BitMath	1187.163	220.816	0.159725
SumNarrowVectorBase	23.659	11080.158	8.014754
SumNarrowVectorTraits	15.374	17051.602	12.334156
SumNarrowVector128Traits	22.819	11488.181	8.309895
SumNarrowVector256Traits	15.561	16846.341	12.185681

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	298.281	878.848
SumNarrow_MinMax	290.546	902.245	1.026622
SumNarrow_BitMath	581.457	450.840	0.512989
SumNarrowVectorBase	71.832	3649.422	4.152505
SumNarrowVectorTraits	43.913	5969.621	6.792550
SumNarrowVector128Traits	83.563	3137.098	3.569556
SumNarrowVector256Traits	44.597	5878.031	6.688334

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1274.875	205.623
SumNarrow_IfUnrolling4	1229.345	213.239	1.037036
SumNarrow_MinMax	1177.461	222.635	1.082732
SumNarrow_MinMaxUnrolling4	1195.961	219.191	1.065984
SumNarrow_BitMath	979.847	267.536	1.301096
SumNarrow_BitMathUnrolling4	970.092	270.226	1.314180
SumNarrowVectorBase	13.612	19258.689	93.660065
SumNarrowVectorTraits	5.867	44677.389	217.277876
SumNarrowVector128Base	21.570	12153.308	59.104729
SumNarrowVector128Traits	7.878	33274.592	161.823080
SumNarrowVector256Traits	5.922	44268.684	215.290240

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1171.645	223.740
SumNarrow_MinMax	1242.721	210.944	0.942806
SumNarrow_BitMath	752.602	348.317	1.556793
SumNarrowVectorBase	24.935	10513.071	46.987873
SumNarrowVectorTraits	13.788	19012.815	84.977237
SumNarrowVector128Base	59.386	4414.235	19.729297
SumNarrowVector128Traits	17.074	15353.537	68.622200
SumNarrowVector256Traits	13.448	19492.541	87.121359

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1190.490	220.198
SumNarrow_MinMax	1226.011	213.819	0.971027
SumNarrow_BitMath	770.395	340.272	1.545299
SumNarrowVectorBase	59.951	4372.612	19.857603
SumNarrowVectorTraits	68.827	3808.744	17.296875
SumNarrowVector128Base	107.022	2449.433	11.123757
SumNarrowVector128Traits	105.066	2495.051	11.330927
SumNarrowVector256Traits	71.159	3683.941	16.730102

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	222.962	1175.733
SumNarrow_IfUnrolling4	231.129	1134.191	0.964667
SumNarrow_MinMax	344.063	761.908	0.648028
SumNarrow_MinMaxUnrolling4	279.742	937.092	0.797028
SumNarrow_BitMath	554.746	472.548	0.401918
SumNarrow_BitMathUnrolling4	515.174	508.845	0.432790
SumNarrowVectorBase	10.346	25337.769	21.550611
SumNarrowVectorTraits	8.748	29966.481	25.487483
SumNarrowVector128Base	30.808	8508.828	7.237040
SumNarrowVector128Traits	14.469	18118.123	15.410063
SumNarrowVector256Traits	8.261	31733.343	26.990258

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	211.380	1240.158
SumNarrow_MinMax	273.037	960.104	0.774179
SumNarrow_BitMath	462.504	566.793	0.457033
SumNarrowVectorBase	22.034	11897.237	9.593326
SumNarrowVectorTraits	17.800	14727.107	11.875188
SumNarrowVector128Base	57.003	4598.785	3.708226
SumNarrowVector128Traits	30.201	8680.100	6.999190
SumNarrowVector256Traits	17.870	14669.718	11.828913

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	199.751	1312.352
SumNarrow_MinMax	279.533	937.792	0.714589
SumNarrow_BitMath	472.490	554.814	0.422763
SumNarrowVectorBase	51.355	5104.550	3.889619
SumNarrowVectorTraits	57.899	4527.588	3.449979
SumNarrowVector128Base	96.928	2704.534	2.060830
SumNarrowVector128Traits	98.761	2654.322	2.022568
SumNarrowVector256Traits	61.050	4293.952	3.271951

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1184.973	221.224
SumNarrow_IfUnrolling4	1197.777	218.859	0.989310
SumNarrow_MinMax	1259.690	208.102	0.940686
SumNarrow_MinMaxUnrolling4	1203.314	217.852	0.984758
SumNarrow_BitMath	604.602	433.581	1.959924
SumNarrow_BitMathUnrolling4	599.411	437.336	1.976897
SumNarrowVectorBase	10.834	24197.090	109.378418
SumNarrowVectorTraits	5.539	47325.429	213.925752
SumNarrowVector128Base	18.331	14300.947	64.644758
SumNarrowVector128Traits	8.091	32398.086	146.449488
SumNarrowVector256Traits	5.546	47270.777	213.678707
SumNarrowVector512Base	10.288	25480.586	115.180224
SumNarrowVector512Traits	5.683	46125.775	208.502936
SumNarrowVector512_Convert	5.826	44992.635	203.380789

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1125.757	232.860
SumNarrow_MinMax	1173.352	223.415	0.959436
SumNarrow_BitMath	475.659	551.117	2.366730
SumNarrowVectorBase	21.737	12059.829	51.789985
SumNarrowVectorTraits	13.514	19398.087	83.303557
SumNarrowVector128Base	35.562	7371.361	31.655730
SumNarrowVector128Traits	18.720	14003.514	60.136987
SumNarrowVector256Traits	13.554	19341.192	83.059226
SumNarrowVector512Base	18.922	13854.230	59.495899
SumNarrowVector512Traits	13.175	19896.890	85.445629
SumNarrowVector512_Convert	13.732	19090.544	81.982837

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1151.817	227.592
SumNarrow_MinMax	1131.192	231.741	1.018233
SumNarrow_BitMath	541.894	483.755	2.125540
SumNarrowVectorBase	44.300	5917.536	26.000672
SumNarrowVectorTraits	27.854	9411.507	41.352599
SumNarrowVector128Base	75.431	3475.261	15.269719
SumNarrowVector128Traits	33.015	7940.087	34.887424
SumNarrowVector256Traits	27.763	9442.143	41.487210
SumNarrowVector512Base	36.009	7279.925	31.986780
SumNarrowVector512Traits	26.319	9960.331	43.764038
SumNarrowVector512_Clamp	36.330	7215.541	31.703887
SumNarrowVector512_Convert	26.157	10021.894	44.034538

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	188.983	1387.128
SumNarrow_IfUnrolling4	190.817	1373.796	0.990388
SumNarrow_MinMax	176.190	1487.848	1.072610
SumNarrow_MinMaxUnrolling4	163.576	1602.582	1.155323
SumNarrow_BitMath	364.164	719.852	0.518951
SumNarrow_BitMathUnrolling4	355.930	736.505	0.530956
SumNarrowVectorBase	8.472	30941.796	22.306367
SumNarrowVectorTraits	5.754	45560.104	32.844906
SumNarrowVector128Base	13.544	19354.326	13.952800
SumNarrowVector128Traits	8.356	31370.112	22.615146
SumNarrowVector256Traits	6.024	43515.935	31.371237
SumNarrowVector512Base	7.635	34333.004	24.751136
SumNarrowVector512Traits	5.777	45374.589	32.711166
SumNarrowVector512_Convert	5.770	45431.950	32.752518
SumNarrowVector512_Pack	7.556	34692.637	25.010400

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	173.942	1507.078
SumNarrow_MinMax	189.479	1383.498	0.918001
SumNarrow_BitMath	300.924	871.130	0.578026
SumNarrowVectorBase	16.387	15997.508	10.614920
SumNarrowVectorTraits	13.266	19760.603	13.111868
SumNarrowVector128Base	27.625	9489.508	6.296629
SumNarrowVector128Traits	18.616	14081.477	9.343565
SumNarrowVector256Traits	13.357	19625.999	13.022554
SumNarrowVector512Base	12.986	20187.199	13.394931
SumNarrowVector512Traits	12.333	21255.152	14.103556
SumNarrowVector512_Convert	12.490	20989.131	13.927041
SumNarrowVector512_Pack	12.916	20295.873	13.467039

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	139.871	1874.180
SumNarrow_MinMax	292.638	895.795	0.477966
SumNarrow_BitMath	311.150	842.500	0.449530
SumNarrowVectorBase	34.074	7693.314	4.104895
SumNarrowVectorTraits	27.505	9530.757	5.085294
SumNarrowVector128Base	51.725	5068.074	2.704155
SumNarrowVector128Traits	29.058	9021.456	4.813548
SumNarrowVector256Traits	27.757	9444.117	5.039066
SumNarrowVector512Base	26.551	9873.078	5.267945
SumNarrowVector512Traits	26.136	10029.859	5.351598
SumNarrowVector512_Clamp	26.726	9808.525	5.233501
SumNarrowVector512_Convert	26.166	10018.529	5.345553

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1011.205	259.239
SumNarrow_IfUnrolling4	1010.093	259.525	1.001101
SumNarrow_MinMax	1053.740	248.775	0.959634
SumNarrow_MinMaxUnrolling4	1051.862	249.219	0.961347
SumNarrow_BitMath	488.822	536.277	2.068658
SumNarrow_BitMathUnrolling4	486.843	538.456	2.077063
SumNarrowVectorBase	13.865	18906.949	72.932424
SumNarrowVectorTraits	9.649	27169.213	104.803614
SumNarrowVector128Traits	9.649	27168.944	104.802579
SumNarrowVector256Traits	1989.750	131.747	0.508207

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1013.498	258.653
SumNarrow_MinMax	1002.704	261.437	1.010764
SumNarrow_BitMath	342.372	765.670	2.960224
SumNarrowVectorBase	27.521	9525.207	36.826234
SumNarrowVectorTraits	19.270	13603.507	52.593706
SumNarrowVector128Traits	19.265	13607.521	52.609228
SumNarrowVector256Traits	2113.485	124.034	0.479539

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1009.477	259.683
SumNarrow_MinMax	1017.679	257.590	0.991940
SumNarrow_BitMath	347.617	754.117	2.903991
SumNarrowVectorBase	62.682	4182.131	16.104750
SumNarrowVectorTraits	38.587	6793.625	26.161218
SumNarrowVector128Traits	38.589	6793.243	26.159745
SumNarrowVector256Traits	3725.489	70.365	0.270965

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	175.640	1492.504
SumNarrow_IfUnrolling4	178.338	1469.925	0.984872
SumNarrow_MinMax	164.119	1597.277	1.070199
SumNarrow_MinMaxUnrolling4	178.822	1465.953	0.982210
SumNarrow_BitMath	266.896	982.194	0.658084
SumNarrow_BitMathUnrolling4	270.066	970.667	0.650361
SumNarrowVectorBase	10.866	24125.030	16.164126
SumNarrowVectorTraits	9.645	27179.027	18.210350
SumNarrowVector128Traits	9.645	27179.284	18.210522
SumNarrowVector256Traits	675.345	388.163	0.260075

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	167.992	1560.454
SumNarrow_MinMax	167.974	1560.625	1.000110
SumNarrow_BitMath	238.241	1100.331	0.705135
SumNarrowVectorBase	21.704	12078.072	7.740103
SumNarrowVectorTraits	19.271	13603.252	8.717499
SumNarrowVector128Traits	19.268	13605.140	8.718708
SumNarrowVector256Traits	951.268	275.573	0.176598

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	154.209	1699.931
SumNarrow_MinMax	154.181	1700.235	1.000178
SumNarrow_BitMath	226.605	1156.830	0.680516
SumNarrowVectorBase	48.189	5439.933	3.200090
SumNarrowVectorTraits	38.535	6802.666	4.001730
SumNarrowVector128Traits	38.538	6802.282	4.001504
SumNarrowVector256Traits	1325.936	197.705	0.116302

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	834.884	313.988
SumNarrow_IfUnrolling4	807.620	324.588	1.033759
SumNarrow_MinMax	842.136	311.285	0.991389
SumNarrow_MinMaxUnrolling4	814.455	321.865	1.025084
SumNarrow_BitMath	375.592	697.949	2.222851
SumNarrow_BitMathUnrolling4	365.990	716.261	2.281170
SumNarrowVectorBase	12.796	20485.803	65.243829
SumNarrowVectorTraits	9.642	27188.567	86.591000
SumNarrowVector128Base	12.973	20206.487	64.354253
SumNarrowVector128Traits	9.645	27179.389	86.561772
SumNarrowVector256Traits	2578.342	101.672	0.323807

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	840.780	311.787
SumNarrow_MinMax	871.588	300.766	0.964654
SumNarrow_BitMath	268.639	975.824	3.129783
SumNarrowVectorBase	25.359	10337.378	33.155308
SumNarrowVectorTraits	19.262	13609.145	43.648920
SumNarrowVector128Base	25.708	10197.022	32.705142
SumNarrowVector128Traits	19.266	13606.380	43.640051
SumNarrowVector256Traits	1830.508	143.208	0.459315

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	878.596	298.367
SumNarrow_MinMax	839.461	312.277	1.046619
SumNarrow_BitMath	278.748	940.435	3.151941
SumNarrowVectorBase	57.863	4530.439	15.184114
SumNarrowVectorTraits	38.538	6802.217	22.798155
SumNarrowVector128Base	77.775	3370.535	11.296608
SumNarrowVector128Traits	38.542	6801.454	22.795597
SumNarrowVector256Traits	2145.731	122.170	0.409462

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	162.255	1615.631
SumNarrow_IfUnrolling4	128.951	2032.898	1.258269
SumNarrow_MinMax	237.053	1105.847	0.684468
SumNarrow_MinMaxUnrolling4	178.698	1466.964	0.907982
SumNarrow_BitMath	208.661	1256.318	0.777602
SumNarrow_BitMathUnrolling4	206.437	1269.848	0.785977
SumNarrowVectorBase	9.675	27095.117	16.770612
SumNarrowVectorTraits	9.640	27193.560	16.831543
SumNarrowVector128Base	9.683	27071.325	16.755886
SumNarrowVector128Traits	9.643	27184.396	16.825871
SumNarrowVector256Traits	459.010	571.107	0.353489

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	154.211	1699.903
SumNarrow_MinMax	231.249	1133.600	0.666861
SumNarrow_BitMath	176.189	1487.859	0.875261
SumNarrowVectorBase	19.327	13563.557	7.979016
SumNarrowVectorTraits	19.260	13611.053	8.006956
SumNarrowVector128Base	19.319	13569.482	7.982501
SumNarrowVector128Traits	19.284	13593.953	7.996897
SumNarrowVector256Traits	488.657	536.458	0.315582

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	154.187	1700.165
SumNarrow_MinMax	231.242	1133.635	0.666780
SumNarrow_BitMath	161.815	1620.023	0.952863
SumNarrowVectorBase	46.967	5581.440	3.282882
SumNarrowVectorTraits	38.520	6805.388	4.002782
SumNarrowVector128Base	43.401	6039.991	3.552592
SumNarrowVector128Traits	38.523	6804.834	4.002456
SumNarrowVector256Traits	741.162	353.693	0.208035

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	820.294	319.573
SumNarrow_IfUnrolling4	817.793	320.551	1.003059
SumNarrow_MinMax	835.791	313.648	0.981459
SumNarrow_MinMaxUnrolling4	807.124	324.788	1.016317
SumNarrow_BitMath	320.696	817.423	2.557859
SumNarrow_BitMathUnrolling4	317.539	825.550	2.583289
SumNarrowVectorBase	12.971	20210.073	63.240842
SumNarrowVectorTraits	9.641	27190.966	85.085271
SumNarrowVector128Base	12.960	20226.822	63.293252
SumNarrowVector128Traits	9.641	27191.345	85.086457
SumNarrowVector256Traits	12.958	20230.254	63.303992
SumNarrowVector512Base	76.749	3415.605	10.688023
SumNarrowVector512Traits	81.742	3206.987	10.035222
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	817.401	320.704
SumNarrow_MinMax	842.331	311.212	0.970403
SumNarrow_BitMath	240.796	1088.657	3.394585
SumNarrowVectorBase	25.748	10181.084	31.746035
SumNarrowVectorTraits	19.260	13610.696	42.440042
SumNarrowVector128Base	25.786	10166.101	31.699317
SumNarrowVector128Traits	19.261	13609.783	42.437194
SumNarrowVector256Traits	25.737	10185.664	31.760316
SumNarrowVector512Base	163.384	1604.462	5.002934
SumNarrowVector512Traits	162.646	1611.747	5.025650
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	847.768	309.217
SumNarrow_MinMax	832.245	314.984	1.018652
SumNarrow_BitMath	264.178	992.302	3.209083
SumNarrowVectorBase	77.838	3367.829	10.891485
SumNarrowVectorTraits	38.537	6802.478	21.999062
SumNarrowVector128Base	77.896	3365.327	10.883391
SumNarrowVector128Traits	38.523	6804.882	22.006838
SumNarrowVector256Traits	77.669	3375.141	10.915130
SumNarrowVector512Base	346.518	756.510	2.446536
SumNarrowVector512Traits	345.822	758.031	2.451454
SumNarrowVector512_Clamp	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	154.375	1698.095
SumNarrow_IfUnrolling4	108.094	2425.154	1.428162
SumNarrow_MinMax	154.517	1696.542	0.999085
SumNarrow_MinMaxUnrolling4	98.462	2662.381	1.567863
SumNarrow_BitMath	193.844	1352.346	0.796390
SumNarrow_BitMathUnrolling4	199.494	1314.044	0.773834
SumNarrowVectorBase	9.665	27122.730	15.972445
SumNarrowVectorTraits	9.638	27199.244	16.017504
SumNarrowVector128Base	9.667	27117.966	15.969639
SumNarrowVector128Traits	9.636	27205.375	16.021114
SumNarrowVector256Traits	9.256	28322.047	16.678717
SumNarrowVector512Base	43.623	6009.319	3.538859
SumNarrowVector512Traits	26.608	9852.199	5.801913
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Pack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	154.399	1697.840
SumNarrow_MinMax	154.412	1697.695	0.999915
SumNarrow_BitMath	166.578	1573.698	0.926883
SumNarrowVectorBase	19.300	13582.691	7.999985
SumNarrowVectorTraits	19.282	13594.922	8.007188
SumNarrowVector128Base	19.306	13578.494	7.997513
SumNarrowVector128Traits	19.261	13610.400	8.016305
SumNarrowVector256Traits	18.447	14210.792	8.369926
SumNarrowVector512Base	86.938	3015.294	1.775959
SumNarrowVector512Traits	53.034	4942.898	2.911287
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Pack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	86.747	3021.943
SumNarrow_MinMax	86.747	3021.954	1.000004
SumNarrow_BitMath	166.623	1573.272	0.520616
SumNarrowVectorBase	49.890	5254.481	1.738775
SumNarrowVectorTraits	38.525	6804.533	2.251708
SumNarrowVector128Base	49.891	5254.300	1.738716
SumNarrowVector128Traits	38.524	6804.696	2.251762
SumNarrowVector256Traits	49.878	5255.719	1.739185
SumNarrowVector512Base	173.946	1507.046	0.498701
SumNarrowVector512Traits	106.037	2472.189	0.818079
SumNarrowVector512_Clamp	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1666.844	157.270
SumNarrow_IfUnrolling4	1655.775	158.321	1.006685
SumNarrow_MinMax	1629.140	160.909	1.023144
SumNarrow_MinMaxUnrolling4	1610.796	162.742	1.034795
SumNarrow_BitMath	1244.316	210.673	1.339567
SumNarrow_BitMathUnrolling4	1258.258	208.339	1.324723
SumNarrowVectorBase	42.972	6100.275	38.788628
SumNarrowVectorTraits	42.959	6102.238	38.801110
SumNarrowVector128Traits	2066.512	126.853	0.806598
SumNarrowVector256Traits	2959.735	88.570	0.563173

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1599.865	163.854
SumNarrow_MinMax	1691.518	154.976	0.945816
SumNarrow_BitMath	1047.116	250.349	1.527878
SumNarrowVectorBase	86.007	3047.923	18.601478
SumNarrowVectorTraits	83.873	3125.498	19.074916
SumNarrowVector128Traits	3660.941	71.606	0.437009
SumNarrowVector256Traits	5383.247	48.696	0.297193

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1620.295	161.788
SumNarrow_MinMax	1629.881	160.836	0.994119
SumNarrow_BitMath	1054.823	248.519	1.536083
SumNarrowVectorBase	359.777	728.629	4.503612
SumNarrowVectorTraits	360.284	727.603	4.497268
SumNarrowVector128Traits	5034.582	52.069	0.321833
SumNarrowVector256Traits	6493.532	40.370	0.249525

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	496.709	527.761
SumNarrow_IfUnrolling4	517.131	506.919	0.960509
SumNarrow_MinMax	457.425	573.087	1.085882
SumNarrow_MinMaxUnrolling4	477.916	548.515	1.039325
SumNarrow_BitMath	799.417	327.919	0.621340
SumNarrow_BitMathUnrolling4	815.020	321.641	0.609444
SumNarrowVectorBase	31.353	8361.120	15.842616
SumNarrowVectorTraits	31.554	8307.680	15.741359
SumNarrowVector128Traits	1310.554	200.025	0.379007
SumNarrowVector256Traits	1783.839	146.955	0.278450

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	487.664	537.550
SumNarrow_MinMax	485.455	539.997	1.004552
SumNarrow_BitMath	714.911	366.681	0.682133
SumNarrowVectorBase	63.942	4099.703	7.626644
SumNarrowVectorTraits	65.140	4024.310	7.486390
SumNarrowVector128Traits	2245.784	116.727	0.217147
SumNarrowVector256Traits	3214.854	81.541	0.151691

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.958	619.788
SumNarrow_MinMax	423.158	619.494	0.999525
SumNarrow_BitMath	673.434	389.265	0.628061
SumNarrowVectorBase	213.173	1229.723	1.984103
SumNarrowVectorTraits	213.314	1228.911	1.982793
SumNarrowVector128Traits	2793.213	93.850	0.151423
SumNarrowVector256Traits	4076.857	64.301	0.103746

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1665.639	157.383
SumNarrow_IfUnrolling4	1635.287	160.305	1.018560
SumNarrow_MinMax	2417.756	108.425	0.688919
SumNarrow_MinMaxUnrolling4	1783.155	147.011	0.934096
SumNarrow_BitMath	1591.093	164.757	1.046852
SumNarrow_BitMathUnrolling4	1604.541	163.376	1.038078
SumNarrowVectorBase	41.557	6308.118	40.081196
SumNarrowVectorTraits	19.496	13445.824	85.433517
SumNarrowVector128Traits	20.394	12853.868	81.672283
SumNarrowVector256Traits	4444.305	58.984	0.374780

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1587.208	165.160
SumNarrow_MinMax	1619.332	161.884	0.980162
SumNarrow_BitMath	1348.146	194.448	1.177326
SumNarrowVectorBase	80.576	3253.378	19.698286
SumNarrowVectorTraits	42.538	6162.533	37.312401
SumNarrowVector128Traits	42.448	6175.605	37.391547
SumNarrowVector256Traits	5004.136	52.385	0.317179

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1621.617	161.656
SumNarrow_MinMax	1591.714	164.693	1.018787
SumNarrow_BitMath	1367.622	191.679	1.185720
SumNarrowVectorBase	230.078	1139.372	7.048132
SumNarrowVectorTraits	79.265	3307.205	20.458305
SumNarrowVector128Traits	79.110	3313.665	20.498267
SumNarrowVector256Traits	8300.241	31.583	0.195370

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	492.920	531.818
SumNarrow_IfUnrolling4	516.523	507.516	0.954303
SumNarrow_MinMax	454.616	576.628	1.084257
SumNarrow_MinMaxUnrolling4	483.092	542.638	1.020344
SumNarrow_BitMath	1014.804	258.320	0.485729
SumNarrow_BitMathUnrolling4	1053.942	248.727	0.467692
SumNarrowVectorBase	32.993	7945.486	14.940222
SumNarrowVectorTraits	18.488	14179.297	26.661914
SumNarrowVector128Traits	19.998	13108.836	24.649082
SumNarrowVector256Traits	1856.245	141.223	0.265547

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	485.932	539.467
SumNarrow_MinMax	480.704	545.333	1.010875
SumNarrow_BitMath	918.878	285.287	0.528832
SumNarrowVectorBase	66.140	3963.463	7.347003
SumNarrowVectorTraits	37.572	6977.151	12.933424
SumNarrowVector128Traits	40.706	6439.929	11.937586
SumNarrowVector256Traits	2453.536	106.843	0.198054

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.638	620.256
SumNarrow_MinMax	422.732	620.119	0.999779
SumNarrow_BitMath	885.071	296.184	0.477519
SumNarrowVectorBase	141.804	1848.632	2.980433
SumNarrowVectorTraits	74.334	3526.548	5.685631
SumNarrowVector128Traits	80.216	3267.989	5.268772
SumNarrowVector256Traits	3577.554	73.275	0.118136

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1443.448	181.610
SumNarrow_IfUnrolling4	1408.926	186.059	1.024502
SumNarrow_MinMax	1422.841	184.240	1.014484
SumNarrow_MinMaxUnrolling4	1407.837	186.203	1.025295
SumNarrow_BitMath	1284.425	204.094	1.123809
SumNarrow_BitMathUnrolling4	1282.776	204.357	1.125253
SumNarrowVectorBase	36.400	7201.735	39.655046
SumNarrowVectorTraits	16.897	15514.261	85.426460
SumNarrowVector128Base	30.027	8730.227	48.071409
SumNarrowVector128Traits	16.838	15568.535	85.725306
SumNarrowVector256Traits	4292.519	61.070	0.336271

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1377.964	190.240
SumNarrow_MinMax	1341.930	195.349	1.026853
SumNarrow_BitMath	1012.957	258.791	1.360339
SumNarrowVectorBase	74.217	3532.128	18.566684
SumNarrowVectorTraits	33.121	7914.641	41.603429
SumNarrowVector128Base	62.291	4208.391	22.121471
SumNarrowVector128Traits	32.698	8017.058	42.141785
SumNarrowVector256Traits	4557.045	57.525	0.302381

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1287.102	203.670
SumNarrow_MinMax	1347.813	194.496	0.954956
SumNarrow_BitMath	1067.425	245.585	1.205801
SumNarrowVectorBase	212.800	1231.877	6.048399
SumNarrowVectorTraits	64.115	4088.677	20.075015
SumNarrowVector128Base	180.691	1450.789	7.123234
SumNarrowVector128Traits	63.923	4100.966	20.135352
SumNarrowVector256Traits	4141.542	63.296	0.310778

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	431.118	608.056
SumNarrow_IfUnrolling4	373.650	701.576	1.153802
SumNarrow_MinMax	430.631	608.744	1.001131
SumNarrow_MinMaxUnrolling4	378.719	692.186	1.138358
SumNarrow_BitMath	787.295	332.968	0.547594
SumNarrow_BitMathUnrolling4	793.001	330.572	0.543654
SumNarrowVectorBase	29.608	8853.731	14.560709
SumNarrowVectorTraits	18.773	13964.213	22.965328
SumNarrowVector128Base	24.367	10758.370	17.693049
SumNarrowVector128Traits	18.692	14024.172	23.063935
SumNarrowVector256Traits	1380.010	189.958	0.312402

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	422.218	620.874
SumNarrow_MinMax	422.185	620.923	1.000078
SumNarrow_BitMath	648.082	404.492	0.651488
SumNarrowVectorBase	60.169	4356.804	7.017210
SumNarrowVectorTraits	39.605	6619.009	10.660793
SumNarrowVector128Base	49.964	5246.643	8.450415
SumNarrowVector128Traits	39.938	6563.849	10.571950
SumNarrowVector256Traits	1616.973	162.120	0.261116

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	316.733	827.649
SumNarrow_MinMax	320.368	818.259	0.988655
SumNarrow_BitMath	629.346	416.534	0.503274
SumNarrowVectorBase	145.192	1805.499	2.181480
SumNarrowVectorTraits	75.324	3480.212	4.204938
SumNarrowVector128Base	143.329	1828.969	2.209837
SumNarrowVector128Traits	74.739	3507.478	4.237881
SumNarrowVector256Traits	1759.148	149.018	0.180049

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1356.398	193.265
SumNarrow_IfUnrolling4	1354.034	193.602	1.001746
SumNarrow_MinMax	1379.902	189.973	0.982967
SumNarrow_MinMaxUnrolling4	1342.775	195.226	1.010146
SumNarrow_BitMath	931.132	281.533	1.456719
SumNarrow_BitMathUnrolling4	923.899	283.737	1.468123
SumNarrowVectorBase	31.729	8261.974	42.749500
SumNarrowVectorTraits	19.170	13674.647	70.756007
SumNarrowVector128Base	32.118	8161.972	42.232063
SumNarrowVector128Traits	19.378	13528.084	69.997654
SumNarrowVector256Traits	30.884	8487.915	43.918572
SumNarrowVector512Base	183.551	1428.184	7.389780
SumNarrowVector512Traits	196.326	1335.247	6.908900
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1226.075	213.807
SumNarrow_MinMax	1345.148	194.881	0.911480
SumNarrow_BitMath	711.251	368.568	1.723829
SumNarrowVectorBase	64.972	4034.752	18.870956
SumNarrowVectorTraits	38.651	6782.358	31.721797
SumNarrowVector128Base	65.257	4017.123	18.788505
SumNarrowVector128Traits	38.306	6843.500	32.007764
SumNarrowVector256Traits	64.174	4084.919	19.105593
SumNarrowVector512Base	397.443	659.577	3.084909
SumNarrowVector512Traits	397.005	660.305	3.088314
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1378.523	190.163
SumNarrow_MinMax	1299.073	201.793	1.061159
SumNarrow_BitMath	779.692	336.215	1.768035
SumNarrowVectorBase	197.608	1326.584	6.976040
SumNarrowVectorTraits	76.890	3409.341	17.928527
SumNarrowVector128Base	197.312	1328.573	6.986498
SumNarrowVector128Traits	76.719	3416.920	17.968383
SumNarrowVector256Traits	195.867	1338.381	7.038073
SumNarrowVector512Base	860.314	304.707	1.602348
SumNarrowVector512Traits	861.096	304.431	1.600894
SumNarrowVector512_Clamp	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	314.910	832.441
SumNarrow_IfUnrolling4	313.509	836.161	1.004469
SumNarrow_MinMax	293.359	893.594	1.073463
SumNarrow_MinMaxUnrolling4	286.203	915.938	1.100304
SumNarrow_BitMath	583.741	449.076	0.539469
SumNarrow_BitMathUnrolling4	588.142	445.716	0.535432
SumNarrowVectorBase	22.160	11829.808	14.210995
SumNarrowVectorTraits	15.856	16532.648	19.860456
SumNarrowVector128Base	22.164	11827.230	14.207898
SumNarrowVector128Traits	15.874	16514.181	19.838271
SumNarrowVector256Traits	21.286	12315.255	14.794155
SumNarrowVector512Base	81.068	3233.614	3.884498
SumNarrowVector512Traits	61.338	4273.747	5.133997
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Pack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	264.887	989.646
SumNarrow_MinMax	316.801	827.472	0.836129
SumNarrow_BitMath	430.424	609.037	0.615409
SumNarrowVectorBase	44.454	5896.924	5.958620
SumNarrowVectorTraits	32.795	7993.300	8.076930
SumNarrowVector128Base	45.402	5773.791	5.834199
SumNarrowVector128Traits	32.731	8008.986	8.092780
SumNarrowVector256Traits	43.969	5962.081	6.024459
SumNarrowVector512Base	162.728	1610.932	1.627786
SumNarrowVector512Traits	122.344	2142.688	2.165106
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Pack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	263.431	995.113
SumNarrow_MinMax	263.542	994.695	0.999580
SumNarrow_BitMath	433.545	604.653	0.607622
SumNarrowVectorBase	120.842	2169.309	2.179963
SumNarrowVectorTraits	63.926	4100.727	4.120866
SumNarrowVector128Base	123.518	2122.309	2.132732
SumNarrowVector128Traits	64.416	4069.548	4.089533
SumNarrowVector256Traits	116.827	2243.867	2.254887
SumNarrowVector512Base	365.648	716.931	0.720451
SumNarrowVector512Traits	287.967	910.327	0.914797
SumNarrowVector512_Clamp	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	12777.083	20.517
SumNarrow_IfUnrolling4	13832.292	18.952	0.923714
SumNarrow_MinMax	18131.250	14.458	0.704700
SumNarrow_MinMaxUnrolling4	17864.583	14.674	0.715219
SumNarrow_BitMath	30447.917	8.610	0.419637
SumNarrow_BitMathUnrolling4	29904.167	8.766	0.427268
SumNarrowVectorBase	51700.000	5.070	0.247139
SumNarrowVectorTraits	1442.708	181.703	8.856318
SumNarrowVector128Base	67650.000	3.875	0.188870
SumNarrowVector128Traits	1232.943	212.617	10.363080
SumNarrowVector256Traits	84083.333	3.118	0.151957
SumNarrowVector512Base	82875.000	3.163	0.154173
SumNarrowVector512Traits	87983.333	2.979	0.145222
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	13719.792	19.107
SumNarrow_MinMax	18293.750	14.330	0.749972
SumNarrow_BitMath	26339.583	9.952	0.520881
SumNarrowVectorBase	59575.000	4.400	0.230294
SumNarrowVectorTraits	2938.542	89.209	4.668912
SumNarrowVector128Base	96475.000	2.717	0.142211
SumNarrowVector128Traits	2388.281	109.763	5.744630
SumNarrowVector256Traits	118950.000	2.204	0.115341
SumNarrowVector512Base	121583.333	2.156	0.112843
SumNarrowVector512Traits	129250.000	2.028	0.106149
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	12405.208	21.132
SumNarrow_MinMax	16960.417	15.456	0.731421
SumNarrow_BitMath	25941.667	10.105	0.478196
SumNarrowVectorBase	76741.667	3.416	0.161649
SumNarrowVectorTraits	146916.667	1.784	0.084437
SumNarrowVector128Base	148116.667	1.770	0.083753
SumNarrowVector128Traits	142741.667	1.836	0.086907
SumNarrowVector256Traits	189833.334	1.381	0.065348
SumNarrowVector512Base	191566.667	1.368	0.064757
SumNarrowVector512Traits	208250.000	1.259	0.059569
SumNarrowVector512_Clamp	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	11159.375	23.491
SumNarrow_IfUnrolling4	11494.792	22.805	0.970820
SumNarrow_MinMax	12832.292	20.428	0.869632
SumNarrow_MinMaxUnrolling4	12501.042	20.970	0.892676
SumNarrow_BitMath	18172.917	14.425	0.614066
SumNarrow_BitMathUnrolling4	17635.417	14.865	0.632782
SumNarrowVectorBase	29260.417	8.959	0.381381
SumNarrowVectorTraits	2027.995	129.263	5.502665
SumNarrowVector128Base	26920.833	9.738	0.414526
SumNarrowVector128Traits	1758.333	149.087	6.346564
SumNarrowVector256Traits	34283.333	7.646	0.325504
SumNarrowVector512Base	34195.833	7.666	0.326337
SumNarrowVector512Traits	37083.333	7.069	0.300927
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Pack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	12121.875	21.626
SumNarrow_MinMax	14193.750	18.469	0.854029
SumNarrow_BitMath	16518.750	15.869	0.733825
SumNarrowVectorBase	36616.667	7.159	0.331048
SumNarrowVectorTraits	4047.135	64.773	2.995174
SumNarrowVector128Base	58275.000	4.498	0.208012
SumNarrowVector128Traits	3573.177	73.364	3.392464
SumNarrowVector256Traits	73375.000	3.573	0.165204
SumNarrowVector512Base	76675.000	3.419	0.158094
SumNarrowVector512Traits	76791.667	3.414	0.157854
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Pack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	10204.167	25.690
SumNarrow_MinMax	11981.250	21.880	0.851678
SumNarrow_BitMath	15370.833	17.055	0.663866
SumNarrowVectorBase	45379.167	5.777	0.224865
SumNarrowVectorTraits	76966.667	3.406	0.132579
SumNarrowVector128Base	91450.000	2.867	0.111582
SumNarrowVector128Traits	71825.000	3.650	0.142070
SumNarrowVector256Traits	113775.000	2.304	0.089687
SumNarrowVector512Base	122233.333	2.145	0.083481
SumNarrowVector512Traits	124333.333	2.108	0.082071
SumNarrowVector512_Clamp	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

```

