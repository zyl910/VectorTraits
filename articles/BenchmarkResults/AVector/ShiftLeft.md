# Benchmark - ShiftLeft
([← Back](README.md))

See [Group](ShiftLeft_Group.md)

## X86

### AMD Ryzen 7 7840H
`AMD Ryzen 7 7840H w/ Radeon 780M Graphics`

#### .NET Framework

```
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9232.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks/bin/Release/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	226.195	1158.930
SumSLL_Basic	19.797	13241.743	11.425834
SumSLL_Base_Core	3.896	67289.841	58.062034
SumSLL_Multiply	19.830	13219.514	11.406653
SumSLLTraits	19.857	13201.590	11.391187
SumSLLTraits_Core	3.848	68122.389	58.780410
SumSLLConstTraits	17.624	14873.913	12.834176
SumSLLConstTraits_Core	3.892	67352.024	58.115689
SumSLLFast_Multiply	17.301	15152.225	13.074321
SumSLLFastTraits	17.423	15045.551	12.982276

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	222.323	1179.113
SumSLL_Basic	34.740	7545.839	6.399592
SumSLL_Base_Core	6.051	43319.874	36.739387
SumSLL_Base_Core_Element	35.182	7451.170	6.319303
SumSLL_Base_Core_Mov	40.157	6527.918	5.536298
SumSLL_Multiply	35.113	7465.650	6.331583
SumSLLTraits	34.282	7646.653	6.485091
SumSLLTraits_Core	6.155	42588.160	36.118824
SumSLLConstTraits	39.396	6654.055	5.643273
SumSLLConstTraits_Core	6.065	43220.783	36.655348
SumSLLFast_Multiply	34.747	7544.444	6.398408
SumSLLFastTraits	30.162	8691.236	7.370998

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	179.124	1463.480
SumSLL_Basic	60.978	4298.977	2.937503
SumSLL_Base_Core	14.084	18612.821	12.718190
SumSLL_Multiply	60.410	4339.441	2.965152
SumSLLTraits	59.911	4375.528	2.989810
SumSLLTraits_Core	13.245	19792.313	13.524141
SumSLLConstTraits	59.844	4380.457	2.993178
SumSLLConstTraits_Core	14.330	18293.329	12.499881
SumSLLFast_Multiply	60.103	4361.613	2.980302
SumSLLFastTraits	59.508	4405.177	3.010069

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	179.025	1464.290
SumSLL_Basic	504.276	519.842	0.355013
SumSLL_Base_Core	504.154	519.968	0.355099
SumSLLTraits	502.376	521.808	0.356356
SumSLLTraits_Core	504.624	519.484	0.354769
SumSLLConstTraits	481.383	544.565	0.371897
SumSLLConstTraits_Core	482.601	543.190	0.370958
SumSLLFastTraits	484.545	541.011	0.369470

```

#### .NET Core 2.1

