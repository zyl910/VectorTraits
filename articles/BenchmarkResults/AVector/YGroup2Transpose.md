# Benchmark - YGroup2Transpose
([← Back](README.md))

See [Group](YGroup2Transpose_Group.md)

- `YGroup2Transpose`: Transpose a 2*2 matrix (对2*2矩阵进行转置).
  Mnemonic: `result0[i] := (0==(i&1))?( x[i&~1] ):( y[i&~1] )`, `result1[i] := (0==(i&1))?( x[(i&~1) + 1] ):( y[(i&~1) + 1] )`.

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	181.880	1441.302
SumBase_ShiftByMul	30.933	8474.611	5.879829
SumBase	31.101	8428.903	5.848116
SumTraits	30.121	8703.029	6.038309

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	245.468	1067.937
SumBase_ShiftByMul	49.738	5270.541	4.935255
SumBase	48.411	5414.970	5.070496
SumTraits	49.579	5287.450	4.951088

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
SumBase_Basic	381.770	686.654
SumBase_ShiftByMul	271.608	965.156	1.405593
SumBase	378.347	692.867	1.009048
SumTraits	381.611	686.941	1.000418

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	663.608	395.028
SumBase	654.926	400.265	1.013257
SumTraits	654.973	400.236	1.013184

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	190.917	1373.075
SumBase_ShiftByMul	62.429	4199.055	3.058140
SumBase	33.204	7895.027	5.749888
SumTraits	31.791	8245.866	6.005402

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	238.259	1100.250
SumBase_ShiftByMul	120.098	2182.759	1.983875
SumBase	51.756	5064.974	4.603476
SumTraits	50.522	5188.689	4.715918

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
SumBase_Basic	387.801	675.976
SumBase_ShiftByMul	441.338	593.976	0.878693
SumBase	385.987	679.152	1.004699
SumTraits	388.597	674.592	0.997952

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	669.084	391.795
SumBase	684.803	382.802	0.977047
SumTraits	673.999	388.938	0.992708

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	184.921	1417.602
SumBase_ShiftByMul	27.612	9493.831	6.697107
SumBase	27.044	9693.378	6.837871
SumTraits	9.569	27394.422	19.324484
Sum128Base_Basic	560.804	467.443	0.329742
Sum128Base	555.538	471.874	0.332868
Sum128Sse_Shift	18.765	13970.084	9.854731
Sum128Sse_Shuffle	25.445	10302.426	7.267504
Sum128Sse_ShuffleXImm	19.691	13313.028	9.391233
Sum128Sse_Unpack	18.997	13799.266	9.734233
Sum128Traits	17.222	15221.510	10.737508
Sum256Base_Basic	441.308	594.016	0.419029
Sum256Base	445.657	588.219	0.414940
Sum256Avx2_Shift	8.264	31721.948	22.377194
Sum256Avx2_Shuffle	13.398	19566.632	13.802630
Sum256Avx2_ShuffleXImm	9.777	26811.564	18.913327
Sum256Avx2_Unpack	9.314	28146.623	19.855099
Sum256Traits	8.406	31186.379	21.999394

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	229.664	1141.423
SumBase_ShiftByMul	45.989	5700.205	4.993947
SumBase	44.843	5845.755	5.121463
SumTraits	11.641	22518.090	19.728087
Sum128Base_Basic	902.352	290.512	0.254517
Sum128Base	913.718	286.898	0.251351
Sum128Sse_Shift	35.998	7282.159	6.379896
Sum128Sse_Shuffle	53.848	4868.215	4.265041
Sum128Sse_ShuffleXImm	22.492	11654.850	10.210808
Sum128Sse_Unpack	30.018	8732.909	7.650897
Sum128Traits	23.493	11158.214	9.775706
Sum256Base_Basic	651.473	402.386	0.352530
Sum256Base	649.531	403.590	0.353585
Sum256Avx2_Shift	16.682	15714.290	13.767281
Sum256Avx2_Shuffle	26.272	9977.978	8.741702
Sum256Avx2_ShuffleXImm	11.406	22983.748	20.136050
Sum256Avx2_Unpack	15.198	17248.222	15.111158
Sum256Traits	11.336	23125.151	20.259933

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	344.146	761.723
SumBase_ShiftByMul	269.651	972.161	1.276266
SumBase	340.023	770.960	1.012127
SumTraits	24.643	10637.484	13.965035
Sum128Base_Basic	1541.624	170.044	0.223236
Sum128Base	1517.720	172.722	0.226752
Sum128Sse_Shift	72.031	3639.344	4.777781
Sum128Sse_Shuffle	104.618	2505.720	3.289544
Sum128Sse_ShuffleXImm	45.135	5807.998	7.624820
Sum128Sse_Unpack	46.056	5691.822	7.472302
Sum128Traits	42.017	6238.989	8.190631
Sum256Base_Basic	988.729	265.132	0.348069
Sum256Base	912.543	287.267	0.377129
Sum256Avx2_Shift	36.383	7205.144	9.459013
Sum256Avx2_Shuffle	58.426	4486.803	5.890336
Sum256Avx2_ShuffleXImm	23.506	11152.278	14.640865
Sum256Avx2_Unpack	22.517	11641.980	15.283751
Sum256Traits	23.253	11273.651	14.800205

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	602.842	434.847
SumBase	601.989	435.463	1.001417
SumTraits	36.511	7179.881	16.511281
Sum128Base_Basic	2826.370	92.749	0.213292
Sum128Base_Move	3246.863	80.738	0.185669
Sum128Base	2806.293	93.413	0.214818
Sum128Sse_Shuffle	210.702	1244.145	2.861109
Sum128Sse_ShuffleXImm	63.642	4119.010	9.472319
Sum128Sse_Unpack	64.027	4094.288	9.415466
Sum128Traits	62.757	4177.127	9.605968
Sum256Base_Basic	1810.463	144.794	0.332977
Sum256Base	1604.768	163.353	0.375657
Sum256Avx2_Shuffle	102.946	2546.429	5.855918
Sum256Avx2_ShuffleXImm	33.151	7907.564	18.184701
Sum256Avx2_Unpack	36.188	7243.872	16.658438
Sum256Traits	34.791	7534.895	17.327690

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	189.921	1380.282
SumBase_ShiftByMul	23.349	11227.262	8.134034
SumBase	23.523	11144.113	8.073794
SumTraits	6.817	38455.627	27.860700
Sum128Base_Basic	560.770	467.472	0.338678
Sum128Base	566.026	463.131	0.335534
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shift	12.988	20183.828	14.622973
Sum128Sse_Shuffle	18.188	14413.063	10.442113
Sum128Sse_ShuffleXImm	19.552	13407.321	9.713464
Sum128Sse_Unpack	18.032	14537.709	10.532418
Sum128Traits	12.727	20597.994	14.923031
Sum256Base_Basic	533.959	490.944	0.355684
Sum256Base	500.724	523.530	0.379292
Sum256Avx2_Shift	6.765	38748.703	28.073031
Sum256Avx2_Shuffle	9.656	27149.089	19.669231
Sum256Avx2_ShuffleXImm	9.749	26889.428	19.481110
Sum256Avx2_Unpack	9.262	28303.023	20.505245
Sum256Traits	6.517	40224.465	29.142205

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	242.895	1079.248
SumBase_ShiftByMul	42.709	6137.886	5.687188
SumBase	43.204	6067.628	5.622088
SumTraits	11.549	22699.253	21.032472
Sum128Base_Basic	936.467	279.929	0.259374
Sum128Base	931.715	281.356	0.260697
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shift	26.778	9789.487	9.070656
Sum128Sse_Shuffle	37.964	6905.152	6.398114
Sum128Sse_ShuffleXImm	22.558	11620.795	10.767493
Sum128Sse_Unpack	29.378	8923.009	8.267802
Sum128Traits	21.810	12019.639	11.137050
Sum256Base_Basic	875.602	299.387	0.277403
Sum256Base	791.916	331.025	0.306718
Sum256Avx2_Shift	13.323	19675.733	18.230966
Sum256Avx2_Shuffle	19.544	13412.948	12.428050
Sum256Avx2_ShuffleXImm	11.081	23657.104	21.919988
Sum256Avx2_Unpack	15.307	17126.294	15.868729
Sum256Traits	11.262	23276.756	21.567569

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	380.727	688.536
SumBase_ShiftByMul	273.494	958.500	1.392084
SumBase	389.656	672.758	0.977085
SumTraits	23.385	11209.907	16.280786
Sum128Base_Basic	1533.128	170.986	0.248333
Sum128Base	1534.326	170.853	0.248139
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shift	51.945	5046.597	7.329460
Sum128Sse_Shuffle	78.729	3329.717	4.835938
Sum128Sse_ShuffleXImm	43.410	6038.754	8.770425
Sum128Sse_Unpack	45.824	5720.625	8.308388
Sum128Traits	41.528	6312.395	9.167851
Sum256Base_Basic	1411.759	185.686	0.269682
Sum256Base	1287.903	203.543	0.295617
Sum256Avx2_Shift	28.651	9149.492	13.288327
Sum256Avx2_Shuffle	39.993	6554.810	9.519923
Sum256Avx2_ShuffleXImm	23.221	11289.191	16.395933
Sum256Avx2_Unpack	23.385	11210.155	16.281145
Sum256Traits	22.879	11457.623	16.640558

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	673.172	389.416
SumBase	677.746	386.788	0.993252
SumTraits	34.365	7628.245	19.588935
Sum128Base_Basic	2822.655	92.871	0.238489
Sum128Base_Move	3259.652	80.421	0.206517
Sum128Base	2804.003	93.489	0.240075
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	151.574	1729.481	4.441216
Sum128Sse_ShuffleXImm	67.959	3857.377	9.905544
Sum128Sse_Unpack	67.028	3910.977	10.043184
Sum128Traits	90.610	2893.098	7.429326
Sum256Base_Basic	2624.393	99.887	0.256506
Sum256Base	2394.604	109.473	0.281120
Sum256Avx2_Shuffle	74.790	3505.087	9.000880
Sum256Avx2_ShuffleXImm	33.846	7745.265	19.889437
Sum256Avx2_Unpack	35.582	7367.321	18.918896
Sum256Traits	33.622	7796.693	20.021501

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	187.295	1399.632
SumBase_ShiftByMul	23.452	11177.763	7.986214
SumBase	23.511	11149.732	7.966186
SumTraits	6.661	39356.226	28.118976
Sum128Base_Basic	558.825	469.098	0.335158
Sum128Base	556.816	470.791	0.336367
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shift	13.329	19667.740	14.052076
Sum128Sse_Shuffle	18.551	14131.058	10.096264
Sum128Sse_ShuffleXImm	19.608	13369.118	9.551879
Sum128Sse_Unpack	18.882	13883.004	9.919036
Sum128Traits	12.839	20417.316	14.587629
Sum256Base_Basic	443.370	591.254	0.422435
Sum256Base	445.742	588.107	0.420187
Sum256Avx2_Shift	6.631	39535.056	28.246745
Sum256Avx2_Shuffle	9.987	26249.757	18.754752
Sum256Avx2_ShuffleXImm	9.829	26671.605	19.056152
Sum256Avx2_Unpack	9.273	28270.208	20.198310
Sum256Traits	6.742	38880.264	27.778913

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	222.622	1177.530
SumBase_ShiftByMul	43.734	5994.017	5.090329
SumBase	42.735	6134.151	5.209336
SumTraits	11.215	23374.006	19.850025
Sum128Base_Basic	908.367	288.588	0.245079
Sum128Base	908.717	288.477	0.244985
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shift	26.567	9867.260	8.379623
Sum128Sse_Shuffle	38.656	6781.425	5.759023
Sum128Sse_ShuffleXImm	22.972	11411.385	9.690948
Sum128Sse_Unpack	29.607	8854.057	7.519176
Sum128Traits	23.346	11228.669	9.535779
Sum256Base_Basic	645.287	406.244	0.344997
Sum256Base	660.004	397.185	0.337304
Sum256Avx2_Shift	13.639	19219.787	16.322117
Sum256Avx2_Shuffle	20.044	13078.338	11.106583
Sum256Avx2_ShuffleXImm	11.165	23479.687	19.939773
Sum256Avx2_Unpack	14.836	17669.918	15.005914
Sum256Traits	11.419	22957.086	19.495962

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	342.768	764.784
SumBase_ShiftByMul	271.270	966.360	1.263571
SumBase	343.945	762.168	0.996579
SumTraits	22.576	11611.570	15.182802
Sum128Base_Basic	1520.487	172.408	0.225433
Sum128Base	1522.807	172.145	0.225090
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shift	52.848	4960.324	6.485911
Sum128Sse_Shuffle	78.555	3337.062	4.363403
Sum128Sse_ShuffleXImm	44.182	5933.314	7.758152
Sum128Sse_Unpack	46.995	5578.087	7.293673
Sum128Traits	45.871	5714.850	7.472498
Sum256Base_Basic	914.032	286.800	0.375007
Sum256Base	912.493	287.283	0.375640
Sum256Avx2_Shift	27.415	9562.074	12.502966
Sum256Avx2_Shuffle	41.533	6311.726	8.252947
Sum256Avx2_ShuffleXImm	22.415	11694.822	15.291658
Sum256Avx2_Unpack	23.480	11164.635	14.598408
Sum256Traits	23.189	11304.557	14.781364

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	593.441	441.736
SumBase	594.324	441.080	0.998515
SumTraits	33.734	7770.801	17.591520
Sum128Base_Basic	2818.007	93.025	0.210589
Sum128Base_Move	3262.220	80.358	0.181913
Sum128Base	2820.107	92.955	0.210432
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	154.039	1701.800	3.852530
Sum128Sse_ShuffleXImm	61.991	4228.732	9.572993
Sum128Sse_Unpack	64.733	4049.626	9.167533
Sum128Traits	66.042	3969.378	8.985868
Sum256Base_Basic	1615.792	162.239	0.367276
Sum256Base	1605.480	163.281	0.369635
Sum256Avx2_Shuffle	77.410	3386.457	7.666253
Sum256Avx2_ShuffleXImm	35.191	7449.184	16.863445
Sum256Avx2_Unpack	34.882	7515.070	17.012598
Sum256Traits	35.050	7479.196	16.931386

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	196.980	1330.814
SumBase_Shift	7.055	37155.325	27.919244
SumBase_ShiftByMul	19.215	13642.917	10.251557
SumBase	7.104	36901.097	27.728213
SumTraits	7.013	37378.897	28.087241
Sum128Base_Basic	225.474	1162.633	0.873626
Sum128Base_Shift	14.047	18662.427	14.023316
Sum128Base_Shuffle	953.678	274.877	0.206548
Sum128Base	13.358	19625.135	14.746714
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shift	13.897	18863.977	14.174765
Sum128Sse_Shuffle	15.973	16411.431	12.331873
Sum128Sse_ShuffleXImm	19.943	13144.409	9.876969
Sum128Sse_Unpack	19.254	13615.353	10.230845
Sum128Traits	13.758	19054.344	14.317810
Sum256Base_Basic	193.965	1351.502	1.015545
Sum256Base_Shift	6.821	38432.651	28.879053
Sum256Base_Shuffle	846.848	309.553	0.232604
Sum256Base	6.688	39193.919	29.451084
Sum256Avx2_Shift	6.804	38526.091	28.949265
Sum256Avx2_Shuffle	9.689	27054.776	20.329493
Sum256Avx2_ShuffleXImm	9.829	26671.291	20.041334
Sum256Avx2_Unpack	9.525	27520.772	20.679651
Sum256Traits	6.845	38296.407	28.776676

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	245.437	1068.071
SumBase_Shift	13.917	18836.299	17.635811
SumBase_ShiftByMul	26.148	10025.228	9.386293
SumBase	13.735	19086.052	17.869646
SumTraits	11.307	23184.277	21.706680
Sum128Base_Basic	318.792	822.303	0.769896
Sum128Base_Shift	28.725	9125.848	8.544233
Sum128Base_Shuffle	1876.847	139.673	0.130771
Sum128Base	27.528	9522.829	8.915913
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shift	28.211	9292.319	8.700095
Sum128Sse_Shuffle	31.389	8351.413	7.819154
Sum128Sse_ShuffleXImm	22.271	11770.778	11.020594
Sum128Sse_Unpack	30.593	8568.649	8.022546
Sum128Traits	22.846	11474.512	10.743210
Sum256Base_Basic	246.963	1061.470	0.993820
Sum256Base_Shift	14.027	18689.176	17.498064
Sum256Base_Shuffle	1716.102	152.755	0.143020
Sum256Base	13.740	19078.670	17.862734
Sum256Avx2_Shift	13.382	19588.936	18.340480
Sum256Avx2_Shuffle	19.836	13215.429	12.373174
Sum256Avx2_ShuffleXImm	11.613	22574.068	21.135361
Sum256Avx2_Unpack	15.576	16830.173	15.757540
Sum256Traits	11.673	22457.159	21.025903

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
SumBase_Basic	392.314	668.199
SumBase_Shift	29.538	8874.686	13.281508
SumBase_ShiftByMul	280.311	935.189	1.399568
SumBase	28.979	9045.898	13.537737
SumTraits	23.986	10928.948	16.355836
Sum128Base_Basic	549.317	477.218	0.714186
Sum128Base_Shift	54.753	4787.752	7.165163
Sum128Base_Shuffle	3823.755	68.557	0.102599
Sum128Base	55.730	4703.784	7.039500
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shift	55.428	4729.456	7.077919
Sum128Sse_Shuffle	73.790	3552.559	5.316620
Sum128Sse_ShuffleXImm	45.296	5787.299	8.661045
Sum128Sse_Unpack	48.321	5425.090	8.118978
Sum128Traits	45.924	5708.247	8.542739
Sum256Base_Basic	393.110	666.846	0.997975
Sum256Base_Shift	29.943	8754.774	13.102052
Sum256Base_Shuffle	3429.727	76.433	0.114387
Sum256Base	30.762	8521.597	12.753089
Sum256Avx2_Shift	29.827	8788.961	13.153215
Sum256Avx2_Shuffle	38.790	6757.990	10.113744
Sum256Avx2_ShuffleXImm	23.675	11072.780	16.571090
Sum256Avx2_Unpack	24.222	10822.715	16.196851
Sum256Traits	23.665	11077.138	16.577612

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
SumBase_Basic	672.648	389.720
SumBase	668.884	391.912	1.005627
SumTraits	34.307	7641.226	19.606981
Sum128Base_Basic	970.425	270.133	0.693147
Sum128Base_Move	1708.317	153.452	0.393749
Sum128Base_Shuffle	8272.743	31.688	0.081309
Sum128Base	1703.334	153.901	0.394901
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	146.673	1787.274	4.586049
Sum128Sse_ShuffleXImm	66.036	3969.725	10.186103
Sum128Sse_Unpack	64.378	4071.961	10.448435
Sum128Traits	73.638	3559.901	9.134517
Sum256Base_Basic	669.351	391.639	1.004925
Sum256Base_Shuffle	7506.062	34.924	0.089614
Sum256Base	662.972	395.408	1.014595
Sum256Avx2_Shuffle	75.903	3453.686	8.861974
Sum256Avx2_ShuffleXImm	38.022	6894.503	17.690928
Sum256Avx2_Unpack	36.612	7159.992	18.372161
Sum256Traits	36.713	7140.319	18.321680

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	192.499	1361.794
SumBase_Shift	6.851	38262.719	28.097279
SumBase_ShiftByMul	17.858	14679.149	10.779269
SumBase	6.720	39010.284	28.646234
SumTraits	5.450	48098.762	35.320132
Sum128Base_Basic	226.595	1156.885	0.849530
Sum128Base_Shift	13.532	19372.725	14.225880
Sum128Base_Shuffle	943.578	277.819	0.204010
Sum128Base	14.267	18374.476	13.492840
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shift	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shift	14.064	18639.392	13.687375
Sum128Sse_Shuffle	15.212	17233.052	12.654664
Sum128Sse_ShuffleX	9.672	27102.285	19.901890
Sum128Sse_ShuffleXImm	19.903	13171.379	9.672076
Sum128Sse_Unpack	19.032	13774.146	10.114702
Sum128Traits	9.790	26775.661	19.662042
Sum256Base_Basic	196.697	1332.730	0.978657
Sum256Base_Shift	6.606	39684.337	29.141208
Sum256Base_Shuffle	1015.517	258.138	0.189558
Sum256Base	6.883	38085.830	27.967384
Sum256Avx2_Shift	6.880	38101.763	27.979085
Sum256Avx2_Shuffle	8.062	32517.279	23.878257
Sum256Avx2_ShuffleX	5.208	50338.633	36.964926
Sum256Avx2_ShuffleXImm	10.630	24661.834	18.109806
Sum256Avx2_Unpack	10.475	25026.818	18.377823
Sum256Traits	5.733	45721.618	33.574536
Sum512Base_Basic	182.853	1433.632	1.052752
Sum512Base_Shift	5.403	48515.893	35.626442
Sum512Base_Shuffle	975.994	268.592	0.197234
Sum512Base	5.144	50963.073	37.423468
Sum512Avx512_Shift	5.033	52089.390	38.250551
Sum512Avx512_Shuffle	7.284	35990.248	26.428545
Sum512Avx512_ShuffleX	3.739	70120.064	51.490929
Sum512Avx512_ShuffleXImm	8.779	29861.591	21.928119
Sum512Avx512_Unpack	9.270	28278.590	20.765681
Sum512Traits	3.855	67996.564	49.931590

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	-24614
SumBase_Basic	241.760	1084.313
SumBase_Shift	13.768	19040.668	17.560119
SumBase_ShiftByMul	24.434	10728.752	9.894514
SumBase	14.008	18714.113	17.258956
SumTraits	9.730	26941.241	24.846366
Sum128Base_Basic	321.155	816.253	0.752784
Sum128Base_Shift	26.147	10025.922	9.246334
Sum128Base_Shuffle	1818.991	144.115	0.132909
Sum128Base	26.709	9814.710	9.051545
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shift	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shift	26.295	9969.224	9.194045
Sum128Sse_Shuffle	30.727	8531.394	7.868017
Sum128Sse_ShuffleX	19.176	13670.158	12.607205
Sum128Sse_ShuffleXImm	21.692	12085.037	11.145338
Sum128Sse_Unpack	28.909	9067.771	8.362687
Sum128Traits	17.814	14715.764	13.571507
Sum256Base_Basic	238.454	1099.348	1.013866
Sum256Base_Shift	13.717	19110.914	17.624902
Sum256Base_Shuffle	1673.062	156.685	0.144502
Sum256Base	13.419	19534.603	18.015647
Sum256Avx2_Shift	13.850	18927.024	17.455312
Sum256Avx2_Shuffle	16.346	16037.189	14.790183
Sum256Avx2_ShuffleX	10.090	25981.645	23.961385
Sum256Avx2_ShuffleXImm	11.237	23329.431	21.515400
Sum256Avx2_Unpack	14.606	17947.498	16.551951
Sum256Traits	9.671	27107.054	24.999286
Sum512Base_Basic	195.625	1340.036	1.235839
Sum512Base_Shift	10.319	25404.622	23.429230
Sum512Base_Shuffle	1969.458	133.105	0.122755
Sum512Base	10.297	25459.478	23.479820
Sum512Avx512_Shift	10.259	25553.372	23.566413
Sum512Avx512_Shuffle	15.704	16693.189	15.395174
Sum512Avx512_ShuffleX	7.262	36099.104	33.292139
Sum512Avx512_ShuffleXImm	9.389	27919.269	25.748345
Sum512Avx512_Unpack	13.649	19205.735	17.712351
Sum512Traits	7.234	36236.553	33.418900

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-468672550
# Sum512Base_Basic	-468213798
SumBase_Basic	379.306	691.115
SumBase_Shift	27.875	9404.298	13.607437
SumBase_ShiftByMul	274.637	954.510	1.381116
SumBase	27.728	9454.060	13.679439
SumTraits	20.374	12866.286	18.616719
Sum128Base_Basic	550.856	475.885	0.688576
Sum128Base_Shift	51.201	5119.904	7.408185
Sum128Base_Shuffle	3614.286	72.530	0.104946
Sum128Base	52.300	5012.278	7.252456
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shift	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shift	52.309	5011.418	7.251211
Sum128Sse_Shuffle	60.859	4307.408	6.232552
Sum128Sse_ShuffleX	36.652	7152.264	10.348883
Sum128Sse_ShuffleXImm	43.361	6045.618	8.747635
Sum128Sse_Unpack	43.180	6070.926	8.784254
Sum128Traits	38.510	6807.102	9.849455
Sum256Base_Basic	379.085	691.518	1.000583
Sum256Base_Shift	28.797	9103.098	13.171620
Sum256Base_Shuffle	3404.876	76.991	0.111401
Sum256Base	27.391	9570.426	13.847814
Sum256Avx2_Shift	27.959	9375.981	13.566464
Sum256Avx2_Shuffle	33.921	7727.964	11.181885
Sum256Avx2_ShuffleX	20.746	12635.989	18.283495
Sum256Avx2_ShuffleXImm	22.528	11636.384	16.837128
Sum256Avx2_Unpack	22.927	11433.758	16.543940
Sum256Traits	20.707	12659.967	18.318189
Sum512Base_Basic	286.440	915.180	1.324208
Sum512Base_Shift	21.089	12430.099	17.985585
Sum512Base_Shuffle	3591.991	72.980	0.105598
Sum512Base	21.073	12439.970	17.999867
Sum512Avx512_Shift	21.200	12365.036	17.891443
Sum512Avx512_Shuffle	31.650	8282.516	11.984289
Sum512Avx512_ShuffleX	15.912	16475.017	23.838331
Sum512Avx512_ShuffleXImm	18.666	14043.646	20.320287
Sum512Avx512_Unpack	19.453	13475.853	19.498726
Sum512Traits	15.652	16748.758	24.234417

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571615236
# Sum512Base_Basic	5910372263571811844
SumBase_Basic	659.280	397.622
SumBase	657.287	398.827	1.003032
SumTraits	32.869	7975.323	20.057564
Sum128Base_Basic	965.041	271.640	0.683162
Sum128Base_Move	939.463	279.036	0.701763
Sum128Base_Shuffle	7453.719	35.170	0.088450
Sum128Base	941.635	278.392	0.700144
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	124.920	2098.488	5.277598
Sum128Sse_ShuffleX	73.756	3554.219	8.938695
Sum128Sse_ShuffleXImm	63.971	4097.879	10.305974
Sum128Sse_Unpack	63.349	4138.089	10.407101
Sum128Traits	64.749	4048.649	10.182163
Sum256Base_Basic	655.702	399.791	1.005456
Sum256Base_Shuffle	8131.135	32.240	0.081081
Sum256Base	662.777	395.524	0.994723
Sum256Avx2_Shuffle	64.316	4075.881	10.250650
Sum256Avx2_ShuffleX	38.489	6810.950	17.129220
Sum256Avx2_ShuffleXImm	33.193	7897.670	19.862270
Sum256Avx2_Unpack	33.369	7856.013	19.757505
Sum256Traits	33.770	7762.624	19.522636
Sum512Base_Basic	467.141	561.166	1.411307
Sum512Base_Shuffle	7265.229	36.082	0.090745
Sum512Avx512_Shuffle	62.614	4186.646	10.529218
Sum512Avx512_ShuffleX	29.688	8829.946	22.206901
Sum512Avx512_ShuffleXImm	28.702	9133.388	22.970042
Sum512Avx512_Unpack	28.987	9043.362	22.743631
Sum512Traits	28.180	9302.326	23.394914

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	106.512	2461.178
SumBase_ShiftByMul	23.828	11001.569	4.470041
SumBase	23.829	11000.927	4.469780
SumTraits	9.636	27204.165	11.053308
Sum128Base_Basic	268.920	974.803	0.396072
Sum128Base	268.715	975.545	0.396373
Sum128AdvSimd_Shift	9.672	27104.651	11.012875
Sum128AdvSimd_Shuffle	24.383	10751.218	4.368321
Sum128AdvSimdB64	9.633	27213.746	11.057201
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.632	27215.292	11.057829
Sum256Base_Basic	256.151	1023.397	0.415816
Sum256Base	262.904	997.107	0.405134
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	262.530	998.531	0.405712

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	117.748	2226.313
SumBase_ShiftByMul	33.829	7749.020	3.480651
SumBase	33.822	7750.723	3.481416
SumTraits	19.268	13605.242	6.111108
Sum128Base_Basic	321.126	816.329	0.366673
Sum128Base	319.626	820.157	0.368393
Sum128AdvSimd_Shift	19.303	13580.446	6.099971
Sum128AdvSimd_Shuffle	48.736	5378.852	2.416036
Sum128AdvSimdB64	19.277	13599.072	6.108337
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.269	13604.684	6.110858
Sum256Base_Basic	341.059	768.618	0.345243
Sum256Base	341.142	768.430	0.345158
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	341.044	768.651	0.345257

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	145.595	1800.507
SumBase_ShiftByMul	113.237	2314.998	1.285747
SumBase	145.553	1801.026	1.000288
SumTraits	38.536	6802.625	3.778171
Sum128Base_Basic	406.637	644.664	0.358046
Sum128Base	406.179	645.390	0.358449
Sum128AdvSimd_Shift	38.578	6795.208	3.774052
Sum128AdvSimd_Shuffle	97.455	2689.890	1.493962
Sum128AdvSimdB64	38.541	6801.708	3.777662
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.535	6802.761	3.778246
Sum256Base_Basic	494.542	530.074	0.294403
Sum256Base	493.327	531.380	0.295128
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	494.928	529.661	0.294173

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	199.332	1315.112
SumBase	199.508	1313.956	0.999120
SumTraits	77.074	3401.200	2.586243
Sum128Base_Basic	672.061	390.060	0.296598
Sum128Base_Move	576.701	454.558	0.345642
Sum128Base	671.578	390.340	0.296811
Sum128AdvSimd_AlignRight	77.088	3400.579	2.585771
Sum128AdvSimd_Shuffle	194.923	1344.860	1.022620
Sum128AdvSimdB64	77.063	3401.672	2.586602
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.083	3400.783	2.585926
Sum256Base_Basic	759.122	345.325	0.262582
Sum256Base	759.020	345.372	0.262618
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	758.881	345.435	0.262666

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	106.610	2458.904
SumBase_Shift	9.650	27165.424	11.047776
SumBase_ShiftByMul	22.325	11742.220	4.775387
SumBase	9.651	27161.862	11.046327
SumTraits	9.630	27220.518	11.070182
Sum128Base_Basic	106.581	2459.565	1.000269
Sum128Base_Shift	9.657	27145.381	11.039625
Sum128Base_Shuffle	793.432	330.392	0.134366
Sum128Base	9.658	27142.831	11.038588
Sum128AdvSimd_Shift	9.659	27139.730	11.037327
Sum128AdvSimd_Shuffle	24.373	10755.464	4.374088
Sum128AdvSimdB64	9.630	27221.482	11.070574
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.629	27223.667	11.071463
Sum256Base_Basic	345.877	757.911	0.308231
Sum256Base_Shift	474.358	552.629	0.224746
Sum256Base_Shuffle	1472.625	178.011	0.072395
Sum256Base	360.933	726.296	0.295374
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	360.939	726.284	0.295369

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	117.649	2228.193
SumBase_Shift	19.278	13598.427	6.102893
SumBase_ShiftByMul	26.524	9883.169	4.435508
SumBase	19.277	13598.763	6.103044
SumTraits	19.262	13609.477	6.107853
Sum128Base_Basic	117.694	2227.333	0.999614
Sum128Base_Shift	19.349	13548.513	6.080492
Sum128Base_Shuffle	1804.115	145.303	0.065211
Sum128Base	19.295	13585.946	6.097292
Sum128AdvSimd_Shift	19.297	13584.619	6.096697
Sum128AdvSimd_Shuffle	48.711	5381.586	2.415224
Sum128AdvSimdB64	19.267	13605.659	6.106139
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.265	13606.980	6.106732
Sum256Base_Basic	460.501	569.259	0.255480
Sum256Base_Shift	715.705	366.274	0.164382
Sum256Base_Shuffle	2956.847	88.657	0.039789
Sum256Base	460.829	568.853	0.255298
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	460.516	569.240	0.255471

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
Check-Sum128Base_Shift	Check `Sum128Base_Shift` mismatch. -833942548!=-468148262
Check-Sum128Base	Check `Sum128Base` mismatch. -833942548!=-468148262
Check-Sum128AdvSimd_Shift	Check `Sum128AdvSimd_Shift` mismatch. -833942548!=-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	145.372	1803.269
SumBase_Shift	38.548	6800.516	3.771216
SumBase_ShiftByMul	103.579	2530.852	1.403480
SumBase	38.544	6801.109	3.771544
SumTraits	38.518	6805.713	3.774098
Sum128Base_Basic	145.473	1802.007	0.999300
Sum128Base_Shift	38.562	6797.973	3.769805
Sum128Base_Shuffle	3478.954	75.351	0.041786
Sum128Base	38.565	6797.431	3.769505
Sum128AdvSimd_Shift	38.565	6797.408	3.769492
Sum128AdvSimd_Shuffle	97.402	2691.355	1.492487
Sum128AdvSimdB64	38.534	6803.010	3.772598
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.536	6802.570	3.772354
Sum256Base_Basic	658.854	397.879	0.220643
Sum256Base_Shift	1173.882	223.314	0.123838
Sum256Base_Shuffle	5879.766	44.584	0.024724
Sum256Base	664.045	394.769	0.218918
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	663.918	394.844	0.218960

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	199.420	1314.531
SumBase	199.416	1314.559	1.000021
SumTraits	77.077	3401.077	2.587293
Sum128Base_Basic	199.249	1315.664	1.000861
Sum128Base_Move	77.098	3400.162	2.586596
Sum128Base_Shuffle	6473.247	40.497	0.030807
Sum128Base	77.100	3400.032	2.586497
Sum128AdvSimd_AlignRight	77.088	3400.571	2.586908
Sum128AdvSimd_Shuffle	194.772	1345.902	1.023865
Sum128AdvSimdB64	77.067	3401.493	2.587609
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.085	3400.729	2.587028
Sum256Base_Basic	1016.640	257.853	0.196156
Sum256Base_Shuffle	10541.249	24.868	0.018918
Sum256Base	1017.750	257.572	0.195942
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1017.614	257.606	0.195968

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	106.158	2469.367
SumBase_Shift	9.654	27153.733	10.996234
SumBase_ShiftByMul	19.652	13339.615	5.402039
SumBase	9.652	27158.974	10.998357
SumTraits	9.648	27170.146	11.002881
Sum128Base_Basic	106.154	2469.467	1.000041
Sum128Base_Shift	9.654	27153.784	10.996255
Sum128Base_Shuffle	793.201	330.489	0.133835
Sum128Base	9.654	27153.139	10.995994
Sum128AdvSimd_Shift	9.652	27160.417	10.998941
Sum128AdvSimd_Shuffle	24.369	10757.417	4.356347
Sum128AdvSimd_ShuffleX	13.876	18892.350	7.650687
Sum128AdvSimdB64	9.626	27231.946	11.027908
Sum128PackedSimd_Shift	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.625	27234.776	11.029054
Sum256Base_Basic	94.001	2788.745	1.129336
Sum256Base_Shift	6.242	41998.174	17.007671
Sum256Base_Shuffle	782.390	335.056	0.135685
Sum256Base	94.263	2780.995	1.126198
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	94.263	2780.990	1.126196
Sum512Base_Basic	91.580	2862.453	1.159185
Sum512Base_Shift	5.463	47986.257	19.432618
Sum512Base_Shuffle	1071.354	244.685	0.099088
Sum512Base	91.603	2861.747	1.158899
Sum512Avx512_Shift	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	91.597	2861.939	1.158977

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	116.635	2247.551
SumBase_Shift	19.297	13584.430	6.044104
SumBase_ShiftByMul	23.056	11369.988	5.058835
SumBase	19.288	13591.099	6.047072
SumTraits	19.255	13614.084	6.057298
Sum128Base_Basic	116.691	2246.473	0.999520
Sum128Base_Shift	19.290	13589.474	6.046348
Sum128Base_Shuffle	1800.141	145.624	0.064792
Sum128Base	19.291	13589.010	6.046142
Sum128AdvSimd_Shift	19.292	13587.903	6.045649
Sum128AdvSimd_Shuffle	48.721	5380.546	2.393960
Sum128AdvSimd_ShuffleX	27.724	9455.404	4.206982
Sum128AdvSimdB64	19.261	13609.829	6.055405
Sum128PackedSimd_Shift	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.262	13609.635	6.055319
Sum256Base_Basic	110.978	2362.116	1.050973
Sum256Base_Shift	12.955	20235.683	9.003438
Sum256Base_Shuffle	1799.368	145.687	0.064820
Sum256Base	110.955	2362.625	1.051200
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	110.971	2362.269	1.051042
Sum512Base_Basic	114.853	2282.426	1.015517
Sum512Base_Shift	11.305	23187.864	10.316949
Sum512Base_Shuffle	2293.734	114.287	0.050850
Sum512Base	114.885	2281.791	1.015235
Sum512Avx512_Shift	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	114.846	2282.569	1.015581

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
# Sum512Base_Basic	-467853350
SumBase_Basic	145.014	1807.714
SumBase_Shift	38.562	6798.027	3.760566
SumBase_ShiftByMul	101.171	2591.105	1.433360
SumBase	38.567	6797.169	3.760091
SumTraits	38.529	6803.854	3.763789
Sum128Base_Basic	144.954	1808.465	1.000415
Sum128Base_Shift	38.566	6797.316	3.760173
Sum128Base_Shuffle	3461.778	75.725	0.041890
Sum128Base	38.569	6796.693	3.759828
Sum128AdvSimd_Shift	38.574	6795.905	3.759392
Sum128AdvSimd_Shuffle	97.386	2691.816	1.489072
Sum128AdvSimd_ShuffleX	55.433	4729.037	2.616032
Sum128AdvSimdB64	38.532	6803.200	3.763427
Sum128PackedSimd_Shift	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.526	6804.319	3.764047
Sum256Base_Basic	140.524	1865.475	1.031953
Sum256Base_Shift	25.792	10163.700	5.622405
Sum256Base_Shuffle	3588.573	73.050	0.040410
Sum256Base	140.572	1864.833	1.031598
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	140.627	1864.114	1.031200
Sum512Base_Basic	153.386	1709.050	0.945421
Sum512Base_Shift	22.493	11654.494	6.447090
Sum512Base_Shuffle	4869.200	53.837	0.029782
Sum512Base	153.368	1709.251	0.945532
Sum512Avx512_Shift	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	153.348	1709.468	0.945652

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	197.288	1328.741
SumBase	197.669	1326.174	0.998068
SumTraits	77.073	3401.236	2.559744
Sum128Base_Basic	197.662	1326.224	0.998106
Sum128Base_Move	77.069	3401.417	2.559880
Sum128Base_Shuffle	6475.218	40.484	0.030468
Sum128Base	77.055	3402.059	2.560363
Sum128AdvSimd_AlignRight	77.060	3401.812	2.560177
Sum128AdvSimd_Shuffle	194.686	1346.495	1.013362
Sum128AdvSimd_ShuffleX	110.819	2365.506	1.780262
Sum128AdvSimdB64	77.047	3402.379	2.560604
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.070	3401.381	2.559853
Sum256Base_Basic	192.138	1364.356	1.026804
Sum256Base_Shuffle	6358.432	41.228	0.031028
Sum256Base	192.164	1364.171	1.026665
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	192.128	1364.423	1.026854
Sum512Base_Basic	228.325	1148.118	0.864065
Sum512Base_Shuffle	8702.115	30.124	0.022671
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	228.307	1148.210	0.864134

