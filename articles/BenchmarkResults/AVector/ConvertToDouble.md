# Benchmark - ConvertToDouble
([← Back](README.md))

See [Group](ConvertToDouble_Group.md)

- `ConvertToDouble[/_Range52]`: Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量).
  Mnemonic: `rt[i] := (Double)(value[i])` .
- `ConvertToInt64[/_Range52/Range52RoundToEven]`: Convert to a vector whose elements are of type Int64 (转换为元素类型是Int64的向量).
  Mnemonic: `rt[i] := (Int64)(value[i])` .
- `ConvertToUInt64[/_Range52/Range52RoundToEven]`: Convert to a vector whose elements are of type UInt64 (转换为元素类型是UInt64的向量).
  Mnemonic: `rt[i] := (UInt64)(value[i])` .

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
SumScalar	230.265	1138.444
SumBcl	135.521	1934.338	1.699108
SumBase_Range52_Impl	57.830	4533.026	3.981775
SumTraits	136.040	1926.957	1.692624
SumTraits_Range52	136.393	1921.972	1.688245

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	764.357	342.960
SumBcl	107.417	2440.437	7.115800
SumBase_Range52_Impl	57.721	4541.583	13.242297
SumTraits	107.617	2435.887	7.102532
SumTraits_Range52	107.269	2443.793	7.125583

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	155.429	1686.589
SumBcl	136.148	1925.438	1.141617
SumBase_Range52_Impl	117.435	2232.246	1.323527
SumBase_Range52RoundToEven	27.765	9441.514	5.597994
SumTraits	136.892	1914.970	1.135410
SumTraits_Range52	137.532	1906.062	1.130129
SumTraits_Range52RoundToEven	28.155	9310.763	5.520470

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	929.911	281.902
SumBcl	1453.953	180.297	0.639575
SumBase_Range52_Impl	123.199	2127.815	7.548060
SumBase_Range52RoundToEven	30.554	8579.765	30.435252
SumTraits	1434.140	182.788	0.648410
SumTraits_Range52	121.163	2163.568	7.674888
SumTraits_Range52RoundToEven	31.275	8381.893	29.733335

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
SumScalar	229.793	1140.781
SumBcl	135.551	1933.921	1.695260
SumBase_Range52_Impl	58.395	4489.142	3.935147
SumTraits	135.519	1934.373	1.695657
SumTraits_Range52	136.031	1927.089	1.689271

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	736.743	355.815
SumBcl	107.383	2441.213	6.860912
SumBase_Range52_Impl	58.207	4503.627	12.657227
SumTraits	107.134	2446.883	6.876846
SumTraits_Range52	107.333	2442.342	6.864084

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	155.533	1685.452
SumBcl	136.755	1916.891	1.137315
SumBase_Range52_Impl	123.564	2121.532	1.258732
SumBase_Range52RoundToEven	30.342	8639.733	5.126062
SumTraits	137.236	1910.166	1.133325
SumTraits_Range52	136.553	1919.728	1.138998
SumTraits_Range52RoundToEven	30.439	8612.012	5.109615

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	926.684	282.884
SumBcl	1442.305	181.754	0.642502
SumBase_Range52_Impl	120.509	2175.306	7.689750
SumBase_Range52RoundToEven	30.213	8676.588	30.671903
SumTraits	1431.845	183.081	0.647196
SumTraits_Range52	121.011	2166.284	7.657855
SumTraits_Range52RoundToEven	31.454	8334.109	29.461233

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	229.157	1143.950
SumBcl	135.909	1928.814	1.686100
SumBase_Range52_Impl	57.771	4537.669	3.966668
SumTraits	65.162	4022.955	3.516724
SumTraits_Range52	57.618	4549.683	3.977170
Sum128Base_Basic	945.932	277.128	0.242255
Sum128Base	944.103	277.665	0.242724
Sum128Base_Range52_Impl	942.391	278.169	0.243165
Sum128Traits	129.810	2019.439	1.765321
Sum128Traits_Range52	115.237	2274.828	1.988573
Sum256Base_Basic	523.580	500.676	0.437673
Sum256Base	524.876	499.439	0.436592
Sum256Base_Range52_Impl	524.986	499.335	0.436501
Sum256Avx2_Bcl	65.313	4013.659	3.508597
Sum256Avx2_HwScalar	139.724	1876.157	1.640070
Sum256Avx2_Range52	57.636	4548.249	3.975917
Sum256Traits	65.706	3989.629	3.487591
Sum256Traits_Range52	57.884	4528.751	3.958872

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	696.388	376.434
SumBcl	106.914	2451.923	6.513555
SumBase_Range52_Impl	57.577	4552.910	12.094845
SumTraits	64.804	4045.208	10.746130
SumTraits_Range52	57.572	4553.320	12.095936
Sum128Base_Basic	1071.854	244.571	0.649704
Sum128Base	1076.185	243.586	0.647090
Sum128Base_Range52_Impl	1076.073	243.612	0.647157
Sum128Traits	128.802	2035.247	5.406651
Sum128Traits_Range52	115.123	2277.079	6.049082
Sum256Base_Basic	913.298	287.030	0.762498
Sum256Base	933.314	280.874	0.746145
Sum256Base_Range52_Impl	943.930	277.716	0.737754
Sum256Avx2_Bcl	64.731	4049.748	10.758192
Sum256Avx2_Range52	57.888	4528.439	12.029840
Sum256Traits	65.170	4022.442	10.685653
Sum256Traits_Range52	57.719	4541.720	12.065120

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	154.106	1701.064
SumBcl	135.665	1932.284	1.135926
SumBase_Range52_Impl	113.078	2318.249	1.362823
SumBase_Range52RoundToEven	30.102	8708.561	5.119478
SumTraits	115.226	2275.043	1.337423
SumTraits_Range52	36.198	7241.949	4.257304
SumTraits_Range52RoundToEven	32.328	8108.759	4.766873
Sum128Base_Basic	917.816	285.617	0.167905
Sum128Base	920.654	284.737	0.167387
Sum128Base_Range52_Impl	925.275	283.315	0.166551
Sum128Traits	230.743	1136.089	0.667869
Sum128Traits_Range52	68.334	3836.194	2.255173
Sum128Traits_Range52RoundToEven	61.605	4255.224	2.501506
Sum256Base_Basic	510.751	513.252	0.301724
Sum256Base	508.243	515.785	0.303213
Sum256Base_Range52_Impl	514.625	509.388	0.299453
Sum256Avx2_HwScalar	139.699	1876.493	1.103128
Sum256Avx2_ShiftVar	97.800	2680.412	1.575726
Sum256Avx2_ShiftVarFix	121.243	2162.145	1.271054
Sum256Avx2_Range52	36.719	7139.139	4.196866
Sum256Traits	116.855	2243.320	1.318774
Sum256Traits_Range52	36.276	7226.366	4.248144
Sum256Traits_Range52RoundToEven	31.693	8271.301	4.862427

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	945.958	277.120
SumBcl	1464.228	179.032	0.646045
SumBase_Range52_Impl	104.948	2497.841	9.013564
SumBase_Range52RoundToEven	31.080	8434.515	30.436300
SumTraits	75.826	3457.159	12.475302
SumTraits_Range52	36.658	7151.099	25.805041
SumTraits_Range52RoundToEven	32.064	8175.679	29.502282
Sum128Base_Basic	1097.148	238.932	0.862197
Sum128Base	1117.391	234.604	0.846577
Sum128Base_Range52_Impl	1109.317	236.311	0.852739
Sum128Traits	145.044	1807.336	6.521849
Sum128Traits_Range52	69.407	3776.921	13.629179
Sum128Traits_Range52RoundToEven	61.889	4235.694	15.284680
Sum256Base_Basic	1074.860	243.887	0.880075
Sum256Base	1084.270	241.770	0.872437
Sum256Base_Range52_Impl	1082.750	242.110	0.873662
Sum256Avx2_ShiftVar	77.734	3372.327	12.169185
Sum256Avx2_Range52	36.833	7117.178	25.682635
Sum256Traits	75.837	3456.659	12.473500
Sum256Traits_Range52	36.243	7233.026	26.100677
Sum256Traits_Range52RoundToEven	31.989	8194.918	29.571704

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	230.200	1138.764
SumBcl	155.553	1685.240	1.479885
SumBase_Range52_Impl	58.887	4451.636	3.909182
SumTraits	63.066	4156.669	3.650158
SumTraits_Range52	58.978	4444.779	3.903160
Sum128Base_Basic	938.599	279.293	0.245260
Sum128Base	939.182	279.119	0.245107
Sum128Base_Range52_Impl	941.364	278.472	0.244539
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	123.860	2116.450	1.858550
Sum128Traits_Range52	116.083	2258.244	1.983066
Sum256Base_Basic	531.806	492.932	0.432865
Sum256Base	533.255	491.592	0.431689
Sum256Base_Range52_Impl	530.163	494.460	0.434207
Sum256Avx2_Bcl	63.089	4155.141	3.648816
Sum256Avx2_HwScalar	161.439	1623.796	1.425928
Sum256Avx2_Range52	59.059	4438.676	3.897800
Sum256Traits	62.778	4175.759	3.666921
Sum256Traits_Range52	58.832	4455.823	3.912859

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	711.831	368.267
SumBcl	117.399	2232.930	6.063342
SumBase_Range52_Impl	58.895	4451.013	12.086370
SumTraits	59.694	4391.472	11.924691
SumTraits_Range52	57.593	4551.672	12.359702
Sum128Base_Basic	1061.840	246.877	0.670375
Sum128Base	1057.743	247.833	0.672972
Sum128Base_Range52_Impl	1066.611	245.773	0.667376
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	116.203	2255.907	6.125734
Sum128Traits_Range52	115.150	2276.539	6.181760
Sum256Base_Basic	958.487	273.498	0.742661
Sum256Base	960.304	272.980	0.741256
Sum256Base_Range52_Impl	961.777	272.562	0.740121
Sum256Avx2_Bcl	58.754	4461.747	12.115516
Sum256Avx2_Range52	57.598	4551.289	12.358662
Sum256Traits	58.601	4473.361	12.147054
Sum256Traits_Range52	57.656	4546.655	12.346079

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	155.525	1685.543
SumBcl	137.683	1903.965	1.129586
SumBase_Range52_Impl	52.231	5018.954	2.977649
SumBase_Range52RoundToEven	30.236	8669.821	5.143638
SumTraits	95.298	2750.794	1.631993
SumTraits_Range52	33.183	7900.015	4.686927
SumTraits_Range52RoundToEven	30.776	8517.762	5.053425
Sum128Base_Basic	892.149	293.834	0.174326
Sum128Base	891.605	294.014	0.174433
Sum128Base_Range52_Impl	887.824	295.266	0.175175
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	187.972	1394.592	0.827384
Sum128Traits_Range52	62.583	4188.773	2.485119
Sum128Traits_Range52RoundToEven	52.694	4974.833	2.951473
Sum256Base_Basic	496.229	528.273	0.313414
Sum256Base	494.310	530.323	0.314631
Sum256Base_Range52_Impl	490.974	533.926	0.316768
Sum256Avx2_HwScalar	142.109	1844.663	1.094403
Sum256Avx2_ShiftVar	84.524	3101.406	1.840005
Sum256Avx2_ShiftVarFix	95.249	2752.211	1.632834
Sum256Avx2_Range52	33.302	7871.662	4.670106
Sum256Traits	95.566	2743.078	1.627416
Sum256Traits_Range52	34.182	7669.011	4.549877
Sum256Traits_Range52RoundToEven	30.850	8497.507	5.041408

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	940.048	278.862
SumBcl	1281.041	204.634	0.733816
SumBase_Range52_Impl	51.689	5071.594	18.186727
SumBase_Range52RoundToEven	27.776	9437.802	33.843944
SumTraits	62.989	4161.721	14.923924
SumTraits_Range52	31.452	8334.830	29.888687
SumTraits_Range52RoundToEven	27.779	9436.677	33.839909
Sum128Base_Basic	1088.978	240.725	0.863239
Sum128Base	1089.892	240.523	0.862514
Sum128Base_Range52_Impl	1091.843	240.093	0.860973
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	123.974	2114.501	7.582598
Sum128Traits_Range52	61.434	4267.074	15.301722
Sum128Traits_Range52RoundToEven	53.449	4904.586	17.587838
Sum256Base_Basic	1034.010	253.522	0.909128
Sum256Base	1039.378	252.212	0.904433
Sum256Base_Range52_Impl	1038.667	252.385	0.905052
Sum256Avx2_ShiftVar	63.708	4114.780	14.755595
Sum256Avx2_Range52	31.081	8434.193	30.245004
Sum256Traits	63.799	4108.900	14.734509
Sum256Traits_Range52	31.658	8280.396	29.693486
Sum256Traits_Range52RoundToEven	27.210	9634.085	34.547814

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	230.052	1139.498
SumBcl	154.317	1698.735	1.490774
SumBase_Range52_Impl	57.924	4525.662	3.971627
SumTraits	58.240	4501.129	3.950097
SumTraits_Range52	57.695	4543.591	3.987361
Sum128Base_Basic	928.481	282.337	0.247773
Sum128Base	925.496	283.247	0.248572
Sum128Base_Range52_Impl	924.409	283.580	0.248864
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	115.112	2277.298	1.998509
Sum128Traits_Range52	115.400	2271.610	1.993518
Sum256Base_Basic	527.603	496.859	0.436033
Sum256Base	513.994	510.014	0.447578
Sum256Base_Range52_Impl	526.552	497.850	0.436903
Sum256Avx2_Bcl	57.879	4529.182	3.974716
Sum256Avx2_HwScalar	140.064	1871.604	1.642481
Sum256Avx2_Range52	57.758	4538.685	3.983055
Sum256Traits	57.945	4524.022	3.970187
Sum256Traits_Range52	57.878	4529.272	3.974794

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	696.932	376.140
SumBcl	105.609	2482.220	6.599193
SumBase_Range52_Impl	57.697	4543.482	12.079235
SumTraits	58.040	4516.611	12.007795
SumTraits_Range52	57.727	4541.076	12.072838
Sum128Base_Basic	1026.118	255.472	0.679193
Sum128Base	1050.545	249.531	0.663401
Sum128Base_Range52_Impl	1029.328	254.675	0.677075
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	115.641	2266.887	6.026712
Sum128Traits_Range52	115.131	2276.919	6.053383
Sum256Base_Basic	958.199	273.580	0.727336
Sum256Base	963.090	272.191	0.723642
Sum256Base_Range52_Impl	958.079	273.614	0.727426
Sum256Avx2_Bcl	57.901	4527.462	12.036645
Sum256Avx2_Range52	57.590	4551.863	12.101516
Sum256Traits	57.908	4526.926	12.035221
Sum256Traits_Range52	57.605	4550.725	12.098492

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	154.427	1697.523
SumBcl	136.400	1921.880	1.132167
SumBase_Range52_Impl	51.057	5134.342	3.024608
SumBase_Range52RoundToEven	39.458	6643.614	3.913711
SumTraits	87.855	2983.825	1.757752
SumTraits_Range52	30.359	8634.906	5.086769
SumTraits_Range52RoundToEven	28.156	9310.375	5.484683
Sum128Base_Basic	889.316	294.770	0.173647
Sum128Base	889.520	294.703	0.173608
Sum128Base_Range52_Impl	886.679	295.647	0.174164
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	177.426	1477.486	0.870378
Sum128Traits_Range52	60.028	4367.050	2.572602
Sum128Traits_Range52RoundToEven	55.507	4722.728	2.782129
Sum256Base_Basic	492.561	532.206	0.313519
Sum256Base	491.830	532.997	0.313985
Sum256Base_Range52_Impl	492.827	531.918	0.313350
Sum256Avx2_HwScalar	142.044	1845.513	1.087180
Sum256Avx2_ShiftVar	76.939	3407.149	2.007130
Sum256Avx2_ShiftVarFix	92.229	2842.314	1.674389
Sum256Avx2_Range52	33.685	7782.212	4.584452
Sum256Traits	91.913	2852.083	1.680144
Sum256Traits_Range52	34.769	7539.603	4.441533
Sum256Traits_Range52RoundToEven	29.103	9007.409	5.306208

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	1006.620	260.420
SumBcl	1279.872	204.821	0.786500
SumBase_Range52_Impl	51.001	5140.013	19.737388
SumBase_Range52RoundToEven	28.186	9300.624	35.713926
SumTraits	59.596	4398.711	16.890827
SumTraits_Range52	30.621	8560.839	32.873188
SumTraits_Range52RoundToEven	27.029	9698.790	37.242862
Sum128Base_Basic	1073.320	244.237	0.937856
Sum128Base	1086.344	241.309	0.926612
Sum128Base_Range52_Impl	1082.129	242.248	0.930222
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	118.199	2217.814	8.516294
Sum128Traits_Range52	60.753	4314.879	16.568918
Sum128Traits_Range52RoundToEven	52.256	5016.537	19.263247
Sum256Base_Basic	1040.915	251.840	0.967053
Sum256Base	1036.759	252.850	0.970929
Sum256Base_Range52_Impl	1034.875	253.310	0.972697
Sum256Avx2_ShiftVar	59.732	4388.663	16.852243
Sum256Avx2_Range52	30.329	8643.214	33.189502
Sum256Traits	60.089	4362.568	16.752042
Sum256Traits_Range52	31.168	8410.638	32.296422
Sum256Traits_Range52RoundToEven	26.591	9858.356	37.855587

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	229.759	1140.953
SumBcl	57.978	4521.407	3.962834
SumBase_Range52_Impl	57.739	4540.127	3.979242
SumTraits	58.087	4512.957	3.955428
SumTraits_Range52	58.259	4499.654	3.943769
Sum128Bcl	116.184	2256.280	1.977540
Sum128Base_Basic	921.224	284.561	0.249406
Sum128Base	115.927	2261.278	1.981921
Sum128Base_Range52_Impl	115.292	2273.731	1.992835
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	115.469	2270.245	1.989779
Sum128Traits_Range52	115.240	2274.766	1.993742
Sum256Bcl	58.148	4508.197	3.951256
Sum256Base_Basic	503.077	521.081	0.456707
Sum256Base	58.029	4517.434	3.959352
Sum256Base_Range52_Impl	57.922	4525.810	3.966694
Sum256Avx2_Bcl	57.939	4524.484	3.965531
Sum256Avx2_HwScalar	138.442	1893.533	1.659606
Sum256Avx2_Range52	57.792	4535.967	3.975596
Sum256Traits	57.972	4521.902	3.963268
Sum256Traits_Range52	58.060	4515.019	3.957236

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	652.915	401.498
SumBcl	58.163	4507.073	11.225643
SumBase_Range52_Impl	57.833	4532.752	11.289599
SumTraits	58.023	4517.897	11.252602
SumTraits_Range52	57.930	4525.217	11.270833
Sum128Bcl	115.571	2268.241	5.649445
Sum128Base_Basic	1020.609	256.851	0.639731
Sum128Base	115.490	2269.838	5.653422
Sum128Base_Range52_Impl	115.259	2274.388	5.664757
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	116.005	2259.766	5.628338
Sum128Traits_Range52	114.918	2281.149	5.681596
Sum256Bcl	58.209	4503.481	11.216697
Sum256Base_Basic	943.320	277.895	0.692145
Sum256Base	58.036	4516.933	11.250201
Sum256Base_Range52_Impl	58.098	4512.092	11.238143
Sum256Avx2_Bcl	58.124	4510.109	11.233205
Sum256Avx2_Range52	57.790	4536.115	11.297978
Sum256Traits	58.049	4515.935	11.247716
Sum256Traits_Range52	57.969	4522.134	11.263154

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	154.420	1697.609
SumBcl	494.432	530.193	0.312317
SumBase_Range52_Impl	50.853	5154.901	3.036566
SumBase_Range52RoundToEven	28.152	9311.873	5.485288
SumTraits	86.908	3016.332	1.776812
SumTraits_Range52	38.084	6883.374	4.054747
SumTraits_Range52RoundToEven	37.738	6946.488	4.091925
Sum128Bcl	881.242	297.471	0.175230
Sum128Base_Basic	881.716	297.311	0.175135
Sum128Base	885.987	295.878	0.174291
Sum128Base_Range52_Impl	99.284	2640.338	1.555328
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	168.890	1552.154	0.914318
Sum128Traits_Range52	60.631	4323.631	2.546895
Sum128Traits_Range52RoundToEven	60.634	4323.357	2.546734
Sum256Bcl	469.931	557.835	0.328600
Sum256Base_Basic	479.505	546.697	0.322039
Sum256Base	470.800	556.805	0.327994
Sum256Base_Range52_Impl	58.211	4503.338	2.652754
Sum256Avx2_HwScalar	140.367	1867.557	1.100111
Sum256Avx2_ShiftVar	74.812	3504.040	2.064103
Sum256Avx2_ShiftVarFix	86.005	3048.020	1.795478
Sum256Avx2_Range52	37.444	7000.910	4.123983
Sum256Traits	86.152	3042.818	1.792414
Sum256Traits_Range52	37.208	7045.454	4.150222
Sum256Traits_Range52RoundToEven	37.303	7027.437	4.139610

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	922.005	284.320
SumBcl	1045.205	250.806	0.882128
SumBase_Range52_Impl	51.870	5053.825	17.775157
SumBase_Range52RoundToEven	27.326	9593.175	33.740819
SumTraits	59.971	4371.170	15.374143
SumTraits_Range52	37.907	6915.502	24.322993
SumTraits_Range52RoundToEven	38.309	6842.850	24.067462
Sum128Bcl	1089.071	240.704	0.846597
Sum128Base_Basic	1085.032	241.600	0.849749
Sum128Base	1085.153	241.573	0.849655
Sum128Base_Range52_Impl	108.124	2424.486	8.527326
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	119.246	2198.340	7.731936
Sum128Traits_Range52	67.823	3865.102	13.594220
Sum128Traits_Range52RoundToEven	68.325	3836.730	13.494428
Sum256Bcl	1033.341	253.686	0.892256
Sum256Base_Basic	1023.931	256.017	0.900456
Sum256Base	1035.972	253.041	0.889990
Sum256Base_Range52_Impl	58.689	4466.694	15.710120
Sum256Avx2_ShiftVar	60.186	4355.559	15.319239
Sum256Avx2_Range52	37.951	6907.521	24.294921
Sum256Traits	60.298	4347.480	15.290822
Sum256Traits_Range52	38.058	6888.081	24.226546
Sum256Traits_Range52RoundToEven	38.012	6896.434	24.255924

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.2591633287830233E+21!=-3.259163328783021E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -3.2591633287830233E+21!=-3.259163328783021E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.2591633287830233E+21!=-3.259163328783021E+21
SumScalar	231.891	1130.463
SumBcl	59.946	4373.005	3.868330
SumBase_Range52_Impl	59.661	4393.920	3.886831
SumTraits	59.284	4421.854	3.911542
SumTraits_Range52	59.102	4435.418	3.923540
Sum128Bcl	120.439	2176.571	1.925379
Sum128Base_Basic	948.741	276.307	0.244419
Sum128Base	119.492	2193.823	1.940641
Sum128Base_Range52_Impl	118.355	2214.893	1.959279
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	117.598	2229.157	1.971897
Sum128Traits_Range52	116.674	2246.803	1.987506
Sum256Bcl	60.984	4298.594	3.802506
Sum256Base_Basic	522.723	501.497	0.443620
Sum256Base	61.371	4271.482	3.778523
Sum256Base_Range52_Impl	60.011	4368.276	3.864147
Sum256Avx2_Bcl	60.890	4305.189	3.808340
Sum256Avx2_HwScalar	155.081	1690.363	1.495284
Sum256Avx2_Range52	58.969	4445.433	3.932400
Sum256Traits	58.897	4450.920	3.937253
Sum256Traits_Range52	58.788	4459.112	3.944499
Sum512Bcl	298.608	877.886	0.776572
Sum512Base	296.713	883.493	0.781532
Sum512Traits	34.090	7689.859	6.802396

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 3.6258241385243226E+24!=3.625824138524307E+24
Check-Sum512Base	Check `Sum512Base` mismatch. 3.6258241385243226E+24!=3.625824138524307E+24
Check-Sum512Traits	Check `Sum512Traits` mismatch. 3.6258241385243226E+24!=3.625824138524307E+24
SumScalar	246.161	1064.929
SumBcl	60.607	4325.317	4.061602
SumBase_Range52_Impl	59.255	4423.973	4.154243
SumTraits	59.173	4430.156	4.160049
SumTraits_Range52	59.170	4430.344	4.160225
Sum128Bcl	119.568	2192.423	2.058751
Sum128Base_Basic	986.192	265.814	0.249608
Sum128Base	119.246	2198.349	2.064316
Sum128Base_Range52_Impl	116.762	2245.113	2.108228
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	116.298	2254.070	2.116639
Sum128Traits_Range52	116.779	2244.781	2.107917
Sum256Bcl	60.685	4319.733	4.056359
Sum256Base_Basic	519.919	504.202	0.473460
Sum256Base	60.620	4324.356	4.060699
Sum256Base_Range52_Impl	59.310	4419.893	4.150412
Sum256Avx2_Bcl	58.502	4480.942	4.207739
Sum256Avx2_Range52	58.091	4512.654	4.237518
Sum256Traits	58.090	4512.733	4.237592
Sum256Traits_Range52	57.677	4545.035	4.267924
Sum512Bcl	305.896	856.972	0.804723
Sum512Base	304.363	861.286	0.808774
Sum512Traits	33.311	7869.563	7.389756

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
SumScalar	155.175	1689.345
SumBcl	471.049	556.512	0.329424
SumBase_Range52_Impl	57.738	4540.258	2.687584
SumBase_Range52RoundToEven	37.296	7028.739	4.160629
SumTraits	24.594	10659.038	6.309567
SumTraits_Range52	24.615	10649.565	6.303959
SumTraits_Range52RoundToEven	24.216	10825.391	6.408039
Sum128Bcl	972.887	269.450	0.159499
Sum128Base_Basic	896.903	292.277	0.173012
Sum128Base	966.640	271.191	0.160530
Sum128Base_Range52_Impl	104.992	2496.809	1.477974
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	47.644	5502.115	3.256951
Sum128Traits_Range52	48.374	5419.148	3.207839
Sum128Traits_Range52RoundToEven	47.797	5484.520	3.246536
Sum256Bcl	931.387	281.455	0.166606
Sum256Base_Basic	486.386	538.963	0.319036
Sum256Base	934.798	280.428	0.165998
Sum256Base_Range52_Impl	57.458	4562.319	2.700643
Sum256Avx2_HwScalar	137.383	1908.132	1.129510
Sum256Avx2_ShiftVar	78.850	3324.585	1.967972
Sum256Avx2_ShiftVarFix	90.735	2889.109	1.710194
Sum256Avx2_Range52	24.401	10743.179	6.359374
Sum256Traits	24.411	10738.964	6.356879
Sum256Traits_Range52	24.430	10730.291	6.351745
Sum256Traits_Range52RoundToEven	24.479	10708.991	6.339137
Sum512Bcl	1397.309	187.606	0.111053
Sum512Base	1410.190	185.893	0.110038
Sum512Traits	24.556	10675.313	6.319201

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
SumScalar	1058.654	247.620
SumBcl	1094.849	239.434	0.966940
SumBase_Range52_Impl	66.314	3953.101	15.964374
SumBase_Range52RoundToEven	41.791	6272.667	25.331805
SumTraits	31.071	8437.045	34.072523
SumTraits_Range52	31.150	8415.470	33.985391
SumTraits_Range52RoundToEven	30.922	8477.641	34.236467
Sum128Bcl	1382.625	189.599	0.765684
Sum128Base_Basic	1112.710	235.590	0.951419
Sum128Base	1390.086	188.581	0.761574
Sum128Base_Range52_Impl	99.697	2629.407	10.618708
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	47.412	5529.105	22.328973
Sum128Traits_Range52	47.315	5540.372	22.374477
Sum128Traits_Range52RoundToEven	47.524	5516.031	22.276174
Sum256Bcl	1440.915	181.929	0.734709
Sum256Base_Basic	1100.064	238.299	0.962356
Sum256Base	1447.245	181.133	0.731496
Sum256Base_Range52_Impl	57.435	4564.197	18.432247
Sum256Avx2_ShiftVar	60.195	4354.901	17.587020
Sum256Avx2_Range52	24.343	10768.982	43.489917
Sum256Traits	24.378	10753.217	43.426248
Sum256Traits_Range52	24.553	10676.618	43.116912
Sum256Traits_Range52RoundToEven	24.303	10786.304	43.559872
Sum512Bcl	2015.887	130.039	0.525155
Sum512Base	2013.953	130.164	0.525659
Sum512Traits	24.456	10719.165	43.288734

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
SumScalar	367.037	714.217
SumBcl	245.204	1069.087	1.496865
SumBase_Range52_Impl	92.075	2847.061	3.986268
SumTraits	233.909	1120.710	1.569145
SumTraits_Range52	237.504	1103.745	1.545392

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	812.277	322.727
SumBcl	128.745	2036.146	6.309184
SumBase_Range52_Impl	91.434	2867.041	8.883788
SumTraits	133.239	1967.466	6.096373
SumTraits_Range52	163.124	1607.021	4.979500

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	248.654	1054.250
SumBcl	269.138	974.012	0.923891
SumBase_Range52_Impl	253.787	1032.931	0.979778
SumBase_Range52RoundToEven	87.503	2995.845	2.841684
SumTraits	247.228	1060.334	1.005771
SumTraits_Range52	251.539	1042.162	0.988534
SumTraits_Range52RoundToEven	78.951	3320.321	3.149463

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	1276.219	205.407
SumBcl	1865.933	140.489	0.683957
SumBase_Range52_Impl	241.929	1083.559	5.275186
SumBase_Range52RoundToEven	100.852	2599.294	12.654375
SumTraits	1904.324	137.657	0.670169
SumTraits_Range52	231.371	1133.001	5.515889
SumTraits_Range52RoundToEven	92.468	2834.962	13.801699

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
SumScalar	309.976	845.692
SumBcl	195.175	1343.119	1.588189
SumBase_Range52_Impl	77.922	3364.195	3.978037
SumTraits	195.484	1341.000	1.585683
SumTraits_Range52	196.730	1332.506	1.575639

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	694.909	377.235
SumBcl	102.550	2556.260	6.776310
SumBase_Range52_Impl	77.766	3370.946	8.935933
SumTraits	103.040	2544.092	6.744052
SumTraits_Range52	135.978	1927.839	5.110447

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	158.046	1658.661
SumBcl	197.847	1324.984	0.798828
SumBase_Range52_Impl	168.977	1551.359	0.935308
SumBase_Range52RoundToEven	71.307	3676.266	2.216406
SumTraits	198.401	1321.285	0.796597
SumTraits_Range52	198.268	1322.172	0.797132
SumTraits_Range52RoundToEven	70.819	3701.596	2.231677

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	929.429	282.048
SumBcl	1398.126	187.497	0.664768
SumBase_Range52_Impl	162.172	1616.455	5.731127
SumBase_Range52RoundToEven	52.664	4977.686	17.648342
SumTraits	1392.883	188.202	0.667270
SumTraits_Range52	162.039	1617.783	5.735837
SumTraits_Range52RoundToEven	56.899	4607.170	16.334683

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	310.523	844.201
SumBcl	195.318	1342.139	1.589835
SumBase_Range52_Impl	77.922	3364.185	3.985054
SumTraits	96.650	2712.295	3.212857
SumTraits_Range52	78.111	3356.046	3.975412
Sum128Base_Basic	892.442	293.738	0.347948
Sum128Base	891.295	294.116	0.348396
Sum128Base_Range52_Impl	891.285	294.119	0.348399
Sum128Traits	166.898	1570.683	1.860557
Sum128Traits_Range52	155.272	1688.289	1.999867
Sum256Base_Basic	504.475	519.638	0.615538
Sum256Base	504.574	519.536	0.615417
Sum256Base_Range52_Impl	506.796	517.258	0.612719
Sum256Avx2_Bcl	95.760	2737.511	3.242726
Sum256Avx2_HwScalar	195.424	1341.411	1.588971
Sum256Avx2_Range52	78.070	3357.796	3.977486
Sum256Traits	95.958	2731.855	3.236026
Sum256Traits_Range52	78.739	3329.274	3.943700

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	697.314	375.934
SumBcl	111.564	2349.708	6.250321
SumBase_Range52_Impl	77.681	3374.604	8.976585
SumTraits	96.035	2729.668	7.261030
SumTraits_Range52	80.133	3271.381	8.702008
Sum128Base_Basic	1133.048	231.362	0.615432
Sum128Base	1091.061	240.265	0.639115
Sum128Base_Range52_Impl	1031.296	254.189	0.676153
Sum128Traits	165.592	1583.074	4.211042
Sum128Traits_Range52	155.182	1689.269	4.493525
Sum256Base_Basic	873.252	300.193	0.798525
Sum256Base	878.941	298.250	0.793357
Sum256Base_Range52_Impl	873.556	300.088	0.798247
Sum256Avx2_Bcl	96.635	2712.725	7.215960
Sum256Avx2_Range52	77.991	3361.202	8.940935
Sum256Traits	97.209	2696.696	7.173323
Sum256Traits_Range52	78.134	3355.055	8.924584

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	158.322	1655.768
SumBcl	197.253	1328.972	0.802632
SumBase_Range52_Impl	152.898	1714.504	1.035473
SumBase_Range52RoundToEven	70.839	3700.541	2.234939
SumTraits	180.878	1449.290	0.875298
SumTraits_Range52	77.435	3385.336	2.044571
SumTraits_Range52RoundToEven	71.547	3663.925	2.212824
Sum128Base_Basic	834.162	314.260	0.189797
Sum128Base	833.155	314.640	0.190027
Sum128Base_Range52_Impl	834.058	314.300	0.189821
Sum128Traits	349.991	749.001	0.452359
Sum128Traits_Range52	122.599	2138.218	1.291375
Sum128Traits_Range52RoundToEven	116.796	2244.453	1.355536
Sum256Base_Basic	468.396	559.664	0.338008
Sum256Base	469.806	557.984	0.336994
Sum256Base_Range52_Impl	478.086	548.320	0.331157
Sum256Avx2_HwScalar	194.985	1344.431	0.811968
Sum256Avx2_ShiftVar	146.744	1786.405	1.078898
Sum256Avx2_ShiftVarFix	179.238	1462.548	0.883305
Sum256Avx2_Range52	77.486	3383.125	2.043236
Sum256Traits	179.542	1460.074	0.881811
Sum256Traits_Range52	77.585	3378.792	2.040619
Sum256Traits_Range52RoundToEven	71.001	3692.122	2.229854

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	870.285	301.216
SumBcl	1452.001	180.540	0.599370
SumBase_Range52_Impl	152.343	1720.754	5.712685
SumBase_Range52RoundToEven	69.746	3758.543	12.477887
SumTraits	128.243	2044.114	6.786200
SumTraits_Range52	77.487	3383.054	11.231311
SumTraits_Range52RoundToEven	69.888	3750.896	12.452501
Sum128Base_Basic	1049.038	249.890	0.829603
Sum128Base	1060.643	247.156	0.820525
Sum128Base_Range52_Impl	1056.193	248.197	0.823983
Sum128Traits	233.713	1121.648	3.723728
Sum128Traits_Range52	117.911	2223.242	7.380882
Sum128Traits_Range52RoundToEven	96.233	2724.063	9.043543
Sum256Base_Basic	996.475	263.071	0.873364
Sum256Base	997.084	262.911	0.872830
Sum256Base_Range52_Impl	997.057	262.918	0.872854
Sum256Avx2_ShiftVar	131.605	1991.893	6.612832
Sum256Avx2_Range52	82.429	3180.236	10.557982
Sum256Traits	129.058	2031.217	6.743383
Sum256Traits_Range52	77.198	3395.744	11.273441
Sum256Traits_Range52RoundToEven	69.887	3750.985	12.452797

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	309.871	845.977
SumBcl	195.458	1341.178	1.585359
SumBase_Range52_Impl	77.846	3367.463	3.980559
SumTraits	86.396	3034.230	3.586656
SumTraits_Range52	77.772	3370.674	3.984356
Sum128Base_Basic	855.161	306.543	0.362354
Sum128Base	855.108	306.563	0.362377
Sum128Base_Range52_Impl	856.040	306.229	0.361982
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	155.732	1683.303	1.989773
Sum128Traits_Range52	155.268	1688.336	1.995723
Sum256Base_Basic	526.340	498.050	0.588728
Sum256Base	526.112	498.267	0.588984
Sum256Base_Range52_Impl	526.105	498.273	0.588991
Sum256Avx2_Bcl	86.990	3013.489	3.562139
Sum256Avx2_HwScalar	195.256	1342.566	1.587000
Sum256Avx2_Range52	77.892	3365.467	3.978200
Sum256Traits	86.435	3032.861	3.585039
Sum256Traits_Range52	77.948	3363.078	3.975377

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	699.786	374.606
SumBcl	103.271	2538.418	6.776233
SumBase_Range52_Impl	77.912	3364.609	8.981728
SumTraits	77.899	3365.159	8.983194
SumTraits_Range52	77.892	3365.471	8.984028
Sum128Base_Basic	925.831	283.145	0.755847
Sum128Base	924.901	283.429	0.756606
Sum128Base_Range52_Impl	926.336	282.990	0.755434
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	155.458	1686.269	4.501446
Sum128Traits_Range52	155.635	1684.347	4.496315
Sum256Base_Basic	828.607	316.367	0.844533
Sum256Base	825.552	317.538	0.847658
Sum256Base_Range52_Impl	822.558	318.693	0.850743
Sum256Avx2_Bcl	78.016	3360.144	8.969808
Sum256Avx2_Range52	77.978	3361.765	8.974134
Sum256Traits	78.143	3354.670	8.955196
Sum256Traits_Range52	77.735	3372.283	9.002213

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	158.165	1657.406
SumBcl	197.259	1328.933	0.801815
SumBase_Range52_Impl	98.524	2660.723	1.605354
SumBase_Range52RoundToEven	71.362	3673.417	2.216365
SumTraits	162.047	1617.708	0.976048
SumTraits_Range52	74.138	3535.908	2.133399
SumTraits_Range52RoundToEven	70.785	3703.357	2.234430
Sum128Base_Basic	807.184	324.763	0.195947
Sum128Base	807.212	324.752	0.195940
Sum128Base_Range52_Impl	806.253	325.139	0.196173
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	311.747	840.886	0.507351
Sum128Traits_Range52	119.525	2193.217	1.323283
Sum128Traits_Range52RoundToEven	97.245	2695.710	1.626464
Sum256Base_Basic	497.324	527.109	0.318033
Sum256Base	491.726	533.109	0.321653
Sum256Base_Range52_Impl	491.816	533.012	0.321594
Sum256Avx2_HwScalar	196.330	1335.218	0.805607
Sum256Avx2_ShiftVar	142.473	1839.951	1.110139
Sum256Avx2_ShiftVarFix	168.146	1559.028	0.940643
Sum256Avx2_Range52	74.185	3533.645	2.132034
Sum256Traits	161.467	1623.511	0.979549
Sum256Traits_Range52	74.010	3541.993	2.137070
Sum256Traits_Range52RoundToEven	70.699	3707.898	2.237169

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	921.244	284.554
SumBcl	1274.020	205.761	0.723101
SumBase_Range52_Impl	89.440	2930.959	10.300177
SumBase_Range52RoundToEven	51.385	5101.545	17.928198
SumTraits	100.600	2605.814	9.157531
SumTraits_Range52	65.958	3974.415	13.967163
SumTraits_Range52RoundToEven	51.153	5124.713	18.009619
Sum128Base_Basic	1107.856	236.623	0.831556
Sum128Base	1062.514	246.721	0.867042
Sum128Base_Range52_Impl	1102.539	237.764	0.835566
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	194.389	1348.552	4.739173
Sum128Traits_Range52	110.471	2372.976	8.339274
Sum128Traits_Range52RoundToEven	88.823	2951.292	10.371632
Sum256Base_Basic	1005.307	260.760	0.916381
Sum256Base	995.127	263.428	0.925755
Sum256Base_Range52_Impl	1009.137	259.770	0.912903
Sum256Avx2_ShiftVar	105.602	2482.375	8.723734
Sum256Avx2_Range52	66.041	3969.420	13.949609
Sum256Traits	100.688	2603.524	9.149482
Sum256Traits_Range52	65.991	3972.419	13.960147
Sum256Traits_Range52RoundToEven	55.076	4759.686	16.726815

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	310.246	844.954
SumBcl	195.142	1343.349	1.589849
SumBase_Range52_Impl	77.842	3367.645	3.985594
SumTraits	79.682	3289.890	3.893572
SumTraits_Range52	77.733	3372.362	3.991177
Sum128Base_Basic	857.697	305.637	0.361720
Sum128Base	856.249	306.154	0.362332
Sum128Base_Range52_Impl	856.789	305.961	0.362104
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	155.306	1687.923	1.997650
Sum128Traits_Range52	155.144	1689.682	1.999732
Sum256Base_Basic	1073.856	244.115	0.288909
Sum256Base	1070.215	244.945	0.289892
Sum256Base_Range52_Impl	1070.729	244.828	0.289753
Sum256Avx2_Bcl	79.791	3285.401	3.888259
Sum256Avx2_HwScalar	195.068	1343.861	1.590454
Sum256Avx2_Range52	77.745	3371.826	3.990543
Sum256Traits	79.861	3282.494	3.884819
Sum256Traits_Range52	77.871	3366.373	3.984090

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	700.707	374.114
SumBcl	102.194	2565.161	6.856634
SumBase_Range52_Impl	77.817	3368.743	9.004595
SumTraits	77.855	3367.071	9.000127
SumTraits_Range52	77.754	3371.469	9.011883
Sum128Base_Basic	925.840	283.142	0.756834
Sum128Base	926.779	282.855	0.756066
Sum128Base_Range52_Impl	926.250	283.017	0.756499
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	155.397	1686.936	4.509153
Sum128Traits_Range52	155.140	1689.726	4.516610
Sum256Base_Basic	1133.655	231.238	0.618095
Sum256Base	1133.837	231.201	0.617996
Sum256Base_Range52_Impl	1137.158	230.526	0.616191
Sum256Avx2_Bcl	77.883	3365.877	8.996935
Sum256Avx2_Range52	77.742	3371.967	9.013214
Sum256Traits	78.012	3360.322	8.982086
Sum256Traits_Range52	77.804	3369.292	9.006064

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	158.044	1658.672
SumBcl	199.960	1310.982	0.790380
SumBase_Range52_Impl	104.425	2510.361	1.513476
SumBase_Range52RoundToEven	54.740	4788.926	2.887204
SumTraits	160.096	1637.423	0.987189
SumTraits_Range52	71.575	3662.527	2.208107
SumTraits_Range52RoundToEven	53.210	4926.614	2.970215
Sum128Base_Basic	803.776	326.141	0.196627
Sum128Base	809.431	323.862	0.195254
Sum128Base_Range52_Impl	804.870	325.697	0.196360
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	317.456	825.764	0.497846
Sum128Traits_Range52	118.824	2206.149	1.330069
Sum128Traits_Range52RoundToEven	90.920	2883.229	1.738275
Sum256Base_Basic	1042.959	251.346	0.151535
Sum256Base	1043.251	251.276	0.151492
Sum256Base_Range52_Impl	1041.650	251.662	0.151725
Sum256Avx2_HwScalar	195.140	1343.364	0.809903
Sum256Avx2_ShiftVar	143.208	1830.518	1.103604
Sum256Avx2_ShiftVarFix	161.335	1624.847	0.979607
Sum256Avx2_Range52	71.595	3661.482	2.207478
Sum256Traits	162.396	1614.229	0.973205
Sum256Traits_Range52	70.923	3696.190	2.228403
Sum256Traits_Range52RoundToEven	53.405	4908.634	2.959375

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	914.482	286.658
SumBcl	1187.841	220.689	0.769869
SumBase_Range52_Impl	98.449	2662.751	9.288936
SumBase_Range52RoundToEven	51.549	5085.319	17.740003
SumTraits	100.592	2606.017	9.091022
SumTraits_Range52	67.015	3911.706	13.645885
SumTraits_Range52RoundToEven	53.741	4877.922	17.016504
Sum128Base_Basic	1083.223	242.004	0.844224
Sum128Base	1040.358	251.975	0.879008
Sum128Base_Range52_Impl	1078.662	243.027	0.847794
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	195.125	1343.466	4.686645
Sum128Traits_Range52	110.139	2380.127	8.303011
Sum128Traits_Range52RoundToEven	87.068	3010.790	10.503061
Sum256Base_Basic	980.181	267.444	0.932973
Sum256Base	979.713	267.572	0.933419
Sum256Base_Range52_Impl	979.926	267.514	0.933216
Sum256Avx2_ShiftVar	101.758	2576.156	8.986852
Sum256Avx2_Range52	65.369	4010.195	13.989461
Sum256Traits	100.592	2606.011	9.091002
Sum256Traits_Range52	65.130	4024.953	14.040943
Sum256Traits_Range52RoundToEven	49.580	5287.314	18.444657

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	310.226	845.009
SumBcl	80.425	3259.472	3.857322
SumBase_Range52_Impl	77.955	3362.752	3.979545
SumTraits	81.256	3226.141	3.817877
SumTraits_Range52	80.882	3241.084	3.835560
Sum128Bcl	155.319	1687.774	1.997344
Sum128Base_Basic	853.463	307.153	0.363491
Sum128Base	155.436	1686.513	1.995852
Sum128Base_Range52_Impl	155.641	1684.287	1.993218
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	155.671	1683.957	1.992827
Sum128Traits_Range52	155.462	1686.228	1.995515
Sum256Bcl	80.600	3252.412	3.848967
Sum256Base_Basic	484.685	540.854	0.640057
Sum256Base	81.603	3212.416	3.801635
Sum256Base_Range52_Impl	77.897	3365.257	3.982509
Sum256Avx2_Bcl	80.615	3251.798	3.848240
Sum256Avx2_HwScalar	195.208	1342.899	1.589213
Sum256Avx2_Range52	105.550	2483.589	2.939127
Sum256Traits	84.455	3103.940	3.673262
Sum256Traits_Range52	84.316	3109.072	3.679335

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	696.880	376.168
SumBcl	135.249	1938.229	5.152562
SumBase_Range52_Impl	80.805	3244.167	8.624251
SumTraits	85.774	3056.233	8.124651
SumTraits_Range52	80.264	3266.012	8.682325
Sum128Bcl	155.407	1686.821	4.484224
Sum128Base_Basic	914.831	286.549	0.761758
Sum128Base	156.113	1679.199	4.463960
Sum128Base_Range52_Impl	155.172	1689.381	4.491029
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	155.335	1687.610	4.486320
Sum128Traits_Range52	155.500	1685.814	4.481547
Sum256Bcl	80.489	3256.912	8.658133
Sum256Base_Basic	826.473	317.184	0.843198
Sum256Base	82.171	3190.223	8.480848
Sum256Base_Range52_Impl	78.002	3360.745	8.934161
Sum256Avx2_Bcl	81.182	3229.109	8.584221
Sum256Avx2_Range52	78.574	3336.262	8.869076
Sum256Traits	92.054	2847.721	7.570346
Sum256Traits_Range52	80.447	3258.582	8.662572

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	155.246	1688.567
SumBcl	435.721	601.633	0.356298
SumBase_Range52_Impl	104.034	2519.799	1.492271
SumBase_Range52RoundToEven	54.235	4833.489	2.862480
SumTraits	156.278	1677.416	0.993396
SumTraits_Range52	74.385	3524.158	2.087071
SumTraits_Range52RoundToEven	58.247	4500.594	2.665334
Sum128Bcl	764.240	343.013	0.203138
Sum128Base_Basic	799.147	328.030	0.194265
Sum128Base	765.735	342.343	0.202742
Sum128Base_Range52_Impl	139.514	1878.978	1.112765
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	278.115	942.576	0.558210
Sum128Traits_Range52	110.000	2383.121	1.411328
Sum128Traits_Range52RoundToEven	96.225	2724.293	1.613376
Sum256Bcl	436.797	600.151	0.355420
Sum256Base_Basic	456.239	574.576	0.340274
Sum256Base	437.037	599.821	0.355225
Sum256Base_Range52_Impl	96.783	2708.575	1.604067
Sum256Avx2_HwScalar	194.991	1344.392	0.796174
Sum256Avx2_ShiftVar	146.750	1786.333	1.057899
Sum256Avx2_ShiftVarFix	156.297	1677.217	0.993278
Sum256Avx2_Range52	70.739	3705.817	2.194652
Sum256Traits	152.854	1714.996	1.015652
Sum256Traits_Range52	70.293	3729.287	2.208552
Sum256Traits_Range52RoundToEven	55.194	4749.525	2.812755

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	908.499	288.546
SumBcl	1001.187	261.833	0.907422
SumBase_Range52_Impl	106.001	2473.041	8.570693
SumBase_Range52RoundToEven	54.364	4822.031	16.711469
SumTraits	111.861	2343.486	8.121700
SumTraits_Range52	73.745	3554.745	12.319501
SumTraits_Range52RoundToEven	54.403	4818.579	16.699506
Sum128Bcl	1098.372	238.666	0.827132
Sum128Base_Basic	1087.523	241.047	0.835384
Sum128Base	1080.423	242.631	0.840873
Sum128Base_Range52_Impl	148.030	1770.881	6.137254
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	198.201	1322.616	4.583724
Sum128Traits_Range52	118.068	2220.273	7.694689
Sum128Traits_Range52RoundToEven	95.778	2737.007	9.485508
Sum256Bcl	1010.213	259.494	0.899315
Sum256Base_Basic	1020.024	256.998	0.890665
Sum256Base	1011.204	259.239	0.898433
Sum256Base_Range52_Impl	95.450	2746.415	9.518112
Sum256Avx2_ShiftVar	116.899	2242.477	7.771639
Sum256Avx2_Range52	80.122	3271.825	11.338997
Sum256Traits	115.119	2277.153	7.891815
Sum256Traits_Range52	75.012	3494.704	12.111419
Sum256Traits_Range52RoundToEven	58.194	4504.691	15.611679

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	318.657	822.652
SumBcl	132.935	1971.970	2.397088
SumBase_Range52_Impl	185.936	1409.858	1.713796
SumTraits	124.881	2099.150	2.551686
SumTraits_Range52	124.918	2098.527	2.550928
Sum128Base_Basic	1174.249	223.244	0.271371
Sum128Base	1168.637	224.316	0.272674
Sum128Base_Range52_Impl	1184.719	221.271	0.268973
Sum128Traits	1174.528	223.191	0.271307
Sum128Traits_Range52	1175.403	223.025	0.271105
Sum256Base_Basic	1786.679	146.721	0.178352
Sum256Base	1909.289	137.299	0.166898
Sum256Base_Range52_Impl	2038.677	128.585	0.156306
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2225.552	117.788	0.143181
Sum256Traits_Range52	2224.415	117.849	0.143254

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	321.803	814.611
SumBcl	125.003	2097.108	2.574369
SumBase_Range52_Impl	177.181	1479.529	1.816240
SumTraits	133.784	1959.464	2.405400
SumTraits_Range52	133.486	1963.827	2.410755
Sum128Base_Basic	1119.805	234.098	0.287374
Sum128Base	1110.176	236.128	0.289866
Sum128Base_Range52_Impl	1120.849	233.880	0.287106
Sum128Traits	1115.181	235.069	0.288566
Sum128Traits_Range52	1120.345	233.985	0.287236
Sum256Base_Basic	1749.822	149.812	0.183906
Sum256Base	1900.003	137.970	0.169370
Sum256Base_Range52_Impl	2022.204	129.633	0.159135
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2185.317	119.957	0.147257
Sum256Traits_Range52	2179.299	120.288	0.147663

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447745283
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447745283
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447745283
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447745283
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum128Base	Check `Sum128Base` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum128Traits	Check `Sum128Traits` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Base	Check `Sum256Base` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Traits	Check `Sum256Traits` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 5047608992447746009!=5047608992447745283
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 5047608992447746009!=5047608992447745283
SumScalar	361.672	724.811
SumBcl	126.550	2071.460	2.857932
SumBase_Range52_Impl	683.433	383.569	0.529199
SumBase_Range52RoundToEven	162.568	1612.520	2.224746
SumTraits	134.057	1955.461	2.697891
SumTraits_Range52	134.008	1956.185	2.698890
SumTraits_Range52RoundToEven	161.089	1627.323	2.245169
Sum128Base_Basic	1104.860	237.264	0.327347
Sum128Base	1134.822	231.000	0.318704
Sum128Base_Range52_Impl	1148.848	228.180	0.314813
Sum128Traits	1134.106	231.146	0.318905
Sum128Traits_Range52	1136.858	230.586	0.318133
Sum128Traits_Range52RoundToEven	1130.908	231.800	0.319807
Sum256Base_Basic	1747.519	150.009	0.206963
Sum256Base	1897.882	138.124	0.190566
Sum256Base_Range52_Impl	1912.523	137.067	0.189107
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2137.164	122.660	0.169230
Sum256Traits_Range52	2144.512	122.239	0.168650
Sum256Traits_Range52RoundToEven	2140.246	122.483	0.168986

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	369.036	710.349
SumBcl	1296.187	202.242	0.284709
SumBase_Range52_Impl	681.933	384.413	0.541161
SumBase_Range52RoundToEven	177.035	1480.743	2.084529
SumTraits	1283.228	204.285	0.287584
SumTraits_Range52	683.346	383.618	0.540042
SumTraits_Range52RoundToEven	185.693	1411.704	1.987338
Sum128Base_Basic	1097.062	238.951	0.336385
Sum128Base	1063.015	246.604	0.347159
Sum128Base_Range52_Impl	1066.976	245.689	0.345870
Sum128Traits	1056.468	248.133	0.349311
Sum128Traits_Range52	1077.026	243.396	0.342643
Sum128Traits_Range52RoundToEven	1077.951	243.187	0.342349
Sum256Base_Basic	1693.199	154.822	0.217952
Sum256Base	1843.082	142.231	0.200227
Sum256Base_Range52_Impl	1853.278	141.449	0.199126
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2103.466	124.625	0.175442
Sum256Traits_Range52	2082.077	125.905	0.177244
Sum256Traits_Range52RoundToEven	2098.362	124.928	0.175868

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	322.259	813.458
SumBcl	134.921	1942.939	2.388494
SumBase_Range52_Impl	164.642	1592.207	1.957333
SumTraits	133.850	1958.491	2.407613
SumTraits_Range52	126.192	2077.343	2.553721
Sum128Base_Basic	406.609	644.708	0.792553
Sum128Base	410.422	638.718	0.785189
Sum128Base_Range52_Impl	410.876	638.013	0.784322
Sum128AdvSimd_Range52	381.472	687.190	0.844777
Sum128AdvSimd_Range52_Impl	315.908	829.812	1.020105
Sum128Traits	133.596	1962.221	2.412198
Sum128Traits_Range52	126.071	2079.344	2.556180
Sum256Base_Basic	1156.589	226.653	0.278629
Sum256Base	1298.057	201.951	0.248263
Sum256Base_Range52_Impl	1299.766	201.685	0.247936
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1303.589	201.094	0.247209
Sum256Traits_Range52	1299.143	201.782	0.248055

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	319.781	819.761
SumBcl	132.091	1984.573	2.420916
SumBase_Range52_Impl	158.580	1653.067	2.016523
SumTraits	131.956	1986.608	2.423400
SumTraits_Range52	124.137	2111.729	2.576030
Sum128Base_Basic	385.582	679.866	0.829347
Sum128Base	389.396	673.207	0.821223
Sum128Base_Range52_Impl	390.440	671.407	0.819028
Sum128AdvSimd_Range52	283.266	925.434	1.128907
Sum128AdvSimd_Range52_Impl	287.513	911.764	1.112231
Sum128Traits	132.440	1979.343	2.414536
Sum128Traits_Range52	123.507	2122.506	2.589177
Sum256Base_Basic	1146.765	228.594	0.278855
Sum256Base	1294.687	202.477	0.246995
Sum256Base_Range52_Impl	1298.060	201.951	0.246353
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1300.475	201.576	0.245896
Sum256Traits_Range52	1298.269	201.918	0.246313

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
SumScalar	365.258	717.695
SumBcl	125.184	2094.069	2.917768
SumBase_Range52_Impl	338.724	773.916	1.078335
SumBase_Range52RoundToEven	161.168	1626.531	2.266324
SumTraits	125.353	2091.252	2.913843
SumTraits_Range52	125.408	2090.334	2.912564
SumTraits_Range52RoundToEven	125.406	2090.362	2.912603
Sum128Base_Basic	410.604	638.435	0.889563
Sum128Base	408.743	641.341	0.893612
Sum128Base_Range52_Impl	409.658	639.909	0.891616
Sum128AdvSimd_Range52	381.017	688.011	0.958639
Sum128AdvSimd_Range52_Impl	379.670	690.451	0.962039
Sum128Traits	133.396	1965.154	2.738145
Sum128Traits_Range52	133.251	1967.288	2.741118
Sum128Traits_Range52RoundToEven	133.231	1967.590	2.741539
Sum256Base_Basic	1050.295	249.591	0.347767
Sum256Base	1198.444	218.737	0.304777
Sum256Base_Range52_Impl	1200.911	218.288	0.304151
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1199.703	218.507	0.304457
Sum256Traits_Range52	1198.261	218.770	0.304823
Sum256Traits_Range52RoundToEven	1197.191	218.966	0.305096

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
SumScalar	360.571	727.026
SumBcl	1005.179	260.793	0.358713
SumBase_Range52_Impl	330.528	793.106	1.090891
SumBase_Range52RoundToEven	159.642	1642.075	2.258621
SumTraits	132.810	1973.827	2.714935
SumTraits_Range52	132.300	1981.437	2.725402
SumTraits_Range52RoundToEven	132.821	1973.664	2.714711
Sum128Base_Basic	395.937	662.085	0.910676
Sum128Base	393.254	666.602	0.916890
Sum128Base_Range52_Impl	394.511	664.478	0.913968
Sum128AdvSimd_Range52	350.909	747.043	1.027533
Sum128AdvSimd_Range52_Impl	349.287	750.512	1.032305
Sum128Traits	124.111	2112.176	2.905229
Sum128Traits_Range52	123.966	2114.636	2.908613
Sum128Traits_Range52RoundToEven	123.424	2123.936	2.921405
Sum256Base_Basic	1035.000	253.279	0.348377
Sum256Base	1188.239	220.615	0.303449
Sum256Base_Range52_Impl	1187.770	220.703	0.303569
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1186.871	220.870	0.303799
Sum256Traits_Range52	1189.514	220.379	0.303124
Sum256Traits_Range52RoundToEven	1188.832	220.506	0.303298

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	319.708	819.948
SumBcl	134.078	1955.167	2.384503
SumBase_Range52_Impl	161.079	1627.430	1.984797
SumTraits	126.059	2079.542	2.536189
SumTraits_Range52	134.252	1952.633	2.381412
Sum128Base_Basic	409.846	639.616	0.780069
Sum128Base	410.195	639.072	0.779406
Sum128Base_Range52_Impl	411.427	637.157	0.777071
Sum128AdvSimd_Range52	324.124	808.776	0.986375
Sum128AdvSimd_Range52_Impl	323.362	810.682	0.988700
Sum128Traits	126.145	2078.110	2.534442
Sum128Traits_Range52	133.718	1960.431	2.390923
Sum256Base_Basic	1155.043	226.956	0.276793
Sum256Base	1300.775	201.529	0.245783
Sum256Base_Range52_Impl	1303.628	201.088	0.245245
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1303.406	201.122	0.245287
Sum256Traits_Range52	1301.181	201.466	0.245706

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	321.846	814.502
SumBcl	124.121	2112.005	2.593003
SumBase_Range52_Impl	146.956	1783.831	2.190089
SumTraits	133.300	1966.571	2.414447
SumTraits_Range52	124.408	2107.127	2.587014
Sum128Base_Basic	390.346	671.568	0.824514
Sum128Base	388.051	675.539	0.829390
Sum128Base_Range52_Impl	388.244	675.205	0.828979
Sum128AdvSimd_Range52	312.638	838.491	1.029453
Sum128AdvSimd_Range52_Impl	310.703	843.712	1.035863
Sum128Traits	132.634	1976.444	2.426569
Sum128Traits_Range52	124.217	2110.370	2.590995
Sum256Base_Basic	1143.048	229.338	0.281568
Sum256Base	1294.941	202.437	0.248541
Sum256Base_Range52_Impl	1299.143	201.782	0.247737
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1296.726	202.158	0.248199
Sum256Traits_Range52	1298.084	201.947	0.247939

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
SumScalar	366.279	715.695
SumBcl	134.081	1955.124	2.731784
SumBase_Range52_Impl	331.388	791.048	1.105286
SumBase_Range52RoundToEven	161.714	1621.030	2.264973
SumTraits	126.165	2077.786	2.903173
SumTraits_Range52	126.469	2072.785	2.896185
SumTraits_Range52RoundToEven	126.003	2080.456	2.906903
Sum128Base_Basic	408.871	641.142	0.895831
Sum128Base	406.989	644.106	0.899973
Sum128Base_Range52_Impl	406.874	644.288	0.900227
Sum128AdvSimd_Range52	375.591	697.951	0.975208
Sum128AdvSimd_Range52_Impl	377.775	693.915	0.969569
Sum128Traits	134.362	1951.028	2.726061
Sum128Traits_Range52	133.979	1956.603	2.733851
Sum128Traits_Range52RoundToEven	133.622	1961.835	2.741161
Sum256Base_Basic	1048.947	249.912	0.349187
Sum256Base	1205.866	217.391	0.303748
Sum256Base_Range52_Impl	1201.144	218.245	0.304942
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1199.536	218.538	0.305351
Sum256Traits_Range52	1204.904	217.564	0.303990
Sum256Traits_Range52RoundToEven	1203.615	217.797	0.304316

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
SumScalar	359.900	728.379
SumBcl	1003.753	261.164	0.358555
SumBase_Range52_Impl	323.554	810.201	1.112335
SumBase_Range52RoundToEven	158.719	1651.626	2.267536
SumTraits	124.131	2111.834	2.899360
SumTraits_Range52	123.937	2115.134	2.903891
SumTraits_Range52RoundToEven	124.002	2114.032	2.902378
Sum128Base_Basic	392.140	668.496	0.917786
Sum128Base	392.604	667.706	0.916701
Sum128Base_Range52_Impl	389.646	672.775	0.923661
Sum128AdvSimd_Range52	349.729	749.564	1.029085
Sum128AdvSimd_Range52_Impl	351.013	746.821	1.025319
Sum128Traits	133.137	1968.978	2.703232
Sum128Traits_Range52	132.925	1972.126	2.707554
Sum128Traits_Range52RoundToEven	132.836	1973.439	2.709357
Sum256Base_Basic	1033.354	253.683	0.348284
Sum256Base	1194.043	219.543	0.301413
Sum256Base_Range52_Impl	1192.922	219.750	0.301697
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1190.638	220.171	0.302275
Sum256Traits_Range52	1189.774	220.331	0.302495
Sum256Traits_Range52RoundToEven	1186.142	221.006	0.303421

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	282.412	928.232
SumBcl	106.330	2465.389	2.656006
SumBase_Range52_Impl	133.116	1969.287	2.121546
SumTraits	106.202	2468.357	2.659203
SumTraits_Range52	106.018	2472.632	2.663809
Sum128Bcl	106.503	2461.367	2.651673
Sum128Base_Basic	399.396	656.351	0.707098
Sum128Base	106.030	2472.368	2.663524
Sum128Base_Range52_Impl	134.725	1945.764	2.096205
Sum128AdvSimd_Range52	106.441	2462.811	2.653228
Sum128AdvSimd_Range52_Impl	248.402	1055.322	1.136917
Sum128Traits	106.338	2465.196	2.655798
Sum128Traits_Range52	106.432	2463.013	2.653446
Sum256Bcl	1192.605	219.808	0.236803
Sum256Base_Basic	1021.330	256.669	0.276514
Sum256Base	1194.146	219.524	0.236497
Sum256Base_Range52_Impl	2704.964	96.912	0.104405
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1189.178	220.441	0.237485
Sum256Traits_Range52	1364.492	192.118	0.206972

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	282.373	928.361
SumBcl	107.842	2430.812	2.618390
SumBase_Range52_Impl	134.502	1948.990	2.099388
SumTraits	107.555	2437.302	2.625381
SumTraits_Range52	107.843	2430.784	2.618360
Sum128Bcl	108.007	2427.102	2.614394
Sum128Base_Basic	411.086	637.686	0.686895
Sum128Base	107.685	2434.368	2.622220
Sum128Base_Range52_Impl	135.986	1927.733	2.076490
Sum128AdvSimd_Range52	107.814	2431.446	2.619073
Sum128AdvSimd_Range52_Impl	270.464	969.238	1.044031
Sum128Traits	107.585	2436.612	2.624637
Sum128Traits_Range52	107.906	2429.379	2.616846
Sum256Bcl	1191.108	220.084	0.237067
Sum256Base_Basic	1025.994	255.503	0.275219
Sum256Base	1185.697	221.088	0.238149
Sum256Base_Range52_Impl	2439.219	107.470	0.115764
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1185.368	221.150	0.238215
Sum256Traits_Range52	1387.551	188.926	0.203504

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447745283!=5047608992447746009
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	230.474	1137.410
SumBcl	106.399	2463.786	2.166136
SumBase_Range52_Impl	303.807	862.863	0.758621
SumBase_Range52RoundToEven	132.835	1973.460	1.735046
SumTraits	106.575	2459.708	2.162551
SumTraits_Range52	106.532	2460.705	2.163428
SumTraits_Range52RoundToEven	106.349	2464.948	2.167158
Sum128Bcl	106.445	2462.720	2.165199
Sum128Base_Basic	395.924	662.108	0.582118
Sum128Base	106.391	2463.966	2.166294
Sum128Base_Range52_Impl	240.661	1089.268	0.957673
Sum128AdvSimd_Range52	106.426	2463.147	2.165575
Sum128AdvSimd_Range52_Impl	317.961	824.454	0.724852
Sum128Traits	106.258	2467.049	2.169005
Sum128Traits_Range52	106.290	2466.307	2.168353
Sum128Traits_Range52RoundToEven	106.421	2463.282	2.165693
Sum256Bcl	954.385	274.673	0.241490
Sum256Base_Basic	1009.535	259.668	0.228298
Sum256Base	1125.265	232.962	0.204818
Sum256Base_Range52_Impl	5365.984	48.853	0.042951
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1126.960	232.612	0.204510
Sum256Traits_Range52	1318.103	198.880	0.174853
Sum256Traits_Range52RoundToEven	2455.617	106.753	0.093856

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	229.655	1141.468
SumBcl	108.554	2414.866	2.115579
SumBase_Range52_Impl	311.652	841.142	0.736895
SumBase_Range52RoundToEven	135.135	1939.868	1.699450
SumTraits	108.243	2421.807	2.121660
SumTraits_Range52	108.001	2427.246	2.126424
SumTraits_Range52RoundToEven	107.923	2428.986	2.127950
Sum128Bcl	108.254	2421.566	2.121449
Sum128Base_Basic	408.044	642.441	0.562820
Sum128Base	107.986	2427.576	2.126714
Sum128Base_Range52_Impl	266.200	984.763	0.862716
Sum128AdvSimd_Range52	107.786	2432.083	2.130662
Sum128AdvSimd_Range52_Impl	349.424	750.217	0.657239
Sum128Traits	108.018	2426.854	2.126081
Sum128Traits_Range52	107.627	2435.670	2.133804
Sum128Traits_Range52RoundToEven	107.783	2432.148	2.130719
Sum256Bcl	967.901	270.837	0.237271
Sum256Base_Basic	1028.112	254.976	0.223376
Sum256Base	1146.562	228.635	0.200299
Sum256Base_Range52_Impl	4946.982	52.991	0.046423
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1140.986	229.752	0.201278
Sum256Traits_Range52	1142.403	229.467	0.201028
Sum256Traits_Range52RoundToEven	2244.419	116.798	0.102323

```