```
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:	.NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	225.493	1162.537
SumSLL_Basic	19.848	13207.349	11.360800
SumSLL_Base_Core	3.866	67800.170	58.320878
SumSLL_Multiply	17.411	15056.255	12.951206
SumSLLTraits	17.413	15054.128	12.949377
SumSLLTraits_Core	3.903	67170.341	57.779106
SumSLLConstTraits	19.792	13244.690	11.392920
SumSLLConstTraits_Core	3.886	67462.939	58.030796
SumSLLFast_Multiply	17.454	15019.257	12.919381
SumSLLFastTraits	17.377	15085.911	12.976716

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	222.514	1178.102
SumSLL_Basic	30.081	8714.679	7.397221
SumSLL_Base_Core	6.140	42691.061	36.237159
SumSLL_Base_Core_Element	30.215	8675.936	7.364335
SumSLL_Base_Core_Mov	39.625	6615.670	5.615533
SumSLL_Multiply	30.156	8692.835	7.378679
SumSLLTraits	34.600	7576.387	6.431012
SumSLLTraits_Core	6.159	42562.830	36.128313
SumSLLConstTraits	34.417	7616.741	6.465266
SumSLLConstTraits_Core	6.453	40623.888	34.482494
SumSLLFast_Multiply	34.432	7613.470	6.462490
SumSLLFastTraits	34.383	7624.219	6.471614

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	180.176	1454.936
SumSLL_Basic	60.518	4331.705	2.977249
SumSLL_Base_Core	13.115	19987.950	13.738030
SumSLL_Multiply	68.980	3800.297	2.612003
SumSLLTraits	68.907	3804.305	2.614758
SumSLLTraits_Core	13.111	19994.030	13.742209
SumSLLConstTraits	78.802	3326.629	2.286444
SumSLLConstTraits_Core	13.144	19943.893	13.707750
SumSLLFast_Multiply	69.090	3794.213	2.607822
SumSLLFastTraits	68.910	3804.142	2.614646

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	178.990	1464.569
SumSLL_Basic	497.380	527.050	0.359867
SumSLL_Base_Core	499.709	524.593	0.358189
SumSLLTraits	500.107	524.175	0.357904
SumSLLTraits_Core	499.807	524.490	0.358119
SumSLLConstTraits	479.473	546.734	0.373307
SumSLLConstTraits_Core	480.167	545.943	0.372767
SumSLLFastTraits	478.216	548.171	0.374288

```

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	173.904	1507.403
SumSLL_Basic	10.475	25024.842	16.601295
SumSLL_Base_Core	3.425	76530.251	50.769604
SumSLL_Multiply	10.362	25299.812	16.783708
SumSLL_Avx2	7.472	35084.309	23.274672
SumSLLTraits	7.633	34345.556	22.784588
SumSLLTraits_Core	3.070	85378.339	56.639360
SumSLLConstTraits	5.546	47270.691	31.359027
SumSLLConstTraits_Core	3.103	84471.420	56.037716
SumSLL128Traits	15.010	17464.506	11.585824
SumSLL128Traits_Core	6.076	43145.557	28.622444
SumSLL128ConstTraits	13.682	19159.479	12.710257
SumSLL128ConstTraits_Core	5.997	43709.593	28.996622
SumSLLFast_Multiply	6.033	43452.725	28.826217
SumSLLFast_Avx2	6.774	38696.307	25.670844
SumSLLFastTraits	6.769	38727.754	25.691706

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	184.865	1418.032
SumSLL_Basic	14.580	17980.227	12.679700
SumSLL_Base_Core	6.042	43384.468	30.594835
SumSLL_Base_Core_Element	16.239	16143.067	11.384131
SumSLL_Base_Core_Mov	14.950	17534.584	12.365433
SumSLL_Multiply	14.738	17787.188	12.543569
SumSLL_Avx2	8.045	32585.584	22.979435
SumSLLTraits	8.068	32493.293	22.914351
SumSLLTraits_Core	6.068	43199.688	30.464527
SumSLLConstTraits	7.772	33729.258	23.785956
SumSLLConstTraits_Core	6.392	41013.383	28.922740
SumSLL128Traits	14.959	17524.340	12.358208
SumSLL128Traits_Core	11.609	22581.624	15.924617
SumSLL128ConstTraits	14.926	17563.474	12.385806
SumSLL128ConstTraits_Core	11.915	22001.606	15.515587
SumSLLFast_Multiply	9.102	28799.847	20.309724
SumSLLFast_Avx2	7.724	33939.352	23.934115
SumSLLFastTraits	7.557	34687.190	24.461493

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	168.044	1559.976
SumSLL_Basic	19.957	13135.292	8.420190
SumSLL_Base_Core	12.723	20604.687	13.208338
SumSLL_Multiply	20.058	13069.043	8.377722
SumSLL_Avx2	16.477	15910.132	10.198961
SumSLLTraits	16.344	16038.922	10.281520
SumSLLTraits_Core	11.517	22761.253	14.590774
SumSLLConstTraits	16.381	16002.972	10.258475
SumSLLConstTraits_Core	13.736	19084.173	12.233634
SumSLL128Traits	29.964	8748.598	5.608163
SumSLL128Traits_Core	20.259	12939.748	8.294839
SumSLL128ConstTraits	30.773	8518.578	5.460712
SumSLL128ConstTraits_Core	20.303	12911.830	8.276942
SumSLLFast_Multiply	16.988	15430.839	9.891717
SumSLLFast_Avx2	16.147	16235.154	10.407312
SumSLLFastTraits	16.010	16373.592	10.496055

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	155.350	1687.438
SumSLL_Basic	504.951	519.148	0.307654
SumSLL_Base_Core	500.603	523.656	0.310326
SumSLL_Avx2	31.912	8214.588	4.868082
SumSLLTraits	32.700	8016.616	4.750761
SumSLLTraits_Core	26.026	10072.464	5.969086
SumSLLConstTraits	31.243	8390.482	4.972319
SumSLLConstTraits_Core	25.573	10250.939	6.074853
SumSLL128Traits	60.868	4306.777	2.552258
SumSLL128Traits_Core	41.585	6303.876	3.735767
SumSLL128ConstTraits	56.075	4674.853	2.770384
SumSLL128ConstTraits_Core	40.248	6513.238	3.859838
SumSLLFast_Avx2	31.838	8233.632	4.879368
SumSLLFastTraits	32.072	8173.518	4.843743

