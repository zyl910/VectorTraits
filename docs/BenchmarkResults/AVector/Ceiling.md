# Benchmark - Ceiling
([← Back](README.md))

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
SumScalar	549.337	477.201
SumBase	334.988	782.547	1.639870
SumBase_ClearBit	339.030	773.219	1.620323
SumTraits	315.994	829.584	1.738439

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	1330.212	197.069
SumBase	164.989	1588.858	8.062431
SumBase_ClearBit	167.815	1562.104	7.926670
SumTraits	159.674	1641.743	8.330784

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	599.361	437.372
SumBase	316.153	829.167	1.895793
SumBase_ClearBit	317.140	826.588	1.889897
SumTraits	317.733	825.046	1.886371

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	1339.666	195.679
SumBase	167.526	1564.794	7.996755
SumBase_ClearBit	155.016	1691.074	8.642094
SumTraits	161.441	1623.780	8.298195

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1261.300	207.836
SumBase	227.150	1154.055	5.552709
SumBase_ClearBit	426.034	615.312	2.960560
SumTraits	253.469	1034.225	4.976152

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	2017.397	129.942
SumBase	127.704	2052.744	15.797418
SumBase_ClearBit	120.513	2175.242	16.740133
SumTraits	117.685	2227.503	17.142325

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
SumScalar	940.808	278.637
SumBase	327.816	799.667	2.869924
SumBase_ClearBit	331.335	791.175	2.839448
SumTraits	324.178	808.641	2.902130

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	937.868	279.510
SumBase	157.534	1664.046	5.953429
SumBase_ClearBit	156.054	1679.825	6.009883
SumTraits	159.266	1645.950	5.888690

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	934.007	280.666
SumBase	342.197	766.061	2.729440
SumBase_ClearBit	338.272	774.950	2.761109
SumTraits	307.141	853.498	3.040975

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	942.474	278.145
SumBase	172.823	1516.833	5.453398
SumBase_ClearBit	173.462	1511.245	5.433308
SumTraits	165.886	1580.264	5.681450

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1164.645	225.085
SumBase	225.637	1161.797	5.161598
SumBase_ClearBit	228.282	1148.334	5.101784
SumTraits	251.656	1041.677	4.627932

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	1127.177	232.567
SumBase	124.835	2099.919	9.029313
SumBase_ClearBit	126.512	2072.092	8.909661
SumTraits	120.028	2184.023	9.390946

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
SumScalar	935.377	280.255
SumBase	296.677	883.601	3.152848
SumBase_ClearBit	265.047	989.048	3.529102
SumTraits	79.455	3299.285	11.772447
Sum128Base_Basic	1647.403	159.126	0.567789
Sum128Base	1648.401	159.029	0.567445
Sum128Traits	1648.280	159.041	0.567487
Sum256Base_Basic	495.902	528.621	1.886216
Sum256Base	494.419	530.206	1.891871
Sum256Traits	79.815	3284.411	11.719376

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	931.667	281.371
SumBase	149.860	1749.261	6.216920
SumBase_ClearBit	150.260	1744.600	6.200355
SumTraits	39.298	6670.753	23.708038
Sum128Base_Basic	897.786	291.989	1.037738
Sum128Base	898.810	291.657	1.036556
Sum128Traits	1010.979	259.297	0.921549
Sum256Base_Basic	323.030	811.515	2.884146
Sum256Base	325.646	804.997	2.860982
Sum256Traits	39.230	6682.166	23.748597

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	932.528	281.111
SumBase	270.785	968.089	3.443797
SumBase_ClearBit	272.233	962.939	3.425476
SumTraits	79.642	3291.516	11.708951
Sum128Base_Basic	1638.530	159.987	0.569125
Sum128Base	1640.148	159.829	0.568563
Sum128Traits	1639.418	159.901	0.568816
Sum256Base_Basic	488.663	536.451	1.908325
Sum256Base	490.557	534.380	1.900956
Sum256Traits	83.939	3123.030	11.109592

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	932.008	281.268
SumBase	148.086	1770.219	6.293708
SumBase_ClearBit	148.494	1765.353	6.276406
SumTraits	39.341	6663.375	23.690475
Sum128Base_Basic	898.143	291.873	1.037705
Sum128Base	898.901	291.627	1.036830
Sum128Traits	898.900	291.627	1.036831
Sum256Base_Basic	283.806	923.673	3.283961
Sum256Base	283.792	923.720	3.284125
Sum256Traits	40.964	6399.424	22.752042

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1187.773	220.702
SumBase	224.103	1169.750	5.300130
SumBase_ClearBit	214.453	1222.382	5.538604
SumTraits	80.648	3250.477	14.727887
Sum128Base_Basic	2351.260	111.491	0.505164
Sum128Base	2342.127	111.926	0.507134
Sum128Traits	2339.938	112.030	0.507609
Sum256Base_Basic	1360.188	192.726	0.873242
Sum256Base	1481.476	176.948	0.801749
Sum256Traits	79.697	3289.257	14.903602

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1393.924	188.062
SumBase	117.778	2225.753	11.835219
SumBase_ClearBit	118.426	2213.560	11.770383
SumTraits	39.744	6595.802	35.072517
Sum128Base_Basic	1654.110	158.480	0.842704
Sum128Base	1650.015	158.874	0.844795
Sum128Traits	1708.618	153.425	0.815820
Sum256Base_Basic	1392.758	188.219	1.000838
Sum256Base	1324.464	197.925	1.052445
Sum256Traits	39.679	6606.638	35.130139

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
SumScalar	939.307	279.082
SumBcl	81.595	3212.734	11.511781
SumBase	84.568	3099.819	11.107186
SumBase_ClearBit	301.733	868.795	3.113042
SumTraits	91.427	2867.242	10.273822
Sum128Base_Basic	1638.845	159.957	0.573152
Sum128Base	1637.413	160.096	0.573653
Sum128Traits	1653.061	158.581	0.568223
Sum256Base_Basic	495.141	529.433	1.897051
Sum256Base	498.678	525.678	1.883595
Sum256Traits	82.515	3176.939	11.383523

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	939.451	279.040
SumBcl	39.655	6610.625	23.690626
SumBase	39.705	6602.343	23.660943
SumBase_ClearBit	142.841	1835.212	6.576886
SumTraits	39.712	6601.192	23.656819
Sum128Base_Basic	904.853	289.709	1.038235
Sum128Base	907.604	288.831	1.035088
Sum128Traits	903.227	290.231	1.040105
Sum256Base_Basic	285.216	919.106	3.293819
Sum256Base	285.567	917.977	3.289771
Sum256Traits	42.443	6176.383	22.134423

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	940.346	278.774
SumBcl	81.178	3229.251	11.583764
SumBase	81.582	3213.265	11.526418
SumBase_ClearBit	288.727	907.931	3.256873
SumTraits	87.011	3012.772	10.807224
Sum128Base_Basic	1647.977	159.070	0.570606
Sum128Base	1646.337	159.229	0.571175
Sum128Traits	1641.347	159.713	0.572911
Sum256Base_Basic	492.636	532.125	1.908805
Sum256Base	494.589	530.024	1.901269
Sum256Traits	87.203	3006.134	10.783410

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	936.962	279.781
SumBcl	40.460	6479.156	23.157976
SumBase	41.861	6262.233	22.382643
SumBase_ClearBit	141.093	1857.954	6.640750
SumTraits	41.667	6291.469	22.487140
Sum128Base_Basic	899.075	291.571	1.042140
Sum128Base	903.496	290.144	1.037041
Sum128Traits	905.850	289.390	1.034346
Sum256Base_Basic	283.976	923.119	3.299439
Sum256Base	282.259	928.737	3.319518
Sum256Traits	40.578	6460.215	23.090278

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1281.731	204.523
SumBase	101.097	2592.996	12.678237
SumBase_ClearBit	214.270	1223.427	5.981845
SumTraits	83.247	3149.009	15.396814
Sum128Base_Basic	2337.243	112.160	0.548395
Sum128Base	2341.364	111.962	0.547429
Sum128Traits	2341.502	111.955	0.547397
Sum256Base_Basic	1320.435	198.529	0.970689
Sum256Base	1368.585	191.544	0.936537
Sum256Traits	79.824	3284.026	16.056969

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1126.803	232.644
SumBase	43.957	5963.602	25.634022
SumBase_ClearBit	98.229	2668.698	11.471166
SumTraits	40.423	6484.948	27.874984
Sum128Base_Basic	1697.287	154.449	0.663885
Sum128Base	1669.310	157.037	0.675011
Sum128Traits	1649.710	158.903	0.683031
Sum256Base_Basic	1284.810	204.033	0.877019
Sum256Base	1351.748	193.930	0.833590
Sum256Traits	39.931	6564.948	28.218855

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
SumScalar	937.969	279.480
SumBcl	82.068	3194.222	11.429149
SumBase	82.110	3192.602	11.423352
SumBase_ClearBit	277.669	944.089	3.378016
SumTraits	88.056	2977.025	10.652002
Sum128Base_Basic	1643.090	159.543	0.570857
Sum128Base	1639.441	159.898	0.572128
Sum128Traits	1635.609	160.273	0.573468
Sum256Base_Basic	554.691	472.594	1.690976
Sum256Base	555.087	472.258	1.689770
Sum256Traits	80.157	3270.370	11.701612

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	938.659	279.275
SumBcl	40.320	6501.641	23.280417
SumBase	40.605	6455.888	23.116592
SumBase_ClearBit	142.342	1841.646	6.594381
SumTraits	39.502	6636.229	23.762337
Sum128Base_Basic	899.662	291.380	1.043346
Sum128Base	900.229	291.197	1.042689
Sum128Traits	904.323	289.879	1.037969
Sum256Base_Basic	320.297	818.441	2.930590
Sum256Base	320.007	819.183	2.933246
Sum256Traits	39.863	6576.043	23.546831

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	935.542	280.205
SumBcl	82.051	3194.880	11.401921
SumBase	82.128	3191.903	11.391295
SumBase_ClearBit	278.602	940.927	3.357990
SumTraits	87.343	3001.324	10.711154
Sum128Base_Basic	1647.278	159.138	0.567932
Sum128Base	1636.928	160.144	0.571523
Sum128Traits	1638.930	159.948	0.570825
Sum256Base_Basic	556.414	471.131	1.681377
Sum256Base	490.049	534.935	1.909081
Sum256Traits	80.025	3275.790	11.690674

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	933.675	280.766
SumBcl	40.969	6398.642	22.789969
SumBase	40.342	6498.044	23.144009
SumBase_ClearBit	137.983	1899.833	6.766613
SumTraits	40.052	6545.037	23.311381
Sum128Base_Basic	905.652	289.453	1.030942
Sum128Base	899.669	291.378	1.037799
Sum128Traits	900.022	291.264	1.037392
Sum256Base_Basic	285.334	918.726	3.272216
Sum256Base	286.554	914.816	3.258288
Sum256Traits	40.238	6514.890	23.204009

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1171.435	223.780
SumBase	102.589	2555.279	11.418692
SumBase_ClearBit	221.911	1181.302	5.278846
SumTraits	85.705	3058.670	13.668179
Sum128Base_Basic	2356.703	111.233	0.497065
Sum128Base	2372.782	110.480	0.493697
Sum128Traits	2361.889	110.989	0.495974
Sum256Base_Basic	1338.939	195.785	0.874897
Sum256Base	1437.622	182.346	0.814842
Sum256Traits	84.732	3093.811	13.825215

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1359.784	192.784
SumBase	48.802	5371.629	27.863524
SumBase_ClearBit	100.729	2602.480	13.499493
SumTraits	40.447	6481.166	33.618874
Sum128Base_Basic	1658.648	158.047	0.819815
Sum128Base	1670.356	156.939	0.814068
Sum128Traits	1660.845	157.838	0.818730
Sum256Base_Basic	1309.711	200.154	1.038232
Sum256Base	1306.647	200.623	1.040666
Sum256Traits	43.034	6091.506	31.597645

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
SumScalar	939.313	279.080
SumBcl	81.981	3197.604	11.457643
SumBase	88.586	2959.190	10.603358
SumBase_ClearBit	289.498	905.513	3.244630
SumTraits	84.994	3084.249	11.051469
Sum128Bcl	158.533	1653.566	5.925053
Sum128Base_Basic	867.740	302.100	1.082482
Sum128Base	161.036	1627.856	5.832927
Sum128Traits	161.236	1625.843	5.825713
Sum256Bcl	83.885	3125.028	11.197589
Sum256Base_Basic	496.075	528.437	1.893492
Sum256Base	82.381	3182.105	11.402106
Sum256Traits	86.232	3039.998	10.892910

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
SumScalar	936.842	279.817
SumBcl	39.967	6558.971	23.440241
SumBase	41.841	6265.216	22.390427
SumBase_ClearBit	138.204	1896.796	6.778711
SumTraits	41.386	6334.103	22.636615
Sum128Bcl	79.203	3309.763	11.828326
Sum128Base_Basic	472.746	554.514	1.981703
Sum128Base	79.347	3303.768	11.806901
Sum128Traits	78.407	3343.381	11.948469
Sum256Bcl	39.286	6672.731	23.846793
Sum256Base_Basic	317.349	826.044	2.952091
Sum256Base	42.537	6162.688	22.024019
Sum256Traits	42.389	6184.290	22.101219

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
SumScalar	934.194	280.610
SumBcl	80.395	3260.682	11.619980
SumBase	80.305	3264.373	11.633135
SumBase_ClearBit	261.977	1000.638	3.565937
SumTraits	80.070	3273.916	11.667140
Sum128Bcl	158.299	1656.007	5.901453
Sum128Base_Basic	856.486	306.069	1.090729
Sum128Base	158.043	1658.685	5.910999
Sum128Traits	158.529	1653.598	5.892869
Sum256Bcl	80.549	3254.464	11.597821
Sum256Base_Basic	558.583	469.302	1.672435
Sum256Base	79.842	3283.271	11.700480
Sum256Traits	80.006	3276.566	11.676586

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
SumScalar	931.732	281.351
SumBcl	39.263	6676.622	23.730559
SumBase	40.692	6442.109	22.897034
SumBase_ClearBit	125.822	2083.449	7.405152
SumTraits	39.251	6678.739	23.738084
Sum128Bcl	78.338	3346.313	11.893720
Sum128Base_Basic	468.689	559.313	1.987952
Sum128Base	78.439	3342.005	11.878407
Sum128Traits	78.254	3349.926	11.906563
Sum256Bcl	41.313	6345.269	22.552837
Sum256Base_Basic	317.061	826.793	2.938651
Sum256Base	42.044	6235.033	22.161030
Sum256Traits	42.218	6209.360	22.069779

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	935.268	280.288
SumBase	90.467	2897.685	10.338259
SumBase_ClearBit	195.506	1340.852	4.783845
SumTraits	85.375	3070.514	10.954872
Sum128Base_Basic	856.882	305.928	1.091478
Sum128Base	178.076	1472.095	5.252087
Sum128Traits	176.620	1484.228	5.295377
Sum256Base_Basic	556.083	471.412	1.681886
Sum256Base	98.013	2674.581	9.542277
Sum256Traits	84.214	3112.820	11.105810

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	932.289	281.183
SumBase	45.133	5808.293	20.656610
SumBase_ClearBit	99.706	2629.178	9.350406
SumTraits	39.715	6600.618	23.474434
Sum128Base_Basic	471.507	555.970	1.977253
Sum128Base	84.762	3092.704	10.998889
Sum128Traits	85.840	3053.879	10.860814
Sum256Base_Basic	317.434	825.822	2.936951
Sum256Base	48.977	5352.357	19.035118
Sum256Traits	41.950	6249.035	22.224064

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
SumScalar	316.257	828.897
SumBase	1423.025	184.216	0.222242
SumBase_ClearBit	1423.904	184.102	0.222105
SumTraits	1422.526	184.281	0.222320
Sum128Base_Basic	1145.167	228.913	0.276166
Sum128Base	1146.176	228.712	0.275923
Sum128Traits	1144.616	229.024	0.276299
Sum256Base_Basic	1570.851	166.880	0.201328
Sum256Base	1569.274	167.048	0.201530
Sum256Traits	1569.580	167.015	0.201491

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	290.787	901.497
SumBase	700.873	374.025	0.414893
SumBase_ClearBit	700.994	373.960	0.414822
SumTraits	700.881	374.021	0.414888
Sum128Base_Basic	1459.953	179.556	0.199176
Sum128Base	1460.342	179.509	0.199123
Sum128Traits	1460.726	179.461	0.199071
Sum256Base_Basic	1186.279	220.980	0.245126
Sum256Base	1189.582	220.366	0.244445
Sum256Traits	1184.583	221.296	0.245477

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	294.585	889.875
SumBase	1441.419	181.865	0.204372
SumBase_ClearBit	1430.668	183.232	0.205908
SumTraits	1427.367	183.656	0.206384
Sum128Base_Basic	1150.785	227.796	0.255986
Sum128Base	1149.895	227.972	0.256185
Sum128Traits	1151.036	227.746	0.255931
Sum256Base_Basic	1587.463	165.134	0.185570
Sum256Base	1590.164	164.853	0.185255
Sum256Traits	1599.244	163.917	0.184203

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	295.873	886.001
SumBase	705.205	371.727	0.419556
SumBase_ClearBit	712.152	368.101	0.415464
SumTraits	705.070	371.798	0.419637
Sum128Base_Basic	1475.767	177.632	0.200488
Sum128Base	1478.264	177.332	0.200149
Sum128Traits	1477.089	177.473	0.200308
Sum256Base_Basic	1196.253	219.138	0.247333
Sum256Base	1203.691	217.783	0.245805
Sum256Traits	1202.211	218.051	0.246108

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1643.806	159.474
SumBase	1089.679	240.570	1.508523
SumBase_ClearBit	1108.549	236.475	1.482844
SumTraits	1108.832	236.415	1.482466
Sum128Base_Basic	2206.754	118.792	0.744897
Sum128Base	2187.644	119.829	0.751404
Sum128Traits	2208.029	118.723	0.744468
Sum256Base_Basic	2673.890	98.038	0.614762
Sum256Base	2675.456	97.981	0.614402
Sum256Traits	2681.193	97.771	0.613087

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	1751.256	149.689
SumBase	540.551	484.957	3.239763
SumBase_ClearBit	541.652	483.972	3.233177
SumTraits	540.631	484.885	3.239278
Sum128Base_Basic	2366.413	110.777	0.740047
Sum128Base	2306.174	113.671	0.759377
Sum128Traits	2416.408	108.485	0.724735
Sum256Base_Basic	2293.076	114.320	0.763715
Sum256Base	2263.742	115.801	0.773611
Sum256Traits	2291.678	114.390	0.764181

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
SumScalar	315.661	830.461
SumBcl	124.888	2099.030	2.527549
SumBase	125.144	2094.740	2.522382
SumBase_ClearBit	1105.352	237.159	0.285575
SumTraits	124.923	2098.437	2.526834
Sum128Base_Basic	557.413	470.287	0.566297
Sum128Base	557.288	470.393	0.566424
Sum128Traits	133.388	1965.278	2.366490
Sum256Base_Basic	1069.192	245.180	0.295233
Sum256Base	1070.996	244.767	0.294736
Sum256Traits	1069.801	245.040	0.295065

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	290.849	901.305
SumBcl	62.446	4197.954	4.657638
SumBase	62.488	4195.124	4.654498
SumBase_ClearBit	514.071	509.937	0.565776
SumTraits	62.399	4201.094	4.661122
Sum128Base_Basic	829.065	316.192	0.350816
Sum128Base	829.135	316.166	0.350786
Sum128Traits	66.680	3931.345	4.361834
Sum256Base_Basic	888.368	295.085	0.327397
Sum256Base	888.011	295.203	0.327529
Sum256Traits	888.467	295.052	0.327361

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.499	902.394
SumBcl	124.884	2099.098	2.326144
SumBase	125.093	2095.597	2.322265
SumBase_ClearBit	1104.485	237.345	0.263017
SumTraits	125.040	2096.486	2.323251
Sum128Base_Basic	558.253	469.579	0.520370
Sum128Base	558.621	469.270	0.520028
Sum128Traits	133.122	1969.198	2.182194
Sum256Base_Basic	1070.462	244.889	0.271377
Sum256Base	1071.328	244.691	0.271158
Sum256Traits	1070.957	244.775	0.271251

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	316.241	828.937
SumBcl	62.458	4197.121	5.063254
SumBase	62.453	4197.432	5.063629
SumBase_ClearBit	514.972	509.045	0.614094
SumTraits	66.561	3938.383	4.751122
Sum128Base_Basic	833.882	314.366	0.379240
Sum128Base	833.803	314.396	0.379275
Sum128Traits	62.463	4196.774	5.062836
Sum256Base_Basic	889.210	294.806	0.355643
Sum256Base	888.930	294.898	0.355755
Sum256Traits	888.645	294.993	0.355869

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1615.530	162.265
SumBase	246.560	1063.206	6.552277
SumBase_ClearBit	843.679	310.715	1.914863
SumTraits	124.919	2098.516	12.932640
Sum128Base_Basic	1683.495	155.714	0.959628
Sum128Base	1672.254	156.761	0.966079
Sum128Traits	133.177	1968.389	12.130705
Sum256Base_Basic	2060.130	127.246	0.784188
Sum256Base	2125.197	123.350	0.760179
Sum256Traits	2128.691	123.148	0.758931

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1752.572	149.577
SumBase	119.161	2199.921	14.707642
SumBase_ClearBit	389.196	673.552	4.503055
SumTraits	62.485	4195.339	28.048070
Sum128Base_Basic	1768.111	148.262	0.991211
Sum128Base	1675.034	156.501	1.046290
Sum128Traits	66.577	3937.437	26.323863
Sum256Base_Basic	2034.501	128.849	0.861426
Sum256Base	2057.248	127.425	0.851901
Sum256Traits	2044.446	128.223	0.857236

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
SumScalar	290.494	902.409
SumBcl	125.014	2096.920	2.323692
SumBase	133.124	1969.175	2.182132
SumBase_ClearBit	994.851	263.501	0.291997
SumTraits	124.876	2099.231	2.326254
Sum128Base_Basic	556.940	470.686	0.521589
Sum128Base	558.728	469.180	0.519919
Sum128Traits	133.144	1968.872	2.181797
Sum256Base_Basic	1073.747	244.139	0.270542
Sum256Base	1067.443	245.581	0.272140
Sum256Traits	1071.742	244.596	0.271048

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	290.713	901.727
SumBcl	66.639	3933.809	4.362527
SumBase	62.580	4188.951	4.645474
SumBase_ClearBit	499.743	524.557	0.581725
SumTraits	62.807	4173.833	4.628709
Sum128Base_Basic	830.329	315.711	0.350118
Sum128Base	829.872	315.885	0.350311
Sum128Traits	66.600	3936.067	4.365031
Sum256Base_Basic	882.692	296.983	0.329348
Sum256Base	883.999	296.543	0.328862
Sum256Traits	882.326	297.106	0.329485

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	316.182	829.093
SumBcl	124.873	2099.288	2.532029
SumBase	133.854	1958.434	2.362140
SumBase_ClearBit	990.279	264.717	0.319286
SumTraits	125.124	2095.072	2.526943
Sum128Base_Basic	556.931	470.694	0.567721
Sum128Base	556.607	470.968	0.568052
Sum128Traits	133.200	1968.044	2.373731
Sum256Base_Basic	1068.754	245.280	0.295841
Sum256Base	1069.492	245.111	0.295637
Sum256Traits	1068.397	245.362	0.295940

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	317.048	826.827
SumBcl	66.615	3935.225	4.759427
SumBase	62.485	4195.324	5.074002
SumBase_ClearBit	499.627	524.679	0.634569
SumTraits	66.619	3934.954	4.759100
Sum128Base_Basic	833.842	314.381	0.380225
Sum128Base	833.500	314.510	0.380381
Sum128Traits	62.494	4194.739	5.073295
Sum256Base_Basic	882.436	297.069	0.359287
Sum256Base	883.140	296.832	0.359001
Sum256Traits	882.534	297.035	0.359247

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1719.637	152.441
SumBase	246.013	1065.568	6.990014
SumBase_ClearBit	745.545	351.614	2.306551
SumTraits	133.427	1964.706	12.888266
Sum128Base_Basic	1691.754	154.954	1.016482
Sum128Base	1708.986	153.392	1.006233
Sum128Traits	124.841	2099.820	13.774597
Sum256Base_Basic	2204.559	118.910	0.780037
Sum256Base	2186.147	119.911	0.786606
Sum256Traits	2145.314	122.194	0.801578

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1753.010	149.539
SumBase	144.160	1818.428	12.160197
SumBase_ClearBit	378.110	693.300	4.636240
SumTraits	66.611	3935.447	26.317131
Sum128Base_Basic	1695.631	154.600	1.033839
Sum128Base	1743.551	150.351	1.005425
Sum128Traits	62.380	4202.366	28.102074
Sum256Base_Basic	2054.078	127.621	0.853429
Sum256Base	2034.530	128.847	0.861629
Sum256Traits	2039.728	128.519	0.859433

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
SumScalar	210.655	1244.422
SumBcl	106.028	2472.398	1.986784
SumBase	106.202	2468.357	1.983537
SumBase_ClearBit	908.573	288.523	0.231853
SumTraits	106.244	2467.371	1.982744
Sum128Bcl	106.579	2459.618	1.976514
Sum128Base_Basic	552.013	474.887	0.381612
Sum128Base	106.120	2470.258	1.985064
Sum128Traits	106.111	2470.471	1.985235
Sum256Bcl	1017.049	257.750	0.207124
Sum256Base_Basic	1209.547	216.729	0.174160
Sum256Base	1149.820	227.987	0.183207
Sum256Traits	1149.452	228.060	0.183266

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
SumScalar	210.931	1242.796
SumBcl	55.410	4730.990	3.806731
SumBase	55.347	4736.385	3.811072
SumBase_ClearBit	462.635	566.633	0.455934
SumTraits	55.249	4744.741	3.817796
Sum128Bcl	55.450	4727.537	3.803953
Sum128Base_Basic	805.345	325.505	0.261914
Sum128Base	55.365	4734.792	3.809790
Sum128Traits	55.245	4745.120	3.818101
Sum256Bcl	896.235	292.495	0.235352
Sum256Base_Basic	1012.387	258.937	0.208350
Sum256Base	936.661	279.871	0.225194
Sum256Traits	938.505	279.321	0.224752

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
SumScalar	210.872	1243.141
SumBcl	106.276	2466.645	1.984205
SumBase	106.180	2468.857	1.985984
SumBase_ClearBit	916.621	285.989	0.230054
SumTraits	106.490	2461.670	1.980203
Sum128Bcl	106.190	2468.637	1.985807
Sum128Base_Basic	557.778	469.979	0.378058
Sum128Base	106.288	2466.347	1.983965
Sum128Traits	106.275	2466.666	1.984221
Sum256Bcl	969.084	270.507	0.217600
Sum256Base_Basic	1155.790	226.809	0.182449
Sum256Base	1149.671	228.017	0.183420
Sum256Traits	1149.654	228.020	0.183423

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
SumScalar	210.892	1243.022
SumBcl	55.374	4734.073	3.808517
SumBase	55.395	4732.289	3.807083
SumBase_ClearBit	465.335	563.345	0.453205
SumTraits	55.327	4738.067	3.811731
Sum128Bcl	55.286	4741.560	3.814541
Sum128Base_Basic	805.348	325.504	0.261865
Sum128Base	55.255	4744.288	3.816736
Sum128Traits	55.330	4737.865	3.811569
Sum256Bcl	900.021	291.264	0.234319
Sum256Base_Basic	1008.634	259.900	0.209087
Sum256Base	936.287	279.982	0.225243
Sum256Traits	936.132	280.029	0.225281

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.586	1244.833
SumBase	217.087	1207.554	0.970053
SumBase_ClearBit	692.227	378.697	0.304215
SumTraits	106.196	2468.494	1.982992
Sum128Base_Basic	551.605	475.239	0.381769
Sum128Base	163.164	1606.629	1.290639
Sum128Traits	106.443	2462.757	1.978384
Sum256Base_Basic	1160.077	225.971	0.181527
Sum256Base	3217.108	81.484	0.065458
Sum256Traits	3216.908	81.489	0.065462

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	210.885	1243.068
SumBase	112.385	2332.546	1.876443
SumBase_ClearBit	349.018	751.090	0.604223
SumTraits	55.594	4715.361	3.793325
Sum128Base_Basic	805.759	325.338	0.261722
Sum128Base	95.391	2748.107	2.210746
Sum128Traits	55.417	4730.362	3.805392
Sum256Base_Basic	1008.488	259.938	0.209110
Sum256Base	2242.412	116.903	0.094044
Sum256Traits	2244.145	116.812	0.093971

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

