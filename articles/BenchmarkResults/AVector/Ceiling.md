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
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
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
SumScalar	326.669	802.475
SumBase	569.010	460.702	0.574101
SumBase_Basic	573.668	456.961	0.569439
SumBase_ClearBit	973.610	269.249	0.335524
SumTraits	575.179	455.761	0.567943
Sum128Base_Basic	1166.975	224.635	0.279928
Sum128Base	1189.818	220.323	0.274554
Sum128Traits	1169.047	224.237	0.279432
Sum256Base_Basic	1899.919	137.976	0.171938
Sum256Base	1918.717	136.625	0.170254
Sum256Traits	1909.797	137.263	0.171049

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	347.089	755.264
SumBase	514.476	509.536	0.674646
SumBase_Basic	865.168	302.998	0.401182
SumBase_ClearBit	511.358	512.643	0.678759
SumTraits	514.989	509.028	0.673974
Sum128Base_Basic	1610.903	162.731	0.215462
Sum128Base	1595.890	164.262	0.217489
Sum128Traits	1597.914	164.054	0.217214
Sum256Base_Basic	1424.841	183.981	0.243599
Sum256Base	1447.546	181.095	0.239778
Sum256Traits	1430.238	183.287	0.242679

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	293.548	893.020
SumBase	548.154	478.230	0.535520
SumBase_Basic	546.228	479.917	0.537409
SumBase_ClearBit	934.439	280.536	0.314143
SumTraits	555.558	471.857	0.528384
Sum128Base_Basic	1161.909	225.615	0.252643
Sum128Base	1164.919	225.032	0.251990
Sum128Traits	1165.705	224.880	0.251820
Sum256Base_Basic	1843.299	142.215	0.159251
Sum256Base	1839.280	142.525	0.159599
Sum256Traits	1846.228	141.989	0.158999

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	319.772	819.783
SumBase	470.355	557.333	0.679854
SumBase_Basic	807.135	324.783	0.396182
SumBase_ClearBit	468.233	559.858	0.682934
SumTraits	468.570	559.455	0.682443
Sum128Base_Basic	1472.786	177.992	0.217121
Sum128Base	1478.108	177.351	0.216339
Sum128Traits	1476.335	177.564	0.216599
Sum256Base_Basic	1289.252	203.330	0.248029
Sum256Base	1310.954	199.964	0.243923
Sum256Traits	1314.677	199.398	0.243233

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	315.458	830.994
SumBase	361.383	725.392	0.872921
SumBase_Add	368.684	711.026	0.855633
SumTraits	362.525	723.107	0.870171
Sum128Base_Basic	1146.749	228.598	0.275089
Sum128Base	1141.664	229.616	0.276314
Sum128Traits	1160.649	225.860	0.271795
Sum256Base_Basic	1811.717	144.694	0.174121
Sum256Base	1815.079	144.426	0.173799
Sum256Traits	1814.900	144.440	0.173816

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	316.235	828.954
SumBase	175.553	1493.248	1.801365
SumBase_Add	177.058	1480.556	1.786055
SumTraits	176.593	1484.456	1.790758
Sum128Base_Basic	1461.901	179.317	0.216318
Sum128Base	1461.129	179.412	0.216432
Sum128Traits	1466.692	178.731	0.215611
Sum256Base_Basic	1288.563	203.439	0.245417
Sum256Base	1312.070	199.794	0.241020
Sum256Traits	1310.410	200.047	0.241325

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1617.590	162.058
SumBase	546.574	479.613	2.959505
SumBase_ClearBit	547.578	478.734	2.954081
SumBase_ClearBit_Not	636.839	411.633	2.540031
SumTraits	548.205	478.186	2.950704
Sum128Base_Basic	2201.114	119.096	0.734896
Sum128Base	2200.871	119.109	0.734977
Sum128Traits	2196.065	119.370	0.736585
Sum256Base_Basic	3188.265	82.222	0.507357
Sum256Base	3276.681	80.003	0.493667
Sum256Traits	3312.224	79.144	0.488370

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	1758.505	149.072
SumBase	262.170	999.902	6.707505
SumBase_ClearBit	263.046	996.570	6.685156
SumTraits	261.909	1000.899	6.714195
Sum128Base_Basic	2465.749	106.314	0.713173
Sum128Base	2305.661	113.696	0.762690
Sum128Traits	2361.832	110.992	0.744551
Sum256Base_Basic	2778.018	94.364	0.633007
Sum256Base	2824.852	92.799	0.622512
Sum256Traits	2761.713	94.921	0.636744