```

#### .NET 5.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	5.0.17
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.17\
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
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
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	171.353	1529.852
SumSLL_Basic	11.197	23412.700	15.303903
SumSLL_Base_Core	3.433	76359.137	49.912775
SumSLL_Multiply	11.116	23581.765	15.414414
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	7.474	35073.321	22.925964
SumSLLTraits	7.453	35173.054	22.991155
SumSLLTraits_Core	3.080	85108.728	55.632017
SumSLLConstTraits	3.795	69067.059	45.146249
SumSLLConstTraits_Core	3.124	83904.666	54.844972
SumSLL128Traits	14.886	17610.251	11.511085
SumSLL128Traits_Core	6.033	43454.469	28.404369
SumSLL128ConstTraits	9.879	26535.458	17.345119
SumSLL128ConstTraits_Core	5.968	43924.635	28.711697
SumSLLFast_Multiply	5.984	43807.761	28.635302
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	4.299	60984.258	39.862859
SumSLLFastTraits	4.359	60138.120	39.309774

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	185.713	1411.558
SumSLL_Basic	14.670	17869.757	12.659601
SumSLL_Base_Core	6.318	41490.237	29.393228
SumSLL_Base_Core_Element	15.761	16632.670	11.783202
SumSLL_Base_Core_Mov	14.831	17675.758	12.522165
SumSLL_Multiply	14.625	17924.490	12.698375
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	7.933	33044.268	23.409789
SumSLLTraits	8.190	32008.890	22.676289
SumSLLTraits_Core	6.279	41750.420	29.577551
SumSLLConstTraits	5.864	44707.598	31.672526
SumSLLConstTraits_Core	5.866	44691.037	31.660794
SumSLL128Traits	14.926	17563.021	12.442297
SumSLL128Traits_Core	11.111	23592.948	16.714123
SumSLL128ConstTraits	11.782	22250.319	15.762954
SumSLL128ConstTraits_Core	11.703	22400.069	15.869043
SumSLLFast_Multiply	9.189	28527.118	20.209672
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	5.872	44640.885	31.625265
SumSLLFastTraits	5.828	44978.236	31.864256

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	155.661	1684.073
SumSLL_Basic	19.821	13225.361	7.853199
SumSLL_Base_Core	13.764	19045.372	11.309113
SumSLL_Multiply	20.057	13069.714	7.760776
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	16.487	15899.566	9.441138
SumSLLTraits	16.397	15987.260	9.493211
SumSLLTraits_Core	11.255	23291.887	13.830687
SumSLLConstTraits	13.622	19244.608	11.427419
SumSLLConstTraits_Core	19.838	13214.099	7.846512
SumSLL128Traits	30.187	8683.954	5.156519
SumSLL128Traits_Core	20.196	12980.278	7.707670
SumSLL128ConstTraits	24.053	10898.434	6.471474
SumSLL128ConstTraits_Core	20.079	13055.798	7.752513
SumSLLFast_Multiply	16.775	15626.693	9.279106
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	12.437	21078.101	12.516144
SumSLLFastTraits	13.627	19237.741	11.423341

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	155.592	1684.814
SumSLL_Basic	478.931	547.352	0.324874
SumSLL_Base_Core	485.705	539.719	0.320343
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	32.391	8093.035	4.803518
SumSLLTraits	31.830	8235.642	4.888160
SumSLLTraits_Core	25.885	10127.320	6.010942
SumSLLConstTraits	31.728	8262.187	4.903916
SumSLLConstTraits_Core	25.575	10249.968	6.083738
SumSLL128Traits	60.379	4341.621	2.576914
SumSLL128Traits_Core	40.417	6485.925	3.849639
SumSLL128ConstTraits	57.331	4572.462	2.713927
SumSLL128ConstTraits_Core	40.260	6511.238	3.864662
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	28.463	9210.144	5.466564
SumSLLFastTraits	28.150	9312.483	5.527306

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.29
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.29\
RuntimeInformation.FrameworkDescription:	.NET 6.0.29
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.29/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	173.780	1508.479
SumSLL_Basic	10.629	24663.094	16.349643
SumSLL_Base_Core	3.870	67728.945	44.898831
SumSLL_Multiply	10.547	24854.766	16.476706
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	8.643	30331.440	20.107299
SumSLLTraits	8.524	30753.325	20.386975
SumSLLTraits_Core	3.656	71706.672	47.535742
SumSLLConstTraits	3.630	72211.591	47.870463
SumSLLConstTraits_Core	3.389	77351.525	51.277825
SumSLL128Traits	17.035	15388.614	10.201410
SumSLL128Traits_Core	6.259	41881.908	27.764328
SumSLL128ConstTraits	7.481	35040.946	23.229322
SumSLL128ConstTraits_Core	6.385	41056.827	27.217366
SumSLLFast_Multiply	7.160	36610.511	24.269817
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	3.756	69790.746	46.265638
SumSLLFastTraits	3.711	70641.558	46.829658

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	202.318	1295.705
SumSLL_Basic	11.026	23775.220	18.349255
SumSLL_Base_Core	6.841	38316.864	29.572215
SumSLL_Base_Core_Element	13.495	19425.648	14.992340
SumSLL_Base_Core_Mov	12.072	21714.821	16.759080
SumSLL_Multiply	10.562	24820.583	19.156046
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	8.692	30160.500	23.277291
SumSLLTraits	8.505	30823.012	23.788605
SumSLLTraits_Core	6.175	42450.753	32.762671
SumSLLConstTraits	5.622	46630.658	35.988641
SumSLLConstTraits_Core	5.405	48501.402	37.432445
SumSLL128Traits	15.220	17223.530	13.292788
SumSLL128Traits_Core	11.046	23732.976	18.316652
SumSLL128ConstTraits	9.867	26568.219	20.504838
SumSLL128ConstTraits_Core	9.866	26569.739	20.506011
SumSLLFast_Multiply	8.109	32328.200	24.950280
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	6.560	39963.668	30.843187
SumSLLFastTraits	6.636	39504.105	30.488505

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	106.330	2465.377
SumSLL_Basic	18.718	14005.275	5.680784
SumSLL_Base_Core	12.889	20339.215	8.249941
SumSLL_Multiply	18.906	13865.790	5.624207
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	16.082	16300.781	6.611882
SumSLLTraits	16.369	16014.192	6.495636
SumSLLTraits_Core	10.929	23985.510	9.728942
SumSLLConstTraits	10.945	23951.437	9.715122
SumSLLConstTraits_Core	11.120	23575.133	9.562486
SumSLL128Traits	30.259	8663.424	3.514036
SumSLL128Traits_Core	19.861	13198.866	5.353691
SumSLL128ConstTraits	20.276	12928.864	5.244173
SumSLL128ConstTraits_Core	20.273	12930.918	5.245006
SumSLLFast_Multiply	16.402	15982.041	6.482595
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	14.319	18307.665	7.425909
SumSLLFastTraits	14.382	18227.790	7.393510

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	105.338	2488.596
SumSLL_Basic	479.278	546.957	0.219785
SumSLL_Base_Core	480.833	545.187	0.219074
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	32.004	8190.858	3.291357
SumSLLTraits	32.421	8085.607	3.249064
SumSLLTraits_Core	25.873	10131.979	4.071363
SumSLLConstTraits	25.503	10278.989	4.130437
SumSLLConstTraits_Core	25.436	10306.207	4.141374
SumSLL128Traits	60.966	4299.816	1.727808
SumSLL128Traits_Core	40.088	6539.145	2.627644
SumSLL128ConstTraits	40.153	6528.608	2.623410
SumSLL128ConstTraits_Core	40.041	6546.894	2.630758
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	28.252	9278.765	3.728514
SumSLLFastTraits	28.164	9307.613	3.740106

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.18
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.18\
RuntimeInformation.FrameworkDescription:	.NET 7.0.18
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.18/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	156.247	1677.757
SumSLLNetBcl	165.107	1587.722	0.946336
SumSLLNetBcl_Const	164.313	1595.398	0.950911
SumSLL_Basic	8.787	29834.283	17.782239
SumSLL_Base_Core	3.357	78097.864	46.548960
SumSLL_Multiply	8.718	30070.786	17.923203
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	6.339	41355.116	24.649044
SumSLLTraits	6.242	41998.816	25.032711
SumSLLTraits_Core	3.051	85921.206	51.211936
SumSLLConstTraits	3.182	82376.139	49.098957
SumSLLConstTraits_Core	4.655	56313.666	33.564844
SumSLL128Traits	13.617	19251.533	11.474563
SumSLL128Traits_Core	5.977	43860.353	26.142249
SumSLL128ConstTraits	6.054	43301.003	25.808858
SumSLL128ConstTraits_Core	8.345	31411.520	18.722325
SumSLLFast_Multiply	4.554	57561.534	34.308615
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	3.174	82595.651	49.229793
SumSLLFastTraits	3.185	82310.926	49.060087

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	166.913	1570.545
SumSLLNetBcl	6.658	39374.300	25.070462
SumSLLNetBcl_Const	5.148	50920.501	32.422176
SumSLL_Basic	6.646	39442.007	25.113572
SumSLL_Base_Core	6.748	38850.396	24.736881
SumSLL_Base_Core_Element	10.816	24236.068	15.431625
SumSLL_Base_Core_Mov	7.810	33565.398	21.371809
SumSLL_Multiply	9.916	26437.499	16.833323
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	7.936	33030.816	21.031430
SumSLLTraits	6.614	39634.050	25.235850
SumSLLTraits_Core	5.862	44715.654	28.471417
SumSLLConstTraits	6.137	42713.244	27.196440
SumSLLConstTraits_Core	6.222	42128.494	26.824116
SumSLL128Traits	15.057	17409.903	11.085259
SumSLL128Traits_Core	11.321	23154.652	14.743064
SumSLL128ConstTraits	9.810	26721.196	17.013959
SumSLL128ConstTraits_Core	9.872	26555.490	16.908451
SumSLLFast_Multiply	8.134	32229.219	20.521036
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	6.703	39108.753	24.901383
SumSLLFastTraits	6.705	39096.035	24.893285

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	87.482	2996.555
SumSLLNetBcl	12.165	21548.327	7.191032
SumSLLNetBcl_Const	11.458	22878.867	7.635055
SumSLL_Basic	12.196	21494.027	7.172912
SumSLL_Base_Core	12.272	21361.797	7.128784
SumSLL_Multiply	18.384	14259.261	4.758551
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	15.724	16671.905	5.563690
SumSLLTraits	12.161	21556.913	7.193897
SumSLLTraits_Core	11.404	22986.994	7.671139
SumSLLConstTraits	11.463	22869.058	7.631782
SumSLLConstTraits_Core	12.432	21086.849	7.037030
SumSLL128Traits	23.701	11060.301	3.691005
SumSLL128Traits_Core	19.973	13124.813	4.379967
SumSLL128ConstTraits	20.775	12618.501	4.211002
SumSLL128ConstTraits_Core	20.998	12484.024	4.166125
SumSLLFast_Multiply	16.251	16130.549	5.383030
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	15.546	16862.446	5.627277
SumSLLFastTraits	12.223	21447.109	7.157254

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	96.468	2717.422
SumSLLNetBcl	28.037	9349.849	3.440705
SumSLLNetBcl_Const	26.169	10017.360	3.686347
SumSLL_Basic	28.289	9266.590	3.410066
SumSLL_Base_Core	28.461	9210.611	3.389466
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	31.777	8249.532	3.035793
SumSLLTraits	31.560	8306.128	3.056620
SumSLLTraits_Core	25.666	10213.689	3.758595
SumSLLConstTraits	25.730	10188.180	3.749208
SumSLLConstTraits_Core	25.589	10244.260	3.769845
SumSLL128Traits	61.135	4287.973	1.577956
SumSLL128Traits_Core	39.741	6596.300	2.427411
SumSLL128ConstTraits	39.653	6610.880	2.432776
SumSLL128ConstTraits_Core	39.726	6598.881	2.428361
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	29.154	8991.723	3.308917
SumSLLFastTraits	29.259	8959.314	3.296990

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.4
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.4\
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector512.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.4/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844161	# 0x8177F7FF
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Avx512BW, Avx512CD, Avx512DQ, Avx512F, Avx512Vbmi, Avx512VL, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2, Avx512VL
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vector512s.Instance:	WVectorTraits512Avx512	// Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi, Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	152.857	1714.959
SumSLLNetBcl	163.563	1602.705	0.934544
SumSLLNetBcl_Const	159.762	1640.845	0.956784
SumSLL_Basic	8.187	32019.641	18.670788
SumSLL_Base_Core	3.259	80445.723	46.908241
SumSLL_Multiply	7.984	32834.447	19.145905
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	3.166	82787.183	48.273556
SumSLLTraits	3.183	82366.957	48.028521
SumSLLTraits_Core	2.522	103940.833	60.608339
SumSLLConstTraits	2.526	103768.539	60.507874
SumSLLConstTraits_Core	2.515	104218.248	60.770101
SumSLL128Traits	6.403	40937.707	23.870950
SumSLL128Traits_Core	4.933	53136.481	30.984107
SumSLL128ConstTraits	4.993	52498.193	30.611918
SumSLL128ConstTraits_Core	4.908	53406.905	31.141792
SumSLL512Bcl	522.230	501.971	0.292701
SumSLL512Traits	2.562	102336.376	59.672774
SumSLLFast_Multiply	4.280	61251.942	35.716267
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	3.213	81590.400	47.575708
SumSLLFastTraits	2.638	99379.677	57.948710

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	153.749	1705.016
SumSLLNetBcl	5.859	44739.814	26.240115
SumSLLNetBcl_Const	5.300	49458.678	29.007752
SumSLL_Basic	5.800	45198.149	26.508931
SumSLL_Base_Core	5.271	49734.859	29.169733
SumSLL_Base_Core_Element	5.802	45180.696	26.498695
SumSLL_Base_Core_Mov	7.784	33678.195	19.752423
SumSLL_Multiply	7.973	32879.805	19.284164
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	7.340	35712.430	20.945512
SumSLLTraits	5.297	49491.506	29.027006
SumSLLTraits_Core	6.191	42340.461	24.832883
SumSLLConstTraits	5.261	49829.677	29.225345
SumSLLConstTraits_Core	5.263	49805.196	29.210987
SumSLL128Traits	9.808	26727.920	15.676053
SumSLL128Traits_Core	11.538	22720.455	13.325656
SumSLL128ConstTraits	9.844	26630.890	15.619145
SumSLL128ConstTraits_Core	9.846	26624.517	15.615407
SumSLL512Bcl	5.360	48909.671	28.685757
SumSLL512Traits	5.305	49414.521	28.981854
SumSLLFast_Multiply	7.938	33024.721	19.369157
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	5.830	44968.382	26.374172
SumSLLFastTraits	5.301	49453.894	29.004946

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	87.557	2993.977
SumSLLNetBcl	13.322	19677.030	6.572205
SumSLLNetBcl_Const	12.816	20453.920	6.831689
SumSLL_Basic	13.363	19617.527	6.552331
SumSLL_Base_Core	12.721	20607.885	6.883114
SumSLL_Multiply	13.550	19346.380	6.461767
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	15.761	16632.341	5.555267
SumSLLTraits	12.662	20703.390	6.915013
SumSLLTraits_Core	13.981	18749.999	6.262573
SumSLLConstTraits	12.648	20726.908	6.922868
SumSLLConstTraits_Core	12.734	20585.988	6.875801
SumSLL128Traits	20.016	13096.959	4.374435
SumSLL128Traits_Core	20.927	12526.460	4.183887
SumSLL128ConstTraits	20.440	12825.056	4.283619
SumSLL128ConstTraits_Core	20.266	12935.403	4.320475
SumSLL512Bcl	12.534	20914.791	6.985622
SumSLL512Traits	12.332	21257.442	7.100069
SumSLLFast_Multiply	13.363	19616.557	6.552007
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	13.187	19879.184	6.639725
SumSLLFastTraits	12.597	20810.343	6.950736

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	87.790	2986.043
SumSLLNetBcl	24.465	10715.263	3.588448
SumSLLNetBcl_Const	25.222	10393.349	3.480642
SumSLL_Basic	24.716	10606.342	3.551972
SumSLL_Base_Core	24.730	10600.385	3.549977
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	29.659	8838.482	2.959931
SumSLLTraits	29.990	8741.160	2.927339
SumSLLTraits_Core	26.027	10071.812	3.372962
SumSLLConstTraits	24.183	10840.139	3.630268
SumSLLConstTraits_Core	24.425	10732.499	3.594221
SumSLL128Traits	49.249	5322.785	1.782555
SumSLL128Traits_Core	39.185	6689.827	2.240365
SumSLL128ConstTraits	39.336	6664.193	2.231780
SumSLL128ConstTraits_Core	39.234	6681.550	2.237593
SumSLL512Bcl	24.366	10758.816	3.603034
SumSLL512Traits	29.529	8877.605	2.973033
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	24.445	10723.790	3.591304
SumSLLFastTraits	24.925	10517.267	3.522141

```

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
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	
Vector128s.Instance:	WVectorTraits128Base	// 
Vectors.Instance:	VectorTraits128Base	// 
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	429.164	610.825
SumSLL_Basic	46.200	5674.133	9.289291
SumSLL_Base_Core	19.878	13187.618	21.589841
SumSLL_Multiply	46.206	5673.371	9.288045
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	46.308	5660.940	9.267693
SumSLLTraits_Core	19.880	13186.221	21.587554
SumSLLConstTraits	23.182	11307.858	18.512431
SumSLLConstTraits_Core	18.265	14351.930	23.495971
SumSLL128Traits	566.751	462.538	0.757235
SumSLL128Traits_Core	562.395	466.121	0.763100
SumSLL128ConstTraits	563.634	465.097	0.761423
SumSLL128ConstTraits_Core	563.602	465.122	0.761466
SumSLLFast_Multiply	26.355	9946.778	16.284166
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.375	9939.062	16.271534

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	431.390	607.672
SumSLL_Basic	60.669	4320.858	7.110505
SumSLL_Base_Core	31.204	8401.035	13.824941
SumSLL_Base_Core_Element	62.142	4218.452	6.941985
SumSLL_Base_Core_Mov	62.353	4204.219	6.918563
SumSLL_Multiply	61.150	4286.881	7.054593
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	62.312	4206.952	6.923060
SumSLLTraits_Core	33.295	7873.391	12.956639
SumSLLConstTraits	39.808	6585.196	10.836755
SumSLLConstTraits_Core	31.251	8388.233	13.803875
SumSLL128Traits	895.357	292.782	0.481808
SumSLL128Traits_Core	886.916	295.568	0.486394
SumSLL128ConstTraits	901.153	290.898	0.478709
SumSLL128ConstTraits_Core	898.900	291.628	0.479909
SumSLLFast_Multiply	47.580	5509.532	9.066616
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	52.683	4975.829	8.188341

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	350.863	747.140
SumSLL_Basic	80.766	3245.731	4.344206
SumSLL_Base_Core	67.186	3901.744	5.222239
SumSLL_Multiply	80.529	3255.281	4.356989
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	80.542	3254.751	4.356279
SumSLLTraits_Core	63.087	4155.259	5.561552
SumSLLConstTraits	80.077	3273.657	4.381584
SumSLLConstTraits_Core	63.025	4159.358	5.567039
SumSLL128Traits	1447.175	181.142	0.242447
SumSLL128Traits_Core	1448.332	180.997	0.242253
SumSLL128ConstTraits	1446.595	181.215	0.242544
SumSLL128ConstTraits_Core	1446.751	181.195	0.242518
SumSLLFast_Multiply	74.738	3507.522	4.694598
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	80.108	3272.378	4.379872

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	353.617	741.321
SumSLL_Basic	541.002	484.553	0.653634
SumSLL_Base_Core	544.840	481.139	0.649029
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	541.265	484.317	0.653316
SumSLLTraits_Core	540.800	484.733	0.653878
SumSLLConstTraits	556.037	471.451	0.635960
SumSLLConstTraits_Core	556.361	471.176	0.635589
SumSLL128Traits	1022.019	256.496	0.345999
SumSLL128Traits_Core	1030.326	254.428	0.343209
SumSLL128ConstTraits	1015.963	258.025	0.348061
SumSLL128ConstTraits_Core	1014.676	258.352	0.348503
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	556.180	471.330	0.635797

