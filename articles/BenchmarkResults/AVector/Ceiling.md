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

## X86

### AMD Ryzen 7 7840H
`AMD Ryzen 7 7840H w/ Radeon 780M Graphics`

#### .NET Framework

```
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9277.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	524.378	499.914
SumBase	196.283	1335.543	2.671547
SumBase_Basic	809.242	323.938	0.647987
SumBase_ClearBit	182.642	1435.292	2.871080
SumTraits	187.259	1399.898	2.800279

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	504.592	519.517
SumBase	97.389	2691.709	5.181176
SumBase_Basic	640.527	409.263	0.787776
SumBase_ClearBit	97.936	2676.679	5.152245
SumTraits	94.556	2772.380	5.336457

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	587.127	446.486
SumBase	188.625	1389.765	3.112673
SumBase_Basic	806.309	325.116	0.728166
SumBase_ClearBit	177.554	1476.421	3.306757
SumTraits	186.456	1405.933	3.148885

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	485.496	539.951
SumBase	98.010	2674.665	4.953537
SumBase_Basic	641.095	408.900	0.757292
SumBase_ClearBit	102.964	2545.973	4.715198
SumTraits	98.251	2668.103	4.941384

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	2066.007	126.884
SumBase	89.149	2940.523	23.174820
SumBase_Add	88.571	2959.711	23.326043
SumTraits	89.652	2924.023	23.044782

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	1964.811	133.419
SumBase	47.157	5558.990	41.665509
SumBase_Add	46.832	5597.585	41.954784
SumTraits	47.388	5531.812	41.461807

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1145.632	228.820
SumBase	122.214	2144.962	9.373997
SumBase_ClearBit	124.928	2098.362	9.170344
SumBase_ClearBit_Not	123.421	2123.982	9.282310
SumTraits	125.197	2093.857	9.150655

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	2062.552	127.097
SumBase	61.194	4283.817	33.705121
SumBase_ClearBit	65.182	4021.699	31.642777
SumTraits	63.481	4129.465	32.490683

```

#### .NET Core 2.1

```
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:	.NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	235.459	1113.331
SumBase	202.484	1294.643	1.162856
SumBase_Basic	514.451	509.561	0.457691
SumBase_ClearBit	205.388	1276.338	1.146414
SumTraits	206.722	1268.101	1.139016

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	234.135	1119.627
SumBase	101.573	2580.842	2.305090
SumBase_Basic	315.136	831.844	0.742965
SumBase_ClearBit	101.596	2580.249	2.304561
SumTraits	105.174	2492.476	2.226166

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	235.026	1115.384
SumBase	202.195	1296.489	1.162370
SumBase_Basic	518.323	505.754	0.453435
SumBase_ClearBit	204.510	1281.814	1.149213
SumTraits	202.824	1292.472	1.158769

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	234.583	1117.490
SumBase	103.367	2536.059	2.269423
SumBase_Basic	310.364	844.635	0.755832
SumBase_ClearBit	103.464	2533.667	2.267283
SumTraits	103.630	2529.623	2.263665

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	235.077	1115.140
SumBase	99.434	2636.358	2.364150
SumBase_Add	97.455	2689.910	2.412172
SumTraits	97.917	2677.199	2.400774

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	235.249	1114.327
SumBase	46.303	5661.500	5.080647
SumBase_Add	46.888	5590.835	5.017231
SumTraits	47.394	5531.160	4.963679

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1277.779	205.156
SumBase	129.888	2018.238	9.837578
SumBase_ClearBit	140.125	1870.781	9.118822
SumBase_ClearBit_Not	131.675	1990.840	9.704032
SumTraits	137.008	1913.341	9.326276

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	1207.962	217.013
SumBase	66.315	3953.042	18.215659
SumBase_ClearBit	69.878	3751.477	17.286848
SumTraits	70.221	3733.133	17.202316

```

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	235.614	1112.602
SumBase	159.206	1646.570	1.479928
SumBase_Basic	508.690	515.332	0.463177
SumBase_ClearBit	164.258	1595.926	1.434409
SumTraits	58.062	4514.893	4.057960
Sum128Base_Basic	940.839	278.628	0.250429
Sum128Base	940.142	278.835	0.250615
Sum128Traits	115.540	2268.862	2.039240
Sum256Base_Basic	509.691	514.320	0.462268
Sum256Base	507.862	516.172	0.463932
Sum256Traits	58.423	4486.965	4.032858

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	235.526	1113.013
SumBase	88.003	2978.817	2.676353
SumBase_Basic	281.769	930.352	0.835886
SumBase_ClearBit	87.273	3003.739	2.698745
SumTraits	30.071	8717.567	7.832403
Sum128Base_Basic	493.126	531.597	0.477619
Sum128Base	488.618	536.501	0.482026
Sum128Traits	58.885	4451.829	3.999799
Sum256Base_Basic	279.263	938.699	0.843386
Sum256Base	280.076	935.975	0.840938
Sum256Traits	29.911	8764.160	7.874265

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	234.562	1117.590
SumBase	162.886	1609.374	1.440040
SumBase_Basic	507.845	516.189	0.461877
SumBase_ClearBit	158.216	1656.870	1.482539
SumTraits	58.125	4510.025	4.035492
Sum128Base_Basic	939.514	279.021	0.249663
Sum128Base	940.449	278.744	0.249415
Sum128Traits	115.629	2267.117	2.028577
Sum256Base_Basic	509.337	514.677	0.460524
Sum256Base	508.953	515.065	0.460871
Sum256Traits	58.100	4511.975	4.037237

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	234.715	1116.860
SumBase	86.783	3020.682	2.704619
SumBase_Basic	279.668	937.341	0.839264
SumBase_ClearBit	88.875	2949.590	2.640966
SumTraits	29.869	8776.409	7.858108
Sum128Base_Basic	492.490	532.283	0.476588
Sum128Base	492.028	532.783	0.477036
Sum128Traits	59.081	4437.047	3.972787
Sum256Base_Basic	280.578	934.300	0.836541
Sum256Base	279.860	936.696	0.838687
Sum256Traits	29.948	8753.246	7.837369

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	234.652	1117.158
SumBase	74.312	3527.625	3.157676
SumBase_Add	75.720	3462.001	3.098934
SumTraits	58.526	4479.081	4.009352
Sum128Base_Basic	943.634	277.803	0.248669
Sum128Base	941.685	278.378	0.249184
Sum128Traits	115.988	2260.092	2.023072
Sum256Base_Basic	509.601	514.410	0.460463
Sum256Base	510.082	513.926	0.460029
Sum256Traits	58.184	4505.461	4.032965

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	234.688	1116.987
SumBase	37.506	6989.347	6.257320
SumBase_Add	38.213	6859.990	6.141512
SumTraits	29.935	8756.991	7.839830
Sum128Base_Basic	492.830	531.916	0.476206
Sum128Base	491.768	533.064	0.477234
Sum128Traits	58.856	4453.993	3.987506
Sum256Base_Basic	279.339	938.443	0.840155
Sum256Base	280.393	934.916	0.836998
Sum256Traits	29.907	8765.312	7.847280

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1427.177	183.680
SumBase	108.541	2415.164	13.148754
SumBase_ClearBit	113.870	2302.139	12.533416
SumBase_ClearBit_Not	120.076	2183.155	11.885642
SumTraits	58.339	4493.430	24.463351
Sum128Base_Basic	1508.551	173.772	0.946058
Sum128Base	1486.252	176.379	0.960252
Sum128Traits	115.831	2263.160	12.321208
Sum256Base_Basic	1267.427	206.832	1.126043
Sum256Base	1287.880	203.547	1.108160
Sum256Traits	58.318	4495.109	24.472491

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1145.174	228.912
SumBase	58.505	4480.716	19.573978
SumBase_ClearBit	58.399	4488.857	19.609541
SumTraits	29.709	8823.862	38.546977
Sum128Base_Basic	1158.172	226.343	0.988777
Sum128Base	1137.220	230.513	1.006995
Sum128Traits	59.001	4443.007	19.409244
Sum256Base_Basic	1213.719	215.984	0.943525
Sum256Base	1201.489	218.183	0.953130
Sum256Traits	30.925	8476.692	37.030370

