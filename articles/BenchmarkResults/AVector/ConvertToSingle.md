﻿# Benchmark - ConvertToSingle
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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
Check-SumBcl	Check `SumBcl` mismatch. 1130044246!=1130044655
Check-SumTraits	Check `SumTraits` mismatch. 1130044246!=1130044655
SumScalar	368.953	710.509
SumBcl	63.604	4121.479	5.800744
SumTraits	67.454	3886.273	5.469704
Sum128Base_Basic	1442.614	181.715	0.255753
Sum128Base	1438.404	182.246	0.256501
Sum128Traits	1445.970	181.293	0.255159
Sum256Base_Basic	1255.474	208.801	0.293875
Sum256Base	1286.723	203.730	0.286738
Sum256Traits	1402.849	186.865	0.263002

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	318.205	823.821
SumBcl	63.671	4117.194	4.997681
SumTraits	67.765	3868.441	4.695730
Sum128Base_Basic	1487.893	176.185	0.213863
Sum128Base	1486.583	176.340	0.214051
Sum128Traits	1494.723	175.380	0.212886
Sum256Base_Basic	1275.351	205.547	0.249504
Sum256Base	1323.351	198.091	0.240454
Sum256Traits	1473.508	177.905	0.215951

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	346.970	755.524
SumBcl	67.380	3890.506	5.149415
SumTraits	62.912	4166.831	5.515155
Sum128Base_Basic	1521.007	172.349	0.228119
Sum128Base	1509.960	173.610	0.229787
Sum128Traits	1518.258	172.661	0.228532
Sum256Base_Basic	1293.579	202.650	0.268225
Sum256Base	1340.720	195.525	0.258794
Sum256Traits	1442.707	181.703	0.240499

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	367.404	713.504
SumBcl	1207.867	217.031	0.304176
SumTraits	1210.689	216.525	0.303467
Sum128Base_Basic	1460.202	179.526	0.251612
Sum128Base	1466.725	178.727	0.250493
Sum128Traits	1464.298	179.024	0.250908
Sum256Base_Basic	1276.538	205.355	0.287813
Sum256Base	1300.340	201.596	0.282544
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1409.247	186.017	0.260709

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	362.744	722.668
SumBcl	62.442	4198.224	5.809336
SumTraits	62.249	4211.214	5.827312
Sum128Base_Basic	733.384	357.444	0.494617
Sum128Base	734.843	356.735	0.493636
Sum128Traits	62.429	4199.079	5.810519
Sum256Base_Basic	891.878	293.924	0.406720
Sum256Base	932.034	281.260	0.389197
Sum256Traits	934.526	280.510	0.388159

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	321.198	816.145
SumBcl	67.183	3901.944	4.780946
SumTraits	67.136	3904.696	4.784317
Sum128Base_Basic	751.546	348.806	0.427383
Sum128Base	750.816	349.145	0.427798
Sum128Traits	67.410	3888.786	4.764823
Sum256Base_Basic	898.107	291.885	0.357639
Sum256Base	941.489	278.436	0.341160
Sum256Traits	944.168	277.645	0.340191

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	346.548	756.443
SumBcl	66.892	3918.924	5.180725
SumTraits	66.841	3921.903	5.184662
Sum128Base_Basic	820.242	319.593	0.422495
Sum128Base	820.046	319.670	0.422596
Sum128Traits	66.504	3941.794	5.210958
Sum256Base_Basic	940.948	278.596	0.368297
Sum256Base	984.098	266.380	0.352148
Sum256Traits	986.037	265.856	0.351456

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	360.408	727.353
SumBcl	811.856	322.895	0.443931
SumTraits	63.217	4146.712	5.701100
Sum128Base_Basic	734.166	357.064	0.490909
Sum128Base	732.192	358.026	0.492232
Sum128Traits	63.292	4141.799	5.694345
Sum256Base_Basic	901.048	290.932	0.399988
Sum256Base	941.171	278.530	0.382936
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	942.672	278.086	0.382326

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	361.100	725.959
SumBcl	66.814	3923.501	5.404578
SumTraits	66.760	3926.662	5.408932
Sum128Base_Basic	739.789	354.350	0.488113
Sum128Base	739.000	354.728	0.488634
Sum128Traits	62.694	4181.350	5.759762
Sum256Base_Basic	893.642	293.344	0.404077
Sum256Base	930.405	281.753	0.388111
Sum256Traits	931.087	281.546	0.387827

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	319.511	820.454
SumBcl	63.538	4125.776	5.028649
SumTraits	63.695	4115.625	5.016277
Sum128Base_Basic	757.616	346.012	0.421732
Sum128Base	758.576	345.574	0.421198
Sum128Traits	63.674	4116.987	5.017937
Sum256Base_Basic	896.531	292.398	0.356386
Sum256Base	943.723	277.776	0.338564
Sum256Traits	940.735	278.659	0.339639

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	319.252	821.119
SumBcl	62.670	4182.957	5.094215
SumTraits	62.737	4178.430	5.088702
Sum128Base_Basic	755.839	346.825	0.422381
Sum128Base	756.873	346.351	0.421804
Sum128Traits	62.609	4187.002	5.099141
Sum256Base_Basic	887.844	295.259	0.359581
Sum256Base	930.042	281.863	0.343266
Sum256Traits	933.686	280.763	0.341927

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	359.469	729.253
SumBcl	1486.621	176.335	0.241803
SumTraits	64.239	4080.756	5.595799
Sum128Base_Basic	736.186	356.084	0.488286
Sum128Base	739.278	354.595	0.486243
Sum128Traits	64.078	4091.023	5.609878
Sum256Base_Basic	898.559	291.738	0.400050
Sum256Base	943.470	277.851	0.381007
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	941.495	278.434	0.381807

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	231.036	1134.645
SumBcl	55.346	4736.433	4.174374
SumTraits	55.458	4726.887	4.165961
Sum128Bcl	55.465	4726.317	4.165459
Sum128Base_Basic	719.558	364.312	0.321081
Sum128Base	55.445	4728.041	4.166978
Sum128Traits	55.526	4721.119	4.160877
Sum256Bcl	974.023	269.135	0.237198
Sum256Base_Basic	922.772	284.083	0.250372
Sum256Base	1043.202	251.288	0.221468
Sum256Traits	1041.543	251.688	0.221821

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	281.998	929.596
SumBcl	54.452	4814.231	5.178844
SumTraits	54.662	4795.698	5.158907
Sum128Bcl	54.695	4792.799	5.155788
Sum128Base_Basic	736.542	355.912	0.382867
Sum128Base	54.652	4796.609	5.159887
Sum128Traits	54.630	4798.539	5.161963
Sum256Bcl	993.867	263.762	0.283738
Sum256Base_Basic	917.202	285.808	0.307455
Sum256Base	994.751	263.527	0.283486
Sum256Traits	995.113	263.431	0.283383

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	281.678	930.652
SumBcl	55.155	4752.819	5.106976
SumTraits	55.225	4746.878	5.100592
Sum128Bcl	55.338	4737.181	5.090172
Sum128Base_Basic	736.599	355.884	0.382403
Sum128Base	55.176	4751.015	5.105037
Sum128Traits	55.199	4749.095	5.102975
Sum256Bcl	995.722	263.270	0.282888
Sum256Base_Basic	919.348	285.141	0.306388
Sum256Base	995.381	263.360	0.282985
Sum256Traits	995.657	263.287	0.282906

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	231.215	1133.765
SumBcl	54.672	4794.886	4.229169
SumTraits	54.763	4786.881	4.222109
Sum128Bcl	54.787	4784.806	4.220278
Sum128Base_Basic	720.380	363.897	0.320963
Sum128Base	54.623	4799.194	4.232969
Sum128Traits	54.825	4781.449	4.217318
Sum256Bcl	971.421	269.856	0.238018
Sum256Base_Basic	917.649	285.669	0.251965
Sum256Base	1036.594	252.890	0.223053
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1035.952	253.046	0.223191

```

