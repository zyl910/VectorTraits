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
SumSLLScalar	170.996	1533.039
SumSLLNetBcl	226.673	1156.486	0.754375
SumSLLNetBcl_Const	227.738	1151.077	0.750847
SumSLL_Base	14.355	18261.898	11.912223
SumSLL_Base_Core	14.267	18374.354	11.985579
SumSLL_Multiply	14.303	18327.957	11.955314
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	13.366	19612.920	12.793494
SumSLLTraits	12.796	20485.785	13.362863
SumSLLTraits_Core	7.308	35868.928	23.397278
SumSLLConstTraits	7.345	35689.810	23.280439
SumSLLConstTraits_Core	6.905	37962.823	24.763124
SumSLLFast_Multiply	8.164	32110.166	20.945440
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.273	36042.593	23.510559
SumSLLFastTraits	7.309	35863.752	23.393901

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	172.917	1516.011
SumSLLNetBcl	14.708	17822.685	11.756304
SumSLLNetBcl_Const	12.962	20224.721	13.340749
SumSLL_Base	14.100	18592.216	12.263906
SumSLL_Base_Core	14.044	18666.479	12.312892
SumSLL_Base_Core_Element	16.536	15853.166	10.457158
SumSLL_Base_Core_Mov	16.332	16050.828	10.587541
SumSLL_Multiply	18.187	14413.717	9.507661
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	15.733	16661.977	10.990671
SumSLLTraits	15.698	16698.771	11.014941
SumSLLTraits_Core	13.498	19421.127	12.810677
SumSLLConstTraits	12.240	21417.674	14.127652
SumSLLConstTraits_Core	12.319	21280.238	14.036995
SumSLLFast_Multiply	15.362	17064.556	11.256222
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	14.119	18566.133	12.246701
SumSLLFastTraits	14.413	18187.805	11.997146

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	117.662	2227.945
SumSLLNetBcl	26.862	9758.749	4.380158
SumSLLNetBcl_Const	26.403	9928.395	4.456303
SumSLL_Base	27.931	9385.461	4.212610
SumSLL_Base_Core	28.933	9060.234	4.066634
SumSLL_Multiply	37.430	7003.672	3.143558
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	31.677	8275.615	3.714462
SumSLLTraits	30.208	8678.003	3.895071
SumSLLTraits_Core	24.009	10918.365	4.900645
SumSLLConstTraits	24.303	10786.594	4.841500
SumSLLConstTraits_Core	24.725	10602.534	4.758886
SumSLLFast_Multiply	30.915	8479.451	3.805952
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	25.332	10348.529	4.644877
SumSLLFastTraits	25.463	10295.008	4.620855

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	103.671	2528.617
SumSLLNetBcl	60.025	4367.269	1.727138
SumSLLNetBcl_Const	54.172	4839.137	1.913748
SumSLL_Base	58.921	4449.077	1.759490
SumSLL_Base_Core	60.147	4358.398	1.723629
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	64.866	4041.304	1.598227
SumSLLTraits	64.772	4047.161	1.600543
SumSLLTraits_Core	50.423	5198.907	2.056028
SumSLLConstTraits	49.947	5248.445	2.075619
SumSLLConstTraits_Core	54.647	4797.017	1.897091
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	60.325	4345.543	1.718545
SumSLLFastTraits	59.784	4384.876	1.734100

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