```

#### .NET 5.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	429.393	610.499
SumSLL_Basic	46.201	5673.983	9.294007
SumSLL_Base_Core	16.584	15807.401	25.892585
SumSLL_Multiply	46.166	5678.280	9.301045
SumSLL_AdvSimd	19.889	13180.138	21.589119
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.782	13251.373	21.705802
SumSLLTraits_Core	15.412	17009.027	27.860853
SumSLLConstTraits	16.497	15890.589	26.028848
SumSLLConstTraits_Core	15.410	17011.540	27.864970
SumSLL128Traits	19.808	13233.928	21.677226
SumSLL128Traits_Core	16.534	15854.999	25.970550
SumSLL128ConstTraits	92.308	2839.889	4.651749
SumSLL128ConstTraits_Core	16.550	15839.694	25.945481
SumSLLFast_Multiply	26.353	9947.575	16.294168
SumSLLFast_AdvSimd	16.512	15876.095	26.005106
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	16.507	15881.148	26.013382

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	431.896	606.961
SumSLL_Basic	61.941	4232.180	6.972737
SumSLL_Base_Core	33.340	7862.815	12.954397
SumSLL_Base_Core_Element	61.337	4273.823	7.041346
SumSLL_Base_Core_Mov	66.017	3970.879	6.542230
SumSLL_Multiply	62.156	4217.522	6.948587
SumSLL_AdvSimd	40.071	6541.930	10.778171
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	39.975	6557.701	10.804153
SumSLLTraits_Core	33.201	7895.671	13.008529
SumSLLConstTraits	39.523	6632.750	10.927801
SumSLLConstTraits_Core	33.041	7933.937	13.071575
SumSLL128Traits	40.040	6547.107	10.786699
SumSLL128Traits_Core	31.082	8433.908	13.895301
SumSLL128ConstTraits	159.240	1646.215	2.712225
SumSLL128ConstTraits_Core	31.120	8423.713	13.878506
SumSLLFast_Multiply	52.673	4976.855	8.199628
SumSLLFast_AdvSimd	33.339	7863.030	12.954752
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	33.466	7833.233	12.905658

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	351.085	746.668
SumSLL_Basic	80.988	3236.820	4.335021
SumSLL_Base_Core	67.384	3890.273	5.210180
SumSLL_Multiply	80.967	3237.648	4.336130
SumSLL_AdvSimd	74.108	3537.330	4.737490
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	79.817	3284.306	4.398619
SumSLLTraits_Core	66.996	3912.810	5.240364
SumSLLConstTraits	79.993	3277.066	4.388922
SumSLLConstTraits_Core	63.051	4157.647	5.568270
SumSLL128Traits	80.191	3269.013	4.378136
SumSLL128Traits_Core	63.096	4154.680	5.564297
SumSLL128ConstTraits	344.566	760.796	1.018921
SumSLL128ConstTraits_Core	67.287	3895.904	5.217722
SumSLLFast_Multiply	80.821	3243.502	4.343971
SumSLLFast_AdvSimd	80.141	3271.025	4.380832
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	79.670	3290.393	4.406770

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	353.063	742.484
SumSLL_Basic	542.196	483.485	0.651173
SumSLL_Base_Core	543.515	482.312	0.649592
SumSLL_AdvSimd	160.381	1634.509	2.201406
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	159.902	1639.404	2.207999
SumSLLTraits_Core	125.016	2096.877	2.824137
SumSLLConstTraits	133.957	1956.929	2.635651
SumSLLConstTraits_Core	124.770	2101.020	2.829717
SumSLL128Traits	160.613	1632.143	2.198219
SumSLL128Traits_Core	133.389	1965.258	2.646868
SumSLL128ConstTraits	639.054	410.206	0.552478
SumSLL128ConstTraits_Core	133.363	1965.643	2.647387
SumSLLFast_AdvSimd	134.368	1950.940	2.627585
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	159.517	1643.357	2.213323

```

