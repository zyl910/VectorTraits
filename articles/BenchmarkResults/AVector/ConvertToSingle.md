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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	160.778	1630.472
SumBcl	16.475	15912.052	9.759168
SumTraits	17.361	15099.891	9.261054

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	230.529	1137.143
SumBcl	29.669	8835.767	7.770144
SumTraits	29.776	8803.823	7.742053

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	244.349	1072.826
SumBcl	46.359	5654.595	5.270747
SumTraits	46.124	5683.478	5.297670

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	160.269	1635.654
SumBcl	560.123	468.011	0.286131
SumTraits	555.753	471.692	0.288381

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
SumScalar	163.615	1602.200
SumBcl	14.735	17789.973	11.103463
SumTraits	14.976	17503.998	10.924974

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
SumScalar	230.383	1137.861
SumBcl	30.107	8707.036	7.652106
SumTraits	29.952	8752.130	7.691737

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.642082E+14
SumScalar	247.414	1059.538
SumBcl	46.669	5617.080	5.301445
SumTraits	46.881	5591.721	5.277511

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	165.194	1586.889
SumBcl	578.407	453.217	0.285601
SumTraits	578.522	453.127	0.285545

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
SumScalar	165.743	1581.630
SumBcl	17.677	14829.621	9.376166
SumTraits	15.198	17248.952	10.905811
Sum128Base_Basic	477.770	548.682	0.346909
Sum128Base	475.186	551.666	0.348796
Sum128Traits	29.576	8863.321	5.603917
Sum256Base_Basic	272.678	961.369	0.607834
Sum256Base	273.864	957.205	0.605202
Sum256Traits	17.523	14959.577	9.458332

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	229.932	1140.093
SumBcl	30.314	8647.600	7.584994
SumTraits	30.698	8539.364	7.490058
Sum128Base_Basic	494.203	530.438	0.465259
Sum128Base	496.909	527.549	0.462725
Sum128Traits	58.834	4455.630	3.908127
Sum256Base_Basic	280.030	936.127	0.821097
Sum256Base	278.244	942.135	0.826367
Sum256Traits	29.851	8781.768	7.702675

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	233.711	1121.659
SumBcl	48.163	5442.813	4.852467
SumTraits	38.137	6873.676	6.128134
Sum128Base_Basic	536.678	488.456	0.435477
Sum128Base	537.023	488.143	0.435197
Sum128Traits	72.358	3622.898	3.229946
Sum256Base_Basic	311.644	841.164	0.749929
Sum256Base	310.254	844.933	0.753289
Sum256Traits	36.723	7138.485	6.364221

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	163.156	1606.708
SumBcl	543.200	482.592	0.300361
SumTraits	55.346	4736.492	2.947948
Sum128Base_Basic	474.359	552.628	0.343950
Sum128Base	473.866	553.203	0.344308
Sum128Traits	110.640	2369.340	1.474655
Sum256Base_Basic	268.976	974.599	0.606581
Sum256Base	269.765	971.749	0.604808
Sum256Avx2_ShiftVar	55.241	4745.426	2.953508
Sum256Avx2_Mapping	270.189	970.226	0.603860
Sum256Avx2_MappingFix	272.650	961.467	0.598408
Sum256Avx2_Mod	270.427	969.372	0.603328
Sum256Traits	56.092	4673.476	2.908727

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
SumScalar	163.231	1605.972
SumBcl	16.683	15713.241	9.784254
SumTraits	15.143	17310.808	10.779021
Sum128Base_Basic	475.596	551.191	0.343213
Sum128Base	476.285	550.393	0.342716
Sum128Traits	28.957	9052.920	5.637034
Sum256Base_Basic	281.505	931.225	0.579851
Sum256Base	283.470	924.769	0.575831
Sum256Traits	14.946	17538.951	10.921080

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	230.797	1135.822
SumBcl	30.006	8736.502	7.691785
SumTraits	29.798	8797.362	7.745367
Sum128Base_Basic	493.634	531.049	0.467546
Sum128Base	493.553	531.137	0.467623
Sum128Traits	59.119	4434.143	3.903905
Sum256Base_Basic	292.933	894.893	0.787881
Sum256Base	291.928	897.976	0.790596
Sum256Traits	29.823	8790.093	7.738968

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	236.130	1110.168
SumBcl	47.619	5505.034	4.958740
SumTraits	31.204	8400.853	7.567191
Sum128Base_Basic	537.145	488.032	0.439602
Sum128Base	534.703	490.261	0.441609
Sum128Traits	61.071	4292.422	3.866462
Sum256Base_Basic	316.732	827.653	0.745521
Sum256Base	315.504	830.873	0.748421
Sum256Traits	32.390	8093.432	7.290277

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	165.022	1588.537
SumBcl	423.434	619.091	0.389724
SumTraits	37.855	6924.970	4.359339
Sum128Base_Basic	476.592	550.039	0.346255
Sum128Base	476.199	550.492	0.346541
Sum128Traits	79.289	3306.192	2.081281
Sum256Base_Basic	284.143	922.578	0.580772
Sum256Base	282.501	927.940	0.584148
Sum256Avx2_ShiftVar	40.637	6450.934	4.060929
Sum256Avx2_Mapping	31.077	8435.306	5.310111
Sum256Avx2_MappingFix	30.597	8567.597	5.393389
Sum256Avx2_Mod	74.416	3522.688	2.217568
Sum256Traits	39.929	6565.322	4.132937

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	164.111	1597.362
SumBcl	16.870	15539.150	9.728005
SumTraits	16.720	15678.784	9.815421
Sum128Base_Basic	475.892	550.848	0.344848
Sum128Base	474.628	552.314	0.345767
Sum128Traits	29.185	8982.045	5.623048
Sum256Base_Basic	272.062	963.545	0.603210
Sum256Base	270.150	970.366	0.607480
Sum256Traits	15.238	17202.988	10.769621

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	230.708	1136.259
SumBcl	30.332	8642.586	7.606178
SumTraits	30.023	8731.443	7.684379
Sum128Base_Basic	495.045	529.536	0.466035
Sum128Base	494.480	530.141	0.466567
Sum128Traits	59.193	4428.617	3.897543
Sum256Base_Basic	282.328	928.508	0.817162
Sum256Base	282.087	929.302	0.817861
Sum256Traits	29.972	8746.321	7.697473

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	234.159	1119.513
SumBcl	47.526	5515.747	4.926917
SumTraits	31.401	8348.390	7.457162
Sum128Base_Basic	534.360	490.576	0.438204
Sum128Base	533.363	491.493	0.439024
Sum128Traits	61.357	4272.466	3.816361
Sum256Base_Basic	313.588	835.950	0.746708
Sum256Base	312.290	839.426	0.749813
Sum256Traits	31.330	8367.236	7.473996

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	165.080	1587.979
SumBcl	423.676	618.737	0.389638
SumTraits	37.363	7016.088	4.418250
Sum128Base_Basic	473.100	554.098	0.348933
Sum128Base	474.689	552.243	0.347765
Sum128Traits	72.584	3611.609	2.274343
Sum256Base_Basic	269.961	971.046	0.611498
Sum256Base	269.939	971.122	0.611546
Sum256Avx2_ShiftVar	38.407	6825.337	4.298129
Sum256Avx2_Mapping	29.945	8754.300	5.512857
Sum256Avx2_MappingFix	29.792	8799.043	5.541033
Sum256Avx2_Mod	74.042	3540.463	2.229540
Sum256Traits	37.901	6916.574	4.355583

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	161.070	1627.517
SumBcl	17.061	15365.400	9.441009
SumTraits	15.926	16459.780	10.113432
Sum128Bcl	27.665	9475.663	5.822160
Sum128Base_Basic	478.228	548.157	0.336806
Sum128Base	27.227	9628.160	5.915859
Sum128Traits	28.372	9239.582	5.677104
Sum256Bcl	14.482	18101.799	11.122342
Sum256Base_Basic	278.002	942.958	0.579385
Sum256Base	17.145	15289.747	9.394525
Sum256Traits	16.944	15471.132	9.505974

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293999E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -8.293937E+11!=-8.293999E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -8.293937E+11!=-8.293999E+11
SumScalar	230.938	1135.125
SumBcl	29.711	8823.151	7.772846
SumTraits	30.649	8553.207	7.535037
Sum128Bcl	59.585	4399.491	3.875777
Sum128Base_Basic	493.177	531.541	0.468266
Sum128Base	58.792	4458.803	3.928029
Sum128Traits	58.749	4462.123	3.930953
Sum256Bcl	30.158	8692.415	7.657673
Sum256Base_Basic	291.431	899.507	0.792430
Sum256Base	30.618	8561.804	7.542610
Sum256Traits	29.900	8767.416	7.723746

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420824E+14
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Base	Check `Sum128Base` mismatch. 5.6420764E+14!=5.6420824E+14
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5.6420764E+14!=5.6420824E+14
SumScalar	234.840	1116.269
SumBcl	30.859	8494.809	7.610003
SumTraits	31.134	8419.775	7.542785
Sum128Bcl	60.986	4298.461	3.850740
Sum128Base_Basic	534.975	490.012	0.438973
Sum128Base	61.391	4270.072	3.825308
Sum128Traits	61.608	4255.018	3.811822
Sum256Bcl	31.318	8370.505	7.498646
Sum256Base_Basic	294.719	889.470	0.796824
Sum256Base	31.806	8242.059	7.383580
Sum256Traits	31.285	8379.272	7.506500

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	161.699	1621.181
SumBcl	263.452	995.036	0.613772
SumTraits	38.121	6876.565	4.241702
Sum128Bcl	477.798	548.650	0.338426
Sum128Base_Basic	475.269	551.570	0.340228
Sum128Base	477.607	548.869	0.338561
Sum128Traits	73.483	3567.413	2.200503
Sum256Bcl	269.278	973.505	0.600492
Sum256Base_Basic	280.898	933.236	0.575652
Sum256Base	269.152	973.963	0.600774
Sum256Avx2_ShiftVar	37.556	6980.072	4.305549
Sum256Avx2_Mapping	30.891	8485.960	5.234432
Sum256Avx2_MappingFix	29.621	8850.060	5.459022
Sum256Avx2_Mod	67.468	3885.464	2.396688
Sum256Traits	38.363	6833.298	4.215013

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	161.877	1619.401
SumBcl	16.567	15823.548	9.771236
SumTraits	16.760	15641.107	9.658576
Sum128Bcl	28.950	9054.950	5.591543
Sum128Base_Basic	486.723	538.590	0.332586
Sum128Base	28.483	9203.373	5.683196
Sum128Traits	28.378	9237.710	5.704400
Sum256Bcl	16.662	15732.990	9.715315
Sum256Base_Basic	296.964	882.748	0.545108
Sum256Base	16.870	15539.190	9.595641
Sum256Traits	16.196	16186.125	9.995132
Sum512Bcl	14.033	18680.891	11.535680
Sum512Base	13.830	18954.994	11.704942
Sum512Traits	13.942	18802.445	11.610741

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
SumScalar	230.849	1135.564
SumBcl	30.041	8726.305	7.684558
SumTraits	30.049	8723.860	7.682405
Sum128Bcl	59.168	4430.521	3.901605
Sum128Base_Basic	499.326	524.995	0.462321
Sum128Base	59.503	4405.545	3.879610
Sum128Traits	59.236	4425.443	3.897133
Sum256Bcl	30.126	8701.684	7.662876
Sum256Base_Basic	307.591	852.248	0.750507
Sum256Base	30.184	8684.858	7.648058
Sum256Traits	30.156	8692.796	7.655049
Sum512Bcl	17.914	14633.152	12.886245
Sum512Base	17.432	15037.887	13.242662
Sum512Traits	17.311	15142.981	13.335210

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
SumScalar	234.004	1120.254
SumBcl	31.704	8268.436	7.380860
SumTraits	30.192	8682.619	7.750582
Sum128Bcl	61.875	4236.672	3.781886
Sum128Base_Basic	525.526	498.822	0.445276
Sum128Base	62.031	4226.030	3.772387
Sum128Traits	59.309	4419.974	3.945511
Sum256Bcl	31.888	8220.850	7.338382
Sum256Base_Basic	310.664	843.819	0.753239
Sum256Base	31.794	8245.042	7.359978
Sum256Traits	30.100	8709.060	7.774185
Sum512Bcl	149.499	1753.486	1.565258
Sum512Base	149.401	1754.635	1.566283
Sum512Traits	17.241	15204.850	13.572685

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	161.477	1623.416
SumBcl	276.827	946.961	0.583314
SumTraits	16.577	15813.891	9.741120
Sum128Bcl	1230.386	213.058	0.131241
Sum128Base_Basic	483.568	542.104	0.333928
Sum128Base	1232.984	212.609	0.130964
Sum128Traits	29.052	9023.188	5.558149
Sum256Bcl	1207.969	217.012	0.133676
Sum256Base_Basic	298.860	877.147	0.540309
Sum256Base	1209.444	216.747	0.133513
Sum256Avx2_ShiftVar	39.527	6631.958	4.085187
Sum256Avx2_Mapping	28.541	9184.928	5.657778
Sum256Avx2_MappingFix	28.793	9104.515	5.608245
Sum256Avx2_Mod	74.501	3518.656	2.167439
Sum256Traits	15.705	16691.485	10.281705
Sum512Bcl	1485.143	176.511	0.108728
Sum512Base	1478.948	177.250	0.109184
Sum512Traits	13.802	18993.104	11.699467

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	155.026	1690.973
SumBcl	38.543	6801.280	4.022111
SumTraits	38.538	6802.257	4.022689
Sum128Base_Basic	85.521	3065.254	1.812716
Sum128Base	85.540	3064.572	1.812313
Sum128Traits	38.528	6803.938	4.023683
Sum256Base_Basic	323.586	810.121	0.479086
Sum256Base	346.939	755.591	0.446838
Sum256Traits	346.645	756.232	0.447217

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	231.543	1132.160
SumBcl	56.214	4663.289	4.118931
SumTraits	56.216	4663.170	4.118825
Sum128Base_Basic	112.269	2334.961	2.062395
Sum128Base	112.211	2336.167	2.063460
Sum128Traits	57.041	4595.711	4.059241
Sum256Base_Basic	384.364	682.021	0.602406
Sum256Base	400.982	653.755	0.577440
Sum256Traits	400.987	653.747	0.577433

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	231.273	1133.484
SumBcl	56.210	4663.681	4.114465
SumTraits	57.276	4576.861	4.037870
Sum128Base_Basic	111.038	2360.858	2.082833
Sum128Base	111.173	2357.992	2.080305
Sum128Traits	57.795	4535.764	4.001613
Sum256Base_Basic	384.571	681.652	0.601378
Sum256Base	398.567	657.716	0.580260
Sum256Traits	399.086	656.861	0.579506

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	155.089	1690.286
SumBcl	236.453	1108.650	0.655895
SumTraits	38.536	6802.555	4.024500
Sum128Base_Basic	87.677	2989.871	1.768855
Sum128Base	87.776	2986.495	1.766858
Sum128Traits	38.534	6802.912	4.024711
Sum256Base_Basic	328.528	797.934	0.472071
Sum256Base	350.013	748.955	0.443093
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	350.719	747.448	0.442202

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	116.631	2247.628
SumBcl	38.521	6805.150	3.027703
SumTraits	38.527	6804.241	3.027299
Sum128Bcl	38.526	6804.317	3.027333
Sum128Base_Basic	84.913	3087.220	1.373546
Sum128Base	38.530	6803.630	3.027027
Sum128Traits	38.525	6804.548	3.027436
Sum256Bcl	289.993	903.966	0.402187
Sum256Base_Basic	292.657	895.740	0.398527
Sum256Base	323.994	809.101	0.359980
Sum256Traits	323.943	809.229	0.360037

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	231.210	1133.791
SumBcl	57.772	4537.551	4.002105
SumTraits	57.788	4536.268	4.000973
Sum128Bcl	57.778	4537.102	4.001709
Sum128Base_Basic	111.413	2352.911	2.075260
Sum128Base	57.775	4537.358	4.001935
Sum128Traits	57.775	4537.345	4.001923
Sum256Bcl	372.966	702.863	0.619923
Sum256Base_Basic	335.781	780.699	0.688574
Sum256Base	372.999	702.801	0.619868
Sum256Traits	372.976	702.845	0.619907

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	231.168	1133.997
SumBcl	57.773	4537.505	4.001337
SumTraits	57.772	4537.523	4.001353
Sum128Bcl	57.776	4537.233	4.001097
Sum128Base_Basic	109.981	2383.544	2.101896
Sum128Base	57.774	4537.410	4.001254
Sum128Traits	57.779	4536.979	4.000874
Sum256Bcl	371.847	704.977	0.621675
Sum256Base_Basic	335.180	782.099	0.689683
Sum256Base	371.776	705.113	0.621794
Sum256Traits	371.917	704.846	0.621559

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	116.599	2248.250
SumBcl	38.523	6804.827	3.026722
SumTraits	38.528	6804.004	3.026356
Sum128Bcl	38.521	6805.283	3.026925
Sum128Base_Basic	86.597	3027.167	1.346455
Sum128Base	38.537	6802.354	3.025622
Sum128Traits	38.522	6805.072	3.026831
Sum256Bcl	293.916	891.902	0.396709
Sum256Base_Basic	294.721	889.466	0.395626
Sum256Base	325.038	806.503	0.358725
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	325.035	806.510	0.358728

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	116.630	2247.655
SumBcl	38.519	6805.495	3.027821
SumTraits	38.521	6805.283	3.027726
Sum128Bcl	38.519	6805.507	3.027826
Sum128Base_Basic	85.282	3073.866	1.367588
Sum128Base	38.528	6803.913	3.027117
Sum128Traits	38.522	6805.082	3.027637
Sum256Bcl	19.268	13605.370	6.053141
Sum256Base_Basic	78.303	3347.811	1.489469
Sum256Base	19.268	13605.292	6.053106
Sum256Traits	19.268	13605.202	6.053066
Sum512Bcl	11.452	22891.207	10.184486
Sum512Base	11.453	22888.487	10.183276
Sum512Traits	11.454	22887.045	10.182634

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -8.2939596E+11!=-8.293937E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -8.2939596E+11!=-8.293937E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -8.2939596E+11!=-8.293937E+11
SumScalar	231.161	1134.031
SumBcl	57.765	4538.086	4.001729
SumTraits	57.758	4538.629	4.002208
Sum128Bcl	57.484	4560.307	4.021324
Sum128Base_Basic	111.064	2360.302	2.081337
Sum128Base	57.759	4538.604	4.002186
Sum128Traits	56.266	4658.983	4.108338
Sum256Bcl	28.878	9077.718	8.004822
Sum256Base_Basic	107.738	2433.168	2.145591
Sum256Base	28.882	9076.229	8.003509
Sum256Traits	28.881	9076.707	8.003930
Sum512Bcl	14.631	17917.218	15.799581
Sum512Base	14.634	17913.784	15.796553
Sum512Traits	14.632	17915.715	15.798256

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 5.642077E+14!=5.6420764E+14
Check-Sum512Base	Check `Sum512Base` mismatch. 5.642077E+14!=5.6420764E+14
Check-Sum512Traits	Check `Sum512Traits` mismatch. 5.642077E+14!=5.6420764E+14
SumScalar	231.141	1134.132
SumBcl	57.262	4577.987	4.036555
SumTraits	56.180	4666.118	4.114262
Sum128Bcl	56.195	4664.878	4.113170
Sum128Base_Basic	110.014	2382.817	2.101005
Sum128Base	56.187	4665.556	4.113767
Sum128Traits	56.187	4665.555	4.113766
Sum256Bcl	28.875	9078.470	8.004772
Sum256Base_Basic	107.843	2430.794	2.143307
Sum256Base	28.871	9079.887	8.006022
Sum256Traits	28.876	9078.151	8.004490
Sum512Bcl	14.473	18112.773	15.970600
Sum512Base	14.470	18116.923	15.974259
Sum512Traits	14.471	18115.681	15.973164

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	116.634	2247.575
SumBcl	38.526	6804.401	3.027441
SumTraits	38.526	6804.316	3.027403
Sum128Bcl	38.528	6804.048	3.027284
Sum128Base_Basic	87.268	3003.904	1.336509
Sum128Base	38.524	6804.732	3.027588
Sum128Traits	38.525	6804.532	3.027499
Sum256Bcl	19.276	13599.466	6.050728
Sum256Base_Basic	78.616	3334.506	1.483602
Sum256Base	19.266	13606.273	6.053756
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	19.269	13604.434	6.052938
Sum512Bcl	11.520	22755.552	10.124490
Sum512Base	11.522	22751.913	10.122871
Sum512Traits	11.524	22747.278	10.120808

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
Check-SumBcl	Check `SumBcl` mismatch. 1130044246!=1130044655
Check-SumTraits	Check `SumTraits` mismatch. 1130044246!=1130044655
SumScalar	362.818	722.522
SumBcl	67.180	3902.092	5.400659
SumTraits	63.727	4113.561	5.693341
Sum128Base_Basic	1420.638	184.526	0.255391
Sum128Base	1422.286	184.312	0.255095
Sum128Traits	1406.272	186.411	0.258000
Sum256Base_Basic	1214.830	215.787	0.298658
Sum256Base	1239.123	211.556	0.292802
Sum256Traits	1366.344	191.858	0.265540

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	323.665	809.923
SumBcl	67.943	3858.295	4.763780
SumTraits	63.190	4148.509	5.122103
Sum128Base_Basic	1419.418	184.684	0.228027
Sum128Base	1451.482	180.604	0.222990
Sum128Traits	1422.004	184.348	0.227612
Sum256Base_Basic	1214.999	215.757	0.266392
Sum256Base	1240.630	211.299	0.260888
Sum256Traits	1363.468	192.263	0.237384

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	344.657	760.595
SumBcl	64.299	4076.928	5.360185
SumTraits	67.424	3887.980	5.111763
Sum128Base_Basic	1510.971	173.494	0.228103
Sum128Base	1515.496	172.976	0.227422
Sum128Traits	1483.850	176.665	0.232272
Sum256Base_Basic	1264.617	207.291	0.272538
Sum256Base	1267.968	206.743	0.271818
Sum256Traits	1404.953	186.586	0.245315

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	365.243	717.726
SumBcl	1217.192	215.368	0.300070
SumTraits	1203.055	217.899	0.303596
Sum128Base_Basic	1388.478	188.799	0.263052
Sum128Base	1369.393	191.431	0.266719
Sum128Traits	1395.525	187.846	0.261724
Sum256Base_Basic	1198.309	218.762	0.304798
Sum256Base	1230.305	213.072	0.296871
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1340.761	195.519	0.272414

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	358.942	730.324
SumBcl	62.336	4205.337	5.758179
SumTraits	62.112	4220.478	5.778911
Sum128Base_Basic	737.629	355.387	0.486616
Sum128Base	737.300	355.546	0.486833
Sum128Traits	62.003	4227.910	5.789087
Sum256Base_Basic	886.039	295.861	0.405109
Sum256Base	927.799	282.544	0.386875
Sum256Traits	928.990	282.182	0.386379

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	317.790	824.898
SumBcl	63.344	4138.441	5.016914
SumTraits	62.930	4165.666	5.049919
Sum128Base_Basic	756.568	346.491	0.420041
Sum128Base	756.555	346.497	0.420049
Sum128Traits	62.761	4176.861	5.063491
Sum256Base_Basic	893.785	293.297	0.355555
Sum256Base	938.597	279.293	0.338580
Sum256Traits	938.340	279.370	0.338672

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	344.922	760.009
SumBcl	66.410	3947.351	5.193818
SumTraits	62.093	4221.771	5.554892
Sum128Base_Basic	822.354	318.773	0.419432
Sum128Base	822.222	318.824	0.419500
Sum128Traits	62.022	4226.620	5.561273
Sum256Base_Basic	935.438	280.236	0.368728
Sum256Base	975.241	268.799	0.353679
Sum256Traits	979.291	267.687	0.352216

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	358.790	730.633
SumBcl	811.546	323.018	0.442107
SumTraits	66.787	3925.049	5.372120
Sum128Base_Basic	736.454	355.954	0.487186
Sum128Base	736.658	355.856	0.487051
Sum128Traits	66.963	3914.757	5.358033
Sum256Base_Basic	895.167	292.844	0.400808
Sum256Base	938.973	279.182	0.382109
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	938.036	279.461	0.382491

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	355.406	737.591
SumBcl	66.409	3947.421	5.351777
SumTraits	66.279	3955.153	5.362259
Sum128Base_Basic	729.682	359.258	0.487069
Sum128Base	732.505	357.873	0.485192
Sum128Traits	62.666	4183.219	5.671463
Sum256Base_Basic	891.297	294.115	0.398751
Sum256Base	931.082	281.548	0.381713
Sum256Traits	931.521	281.415	0.381533

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	318.907	822.007
SumBcl	67.212	3900.247	4.744786
SumTraits	66.884	3919.405	4.768092
Sum128Base_Basic	749.144	349.925	0.425696
Sum128Base	750.334	349.370	0.425020
Sum128Traits	68.461	3829.111	4.658247
Sum256Base_Basic	899.845	291.321	0.354402
Sum256Base	941.980	278.290	0.338550
Sum256Traits	941.402	278.461	0.338758

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	319.160	821.357
SumBcl	61.900	4234.936	5.156021
SumTraits	62.395	4201.342	5.115121
Sum128Base_Basic	748.280	350.329	0.426524
Sum128Base	749.609	349.707	0.425768
Sum128Traits	61.956	4231.115	5.151369
Sum256Base_Basic	887.894	295.242	0.359457
Sum256Base	929.203	282.117	0.343477
Sum256Traits	928.884	282.214	0.343595

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	357.169	733.949
SumBcl	1469.505	178.389	0.243054
SumTraits	62.726	4179.172	5.694087
Sum128Base_Basic	730.032	359.086	0.489251
Sum128Base	730.487	358.862	0.488947
Sum128Traits	62.901	4167.533	5.678229
Sum256Base_Basic	900.697	291.046	0.396547
Sum256Base	943.162	277.942	0.378693
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	938.537	279.311	0.380559

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	230.537	1137.104
SumBcl	54.361	4822.279	4.240843
SumTraits	54.242	4832.863	4.250150
Sum128Bcl	54.305	4827.282	4.245242
Sum128Base_Basic	720.236	363.970	0.320085
Sum128Base	54.414	4817.546	4.236680
Sum128Traits	54.278	4829.659	4.247333
Sum256Bcl	974.447	269.018	0.236582
Sum256Base_Basic	922.704	284.104	0.249849
Sum256Base	1043.041	251.327	0.221024
Sum256Traits	1039.676	252.140	0.221739

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
SumScalar	281.586	930.955
SumBcl	53.839	4869.023	5.230139
SumTraits	54.122	4843.614	5.202846
Sum128Bcl	54.214	4835.356	5.193976
Sum128Base_Basic	735.316	356.505	0.382946
Sum128Base	54.055	4849.622	5.209299
Sum128Traits	54.077	4847.614	5.207142
Sum256Bcl	1024.113	255.972	0.274956
Sum256Base_Basic	917.406	285.745	0.306937
Sum256Base	1024.082	255.979	0.274964
Sum256Traits	1024.435	255.891	0.274870

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
SumScalar	281.580	930.976
SumBcl	54.655	4796.374	5.151983
SumTraits	54.551	4805.454	5.161737
Sum128Bcl	54.471	4812.570	5.169380
Sum128Base_Basic	734.828	356.742	0.383192
Sum128Base	54.688	4793.428	5.148819
Sum128Traits	54.564	4804.313	5.160511
Sum256Bcl	1026.340	255.416	0.274353
Sum256Base_Basic	922.258	284.241	0.305315
Sum256Base	1026.144	255.465	0.274406
Sum256Traits	1027.352	255.165	0.274083

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	230.480	1137.381
SumBcl	53.952	4858.839	4.271955
SumTraits	54.182	4838.230	4.253835
Sum128Bcl	54.029	4851.875	4.265831
Sum128Base_Basic	722.012	363.074	0.319220
Sum128Base	54.195	4837.072	4.252817
Sum128Traits	54.170	4839.253	4.254734
Sum256Bcl	970.399	270.140	0.237511
Sum256Base_Basic	921.919	284.346	0.250001
Sum256Base	1036.721	252.859	0.222317
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1037.084	252.770	0.222239

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	230.406	1137.747
SumBcl	53.707	4881.004	4.290063
SumTraits	53.815	4871.246	4.281486
Sum128Bcl	53.635	4887.528	4.295797
Sum128Base_Basic	718.879	364.657	0.320508
Sum128Base	53.676	4883.848	4.292562
Sum128Traits	53.661	4885.176	4.293730
Sum256Bcl	54.784	4785.064	4.205738
Sum256Base_Basic	402.838	650.743	0.571958
Sum256Base	54.778	4785.609	4.206217
Sum256Traits	55.026	4763.996	4.187221
Sum512Bcl	56.175	4666.568	4.101588
Sum512Base	56.081	4674.397	4.108469
Sum512Traits	56.059	4676.256	4.110103

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -8.2939596E+11!=-8.293937E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -8.2939596E+11!=-8.293937E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -8.2939596E+11!=-8.293937E+11
SumScalar	281.422	931.498
SumBcl	54.360	4822.334	5.176964
SumTraits	54.589	4802.118	5.155261
Sum128Bcl	54.327	4825.332	5.180182
Sum128Base_Basic	736.939	355.720	0.381880
Sum128Base	54.393	4819.486	5.173907
Sum128Traits	54.277	4829.707	5.184879
Sum256Bcl	55.116	4756.208	5.105975
Sum256Base_Basic	410.740	638.223	0.685157
Sum256Base	55.159	4752.557	5.102056
Sum256Traits	55.165	4751.960	5.101415
Sum512Bcl	56.558	4634.951	4.975801
Sum512Base	56.487	4640.770	4.982048
Sum512Traits	56.617	4630.138	4.970635

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 5.642077E+14!=5.6420764E+14
Check-Sum512Base	Check `Sum512Base` mismatch. 5.642077E+14!=5.6420764E+14
Check-Sum512Traits	Check `Sum512Traits` mismatch. 5.642077E+14!=5.6420764E+14
SumScalar	281.142	932.427
SumBcl	53.671	4884.294	5.238260
SumTraits	53.728	4879.066	5.232652
Sum128Bcl	53.713	4880.474	5.234163
Sum128Base_Basic	736.474	355.945	0.381740
Sum128Base	54.037	4851.230	5.202800
Sum128Traits	53.767	4875.531	5.228862
Sum256Bcl	54.840	4780.166	5.126586
Sum256Base_Basic	407.930	642.620	0.689191
Sum256Base	54.820	4781.900	5.128446
Sum256Traits	54.808	4782.957	5.129579
Sum512Bcl	56.262	4659.337	4.997001
Sum512Base	56.164	4667.502	5.005757
Sum512Traits	56.266	4658.975	4.996612

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	230.502	1137.277
SumBcl	54.226	4834.301	4.250770
SumTraits	54.274	4829.986	4.246976
Sum128Bcl	54.251	4832.099	4.248833
Sum128Base_Basic	720.194	363.991	0.320055
Sum128Base	54.302	4827.522	4.244809
Sum128Traits	54.290	4828.628	4.245781
Sum256Bcl	55.041	4762.726	4.187835
Sum256Base_Basic	406.479	644.913	0.567068
Sum256Base	55.145	4753.753	4.179945
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	55.098	4757.745	4.183454
Sum512Bcl	56.649	4627.514	4.068943
Sum512Base	56.603	4631.300	4.072272
Sum512Traits	56.686	4624.488	4.066282

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


[ConvertToInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1130044655
SumScalar	6485.417	40.421
SumBcl	4523.438	57.952	1.433736
SumTraits	1158.854	226.210	5.596404
Sum128Bcl	6569.792	39.901	0.987157
Sum128Base_Basic	2666.927	98.294	2.431794
Sum128Base	6601.042	39.713	0.982484
Sum128Traits	1227.214	213.609	5.284668
Sum256Bcl	7539.583	34.769	0.860182
Sum256Base_Basic	2531.510	103.552	2.561876
Sum256Base	7552.604	34.709	0.858699
Sum256Traits	7550.000	34.721	0.858996
Sum512Bcl	14509.375	18.067	0.446981
Sum512Base	14392.708	18.214	0.450604
Sum512Traits	14779.167	17.737	0.438822

[ConvertToSingleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-8.29399E+11
# SumBcl	-8.293937E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -8.293999E+11!=-8.293937E+11
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -8.2939596E+11!=-8.293937E+11
Check-Sum512Base	Check `Sum512Base` mismatch. -8.2939596E+11!=-8.293937E+11
Check-Sum512Traits	Check `Sum512Traits` mismatch. -8.2939596E+11!=-8.293937E+11
SumScalar	5653.646	46.367
SumBcl	3673.177	71.367	1.539171
SumTraits	1103.385	237.582	5.123908
Sum128Bcl	5527.083	47.429	1.022899
Sum128Base_Basic	2153.125	121.750	2.625786
Sum128Base	5644.271	46.444	1.001661
Sum128Traits	1064.714	246.211	5.310016
Sum256Bcl	7165.104	36.586	0.789053
Sum256Base_Basic	2022.917	129.587	2.794799
Sum256Base	6823.958	38.415	0.828499
Sum256Traits	7623.958	34.384	0.741563
Sum512Bcl	10975.000	23.886	0.515139
Sum512Base	11555.208	22.686	0.489273
Sum512Traits	11297.917	23.203	0.500415

[ConvertToSingleBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5.642155E+14
# SumBcl	5.6420764E+14
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Base	Check `Sum256Base` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5.6420824E+14!=5.6420764E+14
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 5.642077E+14!=5.6420764E+14
Check-Sum512Base	Check `Sum512Base` mismatch. 5.642077E+14!=5.6420764E+14
Check-Sum512Traits	Check `Sum512Traits` mismatch. 5.642077E+14!=5.6420764E+14
SumScalar	6988.021	37.513
SumBcl	9208.333	28.468	0.758880
SumTraits	1144.661	229.014	6.104880
Sum128Bcl	8342.708	31.422	0.837620
Sum128Base_Basic	2606.510	100.573	2.680987
Sum128Base	8443.750	31.046	0.827597
Sum128Traits	1058.464	247.665	6.602042
Sum256Bcl	16981.250	15.437	0.411514
Sum256Base_Basic	2385.677	109.882	2.929156
Sum256Base	17110.417	15.321	0.408407
Sum256Traits	19568.750	13.396	0.357101
Sum512Bcl	21987.500	11.922	0.317818
Sum512Base	22283.333	11.764	0.313599
Sum512Traits	22912.500	11.441	0.304987

[ConvertToUInt32Benchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1129967050
SumScalar	7040.104	37.236
SumBcl	16189.583	16.192	0.434854
SumTraits	1070.443	244.893	6.576815
Sum128Bcl	23091.667	11.352	0.304876
Sum128Base_Basic	9100.000	28.807	0.773638
Sum128Base	24725.000	10.602	0.284736
Sum128Traits	1035.026	253.273	6.801862
Sum256Bcl	32195.833	8.142	0.218665
Sum256Base_Basic	12813.542	20.458	0.549427
Sum256Base	32570.833	8.048	0.216147
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mapping	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_MappingFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Mod	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	38058.333	6.888	0.184982
Sum512Bcl	38341.667	6.837	0.183615
Sum512Base	39704.167	6.602	0.177314
Sum512Traits	41520.833	6.314	0.169556

```

