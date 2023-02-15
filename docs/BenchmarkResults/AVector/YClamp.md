# Benchmark - YClamp
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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.256844812
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.256844812!=130882.256844812
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.256844812!=130882.256844812
SumClamp_If	1278.790	204.994
SumClamp_MinMax	1297.902	201.975	0.985275
SumClamp_BitUtil	1067.360	245.600	1.198087
SumClampVectorScalar	313.378	836.510	4.080663
SumClampVectorBase	79.905	3280.687	16.003842
SumClampVectorTraits	79.924	3279.912	16.000062

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1218.266	215.178
SumClamp_MinMax	1254.559	208.953	0.971071
SumClamp_BitUtil	1210.373	216.581	1.006521
SumClampVectorScalar	403.716	649.328	3.017630
SumClampVectorBase	12.392	21154.282	98.310624
SumClampVectorTraits	12.429	21091.378	98.018287

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1281.507	204.559
SumClamp_MinMax	1210.144	216.622	1.058971
SumClamp_BitUtil	788.247	332.566	1.625769
SumClampVectorScalar	235.148	1114.804	5.449791
SumClampVectorBase	28.852	9085.916	44.417071
SumClampVectorTraits	26.675	9827.426	48.041988

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1345.357	194.851
SumClamp_MinMax	1382.270	189.647	0.973295
SumClamp_BitUtil	866.274	302.611	1.553039
SumClampVectorScalar	423.387	619.160	3.177606
SumClampVectorBase	93.106	2815.533	14.449673
SumClampVectorTraits	95.671	2740.059	14.062331

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1498.837	174.898
SumClamp_MinMax	1460.018	179.549	1.026588
SumClamp_BitUtil	1211.198	216.434	1.237483
SumClampVectorScalar	414.765	632.030	3.613698
SumClampVectorBase	5.863	44710.538	255.637366
SumClampVectorTraits	5.879	44591.610	254.957385

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.5
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.3!=130883.5
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.3!=130883.5
SumClamp_If	1281.933	204.491
SumClamp_MinMax	1306.802	200.600	0.980969
SumClamp_BitUtil	1020.740	256.817	1.255885
SumClampVectorScalar	312.638	838.491	4.100376
SumClampVectorBase	39.268	6675.721	32.645510
SumClampVectorTraits	39.169	6692.600	32.728047

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.256844812
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.256844812!=130882.256844812
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.256844812!=130882.256844812
SumClamp_If	1303.555	201.099
SumClamp_MinMax	1354.399	193.550	0.962461
SumClamp_Math	1309.203	200.232	0.995686
SumClamp_BitUtil	1075.983	243.632	1.211502
SumClampVectorScalar	312.994	837.537	4.164794
SumClampVectorBase	79.549	3295.395	16.386910
SumClampVectorTraits	80.133	3271.377	16.267477

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1223.274	214.297
SumClamp_MinMax	1219.658	214.932	1.002965
SumClamp_Math	1196.261	219.136	1.022582
SumClamp_BitUtil	1214.080	215.920	1.007573
SumClampVectorScalar	403.367	649.890	3.032662
SumClampVectorBase	13.339	19652.096	91.704961
SumClampVectorTraits	13.465	19468.915	90.850161

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1229.701	213.177
SumClamp_MinMax	1204.950	217.556	1.020541
SumClamp_Math	1205.386	217.477	1.020172
SumClamp_BitUtil	786.233	333.418	1.564041
SumClampVectorScalar	237.702	1102.826	5.173287
SumClampVectorBase	26.733	9806.070	45.999657
SumClampVectorTraits	27.092	9675.957	45.389306

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1319.679	198.642
SumClamp_MinMax	1417.058	184.992	0.931281
SumClamp_Math	1340.625	195.539	0.984375
SumClamp_BitUtil	872.383	300.492	1.512728
SumClampVectorScalar	429.040	611.001	3.075887
SumClampVectorBase	104.081	2518.661	12.679379
SumClampVectorTraits	107.873	2430.127	12.233680

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1458.717	179.709
SumClamp_MinMax	1433.327	182.892	1.017714
SumClamp_Math	1351.735	193.931	1.079144
SumClamp_BitUtil	1209.768	216.689	1.205782
SumClampVectorScalar	414.860	631.885	3.516167
SumClampVectorBase	5.886	44537.136	247.829809
SumClampVectorTraits	5.912	44344.030	246.755260

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.5
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.3!=130883.5
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.3!=130883.5
SumClamp_If	1302.218	201.306
SumClamp_MinMax	1353.365	193.698	0.962207
SumClamp_Math	1285.514	203.921	1.012994
SumClamp_BitUtil	1010.096	259.524	1.289202
SumClampVectorScalar	311.737	840.913	4.177290
SumClampVectorBase	39.372	6658.132	33.074715
SumClampVectorTraits	39.619	6616.698	32.868888

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1302.668	201.236
SumClamp_MinMax	1949.083	134.496	0.668349
SumClamp_Math	1222.904	214.362	1.065225
SumClamp_BitUtil	893.727	293.316	1.457569
SumClampVectorScalar	313.044	837.402	4.161291
SumClampVectorBase	79.771	3286.224	16.330182
SumClampVectorTraits	79.952	3278.779	16.293188
SumClampVector128Traits	3370.997	77.765	0.386434
SumClampVector256Traits	82.251	3187.136	15.837786

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1246.485	210.307
SumClamp_MinMax	1232.756	212.649	1.011137
SumClamp_Math	1275.097	205.588	0.977562
SumClamp_BitUtil	776.497	337.598	1.605268
SumClampVectorScalar	396.520	661.112	3.143564
SumClampVectorBase	13.393	19572.835	93.068135
SumClampVectorTraits	12.788	20499.498	97.474384
SumClampVector128Traits	1517.063	172.797	0.821644
SumClampVector256Traits	12.343	21237.875	100.985341

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1201.735	218.138
SumClamp_MinMax	1202.870	217.932	0.999056
SumClamp_Math	1225.554	213.898	0.980565
SumClamp_BitUtil	548.126	478.255	2.192443
SumClampVectorScalar	237.015	1106.024	5.070295
SumClampVectorBase	27.491	9535.606	43.713634
SumClampVectorTraits	30.106	8707.444	39.917129
SumClampVector128Traits	2674.456	98.018	0.449338
SumClampVector256Traits	26.806	9779.266	44.830633

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1355.187	193.437
SumClamp_MinMax	1355.914	193.334	0.999464
SumClamp_Math	1342.475	195.269	1.009469
SumClamp_BitUtil	584.966	448.136	2.316695
SumClampVectorScalar	434.549	603.255	3.118603
SumClampVectorBase	93.582	2801.237	14.481354
SumClampVectorTraits	93.786	2795.139	14.449830
SumClampVector128Traits	2964.558	88.426	0.457130
SumClampVector256Traits	79.943	3279.118	16.951822

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1406.891	186.329
SumClamp_MinMax	1386.277	189.099	1.014870
SumClamp_Math	1861.294	140.840	0.755867
SumClamp_BitUtil	1057.576	247.872	1.330298
SumClampVectorScalar	418.883	625.817	3.358675
SumClampVectorBase	6.115	42871.946	230.087939
SumClampVectorTraits	6.100	42974.441	230.638012
SumClampVector128Traits	916.269	286.099	1.535457
SumClampVector256Traits	5.848	44829.154	240.592008

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1272.589	205.993
SumClamp_MinMax	1859.313	140.990	0.684440
SumClamp_Math	1296.876	202.135	0.981272
SumClamp_BitUtil	864.192	303.340	1.472577
SumClampVectorScalar	311.561	841.390	4.084561
SumClampVectorBase	39.143	6697.154	32.511601
SumClampVectorTraits	39.243	6680.041	32.428528
SumClampVector128Traits	2822.342	92.882	0.450898
SumClampVector256Traits	39.083	6707.323	32.560969

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1303.448	201.116
SumClamp_MinMax	1744.388	150.279	0.747224
SumClamp_Math	1313.766	199.536	0.992146
SumClamp_BitUtil	1289.799	203.244	1.010582
SumClampVectorScalar	321.534	815.291	4.053838
SumClampVectorBase	86.183	3041.701	15.124130
SumClampVectorTraits	87.897	2982.414	14.829342
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	3691.367	71.015	0.353107
SumClampVector256Traits	86.465	3031.777	15.074786

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1229.598	213.195
SumClamp_MinMax	1281.831	204.507	0.959251
SumClamp_Math	1218.067	215.213	1.009466
SumClamp_BitUtil	1173.174	223.448	1.048095
SumClampVectorScalar	393.790	665.695	3.122470
SumClampVectorBase	13.569	19319.646	90.619647
SumClampVectorTraits	14.817	17691.715	82.983766
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	1626.591	161.162	0.755935
SumClampVector256Traits	14.268	18373.474	86.181583

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1313.783	199.534
SumClamp_MinMax	1208.619	216.895	1.087012
SumClamp_Math	1259.543	208.126	1.043064
SumClamp_BitUtil	857.776	305.609	1.531616
SumClampVectorScalar	240.223	1091.252	5.469013
SumClampVectorBase	28.963	9051.076	45.361135
SumClampVectorTraits	28.550	9181.877	46.016670
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	2670.314	98.170	0.491996
SumClampVector256Traits	27.908	9393.211	47.075809

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1371.347	191.158
SumClamp_MinMax	1493.736	175.496	0.918065
SumClamp_Math	1429.545	183.376	0.959289
SumClamp_BitUtil	1007.046	260.310	1.361752
SumClampVectorScalar	436.253	600.898	3.143463
SumClampVectorBase	107.094	2447.795	12.805082
SumClampVectorTraits	106.505	2461.332	12.875899
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	3172.968	82.618	0.432197
SumClampVector256Traits	89.697	2922.554	15.288679

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1401.853	186.998
SumClamp_MinMax	1446.588	181.215	0.969075
SumClamp_Math	1460.802	179.452	0.959646
SumClamp_BitUtil	1139.867	229.978	1.229838
SumClampVectorScalar	419.489	624.913	3.341810
SumClampVectorBase	6.199	42288.784	226.145331
SumClampVectorTraits	6.157	42575.769	227.680026
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	1039.102	252.279	1.349100
SumClampVector256Traits	5.989	43770.958	234.071472

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1283.871	204.182
SumClamp_MinMax	1716.660	152.706	0.747889
SumClamp_Math	1233.542	212.513	1.040801
SumClamp_BitUtil	1081.881	242.304	1.186703
SumClampVectorScalar	312.344	839.279	4.110436
SumClampVectorBase	39.148	6696.206	32.795210
SumClampVectorTraits	39.249	6679.069	32.711278
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	3174.490	82.578	0.404434
SumClampVector256Traits	39.327	6665.739	32.645991

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1238.401	211.679
SumClamp_MinMax	1736.461	150.964	0.713175
SumClamp_Math	1307.454	200.500	0.947185
SumClamp_BitUtil	1060.192	247.261	1.168091
SumClampVectorScalar	315.673	830.429	3.923050
SumClampVectorBase	81.826	3203.663	15.134508
SumClampVectorTraits	82.084	3193.609	15.087013
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	3602.025	72.777	0.343807
SumClampVector256Traits	82.716	3169.204	14.971720

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1221.743	214.566
SumClamp_MinMax	1304.557	200.945	0.936519
SumClamp_Math	1214.624	215.823	1.005861
SumClamp_BitUtil	920.677	284.729	1.327004
SumClampVectorScalar	404.403	648.225	3.021102
SumClampVectorBase	13.653	19200.505	89.485451
SumClampVectorTraits	14.217	18438.419	85.933692
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	1587.180	165.163	0.769757
SumClampVector256Traits	13.035	20110.578	93.726921

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1201.188	218.237
SumClamp_MinMax	1289.546	203.284	0.931481
SumClamp_Math	1173.763	223.336	1.023365
SumClamp_BitUtil	857.663	305.649	1.400536
SumClampVectorScalar	235.747	1111.974	5.095249
SumClampVectorBase	26.632	9843.205	45.103210
SumClampVectorTraits	26.960	9723.548	44.554922
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	2660.893	98.517	0.451423
SumClampVector256Traits	26.342	9951.716	45.600427

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1299.099	201.789
SumClamp_MinMax	1362.622	192.382	0.953382
SumClamp_Math	1340.204	195.600	0.969330
SumClamp_BitUtil	956.949	273.937	1.357542
SumClampVectorScalar	432.497	606.118	3.003719
SumClampVectorBase	103.090	2542.859	12.601571
SumClampVectorTraits	103.289	2537.960	12.577292
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	3171.931	82.645	0.409561
SumClampVector256Traits	87.836	2984.483	14.790116

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1388.956	188.735
SumClamp_MinMax	1403.792	186.740	0.989432
SumClamp_Math	1316.777	199.080	1.054815
SumClamp_BitUtil	921.446	284.492	1.507366
SumClampVectorScalar	406.499	644.882	3.416872
SumClampVectorBase	5.844	44860.280	237.689842
SumClampVectorTraits	6.019	43554.301	230.770182
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	1019.631	257.097	1.362214
SumClampVector256Traits	5.925	44244.131	234.425209

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1222.934	214.357
SumClamp_MinMax	1900.013	137.970	0.643645
SumClamp_Math	1302.155	201.316	0.939162
SumClamp_BitUtil	991.618	264.360	1.233271
SumClampVectorScalar	312.702	838.319	3.910858
SumClampVectorBase	39.568	6625.083	30.906825
SumClampVectorTraits	39.282	6673.399	31.132225
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	3185.721	82.287	0.383880
SumClampVector256Traits	39.384	6656.059	31.051331

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684481168!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1281.401	204.576
SumClamp_MinMax	316.710	827.710	4.045975
SumClamp_Math	1197.972	218.823	1.069642
SumClamp_BitUtil	842.105	311.296	1.521664
SumClampVectorScalar	314.875	832.534	4.069559
SumClampVectorBase	80.917	3239.645	15.835899
SumClampVectorTraits	81.020	3235.564	15.815948
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	159.054	1648.140	8.056371
SumClampVector256Traits	85.640	3061.013	14.962714

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1193.308	219.678
SumClamp_MinMax	1184.826	221.251	1.007159
SumClamp_Math	1171.943	223.683	1.018230
SumClamp_BitUtil	717.331	365.444	1.663539
SumClampVectorScalar	373.756	701.377	3.192744
SumClampVectorBase	13.606	19266.375	87.702660
SumClampVectorTraits	13.780	19023.052	86.595026
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	23.356	11223.871	51.092296
SumClampVector256Traits	15.114	17344.316	78.953237

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1198.277	218.767
SumClamp_MinMax	1301.735	201.380	0.920523
SumClamp_Math	1175.245	223.055	1.019598
SumClamp_BitUtil	545.258	480.770	2.197632
SumClampVectorScalar	197.849	1324.968	6.056518
SumClampVectorBase	25.328	10350.095	47.310966
SumClampVectorTraits	27.585	9503.202	43.439764
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	99.950	2622.757	11.988794
SumClampVector256Traits	28.467	9208.810	42.094078

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1307.671	200.466
SumClamp_MinMax	1309.188	200.234	0.998841
SumClamp_Math	1313.632	199.557	0.995462
SumClamp_BitUtil	611.124	428.954	2.139780
SumClampVectorScalar	337.589	776.519	3.873563
SumClampVectorBase	87.569	2993.575	14.933054
SumClampVectorTraits	87.263	3004.058	14.985346
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128_Arm64	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	205.230	1277.319	6.371735
SumClampVector256Traits	116.934	2241.818	11.183012

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1326.919	197.558
SumClamp_MinMax	1321.584	198.356	1.004037
SumClamp_Math	1299.695	201.697	1.020946
SumClamp_BitUtil	703.129	372.825	1.887161
SumClampVectorScalar	371.066	706.461	3.575960
SumClampVectorBase	5.804	45163.208	228.606804
SumClampVectorTraits	5.775	45390.898	229.759320
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	23.782	11022.757	55.794912
SumClampVector256Traits	6.160	42557.906	215.419304

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.305!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.305!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1250.610	209.613
SumClamp_MinMax	311.338	841.990	4.016881
SumClamp_Math	1183.071	221.579	1.057088
SumClamp_BitUtil	765.063	342.644	1.634649
SumClampVectorScalar	315.059	832.048	3.969448
SumClampVectorBase	39.228	6682.598	31.880649
SumClampVectorTraits	39.245	6679.743	31.867030
SumClampVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumClampVector128Traits	78.521	3338.523	15.927081
SumClampVector256Traits	40.318	6501.880	31.018498

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1587.760	165.103
SumClamp_MinMax	2178.762	120.318	0.728744
SumClamp_Math	1474.440	177.792	1.076856
SumClamp_BitUtil	1596.014	164.249	0.994828
SumClampVectorScalar	385.613	679.811	4.117494
SumClampVectorBase	134.909	1943.113	11.769091
SumClampVectorTraits	134.523	1948.691	11.802874
SumClampVector128Traits	2949.064	88.891	0.538394
SumClampVector256Traits	7154.960	36.638	0.221910

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1529.624	171.378
SumClamp_MinMax	1621.412	161.676	0.943390
SumClamp_Math	1621.400	161.678	0.943397
SumClamp_BitUtil	1189.230	220.432	1.286231
SumClampVectorScalar	613.607	427.218	2.492838
SumClampVectorBase	39.638	6613.497	38.590105
SumClampVectorTraits	33.320	7867.359	45.906454
SumClampVector128Traits	1751.056	149.706	0.873544
SumClampVector256Traits	2684.773	97.641	0.569741

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1563.886	167.624
SumClamp_MinMax	1529.022	171.446	1.022802
SumClamp_Math	1506.342	174.027	1.038201
SumClamp_BitUtil	947.644	276.627	1.650288
SumClampVectorScalar	421.654	621.704	3.708930
SumClampVectorBase	79.618	3292.520	19.642350
SumClampVectorTraits	79.724	3288.143	19.616237
SumClampVector128Traits	3316.644	79.039	0.471527
SumClampVector256Traits	5210.626	50.310	0.300134

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1591.384	164.727
SumClamp_MinMax	1733.247	151.244	0.918152
SumClamp_Math	1553.532	168.741	1.024365
SumClamp_BitUtil	1056.874	248.037	1.505747
SumClampVectorScalar	716.438	365.899	2.221244
SumClampVectorBase	284.392	921.771	5.595750
SumClampVectorTraits	284.577	921.170	5.592097
SumClampVector128Traits	2319.325	113.026	0.686141
SumClampVector256Traits	4416.653	59.354	0.360314

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1645.522	159.307
SumClamp_MinMax	1596.838	164.164	1.030488
SumClamp_Math	1640.774	159.768	1.002894
SumClamp_BitUtil	1158.909	226.199	1.419889
SumClampVectorScalar	594.904	440.649	2.766031
SumClampVectorBase	19.825	13223.016	83.003112
SumClampVectorTraits	19.838	13214.068	82.946948
SumClampVector128Traits	1061.056	247.060	1.550834
SumClampVector256Traits	1576.512	166.281	1.043774

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1570.506	166.917
SumClamp_MinMax	2168.072	120.911	0.724379
SumClamp_Math	1471.624	178.132	1.067193
SumClamp_BitUtil	1521.857	172.253	1.031967
SumClampVectorScalar	383.035	684.387	4.100168
SumClampVectorBase	67.553	3880.545	23.248371
SumClampVectorTraits	67.589	3878.492	23.236073
SumClampVector128Traits	3266.738	80.246	0.480757
SumClampVector256Traits	5130.562	51.095	0.306108

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128_Arm	Check `SumClampVector128_Arm` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1545.658	169.600
SumClamp_MinMax	2004.861	130.754	0.770955
SumClamp_Math	1465.969	178.820	1.054359
SumClamp_BitUtil	2320.424	112.972	0.666110
SumClampVectorScalar	389.378	673.237	3.969551
SumClampVectorBase	133.863	1958.302	11.546574
SumClampVectorTraits	133.869	1958.206	11.546006
SumClampVector128_Arm	1485.092	176.517	1.040783
SumClampVector128Traits	133.392	1965.215	11.587332
SumClampVector256Traits	3008.985	87.120	0.513681

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1551.573	168.954
SumClamp_MinMax	1531.442	171.175	1.013145
SumClamp_Math	1557.712	168.288	0.996059
SumClamp_BitUtil	1553.268	168.769	0.998909
SumClampVectorScalar	614.415	426.656	2.525286
SumClampVectorBase	40.043	6546.640	38.748137
SumClampVectorTraits	34.095	7688.617	45.507251
SumClampVector128_Arm	33.918	7728.677	45.744359
SumClampVector128Traits	40.314	6502.519	38.486995
SumClampVector256Traits	2387.483	109.799	0.649878

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1480.971	177.008
SumClamp_MinMax	1581.713	165.734	0.936309
SumClamp_Math	1528.743	171.477	0.968751
SumClamp_BitUtil	1242.354	211.006	1.192069
SumClampVectorScalar	399.912	655.504	3.703241
SumClampVectorBase	68.779	3811.396	21.532319
SumClampVectorTraits	68.541	3824.629	21.607079
SumClampVector128_Arm	80.577	3253.323	18.379512
SumClampVector128Traits	80.209	3268.265	18.463925
SumClampVector256Traits	3175.573	82.550	0.466364

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1633.783	160.452
SumClamp_MinMax	1707.506	153.525	0.956824
SumClamp_Math	1599.495	163.892	1.021437
SumClamp_BitUtil	1377.648	190.284	1.185922
SumClampVectorScalar	467.718	560.475	3.493096
SumClampVectorBase	184.843	1418.196	8.838744
SumClampVectorTraits	186.486	1405.707	8.760906
SumClampVector128_Arm	1433.062	182.926	1.140064
SumClampVector128_Arm64	184.592	1420.127	8.850777
SumClampVector128Traits	184.916	1417.636	8.835252
SumClampVector256Traits	2571.964	101.924	0.635228

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1576.240	166.310
SumClamp_MinMax	1706.391	153.625	0.923728
SumClamp_Math	1641.762	159.672	0.960091
SumClamp_BitUtil	1502.352	174.489	1.049182
SumClampVectorScalar	598.317	438.135	2.634455
SumClampVectorBase	16.892	15518.749	93.312369
SumClampVectorTraits	16.965	15452.052	92.911328
SumClampVector128_Arm	20.029	13088.214	78.697854
SumClampVector128Traits	20.017	13096.164	78.745654
SumClampVector256Traits	1828.070	143.399	0.862243

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_Arm	Check `SumClampVector128_Arm` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1462.712	179.218
SumClamp_MinMax	2017.755	129.919	0.724920
SumClamp_Math	1511.019	173.488	0.968030
SumClamp_BitUtil	2055.388	127.540	0.711648
SumClampVectorScalar	383.274	683.960	3.816363
SumClampVectorBase	80.646	3250.539	18.137367
SumClampVectorTraits	68.422	3831.290	21.377847
SumClampVector128_Arm	68.899	3804.758	21.229801
SumClampVector128Traits	68.923	3803.452	21.222516
SumClampVector256Traits	3089.452	84.851	0.473454

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128_Arm	Check `SumClampVector128_Arm` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1490.817	175.839
SumClamp_MinMax	1931.634	135.711	0.771791
SumClamp_Math	1425.787	183.859	1.045610
SumClamp_BitUtil	2337.483	112.148	0.637788
SumClampVectorScalar	426.213	615.053	3.497819
SumClampVectorBase	134.121	1954.541	11.115508
SumClampVectorTraits	133.522	1963.298	11.165311
SumClampVector128_Arm	1481.306	176.968	1.006421
SumClampVector128Traits	134.207	1953.280	11.108339
SumClampVector256Traits	3199.120	81.943	0.466009

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1558.021	168.255
SumClamp_MinMax	1687.553	155.340	0.923243
SumClamp_Math	1591.123	164.754	0.979196
SumClamp_BitUtil	1551.969	168.911	1.003900
SumClampVectorScalar	616.165	425.445	2.528577
SumClampVectorBase	33.748	7767.658	46.166123
SumClampVectorTraits	34.062	7696.191	45.741370
SumClampVector128_Arm	34.062	7696.195	45.741390
SumClampVector128Traits	34.016	7706.450	45.802340
SumClampVector256Traits	2529.319	103.642	0.615984

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1476.857	177.501
SumClamp_MinMax	1572.279	166.729	0.939310
SumClamp_Math	1531.052	171.218	0.964603
SumClamp_BitUtil	1246.213	210.353	1.185077
SumClampVectorScalar	408.270	642.084	3.617352
SumClampVectorBase	68.809	3809.717	21.463049
SumClampVectorTraits	68.795	3810.521	21.467577
SumClampVector128_Arm	68.485	3827.758	21.564685
SumClampVector128Traits	68.780	3811.325	21.472103
SumClampVector256Traits	3205.332	81.784	0.460750

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1586.389	165.246
SumClamp_MinMax	1646.458	159.217	0.963516
SumClamp_Math	1568.312	167.150	1.011526
SumClamp_BitUtil	1374.063	190.780	1.154524
SumClampVectorScalar	507.200	516.846	3.127739
SumClampVectorBase	184.843	1418.199	8.582366
SumClampVectorTraits	184.533	1420.583	8.596791
SumClampVector128_Arm	1428.160	183.554	1.110792
SumClampVector128_Arm64	184.449	1421.224	8.600668
SumClampVector128Traits	186.012	1409.283	8.528407
SumClampVector256Traits	2702.764	96.991	0.586951

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1583.729	165.523
SumClamp_MinMax	1630.137	160.811	0.971531
SumClamp_Math	1558.250	168.230	1.016351
SumClamp_BitUtil	1469.260	178.419	1.077909
SumClampVectorScalar	566.095	463.074	2.797636
SumClampVectorBase	17.036	15387.905	92.965177
SumClampVectorTraits	17.035	15388.486	92.968686
SumClampVector128_Arm	16.940	15474.626	93.489100
SumClampVector128Traits	17.058	15367.514	92.841987
SumClampVector256Traits	1908.234	137.375	0.829944

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_Arm	Check `SumClampVector128_Arm` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1475.081	177.715
SumClamp_MinMax	2032.980	128.946	0.725576
SumClamp_Math	1458.920	179.684	1.011078
SumClamp_BitUtil	2047.835	128.010	0.720312
SumClampVectorScalar	425.848	615.581	3.463865
SumClampVectorBase	69.252	3785.379	21.300284
SumClampVectorTraits	69.797	3755.782	21.133740
SumClampVector128_Arm	69.067	3795.518	21.357336
SumClampVector128Traits	69.155	3790.700	21.330227
SumClampVector256Traits	3164.462	82.840	0.466140

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


[YClampBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130882.25684481156
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128_Arm	Check `SumClampVector128_Arm` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130882.25684480942!=130882.25684481156
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.25684481168!=130882.25684481156
SumClamp_If	1242.012	211.064
SumClamp_MinMax	211.667	1238.472	5.867754
SumClamp_Math	1218.118	215.204	1.019615
SumClamp_BitUtil	1018.869	257.289	1.219010
SumClampVectorScalar	308.497	849.746	4.026009
SumClampVectorBase	112.888	2322.158	11.002150
SumClampVectorTraits	112.892	2322.076	11.001762
SumClampVector128_Arm	1465.925	178.825	0.847255
SumClampVector128Traits	136.025	1927.171	9.130739
SumClampVector256Traits	3018.289	86.852	0.411495

[YClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	25723
SumClamp_If	1323.253	198.106
SumClamp_MinMax	1383.570	189.469	0.956405
SumClamp_Math	1341.639	195.391	0.986295
SumClamp_BitUtil	1231.898	212.797	1.074158
SumClampVectorScalar	469.642	558.178	2.817575
SumClampVectorBase	26.780	9788.683	49.411401
SumClampVectorTraits	26.843	9765.709	49.295434
SumClampVector128_Arm	33.195	7897.137	39.863238
SumClampVector128Traits	33.165	7904.151	39.898645
SumClampVector256Traits	4170.027	62.864	0.317325

[YClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-31956128
SumClamp_If	1304.687	200.925
SumClamp_MinMax	1353.238	193.716	0.964123
SumClamp_Math	1253.535	209.124	1.040806
SumClamp_BitUtil	936.393	279.951	1.393312
SumClampVectorScalar	265.359	987.884	4.916686
SumClampVectorBase	55.208	4748.260	23.632030
SumClampVectorTraits	55.197	4749.250	23.636953
SumClampVector128_Arm	67.499	3883.688	19.329065
SumClampVector128Traits	67.505	3883.312	19.327194
SumClampVector256Traits	3604.374	72.729	0.361973

[YClampBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141951893350734
SumClamp_If	1315.407	199.287
SumClamp_MinMax	1284.572	204.071	1.024005
SumClamp_Math	1361.282	192.571	0.966301
SumClamp_BitUtil	1065.777	245.965	1.234224
SumClampVectorScalar	508.650	515.372	2.586075
SumClampVectorBase	153.943	1702.859	8.544743
SumClampVectorTraits	153.899	1703.353	8.547222
SumClampVector128_Arm	1423.875	184.106	0.923822
SumClampVector128_Arm64	187.516	1397.983	7.014911
SumClampVector128Traits	187.715	1396.501	7.007476
SumClampVector256Traits	3090.383	84.826	0.425645

[YClampBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	6
SumClamp_If	1318.346	198.843
SumClamp_MinMax	1285.266	203.961	1.025737
SumClamp_Math	1287.821	203.556	1.023702
SumClamp_BitUtil	1136.966	230.565	1.159530
SumClampVectorScalar	429.084	610.939	3.072465
SumClampVectorBase	13.477	19450.689	97.819251
SumClampVectorTraits	13.466	19467.714	97.904871
SumClampVector128_Arm	16.624	15768.957	79.303491
SumClampVector128Traits	16.640	15753.675	79.226640
SumClampVector256Traits	3059.376	85.685	0.430920

[YClampBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	130883.55
Check-SumClampVectorBase	Check `SumClampVectorBase` mismatch. 130881.91!=130883.55
Check-SumClampVectorTraits	Check `SumClampVectorTraits` mismatch. 130881.91!=130883.55
Check-SumClampVector128_Arm	Check `SumClampVector128_Arm` mismatch. 130881.91!=130883.55
Check-SumClampVector128Traits	Check `SumClampVector128Traits` mismatch. 130881.91!=130883.55
Check-SumClampVector256Traits	Check `SumClampVector256Traits` mismatch. 130882.305!=130883.55
SumClamp_If	1239.933	211.418
SumClamp_MinMax	212.646	1232.772	5.830974
SumClamp_Math	1220.643	214.759	1.015803
SumClamp_BitUtil	937.140	279.728	1.323103
SumClampVectorScalar	307.763	851.772	4.028856
SumClampVectorBase	55.491	4724.083	22.344763
SumClampVectorTraits	55.541	4719.848	22.324734
SumClampVector128_Arm	68.011	3854.423	18.231298
SumClampVector128Traits	67.863	3862.869	18.271251
SumClampVector256Traits	2887.323	90.791	0.429440

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

