# Benchmark - ShiftRightArithmetic
([← Back](README.md))

See [Group](ShiftRightArithmetic_Group.md)

- `ShiftRightArithmetic[/_Args/_Core/_Const/_ConstCore/_Fast]`: Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
  Mnemonic: `rt[i] := value[i] >> shiftAmount`, `shiftAmount &= (T.BitSize-1)`.

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	241.568	1085.176
SumSRA_Base_Basic	200.494	1307.489	1.204863
SumSRA_Base	143.182	1830.849	1.687145
SumSRA_Base_Core	141.112	1857.705	1.711893
SumSRATraits	143.295	1829.405	1.685815
SumSRATraits_Core	142.651	1837.663	1.693425
SumSRAConstTraits	142.729	1836.653	1.692494
SumSRAConstTraits_Core	143.213	1830.444	1.686772
SumSRAFastTraits	143.157	1831.163	1.687434

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	192.346	1362.876
SumSRA_Base_Basic	298.242	878.964	0.644933
SumSRA_Base	299.643	874.854	0.641918
SumSRA_Base_Core	283.987	923.086	0.677307
SumSRATraits	296.568	883.925	0.648574
SumSRATraits_Core	285.092	919.507	0.674681
SumSRAConstTraits	287.517	911.750	0.668990
SumSRAConstTraits_Core	285.800	917.228	0.673009
SumSRAFastTraits	286.260	915.754	0.671928

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	188.114	1393.540
SumSRA_Base_Basic	547.562	478.748	0.343548
SumSRA_Base	546.173	479.965	0.344422
SumSRA_Base_Create	575.138	455.794	0.327076
SumSRA_Base_LoadArray	556.206	471.308	0.338209
SumSRA_Base_Core	540.291	485.190	0.348171
SumSRATraits	543.186	482.604	0.346315
SumSRATraits_Core	514.581	509.432	0.365566
SumSRAConstTraits	513.225	510.778	0.366533
SumSRAConstTraits_Core	514.414	509.597	0.365685
SumSRAFastTraits	512.531	511.470	0.367029

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	262.915	997.067
SumSRA_Base_Basic	144.925	1808.831	1.814152
SumSRA_Base	72.013	3640.252	3.650959
SumSRA_Base_Core	72.093	3636.168	3.646863
SumSRATraits	72.105	3635.592	3.646285
SumSRATraits_Core	71.768	3652.670	3.663414
SumSRAConstTraits	71.798	3651.109	3.661849
SumSRAConstTraits_Core	71.571	3662.694	3.673467
SumSRAFastTraits	71.850	3648.484	3.659216

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	251.161	1043.731
SumSRA_Base_Basic	180.993	1448.367	1.387683
SumSRA_Base	141.335	1854.774	1.777062
SumSRA_Base_Core	139.444	1879.924	1.801158
SumSRATraits	140.791	1861.938	1.783926
SumSRATraits_Core	139.865	1874.262	1.795733
SumSRAConstTraits	139.412	1880.351	1.801567
SumSRAConstTraits_Core	139.486	1879.354	1.800612
SumSRAFastTraits	139.212	1883.055	1.804158

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	198.367	1321.507
SumSRA_Base_Basic	294.898	888.932	0.672665
SumSRA_Base	290.389	902.735	0.683110
SumSRA_Base_Core	279.211	938.876	0.710458
SumSRATraits	292.854	895.137	0.677361
SumSRATraits_Core	281.446	931.419	0.704816
SumSRAConstTraits	278.130	942.523	0.713219
SumSRAConstTraits_Core	279.236	938.789	0.710393
SumSRAFastTraits	276.955	946.521	0.716244

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	196.810	1331.963
SumSRA_Base_Basic	532.834	491.981	0.369365
SumSRA_Base	532.313	492.462	0.369726
SumSRA_Base_Create	559.629	468.425	0.351680
SumSRA_Base_LoadArray	577.631	453.826	0.340719
SumSRA_Base_Core	530.549	494.099	0.370956
SumSRATraits	534.111	490.804	0.368482
SumSRATraits_Core	502.414	521.769	0.391729
SumSRAConstTraits	495.267	529.298	0.397382
SumSRAConstTraits_Core	493.360	531.344	0.398918
SumSRAFastTraits	502.005	522.194	0.392048

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	269.101	974.147
SumSRA_Base_Basic	149.747	1750.576	1.797035
SumSRA_Base	69.836	3753.726	3.853347
SumSRA_Base_Core	69.721	3759.908	3.859693
SumSRATraits	70.911	3696.780	3.794889
SumSRATraits_Core	70.028	3743.427	3.842775
SumSRAConstTraits	69.835	3753.761	3.853384
SumSRAConstTraits_Core	69.844	3753.270	3.852879
SumSRAFastTraits	69.536	3769.918	3.869969

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	213.503	1227.822
SumSRA_Base_Basic	189.795	1381.192	1.124912
SumSRA_Base	138.968	1886.363	1.536349
SumSRA_Base_Core	139.383	1880.751	1.531778
SumSRA_Avx2	9.908	26458.728	21.549314
SumSRATraits	10.223	25643.096	20.885022
SumSRATraits_Core	7.884	33248.481	27.079229
SumSRAConstTraits	9.126	28724.613	23.394764
SumSRAConstTraits_Core	7.725	33935.625	27.638873
SumSRA128Traits	18.866	13895.054	11.316828
SumSRA128Traits_Core	14.416	18184.779	14.810595
SumSRA128ConstTraits	17.898	14646.559	11.928892
SumSRA128ConstTraits_Core	13.829	18956.104	15.438801
SumSRAFast_Avx2	9.255	28324.744	23.069090
SumSRAFastTraits	9.795	26762.964	21.797099

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	173.740	1508.831
SumSRA_Base_Basic	283.749	923.860	0.612302
SumSRA_Base	278.344	941.800	0.624192
SumSRA_Base_Core	280.703	933.884	0.618945
SumSRA_Avx2	20.821	12590.418	8.344486
SumSRATraits	20.319	12901.507	8.550665
SumSRATraits_Core	16.428	15956.786	10.575596
SumSRAConstTraits	19.490	13450.043	8.914215
SumSRAConstTraits_Core	17.084	15344.136	10.169553
SumSRA128Traits	36.191	7243.292	4.800599
SumSRA128Traits_Core	24.879	10536.832	6.983441
SumSRA128ConstTraits	36.491	7183.865	4.761212
SumSRA128ConstTraits_Core	25.996	10083.853	6.683223
SumSRAFast_Avx2	19.430	13491.549	8.941724
SumSRAFastTraits	19.760	13266.168	8.792349

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	171.032	1532.719
SumSRA_Base_Basic	497.223	527.217	0.343975
SumSRA_Base	505.510	518.574	0.338336
SumSRA_Base_Create	552.778	474.230	0.309405
SumSRA_Base_LoadArray	555.430	471.966	0.307927
SumSRA_Base_Core	495.865	528.659	0.344916
SumSRA_Avx2	56.281	4657.784	3.038903
SumSRATraits	52.966	4949.328	3.229116
SumSRATraits_Core	44.120	5941.547	3.876475
SumSRAConstTraits	47.431	5526.893	3.605940
SumSRAConstTraits_Core	44.433	5899.752	3.849207
SumSRA128Traits	107.958	2428.206	1.584248
SumSRA128Traits_Core	86.094	3044.874	1.986583
SumSRA128ConstTraits	95.564	2743.132	1.789716
SumSRA128ConstTraits_Core	88.217	2971.569	1.938756
SumSRAFast_Avx2	49.923	5251.002	3.425939
SumSRAFast_Avx2_Negative	62.480	4195.656	2.737394
SumSRAFastTraits	50.590	5181.733	3.380746

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	205.113	1278.049
SumSRA_Base128_Basic	401.474	652.953	0.510899
SumSRA_Base128_Basic_Ref	404.372	648.274	0.507237
SumSRA_Base_Basic	165.542	1583.545	1.239034
SumSRA_Base	70.693	3708.194	2.901450
SumSRA_Base_Core	68.102	3849.300	3.011857
SumSRA_Avx2	10.810	24251.103	18.975103
SumSRATraits	10.619	24686.302	19.315622
SumSRATraits_Core	6.254	41915.608	32.796570
SumSRAConstTraits	8.791	29819.076	23.331725
SumSRAConstTraits_Core	6.622	39588.701	30.975898
SumSRA128Traits	21.718	12070.160	9.444211
SumSRA128Traits_Core	11.413	22968.835	17.971802
SumSRA128ConstTraits	17.831	14701.493	11.503079
SumSRA128ConstTraits_Core	11.077	23666.644	18.517797
SumSRAFast_Avx2	9.380	27946.119	21.866242
SumSRAFastTraits	9.014	29081.934	22.754952

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	215.627	1215.729
SumSRA_Base_Basic	216.816	1209.061	0.994516
SumSRA_Base	145.544	1801.136	1.481528
SumSRA_Base_Core	140.053	1871.746	1.539609
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	10.318	25406.210	20.897930
SumSRATraits	9.861	26584.675	21.867278
SumSRATraits_Core	7.091	36967.972	30.408081
SumSRAConstTraits	7.088	36985.528	30.422522
SumSRAConstTraits_Core	6.991	37498.165	30.844192
SumSRA128Traits	20.249	12946.272	10.648983
SumSRA128Traits_Core	14.288	18346.905	15.091284
SumSRA128ConstTraits	14.804	17707.356	14.565222
SumSRA128ConstTraits_Core	22.651	11573.021	9.519412
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	7.028	37302.489	30.683239
SumSRAFastTraits	6.968	37622.502	30.946466

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	173.792	1508.378
SumSRA_Base_Basic	296.228	884.939	0.586682
SumSRA_Base	294.044	891.514	0.591041
SumSRA_Base_Core	270.124	970.457	0.643377
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	19.854	13203.383	8.753363
SumSRATraits	20.957	12508.762	8.292855
SumSRATraits_Core	17.187	15252.829	10.112071
SumSRAConstTraits	15.140	17314.816	11.479094
SumSRAConstTraits_Core	16.945	15470.629	10.256465
SumSRA128Traits	39.275	6674.533	4.424973
SumSRA128Traits_Core	26.207	10002.685	6.631417
SumSRA128ConstTraits	29.970	8746.806	5.798815
SumSRA128ConstTraits_Core	27.495	9534.407	6.320965
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	14.952	17531.887	11.623004
SumSRAFastTraits	17.092	15337.171	10.167987

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	169.749	1544.306
SumSRA_Base_Basic	515.962	508.068	0.328994
SumSRA_Base	525.082	499.244	0.323281
SumSRA_Base_Create	568.548	461.076	0.298565
SumSRA_Base_LoadArray	590.950	443.598	0.287247
SumSRA_Base_Core	519.843	504.275	0.326538
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	54.670	4795.006	3.104958
SumSRATraits	52.742	4970.328	3.218486
SumSRATraits_Core	43.327	6050.322	3.917825
SumSRAConstTraits	48.903	5360.460	3.471112
SumSRAConstTraits_Core	43.849	5978.398	3.871251
SumSRA128Traits	103.403	2535.175	1.641627
SumSRA128Traits_Core	81.320	3223.604	2.087413
SumSRA128ConstTraits	82.923	3161.288	2.047060
SumSRA128ConstTraits_Core	81.434	3219.111	2.084503
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	46.252	5667.734	3.670084
SumSRAFast_Avx2_Negative	62.749	4177.662	2.705203
SumSRAFastTraits	47.588	5508.612	3.567046

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	194.169	1350.082
SumSRA_Base128_Basic	400.268	654.921	0.485097
SumSRA_Base128_Basic_Ref	402.299	651.615	0.482649
SumSRA_Base_Basic	170.474	1537.738	1.138997
SumSRA_Base	72.969	3592.541	2.660981
SumSRA_Base_Core	71.490	3666.867	2.716034
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	11.159	23491.234	17.399863
SumSRATraits	11.444	22906.323	16.966622
SumSRATraits_Core	5.806	45147.925	33.440887
SumSRAConstTraits	6.239	42019.515	31.123686
SumSRAConstTraits_Core	5.650	46397.665	34.366565
SumSRA128Traits	21.714	12072.491	8.942046
SumSRA128Traits_Core	11.651	22500.556	16.666072
SumSRA128ConstTraits	12.219	21452.956	15.890119
SumSRA128ConstTraits_Core	11.125	23563.708	17.453544
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	6.860	38213.836	28.304835
SumSRAFastTraits	6.854	38244.798	28.327769

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	216.786	1209.230
SumSRA_Base_Basic	185.766	1411.152	1.166984
SumSRA_Base	139.776	1875.459	1.550953
SumSRA_Base_Core	137.903	1900.935	1.572021
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	9.812	26716.495	22.093801
SumSRATraits	9.842	26634.093	22.025657
SumSRATraits_Core	7.106	36890.508	30.507428
SumSRAConstTraits	6.649	39429.041	32.606724
SumSRAConstTraits_Core	6.875	38127.794	31.530629
SumSRA128Traits	19.197	13655.680	11.292869
SumSRA128Traits_Core	13.966	18769.553	15.521900
SumSRA128ConstTraits	13.233	19810.496	16.382731
SumSRA128ConstTraits_Core	12.981	20194.747	16.700496
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	8.521	30763.413	25.440490
SumSRAFastTraits	8.846	29634.362	24.506796

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	117.730	2226.648
SumSRA_Base_Basic	281.486	931.285	0.418245
SumSRA_Base	279.662	937.361	0.420974
SumSRA_Base_Core	277.112	945.985	0.424847
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	21.503	12191.144	5.475110
SumSRATraits	21.971	11931.480	5.358493
SumSRATraits_Core	15.055	17412.025	7.819836
SumSRAConstTraits	18.463	14198.095	6.376442
SumSRAConstTraits_Core	15.344	17084.816	7.672884
SumSRA128Traits	38.715	6771.110	3.040942
SumSRA128Traits_Core	26.287	9972.559	4.478731
SumSRA128ConstTraits	26.085	10049.468	4.513271
SumSRA128ConstTraits_Core	25.256	10379.314	4.661407
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	17.308	15145.777	6.802051
SumSRAFastTraits	18.002	14562.129	6.539932

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	173.233	1513.245
SumSRA_Base_Basic	494.853	529.741	0.350070
SumSRA_Base	497.084	527.364	0.348499
SumSRA_Base_Create	542.281	483.410	0.319452
SumSRA_Base_LoadArray	557.199	470.467	0.310900
SumSRA_Base_Core	495.150	529.423	0.349860
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	53.927	4861.131	3.212388
SumSRATraits	53.149	4932.277	3.259404
SumSRATraits_Core	42.943	6104.433	4.034002
SumSRAConstTraits	44.933	5834.075	3.855341
SumSRAConstTraits_Core	43.331	6049.756	3.997869
SumSRA128Traits	109.486	2394.306	1.582233
SumSRA128Traits_Core	84.841	3089.825	2.041854
SumSRA128ConstTraits	85.016	3083.453	2.037643
SumSRA128ConstTraits_Core	81.101	3232.302	2.136007
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	47.754	5489.498	3.627634
SumSRAFast_Avx2_Negative	62.207	4214.082	2.784798
SumSRAFastTraits	46.943	5584.326	3.690298

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	213.509	1227.788
SumSRA_Base128_Basic	412.395	635.663	0.517730
SumSRA_Base128_Basic_Ref	401.426	653.032	0.531876
SumSRA_Base_Basic	164.339	1595.144	1.299202
SumSRA_Base	70.367	3725.407	3.034243
SumSRA_Base_Core	68.469	3828.668	3.118346
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	10.616	24692.332	20.111235
SumSRATraits	11.683	22437.129	18.274434
SumSRATraits_Core	5.777	45375.300	36.956952
SumSRAConstTraits	6.083	43095.169	35.099847
SumSRAConstTraits_Core	5.518	47507.648	38.693691
SumSRA128Traits	21.733	12061.983	9.824158
SumSRA128Traits_Core	11.478	22838.586	18.601409
SumSRA128ConstTraits	11.713	22380.417	18.228243
SumSRA128ConstTraits_Core	10.891	24068.925	19.603487
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	6.030	43469.741	35.404926
SumSRAFastTraits	6.014	43587.765	35.501053

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	200.011	1310.645
SumSRANetBcl	8.221	31888.645	24.330493
SumSRANetBcl_Const	6.595	39751.018	30.329350
SumSRA_Base_Basic	200.003	1310.703	1.000044
SumSRA_Base	8.144	32188.817	24.559520
SumSRA_Base_Core	8.116	32301.475	24.645476
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	9.716	26979.579	20.584959
SumSRATraits	8.301	31578.602	24.093936
SumSRATraits_Core	6.963	37648.798	28.725392
SumSRAConstTraits	7.962	32925.588	25.121663
SumSRAConstTraits_Core	7.915	33120.549	25.270415
SumSRA128Bcl	17.144	15290.670	11.666521
SumSRA128Traits	17.277	15172.862	11.576635
SumSRA128Traits_Core	13.787	19013.720	14.507144
SumSRA128ConstTraits	13.456	19481.084	14.863735
SumSRA128ConstTraits_Core	12.475	21013.970	16.033302
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	8.180	32047.925	24.452021
SumSRAFastTraits	8.250	31775.802	24.244396

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	102.575	2555.622
SumSRANetBcl	15.597	16806.958	6.576465
SumSRANetBcl_Const	14.273	18365.861	7.186454
SumSRA_Base_Basic	290.164	903.434	0.353509
SumSRA_Base	15.195	17251.976	6.750598
SumSRA_Base_Core	14.896	17598.842	6.886325
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	20.218	12965.935	5.073495
SumSRATraits	14.887	17609.103	6.890340
SumSRATraits_Core	14.328	18296.493	7.159311
SumSRAConstTraits	15.604	16799.445	6.573525
SumSRAConstTraits_Core	14.345	18274.411	7.150671
SumSRA128Bcl	28.960	9052.085	3.542028
SumSRA128Traits	28.880	9076.860	3.551723
SumSRA128Traits_Core	26.630	9843.782	3.851815
SumSRA128ConstTraits	25.876	10130.878	3.964153
SumSRA128ConstTraits_Core	26.451	9910.714	3.878005
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	17.339	15119.132	5.916028
SumSRAFastTraits	15.417	17003.224	6.653263

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	145.485	1801.859
SumSRANetBcl	499.605	524.702	0.291201
SumSRANetBcl_Const	470.507	557.152	0.309210
SumSRA_Base_Basic	510.119	513.888	0.285199
SumSRA_Base	95.333	2749.760	1.526068
SumSRA_Base_Create	51.637	5076.663	2.817458
SumSRA_Base_LoadArray	67.239	3898.667	2.163691
SumSRA_Base_Core	49.390	5307.651	2.945653
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	52.575	4986.076	2.767184
SumSRATraits	53.474	4902.239	2.720656
SumSRATraits_Core	43.377	6043.337	3.353945
SumSRAConstTraits	42.162	6217.509	3.450608
SumSRAConstTraits_Core	42.479	6171.211	3.424913
SumSRA128Bcl	908.227	288.633	0.160186
SumSRA128Traits	105.552	2483.545	1.378324
SumSRA128Traits_Core	85.031	3082.909	1.710960
SumSRA128ConstTraits	82.750	3167.907	1.758133
SumSRA128ConstTraits_Core	80.554	3254.245	1.806048
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	47.279	5544.666	3.077192
SumSRAFast_Avx2_Negative	62.944	4164.737	2.311355
SumSRAFastTraits	47.122	5563.034	3.087386

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	197.341	1328.380
SumSRANetBcl	230.928	1135.177	0.854558
SumSRANetBcl_Const	224.866	1165.780	0.877595
SumSRA_Base128_Basic	154.630	1695.300	1.276216
SumSRA_Base128_Basic_Ref	154.656	1695.019	1.276004
SumSRA_Base_Basic	208.580	1256.804	0.946118
SumSRA_Base	11.008	23814.764	17.927674
SumSRA_Base_Core	7.303	35894.626	27.021353
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	10.668	24571.923	18.497660
SumSRATraits	10.536	24879.962	18.729551
SumSRATraits_Core	5.602	46792.941	35.225567
SumSRAConstTraits	5.951	44048.300	33.159411
SumSRAConstTraits_Core	6.090	43046.477	32.405242
SumSRA128Bcl	251.109	1043.943	0.785877
SumSRA128Traits	20.961	12506.472	9.414830
SumSRA128Traits_Core	11.576	22644.602	17.046779
SumSRA128ConstTraits	12.376	21181.968	15.945713
SumSRA128ConstTraits_Core	12.002	21841.167	16.441957
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	5.951	44051.647	33.161930
SumSRAFastTraits	6.218	42159.940	31.737860

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	187.597	1397.378
SumSRANetBcl	7.468	35102.079	25.119964
SumSRANetBcl_Const	7.156	36630.458	26.213712
SumSRA_Base_Basic	182.235	1438.491	1.029422
SumSRA_Base	7.238	36216.246	25.917291
SumSRA_Base_Core	6.838	38334.086	27.432872
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	8.952	29283.585	20.956098
SumSRATraits	7.050	37184.123	26.609929
SumSRATraits_Core	6.958	37673.670	26.960261
SumSRAConstTraits	7.017	37356.009	26.732935
SumSRAConstTraits_Core	7.332	35752.947	25.585742
SumSRA128Bcl	13.241	19798.076	14.168020
SumSRA128Traits	14.108	18581.013	13.297057
SumSRA128Traits_Core	14.179	18487.834	13.230377
SumSRA128ConstTraits	13.439	19506.422	13.959305
SumSRA128ConstTraits_Core	13.055	20080.689	14.370265
SumSRA512Bcl	6.216	42170.686	30.178443
SumSRA512Traits	5.901	44425.480	31.792033
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	7.512	34898.627	24.974368
SumSRAFastTraits	7.154	36644.749	26.223938

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	112.624	2327.611
SumSRANetBcl	16.417	15967.982	6.860244
SumSRANetBcl_Const	16.290	16092.208	6.913615
SumSRA_Base_Basic	284.843	920.310	0.395388
SumSRA_Base	16.450	15935.557	6.846314
SumSRA_Base_Core	16.107	16275.317	6.992283
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	19.327	13563.944	5.827410
SumSRATraits	16.100	16282.512	6.995374
SumSRATraits_Core	16.152	16230.128	6.972869
SumSRAConstTraits	15.991	16393.351	7.042994
SumSRAConstTraits_Core	16.329	16054.229	6.897298
SumSRA128Bcl	26.606	9852.790	4.233005
SumSRA128Traits	27.453	9548.746	4.102380
SumSRA128Traits_Core	28.483	9203.490	3.954049
SumSRA128ConstTraits	26.994	9711.089	4.172127
SumSRA128ConstTraits_Core	26.665	9831.192	4.223726
SumSRA512Bcl	13.901	18857.829	8.101795
SumSRA512Traits	15.066	17399.575	7.475292
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	16.398	15986.324	6.868124
SumSRAFastTraits	16.258	16124.004	6.927275

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	102.389	2560.284
SumSRANetBcl	30.297	8652.579	3.379539
SumSRANetBcl_Const	29.553	8870.207	3.464540
SumSRA_Base_Basic	530.012	494.601	0.193182
SumSRA_Base	47.076	5568.470	2.174942
SumSRA_Base_Create	44.176	5934.061	2.317735
SumSRA_Base_LoadArray	47.959	5466.013	2.134924
SumSRA_Base_Core	44.238	5925.816	2.314515
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	37.893	6918.084	2.702077
SumSRATraits	34.759	7541.726	2.945660
SumSRATraits_Core	30.706	8537.297	3.334512
SumSRAConstTraits	34.666	7562.071	2.953606
SumSRAConstTraits_Core	33.952	7720.979	3.015673
SumSRA128Bcl	53.722	4879.641	1.905898
SumSRA128Traits	58.737	4462.980	1.743158
SumSRA128Traits_Core	53.822	4870.602	1.902368
SumSRA128ConstTraits	50.654	5175.151	2.021319
SumSRA128ConstTraits_Core	52.339	5008.581	1.956260
SumSRA512Bcl	28.390	9233.596	3.606473
SumSRA512Traits	31.948	8205.341	3.204856
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	30.597	8567.774	3.346415
SumSRAFast_Avx2_Negative	52.359	5006.686	1.955520
SumSRAFastTraits	34.129	7681.020	3.000066

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	188.866	1387.993
SumSRANetBcl	235.330	1113.944	0.802558
SumSRANetBcl_Const	247.045	1061.118	0.764498
SumSRA_Base128_Basic	157.112	1668.513	1.202105
SumSRA_Base128_Basic_Ref	159.078	1647.898	1.187252
SumSRA_Base_Basic	150.502	1741.799	1.254905
SumSRA_Base	10.580	24778.021	17.851692
SumSRA_Base_Core	5.376	48758.335	35.128664
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	6.067	43210.970	31.131983
SumSRATraits	5.927	44225.353	31.862811
SumSRATraits_Core	5.743	45642.076	32.883510
SumSRAConstTraits	5.567	47091.982	33.928116
SumSRAConstTraits_Core	5.592	46878.753	33.774492
SumSRA128Bcl	342.066	766.356	0.552133
SumSRA128Traits	11.032	23761.139	17.119065
SumSRA128Traits_Core	11.253	23295.247	16.783406
SumSRA128ConstTraits	10.916	24014.578	17.301659
SumSRA128ConstTraits_Core	10.847	24168.272	17.412389
SumSRA512Bcl	591.365	443.286	0.319372
SumSRA512Traits	4.638	56521.423	40.721696
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	5.571	47051.119	33.898676
SumSRAFastTraits	5.600	46807.560	33.723200

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	312.021	840.149
SumSRA_Base_Basic	251.582	1041.984	1.240237
SumSRA_Base	165.928	1579.861	1.880454
SumSRA_Base_Core	152.280	1721.463	2.048997
SumSRATraits	165.487	1584.078	1.885473
SumSRATraits_Core	156.232	1677.911	1.997160
SumSRAConstTraits	154.529	1696.402	2.019168
SumSRAConstTraits_Core	150.463	1742.252	2.073743
SumSRAFastTraits	158.045	1658.668	1.974255

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	312.900	837.789
SumSRA_Base_Basic	484.961	540.547	0.645206
SumSRA_Base	339.992	771.030	0.920315
SumSRA_Base_Core	309.671	846.524	1.010426
SumSRATraits	340.161	770.647	0.919858
SumSRATraits_Core	312.207	839.648	1.002219
SumSRAConstTraits	309.677	846.509	1.010408
SumSRAConstTraits_Core	301.021	870.848	1.039460
SumSRAFastTraits	317.621	825.336	0.985135

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	313.425	836.385
SumSRA_Base_Basic	579.685	452.218	0.540682
SumSRA_Base	602.405	435.162	0.520289
SumSRA_Base_Create	619.390	423.229	0.506022
SumSRA_Base_LoadArray	614.533	426.574	0.510022
SumSRA_Base_Core	580.518	451.569	0.539906
SumSRATraits	603.368	434.468	0.519460
SumSRATraits_Core	560.588	467.624	0.559101
SumSRAConstTraits	523.349	500.897	0.598884
SumSRAConstTraits_Core	522.591	501.624	0.599752
SumSRAFastTraits	538.627	486.690	0.581897

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	310.218	845.031
SumSRA_Base_Basic	283.422	924.925	1.094545
SumSRA_Base	83.041	3156.803	3.735724
SumSRA_Base_Core	76.431	3429.808	4.058795
SumSRATraits	83.134	3153.252	3.731522
SumSRATraits_Core	78.107	3356.234	3.971728
SumSRAConstTraits	77.424	3385.809	4.006727
SumSRAConstTraits_Core	75.384	3477.428	4.115148
SumSRAFastTraits	79.255	3307.606	3.914183

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	310.878	843.238
SumSRA_Base_Basic	250.333	1047.181	1.241856
SumSRA_Base	160.040	1637.991	1.942501
SumSRA_Base_Core	148.406	1766.398	2.094779
SumSRATraits	160.307	1635.261	1.939263
SumSRATraits_Core	150.583	1740.862	2.064496
SumSRAConstTraits	143.846	1822.398	2.161189
SumSRAConstTraits_Core	140.671	1863.526	2.209964
SumSRAFastTraits	153.866	1703.712	2.020440

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	312.659	838.434
SumSRA_Base_Basic	485.271	540.201	0.644297
SumSRA_Base	327.625	800.133	0.954318
SumSRA_Base_Core	296.488	884.163	1.054540
SumSRATraits	328.421	798.196	0.952008
SumSRATraits_Core	301.098	870.626	1.038395
SumSRAConstTraits	287.617	911.435	1.087068
SumSRAConstTraits_Core	281.586	930.956	1.110351
SumSRAFastTraits	307.920	851.338	1.015391

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	313.839	835.282
SumSRA_Base_Basic	583.471	449.284	0.537883
SumSRA_Base	556.366	471.172	0.564087
SumSRA_Base_Create	598.958	437.667	0.523975
SumSRA_Base_LoadArray	618.362	423.933	0.507533
SumSRA_Base_Core	583.218	449.479	0.538116
SumSRATraits	555.950	471.525	0.564509
SumSRATraits_Core	541.780	483.857	0.579274
SumSRAConstTraits	477.523	548.966	0.657222
SumSRAConstTraits_Core	477.849	548.592	0.656774
SumSRAFastTraits	520.488	503.650	0.602970

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	310.195	845.094
SumSRA_Base_Basic	225.603	1161.971	1.374961
SumSRA_Base	80.149	3270.693	3.870211
SumSRA_Base_Core	74.281	3529.103	4.175987
SumSRATraits	80.389	3260.950	3.858682
SumSRATraits_Core	75.543	3470.118	4.106190
SumSRAConstTraits	71.990	3641.392	4.308859
SumSRAConstTraits_Core	70.388	3724.250	4.406905
SumSRAFastTraits	75.633	3465.987	4.101302

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	219.721	1193.076
SumSRA_Base_Basic	270.808	968.008	0.811355
SumSRA_Base	162.579	1612.411	1.351474
SumSRA_Base_Core	153.400	1708.891	1.432341
SumSRA_Avx2	14.636	17911.182	15.012612
SumSRATraits	14.529	18042.836	15.122961
SumSRATraits_Core	12.649	20725.141	17.371188
SumSRAConstTraits	14.433	18163.434	15.224042
SumSRAConstTraits_Core	11.941	21952.651	18.400049
SumSRA128Traits	25.343	10343.697	8.669775
SumSRA128Traits_Core	22.464	11669.697	9.781188
SumSRA128ConstTraits	25.631	10227.651	8.572508
SumSRA128ConstTraits_Core	22.358	11725.080	9.827609
SumSRAFast_Avx2	12.993	20175.655	16.910626
SumSRAFastTraits	13.053	20083.459	16.833350

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	193.756	1352.958
SumSRA_Base_Basic	484.380	541.195	0.400008
SumSRA_Base	329.553	795.454	0.587937
SumSRA_Base_Core	306.761	854.554	0.631619
SumSRA_Avx2	29.044	9025.787	6.671153
SumSRATraits	28.561	9178.232	6.783828
SumSRATraits_Core	22.299	11755.884	8.689026
SumSRAConstTraits	28.131	9318.611	6.887585
SumSRAConstTraits_Core	24.735	10597.903	7.833137
SumSRA128Traits	50.624	5178.258	3.827362
SumSRA128Traits_Core	42.758	6130.943	4.531512
SumSRA128ConstTraits	50.615	5179.182	3.828045
SumSRA128ConstTraits_Core	42.823	6121.559	4.524576
SumSRAFast_Avx2	26.468	9904.295	7.320476
SumSRAFastTraits	27.463	9545.249	7.055098

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	194.128	1350.369
SumSRA_Base_Basic	536.557	488.567	0.361802
SumSRA_Base	536.212	488.881	0.362036
SumSRA_Base_Create	617.258	424.691	0.314500
SumSRA_Base_LoadArray	641.256	408.798	0.302731
SumSRA_Base_Core	536.545	488.578	0.361811
SumSRA_Avx2	81.423	3219.514	2.384174
SumSRATraits	82.314	3184.687	2.358383
SumSRATraits_Core	68.124	3848.049	2.849628
SumSRAConstTraits	81.292	3224.715	2.388025
SumSRAConstTraits_Core	68.017	3854.123	2.854126
SumSRA128Traits	138.548	1892.076	1.401155
SumSRA128Traits_Core	115.925	2261.331	1.674603
SumSRA128ConstTraits	136.751	1916.937	1.419566
SumSRA128ConstTraits_Core	116.296	2254.113	1.669257
SumSRAFast_Avx2	78.162	3353.874	2.483673
SumSRAFast_Avx2_Negative	100.177	2616.804	1.937844
SumSRAFastTraits	78.108	3356.166	2.485370

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	234.081	1119.888
SumSRA_Base128_Basic	398.216	658.295	0.587823
SumSRA_Base128_Basic_Ref	397.975	658.694	0.588179
SumSRA_Base_Basic	221.834	1181.715	1.055208
SumSRA_Base	81.421	3219.602	2.874933
SumSRA_Base_Core	76.660	3419.576	3.053499
SumSRA_Avx2	14.166	18504.842	16.523838
SumSRATraits	14.258	18386.183	16.417882
SumSRATraits_Core	8.376	31296.211	27.945849
SumSRAConstTraits	11.837	22145.325	19.774596
SumSRAConstTraits_Core	8.322	31498.676	28.126640
SumSRA128Traits	29.231	8968.038	8.007980
SumSRA128Traits_Core	14.825	17683.142	15.790104
SumSRA128ConstTraits	20.902	12541.420	11.198820
SumSRA128ConstTraits_Core	14.871	17627.373	15.740305
SumSRAFast_Avx2	10.716	24462.338	21.843565
SumSRAFastTraits	10.794	24286.313	21.686384

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	218.569	1199.367
SumSRA_Base_Basic	265.109	988.818	0.824450
SumSRA_Base	163.681	1601.558	1.335337
SumSRA_Base_Core	153.138	1711.819	1.427269
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.294	18339.131	15.290681
SumSRATraits	14.400	18204.327	15.178286
SumSRATraits_Core	13.036	20109.157	16.766482
SumSRAConstTraits	13.530	19374.320	16.153794
SumSRAConstTraits_Core	13.500	19418.466	16.190602
SumSRA128Traits	25.630	10228.038	8.527867
SumSRA128Traits_Core	22.423	11690.713	9.747407
SumSRA128ConstTraits	22.506	11647.592	9.711454
SumSRA128ConstTraits_Core	22.506	11647.923	9.711729
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	11.887	22053.164	18.387344
SumSRAFastTraits	12.578	20841.444	17.377044

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	193.827	1352.467
SumSRA_Base_Basic	496.259	528.241	0.390576
SumSRA_Base	320.071	819.018	0.605573
SumSRA_Base_Core	315.814	830.059	0.613737
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	28.531	9188.153	6.793624
SumSRATraits	28.382	9236.354	6.829263
SumSRATraits_Core	22.373	11716.871	8.663331
SumSRAConstTraits	23.785	11021.465	8.149156
SumSRAConstTraits_Core	23.309	11246.438	8.315498
SumSRA128Traits	51.028	5137.243	3.798424
SumSRA128Traits_Core	42.896	6111.172	4.518536
SumSRA128ConstTraits	44.871	5842.198	4.319660
SumSRA128ConstTraits_Core	39.714	6600.870	4.880614
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	24.713	10607.503	7.843077
SumSRAFastTraits	25.064	10458.977	7.733258

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	195.309	1342.203
SumSRA_Base_Basic	559.281	468.716	0.349214
SumSRA_Base	571.912	458.364	0.341501
SumSRA_Base_Create	618.029	424.161	0.316019
SumSRA_Base_LoadArray	638.466	410.584	0.305903
SumSRA_Base_Core	559.703	468.363	0.348951
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	81.586	3213.113	2.393910
SumSRATraits	81.247	3226.498	2.403882
SumSRATraits_Core	68.001	3855.016	2.872156
SumSRAConstTraits	81.020	3235.547	2.410624
SumSRAConstTraits_Core	68.003	3854.902	2.872071
SumSRA128Traits	138.306	1895.394	1.412152
SumSRA128Traits_Core	115.121	2277.126	1.696558
SumSRA128ConstTraits	119.908	2186.209	1.628822
SumSRA128ConstTraits_Core	114.508	2289.301	1.705630
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	78.653	3332.934	2.483182
SumSRAFast_Avx2_Negative	100.044	2620.282	1.952225
SumSRAFastTraits	78.224	3351.205	2.496794

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	232.676	1126.648
SumSRA_Base128_Basic	397.719	659.118	0.585026
SumSRA_Base128_Basic_Ref	398.125	658.447	0.584430
SumSRA_Base_Basic	234.819	1116.367	0.990875
SumSRA_Base	82.506	3177.271	2.820110
SumSRA_Base_Core	76.438	3429.507	3.043993
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.151	18524.654	16.442278
SumSRATraits	14.142	18536.103	16.452439
SumSRATraits_Core	8.359	31360.721	27.835428
SumSRAConstTraits	9.222	28425.517	25.230174
SumSRAConstTraits_Core	8.327	31479.345	27.940717
SumSRA128Traits	29.283	8952.113	7.945796
SumSRA128Traits_Core	14.793	17720.560	15.728573
SumSRA128ConstTraits	16.381	16002.988	14.204075
SumSRA128ConstTraits_Core	14.901	17592.686	15.615073
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	9.794	26765.635	23.756881
SumSRAFastTraits	9.892	26500.990	23.521985

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	186.800	1403.341
SumSRA_Base_Basic	271.253	966.420	0.688656
SumSRA_Base	162.871	1609.517	1.146918
SumSRA_Base_Core	155.412	1686.769	1.201967
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.651	17892.176	12.749702
SumSRATraits	14.476	18109.365	12.904468
SumSRATraits_Core	11.946	21944.186	15.637105
SumSRAConstTraits	12.303	21308.042	15.183798
SumSRAConstTraits_Core	11.901	22027.138	15.696215
SumSRA128Traits	25.415	10314.569	7.350011
SumSRA128Traits_Core	22.441	11681.519	8.324079
SumSRA128ConstTraits	21.521	12181.129	8.680094
SumSRA128ConstTraits_Core	20.393	12854.584	9.159988
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	12.946	20249.540	14.429525
SumSRAFastTraits	12.916	20296.236	14.462800

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	158.384	1655.116
SumSRA_Base_Basic	495.316	529.246	0.319764
SumSRA_Base	327.359	800.784	0.483824
SumSRA_Base_Core	923.338	283.909	0.171534
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	28.223	9288.160	5.611788
SumSRATraits	29.536	8875.456	5.362437
SumSRATraits_Core	23.304	11248.856	6.796415
SumSRAConstTraits	23.333	11235.045	6.788070
SumSRAConstTraits_Core	23.403	11201.392	6.767738
SumSRA128Traits	50.663	5174.259	3.126221
SumSRA128Traits_Core	40.318	6501.870	3.928346
SumSRA128ConstTraits	42.885	6112.789	3.693269
SumSRA128ConstTraits_Core	42.829	6120.695	3.698046
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	27.216	9632.066	5.819571
SumSRAFastTraits	27.111	9669.190	5.842001

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	193.925	1351.779
SumSRA_Base_Basic	553.467	473.640	0.350382
SumSRA_Base	554.419	472.826	0.349781
SumSRA_Base_Create	618.040	424.154	0.313774
SumSRA_Base_LoadArray	639.909	409.658	0.303051
SumSRA_Base_Core	537.137	488.039	0.361035
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	81.531	3215.280	2.378554
SumSRATraits	81.461	3218.040	2.380596
SumSRATraits_Core	67.935	3858.747	2.854569
SumSRAConstTraits	67.966	3857.005	2.853281
SumSRAConstTraits_Core	68.147	3846.748	2.845693
SumSRA128Traits	138.438	1893.580	1.400806
SumSRA128Traits_Core	119.032	2202.295	1.629182
SumSRA128ConstTraits	114.131	2296.869	1.699145
SumSRA128ConstTraits_Core	113.888	2301.770	1.702771
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	78.644	3333.292	2.465855
SumSRAFast_Avx2_Negative	99.978	2622.024	1.939683
SumSRAFastTraits	78.184	3352.930	2.480383

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	186.662	1404.378
SumSRA_Base128_Basic	398.459	657.895	0.468460
SumSRA_Base128_Basic_Ref	397.897	658.824	0.469122
SumSRA_Base_Basic	233.308	1123.595	0.800066
SumSRA_Base	81.600	3212.566	2.287537
SumSRA_Base_Core	77.708	3373.462	2.402104
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.210	18447.697	13.135848
SumSRATraits	14.152	18522.999	13.189467
SumSRATraits_Core	8.368	31328.676	22.307864
SumSRAConstTraits	8.501	30836.577	21.957461
SumSRAConstTraits_Core	8.336	31447.480	22.392459
SumSRA128Traits	28.146	9313.649	6.631867
SumSRA128Traits_Core	14.924	17564.807	12.507178
SumSRA128ConstTraits	15.028	17443.902	12.421087
SumSRA128ConstTraits_Core	14.914	17577.020	12.515874
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	8.734	30013.622	21.371468
SumSRAFastTraits	8.885	29505.447	21.009617

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	160.453	1633.772
SumSRANetBcl	12.414	21116.651	12.925089
SumSRANetBcl_Const	11.491	22813.874	13.963927
SumSRA_Base_Basic	216.121	1212.951	0.742424
SumSRA_Base	12.492	20984.369	12.844122
SumSRA_Base_Core	13.294	19718.622	12.069383
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.731	17795.119	10.892045
SumSRATraits	14.032	18681.471	11.434563
SumSRATraits_Core	13.384	19586.359	11.988428
SumSRAConstTraits	12.859	20385.321	12.477457
SumSRAConstTraits_Core	12.658	20710.309	12.676375
SumSRA128Traits	21.843	12001.044	7.345605
SumSRA128Traits_Core	21.043	12457.610	7.625060
SumSRA128ConstTraits	20.008	13101.970	8.019460
SumSRA128ConstTraits_Core	20.140	13015.871	7.966761
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	12.742	20573.984	12.592934
SumSRAFastTraits	13.216	19834.879	12.140542

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	155.334	1687.610
SumSRANetBcl	23.413	11196.449	6.634499
SumSRANetBcl_Const	22.249	11782.312	6.981654
SumSRA_Base_Basic	495.946	528.573	0.313208
SumSRA_Base	23.426	11190.487	6.630965
SumSRA_Base_Core	24.384	10750.685	6.370360
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	27.948	9379.651	5.557948
SumSRATraits	24.430	10730.525	6.358413
SumSRATraits_Core	23.716	11053.369	6.549716
SumSRAConstTraits	23.042	11376.847	6.741394
SumSRAConstTraits_Core	25.128	10432.148	6.181609
SumSRA128Traits	42.086	6228.702	3.690841
SumSRA128Traits_Core	39.997	6554.065	3.883636
SumSRA128ConstTraits	40.620	6453.534	3.824066
SumSRA128ConstTraits_Core	40.174	6525.161	3.866509
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	24.335	10772.310	6.383173
SumSRAFastTraits	24.374	10755.118	6.372986

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	155.696	1683.693
SumSRANetBcl	444.102	590.279	0.350586
SumSRANetBcl_Const	464.104	564.839	0.335476
SumSRA_Base_Basic	534.033	490.876	0.291548
SumSRA_Base	114.581	2287.847	1.358827
SumSRA_Base_Create	84.337	3108.309	1.846126
SumSRA_Base_LoadArray	88.637	2957.485	1.756547
SumSRA_Base_Core	83.632	3134.477	1.861668
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	82.026	3195.879	1.898136
SumSRATraits	81.721	3207.783	1.905207
SumSRATraits_Core	70.252	3731.461	2.216236
SumSRAConstTraits	70.159	3736.409	2.219175
SumSRAConstTraits_Core	74.358	3525.451	2.093880
SumSRA128Traits	137.631	1904.689	1.131257
SumSRA128Traits_Core	117.789	2225.535	1.321818
SumSRA128ConstTraits	107.120	2447.205	1.453475
SumSRA128ConstTraits_Core	106.503	2461.380	1.461894
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	78.416	3342.997	1.985515
SumSRAFast_Avx2_Negative	100.010	2621.174	1.556800
SumSRAFastTraits	78.266	3349.395	1.989315

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	161.407	1624.119
SumSRANetBcl	222.154	1180.012	0.726555
SumSRANetBcl_Const	222.707	1177.082	0.724751
SumSRA_Base128_Basic	167.826	1562.003	0.961754
SumSRA_Base128_Basic_Ref	167.714	1563.038	0.962392
SumSRA_Base_Basic	203.477	1288.323	0.793244
SumSRA_Base	12.947	20247.087	12.466506
SumSRA_Base_Core	9.612	27273.709	16.792928
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	12.325	21268.607	13.095475
SumSRATraits	12.359	21210.612	13.059767
SumSRATraits_Core	7.983	32838.468	20.219253
SumSRAConstTraits	7.882	33258.277	20.477738
SumSRAConstTraits_Core	7.668	34186.649	21.049353
SumSRA128Traits	24.341	10769.494	6.630977
SumSRA128Traits_Core	14.044	18665.642	11.492781
SumSRA128ConstTraits	14.842	17662.646	10.875218
SumSRA128ConstTraits_Core	14.842	17661.984	10.874811
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	8.188	32016.128	19.712923
SumSRAFastTraits	8.247	31784.911	19.570558

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	158.000	1659.137
SumSRA_Base_Basic	115.613	2267.421	1.366627
SumSRA_Base	57.801	4535.267	2.733510
SumSRA_Base_Core	43.411	6038.671	3.639646
SumSRA_AdvSimd	19.302	13580.990	8.185576
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	19.300	13582.299	8.186365
SumSRATraits_Core	19.258	13612.198	8.204385
SumSRAConstTraits	19.256	13613.375	8.205095
SumSRAConstTraits_Core	19.258	13612.120	8.204338
SumSRA128Traits	19.302	13581.226	8.185718
SumSRA128Traits_Core	19.261	13610.432	8.203321
SumSRA128ConstTraits	19.260	13610.703	8.203484
SumSRA128ConstTraits_Core	19.259	13611.597	8.204023
SumSRAFast_AdvSimd	19.260	13610.536	8.203384
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	19.255	13614.024	8.205486

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	151.442	1730.990
SumSRA_Base_Basic	154.175	1700.297	0.982268
SumSRA_Base	96.423	2718.689	1.570598
SumSRA_Base_Core	86.828	3019.132	1.744165
SumSRA_AdvSimd	38.573	6796.078	3.926122
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	38.576	6795.528	3.925804
SumSRATraits_Core	38.530	6803.692	3.930520
SumSRAConstTraits	38.526	6804.269	3.930854
SumSRAConstTraits_Core	38.527	6804.194	3.930811
SumSRA128Traits	38.574	6795.811	3.925968
SumSRA128Traits_Core	38.529	6803.747	3.930552
SumSRA128ConstTraits	38.534	6802.983	3.930111
SumSRA128ConstTraits_Core	38.529	6803.748	3.930553
SumSRAFast_AdvSimd	38.530	6803.691	3.930520
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	38.530	6803.600	3.930467

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	152.325	1720.956
SumSRA_Base_Basic	159.520	1643.328	0.954892
SumSRA_Base	159.500	1643.537	0.955014
SumSRA_Base_Create	173.519	1510.754	0.877857
SumSRA_Base_LoadArray	231.223	1133.726	0.658777
SumSRA_Base_Core	159.644	1642.058	0.954155
SumSRA_AdvSimd	77.144	3398.127	1.974557
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	77.114	3399.435	1.975318
SumSRATraits_Core	77.070	3401.381	1.976448
SumSRAConstTraits	77.079	3400.988	1.976220
SumSRAConstTraits_Core	77.066	3401.544	1.976543
SumSRA128Traits	77.121	3399.137	1.975144
SumSRA128Traits_Core	77.068	3401.483	1.976507
SumSRA128ConstTraits	77.059	3401.854	1.976723
SumSRA128ConstTraits_Core	77.079	3400.970	1.976209
SumSRAFast_AdvSimd	77.068	3401.484	1.976508
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	77.069	3401.436	1.976480

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	155.297	1688.015
SumSRA_Base128_Basic	165.322	1585.657	0.939362
SumSRA_Base128_Basic_Ref	165.210	1586.735	0.940001
SumSRA_Base_Basic	91.294	2871.433	1.701071
SumSRA_Base	28.922	9063.885	5.369552
SumSRA_Base_Core	21.729	12064.226	7.146989
SumSRA_AdvSimd	9.675	27095.310	16.051579
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	9.673	27101.525	16.055261
SumSRATraits_Core	9.628	27226.168	16.129101
SumSRAConstTraits	9.630	27222.911	16.127171
SumSRAConstTraits_Core	9.628	27227.288	16.129765
SumSRA128Traits	9.671	27107.088	16.058557
SumSRA128Traits_Core	9.631	27218.950	16.124825
SumSRA128ConstTraits	9.628	27227.452	16.129862
SumSRA128ConstTraits_Core	9.628	27227.884	16.130118
SumSRAFast_AdvSimd	9.627	27229.755	16.131227
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	9.627	27230.463	16.131646

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	155.123	1689.909
SumSRANetBcl	19.253	13615.524	8.056957
SumSRANetBcl_Const	19.255	13614.666	8.056449
SumSRA_Base_Basic	105.992	2473.252	1.463541
SumSRA_Base	19.250	13617.769	8.058286
SumSRA_Base_Core	19.255	13614.098	8.056114
SumSRA_AdvSimd	19.309	13576.059	8.033604
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	19.254	13614.972	8.056631
SumSRATraits_Core	19.258	13611.891	8.054808
SumSRAConstTraits	19.256	13613.691	8.055873
SumSRAConstTraits_Core	19.258	13612.274	8.055034
SumSRA128Bcl	19.255	13614.631	8.056429
SumSRA128Traits	19.254	13615.019	8.056658
SumSRA128Traits_Core	19.258	13611.941	8.054837
SumSRA128ConstTraits	19.256	13613.382	8.055690
SumSRA128ConstTraits_Core	19.253	13615.745	8.057088
SumSRAFast_AdvSimd	19.292	13588.571	8.041008
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	19.258	13612.397	8.055107

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	113.983	2299.848
SumSRANetBcl	38.529	6803.779	2.958360
SumSRANetBcl_Const	38.522	6805.033	2.958905
SumSRA_Base_Basic	134.897	1943.291	0.844965
SumSRA_Base	38.523	6804.795	2.958802
SumSRA_Base_Core	38.526	6804.295	2.958585
SumSRA_AdvSimd	38.577	6795.258	2.954655
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	38.521	6805.255	2.959002
SumSRATraits_Core	38.518	6805.755	2.959219
SumSRAConstTraits	38.522	6805.055	2.958915
SumSRAConstTraits_Core	38.524	6804.617	2.958724
SumSRA128Bcl	38.525	6804.503	2.958675
SumSRA128Traits	38.524	6804.712	2.958766
SumSRA128Traits_Core	38.528	6803.936	2.958428
SumSRA128ConstTraits	38.524	6804.643	2.958736
SumSRA128ConstTraits_Core	38.528	6804.028	2.958469
SumSRAFast_AdvSimd	38.524	6804.744	2.958780
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	38.532	6803.336	2.958168

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	115.995	2259.968
SumSRANetBcl	77.110	3399.593	1.504266
SumSRANetBcl_Const	77.073	3401.234	1.504992
SumSRA_Base_Basic	154.252	1699.454	0.751981
SumSRA_Base	77.075	3401.140	1.504950
SumSRA_Base_Create	77.088	3400.571	1.504699
SumSRA_Base_LoadArray	77.087	3400.638	1.504728
SumSRA_Base_Core	77.072	3401.287	1.505016
SumSRA_AdvSimd	77.129	3398.780	1.503906
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	77.110	3399.631	1.504283
SumSRATraits_Core	77.069	3401.425	1.505077
SumSRAConstTraits	77.049	3402.320	1.505473
SumSRAConstTraits_Core	77.076	3401.128	1.504945
SumSRA128Bcl	77.085	3400.723	1.504766
SumSRA128Traits	77.117	3399.297	1.504135
SumSRA128Traits_Core	77.072	3401.274	1.505010
SumSRA128ConstTraits	77.083	3400.799	1.504799
SumSRA128ConstTraits_Core	77.070	3401.391	1.505061
SumSRAFast_AdvSimd	77.061	3401.781	1.505234
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	77.060	3401.803	1.505244

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	155.131	1689.821
SumSRANetBcl	9.627	27229.708	16.113956
SumSRANetBcl_Const	9.626	27233.426	16.116156
SumSRA_Base128_Basic	60.681	4320.039	2.556506
SumSRA_Base128_Basic_Ref	60.670	4320.794	2.556953
SumSRA_Base_Basic	91.554	2863.264	1.694418
SumSRA_Base	13.271	19752.906	11.689345
SumSRA_Base_Core	9.662	27130.494	16.055243
SumSRA_AdvSimd	9.675	27093.700	16.033469
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	9.672	27103.833	16.039466
SumSRATraits_Core	9.629	27224.639	16.110956
SumSRAConstTraits	9.632	27215.844	16.105751
SumSRAConstTraits_Core	9.624	27237.797	16.118743
SumSRA128Bcl	9.628	27227.664	16.112746
SumSRA128Traits	9.674	27097.551	16.035748
SumSRA128Traits_Core	9.629	27225.390	16.111401
SumSRA128ConstTraits	9.626	27233.391	16.116135
SumSRA128ConstTraits_Core	9.625	27236.661	16.118071
SumSRAFast_AdvSimd	9.626	27233.782	16.116367
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	9.627	27230.166	16.114227

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	224.859	1165.817
SumSRANetBcl	19.255	13614.299	11.677906
SumSRANetBcl_Const	19.251	13617.127	11.680332
SumSRA_Base_Basic	96.352	2720.678	2.333710
SumSRA_Base	19.248	13619.558	11.682418
SumSRA_Base_Core	19.251	13617.044	11.680262
SumSRA_AdvSimd	19.249	13618.256	11.681301
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	19.251	13617.444	11.680604
SumSRATraits_Core	19.251	13617.402	11.680568
SumSRAConstTraits	19.247	13620.016	11.682810
SumSRAConstTraits_Core	19.255	13614.072	11.677712
SumSRA128Bcl	19.255	13614.194	11.677816
SumSRA128Traits	19.256	13613.813	11.677489
SumSRA128Traits_Core	19.254	13615.329	11.678790
SumSRA128ConstTraits	19.252	13616.589	11.679871
SumSRA128ConstTraits_Core	19.255	13614.638	11.678197
SumSRA512Bcl	5.850	44812.445	38.438671
SumSRA512Traits	5.849	44818.797	38.444119
SumSRAFast_AdvSimd	19.253	13616.004	11.679369
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	19.255	13614.018	11.677666

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	150.230	1744.948
SumSRANetBcl	38.526	6804.410	3.899491
SumSRANetBcl_Const	38.517	6805.900	3.900345
SumSRA_Base_Basic	115.653	2266.651	1.298979
SumSRA_Base	38.515	6806.261	3.900552
SumSRA_Base_Core	38.525	6804.530	3.899560
SumSRA_AdvSimd	38.520	6805.488	3.900108
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	38.516	6806.184	3.900507
SumSRATraits_Core	38.527	6804.233	3.899389
SumSRAConstTraits	38.521	6805.264	3.899980
SumSRAConstTraits_Core	38.514	6806.379	3.900619
SumSRA128Bcl	38.517	6805.979	3.900390
SumSRA128Traits	38.514	6806.505	3.900692
SumSRA128Traits_Core	38.519	6805.613	3.900180
SumSRA128ConstTraits	38.524	6804.685	3.899648
SumSRA128ConstTraits_Core	38.512	6806.825	3.900875
SumSRA512Bcl	11.747	22315.025	12.788359
SumSRA512Traits	11.747	22316.239	12.789055
SumSRAFast_AdvSimd	38.520	6805.431	3.900076
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	38.519	6805.498	3.900114

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	154.210	1699.912
SumSRANetBcl	77.066	3401.548	2.001014
SumSRANetBcl_Const	77.058	3401.891	2.001216
SumSRA_Base_Basic	126.228	2076.742	1.221676
SumSRA_Base	77.065	3401.617	2.001054
SumSRA_Base_Create	77.060	3401.798	2.001161
SumSRA_Base_LoadArray	77.052	3402.171	2.001380
SumSRA_Base_Core	77.068	3401.469	2.000967
SumSRA_AdvSimd	77.065	3401.597	2.001042
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	77.062	3401.709	2.001108
SumSRATraits_Core	77.054	3402.096	2.001336
SumSRAConstTraits	77.063	3401.676	2.001089
SumSRAConstTraits_Core	77.069	3401.407	2.000931
SumSRA128Bcl	77.052	3402.177	2.001384
SumSRA128Traits	77.057	3401.931	2.001239
SumSRA128Traits_Core	77.068	3401.484	2.000976
SumSRA128ConstTraits	77.057	3401.942	2.001245
SumSRA128ConstTraits_Core	77.069	3401.434	2.000946
SumSRA512Bcl	22.906	11444.530	6.732423
SumSRA512Traits	22.906	11444.550	6.732435
SumSRAFast_AdvSimd	77.072	3401.283	2.000858
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	77.064	3401.641	2.001068

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	224.780	1166.226
SumSRANetBcl	9.625	27235.540	23.353577
SumSRANetBcl_Const	9.625	27236.305	23.354233
SumSRA_Base128_Basic	60.601	4325.723	3.709165
SumSRA_Base128_Basic_Ref	60.608	4325.268	3.708775
SumSRA_Base_Basic	86.871	3017.621	2.587510
SumSRA_Base	12.068	21722.368	18.626214
SumSRA_Base_Core	9.634	27211.362	23.332845
SumSRA_AdvSimd	9.620	27250.395	23.366315
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	9.620	27250.592	23.366484
SumSRATraits_Core	9.622	27245.065	23.361744
SumSRAConstTraits	9.622	27245.258	23.361910
SumSRAConstTraits_Core	9.623	27240.233	23.357601
SumSRA128Bcl	9.620	27249.601	23.365634
SumSRA128Traits	9.622	27242.876	23.359868
SumSRA128Traits_Core	9.625	27236.615	23.354499
SumSRA128ConstTraits	9.622	27244.497	23.361258
SumSRA128ConstTraits_Core	9.625	27236.870	23.354718
SumSRA512Bcl	2.926	89603.359	76.831925
SumSRA512Traits	2.925	89635.626	76.859593
SumSRAFast_AdvSimd	9.625	27235.843	23.353837
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	9.623	27240.443	23.357781

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	433.705	604.429
SumSRA_Base_Basic	491.343	533.525	0.882692
SumSRA_Base	159.041	1648.280	2.727002
SumSRA_Base_Core	135.772	1930.771	3.194369
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	152.959	1713.818	2.835431
SumSRATraits_Core	135.953	1928.197	3.190111
SumSRAConstTraits	135.401	1936.057	3.203115
SumSRAConstTraits_Core	138.313	1895.291	3.135669
SumSRA128Traits	875.967	299.263	0.495116
SumSRA128Traits_Core	876.744	298.997	0.494677
SumSRA128ConstTraits	901.422	290.812	0.481134
SumSRA128ConstTraits_Core	906.013	289.338	0.478696
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	136.225	1924.347	3.183741

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	351.736	745.287
SumSRA_Base_Basic	796.045	329.308	0.441854
SumSRA_Base	293.070	894.477	1.200178
SumSRA_Base_Core	271.380	965.968	1.296102
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	305.112	859.173	1.152808
SumSRATraits_Core	277.197	945.694	1.268899
SumSRAConstTraits	270.929	967.576	1.298260
SumSRAConstTraits_Core	276.536	947.955	1.271933
SumSRA128Traits	1405.705	186.486	0.250220
SumSRA128Traits_Core	1408.904	186.062	0.249652
SumSRA128ConstTraits	1415.967	185.134	0.248407
SumSRA128ConstTraits_Core	1408.869	186.067	0.249658
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	272.496	962.010	1.290791

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	354.775	738.902
SumSRA_Base_Basic	537.142	488.035	0.660486
SumSRA_Base	547.267	479.006	0.648267
SumSRA_Base_Create	1392.601	188.241	0.254757
SumSRA_Base_LoadArray	662.658	395.595	0.535382
SumSRA_Base_Core	1318.316	198.848	0.269112
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	560.330	467.838	0.633153
SumSRATraits_Core	559.575	468.470	0.634008
SumSRAConstTraits	561.118	467.182	0.632265
SumSRAConstTraits_Core	559.379	468.634	0.634230
SumSRA128Traits	971.921	269.718	0.365025
SumSRA128Traits_Core	967.667	270.903	0.366629
SumSRA128ConstTraits	984.126	266.372	0.360497
SumSRA128ConstTraits_Core	973.543	269.268	0.364416
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	562.231	466.256	0.631012

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	430.682	608.671
SumSRA_Base128_Basic	567.457	461.963	0.758969
SumSRA_Base128_Basic_Ref	570.522	459.481	0.754892
SumSRA_Base_Basic	358.024	732.196	1.202941
SumSRA_Base	79.543	3295.628	5.414461
SumSRA_Base_Core	67.505	3883.345	6.380034
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	75.274	3482.537	5.721539
SumSRATraits_Core	67.958	3857.464	6.337514
SumSRAConstTraits	67.130	3905.027	6.415657
SumSRAConstTraits_Core	69.058	3796.018	6.236564
SumSRA128Traits	570.308	459.654	0.755175
SumSRA128Traits_Core	572.749	457.695	0.751957
SumSRA128ConstTraits	571.586	458.626	0.753487
SumSRA128ConstTraits_Core	569.833	460.036	0.755804
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	67.389	3889.986	6.390946

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
Check-SumSRAConstTraits	Check `SumSRAConstTraits` mismatch. -24614!=-12499
Check-SumSRA128ConstTraits	Check `SumSRA128ConstTraits` mismatch. -24614!=-12499
SumSRAScalar	435.435	602.027
SumSRA_Base_Basic	500.011	524.277	0.870852
SumSRA_Base	154.264	1699.319	2.822661
SumSRA_Base_Core	136.696	1917.718	3.185433
SumSRA_AdvSimd	53.558	4894.604	8.130203
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	46.717	5611.316	9.320701
SumSRATraits_Core	33.259	7881.850	13.092181
SumSRAConstTraits	33.710	7776.346	12.916933
SumSRAConstTraits_Core	33.501	7825.036	12.997810
SumSRA128Traits	53.097	4937.065	8.200733
SumSRA128Traits_Core	33.360	7858.085	13.052706
SumSRA128ConstTraits	39.976	6557.489	10.892345
SumSRA128ConstTraits_Core	33.383	7852.609	13.043610
SumSRAFast_AdvSimd	39.635	6613.958	10.986143
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	33.446	7837.752	13.018932

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	349.774	749.467
SumSRA_Base_Basic	791.753	331.093	0.441772
SumSRA_Base	287.387	912.163	1.217082
SumSRA_Base_Core	271.809	964.443	1.286839
SumSRA_AdvSimd	89.624	2924.942	3.902696
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	93.120	2815.113	3.756154
SumSRATraits_Core	66.919	3917.314	5.226801
SumSRAConstTraits	67.135	3904.750	5.210036
SumSRAConstTraits_Core	67.105	3906.471	5.212333
SumSRA128Traits	88.703	2955.287	3.943185
SumSRA128Traits_Core	67.139	3904.516	5.209724
SumSRA128ConstTraits	80.477	3257.396	4.346283
SumSRA128ConstTraits_Core	66.817	3923.326	5.234822
SumSRAFast_AdvSimd	67.088	3907.440	5.213625
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	67.118	3905.713	5.211321

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	356.778	734.754
SumSRA_Base_Basic	551.303	475.499	0.647154
SumSRA_Base	1258.003	208.381	0.283607
SumSRA_Base_Create	548.655	477.794	0.650277
SumSRA_Base_LoadArray	649.200	403.796	0.549566
SumSRA_Base_Core	549.924	476.691	0.648777
SumSRA_AdvSimd	189.056	1386.593	1.887153
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	212.520	1233.506	1.678801
SumSRATraits_Core	134.229	1952.967	2.657988
SumSRAConstTraits	135.128	1939.969	2.640298
SumSRAConstTraits_Core	125.107	2095.352	2.851775
SumSRA128Traits	188.148	1393.287	1.896264
SumSRA128Traits_Core	134.352	1951.177	2.655553
SumSRA128ConstTraits	135.392	1936.191	2.635156
SumSRA128ConstTraits_Core	126.067	2079.394	2.830056
SumSRAFast_AdvSimd	136.375	1922.232	2.616158
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	134.632	1947.109	2.650016

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	429.906	609.771
SumSRA_Base128_Basic	552.232	474.699	0.778488
SumSRA_Base128_Basic_Ref	549.069	477.434	0.782972
SumSRA_Base_Basic	372.255	704.205	1.154868
SumSRA_Base	76.909	3408.506	5.589812
SumSRA_Base_Core	68.688	3816.472	6.258861
SumSRA_AdvSimd	23.448	11179.766	18.334365
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.380	11212.340	18.387786
SumSRATraits_Core	15.645	16756.195	27.479485
SumSRAConstTraits	16.893	15518.199	25.449222
SumSRAConstTraits_Core	15.690	16708.142	27.400681
SumSRA128Traits	23.656	11081.377	18.173012
SumSRA128Traits_Core	16.786	15617.279	25.611708
SumSRA128ConstTraits	16.895	15516.376	25.446232
SumSRA128ConstTraits_Core	16.701	15696.286	25.741278
SumSRAFast_AdvSimd	20.060	13068.034	21.431050
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	19.901	13172.480	21.602337

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	432.369	606.297
SumSRA_Base_Basic	501.224	523.008	0.862626
SumSRA_Base	153.214	1710.962	2.821987
SumSRA_Base_Core	135.187	1939.126	3.198311
SumSRA_AdvSimd	46.760	5606.209	9.246640
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	52.964	4949.502	8.163496
SumSRATraits_Core	31.078	8435.043	13.912398
SumSRAConstTraits	31.089	8432.064	13.907484
SumSRAConstTraits_Core	31.111	8426.085	13.897623
SumSRA128Traits	46.507	5636.627	9.296811
SumSRA128Traits_Core	31.092	8431.198	13.906056
SumSRA128ConstTraits	33.244	7885.445	13.005915
SumSRA128ConstTraits_Core	31.109	8426.528	13.898354
SumSRAFast_AdvSimd	31.077	8435.237	13.912717
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	33.072	7926.556	13.073722

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	350.701	747.486
SumSRA_Base_Basic	794.412	329.985	0.441460
SumSRA_Base	285.994	916.607	1.226253
SumSRA_Base_Core	271.859	964.265	1.290010
SumSRA_AdvSimd	89.414	2931.791	3.922201
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	92.988	2819.116	3.771463
SumSRATraits_Core	66.926	3916.943	5.240155
SumSRAConstTraits	62.583	4188.713	5.603733
SumSRAConstTraits_Core	62.520	4192.951	5.609403
SumSRA128Traits	93.196	2812.818	3.763037
SumSRA128Traits_Core	62.630	4185.602	5.599571
SumSRA128ConstTraits	62.640	4184.930	5.598672
SumSRA128ConstTraits_Core	66.692	3930.638	5.258476
SumSRAFast_AdvSimd	62.530	4192.300	5.608531
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	66.827	3922.750	5.247924

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	353.607	741.343
SumSRA_Base_Basic	549.686	476.897	0.643289
SumSRA_Base	550.331	476.339	0.642535
SumSRA_Base_Create	543.826	482.037	0.650221
SumSRA_Base_LoadArray	601.097	436.109	0.588269
SumSRA_Base_Core	550.471	476.218	0.642372
SumSRA_AdvSimd	187.827	1395.666	1.882619
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	212.537	1233.401	1.663739
SumSRATraits_Core	132.970	1971.453	2.659300
SumSRAConstTraits	133.046	1970.321	2.657773
SumSRAConstTraits_Core	124.655	2102.958	2.836687
SumSRA128Traits	186.413	1406.254	1.896901
SumSRA128Traits_Core	133.051	1970.258	2.657689
SumSRA128ConstTraits	124.594	2103.984	2.838072
SumSRA128ConstTraits_Core	124.672	2102.662	2.836288
SumSRAFast_AdvSimd	124.753	2101.308	2.834461
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	132.985	1971.237	2.659009

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	401.907	652.251
SumSRA_Base128_Basic	546.683	479.517	0.735172
SumSRA_Base128_Basic_Ref	551.181	475.604	0.729173
SumSRA_Base_Basic	368.989	710.438	1.089210
SumSRA_Base	76.871	3410.194	5.228345
SumSRA_Base_Core	68.071	3851.018	5.904196
SumSRA_AdvSimd	26.708	9815.157	15.048126
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	26.495	9894.245	15.169381
SumSRATraits_Core	16.661	15733.712	24.122170
SumSRAConstTraits	16.663	15732.344	24.120074
SumSRAConstTraits_Core	15.616	16787.090	25.737160
SumSRA128Traits	23.288	11256.845	17.258454
SumSRA128Traits_Core	16.625	15767.833	24.174483
SumSRA128ConstTraits	15.584	16821.669	25.790174
SumSRA128ConstTraits_Core	15.601	16802.506	25.760794
SumSRAFast_AdvSimd	15.590	16814.979	25.779917
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	15.582	16823.836	25.793497

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	320.180	818.740
SumSRANetBcl	26.369	9941.412	12.142338
SumSRANetBcl_Const	26.395	9931.397	12.130105
SumSRA_Base_Basic	477.459	549.040	0.670592
SumSRA_Base	26.389	9933.717	12.132939
SumSRA_Base_Core	26.379	9937.540	12.137609
SumSRA_AdvSimd	46.109	5685.262	6.943920
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	26.393	9932.269	12.131171
SumSRATraits_Core	26.397	9930.918	12.129521
SumSRAConstTraits	26.409	9926.348	12.123938
SumSRAConstTraits_Core	26.417	9923.414	12.120355
SumSRA128Bcl	26.386	9935.137	12.134674
SumSRA128Traits	26.440	9914.529	12.109503
SumSRA128Traits_Core	26.391	9933.236	12.132352
SumSRA128ConstTraits	26.390	9933.326	12.132462
SumSRA128ConstTraits_Core	26.390	9933.320	12.132454
SumSRAFast_AdvSimd	26.370	9941.022	12.141861
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	26.367	9942.253	12.143364

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	221.846	1181.651
SumSRANetBcl	53.179	4929.438	4.171655
SumSRANetBcl_Const	53.089	4937.824	4.178751
SumSRA_Base_Basic	774.048	338.666	0.286604
SumSRA_Base	53.274	4920.628	4.164199
SumSRA_Base_Core	53.100	4936.770	4.177859
SumSRA_AdvSimd	79.480	3298.252	2.791225
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	53.092	4937.562	4.178530
SumSRATraits_Core	53.131	4933.939	4.175464
SumSRAConstTraits	53.480	4901.680	4.148163
SumSRAConstTraits_Core	53.408	4908.354	4.153812
SumSRA128Bcl	53.247	4923.207	4.166381
SumSRA128Traits	53.236	4924.175	4.167200
SumSRA128Traits_Core	53.357	4912.996	4.157740
SumSRA128ConstTraits	53.388	4910.164	4.155343
SumSRA128ConstTraits_Core	53.461	4903.501	4.149705
SumSRAFast_AdvSimd	53.281	4920.008	4.163674
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	53.138	4933.286	4.174911

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	221.178	1185.217
SumSRANetBcl	105.933	2474.620	2.087905
SumSRANetBcl_Const	105.766	2478.519	2.091195
SumSRA_Base_Basic	539.843	485.593	0.409708
SumSRA_Base	105.719	2479.619	2.092122
SumSRA_Base_Create	146.912	1784.358	1.505512
SumSRA_Base_LoadArray	197.906	1324.587	1.117590
SumSRA_Base_Core	105.826	2477.118	2.090013
SumSRA_AdvSimd	184.847	1418.167	1.196546
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	184.743	1418.970	1.197224
SumSRATraits_Core	105.779	2478.229	2.090950
SumSRAConstTraits	105.945	2474.340	2.087669
SumSRAConstTraits_Core	105.939	2474.473	2.087781
SumSRA128Bcl	105.833	2476.969	2.089887
SumSRA128Traits	184.468	1421.079	1.199003
SumSRA128Traits_Core	106.387	2464.070	2.079004
SumSRA128ConstTraits	106.001	2473.037	2.086569
SumSRA128ConstTraits_Core	105.851	2476.549	2.089532
SumSRAFast_AdvSimd	105.859	2476.360	2.089373
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	105.810	2477.502	2.090337

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	294.565	889.935
SumSRANetBcl	13.253	19779.972	22.226304
SumSRANetBcl_Const	13.237	19803.799	22.253078
SumSRA_Base128_Basic	268.500	976.328	1.097078
SumSRA_Base128_Basic_Ref	267.103	981.433	1.102814
SumSRA_Base_Basic	344.749	760.391	0.854434
SumSRA_Base	32.942	7957.665	8.941847
SumSRA_Base_Core	23.119	11338.964	12.741335
SumSRA_AdvSimd	23.111	11342.725	12.745562
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.092	11352.199	12.756207
SumSRATraits_Core	13.229	19816.163	22.266971
SumSRAConstTraits	13.245	19791.972	22.239788
SumSRAConstTraits_Core	13.245	19791.891	22.239697
SumSRA128Bcl	13.234	19808.239	22.258066
SumSRA128Traits	23.156	11320.583	12.720681
SumSRA128Traits_Core	13.233	19809.326	22.259288
SumSRA128ConstTraits	13.234	19807.724	22.257488
SumSRA128ConstTraits_Core	13.251	19782.592	22.229248
SumSRAFast_AdvSimd	13.219	19831.173	22.283837
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	13.263	19764.481	22.208897

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	315.721	830.302
SumSRANetBcl	26.648	9837.372	11.847949
SumSRANetBcl_Const	26.645	9838.530	11.849343
SumSRA_Base_Basic	483.894	541.738	0.652460
SumSRA_Base	26.701	9817.663	11.824211
SumSRA_Base_Core	26.645	9838.272	11.849033
SumSRA_AdvSimd	26.950	9727.016	11.715037
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	26.646	9837.893	11.848576
SumSRATraits_Core	27.004	9707.757	11.691842
SumSRAConstTraits	26.656	9834.469	11.844452
SumSRAConstTraits_Core	26.656	9834.395	11.844363
SumSRA128Bcl	26.644	9838.923	11.849817
SumSRA128Traits	26.649	9837.037	11.847544
SumSRA128Traits_Core	27.003	9707.873	11.691983
SumSRA128ConstTraits	26.640	9840.065	11.851192
SumSRA128ConstTraits_Core	26.645	9838.351	11.849127
SumSRA512Bcl	19.557	13404.008	16.143539
SumSRA512Traits	19.561	13401.551	16.140580
SumSRAFast_AdvSimd	26.650	9836.728	11.847173
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	26.642	9839.610	11.850644

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	210.723	1244.019
SumSRANetBcl	54.063	4848.848	3.897727
SumSRANetBcl_Const	53.995	4854.964	3.902643
SumSRA_Base_Basic	796.894	328.957	0.264431
SumSRA_Base	53.968	4857.427	3.904624
SumSRA_Base_Core	53.885	4864.883	3.910617
SumSRA_AdvSimd	54.696	4792.779	3.852656
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	54.465	4813.108	3.868997
SumSRATraits_Core	54.752	4787.843	3.848689
SumSRAConstTraits	54.061	4849.051	3.897890
SumSRAConstTraits_Core	54.015	4853.184	3.901213
SumSRA128Bcl	53.972	4857.072	3.904338
SumSRA128Traits	53.985	4855.871	3.903372
SumSRA128Traits_Core	54.741	4788.765	3.849430
SumSRA128ConstTraits	53.890	4864.386	3.910218
SumSRA128ConstTraits_Core	53.973	4856.939	3.904231
SumSRA512Bcl	39.752	6594.414	5.300893
SumSRA512Traits	39.645	6612.354	5.315315
SumSRAFast_AdvSimd	54.312	4826.590	3.879835
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	53.964	4857.725	3.904863

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	210.735	1243.954
SumSRANetBcl	107.738	2433.159	1.955988
SumSRANetBcl_Const	107.494	2438.677	1.960424
SumSRA_Base_Basic	555.390	472.000	0.379435
SumSRA_Base	107.518	2438.137	1.959990
SumSRA_Base_Create	137.374	1908.244	1.534015
SumSRA_Base_LoadArray	160.746	1630.800	1.310981
SumSRA_Base_Core	108.148	2423.927	1.948567
SumSRA_AdvSimd	108.140	2424.126	1.948727
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	108.105	2424.896	1.949346
SumSRATraits_Core	108.109	2424.819	1.949284
SumSRAConstTraits	108.603	2413.790	1.940418
SumSRAConstTraits_Core	107.769	2432.455	1.955422
SumSRA128Bcl	107.778	2432.252	1.955259
SumSRA128Traits	108.195	2422.886	1.947730
SumSRA128Traits_Core	108.243	2421.802	1.946859
SumSRA128ConstTraits	107.586	2436.593	1.958749
SumSRA128ConstTraits_Core	107.753	2432.834	1.955727
SumSRA512Bcl	77.059	3401.842	2.734701
SumSRA512Traits	76.894	3409.179	2.740599
SumSRAFast_AdvSimd	107.680	2434.474	1.957045
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	108.098	2425.048	1.949468

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	315.684	830.400
SumSRANetBcl	13.364	19615.987	23.622337
SumSRANetBcl_Const	13.365	19613.758	23.619652
SumSRA_Base128_Basic	273.918	957.017	1.152477
SumSRA_Base128_Basic_Ref	273.905	957.062	1.152532
SumSRA_Base_Basic	350.333	748.271	0.901097
SumSRA_Base	30.513	8591.201	10.345860
SumSRA_Base_Core	18.575	14112.821	16.995210
SumSRA_AdvSimd	13.432	19516.555	23.502597
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	13.435	19512.654	23.497900
SumSRATraits_Core	13.499	19419.454	23.385665
SumSRAConstTraits	13.363	19617.529	23.624193
SumSRAConstTraits_Core	13.362	19619.300	23.626326
SumSRA128Bcl	13.364	19615.967	23.622313
SumSRA128Traits	13.583	19298.809	23.240379
SumSRA128Traits_Core	13.611	19259.375	23.192891
SumSRA128ConstTraits	13.378	19594.873	23.596910
SumSRA128ConstTraits_Core	13.369	19608.514	23.613337
SumSRA512Bcl	9.677	27089.953	32.622778
SumSRA512Traits	9.657	27144.285	32.688207
SumSRAFast_AdvSimd	13.388	19581.084	23.580305
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	13.442	19502.439	23.485598

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	9706.250	27.008
SumSRANetBcl	1547.005	169.453	6.274219
SumSRANetBcl_Const	1688.802	155.225	5.747417
SumSRA_Base_Basic	13505.208	19.411	0.718704
SumSRA_Base	1559.505	168.094	6.223929
SumSRA_Base_Core	1543.750	169.810	6.287449
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	2071.615	126.541	4.685355
SumSRATraits_Core	2025.651	129.412	4.791669
SumSRAConstTraits	2143.490	122.298	4.528247
SumSRAConstTraits_Core	2154.427	121.677	4.505258
SumSRA128Bcl	1536.458	170.616	6.317288
SumSRA128Traits	1569.141	167.062	6.185711
SumSRA128Traits_Core	1566.146	167.382	6.197539
SumSRA128ConstTraits	1648.438	159.026	5.888152
SumSRA128ConstTraits_Core	1656.771	158.226	5.858535
SumSRA512Bcl	8056.250	32.539	1.204810
SumSRA512Traits	8320.833	31.505	1.166500
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	2044.792	128.201	4.746816

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	7472.917	35.079
SumSRANetBcl	3175.260	82.558	2.353482
SumSRANetBcl_Const	3362.760	77.955	2.222257
SumSRA_Base_Basic	14812.500	17.697	0.504501
SumSRA_Base	3154.687	83.097	2.368829
SumSRA_Base_Core	3001.302	87.343	2.489892
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	4048.958	64.744	1.845639
SumSRATraits_Core	4140.625	63.310	1.804780
SumSRAConstTraits	4465.625	58.703	1.673431
SumSRAConstTraits_Core	4118.229	63.655	1.814595
SumSRA128Bcl	3251.823	80.614	2.298070
SumSRA128Traits	3123.438	83.928	2.392530
SumSRA128Traits_Core	3059.635	85.678	2.442421
SumSRA128ConstTraits	3460.937	75.744	2.159217
SumSRA128ConstTraits_Core	3437.240	76.266	2.174104
SumSRA512Bcl	15689.583	16.708	0.476298
SumSRA512Traits	15704.167	16.693	0.475856
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	4141.146	63.302	1.804553

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	8068.229	32.491
SumSRANetBcl	39795.833	6.587	0.202741
SumSRANetBcl_Const	39412.500	6.651	0.204712
SumSRA_Base_Basic	42254.167	6.204	0.190945
SumSRA_Base	40137.500	6.531	0.201015
SumSRA_Base_Create	68191.667	3.844	0.118317
SumSRA_Base_LoadArray	58716.666	4.465	0.137410
SumSRA_Base_Core	40883.333	6.412	0.197348
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	12416.667	21.112	0.649790
SumSRATraits_Core	12788.542	20.498	0.630895
SumSRAConstTraits	12696.875	20.646	0.635450
SumSRAConstTraits_Core	12584.375	20.831	0.641131
SumSRA128Bcl	89916.667	2.915	0.089730
SumSRA128Traits	6504.687	40.301	1.240372
SumSRA128Traits_Core	6433.333	40.748	1.254129
SumSRA128ConstTraits	7071.354	37.071	1.140974
SumSRA128ConstTraits_Core	6892.708	38.032	1.170546
SumSRA512Bcl	115008.333	2.279	0.070153
SumSRA512Traits	79025.000	3.317	0.102097
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	26704.167	9.817	0.302134

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	8917.708	29.396
SumSRANetBcl	790.755	331.511	11.277458
SumSRANetBcl_Const	858.008	305.526	10.393505
SumSRA_Base128_Basic	8529.167	30.735	1.045554
SumSRA_Base128_Basic_Ref	8711.458	30.092	1.023676
SumSRA_Base_Basic	11390.625	23.014	0.782899
SumSRA_Base	20900.000	12.543	0.426685
SumSRA_Base_Core	16668.750	15.727	0.534996
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	1042.839	251.375	8.551380
SumSRATraits_Core	1023.698	256.076	8.711269
SumSRAConstTraits	1051.042	249.414	8.484638
SumSRAConstTraits_Core	1076.042	243.619	8.287512
SumSRA128Bcl	773.047	339.105	11.535792
SumSRA128Traits	786.523	333.295	11.338134
SumSRA128Traits_Core	774.219	338.592	11.518332
SumSRA128ConstTraits	837.370	313.056	10.649666
SumSRA128ConstTraits_Core	847.721	309.234	10.519622
SumSRA512Bcl	4190.104	62.563	2.128278
SumSRA512Traits	4319.271	60.692	2.064633
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	1002.214	261.565	8.898012

```