```

#### .NET 5.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	5.0.17
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.17\
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
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
SumScalar	234.343	1118.633
SumBcl	58.384	4489.973	4.013803
SumBase	58.883	4451.919	3.979785
SumBase_Basic	513.359	510.645	0.456490
SumBase_ClearBit	157.632	1663.011	1.486646
SumTraits	58.120	4510.425	4.032086
Sum128Base_Basic	944.397	277.578	0.248141
Sum128Base	941.275	278.499	0.248964
Sum128Traits	115.594	2267.803	2.027299
Sum256Base_Basic	510.677	513.326	0.458887
Sum256Base	510.185	513.822	0.459330
Sum256Traits	58.150	4508.094	4.030002

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	235.331	1113.936
SumBcl	30.063	8719.789	7.827907
SumBase	29.834	8786.868	7.888125
SumBase_Basic	279.336	938.453	0.842466
SumBase_ClearBit	87.264	3004.028	2.696768
SumTraits	30.411	8619.946	7.738276
Sum128Base_Basic	489.820	535.185	0.480445
Sum128Base	493.998	530.658	0.476381
Sum128Traits	58.882	4452.020	3.996656
Sum256Base_Basic	280.967	933.005	0.837575
Sum256Base	279.879	936.633	0.840831
Sum256Traits	29.975	8745.291	7.850801

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	236.517	1108.353
SumBcl	58.135	4509.222	4.068397
SumBase	58.252	4500.136	4.060200
SumBase_Basic	515.046	508.972	0.459214
SumBase_ClearBit	158.453	1654.392	1.492658
SumTraits	58.217	4502.860	4.062658
Sum128Base_Basic	944.683	277.494	0.250366
Sum128Base	943.516	277.837	0.250676
Sum128Traits	115.404	2271.539	2.049472
Sum256Base_Basic	520.284	503.848	0.454592
Sum256Base	512.988	511.014	0.461057
Sum256Traits	58.293	4496.972	4.057345

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	234.648	1117.177
SumBcl	30.103	8708.178	7.794803
SumBase	29.829	8788.365	7.866580
SumBase_Basic	291.772	898.456	0.804220
SumBase_ClearBit	84.139	3115.592	2.788807
SumTraits	29.903	8766.582	7.847081
Sum128Base_Basic	494.210	530.430	0.474795
Sum128Base	491.075	533.817	0.477826
Sum128Traits	58.805	4457.875	3.990301
Sum256Base_Basic	289.466	905.612	0.810625
Sum256Base	288.946	907.241	0.812083
Sum256Traits	29.865	8777.526	7.856877

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	234.499	1117.892
SumBase	75.380	3477.632	3.110884
SumBase_Add	73.244	3579.048	3.201605
SumTraits	58.181	4505.682	4.030517
Sum128Base_Basic	947.368	276.708	0.247526
Sum128Base	948.264	276.446	0.247293
Sum128Traits	115.769	2264.366	2.025568
Sum256Base_Basic	515.185	508.834	0.455173
Sum256Base	514.749	509.266	0.455559
Sum256Traits	58.362	4491.675	4.017987

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	236.158	1110.035
SumBase	36.533	7175.487	6.464197
SumBase_Add	36.969	7090.888	6.387984
SumTraits	29.822	8790.145	7.918797
Sum128Base_Basic	494.562	530.053	0.477510
Sum128Base	492.827	531.919	0.479191
Sum128Traits	59.202	4427.968	3.989033
Sum256Base_Basic	290.617	902.025	0.812609
Sum256Base	290.979	900.902	0.811598
Sum256Traits	29.368	8926.301	8.041457

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1412.365	185.606
SumBase	63.770	4110.783	22.147848
SumBase_ClearBit	109.695	2389.750	12.875363
SumBase_ClearBit_Not	115.520	2269.258	12.226180
SumTraits	58.388	4489.716	24.189441
Sum128Base_Basic	1523.101	172.112	0.927295
Sum128Base	1536.466	170.615	0.919229
Sum128Traits	115.771	2264.337	12.199670
Sum256Base_Basic	1309.564	200.176	1.078500
Sum256Base	1308.076	200.404	1.079727
Sum256Traits	58.188	4505.136	24.272519

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1197.981	218.821
SumBase	32.396	8091.964	36.979751
SumBase_ClearBit	57.632	4548.546	20.786562
SumTraits	29.985	8742.571	39.952982
Sum128Base_Basic	1165.483	224.923	1.027884
Sum128Base	1180.112	222.135	1.015142
Sum128Traits	58.482	4482.511	20.484784
Sum256Base_Basic	1206.934	217.198	0.992582
Sum256Base	1250.432	209.643	0.958054
Sum256Traits	30.381	8628.577	39.432038

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.33
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.33\
RuntimeInformation.FrameworkDescription:	.NET 6.0.33
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.33/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
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
SumScalar	234.510	1117.838
SumBcl	58.151	4507.971	4.032759
SumBase	58.123	4510.185	4.034739
SumBase_Basic	536.646	488.486	0.436991
SumBase_ClearBit	159.142	1647.235	1.473590
SumTraits	58.179	4505.830	4.030843
Sum128Base_Basic	945.529	277.246	0.248020
Sum128Base	946.942	276.832	0.247650
Sum128Traits	115.615	2267.397	2.028377
Sum256Base_Basic	536.495	488.624	0.437115
Sum256Base	540.294	485.187	0.434041
Sum256Traits	58.478	4482.781	4.010224

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	234.821	1116.356
SumBcl	30.193	8682.272	7.777335
SumBase	29.866	8777.258	7.862421
SumBase_Basic	304.655	860.462	0.770778
SumBase_ClearBit	87.670	2990.124	2.678470
SumTraits	31.019	8450.954	7.570127
Sum128Base_Basic	491.629	533.215	0.477639
Sum128Base	491.786	533.045	0.477487
Sum128Traits	58.872	4452.815	3.988706
Sum256Base_Basic	310.427	844.462	0.756445
Sum256Base	302.480	866.649	0.776320
Sum256Traits	30.098	8709.734	7.801935

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	236.274	1109.494
SumBcl	58.493	4481.596	4.039316
SumBase	58.380	4490.326	4.047185
SumBase_Basic	508.556	515.467	0.464597
SumBase_ClearBit	163.963	1598.797	1.441015
SumTraits	58.442	4485.571	4.042898
Sum128Base_Basic	943.814	277.750	0.250339
Sum128Base	946.758	276.886	0.249561
Sum128Traits	115.932	2261.187	2.038035
Sum256Base_Basic	507.826	516.209	0.465265
Sum256Base	509.897	514.111	0.463375
Sum256Traits	58.066	4514.587	4.069051

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	235.513	1113.074
SumBcl	29.803	8796.019	7.902453
SumBase	29.944	8754.409	7.865070
SumBase_Basic	283.448	924.841	0.830889
SumBase_ClearBit	83.160	3152.271	2.832040
SumTraits	29.794	8798.479	7.904664
Sum128Base_Basic	491.260	533.615	0.479407
Sum128Base	492.487	532.286	0.478213
Sum128Traits	58.655	4469.266	4.015244
Sum256Base_Basic	278.904	939.909	0.844426
Sum256Base	282.056	929.404	0.834988
Sum256Traits	30.109	8706.537	7.822062

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	234.376	1118.474
SumBase	73.849	3549.714	3.173711
SumBase_Add	70.067	3741.319	3.345019
SumTraits	58.241	4501.004	4.024235
Sum128Base_Basic	941.441	278.450	0.248955
Sum128Base	941.303	278.491	0.248992
Sum128Traits	115.459	2270.445	2.029948
Sum256Base_Basic	509.161	514.855	0.460319
Sum256Base	507.429	516.612	0.461890
Sum256Traits	58.211	4503.320	4.026306

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	234.592	1117.447
SumBase	38.462	6815.641	6.099297
SumBase_Add	36.227	7236.071	6.475538
SumTraits	30.149	8694.942	7.781078
Sum128Base_Basic	489.949	535.044	0.478809
Sum128Base	491.737	533.098	0.477068
Sum128Traits	59.277	4422.343	3.957541
Sum256Base_Basic	280.576	934.308	0.836109
Sum256Base	280.099	935.897	0.837531
Sum256Traits	29.749	8811.958	7.885795

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1428.629	183.493
SumBase	62.336	4205.346	22.918236
SumBase_ClearBit	106.103	2470.666	13.464603
SumBase_ClearBit_Not	117.882	2223.790	12.119180
SumTraits	58.370	4491.105	24.475562
Sum128Base_Basic	1491.311	175.781	0.957968
Sum128Base	1488.132	176.156	0.960015
Sum128Traits	115.427	2271.080	12.376903
Sum256Base_Basic	1210.472	216.563	1.180225
Sum256Base	1252.710	209.261	1.140430
Sum256Traits	58.484	4482.296	24.427553

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1230.503	213.038
SumBase	32.158	8151.873	38.264860
SumBase_ClearBit	56.007	4680.523	21.970359
SumTraits	29.847	8782.919	41.226989
Sum128Base_Basic	1139.322	230.088	1.080031
Sum128Base	1203.720	217.778	1.022250
Sum128Traits	58.854	4454.165	20.907834
Sum256Base_Basic	1243.209	210.861	0.989780
Sum256Base	1193.734	219.600	1.030802
Sum256Traits	30.128	8701.146	40.843149

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.20
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.20\
RuntimeInformation.FrameworkDescription:	.NET 7.0.20
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.20/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
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
SumScalar	235.888	1111.309
SumBcl	58.483	4482.421	4.033460
SumBase	57.896	4527.851	4.074340
SumBase_Basic	508.567	515.456	0.463828
SumBase_ClearBit	142.168	1843.901	1.659216
SumTraits	58.241	4500.991	4.050170
Sum128Bcl	115.779	2264.167	2.037387
Sum128Base_Basic	940.355	278.771	0.250850
Sum128Base	115.509	2269.466	2.042155
Sum128Traits	115.804	2263.691	2.036959
Sum256Bcl	58.728	4463.718	4.016631
Sum256Base_Basic	510.144	513.863	0.462394
Sum256Base	58.254	4500.050	4.049324
Sum256Traits	58.167	4506.759	4.055361

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
SumScalar	236.095	1110.331
SumBcl	30.851	8497.222	7.652875
SumBase	30.962	8466.601	7.625297
SumBase_Basic	291.427	899.519	0.810136
SumBase_ClearBit	74.488	3519.277	3.169575
SumTraits	29.749	8811.839	7.936229
Sum128Bcl	58.842	4455.047	4.012360
Sum128Base_Basic	492.047	532.763	0.479823
Sum128Base	59.860	4379.274	3.944117
Sum128Traits	58.942	4447.495	4.005559
Sum256Bcl	29.873	8775.347	7.903364
Sum256Base_Basic	291.271	900.001	0.810570
Sum256Base	30.440	8611.785	7.756054
Sum256Traits	30.717	8534.262	7.686234

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
SumScalar	235.926	1111.129
SumBcl	58.092	4512.605	4.061280
SumBase	58.563	4476.309	4.028614
SumBase_Basic	516.764	507.280	0.456544
SumBase_ClearBit	146.359	1791.106	1.611970
SumTraits	58.443	4485.451	4.036842
Sum128Bcl	115.576	2268.161	2.041313
Sum128Base_Basic	939.976	278.884	0.250991
Sum128Base	115.926	2261.312	2.035148
Sum128Traits	115.669	2266.328	2.039662
Sum256Bcl	58.341	4493.280	4.043887
Sum256Base_Basic	519.122	504.976	0.454471
Sum256Base	58.247	4500.569	4.050448
Sum256Traits	58.057	4515.254	4.063664

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
SumScalar	236.722	1107.389
SumBcl	31.025	8449.483	7.630091
SumBase	30.203	8679.314	7.837635
SumBase_Basic	289.189	906.481	0.818574
SumBase_ClearBit	73.010	3590.516	3.242324
SumTraits	29.912	8763.939	7.914052
Sum128Bcl	59.188	4429.010	3.999505
Sum128Base_Basic	490.393	534.559	0.482720
Sum128Base	58.944	4447.329	4.016048
Sum128Traits	58.597	4473.682	4.039845
Sum256Bcl	30.193	8682.283	7.840315
Sum256Base_Basic	292.271	896.923	0.809943
Sum256Base	29.910	8764.382	7.914453
Sum256Traits	30.017	8733.232	7.886324

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	235.934	1111.091
SumBase	72.886	3596.652	3.237044
SumBase_Add	79.060	3315.779	2.984254
SumTraits	58.711	4464.953	4.018530
Sum128Base_Basic	943.406	277.870	0.250087
Sum128Base	135.176	1939.283	1.745386
Sum128Traits	116.188	2256.209	2.030625
Sum256Base_Basic	538.028	487.231	0.438516
Sum256Base	71.321	3675.536	3.308042
Sum256Traits	58.487	4482.124	4.033984

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	234.615	1117.337
SumBase	38.616	6788.431	6.075546
SumBase_Add	39.711	6601.339	5.908101
SumTraits	30.392	8625.540	7.719731
Sum128Base_Basic	491.962	532.854	0.476897
Sum128Base	70.435	3721.782	3.330940
Sum128Traits	59.353	4416.710	3.952890
Sum256Base_Basic	305.487	858.117	0.768003
Sum256Base	37.034	7078.442	6.335101
Sum256Traits	30.041	8726.256	7.809871

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	235.048	1115.277
SumBase	64.622	4056.570	3.637274
SumBase_ClearBit	95.695	2739.370	2.456223
SumBase_ClearBit_Not	118.549	2211.263	1.982702
SumTraits	58.697	4466.066	4.004444
Sum128Base_Basic	945.380	277.289	0.248628
Sum128Base	118.720	2208.091	1.979858
Sum128Traits	116.048	2258.920	2.025433
Sum256Base_Basic	538.135	487.135	0.436783
Sum256Base	61.056	4293.485	3.849701
Sum256Traits	58.667	4468.329	4.006473

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	235.505	1113.113
SumBase	33.787	7758.786	6.970349
SumBase_ClearBit	48.691	5383.849	4.836750
SumTraits	30.284	8656.281	7.776642
Sum128Base_Basic	491.879	532.944	0.478787
Sum128Base	60.952	4300.798	3.863757
Sum128Traits	59.234	4425.601	3.975878
Sum256Base_Basic	304.046	862.185	0.774571
Sum256Base	31.755	8255.089	7.416219
Sum256Traits	30.084	8713.616	7.828151

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.8
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.8\
RuntimeInformation.FrameworkDescription:	.NET 8.0.8
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector512.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844161	# 0x8177F7FF
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Avx512BW, Avx512CD, Avx512DQ, Avx512F, Avx512Vbmi, Avx512VL, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2, Avx512VL
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vector512s.Instance:	WVectorTraits512Avx512	// Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi, Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -1.5629256372728648E+21!=-1.562925637272894E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728648E+21!=-1.562925637272894E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728648E+21!=-1.562925637272894E+21
SumScalar	241.109	1087.242
SumBcl	58.714	4464.768	4.106507
SumBase	58.542	4477.845	4.118535
SumBase_Basic	538.290	486.994	0.447917
SumBase_ClearBit	137.330	1908.857	1.755687
SumTraits	58.536	4478.313	4.118965
Sum128Bcl	116.093	2258.055	2.076865
Sum128Base_Basic	952.780	275.136	0.253058
Sum128Base	116.145	2257.050	2.075940
Sum128Traits	115.729	2265.163	2.083402
Sum256Bcl	58.503	4480.847	4.121295
Sum256Base_Basic	538.333	486.955	0.447881
Sum256Base	58.513	4480.126	4.120633
Sum256Traits	58.640	4470.396	4.111683
Sum512Bcl	33.941	7723.433	7.103690
Sum512Base	33.917	7728.947	7.108762
Sum512Traits	33.890	7735.234	7.114544

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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.6394212E+11!=-3.6394507E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394212E+11!=-3.6394507E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394212E+11!=-3.6394507E+11
SumScalar	240.951	1087.957
SumBcl	30.021	8731.906	8.025963
SumBase	30.018	8732.772	8.026759
SumBase_Basic	306.296	855.852	0.786660
SumBase_ClearBit	70.284	3729.769	3.428230
SumTraits	30.115	8704.873	8.001116
Sum128Bcl	58.843	4454.953	4.094786
Sum128Base_Basic	493.776	530.896	0.487975
Sum128Base	59.081	4437.036	4.078317
Sum128Traits	59.347	4417.138	4.060029
Sum256Bcl	30.040	8726.615	8.021101
Sum256Base_Basic	296.111	885.290	0.813717
Sum256Base	30.146	8695.777	7.992756
Sum256Traits	30.146	8695.769	7.992748
Sum512Bcl	17.726	14788.692	13.593080
Sum512Base	17.629	14869.979	13.667795
Sum512Traits	17.800	14727.036	13.536409

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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -1.5629256372728648E+21!=-1.562925637272894E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728648E+21!=-1.562925637272894E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728648E+21!=-1.562925637272894E+21
SumScalar	241.468	1085.627
SumBcl	58.418	4487.354	4.133420
SumBase	58.282	4497.893	4.143127
SumBase_Basic	541.049	484.510	0.446295
SumBase_ClearBit	130.285	2012.084	1.853383
SumTraits	58.359	4491.956	4.137659
Sum128Bcl	115.567	2268.322	2.089411
Sum128Base_Basic	955.909	274.235	0.252605
Sum128Base	116.053	2258.839	2.080676
Sum128Traits	116.368	2252.709	2.075029
Sum256Bcl	58.567	4475.997	4.122959
Sum256Base_Basic	537.417	487.785	0.449312
Sum256Base	58.806	4457.743	4.106144
Sum256Traits	58.550	4477.255	4.124118
Sum512Bcl	34.194	7666.281	7.061612
Sum512Base	34.036	7701.966	7.094483
Sum512Traits	33.946	7722.285	7.113200

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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.6394212E+11!=-3.639452E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394212E+11!=-3.639452E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394212E+11!=-3.639452E+11
SumScalar	241.483	1085.561
SumBcl	30.046	8724.614	8.036964
SumBase	29.958	8750.346	8.060668
SumBase_Basic	306.212	856.086	0.788612
SumBase_ClearBit	65.433	4006.285	3.690521
SumTraits	30.001	8737.765	8.049078
Sum128Bcl	59.072	4437.728	4.087959
Sum128Base_Basic	495.903	528.619	0.486955
Sum128Base	59.186	4429.152	4.080059
Sum128Traits	59.224	4426.344	4.077472
Sum256Bcl	30.042	8725.996	8.038237
Sum256Base_Basic	307.545	852.377	0.785195
Sum256Base	29.985	8742.635	8.053564
Sum256Traits	30.329	8643.295	7.962054
Sum512Bcl	17.406	15060.156	13.873156
Sum512Base	17.453	15020.267	13.836411
Sum512Traits	17.316	15139.211	13.945980

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728648E+21!=-1.562925637272894E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728648E+21!=-1.562925637272894E+21
SumScalar	239.472	1094.675
SumBase	68.213	3843.009	3.510640
SumBase_Add	69.590	3766.970	3.441177
SumTraits	58.009	4519.018	4.128183
Sum128Base_Basic	944.690	277.492	0.253493
Sum128Base	152.118	1723.291	1.574250
Sum128Traits	115.509	2269.467	2.073188
Sum256Base_Basic	512.756	511.245	0.467029
Sum256Base	71.383	3672.362	3.354752
Sum256Traits	57.688	4544.186	4.151174
Sum512Base	61.305	4276.062	3.906240
Sum512Traits	32.186	8144.576	7.440179

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394218E+11!=-3.6394513E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394218E+11!=-3.6394513E+11
SumScalar	239.610	1094.046
SumBase	36.784	7126.659	6.514042
SumBase_Add	37.062	7073.163	6.465145
SumTraits	29.328	8938.254	8.169910
Sum128Base_Basic	495.070	529.509	0.483991
Sum128Base	71.314	3675.925	3.359938
Sum128Traits	57.743	4539.828	4.149578
Sum256Base_Basic	280.840	933.428	0.853190
Sum256Base	36.701	7142.648	6.528657
Sum256Traits	29.153	8991.935	8.218977
Sum512Base	32.636	8032.437	7.341959
Sum512Traits	16.824	15581.826	14.242392

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728648E+21!=-1.562925637272894E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728648E+21!=-1.562925637272894E+21
SumScalar	237.861	1102.091
SumBase	59.967	4371.441	3.966498
SumBase_ClearBit	102.165	2565.897	2.328208
SumBase_ClearBit_Not	106.615	2458.784	2.231018
SumTraits	57.726	4541.196	4.120528
Sum128Base_Basic	944.646	277.505	0.251799
Sum128Base	118.414	2213.788	2.008716
Sum128Traits	114.947	2280.565	2.069308
Sum256Base_Basic	515.418	508.605	0.461491
Sum256Base	59.972	4371.142	3.966226
Sum256Traits	57.837	4532.483	4.112622
Sum512Base	41.367	6337.014	5.749993
Sum512Traits	32.308	8113.934	7.362310

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394218E+11!=-3.6394513E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394218E+11!=-3.6394513E+11
SumScalar	238.241	1100.331
SumBase	30.706	8537.261	7.758808
SumBase_ClearBit	51.443	5095.842	4.631188
SumTraits	29.264	8957.758	8.140963
Sum128Base_Basic	492.774	531.977	0.483469
Sum128Base	60.174	4356.414	3.959183
Sum128Traits	57.912	4526.601	4.113852
Sum256Base_Basic	282.505	927.927	0.843316
Sum256Base	30.527	8587.412	7.804386
Sum256Traits	29.167	8987.733	8.168205
Sum512Base	21.543	12168.669	11.059093
Sum512Traits	17.098	15331.602	13.933621

```

