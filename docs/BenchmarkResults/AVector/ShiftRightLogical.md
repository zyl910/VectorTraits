# Benchmark - ShiftRightLogical
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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	309.626	846.647
SumSRL_Base	72.848	3598.525	4.250325
SumSRL_Base_Core	73.342	3574.287	4.221696
SumSRLTraits	73.008	3590.613	4.240979
SumSRLTraits_Core	72.674	3607.103	4.260457
SumSRLConstTraits	70.133	3737.831	4.414863
SumSRLConstTraits_Core	70.802	3702.475	4.373102
SumSRLFastTraits	70.710	3707.297	4.378798

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	313.941	835.010
SumSRL_Base	145.333	1803.743	2.160146
SumSRL_Base_Core	145.391	1803.031	2.159293
SumSRLTraits	144.846	1809.809	2.167411
SumSRLTraits_Core	144.770	1810.761	2.168551
SumSRLConstTraits	139.440	1879.974	2.251440
SumSRLConstTraits_Core	142.261	1842.697	2.206798
SumSRLFastTraits	141.311	1855.091	2.221640

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	315.736	830.262
SumSRL_Base	304.148	861.896	1.038101
SumSRL_Base_Core	307.891	851.418	1.025481
SumSRLTraits	313.716	835.610	1.006441
SumSRLTraits_Core	307.761	851.779	1.025915
SumSRLConstTraits	279.398	938.247	1.130061
SumSRLConstTraits_Core	279.196	938.926	1.130879
SumSRLFastTraits	283.082	926.035	1.115353

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	319.077	821.569
SumSRL_Base	606.487	432.234	0.526108
SumSRL_Base_Core	579.799	452.129	0.550324
SumSRLTraits	589.545	444.654	0.541226
SumSRLTraits_Core	608.155	431.048	0.524665
SumSRLConstTraits	527.498	496.958	0.604888
SumSRLConstTraits_Core	530.707	493.953	0.601231
SumSRLFastTraits	544.276	481.638	0.586242

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	308.076	850.908
SumSRL_Base	75.389	3477.239	4.086504
SumSRL_Base_Core	75.309	3480.918	4.090827
SumSRLTraits	75.247	3483.802	4.094216
SumSRLTraits_Core	75.436	3475.052	4.083933
SumSRLConstTraits	65.831	3982.087	4.679808
SumSRLConstTraits_Core	64.893	4039.611	4.747411
SumSRLFastTraits	73.857	3549.359	4.171261

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	315.442	831.037
SumSRL_Base	150.605	1740.608	2.094503
SumSRL_Base_Core	150.457	1742.316	2.096558
SumSRLTraits	150.679	1739.752	2.093473
SumSRLTraits_Core	151.514	1730.165	2.081937
SumSRLConstTraits	131.472	1993.908	2.399302
SumSRLConstTraits_Core	129.569	2023.200	2.434550
SumSRLFastTraits	146.977	1783.577	2.146207

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	316.734	827.647
SumSRL_Base	313.558	836.030	1.010129
SumSRL_Base_Core	312.857	837.904	1.012394
SumSRLTraits	313.707	835.632	1.009648
SumSRLTraits_Core	313.280	836.772	1.011026
SumSRLConstTraits	259.699	1009.416	1.219621
SumSRLConstTraits_Core	257.993	1016.089	1.227684
SumSRLFastTraits	293.345	893.637	1.079732

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	317.283	826.216
SumSRL_Base	560.122	468.012	0.566453
SumSRL_Base_Core	561.081	467.212	0.565485
SumSRLTraits	560.312	467.854	0.566261
SumSRLTraits_Core	562.064	466.395	0.564496
SumSRLConstTraits	484.067	541.545	0.655453
SumSRLConstTraits_Core	483.954	541.671	0.655605
SumSRLFastTraits	525.044	499.280	0.604298

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	236.669	1107.639
SumSRL_Base	77.401	3386.821	3.057694
SumSRL_Base_Core	77.572	3379.350	3.050949
SumSRL_Avx2	13.814	18977.043	17.132880
SumSRLTraits	13.648	19207.158	17.340633
SumSRLTraits_Core	6.310	41546.217	37.508813
SumSRLConstTraits	9.949	26348.525	23.788012
SumSRLConstTraits_Core	6.249	41946.846	37.870509
SumSRLFast_Avx2	9.987	26247.503	23.696807
SumSRLFastTraits	10.324	25391.091	22.923619

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	221.317	1184.474
SumSRL_Base	154.512	1696.598	1.432363
SumSRL_Base_Core	154.943	1691.875	1.428376
SumSRL_Avx2	15.380	17044.714	14.390106
SumSRLTraits	15.335	17094.914	14.432489
SumSRLTraits_Core	12.628	20759.720	17.526523
SumSRLConstTraits	15.250	17190.162	14.512902
SumSRLConstTraits_Core	12.934	20268.114	17.111482
SumSRLFast_Avx2	14.380	18229.443	15.390321
SumSRLFastTraits	14.939	17547.558	14.814636

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	197.323	1328.499
SumSRL_Base	310.617	843.947	0.635263
SumSRL_Base_Core	311.134	842.543	0.634206
SumSRL_Avx2	27.386	9572.282	7.205336
SumSRLTraits	29.636	8845.465	6.658240
SumSRLTraits_Core	24.077	10887.560	8.195384
SumSRLConstTraits	29.032	9029.577	6.796826
SumSRLConstTraits_Core	26.329	9956.463	7.494520
SumSRLFast_Avx2	29.136	8997.136	6.772407
SumSRLFastTraits	29.393	8918.505	6.713219

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	199.547	1313.698
SumSRL_Base	561.518	466.848	0.355370
SumSRL_Base_Core	564.059	464.746	0.353769
SumSRL_Avx2	61.145	4287.221	3.263476
SumSRLTraits	65.058	4029.360	3.067190
SumSRLTraits_Core	51.029	5137.119	3.910427
SumSRLConstTraits	62.253	4210.942	3.205412
SumSRLConstTraits_Core	49.755	5268.716	4.010600
SumSRLFast_Avx2	58.024	4517.861	3.439042
SumSRLFastTraits	58.618	4472.050	3.404170

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	239.822	1093.076
SumSRL_Base	73.601	3561.705	3.258423
SumSRL_Base_Core	73.592	3562.142	3.258823
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	14.336	18286.133	16.729055
SumSRLTraits	15.022	17450.727	15.964785
SumSRLTraits_Core	7.302	35902.165	32.845070
SumSRLConstTraits	8.731	30025.484	27.468792
SumSRLConstTraits_Core	7.342	35705.183	32.664861
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	8.181	32043.167	29.314668
SumSRLFastTraits	8.217	31904.295	29.187621

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	221.154	1185.345
SumSRL_Base	161.794	1620.230	1.366885
SumSRL_Base_Core	218.394	1200.329	1.012641
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	32.652	8028.518	6.773148
SumSRLTraits	24.257	10806.895	9.117086
SumSRLTraits_Core	20.717	12653.679	10.675100
SumSRLConstTraits	19.760	13266.484	11.192085
SumSRLConstTraits_Core	21.660	12102.954	10.210489
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	21.353	12276.400	10.356814
SumSRLFastTraits	19.791	13245.903	11.174722

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	296.035	885.517
SumSRL_Base	489.827	535.177	0.604367
SumSRL_Base_Core	547.571	478.740	0.540633
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	58.009	4519.026	5.103265
SumSRLTraits	55.720	4704.657	5.312895
SumSRLTraits_Core	35.914	7299.157	8.242823
SumSRLConstTraits	45.108	5811.441	6.562769
SumSRLConstTraits_Core	34.301	7642.354	8.630390
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	31.876	8223.823	9.287034
SumSRLFastTraits	33.298	7872.610	8.890414

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	238.953	1097.054
SumSRL_Base	699.697	374.654	0.341509
SumSRL_Base_Core	1018.254	257.445	0.234669
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	63.142	4151.675	3.784385
SumSRLTraits	60.246	4351.226	3.966282
SumSRLTraits_Core	49.095	5339.532	4.867154
SumSRLConstTraits	59.447	4409.737	4.019616
SumSRLConstTraits_Core	49.323	5314.806	4.844616
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	55.044	4762.421	4.341099
SumSRLFastTraits	55.414	4730.668	4.312155

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	195.898	1338.167
SumSRL_Base	73.569	3563.218	2.662760
SumSRL_Base_Core	73.660	3558.827	2.659478
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	14.308	18321.401	13.691413
SumSRLTraits	14.435	18160.101	13.570874
SumSRLTraits_Core	6.981	37553.104	28.063085
SumSRLConstTraits	6.586	39803.421	29.744726
SumSRLConstTraits_Core	7.104	36900.323	27.575268
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	7.934	33040.540	24.690888
SumSRLFastTraits	7.943	33001.409	24.661646

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	191.480	1369.041
SumSRL_Base	146.850	1785.114	1.303916
SumSRL_Base_Core	146.789	1785.860	1.304461
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	14.076	18623.897	13.603611
SumSRLTraits	14.488	18094.362	13.216818
SumSRLTraits_Core	12.811	20461.941	14.946189
SumSRLConstTraits	11.890	22047.957	16.104676
SumSRLConstTraits_Core	11.825	22168.490	16.192718
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	12.688	20660.533	15.091248
SumSRLFastTraits	12.829	20433.992	14.925774

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	159.809	1640.360
SumSRL_Base	293.399	893.471	0.544680
SumSRL_Base_Core	294.126	891.263	0.543334
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	28.925	9062.973	5.524991
SumSRLTraits	33.538	7816.410	4.765059
SumSRLTraits_Core	25.740	10184.166	6.208496
SumSRLConstTraits	27.733	9452.568	5.762497
SumSRLConstTraits_Core	24.723	10603.274	6.463993
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	27.103	9672.009	5.896273
SumSRLFastTraits	26.498	9892.826	6.030889

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	198.868	1318.183
SumSRL_Base	578.608	453.059	0.343700
SumSRL_Base_Core	579.192	452.603	0.343353
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	60.843	4308.506	3.268518
SumSRLTraits	62.702	4180.787	3.171627
SumSRLTraits_Core	45.087	5814.218	4.410780
SumSRLConstTraits	54.661	4795.833	3.638213
SumSRLConstTraits_Core	54.645	4797.255	3.639293
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	55.292	4741.085	3.596680
SumSRLFastTraits	55.114	4756.409	3.608306

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	175.853	1490.701
SumSRLNetBcl	225.766	1161.133	0.778918
SumSRLNetBcl_Const	224.792	1166.163	0.782292
SumSRL_Base	12.813	20459.656	13.724859
SumSRL_Base_Core	12.833	20426.575	13.702668
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	13.406	19554.165	13.117432
SumSRLTraits	13.238	19802.455	13.283992
SumSRLTraits_Core	7.180	36508.280	24.490685
SumSRLConstTraits	8.670	30236.571	20.283463
SumSRLConstTraits_Core	6.968	37621.102	25.237194
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	7.632	34347.616	23.041257
SumSRLFastTraits	7.696	34062.504	22.849997

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	162.108	1617.095
SumSRLNetBcl	12.722	20605.171	12.742093
SumSRLNetBcl_Const	12.691	20656.035	12.773547
SumSRL_Base	14.528	18044.091	11.158339
SumSRL_Base_Core	14.778	17738.917	10.969622
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	15.632	16769.637	10.370226
SumSRLTraits	15.781	16611.687	10.272551
SumSRLTraits_Core	13.651	19203.883	11.875546
SumSRLConstTraits	12.353	21220.289	13.122477
SumSRLConstTraits_Core	12.609	20790.294	12.856571
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	14.067	18635.788	11.524240
SumSRLFastTraits	13.148	19938.476	12.329813

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	121.154	2163.718
SumSRLNetBcl	28.767	9112.712	4.211598
SumSRLNetBcl_Const	24.753	10590.438	4.894555
SumSRL_Base	28.053	9344.480	4.318713
SumSRL_Base_Core	28.227	9286.934	4.292117
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	30.872	8491.423	3.924458
SumSRLTraits	31.492	8324.032	3.847096
SumSRLTraits_Core	25.738	10185.192	4.707263
SumSRLConstTraits	26.265	9980.668	4.612739
SumSRLConstTraits_Core	24.207	10829.387	5.004989
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	27.761	9442.923	4.364211
SumSRLFastTraits	27.564	9510.351	4.395374

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	165.249	1586.358
SumSRLNetBcl	62.778	4175.718	2.632268
SumSRLNetBcl_Const	52.455	4997.459	3.150272
SumSRL_Base	59.949	4372.755	2.756475
SumSRL_Base_Core	57.383	4568.351	2.879774
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	64.374	4072.185	2.567003
SumSRLTraits	62.752	4177.428	2.633346
SumSRLTraits_Core	49.846	5259.045	3.315170
SumSRLConstTraits	49.645	5280.386	3.328623
SumSRLConstTraits_Core	52.608	4982.963	3.141134
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	57.799	4535.425	2.859018
SumSRLFastTraits	57.987	4520.710	2.849742

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	429.294	610.640
SumSRL_Base	87.364	3000.591	4.913848
SumSRL_Base_Core	87.150	3007.968	4.925929
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	69.315	3781.946	6.193415
SumSRLTraits_Core	87.376	3000.198	4.913204
SumSRLConstTraits	177.548	1476.467	2.417902
SumSRLConstTraits_Core	74.469	3520.192	5.764761
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	67.898	3860.872	6.322667

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	432.923	605.521
SumSRL_Base	175.405	1494.509	2.468135
SumSRL_Base_Core	175.556	1493.219	2.466004
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	139.112	1884.412	3.112048
SumSRLTraits_Core	176.147	1488.214	2.457739
SumSRLConstTraits	149.167	1757.385	2.902267
SumSRLConstTraits_Core	149.184	1757.182	2.901932
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	137.693	1903.830	3.144117

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	351.001	746.848
SumSRL_Base	350.373	748.185	1.001790
SumSRL_Base_Core	350.688	747.514	1.000892
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	280.218	935.500	1.252598
SumSRLTraits_Core	350.605	747.690	1.001128
SumSRLConstTraits	299.879	874.167	1.170475
SumSRLConstTraits_Core	300.019	873.757	1.169926
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	273.960	956.871	1.281213

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	353.297	741.993
SumSRL_Base	533.244	491.602	0.662543
SumSRL_Base_Core	1318.600	198.805	0.267934
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	561.847	466.575	0.628813
SumSRLTraits_Core	546.027	480.094	0.647033
SumSRLConstTraits	540.737	484.790	0.653362
SumSRLConstTraits_Core	550.329	476.341	0.641975
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	561.254	467.068	0.629478

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	429.664	610.113
SumSRL_Base	86.543	3029.044	4.964724
SumSRL_Base_Core	86.953	3014.782	4.941347
SumSRL_AdvSimd	22.221	11796.979	19.335718
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	23.229	11284.988	18.496544
SumSRLTraits_Core	16.488	15899.247	26.059499
SumSRLConstTraits	86.339	3036.213	4.976474
SumSRLConstTraits_Core	16.487	15900.418	26.061418
SumSRLFast_AdvSimd	19.877	13188.607	21.616652
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	19.854	13203.309	21.640748

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
Check-SumSRLConstTraits_Core	Fail! Check `SumSRLConstTraits_Core` fail! 40922!=20269
SumSRLScalar	433.702	604.433
SumSRL_Base	174.125	1505.496	2.490755
SumSRL_Base_Core	355.967	736.428	1.218377
SumSRL_AdvSimd	44.426	5900.704	9.762372
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	44.383	5906.370	9.771745
SumSRLTraits_Core	33.074	7926.104	13.113278
SumSRLConstTraits	185.000	1416.998	2.344340
SumSRLConstTraits_Core	33.294	7873.564	13.026354
SumSRLFast_AdvSimd	40.174	6525.191	10.795549
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	33.300	7872.079	13.023898

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	349.879	749.242
SumSRL_Base	358.763	730.688	0.975235
SumSRL_Base_Core	359.106	729.990	0.974304
SumSRL_AdvSimd	80.461	3258.035	4.348440
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	79.867	3282.244	4.380752
SumSRLTraits_Core	66.715	3929.288	5.244349
SumSRLConstTraits	373.331	702.176	0.937182
SumSRLConstTraits_Core	67.584	3878.814	5.176983
SumSRLFast_AdvSimd	67.625	3876.461	5.173842
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	67.561	3880.093	5.178689

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	358.007	732.231
SumSRL_Base	1221.127	214.674	0.293178
SumSRL_Base_Core	547.395	478.893	0.654020
SumSRL_AdvSimd	175.860	1490.641	2.035752
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	177.965	1473.005	2.011668
SumSRLTraits_Core	133.566	1962.650	2.680370
SumSRLConstTraits	689.401	380.249	0.519302
SumSRLConstTraits_Core	123.537	2121.983	2.897970
SumSRLFast_AdvSimd	133.498	1963.659	2.681748
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	133.290	1966.726	2.685937

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	388.748	674.329
SumSRL_Base	81.110	3231.956	4.792844
SumSRL_Base_Core	80.473	3257.534	4.830776
SumSRL_AdvSimd	23.063	11366.315	16.855733
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	23.041	11377.277	16.871988
SumSRLTraits_Core	16.483	15903.453	23.584103
SumSRLConstTraits	16.480	15906.459	23.588562
SumSRLConstTraits_Core	15.405	17017.062	25.235535
SumSRLFast_AdvSimd	15.374	17050.593	25.285260
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	15.398	17024.945	25.247226

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	431.582	607.403
SumSRL_Base	162.510	1613.095	2.655725
SumSRL_Base_Core	161.824	1619.935	2.666986
SumSRL_AdvSimd	43.943	5965.610	9.821507
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	43.915	5969.352	9.827666
SumSRLTraits_Core	32.981	7948.216	13.085577
SumSRLConstTraits	32.992	7945.672	13.081389
SumSRLConstTraits_Core	32.978	7949.162	13.087136
SumSRLFast_AdvSimd	32.957	7954.154	13.095353
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	30.815	8506.959	14.005466

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	350.667	747.558
SumSRL_Base	323.666	809.921	1.083423
SumSRL_Base_Core	323.601	810.084	1.083641
SumSRL_AdvSimd	80.189	3269.073	4.373005
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	80.087	3273.260	4.378605
SumSRLTraits_Core	67.258	3897.584	5.213756
SumSRLConstTraits	63.178	4149.296	5.550470
SumSRLConstTraits_Core	63.195	4148.155	5.548943
SumSRLFast_AdvSimd	67.161	3903.209	5.221281
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	63.151	4151.089	5.552867

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	353.131	742.342
SumSRL_Base	540.390	485.101	0.653474
SumSRL_Base_Core	1263.694	207.443	0.279443
SumSRL_AdvSimd	184.841	1418.217	1.910463
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	184.430	1421.374	1.914716
SumSRLTraits_Core	123.849	2116.645	2.851306
SumSRLConstTraits	123.621	2120.543	2.856557
SumSRLConstTraits_Core	132.180	1983.237	2.671594
SumSRLFast_AdvSimd	158.497	1653.939	2.228001
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	158.489	1654.017	2.228107

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	294.784	889.274
SumSRLNetBcl	13.361	19619.792	22.062703
SumSRLNetBcl_Const	13.379	19594.416	22.034167
SumSRL_Base	36.337	7214.323	8.112597
SumSRL_Base_Core	36.360	7209.628	8.107318
SumSRL_AdvSimd	19.888	13181.038	14.822243
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	19.852	13204.921	14.849100
SumSRLTraits_Core	13.373	19602.598	22.043368
SumSRLConstTraits	13.474	19455.399	21.877841
SumSRLConstTraits_Core	13.453	19486.464	21.912773
SumSRLFast_AdvSimd	13.347	19640.172	22.085620
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	13.359	19623.445	22.066811

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	318.802	822.278
SumSRLNetBcl	26.794	9783.640	11.898210
SumSRLNetBcl_Const	26.775	9790.685	11.906779
SumSRL_Base	26.771	9791.961	11.908330
SumSRL_Base_Core	26.786	9786.423	11.901596
SumSRL_AdvSimd	39.837	6580.338	8.002569
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	39.716	6600.497	8.027085
SumSRLTraits_Core	26.777	9789.885	11.905805
SumSRLConstTraits	26.960	9723.278	11.824803
SumSRLConstTraits_Core	26.977	9717.302	11.817535
SumSRLFast_AdvSimd	26.778	9789.686	11.905564
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	26.779	9789.057	11.904799

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	224.169	1169.405
SumSRLNetBcl	55.109	4756.804	4.067711
SumSRLNetBcl_Const	55.112	4756.579	4.067519
SumSRL_Base	55.152	4753.079	4.064526
SumSRL_Base_Core	55.086	4758.808	4.069425
SumSRL_AdvSimd	79.886	3281.485	2.806114
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	79.874	3281.959	2.806520
SumSRLTraits_Core	55.359	4735.310	4.049331
SumSRLConstTraits	55.616	4713.429	4.030620
SumSRLConstTraits_Core	55.454	4727.238	4.042429
SumSRLFast_AdvSimd	55.215	4747.729	4.059951
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	55.117	4756.096	4.067106

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	220.765	1187.433
SumSRLNetBcl	107.669	2434.716	2.050403
SumSRLNetBcl_Const	107.410	2440.583	2.055344
SumSRL_Base	107.512	2438.281	2.053405
SumSRL_Base_Core	107.533	2437.791	2.052993
SumSRL_AdvSimd	158.773	1651.057	1.390442
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	158.758	1651.219	1.390579
SumSRLTraits_Core	107.390	2441.045	2.055733
SumSRLConstTraits	107.497	2438.627	2.053697
SumSRLConstTraits_Core	107.453	2439.606	2.054521
SumSRLFast_AdvSimd	109.102	2402.751	2.023483
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	108.543	2415.114	2.033895

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

