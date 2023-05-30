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
SumSLLScalar	307.583	852.271
SumSLL_Base	29.992	8740.332	10.255347
SumSLL_Base_Core	29.866	8777.222	10.298631
SumSLL_Multiply	29.688	8830.088	10.360660
SumSLLTraits	30.063	8719.914	10.231390
SumSLLTraits_Core	31.710	8267.027	9.700001
SumSLLConstTraits	24.108	10873.954	12.758803
SumSLLFast_Multiply	25.166	10416.437	12.221982
SumSLLFastTraits	25.225	10392.401	12.193779

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	314.305	834.043
SumSLL_Base	49.796	5264.387	6.311885
SumSLL_Base_Core	47.604	5506.784	6.602515
SumSLL_Base_Core_Element	53.455	4904.007	5.879799
SumSLL_Base_Core_Mov	53.556	4894.724	5.868668
SumSLL_Multiply	47.567	5510.990	6.607558
SumSLLTraits	47.745	5490.507	6.582999
SumSLLTraits_Core	50.912	5148.955	6.173485
SumSLLConstTraits	44.750	5857.921	7.023521
SumSLLFast_Multiply	42.483	6170.601	7.398417
SumSLLFastTraits	45.355	5779.886	6.929958

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	316.368	828.604
SumSLL_Base	97.633	2684.980	3.240366
SumSLL_Base_Core	98.687	2656.326	3.205785
SumSLL_Multiply	92.080	2846.917	3.435799
SumSLLTraits	93.024	2818.026	3.400932
SumSLLTraits_Core	96.453	2717.841	3.280024
SumSLLConstTraits	82.972	3159.440	3.812967
SumSLLFast_Multiply	82.376	3182.279	3.840530
SumSLLFastTraits	83.670	3133.061	3.781132

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	318.684	822.582
SumSLL_Base	577.993	453.542	0.551364
SumSLL_Base_Core	606.294	432.371	0.525627
SumSLLTraits	586.267	447.141	0.543582
SumSLLTraits_Core	577.892	453.621	0.551460
SumSLLConstTraits	526.734	497.678	0.605019
SumSLLFastTraits	544.674	481.286	0.585092

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
```

#### .NET Core 2.1

```
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
SumSLLScalar	169.050	1550.687
SumSLLNetBcl	225.146	1164.330	0.750848
SumSLLNetBcl_Const	224.062	1169.963	0.754480
SumSLL_Base	13.450	19490.738	12.569098
SumSLL_Base_Core	13.501	19416.776	12.521402
SumSLL_Multiply	13.944	18799.100	12.123078
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	13.474	19455.867	12.546611
SumSLLTraits	12.654	20716.622	13.359641
SumSLLTraits_Core	6.837	38340.143	24.724617
SumSLLConstTraits	7.044	37217.531	24.000672
SumSLLFast_Multiply	10.341	25348.758	16.346792
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	6.667	39317.140	25.354658
SumSLLFastTraits	6.733	38935.933	25.108827

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	170.142	1540.740
SumSLLNetBcl	13.496	19424.068	12.606977
SumSLLNetBcl_Const	12.655	20714.056	13.444229
SumSLL_Base	14.365	18248.920	11.844260
SumSLL_Base_Core	14.341	18279.477	11.864093
SumSLL_Base_Core_Element	16.540	15848.878	10.286539
SumSLL_Base_Core_Mov	15.460	16956.509	11.005435
SumSLL_Multiply	17.963	14593.356	9.471657
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	15.427	16993.036	11.029143
SumSLLTraits	14.921	17569.033	11.402986
SumSLLTraits_Core	12.925	20281.420	13.163432
SumSLLConstTraits	12.157	21562.934	13.995184
SumSLLFast_Multiply	14.890	17605.800	11.426850
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	13.107	20000.349	12.981006
SumSLLFastTraits	12.995	20172.505	13.092741

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	98.974	2648.609
SumSLLNetBcl	25.059	10461.042	3.949636
SumSLLNetBcl_Const	22.666	11565.716	4.366713
SumSLL_Base	26.653	9835.329	3.713394
SumSLL_Base_Core	27.602	9497.340	3.585784
SumSLL_Multiply	36.258	7230.017	2.729741
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	31.327	8368.100	3.159432
SumSLLTraits	29.773	8804.865	3.324335
SumSLLTraits_Core	23.036	11379.762	4.296505
SumSLLConstTraits	24.101	10877.097	4.106720
SumSLLFast_Multiply	36.589	7164.622	2.705051
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	26.679	9825.996	3.709870
SumSLLFastTraits	25.890	10125.343	3.822891

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	101.473	2583.388
SumSLLNetBcl	55.750	4702.109	1.820133
SumSLLNetBcl_Const	49.267	5320.844	2.059638
SumSLL_Base	57.465	4561.818	1.765828
SumSLL_Base_Core	57.249	4578.999	1.772478
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	64.409	4069.985	1.575445
SumSLLTraits	64.399	4070.642	1.575699
SumSLLTraits_Core	49.191	5329.057	2.062817
SumSLLConstTraits	49.550	5290.533	2.047905
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	56.875	4609.115	1.784136
SumSLLFastTraits	57.537	4556.094	1.763612

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