### Intel Core i5-8250U
`Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 
``` 
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9195.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/910Soft/MyCode/VectorTraits_test/RunBenchmarks_All/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	705.186	371.737
SumBase	278.878	939.994	2.528652
SumBase_Basic	1237.477	211.838	0.569858
SumBase_ClearBit	315.093	831.958	2.238026
SumTraits	289.305	906.118	2.437521

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	1769.260	148.166
SumBase	239.372	1095.133	7.391261
SumBase_Basic	1722.277	152.208	1.027280
SumBase_ClearBit	165.518	1583.780	10.689230
SumTraits	245.925	1065.950	7.194298

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	731.396	358.416
SumBase	375.153	698.766	1.949595
SumBase_Basic	1071.785	244.586	0.682409
SumBase_ClearBit	356.867	734.571	2.049494
SumTraits	432.919	605.527	1.689454

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	1817.561	144.228
SumBase	169.327	1548.149	10.734005
SumBase_Basic	1603.846	163.447	1.133252
SumBase_ClearBit	215.677	1215.447	8.427232
SumTraits	231.943	1130.207	7.836226

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	3321.967	78.912
SumBase	153.973	1702.530	21.574963
SumBase_Add	155.611	1684.609	21.347863
SumTraits	166.921	1570.471	19.901479

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	4056.440	64.624
SumBase	123.828	2117.009	32.758784
SumBase_Add	124.467	2106.134	32.590506
SumTraits	82.757	3167.618	49.016004

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1684.438	155.627
SumBase	335.558	781.218	5.019811
SumBase_ClearBit	355.546	737.299	4.737607
SumBase_ClearBit_Not	318.250	823.704	5.292808
SumTraits	310.130	845.271	5.431389

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	3172.200	82.638
SumBase	201.179	1303.039	15.768052
SumBase_ClearBit	185.114	1416.122	17.136466
SumTraits	178.491	1468.666	17.772300

``` 

#### .NET Core 2.1 
``` 
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	930.843	281.620
SumBase	237.256	1104.902	3.923379
SumBase_Basic	527.363	497.085	1.765092
SumBase_ClearBit	238.696	1098.234	3.899704
SumTraits	237.783	1102.451	3.914676

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	930.165	281.825
SumBase	117.983	2221.882	7.883899
SumBase_Basic	565.599	463.480	1.644567
SumBase_ClearBit	115.361	2272.377	8.063071
SumTraits	116.520	2249.785	7.982909

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	930.721	281.657
SumBase	237.389	1104.280	3.920656
SumBase_Basic	526.759	497.655	1.766882
SumBase_ClearBit	238.638	1098.501	3.900137
SumTraits	236.612	1107.906	3.933528

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	929.784	281.941
SumBase	116.708	2246.156	7.966766
SumBase_Basic	568.212	461.349	1.636332
SumBase_ClearBit	116.618	2247.887	7.972906
SumTraits	116.362	2252.835	7.990454

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	929.298	282.088
SumBase	116.915	2242.179	7.948501
SumBase_Add	119.677	2190.424	7.765029
SumTraits	121.080	2165.047	7.675070

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	929.345	282.074
SumBase	55.649	4710.667	16.700119
SumBase_Add	54.708	4791.699	16.987394
SumTraits	54.713	4791.293	16.985953

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1147.519	228.444
SumBase	157.225	1667.316	7.298570
SumBase_ClearBit	148.448	1765.902	7.730125
SumBase_ClearBit_Not	144.974	1808.218	7.915357
SumTraits	163.438	1603.939	7.021142

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	1334.688	196.408
SumBase	77.841	3367.688	17.146346
SumBase_ClearBit	77.711	3373.335	17.175097
SumTraits	77.746	3371.784	17.167202

``` 

#### .NET Core 3.1 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	929.138	282.137
SumBase	195.533	1340.663	4.751817
SumBase_Basic	526.835	497.582	1.763621
SumBase_ClearBit	196.223	1335.947	4.735103
SumTraits	77.697	3373.932	11.958495
Sum128Base_Basic	852.579	307.472	1.089797
Sum128Base	853.400	307.176	1.088748
Sum128Traits	155.287	1688.123	5.983348
Sum256Base_Basic	486.301	539.057	1.910622
Sum256Base	485.656	539.773	1.913159
Sum256Traits	78.052	3358.594	11.904133

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	929.660	281.978
SumBase	102.025	2569.409	9.112082
SumBase_Basic	329.840	794.760	2.818516
SumBase_ClearBit	102.062	2568.486	9.108808
SumTraits	38.925	6734.605	23.883419
Sum128Base_Basic	466.425	562.028	1.993161
Sum128Base	466.551	561.877	1.992625
Sum128Traits	77.576	3379.182	11.983840
Sum256Base_Basic	294.454	890.273	3.157240
Sum256Base	294.474	890.210	3.157017
Sum256Traits	38.942	6731.602	23.872768

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	929.441	282.045
SumBase	195.536	1340.645	4.753307
SumBase_Basic	526.275	498.112	1.766076
SumBase_ClearBit	196.469	1334.278	4.730731
SumTraits	77.826	3368.315	11.942486
Sum128Base_Basic	853.744	307.052	1.088664
Sum128Base	852.541	307.486	1.090202
Sum128Traits	155.573	1685.019	5.974296
Sum256Base_Basic	485.758	539.660	1.913385
Sum256Base	485.724	539.698	1.913519
Sum256Traits	77.834	3367.969	11.941257

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	930.116	281.840
SumBase	102.643	2553.935	9.061647
SumBase_Basic	330.086	794.168	2.817795
SumBase_ClearBit	102.569	2555.778	9.068185
SumTraits	38.906	6737.850	23.906646
Sum128Base_Basic	466.278	562.206	1.994769
Sum128Base	465.878	562.688	1.996479
Sum128Traits	77.603	3378.019	11.985587
Sum256Base_Basic	294.105	891.329	3.162534
Sum256Base	294.144	891.208	3.162107
Sum256Traits	38.912	6736.925	23.903364

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	929.601	281.996
SumBase	100.348	2612.343	9.263753
SumBase_Add	102.748	2551.329	9.047387
SumTraits	77.835	3367.939	11.943210
Sum128Base_Basic	853.560	307.119	1.089088
Sum128Base	853.560	307.118	1.089087
Sum128Traits	155.330	1687.654	5.984669
Sum256Base_Basic	486.131	539.245	1.912243
Sum256Base	486.155	539.219	1.912152
Sum256Traits	77.795	3369.697	11.949442

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	929.169	282.127
SumBase	51.000	5140.096	18.219058
SumBase_Add	50.508	5190.154	18.396486
SumTraits	38.921	6735.294	23.873231
Sum128Base_Basic	466.566	561.859	1.991507
Sum128Base	466.688	561.712	1.990985
Sum128Traits	77.631	3376.776	11.968972
Sum256Base_Basic	294.555	889.967	3.154487
Sum256Base	294.331	890.645	3.156888
Sum256Traits	38.932	6733.353	23.866352

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1153.212	227.316
SumBase	132.694	1975.546	8.690733
SumBase_ClearBit	132.505	1978.367	8.703146
SumBase_ClearBit_Not	144.268	1817.060	7.993532
SumTraits	77.806	3369.194	14.821609
Sum128Base_Basic	1604.205	163.411	0.718869
Sum128Base	1606.471	163.180	0.717855
Sum128Traits	155.225	1688.797	7.429281
Sum256Base_Basic	1314.833	199.374	0.877079
Sum256Base	1319.072	198.734	0.874260
Sum256Traits	77.758	3371.283	14.830800

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1244.297	210.676
SumBase	68.120	3848.289	18.266358
SumBase_ClearBit	68.141	3847.083	18.260632
SumTraits	38.968	6727.151	31.931214
Sum128Base_Basic	1256.033	208.708	0.990657
Sum128Base	1253.080	209.200	0.992991
Sum128Traits	77.608	3377.788	16.033070
Sum256Base_Basic	1283.307	204.272	0.969603
Sum256Base	1293.227	202.705	0.962165
Sum256Traits	38.877	6742.872	32.005838

``` 

