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
SumSLLScalar	430.784	608.527
SumSLL_Base	50.039	5238.835	8.609041
SumSLL_Base_Core	9.106	28787.358	47.306614
SumSLL_Multiply	42.187	6213.845	10.211287
SumSLLTraits	37.169	7052.690	11.589771
SumSLLTraits_Core	7.962	32924.090	54.104556
SumSLLConstTraits	26.964	9721.913	15.976137
SumSLLConstTraits_Core	8.968	29230.154	48.034266
SumSLLFast_Multiply	24.462	10716.316	17.610252
SumSLLFastTraits	24.959	10502.998	17.259704

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	332.314	788.844
SumSLL_Base	54.976	4768.343	6.044720
SumSLL_Base_Core	14.127	18556.219	23.523299
SumSLL_Base_Core_Element	54.618	4799.554	6.084286
SumSLL_Base_Core_Mov	55.775	4699.988	5.958069
SumSLL_Multiply	51.453	5094.790	6.458551
SumSLLTraits	52.967	4949.226	6.274022
SumSLLTraits_Core	14.180	18486.944	23.435482
SumSLLConstTraits	48.019	5459.134	6.920421
SumSLLConstTraits_Core	13.469	19462.218	24.671814
SumSLLFast_Multiply	48.155	5443.719	6.900880
SumSLLFastTraits	45.855	5716.779	7.247031

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	323.849	809.465
SumSLL_Base	104.100	2518.183	3.110923
SumSLL_Base_Core	30.211	8677.162	10.719629
SumSLL_Multiply	104.224	2515.195	3.107232
SumSLLTraits	104.130	2517.480	3.110055
SumSLLTraits_Core	33.154	7906.848	9.767996
SumSLLConstTraits	80.057	3274.477	4.045238
SumSLLConstTraits_Core	30.379	8629.134	10.660297
SumSLLFast_Multiply	89.024	2944.630	3.637749
SumSLLFastTraits	92.468	2834.964	3.502270

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	328.407	798.230
SumSLL_Base	568.111	461.431	0.578068
SumSLL_Base_Core	597.501	438.734	0.549634
SumSLLTraits	565.323	463.706	0.580918
SumSLLTraits_Core	565.894	463.239	0.580332
SumSLLConstTraits	490.481	534.463	0.669561
SumSLLConstTraits_Core	489.046	536.031	0.671524
SumSLLFastTraits	531.807	492.931	0.617530

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
SumSLLScalar	309.985	845.666
SumSLL_Base	34.863	7519.195	8.891444
SumSLL_Base_Core	6.684	39217.139	46.374244
SumSLL_Multiply	33.919	7728.507	9.138955
SumSLLTraits	34.403	7619.821	9.010433
SumSLLTraits_Core	7.008	37404.448	44.230737
SumSLLConstTraits	24.612	10651.236	12.595081
SumSLLConstTraits_Core	8.069	32487.018	38.415879
SumSLLFast_Multiply	23.166	11316.050	13.381223
SumSLLFastTraits	23.284	11258.499	13.313168

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	315.309	831.388
SumSLL_Base	48.738	5378.595	6.469414
SumSLL_Base_Core	12.658	20710.562	24.910818
SumSLL_Base_Core_Element	54.970	4768.884	5.736049
SumSLL_Base_Core_Mov	56.003	4680.910	5.630234
SumSLL_Multiply	52.975	4948.423	5.952000
SumSLLTraits	51.167	5123.305	6.162349
SumSLLTraits_Core	13.686	19154.325	23.038965
SumSLLConstTraits	44.756	5857.152	7.045026
SumSLLConstTraits_Core	14.004	18719.634	22.516115
SumSLLFast_Multiply	47.038	5572.996	6.703241
SumSLLFastTraits	46.735	5609.164	6.746744

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	328.781	797.321
SumSLL_Base	106.090	2470.949	3.099063
SumSLL_Base_Core	31.547	8309.729	10.422058
SumSLL_Multiply	99.725	2628.665	3.296870
SumSLLTraits	99.315	2639.512	3.310475
SumSLLTraits_Core	30.768	8520.035	10.685823
SumSLLConstTraits	92.515	2833.541	3.553825
SumSLLConstTraits_Core	33.244	7885.350	9.889802
SumSLLFast_Multiply	90.255	2904.493	3.642814
SumSLLFastTraits	91.763	2856.755	3.582940

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	325.495	805.369
SumSLL_Base	590.817	443.698	0.550925
SumSLL_Base_Core	597.971	438.390	0.544333
SumSLLTraits	588.985	445.078	0.552638
SumSLLTraits_Core	562.738	465.837	0.578414
SumSLLConstTraits	488.275	536.878	0.666623
SumSLLConstTraits_Core	485.381	540.079	0.670598
SumSLLFastTraits	528.031	496.456	0.616433

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	240.966	1087.888
SumSLL_Base	19.361	13539.759	12.445914
SumSLL_Base_Core	6.247	41965.307	38.575028
SumSLL_Multiply	19.802	13238.233	12.168747
SumSLL_Avx2	14.377	18233.938	16.760861
SumSLLTraits	14.446	18146.133	16.680149
SumSLLTraits_Core	7.403	35411.731	32.550900
SumSLLConstTraits	11.241	23320.937	21.436893
SumSLLConstTraits_Core	6.518	40220.438	36.971123
SumSLLFast_Multiply	11.251	23298.649	21.416406
SumSLLFast_Avx2	10.473	25029.443	23.007373
SumSLLFastTraits	10.679	24548.515	22.565298

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	227.399	1152.796
SumSLL_Base	24.016	10915.508	9.468728
SumSLL_Base_Core	14.546	18021.387	15.632769
SumSLL_Base_Core_Element	26.452	9910.059	8.596544
SumSLL_Base_Core_Mov	26.134	10030.642	8.701145
SumSLL_Multiply	24.253	10808.887	9.376238
SumSLL_Avx2	16.523	15865.345	13.762496
SumSLLTraits	16.480	15907.088	13.798706
SumSLLTraits_Core	13.719	19107.888	16.575261
SumSLLConstTraits	15.940	16445.249	14.265537
SumSLLConstTraits_Core	14.856	17645.864	15.307018
SumSLLFast_Multiply	18.259	14356.763	12.453867
SumSLLFast_Avx2	15.030	17441.704	15.129919
SumSLLFastTraits	16.304	16078.972	13.947808

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	211.907	1237.069
SumSLL_Base	46.410	5648.392	4.565946
SumSLL_Base_Core	32.103	8165.823	6.600943
SumSLL_Multiply	46.631	5621.619	4.544304
SumSLL_Avx2	32.991	7945.817	6.423098
SumSLLTraits	32.490	8068.411	6.522198
SumSLLTraits_Core	26.963	9722.438	7.859251
SumSLLConstTraits	32.710	8014.096	6.478292
SumSLLConstTraits_Core	27.714	9459.045	7.646334
SumSLLFast_Multiply	35.002	7489.353	6.054110
SumSLLFast_Avx2	30.826	8503.927	6.874253
SumSLLFastTraits	30.145	8696.035	7.029546

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	213.633	1227.075
SumSLL_Base	558.788	469.129	0.382315
SumSLL_Base_Core	552.077	474.832	0.386963
SumSLL_Avx2	66.236	3957.699	3.225310
SumSLLTraits	77.129	3398.794	2.769833
SumSLLTraits_Core	54.569	4803.934	3.914946
SumSLLConstTraits	67.625	3876.425	3.159077
SumSLLConstTraits_Core	55.135	4754.545	3.874697
SumSLLFast_Avx2	65.176	4022.123	3.277812
SumSLLFastTraits	61.367	4271.717	3.481218

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	241.172	1086.961
SumSLL_Base	19.517	13431.606	12.357029
SumSLL_Base_Core	6.744	38869.564	35.759858
SumSLL_Multiply	19.286	13592.747	12.505278
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	14.228	18425.067	16.950995
SumSLLTraits	14.149	18527.322	17.045069
SumSLLTraits_Core	7.139	36720.345	33.782585
SumSLLConstTraits	8.374	31304.742	28.800250
SumSLLConstTraits_Core	7.280	36007.071	33.126376
SumSLLFast_Multiply	10.714	24467.007	22.509558
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	8.264	31721.144	29.183338
SumSLLFastTraits	8.259	31740.296	29.200958

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	230.211	1138.713
SumSLL_Base	23.871	10981.470	9.643752
SumSLL_Base_Core	12.998	20168.185	17.711378
SumSLL_Base_Core_Element	24.327	10776.051	9.463356
SumSLL_Base_Core_Mov	26.588	9859.583	8.658529
SumSLL_Multiply	23.995	10925.164	9.594305
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	17.566	14923.396	13.105488
SumSLLTraits	18.457	14203.113	12.472947
SumSLLTraits_Core	14.466	18121.377	15.913904
SumSLLConstTraits	15.764	16629.214	14.603510
SumSLLConstTraits_Core	17.932	14618.766	12.837967
SumSLLFast_Multiply	20.764	12624.897	11.086983
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	15.341	17088.104	15.006500
SumSLLFastTraits	15.330	17099.815	15.016784

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	216.296	1211.966
SumSLL_Base	49.676	5277.124	4.354184
SumSLL_Base_Core	30.910	8480.747	6.997511
SumSLL_Multiply	46.898	5589.639	4.612042
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	32.964	7952.425	6.561590
SumSLLTraits	33.435	7840.509	6.469248
SumSLLTraits_Core	25.460	10296.430	8.495641
SumSLLConstTraits	28.869	9080.604	7.492457
SumSLLConstTraits_Core	28.525	9190.098	7.582800
SumSLLFast_Multiply	34.435	7612.690	6.281273
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	28.073	9338.049	7.704876
SumSLLFastTraits	33.062	7928.938	6.542210

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	210.924	1242.834
SumSLL_Base	586.870	446.681	0.359405
SumSLL_Base_Core	574.653	456.178	0.367046
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	67.409	3888.873	3.129037
SumSLLTraits	69.057	3796.045	3.054346
SumSLLTraits_Core	53.326	4915.842	3.955349
SumSLLConstTraits	71.257	3678.832	2.960035
SumSLLConstTraits_Core	59.693	4391.541	3.533489
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	62.869	4169.674	3.354973
SumSLLFastTraits	66.292	3954.382	3.181746

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	196.075	1336.955
SumSLL_Base	17.877	14663.997	10.968209
SumSLL_Base_Core	7.002	37438.882	28.003107
SumSLL_Multiply	18.986	13806.871	10.327105
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	15.533	16876.171	12.622846
SumSLLTraits	14.387	18221.224	13.628903
SumSLLTraits_Core	6.977	37575.089	28.104985
SumSLLConstTraits	6.968	37623.788	28.141410
SumSLLConstTraits_Core	7.086	36995.256	27.671288
SumSLLFast_Multiply	10.533	24887.788	18.615283
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.186	36479.940	27.285849
SumSLLFastTraits	7.310	35860.415	26.822464

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	195.061	1343.909
SumSLL_Base	22.541	11629.847	8.653745
SumSLL_Base_Core	14.675	17863.704	13.292345
SumSLL_Base_Core_Element	22.969	11413.084	8.492452
SumSLL_Base_Core_Mov	24.018	10914.636	8.121558
SumSLL_Multiply	21.522	12180.226	9.063281
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	15.896	16491.161	12.271039
SumSLLTraits	15.926	16460.562	12.248270
SumSLLTraits_Core	13.522	19386.292	14.425299
SumSLLConstTraits	13.662	19187.357	14.277272
SumSLLConstTraits_Core	12.802	20476.171	15.236276
SumSLLFast_Multiply	15.223	17219.828	12.813239
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	13.305	19702.397	14.660513
SumSLLFastTraits	14.917	17572.965	13.076007

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	126.649	2069.853
SumSLL_Base	47.857	5477.626	2.646384
SumSLL_Base_Core	32.953	7954.988	3.843262
SumSLL_Multiply	56.458	4643.128	2.243216
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	56.929	4604.778	2.224689
SumSLLTraits	48.233	5434.901	2.625743
SumSLLTraits_Core	38.860	6745.862	3.259102
SumSLLConstTraits	27.116	9667.497	4.670620
SumSLLConstTraits_Core	27.365	9579.479	4.628097
SumSLLFast_Multiply	35.816	7319.087	3.536042
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	30.299	8651.773	4.179898
SumSLLFastTraits	35.567	7370.478	3.560871

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	142.880	1834.713
SumSLL_Base	594.915	440.641	0.240169
SumSLL_Base_Core	571.314	458.844	0.250090
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	69.140	3791.485	2.066527
SumSLLTraits	82.102	3192.922	1.740284
SumSLLTraits_Core	66.351	3950.854	2.153391
SumSLLConstTraits	86.759	3021.524	1.646865
SumSLLConstTraits_Core	82.185	3189.686	1.738520
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	79.196	3310.065	1.804132
SumSLLFastTraits	71.395	3671.750	2.001267

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	172.905	1516.120
SumSLLNetBcl	229.779	1140.850	0.752480
SumSLLNetBcl_Const	230.237	1138.585	0.750986
SumSLL_Base	14.567	17995.462	11.869417
SumSLL_Base_Core	14.261	18381.409	12.123980
SumSLL_Multiply	14.199	18461.514	12.176815
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	13.403	19559.243	12.900854
SumSLLTraits	13.074	20051.145	13.225301
SumSLLTraits_Core	6.955	37690.917	24.860113
SumSLLConstTraits	6.999	37456.235	24.705322
SumSLLConstTraits_Core	6.514	40241.337	26.542315
SumSLLFast_Multiply	7.789	33653.719	22.197265
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.223	36290.701	23.936561
SumSLLFastTraits	7.259	36113.165	23.819462

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	170.880	1534.085
SumSLLNetBcl	14.299	18333.553	11.950805
SumSLLNetBcl_Const	12.425	21098.350	13.753050
SumSLL_Base	13.989	18738.895	12.215029
SumSLL_Base_Core	14.249	18397.967	11.992793
SumSLL_Base_Core_Element	17.194	15245.969	9.938150
SumSLL_Base_Core_Mov	15.579	16826.695	10.968553
SumSLL_Multiply	18.497	14172.039	9.238104
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	16.049	16333.645	10.647156
SumSLLTraits	15.795	16596.677	10.818615
SumSLLTraits_Core	13.396	19568.750	12.755974
SumSLLConstTraits	12.410	21124.172	13.769882
SumSLLConstTraits_Core	12.348	21229.410	13.838482
SumSLLFast_Multiply	15.047	17421.918	11.356552
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	13.420	19534.252	12.733486
SumSLLFastTraits	13.397	19567.262	12.755003

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	159.669	1641.800
SumSLLNetBcl	25.387	10326.057	6.289475
SumSLLNetBcl_Const	24.012	10917.113	6.649480
SumSLL_Base	26.282	9974.238	6.075186
SumSLL_Base_Core	28.211	9292.198	5.659764
SumSLL_Multiply	38.362	6833.467	4.162181
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	31.508	8320.026	5.067626
SumSLLTraits	30.821	8505.305	5.180477
SumSLLTraits_Core	24.961	10501.946	6.396607
SumSLLConstTraits	26.959	9723.702	5.922588
SumSLLConstTraits_Core	26.560	9869.977	6.011682
SumSLLFast_Multiply	32.573	8047.825	4.901831
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	28.348	9247.357	5.632452
SumSLLFastTraits	28.436	9218.867	5.615099

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	162.718	1611.029
SumSLLNetBcl	59.214	4427.098	2.747993
SumSLLNetBcl_Const	49.791	5264.870	3.268016
SumSLL_Base	60.266	4349.762	2.699989
SumSLL_Base_Core	58.495	4481.441	2.781725
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	67.001	3912.523	2.428586
SumSLLTraits	67.084	3907.670	2.425574
SumSLLTraits_Core	58.871	4452.843	2.763974
SumSLLConstTraits	52.827	4962.331	3.080224
SumSLLConstTraits_Core	55.200	4749.017	2.947816
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	63.116	4153.395	2.578100
SumSLLFastTraits	63.000	4161.015	2.582830

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	429.137	610.863
SumSLL_Base	54.902	4774.732	7.816370
SumSLL_Base_Core	18.250	14364.000	23.514271
SumSLL_Multiply	54.894	4775.469	7.817577
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	54.941	4771.370	7.810867
SumSLLTraits_Core	18.247	14366.763	23.518795
SumSLLConstTraits	26.342	9951.667	16.291159
SumSLLConstTraits_Core	19.818	13227.483	21.653762
SumSLLFast_Multiply	26.334	9954.744	16.296196
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.354	9946.897	16.283350

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	432.090	606.688
SumSLL_Base	61.897	4235.151	6.980770
SumSLL_Base_Core	31.397	8349.374	13.762216
SumSLL_Base_Core_Element	62.032	4225.954	6.965611
SumSLL_Base_Core_Mov	62.479	4195.692	6.915730
SumSLL_Multiply	62.109	4220.698	6.956948
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	62.306	4207.387	6.935008
SumSLLTraits_Core	33.485	7828.797	12.904153
SumSLLConstTraits	39.984	6556.199	10.806538
SumSLLConstTraits_Core	31.682	8274.176	13.638268
SumSLLFast_Multiply	47.671	5499.035	9.064021
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	52.815	4963.440	8.181205

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	350.031	748.917
SumSLL_Base	80.793	3244.628	4.332425
SumSLL_Base_Core	67.246	3898.279	5.205219
SumSLL_Multiply	80.894	3240.586	4.327027
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	80.794	3244.608	4.332397
SumSLLTraits_Core	63.348	4138.176	5.525545
SumSLLConstTraits	80.650	3250.374	4.340097
SumSLLConstTraits_Core	63.291	4141.892	5.530507
SumSLLFast_Multiply	74.793	3504.933	4.679999
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	80.675	3249.385	4.338776

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	354.047	740.421
SumSLL_Base	539.364	486.024	0.656415
SumSLL_Base_Core	1285.583	203.911	0.275398
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	539.026	486.329	0.656828
SumSLLTraits_Core	541.766	483.869	0.653505
SumSLLConstTraits	544.667	481.293	0.650025
SumSLLConstTraits_Core	1263.047	207.549	0.280312
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	542.747	482.994	0.652324

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	437.053	599.799
SumSLL_Base	55.919	4687.955	7.815870
SumSLL_Base_Core	16.897	15513.972	25.865266
SumSLL_Multiply	55.917	4688.088	7.816092
SumSLL_AdvSimd	20.131	13021.886	21.710400
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	20.184	12987.836	21.653632
SumSLLTraits_Core	16.865	15543.293	25.914150
SumSLLConstTraits	20.070	13061.278	21.776076
SumSLLConstTraits_Core	16.860	15548.462	25.922768
SumSLLFast_Multiply	26.748	9800.626	16.339839
SumSLLFast_AdvSimd	16.591	15800.657	26.343234
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	16.627	15765.879	26.285251

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	436.437	600.645
SumSLL_Base	63.572	4123.563	6.865222
SumSLL_Base_Core	31.840	8233.071	13.707042
SumSLL_Base_Core_Element	62.548	4191.070	6.977612
SumSLL_Base_Core_Mov	64.254	4079.792	6.792348
SumSLL_Multiply	63.961	4098.510	6.823512
SumSLL_AdvSimd	40.761	6431.296	10.707312
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	40.173	6525.381	10.863950
SumSLLTraits_Core	31.295	8376.673	13.946123
SumSLLConstTraits	34.020	7705.485	12.828677
SumSLLConstTraits_Core	31.848	8231.001	13.703597
SumSLLFast_Multiply	53.634	4887.630	8.137298
SumSLLFast_AdvSimd	34.127	7681.346	12.788489
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	34.190	7667.336	12.765165

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	359.031	730.143
SumSLL_Base	83.518	3138.755	4.298821
SumSLL_Base_Core	65.630	3994.256	5.470510
SumSLL_Multiply	81.180	3229.158	4.422636
SumSLL_AdvSimd	82.383	3182.017	4.358072
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	81.121	3231.508	4.425854
SumSLLTraits_Core	64.565	4060.181	5.560800
SumSLLConstTraits	69.485	3772.647	5.166996
SumSLLConstTraits_Core	68.625	3819.926	5.231749
SumSLLFast_Multiply	83.091	3154.905	4.320939
SumSLLFast_AdvSimd	70.027	3743.489	5.127061
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	69.291	3783.260	5.181530

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	362.218	723.719
SumSLL_Base	562.926	465.681	0.643456
SumSLL_Base_Core	559.746	468.327	0.647111
SumSLL_AdvSimd	181.631	1443.276	1.994249
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	182.347	1437.612	1.986424
SumSLLTraits_Core	136.898	1914.880	2.645889
SumSLLConstTraits	136.841	1915.689	2.647008
SumSLLConstTraits_Core	135.553	1933.882	2.672145
SumSLLFast_AdvSimd	137.127	1911.689	2.641481
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	137.394	1907.979	2.636354

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	421.190	622.389
SumSLL_Base	47.554	5512.589	8.857140
SumSLL_Base_Core	17.462	15011.845	24.119707
SumSLL_Multiply	47.283	5544.153	8.907855
SumSLL_AdvSimd	20.529	12769.623	20.517103
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	20.850	12572.663	20.200645
SumSLLTraits_Core	17.374	15088.497	24.242864
SumSLLConstTraits	17.236	15209.184	24.436773
SumSLLConstTraits_Core	17.092	15336.977	24.642100
SumSLLFast_Multiply	24.686	10618.987	17.061651
SumSLLFast_AdvSimd	20.629	12707.839	20.417833
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	20.779	12615.799	20.269952

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	453.655	577.849
SumSLL_Base	49.098	5339.172	9.239735
SumSLL_Base_Core	35.528	7378.550	12.768992
SumSLL_Base_Core_Element	51.359	5104.110	8.832947
SumSLL_Base_Core_Mov	54.134	4842.528	8.380265
SumSLL_Multiply	49.093	5339.711	9.240667
SumSLL_AdvSimd	41.658	6292.828	10.890089
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	40.125	6533.258	11.306167
SumSLLTraits_Core	32.780	7997.038	13.839321
SumSLLConstTraits	34.992	7491.509	12.964473
SumSLLConstTraits_Core	35.055	7478.102	12.941273
SumSLLFast_Multiply	42.761	6130.411	10.609017
SumSLLFast_AdvSimd	41.725	6282.634	10.872448
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	35.394	7406.469	12.817307

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	367.967	712.412
SumSLL_Base	91.908	2852.258	4.003665
SumSLL_Base_Core	67.148	3903.987	5.479958
SumSLL_Multiply	91.810	2855.296	4.007929
SumSLL_AdvSimd	85.203	3076.715	4.318731
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	85.251	3074.975	4.316289
SumSLLTraits_Core	67.347	3892.438	5.463747
SumSLLConstTraits	71.093	3687.346	5.175862
SumSLLConstTraits_Core	71.229	3680.316	5.165995
SumSLLFast_Multiply	87.016	3012.597	4.228729
SumSLLFast_AdvSimd	71.738	3654.200	5.129336
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	85.072	3081.438	4.325360

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	374.564	699.864
SumSLL_Base	556.493	471.064	0.673080
SumSLL_Base_Core	570.979	459.113	0.656003
SumSLL_AdvSimd	186.656	1404.426	2.006713
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	186.595	1404.883	2.007366
SumSLLTraits_Core	139.989	1872.604	2.675669
SumSLLConstTraits	167.866	1561.622	2.231323
SumSLLConstTraits_Core	131.545	1992.805	2.847419
SumSLLFast_AdvSimd	142.334	1841.751	2.631586
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	141.389	1854.069	2.649185

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	294.551	889.979
SumSLLNetBcl	13.380	19592.428	22.014484
SumSLLNetBcl_Const	13.391	19576.849	21.996980
SumSLL_Base	40.607	6455.689	7.253754
SumSLL_Base_Core	40.737	6435.025	7.230536
SumSLL_Multiply	40.581	6459.693	7.258253
SumSLL_AdvSimd	19.785	13249.798	14.887765
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.792	13244.698	14.882034
SumSLLTraits_Core	13.369	19608.046	22.032033
SumSLLConstTraits	13.556	19337.787	21.728364
SumSLLConstTraits_Core	13.461	19474.237	21.881682
SumSLLFast_Multiply	23.430	11188.575	12.571729
SumSLLFast_AdvSimd	13.414	19541.925	21.957738
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	13.495	19425.881	21.827348

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	318.954	821.886
SumSLLNetBcl	26.586	9860.322	11.997184
SumSLLNetBcl_Const	26.558	9870.640	12.009738
SumSLL_Base	26.525	9882.990	12.024765
SumSLL_Base_Core	26.585	9860.638	11.997569
SumSLL_Base_Core_Element	36.437	7194.392	8.753512
SumSLL_Base_Core_Mov	33.138	7910.792	9.625165
SumSLL_Multiply	42.893	6111.626	7.436096
SumSLL_AdvSimd	39.634	6614.174	8.047553
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	39.637	6613.672	8.046942
SumSLLTraits_Core	26.578	9863.062	12.000518
SumSLLConstTraits	26.700	9818.311	11.946069
SumSLLConstTraits_Core	26.655	9834.832	11.966170
SumSLLFast_Multiply	35.636	7356.250	8.950447
SumSLLFast_AdvSimd	26.607	9852.398	11.987543
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.539	9877.648	12.018265

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	186.620	1404.693
SumSLLNetBcl	53.864	4866.808	3.464676
SumSLLNetBcl_Const	53.782	4874.203	3.469941
SumSLL_Base	53.835	4869.360	3.466493
SumSLL_Base_Core	53.793	4873.204	3.469230
SumSLL_Multiply	79.763	3286.518	2.339669
SumSLL_AdvSimd	79.496	3297.566	2.347534
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	79.485	3298.017	2.347855
SumSLLTraits_Core	53.800	4872.551	3.468765
SumSLLConstTraits	54.267	4830.590	3.438893
SumSLLConstTraits_Core	54.072	4848.092	3.451352
SumSLLFast_Multiply	75.582	3468.322	2.469095
SumSLLFast_AdvSimd	54.144	4841.647	3.446764
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	54.103	4845.268	3.449342

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	191.057	1372.074
SumSLLNetBcl	105.945	2474.334	1.803353
SumSLLNetBcl_Const	105.998	2473.100	1.802454
SumSLL_Base	106.413	2463.468	1.795433
SumSLL_Base_Core	106.524	2460.884	1.793550
SumSLL_AdvSimd	158.140	1657.667	1.208146
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	158.033	1658.788	1.208964
SumSLLTraits_Core	106.047	2471.959	1.801622
SumSLLConstTraits	106.678	2457.350	1.790974
SumSLLConstTraits_Core	105.944	2474.356	1.803369
SumSLLFast_AdvSimd	106.451	2462.569	1.794778
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	106.429	2463.079	1.795150

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

