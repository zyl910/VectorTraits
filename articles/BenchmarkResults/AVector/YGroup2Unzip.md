# Benchmark - YGroup2Unzip
([← Back](README.md))

See [Group](YGroup2Unzip_Group.md)

- `YGroup2Unzip[/_Bit128]`: De-Interleave 2-element groups into 2 vectors. It converts the 2-element groups AoS to SoA (将2-元素组解交织为2个向量. 它能将2元素组的 数组结构体 转为 结构体数组).
  Mnemonic: `x[i] =: element_ref(2*i, data0, data1)`, `y[i] =: element_ref(2*i+1, data0, data1)`.
- `YGroup2Zip[/_Bit128]`: Interleave 2 vectors into 2-element groups. It converts the 2-element groups SoA to AoS (将2个向量交织为2-元素组. 它能将2元素组的 结构体数组 转为 数组结构体).
  Mnemonic: `element_ref(i, data0, data1) := (0==(i&1))?( x[i2] ):( y[i2] )`, `i2 := i/2`.

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	839.021	312.440
SumBase_NarrowMul	49.806	5263.307	16.845806
SumBase	49.566	5288.807	16.927422
SumTraits	49.874	5256.158	16.822925

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	2931.527	89.422
SumBase	2979.229	87.991	0.983988
SumTraits	3280.241	79.916	0.893692
SumTraits_Int128	2088.867	125.496	1.403405

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	762.342	343.867
SumBase_NarrowMul	77.236	3394.043	9.870232
SumBase_NarrowMulOld	125.581	2087.448	6.070515
SumBase	77.332	3389.868	9.858088
SumTraits	78.549	3337.336	9.705320

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
SumBase_Basic	908.140	288.660
SumBase_NarrowMul	180.907	1449.058	5.019940
SumBase	176.971	1481.280	5.131566
SumTraits	178.601	1467.766	5.084753

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	1471.928	178.096
SumBase	1471.040	178.203	1.000604
SumTraits	1455.641	180.088	1.011189

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	699.710	374.647
SumBase_WidenMul	13.633	19227.974	51.322927
SumBase	13.772	19034.663	50.806944
SumTraits	13.647	19208.309	51.270437

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	2906.307	90.198
SumBase	2933.975	89.348	0.990570
SumTraits	3138.128	83.535	0.926128
SumTraits_Int128	2306.732	113.643	1.259924

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	763.187	343.486
SumBase_WidenMul	27.690	9467.105	27.561833
SumBase	27.436	9554.663	27.816742
SumTraits	29.164	8988.525	26.168528

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
SumBase_Basic	1075.823	243.668
SumBase	1053.060	248.935	1.021616
SumTraits	1111.629	235.820	0.967790

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	1874.281	139.864
SumBase	1869.264	140.239	1.002684
SumTraits	1871.494	140.072	1.001489

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	369.939	708.615
SumBase_NarrowMul	50.291	5212.518	7.355926
SumBase	50.281	5213.572	7.357413
SumTraits	50.798	5160.486	7.282498

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	3018.127	86.857
SumBase	2646.200	99.064	1.140551
SumTraits	2746.523	95.446	1.098890
SumTraits_Int128	1704.611	153.785	1.770566

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	474.088	552.944
SumBase_NarrowMul	79.153	3311.882	5.989542
SumBase_NarrowMulOld	131.553	1992.687	3.603777
SumBase	83.468	3140.644	5.679858
SumTraits	81.790	3205.081	5.796393

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
SumBase_Basic	673.056	389.483
SumBase_NarrowMul	187.711	1396.528	3.585593
SumBase	187.213	1400.246	3.595138
SumTraits	187.057	1401.416	3.598142

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	1135.616	230.839
SumBase	1129.251	232.140	1.005637
SumTraits	1125.858	232.839	1.008667

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	350.590	747.722
SumBase_WidenMul	14.470	18116.996	24.229587
SumBase	14.236	18413.837	24.626580
SumTraits	14.800	17712.936	23.689199

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	2377.214	110.274
SumBase	2439.164	107.473	0.974602
SumTraits	2767.536	94.721	0.858964
SumTraits_Int128	1863.393	140.681	1.275745

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	455.466	575.551
SumBase_WidenMul	30.242	8668.102	15.060533
SumBase	30.783	8515.899	14.796084
SumTraits	30.067	8718.781	15.148585

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
SumBase_Basic	701.346	373.773
SumBase	734.463	356.919	0.954910
SumTraits	725.083	361.537	0.967263

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	1254.586	208.949
SumBase	1280.264	204.758	0.979943
SumTraits	1283.000	204.321	0.977853

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	373.511	701.838
SumBase_NarrowMul	50.458	5195.285	7.402399
SumBase	50.490	5191.998	7.397716
SumTraits	11.017	23793.787	33.902105
Sum128Base_Basic	765.688	342.364	0.487810
Sum128Base	755.580	346.944	0.494336
Sum128Sse_Narrow	18.179	14420.100	20.546194
Sum128Sse_Unpack	18.942	13839.276	19.718618
Sum128Traits	17.777	14745.866	21.010354
Sum256Base_Basic	644.046	407.027	0.579944
Sum256Base	651.764	402.207	0.573077
Sum256Avx2_Narrow	11.158	23493.768	33.474628
Sum256Avx2_Unpack	11.676	22451.572	31.989676
Sum256Traits	10.720	24454.706	34.843802

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	2682.970	97.707
SumBase	2554.744	102.611	1.050192
SumTraits	5109.947	51.301	0.525049
SumTraits_Int128	40.273	6509.156	66.619387
Sum128Base_Basic	3164.667	82.835	0.847789
Sum128Base	3179.914	82.437	0.843724
Sum128Traits	1602.492	163.585	1.674249
Sum128Traits_Int128	53.379	4911.017	50.262886
Sum256Base_Basic	3889.099	67.405	0.689869
Sum256Base_Move2	3806.808	68.862	0.704782
Sum256Base	3837.864	68.305	0.699079
Sum256Avx2	3716.930	70.527	0.721824
Sum256Traits	3903.157	67.162	0.687385
Sum256Traits_Int128	47.695	5496.242	56.252491

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	443.605	590.940
SumBase_NarrowMul	78.176	3353.238	5.674414
SumBase_NarrowMulOld	198.706	1319.253	2.232465
SumBase	78.788	3327.213	5.630374
SumTraits	20.283	12924.474	21.871045
Sum128Base_Basic	1170.107	224.034	0.379115
Sum128Base	1153.362	227.287	0.384619
Sum128Sse_Narrow	42.643	6147.426	10.402792
Sum128Sse_ShuffleXImm	28.817	9096.740	15.393679
Sum128Sse_Unpack	29.885	8771.697	14.843635
Sum128Traits	29.242	8964.560	15.170002
Sum256Base_Basic	916.146	286.138	0.484208
Sum256Base	892.261	293.798	0.497170
Sum256Avx2_Narrow	22.248	11782.755	19.939005
Sum256Avx2_ShuffleXImm	19.011	13789.369	23.334636
Sum256Avx2_Unpack	19.790	13246.043	22.415211
Sum256Traits	18.945	13837.439	23.415982

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	671.516	390.376
SumBase_NarrowMul	183.545	1428.226	3.658589
SumBase	184.341	1422.057	3.642785
SumTraits	24.466	10714.833	27.447449
Sum128Base_Basic	1872.019	140.033	0.358712
Sum128Base	1969.023	133.134	0.341040
Sum128Sse_Narrow	71.749	3653.601	9.359179
Sum128Sse_ShuffleXImm	32.933	7959.877	20.390269
Sum128Sse_Unpack	44.651	5870.951	15.039211
Sum128Traits	33.692	7780.653	19.931162
Sum256Base_Basic	1265.755	207.105	0.530526
Sum256Base	1256.811	208.579	0.534302
Sum256Avx2_Narrow	45.508	5760.345	14.755880
Sum256Avx2_ShuffleXImm	23.811	11009.485	28.202238
Sum256Avx2_Unpack	30.640	8555.748	21.916670
Sum256Traits	23.536	11138.013	28.531479

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1107.615	236.674
SumBase	1078.215	243.128	1.027268
SumTraits	47.351	5536.173	23.391533
Sum128Base_Basic	3422.146	76.602	0.323661
Sum128Base	3259.090	80.435	0.339854
Sum128Sse_Unpack	63.358	4137.520	17.481920
Sum128Traits	64.669	4053.644	17.127525
Sum256Base_Basic	2174.143	120.574	0.509449
Sum256Base	2183.905	120.034	0.507172
Sum256Avx2_Unpack	45.182	5801.950	24.514499
Sum256Traits	47.741	5490.972	23.200552

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	296.531	884.034
SumBase_WidenMul	14.438	18156.750	20.538512
SumBase	14.561	18003.172	20.364789
SumTraits	6.006	43644.394	49.369570
Sum128Base_Basic	698.373	375.364	0.424603
Sum128Base	684.955	382.717	0.432921
Sum128Sse_Unpack	8.208	31938.066	36.127632
Sum128Sse_Widen	18.225	14383.702	16.270525
Sum128Traits	8.702	30125.650	34.077468
Sum256Base_Basic	584.144	448.766	0.507634
Sum256Base	614.563	426.553	0.482508
Sum256Avx2_Unpack	5.979	43841.661	49.592714
Sum256Avx2_Widen	11.416	22962.869	25.975088
Sum256Traits	5.852	44799.259	50.675928

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	2131.769	122.970
SumBase	2167.658	120.934	0.983443
SumTraits	5165.024	50.754	0.412732
SumTraits_Int128	39.800	6586.565	53.562298
Sum128Base_Basic	3149.338	83.238	0.676894
Sum128Base	3172.438	82.632	0.671966
Sum128Traits	1603.367	163.496	1.329558
Sum128Traits_Int128	47.967	5465.117	44.442619
Sum256Base_Basic	3177.376	82.503	0.670921
Sum256Base_Move2	3801.880	68.951	0.560714
Sum256Base	3852.053	68.053	0.553411
Sum256Avx2	3710.921	70.641	0.574458
Sum256Traits	3899.178	67.231	0.546723
Sum256Traits_Int128	39.460	6643.367	54.024215

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	385.238	680.473
SumBase_WidenMul	29.154	8991.576	13.213723
SumBase	28.270	9272.883	13.627122
SumTraits	11.933	21968.086	32.283572
Sum128Base_Basic	1054.080	248.695	0.365473
Sum128Base	1069.505	245.108	0.360202
Sum128Sse_Unpack	17.032	15391.344	22.618610
Sum128Sse_Widen	35.231	7440.800	10.934754
Sum128Traits	17.442	15029.828	22.087338
Sum256Base_Basic	763.643	343.281	0.504474
Sum256Base	779.579	336.264	0.494162
Sum256Avx2_Unpack	11.723	22362.425	32.863081
Sum256Avx2_Widen	22.573	11613.146	17.066296
Sum256Traits	12.556	20877.287	30.680570

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	568.533	461.089
SumBase	585.508	447.720	0.971007
SumTraits	25.416	10314.292	22.369437
Sum128Base_Basic	1785.688	146.803	0.318383
Sum128Base	1815.501	144.392	0.313155
Sum128Sse_Unpack	34.296	7643.603	16.577297
Sum128Sse_Widen	71.490	3666.853	7.952599
Sum128Traits	34.346	7632.406	16.553015
Sum256Base_Basic	1169.602	224.131	0.486091
Sum256Base	1095.730	239.241	0.518862
Sum256Avx2_Unpack	25.265	10375.731	22.502685
Sum256Avx2_Widen	45.144	5806.822	12.593723
Sum256Traits	24.373	10755.706	23.326765

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	976.603	268.424
SumBase	949.784	276.004	1.028237
SumTraits	47.994	5462.039	20.348524
Sum128Base_Basic	3401.462	77.068	0.287113
Sum128Base	3238.057	80.957	0.301602
Sum128Sse_Unpack	63.316	4140.217	15.424148
Sum128Traits	64.846	4042.554	15.060310
Sum256Base_Basic	2058.457	127.350	0.474434
Sum256Base	1946.581	134.669	0.501702
Sum256Avx2_Unpack	46.701	5613.266	20.911908
Sum256Traits	46.923	5586.725	20.813031

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	420.527	623.371
SumBase_NarrowMul	49.986	5244.322	8.412843
SumBase	50.167	5225.440	8.382553
SumTraits	10.309	25428.076	40.791246
Sum128Base_Basic	713.662	367.322	0.589251
Sum128Base	697.595	375.783	0.602823
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	18.180	14419.377	23.131297
Sum128Sse_Unpack	18.535	14143.198	22.688256
Sum128Traits	16.480	15906.414	25.516774
Sum256Base_Basic	685.005	382.689	0.613903
Sum256Base	686.152	382.049	0.612876
Sum256Avx2_Narrow	9.464	27700.483	44.436600
Sum256Avx2_Unpack	11.681	22442.671	36.002116
Sum256Traits	9.964	26308.795	42.204079

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1785.828	146.791
SumBase	1586.827	165.200	1.125408
SumTraits	5794.397	45.241	0.308199
SumTraits_Int128	36.876	7108.716	48.427379
Sum128Base_Basic	3221.634	81.370	0.554324
Sum128Base	3211.613	81.624	0.556053
Sum128Traits	1600.835	163.755	1.115561
Sum128Traits_Int128	46.097	5686.756	38.740424
Sum256Base_Basic	2830.705	92.607	0.630878
Sum256Base_Move2	3706.571	70.724	0.481801
Sum256Base	3687.435	71.091	0.484301
Sum256Avx2	2851.951	91.917	0.626178
Sum256Traits	2850.368	91.968	0.626526
Sum256Traits_Int128	37.304	7027.320	47.872877

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	576.132	455.007
SumBase_NarrowMul	77.227	3394.478	7.460276
SumBase_NarrowMulOld	122.522	2139.564	4.702265
SumBase	78.280	3348.805	7.359898
SumTraits	19.017	13784.735	30.295657
Sum128Base_Basic	1112.344	235.668	0.517944
Sum128Base	1122.445	233.547	0.513283
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	33.519	7820.839	17.188393
Sum128Sse_ShuffleXImm	26.299	9967.935	21.907214
Sum128Sse_Unpack	29.168	8987.290	19.751984
Sum128Traits	25.593	10242.922	22.511571
Sum256Base_Basic	1021.443	256.641	0.564037
Sum256Base	952.139	275.321	0.605092
Sum256Avx2_Narrow	18.939	13841.667	30.420780
Sum256Avx2_ShuffleXImm	19.022	13780.883	30.287190
Sum256Avx2_Unpack	19.279	13597.726	29.884654
Sum256Traits	18.913	13860.444	30.462048

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	991.803	264.310
SumBase_NarrowMul	175.508	1493.629	5.651038
SumBase	177.846	1473.995	5.576754
SumTraits	24.538	10682.997	40.418366
Sum128Base_Basic	1954.502	134.123	0.507445
Sum128Base	1970.062	133.064	0.503438
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	66.353	3950.752	14.947391
Sum128Sse_ShuffleXImm	33.286	7875.408	29.796051
Sum128Sse_Unpack	45.507	5760.486	21.794392
Sum128Traits	35.391	7406.999	28.023859
Sum256Base_Basic	1593.087	164.551	0.622567
Sum256Base	1551.380	168.975	0.639304
Sum256Avx2_Narrow	40.903	6408.890	24.247581
Sum256Avx2_ShuffleXImm	24.292	10791.156	40.827579
Sum256Avx2_Unpack	30.686	8542.918	32.321526
Sum256Traits	24.319	10779.378	40.783015

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1119.598	234.141
SumBase	1119.464	234.169	1.000119
SumTraits	46.268	5665.745	24.197982
Sum128Base_Basic	3593.160	72.956	0.311591
Sum128Base	3266.345	80.256	0.342768
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	62.748	4177.750	17.842862
Sum128Traits	63.853	4105.403	17.533876
Sum256Base_Basic	2913.516	89.975	0.384277
Sum256Base	3040.483	86.218	0.368230
Sum256Avx2_Unpack	46.485	5639.294	24.085010
Sum256Traits	45.944	5705.729	24.368750

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	408.052	642.427
SumBase_WidenMul	14.393	18212.820	28.350004
SumBase	14.351	18267.204	28.434657
SumTraits	5.244	49986.735	77.809153
Sum128Base_Basic	699.697	374.653	0.583184
Sum128Base	702.337	373.245	0.580992
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	8.345	31413.814	48.898618
Sum128Sse_Widen	17.497	14981.930	23.320813
Sum128Traits	8.211	31926.232	49.696246
Sum256Base_Basic	695.791	376.757	0.586458
Sum256Base	676.544	387.475	0.603142
Sum256Avx2_Unpack	5.238	50050.529	77.908455
Sum256Avx2_Widen	9.379	27948.616	43.504706
Sum256Traits	5.180	50602.987	78.768409

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1977.117	132.589
SumBase	1957.456	133.921	1.010044
SumTraits	5804.081	45.165	0.340643
SumTraits_Int128	36.368	7208.001	54.363491
Sum128Base_Basic	3212.355	81.605	0.615473
Sum128Base	3230.150	81.155	0.612082
Sum128Traits	1607.075	163.119	1.230258
Sum128Traits_Int128	48.311	5426.199	40.924957
Sum256Base_Basic	2903.797	90.276	0.680873
Sum256Base_Move2	3722.873	70.414	0.531073
Sum256Base	3687.153	71.097	0.536218
Sum256Avx2	2843.094	92.204	0.695410
Sum256Traits	2846.376	92.097	0.694609
Sum256Traits_Int128	38.768	6761.932	50.999191

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	592.107	442.731
SumBase_WidenMul	28.540	9185.208	20.746709
SumBase	29.733	8816.670	19.914289
SumTraits	10.709	24478.518	55.289841
Sum128Base_Basic	1057.943	247.786	0.559677
Sum128Base	1057.228	247.954	0.560056
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	23.075	11360.399	25.659832
Sum128Sse_Widen	36.294	7222.859	16.314335
Sum128Traits	17.354	15105.533	34.118999
Sum256Base_Basic	1007.601	260.166	0.587640
Sum256Base	1073.309	244.239	0.551665
Sum256Avx2_Unpack	10.999	23832.738	53.831214
Sum256Avx2_Widen	18.829	13922.047	31.445849
Sum256Traits	10.630	24660.121	55.700029

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	977.277	268.239
SumBase	1013.624	258.621	0.964142
SumTraits	23.487	11161.150	41.608955
Sum128Base_Basic	1782.211	147.089	0.548351
Sum128Base	1786.755	146.715	0.546957
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	34.791	7534.736	28.089622
Sum128Sse_Widen	72.451	3618.209	13.488743
Sum128Traits	34.711	7552.292	28.155071
Sum256Base_Basic	1542.257	169.974	0.633667
Sum256Base	1625.185	161.301	0.601333
Sum256Avx2_Unpack	23.214	11292.569	42.098888
Sum256Avx2_Widen	38.156	6870.305	25.612611
Sum256Traits	21.723	12067.730	44.988697

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1763.367	148.661
SumBase	1815.011	144.431	0.971546
SumTraits	42.134	6221.690	41.851516
Sum128Base_Basic	3370.973	77.765	0.523103
Sum128Base	3260.412	80.402	0.540842
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	64.154	4086.167	27.486466
Sum128Traits	67.163	3903.111	26.255102
Sum256Base_Basic	2795.405	93.777	0.630809
Sum256Base	3017.533	86.874	0.584374
Sum256Avx2_Unpack	42.418	6180.063	41.571506
Sum256Traits	42.491	6169.405	41.499809

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	353.395	741.788
SumBase_NarrowMul	50.660	5174.573	6.975811
SumBase	51.000	5140.035	6.929250
SumTraits	9.194	28511.141	38.435699
Sum128Base_Basic	748.194	350.369	0.472330
Sum128Base	743.470	352.595	0.475331
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	16.344	16039.185	21.622329
Sum128Sse_Unpack	19.071	13745.620	18.530388
Sum128Traits	16.030	16353.364	22.045872
Sum256Base_Basic	624.694	419.636	0.565709
Sum256Base	627.604	417.690	0.563085
Sum256Avx2_Narrow	9.032	29022.834	39.125509
Sum256Avx2_Unpack	11.590	22617.223	30.490143
Sum256Traits	8.874	29540.267	39.823058

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1623.517	161.467
SumBase	1400.325	187.202	1.159385
SumTraits	5650.073	46.397	0.287344
SumTraits_Int128	39.412	6651.417	41.193716
Sum128Base_Basic	3206.177	81.762	0.506371
Sum128Base	3228.316	81.201	0.502899
Sum128Traits	1603.862	163.446	1.012255
Sum128Traits_Int128	48.719	5380.761	33.324259
Sum256Base_Basic	2501.966	104.775	0.648896
Sum256Base_Move2	2911.944	90.024	0.557537
Sum256Base	2944.457	89.030	0.551381
Sum256Avx2	2770.341	94.625	0.586035
Sum256Traits	2776.081	94.430	0.584823
Sum256Traits_Int128	38.755	6764.164	41.891987

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	453.453	578.106
SumBase_NarrowMul	79.488	3297.919	5.704700
SumBase_NarrowMulOld	129.264	2027.969	3.507956
SumBase	78.661	3332.565	5.764629
SumTraits	19.048	13762.321	23.805892
Sum128Base_Basic	1180.984	221.971	0.383962
Sum128Base	1190.182	220.255	0.380995
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	32.221	8135.788	14.073185
Sum128Sse_ShuffleXImm	25.820	10152.929	17.562409
Sum128Sse_Unpack	29.860	8779.236	15.186213
Sum128Traits	25.716	10193.702	17.632939
Sum256Base_Basic	881.657	297.331	0.514320
Sum256Base	865.990	302.710	0.523624
Sum256Avx2_Narrow	18.565	14120.405	24.425300
Sum256Avx2_ShuffleXImm	19.436	13487.301	23.330166
Sum256Avx2_Unpack	19.653	13338.789	23.073270
Sum256Traits	19.449	13478.299	23.314593

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	657.209	398.874
SumBase_NarrowMul	186.706	1404.044	3.520015
SumBase	182.092	1439.623	3.609213
SumTraits	25.654	10218.602	25.618593
Sum128Base_Basic	1863.490	140.674	0.352677
Sum128Base	1858.995	141.014	0.353529
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	67.721	3870.934	9.704644
Sum128Sse_ShuffleXImm	36.496	7182.845	18.007784
Sum128Sse_Unpack	46.891	5590.444	14.015548
Sum128Traits	32.676	8022.471	20.112772
Sum256Base_Basic	1244.468	210.647	0.528105
Sum256Base	1233.644	212.496	0.532738
Sum256Avx2_Narrow	42.615	6151.415	15.421933
Sum256Avx2_ShuffleXImm	24.778	10579.538	26.523479
Sum256Avx2_Unpack	33.246	7884.926	19.767938
Sum256Traits	25.517	10273.212	25.755503

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1119.057	234.254
SumBase	1100.359	238.235	1.016993
SumTraits	46.213	5672.494	24.215109
Sum128Base_Basic	3548.176	73.881	0.315389
Sum128Base	3257.309	80.479	0.343553
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	67.792	3866.860	16.507105
Sum128Traits	67.848	3863.718	16.493690
Sum256Base_Basic	2214.692	118.366	0.505288
Sum256Base	2184.424	120.006	0.512289
Sum256Avx2_Unpack	44.667	5868.885	25.053476
Sum256Traits	46.224	5671.182	24.209510

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	323.440	810.488
SumBase_WidenMul	14.342	18277.672	22.551437
SumBase	14.930	17557.912	21.663379
SumTraits	5.156	50843.740	62.732244
Sum128Base_Basic	704.364	372.171	0.459194
Sum128Base	692.298	378.658	0.467197
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	8.567	30600.360	37.755469
Sum128Sse_Widen	17.424	15045.124	18.563041
Sum128Traits	8.318	31517.040	38.886491
Sum256Base_Basic	589.143	444.958	0.549000
Sum256Base	585.536	447.699	0.552382
Sum256Avx2_Unpack	5.187	50542.024	62.359980
Sum256Avx2_Widen	9.231	28398.083	35.038246
Sum256Traits	5.260	49833.479	61.485759

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1733.323	151.238
SumBase	1739.647	150.688	0.996365
SumTraits	5656.718	46.342	0.306419
SumTraits_Int128	39.177	6691.355	44.243938
Sum128Base_Basic	3201.152	81.891	0.541469
Sum128Base	3218.013	81.461	0.538632
Sum128Traits	1600.290	163.810	1.083131
Sum128Traits_Int128	50.518	5189.072	34.310682
Sum256Base_Basic	2602.503	100.728	0.666022
Sum256Base_Move2	2909.881	90.088	0.595668
Sum256Base	2929.644	89.480	0.591650
Sum256Avx2	2781.595	94.242	0.623140
Sum256Traits	2756.333	95.106	0.628851
Sum256Traits_Int128	35.771	7328.373	48.455964

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	392.788	667.393
SumBase_WidenMul	28.555	9180.201	13.755316
SumBase	28.436	9218.729	13.813046
SumTraits	10.704	24489.609	36.694438
Sum128Base_Basic	1064.745	246.204	0.368904
Sum128Base	1077.926	243.193	0.364392
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	15.850	16539.302	24.781955
Sum128Sse_Widen	36.041	7273.543	10.898441
Sum128Traits	16.738	15661.157	23.466170
Sum256Base_Basic	782.892	334.841	0.501714
Sum256Base	776.221	337.718	0.506026
Sum256Avx2_Unpack	11.165	23479.905	35.181530
Sum256Avx2_Widen	18.947	13835.971	20.731372
Sum256Traits	10.646	24624.725	36.896890

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	568.033	461.494
SumBase	570.849	459.217	0.995067
SumTraits	22.809	11492.854	24.903586
Sum128Base_Basic	1823.490	143.759	0.311509
Sum128Base	1817.935	144.199	0.312461
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	34.928	7505.358	16.263178
Sum128Sse_Widen	73.353	3573.720	7.743807
Sum128Traits	34.945	7501.640	16.255121
Sum256Base_Basic	1103.733	237.507	0.514648
Sum256Base	1107.377	236.725	0.512954
Sum256Avx2_Unpack	22.845	11475.125	24.865170
Sum256Avx2_Widen	38.703	6773.249	14.676789
Sum256Traits	22.896	11449.479	24.809599

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	965.603	271.482
SumBase	947.195	276.758	1.019435
SumTraits	42.672	6143.165	22.628254
Sum128Base_Basic	3409.881	76.878	0.283178
Sum128Base	3276.723	80.002	0.294686
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	67.449	3886.524	14.315952
Sum128Traits	64.763	4047.766	14.909885
Sum256Base_Basic	1969.103	133.129	0.490377
Sum256Base	1961.774	133.626	0.492209
Sum256Avx2_Unpack	41.524	6313.031	23.253953
Sum256Traits	43.529	6022.308	22.183077

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	379.389	690.964
SumBase_Narrow	9.476	27664.994	40.038237
SumBase_NarrowMul	30.026	8730.559	12.635326
SumBase	9.710	26996.800	39.071192
SumTraits	9.542	27473.666	39.761336
Sum128Base_Basic	412.938	634.826	0.918754
Sum128Base	16.219	16163.037	23.391999
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	16.470	15916.915	23.035798
Sum128Sse_Unpack	19.432	13490.022	19.523471
Sum128Traits	17.086	15342.508	22.204485
Sum256Base_Basic	377.357	694.685	1.005385
Sum256Base	9.362	28000.278	40.523477
Sum256Avx2_Narrow	9.623	27240.744	39.424240
Sum256Avx2_Unpack	11.786	22241.992	32.189783
Sum256Traits	9.486	27635.750	39.995914

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1619622550967760421
Check-SumTraits	Check `SumTraits` mismatch. 5836369141313106960!=1619622550967760421
Check-SumTraits_Int128	Check `SumTraits_Int128` mismatch. 5910372263571615236!=1619622550967760421
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1968.630	133.161
SumBase	1995.074	131.396	0.986746
SumTraits	2834.732	92.476	0.694468
SumTraits_Int128	39.984	6556.273	49.235826
Sum128Base_Basic	1604.972	163.332	1.226582
Sum128Base	1607.916	163.033	1.224336
Sum128Traits	1608.612	162.963	1.223807
Sum128Traits_Int128	50.927	5147.491	38.656253
Sum256Base_Basic	1553.823	168.709	1.266959
Sum256Base_Move2	335.408	781.567	5.869356
Sum256Base	339.979	771.058	5.790438
Sum256Avx2	350.265	748.417	5.620405
Sum256Traits	353.413	741.749	5.570332
Sum256Traits_Int128	37.282	7031.433	52.804144

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	472.870	554.368
SumBase_Narrow	19.272	13602.150	24.536308
SumBase_NarrowMul	50.540	5186.878	9.356375
SumBase_NarrowMulOld	89.738	2921.203	5.269427
SumBase	19.668	13328.548	24.042769
SumTraits	19.467	13465.799	24.290350
Sum128Base_Basic	549.465	477.089	0.860600
Sum128Base	33.497	7825.875	14.116744
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	33.022	7938.521	14.319941
Sum128Sse_ShuffleXImm	26.679	9825.838	17.724389
Sum128Sse_Unpack	30.024	8731.122	15.749679
Sum128Traits	26.896	9746.461	17.581204
Sum256Base_Basic	475.260	551.580	0.994971
Sum256Base	19.248	13619.341	24.567318
Sum256Avx2_Narrow	19.480	13457.282	24.274986
Sum256Avx2_ShuffleXImm	19.276	13599.570	24.531654
Sum256Avx2_Unpack	20.300	12913.395	23.293894
Sum256Traits	19.343	13552.638	24.446995

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	710.532	368.941
SumBase_Narrow	42.522	6164.935	16.709832
SumBase_NarrowMul	113.836	2302.816	6.241699
SumBase	42.475	6171.687	16.728135
SumTraits	25.406	10318.189	27.967079
Sum128Base_Basic	1021.001	256.752	0.695917
Sum128Base	68.574	3822.769	10.361476
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Narrow	69.388	3777.928	10.239936
Sum128Sse_ShuffleXImm	37.301	7027.736	19.048423
Sum128Sse_Unpack	47.753	5489.564	14.879265
Sum128Traits	34.332	7635.668	20.696201
Sum256Base_Basic	704.446	372.128	1.008639
Sum256Base	42.978	6099.499	16.532471
Sum256Avx2_Narrow	42.502	6167.812	16.717631
Sum256Avx2_ShuffleXImm	24.720	10604.505	28.743127
Sum256Avx2_Unpack	31.066	8438.160	22.871328
Sum256Traits	25.401	10320.229	27.972608

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1218.920	215.062
SumBase	1221.032	214.691	0.998271
SumTraits	46.380	5652.144	26.281411
Sum128Base_Basic	1783.191	147.008	0.683561
Sum128Base	1709.281	153.365	0.713119
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	65.500	4002.206	18.609507
Sum128Traits	69.938	3748.229	17.428560
Sum256Base_Basic	1212.950	216.121	1.004922
Sum256Base	1221.082	214.682	0.998230
Sum256Avx2_Unpack	47.806	5483.524	25.497356
Sum256Traits	46.523	5634.759	26.200573

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	310.449	844.404
SumBase_Widen	8.779	29860.211	35.362490
SumBase_WidenMul	9.392	27912.299	33.055640
SumBase	9.031	29027.283	34.376080
SumTraits	5.245	49983.002	59.193266
Sum128Base_Basic	376.474	696.315	0.824623
Sum128Base	15.848	16541.464	19.589525
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	8.909	29423.449	34.845247
Sum128Sse_Widen	19.380	13526.299	16.018762
Sum128Traits	8.266	31713.434	37.557203
Sum256Base_Basic	309.793	846.190	1.002116
Sum256Base	8.652	30299.290	35.882477
Sum256Avx2_Unpack	5.470	47926.024	56.757253
Sum256Avx2_Widen	10.358	25309.333	29.973032
Sum256Traits	5.547	47262.065	55.970947

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-380393390599623666
Check-SumBase	Check `SumBase` mismatch. 1023369567752644982!=-380393390599623666
Check-SumTraits	Check `SumTraits` mismatch. 8860022655257291154!=-380393390599623666
Check-SumTraits_Int128	Check `SumTraits_Int128` mismatch. 5910372263571615236!=-380393390599623666
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1934.105	135.538
SumBase	1930.935	135.760	1.001642
SumTraits	2824.223	92.820	0.684827
SumTraits_Int128	38.551	6800.003	50.170588
Sum128Base_Basic	1607.915	163.034	1.202865
Sum128Base	1609.609	162.862	1.201599
Sum128Traits	1604.680	163.362	1.205290
Sum128Traits_Int128	50.540	5186.834	38.268591
Sum256Base_Basic	1401.755	187.011	1.379773
Sum256Base_Move2	338.970	773.354	5.705825
Sum256Base	335.159	782.149	5.770711
Sum256Avx2	354.535	739.402	5.455326
Sum256Traits	362.128	723.898	5.340941
Sum256Traits_Int128	40.579	6460.112	47.662864

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	408.449	641.803
SumBase_Widen	17.574	14916.760	23.241962
SumBase_WidenMul	19.437	13486.951	21.014162
SumBase	17.657	14846.064	23.131810
SumTraits	11.445	22904.792	35.688200
Sum128Base_Basic	557.035	470.606	0.733256
Sum128Base	33.657	7788.578	12.135466
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	18.599	14094.729	21.961146
Sum128Sse_Widen	40.625	6452.729	10.054066
Sum128Traits	18.107	14477.327	22.557276
Sum256Base_Basic	414.743	632.064	0.984826
Sum256Base	17.240	15205.385	23.691672
Sum256Avx2_Unpack	11.272	23255.358	36.234420
Sum256Avx2_Widen	21.171	12382.326	19.293033
Sum256Traits	11.391	23013.364	35.857367

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	618.656	423.731
SumBase_Widen	35.418	7401.505	17.467446
SumBase	36.244	7232.717	17.069108
SumTraits	22.548	11626.050	27.437309
Sum128Base_Basic	841.096	311.669	0.735535
Sum128Base	67.447	3886.686	9.172524
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	35.188	7449.851	17.581541
Sum128Sse_Widen	76.232	3438.761	8.115426
Sum128Traits	36.843	7115.192	16.791751
Sum256Base_Basic	609.170	430.330	1.015572
Sum256Base	34.828	7526.841	17.763235
Sum256Avx2_Unpack	23.136	11330.721	26.740339
Sum256Avx2_Widen	42.557	6159.853	14.537164
Sum256Traits	23.594	11110.506	26.220634

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	1018.628	257.350
SumBase	1024.709	255.823	0.994066
SumTraits	44.259	5922.926	23.015063
Sum128Base_Basic	1605.438	163.285	0.634486
Sum128Base	1709.835	153.315	0.595747
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Unpack	63.644	4118.941	16.005213
Sum128Traits	72.605	3610.529	14.029645
Sum256Base_Basic	1021.244	256.691	0.997439
Sum256Base	1024.066	255.984	0.994691
Sum256Avx2_Unpack	42.363	6187.994	24.045052
Sum256Traits	45.557	5754.257	22.359657

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	286.995	913.409
SumBase_Narrow	6.756	38799.095	42.477243
SumBase_NarrowMul	25.172	10414.217	11.401484
SumBase	6.686	39210.113	42.927226
SumTraits	4.866	53874.524	58.981821
Sum128Base_Basic	267.158	981.234	1.074255
Sum128Base	12.384	21168.785	23.175583
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Narrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleNarrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Narrow	13.361	19619.701	21.479645
Sum128Sse_Permute	9.427	27808.972	30.445258
Sum128Sse_Unpack	18.249	14365.190	15.727008
Sum128Traits	9.606	27288.403	29.875340
Sum256Base_Basic	284.542	921.283	1.008620
Sum256Base	7.103	36904.926	40.403508
Sum256Avx2_Narrow	7.194	36439.779	39.894265
Sum256Avx2_Permute	5.431	48267.067	52.842778
Sum256Avx2_Unpack	11.884	22058.773	24.149941
Sum256Traits	5.392	48613.828	53.222412
Sum512Base_Basic	281.097	932.576	1.020984
Sum512Base	5.601	46801.082	51.237818
Sum512Avx512_Narrow	5.518	47507.109	52.010776
Sum512Avx512_Permute	3.820	68629.385	75.135441
Sum512Avx512_Unpack	9.919	26429.397	28.934900
Sum512Traits	3.836	68346.668	74.825923

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-4734912173278815619
Check-SumBase	Check `SumBase` mismatch. -4734912171897055059!=-4734912173278815619
Check-SumTraits	Check `SumTraits` mismatch. -4722181298040287688!=-4734912173278815619
Check-SumTraits_Int128	Check `SumTraits_Int128` mismatch. 5910372263571615236!=-4734912173278815619
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
# Sum512Base_Basic	5910372263571811844
SumBase_Basic	1594.090	164.447
SumBase	1587.691	165.110	1.004030
SumTraits	1307.052	200.561	1.219607
SumTraits_Int128	38.868	6744.527	41.013270
Sum128Base_Basic	1605.001	163.329	0.993202
Sum128Base	1606.948	163.132	0.991998
Sum128Traits	1610.348	162.787	0.989904
Sum128Traits_Int128	51.601	5080.169	30.892361
Sum256Base_Basic	844.032	310.585	1.888661
Sum256Base_Move2	49.743	5269.986	32.046630
Sum256Base	42.165	6217.151	37.806311
Sum256Avx2	37.829	6929.795	42.139880
Sum256Traits	37.709	6951.690	42.273023
Sum256Traits_Int128	38.754	6764.362	41.133888
Sum512Base_Basic	678.062	386.608	2.350950
Sum512Base	75.566	3469.086	21.095411
Sum512Avx512	29.606	8854.300	53.842737
Sum512Traits	29.452	8900.684	54.124799
Sum512Traits_Int128	29.420	8910.277	54.183132

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	-24614
SumBase_Basic	372.244	704.227
SumBase_Narrow	13.640	19219.439	27.291552
SumBase_NarrowMul	37.653	6962.179	9.886276
SumBase_NarrowMulOld	86.728	3022.595	4.292077
SumBase	13.554	19340.304	27.463180
SumTraits	10.661	24589.723	34.917342
Sum128Base_Basic	375.652	697.837	0.990926
Sum128Base	25.620	10232.085	14.529533
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Narrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleNarrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Narrow	28.257	9277.071	13.173415
Sum128Sse_Permute	19.377	13528.472	19.210394
Sum128Sse_ShuffleXImm	25.589	10244.473	14.547124
Sum128Sse_Unpack	30.072	8717.110	12.378273
Sum128Traits	18.991	13803.716	19.601240
Sum256Base_Basic	365.976	716.288	1.017127
Sum256Base	13.620	19246.849	27.330474
Sum256Avx2_Narrow	13.897	18863.723	26.786437
Sum256Avx2_Permute	10.550	24848.590	35.284931
Sum256Avx2_ShuffleXImm	19.119	13711.421	19.470181
Sum256Avx2_Unpack	20.021	13093.706	18.593028
Sum256Traits	9.926	26409.251	37.501066
Sum512Base_Basic	310.739	843.615	1.197931
Sum512Base	10.890	24071.005	34.180763
Sum512Avx512_Narrow	10.979	23875.971	33.903816
Sum512Avx512_Permute	7.345	35690.855	50.680919
Sum512Avx512_ShuffleXImm	15.410	17011.339	24.156056
Sum512Avx512_Unpack	15.752	16641.785	23.631290
Sum512Traits	7.343	35699.058	50.692567

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
# Sum512Base_Basic	-468213798
SumBase_Basic	530.831	493.837
SumBase_Narrow	28.436	9218.884	18.667860
SumBase_NarrowMul	85.816	3054.721	6.185685
SumBase	27.513	9527.998	19.293804
SumTraits	20.394	12854.102	26.029027
Sum128Base_Basic	590.949	443.598	0.898269
Sum128Base	51.893	5051.649	10.229382
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Narrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleNarrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Narrow	54.362	4822.234	9.764826
Sum128Sse_Permute	38.665	6779.906	13.729030
Sum128Sse_ShuffleXImm	32.703	8015.991	16.232051
Sum128Sse_Unpack	44.089	5945.846	12.040093
Sum128Traits	34.575	7581.891	15.353016
Sum256Base_Basic	533.821	491.071	0.994398
Sum256Base	28.421	9223.473	18.677152
Sum256Avx2_Narrow	28.002	9361.660	18.956975
Sum256Avx2_Permute	20.866	12563.020	25.439597
Sum256Avx2_ShuffleXImm	24.530	10686.541	21.639804
Sum256Avx2_Unpack	30.725	8532.001	17.276950
Sum256Traits	21.603	12134.600	24.572065
Sum512Base_Basic	409.156	640.694	1.297380
Sum512Base	22.420	11692.195	23.676213
Sum512Avx512_Narrow	22.493	11654.414	23.599707
Sum512Avx512_Permute	16.312	16070.359	32.541814
Sum512Avx512_ShuffleXImm	20.161	13002.839	26.330213
Sum512Avx512_Unpack	25.624	10230.478	20.716297
Sum512Traits	16.027	16355.958	33.120142

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
# Sum512Base_Basic	5910372263571811844
SumBase_Basic	892.021	293.877
SumBase	898.619	291.719	0.992657
SumTraits	40.888	6411.331	21.816408
Sum128Base_Basic	1113.151	235.497	0.801348
Sum128Base	941.779	278.350	0.947165
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	77.719	3372.964	11.477487
Sum128Sse_Unpack	62.660	4183.587	14.235866
Sum128Traits	70.493	3718.750	12.654122
Sum256Base_Basic	887.597	295.341	1.004984
Sum256Base	902.037	290.613	0.988896
Sum256Avx2_Permute	38.127	6875.496	23.395863
Sum256Avx2_Unpack	46.893	5590.221	19.022342
Sum256Traits	42.825	6121.271	20.829394
Sum512Base_Basic	650.566	402.947	1.371145
Sum512Base	652.791	401.574	1.366472
Sum512Avx512_Permute	30.367	8632.549	29.374746
Sum512Avx512_Unpack	38.564	6797.571	23.130701
Sum512Traits	30.101	8708.720	29.633940

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	286.315	915.578
SumBase_Widen	10.061	26054.243	28.456609
SumBase_WidenMul	9.183	28546.869	31.179070
SumBase	9.795	26763.286	29.231030
SumTraits	5.477	47863.406	52.276714
Sum128Base_Basic	371.816	705.036	0.770045
Sum128Base	16.422	15963.084	17.434981
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Widen	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	9.481	27650.235	30.199762
Sum128Sse_Unpack	8.764	29912.986	32.671152
Sum128Sse_Widen	19.523	13427.685	14.665803
Sum128Traits	8.817	29731.938	32.473411
Sum256Base_Basic	305.760	857.353	0.936406
Sum256Base	9.260	28309.743	30.920080
Sum256Avx2_Permute	5.230	50125.580	54.747475
Sum256Avx2_Unpack	5.461	48004.686	52.431022
Sum256Avx2_Widen	8.655	30286.641	33.079261
Sum256Traits	5.392	48621.120	53.104294
Sum512Base_Basic	333.126	786.921	0.859480
Sum512Base	6.373	41136.073	44.929078
Sum512Avx512_Permute	3.794	69099.126	75.470501
Sum512Avx512_Unpack	4.692	55871.801	61.023534
Sum512Avx512_Widen	6.262	41864.680	45.724868
Sum512Traits	3.767	69582.222	75.998142

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-9013130398200726072
Check-SumTraits	Check `SumTraits` mismatch. -4722181267141278072!=-9013130398200726072
Check-SumTraits_Int128	Check `SumTraits_Int128` mismatch. 5910372263571615236!=-9013130398200726072
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
# Sum512Base_Basic	5910372263571811844
SumBase_Basic	1715.719	152.790
SumBase	1722.834	152.159	0.995870
SumTraits	1307.169	200.543	1.312546
SumTraits_Int128	36.092	7263.224	47.537430
Sum128Base_Basic	1604.406	163.390	1.069380
Sum128Base	1602.718	163.562	1.070506
Sum128Traits	1610.494	162.772	1.065337
Sum128Traits_Int128	52.432	4999.649	32.722447
Sum256Base_Basic	933.874	280.706	1.837206
Sum256Base_Move2	53.378	4911.082	32.142778
Sum256Base	45.340	5781.790	37.841516
Sum256Avx2	41.246	6355.561	41.596819
Sum256Traits	40.059	6543.910	42.829553
Sum256Traits_Int128	39.103	6703.968	43.877126
Sum512Base_Basic	832.366	314.938	2.061255
Sum512Base	76.634	3420.716	22.388412
Sum512Avx512	30.345	8638.700	56.539848
Sum512Avx512_Imm	39.697	6603.568	43.220014
Sum512Traits	30.697	8539.793	55.892510
Sum512Traits_Int128	30.619	8561.489	56.034504

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	-24614
SumBase_Basic	406.889	644.264
SumBase_Widen	19.577	13390.275	20.783829
SumBase_WidenMul	18.963	13824.151	21.457272
SumBase	20.263	12937.269	20.080692
SumTraits	11.003	23824.727	36.979752
Sum128Base_Basic	521.244	502.920	0.780611
Sum128Base	32.720	8011.845	12.435653
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Widen	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	21.190	12371.148	19.201982
Sum128Sse_Unpack	17.484	14993.236	23.271878
Sum128Sse_Widen	38.831	6750.856	10.478399
Sum128Traits	17.507	14973.416	23.241115
Sum256Base_Basic	400.264	654.927	1.016551
Sum256Base	17.957	14598.709	22.659509
Sum256Avx2_Permute	11.057	23707.400	36.797641
Sum256Avx2_Unpack	10.792	24289.745	37.701533
Sum256Avx2_Widen	19.785	13249.319	20.565043
Sum256Traits	10.450	25084.652	38.935355
Sum512Base_Basic	397.891	658.833	1.022613
Sum512Base	12.970	20212.267	31.372642
Sum512Avx512_Permute	7.620	34402.753	53.398525
Sum512Avx512_Unpack	9.847	26620.425	41.319118
Sum512Avx512_Widen	12.448	21058.887	32.686729
Sum512Traits	7.316	35829.759	55.613464

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
# Sum512Base_Basic	-468213798
SumBase_Basic	585.171	447.979
SumBase_Widen	34.481	7602.512	16.970705
SumBase	35.130	7462.036	16.657127
SumTraits	22.331	11738.805	26.203942
Sum128Base_Basic	817.823	320.539	0.715522
Sum128Base	63.357	4137.601	9.236157
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Widen	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	41.041	6387.365	14.258193
Sum128Sse_Unpack	33.902	7732.334	17.260500
Sum128Sse_Widen	79.538	3295.814	7.357079
Sum128Traits	33.712	7775.915	17.357784
Sum256Base_Basic	578.531	453.120	1.011478
Sum256Base	34.939	7502.829	16.748186
Sum256Avx2_Permute	21.127	12408.010	27.697775
Sum256Avx2_Unpack	21.870	11986.333	26.756487
Sum256Avx2_Widen	33.289	7874.688	17.578269
Sum256Traits	21.943	11946.741	26.668108
Sum512Base_Basic	562.845	465.748	1.039667
Sum512Base	25.308	10358.249	23.122196
Sum512Avx512_Permute	15.933	16452.672	36.726470
Sum512Avx512_Unpack	19.519	13430.330	29.979849
Sum512Avx512_Widen	25.526	10269.652	22.924426
Sum512Traits	15.790	16601.793	37.059344

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
# Sum512Base_Basic	5910372263571811844
SumBase_Basic	993.688	263.809
SumBase	975.077	268.844	1.019086
SumTraits	38.480	6812.400	25.823214
Sum128Base_Basic	1549.762	169.151	0.641187
Sum128Base	940.181	278.823	1.056911
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	70.505	3718.110	14.093938
Sum128Sse_Unpack	68.098	3849.535	14.592122
Sum128Traits	62.795	4174.581	15.824247
Sum256Base_Basic	983.637	266.505	1.010219
Sum256Base	971.813	269.747	1.022510
Sum256Avx2_Permute	38.394	6827.779	25.881510
Sum256Avx2_Unpack	40.569	6461.752	24.494040
Sum256Traits	39.598	6620.095	25.094256
Sum512Base_Basic	917.444	285.733	1.083104
Sum512Base	922.309	284.226	1.077392
Sum512Avx512_Permute	30.050	8723.450	33.067275
Sum512Avx512_Unpack	37.229	7041.407	26.691291
Sum512Traits	29.215	8973.013	34.013275

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	276.364	948.546
SumBase_NarrowMul	32.540	8055.991	8.492992
SumBase	32.541	8055.920	8.492917
SumTraits	9.632	27216.212	28.692568
Sum128Base_Basic	420.530	623.366	0.657181
Sum128Base	418.859	625.853	0.659802
Sum128AdvSimd_Narrow	9.653	27157.758	28.630943
Sum128AdvSimd_Shuffle	10.275	25512.989	26.896953
Sum128AdvSimdB64	9.632	27214.652	28.690924
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.632	27216.494	28.692866
Sum256Base_Basic	396.974	660.356	0.696178
Sum256Base	397.538	659.419	0.695189
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	397.088	660.165	0.695976

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	934.417	280.543
SumBase	853.173	307.258	1.095225
SumTraits	853.525	307.131	1.094773
SumTraits_Int128	232.832	1125.894	4.013266
Sum128Base_Basic	615.188	426.120	1.518913
Sum128Base	617.056	424.830	1.514314
Sum128Traits	103.881	2523.511	8.995096
Sum128Traits_Int128	77.066	3401.545	12.124862
Sum256Base_Basic	1317.397	198.986	0.709290
Sum256Base_Move2	1214.759	215.799	0.769220
Sum256Base	608.114	431.077	1.536581
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	608.055	431.119	1.536729
Sum256Traits_Int128	608.242	430.987	1.536259

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	399.645	655.942
SumBase_NarrowMul	36.172	7247.117	11.048412
SumBase_NarrowMulOld	91.014	2880.252	4.391017
SumBase	36.165	7248.461	11.050461
SumTraits	19.265	13607.304	20.744678
Sum128Base_Basic	538.450	486.849	0.742214
Sum128Base	536.564	488.560	0.744822
Sum128AdvSimd_Narrow	19.293	13587.433	20.714384
Sum128AdvSimd_Shuffle	20.510	12781.464	19.485664
Sum128AdvSimdB64	19.276	13599.345	20.732544
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.275	13600.267	20.733950
Sum256Base_Basic	538.757	486.572	0.741791
Sum256Base	537.379	487.820	0.743694
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	538.747	486.581	0.741805

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	448.016	585.122
SumBase_NarrowMul	91.584	2862.346	4.891880
SumBase	91.574	2862.651	4.892400
SumTraits	38.534	6802.900	11.626467
Sum128Base_Basic	722.548	362.805	0.620050
Sum128Base	719.574	364.304	0.622613
Sum128AdvSimd_Narrow	38.584	6794.164	11.611537
Sum128AdvSimd_Shuffle	40.991	6395.088	10.929497
Sum128AdvSimdB64	38.544	6801.150	11.623475
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.532	6803.283	11.627120
Sum256Base_Basic	742.014	353.287	0.603784
Sum256Base	738.228	355.099	0.606880
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	741.769	353.404	0.603983

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	821.121	319.251
SumBase	759.407	345.196	1.081266
SumTraits	77.074	3401.203	10.653679
Sum128Base_Basic	1232.046	212.771	0.666469
Sum128Base	577.042	454.289	1.422983
Sum128AdvSimd_AlignRight	77.087	3400.637	10.651905
Sum128AdvSimd_Shuffle	81.969	3198.080	10.017431
Sum128AdvSimdB64	77.074	3401.216	10.653720
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.070	3401.377	10.654224
Sum256Base_Basic	1282.270	204.437	0.640365
Sum256Base	1278.257	205.079	0.642375
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1286.584	203.752	0.638217

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	233.702	1121.702
SumBase_WidenMul	13.283	19735.898	17.594607
SumBase	13.281	19738.304	17.596752
SumTraits	9.634	27208.897	24.256806
Sum128Base_Basic	363.861	720.451	0.642284
Sum128Base	363.074	722.013	0.643677
Sum128AdvSimd_Shuffle	24.725	10602.375	9.452046
Sum128AdvSimd_Widen	10.871	24113.131	21.496922
Sum128AdvSimdB64	9.636	27204.146	24.252570
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.637	27201.822	24.250498
Sum256Base_Basic	382.209	685.865	0.611451
Sum256Base	393.343	666.452	0.594144
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	392.142	668.493	0.595964

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	427.946	612.563
SumBase	431.988	606.832	0.990644
SumTraits	431.968	606.860	0.990691
SumTraits_Int128	232.839	1125.858	1.837947
Sum128Base_Basic	616.412	425.274	0.694254
Sum128Base	621.640	421.698	0.688416
Sum128Traits	103.879	2523.555	4.119669
Sum128Traits_Int128	77.072	3401.307	5.552586
Sum256Base_Basic	1147.063	228.535	0.373080
Sum256Base_Move2	1214.758	215.799	0.352289
Sum256Base	608.367	430.897	0.703434
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	608.204	431.013	0.703624
Sum256Traits_Int128	608.221	431.001	0.703603

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	295.152	888.167
SumBase_WidenMul	26.528	9881.644	11.125887
SumBase	26.526	9882.532	11.126886
SumTraits	19.275	13600.489	15.312988
Sum128Base_Basic	421.977	621.228	0.699449
Sum128Base	422.803	620.015	0.698084
Sum128AdvSimd_Shuffle	49.420	5304.443	5.972349
Sum128AdvSimd_Widen	21.711	12074.034	13.594331
Sum128AdvSimdB64	19.281	13596.118	15.308067
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.276	13599.582	15.311967
Sum256Base_Basic	484.998	540.506	0.608563
Sum256Base	484.522	541.037	0.609161
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	484.374	541.202	0.609347

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	358.953	730.301
SumBase	358.959	730.289	0.999983
SumTraits	38.531	6803.525	9.316051
Sum128Base_Basic	511.622	512.378	0.701598
Sum128Base	511.587	512.413	0.701647
Sum128AdvSimd_Shuffle	98.792	2653.502	3.633434
Sum128AdvSimd_Widen	43.395	6040.927	8.271827
Sum128AdvSimdB64	38.537	6802.342	9.314430
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.531	6803.460	9.315962
Sum256Base_Basic	687.677	381.202	0.521979
Sum256Base	685.037	382.671	0.523991
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	684.959	382.715	0.524051

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	361.886	724.382
SumBase	361.842	724.472	1.000124
SumTraits	77.076	3401.132	4.695219
Sum128Base_Basic	924.165	283.655	0.391582
Sum128Base	576.761	454.511	0.627447
Sum128AdvSimd_AlignRight	77.084	3400.754	4.694697
Sum128AdvSimd_Shuffle	197.554	1326.952	1.831840
Sum128AdvSimdB64	77.078	3401.017	4.695060
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.067	3401.527	4.695764
Sum256Base_Basic	1191.055	220.094	0.303837
Sum256Base	1189.639	220.356	0.304198
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1191.845	219.948	0.303635

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	212.026	1236.377
SumBase_Narrow	9.669	27112.984	21.929391
SumBase_NarrowMul	28.937	9059.240	7.327250
SumBase	9.649	27168.382	21.974197
SumTraits	9.629	27225.638	22.020507
Sum128Base_Basic	211.296	1240.649	1.003455
Sum128Base	9.643	27183.562	21.986475
Sum128AdvSimd_Narrow	9.647	27172.977	21.977913
Sum128AdvSimd_Shuffle	9.709	27000.346	21.838287
Sum128AdvSimdB64	9.628	27225.977	22.020781
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.632	27216.934	22.013467
Sum256Base_Basic	422.558	620.374	0.501768
Sum256Base	423.162	619.489	0.501052
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	422.300	620.753	0.502074

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	881.928	297.240
SumBase	879.154	298.177	1.003155
SumTraits	1476.794	177.509	0.597191
SumTraits_Int128	231.448	1132.628	3.810488
Sum128Base_Basic	103.946	2521.924	8.484485
Sum128Base	103.942	2522.019	8.484804
Sum128Traits	103.935	2522.192	8.485387
Sum128Traits_Int128	77.074	3401.209	11.442655
Sum256Base_Basic	1169.858	224.082	0.753877
Sum256Base_Move2	1312.176	199.778	0.672111
Sum256Base	739.661	354.411	1.192342
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	734.488	356.907	1.200739
Sum256Traits_Int128	734.549	356.878	1.200640

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	284.000	923.041
SumBase_Narrow	19.276	13599.794	14.733689
SumBase_NarrowMul	33.781	7760.100	8.407105
SumBase_NarrowMulOld	79.161	3311.524	3.587625
SumBase	19.278	13598.173	14.731931
SumTraits	19.260	13610.787	14.745597
Sum128Base_Basic	285.432	918.413	0.994986
Sum128Base	19.281	13595.757	14.729314
Sum128AdvSimd_Narrow	19.278	13598.340	14.732113
Sum128AdvSimd_Shuffle	19.594	13378.806	14.494275
Sum128AdvSimdB64	19.266	13606.431	14.740879
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.262	13609.488	14.744190
Sum256Base_Basic	537.834	487.407	0.528045
Sum256Base	541.376	484.218	0.524590
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	541.966	483.691	0.524019

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	389.141	673.648
SumBase_Narrow	38.549	6800.356	10.094828
SumBase_NarrowMul	77.311	3390.759	5.033432
SumBase	38.554	6799.326	10.093299
SumTraits	38.530	6803.697	10.099788
Sum128Base_Basic	392.442	667.981	0.991588
Sum128Base	38.544	6801.216	10.096105
Sum128AdvSimd_Narrow	38.546	6800.890	10.095621
Sum128AdvSimd_Shuffle	39.135	6698.474	9.943589
Sum128AdvSimdB64	38.535	6802.758	10.098395
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.533	6803.039	10.098811
Sum256Base_Basic	779.056	336.489	0.499503
Sum256Base	779.911	336.120	0.498956
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	776.005	337.812	0.501468

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	690.742	379.511
SumBase	687.170	381.484	1.005198
SumTraits	77.060	3401.804	8.963658
Sum128Base_Basic	684.944	382.723	1.008465
Sum128Base	77.080	3400.947	8.961400
Sum128AdvSimd_AlignRight	77.073	3401.239	8.962170
Sum128AdvSimd_Shuffle	78.015	3360.153	8.853910
Sum128AdvSimdB64	77.070	3401.369	8.962513
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.067	3401.488	8.962826
Sum256Base_Basic	1353.614	193.662	0.510295
Sum256Base	1348.152	194.447	0.512362
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1360.382	192.699	0.507756

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	169.865	1543.253
SumBase_Widen	9.670	27109.222	17.566287
SumBase_WidenMul	10.274	25514.269	16.532787
SumBase	9.668	27113.370	17.568975
SumTraits	9.631	27219.139	17.637512
Sum128Base_Basic	169.852	1543.367	1.000074
Sum128Base	39.818	6583.559	4.266028
Sum128AdvSimd_Shuffle	28.934	9059.995	5.870713
Sum128AdvSimd_Widen	9.668	27113.828	17.569272
Sum128AdvSimdB64	9.626	27232.113	17.645918
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.628	27228.560	17.643617
Sum256Base_Basic	405.658	646.220	0.418739
Sum256Base	405.883	645.861	0.418506
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	405.845	645.922	0.418546

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	822.264	318.807
SumBase	811.963	322.852	1.012688
SumTraits	1702.539	153.972	0.482964
SumTraits_Int128	231.482	1132.459	3.552173
Sum128Base_Basic	103.929	2522.336	7.911786
Sum128Base	105.011	2496.349	7.830273
Sum128Traits	105.004	2496.518	7.830802
Sum128Traits_Int128	77.076	3401.096	10.668184
Sum256Base_Basic	966.413	271.255	0.850842
Sum256Base_Move2	1312.247	199.767	0.626608
Sum256Base	739.622	354.430	1.111736
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	733.887	357.199	1.120424
Sum256Traits_Int128	734.176	357.059	1.119983

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	207.206	1265.140
SumBase_Widen	19.305	13578.901	10.733120
SumBase_WidenMul	20.505	12784.629	10.105307
SumBase	19.303	13580.188	10.734138
SumTraits	19.266	13606.474	10.754915
Sum128Base_Basic	207.238	1264.943	0.999844
Sum128Base	79.930	3279.651	2.592322
Sum128AdvSimd_Shuffle	57.840	4532.203	3.582372
Sum128AdvSimd_Widen	19.303	13580.561	10.734432
Sum128AdvSimdB64	19.270	13603.788	10.752792
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.270	13603.560	10.752612
Sum256Base_Basic	471.188	556.347	0.439752
Sum256Base	473.537	553.587	0.437570
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	473.603	553.510	0.437509

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	217.309	1206.318
SumBase_Widen	38.567	6797.140	5.634619
SumBase	38.572	6796.200	5.633839
SumTraits	38.532	6803.240	5.639676
Sum128Base_Basic	217.365	1206.010	0.999745
Sum128Base	159.850	1639.939	1.359459
Sum128AdvSimd_Shuffle	115.646	2266.772	1.879084
Sum128AdvSimd_Widen	38.569	6796.707	5.634260
Sum128AdvSimdB64	38.523	6804.787	5.640958
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.534	6803.010	5.639485
Sum256Base_Basic	652.447	401.786	0.333068
Sum256Base	651.617	402.298	0.333493
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	648.965	403.942	0.334855

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	357.190	733.905
SumBase	357.142	734.006	1.000136
SumTraits	77.058	3401.917	4.635361
Sum128Base_Basic	357.187	733.912	1.000008
Sum128Base	77.093	3400.374	4.633259
Sum128AdvSimd_AlignRight	77.091	3400.448	4.633360
Sum128AdvSimd_Shuffle	231.249	1133.603	1.544617
Sum128AdvSimdB64	77.098	3400.125	4.632920
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.070	3401.368	4.634613
Sum256Base_Basic	1118.921	234.283	0.319228
Sum256Base	1121.422	233.760	0.318516
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1119.605	234.140	0.319033

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	149.923	1748.526
SumBase_Narrow	9.642	27187.294	15.548694
SumBase_NarrowMul	26.537	9878.565	5.649653
SumBase	9.640	27192.274	15.551542
SumTraits	9.627	27230.020	15.573130
Sum128Base_Basic	149.909	1748.683	1.000090
Sum128Base	9.639	27197.478	15.554518
Sum128AdvSimd_Narrow	9.639	27196.364	15.553881
Sum128AdvSimd_Shuffle	9.689	27054.744	15.472887
Sum128AdvSimd_ShuffleX	13.879	18888.399	10.802471
Sum128AdvSimdB64	9.624	27237.363	15.577329
Sum128PackedSimd_Narrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleNarrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.626	27231.839	15.574170
Sum256Base_Basic	146.639	1787.678	1.022392
Sum256Base	146.632	1787.762	1.022440
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	146.627	1787.829	1.022478
Sum512Base_Basic	151.561	1729.632	0.989194
Sum512Base	151.608	1729.086	0.988882
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	151.614	1729.020	0.988844

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	311.801	840.742
SumBase	320.440	818.075	0.973039
SumTraits	353.351	741.880	0.882411
SumTraits_Int128	77.052	3402.169	4.046627
Sum128Base_Basic	77.085	3400.711	4.044893
Sum128Base	77.076	3401.117	4.045376
Sum128Traits	77.077	3401.047	4.045292
Sum128Traits_Int128	77.072	3401.308	4.045603
Sum256Base_Basic	283.578	924.416	1.099524
Sum256Base_Move2	39.570	6624.754	7.879652
Sum256Base	39.575	6623.976	7.878727
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	39.568	6625.078	7.880037
Sum256Traits_Int128	39.572	6624.444	7.879283
Sum512Base_Basic	348.278	752.686	0.895265
Sum512Base	22.899	11448.000	13.616544
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	22.894	11450.213	13.619176
Sum512Traits_Int128	22.898	11448.456	13.617086

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	165.447	1584.459
SumBase_Narrow	19.270	13604.046	8.585924
SumBase_NarrowMul	31.397	8349.315	5.269505
SumBase_NarrowMulOld	75.246	3483.830	2.198750
SumBase	19.268	13605.269	8.586696
SumTraits	19.259	13611.175	8.590424
Sum128Base_Basic	165.513	1583.825	0.999599
Sum128Base	19.269	13604.651	8.586306
Sum128AdvSimd_Narrow	19.269	13604.507	8.586215
Sum128AdvSimd_Shuffle	19.553	13407.121	8.461639
Sum128AdvSimd_ShuffleX	27.723	9455.831	5.967860
Sum128AdvSimdB64	19.266	13606.912	8.587733
Sum128PackedSimd_Narrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleNarrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.259	13611.168	8.590419
Sum256Base_Basic	158.602	1652.838	1.043156
Sum256Base	158.639	1652.459	1.042917
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	158.626	1652.588	1.042998
Sum512Base_Basic	168.495	1555.799	0.981912
Sum512Base	168.510	1555.660	0.981824
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	168.499	1555.760	0.981887

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
# Sum512Base_Basic	-467853350
SumBase_Basic	191.377	1369.777
SumBase_Narrow	38.541	6801.702	4.965555
SumBase_NarrowMul	72.650	3608.292	2.634219
SumBase	38.540	6801.895	4.965696
SumTraits	38.528	6804.044	4.967265
Sum128Base_Basic	191.374	1369.803	1.000019
Sum128Base	38.542	6801.439	4.965363
Sum128AdvSimd_Narrow	38.543	6801.303	4.965264
Sum128AdvSimd_Shuffle	39.076	6708.523	4.897530
Sum128AdvSimd_ShuffleX	55.430	4729.263	3.452580
Sum128AdvSimdB64	38.528	6803.936	4.967187
Sum128PackedSimd_Narrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleNarrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.527	6804.115	4.967317
Sum256Base_Basic	186.602	1404.830	1.025590
Sum256Base	186.580	1404.999	1.025714
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	186.610	1404.771	1.025547
Sum512Base_Basic	206.953	1266.684	0.924738
Sum512Base	206.859	1267.261	0.925159
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	206.923	1266.870	0.924873

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	294.646	889.691
SumBase	294.662	889.643	0.999947
SumTraits	77.060	3401.819	3.823596
Sum128Base_Basic	294.707	889.508	0.999795
Sum128Base	77.066	3401.540	3.823282
Sum128AdvSimd_AlignRight	77.068	3401.468	3.823201
Sum128AdvSimd_Shuffle	77.962	3362.437	3.779332
Sum128AdvSimd_ShuffleX	110.830	2365.289	2.658551
Sum128AdvSimdB64	77.074	3401.213	3.822915
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.069	3401.436	3.823165
Sum256Base_Basic	278.757	940.403	1.057000
Sum256Base	278.638	940.803	1.057449
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	278.725	940.511	1.057121
Sum512Base_Basic	345.402	758.953	0.853052
Sum512Base	345.666	758.374	0.852401
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	345.532	758.669	0.852733

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	203.543	1287.904
SumBase_Widen	9.662	27131.156	21.066134
SumBase_WidenMul	10.868	24120.321	18.728354
SumBase	9.663	27128.047	21.063720
SumTraits	9.625	27236.156	21.147662
Sum128Base_Basic	203.544	1287.897	0.999994
Sum128Base	9.658	27141.429	21.074110
Sum128AdvSimd_Shuffle	28.926	9062.508	7.036634
Sum128AdvSimd_ShuffleX	15.291	17143.654	13.311283
Sum128AdvSimd_Widen	9.663	27127.240	21.063093
Sum128AdvSimdB64	9.625	27235.786	21.147374
Sum128PackedSimd_Widen	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.627	27229.664	21.142621
Sum256Base_Basic	193.006	1358.219	1.054597
Sum256Base	192.989	1358.339	1.054690
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	192.993	1358.307	1.054664
Sum512Base_Basic	193.071	1357.760	1.054240
Sum512Base	193.213	1356.758	1.053463
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	193.090	1357.628	1.054138

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	915.854	286.229
SumBase	920.612	284.750	0.994832
SumTraits	353.323	741.938	2.592114
SumTraits_Int128	77.068	3401.442	11.883643
Sum128Base_Basic	77.082	3400.855	11.881589
Sum128Base	77.085	3400.717	11.881109
Sum128Traits	77.085	3400.717	11.881109
Sum128Traits_Int128	77.070	3401.389	11.883457
Sum256Base_Basic	380.802	688.399	2.405065
Sum256Base_Move2	39.585	6622.375	23.136638
Sum256Base	39.580	6623.064	23.139045
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	39.595	6620.656	23.130632
Sum256Traits_Int128	39.584	6622.403	23.136734
Sum512Base_Basic	388.071	675.505	2.360015
Sum512Base	22.906	11444.364	39.983254
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Imm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	22.902	11446.472	39.990618
Sum512Traits_Int128	22.895	11449.772	40.002147

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	236.947	1106.338
SumBase_Widen	19.298	13584.325	12.278637
SumBase_WidenMul	21.699	12081.156	10.919948
SumBase	19.293	13587.563	12.281563
SumTraits	19.254	13614.762	12.306148
Sum128Base_Basic	236.918	1106.475	1.000123
Sum128Base	19.293	13587.827	12.281802
Sum128AdvSimd_Shuffle	57.815	4534.170	4.098358
Sum128AdvSimd_ShuffleX	30.707	8536.831	7.716294
Sum128AdvSimd_Widen	19.296	13585.499	12.279698
Sum128AdvSimdB64	19.265	13607.363	12.299461
Sum128PackedSimd_Widen	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.262	13609.137	12.301064
Sum256Base_Basic	213.744	1226.441	1.108559
Sum256Base	213.749	1226.412	1.108533
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	213.761	1226.342	1.108470
Sum512Base_Basic	221.100	1185.633	1.071673
Sum512Base	221.097	1185.650	1.071689
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	221.101	1185.631	1.071672

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
# Sum512Base_Basic	-467853350
SumBase_Basic	214.917	1219.745
SumBase_Widen	38.581	6794.697	5.570590
SumBase	38.572	6796.244	5.571858
SumTraits	38.535	6802.782	5.577218
Sum128Base_Basic	214.894	1219.878	1.000109
Sum128Base	38.575	6795.693	5.571406
Sum128AdvSimd_Shuffle	115.608	2267.534	1.859023
Sum128AdvSimd_ShuffleX	61.749	4245.319	3.480498
Sum128AdvSimd_Widen	38.565	6797.458	5.572854
Sum128AdvSimdB64	38.521	6805.139	5.579151
Sum128PackedSimd_Widen	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.530	6803.670	5.577946
Sum256Base_Basic	256.762	1020.960	0.837028
Sum256Base	257.154	1019.403	0.835751
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	257.901	1016.452	0.833332
Sum512Base_Basic	269.375	973.158	0.797837
Sum512Base	269.360	973.209	0.797880
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	269.419	972.998	0.797706

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	333.480	786.087
SumBase	333.478	786.090	1.000003
SumTraits	77.068	3401.456	4.327073
Sum128Base_Basic	333.477	786.092	1.000006
Sum128Base	77.080	3400.940	4.326417
Sum128AdvSimd_AlignRight	77.083	3400.811	4.326252
Sum128AdvSimd_Shuffle	231.249	1133.602	1.442083
Sum128AdvSimd_ShuffleX	124.072	2112.837	2.687790
Sum128AdvSimdB64	77.056	3401.982	4.327742
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.068	3401.445	4.327059
Sum256Base_Basic	285.600	917.870	1.167644
Sum256Base	288.120	909.844	1.157434
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	287.021	913.326	1.161864
Sum512Base_Basic	429.263	610.684	0.776865
Sum512Base	431.604	607.372	0.772652
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	429.841	609.863	0.775821

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
Check-SumBase_NarrowMul	Check `SumBase_NarrowMul` mismatch. 4!=114
Check-SumBase	Check `SumBase` mismatch. 4!=114
Check-SumTraits	Check `SumTraits` mismatch. 4!=114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	744.333	352.186
SumBase_NarrowMul	146.226	1792.734	5.090300
SumBase	145.921	1796.479	5.100934
SumTraits	146.896	1784.551	5.067065
Sum128Base_Basic	1323.500	198.069	0.562397
Sum128Base	1380.645	189.871	0.539120
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1379.858	189.979	0.539427
Sum256Base_Basic	1310.306	200.063	0.568061
Sum256Base	1337.986	195.924	0.556309
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1443.240	181.636	0.515738

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	5243.576	49.993
SumBase	5580.946	46.971	0.939550
SumTraits	6262.700	41.858	0.837271
SumTraits_Int128	636.935	411.571	8.232514
Sum128Base_Basic	1108.914	236.397	4.728570
Sum128Base	1093.583	239.711	4.794858
Sum128Traits	1086.899	241.185	4.824347
Sum128Traits_Int128	1037.258	252.728	5.055230
Sum256Base_Basic	5383.934	48.690	0.973930
Sum256Base_Move2	6971.783	37.601	0.752114
Sum256Base	5781.413	45.343	0.906971
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	6679.724	39.245	0.784999
Sum256Traits_Int128	3718.485	70.498	1.410138

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1059.716	247.372
SumBase_NarrowMul	163.431	1604.007	6.484193
SumBase_NarrowMulOld	358.680	730.857	2.954487
SumBase	163.381	1604.491	6.486153
SumTraits	163.823	1600.161	6.468648
Sum128Base_Basic	1837.175	142.689	0.576818
Sum128Base	1840.304	142.446	0.575838
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1844.467	142.125	0.574538
Sum256Base_Basic	2142.698	122.343	0.494571
Sum256Base	2178.038	120.358	0.486546
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2424.424	108.126	0.437100

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	1216.370	215.513
SumBase_NarrowMul	370.358	707.813	3.284312
SumBase	368.443	711.491	3.301380
SumTraits	369.122	710.183	3.295307
Sum128Base_Basic	2673.987	98.035	0.454890
Sum128Base	2679.942	97.817	0.453879
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2675.249	97.989	0.454676
Sum256Base_Basic	3236.479	80.997	0.375831
Sum256Base	3342.054	78.438	0.363959
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3789.906	69.169	0.320950

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	1824.899	143.649
SumBase	1808.639	144.940	1.008990
SumTraits	1808.369	144.962	1.009141
Sum128Base_Basic	2733.786	95.890	0.667535
Sum128Base	1837.309	142.678	0.993245
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1869.596	140.214	0.976092
Sum256Base_Basic	4990.751	52.526	0.365656
Sum256Base	5102.426	51.376	0.357653
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	6043.586	43.376	0.301956

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	701.934	373.460
SumBase_WidenMul	51.790	5061.669	13.553453
SumBase	51.759	5064.680	13.561514
SumTraits	51.819	5058.821	13.545827
Sum128Base_Basic	1196.117	219.163	0.586844
Sum128Base	1196.365	219.117	0.586722
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1196.447	219.102	0.586682
Sum256Base_Basic	1152.031	227.549	0.609301
Sum256Base	1172.792	223.521	0.598515
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1286.938	203.696	0.545429

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	3651.413	71.792
SumBase	3826.955	68.499	0.954130
SumTraits	4335.867	60.459	0.842141
SumTraits_Int128	636.449	411.885	5.737162
Sum128Base_Basic	1092.075	240.042	3.343556
Sum128Base	1116.361	234.820	3.270816
Sum128Traits	1103.473	237.563	3.309018
Sum128Traits_Int128	1029.091	254.734	3.548192
Sum256Base_Basic	4032.312	65.011	0.905538
Sum256Base_Move2	6967.929	37.622	0.524031
Sum256Base	5778.832	45.363	0.631860
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	6728.982	38.957	0.542640
Sum256Traits_Int128	3710.902	70.642	0.983969

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	908.167	288.652
SumBase_WidenMul	103.625	2529.726	8.763939
SumBase	103.601	2530.327	8.766023
SumTraits	103.643	2529.287	8.762420
Sum128Base_Basic	1661.015	157.822	0.546755
Sum128Base	1661.786	157.748	0.546501
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1661.966	157.731	0.546442
Sum256Base_Basic	1809.041	144.908	0.502016
Sum256Base	1842.813	142.252	0.492816
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2082.679	125.869	0.436057

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	1070.190	244.951
SumBase	1060.211	247.256	1.009412
SumTraits	1057.773	247.826	1.011739
Sum128Base_Basic	2396.087	109.405	0.446641
Sum128Base	2397.153	109.356	0.446442
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2398.622	109.289	0.446169
Sum256Base_Basic	2649.002	98.960	0.403998
Sum256Base	2741.157	95.633	0.390416
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3188.958	82.204	0.335593

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	1161.307	225.732
SumBase	1164.040	225.202	0.997652
SumTraits	1159.610	226.062	1.001463
Sum128Base_Basic	2113.119	124.056	0.549570
Sum128Base	1845.034	142.081	0.629423
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1829.308	143.302	0.634834
Sum256Base_Basic	3855.802	67.987	0.301184
Sum256Base	4081.709	64.224	0.284515
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	5000.985	52.418	0.232216

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	749.633	349.696
SumBase_NarrowMul	121.522	2157.173	6.168705
SumBase	122.099	2146.987	6.139578
SumTraits	18.309	14317.845	40.943663
Sum128Base_Basic	1311.040	199.951	0.571785
Sum128Base	1303.088	201.171	0.575274
Sum128AdvSimd_Narrow	26.962	9722.612	27.803023
Sum128AdvSimd_Shuffle	29.864	8777.794	25.101197
Sum128AdvSimdB64	19.864	13196.828	37.737976
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.842	13211.635	37.780319
Sum256Base_Basic	1189.325	220.414	0.630302
Sum256Base	1192.514	219.825	0.628616
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1201.831	218.120	0.623743

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	8988900299020692996
Check-Sum128Base	Check `Sum128Base` mismatch. 6243581461422140932!=8988900299020692996
Check-Sum128Traits	Check `Sum128Traits` mismatch. 6037064977014844932!=8988900299020692996
Check-Sum128Traits_Int128	Check `Sum128Traits_Int128` mismatch. 5910372263571877380!=8988900299020692996
# Sum256Base_Basic	5910372263571942916

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	748.673	350.145
SumBase_NarrowMul	121.267	2161.706	6.173746
SumBase	121.249	2162.039	6.174697
SumTraits	18.316	14312.472	40.875851
Sum128Base_Basic	1297.820	201.988	0.576869
Sum128Base	1311.922	199.817	0.570669
Sum128AdvSimd_Narrow	27.092	9676.080	27.634500
Sum128AdvSimd_Shuffle	29.541	8873.821	25.343279
Sum128AdvSimdB64	19.891	13179.033	37.638795
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.848	13207.521	37.720154
Sum256Base_Basic	1167.870	224.463	0.641059
Sum256Base	1181.827	221.813	0.633488
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1181.615	221.852	0.633601

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	2467.731	106.229
SumBase	2316.357	113.171	1.065350
SumTraits	2317.727	113.104	1.064720
SumTraits_Int128	385.788	679.502	6.396593
Sum128Base_Basic	1099.524	238.416	2.244363
Sum128Base	1096.781	239.012	2.249976
Sum128Traits	337.785	776.068	7.305632
Sum128Traits_Int128	124.651	2103.017	19.797058
Sum256Base_Basic	2996.077	87.496	0.823654
Sum256Base_Move2	2943.968	89.044	0.838233
Sum256Base	1648.636	159.007	1.496832
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1669.280	157.040	1.478320
Sum256Traits_Int128	1668.996	157.067	1.478572

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1043.870	251.127
SumBase_NarrowMul	152.429	1719.777	6.848237
SumBase_NarrowMulOld	315.865	829.924	3.304800
SumBase	152.529	1718.645	6.843730
SumTraits	40.044	6546.330	26.067806
Sum128Base_Basic	1824.962	143.644	0.571996
Sum128Base	1844.411	142.129	0.565964
Sum128AdvSimd_Narrow	59.969	4371.329	17.406847
Sum128AdvSimd_Shuffle	62.532	4192.131	16.693273
Sum128AdvSimdB64	37.509	6988.773	27.829638
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	40.282	6507.695	25.913961
Sum256Base_Basic	1626.987	161.122	0.641597
Sum256Base	1638.281	160.012	0.637174
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1634.275	160.404	0.638736

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	1263.472	207.479
SumBase_NarrowMul	327.141	801.319	3.862169
SumBase	327.111	801.392	3.862523
SumTraits	80.631	3251.162	15.669838
Sum128Base_Basic	2674.702	98.009	0.472379
Sum128Base	2671.365	98.131	0.472969
Sum128AdvSimd_Narrow	118.721	2208.068	10.642369
Sum128AdvSimd_Shuffle	126.364	2074.507	9.998637
Sum128AdvSimdB64	80.524	3255.483	15.690661
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	75.869	3455.241	16.653447
Sum256Base_Basic	2393.612	109.518	0.527852
Sum256Base	2435.957	107.614	0.518676
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2437.519	107.545	0.518344

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	1927.581	135.996
SumBase	1932.275	135.666	0.997571
SumTraits	160.888	1629.354	11.980867
Sum128Base_Basic	2840.504	92.288	0.678605
Sum128Base	1058.121	247.745	1.821702
Sum128AdvSimd_AlignRight	178.091	1471.969	10.823594
Sum128AdvSimd_Shuffle	252.468	1038.324	7.634937
Sum128AdvSimdB64	149.941	1748.315	12.855603
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	149.557	1752.798	12.888565
Sum256Base_Basic	3290.770	79.660	0.585754
Sum256Base	3251.612	80.620	0.592808
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3287.661	79.736	0.586308

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	696.060	376.611
SumBase_WidenMul	46.632	5621.488	14.926495
SumBase	46.663	5617.840	14.916808
SumTraits	18.303	14322.424	38.029717
Sum128Base_Basic	1195.034	219.361	0.582460
Sum128Base	1195.035	219.361	0.582460
Sum128AdvSimd_Shuffle	74.566	3515.619	9.334872
Sum128AdvSimd_Widen	36.590	7164.315	19.023098
Sum128AdvSimdB64	19.853	13204.449	35.061206
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.842	13211.278	35.079339
Sum256Base_Basic	1132.277	231.519	0.614743
Sum256Base	1156.907	226.590	0.601656
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1170.658	223.929	0.594589

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	1487.560	176.224
SumBase	1554.619	168.623	0.956864
SumTraits	1550.918	169.025	0.959148
SumTraits_Int128	385.846	679.400	3.855318
Sum128Base_Basic	1096.208	239.137	1.357005
Sum128Base	1099.421	238.438	1.353040
Sum128Traits	336.466	779.110	4.421131
Sum128Traits_Int128	124.592	2104.020	11.939452
Sum256Base_Basic	3095.846	84.676	0.480502
Sum256Base_Move2	2947.808	88.928	0.504633
Sum256Base	1669.684	157.002	0.890923
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1648.574	159.013	0.902331
Sum256Traits_Int128	1666.955	157.259	0.892381

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	911.020	287.748
SumBase_WidenMul	93.314	2809.261	9.762926
SumBase	92.936	2820.679	9.802605
SumTraits	40.043	6546.508	22.750849
Sum128Base_Basic	1673.668	156.628	0.544325
Sum128Base	1674.043	156.593	0.544203
Sum128AdvSimd_Shuffle	137.363	1908.404	6.632211
Sum128AdvSimd_Widen	78.185	3352.884	11.652158
Sum128AdvSimdB64	37.375	7013.915	24.375212
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	37.447	7000.348	24.328063
Sum256Base_Basic	1621.157	161.702	0.561957
Sum256Base	1611.873	162.633	0.565193
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1613.059	162.514	0.564778

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	1118.893	234.289
SumBase	1116.541	234.782	1.002106
SumTraits	80.755	3246.151	13.855341
Sum128Base_Basic	2405.218	108.990	0.465194
Sum128Base	2400.722	109.194	0.466065
Sum128AdvSimd_Shuffle	303.321	864.245	3.688803
Sum128AdvSimd_Widen	154.215	1699.860	7.255405
Sum128AdvSimdB64	74.895	3500.172	14.939563
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	75.188	3486.531	14.881341
Sum256Base_Basic	2309.401	113.512	0.484495
Sum256Base	2329.767	112.519	0.480259
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2330.398	112.489	0.480129

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	1152.311	227.494
SumBase	1153.016	227.355	0.999388
SumTraits	160.942	1628.810	7.159790
Sum128Base_Basic	1917.889	136.684	0.600823
Sum128Base	1053.965	248.722	1.093311
Sum128AdvSimd_AlignRight	176.207	1487.703	6.539525
Sum128AdvSimd_Shuffle	613.792	427.089	1.877365
Sum128AdvSimdB64	150.431	1742.618	7.660059
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	149.345	1755.295	7.715782
Sum256Base_Basic	2936.464	89.272	0.392415
Sum256Base	2885.148	90.860	0.399394
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2887.072	90.799	0.399128

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	627.971	417.446
SumBase_Narrow	28.731	9124.239	21.857287
SumBase_NarrowMul	134.303	1951.887	4.675783
SumBase	28.650	9149.776	21.918461
SumTraits	16.994	15426.049	36.953392
Sum128Base_Basic	625.044	419.401	1.004682
Sum128Base	29.083	9013.528	21.592076
Sum128AdvSimd_Narrow	29.144	8994.923	21.547509
Sum128AdvSimd_Shuffle	30.245	8667.225	20.762503
Sum128AdvSimdB64	16.984	15435.179	36.975263
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	16.960	15456.177	37.025564
Sum256Base_Basic	1296.307	202.224	0.484431
Sum256Base	1295.602	202.334	0.484694
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1294.915	202.441	0.484951

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	2564.630	102.215
SumBase	2585.048	101.408	0.992102
SumTraits	1987.383	131.904	1.290456
SumTraits_Int128	371.029	706.533	6.912212
Sum128Base_Basic	340.858	769.070	7.524033
Sum128Base	337.481	776.767	7.599331
Sum128Traits	335.223	781.998	7.650511
Sum128Traits_Int128	105.910	2475.148	24.215084
Sum256Base_Basic	2924.214	89.646	0.877032
Sum256Base_Move2	2967.774	88.330	0.864160
Sum256Base	1791.506	146.326	1.431550
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1741.157	150.557	1.472946
Sum256Traits_Int128	1741.307	150.544	1.472819

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	925.723	283.178
SumBase_Narrow	53.366	4912.155	17.346545
SumBase_NarrowMul	144.951	1808.506	6.386470
SumBase_NarrowMulOld	316.755	827.592	2.922519
SumBase	53.373	4911.557	17.344435
SumTraits	33.146	7908.844	27.928910
Sum128Base_Basic	926.541	282.928	0.999117
Sum128Base	53.466	4903.024	17.314301
Sum128AdvSimd_Narrow	53.308	4917.511	17.365461
Sum128AdvSimd_Shuffle	53.976	4856.715	17.150769
Sum128AdvSimdB64	33.129	7912.926	27.943324
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	33.207	7894.178	27.877119
Sum256Base_Basic	1810.395	144.799	0.511337
Sum256Base	1845.480	142.047	0.501616
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1842.648	142.265	0.502387

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	1352.441	193.830
SumBase_Narrow	107.000	2449.943	12.639634
SumBase_NarrowMul	314.045	834.735	4.306526
SumBase	106.933	2451.481	12.647569
SumTraits	66.600	3936.106	20.306978
Sum128Base_Basic	1345.101	194.888	1.005457
Sum128Base	106.900	2452.245	12.651510
Sum128AdvSimd_Narrow	107.020	2449.484	12.637267
Sum128AdvSimd_Shuffle	110.038	2382.296	12.290631
Sum128AdvSimdB64	66.643	3933.544	20.293760
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	66.616	3935.176	20.302182
Sum256Base_Basic	2429.160	107.915	0.556753
Sum256Base	2432.331	107.775	0.556027
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2431.002	107.834	0.556331

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	2129.538	123.099
SumBase	2135.455	122.758	0.997229
SumTraits	133.260	1967.163	15.980331
Sum128Base_Basic	2110.151	124.230	1.009188
Sum128Base	187.287	1399.690	11.370441
Sum128AdvSimd_AlignRight	159.999	1638.410	13.309690
Sum128AdvSimd_Shuffle	220.562	1188.528	9.655058
Sum128AdvSimdB64	133.064	1970.058	16.003853
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	133.233	1967.563	15.983583
Sum256Base_Basic	3350.434	78.242	0.635601
Sum256Base	3338.978	78.510	0.637781
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3343.757	78.398	0.636870

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	493.881	530.784
SumBase_Widen	41.867	6261.387	11.796494
SumBase_WidenMul	43.912	5969.741	11.247030
SumBase	41.881	6259.288	11.792539
SumTraits	17.043	15381.737	28.979292
Sum128Base_Basic	493.510	531.183	1.000752
Sum128Base	142.833	1835.321	3.457757
Sum128AdvSimd_Shuffle	79.587	3293.795	6.205531
Sum128AdvSimd_Widen	40.218	6518.091	12.280126
Sum128AdvSimdB64	16.992	15427.259	29.065054
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	16.990	15429.306	29.068911
Sum256Base_Basic	1247.684	210.104	0.395838
Sum256Base	1238.523	211.659	0.398766
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1239.216	211.540	0.398543

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	1243.385	210.831
SumBase	1251.038	209.541	0.993882
SumTraits	2010.885	130.363	0.618327
SumTraits_Int128	530.668	493.989	2.343055
Sum128Base_Basic	345.725	758.244	3.596454
Sum128Base	338.064	775.426	3.677952
Sum128Traits	328.916	796.993	3.780248
Sum128Traits_Int128	106.413	2463.460	11.684524
Sum256Base_Basic	2149.215	121.972	0.578530
Sum256Base_Move2	2977.975	88.028	0.417527
Sum256Base	1781.259	147.168	0.698037
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1739.266	150.721	0.714890
Sum256Traits_Int128	1745.312	150.199	0.712414

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	666.893	393.083
SumBase_Widen	73.102	3586.023	9.122826
SumBase_WidenMul	86.362	3035.410	7.722068
SumBase	73.122	3585.032	9.120303
SumTraits	33.153	7907.114	20.115659
Sum128Base_Basic	666.778	393.150	1.000172
Sum128Base	277.334	945.230	2.404661
Sum128AdvSimd_Shuffle	158.103	1658.058	4.218092
Sum128AdvSimd_Widen	78.734	3329.484	8.470192
Sum128AdvSimdB64	33.110	7917.256	20.141460
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	33.197	7896.674	20.089101
Sum256Base_Basic	1592.944	164.566	0.418654
Sum256Base	1596.901	164.158	0.417617
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1595.089	164.344	0.418092

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	1018.382	257.412
SumBase_Widen	152.084	1723.674	6.696161
SumBase	151.477	1730.584	6.723007
SumTraits	66.670	3931.981	15.275036
Sum128Base_Basic	1030.852	254.298	0.987903
Sum128Base	556.501	471.057	1.829972
Sum128AdvSimd_Shuffle	316.581	828.047	3.216813
Sum128AdvSimd_Widen	151.249	1733.200	6.733167
Sum128AdvSimdB64	67.578	3879.146	15.069778
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	67.940	3858.478	14.989490
Sum256Base_Basic	1940.308	135.104	0.524856
Sum256Base	1935.200	135.461	0.526241
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1936.523	135.368	0.525882

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	1050.829	249.464
SumBase	1164.801	225.055	0.902154
SumTraits	133.318	1966.311	7.882145
Sum128Base_Basic	1151.338	227.686	0.912703
Sum128Base	187.583	1397.479	5.601928
Sum128AdvSimd_AlignRight	159.939	1639.030	6.570208
Sum128AdvSimd_Shuffle	633.446	413.838	1.658908
Sum128AdvSimdB64	133.033	1970.512	7.898986
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	133.094	1969.621	7.895412
Sum256Base_Basic	2413.236	108.628	0.435444
Sum256Base	2424.320	108.131	0.433453
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2417.548	108.434	0.434667

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	512.401	511.599
SumBase_Narrow	23.921	10958.598	21.420279
SumBase_NarrowMul	103.206	2540.004	4.964832
SumBase	23.833	10999.133	21.499512
SumTraits	16.599	15792.797	30.869471
Sum128Base_Basic	511.905	512.095	1.000969
Sum128Base	23.820	11005.041	21.511059
Sum128AdvSimd_Narrow	23.909	10964.085	21.431004
Sum128AdvSimd_Shuffle	27.326	9593.057	18.751118
Sum128AdvSimd_ShuffleX	46.691	5614.445	10.974303
Sum128AdvSimdB64	16.603	15788.919	30.861890
Sum128PackedSimd_Narrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleNarrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	16.598	15794.165	30.872145
Sum256Base_Basic	469.207	558.695	1.092057
Sum256Base	468.706	559.293	1.093225
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	468.704	559.295	1.093229
Sum512Base_Basic	440.816	594.679	1.162392
Sum512Base	440.941	594.510	1.162062
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	440.810	594.687	1.162407

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	1174.482	223.200
SumBase	1198.795	218.673	0.979719
SumTraits	1182.313	221.721	0.993377
SumTraits_Int128	106.510	2461.223	11.027004
Sum128Base_Basic	367.705	712.920	3.194091
Sum128Base	370.077	708.350	3.173617
Sum128Traits	370.057	708.388	3.173786
Sum128Traits_Int128	106.432	2463.030	11.035099
Sum256Base_Basic	819.535	319.869	1.433108
Sum256Base_Move2	71.929	3644.502	16.328440
Sum256Base	71.657	3658.334	16.390412
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	71.632	3659.600	16.396084
Sum256Traits_Int128	71.794	3651.340	16.359075
Sum512Base_Basic	690.550	379.616	1.700791
Sum512Base	70.292	3729.378	16.708709
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	70.261	3731.021	16.716071
Sum512Traits_Int128	71.381	3672.483	16.453804

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	725.986	361.087
SumBase_Narrow	56.713	4622.297	12.801075
SumBase_NarrowMul	131.265	1997.059	5.530691
SumBase_NarrowMulOld	264.718	990.278	2.742493
SumBase	56.246	4660.692	12.907406
SumTraits	33.876	7738.322	21.430650
Sum128Base_Basic	723.715	362.220	1.003139
Sum128Base	56.563	4634.583	12.835100
Sum128AdvSimd_Narrow	55.880	4691.210	12.991923
Sum128AdvSimd_Shuffle	58.641	4470.337	12.380234
Sum128AdvSimd_ShuffleX	99.931	2623.243	7.264857
Sum128AdvSimdB64	33.954	7720.611	21.381603
Sum128PackedSimd_Narrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleNarrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	33.961	7719.003	21.377149
Sum256Base_Basic	614.517	426.586	1.181394
Sum256Base	615.867	425.650	1.178804
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	625.397	419.164	1.160841
Sum512Base_Basic	671.460	390.409	1.081206
Sum512Base	664.392	394.562	1.092708
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	657.257	398.845	1.104569

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
# Sum512Base_Basic	-467853350
SumBase_Basic	1159.246	226.133
SumBase_Narrow	111.967	2341.259	10.353450
SumBase_NarrowMul	260.720	1005.461	4.446323
SumBase	112.223	2335.918	10.329830
SumTraits	68.406	3832.155	16.946447
Sum128Base_Basic	1125.966	232.817	1.029557
Sum128Base	112.585	2328.414	10.296645
Sum128AdvSimd_Narrow	112.125	2337.967	10.338892
Sum128AdvSimd_Shuffle	120.492	2175.620	9.620963
Sum128AdvSimd_ShuffleX	198.593	1320.009	5.837306
Sum128AdvSimdB64	68.531	3825.216	16.915763
Sum128PackedSimd_Narrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleNarrow	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	68.533	3825.070	16.915117
Sum256Base_Basic	735.722	356.309	1.575658
Sum256Base	735.982	356.183	1.575100
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	735.861	356.241	1.575360
Sum512Base_Basic	657.694	398.580	1.762590
Sum512Base	656.381	399.378	1.766118
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	655.840	399.707	1.767573

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	1206.543	217.269
SumBase	1207.615	217.076	0.999112
SumTraits	128.544	2039.335	9.386237
Sum128Base_Basic	1199.679	218.512	1.005722
Sum128Base	201.333	1302.042	5.992775
Sum128AdvSimd_AlignRight	159.250	1646.121	7.576430
Sum128AdvSimd_Shuffle	241.954	1083.446	4.986663
Sum128AdvSimd_ShuffleX	394.521	664.462	3.058250
Sum128AdvSimdB64	128.592	2038.573	9.382730
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_TupleShuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	128.594	2038.541	9.382581
Sum256Base_Basic	817.126	320.812	1.476568
Sum256Base	806.824	324.909	1.495423
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	819.322	319.952	1.472611
Sum512Base_Basic	853.876	307.005	1.413018
Sum512Base	855.448	306.441	1.410422
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	853.781	307.039	1.413176

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	595.347	440.321
SumBase_Widen	36.490	7183.963	16.315271
SumBase_WidenMul	39.747	6595.281	14.978335
SumBase	36.530	7176.134	16.297492
SumTraits	16.597	15794.681	35.870799
Sum128Base_Basic	592.382	442.525	1.005005
Sum128Base	39.546	6628.918	15.054726
Sum128AdvSimd_Shuffle	78.981	3319.072	7.537839
Sum128AdvSimd_ShuffleX	52.680	4976.204	11.301299
Sum128AdvSimd_Widen	39.574	6624.209	15.044031
Sum128AdvSimdB64	16.603	15789.340	35.858671
Sum128PackedSimd_Widen	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	16.597	15795.076	35.871697
Sum256Base_Basic	529.777	494.819	1.123769
Sum256Base	543.496	482.329	1.095402
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	532.852	491.964	1.117284
Sum512Base_Basic	547.878	478.471	1.086641
Sum512Base	547.585	478.727	1.087223
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	548.425	477.994	1.085558

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	1158.253	226.327
SumBase	1174.478	223.200	0.986185
SumTraits	1181.341	221.904	0.980457
SumTraits_Int128	106.595	2459.241	10.865878
Sum128Base_Basic	370.336	707.855	3.127575
Sum128Base	370.452	707.634	3.126599
Sum128Traits	367.647	713.031	3.150447
Sum128Traits_Int128	106.644	2458.112	10.860888
Sum256Base_Basic	1095.844	239.216	1.056951
Sum256Base_Move2	71.718	3655.190	16.150042
Sum256Base	71.845	3648.767	16.121662
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	71.957	3643.074	16.096508
Sum256Traits_Int128	71.957	3643.086	16.096559
Sum512Base_Basic	797.811	328.579	1.451789
Sum512Base	70.288	3729.549	16.478589
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Imm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	72.767	3602.522	15.917331
Sum512Traits_Int128	73.703	3556.751	15.715098

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	712.346	368.001
SumBase_Widen	84.613	3098.139	8.418829
SumBase_WidenMul	81.302	3224.324	8.761723
SumBase	84.645	3096.970	8.415652
SumTraits	33.870	7739.642	21.031572
Sum128Base_Basic	712.628	367.855	0.999604
Sum128Base	75.237	3484.235	9.468001
Sum128AdvSimd_Shuffle	158.790	1650.880	4.486074
Sum128AdvSimd_ShuffleX	107.094	2447.788	6.651576
Sum128AdvSimd_Widen	83.524	3138.530	8.528587
Sum128AdvSimdB64	33.977	7715.407	20.965715
Sum128PackedSimd_Widen	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	33.972	7716.376	20.968348
Sum256Base_Basic	621.346	421.897	1.146455
Sum256Base	620.913	422.191	1.147254
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	621.111	422.057	1.146890
Sum512Base_Basic	665.701	393.786	1.070068
Sum512Base	665.491	393.911	1.070406
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	669.267	391.688	1.064366

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
# Sum512Base_Basic	-467853350
SumBase_Basic	1031.479	254.144
SumBase_Widen	160.392	1634.399	6.430999
SumBase	164.515	1593.436	6.269818
SumTraits	68.631	3819.619	15.029357
Sum128Base_Basic	1031.100	254.237	1.000367
Sum128Base	166.630	1573.206	6.190218
Sum128AdvSimd_Shuffle	317.912	824.580	3.244538
Sum128AdvSimd_ShuffleX	214.118	1224.295	4.817329
Sum128AdvSimd_Widen	167.825	1562.006	6.146147
Sum128AdvSimdB64	68.679	3816.963	15.018904
Sum128PackedSimd_Widen	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	68.778	3811.471	14.997295
Sum256Base_Basic	741.290	353.632	1.391465
Sum256Base	745.144	351.803	1.384268
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	741.084	353.730	1.391850
Sum512Base_Basic	827.102	316.943	1.247100
Sum512Base	827.653	316.732	1.246269
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	832.754	314.792	1.238635

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	1119.438	234.175
SumBase	1076.421	243.533	1.039963
SumTraits	128.870	2034.175	8.686574
Sum128Base_Basic	1062.398	246.748	1.053690
Sum128Base	201.097	1303.570	5.566659
Sum128AdvSimd_AlignRight	159.750	1640.959	7.007418
Sum128AdvSimd_Shuffle	635.846	412.276	1.760549
Sum128AdvSimd_ShuffleX	428.031	612.441	2.615318
Sum128AdvSimdB64	128.650	2037.653	8.701427
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	128.739	2036.250	8.695436
Sum256Base_Basic	822.456	318.733	1.361092
Sum256Base	822.752	318.619	1.360603
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	822.514	318.711	1.360996
Sum512Base_Basic	1118.633	234.343	1.000720
Sum512Base	1118.674	234.335	1.000683
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1119.307	234.202	1.000117

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