#### .NET 6.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	404.102	648.707
SumSLL_Basic	37.798	6935.391	10.691103
SumSLL_Base_Core	16.822	15583.597	24.022559
SumSLL_Multiply	37.794	6936.219	10.692379
SumSLL_AdvSimd	20.071	13060.826	20.133635
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.803	13237.895	20.406592
SumSLLTraits_Core	15.504	16908.563	26.065032
SumSLLConstTraits	15.634	16767.307	25.847282
SumSLLConstTraits_Core	15.678	16720.152	25.774591
SumSLL128Traits	20.023	13092.409	20.182321
SumSLL128Traits_Core	16.726	15672.416	24.159476
SumSLL128ConstTraits	15.575	16830.711	25.945021
SumSLL128ConstTraits_Core	15.565	16841.563	25.961750
SumSLLFast_Multiply	23.817	11006.560	16.966926
SumSLLFast_AdvSimd	16.598	15793.456	24.346063
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	16.511	15877.231	24.475204

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	435.653	601.727
SumSLL_Basic	47.068	5569.436	9.255752
SumSLL_Base_Core	34.024	7704.772	12.804431
SumSLL_Base_Core_Element	50.520	5188.869	8.623293
SumSLL_Base_Core_Mov	52.078	5033.689	8.365404
SumSLL_Multiply	47.615	5505.454	9.149421
SumSLL_AdvSimd	40.678	6444.328	10.709720
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	40.891	6410.792	10.653986
SumSLLTraits_Core	32.007	8190.248	13.611235
SumSLLConstTraits	31.956	8203.292	13.632912
SumSLLConstTraits_Core	32.224	8134.961	13.519354
SumSLL128Traits	41.148	6370.773	10.587480
SumSLL128Traits_Core	33.905	7731.770	12.849298
SumSLL128ConstTraits	32.061	8176.309	13.588071
SumSLL128ConstTraits_Core	34.314	7639.466	12.695900
SumSLLFast_Multiply	41.305	6346.490	10.547124
SumSLLFast_AdvSimd	34.171	7671.524	12.749177
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	33.925	7727.203	12.841708

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	352.626	743.406
SumSLL_Basic	88.138	2974.247	4.000841
SumSLL_Base_Core	64.358	4073.205	5.479116
SumSLL_Multiply	88.249	2970.501	3.995802
SumSLL_AdvSimd	81.307	3224.116	4.336954
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	75.133	3489.056	4.693341
SumSLLTraits_Core	63.611	4121.064	5.543494
SumSLLConstTraits	64.261	4079.386	5.487430
SumSLLConstTraits_Core	67.470	3885.342	5.226409
SumSLL128Traits	74.751	3506.917	4.717368
SumSLL128Traits_Core	68.039	3852.825	5.182670
SumSLL128ConstTraits	64.251	4080.006	5.488265
SumSLL128ConstTraits_Core	68.045	3852.526	5.182267
SumSLLFast_Multiply	82.934	3160.888	4.251902
SumSLLFast_AdvSimd	67.469	3885.380	5.226460
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	67.874	3862.215	5.195299

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	359.188	729.825
SumSLL_Basic	551.337	475.470	0.651485
SumSLL_Base_Core	552.036	474.867	0.650659
SumSLL_AdvSimd	163.006	1608.189	2.203528
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	163.104	1607.218	2.202197
SumSLLTraits_Core	136.012	1927.358	2.640850
SumSLLConstTraits	134.124	1954.494	2.678033
SumSLLConstTraits_Core	135.812	1930.194	2.644736
SumSLL128Traits	161.921	1618.958	2.218284
SumSLL128Traits_Core	126.506	2072.185	2.839291
SumSLL128ConstTraits	126.921	2065.404	2.830001
SumSLL128ConstTraits_Core	127.214	2060.660	2.823500
SumSLLFast_AdvSimd	134.560	1948.156	2.669348
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	126.104	2078.794	2.848348

