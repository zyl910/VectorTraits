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
VectorTraitsGlobal.InitCheckSum:	-25396098	# 0xFE7C7C7E
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
SumScalar	323.990	809.110
SumBcl	204.872	1279.547	1.581425
SumBase_Range52_Impl	81.822	3203.819	3.959681
SumTraits	200.375	1308.269	1.616923
SumTraits_Range52	200.268	1308.963	1.617781

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	711.520	368.428
SumBcl	123.017	2130.960	5.783924
SumBase_Range52_Impl	87.300	3002.788	8.150267
SumTraits	140.407	1867.033	5.067563
SumTraits_Range52	105.974	2473.662	6.714095

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	166.044	1578.764
SumBcl	212.762	1232.097	0.780419
SumBase_Range52_Impl	274.402	955.328	0.605112
SumBase_Range52RoundToEven	81.314	3223.845	2.042006
SumTraits	210.314	1246.439	0.789503
SumTraits_Range52	208.062	1259.932	0.798050
SumTraits_Range52RoundToEven	80.654	3250.229	2.058718

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	979.752	267.561
SumBcl	1563.891	167.623	0.626484
SumBase_Range52_Impl	263.383	995.297	3.719882
SumBase_Range52RoundToEven	64.113	4088.803	15.281733
SumTraits	1594.662	164.388	0.614395
SumTraits_Range52	262.475	998.739	3.732747
SumTraits_Range52RoundToEven	61.183	4284.580	16.013442

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
SumScalar	312.686	838.363
SumBcl	199.432	1314.451	1.567878
SumBase_Range52_Impl	80.586	3252.973	3.880149
SumTraits	199.876	1311.535	1.564400
SumTraits_Range52	199.435	1314.433	1.567857

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	719.843	364.168
SumBcl	121.685	2154.290	5.915647
SumBase_Range52_Impl	80.907	3240.061	8.897157
SumTraits	113.769	2304.174	6.327227
SumTraits_Range52	144.828	1810.035	4.970328

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	177.059	1480.543
SumBcl	210.154	1247.390	0.842522
SumBase_Range52_Impl	265.758	986.401	0.666242
SumBase_Range52RoundToEven	73.074	3587.373	2.423011
SumTraits	208.648	1256.391	0.848602
SumTraits_Range52	204.206	1283.724	0.867063
SumTraits_Range52RoundToEven	74.892	3500.278	2.364185

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	927.820	282.538
SumBcl	1523.549	172.061	0.608986
SumBase_Range52_Impl	265.823	986.159	3.490364
SumBase_Range52RoundToEven	59.296	4420.939	15.647263
SumTraits	1441.271	181.884	0.643751
SumTraits_Range52	244.079	1074.011	3.801304
SumTraits_Range52RoundToEven	64.826	4043.831	14.312545

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
SumScalar	317.251	826.298
SumBcl	206.861	1267.246	1.533643
SumBase_Range52_Impl	87.125	3008.814	3.641320
SumTraits	120.924	2167.841	2.623559
SumTraits_Range52	83.803	3128.094	3.785674
Sum128Base_Basic	1694.282	154.723	0.187248
Sum128Base	1679.731	156.063	0.188870
Sum128Base_Range52_Impl	1676.952	156.322	0.189183
Sum128Traits	1793.990	146.123	0.176841
Sum128Traits_Range52	1681.282	155.919	0.188696
Sum256Base_Basic	537.135	488.042	0.590636
Sum256Base	564.550	464.341	0.561954
Sum256Base_Range52_Impl	536.779	488.365	0.591027
Sum256Avx2_Bcl	108.641	2412.941	2.920183
Sum256Avx2_HwScalar	208.756	1255.743	1.519722
Sum256Avx2_Range52	83.659	3133.477	3.792189
Sum256Traits	111.793	2344.897	2.837835
Sum256Traits_Range52	86.755	3021.647	3.656850

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
SumScalar	736.832	355.772
SumBcl	118.013	2221.308	6.243634
SumBase_Range52_Impl	84.413	3105.492	8.728890
SumTraits	107.293	2443.253	6.867477
SumTraits_Range52	90.326	2902.193	8.157460
Sum128Base_Basic	1728.874	151.627	0.426192
Sum128Base	1739.254	150.722	0.423648
Sum128Base_Range52_Impl	1744.908	150.234	0.422276
Sum128Traits	1735.259	151.069	0.424624
Sum128Traits_Range52	1746.251	150.118	0.421951
Sum256Base_Basic	904.618	289.784	0.814523
Sum256Base	910.012	288.067	0.809695
Sum256Base_Range52_Impl	922.719	284.099	0.798544
Sum256Avx2_Bcl	104.631	2505.417	7.042207
Sum256Avx2_Range52	86.645	3025.486	8.504013
Sum256Traits	117.733	2226.600	6.258510
Sum256Traits_Range52	91.170	2875.333	8.081962

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
SumScalar	166.574	1573.739
SumBcl	207.606	1262.698	0.802355
SumBase_Range52_Impl	237.660	1103.022	0.700893
SumBase_Range52RoundToEven	83.973	3121.774	1.983667
SumTraits	200.544	1307.164	0.830611
SumTraits_Range52	92.227	2842.387	1.806136
SumTraits_Range52RoundToEven	84.663	3096.337	1.967504
Sum128Base_Basic	1559.329	168.113	0.106824
Sum128Base	1556.686	168.399	0.107006
Sum128Base_Range52_Impl	1557.239	168.339	0.106968
Sum128Traits	1560.034	168.037	0.106776
Sum128Traits_Range52	1564.865	167.519	0.106446
Sum128Traits_Range52RoundToEven	1571.996	166.759	0.105963
Sum256Base_Basic	500.884	523.363	0.332560
Sum256Base	502.400	521.784	0.331557
Sum256Base_Range52_Impl	503.652	520.486	0.330732
Sum256Avx2_HwScalar	204.561	1281.497	0.814301
Sum256Avx2_ShiftVar	169.501	1546.561	0.982730
Sum256Avx2_ShiftVarFix	208.314	1258.407	0.799629
Sum256Avx2_Range52	83.614	3135.172	1.992180
Sum256Traits	183.622	1427.631	0.907159
Sum256Traits_Range52	81.665	3210.002	2.039730
Sum256Traits_Range52RoundToEven	79.469	3298.692	2.096086

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
SumScalar	1002.650	261.451
SumBcl	1619.242	161.893	0.619209
SumBase_Range52_Impl	269.577	972.427	3.719344
SumBase_Range52RoundToEven	72.551	3613.233	13.819914
SumTraits	137.153	1911.326	7.310449
SumTraits_Range52	92.089	2846.625	10.887788
SumTraits_Range52RoundToEven	81.216	3227.748	12.345508
Sum128Base_Basic	1724.046	152.052	0.581568
Sum128Base	1710.298	153.274	0.586243
Sum128Base_Range52_Impl	1707.687	153.508	0.587139
Sum128Traits	1731.289	151.416	0.579135
Sum128Traits_Range52	1730.982	151.442	0.579238
Sum128Traits_Range52RoundToEven	1712.047	153.117	0.585644
Sum256Base_Basic	1010.628	259.387	0.992105
Sum256Base	1054.591	248.574	0.950747
Sum256Base_Range52_Impl	1050.333	249.582	0.954602
Sum256Avx2_ShiftVar	148.912	1760.395	6.733168
Sum256Avx2_Range52	105.342	2488.513	9.518076
Sum256Traits	335.964	780.274	2.984397
Sum256Traits_Range52	196.200	1336.107	5.110349
Sum256Traits_Range52RoundToEven	88.079	2976.222	11.383469

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
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
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
SumScalar	525.533	498.815
SumBcl	407.859	642.732	1.288519
SumBase_Range52_Impl	214.711	1220.915	2.447631
SumTraits	170.192	1540.280	3.087878
SumTraits_Range52	189.029	1386.792	2.780172
Sum128Base_Basic	2693.596	97.321	0.195105
Sum128Base	2089.395	125.464	0.251524
Sum128Base_Range52_Impl	2215.024	118.348	0.237259
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	2455.005	106.779	0.214066
Sum128Traits_Range52	2383.727	109.972	0.220467
Sum256Base_Basic	1259.665	208.106	0.417201
Sum256Base	1214.821	215.788	0.432602
Sum256Base_Range52_Impl	1211.934	216.302	0.433632
Sum256Avx2_Bcl	125.849	2083.005	4.175907
Sum256Avx2_HwScalar	256.478	1022.094	2.049043
Sum256Avx2_Range52	87.701	2989.082	5.992365
Sum256Traits	102.970	2545.836	5.103768
Sum256Traits_Range52	101.176	2590.968	5.194247

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
SumScalar	776.756	337.486
SumBcl	155.468	1686.164	4.996254
SumBase_Range52_Impl	93.185	2813.161	8.335646
SumTraits	117.980	2221.932	6.583783
SumTraits_Range52	103.094	2542.771	7.534456
Sum128Base_Basic	1738.347	150.801	0.446836
Sum128Base	1812.259	144.650	0.428612
Sum128Base_Range52_Impl	2059.529	127.283	0.377152
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	2196.166	119.364	0.353687
Sum128Traits_Range52	1986.214	131.982	0.391074
Sum256Base_Basic	1061.035	247.065	0.732074
Sum256Base	1062.830	246.647	0.730838
Sum256Base_Range52_Impl	1084.486	241.722	0.716244
Sum256Avx2_Bcl	99.402	2637.207	7.814280
Sum256Avx2_Range52	97.815	2679.988	7.941041
Sum256Traits	125.077	2095.854	6.210201
Sum256Traits_Range52	103.283	2538.114	7.520656

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
SumScalar	226.532	1157.204
SumBcl	279.643	937.423	0.810076
SumBase_Range52_Impl	153.640	1706.221	1.474435
SumBase_Range52RoundToEven	109.419	2395.777	2.070316
SumTraits	246.159	1064.939	0.920269
SumTraits_Range52	248.841	1053.460	0.910349
SumTraits_Range52RoundToEven	187.685	1396.722	1.206980
Sum128Base_Basic	2148.227	122.028	0.105451
Sum128Base	1737.422	150.881	0.130384
Sum128Base_Range52_Impl	1687.395	155.354	0.134250
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1550.499	169.071	0.146103
Sum128Traits_Range52	1552.842	168.816	0.145882
Sum128Traits_Range52RoundToEven	1558.331	168.221	0.145369
Sum256Base_Basic	470.158	557.566	0.481822
Sum256Base	462.679	566.578	0.489610
Sum256Base_Range52_Impl	489.770	535.240	0.462528
Sum256Avx2_HwScalar	288.588	908.366	0.784967
Sum256Avx2_ShiftVar	246.778	1062.267	0.917960
Sum256Avx2_ShiftVarFix	232.374	1128.112	0.974861
Sum256Avx2_Range52	119.402	2195.465	1.897216
Sum256Traits	255.142	1027.444	0.887868
Sum256Traits_Range52	118.215	2217.519	1.916274
Sum256Traits_Range52RoundToEven	111.182	2357.798	2.037496

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
SumScalar	1425.055	183.954
SumBcl	1878.309	139.564	0.758691
SumBase_Range52_Impl	143.365	1828.504	9.940030
SumBase_Range52RoundToEven	104.302	2513.327	13.662834
SumTraits	169.080	1550.417	8.428304
SumTraits_Range52	96.455	2717.782	14.774283
SumTraits_Range52RoundToEven	77.792	3369.785	18.318672
Sum128Base_Basic	1997.280	131.250	0.713498
Sum128Base	2058.346	127.357	0.692330
Sum128Base_Range52_Impl	2030.349	129.113	0.701877
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1922.905	136.327	0.741095
Sum128Traits_Range52	1942.861	134.927	0.733483
Sum128Traits_Range52RoundToEven	1844.654	142.110	0.772532
Sum256Base_Basic	1098.619	238.612	1.297134
Sum256Base	1112.573	235.620	1.280865
Sum256Base_Range52_Impl	1109.350	236.304	1.284586
Sum256Avx2_ShiftVar	118.773	2207.110	11.998189
Sum256Avx2_Range52	112.717	2325.689	12.642804
Sum256Traits	137.098	1912.091	10.394423
Sum256Traits_Range52	119.161	2199.915	11.959077
Sum256Traits_Range52RoundToEven	81.301	3224.381	17.528232

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
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
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
SumScalar	383.246	684.010
SumBcl	272.050	963.587	1.408732
SumBase_Range52_Impl	120.056	2183.514	3.192225
SumTraits	141.626	1850.954	2.706032
SumTraits_Range52	101.217	2589.924	3.786382
Sum128Base_Basic	1717.732	152.611	0.223111
Sum128Base	1924.529	136.212	0.199137
Sum128Base_Range52_Impl	2267.315	115.619	0.169031
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1919.190	136.591	0.199691
Sum128Traits_Range52	1785.948	146.781	0.214590
Sum256Base_Basic	579.085	452.686	0.661812
Sum256Base	584.813	448.253	0.655331
Sum256Base_Range52_Impl	526.064	498.312	0.728515
Sum256Avx2_Bcl	94.415	2776.513	4.059169
Sum256Avx2_HwScalar	211.025	1242.242	1.816117
Sum256Avx2_Range52	81.736	3207.198	4.688816
Sum256Traits	89.422	2931.525	4.285791
Sum256Traits_Range52	116.936	2241.768	3.277390

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
SumScalar	1008.835	259.848
SumBcl	167.933	1561.005	6.007374
SumBase_Range52_Impl	104.858	2499.996	9.620985
SumTraits	104.977	2497.162	9.610078
SumTraits_Range52	98.454	2662.599	10.246747
Sum128Base_Basic	1991.622	131.623	0.506539
Sum128Base	1988.973	131.799	0.507214
Sum128Base_Range52_Impl	1916.621	136.774	0.526361
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	2411.659	108.699	0.418316
Sum128Traits_Range52	1966.646	133.295	0.512973
Sum256Base_Basic	980.302	267.411	1.029106
Sum256Base	961.801	272.555	1.048902
Sum256Base_Range52_Impl	920.761	284.704	1.095654
Sum256Avx2_Bcl	81.997	3197.001	12.303339
Sum256Avx2_Range52	83.512	3138.986	12.080076
Sum256Traits	90.171	2907.186	11.188016
Sum256Traits_Range52	83.709	3131.618	12.051721

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
SumScalar	163.657	1601.785
SumBcl	208.749	1255.784	0.783991
SumBase_Range52_Impl	124.474	2106.012	1.314791
SumBase_Range52RoundToEven	69.239	3786.066	2.363655
SumTraits	186.956	1402.169	0.875379
SumTraits_Range52	85.682	3059.483	1.910047
SumTraits_Range52RoundToEven	67.132	3904.915	2.437853
Sum128Base_Basic	1544.456	169.732	0.105964
Sum128Base	1540.957	170.118	0.106205
Sum128Base_Range52_Impl	1545.922	169.571	0.105864
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1562.156	167.809	0.104764
Sum128Traits_Range52	1552.543	168.848	0.105412
Sum128Traits_Range52RoundToEven	1544.517	169.726	0.105960
Sum256Base_Basic	461.681	567.803	0.354482
Sum256Base	466.818	561.555	0.350581
Sum256Base_Range52_Impl	464.425	564.448	0.352387
Sum256Avx2_HwScalar	199.309	1315.262	0.821123
Sum256Avx2_ShiftVar	147.933	1772.050	1.106297
Sum256Avx2_ShiftVarFix	174.075	1505.927	0.940156
Sum256Avx2_Range52	73.858	3549.275	2.215825
Sum256Traits	168.116	1559.306	0.973480
Sum256Traits_Range52	78.665	3332.418	2.080441
Sum256Traits_Range52RoundToEven	66.338	3951.613	2.467007

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
SumScalar	953.753	274.855
SumBcl	1238.815	211.609	0.769891
SumBase_Range52_Impl	125.853	2082.936	7.578299
SumBase_Range52RoundToEven	59.462	4408.608	16.039737
SumTraits	110.970	2362.301	8.594707
SumTraits_Range52	79.000	3318.260	12.072749
SumTraits_Range52RoundToEven	62.329	4205.803	15.301876
Sum128Base_Basic	1667.814	157.178	0.571858
Sum128Base	1674.243	156.575	0.569662
Sum128Base_Range52_Impl	1669.627	157.007	0.571237
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1673.746	156.621	0.569831
Sum128Traits_Range52	1669.698	157.001	0.571213
Sum128Traits_Range52RoundToEven	1673.386	156.655	0.569954
Sum256Base_Basic	1072.450	244.435	0.889322
Sum256Base	1072.392	244.448	0.889369
Sum256Base_Range52_Impl	1071.688	244.609	0.889954
Sum256Avx2_ShiftVar	115.827	2263.245	8.234313
Sum256Avx2_Range52	71.209	3681.309	13.393623
Sum256Traits	103.933	2522.246	9.176629
Sum256Traits_Range52	67.677	3873.434	14.092628
Sum256Traits_Range52RoundToEven	51.609	5079.418	18.480329

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
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
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
SumScalar	314.287	834.091
SumBcl	85.144	3078.841	3.691255
SumBase_Range52_Impl	80.192	3268.947	3.919175
SumTraits	85.513	3065.538	3.675306
SumTraits_Range52	81.788	3205.147	3.842685
Sum128Bcl	170.290	1539.399	1.845602
Sum128Base_Basic	858.910	305.205	0.365914
Sum128Base	161.191	1626.294	1.949782
Sum128Base_Range52_Impl	164.722	1591.434	1.907987
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	170.542	1537.125	1.842875
Sum128Traits_Range52	157.895	1660.239	1.990478
Sum256Bcl	94.837	2764.143	3.313960
Sum256Base_Basic	533.191	491.651	0.589446
Sum256Base	95.051	2757.925	3.306505
Sum256Base_Range52_Impl	80.239	3267.043	3.916892
Sum256Avx2_Bcl	83.767	3129.453	3.751934
Sum256Avx2_HwScalar	199.302	1315.311	1.576940
Sum256Avx2_Range52	80.359	3262.159	3.911036
Sum256Traits	84.320	3108.917	3.727313
Sum256Traits_Range52	85.222	3075.995	3.687843

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
SumScalar	686.737	381.724
SumBcl	92.701	2827.831	7.408048
SumBase_Range52_Impl	81.062	3233.887	8.471790
SumTraits	86.857	3018.124	7.906558
SumTraits_Range52	85.299	3073.234	8.050928
Sum128Bcl	159.978	1638.628	4.292701
Sum128Base_Basic	935.383	280.253	0.734177
Sum128Base	159.196	1646.676	4.313784
Sum128Base_Range52_Impl	158.204	1656.998	4.340826
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	174.905	1498.778	3.926337
Sum128Traits_Range52	164.087	1597.590	4.185194
Sum256Bcl	83.403	3143.093	8.233937
Sum256Base_Basic	861.260	304.373	0.797363
Sum256Base	96.187	2725.371	7.139634
Sum256Base_Range52_Impl	83.829	3127.129	8.192115
Sum256Avx2_Bcl	94.513	2773.639	7.266082
Sum256Avx2_Range52	87.868	2983.385	7.815552
Sum256Traits	93.036	2817.649	7.381373
Sum256Traits_Range52	87.111	3009.305	7.883452

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
SumScalar	158.787	1650.917
SumBcl	439.589	596.339	0.361217
SumBase_Range52_Impl	101.429	2584.500	1.565494
SumBase_Range52RoundToEven	55.882	4691.007	2.841456
SumTraits	163.538	1602.959	0.970951
SumTraits_Range52	79.597	3293.388	1.994884
SumTraits_Range52RoundToEven	62.017	4227.001	2.560396
Sum128Bcl	768.487	341.117	0.206623
Sum128Base_Basic	806.059	325.217	0.196992
Sum128Base	768.442	341.137	0.206635
Sum128Base_Range52_Impl	165.798	1581.100	0.957711
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	768.652	341.044	0.206578
Sum128Traits_Range52	163.683	1601.538	0.970090
Sum128Traits_Range52RoundToEven	93.784	2795.176	1.693105
Sum256Bcl	442.842	591.958	0.358563
Sum256Base_Basic	459.782	570.148	0.345353
Sum256Base	447.278	586.088	0.355008
Sum256Base_Range52_Impl	112.674	2326.579	1.409265
Sum256Avx2_HwScalar	205.476	1275.789	0.772776
Sum256Avx2_ShiftVar	168.258	1557.992	0.943714
Sum256Avx2_ShiftVarFix	159.887	1639.553	0.993117
Sum256Avx2_Range52	78.748	3328.898	2.016394
Sum256Traits	167.112	1568.669	0.950181
Sum256Traits_Range52	79.458	3299.143	1.998371
Sum256Traits_Range52RoundToEven	62.811	4173.526	2.528005

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
SumScalar	995.251	263.395
SumBcl	1153.614	227.237	0.862725
SumBase_Range52_Impl	115.231	2274.944	8.637010
SumBase_Range52RoundToEven	58.589	4474.250	16.986853
SumTraits	131.157	1998.703	7.588239
SumTraits_Range52	79.731	3287.869	12.482662
SumTraits_Range52RoundToEven	72.610	3610.288	13.706752
Sum128Bcl	1144.051	229.137	0.869936
Sum128Base_Basic	1122.781	233.477	0.886416
Sum128Base	1105.038	237.226	0.900648
Sum128Base_Range52_Impl	176.853	1482.270	5.627561
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1187.689	220.718	0.837972
Sum128Traits_Range52	181.694	1442.774	5.477609
Sum128Traits_Range52RoundToEven	112.019	2340.166	8.884630
Sum256Bcl	1148.495	228.250	0.866570
Sum256Base_Basic	1049.639	249.747	0.948184
Sum256Base	1056.198	248.196	0.942296
Sum256Base_Range52_Impl	98.993	2648.116	10.053790
Sum256Avx2_ShiftVar	153.234	1710.743	6.494975
Sum256Avx2_Range52	101.858	2573.627	9.770985
Sum256Traits	154.241	1699.576	6.452577
Sum256Traits_Range52	111.529	2350.458	8.923704
Sum256Traits_Range52RoundToEven	80.557	3254.135	12.354588

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
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
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
SumScalar	319.856	819.569
SumBcl	125.385	2090.714	2.550992
SumBase_Range52_Impl	181.221	1446.543	1.765004
SumTraits	125.284	2092.393	2.553040
SumTraits_Range52	4687.964	55.919	0.068229
Sum128Base_Basic	1190.331	220.228	0.268712
Sum128Base	1181.978	221.784	0.270611
Sum128Base_Range52_Impl	1173.705	223.347	0.272518
Sum128Traits	1182.395	221.706	0.270515
Sum128Traits_Range52	1169.875	224.079	0.273410
Sum256Base_Basic	1642.712	159.580	0.194712
Sum256Base	1765.761	148.459	0.181143
Sum256Base_Range52_Impl	1873.778	139.901	0.170701
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2032.563	128.972	0.157366
Sum256Traits_Range52	2036.730	128.708	0.157044

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
SumScalar	318.881	822.075
SumBcl	132.613	1976.754	2.404592
SumBase_Range52_Impl	177.202	1479.348	1.799530
SumTraits	132.499	1978.461	2.406669
SumTraits_Range52	4645.460	56.430	0.068644
Sum128Base_Basic	1101.105	238.074	0.289601
Sum128Base	1090.903	240.300	0.292309
Sum128Base_Range52_Impl	1101.677	237.950	0.289451
Sum128Traits	1089.787	240.546	0.292609
Sum128Traits_Range52	1097.253	238.909	0.290618
Sum256Base_Basic	1573.422	166.608	0.202667
Sum256Base	1731.112	151.431	0.184206
Sum256Base_Range52_Impl	1853.826	141.407	0.172012
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2006.595	130.641	0.158916
Sum256Traits_Range52	2007.245	130.599	0.158865

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
SumScalar	357.395	733.485
SumBcl	133.193	1968.145	2.683277
SumBase_Range52_Impl	1192.067	219.907	0.299811
SumBase_Range52RoundToEven	161.476	1623.424	2.213301
SumTraits	124.812	2100.303	2.863456
SumTraits_Range52	124.910	2098.663	2.861220
SumTraits_Range52RoundToEven	162.871	1609.517	2.194341
Sum128Base_Basic	1107.301	236.741	0.322762
Sum128Base	1107.618	236.674	0.322670
Sum128Base_Range52_Impl	1114.122	235.292	0.320786
Sum128Traits	1107.999	236.592	0.322559
Sum128Traits_Range52	1102.380	237.798	0.324203
Sum128Traits_Range52RoundToEven	1111.510	235.845	0.321540
Sum256Base_Basic	1596.091	164.241	0.223919
Sum256Base	1740.891	150.580	0.205294
Sum256Base_Range52_Impl	1732.400	151.318	0.206300
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1999.688	131.092	0.178725
Sum256Traits_Range52	2000.400	131.046	0.178662
Sum256Traits_Range52RoundToEven	1998.975	131.139	0.178789

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	356.829	734.649
SumBcl	1238.647	211.637	0.288080
SumBase_Range52_Impl	1207.529	217.091	0.295504
SumBase_Range52RoundToEven	177.167	1479.641	2.014079
SumTraits	1226.191	213.787	0.291006
SumTraits_Range52	1212.555	216.191	0.294279
SumTraits_Range52RoundToEven	185.493	1413.230	1.923680
Sum128Base_Basic	1047.916	250.158	0.340513
Sum128Base	1060.043	247.296	0.336617
Sum128Base_Range52_Impl	1061.839	246.877	0.336048
Sum128Traits	1067.451	245.579	0.334281
Sum128Traits_Range52	1049.819	249.704	0.339896
Sum128Traits_Range52RoundToEven	1039.543	252.172	0.343256
Sum256Base_Basic	1550.531	169.067	0.230133
Sum256Base	1731.896	151.362	0.206034
Sum256Base_Range52_Impl	1703.903	153.849	0.209419
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1970.828	133.012	0.181055
Sum256Traits_Range52	1963.261	133.525	0.181753
Sum256Traits_Range52RoundToEven	1964.394	133.448	0.181648

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
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
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
SumScalar	320.433	818.092
SumBcl	124.881	2099.149	2.565907
SumBase_Range52_Impl	161.880	1619.370	1.979446
SumTraits	124.864	2099.440	2.566263
SumTraits_Range52	133.391	1965.226	2.402206
Sum128Base_Basic	409.928	639.488	0.781682
Sum128Base	409.694	639.853	0.782128
Sum128Base_Range52_Impl	406.213	645.336	0.788830
Sum128AdvSimd_Range52	374.734	699.548	0.855096
Sum128AdvSimd_Range52_Impl	322.949	811.720	0.992211
Sum128Traits	124.907	2098.720	2.565383
Sum128Traits_Range52	133.248	1967.339	2.404789
Sum256Base_Basic	978.142	268.002	0.327594
Sum256Base	1143.392	229.269	0.280248
Sum256Base_Range52_Impl	1142.406	229.467	0.280490
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1143.411	229.265	0.280243
Sum256Traits_Range52	1141.870	229.574	0.280622

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
SumScalar	317.986	824.389
SumBcl	123.260	2126.764	2.579805
SumBase_Range52_Impl	158.530	1653.593	2.005840
SumTraits	132.259	1982.044	2.404258
SumTraits_Range52	123.323	2125.672	2.578481
Sum128Base_Basic	387.762	676.043	0.820053
Sum128Base	387.995	675.637	0.819561
Sum128Base_Range52_Impl	388.171	675.331	0.819190
Sum128AdvSimd_Range52	283.011	926.269	1.123582
Sum128AdvSimd_Range52_Impl	289.210	906.415	1.099499
Sum128Traits	132.195	1983.007	2.405426
Sum128Traits_Range52	123.461	2123.301	2.575605
Sum256Base_Basic	964.985	271.656	0.329524
Sum256Base	1137.335	230.490	0.279589
Sum256Base_Range52_Impl	1136.621	230.635	0.279764
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1140.026	229.946	0.278928
Sum256Traits_Range52	1137.783	230.399	0.279478

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
SumScalar	357.408	733.458
SumBcl	133.200	1968.044	2.683239
SumBase_Range52_Impl	339.046	773.182	1.054159
SumBase_Range52RoundToEven	161.167	1626.534	2.217622
SumTraits	124.973	2097.608	2.859886
SumTraits_Range52	125.010	2096.976	2.859025
SumTraits_Range52RoundToEven	124.988	2097.357	2.859544
Sum128Base_Basic	410.592	638.454	0.870471
Sum128Base	412.752	635.113	0.865916
Sum128Base_Range52_Impl	412.006	636.263	0.867484
Sum128AdvSimd_Range52	379.773	690.265	0.941110
Sum128AdvSimd_Range52_Impl	381.338	687.433	0.937249
Sum128Traits	133.253	1967.272	2.682187
Sum128Traits_Range52	132.976	1971.364	2.687766
Sum128Traits_Range52RoundToEven	133.168	1968.517	2.683884
Sum256Base_Basic	918.826	285.303	0.388984
Sum256Base	1071.257	244.707	0.333634
Sum256Base_Range52_Impl	1071.387	244.677	0.333594
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1073.557	244.183	0.332920
Sum256Traits_Range52	1072.981	244.314	0.333098
Sum256Traits_Range52RoundToEven	1071.272	244.704	0.333630

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
SumScalar	360.074	728.029
SumBcl	1055.206	248.429	0.341236
SumBase_Range52_Impl	332.847	787.582	1.081801
SumBase_Range52RoundToEven	159.218	1646.451	2.261519
SumTraits	132.118	1984.165	2.725394
SumTraits_Range52	132.032	1985.462	2.727176
SumTraits_Range52RoundToEven	132.296	1981.498	2.721731
Sum128Base_Basic	392.221	668.357	0.918037
Sum128Base	388.966	673.951	0.925720
Sum128Base_Range52_Impl	389.604	672.846	0.924203
Sum128AdvSimd_Range52	352.233	744.235	1.022260
Sum128AdvSimd_Range52_Impl	351.287	746.238	1.025012
Sum128Traits	123.594	2121.013	2.913364
Sum128Traits_Range52	123.642	2120.190	2.912234
Sum128Traits_Range52RoundToEven	123.983	2114.356	2.904221
Sum256Base_Basic	908.230	288.632	0.396456
Sum256Base	1061.496	246.957	0.339213
Sum256Base_Range52_Impl	1062.207	246.792	0.338986
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1061.887	246.866	0.339089
Sum256Traits_Range52	1065.841	245.950	0.337831
Sum256Traits_Range52RoundToEven	1061.220	247.021	0.339302

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
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
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
SumScalar	319.090	821.536
SumBcl	125.079	2095.821	2.551099
SumBase_Range52_Impl	147.778	1773.901	2.159248
SumTraits	124.855	2099.593	2.555691
SumTraits_Range52	133.409	1964.970	2.391823
Sum128Base_Basic	403.950	648.952	0.789925
Sum128Base	404.154	648.624	0.789525
Sum128Base_Range52_Impl	404.366	648.285	0.789112
Sum128AdvSimd_Range52	322.512	812.819	0.989389
Sum128AdvSimd_Range52_Impl	322.282	813.398	0.990094
Sum128Traits	124.937	2098.213	2.554012
Sum128Traits_Range52	133.210	1967.895	2.395384
Sum256Base_Basic	977.769	268.104	0.326345
Sum256Base	1146.264	228.694	0.278374
Sum256Base_Range52_Impl	1144.385	229.070	0.278831
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1144.086	229.130	0.278904
Sum256Traits_Range52	1145.152	228.916	0.278644

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
SumScalar	320.105	818.930
SumBcl	123.500	2122.625	2.591949
SumBase_Range52_Impl	145.746	1798.634	2.196322
SumTraits	132.578	1977.281	2.414469
SumTraits_Range52	123.572	2121.393	2.590445
Sum128Base_Basic	386.846	677.644	0.827475
Sum128Base	386.921	677.514	0.827316
Sum128Base_Range52_Impl	386.929	677.500	0.827299
Sum128AdvSimd_Range52	311.468	841.642	1.027733
Sum128AdvSimd_Range52_Impl	313.107	837.235	1.022353
Sum128Traits	132.311	1981.271	2.419340
Sum128Traits_Range52	124.399	2107.287	2.573220
Sum256Base_Basic	967.207	271.032	0.330959
Sum256Base	1133.565	231.256	0.282388
Sum256Base_Range52_Impl	1135.997	230.761	0.281784
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1133.880	231.192	0.282310
Sum256Traits_Range52	1133.496	231.270	0.282406

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
SumScalar	361.033	726.094
SumBcl	133.151	1968.765	2.711447
SumBase_Range52_Impl	329.266	796.147	1.096479
SumBase_Range52RoundToEven	147.657	1775.356	2.445078
SumTraits	124.956	2097.885	2.889275
SumTraits_Range52	125.083	2095.759	2.886347
SumTraits_Range52RoundToEven	124.937	2098.212	2.889726
Sum128Base_Basic	411.467	637.096	0.877429
Sum128Base	408.124	642.314	0.884616
Sum128Base_Range52_Impl	410.808	638.119	0.878838
Sum128AdvSimd_Range52	377.999	693.505	0.955118
Sum128AdvSimd_Range52_Impl	376.025	697.145	0.960131
Sum128Traits	133.295	1966.647	2.708530
Sum128Traits_Range52	133.342	1965.953	2.707574
Sum128Traits_Range52RoundToEven	133.230	1967.609	2.709855
Sum256Base_Basic	918.574	285.381	0.393037
Sum256Base	1069.527	245.103	0.337563
Sum256Base_Range52_Impl	1070.380	244.907	0.337295
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1070.046	244.984	0.337400
Sum256Traits_Range52	1069.625	245.080	0.337532
Sum256Traits_Range52RoundToEven	1070.700	244.834	0.337194

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
SumScalar	363.806	720.561
SumBcl	796.779	329.004	0.456595
SumBase_Range52_Impl	323.061	811.438	1.126121
SumBase_Range52RoundToEven	145.719	1798.968	2.496623
SumTraits	132.371	1980.370	2.748374
SumTraits_Range52	132.252	1982.163	2.750862
SumTraits_Range52RoundToEven	132.462	1979.011	2.746488
Sum128Base_Basic	389.469	673.080	0.934106
Sum128Base	393.146	666.786	0.925371
Sum128Base_Range52_Impl	392.872	667.251	0.926016
Sum128AdvSimd_Range52	348.515	752.175	1.043875
Sum128AdvSimd_Range52_Impl	347.769	753.788	1.046113
Sum128Traits	123.563	2121.549	2.944303
Sum128Traits_Range52	123.511	2122.427	2.945522
Sum128Traits_Range52RoundToEven	123.604	2120.841	2.943321
Sum256Base_Basic	910.031	288.061	0.399773
Sum256Base	1060.040	247.296	0.343200
Sum256Base_Range52_Impl	1061.657	246.920	0.342677
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1060.110	247.280	0.343177
Sum256Traits_Range52	1059.988	247.309	0.343217
Sum256Traits_Range52RoundToEven	1062.149	246.805	0.342518

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
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
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
SumScalar	282.155	929.077
SumBcl	106.245	2467.349	2.655700
SumBase_Range52_Impl	132.747	1974.764	2.125512
SumTraits	106.246	2467.322	2.655671
SumTraits_Range52	106.393	2463.927	2.652017
Sum128Bcl	106.283	2466.460	2.654743
Sum128Base_Basic	399.085	656.862	0.707005
Sum128Base	106.307	2465.924	2.654166
Sum128Base_Range52_Impl	133.592	1962.275	2.112070
Sum128AdvSimd_Range52	106.415	2463.413	2.651463
Sum128AdvSimd_Range52_Impl	250.137	1048.004	1.128005
Sum128Traits	106.233	2467.641	2.656014
Sum128Traits_Range52	106.327	2465.442	2.653647
Sum256Bcl	1190.085	220.273	0.237088
Sum256Base_Basic	1016.216	257.961	0.277653
Sum256Base	1192.486	219.830	0.236611
Sum256Base_Range52_Impl	2719.579	96.391	0.103750
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1190.150	220.261	0.237075
Sum256Traits_Range52	1371.121	191.190	0.205784

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
SumScalar	282.086	929.305
SumBcl	107.711	2433.772	2.618916
SumBase_Range52_Impl	134.619	1947.305	2.095441
SumTraits	107.705	2433.898	2.619051
SumTraits_Range52	107.754	2432.805	2.617876
Sum128Bcl	107.760	2432.654	2.617713
Sum128Base_Basic	413.921	633.318	0.681497
Sum128Base	107.773	2432.371	2.617409
Sum128Base_Range52_Impl	135.905	1928.872	2.075606
Sum128AdvSimd_Range52	107.874	2430.105	2.614970
Sum128AdvSimd_Range52_Impl	269.463	972.838	1.046844
Sum128Traits	107.909	2429.307	2.614111
Sum128Traits_Range52	107.909	2429.299	2.614103
Sum256Bcl	1176.071	222.898	0.239855
Sum256Base_Basic	1021.269	256.685	0.276211
Sum256Base	1172.076	223.658	0.240672
Sum256Base_Range52_Impl	2422.189	108.226	0.116459
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1173.013	223.479	0.240480
Sum256Traits_Range52	1380.906	189.835	0.204276

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
SumScalar	229.904	1140.234
SumBcl	106.289	2466.328	2.163001
SumBase_Range52_Impl	307.250	853.196	0.748263
SumBase_Range52RoundToEven	132.684	1975.704	1.732717
SumTraits	106.090	2470.958	2.167062
SumTraits_Range52	106.072	2471.373	2.167426
SumTraits_Range52RoundToEven	106.121	2470.237	2.166430
Sum128Bcl	106.128	2470.073	2.166286
Sum128Base_Basic	399.102	656.834	0.576052
Sum128Base	106.197	2468.469	2.164879
Sum128Base_Range52_Impl	240.455	1090.198	0.956118
Sum128AdvSimd_Range52	106.332	2465.324	2.162121
Sum128AdvSimd_Range52_Impl	317.303	826.162	0.724555
Sum128Traits	106.212	2468.112	2.164566
Sum128Traits_Range52	106.234	2467.615	2.164130
Sum128Traits_Range52RoundToEven	106.356	2464.781	2.161645
Sum256Bcl	958.200	273.580	0.239933
Sum256Base_Basic	1001.936	261.637	0.229459
Sum256Base	1122.970	233.438	0.204728
Sum256Base_Range52_Impl	5358.491	48.921	0.042905
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1121.924	233.656	0.204919
Sum256Traits_Range52	1327.020	197.543	0.173248
Sum256Traits_Range52RoundToEven	2453.739	106.835	0.093695

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
SumScalar	230.159	1138.967
SumBcl	107.924	2428.976	2.132614
SumBase_Range52_Impl	312.567	838.681	0.736353
SumBase_Range52RoundToEven	134.918	1942.985	1.705919
SumTraits	108.036	2426.452	2.130398
SumTraits_Range52	108.283	2420.905	2.125527
SumTraits_Range52RoundToEven	107.718	2433.607	2.136680
Sum128Bcl	107.937	2428.687	2.132360
Sum128Base_Basic	405.156	647.020	0.568076
Sum128Base	107.779	2432.233	2.135474
Sum128Base_Range52_Impl	264.515	991.037	0.870119
Sum128AdvSimd_Range52	107.806	2431.632	2.134946
Sum128AdvSimd_Range52_Impl	350.201	748.553	0.657221
Sum128Traits	107.762	2432.626	2.135819
Sum128Traits_Range52	108.015	2426.919	2.130808
Sum128Traits_Range52RoundToEven	107.939	2428.622	2.132303
Sum256Bcl	966.476	271.237	0.238143
Sum256Base_Basic	1015.604	258.116	0.226623
Sum256Base	1141.698	229.609	0.201594
Sum256Base_Range52_Impl	5035.887	52.055	0.045704
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1140.829	229.784	0.201748
Sum256Traits_Range52	1140.376	229.875	0.201828
Sum256Traits_Range52RoundToEven	2241.663	116.942	0.102674

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

