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
SumWidenScalar	162.457	1613.621
SumWidenBcl	47.854	5477.952	3.394820
SumWidenVectorBase	48.302	5427.145	3.363334
SumWidenVectorBase_Ptr	321.066	816.480	0.505992
SumWidenVectorBase_Ref	349.322	750.436	0.465063
SumWidenVectorBase_RefInc	312.565	838.685	0.519754
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	310.424	844.472	0.523340
SumWidenVectorBase256_Ref	295.260	887.841	0.550217
SumWidenVectorTraits	48.757	5376.507	3.331952

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
SumWidenScalar	157.953	1659.633
SumWidenBcl	47.069	5569.393	3.355797
SumWidenVectorBase	46.865	5593.621	3.370395
SumWidenVectorBase_Ptr	326.446	803.025	0.483857
SumWidenVectorBase_Ref	352.857	742.919	0.447640
SumWidenVectorBase_RefInc	315.556	830.736	0.500554
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	308.540	849.627	0.511936
SumWidenVectorBase256_Ref	307.911	851.364	0.512983
SumWidenVectorTraits	46.925	5586.443	3.366070

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
SumWidenScalar	138.863	1887.783
SumWidenBcl	46.906	5588.654	2.960432
SumWidenVectorBase	46.786	5603.044	2.968055
SumWidenVectorBase_Ptr	334.213	784.363	0.415494
SumWidenVectorBase_Ref	343.795	762.501	0.403914
SumWidenVectorBase_RefInc	305.971	856.760	0.453845
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	301.362	869.865	0.460786
SumWidenVectorBase256_Ref	288.783	907.756	0.480858
SumWidenVectorTraits	35.304	7425.424	3.933410
SumWidenVector128Traits	1172.696	223.540	0.118414
SumWidenVector256Traits	34.952	7500.172	3.973005

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
SumWidenScalar	158.007	1659.071
SumWidenBcl	47.063	5570.024	3.357315
SumWidenVectorBase	46.717	5611.336	3.382216
SumWidenVectorBase_Ptr	322.695	812.357	0.489646
SumWidenVectorBase_Ref	352.710	743.229	0.447979
SumWidenVectorBase_RefInc	325.888	804.398	0.484849
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	312.081	839.987	0.506300
SumWidenVectorBase256_Ref	264.901	989.592	0.596474
SumWidenVectorTraits	36.757	7131.718	4.298622
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1157.925	226.391	0.136457
SumWidenVector256Traits	36.152	7251.135	4.370600

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
SumWidenScalar	139.909	1873.675
SumWidenBcl	47.282	5544.270	2.959036
SumWidenVectorBase	47.437	5526.156	2.949368
SumWidenVectorBase_Ptr	319.417	820.696	0.438014
SumWidenVectorBase_Ref	350.267	748.412	0.399435
SumWidenVectorBase_RefInc	303.800	862.883	0.460530
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	309.527	846.918	0.452009
SumWidenVectorBase256_Ref	263.377	995.319	0.531212
SumWidenVectorTraits	38.865	6744.970	3.599862
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1177.094	222.704	0.118860
SumWidenVector256Traits	37.940	6909.381	3.687609

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
SumWidenScalar	124.526	2105.130
SumWidenBcl	32.404	8089.955	3.842971
SumWidenVectorBase	32.415	8087.170	3.841649
SumWidenVectorBase_Ptr	311.868	840.561	0.399292
SumWidenVectorBase_Ref	311.079	842.694	0.400305
SumWidenVectorBase_RefInc	308.999	848.365	0.402999
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	273.757	957.580	0.454879
SumWidenVectorBase256_Ref	273.624	958.043	0.455099
SumWidenVectorTraits	32.799	7992.493	3.796674
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	59.205	4427.740	2.103310
SumWidenVector256Traits	32.655	8027.705	3.813401

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
SumWidenScalar	351.406	745.986
SumWidenBcl	74.676	3510.415	4.705737
SumWidenVectorBase	74.524	3517.587	4.715352
SumWidenVectorBase_Ptr	533.601	491.273	0.658555
SumWidenVectorBase_Ref	491.941	532.877	0.714326
SumWidenVectorBase_RefInc	504.002	520.125	0.697232
SumWidenVectorBase128_Ptr	536.099	488.984	0.655487
SumWidenVectorBase128_Ref	504.167	519.955	0.697003
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	80.601	3252.382	4.359842
SumWidenVector128Traits	1168.159	224.408	0.300820
SumWidenVector256Traits	2359.158	111.118	0.148954

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
SumWidenScalar	350.892	747.079
SumWidenBcl	76.480	3427.614	4.588022
SumWidenVectorBase	81.775	3205.658	4.290923
SumWidenVectorBase_Ptr	538.598	486.715	0.651491
SumWidenVectorBase_Ref	494.690	529.916	0.709317
SumWidenVectorBase_RefInc	513.906	510.101	0.682794
SumWidenVectorBase128_Ptr	548.328	478.079	0.639931
SumWidenVectorBase128_Ref	519.519	504.590	0.675417
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	88.766	2953.196	3.952991
SumWidenVector128_Arm	90.367	2900.890	3.882977
SumWidenVector128Traits	97.391	2691.667	3.602923
SumWidenVector256Traits	1143.079	229.331	0.306971

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
SumWidenScalar	349.202	750.695
SumWidenBcl	75.998	3449.375	4.594911
SumWidenVectorBase	83.848	3126.435	4.164723
SumWidenVectorBase_Ptr	541.647	483.976	0.644704
SumWidenVectorBase_Ref	493.459	531.237	0.707661
SumWidenVectorBase_RefInc	512.612	511.389	0.681221
SumWidenVectorBase128_Ptr	535.869	489.194	0.651655
SumWidenVectorBase128_Ref	517.937	506.131	0.674217
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	87.378	3000.109	3.996443
SumWidenVector128_Arm	87.839	2984.368	3.975475
SumWidenVector128Traits	88.246	2970.612	3.957151
SumWidenVector256Traits	1037.954	252.558	0.336433

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
SumWidenScalar	211.062	1242.026
SumWidenBcl	69.907	3749.874	3.019159
SumWidenVectorBase	69.840	3753.499	3.022077
SumWidenVectorBase_Ptr	478.145	548.252	0.441417
SumWidenVectorBase_Ref	476.124	550.579	0.443291
SumWidenVectorBase_RefInc	479.832	546.325	0.439866
SumWidenVectorBase128_Ptr	489.663	535.356	0.431034
SumWidenVectorBase128_Ref	488.134	537.033	0.432385
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	69.618	3765.467	3.031713
SumWidenVector128_Arm	69.400	3777.313	3.041251
SumWidenVector128Traits	70.218	3733.276	3.005795
SumWidenVector256Traits	2619.923	100.058	0.080560

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