```

#### .NET 7.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	283.790	923.726
SumSLLNetBcl	13.435	19511.837	21.122971
SumSLLNetBcl_Const	13.441	19503.337	21.113769
SumSLL_Basic	13.415	19541.478	21.155059
SumSLL_Base_Core	13.445	19498.215	21.108224
SumSLL_Multiply	35.469	7390.891	8.001172
SumSLL_AdvSimd	19.880	13186.220	14.275035
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.858	13201.062	14.291102
SumSLLTraits_Core	13.437	19508.964	21.119861
SumSLLConstTraits	13.523	19385.104	20.985773
SumSLLConstTraits_Core	13.521	19387.799	20.988691
SumSLL128Traits	19.882	13185.281	14.274018
SumSLL128Traits_Core	13.453	19485.455	21.094410
SumSLL128ConstTraits	13.522	19386.371	20.987145
SumSLL128ConstTraits_Core	13.504	19412.991	21.015963
SumSLLFast_Multiply	22.889	11452.973	12.398670
SumSLLFast_AdvSimd	13.403	19558.086	21.173039
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	13.435	19511.599	21.122713

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	318.619	822.752
SumSLLNetBcl	26.336	9953.959	12.098372
SumSLLNetBcl_Const	26.385	9935.183	12.075550
SumSLL_Basic	26.332	9955.169	12.099842
SumSLL_Base_Core	26.372	9940.394	12.081884
SumSLL_Base_Core_Element	36.270	7227.536	8.784587
SumSLL_Base_Core_Mov	32.923	7962.445	9.677819
SumSLL_Multiply	42.776	6128.303	7.448543
SumSLL_AdvSimd	39.606	6618.822	8.044736
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	26.362	9944.018	12.086290
SumSLLTraits_Core	26.389	9933.661	12.073701
SumSLLConstTraits	26.382	9936.389	12.077017
SumSLLConstTraits_Core	26.405	9927.762	12.066531
SumSLL128Traits	26.380	9937.150	12.077942
SumSLL128Traits_Core	26.370	9941.176	12.082835
SumSLL128ConstTraits	26.425	9920.388	12.057569
SumSLL128ConstTraits_Core	26.431	9918.018	12.054688
SumSLLFast_Multiply	39.134	6698.640	8.141749
SumSLLFast_AdvSimd	26.331	9955.697	12.100485
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.362	9944.184	12.086491

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	186.406	1406.310
SumSLLNetBcl	53.627	4888.325	3.475995
SumSLLNetBcl_Const	54.164	4839.851	3.441526
SumSLL_Basic	55.903	4689.261	3.334444
SumSLL_Base_Core	54.708	4791.678	3.407271
SumSLL_Multiply	81.952	3198.745	2.274567
SumSLL_AdvSimd	69.164	3790.199	2.695138
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	55.845	4694.099	3.337884
SumSLLTraits_Core	55.582	4716.312	3.353679
SumSLLConstTraits	55.777	4699.840	3.341967
SumSLLConstTraits_Core	56.075	4674.841	3.324191
SumSLL128Traits	54.973	4768.568	3.390838
SumSLL128Traits_Core	55.284	4741.779	3.371789
SumSLL128ConstTraits	55.584	4716.192	3.353595
SumSLL128ConstTraits_Core	55.969	4683.749	3.330525
SumSLLFast_Multiply	80.640	3250.808	2.311588
SumSLLFast_AdvSimd	55.778	4699.791	3.341932
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	55.869	4692.153	3.336501

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	195.964	1337.715
SumSLLNetBcl	109.824	2386.951	1.784349
SumSLLNetBcl_Const	109.274	2398.953	1.793321
SumSLL_Basic	115.386	2271.897	1.698342
SumSLL_Base_Core	111.472	2351.655	1.757964
SumSLL_AdvSimd	133.028	1970.596	1.473106
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	132.769	1974.441	1.475980
SumSLLTraits_Core	106.680	2457.296	1.836936
SumSLLConstTraits	107.058	2448.615	1.830446
SumSLLConstTraits_Core	106.436	2462.932	1.841149
SumSLL128Traits	132.826	1973.590	1.475344
SumSLL128Traits_Core	106.510	2461.206	1.839858
SumSLL128ConstTraits	106.611	2458.894	1.838130
SumSLL128ConstTraits_Core	106.502	2461.397	1.840001
SumSLLFast_AdvSimd	106.728	2456.179	1.836100
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	106.840	2453.622	1.834189

```

