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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1268.461	206.663
SumNarrow_IfUnrolling4	1244.356	210.666	1.019371
SumNarrow_MinMax	1281.443	204.569	0.989869
SumNarrow_MinMaxUnrolling4	1650.215	158.854	0.768664
SumNarrow_BitUtil	1092.136	240.029	1.161449
SumNarrow_BitUtilUnrolling4	699.120	374.963	1.814368
SumNarrowVectorBase	42.617	6151.122	29.764019
SumNarrowVectorTraits	16.930	15484.165	74.924701

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1224.320	214.114
SumNarrow_MinMax	1234.415	212.363	0.991822
SumNarrow_BitUtil	522.036	502.156	2.345277
SumNarrowVectorBase	111.953	2341.561	10.936051
SumNarrowVectorTraits	39.968	6558.827	30.632416

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	937.612	279.587
SumNarrow_MinMax	953.190	275.018	0.983657
SumNarrow_BitUtil	509.799	514.210	1.839180
SumNarrowVectorBase	259.556	1009.970	3.612367
SumNarrowVectorTraits	131.661	1991.053	7.121414

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1268.102	206.722
SumNarrow_IfUnrolling4	1233.758	212.476	1.027837
SumNarrow_MinMax	1209.793	216.685	1.048198
SumNarrow_MinMaxUnrolling4	1209.205	216.790	1.048707
SumNarrow_BitUtil	1090.980	240.283	1.162352
SumNarrow_BitUtilUnrolling4	687.042	381.554	1.845741
SumNarrowVectorBase	40.177	6524.759	31.563038
SumNarrowVectorTraits	19.602	13373.345	64.692565

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1223.210	214.308
SumNarrow_MinMax	1242.312	211.013	0.984624
SumNarrow_BitUtil	517.725	506.338	2.362662
SumNarrowVectorBase	76.001	3449.232	16.094722
SumNarrowVectorTraits	35.591	7365.355	34.368038

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	891.563	294.027
SumNarrow_MinMax	909.732	288.155	0.980029
SumNarrow_BitUtil	503.224	520.929	1.771702
SumNarrowVectorBase	209.150	1253.377	4.262789
SumNarrowVectorTraits	124.477	2105.960	7.162461

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1301.806	201.369
SumNarrow_IfUnrolling4	1354.365	193.555	0.961193
SumNarrow_MinMax	1262.093	207.706	1.031466
SumNarrow_MinMaxUnrolling4	1234.367	212.371	1.054635
SumNarrow_BitUtil	765.433	342.478	1.700745
SumNarrow_BitUtilUnrolling4	632.138	414.694	2.059372
SumNarrowVectorBase	29.152	8992.295	44.655711
SumNarrowVectorTraits	9.295	28204.171	140.061833
SumNarrowVector128Traits	1690.191	155.097	0.770212
SumNarrowVector256Traits	55.330	4737.812	23.527960

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1239.847	211.433
SumNarrow_MinMax	1254.887	208.898	0.988015
SumNarrow_BitUtil	537.229	487.955	2.307854
SumNarrowVectorBase	60.651	4322.188	20.442398
SumNarrowVectorTraits	21.260	12330.212	58.317484
SumNarrowVector128Traits	2719.755	96.385	0.455867
SumNarrowVector256Traits	18.574	14113.811	66.753267

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	859.074	305.147
SumNarrow_MinMax	932.978	280.976	0.920787
SumNarrow_BitUtil	522.760	501.462	1.643343
SumNarrowVectorBase	221.499	1183.497	3.878446
SumNarrowVectorTraits	168.458	1556.141	5.099638
SumNarrowVector128Traits	3140.210	83.480	0.273572
SumNarrowVector256Traits	94.520	2773.424	9.088806

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1363.933	192.197
SumNarrow_IfUnrolling4	1463.125	179.167	0.932205
SumNarrow_MinMax	1282.787	204.355	1.063257
SumNarrow_MinMaxUnrolling4	1280.852	204.664	1.064863
SumNarrow_BitUtil	1068.816	245.266	1.276116
SumNarrow_BitUtilUnrolling4	1025.248	255.688	1.330344
SumNarrowVectorBase	30.845	8498.872	44.219544
SumNarrowVectorTraits	10.643	24629.763	128.148407
SumNarrowVector128Traits	1775.550	147.641	0.768175
SumNarrowVector256Traits	56.872	4609.348	23.982390

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1266.735	206.945
SumNarrow_MinMax	1264.018	207.389	1.002150
SumNarrow_BitUtil	910.626	287.872	1.391060
SumNarrowVectorBase	67.595	3878.161	18.740095
SumNarrowVectorTraits	20.240	12951.816	62.585923
SumNarrowVector128Traits	2830.829	92.603	0.447479
SumNarrowVector256Traits	20.435	12828.134	61.988263

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	865.902	302.741
SumNarrow_MinMax	932.490	281.122	0.928591
SumNarrow_BitUtil	721.820	363.171	1.199609
SumNarrowVectorBase	204.274	1283.297	4.238928
SumNarrowVectorTraits	169.452	1547.012	5.110020
SumNarrowVector128Traits	3261.578	80.373	0.265486
SumNarrowVector256Traits	106.973	2450.573	8.094622

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
[Vectors.Instance: VectorTraits256Avx2]
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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1353.521	193.676
SumNarrow_IfUnrolling4	1421.268	184.444	0.952333
SumNarrow_MinMax	1388.724	188.766	0.974650
SumNarrow_MinMaxUnrolling4	1413.400	185.471	0.957635
SumNarrow_BitUtil	879.101	298.196	1.539664
SumNarrow_BitUtilUnrolling4	826.377	317.221	1.637896
SumNarrowVectorBase	30.071	8717.563	45.011143
SumNarrowVectorTraits	11.541	22714.395	117.280583
SumNarrowVector128Traits	1844.997	142.084	0.733617
SumNarrowVector256Traits	55.545	4719.495	24.368035

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1260.156	208.025
SumNarrow_MinMax	1256.160	208.687	1.003181
SumNarrow_BitUtil	907.943	288.723	1.387924
SumNarrowVectorBase	70.302	3728.818	17.924853
SumNarrowVectorTraits	19.152	13687.686	65.798262
SumNarrowVector128Traits	2847.965	92.046	0.442476
SumNarrowVector256Traits	19.101	13724.394	65.974722

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	860.582	304.612
SumNarrow_MinMax	816.767	320.953	1.053645
SumNarrow_BitUtil	736.038	356.156	1.169210
SumNarrowVectorBase	200.977	1304.347	4.281990
SumNarrowVectorTraits	167.760	1562.610	5.129832
SumNarrowVector128Traits	3753.932	69.832	0.229248
SumNarrowVector256Traits	109.827	2386.882	7.835803

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1209.999	216.648
SumNarrow_IfUnrolling4	1275.870	205.463	0.948371
SumNarrow_MinMax	1188.064	220.648	1.018463
SumNarrow_MinMaxUnrolling4	1259.259	208.173	0.960882
SumNarrow_BitUtil	657.060	398.965	1.841536
SumNarrow_BitUtilUnrolling4	675.469	388.092	1.791345
SumNarrowVectorBase	14.702	17830.561	82.301933
SumNarrowVectorTraits	9.251	28337.439	130.799364
SumNarrowVector128Traits	21.811	12018.629	55.475339
SumNarrowVector256Traits	9.240	28372.051	130.959126

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1187.968	220.666
SumNarrow_MinMax	1249.180	209.853	0.950999
SumNarrow_BitUtil	519.004	505.090	2.288937
SumNarrowVectorBase	28.778	9109.115	41.280127
SumNarrowVectorTraits	18.743	13986.604	63.383636
SumNarrowVector128Traits	78.582	3335.948	15.117645
SumNarrowVector256Traits	20.398	12851.662	58.240375

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	969.963	270.262
SumNarrow_MinMax	853.139	307.270	1.136935
SumNarrow_BitUtil	574.291	456.465	1.688974
SumNarrowVectorBase	107.384	2441.193	9.032697
SumNarrowVectorTraits	107.197	2445.448	9.048440
SumNarrowVector128Traits	158.729	1651.516	6.110801
SumNarrowVector256Traits	106.706	2456.697	9.090063

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

