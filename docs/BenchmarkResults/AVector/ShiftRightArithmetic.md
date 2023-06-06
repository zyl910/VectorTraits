# Benchmark - ShiftRightArithmetic
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 4.5

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.4614.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	2130476158	# 0x7EFC7C7E
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	318.592	822.822
SumSRA_Base	149.076	1758.463	2.137113
SumSRA_Base_Core	149.181	1757.223	2.135606
SumSRATraits	149.046	1758.812	2.137537
SumSRATraits_Core	149.086	1758.339	2.136962
SumSRAConstTraits	137.975	1899.938	2.309052
SumSRAConstTraits_Core	138.011	1899.447	2.308455
SumSRAFastTraits	149.396	1754.687	2.132524

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	314.838	832.631
SumSRA_Base	318.337	823.480	0.989009
SumSRA_Base_Core	319.021	821.713	0.986887
SumSRATraits	318.288	823.606	0.989160
SumSRATraits_Core	317.919	824.562	0.990309
SumSRAConstTraits	276.347	948.606	1.139287
SumSRAConstTraits_Core	276.808	947.025	1.137388
SumSRAFastTraits	296.856	883.069	1.060577

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	318.084	824.134
SumSRA_Base	560.953	467.319	0.567043
SumSRA_Base_Core	588.857	445.174	0.540172
SumSRATraits	559.439	468.584	0.568577
SumSRATraits_Core	558.910	469.027	0.569115
SumSRAConstTraits	483.687	541.970	0.657624
SumSRAConstTraits_Core	484.654	540.889	0.656312
SumSRAFastTraits	524.941	499.378	0.605942

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	312.200	839.667
SumSRA_Base	74.342	3526.175	4.199493
SumSRA_Base_Core	74.604	3513.784	4.184736
SumSRATraits	74.686	3509.961	4.180183
SumSRATraits_Core	75.045	3493.160	4.160174
SumSRAConstTraits	70.229	3732.698	4.445452
SumSRAConstTraits_Core	69.156	3790.614	4.514427
SumSRAFastTraits	74.429	3522.055	4.194586

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
VectorTraitsGlobal.InitCheckSum:	2130476158	# 0x7EFC7C7E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	316.344	828.667
SumSRA_Base	165.563	1583.347	1.910716
SumSRA_Base_Core	151.878	1726.015	2.082881
SumSRATraits	149.060	1758.644	2.122257
SumSRATraits_Core	148.679	1763.159	2.127706
SumSRAConstTraits	138.062	1898.741	2.291320
SumSRAConstTraits_Core	138.432	1893.668	2.285198
SumSRAFastTraits	149.161	1757.462	2.120831

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	314.153	834.447
SumSRA_Base	319.028	821.696	0.984719
SumSRA_Base_Core	322.389	813.128	0.974452
SumSRATraits	322.329	813.281	0.974634
SumSRATraits_Core	321.993	814.131	0.975653
SumSRAConstTraits	278.959	939.722	1.126161
SumSRAConstTraits_Core	277.646	944.167	1.131488
SumSRAFastTraits	296.918	882.883	1.058045

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	317.735	825.040
SumSRA_Base	560.019	468.099	0.567365
SumSRA_Base_Core	589.398	444.766	0.539084
SumSRATraits	562.625	465.930	0.564737
SumSRATraits_Core	561.592	466.788	0.565776
SumSRAConstTraits	484.071	541.540	0.656381
SumSRAConstTraits_Core	484.380	541.195	0.655962
SumSRAFastTraits	526.264	498.122	0.603756

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	314.561	833.365
SumSRA_Base	74.323	3527.108	4.232370
SumSRA_Base_Core	74.629	3512.651	4.215022
SumSRATraits	74.730	3507.859	4.209273
SumSRATraits_Core	74.612	3513.431	4.215959
SumSRAConstTraits	69.254	3785.247	4.542125
SumSRAConstTraits_Core	69.138	3791.630	4.549785
SumSRAFastTraits	74.695	3509.529	4.211277

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	220.584	1188.411
SumSRA_Base	154.402	1697.805	1.428634
SumSRA_Base_Core	154.407	1697.744	1.428583
SumSRA_Avx2	14.997	17479.721	14.708475
SumSRATraits	14.809	17701.283	14.894911
SumSRATraits_Core	13.080	20041.106	16.863777
SumSRAConstTraits	15.624	16778.260	14.118225
SumSRAConstTraits_Core	13.306	19701.241	16.577794
SumSRAFast_Avx2	14.193	18469.729	15.541526
SumSRAFastTraits	14.888	17607.716	14.816177

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	196.131	1336.577
SumSRA_Base	310.091	845.378	0.632494
SumSRA_Base_Core	310.281	844.861	0.632108
SumSRA_Avx2	30.289	8654.671	6.475249
SumSRATraits	30.719	8533.478	6.384575
SumSRATraits_Core	24.272	10800.361	8.080610
SumSRAConstTraits	30.800	8511.206	6.367911
SumSRAConstTraits_Core	25.594	10242.350	7.663118
SumSRAFast_Avx2	30.047	8724.377	6.527401
SumSRAFastTraits	28.855	9084.928	6.797158

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	199.365	1314.896
SumSRA_Base	544.046	481.841	0.366448
SumSRA_Base_Core	543.540	482.290	0.366790
SumSRA_Avx2	112.348	2333.327	1.774534
SumSRATraits	112.955	2320.783	1.764994
SumSRATraits_Core	71.965	3642.656	2.770300
SumSRAConstTraits	105.985	2473.399	1.881060
SumSRAConstTraits_Core	73.806	3551.778	2.701186
SumSRAFast_Avx2	105.609	2482.206	1.887759
SumSRAFastTraits	108.818	2409.022	1.832101

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	235.844	1111.515
SumSRA_Base	79.002	3318.182	2.985279
SumSRA_Base_Core	77.742	3371.976	3.033676
SumSRA_Avx2	16.430	15955.039	14.354319
SumSRATraits	16.417	15967.381	14.365422
SumSRATraits_Core	8.832	29681.622	26.703756
SumSRAConstTraits	12.138	21597.213	19.430431
SumSRAConstTraits_Core	8.607	30456.005	27.400448
SumSRAFast_Avx2	11.309	23181.082	20.855395
SumSRAFastTraits	11.494	22806.202	20.518125

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 5

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	221.188	1185.166
SumSRA_Base	151.967	1725.009	1.455500
SumSRA_Base_Core	151.689	1728.162	1.458161
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.562	18002.016	15.189448
SumSRATraits	15.324	17106.394	14.433755
SumSRATraits_Core	13.867	18903.654	15.950218
SumSRAConstTraits	13.021	20133.114	16.987591
SumSRAConstTraits_Core	13.230	19814.317	16.718602
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	13.062	20068.467	16.933044
SumSRAFastTraits	12.864	20377.405	17.193715

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	196.890	1331.422
SumSRA_Base	306.282	855.891	0.642840
SumSRA_Base_Core	362.234	723.687	0.543544
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	35.850	7312.321	5.492114
SumSRATraits	31.545	8310.205	6.241602
SumSRATraits_Core	24.653	10633.147	7.986310
SumSRAConstTraits	26.706	9815.982	7.372556
SumSRAConstTraits_Core	24.285	10794.387	8.107414
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	26.235	9992.298	7.504983
SumSRAFastTraits	26.288	9971.856	7.489630

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	198.698	1319.310
SumSRA_Base	563.004	465.616	0.352924
SumSRA_Base_Core	562.851	465.743	0.353021
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	109.884	2385.635	1.808244
SumSRATraits	113.779	2303.979	1.746352
SumSRATraits_Core	74.344	3526.117	2.672698
SumSRAConstTraits	107.175	2445.954	1.853964
SumSRAConstTraits_Core	73.069	3587.635	2.719327
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	105.670	2480.769	1.880353
SumSRAFastTraits	106.023	2472.519	1.874101

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	234.812	1116.402
SumSRA_Base	78.643	3333.356	2.985803
SumSRA_Base_Core	79.059	3315.792	2.970071
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	16.778	15624.385	13.995307
SumSRATraits	16.723	15675.363	14.040970
SumSRATraits_Core	9.414	27846.348	24.942947
SumSRAConstTraits	10.331	25373.867	22.728260
SumSRAConstTraits_Core	9.399	27890.669	24.982647
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	10.720	24454.761	21.904984
SumSRAFastTraits	10.921	24004.566	21.501728

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 6

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	194.437	1348.219
SumSRA_Base	151.871	1726.099	1.280281
SumSRA_Base_Core	152.031	1724.274	1.278928
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	15.280	17155.830	12.724814
SumSRATraits	15.285	17150.702	12.721010
SumSRATraits_Core	12.902	20318.480	15.070613
SumSRAConstTraits	12.122	21626.365	16.040697
SumSRAConstTraits_Core	12.170	21540.121	15.976728
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	14.346	18273.432	13.553761
SumSRAFastTraits	14.432	18164.234	13.472767

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	163.680	1601.568
SumSRA_Base	307.268	853.144	0.532693
SumSRA_Base_Core	306.947	854.038	0.533251
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	30.593	8568.691	5.350188
SumSRATraits	32.614	8037.874	5.018752
SumSRATraits_Core	27.546	9516.558	5.942024
SumSRAConstTraits	24.731	10599.716	6.618335
SumSRAConstTraits_Core	25.303	10360.085	6.468712
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	26.037	10068.282	6.286514
SumSRAFastTraits	26.177	10014.271	6.252790

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	198.087	1323.381
SumSRA_Base	557.706	470.040	0.355181
SumSRA_Base_Core	559.726	468.343	0.353899
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	113.399	2311.695	1.746810
SumSRATraits	110.666	2368.788	1.789952
SumSRATraits_Core	82.550	3175.572	2.399590
SumSRAConstTraits	88.400	2965.443	2.240808
SumSRAConstTraits_Core	73.135	3584.367	2.708492
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	107.363	2441.660	1.845017
SumSRAFastTraits	105.604	2482.335	1.875753

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	193.475	1354.925
SumSRA_Base	75.912	3453.275	2.548683
SumSRA_Base_Core	75.944	3451.787	2.547585
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	16.951	15465.131	11.414010
SumSRATraits	16.844	15563.282	11.486450
SumSRATraits_Core	9.259	28312.374	20.895893
SumSRAConstTraits	9.358	28012.964	20.674914
SumSRAConstTraits_Core	9.001	29124.135	21.495011
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	9.288	28225.130	20.831503
SumSRAFastTraits	9.827	26675.021	19.687447

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 7

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	164.745	1591.213
SumSRANetBcl	13.457	19479.795	12.242101
SumSRANetBcl_Const	11.813	22191.444	13.946240
SumSRA_Base	14.778	17738.923	11.148047
SumSRA_Base_Core	14.822	17686.236	11.114936
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	15.262	17175.848	10.794182
SumSRATraits	15.347	17081.296	10.734761
SumSRATraits_Core	13.065	20064.167	12.609350
SumSRAConstTraits	12.136	21600.429	13.574815
SumSRAConstTraits_Core	12.070	21719.509	13.649651
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	12.919	20291.825	12.752422
SumSRAFastTraits	13.216	19835.476	12.465628

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	158.336	1655.617
SumSRANetBcl	24.259	10806.268	6.527033
SumSRANetBcl_Const	23.476	11166.665	6.744714
SumSRA_Base	25.456	10297.979	6.220024
SumSRA_Base_Core	27.498	9533.248	5.758123
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	30.714	8534.869	5.155098
SumSRATraits	30.858	8495.269	5.131179
SumSRATraits_Core	25.962	10097.222	6.098766
SumSRAConstTraits	25.575	10250.099	6.191105
SumSRAConstTraits_Core	25.950	10101.952	6.101623
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	27.161	9651.346	5.829455
SumSRAFastTraits	25.905	10119.262	6.112078

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	160.067	1637.716
SumSRANetBcl	467.755	560.431	0.342202
SumSRANetBcl_Const	448.556	584.417	0.356849
SumSRA_Base	123.414	2124.102	1.296990
SumSRA_Base_Core	120.366	2177.898	1.329838
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	113.090	2318.020	1.415398
SumSRATraits	112.927	2321.358	1.417436
SumSRATraits_Core	71.446	3669.136	2.240398
SumSRAConstTraits	84.233	3112.112	1.900275
SumSRAConstTraits_Core	76.835	3411.773	2.083250
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	105.549	2483.613	1.516510
SumSRAFastTraits	106.178	2468.913	1.507534

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	160.674	1631.530
SumSRANetBcl	224.433	1168.030	0.715911
SumSRANetBcl_Const	223.735	1171.671	0.718143
SumSRA_Base	15.065	17401.291	10.665630
SumSRA_Base_Core	15.572	16834.781	10.318404
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	15.287	17147.693	10.510194
SumSRATraits	15.169	17281.101	10.591963
SumSRATraits_Core	8.129	32247.291	19.765067
SumSRAConstTraits	8.508	30810.353	18.884336
SumSRAConstTraits_Core	8.650	30306.752	18.575668
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	8.850	29620.015	18.154752
SumSRAFastTraits	8.999	29129.808	17.854293

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
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	3.1.31
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.31
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	431.478	607.549
SumSRA_Base	189.474	1383.535	2.277239
SumSRA_Base_Core	189.593	1382.670	2.275815
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	162.218	1616.001	2.659867
SumSRATraits_Core	189.732	1381.652	2.274140
SumSRAConstTraits	165.895	1580.182	2.600912
SumSRAConstTraits_Core	168.217	1558.365	2.565002
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	144.687	1811.799	2.982144

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	349.849	749.307
SumSRA_Base	770.951	340.027	0.453789
SumSRA_Base_Core	779.798	336.169	0.448640
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	324.449	807.968	1.078287
SumSRATraits_Core	380.516	688.917	0.919407
SumSRAConstTraits	337.408	776.936	1.036873
SumSRAConstTraits_Core	765.947	342.248	0.456753
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	286.307	915.604	1.221935

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	353.599	741.360
SumSRA_Base	1277.926	205.132	0.276697
SumSRA_Base_Core	542.385	483.317	0.651934
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	557.627	470.106	0.634113
SumSRATraits_Core	541.873	483.774	0.652549
SumSRAConstTraits	552.106	474.807	0.640454
SumSRAConstTraits_Core	543.324	482.482	0.650807
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	555.951	471.524	0.636025

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	429.760	609.978
SumSRA_Base	94.528	2773.188	4.546374
SumSRA_Base_Core	94.692	2768.391	4.538508
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	79.543	3295.643	5.402888
SumSRATraits_Core	191.237	1370.784	2.247267
SumSRAConstTraits	83.563	3137.073	5.142927
SumSRAConstTraits_Core	83.148	3152.736	5.168605
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	70.570	3714.683	6.089863

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 5

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
Check-SumSRAConstTraits	Fail! Check `SumSRAConstTraits` fail! -24614!=-12499
SumSRAScalar	431.540	607.462
SumSRA_Base	180.238	1454.436	2.394283
SumSRA_Base_Core	180.293	1453.989	2.393547
SumSRA_AdvSimd	46.433	5645.682	9.293885
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	52.886	4956.777	8.159813
SumSRATraits_Core	31.101	8428.734	13.875327
SumSRAConstTraits	39.513	6634.335	10.921399
SumSRAConstTraits_Core	31.134	8419.991	13.860934
SumSRAFast_AdvSimd	33.371	7855.376	12.931469
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	39.504	6635.878	10.923939

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	350.106	748.756
SumSRA_Base	362.638	722.881	0.965444
SumSRA_Base_Core	363.956	720.262	0.961946
SumSRA_AdvSimd	93.323	2809.005	3.751565
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	89.048	2943.851	3.931657
SumSRATraits_Core	63.441	4132.082	5.518599
SumSRAConstTraits	80.109	3272.324	4.370349
SumSRAConstTraits_Core	63.452	4131.383	5.517665
SumSRAFast_AdvSimd	68.080	3850.507	5.142542
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	68.046	3852.431	5.145111

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	352.832	742.970
SumSRA_Base	541.496	484.111	0.651589
SumSRA_Base_Core	541.549	484.063	0.651525
SumSRA_AdvSimd	186.046	1409.026	1.896477
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	212.003	1236.510	1.664279
SumSRATraits_Core	133.010	1970.862	2.652680
SumSRAConstTraits	133.823	1958.880	2.636552
SumSRAConstTraits_Core	125.159	2094.486	2.819071
SumSRAFast_AdvSimd	133.969	1956.746	2.633681
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	133.984	1956.535	2.633397

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	428.882	611.227
SumSRA_Base	91.889	2852.824	4.667375
SumSRA_Base_Core	92.219	2842.627	4.650692
SumSRA_AdvSimd	23.253	11273.588	18.444205
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.180	11308.933	18.502030
SumSRATraits_Core	15.609	16794.087	27.476042
SumSRAConstTraits	16.741	15658.634	25.618379
SumSRAConstTraits_Core	15.579	16826.530	27.529120
SumSRAFast_AdvSimd	16.662	15733.298	25.740533
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	16.874	15535.373	25.416717

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 6

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	6.0.11
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/
RuntimeInformation.FrameworkDescription:	.NET 6.0.11
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	432.534	606.066
SumSRA_Base	170.024	1541.803	2.543955
SumSRA_Base_Core	171.074	1532.344	2.528347
SumSRA_AdvSimd	53.232	4924.542	8.125428
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	53.235	4924.264	8.124969
SumSRATraits_Core	31.851	8230.375	13.580008
SumSRAConstTraits	31.859	8228.344	13.576657
SumSRAConstTraits_Core	31.869	8225.552	13.572051
SumSRAFast_AdvSimd	31.863	8227.206	13.574778
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	33.770	7762.666	12.808295

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	349.280	750.527
SumSRA_Base	338.470	774.498	1.031940
SumSRA_Base_Core	335.785	780.690	1.040189
SumSRA_AdvSimd	88.984	2945.974	3.925210
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	93.200	2812.698	3.747633
SumSRATraits_Core	67.508	3883.180	5.173941
SumSRAConstTraits	63.842	4106.115	5.470979
SumSRAConstTraits_Core	63.685	4116.228	5.484454
SumSRAFast_AdvSimd	67.659	3874.486	5.162357
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	63.787	4109.687	5.475738

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	352.799	743.040
SumSRA_Base	549.201	477.318	0.642386
SumSRA_Base_Core	542.399	483.305	0.650443
SumSRA_AdvSimd	212.382	1234.303	1.661152
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	186.034	1409.121	1.896427
SumSRATraits_Core	124.891	2098.980	2.824855
SumSRAConstTraits	124.893	2098.950	2.824815
SumSRAConstTraits_Core	133.013	1970.818	2.652372
SumSRAFast_AdvSimd	132.955	1971.672	2.653521
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	133.050	1970.264	2.651626

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	399.945	655.450
SumSRA_Base	85.285	3073.752	4.689529
SumSRA_Base_Core	85.485	3066.549	4.678541
SumSRA_AdvSimd	26.480	9899.607	15.103529
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	26.478	9900.487	15.104871
SumSRATraits_Core	16.570	15820.039	24.136151
SumSRAConstTraits	16.539	15849.886	24.181687
SumSRAConstTraits_Core	15.568	16838.432	25.689882
SumSRAFast_AdvSimd	15.557	16850.754	25.708681
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	15.571	16835.738	25.685772

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 7

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	7.0.1
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/
RuntimeInformation.FrameworkDescription:	.NET 7.0.1
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	320.557	817.777
SumSRANetBcl	26.758	9796.756	11.979745
SumSRANetBcl_Const	26.673	9828.067	12.018033
SumSRA_Base	26.665	9831.056	12.021688
SumSRA_Base_Core	26.701	9817.888	12.005585
SumSRA_AdvSimd	46.381	5651.971	6.911387
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	46.412	5648.247	6.906832
SumSRATraits_Core	26.701	9817.770	12.005442
SumSRAConstTraits	26.751	9799.310	11.982869
SumSRAConstTraits_Core	26.707	9815.734	12.002952
SumSRAFast_AdvSimd	26.703	9817.066	12.004580
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	26.692	9821.205	12.009641

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	224.719	1166.539
SumSRANetBcl	54.265	4830.803	4.141140
SumSRANetBcl_Const	54.140	4841.963	4.150707
SumSRA_Base	54.109	4844.752	4.153098
SumSRA_Base_Core	54.206	4836.097	4.145679
SumSRA_AdvSimd	79.920	3280.073	2.811798
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	80.092	3273.040	2.805769
SumSRATraits_Core	54.152	4840.852	4.149754
SumSRAConstTraits	54.499	4810.088	4.123382
SumSRAConstTraits_Core	54.457	4813.777	4.126545
SumSRAFast_AdvSimd	54.205	4836.118	4.145696
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	54.178	4838.613	4.147835

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	221.661	1182.637
SumSRANetBcl	106.247	2467.312	2.086280
SumSRANetBcl_Const	106.281	2466.521	2.085611
SumSRA_Base	316.330	828.703	0.700725
SumSRA_Base_Core	316.415	828.481	0.700537
SumSRA_AdvSimd	184.804	1418.494	1.199433
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	184.612	1419.971	1.200681
SumSRATraits_Core	106.404	2463.674	2.083203
SumSRAConstTraits	106.039	2472.153	2.090373
SumSRAConstTraits_Core	106.489	2461.704	2.081538
SumSRAFast_AdvSimd	106.337	2465.219	2.084509
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	106.354	2464.829	2.084180

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	292.587	895.952
SumSRANetBcl	13.253	19779.999	22.077067
SumSRANetBcl_Const	13.231	19813.264	22.114195
SumSRA_Base	37.904	6915.913	7.719064
SumSRA_Base_Core	37.877	6920.930	7.724664
SumSRA_AdvSimd	23.082	11357.060	12.675966
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.057	11369.264	12.689587
SumSRATraits_Core	13.220	19830.005	22.132880
SumSRAConstTraits	13.231	19813.544	22.114508
SumSRAConstTraits_Core	13.234	19808.548	22.108932
SumSRAFast_AdvSimd	13.197	19863.301	22.170043
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	13.260	19769.927	22.065825

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

