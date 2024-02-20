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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	429.765	609.971
SumSRL_Basic	74.149	3535.363	5.795951
SumSRL_Base_Core	74.107	3537.350	5.799208
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	70.061	3741.637	6.134122
SumSRLTraits_Core	70.123	3738.350	6.128733
SumSRLConstTraits	68.559	3823.629	6.268540
SumSRLConstTraits_Core	68.542	3824.594	6.270122
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	68.925	3803.316	6.235240

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	432.124	606.641
SumSRL_Basic	148.320	1767.420	2.913453
SumSRL_Base_Core	148.473	1765.596	2.910447
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	138.565	1891.842	3.118553
SumSRLTraits_Core	138.464	1893.230	3.120842
SumSRLConstTraits	136.558	1919.649	3.164391
SumSRLConstTraits_Core	136.443	1921.276	3.167072
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	136.822	1915.946	3.158287

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	350.570	747.766
SumSRL_Basic	275.969	949.905	1.270323
SumSRL_Base_Core	679.196	385.962	0.516154
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	279.450	938.073	1.254500
SumSRLTraits_Core	279.358	938.379	1.254909
SumSRLConstTraits	276.631	947.631	1.267283
SumSRLConstTraits_Core	273.343	959.031	1.282528
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	272.367	962.467	1.287123

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	354.044	740.429
SumSRL_Basic	539.613	485.800	0.656106
SumSRL_Base_Core	534.307	490.624	0.662622
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	556.197	471.315	0.636543
SumSRLTraits_Core	556.365	471.172	0.636351
SumSRLConstTraits	557.536	470.183	0.635014
SumSRLConstTraits_Core	557.508	470.207	0.635047
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	557.664	470.075	0.634869

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	429.151	610.843
SumSRL_Basic	73.221	3580.168	5.861027
SumSRL_Base_Core	71.538	3664.403	5.998926
SumSRL_AdvSimd	23.106	11345.178	18.572980
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	22.005	11913.021	19.502587
SumSRLTraits_Core	15.436	16982.614	27.801924
SumSRLConstTraits	16.505	15882.629	26.001158
SumSRLConstTraits_Core	15.422	16997.625	27.826497
SumSRLFast_AdvSimd	16.520	15868.754	25.978445
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	16.501	15886.504	26.007502

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	431.708	607.225
SumSRL_Basic	145.783	1798.180	2.961308
SumSRL_Base_Core	146.665	1787.371	2.943506
SumSRL_AdvSimd	46.205	5673.453	9.343245
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	46.141	5681.334	9.356224
SumSRLTraits_Core	30.898	8484.151	13.972002
SumSRLConstTraits	209.653	1250.372	2.059157
SumSRLConstTraits_Core	30.935	8473.922	13.955157
SumSRLFast_AdvSimd	33.091	7921.829	13.045951
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	39.652	6611.060	10.887330

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	351.131	746.570
SumSRL_Basic	268.519	976.257	1.307656
SumSRL_Base_Core	267.875	978.606	1.310802
SumSRL_AdvSimd	80.044	3274.991	4.386716
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	80.008	3276.459	4.388681
SumSRLTraits_Core	67.189	3901.594	5.226024
SumSRLConstTraits	67.281	3896.249	5.218865
SumSRLConstTraits_Core	67.168	3902.825	5.227673
SumSRLFast_AdvSimd	67.561	3880.117	5.197257
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	67.423	3888.059	5.207894

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	353.535	741.494
SumSRL_Basic	541.139	484.430	0.653317
SumSRL_Base_Core	541.052	484.508	0.653421
SumSRL_AdvSimd	184.729	1419.077	1.913807
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	184.530	1420.603	1.915865
SumSRLTraits_Core	123.631	2120.369	2.859590
SumSRLConstTraits	132.755	1974.648	2.663066
SumSRLConstTraits_Core	132.268	1981.918	2.672871
SumSRLFast_AdvSimd	132.584	1977.193	2.666499
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	132.381	1980.220	2.670582

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	400.480	654.575
SumSRL_Basic	73.447	3569.164	5.452642
SumSRL_Base_Core	72.487	3616.444	5.524872
SumSRL_AdvSimd	23.120	11338.244	17.321532
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	23.085	11355.501	17.347896
SumSRLTraits_Core	16.515	15872.815	24.249036
SumSRLConstTraits	16.521	15867.157	24.240391
SumSRLConstTraits_Core	15.443	16974.903	25.932705
SumSRLFast_AdvSimd	15.417	17003.082	25.975754
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	15.423	16996.865	25.966256

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	432.071	606.715
SumSRL_Basic	147.388	1778.601	2.931528
SumSRL_Base_Core	146.130	1793.904	2.956751
SumSRL_AdvSimd	44.214	5929.012	9.772323
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	44.127	5940.648	9.791501
SumSRLTraits_Core	33.271	7879.072	12.986453
SumSRLConstTraits	33.250	7884.014	12.994599
SumSRLConstTraits_Core	33.287	7875.343	12.980307
SumSRLFast_AdvSimd	33.340	7862.685	12.959444
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	31.243	8390.470	13.829349

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	350.023	748.934
SumSRL_Basic	268.659	975.748	1.302849
SumSRL_Base_Core	268.654	975.768	1.302875
SumSRL_AdvSimd	79.934	3279.505	4.378895
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	79.903	3280.786	4.380606
SumSRLTraits_Core	62.707	4180.485	5.581911
SumSRLConstTraits	66.929	3916.718	5.229722
SumSRLConstTraits_Core	66.818	3923.265	5.238463
SumSRLFast_AdvSimd	62.824	4172.700	5.571516
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	66.883	3919.469	5.233395

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	353.116	742.373
SumSRL_Basic	538.167	487.105	0.656146
SumSRL_Base_Core	550.040	476.591	0.641983
SumSRL_AdvSimd	184.627	1419.860	1.912597
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	184.495	1420.872	1.913960
SumSRLTraits_Core	123.525	2122.190	2.858657
SumSRLConstTraits	123.599	2120.920	2.856947
SumSRLConstTraits_Core	132.228	1982.508	2.670501
SumSRLFast_AdvSimd	158.441	1654.524	2.228697
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	158.487	1654.040	2.228044

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	294.266	890.839
SumSRLNetBcl	13.384	19586.726	21.986831
SumSRLNetBcl_Const	13.381	19590.775	21.991376
SumSRL_Basic	33.042	7933.745	8.905925
SumSRL_Base_Core	33.053	7930.950	8.902788
SumSRL_AdvSimd	19.911	13165.746	14.779041
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	19.896	13175.619	14.790124
SumSRLTraits_Core	13.388	19580.851	21.980236
SumSRLConstTraits	13.480	19447.280	21.830298
SumSRLConstTraits_Core	13.490	19432.662	21.813888
SumSRLFast_AdvSimd	13.372	19603.444	22.005598
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	13.396	19568.992	21.966924

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	319.447	820.618
SumSRLNetBcl	27.579	9505.360	11.583171
SumSRLNetBcl_Const	27.569	9508.811	11.587376
SumSRL_Basic	27.532	9521.524	11.602867
SumSRL_Base_Core	27.584	9503.337	11.580705
SumSRL_AdvSimd	40.259	6511.443	7.934803
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	27.579	9505.102	11.582856
SumSRLTraits_Core	27.568	9509.063	11.587683
SumSRLConstTraits	27.762	9442.549	11.506630
SumSRLConstTraits_Core	27.770	9439.698	11.503155
SumSRLFast_AdvSimd	27.528	9522.792	11.604413
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	27.563	9510.709	11.589689

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	224.058	1169.981
SumSRLNetBcl	55.092	4758.308	4.066995
SumSRLNetBcl_Const	55.221	4747.163	4.057469
SumSRL_Basic	55.224	4746.886	4.057233
SumSRL_Base_Core	55.173	4751.345	4.061044
SumSRL_AdvSimd	79.911	3280.461	2.803858
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	55.335	4737.385	4.049113
SumSRLTraits_Core	55.146	4753.624	4.062992
SumSRLConstTraits	55.566	4717.740	4.032321
SumSRLConstTraits_Core	55.658	4709.911	4.025630
SumSRLFast_AdvSimd	55.348	4736.323	4.048205
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	55.195	4749.435	4.059412

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	220.335	1189.752
SumSRLNetBcl	107.682	2434.417	2.046156
SumSRLNetBcl_Const	107.696	2434.110	2.045898
SumSRL_Basic	108.167	2423.514	2.036992
SumSRL_Base_Core	111.423	2352.692	1.977465
SumSRL_AdvSimd	160.513	1633.169	1.372697
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	158.991	1648.802	1.385838
SumSRLTraits_Core	109.643	2390.895	2.009575
SumSRLConstTraits	108.761	2410.270	2.025860
SumSRLConstTraits_Core	109.253	2399.429	2.016748
SumSRLFast_AdvSimd	110.150	2379.890	2.000325
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	110.143	2380.027	2.000441

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

