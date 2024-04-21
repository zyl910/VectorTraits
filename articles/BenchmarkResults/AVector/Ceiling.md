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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9232.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks/bin/Release/Release/System.Numerics.Vectors.DLL
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
SumScalar	477.076	549.481
SumBase	170.500	1537.499	2.798093
SumBase_Basic	847.691	309.245	0.562794
SumBase_ClearBit	170.952	1533.438	2.790701
SumTraits	165.020	1588.560	2.891019

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	461.439	568.101
SumBase	86.817	3019.487	5.315049
SumBase_Basic	739.694	354.395	0.623824
SumBase_ClearBit	110.969	2362.310	4.158255
SumTraits	101.235	2589.451	4.558080

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	543.840	482.024
SumBase	161.681	1621.366	3.363661
SumBase_Basic	804.689	325.770	0.675838
SumBase_ClearBit	161.597	1622.208	3.365408
SumTraits	160.154	1636.828	3.395737

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	523.732	500.530
SumBase	84.981	3084.739	6.162940
SumBase_Basic	607.677	431.387	0.861859
SumBase_ClearBit	85.801	3055.240	6.104004
SumTraits	86.144	3043.084	6.079717

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1911.567	137.136
SumBase	72.471	3617.250	26.377173
SumBase_Add	72.968	3592.600	26.197419
SumTraits	73.526	3565.323	25.998516

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	1909.597	137.277
SumBase	37.956	6906.579	50.311205
SumBase_Add	37.703	6952.866	50.648379
SumTraits	37.766	6941.215	50.563507

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1198.256	218.771
SumBase	105.515	2484.427	11.356278
SumBase_ClearBit	104.421	2510.442	11.475194
SumBase_ClearBit_Not	104.621	2505.658	11.453327
SumTraits	105.041	2495.632	11.407496

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	2009.983	130.421
SumBase	55.457	4726.957	36.243838
SumBase_ClearBit	55.527	4721.061	36.198631
SumTraits	55.300	4740.410	36.346989

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
SumScalar	232.506	1127.470
SumBase	162.212	1616.057	1.433347
SumBase_Basic	500.274	524.000	0.464757
SumBase_ClearBit	164.088	1597.584	1.416963
SumTraits	162.376	1614.423	1.431898

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	232.680	1126.627
SumBase	84.578	3099.450	2.751088
SumBase_Basic	281.440	931.439	0.826751
SumBase_ClearBit	84.977	3084.885	2.738160
SumTraits	84.750	3093.159	2.745505

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	244.391	1072.642
SumBase	163.439	1603.926	1.495304
SumBase_Basic	497.599	526.818	0.491140
SumBase_ClearBit	162.182	1616.361	1.506897
SumTraits	167.493	1565.100	1.459107

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	233.466	1122.837
SumBase	83.868	3125.691	2.783743
SumBase_Basic	281.863	930.041	0.828295
SumBase_ClearBit	84.839	3089.907	2.751874
SumTraits	85.301	3073.165	2.736964

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	241.224	1086.725
SumBase	71.683	3657.002	3.365158
SumBase_Add	70.841	3700.431	3.405122
SumTraits	71.644	3658.977	3.366975

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639451E+11
SumScalar	233.425	1123.031
SumBase	35.297	7426.872	6.613240
SumBase_Add	35.722	7338.376	6.534438
SumTraits	35.367	7412.166	6.600144

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1162.868	225.429
SumBase	106.871	2452.903	10.881053
SumBase_ClearBit	107.225	2444.809	10.845151
SumBase_ClearBit_Not	106.820	2454.072	10.886241
SumTraits	107.707	2433.854	10.796553

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	981.678	267.037
SumBase	55.425	4729.666	17.711667
SumBase_ClearBit	55.046	4762.280	17.833800
SumTraits	55.447	4727.789	17.704638

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
SumScalar	239.971	1092.399
SumBase	138.403	1894.059	1.733853
SumBase_Basic	500.171	524.109	0.479778
SumBase_ClearBit	136.520	1920.193	1.757776
SumTraits	57.804	4535.059	4.151467
Sum128Base_Basic	928.184	282.427	0.258538
Sum128Base	920.628	284.745	0.260660
Sum128Traits	115.238	2274.812	2.082400
Sum256Base_Basic	504.193	519.928	0.475951
Sum256Base	501.272	522.958	0.478724
Sum256Traits	57.660	4546.414	4.161861

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	233.923	1120.641
SumBase	73.805	3551.870	3.169498
SumBase_Basic	277.975	943.050	0.841527
SumBase_ClearBit	73.528	3565.213	3.181404
SumTraits	28.932	9060.761	8.085337
Sum128Base_Basic	479.209	547.035	0.488145
Sum128Base	478.607	547.723	0.488759
Sum128Traits	57.279	4576.617	4.083928
Sum256Base_Basic	280.572	934.319	0.833736
Sum256Base	278.338	941.819	0.840428
Sum256Traits	28.778	9109.209	8.128570

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	233.696	1121.733
SumBase	140.005	1872.387	1.669192
SumBase_Basic	497.794	526.612	0.469463
SumBase_ClearBit	138.731	1889.580	1.684519
SumTraits	57.784	4536.658	4.044331
Sum128Base_Basic	934.312	280.574	0.250126
Sum128Base	929.700	281.966	0.251367
Sum128Traits	115.129	2276.960	2.029860
Sum256Base_Basic	502.148	522.046	0.465392
Sum256Base	503.446	520.700	0.464192
Sum256Traits	57.985	4520.881	4.030267

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	234.915	1115.910
SumBase	73.623	3560.632	3.190788
SumBase_Basic	279.985	936.280	0.839028
SumBase_ClearBit	74.204	3532.735	3.165788
SumTraits	29.131	8998.757	8.064052
Sum128Base_Basic	479.002	547.271	0.490426
Sum128Base	481.714	544.190	0.487665
Sum128Traits	57.860	4530.685	4.060081
Sum256Base_Basic	279.993	936.254	0.839005
Sum256Base	279.648	937.408	0.840039
Sum256Traits	29.022	9032.480	8.094273

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	233.153	1124.342
SumBase	61.049	4294.002	3.819125
SumBase_Add	61.929	4233.006	3.764875
SumTraits	57.561	4554.227	4.050572
Sum128Base_Basic	932.391	281.152	0.250060
Sum128Base	929.813	281.932	0.250753
Sum128Traits	114.572	2288.033	2.034998
Sum256Base_Basic	496.813	527.652	0.469298
Sum256Base	501.240	522.991	0.465153
Sum256Traits	57.715	4542.008	4.039705

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	233.652	1121.941
SumBase	30.502	8594.248	7.660161
SumBase_Add	30.146	8695.917	7.750780
SumTraits	28.806	9100.447	8.111342
Sum128Base_Basic	479.180	547.068	0.487608
Sum128Base	477.556	548.928	0.489266
Sum128Traits	57.637	4548.166	4.053838
Sum256Base_Basic	278.161	942.418	0.839989
Sum256Base	279.426	938.150	0.836185
Sum256Traits	28.832	9092.239	8.104026

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1312.210	199.773
SumBase	84.633	3097.405	15.504624
SumBase_ClearBit	84.330	3108.555	15.560438
SumBase_ClearBit_Not	96.315	2721.747	13.624198
SumTraits	57.521	4557.374	22.812765
Sum128Base_Basic	1392.229	188.291	0.942524
Sum128Base	1396.310	187.741	0.939770
Sum128Traits	115.117	2277.204	11.398961
Sum256Base_Basic	1105.955	237.030	1.186495
Sum256Base	1127.212	232.560	1.164120
Sum256Traits	57.578	4552.880	22.790271

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1032.639	253.858
SumBase	47.323	5539.411	21.820887
SumBase_ClearBit	47.862	5477.033	21.575168
SumTraits	28.760	9115.006	35.905896
Sum128Base_Basic	969.086	270.506	1.065580
Sum128Base	983.232	266.615	1.050250
Sum128Traits	57.511	4558.137	17.955446
Sum256Base_Basic	1052.249	249.127	0.981365
Sum256Base	1051.722	249.252	0.981856
Sum256Traits	28.869	9080.462	35.769818

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
SumScalar	233.135	1124.432
SumBcl	57.631	4548.655	4.045291
SumBase	57.750	4539.289	4.036962
SumBase_Basic	496.769	527.698	0.469302
SumBase_ClearBit	137.315	1909.074	1.697812
SumTraits	57.522	4557.286	4.052967
Sum128Base_Basic	918.007	285.558	0.253957
Sum128Base	924.574	283.529	0.252154
Sum128Traits	114.731	2284.851	2.032005
Sum256Base_Basic	498.212	526.170	0.467943
Sum256Base	498.931	525.411	0.467268
Sum256Traits	57.524	4557.132	4.052831

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	234.565	1117.575
SumBcl	28.803	9101.356	8.143844
SumBase	28.838	9090.081	8.133756
SumBase_Basic	267.663	979.380	0.876344
SumBase_ClearBit	72.408	3620.351	3.239471
SumTraits	28.932	9060.652	8.107424
Sum128Base_Basic	480.892	545.120	0.487771
Sum128Base	480.843	545.175	0.487820
Sum128Traits	57.439	4563.884	4.083739
Sum256Base_Basic	269.298	973.434	0.871024
Sum256Base	269.901	971.258	0.869077
Sum256Traits	29.082	9013.888	8.065579

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	234.786	1116.525
SumBcl	57.881	4529.003	4.056339
SumBase	57.970	4522.051	4.050113
SumBase_Basic	524.607	499.696	0.447546
SumBase_ClearBit	136.354	1922.532	1.721889
SumTraits	57.847	4531.654	4.058714
Sum128Base_Basic	929.646	281.983	0.252554
Sum128Base	929.404	282.056	0.252620
Sum128Traits	115.632	2267.054	2.030456
Sum256Base_Basic	521.577	502.599	0.450146
Sum256Base	527.033	497.396	0.445486
Sum256Traits	57.839	4532.267	4.059263

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	248.889	1053.258
SumBcl	28.933	9060.489	8.602343
SumBase	28.916	9065.826	8.607411
SumBase_Basic	288.284	909.327	0.863347
SumBase_ClearBit	71.782	3651.926	3.467265
SumTraits	28.963	9050.841	8.593183
Sum128Base_Basic	480.517	545.545	0.517960
Sum128Base	480.409	545.669	0.518077
Sum128Traits	57.737	4540.344	4.310760
Sum256Base_Basic	290.949	900.997	0.855438
Sum256Base	288.528	908.556	0.862614
Sum256Traits	28.962	9051.236	8.593558

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	235.403	1113.595
SumBase	66.890	3919.030	3.519260
SumBase_Add	60.862	4307.183	3.867818
SumTraits	58.192	4504.822	4.045296
Sum128Base_Basic	934.475	280.525	0.251910
Sum128Base	942.395	278.168	0.249793
Sum128Traits	115.839	2263.003	2.032160
Sum256Base_Basic	537.911	487.337	0.437625
Sum256Base	526.832	497.586	0.446828
Sum256Traits	57.976	4521.624	4.060385

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	244.548	1071.953
SumBase	30.365	8633.230	8.053738
SumBase_Add	30.756	8523.335	7.951220
SumTraits	29.023	9032.208	8.425935
Sum128Base_Basic	480.630	545.418	0.508807
Sum128Base	480.702	545.336	0.508731
Sum128Traits	57.780	4536.940	4.232406
Sum256Base_Basic	289.111	906.724	0.845861
Sum256Base	287.205	912.741	0.851475
Sum256Traits	28.919	9064.727	8.456272

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1232.380	212.714
SumBase	58.648	4469.761	21.013040
SumBase_ClearBit	85.951	3049.924	14.338167
SumBase_ClearBit_Not	97.795	2680.540	12.601632
SumTraits	57.615	4549.931	21.389930
Sum128Base_Basic	1403.463	186.784	0.878099
Sum128Base	1377.697	190.277	0.894522
Sum128Traits	114.970	2280.101	10.719106
Sum256Base_Basic	1095.028	239.395	1.125432
Sum256Base	1081.755	242.332	1.139241
Sum256Traits	57.890	4528.293	21.288209

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1027.771	255.061
SumBase	29.430	8907.324	34.922353
SumBase_ClearBit	45.830	5719.901	22.425634
SumTraits	28.976	9046.807	35.469215
Sum128Base_Basic	958.673	273.445	1.072077
Sum128Base	973.226	269.356	1.056045
Sum128Traits	57.807	4534.828	17.779400
Sum256Base_Basic	1048.649	249.983	0.980090
Sum256Base	1041.882	251.606	0.986456
Sum256Traits	28.937	9059.106	35.517437

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.29
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.29\
RuntimeInformation.FrameworkDescription:	.NET 6.0.29
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.29/System.Private.CoreLib.dll
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
SumScalar	237.748	1102.614
SumBcl	57.892	4528.132	4.106723
SumBase	57.906	4527.078	4.105767
SumBase_Basic	501.851	522.354	0.473741
SumBase_ClearBit	140.166	1870.234	1.696181
SumTraits	57.833	4532.775	4.110934
Sum128Base_Basic	926.071	283.071	0.256727
Sum128Base	930.250	281.799	0.255574
Sum128Traits	115.518	2269.301	2.058109
Sum256Base_Basic	496.902	527.557	0.478460
Sum256Base	500.161	524.119	0.475342
Sum256Traits	57.824	4533.510	4.111600

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	234.331	1118.693
SumBcl	29.007	9037.121	8.078285
SumBase	29.040	9026.872	8.069123
SumBase_Basic	269.748	971.809	0.868701
SumBase_ClearBit	81.666	3209.938	2.869364
SumTraits	28.954	9053.813	8.093205
Sum128Base_Basic	488.475	536.657	0.479718
Sum128Base	497.637	526.777	0.470886
Sum128Traits	57.739	4540.152	4.058443
Sum256Base_Basic	288.809	907.673	0.811369
Sum256Base	285.461	918.318	0.820885
Sum256Traits	29.108	9006.011	8.050475

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	237.514	1103.699
SumBcl	57.918	4526.099	4.100847
SumBase	58.161	4507.183	4.083708
SumBase_Basic	526.445	497.952	0.451166
SumBase_ClearBit	140.695	1863.205	1.688146
SumTraits	57.662	4546.235	4.119091
Sum128Base_Basic	932.688	281.063	0.254656
Sum128Base	931.113	281.538	0.255086
Sum128Traits	115.262	2274.334	2.060647
Sum256Base_Basic	524.875	499.441	0.452516
Sum256Base	527.548	496.910	0.450223
Sum256Traits	58.051	4515.775	4.091493

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	233.482	1122.757
SumBcl	28.885	9075.379	8.083118
SumBase	29.095	9010.049	8.024930
SumBase_Basic	288.836	907.588	0.808356
SumBase_ClearBit	73.200	3581.185	3.189635
SumTraits	29.007	9037.348	8.049245
Sum128Base_Basic	481.015	544.981	0.485395
Sum128Base	482.410	543.405	0.483991
Sum128Traits	57.721	4541.554	4.045001
Sum256Base_Basic	289.023	907.001	0.807834
Sum256Base	288.435	908.848	0.809479
Sum256Traits	28.886	9075.226	8.082982

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	235.407	1113.578
SumBase	59.390	4413.941	3.963745
SumBase_Add	59.789	4384.467	3.937277
SumTraits	57.535	4556.273	4.091560
Sum128Base_Basic	927.967	282.493	0.253680
Sum128Base	930.420	281.748	0.253011
Sum128Traits	114.949	2280.533	2.047932
Sum256Base_Basic	522.548	501.665	0.450498
Sum256Base	523.484	500.768	0.449693
Sum256Traits	57.533	4556.398	4.091672

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	238.338	1099.883
SumBase	29.793	8798.793	7.999754
SumBase_Add	29.911	8764.051	7.968167
SumTraits	28.875	9078.546	8.254102
Sum128Base_Basic	480.342	545.745	0.496185
Sum128Base	478.674	547.646	0.497913
Sum128Traits	57.456	4562.526	4.148193
Sum256Base_Basic	287.772	910.943	0.828218
Sum256Base	287.989	910.256	0.827594
Sum256Traits	28.861	9082.861	8.258025

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1247.562	210.125
SumBase	58.391	4489.447	21.365597
SumBase_ClearBit	88.757	2953.497	14.055903
SumBase_ClearBit_Not	96.210	2724.701	12.967046
SumTraits	57.758	4538.633	21.599679
Sum128Base_Basic	1376.787	190.403	0.906140
Sum128Base	1369.967	191.351	0.910651
Sum128Traits	115.340	2272.794	10.816389
Sum256Base_Basic	1100.913	238.115	1.133207
Sum256Base	1072.634	244.393	1.163082
Sum256Traits	57.581	4552.627	21.666279

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1069.524	245.103
SumBase	29.407	8914.283	36.369465
SumBase_ClearBit	46.066	5690.653	23.217345
SumTraits	28.803	9101.294	37.132454
Sum128Base_Basic	966.247	271.301	1.106885
Sum128Base	958.667	273.446	1.115636
Sum128Traits	57.454	4562.710	18.615440
Sum256Base_Basic	1038.680	252.382	1.029695
Sum256Base	1040.018	252.057	1.028371
Sum256Traits	28.745	9119.587	37.207088

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.18
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.18\
RuntimeInformation.FrameworkDescription:	.NET 7.0.18
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.18/System.Private.CoreLib.dll
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
SumScalar	233.591	1122.235
SumBcl	57.468	4561.589	4.064735
SumBase	57.628	4548.923	4.053448
SumBase_Basic	496.299	528.197	0.470665
SumBase_ClearBit	119.929	2185.821	1.947739
SumTraits	57.682	4544.622	4.049615
Sum128Bcl	115.282	2273.938	2.026258
Sum128Base_Basic	925.496	283.247	0.252395
Sum128Base	115.275	2274.075	2.026380
Sum128Traits	114.994	2279.640	2.031338
Sum256Bcl	57.830	4532.985	4.039246
Sum256Base_Basic	497.505	526.918	0.469525
Sum256Base	57.585	4552.297	4.056454
Sum256Traits	57.831	4532.947	4.039213

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
SumScalar	233.768	1121.387
SumBcl	29.198	8978.265	8.006396
SumBase	29.146	8994.253	8.020653
SumBase_Basic	278.814	940.211	0.838436
SumBase_ClearBit	60.464	4335.544	3.866235
SumTraits	29.061	9020.588	8.044138
Sum128Bcl	57.922	4525.813	4.035908
Sum128Base_Basic	479.557	546.638	0.487466
Sum128Base	57.846	4531.776	4.041226
Sum128Traits	57.834	4532.696	4.042046
Sum256Bcl	29.138	8996.508	8.022664
Sum256Base_Basic	278.291	941.978	0.840012
Sum256Base	29.146	8994.049	8.020471
Sum256Traits	29.099	9008.715	8.033549

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
SumScalar	236.694	1107.525
SumBcl	57.874	4529.562	4.089806
SumBase	57.630	4548.732	4.107115
SumBase_Basic	500.447	523.820	0.472964
SumBase_ClearBit	119.214	2198.939	1.985453
SumTraits	57.718	4541.788	4.100845
Sum128Bcl	114.867	2282.151	2.060587
Sum128Base_Basic	922.120	284.284	0.256684
Sum128Base	115.824	2263.301	2.043567
Sum128Traits	115.292	2273.737	2.052990
Sum256Bcl	57.895	4527.914	4.088318
Sum256Base_Basic	498.829	525.519	0.474498
Sum256Base	57.729	4540.965	4.100103
Sum256Traits	57.523	4557.232	4.114790

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
SumScalar	236.296	1109.390
SumBcl	28.843	9088.603	8.192431
SumBase	28.943	9057.185	8.164111
SumBase_Basic	279.118	939.186	0.846578
SumBase_ClearBit	59.952	4372.585	3.941431
SumTraits	28.990	9042.411	8.150793
Sum128Bcl	57.581	4552.634	4.103726
Sum128Base_Basic	480.538	545.522	0.491732
Sum128Base	57.582	4552.501	4.103606
Sum128Traits	57.594	4551.585	4.102781
Sum256Bcl	28.911	9067.260	8.173192
Sum256Base_Basic	278.494	941.292	0.848477
Sum256Base	29.058	9021.332	8.131793
Sum256Traits	29.071	9017.492	8.128332

[YRoundToEvenBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	233.425	1123.031
SumBase	59.915	4375.248	3.895927
SumBase_Add	59.735	4388.451	3.907683
SumTraits	57.522	4557.252	4.057991
Sum128Base_Basic	922.431	284.188	0.253054
Sum128Base	117.272	2235.358	1.990468
Sum128Traits	114.774	2284.006	2.033786
Sum256Base_Basic	517.010	507.039	0.451491
Sum256Base	60.686	4319.713	3.846476
Sum256Traits	57.630	4548.715	4.050390

[YRoundToEvenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	234.753	1116.682
SumBase	30.044	8725.480	7.813759
SumBase_Add	30.415	8618.836	7.718258
SumTraits	28.749	9118.384	8.165608
Sum128Base_Basic	479.555	546.640	0.489522
Sum128Base	58.866	4453.220	3.987905
Sum128Traits	57.356	4570.443	4.092879
Sum256Base_Basic	289.616	905.143	0.810565
Sum256Base	30.072	8717.290	7.806424
Sum256Traits	28.824	9094.801	8.144489

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	242.654	1080.320
SumBase	58.614	4472.370	4.139857
SumBase_ClearBit	72.550	3613.276	3.344635
SumBase_ClearBit_Not	86.990	3013.479	2.789432
SumTraits	58.014	4518.665	4.182710
Sum128Base_Basic	921.270	284.546	0.263391
Sum128Base	115.784	2264.081	2.095751
Sum128Traits	115.100	2277.533	2.108203
Sum256Base_Basic	518.166	505.908	0.468294
Sum256Base	58.147	4508.334	4.173147
Sum256Traits	57.578	4552.889	4.214389

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	236.660	1107.682
SumBase	29.321	8940.517	8.071376
SumBase_ClearBit	36.651	7152.393	6.457083
SumTraits	28.884	9075.862	8.193564
Sum128Base_Basic	480.432	545.643	0.492599
Sum128Base	57.772	4537.569	4.096455
Sum128Traits	57.496	4559.340	4.116109
Sum256Base_Basic	288.681	908.074	0.819797
Sum256Base	29.046	9025.011	8.147656
Sum256Traits	28.934	9060.196	8.179421

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.4
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.4\
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.4/System.Private.CoreLib.dll
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
SumScalar	236.316	1109.296
SumBcl	57.792	4536.003	4.089081
SumBase	57.672	4545.412	4.097563
SumBase_Basic	513.635	510.370	0.460084
SumBase_ClearBit	118.122	2219.273	2.000613
SumTraits	57.740	4540.038	4.092719
Sum128Bcl	115.011	2279.292	2.054718
Sum128Base_Basic	940.315	278.783	0.251315
Sum128Base	114.854	2282.416	2.057535
Sum128Traits	114.873	2282.041	2.057197
Sum256Bcl	57.648	4547.338	4.099299
Sum256Base_Basic	500.320	523.953	0.472329
Sum256Base	57.753	4539.017	4.091799
Sum256Traits	57.679	4544.841	4.097049
Sum512Bcl	31.567	8304.459	7.486241
Sum512Base	31.639	8285.512	7.469160
Sum512Traits	31.443	8337.220	7.515774

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
SumScalar	231.657	1131.605
SumBcl	28.851	9086.154	8.029440
SumBase	28.885	9075.376	8.019915
SumBase_Basic	287.818	910.799	0.804874
SumBase_ClearBit	53.044	4942.036	4.367280
SumTraits	28.767	9112.771	8.052961
Sum128Bcl	57.402	4566.841	4.035720
Sum128Base_Basic	478.417	547.940	0.484215
Sum128Base	57.594	4551.618	4.022268
Sum128Traits	57.365	4569.723	4.038267
Sum256Bcl	28.770	9111.745	8.052055
Sum256Base_Basic	288.491	908.673	0.802995
Sum256Base	28.889	9074.186	8.018863
Sum256Traits	29.105	9006.947	7.959444
Sum512Bcl	16.067	16315.358	14.417891
Sum512Base	16.236	16145.415	14.267713
Sum512Traits	16.512	15876.425	14.030006

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
SumScalar	231.659	1131.593
SumBcl	57.633	4548.496	4.019553
SumBase	57.797	4535.620	4.008175
SumBase_Basic	498.295	526.082	0.464904
SumBase_ClearBit	110.654	2369.041	2.093546
SumTraits	58.184	4505.397	3.981466
Sum128Bcl	115.867	2262.448	1.999349
Sum128Base_Basic	924.379	283.589	0.250611
Sum128Base	115.330	2272.989	2.008664
Sum128Traits	115.536	2268.936	2.005082
Sum256Bcl	57.655	4546.789	4.018044
Sum256Base_Basic	500.872	523.376	0.462512
Sum256Base	57.644	4547.635	4.018792
Sum256Traits	57.569	4553.534	4.024005
Sum512Bcl	32.851	7979.895	7.051916
Sum512Base	32.694	8018.227	7.085790
Sum512Traits	32.833	7984.092	7.055625

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
SumScalar	231.995	1129.957
SumBcl	28.833	9091.753	8.046103
SumBase	28.972	9048.264	8.007616
SumBase_Basic	278.322	941.872	0.833547
SumBase_ClearBit	54.360	4822.350	4.267728
SumTraits	28.916	9065.725	8.023068
Sum128Bcl	57.664	4546.059	4.023212
Sum128Base_Basic	481.131	544.850	0.482186
Sum128Base	57.587	4552.168	4.028619
Sum128Traits	57.938	4524.560	4.004187
Sum256Bcl	28.911	9067.143	8.024323
Sum256Base_Basic	279.135	939.129	0.831119
Sum256Base	28.896	9071.939	8.028567
Sum256Traits	29.090	9011.531	7.975107
Sum512Bcl	16.521	15867.152	14.042258
Sum512Base	16.521	15867.598	14.042652
Sum512Traits	16.382	16001.706	14.161336

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
SumScalar	232.245	1128.740
SumBase	60.828	4309.611	3.818074
SumBase_Add	61.155	4286.585	3.797674
SumTraits	58.101	4511.837	3.997235
Sum128Base_Basic	923.988	283.709	0.251350
Sum128Base	118.534	2211.548	1.959307
Sum128Traits	115.053	2278.463	2.018591
Sum256Base_Basic	500.303	523.970	0.464208
Sum256Base	60.339	4344.511	3.848993
Sum256Traits	57.816	4534.078	4.016939
Sum512Base	57.752	4539.149	4.021432
Sum512Traits	31.618	8290.922	7.345292

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
SumScalar	231.451	1132.610
SumBase	30.535	8584.997	7.579837
SumBase_Add	30.205	8678.937	7.662779
SumTraits	28.808	9099.815	8.034379
Sum128Base_Basic	479.610	546.577	0.482582
Sum128Base	58.759	4461.377	3.939024
Sum128Traits	57.618	4549.707	4.017012
Sum256Base_Basic	269.898	971.270	0.857550
Sum256Base	30.345	8638.818	7.627356
Sum256Traits	28.835	9091.199	8.026772
Sum512Base	29.055	9022.483	7.966101
Sum512Traits	16.024	16359.655	14.444213

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
SumScalar	231.468	1132.529
SumBase	58.029	4517.454	3.988820
SumBase_ClearBit	87.637	2991.254	2.641217
SumBase_ClearBit_Not	91.035	2879.590	2.542620
SumTraits	57.776	4537.231	4.006283
Sum128Base_Basic	923.884	283.741	0.250538
Sum128Base	115.463	2270.376	2.004696
Sum128Traits	114.825	2282.991	2.015835
Sum256Base_Basic	497.079	527.369	0.465656
Sum256Base	58.295	4496.814	3.970596
Sum256Traits	57.746	4539.575	4.008353
Sum512Base	38.804	6755.622	5.965078
Sum512Traits	31.479	8327.462	7.352981

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
SumScalar	230.005	1139.733
SumBase	29.187	8981.666	7.880502
SumBase_ClearBit	44.379	5906.898	5.182704
SumTraits	28.905	9069.115	7.957229
Sum128Base_Basic	479.905	546.241	0.479271
Sum128Base	58.029	4517.488	3.963638
Sum128Traits	57.434	4564.285	4.004698
Sum256Base_Basic	267.461	980.121	0.859957
Sum256Base	28.821	9095.594	7.980463
Sum256Traits	28.804	9100.825	7.985052
Sum512Base	19.958	13134.648	11.524323
Sum512Traits	15.945	16440.354	14.424745

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

