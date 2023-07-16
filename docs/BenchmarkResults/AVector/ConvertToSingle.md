# Benchmark - ConvertToSingle
([← Back](README.md))

- `ConvertToInt32`: Convert to a vector whose elements are of type Int32 (转换为元素类型是Int32的向量).
  Mnemonic: `rt[i] := (Int32)(value[i])` .
- `ConvertToSingle`: Convert to a vector whose elements are of type Single (转换为元素类型是Single的向量).
  Mnemonic: `rt[i] := (Single)(value[i])` .
- `ConvertToUInt32`: Convert to a vector whose elements are of type UInt32 (转换为元素类型是UInt32的向量).
  Mnemonic: `rt[i] := (UInt32)(value[i])` .

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9167.0
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
SumScalar	162.896	1609.267
SumBcl	26.276	9976.702	6.199530
SumTraits	24.477	10709.915	6.655150

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	313.111	837.223
SumBcl	39.590	6621.449	7.908825
SumTraits	39.419	6650.155	7.943112

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	314.149	834.459
SumBcl	53.650	4886.227	5.855565
SumTraits	53.622	4888.717	5.858548

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	160.402	1634.297
SumBcl	662.890	395.456	0.241973
SumTraits	644.249	406.899	0.248975

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
SumScalar	165.459	1584.344
SumBcl	26.996	9710.505	6.129039
SumTraits	24.715	10606.839	6.694784

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	311.020	842.852
SumBcl	39.032	6716.212	7.968441
SumTraits	39.126	6699.975	7.949176

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	319.681	820.018
SumBcl	49.066	5342.710	6.515357
SumTraits	49.496	5296.235	6.458681

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	175.437	1494.230
SumBcl	663.063	395.353	0.264586
SumTraits	648.935	403.960	0.270347

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
SumScalar	161.511	1623.075
SumBcl	24.989	10490.205	6.463169
SumTraits	22.989	11402.815	7.025442
Sum128Base_Basic	933.529	280.810	0.173011
Sum128Base	931.808	281.328	0.173330
Sum128Traits	932.431	281.140	0.173215
Sum256Base_Basic	306.083	856.446	0.527669
Sum256Base	318.150	823.965	0.507657
Sum256Traits	24.662	10629.327	6.548884

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	313.056	837.372
SumBcl	39.381	6656.660	7.949467
SumTraits	39.496	6637.186	7.926212
Sum128Base_Basic	919.292	285.159	0.340540
Sum128Base	913.811	286.869	0.342583
Sum128Traits	912.631	287.240	0.343026
Sum256Base_Basic	322.439	813.002	0.970898
Sum256Base	324.535	807.752	0.964628
Sum256Traits	39.032	6716.138	8.020498

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	310.751	843.583
SumBcl	46.816	5599.424	6.637669
SumTraits	45.516	5759.441	6.827357
Sum128Base_Basic	973.633	269.243	0.319166
Sum128Base	974.073	269.121	0.319022
Sum128Traits	974.702	268.948	0.318816
Sum256Base_Basic	369.902	708.684	0.840089
Sum256Base	369.554	709.352	0.840880
Sum256Traits	42.085	6228.928	7.383896

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	157.543	1663.953
SumBcl	643.892	407.124	0.244673
SumTraits	67.895	3860.996	2.320375
Sum128Base_Basic	932.195	281.212	0.169002
Sum128Base	932.235	281.199	0.168995
Sum128Traits	932.135	281.230	0.169013
Sum256Base_Basic	309.698	846.450	0.508698
Sum256Base	309.964	845.724	0.508262
Sum256Avx2_ShiftVar	70.355	3726.023	2.239259
Sum256Avx2_Mapping	307.228	853.257	0.512789
Sum256Avx2_MappingFix	305.449	858.224	0.515774
Sum256Avx2_Mod	305.026	859.414	0.516489
Sum256Traits	68.122	3848.131	2.312643

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
SumScalar	158.487	1654.039
SumBcl	23.565	11124.349	6.725567
SumTraits	22.426	11689.450	7.067216
Sum128Base_Basic	840.465	311.904	0.188571
Sum128Base	840.004	312.075	0.188674
Sum128Traits	839.908	312.110	0.188696
Sum256Base_Basic	296.406	884.409	0.534697
Sum256Base	288.424	908.884	0.549494
Sum256Traits	26.579	9862.939	5.962943

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	317.653	825.253
SumBcl	39.591	6621.341	8.023412
SumTraits	40.237	6514.974	7.894522
Sum128Base_Basic	901.477	290.794	0.352370
Sum128Base	906.311	289.243	0.350490
Sum128Traits	899.172	291.539	0.353273
Sum256Base_Basic	304.904	859.759	1.041813
Sum256Base	306.123	856.337	1.037666
Sum256Traits	39.057	6711.816	8.133045

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	311.001	842.904
SumBcl	47.934	5468.863	6.488121
SumTraits	41.240	6356.525	7.541220
Sum128Base_Basic	991.638	264.354	0.313623
Sum128Base	992.598	264.099	0.313320
Sum128Traits	992.527	264.118	0.313343
Sum256Base_Basic	368.942	710.528	0.842953
Sum256Base	369.379	709.689	0.841957
Sum256Traits	39.721	6599.595	7.829592

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	157.855	1660.660
SumBcl	471.741	555.695	0.334623
SumTraits	57.398	4567.142	2.750197
Sum128Base_Basic	840.875	311.752	0.187728
Sum128Base	840.377	311.936	0.187839
Sum128Traits	840.055	312.056	0.187911
Sum256Base_Basic	260.328	1006.976	0.606371
Sum256Base	260.937	1004.625	0.604956
Sum256Avx2_ShiftVar	59.531	4403.513	2.651665
Sum256Avx2_Mapping	47.714	5494.071	3.308366
Sum256Avx2_MappingFix	59.396	4413.471	2.657661
Sum256Avx2_Mod	112.399	2332.261	1.404418
Sum256Traits	56.444	4644.279	2.796647

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
SumScalar	162.635	1611.854
SumBcl	22.750	11522.607	7.148669
SumTraits	24.752	10591.003	6.570698
Sum128Base_Basic	869.672	301.428	0.187007
Sum128Base	846.728	309.596	0.192075
Sum128Traits	846.427	309.707	0.192143
Sum256Base_Basic	267.479	980.055	0.608030
Sum256Base	268.572	976.067	0.605556
Sum256Traits	22.343	11732.708	7.279016

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	310.563	844.092
SumBcl	39.056	6711.954	7.951684
SumTraits	39.071	6709.419	7.948681
Sum128Base_Basic	893.046	293.539	0.347757
Sum128Base	896.465	292.420	0.346431
Sum128Traits	896.164	292.518	0.346547
Sum256Base_Basic	282.608	927.588	1.098918
Sum256Base	282.568	927.721	1.099076
Sum256Traits	39.201	6687.241	7.922407

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	311.295	842.108
SumBcl	48.526	5402.151	6.415036
SumTraits	41.995	6242.319	7.412734
Sum128Base_Basic	992.579	264.104	0.313623
Sum128Base	991.533	264.383	0.313953
Sum128Traits	991.862	264.295	0.313849
Sum256Base_Basic	359.354	729.487	0.866263
Sum256Base	359.264	729.670	0.866481
Sum256Traits	41.263	6352.967	7.544128

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	157.804	1661.196
SumBcl	469.579	558.253	0.336055
SumTraits	57.089	4591.813	2.764162
Sum128Base_Basic	840.268	311.976	0.187802
Sum128Base	840.251	311.983	0.187806
Sum128Traits	840.015	312.071	0.187859
Sum256Base_Basic	286.530	914.894	0.550744
Sum256Base	284.862	920.249	0.553968
Sum256Avx2_ShiftVar	56.142	4669.314	2.810815
Sum256Avx2_Mapping	53.493	4900.498	2.949982
Sum256Avx2_MappingFix	62.584	4188.675	2.521482
Sum256Avx2_Mod	116.774	2244.890	1.351370
Sum256Traits	57.989	4520.570	2.721275

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
SumScalar	162.084	1617.331
SumBcl	23.152	11322.949	7.001008
SumTraits	22.971	11411.745	7.055911
Sum128Bcl	42.609	6152.300	3.803983
Sum128Base_Basic	436.511	600.543	0.371317
Sum128Base	42.626	6149.790	3.802430
Sum128Traits	42.570	6157.963	3.807484
Sum256Bcl	23.150	11323.859	7.001571
Sum256Base_Basic	263.653	994.277	0.614764
Sum256Base	23.120	11338.577	7.010671
Sum256Traits	23.088	11354.037	7.020230

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	311.325	842.027
SumBcl	39.020	6718.190	7.978588
SumTraits	39.127	6699.785	7.956731
Sum128Bcl	77.859	3366.912	3.998578
Sum128Base_Basic	468.342	559.728	0.664739
Sum128Base	78.771	3327.907	3.952255
Sum128Traits	78.931	3321.165	3.944249
Sum256Bcl	39.419	6650.188	7.897828
Sum256Base_Basic	285.648	917.717	1.089890
Sum256Base	39.583	6622.669	7.865147
Sum256Traits	39.212	6685.339	7.939574

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	311.185	842.405
SumBcl	40.830	6420.330	7.621429
SumTraits	41.222	6359.293	7.548973
Sum128Bcl	79.355	3303.418	3.921413
Sum128Base_Basic	545.277	480.754	0.570692
Sum128Base	79.185	3310.534	3.929860
Sum128Traits	78.102	3356.421	3.984332
Sum256Bcl	40.848	6417.482	7.618048
Sum256Base_Basic	349.826	749.356	0.889544
Sum256Base	39.991	6555.101	7.781412
Sum256Traits	40.057	6544.327	7.768623

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	155.853	1681.990
SumBcl	248.555	1054.673	0.627039
SumTraits	50.773	5163.094	3.069634
Sum128Bcl	416.742	629.032	0.373981
Sum128Base_Basic	436.410	600.683	0.357126
Sum128Base	416.364	629.603	0.374320
Sum128Traits	416.462	629.455	0.374232
Sum256Bcl	247.672	1058.434	0.629275
Sum256Base_Basic	267.119	981.375	0.583460
Sum256Base	248.051	1056.814	0.628311
Sum256Avx2_ShiftVar	49.857	5257.925	3.126014
Sum256Avx2_Mapping	43.973	5961.469	3.544295
Sum256Avx2_MappingFix	52.270	5015.206	2.981709
Sum256Avx2_Mod	107.720	2433.566	1.446837
Sum256Traits	51.245	5115.509	3.041342

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

