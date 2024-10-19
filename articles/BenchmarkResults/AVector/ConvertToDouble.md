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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.25916332878302E+21
SumScalar	230.289	1138.328
SumBcl	146.963	1783.739	1.566982
SumBase_Range52_Impl	58.536	4478.307	3.934110
SumTraits	151.472	1730.644	1.520339
SumTraits_Range52	58.543	4477.813	3.933677

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.62582413852431E+24
SumScalar	768.087	341.295
SumBcl	113.674	2306.101	6.756917
SumBase_Range52_Impl	58.394	4489.217	13.153487
SumTraits	111.832	2344.096	6.868245
SumTraits_Range52	58.537	4478.226	13.121284

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	159.978	1638.626
SumBcl	149.408	1754.547	1.070743
SumBase_Range52_Impl	129.952	2017.237	1.231054
SumBase_Range52RoundToEven	34.234	7657.413	4.673070
SumTraits	151.671	1728.372	1.054769
SumTraits_Range52	146.713	1786.787	1.090418
SumTraits_Range52RoundToEven	33.985	7713.485	4.707289

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	974.497	269.005
SumBcl	1540.306	170.190	0.632664
SumBase_Range52_Impl	140.051	1871.772	6.958141
SumBase_Range52RoundToEven	37.608	6970.436	25.911962
SumTraits	1566.443	167.350	0.622108
SumTraits_Range52	133.423	1964.761	7.303820
SumTraits_Range52RoundToEven	33.890	7735.064	28.754398

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
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.25916332878302E+21
SumScalar	230.375	1137.900
SumBcl	157.283	1666.708	1.464722
SumBase_Range52_Impl	58.160	4507.281	3.961051
SumTraits	161.015	1628.077	1.430773
SumTraits_Range52	58.481	4482.558	3.939324

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.62582413852431E+24
SumScalar	789.793	331.915
SumBcl	116.279	2254.436	6.792210
SumBase_Range52_Impl	58.068	4514.439	13.601196
SumTraits	115.893	2261.942	6.814826
SumTraits_Range52	58.121	4510.294	13.588708

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	164.262	1595.892
SumBcl	160.506	1633.239	1.023402
SumBase_Range52_Impl	148.697	1762.935	1.104671
SumBase_Range52RoundToEven	37.386	7011.856	4.393690
SumTraits	160.315	1635.181	1.024618
SumTraits_Range52	156.309	1677.086	1.050877
SumTraits_Range52RoundToEven	37.802	6934.704	4.345346

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	970.486	270.116
SumBcl	1641.204	159.727	0.591326
SumBase_Range52_Impl	143.500	1826.783	6.762956
SumBase_Range52RoundToEven	38.424	6822.432	25.257406
SumTraits	1565.507	167.450	0.619918
SumTraits_Range52	149.299	1755.834	6.500294
SumTraits_Range52RoundToEven	35.990	7283.890	26.965774

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
SumScalar	230.574	1136.919
SumBcl	151.807	1726.822	1.518861
SumBase_Range52_Impl	58.273	4498.555	3.956793
SumTraits	79.170	3311.139	2.912378
SumTraits_Range52	58.370	4491.106	3.950241
Sum128Base_Basic	941.658	278.386	0.244860
Sum128Base	939.772	278.944	0.245351
Sum128Base_Range52_Impl	941.488	278.436	0.244904
Sum128Traits	152.406	1720.034	1.512890
Sum128Traits_Range52	116.599	2248.248	1.977492
Sum256Base_Basic	514.600	509.413	0.448064
Sum256Base	513.823	510.183	0.448742
Sum256Base_Range52_Impl	514.222	509.788	0.448394
Sum256Avx2_Bcl	78.797	3326.829	2.926178
Sum256Avx2_HwScalar	158.855	1650.213	1.451477
Sum256Avx2_Range52	58.823	4456.488	3.919793
Sum256Traits	76.494	3427.010	3.014295
Sum256Traits_Range52	58.295	4496.869	3.955310

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
SumScalar	735.168	356.577
SumBcl	116.196	2256.057	6.326979
SumBase_Range52_Impl	58.267	4499.029	12.617263
SumTraits	78.506	3339.149	9.364449
SumTraits_Range52	58.482	4482.461	12.570802
Sum128Base_Basic	1058.060	247.759	0.694826
Sum128Base	1090.743	240.335	0.674006
Sum128Base_Range52_Impl	1060.180	247.264	0.693436
Sum128Traits	156.206	1678.198	4.706409
Sum128Traits_Range52	116.161	2256.730	6.328866
Sum256Base_Basic	935.873	280.106	0.785542
Sum256Base	949.338	276.133	0.774400
Sum256Base_Range52_Impl	933.453	280.833	0.787579
Sum256Avx2_Bcl	78.166	3353.687	9.405219
Sum256Avx2_Range52	58.045	4516.192	12.665398
Sum256Traits	79.589	3293.701	9.236993
Sum256Traits_Range52	58.329	4494.216	12.603766

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
SumScalar	163.794	1600.449
SumBcl	156.885	1670.933	1.044040
SumBase_Range52_Impl	124.776	2100.918	1.312706
SumBase_Range52RoundToEven	36.620	7158.505	4.472811
SumTraits	141.589	1851.438	1.156824
SumTraits_Range52	44.097	5944.655	3.714368
SumTraits_Range52RoundToEven	39.848	6578.539	4.110435
Sum128Base_Basic	901.476	290.794	0.181695
Sum128Base	902.599	290.432	0.181469
Sum128Base_Range52_Impl	900.823	291.005	0.181827
Sum128Traits	285.938	916.785	0.572830
Sum128Traits_Range52	79.532	3296.085	2.059476
Sum128Traits_Range52RoundToEven	74.829	3503.241	2.188912
Sum256Base_Basic	495.384	529.174	0.330641
Sum256Base	494.138	530.507	0.331474
Sum256Base_Range52_Impl	496.289	528.208	0.330037
Sum256Avx2_HwScalar	165.615	1582.852	0.989005
Sum256Avx2_ShiftVar	122.002	2148.678	1.342547
Sum256Avx2_ShiftVarFix	137.352	1908.552	1.192511
Sum256Avx2_Range52	43.607	6011.455	3.756107
Sum256Traits	139.790	1875.265	1.171712
Sum256Traits_Range52	43.221	6065.159	3.789662
Sum256Traits_Range52RoundToEven	39.381	6656.631	4.159228

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
SumScalar	1086.031	241.378
SumBcl	1594.786	164.376	0.680989
SumBase_Range52_Impl	124.055	2113.133	8.754453
SumBase_Range52RoundToEven	38.425	6822.259	28.263797
SumTraits	90.775	2887.840	11.963974
SumTraits_Range52	43.506	6025.482	24.962844
SumTraits_Range52RoundToEven	39.865	6575.867	27.243023
Sum128Base_Basic	1182.897	221.612	0.918111
Sum128Base	1160.818	225.827	0.935574
Sum128Base_Range52_Impl	1183.996	221.406	0.917259
Sum128Traits	174.849	1499.256	6.211238
Sum128Traits_Range52	82.680	3170.567	13.135277
Sum128Traits_Range52RoundToEven	71.948	3643.508	15.094615
Sum256Base_Basic	1100.224	238.264	0.987100
Sum256Base	1101.968	237.887	0.985538
Sum256Base_Range52_Impl	1106.214	236.974	0.981755
Sum256Avx2_ShiftVar	87.794	2985.914	12.370280
Sum256Avx2_Range52	43.436	6035.207	25.003134
Sum256Traits	91.375	2868.868	11.885374
Sum256Traits_Range52	43.131	6077.850	25.179802
Sum256Traits_Range52RoundToEven	39.556	6627.138	27.455434

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
SumScalar	231.271	1133.493
SumBcl	151.942	1725.295	1.522104
SumBase_Range52_Impl	58.331	4494.114	3.964836
SumTraits	64.214	4082.377	3.601590
SumTraits_Range52	58.087	4512.945	3.981449
Sum128Base_Basic	946.030	277.099	0.244465
Sum128Base	941.984	278.289	0.245515
Sum128Base_Range52_Impl	944.577	277.525	0.244841
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	125.899	2082.181	1.836959
Sum128Traits_Range52	115.833	2263.122	1.996591
Sum256Base_Basic	516.879	507.167	0.447437
Sum256Base	519.954	504.168	0.444791
Sum256Base_Range52_Impl	526.864	497.555	0.438957
Sum256Avx2_Bcl	63.997	4096.189	3.613775
Sum256Avx2_HwScalar	161.213	1626.068	1.434564
Sum256Avx2_Range52	58.217	4502.850	3.972543
Sum256Traits	64.001	4095.964	3.613577
Sum256Traits_Range52	58.335	4493.781	3.964542

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
SumScalar	712.858	367.737
SumBcl	115.691	2265.902	6.161755
SumBase_Range52_Impl	58.171	4506.452	12.254568
SumTraits	63.436	4132.420	11.237448
SumTraits_Range52	58.370	4491.039	12.212653
Sum128Base_Basic	1081.745	242.334	0.658989
Sum128Base	1082.995	242.055	0.658229
Sum128Base_Range52_Impl	1083.367	241.971	0.658002
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	126.337	2074.959	5.642514
Sum128Traits_Range52	115.708	2265.560	6.160823
Sum256Base_Basic	932.727	281.051	0.764274
Sum256Base	941.996	278.286	0.756753
Sum256Base_Range52_Impl	927.884	282.518	0.768262
Sum256Avx2_Bcl	62.175	4216.202	11.465279
Sum256Avx2_Range52	58.228	4502.041	12.242572
Sum256Traits	63.143	4151.561	11.289498
Sum256Traits_Range52	58.451	4484.841	12.195800

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
SumScalar	164.037	1598.075
SumBcl	160.797	1630.275	1.020150
SumBase_Range52_Impl	59.956	4372.285	2.735971
SumBase_Range52RoundToEven	38.464	6815.281	4.264683
SumTraits	119.097	2201.093	1.377341
SumTraits_Range52	40.315	6502.462	4.068935
SumTraits_Range52RoundToEven	38.580	6794.903	4.251931
Sum128Base_Basic	908.919	288.413	0.180475
Sum128Base	906.427	289.206	0.180971
Sum128Base_Range52_Impl	907.820	288.762	0.180694
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	236.063	1110.483	0.694888
Sum128Traits_Range52	76.662	3419.467	2.139742
Sum128Traits_Range52RoundToEven	66.749	3927.285	2.457510
Sum256Base_Basic	502.338	521.848	0.326548
Sum256Base	501.809	522.398	0.326892
Sum256Base_Range52_Impl	505.413	518.673	0.324561
Sum256Avx2_HwScalar	169.054	1550.655	0.970327
Sum256Avx2_ShiftVar	102.987	2545.404	1.592794
Sum256Avx2_ShiftVarFix	112.893	2322.051	1.453031
Sum256Avx2_Range52	40.819	6422.094	4.018644
Sum256Traits	123.289	2126.255	1.330511
Sum256Traits_Range52	40.509	6471.331	4.049455
Sum256Traits_Range52RoundToEven	36.503	7181.377	4.493769

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
SumScalar	986.665	265.687
SumBcl	1375.725	190.550	0.717196
SumBase_Range52_Impl	63.805	4108.526	15.463785
SumBase_Range52RoundToEven	33.539	7816.186	29.418778
SumTraits	74.619	3513.113	13.222751
SumTraits_Range52	38.399	6826.889	25.695233
SumTraits_Range52RoundToEven	33.976	7715.611	29.040230
Sum128Base_Basic	1158.107	226.356	0.851963
Sum128Base	1185.352	221.153	0.832381
Sum128Base_Range52_Impl	1171.328	223.801	0.842347
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	159.084	1647.829	6.202144
Sum128Traits_Range52	72.392	3621.163	13.629434
Sum128Traits_Range52RoundToEven	67.010	3912.023	14.724179
Sum256Base_Basic	1118.523	234.366	0.882114
Sum256Base	1109.234	236.329	0.889501
Sum256Base_Range52_Impl	1111.845	235.774	0.887412
Sum256Avx2_ShiftVar	74.616	3513.235	13.223213
Sum256Avx2_Range52	39.379	6656.904	25.055439
Sum256Traits	76.662	3419.469	12.870291
Sum256Traits_Range52	39.674	6607.416	24.869174
Sum256Traits_Range52RoundToEven	34.113	7684.661	28.923742

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
SumScalar	230.168	1138.926
SumBcl	156.742	1672.452	1.468447
SumBase_Range52_Impl	58.014	4518.671	3.967484
SumTraits	59.850	4380.002	3.845730
SumTraits_Range52	58.418	4487.376	3.940006
Sum128Base_Basic	950.363	275.836	0.242189
Sum128Base	947.256	276.740	0.242984
Sum128Base_Range52_Impl	945.555	277.238	0.243421
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	119.500	2193.677	1.926092
Sum128Traits_Range52	115.443	2270.771	1.993783
Sum256Base_Basic	513.372	510.632	0.448345
Sum256Base	514.276	509.734	0.447557
Sum256Base_Range52_Impl	514.158	509.852	0.447660
Sum256Avx2_Bcl	60.148	4358.339	3.826709
Sum256Avx2_HwScalar	158.859	1650.168	1.448881
Sum256Avx2_Range52	59.151	4431.773	3.891186
Sum256Traits	60.245	4351.279	3.820510
Sum256Traits_Range52	58.340	4493.398	3.945293

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
SumScalar	711.201	368.594
SumBcl	115.789	2263.979	6.142210
SumBase_Range52_Impl	58.655	4469.219	12.125060
SumTraits	60.232	4352.220	11.807639
SumTraits_Range52	58.264	4499.255	12.206546
Sum128Base_Basic	1058.024	247.768	0.672197
Sum128Base	1071.493	244.653	0.663747
Sum128Base_Range52_Impl	1062.903	246.630	0.669111
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	119.860	2187.089	5.933605
Sum128Traits_Range52	116.035	2259.172	6.129167
Sum256Base_Basic	926.601	282.909	0.767537
Sum256Base	929.168	282.128	0.765417
Sum256Base_Range52_Impl	923.836	283.756	0.769835
Sum256Avx2_Bcl	60.233	4352.187	11.807550
Sum256Avx2_Range52	58.436	4486.005	12.170599
Sum256Traits	60.085	4362.896	11.836604
Sum256Traits_Range52	58.268	4498.954	12.205731

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
SumScalar	163.481	1603.518
SumBcl	155.277	1688.237	1.052833
SumBase_Range52_Impl	61.429	4267.413	2.661282
SumBase_Range52RoundToEven	38.064	6886.875	4.294854
SumTraits	106.840	2453.610	1.530142
SumTraits_Range52	37.897	6917.255	4.313800
SumTraits_Range52RoundToEven	35.592	7365.267	4.593193
Sum128Base_Basic	905.615	289.465	0.180519
Sum128Base	906.517	289.177	0.180339
Sum128Base_Range52_Impl	910.640	287.868	0.179523
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	212.847	1231.606	0.768065
Sum128Traits_Range52	74.076	3538.835	2.206920
Sum128Traits_Range52RoundToEven	68.331	3836.373	2.392473
Sum256Base_Basic	496.676	527.797	0.329149
Sum256Base	497.046	527.404	0.328905
Sum256Base_Range52_Impl	496.759	527.709	0.329095
Sum256Avx2_HwScalar	162.283	1615.349	1.007379
Sum256Avx2_ShiftVar	91.214	2873.944	1.792274
Sum256Avx2_ShiftVarFix	108.955	2405.989	1.500444
Sum256Avx2_Range52	40.154	6528.405	4.071302
Sum256Traits	106.229	2467.732	1.538949
Sum256Traits_Range52	39.501	6636.340	4.138613
Sum256Traits_Range52RoundToEven	34.892	7512.979	4.685311

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
SumScalar	1025.973	255.508
SumBcl	1365.430	191.986	0.751392
SumBase_Range52_Impl	62.034	4225.794	16.538822
SumBase_Range52RoundToEven	34.316	7639.011	29.897394
SumTraits	75.038	3493.482	13.672713
SumTraits_Range52	36.564	7169.392	28.059410
SumTraits_Range52RoundToEven	32.917	7963.862	31.168790
Sum128Base_Basic	1184.512	221.310	0.866157
Sum128Base	1166.958	224.639	0.879186
Sum128Base_Range52_Impl	1196.793	219.039	0.857269
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	145.967	1795.908	7.028786
Sum128Traits_Range52	77.295	3391.479	13.273496
Sum128Traits_Range52RoundToEven	69.252	3785.339	14.814975
Sum256Base_Basic	1117.851	234.507	0.917809
Sum256Base	1134.886	230.987	0.904032
Sum256Base_Range52_Impl	1142.213	229.505	0.898233
Sum256Avx2_ShiftVar	73.951	3544.814	13.873614
Sum256Avx2_Range52	38.570	6796.506	26.600016
Sum256Traits	73.320	3575.332	13.993056
Sum256Traits_Range52	36.865	7111.012	27.830923
Sum256Traits_Range52RoundToEven	33.718	7774.516	30.427732

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
SumScalar	230.903	1135.301
SumBcl	60.216	4353.395	3.834575
SumBase_Range52_Impl	58.284	4497.730	3.961708
SumTraits	60.085	4362.887	3.842935
SumTraits_Range52	58.761	4461.216	3.929546
Sum128Bcl	119.319	2197.004	1.935174
Sum128Base_Basic	944.639	277.507	0.244435
Sum128Base	119.366	2196.144	1.934416
Sum128Base_Range52_Impl	115.961	2260.615	1.991204
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	119.512	2193.453	1.932046
Sum128Traits_Range52	115.890	2262.011	1.992433
Sum256Bcl	59.959	4372.025	3.850984
Sum256Base_Basic	515.504	508.520	0.447917
Sum256Base	60.223	4352.892	3.834131
Sum256Base_Range52_Impl	58.394	4489.240	3.954230
Sum256Avx2_Bcl	60.124	4360.025	3.840414
Sum256Avx2_HwScalar	159.586	1642.647	1.446883
Sum256Avx2_Range52	58.663	4468.637	3.936082
Sum256Traits	60.147	4358.358	3.838946
Sum256Traits_Range52	58.573	4475.541	3.942164

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
SumScalar	682.192	384.267
SumBcl	60.559	4328.772	11.265004
SumBase_Range52_Impl	58.617	4472.157	11.638144
SumTraits	59.783	4384.902	11.411076
SumTraits_Range52	58.515	4479.913	11.658328
Sum128Bcl	118.997	2202.955	5.732874
Sum128Base_Basic	1063.421	246.510	0.641507
Sum128Base	119.259	2198.103	5.720246
Sum128Base_Range52_Impl	115.954	2260.749	5.883274
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	119.933	2185.758	5.688121
Sum128Traits_Range52	115.713	2265.459	5.895531
Sum256Bcl	60.204	4354.259	11.331331
Sum256Base_Basic	948.875	276.268	0.718948
Sum256Base	60.006	4368.641	11.368759
Sum256Base_Range52_Impl	58.121	4510.324	11.737468
Sum256Avx2_Bcl	61.029	4295.434	11.178249
Sum256Avx2_Range52	58.547	4477.522	11.652106
Sum256Traits	60.032	4366.718	11.363754
Sum256Traits_Range52	58.361	4491.777	11.689201

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
SumScalar	162.047	1617.700
SumBcl	507.758	516.277	0.319143
SumBase_Range52_Impl	62.699	4181.004	2.584536
SumBase_Range52RoundToEven	34.161	7673.773	4.743631
SumTraits	104.557	2507.194	1.549851
SumTraits_Range52	43.013	6094.533	3.767406
SumTraits_Range52RoundToEven	42.830	6120.616	3.783529
Sum128Bcl	911.417	287.623	0.177797
Sum128Base_Basic	900.416	291.137	0.179969
Sum128Base	914.320	286.709	0.177233
Sum128Base_Range52_Impl	113.701	2305.564	1.425211
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	203.129	1290.529	0.797755
Sum128Traits_Range52	70.582	3714.017	2.295863
Sum128Traits_Range52RoundToEven	71.012	3691.546	2.281971
Sum256Bcl	481.962	543.910	0.336224
Sum256Base_Basic	495.968	528.550	0.326729
Sum256Base	482.985	542.758	0.335512
Sum256Base_Range52_Impl	62.916	4166.561	2.575607
Sum256Avx2_HwScalar	165.073	1588.051	0.981672
Sum256Avx2_ShiftVar	88.470	2963.079	1.831661
Sum256Avx2_ShiftVarFix	101.761	2576.074	1.592430
Sum256Avx2_Range52	42.249	6204.789	3.835562
Sum256Traits	104.261	2514.294	1.554240
Sum256Traits_Range52	43.432	6035.781	3.731088
Sum256Traits_Range52RoundToEven	41.891	6257.690	3.868263

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
SumScalar	988.226	265.267
SumBcl	1090.824	240.317	0.905944
SumBase_Range52_Impl	62.247	4211.328	15.875796
SumBase_Range52RoundToEven	33.664	7786.992	29.355275
SumTraits	72.007	3640.510	13.723936
SumTraits_Range52	42.511	6166.445	23.246164
SumTraits_Range52RoundToEven	41.181	6365.631	23.997050
Sum128Bcl	1166.190	224.787	0.847397
Sum128Base_Basic	1160.627	225.864	0.851459
Sum128Base	1167.254	224.582	0.846625
Sum128Base_Range52_Impl	117.935	2222.792	8.379447
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	139.295	1881.938	7.094499
Sum128Traits_Range52	77.396	3387.049	12.768443
Sum128Traits_Range52RoundToEven	74.783	3505.374	13.214503
Sum256Bcl	1087.270	241.103	0.908906
Sum256Base_Basic	1088.198	240.897	0.908131
Sum256Base	1083.369	241.971	0.912179
Sum256Base_Range52_Impl	63.786	4109.712	15.492725
Sum256Avx2_ShiftVar	73.709	3556.478	13.407151
Sum256Avx2_Range52	43.663	6003.864	22.633268
Sum256Traits	71.953	3643.262	13.734311
Sum256Traits_Range52	41.937	6250.955	23.564747
Sum256Traits_Range52RoundToEven	40.842	6418.539	24.196505

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
SumScalar	230.038	1139.568
SumBcl	60.760	4314.428	3.786019
SumBase_Range52_Impl	58.839	4455.272	3.909613
SumTraits	58.505	4480.699	3.931926
SumTraits_Range52	58.690	4466.599	3.919553
Sum128Bcl	120.631	2173.102	1.906952
Sum128Base_Basic	958.544	273.481	0.239987
Sum128Base	119.950	2185.449	1.917787
Sum128Base_Range52_Impl	115.931	2261.199	1.984259
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	115.991	2260.038	1.983240
Sum128Traits_Range52	115.878	2262.247	1.985178
Sum256Bcl	61.284	4277.539	3.753648
Sum256Base_Basic	539.800	485.632	0.426154
Sum256Base	60.989	4298.224	3.771800
Sum256Base_Range52_Impl	58.583	4474.760	3.926714
Sum256Avx2_Bcl	60.695	4319.021	3.790050
Sum256Avx2_HwScalar	166.053	1578.679	1.385330
Sum256Avx2_Range52	58.593	4473.990	3.926039
Sum256Traits	58.528	4478.929	3.930372
Sum256Traits_Range52	58.843	4455.008	3.909382
Sum512Bcl	300.512	872.324	0.765486
Sum512Base	301.522	869.401	0.762921
Sum512Traits	34.280	7647.151	6.710567

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
SumScalar	244.692	1071.323
SumBcl	60.903	4304.313	4.017754
SumBase_Range52_Impl	58.476	4482.896	4.184447
SumTraits	58.347	4492.807	4.193698
SumTraits_Range52	58.544	4477.748	4.179642
Sum128Bcl	120.929	2167.744	2.023426
Sum128Base_Basic	992.607	264.096	0.246514
Sum128Base	120.595	2173.747	2.029030
Sum128Base_Range52_Impl	116.023	2259.417	2.108997
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	116.073	2258.444	2.108088
Sum128Traits_Range52	115.828	2263.224	2.112549
Sum256Bcl	61.598	4255.747	3.972421
Sum256Base_Basic	548.990	477.503	0.445713
Sum256Base	60.987	4298.339	4.012178
Sum256Base_Range52_Impl	59.007	4442.575	4.146811
Sum256Avx2_Bcl	61.141	4287.501	4.002061
Sum256Avx2_Range52	58.368	4491.225	4.192222
Sum256Traits	58.550	4477.267	4.179193
Sum256Traits_Range52	58.680	4467.321	4.169909
Sum512Bcl	300.244	873.102	0.814976
Sum512Base	302.282	867.217	0.809482
Sum512Traits	33.808	7753.940	7.237721

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
SumScalar	161.495	1623.235
SumBcl	506.776	517.278	0.318671
SumBase_Range52_Impl	66.156	3962.523	2.441128
SumBase_Range52RoundToEven	47.505	5518.297	3.399568
SumTraits	29.310	8943.808	5.509868
SumTraits_Range52	30.228	8672.266	5.342583
SumTraits_Range52RoundToEven	29.096	9009.652	5.550431
Sum128Bcl	999.525	262.269	0.161572
Sum128Base_Basic	922.493	284.169	0.175064
Sum128Base	1002.140	261.584	0.161150
Sum128Base_Range52_Impl	123.669	2119.720	1.305862
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	55.035	4763.183	2.934377
Sum128Traits_Range52	54.833	4780.778	2.945217
Sum128Traits_Range52RoundToEven	55.034	4763.328	2.934466
Sum256Bcl	958.715	273.433	0.168449
Sum256Base_Basic	526.528	497.872	0.306716
Sum256Base	957.191	273.868	0.168717
Sum256Base_Range52_Impl	66.637	3933.894	2.423490
Sum256Avx2_HwScalar	157.812	1661.119	1.023339
Sum256Avx2_ShiftVar	100.032	2620.609	1.614436
Sum256Avx2_ShiftVarFix	113.324	2313.218	1.425067
Sum256Avx2_Range52	29.474	8894.188	5.479299
Sum256Traits	29.535	8875.725	5.467925
Sum256Traits_Range52	29.566	8866.368	5.462161
Sum256Traits_Range52RoundToEven	29.885	8771.898	5.403962
Sum512Bcl	1475.890	177.618	0.109422
Sum512Base	1467.012	178.692	0.110084
Sum512Traits	26.987	9713.809	5.984230

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
SumScalar	989.298	264.980
SumBcl	1101.561	237.975	0.898087
SumBase_Range52_Impl	66.607	3935.655	14.852653
SumBase_Range52RoundToEven	43.550	6019.378	22.716358
SumTraits	29.528	8877.831	33.503789
SumTraits_Range52	29.690	8829.251	33.320457
SumTraits_Range52RoundToEven	29.174	8985.633	33.910621
Sum128Bcl	1498.830	174.899	0.660047
Sum128Base_Basic	1220.546	214.776	0.810537
Sum128Base	1490.029	175.932	0.663945
Sum128Base_Range52_Impl	118.582	2210.661	8.342749
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	55.925	4687.445	17.689813
Sum128Traits_Range52	53.670	4884.330	18.432833
Sum128Traits_Range52RoundToEven	53.965	4857.641	18.332110
Sum256Bcl	1499.537	174.817	0.659735
Sum256Base_Basic	1153.615	227.237	0.857563
Sum256Base	1511.259	173.461	0.654618
Sum256Base_Range52_Impl	66.348	3951.041	14.910718
Sum256Avx2_ShiftVar	78.425	3342.598	12.614533
Sum256Avx2_Range52	29.521	8879.996	33.511960
Sum256Traits	29.842	8784.506	33.151594
Sum256Traits_Range52	29.762	8808.130	33.240748
Sum256Traits_Range52RoundToEven	29.770	8805.704	33.231590
Sum512Bcl	2013.898	130.167	0.491235
Sum512Base	2020.444	129.746	0.489644
Sum512Traits	26.902	9744.563	36.774723

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 非數值!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. 非數值!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 非數值!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	230.879	1135.416
SumBcl	112.442	2331.370	2.053317
SumBase_Range52_Impl	115.651	2266.688	1.996350
SumTraits	115.614	2267.406	1.996982
SumTraits_Range52	115.659	2266.519	1.996201
Sum128Base_Basic	139.784	1875.354	1.651688
Sum128Base	140.290	1868.588	1.645729
Sum128Base_Range52_Impl	140.180	1870.054	1.647021
Sum128AdvSimd_Range52	115.703	2265.654	1.995439
Sum128AdvSimd_Range52_Impl	115.705	2265.626	1.995415
Sum128Traits	113.847	2302.603	2.027981
Sum128Traits_Range52	115.608	2267.529	1.997090
Sum256Base_Basic	660.090	397.134	0.349769
Sum256Base	786.558	333.280	0.293531
Sum256Base_Range52_Impl	786.635	333.247	0.293502
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	779.168	336.441	0.296315
Sum256Traits_Range52	779.213	336.421	0.296298

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 非數值!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. 非數值!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 非數值!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	231.290	1133.402
SumBcl	115.610	2267.488	2.000604
SumBase_Range52_Impl	115.630	2267.088	2.000251
SumTraits	115.628	2267.128	2.000286
SumTraits_Range52	115.609	2267.499	2.000614
Sum128Base_Basic	136.812	1916.083	1.690560
Sum128Base	136.862	1915.386	1.689944
Sum128Base_Range52_Impl	136.814	1916.058	1.690537
Sum128AdvSimd_Range52	115.673	2266.254	1.999515
Sum128AdvSimd_Range52_Impl	115.678	2266.146	1.999420
Sum128Traits	112.485	2330.481	2.056182
Sum128Traits_Range52	112.443	2331.357	2.056955
Sum256Base_Basic	658.426	398.138	0.351277
Sum256Base	778.799	336.600	0.296982
Sum256Base_Range52_Impl	773.166	339.053	0.299146
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	779.333	336.370	0.296779
Sum256Traits_Range52	775.812	337.896	0.298126

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
SumScalar	155.034	1690.882
SumBcl	77.111	3399.553	2.010521
SumBase_Range52_Impl	96.436	2718.321	1.607635
SumBase_Range52RoundToEven	77.104	3399.855	2.010699
SumTraits	77.088	3400.578	2.011127
SumTraits_Range52	77.120	3399.154	2.010285
SumTraits_Range52RoundToEven	77.091	3400.471	2.011063
Sum128Base_Basic	114.464	2290.195	1.354438
Sum128Base	114.184	2295.804	1.357755
Sum128Base_Range52_Impl	114.490	2289.662	1.354123
Sum128AdvSimd_Range52	96.459	2717.670	1.607250
Sum128AdvSimd_Range52_Impl	96.467	2717.438	1.607113
Sum128Traits	77.103	3399.905	2.010729
Sum128Traits_Range52	77.092	3400.408	2.011026
Sum128Traits_Range52RoundToEven	77.094	3400.328	2.010979
Sum256Base_Basic	519.974	504.148	0.298157
Sum256Base	620.324	422.592	0.249924
Sum256Base_Range52_Impl	619.735	422.994	0.250162
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	619.631	423.065	0.250204
Sum256Traits_Range52	619.722	423.003	0.250167
Sum256Traits_Range52RoundToEven	619.823	422.934	0.250126

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
SumScalar	155.078	1690.404
SumBcl	309.143	847.969	0.501637
SumBase_Range52_Impl	96.402	2719.271	1.608652
SumBase_Range52RoundToEven	77.072	3401.300	2.012123
SumTraits	77.099	3400.103	2.011415
SumTraits_Range52	77.089	3400.541	2.011674
SumTraits_Range52RoundToEven	77.124	3399.014	2.010771
Sum128Base_Basic	111.918	2342.283	1.385636
Sum128Base	111.866	2343.382	1.386286
Sum128Base_Range52_Impl	111.874	2343.206	1.386182
Sum128AdvSimd_Range52	96.431	2718.449	1.608165
Sum128AdvSimd_Range52_Impl	96.411	2719.025	1.608506
Sum128Traits	77.244	3393.724	2.007641
Sum128Traits_Range52	77.096	3400.227	2.011488
Sum128Traits_Range52RoundToEven	77.219	3394.818	2.008288
Sum256Base_Basic	542.687	483.048	0.285759
Sum256Base	611.053	429.004	0.253788
Sum256Base_Range52_Impl	586.093	447.274	0.264596
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	555.220	472.145	0.279309
Sum256Traits_Range52	579.081	452.690	0.267800
Sum256Traits_Range52RoundToEven	573.242	457.301	0.270528

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 非數值!=-3.259163328783052E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 非數值!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 非數值!=-3.259163328783052E+21
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 非數值!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	231.154	1134.064
SumBcl	115.553	2268.603	2.000419
SumBase_Range52_Impl	115.585	2267.970	1.999860
SumTraits	115.566	2268.344	2.000190
SumTraits_Range52	115.601	2267.670	1.999596
Sum128Bcl	115.573	2268.206	2.000068
Sum128Base_Basic	138.011	1899.437	1.674893
Sum128Base	115.572	2268.238	2.000097
Sum128Base_Range52_Impl	115.615	2267.397	1.999354
Sum128AdvSimd_Range52	115.572	2268.232	2.000091
Sum128AdvSimd_Range52_Impl	115.640	2266.891	1.998909
Sum128Traits	115.589	2267.896	1.999794
Sum128Traits_Range52	115.593	2267.812	1.999721
Sum256Bcl	544.508	481.433	0.424520
Sum256Base_Basic	527.368	497.080	0.438317
Sum256Base	544.488	481.451	0.424536
Sum256Base_Range52_Impl	1504.793	174.206	0.153612
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	544.171	481.731	0.424783
Sum256Traits_Range52	598.210	438.214	0.386411

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 非數值!=3.625824138524267E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 非數值!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 非數值!=3.625824138524267E+24
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 非數值!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	231.202	1133.831
SumBcl	115.569	2268.293	2.000556
SumBase_Range52_Impl	115.591	2267.855	2.000170
SumTraits	115.583	2268.020	2.000315
SumTraits_Range52	115.575	2268.165	2.000443
Sum128Bcl	115.570	2268.271	2.000536
Sum128Base_Basic	134.616	1947.352	1.717497
Sum128Base	115.561	2268.454	2.000698
Sum128Base_Range52_Impl	115.591	2267.856	2.000171
Sum128AdvSimd_Range52	115.568	2268.315	2.000575
Sum128AdvSimd_Range52_Impl	115.618	2267.330	1.999706
Sum128Traits	115.585	2267.967	2.000268
Sum128Traits_Range52	115.577	2268.141	2.000422
Sum256Bcl	544.501	481.439	0.424612
Sum256Base_Basic	524.449	499.847	0.440848
Sum256Base	544.495	481.444	0.424617
Sum256Base_Range52_Impl	1420.664	184.522	0.162742
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	544.584	481.366	0.424548
Sum256Traits_Range52	594.262	441.125	0.389057

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
SumScalar	116.647	2247.321
SumBcl	77.039	3402.723	1.514124
SumBase_Range52_Impl	86.746	3021.979	1.344703
SumBase_Range52RoundToEven	77.061	3401.786	1.513707
SumTraits	77.053	3402.116	1.513854
SumTraits_Range52	77.071	3401.333	1.513506
SumTraits_Range52RoundToEven	77.061	3401.792	1.513710
Sum128Bcl	77.062	3401.719	1.513677
Sum128Base_Basic	112.802	2323.924	1.034086
Sum128Base	77.045	3402.478	1.514015
Sum128Base_Range52_Impl	78.195	3352.455	1.491756
Sum128AdvSimd_Range52	77.047	3402.392	1.513977
Sum128AdvSimd_Range52_Impl	86.931	3015.554	1.341844
Sum128Traits	77.057	3401.955	1.513782
Sum128Traits_Range52	77.042	3402.606	1.514072
Sum128Traits_Range52RoundToEven	77.065	3401.596	1.513622
Sum256Bcl	439.339	596.678	0.265506
Sum256Base_Basic	438.617	597.660	0.265943
Sum256Base	493.389	531.314	0.236421
Sum256Base_Range52_Impl	2570.399	101.986	0.045381
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	493.705	530.973	0.236269
Sum256Traits_Range52	524.957	499.363	0.222204
Sum256Traits_Range52RoundToEven	1258.854	208.240	0.092662

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
SumScalar	116.621	2247.837
SumBcl	77.047	3402.398	1.513632
SumBase_Range52_Impl	86.735	3022.343	1.344556
SumBase_Range52RoundToEven	77.062	3401.717	1.513329
SumTraits	77.064	3401.652	1.513300
SumTraits_Range52	77.047	3402.380	1.513624
SumTraits_Range52RoundToEven	77.066	3401.553	1.513256
Sum128Bcl	77.058	3401.908	1.513414
Sum128Base_Basic	110.107	2380.812	1.059157
Sum128Base	77.059	3401.850	1.513388
Sum128Base_Range52_Impl	77.107	3399.747	1.512453
Sum128AdvSimd_Range52	77.066	3401.548	1.513254
Sum128AdvSimd_Range52_Impl	86.837	3018.788	1.342975
Sum128Traits	77.065	3401.601	1.513278
Sum128Traits_Range52	77.059	3401.873	1.513398
Sum128Traits_Range52RoundToEven	77.056	3401.981	1.513446
Sum256Bcl	436.826	600.111	0.266972
Sum256Base_Basic	437.785	598.797	0.266388
Sum256Base	486.065	539.319	0.239928
Sum256Base_Range52_Impl	2349.729	111.563	0.049631
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	486.470	538.870	0.239728
Sum256Traits_Range52	491.333	533.536	0.237355
Sum256Traits_Range52RoundToEven	999.433	262.293	0.116687

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 非數值!=-3.259163328783052E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 非數值!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 非數值!=-3.259163328783052E+21
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 非數值!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.259163328783023E+21!=-3.259163328783052E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -3.259163328783023E+21!=-3.259163328783052E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.259163328783023E+21!=-3.259163328783052E+21
SumScalar	231.153	1134.070
SumBcl	112.409	2332.061	2.056364
SumBase_Range52_Impl	115.588	2267.912	1.999799
SumTraits	112.430	2331.625	2.055980
SumTraits_Range52	112.398	2332.283	2.056560
Sum128Bcl	112.391	2332.436	2.056696
Sum128Base_Basic	138.320	1895.197	1.671147
Sum128Base	112.401	2332.222	2.056507
Sum128Base_Range52_Impl	115.557	2268.528	2.000342
Sum128AdvSimd_Range52	112.404	2332.153	2.056446
Sum128AdvSimd_Range52_Impl	115.605	2267.586	1.999512
Sum128Traits	112.424	2331.737	2.056079
Sum128Traits_Range52	112.406	2332.124	2.056420
Sum256Bcl	57.779	4537.012	4.000647
Sum256Base_Basic	131.975	1986.317	1.751494
Sum256Base	57.795	4535.767	3.999548
Sum256Base_Range52_Impl	57.819	4533.895	3.997898
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	57.775	4537.298	4.000898
Sum256Traits_Range52	57.782	4536.814	4.000472
Sum512Bcl	28.956	9053.050	7.982798
Sum512Base	28.963	9051.040	7.981026
Sum512Traits	28.965	9050.424	7.980483

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 非數值!=3.625824138524267E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 非數值!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. 非數值!=3.625824138524267E+24
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 非數值!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 3.6258241385243226E+24!=3.625824138524267E+24
Check-Sum512Base	Check `Sum512Base` mismatch. 3.6258241385243226E+24!=3.625824138524267E+24
Check-Sum512Traits	Check `Sum512Traits` mismatch. 3.6258241385243226E+24!=3.625824138524267E+24
SumScalar	231.193	1133.875
SumBcl	112.390	2332.449	2.057060
SumBase_Range52_Impl	115.595	2267.788	2.000033
SumTraits	112.393	2332.397	2.057013
SumTraits_Range52	112.407	2332.089	2.056741
Sum128Bcl	112.398	2332.289	2.056918
Sum128Base_Basic	134.716	1945.902	1.716152
Sum128Base	112.402	2332.207	2.056846
Sum128Base_Range52_Impl	115.560	2268.469	2.000634
Sum128AdvSimd_Range52	112.393	2332.394	2.057011
Sum128AdvSimd_Range52_Impl	115.602	2267.639	1.999901
Sum128Traits	112.442	2331.380	2.056116
Sum128Traits_Range52	112.423	2331.771	2.056461
Sum256Bcl	57.787	4536.388	4.000782
Sum256Base_Basic	134.855	1943.895	1.714382
Sum256Base	57.779	4537.003	4.001324
Sum256Base_Range52_Impl	57.813	4534.382	3.999012
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	57.782	4536.775	4.001123
Sum256Traits_Range52	57.774	4537.368	4.001646
Sum512Bcl	28.925	9062.899	7.992853
Sum512Base	28.918	9065.223	7.994902
Sum512Traits	28.922	9063.756	7.993608

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
SumScalar	116.655	2247.165
SumBcl	77.054	3402.060	1.513934
SumBase_Range52_Impl	78.200	3352.229	1.491759
SumBase_Range52RoundToEven	77.091	3400.447	1.513216
SumTraits	77.048	3402.349	1.514063
SumTraits_Range52	77.044	3402.544	1.514150
SumTraits_Range52RoundToEven	77.067	3401.498	1.513684
Sum128Bcl	77.054	3402.088	1.513946
Sum128Base_Basic	113.284	2314.049	1.029763
Sum128Base	77.054	3402.065	1.513936
Sum128Base_Range52_Impl	78.210	3351.817	1.491575
Sum128AdvSimd_Range52	77.053	3402.123	1.513962
Sum128AdvSimd_Range52_Impl	78.307	3347.639	1.489717
Sum128Traits	77.063	3401.701	1.513774
Sum128Traits_Range52	77.062	3401.717	1.513782
Sum128Traits_Range52RoundToEven	77.063	3401.676	1.513763
Sum256Bcl	38.538	6802.198	3.027013
Sum256Base_Basic	101.880	2573.070	1.145029
Sum256Base	38.540	6801.951	3.026903
Sum256Base_Range52_Impl	78.156	3354.102	1.492593
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	38.536	6802.634	3.027207
Sum256Traits_Range52	38.540	6801.826	3.026847
Sum256Traits_Range52RoundToEven	51.696	5070.914	2.256583
Sum512Bcl	22.946	11424.624	5.084016
Sum512Base	22.940	11427.139	5.085135
Sum512Traits	22.941	11426.862	5.085012

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
SumScalar	116.587	2248.484
SumBcl	77.048	3402.351	1.513176
SumBase_Range52_Impl	77.132	3398.654	1.511531
SumBase_Range52RoundToEven	77.065	3401.586	1.512835
SumTraits	77.059	3401.867	1.512960
SumTraits_Range52	77.056	3402.008	1.513023
SumTraits_Range52RoundToEven	77.059	3401.877	1.512965
Sum128Bcl	77.069	3401.429	1.512766
Sum128Base_Basic	110.062	2381.774	1.059280
Sum128Base	77.072	3401.296	1.512706
Sum128Base_Range52_Impl	77.134	3398.545	1.511483
Sum128AdvSimd_Range52	77.056	3402.009	1.513023
Sum128AdvSimd_Range52_Impl	78.164	3353.785	1.491576
Sum128Traits	77.062	3401.720	1.512895
Sum128Traits_Range52	77.050	3402.265	1.513137
Sum128Traits_Range52RoundToEven	77.064	3401.629	1.512854
Sum256Bcl	38.532	6803.223	3.025693
Sum256Base_Basic	100.686	2603.576	1.157925
Sum256Base	38.559	6798.531	3.023606
Sum256Base_Range52_Impl	75.767	3459.866	1.538755
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	38.539	6801.977	3.025139
Sum256Traits_Range52	38.525	6804.504	3.026263
Sum256Traits_Range52RoundToEven	49.970	5246.035	2.333143
Sum512Bcl	22.810	11492.489	5.111216
Sum512Base	22.811	11492.022	5.111009
Sum512Traits	22.807	11494.183	5.111970

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
SumScalar	326.420	803.088
SumBcl	132.192	1983.059	2.469293
SumBase_Range52_Impl	184.661	1419.599	1.767677
SumTraits	123.342	2125.336	2.646455
SumTraits_Range52	123.357	2125.090	2.646149
Sum128Base_Basic	1053.698	248.785	0.309785
Sum128Base	1057.483	247.894	0.308677
Sum128Base_Range52_Impl	1062.378	246.752	0.307254
Sum128Traits	1053.945	248.726	0.309713
Sum128Traits_Range52	1056.897	248.032	0.308848
Sum256Base_Basic	1690.692	155.051	0.193069
Sum256Base	1845.236	142.065	0.176899
Sum256Base_Range52_Impl	1944.739	134.796	0.167848
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2119.462	123.684	0.154011
Sum256Traits_Range52	2120.046	123.650	0.153968

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
SumScalar	318.685	822.580
SumBcl	125.280	2092.470	2.543788
SumBase_Range52_Impl	179.867	1457.436	1.771786
SumTraits	132.923	1972.154	2.397522
SumTraits_Range52	132.976	1971.364	2.396561
Sum128Base_Basic	1171.690	223.732	0.271988
Sum128Base	1169.361	224.177	0.272529
Sum128Base_Range52_Impl	1171.697	223.730	0.271986
Sum128Traits	1169.204	224.207	0.272566
Sum128Traits_Range52	1175.216	223.060	0.271171
Sum256Base_Basic	1738.136	150.819	0.183349
Sum256Base	1874.845	139.822	0.169979
Sum256Base_Range52_Impl	2007.673	130.571	0.158734
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2207.435	118.755	0.144369
Sum256Traits_Range52	2174.394	120.560	0.146563

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
SumScalar	363.092	721.978
SumBcl	123.343	2125.322	2.943750
SumBase_Range52_Impl	659.875	397.263	0.550243
SumBase_Range52RoundToEven	161.241	1625.790	2.251856
SumTraits	125.823	2083.430	2.885726
SumTraits_Range52	126.590	2070.814	2.868252
SumTraits_Range52RoundToEven	163.139	1606.876	2.225659
Sum128Base_Basic	1029.056	254.742	0.352839
Sum128Base	1039.988	252.064	0.349130
Sum128Base_Range52_Impl	1051.646	249.270	0.345260
Sum128Traits	1032.964	253.779	0.351505
Sum128Traits_Range52	1039.168	252.263	0.349406
Sum128Traits_Range52RoundToEven	1044.197	251.048	0.347723
Sum256Base_Basic	1671.579	156.824	0.217215
Sum256Base	1816.695	144.297	0.199864
Sum256Base_Range52_Impl	1824.222	143.702	0.199039
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2102.988	124.653	0.172655
Sum256Traits_Range52	2076.883	126.220	0.174825
Sum256Traits_Range52RoundToEven	2094.913	125.134	0.173321

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	359.395	729.403
SumBcl	1303.948	201.039	0.275621
SumBase_Range52_Impl	717.540	365.337	0.500871
SumBase_Range52RoundToEven	186.047	1409.023	1.931748
SumTraits	1283.838	204.188	0.279938
SumTraits_Range52	703.709	372.517	0.510715
SumTraits_Range52RoundToEven	179.924	1456.974	1.997487
Sum128Base_Basic	1094.281	239.558	0.328430
Sum128Base	1079.795	242.772	0.332836
Sum128Base_Range52_Impl	1112.467	235.642	0.323061
Sum128Traits	1097.145	238.933	0.327573
Sum128Traits_Range52	1087.310	241.094	0.330536
Sum128Traits_Range52RoundToEven	1100.424	238.221	0.326597
Sum256Base_Basic	1697.679	154.413	0.211698
Sum256Base	1854.097	141.386	0.193838
Sum256Base_Range52_Impl	1819.586	144.068	0.197515
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2112.314	124.103	0.170143
Sum256Traits_Range52	2119.716	123.669	0.169549
Sum256Traits_Range52RoundToEven	2123.981	123.421	0.169208

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
SumScalar	318.468	823.140
SumBcl	133.034	1970.505	2.393887
SumBase_Range52_Impl	161.856	1619.608	1.967597
SumTraits	133.018	1970.736	2.394168
SumTraits_Range52	124.878	2099.204	2.550238
Sum128Base_Basic	406.253	645.273	0.783916
Sum128Base	406.569	644.772	0.783308
Sum128Base_Range52_Impl	404.825	647.550	0.786682
Sum128AdvSimd_Range52	324.251	808.461	0.982166
Sum128AdvSimd_Range52_Impl	374.687	699.634	0.849958
Sum128Traits	124.556	2104.629	2.556829
Sum128Traits_Range52	132.909	1972.364	2.396146
Sum256Base_Basic	1153.016	227.355	0.276204
Sum256Base	1298.445	201.891	0.245269
Sum256Base_Range52_Impl	1299.299	201.758	0.245108
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1298.410	201.896	0.245276
Sum256Traits_Range52	1298.093	201.946	0.245335

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
SumScalar	318.579	822.854
SumBcl	123.310	2125.892	2.583559
SumBase_Range52_Impl	158.721	1651.605	2.007166
SumTraits	123.390	2124.522	2.581893
SumTraits_Range52	132.010	1985.782	2.413286
Sum128Base_Basic	390.131	671.938	0.816595
Sum128Base	390.955	670.521	0.814873
Sum128Base_Range52_Impl	388.030	675.576	0.821016
Sum128AdvSimd_Range52	294.187	891.078	1.082912
Sum128AdvSimd_Range52_Impl	374.847	699.336	0.849890
Sum128Traits	124.523	2105.191	2.558401
Sum128Traits_Range52	132.754	1974.663	2.399772
Sum256Base_Basic	1141.230	229.703	0.279154
Sum256Base	1295.624	202.330	0.245888
Sum256Base_Range52_Impl	1295.965	202.277	0.245824
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1295.279	202.384	0.245954
Sum256Traits_Range52	1296.323	202.221	0.245756

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
SumScalar	359.789	728.604
SumBcl	124.738	2101.559	2.884363
SumBase_Range52_Impl	340.610	769.632	1.056310
SumBase_Range52RoundToEven	160.891	1629.327	2.236231
SumTraits	124.501	2105.549	2.889839
SumTraits_Range52	124.640	2103.203	2.886619
SumTraits_Range52RoundToEven	124.647	2103.089	2.886463
Sum128Base_Basic	402.467	651.343	0.893960
Sum128Base	404.943	647.361	0.888495
Sum128Base_Range52_Impl	402.047	652.023	0.894894
Sum128AdvSimd_Range52	379.547	690.677	0.947945
Sum128AdvSimd_Range52_Impl	381.441	687.247	0.943237
Sum128Traits	132.781	1974.253	2.709637
Sum128Traits_Range52	132.890	1972.642	2.707425
Sum128Traits_Range52RoundToEven	134.658	1946.735	2.671868
Sum256Base_Basic	1047.373	250.287	0.343516
Sum256Base	1199.266	218.587	0.300008
Sum256Base_Range52_Impl	1198.994	218.637	0.300076
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1200.330	218.393	0.299742
Sum256Traits_Range52	1199.824	218.485	0.299868
Sum256Traits_Range52RoundToEven	1200.217	218.414	0.299770

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
SumScalar	360.876	726.411
SumBcl	1004.718	260.913	0.359181
SumBase_Range52_Impl	329.509	795.560	1.095194
SumBase_Range52RoundToEven	159.073	1647.945	2.268614
SumTraits	132.059	1985.050	2.732684
SumTraits_Range52	132.075	1984.815	2.732360
SumTraits_Range52RoundToEven	132.027	1985.529	2.733343
Sum128Base_Basic	388.054	675.535	0.929962
Sum128Base	388.074	675.500	0.929915
Sum128Base_Range52_Impl	387.984	675.657	0.930131
Sum128AdvSimd_Range52	352.201	744.302	1.024630
Sum128AdvSimd_Range52_Impl	349.280	750.527	1.033200
Sum128Traits	123.272	2126.551	2.927478
Sum128Traits_Range52	123.289	2126.259	2.927077
Sum128Traits_Range52RoundToEven	123.442	2123.621	2.923445
Sum256Base_Basic	1031.734	254.081	0.349776
Sum256Base	1188.600	220.549	0.303614
Sum256Base_Range52_Impl	1187.601	220.734	0.303870
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1187.802	220.697	0.303818
Sum256Traits_Range52	1188.310	220.602	0.303688
Sum256Traits_Range52RoundToEven	1188.295	220.605	0.303692

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
SumScalar	318.315	823.536
SumBcl	133.473	1964.017	2.384858
SumBase_Range52_Impl	160.238	1635.968	1.986516
SumTraits	124.727	2101.750	2.552104
SumTraits_Range52	132.985	1971.227	2.393613
Sum128Base_Basic	410.053	639.294	0.776279
Sum128Base	413.174	634.464	0.770414
Sum128Base_Range52_Impl	412.970	634.777	0.770794
Sum128AdvSimd_Range52	322.348	813.233	0.987489
Sum128AdvSimd_Range52_Impl	323.344	810.728	0.984447
Sum128Traits	133.293	1966.672	2.388082
Sum128Traits_Range52	124.994	2097.259	2.546651
Sum256Base_Basic	1158.604	226.258	0.274740
Sum256Base	1300.680	201.544	0.244730
Sum256Base_Range52_Impl	1300.159	201.625	0.244828
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1302.314	201.291	0.244423
Sum256Traits_Range52	1300.358	201.594	0.244790

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
SumScalar	319.027	821.698
SumBcl	132.090	1984.585	2.415224
SumBase_Range52_Impl	158.625	1652.599	2.011200
SumTraits	123.464	2123.248	2.583977
SumTraits_Range52	132.021	1985.624	2.416489
Sum128Base_Basic	386.257	678.677	0.825944
Sum128Base	389.238	673.479	0.819619
Sum128Base_Range52_Impl	389.280	673.407	0.819531
Sum128AdvSimd_Range52	311.054	842.760	1.025632
Sum128AdvSimd_Range52_Impl	311.741	840.903	1.023372
Sum128Traits	123.347	2125.258	2.586422
Sum128Traits_Range52	132.128	1984.017	2.414533
Sum256Base_Basic	1141.594	229.630	0.279458
Sum256Base	1298.113	201.942	0.245762
Sum256Base_Range52_Impl	1297.489	202.039	0.245880
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1298.359	201.904	0.245716
Sum256Traits_Range52	1297.268	202.074	0.245922

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
SumScalar	361.086	725.987
SumBcl	133.052	1970.241	2.713878
SumBase_Range52_Impl	328.847	797.162	1.098038
SumBase_Range52RoundToEven	147.873	1772.770	2.441875
SumTraits	132.996	1971.068	2.715016
SumTraits_Range52	133.089	1969.692	2.713122
SumTraits_Range52RoundToEven	133.212	1967.876	2.710620
Sum128Base_Basic	411.506	637.036	0.877475
Sum128Base	411.594	636.899	0.877287
Sum128Base_Range52_Impl	411.407	637.189	0.877686
Sum128AdvSimd_Range52	375.205	698.669	0.962371
Sum128AdvSimd_Range52_Impl	377.458	694.498	0.956626
Sum128Traits	124.979	2097.498	2.889166
Sum128Traits_Range52	124.803	2100.457	2.893241
Sum128Traits_Range52RoundToEven	124.692	2102.340	2.895836
Sum256Base_Basic	1048.709	249.968	0.344315
Sum256Base	1200.960	218.279	0.300665
Sum256Base_Range52_Impl	1201.383	218.202	0.300559
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1201.271	218.222	0.300587
Sum256Traits_Range52	1201.707	218.143	0.300478
Sum256Traits_Range52RoundToEven	1200.811	218.306	0.300702

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
SumScalar	360.511	727.146
SumBcl	803.950	326.070	0.448424
SumBase_Range52_Impl	322.574	812.664	1.117607
SumBase_Range52RoundToEven	159.061	1648.076	2.266499
SumTraits	124.817	2100.218	2.888303
SumTraits_Range52	125.597	2087.182	2.870375
SumTraits_Range52RoundToEven	123.805	2117.388	2.911915
Sum128Base_Basic	399.133	656.784	0.903236
Sum128Base	390.897	670.621	0.922265
Sum128Base_Range52_Impl	392.428	668.004	0.918666
Sum128AdvSimd_Range52	348.432	752.353	1.034666
Sum128AdvSimd_Range52_Impl	348.708	751.758	1.033847
Sum128Traits	132.336	1980.894	2.724203
Sum128Traits_Range52	132.126	1984.041	2.728531
Sum128Traits_Range52RoundToEven	132.255	1982.111	2.725877
Sum256Base_Basic	1026.411	255.399	0.351234
Sum256Base	1189.325	220.414	0.303122
Sum256Base_Range52_Impl	1189.499	220.382	0.303078
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1189.497	220.382	0.303078
Sum256Traits_Range52	1192.669	219.796	0.302272
Sum256Traits_Range52RoundToEven	1190.209	220.250	0.302897

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
SumScalar	282.129	929.164
SumBcl	105.940	2474.455	2.663099
SumBase_Range52_Impl	132.629	1976.516	2.127199
SumTraits	105.851	2476.539	2.665342
SumTraits_Range52	105.867	2476.164	2.664938
Sum128Bcl	106.048	2471.941	2.660394
Sum128Base_Basic	403.985	648.895	0.698364
Sum128Base	105.812	2477.441	2.666313
Sum128Base_Range52_Impl	133.462	1964.186	2.113929
Sum128AdvSimd_Range52	105.781	2478.187	2.667115
Sum128AdvSimd_Range52_Impl	258.484	1014.160	1.091477
Sum128Traits	105.807	2477.574	2.666457
Sum128Traits_Range52	105.805	2477.604	2.666488
Sum256Bcl	1189.817	220.323	0.237120
Sum256Base_Basic	1014.172	258.481	0.278187
Sum256Base	1190.078	220.275	0.237068
Sum256Base_Range52_Impl	2714.225	96.582	0.103945
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1189.435	220.394	0.237196
Sum256Traits_Range52	1381.094	189.809	0.204279

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
SumScalar	282.097	929.269
SumBcl	107.218	2444.958	2.631054
SumBase_Range52_Impl	134.132	1954.375	2.103131
SumTraits	107.555	2437.301	2.622814
SumTraits_Range52	107.930	2428.823	2.613691
Sum128Bcl	107.361	2441.717	2.627566
Sum128Base_Basic	415.026	631.633	0.679709
Sum128Base	107.067	2448.406	2.634765
Sum128Base_Range52_Impl	135.689	1931.942	2.078991
Sum128AdvSimd_Range52	107.156	2446.379	2.632583
Sum128AdvSimd_Range52_Impl	269.138	974.014	1.048150
Sum128Traits	107.085	2447.988	2.634315
Sum128Traits_Range52	107.265	2443.880	2.629894
Sum256Bcl	1182.272	221.729	0.238606
Sum256Base_Basic	1027.101	255.227	0.274654
Sum256Base	1181.926	221.794	0.238676
Sum256Base_Range52_Impl	2435.790	107.622	0.115813
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1196.024	219.179	0.235862
Sum256Traits_Range52	1376.082	190.500	0.205000

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
SumScalar	230.221	1138.664
SumBcl	105.778	2478.246	2.176450
SumBase_Range52_Impl	305.208	858.902	0.754306
SumBase_Range52RoundToEven	132.641	1976.347	1.735671
SumTraits	105.784	2478.113	2.176333
SumTraits_Range52	105.749	2478.920	2.177041
SumTraits_Range52RoundToEven	106.161	2469.312	2.168604
Sum128Bcl	105.839	2476.826	2.175202
Sum128Base_Basic	398.148	658.409	0.578229
Sum128Base	105.842	2476.758	2.175143
Sum128Base_Range52_Impl	237.736	1102.667	0.968386
Sum128AdvSimd_Range52	105.644	2481.384	2.179206
Sum128AdvSimd_Range52_Impl	315.741	830.249	0.729143
Sum128Traits	105.740	2479.130	2.177226
Sum128Traits_Range52	105.827	2477.099	2.175442
Sum128Traits_Range52RoundToEven	105.940	2474.462	2.173127
Sum256Bcl	956.606	274.035	0.240664
Sum256Base_Basic	1011.848	259.074	0.227525
Sum256Base	1124.329	233.156	0.204763
Sum256Base_Range52_Impl	5355.357	48.950	0.042989
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1128.959	232.200	0.203923
Sum256Traits_Range52	1339.569	195.693	0.171862
Sum256Traits_Range52RoundToEven	2513.310	104.302	0.091601

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
SumScalar	229.931	1140.096
SumBcl	107.360	2441.726	2.141684
SumBase_Range52_Impl	311.873	840.547	0.737260
SumBase_Range52RoundToEven	134.535	1948.516	1.709080
SumTraits	107.269	2443.790	2.143495
SumTraits_Range52	107.296	2443.184	2.142963
SumTraits_Range52RoundToEven	107.126	2447.064	2.146366
Sum128Bcl	107.595	2436.402	2.137014
Sum128Base_Basic	408.820	641.221	0.562427
Sum128Base	107.260	2443.997	2.143676
Sum128Base_Range52_Impl	263.949	993.160	0.871120
Sum128AdvSimd_Range52	107.286	2443.414	2.143164
Sum128AdvSimd_Range52_Impl	350.383	748.164	0.656228
Sum128Traits	107.491	2438.747	2.139071
Sum128Traits_Range52	107.379	2441.300	2.141311
Sum128Traits_Range52RoundToEven	107.501	2438.515	2.138868
Sum256Bcl	967.180	271.040	0.237734
Sum256Base_Basic	1017.687	257.588	0.225935
Sum256Base	1143.044	229.338	0.201157
Sum256Base_Range52_Impl	5090.935	51.492	0.045165
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1139.683	230.015	0.201750
Sum256Traits_Range52	1142.179	229.512	0.201310
Sum256Traits_Range52RoundToEven	2238.126	117.127	0.102734

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.259163328783023E+21!=-3.259163328783052E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -3.259163328783023E+21!=-3.259163328783052E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.259163328783023E+21!=-3.259163328783052E+21
SumScalar	282.285	928.650
SumBcl	107.869	2430.213	2.616932
SumBase_Range52_Impl	136.753	1916.919	2.064200
SumTraits	107.878	2430.008	2.616710
SumTraits_Range52	107.761	2432.635	2.619540
Sum128Bcl	107.732	2433.292	2.620247
Sum128Base_Basic	405.191	646.964	0.696672
Sum128Base	107.897	2429.587	2.616257
Sum128Base_Range52_Impl	136.600	1919.070	2.066516
Sum128AdvSimd_Range52	107.744	2433.021	2.619955
Sum128AdvSimd_Range52_Impl	265.137	988.711	1.064675
Sum128Traits	107.711	2433.779	2.620771
Sum128Traits_Range52	107.717	2433.642	2.620624
Sum256Bcl	78.017	3360.087	3.618249
Sum256Base_Basic	407.554	643.212	0.692632
Sum256Base	78.125	3355.438	3.613243
Sum256Base_Range52_Impl	123.010	2131.072	2.294807
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	78.173	3353.365	3.611011
Sum256Traits_Range52	77.983	3361.564	3.619839
Sum512Bcl	77.148	3397.917	3.658986
Sum512Base	77.407	3386.558	3.646754
Sum512Traits	77.714	3373.171	3.632338

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
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 3.6258241385243226E+24!=3.625824138524267E+24
Check-Sum512Base	Check `Sum512Base` mismatch. 3.6258241385243226E+24!=3.625824138524267E+24
Check-Sum512Traits	Check `Sum512Traits` mismatch. 3.6258241385243226E+24!=3.625824138524267E+24
SumScalar	282.063	929.381
SumBcl	105.654	2481.167	2.669698
SumBase_Range52_Impl	133.353	1965.794	2.115164
SumTraits	106.028	2472.410	2.660275
SumTraits_Range52	105.889	2475.657	2.663768
Sum128Bcl	105.900	2475.390	2.663481
Sum128Base_Basic	402.721	650.931	0.700392
Sum128Base	106.062	2471.611	2.659416
Sum128Base_Range52_Impl	133.274	1966.954	2.116412
Sum128AdvSimd_Range52	106.100	2470.735	2.658473
Sum128AdvSimd_Range52_Impl	240.078	1091.910	1.174879
Sum128Traits	106.078	2471.237	2.659013
Sum128Traits_Range52	106.205	2468.289	2.655841
Sum256Bcl	66.544	3939.407	4.238741
Sum256Base_Basic	393.427	666.310	0.716939
Sum256Base	66.590	3936.665	4.235791
Sum256Base_Range52_Impl	114.732	2284.839	2.458452
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	66.369	3949.787	4.249910
Sum256Traits_Range52	66.396	3948.189	4.248191
Sum512Bcl	69.431	3775.580	4.062466
Sum512Base	69.322	3781.553	4.068892
Sum512Traits	69.073	3795.193	4.083569

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
SumScalar	229.878	1140.359
SumBcl	107.318	2442.694	2.142039
SumBase_Range52_Impl	263.022	996.661	0.873988
SumBase_Range52RoundToEven	136.752	1916.926	1.680984
SumTraits	107.669	2434.718	2.135045
SumTraits_Range52	107.672	2434.657	2.134991
SumTraits_Range52RoundToEven	107.670	2434.697	2.135026
Sum128Bcl	107.712	2433.753	2.134199
Sum128Base_Basic	410.313	638.889	0.560252
Sum128Base	107.826	2431.186	2.131948
Sum128Base_Range52_Impl	261.755	1001.485	0.878219
Sum128AdvSimd_Range52	107.796	2431.848	2.132528
Sum128AdvSimd_Range52_Impl	305.603	857.791	0.752211
Sum128Traits	107.651	2435.131	2.135407
Sum128Traits_Range52	107.787	2432.061	2.132715
Sum128Traits_Range52RoundToEven	107.617	2435.906	2.136086
Sum256Bcl	78.183	3352.972	2.940277
Sum256Base_Basic	406.174	645.398	0.565960
Sum256Base	78.270	3349.217	2.936984
Sum256Base_Range52_Impl	238.083	1101.062	0.965539
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	82.436	3179.954	2.788554
Sum256Traits_Range52	78.988	3318.784	2.910297
Sum256Traits_Range52RoundToEven	123.302	2126.039	1.864359
Sum512Bcl	77.602	3378.058	2.962275
Sum512Base	77.719	3372.974	2.957817
Sum512Traits	77.650	3375.953	2.960429

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
SumScalar	229.999	1139.760
SumBcl	105.845	2476.672	2.172976
SumBase_Range52_Impl	239.629	1093.957	0.959813
SumBase_Range52RoundToEven	133.175	1968.423	1.727050
SumTraits	105.986	2473.393	2.170099
SumTraits_Range52	106.486	2461.760	2.159892
SumTraits_Range52RoundToEven	106.184	2468.781	2.166052
Sum128Bcl	106.014	2472.723	2.169511
Sum128Base_Basic	395.673	662.527	0.581286
Sum128Base	105.934	2474.604	2.171162
Sum128Base_Range52_Impl	239.451	1094.770	0.960526
Sum128AdvSimd_Range52	106.074	2471.321	2.168281
Sum128AdvSimd_Range52_Impl	274.539	954.850	0.837764
Sum128Traits	106.060	2471.647	2.168567
Sum128Traits_Range52	106.102	2470.676	2.167715
Sum128Traits_Range52RoundToEven	105.988	2473.339	2.170052
Sum256Bcl	66.745	3927.520	3.445917
Sum256Base_Basic	402.532	651.238	0.571382
Sum256Base	67.015	3911.748	3.432079
Sum256Base_Range52_Impl	234.815	1116.385	0.979490
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	66.702	3930.058	3.448144
Sum256Traits_Range52	69.058	3796.007	3.330530
Sum256Traits_Range52RoundToEven	111.976	2341.065	2.053997
Sum512Bcl	68.830	3808.571	3.341554
Sum512Base	68.955	3801.655	3.335486
Sum512Traits	70.311	3728.360	3.271178

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


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.259163328783021E+21!=-3.259163328783052E+21
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -3.259163328783023E+21!=-3.259163328783052E+21
Check-Sum512Base	Check `Sum512Base` mismatch. -3.259163328783023E+21!=-3.259163328783052E+21
Check-Sum512Traits	Check `Sum512Traits` mismatch. -3.259163328783023E+21!=-3.259163328783052E+21
SumScalar	6403.646	40.937
SumBcl	14381.250	18.228	0.445277
SumBase_Range52_Impl	20925.000	12.528	0.306028
SumTraits	7446.875	35.202	0.859910
SumTraits_Range52	2940.365	89.154	2.177841
Sum128Bcl	9034.896	29.015	0.708768
Sum128Base_Basic	3684.375	71.150	1.738055
Sum128Base	8535.417	30.713	0.750244
Sum128Base_Range52_Impl	20410.417	12.844	0.313744
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	8528.125	30.739	0.750886
Sum128Traits_Range52	2559.896	102.404	2.501526
Sum256Bcl	31408.333	8.346	0.203884
Sum256Base_Basic	21295.833	12.310	0.300699
Sum256Base	31912.500	8.214	0.200663
Sum256Base_Range52_Impl	64395.833	4.071	0.099442
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	41725.000	6.283	0.153473
Sum256Traits_Range52	42454.167	6.175	0.150837
Sum512Bcl	33091.667	7.922	0.193512
Sum512Base	32875.000	7.974	0.194788
Sum512Traits	37183.333	7.050	0.172218

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524267E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 3.6258241385243226E+24!=3.625824138524267E+24
Check-Sum512Base	Check `Sum512Base` mismatch. 3.6258241385243226E+24!=3.625824138524267E+24
Check-Sum512Traits	Check `Sum512Traits` mismatch. 3.6258241385243226E+24!=3.625824138524267E+24
SumScalar	7685.938	34.107
SumBcl	15793.750	16.598	0.486644
SumBase_Range52_Impl	16239.583	16.142	0.473284
SumTraits	9830.208	26.667	0.781869
SumTraits_Range52	2880.729	90.999	2.668053
Sum128Bcl	10773.958	24.331	0.713381
Sum128Base_Basic	5943.229	44.108	1.293226
Sum128Base	10912.500	24.022	0.704324
Sum128Base_Range52_Impl	11828.125	22.163	0.649802
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	10404.167	25.196	0.738736
Sum128Traits_Range52	2557.292	102.508	3.005499
Sum256Bcl	33614.583	7.799	0.228649
Sum256Base_Basic	23518.750	11.146	0.326800
Sum256Base	33891.667	7.735	0.226780
Sum256Base_Range52_Impl	40529.167	6.468	0.189640
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	44425.000	5.901	0.173009
Sum256Traits_Range52	46491.667	5.639	0.165319
Sum512Bcl	33712.500	7.776	0.227985
Sum512Base	34512.500	7.596	0.222700
Sum512Traits	40270.833	6.510	0.190856

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
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	6775.521	38.690
SumBcl	9565.625	27.405	0.708320
SumBase_Range52_Impl	23170.833	11.314	0.292416
SumBase_Range52RoundToEven	18956.250	13.829	0.357429
SumTraits	8382.292	31.274	0.808314
SumTraits_Range52	2991.927	87.617	2.264601
SumTraits_Range52RoundToEven	6136.979	42.715	1.104048
Sum128Bcl	9331.250	28.093	0.726111
Sum128Base_Basic	3951.042	66.348	1.714869
Sum128Base	8652.083	30.298	0.783109
Sum128Base_Range52_Impl	29633.333	8.846	0.228645
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	8939.583	29.324	0.757924
Sum128Traits_Range52	2813.802	93.164	2.407959
Sum128Traits_Range52RoundToEven	2519.792	104.034	2.688921
Sum256Bcl	26512.500	9.888	0.255559
Sum256Base_Basic	18689.583	14.026	0.362529
Sum256Base	27645.833	9.482	0.245083
Sum256Base_Range52_Impl	86891.667	3.017	0.077977
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShiftVarFix	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	38929.167	6.734	0.174047
Sum256Traits_Range52	38504.167	6.808	0.175969
Sum256Traits_Range52RoundToEven	67058.333	3.909	0.101039
Sum512Bcl	33429.167	7.842	0.202683
Sum512Base	34733.333	7.547	0.195073
Sum512Traits	37729.167	6.948	0.179583

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 3573632353932676593!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 3573632353956802055!=5047608992447735894
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 3573632353956802055!=5047608992447735894
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	8161.458	32.120
SumBcl	27622.917	9.490	0.295460
SumBase_Range52_Impl	20770.833	12.621	0.392929
SumBase_Range52RoundToEven	14697.917	17.835	0.555280
SumTraits	39695.833	6.604	0.205600
SumTraits_Range52	2656.771	98.670	3.071947
SumTraits_Range52RoundToEven	5481.250	47.826	1.488978
Sum128Bcl	35570.833	7.370	0.229442
Sum128Base_Basic	12965.625	20.218	0.629469
Sum128Base	38720.833	6.770	0.210777
Sum128Base_Range52_Impl	21327.083	12.292	0.382680
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	36662.500	7.150	0.222611
Sum128Traits_Range52	2504.948	104.650	3.258135
Sum128Traits_Range52RoundToEven	2321.094	112.940	3.516212
Sum256Bcl	61387.500	4.270	0.132950
Sum256Base_Basic	28900.000	9.071	0.282403
Sum256Base	61100.000	4.290	0.133575
Sum256Base_Range52_Impl	72350.000	3.623	0.112805
Sum256Avx2_ShiftVar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	69041.667	3.797	0.118211
Sum256Traits_Range52	68083.333	3.850	0.119875
Sum256Traits_Range52RoundToEven	45070.833	5.816	0.181081
Sum512Bcl	66908.333	3.918	0.121980
Sum512Base	70125.000	3.738	0.116384
Sum512Traits	73791.667	3.552	0.110601

```

