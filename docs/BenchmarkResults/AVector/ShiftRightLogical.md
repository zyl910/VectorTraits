# Benchmark - ShiftRightLogical
([← Back](README.md))
See [Group](ShiftRightLogical.md)

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	387.422	676.636
SumSRL_Basic	96.626	2712.984	4.009517
SumSRL_Base_Core	92.865	2822.861	4.171904
SumSRLTraits	94.872	2763.121	4.083615
SumSRLTraits_Core	94.794	2765.412	4.087000
SumSRLConstTraits	79.667	3290.487	4.863009
SumSRLConstTraits_Core	77.166	3397.125	5.020608
SumSRLFastTraits	84.522	3101.489	4.583688

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	381.585	686.987
SumSRL_Basic	187.324	1399.415	2.037033
SumSRL_Base_Core	183.561	1428.099	2.078787
SumSRLTraits	181.607	1443.467	2.101157
SumSRLTraits_Core	197.582	1326.763	1.931278
SumSRLConstTraits	153.551	1707.216	2.485078
SumSRLConstTraits_Core	155.905	1681.437	2.447553
SumSRLFastTraits	169.042	1550.767	2.257345

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	376.671	695.950
SumSRL_Basic	369.003	710.412	1.020781
SumSRL_Base_Core	368.665	711.064	1.021718
SumSRLTraits	362.624	722.908	1.038737
SumSRLTraits_Core	358.123	731.994	1.051791
SumSRLConstTraits	307.746	851.818	1.223965
SumSRLConstTraits_Core	308.180	850.620	1.222244
SumSRLFastTraits	335.355	781.691	1.123200

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	386.767	677.784
SumSRL_Basic	702.692	373.057	0.550407
SumSRL_Base_Core	672.522	389.792	0.575098
SumSRLTraits	683.478	383.544	0.565880
SumSRLTraits_Core	711.720	368.325	0.543425
SumSRLConstTraits	563.028	465.597	0.686941
SumSRLConstTraits_Core	565.825	463.295	0.683545
SumSRLFastTraits	647.324	404.966	0.597485

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	370.192	708.130
SumSRL_Basic	94.836	2764.181	3.903494
SumSRL_Base_Core	94.032	2787.810	3.936862
SumSRLTraits	93.176	2813.433	3.973046
SumSRLTraits_Core	95.715	2738.805	3.867659
SumSRLConstTraits	80.254	3266.420	4.612741
SumSRLConstTraits_Core	80.554	3254.282	4.595600
SumSRLFastTraits	88.579	2959.432	4.179222

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	389.550	672.940
SumSRL_Basic	188.412	1391.336	2.067547
SumSRL_Base_Core	186.638	1404.558	2.087195
SumSRLTraits	191.288	1370.414	2.036456
SumSRLTraits_Core	186.943	1402.270	2.083795
SumSRLConstTraits	153.381	1709.098	2.539746
SumSRLConstTraits_Core	154.430	1697.491	2.522498
SumSRLFastTraits	168.987	1551.263	2.305201

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	374.192	700.561
SumSRL_Basic	368.567	711.251	1.015259
SumSRL_Base_Core	378.563	692.471	0.988451
SumSRLTraits	382.124	686.018	0.979240
SumSRLTraits_Core	379.602	690.576	0.985747
SumSRLConstTraits	309.464	847.091	1.209161
SumSRLConstTraits_Core	306.153	856.251	1.222237
SumSRLFastTraits	434.409	603.450	0.861382

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	386.591	678.091
SumSRL_Basic	665.335	394.003	0.581047
SumSRL_Base_Core	705.947	371.337	0.547621
SumSRLTraits	699.163	374.939	0.552934
SumSRLTraits_Core	672.396	389.865	0.574945
SumSRLConstTraits	562.790	465.793	0.686918
SumSRLConstTraits_Core	680.793	385.057	0.567854
SumSRLFastTraits	628.627	417.011	0.614977

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	280.683	933.951
SumSRL_Basic	95.678	2739.860	2.933621
SumSRL_Base_Core	92.551	2832.429	3.032737
SumSRL_Avx2	15.486	16927.856	18.124987
SumSRLTraits	15.339	17089.946	18.298540
SumSRLTraits_Core	7.912	33131.684	35.474743
SumSRLConstTraits	12.313	21290.313	22.795955
SumSRLConstTraits_Core	7.914	33122.707	35.465131
SumSRLFast_Avx2	12.552	20884.136	22.361053
SumSRLFastTraits	12.587	20825.814	22.298607

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	275.977	949.876
SumSRL_Basic	191.341	1370.037	1.442332
SumSRL_Base_Core	195.714	1339.424	1.410104
SumSRL_Avx2	19.481	13456.086	14.166147
SumSRLTraits	18.947	13835.850	14.565950
SumSRLTraits_Core	16.796	15607.688	16.431287
SumSRLConstTraits	19.097	13726.661	14.451000
SumSRLConstTraits_Core	16.544	15845.440	16.681585
SumSRLFast_Avx2	18.409	14239.876	14.991297
SumSRLFastTraits	17.700	14810.041	15.591549

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	240.360	1090.632
SumSRL_Basic	392.961	667.100	0.611664
SumSRL_Base_Core	385.824	679.439	0.622977
SumSRL_Avx2	39.558	6626.788	6.076099
SumSRLTraits	35.933	7295.258	6.689020
SumSRLTraits_Core	33.648	7790.768	7.143353
SumSRLConstTraits	36.899	7104.290	6.513921
SumSRLConstTraits_Core	31.430	8340.662	7.647551
SumSRLFast_Avx2	34.516	7594.773	6.963645
SumSRLFastTraits	35.810	7320.504	6.712168

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	246.895	1061.761
SumSRL_Basic	672.967	389.535	0.366876
SumSRL_Base_Core	662.845	395.483	0.372478
SumSRL_Avx2	77.979	3361.730	3.166182
SumSRLTraits	77.901	3365.101	3.169357
SumSRLTraits_Core	60.020	4367.611	4.113552
SumSRLConstTraits	75.627	3466.271	3.264642
SumSRLConstTraits_Core	64.313	4076.087	3.838985
SumSRLFast_Avx2	71.177	3682.970	3.468736
SumSRLFastTraits	74.342	3526.183	3.321069

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	275.053	953.066
SumSRL_Basic	88.279	2969.480	3.115713
SumSRL_Base_Core	88.457	2963.524	3.109464
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	14.861	17639.587	18.508256
SumSRLTraits	14.856	17646.018	18.515003
SumSRLTraits_Core	8.422	31125.478	32.658264
SumSRLConstTraits	10.189	25728.183	26.995178
SumSRLConstTraits_Core	8.624	30397.182	31.894103
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	9.671	27106.210	28.441067
SumSRLFastTraits	9.436	27781.507	29.149619

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	274.572	954.735
SumSRL_Basic	175.480	1493.871	1.564696
SumSRL_Base_Core	213.290	1229.047	1.287317
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	22.205	11805.536	12.365243
SumSRLTraits	18.300	14325.129	15.004291
SumSRLTraits_Core	19.438	13486.406	14.125805
SumSRLConstTraits	20.079	13055.716	13.674695
SumSRLConstTraits_Core	19.927	13154.944	13.778627
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	20.859	12567.213	13.163031
SumSRLFastTraits	21.446	12223.604	12.803132

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	405.329	646.744
SumSRL_Basic	474.229	552.780	0.854712
SumSRL_Base_Core	516.408	507.629	0.784900
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	60.801	4311.531	6.666523
SumSRLTraits	68.365	3834.455	5.928864
SumSRLTraits_Core	37.485	6993.301	10.813095
SumSRLConstTraits	32.476	8071.843	12.480745
SumSRLConstTraits_Core	28.743	9120.339	14.101939
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	32.213	8137.778	12.582695
SumSRLFastTraits	51.341	5105.923	7.894818

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	242.802	1079.662
SumSRL_Basic	702.006	373.421	0.345869
SumSRL_Base_Core	705.075	371.796	0.344363
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	78.615	3334.543	3.088506
SumSRLTraits	89.903	2915.849	2.700705
SumSRLTraits_Core	62.355	4204.078	3.893883
SumSRLConstTraits	73.931	3545.798	3.284173
SumSRLConstTraits_Core	64.016	4094.998	3.792851
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	71.747	3653.751	3.384161
SumSRLFastTraits	66.825	3922.846	3.633401

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	229.695	1141.269
SumSRL_Basic	115.261	2274.348	1.992823
SumSRL_Base_Core	92.406	2836.866	2.485711
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	15.133	17322.205	15.178018
SumSRLTraits	15.506	16906.401	14.813684
SumSRLTraits_Core	8.946	29301.316	25.674324
SumSRLConstTraits	8.140	32205.636	28.219141
SumSRLConstTraits_Core	8.761	29922.054	26.218226
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	8.951	29286.890	25.661684
SumSRLFastTraits	8.930	29353.797	25.720309

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	231.471	1132.513
SumSRL_Basic	181.228	1446.483	1.277233
SumSRL_Base_Core	180.322	1453.755	1.283655
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	18.051	14522.419	12.823182
SumSRLTraits	21.844	12000.746	10.596564
SumSRLTraits_Core	15.585	16820.279	14.852174
SumSRLConstTraits	15.017	17456.865	15.414275
SumSRLConstTraits_Core	14.282	18354.993	16.207314
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	17.122	15310.185	13.518773
SumSRLFastTraits	16.661	15733.755	13.892782

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	189.886	1380.535
SumSRL_Basic	355.601	737.186	0.533986
SumSRL_Base_Core	348.533	752.136	0.544814
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	38.173	6867.337	4.974402
SumSRLTraits	38.277	6848.619	4.960843
SumSRLTraits_Core	28.945	9056.677	6.560266
SumSRLConstTraits	30.031	8729.219	6.323069
SumSRLConstTraits_Core	31.784	8247.695	5.974274
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	36.628	7156.965	5.184196
SumSRLFastTraits	33.164	7904.437	5.725632

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	244.994	1070.000
SumSRL_Basic	666.799	393.138	0.367419
SumSRL_Base_Core	675.022	388.349	0.362943
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	75.292	3481.718	3.253942
SumSRLTraits	77.708	3373.438	3.152746
SumSRLTraits_Core	60.812	4310.722	4.028713
SumSRLConstTraits	59.916	4375.220	4.088992
SumSRLConstTraits_Core	57.118	4589.524	4.289275
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	70.562	3715.074	3.472032
SumSRLFastTraits	64.205	4082.896	3.815791

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	198.908	1317.919
SumSRLNetBcl	426.900	614.064	0.465934
SumSRLNetBcl_Const	267.691	979.279	0.743049
SumSRL_Basic	14.377	18234.177	13.835581
SumSRL_Base_Core	14.401	18203.678	13.812440
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	13.441	19503.269	14.798533
SumSRLTraits	13.427	19523.368	14.813784
SumSRLTraits_Core	8.724	30049.183	22.800476
SumSRLConstTraits	10.173	25769.708	19.553331
SumSRLConstTraits_Core	7.966	32908.088	24.969733
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	9.081	28868.622	21.904700
SumSRLFastTraits	9.119	28745.911	21.811590

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	198.293	1322.004
SumSRLNetBcl	17.701	14809.776	11.202521
SumSRLNetBcl_Const	14.489	18092.546	13.685699
SumSRL_Basic	16.793	15609.970	11.807810
SumSRL_Base_Core	17.857	14680.034	11.104381
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	19.053	13758.862	10.407581
SumSRLTraits	17.987	14574.237	11.024353
SumSRLTraits_Core	16.915	15497.392	11.722653
SumSRLConstTraits	14.974	17506.501	13.242398
SumSRLConstTraits_Core	16.033	16350.743	12.368151
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	18.163	14433.111	10.917602
SumSRLFastTraits	18.045	14527.394	10.988920

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	194.943	1344.719
SumSRLNetBcl	35.844	7313.562	5.438729
SumSRLNetBcl_Const	29.381	8922.247	6.635027
SumSRL_Basic	34.505	7597.169	5.649633
SumSRL_Base_Core	39.308	6669.024	4.959419
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	41.614	6299.407	4.684553
SumSRLTraits	39.047	6713.570	4.992545
SumSRLTraits_Core	30.281	8656.923	6.437719
SumSRLConstTraits	34.831	7526.184	5.596845
SumSRLConstTraits_Core	29.872	8775.590	6.525966
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	34.760	7541.490	5.608228
SumSRLFastTraits	35.648	7353.749	5.468614

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	196.637	1333.139
SumSRLNetBcl	70.465	3720.209	2.790565
SumSRLNetBcl_Const	60.490	4333.666	3.250724
SumSRL_Basic	69.633	3764.647	2.823897
SumSRL_Base_Core	68.850	3807.459	2.856012
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	77.539	3380.790	2.535963
SumSRLTraits	78.630	3333.889	2.500782
SumSRLTraits_Core	64.516	4063.224	3.047863
SumSRLConstTraits	60.219	4353.153	3.265342
SumSRLConstTraits_Core	65.133	4024.723	3.018983
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	69.618	3765.448	2.824498
SumSRLFastTraits	71.037	3690.236	2.768081

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

