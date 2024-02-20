# Benchmark - ShiftLeft
([← Back](README.md))

See [Group](ShiftLeft_Group.md)

## X86

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	304.879	859.830
SumSLL_Basic	29.404	8915.278	10.368654
SumSLL_Base_Core	6.602	39706.505	46.179494
SumSLL_Multiply	29.521	8879.961	10.327579
SumSLLTraits	29.460	8898.294	10.348901
SumSLLTraits_Core	7.396	35443.918	41.222016
SumSLLConstTraits	22.996	11399.508	13.257866
SumSLLConstTraits_Core	6.605	39686.234	46.155918
SumSLLFast_Multiply	22.321	11744.320	13.658890
SumSLLFastTraits	22.574	11612.495	13.505574

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	311.522	841.494
SumSLL_Basic	48.569	5397.386	6.414050
SumSLL_Base_Core	11.256	23288.822	27.675558
SumSLL_Base_Core_Element	49.687	5275.958	6.269749
SumSLL_Base_Core_Mov	51.005	5139.615	6.107725
SumSLL_Multiply	47.004	5577.054	6.627560
SumSLLTraits	48.037	5457.114	6.485028
SumSLLTraits_Core	11.957	21924.622	26.054393
SumSLLConstTraits	42.539	6162.425	7.323193
SumSLLConstTraits_Core	12.088	21686.822	25.771800
SumSLLFast_Multiply	42.371	6186.912	7.352292
SumSLLFastTraits	42.389	6184.293	7.349181

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	311.584	841.328
SumSLL_Basic	93.532	2802.717	3.331302
SumSLL_Base_Core	28.870	9080.301	10.792825
SumSLL_Multiply	92.824	2824.083	3.356698
SumSLLTraits	93.007	2818.536	3.350106
SumSLLTraits_Core	28.692	9136.424	10.859532
SumSLLConstTraits	84.313	3109.161	3.695542
SumSLLConstTraits_Core	28.470	9207.823	10.944397
SumSLLFast_Multiply	83.933	3123.269	3.712311
SumSLLFastTraits	82.457	3179.152	3.778733

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	314.890	832.495
SumSLL_Basic	580.294	451.744	0.542639
SumSLL_Base_Core	572.165	458.161	0.550347
SumSLLTraits	581.367	450.909	0.541636
SumSLLTraits_Core	602.887	434.814	0.522303
SumSLLConstTraits	523.344	500.901	0.601687
SumSLLConstTraits_Core	522.427	501.781	0.602744
SumSLLFastTraits	539.336	486.050	0.583847

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	304.933	859.678
SumSLL_Basic	29.296	8948.021	10.408578
SumSLL_Base_Core	7.588	34547.354	40.186410
SumSLL_Multiply	29.579	8862.589	10.309202
SumSLLTraits	29.393	8918.435	10.374163
SumSLLTraits_Core	6.608	39670.570	46.145872
SumSLLConstTraits	23.005	11394.920	13.254877
SumSLLConstTraits_Core	7.450	35187.799	40.931393
SumSLLFast_Multiply	22.363	11722.099	13.635460
SumSLLFastTraits	22.394	11706.056	13.616799

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	310.930	843.096
SumSLL_Basic	46.542	5632.457	6.680683
SumSLL_Base_Core	11.597	22603.626	26.810262
SumSLL_Base_Core_Element	50.830	5157.314	6.117113
SumSLL_Base_Core_Mov	51.729	5067.630	6.010739
SumSLL_Multiply	46.557	5630.545	6.678415
SumSLLTraits	46.461	5642.180	6.692215
SumSLLTraits_Core	11.612	22574.392	26.775588
SumSLLConstTraits	41.149	6370.666	7.556276
SumSLLConstTraits_Core	12.055	21746.218	25.793287
SumSLLFast_Multiply	40.820	6421.950	7.617104
SumSLLFastTraits	41.548	6309.359	7.483560

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	311.828	840.669
SumSLL_Basic	88.877	2949.499	3.508514
SumSLL_Base_Core	29.773	8804.870	10.473647
SumSLL_Multiply	88.760	2953.408	3.513165
SumSLLTraits	89.007	2945.223	3.503428
SumSLLTraits_Core	27.071	9683.714	11.519058
SumSLLConstTraits	80.198	3268.712	3.888227
SumSLLConstTraits_Core	26.840	9766.888	11.617995
SumSLLFast_Multiply	80.397	3260.600	3.878578
SumSLLFastTraits	79.364	3303.057	3.929081

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	315.951	829.698
SumSLL_Basic	581.999	450.420	0.542872
SumSLL_Base_Core	555.365	472.021	0.568907
SumSLLTraits	555.418	471.976	0.568853
SumSLLTraits_Core	556.600	470.974	0.567645
SumSLLConstTraits	477.458	549.041	0.661736
SumSLLConstTraits_Core	477.611	548.865	0.661524
SumSLLFastTraits	520.414	503.722	0.607116

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	233.978	1120.378
SumSLL_Basic	16.480	15906.723	14.197643
SumSLL_Base_Core	5.741	45658.298	40.752595
SumSLL_Multiply	16.434	15951.707	14.237794
SumSLL_Avx2	11.691	22421.910	20.012814
SumSLLTraits	11.653	22496.421	20.079319
SumSLLTraits_Core	6.212	42201.168	37.666912
SumSLLConstTraits	9.806	26732.458	23.860220
SumSLLConstTraits_Core	6.206	42237.347	37.699204
SumSLL128Traits	24.461	10716.849	9.565389
SumSLL128Traits_Core	11.372	23050.798	20.574132
SumSLL128ConstTraits	19.575	13391.678	11.952824
SumSLL128ConstTraits_Core	11.613	22572.982	20.147654
SumSLLFast_Multiply	9.785	26791.041	23.912508
SumSLLFast_Avx2	9.767	26841.018	23.957116
SumSLLFastTraits	9.803	26739.956	23.866912

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	219.723	1193.064
SumSLL_Basic	21.412	12242.743	10.261594
SumSLL_Base_Core	12.015	21818.346	18.287652
SumSLL_Base_Core_Element	23.087	11354.740	9.517290
SumSLL_Base_Core_Mov	23.300	11250.575	9.429981
SumSLL_Multiply	21.318	12296.786	10.306892
SumSLL_Avx2	14.478	18106.898	15.176798
SumSLLTraits	14.488	18094.357	15.166287
SumSLLTraits_Core	13.136	19955.908	16.726597
SumSLLConstTraits	14.086	18610.286	15.598727
SumSLLConstTraits_Core	11.666	22470.309	18.834112
SumSLL128Traits	25.360	10336.762	8.664043
SumSLL128Traits_Core	22.487	11657.662	9.771193
SumSLL128ConstTraits	25.357	10337.941	8.665032
SumSLL128ConstTraits_Core	22.399	11703.474	9.809591
SumSLLFast_Multiply	16.040	16343.287	13.698579
SumSLLFast_Avx2	13.032	20115.209	16.860120
SumSLLFastTraits	13.095	20019.329	16.779756

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	194.032	1351.033
SumSLL_Basic	40.891	6410.821	4.745125
SumSLL_Base_Core	26.806	9779.287	7.238376
SumSLL_Multiply	40.287	6506.876	4.816222
SumSLL_Avx2	29.563	8867.412	6.563430
SumSLLTraits	28.911	9067.419	6.711470
SumSLLTraits_Core	23.755	11035.304	8.168048
SumSLLConstTraits	29.567	8866.244	6.562565
SumSLLConstTraits_Core	23.179	11309.484	8.370988
SumSLL128Traits	50.188	5223.277	3.866135
SumSLL128Traits_Core	42.734	6134.347	4.540485
SumSLL128ConstTraits	50.553	5185.557	3.838215
SumSLL128ConstTraits_Core	43.025	6092.871	4.509786
SumSLLFast_Multiply	30.129	8700.854	6.440148
SumSLLFast_Avx2	26.131	10031.817	7.425292
SumSLLFastTraits	26.120	10036.247	7.428571

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	194.020	1351.115
SumSLL_Basic	536.292	488.809	0.361782
SumSLL_Base_Core	535.876	489.188	0.362062
SumSLL_Avx2	58.286	4497.519	3.328746
SumSLLTraits	57.704	4542.925	3.362352
SumSLLTraits_Core	43.720	5996.036	4.437842
SumSLLConstTraits	56.083	4674.201	3.459513
SumSLLConstTraits_Core	44.729	5860.712	4.337684
SumSLL128Traits	101.276	2588.404	1.915754
SumSLL128Traits_Core	85.540	3064.588	2.268191
SumSLL128ConstTraits	101.015	2595.091	1.920702
SumSLL128ConstTraits_Core	78.660	3332.640	2.466584
SumSLLFast_Avx2	52.112	5030.382	3.723133
SumSLLFastTraits	52.167	5025.083	3.719211

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	232.532	1127.346
SumSLL_Basic	17.109	15322.318	13.591494
SumSLL_Base_Core	6.533	40123.498	35.591109
SumSLL_Multiply	17.183	15255.982	13.532652
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	11.769	22273.765	19.757699
SumSLLTraits	13.145	19942.064	17.689390
SumSLLTraits_Core	8.046	32582.667	28.902098
SumSLLConstTraits	8.574	30573.583	27.119962
SumSLLConstTraits_Core	7.711	33994.636	30.154570
SumSLL128Traits	27.827	9420.328	8.356199
SumSLL128Traits_Core	12.444	21066.098	18.686452
SumSLL128ConstTraits	11.799	22217.394	19.707696
SumSLL128ConstTraits_Core	11.384	23027.578	20.426361
SumSLLFast_Multiply	9.805	26735.628	23.715547
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.478	35053.310	31.093655
SumSLLFastTraits	7.501	34949.253	31.001352

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	220.281	1190.046
SumSLL_Basic	21.271	12324.011	10.355911
SumSLL_Base_Core	11.361	23074.695	19.389749
SumSLL_Base_Core_Element	22.748	11523.799	9.683490
SumSLL_Base_Core_Mov	23.702	11060.124	9.293862
SumSLL_Multiply	26.580	9862.494	8.287489
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	14.963	17519.480	14.721681
SumSLLTraits	14.969	17511.952	14.715355
SumSLLTraits_Core	17.118	15314.070	12.868468
SumSLLConstTraits	13.411	19546.284	16.424812
SumSLLConstTraits_Core	13.050	20086.968	16.879150
SumSLL128Traits	25.400	10320.694	8.672515
SumSLL128Traits_Core	22.450	11676.835	9.812086
SumSLL128ConstTraits	22.488	11656.995	9.795414
SumSLL128ConstTraits_Core	22.490	11655.909	9.794501
SumSLLFast_Multiply	15.391	17032.182	14.312203
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	11.928	21976.277	18.466743
SumSLLFastTraits	12.678	20676.579	17.374603

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	193.821	1352.504
SumSLL_Basic	43.738	5993.531	4.431433
SumSLL_Base_Core	29.375	8924.169	6.598257
SumSLL_Multiply	41.490	6318.309	4.671564
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	29.738	8815.073	6.517595
SumSLLTraits	31.053	8441.793	6.241603
SumSLLTraits_Core	26.047	10064.362	7.441281
SumSLLConstTraits	25.523	10270.765	7.593889
SumSLLConstTraits_Core	22.964	11415.397	8.440195
SumSLL128Traits	56.482	4641.201	3.431562
SumSLL128Traits_Core	42.967	6101.042	4.510924
SumSLL128ConstTraits	44.786	5853.219	4.327691
SumSLL128ConstTraits_Core	38.558	6798.737	5.026778
SumSLLFast_Multiply	30.051	8723.159	6.449636
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	25.243	10384.981	7.678337
SumSLLFastTraits	25.281	10369.038	7.666549

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	194.724	1346.235
SumSLL_Basic	556.299	471.229	0.350034
SumSLL_Base_Core	562.446	466.079	0.346209
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	58.928	4448.556	3.304442
SumSLLTraits	59.076	4437.420	3.296170
SumSLLTraits_Core	46.552	5631.227	4.182945
SumSLLConstTraits	60.136	4359.205	3.238071
SumSLLConstTraits_Core	47.712	5494.338	4.081262
SumSLL128Traits	101.761	2576.063	1.913531
SumSLL128Traits_Core	85.666	3060.060	2.273050
SumSLL128ConstTraits	100.866	2598.921	1.930510
SumSLL128ConstTraits_Core	85.623	3061.618	2.274208
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	54.373	4821.201	3.581248
SumSLLFastTraits	54.707	4791.775	3.559389

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	192.844	1359.361
SumSLL_Basic	15.940	16445.602	12.098041
SumSLL_Base_Core	6.546	40044.314	29.458196
SumSLL_Multiply	15.926	16459.778	12.108470
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	11.740	22329.276	16.426306
SumSLLTraits	11.768	22275.738	16.386922
SumSLLTraits_Core	6.760	38778.852	28.527271
SumSLLConstTraits	6.425	40803.174	30.016443
SumSLLConstTraits_Core	6.906	37957.676	27.923181
SumSLL128Traits	23.149	11324.426	8.330700
SumSLL128Traits_Core	11.392	23010.720	16.927604
SumSLL128ConstTraits	11.188	23430.138	17.236145
SumSLL128ConstTraits_Core	11.384	23027.809	16.940175
SumSLLFast_Multiply	9.782	26799.087	19.714478
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	6.934	37805.004	27.810870
SumSLLFastTraits	6.951	37713.378	27.743466

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	192.920	1358.824
SumSLL_Basic	18.729	13996.667	10.300577
SumSLL_Base_Core	11.139	23534.517	17.319774
SumSLL_Base_Core_Element	20.656	12690.810	9.339557
SumSLL_Base_Core_Mov	21.736	12060.375	8.875601
SumSLL_Multiply	19.387	13521.671	9.951013
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	14.913	17577.641	12.935926
SumSLLTraits	15.054	17413.467	12.815106
SumSLLTraits_Core	12.693	20651.910	15.198375
SumSLLConstTraits	12.036	21780.182	16.028705
SumSLLConstTraits_Core	11.748	22313.920	16.421499
SumSLL128Traits	25.452	10299.377	7.579628
SumSLL128Traits_Core	22.485	11658.723	8.580012
SumSLL128ConstTraits	21.611	12129.890	8.926759
SumSLL128ConstTraits_Core	20.978	12496.018	9.196204
SumSLLFast_Multiply	13.215	19837.415	14.598963
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	12.935	20266.778	14.914944
SumSLLFastTraits	13.233	19810.254	14.578974

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	118.564	2210.995
SumSLL_Basic	40.322	6501.187	2.940390
SumSLL_Base_Core	28.396	9231.653	4.175339
SumSLL_Multiply	40.829	6420.457	2.903877
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	29.894	8769.006	3.966091
SumSLLTraits	29.673	8834.515	3.995720
SumSLLTraits_Core	24.720	10604.724	4.796359
SumSLLConstTraits	23.321	11240.672	5.083989
SumSLLConstTraits_Core	24.387	10749.271	4.861736
SumSLL128Traits	50.821	5158.228	2.332990
SumSLL128Traits_Core	41.296	6347.901	2.871061
SumSLL128ConstTraits	42.898	6110.895	2.763867
SumSLL128ConstTraits_Core	42.863	6115.839	2.766103
SumSLLFast_Multiply	30.260	8663.119	3.918200
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	27.803	9428.490	4.264366
SumSLLFastTraits	27.715	9458.591	4.277980

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	121.254	2161.948
SumSLL_Basic	553.559	473.561	0.219044
SumSLL_Base_Core	553.932	473.242	0.218896
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	57.307	4574.409	2.115874
SumSLLTraits	56.935	4604.258	2.129680
SumSLLTraits_Core	44.853	5844.559	2.703376
SumSLLConstTraits	46.435	5645.399	2.611255
SumSLLConstTraits_Core	46.897	5589.806	2.585541
SumSLL128Traits	101.375	2585.887	1.196091
SumSLL128Traits_Core	81.200	3228.360	1.493264
SumSLL128ConstTraits	83.688	3132.408	1.448882
SumSLL128ConstTraits_Core	85.531	3064.909	1.417661
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	51.564	5083.835	2.351506
SumSLLFastTraits	51.035	5136.548	2.375889

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


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	169.143	1549.840
SumSLLNetBcl	222.385	1178.786	0.760585
SumSLLNetBcl_Const	222.658	1177.339	0.759651
SumSLL_Basic	13.086	20032.835	12.925740
SumSLL_Base_Core	6.591	39771.177	25.661466
SumSLL_Multiply	13.060	20072.958	12.951629
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	10.372	25274.859	16.308040
SumSLLTraits	10.215	25662.171	16.557945
SumSLLTraits_Core	6.765	38750.734	25.003048
SumSLLConstTraits	6.780	38665.512	24.948060
SumSLLConstTraits_Core	6.295	41641.236	26.868080
SumSLL128Traits	19.677	13322.526	8.596063
SumSLL128Traits_Core	12.417	21112.009	13.622054
SumSLL128ConstTraits	12.450	21055.801	13.585787
SumSLL128ConstTraits_Core	12.435	21080.812	13.601924
SumSLLFast_Multiply	7.377	35535.744	22.928647
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	6.925	37856.876	24.426306
SumSLLFastTraits	6.724	38986.866	25.155407

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	168.716	1553.763
SumSLLNetBcl	12.543	20899.194	13.450699
SumSLLNetBcl_Const	11.206	23392.777	15.055566
SumSLL_Basic	13.582	19300.915	12.422048
SumSLL_Base_Core	13.341	19649.150	12.646172
SumSLL_Base_Core_Element	15.659	16740.485	10.774158
SumSLL_Base_Core_Mov	14.897	17597.569	11.325776
SumSLL_Multiply	17.128	15305.111	9.850353
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	14.480	18104.001	11.651715
SumSLLTraits	13.924	18827.412	12.117302
SumSLLTraits_Core	14.208	18450.119	11.874477
SumSLLConstTraits	12.795	20487.319	13.185616
SumSLLConstTraits_Core	12.023	21803.300	14.032580
SumSLL128Traits	21.871	11985.678	7.713969
SumSLL128Traits_Core	21.081	12435.207	8.003286
SumSLL128ConstTraits	20.075	13057.907	8.404055
SumSLL128ConstTraits_Core	20.228	12959.630	8.340804
SumSLLFast_Multiply	13.211	19843.004	12.770936
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	13.173	19900.086	12.807674
SumSLLFastTraits	13.536	19366.831	12.464471

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	155.823	1682.320
SumSLLNetBcl	23.617	11099.770	6.597894
SumSLLNetBcl_Const	22.902	11446.173	6.803802
SumSLL_Basic	24.390	10747.854	6.388709
SumSLL_Base_Core	24.429	10730.875	6.378617
SumSLL_Multiply	34.710	7552.381	4.489265
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	28.257	9277.081	5.514457
SumSLLTraits	26.153	10023.542	5.958165
SumSLLTraits_Core	22.423	11690.595	6.949091
SumSLLConstTraits	23.236	11281.663	6.706014
SumSLLConstTraits_Core	22.716	11540.250	6.859723
SumSLL128Traits	42.028	6237.418	3.707629
SumSLL128Traits_Core	40.439	6482.377	3.853236
SumSLL128ConstTraits	40.066	6542.770	3.889135
SumSLL128ConstTraits_Core	39.928	6565.355	3.902560
SumSLLFast_Multiply	28.247	9280.389	5.516423
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	25.518	10272.998	6.106447
SumSLLFastTraits	24.715	10606.724	6.304819

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	98.276	2667.438
SumSLLNetBcl	62.719	4179.660	1.566919
SumSLLNetBcl_Const	46.412	5648.203	2.117464
SumSLL_Basic	53.437	4905.683	1.839099
SumSLL_Base_Core	53.493	4900.543	1.837172
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	60.073	4363.729	1.635925
SumSLLTraits	70.663	3709.782	1.390766
SumSLLTraits_Core	93.068	2816.698	1.055956
SumSLLConstTraits	52.726	4971.800	1.863886
SumSLLConstTraits_Core	51.283	5111.673	1.916323
SumSLL128Traits	98.763	2654.271	0.995064
SumSLL128Traits_Core	75.430	3475.323	1.302869
SumSLL128ConstTraits	76.978	3405.429	1.276666
SumSLL128ConstTraits_Core	76.340	3433.879	1.287332
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	51.284	5111.590	1.916292
SumSLLFastTraits	53.085	4938.225	1.851299

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
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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
SumSLLScalar	429.609	610.192
SumSLL_Basic	46.184	5676.064	9.302090
SumSLL_Base_Core	18.268	14349.939	23.517074
SumSLL_Multiply	46.183	5676.185	9.302288
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	46.250	5668.036	9.288933
SumSLLTraits_Core	18.278	14341.895	23.503891
SumSLLConstTraits	26.355	9946.663	16.300865
SumSLLConstTraits_Core	19.857	13201.657	21.635238
SumSLLFast_Multiply	26.355	9946.629	16.300809
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.379	9937.536	16.285907

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	431.910	606.942
SumSLL_Basic	62.039	4225.475	6.961910
SumSLL_Base_Core	33.284	7876.033	12.976586
SumSLL_Base_Core_Element	66.166	3961.926	6.527685
SumSLL_Base_Core_Mov	61.881	4236.260	6.979680
SumSLL_Multiply	61.829	4239.837	6.985573
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	61.953	4231.310	6.971524
SumSLLTraits_Core	33.259	7881.834	12.986143
SumSLLConstTraits	39.853	6577.829	10.837659
SumSLLConstTraits_Core	31.271	8383.107	13.812042
SumSLLFast_Multiply	47.381	5532.640	9.115602
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	52.682	4975.958	8.198410

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	349.763	749.491
SumSLL_Basic	80.635	3251.006	4.337620
SumSLL_Base_Core	63.178	4149.315	5.536180
SumSLL_Multiply	81.011	3235.925	4.317499
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	81.078	3233.214	4.313882
SumSLLTraits_Core	67.182	3901.975	5.206170
SumSLLConstTraits	74.675	3510.471	4.683808
SumSLLConstTraits_Core	67.116	3905.829	5.211311
SumSLLFast_Multiply	80.587	3252.916	4.340169
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	74.737	3507.561	4.679927

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	352.730	743.187
SumSLL_Basic	544.543	481.402	0.647754
SumSLL_Base_Core	541.368	484.225	0.651552
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	543.804	482.056	0.648633
SumSLLTraits_Core	537.101	488.072	0.656729
SumSLLConstTraits	560.206	467.942	0.629643
SumSLLConstTraits_Core	557.621	470.112	0.632562
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	556.305	471.224	0.634058

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
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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
SumSLLScalar	429.348	610.563
SumSLL_Basic	46.132	5682.492	9.306973
SumSLL_Base_Core	16.594	15797.770	25.874107
SumSLL_Multiply	46.131	5682.654	9.307238
SumSLL_AdvSimd	19.801	13239.258	21.683692
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.780	13252.891	21.706020
SumSLLTraits_Core	16.499	15888.315	26.022404
SumSLLConstTraits	19.794	13243.304	21.690319
SumSLLConstTraits_Core	16.490	15896.748	26.036217
SumSLLFast_Multiply	26.334	9954.522	16.303843
SumSLLFast_AdvSimd	16.494	15893.590	26.031045
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	16.495	15892.019	26.028471

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	431.708	607.226
SumSLL_Basic	62.947	4164.512	6.858263
SumSLL_Base_Core	33.298	7872.607	12.964882
SumSLL_Base_Core_Element	60.799	4311.659	7.100590
SumSLL_Base_Core_Mov	66.039	3969.535	6.537168
SumSLL_Multiply	60.712	4317.808	7.110716
SumSLL_AdvSimd	39.834	6580.871	10.837606
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	40.003	6553.072	10.791825
SumSLLTraits_Core	33.192	7897.878	13.006499
SumSLLConstTraits	39.598	6620.078	10.902173
SumSLLConstTraits_Core	33.086	7923.119	13.048066
SumSLLFast_Multiply	47.357	5535.524	9.116093
SumSLLFast_AdvSimd	33.331	7864.969	12.952303
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	33.352	7860.008	12.944132

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	351.204	746.414
SumSLL_Basic	81.774	3205.726	4.294834
SumSLL_Base_Core	63.677	4116.747	5.515364
SumSLL_Multiply	81.298	3224.488	4.319970
SumSLL_AdvSimd	79.954	3278.702	4.392603
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	74.231	3531.441	4.731207
SumSLLTraits_Core	63.317	4140.171	5.546747
SumSLLConstTraits	67.820	3865.285	5.178470
SumSLLConstTraits_Core	67.287	3895.898	5.219484
SumSLLFast_Multiply	80.893	3240.639	4.341609
SumSLLFast_AdvSimd	80.123	3271.777	4.383325
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	79.828	3283.848	4.399497

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	352.968	742.685
SumSLL_Basic	548.659	477.791	0.643328
SumSLL_Base_Core	547.245	479.025	0.644990
SumSLL_AdvSimd	159.940	1639.016	2.206878
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	160.114	1637.232	2.204477
SumSLLTraits_Core	133.058	1970.152	2.652741
SumSLLConstTraits	133.854	1958.432	2.636961
SumSLLConstTraits_Core	132.940	1971.898	2.655092
SumSLLFast_AdvSimd	133.774	1959.602	2.638536
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	159.258	1646.035	2.216329

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
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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
SumSLLScalar	401.325	653.197
SumSLL_Basic	37.192	7048.387	10.790600
SumSLL_Base_Core	19.784	13250.518	20.285640
SumSLL_Multiply	37.126	7060.939	10.809816
SumSLL_AdvSimd	19.834	13216.883	20.234148
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.779	13253.575	20.290320
SumSLLTraits_Core	16.500	15887.520	24.322711
SumSLLConstTraits	16.492	15895.672	24.335190
SumSLLConstTraits_Core	16.493	15894.093	24.332774
SumSLLFast_Multiply	23.571	11121.366	17.026054
SumSLLFast_AdvSimd	15.400	17022.639	26.060501
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	15.410	17010.920	26.042560

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	431.341	607.742
SumSLL_Basic	46.585	5627.246	9.259268
SumSLL_Base_Core	33.281	7876.791	12.960748
SumSLL_Base_Core_Element	49.730	5271.394	8.673736
SumSLL_Base_Core_Mov	51.264	5113.562	8.414035
SumSLL_Multiply	46.475	5640.580	9.281208
SumSLL_AdvSimd	39.934	6564.405	10.801303
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	39.698	6603.431	10.865517
SumSLLTraits_Core	31.025	8449.502	13.903106
SumSLLConstTraits	31.044	8444.304	13.894553
SumSLLConstTraits_Core	31.046	8443.802	13.893728
SumSLLFast_Multiply	40.347	6497.237	10.690782
SumSLLFast_AdvSimd	31.020	8450.845	13.905317
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	31.045	8444.011	13.894072

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	350.801	747.273
SumSLL_Basic	87.267	3003.930	4.019857
SumSLL_Base_Core	63.549	4125.050	5.520138
SumSLL_Multiply	87.161	3007.593	4.024759
SumSLL_AdvSimd	79.786	3285.599	4.396787
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	74.254	3530.389	4.724364
SumSLLTraits_Core	63.283	4142.377	5.543325
SumSLLConstTraits	63.410	4134.108	5.532260
SumSLLConstTraits_Core	67.273	3896.719	5.214586
SumSLLFast_Multiply	82.299	3185.249	4.262499
SumSLLFast_AdvSimd	67.183	3901.965	5.221607
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	67.227	3899.394	5.218166

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	352.458	743.760
SumSLL_Basic	540.845	484.694	0.651680
SumSLL_Base_Core	541.026	484.531	0.651462
SumSLL_AdvSimd	160.402	1634.294	2.197339
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	159.791	1640.547	2.205746
SumSLLTraits_Core	125.500	2088.793	2.808421
SumSLLConstTraits	124.884	2099.095	2.822274
SumSLLConstTraits_Core	124.968	2097.693	2.820388
SumSLLFast_AdvSimd	133.044	1970.355	2.649180
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	124.763	2101.135	2.825015

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
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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
SumSLLScalar	294.184	891.088
SumSLLNetBcl	13.388	19580.464	21.973654
SumSLLNetBcl_Const	13.375	19599.073	21.994538
SumSLL_Basic	13.363	19616.914	22.014559
SumSLL_Base_Core	13.398	19565.182	21.956504
SumSLL_Multiply	35.423	7400.391	8.304892
SumSLL_AdvSimd	19.812	13231.639	14.848854
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.797	13241.598	14.860030
SumSLLTraits_Core	13.378	19595.005	21.989972
SumSLLConstTraits	13.466	19466.408	21.845657
SumSLLConstTraits_Core	13.480	19447.318	21.824235
SumSLLFast_Multiply	22.919	11437.932	12.835914
SumSLLFast_AdvSimd	13.365	19613.913	22.011192
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	13.378	19595.664	21.990712

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	342.603	765.154
SumSLLNetBcl	28.090	9332.186	12.196478
SumSLLNetBcl_Const	28.370	9240.256	12.076332
SumSLL_Basic	28.036	9350.349	12.220215
SumSLL_Base_Core	27.833	9418.617	12.309436
SumSLL_Base_Core_Element	39.135	6698.495	8.754438
SumSLL_Base_Core_Mov	35.177	7452.238	9.739524
SumSLL_Multiply	45.762	5728.366	7.486551
SumSLL_AdvSimd	42.719	6136.411	8.019836
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	28.034	9351.061	12.221146
SumSLLTraits_Core	28.018	9356.142	12.227786
SumSLLConstTraits	28.009	9359.246	12.231843
SumSLLConstTraits_Core	28.134	9317.663	12.177497
SumSLLFast_Multiply	38.378	6830.659	8.927167
SumSLLFast_AdvSimd	27.449	9550.069	12.481235
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	27.847	9413.761	12.303089

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	186.774	1403.533
SumSLLNetBcl	57.769	4537.804	3.233131
SumSLLNetBcl_Const	57.827	4533.257	3.229891
SumSLL_Basic	56.936	4604.189	3.280429
SumSLL_Base_Core	57.240	4579.735	3.263006
SumSLL_Multiply	86.170	3042.178	2.167515
SumSLL_AdvSimd	71.570	3662.748	2.609664
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	57.671	4545.497	3.238612
SumSLLTraits_Core	58.182	4505.555	3.210154
SumSLLConstTraits	57.386	4568.054	3.254683
SumSLLConstTraits_Core	57.648	4547.294	3.239892
SumSLLFast_Multiply	74.970	3496.673	2.491338
SumSLLFast_AdvSimd	53.719	4879.927	3.476889
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	53.486	4901.191	3.492040

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	191.025	1372.299
SumSLLNetBcl	105.995	2473.172	1.802210
SumSLLNetBcl_Const	106.198	2468.456	1.798774
SumSLL_Basic	107.068	2448.377	1.784143
SumSLL_Base_Core	106.641	2458.194	1.791296
SumSLL_AdvSimd	132.447	1979.243	1.442282
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	132.274	1981.831	1.444168
SumSLLTraits_Core	106.208	2468.202	1.798589
SumSLLConstTraits	106.536	2460.619	1.793064
SumSLLConstTraits_Core	106.328	2465.419	1.796561
SumSLLFast_AdvSimd	106.471	2462.124	1.794160
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	106.526	2460.834	1.793220

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

