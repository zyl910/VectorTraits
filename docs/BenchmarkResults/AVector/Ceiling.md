# Benchmark - Ceiling
([← Back](README.md))
See [Group](Ceiling_Group.md)

- `Ceiling`: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: `MidpointRounding.ToPositiveInfinity`.
  Mnemonic: `rt[i] := ceiling(value[i])` .
- `Floor`: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: `MidpointRounding.ToNegativeInfinity`.
  Mnemonic: `rt[i] := floor(value[i])` .
- `YRoundToEven`: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: `MidpointRounding.ToEven`.
  Mnemonic: `rt[i] := round_to_even(value[i])` .
- `YRoundToZero`: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: `MidpointRounding.ToZero`.
  Mnemonic: `rt[i] := round_to_zero(value[i])` .

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9167.0
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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	632.141	414.692
SumBase	314.167	834.411	2.012121
SumBase_Basic	901.506	290.785	0.701206
SumBase_ClearBit	311.721	840.957	2.027908
SumTraits	314.982	832.251	2.006913

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	1323.553	198.061
SumBase	157.183	1667.763	8.420458
SumBase_Basic	1130.455	231.892	1.170814
SumBase_ClearBit	150.338	1743.695	8.803835
SumTraits	153.896	1703.384	8.600308

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	583.880	448.969
SumBase	314.141	834.480	1.858659
SumBase_Basic	884.298	296.443	0.660276
SumBase_ClearBit	313.595	835.931	1.861892
SumTraits	313.847	835.259	1.860396

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	1333.730	196.550
SumBase	156.083	1679.515	8.544994
SumBase_Basic	1185.638	221.100	1.124905
SumBase_ClearBit	190.990	1372.552	6.983238
SumTraits	221.434	1183.849	6.023157

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	2617.603	100.147
SumBase	162.815	1610.072	16.077153
SumBase_Add	148.801	1761.709	17.591305
SumTraits	156.105	1679.275	16.768174

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	2683.261	97.696
SumBase	73.326	3575.034	36.593439
SumBase_Add	77.203	3395.510	34.755859
SumTraits	75.776	3459.458	35.410413

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1492.762	175.610
SumBase	250.637	1045.910	5.955864
SumBase_ClearBit	238.955	1097.045	6.247049
SumTraits	245.391	1068.271	6.083199

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	2100.648	124.792
SumBase	122.256	2144.230	17.182432
SumBase_ClearBit	125.052	2096.284	16.798226
SumTraits	121.907	2150.368	17.231617

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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	934.376	280.555
SumBase	318.830	822.207	2.930643
SumBase_Basic	530.006	494.606	1.762953
SumBase_ClearBit	321.703	814.862	2.904463
SumTraits	325.333	805.772	2.872063

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	931.892	281.303
SumBase	156.759	1672.269	5.944727
SumBase_Basic	569.839	460.032	1.635361
SumBase_ClearBit	155.323	1687.738	5.999719
SumTraits	155.970	1680.734	5.974820

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	933.748	280.744
SumBase	320.998	816.653	2.908890
SumBase_Basic	530.082	494.535	1.761515
SumBase_ClearBit	304.056	862.157	3.070972
SumTraits	306.008	856.656	3.051379

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	931.448	281.437
SumBase	166.406	1575.332	5.597454
SumBase_Basic	575.493	455.512	1.618521
SumBase_ClearBit	167.942	1560.924	5.546262
SumTraits	169.261	1548.752	5.503011

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	934.335	280.567
SumBase	124.925	2098.419	7.479197
SumBase_Add	123.979	2114.424	7.536242
SumTraits	115.540	2268.855	8.086664

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	935.632	280.178
SumBase	53.463	4903.248	17.500450
SumBase_Add	56.667	4626.075	16.511178
SumTraits	55.835	4694.986	16.757130

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1286.728	203.729
SumBase	228.703	1146.221	5.626200
SumBase_ClearBit	230.307	1138.236	5.587008
SumTraits	229.441	1142.532	5.608093

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	1420.477	184.547
SumBase	123.541	2121.917	11.498005
SumBase_ClearBit	113.568	2308.252	12.507699
SumTraits	120.841	2169.330	11.754922

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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	933.458	280.831
SumBase	270.937	967.544	3.445289
SumBase_Basic	532.055	492.701	1.754440
SumBase_ClearBit	267.358	980.499	3.491417
SumTraits	80.489	3256.891	11.597331
Sum128Base_Basic	1643.566	159.497	0.567947
Sum128Base	1643.485	159.505	0.567975
Sum128Traits	1643.857	159.469	0.567846
Sum256Base_Basic	489.421	535.621	1.907271
Sum256Base	488.946	536.141	1.909124
Sum256Traits	80.279	3265.408	11.627656

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	934.660	280.470
SumBase	145.056	1807.195	6.443455
SumBase_Basic	334.303	784.150	2.795845
SumBase_ClearBit	138.159	1897.404	6.765093
SumTraits	40.309	6503.422	23.187598
Sum128Base_Basic	906.632	289.141	1.030915
Sum128Base	909.691	288.168	1.027448
Sum128Traits	907.090	288.995	1.030394
Sum256Base_Basic	299.159	876.270	3.124293
Sum256Base	298.744	877.487	3.128632
Sum256Traits	40.378	6492.313	23.147991

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	938.927	279.195
SumBase	268.431	976.579	3.497833
SumBase_Basic	532.821	491.993	1.762181
SumBase_ClearBit	267.628	979.510	3.508330
SumTraits	80.198	3268.709	11.707606
Sum128Base_Basic	1667.296	157.227	0.563143
Sum128Base	1643.581	159.496	0.571269
Sum128Traits	1645.830	159.278	0.570488
Sum256Base_Basic	490.725	534.198	1.913348
Sum256Base	491.093	533.798	1.911914
Sum256Traits	80.843	3242.621	11.614166

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	932.081	281.246
SumBase	136.926	1914.500	6.807211
SumBase_Basic	331.153	791.610	2.814654
SumBase_ClearBit	139.450	1879.837	6.683963
SumTraits	40.310	6503.210	23.122863
Sum128Base_Basic	899.933	291.293	1.035723
Sum128Base	899.487	291.437	1.036237
Sum128Traits	898.804	291.659	1.037024
Sum256Base_Basic	295.880	885.980	3.150198
Sum256Base	296.033	885.522	3.148569
Sum256Traits	39.305	6669.505	23.714144

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	932.532	281.110
SumBase	107.197	2445.436	8.699213
SumBase_Add	107.554	2437.314	8.670321
SumTraits	80.905	3240.163	11.526317
Sum128Base_Basic	1646.814	159.183	0.566264
Sum128Base	1636.526	160.183	0.569824
Sum128Traits	1635.887	160.246	0.570046
Sum256Base_Basic	488.987	536.096	1.907068
Sum256Base	489.933	535.061	1.903388
Sum256Traits	86.747	3021.949	10.750058

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1022.431	256.393
SumBase	78.472	3340.615	13.029287
SumBase_Add	73.266	3577.963	13.955008
SumTraits	52.260	5016.138	19.564274
Sum128Base_Basic	1048.624	249.989	0.975022
Sum128Base	1042.309	251.503	0.980930
Sum128Traits	1013.397	258.679	1.008915
Sum256Base_Basic	347.369	754.655	2.943354
Sum256Base	354.574	739.320	2.883547
Sum256Traits	47.369	5534.097	21.584450

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1463.240	179.153
SumBase	242.972	1078.904	6.022248
SumBase_ClearBit	228.445	1147.513	6.405207
SumTraits	84.064	3118.403	17.406358
Sum128Base_Basic	2416.851	108.465	0.605433
Sum128Base	2399.336	109.257	0.609852
Sum128Traits	2410.688	108.742	0.606980
Sum256Base_Basic	1499.481	174.823	0.975831
Sum256Base	1387.606	188.918	1.054507
Sum256Traits	80.337	3263.052	18.213764

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1490.408	175.887
SumBase	123.360	2125.035	12.081789
SumBase_ClearBit	122.977	2131.651	12.119406
SumTraits	41.055	6385.146	36.302452
Sum128Base_Basic	1725.909	151.888	0.863550
Sum128Base	1682.947	155.765	0.885594
Sum128Traits	1787.604	146.645	0.833746
Sum256Base_Basic	1360.560	192.674	1.095437
Sum256Base	1369.528	191.412	1.088264
Sum256Traits	40.276	6508.660	37.004686

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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	943.804	277.753
SumBcl	84.091	3117.382	11.223589
SumBase	83.455	3141.148	11.309152
SumBase_Basic	536.422	488.690	1.759442
SumBase_ClearBit	283.558	924.480	3.328428
SumTraits	83.635	3134.369	11.284746
Sum128Base_Basic	1642.212	159.629	0.574715
Sum128Base	1641.442	159.703	0.574984
Sum128Traits	1640.816	159.764	0.575204
Sum256Base_Basic	494.235	530.404	1.909626
Sum256Base	495.886	528.637	1.903266
Sum256Traits	84.864	3089.002	11.121410

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	935.391	280.251
SumBcl	39.416	6650.782	23.731550
SumBase	39.625	6615.676	23.606285
SumBase_Basic	353.368	741.845	2.647077
SumBase_ClearBit	136.376	1922.220	6.858933
SumTraits	40.876	6413.205	22.883821
Sum128Base_Basic	908.381	288.584	1.029734
Sum128Base	909.003	288.386	1.029030
Sum128Traits	909.429	288.251	1.028548
Sum256Base_Basic	299.642	874.857	3.121695
Sum256Base	298.674	877.693	3.131814
Sum256Traits	40.783	6427.764	22.935768

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	940.378	278.764
SumBcl	80.037	3275.285	11.749290
SumBase	80.099	3272.761	11.740236
SumBase_Basic	528.965	495.579	1.777771
SumBase_ClearBit	264.133	992.470	3.560247
SumTraits	80.975	3237.363	11.613253
Sum128Base_Basic	1636.190	160.216	0.574736
Sum128Base	1636.810	160.155	0.574519
Sum128Traits	1635.867	160.248	0.574850
Sum256Base_Basic	488.897	536.195	1.923469
Sum256Base	488.924	536.165	1.923361
Sum256Traits	80.111	3272.271	11.738477

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	932.293	281.182
SumBcl	39.414	6650.981	23.653652
SumBase	40.045	6546.216	23.281065
SumBase_Basic	332.087	789.384	2.807377
SumBase_ClearBit	124.906	2098.730	7.463957
SumTraits	39.471	6641.418	23.619641
Sum128Base_Basic	899.274	291.506	1.036717
Sum128Base	900.738	291.033	1.035033
Sum128Traits	898.942	291.614	1.037101
Sum256Base_Basic	296.488	884.165	3.144458
Sum256Base	296.221	884.961	3.147289
Sum256Traits	39.737	6596.996	23.461659

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	935.934	280.088
SumBase	104.481	2509.018	8.957958
SumBase_Add	107.717	2433.633	8.688810
SumTraits	81.440	3218.852	11.492279
Sum128Base_Basic	1634.469	160.385	0.572623
Sum128Base	1642.586	159.592	0.569793
Sum128Traits	1641.703	159.678	0.570099
Sum256Base_Basic	492.095	532.710	1.901937
Sum256Base	491.437	533.424	1.904484
Sum256Traits	80.404	3260.332	11.640374

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	934.649	280.473
SumBase	43.676	6001.979	21.399477
SumBase_Add	47.726	5492.692	19.583664
SumTraits	39.301	6670.229	23.782059
Sum128Base_Basic	897.024	292.237	1.041944
Sum128Base	897.161	292.193	1.041785
Sum128Traits	897.065	292.224	1.041896
Sum256Base_Basic	295.697	886.529	3.160834
Sum256Base	295.706	886.503	3.160743
Sum256Traits	39.284	6673.066	23.792174

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1323.877	198.012
SumBase	90.507	2896.409	14.627412
SumBase_ClearBit	183.713	1426.923	7.206232
SumTraits	81.216	3227.738	16.300688
Sum128Base_Basic	2399.936	109.230	0.551630
Sum128Base	2398.897	109.277	0.551869
Sum128Traits	2389.183	109.721	0.554113
Sum256Base_Basic	1397.650	187.560	0.947216
Sum256Base	1391.750	188.356	0.951232
Sum256Traits	80.169	3269.905	16.513639

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1343.407	195.134
SumBase	43.035	6091.413	31.216599
SumBase_ClearBit	91.859	2853.757	14.624618
SumTraits	39.604	6619.175	33.921214
Sum128Base_Basic	2256.487	116.174	0.595353
Sum128Base	2152.624	121.779	0.624079
Sum128Traits	1734.403	151.144	0.774564
Sum256Base_Basic	1465.240	178.909	0.916851
Sum256Base	1864.954	140.563	0.720343
Sum256Traits	39.830	6581.566	33.728481

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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	934.529	280.509
SumBcl	81.389	3220.868	11.482220
SumBase	83.579	3136.465	11.181330
SumBase_Basic	536.363	488.744	1.742345
SumBase_ClearBit	274.703	954.281	3.401959
SumTraits	86.148	3042.935	10.847900
Sum128Base_Basic	1657.587	158.148	0.563789
Sum128Base	1655.413	158.356	0.564529
Sum128Traits	1646.994	159.165	0.567415
Sum256Base_Basic	494.762	529.839	1.888846
Sum256Base	489.140	535.928	1.910554
Sum256Traits	80.281	3265.338	11.640754

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	932.473	281.128
SumBcl	39.707	6601.893	23.483618
SumBase	40.123	6533.543	23.240491
SumBase_Basic	331.131	791.662	2.816025
SumBase_ClearBit	145.344	1803.610	6.415630
SumTraits	39.298	6670.659	23.728226
Sum128Base_Basic	896.793	292.313	1.039787
Sum128Base	901.286	290.856	1.034604
Sum128Traits	900.877	290.987	1.035073
Sum256Base_Basic	295.878	885.988	3.151552
Sum256Base	295.895	885.936	3.151366
Sum256Traits	40.642	6450.030	22.943426

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	936.866	279.810
SumBcl	83.161	3152.259	11.265729
SumBase	82.015	3196.305	11.423142
SumBase_Basic	536.840	488.309	1.745149
SumBase_ClearBit	274.906	953.577	3.407949
SumTraits	82.625	3172.691	11.338750
Sum128Base_Basic	1651.478	158.733	0.567289
Sum128Base	1642.883	159.563	0.570257
Sum128Traits	1636.668	160.169	0.572423
Sum256Base_Basic	488.822	536.277	1.916580
Sum256Base	489.907	535.089	1.912333
Sum256Traits	80.452	3258.403	11.645074

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	931.280	281.488
SumBcl	39.272	6675.017	23.713340
SumBase	39.707	6601.888	23.453547
SumBase_Basic	331.542	790.681	2.808936
SumBase_ClearBit	145.489	1801.810	6.401024
SumTraits	39.526	6632.176	23.561146
Sum128Base_Basic	900.403	291.141	1.034293
Sum128Base	900.663	291.057	1.033994
Sum128Traits	901.421	290.812	1.033124
Sum256Base_Basic	296.822	883.170	3.137508
Sum256Base	296.723	883.464	3.138551
Sum256Traits	39.274	6674.671	23.712112

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	936.294	279.980
SumBase	100.933	2597.214	9.276410
SumBase_Add	104.758	2502.383	8.937705
SumTraits	80.165	3270.041	11.679532
Sum128Base_Basic	1636.541	160.182	0.572117
Sum128Base	1643.640	159.490	0.569647
Sum128Traits	1659.485	157.967	0.564207
Sum256Base_Basic	496.622	527.854	1.885325
Sum256Base	497.017	527.435	1.883826
Sum256Traits	82.838	3164.546	11.302738

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	941.246	278.507
SumBase	46.647	5619.719	20.177986
SumBase_Add	45.456	5767.035	20.706933
SumTraits	39.947	6562.255	23.562225
Sum128Base_Basic	900.899	290.980	1.044785
Sum128Base	900.599	291.078	1.045134
Sum128Traits	901.302	290.850	1.044318
Sum256Base_Basic	296.580	883.891	3.173669
Sum256Base	297.238	881.932	3.166636
Sum256Traits	39.508	6635.209	23.824172

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1291.019	203.052
SumBase	96.205	2724.860	13.419523
SumBase_ClearBit	210.138	1247.482	6.143662
SumTraits	83.785	3128.780	15.408765
Sum128Base_Basic	2422.777	108.200	0.532868
Sum128Base	3013.291	86.996	0.428442
Sum128Traits	2425.528	108.077	0.532263
Sum256Base_Basic	1393.762	188.084	0.926284
Sum256Base	1373.914	190.801	0.939666
Sum256Traits	80.552	3254.357	16.027216

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	2297.830	114.083
SumBase	45.373	5777.511	50.642931
SumBase_ClearBit	99.325	2639.250	23.134423
SumTraits	39.445	6645.737	58.253395
Sum128Base_Basic	1680.171	156.022	1.367617
Sum128Base	1690.101	155.106	1.359582
Sum128Traits	1664.345	157.506	1.380621
Sum256Base_Basic	1332.830	196.682	1.724023
Sum256Base	1336.819	196.095	1.718879
Sum256Traits	39.826	6582.179	57.696270

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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	936.105	280.037
SumBcl	82.253	3187.029	11.380747
SumBase	82.941	3160.596	11.286357
SumBase_Basic	534.193	490.729	1.752372
SumBase_ClearBit	266.031	985.390	3.518785
SumTraits	85.347	3071.513	10.968244
Sum128Bcl	158.517	1653.729	5.905396
Sum128Base_Basic	861.284	304.364	1.086872
Sum128Base	157.768	1661.578	5.933425
Sum128Traits	158.224	1656.789	5.916326
Sum256Bcl	82.552	3175.508	11.339608
Sum256Base_Basic	490.413	534.538	1.908812
Sum256Base	79.662	3290.693	11.750926
Sum256Traits	79.754	3286.909	11.737415

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	933.974	280.676
SumBcl	39.274	6674.753	23.781005
SumBase	39.255	6678.004	23.792588
SumBase_Basic	331.669	790.379	2.815984
SumBase_ClearBit	124.119	2112.031	7.524807
SumTraits	40.861	6415.496	22.857315
Sum128Bcl	78.357	3345.500	11.919444
Sum128Base_Basic	467.917	560.236	1.996026
Sum128Base	78.353	3345.689	11.920119
Sum128Traits	78.324	3346.906	11.924454
Sum256Bcl	39.332	6664.850	23.745723
Sum256Base_Basic	283.345	925.177	3.296247
Sum256Base	39.325	6666.065	23.750050
Sum256Traits	40.405	6487.916	23.115335

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	935.361	280.260
SumBcl	82.102	3192.895	11.392631
SumBase	82.497	3177.638	11.338190
SumBase_Basic	528.871	495.667	1.768599
SumBase_ClearBit	253.182	1035.397	3.694420
SumTraits	81.494	3216.709	11.477601
Sum128Bcl	158.199	1657.054	5.912566
Sum128Base_Basic	863.469	303.594	1.083260
Sum128Base	158.434	1654.592	5.903782
Sum128Traits	158.365	1655.319	5.906377
Sum256Bcl	81.335	3223.031	11.500160
Sum256Base_Basic	491.167	533.717	1.904365
Sum256Base	81.769	3205.900	11.439035
Sum256Traits	82.465	3178.860	11.342553

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	932.129	281.232
SumBcl	40.507	6471.640	23.011785
SumBase	40.746	6433.686	22.876830
SumBase_Basic	332.137	789.263	2.806454
SumBase_ClearBit	132.392	1980.059	7.040671
SumTraits	39.382	6656.386	23.668703
Sum128Bcl	78.400	3343.684	11.889434
Sum128Base_Basic	469.416	558.447	1.985720
Sum128Base	78.376	3344.712	11.893089
Sum128Traits	78.406	3343.436	11.888552
Sum256Bcl	40.587	6458.805	22.966145
Sum256Base_Basic	283.696	924.030	3.285656
Sum256Base	40.243	6514.009	23.162439
Sum256Traits	39.292	6671.728	23.723257

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	934.545	280.504
SumBase	97.642	2684.754	9.571168
SumBase_Add	97.603	2685.829	9.574998
SumTraits	79.974	3277.885	11.685685
Sum128Base_Basic	862.519	303.928	1.083507
Sum128Base	160.882	1629.413	5.808870
Sum128Traits	160.055	1637.832	5.838883
Sum256Base_Basic	491.426	533.435	1.901701
Sum256Base	109.103	2402.729	8.565745
Sum256Traits	82.584	3174.272	11.316301

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	932.204	281.209
SumBase	55.698	4706.556	16.736880
SumBase_Add	53.020	4944.285	17.582261
SumTraits	39.850	6578.304	23.392960
Sum128Base_Basic	469.297	558.589	1.986387
Sum128Base	80.412	3260.002	11.592820
Sum128Traits	80.036	3275.313	11.647267
Sum256Base_Basic	282.721	927.219	3.297263
Sum256Base	47.309	5541.105	19.704599
Sum256Traits	39.213	6685.203	23.773103

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	934.241	280.596
SumBase	89.550	2927.350	10.432621
SumBase_ClearBit	182.985	1432.600	5.105566
SumTraits	79.983	3277.488	11.680458
Sum128Base_Basic	864.505	303.230	1.080665
Sum128Base	161.331	1624.883	5.790831
Sum128Traits	160.646	1631.813	5.815528
Sum256Base_Basic	490.391	534.561	1.905094
Sum256Base	90.897	2883.971	10.278025
Sum256Traits	79.393	3301.851	11.767286

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	932.157	281.223
SumBase	44.291	5918.672	21.046178
SumBase_ClearBit	98.322	2666.170	9.480623
SumTraits	39.239	6680.642	23.755665
Sum128Base_Basic	468.200	559.897	1.990935
Sum128Base	84.292	3109.943	11.058634
Sum128Traits	84.351	3107.787	11.050966
Sum256Base_Basic	282.492	927.971	3.299768
Sum256Base	45.799	5723.801	20.353240
Sum256Traits	40.916	6406.911	22.782307

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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	315.653	830.483
SumBase	1422.575	184.274	0.221888
SumBase_Basic	548.375	478.038	0.575614
SumBase_ClearBit	1422.768	184.249	0.221858
SumTraits	1422.761	184.250	0.221859
Sum128Base_Basic	1145.994	228.748	0.275440
Sum128Base	1144.020	229.143	0.275915
Sum128Traits	1146.384	228.670	0.275346
Sum256Base_Basic	1679.034	156.128	0.187996
Sum256Base	1683.580	155.706	0.187489
Sum256Traits	1681.124	155.934	0.187763

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	316.583	828.043
SumBase	700.755	374.088	0.451774
SumBase_Basic	796.849	328.976	0.397293
SumBase_ClearBit	700.661	374.138	0.451834
SumTraits	700.964	373.977	0.451639
Sum128Base_Basic	1460.749	179.459	0.216726
Sum128Base	1460.238	179.521	0.216802
Sum128Traits	1460.249	179.520	0.216800
Sum256Base_Basic	1215.782	215.618	0.260394
Sum256Base	1233.138	212.583	0.256729
Sum256Traits	1233.685	212.489	0.256616

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.398	902.707
SumBase	1426.095	183.819	0.203631
SumBase_Basic	550.707	476.014	0.527319
SumBase_ClearBit	1422.578	184.274	0.204135
SumTraits	1424.985	183.963	0.203790
Sum128Base_Basic	1137.707	230.414	0.255248
Sum128Base	1146.198	228.707	0.253357
Sum128Traits	1157.998	226.377	0.250776
Sum256Base_Basic	1684.702	155.603	0.172373
Sum256Base	1690.628	155.057	0.171769
Sum256Traits	1691.462	154.981	0.171684

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	290.755	901.596
SumBase	708.631	369.930	0.410306
SumBase_Basic	797.147	328.853	0.364745
SumBase_ClearBit	709.191	369.638	0.409982
SumTraits	701.120	373.893	0.414701
Sum128Base_Basic	1459.894	179.564	0.199162
Sum128Base	1460.663	179.469	0.199057
Sum128Traits	1460.690	179.466	0.199054
Sum256Base_Basic	1235.863	212.114	0.235265
Sum256Base	1243.610	210.793	0.233800
Sum256Traits	1242.653	210.955	0.233980

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	290.601	902.076
SumBase	365.867	716.501	0.794280
SumBase_Add	362.497	723.162	0.801664
SumTraits	367.370	713.569	0.791029
Sum128Base_Basic	1159.446	226.094	0.250638
Sum128Base	1151.480	227.658	0.252371
Sum128Traits	1159.133	226.155	0.250705
Sum256Base_Basic	1691.484	154.979	0.171802
Sum256Base	1723.047	152.140	0.168655
Sum256Traits	1691.307	154.995	0.171820

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	316.064	829.401
SumBase	177.540	1476.531	1.780238
SumBase_Add	177.791	1474.446	1.777724
SumTraits	178.406	1469.371	1.771605
Sum128Base_Basic	1461.965	179.309	0.216191
Sum128Base	1460.571	179.480	0.216398
Sum128Traits	1461.085	179.417	0.216322
Sum256Base_Basic	1220.182	214.840	0.259030
Sum256Base	1238.400	211.680	0.255220
Sum256Traits	1238.702	211.628	0.255158

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1719.519	152.452
SumBase	1086.802	241.207	1.582183
SumBase_ClearBit	1086.048	241.374	1.583281
SumTraits	1086.989	241.165	1.581911
Sum128Base_Basic	2223.171	117.914	0.773453
Sum128Base	2196.363	119.354	0.782894
Sum128Traits	2215.005	118.349	0.776305
Sum256Base_Basic	3181.838	82.388	0.540417
Sum256Base	3178.997	82.461	0.540900
Sum256Traits	3220.737	81.393	0.533890

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	1750.442	149.759
SumBase	540.754	484.775	3.237041
SumBase_ClearBit	542.443	483.265	3.226960
SumTraits	541.447	484.155	3.232898
Sum128Base_Basic	2343.124	111.878	0.747055
Sum128Base	2315.035	113.235	0.756119
Sum128Traits	2363.975	110.891	0.740466
Sum256Base_Basic	2741.691	95.614	0.638454
Sum256Base	2680.163	97.809	0.653110
Sum256Traits	2701.544	97.035	0.647942

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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728653E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	290.479	902.454
SumBcl	133.280	1966.868	2.179466
SumBase	133.281	1966.857	2.179454
SumBase_Basic	558.827	469.097	0.519801
SumBase_ClearBit	1124.797	233.059	0.258250
SumTraits	127.359	2058.305	2.280787
Sum128Base_Basic	563.899	464.878	0.515126
Sum128Base	568.439	461.165	0.511012
Sum128Traits	133.318	1966.302	2.178839
Sum256Base_Basic	1091.148	240.246	0.266214
Sum256Base	1083.590	241.922	0.268071
Sum256Traits	1087.175	241.124	0.267187

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	321.173	816.207
SumBcl	63.593	4122.234	5.050474
SumBase	63.690	4115.931	5.042752
SumBase_Basic	810.074	323.605	0.396474
SumBase_ClearBit	517.460	506.597	0.620672
SumTraits	63.584	4122.810	5.051180
Sum128Base_Basic	842.235	311.248	0.381334
Sum128Base	839.028	312.438	0.382792
Sum128Traits	67.695	3872.441	4.744433
Sum256Base_Basic	891.957	293.898	0.360077
Sum256Base	928.570	282.309	0.345879
Sum256Traits	931.697	281.362	0.344719

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	323.717	809.794
SumBcl	134.764	1945.206	2.402100
SumBase	135.246	1938.282	2.393550
SumBase_Basic	562.670	465.893	0.575323
SumBase_ClearBit	1120.176	234.020	0.288987
SumTraits	134.637	1947.045	2.404371
Sum128Base_Basic	566.554	462.699	0.571379
Sum128Base	564.826	464.115	0.573127
Sum128Traits	126.582	2070.950	2.557379
Sum256Base_Basic	1088.267	240.882	0.297461
Sum256Base	1092.604	239.926	0.296280
Sum256Traits	1096.273	239.123	0.295289

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	295.743	886.392
SumBcl	68.264	3840.158	4.332348
SumBase	67.883	3861.680	4.356629
SumBase_Basic	810.580	323.403	0.364854
SumBase_ClearBit	519.877	504.243	0.568871
SumTraits	64.192	4083.758	4.607171
Sum128Base_Basic	844.307	310.484	0.350279
Sum128Base	846.706	309.605	0.349286
Sum128Traits	68.097	3849.560	4.342956
Sum256Base_Basic	898.526	291.749	0.329142
Sum256Base	928.062	282.464	0.318667
Sum256Traits	928.974	282.187	0.318354

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	321.008	816.628
SumBase	368.168	712.022	0.871906
SumBase_Add	368.227	711.908	0.871766
SumTraits	134.615	1947.359	2.384636
Sum128Base_Basic	567.555	461.883	0.565598
Sum128Base	566.696	462.583	0.566455
Sum128Traits	127.052	2063.281	2.526587
Sum256Base_Basic	1097.146	238.933	0.292585
Sum256Base	1090.191	240.457	0.294451
Sum256Traits	1088.849	240.753	0.294814

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	322.702	812.341
SumBase	179.659	1459.116	1.796186
SumBase_Add	180.816	1449.779	1.784692
SumTraits	63.783	4109.915	5.059345
Sum128Base_Basic	847.484	309.320	0.380776
Sum128Base	841.300	311.594	0.383575
Sum128Traits	68.673	3817.289	4.699120
Sum256Base_Basic	894.781	292.970	0.360649
Sum256Base	928.771	282.248	0.347450
Sum256Traits	927.443	282.652	0.347948

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1980.758	132.345
SumBase	260.152	1007.658	7.613853
SumBase_ClearBit	860.073	304.793	2.303012
SumTraits	127.615	2054.172	15.521304
Sum128Base_Basic	2086.304	125.650	0.949410
Sum128Base	2079.296	126.073	0.952610
Sum128Traits	135.994	1927.611	14.565015
Sum256Base_Basic	2533.367	103.477	0.781868
Sum256Base	2523.044	103.900	0.785067
Sum256Traits	2514.594	104.249	0.787705

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1916.223	136.802
SumBase	122.933	2132.416	15.587550
SumBase_ClearBit	394.397	664.670	4.858614
SumTraits	67.992	3855.517	28.183094
Sum128Base_Basic	2134.262	122.827	0.897839
Sum128Base	2126.379	123.282	0.901167
Sum128Traits	64.301	4076.856	29.801039
Sum256Base_Basic	2514.140	104.268	0.762178
Sum256Base	2443.563	107.279	0.784192
Sum256Traits	2467.944	106.220	0.776445

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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728653E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	291.509	899.267
SumBcl	133.528	1963.219	2.183134
SumBase	125.594	2087.232	2.321038
SumBase_Basic	554.194	473.018	0.526004
SumBase_ClearBit	996.305	263.116	0.292590
SumTraits	133.497	1963.663	2.183627
Sum128Base_Basic	558.987	468.963	0.521494
Sum128Base	555.752	471.692	0.524530
Sum128Traits	125.282	2092.432	2.326820
Sum256Base_Basic	1083.737	241.889	0.268985
Sum256Base	1073.681	244.154	0.271504
Sum256Traits	1074.440	243.982	0.271312

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	317.246	826.310
SumBcl	63.153	4150.914	5.023432
SumBase	67.140	3904.425	4.725132
SumBase_Basic	799.919	327.713	0.396598
SumBase_ClearBit	500.728	523.525	0.633570
SumTraits	67.078	3908.070	4.729542
Sum128Base_Basic	834.673	314.068	0.380085
Sum128Base	832.850	314.755	0.380917
Sum128Traits	62.974	4162.712	5.037710
Sum256Base_Basic	888.639	294.995	0.357002
Sum256Base	914.061	286.791	0.347074
Sum256Traits	914.935	286.517	0.346742

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.984	900.887
SumBcl	133.342	1965.948	2.182235
SumBase	124.986	2097.391	2.328139
SumBase_Basic	551.153	475.628	0.527955
SumBase_ClearBit	992.677	264.078	0.293131
SumTraits	124.996	2097.222	2.327951
Sum128Base_Basic	557.778	469.979	0.521685
Sum128Base	558.967	468.980	0.520575
Sum128Traits	133.329	1966.140	2.182448
Sum256Base_Basic	1083.354	241.974	0.268596
Sum256Base	1065.656	245.993	0.273056
Sum256Traits	1070.993	244.767	0.271696

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	316.873	827.284
SumBcl	66.782	3925.353	4.744868
SumBase	62.756	4177.225	5.049325
SumBase_Basic	798.307	328.375	0.396931
SumBase_ClearBit	499.575	524.734	0.634286
SumTraits	62.652	4184.139	5.057682
Sum128Base_Basic	833.983	314.328	0.379951
Sum128Base	832.603	314.849	0.380581
Sum128Traits	66.860	3920.771	4.739329
Sum256Base_Basic	893.417	293.417	0.354675
Sum256Base	916.658	285.978	0.345683
Sum256Traits	917.749	285.638	0.345272

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	316.267	828.869
SumBase	349.859	749.285	0.903985
SumBase_Add	350.115	748.736	0.903322
SumTraits	125.132	2094.944	2.527472
Sum128Base_Basic	559.519	468.516	0.565247
Sum128Base	566.988	462.345	0.557802
Sum128Traits	133.276	1966.932	2.373030
Sum256Base_Basic	1072.172	244.498	0.294978
Sum256Base	1067.358	245.601	0.296308
Sum256Traits	1067.247	245.626	0.296339

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	316.360	828.627
SumBase	211.901	1237.103	1.492956
SumBase_Add	211.967	1236.719	1.492492
SumTraits	66.816	3923.378	4.734795
Sum128Base_Basic	832.986	314.704	0.379790
Sum128Base	834.277	314.217	0.379202
Sum128Traits	62.670	4182.934	5.048031
Sum256Base_Basic	887.260	295.453	0.356558
Sum256Base	912.652	287.233	0.346638
Sum256Traits	912.926	287.147	0.346534

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1618.168	162.000
SumBase	239.222	1095.817	6.764286
SumBase_ClearBit	745.387	351.688	2.170909
SumTraits	133.352	1965.803	12.134550
Sum128Base_Basic	1678.058	156.219	0.964310
Sum128Base	1710.937	153.217	0.945779
Sum128Traits	125.102	2095.441	12.934783
Sum256Base_Basic	2133.447	122.873	0.758476
Sum256Base	2106.895	124.422	0.768035
Sum256Traits	2135.953	122.729	0.757586

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1652.680	158.617
SumBase	144.237	1817.457	11.458115
SumBase_ClearBit	379.606	690.569	4.353674
SumTraits	62.729	4179.016	26.346500
Sum128Base_Basic	1739.477	150.703	0.950102
Sum128Base	1695.407	154.620	0.974798
Sum128Traits	66.813	3923.523	24.735754
Sum256Base_Basic	2244.275	116.806	0.736398
Sum256Base	2192.608	119.558	0.753751
Sum256Traits	2183.715	120.045	0.756820

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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728653E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	211.033	1242.191
SumBcl	106.115	2470.381	1.988728
SumBase	107.159	2446.300	1.969342
SumBase_Basic	548.204	478.187	0.384954
SumBase_ClearBit	909.887	288.106	0.231934
SumTraits	106.602	2459.086	1.979635
Sum128Bcl	106.326	2465.481	1.984783
Sum128Base_Basic	554.453	472.798	0.380616
Sum128Base	106.262	2466.948	1.985964
Sum128Traits	106.325	2465.501	1.984799
Sum256Bcl	970.819	270.024	0.217377
Sum256Base_Basic	1152.626	227.432	0.183089
Sum256Base	1150.414	227.869	0.183441
Sum256Traits	1149.997	227.952	0.183508

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	210.923	1242.842
SumBcl	55.202	4748.790	3.820911
SumBase	55.126	4755.363	3.826199
SumBase_Basic	801.215	327.183	0.263254
SumBase_ClearBit	462.317	567.023	0.456230
SumTraits	55.273	4742.703	3.816013
Sum128Bcl	55.197	4749.266	3.821294
Sum128Base_Basic	805.510	325.439	0.261850
Sum128Base	55.184	4750.335	3.822154
Sum128Traits	55.209	4748.201	3.820436
Sum256Bcl	897.219	292.174	0.235085
Sum256Base_Basic	1012.619	258.877	0.208295
Sum256Base	936.461	279.930	0.225234
Sum256Traits	937.482	279.626	0.224989

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	210.649	1244.460
SumBcl	106.144	2469.708	1.984562
SumBase	106.291	2466.293	1.981818
SumBase_Basic	548.201	478.190	0.384255
SumBase_ClearBit	916.742	285.952	0.229780
SumTraits	106.345	2465.022	1.980797
Sum128Bcl	106.261	2466.984	1.982373
Sum128Base_Basic	555.591	471.829	0.379144
Sum128Base	106.113	2470.412	1.985128
Sum128Traits	106.177	2468.927	1.983935
Sum256Bcl	969.120	270.497	0.217361
Sum256Base_Basic	1150.570	227.838	0.183082
Sum256Base	1149.548	228.041	0.183245
Sum256Traits	1150.222	227.907	0.183138

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	210.925	1242.831
SumBcl	55.259	4743.879	3.816995
SumBase	55.142	4754.015	3.825151
SumBase_Basic	801.318	327.141	0.263222
SumBase_ClearBit	465.602	563.022	0.453016
SumTraits	55.162	4752.299	3.823770
Sum128Bcl	55.067	4760.494	3.830364
Sum128Base_Basic	805.795	325.323	0.261760
Sum128Base	55.086	4758.814	3.829012
Sum128Traits	55.445	4728.010	3.804227
Sum256Bcl	902.401	290.496	0.233738
Sum256Base_Basic	1009.446	259.691	0.208951
Sum256Base	935.817	280.123	0.225391
Sum256Traits	936.696	279.860	0.225180

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.671	1244.328
SumBase	418.309	626.675	0.503625
SumBase_Add	419.139	625.434	0.502628
SumTraits	106.146	2469.649	1.984725
Sum128Base_Basic	551.828	475.047	0.381770
Sum128Base	254.911	1028.375	0.826450
Sum128Traits	106.191	2468.619	1.983898
Sum256Base_Basic	1150.473	227.858	0.183117
Sum256Base	5642.994	46.455	0.037333
Sum256Traits	5642.532	46.459	0.037336

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	210.919	1242.864
SumBase	171.127	1531.870	1.232532
SumBase_Add	171.180	1531.396	1.232151
SumTraits	55.279	4742.209	3.815549
Sum128Base_Basic	805.889	325.286	0.261723
Sum128Base	141.301	1855.223	1.492700
Sum128Traits	55.219	4747.328	3.819668
Sum256Base_Basic	1009.494	259.679	0.208936
Sum256Base	4099.132	63.951	0.051455
Sum256Traits	4098.951	63.954	0.051457

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.880	1243.098
SumBase	271.793	964.497	0.775882
SumBase_ClearBit	693.045	378.250	0.304280
SumTraits	106.496	2461.529	1.980157
Sum128Base_Basic	558.839	469.087	0.377353
Sum128Base	162.532	1612.878	1.297466
Sum128Traits	106.499	2461.480	1.980117
Sum256Base_Basic	1155.632	226.840	0.182480
Sum256Base	3212.231	81.608	0.065649
Sum256Traits	3209.836	81.669	0.065698

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	210.962	1242.615
SumBase	114.434	2290.790	1.843524
SumBase_ClearBit	350.704	747.479	0.601537
SumTraits	55.080	4759.306	3.830073
Sum128Base_Basic	805.905	325.279	0.261770
Sum128Base	93.993	2788.983	2.244447
Sum128Traits	55.144	4753.799	3.825642
Sum256Base_Basic	1009.290	259.731	0.209020
Sum256Base	2250.093	116.504	0.093757
Sum256Traits	2243.723	116.834	0.094023

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

