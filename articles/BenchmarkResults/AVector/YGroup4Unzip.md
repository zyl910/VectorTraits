# Benchmark - YGroup4Unzip
([← Back](README.md))

See [Group](YGroup4Unzip_Group.md)

- `YGroup4Unzip[/_Bit128]`: De-Interleave 4-element groups into 4 vectors. It converts the 4-element groups AoS to SoA. It can also deinterleave packed RGBA pixel data into R,G,B,A planar data (将4-元素组解交织为4个向量. 它能将4元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGBA像素数据, 解交织为 R,G,B,A 平面数据).
  Mnemonic: `x[i] =: element_ref(4*i, data0, data1, data2, data3)`, `y[i] =: element_ref(4*i+1, data0, data1, data2, data3)`, `z[i] =: element_ref(4*i+2, data0, data1, data2, data3)`, `w[i] =: element_ref(4*i+3, data0, data1, data2, data3)`.
- `YGroup4Zip[/_Bit128]`: Interleave 4 vectors into 4-element groups. It converts the 4-element groups SoA to AoS. It can also interleave R,G,B,A planar data into packed RGBA pixel data (将4个向量交织为4-元素组. 它能将4元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B,A 平面数据, 交织为 已打包的RGBA像素数据).
  Mnemonic: `element_ref(i, data0, data1, data2, data3) := (0==(i&3))?( x[i2] ):( (1==(i&3))?( y[i2] ):( (2==(i&3))?( z[i2] ):( w[i2] ) ) )`, `i2 := i/4`.

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	1373.110	190.913
SumBase_Unzip	199.576	1313.504	6.880132
SumBase	200.289	1308.828	6.855639
SumTraits	199.832	1311.822	6.871320

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	5407.139	48.481
SumBase	5549.405	47.238	0.974364
SumTraits	5847.412	44.831	0.924706
SumTraits_Int128	4304.007	60.907	1.256303

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	1511.062	173.483
SumBase_Unzip	305.389	858.395	4.947998
SumBase	305.963	856.782	4.938703
SumTraits	305.004	859.478	4.954239

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
SumBase_Basic	1860.203	140.922
SumBase_Unzip	687.519	381.290	2.705677
SumBase	692.271	378.672	2.687101
SumTraits	689.121	380.403	2.699383

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	2678.466	97.871
SumBase	2600.014	100.824	1.030174
SumTraits	2422.759	108.201	1.105544

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	1043.759	251.154
SumBase_Zip	50.782	5162.172	20.553838
SumBase	51.006	5139.426	20.463273
SumTraits	52.139	5027.778	20.018733

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	5246.663	49.964
SumBase	5291.125	49.544	0.991597
SumTraits	5596.340	46.842	0.937517
SumTraits_Int128	3979.765	65.869	1.318335

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	1301.028	201.490
SumBase_Zip	105.505	2484.660	12.331439
SumBase	99.820	2626.164	13.033723
SumTraits	100.434	2610.113	12.954061

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
SumBase_Basic	1817.821	144.208
SumBase_Zip	4363.660	60.074	0.416582
SumBase	1807.688	145.016	1.005606
SumTraits	1778.714	147.378	1.021986

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	2756.727	95.092
SumBase	2675.883	97.965	1.030212
SumTraits	2708.778	96.776	1.017701

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	716.076	366.084
SumBase_Unzip	201.509	1300.906	3.553572
SumBase	203.372	1288.986	3.521009
SumTraits	201.481	1301.084	3.554058

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	4593.219	57.072
SumBase	4672.089	56.109	0.983119
SumTraits	4930.934	53.163	0.931511
SumTraits_Int128	3642.688	71.964	1.260942

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	854.902	306.636
SumBase_Unzip	311.312	842.063	2.746128
SumBase	312.238	839.566	2.737985
SumTraits	313.494	836.200	2.727008

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
SumBase_Basic	1216.313	215.524
SumBase_Unzip	716.657	365.787	1.697203
SumBase	710.825	368.789	1.711129
SumTraits	722.410	362.874	1.683687

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	1948.032	134.569
SumBase	1933.417	135.586	1.007559
SumTraits	1957.489	133.918	0.995169

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	649.647	403.517
SumBase_Zip	53.484	4901.345	12.146550
SumBase	54.969	4768.965	11.818485
SumTraits	53.870	4866.195	12.059440

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	4708.652	55.673
SumBase	4862.306	53.914	0.968399
SumTraits	4964.058	52.808	0.948549
SumTraits_Int128	3429.536	76.437	1.372971

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	806.238	325.145
SumBase_Zip	108.102	2424.978	7.458152
SumBase	107.528	2437.925	7.497968
SumTraits	108.673	2412.217	7.418904

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
SumBase_Basic	1176.768	222.766
SumBase_Zip	2523.009	103.901	0.466414
SumBase	1232.970	212.612	0.954417
SumTraits	1236.216	212.054	0.951911

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	2111.324	124.161
SumBase	2148.352	122.021	0.982765
SumTraits	2159.333	121.400	0.977767

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	666.733	393.177
SumBase_Unzip	198.722	1319.150	3.355106
SumBase	199.038	1317.053	3.349773
SumTraits	23.162	11317.635	28.785112
Sum128Base_Basic	1398.036	187.509	0.476907
Sum128Base	1370.888	191.222	0.486351
Sum128Sse_Narrow	100.297	2613.681	6.647599
Sum128Sse_Unpack	36.049	7271.825	18.495057
Sum128Sse_Unzip	61.003	4297.204	10.929448
Sum128Traits	36.118	7258.039	18.459993
Sum256Base_Basic	1219.846	214.899	0.546572
Sum256Base	1187.731	220.710	0.561351
Sum256Avx2_Narrow	55.221	4747.147	12.073825
Sum256Avx2_Unpack	22.289	11761.122	29.913071
Sum256Avx2_Unzip	37.016	7081.978	18.012203
Sum256Traits	22.354	11727.078	29.826484

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	4484.256	58.459
SumBase	4712.130	55.632	0.951641
SumTraits	5880.340	44.580	0.762584
SumTraits_Int128	58.660	4468.862	76.444703
Sum128Base_Basic	6374.986	41.121	0.703414
Sum128Base	6348.479	41.292	0.706351
Sum128Traits	3155.334	83.080	1.421167
Sum128Traits_Int128	63.603	4121.575	70.503981
Sum256Base_Basic	6781.769	38.654	0.661222
Sum256Base	7007.364	37.410	0.639935
Sum256Avx2	3712.209	70.617	1.207975
Sum256Traits	3970.686	66.020	1.129340
Sum256Traits_Int128	62.182	4215.748	72.114915

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	782.330	335.081
SumBase_Unzip	302.635	866.206	2.585066
SumBase	301.539	869.353	2.594458
SumTraits	37.502	6990.059	20.860805
Sum128Base_Basic	2086.787	125.621	0.374897
Sum128Base	2079.186	126.080	0.376268
Sum128Sse_Narrow	192.614	1360.978	4.061639
Sum128Sse_Unpack	55.240	4745.538	14.162362
Sum128Sse_Unzip	105.087	2494.536	7.444576
Sum128Traits	55.054	4761.592	14.210272
Sum256Base_Basic	1574.719	166.470	0.496806
Sum256Base	1585.100	165.380	0.493553
Sum256Avx2_Narrow	117.595	2229.205	6.652735
Sum256Avx2_Unpack	36.385	7204.738	21.501483
Sum256Avx2_Unzip	69.123	3792.411	11.317893
Sum256Traits	36.285	7224.613	21.560796

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
# Sum128Base_Basic	-466313254
# Sum256Base_Basic	-466837542
SumBase_Basic	1148.555	228.238
SumBase_Unzip	709.724	369.360	1.618312
SumBase	706.410	371.093	1.625904
SumTraits	60.208	4353.965	19.076421
Sum128Base_Basic	3108.007	84.345	0.369547
Sum128Base	3079.464	85.127	0.372973
Sum128Sse_Unpack	80.248	3266.690	14.312646
Sum128Sse_Unzip	81.264	3225.848	14.133700
Sum128Traits	81.961	3198.406	14.013466
Sum256Base_Basic	2342.890	111.889	0.490230
Sum256Base	2168.668	120.878	0.529613
Sum256Avx2_Unpack	56.920	4605.509	20.178534
Sum256Avx2_Unzip	73.940	3545.363	15.533622
Sum256Traits	57.094	4591.433	20.116865

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	1662.617	157.670
SumBase	1667.619	157.197	0.997000
SumTraits	89.847	2917.665	18.504934
Sum128Base_Basic	5768.622	45.443	0.288217
Sum128Base	6502.263	40.316	0.255698
Sum128Sse_Unpack	102.472	2558.203	16.225095
Sum128Sse_Unzip	106.696	2456.921	15.582723
Sum128Traits	102.241	2563.989	16.261786
Sum256Base_Basic	4202.893	62.372	0.395589
Sum256Base	3687.921	71.082	0.450828
Sum256Avx2_Unpack	82.874	3163.178	20.062075
Sum256Avx2_Unzip	137.260	1909.841	12.112937
Sum256Traits	84.311	3109.256	19.720078

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	575.010	455.895
SumBase_Zip	53.271	4920.933	10.794005
SumBase	52.736	4970.837	10.903468
SumTraits	14.919	17570.591	38.540871
Sum128Base_Basic	1277.483	205.204	0.450111
Sum128Base	1283.711	204.208	0.447927
Sum128Sse_Widen	122.294	2143.552	4.701855
Sum128Sse_Zip	20.215	12967.776	28.444654
Sum128Traits	20.208	12972.106	28.454151
Sum256Base_Basic	1105.627	237.100	0.520076
Sum256Base	1150.019	227.948	0.500000
Sum256Avx2_Widen	65.585	3997.023	8.767420
Sum256Avx2_Unpack	13.812	18979.155	41.630538
Sum256Avx2_Zip	18.396	14250.406	31.258086
Sum256Traits	13.874	18894.838	41.445589

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	4769.375	54.964
SumBase	4963.898	52.810	0.960812
SumTraits	5917.616	44.299	0.805962
SumTraits_Int128	63.275	4142.950	75.375675
Sum128Base_Basic	6347.017	41.302	0.751436
Sum128Base	6406.743	40.917	0.744431
Sum128Traits	3157.924	83.011	1.510288
Sum128Traits_Int128	67.928	3859.157	70.212434
Sum256Base_Basic	7422.831	35.316	0.642528
Sum256Base	6965.599	37.634	0.684704
Sum256Avx2	3761.705	69.688	1.267876
Sum256Traits	4022.688	65.166	1.185619
Sum256Traits_Int128	61.825	4240.108	77.143344

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	692.457	378.571
SumBase_Zip	102.415	2559.626	6.761286
SumBase	105.567	2483.194	6.559392
SumTraits	28.861	9083.127	23.993201
Sum128Base_Basic	1988.912	131.803	0.348159
Sum128Base	2012.745	130.242	0.344036
Sum128Sse_Widen	240.049	1092.044	2.884649
Sum128Sse_Zip	40.540	6466.347	17.080943
Sum128Traits	39.251	6678.739	17.641978
Sum256Base_Basic	1480.602	177.052	0.467686
Sum256Base	1485.734	176.441	0.466070
Sum256Avx2_Widen	140.613	1864.294	4.924557
Sum256Avx2_Unpack	27.606	9495.847	25.083406
Sum256Avx2_Zip	37.060	7073.414	18.684519
Sum256Traits	28.378	9237.422	24.400776

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
# Sum128Base_Basic	-466313254
# Sum256Base_Basic	-466837542
SumBase_Basic	943.313	277.897
SumBase_Zip	2184.668	119.993	0.431788
SumBase	952.467	275.226	0.990389
SumTraits	58.384	4490.028	16.157161
Sum128Base_Basic	3058.486	85.710	0.308425
Sum128Base	3107.332	84.363	0.303577
Sum128Sse_Zip	80.427	3259.418	11.728868
Sum128Traits	80.022	3275.900	11.788176
Sum256Base_Basic	2226.078	117.760	0.423756
Sum256Base	2016.971	129.969	0.467688
Sum256Avx2_Unpack	56.183	4665.935	16.790154
Sum256Avx2_Zip	74.171	3534.301	12.718023
Sum256Traits	55.209	4748.235	17.086308

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	1532.615	171.044
SumBase	1549.336	169.198	0.989208
SumTraits	113.372	2312.248	13.518471
Sum128Base_Basic	5813.530	45.092	0.263629
Sum128Base	6450.132	40.642	0.237610
Sum128Sse_Zip	103.804	2525.382	14.764551
Sum128Traits	106.369	2464.488	14.408534
Sum256Base_Basic	3931.280	66.682	0.389851
Sum256Base	3396.393	77.183	0.451248
Sum256Avx2_Unpack	110.616	2369.849	13.855232
Sum256Avx2_Zip	146.722	1786.667	10.445679
Sum256Traits	108.770	2410.066	14.090356

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	681.571	384.617
SumBase_Unzip	193.353	1355.779	3.525010
SumBase	192.341	1362.915	3.543562
SumTraits	22.382	11712.292	30.451817
Sum128Base_Basic	1215.750	215.623	0.560618
Sum128Base	1281.720	204.525	0.531763
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	81.866	3202.091	8.325399
Sum128Sse_Unpack	32.430	8083.456	21.016889
Sum128Sse_Unzip	52.199	5022.033	13.057224
Sum128Traits	32.359	8101.005	21.062516
Sum256Base_Basic	1226.494	213.734	0.555707
Sum256Base	1232.130	212.757	0.553165
Sum256Avx2_Narrow	144.260	1817.157	4.724587
Sum256Avx2_Unpack	22.467	11668.034	30.336748
Sum256Avx2_Unzip	36.622	7158.142	18.611083
Sum256Traits	22.513	11644.337	30.275136

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	2873.911	91.215
SumBase	2944.299	89.034	0.976093
SumTraits	9218.540	28.437	0.311753
SumTraits_Int128	56.245	4660.765	51.096428
Sum128Base_Basic	6331.559	41.403	0.453903
Sum128Base	6355.192	41.249	0.452215
Sum128Traits	3138.648	83.521	0.915652
Sum128Traits_Int128	64.215	4082.289	44.754537
Sum256Base_Basic	5202.841	50.385	0.552373
Sum256Base	5802.514	45.178	0.495287
Sum256Avx2	3687.393	71.092	0.779388
Sum256Traits	3663.352	71.559	0.784503
Sum256Traits_Int128	55.516	4721.944	51.767141

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	894.982	292.904
SumBase_Unzip	322.322	813.299	2.776670
SumBase	326.516	802.852	2.741005
SumTraits	36.000	7281.744	24.860486
Sum128Base_Basic	2075.793	126.286	0.431152
Sum128Base	2066.180	126.874	0.433158
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	180.252	1454.320	4.965172
Sum128Sse_Unpack	49.865	5257.057	17.948035
Sum128Sse_Unzip	93.296	2809.804	9.592906
Sum128Traits	50.067	5235.845	17.875614
Sum256Base_Basic	1687.103	155.381	0.530484
Sum256Base	1745.129	150.215	0.512846
Sum256Avx2_Narrow	325.942	804.265	2.745828
Sum256Avx2_Unpack	36.301	7221.397	24.654456
Sum256Avx2_Unzip	68.953	3801.789	12.979627
Sum256Traits	36.031	7275.563	24.839384

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
# Sum128Base_Basic	-466313254
# Sum256Base_Basic	-466837542
SumBase_Basic	1357.490	193.109
SumBase_Unzip	674.601	388.591	2.012287
SumBase	678.532	386.340	2.000627
SumTraits	57.856	4531.006	23.463424
Sum128Base_Basic	3085.322	84.965	0.439983
Sum128Base	3105.580	84.411	0.437113
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	71.439	3669.472	19.002041
Sum128Sse_Unzip	82.273	3186.275	16.499847
Sum128Traits	71.838	3649.089	18.896492
Sum256Base_Basic	2619.560	100.072	0.518213
Sum256Base	2651.757	98.857	0.511921
Sum256Avx2_Unpack	57.321	4573.300	23.682437
Sum256Avx2_Unzip	73.477	3567.710	18.475079
Sum256Traits	57.545	4555.480	23.590158

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	2362.674	110.952
SumBase	2528.647	103.670	0.934363
SumTraits	85.384	3070.160	27.670997
Sum128Base_Basic	5656.161	46.347	0.417717
Sum128Base	6514.355	40.241	0.362687
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	96.382	2719.839	24.513598
Sum128Sse_Unzip	92.637	2829.786	25.504536
Sum128Traits	96.235	2724.012	24.551210
Sum256Base_Basic	4629.518	56.624	0.510350
Sum256Base	4687.765	55.921	0.504009
Sum256Avx2_Unpack	84.238	3111.953	28.047674
Sum256Avx2_Unzip	127.583	2054.701	18.518786
Sum256Traits	84.445	3104.312	27.978811

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	666.438	393.351
SumBase_Zip	51.552	5085.018	12.927443
SumBase	51.459	5094.209	12.950808
SumTraits	12.554	20881.719	53.086776
Sum128Base_Basic	1318.453	198.827	0.505470
Sum128Base	1213.736	215.981	0.549080
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Widen	85.614	3061.943	7.784257
Sum128Sse_Zip	17.505	14975.661	38.072037
Sum128Traits	17.779	14744.642	37.484725
Sum256Base_Basic	1221.988	214.522	0.545372
Sum256Base	1185.623	221.102	0.562100
Sum256Avx2_Widen	56.576	4633.461	11.779466
Sum256Avx2_Unpack	12.317	21283.751	54.108845
Sum256Avx2_Zip	15.706	16690.530	42.431679
Sum256Traits	12.233	21428.836	54.477689

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	3380.720	77.541
SumBase	3448.935	76.007	0.980221
SumTraits	9361.513	28.002	0.361130
SumTraits_Int128	57.784	4536.606	58.505996
Sum128Base_Basic	6406.436	40.919	0.527707
Sum128Base	6372.917	41.134	0.530482
Sum128Traits	3151.174	83.189	1.072845
Sum128Traits_Int128	65.382	4009.394	51.706839
Sum256Base_Basic	5584.081	46.945	0.605421
Sum256Base	5863.830	44.705	0.576538
Sum256Avx2	3754.577	69.820	0.900426
Sum256Traits	3746.820	69.964	0.902291
Sum256Traits_Int128	55.107	4756.999	61.348275

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	879.369	298.105
SumBase_Zip	102.844	2548.948	8.550518
SumBase	105.146	2493.152	8.363348
SumTraits	25.511	10275.728	34.470218
Sum128Base_Basic	1956.945	133.956	0.449358
Sum128Base	1966.427	133.310	0.447192
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Widen	166.712	1572.432	5.274767
Sum128Sse_Zip	35.133	7461.573	25.030055
Sum128Traits	35.604	7362.837	24.698844
Sum256Base_Basic	1610.133	162.809	0.546147
Sum256Base	1678.507	156.177	0.523900
Sum256Avx2_Widen	113.651	2306.579	7.737484
Sum256Avx2_Unpack	25.498	10280.934	34.487680
Sum256Avx2_Zip	32.516	8062.111	27.044579
Sum256Traits	24.896	10529.701	35.322176

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
# Sum128Base_Basic	-466313254
# Sum256Base_Basic	-466837542
SumBase_Basic	1356.615	193.234
SumBase_Zip	2302.712	113.841	0.589138
SumBase	1373.670	190.835	0.987585
SumTraits	50.491	5191.872	26.868333
Sum128Base_Basic	3150.564	83.205	0.430594
Sum128Base	3209.149	81.686	0.422734
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Zip	72.853	3598.240	18.621168
Sum128Traits	71.651	3658.618	18.933624
Sum256Base_Basic	2523.420	103.884	0.537610
Sum256Base	2562.420	102.303	0.529427
Sum256Avx2_Unpack	50.668	5173.782	26.774715
Sum256Avx2_Zip	63.931	4100.444	21.220107
Sum256Traits	51.487	5091.419	26.348480

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	2427.040	108.010
SumBase	2426.716	108.024	1.000133
SumTraits	98.040	2673.854	24.755675
Sum128Base_Basic	5702.270	45.972	0.425627
Sum128Base	6522.488	40.191	0.372103
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Zip	93.357	2807.971	25.997384
Sum128Traits	96.834	2707.136	25.063813
Sum256Base_Basic	4558.996	57.500	0.532363
Sum256Base	4619.613	56.746	0.525377
Sum256Avx2_Unpack	97.943	2676.501	24.780177
Sum256Avx2_Zip	124.835	2099.920	19.441945
Sum256Traits	97.147	2698.435	24.983257

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	566.474	462.764
SumBase_Unzip	196.815	1331.928	2.878198
SumBase	196.841	1331.758	2.877832
SumTraits	22.533	11633.963	25.140142
Sum128Base_Basic	1271.645	206.146	0.445465
Sum128Base	1265.773	207.102	0.447532
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	80.315	3263.961	7.053181
Sum128Sse_Unpack	32.385	8094.591	17.491817
Sum128Sse_Unzip	51.483	5091.896	11.003214
Sum128Traits	32.342	8105.307	17.514974
Sum256Base_Basic	1118.870	234.294	0.506291
Sum256Base	1110.680	236.021	0.510025
Sum256Avx2_Narrow	51.677	5072.741	10.961822
Sum256Avx2_Unpack	22.343	11732.882	25.353897
Sum256Avx2_Unzip	35.411	7402.959	15.997251
Sum256Traits	22.471	11665.941	25.209242

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	2783.785	94.168
SumBase	2766.008	94.773	1.006427
SumTraits	9024.946	29.047	0.308455
SumTraits_Int128	56.178	4666.283	49.552652
Sum128Base_Basic	6366.716	41.174	0.437240
Sum128Base	6376.394	41.112	0.436577
Sum128Traits	3136.949	83.567	0.887418
Sum128Traits_Int128	68.488	3827.590	40.646317
Sum256Base_Basic	4752.571	55.158	0.585743
Sum256Base	5341.824	49.074	0.521130
Sum256Avx2	3516.258	74.552	0.791690
Sum256Traits	3501.314	74.870	0.795069
Sum256Traits_Int128	56.114	4671.648	49.609623

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	713.020	367.653
SumBase_Unzip	291.580	899.047	2.445367
SumBase	292.188	897.176	2.440279
SumTraits	36.034	7274.943	19.787517
Sum128Base_Basic	2014.515	130.128	0.353941
Sum128Base	2020.030	129.772	0.352975
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	176.454	1485.624	4.040829
Sum128Sse_Unpack	49.789	5265.101	14.320838
Sum128Sse_Unzip	92.610	2830.633	7.699194
Sum128Traits	50.772	5163.157	14.043554
Sum256Base_Basic	1516.097	172.907	0.470300
Sum256Base	1515.358	172.991	0.470529
Sum256Avx2_Narrow	113.887	2301.797	6.260784
Sum256Avx2_Unpack	36.544	7173.467	19.511508
Sum256Avx2_Unzip	69.222	3787.005	10.300482
Sum256Traits	36.265	7228.484	19.661151

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
# Sum128Base_Basic	-466313254
# Sum256Base_Basic	-466837542
SumBase_Basic	1016.333	257.931
SumBase_Unzip	705.722	371.455	1.440132
SumBase	687.872	381.094	1.477502
SumTraits	57.541	4555.739	17.662609
Sum128Base_Basic	3015.010	86.946	0.337091
Sum128Base	3074.816	85.255	0.330535
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	70.748	3705.316	14.365517
Sum128Sse_Unzip	82.041	3195.266	12.388054
Sum128Traits	69.707	3760.642	14.580017
Sum256Base_Basic	2123.642	123.441	0.478580
Sum256Base	2097.634	124.971	0.484514
Sum256Avx2_Unpack	57.233	4580.303	17.757847
Sum256Avx2_Unzip	73.080	3587.078	13.907108
Sum256Traits	57.388	4567.923	17.709846

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	1518.727	172.608
SumBase	1590.095	164.861	0.955118
SumTraits	85.737	3057.537	17.713793
Sum128Base_Basic	5663.096	46.290	0.268180
Sum128Base	5792.032	45.259	0.262210
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	101.415	2584.873	14.975421
Sum128Sse_Unzip	96.667	2711.829	15.710937
Sum128Traits	95.555	2743.392	15.893801
Sum256Base_Basic	3692.175	71.000	0.411337
Sum256Base	3648.263	71.854	0.416288
Sum256Avx2_Unpack	87.992	2979.182	17.259842
Sum256Avx2_Unzip	128.305	2043.133	11.836862
Sum256Traits	86.864	3017.880	17.484040

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	592.906	442.134
SumBase_Zip	52.696	4974.636	11.251423
SumBase	52.331	5009.342	11.329920
SumTraits	12.794	20489.374	46.342009
Sum128Base_Basic	1256.489	208.632	0.471875
Sum128Base	1298.317	201.911	0.456673
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Widen	84.205	3113.181	7.041262
Sum128Sse_Zip	17.739	14778.250	33.424826
Sum128Traits	17.689	14819.275	33.517616
Sum256Base_Basic	1126.638	232.678	0.526262
Sum256Base	1117.499	234.581	0.530565
Sum256Avx2_Widen	55.801	4697.851	10.625402
Sum256Avx2_Unpack	12.217	21458.135	48.533110
Sum256Avx2_Zip	15.861	16527.551	37.381322
Sum256Traits	12.551	20886.951	47.241230

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	3091.329	84.800
SumBase	3071.010	85.361	1.006616
SumTraits	9037.632	29.006	0.342051
SumTraits_Int128	56.409	4647.233	54.802427
Sum128Base_Basic	6339.803	41.349	0.487607
Sum128Base	6346.876	41.303	0.487063
Sum128Traits	3144.891	83.356	0.982969
Sum128Traits_Int128	67.528	3881.983	45.778233
Sum256Base_Basic	4997.845	52.451	0.618532
Sum256Base	5396.931	48.573	0.572794
Sum256Avx2	3547.745	73.890	0.871351
Sum256Traits	3543.303	73.983	0.872443
Sum256Traits_Int128	55.424	4729.797	55.776070

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	722.447	362.856
SumBase_Zip	104.330	2512.644	6.924635
SumBase	104.030	2519.882	6.944581
SumTraits	24.915	10521.471	28.996282
Sum128Base_Basic	1930.846	135.766	0.374161
Sum128Base	1954.719	134.108	0.369591
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Widen	161.036	1627.863	4.486251
Sum128Sse_Zip	37.121	7061.820	19.461776
Sum128Traits	34.748	7544.184	20.791131
Sum256Base_Basic	1420.685	184.519	0.508520
Sum256Base	1418.987	184.740	0.509128
Sum256Avx2_Widen	112.991	2320.037	6.393826
Sum256Avx2_Unpack	24.873	10539.332	29.045505
Sum256Avx2_Zip	33.024	7937.913	21.876215
Sum256Traits	25.605	10238.148	28.215467

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
# Sum128Base_Basic	-466313254
# Sum256Base_Basic	-466837542
SumBase_Basic	890.100	294.511
SumBase_Zip	2089.255	125.472	0.426037
SumBase	885.745	295.959	1.004917
SumTraits	50.431	5198.124	17.650039
Sum128Base_Basic	3127.440	83.821	0.284610
Sum128Base	3155.970	83.063	0.282037
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Zip	72.935	3594.226	12.204064
Sum128Traits	69.662	3763.094	12.777448
Sum256Base_Basic	1992.946	131.536	0.446625
Sum256Base	1949.124	134.493	0.456667
Sum256Avx2_Unpack	49.798	5264.162	17.874269
Sum256Avx2_Zip	63.746	4112.304	13.963178
Sum256Traits	50.461	5195.031	17.639537

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	1486.695	176.327
SumBase	1445.086	181.404	1.028794
SumTraits	99.215	2642.175	14.984548
Sum128Base_Basic	5674.158	46.200	0.262012
Sum128Base	5791.872	45.261	0.256686
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Zip	97.326	2693.472	15.275466
Sum128Traits	95.952	2732.028	15.494127
Sum256Base_Basic	3466.313	75.626	0.428898
Sum256Base	3475.401	75.428	0.427777
Sum256Avx2_Unpack	99.498	2634.659	14.941923
Sum256Avx2_Zip	127.045	2063.402	11.702159
Sum256Traits	99.062	2646.259	15.007707

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	631.148	415.345
SumBase_Narrow	51.899	5050.996	12.160972
SumBase_Unzip	34.468	7605.523	18.311349
SumBase	34.071	7694.095	18.524597
SumTraits	22.914	11440.257	27.544000
Sum128Base_Basic	664.136	394.714	0.950330
Sum128Base_Narrow	84.366	3107.233	7.481093
Sum128Base_Unzip	54.753	4787.751	11.527172
Sum128Base	54.926	4772.638	11.490787
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	81.117	3231.663	7.780676
Sum128Sse_Unpack	33.309	7870.067	18.948274
Sum128Sse_Unzip	55.057	4761.336	11.463576
Sum128Traits	33.154	7906.761	19.036620
Sum256Base_Basic	608.679	430.677	1.036915
Sum256Base_Narrow	53.774	4874.950	11.737116
Sum256Base_Unzip	34.683	7558.180	18.197364
Sum256Base	34.313	7639.775	18.393814
Sum256Avx2_Narrow	51.788	5061.850	12.187103
Sum256Avx2_Unpack	22.501	11650.379	28.049897
Sum256Avx2_Unzip	34.754	7542.780	18.160287
Sum256Traits	22.647	11575.078	27.868600

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1762985990809070452
Check-SumTraits	Check `SumTraits` mismatch. 3227566828761211651!=-1762985990809070452
Check-SumTraits_Int128	Check `SumTraits_Int128` mismatch. 5910372263572401668!=-1762985990809070452
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	3303.048	79.364
SumBase	3243.659	80.817	1.018309
SumTraits	2008.874	130.493	1.644229
SumTraits_Int128	57.715	4542.025	57.230100
Sum128Base_Basic	3147.143	83.296	1.049538
Sum128Base	3144.203	83.374	1.050520
Sum128Traits	3157.059	83.034	1.046242
Sum128Traits_Int128	74.762	3506.388	44.180938
Sum256Base_Basic	2112.410	124.097	1.563639
Sum256Base	601.045	436.147	5.495512
Sum256Avx2	548.667	477.783	6.020129
Sum256Traits	539.514	485.889	6.122266
Sum256Traits_Int128	57.769	4537.832	57.177260

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	833.980	314.329
SumBase_Narrow	108.336	2419.735	7.698103
SumBase_Unzip	68.934	3802.816	12.098212
SumBase	70.685	3708.598	11.798469
SumTraits	36.843	7115.192	22.636149
Sum128Base_Basic	858.176	305.466	0.971805
Sum128Base_Narrow	172.469	1519.946	4.835530
Sum128Base_Unzip	113.243	2314.881	7.364522
Sum128Base	113.340	2312.904	7.358233
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	175.216	1496.123	4.759739
Sum128Sse_Unpack	50.235	5218.333	16.601514
Sum128Sse_Unzip	95.238	2752.524	8.756831
Sum128Traits	51.066	5133.435	16.331421
Sum256Base_Basic	816.167	321.189	1.021826
Sum256Base_Narrow	107.776	2432.301	7.738079
Sum256Base_Unzip	69.277	3783.991	12.038324
Sum256Base	69.334	3780.878	12.028420
Sum256Avx2_Narrow	115.380	2271.999	7.228096
Sum256Avx2_Unpack	36.888	7106.401	22.608181
Sum256Avx2_Unzip	69.628	3764.902	11.977594
Sum256Traits	36.854	7113.034	22.629283

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
# Sum128Base_Basic	-466313254
# Sum256Base_Basic	-466837542
SumBase_Basic	1150.425	227.867
SumBase_Unzip	142.156	1844.052	8.092664
SumBase	143.002	1833.154	8.044836
SumTraits	58.457	4484.379	19.679795
Sum128Base_Basic	1327.542	197.466	0.866583
Sum128Base_Unzip	229.715	1141.171	5.008055
Sum128Base	228.252	1148.487	5.040161
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	72.574	3612.090	15.851734
Sum128Sse_Unzip	87.522	2995.178	13.144405
Sum128Traits	76.592	3422.599	15.020151
Sum256Base_Basic	1137.644	230.427	1.011235
Sum256Base_Unzip	139.336	1881.378	8.256466
Sum256Base	139.494	1879.245	8.247105
Sum256Avx2_Unpack	58.052	4515.699	19.817241
Sum256Avx2_Unzip	73.806	3551.816	15.587223
Sum256Traits	57.883	4528.857	19.874987

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	1886.645	138.947
SumBase	1893.124	138.472	0.996578
SumTraits	87.362	3000.670	21.595759
Sum128Base_Basic	2165.745	121.041	0.871130
Sum128Base_Move	5727.689	45.768	0.329390
Sum128Base_Unzip	3324.922	78.842	0.567425
Sum128Base	3313.894	79.105	0.569314
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	95.872	2734.317	19.678825
Sum128Sse_Unzip	101.733	2576.776	18.545004
Sum128Traits	100.249	2614.924	18.819552
Sum256Base_Basic	1860.937	140.867	1.013814
Sum256Base	1870.495	140.147	1.008634
Sum256Avx2_Unpack	86.551	3028.780	21.798070
Sum256Avx2_Unzip	129.623	2022.364	14.554910
Sum256Traits	89.450	2930.615	21.091572

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	581.508	450.800
SumBase_Widen	54.478	4811.906	10.674141
SumBase_Zip	35.928	7296.301	16.185217
SumBase	35.967	7288.461	16.167828
SumTraits	12.912	20302.304	45.036139
Sum128Base_Basic	627.776	417.576	0.926299
Sum128Base_Widen	103.919	2522.568	5.595756
Sum128Base_Zip	66.098	3965.990	8.797664
Sum128Base	67.830	3864.722	8.573024
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Widen	86.457	3032.090	6.726016
Sum128Sse_Zip	18.429	14224.181	31.553177
Sum128Traits	18.302	14323.282	31.773010
Sum256Base_Basic	551.970	474.925	1.053515
Sum256Base_Widen	55.037	4763.063	10.565794
Sum256Base_Zip	36.413	7199.163	15.969739
Sum256Base	36.275	7226.623	16.030653
Sum256Avx2_Widen	58.009	4519.043	10.024489
Sum256Avx2_Unpack	12.299	21314.463	47.281388
Sum256Avx2_Zip	16.102	16280.004	36.113562
Sum256Traits	12.668	20693.407	45.903714

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	6068712411956559007
Check-SumBase	Check `SumBase` mismatch. 6068594992779389594!=6068712411956559007
Check-SumTraits	Check `SumTraits` mismatch. 3227566869893625171!=6068712411956559007
Check-SumTraits_Int128	Check `SumTraits_Int128` mismatch. 5910372263572401668!=6068712411956559007
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	3107.497	84.359
SumBase	3096.695	84.653	1.003488
SumTraits	2006.476	130.649	1.548734
SumTraits_Int128	57.092	4591.619	54.429781
Sum128Base_Basic	3152.067	83.166	0.985860
Sum128Base	3142.007	83.432	0.989016
Sum128Traits	3158.399	82.999	0.983883
Sum128Traits_Int128	71.819	3650.084	43.268675
Sum256Base_Basic	1960.882	133.687	1.584745
Sum256Base	585.444	447.769	5.307930
Sum256Avx2	542.584	483.140	5.727215
Sum256Traits	540.087	485.374	5.753696
Sum256Traits_Int128	56.141	4669.404	55.351865

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	689.388	380.256
SumBase_Widen	108.648	2412.773	6.345129
SumBase_Zip	71.860	3647.958	9.593429
SumBase	72.292	3626.172	9.536135
SumTraits	25.604	10238.326	26.924831
Sum128Base_Basic	816.490	321.062	0.844332
Sum128Base_Widen	213.557	1227.512	3.228121
Sum128Base_Zip	143.240	1830.105	4.812825
Sum128Base	143.224	1830.314	4.813373
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Widen	171.811	1525.768	4.012477
Sum128Sse_Zip	36.087	7264.182	19.103402
Sum128Traits	37.108	7064.437	18.578112
Sum256Base_Basic	696.341	376.459	0.990015
Sum256Base_Widen	110.763	2366.719	6.224017
Sum256Base_Zip	71.424	3670.263	9.652087
Sum256Base	73.241	3579.184	9.412567
Sum256Avx2_Widen	116.271	2254.595	5.929152
Sum256Avx2_Unpack	26.079	10051.832	26.434387
Sum256Avx2_Zip	32.752	8003.923	21.048778
Sum256Traits	25.675	10210.013	26.850373

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
# Sum128Base_Basic	-466313254
# Sum256Base_Basic	-466837542
SumBase_Basic	1066.344	245.834
SumBase_Zip	143.506	1826.713	7.430666
SumBase	144.226	1817.586	7.393539
SumTraits	52.536	4989.766	20.297267
Sum128Base_Basic	1307.263	200.529	0.815707
Sum128Base_Zip	283.380	925.063	3.762953
Sum128Base	281.728	930.485	3.785007
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Zip	75.375	3477.853	14.147137
Sum128Traits	75.334	3479.747	14.154842
Sum256Base_Basic	1010.569	259.402	1.055192
Sum256Base_Zip	144.449	1814.790	7.382163
Sum256Base	144.513	1813.977	7.378857
Sum256Avx2_Unpack	51.893	5051.634	20.548931
Sum256Avx2_Zip	65.626	3994.512	16.248792
Sum256Traits	51.843	5056.451	20.568525

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
SumBase_Basic	1648.232	159.046
SumBase	1670.946	156.884	0.986406
SumTraits	102.170	2565.763	16.132251
Sum128Base_Basic	2095.773	125.082	0.786455
Sum128Base_Move	5730.957	45.742	0.287602
Sum128Base_Zip	3306.802	79.274	0.498437
Sum128Base	3293.556	79.593	0.500442
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Zip	97.167	2697.866	16.962849
Sum128Traits	96.838	2707.043	17.020552
Sum256Base_Basic	1658.797	158.033	0.993631
Sum256Base	1700.689	154.140	0.969156
Sum256Avx2_Unpack	101.544	2581.569	16.231632
Sum256Avx2_Zip	127.346	2058.522	12.942967
Sum256Traits	102.342	2561.453	16.105153

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	515.184	508.836
SumBase_Narrow	40.806	6424.102	12.625107
SumBase_Unzip	23.153	11322.199	22.251198
SumBase	23.530	11140.844	21.894785
SumTraits	10.976	23883.061	46.936704
Sum128Base_Basic	482.532	543.268	1.067670
Sum128Base_Narrow	81.480	3217.284	6.322838
Sum128Base_Unzip	45.244	5793.973	11.386732
Sum128Base	45.302	5786.586	11.372215
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	17.798	14728.610	28.945720
Sum128Sse_Narrow	66.399	3947.983	7.758860
Sum128Sse_Unpack	32.749	8004.607	15.731227
Sum128Sse_Unzip	19.835	13216.107	25.973240
Sum128Traits	17.292	15159.452	29.792441
Sum256Base_Basic	496.411	528.079	1.037818
Sum256Base_Narrow	40.434	6483.212	12.741273
Sum256Base_Unzip	23.132	11332.542	22.271524
Sum256Base	23.084	11356.249	22.318114
Sum256Avx2_Permute	13.666	19181.517	37.696892
Sum256Avx2_Narrow	40.563	6462.570	12.700706
Sum256Avx2_Unpack	20.651	12694.266	24.947681
Sum256Avx2_Unzip	10.274	25515.269	50.144435
Sum256Traits	9.959	26321.408	51.728718
Sum512Base_Basic	476.402	550.258	1.081407
Sum512Base_Narrow	40.241	6514.335	12.802439
Sum512Base_Unzip	19.909	13167.362	25.877443
Sum512Base	19.877	13188.038	25.918078
Sum512Avx512_Permute	14.995	17482.569	34.357999
Sum512Avx512_Narrow	40.215	6518.573	12.810767
Sum512Avx512_Unpack	22.344	11732.034	23.056634
Sum512Avx512_Unzip	7.834	33462.067	65.762053
Sum512Traits	7.952	32966.449	64.788028

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	4014530024295949961
Check-SumBase	Check `SumBase` mismatch. 4014572167039515208!=4014530024295949961
Check-SumTraits	Check `SumTraits` mismatch. 3199662901941356043!=4014530024295949961
Check-SumTraits_Int128	Check `SumTraits_Int128` mismatch. 5910372263572401668!=4014530024295949961
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
# Sum512Base_Basic	5910372263572205060
SumBase_Basic	2629.820	99.681
SumBase	2615.808	100.215	1.005357
SumTraits	2777.714	94.374	0.946757
SumTraits_Int128	48.121	5447.562	54.649760
Sum128Base_Basic	3108.404	84.334	0.846035
Sum128Base	3098.729	84.597	0.848677
Sum128Traits	3107.551	84.357	0.846268
Sum128Traits_Int128	70.401	3723.567	37.354704
Sum256Base_Basic	1181.802	221.817	2.225263
Sum256Base	55.836	4694.933	47.099410
Sum256Avx2	48.845	5366.868	53.840238
Sum256Traits	49.120	5336.861	53.539205
Sum256Traits_Int128	47.710	5494.496	55.120599
Sum512Base_Basic	910.309	287.972	2.888930
Sum512Base_Move	138.974	1886.283	18.923130
Sum512Base_Unzip	294.490	890.162	8.930073
Sum512Base	139.172	1883.592	18.896133
Sum512Avx512	60.064	4364.424	43.783754
Sum512Traits	60.274	4349.202	43.631050
Sum512Traits_Int128	60.121	4360.276	43.742140

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	-24614
SumBase_Basic	606.051	432.544
SumBase_Narrow	81.872	3201.869	7.402410
SumBase_Unzip	46.654	5618.852	12.990240
SumBase	46.501	5637.351	13.033007
SumTraits	21.682	12090.640	27.952384
Sum128Base_Basic	654.094	400.774	0.926551
Sum128Base_Narrow	160.505	1633.242	3.775897
Sum128Base_Unzip	90.797	2887.157	6.674825
Sum128Base	89.652	2924.003	6.760011
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	35.790	7324.511	16.933557
Sum128Sse_Narrow	128.610	2038.283	4.712311
Sum128Sse_Unpack	49.974	5245.593	12.127302
Sum128Sse_Unzip	39.034	6715.743	15.526144
Sum128Traits	38.295	6845.378	15.825848
Sum256Base_Basic	596.075	439.783	1.016736
Sum256Base_Narrow	80.400	3260.511	7.537984
Sum256Base_Unzip	46.720	5610.957	12.971986
Sum256Base	47.157	5558.928	12.851701
Sum256Avx2_Permute	27.773	9438.963	21.821964
Sum256Avx2_Narrow	81.900	3200.801	7.399940
Sum256Avx2_Unpack	33.769	7762.908	17.947089
Sum256Avx2_Unzip	21.548	12165.501	28.125455
Sum256Traits	20.255	12942.112	29.920905
Sum512Base_Basic	573.458	457.129	1.056837
Sum512Base_Narrow	80.559	3254.052	7.523053
Sum512Base_Unzip	39.365	6659.382	15.395844
Sum512Base	39.453	6644.433	15.361283
Sum512Avx512_Permute	31.179	8407.801	19.438019
Sum512Avx512_Narrow	80.264	3266.021	7.550723
Sum512Avx512_Unpack	37.593	6973.292	16.121573
Sum512Avx512_Unzip	15.820	16570.473	38.309323
Sum512Traits	15.702	16694.703	38.596530

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
# Sum128Base_Basic	-466313254
# Sum256Base_Basic	-466837542
# Sum512Base_Basic	-467296294
SumBase_Basic	821.138	319.245
SumBase_Unzip	93.547	2802.278	8.777834
SumBase	93.786	2795.132	8.755450
SumTraits	41.943	6249.957	19.577319
Sum128Base_Basic	952.618	275.183	0.861980
Sum128Base_Unzip	184.185	1423.265	4.458224
Sum128Base	180.088	1455.643	4.559644
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	73.434	3569.770	11.181922
Sum128Sse_Unpack	71.514	3665.616	11.482147
Sum128Sse_Unzip	72.173	3632.176	11.377402
Sum128Traits	71.304	3676.406	11.515947
Sum256Base_Basic	825.317	317.628	0.994936
Sum256Base_Unzip	93.917	2791.221	8.743200
Sum256Base	93.130	2814.809	8.817086
Sum256Avx2_Permute	54.560	4804.668	15.050106
Sum256Avx2_Unpack	52.922	4953.402	15.516000
Sum256Avx2_Unzip	42.611	6152.071	19.270700
Sum256Traits	40.729	6436.301	20.161021
Sum512Base_Basic	705.680	371.477	1.163612
Sum512Base_Unzip	78.735	3329.459	10.429171
Sum512Base	79.091	3314.440	10.382128
Sum512Avx512_Permute	62.449	4197.718	13.148902
Sum512Avx512_Unpack	61.244	4280.347	13.407728
Sum512Avx512_Unzip	31.915	8213.812	25.728883
Sum512Traits	31.759	8254.065	25.854970

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
# Sum512Base_Basic	5910372263572205060
SumBase_Basic	1317.413	198.984
SumBase	1304.940	200.886	1.009558
SumTraits	70.028	3743.422	18.812683
Sum128Base_Basic	1639.702	159.873	0.803446
Sum128Base_Move	2626.460	99.809	0.501593
Sum128Base_Unzip	1049.388	249.806	1.255410
Sum128Base	1056.125	248.213	1.247402
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	146.314	1791.655	9.004017
Sum128Sse_Unpack	99.689	2629.631	13.215291
Sum128Sse_Unzip	99.211	2642.295	13.278931
Sum128Traits	96.374	2720.074	13.669813
Sum256Base_Basic	1313.814	199.529	1.002739
Sum256Base	1306.697	200.616	1.008200
Sum256Avx2_Permute	108.985	2405.319	12.088006
Sum256Avx2_Unpack	74.374	3524.684	17.713406
Sum256Avx2_Unzip	81.912	3200.331	16.083363
Sum256Traits	74.378	3524.479	17.712375
Sum512Base_Basic	1041.339	251.738	1.265115
Sum512Base	1055.003	248.477	1.248729
Sum512Avx512_Permute	121.380	2159.698	10.853627
Sum512Avx512_Unpack	90.320	2902.392	14.586061
Sum512Avx512_Unzip	63.045	4158.073	20.896522
Sum512Traits	63.023	4159.506	20.903724

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	462.460	566.847
SumBase_Widen	49.327	5314.398	9.375369
SumBase_Zip	31.646	8283.701	14.613651
SumBase	31.782	8248.253	14.551116
SumTraits	10.603	24723.567	43.615960
Sum128Base_Basic	539.851	485.586	0.856644
Sum128Base_Widen	97.523	2688.026	4.742067
Sum128Base_Zip	64.239	4080.740	7.199018
Sum128Base	64.175	4084.862	7.206289
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	18.362	14276.207	25.185300
Sum128Sse_Widen	83.521	3138.661	5.537053
Sum128Sse_Zip	18.417	14233.708	25.110326
Sum128Traits	18.540	14139.144	24.943503
Sum256Base_Basic	456.488	574.262	1.013082
Sum256Base_Widen	49.695	5275.039	9.305933
Sum256Base_Zip	32.537	8056.696	14.213181
Sum256Base	31.942	8206.895	14.478153
Sum256Avx2_Permute	13.647	19208.990	33.887447
Sum256Avx2_Widen	48.656	5387.699	9.504682
Sum256Avx2_Unpack	12.688	20661.159	36.449282
Sum256Avx2_Zip	10.484	25005.377	44.113114
Sum256Traits	10.677	24553.252	43.315499
Sum512Base_Basic	467.428	560.822	0.989371
Sum512Base_Widen	42.004	6240.905	11.009862
Sum512Base_Zip	25.008	10482.232	18.492178
Sum512Base	25.038	10469.801	18.470248
Sum512Avx512_Widen	41.630	6296.965	11.108759
Sum512Avx512_Unpack	13.883	18882.903	33.312181
Sum512Avx512_Zip	7.882	33258.320	58.672504
Sum512Traits	7.932	33050.939	58.306652

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1090783767797133349
Check-SumBase	Check `SumBase` mismatch. 3090802681087540734!=-1090783767797133349
Check-SumTraits	Check `SumTraits` mismatch. -4677199428773065780!=-1090783767797133349
Check-SumTraits_Int128	Check `SumTraits_Int128` mismatch. 5910372263572401668!=-1090783767797133349
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
# Sum512Base_Basic	5910372263572205060
SumBase_Basic	2668.647	98.231
SumBase	2662.833	98.446	1.002183
SumTraits	2811.816	93.229	0.949083
SumTraits_Int128	50.066	5235.955	53.302431
Sum128Base_Basic	3101.541	84.521	0.860426
Sum128Base	3103.374	84.471	0.859918
Sum128Traits	3094.401	84.716	0.862411
Sum128Traits_Int128	71.877	3647.143	37.128206
Sum256Base_Basic	1365.251	192.012	1.954693
Sum256Base	55.090	4758.460	48.441495
Sum256Avx2	48.274	5430.292	55.280799
Sum256Traits	49.078	5341.405	54.375927
Sum256Traits_Int128	48.750	5377.307	54.741414
Sum512Base_Basic	1239.636	211.468	2.152766
Sum512Base_Move	139.077	1884.878	19.188208
Sum512Base_Zip	293.884	891.999	9.080620
Sum512Base	139.168	1883.651	19.175718
Sum512Avx512	62.465	4196.687	42.722605
Sum512Traits	63.407	4134.293	42.087431
Sum512Traits_Int128	63.208	4147.294	42.219778

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	-24614
SumBase_Basic	580.229	451.794
SumBase_Widen	98.663	2656.963	5.880922
SumBase_Zip	63.255	4144.257	9.172898
SumBase	63.713	4114.475	9.106979
SumTraits	21.042	12458.323	27.575250
Sum128Base_Basic	727.822	360.176	0.797214
Sum128Base_Widen	193.969	1351.475	2.991355
Sum128Base_Zip	129.941	2017.405	4.465324
Sum128Base	131.508	1993.364	4.412113
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	38.055	6888.565	15.247148
Sum128Sse_Widen	174.269	1504.251	3.329508
Sum128Sse_Zip	35.562	7371.543	16.316173
Sum128Traits	35.637	7355.981	16.281728
Sum256Base_Basic	586.457	446.996	0.989382
Sum256Base_Widen	97.867	2678.575	5.928757
Sum256Base_Zip	66.719	3929.069	8.696601
Sum256Base	64.157	4085.968	9.043882
Sum256Avx2_Permute	27.667	9475.023	20.972015
Sum256Avx2_Widen	98.105	2672.070	5.914359
Sum256Avx2_Unpack	24.838	10554.011	23.360246
Sum256Avx2_Zip	20.870	12560.870	27.802229
Sum256Traits	20.552	12754.909	28.231714
Sum512Base_Basic	616.742	425.047	0.940798
Sum512Base_Widen	83.999	3120.806	6.907592
Sum512Base_Zip	49.856	5257.995	11.638044
Sum512Base	49.976	5245.364	11.610087
Sum512Avx512_Widen	83.507	3139.200	6.948306
Sum512Avx512_Unpack	28.025	9353.922	20.703971
Sum512Avx512_Zip	15.790	16601.833	36.746495
Sum512Traits	15.674	16724.948	37.018998

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
# Sum128Base_Basic	-466313254
# Sum256Base_Basic	-466837542
# Sum512Base_Basic	-467296294
SumBase_Basic	820.584	319.460
SumBase_Zip	125.604	2087.067	6.533100
SumBase	123.205	2127.701	6.660297
SumTraits	38.593	6792.440	21.262230
Sum128Base_Basic	1159.499	226.084	0.707705
Sum128Base_Zip	255.029	1027.900	3.217612
Sum128Base	259.325	1010.871	3.164308
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	72.656	3607.999	11.294040
Sum128Sse_Zip	75.702	3462.840	10.839652
Sum128Traits	70.189	3734.821	11.691031
Sum256Base_Basic	850.428	308.250	0.964907
Sum256Base_Zip	131.073	1999.979	6.260490
Sum256Base	129.315	2027.180	6.345637
Sum256Avx2_Permute	54.853	4779.061	14.959792
Sum256Avx2_Unpack	50.909	5149.223	16.118501
Sum256Avx2_Zip	41.204	6362.161	19.915336
Sum256Traits	41.347	6340.075	19.846199
Sum512Base_Basic	892.819	293.614	0.919093
Sum512Base_Zip	100.180	2616.734	8.191105
Sum512Base	100.018	2620.974	8.204378
Sum512Avx512_Unpack	55.957	4684.721	14.664482
Sum512Avx512_Zip	31.940	8207.273	25.691051
Sum512Traits	31.892	8219.793	25.730241

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	5910372263572401668
# Sum512Base_Basic	5910372263572205060
SumBase_Basic	1481.839	176.905
SumBase	1451.013	180.663	1.021244
SumTraits	81.899	3200.810	18.093435
Sum128Base_Basic	1952.746	134.244	0.758849
Sum128Base_Move	2626.871	99.793	0.564108
Sum128Base_Zip	1051.208	249.374	1.409653
Sum128Base	1058.430	247.673	1.400035
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	148.818	1761.508	9.957395
Sum128Sse_Zip	88.849	2950.458	16.678253
Sum128Traits	91.540	2863.710	16.187888
Sum256Base_Basic	1466.537	178.750	1.010434
Sum256Base	1440.364	181.998	1.028795
Sum256Avx2_Permute	109.008	2404.807	13.593814
Sum256Avx2_Unpack	98.381	2664.569	15.062188
Sum256Avx2_Zip	84.424	3105.077	17.552275
Sum256Traits	83.988	3121.222	17.643543
Sum512Base_Basic	1434.846	182.698	1.032751
Sum512Base	1490.405	175.888	0.994253
Sum512Avx512_Unpack	111.077	2360.029	13.340693
Sum512Avx512_Zip	63.119	4153.175	23.476931
Sum512Traits	62.533	4192.078	23.696837

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	448.379	584.649
SumBase_Unzip	125.238	2093.166	3.580211
SumBase	125.244	2093.072	3.580051
SumTraits	12.075	21709.057	37.131791
Sum128Base_Basic	714.642	366.819	0.627417
Sum128Base	715.100	366.584	0.627015
Sum128AdvSimd_Narrow	42.250	6204.560	10.612456
Sum128AdvSimd_Unzip	27.832	9418.671	16.109963
Sum128AdvSimdB64_Unzip	12.073	21713.503	37.139396
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	12.073	21712.500	37.137680
Sum256Base_Basic	751.441	348.855	0.596691
Sum256Base	750.554	349.267	0.597397
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	815.574	321.423	0.549771

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	1317.127	199.027
SumBase	1327.511	197.470	0.992178
SumTraits	1323.106	198.128	0.995482
SumTraits_Int128	244.656	1071.479	5.383586
Sum128Base_Basic	747.847	350.532	1.761226
Sum128Base	747.948	350.484	1.760988
Sum128Traits	195.491	1340.951	6.737528
Sum128Traits_Int128	81.094	3232.575	16.241883
Sum256Base_Basic	2352.802	111.418	0.559812
Sum256Base	3938.189	66.565	0.334450
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4911.142	53.377	0.268192
Sum256Traits_Int128	2559.821	102.407	0.514539

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	627.616	417.682
SumBase_Unzip	130.453	2009.488	4.811048
SumBase	130.423	2009.957	4.812170
SumTraits	24.113	10871.631	26.028482
Sum128Base_Basic	929.446	282.043	0.675258
Sum128Base	936.900	279.799	0.669886
Sum128AdvSimd_Narrow	84.470	3103.392	7.430033
Sum128AdvSimd_Unzip	55.634	4711.975	11.281247
Sum128AdvSimdB64_Unzip	24.116	10870.277	26.025241
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	24.114	10871.121	26.027261
Sum256Base_Basic	984.028	266.399	0.637803
Sum256Base	983.034	266.668	0.638448
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1067.888	245.479	0.587717

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
SumBase_Basic	908.306	288.607
SumBase_Unzip	337.638	776.406	2.690181
SumBase	337.636	776.409	2.690191
SumTraits	48.203	5438.320	18.843310
Sum128Base_Basic	1255.915	208.728	0.723223
Sum128Base	1258.560	208.289	0.721703
Sum128AdvSimd_Unzip	111.347	2354.294	8.157427
Sum128AdvSimdB64_Unzip	48.209	5437.669	18.841052
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	48.206	5438.011	18.842237
Sum256Base_Basic	1400.900	187.125	0.648373
Sum256Base	1406.527	186.377	0.645779
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1440.824	181.940	0.630408

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	1344.481	194.978
SumBase	1337.990	195.924	1.004851
SumTraits	78.882	3323.262	17.044302
Sum128Base_Basic	1918.596	136.633	0.700763
Sum128Base	642.232	408.176	2.093449
Sum128AdvSimd_Unzip	96.394	2719.493	13.947699
Sum128AdvSimdB64_Unzip	78.897	3322.597	17.040888
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.886	3323.066	17.043295
Sum256Base_Basic	2412.298	108.670	0.557344
Sum256Base	2431.263	107.822	0.552997
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2425.626	108.073	0.554282

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	401.630	652.700
SumBase_Zip	48.191	5439.695	8.334143
SumBase	48.205	5438.090	8.331684
SumTraits	12.075	21710.219	33.262169
Sum128Base_Basic	688.931	380.508	0.582976
Sum128Base	688.712	380.629	0.583161
Sum128AdvSimd_Widen	59.049	4439.439	6.801653
Sum128AdvSimd_Zip	39.762	6592.849	10.100886
Sum128AdvSimdB64_Zip	12.074	21710.903	33.263217
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	12.070	21717.794	33.273775
Sum256Base_Basic	738.589	354.926	0.543780
Sum256Base	756.735	346.414	0.530740
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	811.224	323.146	0.495092

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	799.577	327.853
SumBase	799.733	327.789	0.999805
SumTraits	799.748	327.783	0.999787
SumTraits_Int128	244.569	1071.863	3.269338
Sum128Base_Basic	747.995	350.462	1.068960
Sum128Base	748.109	350.409	1.068797
Sum128Traits	194.869	1345.230	4.103146
Sum128Traits_Int128	80.996	3236.502	9.871797
Sum256Base_Basic	2252.951	116.356	0.354902
Sum256Base	3948.000	66.399	0.202527
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4930.458	53.168	0.162171
Sum256Traits_Int128	2549.780	102.810	0.313587

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	501.006	523.235
SumBase_Zip	96.359	2720.480	5.199343
SumBase	96.362	2720.413	5.199215
SumTraits	24.117	10869.472	20.773581
Sum128Base_Basic	784.762	334.043	0.638418
Sum128Base	785.317	333.806	0.637966
Sum128AdvSimd_Widen	118.065	2220.336	4.243475
Sum128AdvSimd_Zip	79.516	3296.733	6.300668
Sum128AdvSimdB64_Zip	24.118	10869.243	20.773142
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	24.118	10869.357	20.773361
Sum256Base_Basic	963.408	272.101	0.520035
Sum256Base	981.125	267.187	0.510645
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1055.987	248.245	0.474443

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
SumBase_Basic	597.440	438.779
SumBase_Zip	1358.726	192.934	0.439706
SumBase	597.489	438.743	0.999918
SumTraits	48.201	5438.546	12.394735
Sum128Base_Basic	937.795	279.532	0.637069
Sum128Base	961.470	272.649	0.621382
Sum128AdvSimd_Zip	158.982	1648.886	3.757898
Sum128AdvSimdB64_Zip	48.207	5437.854	12.393157
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	48.213	5437.194	12.391653
Sum256Base_Basic	1359.308	192.851	0.439518
Sum256Base	1386.252	189.103	0.430975
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1652.155	158.668	0.361613

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	643.744	407.218
SumBase	642.221	408.183	1.002372
SumTraits	78.886	3323.062	8.160408
Sum128Base_Basic	1233.187	212.574	0.522017
Sum128Base	638.500	410.562	1.008213
Sum128AdvSimd_Zip	96.381	2719.877	6.679174
Sum128AdvSimdB64_Zip	78.901	3322.445	8.158893
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.891	3322.864	8.159922
Sum256Base_Basic	2309.310	113.516	0.278760
Sum256Base	2318.293	113.076	0.277680
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2316.319	113.173	0.277917

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	332.978	787.272
SumBase_Narrow	42.269	6201.824	7.877614
SumBase_Unzip	27.832	9418.799	11.963845
SumBase	27.836	9417.353	11.962009
SumTraits	12.076	21707.435	27.572985
Sum128Base_Basic	332.793	787.710	1.000556
Sum128Base_Narrow	42.274	6201.104	7.876700
Sum128Base_Unzip	27.833	9418.460	11.963415
Sum128Base	27.836	9417.516	11.962216
Sum128AdvSimd_Narrow	42.279	6200.292	7.875669
Sum128AdvSimd_Unzip	27.836	9417.584	11.962303
Sum128AdvSimdB64_Unzip	12.074	21711.643	27.578329
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	12.072	21714.533	27.582001
Sum256Base_Basic	799.829	327.750	0.416311
Sum256Base_Narrow	1792.413	146.252	0.185771
Sum256Base_Unzip	1198.211	218.780	0.277896
Sum256Base	802.736	326.563	0.414804
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	801.808	326.941	0.415284

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	1429.226	183.417
SumBase	1424.676	184.003	1.003193
SumTraits	1513.809	173.168	0.944126
SumTraits_Int128	244.752	1071.061	5.839495
Sum128Base_Basic	200.942	1304.578	7.112644
Sum128Base	202.575	1294.058	7.055287
Sum128Traits	202.545	1294.248	7.056320
Sum128Traits_Int128	81.093	3232.651	17.624617
Sum256Base_Basic	2033.738	128.898	0.702758
Sum256Base	2326.175	112.693	0.614410
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2351.765	111.467	0.607725
Sum256Traits_Int128	2355.332	111.298	0.606804

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	439.540	596.405
SumBase_Narrow	84.543	3100.719	5.199016
SumBase_Unzip	55.646	4710.960	7.898929
SumBase	55.645	4710.982	7.898966
SumTraits	24.119	10868.672	18.223647
Sum128Base_Basic	437.445	599.262	1.004790
Sum128Base_Narrow	84.523	3101.456	5.200253
Sum128Base_Unzip	55.658	4709.914	7.897175
Sum128Base	55.644	4711.067	7.899109
Sum128AdvSimd_Narrow	84.532	3101.124	5.199695
Sum128AdvSimd_Unzip	55.640	4711.446	7.899744
Sum128AdvSimdB64_Unzip	24.118	10869.307	18.224711
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	24.114	10871.220	18.227919
Sum256Base_Basic	1000.292	262.068	0.439412
Sum256Base_Narrow	2571.101	101.958	0.170954
Sum256Base_Unzip	1573.676	166.581	0.279308
Sum256Base	1009.265	259.738	0.435506
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1005.788	260.635	0.437011

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
SumBase_Basic	646.842	405.267
SumBase_Unzip	111.287	2355.565	5.812377
SumBase	111.252	2356.312	5.814219
SumTraits	48.196	5439.144	13.421133
Sum128Base_Basic	645.487	406.118	1.002100
Sum128Base_Unzip	111.264	2356.053	5.813580
Sum128Base	111.271	2355.914	5.813238
Sum128AdvSimd_Unzip	111.265	2356.036	5.813538
Sum128AdvSimdB64_Unzip	48.198	5438.905	13.420543
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	48.205	5438.074	13.418492
Sum256Base_Basic	1427.296	183.665	0.453194
Sum256Base_Unzip	2171.886	120.699	0.297825
Sum256Base	1432.685	182.974	0.451490
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1433.095	182.922	0.451361

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	1027.796	255.055
SumBase	1034.570	253.384	0.993452
SumTraits	78.778	3327.620	13.046697
Sum128Base_Basic	1034.909	253.302	0.993127
Sum128Base_Move	118.854	2205.604	8.647576
Sum128Base_Unzip	101.644	2579.053	10.111769
Sum128Base	101.668	2578.421	10.109290
Sum128AdvSimd_Unzip	96.367	2720.258	10.665396
Sum128AdvSimdB64_Unzip	78.767	3328.093	13.048552
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.770	3327.954	13.048006
Sum256Base_Basic	2374.211	110.413	0.432900
Sum256Base	2376.718	110.297	0.432443
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2383.118	110.000	0.431282

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	280.046	936.075
SumBase_Widen	60.233	4352.183	4.649397
SumBase_Zip	40.079	6540.751	6.987424
SumBase	40.072	6541.766	6.988508
SumTraits	12.077	21706.230	23.188566
Sum128Base_Basic	280.015	936.179	1.000111
Sum128Base_Widen	260.256	1007.256	1.076042
Sum128Base_Zip	173.754	1508.704	1.611735
Sum128Base	173.790	1508.394	1.611403
Sum128AdvSimd_Widen	60.232	4352.228	4.649445
Sum128AdvSimd_Zip	40.067	6542.662	6.989465
Sum128AdvSimdB64_Zip	12.073	21713.311	23.196130
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	12.073	21712.826	23.195612
Sum256Base_Basic	764.387	342.947	0.366367
Sum256Base_Widen	2739.026	95.707	0.102243
Sum256Base_Zip	1133.263	231.318	0.247115
Sum256Base	767.255	341.665	0.364998
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	767.347	341.624	0.364953

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	1057.571	247.874
SumBase	1052.314	249.112	1.004995
SumTraits	1477.983	177.366	0.715550
SumTraits_Int128	244.792	1070.887	4.320292
Sum128Base_Basic	200.920	1304.716	5.263633
Sum128Base	202.705	1293.228	5.217287
Sum128Traits	202.669	1293.461	5.218227
Sum128Traits_Int128	81.028	3235.218	13.051880
Sum256Base_Basic	1934.213	135.530	0.546770
Sum256Base	2341.552	111.953	0.451654
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2281.566	114.897	0.463528
Sum256Traits_Int128	2286.010	114.673	0.462627

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	336.276	779.550
SumBase_Widen	120.454	2176.307	2.791748
SumBase_Zip	80.119	3271.931	4.197205
SumBase	80.106	3272.469	4.197895
SumTraits	24.116	10870.117	13.944091
Sum128Base_Basic	336.299	779.497	0.999932
Sum128Base_Widen	521.393	502.776	0.644957
Sum128Base_Zip	348.330	752.574	0.965395
Sum128Base	348.930	751.279	0.963734
Sum128AdvSimd_Widen	120.457	2176.237	2.791657
Sum128AdvSimd_Zip	80.119	3271.916	4.197185
Sum128AdvSimdB64_Zip	24.122	10867.613	13.940878
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	24.117	10869.847	13.943743
Sum256Base_Basic	961.588	272.616	0.349709
Sum256Base_Widen	4550.207	57.611	0.073903
Sum256Base_Zip	1412.570	185.580	0.238060
Sum256Base	948.912	276.257	0.354380
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	948.237	276.454	0.354633

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
SumBase_Basic	441.645	593.563
SumBase_Zip	160.196	1636.398	2.756905
SumBase	160.194	1636.411	2.756927
SumTraits	48.203	5438.384	9.162263
Sum128Base_Basic	441.530	593.717	1.000259
Sum128Base_Zip	697.135	376.030	0.633514
Sum128Base	696.647	376.294	0.633957
Sum128AdvSimd_Zip	160.195	1636.402	2.756913
Sum128AdvSimdB64_Zip	48.200	5438.627	9.162674
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	48.196	5439.129	9.163518
Sum256Base_Basic	1350.229	194.148	0.327089
Sum256Base_Zip	2026.536	129.356	0.217931
Sum256Base	1350.768	194.070	0.326958
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1345.591	194.817	0.328216

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	650.497	402.990
SumBase	649.988	403.306	1.000784
SumTraits	78.777	3327.671	8.257451
Sum128Base_Basic	650.364	403.072	1.000205
Sum128Base_Move	118.197	2217.855	5.503497
Sum128Base_Zip	101.613	2579.837	6.401739
Sum128Base	101.575	2580.797	6.404120
Sum128AdvSimd_Zip	96.368	2720.231	6.750119
Sum128AdvSimdB64_Zip	78.780	3327.549	8.257148
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.793	3326.992	8.255767
Sum256Base_Basic	2142.407	122.360	0.303629
Sum256Base	2141.522	122.410	0.303755
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2154.345	121.682	0.301947

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	257.358	1018.597
SumBase_Narrow	35.146	7458.657	7.322484
SumBase_Unzip	25.374	10331.239	10.142622
SumBase	25.375	10330.663	10.142056
SumTraits	12.066	21726.068	21.329415
Sum128Base_Basic	257.502	1018.028	0.999442
Sum128Base_Narrow	35.152	7457.403	7.321253
Sum128Base_Unzip	25.373	10331.808	10.143180
Sum128Base	25.379	10329.227	10.140646
Sum128AdvSimd_Narrow	35.152	7457.396	7.321246
Sum128AdvSimd_ShuffleX	50.904	5149.796	5.055777
Sum128AdvSimd_Unzip	25.368	10333.810	10.145146
Sum128AdvSimdB64_ShuffleX	20.320	12900.863	12.665332
Sum128AdvSimdB64_Unzip	12.064	21729.573	21.332856
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	12.063	21731.129	21.334383
Sum256Base_Basic	256.397	1022.414	1.003748
Sum256Base_Narrow	33.764	7764.056	7.622307
Sum256Base_Unzip	582.232	450.240	0.442019
Sum256Base	256.511	1021.958	1.003300
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	256.499	1022.010	1.003351
Sum512Base_Basic	282.786	927.004	0.910080
Sum512Base_Narrow	28.408	9227.955	9.059480
Sum512Base_Unzip	610.382	429.475	0.421634
Sum512Base	282.410	928.239	0.911292
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	282.384	928.324	0.911375

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	589.863	444.415
SumBase	590.114	444.226	0.999575
SumTraits	627.763	417.585	0.939628
SumTraits_Int128	80.987	3236.875	7.283452
Sum128Base_Basic	88.939	2947.469	6.632246
Sum128Base	89.265	2936.684	6.607979
Sum128Traits	89.309	2935.244	6.604738
Sum128Traits_Int128	80.993	3236.633	7.282908
Sum256Base_Basic	651.543	402.343	0.905332
Sum256Base	41.041	6387.344	14.372480
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	41.058	6384.757	14.366659
Sum256Traits_Int128	41.052	6385.732	14.368853
Sum512Base_Basic	674.817	388.467	0.874108
Sum512Base_Move	22.823	11486.151	25.845559
Sum512Base_Unzip	22.774	11510.561	25.900484
Sum512Base	22.773	11510.961	25.901385
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	22.773	11510.954	25.901369
Sum512Traits_Int128	22.775	11510.307	25.899914

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	283.385	925.044
SumBase_Narrow	70.288	3729.578	4.031785
SumBase_Unzip	50.742	5166.212	5.584829
SumBase	50.743	5166.148	5.584761
SumTraits	24.112	10871.837	11.752780
Sum128Base_Basic	283.396	925.009	0.999962
Sum128Base_Narrow	70.297	3729.096	4.031264
Sum128Base_Unzip	50.735	5166.938	5.585615
Sum128Base	50.752	5165.206	5.583742
Sum128AdvSimd_Narrow	70.299	3728.979	4.031137
Sum128AdvSimd_ShuffleX	102.505	2557.389	2.764614
Sum128AdvSimd_Unzip	50.781	5162.239	5.580535
Sum128AdvSimdB64_ShuffleX	40.619	6453.776	6.976725
Sum128AdvSimdB64_Unzip	24.114	10870.871	11.751737
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	24.111	10872.351	11.753337
Sum256Base_Basic	281.838	930.124	1.005491
Sum256Base_Narrow	67.623	3876.531	4.190646
Sum256Base_Unzip	625.132	419.342	0.453321
Sum256Base	281.856	930.063	1.005426
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	281.864	930.036	1.005397
Sum512Base_Basic	299.932	874.013	0.944834
Sum512Base_Narrow	58.314	4495.405	4.859668
Sum512Base_Unzip	680.997	384.942	0.416133
Sum512Base	299.985	873.856	0.944665
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	299.949	873.961	0.944778

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
# Sum512Base_Basic	-467656742
SumBase_Basic	378.229	693.084
SumBase_Unzip	101.489	2582.983	3.726799
SumBase	101.460	2583.714	3.727853
SumTraits	48.203	5438.338	7.846582
Sum128Base_Basic	378.109	693.303	1.000316
Sum128Base_Unzip	101.458	2583.774	3.727940
Sum128Base	101.458	2583.780	3.727948
Sum128AdvSimd_ShuffleX	207.083	1265.887	1.826456
Sum128AdvSimd_Unzip	101.452	2583.923	3.728155
Sum128AdvSimdB64_ShuffleX	81.538	3215.011	4.638705
Sum128AdvSimdB64_Unzip	48.197	5439.044	7.847602
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	48.214	5437.131	7.844841
Sum256Base_Basic	365.834	716.566	1.033881
Sum256Base_Unzip	785.970	333.529	0.481225
Sum256Base	365.856	716.522	1.033818
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	365.967	716.306	1.033506
Sum512Base_Basic	407.909	642.653	0.927237
Sum512Base_Unzip	865.356	302.932	0.437079
Sum512Base	407.528	643.254	0.928104
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	405.762	646.053	0.932143

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	578.269	453.325
SumBase	578.346	453.265	0.999867
SumTraits	78.767	3328.090	7.341506
Sum128Base_Basic	578.134	453.432	1.000235
Sum128Base_Move	77.987	3361.398	7.414981
Sum128Base_Unzip	77.101	3400.003	7.500141
Sum128Base	77.112	3399.541	7.499121
Sum128AdvSimd_ShuffleX	423.033	619.678	1.366961
Sum128AdvSimd_Unzip	86.725	3022.706	6.667853
Sum128AdvSimdB64_ShuffleX	166.365	1575.717	3.475907
Sum128AdvSimdB64_Unzip	78.774	3327.803	7.340873
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.769	3327.990	7.341285
Sum256Base_Basic	599.935	436.954	0.963886
Sum256Base	599.789	437.061	0.964122
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	599.917	436.967	0.963916
Sum512Base_Basic	655.553	399.882	0.882108
Sum512Base	656.374	399.382	0.881006
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	656.885	399.072	0.880321

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	352.241	744.217
SumBase_Widen	60.230	4352.411	5.848309
SumBase_Zip	36.448	7192.371	9.664347
SumBase	36.445	7192.862	9.665007
SumTraits	12.063	21732.073	29.201259
Sum128Base_Basic	352.248	744.203	0.999981
Sum128Base_Widen	62.342	4204.926	5.650135
Sum128Base_Zip	39.748	6595.133	8.861842
Sum128Base	39.760	6593.195	8.859237
Sum128AdvSimd_ShuffleX	50.916	5148.608	6.918155
Sum128AdvSimd_Widen	60.238	4351.779	5.847460
Sum128AdvSimd_Zip	36.455	7190.883	9.662347
Sum128AdvSimdB64_ShuffleX	20.332	12893.303	17.324656
Sum128AdvSimdB64_Zip	12.065	21727.385	29.194960
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	12.066	21726.277	29.193471
Sum256Base_Basic	341.853	766.832	1.030387
Sum256Base_Widen	54.807	4783.043	6.426947
Sum256Base_Zip	764.773	342.774	0.460583
Sum256Base	341.831	766.882	1.030455
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	341.875	766.783	1.030322
Sum512Base_Basic	349.639	749.756	1.007442
Sum512Base_Widen	471.730	555.708	0.746701
Sum512Base_Zip	795.657	329.469	0.442705
Sum512Base	349.717	749.589	1.007218
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	349.656	749.719	1.007394

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	1176.517	222.814
SumBase	1179.025	222.340	0.997873
SumTraits	627.382	417.838	1.875279
SumTraits_Int128	80.985	3236.946	14.527600
Sum128Base_Basic	88.961	2946.745	13.225161
Sum128Base	89.127	2941.254	13.200518
Sum128Traits	89.168	2939.879	13.194344
Sum128Traits_Int128	80.983	3237.030	14.527974
Sum256Base_Basic	790.811	331.488	1.487735
Sum256Base	41.014	6391.559	28.685683
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	41.017	6391.135	28.683781
Sum256Traits_Int128	41.020	6390.599	28.681375
Sum512Base_Basic	754.702	347.348	1.558916
Sum512Base_Move	22.885	11454.688	51.409295
Sum512Base_Zip	22.890	11452.205	51.398152
Sum512Base	22.889	11452.774	51.400709
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	22.890	11452.215	51.398196
Sum512Traits_Int128	22.894	11450.482	51.390421

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	403.527	649.632
SumBase_Widen	120.420	2176.909	3.350986
SumBase_Zip	72.874	3597.236	5.537341
SumBase	72.875	3597.160	5.537225
SumTraits	24.114	10870.869	16.733879
Sum128Base_Basic	403.495	649.683	1.000078
Sum128Base_Widen	124.638	2103.236	3.237579
Sum128Base_Zip	79.506	3297.168	5.075437
Sum128Base	79.504	3297.263	5.075584
Sum128AdvSimd_ShuffleX	102.443	2558.932	3.939047
Sum128AdvSimd_Widen	120.457	2176.243	3.349961
Sum128AdvSimd_Zip	72.882	3596.824	5.536707
Sum128AdvSimdB64_ShuffleX	40.665	6446.506	9.923315
Sum128AdvSimdB64_Zip	24.112	10871.911	16.735484
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	24.112	10871.877	16.735430
Sum256Base_Basic	382.151	685.970	1.055936
Sum256Base_Widen	109.606	2391.693	3.681610
Sum256Base_Zip	835.539	313.743	0.482954
Sum256Base	382.068	686.119	1.056166
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	382.066	686.123	1.056171
Sum512Base_Basic	401.621	652.715	1.004746
Sum512Base_Widen	1012.235	258.976	0.398649
Sum512Base_Zip	854.901	306.637	0.472016
Sum512Base	401.733	652.533	1.004466
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	401.918	652.232	1.004002

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
# Sum512Base_Basic	-467656742
SumBase_Basic	504.384	519.731
SumBase_Zip	145.748	1798.616	3.460670
SumBase	145.707	1799.112	3.461625
SumTraits	48.208	5437.779	10.462688
Sum128Base_Basic	502.441	521.741	1.003868
Sum128Base_Zip	144.534	1813.714	3.489720
Sum128Base	144.542	1813.617	3.489534
Sum128AdvSimd_ShuffleX	207.127	1265.620	2.435147
Sum128AdvSimd_Zip	145.749	1798.600	3.460640
Sum128AdvSimdB64_ShuffleX	81.527	3215.429	6.186723
Sum128AdvSimdB64_Zip	48.205	5438.066	10.463241
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	48.205	5438.142	10.463386
Sum256Base_Basic	456.162	574.673	1.105714
Sum256Base_Zip	991.363	264.428	0.508779
Sum256Base	456.091	574.763	1.105887
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	456.198	574.627	1.105625
Sum512Base_Basic	496.814	527.651	1.015239
Sum512Base_Zip	1037.234	252.734	0.486278
Sum512Base	496.258	528.242	1.016376
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	496.366	528.127	1.016155

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	651.561	402.332
SumBase	654.186	400.718	0.995987
SumTraits	78.761	3328.345	8.272622
Sum128Base_Basic	645.311	406.229	1.009684
Sum128Base_Move	77.974	3361.925	8.356087
Sum128Base_Zip	77.084	3400.758	8.452605
Sum128Base	77.087	3400.644	8.452324
Sum128AdvSimd_ShuffleX	423.143	619.517	1.539813
Sum128AdvSimd_Zip	86.730	3022.540	7.512543
Sum128AdvSimdB64_ShuffleX	166.080	1578.423	3.923182
Sum128AdvSimdB64_Zip	78.772	3327.889	8.271491
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.766	3328.129	8.272087
Sum256Base_Basic	744.725	352.001	0.874901
Sum256Base	744.651	352.036	0.874988
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	745.431	351.667	0.874072
Sum512Base_Basic	825.933	317.391	0.788879
Sum512Base	825.926	317.394	0.788885
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	825.421	317.588	0.789368

