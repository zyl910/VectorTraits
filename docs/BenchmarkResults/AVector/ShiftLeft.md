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
SumSLLScalar	236.431	1108.754
SumSLL_Base	18.852	13905.205	12.541291
SumSLL_Base_Core	6.047	43353.547	39.101148
SumSLL_Multiply	18.888	13879.186	12.517825
SumSLL_Avx2	13.853	18923.032	17.066938
SumSLLTraits	13.857	18917.686	17.062115
SumSLLTraits_Core	6.807	38508.984	34.731771
SumSLLConstTraits	10.052	26077.991	23.520091
SumSLLConstTraits_Core	6.401	40956.605	36.939313
SumSLLFast_Multiply	10.046	26095.441	23.535829
SumSLLFast_Avx2	9.844	26629.987	24.017944
SumSLLFastTraits	9.920	26425.931	23.833902

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	220.700	1187.783
SumSLL_Base	21.609	12131.082	10.213214
SumSLL_Base_Core	12.104	21657.820	18.233817
SumSLL_Base_Core_Element	24.024	10911.910	9.186786
SumSLL_Base_Core_Mov	24.136	10861.051	9.143969
SumSLL_Multiply	22.063	11881.526	10.003111
SumSLL_Avx2	15.471	16944.399	14.265566
SumSLLTraits	15.866	16522.515	13.910381
SumSLLTraits_Core	13.200	19859.901	16.720141
SumSLLConstTraits	15.280	17155.618	14.443393
SumSLLConstTraits_Core	15.205	17240.140	14.514552
SumSLLFast_Multiply	16.611	15781.007	13.286102
SumSLLFast_Avx2	14.017	18701.292	15.744703
SumSLLFastTraits	14.503	18075.620	15.217947

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	198.744	1319.005
SumSLL_Base	42.782	6127.462	4.645520
SumSLL_Base_Core	30.669	8547.451	6.480228
SumSLL_Multiply	44.313	5915.715	4.484984
SumSLL_Avx2	31.186	8405.706	6.372764
SumSLLTraits	31.585	8299.632	6.292345
SumSLLTraits_Core	24.522	10690.353	8.104864
SumSLLConstTraits	31.008	8454.158	6.409498
SumSLLConstTraits_Core	30.588	8570.171	6.497453
SumSLLFast_Multiply	33.269	7879.597	5.973896
SumSLLFast_Avx2	30.163	8690.813	6.588917
SumSLLFastTraits	30.640	8555.617	6.486419

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	203.347	1289.144
SumSLL_Base	546.277	479.874	0.372242
SumSLL_Base_Core	547.159	479.100	0.371642
SumSLL_Avx2	62.386	4201.998	3.259525
SumSLLTraits	61.744	4245.651	3.293387
SumSLLTraits_Core	48.894	5361.495	4.158957
SumSLLConstTraits	64.513	4063.437	3.152042
SumSLLConstTraits_Core	64.119	4088.370	3.171383
SumSLLFast_Avx2	60.384	4341.253	3.367546
SumSLLFastTraits	63.197	4148.023	3.217656

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
SumSLLScalar	245.991	1065.664
SumSLL_Base	19.176	13670.638	12.828279
SumSLL_Base_Core	6.888	38058.533	35.713438
SumSLL_Multiply	18.894	13874.782	13.019844
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	14.094	18599.195	17.453147
SumSLLTraits	14.249	18396.903	17.263320
SumSLLTraits_Core	6.889	38049.983	35.705414
SumSLLConstTraits	8.424	31118.941	29.201450
SumSLLConstTraits_Core	7.056	37149.805	34.860704
SumSLLFast_Multiply	10.648	24618.279	23.101347
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.979	32854.348	30.829924
SumSLLFastTraits	8.122	32274.306	30.285624

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	221.837	1181.695
SumSLL_Base	21.997	11917.270	10.084893
SumSLL_Base_Core	14.911	17580.595	14.877437
SumSLL_Base_Core_Element	24.272	10800.229	9.139606
SumSLL_Base_Core_Mov	25.077	10453.482	8.846174
SumSLL_Multiply	23.657	11081.062	9.377259
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	16.030	16353.152	13.838723
SumSLLTraits	16.180	16201.538	13.710421
SumSLLTraits_Core	14.465	18123.093	15.336521
SumSLLConstTraits	15.199	17247.557	14.595605
SumSLLConstTraits_Core	14.991	17487.171	14.798377
SumSLLFast_Multiply	17.748	14770.171	12.499138
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	13.508	19407.128	16.423125
SumSLLFastTraits	14.698	17834.965	15.092695

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	204.170	1283.947
SumSLL_Base	45.336	5782.199	4.503454
SumSLL_Base_Core	30.296	8652.893	6.739289
SumSLL_Multiply	48.433	5412.496	4.215512
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	33.420	7844.013	6.109294
SumSLLTraits	32.449	8078.688	6.292071
SumSLLTraits_Core	25.615	10234.152	7.970849
SumSLLConstTraits	28.522	9190.847	7.158273
SumSLLConstTraits_Core	26.781	9788.397	7.623674
SumSLLFast_Multiply	34.383	7624.134	5.938042
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	27.231	9626.561	7.497628
SumSLLFastTraits	27.485	9537.846	7.428533

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	197.542	1327.027
SumSLL_Base	564.734	464.190	0.349797
SumSLL_Base_Core	569.757	460.098	0.346713
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	64.759	4047.996	3.050426
SumSLLTraits	67.034	3910.629	2.946911
SumSLLTraits_Core	65.256	4017.142	3.027175
SumSLLConstTraits	75.621	3466.566	2.612280
SumSLLConstTraits_Core	66.518	3940.935	2.969748
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	70.313	3728.223	2.809456
SumSLLFastTraits	65.140	4024.332	3.032593

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
SumSLLScalar	199.273	1315.504
SumSLL_Base	17.855	14681.956	11.160707
SumSLL_Base_Core	6.843	38308.326	29.120643
SumSLL_Multiply	17.739	14777.567	11.233387
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	13.999	18726.463	14.235199
SumSLLTraits	14.195	18467.349	14.038229
SumSLLTraits_Core	7.076	37049.164	28.163473
SumSLLConstTraits	7.244	36186.185	27.507466
SumSLLConstTraits_Core	6.998	37459.840	28.475654
SumSLLFast_Multiply	10.086	25990.355	19.756955
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	6.733	38936.421	29.598099
SumSLLFastTraits	7.024	37321.738	28.370674

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	192.235	1363.663
SumSLL_Base	18.982	13810.303	10.127356
SumSLL_Base_Core	12.259	21384.123	15.681382
SumSLL_Base_Core_Element	21.241	12341.697	9.050400
SumSLL_Base_Core_Mov	21.154	12391.997	9.087286
SumSLL_Multiply	20.101	13041.302	9.563434
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	14.345	18274.037	13.400697
SumSLLTraits	14.382	18227.445	13.366531
SumSLLTraits_Core	12.868	20371.440	14.938762
SumSLLConstTraits	11.928	21977.469	16.116494
SumSLLConstTraits_Core	11.654	22494.613	16.495725
SumSLLFast_Multiply	14.515	18060.708	13.244259
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	13.318	19682.748	14.433732
SumSLLFastTraits	13.911	18843.751	13.818479

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	119.711	2189.804
SumSLL_Base	41.511	6315.004	2.883821
SumSLL_Base_Core	28.049	9345.829	4.267884
SumSLL_Multiply	41.016	6391.211	2.918622
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	28.983	9044.684	4.130362
SumSLLTraits	30.092	8711.534	3.978225
SumSLLTraits_Core	22.701	11547.517	5.273311
SumSLLConstTraits	22.904	11445.323	5.226642
SumSLLConstTraits_Core	26.653	9835.362	4.491434
SumSLLFast_Multiply	33.539	7816.164	3.569344
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	28.023	9354.739	4.271952
SumSLLFastTraits	26.397	9930.680	4.534963

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	136.141	1925.527
SumSLL_Base	592.210	442.654	0.229887
SumSLL_Base_Core	582.177	450.282	0.233849
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	62.206	4214.124	2.188556
SumSLLTraits	70.932	3695.732	1.919335
SumSLLTraits_Core	52.567	4986.875	2.589875
SumSLLConstTraits	50.047	5237.909	2.720247
SumSLLConstTraits_Core	50.356	5205.782	2.703562
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	57.447	4563.235	2.369863
SumSLLFastTraits	60.947	4301.170	2.233762

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
SumSLLScalar	429.230	610.731
SumSLL_Base	54.918	4773.369	7.815835
SumSLL_Base_Core	18.249	14365.003	23.521018
SumSLL_Multiply	54.902	4774.747	7.818092
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	54.978	4768.165	7.807314
SumSLLTraits_Core	18.250	14363.963	23.519314
SumSLLConstTraits	23.171	11313.654	18.524790
SumSLLConstTraits_Core	19.870	13193.183	21.602298
SumSLLFast_Multiply	26.342	9951.543	16.294492
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.360	9944.715	16.283311

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	432.271	606.434
SumSLL_Base	61.897	4235.155	6.983703
SumSLL_Base_Core	33.620	7797.223	12.857495
SumSLL_Base_Core_Element	66.357	3950.522	6.514347
SumSLL_Base_Core_Mov	62.311	4207.027	6.937320
SumSLL_Multiply	61.279	4277.885	7.054164
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	62.478	4195.757	6.918735
SumSLLTraits_Core	31.601	8295.461	13.679082
SumSLLConstTraits	40.192	6522.311	10.755187
SumSLLConstTraits_Core	33.545	7814.588	12.886130
SumSLLFast_Multiply	52.840	4961.046	8.180685
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	47.573	5510.371	9.086513

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	349.923	749.148
SumSLL_Base	80.876	3241.316	4.326670
SumSLL_Base_Core	63.771	4110.710	5.487180
SumSLL_Multiply	80.922	3239.479	4.324217
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	81.141	3230.702	4.312502
SumSLLTraits_Core	67.505	3883.346	5.183683
SumSLLConstTraits	80.238	3267.086	4.361068
SumSLLConstTraits_Core	67.401	3889.318	5.191655
SumSLLFast_Multiply	80.705	3248.164	4.335811
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	75.088	3491.158	4.660171

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	353.529	741.506
SumSLL_Base	1315.409	199.287	0.268760
SumSLL_Base_Core	545.361	480.680	0.648249
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	545.673	480.405	0.647877
SumSLLTraits_Core	545.213	480.810	0.648423
SumSLLConstTraits	544.289	481.626	0.649525
SumSLLConstTraits_Core	550.435	476.249	0.642273
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	542.347	483.351	0.651851

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
SumSLLScalar	429.191	610.786
SumSLL_Base	54.915	4773.640	7.815567
SumSLL_Base_Core	16.588	15802.948	25.873126
SumSLL_Multiply	54.928	4772.502	7.813703
SumSLL_AdvSimd	19.797	13241.372	21.679227
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.810	13233.206	21.665857
SumSLLTraits_Core	16.495	15892.102	26.019092
SumSLLConstTraits	16.534	15855.141	25.958579
SumSLLConstTraits_Core	72.620	3609.793	5.910077
SumSLLFast_Multiply	26.325	9957.889	16.303396
SumSLLFast_AdvSimd	16.758	15643.126	25.611461
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	16.667	15728.710	25.751580

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	439.290	596.745
SumSLL_Base	62.949	4164.378	6.978491
SumSLL_Base_Core	33.884	7736.407	12.964346
SumSLL_Base_Core_Element	61.288	4277.260	7.167654
SumSLL_Base_Core_Mov	67.272	3896.771	6.530045
SumSLL_Multiply	63.085	4155.382	6.963414
SumSLL_AdvSimd	40.556	6463.784	10.831737
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	40.596	6457.351	10.820957
SumSLLTraits_Core	33.944	7722.816	12.941571
SumSLLConstTraits	34.298	7643.077	12.807947
SumSLLConstTraits_Core	156.030	1680.091	2.815426
SumSLLFast_Multiply	53.475	4902.134	8.214791
SumSLLFast_AdvSimd	34.241	7655.858	12.829365
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	34.281	7646.974	12.814478

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	355.991	736.378
SumSLL_Base	82.536	3176.133	4.313183
SumSLL_Base_Core	65.354	4011.122	5.447097
SumSLL_Multiply	82.733	3168.572	4.302916
SumSLL_AdvSimd	82.425	3180.401	4.318979
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	82.525	3176.556	4.313757
SumSLLTraits_Core	65.038	4030.652	5.473618
SumSLLConstTraits	81.408	3220.127	4.372927
SumSLLConstTraits_Core	348.929	751.281	1.020239
SumSLLFast_Multiply	82.357	3183.032	4.322552
SumSLLFast_AdvSimd	69.861	3752.391	5.095741
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	69.806	3755.336	5.099739

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	359.996	728.187
SumSLL_Base	550.260	476.401	0.654229
SumSLL_Base_Core	551.586	475.255	0.652655
SumSLL_AdvSimd	180.644	1451.166	1.992849
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	179.868	1457.422	2.001439
SumSLLTraits_Core	127.031	2063.620	2.833916
SumSLLConstTraits	137.004	1913.406	2.627631
SumSLLConstTraits_Core	801.160	327.206	0.449343
SumSLLFast_AdvSimd	136.681	1917.926	2.633838
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	136.482	1920.717	2.637671

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
SumSLLScalar	401.136	653.504
SumSLL_Base	45.908	5710.162	8.737761
SumSLL_Base_Core	16.576	15814.815	24.200026
SumSLL_Multiply	45.306	5786.023	8.853844
SumSLL_AdvSimd	19.801	13238.637	20.257927
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.832	13218.085	20.226478
SumSLLTraits_Core	16.493	15893.997	24.321192
SumSLLConstTraits	16.479	15907.704	24.342166
SumSLLConstTraits_Core	16.482	15905.275	24.338450
SumSLLFast_Multiply	23.630	11093.497	16.975407
SumSLLFast_AdvSimd	19.761	13265.947	20.299718
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	19.766	13262.086	20.293809

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	432.368	606.298
SumSLL_Base	46.697	5613.742	9.259049
SumSLL_Base_Core	33.513	7822.043	12.901319
SumSLL_Base_Core_Element	49.928	5250.411	8.659786
SumSLL_Base_Core_Mov	51.461	5094.016	8.401837
SumSLL_Multiply	46.643	5620.190	9.269683
SumSLL_AdvSimd	40.215	6518.506	10.751326
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	40.074	6541.442	10.789155
SumSLLTraits_Core	31.359	8359.565	13.787884
SumSLLConstTraits	33.653	7789.581	12.847777
SumSLLConstTraits_Core	33.358	7858.605	12.961623
SumSLLFast_Multiply	40.507	6471.529	10.673843
SumSLLFast_AdvSimd	39.703	6602.652	10.890111
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	33.705	7777.522	12.827888

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	350.226	748.499
SumSLL_Base	87.719	2988.465	3.992612
SumSLL_Base_Core	64.126	4087.932	5.461508
SumSLL_Multiply	87.719	2988.450	3.992592
SumSLL_AdvSimd	81.205	3228.170	4.312859
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	81.219	3227.632	4.312140
SumSLLTraits_Core	63.901	4102.318	5.480727
SumSLLConstTraits	68.264	3840.173	5.130500
SumSLLConstTraits_Core	67.821	3865.243	5.163994
SumSLLFast_Multiply	82.608	3173.340	4.239606
SumSLLFast_AdvSimd	68.349	3835.364	5.124075
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	80.379	3261.351	4.357189

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	353.538	741.488
SumSLL_Base	541.660	483.964	0.652693
SumSLL_Base_Core	542.303	483.390	0.651920
SumSLL_AdvSimd	177.524	1476.665	1.991490
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	177.428	1477.470	1.992576
SumSLLTraits_Core	133.233	1967.562	2.653533
SumSLLConstTraits	159.303	1645.565	2.219275
SumSLLConstTraits_Core	124.965	2097.734	2.829089
SumSLLFast_AdvSimd	134.240	1952.796	2.633619
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	134.016	1956.064	2.638027

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


[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	191.354	1369.943
SumSLLNetBcl	106.035	2472.244	1.804633
SumSLLNetBcl_Const	106.265	2466.886	1.800722
SumSLL_Base	106.435	2462.940	1.797842
SumSLL_Base_Core	106.393	2463.923	1.798559
SumSLL_AdvSimd	158.248	1656.542	1.209205
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	158.439	1654.543	1.207746
SumSLLTraits_Core	106.118	2470.316	1.803225
SumSLLConstTraits	106.702	2456.788	1.793351
SumSLLConstTraits_Core	106.123	2470.179	1.803126
SumSLLFast_AdvSimd	106.603	2459.069	1.795016
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	106.567	2459.895	1.795619

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