#### .NET 5.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
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
SumScalar	929.409	282.055
SumBcl	77.835	3367.948	11.940769
SumBase	77.792	3369.820	11.947403
SumBase_Basic	553.167	473.897	1.680161
SumBase_ClearBit	195.209	1342.891	4.761105
SumTraits	77.704	3373.611	11.960845
Sum128Base_Basic	853.505	307.138	1.088932
Sum128Base	853.387	307.181	1.089083
Sum128Traits	155.468	1686.162	5.978141
Sum256Base_Basic	552.617	474.368	1.681832
Sum256Base	552.698	474.299	1.681585
Sum256Traits	78.146	3354.522	11.893166

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	929.171	282.127
SumBcl	38.883	6741.925	23.896797
SumBase	38.875	6743.225	23.901405
SumBase_Basic	339.479	772.194	2.737047
SumBase_ClearBit	97.137	2698.716	9.565615
SumTraits	38.916	6736.146	23.876311
Sum128Base_Basic	465.668	562.942	1.995353
Sum128Base	465.854	562.717	1.994555
Sum128Traits	77.738	3372.141	11.952574
Sum256Base_Basic	315.388	831.179	2.946120
Sum256Base	315.409	831.125	2.945926
Sum256Traits	38.948	6730.672	23.856909

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	929.189	282.121
SumBcl	78.030	3359.510	11.908039
SumBase	77.881	3365.947	11.930855
SumBase_Basic	553.767	473.383	1.677942
SumBase_ClearBit	195.825	1338.663	4.744994
SumTraits	77.857	3367.014	11.934638
Sum128Base_Basic	855.270	306.504	1.086428
Sum128Base	854.372	306.827	1.087570
Sum128Traits	155.577	1684.974	5.972520
Sum256Base_Basic	552.885	474.138	1.680619
Sum256Base	553.027	474.016	1.680187
Sum256Traits	77.793	3369.784	11.944457

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	929.296	282.089
SumBcl	38.895	6739.706	23.892147
SumBase	38.924	6734.717	23.874462
SumBase_Basic	339.963	771.097	2.733525
SumBase_ClearBit	98.489	2661.656	9.435529
SumTraits	38.876	6743.087	23.904136
Sum128Base_Basic	465.536	563.101	1.996185
Sum128Base	465.517	563.125	1.996268
Sum128Traits	77.740	3372.074	11.953947
Sum256Base_Basic	315.299	831.414	2.947349
Sum256Base	315.536	830.791	2.945140
Sum256Traits	38.925	6734.557	23.873895

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	929.179	282.124
SumBase	96.892	2705.523	9.589825
SumBase_Add	98.338	2665.736	9.448799
SumTraits	77.855	3367.058	11.934661
Sum128Base_Basic	853.077	307.292	1.089208
Sum128Base	853.692	307.071	1.088424
Sum128Traits	155.108	1690.072	5.990521
Sum256Base_Basic	552.824	474.191	1.680787
Sum256Base	553.586	473.538	1.678474
Sum256Traits	77.758	3371.297	11.949686

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	930.074	281.853
SumBase	42.949	6103.596	21.655269
SumBase_Add	42.867	6115.292	21.696764
SumTraits	38.919	6735.617	23.897649
Sum128Base_Basic	465.486	563.162	1.998070
Sum128Base	466.737	561.653	1.992717
Sum128Traits	77.664	3375.345	11.975563
Sum256Base_Basic	315.005	832.189	2.952566
Sum256Base	314.906	832.451	2.953496
Sum256Traits	38.901	6738.818	23.909005

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1223.648	214.232
SumBase	86.714	3023.088	14.111312
SumBase_ClearBit	131.514	1993.278	9.304315
SumBase_ClearBit_Not	145.074	1806.966	8.434640
SumTraits	77.662	3375.452	15.756091
Sum128Base_Basic	1608.236	163.001	0.760863
Sum128Base	1603.333	163.499	0.763190
Sum128Traits	155.327	1687.691	7.877881
Sum256Base_Basic	1320.172	198.568	0.926885
Sum256Base	1318.310	198.849	0.928195
Sum256Traits	78.229	3351.001	15.641960

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1367.411	191.708
SumBase	42.434	6177.637	32.224158
SumBase_ClearBit	62.237	4212.048	21.971135
SumTraits	38.950	6730.234	35.106647
Sum128Base_Basic	1284.672	204.055	1.064405
Sum128Base	1272.318	206.037	1.074740
Sum128Traits	77.763	3371.067	17.584360
Sum256Base_Basic	1293.488	202.664	1.057150
Sum256Base	1296.921	202.128	1.054352
Sum256Traits	38.973	6726.350	35.086389

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.24
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.24\
RuntimeInformation.FrameworkDescription:	.NET 6.0.24
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.24/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
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
SumScalar	929.128	282.140
SumBcl	77.726	3372.665	11.953882
SumBase	77.776	3370.514	11.946256
SumBase_Basic	1916.849	136.758	0.484716
SumBase_ClearBit	205.119	1278.012	4.529711
SumTraits	77.869	3366.471	11.931928
Sum128Base_Basic	853.271	307.222	1.088901
Sum128Base	853.117	307.278	1.089099
Sum128Traits	155.324	1687.723	5.981869
Sum256Base_Basic	1879.408	139.482	0.494373
Sum256Base	1879.958	139.441	0.494228
Sum256Traits	77.927	3363.948	11.922985

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	929.567	282.007
SumBcl	38.927	6734.217	23.879634
SumBase	38.854	6746.937	23.924739
SumBase_Basic	1026.488	255.380	0.905580
SumBase_ClearBit	99.956	2622.592	9.299751
SumTraits	38.904	6738.297	23.894100
Sum128Base_Basic	465.848	562.724	1.995428
Sum128Base	465.812	562.767	1.995581
Sum128Traits	77.605	3377.911	11.978124
Sum256Base_Basic	1018.450	257.395	0.912727
Sum256Base	1018.841	257.296	0.912376
Sum256Traits	38.975	6726.019	23.850562

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	929.916	281.901
SumBcl	77.721	3372.893	11.964831
SumBase	77.812	3368.951	11.950845
SumBase_Basic	1919.329	136.581	0.484501
SumBase_ClearBit	204.856	1279.650	4.539367
SumTraits	77.772	3370.659	11.956905
Sum128Base_Basic	854.176	306.897	1.088671
Sum128Base	852.887	307.361	1.090316
Sum128Traits	155.569	1685.069	5.977530
Sum256Base_Basic	1879.437	139.480	0.494785
Sum256Base	1880.499	139.401	0.494505
Sum256Traits	77.789	3369.956	11.954412

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	929.802	281.935
SumBcl	38.834	6750.329	23.942830
SumBase	38.849	6747.700	23.933506
SumBase_Basic	1027.753	255.065	0.904694
SumBase_ClearBit	99.775	2627.355	9.319002
SumTraits	39.031	6716.382	23.822424
Sum128Base_Basic	466.559	561.866	1.992891
Sum128Base	466.429	562.024	1.993449
Sum128Traits	77.632	3376.758	11.977069
Sum256Base_Basic	1017.419	257.656	0.913883
Sum256Base	1018.559	257.368	0.912860
Sum256Traits	38.910	6737.162	23.896129

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	930.265	281.795
SumBase	101.771	2575.820	9.140763
SumBase_Add	102.041	2569.017	9.116622
SumTraits	77.872	3366.326	11.946015
Sum128Base_Basic	853.324	307.204	1.090167
Sum128Base	853.085	307.289	1.090472
Sum128Traits	155.254	1688.480	5.991876
Sum256Base_Basic	1879.504	139.475	0.494953
Sum256Base	1878.978	139.514	0.495091
Sum256Traits	77.845	3367.504	11.950198

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	929.418	282.052
SumBase	44.044	5951.808	21.101838
SumBase_Add	43.484	6028.539	21.373884
SumTraits	38.893	6740.122	23.896766
Sum128Base_Basic	465.963	562.585	1.994616
Sum128Base	466.275	562.209	1.993285
Sum128Traits	77.657	3375.675	11.968286
Sum256Base_Basic	1017.082	257.741	0.913809
Sum256Base	1017.069	257.745	0.913821
Sum256Traits	38.914	6736.515	23.883978

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1217.930	215.237
SumBase	87.335	3001.609	13.945582
SumBase_ClearBit	137.280	1909.557	8.871870
SumBase_ClearBit_Not	150.032	1747.250	8.117788
SumTraits	77.844	3367.570	15.645850
Sum128Base_Basic	1602.373	163.597	0.760079
Sum128Base	1608.061	163.019	0.757390
Sum128Traits	155.213	1688.928	7.846819
Sum256Base_Basic	1318.904	198.759	0.923441
Sum256Base	1321.739	198.333	0.921461
Sum256Traits	77.672	3375.001	15.680376

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1375.690	190.555
SumBase	42.534	6163.136	32.343161
SumBase_ClearBit	62.872	4169.460	21.880667
SumTraits	38.902	6738.520	35.362683
Sum128Base_Basic	1236.188	212.058	1.112849
Sum128Base	1230.830	212.982	1.117693
Sum128Traits	77.737	3372.191	17.696723
Sum256Base_Basic	1293.292	202.695	1.063712
Sum256Base	1292.757	202.779	1.064152
Sum256Traits	39.000	6721.680	35.274308

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.13
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.13\
RuntimeInformation.FrameworkDescription:	.NET 7.0.13
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.13/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
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
SumScalar	929.338	282.076
SumBcl	77.927	3363.958	11.925719
SumBase	77.674	3374.934	11.964630
SumBase_Basic	523.718	500.544	1.774502
SumBase_ClearBit	195.242	1342.663	4.759936
SumTraits	77.757	3371.318	11.951810
Sum128Bcl	155.137	1689.760	5.990445
Sum128Base_Basic	856.057	306.223	1.085604
Sum128Base	155.215	1688.910	5.987432
Sum128Traits	155.388	1687.029	5.980762
Sum256Bcl	77.688	3374.338	11.962516
Sum256Base_Basic	486.939	538.351	1.908532
Sum256Base	77.812	3368.927	11.943332
Sum256Traits	77.852	3367.215	11.937266

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
SumScalar	929.772	281.945
SumBcl	38.901	6738.768	23.901042
SumBase	38.911	6737.024	23.894856
SumBase_Basic	330.086	794.168	2.816752
SumBase_ClearBit	97.652	2684.462	9.521242
SumTraits	38.870	6744.141	23.920098
Sum128Bcl	77.622	3377.173	11.978148
Sum128Base_Basic	466.229	562.265	1.994239
Sum128Base	77.537	3380.882	11.991302
Sum128Traits	77.655	3375.749	11.973095
Sum256Bcl	38.937	6732.600	23.879164
Sum256Base_Basic	281.612	930.868	3.301601
Sum256Base	38.914	6736.442	23.892792
Sum256Traits	38.918	6735.871	23.890767

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
SumScalar	930.584	281.698
SumBcl	77.919	3364.317	11.942980
SumBase	77.929	3363.893	11.941472
SumBase_Basic	525.040	499.284	1.772407
SumBase_ClearBit	194.313	1349.079	4.789090
SumTraits	77.709	3373.400	11.975222
Sum128Bcl	155.392	1686.986	5.988626
Sum128Base_Basic	856.246	306.155	1.086819
Sum128Base	155.256	1688.467	5.993884
Sum128Traits	155.453	1686.328	5.986289
Sum256Bcl	77.807	3369.147	11.960124
Sum256Base_Basic	486.423	538.922	1.913119
Sum256Base	77.693	3374.108	11.977734
Sum256Traits	77.909	3364.726	11.944432

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
SumScalar	929.307	282.086
SumBcl	38.990	6723.379	23.834535
SumBase	38.900	6738.892	23.889531
SumBase_Basic	329.663	795.187	2.818958
SumBase_ClearBit	98.055	2673.449	9.477441
SumTraits	38.956	6729.163	23.855041
Sum128Bcl	77.712	3373.271	11.958326
Sum128Base_Basic	465.581	563.047	1.996016
Sum128Base	77.686	3374.392	11.962300
Sum128Traits	77.650	3375.965	11.967875
Sum256Bcl	38.911	6737.070	23.883073
Sum256Base_Basic	282.615	927.565	3.288239
Sum256Base	38.880	6742.392	23.901939
Sum256Traits	38.914	6736.511	23.881090

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	929.248	282.103
SumBase	99.977	2622.030	9.294574
SumBase_Add	98.860	2651.675	9.399659
SumTraits	77.803	3369.313	11.943542
Sum128Base_Basic	856.294	306.138	1.085197
Sum128Base	155.869	1681.823	5.961728
Sum128Traits	155.669	1683.988	5.969402
Sum256Base_Basic	486.182	539.189	1.911317
Sum256Base	93.316	2809.219	9.958121
Sum256Traits	77.742	3371.984	11.953011

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	929.274	282.096
SumBase	47.752	5489.668	19.460315
SumBase_Add	47.152	5559.593	19.708191
SumTraits	38.927	6734.230	23.872162
Sum128Base_Basic	465.502	563.143	1.996283
Sum128Base	78.847	3324.719	11.785790
Sum128Traits	77.776	3370.487	11.948033
Sum256Base_Basic	281.456	931.385	3.301665
Sum256Base	46.272	5665.301	20.082915
Sum256Traits	38.943	6731.561	23.862701

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	929.943	281.893
SumBase	87.082	3010.300	10.678888
SumBase_ClearBit	131.501	1993.469	7.071731
SumBase_ClearBit_Not	144.672	1811.987	6.427933
SumTraits	77.879	3366.053	11.940904
Sum128Base_Basic	856.273	306.145	1.086035
Sum128Base	157.631	1663.025	5.899499
Sum128Traits	155.368	1687.246	5.985419
Sum256Base_Basic	486.142	539.233	1.912902
Sum256Base	85.173	3077.768	10.918228
Sum256Traits	77.790	3369.877	11.954469

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	929.266	282.098
SumBase	43.314	6052.151	21.454080
SumBase_ClearBit	66.110	3965.241	14.056258
SumTraits	38.907	6737.743	23.884416
Sum128Base_Basic	465.801	562.782	1.994987
Sum128Base	83.342	3145.404	11.150044
Sum128Traits	77.574	3379.266	11.979054
Sum256Base_Basic	281.235	932.117	3.304233
Sum256Base	42.498	6168.437	21.866301
Sum256Traits	38.961	6728.401	23.851300

