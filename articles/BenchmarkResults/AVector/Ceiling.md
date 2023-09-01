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
SumScalar	634.762	412.980
SumBase	246.751	1062.381	2.572476
SumBase_Basic	911.994	287.440	0.696015
SumBase_ClearBit	244.392	1072.637	2.597311
SumTraits	261.982	1000.619	2.422925

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	1409.426	185.993
SumBase	251.570	1042.031	5.602512
SumBase_Basic	1444.485	181.479	0.975729
SumBase_ClearBit	132.706	1975.370	10.620643
SumTraits	139.576	1878.139	10.097877

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	603.534	434.349
SumBase	280.876	933.307	2.148752
SumBase_Basic	954.296	274.699	0.632439
SumBase_ClearBit	262.319	999.334	2.300765
SumTraits	263.141	996.211	2.293574

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	1330.168	197.076
SumBase	129.259	2028.046	10.290682
SumBase_Basic	1116.475	234.796	1.191399
SumBase_ClearBit	121.978	2149.107	10.904968
SumTraits	122.589	2138.401	10.850644

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	2052.132	127.742
SumBase	117.641	2228.336	17.444000
SumBase_Add	118.784	2206.904	17.276221
SumTraits	135.366	1936.561	15.159908

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	2470.062	106.129
SumBase	68.159	3846.063	36.239678
SumBase_Add	64.743	4049.007	38.151929
SumTraits	70.130	3737.951	35.220986

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1430.520	183.251
SumBase	170.270	1539.579	8.401486
SumBase_ClearBit	188.413	1391.329	7.592487
SumBase_ClearBit_Not	161.113	1627.086	8.879012
SumTraits	165.683	1582.205	8.634096

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	2218.830	118.145
SumBase	92.279	2840.766	24.044708
SumBase_ClearBit	89.246	2937.327	24.862019
SumTraits	93.718	2797.146	23.675504

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
SumScalar	933.368	280.858
SumBase	246.856	1061.929	3.781017
SumBase_Basic	534.151	490.767	1.747386
SumBase_ClearBit	263.903	993.333	3.536779
SumTraits	264.285	991.899	3.531673

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	933.071	280.947
SumBase	134.573	1947.968	6.933565
SumBase_Basic	570.468	459.524	1.635623
SumBase_ClearBit	135.628	1932.821	6.879654
SumTraits	126.315	2075.313	7.386834

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	933.266	280.889
SumBase	260.082	1007.928	3.588350
SumBase_Basic	529.276	495.287	1.763286
SumBase_ClearBit	259.724	1009.316	3.593294
SumTraits	261.089	1004.039	3.574505

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	931.778	281.338
SumBase	129.996	2016.554	7.167741
SumBase_Basic	570.797	459.259	1.632415
SumBase_ClearBit	136.101	1926.093	6.846201
SumTraits	137.123	1911.738	6.795175

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	936.422	279.942
SumBase	128.005	2047.918	7.315502
SumBase_Add	131.931	1986.976	7.097808
SumTraits	134.229	1952.964	6.976312

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	932.226	281.202
SumBase	60.194	4354.952	15.486908
SumBase_Add	63.333	4139.158	14.719509
SumTraits	57.569	4553.530	16.193084

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1316.592	199.108
SumBase	164.496	1593.620	8.003793
SumBase_ClearBit	175.566	1493.136	7.499125
SumBase_ClearBit_Not	173.368	1512.067	7.594204
SumTraits	175.988	1489.558	7.481155

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	1251.733	209.425
SumBase	82.420	3180.573	15.187186
SumBase_ClearBit	87.789	2986.076	14.258464
SumTraits	84.408	3105.694	14.829638

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
SumScalar	935.771	280.137
SumBase	204.743	1280.356	4.570463
SumBase_Basic	561.276	467.050	1.667221
SumBase_ClearBit	218.854	1197.805	4.275782
SumTraits	82.642	3172.027	11.323129
Sum128Base_Basic	1651.064	158.773	0.566768
Sum128Base	1647.296	159.136	0.568065
Sum128Traits	1649.344	158.938	0.567359
Sum256Base_Basic	556.429	471.118	1.681742
Sum256Base	558.216	469.610	1.676359
Sum256Traits	80.124	3271.728	11.679029

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	932.086	281.245
SumBase	109.909	2385.106	8.480543
SumBase_Basic	341.794	766.965	2.727041
SumBase_ClearBit	105.044	2495.557	8.873262
SumTraits	42.771	6129.016	21.792479
Sum128Base_Basic	904.590	289.793	1.030396
Sum128Base	905.217	289.592	1.029682
Sum128Traits	905.524	289.494	1.029333
Sum256Base_Basic	318.797	822.290	2.923755
Sum256Base	317.567	825.477	2.935086
Sum256Traits	39.573	6624.296	23.553510

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	937.636	279.580
SumBase	204.969	1278.945	4.574524
SumBase_Basic	565.466	463.589	1.658163
SumBase_ClearBit	228.517	1147.151	4.103124
SumTraits	87.550	2994.228	10.709743
Sum128Base_Basic	1648.816	158.989	0.568672
Sum128Base	1653.530	158.536	0.567051
Sum128Traits	1655.085	158.387	0.566518
Sum256Base_Basic	563.010	465.611	1.665397
Sum256Base	566.290	462.915	1.655752
Sum256Traits	88.237	2970.900	10.626303

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	932.732	281.050
SumBase	103.943	2521.991	8.973470
SumBase_Basic	345.057	759.712	2.703124
SumBase_ClearBit	147.155	1781.410	6.338415
SumTraits	79.924	3279.931	11.670288
Sum128Base_Basic	1377.052	190.366	0.677339
Sum128Base	1201.654	218.153	0.776207
Sum128Traits	1130.189	231.947	0.825288
Sum256Base_Basic	451.767	580.264	2.064632
Sum256Base	422.852	619.942	2.205809
Sum256Traits	49.470	5299.073	18.854573

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1100.761	238.148
SumBase	136.443	1921.266	8.067530
SumBase_Add	119.131	2200.473	9.239941
SumTraits	86.957	3014.638	12.658676
Sum128Base_Basic	1646.448	159.218	0.668567
Sum128Base	1646.253	159.237	0.668646
Sum128Traits	1645.640	159.296	0.668895
Sum256Base_Basic	560.137	468.000	1.965163
Sum256Base	560.886	467.375	1.962540
Sum256Traits	83.145	3152.866	13.239106

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	934.615	280.483
SumBase	56.145	4669.012	16.646300
SumBase_Add	54.598	4801.331	17.118053
SumTraits	40.271	6509.488	23.208098
Sum128Base_Basic	900.412	291.138	1.037986
Sum128Base	899.116	291.557	1.039481
Sum128Traits	899.355	291.480	1.039206
Sum256Base_Basic	318.914	821.989	2.930616
Sum256Base	320.894	816.917	2.912533
Sum256Traits	40.242	6514.154	23.224736

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1212.922	216.126
SumBase	144.408	1815.298	8.399261
SumBase_ClearBit	144.579	1813.153	8.389335
SumBase_ClearBit_Not	162.814	1610.078	7.449720
SumTraits	82.068	3194.236	14.779514
Sum128Base_Basic	2384.951	109.916	0.508573
Sum128Base	2395.676	109.424	0.506296
Sum128Traits	2387.539	109.797	0.508022
Sum256Base_Basic	1513.295	173.227	0.801511
Sum256Base	1520.741	172.379	0.797586
Sum256Traits	82.852	3164.017	14.639692

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1372.789	190.957
SumBase	76.175	3441.352	18.021576
SumBase_ClearBit	75.953	3451.416	18.074281
SumTraits	39.986	6555.822	34.331350
Sum128Base_Basic	1777.978	147.439	0.772107
Sum128Base	2155.495	121.617	0.636879
Sum128Traits	2446.589	107.147	0.561103
Sum256Base_Basic	1959.149	133.805	0.700706
Sum256Base	1453.811	180.315	0.944269
Sum256Traits	39.980	6556.909	34.337042

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
SumScalar	937.699	279.561
SumBcl	87.075	3010.554	10.768867
SumBase	88.316	2968.252	10.617552
SumBase_Basic	528.462	496.050	1.774391
SumBase_ClearBit	223.157	1174.705	4.201965
SumTraits	84.429	3104.910	11.106383
Sum128Base_Basic	1659.713	157.945	0.564977
Sum128Base	1645.786	159.282	0.569758
Sum128Traits	1655.750	158.323	0.566329
Sum256Base_Basic	492.207	532.589	1.905090
Sum256Base	491.424	533.437	1.908125
Sum256Traits	85.082	3081.069	11.021104

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	933.517	280.813
SumBcl	39.343	6663.045	23.727678
SumBase	39.436	6647.332	23.671724
SumBase_Basic	333.751	785.447	2.797044
SumBase_ClearBit	103.692	2528.092	9.002755
SumTraits	39.889	6571.875	23.403013
Sum128Base_Basic	906.395	289.216	1.029924
Sum128Base	902.107	290.591	1.034819
Sum128Traits	900.825	291.004	1.036291
Sum256Base_Basic	296.180	885.084	3.151860
Sum256Base	295.810	886.191	3.155803
Sum256Traits	41.414	6329.864	22.541190

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	935.677	280.165
SumBcl	84.809	3091.000	11.032785
SumBase	81.770	3205.871	11.442798
SumBase_Basic	528.825	495.710	1.769351
SumBase_ClearBit	223.181	1174.578	4.192452
SumTraits	84.005	3120.590	11.138403
Sum128Base_Basic	1638.685	159.972	0.570993
Sum128Base	1648.433	159.026	0.567616
Sum128Traits	1649.657	158.908	0.567195
Sum256Base_Basic	560.886	467.375	1.668214
Sum256Base	561.863	466.562	1.665312
Sum256Traits	88.756	2953.529	10.542109

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	936.730	279.850
SumBcl	39.284	6673.020	23.844971
SumBase	39.159	6694.421	23.921445
SumBase_Basic	343.861	762.355	2.724153
SumBase_ClearBit	112.577	2328.569	8.320769
SumTraits	39.678	6606.767	23.608228
Sum128Base_Basic	904.587	289.794	1.035534
Sum128Base	906.871	289.064	1.032925
Sum128Traits	908.719	288.476	1.030825
Sum256Base_Basic	319.726	819.903	2.929792
Sum256Base	316.883	827.258	2.956074
Sum256Traits	39.204	6686.638	23.893632

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	933.113	280.935
SumBase	112.466	2330.883	8.296879
SumBase_Add	115.207	2275.420	8.099457
SumTraits	82.474	3178.493	11.313983
Sum128Base_Basic	1647.219	159.143	0.566478
Sum128Base	1651.519	158.729	0.565003
Sum128Traits	1640.175	159.827	0.568910
Sum256Base_Basic	557.664	470.075	1.673252
Sum256Base	558.373	469.478	1.671127
Sum256Traits	83.116	3153.965	11.226673

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	931.875	281.308
SumBase	49.965	5246.601	18.650728
SumBase_Add	51.416	5098.525	18.124344
SumTraits	39.660	6609.823	23.496737
Sum128Base_Basic	906.535	289.171	1.027952
Sum128Base	902.520	290.458	1.032525
Sum128Traits	905.731	289.428	1.028865
Sum256Base_Basic	317.800	824.871	2.932268
Sum256Base	320.390	818.202	2.908560
Sum256Traits	42.049	6234.231	22.161574

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1299.279	201.761
SumBase	104.773	2502.016	12.400878
SumBase_ClearBit	146.615	1787.973	8.861830
SumBase_ClearBit_Not	153.672	1705.871	8.454901
SumTraits	81.026	3235.294	16.035269
Sum128Base_Basic	2410.643	108.744	0.538976
Sum128Base	2387.518	109.798	0.544196
Sum128Traits	2384.049	109.957	0.544988
Sum256Base_Basic	1366.538	191.831	0.950781
Sum256Base	1537.403	170.511	0.845113
Sum256Traits	86.081	3045.328	15.093726

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1306.029	200.718
SumBase	44.495	5891.495	29.352048
SumBase_ClearBit	76.266	3437.217	17.124578
SumTraits	43.135	6077.277	30.277632
Sum128Base_Basic	1645.258	159.333	0.793814
Sum128Base	1808.577	144.945	0.722131
Sum128Traits	1795.557	145.996	0.727367
Sum256Base_Basic	1484.109	176.634	0.880009
Sum256Base	1474.119	177.831	0.885973
Sum256Traits	41.421	6328.726	31.530381

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
SumScalar	939.154	279.128
SumBcl	80.843	3242.627	11.616993
SumBase	82.067	3194.279	11.443779
SumBase_Basic	560.815	467.434	1.674622
SumBase_ClearBit	211.474	1239.603	4.440984
SumTraits	80.621	3251.552	11.648967
Sum128Base_Basic	1640.783	159.768	0.572382
Sum128Base	1641.960	159.653	0.571971
Sum128Traits	1643.479	159.506	0.571442
Sum256Base_Basic	558.334	469.511	1.682063
Sum256Base	559.782	468.297	1.677714
Sum256Traits	81.616	3211.921	11.506987

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	934.718	280.453
SumBcl	39.320	6666.958	23.772141
SumBase	39.330	6665.210	23.765909
SumBase_Basic	346.840	755.807	2.694954
SumBase_ClearBit	112.020	2340.143	8.344168
SumTraits	40.663	6446.697	22.986765
Sum128Base_Basic	903.453	290.158	1.034606
Sum128Base	914.194	286.749	1.022450
Sum128Traits	1015.316	258.190	0.920617
Sum256Base_Basic	321.007	816.630	2.911830
Sum256Base	316.607	827.980	2.952299
Sum256Traits	40.159	6527.725	23.275681

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	934.620	280.482
SumBcl	82.190	3189.489	11.371458
SumBase	83.342	3145.399	11.214264
SumBase_Basic	556.814	470.792	1.678513
SumBase_ClearBit	210.725	1244.012	4.435266
SumTraits	80.612	3251.925	11.594063
Sum128Base_Basic	1643.090	159.543	0.568818
Sum128Base	1639.258	159.916	0.570148
Sum128Traits	1642.862	159.565	0.568897
Sum256Base_Basic	491.027	533.869	1.903398
Sum256Base	489.704	535.311	1.908542
Sum256Traits	85.465	3067.252	10.935650

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	934.110	280.635
SumBcl	41.380	6335.088	22.574121
SumBase	40.592	6457.957	23.011945
SumBase_Basic	340.108	770.766	2.746509
SumBase_ClearBit	107.678	2434.517	8.675031
SumTraits	39.434	6647.730	23.688172
Sum128Base_Basic	900.523	291.102	1.037297
Sum128Base	903.184	290.244	1.034241
Sum128Traits	899.794	291.338	1.038138
Sum256Base_Basic	295.912	885.886	3.156719
Sum256Base	296.008	885.597	3.155691
Sum256Traits	39.359	6660.299	23.732958

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	933.204	280.907
SumBase	100.907	2597.889	9.248204
SumBase_Add	102.217	2564.584	9.129641
SumTraits	80.287	3265.075	11.623314
Sum128Base_Basic	1639.489	159.894	0.569205
Sum128Base	1638.220	160.018	0.569645
Sum128Traits	1637.472	160.091	0.569906
Sum256Base_Basic	493.074	531.652	1.892624
Sum256Base	489.291	535.763	1.907259
Sum256Traits	85.460	3067.464	10.919840

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	933.270	280.888
SumBase	45.086	5814.252	20.699562
SumBase_Add	51.409	5099.222	18.153956
SumTraits	40.422	6485.141	23.088022
Sum128Base_Basic	902.377	290.504	1.034235
Sum128Base	902.026	290.617	1.034638
Sum128Traits	902.043	290.611	1.034618
Sum256Base_Basic	296.214	884.982	3.150663
Sum256Base	297.132	882.247	3.140924
Sum256Traits	42.483	6170.518	21.967920

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1284.245	204.123
SumBase	90.262	2904.255	14.227962
SumBase_ClearBit	153.758	1704.912	8.352371
SumBase_ClearBit_Not	172.748	1517.497	7.434224
SumTraits	82.217	3188.426	15.620113
Sum128Base_Basic	2408.378	108.847	0.533240
Sum128Base	2411.906	108.687	0.532460
Sum128Traits	2394.532	109.476	0.536324
Sum256Base_Basic	1361.668	192.517	0.943141
Sum256Base	1363.918	192.199	0.941585
Sum256Traits	80.376	3261.483	15.978020

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1242.862	210.920
SumBase	46.796	5601.870	26.559252
SumBase_ClearBit	79.204	3309.733	15.691908
SumTraits	42.657	6145.363	29.136032
Sum128Base_Basic	1771.879	147.947	0.701437
Sum128Base	1728.082	151.696	0.719214
Sum128Traits	1640.446	159.800	0.757637
Sum256Base_Basic	1320.752	198.481	0.941025
Sum256Base	1394.925	187.927	0.890988
Sum256Traits	41.840	6265.317	29.704751

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
SumScalar	936.340	279.967
SumBcl	80.719	3247.624	11.600041
SumBase	80.185	3269.246	11.677274
SumBase_Basic	531.222	493.473	1.762615
SumBase_ClearBit	212.358	1234.445	4.409259
SumTraits	81.751	3206.632	11.453624
Sum128Bcl	158.357	1655.395	5.912833
Sum128Base_Basic	865.938	302.729	1.081302
Sum128Base	157.995	1659.188	5.926380
Sum128Traits	158.511	1653.792	5.907105
Sum256Bcl	85.980	3048.889	10.890191
Sum256Base_Basic	489.229	535.830	1.913909
Sum256Base	84.863	3089.020	11.033533
Sum256Traits	84.682	3095.625	11.057122

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
SumScalar	931.543	281.408
SumBcl	39.504	6635.887	23.580999
SumBase	39.998	6553.857	23.289499
SumBase_Basic	332.561	788.257	2.801117
SumBase_ClearBit	103.741	2526.898	8.979475
SumTraits	39.575	6624.018	23.538821
Sum128Bcl	78.574	3336.253	11.855565
Sum128Base_Basic	468.586	559.436	1.987986
Sum128Base	78.617	3334.433	11.849097
Sum128Traits	78.287	3348.518	11.899147
Sum256Bcl	40.065	6542.927	23.250659
Sum256Base_Basic	283.776	923.770	3.282668
Sum256Base	41.769	6276.027	22.302216
Sum256Traits	40.067	6542.642	23.249649

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
SumScalar	939.494	279.027
SumBcl	82.390	3181.729	11.402948
SumBase	84.897	3087.774	11.066225
SumBase_Basic	532.630	492.169	1.763876
SumBase_ClearBit	199.578	1313.490	4.707398
SumTraits	80.569	3253.668	11.660771
Sum128Bcl	159.247	1646.149	5.899608
Sum128Base_Basic	860.631	304.595	1.091633
Sum128Base	158.251	1656.506	5.936725
Sum128Traits	158.654	1652.297	5.921642
Sum256Bcl	81.592	3212.858	11.514511
Sum256Base_Basic	490.137	534.838	1.916799
Sum256Base	80.716	3247.740	11.639523
Sum256Traits	80.691	3248.753	11.643155

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
SumScalar	931.508	281.419
SumBcl	42.555	6160.084	21.889370
SumBase	42.432	6178.017	21.953093
SumBase_Basic	342.393	765.623	2.720582
SumBase_ClearBit	108.488	2416.349	8.586306
SumTraits	42.226	6208.141	22.060137
Sum128Bcl	78.513	3338.840	11.864303
Sum128Base_Basic	467.763	560.421	1.991410
Sum128Base	78.512	3338.906	11.864538
Sum128Traits	78.315	3347.296	11.894350
Sum256Bcl	39.772	6591.146	23.421113
Sum256Base_Basic	283.363	925.118	3.287333
Sum256Base	39.369	6658.583	23.660744
Sum256Traits	42.354	6189.342	21.993336

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	932.655	281.073
SumBase	106.231	2467.688	8.779537
SumBase_Add	101.427	2584.549	9.195304
SumTraits	80.716	3247.742	11.554809
Sum128Base_Basic	860.365	304.689	1.084023
Sum128Base	174.157	1505.217	5.355259
Sum128Traits	173.988	1506.678	5.360457
Sum256Base_Basic	488.821	536.278	1.907967
Sum256Base	106.828	2453.877	8.730399
Sum256Traits	81.702	3208.535	11.415321

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	932.486	281.124
SumBase	56.640	4628.288	16.463516
SumBase_Add	53.970	4857.226	17.277884
SumTraits	40.584	6459.225	22.976434
Sum128Base_Basic	471.856	555.559	1.976208
Sum128Base	90.861	2885.109	10.262768
Sum128Traits	90.093	2909.698	10.350234
Sum256Base_Basic	282.512	927.905	3.300696
Sum256Base	55.706	4705.889	16.739554
Sum256Traits	42.269	6201.831	22.060845

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	934.111	280.635
SumBase	99.990	2621.701	9.342038
SumBase_ClearBit	153.425	1708.608	6.088367
SumBase_ClearBit_Not	158.281	1656.192	5.901592
SumTraits	83.278	3147.820	11.216782
Sum128Base_Basic	868.270	301.915	1.075830
Sum128Base	172.231	1522.046	5.423582
Sum128Traits	178.414	1469.299	5.235625
Sum256Base_Basic	496.478	528.007	1.881474
Sum256Base	98.517	2660.909	9.481750
Sum256Traits	86.795	3020.262	10.762249

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	932.504	281.118
SumBase	49.524	5293.321	18.829511
SumBase_ClearBit	75.077	3491.647	12.420558
SumTraits	42.516	6165.792	21.933084
Sum128Base_Basic	471.694	555.750	1.976924
Sum128Base	87.587	2992.939	10.646544
Sum128Traits	85.257	3074.751	10.937567
Sum256Base_Basic	282.613	927.573	3.299581
Sum256Base	49.522	5293.440	18.829935
Sum256Traits	41.995	6242.231	22.204992

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
SumScalar	317.070	826.769
SumBase	543.500	482.326	0.583386
SumBase_Basic	543.367	482.444	0.583529
SumBase_ClearBit	930.212	281.811	0.340858
SumTraits	551.277	475.521	0.575156
Sum128Base_Basic	1161.122	225.768	0.273072
Sum128Base	1153.741	227.212	0.274819
Sum128Traits	1151.643	227.626	0.275320
Sum256Base_Basic	1834.110	142.927	0.172874
Sum256Base	1843.067	142.232	0.172034
Sum256Traits	1826.478	143.524	0.173597

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	291.588	899.023
SumBase	456.712	573.981	0.638450
SumBase_Basic	799.928	327.709	0.364517
SumBase_ClearBit	456.914	573.727	0.638167
SumTraits	455.460	575.558	0.640204
Sum128Base_Basic	1463.400	179.133	0.199253
Sum128Base	1464.546	178.993	0.199098
Sum128Traits	1467.358	178.650	0.198716
Sum256Base_Basic	1293.536	202.657	0.225419
Sum256Base	1322.264	198.254	0.220521
Sum256Traits	1315.270	199.308	0.221694

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	291.446	899.459
SumBase	551.048	475.719	0.528895
SumBase_Basic	549.251	477.275	0.530625
SumBase_ClearBit	930.752	281.648	0.313130
SumTraits	548.873	477.604	0.530990
Sum128Base_Basic	1150.807	227.791	0.253254
Sum128Base	1165.589	224.903	0.250042
Sum128Traits	1153.259	227.307	0.252716
Sum256Base_Basic	1837.476	142.665	0.158612
Sum256Base	1835.100	142.850	0.158818
Sum256Traits	1837.866	142.635	0.158579

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	291.489	899.329
SumBase	456.763	573.918	0.638162
SumBase_Basic	796.813	328.991	0.365818
SumBase_ClearBit	457.000	573.619	0.637830
SumTraits	457.385	573.136	0.637294
Sum128Base_Basic	1466.307	178.778	0.198791
Sum128Base	1464.530	178.995	0.199032
Sum128Traits	1464.602	178.987	0.199022
Sum256Base_Basic	1287.702	203.575	0.226363
Sum256Base	1315.084	199.336	0.221650
Sum256Traits	1319.133	198.725	0.220970

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	316.923	827.154
SumBase	363.595	720.979	0.871638
SumBase_Add	365.927	716.384	0.866083
SumTraits	364.311	719.561	0.869924
Sum128Base_Basic	1142.016	229.545	0.277512
Sum128Base	1153.563	227.247	0.274734
Sum128Traits	1148.873	228.175	0.275856
Sum256Base_Basic	1829.163	143.314	0.173261
Sum256Base	1834.785	142.875	0.172730
Sum256Traits	1829.334	143.300	0.173245

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	317.383	825.955
SumBase	177.812	1474.272	1.784931
SumBase_Add	178.294	1470.287	1.780106
SumTraits	178.301	1470.230	1.780038
Sum128Base_Basic	1466.478	178.758	0.216425
Sum128Base	1458.794	179.699	0.217565
Sum128Traits	1467.930	178.581	0.216211
Sum256Base_Basic	1291.939	202.907	0.245664
Sum256Base	1317.883	198.913	0.240828
Sum256Traits	1316.484	199.124	0.241084

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	2242.216	116.913
SumBase	544.221	481.687	4.120047
SumBase_ClearBit	548.056	478.316	4.091214
SumBase_ClearBit_Not	637.976	410.900	3.514578
SumTraits	550.923	475.827	4.069926
Sum128Base_Basic	3308.714	79.228	0.677670
Sum128Base	3324.192	78.859	0.674515
Sum128Traits	3323.384	78.879	0.674679
Sum256Base_Basic	4112.557	63.742	0.545212
Sum256Base	4058.925	64.585	0.552416
Sum256Traits	4612.651	56.832	0.486101

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	2671.889	98.112
SumBase	262.133	1000.043	10.192884
SumBase_ClearBit	264.803	989.959	10.090102
SumTraits	263.736	993.963	10.130916
Sum128Base_Basic	3377.377	77.618	0.791114
Sum128Base	3410.647	76.860	0.783397
Sum128Traits	3422.394	76.597	0.780708
Sum256Base_Basic	3810.622	68.793	0.701169
Sum256Base	3801.375	68.960	0.702874
Sum256Traits	3782.718	69.300	0.706341

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
SumScalar	316.330	828.704
SumBcl	124.946	2098.061	2.531740
SumBase	125.300	2092.123	2.524574
SumBase_Basic	544.567	481.381	0.580884
SumBase_ClearBit	817.258	320.760	0.387063
SumTraits	133.377	1965.433	2.371696
Sum128Base_Basic	560.775	467.467	0.564095
Sum128Base	558.981	468.968	0.565905
Sum128Traits	124.937	2098.211	2.531920
Sum256Base_Basic	1236.534	211.999	0.255820
Sum256Base	1227.509	213.558	0.257701
Sum256Traits	1228.181	213.441	0.257560

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	291.514	899.250
SumBcl	62.607	4187.114	4.656231
SumBase	62.792	4174.828	4.642569
SumBase_Basic	798.860	328.147	0.364912
SumBase_ClearBit	399.063	656.898	0.730496
SumTraits	66.789	3924.946	4.364690
Sum128Base_Basic	833.498	314.511	0.349748
Sum128Base	834.980	313.952	0.349127
Sum128Traits	62.674	4182.635	4.651250
Sum256Base_Basic	958.671	273.445	0.304081
Sum256Base	992.366	264.161	0.293757
Sum256Traits	988.093	265.303	0.295027

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.743	901.636
SumBcl	125.226	2093.372	2.321748
SumBase	125.214	2093.570	2.321968
SumBase_Basic	551.110	475.666	0.527558
SumBase_ClearBit	814.719	321.760	0.356862
SumTraits	125.126	2095.045	2.323604
Sum128Base_Basic	560.564	467.644	0.518661
Sum128Base	557.370	470.323	0.521633
Sum128Traits	133.176	1968.408	2.183152
Sum256Base_Basic	1229.837	213.153	0.236407
Sum256Base	1218.587	215.121	0.238590
Sum256Traits	1221.444	214.618	0.238032

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	317.121	826.638
SumBcl	62.601	4187.530	5.065736
SumBase	62.669	4182.983	5.060235
SumBase_Basic	799.889	327.725	0.396456
SumBase_ClearBit	399.879	655.558	0.793042
SumTraits	66.741	3927.757	4.751484
Sum128Base_Basic	833.009	314.695	0.380693
Sum128Base	833.486	314.515	0.380475
Sum128Traits	62.621	4186.191	5.064116
Sum256Base_Basic	956.040	274.198	0.331702
Sum256Base	991.410	264.415	0.319868
Sum256Traits	992.343	264.167	0.319568

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	316.464	828.353
SumBase	364.075	720.028	0.869229
SumBase_Add	364.393	719.400	0.868470
SumTraits	133.525	1963.255	2.370071
Sum128Base_Basic	558.609	469.280	0.566522
Sum128Base	557.311	470.373	0.567841
Sum128Traits	126.160	2077.867	2.508433
Sum256Base_Basic	1219.873	214.894	0.259424
Sum256Base	1224.538	214.076	0.258436
Sum256Traits	1229.659	213.184	0.257359

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	317.146	826.573
SumBase	179.220	1462.693	1.769588
SumBase_Add	176.766	1483.004	1.794160
SumTraits	62.620	4186.280	5.064624
Sum128Base_Basic	834.895	313.985	0.379863
Sum128Base	833.478	314.518	0.380509
Sum128Traits	66.701	3930.141	4.754743
Sum256Base_Basic	959.200	273.294	0.330636
Sum256Base	989.692	264.874	0.320449
Sum256Traits	988.136	265.291	0.320954

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1910.808	137.190
SumBase	246.043	1065.440	7.766154
SumBase_ClearBit	530.811	493.856	3.599791
SumBase_ClearBit_Not	591.622	443.094	3.229781
SumTraits	133.477	1963.968	14.315667
Sum128Base_Basic	2022.301	129.627	0.944868
Sum128Base	2055.350	127.542	0.929675
Sum128Traits	125.070	2095.975	15.277883
Sum256Base_Basic	2670.699	98.156	0.715471
Sum256Base	2584.409	101.433	0.739360
Sum256Traits	2654.521	98.754	0.719832

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1971.617	132.959
SumBase	119.910	2186.171	16.442457
SumBase_ClearBit	255.455	1026.186	7.718066
SumTraits	62.652	4184.152	31.469515
Sum128Base_Basic	2157.730	121.491	0.913746
Sum128Base	2077.086	126.208	0.949222
Sum128Traits	66.819	3923.172	29.506646
Sum256Base_Basic	2593.234	101.088	0.760293
Sum256Base	2515.341	104.218	0.783837
Sum256Traits	2492.055	105.192	0.791161

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
SumScalar	323.037	811.499
SumBcl	135.533	1934.170	2.383452
SumBase	127.062	2063.120	2.542355
SumBase_Basic	564.381	464.481	0.572373
SumBase_ClearBit	774.045	338.668	0.417336
SumTraits	133.254	1967.245	2.424211
Sum128Base_Basic	559.042	468.917	0.577840
Sum128Base	560.446	467.741	0.576392
Sum128Traits	125.136	2094.867	2.581477
Sum256Base_Basic	1226.708	213.697	0.263336
Sum256Base	1225.999	213.821	0.263488
Sum256Traits	1226.392	213.752	0.263404

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	290.991	900.867
SumBcl	63.034	4158.774	4.616415
SumBase	66.987	3913.335	4.343967
SumBase_Basic	798.366	328.351	0.364483
SumBase_ClearBit	367.659	713.008	0.791469
SumTraits	67.004	3912.364	4.342889
Sum128Base_Basic	833.701	314.434	0.349035
Sum128Base	832.414	314.920	0.349575
Sum128Traits	67.226	3899.422	4.328523
Sum256Base_Basic	959.181	273.300	0.303374
Sum256Base	988.358	265.232	0.294418
Sum256Traits	989.354	264.965	0.294122

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.660	901.892
SumBcl	133.335	1966.058	2.179927
SumBase	125.058	2096.187	2.324211
SumBase_Basic	551.006	475.755	0.527508
SumBase_ClearBit	763.393	343.393	0.380748
SumTraits	133.425	1964.730	2.178454
Sum128Base_Basic	555.206	472.156	0.523518
Sum128Base	557.321	470.365	0.521531
Sum128Traits	124.942	2098.120	2.326354
Sum256Base_Basic	1227.126	213.624	0.236862
Sum256Base	1219.387	214.980	0.238366
Sum256Traits	1224.271	214.122	0.237415

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	291.112	900.491
SumBcl	62.995	4161.340	4.621188
SumBase	67.043	3910.103	4.342189
SumBase_Basic	800.476	327.485	0.363674
SumBase_ClearBit	368.057	712.237	0.790943
SumTraits	63.021	4159.649	4.619310
Sum128Base_Basic	834.189	314.250	0.348976
Sum128Base	832.980	314.706	0.349483
Sum128Traits	67.169	3902.757	4.334030
Sum256Base_Basic	959.037	273.341	0.303546
Sum256Base	987.814	265.378	0.294703
Sum256Traits	990.650	264.618	0.293860

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	315.742	830.248
SumBase	350.381	748.168	0.901138
SumBase_Add	349.901	749.195	0.902375
SumTraits	125.127	2095.018	2.523365
Sum128Base_Basic	559.906	468.193	0.563920
Sum128Base	557.293	470.388	0.566564
Sum128Traits	133.352	1965.800	2.367728
Sum256Base_Basic	1226.345	213.760	0.257466
Sum256Base	1223.985	214.173	0.257962
Sum256Traits	1215.766	215.620	0.259706

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
SumScalar	316.655	827.853
SumBase	212.323	1234.648	1.491385
SumBase_Add	212.266	1234.978	1.491785
SumTraits	67.220	3899.819	4.710763
Sum128Base_Basic	833.134	314.648	0.380077
Sum128Base	832.774	314.784	0.380242
Sum128Traits	63.013	4160.155	5.025234
Sum256Base_Basic	958.239	273.568	0.330455
Sum256Base	991.331	264.437	0.319425
Sum256Traits	990.856	264.563	0.319577

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1720.017	152.408
SumBase	244.616	1071.656	7.031501
SumBase_ClearBit	486.134	539.242	3.538154
SumBase_ClearBit_Not	553.972	473.208	3.104878
SumTraits	133.275	1966.935	12.905735
Sum128Base_Basic	1681.147	155.932	1.023121
Sum128Base	1717.656	152.617	1.001374
Sum128Traits	125.188	2094.000	13.739453
Sum256Base_Basic	2331.850	112.419	0.737619
Sum256Base	2218.048	118.187	0.775464
Sum256Traits	2270.676	115.448	0.757491

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
SumScalar	1656.901	158.213
SumBase	144.597	1812.929	11.458754
SumBase_ClearBit	234.271	1118.979	7.072590
SumTraits	62.949	4164.395	26.321378
Sum128Base_Basic	1732.923	151.273	0.956131
Sum128Base	1685.165	155.560	0.983228
Sum128Traits	67.108	3906.307	24.690112
Sum256Base_Basic	2276.894	115.132	0.727702
Sum256Base	2214.783	118.361	0.748110
Sum256Traits	2236.211	117.227	0.740941

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
SumScalar	210.975	1242.533
SumBcl	106.517	2461.046	1.980669
SumBase	106.582	2459.541	1.979457
SumBase_Basic	548.423	477.996	0.384695
SumBase_ClearBit	669.510	391.546	0.315119
SumTraits	106.282	2466.490	1.985050
Sum128Bcl	106.445	2462.722	1.982017
Sum128Base_Basic	552.363	474.586	0.381951
Sum128Base	106.346	2465.012	1.983861
Sum128Traits	106.531	2460.736	1.980419
Sum256Bcl	972.349	269.599	0.216975
Sum256Base_Basic	1158.500	226.279	0.182111
Sum256Base	1151.111	227.731	0.183280
Sum256Traits	1150.170	227.918	0.183430

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
SumScalar	211.240	1240.976
SumBcl	55.450	4727.534	3.809528
SumBase	55.368	4734.605	3.815225
SumBase_Basic	801.154	327.208	0.263670
SumBase_ClearBit	352.730	743.186	0.598872
SumTraits	55.100	4757.584	3.833742
Sum128Bcl	55.068	4760.402	3.836013
Sum128Base_Basic	805.000	325.645	0.262410
Sum128Base	55.130	4755.007	3.831666
Sum128Traits	55.208	4748.292	3.826255
Sum256Bcl	898.343	291.808	0.235144
Sum256Base_Basic	1012.581	258.887	0.208616
Sum256Base	936.876	279.806	0.225473
Sum256Traits	935.846	280.114	0.225721

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
SumScalar	210.551	1245.040
SumBcl	106.198	2468.457	1.982633
SumBase	106.115	2470.383	1.984181
SumBase_Basic	548.564	477.873	0.383821
SumBase_ClearBit	675.603	388.015	0.311649
SumTraits	106.157	2469.391	1.983384
Sum128Bcl	106.181	2468.847	1.982947
Sum128Base_Basic	551.315	475.489	0.381906
Sum128Base	106.325	2465.497	1.980256
Sum128Traits	106.197	2468.472	1.982646
Sum256Bcl	968.810	270.584	0.217329
Sum256Base_Basic	1159.761	226.033	0.181547
Sum256Base	1149.704	228.010	0.183135
Sum256Traits	1149.655	228.020	0.183143

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
SumScalar	210.897	1242.995
SumBcl	55.837	4694.784	3.776993
SumBase	55.097	4757.881	3.827756
SumBase_Basic	801.062	327.246	0.263272
SumBase_ClearBit	353.980	740.561	0.595787
SumTraits	55.094	4758.099	3.827930
Sum128Bcl	55.159	4752.548	3.823465
Sum128Base_Basic	805.684	325.368	0.261761
Sum128Base	55.196	4749.327	3.820873
Sum128Traits	55.128	4755.230	3.825622
Sum256Bcl	900.945	290.965	0.234084
Sum256Base_Basic	1008.530	259.927	0.209113
Sum256Base	936.269	279.988	0.225253
Sum256Traits	936.189	280.012	0.225272

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.613	1244.672
SumBase	418.215	626.817	0.503600
SumBase_Add	418.398	626.542	0.503379
SumTraits	106.128	2470.066	1.984512
Sum128Base_Basic	551.534	475.300	0.381867
Sum128Base	255.300	1026.807	0.824962
Sum128Traits	106.208	2468.209	1.983019
Sum256Base_Basic	1152.095	227.537	0.182809
Sum256Base	5213.624	50.281	0.040397
Sum256Traits	5214.234	50.275	0.040392

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	210.882	1243.083
SumBase	171.129	1531.852	1.232301
SumBase_Add	171.276	1530.531	1.231239
SumTraits	55.164	4752.053	3.822798
Sum128Base_Basic	805.360	325.499	0.261848
Sum128Base	140.584	1864.673	1.500039
Sum128Traits	55.073	4759.974	3.829170
Sum256Base_Basic	1008.903	259.831	0.209021
Sum256Base	3967.482	66.073	0.053153
Sum256Traits	3970.814	66.018	0.053108

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.656	1244.416
SumBase	271.710	964.792	0.775297
SumBase_ClearBit	433.446	604.790	0.486003
SumBase_ClearBit_Not	493.297	531.412	0.427037
SumTraits	106.113	2470.418	1.985203
Sum128Base_Basic	551.664	475.188	0.381856
Sum128Base	163.146	1606.804	1.291212
Sum128Traits	106.098	2470.777	1.985492
Sum256Base_Basic	1154.720	227.020	0.182431
Sum256Base	3213.017	81.588	0.065563
Sum256Traits	3220.259	81.405	0.065416

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	210.835	1243.358
SumBase	114.322	2293.027	1.844221
SumBase_ClearBit	227.052	1154.554	0.928577
SumTraits	55.073	4759.973	3.828320
Sum128Base_Basic	805.395	325.485	0.261779
Sum128Base	94.124	2785.098	2.239980
Sum128Traits	55.088	4758.605	3.827220
Sum256Base_Basic	1009.098	259.781	0.208935
Sum256Base	2249.556	116.531	0.093723
Sum256Traits	2238.560	117.104	0.094184

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

