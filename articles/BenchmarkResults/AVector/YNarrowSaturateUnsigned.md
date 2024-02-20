# Benchmark - YNarrowSaturateUnsigned
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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1246.583	210.290
SumNarrow_IfUnrolling4	1219.788	214.910	1.021967
SumNarrow_MinMax	1261.245	207.845	0.988375
SumNarrow_MinMaxUnrolling4	1620.898	161.728	0.769069
SumNarrow_BitMath	1084.412	241.738	1.149547
SumNarrow_BitMathUnrolling4	681.228	384.811	1.829907
SumNarrowVectorBase	16.920	15493.391	73.676288
SumNarrowVectorTraits	16.900	15511.929	73.764444

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1220.923	214.710
SumNarrow_MinMax	1226.086	213.806	0.995790
SumNarrow_BitMath	511.680	512.320	2.386108
SumNarrowVectorBase	34.743	7545.259	35.141689
SumNarrowVectorTraits	34.719	7550.500	35.166095

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	914.514	286.648
SumNarrow_MinMax	931.788	281.334	0.981461
SumNarrow_BitMath	498.701	525.654	1.833793
SumNarrowVectorBase	115.331	2272.961	7.929440
SumNarrowVectorTraits	116.106	2257.793	7.876524

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1287.951	203.536
SumNarrow_IfUnrolling4	1225.024	213.991	1.051368
SumNarrow_MinMax	1218.342	215.164	1.057134
SumNarrow_MinMaxUnrolling4	1192.816	219.769	1.079757
SumNarrow_BitMath	1088.213	240.894	1.183547
SumNarrow_BitMathUnrolling4	682.762	383.947	1.886385
SumNarrowVectorBase	17.652	14850.977	72.964999
SumNarrowVectorTraits	17.586	14906.325	73.236932

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1214.604	215.827
SumNarrow_MinMax	1217.566	215.302	0.997567
SumNarrow_BitMath	508.584	515.439	2.388208
SumNarrowVectorBase	38.576	6795.446	31.485650
SumNarrowVectorTraits	38.734	6767.870	31.357880

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	916.593	285.998
SumNarrow_MinMax	928.013	282.479	0.987694
SumNarrow_BitMath	497.797	526.609	1.841299
SumNarrowVectorBase	137.086	1912.266	6.686283
SumNarrowVectorTraits	137.041	1912.881	6.688434

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1304.080	201.018
SumNarrow_IfUnrolling4	1328.272	197.357	0.981787
SumNarrow_MinMax	1222.789	214.382	1.066480
SumNarrow_MinMaxUnrolling4	1235.679	212.146	1.055356
SumNarrow_BitMath	730.613	358.800	1.784912
SumNarrow_BitMathUnrolling4	623.148	420.677	2.092730
SumNarrowVectorBase	19.209	13646.959	67.889141
SumNarrowVectorTraits	9.194	28513.211	141.843863
SumNarrowVector128Traits	12.412	21120.153	105.065830
SumNarrowVector256Traits	9.216	28443.815	141.498644

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1220.896	214.714
SumNarrow_MinMax	1231.824	212.810	0.991128
SumNarrow_BitMath	527.627	496.836	2.313939
SumNarrowVectorBase	38.819	6752.904	31.450622
SumNarrowVectorTraits	18.309	14317.622	66.682141
SumNarrowVector128Traits	24.527	10688.056	49.777992
SumNarrowVector256Traits	19.185	13664.211	63.638981

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	810.885	323.281
SumNarrow_MinMax	880.350	297.773	0.921094
SumNarrow_BitMath	516.515	507.524	1.569915
SumNarrowVectorBase	122.617	2137.906	6.613144
SumNarrowVectorTraits	92.800	2824.818	8.737957
SumNarrowVector128Traits	213.330	1228.817	3.801077
SumNarrowVector256Traits	92.888	2822.149	8.729700

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1256.799	208.581
SumNarrow_IfUnrolling4	1329.672	197.149	0.945195
SumNarrow_MinMax	1215.412	215.683	1.034052
SumNarrow_MinMaxUnrolling4	1210.498	216.559	1.038250
SumNarrow_BitMath	1049.040	249.889	1.198047
SumNarrow_BitMathUnrolling4	968.818	270.581	1.297250
SumNarrowVectorBase	19.408	13506.832	64.755907
SumNarrowVectorTraits	10.380	25254.194	121.076373
SumNarrowVector128Traits	13.491	19431.592	93.161027
SumNarrowVector256Traits	9.279	28252.470	135.451029

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1220.955	214.704
SumNarrow_MinMax	1235.110	212.243	0.988539
SumNarrow_BitMath	895.245	292.818	1.363821
SumNarrowVectorBase	35.955	7290.861	33.957709
SumNarrowVectorTraits	18.296	14327.770	66.732620
SumNarrowVector128Traits	26.623	9846.518	45.860865
SumNarrowVector256Traits	20.599	12726.347	59.273877

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	848.198	309.060
SumNarrow_MinMax	924.323	283.607	0.917643
SumNarrow_BitMath	705.034	371.817	1.203060
SumNarrowVectorBase	122.189	2145.397	6.941690
SumNarrowVectorTraits	92.578	2831.598	9.161976
SumNarrowVector128Traits	140.284	1868.665	6.046290
SumNarrowVector256Traits	91.749	2857.186	9.244768

