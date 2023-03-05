# Benchmark - Narrow
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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.6
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.6
SumNarrowScalar	323.177	811.146
SumNarrowBcl	51.617	5078.600	6.261019
SumNarrowVectorBase	49.418	5304.587	6.539622
SumNarrowVectorTraits	145.763	1798.425	2.217142

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	161.906	1619.116
SumNarrowBcl	13.866	18905.511	11.676441
SumNarrowVectorBase	14.143	18534.705	11.447424
SumNarrowVectorTraits	81.282	3225.114	1.991898

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	260.163	1007.613
SumNarrowBcl	84.374	3106.924	3.083450
SumNarrowVectorBase	77.343	3389.379	3.363771
SumNarrowVectorTraits	154.286	1699.073	1.686236

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.6
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.6
SumNarrowScalar	321.535	815.289
SumNarrowBcl	51.448	5095.351	6.249749
SumNarrowVectorBase	48.874	5363.616	6.578792
SumNarrowVectorTraits	127.264	2059.850	2.526528

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	158.401	1654.942
SumNarrowBcl	15.150	17303.474	10.455640
SumNarrowVectorBase	14.938	17548.949	10.603968
SumNarrowVectorTraits	33.197	7896.654	4.771560

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	170.131	1540.832
SumNarrowBcl	74.143	3535.648	2.294636
SumNarrowVectorBase	82.165	3190.445	2.070599
SumNarrowVectorTraits	148.865	1760.957	1.142861

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	324.870	806.920
SumNarrowBcl	51.252	5114.782	6.338647
SumNarrowVectorBase	49.034	5346.153	6.625381
SumNarrowVectorTraits	63.768	4110.908	5.094567
SumNarrowVector128Traits	1409.098	186.037	0.230552
SumNarrowVector256Traits	252.731	1037.244	1.285436

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	183.124	1431.510
SumNarrowBcl	13.172	19901.938	13.902754
SumNarrowVectorBase	13.349	19637.024	13.717695
SumNarrowVectorTraits	25.256	10379.315	7.250604
SumNarrowVector128Traits	366.755	714.766	0.499309
SumNarrowVector256Traits	11.531	22733.407	15.880713

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	169.839	1543.487
SumNarrowBcl	72.530	3614.275	2.341629
SumNarrowVectorBase	71.913	3645.302	2.361731
SumNarrowVectorTraits	46.094	5687.181	3.684631
SumNarrowVector128Traits	966.631	271.194	0.175702
SumNarrowVector256Traits	44.541	5885.496	3.813116

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	319.533	820.398
SumNarrowBcl	45.717	5734.039	6.989340
SumNarrowVectorBase	50.794	5160.936	6.290773
SumNarrowVectorTraits	51.488	5091.396	6.206009
SumNarrowVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	1380.525	189.887	0.231457
SumNarrowVector256Traits	237.073	1105.751	1.347823

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	158.867	1650.089
SumNarrowBcl	13.622	19244.496	11.662703
SumNarrowVectorBase	13.655	19198.150	11.634616
SumNarrowVectorTraits	23.691	11065.245	6.705848
SumNarrowVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	353.469	741.632	0.449450
SumNarrowVector256Traits	12.813	20459.347	12.398937

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	169.534	1546.267
SumNarrowBcl	75.504	3471.921	2.245358
SumNarrowVectorBase	74.990	3495.735	2.260758
SumNarrowVectorTraits	48.659	5387.317	3.484080
SumNarrowVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	891.311	294.111	0.190207
SumNarrowVector256Traits	54.853	4778.999	3.090669

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
Environment.Version:	6.0.14
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.14\
RuntimeInformation.FrameworkDescription:	.NET 6.0.14
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	318.417	823.274
SumNarrowBcl	51.682	5072.270	6.161097
SumNarrowVectorBase	47.094	5566.435	6.761340
SumNarrowVectorTraits	48.332	5423.851	6.588148
SumNarrowVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	1360.584	192.670	0.234029
SumNarrowVector256Traits	251.867	1040.802	1.264224

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	156.187	1678.397
SumNarrowBcl	13.587	19293.408	11.495137
SumNarrowVectorBase	16.662	15732.613	9.373592
SumNarrowVectorTraits	40.366	6494.124	3.869241
SumNarrowVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	401.798	652.428	0.388721
SumNarrowVector256Traits	17.561	14927.566	8.893941

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	174.238	1504.518
SumNarrowBcl	82.288	3185.681	2.117410
SumNarrowVectorBase	81.663	3210.064	2.133616
SumNarrowVectorTraits	63.106	4154.041	2.761044
SumNarrowVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	995.286	263.386	0.175063
SumNarrowVector256Traits	50.485	5192.553	3.451307

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
Environment.Version:	7.0.3
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.3\
RuntimeInformation.FrameworkDescription:	.NET 7.0.3
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	321.752	814.739
SumNarrowBcl	51.690	5071.474	6.224661
SumNarrowVectorBase	53.628	4888.192	5.999703
SumNarrowVectorTraits	54.014	4853.237	5.956801
SumNarrowVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	82.982	3159.050	3.877377
SumNarrowVector256Traits	54.003	4854.263	5.958059

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	157.550	1663.875
SumNarrowBcl	18.136	14454.666	8.687352
SumNarrowVectorBase	10.805	24260.381	14.580654
SumNarrowVectorTraits	11.418	22959.724	13.798950
SumNarrowVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	16.849	15558.655	9.350858
SumNarrowVector256Traits	11.491	22813.000	13.710768

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	114.330	2292.870
SumNarrowBcl	49.558	5289.639	2.306995
SumNarrowVectorBase	52.720	4972.401	2.168637
SumNarrowVectorTraits	56.080	4674.433	2.038682
SumNarrowVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	68.882	3805.680	1.659789
SumNarrowVector256Traits	51.757	5064.921	2.208988

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
```

#### .NET 5

```
```

#### .NET 6

```
```

#### .NET 7

```
```

