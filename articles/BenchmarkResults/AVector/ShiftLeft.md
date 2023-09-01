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
SumSLLScalar	307.031	853.802
SumSLL_Basic	32.484	8069.914	9.451742
SumSLL_Base_Core	6.808	38503.998	45.097120
SumSLL_Multiply	31.223	8395.966	9.833626
SumSLLTraits	31.596	8296.682	9.717341
SumSLLTraits_Core	7.865	33328.333	39.035215
SumSLLConstTraits	24.161	10849.899	12.707751
SumSLLConstTraits_Core	7.175	36537.668	42.794092
SumSLLFast_Multiply	23.472	11168.370	13.080754
SumSLLFastTraits	23.500	11154.884	13.064959

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	318.264	823.668
SumSLL_Basic	49.482	5297.801	6.431965
SumSLL_Base_Core	12.966	20217.733	24.545987
SumSLL_Base_Core_Element	54.079	4847.459	5.885213
SumSLL_Base_Core_Mov	53.706	4881.116	5.926075
SumSLL_Multiply	50.952	5144.957	6.246400
SumSLLTraits	51.643	5076.036	6.162725
SumSLLTraits_Core	12.901	20318.984	24.668914
SumSLLConstTraits	44.437	5899.256	7.162181
SumSLLConstTraits_Core	12.995	20172.952	24.491618
SumSLLFast_Multiply	46.679	5615.882	6.818141
SumSLLFastTraits	47.228	5550.577	6.738856

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	326.250	803.506
SumSLL_Basic	113.212	2315.510	2.881758
SumSLL_Base_Core	31.045	8444.097	10.509066
SumSLL_Multiply	104.709	2503.559	3.115794
SumSLLTraits	101.944	2571.456	3.200295
SumSLLTraits_Core	30.573	8574.361	10.671186
SumSLLConstTraits	175.513	1493.590	1.858841
SumSLLConstTraits_Core	30.957	8467.974	10.538782
SumSLLFast_Multiply	92.009	2849.113	3.545852
SumSLLFastTraits	90.215	2905.785	3.616382

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	328.624	797.703
SumSLL_Basic	597.978	438.384	0.549558
SumSLL_Base_Core	595.367	440.306	0.551968
SumSLLTraits	613.992	426.950	0.535225
SumSLLTraits_Core	593.922	441.378	0.553311
SumSLLConstTraits	534.840	490.135	0.614434
SumSLLConstTraits_Core	533.612	491.263	0.615847
SumSLLFastTraits	552.496	474.472	0.594798

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
SumSLLScalar	320.655	817.528
SumSLL_Basic	34.083	7691.254	9.407944
SumSLL_Base_Core	9.266	28291.374	34.606018
SumSLL_Multiply	31.801	8243.188	10.083070
SumSLLTraits	32.307	8114.085	9.925151
SumSLLTraits_Core	7.384	35503.285	43.427629
SumSLLConstTraits	25.779	10168.754	12.438424
SumSLLConstTraits_Core	8.234	31837.586	38.943745
SumSLLFast_Multiply	25.465	10294.128	12.591781
SumSLLFastTraits	25.464	10294.789	12.592590

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	325.081	806.395
SumSLL_Basic	51.303	5109.682	6.336452
SumSLL_Base_Core	13.628	19235.490	23.853690
SumSLL_Base_Core_Element	56.723	4621.513	5.731080
SumSLL_Base_Core_Mov	55.034	4763.353	5.906974
SumSLL_Multiply	50.799	5160.423	6.399375
SumSLLTraits	51.936	5047.453	6.259283
SumSLLTraits_Core	13.827	18959.033	23.510858
SumSLLConstTraits	46.046	5693.084	7.059922
SumSLLConstTraits_Core	13.555	19339.311	23.982436
SumSLLFast_Multiply	45.148	5806.351	7.200382
SumSLLFastTraits	45.957	5704.171	7.073671

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	319.439	820.639
SumSLL_Basic	106.659	2457.767	2.994943
SumSLL_Base_Core	30.748	8525.641	10.389029
SumSLL_Multiply	98.968	2648.774	3.227697
SumSLLTraits	97.856	2678.866	3.264366
SumSLLTraits_Core	30.965	8465.712	10.316002
SumSLLConstTraits	89.711	2922.103	3.560766
SumSLLConstTraits_Core	30.642	8554.920	10.424708
SumSLLFast_Multiply	91.359	2869.379	3.496519
SumSLLFastTraits	89.542	2927.619	3.567487

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	321.057	816.504
SumSLL_Basic	577.214	454.154	0.556218
SumSLL_Base_Core	598.518	437.988	0.536419
SumSLLTraits	571.722	458.517	0.561561
SumSLLTraits_Core	565.530	463.537	0.567709
SumSLLConstTraits	488.210	536.949	0.657620
SumSLLConstTraits_Core	492.802	531.946	0.651493
SumSLLFastTraits	531.356	493.349	0.604222

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
SumSLLScalar	237.236	1104.993
SumSLL_Basic	17.598	14896.610	13.481178
SumSLL_Base_Core	6.373	41134.136	37.225690
SumSLL_Multiply	18.063	14512.566	13.133624
SumSLL_Avx2	12.410	21122.908	19.115870
SumSLLTraits	12.019	21811.573	19.739100
SumSLLTraits_Core	6.295	41644.146	37.687241
SumSLLConstTraits	10.473	25029.290	22.651079
SumSLLConstTraits_Core	6.669	39307.523	35.572637
SumSLLFast_Multiply	10.879	24095.249	21.805789
SumSLLFast_Avx2	10.431	25132.166	22.744180
SumSLLFastTraits	10.545	24859.770	22.497667

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	222.886	1176.133
SumSLL_Basic	23.612	11101.944	9.439363
SumSLL_Base_Core	13.484	19440.526	16.529194
SumSLL_Base_Core_Element	25.088	10448.984	8.884188
SumSLL_Base_Core_Mov	25.731	10187.989	8.662278
SumSLL_Multiply	23.335	11234.065	9.551698
SumSLL_Avx2	15.763	16630.499	14.139985
SumSLLTraits	15.433	16986.361	14.442554
SumSLLTraits_Core	12.989	20182.655	17.160185
SumSLLConstTraits	15.471	16944.673	14.407109
SumSLLConstTraits_Core	14.241	18407.673	15.651017
SumSLLFast_Multiply	16.753	15647.790	13.304442
SumSLLFast_Avx2	15.097	17363.745	14.763423
SumSLLFastTraits	14.651	17892.967	15.213391

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	200.475	1307.614
SumSLL_Basic	43.989	5959.311	4.557392
SumSLL_Base_Core	30.141	8697.140	6.651151
SumSLL_Multiply	45.309	5785.642	4.424578
SumSLL_Avx2	32.262	8125.443	6.213945
SumSLLTraits	31.789	8246.402	6.306448
SumSLLTraits_Core	25.399	10320.833	7.892873
SumSLLConstTraits	32.145	8155.046	6.236583
SumSLLConstTraits_Core	26.791	9784.699	7.482863
SumSLLFast_Multiply	33.695	7779.964	5.949739
SumSLLFast_Avx2	29.173	8985.776	6.871886
SumSLLFastTraits	30.924	8477.082	6.482861

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	202.426	1295.009
SumSLL_Basic	550.348	476.324	0.367815
SumSLL_Base_Core	548.601	477.841	0.368987
SumSLL_Avx2	66.193	3960.310	3.058132
SumSLLTraits	67.788	3867.136	2.986184
SumSLLTraits_Core	54.580	4802.911	3.708785
SumSLLConstTraits	66.718	3929.109	3.034039
SumSLLConstTraits_Core	53.172	4930.099	3.806999
SumSLLFast_Avx2	59.437	4410.488	3.405758
SumSLLFastTraits	59.140	4432.603	3.422835

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
SumSLLScalar	234.396	1118.381
SumSLL_Basic	17.376	15086.467	13.489556
SumSLL_Base_Core	6.602	39705.639	35.502776
SumSLL_Multiply	17.365	15095.835	13.497932
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	12.372	21189.173	18.946287
SumSLLTraits	13.133	19960.732	17.847877
SumSLLTraits_Core	7.342	35703.816	31.924547
SumSLLConstTraits	8.808	29761.737	26.611441
SumSLLConstTraits_Core	7.343	35698.909	31.920160
SumSLLFast_Multiply	10.378	25259.278	22.585570
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	8.090	32403.191	28.973295
SumSLLFastTraits	7.759	33783.717	30.207692

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	221.412	1183.966
SumSLL_Basic	22.093	11865.556	10.021872
SumSLL_Base_Core	13.993	18733.935	15.823035
SumSLL_Base_Core_Element	24.399	10743.950	9.074543
SumSLL_Base_Core_Mov	25.046	10466.564	8.840258
SumSLL_Multiply	23.191	11303.627	9.547257
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	15.691	16706.706	14.110799
SumSLLTraits	15.741	16653.329	14.065716
SumSLLTraits_Core	14.824	17683.717	14.936001
SumSLLConstTraits	13.528	19378.434	16.367391
SumSLLConstTraits_Core	13.206	19850.711	16.766285
SumSLLFast_Multiply	20.209	12971.552	10.956017
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	24.626	10645.162	8.991105
SumSLLFastTraits	13.188	19877.381	16.788811

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	197.293	1328.703
SumSLL_Basic	44.308	5916.353	4.452727
SumSLL_Base_Core	29.302	8946.409	6.733188
SumSLL_Multiply	44.989	5826.821	4.385344
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	33.046	7932.724	5.970275
SumSLLTraits	33.609	7799.748	5.870196
SumSLLTraits_Core	25.186	10408.381	7.833488
SumSLLConstTraits	28.208	9293.148	6.994148
SumSLLConstTraits_Core	25.243	10384.732	7.815690
SumSLLFast_Multiply	34.997	7490.489	5.637443
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	26.496	9893.850	7.446245
SumSLLFastTraits	27.901	9395.637	7.071283

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	200.783	1305.611
SumSLL_Basic	567.569	461.872	0.353759
SumSLL_Base_Core	567.550	461.887	0.353771
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	65.291	4014.993	3.075184
SumSLLTraits	66.500	3941.999	3.019276
SumSLLTraits_Core	54.466	4813.018	3.686411
SumSLLConstTraits	65.241	4018.072	3.077543
SumSLLConstTraits_Core	55.334	4737.462	3.628541
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	62.046	4224.984	3.236022
SumSLLFastTraits	61.674	4250.476	3.255546

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
SumSLLScalar	190.754	1374.255
SumSLL_Basic	16.520	15868.727	11.547148
SumSLL_Base_Core	6.765	38750.970	28.197799
SumSLL_Multiply	16.773	15628.465	11.372317
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	12.292	21327.063	15.518998
SumSLLTraits	12.457	21044.192	15.313162
SumSLLTraits_Core	7.159	36615.138	26.643625
SumSLLConstTraits	7.759	33785.502	24.584592
SumSLLConstTraits_Core	7.347	35679.744	25.962969
SumSLLFast_Multiply	10.680	24544.667	17.860342
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.737	33882.537	24.655201
SumSLLFastTraits	7.785	33672.008	24.502006

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	190.029	1379.498
SumSLL_Basic	19.141	13695.366	9.927793
SumSLL_Base_Core	13.801	18994.672	13.769269
SumSLL_Base_Core_Element	21.563	12157.192	8.812768
SumSLL_Base_Core_Mov	23.164	11316.808	8.203572
SumSLL_Multiply	20.675	12679.057	9.191069
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	16.018	16366.063	11.863786
SumSLLTraits	15.891	16496.182	11.958109
SumSLLTraits_Core	14.170	18500.302	13.410899
SumSLLConstTraits	12.448	21059.682	15.266198
SumSLLConstTraits_Core	12.346	21232.279	15.391314
SumSLLFast_Multiply	15.162	17289.218	12.532982
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	13.672	19174.068	13.899313
SumSLLFastTraits	13.778	19025.720	13.791776

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	119.173	2199.685
SumSLL_Basic	43.418	6037.703	2.744803
SumSLL_Base_Core	30.567	8576.075	3.898774
SumSLL_Multiply	44.291	5918.716	2.690711
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	33.340	7862.673	3.574454
SumSLLTraits	31.886	8221.382	3.737527
SumSLLTraits_Core	24.668	10626.910	4.831105
SumSLLConstTraits	24.779	10579.400	4.809507
SumSLLConstTraits_Core	26.774	9790.898	4.451045
SumSLLFast_Multiply	33.937	7724.487	3.511633
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	29.603	8855.262	4.025695
SumSLLFastTraits	30.325	8644.394	3.929833

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	128.280	2043.527
SumSLL_Basic	558.444	469.419	0.229710
SumSLL_Base_Core	559.391	468.624	0.229321
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	62.227	4212.691	2.061480
SumSLLTraits	66.118	3964.762	1.940156
SumSLLTraits_Core	54.886	4776.182	2.337224
SumSLLConstTraits	55.477	4725.293	2.312322
SumSLLConstTraits_Core	54.814	4782.430	2.340282
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	62.169	4216.614	2.063400
SumSLLFastTraits	58.552	4477.111	2.190874

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
SumSLLScalar	177.097	1480.225
SumSLLNetBcl	232.337	1128.290	0.762242
SumSLLNetBcl_Const	230.443	1137.564	0.768507
SumSLL_Basic	13.953	18787.783	12.692519
SumSLL_Base_Core	7.044	37216.349	25.142361
SumSLL_Multiply	13.918	18834.959	12.724390
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	11.120	23574.046	15.925990
SumSLLTraits	11.361	23074.627	15.588596
SumSLLTraits_Core	7.974	32872.874	22.208027
SumSLLConstTraits	7.977	32862.094	22.200744
SumSLLConstTraits_Core	7.711	33994.997	22.966103
SumSLLFast_Multiply	8.854	29608.849	20.002939
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.899	33187.674	22.420697
SumSLLFastTraits	8.035	32623.259	22.039393

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	176.302	1486.900
SumSLLNetBcl	14.212	18445.571	12.405384
SumSLLNetBcl_Const	13.758	19054.243	12.814740
SumSLL_Basic	15.734	16661.204	11.205326
SumSLL_Base_Core	15.626	16775.685	11.282319
SumSLL_Base_Core_Element	17.705	14806.369	9.957875
SumSLL_Base_Core_Mov	16.889	15521.448	10.438795
SumSLL_Multiply	19.507	13438.190	9.037720
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	16.334	16048.877	10.793512
SumSLLTraits	16.268	16114.543	10.837675
SumSLLTraits_Core	14.217	18439.182	12.401087
SumSLLConstTraits	13.393	19572.551	13.163324
SumSLLConstTraits_Core	14.454	18136.492	12.197516
SumSLLFast_Multiply	16.374	16009.810	10.767238
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	15.676	16722.841	11.246779
SumSLLFastTraits	15.547	16861.299	11.339898

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	165.175	1587.071
SumSLLNetBcl	27.682	9469.894	5.966899
SumSLLNetBcl_Const	24.596	10657.900	6.715451
SumSLL_Basic	27.413	9562.776	6.025423
SumSLL_Base_Core	30.764	8521.214	5.369144
SumSLL_Multiply	40.120	6534.076	4.117066
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	32.679	8021.776	5.054452
SumSLLTraits	27.323	9594.126	6.045177
SumSLLTraits_Core	26.122	10035.217	6.323105
SumSLLConstTraits	25.737	10185.431	6.417753
SumSLLConstTraits_Core	25.379	10329.112	6.508285
SumSLLFast_Multiply	34.263	7651.018	4.820841
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	29.267	8956.954	5.643700
SumSLLFastTraits	27.308	9599.512	6.048570

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	170.688	1535.809
SumSLLNetBcl	63.273	4143.077	2.697651
SumSLLNetBcl_Const	53.465	4903.130	3.192539
SumSLL_Basic	66.666	3932.215	2.560354
SumSLL_Base_Core	65.642	3993.552	2.600292
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	71.152	3684.303	2.398933
SumSLLTraits	70.587	3713.754	2.418109
SumSLLTraits_Core	56.337	4653.104	3.029741
SumSLLConstTraits	55.629	4712.366	3.068328
SumSLLConstTraits_Core	59.965	4371.649	2.846480
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	68.285	3838.971	2.499641
SumSLLFastTraits	64.048	4092.936	2.665003

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

