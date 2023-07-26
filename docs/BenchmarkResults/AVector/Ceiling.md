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
SumScalar	627.297	417.895
SumBase	314.240	834.217	1.996237
SumBase_Basic	920.135	284.897	0.681744
SumBase_ClearBit	322.129	813.785	1.947345
SumTraits	325.868	804.450	1.925005

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	1324.491	197.921
SumBase	159.572	1642.791	8.300252
SumBase_Basic	1130.128	231.960	1.171983
SumBase_ClearBit	153.063	1712.651	8.653227
SumTraits	153.158	1711.593	8.647880

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	586.085	447.280
SumBase	325.968	804.201	1.797983
SumBase_Basic	905.217	289.592	0.647453
SumBase_ClearBit	313.965	834.945	1.866719
SumTraits	313.038	837.418	1.872247

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	1331.391	196.895
SumBase	154.610	1695.519	8.611291
SumBase_Basic	1114.190	235.278	1.194941
SumBase_ClearBit	164.484	1593.737	8.094358
SumTraits	153.853	1703.858	8.653644

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	2128.629	123.152
SumBase	124.528	2105.101	17.093579
SumBase_Add	125.008	2097.017	17.027938
SumTraits	124.171	2111.145	17.142657

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	2332.766	112.375
SumBase	57.979	4521.338	40.234472
SumBase_Add	63.907	4101.949	36.502416
SumTraits	59.431	4410.870	39.251436

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1403.463	186.784
SumBase	231.201	1133.835	6.070310
SumBase_ClearBit	240.438	1090.277	5.837110
SumTraits	227.777	1150.882	6.161573

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	2048.499	127.969
SumBase	117.408	2232.755	17.447652
SumBase_ClearBit	123.182	2128.099	16.629830
SumTraits	123.789	2117.666	16.548295

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
SumScalar	942.664	278.088
SumBase	321.057	816.503	2.936129
SumBase_Basic	539.421	485.972	1.747547
SumBase_ClearBit	303.318	864.255	3.107844
SumTraits	307.611	852.194	3.064471

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	932.588	281.093
SumBase	166.973	1569.983	5.585276
SumBase_Basic	572.002	458.292	1.630393
SumBase_ClearBit	163.522	1603.109	5.703123
SumTraits	156.383	1676.296	5.963490

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	933.969	280.677
SumBase	321.177	816.199	2.907961
SumBase_Basic	530.587	494.064	1.760256
SumBase_ClearBit	309.221	847.757	3.020399
SumTraits	321.828	814.547	2.902076

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	932.860	281.011
SumBase	157.017	1669.531	5.941155
SumBase_Basic	571.751	458.493	1.631583
SumBase_ClearBit	156.552	1674.487	5.958790
SumTraits	166.706	1572.495	5.595847

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	935.362	280.259
SumBase	120.020	2184.177	7.793416
SumBase_Add	133.069	1969.991	7.029171
SumTraits	117.760	2226.096	7.942986

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	932.410	281.147
SumBase	60.689	4319.431	15.363613
SumBase_Add	54.722	4790.492	17.039108
SumTraits	55.169	4751.639	16.900914

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1266.559	206.973
SumBase	232.279	1128.572	5.452741
SumBase_ClearBit	231.400	1132.861	5.473461
SumTraits	231.400	1132.862	5.473470

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	1455.427	180.115
SumBase	116.315	2253.742	12.512809
SumBase_ClearBit	118.925	2204.280	12.238197
SumTraits	119.940	2185.623	12.134609

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
SumScalar	934.713	280.454
SumBase	292.372	896.612	3.197000
SumBase_Basic	531.187	493.506	1.759668
SumBase_ClearBit	288.687	908.057	3.237810
SumTraits	84.797	3091.432	11.022949
Sum128Base_Basic	1648.839	158.987	0.566891
Sum128Base	1643.666	159.487	0.568675
Sum128Traits	1641.646	159.684	0.569375
Sum256Base_Basic	489.539	535.491	1.909372
Sum256Base	489.123	535.947	1.910999
Sum256Traits	81.247	3226.517	11.504614

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	935.307	280.276
SumBase	143.512	1826.638	6.517285
SumBase_Basic	331.444	790.915	2.821914
SumBase_ClearBit	142.979	1833.438	6.541546
SumTraits	39.960	6560.096	23.405853
Sum128Base_Basic	899.282	291.504	1.040060
Sum128Base	904.568	289.800	1.033982
Sum128Traits	903.950	289.998	1.034689
Sum256Base_Basic	296.757	883.363	3.151763
Sum256Base	296.807	883.213	3.151226
Sum256Traits	39.607	6618.632	23.614701

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	936.681	279.865
SumBase	268.012	978.104	3.494916
SumBase_Basic	531.610	493.114	1.761971
SumBase_ClearBit	281.020	932.832	3.333149
SumTraits	80.830	3243.152	11.588278
Sum128Base_Basic	1642.397	159.611	0.570313
Sum128Base	1642.370	159.613	0.570322
Sum128Traits	1639.552	159.888	0.571303
Sum256Base_Basic	495.132	529.443	1.891781
Sum256Base	498.737	525.616	1.878105
Sum256Traits	83.441	3141.673	11.225678

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	940.322	278.781
SumBase	141.149	1857.212	6.661903
SumBase_Basic	335.047	782.409	2.806536
SumBase_ClearBit	143.802	1822.954	6.539021
SumTraits	40.051	6545.273	23.478191
Sum128Base_Basic	940.468	278.738	0.999845
Sum128Base	904.560	289.803	1.039535
Sum128Traits	903.618	290.105	1.040620
Sum256Base_Basic	297.483	881.205	3.160923
Sum256Base	297.367	881.550	3.162158
Sum256Traits	39.302	6670.002	23.925601

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	936.179	280.015
SumBase	103.295	2537.818	9.063154
SumBase_Add	102.344	2561.394	9.147350
SumTraits	80.088	3273.215	11.689431
Sum128Base_Basic	1637.778	160.061	0.571615
Sum128Base	1640.657	159.780	0.570612
Sum128Traits	1638.589	159.982	0.571332
Sum256Base_Basic	491.001	533.897	1.906674
Sum256Base	491.355	533.512	1.905300
Sum256Traits	79.842	3283.300	11.725448

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	932.495	281.121
SumBase	52.981	4947.858	17.600448
SumBase_Add	49.348	5312.123	18.896206
SumTraits	39.596	6620.438	23.550125
Sum128Base_Basic	906.527	289.174	1.028645
Sum128Base	899.130	291.553	1.037107
Sum128Traits	901.175	290.891	1.034755
Sum256Base_Basic	295.925	885.846	3.151119
Sum256Base	296.700	883.533	3.142889
Sum256Traits	39.495	6637.386	23.610413

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1265.553	207.138
SumBase	215.571	1216.044	5.870699
SumBase_ClearBit	217.515	1205.178	5.818238
SumTraits	80.231	3267.384	15.773952
Sum128Base_Basic	2393.628	109.517	0.528717
Sum128Base	2399.292	109.259	0.527469
Sum128Traits	2386.873	109.827	0.530214
Sum256Base_Basic	1382.268	189.648	0.915563
Sum256Base	1401.605	187.031	0.902931
Sum256Traits	80.069	3273.959	15.805696

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1273.146	205.903
SumBase	119.653	2190.860	10.640275
SumBase_ClearBit	111.757	2345.651	11.392043
SumTraits	39.413	6651.257	32.302931
Sum128Base_Basic	1679.289	156.104	0.758146
Sum128Base	1659.703	157.946	0.767093
Sum128Traits	1676.121	156.399	0.759579
Sum256Base_Basic	1409.860	185.936	0.903030
Sum256Base	1419.118	184.723	0.897138
Sum256Traits	40.132	6532.025	31.723858

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
SumScalar	935.978	280.075
SumBcl	80.255	3266.388	11.662545
SumBase	80.796	3244.511	11.584433
SumBase_Basic	528.695	495.832	1.770354
SumBase_ClearBit	262.183	999.851	3.569940
SumTraits	80.349	3262.566	11.648900
Sum128Base_Basic	1638.937	159.948	0.571088
Sum128Base	1637.264	160.111	0.571672
Sum128Traits	1636.023	160.232	0.572105
Sum256Base_Basic	489.022	536.057	1.913977
Sum256Base	489.373	535.674	1.912607
Sum256Traits	79.662	3290.702	11.749357

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	931.343	281.469
SumBcl	39.239	6680.740	23.735288
SumBase	39.290	6671.956	23.704082
SumBase_Basic	331.562	790.634	2.808960
SumBase_ClearBit	133.264	1967.098	6.988693
SumTraits	39.229	6682.335	23.740958
Sum128Base_Basic	899.625	291.392	1.035257
Sum128Base	899.207	291.528	1.035739
Sum128Traits	900.025	291.263	1.034798
Sum256Base_Basic	296.544	883.997	3.140659
Sum256Base	297.756	880.399	3.127875
Sum256Traits	39.404	6652.748	23.635838

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	932.755	281.043
SumBcl	79.526	3296.341	11.728970
SumBase	79.786	3285.578	11.690673
SumBase_Basic	528.779	495.753	1.763978
SumBase_ClearBit	268.187	977.467	3.478002
SumTraits	80.545	3254.634	11.580571
Sum128Base_Basic	1640.132	159.831	0.568707
Sum128Base	1637.489	160.089	0.569625
Sum128Traits	1635.176	160.315	0.570431
Sum256Base_Basic	489.769	535.240	1.904480
Sum256Base	490.703	534.221	1.900854
Sum256Traits	79.836	3283.540	11.683422

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	934.814	280.424
SumBcl	40.138	6531.098	23.290106
SumBase	40.072	6541.801	23.328274
SumBase_Basic	336.506	779.018	2.778003
SumBase_ClearBit	125.806	2083.724	7.430626
SumTraits	39.980	6556.881	23.382048
Sum128Base_Basic	910.961	287.766	1.026184
Sum128Base	913.526	286.958	1.023303
Sum128Traits	909.760	288.146	1.027539
Sum256Base_Basic	296.540	884.010	3.152408
Sum256Base	296.988	882.674	3.147644
Sum256Traits	39.416	6650.729	23.716714

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	933.977	280.675
SumBase	102.861	2548.521	9.079975
SumBase_Add	99.881	2624.556	9.350876
SumTraits	79.829	3283.806	11.699677
Sum128Base_Basic	1637.591	160.079	0.570336
Sum128Base	1645.575	159.302	0.567569
Sum128Traits	1644.312	159.425	0.568005
Sum256Base_Basic	492.294	532.495	1.897194
Sum256Base	491.022	533.874	1.902109
Sum256Traits	81.684	3209.232	11.433982

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	934.430	280.539
SumBase	47.481	5521.087	19.680281
SumBase_Add	48.488	5406.321	19.271190
SumTraits	39.434	6647.653	23.696000
Sum128Base_Basic	899.537	291.421	1.038790
Sum128Base	898.945	291.613	1.039473
Sum128Traits	899.757	291.350	1.038535
Sum256Base_Basic	295.903	885.911	3.157890
Sum256Base	295.886	885.963	3.158072
Sum256Traits	39.265	6676.243	23.797909

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1267.883	206.757
SumBase	94.654	2769.496	13.394912
SumBase_ClearBit	185.080	1416.382	6.850456
SumTraits	80.121	3271.842	15.824551
Sum128Base_Basic	2391.588	109.611	0.530143
Sum128Base	2400.706	109.195	0.528129
Sum128Traits	3081.724	85.064	0.411420
Sum256Base_Basic	2591.836	101.142	0.489183
Sum256Base	1436.210	182.525	0.882798
Sum256Traits	80.247	3266.719	15.799778

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1251.768	209.419
SumBase	43.491	6027.605	28.782519
SumBase_ClearBit	94.054	2787.153	13.308982
SumTraits	39.288	6672.350	31.861251
Sum128Base_Basic	1648.800	158.991	0.759200
Sum128Base	1651.391	158.741	0.758008
Sum128Traits	1664.035	157.535	0.752249
Sum256Base_Basic	1320.240	198.558	0.948137
Sum256Base	1305.918	200.735	0.958535
Sum256Traits	39.250	6678.795	31.892025

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
SumScalar	934.285	280.583
SumBcl	80.103	3272.593	11.663565
SumBase	80.289	3264.993	11.636479
SumBase_Basic	1928.711	135.917	0.484409
SumBase_ClearBit	274.156	956.186	3.407860
SumTraits	80.015	3276.169	11.676311
Sum128Base_Basic	1643.464	159.507	0.568485
Sum128Base	1642.275	159.622	0.568897
Sum128Traits	1641.752	159.673	0.569078
Sum256Base_Basic	1888.740	138.793	0.494660
Sum256Base	1888.801	138.789	0.494644
Sum256Traits	80.017	3276.113	11.676111

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	933.254	280.893
SumBcl	39.144	6696.955	23.841696
SumBase	39.206	6686.363	23.803988
SumBase_Basic	1032.089	253.994	0.904237
SumBase_ClearBit	140.399	1867.142	6.647176
SumTraits	39.314	6667.881	23.738188
Sum128Base_Basic	901.938	290.645	1.034720
Sum128Base	903.287	290.211	1.033175
Sum128Traits	901.615	290.749	1.035091
Sum256Base_Basic	1020.679	256.833	0.914346
Sum256Base	1020.543	256.867	0.914467
Sum256Traits	39.221	6683.710	23.794542

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	933.458	280.831
SumBcl	79.860	3282.552	11.688705
SumBase	80.185	3269.227	11.641254
SumBase_Basic	1930.079	135.820	0.483637
SumBase_ClearBit	265.250	988.289	3.519157
SumTraits	80.385	3261.104	11.612329
Sum128Base_Basic	1638.588	159.982	0.569672
Sum128Base	1636.971	160.140	0.570235
Sum128Traits	1636.167	160.218	0.570515
Sum256Base_Basic	489.176	535.889	1.908226
Sum256Base	491.831	532.996	1.897925
Sum256Traits	80.072	3273.834	11.657660

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	936.585	279.893
SumBcl	39.313	6668.184	23.824012
SumBase	39.342	6663.187	23.806160
SumBase_Basic	331.548	790.666	2.824882
SumBase_ClearBit	137.049	1912.782	6.833965
SumTraits	39.557	6626.923	23.676595
Sum128Base_Basic	899.260	291.511	1.041506
Sum128Base	900.300	291.174	1.040303
Sum128Traits	899.967	291.282	1.040689
Sum256Base_Basic	296.499	884.132	3.158818
Sum256Base	299.048	876.596	3.131891
Sum256Traits	39.735	6597.250	23.570582

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	942.720	278.072
SumBase	104.050	2519.403	9.060256
SumBase_Add	103.336	2536.804	9.122831
SumTraits	82.281	3185.973	11.457367
Sum128Base_Basic	1647.690	159.098	0.572146
Sum128Base	1651.683	158.713	0.570763
Sum128Traits	1645.395	159.320	0.572944
Sum256Base_Basic	491.379	533.486	1.918519
Sum256Base	489.792	535.215	1.924735
Sum256Traits	79.602	3293.164	11.842846

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	932.427	281.142
SumBase	44.748	5858.236	20.837312
SumBase_Add	44.353	5910.466	21.023092
SumTraits	39.383	6656.310	23.676001
Sum128Base_Basic	900.745	291.030	1.035173
Sum128Base	899.853	291.319	1.036199
Sum128Traits	899.843	291.322	1.036211
Sum256Base_Basic	296.330	884.636	3.146586
Sum256Base	295.956	885.752	3.150556
Sum256Traits	39.270	6675.423	23.743984

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	2603.818	100.677
SumBase	90.127	2908.619	28.890665
SumBase_ClearBit	203.020	1291.222	12.825420
SumTraits	79.789	3285.474	32.633880
Sum128Base_Basic	2393.624	109.518	1.087814
Sum128Base	2389.994	109.684	1.089467
Sum128Traits	2389.812	109.692	1.089549
Sum256Base_Basic	1460.110	179.537	1.783303
Sum256Base	1422.314	184.308	1.830692
Sum256Traits	80.293	3264.846	32.428996

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1331.309	196.907
SumBase	46.110	5685.133	28.872189
SumBase_ClearBit	99.158	2643.687	13.426078
SumTraits	39.265	6676.272	33.905729
Sum128Base_Basic	2843.347	92.196	0.468219
Sum128Base	2248.646	116.579	0.592049
Sum128Traits	1652.424	158.642	0.805671
Sum256Base_Basic	2595.522	100.999	0.512925
Sum256Base	1884.376	139.114	0.706499
Sum256Traits	39.466	6642.262	33.733009

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
SumScalar	936.444	279.935
SumBcl	80.299	3264.591	11.661940
SumBase	79.776	3286.006	11.738442
SumBase_Basic	530.775	493.889	1.764297
SumBase_ClearBit	261.243	1003.449	3.584573
SumTraits	84.844	3089.729	11.037291
Sum128Bcl	166.162	1577.645	5.635746
Sum128Base_Basic	864.439	303.253	1.083297
Sum128Base	160.367	1634.648	5.839373
Sum128Traits	161.178	1626.430	5.810017
Sum256Bcl	90.091	2909.770	10.394430
Sum256Base_Basic	517.217	506.836	1.810546
Sum256Base	91.105	2877.397	10.278787
Sum256Traits	85.274	3074.129	10.981564

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
SumScalar	932.272	281.188
SumBcl	39.651	6611.335	23.512133
SumBase	39.419	6650.190	23.650316
SumBase_Basic	343.655	762.811	2.712811
SumBase_ClearBit	125.867	2082.699	7.406781
SumTraits	43.489	6027.883	21.437181
Sum128Bcl	79.172	3311.088	11.775345
Sum128Base_Basic	469.386	558.483	1.986155
Sum128Base	78.269	3349.274	11.911147
Sum128Traits	78.123	3355.530	11.933394
Sum256Bcl	40.107	6536.163	23.244797
Sum256Base_Basic	344.134	761.750	2.709039
Sum256Base	41.511	6315.026	22.458360
Sum256Traits	41.669	6291.113	22.373317

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
SumScalar	934.347	280.564
SumBcl	81.233	3227.064	11.502063
SumBase	80.919	3239.587	11.546699
SumBase_Basic	551.552	475.284	1.694031
SumBase_ClearBit	269.372	973.169	3.468616
SumTraits	82.109	3192.639	11.379362
Sum128Bcl	157.767	1661.589	5.922319
Sum128Base_Basic	861.115	304.424	1.085043
Sum128Base	157.994	1659.206	5.913825
Sum128Traits	158.258	1656.437	5.903955
Sum256Bcl	80.107	3272.428	11.663750
Sum256Base_Basic	558.187	469.635	1.673896
Sum256Base	80.836	3242.904	11.558520
Sum256Traits	79.938	3279.329	11.688348

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
SumScalar	935.769	280.137
SumBcl	39.453	6644.415	23.718413
SumBase	39.293	6671.589	23.815416
SumBase_Basic	341.688	767.203	2.738666
SumBase_ClearBit	129.862	2018.639	7.205889
SumTraits	39.861	6576.504	23.475993
Sum128Bcl	78.277	3348.947	11.954658
Sum128Base_Basic	469.214	558.688	1.994335
Sum128Base	78.182	3353.001	11.969128
Sum128Traits	78.603	3335.051	11.905055
Sum256Bcl	39.981	6556.680	23.405227
Sum256Base_Basic	319.598	820.231	2.927959
Sum256Base	39.802	6586.200	23.510603
Sum256Traits	40.199	6521.154	23.278410

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	940.915	278.606
SumBase	99.709	2629.086	9.436589
SumBase_Add	106.829	2453.873	8.807698
SumTraits	81.677	3209.523	11.519955
Sum128Base_Basic	860.283	304.718	1.093727
Sum128Base	172.749	1517.483	5.446707
Sum128Traits	174.719	1500.376	5.385307
Sum256Base_Basic	562.544	465.997	1.672606
Sum256Base	104.280	2513.851	9.022974
Sum256Traits	81.799	3204.751	11.502827

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	941.435	278.452
SumBase	51.711	5069.403	18.205685
SumBase_Add	52.644	4979.590	17.883139
SumTraits	41.004	6393.090	22.959425
Sum128Base_Basic	468.467	559.578	2.009607
Sum128Base	85.387	3070.074	11.025520
Sum128Traits	85.413	3069.133	11.022141
Sum256Base_Basic	318.404	823.306	2.956728
Sum256Base	52.036	5037.753	18.092020
Sum256Traits	40.062	6543.418	23.499296

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	933.262	280.890
SumBase	96.065	2728.809	9.714861
SumBase_ClearBit	182.565	1435.897	5.111950
SumTraits	80.027	3275.713	11.661900
Sum128Base_Basic	859.844	304.874	1.085385
Sum128Base	168.163	1558.869	5.549745
Sum128Traits	172.148	1522.786	5.421286
Sum256Base_Basic	558.886	469.047	1.669861
Sum256Base	88.390	2965.754	10.558412
Sum256Traits	80.275	3265.585	11.625843

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	937.724	279.553
SumBase	44.593	5878.646	21.028700
SumBase_ClearBit	99.038	2646.912	9.468356
SumTraits	40.088	6539.243	23.391742
Sum128Base_Basic	467.860	560.305	2.004285
Sum128Base	84.367	3107.175	11.114777
Sum128Traits	84.631	3097.481	11.080103
Sum256Base_Basic	318.770	822.361	2.941696
Sum256Base	43.473	6029.981	21.570044
Sum256Traits	39.424	6649.430	23.785895

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
SumScalar	316.057	829.419
SumBase	541.020	484.537	0.584189
SumBase_Basic	1215.095	215.740	0.260109
SumBase_ClearBit	1425.671	183.874	0.221690
SumTraits	546.973	479.263	0.577831
Sum128Base_Basic	1138.921	230.169	0.277506
Sum128Base	1133.716	231.225	0.278780
Sum128Traits	1136.889	230.580	0.278002
Sum256Base_Basic	1804.758	145.252	0.175125
Sum256Base	1799.196	145.701	0.175666
Sum256Traits	1792.636	146.234	0.176309

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	290.349	902.859
SumBase	700.701	374.117	0.414369
SumBase_Basic	796.042	329.309	0.364740
SumBase_ClearBit	709.001	369.737	0.409518
SumTraits	700.664	374.136	0.414391
Sum128Base_Basic	1458.275	179.763	0.199104
Sum128Base	1458.607	179.722	0.199059
Sum128Traits	1458.708	179.710	0.199045
Sum256Base_Basic	1303.229	201.150	0.222792
Sum256Base	1335.607	196.273	0.217391
Sum256Traits	1335.629	196.270	0.217387

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.581	902.139
SumBase	546.810	479.406	0.531411
SumBase_Basic	547.633	478.686	0.530612
SumBase_ClearBit	1421.880	184.364	0.204364
SumTraits	547.291	478.985	0.530944
Sum128Base_Basic	1140.325	229.885	0.254823
Sum128Base	1148.239	228.301	0.253066
Sum128Traits	1135.941	230.773	0.255806
Sum256Base_Basic	1825.191	143.626	0.159206
Sum256Base	1821.136	143.945	0.159560
Sum256Traits	1818.129	144.183	0.159824

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	316.582	828.044
SumBase	701.117	373.895	0.451540
SumBase_Basic	796.732	329.024	0.397351
SumBase_ClearBit	700.630	374.155	0.451854
SumTraits	703.925	372.403	0.449739
Sum128Base_Basic	1460.169	179.530	0.216812
Sum128Base	1459.918	179.561	0.216849
Sum128Traits	1475.751	177.634	0.214523
Sum256Base_Basic	1303.560	201.098	0.242860
Sum256Base	1336.932	196.079	0.236798
Sum256Traits	1336.917	196.081	0.236800

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	290.302	903.004
SumBase	365.203	717.804	0.794907
SumBase_Add	364.276	719.631	0.796929
SumTraits	366.807	714.664	0.791430
Sum128Base_Basic	1141.575	229.634	0.254300
Sum128Base	1144.527	229.041	0.253644
Sum128Traits	1140.253	229.900	0.254594
Sum256Base_Basic	1815.847	144.365	0.159871
Sum256Base	1818.389	144.163	0.159648
Sum256Traits	1819.528	144.073	0.159548

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	290.567	902.180
SumBase	177.538	1476.550	1.636647
SumBase_Add	177.239	1479.040	1.639407
SumTraits	178.685	1467.071	1.626140
Sum128Base_Basic	1458.441	179.743	0.199231
Sum128Base	1459.234	179.645	0.199123
Sum128Traits	1459.211	179.648	0.199126
Sum256Base_Basic	1305.755	200.760	0.222528
Sum256Base	1336.099	196.201	0.217474
Sum256Traits	1337.254	196.032	0.217287

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1612.695	162.550
SumBase	1086.684	241.233	1.484052
SumBase_ClearBit	1087.061	241.149	1.483537
SumTraits	1087.795	240.987	1.482536
Sum128Base_Basic	2214.360	118.384	0.728289
Sum128Base	2226.096	117.760	0.724450
Sum128Traits	2222.592	117.945	0.725592
Sum256Base_Basic	3234.886	81.037	0.498532
Sum256Base	3335.870	78.583	0.483440
Sum256Traits	3314.923	79.080	0.486495

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	1653.182	158.569
SumBase	541.175	484.398	3.054802
SumBase_ClearBit	541.645	483.978	3.052151
SumTraits	540.636	484.881	3.057848
Sum128Base_Basic	2384.810	109.922	0.693213
Sum128Base	2468.881	106.179	0.669608
Sum128Traits	2300.215	113.965	0.718708
Sum256Base_Basic	2840.105	92.301	0.582085
Sum256Base	2765.626	94.786	0.597760
Sum256Traits	2755.451	95.137	0.599968

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
SumScalar	316.145	829.190
SumBcl	125.195	2093.883	2.525214
SumBase	124.945	2098.081	2.530276
SumBase_Basic	551.448	475.374	0.573299
SumBase_ClearBit	1103.907	237.469	0.286387
SumTraits	133.208	1967.932	2.373318
Sum128Base_Basic	557.785	469.973	0.566785
Sum128Base	554.973	472.354	0.569657
Sum128Traits	125.991	2080.660	2.509267
Sum256Base_Basic	1219.325	214.991	0.259278
Sum256Base	1223.971	214.175	0.258294
Sum256Traits	1223.698	214.223	0.258352

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	316.859	827.319
SumBcl	62.888	4168.448	5.038499
SumBase	62.835	4171.968	5.042754
SumBase_Basic	798.929	328.119	0.396605
SumBase_ClearBit	513.932	510.076	0.616540
SumTraits	62.901	4167.573	5.037441
Sum128Base_Basic	833.871	314.370	0.379986
Sum128Base	832.761	314.789	0.380493
Sum128Traits	66.951	3915.472	4.732721
Sum256Base_Basic	965.551	271.497	0.328165
Sum256Base	993.041	263.981	0.319080
Sum256Traits	991.144	264.486	0.319691

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.327	902.926
SumBcl	124.949	2098.000	2.323556
SumBase	125.068	2096.010	2.321351
SumBase_Basic	551.360	475.450	0.526566
SumBase_ClearBit	1102.512	237.770	0.263332
SumTraits	125.160	2094.466	2.319642
Sum128Base_Basic	557.448	470.257	0.520814
Sum128Base	554.794	472.507	0.523306
Sum128Traits	133.311	1966.409	2.177818
Sum256Base_Basic	1226.882	213.667	0.236638
Sum256Base	1228.651	213.359	0.236297
Sum256Traits	1220.477	214.788	0.237880

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	290.877	901.220
SumBcl	66.880	3919.618	4.349235
SumBase	66.976	3914.011	4.343013
SumBase_Basic	799.164	328.023	0.363976
SumBase_ClearBit	514.634	509.379	0.565210
SumTraits	67.296	3895.362	4.322321
Sum128Base_Basic	832.364	314.939	0.349459
Sum128Base	833.992	314.324	0.348776
Sum128Traits	62.820	4172.969	4.630356
Sum256Base_Basic	964.200	271.877	0.301677
Sum256Base	986.268	265.794	0.294927
Sum256Traits	991.969	264.266	0.293232

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	290.395	902.715
SumBase	364.564	719.061	0.796554
SumBase_Add	363.240	721.682	0.799457
SumTraits	125.116	2095.209	2.321007
Sum128Base_Basic	556.429	471.118	0.521890
Sum128Base	558.140	469.674	0.520291
Sum128Traits	133.178	1968.378	2.180508
Sum256Base_Basic	1224.943	214.005	0.237068
Sum256Base	1219.999	214.872	0.238029
Sum256Traits	1220.052	214.863	0.238019

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	316.396	828.533
SumBase	178.834	1465.853	1.769215
SumBase_Add	177.812	1474.276	1.779382
SumTraits	62.854	4170.679	5.033814
Sum128Base_Basic	832.505	314.886	0.380052
Sum128Base	832.089	315.043	0.380242
Sum128Traits	67.132	3904.895	4.713025
Sum256Base_Basic	961.709	272.582	0.328993
Sum256Base	993.692	263.808	0.318404
Sum256Traits	991.238	264.461	0.319192

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1869.261	140.239
SumBase	243.150	1078.117	7.687696
SumBase_ClearBit	840.599	311.854	2.223726
SumTraits	133.488	1963.798	14.003188
Sum128Base_Basic	2056.814	127.451	0.908814
Sum128Base	2155.734	121.603	0.867111
Sum128Traits	125.065	2096.066	14.946344
Sum256Base_Basic	2607.947	100.517	0.716756
Sum256Base	2638.130	99.367	0.708555
Sum256Traits	2636.957	99.412	0.708871

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1970.592	133.028
SumBase	119.813	2187.951	16.447290
SumBase_ClearBit	389.860	672.405	5.054609
SumTraits	67.162	3903.144	29.340764
Sum128Base_Basic	2068.087	126.757	0.952858
Sum128Base	2123.674	123.439	0.927917
Sum128Traits	62.984	4162.042	31.286954
Sum256Base_Basic	2565.965	102.162	0.767973
Sum256Base	2505.574	104.624	0.786483
Sum256Traits	2486.752	105.416	0.792436

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
SumScalar	316.191	829.069
SumBcl	133.195	1968.120	2.373891
SumBase	125.100	2095.473	2.527501
SumBase_Basic	543.442	482.377	0.581830
SumBase_ClearBit	995.721	263.271	0.317550
SumTraits	125.058	2096.171	2.528343
Sum128Base_Basic	554.707	472.581	0.570014
Sum128Base	554.890	472.425	0.569826
Sum128Traits	133.379	1965.410	2.370622
Sum256Base_Basic	1220.928	214.709	0.258976
Sum256Base	1220.523	214.780	0.259062
Sum256Traits	1220.415	214.799	0.259085

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	316.372	828.595
SumBcl	67.023	3911.273	4.720367
SumBase	62.905	4167.304	5.029362
SumBase_Basic	798.056	328.478	0.396428
SumBase_ClearBit	500.673	523.583	0.631892
SumTraits	67.153	3903.693	4.711220
Sum128Base_Basic	832.752	314.792	0.379911
Sum128Base	833.371	314.558	0.379629
Sum128Traits	63.005	4160.695	5.021386
Sum256Base_Basic	957.880	273.671	0.330283
Sum256Base	992.578	264.104	0.318737
Sum256Traits	991.600	264.365	0.319052

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	316.159	829.151
SumBcl	125.365	2091.050	2.521916
SumBase	133.334	1966.074	2.371189
SumBase_Basic	543.620	482.219	0.581581
SumBase_ClearBit	994.109	263.697	0.318033
SumTraits	133.350	1965.831	2.370896
Sum128Base_Basic	554.796	472.505	0.569866
Sum128Base	554.744	472.549	0.569919
Sum128Traits	125.229	2093.312	2.524644
Sum256Base_Basic	1224.760	214.037	0.258140
Sum256Base	1221.724	214.569	0.258781
Sum256Traits	1226.092	213.804	0.257859

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	316.816	827.432
SumBcl	67.011	3911.975	4.727852
SumBase	62.911	4166.932	5.035984
SumBase_Basic	799.116	328.043	0.396459
SumBase_ClearBit	499.970	524.319	0.633671
SumTraits	62.960	4163.633	5.031997
Sum128Base_Basic	832.342	314.947	0.380632
Sum128Base	831.980	315.084	0.380798
Sum128Traits	66.918	3917.388	4.734395
Sum256Base_Basic	958.751	273.422	0.330447
Sum256Base	988.938	265.076	0.320360
Sum256Traits	990.707	264.603	0.319788

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	316.530	828.180
SumBase	348.775	751.614	0.907549
SumBase_Add	349.586	749.870	0.905443
SumTraits	124.879	2099.192	2.534705
Sum128Base_Basic	554.576	472.693	0.570761
Sum128Base	555.171	472.186	0.570149
Sum128Traits	133.209	1967.909	2.376185
Sum256Base_Basic	1224.416	214.097	0.258515
Sum256Base	1223.337	214.286	0.258743
Sum256Traits	1223.261	214.299	0.258759

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394228E+11!=-3.639423E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394228E+11!=-3.639423E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394228E+11!=-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	290.885	901.194
SumBase	211.856	1237.371	1.373036
SumBase_Add	211.971	1236.700	1.372291
SumTraits	66.919	3917.332	4.346826
Sum128Base_Basic	832.198	315.002	0.349539
Sum128Base	833.616	314.466	0.348944
Sum128Traits	63.026	4159.278	4.615299
Sum256Base_Basic	958.561	273.477	0.303461
Sum256Base	987.128	265.562	0.294678
Sum256Traits	988.390	265.223	0.294302

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1867.620	140.363
SumBase	243.286	1077.514	7.676645
SumBase_ClearBit	748.354	350.294	2.495638
SumTraits	124.991	2097.308	14.942066
Sum128Base_Basic	2140.633	122.461	0.872461
Sum128Base	2033.212	128.931	0.918556
Sum128Traits	133.109	1969.392	14.030744
Sum256Base_Basic	2712.530	96.642	0.688516
Sum256Base	2608.220	100.507	0.716051
Sum256Traits	2597.797	100.910	0.718924

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394228E+11!=-3.639423E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394228E+11!=-3.639423E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394228E+11!=-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	1889.471	138.739
SumBase	144.142	1818.647	13.108371
SumBase_ClearBit	379.494	690.772	4.978916
SumTraits	62.868	4169.740	30.054483
Sum128Base_Basic	2075.048	126.332	0.910567
Sum128Base	2122.174	123.526	0.890347
Sum128Traits	67.001	3912.528	28.200563
Sum256Base_Basic	2575.024	101.803	0.733768
Sum256Base	2512.098	104.353	0.752149
Sum256Traits	2503.629	104.706	0.754693

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
SumScalar	210.676	1244.301
SumBcl	106.099	2470.751	1.985654
SumBase	106.257	2467.067	1.982693
SumBase_Basic	548.267	478.132	0.384258
SumBase_ClearBit	908.670	288.492	0.231851
SumTraits	106.197	2468.473	1.983823
Sum128Bcl	106.360	2464.693	1.980786
Sum128Base_Basic	551.788	475.081	0.381806
Sum128Base	106.220	2467.937	1.983393
Sum128Traits	106.255	2467.121	1.982737
Sum256Bcl	969.056	270.515	0.217403
Sum256Base_Basic	1159.566	226.071	0.181685
Sum256Base	1149.690	228.013	0.183246
Sum256Traits	1149.464	228.058	0.183282

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
SumScalar	211.277	1240.758
SumBcl	55.750	4702.110	3.789709
SumBase	55.750	4702.100	3.789701
SumBase_Basic	801.610	327.022	0.263566
SumBase_ClearBit	462.526	566.766	0.456790
SumTraits	55.770	4700.442	3.788364
Sum128Bcl	55.666	4709.245	3.795459
Sum128Base_Basic	805.652	325.381	0.262244
Sum128Base	55.635	4711.882	3.797585
Sum128Traits	55.731	4703.732	3.791016
Sum256Bcl	897.501	292.082	0.235406
Sum256Base_Basic	1014.089	258.502	0.208342
Sum256Base	936.909	279.797	0.225505
Sum256Traits	938.419	279.346	0.225142

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
SumScalar	210.679	1244.283
SumBcl	106.574	2459.743	1.976836
SumBase	106.416	2463.389	1.979767
SumBase_Basic	555.475	471.928	0.379277
SumBase_ClearBit	916.719	285.959	0.229818
SumTraits	106.257	2467.065	1.982721
Sum128Bcl	106.362	2464.638	1.980770
Sum128Base_Basic	558.605	469.283	0.377151
Sum128Base	106.336	2465.248	1.981261
Sum128Traits	106.315	2465.723	1.981643
Sum256Bcl	968.652	270.628	0.217497
Sum256Base_Basic	1151.176	227.718	0.183012
Sum256Base	1149.305	228.089	0.183310
Sum256Traits	1149.727	228.005	0.183242

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
SumScalar	211.400	1240.039
SumBcl	55.743	4702.729	3.792404
SumBase	55.639	4711.522	3.799495
SumBase_Basic	801.635	327.012	0.263711
SumBase_ClearBit	466.284	562.198	0.453371
SumTraits	55.796	4698.280	3.788816
Sum128Bcl	55.734	4703.472	3.793004
Sum128Base_Basic	806.396	325.081	0.262154
Sum128Base	55.894	4690.033	3.782166
Sum128Traits	55.864	4692.576	3.784217
Sum256Bcl	901.264	290.863	0.234559
Sum256Base_Basic	1010.358	259.457	0.209233
Sum256Base	936.978	279.776	0.225619
Sum256Traits	936.709	279.856	0.225684

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.634	1244.545
SumBase	418.472	626.432	0.503342
SumBase_Add	418.445	626.471	0.503374
SumTraits	106.529	2460.771	1.977245
Sum128Base_Basic	557.233	470.439	0.378000
Sum128Base	257.718	1017.172	0.817304
Sum128Traits	106.120	2470.259	1.984869
Sum256Base_Basic	1151.570	227.641	0.182911
Sum256Base	5222.645	50.194	0.040331
Sum256Traits	5222.426	50.196	0.040333

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	211.706	1238.247
SumBase	180.184	1454.865	1.174939
SumBase_Add	171.792	1525.939	1.232338
SumTraits	55.716	4704.973	3.799705
Sum128Base_Basic	806.127	325.190	0.262621
Sum128Base	141.384	1854.125	1.497379
Sum128Traits	55.769	4700.519	3.796107
Sum256Base_Basic	1010.619	259.389	0.209481
Sum256Base	3972.297	65.993	0.053296
Sum256Traits	3973.245	65.977	0.053283

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.611	1244.686
SumBase	271.582	965.249	0.775496
SumBase_ClearBit	691.529	379.079	0.304558
SumTraits	106.312	2465.789	1.981053
Sum128Base_Basic	557.505	470.209	0.377773
Sum128Base	163.282	1605.466	1.289856
Sum128Traits	106.210	2468.178	1.982973
Sum256Base_Basic	1151.579	227.639	0.182888
Sum256Base	3222.581	81.346	0.065355
Sum256Traits	3226.001	81.260	0.065285

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	211.329	1240.455
SumBase	114.759	2284.300	1.841501
SumBase_ClearBit	350.785	747.307	0.602446
SumTraits	55.652	4710.389	3.797306
Sum128Base_Basic	805.885	325.287	0.262232
Sum128Base	95.628	2741.302	2.209916
Sum128Traits	56.002	4680.994	3.773609
Sum256Base_Basic	1010.835	259.334	0.209064
Sum256Base	2241.101	116.971	0.094297
Sum256Traits	2245.490	116.742	0.094113

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