``` 


## Arm

### Apple M2
`Apple M2`

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	6.0.33
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.33/
RuntimeInformation.FrameworkDescription:	.NET 6.0.33
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.15-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.33/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, ArmBase, Crc32
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
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
SumScalar	224.790	1166.170
SumBcl	112.505	2330.068	1.998051
SumBase	112.334	2333.607	2.001085
SumBase_Basic	150.467	1742.204	1.493953
SumBase_ClearBit	222.128	1180.150	1.011988
SumTraits	112.360	2333.082	2.000636
Sum128Base_Basic	128.800	2035.285	1.745273
Sum128Base	130.300	2011.845	1.725173
Sum128Traits	114.074	2298.017	1.970567
Sum256Base_Basic	801.795	326.946	0.280359
Sum256Base	813.743	322.146	0.276243
Sum256Traits	802.897	326.498	0.279974

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	225.807	1160.920
SumBcl	56.261	4659.440	4.013577
SumBase	56.141	4669.363	4.022125
SumBase_Basic	138.677	1890.322	1.628297
SumBase_ClearBit	110.877	2364.272	2.036551
SumTraits	56.185	4665.693	4.018963
Sum128Base_Basic	86.616	3026.499	2.606984
Sum128Base	86.752	3021.772	2.602913
Sum128Traits	58.954	4446.558	3.830203
Sum256Base_Basic	378.677	692.263	0.596306
Sum256Base	378.514	692.560	0.596562
Sum256Traits	378.605	692.394	0.596418

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	231.353	1133.091
SumBcl	115.637	2266.963	2.000689
SumBase	115.604	2267.596	2.001247
SumBase_Basic	150.376	1743.252	1.538492
SumBase_ClearBit	221.820	1181.787	1.042976
SumTraits	115.617	2267.343	2.001024
Sum128Base_Basic	126.514	2072.058	1.828677
Sum128Base	126.698	2069.043	1.826016
Sum128Traits	115.626	2267.170	2.000871
Sum256Base_Basic	824.076	318.107	0.280742
Sum256Base	840.652	311.834	0.275206
Sum256Traits	823.567	318.303	0.280916

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	231.303	1133.336
SumBcl	57.796	4535.650	4.002034
SumBase	57.810	4534.601	4.001109
SumBase_Basic	141.751	1849.329	1.631757
SumBase_ClearBit	110.915	2363.468	2.085408
SumTraits	57.506	4558.537	4.022229
Sum128Base_Basic	86.972	3014.110	2.659502
Sum128Base	86.826	3019.183	2.663979
Sum128Traits	57.122	4589.208	4.049292
Sum256Base_Basic	379.357	691.021	0.609723
Sum256Base	379.425	690.899	0.609615
Sum256Traits	379.463	690.829	0.609553

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	231.185	1133.916
SumBase	115.642	2266.849	1.999133
SumBase_Add	115.624	2267.202	1.999445
SumTraits	115.588	2267.908	2.000067
Sum128Base_Basic	122.680	2136.812	1.884454
Sum128Base	127.293	2059.372	1.816160
Sum128Traits	115.586	2267.956	2.000110
Sum256Base_Basic	844.374	310.459	0.273794
Sum256Base	824.318	318.013	0.280456
Sum256Traits	830.977	315.465	0.278208

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
SumScalar	231.151	1134.083
SumBase	57.813	4534.375	3.998273
SumBase_Add	57.814	4534.295	3.998203
SumTraits	57.773	4537.466	4.000999
Sum128Base_Basic	86.737	3022.287	2.664960
Sum128Base	86.852	3018.272	2.661420
Sum128Traits	57.765	4538.083	4.001543
Sum256Base_Basic	379.257	691.204	0.609482
Sum256Base	379.086	691.516	0.609758
Sum256Traits	380.136	689.605	0.608073

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	758.186	345.752
SumBase	115.628	2267.127	6.557099
SumBase_ClearBit	154.512	1696.589	4.906959
SumBase_ClearBit_Not	173.435	1511.486	4.371595
SumTraits	115.576	2268.158	6.560081
Sum128Base_Basic	717.673	365.270	1.056451
Sum128Base	717.744	365.233	1.056346
Sum128Traits	115.577	2268.130	6.560000
Sum256Base_Basic	835.213	313.865	0.907775
Sum256Base	820.166	319.623	0.924429
Sum256Traits	828.724	316.322	0.914883

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
SumScalar	742.719	352.952
SumBase	57.801	4535.268	12.849536
SumBase_ClearBit	77.087	3400.610	9.634769
SumTraits	57.766	4538.052	12.857423
Sum128Base_Basic	682.921	383.857	1.087562
Sum128Base	683.111	383.750	1.087259
Sum128Traits	57.768	4537.875	12.856922
Sum256Base_Basic	720.340	363.917	1.031067
Sum256Base	711.485	368.446	1.043900
Sum256Traits	711.400	368.491	1.044025

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	7.0.20
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.20/
RuntimeInformation.FrameworkDescription:	.NET 7.0.20
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.15-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.20/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
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
SumScalar	231.237	1133.659
SumBcl	115.564	2268.394	2.000949
SumBase	115.588	2267.923	2.000533
SumBase_Basic	126.691	2069.166	1.825210
SumBase_ClearBit	156.514	1674.889	1.477419
SumTraits	115.563	2268.415	2.000967
Sum128Bcl	115.583	2268.015	2.000614
Sum128Base_Basic	122.154	2146.008	1.892992
Sum128Base	115.618	2267.330	2.000011
Sum128Traits	115.570	2268.265	2.000835
Sum256Bcl	633.447	413.837	0.365045
Sum256Base_Basic	537.095	488.078	0.430533
Sum256Base	578.142	453.425	0.399966
Sum256Traits	575.643	455.393	0.401702

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
SumScalar	231.144	1134.114
SumBcl	57.779	4537.048	4.000522
SumBase	57.771	4537.653	4.001055
SumBase_Basic	121.897	2150.538	1.896227
SumBase_ClearBit	78.301	3347.888	2.951985
SumTraits	57.778	4537.124	4.000589
Sum128Bcl	57.767	4537.953	4.001320
Sum128Base_Basic	81.842	3203.063	2.824287
Sum128Base	57.771	4537.629	4.001034
Sum128Traits	57.771	4537.634	4.001039
Sum256Bcl	299.879	874.165	0.770791
Sum256Base_Basic	325.949	804.249	0.709143
Sum256Base	326.439	803.041	0.708078
Sum256Traits	326.608	802.626	0.707712

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
SumScalar	231.185	1133.915
SumBcl	115.576	2268.143	2.000276
SumBase	115.570	2268.265	2.000384
SumBase_Basic	126.588	2070.847	1.826280
SumBase_ClearBit	156.477	1675.287	1.477436
SumTraits	115.563	2268.410	2.000511
Sum128Bcl	115.587	2267.936	2.000093
Sum128Base_Basic	122.256	2144.218	1.890986
Sum128Base	115.584	2268.001	2.000151
Sum128Traits	115.583	2268.005	2.000154
Sum256Bcl	634.234	413.324	0.364510
Sum256Base_Basic	537.173	488.006	0.430373
Sum256Base	575.564	455.456	0.401666
Sum256Traits	578.449	453.184	0.399663

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
SumScalar	224.848	1165.874
SumBcl	56.199	4664.594	4.000943
SumBase	56.291	4656.980	3.994412
SumBase_Basic	120.684	2172.152	1.863111
SumBase_ClearBit	78.165	3353.721	2.876574
SumTraits	57.765	4538.079	3.892428
Sum128Bcl	56.184	4665.798	4.001976
Sum128Base_Basic	81.780	3205.488	2.749430
Sum128Base	57.763	4538.254	3.892578
Sum128Traits	57.689	4544.123	3.897612
Sum256Bcl	299.523	875.205	0.750686
Sum256Base_Basic	325.500	805.359	0.690777
Sum256Base	326.109	803.853	0.689486
Sum256Traits	326.195	803.642	0.689305

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	224.841	1165.909
SumBase	115.630	2267.098	1.944490
SumBase_Add	115.591	2267.862	1.945145
SumTraits	113.529	2309.058	1.980479
Sum128Base_Basic	122.145	2146.172	1.840771
Sum128Base	115.607	2267.542	1.944871
Sum128Traits	114.333	2292.812	1.966544
Sum256Base_Basic	537.402	487.798	0.418385
Sum256Base	2772.548	94.550	0.081095
Sum256Traits	2772.865	94.539	0.081086

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	224.858	1165.822
SumBase	57.825	4533.397	3.888586
SumBase_Add	57.818	4533.986	3.889091
SumTraits	56.201	4664.377	4.000935
Sum128Base_Basic	81.694	3208.833	2.752422
Sum128Base	57.819	4533.888	3.889007
Sum128Traits	56.273	4658.421	3.995827
Sum256Base_Basic	325.927	804.303	0.689902
Sum256Base	1754.156	149.442	0.128186
Sum256Traits	1755.268	149.347	0.128105

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	224.851	1165.857
SumBase	115.616	2267.372	1.944812
SumBase_ClearBit	120.487	2175.708	1.866188
SumBase_ClearBit_Not	134.943	1942.622	1.666262
SumTraits	112.430	2331.616	1.999917
Sum128Base_Basic	122.195	2145.289	1.840097
Sum128Base	115.639	2266.923	1.944427
Sum128Traits	112.399	2332.260	2.000469
Sum256Base_Basic	537.348	487.847	0.418446
Sum256Base	1713.311	153.004	0.131238
Sum256Traits	1716.780	152.695	0.130972

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	224.836	1165.936
SumBase	57.794	4535.856	3.890312
SumBase_ClearBit	60.244	4351.378	3.732088
SumTraits	57.766	4538.051	3.892194
Sum128Base_Basic	81.678	3209.493	2.752717
Sum128Base	57.791	4536.103	3.890523
Sum128Traits	57.767	4537.957	3.892113
Sum256Base_Basic	326.027	804.055	0.689622
Sum256Base	811.124	323.186	0.277190
Sum256Traits	811.569	323.009	0.277038

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	8.0.4
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.4/
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.4/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844159	# 0x8177F801
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
SumScalar	231.155	1134.063
SumBcl	115.582	2268.040	1.999925
SumBase	115.584	2268.002	1.999892
SumBase_Basic	126.808	2067.245	1.822867
SumBase_ClearBit	159.625	1642.247	1.448110
SumTraits	115.578	2268.110	1.999986
Sum128Bcl	115.559	2268.480	2.000313
Sum128Base_Basic	126.568	2071.165	1.826324
Sum128Base	115.570	2268.279	2.000136
Sum128Traits	115.592	2267.833	1.999742
Sum256Bcl	57.779	4536.986	4.000649
Sum256Base_Basic	112.684	2326.359	2.051350
Sum256Base	57.778	4537.079	4.000731
Sum256Traits	57.786	4536.479	4.000202
Sum512Bcl	28.998	9040.096	7.971427
Sum512Base	28.985	9044.157	7.975008
Sum512Traits	28.996	9040.599	7.971870

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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.6394212E+11!=-3.639422E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394212E+11!=-3.639422E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394212E+11!=-3.639422E+11
SumScalar	224.828	1165.974
SumBcl	56.190	4665.305	4.001207
SumBase	57.760	4538.480	3.892435
SumBase_Basic	115.954	2260.758	1.938943
SumBase_ClearBit	79.471	3298.593	2.829044
SumTraits	57.774	4537.433	3.891538
Sum128Bcl	57.765	4538.086	3.892097
Sum128Base_Basic	81.937	3199.344	2.743923
Sum128Base	57.759	4538.564	3.892507
Sum128Traits	57.774	4537.390	3.891500
Sum256Bcl	28.877	9078.047	7.785803
Sum256Base_Basic	85.013	3083.561	2.644621
Sum256Base	28.880	9076.936	7.784850
Sum256Traits	28.958	9052.529	7.763918
Sum512Bcl	14.496	18084.328	15.510055
Sum512Base	14.494	18086.188	15.511650
Sum512Traits	14.497	18082.379	15.508384

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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -1.5629256372728646E+21!=-1.5629256372728656E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728656E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728656E+21
SumScalar	231.180	1133.939
SumBcl	115.590	2267.868	1.999992
SumBase	115.601	2267.657	1.999806
SumBase_Basic	126.863	2066.363	1.822288
SumBase_ClearBit	159.103	1647.634	1.453019
SumTraits	115.551	2268.642	2.000674
Sum128Bcl	115.574	2268.194	2.000279
Sum128Base_Basic	123.833	2116.924	1.866876
Sum128Base	115.555	2268.568	2.000609
Sum128Traits	115.561	2268.450	2.000505
Sum256Bcl	57.782	4536.793	4.000916
Sum256Base_Basic	111.977	2341.045	2.064525
Sum256Base	57.780	4536.962	4.001064
Sum256Traits	57.786	4536.498	4.000655
Sum512Bcl	29.002	9038.748	7.971108
Sum512Base	28.998	9040.194	7.972383
Sum512Traits	28.995	9040.959	7.973058

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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.6394212E+11!=-3.6394235E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394212E+11!=-3.6394235E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394212E+11!=-3.6394235E+11
SumScalar	227.829	1150.617
SumBcl	56.179	4666.221	4.055408
SumBase	56.187	4665.538	4.054815
SumBase_Basic	115.921	2261.411	1.965391
SumBase_ClearBit	79.519	3296.607	2.865078
SumTraits	56.190	4665.273	4.054584
Sum128Bcl	56.187	4665.528	4.054806
Sum128Base_Basic	82.067	3194.279	2.776145
Sum128Base	56.194	4664.997	4.054344
Sum128Traits	56.189	4665.371	4.054670
Sum256Bcl	28.883	9076.031	7.887970
Sum256Base_Basic	84.868	3088.855	2.684521
Sum256Base	28.879	9077.234	7.889015
Sum256Traits	28.879	9077.238	7.889019
Sum512Bcl	14.508	18068.891	15.703656
Sum512Base	14.508	18069.384	15.704084
Sum512Traits	14.509	18068.209	15.703064

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
SumScalar	231.161	1134.030
SumBase	115.626	2267.166	1.999211
SumBase_Add	115.618	2267.319	1.999346
SumTraits	115.592	2267.842	1.999807
Sum128Base_Basic	123.866	2116.346	1.866216
Sum128Base	115.615	2267.386	1.999405
Sum128Traits	115.547	2268.713	2.000575
Sum256Base_Basic	112.540	2329.336	2.054034
Sum256Base	78.368	3345.017	2.949672
Sum256Traits	78.250	3350.064	2.954122
Sum512Base	971.743	269.767	0.237883
Sum512Traits	971.964	269.705	0.237829

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394218E+11!=-3.639423E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394218E+11!=-3.639423E+11
SumScalar	231.152	1134.074
SumBase	57.816	4534.094	3.998058
SumBase_Add	57.811	4534.464	3.998384
SumTraits	57.751	4539.175	4.002538
Sum128Base_Basic	81.452	3218.367	2.837881
Sum128Base	57.813	4534.349	3.998283
Sum128Traits	57.750	4539.265	4.002618
Sum256Base_Basic	84.651	3096.753	2.730644
Sum256Base	38.573	6796.080	5.992624
Sum256Traits	38.575	6795.666	5.992259
Sum512Base	513.443	510.561	0.450201
Sum512Traits	505.577	518.504	0.457205

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
SumScalar	231.149	1134.093
SumBase	115.604	2267.594	1.999478
SumBase_ClearBit	117.569	2229.711	1.966074
SumBase_ClearBit_Not	129.805	2019.523	1.780738
SumTraits	115.571	2268.254	2.000059
Sum128Base_Basic	123.875	2116.198	1.865982
Sum128Base	115.593	2267.825	1.999681
Sum128Traits	115.585	2267.986	1.999823
Sum256Base_Basic	112.594	2328.225	2.052940
Sum256Base	57.896	4527.832	3.992469
Sum256Traits	57.876	4529.408	3.993858
Sum512Base	234.142	1119.596	0.987217
Sum512Traits	234.255	1119.055	0.986740

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394218E+11!=-3.639423E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394218E+11!=-3.639423E+11
SumScalar	231.198	1133.852
SumBase	57.785	4536.503	4.000965
SumBase_ClearBit	57.961	4522.788	3.988869
SumTraits	57.753	4539.069	4.003228
Sum128Base_Basic	81.585	3213.131	2.833818
Sum128Base	57.786	4536.424	4.000895
Sum128Traits	57.748	4539.423	4.003540
Sum256Base_Basic	84.931	3086.538	2.722169
Sum256Base	28.938	9058.806	7.989406
Sum256Traits	28.918	9065.069	7.994930
Sum512Base	130.457	2009.435	1.772220
Sum512Traits	133.001	1970.988	1.738311

```

