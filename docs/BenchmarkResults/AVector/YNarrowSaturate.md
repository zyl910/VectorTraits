# Benchmark - YNarrowSaturate
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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1267.777	206.775
SumNarrow_IfUnrolling4	1243.532	210.806	1.019497
SumNarrow_MinMax	1302.260	201.299	0.973521
SumNarrow_MinMaxUnrolling4	1287.651	203.583	0.984565
SumNarrow_BitUtil	1195.533	219.270	1.060428
SumNarrow_BitUtilUnrolling4	845.363	310.096	1.499683
SumNarrowVectorBase	42.393	6183.593	29.905000
SumNarrowVectorTraits	17.566	14923.605	72.173312

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1227.638	213.535
SumNarrow_MinMax	1228.555	213.376	0.999253
SumNarrow_BitUtil	599.194	437.494	2.048814
SumNarrowVectorBase	87.598	2992.565	14.014387
SumNarrowVectorTraits	40.175	6525.001	30.557024

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1331.241	196.917
SumNarrow_MinMax	1384.135	189.392	0.961786
SumNarrow_BitUtil	779.939	336.108	1.706853
SumNarrowVectorBase	218.706	1198.614	6.086898
SumNarrowVectorTraits	129.388	2026.032	10.288763

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	316.812	827.443
SumNarrow_IfUnrolling4	248.720	1053.973	1.273771
SumNarrow_MinMax	300.922	871.135	1.052804
SumNarrow_MinMaxUnrolling4	224.709	1166.592	1.409876
SumNarrow_BitUtil	448.206	584.874	0.706845
SumNarrow_BitUtilUnrolling4	556.937	470.689	0.568847
SumNarrowVectorBase	44.273	5921.068	7.155863
SumNarrowVectorTraits	17.317	15138.033	18.294959

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	286.115	916.220
SumNarrow_MinMax	294.775	889.301	0.970620
SumNarrow_BitUtil	510.429	513.576	0.560538
SumNarrowVectorBase	90.885	2884.357	3.148105
SumNarrowVectorTraits	36.047	7272.381	7.937373

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	306.489	855.314
SumNarrow_MinMax	268.106	977.762	1.143162
SumNarrow_BitUtil	396.513	661.123	0.772960
SumNarrowVectorBase	229.111	1144.178	1.337728
SumNarrowVectorTraits	139.141	1884.023	2.202726

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1238.289	211.699
SumNarrow_IfUnrolling4	1241.274	211.189	0.997595
SumNarrow_MinMax	1239.095	211.561	0.999349
SumNarrow_MinMaxUnrolling4	1207.958	217.014	1.025109
SumNarrow_BitUtil	1196.363	219.117	1.035044
SumNarrow_BitUtilUnrolling4	840.122	312.031	1.473939
SumNarrowVectorBase	40.918	6406.529	30.262498
SumNarrowVectorTraits	20.225	12961.424	61.225830

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1246.093	210.373
SumNarrow_MinMax	1229.204	213.263	1.013740
SumNarrow_BitUtil	600.025	436.888	2.076735
SumNarrowVectorBase	80.954	3238.193	15.392643
SumNarrowVectorTraits	37.839	6927.874	32.931420

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1408.838	186.071
SumNarrow_MinMax	1482.954	176.772	0.950022
SumNarrow_BitUtil	785.264	333.829	1.794095
SumNarrowVectorBase	207.650	1262.430	6.784670
SumNarrowVectorTraits	132.121	1984.125	10.663264

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	296.413	884.389
SumNarrow_IfUnrolling4	249.186	1052.002	1.189524
SumNarrow_MinMax	383.623	683.337	0.772666
SumNarrow_MinMaxUnrolling4	238.105	1100.960	1.244882
SumNarrow_BitUtil	620.907	422.195	0.477386
SumNarrow_BitUtilUnrolling4	551.752	475.112	0.537221
SumNarrowVectorBase	35.149	7458.062	8.433010
SumNarrowVectorTraits	17.399	15066.506	17.036059

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	520.300	503.832
SumNarrow_MinMax	390.571	671.181	1.332151
SumNarrow_BitUtil	785.685	333.650	0.662224
SumNarrowVectorBase	130.967	2001.602	3.972753
SumNarrowVectorTraits	49.535	5292.044	10.503579

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	293.792	892.278
SumNarrow_MinMax	321.375	815.695	0.914172
SumNarrow_BitUtil	369.498	709.459	0.795110
SumNarrowVectorBase	245.313	1068.612	1.197623
SumNarrowVectorTraits	146.699	1786.954	2.002689

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1267.546	206.812
SumNarrow_IfUnrolling4	1286.552	203.757	0.985227
SumNarrow_MinMax	1251.622	209.443	1.012723
SumNarrow_MinMaxUnrolling4	1230.060	213.115	1.030475
SumNarrow_BitUtil	1206.136	217.342	1.050915
SumNarrow_BitUtilUnrolling4	818.031	320.457	1.549509
SumNarrowVectorBase	37.376	7013.756	33.913656
SumNarrowVectorTraits	10.593	24747.098	119.659793
SumNarrowVector128Traits	1684.104	155.658	0.752653
SumNarrowVector256Traits	63.234	4145.627	20.045375

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1247.622	210.115
SumNarrow_MinMax	1238.380	211.683	1.007463
SumNarrow_BitUtil	752.051	348.572	1.658959
SumNarrowVectorBase	65.989	3972.517	18.906401
SumNarrowVectorTraits	18.909	13863.643	65.981248
SumNarrowVector128Traits	2738.830	95.714	0.455531
SumNarrowVector256Traits	19.125	13706.701	65.234312

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1329.479	197.178
SumNarrow_MinMax	1377.170	190.350	0.965370
SumNarrow_BitUtil	782.195	335.139	1.699678
SumNarrowVectorBase	186.517	1405.468	7.127914
SumNarrowVectorTraits	158.641	1652.435	8.380421
SumNarrowVector128Traits	3362.872	77.952	0.395340
SumNarrowVector256Traits	104.426	2510.339	12.731333

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	246.174	1064.875
SumNarrow_IfUnrolling4	243.678	1075.779	1.010240
SumNarrow_MinMax	254.646	1029.446	0.966730
SumNarrow_MinMaxUnrolling4	331.465	790.865	0.742683
SumNarrow_BitUtil	545.852	480.247	0.450989
SumNarrow_BitUtilUnrolling4	540.710	484.814	0.455278
SumNarrowVectorBase	30.395	8624.650	8.099215
SumNarrowVectorTraits	25.336	10346.772	9.716421
SumNarrowVector128Traits	941.562	278.414	0.261452
SumNarrowVector256Traits	14.566	17997.490	16.901038

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	320.495	817.934
SumNarrow_MinMax	303.936	862.497	1.054482
SumNarrow_BitUtil	587.593	446.132	0.545437
SumNarrowVectorBase	59.956	4372.290	5.345528
SumNarrowVectorTraits	54.977	4768.241	5.829615
SumNarrowVector128Traits	1808.532	144.948	0.177213
SumNarrowVector256Traits	26.093	10046.543	12.282825

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	279.717	937.175
SumNarrow_MinMax	303.768	862.973	0.920824
SumNarrow_BitUtil	366.705	714.864	0.762786
SumNarrowVectorBase	195.318	1342.140	1.432112
SumNarrowVectorTraits	156.169	1678.591	1.791117
SumNarrowVector128Traits	1910.209	137.233	0.146433
SumNarrowVector256Traits	96.521	2715.916	2.897980

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1309.917	200.123
SumNarrow_IfUnrolling4	1297.177	202.088	1.009821
SumNarrow_MinMax	1310.039	200.104	0.999907
SumNarrow_MinMaxUnrolling4	1223.716	214.220	1.070442
SumNarrow_BitUtil	1216.758	215.445	1.076563
SumNarrow_BitUtilUnrolling4	1149.733	228.004	1.139322
SumNarrowVectorBase	30.862	8494.002	42.443981
SumNarrowVectorTraits	10.363	25297.062	126.407790
SumNarrowVector128Traits	1738.596	150.779	0.753434
SumNarrowVector256Traits	56.180	4666.126	23.316328

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1229.687	213.179
SumNarrow_MinMax	1271.497	206.170	0.967118
SumNarrow_BitUtil	1135.281	230.907	1.083157
SumNarrowVectorBase	75.221	3484.971	16.347598
SumNarrowVectorTraits	21.753	12050.968	56.529704
SumNarrowVector128Traits	2832.238	92.557	0.434175
SumNarrowVector256Traits	19.692	13312.277	62.446359

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1374.796	190.678
SumNarrow_MinMax	1377.889	190.250	0.997755
SumNarrow_BitUtil	961.980	272.505	1.429132
SumNarrowVectorBase	197.392	1328.039	6.964810
SumNarrowVectorTraits	167.038	1569.372	8.230461
SumNarrowVector128Traits	3633.026	72.156	0.378416
SumNarrowVector256Traits	130.143	2014.275	10.563724

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	362.410	723.334
SumNarrow_IfUnrolling4	352.951	742.722	1.026802
SumNarrow_MinMax	405.003	647.264	0.894834
SumNarrow_MinMaxUnrolling4	241.630	1084.897	1.499855
SumNarrow_BitUtil	915.132	286.455	0.396020
SumNarrow_BitUtilUnrolling4	900.282	291.180	0.402552
SumNarrowVectorBase	28.897	9071.752	12.541572
SumNarrowVectorTraits	25.141	10426.976	14.415151
SumNarrowVector128Traits	942.262	278.207	0.384617
SumNarrowVector256Traits	13.177	19894.336	27.503646

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	305.564	857.902
SumNarrow_MinMax	302.978	865.226	1.008536
SumNarrow_BitUtil	1015.470	258.150	0.300909
SumNarrowVectorBase	62.285	4208.788	4.905905
SumNarrowVectorTraits	50.766	5163.723	6.019010
SumNarrowVector128Traits	1636.831	160.153	0.186680
SumNarrowVector256Traits	26.747	9800.924	11.424286

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	276.194	949.129
SumNarrow_MinMax	279.659	937.371	0.987611
SumNarrow_BitUtil	465.679	562.929	0.593101
SumNarrowVectorBase	166.553	1573.936	1.658294
SumNarrowVectorTraits	159.790	1640.551	1.728480
SumNarrowVector128Traits	1908.724	137.340	0.144701
SumNarrowVector256Traits	104.231	2515.035	2.649834

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1254.204	209.012
SumNarrow_IfUnrolling4	1266.937	206.912	0.989950
SumNarrow_MinMax	1499.926	174.771	0.836177
SumNarrow_MinMaxUnrolling4	1326.361	197.642	0.945597
SumNarrow_BitUtil	944.380	277.583	1.328071
SumNarrow_BitUtilUnrolling4	945.578	277.232	1.326389
SumNarrowVectorBase	30.743	8526.961	40.796448
SumNarrowVectorTraits	9.361	28004.112	133.983061
SumNarrowVector128Traits	1732.084	151.346	0.724101
SumNarrowVector256Traits	55.978	4682.962	22.405196

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1231.290	212.902
SumNarrow_MinMax	1232.260	212.734	0.999213
SumNarrow_BitUtil	1045.475	250.741	1.177732
SumNarrowVectorBase	65.300	4014.440	18.855818
SumNarrowVectorTraits	18.771	13965.124	65.594165
SumNarrowVector128Traits	2820.182	92.953	0.436599
SumNarrowVector256Traits	21.101	12423.243	58.351954

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1369.261	191.449
SumNarrow_MinMax	1364.026	192.184	1.003838
SumNarrow_BitUtil	965.206	271.594	1.418621
SumNarrowVectorBase	203.243	1289.803	6.737048
SumNarrowVectorTraits	165.786	1581.219	8.259209
SumNarrowVector128Traits	3292.898	79.609	0.415822
SumNarrowVector256Traits	111.737	2346.079	12.254314

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	307.887	851.429
SumNarrow_IfUnrolling4	243.168	1078.038	1.266150
SumNarrow_MinMax	276.031	949.691	1.115407
SumNarrow_MinMaxUnrolling4	345.861	757.945	0.890203
SumNarrow_BitUtil	907.474	288.872	0.339279
SumNarrow_BitUtilUnrolling4	905.626	289.462	0.339971
SumNarrowVectorBase	26.254	9984.885	11.727204
SumNarrowVectorTraits	24.139	10859.842	12.754837
SumNarrowVector128Traits	947.494	276.671	0.324949
SumNarrowVector256Traits	15.016	17458.222	20.504605

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	321.497	815.386
SumNarrow_MinMax	312.532	838.774	1.028683
SumNarrow_BitUtil	1030.621	254.355	0.311945
SumNarrowVectorBase	62.179	4215.965	5.170515
SumNarrowVectorTraits	53.413	4907.864	6.019069
SumNarrowVector128Traits	1635.818	160.252	0.196536
SumNarrowVector256Traits	25.809	10157.225	12.456955

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	285.658	917.684
SumNarrow_MinMax	283.999	923.046	1.005843
SumNarrow_BitUtil	469.346	558.530	0.608630
SumNarrowVectorBase	161.770	1620.473	1.765828
SumNarrowVectorTraits	153.255	1710.509	1.863940
SumNarrowVector128Traits	1884.885	139.077	0.151552
SumNarrowVector256Traits	95.667	2740.178	2.985970

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1371.259	191.170
SumNarrow_IfUnrolling4	1262.906	207.572	1.085797
SumNarrow_MinMax	1198.585	218.711	1.144065
SumNarrow_MinMaxUnrolling4	1229.671	213.182	1.115143
SumNarrow_BitUtil	730.245	358.981	1.877806
SumNarrow_BitUtilUnrolling4	780.085	336.045	1.757832
SumNarrowVectorBase	15.629	16772.586	87.736356
SumNarrowVectorTraits	9.234	28389.912	148.505864
SumNarrowVector128Traits	25.723	10191.200	53.309537
SumNarrowVector256Traits	10.235	25613.256	133.981349

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1196.133	219.160
SumNarrow_MinMax	1258.128	208.360	0.950724
SumNarrow_BitUtil	622.808	420.906	1.920548
SumNarrowVectorBase	36.671	7148.632	32.618390
SumNarrowVectorTraits	23.739	11042.730	50.386715
SumNarrowVector128Traits	82.461	3178.988	14.505359
SumNarrowVector256Traits	22.567	11616.179	53.003297

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1365.031	192.043
SumNarrow_MinMax	1296.594	202.179	1.052782
SumNarrow_BitUtil	613.998	426.946	2.223187
SumNarrowVectorBase	108.247	2421.722	12.610346
SumNarrowVectorTraits	131.910	1987.293	10.348194
SumNarrowVector128Traits	165.049	1588.277	8.270445
SumNarrowVector256Traits	116.972	2241.083	11.669725

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	243.285	1077.520
SumNarrow_IfUnrolling4	244.847	1070.646	0.993620
SumNarrow_MinMax	335.205	782.040	0.725777
SumNarrow_MinMaxUnrolling4	301.168	870.426	0.807804
SumNarrow_BitUtil	446.855	586.642	0.544438
SumNarrow_BitUtilUnrolling4	441.289	594.042	0.551305
SumNarrowVectorBase	13.809	18983.630	17.617889
SumNarrowVectorTraits	12.647	20728.497	19.237223
SumNarrowVector128Traits	32.891	7970.046	7.396656
SumNarrowVector256Traits	13.850	18927.292	17.565604

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	236.986	1106.160
SumNarrow_MinMax	357.460	733.351	0.662970
SumNarrow_BitUtil	387.848	675.894	0.611027
SumNarrowVectorBase	26.462	9906.437	8.955699
SumNarrowVectorTraits	24.873	10539.250	9.527779
SumNarrowVector128Traits	65.998	3972.009	3.590808
SumNarrowVector256Traits	24.731	10599.979	9.582680

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	247.451	1059.378
SumNarrow_MinMax	361.788	724.578	0.683966
SumNarrow_BitUtil	416.911	628.777	0.593534
SumNarrowVectorBase	96.901	2705.270	2.553640
SumNarrowVectorTraits	98.415	2663.652	2.514354
SumNarrowVector128Traits	129.358	2026.496	1.912911
SumNarrowVector256Traits	99.395	2637.392	2.489566

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1609.553	162.868
SumNarrow_IfUnrolling4	1650.050	158.870	0.975457
SumNarrow_MinMax	1586.294	165.256	1.014662
SumNarrow_MinMaxUnrolling4	1619.637	161.854	0.993774
SumNarrow_BitUtil	1248.137	210.028	1.289564
SumNarrow_BitUtilUnrolling4	1269.803	206.445	1.267561
SumNarrowVectorBase	103.538	2531.862	15.545522
SumNarrowVectorTraits	51.639	5076.522	31.169622
SumNarrowVector128Traits	1991.682	131.619	0.808137
SumNarrowVector256Traits	2465.235	106.336	0.652900

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1621.355	161.682
SumNarrow_MinMax	1707.532	153.522	0.949531
SumNarrow_BitUtil	1063.734	246.437	1.524210
SumNarrowVectorBase	187.154	1400.683	8.663193
SumNarrowVectorTraits	87.506	2995.739	18.528579
SumNarrowVector128Traits	3582.353	73.176	0.452595
SumNarrowVector256Traits	5486.506	47.780	0.295517

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1596.916	164.156
SumNarrow_MinMax	1715.856	152.777	0.930682
SumNarrow_BitUtil	1067.916	245.473	1.495357
SumNarrowVectorBase	490.387	534.566	3.256441
SumNarrowVectorTraits	362.903	722.353	4.400393
SumNarrowVector128Traits	3173.460	82.605	0.503210
SumNarrowVector256Traits	4909.272	53.398	0.325286

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	504.386	519.729
SumNarrow_IfUnrolling4	523.916	500.355	0.962723
SumNarrow_MinMax	500.847	523.401	1.007066
SumNarrow_MinMaxUnrolling4	482.451	543.359	1.045466
SumNarrow_BitUtil	800.042	327.663	0.630450
SumNarrow_BitUtilUnrolling4	820.330	319.559	0.614857
SumNarrowVectorBase	92.588	2831.289	5.447626
SumNarrowVectorTraits	33.724	7773.152	14.956167
SumNarrowVector128Traits	1240.358	211.345	0.406646
SumNarrowVector256Traits	1663.472	157.588	0.303213

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	495.335	529.226
SumNarrow_MinMax	494.501	530.118	1.001686
SumNarrow_BitUtil	716.064	366.090	0.691746
SumNarrowVectorBase	187.490	1398.176	2.641926
SumNarrowVectorTraits	65.533	4000.190	7.558565
SumNarrowVector128Traits	2374.659	110.392	0.208592
SumNarrowVector256Traits	3287.110	79.749	0.150690

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.916	619.849
SumNarrow_MinMax	422.998	619.728	0.999806
SumNarrow_BitUtil	672.408	389.858	0.628957
SumNarrowVectorBase	382.349	685.614	1.106099
SumNarrowVectorTraits	212.654	1232.725	1.988750
SumNarrowVector128Traits	2179.810	120.260	0.194015
SumNarrowVector256Traits	3444.018	76.116	0.122797

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1687.532	155.342
SumNarrow_IfUnrolling4	1640.247	159.820	1.028828
SumNarrow_MinMax	1643.687	159.485	1.026675
SumNarrow_MinMaxUnrolling4	1615.469	162.271	1.044608
SumNarrow_BitUtil	1585.802	165.307	1.064151
SumNarrow_BitUtilUnrolling4	1614.585	162.360	1.045180
SumNarrowVectorBase	90.013	2912.285	18.747612
SumNarrowVectorTraits	19.464	13468.358	86.701527
SumNarrowVector128Traits	143.100	1831.893	11.792672
SumNarrowVector256Traits	2446.781	107.138	0.689695

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1601.843	163.652
SumNarrow_MinMax	1689.141	155.194	0.948318
SumNarrow_BitUtil	1349.426	194.263	1.187054
SumNarrowVectorBase	184.587	1420.169	8.678005
SumNarrowVectorTraits	42.085	6228.960	38.062334
SumNarrowVector128Traits	42.915	6108.384	37.325553
SumNarrowVector256Traits	4705.429	55.711	0.340424

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1580.269	165.886
SumNarrow_MinMax	1700.495	154.157	0.929299
SumNarrow_BitUtil	1364.619	192.100	1.158029
SumNarrowVectorBase	403.308	649.984	3.918265
SumNarrowVectorTraits	83.740	3130.446	18.871098
SumNarrowVector128Traits	83.699	3131.992	18.880421
SumNarrowVector256Traits	3163.827	82.857	0.499480

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	501.790	522.418
SumNarrow_IfUnrolling4	515.357	508.665	0.973674
SumNarrow_MinMax	497.431	526.995	1.008762
SumNarrow_MinMaxUnrolling4	477.119	549.432	1.051709
SumNarrow_BitUtil	1011.156	259.252	0.496253
SumNarrow_BitUtilUnrolling4	1059.249	247.481	0.473722
SumNarrowVectorBase	98.792	2653.492	5.079250
SumNarrowVectorTraits	18.776	13961.822	26.725384
SumNarrowVector128Traits	18.764	13970.769	26.742510
SumNarrowVector256Traits	1415.808	185.155	0.354419

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	515.332	508.689
SumNarrow_MinMax	488.112	537.058	1.055767
SumNarrow_BitUtil	916.969	285.881	0.561995
SumNarrowVectorBase	222.921	1175.952	2.311729
SumNarrowVectorTraits	42.201	6211.817	12.211413
SumNarrowVector128Traits	42.204	6211.287	12.210371
SumNarrowVector256Traits	1687.664	155.330	0.305352

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.013	621.175
SumNarrow_MinMax	422.326	620.715	0.999260
SumNarrow_BitUtil	883.179	296.819	0.477834
SumNarrowVectorBase	488.257	536.898	0.864327
SumNarrowVectorTraits	75.358	3478.670	5.600148
SumNarrowVector128Traits	80.956	3238.094	5.212857
SumNarrowVector256Traits	1849.123	141.767	0.228223

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1695.301	154.630
SumNarrow_IfUnrolling4	1641.479	159.700	1.032789
SumNarrow_MinMax	1678.959	156.135	1.009733
SumNarrow_MinMaxUnrolling4	1773.915	147.777	0.955683
SumNarrow_BitUtil	1580.344	165.878	1.072741
SumNarrow_BitUtilUnrolling4	1594.308	164.425	1.063346
SumNarrowVectorBase	93.092	2815.978	18.211093
SumNarrowVectorTraits	20.281	12925.367	83.589116
SumNarrowVector128Traits	138.780	1888.919	12.215754
SumNarrowVector256Traits	2751.944	95.258	0.616037

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1631.377	160.689
SumNarrow_MinMax	1646.077	159.254	0.991070
SumNarrow_BitUtil	1347.027	194.609	1.211094
SumNarrowVectorBase	207.461	1263.580	7.863522
SumNarrowVectorTraits	42.436	6177.373	38.443081
SumNarrowVector128Traits	42.514	6166.026	38.372467
SumNarrowVector256Traits	4764.284	55.023	0.342418

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1632.469	160.581
SumNarrow_MinMax	1588.863	164.988	1.027445
SumNarrow_BitUtil	1363.689	192.232	1.197098
SumNarrowVectorBase	436.486	600.578	3.740026
SumNarrowVectorTraits	80.061	3274.293	20.390248
SumNarrowVector128Traits	80.106	3272.445	20.378743
SumNarrowVector256Traits	3066.170	85.496	0.532413

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	502.390	521.794
SumNarrow_IfUnrolling4	515.486	508.537	0.974594
SumNarrow_MinMax	453.959	577.462	1.106686
SumNarrow_MinMaxUnrolling4	481.630	544.286	1.043104
SumNarrow_BitUtil	1011.261	259.225	0.496796
SumNarrow_BitUtilUnrolling4	1053.238	248.893	0.476996
SumNarrowVectorBase	85.828	3054.293	5.853446
SumNarrowVectorTraits	18.742	13987.326	26.806225
SumNarrowVector128Traits	18.803	13941.506	26.718413
SumNarrowVector256Traits	1411.380	185.736	0.355957

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	483.208	542.507
SumNarrow_MinMax	486.669	538.650	0.992889
SumNarrow_BitUtil	919.456	285.108	0.525537
SumNarrowVectorBase	174.611	1501.303	2.767340
SumNarrowVectorTraits	39.178	6691.098	12.333653
SumNarrowVector128Traits	39.140	6697.548	12.345541
SumNarrowVector256Traits	1698.401	154.348	0.284508

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	426.936	614.013
SumNarrow_MinMax	427.403	613.341	0.998907
SumNarrow_BitUtil	892.052	293.866	0.478600
SumNarrowVectorBase	371.223	706.164	1.150080
SumNarrowVectorTraits	76.296	3435.888	5.595793
SumNarrowVector128Traits	76.123	3443.712	5.608536
SumNarrowVector256Traits	1882.942	139.220	0.226739

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1443.394	181.616
SumNarrow_IfUnrolling4	1408.892	186.064	1.024488
SumNarrow_MinMax	1422.868	184.236	1.014425
SumNarrow_MinMaxUnrolling4	1408.193	186.156	1.024997
SumNarrow_BitUtil	1282.070	204.469	1.125830
SumNarrow_BitUtilUnrolling4	1279.546	204.873	1.128052
SumNarrowVectorBase	37.653	6962.118	38.334181
SumNarrowVectorTraits	17.389	15075.252	83.005983
SumNarrowVector128Traits	17.443	15028.437	82.748215
SumNarrowVector256Traits	3981.879	65.834	0.362491

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1374.727	190.688
SumNarrow_MinMax	1344.276	195.008	1.022652
SumNarrow_BitUtil	1013.433	258.669	1.356505
SumNarrowVectorBase	86.469	3031.664	15.898558
SumNarrowVectorTraits	33.743	7768.797	40.740880
SumNarrowVector128Traits	33.836	7747.447	40.628919
SumNarrowVector256Traits	3987.591	65.740	0.344751

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1276.842	205.307
SumNarrow_MinMax	1326.726	197.587	0.962400
SumNarrow_BitUtil	1065.345	246.065	1.198524
SumNarrowVectorBase	209.952	1248.590	6.081589
SumNarrowVectorTraits	65.373	4009.993	19.531733
SumNarrowVector128Traits	64.980	4034.209	19.649681
SumNarrowVector256Traits	3622.936	72.357	0.352433

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	431.452	607.586
SumNarrow_IfUnrolling4	372.988	702.821	1.156743
SumNarrow_MinMax	430.797	608.509	1.001519
SumNarrow_MinMaxUnrolling4	378.713	692.197	1.139257
SumNarrow_BitUtil	839.215	312.368	0.514113
SumNarrow_BitUtilUnrolling4	847.996	309.133	0.508789
SumNarrowVectorBase	32.988	7946.709	13.079146
SumNarrowVectorTraits	20.495	12790.759	21.051760
SumNarrowVector128Traits	20.731	12645.172	20.812146
SumNarrowVector256Traits	1320.292	198.550	0.326785

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	455.698	575.258
SumNarrow_MinMax	457.211	573.354	0.996690
SumNarrow_BitUtil	698.941	375.059	0.651983
SumNarrowVectorBase	66.071	3967.581	6.897046
SumNarrowVectorTraits	43.156	6074.297	10.559256
SumNarrowVector128Traits	43.862	5976.629	10.389476
SumNarrowVector256Traits	1463.150	179.164	0.311450

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	342.365	765.685
SumNarrow_MinMax	343.490	763.179	0.996727
SumNarrow_BitUtil	681.621	384.589	0.502281
SumNarrowVectorBase	157.912	1660.066	2.168081
SumNarrowVectorTraits	82.701	3169.762	4.139775
SumNarrowVector128Traits	83.418	3142.530	4.104209
SumNarrowVector256Traits	1616.394	162.178	0.211808

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

