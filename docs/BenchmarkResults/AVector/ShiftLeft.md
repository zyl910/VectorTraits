# Benchmark - ShiftLeft
([← Back](README.md))
See [Group](ShiftLeft_Group.md)

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9167.0
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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	372.899	702.989
SumSLL_Basic	41.019	6390.804	9.090897
SumSLL_Base_Core	8.493	30865.116	43.905524
SumSLL_Multiply	37.827	6930.163	9.858134
SumSLLTraits	38.330	6839.084	9.728573
SumSLLTraits_Core	9.521	27532.274	39.164567
SumSLLConstTraits	30.137	8698.413	12.373463
SumSLLConstTraits_Core	8.601	30479.708	43.357282
SumSLLFast_Multiply	28.182	9301.726	13.231673
SumSLLFastTraits	29.216	8972.513	12.763370

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	380.602	688.762
SumSLL_Basic	60.457	4336.013	6.295375
SumSLL_Base_Core	16.336	16046.658	23.297836
SumSLL_Base_Core_Element	62.717	4179.765	6.068521
SumSLL_Base_Core_Mov	66.761	3926.580	5.700926
SumSLL_Multiply	61.131	4288.238	6.226011
SumSLLTraits	61.024	4295.741	6.236905
SumSLLTraits_Core	16.598	15793.797	22.930712
SumSLLConstTraits	54.060	4849.121	7.040346
SumSLLConstTraits_Core	15.496	16917.224	24.561793
SumSLLFast_Multiply	56.701	4623.241	6.712396
SumSLLFastTraits	55.090	4758.473	6.908736

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	374.283	700.389
SumSLL_Basic	127.566	2054.961	2.934029
SumSLL_Base_Core	36.678	7147.102	10.204475
SumSLL_Multiply	119.288	2197.576	3.137651
SumSLLTraits	114.445	2290.570	3.270426
SumSLLTraits_Core	42.450	6175.384	8.817077
SumSLLConstTraits	105.884	2475.758	3.534834
SumSLLConstTraits_Core	35.724	7337.960	10.476979
SumSLLFast_Multiply	110.352	2375.530	3.391730
SumSLLFastTraits	114.396	2291.540	3.271811

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	381.512	687.118
SumSLL_Basic	692.157	378.735	0.551193
SumSLL_Base_Core	698.028	375.550	0.546558
SumSLLTraits	692.212	378.705	0.551149
SumSLLTraits_Core	730.824	358.696	0.522030
SumSLLConstTraits	602.244	435.279	0.633485
SumSLLConstTraits_Core	611.967	428.363	0.623420
SumSLLFastTraits	640.360	409.370	0.595778

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	370.477	707.586
SumSLL_Basic	39.573	6624.372	9.361935
SumSLL_Base_Core	8.671	30231.303	42.724576
SumSLL_Multiply	36.979	7088.927	10.018470
SumSLLTraits	37.312	7025.806	9.929263
SumSLLTraits_Core	9.771	26828.943	37.916170
SumSLLConstTraits	29.315	8942.308	12.637772
SumSLLConstTraits_Core	8.932	29350.310	41.479507
SumSLLFast_Multiply	30.215	8676.092	12.261541
SumSLLFastTraits	29.198	8978.044	12.688276

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	384.441	681.884
SumSLL_Basic	58.926	4448.691	6.524120
SumSLL_Base_Core	16.330	16052.598	23.541552
SumSLL_Base_Core_Element	64.655	4054.507	5.946040
SumSLL_Base_Core_Mov	66.708	3929.746	5.763075
SumSLL_Multiply	59.974	4370.965	6.410134
SumSLLTraits	59.176	4429.872	6.496523
SumSLLTraits_Core	15.780	16612.726	24.362994
SumSLLConstTraits	53.864	4866.811	7.137304
SumSLLConstTraits_Core	16.935	15479.262	22.700739
SumSLLFast_Multiply	53.902	4863.332	7.132203
SumSLLFastTraits	53.388	4910.179	7.200905

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	372.643	703.471
SumSLL_Basic	124.936	2098.220	2.982666
SumSLL_Base_Core	36.307	7220.161	10.263617
SumSLL_Multiply	116.616	2247.924	3.195472
SumSLLTraits	119.617	2191.532	3.115311
SumSLLTraits_Core	39.087	6706.747	9.533788
SumSLLConstTraits	101.881	2573.044	3.657639
SumSLLConstTraits_Core	36.520	7178.159	10.203910
SumSLLFast_Multiply	108.570	2414.508	3.432276
SumSLLFastTraits	103.115	2542.243	3.613855

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	381.869	686.477
SumSLL_Basic	673.475	389.241	0.567013
SumSLL_Base_Core	734.372	356.963	0.519993
SumSLLTraits	662.258	395.834	0.576616
SumSLLTraits_Core	670.001	391.259	0.569952
SumSLLConstTraits	549.245	477.280	0.695261
SumSLLConstTraits_Core	554.240	472.980	0.688996
SumSLLFastTraits	881.133	297.508	0.433384

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	287.125	912.995
SumSLL_Basic	20.632	12705.510	13.916292
SumSLL_Base_Core	7.597	34508.336	37.796836
SumSLL_Multiply	20.370	12869.416	14.095818
SumSLL_Avx2	14.443	18150.707	19.880393
SumSLLTraits	15.861	16527.720	18.102742
SumSLLTraits_Core	7.708	34009.630	37.250605
SumSLLConstTraits	12.708	20628.738	22.594571
SumSLLConstTraits_Core	7.793	33637.813	36.843356
SumSLLFast_Multiply	12.373	21185.978	23.204913
SumSLLFast_Avx2	12.037	21778.525	23.853928
SumSLLFastTraits	12.429	21090.553	23.100394

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	267.722	979.166
SumSLL_Basic	28.472	9206.985	9.402886
SumSLL_Base_Core	17.860	14677.376	14.989673
SumSLL_Base_Core_Element	31.831	8235.392	8.410620
SumSLL_Base_Core_Mov	29.637	8845.021	9.033221
SumSLL_Multiply	27.684	9469.301	9.670783
SumSLL_Avx2	18.445	14212.252	14.514652
SumSLLTraits	18.927	13850.121	14.144816
SumSLLTraits_Core	18.572	14115.234	14.415569
SumSLLConstTraits	18.346	14288.791	14.592820
SumSLLConstTraits_Core	15.505	16907.403	17.267149
SumSLLFast_Multiply	21.253	12334.222	12.596662
SumSLLFast_Avx2	17.730	14785.540	15.100138
SumSLLFastTraits	18.522	14152.985	14.454124

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	241.501	1085.480
SumSLL_Basic	52.096	5031.961	4.635703
SumSLL_Base_Core	35.916	7298.794	6.724026
SumSLL_Multiply	52.819	4963.079	4.572245
SumSLL_Avx2	42.543	6161.886	5.676647
SumSLLTraits	36.408	7200.099	6.633103
SumSLLTraits_Core	31.810	8240.907	7.591949
SumSLLConstTraits	37.108	7064.383	6.508074
SumSLLConstTraits_Core	30.620	8561.253	7.887068
SumSLLFast_Multiply	39.591	6621.280	6.099865
SumSLLFast_Avx2	36.182	7245.150	6.674606
SumSLLFastTraits	35.771	7328.439	6.751336

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	241.928	1083.563
SumSLL_Basic	642.912	407.745	0.376300
SumSLL_Base_Core	639.137	410.153	0.378522
SumSLL_Avx2	75.403	3476.589	3.208479
SumSLLTraits	76.968	3405.878	3.143222
SumSLLTraits_Core	63.344	4138.440	3.819290
SumSLLConstTraits	75.787	3458.963	3.192213
SumSLLConstTraits_Core	65.171	4022.378	3.712178
SumSLLFast_Avx2	73.516	3565.830	3.290838
SumSLLFastTraits	71.667	3657.788	3.375705

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	273.500	958.479
SumSLL_Basic	21.467	12211.638	12.740644
SumSLL_Base_Core	8.578	30559.773	31.883617
SumSLL_Multiply	21.877	11982.441	12.501518
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	16.396	15988.311	16.680922
SumSLLTraits	14.631	17917.063	18.693227
SumSLLTraits_Core	8.406	31183.779	32.534654
SumSLLConstTraits	10.394	25220.267	26.312804
SumSLLConstTraits_Core	8.662	30264.244	31.575285
SumSLLFast_Multiply	12.857	20389.800	21.273083
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	9.824	26684.523	27.840491
SumSLLFastTraits	9.658	27143.873	28.319741

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	269.879	971.341
SumSLL_Basic	27.993	9364.735	9.641042
SumSLL_Base_Core	15.166	17285.330	17.795336
SumSLL_Base_Core_Element	28.584	9170.905	9.441493
SumSLL_Base_Core_Mov	30.394	8624.911	8.879390
SumSLL_Multiply	27.548	9515.880	9.796647
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	19.003	13795.022	14.202045
SumSLLTraits	18.559	14125.173	14.541937
SumSLLTraits_Core	16.178	16203.782	16.681876
SumSLLConstTraits	18.836	13917.256	14.327886
SumSLLConstTraits_Core	17.523	14960.127	15.401527
SumSLLFast_Multiply	20.230	12958.415	13.340754
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	15.732	16663.593	17.155254
SumSLLFastTraits	17.142	15292.245	15.743444

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	233.167	1124.277
SumSLL_Basic	53.233	4924.451	4.380106
SumSLL_Base_Core	35.263	7433.905	6.612167
SumSLL_Multiply	52.788	4965.937	4.417006
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	37.460	6998.017	6.224462
SumSLLTraits	37.499	6990.621	6.217884
SumSLLTraits_Core	29.564	8866.891	7.886752
SumSLLConstTraits	33.952	7720.911	6.867448
SumSLLConstTraits_Core	29.895	8768.824	7.799526
SumSLLFast_Multiply	39.380	6656.762	5.920929
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	35.713	7340.360	6.528962
SumSLLFastTraits	33.777	7760.968	6.903077

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	240.371	1090.582
SumSLL_Basic	695.141	377.109	0.345787
SumSLL_Base_Core	687.681	381.200	0.349538
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	76.025	3448.141	3.161745
SumSLLTraits	76.867	3410.351	3.127093
SumSLLTraits_Core	59.211	4427.322	4.059597
SumSLLConstTraits	79.111	3313.622	3.038399
SumSLLConstTraits_Core	60.252	4350.820	3.989449
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	69.597	3766.616	3.453768
SumSLLFastTraits	71.147	3684.556	3.378524

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	222.455	1178.414
SumSLL_Basic	20.144	13013.599	11.043319
SumSLL_Base_Core	8.433	31084.857	26.378560
SumSLL_Multiply	19.740	13279.775	11.269196
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	15.012	17462.775	14.818883
SumSLLTraits	14.687	17849.148	15.146759
SumSLLTraits_Core	8.501	30838.282	26.169317
SumSLLConstTraits	7.821	33518.465	28.443716
SumSLLConstTraits_Core	8.788	29831.199	25.314708
SumSLLFast_Multiply	12.738	20579.514	17.463743
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	8.897	29464.590	25.003604
SumSLLFastTraits	9.219	28436.339	24.131032

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	237.534	1103.607
SumSLL_Basic	24.749	10592.035	9.597649
SumSLL_Base_Core	15.196	17251.387	15.631816
SumSLL_Base_Core_Element	26.185	10011.226	9.071365
SumSLL_Base_Core_Mov	26.951	9726.792	8.813634
SumSLL_Multiply	24.775	10580.946	9.587600
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	19.145	13692.307	12.406865
SumSLLTraits	17.966	14591.112	13.221289
SumSLLTraits_Core	16.482	15904.696	14.411553
SumSLLConstTraits	14.787	17727.500	16.063231
SumSLLConstTraits_Core	14.772	17746.234	16.080207
SumSLLFast_Multiply	17.676	14830.091	13.437832
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	18.818	13930.337	12.622549
SumSLLFastTraits	17.483	14994.523	13.586828

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	140.809	1861.695
SumSLL_Basic	52.766	4968.010	2.668542
SumSLL_Base_Core	36.062	7269.351	3.904695
SumSLL_Multiply	51.440	5096.160	2.737377
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	36.922	7099.849	3.813648
SumSLLTraits	37.627	6966.909	3.742240
SumSLLTraits_Core	29.857	8779.970	4.716117
SumSLLConstTraits	31.463	8331.775	4.475371
SumSLLConstTraits_Core	29.996	8739.208	4.694221
SumSLLFast_Multiply	42.240	6206.111	3.333581
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	36.240	7233.623	3.885504
SumSLLFastTraits	34.072	7693.780	4.132675

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	151.103	1734.873
SumSLL_Basic	628.820	416.882	0.240296
SumSLL_Base_Core	641.291	408.775	0.235623
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	79.959	3278.499	1.889763
SumSLLTraits	76.421	3430.241	1.977229
SumSLLTraits_Core	59.837	4380.972	2.525241
SumSLLConstTraits	62.695	4181.281	2.410137
SumSLLConstTraits_Core	64.281	4078.089	2.350655
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	71.089	3687.528	2.125532
SumSLLFastTraits	69.151	3790.882	2.185106

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	204.016	1284.920
SumSLLNetBcl	265.618	986.920	0.768079
SumSLLNetBcl_Const	264.400	991.468	0.771618
SumSLL_Basic	16.054	16328.607	12.707876
SumSLL_Base_Core	16.369	16014.270	12.463241
SumSLL_Multiply	16.617	15775.508	12.277423
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	13.051	20086.875	15.632781
SumSLLTraits	12.881	20350.851	15.838222
SumSLLTraits_Core	8.444	31044.717	24.160814
SumSLLConstTraits	8.544	30680.398	23.877279
SumSLLConstTraits_Core	8.103	32350.096	25.176737
SumSLLFast_Multiply	9.774	26821.848	20.874330
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	8.383	31272.106	24.337781
SumSLLFastTraits	8.358	31363.732	24.409090

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	202.650	1293.578
SumSLLNetBcl	16.800	15603.602	12.062356
SumSLLNetBcl_Const	15.684	16713.688	12.920507
SumSLL_Basic	16.987	15431.765	11.929518
SumSLL_Base_Core	16.477	15909.433	12.298779
SumSLL_Base_Core_Element	19.909	13167.032	10.178767
SumSLL_Base_Core_Mov	18.502	14168.092	10.952636
SumSLL_Multiply	21.803	12023.373	9.294662
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	19.413	13503.724	10.439046
SumSLLTraits	20.888	12550.094	9.701844
SumSLLTraits_Core	24.777	10580.334	8.179121
SumSLLConstTraits	18.699	14019.203	10.837537
SumSLLConstTraits_Core	19.534	13419.777	10.374151
SumSLLFast_Multiply	23.482	11163.718	8.630106
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	22.322	11743.655	9.078426
SumSLLFastTraits	20.276	12929.051	9.994796

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	136.478	1920.772
SumSLLNetBcl	35.028	7483.762	3.896225
SumSLLNetBcl_Const	35.299	7426.378	3.866350
SumSLL_Basic	36.905	7103.115	3.698052
SumSLL_Base_Core	35.318	7422.319	3.864237
SumSLL_Multiply	50.900	5150.216	2.681326
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	42.856	6116.803	3.184554
SumSLLTraits	38.972	6726.526	3.501990
SumSLLTraits_Core	33.436	7840.156	4.081773
SumSLLConstTraits	30.619	8561.389	4.457264
SumSLLConstTraits_Core	29.862	8778.513	4.570304
SumSLLFast_Multiply	37.386	7011.858	3.650541
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	33.531	7818.042	4.070259
SumSLLFastTraits	32.766	8000.584	4.165296

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	123.258	2126.795
SumSLLNetBcl	71.499	3666.401	1.723909
SumSLLNetBcl_Const	57.993	4520.260	2.125386
SumSLL_Basic	68.118	3848.398	1.809482
SumSLL_Base_Core	72.544	3613.605	1.699085
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	74.678	3510.332	1.650527
SumSLLTraits	78.593	3335.470	1.568308
SumSLLTraits_Core	62.911	4166.878	1.959229
SumSLLConstTraits	58.850	4454.434	2.094435
SumSLLConstTraits_Core	61.963	4230.642	1.989210
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	73.892	3547.678	1.668086
SumSLLFastTraits	73.706	3556.618	1.672290

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	434.225	603.706
SumSLL_Basic	46.428	5646.259	9.352664
SumSLL_Base_Core	20.079	13055.629	21.625808
SumSLL_Multiply	46.419	5647.400	9.354553
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	46.751	5607.205	9.287974
SumSLLTraits_Core	19.982	13118.993	21.730766
SumSLLConstTraits	23.387	11208.733	18.566543
SumSLLConstTraits_Core	18.294	14329.362	23.735664
SumSLLFast_Multiply	26.661	9832.305	16.286579
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.568	9866.766	16.343662

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	434.116	603.857
SumSLL_Basic	71.138	3685.026	6.102480
SumSLL_Base_Core	35.637	7356.050	12.181773
SumSLL_Base_Core_Element	70.034	3743.090	6.198635
SumSLL_Base_Core_Mov	70.946	3694.994	6.118987
SumSLL_Multiply	70.331	3727.278	6.172451
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	68.548	3824.256	6.333047
SumSLLTraits_Core	31.474	8328.793	13.792655
SumSLLConstTraits	37.273	7033.015	11.646819
SumSLLConstTraits_Core	33.442	7838.663	12.980990
SumSLLFast_Multiply	52.767	4967.933	8.227000
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	47.613	5505.719	9.117585

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	351.044	746.756
SumSLL_Basic	81.289	3224.821	4.318443
SumSLL_Base_Core	69.338	3780.691	5.062823
SumSLL_Multiply	91.692	2858.966	3.828516
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	81.338	3222.900	4.315870
SumSLLTraits_Core	63.929	4100.563	5.491171
SumSLLConstTraits	80.501	3256.415	4.360751
SumSLLConstTraits_Core	64.120	4088.318	5.474773
SumSLLFast_Multiply	75.430	3475.343	4.653923
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	80.570	3253.603	4.356986

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	353.843	740.847
SumSLL_Basic	539.269	486.110	0.656154
SumSLL_Base_Core	548.522	477.910	0.645085
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	538.934	486.412	0.656562
SumSLLTraits_Core	541.732	483.900	0.653171
SumSLLConstTraits	559.295	468.705	0.632660
SumSLLConstTraits_Core	560.575	467.634	0.631215
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	560.615	467.601	0.631170

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	429.381	610.516
SumSLL_Basic	46.216	5672.107	9.290676
SumSLL_Base_Core	16.610	15782.407	25.850927
SumSLL_Multiply	46.225	5671.097	9.289021
SumSLL_AdvSimd	19.826	13222.322	21.657614
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.806	13235.621	21.679398
SumSLLTraits_Core	16.500	15887.664	26.023334
SumSLLConstTraits	19.797	13241.436	21.688923
SumSLLConstTraits_Core	16.502	15885.257	26.019392
SumSLLFast_Multiply	26.346	9949.954	16.297611
SumSLLFast_AdvSimd	16.502	15885.321	26.019498
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	16.501	15886.532	26.021480

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	431.772	607.135
SumSLL_Basic	61.922	4233.448	6.972827
SumSLL_Base_Core	33.318	7867.964	12.959165
SumSLL_Base_Core_Element	61.157	4286.400	7.060043
SumSLL_Base_Core_Mov	66.124	3964.427	6.529727
SumSLL_Multiply	61.357	4272.425	7.037024
SumSLL_AdvSimd	39.915	6567.495	10.817188
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	39.951	6561.644	10.807552
SumSLLTraits_Core	33.214	7892.546	12.999653
SumSLLConstTraits	39.509	6635.069	10.928489
SumSLLConstTraits_Core	33.091	7921.999	13.048164
SumSLLFast_Multiply	47.435	5526.437	9.102483
SumSLLFast_AdvSimd	33.346	7861.443	12.948425
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	33.421	7843.736	12.919259

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	351.297	746.217
SumSLL_Basic	81.788	3205.170	4.295225
SumSLL_Base_Core	64.068	4091.668	5.483214
SumSLL_Multiply	81.617	3211.895	4.304236
SumSLL_AdvSimd	80.142	3270.976	4.383411
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	74.780	3505.532	4.697737
SumSLLTraits_Core	63.707	4114.834	5.514259
SumSLLConstTraits	68.153	3846.424	5.154564
SumSLLConstTraits_Core	67.754	3869.073	5.184916
SumSLLFast_Multiply	81.179	3229.223	4.327458
SumSLLFast_AdvSimd	80.306	3264.295	4.374458
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	79.989	3277.264	4.391837

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	352.996	742.626
SumSLL_Basic	542.406	483.299	0.650797
SumSLL_Base_Core	547.746	478.587	0.644452
SumSLL_AdvSimd	160.100	1637.381	2.204854
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	160.381	1634.506	2.200982
SumSLLTraits_Core	133.087	1969.717	2.652368
SumSLLConstTraits	134.143	1954.213	2.631490
SumSLLConstTraits_Core	133.005	1970.938	2.654012
SumSLLFast_AdvSimd	134.213	1953.192	2.630116
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	159.386	1644.716	2.214730

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	389.200	673.546
SumSLL_Basic	36.869	7110.113	10.556243
SumSLL_Base_Core	16.615	15777.964	23.425228
SumSLL_Multiply	37.208	7045.315	10.460038
SumSLL_AdvSimd	19.820	13226.185	19.636653
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.788	13247.338	19.668059
SumSLLTraits_Core	15.417	17003.282	25.244434
SumSLLConstTraits	15.425	16994.514	25.231415
SumSLLConstTraits_Core	15.428	16991.730	25.227282
SumSLLFast_Multiply	23.563	11125.190	16.517348
SumSLLFast_AdvSimd	16.492	15895.407	23.599594
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	16.500	15887.817	23.588325

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	431.793	607.105
SumSLL_Basic	46.634	5621.349	9.259265
SumSLL_Base_Core	31.458	8333.205	13.726128
SumSLL_Base_Core_Element	52.945	4951.286	8.155563
SumSLL_Base_Core_Mov	53.278	4920.346	8.104601
SumSLL_Multiply	46.701	5613.295	9.245999
SumSLL_AdvSimd	40.029	6548.788	10.786907
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	40.097	6537.762	10.768745
SumSLLTraits_Core	33.305	7870.912	12.964657
SumSLLConstTraits	33.214	7892.477	13.000178
SumSLLConstTraits_Core	33.238	7886.939	12.991056
SumSLLFast_Multiply	40.582	6459.647	10.640076
SumSLLFast_AdvSimd	33.203	7895.085	13.004474
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	33.326	7866.037	12.956628

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	350.273	748.400
SumSLL_Basic	87.644	2991.012	3.996543
SumSLL_Base_Core	68.038	3852.914	5.148202
SumSLL_Multiply	87.670	2990.129	3.995362
SumSLL_AdvSimd	74.812	3504.041	4.682044
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	80.678	3249.259	4.341607
SumSLLTraits_Core	67.733	3870.271	5.171394
SumSLLConstTraits	67.803	3866.282	5.166063
SumSLLConstTraits_Core	63.853	4105.409	5.485582
SumSLLFast_Multiply	81.810	3204.317	4.281557
SumSLLFast_AdvSimd	64.004	4095.751	5.472677
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	63.849	4105.693	5.485960

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	353.827	740.883
SumSLL_Basic	541.742	483.891	0.653128
SumSLL_Base_Core	541.922	483.730	0.652910
SumSLL_AdvSimd	160.097	1637.409	2.210078
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	160.230	1636.045	2.208238
SumSLLTraits_Core	133.049	1970.279	2.659368
SumSLLConstTraits	133.120	1969.238	2.657962
SumSLLConstTraits_Core	132.925	1972.121	2.661853
SumSLLFast_AdvSimd	124.999	2097.162	2.830626
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	133.081	1969.802	2.658723

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	295.552	886.963
SumSLLNetBcl	13.384	19586.570	22.082746
SumSLLNetBcl_Const	13.386	19583.990	22.079836
SumSLL_Basic	35.423	7400.491	8.343634
SumSLL_Base_Core	35.476	7389.258	8.330969
SumSLL_Multiply	35.426	7399.725	8.342770
SumSLL_AdvSimd	19.809	13233.450	14.919964
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.818	13227.773	14.913563
SumSLLTraits_Core	13.383	19588.388	22.084796
SumSLLConstTraits	13.471	19460.477	21.940583
SumSLLConstTraits_Core	13.480	19447.305	21.925732
SumSLLFast_Multiply	22.936	11429.354	12.885948
SumSLLFast_AdvSimd	13.365	19614.806	22.114580
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	13.406	19553.951	22.045970

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	318.968	821.851
SumSLLNetBcl	26.532	9880.161	12.021835
SumSLLNetBcl_Const	26.521	9884.262	12.026825
SumSLL_Basic	26.475	9901.496	12.047794
SumSLL_Base_Core	26.529	9881.348	12.023279
SumSLL_Base_Core_Element	36.376	7206.607	8.768747
SumSLL_Base_Core_Mov	33.079	7924.840	9.642669
SumSLL_Multiply	42.799	6124.986	7.452669
SumSLL_AdvSimd	39.596	6620.389	8.055459
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	26.519	9885.127	12.027878
SumSLLTraits_Core	26.529	9881.255	12.023167
SumSLLConstTraits	26.611	9850.836	11.986153
SumSLLConstTraits_Core	26.585	9860.506	11.997920
SumSLLFast_Multiply	37.122	7061.733	8.592470
SumSLLFast_AdvSimd	26.580	9862.607	12.000476
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.607	9852.284	11.987915

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	186.322	1406.943
SumSLLNetBcl	53.801	4872.472	3.463162
SumSLLNetBcl_Const	53.944	4859.541	3.453971
SumSLL_Basic	53.911	4862.536	3.456099
SumSLL_Base_Core	53.875	4865.826	3.458438
SumSLL_Multiply	79.652	3291.103	2.339187
SumSLL_AdvSimd	66.648	3933.287	2.795626
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	53.818	4870.908	3.462050
SumSLLTraits_Core	54.320	4825.955	3.430099
SumSLLConstTraits	54.241	4832.987	3.435097
SumSLLConstTraits_Core	54.130	4842.866	3.442119
SumSLLFast_Multiply	77.251	3393.409	2.411902
SumSLLFast_AdvSimd	54.121	4843.690	3.442705
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	53.928	4860.993	3.455003

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	191.007	1372.433
SumSLLNetBcl	107.093	2447.827	1.783567
SumSLLNetBcl_Const	106.313	2465.779	1.796648
SumSLL_Basic	106.455	2462.489	1.794251
SumSLL_Base_Core	106.427	2463.136	1.794722
SumSLL_AdvSimd	132.352	1980.659	1.443173
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	132.358	1980.563	1.443103
SumSLLTraits_Core	106.246	2467.329	1.797777
SumSLLConstTraits	106.464	2462.272	1.794092
SumSLLConstTraits_Core	106.262	2466.961	1.797509
SumSLLFast_AdvSimd	106.346	2465.009	1.796087
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	106.515	2461.104	1.793242

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

