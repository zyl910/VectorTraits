# Benchmark - ConvertToDouble
([← Back](README.md))

- `ConvertToDouble[/_Range52]`: Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量).
  Mnemonic: `rt[i] := (Double)(value[i])` .
- `ConvertToInt64[/_Range52/Range52RoundToEven]`: Convert to a vector whose elements are of type Int64 (转换为元素类型是Int64的向量).
  Mnemonic: `rt[i] := (Int64)(value[i])` .
- `ConvertToUInt64[/_Range52/Range52RoundToEven]`: Convert to a vector whose elements are of type UInt64 (转换为元素类型是UInt64的向量).
  Mnemonic: `rt[i] := (UInt64)(value[i])` .

## x86

### Intel Core i5-8250U
`Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 
``` 
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9166.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
SumScalar	315.120	831.886
SumBcl	201.266	1302.478	1.565694
SumBase_Range52_Impl	80.976	3237.323	3.891547
SumTraits	200.253	1309.065	1.573611
SumTraits_Range52	201.362	1301.855	1.564944

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	709.389	369.535
SumBcl	108.224	2422.243	6.554845
SumBase_Range52_Impl	80.858	3242.035	8.773290
SumTraits	109.567	2392.550	6.474494
SumTraits_Range52	140.170	1870.181	5.060906

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	165.243	1586.414
SumBcl	202.586	1293.986	0.815667
SumBase_Range52_Impl	248.188	1056.230	0.665797
SumBase_Range52RoundToEven	76.053	3446.839	2.172723
SumTraits	202.823	1292.474	0.814714
SumTraits_Range52	202.843	1292.350	0.814636
SumTraits_Range52RoundToEven	73.411	3570.933	2.250946

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	1045.461	250.745
SumBcl	1493.739	175.495	0.699895
SumBase_Range52_Impl	251.680	1041.578	4.153935
SumBase_Range52RoundToEven	56.245	4660.753	18.587624
SumTraits	1482.849	176.784	0.705035
SumTraits_Range52	241.020	1087.645	4.337654
SumTraits_Range52RoundToEven	55.753	4701.877	18.751633

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

``` 

#### .NET Core 2.1 
``` 
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
SumScalar	314.344	833.941
SumBcl	201.078	1303.691	1.563289
SumBase_Range52_Impl	81.860	3202.328	3.839995
SumTraits	200.499	1307.461	1.567810
SumTraits_Range52	201.010	1304.136	1.563824

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	715.285	366.489
SumBcl	106.026	2472.445	6.746304
SumBase_Range52_Impl	80.879	3241.204	8.843939
SumTraits	140.583	1864.693	5.087996
SumTraits_Range52	106.714	2456.500	6.702798

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	168.926	1551.828
SumBcl	202.957	1291.623	0.832323
SumBase_Range52_Impl	250.037	1048.421	0.675604
SumBase_Range52RoundToEven	74.792	3504.967	2.258605
SumTraits	204.268	1283.336	0.826983
SumTraits_Range52	202.682	1293.376	0.833453
SumTraits_Range52RoundToEven	75.020	3494.320	2.251744

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	910.410	287.941
SumBcl	1421.507	184.413	0.640454
SumBase_Range52_Impl	253.151	1035.522	3.596304
SumBase_Range52RoundToEven	60.586	4326.789	15.026665
SumTraits	1421.207	184.452	0.640589
SumTraits_Range52	252.637	1037.632	3.603630
SumTraits_Range52RoundToEven	56.905	4606.705	15.998796

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

