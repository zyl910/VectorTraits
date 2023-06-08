# Benchmark - ShiftRightArithmetic
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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-25396098	# 0xFE7C7C7E
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	373.375	702.093
SumSRA_Base_Basic	294.380	890.496	1.268345
SumSRA_Base	192.120	1364.479	1.943444
SumSRA_Base_Core	328.363	798.336	1.137080
SumSRATraits	186.600	1404.847	2.000941
SumSRATraits_Core	175.727	1491.773	2.124751
SumSRAConstTraits	184.569	1420.306	2.022960
SumSRAConstTraits_Core	213.032	1230.536	1.752668
SumSRAFastTraits	283.180	925.717	1.318510

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	511.251	512.750
SumSRA_Base_Basic	764.334	342.970	0.668884
SumSRA_Base	499.904	524.388	1.022698
SumSRA_Base_Core	424.566	617.439	1.204173
SumSRATraits	463.226	565.910	1.103677
SumSRATraits_Core	400.225	654.991	1.277409
SumSRAConstTraits	376.138	696.936	1.359212
SumSRAConstTraits_Core	368.779	710.843	1.386335
SumSRAFastTraits	407.593	643.151	1.254318

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	434.275	603.636
SumSRA_Base_Basic	644.631	406.657	0.673680
SumSRA_Base	654.867	400.301	0.663150
SumSRA_Base_Create	712.220	368.066	0.609748
SumSRA_Base_LoadArray	736.075	356.137	0.589987
SumSRA_Base_Core	643.056	407.654	0.675330
SumSRATraits	640.051	409.568	0.678501
SumSRATraits_Core	638.940	410.280	0.679681
SumSRAConstTraits	548.225	478.169	0.792148
SumSRAConstTraits_Core	550.179	476.470	0.789334
SumSRAFastTraits	620.186	422.686	0.700234

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	377.694	694.064
SumSRA_Base_Basic	251.943	1040.489	1.499126
SumSRA_Base	91.618	2861.264	4.122480
SumSRA_Base_Core	84.938	3086.314	4.446729
SumSRATraits	94.012	2788.400	4.017498
SumSRATraits_Core	86.988	3013.549	4.341891
SumSRAConstTraits	81.506	3216.235	4.633918
SumSRAConstTraits_Core	78.544	3337.539	4.808691
SumSRAFastTraits	89.618	2925.110	4.214469

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
VectorTraitsGlobal.InitCheckSum:	-25396098	# 0xFE7C7C7E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	396.351	661.393
SumSRA_Base_Basic	292.131	897.350	1.356756
SumSRA_Base	192.434	1362.254	2.059673
SumSRA_Base_Core	178.903	1465.288	2.215456
SumSRATraits	194.010	1351.186	2.042939
SumSRATraits_Core	179.048	1464.097	2.213656
SumSRAConstTraits	176.697	1483.577	2.243108
SumSRAConstTraits_Core	168.397	1556.703	2.353671
SumSRAFastTraits	182.169	1439.019	2.175738

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	366.002	716.236
SumSRA_Base_Basic	603.846	434.124	0.606118
SumSRA_Base	403.457	649.745	0.907166
SumSRA_Base_Core	367.485	713.346	0.995965
SumSRATraits	411.276	637.392	0.889919
SumSRATraits_Core	370.148	708.215	0.988800
SumSRAConstTraits	359.971	728.237	1.016755
SumSRAConstTraits_Core	350.867	747.132	1.043136
SumSRAFastTraits	375.979	697.230	0.973464

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	389.524	672.985
SumSRA_Base_Basic	712.048	368.155	0.547048
SumSRA_Base	686.918	381.624	0.567061
SumSRA_Base_Create	740.675	353.926	0.525904
SumSRA_Base_LoadArray	760.305	344.788	0.512326
SumSRA_Base_Core	723.618	362.268	0.538300
SumSRATraits	700.368	374.295	0.556170
SumSRATraits_Core	673.626	389.153	0.578249
SumSRAConstTraits	625.086	419.373	0.623153
SumSRAConstTraits_Core	615.837	425.671	0.632512
SumSRAFastTraits	638.733	410.412	0.609838

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	364.078	720.023
SumSRA_Base_Basic	247.913	1057.404	1.468570
SumSRA_Base	97.666	2684.095	3.727793
SumSRA_Base_Core	88.208	2971.869	4.127467
SumSRATraits	95.179	2754.216	3.825180
SumSRATraits_Core	88.908	2948.503	4.095014
SumSRAConstTraits	86.903	3016.510	4.189466
SumSRAConstTraits_Core	85.555	3064.053	4.255496
SumSRAFastTraits	94.442	2775.703	3.855023

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
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	262.285	999.463
SumSRA_Base_Basic	318.978	821.825	0.822267
SumSRA_Base	190.264	1377.793	1.378533
SumSRA_Base_Core	185.677	1411.826	1.412585
SumSRA_Avx2	19.528	13424.248	13.431463
SumSRATraits	18.671	14040.396	14.047942
SumSRATraits_Core	15.461	16954.769	16.963881
SumSRAConstTraits	17.993	14568.822	14.576652
SumSRAConstTraits_Core	15.237	17204.435	17.213682
SumSRAFast_Avx2	17.265	15183.697	15.191858
SumSRAFastTraits	17.876	14664.683	14.672564

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	231.915	1130.344
SumSRA_Base_Basic	598.793	437.787	0.387304
SumSRA_Base	383.991	682.682	0.603960
SumSRA_Base_Core	368.289	711.789	0.629710
SumSRA_Avx2	37.159	7054.651	6.241152
SumSRATraits	37.269	7033.899	6.222793
SumSRATraits_Core	31.321	8369.465	7.404349
SumSRAConstTraits	36.853	7113.141	6.292897
SumSRAConstTraits_Core	30.380	8628.813	7.633791
SumSRAFast_Avx2	35.453	7394.178	6.541526
SumSRAFastTraits	36.144	7252.708	6.416370

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	262.198	999.795
SumSRA_Base_Basic	660.226	397.052	0.397133
SumSRA_Base	664.482	394.509	0.394590
SumSRA_Base_Create	738.502	354.967	0.355040
SumSRA_Base_LoadArray	775.536	338.017	0.338086
SumSRA_Base_Core	652.519	401.741	0.401824
SumSRA_Avx2	145.948	1796.148	1.796516
SumSRATraits	145.082	1806.868	1.807239
SumSRATraits_Core	96.183	2725.484	2.726043
SumSRAConstTraits	135.179	1939.231	1.939628
SumSRAConstTraits_Core	92.579	2831.561	2.832141
SumSRAFast_Avx2	129.332	2026.911	2.027327
SumSRAFastTraits	134.916	1943.022	1.943420

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	280.145	935.744
SumSRA_Base_Basic	275.275	952.300	1.017693
SumSRA_Base	97.422	2690.819	2.875593
SumSRA_Base_Core	105.217	2491.451	2.662535
SumSRA_Avx2	19.237	13626.962	14.562703
SumSRATraits	18.734	13992.988	14.953863
SumSRATraits_Core	10.711	24474.777	26.155419
SumSRAConstTraits	15.306	17127.425	18.303536
SumSRAConstTraits_Core	11.551	22695.017	24.253446
SumSRAFast_Avx2	14.973	17507.704	18.709929
SumSRAFastTraits	14.076	18623.264	19.902092

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	266.041	985.350
SumSRA_Base_Basic	325.543	805.250	0.817222
SumSRA_Base	194.166	1350.105	1.370178
SumSRA_Base_Core	178.175	1471.275	1.493149
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	19.441	13484.234	13.684710
SumSRATraits	19.712	13298.853	13.496572
SumSRATraits_Core	18.464	14197.408	14.408487
SumSRAConstTraits	17.081	15347.296	15.575470
SumSRAConstTraits_Core	16.024	16359.771	16.602999
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	17.631	14868.196	15.089248
SumSRAFastTraits	15.957	16428.024	16.672267

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	229.178	1143.847
SumSRA_Base_Basic	591.295	443.339	0.387586
SumSRA_Base	405.979	645.708	0.564506
SumSRA_Base_Core	371.633	705.384	0.616677
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	40.562	6462.745	5.650010
SumSRATraits	39.037	6715.292	5.870797
SumSRATraits_Core	29.085	9013.045	7.879592
SumSRAConstTraits	33.563	7810.563	6.828331
SumSRAConstTraits_Core	31.526	8315.196	7.269502
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	33.686	7781.886	6.803260
SumSRAFastTraits	32.919	7963.255	6.961820

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	255.871	1024.516
SumSRA_Base_Basic	670.715	390.843	0.381490
SumSRA_Base	674.560	388.615	0.379316
SumSRA_Base_Create	728.803	359.691	0.351084
SumSRA_Base_LoadArray	747.814	350.547	0.342159
SumSRA_Base_Core	663.505	395.090	0.385635
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	141.356	1854.497	1.810120
SumSRATraits	139.530	1878.760	1.833802
SumSRATraits_Core	90.440	2898.529	2.829168
SumSRAConstTraits	131.746	1989.769	1.942155
SumSRAConstTraits_Core	97.265	2695.154	2.630660
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	134.040	1955.717	1.908918
SumSRAFastTraits	135.550	1933.931	1.887653

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	294.400	890.434
SumSRA_Base_Basic	294.316	890.689	1.000287
SumSRA_Base	99.800	2626.683	2.949892
SumSRA_Base_Core	88.953	2946.990	3.309611
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	17.594	14899.290	16.732622
SumSRATraits	17.357	15103.419	16.961868
SumSRATraits_Core	10.562	24819.521	27.873520
SumSRAConstTraits	11.880	22065.680	24.780823
SumSRAConstTraits_Core	10.532	24889.146	27.951712
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	12.501	20969.587	23.549857
SumSRAFastTraits	12.393	21152.867	23.755690

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	222.931	1175.895
SumSRA_Base_Basic	319.546	820.364	0.697651
SumSRA_Base	189.405	1384.036	1.177007
SumSRA_Base_Core	177.088	1480.305	1.258875
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	18.220	14387.967	12.235759
SumSRATraits	19.139	13696.511	11.647734
SumSRATraits_Core	16.435	15950.067	13.564195
SumSRAConstTraits	14.762	17758.148	15.101816
SumSRAConstTraits_Core	14.714	17815.552	15.150633
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	16.008	16375.344	13.925857
SumSRAFastTraits	17.040	15384.450	13.083185

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	185.692	1411.714
SumSRA_Base_Basic	570.391	459.587	0.325552
SumSRA_Base	377.446	694.520	0.491969
SumSRA_Base_Core	357.904	732.441	0.518831
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	39.066	6710.236	4.753255
SumSRATraits	36.700	7142.890	5.059728
SumSRATraits_Core	29.569	8865.607	6.280030
SumSRAConstTraits	28.880	9077.101	6.429844
SumSRAConstTraits_Core	30.011	8734.785	6.187361
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	33.203	7895.274	5.592686
SumSRAFastTraits	33.546	7814.563	5.535514

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	244.203	1073.467
SumSRA_Base_Basic	636.150	412.079	0.383877
SumSRA_Base	624.620	419.686	0.390963
SumSRA_Base_Create	715.925	366.161	0.341102
SumSRA_Base_LoadArray	736.973	355.704	0.331360
SumSRA_Base_Core	653.613	401.069	0.373621
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	137.358	1908.478	1.777864
SumSRATraits	139.695	1876.551	1.748123
SumSRATraits_Core	103.264	2538.591	2.364854
SumSRAConstTraits	110.069	2381.632	2.218637
SumSRAConstTraits_Core	92.414	2836.640	2.642504
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	129.319	2027.105	1.888373
SumSRAFastTraits	129.212	2028.785	1.889938

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	222.753	1176.838
SumSRA_Base_Basic	259.603	1009.787	0.858051
SumSRA_Base	94.461	2775.165	2.358153
SumSRA_Base_Core	87.911	2981.920	2.533840
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	17.950	14604.303	12.409780
SumSRATraits	18.260	14356.315	12.199056
SumSRATraits_Core	10.539	24872.623	21.135126
SumSRAConstTraits	10.688	24527.494	20.841857
SumSRAConstTraits_Core	10.445	25098.230	21.326832
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	11.164	23481.786	19.953283
SumSRAFastTraits	11.816	22185.694	18.851949

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	189.019	1386.868
SumSRANetBcl	16.846	15561.485	11.220592
SumSRANetBcl_Const	15.300	17133.315	12.353958
SumSRA_Base_Basic	265.151	988.659	0.712872
SumSRA_Base	16.380	16003.624	11.539396
SumSRA_Base_Core	16.629	15764.564	11.367022
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	17.986	14574.903	10.509218
SumSRATraits	18.267	14350.990	10.347766
SumSRATraits_Core	15.419	17000.906	12.258485
SumSRAConstTraits	15.849	16540.240	11.926323
SumSRAConstTraits_Core	14.542	18026.411	12.997925
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	16.300	16082.689	11.596406
SumSRAFastTraits	16.505	15882.748	11.452239

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	186.301	1407.096
SumSRANetBcl	32.350	8103.354	5.758921
SumSRANetBcl_Const	28.648	9150.476	6.503093
SumSRA_Base_Basic	586.806	446.730	0.317484
SumSRA_Base	29.398	8917.115	6.337248
SumSRA_Base_Core	31.676	8275.910	5.881554
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	36.495	7182.959	5.104811
SumSRATraits	36.204	7240.780	5.145904
SumSRATraits_Core	28.722	9127.018	6.486422
SumSRAConstTraits	31.492	8324.080	5.915787
SumSRAConstTraits_Core	31.234	8392.985	5.964757
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	30.230	8671.785	6.162895
SumSRAFastTraits	32.255	8127.186	5.775858

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	193.557	1354.353
SumSRANetBcl	498.193	526.189	0.388517
SumSRANetBcl_Const	521.334	502.833	0.371272
SumSRA_Base_Basic	647.460	404.880	0.298948
SumSRA_Base	154.920	1692.126	1.249398
SumSRA_Base_Create	114.144	2296.599	1.695716
SumSRA_Base_LoadArray	120.034	2183.917	1.612517
SumSRA_Base_Core	111.204	2357.332	1.740560
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	141.601	1851.285	1.366915
SumSRATraits	137.562	1905.640	1.407048
SumSRATraits_Core	89.713	2922.042	2.157519
SumSRAConstTraits	107.582	2436.681	1.799148
SumSRAConstTraits_Core	93.383	2807.207	2.072729
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	128.659	2037.505	1.504412
SumSRAFastTraits	130.601	2007.209	1.482043

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	193.533	1354.520
SumSRANetBcl	267.968	978.265	0.722222
SumSRANetBcl_Const	259.805	1009.002	0.744914
SumSRA_Base_Basic	238.610	1098.628	0.811083
SumSRA_Base	15.844	16545.597	12.215096
SumSRA_Base_Core	12.121	21626.852	15.966427
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	15.312	17119.958	12.639129
SumSRATraits	15.253	17186.103	12.687961
SumSRATraits_Core	9.442	27764.407	20.497592
SumSRAConstTraits	10.027	26142.905	19.300487
SumSRAConstTraits_Core	10.039	26113.489	19.278770
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	10.987	23858.806	17.614209
SumSRAFastTraits	10.813	24243.615	17.898301

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
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	431.853	607.022
SumSRA_Base_Basic	500.529	523.734	0.862793
SumSRA_Base	163.592	1602.422	2.639810
SumSRA_Base_Core	313.094	837.268	1.379305
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	160.075	1637.633	2.697817
SumSRATraits_Core	137.819	1902.091	3.133481
SumSRAConstTraits	139.755	1875.738	3.090067
SumSRAConstTraits_Core	138.573	1891.736	3.116423
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	142.033	1845.660	3.040519

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	350.762	747.356
SumSRA_Base_Basic	799.666	327.817	0.438636
SumSRA_Base	304.737	860.231	1.151034
SumSRA_Base_Core	286.275	915.706	1.225261
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	322.334	813.269	1.088195
SumSRATraits_Core	272.209	963.024	1.288576
SumSRAConstTraits	281.158	932.371	1.247560
SumSRAConstTraits_Core	275.753	950.649	1.272016
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	286.957	913.530	1.222350

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	353.315	741.955
SumSRA_Base_Basic	547.892	478.459	0.644862
SumSRA_Base	547.825	478.518	0.644941
SumSRA_Base_Create	1273.540	205.839	0.277428
SumSRA_Base_LoadArray	675.353	388.158	0.523156
SumSRA_Base_Core	539.120	486.244	0.655355
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	558.024	469.772	0.633154
SumSRATraits_Core	560.128	468.007	0.630775
SumSRAConstTraits	558.038	469.760	0.633138
SumSRAConstTraits_Core	557.717	470.031	0.633503
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	559.065	468.897	0.631975

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	429.356	610.552
SumSRA_Base_Basic	364.390	719.405	1.178287
SumSRA_Base	81.350	3222.411	5.277868
SumSRA_Base_Core	70.238	3732.210	6.112849
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	80.951	3238.324	5.303932
SumSRATraits_Core	67.963	3857.160	6.317500
SumSRAConstTraits	69.370	3778.934	6.189376
SumSRAConstTraits_Core	68.782	3811.242	6.242293
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	72.388	3621.377	5.931320

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
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
Check-SumSRAConstTraits	Fail! Check `SumSRAConstTraits` fail! -24614!=-12499
SumSRAScalar	432.450	606.184
SumSRA_Base_Basic	502.033	522.165	0.861397
SumSRA_Base	154.200	1700.029	2.804476
SumSRA_Base_Core	134.588	1947.752	3.213136
SumSRA_AdvSimd	53.130	4934.040	8.139507
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	46.655	5618.766	9.269075
SumSRATraits_Core	33.481	7829.695	12.916366
SumSRAConstTraits	33.799	7756.066	12.794903
SumSRAConstTraits_Core	33.489	7827.648	12.912988
SumSRAFast_AdvSimd	40.028	6548.964	10.803590
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	33.715	7775.248	12.826546

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	351.215	746.393
SumSRA_Base_Basic	793.631	330.310	0.442542
SumSRA_Base	283.472	924.763	1.238977
SumSRA_Base_Core	270.664	968.521	1.297602
SumSRA_AdvSimd	93.494	2803.856	3.756543
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	93.366	2807.705	3.761700
SumSRATraits_Core	67.585	3878.725	5.196628
SumSRAConstTraits	68.126	3847.901	5.155331
SumSRAConstTraits_Core	67.608	3877.401	5.194855
SumSRAFast_AdvSimd	68.210	3843.199	5.149031
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	68.430	3830.823	5.132451

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	352.728	743.190
SumSRA_Base_Basic	542.738	483.003	0.649905
SumSRA_Base	542.635	483.095	0.650028
SumSRA_Base_Create	549.224	477.299	0.642230
SumSRA_Base_LoadArray	635.335	412.607	0.555184
SumSRA_Base_Core	543.604	482.233	0.648869
SumSRA_AdvSimd	212.738	1232.240	1.658041
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	186.130	1408.393	1.895064
SumSRATraits_Core	124.958	2097.849	2.822761
SumSRAConstTraits	133.661	1961.259	2.638973
SumSRAConstTraits_Core	133.139	1968.949	2.649321
SumSRAFast_AdvSimd	134.053	1955.532	2.631267
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	133.838	1958.661	2.635478

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	429.192	610.785
SumSRA_Base_Basic	367.977	712.393	1.166357
SumSRA_Base	76.416	3430.466	5.616491
SumSRA_Base_Core	67.273	3896.724	6.379866
SumSRA_AdvSimd	23.264	11268.036	18.448462
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.220	11289.392	18.483428
SumSRATraits_Core	15.620	16782.354	27.476716
SumSRAConstTraits	16.718	15680.394	25.672544
SumSRAConstTraits_Core	15.580	16825.439	27.547257
SumSRAFast_AdvSimd	16.684	15711.871	25.724080
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	16.860	15548.694	25.456920

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
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	432.005	606.807
SumSRA_Base_Basic	503.339	520.810	0.858278
SumSRA_Base	152.502	1718.959	2.832793
SumSRA_Base_Core	134.627	1947.184	3.208901
SumSRA_AdvSimd	46.584	5627.322	9.273656
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	46.563	5629.872	9.277859
SumSRATraits_Core	33.322	7867.061	12.964678
SumSRAConstTraits	33.297	7872.830	12.974186
SumSRAConstTraits_Core	33.213	7892.796	13.007089
SumSRAFast_AdvSimd	33.252	7883.568	12.991881
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	31.220	8396.787	13.837651

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	349.670	749.690
SumSRA_Base_Basic	793.235	330.475	0.440815
SumSRA_Base	286.692	914.376	1.219672
SumSRA_Base_Core	270.760	968.180	1.291440
SumSRA_AdvSimd	89.138	2940.869	3.922780
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	106.239	2467.487	3.291343
SumSRATraits_Core	67.373	3890.935	5.190059
SumSRAConstTraits	63.516	4127.197	5.505205
SumSRAConstTraits_Core	63.447	4131.731	5.511253
SumSRAFast_AdvSimd	67.366	3891.328	5.190582
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	63.492	4128.745	5.507270

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	354.052	740.411
SumSRA_Base_Basic	549.372	477.170	0.644467
SumSRA_Base	542.411	483.294	0.652738
SumSRA_Base_Create	540.849	484.689	0.654622
SumSRA_Base_LoadArray	599.195	437.493	0.590879
SumSRA_Base_Core	541.971	483.686	0.653267
SumSRA_AdvSimd	185.947	1409.775	1.904044
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	212.410	1234.141	1.666833
SumSRATraits_Core	133.280	1966.865	2.656451
SumSRAConstTraits	132.924	1972.135	2.663569
SumSRAConstTraits_Core	126.512	2072.094	2.798574
SumSRAFast_AdvSimd	125.347	2091.349	2.824581
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	124.934	2098.265	2.833920

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	398.939	657.103
SumSRA_Base_Basic	368.140	712.076	1.083659
SumSRA_Base	77.038	3402.767	5.178434
SumSRA_Base_Core	67.447	3886.680	5.914868
SumSRA_AdvSimd	26.509	9888.768	15.049029
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	26.484	9898.131	15.063278
SumSRATraits_Core	16.567	15823.471	24.080642
SumSRAConstTraits	16.555	15834.775	24.097845
SumSRAConstTraits_Core	15.585	16820.135	25.597396
SumSRAFast_AdvSimd	15.594	16811.021	25.583526
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	15.679	16719.545	25.444315

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
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	318.860	822.128
SumSRANetBcl	26.387	9934.492	12.083877
SumSRANetBcl_Const	26.367	9942.126	12.093163
SumSRA_Base_Basic	476.969	549.604	0.668514
SumSRA_Base	26.339	9952.668	12.105986
SumSRA_Base_Core	26.387	9934.629	12.084044
SumSRA_AdvSimd	46.080	5688.943	6.919779
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	46.079	5689.049	6.919908
SumSRATraits_Core	26.375	9939.044	12.089414
SumSRAConstTraits	26.404	9928.330	12.076382
SumSRAConstTraits_Core	26.420	9922.240	12.068974
SumSRAFast_AdvSimd	26.343	9951.358	12.104392
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	26.366	9942.575	12.093709

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	223.901	1170.805
SumSRANetBcl	53.929	4860.899	4.151759
SumSRANetBcl_Const	53.961	4858.019	4.149299
SumSRA_Base_Basic	774.754	338.358	0.288996
SumSRA_Base	53.936	4860.276	4.151226
SumSRA_Base_Core	53.970	4857.179	4.148581
SumSRA_AdvSimd	79.633	3291.914	2.811668
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	79.597	3293.371	2.812912
SumSRATraits_Core	54.025	4852.282	4.144399
SumSRAConstTraits	54.150	4841.111	4.134857
SumSRAConstTraits_Core	54.143	4841.735	4.135391
SumSRAFast_AdvSimd	53.921	4861.587	4.152346
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	53.990	4855.400	4.147062

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	221.008	1186.131
SumSRANetBcl	106.114	2470.410	2.082747
SumSRANetBcl_Const	105.978	2473.566	2.085407
SumSRA_Base_Basic	549.395	477.151	0.402275
SumSRA_Base	107.351	2441.937	2.058742
SumSRA_Base_Create	147.641	1775.549	1.496926
SumSRA_Base_LoadArray	197.921	1324.486	1.116644
SumSRA_Base_Core	106.300	2466.085	2.079101
SumSRA_AdvSimd	184.365	1421.879	1.198754
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	184.354	1421.963	1.198825
SumSRATraits_Core	106.204	2468.310	2.080977
SumSRAConstTraits	105.982	2473.474	2.085330
SumSRAConstTraits_Core	106.119	2470.286	2.082642
SumSRAFast_AdvSimd	105.937	2474.530	2.086220
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	106.095	2470.841	2.083110

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	294.060	891.465
SumSRANetBcl	13.200	19859.179	22.277005
SumSRANetBcl_Const	13.198	19862.796	22.281063
SumSRA_Base_Basic	344.076	761.878	0.854636
SumSRA_Base	32.873	7974.465	8.945344
SumSRA_Base_Core	23.064	11365.760	12.749525
SumSRA_AdvSimd	23.050	11372.933	12.757571
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.054	11370.679	12.755043
SumSRATraits_Core	13.204	19853.636	22.270787
SumSRAConstTraits	13.223	19825.456	22.239177
SumSRAConstTraits_Core	13.215	19836.530	22.251599
SumSRAFast_AdvSimd	13.184	19883.116	22.303856
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	13.199	19860.853	22.278883

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

