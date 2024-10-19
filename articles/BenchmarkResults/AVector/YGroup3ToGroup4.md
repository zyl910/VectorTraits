# Benchmark - YGroup3ToGroup4
([← Back](README.md))

See [Group](YGroup3ToGroup4_Group.md)

- `YGroup3ToGroup4`: Convert a 3-element group, to a 4-element group. It also converts packed RGB pixel data to packed RGBA pixel data (将3-元素组, 转为4-元素组. 它还能将 已打包的RGB像素数据, 转换为 已打包的RGBA像素数据).
  Mnemonic: View for group: `(result0, result1, result2, result3) = YGroup4Zip(YGroup3Unzip(data0, data1, data2), Vector.Zero))`. View for element: `element_ref(i, result0, result1, result2, result3) := (3!=(i%4))?element_ref((i/4)*3+(i%4), data0, data1, data2):0`.
- `YGroup4ToGroup3`: Convert a 4-element group, to a 3-element group. It also converts packed RGBA pixel data to packed RGB pixel data (将4-元素组, 转为3-元素组. 它还能将 已打包的RGBA像素数据, 转换为 已打包的RGB像素数据).
  Mnemonic: View for group: `(result0, result1, result2) = YGroup3Zip(YGroup4Unzip(data0, data1, data2, data3)))`. View for element: `element_ref(i, result0, result1, result2) := element_ref((i/3)*4+(i%3), data0, data1, data2, data3)`.

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	2094.409	125.164
SumBase_Unzip	288.404	908.947	7.262066
SumBase	291.937	897.949	7.174192
SumTraits	286.186	915.993	7.318355

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	2370.434	110.589
SumBase_Unzip	477.000	549.569	4.969467
SumBase	2368.770	110.667	1.000703
SumTraits	2406.335	108.939	0.985081

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
SumBase_Basic	3055.041	85.807
SumBase_Unzip	3384.873	77.446	0.902557
SumBase	2947.579	88.935	1.036457
SumTraits	2950.032	88.861	1.035596

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
SumBase_Basic	4291.844	61.080
SumBase	4202.818	62.373	1.021183
SumTraits	4076.092	64.313	1.052931

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
SumBase_Basic	1895.049	138.331
SumBase_Unzip	968.026	270.803	1.957643
SumBase	970.632	270.076	1.952387
SumTraits	897.806	291.983	2.110755

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
SumBase_Basic	2387.547	109.796
SumBase_Unzip	1076.768	243.454	2.217327
SumBase	2268.005	115.584	1.052708
SumTraits	2219.549	118.107	1.075690

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809936964
SumBase_Basic	2857.380	91.743
SumBase_Unzip	3047.589	86.017	0.937587
SumBase	2878.131	91.081	0.992790
SumTraits	2752.264	95.247	1.038193

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-5443202675530370315
SumBase_Basic	3919.710	66.878
SumBase	4023.412	65.155	0.974225
SumTraits	3981.552	65.840	0.984468

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	717.417	365.400
SumBase_Unzip	303.828	862.805	2.361263
SumBase	301.167	870.428	2.382126
SumTraits	307.193	853.352	2.335395

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	895.419	292.761
SumBase_Unzip	608.717	430.650	1.470993
SumBase	877.518	298.733	1.020399
SumTraits	925.016	283.394	0.968004

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
SumBase_Basic	1392.048	188.315
SumBase_Unzip	2100.895	124.777	0.662597
SumBase	1380.786	189.851	1.008156
SumTraits	1358.495	192.967	1.024698

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
SumBase_Basic	2459.057	106.603
SumBase	2528.128	103.691	0.972679
SumTraits	2397.692	109.332	1.025594

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
SumBase_Basic	656.747	399.155
SumBase_Unzip	618.623	423.754	1.061626
SumBase	569.948	459.943	1.152291
SumTraits	601.802	435.598	1.091300

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
SumBase_Basic	837.880	312.866
SumBase_Unzip	783.406	334.621	1.069535
SumBase	796.179	329.252	1.052376
SumTraits	838.218	312.740	0.999597

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809936964
SumBase_Basic	1380.610	189.875
SumBase_Unzip	2085.493	125.699	0.662006
SumBase	1355.276	193.425	1.018693
SumTraits	1385.589	189.193	0.996407

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-5443202675530370315
SumBase_Basic	2501.316	104.802
SumBase	2501.328	104.802	0.999995
SumTraits	2484.722	105.502	1.006679

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	678.312	386.465
SumBase_Unzip	294.649	889.683	2.302103
SumBase	289.622	905.125	2.342062
SumTraits	32.816	7988.200	20.669910
Sum128Base_Basic	1417.533	184.930	0.478516
Sum128Base	1425.781	183.860	0.475748
Sum128Sse_Shuffle	46.629	5621.952	14.547114
Sum128Traits	46.311	5660.564	14.647024
Sum256Base_Basic	1179.807	222.192	0.574935
Sum256Base	1180.575	222.048	0.574561
Sum256Avx2_Shuffle	26.754	9798.345	25.353762
Sum256Traits	27.645	9482.387	24.536204

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	842.443	311.171
SumBase_Unzip	474.759	552.163	1.774466
SumBase	839.617	312.219	1.003366
SumTraits	62.106	4220.894	13.564545
Sum128Base_Basic	2304.826	113.737	0.365513
Sum128Base	2294.932	114.227	0.367089
Sum128Sse_Shuffle	91.363	2869.271	9.220879
Sum128Traits	87.613	2992.079	9.615543
Sum256Base_Basic	1615.519	162.266	0.521469
Sum256Base	1632.379	160.590	0.516083
Sum256Avx2_Shuffle	50.927	5147.465	16.542235
Sum256Traits	50.501	5190.890	16.681787

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-466706470
# Sum256Base_Basic	-467755046
SumBase_Basic	1143.795	229.188
SumBase_Unzip	1775.207	147.670	0.644317
SumBase	1166.317	224.762	0.980690
SumTraits	66.058	3968.382	17.314973
Sum128Base_Basic	3542.704	73.995	0.322859
Sum128Base	3597.390	72.871	0.317951
Sum128Sse_Shuffle	155.402	1686.876	7.360231
Sum128Sse_ShuffleXImm	88.669	2956.419	12.899545
Sum128Traits	87.562	2993.824	13.062750
Sum256Base_Basic	2597.101	100.937	0.440412
Sum256Base	2320.188	112.984	0.492975
Sum256Avx2_Shuffle	106.351	2464.903	10.754947
Sum256Avx2_ShuffleXImm	63.409	4134.183	18.038405
Sum256Traits	63.010	4160.323	18.152459

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572532740
# Sum256Base_Basic	5910372263572008452
SumBase_Basic	1917.178	136.734
SumBase	2069.609	126.664	0.926348
SumTraits	100.098	2618.861	19.152921
Sum128Base_Basic	6955.470	37.689	0.275636
Sum128Base	6535.405	40.111	0.293353
Sum128Sse_Shuffle	228.553	1146.972	8.388330
Sum128Sse_ShuffleXImm	114.873	2282.041	16.689606
Sum128Traits	112.762	2324.759	17.002019
Sum256Base_Basic	4510.088	58.124	0.425087
Sum256Base	4104.518	63.867	0.467090
Sum256Avx2_Shuffle	134.162	1953.935	14.290017
Sum256Avx2_ShuffleXImm	97.389	2691.732	19.685858
Sum256Traits	96.084	2728.279	19.953143

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
SumBase_Basic	653.537	401.116
SumBase_Unzip	575.126	455.803	1.136337
SumBase	584.754	448.298	1.117627
SumTraits	27.575	9506.626	23.700440
Sum128Base_Basic	1129.294	232.131	0.578713
Sum128Base	1122.521	233.531	0.582204
Sum128Sse_Shuffle	39.606	6618.775	16.500899
Sum128Traits	41.544	6310.045	15.731221
Sum256Base_Basic	1047.745	250.198	0.623755
Sum256Base	1050.224	249.608	0.622283
Sum256Avx2_Shuffle	23.104	11346.313	28.286861
Sum256Traits	22.039	11894.609	29.653787

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
SumBase_Basic	750.384	349.346
SumBase_Unzip	690.455	379.668	1.086797
SumBase	785.235	333.841	0.955617
SumTraits	58.620	4471.914	12.800803
Sum128Base_Basic	2079.432	126.065	0.360860
Sum128Base	1968.585	133.164	0.381180
Sum128Sse_Shuffle	80.815	3243.773	9.285264
Sum128Traits	77.307	3390.933	9.706507
Sum256Base_Basic	1379.462	190.034	0.543969
Sum256Base	1364.415	192.129	0.549968
Sum256Avx2_Shuffle	47.415	5528.709	15.825867
Sum256Traits	47.856	5477.736	15.679958

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809936964
# Sum128Base_Basic	1810330180
# Sum256Base_Basic	1809936964
SumBase_Basic	1158.589	226.261
SumBase_Unzip	1836.458	142.744	0.630882
SumBase	1126.034	232.803	1.028911
SumTraits	57.041	4595.679	20.311362
Sum128Base_Basic	3145.712	83.334	0.368307
Sum128Base	3211.045	81.638	0.360814
Sum128Sse_Shuffle	168.459	1556.126	6.877556
Sum128Sse_ShuffleXImm	55.151	4753.224	21.007658
Sum128Traits	54.214	4835.375	21.370736
Sum256Base_Basic	2225.922	117.769	0.520498
Sum256Base	2073.755	126.410	0.558691
Sum256Avx2_Shuffle	88.883	2949.299	13.034915
Sum256Avx2_ShuffleXImm	55.236	4745.917	20.975365
Sum256Traits	55.693	4706.962	20.803194

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-5443202675530370315
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	-5443202675530370315
SumBase_Basic	1981.641	132.286
SumBase	2047.712	128.018	0.967734
SumTraits	92.109	2846.015	21.514046
Sum128Base_Basic	6098.596	42.984	0.324934
Sum128Base_Move	4919.783	53.284	0.402790
Sum128Base	4939.949	53.066	0.401146
Sum128Sse_Shuffle	233.037	1124.904	8.503551
Sum128Sse_ShuffleXImm	71.863	3647.826	27.575226
Sum128Traits	74.290	3528.674	26.674516
Sum256Base_Basic	4103.043	63.890	0.482968
Sum256Base	3621.676	72.382	0.547161
Sum256Avx2_Shuffle	147.005	1783.227	13.480051
Sum256Avx2_ShuffleXImm	89.288	2935.932	22.193761
Sum256Traits	90.239	2904.987	21.959839

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	676.936	387.251
SumBase_Unzip	291.668	898.776	2.320915
SumBase	291.411	899.567	2.322958
SumTraits	22.393	11706.262	30.229146
Sum128Base_Basic	1379.269	190.060	0.490793
Sum128Base	1413.341	185.478	0.478962
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	33.070	7926.908	20.469699
Sum128Traits	31.527	8314.980	21.471820
Sum256Base_Basic	1342.420	195.277	0.504265
Sum256Base	1292.663	202.794	0.523675
Sum256Avx2_Shuffle	21.933	11951.826	30.863269
Sum256Traits	22.013	11908.600	30.751646

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1030.712	254.333
SumBase_Unzip	474.812	552.101	2.170781
SumBase	1132.122	231.551	0.910425
SumTraits	43.112	6080.553	23.907858
Sum128Base_Basic	2381.816	110.061	0.432742
Sum128Base	2288.330	114.557	0.450421
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	64.487	4065.093	15.983358
Sum128Traits	64.431	4068.603	15.997161
Sum256Base_Basic	1813.917	144.518	0.568225
Sum256Base	1831.623	143.121	0.562732
Sum256Avx2_Shuffle	44.325	5914.088	23.253341
Sum256Traits	43.692	5999.823	23.590438

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-466706470
# Sum256Base_Basic	-467755046
SumBase_Basic	1584.102	165.484
SumBase_Unzip	1898.250	138.098	0.834506
SumBase	1893.442	138.448	0.836626
SumTraits	62.935	4165.345	25.170636
Sum128Base_Basic	3698.540	70.878	0.428305
Sum128Base	3642.765	71.963	0.434863
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	132.937	1971.939	11.916168
Sum128Sse_ShuffleXImm	74.425	3522.250	21.284499
Sum128Traits	70.774	3703.946	22.382461
Sum256Base_Basic	2889.001	90.739	0.548322
Sum256Base	3058.327	85.715	0.517964
Sum256Avx2_Shuffle	90.780	2887.687	17.449915
Sum256Avx2_ShuffleXImm	61.005	4297.116	25.966913
Sum256Traits	59.872	4378.437	26.458324

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572532740
# Sum256Base_Basic	5910372263572008452
SumBase_Basic	2852.790	91.890
SumBase	3428.018	76.471	0.832198
SumTraits	95.930	2732.671	29.738380
Sum128Base_Basic	6832.617	38.367	0.417525
Sum128Base	6558.771	39.968	0.434958
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	150.303	1744.101	18.980238
Sum128Sse_ShuffleXImm	97.454	2689.923	29.273169
Sum128Traits	96.896	2705.412	29.441731
Sum256Base_Basic	5103.043	51.370	0.559037
Sum256Base	5587.483	46.916	0.510568
Sum256Avx2_Shuffle	125.089	2095.666	22.806151
Sum256Avx2_ShuffleXImm	96.083	2728.306	29.690879
Sum256Traits	96.642	2712.529	29.519187

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
SumBase_Basic	673.313	389.335
SumBase_Unzip	697.768	375.689	0.964952
SumBase	705.789	371.420	0.953986
SumTraits	18.829	13922.197	35.758943
Sum128Base_Basic	1167.018	224.627	0.576951
Sum128Base	1136.354	230.689	0.592520
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	25.165	10417.150	26.756284
Sum128Traits	26.444	9913.021	25.461436
Sum256Base_Basic	1129.752	232.037	0.595983
Sum256Base	1184.388	221.333	0.568490
Sum256Avx2_Shuffle	18.936	13843.737	35.557419
Sum256Traits	19.585	13384.700	34.378389

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
SumBase_Basic	932.470	281.129
SumBase_Unzip	911.535	287.585	1.022966
SumBase	1032.699	253.844	0.902945
SumTraits	39.826	6582.240	23.413616
Sum128Base_Basic	1860.873	140.872	0.501093
Sum128Base	1913.615	136.989	0.487282
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	51.633	5077.047	18.059511
Sum128Traits	52.191	5022.753	17.866382
Sum256Base_Basic	1610.707	162.751	0.578919
Sum256Base	1580.124	165.901	0.590124
Sum256Avx2_Shuffle	39.968	6558.912	23.330635
Sum256Traits	39.488	6638.655	23.614290

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809936964
# Sum128Base_Basic	1810330180
# Sum256Base_Basic	1809936964
SumBase_Basic	1581.815	165.724
SumBase_Unzip	1835.143	142.847	0.861957
SumBase	1892.436	138.522	0.835862
SumTraits	55.920	4687.863	28.287242
Sum128Base_Basic	3079.638	85.122	0.513637
Sum128Base	3157.922	83.012	0.500904
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	107.647	2435.226	14.694509
Sum128Sse_ShuffleXImm	54.655	4796.366	28.941969
Sum128Traits	53.370	4911.851	29.638817
Sum256Base_Basic	2545.993	102.963	0.621296
Sum256Base	2754.366	95.174	0.574294
Sum256Avx2_Shuffle	79.063	3315.639	20.007043
Sum256Avx2_ShuffleXImm	56.790	4616.005	27.853640
Sum256Traits	56.012	4680.139	28.240636

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-5443202675530370315
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	-5443202675530370315
SumBase_Basic	2911.138	90.049
SumBase	3457.160	75.826	0.842060
SumTraits	87.716	2988.565	33.188342
Sum128Base_Basic	5926.148	44.235	0.491236
Sum128Base_Move	4903.494	53.461	0.593686
Sum128Base	4917.493	53.308	0.591996
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	150.246	1744.760	19.375750
Sum128Sse_ShuffleXImm	74.056	3539.793	39.309788
Sum128Traits	73.646	3559.500	39.528633
Sum256Base_Basic	4693.006	55.858	0.620314
Sum256Base	5214.159	50.275	0.558314
Sum256Avx2_Shuffle	123.504	2122.555	23.571209
Sum256Avx2_ShuffleXImm	89.432	2931.205	32.551352
Sum256Traits	90.807	2886.826	32.058523

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	629.631	416.345
SumBase_Unzip	297.246	881.910	2.118218
SumBase	295.278	887.787	2.132334
SumTraits	21.642	12112.922	29.093448
Sum128Base_Basic	1367.030	191.762	0.460583
Sum128Base	1400.198	187.219	0.449673
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	34.773	7538.700	18.106843
Sum128Traits	35.140	7460.086	17.918023
Sum256Base_Basic	1256.232	208.675	0.501206
Sum256Base	1193.428	219.656	0.527582
Sum256Avx2_Shuffle	21.376	12263.188	29.454363
Sum256Traits	21.668	12097.966	29.057524

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	789.438	332.064
SumBase_Unzip	474.238	552.768	1.664645
SumBase	800.438	327.501	0.986258
SumTraits	44.303	5917.073	17.819080
Sum128Base_Basic	2424.605	108.118	0.325595
Sum128Base	2471.985	106.046	0.319354
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	64.130	4087.712	12.310016
Sum128Traits	68.590	3821.887	11.509491
Sum256Base_Basic	1589.766	164.895	0.496575
Sum256Base	1567.122	167.277	0.503751
Sum256Avx2_Shuffle	45.149	5806.176	17.485116
Sum256Traits	44.057	5950.134	17.918641

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-466706470
# Sum256Base_Basic	-467755046
SumBase_Basic	1107.910	236.611
SumBase_Unzip	1771.423	147.985	0.625435
SumBase	1166.464	224.734	0.949801
SumTraits	60.855	4307.685	18.205739
Sum128Base_Basic	3849.443	68.099	0.287810
Sum128Base	3853.115	68.034	0.287536
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	130.752	2004.896	8.473372
Sum128Sse_ShuffleXImm	70.272	3730.410	15.765979
Sum128Traits	73.113	3585.478	15.153446
Sum256Base_Basic	2365.501	110.820	0.468361
Sum256Base	2266.360	115.667	0.488850
Sum256Avx2_Shuffle	88.706	2955.207	12.489708
Sum256Avx2_ShuffleXImm	62.997	4161.183	17.586572
Sum256Traits	62.334	4205.451	17.773665

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572532740
# Sum256Base_Basic	5910372263572008452
SumBase_Basic	1914.930	136.895
SumBase	1981.543	132.293	0.966383
SumTraits	94.796	2765.355	20.200577
Sum128Base_Basic	7279.651	36.011	0.263052
Sum128Base	5916.591	44.307	0.323654
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	154.485	1696.895	12.395609
Sum128Sse_ShuffleXImm	100.129	2618.050	19.124532
Sum128Traits	93.301	2809.648	20.524137
Sum256Base_Basic	3974.261	65.960	0.481833
Sum256Base	3966.524	66.089	0.482773
Sum256Avx2_Shuffle	129.597	2022.770	14.776089
Sum256Avx2_ShuffleXImm	96.572	2714.484	19.828975
Sum256Traits	95.119	2755.957	20.131926

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
SumBase_Basic	646.063	405.756
SumBase_Unzip	567.772	461.707	1.137893
SumBase	559.531	468.507	1.154653
SumTraits	18.978	13812.683	34.041863
Sum128Base_Basic	1149.883	227.974	0.561851
Sum128Base	1174.627	223.172	0.550016
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	25.759	10176.811	25.081122
Sum128Traits	26.383	9936.256	24.488267
Sum256Base_Basic	993.186	263.942	0.650496
Sum256Base	1021.067	256.735	0.632734
Sum256Avx2_Shuffle	19.619	13361.974	32.931073
Sum256Traits	19.541	13415.116	33.062043

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
SumBase_Basic	775.917	337.851
SumBase_Unzip	692.197	378.713	1.120949
SumBase	760.241	344.817	1.020620
SumTraits	39.053	6712.485	19.868201
Sum128Base_Basic	1846.379	141.977	0.420237
Sum128Base	1867.208	140.394	0.415549
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	52.974	4948.538	14.647117
Sum128Traits	52.873	4957.969	14.675030
Sum256Base_Basic	1330.659	197.003	0.583107
Sum256Base	1418.651	184.784	0.546940
Sum256Avx2_Shuffle	38.836	6749.942	19.979070
Sum256Traits	39.571	6624.726	19.608446

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809936964
# Sum128Base_Basic	1810330180
# Sum256Base_Basic	1809936964
SumBase_Basic	1045.500	250.735
SumBase_Unzip	1726.155	151.866	0.605681
SumBase	1099.718	238.374	0.950699
SumTraits	56.329	4653.792	18.560565
Sum128Base_Basic	3213.755	81.569	0.325320
Sum128Base	3161.705	82.912	0.330676
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	107.031	2449.238	9.768214
Sum128Sse_ShuffleXImm	55.085	4758.926	18.979867
Sum128Traits	55.645	4710.994	18.788702
Sum256Base_Basic	1966.977	133.273	0.531526
Sum256Base	2033.204	128.931	0.514213
Sum256Avx2_Shuffle	77.375	3387.961	13.512093
Sum256Avx2_ShuffleXImm	56.445	4644.251	18.522510
Sum256Traits	56.149	4668.680	18.619939

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-5443202675530370315
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	-5443202675530370315
SumBase_Basic	1949.349	134.478
SumBase	2011.759	130.306	0.968977
SumTraits	88.242	2970.747	22.090998
Sum128Base_Basic	6179.610	42.421	0.315449
Sum128Base_Move	4892.695	53.579	0.398420
Sum128Base	4932.534	53.146	0.395202
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	154.039	1701.806	12.654931
Sum128Sse_ShuffleXImm	71.570	3662.741	27.236788
Sum128Traits	71.753	3653.439	27.167623
Sum256Base_Basic	3509.624	74.693	0.555430
Sum256Base	3579.028	73.244	0.544659
Sum256Avx2_Shuffle	124.479	2105.934	15.660101
Sum256Avx2_ShuffleXImm	87.853	2983.878	22.188643
Sum256Traits	87.827	2984.785	22.195389

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	689.318	380.295
SumBase_Unzip	216.282	1212.048	3.187126
SumBase	216.449	1211.113	3.184669
SumTraits	21.912	11963.325	31.458031
Sum128Base_Basic	831.912	315.110	0.828595
Sum128Base_Shuffle	1507.588	173.883	0.457232
Sum128Base_Unzip	289.827	904.486	2.378381
Sum128Base	290.445	902.561	2.373319
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	33.893	7734.572	20.338361
Sum128Traits	32.746	8005.313	21.050284
Sum256Base_Basic	733.035	357.615	0.940362
Sum256Base_Shuffle	1460.264	179.518	0.472050
Sum256Base_Unzip	180.981	1448.459	3.808780
Sum256Base	181.927	1440.932	3.788986
Sum256Avx2_Shuffle	20.998	12484.445	32.828335
Sum256Traits	21.403	12248.054	32.206738

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	962.732	272.292
SumBase_Unzip	335.854	780.529	2.866517
SumBase	898.802	291.659	1.071128
SumTraits	43.854	5977.648	21.953102
Sum128Base_Basic	1178.441	222.450	0.816954
Sum128Base_Shuffle	3133.689	83.653	0.307220
Sum128Base_Unzip	473.605	553.507	2.032774
Sum128Base	1248.179	210.021	0.771310
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	74.860	3501.772	12.860368
Sum128Traits	66.009	3971.342	14.584881
Sum256Base_Basic	892.407	293.749	1.078804
Sum256Base_Shuffle	2841.405	92.259	0.338823
Sum256Base_Unzip	307.760	851.781	3.128192
Sum256Base	942.425	278.159	1.021548
Sum256Avx2_Shuffle	43.215	6066.006	22.277602
Sum256Traits	43.241	6062.408	22.264386

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-466706470
# Sum256Base_Basic	-467755046
SumBase_Basic	1350.537	194.104
SumBase_Unzip	623.480	420.453	2.166126
SumBase	1331.438	196.888	1.014345
SumTraits	63.906	4102.026	21.133182
Sum128Base_Basic	2077.353	126.191	0.650124
Sum128Base_Shuffle	5022.885	52.190	0.268877
Sum128Base_Unzip	730.866	358.676	1.847857
Sum128Base	1996.737	131.286	0.676372
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	122.434	2141.098	11.030697
Sum128Sse_ShuffleXImm	80.658	3250.072	16.744012
Sum128Traits	76.338	3433.977	17.691466
Sum256Base_Basic	1377.819	190.260	0.980199
Sum256Base_Shuffle	5584.612	46.940	0.241832
Sum256Base_Unzip	506.913	517.138	2.664235
Sum256Base	1373.602	190.844	0.983208
Sum256Avx2_Shuffle	88.088	2975.943	15.331727
Sum256Avx2_ShuffleXImm	62.417	4199.877	21.637299
Sum256Traits	63.479	4129.612	21.275302

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572532740
# Sum256Base_Basic	5910372263572008452
SumBase_Basic	2365.291	110.829
SumBase	2435.473	107.636	0.971184
SumTraits	101.756	2576.212	23.244829
Sum128Base_Basic	4276.012	61.306	0.553153
Sum128Base_Move	3390.097	77.326	0.697706
Sum128Base_Shuffle	7874.341	33.291	0.300380
Sum128Base	3379.893	77.560	0.699812
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	151.859	1726.233	15.575573
Sum128Sse_ShuffleXImm	93.054	2817.104	25.418358
Sum128Traits	94.601	2771.045	25.002779
Sum256Base_Basic	2356.534	111.241	1.003716
Sum256Base_Shuffle	10232.396	25.619	0.231157
Sum256Base	2293.243	114.311	1.031417
Sum256Avx2_Shuffle	121.858	2151.232	19.410282
Sum256Avx2_ShuffleXImm	101.033	2594.626	23.410971
Sum256Traits	101.519	2582.220	23.299033

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
SumBase_Basic	695.408	376.964
SumBase_Unzip	224.851	1165.855	3.092747
SumBase	223.962	1170.486	3.105033
SumTraits	18.725	13999.827	37.138346
Sum128Base_Basic	763.417	343.383	0.910916
Sum128Base_Shuffle	1503.805	174.321	0.462433
Sum128Base_Unzip	216.277	1212.078	3.215365
Sum128Base	217.008	1207.990	3.204523
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	22.575	11611.960	30.803881
Sum128Traits	22.350	11729.190	31.114863
Sum256Base_Basic	692.945	378.304	1.003555
Sum256Base_Shuffle	1586.979	165.184	0.438196
Sum256Base_Unzip	141.359	1854.459	4.919456
Sum256Base	141.070	1858.256	4.929528
Sum256Avx2_Shuffle	18.826	13924.659	36.938942
Sum256Traits	18.798	13945.205	36.993445

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
SumBase_Basic	918.875	285.288
SumBase_Unzip	336.169	779.799	2.733374
SumBase	837.497	313.009	1.097168
SumTraits	37.685	6956.168	24.382962
Sum128Base_Basic	1192.629	219.803	0.770461
Sum128Base_Shuffle	3118.303	84.066	0.294671
Sum128Base_Unzip	361.513	725.130	2.541745
Sum128Base	1136.767	230.605	0.808323
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	43.973	5961.458	20.896275
Sum128Traits	46.380	5652.138	19.812038
Sum256Base_Basic	864.125	303.363	1.063359
Sum256Base_Shuffle	3136.325	83.583	0.292978
Sum256Base_Unzip	242.944	1079.032	3.782253
Sum256Base	853.229	307.237	1.076938
Sum256Avx2_Shuffle	39.020	6718.251	23.549006
Sum256Traits	38.333	6838.606	23.970879

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809936964
# Sum128Base_Basic	1810330180
# Sum256Base_Basic	1809936964
SumBase_Basic	1293.739	202.625
SumBase_Unzip	618.443	423.878	2.091931
SumBase	1398.651	187.426	0.924991
SumTraits	57.391	4567.658	22.542414
Sum128Base_Basic	2096.026	125.067	0.617234
Sum128Base_Shuffle	5747.730	45.608	0.225087
Sum128Base_Unzip	613.568	427.245	2.108551
Sum128Base	2046.712	128.081	0.632106
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	88.688	2955.803	14.587546
Sum128Sse_ShuffleXImm	58.188	4505.109	22.233721
Sum128Traits	56.451	4643.770	22.918043
Sum256Base_Basic	1330.417	197.039	0.972431
Sum256Base_Shuffle	6146.923	42.646	0.210469
Sum256Base_Unzip	451.562	580.527	2.865029
Sum256Base	1315.920	199.210	0.983144
Sum256Avx2_Shuffle	75.538	3470.369	17.127047
Sum256Avx2_ShuffleXImm	57.443	4563.581	22.522291
Sum256Traits	57.889	4528.366	22.348499

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-5443202675530370315
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	-5443202675530370315
SumBase_Basic	2393.823	109.509
SumBase	2386.732	109.834	1.002971
SumTraits	89.682	2923.026	26.692229
Sum128Base_Basic	3894.366	67.314	0.614689
Sum128Base_Move	2518.078	104.105	0.950655
Sum128Base_Shuffle	8305.697	31.562	0.288215
Sum128Base	2516.756	104.159	0.951154
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	130.849	2003.406	18.294526
Sum128Sse_ShuffleXImm	78.413	3343.100	30.528221
Sum128Traits	77.202	3395.542	31.007101
Sum256Base_Basic	2327.367	112.635	1.028554
Sum256Base_Shuffle	13854.548	18.921	0.172782
Sum256Base	2368.372	110.685	1.010746
Sum256Avx2_Shuffle	123.450	2123.479	19.390994
Sum256Avx2_ShuffleXImm	90.405	2899.660	26.478855
Sum256Traits	90.202	2906.198	26.538556

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	561.568	466.807
SumBase_Unzip	212.393	1234.241	2.644007
SumBase	212.338	1234.563	2.644696
SumTraits	13.573	19313.026	41.372622
Sum128Base_Basic	597.332	438.858	0.940127
Sum128Base_Shuffle	1505.695	174.102	0.372963
Sum128Base_Unzip	282.610	927.583	1.987081
Sum128Base	284.710	920.739	1.972419
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	31.230	8393.971	17.981677
Sum128Sse_ShuffleX	27.412	9563.121	20.486245
Sum128Traits	26.576	9863.907	21.130592
Sum256Base_Basic	576.804	454.477	0.973586
Sum256Base_Shuffle	1407.184	186.290	0.399073
Sum256Base_Unzip	179.277	1462.231	3.132411
Sum256Base	179.726	1458.579	3.124588
Sum256Avx2_Shuffle	20.193	12982.061	27.810343
Sum256Avx2_ShuffleX	14.286	18349.676	39.308919
Sum256Traits	14.102	18589.666	39.823030
Sum512Base_Basic	593.095	441.994	0.946845
Sum512Base_Shuffle	1534.607	170.822	0.365936
Sum512Base_Unzip	126.509	2072.140	4.438965
Sum512Base	127.451	2056.815	4.406137
Sum512Avx512_ShuffleX	12.708	20628.960	44.191632
Sum512Traits	12.628	20758.455	44.469039

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	-24614
SumBase_Basic	654.213	400.701
SumBase_Unzip	334.459	783.785	1.956034
SumBase	682.543	384.070	0.958494
SumTraits	29.835	8786.461	21.927709
Sum128Base_Basic	992.925	264.012	0.658875
Sum128Base_Shuffle	2940.655	89.145	0.222472
Sum128Base_Unzip	460.358	569.435	1.421096
Sum128Base	1008.712	259.880	0.648563
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	62.119	4220.018	10.531581
Sum128Sse_ShuffleX	54.029	4851.907	12.108539
Sum128Traits	54.939	4771.527	11.907941
Sum256Base_Basic	626.540	418.400	1.044168
Sum256Base_Shuffle	2810.083	93.287	0.232809
Sum256Base_Unzip	307.901	851.391	2.124751
Sum256Base	622.325	421.233	1.051240
Sum256Avx2_Shuffle	39.834	6580.987	16.423672
Sum256Avx2_ShuffleX	29.423	8909.358	22.234414
Sum256Traits	29.743	8813.589	21.995411
Sum512Base_Basic	754.978	347.221	0.866532
Sum512Base_Shuffle	2870.416	91.326	0.227916
Sum512Base_Unzip	230.118	1139.170	2.842941
Sum512Base	760.415	344.738	0.860336
Sum512Avx512_ShuffleX	27.069	9684.440	24.168726
Sum512Traits	26.843	9765.652	24.371402

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-466706470
# Sum256Base_Basic	-467755046
# Sum512Base_Basic	-467755046
SumBase_Basic	927.494	282.637
SumBase_Unzip	615.850	425.662	1.506040
SumBase	916.969	285.881	1.011478
SumTraits	59.471	4407.946	15.595796
Sum128Base_Basic	1353.333	193.702	0.685340
Sum128Base_Shuffle	4952.362	52.933	0.187283
Sum128Base_Unzip	700.271	374.346	1.324478
Sum128Base	1634.120	160.419	0.567580
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	120.439	2176.579	7.700975
Sum128Sse_ShuffleX	92.502	2833.934	10.026769
Sum128Sse_ShuffleXImm	69.057	3796.051	13.430845
Sum128Traits	76.081	3445.600	12.190910
Sum256Base_Basic	939.710	278.963	0.987000
Sum256Base_Shuffle	5602.469	46.791	0.165551
Sum256Base_Unzip	512.060	511.940	1.811301
Sum256Base	931.562	281.403	0.995634
Sum256Avx2_Shuffle	80.160	3270.271	11.570577
Sum256Avx2_ShuffleX	58.468	4483.545	15.863273
Sum256Avx2_ShuffleXImm	58.091	4512.614	15.966122
Sum256Traits	58.065	4514.653	15.973337
Sum512Base_Basic	956.616	274.032	0.969557
Sum512Base_Shuffle	5726.256	45.779	0.161972
Sum512Base_Unzip	402.069	651.987	2.306801
Sum512Base	979.112	267.736	0.947281
Sum512Avx512_ShuffleX	54.685	4793.739	16.960772
Sum512Avx512_ShuffleXImm	77.651	3375.921	11.944380
Sum512Traits	54.760	4787.147	16.937452

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572532740
# Sum256Base_Basic	5910372263572008452
# Sum512Base_Basic	5910372263572008452
SumBase_Basic	1531.383	171.181
SumBase	1549.628	169.166	0.988226
SumTraits	87.573	2993.431	17.486913
Sum128Base_Basic	2014.147	130.151	0.760313
Sum128Base_Move	1776.428	147.568	0.862057
Sum128Base_Shuffle	8267.376	31.708	0.185232
Sum128Base	1776.744	147.542	0.861904
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	150.158	1745.793	10.198506
Sum128Sse_ShuffleX	131.218	1997.779	11.670550
Sum128Sse_ShuffleXImm	93.245	2811.358	16.423282
Sum128Traits	91.536	2863.836	16.729846
Sum256Base_Basic	1578.936	166.026	0.969883
Sum256Base_Shuffle	10227.979	25.630	0.149725
Sum256Base	1581.620	165.744	0.968237
Sum256Avx2_Shuffle	111.785	2345.081	13.699402
Sum256Avx2_ShuffleX	121.204	2162.840	12.634793
Sum256Avx2_ShuffleXImm	90.343	2901.644	16.950714
Sum256Traits	89.081	2942.764	17.190928
Sum512Base_Basic	1601.830	163.653	0.956021
Sum512Base_Shuffle	12313.275	21.290	0.124368
Sum512Base	1616.553	162.162	0.947313
Sum512Avx512_ShuffleX	108.118	2424.607	14.163977
Sum512Avx512_ShuffleXImm	134.409	1950.340	11.393423
Sum512Traits	108.216	2422.416	14.151180

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
# Sum512Base_Basic	182
SumBase_Basic	494.563	530.051
SumBase_Unzip	184.911	1417.676	2.674602
SumBase	185.316	1414.576	2.668753
SumTraits	7.989	32813.417	61.906119
Sum128Base_Basic	510.537	513.467	0.968712
Sum128Base_Shuffle	1411.264	185.751	0.350440
Sum128Base_Unzip	243.383	1077.083	2.032036
Sum128Base	244.386	1072.665	2.023700
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	21.662	12101.282	22.830399
Sum128Sse_ShuffleX	15.079	17384.406	32.797593
Sum128Traits	15.506	16905.897	31.894833
Sum256Base_Basic	501.306	522.922	0.986549
Sum256Base_Shuffle	1494.361	175.422	0.330953
Sum256Base_Unzip	156.617	1673.785	3.157780
Sum256Base	156.917	1670.588	3.151747
Sum256Avx2_Shuffle	15.503	16909.693	31.901995
Sum256Avx2_ShuffleX	7.796	33626.822	63.440696
Sum256Traits	7.707	34014.393	64.171891
Sum512Base_Basic	561.390	466.955	0.880962
Sum512Base_Shuffle	1493.265	175.551	0.331196
Sum512Base_Unzip	105.337	2488.632	4.695078
Sum512Base	105.083	2494.629	4.706392
Sum512Avx512_ShuffleX	5.982	43822.877	82.676675
Sum512Traits	5.970	43909.330	82.839778

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
# Sum512Base_Basic	29252
SumBase_Basic	605.122	433.208
SumBase_Unzip	283.335	925.207	2.135709
SumBase	616.808	425.001	0.981054
SumTraits	15.795	16596.372	38.310363
Sum128Base_Basic	886.902	295.573	0.682288
Sum128Base_Shuffle	2786.593	94.073	0.217155
Sum128Base_Unzip	388.424	674.891	1.557889
Sum128Base	899.685	291.373	0.672594
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	43.642	6006.662	13.865524
Sum128Sse_ShuffleX	30.353	8636.595	19.936352
Sum128Traits	31.464	8331.670	19.232474
Sum256Base_Basic	577.747	453.735	1.047382
Sum256Base_Shuffle	2993.021	87.585	0.202178
Sum256Base_Unzip	267.157	981.236	2.265043
Sum256Base	603.134	434.637	1.003297
Sum256Avx2_Shuffle	30.931	8475.126	19.563623
Sum256Avx2_ShuffleX	15.835	16555.087	38.215063
Sum256Traits	15.876	16512.073	38.115771
Sum512Base_Basic	714.540	366.871	0.846870
Sum512Base_Shuffle	2998.684	87.420	0.201796
Sum512Base_Unzip	187.271	1399.810	3.231262
Sum512Base	715.010	366.630	0.846312
Sum512Avx512_ShuffleX	13.354	19629.932	45.312906
Sum512Traits	13.794	19004.429	43.869020

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809936964
# Sum128Base_Basic	1810330180
# Sum256Base_Basic	1809936964
# Sum512Base_Basic	1809543748
SumBase_Basic	908.276	288.617
SumBase_Unzip	529.821	494.779	1.714307
SumBase	913.312	287.026	0.994486
SumTraits	32.089	8169.275	28.304882
Sum128Base_Basic	1464.453	179.005	0.620215
Sum128Base_Shuffle	6067.128	43.207	0.149704
Sum128Base_Unzip	592.598	442.364	1.532702
Sum128Base	1440.043	182.039	0.630728
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	87.105	3009.506	10.427328
Sum128Sse_ShuffleX	62.605	4187.272	14.508050
Sum128Sse_ShuffleXImm	47.979	5463.721	18.930688
Sum128Traits	48.261	5431.747	18.819902
Sum256Base_Basic	898.136	291.876	1.011290
Sum256Base_Shuffle	6088.554	43.055	0.149178
Sum256Base_Unzip	433.679	604.466	2.094353
Sum256Base	899.429	291.456	1.009836
Sum256Avx2_Shuffle	61.312	4275.570	14.813983
Sum256Avx2_ShuffleX	32.693	8018.338	27.781917
Sum256Avx2_ShuffleXImm	49.543	5291.225	18.333024
Sum256Traits	33.932	7725.525	26.767377
Sum512Base_Basic	935.356	280.261	0.971048
Sum512Base_Shuffle	6373.090	41.133	0.142517
Sum512Base_Unzip	318.137	823.997	2.854984
Sum512Base	940.725	278.662	0.965506
Sum512Avx512_ShuffleX	27.768	9440.370	32.708971
Sum512Avx512_ShuffleXImm	72.198	3630.880	12.580264
Sum512Traits	27.545	9517.029	32.974577

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-5443202675530370315
# Sum128Base_Basic	5910372263572663812
# Sum256Base_Basic	-5443202675530370315
# Sum512Base_Basic	-5443202675530566923
SumBase_Basic	1580.426	165.869
SumBase	1525.663	171.823	1.035895
SumTraits	63.688	4116.096	24.815314
Sum128Base_Basic	2811.914	93.226	0.562046
Sum128Base_Move	1721.139	152.308	0.918244
Sum128Base_Shuffle	8133.891	32.229	0.194301
Sum128Base	1723.081	152.137	0.917210
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	131.581	1992.271	12.011098
Sum128Sse_ShuffleX	109.484	2394.354	14.435194
Sum128Sse_ShuffleXImm	73.924	3546.137	21.379123
Sum128Traits	70.825	3701.295	22.314546
Sum256Base_Basic	1552.136	168.892	1.018227
Sum256Base_Shuffle	10918.422	24.009	0.144749
Sum256Base	1549.364	169.195	1.020048
Sum256Avx2_Shuffle	107.538	2437.678	14.696392
Sum256Avx2_ShuffleX	61.330	4274.302	25.769119
Sum256Avx2_ShuffleXImm	75.416	3475.974	20.956117
Sum256Traits	62.126	4219.571	25.439149
Sum512Base_Basic	1557.538	168.307	1.014695
Sum512Base_Shuffle	12317.498	21.282	0.128307
Sum512Base	1572.446	166.711	1.005075
Sum512Avx512_ShuffleX	52.603	4983.476	30.044617
Sum512Avx512_ShuffleXImm	122.601	2138.180	12.890760
Sum512Traits	52.719	4972.455	29.978177

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	503.610	520.529
SumBase_Unzip	200.510	1307.385	2.511644
SumBase	200.491	1307.512	2.511889
SumTraits	19.305	13579.136	26.087162
Sum128Base_Basic	786.914	333.129	0.639981
Sum128Base	787.574	332.850	0.639445
Sum128AdvSimd_Shuffle	42.785	6126.954	11.770619
Sum128AdvSimdB64_Shuffle	19.304	13579.777	26.088392
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.297	13584.712	26.097872
Sum256Base_Basic	831.159	315.396	0.605913
Sum256Base	843.880	310.641	0.596779
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	896.811	292.307	0.561557

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	629.997	416.104
SumBase_Unzip	365.977	716.286	1.721411
SumBase	627.191	417.965	1.004474
SumTraits	38.584	6794.162	16.328044
Sum128Base_Basic	930.472	281.732	0.677072
Sum128Base	927.315	282.691	0.679377
Sum128AdvSimd_Shuffle	85.533	3064.839	7.365562
Sum128AdvSimdB64_Shuffle	38.576	6795.556	16.331394
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.581	6794.679	16.329287
Sum256Base_Basic	1046.851	250.412	0.601801
Sum256Base	1044.919	250.875	0.602914
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1157.364	226.501	0.544337

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-467755046
# Sum256Base_Basic	-467755046
SumBase_Basic	906.412	289.211
SumBase_Unzip	1303.773	201.066	0.695222
SumBase	905.026	289.653	1.001531
SumTraits	53.020	4944.271	17.095736
Sum128Base_Basic	1338.618	195.832	0.677125
Sum128Base	1356.987	193.181	0.667959
Sum128AdvSimd_AlignRight	53.021	4944.118	17.095207
Sum128AdvSimd_Shuffle	150.279	1744.386	6.031539
Sum128AdvSimdB64_Shuffle	72.307	3625.425	12.535581
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	53.022	4944.094	17.095123
Sum256Base_Basic	1642.188	159.631	0.551954
Sum256Base	1639.964	159.847	0.552702
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1745.744	150.162	0.519212

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572008452
# Sum256Base_Basic	5910372263572008452
SumBase_Basic	1830.542	143.206
SumBase	1813.278	144.569	1.009521
SumTraits	77.126	3398.923	23.734554
Sum128Base_Basic	2304.536	113.751	0.794321
Sum128Base	632.403	414.521	2.894583
Sum128AdvSimd_AlignRight	77.104	3399.868	23.741157
Sum128AdvSimd_Shuffle	184.263	1422.660	9.934383
Sum128AdvSimdB64_Shuffle	101.196	2590.453	18.089036
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.091	3400.460	23.745289
Sum256Base_Basic	2866.360	91.455	0.638629
Sum256Base	2869.493	91.355	0.637932
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2870.539	91.322	0.637700

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
SumBase_Basic	469.221	558.679
SumBase_Unzip	405.861	645.896	1.156113
SumBase	405.821	645.960	1.156228
SumTraits	15.092	17370.143	31.091448
Sum128Base_Basic	682.144	384.294	0.687863
Sum128Base	681.276	384.784	0.688739
Sum128AdvSimd_Shuffle	37.613	6969.571	12.475087
Sum128AdvSimdB64_Shuffle	15.092	17369.160	31.089688
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	15.090	17371.934	31.094654
Sum256Base_Basic	707.564	370.488	0.663150
Sum256Base	721.519	363.323	0.650324
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	742.195	353.201	0.632207

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
SumBase_Basic	617.569	424.478
SumBase_Unzip	489.021	536.059	1.262868
SumBase	618.951	423.529	0.997766
SumTraits	30.176	8687.038	20.465245
Sum128Base_Basic	835.642	313.704	0.739035
Sum128Base	843.870	310.645	0.731829
Sum128AdvSimd_Shuffle	75.181	3486.834	8.214411
Sum128AdvSimdB64_Shuffle	30.175	8687.440	20.466191
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	30.174	8687.655	20.466699
Sum256Base_Basic	901.077	290.923	0.685367
Sum256Base	918.454	285.419	0.672400
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	950.840	275.697	0.649498

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809543748
# Sum128Base_Basic	1809543748
# Sum256Base_Basic	1809347140
SumBase_Basic	901.412	290.815
SumBase_Unzip	1297.257	202.076	0.694860
SumBase	901.196	290.884	1.000239
SumTraits	43.398	6040.415	20.770660
Sum128Base_Basic	1218.339	215.165	0.739870
Sum128Base	1228.747	213.343	0.733603
Sum128AdvSimd_AlignRight	43.385	6042.281	20.777075
Sum128AdvSimd_Shuffle	150.368	1743.352	5.994716
Sum128AdvSimdB64_Shuffle	60.304	4347.075	14.947915
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	43.383	6042.495	20.777811
Sum256Base_Basic	1454.423	180.239	0.619773
Sum256Base	1456.699	179.958	0.618804
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1549.842	169.142	0.581615

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	-5443202675530697995
SumBase_Basic	1804.342	145.285
SumBase	1801.818	145.489	1.001401
SumTraits	78.838	3325.110	22.886800
Sum128Base_Basic	2341.824	111.940	0.770486
Sum128Base_Move	602.973	434.752	2.992409
Sum128Base	604.516	433.643	2.984771
Sum128AdvSimd_AlignRight	77.654	3375.814	23.235794
Sum128AdvSimd_Shuffle	203.981	1285.141	8.845653
Sum128AdvSimdB64_AlignRight	78.818	3325.956	22.892619
Sum128AdvSimdB64_Shuffle	96.411	2719.029	18.715133
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.828	3325.530	22.889689
Sum256Base_Basic	2621.956	99.980	0.688167
Sum256Base	2629.322	99.700	0.686239
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2620.508	100.036	0.688547

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	486.883	538.412
SumBase_Unzip	180.437	1452.826	2.698353
SumBase	180.486	1452.436	2.697628
SumTraits	19.313	13573.332	25.209924
Sum128Base_Basic	483.539	542.136	1.006917
Sum128Base_Shuffle	981.316	267.135	0.496153
Sum128Base_Unzip	1353.277	193.711	0.359781
Sum128Base	1350.068	194.171	0.360636
Sum128AdvSimd_Shuffle	41.233	6357.662	11.808167
Sum128AdvSimdB64_Shuffle	19.312	13573.854	25.210894
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.313	13573.402	25.210055
Sum256Base_Basic	963.187	272.163	0.505492
Sum256Base_Shuffle	2168.620	120.881	0.224513
Sum256Base_Unzip	1502.976	174.417	0.323946
Sum256Base	966.308	271.284	0.503859
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	964.205	271.876	0.504959

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	587.056	446.540
SumBase_Unzip	328.053	799.091	1.789518
SumBase	587.940	445.869	0.998498
SumTraits	38.878	6742.763	15.100031
Sum128Base_Basic	587.655	446.085	0.998982
Sum128Base_Shuffle	1855.436	141.284	0.316398
Sum128Base_Unzip	2224.211	117.859	0.263939
Sum128Base	584.732	448.315	1.003976
Sum128AdvSimd_Shuffle	82.436	3179.980	7.121382
Sum128AdvSimdB64_Shuffle	38.878	6742.762	15.100028
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.915	6736.367	15.085707
Sum256Base_Basic	1165.665	224.888	0.503624
Sum256Base_Shuffle	4225.770	62.035	0.138923
Sum256Base_Unzip	2356.011	111.266	0.249174
Sum256Base	1179.670	222.218	0.497645
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1154.348	227.093	0.508561

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-467755046
# Sum256Base_Basic	-467755046
SumBase_Basic	794.566	329.921
SumBase_Unzip	477.260	549.269	1.664850
SumBase	787.668	332.810	1.008757
SumTraits	53.037	4942.637	14.981276
Sum128Base_Basic	793.918	330.190	1.000817
Sum128Base_Shuffle	3236.499	80.996	0.245502
Sum128Base_Unzip	3495.102	75.003	0.227337
Sum128Base	801.967	326.876	0.990771
Sum128AdvSimd_AlignRight	53.040	4942.346	14.980395
Sum128AdvSimd_Shuffle	145.386	1803.087	5.465208
Sum128AdvSimdB64_Shuffle	72.479	3616.831	10.962721
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	53.079	4938.763	14.969534
Sum256Base_Basic	1544.696	169.706	0.514384
Sum256Base_Shuffle	7617.564	34.413	0.104307
Sum256Base_Unzip	3367.540	77.844	0.235948
Sum256Base	1547.254	169.425	0.513533
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1540.356	170.184	0.515833

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572008452
# Sum256Base_Basic	5910372263572008452
SumBase_Basic	1628.218	161.001
SumBase	1624.706	161.349	1.002162
SumTraits	77.899	3365.173	20.901626
Sum128Base_Basic	1641.226	159.725	0.992074
Sum128Base_Move	96.372	2720.113	16.895051
Sum128Base_Shuffle	5042.433	51.988	0.322903
Sum128Base	96.356	2720.566	16.897870
Sum128AdvSimd_AlignRight	77.857	3366.973	20.912805
Sum128AdvSimd_Shuffle	183.956	1425.034	8.851115
Sum128AdvSimdB64_Shuffle	96.564	2714.717	16.861537
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.874	3366.244	20.908273
Sum256Base_Basic	2621.402	100.001	0.621125
Sum256Base_Shuffle	12671.601	20.688	0.128493
Sum256Base	2611.111	100.396	0.623573
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2621.510	99.997	0.621099

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
SumBase_Basic	448.595	584.367
SumBase_Unzip	122.286	2143.697	3.668409
SumBase	122.314	2143.201	3.667560
SumTraits	14.491	18090.243	30.956990
Sum128Base_Basic	449.073	583.745	0.998935
Sum128Base_Shuffle	1059.594	247.400	0.423365
Sum128Base_Unzip	121.544	2156.787	3.690809
Sum128Base	120.536	2174.823	3.721674
Sum128AdvSimd_Shuffle	36.408	7200.204	12.321374
Sum128AdvSimdB64_Shuffle	14.493	18087.791	30.952794
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	14.491	18090.702	30.957775
Sum256Base_Basic	802.487	326.664	0.559005
Sum256Base_Shuffle	2044.707	128.206	0.219393
Sum256Base_Unzip	893.031	293.544	0.502328
Sum256Base	804.078	326.018	0.557900
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	804.178	325.978	0.557830

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
SumBase_Basic	561.056	467.233
SumBase_Unzip	229.683	1141.328	2.442736
SumBase	562.319	466.184	0.997754
SumTraits	28.962	9051.363	19.372256
Sum128Base_Basic	556.943	470.683	1.007384
Sum128Base_Shuffle	2117.837	123.779	0.264919
Sum128Base_Unzip	194.759	1345.994	2.880776
Sum128Base	555.061	472.280	1.010801
Sum128AdvSimd_Shuffle	72.786	3601.586	7.708324
Sum128AdvSimdB64_Shuffle	28.989	9042.734	19.353789
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	28.987	9043.571	19.355580
Sum256Base_Basic	973.213	269.359	0.576499
Sum256Base_Shuffle	3812.845	68.753	0.147149
Sum256Base_Unzip	1319.328	198.695	0.425259
Sum256Base	982.186	266.898	0.571232
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	980.958	267.233	0.571947

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809543748
# Sum128Base_Basic	1809543748
# Sum256Base_Basic	1809347140
SumBase_Basic	778.148	336.882
SumBase_Unzip	298.185	879.131	2.609612
SumBase	781.146	335.589	0.996163
SumTraits	43.383	6042.525	17.936628
Sum128Base_Basic	776.986	337.386	1.001496
Sum128Base_Shuffle	4235.092	61.898	0.183738
Sum128Base_Unzip	300.112	873.486	2.592855
Sum128Base	778.922	336.547	0.999006
Sum128AdvSimd_AlignRight	43.389	6041.745	17.934312
Sum128AdvSimd_Shuffle	145.522	1801.410	5.347304
Sum128AdvSimdB64_Shuffle	57.936	4524.701	13.431121
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	43.383	6042.575	17.936775
Sum256Base_Basic	1276.243	205.403	0.609718
Sum256Base_Shuffle	7289.770	35.961	0.106745
Sum256Base_Unzip	2000.070	131.067	0.389060
Sum256Base	1279.804	204.831	0.608021
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1280.989	204.642	0.607459

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	-5443202675530697995
SumBase_Basic	1577.408	166.187
SumBase	1591.104	164.756	0.991392
SumTraits	78.845	3324.803	20.006449
Sum128Base_Basic	1585.048	165.386	0.995180
Sum128Base_Move	77.342	3389.427	20.395311
Sum128Base_Shuffle	6438.844	40.713	0.244983
Sum128Base	77.342	3389.425	20.395300
Sum128AdvSimd_AlignRight	77.655	3375.740	20.312954
Sum128AdvSimd_Shuffle	203.640	1287.293	7.746072
Sum128AdvSimdB64_AlignRight	78.843	3324.902	20.007045
Sum128AdvSimdB64_Shuffle	86.772	3021.067	18.178764
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.824	3325.705	20.011877
Sum256Base_Basic	2246.184	116.706	0.702261
Sum256Base_Shuffle	14097.052	18.596	0.111896
Sum256Base	2239.223	117.069	0.704444
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2244.916	116.772	0.702658

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	408.827	641.209
SumBase_Unzip	179.672	1459.013	2.275408
SumBase	179.684	1458.918	2.275261
SumTraits	15.929	16457.464	25.666288
Sum128Base_Basic	408.875	641.135	0.999884
Sum128Base_Shuffle	980.089	267.470	0.417133
Sum128Base_Unzip	168.079	1559.648	2.432354
Sum128Base	168.102	1559.436	2.432023
Sum128AdvSimd_Shuffle	41.242	6356.244	9.912899
Sum128AdvSimd_ShuffleX	29.364	8927.413	13.922775
Sum128AdvSimdB64_Shuffle	19.303	13580.241	21.179107
Sum128AdvSimdB64_ShuffleX	15.925	16460.828	25.671535
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	15.931	16454.649	25.661898
Sum256Base_Basic	409.763	639.746	0.997717
Sum256Base_Shuffle	900.620	291.071	0.453940
Sum256Base_Unzip	411.904	636.420	0.992531
Sum256Base	409.580	640.031	0.998162
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	409.574	640.040	0.998177
Sum512Base_Basic	431.477	607.551	0.947508
Sum512Base_Shuffle	1417.033	184.995	0.288509
Sum512Base_Unzip	655.586	399.862	0.623606
Sum512Base	432.415	606.232	0.945451
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	432.350	606.324	0.945594

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	-24614
SumBase_Basic	440.027	595.746
SumBase_Unzip	325.983	804.164	1.349845
SumBase	440.168	595.555	0.999680
SumTraits	32.397	8091.684	13.582445
Sum128Base_Basic	440.041	595.726	0.999967
Sum128Base_Shuffle	1839.754	142.489	0.239177
Sum128Base_Unzip	275.156	952.712	1.599192
Sum128Base	440.191	595.523	0.999626
Sum128AdvSimd_Shuffle	82.440	3179.825	5.337554
Sum128AdvSimd_ShuffleX	58.664	4468.549	7.500765
Sum128AdvSimdB64_Shuffle	38.936	6732.619	11.301162
Sum128AdvSimdB64_ShuffleX	32.392	8092.919	13.584519
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	32.380	8095.871	13.589473
Sum256Base_Basic	439.142	596.946	1.002015
Sum256Base_Shuffle	1810.450	144.795	0.243048
Sum256Base_Unzip	488.872	536.222	0.900086
Sum256Base	439.246	596.805	1.001778
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	439.058	597.060	1.002205
Sum512Base_Basic	494.986	529.598	0.888967
Sum512Base_Shuffle	2717.220	96.475	0.161940
Sum512Base_Unzip	988.553	265.179	0.445122
Sum512Base	494.799	529.799	0.889304
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	495.516	529.033	0.888018

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-467755046
# Sum256Base_Basic	-467755046
# Sum512Base_Basic	-467755046
SumBase_Basic	518.394	505.684
SumBase_Unzip	474.917	551.978	1.091547
SumBase	518.167	505.906	1.000439
SumTraits	48.238	5434.410	10.746643
Sum128Base_Basic	518.192	505.882	1.000391
Sum128Base_Shuffle	3237.249	80.977	0.160134
Sum128Base_Unzip	433.260	605.050	1.196497
Sum128Base	518.247	505.828	1.000285
Sum128AdvSimd_AlignRight	48.206	5437.977	10.753697
Sum128AdvSimd_Shuffle	145.418	1802.688	3.564848
Sum128AdvSimd_ShuffleX	97.995	2675.072	5.290003
Sum128AdvSimdB64_Shuffle	72.438	3618.851	7.156343
Sum128AdvSimdB64_ShuffleX	58.351	4492.558	8.884115
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	48.209	5437.666	10.753081
Sum256Base_Basic	493.996	530.660	1.049390
Sum256Base_Shuffle	3612.083	72.574	0.143517
Sum256Base_Unzip	615.343	426.013	0.842449
Sum256Base	494.482	530.139	1.048359
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	494.523	530.094	1.048271
Sum512Base_Basic	606.627	432.134	0.854552
Sum512Base_Shuffle	5377.377	48.749	0.096403
Sum512Base_Unzip	920.131	284.899	0.563392
Sum512Base	606.678	432.097	0.854480
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	605.388	433.018	0.856301

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572008452
# Sum256Base_Basic	5910372263572008452
# Sum512Base_Basic	5910372263572008452
SumBase_Basic	673.855	389.022
SumBase	673.415	389.276	1.000653
SumTraits	78.821	3325.810	8.549167
Sum128Base_Basic	672.914	389.565	1.001398
Sum128Base_Move	78.520	3338.561	8.581943
Sum128Base_Shuffle	4971.112	52.733	0.135554
Sum128Base	78.526	3338.318	8.581319
Sum128AdvSimd_AlignRight	78.810	3326.278	8.550370
Sum128AdvSimd_Shuffle	164.669	1591.940	4.092165
Sum128AdvSimd_ShuffleX	118.800	2206.596	5.672170
Sum128AdvSimdB64_Shuffle	81.953	3198.727	8.222494
Sum128AdvSimdB64_ShuffleX	77.173	3396.853	8.731787
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.833	3325.301	8.547859
Sum256Base_Basic	786.143	333.456	0.857165
Sum256Base_Shuffle	6228.773	42.086	0.108184
Sum256Base	787.747	332.777	0.855420
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	785.571	333.699	0.857790
Sum512Base_Basic	963.420	272.097	0.699440
Sum512Base_Shuffle	10739.710	24.409	0.062744
Sum512Base	965.513	271.507	0.697924
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	964.413	271.817	0.698720

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
# Sum512Base_Basic	182
SumBase_Basic	367.758	712.817
SumBase_Unzip	120.072	2183.216	3.062800
SumBase	120.080	2183.076	3.062603
SumTraits	9.686	27063.256	37.966614
Sum128Base_Basic	367.690	712.949	1.000185
Sum128Base_Shuffle	1143.776	229.192	0.321529
Sum128Base_Unzip	114.272	2294.033	3.218262
Sum128Base	114.269	2294.086	3.218337
Sum128AdvSimd_Shuffle	36.387	7204.290	10.106785
Sum128AdvSimd_ShuffleX	18.721	14002.610	19.644041
Sum128AdvSimdB64_Shuffle	14.481	18102.928	25.396312
Sum128AdvSimdB64_ShuffleX	9.689	27055.608	37.955885
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.688	27058.236	37.959572
Sum256Base_Basic	369.809	708.862	0.994452
Sum256Base_Shuffle	983.133	266.641	0.374067
Sum256Base_Unzip	306.653	854.856	1.199265
Sum256Base	369.888	708.712	0.994242
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	369.838	708.808	0.994375
Sum512Base_Basic	389.320	673.337	0.944614
Sum512Base_Shuffle	1397.176	187.624	0.263215
Sum512Base_Unzip	316.495	828.271	1.161968
Sum512Base	389.207	673.534	0.944891
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	389.404	673.193	0.944412

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
# Sum512Base_Basic	29252
SumBase_Basic	394.843	663.919
SumBase_Unzip	225.834	1160.780	1.748376
SumBase	394.843	663.919	1.000001
SumTraits	19.357	13542.761	20.398212
Sum128Base_Basic	394.791	664.008	1.000134
Sum128Base_Shuffle	2137.229	122.656	0.184745
Sum128Base_Unzip	182.007	1440.293	2.169381
Sum128Base	394.943	663.751	0.999747
Sum128AdvSimd_Shuffle	72.743	3603.707	5.427931
Sum128AdvSimd_ShuffleX	37.392	7010.608	10.559432
Sum128AdvSimdB64_Shuffle	28.981	9045.482	13.624376
Sum128AdvSimdB64_ShuffleX	19.362	13539.271	20.392955
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.361	13540.015	20.394076
Sum256Base_Basic	395.370	663.034	0.998668
Sum256Base_Shuffle	1988.692	131.817	0.198544
Sum256Base_Unzip	356.451	735.429	1.107709
Sum256Base	395.537	662.755	0.998246
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	395.485	662.841	0.998377
Sum512Base_Basic	441.074	594.331	0.895185
Sum512Base_Shuffle	2794.692	93.801	0.141283
Sum512Base_Unzip	379.305	691.117	1.040966
Sum512Base	444.759	589.407	0.887769
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	444.412	589.867	0.888462

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809543748
# Sum128Base_Basic	1809543748
# Sum256Base_Basic	1809347140
# Sum512Base_Basic	1809248836
SumBase_Basic	474.513	552.449
SumBase_Unzip	291.514	899.251	1.627756
SumBase	474.541	552.416	0.999940
SumTraits	38.705	6772.956	12.259884
Sum128Base_Basic	474.494	552.471	1.000040
Sum128Base_Shuffle	4267.791	61.424	0.111185
Sum128Base_Unzip	271.601	965.180	1.747095
Sum128Base	474.521	552.440	0.999984
Sum128AdvSimd_AlignRight	38.641	6784.122	12.280096
Sum128AdvSimd_Shuffle	145.471	1802.038	3.261911
Sum128AdvSimd_ShuffleX	74.846	3502.457	6.339878
Sum128AdvSimdB64_Shuffle	57.905	4527.108	8.194624
Sum128AdvSimdB64_ShuffleX	38.724	6769.615	12.253836
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.714	6771.312	12.256908
Sum256Base_Basic	444.861	589.271	1.066654
Sum256Base_Shuffle	3932.122	66.667	0.120676
Sum256Base_Unzip	440.837	594.650	1.076390
Sum256Base	444.927	589.185	1.066497
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	444.710	589.471	1.067016
Sum512Base_Basic	540.504	484.999	0.877909
Sum512Base_Shuffle	5497.293	47.686	0.086318
Sum512Base_Unzip	483.730	541.922	0.980945
Sum512Base	540.795	484.738	0.877436
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	540.458	485.040	0.877983

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	-5443202675530697995
# Sum512Base_Basic	-5443202675530730763
SumBase_Basic	595.216	440.418
SumBase	594.847	440.692	1.000621
SumTraits	79.101	3314.022	7.524718
Sum128Base_Basic	594.722	440.784	1.000831
Sum128Base_Move	79.056	3315.914	7.529013
Sum128Base_Shuffle	6404.191	40.933	0.092942
Sum128Base	78.986	3318.875	7.535737
Sum128AdvSimd_AlignRight	78.815	3326.072	7.552078
Sum128AdvSimd_Shuffle	203.657	1287.181	2.922635
Sum128AdvSimd_ShuffleX	110.096	2381.057	5.406355
Sum128AdvSimdB64_AlignRight	78.837	3325.124	7.549924
Sum128AdvSimdB64_Shuffle	86.739	3022.203	6.862122
Sum128AdvSimdB64_ShuffleX	77.108	3399.692	7.719236
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.802	3326.612	7.553304
Sum256Base_Basic	673.750	389.082	0.883438
Sum256Base_Shuffle	7890.292	33.224	0.075437
Sum256Base	673.790	389.059	0.883385
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	674.226	388.807	0.882814
Sum512Base_Basic	904.078	289.957	0.658368
Sum512Base_Shuffle	11157.259	23.495	0.053348
Sum512Base	903.911	290.011	0.658490
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	903.920	290.008	0.658483

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	1378.107	190.220
SumBase_Unzip	895.054	292.881	1.539692
SumBase	926.858	282.831	1.486859
SumTraits	899.828	291.327	1.531523
Sum128Base_Basic	2366.501	110.773	0.582339
Sum128Base	2368.879	110.662	0.581755
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2365.838	110.804	0.582503
Sum256Base_Basic	2283.326	114.808	0.603552
Sum256Base	2314.087	113.282	0.595529
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2508.118	104.518	0.549459

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1719.529	152.451
SumBase_Unzip	1595.189	164.334	1.077947
SumBase	1721.829	152.247	0.998664
SumTraits	1709.432	153.352	1.005906
Sum128Base_Basic	3205.815	81.771	0.536378
Sum128Base	3227.861	81.213	0.532715
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	3263.397	80.329	0.526914
Sum256Base_Basic	3410.950	76.854	0.504120
Sum256Base	3502.113	74.853	0.490998
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3892.289	67.350	0.441778

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-467755046
# Sum256Base_Basic	-467755046
SumBase_Basic	2306.628	113.648
SumBase_Unzip	3732.417	70.234	0.617999
SumBase	2331.161	112.452	0.989476
SumTraits	2336.909	112.176	0.987043
Sum128Base_Basic	4812.598	54.470	0.479290
Sum128Base	4835.513	54.212	0.477018
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	4804.529	54.562	0.480095
Sum256Base_Basic	5307.396	49.392	0.434606
Sum256Base	5414.898	48.412	0.425978
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	6188.413	42.360	0.372733

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572008452
# Sum256Base_Basic	5910372263572008452
SumBase_Basic	3398.146	77.143
SumBase	3435.801	76.298	0.989040
SumTraits	3426.849	76.497	0.991624
Sum128Base_Basic	5187.886	50.530	0.655015
Sum128Base	3996.234	65.598	0.850337
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	4003.502	65.479	0.848793
Sum256Base_Basic	8092.772	32.392	0.419899
Sum256Base	8287.988	31.629	0.410009
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	9902.730	26.472	0.343152

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
Check-SumBase_Unzip	Check `SumBase_Unzip` mismatch. 101!=182
Check-SumBase	Check `SumBase` mismatch. 101!=182
Check-SumTraits	Check `SumTraits` mismatch. 101!=182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
SumBase_Basic	1288.827	203.397
SumBase_Unzip	1376.259	190.476	0.936471
SumBase	1374.059	190.781	0.937971
SumTraits	1375.347	190.602	0.937092
Sum128Base_Basic	2050.866	127.821	0.628431
Sum128Base	2041.971	128.378	0.631168
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2040.435	128.475	0.631643
Sum256Base_Basic	1964.610	133.433	0.656022
Sum256Base	1991.247	131.648	0.647246
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2169.696	120.821	0.594013

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
SumBase_Basic	1614.779	162.341
SumBase_Unzip	1685.967	155.486	0.957776
SumBase	1607.631	163.062	1.004446
SumTraits	1598.775	163.966	1.010010
Sum128Base_Basic	2753.880	95.191	0.586365
Sum128Base	2772.687	94.545	0.582388
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2793.089	93.855	0.578134
Sum256Base_Basic	3033.954	86.403	0.532236
Sum256Base	3113.366	84.200	0.518660
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3472.997	75.481	0.464952

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809543748
# Sum128Base_Basic	1809543748
# Sum256Base_Basic	1809347140
SumBase_Basic	2295.484	114.200
SumBase_Unzip	3787.264	69.217	0.606106
SumBase	2312.924	113.339	0.992460
SumTraits	2310.033	113.481	0.993702
Sum128Base_Basic	4084.048	64.187	0.562061
Sum128Base	4090.801	64.081	0.561133
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	4081.506	64.227	0.562411
Sum256Base_Basic	4759.031	55.083	0.482343
Sum256Base	4851.239	54.037	0.473175
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	5609.093	46.736	0.409243

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	-5443202675530697995
SumBase_Basic	3377.456	77.616
SumBase	3399.277	77.118	0.993581
SumTraits	3405.162	76.984	0.991864
Sum128Base_Basic	4781.989	54.819	0.706287
Sum128Base_Move	2662.418	98.461	1.268567
Sum128Base	2641.627	99.236	1.278552
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2638.765	99.343	1.279938
Sum256Base_Basic	7593.253	34.523	0.444797
Sum256Base	7709.409	34.003	0.438095
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	9193.377	28.514	0.367379

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	1346.626	194.667
SumBase_Unzip	839.964	312.090	1.603195
SumBase	839.643	312.209	1.603808
SumTraits	56.836	4612.299	23.693244
Sum128Base_Basic	2430.023	107.877	0.554162
Sum128Base	2429.712	107.891	0.554233
Sum128AdvSimd_Shuffle	139.488	1879.325	9.654040
Sum128AdvSimdB64_Shuffle	56.740	4620.092	23.733275
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	62.014	4227.170	21.714846
Sum256Base_Basic	2337.943	112.126	0.575987
Sum256Base	2372.076	110.512	0.567699
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2538.250	103.277	0.530533

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1685.167	155.560
SumBase_Unzip	1508.470	173.781	1.117136
SumBase	1675.630	156.445	1.005692
SumTraits	127.121	2062.156	13.256368
Sum128Base_Basic	3241.591	80.869	0.519858
Sum128Base	3246.376	80.750	0.519092
Sum128AdvSimd_Shuffle	294.986	888.666	5.712701
Sum128AdvSimdB64_Shuffle	127.888	2049.794	13.176898
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	122.001	2148.699	13.812703
Sum256Base_Basic	3188.739	82.209	0.528474
Sum256Base	3218.567	81.447	0.523577
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3531.154	74.237	0.477228

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-467755046
# Sum256Base_Basic	-467755046
SumBase_Basic	2329.968	112.510
SumBase_Unzip	3699.499	70.859	0.629806
SumBase	2292.291	114.359	1.016436
SumTraits	148.376	1766.756	15.703147
Sum128Base_Basic	4981.174	52.627	0.467755
Sum128Base	4992.074	52.512	0.466733
Sum128AdvSimd_AlignRight	148.100	1770.049	15.732410
Sum128AdvSimd_Shuffle	510.050	513.958	4.568120
Sum128AdvSimdB64_Shuffle	226.757	1156.059	10.275191
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	148.253	1768.223	15.716182
Sum256Base_Basic	4948.074	52.979	0.470884
Sum256Base	4930.068	53.172	0.472604
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	5199.726	50.415	0.448094

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572008452
# Sum256Base_Basic	5910372263572008452
SumBase_Basic	3383.711	77.472
SumBase	3392.193	77.279	0.997500
SumTraits	212.629	1232.871	15.913690
Sum128Base_Basic	5194.672	50.464	0.651381
Sum128Base	1965.314	133.385	1.721715
Sum128AdvSimd_AlignRight	212.433	1234.007	15.928352
Sum128AdvSimd_Shuffle	612.819	427.768	5.521554
Sum128AdvSimdB64_Shuffle	313.989	834.883	10.776526
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	212.490	1233.679	15.924126
Sum256Base_Basic	7497.477	34.964	0.451313
Sum256Base	7663.764	34.206	0.441521
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	7700.078	34.044	0.439439

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
SumBase_Basic	1244.022	210.723
SumBase_Unzip	1258.597	208.283	0.988420
SumBase	1256.294	208.664	0.990232
SumTraits	47.416	5528.545	26.236091
Sum128Base_Basic	2004.416	130.783	0.620641
Sum128Base	2017.259	129.951	0.616689
Sum128AdvSimd_Shuffle	125.371	2090.938	9.922690
Sum128AdvSimdB64_Shuffle	45.110	5811.236	27.577619
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	45.076	5815.625	27.598450
Sum256Base_Basic	1988.434	131.834	0.625629
Sum256Base	2047.342	128.041	0.607628
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2119.949	123.656	0.586817

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
SumBase_Basic	1558.753	168.175
SumBase_Unzip	1600.288	163.811	0.974046
SumBase	1559.070	168.141	0.999797
SumTraits	95.896	2733.614	16.254543
Sum128Base_Basic	2741.057	95.636	0.568669
Sum128Base	2765.055	94.806	0.563733
Sum128AdvSimd_Shuffle	259.198	1011.366	6.013755
Sum128AdvSimdB64_Shuffle	91.920	2851.884	16.957792
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	91.418	2867.543	17.050903
Sum256Base_Basic	2833.225	92.525	0.550169
Sum256Base	2908.230	90.139	0.535980
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3010.944	87.064	0.517696

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809543748
# Sum128Base_Basic	1809543748
# Sum256Base_Basic	1809347140
SumBase_Basic	2246.306	116.700
SumBase_Unzip	3737.972	70.130	0.600942
SumBase	2198.330	119.247	1.021824
SumTraits	121.986	2148.971	18.414482
Sum128Base_Basic	4088.842	64.112	0.549375
Sum128Base	4132.315	63.438	0.543595
Sum128AdvSimd_AlignRight	122.099	2146.980	18.397425
Sum128AdvSimd_Shuffle	522.446	501.763	4.299598
Sum128AdvSimdB64_Shuffle	184.012	1424.604	12.207401
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	121.959	2149.451	18.418595
Sum256Base_Basic	4330.737	60.531	0.518689
Sum256Base	4316.351	60.733	0.520418
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4546.084	57.664	0.494119

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	-5443202675530697995
SumBase_Basic	3330.280	78.715
SumBase	3343.716	78.399	0.995982
SumTraits	159.860	1639.839	20.832535
Sum128Base_Basic	4470.336	58.641	0.744973
Sum128Base_Move	1559.319	168.114	2.135728
Sum128Base	1563.954	167.616	2.129398
Sum128AdvSimd_AlignRight	185.473	1413.380	17.955598
Sum128AdvSimd_Shuffle	728.111	360.033	4.573866
Sum128AdvSimdB64_AlignRight	159.759	1640.871	20.845650
Sum128AdvSimdB64_Shuffle	268.313	977.009	12.411935
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	159.585	1642.666	20.868444
Sum256Base_Basic	6496.955	40.349	0.512591
Sum256Base	6497.652	40.344	0.512536
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	6509.097	40.273	0.511635

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	1399.570	187.303
SumBase_Unzip	791.606	331.154	1.768013
SumBase	791.435	331.226	1.768395
SumTraits	57.490	4559.826	24.344627
Sum128Base_Basic	1401.309	187.071	0.998759
Sum128Base_Shuffle	2302.175	113.868	0.607934
Sum128Base_Unzip	4212.197	62.234	0.332266
Sum128Base	4211.899	62.239	0.332290
Sum128AdvSimd_Shuffle	117.896	2223.526	11.871265
Sum128AdvSimdB64_Shuffle	57.493	4559.555	24.343182
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	57.557	4554.484	24.316105
Sum256Base_Basic	2894.625	90.562	0.483507
Sum256Base_Shuffle	5465.332	47.965	0.256082
Sum256Base_Unzip	4493.148	58.343	0.311490
Sum256Base	2900.717	90.372	0.482491
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2900.529	90.378	0.482522

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	1743.659	150.341
SumBase_Unzip	1450.034	180.785	1.202496
SumBase	1744.643	150.257	0.999436
SumTraits	110.502	2372.310	15.779498
Sum128Base_Basic	1743.308	150.372	1.000201
Sum128Base_Shuffle	4656.271	56.299	0.374475
Sum128Base_Unzip	7134.029	36.746	0.244414
Sum128Base	1765.044	148.520	0.987884
Sum128AdvSimd_Shuffle	232.334	1128.305	7.504959
Sum128AdvSimdB64_Shuffle	110.566	2370.929	15.770311
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	110.982	2362.040	15.711188
Sum256Base_Basic	3634.426	72.128	0.479762
Sum256Base_Shuffle	9726.378	26.952	0.179271
Sum256Base_Unzip	7076.140	37.046	0.246414
Sum256Base	3675.422	71.324	0.474411
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3676.352	71.305	0.474291

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-467755046
# Sum256Base_Basic	-467755046
SumBase_Basic	2378.230	110.227
SumBase_Unzip	2087.125	125.601	1.139477
SumBase	2372.361	110.499	1.002474
SumTraits	145.860	1797.230	16.304885
Sum128Base_Basic	2377.408	110.265	1.000346
Sum128Base_Shuffle	7576.607	34.599	0.313891
Sum128Base_Unzip	11576.262	22.645	0.205440
Sum128Base	2383.255	109.994	0.997891
Sum128AdvSimd_AlignRight	145.877	1797.022	16.302996
Sum128AdvSimd_Shuffle	410.448	638.677	5.794225
Sum128AdvSimdB64_Shuffle	206.497	1269.481	11.517025
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	145.863	1797.193	16.304545
Sum256Base_Basic	4814.221	54.452	0.494001
Sum256Base_Shuffle	17765.607	14.756	0.133867
Sum256Base_Unzip	10379.810	25.255	0.229121
Sum256Base	4818.221	54.407	0.493591
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4798.679	54.628	0.495601

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572008452
# Sum256Base_Basic	5910372263572008452
SumBase_Basic	3635.965	72.097
SumBase	3647.516	71.869	0.996833
SumTraits	185.108	1416.166	19.642381
Sum128Base_Basic	3660.590	71.612	0.993273
Sum128Base_Move	263.661	994.248	13.790323
Sum128Base_Shuffle	12722.972	20.604	0.285780
Sum128Base	263.724	994.008	13.787000
Sum128AdvSimd_AlignRight	184.863	1418.043	19.668407
Sum128AdvSimd_Shuffle	503.810	520.323	7.216941
Sum128AdvSimdB64_Shuffle	266.490	983.692	13.643910
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	184.936	1417.484	19.660650
Sum256Base_Basic	5916.416	44.308	0.614555
Sum256Base_Shuffle	28223.037	9.288	0.128830
Sum256Base	5960.456	43.981	0.610015
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	5901.049	44.423	0.616156

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
SumBase_Basic	1307.011	200.568
SumBase_Unzip	384.880	681.106	3.395895
SumBase	384.647	681.519	3.397954
SumTraits	41.263	6353.013	31.675185
Sum128Base_Basic	1296.272	202.229	1.008285
Sum128Base_Shuffle	2226.518	117.737	0.587020
Sum128Base_Unzip	372.403	703.925	3.509668
Sum128Base	383.275	683.959	3.410116
Sum128AdvSimd_Shuffle	102.844	2548.951	12.708693
Sum128AdvSimdB64_Shuffle	41.070	6382.854	31.823967
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	41.020	6390.652	31.862846
Sum256Base_Basic	2425.738	108.068	0.538810
Sum256Base_Shuffle	4777.402	54.872	0.273582
Sum256Base_Unzip	2672.822	98.078	0.489000
Sum256Base	2439.077	107.477	0.535863
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2441.333	107.377	0.535368

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
SumBase_Basic	1647.705	159.096
SumBase_Unzip	723.852	362.151	2.276300
SumBase	1647.858	159.082	0.999907
SumTraits	79.602	3293.200	20.699392
Sum128Base_Basic	1646.867	159.177	1.000509
Sum128Base_Shuffle	4434.852	59.110	0.371535
Sum128Base_Unzip	626.059	418.721	2.631867
Sum128Base	1660.015	157.917	0.992584
Sum128AdvSimd_Shuffle	201.827	1298.852	8.163930
Sum128AdvSimdB64_Shuffle	79.690	3289.533	20.676338
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	79.696	3289.300	20.674874
Sum256Base_Basic	3115.993	84.129	0.528790
Sum256Base_Shuffle	8422.076	31.126	0.195641
Sum256Base_Unzip	3918.662	66.896	0.420476
Sum256Base	3112.415	84.225	0.529397
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3110.819	84.268	0.529669

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809543748
# Sum128Base_Basic	1809543748
# Sum256Base_Basic	1809347140
SumBase_Basic	2273.164	115.321
SumBase_Unzip	969.446	270.406	2.344806
SumBase	2274.437	115.257	0.999440
SumTraits	119.306	2197.232	19.053146
Sum128Base_Basic	2269.868	115.489	1.001452
Sum128Base_Shuffle	8893.206	29.477	0.255607
Sum128Base_Unzip	942.517	278.132	2.411801
Sum128Base	2289.081	114.519	0.993047
Sum128AdvSimd_AlignRight	119.359	2196.269	19.044794
Sum128AdvSimd_Shuffle	405.390	646.646	5.607346
Sum128AdvSimdB64_Shuffle	160.069	1637.695	14.201161
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	119.289	2197.550	19.055904
Sum256Base_Basic	4258.105	61.564	0.533844
Sum256Base_Shuffle	15724.208	16.671	0.144565
Sum256Base_Unzip	5622.127	46.627	0.404325
Sum256Base	4200.762	62.404	0.541131
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4185.057	62.638	0.543162

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	-5443202675530697995
SumBase_Basic	3620.330	72.409
SumBase	3618.352	72.448	1.000546
SumTraits	132.505	1978.375	27.322269
Sum128Base_Basic	3610.046	72.615	1.002849
Sum128Base_Move	212.005	1236.496	17.076585
Sum128Base_Shuffle	12066.763	21.724	0.300025
Sum128Base	211.613	1238.788	17.108227
Sum128AdvSimd_AlignRight	158.724	1651.576	22.809025
Sum128AdvSimd_Shuffle	567.176	462.192	6.383081
Sum128AdvSimdB64_AlignRight	132.247	1982.228	27.375479
Sum128AdvSimdB64_Shuffle	264.020	992.895	13.712335
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	132.366	1980.444	27.350850
Sum256Base_Basic	5555.511	47.186	0.651665
Sum256Base_Shuffle	31014.389	8.452	0.116731
Sum256Base	5554.593	47.194	0.651772
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	5544.481	47.280	0.652961

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	1162.696	225.462
SumBase_Unzip	763.221	343.471	1.523408
SumBase	763.324	343.424	1.523202
SumTraits	45.400	5774.140	25.610244
Sum128Base_Basic	1162.242	225.550	1.000391
Sum128Base_Shuffle	2269.684	115.498	0.512272
Sum128Base_Unzip	694.195	377.623	1.674883
Sum128Base	694.341	377.544	1.674533
Sum128AdvSimd_Shuffle	115.276	2274.059	10.086211
Sum128AdvSimd_ShuffleX	88.713	2954.983	13.106337
Sum128AdvSimdB64_Shuffle	55.343	4736.753	21.009086
Sum128AdvSimdB64_ShuffleX	44.973	5828.885	25.853056
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	45.006	5824.685	25.834426
Sum256Base_Basic	1141.138	229.722	1.018892
Sum256Base_Shuffle	2267.236	115.623	0.512825
Sum256Base_Unzip	1256.037	208.707	0.925687
Sum256Base	1142.342	229.480	1.017819
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1141.607	229.627	1.018474
Sum512Base_Basic	1216.700	215.455	0.955615
Sum512Base_Shuffle	3939.411	66.544	0.295145
Sum512Base_Unzip	1790.722	146.390	0.649289
Sum512Base	1218.608	215.118	0.954119
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1217.432	215.325	0.955040

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	-24614
SumBase_Basic	1276.564	205.351
SumBase_Unzip	1408.752	186.082	0.906167
SumBase	1272.372	206.028	1.003295
SumTraits	93.769	2795.647	13.613982
Sum128Base_Basic	1277.371	205.222	0.999369
Sum128Base_Shuffle	4559.766	57.491	0.279963
Sum128Base_Unzip	1133.308	231.309	1.126405
Sum128Base	1280.503	204.720	0.996924
Sum128AdvSimd_Shuffle	235.889	1111.301	5.411708
Sum128AdvSimd_ShuffleX	181.915	1441.024	7.017363
Sum128AdvSimdB64_Shuffle	115.811	2263.555	11.022850
Sum128AdvSimdB64_ShuffleX	93.819	2794.161	13.606745
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	93.953	2790.148	13.587204
Sum256Base_Basic	1351.424	193.976	0.944607
Sum256Base_Shuffle	4543.406	57.698	0.280971
Sum256Base_Unzip	1561.375	167.893	0.817590
Sum256Base	1357.790	193.067	0.940178
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1355.592	193.380	0.941703
Sum512Base_Basic	1438.114	182.283	0.887666
Sum512Base_Shuffle	7698.085	34.053	0.165829
Sum512Base_Unzip	2747.533	95.411	0.464622
Sum512Base	1441.038	181.913	0.885865
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1440.882	181.933	0.885960

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-467755046
# Sum256Base_Basic	-467755046
# Sum512Base_Basic	-467755046
SumBase_Basic	1522.960	172.128
SumBase_Unzip	2025.541	129.419	0.751878
SumBase	1523.165	172.105	0.999865
SumTraits	148.043	1770.725	10.287258
Sum128Base_Basic	1522.908	172.134	1.000034
Sum128Base_Shuffle	7495.380	34.974	0.203187
Sum128Base_Unzip	1751.377	149.679	0.869579
Sum128Base	1523.813	172.032	0.999440
Sum128AdvSimd_AlignRight	147.927	1772.119	10.295358
Sum128AdvSimd_Shuffle	419.029	625.598	3.634495
Sum128AdvSimd_ShuffleX	310.146	845.228	4.910466
Sum128AdvSimdB64_Shuffle	217.300	1206.371	7.008569
Sum128AdvSimdB64_ShuffleX	175.214	1496.134	8.691989
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	147.825	1773.341	10.302458
Sum256Base_Basic	1635.121	160.321	0.931405
Sum256Base_Shuffle	9102.742	28.798	0.167308
Sum256Base_Unzip	2007.576	130.577	0.758607
Sum256Base	1634.769	160.355	0.931606
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1635.226	160.311	0.931345
Sum512Base_Basic	1829.159	143.314	0.832601
Sum512Base_Shuffle	14916.155	17.575	0.102101
Sum512Base_Unzip	2858.481	91.707	0.532786
Sum512Base	1832.303	143.068	0.831172
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1848.408	141.821	0.823931

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572008452
# Sum256Base_Basic	5910372263572008452
# Sum512Base_Basic	5910372263572008452
SumBase_Basic	1814.429	144.477
SumBase	1911.657	137.129	0.949140
SumTraits	146.262	1792.285	12.405297
Sum128Base_Basic	1904.522	137.643	0.952695
Sum128Base_Move	185.517	1413.043	9.780374
Sum128Base_Shuffle	12456.059	21.046	0.145666
Sum128Base	185.600	1412.414	9.776018
Sum128AdvSimd_AlignRight	146.271	1792.176	12.404544
Sum128AdvSimd_Shuffle	469.707	558.101	3.862893
Sum128AdvSimd_ShuffleX	338.439	774.568	5.361167
Sum128AdvSimdB64_Shuffle	241.198	1086.841	7.522566
Sum128AdvSimdB64_ShuffleX	187.325	1399.410	9.686015
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	146.270	1792.192	12.404653
Sum256Base_Basic	2130.368	123.051	0.851697
Sum256Base_Shuffle	15048.431	17.420	0.120573
Sum256Base	2128.994	123.130	0.852247
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2128.496	123.159	0.852446
Sum512Base_Basic	2594.131	101.053	0.699436
Sum512Base_Shuffle	30245.328	8.667	0.059990
Sum512Base	2615.466	100.228	0.693731
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	2601.981	100.748	0.697326

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
# Sum512Base_Basic	182
SumBase_Basic	1065.504	246.028
SumBase_Unzip	381.811	686.581	2.790658
SumBase	381.843	686.524	2.790426
SumTraits	24.937	10512.407	42.728450
Sum128Base_Basic	1066.844	245.719	0.998744
Sum128Base_Shuffle	2309.503	113.507	0.461356
Sum128Base_Unzip	322.636	812.508	3.302498
Sum128Base	322.636	812.508	3.302499
Sum128AdvSimd_Shuffle	101.078	2593.483	10.541403
Sum128AdvSimd_ShuffleX	56.584	4632.828	18.830471
Sum128AdvSimdB64_Shuffle	39.738	6596.832	26.813310
Sum128AdvSimdB64_ShuffleX	24.902	10527.088	42.788125
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	24.899	10528.249	42.792843
Sum256Base_Basic	1028.820	254.801	1.035656
Sum256Base_Shuffle	2119.999	123.653	0.502596
Sum256Base_Unzip	968.549	270.657	1.100103
Sum256Base	1030.445	254.399	1.034023
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1029.857	254.544	1.034613
Sum512Base_Basic	1102.010	237.878	0.966873
Sum512Base_Shuffle	3829.167	68.460	0.278260
Sum512Base_Unzip	907.957	288.719	1.173518
Sum512Base	1108.779	236.426	0.960970
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1102.177	237.842	0.966727

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
# Sum512Base_Basic	29252
SumBase_Basic	1195.500	219.276
SumBase_Unzip	730.527	358.843	1.636491
SumBase	1195.014	219.365	1.000407
SumTraits	52.511	4992.210	22.766830
Sum128Base_Basic	1193.756	219.596	1.001461
Sum128Base_Shuffle	4664.515	56.200	0.256297
Sum128Base_Unzip	532.546	492.246	2.244876
Sum128Base	1195.135	219.343	1.000306
Sum128AdvSimd_Shuffle	205.388	1276.333	5.820679
Sum128AdvSimd_ShuffleX	117.266	2235.461	10.194755
Sum128AdvSimdB64_Shuffle	83.644	3134.060	14.292793
Sum128AdvSimdB64_ShuffleX	52.572	4986.348	22.740098
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	52.567	4986.882	22.742533
Sum256Base_Basic	1140.202	229.910	1.048499
Sum256Base_Shuffle	4241.033	61.811	0.281889
Sum256Base_Unzip	1247.967	210.057	0.957959
Sum256Base	1139.595	230.033	1.049057
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1140.078	229.935	1.048613
Sum512Base_Basic	1328.473	197.327	0.899905
Sum512Base_Shuffle	7611.273	34.442	0.157070
Sum512Base_Unzip	1227.235	213.605	0.974142
Sum512Base	1330.595	197.013	0.898470
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1329.429	197.185	0.899258

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809543748
# Sum128Base_Basic	1809543748
# Sum256Base_Basic	1809347140
# Sum512Base_Basic	1809248836
SumBase_Basic	1403.202	186.818
SumBase_Unzip	996.405	263.090	1.408264
SumBase	1402.805	186.871	1.000283
SumTraits	105.469	2485.518	13.304457
Sum128Base_Basic	1409.409	185.996	0.995596
Sum128Base_Shuffle	9351.763	28.032	0.150047
Sum128Base_Unzip	832.767	314.787	1.684987
Sum128Base	1403.140	186.827	1.000044
Sum128AdvSimd_AlignRight	122.020	2148.376	11.499805
Sum128AdvSimd_Shuffle	414.956	631.739	3.381565
Sum128AdvSimd_ShuffleX	234.173	1119.447	5.992163
Sum128AdvSimdB64_Shuffle	166.289	1576.439	8.438344
Sum128AdvSimdB64_ShuffleX	105.446	2486.061	13.307361
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	105.623	2481.875	13.284954
Sum256Base_Basic	1332.957	196.663	1.052698
Sum256Base_Shuffle	8487.080	30.887	0.165334
Sum256Base_Unzip	1546.084	169.553	0.907584
Sum256Base	1332.753	196.694	1.052860
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1339.058	195.767	1.047902
Sum512Base_Basic	1641.039	159.743	0.855069
Sum512Base_Shuffle	15278.414	17.158	0.091842
Sum512Base_Unzip	1458.585	179.725	0.962029
Sum512Base	1645.602	159.300	0.852698
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1646.854	159.179	0.852050

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	-5443202675530697995
# Sum512Base_Basic	-5443202675530730763
SumBase_Basic	1771.588	147.971
SumBase	1752.593	149.575	1.010839
SumTraits	133.921	1957.456	13.228630
Sum128Base_Basic	1771.360	147.990	1.000129
Sum128Base_Move	133.776	1959.573	13.242941
Sum128Base_Shuffle	12051.152	21.753	0.147006
Sum128Base	133.643	1961.529	13.256155
Sum128AdvSimd_AlignRight	160.275	1635.593	11.053459
Sum128AdvSimd_Shuffle	572.802	457.652	3.092847
Sum128AdvSimd_ShuffleX	301.420	869.695	5.877466
Sum128AdvSimdB64_AlignRight	134.031	1955.846	13.217750
Sum128AdvSimdB64_Shuffle	253.608	1033.660	6.985551
Sum128AdvSimdB64_ShuffleX	160.211	1636.246	11.057874
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	133.767	1959.709	13.243856
Sum256Base_Basic	1681.857	155.866	1.053353
Sum256Base_Shuffle	17473.933	15.002	0.101385
Sum256Base	1681.897	155.862	1.053328
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1682.496	155.807	1.052952
Sum512Base_Basic	2306.259	113.666	0.768165
Sum512Base_Shuffle	31629.243	8.288	0.056011
Sum512Base	2294.913	114.228	0.771963
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	2294.370	114.255	0.772146

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


