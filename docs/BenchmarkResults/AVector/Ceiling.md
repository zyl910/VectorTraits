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
SumScalar	550.222	476.434
SumBase	312.651	838.455	1.759856
SumBase_Basic	915.830	286.236	0.600790
SumBase_ClearBit	313.185	837.025	1.756857
SumTraits	320.490	817.948	1.716814

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	1324.520	197.916
SumBase	170.403	1538.374	7.772853
SumBase_Basic	1139.061	230.140	1.162817
SumBase_ClearBit	161.558	1622.598	8.198408
SumTraits	162.067	1617.508	8.172688

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	629.455	416.462
SumBase	319.707	819.950	1.968848
SumBase_Basic	882.934	296.901	0.712913
SumBase_ClearBit	351.288	746.238	1.791852
SumTraits	600.054	436.867	1.048998

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	1479.430	177.193
SumBase	159.889	1639.540	9.252875
SumBase_Basic	1113.607	235.401	1.328503
SumBase_ClearBit	161.329	1624.899	9.170245
SumTraits	169.906	1542.873	8.707325

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1391.627	188.372
SumBase	239.403	1094.988	5.812894
SumBase_ClearBit	236.570	1108.104	5.882522
SumTraits	238.376	1099.706	5.837936

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	2042.409	128.350
SumBase	116.147	2257.002	17.584687
SumBase_ClearBit	127.760	2051.839	15.986231
SumTraits	117.788	2225.550	17.339639

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
SumScalar	944.812	277.456
SumBase	345.468	758.808	2.734875
SumBase_Basic	538.696	486.627	1.753888
SumBase_ClearBit	328.883	797.075	2.872792
SumTraits	327.595	800.207	2.884081

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	938.236	279.401
SumBase	176.180	1487.935	5.325450
SumBase_Basic	574.337	456.429	1.633598
SumBase_ClearBit	166.576	1573.719	5.632478
SumTraits	167.942	1560.917	5.586657

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	937.358	279.663
SumBase	306.778	854.506	3.055488
SumBase_Basic	539.339	486.047	1.737975
SumBase_ClearBit	345.677	758.349	2.711654
SumTraits	330.390	793.438	2.837125

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	939.284	279.089
SumBase	179.597	1459.620	5.229941
SumBase_Basic	578.682	453.002	1.623143
SumBase_ClearBit	168.242	1558.140	5.582945
SumTraits	163.899	1599.425	5.730875

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1200.952	218.280
SumBase	243.829	1075.113	4.925385
SumBase_ClearBit	235.966	1110.940	5.089517
SumTraits	237.219	1105.074	5.062641

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	1207.372	217.119
SumBase	126.400	2073.929	9.552019
SumBase_ClearBit	134.538	1948.471	8.974188
SumTraits	132.506	1978.356	9.111831

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
SumScalar	934.764	280.439
SumBase	303.518	863.685	3.079762
SumBase_Basic	531.203	493.491	1.759712
SumBase_ClearBit	273.274	959.270	3.420605
SumTraits	87.847	2984.088	10.640783
Sum128Base_Basic	1653.580	158.531	0.565297
Sum128Base	1656.586	158.244	0.564271
Sum128Traits	1656.481	158.254	0.564307
Sum256Base_Basic	498.926	525.417	1.873552
Sum256Base	492.621	532.141	1.897530
Sum256Traits	85.607	3062.177	10.919235

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	933.229	280.900
SumBase	143.672	1824.604	6.495566
SumBase_Basic	344.986	759.868	2.705120
SumBase_ClearBit	152.969	1713.710	6.100788
SumTraits	39.848	6578.611	23.419775
Sum128Base_Basic	901.511	290.783	1.035183
Sum128Base	901.989	290.629	1.034635
Sum128Traits	903.093	290.273	1.033370
Sum256Base_Basic	296.239	884.906	3.150254
Sum256Base	296.187	885.062	3.150808
Sum256Traits	41.901	6256.296	22.272337

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	934.534	280.508
SumBase	270.991	967.353	3.448579
SumBase_Basic	534.796	490.176	1.747459
SumBase_ClearBit	287.943	910.401	3.245547
SumTraits	80.497	3256.555	11.609501
Sum128Base_Basic	1641.984	159.651	0.569149
Sum128Base	1644.559	159.401	0.568258
Sum128Traits	1644.093	159.446	0.568419
Sum256Base_Basic	490.094	534.885	1.906845
Sum256Base	490.798	534.118	1.904110
Sum256Traits	85.003	3083.938	10.994129

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	934.991	280.371
SumBase	139.995	1872.519	6.678729
SumBase_Basic	331.814	790.033	2.817815
SumBase_ClearBit	148.985	1759.534	6.275743
SumTraits	41.546	6309.735	22.504977
Sum128Base_Basic	900.607	291.075	1.038179
Sum128Base	900.870	290.990	1.037876
Sum128Traits	902.143	290.579	1.036410
Sum256Base_Basic	284.730	920.677	3.283784
Sum256Base	286.607	914.646	3.262274
Sum256Traits	40.121	6533.855	23.304349

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1227.739	213.518
SumBase	247.200	1060.453	4.966584
SumBase_ClearBit	244.564	1071.885	5.020124
SumTraits	87.028	3012.169	14.107357
Sum128Base_Basic	2355.946	111.269	0.521124
Sum128Base	2390.827	109.646	0.513521
Sum128Traits	2346.396	111.722	0.523245
Sum256Base_Basic	1519.044	172.572	0.808232
Sum256Base	1452.365	180.495	0.845338
Sum256Traits	82.032	3195.645	14.966656

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1346.874	194.631
SumBase	126.311	2075.388	10.663171
SumBase_ClearBit	115.639	2266.919	11.647238
SumTraits	40.852	6416.937	32.969684
Sum128Base_Basic	1725.137	151.955	0.780734
Sum128Base	1671.433	156.838	0.805820
Sum128Traits	1654.439	158.449	0.814097
Sum256Base_Basic	1427.917	183.585	0.943244
Sum256Base	1385.231	189.242	0.972310
Sum256Traits	39.563	6625.948	34.043567

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
SumScalar	954.904	274.524
SumBcl	91.875	2853.271	10.393520
SumBase	88.566	2959.868	10.781820
SumBase_Basic	544.132	481.766	1.754913
SumBase_ClearBit	299.016	876.690	3.193492
SumTraits	85.458	3067.503	11.173898
Sum128Base_Basic	1640.437	159.801	0.582103
Sum128Base	1637.711	160.067	0.583072
Sum128Traits	1637.678	160.071	0.583084
Sum256Base_Basic	491.329	533.540	1.943511
Sum256Base	490.958	533.944	1.944980
Sum256Traits	91.557	2863.173	10.429589

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	932.671	281.068
SumBcl	42.093	6227.678	22.157202
SumBase	42.359	6188.604	22.018180
SumBase_Basic	332.142	789.254	2.808054
SumBase_ClearBit	128.390	2041.774	7.264344
SumTraits	42.758	6130.891	21.812845
Sum128Base_Basic	897.169	292.190	1.039572
Sum128Base	899.315	291.493	1.037091
Sum128Traits	897.534	292.071	1.039149
Sum256Base_Basic	296.582	883.884	3.144737
Sum256Base	296.426	884.350	3.146392
Sum256Traits	39.713	6600.946	23.485237

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	935.441	280.236
SumBcl	85.994	3048.394	10.877968
SumBase	84.496	3102.425	11.070771
SumBase_Basic	531.775	492.960	1.759092
SumBase_ClearBit	297.546	881.020	3.143856
SumTraits	81.339	3222.838	11.500458
Sum128Base_Basic	1639.773	159.866	0.570470
Sum128Base	1641.451	159.703	0.569887
Sum128Traits	1639.797	159.864	0.570462
Sum256Base_Basic	557.804	469.957	1.677008
Sum256Base	564.590	464.309	1.656851
Sum256Traits	85.622	3061.643	10.925243

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	932.124	281.233
SumBcl	39.444	6646.008	23.631675
SumBase	39.407	6652.212	23.653736
SumBase_Basic	341.153	768.406	2.732274
SumBase_ClearBit	135.698	1931.816	6.869094
SumTraits	39.503	6635.990	23.596051
Sum128Base_Basic	901.715	290.717	1.033723
Sum128Base	905.942	289.361	1.028900
Sum128Traits	899.975	291.279	1.035722
Sum256Base_Basic	317.174	826.500	2.938844
Sum256Base	316.954	827.073	2.940882
Sum256Traits	39.305	6669.540	23.715349

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1173.470	223.392
SumBase	102.137	2566.601	11.489215
SumBase_ClearBit	210.552	1245.032	5.573303
SumTraits	81.459	3218.102	14.405616
Sum128Base_Basic	2351.841	111.463	0.498958
Sum128Base	2347.508	111.669	0.499879
Sum128Traits	2344.714	111.802	0.500475
Sum256Base_Basic	1508.748	173.749	0.777777
Sum256Base	1541.325	170.077	0.761338
Sum256Traits	80.660	3249.998	14.548394

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1142.356	229.477
SumBase	49.689	5275.657	22.989957
SumBase_ClearBit	107.806	2431.621	10.596380
SumTraits	42.386	6184.649	26.951114
Sum128Base_Basic	1669.001	157.066	0.684455
Sum128Base	1762.774	148.711	0.648045
Sum128Traits	1735.368	151.060	0.658279
Sum256Base_Basic	1396.708	187.687	0.817892
Sum256Base	1407.081	186.303	0.811862
Sum256Traits	39.483	6639.474	28.933123

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
SumScalar	937.402	279.649
SumBcl	80.980	3237.146	11.575730
SumBase	86.392	3034.366	10.850608
SumBase_Basic	556.311	471.219	1.685034
SumBase_ClearBit	296.875	883.011	3.157564
SumTraits	85.803	3055.200	10.925108
Sum128Base_Basic	1638.102	160.029	0.572249
Sum128Base	1637.361	160.102	0.572508
Sum128Traits	1637.815	160.057	0.572349
Sum256Base_Basic	558.851	469.076	1.677374
Sum256Base	557.607	470.123	1.681118
Sum256Traits	80.507	3256.144	11.643666

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	931.503	281.420
SumBcl	40.148	6529.408	23.201611
SumBase	40.826	6420.936	22.816169
SumBase_Basic	344.330	761.316	2.705261
SumBase_ClearBit	137.769	1902.785	6.761359
SumTraits	41.152	6370.155	22.635724
Sum128Base_Basic	899.236	291.519	1.035883
Sum128Base	901.357	290.833	1.033445
Sum128Traits	901.695	290.724	1.033058
Sum256Base_Basic	320.932	816.822	2.902497
Sum256Base	318.692	822.564	2.922899
Sum256Traits	39.246	6679.433	23.734713

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	935.948	280.084
SumBcl	87.907	2982.064	10.647034
SumBase	87.745	2987.562	10.666664
SumBase_Basic	554.759	472.537	1.687125
SumBase_ClearBit	300.084	873.568	3.118951
SumTraits	86.677	3024.379	10.798112
Sum128Base_Basic	1641.479	159.700	0.570186
Sum128Base	1641.144	159.732	0.570302
Sum128Traits	1645.147	159.344	0.568914
Sum256Base_Basic	493.171	531.547	1.897814
Sum256Base	490.725	534.198	1.907276
Sum256Traits	87.072	3010.659	10.749126

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	939.712	278.962
SumBcl	40.111	6535.424	23.427656
SumBase	40.145	6529.984	23.408156
SumBase_Basic	336.612	778.773	2.791682
SumBase_ClearBit	152.108	1723.403	6.177914
SumTraits	39.424	6649.416	23.836286
Sum128Base_Basic	900.673	291.053	1.043345
Sum128Base	904.356	289.868	1.039096
Sum128Traits	901.805	290.688	1.042035
Sum256Base_Basic	283.492	924.695	3.314772
Sum256Base	283.368	925.100	3.316223
Sum256Traits	41.569	6306.196	22.605939

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1168.667	224.310
SumBase	93.466	2804.695	12.503640
SumBase_ClearBit	204.931	1279.185	5.702748
SumTraits	83.482	3140.110	13.998958
Sum128Base_Basic	2398.619	109.290	0.487225
Sum128Base	2359.840	111.086	0.495232
Sum128Traits	2349.532	111.573	0.497404
Sum256Base_Basic	1371.934	191.076	0.851839
Sum256Base	1382.137	189.666	0.845550
Sum256Traits	81.947	3198.961	14.261320

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1408.776	186.079
SumBase	47.372	5533.763	29.738732
SumBase_ClearBit	101.784	2575.505	13.840898
SumTraits	39.438	6646.997	35.721308
Sum128Base_Basic	1659.233	157.991	0.849052
Sum128Base	1773.660	147.798	0.794276
Sum128Traits	1767.302	148.330	0.797133
Sum256Base_Basic	1336.836	196.093	1.053813
Sum256Base	1374.229	190.757	1.025139
Sum256Traits	40.423	6485.038	34.850930

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
SumScalar	934.249	280.593
SumBcl	81.601	3212.500	11.448949
SumBase	85.703	3058.741	10.900973
SumBase_Basic	528.734	495.796	1.766954
SumBase_ClearBit	287.840	910.728	3.245721
SumTraits	87.834	2984.542	10.636534
Sum128Bcl	159.659	1641.901	5.851530
Sum128Base_Basic	863.418	303.612	1.082035
Sum128Base	158.912	1649.622	5.879048
Sum128Traits	159.519	1643.344	5.856674
Sum256Bcl	86.821	3019.371	10.760663
Sum256Base_Basic	493.346	531.360	1.893699
Sum256Base	85.377	3070.428	10.942624
Sum256Traits	80.405	3260.313	11.619349

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
SumScalar	932.936	280.988
SumBcl	39.408	6652.076	23.673854
SumBase	40.673	6445.141	22.937401
SumBase_Basic	348.611	751.967	2.676152
SumBase_ClearBit	140.327	1868.098	6.648313
SumTraits	43.103	6081.735	21.644086
Sum128Bcl	79.149	3312.013	11.787016
Sum128Base_Basic	469.939	557.825	1.985227
Sum128Base	78.948	3320.444	11.817019
Sum128Traits	79.004	3318.125	11.808765
Sum256Bcl	41.085	6380.540	22.707494
Sum256Base_Basic	284.087	922.758	3.283973
Sum256Base	40.691	6442.341	22.927435
Sum256Traits	40.051	6545.213	23.293545

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
SumScalar	934.060	280.650
SumBcl	81.132	3231.088	11.512868
SumBase	88.030	2977.907	10.610745
SumBase_Basic	552.047	474.858	1.691994
SumBase_ClearBit	290.537	902.273	3.214938
SumTraits	81.398	3220.525	11.475232
Sum128Bcl	158.936	1649.369	5.876956
Sum128Base_Basic	859.719	304.918	1.086471
Sum128Base	159.210	1646.527	5.866832
Sum128Traits	159.600	1642.507	5.852508
Sum256Bcl	81.962	3198.375	11.396308
Sum256Base_Basic	493.339	531.366	1.893341
Sum256Base	80.468	3257.757	11.607895
Sum256Traits	85.100	3080.414	10.975994

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
SumScalar	931.921	281.294
SumBcl	43.062	6087.570	21.641295
SumBase	42.856	6116.870	21.745455
SumBase_Basic	349.916	749.163	2.663271
SumBase_ClearBit	127.149	2061.702	7.329346
SumTraits	41.972	6245.726	22.203538
Sum128Bcl	79.048	3316.250	11.789260
Sum128Base_Basic	468.721	559.275	1.988222
Sum128Base	78.545	3337.482	11.864740
Sum128Traits	78.560	3336.856	11.862514
Sum256Bcl	40.121	6533.811	23.227679
Sum256Base_Basic	286.312	915.587	3.254911
Sum256Base	39.518	6633.468	23.581960
Sum256Traits	42.342	6191.139	22.009483

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	935.401	280.248
SumBase	104.403	2510.874	8.959481
SumBase_ClearBit	195.657	1339.814	4.780818
SumTraits	83.193	3151.023	11.243705
Sum128Base_Basic	859.797	304.891	1.087933
Sum128Base	181.623	1443.340	5.150230
Sum128Traits	172.811	1516.937	5.412845
Sum256Base_Basic	492.009	532.803	1.901186
Sum256Base	95.908	2733.273	9.753059
Sum256Traits	81.560	3214.126	11.468874

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	934.439	280.536
SumBase	50.668	5173.759	18.442383
SumBase_ClearBit	109.524	2393.478	8.531791
SumTraits	40.297	6505.304	23.188807
Sum128Base_Basic	468.721	559.275	1.993591
Sum128Base	84.703	3094.850	11.031902
Sum128Traits	84.549	3100.507	11.052067
Sum256Base_Basic	285.563	917.989	3.272263
Sum256Base	46.899	5589.583	19.924630
Sum256Traits	40.356	6495.841	23.155075

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
SumScalar	316.454	828.379
SumBase	1424.412	184.037	0.222165
SumBase_Basic	542.142	483.534	0.583711
SumBase_ClearBit	1422.429	184.293	0.222474
SumTraits	1425.669	183.874	0.221969
Sum128Base_Basic	1132.136	231.548	0.279519
Sum128Base	1135.193	230.925	0.278767
Sum128Traits	1136.575	230.644	0.278428
Sum256Base_Basic	1680.429	155.998	0.188317
Sum256Base	1685.806	155.501	0.187717
Sum256Traits	1686.522	155.435	0.187637

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	316.081	829.358
SumBase	700.892	374.015	0.450969
SumBase_Basic	797.724	328.615	0.396228
SumBase_ClearBit	700.911	374.005	0.450957
SumTraits	709.265	369.600	0.445646
Sum128Base_Basic	1458.691	179.712	0.216688
Sum128Base	1459.519	179.610	0.216565
Sum128Traits	1459.894	179.564	0.216509
Sum256Base_Basic	1224.951	214.004	0.258035
Sum256Base	1236.746	211.963	0.255574
Sum256Traits	1231.080	212.938	0.256751

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.588	902.116
SumBase	1423.156	184.199	0.204186
SumBase_Basic	541.682	483.945	0.536455
SumBase_ClearBit	1422.937	184.227	0.204217
SumTraits	1422.094	184.337	0.204338
Sum128Base_Basic	1133.986	231.170	0.256254
Sum128Base	1131.779	231.621	0.256753
Sum128Traits	1131.178	231.744	0.256890
Sum256Base_Basic	1581.574	165.749	0.183733
Sum256Base	1593.940	164.463	0.182308
Sum256Traits	1578.503	166.071	0.184091

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	316.821	827.421
SumBase	701.048	373.932	0.451924
SumBase_Basic	798.402	328.336	0.396818
SumBase_ClearBit	700.924	373.998	0.452004
SumTraits	700.760	374.085	0.452110
Sum128Base_Basic	1461.000	179.428	0.216852
Sum128Base	1461.957	179.310	0.216710
Sum128Traits	1460.235	179.522	0.216965
Sum256Base_Basic	1176.993	222.724	0.269178
Sum256Base	1176.244	222.865	0.269349
Sum256Traits	1176.380	222.840	0.269318

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1947.022	134.638
SumBase	1092.029	240.052	1.782940
SumBase_ClearBit	1093.075	239.822	1.781234
SumTraits	1085.166	241.570	1.794216
Sum128Base_Basic	2379.174	110.183	0.818361
Sum128Base	2382.190	110.043	0.817325
Sum128Traits	2380.371	110.127	0.817949
Sum256Base_Basic	3013.607	86.987	0.646077
Sum256Base	3060.810	85.645	0.636114
Sum256Traits	3051.904	85.895	0.637970

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	1871.994	140.035
SumBase	541.493	484.113	3.457095
SumBase_ClearBit	541.972	483.686	3.454043
SumTraits	541.198	484.377	3.458981
Sum128Base_Basic	2746.115	95.460	0.681688
Sum128Base	2659.366	98.574	0.703925
Sum128Traits	2734.478	95.866	0.684589
Sum256Base_Basic	2560.657	102.374	0.731060
Sum256Base	2522.260	103.932	0.742189
Sum256Traits	2558.044	102.478	0.731807

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
SumScalar	315.706	830.341
SumBcl	125.063	2096.088	2.524370
SumBase	125.047	2096.360	2.524698
SumBase_Basic	553.434	473.668	0.570450
SumBase_ClearBit	1043.975	251.102	0.302408
SumTraits	133.305	1966.494	2.368297
Sum128Base_Basic	560.447	467.741	0.563312
Sum128Base	557.002	470.634	0.566795
Sum128Traits	125.118	2095.179	2.523274
Sum256Base_Basic	1077.291	243.336	0.293056
Sum256Base	1080.078	242.708	0.292300
Sum256Traits	1074.239	244.028	0.293888

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	316.386	828.557
SumBcl	62.835	4171.970	5.035222
SumBase	62.845	4171.246	5.034349
SumBase_Basic	799.255	327.986	0.395851
SumBase_ClearBit	514.073	509.935	0.615449
SumTraits	62.948	4164.482	5.026185
Sum128Base_Basic	832.376	314.934	0.380100
Sum128Base	832.257	314.980	0.380154
Sum128Traits	67.160	3903.266	4.710920
Sum256Base_Basic	884.369	296.419	0.357753
Sum256Base	915.135	286.454	0.345726
Sum256Traits	916.179	286.128	0.345332

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	315.733	830.272
SumBcl	133.358	1965.719	2.367560
SumBase	133.343	1965.931	2.367815
SumBase_Basic	550.651	476.062	0.573381
SumBase_ClearBit	1044.403	250.999	0.302309
SumTraits	133.306	1966.484	2.368483
Sum128Base_Basic	559.986	468.126	0.563822
Sum128Base	559.316	468.686	0.564498
Sum128Traits	125.311	2091.954	2.519602
Sum256Base_Basic	1073.521	244.191	0.294110
Sum256Base	1074.644	243.936	0.293802
Sum256Traits	1072.664	244.386	0.294344

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	317.118	826.646
SumBcl	62.873	4169.412	5.043769
SumBase	62.906	4167.221	5.041118
SumBase_Basic	799.976	327.690	0.396409
SumBase_ClearBit	514.686	509.328	0.616138
SumTraits	66.941	3916.063	4.737290
Sum128Base_Basic	833.950	314.340	0.380260
Sum128Base	834.068	314.296	0.380206
Sum128Traits	62.954	4164.083	5.037322
Sum256Base_Basic	883.931	296.566	0.358758
Sum256Base	883.360	296.758	0.358990
Sum256Traits	883.059	296.859	0.359113

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1910.000	137.248
SumBase	247.199	1060.457	7.726570
SumBase_ClearBit	779.558	336.273	2.450106
SumTraits	125.156	2094.534	15.260929
Sum128Base_Basic	2008.077	130.545	0.951159
Sum128Base	1986.010	131.995	0.961727
Sum128Traits	133.259	1967.184	14.333044
Sum256Base_Basic	2403.974	109.046	0.794518
Sum256Base	2404.074	109.042	0.794485
Sum256Traits	2483.246	105.565	0.769155

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1970.758	133.017
SumBase	122.550	2139.081	16.081280
SumBase_ClearBit	388.748	674.329	5.069505
SumTraits	63.053	4157.496	31.255411
Sum128Base_Basic	2133.335	122.880	0.923792
Sum128Base	2054.526	127.593	0.959228
Sum128Traits	66.988	3913.313	29.419683
Sum256Base_Basic	2339.104	112.070	0.842527
Sum256Base	2359.630	111.095	0.835198
Sum256Traits	2339.628	112.045	0.842338

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
SumScalar	290.394	902.717
SumBcl	125.487	2089.012	2.314139
SumBase	133.346	1965.897	2.177756
SumBase_Basic	554.937	472.385	0.523292
SumBase_ClearBit	993.221	263.933	0.292376
SumTraits	133.428	1964.687	2.176415
Sum128Base_Basic	561.057	467.233	0.517585
Sum128Base	558.825	469.099	0.519652
Sum128Traits	125.193	2093.912	2.319567
Sum256Base_Basic	1079.061	242.937	0.269118
Sum256Base	1073.723	244.145	0.270456
Sum256Traits	1076.251	243.571	0.269820

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	290.500	902.389
SumBcl	66.882	3919.525	4.343498
SumBase	62.716	4179.878	4.632013
SumBase_Basic	797.234	328.817	0.364385
SumBase_ClearBit	499.591	524.718	0.581476
SumTraits	63.250	4144.539	4.592852
Sum128Base_Basic	833.757	314.413	0.348423
Sum128Base	833.126	314.651	0.348687
Sum128Traits	66.853	3921.209	4.345364
Sum256Base_Basic	883.250	296.795	0.328899
Sum256Base	914.023	286.802	0.317826
Sum256Traits	914.040	286.797	0.317820

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.494	902.408
SumBcl	133.184	1968.290	2.181153
SumBase	125.285	2092.377	2.318660
SumBase_Basic	551.184	475.602	0.527036
SumBase_ClearBit	988.835	265.104	0.293774
SumTraits	125.124	2095.077	2.321652
Sum128Base_Basic	560.669	467.556	0.518120
Sum128Base	558.067	469.735	0.520536
Sum128Traits	133.412	1964.927	2.177426
Sum256Base_Basic	1069.146	245.190	0.271706
Sum256Base	1069.818	245.036	0.271536
Sum256Traits	1071.269	244.704	0.271168

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	316.046	829.448
SumBcl	66.898	3918.567	4.724306
SumBase	62.796	4174.521	5.032890
SumBase_Basic	799.165	328.022	0.395471
SumBase_ClearBit	499.530	524.781	0.632687
SumTraits	62.625	4185.938	5.046655
Sum128Base_Basic	829.248	316.122	0.381124
Sum128Base	829.482	316.033	0.381016
Sum128Traits	66.871	3920.117	4.726176
Sum256Base_Basic	882.539	297.034	0.358110
Sum256Base	885.808	295.938	0.356789
Sum256Traits	882.944	296.898	0.357946

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1987.859	131.873
SumBase	245.968	1065.764	8.081778
SumBase_ClearBit	746.956	350.950	2.661281
SumTraits	125.013	2096.927	15.901166
Sum128Base_Basic	2536.688	103.341	0.783644
Sum128Base	2480.916	105.664	0.801260
Sum128Traits	133.204	1967.994	14.923460
Sum256Base_Basic	2545.793	102.971	0.780841
Sum256Base	2490.800	105.245	0.798081
Sum256Traits	2542.476	103.106	0.781860

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	2047.974	128.002
SumBase	143.947	1821.116	14.227292
SumBase_ClearBit	379.156	691.387	5.401395
SumTraits	62.726	4179.175	32.649394
Sum128Base_Basic	2201.040	119.100	0.930457
Sum128Base	2211.441	118.540	0.926081
Sum128Traits	66.888	3919.136	30.617865
Sum256Base_Basic	2580.670	101.580	0.793582
Sum256Base	2510.251	104.429	0.815844
Sum256Traits	2485.207	105.482	0.824066

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
SumScalar	210.771	1243.740
SumBcl	106.225	2467.827	1.984199
SumBase	106.213	2468.100	1.984419
SumBase_Basic	556.803	470.802	0.378537
SumBase_ClearBit	907.680	288.807	0.232208
SumTraits	106.355	2464.804	1.981768
Sum128Bcl	106.158	2469.371	1.985440
Sum128Base_Basic	551.569	475.270	0.382130
Sum128Base	106.189	2468.644	1.984856
Sum128Traits	106.383	2464.158	1.981249
Sum256Bcl	968.700	270.614	0.217581
Sum256Base_Basic	1149.446	228.061	0.183367
Sum256Base	1152.120	227.532	0.182942
Sum256Traits	1153.937	227.174	0.182654

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
SumScalar	210.892	1243.024
SumBcl	55.508	4722.643	3.799319
SumBase	55.747	4702.413	3.783044
SumBase_Basic	799.225	327.998	0.263871
SumBase_ClearBit	462.059	567.339	0.456418
SumTraits	55.377	4733.844	3.808330
Sum128Bcl	55.379	4733.613	3.808144
Sum128Base_Basic	803.863	326.105	0.262348
Sum128Base	55.364	4734.925	3.809199
Sum128Traits	55.376	4733.889	3.808366
Sum256Bcl	901.046	290.933	0.234053
Sum256Base_Basic	1008.599	259.909	0.209094
Sum256Base	936.606	279.887	0.225166
Sum256Traits	936.143	280.026	0.225278

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
SumScalar	210.605	1244.718
SumBcl	106.118	2470.312	1.984635
SumBase	106.267	2466.842	1.981848
SumBase_Basic	547.214	479.052	0.384868
SumBase_ClearBit	915.919	286.209	0.229939
SumTraits	106.301	2466.062	1.981221
Sum128Bcl	106.105	2470.607	1.984873
Sum128Base_Basic	554.862	472.449	0.379563
Sum128Base	106.032	2472.308	1.986239
Sum128Traits	106.266	2466.874	1.981874
Sum256Bcl	970.516	270.108	0.217003
Sum256Base_Basic	1151.411	227.672	0.182911
Sum256Base	1148.260	228.297	0.183412
Sum256Traits	1149.275	228.095	0.183250

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
SumScalar	210.778	1243.694
SumBcl	55.327	4738.076	3.809679
SumBase	55.336	4737.303	3.809057
SumBase_Basic	800.392	327.519	0.263344
SumBase_ClearBit	465.630	562.987	0.452673
SumTraits	55.456	4727.082	3.800839
Sum128Bcl	55.322	4738.478	3.810002
Sum128Base_Basic	805.259	325.540	0.261752
Sum128Base	55.426	4729.609	3.802870
Sum128Traits	55.460	4726.703	3.800534
Sum256Bcl	897.582	292.056	0.234829
Sum256Base_Basic	1012.860	258.816	0.208102
Sum256Base	935.853	280.112	0.225226
Sum256Traits	936.374	279.956	0.225101

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.631	1244.567
SumBase	271.401	965.890	0.776086
SumBase_ClearBit	690.319	379.743	0.305121
SumTraits	106.197	2468.480	1.983405
Sum128Base_Basic	551.469	475.356	0.381945
Sum128Base	162.934	1608.896	1.292736
Sum128Traits	106.159	2469.364	1.984116
Sum256Base_Basic	1150.688	227.815	0.183048
Sum256Base	3191.945	82.127	0.065988
Sum256Traits	3204.152	81.814	0.065737

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	210.835	1243.363
SumBase	114.431	2290.842	1.842456
SumBase_ClearBit	349.396	750.278	0.603426
SumTraits	55.337	4737.249	3.810028
Sum128Base_Basic	805.399	325.483	0.261777
Sum128Base	95.724	2738.533	2.202521
Sum128Traits	55.441	4728.307	3.802837
Sum256Base_Basic	1012.686	258.860	0.208193
Sum256Base	2237.339	117.168	0.094235
Sum256Traits	2240.618	116.996	0.094097

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