```

#### .NET 5.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
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
SumScalar	291.546	899.152
SumBcl	125.383	2090.753	2.325249
SumBase	125.402	2090.424	2.324883
SumBase_Basic	555.321	472.059	0.525004
SumBase_ClearBit	822.085	318.877	0.354642
SumTraits	125.496	2088.857	2.323141
Sum128Base_Basic	558.168	469.651	0.522326
Sum128Base	558.192	469.630	0.522304
Sum128Traits	133.333	1966.092	2.186606
Sum256Base_Basic	1223.599	214.240	0.238269
Sum256Base	1451.303	180.627	0.200885
Sum256Traits	1223.447	214.267	0.238299

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	317.721	825.076
SumBcl	66.778	3925.614	4.757884
SumBase	66.931	3916.635	4.747001
SumBase_Basic	805.047	325.626	0.394662
SumBase_ClearBit	402.149	651.857	0.790058
SumTraits	62.704	4180.633	5.066969
Sum128Base_Basic	838.502	312.634	0.378915
Sum128Base	839.740	312.173	0.378356
Sum128Traits	66.681	3931.319	4.764798
Sum256Base_Basic	968.665	270.624	0.327999
Sum256Base	994.847	263.502	0.319367
Sum256Traits	991.154	264.484	0.320557

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	317.287	826.205
SumBcl	133.436	1964.571	2.377825
SumBase	125.073	2095.930	2.536815
SumBase_Basic	552.000	474.898	0.574795
SumBase_ClearBit	817.529	320.654	0.388105
SumTraits	125.524	2088.397	2.527698
Sum128Base_Basic	558.635	469.258	0.567968
Sum128Base	559.784	468.295	0.566802
Sum128Traits	133.730	1960.246	2.372590
Sum256Base_Basic	1228.107	213.454	0.258354
Sum256Base	1224.504	214.082	0.259115
Sum256Traits	1220.554	214.775	0.259953

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	290.902	901.142
SumBcl	66.632	3934.178	4.365768
SumBase	66.824	3922.912	4.353266
SumBase_Basic	803.629	326.200	0.361985
SumBase_ClearBit	400.173	655.076	0.726940
SumTraits	62.402	4200.880	4.661728
Sum128Base_Basic	834.769	314.032	0.348482
Sum128Base	834.005	314.320	0.348801
Sum128Traits	66.668	3932.085	4.363445
Sum256Base_Basic	967.479	270.956	0.300680
Sum256Base	995.821	263.244	0.292123
Sum256Traits	995.682	263.281	0.292163

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
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
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
SumScalar	292.543	896.087
SumBcl	134.348	1951.236	2.177507
SumBase	126.451	2073.086	2.313487
SumBase_Basic	555.192	472.168	0.526922
SumBase_ClearBit	787.352	332.944	0.371553
SumTraits	126.432	2073.393	2.313830
Sum128Base_Basic	556.719	470.873	0.525477
Sum128Base	562.085	466.378	0.520460
Sum128Traits	134.844	1944.047	2.169485
Sum256Base_Basic	1230.210	213.089	0.237799
Sum256Base	1231.666	212.837	0.237518
Sum256Traits	1219.893	214.891	0.239810

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	319.058	821.620
SumBcl	66.664	3932.328	4.786068
SumBase	62.823	4172.717	5.078646
SumBase_Basic	805.704	325.360	0.395998
SumBase_ClearBit	368.686	711.023	0.865392
SumTraits	67.015	3911.738	4.761008
Sum128Base_Basic	834.069	314.295	0.382531
Sum128Base	837.119	313.150	0.381137
Sum128Traits	62.605	4187.274	5.096365
Sum256Base_Basic	960.737	272.857	0.332097
Sum256Base	995.071	263.443	0.320638
Sum256Traits	993.722	263.800	0.321073

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.724	901.694
SumBcl	133.463	1964.175	2.178317
SumBase	125.403	2090.415	2.318321
SumBase_Basic	553.109	473.946	0.525618
SumBase_ClearBit	783.705	334.493	0.370961
SumTraits	134.039	1955.724	2.168945
Sum128Base_Basic	559.524	468.512	0.519591
Sum128Base	559.232	468.757	0.519863
Sum128Traits	126.443	2073.220	2.299251
Sum256Base_Basic	1232.297	212.728	0.235920
Sum256Base	1232.359	212.717	0.235909
Sum256Traits	1230.630	213.016	0.236240

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	317.563	825.485
SumBcl	66.955	3915.212	4.742921
SumBase	62.676	4182.531	5.066754
SumBase_Basic	797.493	328.710	0.398202
SumBase_ClearBit	367.889	712.563	0.863205
SumTraits	66.603	3935.907	4.767992
Sum128Base_Basic	834.861	313.997	0.380379
Sum128Base	833.197	314.624	0.381139
Sum128Traits	62.455	4197.332	5.084684
Sum256Base_Basic	959.919	273.090	0.330823
Sum256Base	993.468	263.868	0.319652
Sum256Traits	995.785	263.253	0.318908

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	316.008	829.548
SumBase	350.602	747.696	0.901329
SumBase_Add	350.307	748.325	0.902088
SumTraits	125.376	2090.865	2.520486
Sum128Base_Basic	554.236	472.983	0.570169
Sum128Base	557.866	469.905	0.566459
Sum128Traits	133.490	1963.770	2.367276
Sum256Base_Basic	1223.902	214.187	0.258197
Sum256Base	1228.344	213.412	0.257263
Sum256Traits	1225.052	213.986	0.257955

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
SumScalar	317.127	826.621
SumBase	170.880	1534.078	1.855843
SumBase_Add	170.928	1533.654	1.855330
SumTraits	66.687	3930.969	4.755469
Sum128Base_Basic	832.283	314.970	0.381033
Sum128Base	834.024	314.312	0.380238
Sum128Traits	62.628	4185.752	5.063691
Sum256Base_Basic	959.625	273.173	0.330470
Sum256Base	992.188	264.208	0.319624
Sum256Traits	989.307	264.977	0.320555

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1619.824	161.835
SumBase	242.020	1083.150	6.692935
SumBase_ClearBit	488.172	536.991	3.318140
SumBase_ClearBit_Not	555.443	471.955	2.916276
SumTraits	125.551	2087.945	12.901703
Sum128Base_Basic	1745.447	150.187	0.928029
Sum128Base	1684.608	155.611	0.961544
Sum128Traits	133.616	1961.925	12.123010
Sum256Base_Basic	2291.762	114.385	0.706803
Sum256Base	2285.521	114.698	0.708733
Sum256Traits	2266.133	115.679	0.714797

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
SumScalar	1655.819	158.317
SumBase	125.798	2083.851	13.162538
SumBase_ClearBit	233.310	1123.586	7.097077
SumTraits	66.781	3925.433	24.794799
Sum128Base_Basic	1703.176	153.915	0.972195
Sum128Base	1758.479	149.074	0.941620
Sum128Traits	62.577	4189.171	26.460684
Sum256Base_Basic	2313.301	113.320	0.715782
Sum256Base	2228.731	117.620	0.742943
Sum256Traits	2241.870	116.931	0.738588

```

