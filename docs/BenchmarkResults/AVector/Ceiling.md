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
SumScalar	543.557	482.275
SumBase	312.917	837.742	1.737063
SumBase_Basic	902.915	290.331	0.602002
SumBase_ClearBit	311.238	842.261	1.746433
SumTraits	335.088	782.315	1.622134

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	1325.857	197.717
SumBase	166.566	1573.813	7.959940
SumBase_Basic	1121.410	233.763	1.182312
SumBase_ClearBit	163.871	1599.699	8.090862
SumTraits	152.841	1715.142	8.674747

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	514.157	509.852
SumBase	314.909	832.444	1.632718
SumBase_Basic	884.653	296.324	0.581197
SumBase_ClearBit	314.842	832.620	1.633063
SumTraits	312.427	839.057	1.645689

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	1329.958	197.107
SumBase	154.076	1701.395	8.631836
SumBase_Basic	1125.969	232.816	1.181167
SumBase_ClearBit	164.518	1593.406	8.083964
SumTraits	163.899	1599.429	8.114519

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1313.613	199.560
SumBase	233.601	1122.188	5.623323
SumBase_ClearBit	230.911	1135.259	5.688825
SumTraits	237.697	1102.849	5.526414

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	2025.829	129.401
SumBase	114.065	2298.194	17.760272
SumBase_ClearBit	127.400	2057.648	15.901350
SumTraits	125.972	2080.963	16.081528

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
SumScalar	933.483	280.823
SumBase	304.360	861.297	3.067040
SumBase_Basic	558.051	469.749	1.672757
SumBase_ClearBit	301.672	868.971	3.094369
SumTraits	336.966	777.954	2.770261

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	936.362	279.960
SumBase	168.290	1557.696	5.563991
SumBase_Basic	572.195	458.137	1.636438
SumBase_ClearBit	170.039	1541.672	5.506755
SumTraits	171.692	1526.830	5.453742

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	933.580	280.794
SumBase	324.279	808.390	2.878938
SumBase_Basic	554.240	472.979	1.684432
SumBase_ClearBit	329.305	796.053	2.835004
SumTraits	331.128	791.669	2.819388

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	931.342	281.469
SumBase	170.404	1538.366	5.465485
SumBase_Basic	570.254	459.697	1.633205
SumBase_ClearBit	168.749	1553.454	5.519090
SumTraits	169.407	1547.420	5.497653

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1249.429	209.811
SumBase	240.504	1089.976	5.195037
SumBase_ClearBit	230.569	1136.943	5.418889
SumTraits	237.324	1104.581	5.264645

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	1193.164	219.705
SumBase	123.211	2127.599	9.683892
SumBase_ClearBit	125.193	2093.915	9.530577
SumTraits	124.076	2112.770	9.616397

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
SumScalar	933.341	280.866
SumBase	265.212	988.431	3.519221
SumBase_Basic	532.822	491.992	1.751693
SumBase_ClearBit	278.104	942.610	3.356079
SumTraits	80.172	3269.782	11.641771
Sum128Base_Basic	1646.522	159.211	0.566856
Sum128Base	1645.192	159.340	0.567314
Sum128Traits	1646.355	159.227	0.566913
Sum256Base_Basic	490.311	534.649	1.903570
Sum256Base	490.491	534.452	1.902869
Sum256Traits	81.065	3233.767	11.513545

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	935.606	280.186
SumBase	148.197	1768.893	6.313272
SumBase_Basic	331.088	791.766	2.825854
SumBase_ClearBit	149.334	1755.417	6.265174
SumTraits	40.442	6482.013	23.134646
Sum128Base_Basic	903.900	290.014	1.035077
Sum128Base	899.866	291.315	1.039717
Sum128Traits	901.838	290.677	1.037443
Sum256Base_Basic	284.309	922.040	3.290809
Sum256Base	283.830	923.596	3.296362
Sum256Traits	39.634	6614.054	23.605908

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	933.169	280.918
SumBase	273.393	958.854	3.413291
SumBase_Basic	534.233	490.692	1.746746
SumBase_ClearBit	270.217	970.125	3.453413
SumTraits	80.570	3253.632	11.582146
Sum128Base_Basic	1643.627	159.491	0.567750
Sum128Base	1647.504	159.116	0.566414
Sum128Traits	1639.390	159.903	0.569218
Sum256Base_Basic	489.987	535.002	1.904478
Sum256Base	491.087	533.803	1.900211
Sum256Traits	82.987	3158.848	11.244738

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	936.827	279.821
SumBase	149.933	1748.402	6.248283
SumBase_Basic	331.661	790.398	2.824654
SumBase_ClearBit	149.965	1748.031	6.246958
SumTraits	40.180	6524.271	23.315861
Sum128Base_Basic	903.728	290.069	1.036625
Sum128Base	900.571	291.086	1.040258
Sum128Traits	900.634	291.066	1.040186
Sum256Base_Basic	283.889	923.402	3.299973
Sum256Base	283.473	924.758	3.304817
Sum256Traits	39.562	6626.080	23.679697

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1259.520	208.130
SumBase	236.326	1109.248	5.329591
SumBase_ClearBit	233.843	1121.027	5.386182
SumTraits	82.006	3196.657	15.358935
Sum128Base_Basic	2353.874	111.367	0.535084
Sum128Base	2354.179	111.353	0.535014
Sum128Traits	2339.985	112.028	0.538260
Sum256Base_Basic	1361.254	192.575	0.925265
Sum256Base	1467.547	178.627	0.858248
Sum256Traits	83.274	3147.959	15.124958

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1330.010	197.099
SumBase	115.190	2275.745	11.546189
SumBase_ClearBit	113.892	2301.685	11.677797
SumTraits	41.808	6270.162	31.812203
Sum128Base_Basic	1894.004	138.407	0.702221
Sum128Base	1770.207	148.087	0.751330
Sum128Traits	1747.868	149.979	0.760933
Sum256Base_Basic	1469.974	178.332	0.904785
Sum256Base	1432.198	183.036	0.928649
Sum256Traits	39.346	6662.604	33.803292

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
SumScalar	934.527	280.510
SumBcl	80.255	3266.401	11.644512
SumBase	82.558	3175.265	11.319620
SumBase_Basic	531.856	492.885	1.757105
SumBase_ClearBit	260.390	1006.734	3.588943
SumTraits	81.785	3205.282	11.426628
Sum128Base_Basic	1654.549	158.438	0.564823
Sum128Base	1653.944	158.496	0.565029
Sum128Traits	1658.259	158.084	0.563559
Sum256Base_Basic	494.783	529.816	1.888762
Sum256Base	491.394	533.470	1.901787
Sum256Traits	83.418	3142.532	11.202927

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	931.537	281.410
SumBcl	40.138	6531.020	23.208181
SumBase	39.371	6658.358	23.660681
SumBase_Basic	333.226	786.686	2.795512
SumBase_ClearBit	135.842	1929.777	6.857522
SumTraits	40.199	6521.122	23.173007
Sum128Base_Basic	898.687	291.697	1.036553
Sum128Base	899.205	291.529	1.035956
Sum128Traits	902.541	290.451	1.032127
Sum256Base_Basic	283.778	923.764	3.282623
Sum256Base	289.871	904.348	3.213630
Sum256Traits	39.433	6647.839	23.623299

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	933.128	280.930
SumBcl	82.182	3189.789	11.354380
SumBase	80.383	3261.170	11.608468
SumBase_Basic	530.112	494.507	1.760248
SumBase_ClearBit	263.790	993.759	3.537385
SumTraits	80.185	3269.227	11.637147
Sum128Base_Basic	1643.128	159.540	0.567898
Sum128Base	1643.274	159.525	0.567847
Sum128Traits	1636.361	160.199	0.570246
Sum256Base_Basic	489.145	535.923	1.907671
Sum256Base	490.198	534.772	1.903574
Sum256Traits	80.603	3252.292	11.576865

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	932.092	281.243
SumBcl	39.350	6661.786	23.686970
SumBase	39.253	6678.264	23.745561
SumBase_Basic	331.791	790.088	2.809274
SumBase_ClearBit	131.355	1995.694	7.095987
SumTraits	40.732	6435.838	22.883578
Sum128Base_Basic	897.468	292.093	1.038580
Sum128Base	897.937	291.940	1.038038
Sum128Traits	897.992	291.923	1.037974
Sum256Base_Basic	282.978	926.375	3.293865
Sum256Base	282.859	926.764	3.295248
Sum256Traits	40.180	6524.273	23.198022

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1255.135	208.857
SumBase	98.437	2663.074	12.750693
SumBase_ClearBit	204.320	1283.005	6.142977
SumTraits	82.196	3189.266	15.270079
Sum128Base_Basic	2353.995	111.361	0.533194
Sum128Base	2351.960	111.458	0.533655
Sum128Traits	2337.505	112.147	0.536955
Sum256Base_Basic	1472.747	177.997	0.852241
Sum256Base	1331.170	196.928	0.942881
Sum256Traits	80.418	3259.776	15.607677

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1170.384	223.981
SumBase	47.030	5573.932	24.885704
SumBase_ClearBit	97.856	2678.881	11.960289
SumTraits	40.395	6489.491	28.973364
Sum128Base_Basic	1726.302	151.853	0.677971
Sum128Base	1759.350	149.000	0.665236
Sum128Traits	1743.080	150.391	0.671446
Sum256Base_Basic	1363.100	192.315	0.858619
Sum256Base	1336.021	196.213	0.876022
Sum256Traits	41.271	6351.820	28.358711

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
SumScalar	935.811	280.125
SumBcl	81.443	3218.731	11.490346
SumBase	81.437	3218.991	11.491273
SumBase_Basic	554.916	472.403	1.686402
SumBase_ClearBit	286.317	915.573	3.268447
SumTraits	81.341	3222.768	11.504756
Sum128Base_Basic	1638.047	160.034	0.571297
Sum128Base	1638.918	159.949	0.570993
Sum128Traits	1644.578	159.399	0.569028
Sum256Base_Basic	557.717	470.031	1.677934
Sum256Base	557.272	470.406	1.679272
Sum256Traits	80.061	3274.315	11.688771

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	931.808	281.328
SumBcl	39.376	6657.462	23.664388
SumBase	39.262	6676.796	23.733115
SumBase_Basic	341.621	767.354	2.727612
SumBase_ClearBit	136.091	1926.243	6.846958
SumTraits	39.270	6675.368	23.728037
Sum128Base_Basic	899.213	291.526	1.036249
Sum128Base	899.938	291.291	1.035413
Sum128Traits	899.466	291.444	1.035957
Sum256Base_Basic	316.915	827.174	2.940243
Sum256Base	317.780	824.923	2.932244
Sum256Traits	40.484	6475.313	23.016927

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	934.243	280.595
SumBcl	80.012	3276.323	11.676335
SumBase	81.196	3228.532	11.506016
SumBase_Basic	556.404	471.140	1.679074
SumBase_ClearBit	282.999	926.306	3.301220
SumTraits	80.998	3236.438	11.534192
Sum128Base_Basic	1639.530	159.890	0.569823
Sum128Base	1638.972	159.944	0.570018
Sum128Traits	1640.122	159.832	0.569618
Sum256Base_Basic	489.953	535.039	1.906801
Sum256Base	491.628	533.216	1.900302
Sum256Traits	82.412	3180.895	11.336244

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	932.559	281.102
SumBcl	39.290	6672.041	23.735314
SumBase	39.269	6675.607	23.748002
SumBase_Basic	331.436	790.935	2.813695
SumBase_ClearBit	137.275	1909.633	6.793383
SumTraits	39.631	6614.600	23.530972
Sum128Base_Basic	898.639	291.712	1.037746
Sum128Base	899.596	291.402	1.036642
Sum128Traits	898.112	291.883	1.038355
Sum256Base_Basic	283.186	925.696	3.293097
Sum256Base	284.302	922.060	3.280164
Sum256Traits	40.539	6466.515	23.004173

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1181.259	221.919
SumBase	92.590	2831.232	12.757949
SumBase_ClearBit	202.397	1295.200	5.836362
SumTraits	80.227	3267.531	14.723975
Sum128Base_Basic	2343.473	111.861	0.504064
Sum128Base	2342.289	111.918	0.504318
Sum128Traits	2340.182	112.019	0.504772
Sum256Base_Basic	1379.236	190.065	0.856459
Sum256Base	1477.014	177.482	0.799762
Sum256Traits	83.798	3128.296	14.096563

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1352.444	193.830
SumBase	48.183	5440.569	28.068791
SumBase_ClearBit	106.749	2455.694	12.669328
SumTraits	39.251	6678.724	34.456636
Sum128Base_Basic	1638.209	160.019	0.825563
Sum128Base	1711.869	153.133	0.790039
Sum128Traits	1683.764	155.689	0.803226
Sum256Base_Basic	1392.978	188.190	0.970901
Sum256Base	1389.179	188.704	0.973557
Sum256Traits	40.593	6457.931	33.317529

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
SumScalar	933.682	280.764
SumBcl	83.076	3155.485	11.238941
SumBase	82.795	3166.182	11.277039
SumBase_Basic	568.346	461.240	1.642807
SumBase_ClearBit	252.340	1038.853	3.700099
SumTraits	80.569	3253.642	11.588547
Sum128Bcl	160.589	1632.390	5.814109
Sum128Base_Basic	858.301	305.422	1.087826
Sum128Base	157.882	1660.374	5.913781
Sum128Traits	158.320	1655.790	5.897452
Sum256Bcl	81.707	3208.348	11.427223
Sum256Base_Basic	556.671	470.914	1.677262
Sum256Base	82.101	3192.930	11.372310
Sum256Traits	84.871	3088.733	11.001188

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
SumScalar	931.662	281.372
SumBcl	41.194	6363.590	22.616248
SumBase	40.952	6401.239	22.750053
SumBase_Basic	340.986	768.782	2.732256
SumBase_ClearBit	123.285	2126.333	7.557004
SumTraits	39.198	6687.620	23.767854
Sum128Bcl	78.277	3348.945	11.902176
Sum128Base_Basic	468.264	559.821	1.989607
Sum128Base	78.177	3353.196	11.917284
Sum128Traits	78.218	3351.432	11.911016
Sum256Bcl	41.445	6325.050	22.479278
Sum256Base_Basic	283.454	924.819	3.286813
Sum256Base	39.295	6671.235	23.709620
Sum256Traits	39.217	6684.442	23.756560

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
SumScalar	933.027	280.961
SumBcl	83.474	3140.427	11.177455
SumBase	80.507	3256.175	11.589428
SumBase_Basic	550.496	476.196	1.694885
SumBase_ClearBit	254.976	1028.112	3.659273
SumTraits	82.668	3171.064	11.286499
Sum128Bcl	157.512	1664.275	5.923513
Sum128Base_Basic	859.509	304.993	1.085535
Sum128Base	158.442	1654.507	5.888747
Sum128Traits	158.231	1656.712	5.896595
Sum256Bcl	81.478	3217.347	11.451231
Sum256Base_Basic	490.300	534.661	1.902972
Sum256Base	80.085	3273.311	11.650417
Sum256Traits	83.695	3132.149	11.147992

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
SumScalar	932.091	281.243
SumBcl	41.132	6373.250	22.661021
SumBase	41.636	6296.048	22.386519
SumBase_Basic	341.150	768.413	2.732205
SumBase_ClearBit	123.144	2128.762	7.569124
SumTraits	39.304	6669.643	23.714891
Sum128Bcl	78.245	3350.284	11.912427
Sum128Base_Basic	467.555	560.670	1.993543
Sum128Base	78.329	3346.684	11.899624
Sum128Traits	78.179	3353.125	11.922528
Sum256Bcl	39.221	6683.729	23.764976
Sum256Base_Basic	284.125	922.635	3.280564
Sum256Base	39.388	6655.444	23.664404
Sum256Traits	40.750	6433.018	22.873535

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	937.578	279.597
SumBase	101.292	2588.000	9.256179
SumBase_ClearBit	186.865	1402.854	5.017414
SumTraits	85.301	3073.152	10.991365
Sum128Base_Basic	858.300	305.422	1.092366
Sum128Base	160.648	1631.794	5.836238
Sum128Traits	162.427	1613.917	5.772296
Sum256Base_Basic	490.235	534.732	1.912509
Sum256Base	91.375	2868.874	10.260748
Sum256Traits	84.552	3100.370	11.088710

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	931.628	281.383
SumBase	44.478	5893.726	20.945576
SumBase_ClearBit	94.574	2771.852	9.850820
SumTraits	41.408	6330.733	22.498645
Sum128Base_Basic	468.158	559.947	1.989984
Sum128Base	86.852	3018.283	10.726608
Sum128Traits	84.438	3104.572	11.033265
Sum256Base_Basic	283.794	923.712	3.282757
Sum256Base	43.147	6075.636	21.592062
Sum256Traits	39.790	6588.136	23.413424

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
SumScalar	317.415	825.870
SumBase	1425.581	183.886	0.222657
SumBase_Basic	550.705	476.015	0.576380
SumBase_ClearBit	1424.057	184.082	0.222895
SumTraits	1427.687	183.615	0.222328
Sum128Base_Basic	1144.306	229.085	0.277387
Sum128Base	1143.348	229.277	0.277619
Sum128Traits	1144.957	228.955	0.277229
Sum256Base_Basic	1579.556	165.961	0.200952
Sum256Base	1574.924	166.449	0.201543
Sum256Traits	1578.063	166.118	0.201142

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	317.391	825.935
SumBase	702.410	373.206	0.451859
SumBase_Basic	801.799	326.945	0.395848
SumBase_ClearBit	702.861	372.967	0.451569
SumTraits	710.849	368.776	0.446495
Sum128Base_Basic	1464.266	179.028	0.216757
Sum128Base	1461.772	179.333	0.217127
Sum128Traits	1462.162	179.285	0.217069
Sum256Base_Basic	1180.012	222.154	0.268972
Sum256Base	1181.852	221.808	0.268554
Sum256Traits	1182.128	221.756	0.268491

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	291.616	898.935
SumBase	1427.035	183.698	0.204351
SumBase_Basic	542.849	482.904	0.537195
SumBase_ClearBit	1425.442	183.904	0.204579
SumTraits	1426.509	183.766	0.204426
Sum128Base_Basic	1146.530	228.641	0.254347
Sum128Base	1144.406	229.065	0.254819
Sum128Traits	1152.850	227.388	0.252952
Sum256Base_Basic	1576.067	166.328	0.185028
Sum256Base	1575.633	166.374	0.185079
Sum256Traits	1574.965	166.444	0.185157

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	317.324	826.108
SumBase	703.040	372.872	0.451360
SumBase_Basic	799.874	327.732	0.396718
SumBase_ClearBit	701.540	373.669	0.452325
SumTraits	702.144	373.348	0.451935
Sum128Base_Basic	1466.911	178.705	0.216321
Sum128Base	1466.785	178.720	0.216340
Sum128Traits	1465.217	178.911	0.216571
Sum256Base_Basic	1179.241	222.299	0.269092
Sum256Base	1178.415	222.455	0.269280
Sum256Traits	1177.114	222.701	0.269578

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1917.380	136.720
SumBase	1088.600	240.808	1.761326
SumBase_ClearBit	1090.814	240.320	1.757751
SumTraits	1086.762	241.216	1.764306
Sum128Base_Basic	2397.913	109.322	0.799604
Sum128Base	2386.415	109.848	0.803456
Sum128Traits	2397.264	109.351	0.799820
Sum256Base_Basic	2992.419	87.603	0.640746
Sum256Base	2996.992	87.469	0.639768
Sum256Traits	3083.842	85.006	0.621750

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	1970.959	133.003
SumBase	543.331	482.475	3.627545
SumBase_ClearBit	543.256	482.542	3.628050
SumTraits	542.354	483.345	3.634081
Sum128Base_Basic	2742.543	95.584	0.718661
Sum128Base	2703.910	96.950	0.728929
Sum128Traits	2708.918	96.771	0.727582
Sum256Base_Basic	2569.252	102.031	0.767133
Sum256Base	2560.439	102.382	0.769774
Sum256Traits	2592.450	101.118	0.760269

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
SumScalar	317.599	825.392
SumBcl	125.958	2081.194	2.521460
SumBase	125.462	2089.422	2.531429
SumBase_Basic	545.586	480.482	0.582125
SumBase_ClearBit	1047.539	250.247	0.303186
SumTraits	133.946	1957.083	2.371095
Sum128Base_Basic	562.148	466.326	0.564975
Sum128Base	559.684	468.379	0.567462
Sum128Traits	126.106	2078.758	2.518509
Sum256Base_Basic	1083.458	241.951	0.293135
Sum256Base	1077.348	243.323	0.294797
Sum256Traits	1073.017	244.305	0.295987

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	316.716	827.696
SumBcl	63.008	4160.499	5.026605
SumBase	63.200	4147.838	5.011309
SumBase_Basic	803.614	326.206	0.394114
SumBase_ClearBit	513.825	510.181	0.616387
SumTraits	62.898	4167.739	5.035353
Sum128Base_Basic	830.397	315.685	0.381403
Sum128Base	831.679	315.199	0.380815
Sum128Traits	66.979	3913.840	4.728599
Sum256Base_Basic	886.010	295.870	0.357463
Sum256Base	887.731	295.297	0.356770
Sum256Traits	886.843	295.592	0.357127

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	291.290	899.943
SumBcl	126.110	2078.686	2.309798
SumBase	125.371	2090.952	2.323428
SumBase_Basic	546.209	479.934	0.533294
SumBase_ClearBit	1050.234	249.605	0.277357
SumTraits	126.359	2074.592	2.305248
Sum128Base_Basic	563.222	465.436	0.517184
Sum128Base	563.136	465.508	0.517263
Sum128Traits	134.404	1950.419	2.167270
Sum256Base_Basic	1084.251	241.774	0.268655
Sum256Base	1080.878	242.529	0.269494
Sum256Traits	1084.256	241.773	0.268654

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	293.744	892.425
SumBcl	67.548	3880.862	4.348673
SumBase	67.678	3873.416	4.340329
SumBase_Basic	805.223	325.555	0.364798
SumBase_ClearBit	516.127	507.906	0.569130
SumTraits	63.131	4152.355	4.652892
Sum128Base_Basic	838.182	312.753	0.350453
Sum128Base	834.005	314.320	0.352209
Sum128Traits	67.727	3870.573	4.337143
Sum256Base_Basic	891.597	294.016	0.329458
Sum256Base	889.995	294.546	0.330051
Sum256Traits	890.183	294.483	0.329981

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1622.062	161.612
SumBase	260.071	1007.969	6.236984
SumBase_ClearBit	795.302	329.616	2.039555
SumTraits	134.890	1943.397	12.025109
Sum128Base_Basic	1734.848	151.105	0.934988
Sum128Base	1733.761	151.200	0.935574
Sum128Traits	126.911	2065.580	12.781136
Sum256Base_Basic	2338.869	112.082	0.693524
Sum256Base	2117.956	123.772	0.765862
Sum256Traits	2157.492	121.504	0.751827

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1658.145	158.095
SumBase	129.249	2028.216	12.829113
SumBase_ClearBit	391.009	670.430	4.240685
SumTraits	67.274	3896.663	24.647639
Sum128Base_Basic	1786.226	146.759	0.928295
Sum128Base	1864.590	140.591	0.889281
Sum128Traits	63.377	4136.294	26.163382
Sum256Base_Basic	2020.438	129.746	0.820686
Sum256Base	2046.586	128.088	0.810200
Sum256Traits	2051.357	127.791	0.808316

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
SumScalar	293.596	892.874
SumBcl	126.220	2076.887	2.326070
SumBase	134.554	1948.247	2.181997
SumBase_Basic	544.111	481.784	0.539588
SumBase_ClearBit	1008.343	259.975	0.291167
SumTraits	134.133	1954.358	2.188841
Sum128Base_Basic	563.996	464.798	0.520564
Sum128Base	565.782	463.331	0.518921
Sum128Traits	125.714	2085.235	2.335420
Sum256Base_Basic	1076.439	243.529	0.272747
Sum256Base	1079.211	242.903	0.272047
Sum256Traits	1076.347	243.550	0.272771

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	318.914	821.989
SumBcl	62.930	4165.649	5.067770
SumBase	67.335	3893.144	4.736251
SumBase_Basic	804.399	325.888	0.396463
SumBase_ClearBit	499.787	524.511	0.638100
SumTraits	66.977	3913.935	4.761544
Sum128Base_Basic	833.830	314.385	0.382469
Sum128Base	833.395	314.550	0.382669
Sum128Traits	62.532	4192.164	5.100027
Sum256Base_Basic	881.740	297.303	0.361688
Sum256Base	882.455	297.062	0.361395
Sum256Traits	882.552	297.030	0.361355

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.427	902.614
SumBcl	133.178	1968.370	2.180743
SumBase	124.973	2097.607	2.323924
SumBase_Basic	548.859	477.617	0.529148
SumBase_ClearBit	991.789	264.314	0.292832
SumTraits	124.895	2098.917	2.325375
Sum128Base_Basic	558.768	469.147	0.519764
Sum128Base	563.189	465.464	0.515684
Sum128Traits	133.621	1961.848	2.173517
Sum256Base_Basic	1070.463	244.889	0.271310
Sum256Base	1070.778	244.816	0.271230
Sum256Traits	1069.915	245.014	0.271449

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	316.552	828.124
SumBcl	66.695	3930.498	4.746267
SumBase	62.628	4185.737	5.054481
SumBase_Basic	798.052	328.480	0.396655
SumBase_ClearBit	499.232	525.095	0.634078
SumTraits	62.625	4185.941	5.054728
Sum128Base_Basic	829.667	315.963	0.381540
Sum128Base	829.424	316.055	0.381652
Sum128Traits	66.715	3929.329	4.744856
Sum256Base_Basic	881.745	297.301	0.359006
Sum256Base	882.459	297.061	0.358716
Sum256Traits	881.384	297.423	0.359153

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1719.657	152.440
SumBase	288.063	910.022	5.969718
SumBase_ClearBit	747.888	350.513	2.299353
SumTraits	124.819	2100.189	13.777179
Sum128Base_Basic	1678.925	156.138	1.024261
Sum128Base	1679.783	156.058	1.023738
Sum128Traits	133.064	1970.067	12.923582
Sum256Base_Basic	2123.864	123.428	0.809683
Sum256Base	2169.668	120.822	0.792590
Sum256Traits	2086.881	125.615	0.824032

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1647.432	159.123
SumBase	120.923	2167.859	13.623808
SumBase_ClearBit	380.294	689.320	4.332001
SumTraits	62.111	4220.541	26.523793
Sum128Base_Basic	1778.367	147.407	0.926373
Sum128Base	1691.359	154.990	0.974028
Sum128Traits	66.329	3952.191	24.837362
Sum256Base_Basic	2038.342	128.606	0.808222
Sum256Base	2060.437	127.227	0.799555
Sum256Traits	2027.426	129.299	0.812573

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
SumScalar	211.787	1237.770
SumBcl	106.706	2456.693	1.984773
SumBase	106.846	2453.481	1.982179
SumBase_Basic	550.992	475.767	0.384375
SumBase_ClearBit	912.153	287.390	0.232184
SumTraits	106.700	2456.839	1.984891
Sum128Bcl	107.116	2447.285	1.977173
Sum128Base_Basic	554.559	472.707	0.381902
Sum128Base	106.758	2455.489	1.983801
Sum128Traits	106.577	2459.659	1.987169
Sum256Bcl	975.199	268.811	0.217174
Sum256Base_Basic	1158.898	226.201	0.182749
Sum256Base	1156.574	226.656	0.183116
Sum256Traits	1152.587	227.440	0.183750

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
SumScalar	211.637	1238.650
SumBcl	56.120	4671.149	3.771161
SumBase	55.963	4684.200	3.781698
SumBase_Basic	805.182	325.571	0.262843
SumBase_ClearBit	465.160	563.557	0.454977
SumTraits	56.235	4661.571	3.763429
Sum128Bcl	56.099	4672.905	3.772579
Sum128Base_Basic	810.638	323.380	0.261074
Sum128Base	55.873	4691.760	3.787802
Sum128Traits	56.122	4670.982	3.771026
Sum256Bcl	908.534	288.535	0.232943
Sum256Base_Basic	1015.754	258.078	0.208354
Sum256Base	943.152	277.945	0.224393
Sum256Traits	944.561	277.530	0.224059

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
SumScalar	211.257	1240.878
SumBcl	106.961	2450.849	1.975093
SumBase	107.237	2444.539	1.970008
SumBase_Basic	548.912	477.570	0.384865
SumBase_ClearBit	919.135	285.207	0.229843
SumTraits	106.913	2451.949	1.975979
Sum128Bcl	106.670	2457.524	1.980473
Sum128Base_Basic	555.297	472.079	0.380440
Sum128Base	107.483	2438.942	1.965498
Sum128Traits	106.742	2455.867	1.979137
Sum256Bcl	975.351	268.769	0.216596
Sum256Base_Basic	1157.249	226.523	0.182551
Sum256Base	1155.918	226.784	0.182761
Sum256Traits	1154.529	227.057	0.182981

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
SumScalar	211.849	1237.409
SumBcl	56.037	4678.036	3.780509
SumBase	56.146	4668.982	3.773192
SumBase_Basic	803.692	326.175	0.263595
SumBase_ClearBit	469.294	558.592	0.451420
SumTraits	56.075	4674.870	3.777950
Sum128Bcl	56.048	4677.170	3.779809
Sum128Base_Basic	805.870	325.293	0.262883
Sum128Base	56.106	4672.309	3.775881
Sum128Traits	56.041	4677.746	3.780275
Sum256Bcl	903.302	290.206	0.234527
Sum256Base_Basic	1012.318	258.954	0.209271
Sum256Base	940.895	278.611	0.225157
Sum256Traits	1041.983	251.582	0.203313

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	219.347	1195.113
SumBase	229.180	1143.836	0.957094
SumBase_ClearBit	691.758	378.953	0.317086
SumTraits	106.189	2468.666	2.065633
Sum128Base_Basic	557.883	469.890	0.393176
Sum128Base	163.264	1605.649	1.343512
Sum128Traits	106.422	2463.240	2.061093
Sum256Base_Basic	1151.844	227.586	0.190431
Sum256Base	3272.119	80.114	0.067035
Sum256Traits	3278.749	79.952	0.066899

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	211.523	1239.319
SumBase	112.748	2325.046	1.876067
SumBase_ClearBit	350.385	748.160	0.603686
SumTraits	55.962	4684.352	3.779779
Sum128Base_Basic	803.523	326.244	0.263244
Sum128Base	94.408	2776.707	2.240510
Sum128Traits	55.923	4687.576	3.782380
Sum256Base_Basic	1009.529	259.670	0.209526
Sum256Base	2250.302	116.493	0.093997
Sum256Traits	2251.104	116.451	0.093964

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

