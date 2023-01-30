# Benchmark - YClamp

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.4515.0
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


[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	20284
SumClamp_If	1220.453	214.792
SumClamp_MinMax	1294.029	202.580	0.943142
SumClamp_BitUtil	1219.784	214.910	1.000549
SumClampVectorScalar	402.639	651.065	3.031135
SumClampVectorBase	13.604	19270.220	89.715579
SumClampVectorTraits	67.226	3899.415	18.154349

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	1607778
SumClamp_If	1275.479	205.526
SumClamp_MinMax	1280.887	204.658	0.995778
SumClamp_BitUtil	818.980	320.086	1.557399
SumClampVectorScalar	256.404	1022.386	4.974487
SumClampVectorBase	27.023	9700.922	47.200482
SumClampVectorTraits	147.837	1773.201	8.627630

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141110628186068
SumClamp_If	2043.270	128.296
SumClamp_MinMax	1960.477	133.714	1.042231
SumClamp_BitUtil	1211.950	216.299	1.685936
SumClampVectorScalar	662.511	395.683	3.084131
SumClampVectorBase	163.095	1607.307	12.528088
SumClampVectorTraits	420.425	623.521	4.860007

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1771.407	147.986
SumClamp_MinMax	1636.438	160.192	1.082478
SumClamp_BitUtil	1295.498	202.350	1.367356
SumClampVectorScalar	481.717	544.186	3.677275
SumClampVectorBase	8.632	30367.229	205.202954
SumClampVectorTraits	36.884	7107.274	48.026561

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


[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	20284
SumClamp_If	1241.715	211.114
SumClamp_MinMax	1268.250	206.697	0.979077
SumClamp_Math	1408.247	186.149	0.881745
SumClamp_BitUtil	1340.387	195.573	0.926385
SumClampVectorScalar	411.371	637.245	3.018482
SumClampVectorBase	14.233	18418.034	87.241929
SumClampVectorTraits	71.199	3681.840	17.440018

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	1607778
SumClamp_If	1246.272	210.342
SumClamp_MinMax	1217.729	215.273	1.023440
SumClamp_Math	1192.005	219.919	1.045526
SumClamp_BitUtil	847.559	309.293	1.470425
SumClampVectorScalar	256.562	1021.755	4.857579
SumClampVectorBase	31.499	8322.378	39.565845
SumClampVectorTraits	175.339	1495.074	7.107806

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141110628186068
SumClamp_If	1493.971	175.468
SumClamp_MinMax	1636.794	160.157	0.912742
SumClamp_Math	1807.953	144.995	0.826333
SumClamp_BitUtil	968.953	270.544	1.541841
SumClampVectorScalar	465.106	563.622	3.212109
SumClampVectorBase	123.790	2117.648	12.068578
SumClampVectorTraits	358.473	731.279	4.167594

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1572.435	166.712
SumClamp_MinMax	1462.425	179.253	1.075224
SumClamp_Math	1510.950	173.496	1.040693
SumClamp_BitUtil	1286.925	203.698	1.221854
SumClampVectorScalar	466.992	561.346	3.367156
SumClampVectorBase	7.558	34682.533	208.038428
SumClampVectorTraits	41.489	6318.444	37.900321

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


[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	20284
SumClamp_If	1281.288	204.594
SumClamp_MinMax	1227.004	213.646	1.044241
SumClamp_Math	1218.633	215.113	1.051414
SumClamp_BitUtil	772.925	339.158	1.657713
SumClampVectorScalar	395.036	663.596	3.243472
SumClampVectorBase	13.354	19630.032	95.946188
SumClampVectorTraits	13.333	19660.580	96.095495
SumClampVector128Traits	1512.457	173.323	0.847157
SumClampVector256Traits	13.413	19543.834	95.524875

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	1607778
SumClamp_If	1200.144	218.427
SumClamp_MinMax	1202.072	218.077	0.998396
SumClamp_Math	1224.702	214.047	0.979947
SumClamp_BitUtil	543.524	482.304	2.208077
SumClampVectorScalar	235.450	1113.372	5.097225
SumClampVectorBase	25.719	10192.552	46.663386
SumClampVectorTraits	25.963	10096.929	46.225604
SumClampVector128Traits	2668.225	98.247	0.449791
SumClampVector256Traits	24.694	10615.644	48.600376

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141110628186068
SumClamp_If	1347.033	194.608
SumClamp_MinMax	1360.049	192.746	0.990429
SumClamp_Math	1354.312	193.563	0.994625
SumClamp_BitUtil	580.750	451.388	2.319469
SumClampVectorScalar	432.067	606.721	3.117648
SumClampVectorBase	105.513	2484.470	12.766505
SumClampVectorTraits	105.563	2483.293	12.760454
SumClampVector128Traits	2978.571	88.010	0.452241
SumClampVector256Traits	94.781	2765.799	14.212119

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1548.603	169.278
SumClamp_MinMax	1389.603	188.647	1.114421
SumClamp_Math	1514.986	173.034	1.022190
SumClamp_BitUtil	766.229	342.122	2.021072
SumClampVectorScalar	417.079	628.524	3.712977
SumClampVectorBase	6.141	42690.605	252.192726
SumClampVectorTraits	6.442	40692.796	240.390765
SumClampVector128Traits	938.788	279.237	1.649578
SumClampVector256Traits	6.232	42066.151	248.503791

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


[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	20284
SumClamp_If	1197.412	218.925
SumClamp_MinMax	1210.951	216.478	0.988819
SumClamp_Math	1173.286	223.427	1.020563
SumClamp_BitUtil	1131.494	231.680	1.058258
SumClampVectorScalar	394.699	664.162	3.033735
SumClampVectorBase	13.238	19802.645	90.453833
SumClampVectorTraits	13.017	20138.482	91.987857
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	1647.101	159.155	0.726981
SumClampVector256Traits	13.718	19109.889	87.289486

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	1607778
SumClamp_If	1256.829	208.576
SumClamp_MinMax	1197.379	218.932	1.049650
SumClamp_Math	1205.873	217.389	1.042257
SumClamp_BitUtil	872.095	300.591	1.441161
SumClampVectorScalar	235.295	1114.106	5.341498
SumClampVectorBase	27.067	9685.141	46.434667
SumClampVectorTraits	27.179	9645.134	46.242856
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	2666.374	98.315	0.471363
SumClampVector256Traits	26.556	9871.335	47.327360

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141110628186068
SumClamp_If	1306.404	200.661
SumClamp_MinMax	1410.065	185.909	0.926485
SumClamp_Math	1406.306	186.406	0.928961
SumClamp_BitUtil	958.502	273.493	1.362963
SumClampVectorScalar	439.809	596.041	2.970390
SumClampVectorBase	105.137	2493.363	12.425762
SumClampVectorTraits	105.850	2476.570	12.342073
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	3139.272	83.505	0.416149
SumClampVector256Traits	93.357	2807.970	13.993614

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1440.836	181.939
SumClamp_MinMax	1473.401	177.918	0.977898
SumClamp_Math	1439.913	182.055	1.000640
SumClamp_BitUtil	1131.005	231.780	1.273943
SumClampVectorScalar	414.381	632.616	3.477080
SumClampVectorBase	5.869	44663.752	245.487679
SumClampVectorTraits	5.951	44049.448	242.111247
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	1018.024	257.503	1.415326
SumClampVector256Traits	6.010	43617.172	239.735305

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


[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	20284
SumClamp_If	1232.150	212.753
SumClamp_MinMax	1298.274	201.917	0.949068
SumClamp_Math	1219.222	215.009	1.010603
SumClamp_BitUtil	927.472	282.644	1.328504
SumClampVectorScalar	404.035	648.815	3.049611
SumClampVectorBase	13.074	20051.524	94.247763
SumClampVectorTraits	13.167	19909.680	93.581056
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	1588.047	165.073	0.775890
SumClampVector256Traits	13.029	20119.974	94.569497

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	1607778
SumClamp_If	1205.295	217.494
SumClamp_MinMax	1297.037	202.110	0.929268
SumClamp_Math	1204.267	217.679	1.000854
SumClamp_BitUtil	857.234	305.802	1.406028
SumClampVectorScalar	236.005	1110.756	5.107073
SumClampVectorBase	26.605	9853.319	45.303944
SumClampVectorTraits	26.592	9857.857	45.324809
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	2673.160	98.065	0.450888
SumClampVector256Traits	26.054	10061.704	46.262060

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141110628186068
SumClamp_If	1299.239	201.767
SumClamp_MinMax	1340.562	195.548	0.969175
SumClamp_Math	1341.996	195.339	0.968139
SumClamp_BitUtil	964.772	271.716	1.346679
SumClampVectorScalar	431.666	607.284	3.009823
SumClampVectorBase	104.714	2503.424	12.407473
SumClampVectorTraits	104.499	2508.568	12.432967
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	3146.849	83.304	0.412870
SumClampVector256Traits	87.780	2986.387	14.801135

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1382.828	189.571
SumClamp_MinMax	1428.226	183.545	0.968214
SumClamp_Math	1319.350	198.692	1.048113
SumClamp_BitUtil	917.534	285.705	1.507115
SumClampVectorScalar	406.686	644.586	3.400236
SumClampVectorBase	5.846	44844.179	236.556235
SumClampVectorTraits	5.880	44585.662	235.192540
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	1020.329	256.921	1.355277
SumClampVector256Traits	5.834	44936.797	237.044801

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


[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	20284
SumClamp_If	1223.169	214.315
SumClamp_MinMax	1188.376	220.590	1.029278
SumClamp_Math	1182.340	221.716	1.034533
SumClamp_BitUtil	702.955	372.917	1.740039
SumClampVectorScalar	375.668	697.808	3.255986
SumClampVectorBase	12.570	20854.217	97.306192
SumClampVectorTraits	12.539	20906.846	97.551762
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	22.298	11756.220	54.854758
SumClampVector256Traits	12.389	21158.862	98.727675

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	1607778
SumClamp_If	1188.155	220.631
SumClamp_MinMax	1303.873	201.050	0.911250
SumClamp_Math	1166.783	224.673	1.018317
SumClamp_BitUtil	543.010	482.761	2.188092
SumClampVectorScalar	199.619	1313.224	5.952124
SumClampVectorBase	27.469	9543.296	43.254530
SumClampVectorTraits	27.477	9540.510	43.241904
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	98.725	2655.295	12.034999
SumClampVector256Traits	28.496	9199.450	41.696063

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141110628186068
SumClamp_If	1306.303	200.676
SumClamp_MinMax	1292.261	202.857	1.010866
SumClamp_Math	1267.740	206.781	1.030419
SumClamp_BitUtil	613.472	427.312	2.129361
SumClampVectorScalar	337.093	777.661	3.875204
SumClampVectorBase	79.744	3287.302	16.381122
SumClampVectorTraits	80.554	3254.260	16.216469
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	201.592	1300.367	6.479924
SumClampVector256Traits	106.049	2471.918	12.317942

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1334.087	196.497
SumClamp_MinMax	1325.491	197.771	1.006485
SumClamp_Math	1307.023	200.566	1.020707
SumClamp_BitUtil	697.414	375.880	1.912906
SumClampVectorScalar	373.636	701.602	3.570550
SumClampVectorBase	6.251	41936.446	213.420403
SumClampVectorTraits	6.281	41732.827	212.384156
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	23.099	11348.649	57.754851
SumClampVector256Traits	5.877	44602.929	226.990502

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