```

### AWS Arm t4g.small
`Neoverse-N1`

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
Check-SumBase_Unzip	Check `SumBase_Unzip` mismatch. 132!=114
Check-SumBase	Check `SumBase` mismatch. 132!=114
Check-SumTraits	Check `SumTraits` mismatch. 132!=114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	1260.702	207.935
SumBase_Unzip	574.356	456.414	2.194983
SumBase	571.792	458.460	2.204825
SumTraits	575.574	455.448	2.190340
Sum128Base_Basic	2627.132	99.783	0.479878
Sum128Base	2634.031	99.522	0.478621
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2627.451	99.771	0.479819
Sum256Base_Basic	2598.919	100.867	0.485087
Sum256Base	2662.432	98.460	0.473515
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2845.511	92.125	0.443049

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	7402.733	35.412
SumBase	7853.481	33.379	0.942605
SumTraits	8687.367	30.175	0.852126
SumTraits_Int128	1367.342	191.718	5.413959
Sum128Base_Basic	2191.130	119.639	3.378500
Sum128Base	2177.214	120.403	3.400094
Sum128Traits	2222.446	117.953	3.330895
Sum128Traits_Int128	1931.852	135.696	3.831935
Sum256Base_Basic	9131.665	28.707	0.810666
Sum256Base	13544.362	19.354	0.546555
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	16619.099	15.774	0.445435
Sum256Traits_Int128	9344.341	28.054	0.792216

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1754.769	149.389
SumBase_Unzip	632.001	414.784	2.776528
SumBase	634.067	413.433	2.767482
SumTraits	633.180	414.012	2.771358
Sum128Base_Basic	3641.520	71.988	0.481878
Sum128Base	3647.767	71.864	0.481053
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	3661.868	71.588	0.479201
Sum256Base_Basic	3848.256	68.120	0.455991
Sum256Base	3904.389	67.141	0.449435
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4402.854	59.540	0.398553

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
SumBase_Basic	2313.417	113.315
SumBase_Unzip	1342.255	195.301	1.723530
SumBase	1344.689	194.948	1.720410
SumTraits	1343.092	195.179	1.722455
Sum128Base_Basic	5274.435	49.701	0.438609
Sum128Base	5252.408	49.909	0.440449
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	5245.762	49.973	0.441007
Sum256Base_Basic	5831.915	44.950	0.396682
Sum256Base	5997.717	43.707	0.385716
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	6961.659	37.655	0.332308

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	2869.206	91.365
SumBase	2866.325	91.456	1.001005
SumTraits	2883.571	90.910	0.995018
Sum128Base_Basic	5300.268	49.459	0.541332
Sum128Base	3903.303	67.160	0.735071
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	3894.329	67.314	0.736765
Sum256Base_Basic	8911.931	29.415	0.321951
Sum256Base	9174.352	28.574	0.312742
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	11300.995	23.197	0.253890

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	1194.618	219.437
SumBase_Zip	206.774	1267.779	5.777403
SumBase	206.534	1269.255	5.784130
SumTraits	206.654	1268.518	5.780773
Sum128Base_Basic	2204.815	118.896	0.541823
Sum128Base	2205.427	118.863	0.541672
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2205.331	118.868	0.541696
Sum256Base_Basic	2151.365	121.850	0.555284
Sum256Base	2196.037	119.371	0.543988
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2410.175	108.766	0.495656

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	5377.134	48.752
SumBase	5661.525	46.303	0.949768
SumTraits	6444.091	40.680	0.834429
SumTraits_Int128	1370.733	191.244	3.922816
Sum128Base_Basic	2185.420	119.951	2.460458
Sum128Base	2235.944	117.241	2.404860
Sum128Traits	2182.797	120.095	2.463414
Sum128Traits_Int128	1925.305	136.157	2.792874
Sum256Base_Basic	7680.938	34.129	0.700062
Sum256Base	13551.591	19.344	0.396790
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	16687.150	15.709	0.322232
Sum256Traits_Int128	9401.836	27.882	0.571924

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1552.631	168.839
SumBase_Zip	412.672	635.235	3.762384
SumBase	412.558	635.411	3.763423
SumTraits	412.662	635.252	3.762479
Sum128Base_Basic	3236.014	81.008	0.479797
Sum128Base	3289.977	79.680	0.471928
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	3286.414	79.766	0.472439
Sum256Base_Basic	3420.904	76.630	0.453866
Sum256Base	3487.154	75.174	0.445243
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3978.038	65.898	0.390301

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
SumBase_Basic	1856.892	141.174
SumBase_Zip	4034.557	64.975	0.460247
SumBase	1857.106	141.157	0.999885
SumTraits	1857.076	141.160	0.999901
Sum128Base_Basic	5347.435	49.022	0.347249
Sum128Base	5347.215	49.024	0.347263
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	5338.833	49.101	0.347808
Sum256Base_Basic	5074.814	51.656	0.365903
Sum256Base	5219.166	50.227	0.355783
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	6164.795	42.523	0.301209

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	1885.820	139.008
SumBase	1898.662	138.068	0.993236
SumTraits	1899.354	138.017	0.992874
Sum128Base_Basic	3991.229	65.680	0.472491
Sum128Base	3905.967	67.114	0.482805
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	3916.517	66.933	0.481504
Sum256Base_Basic	7444.808	35.212	0.253307
Sum256Base	7716.919	33.970	0.244375
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	9814.422	26.710	0.192148

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	1242.316	211.012
SumBase_Unzip	500.025	524.261	2.484506
SumBase	500.041	524.245	2.484431
SumTraits	40.112	6535.359	30.971459
Sum128Base_Basic	2315.253	113.225	0.536579
Sum128Base	2320.167	112.985	0.535443
Sum128AdvSimd_Narrow	135.135	1939.874	9.193180
Sum128AdvSimd_Unzip	89.774	2920.055	13.838317
Sum128AdvSimdB64_Unzip	39.947	6562.346	31.099354
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	40.070	6542.225	31.003998
Sum256Base_Basic	2220.423	118.060	0.559495
Sum256Base	2232.176	117.439	0.556549
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2362.210	110.974	0.525913

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	3274.141	80.065
SumBase	3208.680	81.698	1.020401
SumTraits	3239.734	80.915	1.010620
SumTraits_Int128	591.423	443.242	5.536035
Sum128Base_Basic	2167.482	120.944	1.510573
Sum128Base	2228.021	117.658	1.469529
Sum128Traits	529.082	495.470	6.188345
Sum128Traits_Int128	158.900	1649.746	20.605087
Sum256Base_Basic	6329.930	41.413	0.517248
Sum256Base	11584.281	22.629	0.282636
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	14434.612	18.161	0.226826
Sum256Traits_Int128	7213.969	36.338	0.453861

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1743.803	150.329
SumBase_Unzip	547.342	478.940	3.185948
SumBase	549.943	476.675	3.170881
SumTraits	83.743	3130.351	20.823355
Sum128Base_Basic	3374.186	77.691	0.516807
Sum128Base	3399.226	77.119	0.513000
Sum128AdvSimd_Narrow	275.637	951.047	6.326442
Sum128AdvSimd_Unzip	186.985	1401.955	9.325918
Sum128AdvSimdB64_Unzip	83.321	3146.197	20.928761
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	83.951	3122.580	20.771657
Sum256Base_Basic	3049.172	85.972	0.571894
Sum256Base	3061.262	85.633	0.569636
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3288.801	79.708	0.530225

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
SumBase_Basic	2246.648	116.682
SumBase_Unzip	1102.293	237.817	2.038159
SumBase	1104.248	237.396	2.034551
SumTraits	165.726	1581.791	13.556399
Sum128Base_Basic	4970.840	52.736	0.451966
Sum128Base	4920.331	53.278	0.456605
Sum128AdvSimd_Unzip	374.810	699.406	5.994105
Sum128AdvSimdB64_Unzip	167.409	1565.891	13.420131
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	166.642	1573.098	13.481893
Sum256Base_Basic	4557.939	57.514	0.492909
Sum256Base	4575.249	57.296	0.491044
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4605.072	56.925	0.487864

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	3025.833	86.635
SumBase	3026.978	86.603	0.999622
SumTraits	220.179	1190.596	13.742616
Sum128Base_Basic	4676.713	56.053	0.647000
Sum128Base	1991.331	131.643	1.519503
Sum128AdvSimd_Unzip	276.010	949.763	10.962769
Sum128AdvSimdB64_Unzip	222.567	1177.820	13.595145
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	220.046	1191.313	13.750895
Sum256Base_Basic	6213.543	42.189	0.486974
Sum256Base	6232.283	42.062	0.485510
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	6185.774	42.379	0.489160

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	1172.006	223.671
SumBase_Zip	175.894	1490.353	6.663144
SumBase	190.839	1373.638	6.141325
SumTraits	40.152	6528.782	29.189195
Sum128Base_Basic	2191.304	119.629	0.534844
Sum128Base	2190.774	119.658	0.534974
Sum128AdvSimd_Widen	233.012	1125.025	5.029816
Sum128AdvSimd_Zip	163.222	1606.053	7.180421
Sum128AdvSimdB64_Zip	40.059	6544.011	29.257279
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	39.951	6561.612	29.335972
Sum256Base_Basic	2188.018	119.809	0.535647
Sum256Base	2247.511	116.637	0.521468
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2379.920	110.148	0.492456

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	2338.491	112.100
SumBase	2330.502	112.484	1.003428
SumTraits	2335.461	112.245	1.001297
SumTraits_Int128	612.312	428.122	3.819118
Sum128Base_Basic	2176.956	120.418	1.074202
Sum128Base	2167.052	120.968	1.079111
Sum128Traits	529.175	495.383	4.419130
Sum128Traits_Int128	146.728	1786.603	15.937636
Sum256Base_Basic	7060.764	37.127	0.331195
Sum256Base	11477.318	22.840	0.203749
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	14369.414	18.243	0.162741
Sum256Traits_Int128	7144.436	36.692	0.327316

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1508.220	173.810
SumBase_Zip	369.048	710.325	4.086785
SumBase	370.893	706.791	4.066455
SumTraits	82.854	3163.915	18.203274
Sum128Base_Basic	3075.866	85.226	0.490340
Sum128Base	3115.445	84.143	0.484111
Sum128AdvSimd_Widen	524.520	499.779	2.875430
Sum128AdvSimd_Zip	324.488	807.871	4.648004
Sum128AdvSimdB64_Zip	82.379	3182.182	18.308371
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	81.341	3222.778	18.541934
Sum256Base_Basic	3160.054	82.956	0.477277
Sum256Base	3198.905	81.948	0.471480
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3410.235	76.870	0.442263

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
SumBase_Basic	1820.706	143.979
SumBase_Zip	4267.373	61.430	0.426657
SumBase	1824.757	143.660	0.997780
SumTraits	164.040	1598.046	11.099137
Sum128Base_Basic	4378.435	59.872	0.415835
Sum128Base	4684.584	55.959	0.388659
Sum128AdvSimd_Zip	658.179	398.287	2.766279
Sum128AdvSimdB64_Zip	164.792	1590.752	11.048475
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	164.396	1594.589	11.075126
Sum256Base_Basic	4518.035	58.022	0.402986
Sum256Base	4527.140	57.905	0.402176
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	5241.567	50.013	0.347359

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	1788.474	146.574
SumBase	1794.298	146.098	0.996754
SumTraits	221.946	1181.117	8.058156
Sum128Base_Basic	3706.097	70.733	0.482576
Sum128Base	2014.202	130.148	0.887932
Sum128AdvSimd_Zip	275.775	950.572	6.485266
Sum128AdvSimdB64_Zip	221.699	1182.431	8.067119
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	221.977	1180.949	8.057011
Sum256Base_Basic	6786.388	38.628	0.263538
Sum256Base	6754.920	38.808	0.264766
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	6763.364	38.759	0.264436

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	1025.856	255.537
SumBase_Narrow	133.225	1967.675	7.700163
SumBase_Unzip	91.720	2858.096	11.184676
SumBase	91.999	2849.434	11.150778
SumTraits	40.842	6418.487	25.117664
Sum128Base_Basic	1025.475	255.632	1.000372
Sum128Base_Narrow	132.774	1974.361	7.726326
Sum128Base_Unzip	91.745	2857.316	11.181622
Sum128Base	91.668	2859.716	11.191013
Sum128AdvSimd_Narrow	133.282	1966.841	7.696899
Sum128AdvSimd_Unzip	92.035	2848.322	11.146427
Sum128AdvSimdB64_Unzip	40.839	6419.013	25.119721
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	41.049	6386.064	24.990783
Sum256Base_Basic	2539.321	103.234	0.403988
Sum256Base_Narrow	5475.876	47.873	0.187341
Sum256Base_Unzip	3632.722	72.162	0.282393
Sum256Base	2528.123	103.691	0.405778
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2527.945	103.698	0.405806

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	3881.222	67.542
SumBase	3965.757	66.102	0.978684
SumTraits	3104.584	84.438	1.250158
SumTraits_Int128	605.870	432.674	6.406036
Sum128Base_Basic	530.899	493.774	7.310656
Sum128Base	530.330	494.304	7.318506
Sum128Traits	530.054	494.561	7.322311
Sum128Traits_Int128	123.892	2115.910	31.327504
Sum256Base_Basic	5205.750	50.357	0.745564
Sum256Base	5143.257	50.968	0.754623
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	5143.028	50.971	0.754657
Sum256Traits_Int128	5139.122	51.009	0.755231

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1461.663	179.346
SumBase_Narrow	263.374	995.330	5.549759
SumBase_Unzip	183.644	1427.459	7.959224
SumBase	183.547	1428.209	7.963408
SumTraits	79.373	3302.669	18.415020
Sum128Base_Basic	1460.405	179.501	1.000861
Sum128Base_Narrow	263.486	994.906	5.547396
Sum128Base_Unzip	183.724	1426.839	7.955771
Sum128Base	184.405	1421.565	7.926362
Sum128AdvSimd_Narrow	263.496	994.869	5.547193
Sum128AdvSimd_Unzip	184.223	1422.973	7.934213
Sum128AdvSimdB64_Unzip	79.489	3297.866	18.388244
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	79.432	3300.219	18.401364
Sum256Base_Basic	3511.013	74.663	0.416308
Sum256Base_Narrow	6481.540	40.445	0.225512
Sum256Base_Unzip	5063.401	51.772	0.288672
Sum256Base	3525.847	74.349	0.414556
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3526.263	74.340	0.414508

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
SumBase_Basic	2126.388	123.281
SumBase_Unzip	364.048	720.080	5.840948
SumBase	363.900	720.373	5.843327
SumTraits	159.055	1648.131	13.368864
Sum128Base_Basic	2095.268	125.112	1.014852
Sum128Base_Unzip	366.963	714.360	5.794553
Sum128Base	367.199	713.902	5.790838
Sum128AdvSimd_Unzip	366.235	715.782	5.806083
Sum128AdvSimdB64_Unzip	159.164	1647.007	13.359745
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	159.188	1646.755	13.357699
Sum256Base_Basic	4549.629	57.619	0.467376
Sum256Base_Unzip	6688.762	39.192	0.317905
Sum256Base	4555.484	57.545	0.466775
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4550.970	57.602	0.467239

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	3447.665	76.035
SumBase	3462.960	75.699	0.995583
SumTraits	212.610	1232.980	16.215900
Sum128Base_Basic	3458.487	75.797	0.996871
Sum128Base_Move	369.527	709.405	9.329948
Sum128Base_Unzip	369.796	708.888	9.323155
Sum128Base	369.842	708.801	9.322002
Sum128AdvSimd_Unzip	265.258	988.262	12.997426
Sum128AdvSimdB64_Unzip	212.230	1235.188	16.244941
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	212.349	1234.496	16.235839
Sum256Base_Basic	5863.484	44.708	0.587989
Sum256Base	5910.485	44.352	0.583313
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	5893.593	44.479	0.584985

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	775.615	337.982
SumBase_Widen	240.035	1092.107	3.231256
SumBase_Zip	160.449	1633.814	4.834023
SumBase	161.831	1619.867	4.792759
SumTraits	41.357	6338.551	18.754101
Sum128Base_Basic	775.618	337.981	0.999996
Sum128Base_Widen	1204.090	217.711	0.644150
Sum128Base_Zip	567.198	462.174	1.367450
Sum128Base	564.635	464.271	1.373656
Sum128AdvSimd_Widen	239.082	1096.460	3.244136
Sum128AdvSimd_Zip	160.867	1629.574	4.821478
Sum128AdvSimdB64_Zip	41.286	6349.519	18.786551
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	40.810	6423.472	19.005359
Sum256Base_Basic	2311.883	113.390	0.335491
Sum256Base_Widen	7695.714	34.064	0.100785
Sum256Base_Zip	3502.904	74.836	0.221421
Sum256Base	2322.244	112.884	0.333994
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2321.269	112.931	0.334134

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	2618.007	100.131
SumBase	2381.409	110.079	1.099352
SumTraits	3097.896	84.620	0.845092
SumTraits_Int128	603.017	434.721	4.341513
Sum128Base_Basic	529.686	494.904	4.942562
Sum128Base	529.375	495.196	4.945469
Sum128Traits	529.365	495.204	4.945558
Sum128Traits_Int128	123.601	2120.890	21.181122
Sum256Base_Basic	4491.324	58.367	0.582903
Sum256Base	5166.145	50.743	0.506762
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	5166.869	50.736	0.506691
Sum256Traits_Int128	5164.260	50.761	0.506947

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1041.478	251.704
SumBase_Widen	478.059	548.351	2.178554
SumBase_Zip	325.979	804.174	3.194921
SumBase	326.831	802.077	3.186589
SumTraits	80.346	3262.679	12.962367
Sum128Base_Basic	1040.619	251.912	1.000825
Sum128Base_Widen	2404.926	109.003	0.433060
Sum128Base_Zip	1131.902	231.596	0.920113
Sum128Base	1124.509	233.119	0.926162
Sum128AdvSimd_Widen	477.715	548.745	2.180122
Sum128AdvSimd_Zip	327.258	801.031	3.182433
Sum128AdvSimdB64_Zip	79.584	3293.917	13.086475
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	79.922	3279.995	13.031164
Sum256Base_Basic	3054.924	85.810	0.340918
Sum256Base_Widen	14350.111	18.268	0.072576
Sum256Base_Zip	4515.985	58.048	0.230620
Sum256Base	3074.558	85.262	0.338741
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3074.227	85.272	0.338777

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
SumBase_Basic	1304.495	200.954
SumBase_Zip	647.639	404.768	2.014230
SumBase	648.712	404.099	2.010899
SumTraits	159.795	1640.506	8.163572
Sum128Base_Basic	1304.824	200.904	0.999747
Sum128Base_Zip	2251.568	116.427	0.579372
Sum128Base	2243.198	116.862	0.581533
Sum128AdvSimd_Zip	648.725	404.091	2.010858
Sum128AdvSimdB64_Zip	159.830	1640.138	8.161742
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	159.522	1643.313	8.177537
Sum256Base_Basic	3886.582	67.448	0.335641
Sum256Base_Zip	5719.962	45.830	0.228060
Sum256Base	3888.077	67.423	0.335511
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3888.425	67.416	0.335481

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
SumBase_Basic	1749.198	149.865
SumBase	1784.816	146.875	0.980044
SumTraits	212.525	1233.472	8.230540
Sum128Base_Basic	1785.309	146.834	0.979773
Sum128Base_Move	369.884	708.719	4.729040
Sum128Base_Zip	369.787	708.905	4.730283
Sum128Base	369.689	709.093	4.731539
Sum128AdvSimd_Zip	265.523	987.276	6.587756
Sum128AdvSimdB64_Zip	212.170	1235.540	8.244339
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	212.572	1233.199	8.228722
Sum256Base_Basic	4535.002	57.805	0.385711
Sum256Base	4539.933	57.742	0.385292
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4508.382	58.146	0.387988

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	965.267	271.577
SumBase_Narrow	99.228	2641.844	9.727805
SumBase_Unzip	79.227	3308.780	12.183599
SumBase	79.233	3308.520	12.182642
SumTraits	39.718	6600.189	24.303235
Sum128Base_Basic	964.896	271.681	1.000385
Sum128Base_Narrow	99.211	2642.283	9.729423
Sum128Base_Unzip	79.219	3309.106	12.184800
Sum128Base	79.221	3309.015	12.184463
Sum128AdvSimd_Narrow	99.178	2643.154	9.732628
Sum128AdvSimd_ShuffleX	157.923	1659.946	6.112257
Sum128AdvSimd_Unzip	79.220	3309.047	12.184583
Sum128AdvSimdB64_ShuffleX	66.038	3969.605	14.616892
Sum128AdvSimdB64_Unzip	39.728	6598.490	24.296980
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	39.718	6600.112	24.302950
Sum256Base_Basic	852.883	307.362	1.131770
Sum256Base_Narrow	97.720	2682.591	9.877845
Sum256Base_Unzip	1914.505	136.925	0.504186
Sum256Base	853.433	307.164	1.131041
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	853.159	307.263	1.131403
Sum512Base_Basic	785.445	333.752	1.228943
Sum512Base_Narrow	92.371	2837.962	10.449952
Sum512Base_Unzip	1857.001	141.165	0.519799
Sum512Base	785.668	333.657	1.228594
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	786.067	333.488	1.227971

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	1956.519	133.985
SumBase	1915.256	136.872	1.021545
SumTraits	1833.331	142.988	1.067194
SumTraits_Int128	125.574	2087.561	15.580567
Sum128Base_Basic	385.424	680.145	5.076279
Sum128Base	386.147	678.870	5.066766
Sum128Traits	385.978	679.168	5.068987
Sum128Traits_Int128	125.296	2092.196	15.615165
Sum256Base_Basic	1491.158	175.799	1.312080
Sum256Base	78.306	3347.706	24.985695
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	78.051	3358.608	25.067061
Sum256Traits_Int128	78.138	3354.869	25.039157
Sum512Base_Basic	1394.736	187.952	1.402788
Sum512Base_Move	70.738	3705.827	27.658541
Sum512Base_Unzip	71.281	3677.618	27.448002
Sum512Base	71.146	3684.613	27.500210
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	70.594	3713.386	27.714957
Sum512Traits_Int128	70.715	3707.026	27.667490

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	1248.515	209.965
SumBase_Narrow	206.774	1267.781	6.038067
SumBase_Unzip	163.358	1604.720	7.642812
SumBase	163.319	1605.104	7.644642
SumTraits	82.029	3195.761	15.220475
Sum128Base_Basic	1248.694	209.935	0.999857
Sum128Base_Narrow	206.830	1267.439	6.036442
Sum128Base_Unzip	163.932	1599.101	7.616051
Sum128Base	163.967	1598.762	7.614437
Sum128AdvSimd_Narrow	207.758	1261.779	6.009482
Sum128AdvSimd_ShuffleX	317.318	826.125	3.934589
Sum128AdvSimd_Unzip	163.439	1603.927	7.639036
Sum128AdvSimdB64_ShuffleX	136.619	1918.800	9.138683
Sum128AdvSimdB64_Unzip	81.516	3215.840	15.316105
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	81.615	3211.973	15.297688
Sum256Base_Basic	1119.150	234.235	1.115593
Sum256Base_Narrow	197.481	1327.441	6.322213
Sum256Base_Unzip	2483.770	105.543	0.502669
Sum256Base	1120.164	234.023	1.114583
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1119.946	234.068	1.114800
Sum512Base_Basic	1022.382	256.405	1.221183
Sum512Base_Narrow	188.614	1389.843	6.619416
Sum512Base_Unzip	2471.441	106.069	0.505177
Sum512Base	1023.496	256.126	1.219853
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1031.016	254.258	1.210956

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
# Sum512Base_Basic	-467656742
SumBase_Basic	1745.983	150.141
SumBase_Unzip	333.703	785.560	5.232145
SumBase	331.931	789.755	5.260080
SumTraits	167.694	1563.229	10.411726
Sum128Base_Basic	1747.108	150.045	0.999357
Sum128Base_Unzip	331.015	791.941	5.274640
Sum128Base	331.395	791.032	5.268586
Sum128AdvSimd_ShuffleX	634.965	412.848	2.749732
Sum128AdvSimd_Unzip	331.211	791.471	5.271511
Sum128AdvSimdB64_ShuffleX	268.884	974.935	6.493453
Sum128AdvSimdB64_Unzip	163.476	1603.566	10.680390
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	163.631	1602.045	10.670260
Sum256Base_Basic	1310.220	200.076	1.332588
Sum256Base_Unzip	2964.310	88.433	0.589002
Sum256Base	1312.356	199.751	1.330420
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1310.665	200.008	1.332136
Sum512Base_Basic	1179.549	222.241	1.480212
Sum512Base_Unzip	2614.401	100.269	0.667833
Sum512Base	1182.469	221.692	1.476557
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1179.762	222.201	1.479946

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	1600.242	163.815
SumBase	1658.873	158.025	0.964656
SumTraits	214.746	1220.719	7.451804
Sum128Base_Basic	1596.313	164.218	1.002461
Sum128Base_Move	270.908	967.651	5.906966
Sum128Base_Unzip	296.041	885.498	5.405466
Sum128Base	296.112	885.285	5.404168
Sum128AdvSimd_ShuffleX	1269.523	206.490	1.260506
Sum128AdvSimd_Unzip	270.892	967.705	5.907297
Sum128AdvSimdB64_ShuffleX	541.380	484.215	2.955859
Sum128AdvSimdB64_Unzip	214.843	1220.164	7.448412
Sum128PackedSimd_Unzip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	214.969	1219.452	7.444067
Sum256Base_Basic	1514.268	173.116	1.056776
Sum256Base	1513.641	173.188	1.057213
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1513.471	173.207	1.057332
Sum512Base_Basic	1655.656	158.332	0.966530
Sum512Base	1656.359	158.265	0.966120
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1660.764	157.845	0.963557

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	964.480	271.798
SumBase_Widen	239.330	1095.326	4.029925
SumBase_Zip	154.726	1694.249	6.233481
SumBase	154.746	1694.025	6.232657
SumTraits	40.133	6531.924	24.032254
Sum128Base_Basic	964.553	271.778	0.999925
Sum128Base_Widen	249.989	1048.623	3.858095
Sum128Base_Zip	161.468	1623.505	5.973198
Sum128Base	161.738	1620.798	5.963238
Sum128AdvSimd_ShuffleX	157.911	1660.076	6.107752
Sum128AdvSimd_Widen	236.906	1106.530	4.071146
Sum128AdvSimd_Zip	154.711	1694.413	6.234084
Sum128AdvSimdB64_ShuffleX	66.032	3969.956	14.606262
Sum128AdvSimdB64_Zip	40.007	6552.449	24.107770
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	40.011	6551.751	24.105203
Sum256Base_Basic	946.572	276.940	1.018919
Sum256Base_Widen	233.540	1122.481	4.129830
Sum256Base_Zip	2165.989	121.027	0.445284
Sum256Base	947.328	276.719	1.018106
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	947.270	276.736	1.018168
Sum512Base_Basic	974.556	268.988	0.989661
Sum512Base_Widen	1050.643	249.508	0.917990
Sum512Base_Zip	2223.660	117.889	0.433735
Sum512Base	975.339	268.772	0.988867
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	975.182	268.815	0.989026

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	2196.328	119.356
SumBase	2195.934	119.377	1.000179
SumTraits	1829.922	143.254	1.200230
SumTraits_Int128	125.168	2094.331	17.546985
Sum128Base_Basic	384.008	682.652	5.719481
Sum128Base	386.924	677.507	5.676374
Sum128Traits	381.225	687.637	5.761244
Sum128Traits_Int128	125.277	2092.521	17.531817
Sum256Base_Basic	1899.993	137.971	1.155966
Sum256Base	77.807	3369.152	28.227851
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	77.313	3390.667	28.408112
Sum256Traits_Int128	77.745	3371.853	28.250482
Sum512Base_Basic	1801.837	145.487	1.218938
Sum512Base_Move	70.758	3704.817	31.040160
Sum512Base_Zip	70.631	3711.438	31.095634
Sum512Base	70.705	3707.572	31.063245
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	70.552	3715.637	31.130810
Sum512Traits_Int128	70.658	3710.016	31.083718

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	1138.653	230.223
SumBase_Widen	475.976	550.751	2.392250
SumBase_Zip	310.035	845.531	3.672664
SumBase	310.028	845.548	3.672738
SumTraits	81.227	3227.316	14.018226
Sum128Base_Basic	1139.108	230.131	0.999601
Sum128Base_Widen	499.982	524.307	2.277390
Sum128Base_Zip	325.178	806.157	3.501635
Sum128Base	323.926	809.271	3.515162
Sum128AdvSimd_ShuffleX	317.320	826.119	3.588343
Sum128AdvSimd_Widen	476.298	550.378	2.390633
Sum128AdvSimd_Zip	310.158	845.195	3.671205
Sum128AdvSimdB64_ShuffleX	136.574	1919.435	8.337289
Sum128AdvSimdB64_Zip	82.628	3172.597	13.780549
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	82.233	3187.808	13.846617
Sum256Base_Basic	1173.546	223.378	0.970267
Sum256Base_Widen	467.221	561.071	2.437078
Sum256Base_Zip	2581.935	101.530	0.441008
Sum256Base	1176.777	222.764	0.967603
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1175.152	223.072	0.968941
Sum512Base_Basic	1193.564	219.631	0.953995
Sum512Base_Widen	2301.273	113.913	0.494793
Sum512Base_Zip	2595.756	100.989	0.438660
Sum512Base	1196.667	219.062	0.951521
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1191.641	219.986	0.955534

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
# Sum512Base_Basic	-467656742
SumBase_Basic	1453.763	180.321
SumBase_Zip	621.267	421.951	2.339999
SumBase	621.141	422.036	2.340473
SumTraits	165.705	1581.989	8.773182
Sum128Base_Basic	1455.745	180.076	0.998639
Sum128Base_Zip	621.059	422.092	2.340779
Sum128Base	621.270	421.949	2.339988
Sum128AdvSimd_ShuffleX	634.971	412.844	2.289494
Sum128AdvSimd_Zip	621.269	421.949	2.339989
Sum128AdvSimdB64_ShuffleX	268.910	974.840	5.406139
Sum128AdvSimdB64_Zip	165.272	1586.136	8.796184
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	165.424	1584.676	8.788084
Sum256Base_Basic	1511.129	173.476	0.962038
Sum256Base_Zip	3216.103	81.510	0.452026
Sum256Base	1511.976	173.378	0.961499
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1512.387	173.331	0.961238
Sum512Base_Basic	1516.467	172.865	0.958651
Sum512Base_Zip	3168.354	82.738	0.458839
Sum512Base	1517.529	172.744	0.957980
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1517.810	172.712	0.957803

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	1828.538	143.363
SumBase	1824.252	143.699	1.002350
SumTraits	216.512	1210.762	8.445453
Sum128Base_Basic	1822.918	143.805	1.003083
Sum128Base_Move	270.680	968.466	6.755360
Sum128Base_Zip	296.300	884.726	6.171245
Sum128Base	296.516	884.080	6.166741
Sum128AdvSimd_ShuffleX	1269.708	206.460	1.440125
Sum128AdvSimd_Zip	270.587	968.798	6.757674
Sum128AdvSimdB64_ShuffleX	537.016	488.149	3.404996
Sum128AdvSimdB64_Zip	216.336	1211.747	8.452320
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	216.380	1211.497	8.450579
Sum256Base_Basic	1861.039	140.859	0.982536
Sum256Base	1861.828	140.799	0.982120
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1861.467	140.827	0.982310
Sum512Base_Basic	2157.211	121.520	0.847640
Sum512Base	2157.753	121.489	0.847427
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	2157.159	121.523	0.847660

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


[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	32800.000	7.992
SumBase_Narrow	96658.333	2.712	0.339340
SumBase_Unzip	73341.667	3.574	0.447222
SumBase	32170.833	8.148	1.019557
SumTraits	8039.583	32.607	4.079813
Sum128Base_Basic	33041.667	7.934	0.992686
Sum128Base_Narrow	86991.667	3.013	0.377048
Sum128Base_Unzip	5210.938	50.306	6.294453
Sum128Base	5196.354	50.448	6.312118
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Unzip	6854.688	38.243	4.785047
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	6910.417	37.935	4.746458
Sum256Base_Basic	34900.000	7.511	0.939828
Sum256Base_Narrow	119358.333	2.196	0.274803
Sum256Base_Unzip	71216.667	3.681	0.460566
Sum256Base	35300.000	7.426	0.929178
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	36579.167	7.166	0.896685
Sum512Base_Basic	35258.333	7.435	0.930277
Sum512Base_Narrow	140816.667	1.862	0.232927
Sum512Base_Unzip	64516.667	4.063	0.508396
Sum512Base	34833.333	7.526	0.941627
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	35854.167	7.311	0.914817

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	198483.333	1.321
SumBase	197833.334	1.325	1.003286
SumTraits	144616.666	1.813	1.372479
SumTraits_Int128	105100.000	2.494	1.888519
Sum128Base_Basic	230916.667	1.135	0.859545
Sum128Base	232100.000	1.129	0.855163
Sum128Traits	9756.250	26.869	20.344224
Sum128Traits_Int128	9272.917	28.270	21.404628
Sum256Base_Basic	337433.334	0.777	0.588215
Sum256Base	314616.666	0.833	0.630874
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	142150.000	1.844	1.396295
Sum256Traits_Int128	113991.667	2.300	1.741209
Sum512Base_Basic	330383.334	0.793	0.600767
Sum512Base_Move	330400.000	0.793	0.600736
Sum512Base_Unzip	416816.667	0.629	0.476189
Sum512Base	342966.666	0.764	0.578725
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	154133.334	1.701	1.287738
Sum512Traits_Int128	141450.000	1.853	1.403205

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	49741.667	5.270
SumBase_Narrow	128316.666	2.043	0.387648
SumBase_Unzip	108308.333	2.420	0.459260
SumBase	50508.333	5.190	0.984821
SumTraits	61691.667	4.249	0.806295
Sum128Base_Basic	50341.667	5.207	0.988081
Sum128Base_Narrow	208916.666	1.255	0.238093
Sum128Base_Unzip	190433.333	1.377	0.261203
Sum128Base	199433.333	1.314	0.249415
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Unzip	13822.917	18.964	3.598493
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	13995.833	18.730	3.554034
Sum256Base_Basic	53983.333	4.856	0.921426
Sum256Base_Narrow	266366.666	0.984	0.186741
Sum256Base_Unzip	104400.000	2.511	0.476453
Sum256Base	53295.833	4.919	0.933312
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	56354.166	4.652	0.882662
Sum512Base_Basic	55383.333	4.733	0.898134
Sum512Base_Narrow	310883.333	0.843	0.160001
Sum512Base_Unzip	91516.667	2.864	0.543526
Sum512Base	54650.000	4.797	0.910186
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	55770.833	4.700	0.891894

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
# Sum512Base_Basic	-467656742
SumBase_Basic	73054.167	3.588
SumBase_Unzip	160316.667	1.635	0.455687
SumBase	72133.333	3.634	1.012766
SumTraits	126650.000	2.070	0.576819
Sum128Base_Basic	69600.000	3.766	1.049629
Sum128Base_Unzip	295416.666	0.887	0.247292
Sum128Base	289650.000	0.905	0.252215
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Unzip	27320.833	9.595	2.673936
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	28333.333	9.252	2.578382
Sum256Base_Basic	77491.667	3.383	0.942736
Sum256Base_Unzip	144866.667	1.810	0.504286
Sum256Base	80666.667	3.250	0.905630
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	88841.667	2.951	0.822296
Sum512Base_Basic	75425.000	3.476	0.968567
Sum512Base_Unzip	124733.333	2.102	0.585683
Sum512Base	78600.000	3.335	0.929442
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	81241.667	3.227	0.899220

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	197600.000	1.327
SumBase	198416.666	1.321	0.995884
SumTraits	247550.000	1.059	0.798223
Sum128Base_Basic	329450.000	0.796	0.599788
Sum128Base_Move	295950.000	0.886	0.667680
Sum128Base_Unzip	272633.333	0.962	0.724783
Sum128Base	276866.666	0.947	0.713701
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Unzip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Unzip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Unzip	31512.500	8.319	6.270528
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unzip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	32637.500	8.032	6.054385
Sum256Base_Basic	337650.000	0.776	0.585221
Sum256Base	342533.333	0.765	0.576878
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unzip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	165300.000	1.586	1.195402
Sum512Base_Basic	330400.000	0.793	0.598063
Sum512Base	342199.999	0.766	0.577440
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unzip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	142000.000	1.846	1.391549

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	33783.333	7.760
SumBase_Widen	117625.000	2.229	0.287212
SumBase_Zip	78483.333	3.340	0.430452
SumBase	32970.833	7.951	1.024643
SumTraits	7848.958	33.399	4.304181
Sum128Base_Basic	33047.917	7.932	1.022253
Sum128Base_Widen	115675.000	2.266	0.292054
Sum128Base_Zip	20516.667	12.777	1.646629
Sum128Base	20439.583	12.825	1.652839
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Zip	6881.771	38.093	4.909105
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	6947.917	37.730	4.862369
Sum256Base_Basic	32970.833	7.951	1.024643
Sum256Base_Widen	159450.000	1.644	0.211874
Sum256Base_Zip	70666.667	3.710	0.478066
Sum256Base	35395.833	7.406	0.954444
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	37141.667	7.058	0.909580
Sum512Base_Basic	35887.500	7.305	0.941368
Sum512Base_Widen	175016.666	1.498	0.193029
Sum512Base_Zip	67320.833	3.894	0.501826
Sum512Base	35366.667	7.412	0.955231
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	34870.833	7.518	0.968813

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	175883.334	1.490
SumBase	179716.666	1.459	0.978670
SumTraits	69683.333	3.762	2.524037
SumTraits_Int128	106541.667	2.460	1.650841
Sum128Base_Basic	216600.000	1.210	0.812019
Sum128Base	220983.333	1.186	0.795912
Sum128Traits	9257.292	28.318	18.999437
Sum128Traits_Int128	9406.250	27.869	18.698560
Sum256Base_Basic	318650.000	0.823	0.551964
Sum256Base	284866.666	0.920	0.617423
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	131300.000	1.997	1.339553
Sum256Traits_Int128	109050.000	2.404	1.612869
Sum512Base_Basic	311650.000	0.841	0.564362
Sum512Base_Move	338200.000	0.775	0.520057
Sum512Base_Zip	392983.334	0.667	0.447559
Sum512Base	338216.667	0.775	0.520032
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	156266.667	1.678	1.125533
Sum512Traits_Int128	143333.333	1.829	1.227093

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	43975.000	5.961
SumBase_Widen	176683.333	1.484	0.248892
SumBase_Zip	96825.000	2.707	0.454170
SumBase	40320.833	6.501	1.090627
SumTraits	65137.500	4.024	0.675110
Sum128Base_Basic	43412.500	6.038	1.012957
Sum128Base_Widen	275566.666	0.951	0.159580
Sum128Base_Zip	216100.000	1.213	0.203494
Sum128Base	206400.000	1.270	0.213057
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Zip	13433.333	19.514	3.273573
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	13495.833	19.424	3.258413
Sum256Base_Basic	47879.167	5.475	0.918458
Sum256Base_Widen	348633.333	0.752	0.126135
Sum256Base_Zip	85958.333	3.050	0.511585
Sum256Base	45254.167	5.793	0.971734
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	52600.000	4.984	0.836027
Sum512Base_Basic	46250.000	5.668	0.950811
Sum512Base_Widen	409616.666	0.640	0.107356
Sum512Base_Zip	81583.333	3.213	0.539019
Sum512Base	47962.500	5.466	0.916862
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	51604.167	5.080	0.852160

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467361830
# Sum128Base_Basic	-467361830
# Sum256Base_Basic	-467558438
# Sum512Base_Basic	-467656742
SumBase_Basic	57000.000	4.599
SumBase_Zip	142666.667	1.837	0.399533
SumBase	60762.500	4.314	0.938079
SumTraits	124450.000	2.106	0.458015
Sum128Base_Basic	63741.667	4.113	0.894235
Sum128Base_Zip	369366.667	0.710	0.154318
Sum128Base	381516.666	0.687	0.149404
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Zip	27220.833	9.630	2.093984
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	27108.333	9.670	2.102674
Sum256Base_Basic	66525.000	3.941	0.856821
Sum256Base_Zip	134116.666	1.955	0.425003
Sum256Base	68233.333	3.842	0.835369
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	82050.000	3.195	0.694698
Sum512Base_Basic	73258.333	3.578	0.778068
Sum512Base_Zip	118783.333	2.207	0.479865
Sum512Base	72375.000	3.622	0.787565
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	77016.667	3.404	0.740100

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	5910372263572073988
# Sum512Base_Basic	5910372263572041220
SumBase_Basic	179466.667	1.461
SumBase	180516.666	1.452	0.994183
SumTraits	246900.000	1.062	0.726880
Sum128Base_Basic	303466.666	0.864	0.591388
Sum128Base_Move	283583.333	0.924	0.632853
Sum128Base_Zip	264066.666	0.993	0.679626
Sum128Base	260566.666	1.006	0.688755
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Zip	31895.833	8.219	5.626649
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	31752.083	8.256	5.652123
Sum256Base_Basic	318816.667	0.822	0.562915
Sum256Base	317783.333	0.825	0.564745
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	162316.667	1.615	1.105658
Sum512Base_Basic	314600.000	0.833	0.570460
Sum512Base	321550.000	0.815	0.558130
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	135950.000	1.928	1.320093

```

