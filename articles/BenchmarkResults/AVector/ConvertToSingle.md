# Benchmark - ConvertToSingle
([← Back](README.md))

- `ConvertToInt32`: Convert to a vector whose elements are of type Int32 (转换为元素类型是Int32的向量).
  Mnemonic: `rt[i] := (Int32)(value[i])` .
- `ConvertToSingle`: Convert to a vector whose elements are of type Single (转换为元素类型是Single的向量).
  Mnemonic: `rt[i] := (Single)(value[i])` .
- `ConvertToUInt32`: Convert to a vector whose elements are of type UInt32 (转换为元素类型是UInt32的向量).
  Mnemonic: `rt[i] := (UInt32)(value[i])` .

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	174.833	1499.395
SumBcl	25.153	10421.773	6.950654
SumTraits	26.256	9984.056	6.658725

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	366.847	714.586
SumBcl	49.066	5342.687	7.476613
SumTraits	49.099	5339.127	7.471632

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	379.691	690.414
SumBcl	68.264	3840.125	5.562057
SumTraits	68.901	3804.634	5.510652

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	199.534	1313.781
SumBcl	846.585	309.649	0.235693
SumTraits	790.441	331.643	0.252434

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	156.984	1669.872
SumBcl	25.529	10268.459	6.149248
SumTraits	22.476	11663.138	6.984449

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	309.753	846.301
SumBcl	38.836	6749.984	7.975871
SumTraits	38.870	6744.116	7.968937

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	310.385	844.578
SumBcl	47.564	5511.355	6.525573
SumTraits	48.064	5454.035	6.457704

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	156.728	1672.603
SumBcl	618.441	423.879	0.253425
SumTraits	619.559	423.114	0.252967

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	157.026	1669.428
SumBcl	24.240	10814.535	6.477989
SumTraits	23.902	10967.617	6.569687
Sum128Base_Basic	452.460	579.374	0.347050
Sum128Base	455.601	575.380	0.344657
Sum128Traits	40.897	6409.819	3.839531
Sum256Base_Basic	276.639	947.605	0.567623
Sum256Base	273.459	958.622	0.574222
Sum256Traits	22.516	11642.519	6.973959

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	309.786	846.210
SumBcl	38.842	6748.989	7.975548
SumTraits	38.929	6733.875	7.957687
Sum128Base_Basic	484.995	540.509	0.638741
Sum128Base	484.953	540.556	0.638796
Sum128Traits	77.632	3376.766	3.990459
Sum256Base_Basic	296.125	885.249	1.046134
Sum256Base	295.394	887.439	1.048722
Sum256Traits	38.918	6735.888	7.960067

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	310.059	845.465
SumBcl	43.145	6075.856	7.186411
SumTraits	41.273	6351.457	7.512386
Sum128Base_Basic	542.842	482.910	0.571177
Sum128Base	542.661	483.071	0.571368
Sum128Traits	77.905	3364.906	3.979948
Sum256Base_Basic	358.573	731.077	0.864704
Sum256Base	358.521	731.182	0.864829
Sum256Traits	41.186	6364.881	7.528264

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	156.969	1670.039
SumBcl	624.623	419.684	0.251302
SumTraits	65.624	3994.640	2.391944
Sum128Base_Basic	454.218	577.132	0.345580
Sum128Base	452.509	579.312	0.346885
Sum128Traits	117.182	2237.059	1.339525
Sum256Base_Basic	274.533	954.871	0.571765
Sum256Base	273.473	958.572	0.573982
Sum256Avx2_ShiftVar	65.204	4020.361	2.407345
Sum256Avx2_Mapping	274.682	954.356	0.571457
Sum256Avx2_MappingFix	273.159	959.677	0.574643
Sum256Avx2_Mod	273.369	958.940	0.574202
Sum256Traits	65.705	3989.698	2.388985

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	156.700	1672.903
SumBcl	22.205	11805.635	7.056974
SumTraits	22.000	11915.415	7.122596
Sum128Base_Basic	430.859	608.422	0.363692
Sum128Base	430.722	608.616	0.363808
Sum128Traits	40.659	6447.333	3.853978
Sum256Base_Basic	283.793	923.714	0.552162
Sum256Base	280.492	934.587	0.558661
Sum256Traits	22.348	11729.918	7.011713

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	309.794	846.187
SumBcl	38.868	6744.484	7.970439
SumTraits	38.904	6738.263	7.963088
Sum128Base_Basic	466.102	562.417	0.664649
Sum128Base	465.611	563.010	0.665349
Sum128Traits	77.842	3367.625	3.979764
Sum256Base_Basic	303.944	862.476	1.019249
Sum256Base	303.975	862.387	1.019144
Sum256Traits	38.913	6736.699	7.961240

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	310.150	845.217
SumBcl	47.628	5503.989	6.511923
SumTraits	39.464	6642.531	7.858964
Sum128Base_Basic	542.461	483.249	0.571746
Sum128Base	542.515	483.202	0.571689
Sum128Traits	77.728	3372.597	3.990214
Sum256Base_Basic	368.235	711.893	0.842260
Sum256Base	368.573	711.241	0.841489
Sum256Traits	39.635	6613.978	7.825182

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	156.811	1671.720
SumBcl	469.150	558.764	0.334245
SumTraits	55.959	4684.569	2.802245
Sum128Base_Basic	431.677	607.269	0.363260
Sum128Base	430.851	608.433	0.363956
Sum128Traits	99.156	2643.752	1.581456
Sum256Base_Basic	280.991	932.925	0.558063
Sum256Base	287.088	913.115	0.546213
Sum256Avx2_ShiftVar	55.682	4707.837	2.816164
Sum256Avx2_Mapping	47.207	5553.033	3.321748
Sum256Avx2_MappingFix	58.938	4447.789	2.660606
Sum256Avx2_Mod	111.743	2345.947	1.403313
Sum256Traits	55.798	4698.052	2.810311

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	156.863	1671.169
SumBcl	22.692	11552.363	6.912742
SumTraits	22.290	11760.373	7.037212
Sum128Base_Basic	434.661	603.101	0.360885
Sum128Base	436.704	600.279	0.359197
Sum128Traits	40.767	6430.375	3.847830
Sum256Base_Basic	552.869	474.152	0.283725
Sum256Base	552.588	474.393	0.283869
Sum256Traits	22.574	11612.407	6.948672

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	309.933	845.809
SumBcl	38.833	6750.559	7.981189
SumTraits	39.016	6718.815	7.943659
Sum128Base_Basic	466.564	561.861	0.664289
Sum128Base	466.732	561.658	0.664049
Sum128Traits	77.583	3378.899	3.994874
Sum256Base_Basic	573.150	457.374	0.540754
Sum256Base	573.353	457.212	0.540562
Sum256Traits	38.963	6728.034	7.954558

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	310.060	845.461
SumBcl	47.482	5520.861	6.530000
SumTraits	39.778	6590.232	7.794836
Sum128Base_Basic	542.425	483.281	0.571619
Sum128Base	542.889	482.868	0.571130
Sum128Traits	77.795	3369.685	3.985618
Sum256Base_Basic	649.723	403.470	0.477219
Sum256Base	650.080	403.249	0.476958
Sum256Traits	39.614	6617.517	7.827109

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	158.548	1653.408
SumBcl	493.349	531.356	0.321370
SumTraits	55.058	4761.244	2.879655
Sum128Base_Basic	438.544	597.760	0.361532
Sum128Base	430.981	608.249	0.367876
Sum128Traits	98.399	2664.080	1.611266
Sum256Base_Basic	554.492	472.764	0.285933
Sum256Base	553.315	473.770	0.286542
Sum256Avx2_ShiftVar	55.111	4756.635	2.876867
Sum256Avx2_Mapping	47.054	5571.145	3.369492
Sum256Avx2_MappingFix	59.221	4426.557	2.677232
Sum256Avx2_Mod	109.464	2394.794	1.448399
Sum256Traits	55.136	4754.504	2.875578

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	155.001	1691.240
SumBcl	23.774	11026.326	6.519671
SumTraits	24.253	10808.847	6.391079
Sum128Bcl	42.821	6121.922	3.619784
Sum128Base_Basic	435.033	602.585	0.356298
Sum128Base	42.182	6214.614	3.674591
Sum128Traits	42.306	6196.387	3.663813
Sum256Bcl	22.909	11442.853	6.765956
Sum256Base_Basic	263.653	994.278	0.587899
Sum256Base	22.987	11404.163	6.743079
Sum256Traits	23.030	11382.767	6.730428

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	309.764	846.270
SumBcl	38.784	6759.000	7.986809
SumTraits	38.854	6746.860	7.972463
Sum128Bcl	77.652	3375.873	3.989119
Sum128Base_Basic	465.246	563.452	0.665807
Sum128Base	77.613	3377.586	3.991143
Sum128Traits	77.579	3379.056	3.992880
Sum256Bcl	38.840	6749.398	7.975462
Sum256Base_Basic	281.014	932.852	1.102310
Sum256Base	38.868	6744.415	7.969575
Sum256Traits	38.823	6752.269	7.978855

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	310.428	844.460
SumBcl	39.858	6576.911	7.788302
SumTraits	39.826	6582.186	7.794549
Sum128Bcl	77.691	3374.187	3.995673
Sum128Base_Basic	540.337	485.149	0.574508
Sum128Base	78.152	3354.275	3.972094
Sum128Traits	77.694	3374.072	3.995537
Sum256Bcl	39.755	6593.947	7.808476
Sum256Base_Basic	348.768	751.629	0.890070
Sum256Base	39.831	6581.442	7.793668
Sum256Traits	39.775	6590.715	7.804649

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	154.976	1691.514
SumBcl	246.858	1061.923	0.627794
SumTraits	50.606	5180.147	3.062432
Sum128Bcl	415.020	631.641	0.373418
Sum128Base_Basic	435.795	601.531	0.355617
Sum128Base	415.313	631.196	0.373154
Sum128Traits	96.998	2702.577	1.597727
Sum256Bcl	246.959	1061.490	0.627538
Sum256Base_Basic	265.325	988.012	0.584099
Sum256Base	247.489	1059.217	0.626194
Sum256Avx2_ShiftVar	55.228	4746.598	2.806123
Sum256Avx2_Mapping	44.527	5887.329	3.480508
Sum256Avx2_MappingFix	51.907	5050.234	2.985629
Sum256Avx2_Mod	106.458	2462.422	1.455750
Sum256Traits	50.946	5145.548	3.041977

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
Check-SumBcl	Check `SumBcl` mismatch. 1130044246!=1130044655
Check-SumTraits	Check `SumTraits` mismatch. 1130044246!=1130044655
SumScalar	360.817	726.529
SumBcl	66.473	3943.642	5.428059
SumTraits	66.522	3940.732	5.424053
Sum128Base_Basic	1422.134	184.331	0.253715
Sum128Base	1422.598	184.271	0.253632
Sum128Traits	1423.504	184.154	0.253471
Sum256Base_Basic	1159.832	226.019	0.311094
Sum256Base	1200.498	218.363	0.300556
Sum256Traits	1311.097	199.943	0.275202

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	326.102	803.871
SumBcl	67.308	3894.690	4.844918
SumTraits	63.550	4124.981	5.131395
Sum128Base_Basic	1478.213	177.338	0.220606
Sum128Base	1478.107	177.351	0.220621
Sum128Traits	1479.923	177.134	0.220351
Sum256Base_Basic	1193.226	219.693	0.273294
Sum256Base	1239.590	211.476	0.263072
Sum256Traits	1415.771	185.160	0.230335

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	345.199	759.399
SumBcl	66.667	3932.128	5.177945
SumTraits	62.559	4190.322	5.517944
Sum128Base_Basic	1502.244	174.502	0.229789
Sum128Base	1502.162	174.511	0.229802
Sum128Traits	1502.629	174.457	0.229730
Sum256Base_Basic	1209.751	216.692	0.285347
Sum256Base	1259.196	208.184	0.274143
Sum256Traits	1384.887	189.289	0.249262

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	359.557	729.076
SumBcl	1203.936	217.739	0.298651
SumTraits	1209.196	216.792	0.297352
Sum128Base_Basic	1449.117	180.899	0.248121
Sum128Base	1446.865	181.181	0.248507
Sum128Traits	1450.058	180.782	0.247960
Sum256Base_Basic	1180.387	222.083	0.304609
Sum256Base	1213.211	216.075	0.296368
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1326.739	197.585	0.271008

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	359.083	730.038
SumBcl	67.195	3901.265	5.343924
SumTraits	63.113	4153.583	5.689546
Sum128Base_Basic	728.992	359.598	0.492575
Sum128Base	730.562	358.825	0.491516
Sum128Traits	67.309	3894.628	5.334832
Sum256Base_Basic	818.103	320.429	0.438921
Sum256Base	857.651	305.654	0.418682
Sum256Traits	857.971	305.539	0.418526

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	318.080	824.144
SumBcl	63.537	4125.841	5.006216
SumTraits	63.825	4107.206	4.983604
Sum128Base_Basic	749.466	349.775	0.424410
Sum128Base	749.142	349.926	0.424593
Sum128Traits	67.602	3877.767	4.705208
Sum256Base_Basic	831.310	315.339	0.382626
Sum256Base	874.652	299.712	0.363665
Sum256Traits	873.371	300.152	0.364198

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	345.134	759.542
SumBcl	66.995	3912.899	5.151655
SumTraits	67.088	3907.479	5.144520
Sum128Base_Basic	817.665	320.601	0.422097
Sum128Base	818.107	320.428	0.421869
Sum128Traits	67.066	3908.749	5.146192
Sum256Base_Basic	879.635	298.015	0.392361
Sum256Base	912.695	287.220	0.378148
Sum256Traits	913.226	287.053	0.377929

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	358.721	730.773
SumBcl	810.875	323.285	0.442388
SumTraits	64.164	4085.544	5.590715
Sum128Base_Basic	730.885	358.667	0.490804
Sum128Base	731.364	358.432	0.490483
Sum128Traits	64.127	4087.857	5.593880
Sum256Base_Basic	822.527	318.706	0.436121
Sum256Base	866.649	302.480	0.413918
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	870.320	301.204	0.412172

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	363.712	720.747
SumBcl	66.611	3935.441	5.460228
SumTraits	62.544	4191.321	5.815249
Sum128Base_Basic	737.293	355.549	0.493307
Sum128Base	738.354	355.038	0.492598
Sum128Traits	62.753	4177.386	5.795915
Sum256Base_Basic	812.811	322.515	0.447474
Sum256Base	860.021	304.811	0.422910
Sum256Traits	859.445	305.016	0.423194

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	317.523	825.591
SumBcl	67.365	3891.390	4.713461
SumTraits	67.433	3887.459	4.708701
Sum128Base_Basic	756.421	346.558	0.419770
Sum128Base	755.866	346.813	0.420078
Sum128Traits	63.690	4115.930	4.985437
Sum256Base_Basic	823.755	318.231	0.385458
Sum256Base	872.222	300.547	0.364039
Sum256Traits	872.329	300.511	0.363995

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	320.726	817.347
SumBcl	62.765	4176.618	5.109972
SumTraits	62.681	4182.193	5.116793
Sum128Base_Basic	756.536	346.506	0.423940
Sum128Base	757.060	346.266	0.423646
Sum128Traits	62.691	4181.556	5.116013
Sum256Base_Basic	815.437	321.477	0.393318
Sum256Base	861.716	304.212	0.372194
Sum256Traits	862.318	303.999	0.371934

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	355.502	737.392
SumBcl	1472.611	178.013	0.241409
SumTraits	63.706	4114.905	5.580353
Sum128Base_Basic	736.537	355.914	0.482666
Sum128Base	734.795	356.758	0.483811
Sum128Traits	63.824	4107.313	5.570057
Sum256Base_Basic	824.025	318.126	0.431421
Sum256Base	870.958	300.983	0.408173
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	875.057	299.574	0.406261

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	230.537	1137.101
SumBcl	54.984	4767.655	4.192817
SumTraits	55.109	4756.833	4.183299
Sum128Bcl	55.160	4752.445	4.179441
Sum128Base_Basic	718.654	364.771	0.320790
Sum128Base	55.135	4754.545	4.181288
Sum128Traits	55.014	4765.065	4.190539
Sum256Bcl	971.716	269.774	0.237248
Sum256Base_Basic	921.190	284.571	0.250260
Sum256Base	1039.142	252.270	0.221853
Sum256Traits	1039.801	252.110	0.221713

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	281.927	929.830
SumBcl	55.152	4753.116	5.111810
SumTraits	55.232	4746.243	5.104418
Sum128Bcl	55.149	4753.376	5.112089
Sum128Base_Basic	737.225	355.582	0.382416
Sum128Base	55.897	4689.764	5.043676
Sum128Traits	55.259	4743.946	5.101947
Sum256Bcl	1002.643	261.453	0.281184
Sum256Base_Basic	916.073	286.161	0.307756
Sum256Base	1002.673	261.445	0.281175
Sum256Traits	1003.036	261.351	0.281073

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	281.939	929.789
SumBcl	55.800	4697.901	5.052652
SumTraits	55.889	4690.442	5.044629
Sum128Bcl	55.862	4692.671	5.047027
Sum128Base_Basic	735.334	356.496	0.383416
Sum128Base	55.981	4682.753	5.036359
Sum128Traits	55.825	4695.803	5.050395
Sum256Bcl	1004.100	261.074	0.280788
Sum256Base_Basic	919.236	285.176	0.306710
Sum256Base	1005.482	260.715	0.280402
Sum256Traits	1005.348	260.749	0.280439

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	231.133	1134.170
SumBcl	55.081	4759.247	4.196239
SumTraits	55.126	4755.323	4.192779
Sum128Bcl	55.079	4759.381	4.196357
Sum128Base_Basic	716.769	365.730	0.322465
Sum128Base	54.993	4766.890	4.202978
Sum128Traits	54.990	4767.119	4.203180
Sum256Bcl	971.638	269.796	0.237880
Sum256Base_Basic	918.656	285.356	0.251599
Sum256Base	1035.315	253.202	0.223249
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1035.346	253.195	0.223242

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

