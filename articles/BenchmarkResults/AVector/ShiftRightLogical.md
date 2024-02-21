# Benchmark - ShiftRightLogical
([← Back](README.md))

See [Group](ShiftRightLogical.md)

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	304.568	860.708
SumSRL_Basic	75.272	3482.636	4.046247
SumSRL_Base_Core	76.107	3444.402	4.001825
SumSRLTraits	74.655	3511.384	4.079648
SumSRLTraits_Core	79.145	3312.182	3.848208
SumSRLConstTraits	71.209	3681.307	4.277070
SumSRLConstTraits_Core	71.239	3679.763	4.275276
SumSRLFastTraits	73.251	3578.692	4.157849

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	311.290	842.123
SumSRL_Basic	150.407	1742.900	2.069651
SumSRL_Base_Core	151.778	1727.160	2.050960
SumSRLTraits	149.076	1758.457	2.088124
SumSRLTraits_Core	155.699	1683.654	1.999298
SumSRLConstTraits	142.320	1841.928	2.187245
SumSRLConstTraits_Core	142.295	1842.261	2.187640
SumSRLFastTraits	146.273	1792.157	2.128143

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	311.990	840.232
SumSRL_Basic	301.227	870.254	1.035730
SumSRL_Base_Core	303.289	864.336	1.028688
SumSRLTraits	302.720	865.963	1.030624
SumSRLTraits_Core	302.619	866.250	1.030966
SumSRLConstTraits	284.747	920.621	1.095675
SumSRLConstTraits_Core	284.532	921.315	1.096501
SumSRLFastTraits	292.514	896.177	1.066583

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	313.226	836.917
SumSRL_Basic	580.882	451.286	0.539224
SumSRL_Base_Core	598.053	438.329	0.523742
SumSRLTraits	581.222	451.022	0.538909
SumSRLTraits_Core	572.955	457.530	0.546685
SumSRLConstTraits	523.659	500.601	0.598149
SumSRLConstTraits_Core	523.574	500.682	0.598246
SumSRLFastTraits	538.652	486.667	0.581500

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	305.108	859.184
SumSRL_Basic	77.288	3391.803	3.947705
SumSRL_Base_Core	75.283	3482.122	4.052826
SumSRLTraits	75.766	3459.909	4.026973
SumSRLTraits_Core	74.638	3512.213	4.087849
SumSRLConstTraits	65.794	3984.333	4.637348
SumSRLConstTraits_Core	65.677	3991.424	4.645600
SumSRLFastTraits	70.623	3711.903	4.320267

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	311.168	842.452
SumSRL_Basic	153.109	1712.144	2.032334
SumSRL_Base_Core	150.400	1742.983	2.068940
SumSRLTraits	151.214	1733.595	2.057796
SumSRLTraits_Core	149.538	1753.028	2.080864
SumSRLConstTraits	130.926	2002.238	2.376678
SumSRLConstTraits_Core	131.049	2000.354	2.374442
SumSRLFastTraits	141.116	1857.651	2.205052

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	311.598	841.290
SumSRL_Basic	303.149	864.736	1.027870
SumSRL_Base_Core	303.441	863.905	1.026882
SumSRLTraits	303.175	864.663	1.027783
SumSRLTraits_Core	303.405	864.007	1.027003
SumSRLConstTraits	262.338	999.262	1.187774
SumSRLConstTraits_Core	261.981	1000.621	1.189390
SumSRLFastTraits	281.373	931.659	1.107417

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	313.218	836.937
SumSRL_Basic	583.872	448.975	0.536450
SumSRL_Base_Core	555.307	472.070	0.564045
SumSRLTraits	554.649	472.630	0.564714
SumSRLTraits_Core	555.518	471.891	0.563831
SumSRLConstTraits	480.786	545.241	0.651472
SumSRLConstTraits_Core	479.622	546.563	0.653052
SumSRLFastTraits	519.577	504.534	0.602834

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	233.169	1124.267
SumSRL_Basic	74.826	3503.398	3.116161
SumSRL_Base_Core	75.917	3453.035	3.071364
SumSRL_Avx2	11.652	22498.329	20.011548
SumSRLTraits	12.232	21430.778	19.061996
SumSRLTraits_Core	6.187	42371.740	37.688315
SumSRLConstTraits	9.806	26732.259	23.777494
SumSRLConstTraits_Core	6.187	42371.681	37.688262
SumSRL128Traits	23.253	11273.585	10.027496
SumSRL128Traits_Core	11.544	22707.966	20.198014
SumSRL128ConstTraits	19.602	13373.228	11.895061
SumSRL128ConstTraits_Core	11.355	23085.285	20.533627
SumSRLFast_Avx2	9.747	26894.410	23.921722
SumSRLFastTraits	9.775	26816.824	23.852712

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	218.927	1197.405
SumSRL_Basic	152.829	1715.282	1.432500
SumSRL_Base_Core	151.368	1731.832	1.446322
SumSRL_Avx2	13.986	18742.928	15.652959
SumSRLTraits	14.349	18269.521	15.257598
SumSRLTraits_Core	13.788	19012.074	15.877734
SumSRLConstTraits	14.149	18526.821	15.472480
SumSRLConstTraits_Core	11.699	22406.662	18.712689
SumSRL128Traits	24.584	10663.254	8.905305
SumSRL128Traits_Core	21.156	12390.775	10.348026
SumSRL128ConstTraits	23.670	11074.842	9.249038
SumSRL128ConstTraits_Core	21.136	12402.444	10.357771
SumSRLFast_Avx2	13.087	20031.053	16.728724
SumSRLFastTraits	13.433	19515.046	16.297786

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	193.806	1352.612
SumSRL_Basic	298.864	877.136	0.648476
SumSRL_Base_Core	298.536	878.099	0.649187
SumSRL_Avx2	27.999	9362.615	6.921875
SumSRLTraits	26.516	9886.217	7.308979
SumSRLTraits_Core	24.354	10763.813	7.957795
SumSRLConstTraits	26.489	9896.420	7.316523
SumSRLConstTraits_Core	21.897	11971.914	8.850957
SumSRL128Traits	48.975	5352.578	3.957215
SumSRL128Traits_Core	40.636	6451.066	4.769338
SumSRL128ConstTraits	47.168	5557.668	4.108840
SumSRL128ConstTraits_Core	40.088	6539.178	4.834480
SumSRLFast_Avx2	24.932	10514.538	7.773504
SumSRLFastTraits	24.953	10505.602	7.766897

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	201.172	1303.085
SumSRL_Basic	535.917	489.150	0.375379
SumSRL_Base_Core	536.844	488.306	0.374731
SumSRL_Avx2	56.574	4633.662	3.555918
SumSRLTraits	56.941	4603.809	3.533008
SumSRLTraits_Core	44.829	5847.583	4.487493
SumSRLConstTraits	57.548	4555.211	3.495714
SumSRLConstTraits_Core	49.274	5320.140	4.082728
SumSRL128Traits	98.196	2669.587	2.048667
SumSRL128Traits_Core	74.418	3522.583	2.703265
SumSRL128ConstTraits	94.232	2781.894	2.134853
SumSRL128ConstTraits_Core	80.538	3254.929	2.497865
SumSRLFast_Avx2	51.984	5042.779	3.869878
SumSRLFastTraits	54.025	4852.310	3.723711

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	233.137	1124.419
SumSRL_Basic	72.918	3595.065	3.197265
SumSRL_Base_Core	72.866	3597.632	3.199548
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	12.390	21158.115	18.816934
SumSRLTraits	11.730	22348.406	19.875517
SumSRLTraits_Core	6.732	38940.425	34.631601
SumSRLConstTraits	8.089	32406.520	28.820683
SumSRLConstTraits_Core	6.734	38927.011	34.619671
SumSRL128Traits	23.233	11283.140	10.034642
SumSRL128Traits_Core	11.341	23114.473	20.556817
SumSRL128ConstTraits	11.632	22537.410	20.043607
SumSRL128ConstTraits_Core	11.380	23034.984	20.486124
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	7.443	35221.999	31.324625
SumSRLFastTraits	7.469	35097.841	31.214206

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	219.776	1192.777
SumSRL_Basic	147.388	1778.594	1.491137
SumSRL_Base_Core	146.542	1788.865	1.499748
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	13.923	18828.496	15.785429
SumSRLTraits	14.050	18657.899	15.642404
SumSRLTraits_Core	11.624	22551.415	18.906648
SumSRLConstTraits	11.761	22290.091	18.687559
SumSRLConstTraits_Core	12.386	21164.821	17.744156
SumSRL128Traits	24.548	10678.717	8.952820
SumSRL128Traits_Core	21.397	12251.695	10.271572
SumSRL128ConstTraits	21.187	12372.903	10.373190
SumSRL128ConstTraits_Core	21.184	12374.374	10.374423
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	11.785	22244.068	18.648975
SumSRLFastTraits	12.147	21581.651	18.093618

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	193.754	1352.975
SumSRL_Basic	290.879	901.214	0.666098
SumSRL_Base_Core	291.124	900.454	0.665537
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	28.470	9207.784	6.805584
SumSRLTraits	28.875	9078.617	6.710115
SumSRLTraits_Core	23.327	11237.730	8.305942
SumSRLConstTraits	25.202	10401.660	7.687992
SumSRLConstTraits_Core	22.726	11534.917	8.525597
SumSRL128Traits	52.201	5021.805	3.711676
SumSRL128Traits_Core	40.008	6552.349	4.842920
SumSRL128ConstTraits	41.956	6248.058	4.618015
SumSRL128ConstTraits_Core	39.136	6698.201	4.950721
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	23.774	11026.398	8.149744
SumSRLFastTraits	25.363	10335.612	7.639175

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	194.437	1348.224
SumSRL_Basic	559.881	468.214	0.347282
SumSRL_Base_Core	560.537	467.666	0.346876
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	55.726	4704.132	3.489133
SumSRLTraits	53.421	4907.109	3.639685
SumSRLTraits_Core	45.290	5788.063	4.293103
SumSRLConstTraits	55.644	4711.067	3.494277
SumSRLConstTraits_Core	46.482	5639.746	4.183094
SumSRL128Traits	99.277	2640.540	1.958533
SumSRL128Traits_Core	81.424	3219.510	2.387965
SumSRL128ConstTraits	94.058	2787.046	2.067198
SumSRL128ConstTraits_Core	79.723	3288.192	2.438907
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	48.789	5372.972	3.985223
SumSRLFastTraits	52.501	4993.147	3.703501

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	187.022	1401.674
SumSRL_Basic	74.558	3515.958	2.508399
SumSRL_Base_Core	74.614	3513.345	2.506535
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	11.722	22363.691	15.954983
SumSRLTraits	11.731	22347.107	15.943152
SumSRLTraits_Core	6.735	38922.939	27.768888
SumSRLConstTraits	6.320	41480.463	29.593508
SumSRLConstTraits_Core	6.726	38976.774	27.807295
SumSRL128Traits	23.145	11326.038	8.080363
SumSRL128Traits_Core	11.346	23105.048	16.483891
SumSRL128ConstTraits	10.921	24004.174	17.125357
SumSRL128ConstTraits_Core	11.379	23037.629	16.435792
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	6.968	37623.123	26.841557
SumSRLFastTraits	6.989	37507.716	26.759222

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	186.577	1405.020
SumSRL_Basic	150.295	1744.197	1.241403
SumSRL_Base_Core	150.572	1740.990	1.239121
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	13.463	19471.763	13.858707
SumSRLTraits	13.493	19427.799	13.827416
SumSRLTraits_Core	11.623	22553.645	16.052186
SumSRLConstTraits	11.123	23567.158	16.773537
SumSRLConstTraits_Core	10.800	24273.169	17.276028
SumSRL128Traits	24.557	10674.785	7.597602
SumSRL128Traits_Core	21.112	12416.879	8.837509
SumSRL128ConstTraits	20.222	12963.102	9.226274
SumSRL128ConstTraits_Core	19.150	13689.134	9.743016
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	13.242	19796.466	14.089809
SumSRLFastTraits	13.528	19377.471	13.791596

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	159.200	1646.634
SumSRL_Basic	297.943	879.845	0.534329
SumSRL_Base_Core	298.492	878.228	0.533347
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	28.490	9201.105	5.587826
SumSRLTraits	28.593	9168.072	5.567765
SumSRLTraits_Core	22.660	11568.403	7.025484
SumSRLConstTraits	24.495	10701.916	6.499268
SumSRLConstTraits_Core	23.287	11257.117	6.836441
SumSRL128Traits	48.946	5355.734	3.252534
SumSRL128Traits_Core	40.013	6551.525	3.978738
SumSRL128ConstTraits	39.988	6555.543	3.981177
SumSRL128ConstTraits_Core	39.928	6565.484	3.987215
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	25.674	10210.506	6.200834
SumSRLFastTraits	25.306	10359.040	6.291039

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	194.012	1351.173
SumSRL_Basic	537.169	488.011	0.361175
SumSRL_Base_Core	534.835	490.140	0.362751
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	53.624	4888.515	3.617979
SumSRLTraits	53.197	4927.812	3.647063
SumSRLTraits_Core	44.433	5899.802	4.366430
SumSRLConstTraits	50.529	5187.960	3.839597
SumSRLConstTraits_Core	49.658	5279.033	3.907000
SumSRL128Traits	98.372	2664.826	1.972232
SumSRL128Traits_Core	76.885	3409.562	2.523409
SumSRL128ConstTraits	80.761	3245.938	2.402312
SumSRL128ConstTraits_Core	81.373	3221.531	2.384247
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	48.854	5365.849	3.971253
SumSRLFastTraits	50.509	5190.052	3.841146

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	161.284	1625.360
SumSRLNetBcl	222.412	1178.641	0.725157
SumSRLNetBcl_Const	222.517	1178.088	0.724816
SumSRL_Basic	11.183	23441.151	14.422126
SumSRL_Base_Core	11.239	23325.467	14.350952
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	10.453	25077.580	15.428936
SumSRLTraits	10.459	25064.421	15.420840
SumSRLTraits_Core	6.760	38779.830	23.859221
SumSRLConstTraits	8.308	31554.277	19.413712
SumSRLConstTraits_Core	6.235	42041.736	25.866103
SumSRL128Traits	19.601	13373.965	8.228308
SumSRL128Traits_Core	12.395	21149.430	13.012149
SumSRL128ConstTraits	12.448	21058.754	12.956361
SumSRL128ConstTraits_Core	12.438	21076.848	12.967493
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	6.943	37755.611	23.229072
SumSRLFastTraits	6.969	37615.945	23.143143

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	160.780	1630.456
SumSRLNetBcl	12.597	20810.187	12.763416
SumSRLNetBcl_Const	11.422	22950.040	14.075843
SumSRL_Basic	12.622	20769.333	12.738360
SumSRL_Base_Core	13.418	19536.778	11.982402
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	14.702	17830.372	10.935820
SumSRLTraits	14.304	18326.875	11.240338
SumSRLTraits_Core	13.460	19476.074	11.945171
SumSRLConstTraits	11.521	22752.658	13.954783
SumSRLConstTraits_Core	11.517	22760.503	13.959595
SumSRL128Traits	23.688	11066.687	6.787480
SumSRL128Traits_Core	22.426	11689.107	7.169226
SumSRL128ConstTraits	21.351	12277.972	7.530392
SumSRL128ConstTraits_Core	20.771	12620.601	7.740535
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	12.752	20557.871	12.608665
SumSRLFastTraits	13.549	19347.959	11.866595

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	116.432	2251.479
SumSRLNetBcl	25.192	10405.918	4.621815
SumSRLNetBcl_Const	22.259	11777.083	5.230821
SumSRL_Basic	27.293	9604.887	4.266035
SumSRL_Base_Core	26.934	9732.781	4.322839
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	29.142	8995.293	3.995282
SumSRLTraits	26.652	9835.703	4.368552
SumSRLTraits_Core	23.333	11234.864	4.989993
SumSRLConstTraits	23.240	11279.942	5.010015
SumSRLConstTraits_Core	22.878	11458.321	5.089242
SumSRL128Traits	46.376	5652.604	2.510618
SumSRL128Traits_Core	42.608	6152.423	2.732614
SumSRL128ConstTraits	42.849	6117.871	2.717268
SumSRL128ConstTraits_Core	42.766	6129.746	2.722542
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	26.135	10030.468	4.455057
SumSRLFastTraits	25.700	10200.001	4.530356

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	155.737	1683.247
SumSRLNetBcl	51.322	5107.877	3.034539
SumSRLNetBcl_Const	45.565	5753.125	3.417874
SumSRL_Basic	53.747	4877.338	2.897577
SumSRL_Base_Core	53.417	4907.489	2.915490
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	63.475	4129.910	2.453538
SumSRLTraits	60.172	4356.584	2.588203
SumSRLTraits_Core	46.347	5656.123	3.360245
SumSRLConstTraits	51.262	5113.821	3.038070
SumSRLConstTraits_Core	47.007	5576.720	3.313073
SumSRL128Traits	100.824	2600.020	1.544646
SumSRL128Traits_Core	78.521	3338.540	1.983393
SumSRL128ConstTraits	85.348	3071.486	1.824739
SumSRL128ConstTraits_Core	83.607	3135.444	1.862736
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	51.488	5091.406	3.024753
SumSRLFastTraits	52.384	5004.310	2.973010

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	429.435	610.440
SumSRL_Basic	74.423	3522.345	5.770175
SumSRL_Base_Core	74.375	3524.622	5.773905
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	69.076	3794.990	6.216811
SumSRLTraits_Core	69.231	3786.531	6.202954
SumSRLConstTraits	67.293	3895.547	6.381541
SumSRLConstTraits_Core	67.650	3875.003	6.347886
SumSRL128Traits	566.774	462.520	0.757683
SumSRL128Traits_Core	562.181	466.298	0.763872
SumSRL128ConstTraits	564.025	464.774	0.761375
SumSRL128ConstTraits_Core	563.863	464.907	0.761594
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	67.653	3874.840	6.347618

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	431.924	606.922
SumSRL_Basic	148.338	1767.201	2.911745
SumSRL_Base_Core	148.175	1769.150	2.914957
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	139.169	1883.644	3.103603
SumSRLTraits_Core	138.792	1888.758	3.112030
SumSRLConstTraits	135.981	1927.803	3.176362
SumSRLConstTraits_Core	135.974	1927.897	3.176517
SumSRL128Traits	887.416	295.401	0.486721
SumSRL128Traits_Core	878.213	298.497	0.491821
SumSRL128ConstTraits	893.112	293.517	0.483617
SumSRL128ConstTraits_Core	892.333	293.774	0.484039
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	137.166	1911.139	3.148906

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	349.616	749.805
SumSRL_Basic	275.144	952.751	1.270666
SumSRL_Base_Core	275.295	952.229	1.269969
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	277.599	944.328	1.259432
SumSRLTraits_Core	277.123	945.949	1.261594
SumSRLConstTraits	275.110	952.870	1.270825
SumSRLConstTraits_Core	274.703	954.282	1.272707
SumSRL128Traits	1431.621	183.110	0.244210
SumSRL128Traits_Core	1432.064	183.053	0.244135
SumSRL128ConstTraits	1432.219	183.033	0.244108
SumSRL128ConstTraits_Core	1432.159	183.041	0.244118
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	271.031	967.210	1.289950

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	353.088	742.433
SumSRL_Basic	547.698	478.629	0.644676
SumSRL_Base_Core	540.114	485.350	0.653728
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	560.019	468.098	0.630492
SumSRLTraits_Core	556.951	470.677	0.633966
SumSRLConstTraits	560.329	467.839	0.630143
SumSRLConstTraits_Core	558.984	468.965	0.631659
SumSRL128Traits	968.813	270.583	0.364454
SumSRL128Traits_Core	950.022	275.935	0.371663
SumSRL128ConstTraits	958.267	273.560	0.368465
SumSRL128ConstTraits_Core	949.173	276.181	0.371995
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	558.161	469.657	0.632591

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	428.993	611.068
SumSRL_Basic	73.293	3576.642	5.853095
SumSRL_Base_Core	73.306	3576.022	5.852081
SumSRL_AdvSimd	22.043	11892.353	19.461572
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	23.060	11367.866	18.603260
SumSRLTraits_Core	16.500	15887.374	25.999335
SumSRLConstTraits	19.778	13254.468	21.690643
SumSRLConstTraits_Core	16.498	15889.018	26.002026
SumSRL128Traits	22.013	11908.536	19.488056
SumSRL128Traits_Core	16.554	15835.768	25.914883
SumSRL128ConstTraits	16.545	15844.426	25.929052
SumSRL128ConstTraits_Core	16.529	15859.491	25.953706
SumSRLFast_AdvSimd	19.848	13207.837	21.614332
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	19.841	13212.078	21.621274

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	432.537	606.062
SumSRL_Basic	146.629	1787.808	2.949877
SumSRL_Base_Core	147.070	1782.443	2.941024
SumSRL_AdvSimd	44.121	5941.433	9.803341
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	43.898	5971.707	9.853294
SumSRLTraits_Core	32.965	7952.247	13.121177
SumSRLConstTraits	209.778	1249.623	2.061874
SumSRLConstTraits_Core	32.942	7957.828	13.130386
SumSRL128Traits	46.153	5679.936	9.371872
SumSRL128Traits_Core	33.020	7938.871	13.099106
SumSRL128ConstTraits	209.924	1248.756	2.060443
SumSRL128ConstTraits_Core	33.014	7940.466	13.101737
SumSRLFast_AdvSimd	39.662	6609.521	10.905684
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	32.958	7953.825	13.123780

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	350.662	747.568
SumSRL_Basic	268.332	976.939	1.306823
SumSRL_Base_Core	268.834	975.116	1.304385
SumSRL_AdvSimd	79.834	3283.631	4.392417
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	79.630	3292.010	4.403625
SumSRLTraits_Core	66.619	3934.975	5.263702
SumSRLConstTraits	66.640	3933.740	5.262049
SumSRLConstTraits_Core	66.607	3935.683	5.264648
SumSRL128Traits	79.857	3282.675	4.391139
SumSRL128Traits_Core	62.556	4190.520	5.605536
SumSRL128ConstTraits	66.778	3925.599	5.251160
SumSRL128ConstTraits_Core	62.443	4198.127	5.615713
SumSRLFast_AdvSimd	66.664	3932.311	5.260138
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	66.812	3923.614	5.248504

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	354.306	739.881
SumSRL_Basic	538.884	486.457	0.657481
SumSRL_Base_Core	541.983	483.676	0.653721
SumSRL_AdvSimd	185.337	1414.415	1.911678
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	184.525	1420.642	1.920095
SumSRLTraits_Core	123.427	2123.873	2.870560
SumSRLConstTraits	132.142	1983.810	2.681256
SumSRLConstTraits_Core	132.276	1981.799	2.678537
SumSRL128Traits	185.014	1416.889	1.915023
SumSRL128Traits_Core	132.261	1982.015	2.678829
SumSRL128ConstTraits	132.872	1972.904	2.666516
SumSRL128ConstTraits_Core	124.112	2112.151	2.854718
SumSRLFast_AdvSimd	132.487	1978.634	2.674260
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	132.127	1984.034	2.681558

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	401.261	653.301
SumSRL_Basic	172.696	1517.947	2.323503
SumSRL_Base_Core	175.952	1489.862	2.280513
SumSRL_AdvSimd	23.217	11291.053	17.283073
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	22.113	11854.758	18.145930
SumSRLTraits_Core	15.483	16931.012	25.916088
SumSRLConstTraits	15.485	16929.335	25.913521
SumSRLConstTraits_Core	16.535	15854.083	24.267646
SumSRL128Traits	22.024	11902.879	18.219589
SumSRL128Traits_Core	16.599	15793.090	24.174285
SumSRL128ConstTraits	15.498	16914.199	25.890352
SumSRL128ConstTraits_Core	15.513	16898.840	25.866843
SumSRLFast_AdvSimd	15.460	16956.112	25.954509
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	15.460	16956.265	25.954743

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	433.959	604.075
SumSRL_Basic	148.005	1771.186	2.932061
SumSRL_Base_Core	318.218	823.786	1.363715
SumSRL_AdvSimd	44.485	5892.797	9.755068
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	44.417	5901.827	9.770016
SumSRLTraits_Core	33.456	7835.431	12.970949
SumSRLConstTraits	33.414	7845.444	12.987524
SumSRLConstTraits_Core	33.461	7834.350	12.969158
SumSRL128Traits	44.410	5902.850	9.771710
SumSRL128Traits_Core	31.508	8320.033	13.773169
SumSRL128ConstTraits	33.640	7792.567	12.899990
SumSRL128ConstTraits_Core	31.559	8306.434	13.750657
SumSRLFast_AdvSimd	31.429	8340.868	13.807660
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	33.547	7814.332	12.936021

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	353.306	741.975
SumSRL_Basic	270.835	967.911	1.304506
SumSRL_Base_Core	270.997	967.333	1.303727
SumSRL_AdvSimd	80.363	3262.002	4.396376
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	80.116	3272.067	4.409942
SumSRLTraits_Core	62.777	4175.823	5.627983
SumSRLConstTraits	66.916	3917.508	5.279837
SumSRLConstTraits_Core	66.814	3923.493	5.287904
SumSRL128Traits	80.089	3273.167	4.411423
SumSRL128Traits_Core	62.906	4167.244	5.616419
SumSRL128ConstTraits	62.873	4169.417	5.619348
SumSRL128ConstTraits_Core	66.988	3913.322	5.274196
SumSRLFast_AdvSimd	62.990	4161.691	5.608935
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	66.908	3917.982	5.280477

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	354.692	739.075
SumSRL_Basic	544.126	481.770	0.651856
SumSRL_Base_Core	544.286	481.629	0.651665
SumSRL_AdvSimd	177.130	1479.955	2.002443
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	176.334	1486.629	2.011473
SumSRLTraits_Core	133.181	1968.333	2.663239
SumSRLConstTraits	133.453	1964.318	2.657807
SumSRLConstTraits_Core	124.238	2110.022	2.854950
SumSRL128Traits	177.275	1478.744	2.000805
SumSRL128Traits_Core	125.217	2093.517	2.832618
SumSRL128ConstTraits	132.927	1972.086	2.668318
SumSRL128ConstTraits_Core	133.198	1968.082	2.662900
SumSRLFast_AdvSimd	159.103	1647.634	2.229320
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	158.987	1648.839	2.230950

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	283.378	925.069
SumSRLNetBcl	13.425	19526.683	21.108344
SumSRLNetBcl_Const	13.425	19527.125	21.108822
SumSRL_Basic	32.997	7944.581	8.588092
SumSRL_Base_Core	33.076	7925.434	8.567394
SumSRL_AdvSimd	19.957	13135.329	14.199291
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	19.934	13150.471	14.215659
SumSRLTraits_Core	13.434	19512.920	21.093466
SumSRLConstTraits	13.501	19416.639	20.989386
SumSRLConstTraits_Core	13.501	19416.358	20.989083
SumSRL128Traits	19.929	13154.059	14.219538
SumSRL128Traits_Core	13.432	19515.757	21.096533
SumSRL128ConstTraits	13.510	19404.393	20.976148
SumSRL128ConstTraits_Core	13.516	19395.451	20.966483
SumSRLFast_AdvSimd	13.389	19579.055	21.164958
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	13.432	19516.840	21.097704

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	318.548	822.934
SumSRLNetBcl	26.733	9805.972	11.915872
SumSRLNetBcl_Const	26.732	9806.457	11.916461
SumSRL_Basic	26.703	9817.130	11.929431
SumSRL_Base_Core	26.770	9792.583	11.899603
SumSRL_AdvSimd	39.814	6584.266	8.000969
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	26.731	9806.873	11.916967
SumSRLTraits_Core	26.723	9809.512	11.920174
SumSRLConstTraits	26.893	9747.796	11.845180
SumSRLConstTraits_Core	26.908	9742.182	11.838358
SumSRL128Traits	26.770	9792.525	11.899532
SumSRL128Traits_Core	26.773	9791.252	11.897986
SumSRL128ConstTraits	26.944	9729.161	11.822535
SumSRL128ConstTraits_Core	26.947	9728.222	11.821393
SumSRLFast_AdvSimd	26.755	9797.920	11.906088
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	26.693	9820.527	11.933559

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	224.033	1170.115
SumSRLNetBcl	54.945	4771.051	4.077420
SumSRLNetBcl_Const	54.884	4776.363	4.081960
SumSRL_Basic	54.873	4777.290	4.082753
SumSRL_Base_Core	55.078	4759.469	4.067522
SumSRL_AdvSimd	79.776	3285.996	2.808268
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	54.908	4774.267	4.080169
SumSRLTraits_Core	54.945	4770.997	4.077374
SumSRLConstTraits	55.386	4733.043	4.044938
SumSRLConstTraits_Core	55.260	4743.864	4.054186
SumSRL128Traits	54.877	4776.961	4.082471
SumSRL128Traits_Core	54.884	4776.351	4.081950
SumSRL128ConstTraits	55.364	4734.876	4.046505
SumSRL128ConstTraits_Core	55.269	4743.023	4.053467
SumSRLFast_AdvSimd	54.830	4781.043	4.085959
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	54.916	4773.527	4.079537

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	219.915	1192.022
SumSRLNetBcl	107.568	2437.007	2.044430
SumSRLNetBcl_Const	107.500	2438.554	2.045729
SumSRL_Basic	107.596	2436.375	2.043901
SumSRL_Base_Core	107.749	2432.922	2.041003
SumSRL_AdvSimd	159.201	1646.618	1.381366
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	158.965	1649.062	1.383416
SumSRLTraits_Core	107.634	2435.511	2.043176
SumSRLConstTraits	107.893	2429.675	2.038280
SumSRLConstTraits_Core	107.647	2435.217	2.042929
SumSRL128Traits	158.942	1649.302	1.383617
SumSRL128Traits_Core	108.679	2412.091	2.023528
SumSRL128ConstTraits	107.852	2430.599	2.039055
SumSRL128ConstTraits_Core	107.654	2435.059	2.042796
SumSRLFast_AdvSimd	108.742	2410.698	2.022360
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	108.678	2412.110	2.023545

```