``` 

#### .NET Core 3.1 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
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
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	313.524	836.122
SumBcl	200.872	1305.031	1.560813
SumBase_Range52_Impl	81.682	3209.316	3.838333
SumTraits	115.775	2264.250	2.708037
SumTraits_Range52	94.299	2779.920	3.324776
Sum128Base_Basic	1752.697	149.566	0.178881
Sum128Base	1716.930	152.682	0.182607
Sum128Base_Range52_Impl	1702.149	154.008	0.184193
Sum128Traits	1703.652	153.872	0.184030
Sum128Traits_Range52	1702.584	153.968	0.184146
Sum256Base_Basic	519.443	504.664	0.603576
Sum256Base	520.203	503.926	0.602694
Sum256Base_Range52_Impl	512.592	511.409	0.611644
Sum256Avx2_Bcl	100.278	2614.166	3.126536
Sum256Avx2_HwScalar	200.935	1304.619	1.560320
Sum256Avx2_Range52	81.665	3209.996	3.839146
Sum256Traits	100.958	2596.573	3.105494
Sum256Traits_Range52	87.244	3004.711	3.593626

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
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	736.882	355.748
SumBcl	117.047	2239.640	6.295587
SumBase_Range52_Impl	81.095	3232.542	9.086615
SumTraits	101.512	2582.384	7.259034
SumTraits_Range52	81.698	3208.689	9.019566
Sum128Base_Basic	1720.794	152.339	0.428222
Sum128Base	1719.865	152.421	0.428453
Sum128Base_Range52_Impl	1728.087	151.696	0.426415
Sum128Traits	1721.462	152.280	0.428056
Sum128Traits_Range52	1724.834	151.982	0.427219
Sum256Base_Basic	896.939	292.265	0.821552
Sum256Base	891.218	294.141	0.826825
Sum256Base_Range52_Impl	887.142	295.493	0.830625
Sum256Avx2_Bcl	101.671	2578.364	7.247733
Sum256Avx2_Range52	82.355	3183.112	8.947670
Sum256Traits	106.892	2452.420	6.893707
Sum256Traits_Range52	84.227	3112.363	8.748796

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	173.581	1510.208
SumBcl	207.309	1264.510	0.837309
SumBase_Range52_Impl	258.069	1015.790	0.672616
SumBase_Range52RoundToEven	77.559	3379.923	2.238051
SumTraits	197.515	1327.208	0.878825
SumTraits_Range52	88.208	2971.895	1.967871
SumTraits_Range52RoundToEven	79.408	3301.220	2.185937
Sum128Base_Basic	1560.061	168.034	0.111266
Sum128Base	1556.932	168.372	0.111489
Sum128Base_Range52_Impl	1566.755	167.316	0.110790
Sum128Traits	1568.257	167.156	0.110684
Sum128Traits_Range52	1567.777	167.207	0.110718
Sum128Traits_Range52RoundToEven	1572.138	166.744	0.110411
Sum256Base_Basic	476.419	550.238	0.364346
Sum256Base	478.006	548.412	0.363137
Sum256Base_Range52_Impl	478.481	547.867	0.362776
Sum256Avx2_HwScalar	200.038	1310.468	0.867740
Sum256Avx2_ShiftVar	158.505	1653.852	1.095115
Sum256Avx2_ShiftVarFix	185.649	1412.037	0.934995
Sum256Avx2_Range52	85.876	3052.578	2.021297
Sum256Traits	197.201	1329.321	0.880224
Sum256Traits_Range52	86.059	3046.099	2.017006
Sum256Traits_Range52RoundToEven	77.907	3364.845	2.228067

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	993.793	263.781
SumBcl	1457.533	179.855	0.681832
SumBase_Range52_Impl	237.714	1102.770	4.180620
SumBase_Range52RoundToEven	73.900	3547.286	13.447829
SumTraits	134.976	1942.159	7.362761
SumTraits_Range52	80.793	3244.631	12.300457
SumTraits_Range52RoundToEven	75.311	3480.836	13.195916
Sum128Base_Basic	1870.219	140.168	0.531378
Sum128Base	1886.657	138.946	0.526748
Sum128Base_Range52_Impl	1934.418	135.516	0.513743
Sum128Traits	1884.636	139.095	0.527313
Sum128Traits_Range52	1884.628	139.096	0.527315
Sum128Traits_Range52RoundToEven	1872.857	139.970	0.530629
Sum256Base_Basic	1010.013	259.545	0.983940
Sum256Base	1011.082	259.271	0.982901
Sum256Base_Range52_Impl	1013.414	258.674	0.980639
Sum256Avx2_ShiftVar	142.920	1834.199	6.953482
Sum256Avx2_Range52	91.292	2871.485	10.885855
Sum256Traits	143.105	1831.831	6.944507
Sum256Traits_Range52	86.098	3044.713	11.542565
Sum256Traits_Range52RoundToEven	75.549	3469.845	13.154248

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 5.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
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
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	313.212	836.955
SumBcl	200.986	1304.293	1.558378
SumBase_Range52_Impl	80.864	3241.778	3.873300
SumTraits	91.986	2849.828	3.404995
SumTraits_Range52	82.353	3183.164	3.803268
Sum128Base_Basic	1637.233	160.114	0.191305
Sum128Base	1640.702	159.776	0.190901
Sum128Base_Range52_Impl	1638.083	160.031	0.191206
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1638.642	159.976	0.191141
Sum128Traits_Range52	1636.773	160.159	0.191359
Sum256Base_Basic	508.916	515.103	0.615449
Sum256Base	511.079	512.923	0.612844
Sum256Base_Range52_Impl	511.120	512.882	0.612795
Sum256Avx2_Bcl	93.106	2815.550	3.364040
Sum256Avx2_HwScalar	199.640	1313.085	1.568883
Sum256Avx2_Range52	80.325	3263.536	3.899297
Sum256Traits	91.623	2861.126	3.418494
Sum256Traits_Range52	80.410	3260.094	3.895184

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
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	735.460	356.435
SumBcl	115.160	2276.340	6.386407
SumBase_Range52_Impl	82.243	3187.413	8.942476
SumTraits	88.543	2960.635	8.306237
SumTraits_Range52	79.943	3279.142	9.199826
Sum128Base_Basic	1713.467	152.990	0.429224
Sum128Base	1712.250	153.099	0.429529
Sum128Base_Range52_Impl	1711.852	153.135	0.429628
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1710.619	153.245	0.429938
Sum128Traits_Range52	1717.311	152.648	0.428263
Sum256Base_Basic	826.962	316.996	0.889352
Sum256Base	826.118	317.320	0.890261
Sum256Base_Range52_Impl	823.112	318.479	0.893512
Sum256Avx2_Bcl	81.093	3232.631	9.069337
Sum256Avx2_Range52	79.803	3284.880	9.215926
Sum256Traits	81.381	3221.190	9.037238
Sum256Traits_Range52	80.024	3275.804	9.190463

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	163.551	1602.827
SumBcl	202.503	1294.516	0.807645
SumBase_Range52_Impl	109.180	2401.020	1.497990
SumBase_Range52RoundToEven	75.601	3467.464	2.163342
SumTraits	175.338	1495.078	0.932776
SumTraits_Range52	81.484	3217.118	2.007152
SumTraits_Range52RoundToEven	76.456	3428.697	2.139156
Sum128Base_Basic	1534.361	170.849	0.106592
Sum128Base	1538.038	170.440	0.106337
Sum128Base_Range52_Impl	1535.108	170.766	0.106540
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1532.808	171.022	0.106700
Sum128Traits_Range52	1529.098	171.437	0.106959
Sum128Traits_Range52RoundToEven	1533.282	170.969	0.106667
Sum256Base_Basic	456.005	574.870	0.358660
Sum256Base	457.094	573.501	0.357806
Sum256Base_Range52_Impl	457.872	572.527	0.357198
Sum256Avx2_HwScalar	200.899	1304.856	0.814097
Sum256Avx2_ShiftVar	149.342	1755.321	1.095140
Sum256Avx2_ShiftVarFix	170.561	1536.952	0.958900
Sum256Avx2_Range52	76.896	3409.089	2.126922
Sum256Traits	169.508	1546.500	0.964857
Sum256Traits_Range52	76.682	3418.607	2.132861
Sum256Traits_Range52RoundToEven	73.115	3585.345	2.236888

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	885.389	296.078
SumBcl	1266.290	207.017	0.699199
SumBase_Range52_Impl	95.240	2752.449	9.296370
SumBase_Range52RoundToEven	57.535	4556.255	15.388711
SumTraits	113.762	2304.314	7.782800
SumTraits_Range52	73.627	3560.432	12.025327
SumTraits_Range52RoundToEven	56.927	4604.875	15.552923
Sum128Base_Basic	1671.887	156.795	0.529575
Sum128Base	1677.356	156.284	0.527848
Sum128Base_Range52_Impl	1681.204	155.926	0.526640
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1704.777	153.770	0.519358
Sum128Traits_Range52	1686.259	155.459	0.525061
Sum128Traits_Range52RoundToEven	1686.619	155.426	0.524949
Sum256Base_Basic	1013.839	258.566	0.873304
Sum256Base	1013.791	258.578	0.873345
Sum256Base_Range52_Impl	1022.983	256.254	0.865497
Sum256Avx2_ShiftVar	115.202	2275.512	7.685520
Sum256Avx2_Range52	74.613	3513.362	11.866349
Sum256Traits	108.181	2423.195	8.184321
Sum256Traits_Range52	76.150	3442.459	11.626874
Sum256Traits_Range52RoundToEven	58.417	4487.463	15.156365

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.14
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.14\
RuntimeInformation.FrameworkDescription:	.NET 6.0.14
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
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
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	313.552	836.047
SumBcl	200.905	1304.814	1.560695
SumBase_Range52_Impl	81.483	3217.180	3.848086
SumTraits	89.000	2945.446	3.523063
SumTraits_Range52	83.255	3148.677	3.766149
Sum128Base_Basic	1639.052	159.936	0.191301
Sum128Base	1637.939	160.045	0.191431
Sum128Base_Range52_Impl	1640.874	159.759	0.191088
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1653.788	158.511	0.189596
Sum128Traits_Range52	1653.575	158.532	0.189620
Sum256Base_Basic	518.284	505.792	0.604980
Sum256Base	515.607	508.418	0.608122
Sum256Base_Range52_Impl	515.852	508.177	0.607833
Sum256Avx2_Bcl	86.759	3021.515	3.614049
Sum256Avx2_HwScalar	204.901	1279.369	1.530260
Sum256Avx2_Range52	82.785	3166.552	3.787529
Sum256Traits	83.811	3127.791	3.741167
Sum256Traits_Range52	80.714	3247.823	3.884738

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
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	713.148	367.587
SumBcl	110.115	2380.630	6.476372
SumBase_Range52_Impl	84.532	3101.124	8.436438
SumTraits	87.605	2992.348	8.140517
SumTraits_Range52	83.990	3121.121	8.490838
Sum128Base_Basic	1719.302	152.471	0.414790
Sum128Base	1717.658	152.617	0.415186
Sum128Base_Range52_Impl	1715.284	152.828	0.415761
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1713.275	153.008	0.416249
Sum128Traits_Range52	1713.217	153.013	0.416263
Sum256Base_Basic	843.740	310.693	0.845223
Sum256Base	842.251	311.242	0.846717
Sum256Base_Range52_Impl	843.397	310.819	0.845567
Sum256Avx2_Bcl	82.139	3191.472	8.682223
Sum256Avx2_Range52	81.157	3230.094	8.787293
Sum256Traits	84.202	3113.276	8.469495
Sum256Traits_Range52	87.334	3001.627	8.165761

[ConvertToInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447746009
# SumBcl	5047608992447746009
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. -3689937982793898067!=5047608992447746009
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3689937982793898067!=5047608992447746009
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. -3689937982793898793!=5047608992447746009
SumScalar	166.331	1576.040
SumBcl	205.520	1275.517	0.809318
SumBase_Range52_Impl	112.891	2322.105	1.473380
SumBase_Range52RoundToEven	63.329	4139.401	2.626458
SumTraits	173.633	1509.755	0.957942
SumTraits_Range52	81.444	3218.704	2.042273
SumTraits_Range52RoundToEven	61.698	4248.799	2.695870
Sum128Base_Basic	1538.180	170.425	0.108135
Sum128Base	1532.628	171.042	0.108527
Sum128Base_Range52_Impl	1532.516	171.055	0.108535
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1535.616	170.709	0.108315
Sum128Traits_Range52	1538.003	170.444	0.108147
Sum128Traits_Range52RoundToEven	1531.604	171.156	0.108599
Sum256Base_Basic	462.223	567.137	0.359850
Sum256Base	460.353	569.441	0.361311
Sum256Base_Range52_Impl	457.894	572.499	0.363252
Sum256Avx2_HwScalar	200.285	1308.855	0.830471
Sum256Avx2_ShiftVar	148.281	1767.888	1.121728
Sum256Avx2_ShiftVarFix	166.413	1575.260	0.999505
Sum256Avx2_Range52	74.758	3506.579	2.224930
Sum256Traits	166.809	1571.525	0.997135
Sum256Traits_Range52	74.871	3501.264	2.221558
Sum256Traits_Range52RoundToEven	55.807	4697.308	2.980451

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	873.777	300.013
SumBcl	1187.910	220.677	0.735558
SumBase_Range52_Impl	104.699	2503.786	8.345603
SumBase_Range52RoundToEven	61.644	4252.560	14.174605
SumTraits	110.458	2373.251	7.910504
SumTraits_Range52	73.902	3547.182	11.823443
SumTraits_Range52RoundToEven	57.280	4576.532	15.254467
Sum128Base_Basic	1684.385	155.632	0.518751
Sum128Base	1671.765	156.807	0.522667
Sum128Base_Range52_Impl	1677.505	156.270	0.520879
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1672.070	156.778	0.522572
Sum128Traits_Range52	1679.211	156.111	0.520350
Sum128Traits_Range52RoundToEven	1669.703	157.000	0.523313
Sum256Base_Basic	998.302	262.590	0.875263
Sum256Base	997.182	262.885	0.876246
Sum256Base_Range52_Impl	1025.202	255.700	0.852297
Sum256Avx2_ShiftVar	112.846	2323.025	7.743093
Sum256Avx2_Range52	72.541	3613.720	12.045228
Sum256Traits	111.082	2359.924	7.866085
Sum256Traits_Range52	74.837	3502.857	11.675699
Sum256Traits_Range52RoundToEven	56.470	4642.144	15.473165

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.3
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.3\
RuntimeInformation.FrameworkDescription:	.NET 7.0.3
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
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
SumScalar	315.910	829.805
SumBcl	88.748	2953.794	3.559623
SumBase_Range52_Impl	86.300	3037.585	3.660600
SumTraits	93.177	2813.396	3.390429
SumTraits_Range52	88.434	2964.291	3.572272
Sum128Bcl	163.597	1602.375	1.931026
Sum128Base_Basic	864.111	303.369	0.365590
Sum128Base	161.758	1620.595	1.952982
Sum128Base_Range52_Impl	160.022	1638.177	1.974170
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	160.790	1630.355	1.964743
Sum128Traits_Range52	160.034	1638.054	1.974022
Sum256Bcl	86.130	3043.573	3.667816
Sum256Base_Basic	532.786	492.025	0.592941
Sum256Base	90.116	2908.948	3.505579
Sum256Base_Range52_Impl	86.111	3044.242	3.668622
Sum256Avx2_Bcl	92.076	2847.042	3.430976
Sum256Avx2_HwScalar	206.485	1269.553	1.529941
Sum256Avx2_Range52	87.092	3009.950	3.627297
Sum256Traits	93.604	2800.576	3.374980
Sum256Traits_Range52	86.539	3029.196	3.650490

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
SumScalar	699.481	374.769
SumBcl	88.800	2952.064	7.877021
SumBase_Range52_Impl	83.595	3135.873	8.367480
SumTraits	92.930	2820.885	7.526993
SumTraits_Range52	86.300	3037.598	8.105253
Sum128Bcl	163.216	1606.114	4.285609
Sum128Base_Basic	925.598	283.216	0.755707
Sum128Base	160.788	1630.371	4.350334
Sum128Base_Range52_Impl	159.642	1642.074	4.381561
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	160.822	1630.023	4.349407
Sum128Traits_Range52	159.874	1639.694	4.375212
Sum256Bcl	89.365	2933.399	7.827216
Sum256Base_Basic	887.082	295.513	0.788519
Sum256Base	86.220	3040.418	8.112775
Sum256Base_Range52_Impl	86.283	3038.195	8.106845
Sum256Avx2_Bcl	93.241	2811.461	7.501848
Sum256Avx2_Range52	87.029	3012.139	8.037320
Sum256Traits	92.314	2839.712	7.577229
Sum256Traits_Range52	85.821	3054.544	8.150468

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
SumScalar	232.655	1126.752
SumBcl	568.453	461.153	0.409277
SumBase_Range52_Impl	161.418	1624.010	1.441320
SumBase_Range52RoundToEven	63.530	4126.274	3.662098
SumTraits	168.835	1552.668	1.378004
SumTraits_Range52	84.176	3114.229	2.763900
SumTraits_Range52RoundToEven	64.681	4052.877	3.596957
Sum128Bcl	771.151	339.939	0.301698
Sum128Base_Basic	806.836	324.904	0.288354
Sum128Base	771.069	339.975	0.301730
Sum128Base_Range52_Impl	153.626	1706.383	1.514427
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	773.800	338.775	0.300665
Sum128Traits_Range52	149.773	1750.278	1.553384
Sum128Traits_Range52RoundToEven	96.900	2705.296	2.400969
Sum256Bcl	442.047	593.023	0.526312
Sum256Base_Basic	461.141	568.468	0.504519
Sum256Base	443.504	591.075	0.524583
Sum256Base_Range52_Impl	101.016	2595.066	2.303140
Sum256Avx2_HwScalar	201.305	1302.221	1.155730
Sum256Avx2_ShiftVar	152.479	1719.213	1.525814
Sum256Avx2_ShiftVarFix	163.333	1604.967	1.424419
Sum256Avx2_Range52	76.255	3437.714	3.050995
Sum256Traits	164.306	1595.466	1.415987
Sum256Traits_Range52	79.742	3287.410	2.917600
Sum256Traits_Range52RoundToEven	63.984	4097.034	3.636147

[ConvertToUInt64Benchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5047608992447735894
# SumBcl	5047608992447735894
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-SumBase_Range52RoundToEven	Check `SumBase_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-SumTraits_Range52RoundToEven	Check `SumTraits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3573632353932676593!=5047608992447735894
Check-Sum128Traits_Range52RoundToEven	Check `Sum128Traits_Range52RoundToEven` mismatch. 3573632353956802055!=5047608992447735894
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 6696906415454780480!=5047608992447735894
Check-Sum256Traits_Range52RoundToEven	Check `Sum256Traits_Range52RoundToEven` mismatch. 6696906415454844503!=5047608992447735894
SumScalar	905.834	289.395
SumBcl	1055.345	248.396	0.858329
SumBase_Range52_Impl	125.929	2081.676	7.193194
SumBase_Range52RoundToEven	63.246	4144.802	14.322288
SumTraits	125.260	2092.797	7.231620
SumTraits_Range52	82.037	3195.417	11.041706
SumTraits_Range52RoundToEven	62.541	4191.532	14.483762
Sum128Bcl	1130.996	231.782	0.800917
Sum128Base_Basic	1122.592	233.517	0.806913
Sum128Base	1128.870	232.218	0.802426
Sum128Base_Range52_Impl	154.234	1699.651	5.873114
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1118.869	234.294	0.809598
Sum128Traits_Range52	161.898	1619.195	5.595100
Sum128Traits_Range52RoundToEven	103.824	2524.886	8.724698
Sum256Bcl	1047.295	250.306	0.864927
Sum256Base_Basic	1164.502	225.112	0.777872
Sum256Base	1059.075	247.522	0.855306
Sum256Base_Range52_Impl	108.896	2407.289	8.318342
Sum256Avx2_ShiftVar	124.656	2102.944	7.266686
Sum256Avx2_Range52	81.163	3229.839	11.160650
Sum256Traits	123.501	2122.600	7.334605
Sum256Traits_Range52	81.613	3212.045	11.099162
Sum256Traits_Range52RoundToEven	67.615	3877.011	13.396942

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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

