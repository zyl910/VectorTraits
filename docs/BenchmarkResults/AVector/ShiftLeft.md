# Benchmark - ShiftLeft
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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	310.192	845.103
SumSLL_Base	36.218	7237.880	8.564495
SumSLL_Base_Core	6.501	40322.785	47.713459
SumSLL_Multiply	36.300	7221.616	8.545250
SumSLLTraits	34.599	7576.734	8.965457
SumSLLTraits_Core	6.401	40954.796	48.461310
SumSLLConstTraits	24.555	10675.936	12.632705
SumSLLConstTraits_Core	8.120	32284.495	38.201849
SumSLLFast_Multiply	23.199	11299.781	13.370893
SumSLLFastTraits	23.122	11337.474	13.415495

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	317.258	826.281
SumSLL_Base	105.259	2490.462	3.014062
SumSLL_Base_Core	29.082	9013.810	10.908893
SumSLL_Base_Core_Element	54.152	4840.894	5.858655
SumSLL_Base_Core_Mov	54.688	4793.464	5.801253
SumSLL_Multiply	49.658	5279.022	6.388895
SumSLLTraits	48.954	5354.881	6.480704
SumSLLTraits_Core	13.685	19155.313	23.182570
SumSLLConstTraits	44.959	5830.783	7.056660
SumSLLConstTraits_Core	13.579	19305.405	23.364216
SumSLLFast_Multiply	45.806	5722.919	6.926118
SumSLLFastTraits	43.666	6003.428	7.265602

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	314.418	833.743
SumSLL_Base	101.218	2589.890	3.106340
SumSLL_Base_Core	29.829	8788.324	10.540807
SumSLL_Multiply	98.408	2663.837	3.195034
SumSLLTraits	94.239	2781.690	3.336388
SumSLLTraits_Core	33.150	7907.810	9.484709
SumSLLConstTraits	85.574	3063.367	3.674234
SumSLLConstTraits_Core	29.351	8931.223	10.712201
SumSLLFast_Multiply	86.207	3040.881	3.647264
SumSLLFastTraits	86.909	3016.321	3.617806

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	321.373	815.699
SumSLL_Base	560.055	468.068	0.573825
SumSLL_Base_Core	588.596	445.372	0.546000
SumSLLTraits	564.596	464.304	0.569210
SumSLLTraits_Core	561.435	466.918	0.572414
SumSLLConstTraits	484.380	541.195	0.663474
SumSLLConstTraits_Core	483.147	542.576	0.665166
SumSLLFastTraits	523.990	500.284	0.613319

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	309.306	847.522
SumSLL_Base	34.707	7553.009	8.911874
SumSLL_Base_Core	6.698	39137.730	46.179016
SumSLL_Multiply	33.094	7921.193	9.346298
SumSLLTraits	33.337	7863.432	9.278146
SumSLLTraits_Core	6.677	39258.375	46.321367
SumSLLConstTraits	23.578	11118.393	13.118708
SumSLLConstTraits_Core	7.616	34422.203	40.615117
SumSLLFast_Multiply	22.956	11419.574	13.474075
SumSLLFastTraits	22.998	11398.639	13.449373

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	315.493	830.901
SumSLL_Base	48.003	5460.948	6.572317
SumSLL_Base_Core	13.477	19451.827	23.410510
SumSLL_Base_Core_Element	55.875	4691.608	5.646407
SumSLL_Base_Core_Mov	57.925	4525.539	5.446541
SumSLL_Multiply	50.032	5239.493	6.305794
SumSLLTraits	49.835	5260.217	6.330735
SumSLLTraits_Core	13.699	19135.778	23.030141
SumSLLConstTraits	48.584	5395.652	6.493733
SumSLLConstTraits_Core	14.839	17666.075	21.261336
SumSLLFast_Multiply	45.981	5701.182	6.861441
SumSLLFastTraits	44.365	5908.762	7.111266

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	316.714	827.700
SumSLL_Base	102.482	2557.944	3.090424
SumSLL_Base_Core	31.964	8201.131	9.908337
SumSLL_Multiply	112.021	2340.136	2.827276
SumSLLTraits	100.863	2599.005	3.140033
SumSLLTraits_Core	36.305	7220.640	8.723740
SumSLLConstTraits	100.323	2613.001	3.156942
SumSLLConstTraits_Core	31.949	8204.984	9.912992
SumSLLFast_Multiply	90.805	2886.877	3.487830
SumSLLFastTraits	92.678	2828.540	3.417349

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	325.146	806.236
SumSLL_Base	568.567	461.061	0.571868
SumSLL_Base_Core	576.422	454.778	0.564076
SumSLLTraits	602.287	435.248	0.539851
SumSLLTraits_Core	586.561	446.917	0.554325
SumSLLConstTraits	492.416	532.362	0.660306
SumSLLConstTraits_Core	491.313	533.558	0.661789
SumSLLFastTraits	524.215	500.070	0.620252

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
```

#### .NET Core 3.1

```
```

#### .NET 5

```
```

#### .NET 6

```
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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	170.669	1535.981
SumSLLNetBcl	227.837	1150.575	0.749081
SumSLLNetBcl_Const	226.908	1155.290	0.752151
SumSLL_Base	14.232	18419.585	11.992065
SumSLL_Base_Core	14.627	17921.528	11.667805
SumSLL_Multiply	14.272	18367.535	11.958178
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	12.834	20426.480	13.298653
SumSLLTraits	13.471	19459.852	12.669330
SumSLLTraits_Core	6.974	37590.820	24.473491
SumSLLConstTraits	6.990	37503.071	24.416362
SumSLLConstTraits_Core	6.351	41274.658	26.871853
SumSLLFast_Multiply	8.074	32468.128	21.138364
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	6.888	38060.596	24.779339
SumSLLFastTraits	7.173	36545.433	23.792892

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	171.550	1528.093
SumSLLNetBcl	13.290	19724.768	12.908098
SumSLLNetBcl_Const	12.940	20257.886	13.256976
SumSLL_Base	14.236	18414.343	12.050542
SumSLL_Base_Core	14.425	18172.489	11.892270
SumSLL_Base_Core_Element	17.487	14990.509	9.809949
SumSLL_Base_Core_Mov	15.965	16420.284	10.745609
SumSLL_Multiply	19.001	13796.400	9.028511
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	16.049	16333.808	10.689018
SumSLLTraits	15.693	16704.967	10.931908
SumSLLTraits_Core	13.342	19647.494	12.857529
SumSLLConstTraits	12.332	21258.036	13.911485
SumSLLConstTraits_Core	12.399	21142.341	13.835773
SumSLLFast_Multiply	14.817	17691.719	11.577649
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	13.398	19566.390	12.804453
SumSLLFastTraits	13.532	19371.906	12.677181

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	159.615	1642.349
SumSLLNetBcl	28.441	9216.955	5.612056
SumSLLNetBcl_Const	23.925	10957.133	6.671622
SumSLL_Base	26.138	10029.216	6.106628
SumSLL_Base_Core	25.831	10148.521	6.179271
SumSLL_Multiply	36.711	7140.684	4.347848
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	29.641	8843.915	5.384918
SumSLLTraits	30.534	8585.315	5.227460
SumSLLTraits_Core	24.470	10712.658	6.522765
SumSLLConstTraits	26.591	9858.302	6.002562
SumSLLConstTraits_Core	24.256	10807.331	6.580410
SumSLLFast_Multiply	32.369	8098.679	4.931156
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	26.980	9716.079	5.915965
SumSLLFastTraits	26.512	9887.658	6.020436

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	110.834	2365.199
SumSLLNetBcl	62.372	4202.920	1.776984
SumSLLNetBcl_Const	54.735	4789.308	2.024907
SumSLL_Base	62.950	4164.298	1.760655
SumSLL_Base_Core	59.845	4380.395	1.852020
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	71.419	3670.508	1.551881
SumSLLTraits	69.163	3790.225	1.602498
SumSLLTraits_Core	61.396	4269.755	1.805242
SumSLLConstTraits	75.676	3464.046	1.464590
SumSLLConstTraits_Core	68.004	3854.826	1.629811
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	77.601	3378.098	1.428251
SumSLLFastTraits	66.077	3967.262	1.677348

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
```

#### .NET 5

```
```

#### .NET 6

```
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


[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	321.819	814.569
SumSLLNetBcl	26.529	9881.346	12.130759
SumSLLNetBcl_Const	26.617	9848.674	12.090649
SumSLL_Base	26.648	9837.342	12.076737
SumSLL_Base_Args	33.283	7876.192	9.669147
SumSLL_Base_Args_Element	36.576	7167.016	8.798533
SumSLL_Multiply	43.041	6090.591	7.477068
SumSLL_AdvSimd	101.162	2591.336	3.181234
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	101.353	2586.434	3.175216
SumSLLTraits_Args	33.160	7905.428	9.705038
SumSLLConstTraits	26.721	9810.412	12.043678
SumSLLFast_Multiply	35.835	7315.206	8.980456
SumSLLFast_AdvSimd	93.129	2814.858	3.455638
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	106.214	2468.065	3.029901

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

