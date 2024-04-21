# Benchmark - YNarrowSaturateUnsigned
([← Back](README.md))

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1217.666	215.284
SumNarrow_IfUnrolling4	1218.301	215.172	0.999479
SumNarrow_MinMax	1309.516	200.184	0.929860
SumNarrow_MinMaxUnrolling4	1263.645	207.451	0.963614
SumNarrow_BitMath	1071.209	244.718	1.136722
SumNarrow_BitMathUnrolling4	620.510	422.465	1.962363
SumNarrowVectorBase	9.188	28531.707	132.530599
SumNarrowVectorTraits	9.056	28948.132	134.464905

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1147.381	228.472
SumNarrow_MinMax	1140.428	229.865	1.006097
SumNarrow_BitMath	461.891	567.545	2.484095
SumNarrowVectorBase	20.346	12884.001	56.392116
SumNarrowVectorTraits	20.358	12876.553	56.359514

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	733.830	357.227
SumNarrow_MinMax	740.584	353.969	0.990880
SumNarrow_BitMath	484.551	541.004	1.514452
SumNarrowVectorBase	74.653	3511.481	9.829822
SumNarrowVectorTraits	74.010	3542.030	9.915337

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1236.009	212.089
SumNarrow_IfUnrolling4	1175.877	222.935	1.051138
SumNarrow_MinMax	1221.538	214.602	1.011846
SumNarrow_MinMaxUnrolling4	1140.288	229.893	1.083945
SumNarrow_BitMath	1067.943	245.466	1.157373
SumNarrow_BitMathUnrolling4	626.372	418.512	1.973282
SumNarrowVectorBase	9.671	27106.812	127.808581
SumNarrowVectorTraits	9.667	27116.267	127.853163

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1172.711	223.537
SumNarrow_MinMax	1197.040	218.994	0.979676
SumNarrow_BitMath	453.541	577.994	2.585679
SumNarrowVectorBase	20.331	12893.661	57.680277
SumNarrowVectorTraits	20.414	12841.466	57.446781

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	774.823	338.328
SumNarrow_MinMax	668.546	392.111	1.158968
SumNarrow_BitMath	479.446	546.764	1.616080
SumNarrowVectorBase	73.540	3564.669	10.536148
SumNarrowVectorTraits	74.167	3534.513	10.447013

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1219.149	215.022
SumNarrow_IfUnrolling4	1179.083	222.329	1.033981
SumNarrow_MinMax	1235.119	212.242	0.987070
SumNarrow_MinMaxUnrolling4	1165.006	225.015	1.046474
SumNarrow_BitMath	770.474	340.237	1.582335
SumNarrow_BitMathUnrolling4	571.132	458.990	2.134618
SumNarrowVectorBase	9.832	26663.202	124.002094
SumNarrowVectorTraits	5.189	50522.801	234.965516
SumNarrowVector128Traits	6.798	38563.724	179.347645
SumNarrowVector256Traits	5.290	49555.905	230.468788

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1185.650	221.097
SumNarrow_MinMax	1214.560	215.835	0.976197
SumNarrow_BitMath	597.037	439.075	1.985890
SumNarrowVectorBase	23.599	11108.356	50.241920
SumNarrowVectorTraits	12.642	20735.835	93.785993
SumNarrowVector128Traits	16.407	15977.185	72.263122
SumNarrowVector256Traits	11.058	23705.223	107.216220

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	719.535	364.324
SumNarrow_MinMax	680.336	385.316	1.057618
SumNarrow_BitMath	479.081	547.181	1.501907
SumNarrowVectorBase	74.102	3537.623	9.710102
SumNarrowVectorTraits	44.517	5888.563	16.162982
SumNarrowVector128Traits	104.830	2500.670	6.863862
SumNarrowVector256Traits	43.878	5974.316	16.398357

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1238.216	211.711
SumNarrow_IfUnrolling4	1187.132	220.821	1.043031
SumNarrow_MinMax	1220.511	214.782	1.014507
SumNarrow_MinMaxUnrolling4	1175.312	223.042	1.053521
SumNarrow_BitMath	1319.834	198.619	0.938161
SumNarrow_BitMathUnrolling4	1251.575	209.451	0.989326
SumNarrowVectorBase	9.686	27065.571	127.842064
SumNarrowVectorTraits	6.489	40400.661	190.829298
SumNarrowVector128Traits	9.031	29027.332	137.108289
SumNarrowVector256Traits	5.830	44964.345	212.385499

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1337.040	196.063
SumNarrow_MinMax	1292.847	202.765	1.034182
SumNarrow_BitMath	1257.845	208.407	1.062960
SumNarrowVectorBase	23.364	11220.132	57.227174
SumNarrowVectorTraits	12.982	20193.467	102.994783
SumNarrowVector128Traits	16.520	15868.379	80.935102
SumNarrowVector256Traits	12.434	21083.283	107.533203

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	856.389	306.104
SumNarrow_MinMax	868.498	301.836	0.986058
SumNarrow_BitMath	950.461	275.807	0.901025
SumNarrowVectorBase	88.109	2975.216	9.719623
SumNarrowVectorTraits	50.969	5143.207	16.802152
SumNarrowVector128Traits	88.666	2956.524	9.658561
SumNarrowVector256Traits	49.026	5347.046	17.468067

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1222.028	214.516
SumNarrow_IfUnrolling4	1181.498	221.874	1.034304
SumNarrow_MinMax	1250.901	209.564	0.976918
SumNarrow_MinMaxUnrolling4	1258.943	208.226	0.970678
SumNarrow_BitMath	1258.801	208.249	0.970788
SumNarrow_BitMathUnrolling4	1047.302	250.304	1.166834
SumNarrowVectorBase	9.311	28154.049	131.244798
SumNarrowVectorTraits	5.047	51942.719	242.139653
SumNarrowVector128Traits	6.739	38897.086	181.325257
SumNarrowVector256Traits	5.078	51619.618	240.633462

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1174.877	223.125
SumNarrow_MinMax	1165.039	225.009	1.008444
SumNarrow_BitMath	1228.064	213.461	0.956690
SumNarrowVectorBase	19.673	13324.810	59.719131
SumNarrowVectorTraits	10.483	25006.585	112.074511
SumNarrowVector128Traits	13.739	19079.865	85.512137
SumNarrowVector256Traits	10.489	24993.055	112.013870

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	803.528	326.241
SumNarrow_MinMax	721.364	363.400	1.113900
SumNarrow_BitMath	821.593	319.068	0.978011
SumNarrowVectorBase	71.920	3644.963	11.172594
SumNarrowVectorTraits	42.021	6238.429	19.122126
SumNarrowVector128Traits	74.859	3501.849	10.733921
SumNarrowVector256Traits	42.409	6181.277	18.946942

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1166.529	224.721
SumNarrow_IfUnrolling4	1148.134	228.322	1.016022
SumNarrow_MinMax	1106.555	236.901	1.054199
SumNarrow_MinMaxUnrolling4	1097.375	238.883	1.063018
SumNarrow_BitMath	761.896	344.068	1.531087
SumNarrow_BitMathUnrolling4	766.174	342.147	1.522539
SumNarrowVectorBase	8.926	29367.475	130.683990
SumNarrowVectorTraits	5.085	51553.460	229.410660
SumNarrowVector128Traits	6.133	42745.758	190.216768
SumNarrowVector256Traits	5.028	52134.689	231.997102

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1086.190	241.343
SumNarrow_MinMax	1117.872	234.503	0.971659
SumNarrow_BitMath	534.874	490.104	2.030741
SumNarrowVectorBase	18.071	14506.111	60.105880
SumNarrowVectorTraits	10.950	23939.224	99.191861
SumNarrowVector128Traits	13.400	19563.128	81.059563
SumNarrowVector256Traits	10.939	23963.609	99.292901

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	691.745	378.960
SumNarrow_MinMax	595.604	440.131	1.161418
SumNarrow_BitMath	634.366	413.237	1.090450
SumNarrowVectorBase	44.137	5939.361	15.672776
SumNarrowVectorTraits	48.169	5442.156	14.360750
SumNarrowVector128Traits	83.176	3151.677	8.316639
SumNarrowVector256Traits	48.398	5416.410	14.292813

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1100.520	238.200
SumNarrow_IfUnrolling4	1097.508	238.854	1.002744
SumNarrow_MinMax	1122.355	233.566	0.980545
SumNarrow_MinMaxUnrolling4	1103.127	237.637	0.997636
SumNarrow_BitMath	445.799	588.032	2.468648
SumNarrow_BitMathUnrolling4	448.546	584.430	2.453525
SumNarrowVectorBase	7.648	34274.144	143.887960
SumNarrowVectorTraits	5.043	51986.258	218.246049
SumNarrowVector128Traits	7.292	35948.436	150.916887
SumNarrowVector256Traits	5.093	51471.614	216.085495
SumNarrowVector512Base	7.277	36022.539	151.227980
SumNarrowVector512Traits	5.324	49235.537	206.698113
SumNarrowVector512_Convert	5.411	48450.737	203.403407

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1032.130	253.983
SumNarrow_MinMax	1089.705	240.564	0.947165
SumNarrow_BitMath	316.864	827.308	3.257330
SumNarrowVectorBase	16.641	15752.815	62.023005
SumNarrowVectorTraits	12.114	21639.217	85.199327
SumNarrowVector128Traits	15.183	17265.832	67.980153
SumNarrowVector256Traits	12.069	21720.418	85.519038
SumNarrowVector512Base	13.828	18957.082	74.639050
SumNarrowVector512Traits	12.242	21413.772	84.311689
SumNarrowVector512_Convert	12.894	20330.327	80.045881

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	663.025	395.376
SumNarrow_MinMax	660.040	397.164	1.004523
SumNarrow_BitMath	366.182	715.885	1.810645
SumNarrowVectorBase	32.694	8018.227	20.280019
SumNarrowVectorTraits	26.243	9989.200	25.265082
SumNarrowVector128Traits	32.364	8099.972	20.486769
SumNarrowVector256Traits	26.631	9843.518	24.896617
SumNarrowVector512Base	29.361	8928.352	22.581942
SumNarrowVector512Traits	24.974	10496.607	26.548434
SumNarrowVector512_Clamp	29.064	9019.433	22.812309
SumNarrowVector512_Convert	25.270	10373.766	26.237740

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1719.121	152.487
SumNarrow_IfUnrolling4	1659.688	157.948	1.035809
SumNarrow_MinMax	1634.280	160.403	1.051913
SumNarrow_MinMaxUnrolling4	1615.113	162.307	1.064397
SumNarrow_BitMath	1088.930	240.735	1.578725
SumNarrow_BitMathUnrolling4	1103.929	237.464	1.557274
SumNarrowVectorBase	37.157	7055.040	46.266422
SumNarrowVectorTraits	36.685	7145.799	46.861616
SumNarrowVector128Traits	2003.820	130.822	0.857922
SumNarrowVector256Traits	3104.445	84.442	0.553761

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1644.127	159.443
SumNarrow_MinMax	1622.389	161.579	1.013399
SumNarrow_BitMath	884.449	296.392	1.858928
SumNarrowVectorBase	74.231	3531.453	22.148727
SumNarrowVectorTraits	72.533	3614.158	22.667444
SumNarrowVector128Traits	3795.270	69.071	0.433204
SumNarrowVector256Traits	5964.448	43.951	0.275654

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	1091.411	240.188
SumNarrow_MinMax	1211.629	216.357	0.900780
SumNarrow_BitMath	894.408	293.092	1.220261
SumNarrowVectorBase	327.476	800.498	3.332797
SumNarrowVectorTraits	327.235	801.088	3.335250
SumNarrowVector128Traits	5738.719	45.680	0.190184
SumNarrowVector256Traits	7165.872	36.582	0.152307

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1720.420	152.372
SumNarrow_IfUnrolling4	1653.287	158.559	1.040605
SumNarrow_MinMax	1634.514	160.380	1.052558
SumNarrow_MinMaxUnrolling4	1600.674	163.771	1.074810
SumNarrow_BitMath	1436.192	182.527	1.197903
SumNarrow_BitMathUnrolling4	1467.756	178.602	1.172143
SumNarrowVectorBase	36.863	7111.218	46.670071
SumNarrowVectorTraits	19.509	13436.919	88.184892
SumNarrowVector128Traits	20.628	12707.929	83.400618
SumNarrowVector256Traits	3247.986	80.710	0.529688

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1579.413	165.976
SumNarrow_MinMax	1670.547	156.921	0.945447
SumNarrow_BitMath	1202.575	217.986	1.313359
SumNarrowVectorBase	72.873	3597.270	21.673482
SumNarrowVectorTraits	42.541	6162.156	37.126870
SumNarrowVector128Traits	42.930	6106.270	36.790160
SumNarrowVector256Traits	5029.688	52.119	0.314018

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	1091.315	240.209
SumNarrow_MinMax	1211.211	216.431	0.901012
SumNarrow_BitMath	1228.814	213.331	0.888104
SumNarrowVectorBase	192.205	1363.876	5.677867
SumNarrowVectorTraits	84.312	3109.211	12.943763
SumNarrowVector128Traits	83.017	3157.716	13.145692
SumNarrowVector256Traits	8311.447	31.540	0.131303

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1690.027	155.112
SumNarrow_IfUnrolling4	1631.474	160.679	1.035890
SumNarrow_MinMax	1675.264	156.479	1.008812
SumNarrow_MinMaxUnrolling4	1785.161	146.846	0.946709
SumNarrow_BitMath	1437.175	182.402	1.175937
SumNarrow_BitMathUnrolling4	1455.408	180.117	1.161205
SumNarrowVectorBase	37.437	7002.249	45.143100
SumNarrowVectorTraits	20.692	12668.895	81.675648
SumNarrowVector128Traits	20.690	12669.799	81.681478
SumNarrowVector256Traits	5111.394	51.286	0.330639

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1579.635	165.952
SumNarrow_MinMax	1670.356	156.939	0.945688
SumNarrow_BitMath	1202.040	218.083	1.314128
SumNarrowVectorBase	73.829	3550.672	21.395740
SumNarrowVectorTraits	43.208	6067.001	36.558712
SumNarrowVector128Traits	43.330	6049.927	36.455828
SumNarrowVector256Traits	5284.498	49.606	0.298919

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	1058.521	247.651
SumNarrow_MinMax	1040.306	251.987	1.017509
SumNarrow_BitMath	1195.904	219.201	0.885122
SumNarrowVectorBase	193.511	1354.669	5.470067
SumNarrowVectorTraits	81.018	3235.645	13.065328
SumNarrowVector128Traits	81.116	3231.727	13.049508
SumNarrowVector256Traits	8477.299	30.923	0.124865

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1422.093	184.337
SumNarrow_IfUnrolling4	1413.651	185.438	1.005972
SumNarrow_MinMax	1411.598	185.707	1.007434
SumNarrow_MinMaxUnrolling4	1405.477	186.516	1.011822
SumNarrow_BitMath	1166.550	224.717	1.219059
SumNarrow_BitMathUnrolling4	1188.030	220.654	1.197017
SumNarrowVectorBase	33.334	7864.050	42.661310
SumNarrowVectorTraits	16.959	15457.546	83.854909
SumNarrowVector128Traits	16.958	15458.157	83.858222
SumNarrowVector256Traits	4167.225	62.906	0.341257

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1368.256	191.590
SumNarrow_MinMax	1330.611	197.010	1.028292
SumNarrow_BitMath	923.880	283.743	1.480989
SumNarrowVectorBase	67.351	3892.225	20.315401
SumNarrowVectorTraits	33.861	7741.818	40.408286
SumNarrowVector128Traits	34.281	7646.956	39.913153
SumNarrowVector256Traits	4316.288	60.734	0.316998

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	936.380	279.955
SumNarrow_MinMax	863.463	303.596	1.084447
SumNarrow_BitMath	958.284	273.556	0.977143
SumNarrowVectorBase	177.791	1474.447	5.266736
SumNarrowVectorTraits	65.801	3983.874	14.230429
SumNarrowVector128Traits	65.731	3988.140	14.245665
SumNarrowVector256Traits	3560.115	73.634	0.263020

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