#### .NET 7.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
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
SumScalar	210.630	1244.573
SumBcl	106.143	2469.722	1.984393
SumBase	106.167	2469.159	1.983940
SumBase_Basic	547.470	478.828	0.384732
SumBase_ClearBit	669.155	391.754	0.314770
SumTraits	106.190	2468.633	1.983518
Sum128Bcl	106.178	2468.907	1.983738
Sum128Base_Basic	550.488	476.203	0.382624
Sum128Base	106.114	2470.400	1.984937
Sum128Traits	106.064	2471.567	1.985875
Sum256Bcl	969.415	270.415	0.217275
Sum256Base_Basic	1155.258	226.914	0.182323
Sum256Base	1150.868	227.779	0.183018
Sum256Traits	1150.202	227.911	0.183124

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
SumScalar	211.052	1242.081
SumBcl	55.471	4725.805	3.804747
SumBase	55.310	4739.567	3.815827
SumBase_Basic	801.473	327.078	0.263331
SumBase_ClearBit	352.459	743.757	0.598799
SumTraits	55.329	4737.914	3.814496
Sum128Bcl	55.275	4742.519	3.818203
Sum128Base_Basic	806.072	325.212	0.261828
Sum128Base	55.317	4738.913	3.815300
Sum128Traits	55.347	4736.413	3.813287
Sum256Bcl	900.541	291.096	0.234362
Sum256Base_Basic	1008.817	259.853	0.209208
Sum256Base	938.368	279.362	0.224914
Sum256Traits	938.640	279.281	0.224849

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
SumScalar	210.987	1242.465
SumBcl	106.642	2458.168	1.978460
SumBase	106.406	2463.610	1.982840
SumBase_Basic	549.012	477.483	0.384303
SumBase_ClearBit	677.598	386.872	0.311375
SumTraits	106.632	2458.408	1.978653
Sum128Bcl	106.413	2463.456	1.982716
Sum128Base_Basic	550.809	475.925	0.383049
Sum128Base	106.375	2464.333	1.983422
Sum128Traits	106.252	2467.197	1.985727
Sum256Bcl	969.631	270.354	0.217595
Sum256Base_Basic	1160.790	225.833	0.181762
Sum256Base	1156.610	226.649	0.182418
Sum256Traits	1153.327	227.294	0.182938

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
SumScalar	211.486	1239.536
SumBcl	55.485	4724.561	3.811555
SumBase	55.446	4727.887	3.814238
SumBase_Basic	801.987	326.868	0.263702
SumBase_ClearBit	354.579	739.310	0.596441
SumTraits	55.333	4737.593	3.822069
Sum128Bcl	55.329	4737.922	3.822334
Sum128Base_Basic	807.494	324.639	0.261904
Sum128Base	55.343	4736.704	3.821351
Sum128Traits	55.439	4728.512	3.814743
Sum256Bcl	901.884	290.663	0.234493
Sum256Base_Basic	1014.551	258.384	0.208452
Sum256Base	939.994	278.878	0.224986
Sum256Traits	939.782	278.941	0.225037

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.904	1242.953
SumBase	333.817	785.293	0.631796
SumBase_Add	333.789	785.359	0.631849
SumTraits	106.318	2465.669	1.983719
Sum128Base_Basic	550.889	475.856	0.382843
Sum128Base	256.430	1022.284	0.822464
Sum128Traits	106.168	2469.134	1.986506
Sum256Base_Basic	1151.946	227.566	0.183085
Sum256Base	5301.528	49.447	0.039782
Sum256Traits	5304.213	49.422	0.039762

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	211.207	1241.168
SumBase	171.605	1527.605	1.230780
SumBase_Add	171.585	1527.781	1.230921
SumTraits	55.592	4715.479	3.799226
Sum128Base_Basic	804.118	326.002	0.262657
Sum128Base	142.941	1833.935	1.477587
Sum128Traits	55.620	4713.160	3.797358
Sum256Base_Basic	1008.929	259.824	0.209338
Sum256Base	4065.188	64.485	0.051955
Sum256Traits	4066.276	64.468	0.051941

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.544	1245.080
SumBase	217.072	1207.634	0.969925
SumBase_ClearBit	432.224	606.500	0.487117
SumBase_ClearBit_Not	491.318	533.553	0.428529
SumTraits	106.385	2464.112	1.979079
Sum128Base_Basic	550.969	475.787	0.382134
Sum128Base	163.755	1600.828	1.285723
Sum128Traits	106.274	2466.672	1.981135
Sum256Base_Basic	1154.264	227.109	0.182405
Sum256Base	3270.713	80.149	0.064372
Sum256Traits	3259.477	80.425	0.064594

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	211.241	1240.973
SumBase	114.997	2279.574	1.836924
SumBase_ClearBit	227.485	1152.359	0.928593
SumTraits	55.442	4728.263	3.810124
Sum128Base_Basic	803.897	326.092	0.262771
Sum128Base	94.297	2779.974	2.240156
Sum128Traits	55.400	4731.875	3.813035
Sum256Base_Basic	1008.695	259.884	0.209420
Sum256Base	2258.561	116.067	0.093529
Sum256Traits	2259.867	116.000	0.093475

```

