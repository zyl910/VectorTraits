# Benchmark - ConvertToDouble
([← Back](README.md))

- `ConvertToDouble[/_Range52]`: Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量).
  Mnemonic: `rt[i] := (Double)(value[i])` .
- `ConvertToInt64[/_Range52/Range52RoundToEven]`: Convert to a vector whose elements are of type Int64 (转换为元素类型是Int64的向量).
  Mnemonic: `rt[i] := (Int64)(value[i])` .
- `ConvertToUInt64[/_Range52/Range52RoundToEven]`: Convert to a vector whose elements are of type UInt64 (转换为元素类型是UInt64的向量).
  Mnemonic: `rt[i] := (UInt64)(value[i])` .

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
SumScalar	320.324	818.370
SumBcl	125.581	2087.442	2.550730
SumBase_Range52_Impl	180.036	1456.066	1.779226
SumTraits	125.437	2089.852	2.553675
SumTraits_Range52	125.321	2091.784	2.556035
Sum128Base_Basic	1176.039	222.904	0.272376
Sum128Base	1174.005	223.290	0.272848
Sum128Base_Range52_Impl	1175.511	223.004	0.272498
Sum128Traits	1171.123	223.840	0.273519
Sum128Traits_Range52	1176.123	222.888	0.272356
Sum256Base_Basic	1631.998	160.628	0.196277
Sum256Base	1779.955	147.276	0.179962
Sum256Base_Range52_Impl	1871.056	140.105	0.171200
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2036.926	128.696	0.157259
Sum256Traits_Range52	2040.447	128.474	0.156987

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
SumScalar	319.299	820.998
SumBcl	132.186	1983.144	2.415528
SumBase_Range52_Impl	176.316	1486.786	1.810949
SumTraits	132.251	1982.172	2.414344
SumTraits_Range52	132.249	1982.195	2.414372
Sum128Base_Basic	1097.649	238.823	0.290893
Sum128Base	1109.662	236.238	0.287744
Sum128Base_Range52_Impl	1095.640	239.261	0.291427
Sum128Traits	1110.867	235.982	0.287432
Sum128Traits_Range52	1115.556	234.990	0.286224
Sum256Base_Basic	1583.345	165.563	0.201661
Sum256Base	1763.653	148.637	0.181044
Sum256Base_Range52_Impl	2002.908	130.882	0.159418
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2122.155	123.527	0.150460
Sum256Traits_Range52	2123.609	123.443	0.150357

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
SumScalar	381.908	686.406
SumBcl	141.026	1858.829	2.708061
SumBase_Range52_Impl	1259.173	208.188	0.303301
SumBase_Range52RoundToEven	170.114	1540.992	2.245016
SumTraits	140.827	1861.459	2.711891
SumTraits_Range52	140.241	1869.245	2.723235
SumTraits_Range52RoundToEven	170.463	1537.832	2.240411
Sum128Base_Basic	1188.177	220.627	0.321424
Sum128Base	1193.810	219.586	0.319907
Sum128Base_Range52_Impl	1189.671	220.350	0.321020
Sum128Traits	1194.904	219.385	0.319614
Sum128Traits_Range52	1170.879	223.886	0.326172
Sum128Traits_Range52RoundToEven	1176.989	222.724	0.324479
Sum256Base_Basic	1695.427	154.618	0.225258
Sum256Base	1840.439	142.436	0.207509
Sum256Base_Range52_Impl	1826.842	143.496	0.209054
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1991.820	131.610	0.191738
Sum256Traits_Range52	1994.261	131.449	0.191504
Sum256Traits_Range52RoundToEven	1998.852	131.147	0.191064

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	363.634	720.901
SumBcl	1277.669	205.174	0.284607
SumBase_Range52_Impl	1207.475	217.101	0.301152
SumBase_Range52RoundToEven	176.859	1482.220	2.056067
SumTraits	1273.340	205.871	0.285575
SumTraits_Range52	1266.125	207.044	0.287202
SumTraits_Range52RoundToEven	185.019	1416.851	1.965390
Sum128Base_Basic	1081.743	242.335	0.336156
Sum128Base	1068.970	245.230	0.340172
Sum128Base_Range52_Impl	1078.609	243.039	0.337132
Sum128Traits	1082.146	242.245	0.336030
Sum128Traits_Range52	1070.811	244.809	0.339587
Sum128Traits_Range52RoundToEven	1082.507	242.164	0.335918
Sum256Base_Basic	1560.985	167.935	0.232952
Sum256Base	1703.500	153.885	0.213463
Sum256Base_Range52_Impl	1711.485	153.168	0.212467
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1965.216	133.392	0.185035
Sum256Traits_Range52	1961.819	133.623	0.185355
Sum256Traits_Range52RoundToEven	1960.955	133.682	0.185437

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
SumScalar	328.423	798.191
SumBcl	134.119	1954.562	2.448740
SumBase_Range52_Impl	162.410	1614.087	2.022182
SumTraits	134.245	1952.721	2.446435
SumTraits_Range52	126.012	2080.315	2.606288
Sum128Base_Basic	407.609	643.126	0.805729
Sum128Base	408.916	641.070	0.803154
Sum128Base_Range52_Impl	407.975	642.549	0.805006
Sum128AdvSimd_Range52	381.480	687.176	0.860917
Sum128AdvSimd_Range52_Impl	316.764	827.568	1.036805
Sum128Traits	134.276	1952.275	2.445876
Sum128Traits_Range52	126.110	2078.691	2.604253
Sum256Base_Basic	982.293	266.870	0.334343
Sum256Base	1145.365	228.874	0.286741
Sum256Base_Range52_Impl	1148.999	228.150	0.285834
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1150.793	227.794	0.285388
Sum256Traits_Range52	1151.799	227.595	0.285139

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
SumScalar	320.469	818.001
SumBcl	133.088	1969.699	2.407943
SumBase_Range52_Impl	159.675	1641.730	2.007003
SumTraits	124.237	2110.027	2.579493
SumTraits_Range52	133.142	1968.906	2.406973
Sum128Base_Basic	392.427	668.007	0.816634
Sum128Base	390.617	671.102	0.820417
Sum128Base_Range52_Impl	392.239	668.328	0.817026
Sum128AdvSimd_Range52	295.403	887.411	1.084853
Sum128AdvSimd_Range52_Impl	374.856	699.320	0.854914
Sum128Traits	123.823	2117.095	2.588134
Sum128Traits_Range52	132.504	1978.390	2.418567
Sum256Base_Basic	965.467	271.520	0.331932
Sum256Base	1139.481	230.056	0.281241
Sum256Base_Range52_Impl	1138.678	230.218	0.281440
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1138.606	230.232	0.281457
Sum256Traits_Range52	1140.769	229.796	0.280924

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
SumScalar	362.936	722.288
SumBcl	125.311	2091.949	2.896283
SumBase_Range52_Impl	339.997	771.018	1.067467
SumBase_Range52RoundToEven	162.587	1612.331	2.232255
SumTraits	134.067	1955.321	2.707121
SumTraits_Range52	133.643	1961.522	2.715707
SumTraits_Range52RoundToEven	133.970	1956.742	2.709090
Sum128Base_Basic	411.764	636.636	0.881416
Sum128Base	412.525	635.463	0.879792
Sum128Base_Range52_Impl	413.144	634.510	0.878472
Sum128AdvSimd_Range52	392.298	668.226	0.925153
Sum128AdvSimd_Range52_Impl	380.752	688.489	0.953206
Sum128Traits	125.423	2090.078	2.893691
Sum128Traits_Range52	126.311	2075.393	2.873360
Sum128Traits_Range52RoundToEven	126.019	2080.199	2.880015
Sum256Base_Basic	919.350	285.141	0.394774
Sum256Base	1074.442	243.982	0.337790
Sum256Base_Range52_Impl	1072.025	244.532	0.338551
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1075.253	243.798	0.337535
Sum256Traits_Range52	1072.706	244.376	0.338337
Sum256Traits_Range52RoundToEven	1073.795	244.129	0.337994

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
SumScalar	357.202	733.882
SumBcl	1055.179	248.436	0.338523
SumBase_Range52_Impl	329.787	794.890	1.083130
SumBase_Range52RoundToEven	159.628	1642.214	2.237709
SumTraits	124.053	2113.157	2.879424
SumTraits_Range52	124.079	2112.710	2.878815
SumTraits_Range52RoundToEven	123.819	2117.156	2.884873
Sum128Base_Basic	395.469	662.869	0.903236
Sum128Base	392.465	667.942	0.910149
Sum128Base_Range52_Impl	390.336	671.585	0.915113
Sum128AdvSimd_Range52	348.520	752.163	1.024911
Sum128AdvSimd_Range52_Impl	349.739	749.543	1.021339
Sum128Traits	132.536	1977.912	2.695137
Sum128Traits_Range52	132.477	1978.783	2.696323
Sum128Traits_Range52RoundToEven	132.635	1976.424	2.693109
Sum256Base_Basic	910.452	287.927	0.392335
Sum256Base	1062.861	246.640	0.336076
Sum256Base_Range52_Impl	1061.848	246.875	0.336396
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1062.651	246.689	0.336142
Sum256Traits_Range52	1061.584	246.937	0.336480
Sum256Traits_Range52RoundToEven	1062.906	246.629	0.336061

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
SumScalar	319.373	820.808
SumBcl	125.307	2092.015	2.548727
SumBase_Range52_Impl	148.055	1770.587	2.157127
SumTraits	125.900	2082.153	2.536712
SumTraits_Range52	133.798	1959.258	2.386988
Sum128Base_Basic	410.118	639.192	0.778735
Sum128Base	409.520	640.125	0.779872
Sum128Base_Range52_Impl	406.798	644.408	0.785090
Sum128AdvSimd_Range52	322.578	812.653	0.990065
Sum128AdvSimd_Range52_Impl	322.286	813.390	0.990963
Sum128Traits	126.059	2079.537	2.533525
Sum128Traits_Range52	133.530	1963.178	2.391764
Sum256Base_Basic	982.791	266.734	0.324965
Sum256Base	1146.820	228.583	0.278486
Sum256Base_Range52_Impl	1146.812	228.585	0.278488
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1146.378	228.671	0.278593
Sum256Traits_Range52	1146.636	228.620	0.278531

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
SumScalar	320.087	818.978
SumBcl	123.839	2116.815	2.584704
SumBase_Range52_Impl	145.941	1796.233	2.193263
SumTraits	132.443	1979.296	2.416789
SumTraits_Range52	123.820	2117.136	2.585096
Sum128Base_Basic	388.806	674.229	0.823256
Sum128Base	389.028	673.843	0.822786
Sum128Base_Range52_Impl	388.517	674.730	0.823868
Sum128AdvSimd_Range52	311.573	841.356	1.027324
Sum128AdvSimd_Range52_Impl	312.529	838.783	1.024183
Sum128Traits	132.804	1973.923	2.410227
Sum128Traits_Range52	123.959	2114.768	2.582204
Sum256Base_Basic	964.990	271.655	0.331700
Sum256Base	1136.143	230.731	0.281731
Sum256Base_Range52_Impl	1136.649	230.629	0.281606
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1138.229	230.309	0.281215
Sum256Traits_Range52	1138.233	230.308	0.281214

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
SumScalar	360.291	727.591
SumBcl	133.544	1962.985	2.697926
SumBase_Range52_Impl	328.826	797.213	1.095689
SumBase_Range52RoundToEven	147.876	1772.724	2.436431
SumTraits	125.225	2093.386	2.877148
SumTraits_Range52	125.580	2087.466	2.869012
SumTraits_Range52RoundToEven	125.443	2089.740	2.872137
Sum128Base_Basic	411.441	637.136	0.875679
Sum128Base	407.471	643.344	0.884212
Sum128Base_Range52_Impl	411.896	636.432	0.874711
Sum128AdvSimd_Range52	378.080	693.355	0.952947
Sum128AdvSimd_Range52_Impl	375.900	697.378	0.958475
Sum128Traits	133.496	1963.683	2.698885
Sum128Traits_Range52	133.314	1966.371	2.702578
Sum128Traits_Range52RoundToEven	133.381	1965.381	2.701218
Sum256Base_Basic	919.750	285.017	0.391727
Sum256Base	1072.679	244.383	0.335879
Sum256Base_Range52_Impl	1072.712	244.375	0.335869
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1073.055	244.297	0.335761
Sum256Traits_Range52	1073.873	244.111	0.335506
Sum256Traits_Range52RoundToEven	1075.630	243.712	0.334958

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
SumScalar	364.045	720.087
SumBcl	801.841	326.928	0.454011
SumBase_Range52_Impl	323.871	809.408	1.124042
SumBase_Range52RoundToEven	145.890	1796.856	2.495331
SumTraits	132.590	1977.099	2.745639
SumTraits_Range52	132.473	1978.854	2.748075
SumTraits_Range52RoundToEven	132.571	1977.387	2.746039
Sum128Base_Basic	389.839	672.442	0.933834
Sum128Base	390.320	671.613	0.932683
Sum128Base_Range52_Impl	395.375	663.026	0.920758
Sum128AdvSimd_Range52	349.167	750.769	1.042609
Sum128AdvSimd_Range52_Impl	348.130	753.005	1.045714
Sum128Traits	123.829	2116.980	2.939895
Sum128Traits_Range52	124.012	2113.866	2.935570
Sum128Traits_Range52RoundToEven	124.036	2113.455	2.934999
Sum256Base_Basic	908.930	288.409	0.400520
Sum256Base	1062.172	246.800	0.342736
Sum256Base_Range52_Impl	1061.397	246.980	0.342987
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1064.452	246.271	0.342002
Sum256Traits_Range52	1061.560	246.942	0.342934
Sum256Traits_Range52RoundToEven	1061.862	246.872	0.342836

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
SumScalar	281.914	929.872
SumBcl	106.375	2464.344	2.650198
SumBase_Range52_Impl	132.996	1971.065	2.119717
SumTraits	106.453	2462.529	2.648247
SumTraits_Range52	106.397	2463.821	2.649635
Sum128Bcl	106.342	2465.095	2.651006
Sum128Base_Basic	402.865	650.699	0.699773
Sum128Base	106.316	2465.707	2.651664
Sum128Base_Range52_Impl	134.167	1953.864	2.101219
Sum128AdvSimd_Range52	106.715	2456.493	2.641755
Sum128AdvSimd_Range52_Impl	249.635	1050.110	1.129306
Sum128Traits	106.508	2461.264	2.646885
Sum128Traits_Range52	106.536	2460.619	2.646192
Sum256Bcl	1189.942	220.300	0.236914
Sum256Base_Basic	1013.715	258.597	0.278100
Sum256Base	1189.559	220.371	0.236990
Sum256Base_Range52_Impl	2711.592	96.675	0.103966
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1189.622	220.359	0.236978
Sum256Traits_Range52	1378.040	190.230	0.204576

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
SumScalar	282.019	929.527
SumBcl	108.314	2420.226	2.603718
SumBase_Range52_Impl	134.761	1945.251	2.092731
SumTraits	108.107	2424.854	2.608696
SumTraits_Range52	108.035	2426.466	2.610430
Sum128Bcl	108.005	2427.148	2.611164
Sum128Base_Basic	401.435	653.017	0.702526
Sum128Base	108.211	2422.520	2.606185
Sum128Base_Range52_Impl	136.044	1926.907	2.072996
Sum128AdvSimd_Range52	108.095	2425.131	2.608994
Sum128AdvSimd_Range52_Impl	268.168	977.535	1.051648
Sum128Traits	108.060	2425.910	2.609832
Sum128Traits_Range52	107.837	2430.927	2.615229
Sum256Bcl	1148.350	228.279	0.245586
Sum256Base_Basic	1022.083	256.480	0.275925
Sum256Base	1149.052	228.139	0.245436
Sum256Base_Range52_Impl	2405.183	108.991	0.117255
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1147.919	228.365	0.245678
Sum256Traits_Range52	1373.130	190.910	0.205384

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
SumScalar	229.820	1140.649
SumBcl	106.312	2465.796	2.161749
SumBase_Range52_Impl	308.728	849.111	0.744410
SumBase_Range52RoundToEven	132.753	1974.677	1.731188
SumTraits	106.375	2464.344	2.160476
SumTraits_Range52	106.426	2463.161	2.159439
SumTraits_Range52RoundToEven	106.580	2459.605	2.156321
Sum128Bcl	106.907	2452.073	2.149718
Sum128Base_Basic	396.134	661.756	0.580157
Sum128Base	106.949	2451.121	2.148883
Sum128Base_Range52_Impl	240.167	1091.508	0.956919
Sum128AdvSimd_Range52	106.452	2462.560	2.158912
Sum128AdvSimd_Range52_Impl	315.316	831.369	0.728856
Sum128Traits	108.862	2408.044	2.111118
Sum128Traits_Range52	109.191	2400.781	2.104750
Sum128Traits_Range52RoundToEven	110.169	2379.476	2.086072
Sum256Bcl	989.471	264.933	0.232266
Sum256Base_Basic	1019.621	257.100	0.225398
Sum256Base	1150.286	227.895	0.199794
Sum256Base_Range52_Impl	5410.151	48.454	0.042479
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1128.471	232.300	0.203656
Sum256Traits_Range52	1358.216	193.006	0.169207
Sum256Traits_Range52RoundToEven	2507.644	104.538	0.091648

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 5047608992447799917!=5047608992447735894
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	232.191	1129.002
SumBcl	110.222	2378.326	2.106573
SumBase_Range52_Impl	321.374	815.697	0.722493
SumBase_Range52RoundToEven	137.101	1912.056	1.693580
SumTraits	110.326	2376.079	2.104582
SumTraits_Range52	109.456	2394.973	2.121318
SumTraits_Range52RoundToEven	109.911	2385.062	2.112539
Sum128Bcl	109.069	2403.468	2.128842
Sum128Base_Basic	412.523	635.465	0.562855
Sum128Base	109.793	2387.625	2.114810
Sum128Base_Range52_Impl	265.364	987.864	0.874988
Sum128AdvSimd_Range52	110.020	2382.697	2.110445
Sum128AdvSimd_Range52_Impl	349.881	749.237	0.663627
Sum128Traits	110.814	2365.613	2.095313
Sum128Traits_Range52	110.557	2371.119	2.100189
Sum128Traits_Range52RoundToEven	110.640	2369.347	2.098620
Sum256Bcl	987.228	265.536	0.235195
Sum256Base_Basic	1041.118	251.791	0.223021
Sum256Base	1157.169	226.539	0.200654
Sum256Base_Range52_Impl	5517.065	47.515	0.042086
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1160.784	225.833	0.200029
Sum256Traits_Range52	1156.416	226.687	0.200785
Sum256Traits_Range52RoundToEven	2246.732	116.678	0.103346

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