[Vectors.Instance: VectorTraits256Avx2]
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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1299.261	201.764
SumNarrow_IfUnrolling4	1281.280	204.595	1.014033
SumNarrow_MinMax	1281.483	204.563	1.013873
SumNarrow_MinMaxUnrolling4	1363.390	192.274	0.952963
SumNarrow_BitMath	855.263	306.507	1.519137
SumNarrow_BitMathUnrolling4	808.367	324.288	1.607266
SumNarrowVectorBase	19.225	13635.746	67.582680
SumNarrowVectorTraits	9.220	28430.918	140.911806
SumNarrowVector128Traits	12.434	21083.352	104.495157
SumNarrowVector256Traits	9.218	28438.840	140.951072

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1233.054	212.597
SumNarrow_MinMax	1215.441	215.678	1.014491
SumNarrow_BitMath	894.924	292.923	1.377831
SumNarrowVectorBase	34.675	7559.980	35.560081
SumNarrowVectorTraits	18.302	14323.482	67.373748
SumNarrowVector128Traits	24.731	10599.796	49.858544
SumNarrowVector256Traits	18.309	14318.085	67.348361

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	818.600	320.234
SumNarrow_MinMax	804.467	325.860	1.017568
SumNarrow_BitMath	705.676	371.479	1.160023
SumNarrowVectorBase	121.246	2162.083	6.751563
SumNarrowVectorTraits	92.144	2844.929	8.883894
SumNarrowVector128Traits	140.676	1863.457	5.819040
SumNarrowVector256Traits	92.371	2837.939	8.862068

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1189.598	220.364
SumNarrow_IfUnrolling4	1263.791	207.427	0.941293
SumNarrow_MinMax	1188.973	220.479	1.000526
SumNarrow_MinMaxUnrolling4	1253.008	209.212	0.949394
SumNarrow_BitMath	653.151	401.353	1.821320
SumNarrow_BitMathUnrolling4	673.158	389.424	1.767191
SumNarrowVectorBase	15.622	16780.535	76.149336
SumNarrowVectorTraits	9.173	28577.130	129.681768
SumNarrowVector128Traits	12.293	21324.347	96.768957
SumNarrowVector256Traits	9.260	28307.930	128.460150

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1175.542	222.998
SumNarrow_MinMax	1260.100	208.034	0.932896
SumNarrow_BitMath	518.986	505.108	2.265076
SumNarrowVectorBase	27.119	9666.440	43.347569
SumNarrowVectorTraits	18.151	14442.278	64.764034
SumNarrowVector128Traits	24.383	10750.941	48.210839
SumNarrowVector256Traits	18.332	14299.886	64.125500

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	796.042	329.309
SumNarrow_MinMax	797.389	328.753	0.998310
SumNarrow_BitMath	572.111	458.205	1.391411
SumNarrowVectorBase	95.012	2759.052	8.378301
SumNarrowVectorTraits	102.058	2568.578	7.799897
SumNarrowVector128Traits	194.470	1347.991	4.093389
SumNarrowVector256Traits	100.936	2597.132	7.886604

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1712.632	153.065
SumNarrow_IfUnrolling4	1651.216	158.758	1.037194
SumNarrow_MinMax	1632.561	160.572	1.049046
SumNarrow_MinMaxUnrolling4	1618.259	161.991	1.058318
SumNarrow_BitUtil	1089.931	240.514	1.571321
SumNarrow_BitUtilUnrolling4	1105.809	237.061	1.548760
SumNarrowVectorBase	92.385	2837.509	18.537936
SumNarrowVectorTraits	36.546	7172.940	46.862050
SumNarrowVector128Traits	1967.588	133.231	0.870422
SumNarrowVector256Traits	2544.359	103.029	0.673109

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1534.499	170.834
SumNarrow_MinMax	1705.828	153.675	0.899562
SumNarrow_BitUtil	910.319	287.969	1.685672
SumNarrowVectorBase	255.712	1025.152	6.000880
SumNarrowVectorTraits	81.727	3207.567	18.775967
SumNarrowVector128Traits	3570.817	73.413	0.429733
SumNarrowVector256Traits	5667.820	46.251	0.270739

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	1088.746	240.776
SumNarrow_MinMax	1212.264	216.243	0.898110
SumNarrow_BitUtil	899.278	291.505	1.210689
SumNarrowVectorBase	574.396	456.382	1.895462
SumNarrowVectorTraits	349.084	750.949	3.118869
SumNarrowVector128Traits	2971.944	88.206	0.366341
SumNarrowVector256Traits	5312.546	49.344	0.204939

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1631.060	160.720
SumNarrow_IfUnrolling4	1647.380	159.128	0.990093
SumNarrow_MinMax	1578.910	166.028	1.033029
SumNarrow_MinMaxUnrolling4	1609.993	162.823	1.013085
SumNarrow_BitUtil	1439.595	182.096	1.132999
SumNarrow_BitUtilUnrolling4	1470.416	178.279	1.109251
SumNarrowVectorBase	92.752	2826.288	17.585163
SumNarrowVectorTraits	20.597	12727.463	79.190268
SumNarrowVector128Traits	214.012	1224.903	7.621347
SumNarrowVector256Traits	2472.839	106.009	0.659590

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1537.830	170.464
SumNarrow_MinMax	1706.341	153.629	0.901244
SumNarrow_BitUtil	1200.762	218.315	1.280712
SumNarrowVectorBase	176.836	1482.412	8.696356
SumNarrowVectorTraits	42.959	6102.258	35.798012
SumNarrowVector128Traits	42.996	6097.001	35.767176
SumNarrowVector256Traits	5060.002	51.807	0.303919

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	1119.204	234.224
SumNarrow_MinMax	1237.811	211.780	0.904180
SumNarrow_BitUtil	1256.744	208.590	0.890558
SumNarrowVectorBase	390.890	670.633	2.863217
SumNarrowVectorTraits	86.671	3024.586	12.913236
SumNarrowVector128Traits	82.405	3181.158	13.581709
SumNarrowVector256Traits	3759.614	69.726	0.297691

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1724.608	152.002
SumNarrow_IfUnrolling4	1635.380	160.295	1.054561
SumNarrow_MinMax	1679.419	156.092	1.026908
SumNarrow_MinMaxUnrolling4	1779.425	147.319	0.969194
SumNarrow_BitUtil	1441.448	181.862	1.196441
SumNarrow_BitUtilUnrolling4	1457.720	179.832	1.183086
SumNarrowVectorBase	100.944	2596.920	17.084765
SumNarrowVectorTraits	20.179	12990.820	85.464758
SumNarrowVector128Traits	138.898	1887.309	12.416339
SumNarrowVector256Traits	2436.253	107.601	0.707894

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1587.419	165.138
SumNarrow_MinMax	1677.166	156.302	0.946489
SumNarrow_BitUtil	1202.970	217.914	1.319584
SumNarrowVectorBase	186.655	1404.431	8.504566
SumNarrowVectorTraits	42.821	6121.812	37.070778
SumNarrowVector128Traits	43.974	5961.382	36.099292
SumNarrowVector256Traits	4776.724	54.879	0.332324

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	1080.597	242.592
SumNarrow_MinMax	1057.580	247.872	1.021764
SumNarrow_BitUtil	1202.646	217.973	0.898516
SumNarrowVectorBase	375.141	698.787	2.880508
SumNarrowVectorTraits	80.335	3263.127	13.451105
SumNarrowVector128Traits	80.596	3252.567	13.407575
SumNarrowVector256Traits	3681.385	71.208	0.293530

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1423.639	184.137
SumNarrow_IfUnrolling4	1415.443	185.203	1.005790
SumNarrow_MinMax	1413.592	185.445	1.007107
SumNarrow_MinMaxUnrolling4	1407.851	186.201	1.011214
SumNarrow_BitUtil	1168.532	224.336	1.218314
SumNarrow_BitUtilUnrolling4	1190.620	220.174	1.195712
SumNarrowVectorBase	33.925	7727.137	41.964164
SumNarrowVectorTraits	18.263	14353.921	77.952580
SumNarrowVector128Traits	18.294	14329.333	77.819050
SumNarrowVector256Traits	3969.753	66.035	0.358622

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1365.276	192.008
SumNarrow_MinMax	1331.089	196.939	1.025683
SumNarrow_BitUtil	923.921	283.730	1.477698
SumNarrowVectorBase	78.161	3353.910	17.467556
SumNarrowVectorTraits	34.262	7651.172	39.848193
SumNarrowVector128Traits	34.292	7644.449	39.813178
SumNarrowVector256Traits	4052.878	64.681	0.336866

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	928.196	282.423
SumNarrow_MinMax	872.411	300.482	1.063943
SumNarrow_BitUtil	956.906	273.950	0.969997
SumNarrowVectorBase	178.319	1470.086	5.205258
SumNarrowVectorTraits	65.097	4026.995	14.258722
SumNarrowVector128Traits	65.756	3986.622	14.115771
SumNarrowVector256Traits	2929.415	89.487	0.316854

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```


### Apple M2
`Apple M2 @ 3.20 GHz 8 Core`

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 13.3.0
Environment.Version:	7.0.4
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.4/
RuntimeInformation.FrameworkDescription:	.NET 7.0.4
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.4/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	884.416	296.404
SumNarrow_IfUnrolling4	805.433	325.470	1.098063
SumNarrow_MinMax	842.998	310.966	1.049131
SumNarrow_MinMaxUnrolling4	819.153	320.018	1.079671
SumNarrow_BitMath	327.894	799.477	2.697260
SumNarrow_BitMathUnrolling4	323.089	811.368	2.737376
SumNarrowVectorBase	11.752	22306.047	75.255659
SumNarrowVectorTraits	9.360	28007.803	94.492120
SumNarrowVector128Traits	9.361	28002.843	94.475383
SumNarrowVector256Traits	2418.901	108.373	0.365627

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	931.216	281.507
SumNarrow_MinMax	869.487	301.493	1.070994
SumNarrow_BitMath	230.974	1134.952	4.031696
SumNarrowVectorBase	23.634	11091.733	39.401227
SumNarrowVectorTraits	18.720	14003.398	49.744351
SumNarrowVector128Traits	18.717	14005.639	49.752313
SumNarrowVector256Traits	1615.007	162.318	0.576602

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	547.804	478.536
SumNarrow_MinMax	486.299	539.059	1.126474
SumNarrow_BitMath	231.103	1134.314	2.370382
SumNarrowVectorBase	60.890	4305.238	8.996678
SumNarrowVectorTraits	37.441	7001.500	14.631068
SumNarrowVector128Traits	37.449	6999.984	14.627900
SumNarrowVector256Traits	1415.826	185.153	0.386914

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