### AWS Arm t4g.small
`AWS Arm t4g.small`

#### .NET Core 3.1
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	
Vector128s.Instance:	WVectorTraits128Base	// 
Vectors.Instance:	VectorTraits128Base	// 
Vectors.BaseInstance:	VectorTraits128Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	291.061	900.649
SumBase	554.973	472.355	0.524460
SumBase_Basic	543.583	482.252	0.535450
SumBase_ClearBit	903.887	290.019	0.322011
SumTraits	549.524	477.038	0.529660
Sum128Base_Basic	1043.639	251.183	0.278891
Sum128Base	1042.610	251.431	0.279166
Sum128Traits	1048.502	250.018	0.277597
Sum256Base_Basic	1761.507	148.818	0.165234
Sum256Base	1763.740	148.630	0.165025
Sum256Traits	1769.429	148.152	0.164494

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	316.361	828.623
SumBase	470.509	557.149	0.672380
SumBase_Basic	823.468	318.341	0.384181
SumBase_ClearBit	468.301	559.777	0.675551
SumTraits	472.658	554.617	0.669324
Sum128Base_Basic	1485.318	176.490	0.212992
Sum128Base	1475.465	177.669	0.214414
Sum128Traits	1457.025	179.917	0.217128
Sum256Base_Basic	1246.757	210.261	0.253747
Sum256Base	1292.740	202.782	0.244721
Sum256Traits	1281.561	204.551	0.246856

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	320.186	818.725
SumBase	541.097	484.468	0.591735
SumBase_Basic	1272.209	206.054	0.251677
SumBase_ClearBit	911.898	287.471	0.351120
SumTraits	1286.394	203.782	0.248902
Sum128Base_Basic	1063.273	246.545	0.301132
Sum128Base	1063.912	246.396	0.300951
Sum128Traits	1039.630	252.151	0.307980
Sum256Base_Basic	1814.858	144.443	0.176425
Sum256Base	1784.792	146.876	0.179397
Sum256Traits	1799.982	145.637	0.177883

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	292.662	895.723
SumBase	474.367	552.618	0.616952
SumBase_Basic	829.777	315.921	0.352699
SumBase_ClearBit	479.437	546.775	0.610428
SumTraits	477.166	549.377	0.613333
Sum128Base_Basic	1470.026	178.326	0.199086
Sum128Base	1470.303	178.293	0.199049
Sum128Traits	1472.806	177.989	0.198710
Sum256Base_Basic	1284.159	204.137	0.227902
Sum256Base	1312.707	199.697	0.222945
Sum256Traits	1309.938	200.119	0.223416

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	316.231	828.965
SumBase	353.259	742.072	0.895180
SumBase_Add	354.231	740.037	0.892725
SumTraits	353.277	742.036	0.895136
Sum128Base_Basic	1052.158	249.149	0.300554
Sum128Base	1047.084	250.356	0.302011
Sum128Traits	1044.008	251.094	0.302901
Sum256Base_Basic	1755.111	149.360	0.180177
Sum256Base	1755.014	149.369	0.180187
Sum256Traits	1760.234	148.926	0.179653

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	290.399	902.703
SumBase	182.938	1432.968	1.587420
SumBase_Add	181.629	1443.292	1.598857
SumTraits	182.766	1434.315	1.588912
Sum128Base_Basic	1462.359	179.261	0.198583
Sum128Base	1450.830	180.686	0.200161
Sum128Traits	1451.383	180.617	0.200084
Sum256Base_Basic	1259.693	208.102	0.230532
Sum256Base	1281.370	204.581	0.226632
Sum256Traits	1281.613	204.542	0.226589

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1618.469	161.970
SumBase	528.076	496.413	3.064841
SumBase_ClearBit	531.713	493.018	3.043877
SumBase_ClearBit_Not	624.993	419.435	2.589579
SumTraits	532.965	491.860	3.036729
Sum128Base_Basic	2120.532	123.622	0.763237
Sum128Base	2060.596	127.218	0.785438
Sum128Traits	2105.468	124.506	0.768698
Sum256Base_Basic	3142.991	83.406	0.514946
Sum256Base	3222.525	81.347	0.502236
Sum256Traits	3222.305	81.353	0.502271

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	1650.234	158.853
SumBase	269.154	973.956	6.131193
SumBase_ClearBit	269.895	971.280	6.114343
SumTraits	268.655	975.765	6.142581
Sum128Base_Basic	2446.208	107.163	0.674609
Sum128Base	2447.228	107.119	0.674328
Sum128Traits	2435.628	107.629	0.677539
Sum256Base_Basic	2784.955	94.129	0.592553
Sum256Base	2752.730	95.231	0.599490
Sum256Traits	2772.589	94.548	0.595196

```

#### .NET 5.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
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
SumScalar	316.333	828.695
SumBcl	132.999	1971.016	2.378456
SumBase	132.936	1971.962	2.379598
SumBase_Basic	550.701	476.019	0.574419
SumBase_ClearBit	816.343	321.120	0.387501
SumTraits	124.734	2101.631	2.536071
Sum128Base_Basic	556.244	471.275	0.568695
Sum128Base	558.141	469.674	0.566763
Sum128Traits	133.246	1967.362	2.374047
Sum256Base_Basic	1228.393	213.404	0.257518
Sum256Base	1223.229	214.305	0.258605
Sum256Traits	1219.935	214.884	0.259303

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	290.558	902.207
SumBcl	62.313	4206.888	4.662884
SumBase	62.202	4214.430	4.671242
SumBase_Basic	798.488	328.300	0.363886
SumBase_ClearBit	399.004	656.997	0.728210
SumTraits	66.672	3931.869	4.358054
Sum128Base_Basic	833.337	314.572	0.348669
Sum128Base	834.200	314.246	0.348308
Sum128Traits	61.994	4228.566	4.686911
Sum256Base_Basic	958.282	273.556	0.303208
Sum256Base	989.042	265.048	0.293778
Sum256Traits	991.429	264.410	0.293070

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.783	901.510
SumBcl	124.642	2103.178	2.332950
SumBase	124.786	2100.754	2.330260
SumBase_Basic	551.592	475.250	0.527170
SumBase_ClearBit	817.850	320.528	0.355546
SumTraits	124.606	2103.785	2.333623
Sum128Base_Basic	557.878	469.895	0.521231
Sum128Base	560.657	467.566	0.518648
Sum128Traits	133.040	1970.418	2.185685
Sum256Base_Basic	1226.239	213.779	0.237134
Sum256Base	1224.659	214.055	0.237440
Sum256Traits	1216.843	215.430	0.238965

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	316.530	828.181
SumBcl	62.203	4214.356	5.088690
SumBase	61.811	4241.078	5.120956
SumBase_Basic	797.935	328.528	0.396686
SumBase_ClearBit	398.721	657.463	0.793863
SumTraits	66.282	3954.980	4.775503
Sum128Base_Basic	833.627	314.462	0.379702
Sum128Base	835.199	313.870	0.378987
Sum128Traits	62.226	4212.754	5.086756
Sum256Base_Basic	958.049	273.623	0.330390
Sum256Base	991.838	264.301	0.319135
Sum256Traits	989.657	264.884	0.319838

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	290.483	902.443
SumBase	358.696	730.824	0.809829
SumBase_Add	358.218	731.800	0.810910
SumTraits	124.726	2101.767	2.328975
Sum128Base_Basic	558.109	469.700	0.520476
Sum128Base	558.242	469.588	0.520352
Sum128Traits	133.322	1966.244	2.178802
Sum256Base_Basic	1224.464	214.089	0.237233
Sum256Base	1217.465	215.319	0.238596
Sum256Traits	1219.865	214.896	0.238127

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	316.783	827.520
SumBase	177.907	1473.490	1.780610
SumBase_Add	178.435	1469.131	1.775342
SumTraits	62.218	4213.338	5.091524
Sum128Base_Basic	833.752	314.415	0.379948
Sum128Base	832.028	315.066	0.380735
Sum128Traits	66.380	3949.155	4.772278
Sum256Base_Basic	963.944	271.949	0.328632
Sum256Base	990.504	264.657	0.319820
Sum256Traits	991.959	264.269	0.319351

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1614.487	162.370
SumBase	242.797	1079.684	6.649534
SumBase_ClearBit	527.464	496.989	3.060845
SumBase_ClearBit_Not	591.689	443.044	2.728608
SumTraits	125.004	2097.093	12.915527
Sum128Base_Basic	1749.423	149.846	0.922868
Sum128Base	1689.342	155.175	0.955689
Sum128Traits	132.956	1971.661	12.143024
Sum256Base_Basic	2325.777	112.712	0.694171
Sum256Base	2300.312	113.960	0.701856
Sum256Traits	2287.767	114.585	0.705704

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1758.984	149.031
SumBase	119.922	2185.952	14.667721
SumBase_ClearBit	254.077	1031.752	6.923049
SumTraits	66.498	3942.155	26.451829
Sum128Base_Basic	1753.816	149.471	1.002947
Sum128Base	1689.494	155.161	1.041131
Sum128Traits	62.273	4209.593	28.246338
Sum256Base_Basic	2275.939	115.181	0.772861
Sum256Base	2235.448	117.267	0.786860
Sum256Traits	2242.423	116.902	0.784412

```

