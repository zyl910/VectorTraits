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

