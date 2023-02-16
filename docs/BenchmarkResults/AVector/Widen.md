# Benchmark - Widen
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 4.5

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.4614.0
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	156.859	1671.207
SumWidenBcl	46.440	5644.769	3.377660
SumWidenVectorBase	48.019	5459.142	3.266586
SumWidenVectorTraits	47.270	5545.621	3.318333

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	165.845	1580.654
SumWidenBcl	11.070	23680.787	14.981640
SumWidenVectorBase	11.729	22350.203	14.139847
SumWidenVectorTraits	11.410	22975.437	14.535401

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194
SumWidenScalar	316.593	828.016
SumWidenBcl	46.704	5612.840	6.778661
SumWidenVectorBase	55.745	4702.540	5.679286
SumWidenVectorTraits	42.719	6136.459	7.411039

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	147.226	1780.551
SumWidenBcl	47.398	5530.642	3.106140
SumWidenVectorBase	46.763	5605.853	3.148380
SumWidenVectorTraits	47.716	5493.843	3.085473

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	167.516	1564.891
SumWidenBcl	11.278	23243.735	14.853266
SumWidenVectorBase	12.016	21815.871	13.940829
SumWidenVectorTraits	11.387	23021.467	14.711231

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194
SumWidenScalar	316.078	829.366
SumWidenBcl	45.061	5817.518	7.014418
SumWidenVectorBase	44.038	5952.646	7.177348
SumWidenVectorTraits	43.936	5966.507	7.194061

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	140.648	1863.832
SumWidenBcl	47.473	5521.920	2.962671
SumWidenVectorBase	48.586	5395.442	2.894811
SumWidenVectorTraits	36.967	7091.232	3.804652
SumWidenVector128Traits	1180.883	221.990	0.119104
SumWidenVector256Traits	35.236	7439.578	3.991550

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	164.929	1589.435
SumWidenBcl	11.005	23820.303	14.986648
SumWidenVectorBase	10.939	23964.191	15.077176
SumWidenVectorTraits	7.794	33634.796	21.161480
SumWidenVector128Traits	400.793	654.063	0.411506
SumWidenVector256Traits	7.852	33385.042	21.004346

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	313.778	835.443
SumWidenBcl	40.463	6478.539	7.754611
SumWidenVectorBase	40.285	6507.286	7.789021
SumWidenVectorTraits	41.268	6352.188	7.603373
SumWidenVector128Traits	1238.303	211.696	0.253394
SumWidenVector256Traits	41.774	6275.256	7.511288

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 5

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	157.104	1668.600
SumWidenBcl	46.627	5622.206	3.369415
SumWidenVectorBase	47.087	5567.224	3.336464
SumWidenVectorTraits	35.483	7387.902	4.427606
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1157.551	226.464	0.135721
SumWidenVector256Traits	34.760	7541.595	4.519714

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	166.415	1575.239
SumWidenBcl	11.024	23779.485	15.095792
SumWidenVectorBase	11.173	23461.893	14.894177
SumWidenVectorTraits	8.004	32752.695	20.792202
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	397.043	660.241	0.419137
SumWidenVector256Traits	7.889	33228.841	21.094472

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	316.885	827.254
SumWidenBcl	43.831	5980.744	7.229635
SumWidenVectorBase	44.953	5831.571	7.049311
SumWidenVectorTraits	44.895	5839.047	7.058349
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1215.477	215.672	0.260708
SumWidenVector256Traits	45.846	5717.963	6.911980

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 6

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.12
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.12\
RuntimeInformation.FrameworkDescription:	.NET 6.0.12
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.12/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	165.156	1587.255
SumWidenBcl	47.413	5528.908	3.483313
SumWidenVectorBase	47.632	5503.553	3.467339
SumWidenVectorTraits	36.800	7123.460	4.487910
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1153.148	227.329	0.143221
SumWidenVector256Traits	35.222	7442.562	4.688950

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	156.726	1672.631
SumWidenBcl	11.005	23821.254	14.241789
SumWidenVectorBase	11.005	23820.188	14.241152
SumWidenVectorTraits	7.947	32984.656	19.720227
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	396.216	661.620	0.395556
SumWidenVector256Traits	7.914	33124.261	19.803691

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	313.768	835.470
SumWidenBcl	43.809	5983.763	7.162154
SumWidenVectorBase	43.815	5983.019	7.161264
SumWidenVectorTraits	44.133	5939.882	7.109631
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1208.067	216.995	0.259728
SumWidenVector256Traits	43.706	5997.929	7.179110

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 7

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.1
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.1\
RuntimeInformation.FrameworkDescription:	.NET 7.0.1
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	161.189	1626.317
SumWidenBcl	32.314	8112.521	4.988277
SumWidenVectorBase	32.673	8023.297	4.933415
SumWidenVectorTraits	32.705	8015.412	4.928566
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	59.201	4428.059	2.722752
SumWidenVector256Traits	32.518	8061.437	4.956866

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	157.057	1669.104
SumWidenBcl	7.577	34595.723	20.727120
SumWidenVectorBase	7.594	34521.067	20.682392
SumWidenVectorTraits	7.607	34459.971	20.645788
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	14.827	17680.656	10.592902
SumWidenVector256Traits	7.704	34028.644	20.387370

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	312.754	838.180
SumWidenBcl	43.831	5980.830	7.135492
SumWidenVectorBase	43.678	6001.722	7.160418
SumWidenVectorTraits	43.587	6014.336	7.175467
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	78.348	3345.880	3.991837
SumWidenVector256Traits	43.417	6037.832	7.203500

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	350.379	748.172
SumWidenBcl	74.350	3525.804	4.712560
SumWidenVectorBase	74.374	3524.667	4.711041
SumWidenVectorTraits	80.389	3260.950	4.358558
SumWidenVector128Traits	1154.166	227.129	0.303578
SumWidenVector256Traits	2374.771	110.387	0.147542

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	353.422	741.730
SumWidenBcl	18.316	14312.571	19.296198
SumWidenVectorBase	18.288	14333.820	19.324846
SumWidenVectorTraits	19.829	13220.296	17.823593
SumWidenVector128Traits	615.439	425.946	0.574260
SumWidenVector256Traits	669.484	391.561	0.527903

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	290.736	901.658
SumWidenBcl	74.665	3510.924	3.893855
SumWidenVectorBase	80.397	3260.611	3.616241
SumWidenVectorTraits	80.407	3260.202	3.615787
SumWidenVector128Traits	1328.922	197.261	0.218776
SumWidenVector256Traits	2341.861	111.938	0.124147

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 5

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	353.395	741.788
SumWidenBcl	77.661	3375.503	4.550497
SumWidenVectorBase	82.875	3163.139	4.264211
SumWidenVectorTraits	92.005	2849.229	3.841031
SumWidenVector128_Arm	91.021	2880.036	3.882562
SumWidenVector128Traits	90.542	2895.282	3.903115
SumWidenVector256Traits	1079.931	242.742	0.327239

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	352.817	743.002
SumWidenBcl	20.302	12912.478	17.378798
SumWidenVectorBase	19.125	13707.138	18.448323
SumWidenVectorTraits	22.006	11912.591	16.033058
SumWidenVector128_Arm	22.718	11538.900	15.530110
SumWidenVector128Traits	22.632	11582.965	15.589417
SumWidenVector256Traits	447.383	585.950	0.788625

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	296.563	883.939
SumWidenBcl	78.862	3324.082	3.760531
SumWidenVectorBase	79.272	3306.913	3.741108
SumWidenVectorTraits	91.000	2880.692	3.258925
SumWidenVector128_Arm	663.883	394.865	0.446710
SumWidenVector128_ArmB64	94.760	2766.386	3.129611
SumWidenVector128Traits	93.997	2788.862	3.155038
SumWidenVector256Traits	1066.724	245.747	0.278013

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 6

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	352.005	744.717
SumWidenBcl	84.281	3110.375	4.176584
SumWidenVectorBase	77.024	3403.403	4.570059
SumWidenVectorTraits	88.691	2955.713	3.968906
SumWidenVector128_Arm	89.119	2941.505	3.949827
SumWidenVector128Traits	88.708	2955.129	3.968121
SumWidenVector256Traits	1052.390	249.094	0.334481

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	309.897	845.908
SumWidenBcl	18.857	13901.336	16.433627
SumWidenVectorBase	21.237	12343.645	14.592185
SumWidenVectorTraits	21.714	12072.590	14.271754
SumWidenVector128_Arm	21.802	12023.762	14.214032
SumWidenVector128Traits	21.679	12092.220	14.294960
SumWidenVector256Traits	427.307	613.480	0.725232

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	316.990	826.978
SumWidenBcl	77.962	3362.465	4.065969
SumWidenVectorBase	84.766	3092.558	3.739590
SumWidenVectorTraits	91.830	2854.679	3.451942
SumWidenVector128_Arm	659.279	397.622	0.480813
SumWidenVector128_ArmB64	90.900	2883.866	3.487235
SumWidenVector128Traits	91.381	2868.701	3.468898
SumWidenVector256Traits	1044.119	251.067	0.303596

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 7

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	211.226	1241.061
SumWidenBcl	70.365	3725.488	3.001857
SumWidenVectorBase	70.283	3729.819	3.005346
SumWidenVectorTraits	70.358	3725.881	3.002173
SumWidenVector128_Arm	70.007	3744.554	3.017219
SumWidenVector128Traits	70.539	3716.321	2.994470
SumWidenVector256Traits	2217.671	118.207	0.095247

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	215.669	1215.494
SumWidenBcl	16.977	15441.281	12.703713
SumWidenVectorBase	17.084	15344.368	12.623981
SumWidenVectorTraits	17.050	15375.171	12.649324
SumWidenVector128_Arm	16.994	15425.289	12.690556
SumWidenVector128Traits	17.142	15292.172	12.581039
SumWidenVector256Traits	1514.197	173.124	0.142431

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	211.727	1238.120
SumWidenBcl	73.655	3559.079	2.874583
SumWidenVectorBase	73.515	3565.863	2.880061
SumWidenVectorTraits	73.690	3557.398	2.873224
SumWidenVector128_Arm	457.443	573.064	0.462850
SumWidenVector128_ArmB64	73.443	3569.344	2.882873
SumWidenVector128Traits	73.475	3567.777	2.881608
SumWidenVector256Traits	2261.126	115.935	0.093638

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

