# Benchmark - ShiftRightArithmetic
([← Back](README.md))

See [Group](ShiftRightArithmetic_Group.md)

## x86

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9181.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	312.303	839.391
SumSRA_Base_Basic	255.602	1025.593	1.221830
SumSRA_Base	160.890	1629.340	1.941099
SumSRA_Base_Core	149.174	1757.308	2.093552
SumSRATraits	161.546	1622.718	1.933210
SumSRATraits_Core	151.634	1728.790	2.059577
SumSRAConstTraits	144.441	1814.882	2.162142
SumSRAConstTraits_Core	141.192	1856.651	2.211903
SumSRAFastTraits	153.266	1710.384	2.037649

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	314.003	834.844
SumSRA_Base_Basic	487.329	537.921	0.644336
SumSRA_Base	329.199	796.309	0.953842
SumSRA_Base_Core	298.437	878.389	1.052159
SumSRATraits	329.278	796.117	0.953612
SumSRATraits_Core	302.454	866.725	1.038187
SumSRAConstTraits	288.452	908.797	1.088583
SumSRAConstTraits_Core	282.703	927.276	1.110717
SumSRAFastTraits	314.667	833.085	0.997892

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	318.311	823.547
SumSRA_Base_Basic	560.836	467.417	0.567566
SumSRA_Base	559.067	468.895	0.569361
SumSRA_Base_Create	601.981	435.469	0.528773
SumSRA_Base_LoadArray	638.518	410.551	0.498515
SumSRA_Base_Core	559.399	468.617	0.569023
SumSRATraits	559.733	468.338	0.568684
SumSRATraits_Core	547.800	478.540	0.581072
SumSRAConstTraits	483.425	542.264	0.658450
SumSRAConstTraits_Core	483.703	541.953	0.658072
SumSRAFastTraits	524.038	500.239	0.607420

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	312.642	838.480
SumSRA_Base_Basic	206.453	1269.754	1.514353
SumSRA_Base	80.766	3245.706	3.870941
SumSRA_Base_Core	74.580	3514.957	4.192060
SumSRATraits	80.697	3248.507	3.874282
SumSRATraits_Core	75.940	3451.975	4.116944
SumSRAConstTraits	72.449	3618.342	4.315360
SumSRAConstTraits_Core	70.759	3704.749	4.418412
SumSRAFastTraits	77.459	3384.301	4.036234

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Vector128 type is not supported! Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Vector128 type is not supported! Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	312.301	839.395
SumSRA_Base_Basic	250.686	1045.705	1.245783
SumSRA_Base	166.320	1576.145	1.877714
SumSRA_Base_Core	153.421	1708.654	2.035577
SumSRATraits	166.738	1572.191	1.873004
SumSRATraits_Core	156.553	1674.478	1.994862
SumSRAConstTraits	154.967	1691.615	2.015277
SumSRAConstTraits_Core	150.921	1736.966	2.069306
SumSRAFastTraits	158.479	1654.127	1.970617

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	313.818	835.338
SumSRA_Base_Basic	487.652	537.563	0.643528
SumSRA_Base	341.511	767.601	0.918911
SumSRA_Base_Core	307.123	853.547	1.021798
SumSRATraits	341.144	768.425	0.919897
SumSRATraits_Core	313.883	835.164	0.999792
SumSRAConstTraits	310.527	844.191	1.010597
SumSRAConstTraits_Core	301.854	868.446	1.039634
SumSRAFastTraits	315.600	830.620	0.994352

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	316.420	828.468
SumSRA_Base_Basic	585.498	447.729	0.540430
SumSRA_Base	588.643	445.336	0.537541
SumSRA_Base_Create	626.097	418.696	0.505385
SumSRA_Base_LoadArray	622.975	420.794	0.507918
SumSRA_Base_Core	577.202	454.163	0.548196
SumSRATraits	584.701	448.339	0.541166
SumSRATraits_Core	566.448	462.786	0.558604
SumSRAConstTraits	531.430	493.281	0.595413
SumSRAConstTraits_Core	528.836	495.700	0.598333
SumSRAFastTraits	544.651	481.306	0.580959

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	316.369	828.601
SumSRA_Base_Basic	203.842	1286.018	1.552035
SumSRA_Base	83.317	3146.328	3.797157
SumSRA_Base_Core	76.946	3406.842	4.111559
SumSRATraits	83.593	3135.938	3.784618
SumSRATraits_Core	78.477	3340.396	4.031368
SumSRAConstTraits	77.658	3375.621	4.073880
SumSRAConstTraits_Core	75.790	3458.825	4.174295
SumSRAFastTraits	79.742	3287.385	3.967393

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Vector128 type is not supported! Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Vector128 type is not supported! Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	220.607	1188.285
SumSRA_Base_Basic	270.894	967.699	0.814366
SumSRA_Base	164.401	1594.540	1.341884
SumSRA_Base_Core	155.861	1681.910	1.415410
SumSRA_Avx2	14.999	17476.876	14.707651
SumSRATraits	15.548	16860.804	14.189197
SumSRATraits_Core	12.533	20916.787	17.602506
SumSRAConstTraits	14.976	17503.983	14.730464
SumSRAConstTraits_Core	13.900	18859.417	15.871128
SumSRA128Traits	25.990	10086.214	8.488046
SumSRA128Traits_Core	22.848	11473.584	9.655586
SumSRA128ConstTraits	25.593	10242.934	8.619933
SumSRA128ConstTraits_Core	22.680	11558.141	9.726744
SumSRAFast_Avx2	13.132	19961.511	16.798594
SumSRAFastTraits	14.808	17703.441	14.898317

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	195.424	1341.413
SumSRA_Base_Basic	487.390	537.853	0.400960
SumSRA_Base	330.966	792.058	0.590465
SumSRA_Base_Core	308.508	849.716	0.633449
SumSRA_Avx2	29.956	8750.851	6.523605
SumSRATraits	31.289	8378.105	6.245729
SumSRATraits_Core	22.855	11470.052	8.550720
SumSRAConstTraits	30.234	8670.561	6.463750
SumSRAConstTraits_Core	24.555	10675.798	7.958619
SumSRA128Traits	59.355	4416.572	3.292476
SumSRA128Traits_Core	44.898	5838.648	4.352609
SumSRA128ConstTraits	53.951	4858.903	3.622226
SumSRA128ConstTraits_Core	42.266	6202.266	4.623680
SumSRAFast_Avx2	28.932	9060.637	6.754545
SumSRAFastTraits	28.227	9286.992	6.923288

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	204.017	1284.913
SumSRA_Base_Basic	548.404	478.013	0.372020
SumSRA_Base	548.072	478.302	0.372245
SumSRA_Base_Create	628.787	416.904	0.324461
SumSRA_Base_LoadArray	654.305	400.645	0.311807
SumSRA_Base_Core	542.875	482.881	0.375809
SumSRA_Avx2	86.101	3044.602	2.369501
SumSRATraits	89.231	2937.800	2.286381
SumSRATraits_Core	76.613	3421.681	2.662967
SumSRAConstTraits	86.994	3013.354	2.345182
SumSRAConstTraits_Core	74.009	3542.034	2.756634
SumSRA128Traits	146.544	1788.844	1.392191
SumSRA128Traits_Core	122.874	2133.440	1.660378
SumSRA128ConstTraits	144.439	1814.907	1.412475
SumSRA128ConstTraits_Core	122.979	2131.611	1.658954
SumSRAFast_Avx2	87.342	3001.357	2.335845
SumSRAFast_Avx2_Negative	111.600	2348.961	1.828109
SumSRAFastTraits	85.119	3079.740	2.396848

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	237.657	1103.034
SumSRA_Base128_Basic	404.390	648.245	0.587693
SumSRA_Base128_Basic_Ref	403.484	649.701	0.589013
SumSRA_Base_Basic	224.210	1169.189	1.059975
SumSRA_Base	83.005	3158.168	2.863164
SumSRA_Base_Core	78.340	3346.222	3.033652
SumSRA_Avx2	15.539	16869.961	15.294141
SumSRATraits	15.510	16901.233	15.322492
SumSRATraits_Core	9.280	28249.685	25.610888
SumSRAConstTraits	12.869	20369.699	18.466969
SumSRAConstTraits_Core	8.622	30402.515	27.562621
SumSRA128Traits	28.418	9224.566	8.362901
SumSRA128Traits_Core	15.360	17066.408	15.472238
SumSRA128ConstTraits	21.634	12117.099	10.985243
SumSRA128ConstTraits_Core	15.862	16526.991	14.983208
SumSRAFast_Avx2	11.806	22203.796	20.129744
SumSRAFastTraits	12.042	21769.382	19.735908

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	221.963	1181.028
SumSRA_Base_Basic	267.221	981.000	0.830633
SumSRA_Base	164.540	1593.191	1.348987
SumSRA_Base_Core	153.153	1711.650	1.449289
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	15.871	16517.381	13.985602
SumSRATraits	15.791	16600.567	14.056037
SumSRATraits_Core	13.993	18734.182	15.862612
SumSRAConstTraits	13.347	19640.867	16.630321
SumSRAConstTraits_Core	12.123	21623.658	18.309190
SumSRA128Traits	26.173	10015.999	8.480750
SumSRA128Traits_Core	24.135	10861.751	9.196865
SumSRA128ConstTraits	23.014	11390.604	9.644656
SumSRA128ConstTraits_Core	23.033	11381.088	9.636598
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	13.377	19595.912	16.592256
SumSRAFastTraits	14.647	17896.930	15.153694

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	202.586	1293.990
SumSRA_Base_Basic	513.858	510.149	0.394245
SumSRA_Base	328.116	798.938	0.617422
SumSRA_Base_Core	312.084	839.978	0.649138
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	30.843	8499.406	6.568370
SumSRATraits	33.589	7804.551	6.031384
SumSRATraits_Core	24.898	10528.876	8.136752
SumSRAConstTraits	28.529	9188.833	7.101162
SumSRAConstTraits_Core	26.026	10072.500	7.784063
SumSRA128Traits	71.621	3660.149	2.828576
SumSRA128Traits_Core	44.499	5891.063	4.552634
SumSRA128ConstTraits	46.906	5588.681	4.318952
SumSRA128ConstTraits_Core	40.688	6442.717	4.978954
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	28.742	9120.726	7.048529
SumSRAFastTraits	26.737	9804.511	7.576960

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	198.830	1318.432
SumSRA_Base_Basic	563.017	465.606	0.353151
SumSRA_Base	562.377	466.136	0.353553
SumSRA_Base_Create	624.482	419.778	0.318392
SumSRA_Base_LoadArray	645.665	406.006	0.307946
SumSRA_Base_Core	562.204	466.279	0.353662
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	91.715	2858.260	2.167923
SumSRATraits	92.078	2846.990	2.159376
SumSRATraits_Core	72.862	3597.825	2.728866
SumSRAConstTraits	87.276	3003.633	2.278185
SumSRAConstTraits_Core	78.170	3353.508	2.543557
SumSRA128Traits	146.317	1791.616	1.358899
SumSRA128Traits_Core	122.765	2135.326	1.619595
SumSRA128ConstTraits	128.468	2040.541	1.547702
SumSRA128ConstTraits_Core	121.295	2161.208	1.639226
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	87.807	2985.445	2.264390
SumSRAFast_Avx2_Negative	106.977	2450.472	1.858626
SumSRAFastTraits	88.064	2976.750	2.257795

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	241.587	1085.091
SumSRA_Base128_Basic	401.518	652.882	0.601684
SumSRA_Base128_Basic_Ref	400.816	654.026	0.602739
SumSRA_Base_Basic	237.914	1101.846	1.015441
SumSRA_Base	82.990	3158.751	2.911047
SumSRA_Base_Core	77.220	3394.754	3.128543
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.386	18222.383	16.793414
SumSRATraits	14.395	18210.583	16.782540
SumSRATraits_Core	8.482	30904.967	28.481451
SumSRAConstTraits	9.380	27945.755	25.754296
SumSRAConstTraits_Core	8.449	31026.477	28.593433
SumSRA128Traits	28.644	9151.821	8.434151
SumSRA128Traits_Core	15.284	17151.619	15.806618
SumSRA128ConstTraits	16.826	15579.876	14.358129
SumSRA128ConstTraits_Core	15.918	16468.315	15.176898
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	10.696	24508.918	22.586970
SumSRAFastTraits	10.572	24795.926	22.851472

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	190.441	1376.512
SumSRA_Base_Basic	282.417	928.215	0.674324
SumSRA_Base	168.636	1554.492	1.129298
SumSRA_Base_Core	161.689	1621.285	1.177821
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	15.757	16636.639	12.086080
SumSRATraits	15.705	16692.175	12.126426
SumSRATraits_Core	12.084	21692.735	15.759201
SumSRAConstTraits	11.404	22986.916	16.699390
SumSRAConstTraits_Core	13.390	19577.296	14.222391
SumSRA128Traits	27.336	9589.620	6.966607
SumSRA128Traits_Core	23.779	11024.177	8.008775
SumSRA128ConstTraits	22.386	11710.410	8.507305
SumSRA128ConstTraits_Core	21.439	12227.616	8.883042
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	12.985	20188.707	14.666564
SumSRAFastTraits	14.089	18605.854	13.516664

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	162.526	1612.932
SumSRA_Base_Basic	504.403	519.711	0.322215
SumSRA_Base	346.023	757.591	0.469698
SumSRA_Base_Core	312.123	839.874	0.520712
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	30.843	8499.302	5.269472
SumSRATraits	53.712	4880.572	3.025900
SumSRATraits_Core	69.427	3775.828	2.340971
SumSRAConstTraits	70.274	3730.334	2.312765
SumSRAConstTraits_Core	68.807	3809.859	2.362070
SumSRA128Traits	146.601	1788.144	1.108629
SumSRA128Traits_Core	55.690	4707.168	2.918392
SumSRA128ConstTraits	54.579	4803.045	2.977834
SumSRA128ConstTraits_Core	47.649	5501.580	3.410918
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	29.336	8935.938	5.540181
SumSRAFastTraits	30.562	8577.495	5.317950

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	202.250	1296.141
SumSRA_Base_Basic	555.226	472.140	0.364266
SumSRA_Base	552.579	474.401	0.366010
SumSRA_Base_Create	641.661	408.540	0.315197
SumSRA_Base_LoadArray	656.472	399.323	0.308086
SumSRA_Base_Core	566.350	462.865	0.357110
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	86.927	3015.674	2.326657
SumSRATraits	88.813	2951.634	2.277248
SumSRATraits_Core	73.741	3554.936	2.742709
SumSRAConstTraits	74.910	3499.440	2.699892
SumSRAConstTraits_Core	72.684	3606.630	2.782591
SumSRA128Traits	145.664	1799.643	1.388463
SumSRA128Traits_Core	123.316	2125.784	1.640088
SumSRA128ConstTraits	117.378	2233.335	1.723065
SumSRA128ConstTraits_Core	121.545	2156.770	1.663993
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	85.861	3053.117	2.355544
SumSRAFast_Avx2_Negative	107.938	2428.654	1.873758
SumSRAFastTraits	86.785	3020.614	2.330468

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	192.953	1358.592
SumSRA_Base128_Basic	401.009	653.711	0.481168
SumSRA_Base128_Basic_Ref	401.279	653.271	0.480844
SumSRA_Base_Basic	227.312	1153.235	0.848846
SumSRA_Base	82.284	3185.845	2.344961
SumSRA_Base_Core	78.106	3356.255	2.470393
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.408	18194.031	13.391830
SumSRATraits	14.523	18050.319	13.286050
SumSRATraits_Core	8.633	30363.723	22.349407
SumSRAConstTraits	8.772	29882.510	21.995207
SumSRAConstTraits_Core	8.821	29718.265	21.874313
SumSRA128Traits	28.733	9123.501	6.715410
SumSRA128Traits_Core	15.472	16942.634	12.470731
SumSRA128ConstTraits	15.613	16789.636	12.358115
SumSRA128ConstTraits_Core	15.277	17158.986	12.629978
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	9.079	28872.872	21.252057
SumSRAFastTraits	9.087	28847.491	21.233375

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	170.085	1541.257
SumSRANetBcl	13.096	20016.345	12.987026
SumSRANetBcl_Const	12.190	21504.615	13.952646
SumSRA_Base_Basic	221.897	1181.375	0.766501
SumSRA_Base	13.846	18932.539	12.283829
SumSRA_Base_Core	13.667	19180.436	12.444670
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	15.052	17415.469	11.299522
SumSRATraits	14.080	18617.932	12.079706
SumSRATraits_Core	14.296	18336.871	11.897347
SumSRAConstTraits	13.647	19208.693	12.463004
SumSRAConstTraits_Core	13.759	19052.516	12.361673
SumSRA128Traits	22.920	11437.283	7.420749
SumSRA128Traits_Core	22.876	11459.152	7.434939
SumSRA128ConstTraits	21.113	12416.005	8.055765
SumSRA128ConstTraits_Core	20.499	12788.063	8.297164
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	14.240	18409.410	11.944412
SumSRAFastTraits	14.435	18160.653	11.783014

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	121.203	2162.857
SumSRANetBcl	26.143	10027.419	4.636192
SumSRANetBcl_Const	23.172	11312.948	5.230559
SumSRA_Base_Basic	515.424	508.599	0.235151
SumSRA_Base	25.825	10150.735	4.693208
SumSRA_Base_Core	25.763	10175.064	4.704456
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	30.182	8685.311	4.015666
SumSRATraits	26.274	9977.265	4.613004
SumSRATraits_Core	23.629	11094.133	5.129389
SumSRAConstTraits	24.624	10645.983	4.922186
SumSRAConstTraits_Core	24.393	10746.654	4.968732
SumSRA128Traits	45.197	5800.045	2.681659
SumSRA128Traits_Core	40.717	6438.267	2.976742
SumSRA128ConstTraits	40.729	6436.328	2.975846
SumSRA128ConstTraits_Core	40.864	6415.053	2.966009
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	25.271	10373.218	4.796073
SumSRAFastTraits	25.261	10377.300	4.797960

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	160.396	1634.356
SumSRANetBcl	447.982	585.167	0.358041
SumSRANetBcl_Const	466.966	561.377	0.343485
SumSRA_Base_Basic	541.760	483.875	0.296065
SumSRA_Base	122.875	2133.418	1.305358
SumSRA_Base_Create	87.714	2988.608	1.828616
SumSRA_Base_LoadArray	107.664	2434.825	1.489777
SumSRA_Base_Core	104.109	2517.986	1.540660
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	95.186	2754.028	1.685085
SumSRATraits	90.975	2881.506	1.763084
SumSRATraits_Core	77.780	3370.311	2.062165
SumSRAConstTraits	77.878	3366.094	2.059585
SumSRAConstTraits_Core	81.464	3217.932	1.968930
SumSRA128Traits	152.591	1717.949	1.051148
SumSRA128Traits_Core	124.004	2113.989	1.293469
SumSRA128ConstTraits	115.284	2273.897	1.391311
SumSRA128ConstTraits_Core	115.714	2265.455	1.386146
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	88.532	2961.021	1.811736
SumSRAFast_Avx2_Negative	112.840	2323.139	1.421441
SumSRAFastTraits	88.463	2963.319	1.813142

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	163.992	1598.519
SumSRANetBcl	226.234	1158.731	0.724878
SumSRANetBcl_Const	224.896	1165.626	0.729191
SumSRA_Base128_Basic	168.513	1555.628	0.973168
SumSRA_Base128_Basic_Ref	169.040	1550.783	0.970137
SumSRA_Base_Basic	224.940	1165.394	0.729046
SumSRA_Base	14.013	18707.139	11.702795
SumSRA_Base_Core	10.548	24852.198	15.547016
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	13.325	19673.763	12.307495
SumSRATraits	12.705	20633.644	12.907977
SumSRATraits_Core	8.327	31479.552	19.692951
SumSRAConstTraits	8.997	29136.609	18.227254
SumSRAConstTraits_Core	8.992	29154.267	18.238301
SumSRA128Traits	24.664	10628.801	6.649156
SumSRA128Traits_Core	14.553	18013.408	11.268812
SumSRA128ConstTraits	15.916	16470.361	10.303514
SumSRA128ConstTraits_Core	16.318	16065.149	10.050022
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	8.843	29645.745	18.545759
SumSRAFastTraits	9.108	28782.474	18.005715

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	446.370	587.279
SumSRA_Base_Basic	524.311	499.978	0.851347
SumSRA_Base	169.016	1550.998	2.640990
SumSRA_Base_Core	148.814	1761.556	2.999521
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	168.134	1559.138	2.654850
SumSRATraits_Core	143.758	1823.509	3.105013
SumSRAConstTraits	144.914	1808.965	3.080247
SumSRAConstTraits_Core	144.789	1810.527	3.082907
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	149.417	1754.440	2.987405

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	367.834	712.668
SumSRA_Base_Basic	824.375	317.991	0.446198
SumSRA_Base	316.041	829.461	1.163881
SumSRA_Base_Core	300.706	871.763	1.223237
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	336.174	779.787	1.094179
SumSRATraits_Core	286.701	914.346	1.282990
SumSRAConstTraits	296.237	884.914	1.241691
SumSRAConstTraits_Core	284.819	920.389	1.291468
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	299.356	875.693	1.228752

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	365.286	717.640
SumSRA_Base_Basic	1330.569	197.017	0.274534
SumSRA_Base	571.528	458.672	0.639140
SumSRA_Base_Create	592.009	442.804	0.617029
SumSRA_Base_LoadArray	726.084	361.038	0.503091
SumSRA_Base_Core	1313.846	199.524	0.278028
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	580.022	451.956	0.629781
SumSRATraits_Core	602.380	435.180	0.606405
SumSRAConstTraits	598.777	437.799	0.610054
SumSRAConstTraits_Core	600.670	436.419	0.608131
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	603.611	434.293	0.605168

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	453.720	577.766
SumSRA_Base_Basic	393.284	666.552	1.153671
SumSRA_Base	86.602	3026.992	5.239132
SumSRA_Base_Core	76.370	3432.558	5.941086
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	87.638	2991.228	5.177231
SumSRATraits_Core	74.276	3529.326	6.108573
SumSRAConstTraits	75.412	3476.138	6.016515
SumSRAConstTraits_Core	73.267	3577.927	6.192692
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	75.831	3456.946	5.983298

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
Check-SumSRAConstTraits	Check `SumSRAConstTraits` mismatch. -24614!=-12499
SumSRAScalar	484.406	541.166
SumSRA_Base_Basic	558.961	468.984	0.866619
SumSRA_Base	174.180	1505.018	2.781065
SumSRA_Base_Core	153.409	1708.796	3.157619
SumSRA_AdvSimd	53.113	4935.548	9.120211
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	52.953	4950.480	9.147803
SumSRATraits_Core	31.249	8388.956	15.501632
SumSRAConstTraits	39.780	6589.881	12.177190
SumSRAConstTraits_Core	31.234	8392.943	15.509000
SumSRAFast_AdvSimd	33.441	7839.053	14.485488
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	39.793	6587.622	12.173017

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	351.086	746.666
SumSRA_Base_Basic	793.372	330.418	0.442524
SumSRA_Base	667.019	393.008	0.526351
SumSRA_Base_Core	273.014	960.185	1.285964
SumSRA_AdvSimd	93.338	2808.552	3.761458
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	89.038	2944.169	3.943088
SumSRATraits_Core	63.539	4125.748	5.525562
SumSRAConstTraits	80.258	3266.272	4.374476
SumSRAConstTraits_Core	63.409	4134.164	5.536833
SumSRAFast_AdvSimd	68.421	3831.355	5.131286
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	68.172	3845.319	5.149987

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	353.122	742.361
SumSRA_Base_Basic	541.363	484.230	0.652283
SumSRA_Base	541.164	484.408	0.652523
SumSRA_Base_Create	545.533	480.529	0.647298
SumSRA_Base_LoadArray	650.260	403.137	0.543047
SumSRA_Base_Core	549.167	477.348	0.643013
SumSRA_AdvSimd	186.158	1408.181	1.896895
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	212.189	1235.429	1.664188
SumSRATraits_Core	132.884	1972.734	2.657378
SumSRAConstTraits	133.605	1962.084	2.643031
SumSRAConstTraits_Core	124.872	2099.303	2.827872
SumSRAFast_AdvSimd	133.786	1959.429	2.639454
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	133.777	1959.553	2.639622

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	429.274	610.669
SumSRA_Base_Basic	367.815	712.706	1.167091
SumSRA_Base	77.118	3399.260	5.566454
SumSRA_Base_Core	66.977	3913.964	6.409307
SumSRA_AdvSimd	23.283	11259.027	18.437205
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.237	11281.229	18.473562
SumSRATraits_Core	15.587	16818.297	27.540782
SumSRAConstTraits	16.717	15680.873	25.678193
SumSRAConstTraits_Core	15.592	16813.202	27.532438
SumSRAFast_AdvSimd	16.748	15651.930	25.630798
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	16.707	15691.023	25.694815

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	431.705	607.230
SumSRA_Base_Basic	499.842	524.454	0.863682
SumSRA_Base	374.423	700.127	1.152985
SumSRA_Base_Core	135.073	1940.752	3.196073
SumSRA_AdvSimd	46.442	5644.488	9.295468
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	46.434	5645.497	9.297130
SumSRATraits_Core	33.164	7904.366	13.017084
SumSRAConstTraits	33.215	7892.407	12.997391
SumSRAConstTraits_Core	33.199	7896.220	13.003670
SumSRAFast_AdvSimd	33.189	7898.538	13.007488
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	31.162	8412.310	13.853578

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	350.903	747.055
SumSRA_Base_Basic	790.944	331.432	0.443651
SumSRA_Base	666.696	393.199	0.526332
SumSRA_Base_Core	270.425	969.376	1.297597
SumSRA_AdvSimd	106.249	2467.260	3.302648
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	89.012	2945.026	3.942181
SumSRATraits_Core	63.391	4135.353	5.535540
SumSRAConstTraits	67.354	3892.016	5.209812
SumSRAConstTraits_Core	67.336	3893.088	5.211247
SumSRAFast_AdvSimd	63.524	4126.674	5.523922
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	67.198	3901.047	5.221901

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	353.133	742.337
SumSRA_Base_Basic	542.201	483.481	0.651296
SumSRA_Base	542.529	483.189	0.650903
SumSRA_Base_Create	541.613	484.006	0.652003
SumSRA_Base_LoadArray	601.682	435.685	0.586910
SumSRA_Base_Core	549.734	476.856	0.642372
SumSRA_AdvSimd	186.112	1408.528	1.897424
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	212.466	1233.818	1.662072
SumSRATraits_Core	133.271	1966.992	2.649729
SumSRAConstTraits	133.275	1966.946	2.649666
SumSRAConstTraits_Core	124.991	2097.296	2.825260
SumSRAFast_AdvSimd	124.931	2098.306	2.826621
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	133.046	1970.332	2.654228

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	389.639	672.786
SumSRA_Base_Basic	368.363	711.647	1.057760
SumSRA_Base	76.118	3443.934	5.118911
SumSRA_Base_Core	154.119	1700.917	2.528167
SumSRA_AdvSimd	23.394	11205.761	16.655746
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.248	11275.758	16.759786
SumSRATraits_Core	15.578	16827.844	25.012161
SumSRAConstTraits	15.576	16829.920	25.015247
SumSRAConstTraits_Core	16.631	15762.243	23.428299
SumSRAFast_AdvSimd	16.591	15800.184	23.484693
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	16.612	15780.403	23.455291

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


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	318.685	822.580
SumSRANetBcl	26.369	9941.333	12.085549
SumSRANetBcl_Const	26.377	9938.477	12.082077
SumSRA_Base_Basic	477.864	548.575	0.666895
SumSRA_Base	26.360	9944.813	12.089780
SumSRA_Base_Core	26.379	9937.640	12.081059
SumSRA_AdvSimd	46.091	5687.558	6.914290
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	26.377	9938.217	12.081761
SumSRATraits_Core	26.376	9938.584	12.082207
SumSRAConstTraits	26.556	9871.343	12.000463
SumSRAConstTraits_Core	26.411	9925.543	12.066353
SumSRAFast_AdvSimd	26.362	9944.129	12.088949
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	26.380	9937.396	12.080763

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	220.558	1188.551
SumSRANetBcl	53.918	4861.897	4.090610
SumSRANetBcl_Const	53.941	4859.816	4.088859
SumSRA_Base_Basic	772.611	339.296	0.285471
SumSRA_Base	54.095	4846.014	4.077247
SumSRA_Base_Core	54.067	4848.500	4.079338
SumSRA_AdvSimd	79.784	3285.681	2.764444
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	53.841	4868.865	4.096473
SumSRATraits_Core	53.916	4862.075	4.090760
SumSRAConstTraits	54.147	4841.364	4.073334
SumSRAConstTraits_Core	54.113	4844.364	4.075859
SumSRAFast_AdvSimd	53.813	4871.387	4.098595
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	53.814	4871.318	4.098537

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	220.303	1189.925
SumSRANetBcl	106.209	2468.196	2.074245
SumSRANetBcl_Const	106.070	2471.434	2.076967
SumSRA_Base_Basic	551.948	474.944	0.399137
SumSRA_Base	106.280	2466.542	2.072855
SumSRA_Base_Create	147.056	1782.609	1.498086
SumSRA_Base_LoadArray	197.744	1325.673	1.114081
SumSRA_Base_Core	106.211	2468.146	2.074204
SumSRA_AdvSimd	184.537	1420.547	1.193813
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	184.593	1420.116	1.193450
SumSRATraits_Core	106.306	2465.932	2.072343
SumSRAConstTraits	106.096	2470.825	2.076455
SumSRAConstTraits_Core	106.168	2469.149	2.075046
SumSRAFast_AdvSimd	106.220	2467.935	2.074026
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFast_Avx2_Negative	Run fail! Requires hardware support Avx, Avx2!
SumSRAFastTraits	106.463	2462.309	2.069298

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	283.241	925.515
SumSRANetBcl	13.244	19792.701	21.385605
SumSRANetBcl_Const	13.245	19792.641	21.385540
SumSRA_Base_Basic	344.059	761.916	0.823235
SumSRA_Base	32.907	7966.148	8.607258
SumSRA_Base_Core	23.107	11344.947	12.257981
SumSRA_AdvSimd	23.097	11349.802	12.263226
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.082	11356.994	12.270997
SumSRATraits_Core	13.240	19798.924	21.392328
SumSRAConstTraits	13.257	19774.470	21.365907
SumSRAConstTraits_Core	13.267	19759.552	21.349788
SumSRAFast_AdvSimd	13.212	19841.339	21.438157
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	13.247	19789.471	21.382115

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