#### .NET 6.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
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
SumScalar	290.806	901.440
SumBcl	133.148	1968.816	2.184078
SumBase	124.981	2097.476	2.326807
SumBase_Basic	543.947	481.929	0.534622
SumBase_ClearBit	763.946	343.145	0.380663
SumTraits	124.654	2102.980	2.332912
Sum128Base_Basic	555.419	471.975	0.523579
Sum128Base	557.084	470.565	0.522014
Sum128Traits	133.096	1969.581	2.184927
Sum256Base_Basic	1233.638	212.497	0.235730
Sum256Base	1226.690	213.700	0.237065
Sum256Traits	1222.970	214.350	0.237786

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	290.792	901.483
SumBcl	61.890	4235.664	4.698552
SumBase	66.299	3953.993	4.386099
SumBase_Basic	799.504	327.883	0.363715
SumBase_ClearBit	367.657	713.013	0.790933
SumTraits	61.927	4233.135	4.695747
Sum128Base_Basic	833.800	314.397	0.348755
Sum128Base	833.678	314.443	0.348806
Sum128Traits	61.999	4228.190	4.690262
Sum256Base_Basic	963.604	272.045	0.301775
Sum256Base	993.648	263.820	0.292651
Sum256Traits	989.206	265.004	0.293965

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.852	901.298
SumBcl	133.293	1966.670	2.182041
SumBase	124.672	2102.663	2.332927
SumBase_Basic	544.800	481.174	0.533868
SumBase_ClearBit	761.676	344.167	0.381857
SumTraits	133.005	1970.933	2.186771
Sum128Base_Basic	556.258	471.263	0.522871
Sum128Base	555.963	471.513	0.523149
Sum128Traits	124.761	2101.177	2.331278
Sum256Base_Basic	1222.132	214.497	0.237987
Sum256Base	1229.676	213.181	0.236527
Sum256Traits	1225.188	213.962	0.237393

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	316.508	828.238
SumBcl	66.190	3960.468	4.781799
SumBase	62.048	4224.856	5.101016
SumBase_Basic	799.821	327.753	0.395724
SumBase_ClearBit	367.719	712.892	0.860733
SumTraits	66.263	3956.107	4.776534
Sum128Base_Basic	834.084	314.290	0.379468
Sum128Base	834.456	314.149	0.379298
Sum128Traits	61.945	4231.867	5.109481
Sum256Base_Basic	963.722	272.012	0.328423
Sum256Base	993.093	263.967	0.318709
Sum256Traits	991.525	264.385	0.319213

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	316.133	829.221
SumBase	348.651	751.880	0.906730
SumBase_Add	348.654	751.874	0.906723
SumTraits	124.595	2103.964	2.537277
Sum128Base_Basic	556.202	471.311	0.568378
Sum128Base	556.301	471.227	0.568276
Sum128Traits	133.148	1968.811	2.374288
Sum256Base_Basic	1223.135	214.321	0.258461
Sum256Base	1225.165	213.966	0.258033
Sum256Traits	1225.647	213.882	0.257931

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
SumScalar	316.136	829.213
SumBase	170.938	1533.566	1.849423
SumBase_Add	170.801	1534.795	1.850905
SumTraits	66.339	3951.605	4.765488
Sum128Base_Basic	833.712	314.430	0.379191
Sum128Base	834.337	314.194	0.378907
Sum128Traits	61.833	4239.569	5.112762
Sum256Base_Basic	963.582	272.051	0.328084
Sum256Base	989.732	264.864	0.319416
Sum256Traits	992.765	264.054	0.318440

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1721.317	152.293
SumBase	240.034	1092.110	7.171122
SumBase_ClearBit	487.002	538.281	3.534517
SumBase_ClearBit_Not	553.467	473.640	3.110064
SumTraits	132.933	1972.003	12.948766
Sum128Base_Basic	1681.451	155.903	1.023709
Sum128Base	1713.000	153.032	1.004855
Sum128Traits	124.873	2099.284	13.784535
Sum256Base_Basic	2324.471	112.776	0.740520
Sum256Base	2333.321	112.348	0.737711
Sum256Traits	2341.537	111.954	0.735123

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
SumScalar	1756.906	149.208
SumBase	120.483	2175.778	14.582200
SumBase_ClearBit	233.004	1125.061	7.540230
SumTraits	62.478	4195.801	28.120522
Sum128Base_Basic	1690.449	155.074	1.039313
Sum128Base	1736.416	150.968	1.011800
Sum128Traits	66.206	3959.531	26.537026
Sum256Base_Basic	2260.103	115.988	0.777356
Sum256Base	2231.527	117.473	0.787311
Sum256Traits	2271.064	115.428	0.773605

```

#### .NET 7.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
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
SumScalar	210.947	1242.698
SumBcl	105.887	2475.688	1.992188
SumBase	105.871	2476.068	1.992494
SumBase_Basic	556.858	470.756	0.378818
SumBase_ClearBit	669.387	391.618	0.315135
SumTraits	106.014	2472.734	1.989811
Sum128Bcl	105.759	2478.700	1.994612
Sum128Base_Basic	553.443	473.660	0.381155
Sum128Base	105.944	2474.366	1.991125
Sum128Traits	105.809	2477.509	1.993654
Sum256Bcl	971.288	269.893	0.217183
Sum256Base_Basic	1159.199	226.142	0.181977
Sum256Base	1152.238	227.509	0.183076
Sum256Traits	1151.415	227.671	0.183207

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
SumScalar	210.752	1243.849
SumBcl	54.296	4828.059	3.881547
SumBase	54.296	4828.066	3.881552
SumBase_Basic	801.846	326.926	0.262834
SumBase_ClearBit	352.581	743.501	0.597742
SumTraits	54.263	4830.974	3.883890
Sum128Bcl	54.307	4827.104	3.880779
Sum128Base_Basic	805.819	325.314	0.261538
Sum128Base	54.319	4826.005	3.879895
Sum128Traits	54.559	4804.750	3.862807
Sum256Bcl	895.903	292.603	0.235240
Sum256Base_Basic	1012.604	258.881	0.208129
Sum256Base	936.150	280.023	0.225126
Sum256Traits	935.541	280.206	0.225273

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
SumScalar	210.855	1243.245
SumBcl	105.974	2473.674	1.989692
SumBase	105.845	2476.676	1.992106
SumBase_Basic	556.885	470.733	0.378632
SumBase_ClearBit	675.127	388.289	0.312319
SumTraits	106.062	2471.610	1.988031
Sum128Bcl	105.843	2476.722	1.992144
Sum128Base_Basic	551.945	474.945	0.382021
Sum128Base	105.935	2474.566	1.990409
Sum128Traits	105.736	2479.240	1.994169
Sum256Bcl	972.012	269.692	0.216926
Sum256Base_Basic	1159.831	226.019	0.181798
Sum256Base	1151.922	227.571	0.183046
Sum256Traits	1150.620	227.829	0.183253

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
SumScalar	210.941	1242.733
SumBcl	54.464	4813.179	3.873059
SumBase	54.396	4819.162	3.877873
SumBase_Basic	802.975	326.466	0.262700
SumBase_ClearBit	354.060	740.394	0.595779
SumTraits	54.557	4804.987	3.866467
Sum128Bcl	54.456	4813.831	3.873583
Sum128Base_Basic	805.807	325.319	0.261777
Sum128Base	54.438	4815.457	3.874892
Sum128Traits	54.585	4802.528	3.864488
Sum256Bcl	901.586	290.759	0.233967
Sum256Base_Basic	1010.632	259.386	0.208722
Sum256Base	936.371	279.957	0.225275
Sum256Traits	937.675	279.568	0.224962

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	211.029	1242.218
SumBase	331.185	791.534	0.637194
SumBase_Add	331.816	790.029	0.635982
SumTraits	106.209	2468.189	1.986920
Sum128Base_Basic	553.193	473.875	0.381474
Sum128Base	257.143	1019.449	0.820668
Sum128Traits	106.272	2466.738	1.985752
Sum256Base_Basic	1155.662	226.834	0.182604
Sum256Base	5261.849	49.820	0.040105
Sum256Traits	5289.623	49.558	0.039895

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	212.795	1231.907
SumBase	169.897	1542.954	1.252492
SumBase_Add	170.024	1541.802	1.251557
SumTraits	54.763	4786.917	3.885777
Sum128Base_Basic	806.205	325.158	0.263947
Sum128Base	141.036	1858.699	1.508798
Sum128Traits	55.615	4713.578	3.826244
Sum256Base_Basic	1012.410	258.931	0.210187
Sum256Base	3981.160	65.846	0.053451
Sum256Traits	3980.312	65.860	0.053462

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.817	1243.469
SumBase	212.249	1235.079	0.993253
SumBase_ClearBit	432.752	605.761	0.487154
SumBase_ClearBit_Not	499.351	524.969	0.422181
SumTraits	106.031	2472.341	1.988261
Sum128Base_Basic	558.086	469.719	0.377749
Sum128Base	163.012	1608.132	1.293263
Sum128Traits	105.934	2474.605	1.990082
Sum256Base_Basic	1153.176	227.324	0.182814
Sum256Base	3162.952	82.880	0.066652
Sum256Traits	3168.849	82.725	0.066528

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	210.800	1243.567
SumBase	112.317	2333.964	1.876830
SumBase_ClearBit	227.221	1153.694	0.927730
SumTraits	54.666	4795.365	3.856136
Sum128Base_Basic	806.780	324.926	0.261286
Sum128Base	94.760	2766.401	2.224569
Sum128Traits	54.709	4791.564	3.853080
Sum256Base_Basic	1013.245	258.717	0.208044
Sum256Base	2243.990	116.820	0.093940
Sum256Traits	2244.140	116.813	0.093934

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	8.0.7
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/
RuntimeInformation.FrameworkDescription:	.NET 8.0.7
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Ubuntu 22.04.2 LTS
RuntimeInformation.RuntimeIdentifier:	linux-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844159	# 0x8177F801
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
SumScalar	210.776	1243.712
SumBcl	107.215	2445.025	1.965909
SumBase	107.151	2446.499	1.967095
SumBase_Basic	556.605	470.970	0.378681
SumBase_ClearBit	663.542	395.068	0.317652
SumTraits	107.778	2432.257	1.955644
Sum128Bcl	107.637	2435.450	1.958211
Sum128Base_Basic	557.602	470.128	0.378004
Sum128Base	110.272	2377.245	1.911411
Sum128Traits	107.714	2433.712	1.956814
Sum256Bcl	78.337	3346.363	2.690626
Sum256Base_Basic	402.133	651.883	0.524143
Sum256Base	78.143	3354.672	2.697307
Sum256Traits	78.306	3347.693	2.691695
Sum512Bcl	77.370	3388.202	2.724266
Sum512Base	77.590	3378.592	2.716540
Sum512Traits	77.542	3380.679	2.718218

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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.6394212E+11!=-3.639422E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394212E+11!=-3.639422E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394212E+11!=-3.639422E+11
SumScalar	210.749	1243.867
SumBcl	53.650	4886.205	3.928238
SumBase	53.655	4885.701	3.927832
SumBase_Basic	799.160	328.024	0.263713
SumBase_ClearBit	310.390	844.562	0.678981
SumTraits	53.674	4883.976	3.926446
Sum128Bcl	53.680	4883.449	3.926022
Sum128Base_Basic	808.138	324.380	0.260784
Sum128Base	53.616	4889.265	3.930698
Sum128Traits	53.965	4857.623	3.905259
Sum256Bcl	54.863	4778.182	3.841393
Sum256Base_Basic	470.965	556.610	0.447484
Sum256Base	54.811	4782.663	3.844996
Sum256Traits	54.892	4775.646	3.839355
Sum512Bcl	56.018	4679.631	3.762164
Sum512Base	56.150	4668.649	3.753335
Sum512Traits	56.385	4649.159	3.737666

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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -1.5629256372728646E+21!=-1.5629256372728656E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728656E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728656E+21
SumScalar	210.766	1243.769
SumBcl	107.315	2442.751	1.963992
SumBase	107.280	2443.549	1.964633
SumBase_Basic	550.110	476.530	0.383134
SumBase_ClearBit	657.404	398.756	0.320603
SumTraits	108.025	2426.687	1.951076
Sum128Bcl	108.022	2426.772	1.951144
Sum128Base_Basic	557.400	470.298	0.378123
Sum128Base	107.694	2434.145	1.957073
Sum128Traits	107.629	2435.621	1.958259
Sum256Bcl	77.928	3363.920	2.704619
Sum256Base_Basic	410.303	638.903	0.513683
Sum256Base	78.096	3356.684	2.698801
Sum256Traits	77.955	3362.757	2.703684
Sum512Bcl	77.503	3382.358	2.719443
Sum512Base	77.560	3379.894	2.717462
Sum512Traits	77.183	3396.402	2.730735

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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.6394212E+11!=-3.6394235E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394212E+11!=-3.6394235E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394212E+11!=-3.6394235E+11
SumScalar	210.728	1243.992
SumBcl	53.636	4887.429	3.928828
SumBase	53.673	4884.052	3.926113
SumBase_Basic	797.776	328.593	0.264144
SumBase_ClearBit	311.924	840.410	0.675575
SumTraits	53.663	4884.986	3.926864
Sum128Bcl	53.663	4884.996	3.926872
Sum128Base_Basic	807.299	324.717	0.261029
Sum128Base	53.995	4854.967	3.902733
Sum128Traits	53.692	4882.401	3.924786
Sum256Bcl	54.802	4783.443	3.845237
Sum256Base_Basic	475.112	551.752	0.443534
Sum256Base	54.743	4788.635	3.849411
Sum256Traits	54.845	4779.687	3.842218
Sum512Bcl	56.133	4670.053	3.754087
Sum512Base	56.049	4677.017	3.759685
Sum512Traits	56.078	4674.595	3.757738

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
SumScalar	210.874	1243.132
SumBase	286.255	915.770	0.736663
SumBase_Add	286.029	916.493	0.737245
SumTraits	107.903	2429.434	1.954286
Sum128Base_Basic	560.300	467.864	0.376359
Sum128Base	285.097	919.491	0.739657
Sum128Traits	107.773	2432.368	1.956645
Sum256Base_Basic	413.538	633.906	0.509927
Sum256Base	250.933	1044.678	0.840360
Sum256Traits	250.767	1045.370	0.840916
Sum512Base	1973.210	132.852	0.106868
Sum512Traits	1973.289	132.846	0.106864

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394218E+11!=-3.639423E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394218E+11!=-3.639423E+11
SumScalar	210.780	1243.686
SumBase	132.535	1977.927	1.590375
SumBase_Add	132.710	1975.313	1.588273
SumTraits	53.875	4865.757	3.912368
Sum128Base_Basic	808.638	324.180	0.260660
Sum128Base	132.377	1980.277	1.592264
Sum128Traits	53.921	4861.614	3.909036
Sum256Base_Basic	471.041	556.520	0.447476
Sum256Base	123.324	2125.645	1.709149
Sum256Traits	122.971	2131.759	1.714065
Sum512Base	1029.683	254.587	0.204704
Sum512Traits	1030.057	254.495	0.204629

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
SumScalar	210.730	1243.980
SumBase	177.641	1475.699	1.186273
SumBase_ClearBit	433.790	604.311	0.485789
SumBase_ClearBit_Not	493.569	531.119	0.426952
SumTraits	107.938	2428.648	1.952321
Sum128Base_Basic	559.042	468.916	0.376948
Sum128Base	177.029	1480.799	1.190373
Sum128Traits	107.781	2432.196	1.955173
Sum256Base_Basic	406.881	644.278	0.517916
Sum256Base	158.414	1654.800	1.330247
Sum256Traits	158.556	1653.318	1.329055
Sum512Base	515.042	508.976	0.409152
Sum512Traits	515.905	508.124	0.408467

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394218E+11!=-3.639423E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394218E+11!=-3.639423E+11
SumScalar	210.683	1244.256
SumBase	86.935	3015.395	2.423453
SumBase_ClearBit	200.013	1310.633	1.053347
SumTraits	53.904	4863.135	3.908469
Sum128Base_Basic	817.036	320.847	0.257863
Sum128Base	86.204	3040.971	2.444008
Sum128Traits	54.048	4850.245	3.898109
Sum256Base_Basic	472.562	554.730	0.445833
Sum256Base	84.804	3091.158	2.484343
Sum256Traits	84.889	3088.073	2.481863
Sum512Base	311.148	842.505	0.677116
Sum512Traits	312.221	839.610	0.674789

```