```

### AWS Arm t4g.small
`Neoverse-N1`

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	342.238	765.971
SumBase_ShiftByMul	115.820	2263.365	2.954897
SumBase	115.887	2262.062	2.953197
SumTraits	115.938	2261.075	2.951908
Sum128Base_Basic	848.664	308.890	0.403266
Sum128Base	855.009	306.598	0.400274
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	854.762	306.687	0.400389
Sum256Base_Basic	806.485	325.045	0.424357
Sum256Base	824.369	317.994	0.415151
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	939.746	278.952	0.364181

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	444.486	589.769
SumBase_ShiftByMul	137.632	1904.680	3.229538
SumBase	137.561	1905.657	3.231195
SumTraits	137.641	1904.554	3.229325
Sum128Base_Basic	1295.906	202.286	0.342993
Sum128Base	1296.342	202.218	0.342877
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1294.060	202.575	0.343482
Sum256Base_Basic	1349.783	194.212	0.329302
Sum256Base	1384.601	189.328	0.321021
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1613.572	162.462	0.275467

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	725.979	361.090
SumBase_ShiftByMul	343.816	762.455	2.111536
SumBase	731.316	358.455	0.992702
SumTraits	732.413	357.918	0.991216
Sum128Base_Basic	2153.422	121.734	0.337128
Sum128Base	2224.334	117.853	0.326381
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2164.657	121.102	0.335378
Sum256Base_Basic	2200.667	119.120	0.329891
Sum256Base	2276.937	115.130	0.318840
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2716.558	96.499	0.267242

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	705.866	371.379
SumBase	689.973	379.934	1.023034
SumTraits	689.403	380.248	1.023880
Sum128Base_Basic	1519.369	172.535	0.464578
Sum128Base_Move	1839.464	142.511	0.383735
Sum128Base	1509.416	173.672	0.467642
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1512.254	173.347	0.466764
Sum256Base_Basic	3384.977	77.443	0.208529
Sum256Base	3535.103	74.155	0.199673
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4447.914	58.936	0.158696

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	334.542	783.590
SumBase_ShiftByMul	100.832	2599.811	3.317821
SumBase	97.969	2675.793	3.414787
SumTraits	19.944	13143.803	16.773827
Sum128Base_Basic	847.979	309.140	0.394517
Sum128Base	853.016	307.314	0.392188
Sum128AdvSimd_Shift	30.037	8727.499	11.137839
Sum128AdvSimd_Shuffle	82.619	3172.917	4.049206
Sum128AdvSimdB64	19.845	13209.795	16.858045
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.838	13214.100	16.863539
Sum256Base_Basic	755.256	347.093	0.442952
Sum256Base	773.134	339.067	0.432710
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	773.247	339.017	0.432646

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	459.008	571.110
SumBase_ShiftByMul	115.955	2260.738	3.958500
SumBase	115.833	2263.118	3.962667
SumTraits	37.387	7011.678	12.277288
Sum128Base_Basic	1266.279	207.019	0.362486
Sum128Base	1258.685	208.268	0.364673
Sum128AdvSimd_Shift	62.235	4212.182	7.375434
Sum128AdvSimd_Shuffle	166.755	1572.034	2.752596
Sum128AdvSimdB64	37.343	7019.852	12.291601
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	37.454	6999.152	12.255356
Sum256Base_Basic	989.666	264.881	0.463801
Sum256Base	988.192	265.277	0.464493
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	986.800	265.651	0.465148

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	740.756	353.887
SumBase_ShiftByMul	321.432	815.549	2.304547
SumBase	746.580	351.127	0.992199
SumTraits	75.122	3489.579	9.860713
Sum128Base_Basic	2162.396	121.228	0.342563
Sum128Base	2144.708	122.228	0.345388
Sum128AdvSimd_Shift	124.033	2113.498	5.972238
Sum128AdvSimd_Shuffle	336.098	779.963	2.203990
Sum128AdvSimdB64	74.834	3502.993	9.898616
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	75.369	3478.128	9.828354
Sum256Base_Basic	1493.926	175.473	0.495845
Sum256Base	1496.001	175.230	0.495157
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1493.811	175.487	0.495883

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	695.543	376.891
SumBase	695.758	376.775	0.999691
SumTraits	160.781	1630.443	4.326034
Sum128Base_Basic	1611.833	162.637	0.431523
Sum128Base_Move	1013.827	258.569	0.686057
Sum128Base	1624.894	161.330	0.428055
Sum128AdvSimd_AlignRight	178.176	1471.262	3.903680
Sum128AdvSimd_Shuffle	677.594	386.875	1.026490
Sum128AdvSimdB64	161.309	1625.103	4.311866
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	161.371	1624.481	4.310216
Sum256Base_Basic	1888.790	138.789	0.368248
Sum256Base	1927.001	136.037	0.360946
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1921.246	136.445	0.362027

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	333.454	786.147
SumBase_ShiftByMul	98.656	2657.141	3.379955
SumBase	98.655	2657.184	3.380010
SumTraits	18.314	14313.830	18.207577
Sum128Base_Basic	850.175	308.341	0.392218
Sum128Base	851.044	308.026	0.391818
Sum128AdvSimd_Shift	29.950	8752.732	11.133711
Sum128AdvSimd_Shuffle	85.345	3071.592	3.907147
Sum128AdvSimdB64	18.318	14311.042	18.204030
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	18.276	14343.457	18.245264
Sum256Base_Basic	755.187	347.124	0.441552
Sum256Base	765.220	342.573	0.435762
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	765.289	342.542	0.435723

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	459.203	570.867
SumBase_ShiftByMul	114.667	2286.127	4.004659
SumBase	114.790	2283.680	4.000372
SumTraits	40.057	6544.259	11.463723
Sum128Base_Basic	1247.915	210.066	0.367976
Sum128Base	1255.656	208.771	0.365708
Sum128AdvSimd_Shift	61.506	4262.090	7.465997
Sum128AdvSimd_Shuffle	167.778	1562.449	2.736977
Sum128AdvSimdB64	37.412	7006.907	12.274154
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	37.450	6999.869	12.261824
Sum256Base_Basic	971.316	269.885	0.472764
Sum256Base	974.586	268.980	0.471178
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	972.885	269.450	0.472002

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	747.071	350.896
SumBase_ShiftByMul	306.198	856.125	2.439828
SumBase	743.891	352.396	1.004275
SumTraits	75.024	3494.116	9.957711
Sum128Base_Basic	2138.278	122.596	0.349380
Sum128Base	2145.112	122.205	0.348267
Sum128AdvSimd_Shift	124.072	2112.835	6.021266
Sum128AdvSimd_Shuffle	342.191	766.075	2.183200
Sum128AdvSimdB64	74.882	3500.749	9.976614
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	75.142	3488.660	9.942161
Sum256Base_Basic	1464.213	179.034	0.510220
Sum256Base	1473.945	177.852	0.506852
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1469.844	178.348	0.508266

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	685.849	382.218
SumBase	695.905	376.695	0.985550
SumTraits	149.646	1751.755	4.583128
Sum128Base_Basic	1592.738	164.587	0.430610
Sum128Base_Move	1070.460	244.889	0.640705
Sum128Base	1587.306	165.150	0.432084
Sum128AdvSimd_AlignRight	175.833	1490.869	3.900569
Sum128AdvSimd_Shuffle	683.269	383.661	1.003775
Sum128AdvSimdB64	149.568	1752.669	4.585519
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	149.140	1757.701	4.598684
Sum256Base_Basic	1837.431	142.669	0.373265
Sum256Base	1843.422	142.205	0.372052
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1841.473	142.356	0.372446

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
SumBase_Basic	303.824	862.815
SumBase_Shift	30.434	8613.444	9.982961
SumBase_ShiftByMul	102.335	2561.626	2.968918
SumBase	30.487	8598.616	9.965776
SumTraits	16.957	15459.072	17.917029
Sum128Base_Basic	303.780	862.941	1.000147
Sum128Base_Shift	28.389	9233.887	10.702053
Sum128Base_Shuffle	1816.126	144.342	0.167293
Sum128Base	28.616	9160.895	10.617455
Sum128AdvSimd_Shift	28.890	9073.843	10.516563
Sum128AdvSimd_Shuffle	69.831	3753.951	4.350821
Sum128AdvSimdB64	16.997	15423.396	17.875680
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	16.963	15453.771	17.910884
Sum256Base_Basic	1042.465	251.465	0.291448
Sum256Base_Shift	1590.976	164.769	0.190967
Sum256Base_Shuffle	3529.634	74.269	0.086078
Sum256Base	1049.530	249.773	0.289486
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1051.108	249.398	0.289052

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
SumBase_Basic	431.239	607.885
SumBase_Shift	59.531	4403.506	7.243974
SumBase_ShiftByMul	115.453	2270.565	3.735185
SumBase	59.628	4396.289	7.232101
SumTraits	33.151	7907.458	13.008138
Sum128Base_Basic	431.384	607.681	0.999664
Sum128Base_Shift	53.676	4883.821	8.034114
Sum128Base_Shuffle	3027.874	86.577	0.142423
Sum128Base	53.723	4879.563	8.027110
Sum128AdvSimd_Shift	53.994	4855.094	7.986856
Sum128AdvSimd_Shuffle	136.918	1914.612	3.149627
Sum128AdvSimdB64	33.240	7886.405	12.973505
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	33.177	7901.401	12.998175
Sum256Base_Basic	1355.661	193.370	0.318103
Sum256Base_Shift	2247.943	116.615	0.191837
Sum256Base_Shuffle	5768.642	45.443	0.074756
Sum256Base	1345.606	194.815	0.320480
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1346.965	194.618	0.320156

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
Check-Sum128Base_Shift	Check `Sum128Base_Shift` mismatch. -833942548!=-468148262
Check-Sum128Base	Check `Sum128Base` mismatch. -833942548!=-468148262
Check-Sum128AdvSimd_Shift	Check `Sum128AdvSimd_Shift` mismatch. -833942548!=-468148262
# Sum256Base_Basic	-467951654
SumBase_Basic	721.926	363.118
SumBase_Shift	119.542	2192.905	6.039103
SumBase_ShiftByMul	285.703	917.540	2.526840
SumBase	119.322	2196.948	6.050237
SumTraits	66.618	3935.018	10.836758
Sum128Base_Basic	720.679	363.746	1.001731
Sum128Base_Shift	107.110	2447.425	6.740033
Sum128Base_Shuffle	6044.139	43.372	0.119442
Sum128Base	107.312	2442.812	6.727330
Sum128AdvSimd_Shift	107.228	2444.736	6.732630
Sum128AdvSimd_Shuffle	274.680	954.362	2.628246
Sum128AdvSimdB64	66.495	3942.317	10.856861
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	66.501	3941.958	10.855873
Sum256Base_Basic	1767.511	148.313	0.408442
Sum256Base_Shift	2960.174	88.557	0.243880
Sum256Base_Shuffle	10894.215	24.063	0.066267
Sum256Base	1768.481	148.231	0.408218
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1767.815	148.287	0.408372

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
SumBase_Basic	679.517	385.780
SumBase	689.484	380.203	0.985544
SumTraits	133.260	1967.158	5.099175
Sum128Base_Basic	688.934	380.507	0.986332
Sum128Base_Move	187.259	1399.903	3.628763
Sum128Base_Shuffle	12082.297	21.697	0.056241
Sum128Base	187.246	1400.001	3.629018
Sum128AdvSimd_AlignRight	160.308	1635.254	4.238828
Sum128AdvSimd_Shuffle	548.629	477.816	1.238573
Sum128AdvSimdB64	132.967	1971.497	5.110422
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	133.438	1964.536	5.092379
Sum256Base_Basic	2142.779	122.338	0.317120
Sum256Base_Shuffle	20654.563	12.692	0.032899
Sum256Base	2165.523	121.053	0.313789
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2170.585	120.771	0.313057

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	299.508	875.250
SumBase_Shift	23.350	11226.945	12.827134
SumBase_ShiftByMul	90.494	2896.796	3.309680
SumBase	23.384	11210.388	12.808218
SumTraits	16.603	15789.241	18.039700
Sum128Base_Basic	299.427	875.485	1.000269
Sum128Base_Shift	23.373	11215.464	12.814018
Sum128Base_Shuffle	1711.601	153.157	0.174987
Sum128Base	23.384	11210.609	12.808470
Sum128AdvSimd_Shift	23.350	11226.761	12.826925
Sum128AdvSimd_Shuffle	68.299	3838.192	4.385254
Sum128AdvSimd_ShuffleX	46.488	5638.952	6.442678
Sum128AdvSimdB64	16.605	15786.867	18.036987
Sum128PackedSimd_Shift	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	16.602	15790.296	18.040905
Sum256Base_Basic	263.546	994.681	1.136454
Sum256Base_Shift	18.211	14395.012	16.446750
Sum256Base_Shuffle	1770.435	148.068	0.169172
Sum256Base	263.232	995.868	1.137811
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	263.218	995.918	1.137867
Sum512Base_Basic	265.342	987.949	1.128762
Sum512Base_Shift	15.336	17093.738	19.530128
Sum512Base_Shuffle	2917.012	89.867	0.102676
Sum512Base	265.066	988.975	1.129935
Sum512Avx512_Shift	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	265.186	988.528	1.129424

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	438.426	597.921
SumBase_Shift	49.681	5276.586	8.824891
SumBase_ShiftByMul	88.049	2977.261	4.979356
SumBase	50.042	5238.511	8.761213
SumTraits	33.875	7738.568	12.942463
Sum128Base_Basic	438.427	597.919	0.999998
Sum128Base_Shift	49.652	5279.656	8.830026
Sum128Base_Shuffle	3019.466	86.818	0.145200
Sum128Base	50.835	5156.775	8.624513
Sum128AdvSimd_Shift	50.033	5239.406	8.762710
Sum128AdvSimd_Shuffle	138.841	1888.091	3.157762
Sum128AdvSimd_ShuffleX	98.930	2649.799	4.431689
Sum128AdvSimdB64	33.973	7716.261	12.905157
Sum128PackedSimd_Shift	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	33.962	7718.848	12.909483
Sum256Base_Basic	310.348	844.677	1.412690
Sum256Base_Shift	37.069	7071.845	11.827394
Sum256Base_Shuffle	3037.952	86.290	0.144316
Sum256Base	311.012	842.874	1.409675
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	311.194	842.382	1.408851
Sum512Base_Basic	327.301	800.926	1.339519
Sum512Base_Shift	32.108	8164.370	13.654602
Sum512Base_Shuffle	5316.418	49.308	0.082466
Sum512Base	327.449	800.564	1.338913
Sum512Avx512_Shift	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	327.472	800.509	1.338821

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
# Sum512Base_Basic	-467853350
SumBase_Basic	707.176	370.691
SumBase_Shift	100.420	2610.484	7.042202
SumBase_ShiftByMul	292.983	894.741	2.413709
SumBase	100.516	2607.987	7.035468
SumTraits	68.475	3828.336	10.327555
Sum128Base_Basic	707.489	370.527	0.999557
Sum128Base_Shift	100.541	2607.325	7.033680
Sum128Base_Shuffle	5982.815	43.816	0.118201
Sum128Base	100.579	2606.337	7.031016
Sum128AdvSimd_Shift	100.551	2607.062	7.032973
Sum128AdvSimd_Shuffle	281.028	932.805	2.516393
Sum128AdvSimd_ShuffleX	200.493	1307.495	3.527180
Sum128AdvSimdB64	68.394	3832.846	10.339724
Sum128PackedSimd_Shift	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	68.580	3822.432	10.311629
Sum256Base_Basic	493.359	531.346	1.433391
Sum256Base_Shift	74.532	3517.207	9.488236
Sum256Base_Shuffle	5905.791	44.388	0.119743
Sum256Base	491.916	532.904	1.437594
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	493.477	531.218	1.433047
Sum512Base_Basic	422.876	619.908	1.672301
Sum512Base_Shift	64.532	4062.257	10.958596
Sum512Base_Shuffle	10096.132	25.965	0.070044
Sum512Base	423.660	618.760	1.669206
Sum512Avx512_Shift	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	423.586	618.868	1.669498

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	678.915	386.122
SumBase	679.427	385.831	0.999247
SumTraits	128.830	2034.799	5.269835
Sum128Base_Basic	685.031	382.675	0.991072
Sum128Base_Move	202.653	1293.562	3.350138
Sum128Base_Shuffle	12073.120	21.713	0.056234
Sum128Base	202.810	1292.560	3.347543
Sum128AdvSimd_AlignRight	159.598	1642.530	4.253915
Sum128AdvSimd_Shuffle	559.266	468.729	1.213940
Sum128AdvSimd_ShuffleX	398.623	657.624	1.703152
Sum128AdvSimdB64	128.569	2038.941	5.280562
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	128.570	2038.923	5.280517
Sum256Base_Basic	529.756	494.839	1.281562
Sum256Base_Shuffle	11744.017	22.321	0.057809
Sum256Base	529.787	494.810	1.281486
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	529.629	494.958	1.281869
Sum512Base_Basic	600.748	436.363	1.130116
Sum512Base_Shuffle	20426.732	12.833	0.033237
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	600.910	436.245	1.129811

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


[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# Sum128Base_Basic	114
# Sum256Base_Basic	114
# Sum512Base_Basic	114
SumBase_Basic	11831.250	22.157
SumBase_Shift	6892.708	38.032	1.716488
SumBase_ShiftByMul	42616.667	6.151	0.277620
SumBase	11564.583	22.668	1.023059
SumTraits	2560.937	102.363	4.619890
Sum128Base_Basic	11986.458	21.870	0.987051
Sum128Base_Shift	2114.062	124.000	5.596452
Sum128Base_Shuffle	4698.437	55.794	2.518124
Sum128Base	2106.250	124.460	5.617211
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shift	2162.500	121.223	5.471098
Sum128PackedSimd_Shuffle	2133.073	122.895	5.546575
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2069.010	126.700	5.718313
Sum256Base_Basic	12821.875	20.445	0.922739
Sum256Base_Shift	14313.542	18.314	0.826577
Sum256Base_Shuffle	52608.333	4.983	0.224893
Sum256Base	13213.542	19.839	0.895388
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	13525.000	19.382	0.874769
Sum512Base_Basic	13283.333	19.735	0.890684
Sum512Base_Shift	19766.667	13.262	0.598546
Sum512Base_Shuffle	52695.833	4.975	0.224520
Sum512Base	14180.208	18.487	0.834350
Sum512Avx512_Shift	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	14408.333	18.194	0.821139

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# Sum128Base_Basic	-24614
# Sum256Base_Basic	-24614
# Sum512Base_Basic	8154
SumBase_Basic	16918.750	15.494
SumBase_Shift	12526.042	20.928	1.350686
SumBase_ShiftByMul	33845.833	7.745	0.499877
SumBase	16354.167	16.029	1.034522
SumTraits	5200.000	50.412	3.253606
Sum128Base_Basic	16037.500	16.346	1.054949
Sum128Base_Shift	4230.208	61.970	3.999508
Sum128Base_Shuffle	9546.875	27.459	1.772177
Sum128Base	4171.875	62.836	4.055431
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shift	4185.937	62.625	4.041807
Sum128PackedSimd_Shuffle	4336.458	60.451	3.901513
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	4264.844	61.466	3.967027
Sum256Base_Basic	18962.500	13.824	0.892221
Sum256Base_Shift	27277.083	9.610	0.620255
Sum256Base_Shuffle	104225.000	2.515	0.162329
Sum256Base	18685.417	14.029	0.905452
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	20877.083	12.557	0.810398
Sum512Base_Basic	20352.083	12.880	0.831303
Sum512Base_Shift	39487.500	6.639	0.428458
Sum512Base_Shuffle	105491.667	2.485	0.160380
Sum512Base	20095.833	13.045	0.841903
Sum512Avx512_Shift	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	21535.417	12.173	0.785624

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468148262
# Sum128Base_Basic	-468148262
# Sum256Base_Basic	-467951654
# Sum512Base_Basic	-467853350
SumBase_Basic	24447.917	10.723
SumBase_Shift	21891.667	11.975	1.116768
SumBase_ShiftByMul	104375.000	2.512	0.234232
SumBase	24418.750	10.735	1.001194
SumTraits	10519.792	24.919	2.323992
Sum128Base_Basic	22589.583	11.605	1.082265
Sum128Base_Shift	8638.542	30.346	2.830098
Sum128Base_Shuffle	18770.833	13.965	1.302442
Sum128Base	8582.292	30.545	2.848647
Sum128AdvSimd_Shift	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shift	8315.625	31.524	2.939998
Sum128PackedSimd_Shuffle	8753.125	29.949	2.793050
Sum128Sse_Shift	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	8341.667	31.426	2.930819
Sum256Base_Basic	28575.000	9.174	0.855570
Sum256Base_Shift	54908.333	4.774	0.445250
Sum256Base_Shuffle	205266.666	1.277	0.119103
Sum256Base	28812.500	9.098	0.848518
Sum256Avx2_Shift	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	32952.083	7.955	0.741923
Sum512Base_Basic	31166.667	8.411	0.784425
Sum512Base_Shift	76800.000	3.413	0.318332
Sum512Base_Shuffle	216000.000	1.214	0.113185
Sum512Base	30716.667	8.534	0.795917
Sum512Avx512_Shift	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	31716.667	8.265	0.770822

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571877380
# Sum128Base_Basic	5910372263571877380
# Sum256Base_Basic	5910372263571942916
# Sum512Base_Basic	5910372263571975684
SumBase_Basic	72566.667	3.612
SumBase	72675.000	3.607	0.998509
SumTraits	61325.000	4.275	1.183313
Sum128Base_Basic	132983.333	1.971	0.545682
Sum128Base_Move	128283.333	2.043	0.565675
Sum128Base_Shuffle	140533.333	1.865	0.516366
Sum128Base	118233.333	2.217	0.613758
Sum128AdvSimd_AlignRight	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_ShuffleX	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	16702.083	15.695	4.344767
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleX	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_ShuffleXImm	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Unpack	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	17056.250	15.369	4.254550
Sum256Base_Basic	151933.333	1.725	0.477622
Sum256Base_Shuffle	519516.667	0.505	0.139681
Sum256Base	146700.000	1.787	0.494660
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Unpack	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	65633.333	3.994	1.105637
Sum512Base_Basic	144550.000	1.814	0.502018
Sum512Base_Shuffle	525050.000	0.499	0.138209
Sum512Avx512_Shuffle	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Unpack	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	57908.333	4.527	1.253130

```

