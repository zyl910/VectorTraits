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
SumWidenScalar	147.504	1777.196
SumWidenBcl	54.406	4818.288	2.711174
SumWidenVectorBase	46.795	5601.928	3.152116
SumWidenVectorBase_NPtr	325.292	805.873	0.453452
SumWidenVectorBase_NRef	326.301	803.382	0.452050
SumWidenVectorBase_NRef2	337.026	777.815	0.437664
SumWidenVectorBase_NRefInc	324.192	808.608	0.454991
SumWidenVectorBase_NRefInc2	328.860	797.130	0.448532
SumWidenVectorBase_Ptr	330.110	794.110	0.446833
SumWidenVectorBase_Ref	383.858	682.918	0.384267
SumWidenVectorBase_Ref2	353.450	741.672	0.417327
SumWidenVectorBase_RefInc	318.892	822.046	0.462552
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	314.792	832.754	0.468577
SumWidenVectorBase256_Ref	321.693	814.888	0.458525
SumWidenVectorBase256_Ref2	326.238	803.537	0.452137
SumWidenVectorBase256_RefI	320.946	816.786	0.459593
SumWidenVectorBase256_RefI2	317.313	826.136	0.464853
SumWidenVectorBase256_RefInc	324.776	807.153	0.454172
SumWidenVectorBase256_RefInc2	318.563	822.897	0.463031
SumWidenVectorTraits	46.599	5625.500	3.165379

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
SumWidenScalar	147.376	1778.744
SumWidenBcl	46.581	5627.688	3.163854
SumWidenVectorBase	46.980	5579.964	3.137024
SumWidenVectorBase_NPtr	318.255	823.691	0.463074
SumWidenVectorBase_NRef	327.349	800.810	0.450211
SumWidenVectorBase_NRef2	340.290	770.354	0.433088
SumWidenVectorBase_NRefInc	315.648	830.495	0.466900
SumWidenVectorBase_NRefInc2	325.636	805.022	0.452579
SumWidenVectorBase_Ptr	327.602	800.190	0.449862
SumWidenVectorBase_Ref	352.849	742.935	0.417674
SumWidenVectorBase_Ref2	342.265	765.910	0.430590
SumWidenVectorBase_RefInc	315.778	830.153	0.466708
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	308.190	850.592	0.478198
SumWidenVectorBase256_Ref	307.841	851.557	0.478741
SumWidenVectorBase256_Ref2	307.272	853.132	0.479626
SumWidenVectorBase256_RefI	308.674	849.259	0.477448
SumWidenVectorBase256_RefI2	309.569	846.802	0.476067
SumWidenVectorBase256_RefInc	309.506	846.976	0.476165
SumWidenVectorBase256_RefInc2	309.693	846.464	0.475877
SumWidenVectorTraits	46.771	5604.880	3.151032

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
SumWidenScalar	160.505	1633.245
SumWidenBcl	47.306	5541.438	3.392900
SumWidenVectorBase	48.687	5384.220	3.296639
SumWidenVectorBase_NPtr	311.429	841.745	0.515382
SumWidenVectorBase_NRef	318.097	824.100	0.504578
SumWidenVectorBase_NRef2	326.559	802.747	0.491504
SumWidenVectorBase_NRefInc	308.446	849.887	0.520367
SumWidenVectorBase_NRefInc2	326.551	802.765	0.491516
SumWidenVectorBase_Ptr	357.446	733.382	0.449033
SumWidenVectorBase_Ref	344.332	761.312	0.466135
SumWidenVectorBase_Ref2	337.054	777.752	0.476200
SumWidenVectorBase_RefInc	464.006	564.959	0.345912
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	302.174	867.526	0.531167
SumWidenVectorBase256_Ref	288.445	908.817	0.556449
SumWidenVectorBase256_Ref2	288.111	909.871	0.557094
SumWidenVectorBase256_RefI	289.827	904.485	0.553796
SumWidenVectorBase256_RefI2	290.131	903.536	0.553215
SumWidenVectorBase256_RefInc	291.563	899.100	0.550499
SumWidenVectorBase256_RefInc2	299.102	876.436	0.536623
SumWidenVectorTraits	35.569	7370.098	4.512549
SumWidenVector128Traits	1176.089	222.895	0.136474
SumWidenVector256Traits	36.081	7265.459	4.448480

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
SumWidenScalar	159.077	1647.902
SumWidenBcl	46.574	5628.493	3.415551
SumWidenVectorBase	47.032	5573.746	3.382329
SumWidenVectorBase_NPtr	327.502	800.435	0.485730
SumWidenVectorBase_NRef	322.268	813.434	0.493618
SumWidenVectorBase_NRef2	331.159	791.595	0.480365
SumWidenVectorBase_NRefInc	303.943	862.476	0.523378
SumWidenVectorBase_NRefInc2	314.489	833.557	0.505829
SumWidenVectorBase_Ptr	324.940	806.747	0.489560
SumWidenVectorBase_Ref	347.480	754.415	0.457803
SumWidenVectorBase_Ref2	336.589	778.824	0.472616
SumWidenVectorBase_RefInc	302.826	865.659	0.525310
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	319.371	820.813	0.498096
SumWidenVectorBase256_Ref	274.715	954.241	0.579065
SumWidenVectorBase256_Ref2	274.735	954.170	0.579021
SumWidenVectorBase256_RefI	285.291	918.864	0.557597
SumWidenVectorBase256_RefI2	284.023	922.968	0.560087
SumWidenVectorBase256_RefInc	287.396	912.136	0.553514
SumWidenVectorBase256_RefInc2	296.243	884.895	0.536983
SumWidenVectorTraits	36.021	7277.587	4.416275
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1172.317	223.612	0.135695
SumWidenVector256Traits	35.849	7312.473	4.437445

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
SumWidenScalar	141.739	1849.481
SumWidenBcl	48.435	5412.270	2.926372
SumWidenVectorBase	46.722	5610.768	3.033698
SumWidenVectorBase_NPtr	314.922	832.408	0.450077
SumWidenVectorBase_NRef	315.841	829.987	0.448767
SumWidenVectorBase_NRef2	322.495	812.861	0.439508
SumWidenVectorBase_NRefInc	300.356	872.777	0.471904
SumWidenVectorBase_NRefInc2	313.016	837.479	0.452818
SumWidenVectorBase_Ptr	321.432	815.550	0.440962
SumWidenVectorBase_Ref	340.874	769.036	0.415812
SumWidenVectorBase_Ref2	330.195	793.908	0.429260
SumWidenVectorBase_RefInc	300.926	871.124	0.471010
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	311.470	841.634	0.455065
SumWidenVectorBase256_Ref	263.793	993.749	0.537312
SumWidenVectorBase256_Ref2	274.270	955.789	0.516788
SumWidenVectorBase256_RefI	275.070	953.008	0.515284
SumWidenVectorBase256_RefI2	280.496	934.574	0.505317
SumWidenVectorBase256_RefInc	283.679	924.088	0.499647
SumWidenVectorBase256_RefInc2	291.251	900.061	0.486656
SumWidenVectorTraits	35.176	7452.360	4.029433
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1151.439	227.666	0.123097
SumWidenVector256Traits	34.798	7533.270	4.073180

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
SumWidenScalar	157.789	1661.361
SumWidenBcl	33.383	7852.721	4.726680
SumWidenVectorBase	32.639	8031.714	4.834419
SumWidenVectorBase_NPtr	283.126	925.892	0.557309
SumWidenVectorBase_NRef	283.318	925.265	0.556932
SumWidenVectorBase_NRef2	284.098	922.723	0.555402
SumWidenVectorBase_NRefInc	300.528	872.279	0.525039
SumWidenVectorBase_NRefInc2	311.300	842.096	0.506871
SumWidenVectorBase_Ptr	309.704	846.433	0.509482
SumWidenVectorBase_Ref	307.958	851.233	0.512371
SumWidenVectorBase_Ref2	294.323	890.667	0.536107
SumWidenVectorBase_RefInc	304.062	862.140	0.518936
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	264.609	990.685	0.596309
SumWidenVectorBase256_Ref	261.861	1001.080	0.602566
SumWidenVectorBase256_Ref2	273.175	959.621	0.577611
SumWidenVectorBase256_RefI	273.761	957.567	0.576375
SumWidenVectorBase256_RefI2	279.594	937.587	0.564349
SumWidenVectorBase256_RefInc	283.097	925.988	0.557367
SumWidenVectorBase256_RefInc2	288.981	907.133	0.546018
SumWidenVectorTraits	32.426	8084.349	4.866100
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	59.420	4411.713	2.655481
SumWidenVector256Traits	32.707	8014.970	4.824340

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
SumWidenScalar	351.338	746.130
SumWidenBcl	74.516	3517.936	4.714910
SumWidenVectorBase	74.536	3517.029	4.713693
SumWidenVectorBase_NPtr	552.921	474.108	0.635422
SumWidenVectorBase_NRef	497.471	526.954	0.706249
SumWidenVectorBase_NRef2	494.180	530.463	0.710952
SumWidenVectorBase_NRefInc	508.912	515.106	0.690371
SumWidenVectorBase_NRefInc2	502.583	521.594	0.699065
SumWidenVectorBase_Ptr	554.701	472.586	0.633383
SumWidenVectorBase_Ref	494.729	529.874	0.710163
SumWidenVectorBase_Ref2	494.900	529.691	0.709918
SumWidenVectorBase_RefInc	504.023	520.103	0.697068
SumWidenVectorBase128_Ptr	551.888	474.995	0.636612
SumWidenVectorBase128_Ref	501.683	522.529	0.700318
SumWidenVectorBase128_Ref2	498.981	525.359	0.704112
SumWidenVectorBase128_RefI	500.584	523.676	0.701856
SumWidenVectorBase128_RefI2	499.986	524.303	0.702697
SumWidenVectorBase128_RefInc	497.776	526.630	0.705815
SumWidenVectorBase128_RefInc2	492.439	532.338	0.713465
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	74.583	3514.810	4.710720
SumWidenVector128Traits	1153.310	227.297	0.304635
SumWidenVector256Traits	2153.353	121.738	0.163159

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
SumWidenScalar	349.460	750.140
SumWidenBcl	76.497	3426.850	4.568283
SumWidenVectorBase	81.502	3216.417	4.287759
SumWidenVectorBase_NPtr	814.846	321.710	0.428867
SumWidenVectorBase_NRef	494.583	530.030	0.706576
SumWidenVectorBase_NRef2	498.227	526.154	0.701408
SumWidenVectorBase_NRefInc	511.495	512.506	0.683214
SumWidenVectorBase_NRefInc2	505.923	518.150	0.690738
SumWidenVectorBase_Ptr	805.916	325.274	0.433619
SumWidenVectorBase_Ref	494.042	530.611	0.707350
SumWidenVectorBase_Ref2	494.032	530.621	0.707363
SumWidenVectorBase_RefInc	511.553	512.448	0.683136
SumWidenVectorBase128_Ptr	547.114	479.139	0.638734
SumWidenVectorBase128_Ref	515.559	508.466	0.677828
SumWidenVectorBase128_Ref2	515.686	508.341	0.677661
SumWidenVectorBase128_RefI	514.657	509.357	0.679016
SumWidenVectorBase128_RefI2	511.317	512.684	0.683451
SumWidenVectorBase128_RefInc	507.414	516.628	0.688709
SumWidenVectorBase128_RefInc2	499.169	525.161	0.700084
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	88.242	2970.741	3.960251
SumWidenVector128_Arm	89.239	2937.540	3.915991
SumWidenVector128Traits	89.535	2927.830	3.903047
SumWidenVector256Traits	1110.418	236.077	0.314711

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
SumWidenScalar	350.483	747.950
SumWidenBcl	85.095	3080.590	4.118712
SumWidenVectorBase	77.412	3386.367	4.527532
SumWidenVectorBase_NPtr	545.626	480.447	0.642351
SumWidenVectorBase_NRef	494.004	530.652	0.709475
SumWidenVectorBase_NRef2	699.758	374.621	0.500864
SumWidenVectorBase_NRefInc	514.508	509.505	0.681202
SumWidenVectorBase_NRefInc2	507.888	516.146	0.690081
SumWidenVectorBase_Ptr	547.745	478.587	0.639865
SumWidenVectorBase_Ref	495.608	528.934	0.707179
SumWidenVectorBase_Ref2	495.673	528.865	0.707086
SumWidenVectorBase_RefInc	514.514	509.499	0.681194
SumWidenVectorBase128_Ptr	540.737	484.790	0.648159
SumWidenVectorBase128_Ref	520.597	503.545	0.673234
SumWidenVectorBase128_Ref2	520.392	503.743	0.673499
SumWidenVectorBase128_RefI	515.447	508.576	0.679960
SumWidenVectorBase128_RefI2	514.870	509.146	0.680722
SumWidenVectorBase128_RefInc	510.561	513.443	0.686467
SumWidenVectorBase128_RefInc2	504.253	519.866	0.695054
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	88.866	2949.891	3.943968
SumWidenVector128_Arm	88.661	2956.692	3.953061
SumWidenVector128Traits	88.755	2953.562	3.948877
SumWidenVector256Traits	1058.374	247.686	0.331153

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
SumWidenScalar	211.482	1239.558
SumWidenBcl	70.428	3722.131	3.002789
SumWidenVectorBase	70.332	3727.255	3.006922
SumWidenVectorBase_NPtr	479.649	546.533	0.440910
SumWidenVectorBase_NRef	481.821	544.069	0.438922
SumWidenVectorBase_NRef2	479.402	546.815	0.441137
SumWidenVectorBase_NRefInc	750.142	349.459	0.281922
SumWidenVectorBase_NRefInc2	481.658	544.254	0.439071
SumWidenVectorBase_Ptr	479.069	547.195	0.441444
SumWidenVectorBase_Ref	480.685	545.355	0.439959
SumWidenVectorBase_Ref2	476.711	549.902	0.443627
SumWidenVectorBase_RefInc	481.020	544.975	0.439653
SumWidenVectorBase128_Ptr	491.066	533.826	0.430658
SumWidenVectorBase128_Ref	491.552	533.299	0.430233
SumWidenVectorBase128_Ref2	490.943	533.960	0.430767
SumWidenVectorBase128_RefI	490.129	534.847	0.431482
SumWidenVectorBase128_RefI2	489.899	535.098	0.431685
SumWidenVectorBase128_RefInc	490.030	534.955	0.431569
SumWidenVectorBase128_RefInc2	488.350	536.796	0.433054
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	70.227	3732.821	3.011413
SumWidenVector128_Arm	70.144	3737.222	3.014963
SumWidenVector128Traits	70.343	3726.654	3.006438
SumWidenVector256Traits	2221.371	118.010	0.095203

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

