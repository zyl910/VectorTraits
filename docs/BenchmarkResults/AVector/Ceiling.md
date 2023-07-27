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
SumScalar	633.242	413.971
SumBase	245.270	1068.796	2.581814
SumBase_Basic	903.210	290.236	0.701102
SumBase_ClearBit	239.853	1092.937	2.640127
SumTraits	242.283	1081.972	2.613642

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	1324.761	197.880
SumBase	117.682	2227.562	11.257126
SumBase_Basic	1132.565	231.461	1.169701
SumBase_ClearBit	122.212	2144.997	10.839878
SumTraits	123.336	2125.438	10.741038

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	589.152	444.951
SumBase	241.815	1084.067	2.436373
SumBase_Basic	886.025	295.865	0.664939
SumBase_ClearBit	242.289	1081.946	2.431607
SumTraits	252.207	1039.399	2.335985

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	1333.195	196.628
SumBase	117.263	2235.514	11.369231
SumBase_Basic	1118.092	234.457	1.192383
SumBase_ClearBit	121.015	2166.219	11.016811
SumTraits	124.963	2097.777	10.668735

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	2142.861	122.334
SumBase	123.187	2128.025	17.395252
SumBase_Add	120.347	2178.238	17.805717
SumTraits	126.416	2073.669	16.950925

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	2324.896	112.755
SumBase	59.162	4430.932	39.296928
SumBase_Add	64.617	4056.907	35.979786
SumTraits	60.760	4314.404	38.263469

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1441.862	181.809
SumBase	164.434	1594.218	8.768624
SumBase_ClearBit	161.704	1621.136	8.916682
SumBase_ClearBit_Not	165.009	1588.665	8.738083
SumTraits	163.706	1601.310	8.807633

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	2107.001	124.416
SumBase	82.523	3176.600	25.532139
SumBase_ClearBit	82.820	3165.214	25.440628
SumTraits	83.819	3127.494	25.137446

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
SumScalar	941.417	278.457
SumBase	256.565	1021.746	3.669315
SumBase_Basic	540.064	485.394	1.743157
SumBase_ClearBit	254.953	1028.203	3.692504
SumTraits	248.253	1055.954	3.792164

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	933.267	280.889
SumBase	121.161	2163.609	7.702728
SumBase_Basic	570.855	459.213	1.634856
SumBase_ClearBit	126.551	2071.455	7.374648
SumTraits	127.207	2060.763	7.336583

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	933.050	280.954
SumBase	243.703	1075.671	3.828639
SumBase_Basic	532.039	492.716	1.753726
SumBase_ClearBit	239.912	1092.668	3.889137
SumTraits	243.025	1078.670	3.839314

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	932.751	281.044
SumBase	126.181	2077.525	7.392174
SumBase_Basic	570.556	459.453	1.634811
SumBase_ClearBit	118.559	2211.077	7.867376
SumTraits	119.625	2191.378	7.797283

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	933.660	280.770
SumBase	116.036	2259.159	8.046285
SumBase_Add	132.868	1972.961	7.026955
SumTraits	118.206	2217.692	7.898597

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	932.946	280.985
SumBase	56.188	4665.501	16.604079
SumBase_Add	59.391	4413.895	15.708638
SumTraits	59.892	4376.953	15.577165

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	2578.037	101.684
SumBase	160.419	1634.119	16.070624
SumBase_ClearBit	171.640	1527.294	15.020065
SumBase_ClearBit_Not	173.590	1510.136	14.851329
SumTraits	160.020	1638.197	16.110732

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	1458.283	179.762
SumBase	81.620	3211.757	17.866713
SumBase_ClearBit	81.243	3226.662	17.949626
SumTraits	81.262	3225.926	17.945534

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
SumScalar	935.279	280.284
SumBase	222.839	1176.384	4.197108
SumBase_Basic	556.841	470.770	1.679617
SumBase_ClearBit	219.481	1194.381	4.261321
SumTraits	80.323	3263.621	11.643965
Sum128Base_Basic	1640.851	159.761	0.569996
Sum128Base	1639.036	159.938	0.570627
Sum128Traits	1644.279	159.428	0.568808
Sum256Base_Basic	558.814	469.108	1.673686
Sum256Base	558.579	469.305	1.674390
Sum256Traits	80.229	3267.449	11.657625

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	935.195	280.309
SumBase	112.360	2333.076	8.323218
SumBase_Basic	342.760	764.802	2.728423
SumBase_ClearBit	111.701	2346.829	8.372285
SumTraits	39.330	6665.307	23.778399
Sum128Base_Basic	900.977	290.955	1.037979
Sum128Base	902.723	290.392	1.035971
Sum128Traits	903.864	290.026	1.034664
Sum256Base_Basic	317.835	824.779	2.942391
Sum256Base	317.214	826.396	2.948156
Sum256Traits	39.552	6627.816	23.644652

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	933.985	280.673
SumBase	222.128	1180.150	4.204721
SumBase_Basic	556.743	470.853	1.677586
SumBase_ClearBit	226.332	1158.227	4.126612
SumTraits	80.044	3274.998	11.668394
Sum128Base_Basic	1638.136	160.026	0.570151
Sum128Base	1639.494	159.893	0.569679
Sum128Traits	1639.862	159.857	0.569551
Sum256Base_Basic	557.351	470.339	1.675756
Sum256Base	557.055	470.589	1.676649
Sum256Traits	79.702	3289.060	11.718494

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	954.118	274.750
SumBase	117.600	2229.120	8.113264
SumBase_Basic	343.054	764.149	2.781250
SumBase_ClearBit	114.739	2284.696	8.315541
SumTraits	43.132	6077.675	22.120740
Sum128Base_Basic	907.825	288.760	1.050993
Sum128Base	905.856	289.388	1.053277
Sum128Traits	902.271	290.538	1.057463
Sum256Base_Basic	317.101	826.688	3.008873
Sum256Base	317.257	826.284	3.007401
Sum256Traits	39.500	6636.605	24.155061

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	932.939	280.987
SumBase	99.019	2647.406	9.421805
SumBase_Add	107.535	2437.753	8.675672
SumTraits	79.751	3287.023	11.698125
Sum128Base_Basic	1640.602	159.785	0.568657
Sum128Base	1640.698	159.776	0.568624
Sum128Traits	1648.280	159.041	0.566008
Sum256Base_Basic	560.672	467.553	1.663965
Sum256Base	559.346	468.662	1.667912
Sum256Traits	79.809	3284.623	11.689582

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	943.068	277.969
SumBase	52.116	5029.993	18.095489
SumBase_Add	52.380	5004.617	18.004197
SumTraits	40.032	6548.433	23.558102
Sum128Base_Basic	911.278	287.666	1.034885
Sum128Base	912.145	287.393	1.033901
Sum128Traits	911.671	287.542	1.034439
Sum256Base_Basic	321.837	814.524	2.930263
Sum256Base	320.269	818.512	2.944611
Sum256Traits	39.677	6606.884	23.768380

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1216.267	215.532
SumBase	149.020	1759.115	8.161750
SumBase_ClearBit	149.271	1756.159	8.148035
SumBase_ClearBit_Not	139.267	1882.307	8.733326
SumTraits	86.563	3028.367	14.050689
Sum128Base_Basic	2452.429	106.892	0.495944
Sum128Base	2433.947	107.703	0.499710
Sum128Traits	2439.099	107.476	0.498654
Sum256Base_Basic	1376.292	190.471	0.883728
Sum256Base	1418.470	184.808	0.857450
Sum256Traits	85.551	3064.195	14.216920

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1146.511	228.645
SumBase	81.294	3224.626	14.103195
SumBase_ClearBit	78.895	3322.692	14.532096
SumTraits	42.119	6223.961	27.221062
Sum128Base_Basic	1681.193	155.927	0.681963
Sum128Base	1689.433	155.167	0.678636
Sum128Traits	1675.321	156.474	0.684353
Sum256Base_Basic	1344.085	195.035	0.853004
Sum256Base	1386.050	189.130	0.827178
Sum256Traits	39.447	6645.544	29.064893

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
SumScalar	934.225	280.601
SumBcl	79.882	3281.622	11.694994
SumBase	79.974	3277.855	11.681569
SumBase_Basic	531.633	493.092	1.757274
SumBase_ClearBit	218.617	1199.103	4.273346
SumTraits	84.974	3084.991	10.994243
Sum128Base_Basic	1643.261	159.527	0.568519
Sum128Base	1642.421	159.608	0.568810
Sum128Traits	1636.791	160.157	0.570766
Sum256Base_Basic	491.636	533.208	1.900237
Sum256Base	490.927	533.978	1.902981
Sum256Traits	80.107	3272.422	11.662208

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	934.178	280.615
SumBcl	39.474	6640.910	23.665585
SumBase	39.301	6670.143	23.769760
SumBase_Basic	331.292	791.277	2.819799
SumBase_ClearBit	109.423	2395.691	8.537299
SumTraits	39.442	6646.280	23.684723
Sum128Base_Basic	901.285	290.856	1.036495
Sum128Base	899.461	291.446	1.038598
Sum128Traits	903.159	290.252	1.034345
Sum256Base_Basic	296.201	885.020	3.153862
Sum256Base	296.583	883.882	3.149806
Sum256Traits	39.351	6661.724	23.739759

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	934.928	280.389
SumBcl	80.021	3275.930	11.683502
SumBase	80.289	3265.015	11.644573
SumBase_Basic	528.899	495.641	1.767687
SumBase_ClearBit	222.103	1180.281	4.209435
SumTraits	80.091	3273.062	11.673274
Sum128Base_Basic	1638.712	159.970	0.570526
Sum128Base	1638.294	160.010	0.570672
Sum128Traits	1639.004	159.941	0.570425
Sum256Base_Basic	490.480	534.464	1.906150
Sum256Base	490.444	534.503	1.906288
Sum256Traits	79.959	3278.468	11.692553

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	932.643	281.076
SumBcl	39.231	6682.069	23.773132
SumBase	39.242	6680.176	23.766400
SumBase_Basic	331.972	789.656	2.809398
SumBase_ClearBit	105.358	2488.120	8.852110
SumTraits	39.348	6662.188	23.702401
Sum128Base_Basic	899.352	291.481	1.037017
Sum128Base	900.662	291.057	1.035508
Sum128Traits	902.825	290.360	1.033027
Sum256Base_Basic	295.972	885.707	3.151123
Sum256Base	298.797	877.332	3.121329
Sum256Traits	39.881	6573.129	23.385553

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	940.735	278.659
SumBase	110.600	2370.208	8.505777
SumBase_Add	105.280	2489.979	8.935588
SumTraits	80.083	3273.420	11.747063
Sum128Base_Basic	1642.232	159.627	0.572839
Sum128Base	1638.665	159.974	0.574086
Sum128Traits	1644.464	159.410	0.572062
Sum256Base_Basic	490.324	534.635	1.918601
Sum256Base	491.383	533.483	1.914466
Sum256Traits	80.099	3272.761	11.744698

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	932.690	281.062
SumBase	47.721	5493.254	19.544601
SumBase_Add	47.667	5499.456	19.566671
SumTraits	39.294	6671.423	23.736443
Sum128Base_Basic	900.586	291.082	1.035647
Sum128Base	899.588	291.405	1.036796
Sum128Traits	900.744	291.031	1.035466
Sum256Base_Basic	295.890	885.952	3.152153
Sum256Base	295.793	886.243	3.153187
Sum256Traits	39.269	6675.537	23.751080

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1238.910	211.592
SumBase	91.465	2866.074	13.545255
SumBase_ClearBit	157.037	1669.318	7.889307
SumBase_ClearBit_Not	146.307	1791.734	8.467855
SumTraits	79.704	3288.974	15.543909
Sum128Base_Basic	2389.065	109.727	0.518575
Sum128Base	2388.298	109.762	0.518742
Sum128Traits	2399.948	109.229	0.516224
Sum256Base_Basic	1348.997	194.325	0.918394
Sum256Base	1412.414	185.600	0.877158
Sum256Traits	80.249	3266.645	15.438383

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1323.923	198.005
SumBase	45.936	5706.768	28.821271
SumBase_ClearBit	75.716	3462.184	17.485301
SumTraits	39.467	6642.112	33.545105
Sum128Base_Basic	2833.726	92.509	0.467202
Sum128Base	2855.220	91.812	0.463685
Sum128Traits	1674.178	156.581	0.790790
Sum256Base_Basic	1397.667	187.558	0.947238
Sum256Base	1387.544	188.927	0.954149
Sum256Traits	39.461	6643.102	33.550103

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
SumScalar	933.018	280.964
SumBcl	79.728	3287.961	11.702442
SumBase	80.089	3273.154	11.649742
SumBase_Basic	529.881	494.722	1.760806
SumBase_ClearBit	229.144	1144.015	4.071756
SumTraits	79.862	3282.474	11.682916
Sum128Base_Basic	1641.181	159.729	0.568504
Sum128Base	1638.796	159.961	0.569331
Sum128Traits	1638.950	159.946	0.569278
Sum256Base_Basic	494.249	530.389	1.887749
Sum256Base	489.585	535.441	1.905731
Sum256Traits	79.990	3277.204	11.664159

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	932.405	281.148
SumBcl	39.298	6670.602	23.726292
SumBase	39.284	6673.117	23.735235
SumBase_Basic	331.589	790.570	2.811934
SumBase_ClearBit	108.761	2410.265	8.572937
SumTraits	39.172	6692.145	23.802916
Sum128Base_Basic	899.496	291.434	1.036587
Sum128Base	901.822	290.683	1.033913
Sum128Traits	899.970	291.281	1.036040
Sum256Base_Basic	295.745	886.387	3.152739
Sum256Base	296.002	885.615	3.149996
Sum256Traits	39.214	6684.988	23.777459

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	935.764	280.139
SumBcl	80.663	3249.855	11.600871
SumBase	80.295	3264.749	11.654038
SumBase_Basic	531.530	493.188	1.760512
SumBase_ClearBit	223.945	1170.574	4.178548
SumTraits	79.956	3278.615	11.703534
Sum128Base_Basic	1638.343	160.006	0.571165
Sum128Base	1638.761	159.965	0.571019
Sum128Traits	1635.418	160.292	0.572187
Sum256Base_Basic	556.494	471.063	1.681535
Sum256Base	557.106	470.546	1.679689
Sum256Traits	79.846	3283.135	11.719666

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	931.674	281.369
SumBcl	39.323	6666.441	23.692889
SumBase	39.352	6661.500	23.675331
SumBase_Basic	341.455	767.726	2.728540
SumBase_ClearBit	108.826	2408.842	8.561154
SumTraits	39.345	6662.742	23.679743
Sum128Base_Basic	900.184	291.212	1.034982
Sum128Base	899.498	291.434	1.035771
Sum128Traits	899.758	291.349	1.035472
Sum256Base_Basic	316.899	827.215	2.939968
Sum256Base	317.150	826.563	2.937649
Sum256Traits	39.697	6603.559	23.469405

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	939.675	278.973
SumBase	103.901	2523.018	9.043951
SumBase_Add	105.310	2489.266	8.922962
SumTraits	80.303	3264.435	11.701616
Sum128Base_Basic	1637.510	160.087	0.573844
Sum128Base	1637.236	160.114	0.573940
Sum128Traits	1635.705	160.264	0.574477
Sum256Base_Basic	556.457	471.095	1.688675
Sum256Base	607.585	431.453	1.546574
Sum256Traits	93.681	2798.269	10.030605

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1165.668	224.887
SumBase	68.829	3808.650	16.935817
SumBase_Add	62.039	4225.448	18.789181
SumTraits	47.814	5482.529	24.379006
Sum128Base_Basic	1010.506	259.418	1.153549
Sum128Base	1034.193	253.477	1.127128
Sum128Traits	999.745	262.211	1.165966
Sum256Base_Basic	362.366	723.424	3.216827
Sum256Base	318.169	823.914	3.663675
Sum256Traits	39.907	6568.806	29.209324

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1216.655	215.463
SumBase	97.026	2701.802	12.539519
SumBase_ClearBit	165.295	1585.915	7.360501
SumBase_ClearBit_Not	150.936	1736.790	8.060736
SumTraits	84.215	3112.789	14.446982
Sum128Base_Basic	3099.649	84.572	0.392514
Sum128Base	2835.203	92.460	0.429124
Sum128Traits	2390.886	109.643	0.508872
Sum256Base_Basic	1409.887	185.933	0.862945
Sum256Base	1412.843	185.544	0.861139
Sum256Traits	80.740	3246.774	15.068829

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1264.070	207.381
SumBase	44.597	5878.066	28.344291
SumBase_ClearBit	79.019	3317.487	15.997065
SumTraits	43.240	6062.562	29.233937
Sum128Base_Basic	2802.618	93.535	0.451032
Sum128Base	1981.543	132.293	0.637922
Sum128Traits	1670.893	156.889	0.756524
Sum256Base_Basic	1352.032	193.889	0.934941
Sum256Base	1351.775	193.926	0.935118
Sum256Traits	39.300	6670.264	32.164306

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
SumScalar	933.637	280.777
SumBcl	80.895	3240.560	11.541395
SumBase	80.067	3274.040	11.660634
SumBase_Basic	528.065	496.423	1.768033
SumBase_ClearBit	213.702	1226.679	4.368870
SumTraits	79.752	3286.972	11.706695
Sum128Bcl	157.495	1664.454	5.928026
Sum128Base_Basic	860.421	304.670	1.085094
Sum128Base	158.263	1656.383	5.899280
Sum128Traits	158.200	1657.037	5.901611
Sum256Bcl	79.849	3283.009	11.692578
Sum256Base_Basic	491.530	533.323	1.899453
Sum256Base	79.913	3280.381	11.683220
Sum256Traits	79.616	3292.624	11.726822

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
SumScalar	933.047	280.955
SumBcl	39.216	6684.630	23.792552
SumBase	39.508	6635.149	23.616433
SumBase_Basic	341.658	767.269	2.730935
SumBase_ClearBit	107.148	2446.564	8.708037
SumTraits	39.935	6564.341	23.364407
Sum128Bcl	79.110	3313.678	11.794349
Sum128Base_Basic	472.489	554.815	1.974747
Sum128Base	79.138	3312.472	11.790057
Sum128Traits	79.200	3309.900	11.780901
Sum256Bcl	39.317	6667.508	23.731609
Sum256Base_Basic	317.437	825.813	2.939311
Sum256Base	39.375	6657.626	23.696436
Sum256Traits	39.362	6659.892	23.704503

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
SumScalar	933.592	280.791
SumBcl	80.428	3259.351	11.607761
SumBase	80.234	3267.249	11.635885
SumBase_Basic	552.306	474.636	1.690354
SumBase_ClearBit	217.184	1207.012	4.298619
SumTraits	80.224	3267.643	11.637290
Sum128Bcl	157.777	1661.483	5.917156
Sum128Base_Basic	863.215	303.683	1.081529
Sum128Base	157.776	1661.490	5.917181
Sum128Traits	158.597	1652.894	5.886571
Sum256Bcl	80.034	3275.423	11.664998
Sum256Base_Basic	557.352	470.339	1.675050
Sum256Base	81.151	3230.319	11.504366
Sum256Traits	80.137	3271.207	11.649981

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
SumScalar	936.419	279.943
SumBcl	39.846	6578.901	23.500860
SumBase	39.901	6569.919	23.468777
SumBase_Basic	346.407	756.751	2.703231
SumBase_ClearBit	109.595	2391.931	8.544350
SumTraits	39.416	6650.649	23.757155
Sum128Bcl	78.270	3349.219	11.963934
Sum128Base_Basic	468.311	559.764	1.999566
Sum128Base	78.218	3351.471	11.971977
Sum128Traits	78.316	3347.267	11.956961
Sum256Bcl	39.292	6671.611	23.832035
Sum256Base_Basic	316.646	827.878	2.957310
Sum256Base	39.342	6663.161	23.801850
Sum256Traits	39.319	6667.120	23.815991

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	935.310	280.275
SumBase	102.917	2547.145	9.088022
SumBase_Add	104.329	2512.668	8.965011
SumTraits	79.922	3280.012	11.702839
Sum128Base_Basic	861.659	304.232	1.085477
Sum128Base	160.631	1631.964	5.822727
Sum128Traits	160.375	1634.573	5.832033
Sum256Base_Basic	557.200	470.467	1.678590
Sum256Base	103.815	2525.098	9.009361
Sum256Traits	80.305	3264.343	11.646931

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	932.030	281.261
SumBase	51.376	5102.453	18.141318
SumBase_Add	55.161	4752.384	16.896680
SumTraits	39.734	6597.506	23.456844
Sum128Base_Basic	467.010	561.324	1.995736
Sum128Base	83.516	3138.839	11.159862
Sum128Traits	81.836	3203.265	11.388924
Sum256Base_Basic	317.030	826.875	2.939882
Sum256Base	50.394	5201.888	18.494850
Sum256Traits	39.230	6682.193	23.757944

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	934.817	280.423
SumBase	88.850	2950.425	10.521349
SumBase_ClearBit	148.480	1765.514	6.295904
SumBase_ClearBit_Not	137.636	1904.616	6.791947
SumTraits	79.845	3283.149	11.707856
Sum128Base_Basic	866.313	302.597	1.079076
Sum128Base	170.626	1536.364	5.478744
Sum128Traits	170.512	1537.393	5.482413
Sum256Base_Basic	559.770	468.307	1.670002
Sum256Base	91.162	2875.587	10.254471
Sum256Traits	79.576	3294.249	11.747442

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	933.272	280.887
SumBase	44.731	5860.498	20.864243
SumBase_ClearBit	73.575	3562.933	12.684571
SumTraits	39.727	6598.576	23.491911
Sum128Base_Basic	470.118	557.614	1.985187
Sum128Base	83.925	3123.550	11.120303
Sum128Traits	83.959	3122.297	11.115841
Sum256Base_Basic	319.264	821.090	2.923201
Sum256Base	43.800	5985.010	21.307526
Sum256Traits	39.771	6591.408	23.466393

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
SumScalar	290.579	902.145
SumBase	1233.147	212.581	0.235640
SumBase_Basic	547.181	479.081	0.531046
SumBase_ClearBit	1012.883	258.810	0.286883
SumTraits	545.467	480.587	0.532716
Sum128Base_Basic	1138.483	230.257	0.255233
Sum128Base	1146.582	228.631	0.253430
Sum128Traits	1142.859	229.376	0.254256
Sum256Base_Basic	1828.964	143.329	0.158876
Sum256Base	1825.679	143.587	0.159162
Sum256Traits	1826.196	143.547	0.159117

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	316.824	827.413
SumBase	499.016	525.322	0.634897
SumBase_Basic	797.568	328.679	0.397237
SumBase_ClearBit	498.527	525.837	0.635520
SumTraits	498.686	525.670	0.635317
Sum128Base_Basic	1460.743	179.459	0.216892
Sum128Base	1460.983	179.430	0.216856
Sum128Traits	1460.963	179.432	0.216859
Sum256Base_Basic	1288.434	203.459	0.245898
Sum256Base	1312.578	199.717	0.241375
Sum256Traits	1315.238	199.313	0.240887

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.565	902.188
SumBase	546.347	479.813	0.531832
SumBase_Basic	546.873	479.351	0.531320
SumBase_ClearBit	1012.021	259.030	0.287113
SumTraits	547.024	479.219	0.531174
Sum128Base_Basic	1139.943	229.962	0.254894
Sum128Base	1148.969	228.156	0.252892
Sum128Traits	1136.167	230.727	0.255741
Sum256Base_Basic	1825.826	143.576	0.159142
Sum256Base	1834.070	142.930	0.158426
Sum256Traits	1831.101	143.162	0.158683

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	290.747	901.623
SumBase	498.567	525.795	0.583165
SumBase_Basic	798.101	328.460	0.364298
SumBase_ClearBit	498.903	525.441	0.582772
SumTraits	498.745	525.607	0.582957
Sum128Base_Basic	1459.705	179.587	0.199182
Sum128Base	1460.575	179.480	0.199063
Sum128Traits	1460.211	179.525	0.199113
Sum256Base_Basic	1284.767	204.040	0.226303
Sum256Base	1308.840	200.287	0.222141
Sum256Traits	1309.915	200.123	0.221958

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	315.905	829.820
SumBase	357.472	733.326	0.883717
SumBase_Add	352.458	743.760	0.896290
SumTraits	352.470	743.733	0.896258
Sum128Base_Basic	1138.229	230.309	0.277540
Sum128Base	1152.141	227.528	0.274189
Sum128Traits	1136.509	230.657	0.277960
Sum256Base_Basic	1827.667	143.431	0.172846
Sum256Base	1827.191	143.468	0.172891
Sum256Traits	1843.397	142.207	0.171371

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	290.743	901.633
SumBase	170.661	1536.055	1.703635
SumBase_Add	170.592	1536.672	1.704321
SumTraits	170.597	1536.630	1.704274
Sum128Base_Basic	1459.539	179.607	0.199202
Sum128Base	1460.238	179.521	0.199107
Sum128Traits	1459.068	179.665	0.199267
Sum256Base_Basic	1285.836	203.871	0.226112
Sum256Base	1309.034	200.258	0.222105
Sum256Traits	1313.836	199.526	0.221293

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1618.128	162.005
SumBase	633.008	414.124	2.556253
SumBase_ClearBit	633.650	413.705	2.553662
SumBase_ClearBit_Not	546.719	479.486	2.959707
SumTraits	633.104	414.061	2.555864
Sum128Base_Basic	2215.407	118.328	0.730398
Sum128Base	2208.900	118.676	0.732549
Sum128Traits	2220.480	118.057	0.728729
Sum256Base_Basic	3260.781	80.393	0.496239
Sum256Base	3224.729	81.292	0.501787
Sum256Traits	3321.718	78.918	0.487136

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	1758.657	149.059
SumBase	310.792	843.472	5.658636
SumBase_ClearBit	311.208	842.343	5.651064
SumTraits	310.472	844.341	5.664465
Sum128Base_Basic	2369.444	110.635	0.742223
Sum128Base	2398.925	109.276	0.733102
Sum128Traits	2391.064	109.635	0.735512
Sum256Base_Basic	2791.996	93.891	0.629892
Sum256Base	2731.799	95.960	0.643772
Sum256Traits	2749.213	95.352	0.639695

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
SumScalar	315.777	830.155
SumBcl	124.912	2098.636	2.528006
SumBase	124.846	2099.741	2.529337
SumBase_Basic	550.672	476.044	0.573440
SumBase_ClearBit	881.269	297.462	0.358321
SumTraits	125.058	2096.185	2.525053
Sum128Base_Basic	557.657	470.081	0.566257
Sum128Base	560.474	467.718	0.563411
Sum128Traits	133.927	1957.363	2.357830
Sum256Base_Basic	1226.761	213.688	0.257407
Sum256Base	1224.617	214.062	0.257858
Sum256Traits	1223.543	214.250	0.258084

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	290.155	903.463
SumBcl	62.307	4207.301	4.656860
SumBase	62.399	4201.099	4.649996
SumBase_Basic	796.675	329.048	0.364207
SumBase_ClearBit	432.003	606.811	0.671650
SumTraits	66.542	3939.507	4.360451
Sum128Base_Basic	832.501	314.887	0.348534
Sum128Base	833.154	314.641	0.348261
Sum128Traits	62.489	4195.048	4.643298
Sum256Base_Basic	957.799	273.694	0.302939
Sum256Base	991.286	264.448	0.292705
Sum256Traits	990.583	264.636	0.292913

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.487	902.428
SumBcl	125.043	2096.432	2.323101
SumBase	124.994	2097.258	2.324016
SumBase_Basic	550.129	476.513	0.528035
SumBase_ClearBit	880.429	297.746	0.329938
SumTraits	133.076	1969.887	2.182874
Sum128Base_Basic	560.091	468.038	0.518643
Sum128Base	558.593	469.293	0.520034
Sum128Traits	125.669	2085.981	2.311520
Sum256Base_Basic	1232.420	212.707	0.235705
Sum256Base	1211.184	216.436	0.239837
Sum256Traits	1222.749	214.389	0.237569

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	290.186	903.367
SumBcl	66.649	3933.202	4.353937
SumBase	66.534	3939.988	4.361448
SumBase_Basic	799.974	327.691	0.362744
SumBase_ClearBit	432.097	606.678	0.671574
SumTraits	62.445	4197.987	4.647046
Sum128Base_Basic	833.119	314.654	0.348312
Sum128Base	831.947	315.097	0.348803
Sum128Traits	66.557	3938.614	4.359927
Sum256Base_Basic	957.965	273.647	0.302919
Sum256Base	989.352	264.965	0.293309
Sum256Traits	989.987	264.795	0.293121

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	290.556	902.215
SumBase	364.354	719.477	0.797456
SumBase_Add	362.591	722.975	0.801333
SumTraits	133.170	1968.485	2.181836
Sum128Base_Basic	556.523	471.039	0.522091
Sum128Base	555.676	471.757	0.522888
Sum128Traits	124.956	2097.891	2.325266
Sum256Base_Basic	1226.763	213.688	0.236848
Sum256Base	1218.864	215.072	0.238383
Sum256Traits	1222.620	214.412	0.237650

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	290.298	903.018
SumBase	177.946	1473.166	1.631381
SumBase_Add	179.658	1459.131	1.615838
SumTraits	66.563	3938.283	4.361246
Sum128Base_Basic	831.512	315.262	0.349120
Sum128Base	833.126	314.651	0.348444
Sum128Traits	62.464	4196.736	4.647457
Sum256Base_Basic	958.292	273.553	0.302932
Sum256Base	989.795	264.847	0.293291
Sum256Traits	989.731	264.864	0.293310

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1614.802	162.338
SumBase	241.354	1086.141	6.690606
SumBase_ClearBit	597.984	438.380	2.700411
SumBase_ClearBit_Not	531.836	492.904	3.036278
SumTraits	124.949	2098.006	12.923680
Sum128Base_Basic	1735.285	151.067	0.930569
Sum128Base	1674.739	156.528	0.964211
Sum128Traits	133.129	1969.101	12.129623
Sum256Base_Basic	2346.514	111.716	0.688171
Sum256Base	2226.425	117.742	0.725289
Sum256Traits	2258.213	116.085	0.715080

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1758.156	149.102
SumBase	121.981	2149.049	14.413309
SumBase_ClearBit	288.512	908.606	6.093871
SumTraits	66.428	3946.291	26.467111
Sum128Base_Basic	1688.765	155.228	1.041090
Sum128Base	1757.544	149.154	1.000348
Sum128Traits	62.315	4206.755	28.214001
Sum256Base_Basic	2306.726	113.643	0.762187
Sum256Base	2273.204	115.319	0.773426
Sum256Traits	2208.815	118.681	0.795973

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
SumScalar	316.095	829.321
SumBcl	133.222	1967.725	2.372694
SumBase	125.217	2093.522	2.524381
SumBase_Basic	550.282	476.381	0.574423
SumBase_ClearBit	824.439	317.966	0.383406
SumTraits	125.127	2095.023	2.526190
Sum128Base_Basic	558.022	469.773	0.566455
Sum128Base	559.946	468.160	0.564510
Sum128Traits	133.312	1966.395	2.371090
Sum256Base_Basic	1222.621	214.412	0.258539
Sum256Base	1220.958	214.703	0.258891
Sum256Traits	1219.810	214.906	0.259134

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	317.103	826.685
SumBcl	67.180	3902.126	4.720210
SumBase	62.994	4161.406	5.033848
SumBase_Basic	797.992	328.505	0.397376
SumBase_ClearBit	414.196	632.898	0.765585
SumTraits	72.708	3605.444	4.361327
Sum128Base_Basic	929.215	282.113	0.341259
Sum128Base	835.803	313.643	0.379399
Sum128Traits	63.075	4156.049	5.027368
Sum256Base_Basic	959.164	273.305	0.330603
Sum256Base	993.864	263.762	0.319060
Sum256Traits	987.572	265.443	0.321093

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	316.328	828.709
SumBcl	125.231	2093.284	2.525958
SumBase	133.407	1964.997	2.371155
SumBase_Basic	552.104	474.809	0.572951
SumBase_ClearBit	825.056	317.729	0.383402
SumTraits	133.372	1965.508	2.371771
Sum128Base_Basic	557.144	470.514	0.567767
Sum128Base	558.246	469.585	0.566647
Sum128Traits	125.255	2092.875	2.525464
Sum256Base_Basic	1225.340	213.936	0.258155
Sum256Base	1236.662	211.977	0.255792
Sum256Traits	1235.194	212.229	0.256096

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	291.529	899.204
SumBcl	62.887	4168.508	4.635776
SumBase	67.236	3898.864	4.335907
SumBase_Basic	799.077	328.059	0.364832
SumBase_ClearBit	396.724	660.771	0.734840
SumTraits	63.037	4158.603	4.624762
Sum128Base_Basic	835.414	313.789	0.348964
Sum128Base	833.482	314.517	0.349772
Sum128Traits	67.103	3906.602	4.344512
Sum256Base_Basic	960.886	272.815	0.303396
Sum256Base	993.674	263.813	0.293385
Sum256Traits	991.285	264.449	0.294092

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	316.133	829.222
SumBase	350.206	748.542	0.902704
SumBase_Add	349.352	750.372	0.904911
SumTraits	125.251	2092.953	2.523997
Sum128Base_Basic	558.416	469.442	0.566124
Sum128Base	561.650	466.739	0.562864
Sum128Traits	133.701	1960.680	2.364482
Sum256Base_Basic	1226.591	213.717	0.257733
Sum256Base	1223.645	214.232	0.258353
Sum256Traits	1229.892	213.144	0.257041

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
SumScalar	316.827	827.404
SumBase	212.545	1233.356	1.490633
SumBase_Add	212.363	1234.412	1.491909
SumTraits	67.070	3908.499	4.723809
Sum128Base_Basic	833.893	314.362	0.379937
Sum128Base	834.970	313.956	0.379447
Sum128Traits	63.013	4160.178	5.027987
Sum256Base_Basic	959.363	273.248	0.330247
Sum256Base	992.458	264.136	0.319235
Sum256Traits	991.504	264.390	0.319542

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1942.841	134.928
SumBase	246.248	1064.551	7.889759
SumBase_ClearBit	556.040	471.448	3.494066
SumBase_ClearBit_Not	485.808	539.604	3.999197
SumTraits	133.970	1956.730	14.502008
Sum128Base_Basic	2053.869	127.634	0.945942
Sum128Base	2086.936	125.612	0.930954
Sum128Traits	125.318	2091.834	15.503307
Sum256Base_Basic	2648.533	98.977	0.733553
Sum256Base	2538.212	103.279	0.765437
Sum256Traits	2509.374	104.466	0.774233

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
SumScalar	1875.956	139.739
SumBase	144.675	1811.947	12.966664
SumBase_ClearBit	266.791	982.581	7.031551
SumTraits	62.931	4165.602	29.809909
Sum128Base_Basic	2078.484	126.123	0.902560
Sum128Base	2126.227	123.291	0.882294
Sum128Traits	66.981	3913.729	28.007452
Sum256Base_Basic	2586.557	101.349	0.725272
Sum256Base	2511.807	104.365	0.746855
Sum256Traits	2518.012	104.108	0.745015

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
SumScalar	210.690	1244.215
SumBcl	106.343	2465.070	1.981224
SumBase	106.304	2465.979	1.981956
SumBase_Basic	548.225	478.169	0.384313
SumBase_ClearBit	729.294	359.449	0.288896
SumTraits	106.883	2452.616	1.971215
Sum128Bcl	106.271	2466.755	1.982579
Sum128Base_Basic	555.074	472.269	0.379571
Sum128Base	106.395	2463.874	1.980263
Sum128Traits	106.190	2468.621	1.984079
Sum256Bcl	968.750	270.600	0.217487
Sum256Base_Basic	1155.765	226.814	0.182295
Sum256Base	1149.923	227.967	0.183221
Sum256Traits	1149.912	227.969	0.183223

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
SumScalar	211.505	1239.420
SumBcl	55.543	4719.618	3.807926
SumBase	55.601	4714.777	3.804020
SumBase_Basic	801.064	327.245	0.264030
SumBase_ClearBit	384.869	681.125	0.549552
SumTraits	55.527	4721.042	3.809075
Sum128Bcl	55.587	4715.941	3.804959
Sum128Base_Basic	805.893	325.284	0.262449
Sum128Base	55.567	4717.625	3.806318
Sum128Traits	55.583	4716.239	3.805200
Sum256Bcl	901.632	290.744	0.234581
Sum256Base_Basic	1009.208	259.752	0.209576
Sum256Base	936.398	279.949	0.225871
Sum256Traits	936.266	279.989	0.225903

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
SumScalar	210.657	1244.412
SumBcl	106.384	2464.127	1.980154
SumBase	106.411	2463.502	1.979652
SumBase_Basic	548.129	478.253	0.384320
SumBase_ClearBit	734.186	357.054	0.286926
SumTraits	106.253	2467.170	1.982600
Sum128Bcl	106.379	2464.247	1.980251
Sum128Base_Basic	557.069	470.577	0.378152
Sum128Base	106.958	2450.914	1.969537
Sum128Traits	106.447	2462.675	1.978987
Sum256Bcl	967.197	271.035	0.217801
Sum256Base_Basic	1157.563	226.462	0.181983
Sum256Base	1150.400	227.872	0.183116
Sum256Traits	1149.792	227.993	0.183213

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
SumScalar	211.277	1240.762
SumBcl	55.571	4717.272	3.801916
SumBase	55.570	4717.366	3.801993
SumBase_Basic	801.994	326.865	0.263439
SumBase_ClearBit	388.400	674.934	0.543967
SumTraits	55.673	4708.653	3.794970
Sum128Bcl	55.670	4708.891	3.795161
Sum128Base_Basic	805.914	325.276	0.262158
Sum128Base	55.570	4717.386	3.802009
Sum128Traits	55.470	4725.838	3.808821
Sum256Bcl	900.322	291.167	0.234668
Sum256Base_Basic	1013.087	258.758	0.208547
Sum256Base	938.875	279.211	0.225032
Sum256Traits	937.892	279.503	0.225268

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.673	1244.318
SumBase	418.531	626.343	0.503363
SumBase_Add	418.607	626.229	0.503271
SumTraits	106.345	2465.034	1.981033
Sum128Base_Basic	556.003	471.480	0.378906
Sum128Base	256.339	1022.644	0.821851
Sum128Traits	106.348	2464.956	1.980970
Sum256Base_Basic	1150.940	227.765	0.183044
Sum256Base	5269.439	49.748	0.039980
Sum256Traits	5269.390	49.748	0.039981

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	211.333	1240.429
SumBase	171.602	1527.630	1.231533
SumBase_Add	171.539	1528.189	1.231984
SumTraits	55.572	4717.182	3.802862
Sum128Base_Basic	806.084	325.207	0.262173
Sum128Base	141.970	1846.475	1.488577
Sum128Traits	55.661	4709.683	3.796816
Sum256Base_Basic	1012.493	258.910	0.208726
Sum256Base	3977.370	65.909	0.053134
Sum256Traits	3974.294	65.960	0.053175

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.663	1244.374
SumBase	271.465	965.665	0.776025
SumBase_ClearBit	494.549	530.067	0.425971
SumBase_ClearBit_Not	432.988	605.431	0.486534
SumTraits	106.337	2465.230	1.981101
Sum128Base_Basic	554.988	472.341	0.379582
Sum128Base	163.924	1599.179	1.285127
Sum128Traits	106.340	2465.142	1.981030
Sum256Base_Basic	1150.102	227.931	0.183169
Sum256Base	3182.326	82.375	0.066198
Sum256Traits	3183.503	82.345	0.066173

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	211.482	1239.554
SumBase	114.956	2280.380	1.839678
SumBase_ClearBit	259.229	1011.245	0.815814
SumTraits	55.646	4710.957	3.800525
Sum128Base_Basic	809.441	323.858	0.261270
Sum128Base	95.395	2747.993	2.216921
Sum128Traits	55.592	4715.503	3.804193
Sum256Base_Basic	1012.668	258.865	0.208837
Sum256Base	2244.312	116.804	0.094230
Sum256Traits	2251.795	116.416	0.093917

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