## Wasm

### Wasm on AMD Ryzen 7 7840H
``

#### .NET 8.0

```
VectorTraits.Benchmarks.Wasm


IsRelease:	True
Environment.ProcessorCount:	1
Environment.Is64BitProcess:	False
Environment.OSVersion:	Other 1.0.0.0
Environment.Version:	8.0.7
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/
RuntimeInformation.FrameworkDescription:	.NET 8.0.7
RuntimeInformation.OSArchitecture:	Wasm
RuntimeInformation.OSDescription:	Browser
RuntimeInformation.RuntimeIdentifier:	browser-wasm
IntPtr.Size:	4
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	False
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844158	# 0x8177F802
VectorEnvironment.CpuModelName:	
VectorEnvironment.SupportedInstructionSets:	PackedSimd
Vector128s.Instance:	WVectorTraits128PackedSimd	// PackedSimd
Vectors.Instance:	VectorTraits128PackedSimd	// PackedSimd
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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
SumScalar	6368.750	41.161
SumBcl	12758.333	20.547	0.499184
SumBase	12738.542	20.579	0.499959
SumBase_Basic	10494.792	24.978	0.606849
SumBase_ClearBit	95850.000	2.735	0.066445
SumTraits	2528.385	103.680	2.518900
Sum128Bcl	9258.333	28.314	0.687894
Sum128Base_Basic	3530.208	74.257	1.804072
Sum128Base	8876.042	29.534	0.717521
Sum128Traits	2318.750	113.054	2.746631
Sum256Bcl	32779.167	7.997	0.194293
Sum256Base_Basic	22097.917	11.863	0.288206
Sum256Base	32175.000	8.147	0.197941
Sum256Traits	66854.167	3.921	0.095263
Sum512Bcl	50479.167	5.193	0.126166
Sum512Base	53133.333	4.934	0.119864
Sum512Traits	58933.333	4.448	0.108067

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.639451E+11!=-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639451E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639451E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639451E+11!=-3.639422E+11
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.6394212E+11!=-3.639422E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394212E+11!=-3.639422E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394212E+11!=-3.639422E+11
SumScalar	10008.333	26.193
SumBcl	7151.562	36.655	1.399461
SumBase	7314.062	35.841	1.368369
SumBase_Basic	4569.271	57.371	2.190357
SumBase_ClearBit	68175.000	3.845	0.146804
SumTraits	1257.161	208.521	7.961056
Sum128Bcl	6676.042	39.266	1.499142
Sum128Base_Basic	2477.865	105.794	4.039096
Sum128Base	6892.188	38.035	1.452127
Sum128Traits	1224.609	214.063	8.172674
Sum256Bcl	7783.854	33.678	1.285781
Sum256Base_Basic	2418.490	108.392	4.138258
Sum256Base	7796.875	33.622	1.283634
Sum256Traits	7935.417	33.035	1.261223
Sum512Bcl	14687.500	17.848	0.681418
Sum512Base	15085.417	17.377	0.663444
Sum512Traits	14195.833	18.466	0.705019

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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -1.5629256372728646E+21!=-1.5629256372728656E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728656E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728656E+21
SumScalar	5646.875	46.423
SumBcl	11910.417	22.010	0.474112
SumBase	11943.750	21.948	0.472789
SumBase_Basic	9339.583	28.068	0.604617
SumBase_ClearBit	88441.667	2.964	0.063849
SumTraits	2317.708	113.105	2.436404
Sum128Bcl	8225.000	31.872	0.686550
Sum128Base_Basic	3207.812	81.720	1.760351
Sum128Base	8313.542	31.532	0.679238
Sum128Traits	2106.771	124.429	2.680346
Sum256Bcl	30337.500	8.641	0.186135
Sum256Base_Basic	19139.583	13.696	0.295036
Sum256Base	31220.833	8.396	0.180869
Sum256Traits	41775.000	6.275	0.135174
Sum512Bcl	32858.333	7.978	0.171855
Sum512Base	32941.667	7.958	0.171420
Sum512Traits	37712.500	6.951	0.149735

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.6394523E+11!=-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394523E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394523E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394523E+11!=-3.6394235E+11
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.6394212E+11!=-3.6394235E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394212E+11!=-3.6394235E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394212E+11!=-3.6394235E+11
SumScalar	5541.667	47.304
SumBcl	4194.792	62.493	1.321083
SumBase	4280.208	61.246	1.294719
SumBase_Basic	2689.323	97.476	2.060618
SumBase_ClearBit	40341.667	6.498	0.137368
SumTraits	1103.255	237.610	5.023014
Sum128Bcl	6272.917	41.790	0.883427
Sum128Base_Basic	2388.542	109.751	2.320105
Sum128Base	6241.667	41.999	0.887850
Sum128Traits	1075.651	243.707	5.151919
Sum256Bcl	7806.250	33.581	0.709901
Sum256Base_Basic	2354.167	111.353	2.353982
Sum256Base	7668.750	34.183	0.722630
Sum256Traits	7522.396	34.848	0.736689
Sum512Bcl	13626.042	19.238	0.406697
Sum512Base	14106.250	18.584	0.392852
Sum512Traits	14022.917	18.694	0.395186

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
SumScalar	23204.167	11.297
SumBase	157483.333	1.665	0.147344
SumBase_Add	151966.667	1.725	0.152692
SumTraits	13492.708	19.429	1.719756
Sum128Base_Basic	32679.167	8.022	0.710060
Sum128Base	191066.667	1.372	0.121445
Sum128Traits	6841.146	38.319	3.391854
Sum256Base_Basic	50566.667	5.184	0.458883
Sum256Base	300666.667	0.872	0.077176
Sum256Traits	315200.000	0.832	0.073617
Sum512Base	341083.333	0.769	0.068031
Sum512Traits	334416.667	0.784	0.069387

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394218E+11!=-3.639423E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394218E+11!=-3.639423E+11
SumScalar	19989.583	13.114
SumBase	56137.500	4.670	0.356083
SumBase_Add	51637.500	5.077	0.387114
SumTraits	4247.917	61.711	4.705738
Sum128Base_Basic	25808.333	10.157	0.774540
Sum128Base	48662.500	5.387	0.410780
Sum128Traits	3307.292	79.262	6.044094
Sum256Base_Basic	29475.000	8.894	0.678188
Sum256Base	102850.000	2.549	0.194357
Sum256Traits	105691.667	2.480	0.189131
Sum512Base	123633.334	2.120	0.161684
Sum512Traits	126466.666	2.073	0.158062

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -1.5629256372728646E+21!=-1.5629256372728653E+21
SumScalar	91016.667	2.880
SumBase	57633.333	4.548	1.579237
SumBase_ClearBit	230066.666	1.139	0.395610
SumBase_ClearBit_Not	231050.000	1.135	0.393926
SumTraits	13194.792	19.867	6.897924
Sum128Base_Basic	103791.667	2.526	0.876917
Sum128Base	51720.833	5.068	1.759768
Sum128Traits	6477.083	40.473	14.052107
Sum256Base_Basic	127166.667	2.061	0.715727
Sum256Base	119883.333	2.187	0.759210
Sum256Traits	127816.666	2.051	0.712088
Sum512Base	133433.334	1.965	0.682113
Sum512Traits	144616.667	1.813	0.629365

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -3.6394218E+11!=-3.639423E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.6394218E+11!=-3.639423E+11
SumScalar	92508.333	2.834
SumBase	22870.833	11.462	4.044817
SumBase_ClearBit	100808.333	2.600	0.917666
SumTraits	4212.240	62.234	21.961793
Sum128Base_Basic	94300.000	2.780	0.981000
Sum128Base	32262.500	8.125	2.867364
Sum128Traits	3220.833	81.390	28.721863
Sum256Base_Basic	101941.667	2.572	0.907463
Sum256Base	65258.334	4.017	1.417571
Sum256Traits	66666.667	3.932	1.387625
Sum512Base	73975.000	3.544	1.250535
Sum512Traits	80683.333	3.249	1.146561

```