[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	16791.667	15.612
SumBase_Narrow	19531.250	13.422	0.859733
SumBase_NarrowMul	81316.667	3.224	0.206497
SumBase	17339.583	15.118	0.968401
SumTraits	2657.292	98.651	6.319091
Sum128Base_Basic	16716.667	15.682	1.004487
Sum128Base	1586.589	165.225	10.583504
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Narrow	1654.036	158.487	10.151933
Sum128PackedSimd_Shuffle	2073.177	126.446	8.099485
Sum128PackedSimd_TupleNarrow	3336.458	78.570	5.032782
Sum128PackedSimd_TupleShuffle	3598.958	72.839	4.665702
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2183.073	120.080	7.691757
Sum256Base_Basic	17214.583	15.228	0.975433
Sum256Base	18862.500	13.898	0.890214
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	18241.667	14.371	0.920512
Sum512Base_Basic	18187.500	14.413	0.923253
Sum512Base	17075.000	15.353	0.983407
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	18235.417	14.376	0.920827

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	91091.667	2.878
SumBase	95325.000	2.750	0.955591
SumTraits	66483.333	3.943	1.370143
SumTraits_Int128	48037.500	5.457	1.896262
Sum128Base_Basic	106016.667	2.473	0.859220
Sum128Base	106516.667	2.461	0.855187
Sum128Traits	6399.479	40.963	14.234231
Sum128Traits_Int128	6358.333	41.228	14.326343
Sum256Base_Basic	158366.667	1.655	0.575195
Sum256Base_Move2	143366.667	1.828	0.635375
Sum256Base	133750.000	1.960	0.681059
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	58179.167	4.506	1.565709
Sum256Traits_Int128	49325.000	5.315	1.846765
Sum512Base_Basic	154550.000	1.696	0.589399
Sum512Base	167116.666	1.569	0.545078
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	76083.333	3.445	1.197262
Sum512Traits_Int128	71508.333	3.666	1.273861

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	25497.917	10.281
SumBase_Narrow	27979.167	9.369	0.911318
SumBase_NarrowMul	63141.667	4.152	0.403821
SumBase_NarrowMulOld	187283.333	1.400	0.136146
SumBase	26485.417	9.898	0.962715
SumTraits	5128.125	51.119	4.972171
Sum128Base_Basic	26025.000	10.073	0.979747
Sum128Base	42462.500	6.174	0.600481
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Narrow	41433.333	6.327	0.615396
Sum128PackedSimd_Shuffle	4292.708	61.067	5.939820
Sum128PackedSimd_TupleNarrow	47362.500	5.535	0.538357
Sum128PackedSimd_TupleShuffle	10657.292	24.598	2.392532
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	4400.000	59.578	5.794981
Sum256Base_Basic	26568.750	9.867	0.959696
Sum256Base	27241.667	9.623	0.935990
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	30120.833	8.703	0.846521
Sum512Base_Basic	26922.917	9.737	0.947071
Sum512Base	26070.833	10.055	0.978025
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	28570.833	9.175	0.892446

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
# Sum512Base_Basic	-467853350
SumBase_Basic	35987.500	7.284
SumBase_Narrow	36162.500	7.249	0.995161
SumBase_NarrowMul	158383.334	1.655	0.227218
SumBase	36708.333	7.141	0.980363
SumTraits	10560.417	24.823	3.407773
Sum128Base_Basic	37662.500	6.960	0.955526
Sum128Base	66733.333	3.928	0.539273
Sum128AdvSimd_Narrow	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Narrow	67016.667	3.912	0.536993
Sum128PackedSimd_Shuffle	8278.125	31.667	4.347301
Sum128PackedSimd_TupleNarrow	73141.667	3.584	0.492025
Sum128PackedSimd_TupleShuffle	20987.500	12.490	1.714711
Sum128Sse_Narrow	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	8505.208	30.822	4.231231
Sum256Base_Basic	38520.833	6.805	0.934235
Sum256Base	39708.333	6.602	0.906296
Sum256Avx2_Narrow	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	44908.333	5.837	0.801355
Sum512Base_Basic	40491.667	6.474	0.888763
Sum512Base	37825.000	6.930	0.951421
Sum512Avx512_Narrow	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	40187.500	6.523	0.895490

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	95308.333	2.750
SumBase	94691.667	2.768	1.006512
SumTraits	60741.667	4.316	1.569077
Sum128Base_Basic	157283.334	1.667	0.605966
Sum128Base	128116.667	2.046	0.743918
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	17317.708	15.137	5.503519
Sum128PackedSimd_TupleShuffle	41641.667	6.295	2.288773
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	16625.000	15.768	5.732832
Sum256Base_Basic	160200.000	1.636	0.594933
Sum256Base	162633.334	1.612	0.586032
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	82516.667	3.177	1.155019
Sum512Base_Basic	162000.000	1.618	0.588323
Sum512Base	157316.667	1.666	0.605837
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	70566.667	3.715	1.350614

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	17658.333	14.845
SumBase_Widen	26414.583	9.924	0.668507
SumBase_WidenMul	31250.000	8.389	0.565067
SumBase	17339.583	15.118	1.018383
SumTraits	2633.333	99.548	6.705696
Sum128Base_Basic	18718.750	14.004	0.943350
Sum128Base	5370.833	48.809	3.287820
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Widen	2144.271	122.253	8.235123
Sum128PackedSimd_Shuffle	2199.740	119.170	8.027465
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2205.990	118.833	8.004722
Sum256Base_Basic	18260.417	14.356	0.967028
Sum256Base	18685.417	14.029	0.945033
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	19350.000	13.547	0.912575
Sum512Base_Basic	17787.500	14.738	0.992738
Sum512Base	18877.083	13.887	0.935438
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	18456.250	14.204	0.956767

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	98116.667	2.672
SumBase	96250.000	2.724	1.019394
SumTraits	68125.000	3.848	1.440245
SumTraits_Int128	50729.167	5.168	1.934127
Sum128Base_Basic	101475.000	2.583	0.966905
Sum128Base	107358.333	2.442	0.913918
Sum128Traits	6156.771	42.578	15.936384
Sum128Traits_Int128	6557.292	39.977	14.962986
Sum256Base_Basic	156883.333	1.671	0.625412
Sum256Base_Move2	141483.333	1.853	0.693486
Sum256Base	142600.000	1.838	0.688055
Sum256Avx2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	59879.167	4.378	1.638578
Sum256Traits_Int128	49470.833	5.299	1.983324
Sum512Base_Basic	161016.667	1.628	0.609357
Sum512Base	156783.333	1.672	0.625811
Sum512Avx512	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Imm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	75641.667	3.466	1.297125
Sum512Traits_Int128	73233.333	3.580	1.339782

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	24918.750	10.520
SumBase_Widen	41745.833	6.280	0.596916
SumBase_WidenMul	45441.667	5.769	0.548368
SumBase	25166.667	10.416	0.990149
SumTraits	5245.833	49.972	4.750199
Sum128Base_Basic	25160.417	10.419	0.990395
Sum128Base	49625.000	5.282	0.502141
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Widen	4441.667	59.019	5.610225
Sum128PackedSimd_Shuffle	4310.938	60.809	5.780355
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	4520.833	57.986	5.511982
Sum256Base_Basic	24416.667	10.736	1.020563
Sum256Base	25468.750	10.293	0.978405
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	27816.667	9.424	0.895821
Sum512Base_Basic	25035.417	10.471	0.995340
Sum512Base	25085.417	10.450	0.993356
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	26920.833	9.738	0.925631

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
# Sum512Base_Basic	-467853350
SumBase_Basic	35920.833	7.298
SumBase_Widen	37191.667	7.048	0.965830
SumBase	36495.833	7.183	0.984245
SumTraits	10694.792	24.511	3.358722
Sum128Base_Basic	36579.167	7.166	0.982003
Sum128Base	90100.000	2.909	0.398677
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Widen	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Widen	8676.042	30.215	4.140233
Sum128PackedSimd_Shuffle	8680.208	30.200	4.138246
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Widen	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	8313.542	31.532	4.320762
Sum256Base_Basic	37525.000	6.986	0.957251
Sum256Base	36979.167	7.089	0.971380
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Widen	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	44762.500	5.856	0.802476
Sum512Base_Basic	38833.333	6.750	0.925000
Sum512Base	38320.833	6.841	0.937371
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Widen	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	40004.167	6.553	0.897927

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	103350.000	2.536
SumBase	102791.667	2.550	1.005432
SumTraits	61308.333	4.276	1.685741
Sum128Base_Basic	163666.666	1.602	0.631466
Sum128Base	122900.000	2.133	0.840928
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	17283.333	15.167	5.979749
Sum128Sse_Permute	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	17654.167	14.849	5.854142
Sum256Base_Basic	157766.667	1.662	0.655081
Sum256Base	159016.666	1.649	0.649932
Sum256Avx2_Permute	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	89450.000	2.931	1.155394
Sum512Base_Basic	160516.666	1.633	0.643858
Sum512Base	166216.667	1.577	0.621779
Sum512Avx512_Permute	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	72208.333	3.630	1.431275

```