[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	80400.000	3.260
SumBase_Unzip	54204.167	4.836	1.483281
SumBase	75816.667	3.458	1.060453
SumTraits	5535.417	47.358	14.524652
Sum128Base_Basic	77816.667	3.369	1.033198
Sum128Base_Shuffle	7177.083	36.525	11.202322
Sum128Base_Unzip	46820.833	5.599	1.717184
Sum128Base	45012.500	5.824	1.786171
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	4629.687	56.622	17.366183
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	4583.333	57.195	17.541818
Sum256Base_Basic	79833.333	3.284	1.007098
Sum256Base_Shuffle	84525.000	3.101	0.951198
Sum256Base_Unzip	63416.667	4.134	1.267806
Sum256Base	81350.000	3.222	0.988322
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	83375.000	3.144	0.964318
Sum512Base_Basic	79100.000	3.314	1.016435
Sum512Base_Shuffle	95916.666	2.733	0.838228
Sum512Base_Unzip	69791.667	3.756	1.152000
Sum512Base	79375.000	3.303	1.012913
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	78708.333	3.331	1.021493

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	-24614
SumBase_Basic	98275.000	2.667
SumBase_Unzip	81725.000	3.208	1.202508
SumBase	94158.333	2.784	1.043721
SumTraits	10808.333	24.254	9.092521
Sum128Base_Basic	94841.667	2.764	1.036201
Sum128Base_Shuffle	14130.208	18.552	6.954958
Sum128Base_Unzip	389100.000	0.674	0.252570
Sum128Base	99150.000	2.644	0.991175
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	8921.875	29.382	11.015061
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	8985.417	29.174	10.937167
Sum256Base_Basic	93041.667	2.817	1.056247
Sum256Base_Shuffle	184350.000	1.422	0.533089
Sum256Base_Unzip	95116.667	2.756	1.033205
Sum256Base	97441.667	2.690	1.008552
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	104858.333	2.500	0.937217
Sum512Base_Basic	93758.333	2.796	1.048173
Sum512Base_Shuffle	197616.667	1.327	0.497301
Sum512Base_Unzip	125633.333	2.087	0.782237
Sum512Base	97458.333	2.690	1.008380
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	96875.000	2.706	1.014452

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# Sum128Base_Basic	-467755046
# Sum256Base_Basic	-467755046
# Sum512Base_Basic	-467755046
SumBase_Basic	116758.333	2.245
SumBase_Unzip	111558.333	2.350	1.046612
SumBase	115441.667	2.271	1.011405
SumTraits	21025.000	12.468	5.553310
Sum128Base_Basic	113383.333	2.312	1.029766
Sum128Base_Shuffle	25202.083	10.402	4.632884
Sum128Base_Unzip	668100.000	0.392	0.174762
Sum128Base	114116.667	2.297	1.023149
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	15445.833	16.972	7.559212
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	15481.250	16.933	7.541919
Sum256Base_Basic	121016.667	2.166	0.964812
Sum256Base_Shuffle	360516.666	0.727	0.323864
Sum256Base_Unzip	144083.333	1.819	0.810353
Sum256Base	116216.667	2.256	1.004661
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	129816.667	2.019	0.899409
Sum512Base_Basic	121716.667	2.154	0.959263
Sum512Base_Shuffle	379666.667	0.690	0.307529
Sum512Base_Unzip	191933.334	1.366	0.608328
Sum512Base	119950.000	2.185	0.973392
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	124133.333	2.112	0.940588

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# Sum128Base_Basic	5910372263572008452
# Sum256Base_Basic	5910372263572008452
# Sum512Base_Basic	5910372263572008452
SumBase_Basic	249883.333	1.049
SumBase	246283.333	1.064	1.014617
SumTraits	136000.000	1.928	1.837377
Sum128Base_Basic	348616.667	0.752	0.716785
Sum128Base_Move	248166.667	1.056	1.006917
Sum128Base_Shuffle	248933.333	1.053	1.003816
Sum128Base	261583.333	1.002	0.955272
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	18843.750	13.911	13.260807
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	50870.833	5.153	4.912114
Sum256Base_Basic	371716.667	0.705	0.672241
Sum256Base_Shuffle	804200.000	0.326	0.310723
Sum256Base	357416.667	0.733	0.699137
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	205450.000	1.276	1.216273
Sum512Base_Basic	360233.333	0.728	0.693671
Sum512Base_Shuffle	952816.667	0.275	0.262258
Sum512Base	366850.000	0.715	0.681159
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	188150.000	1.393	1.328107

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
# Sum128Base_Basic	182
# Sum256Base_Basic	182
# Sum512Base_Basic	182
SumBase_Basic	81233.333	3.227
SumBase_Unzip	56416.667	4.647	1.439882
SumBase	79783.333	3.286	1.018174
SumTraits	4264.583	61.470	19.048363
Sum128Base_Basic	77133.333	3.399	1.053155
Sum128Base_Shuffle	6800.000	38.551	11.946078
Sum128Base_Unzip	20375.000	12.866	3.986912
Sum128Base	19360.417	13.540	4.195846
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	3186.198	82.275	25.495382
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	3169.531	82.707	25.629447
Sum256Base_Basic	79966.667	3.278	1.015840
Sum256Base_Shuffle	82416.667	3.181	0.985642
Sum256Base_Unzip	43945.833	5.965	1.848488
Sum256Base	77650.000	3.376	1.046147
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	77200.000	3.396	1.052245
Sum512Base_Basic	77283.333	3.392	1.051111
Sum512Base_Shuffle	84141.667	3.116	0.965435
Sum512Base_Unzip	54583.333	4.803	1.488244
Sum512Base	77000.000	3.404	1.054978
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	76516.667	3.426	1.061642

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
# Sum128Base_Basic	29252
# Sum256Base_Basic	29252
# Sum512Base_Basic	29252
SumBase_Basic	93158.333	2.814
SumBase_Unzip	80866.667	3.242	1.151999
SumBase	92875.000	2.823	1.003051
SumTraits	7776.042	33.712	11.980174
Sum128Base_Basic	92825.000	2.824	1.003591
Sum128Base_Shuffle	13360.417	19.621	6.972712
Sum128Base_Unzip	206733.333	1.268	0.450621
Sum128Base	94850.000	2.764	0.982165
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	6304.687	41.579	14.776043
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	6258.333	41.887	14.885486
Sum256Base_Basic	88100.000	2.976	1.057416
Sum256Base_Shuffle	168883.334	1.552	0.551614
Sum256Base_Unzip	95216.667	2.753	0.978383
Sum256Base	91050.000	2.879	1.023156
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	97775.000	2.681	0.952783
Sum512Base_Basic	90258.333	2.904	1.032130
Sum512Base_Shuffle	171450.000	1.529	0.543356
Sum512Base_Unzip	90966.667	2.882	1.024093
Sum512Base	90275.000	2.904	1.031939
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	90741.667	2.889	1.026632

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809543748
# Sum128Base_Basic	1809543748
# Sum256Base_Basic	1809347140
# Sum512Base_Basic	1809248836
SumBase_Basic	118041.667	2.221
SumBase_Unzip	122950.000	2.132	0.960079
SumBase	116758.333	2.245	1.010991
SumTraits	16420.833	15.964	7.188531
Sum128Base_Basic	116666.667	2.247	1.011786
Sum128Base_Shuffle	27689.583	9.467	4.263035
Sum128Base_Unzip	332466.666	0.788	0.355048
Sum128Base	114083.333	2.298	1.034697
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	12797.917	20.483	9.223506
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	12301.042	21.311	9.596071
Sum256Base_Basic	114708.333	2.285	1.029059
Sum256Base_Shuffle	335266.667	0.782	0.352083
Sum256Base_Unzip	140100.000	1.871	0.842553
Sum256Base	117783.333	2.226	1.002193
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	127491.667	2.056	0.925878
Sum512Base_Basic	110783.333	2.366	1.065518
Sum512Base_Shuffle	347983.333	0.753	0.339216
Sum512Base_Unzip	141150.000	1.857	0.836285
Sum512Base	112666.667	2.327	1.047707
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	112491.667	2.330	1.049337

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572139524
# Sum128Base_Basic	5910372263572139524
# Sum256Base_Basic	-5443202675530697995
# Sum512Base_Basic	-5443202675530730763
SumBase_Basic	228000.000	1.150
SumBase	222233.333	1.180	1.025949
SumTraits	89816.667	2.919	2.538504
Sum128Base_Basic	330283.333	0.794	0.690316
Sum128Base_Move	201116.667	1.303	1.133670
Sum128Base_Shuffle	190233.333	1.378	1.198528
Sum128Base	202366.666	1.295	1.126668
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_AlignRight	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_ShuffleX	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	19243.750	13.622	11.848003
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19662.500	13.332	11.595677
Sum256Base_Basic	338933.334	0.773	0.672699
Sum256Base_Shuffle	812866.667	0.322	0.280489
Sum256Base	323650.000	0.810	0.704465
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	203066.667	1.291	1.122784
Sum512Base_Basic	309250.000	0.848	0.737268
Sum512Base_Shuffle	851100.000	0.308	0.267889
Sum512Base	306666.666	0.855	0.743478
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	175133.333	1.497	1.301865

```

