# Benchmark - ConvertToDouble
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9166.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
SumScalar	347.082	755.279
SumBcl	228.831	1145.580	1.516764
SumBase_Range52_Impl	100.416	2610.573	3.456436
SumTraits	203.790	1286.345	1.703140
SumTraits_Range52	214.171	1223.993	1.620585

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	848.378	308.994
SumBcl	119.673	2190.507	7.089150
SumBase_Range52_Impl	85.672	3059.854	9.902623
SumTraits	120.016	2184.236	7.068857
SumTraits_Range52	152.596	1717.892	5.559625

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	165.332	1585.558
SumBcl	200.218	1309.294	0.825762
SumBase_Range52_Impl	237.166	1105.316	0.697115
SumBase_Range52RoundToEven	72.607	3610.459	2.277090
SumTraits	200.300	1308.755	0.825422
SumTraits_Range52	200.907	1304.803	0.822930
SumTraits_Range52RoundToEven	74.839	3502.767	2.209170

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	1035.583	253.137
SumBcl	1565.680	167.431	0.661427
SumBase_Range52_Impl	284.857	920.265	3.635449
SumBase_Range52RoundToEven	69.097	3793.873	14.987452
SumTraits	1485.827	176.430	0.696974
SumTraits_Range52	259.460	1010.343	3.991298
SumTraits_Range52RoundToEven	61.613	4254.673	16.807816

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
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
SumScalar	313.094	837.268
SumBcl	199.337	1315.081	1.570681
SumBase_Range52_Impl	82.295	3185.418	3.804538
SumTraits	198.899	1317.976	1.574139
SumTraits_Range52	198.732	1319.081	1.575458

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	715.220	366.522
SumBcl	141.415	1853.725	5.057603
SumBase_Range52_Impl	81.088	3232.820	8.820253
SumTraits	110.991	2361.856	6.443960
SumTraits_Range52	147.666	1775.250	4.843497

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	180.537	1452.025
SumBcl	201.723	1299.525	0.894974
SumBase_Range52_Impl	236.363	1109.075	0.763813
SumBase_Range52RoundToEven	75.170	3487.368	2.401727
SumTraits	202.957	1291.623	0.889532
SumTraits_Range52	200.830	1305.301	0.898952
SumTraits_Range52RoundToEven	75.798	3458.478	2.381831

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	900.922	290.973
SumBcl	1380.439	189.899	0.652634
SumBase_Range52_Impl	255.392	1026.437	3.527603
SumBase_Range52RoundToEven	61.322	4274.902	14.691748
SumTraits	1429.280	183.410	0.630333
SumTraits_Range52	256.502	1021.994	3.512334
SumTraits_Range52RoundToEven	61.247	4280.144	14.709763

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
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	315.959	829.678
SumBcl	203.409	1288.753	1.553318
SumBase_Range52_Impl	84.846	3089.633	3.723896
SumTraits	122.646	2137.406	2.576189
SumTraits_Range52	89.573	2926.595	3.527388
Sum128Base_Basic	1699.521	154.246	0.185911
Sum128Base	1694.524	154.701	0.186459
Sum128Base_Range52_Impl	1689.456	155.165	0.187018
Sum128Traits	1692.135	154.919	0.186722
Sum128Traits_Range52	1688.804	155.225	0.187090
Sum256Base_Basic	584.560	448.447	0.540507
Sum256Base	583.776	449.049	0.541233
Sum256Base_Range52_Impl	583.476	449.280	0.541511
Sum256Avx2_Bcl	110.293	2376.801	2.864728
Sum256Avx2_HwScalar	201.870	1298.579	1.565161
Sum256Avx2_Range52	82.639	3172.173	3.823381
Sum256Traits	108.197	2422.851	2.920232
Sum256Traits_Range52	82.980	3159.127	3.807656

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	732.473	357.889
SumBcl	115.102	2277.489	6.363677
SumBase_Range52_Impl	80.235	3267.194	9.129075
SumTraits	99.628	2631.236	7.352104
SumTraits_Range52	82.931	3160.986	8.832312
Sum128Base_Basic	1719.825	152.425	0.425900
Sum128Base	1725.335	151.938	0.424540
Sum128Base_Range52_Impl	1723.395	152.109	0.425018
Sum128Traits	1723.042	152.140	0.425105
Sum128Traits_Range52	1723.406	152.108	0.425015
Sum256Base_Basic	885.862	295.920	0.826848
Sum256Base	894.495	293.064	0.818868
Sum256Base_Range52_Impl	898.518	291.752	0.815201
Sum256Avx2_Bcl	102.692	2552.713	7.132698
Sum256Avx2_Range52	82.500	3177.500	8.878456
Sum256Traits	107.708	2433.848	6.800568
Sum256Traits_Range52	83.197	3150.879	8.804071

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	161.414	1624.045
SumBcl	201.023	1304.050	0.802964
SumBase_Range52_Impl	252.513	1038.142	0.639232
SumBase_Range52RoundToEven	75.369	3478.120	2.141641
SumTraits	193.557	1354.350	0.833937
SumTraits_Range52	88.221	2971.433	1.829649
SumTraits_Range52RoundToEven	79.201	3309.838	2.038022
Sum128Base_Basic	1565.262	167.476	0.103123
Sum128Base	1568.031	167.180	0.102941
Sum128Base_Range52_Impl	1565.986	167.399	0.103075
Sum128Traits	1565.746	167.424	0.103091
Sum128Traits_Range52	1567.433	167.244	0.102980
Sum128Traits_Range52RoundToEven	1564.663	167.540	0.103162
Sum256Base_Basic	540.340	485.146	0.298727
Sum256Base	545.462	480.591	0.295922
Sum256Base_Range52_Impl	543.610	482.228	0.296930
Sum256Avx2_HwScalar	202.356	1295.460	0.797675
Sum256Avx2_ShiftVar	159.336	1645.224	1.013041
Sum256Avx2_ShiftVarFix	187.171	1400.562	0.862391
Sum256Avx2_Range52	82.688	3170.291	1.952096
Sum256Traits	198.086	1323.385	0.814870
Sum256Traits_Range52	86.601	3027.046	1.863893
Sum256Traits_Range52RoundToEven	75.594	3467.782	2.135274

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	890.952	294.229
SumBcl	1460.874	179.443	0.609876
SumBase_Range52_Impl	233.911	1120.700	3.808936
SumBase_Range52RoundToEven	71.494	3666.657	12.461911
SumTraits	135.261	1938.054	6.586887
SumTraits_Range52	85.206	3076.598	10.456470
SumTraits_Range52RoundToEven	79.123	3313.127	11.260364
Sum128Base_Basic	1742.147	150.472	0.511410
Sum128Base	1719.713	152.435	0.518082
Sum128Base_Range52_Impl	1726.280	151.855	0.516111
Sum128Traits	1722.953	152.148	0.517107
Sum128Traits_Range52	1733.831	151.194	0.513863
Sum128Traits_Range52RoundToEven	1717.194	152.658	0.518842
Sum256Base_Basic	1025.247	255.689	0.869012
Sum256Base	1061.005	247.071	0.839725
Sum256Base_Range52_Impl	1056.919	248.027	0.842971
Sum256Avx2_ShiftVar	143.903	1821.677	6.191354
Sum256Avx2_Range52	91.024	2879.943	9.788097
Sum256Traits	142.758	1836.283	6.240998
Sum256Traits_Range52	82.484	3178.132	10.801554
Sum256Traits_Range52RoundToEven	74.227	3531.630	12.002991

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	316.749	827.608
SumBcl	202.756	1292.905	1.562219
SumBase_Range52_Impl	83.238	3149.333	3.805344
SumTraits	99.000	2647.915	3.199479
SumTraits_Range52	85.265	3074.463	3.714878
Sum128Base_Basic	1649.292	158.943	0.192051
Sum128Base	1646.521	159.211	0.192375
Sum128Base_Range52_Impl	1645.981	159.263	0.192438
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1643.686	159.485	0.192707
Sum128Traits_Range52	1643.154	159.537	0.192769
Sum256Base_Basic	489.115	535.956	0.647597
Sum256Base	490.547	534.392	0.645706
Sum256Base_Range52_Impl	496.191	528.313	0.638361
Sum256Avx2_Bcl	90.915	2883.402	3.484018
Sum256Avx2_HwScalar	202.834	1292.408	1.561618
Sum256Avx2_Range52	81.996	3197.026	3.862971
Sum256Traits	98.110	2671.950	3.228521
Sum256Traits_Range52	82.294	3185.475	3.849013

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	717.196	365.513
SumBcl	111.423	2352.684	6.436672
SumBase_Range52_Impl	79.795	3285.211	8.987957
SumTraits	89.759	2920.538	7.990254
SumTraits_Range52	86.736	3022.309	8.268687
Sum128Base_Basic	1721.023	152.319	0.416726
Sum128Base	1727.372	151.759	0.415195
Sum128Base_Range52_Impl	1724.246	152.034	0.415947
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1720.806	152.338	0.416779
Sum128Traits_Range52	1727.109	151.782	0.415258
Sum256Base_Basic	840.978	311.713	0.852811
Sum256Base	842.533	311.138	0.851237
Sum256Base_Range52_Impl	837.448	313.027	0.856406
Sum256Avx2_Bcl	101.661	2578.620	7.054806
Sum256Avx2_Range52	97.786	2680.806	7.334374
Sum256Traits	87.752	2987.325	8.172975
Sum256Traits_Range52	92.740	2826.654	7.733399

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	170.082	1541.277
SumBcl	206.578	1268.983	0.823333
SumBase_Range52_Impl	110.423	2373.999	1.540281
SumBase_Range52RoundToEven	79.718	3288.404	2.133558
SumTraits	180.345	1453.566	0.943092
SumTraits_Range52	81.383	3221.134	2.089913
SumTraits_Range52RoundToEven	74.952	3497.498	2.269221
Sum128Base_Basic	1529.746	171.364	0.111183
Sum128Base	1529.240	171.421	0.111220
Sum128Base_Range52_Impl	1542.593	169.937	0.110257
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1543.893	169.794	0.110165
Sum128Traits_Range52	1539.407	170.289	0.110486
Sum128Traits_Range52RoundToEven	1535.649	170.706	0.110756
Sum256Base_Basic	475.566	551.225	0.357642
Sum256Base	475.405	551.412	0.357763
Sum256Base_Range52_Impl	476.665	549.954	0.356817
Sum256Avx2_HwScalar	199.432	1314.451	0.852832
Sum256Avx2_ShiftVar	150.503	1741.787	1.130093
Sum256Avx2_ShiftVarFix	170.398	1538.426	0.998150
Sum256Avx2_Range52	78.596	3335.327	2.164003
Sum256Traits	173.383	1511.937	0.980964
Sum256Traits_Range52	80.941	3238.713	2.101318
Sum256Traits_Range52RoundToEven	75.087	3491.223	2.265150

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	887.024	295.532
SumBcl	1322.077	198.282	0.670933
SumBase_Range52_Impl	93.158	2813.979	9.521745
SumBase_Range52RoundToEven	56.669	4625.844	15.652606
SumTraits	103.385	2535.613	8.579830
SumTraits_Range52	69.502	3771.743	12.762561
SumTraits_Range52RoundToEven	58.919	4449.218	15.054953
Sum128Base_Basic	1676.893	156.327	0.528969
Sum128Base	1666.408	157.311	0.532297
Sum128Base_Range52_Impl	1675.463	156.461	0.529420
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1678.902	156.140	0.528336
Sum128Traits_Range52	1686.171	155.467	0.526058
Sum128Traits_Range52RoundToEven	1676.790	156.337	0.529002
Sum256Base_Basic	1014.337	258.439	0.874487
Sum256Base	1010.524	259.414	0.877787
Sum256Base_Range52_Impl	1018.373	257.415	0.871021
Sum256Avx2_ShiftVar	111.676	2347.369	7.942864
Sum256Avx2_Range52	73.814	3551.413	12.017021
Sum256Traits	113.107	2317.658	7.842330
Sum256Traits_Range52	69.672	3762.550	12.731453
Sum256Traits_Range52RoundToEven	58.791	4458.932	15.087820

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	315.519	830.833
SumBcl	202.970	1291.543	1.554515
SumBase_Range52_Impl	82.616	3173.028	3.819091
SumTraits	88.667	2956.515	3.558494
SumTraits_Range52	83.997	3120.869	3.756311
Sum128Base_Basic	1646.599	159.203	0.191619
Sum128Base	1647.435	159.122	0.191522
Sum128Base_Range52_Impl	1648.790	158.992	0.191364
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1646.518	159.211	0.191628
Sum128Traits_Range52	1646.064	159.255	0.191681
Sum256Base_Basic	493.643	531.040	0.639165
Sum256Base	495.220	529.349	0.637130
Sum256Base_Range52_Impl	494.851	529.743	0.637605
Sum256Avx2_Bcl	86.525	3029.681	3.646557
Sum256Avx2_HwScalar	202.747	1292.963	1.556224
Sum256Avx2_Range52	80.933	3239.009	3.898506
Sum256Traits	83.294	3147.217	3.788025
Sum256Traits_Range52	81.242	3226.708	3.883701

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	715.488	366.385
SumBcl	113.170	2316.380	6.322259
SumBase_Range52_Impl	81.847	3202.869	8.741816
SumTraits	85.580	3063.146	8.360459
SumTraits_Range52	80.878	3241.231	8.846518
Sum128Base_Basic	1711.164	153.196	0.418129
Sum128Base	1712.320	153.093	0.417847
Sum128Base_Range52_Impl	1719.739	152.432	0.416044
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1719.521	152.452	0.416097
Sum128Traits_Range52	1724.439	152.017	0.414911
Sum256Base_Basic	861.493	304.290	0.830521
Sum256Base	857.718	305.630	0.834176
Sum256Base_Range52_Impl	863.320	303.646	0.828763
Sum256Avx2_Bcl	82.721	3169.005	8.649389
Sum256Avx2_Range52	81.766	3206.026	8.750433
Sum256Traits	81.980	3197.674	8.727637
Sum256Traits_Range52	81.267	3225.719	8.804182

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	168.092	1559.524
SumBcl	206.017	1272.440	0.815916
SumBase_Range52_Impl	111.867	2343.352	1.502608
SumBase_Range52RoundToEven	63.018	4159.825	2.667369
SumTraits	178.763	1466.432	0.940308
SumTraits_Range52	80.477	3257.382	2.088703
SumTraits_Range52RoundToEven	61.505	4262.154	2.732985
Sum128Base_Basic	1537.536	170.496	0.109326
Sum128Base	1537.436	170.507	0.109333
Sum128Base_Range52_Impl	1535.373	170.736	0.109480
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1539.700	170.257	0.109172
Sum128Traits_Range52	1547.290	169.421	0.108637
Sum128Traits_Range52RoundToEven	1538.858	170.350	0.109232
Sum256Base_Basic	482.850	542.910	0.348126
Sum256Base	481.727	544.175	0.348937
Sum256Base_Range52_Impl	476.722	549.889	0.352600
Sum256Avx2_HwScalar	198.679	1319.432	0.846048
Sum256Avx2_ShiftVar	149.236	1756.575	1.126354
Sum256Avx2_ShiftVarFix	167.592	1564.177	1.002984
Sum256Avx2_Range52	77.843	3367.612	2.159385
Sum256Traits	171.020	1532.826	0.982881
Sum256Traits_Range52	78.663	3332.495	2.136868
Sum256Traits_Range52RoundToEven	58.364	4491.516	2.880057

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	877.874	298.612
SumBcl	1228.425	213.399	0.714634
SumBase_Range52_Impl	102.637	2554.091	8.553199
SumBase_Range52RoundToEven	57.928	4525.326	15.154514
SumTraits	109.741	2388.743	7.999475
SumTraits_Range52	72.995	3591.258	12.026486
SumTraits_Range52RoundToEven	55.456	4727.091	15.830189
Sum128Base_Basic	1691.757	154.954	0.518912
Sum128Base	1681.220	155.925	0.522165
Sum128Base_Range52_Impl	1684.749	155.598	0.521071
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1680.431	155.998	0.522410
Sum128Traits_Range52	1685.775	155.504	0.520754
Sum128Traits_Range52RoundToEven	1685.177	155.559	0.520939
Sum256Base_Basic	980.925	267.242	0.894945
Sum256Base	980.171	267.447	0.895634
Sum256Base_Range52_Impl	982.857	266.716	0.893185
Sum256Avx2_ShiftVar	105.692	2480.255	8.305933
Sum256Avx2_Range52	69.332	3781.011	12.661936
Sum256Traits	111.286	2355.585	7.888435
Sum256Traits_Range52	70.432	3721.951	12.464153
Sum256Traits_Range52RoundToEven	56.459	4643.059	15.548780

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	316.504	828.248
SumBcl	89.348	2933.963	3.542372
SumBase_Range52_Impl	85.871	3052.755	3.685797
SumTraits	93.495	2803.830	3.385253
SumTraits_Range52	86.924	3015.771	3.641144
Sum128Bcl	162.723	1610.987	1.945053
Sum128Base_Basic	866.567	302.508	0.365239
Sum128Base	161.937	1618.803	1.954490
Sum128Base_Range52_Impl	160.156	1636.802	1.976221
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	159.842	1640.014	1.980100
Sum128Traits_Range52	158.252	1656.493	1.999995
Sum256Bcl	82.945	3160.469	3.815847
Sum256Base_Basic	488.677	536.436	0.647676
Sum256Base	86.721	3022.857	3.649699
Sum256Base_Range52_Impl	84.426	3105.026	3.748908
Sum256Avx2_Bcl	90.807	2886.823	3.485457
Sum256Avx2_HwScalar	202.898	1292.000	1.559918
Sum256Avx2_Range52	86.279	3038.339	3.668392
Sum256Traits	91.086	2877.974	3.474772
Sum256Traits_Range52	85.834	3054.069	3.687383

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	690.735	379.515
SumBcl	83.744	3130.308	8.248183
SumBase_Range52_Impl	83.904	3124.336	8.232448
SumTraits	91.227	2873.539	7.571610
SumTraits_Range52	87.451	2997.616	7.898547
Sum128Bcl	161.663	1621.545	4.272678
Sum128Base_Basic	931.783	281.336	0.741304
Sum128Base	161.504	1623.147	4.276900
Sum128Base_Range52_Impl	159.761	1640.854	4.323556
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	159.675	1641.734	4.325875
Sum128Traits_Range52	157.440	1665.046	4.387301
Sum256Bcl	86.680	3024.268	7.968774
Sum256Base_Basic	877.816	298.632	0.786879
Sum256Base	88.121	2974.828	7.838503
Sum256Base_Range52_Impl	86.380	3034.773	7.996453
Sum256Avx2_Bcl	90.856	2885.272	7.602528
Sum256Avx2_Range52	87.753	2987.278	7.871307
Sum256Traits	91.213	2873.969	7.572746
Sum256Traits_Range52	87.997	2979.024	7.849558

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	162.262	1615.561
SumBcl	464.955	563.805	0.348984
SumBase_Range52_Impl	107.056	2448.665	1.515675
SumBase_Range52RoundToEven	61.340	4273.610	2.645279
SumTraits	168.275	1557.831	0.964266
SumTraits_Range52	81.103	3232.242	2.000693
SumTraits_Range52RoundToEven	62.715	4179.903	2.587276
Sum128Bcl	772.511	339.340	0.210045
Sum128Base_Basic	807.287	324.722	0.200997
Sum128Base	772.658	339.276	0.210005
Sum128Base_Range52_Impl	148.904	1760.489	1.089708
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	775.719	337.937	0.209176
Sum128Traits_Range52	154.136	1700.727	1.052716
Sum128Traits_Range52RoundToEven	100.370	2611.781	1.616640
Sum256Bcl	464.223	564.695	0.349535
Sum256Base_Basic	482.435	543.377	0.336339
Sum256Base	463.411	565.684	0.350147
Sum256Base_Range52_Impl	104.499	2508.577	1.552759
Sum256Avx2_HwScalar	198.349	1321.631	0.818063
Sum256Avx2_ShiftVar	153.810	1704.339	1.054952
Sum256Avx2_ShiftVarFix	166.087	1578.356	0.976971
Sum256Avx2_Range52	76.639	3420.500	2.117221
Sum256Traits	168.122	1559.253	0.965146
Sum256Traits_Range52	79.663	3290.679	2.036864
Sum256Traits_Range52RoundToEven	61.631	4253.457	2.632805

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 3573632353956802055!=5047608992447735894
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	911.200	287.691
SumBcl	1199.847	218.481	0.759430
SumBase_Range52_Impl	104.807	2501.214	8.694101
SumBase_Range52RoundToEven	58.492	4481.732	15.578289
SumTraits	123.634	2120.320	7.370131
SumTraits_Range52	82.276	3186.148	11.074898
SumTraits_Range52RoundToEven	64.882	4040.339	14.044027
Sum128Bcl	1128.701	232.253	0.807300
Sum128Base_Basic	1124.135	233.196	0.810579
Sum128Base	1120.054	234.046	0.813532
Sum128Base_Range52_Impl	156.115	1679.171	5.836720
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1110.323	236.097	0.820662
Sum128Traits_Range52	159.971	1638.697	5.696034
Sum128Traits_Range52RoundToEven	97.998	2675.000	9.298174
Sum256Bcl	1029.191	254.709	0.885356
Sum256Base_Basic	1029.461	254.642	0.885124
Sum256Base	1034.594	253.379	0.880732
Sum256Base_Range52_Impl	123.460	2123.309	7.380522
Sum256Avx2_ShiftVar	127.305	2059.175	7.157595
Sum256Avx2_Range52	80.711	3247.917	11.289604
Sum256Traits	127.488	2056.217	7.147314
Sum256Traits_Range52	82.804	3165.826	11.004261
Sum256Traits_Range52RoundToEven	66.726	3928.653	13.655810

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	318.728	822.470
SumBcl	125.273	2092.585	2.544269
SumBase_Range52_Impl	180.322	1453.756	1.767548
SumTraits	125.212	2093.603	2.545506
SumTraits_Range52	4581.891	57.213	0.069562
Sum128Base_Basic	1179.901	222.175	0.270131
Sum128Base	1186.515	220.936	0.268625
Sum128Base_Range52_Impl	1182.805	221.629	0.269468
Sum128Traits	1186.207	220.994	0.268695
Sum128Traits_Range52	1187.968	220.666	0.268296
Sum256Base_Basic	1629.737	160.850	0.195570
Sum256Base	1767.004	148.355	0.180377
Sum256Base_Range52_Impl	1877.540	139.621	0.169758
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2034.791	128.831	0.156639
Sum256Traits_Range52	2031.008	129.071	0.156931

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	318.179	823.889
SumBcl	132.147	1983.728	2.407761
SumBase_Range52_Impl	176.442	1485.725	1.803307
SumTraits	132.257	1982.074	2.405753
SumTraits_Range52	4570.041	57.361	0.069623
Sum128Base_Basic	1098.813	238.570	0.289566
Sum128Base	1098.388	238.663	0.289678
Sum128Base_Range52_Impl	1109.607	236.249	0.286749
Sum128Traits	1091.072	240.263	0.291620
Sum128Traits_Range52	1100.674	238.167	0.289076
Sum256Base_Basic	1572.625	166.692	0.202323
Sum256Base	1730.687	151.468	0.183845
Sum256Base_Range52_Impl	1853.241	141.452	0.171688
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2015.237	130.081	0.157886
Sum256Traits_Range52	2017.133	129.959	0.157738

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447745283
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447745283
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447745283
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447745283
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum128Base	Check `Sum128Base` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Base	Check `Sum256Base` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 5047608992447746009!=5047608992447745283
SumScalar	355.525	737.344
SumBcl	133.294	1966.655	2.667216
SumBase_Range52_Impl	1191.134	220.079	0.298476
SumBase_Range52RoundToEven	162.078	1617.393	2.193540
SumTraits	125.115	2095.217	2.841574
SumTraits_Range52	125.042	2096.444	2.843238
SumTraits_Range52RoundToEven	162.562	1612.579	2.187011
Sum128Base_Basic	1135.908	230.779	0.312987
Sum128Base	1110.957	235.962	0.320017
Sum128Base_Range52_Impl	1129.975	231.991	0.314631
Sum128Traits	1115.770	234.944	0.318636
Sum128Traits_Range52	1114.592	235.193	0.318973
Sum128Traits_Range52RoundToEven	1136.114	230.737	0.312930
Sum256Base_Basic	1597.563	164.090	0.222542
Sum256Base	1741.656	150.514	0.204130
Sum256Base_Range52_Impl	1736.162	150.990	0.204776
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2003.916	130.816	0.177415
Sum256Traits_Range52	2015.009	130.096	0.176438
Sum256Traits_Range52RoundToEven	2010.888	130.362	0.176800

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	355.545	737.301
SumBcl	1238.415	211.677	0.287097
SumBase_Range52_Impl	1206.799	217.223	0.294619
SumBase_Range52RoundToEven	176.582	1484.544	2.013484
SumTraits	1225.562	213.897	0.290108
SumTraits_Range52	1209.301	216.773	0.294009
SumTraits_Range52RoundToEven	184.736	1419.022	1.924617
Sum128Base_Basic	1060.615	247.162	0.335226
Sum128Base	1056.509	248.123	0.336528
Sum128Base_Range52_Impl	1058.472	247.663	0.335904
Sum128Traits	1059.102	247.515	0.335705
Sum128Traits_Range52	1058.790	247.588	0.335804
Sum128Traits_Range52RoundToEven	1059.771	247.359	0.335493
Sum256Base_Basic	1554.906	168.592	0.228660
Sum256Base	1693.523	154.792	0.209944
Sum256Base_Range52_Impl	1707.333	153.540	0.208246
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1969.825	133.080	0.180496
Sum256Traits_Range52	1973.481	132.833	0.180162
Sum256Traits_Range52RoundToEven	1969.295	133.116	0.180545

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	326.845	802.044
SumBcl	133.265	1967.095	2.452604
SumBase_Range52_Impl	161.868	1619.488	2.019201
SumTraits	133.448	1964.386	2.449226
SumTraits_Range52	126.567	2071.191	2.582392
Sum128Base_Basic	404.886	647.451	0.807251
Sum128Base	408.845	641.182	0.799435
Sum128Base_Range52_Impl	403.623	649.477	0.809777
Sum128AdvSimd_Range52	378.782	692.071	0.862884
Sum128AdvSimd_Range52_Impl	315.143	831.825	1.037132
Sum128Traits	133.403	1965.059	2.450065
Sum128Traits_Range52	125.269	2092.640	2.609135
Sum256Base_Basic	974.125	269.107	0.335527
Sum256Base	1144.113	229.124	0.285675
Sum256Base_Range52_Impl	1149.252	228.100	0.284398
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1146.325	228.682	0.285124
Sum256Traits_Range52	1148.204	228.308	0.284658

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	317.916	824.569
SumBcl	123.768	2118.035	2.568656
SumBase_Range52_Impl	158.893	1649.818	2.000824
SumTraits	132.171	1983.368	2.405338
SumTraits_Range52	123.737	2118.558	2.569290
Sum128Base_Basic	384.189	682.330	0.827499
Sum128Base	388.171	675.331	0.819011
Sum128Base_Range52_Impl	388.124	675.412	0.819109
Sum128AdvSimd_Range52	282.497	927.953	1.125379
Sum128AdvSimd_Range52_Impl	287.721	911.105	1.104947
Sum128Traits	132.246	1982.240	2.403970
Sum128Traits_Range52	123.639	2120.233	2.571322
Sum256Base_Basic	966.894	271.120	0.328802
Sum256Base	1133.397	231.290	0.280499
Sum256Base_Range52_Impl	1136.496	230.660	0.279734
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1132.479	231.478	0.280726
Sum256Traits_Range52	1132.892	231.394	0.280624

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
SumScalar	355.507	737.380
SumBcl	133.319	1966.295	2.666597
SumBase_Range52_Impl	338.920	773.468	1.048941
SumBase_Range52RoundToEven	161.211	1626.097	2.205236
SumTraits	125.258	2092.838	2.838208
SumTraits_Range52	125.329	2091.648	2.836595
SumTraits_Range52RoundToEven	125.074	2095.913	2.842378
Sum128Base_Basic	411.473	637.087	0.863988
Sum128Base	412.026	636.231	0.862827
Sum128Base_Range52_Impl	407.906	642.659	0.871543
Sum128AdvSimd_Range52	379.300	691.125	0.937271
Sum128AdvSimd_Range52_Impl	380.327	689.259	0.934741
Sum128Traits	133.345	1965.905	2.666068
Sum128Traits_Range52	133.717	1960.433	2.658647
Sum128Traits_Range52RoundToEven	133.211	1967.885	2.668752
Sum256Base_Basic	918.385	285.440	0.387101
Sum256Base	1070.786	244.815	0.332006
Sum256Base_Range52_Impl	1072.152	244.503	0.331583
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1073.609	244.171	0.331133
Sum256Traits_Range52	1070.926	244.783	0.331963
Sum256Traits_Range52RoundToEven	1073.213	244.261	0.331255

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
SumScalar	360.620	726.925
SumBcl	1055.639	248.327	0.341613
SumBase_Range52_Impl	332.510	788.380	1.084540
SumBase_Range52RoundToEven	159.334	1645.244	2.263292
SumTraits	132.229	1982.497	2.727236
SumTraits_Range52	132.218	1982.658	2.727457
SumTraits_Range52RoundToEven	132.219	1982.654	2.727451
Sum128Base_Basic	388.956	673.968	0.927149
Sum128Base	392.679	667.578	0.918359
Sum128Base_Range52_Impl	388.964	673.955	0.927130
Sum128AdvSimd_Range52	351.148	746.533	1.026974
Sum128AdvSimd_Range52_Impl	349.528	749.994	1.031735
Sum128Traits	123.755	2118.257	2.913994
Sum128Traits_Range52	123.500	2122.622	2.920000
Sum128Traits_Range52RoundToEven	123.574	2121.354	2.918255
Sum256Base_Basic	910.161	288.019	0.396216
Sum256Base	1059.776	247.358	0.340280
Sum256Base_Range52_Impl	1060.047	247.295	0.340193
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1059.916	247.325	0.340235
Sum256Traits_Range52	1059.499	247.423	0.340369
Sum256Traits_Range52RoundToEven	1059.364	247.454	0.340412

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	326.814	802.120
SumBcl	133.200	1968.054	2.453566
SumBase_Range52_Impl	147.711	1774.703	2.212516
SumTraits	125.636	2086.539	2.601280
SumTraits_Range52	133.420	1964.797	2.449505
Sum128Base_Basic	404.225	648.510	0.808495
Sum128Base	404.031	648.822	0.808884
Sum128Base_Range52_Impl	403.882	649.060	0.809181
Sum128AdvSimd_Range52	322.858	811.948	1.012252
Sum128AdvSimd_Range52_Impl	322.622	812.542	1.012993
Sum128Traits	126.833	2066.851	2.576736
Sum128Traits_Range52	133.471	1964.053	2.448577
Sum256Base_Basic	975.495	268.729	0.335024
Sum256Base	1143.989	229.149	0.285679
Sum256Base_Range52_Impl	1146.752	228.597	0.284991
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1147.488	228.450	0.284808
Sum256Traits_Range52	1147.290	228.490	0.284857

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	324.039	808.988
SumBcl	123.756	2118.234	2.618375
SumBase_Range52_Impl	145.732	1798.805	2.223525
SumTraits	132.310	1981.290	2.449097
SumTraits_Range52	123.728	2118.710	2.618963
Sum128Base_Basic	391.386	669.784	0.827928
Sum128Base	389.090	673.736	0.832814
Sum128Base_Range52_Impl	391.440	669.691	0.827814
Sum128AdvSimd_Range52	311.628	841.207	1.039826
Sum128AdvSimd_Range52_Impl	312.465	838.955	1.037043
Sum128Traits	132.369	1980.402	2.447999
Sum128Traits_Range52	123.573	2121.362	2.622242
Sum256Base_Basic	965.899	271.399	0.335480
Sum256Base	1132.505	231.473	0.286126
Sum256Base_Range52_Impl	1132.198	231.535	0.286204
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1131.964	231.583	0.286263
Sum256Traits_Range52	1133.611	231.247	0.285847

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
SumScalar	364.361	719.461
SumBcl	125.327	2091.681	2.907287
SumBase_Range52_Impl	330.257	793.757	1.103266
SumBase_Range52RoundToEven	160.157	1636.794	2.275026
SumTraits	125.257	2092.845	2.908905
SumTraits_Range52	125.275	2092.546	2.908489
SumTraits_Range52RoundToEven	125.245	2093.056	2.909198
Sum128Base_Basic	410.992	637.832	0.886541
Sum128Base	408.676	641.447	0.891566
Sum128Base_Range52_Impl	408.609	641.553	0.891712
Sum128AdvSimd_Range52	378.287	692.976	0.963187
Sum128AdvSimd_Range52_Impl	373.095	702.620	0.976591
Sum128Traits	133.331	1966.116	2.732760
Sum128Traits_Range52	133.420	1964.809	2.730944
Sum128Traits_Range52RoundToEven	133.527	1963.223	2.728739
Sum256Base_Basic	918.376	285.443	0.396745
Sum256Base	1071.406	244.673	0.340078
Sum256Base_Range52_Impl	1069.671	245.070	0.340630
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1073.276	244.247	0.339485
Sum256Traits_Range52	1069.783	245.044	0.340594
Sum256Traits_Range52RoundToEven	1069.217	245.174	0.340774

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
SumScalar	362.955	722.250
SumBcl	949.373	276.123	0.382310
SumBase_Range52_Impl	326.011	804.097	1.113321
SumBase_Range52RoundToEven	145.793	1798.058	2.489522
SumTraits	132.514	1978.243	2.738999
SumTraits_Range52	132.273	1981.833	2.743971
SumTraits_Range52RoundToEven	132.518	1978.170	2.738898
Sum128Base_Basic	393.292	666.538	0.922863
Sum128Base	393.164	666.754	0.923163
Sum128Base_Range52_Impl	389.255	673.450	0.932434
Sum128AdvSimd_Range52	349.022	751.081	1.039918
Sum128AdvSimd_Range52_Impl	347.947	753.402	1.043132
Sum128Traits	123.562	2121.550	2.937417
Sum128Traits_Range52	123.782	2117.787	2.932207
Sum128Traits_Range52RoundToEven	123.562	2121.565	2.937438
Sum256Base_Basic	910.119	288.033	0.398799
Sum256Base	1060.950	247.084	0.342103
Sum256Base_Range52_Impl	1059.966	247.314	0.342421
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1059.848	247.341	0.342459
Sum256Traits_Range52	1062.026	246.834	0.341757
Sum256Traits_Range52RoundToEven	1062.396	246.748	0.341638

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	282.168	929.037
SumBcl	106.261	2466.989	2.655427
SumBase_Range52_Impl	132.712	1975.284	2.126163
SumTraits	106.340	2465.156	2.653454
SumTraits_Range52	106.336	2465.252	2.653558
Sum128Bcl	106.357	2464.746	2.653013
Sum128Base_Basic	399.524	656.141	0.706259
Sum128Base	106.388	2464.048	2.652261
Sum128Base_Range52_Impl	133.587	1962.344	2.112235
Sum128AdvSimd_Range52	106.492	2461.642	2.649671
Sum128AdvSimd_Range52_Impl	249.443	1050.919	1.131192
Sum128Traits	106.316	2465.698	2.654037
Sum128Traits_Range52	106.424	2463.193	2.651341
Sum256Bcl	1188.698	220.530	0.237375
Sum256Base_Basic	1019.946	257.018	0.276650
Sum256Base	1189.331	220.413	0.237249
Sum256Base_Range52_Impl	2718.840	96.418	0.103782
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1189.132	220.450	0.237289
Sum256Traits_Range52	1371.946	191.075	0.205670

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	282.066	929.370
SumBcl	107.706	2433.892	2.618861
SumBase_Range52_Impl	135.073	1940.764	2.088257
SumTraits	107.739	2433.145	2.618058
SumTraits_Range52	107.816	2431.398	2.616178
Sum128Bcl	107.915	2429.164	2.613774
Sum128Base_Basic	415.964	630.209	0.678103
Sum128Base	107.810	2431.543	2.616333
Sum128Base_Range52_Impl	136.011	1927.375	2.073850
Sum128AdvSimd_Range52	107.825	2431.204	2.615969
Sum128AdvSimd_Range52_Impl	268.945	974.713	1.048789
Sum128Traits	107.915	2429.172	2.613783
Sum128Traits_Range52	107.849	2430.665	2.615389
Sum256Bcl	1170.915	223.880	0.240894
Sum256Base_Basic	1028.803	254.805	0.274169
Sum256Base	1172.369	223.602	0.240595
Sum256Base_Range52_Impl	2422.239	108.224	0.116449
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1171.139	223.837	0.240848
Sum256Traits_Range52	1384.928	189.283	0.203668

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	229.851	1140.497
SumBcl	106.267	2466.834	2.162946
SumBase_Range52_Impl	309.411	847.236	0.742865
SumBase_Range52RoundToEven	132.808	1973.855	1.730696
SumTraits	106.320	2465.618	2.161880
SumTraits_Range52	106.335	2465.271	2.161576
SumTraits_Range52RoundToEven	106.461	2462.348	2.159012
Sum128Bcl	106.686	2457.154	2.154458
Sum128Base_Basic	399.694	655.861	0.575066
Sum128Base	106.324	2465.516	2.161790
Sum128Base_Range52_Impl	239.828	1093.048	0.958396
Sum128AdvSimd_Range52	106.401	2463.729	2.160223
Sum128AdvSimd_Range52_Impl	316.113	829.273	0.727116
Sum128Traits	106.281	2466.519	2.162669
Sum128Traits_Range52	106.343	2465.084	2.161412
Sum128Traits_Range52RoundToEven	106.354	2464.818	2.161178
Sum256Bcl	955.418	274.376	0.240576
Sum256Base_Basic	1008.079	260.043	0.228008
Sum256Base	1124.429	233.135	0.204415
Sum256Base_Range52_Impl	5359.131	48.915	0.042890
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1122.737	233.486	0.204723
Sum256Traits_Range52	1326.849	197.569	0.173230
Sum256Traits_Range52RoundToEven	2499.919	104.861	0.091943

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	229.864	1140.429
SumBcl	107.755	2432.773	2.133208
SumBase_Range52_Impl	313.160	837.094	0.734017
SumBase_Range52RoundToEven	134.659	1946.729	1.707014
SumTraits	107.771	2432.420	2.132899
SumTraits_Range52	107.828	2431.122	2.131760
SumTraits_Range52RoundToEven	107.916	2429.149	2.130030
Sum128Bcl	107.925	2428.955	2.129861
Sum128Base_Basic	406.127	645.472	0.565991
Sum128Base	107.718	2433.617	2.133948
Sum128Base_Range52_Impl	264.501	991.089	0.869049
Sum128AdvSimd_Range52	107.948	2428.434	2.129404
Sum128AdvSimd_Range52_Impl	348.654	751.874	0.659290
Sum128Traits	107.762	2432.610	2.133065
Sum128Traits_Range52	107.936	2428.693	2.129630
Sum128Traits_Range52RoundToEven	108.427	2417.703	2.119993
Sum256Bcl	965.967	271.380	0.237963
Sum256Base_Basic	1022.090	256.478	0.224896
Sum256Base	1141.426	229.664	0.201383
Sum256Base_Range52_Impl	5032.958	52.085	0.045672
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1140.664	229.817	0.201518
Sum256Traits_Range52	1139.301	230.092	0.201759
Sum256Traits_Range52RoundToEven	2239.263	117.067	0.102652

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

