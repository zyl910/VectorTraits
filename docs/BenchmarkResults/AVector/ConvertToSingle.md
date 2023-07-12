# Benchmark - ConvertToSingle
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 
``` 
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9166.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	158.571	1653.169
SumBcl	26.059	10059.799	6.085161
SumTraits	23.440	11183.711	6.765014

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	311.441	841.714
SumBcl	39.180	6690.841	7.949068
SumTraits	39.195	6688.274	7.946018

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	312.634	838.501
SumBcl	51.638	5076.616	6.054396
SumTraits	51.872	5053.641	6.026996

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	164.754	1591.127
SumBcl	643.609	407.303	0.255984
SumTraits	636.462	411.877	0.258859

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

``` 

#### .NET Core 2.1 
``` 
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	158.074	1658.361
SumBcl	26.268	9979.623	6.017762
SumTraits	24.101	10876.882	6.558814

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	312.084	839.980
SumBcl	39.127	6699.811	7.976160
SumTraits	39.412	6651.344	7.918459

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	313.314	836.683
SumBcl	52.863	4958.970	5.926942
SumTraits	48.656	5387.657	6.439307

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	165.270	1586.160
SumBcl	634.524	413.135	0.260462
SumTraits	633.694	413.676	0.260803

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

``` 

#### .NET Core 3.1 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	166.745	1572.124
SumBcl	22.913	11440.895	7.277351
SumTraits	25.393	10323.354	6.566503
Sum128Base_Basic	934.119	280.632	0.178505
Sum128Base	932.728	281.051	0.178771
Sum128Traits	935.635	280.178	0.178216
Sum256Base_Basic	286.230	915.850	0.582556
Sum256Base	286.299	915.630	0.582416
Sum256Traits	23.082	11357.280	7.224165

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	312.637	838.494
SumBcl	39.191	6688.951	7.977343
SumTraits	39.261	6676.874	7.962940
Sum128Base_Basic	917.592	285.687	0.340714
Sum128Base	916.619	285.990	0.341076
Sum128Traits	913.789	286.876	0.342133
Sum256Base_Basic	307.447	852.647	1.016880
Sum256Base	306.752	854.581	1.019186
Sum256Traits	39.227	6682.661	7.969842

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	312.653	838.449
SumBcl	43.904	5970.844	7.121295
SumTraits	43.234	6063.396	7.231680
Sum128Base_Basic	974.167	269.095	0.320944
Sum128Base	978.156	267.998	0.319636
Sum128Traits	978.642	267.865	0.319477
Sum256Base_Basic	360.756	726.653	0.866663
Sum256Base	360.425	727.319	0.867458
Sum256Traits	42.613	6151.688	7.336983

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	163.305	1605.245
SumBcl	636.824	411.643	0.256436
SumTraits	67.252	3897.953	2.428261
Sum128Base_Basic	938.351	279.367	0.174034
Sum128Base	934.412	280.544	0.174767
Sum128Traits	933.434	280.838	0.174950
Sum256Base_Basic	289.871	904.347	0.563370
Sum256Base	289.142	906.627	0.564791
Sum256Avx2_ShiftVar	67.819	3865.372	2.407964
Sum256Avx2_Mapping	286.233	915.841	0.570530
Sum256Avx2_MappingFix	285.911	916.872	0.571173
Sum256Avx2_Mod	287.124	912.998	0.568760
Sum256Traits	66.307	3953.505	2.462867

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 5.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	161.515	1623.036
SumBcl	22.391	11707.458	7.213307
SumTraits	22.556	11621.797	7.160529
Sum128Base_Basic	843.242	310.876	0.191540
Sum128Base	844.295	310.489	0.191301
Sum128Traits	843.510	310.777	0.191479
Sum256Base_Basic	262.696	997.898	0.614834
Sum256Base	262.364	999.160	0.615612
Sum256Traits	24.852	10548.302	6.499117

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	311.844	840.625
SumBcl	39.280	6673.741	7.939025
SumTraits	39.624	6615.815	7.870117
Sum128Base_Basic	896.072	292.548	0.348013
Sum128Base	899.651	291.384	0.346628
Sum128Traits	895.901	292.604	0.348079
Sum256Base_Basic	284.134	922.607	1.097525
Sum256Base	284.797	920.459	1.094970
Sum256Traits	39.238	6680.950	7.947601

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	311.207	842.346
SumBcl	48.780	5374.043	6.379856
SumTraits	40.275	6508.902	7.727116
Sum128Base_Basic	996.567	263.047	0.312279
Sum128Base	998.365	262.573	0.311717
Sum128Traits	998.630	262.504	0.311634
Sum256Base_Basic	361.179	725.801	0.861643
Sum256Base	361.080	725.999	0.861878
Sum256Traits	40.918	6406.604	7.605672

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	166.455	1574.865
SumBcl	456.214	574.608	0.364862
SumTraits	61.165	4285.841	2.721401
Sum128Base_Basic	844.941	310.251	0.197002
Sum128Base	849.762	308.491	0.195884
Sum128Traits	851.214	307.965	0.195550
Sum256Base_Basic	286.028	916.498	0.581953
Sum256Base	288.117	909.852	0.577733
Sum256Avx2_ShiftVar	62.271	4209.736	2.673077
Sum256Avx2_Mapping	52.780	4966.739	3.153754
Sum256Avx2_MappingFix	60.236	4351.977	2.763396
Sum256Avx2_Mod	134.884	1943.473	1.234057
Sum256Traits	63.525	4126.599	2.620287

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.14
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.14\
RuntimeInformation.FrameworkDescription:	.NET 6.0.14
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	162.433	1613.860
SumBcl	26.893	9747.773	6.040035
SumTraits	24.401	10743.057	6.656745
Sum128Base_Basic	842.486	311.155	0.192802
Sum128Base	844.589	310.381	0.192322
Sum128Traits	844.890	310.270	0.192253
Sum256Base_Basic	272.213	963.010	0.596712
Sum256Base	276.045	949.642	0.588429
Sum256Traits	22.942	11426.271	7.080087

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	313.632	835.832
SumBcl	39.867	6575.515	7.867027
SumTraits	39.664	6609.167	7.907289
Sum128Base_Basic	905.838	289.394	0.346234
Sum128Base	899.317	291.492	0.348745
Sum128Traits	897.429	292.106	0.349479
Sum256Base_Basic	295.535	887.016	1.061237
Sum256Base	295.536	887.012	1.061232
Sum256Traits	39.174	6691.724	8.006061

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	311.547	841.426
SumBcl	48.311	5426.156	6.448760
SumTraits	40.242	6514.219	7.741877
Sum128Base_Basic	994.905	263.486	0.313143
Sum128Base	993.587	263.836	0.313558
Sum128Traits	993.689	263.809	0.313526
Sum256Base_Basic	360.918	726.326	0.863208
Sum256Base	360.712	726.741	0.863702
Sum256Traits	41.086	6380.350	7.582779

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	165.262	1586.231
SumBcl	472.403	554.916	0.349833
SumTraits	56.212	4663.472	2.939971
Sum128Base_Basic	844.408	310.447	0.195714
Sum128Base	840.851	311.760	0.196542
Sum128Traits	841.994	311.337	0.196275
Sum256Base_Basic	267.753	979.053	0.617220
Sum256Base	267.413	980.296	0.618003
Sum256Avx2_ShiftVar	57.152	4586.773	2.891617
Sum256Avx2_Mapping	50.295	5212.125	3.285855
Sum256Avx2_MappingFix	60.267	4349.683	2.742150
Sum256Avx2_Mod	125.892	2082.290	1.312728
Sum256Traits	59.954	4372.398	2.756471

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.3
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.3\
RuntimeInformation.FrameworkDescription:	.NET 7.0.3
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	157.311	1666.405
SumBcl	23.799	11014.849	6.609947
SumTraits	24.057	10896.887	6.539158
Sum128Bcl	42.720	6136.323	3.682372
Sum128Base_Basic	438.478	597.850	0.358767
Sum128Base	42.929	6106.398	3.664414
Sum128Traits	42.803	6124.456	3.675250
Sum256Bcl	23.326	11238.055	6.743891
Sum256Base_Basic	278.241	942.149	0.565378
Sum256Base	23.403	11201.511	6.721961
Sum256Traits	25.515	10274.098	6.165426

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	311.675	841.082
SumBcl	39.184	6690.143	7.954215
SumTraits	39.580	6623.226	7.874654
Sum128Bcl	78.009	3360.445	3.995386
Sum128Base_Basic	468.576	559.448	0.665154
Sum128Base	78.286	3348.546	3.981238
Sum128Traits	78.162	3353.853	3.987548
Sum256Bcl	39.112	6702.414	7.968804
Sum256Base_Basic	295.090	888.353	1.056204
Sum256Base	39.309	6668.810	7.928851
Sum256Traits	39.228	6682.584	7.945227

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	312.993	837.539
SumBcl	43.098	6082.452	7.262294
SumTraits	42.875	6114.117	7.300101
Sum128Bcl	78.720	3330.075	3.976025
Sum128Base_Basic	542.862	482.893	0.576561
Sum128Base	78.717	3330.219	3.976197
Sum128Traits	78.891	3322.856	3.967406
Sum256Bcl	43.929	5967.401	7.124926
Sum256Base_Basic	351.518	745.749	0.890405
Sum256Base	40.595	6457.591	7.710200
Sum256Traits	41.123	6374.697	7.611227

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	156.772	1672.141
SumBcl	260.104	1007.841	0.602725
SumTraits	51.391	5100.969	3.050562
Sum128Bcl	417.858	627.352	0.375179
Sum128Base_Basic	437.441	599.267	0.358383
Sum128Base	417.426	628.002	0.375568
Sum128Traits	419.331	625.148	0.373861
Sum256Bcl	259.732	1009.285	0.603589
Sum256Base_Basic	278.151	942.453	0.563621
Sum256Base	261.162	1003.760	0.600284
Sum256Avx2_ShiftVar	51.178	5122.246	3.063286
Sum256Avx2_Mapping	44.172	5934.664	3.549142
Sum256Avx2_MappingFix	52.698	4974.472	2.974913
Sum256Avx2_Mod	135.395	1936.135	1.157878
Sum256Traits	57.661	4546.276	2.718836

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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

