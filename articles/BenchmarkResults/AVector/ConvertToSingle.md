# Benchmark - ConvertToSingle
([← Back](README.md))

See [Group](ConvertToSingle_Group.md)

- `ConvertToInt32`: Convert to a vector whose elements are of type Int32 (转换为元素类型是Int32的向量).
  Mnemonic: `rt[i] := (Int32)(value[i])` .
- `ConvertToSingle`: Convert to a vector whose elements are of type Single (转换为元素类型是Single的向量).
  Mnemonic: `rt[i] := (Single)(value[i])` .
- `ConvertToUInt32`: Convert to a vector whose elements are of type UInt32 (转换为元素类型是UInt32的向量).
  Mnemonic: `rt[i] := (UInt32)(value[i])` .

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	154.674	1694.815
SumBcl	12.631	20754.239	12.245724
SumTraits	12.597	20809.224	12.278167

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	230.234	1138.600
SumBcl	28.813	9098.173	7.990664
SumTraits	28.968	9049.423	7.947848

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	238.472	1099.264
SumBcl	43.426	6036.592	5.491487
SumTraits	43.315	6051.971	5.505476

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	155.750	1683.112
SumBcl	529.970	494.640	0.293884
SumTraits	532.994	491.833	0.292216

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	154.629	1695.307
SumBcl	12.356	21216.737	12.514983
SumTraits	12.452	21053.020	12.418412

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	228.864	1145.412
SumBcl	28.902	9070.082	7.918622
SumTraits	28.779	9108.798	7.952422

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	238.708	1098.180
SumBcl	42.971	6100.482	5.555084
SumTraits	43.358	6046.042	5.505512

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	154.970	1691.575
SumBcl	495.967	528.552	0.312461
SumTraits	503.719	520.417	0.307652

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	155.474	1686.092
SumBcl	12.533	20916.395	12.405253
SumTraits	12.692	20654.123	12.249702
Sum128Base_Basic	483.257	542.453	0.321722
Sum128Base	482.156	543.691	0.322456
Sum128Traits	24.502	10698.919	6.345395
Sum256Base_Basic	282.470	928.042	0.550410
Sum256Base	282.619	927.554	0.550121
Sum256Traits	12.630	20755.404	12.309771

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	229.374	1142.866
SumBcl	28.843	9088.499	7.952375
SumTraits	28.860	9083.346	7.947865
Sum128Base_Basic	501.171	523.062	0.457676
Sum128Base	498.569	525.792	0.460065
Sum128Traits	57.663	4546.158	3.977857
Sum256Base_Basic	292.436	896.414	0.784356
Sum256Base	295.439	887.303	0.776384
Sum256Traits	28.894	9072.746	7.938591

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	230.295	1138.296
SumBcl	43.137	6077.023	5.338703
SumTraits	31.765	8252.668	7.250021
Sum128Base_Basic	524.822	499.491	0.438806
Sum128Base	523.888	500.382	0.439589
Sum128Traits	64.294	4077.241	3.581882
Sum256Base_Basic	300.303	872.932	0.766877
Sum256Base	299.233	876.054	0.769619
Sum256Traits	31.466	8331.018	7.318852

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	154.515	1696.562
SumBcl	515.846	508.183	0.299537
SumTraits	46.338	5657.201	3.334509
Sum128Base_Basic	484.891	540.625	0.318659
Sum128Base	481.293	544.666	0.321041
Sum128Traits	94.747	2766.782	1.630817
Sum256Base_Basic	284.394	921.763	0.543312
Sum256Base	282.451	928.105	0.547050
Sum256Avx2_ShiftVar	46.363	5654.133	3.332700
Sum256Avx2_Mapping	281.679	930.649	0.548550
Sum256Avx2_MappingFix	282.879	926.699	0.546222
Sum256Avx2_Mod	283.250	925.485	0.545506
Sum256Traits	46.404	5649.165	3.329772

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	154.364	1698.224
SumBcl	12.236	21423.395	12.615174
SumTraits	12.304	21305.099	12.545515
Sum128Base_Basic	462.913	566.292	0.333461
Sum128Base	463.725	565.300	0.332877
Sum128Traits	22.562	11618.911	6.841800
Sum256Base_Basic	282.850	926.796	0.545744
Sum256Base	280.133	935.786	0.551038
Sum256Traits	12.100	21665.234	12.757581

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	228.996	1144.753
SumBcl	28.900	9070.805	7.923810
SumTraits	28.952	9054.363	7.909448
Sum128Base_Basic	482.485	543.321	0.474618
Sum128Base	481.634	544.280	0.475456
Sum128Traits	57.627	4549.003	3.973786
Sum256Base_Basic	291.896	898.074	0.784513
Sum256Base	289.959	904.074	0.789755
Sum256Traits	28.916	9065.694	7.919346

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	229.886	1140.320
SumBcl	43.273	6057.951	5.312500
SumTraits	29.419	8910.805	7.814301
Sum128Base_Basic	517.083	506.967	0.444583
Sum128Base	518.534	505.548	0.443339
Sum128Traits	57.726	4541.211	3.982400
Sum256Base_Basic	308.366	850.108	0.745499
Sum256Base	309.267	847.630	0.743326
Sum256Traits	29.186	8981.840	7.876595

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	155.079	1690.393
SumBcl	430.064	609.546	0.360594
SumTraits	32.066	8175.227	4.836288
Sum128Base_Basic	464.243	564.669	0.334046
Sum128Base	464.109	564.832	0.334143
Sum128Traits	62.679	4182.321	2.474171
Sum256Base_Basic	280.658	934.032	0.552553
Sum256Base	281.483	931.297	0.550935
Sum256Avx2_ShiftVar	31.940	8207.489	4.855373
Sum256Avx2_Mapping	24.749	10591.961	6.265976
Sum256Avx2_MappingFix	24.763	10585.957	6.262424
Sum256Avx2_Mod	62.118	4220.109	2.496526
Sum256Traits	31.709	8267.276	4.890742

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	153.947	1702.825
SumBcl	12.078	21703.698	12.745699
SumTraits	12.063	21731.991	12.762314
Sum128Base_Basic	461.497	568.029	0.333581
Sum128Base	463.093	566.073	0.332431
Sum128Traits	24.413	10737.859	6.305908
Sum256Base_Basic	280.857	933.373	0.548132
Sum256Base	279.291	938.605	0.551205
Sum256Traits	12.161	21555.620	12.658738

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	229.942	1140.042
SumBcl	28.969	9049.220	7.937618
SumTraits	28.902	9069.952	7.955803
Sum128Base_Basic	485.329	540.137	0.473786
Sum128Base	486.695	538.621	0.472457
Sum128Traits	57.492	4559.698	3.999587
Sum256Base_Basic	296.944	882.807	0.774363
Sum256Base	293.120	894.322	0.784464
Sum256Traits	28.925	9062.818	7.949545

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	231.537	1132.192
SumBcl	44.202	5930.575	5.238134
SumTraits	29.274	8954.832	7.909285
Sum128Base_Basic	514.978	509.039	0.449605
Sum128Base	520.266	503.866	0.445035
Sum128Traits	57.799	4535.420	4.005874
Sum256Base_Basic	310.359	844.648	0.746029
Sum256Base	309.549	846.857	0.747980
Sum256Traits	29.236	8966.597	7.919676

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	154.164	1700.422
SumBcl	429.330	610.588	0.359081
SumTraits	30.018	8733.016	5.135795
Sum128Base_Basic	463.267	565.860	0.332776
Sum128Base	464.314	564.584	0.332026
Sum128Traits	60.294	4347.727	2.556852
Sum256Base_Basic	281.251	932.064	0.548137
Sum256Base	280.967	933.007	0.548692
Sum256Avx2_ShiftVar	29.764	8807.306	5.179484
Sum256Avx2_Mapping	24.015	10915.903	6.419528
Sum256Avx2_MappingFix	24.413	10737.765	6.314766
Sum256Avx2_Mod	63.024	4159.408	2.446104
Sum256Traits	30.255	8664.563	5.095538

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	153.772	1704.754
SumBcl	12.934	20267.664	11.888907
SumTraits	13.006	20155.336	11.823016
Sum128Bcl	23.734	11044.863	6.478860
Sum128Base_Basic	460.658	569.064	0.333810
Sum128Base	23.776	11025.670	6.467601
Sum128Traits	23.721	11051.285	6.482627
Sum256Bcl	14.062	18642.632	10.935672
Sum256Base_Basic	270.453	969.279	0.568574
Sum256Base	12.844	20409.262	11.971968
Sum256Traits	12.863	20379.841	11.954709

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	229.635	1141.567
SumBcl	28.865	9081.773	7.955535
SumTraits	28.891	9073.535	7.948319
Sum128Bcl	57.571	4553.400	3.988729
Sum128Base_Basic	479.556	546.639	0.478850
Sum128Base	57.543	4555.607	3.990662
Sum128Traits	57.622	4549.409	3.985233
Sum256Bcl	28.934	9060.146	7.936590
Sum256Base_Basic	278.376	941.689	0.824909
Sum256Base	28.882	9076.261	7.950706
Sum256Traits	28.794	9103.989	7.974996

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	229.840	1140.548
SumBcl	29.067	9018.519	7.907179
SumTraits	29.104	9007.087	7.897156
Sum128Bcl	57.804	4535.069	3.976219
Sum128Base_Basic	530.908	493.765	0.432919
Sum128Base	58.053	4515.612	3.959159
Sum128Traits	58.031	4517.314	3.960652
Sum256Bcl	29.104	9007.044	7.897118
Sum256Base_Basic	280.536	934.441	0.819291
Sum256Base	29.172	8986.087	7.878744
Sum256Traits	29.093	9010.432	7.900089

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	154.775	1693.707
SumBcl	257.270	1018.945	0.601606
SumTraits	29.781	8802.253	5.197033
Sum128Bcl	463.972	565.000	0.333588
Sum128Base_Basic	459.966	569.921	0.336493
Sum128Base	461.737	567.735	0.335202
Sum128Traits	59.481	4407.198	2.602102
Sum256Bcl	255.956	1024.174	0.604694
Sum256Base_Basic	268.699	975.603	0.576016
Sum256Base	253.068	1035.865	0.611596
Sum256Avx2_ShiftVar	29.800	8796.670	5.193737
Sum256Avx2_Mapping	24.333	10773.209	6.360727
Sum256Avx2_MappingFix	24.310	10783.603	6.366864
Sum256Avx2_Mod	58.421	4487.182	2.649326
Sum256Traits	30.073	8716.898	5.146638

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	155.093	1690.241
SumBcl	13.276	19745.207	11.681889
SumTraits	13.336	19656.530	11.629425
Sum128Bcl	23.806	11011.810	6.514935
Sum128Base_Basic	464.643	564.184	0.333789
Sum128Base	23.851	10990.685	6.502437
Sum128Traits	24.026	10910.669	6.455096
Sum256Bcl	13.380	19591.970	11.591229
Sum256Base_Basic	272.017	963.704	0.570158
Sum256Base	13.426	19525.084	11.551657
Sum256Traits	13.604	19270.308	11.400924
Sum512Bcl	12.566	20861.099	12.342086
Sum512Base	12.624	20766.090	12.285875
Sum512Traits	12.648	20726.919	12.262701

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -8.2939596E+11!=-8.293999E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -8.2939596E+11!=-8.293999E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -8.2939596E+11!=-8.293999E+11
SumScalar	229.837	1140.564
SumBcl	28.897	9071.740	7.953729
SumTraits	29.125	9000.554	7.891316
Sum128Bcl	57.931	4525.092	3.967415
Sum128Base_Basic	483.005	542.735	0.475848
Sum128Base	57.700	4543.255	3.983340
Sum128Traits	57.787	4536.419	3.977346
Sum256Bcl	28.906	9068.772	7.951127
Sum256Base_Basic	282.628	927.525	0.813215
Sum256Base	28.977	9046.685	7.931762
Sum256Traits	28.919	9064.754	7.947604
Sum512Bcl	16.386	15998.055	14.026437
Sum512Base	16.559	15830.903	13.879886
Sum512Traits	16.341	16042.295	14.065225

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 5.642077E+14!=5.6420824E+14
Check-Sum512Base	Check `Sum512Base` mismatch. 5.642077E+14!=5.6420824E+14
Check-Sum512Traits	Check `Sum512Traits` mismatch. 5.642077E+14!=5.6420824E+14
SumScalar	230.082	1139.351
SumBcl	29.289	8950.403	7.855702
SumTraits	28.928	9061.888	7.953552
Sum128Bcl	58.444	4485.409	3.936810
Sum128Base_Basic	498.735	525.618	0.461331
Sum128Base	58.079	4513.552	3.961511
Sum128Traits	58.000	4519.746	3.966947
Sum256Bcl	29.162	8989.369	7.889903
Sum256Base_Basic	279.877	936.639	0.822081
Sum256Base	29.290	8949.840	7.855208
Sum256Traits	28.873	9079.091	7.968650
Sum512Bcl	151.453	1730.857	1.519161
Sum512Base	150.383	1743.180	1.529976
Sum512Traits	16.603	15789.170	13.858037

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	153.923	1703.090
SumBcl	254.992	1028.049	0.603638
SumTraits	13.978	18754.390	11.011977
Sum128Bcl	1229.859	213.150	0.125155
Sum128Base_Basic	479.943	546.198	0.320710
Sum128Base	1222.792	214.382	0.125878
Sum128Traits	27.476	9540.796	5.602050
Sum256Bcl	1196.422	219.107	0.128652
Sum256Base_Basic	282.417	928.217	0.545019
Sum256Base	1192.422	219.842	0.129084
Sum256Avx2_ShiftVar	36.520	7178.130	4.214768
Sum256Avx2_Mapping	27.703	9462.579	5.556123
Sum256Avx2_MappingFix	27.740	9450.026	5.548752
Sum256Avx2_Mod	74.237	3531.197	2.073406
Sum256Traits	16.409	15975.347	9.380212
Sum512Bcl	1458.185	179.774	0.105558
Sum512Base	1460.025	179.548	0.105425
Sum512Traits	14.959	17523.786	10.289406

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	174.833	1499.395
SumBcl	25.153	10421.773	6.950654
SumTraits	26.256	9984.056	6.658725

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	366.847	714.586
SumBcl	49.066	5342.687	7.476613
SumTraits	49.099	5339.127	7.471632

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	379.691	690.414
SumBcl	68.264	3840.125	5.562057
SumTraits	68.901	3804.634	5.510652

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	199.534	1313.781
SumBcl	846.585	309.649	0.235693
SumTraits	790.441	331.643	0.252434

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	156.984	1669.872
SumBcl	25.529	10268.459	6.149248
SumTraits	22.476	11663.138	6.984449

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	309.753	846.301
SumBcl	38.836	6749.984	7.975871
SumTraits	38.870	6744.116	7.968937

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	310.385	844.578
SumBcl	47.564	5511.355	6.525573
SumTraits	48.064	5454.035	6.457704

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	156.728	1672.603
SumBcl	618.441	423.879	0.253425
SumTraits	619.559	423.114	0.252967

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	157.026	1669.428
SumBcl	24.240	10814.535	6.477989
SumTraits	23.902	10967.617	6.569687
Sum128Base_Basic	452.460	579.374	0.347050
Sum128Base	455.601	575.380	0.344657
Sum128Traits	40.897	6409.819	3.839531
Sum256Base_Basic	276.639	947.605	0.567623
Sum256Base	273.459	958.622	0.574222
Sum256Traits	22.516	11642.519	6.973959

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	309.786	846.210
SumBcl	38.842	6748.989	7.975548
SumTraits	38.929	6733.875	7.957687
Sum128Base_Basic	484.995	540.509	0.638741
Sum128Base	484.953	540.556	0.638796
Sum128Traits	77.632	3376.766	3.990459
Sum256Base_Basic	296.125	885.249	1.046134
Sum256Base	295.394	887.439	1.048722
Sum256Traits	38.918	6735.888	7.960067

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	310.059	845.465
SumBcl	43.145	6075.856	7.186411
SumTraits	41.273	6351.457	7.512386
Sum128Base_Basic	542.842	482.910	0.571177
Sum128Base	542.661	483.071	0.571368
Sum128Traits	77.905	3364.906	3.979948
Sum256Base_Basic	358.573	731.077	0.864704
Sum256Base	358.521	731.182	0.864829
Sum256Traits	41.186	6364.881	7.528264

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	156.969	1670.039
SumBcl	624.623	419.684	0.251302
SumTraits	65.624	3994.640	2.391944
Sum128Base_Basic	454.218	577.132	0.345580
Sum128Base	452.509	579.312	0.346885
Sum128Traits	117.182	2237.059	1.339525
Sum256Base_Basic	274.533	954.871	0.571765
Sum256Base	273.473	958.572	0.573982
Sum256Avx2_ShiftVar	65.204	4020.361	2.407345
Sum256Avx2_Mapping	274.682	954.356	0.571457
Sum256Avx2_MappingFix	273.159	959.677	0.574643
Sum256Avx2_Mod	273.369	958.940	0.574202
Sum256Traits	65.705	3989.698	2.388985

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	156.700	1672.903
SumBcl	22.205	11805.635	7.056974
SumTraits	22.000	11915.415	7.122596
Sum128Base_Basic	430.859	608.422	0.363692
Sum128Base	430.722	608.616	0.363808
Sum128Traits	40.659	6447.333	3.853978
Sum256Base_Basic	283.793	923.714	0.552162
Sum256Base	280.492	934.587	0.558661
Sum256Traits	22.348	11729.918	7.011713

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	309.794	846.187
SumBcl	38.868	6744.484	7.970439
SumTraits	38.904	6738.263	7.963088
Sum128Base_Basic	466.102	562.417	0.664649
Sum128Base	465.611	563.010	0.665349
Sum128Traits	77.842	3367.625	3.979764
Sum256Base_Basic	303.944	862.476	1.019249
Sum256Base	303.975	862.387	1.019144
Sum256Traits	38.913	6736.699	7.961240

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	310.150	845.217
SumBcl	47.628	5503.989	6.511923
SumTraits	39.464	6642.531	7.858964
Sum128Base_Basic	542.461	483.249	0.571746
Sum128Base	542.515	483.202	0.571689
Sum128Traits	77.728	3372.597	3.990214
Sum256Base_Basic	368.235	711.893	0.842260
Sum256Base	368.573	711.241	0.841489
Sum256Traits	39.635	6613.978	7.825182

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	156.811	1671.720
SumBcl	469.150	558.764	0.334245
SumTraits	55.959	4684.569	2.802245
Sum128Base_Basic	431.677	607.269	0.363260
Sum128Base	430.851	608.433	0.363956
Sum128Traits	99.156	2643.752	1.581456
Sum256Base_Basic	280.991	932.925	0.558063
Sum256Base	287.088	913.115	0.546213
Sum256Avx2_ShiftVar	55.682	4707.837	2.816164
Sum256Avx2_Mapping	47.207	5553.033	3.321748
Sum256Avx2_MappingFix	58.938	4447.789	2.660606
Sum256Avx2_Mod	111.743	2345.947	1.403313
Sum256Traits	55.798	4698.052	2.810311

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	156.863	1671.169
SumBcl	22.692	11552.363	6.912742
SumTraits	22.290	11760.373	7.037212
Sum128Base_Basic	434.661	603.101	0.360885
Sum128Base	436.704	600.279	0.359197
Sum128Traits	40.767	6430.375	3.847830
Sum256Base_Basic	552.869	474.152	0.283725
Sum256Base	552.588	474.393	0.283869
Sum256Traits	22.574	11612.407	6.948672

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	309.933	845.809
SumBcl	38.833	6750.559	7.981189
SumTraits	39.016	6718.815	7.943659
Sum128Base_Basic	466.564	561.861	0.664289
Sum128Base	466.732	561.658	0.664049
Sum128Traits	77.583	3378.899	3.994874
Sum256Base_Basic	573.150	457.374	0.540754
Sum256Base	573.353	457.212	0.540562
Sum256Traits	38.963	6728.034	7.954558

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	310.060	845.461
SumBcl	47.482	5520.861	6.530000
SumTraits	39.778	6590.232	7.794836
Sum128Base_Basic	542.425	483.281	0.571619
Sum128Base	542.889	482.868	0.571130
Sum128Traits	77.795	3369.685	3.985618
Sum256Base_Basic	649.723	403.470	0.477219
Sum256Base	650.080	403.249	0.476958
Sum256Traits	39.614	6617.517	7.827109

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	158.548	1653.408
SumBcl	493.349	531.356	0.321370
SumTraits	55.058	4761.244	2.879655
Sum128Base_Basic	438.544	597.760	0.361532
Sum128Base	430.981	608.249	0.367876
Sum128Traits	98.399	2664.080	1.611266
Sum256Base_Basic	554.492	472.764	0.285933
Sum256Base	553.315	473.770	0.286542
Sum256Avx2_ShiftVar	55.111	4756.635	2.876867
Sum256Avx2_Mapping	47.054	5571.145	3.369492
Sum256Avx2_MappingFix	59.221	4426.557	2.677232
Sum256Avx2_Mod	109.464	2394.794	1.448399
Sum256Traits	55.136	4754.504	2.875578

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	155.001	1691.240
SumBcl	23.774	11026.326	6.519671
SumTraits	24.253	10808.847	6.391079
Sum128Bcl	42.821	6121.922	3.619784
Sum128Base_Basic	435.033	602.585	0.356298
Sum128Base	42.182	6214.614	3.674591
Sum128Traits	42.306	6196.387	3.663813
Sum256Bcl	22.909	11442.853	6.765956
Sum256Base_Basic	263.653	994.278	0.587899
Sum256Base	22.987	11404.163	6.743079
Sum256Traits	23.030	11382.767	6.730428

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	309.764	846.270
SumBcl	38.784	6759.000	7.986809
SumTraits	38.854	6746.860	7.972463
Sum128Bcl	77.652	3375.873	3.989119
Sum128Base_Basic	465.246	563.452	0.665807
Sum128Base	77.613	3377.586	3.991143
Sum128Traits	77.579	3379.056	3.992880
Sum256Bcl	38.840	6749.398	7.975462
Sum256Base_Basic	281.014	932.852	1.102310
Sum256Base	38.868	6744.415	7.969575
Sum256Traits	38.823	6752.269	7.978855

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	310.428	844.460
SumBcl	39.858	6576.911	7.788302
SumTraits	39.826	6582.186	7.794549
Sum128Bcl	77.691	3374.187	3.995673
Sum128Base_Basic	540.337	485.149	0.574508
Sum128Base	78.152	3354.275	3.972094
Sum128Traits	77.694	3374.072	3.995537
Sum256Bcl	39.755	6593.947	7.808476
Sum256Base_Basic	348.768	751.629	0.890070
Sum256Base	39.831	6581.442	7.793668
Sum256Traits	39.775	6590.715	7.804649

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	154.976	1691.514
SumBcl	246.858	1061.923	0.627794
SumTraits	50.606	5180.147	3.062432
Sum128Bcl	415.020	631.641	0.373418
Sum128Base_Basic	435.795	601.531	0.355617
Sum128Base	415.313	631.196	0.373154
Sum128Traits	96.998	2702.577	1.597727
Sum256Bcl	246.959	1061.490	0.627538
Sum256Base_Basic	265.325	988.012	0.584099
Sum256Base	247.489	1059.217	0.626194
Sum256Avx2_ShiftVar	55.228	4746.598	2.806123
Sum256Avx2_Mapping	44.527	5887.329	3.480508
Sum256Avx2_MappingFix	51.907	5050.234	2.985629
Sum256Avx2_Mod	106.458	2462.422	1.455750
Sum256Traits	50.946	5145.548	3.041977

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
Check-SumBcl	Check `SumBcl` mismatch. 1130044246!=1130044655
Check-SumTraits	Check `SumTraits` mismatch. 1130044246!=1130044655
SumScalar	368.953	710.509
SumBcl	63.604	4121.479	5.800744
SumTraits	67.454	3886.273	5.469704
Sum128Base_Basic	1442.614	181.715	0.255753
Sum128Base	1438.404	182.246	0.256501
Sum128Traits	1445.970	181.293	0.255159
Sum256Base_Basic	1255.474	208.801	0.293875
Sum256Base	1286.723	203.730	0.286738
Sum256Traits	1402.849	186.865	0.263002

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	318.205	823.821
SumBcl	63.671	4117.194	4.997681
SumTraits	67.765	3868.441	4.695730
Sum128Base_Basic	1487.893	176.185	0.213863
Sum128Base	1486.583	176.340	0.214051
Sum128Traits	1494.723	175.380	0.212886
Sum256Base_Basic	1275.351	205.547	0.249504
Sum256Base	1323.351	198.091	0.240454
Sum256Traits	1473.508	177.905	0.215951

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	346.970	755.524
SumBcl	67.380	3890.506	5.149415
SumTraits	62.912	4166.831	5.515155
Sum128Base_Basic	1521.007	172.349	0.228119
Sum128Base	1509.960	173.610	0.229787
Sum128Traits	1518.258	172.661	0.228532
Sum256Base_Basic	1293.579	202.650	0.268225
Sum256Base	1340.720	195.525	0.258794
Sum256Traits	1442.707	181.703	0.240499

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	367.404	713.504
SumBcl	1207.867	217.031	0.304176
SumTraits	1210.689	216.525	0.303467
Sum128Base_Basic	1460.202	179.526	0.251612
Sum128Base	1466.725	178.727	0.250493
Sum128Traits	1464.298	179.024	0.250908
Sum256Base_Basic	1276.538	205.355	0.287813
Sum256Base	1300.340	201.596	0.282544
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1409.247	186.017	0.260709

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	362.744	722.668
SumBcl	62.442	4198.224	5.809336
SumTraits	62.249	4211.214	5.827312
Sum128Base_Basic	733.384	357.444	0.494617
Sum128Base	734.843	356.735	0.493636
Sum128Traits	62.429	4199.079	5.810519
Sum256Base_Basic	891.878	293.924	0.406720
Sum256Base	932.034	281.260	0.389197
Sum256Traits	934.526	280.510	0.388159

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	321.198	816.145
SumBcl	67.183	3901.944	4.780946
SumTraits	67.136	3904.696	4.784317
Sum128Base_Basic	751.546	348.806	0.427383
Sum128Base	750.816	349.145	0.427798
Sum128Traits	67.410	3888.786	4.764823
Sum256Base_Basic	898.107	291.885	0.357639
Sum256Base	941.489	278.436	0.341160
Sum256Traits	944.168	277.645	0.340191

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	346.548	756.443
SumBcl	66.892	3918.924	5.180725
SumTraits	66.841	3921.903	5.184662
Sum128Base_Basic	820.242	319.593	0.422495
Sum128Base	820.046	319.670	0.422596
Sum128Traits	66.504	3941.794	5.210958
Sum256Base_Basic	940.948	278.596	0.368297
Sum256Base	984.098	266.380	0.352148
Sum256Traits	986.037	265.856	0.351456

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	360.408	727.353
SumBcl	811.856	322.895	0.443931
SumTraits	63.217	4146.712	5.701100
Sum128Base_Basic	734.166	357.064	0.490909
Sum128Base	732.192	358.026	0.492232
Sum128Traits	63.292	4141.799	5.694345
Sum256Base_Basic	901.048	290.932	0.399988
Sum256Base	941.171	278.530	0.382936
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	942.672	278.086	0.382326

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	361.100	725.959
SumBcl	66.814	3923.501	5.404578
SumTraits	66.760	3926.662	5.408932
Sum128Base_Basic	739.789	354.350	0.488113
Sum128Base	739.000	354.728	0.488634
Sum128Traits	62.694	4181.350	5.759762
Sum256Base_Basic	893.642	293.344	0.404077
Sum256Base	930.405	281.753	0.388111
Sum256Traits	931.087	281.546	0.387827

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	319.511	820.454
SumBcl	63.538	4125.776	5.028649
SumTraits	63.695	4115.625	5.016277
Sum128Base_Basic	757.616	346.012	0.421732
Sum128Base	758.576	345.574	0.421198
Sum128Traits	63.674	4116.987	5.017937
Sum256Base_Basic	896.531	292.398	0.356386
Sum256Base	943.723	277.776	0.338564
Sum256Traits	940.735	278.659	0.339639

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	319.252	821.119
SumBcl	62.670	4182.957	5.094215
SumTraits	62.737	4178.430	5.088702
Sum128Base_Basic	755.839	346.825	0.422381
Sum128Base	756.873	346.351	0.421804
Sum128Traits	62.609	4187.002	5.099141
Sum256Base_Basic	887.844	295.259	0.359581
Sum256Base	930.042	281.863	0.343266
Sum256Traits	933.686	280.763	0.341927

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	359.469	729.253
SumBcl	1486.621	176.335	0.241803
SumTraits	64.239	4080.756	5.595799
Sum128Base_Basic	736.186	356.084	0.488286
Sum128Base	739.278	354.595	0.486243
Sum128Traits	64.078	4091.023	5.609878
Sum256Base_Basic	898.559	291.738	0.400050
Sum256Base	943.470	277.851	0.381007
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	941.495	278.434	0.381807

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	231.036	1134.645
SumBcl	55.346	4736.433	4.174374
SumTraits	55.458	4726.887	4.165961
Sum128Bcl	55.465	4726.317	4.165459
Sum128Base_Basic	719.558	364.312	0.321081
Sum128Base	55.445	4728.041	4.166978
Sum128Traits	55.526	4721.119	4.160877
Sum256Bcl	974.023	269.135	0.237198
Sum256Base_Basic	922.772	284.083	0.250372
Sum256Base	1043.202	251.288	0.221468
Sum256Traits	1041.543	251.688	0.221821

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	281.998	929.596
SumBcl	54.452	4814.231	5.178844
SumTraits	54.662	4795.698	5.158907
Sum128Bcl	54.695	4792.799	5.155788
Sum128Base_Basic	736.542	355.912	0.382867
Sum128Base	54.652	4796.609	5.159887
Sum128Traits	54.630	4798.539	5.161963
Sum256Bcl	993.867	263.762	0.283738
Sum256Base_Basic	917.202	285.808	0.307455
Sum256Base	994.751	263.527	0.283486
Sum256Traits	995.113	263.431	0.283383

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	281.678	930.652
SumBcl	55.155	4752.819	5.106976
SumTraits	55.225	4746.878	5.100592
Sum128Bcl	55.338	4737.181	5.090172
Sum128Base_Basic	736.599	355.884	0.382403
Sum128Base	55.176	4751.015	5.105037
Sum128Traits	55.199	4749.095	5.102975
Sum256Bcl	995.722	263.270	0.282888
Sum256Base_Basic	919.348	285.141	0.306388
Sum256Base	995.381	263.360	0.282985
Sum256Traits	995.657	263.287	0.282906

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	231.215	1133.765
SumBcl	54.672	4794.886	4.229169
SumTraits	54.763	4786.881	4.222109
Sum128Bcl	54.787	4784.806	4.220278
Sum128Base_Basic	720.380	363.897	0.320963
Sum128Base	54.623	4799.194	4.232969
Sum128Traits	54.825	4781.449	4.217318
Sum256Bcl	971.421	269.856	0.238018
Sum256Base_Basic	917.649	285.669	0.251965
Sum256Base	1036.594	252.890	0.223053
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1035.952	253.046	0.223191

```

