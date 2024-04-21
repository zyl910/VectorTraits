﻿# Benchmark - YShuffleG2
([← Back](README.md))

See [Group](YShuffleG2_Group.md)

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	241.016	1087.661
SumBase	238.319	1099.972	1.011319
SumTraits	239.835	1093.016	1.004923

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	362.397	723.362
SumBase	341.442	767.755	1.061370
SumTraits	349.356	750.364	1.037329

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	518.770	505.318
SumBase	501.293	522.936	1.034865
SumTraits	505.912	518.161	1.025416

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	234.734	1116.768
SumBase	233.304	1123.616	1.006132
SumTraits	233.051	1124.834	1.007222

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	237.959	1101.637
SumBase	239.538	1094.372	0.993406
SumTraits	237.007	1106.062	1.004017

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	349.618	749.801
SumBase	349.839	749.328	0.999369
SumTraits	338.550	774.314	1.032692

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	499.054	525.282
SumBase	502.607	521.568	0.992931
SumTraits	503.187	520.967	0.991787

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	229.434	1142.570
SumBase	229.576	1141.862	0.999380
SumTraits	232.088	1129.501	0.988562

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	237.332	1104.544
SumBase	241.663	1084.752	0.982081
SumTraits	10.086	25990.945	23.530931
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.103	25946.541	23.490729

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	364.330	719.524
SumBase	339.979	771.060	1.071625
SumTraits	23.403	11201.451	15.567866
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	23.718	11052.503	15.360857
Sum256Traits	23.509	11150.785	15.497450

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	520.828	503.321
SumBase	504.887	519.213	1.031573
SumTraits	41.894	6257.356	12.432128
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	41.438	6326.099	12.568707

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	232.619	1126.924
SumBase	233.072	1124.734	0.998057
SumTraits	5.124	51164.475	45.401902
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	5.101	51387.516	45.599822

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	234.070	1119.938
SumBase	237.085	1105.697	0.987284
SumTraits	10.127	25886.263	23.114012
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.135	25864.203	23.094314

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	339.243	772.732
SumBase	347.716	753.903	0.975634
SumTraits	23.686	11067.433	14.322473
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	23.283	11258.907	14.570261
Sum256Traits	24.005	10920.510	14.132338

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	502.262	521.927
SumBase	515.448	508.575	0.974418
SumTraits	41.717	6283.843	12.039703
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	40.895	6410.146	12.281697

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	235.630	1112.525
SumBase	232.572	1127.150	1.013145
SumTraits	5.131	51085.822	45.918797
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	5.031	52103.208	46.833280

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	232.340	1128.276
SumBase	235.134	1114.873	0.988121
SumTraits	9.538	27485.516	24.360640
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.280	25501.364	22.602070

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	337.422	776.903
SumBase	346.158	757.296	0.974762
SumTraits	17.229	15214.935	19.584091
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	17.304	15149.355	19.499678
Sum256Traits	17.560	14928.860	19.215866

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	499.988	524.301
SumBase	508.883	515.136	0.982520
SumTraits	34.463	7606.608	14.508104
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	34.153	7675.571	14.639638

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	228.522	1147.130
SumBase	231.566	1132.048	0.986852
SumTraits	4.264	61471.950	53.587594
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4.259	61552.383	53.657711

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	226.569	1157.015
SumBase	229.873	1140.386	0.985627
SumTraits	9.667	27117.640	23.437591
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.344	25342.257	21.903140

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	328.806	797.260
SumBase	340.442	770.010	0.965821
SumTraits	17.040	15384.067	19.296176
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	16.951	15464.470	19.397025
Sum256Traits	17.026	15396.595	19.311890

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	482.200	543.642
SumBase	506.925	517.126	0.951226
SumTraits	38.959	6728.730	12.377144
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	39.627	6615.310	12.168515

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	202.211	1296.387
SumBase	203.720	1286.785	0.992594
SumTraits	4.249	61697.931	47.592226
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4.265	61469.846	47.416287

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
# Sum512Base	-8174
SumScalar	229.587	1141.805
SumBase	232.481	1127.591	0.987552
SumTraits	6.844	38304.855	33.547643
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.801	38544.468	33.757498
Sum512Base	213.834	1225.925	1.073673
Sum512Traits	8.723	30051.706	26.319481

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
# Sum512Base	2077257973
SumScalar	259.153	1011.540
SumBase	259.452	1010.376	0.998849
SumTraits	14.860	17640.637	17.439385
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	14.889	17606.166	17.405308
Sum256Traits	14.725	17803.067	17.599962
Sum512Base	237.573	1103.425	1.090837
Sum512Traits	14.751	17771.026	17.568287

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
# Sum512Base	7080891345787607929
SumScalar	486.055	539.330
SumBase	486.995	538.289	0.998070
SumTraits	36.794	7124.596	13.210091
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	36.755	7132.190	13.224171
Sum512Base	308.844	848.791	1.573788
Sum512Traits	33.740	7769.455	14.405759

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
# Sum512Base	117
SumScalar	212.562	1233.262
SumBase	216.255	1212.199	0.982921
SumTraits	4.579	57249.902	46.421533
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4.572	57331.397	46.487614
Sum512Base	213.696	1226.713	0.994690
Sum512Traits	4.274	61341.683	49.739386

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	427.146	613.710
SumBase	431.536	607.467	0.989827
SumTraits	431.881	606.983	0.989038

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	524.372	499.920
SumBase	536.235	488.861	0.977878
SumTraits	535.457	489.571	0.979298

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	522.420	501.788
SumBase	547.174	479.088	0.954761
SumTraits	549.163	477.352	0.951302

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	377.958	693.580
SumBase	382.300	685.702	0.988641
SumTraits	380.680	688.620	0.992848

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	426.192	615.084
SumBase	426.291	614.942	0.999769
SumTraits	426.876	614.098	0.998397

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	524.053	500.224
SumBase	525.141	499.188	0.997928
SumTraits	524.561	499.740	0.999031

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	525.398	498.944
SumBase	526.146	498.234	0.998578
SumTraits	525.781	498.580	0.999272

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	378.323	692.910
SumBase	378.828	691.988	0.998669
SumTraits	378.044	693.421	1.000738

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	426.442	614.723
SumBase	426.058	615.277	1.000901
SumTraits	21.733	12062.124	19.622042
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	22.040	11894.025	19.348587

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	523.982	500.292
SumBase	524.343	499.948	0.999312
SumTraits	42.383	6185.124	12.363038
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	42.484	6170.363	12.333534
Sum256Traits	42.421	6179.582	12.351961

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	524.686	499.621
SumBase	523.011	501.221	1.003202
SumTraits	85.518	3065.379	6.135411
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	85.690	3059.214	6.123071

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	378.475	692.633
SumBase	377.942	693.610	1.001410
SumTraits	9.946	26356.467	38.052569
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	9.942	26368.652	38.070161

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	427.652	612.985
SumBase	433.750	604.367	0.985941
SumTraits	21.227	12349.700	20.146826
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	21.264	12327.884	20.111235

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	524.185	500.098
SumBase	533.292	491.558	0.982923
SumTraits	43.571	6016.417	12.030477
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	43.533	6021.792	12.041225
Sum256Traits	43.581	6015.130	12.027902

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	502.400	521.783
SumBase	521.354	502.814	0.963645
SumTraits	85.368	3070.744	5.885094
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	85.367	3070.792	5.885185

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	378.792	692.053
SumBase	381.841	686.527	0.992014
SumTraits	9.979	26269.727	37.959116
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	9.964	26309.214	38.016173

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	427.064	613.828
SumBase	566.309	462.899	0.754118
SumTraits	12.595	20813.621	33.907880
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	13.572	19315.244	31.466845

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	524.020	500.256
SumBase	813.286	322.327	0.644324
SumTraits	27.452	9549.107	19.088450
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	29.452	8900.803	17.792505
Sum256Traits	30.499	8595.103	17.181417

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	503.059	521.100
SumBase	1101.816	237.920	0.456572
SumTraits	50.403	5200.986	9.980786
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	49.613	5283.821	10.139748

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	379.123	691.449
SumBase	448.228	584.845	0.845825
SumTraits	5.846	44842.162	64.852440
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.480	40455.310	58.508008

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	346.753	755.996
SumBase	347.276	754.857	0.998494
SumTraits	13.672	19174.068	25.362670
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	16.196	16185.459	21.409461

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	446.989	586.467
SumBase	447.020	586.425	0.999929
SumTraits	26.951	9726.706	16.585266
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	26.304	9965.984	16.993265
Sum256Traits	28.098	9329.745	15.908398

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	499.000	525.338
SumBase	498.637	525.721	1.000729
SumTraits	51.738	5066.715	9.644668
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	53.072	4939.400	9.402320

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	299.881	874.159
SumBase	312.870	837.868	0.958484
SumTraits	5.753	45567.330	52.127023
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.513	40250.872	46.045229

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	641.103	408.895
SumBase	640.251	409.439	1.001331
SumTraits	640.067	409.557	1.001620
Sum128Traits	1039.493	252.184	0.616746
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	736.444	355.959
SumBase	735.713	356.313	1.000993
SumTraits	736.850	355.763	0.999449
Sum128Traits	1492.323	175.662	0.493488
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	674.701	388.533
SumBase	675.857	387.869	0.998289
SumTraits	675.249	388.218	0.999189
Sum128Traits	1294.202	202.553	0.521326
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	527.944	496.537
SumBase	528.167	496.327	0.999577
SumTraits	527.430	497.022	1.000975
Sum128Traits	804.451	325.867	0.656279
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	630.740	415.613
SumBase	631.241	415.284	0.999207
SumTraits	62.493	4194.783	10.092995
Sum128_AdvSimd	91.287	2871.650	6.909427
Sum128Traits	62.333	4205.545	10.118890
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	681.896	384.434
SumBase	685.318	382.514	0.995006
SumTraits	118.382	2214.393	5.760137
Sum128_AdvSimd	160.071	1637.676	4.259964
Sum128Traits	118.879	2205.138	5.736063
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	409.184	640.650
SumBase	407.341	643.549	1.004525
SumTraits	237.001	1106.090	1.726511
Sum128_AdvSimd	309.439	847.159	1.322343
Sum128Traits	244.661	1071.456	1.672451
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	524.769	499.542
SumBase	525.312	499.025	0.998966
SumTraits	30.444	8610.713	17.237231
Sum128_AdvSimd	39.811	6584.690	13.181466
Sum128Traits	29.696	8827.489	17.671182
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	632.232	414.633
SumBase	632.811	414.253	0.999085
SumTraits	46.710	5612.197	13.535350
Sum128_AdvSimd	66.752	3927.137	9.471366
Sum128Traits	46.824	5598.492	13.502296
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	689.889	379.980
SumBase	690.948	379.398	0.998468
SumTraits	93.557	2801.964	7.373977
Sum128_AdvSimd	133.986	1956.504	5.148965
Sum128Traits	106.375	2464.340	6.485445
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	406.872	644.291
SumBase	409.203	640.622	0.994304
SumTraits	187.064	1401.358	2.175038
Sum128_AdvSimd	267.396	980.359	1.521608
Sum128Traits	187.431	1398.616	2.170782
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	524.706	499.601
SumBase	525.524	498.824	0.998444
SumTraits	23.447	11180.317	22.378474
Sum128_AdvSimd	36.156	7250.345	14.512260
Sum128Traits	26.467	9904.450	19.824705
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	461.049	568.581
SumBase	466.132	562.382	0.989097
SumTraits	39.524	6632.605	11.665189
Sum128_AdvSimd	58.778	4459.913	7.843935
Sum128Traits	39.499	6636.736	11.672453
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	698.904	375.079
SumBase	694.756	377.318	1.005970
SumTraits	79.834	3283.621	8.754483
Sum128_AdvSimd	119.910	2186.169	5.828560
Sum128Traits	79.644	3291.444	8.775338
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	358.035	732.174
SumBase	357.831	732.591	1.000569
SumTraits	158.420	1654.739	2.260034
Sum128_AdvSimd	240.744	1088.890	1.487200
Sum128Traits	158.484	1654.073	2.259124
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	373.640	701.595
SumBase	373.734	701.419	0.999749
SumTraits	19.803	13237.627	18.867898
Sum128_AdvSimd	29.540	8874.120	12.648490
Sum128Traits	19.786	13248.838	18.883877
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !

```

