# Benchmark - Shuffle
([← Back](README.md))
See [Group](Shuffle_Group.md)

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	259.772	1009.132
SumBase	258.718	1013.240	1.004071
SumTraits	258.876	1012.626	1.003462
SumTraits_Args0	259.825	1008.925	0.999795
SumTraits_Args	259.811	1008.981	0.999850
SumKernelTraits	259.157	1011.528	1.002374
SumKernelTraits_Args0	260.495	1006.331	0.997225
SumKernelTraits_Args	257.695	1017.264	1.008059

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	362.569	723.019
SumBase	364.665	718.863	0.994253
SumTraits	365.863	716.509	0.990997
SumTraits_Args0	365.857	716.520	0.991012
SumTraits_Args	362.652	722.854	0.999772
SumKernelTraits	362.859	722.441	0.999201
SumKernelTraits_Args0	361.733	724.689	1.002310
SumKernelTraits_Args	360.097	727.981	1.006863

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	570.025	459.881
SumBase	569.874	460.004	1.000265
SumTraits	570.744	459.302	0.998741
SumTraits_Args0	563.673	465.064	1.011269
SumTraits_Args	570.144	459.786	0.999792
SumKernelTraits	569.807	460.058	1.000384
SumKernelTraits_Args0	564.108	464.705	1.010489
SumKernelTraits_Args	565.919	463.218	1.007255

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	207.522	1263.210
SumBase	207.542	1263.090	0.999905
SumTraits	207.328	1264.393	1.000936
SumTraits_Args0	207.660	1262.368	0.999333
SumTraits_Args	214.601	1221.542	0.967013
SumKernelTraits	208.035	1260.097	0.997535
SumKernelTraits_Args0	207.975	1260.461	0.997824
SumKernelTraits_Args	208.006	1260.272	0.997674

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	260.129	1007.748
SumBase	258.749	1013.121	1.005332
SumTraits	259.831	1008.900	1.001144
SumTraits_Args0	265.155	988.646	0.981045
SumTraits_Args	264.314	991.790	0.984165
SumKernelTraits	259.731	1009.289	1.001529
SumKernelTraits_Args0	264.929	989.488	0.981881
SumKernelTraits_Args	264.749	990.161	0.982548

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	361.571	725.013
SumBase	361.863	724.428	0.999193
SumTraits	361.893	724.369	0.999112
SumTraits_Args0	372.557	703.636	0.970514
SumTraits_Args	369.397	709.654	0.978816
SumKernelTraits	361.469	725.218	1.000283
SumKernelTraits_Args0	371.128	706.345	0.974251
SumKernelTraits_Args	373.874	701.155	0.967093

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	572.427	457.952
SumBase	571.744	458.499	1.001195
SumTraits	570.032	459.876	1.004202
SumTraits_Args0	593.656	441.576	0.964241
SumTraits_Args	641.652	408.545	0.892114
SumKernelTraits	571.296	458.858	1.001980
SumKernelTraits_Args0	598.196	438.224	0.956923
SumKernelTraits_Args	636.419	411.905	0.899450

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	207.601	1262.732
SumBase	207.189	1265.241	1.001986
SumTraits	207.283	1264.667	1.001532
SumTraits_Args0	210.981	1242.503	0.983980
SumTraits_Args	210.031	1248.121	0.988429
SumKernelTraits	207.056	1266.056	1.002632
SumKernelTraits_Args0	210.468	1245.530	0.986377
SumKernelTraits_Args	209.830	1249.316	0.989375

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	264.178	992.299
SumBase	259.888	1008.682	1.016510
SumTraits	43.505	6025.629	6.072392
SumTraits_Args0	17.658	14845.370	14.960580
SumTraits_Args	17.901	14644.219	14.757868
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	44.416	5901.995	5.947799
SumKernelTraits	34.646	7566.266	7.624986
SumKernelTraits_Args0	17.423	15045.753	15.162519
SumKernelTraits_Args	17.593	14900.553	15.016192
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	39.178	6691.139	6.743067
SumKernel256_Avx2_ShiftLane	36.501	7181.794	7.237529
SumKernel256Traits	36.770	7129.297	7.184625
SumKernel256Traits_Args0	18.399	14247.517	14.358088
SumKernel256Traits_Args	18.880	13885.080	13.992838

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	371.936	704.809
SumBase	362.819	722.521	1.025130
SumTraits	50.250	5216.757	7.401659
SumTraits_Args0	28.253	9278.507	13.164567
SumTraits_Args	29.092	9010.834	12.784786
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	51.734	5067.112	7.189339
SumKernelTraits	27.436	9554.766	13.556529
SumKernelTraits_Args0	23.793	11017.874	15.632421
SumKernelTraits_Args	23.765	11030.886	15.650883
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	23.459	11174.456	15.854583
SumKernel256Traits_Args0	24.013	10916.589	15.488716
SumKernel256Traits_Args	26.161	10020.229	14.216938

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	1390.227	188.562
SumBase	571.713	458.524	2.431687
SumTraits	122.318	2143.129	11.365640
SumTraits_Args0	58.141	4508.754	23.911246
SumTraits_Args	58.697	4466.028	23.684659
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	131.518	1993.214	10.570601
SumKernelTraits	97.015	2702.105	14.330058
SumKernelTraits_Args0	54.378	4820.767	25.565944
SumKernelTraits_Args	53.671	4884.277	25.902753
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	81.248	3226.481	17.110974
SumKernel256_Avx2_DuplicateEven	77.988	3361.318	17.826057
SumKernel256_Avx2_Multiply	159.711	1641.368	8.704655
SumKernel256_Avx2_ShiftLane	80.151	3270.627	17.345096
SumKernel256Traits	78.423	3342.688	17.727254
SumKernel256Traits_Args0	48.230	5435.300	28.824989
SumKernel256Traits_Args	48.008	5460.464	28.958446

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	310.322	844.749
SumBase	207.741	1261.878	1.493790
SumTraits	19.800	13239.408	15.672585
SumTraits_Args0	8.245	31793.487	37.636586
SumTraits_Args	8.424	31118.400	36.837430
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	20.567	12745.930	15.088414
Sum256_Avx2_Add2	20.590	12731.326	15.071126
Sum256_Avx2_Cmp2	18.206	14398.765	17.045012
Sum256Traits	18.839	13914.661	16.471937
SumKernelTraits	13.109	19996.806	23.671877
SumKernelTraits_Args0	8.433	31084.955	36.797838
SumKernelTraits_Args	8.504	30827.152	36.492655
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	13.511	19401.960	22.967708
SumKernel256Traits_Args0	8.466	30964.751	36.655542
SumKernel256Traits_Args	8.455	31005.994	36.704365

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	261.003	1004.370
SumBase	253.541	1033.930	1.029432
SumTraits	32.532	8058.075	8.023015
SumTraits_Args0	17.967	14590.246	14.526766
SumTraits_Args	18.045	14527.035	14.463830
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	31.291	8377.537	8.341088
SumKernelTraits	27.943	9381.227	9.340410
SumKernelTraits_Args0	17.985	14575.460	14.512044
SumKernelTraits_Args	19.174	13672.167	13.612682
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	25.844	10143.220	10.099088
SumKernel256_Avx2_ShiftLane	26.223	9996.539	9.953045
SumKernel256Traits	25.771	10172.071	10.127814
SumKernel256Traits_Args0	17.680	14827.097	14.762587
SumKernel256Traits_Args	18.250	14364.013	14.301517

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	370.066	708.372
SumBase	350.042	748.893	1.057204
SumTraits	45.095	5813.206	8.206433
SumTraits_Args0	28.428	9221.310	13.017614
SumTraits_Args	28.603	9164.854	12.937915
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	34.032	7702.905	10.874099
SumKernelTraits	37.106	7064.711	9.973168
SumKernelTraits_Args0	23.633	11092.301	15.658869
SumKernelTraits_Args	23.896	10970.116	15.486382
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	23.720	11051.656	15.601492
SumKernel256Traits_Args0	26.350	9948.481	14.044152
SumKernel256Traits_Args	25.833	10147.550	14.325176

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	548.641	477.806
SumBase	547.939	478.418	1.001281
SumTraits	104.095	2518.325	5.270601
SumTraits_Args0	58.921	4449.098	9.311515
SumTraits_Args	62.196	4214.808	8.821169
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	101.448	2584.016	5.408086
SumKernelTraits	82.027	3195.810	6.688511
SumKernelTraits_Args0	55.706	4705.843	9.848856
SumKernelTraits_Args	48.245	5433.558	11.371892
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	89.620	2925.062	6.121861
SumKernel256_Avx2_DuplicateEven	115.062	2278.289	4.768230
SumKernel256_Avx2_Multiply	171.270	1530.592	3.203376
SumKernel256_Avx2_ShiftLane	115.931	2261.214	4.732495
SumKernel256Traits	120.271	2179.618	4.561722
SumKernel256Traits_Args0	84.193	3113.626	6.516507
SumKernel256Traits_Args	62.881	4168.885	8.725058

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	258.544	1013.924
SumBase	240.431	1090.308	1.075334
SumTraits	14.755	17766.242	17.522254
SumTraits_Args0	8.342	31423.344	30.991800
SumTraits_Args	8.292	31615.120	31.180942
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	13.992	18735.483	18.478184
Sum256_Avx2_Add2	14.876	17621.875	17.379870
Sum256_Avx2_Cmp2	13.413	19544.513	19.276103
Sum256Traits	11.830	22158.597	21.854288
SumKernelTraits	11.382	23032.250	22.715943
SumKernelTraits_Args0	8.463	30974.022	30.548648
SumKernelTraits_Args	8.529	30734.831	30.312742
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	10.077	26014.344	25.657083
SumKernel256Traits_Args0	8.458	30993.177	30.567540
SumKernel256Traits_Args	8.388	31250.668	30.821495

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	253.301	1034.912
SumBase	258.301	1014.877	0.980641
SumTraits	32.697	8017.278	7.746821
SumTraits_Args0	18.188	14413.193	13.926974
SumTraits_Args	18.463	14198.718	13.719734
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	30.580	8572.468	8.283282
SumKernelTraits	27.348	9585.573	9.262210
SumKernelTraits_Args0	18.124	14464.147	13.976208
SumKernelTraits_Args	18.009	14556.627	14.065569
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	25.492	10283.465	9.936559
SumKernel256_Avx2_ShiftLane	26.255	9984.497	9.647676
SumKernel256Traits	25.549	10260.544	9.914412
SumKernel256Traits_Args0	22.896	11449.426	11.063187
SumKernel256Traits_Args	18.759	13974.440	13.503022

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	356.475	735.378
SumBase	366.603	715.063	0.972375
SumTraits	36.718	7139.337	9.708394
SumTraits_Args0	28.619	9159.683	12.455754
SumTraits_Args	29.152	8992.356	12.228215
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	30.619	8561.380	11.642153
SumKernelTraits	37.815	6932.192	9.426709
SumKernelTraits_Args0	23.543	11134.924	15.141776
SumKernelTraits_Args	24.942	10510.208	14.292258
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	26.609	9851.523	13.396549
SumKernel256Traits_Args0	26.432	9917.648	13.486468
SumKernel256Traits_Args	26.909	9741.727	13.247243

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	570.819	459.242
SumBase	570.426	459.559	1.000690
SumTraits	107.725	2433.449	5.298844
SumTraits_Args0	59.484	4406.994	9.596245
SumTraits_Args	61.057	4293.438	9.348975
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	169.146	1549.809	3.374715
SumKernelTraits	152.877	1714.735	3.733841
SumKernelTraits_Args0	64.851	4042.262	8.802040
SumKernelTraits_Args	63.312	4140.529	9.016016
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	158.658	1652.260	3.597801
SumKernel256_Avx2_DuplicateEven	141.988	1846.244	4.020202
SumKernel256_Avx2_Multiply	185.095	1416.268	3.083929
SumKernel256_Avx2_ShiftLane	111.417	2352.816	5.123264
SumKernel256Traits	99.414	2636.886	5.741829
SumKernel256Traits_Args0	58.062	4514.884	9.831175
SumKernel256Traits_Args	57.779	4537.030	9.879398

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	243.286	1077.513
SumBase	244.728	1071.163	0.994107
SumTraits	16.241	16140.964	14.979830
SumTraits_Args0	8.371	31314.488	29.061816
SumTraits_Args	8.197	31980.794	29.680190
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	13.074	20051.159	18.608738
Sum256_Avx2_Add2	13.316	19686.080	18.269922
Sum256_Avx2_Cmp2	11.961	21917.193	20.340535
Sum256Traits	12.168	21543.760	19.993966
SumKernelTraits	10.990	23853.314	22.137377
SumKernelTraits_Args0	8.214	31913.287	29.617539
SumKernelTraits_Args	8.113	32311.418	29.987030
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	9.707	27007.048	25.064240
SumKernel256Traits_Args0	8.169	32091.019	29.782485
SumKernel256Traits_Args	8.136	32222.099	29.904136

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	265.048	989.043
SumBase	260.370	1006.813	1.017966
SumTraits	28.934	9060.106	9.160475
SumTraits_Args0	18.449	14209.436	14.366849
SumTraits_Args	18.692	14024.591	14.179956
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	337.883	775.841	0.784436
Sum256Traits	22.005	11912.737	12.044707
SumKernelTraits	25.376	10330.592	10.445035
SumKernelTraits_Args0	18.098	14484.413	14.644872
SumKernelTraits_Args	18.357	14280.139	14.438335
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	19.401	13511.561	13.661243
SumKernel256_Avx2_ShiftLane	24.505	10697.449	10.815956
SumKernel256Traits	19.235	13628.575	13.779553
SumKernel256Traits_Args0	18.347	14287.774	14.446055
SumKernel256Traits_Args	18.432	14222.289	14.379845

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	350.624	747.651
SumBase	349.832	749.342	1.002261
SumTraits	28.338	9250.625	12.372921
SumTraits_Args0	26.946	9728.639	13.012276
SumTraits_Args	26.671	9828.623	13.146007
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	428.765	611.393	0.817752
Sum256Traits	27.433	9555.813	12.781118
SumKernelTraits	26.222	9996.960	13.371162
SumKernelTraits_Args0	23.242	11279.116	15.086074
SumKernelTraits_Args	23.148	11324.558	15.146854
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	25.026	10475.013	14.010568
SumKernel256Traits_Args0	26.028	10071.736	13.471176
SumKernel256Traits_Args	25.948	10102.702	13.512595

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	567.386	462.021
SumBase	589.084	445.003	0.963167
SumTraits	74.382	3524.309	7.628036
SumTraits_Args0	58.455	4484.512	9.706305
SumTraits_Args	61.384	4270.565	9.243236
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	508.166	515.863	1.116537
Sum256Traits	65.541	3999.694	8.656962
SumKernelTraits	64.789	4046.124	8.757456
SumKernelTraits_Args0	53.692	4882.344	10.567375
SumKernelTraits_Args	54.748	4788.233	10.363680
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	67.158	3903.387	8.448514
SumKernel256_Avx2_DuplicateEven	56.803	4614.976	9.988683
SumKernel256_Avx2_Multiply	117.836	2224.655	4.815057
SumKernel256_Avx2_ShiftLane	58.532	4478.636	9.693586
SumKernel256Traits	60.134	4359.323	9.435344
SumKernel256Traits_Args0	54.122	4843.565	10.483441
SumKernel256Traits_Args	53.669	4884.430	10.571891

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	207.732	1261.932
SumBase	209.558	1250.940	0.991289
SumTraits	10.683	24537.440	19.444339
SumTraits_Args0	7.638	34322.789	27.198596
SumTraits_Args	7.906	33156.240	26.274181
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	281.776	930.329	0.737226
Sum256_Avx2_Add1	10.286	25485.263	20.195427
Sum256_Avx2_Add2	10.327	25385.425	20.116312
Sum256_Avx2_Cmp2	10.271	25522.923	20.225270
Sum256Traits	8.636	30353.955	24.053552
SumKernelTraits	8.853	29612.169	23.465734
SumKernelTraits_Args0	7.792	33643.052	26.659948
SumKernelTraits_Args	7.949	32977.071	26.132202
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	7.774	33722.566	26.722958
SumKernel256Traits_Args0	7.901	33179.123	26.292315
SumKernel256Traits_Args	8.147	32176.595	25.497876

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	617.048	424.835
SumBase	618.215	424.034	0.998113
SumTraits	618.349	423.942	0.997897
SumTraits_Args0	618.450	423.872	0.997733
SumTraits_Args	654.106	400.767	0.943347
Sum128Traits	1099.151	238.497	0.561386
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	617.803	424.317	0.998779
SumKernelTraits_Args0	618.411	423.899	0.997797
SumKernelTraits_Args	655.734	399.772	0.941003
SumKernel128Traits	1099.154	238.496	0.561385
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	909.556	288.211
SumBase	910.562	287.892	0.998894
SumTraits	910.405	287.942	0.999067
SumTraits_Args0	914.522	286.646	0.994569
SumTraits_Args	975.916	268.613	0.932002
Sum128Traits	1711.337	153.181	0.531488
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	910.537	287.900	0.998922
SumKernelTraits_Args0	914.811	286.556	0.994256
SumKernelTraits_Args	975.029	268.858	0.932850
SumKernel128Traits	1710.698	153.238	0.531687
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	692.353	378.628
SumBase	690.819	379.468	1.002220
SumTraits	690.501	379.643	1.002681
SumTraits_Args0	689.612	380.133	1.003974
SumTraits_Args	802.639	326.603	0.862595
Sum128Traits	1260.883	207.905	0.549101
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	690.405	379.696	1.002821
SumKernelTraits_Args0	690.238	379.788	1.003064
SumKernelTraits_Args	1533.394	170.957	0.451516
SumKernel128Traits	1261.539	207.797	0.548816
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	392.167	668.450
SumBase	394.553	664.408	0.993953
SumTraits	392.709	667.527	0.998619
SumTraits_Args0	394.209	664.988	0.994820
SumTraits_Args	419.156	625.410	0.935612
Sum128Traits	656.703	399.182	0.597175
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	392.854	667.280	0.998249
SumKernelTraits_Args0	394.253	664.914	0.994709
SumKernelTraits_Args	418.920	625.761	0.936137
SumKernel128Traits	655.121	400.146	0.598617
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	620.773	422.286
SumBase	619.553	423.118	1.001968
SumTraits	53.227	4925.034	11.662782
SumTraits_Args0	31.277	8381.395	19.847654
SumTraits_Args	87.887	2982.755	7.063346
Sum128_AdvSimd	82.720	3169.036	7.504470
Sum128Traits	49.856	5258.028	12.451331
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	46.440	5644.808	13.367249
SumKernelTraits_Args0	33.259	7881.823	18.664638
SumKernelTraits_Args	87.908	2982.013	7.061588
SumKernel128_AdvSimd	75.777	3459.399	8.192067
SumKernel128Traits	39.892	6571.362	15.561385
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	932.627	281.081
SumBase	934.743	280.445	0.997736
SumTraits	107.093	2447.812	8.708555
SumTraits_Args0	63.890	4103.084	14.597496
SumTraits_Args	176.269	1487.180	5.290924
Sum128_AdvSimd	190.206	1378.213	4.903254
Sum128Traits	106.122	2470.216	8.788260
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	93.444	2805.355	9.980581
SumKernelTraits_Args0	63.740	4112.689	14.631669
SumKernelTraits_Args	176.288	1487.021	5.290357
SumKernel128_AdvSimd	153.383	1709.084	6.080389
SumKernel128Traits	80.983	3237.010	11.516274
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	1392.908	188.199
SumBase	1378.743	190.133	1.010274
SumTraits	258.064	1015.811	5.397537
SumTraits_Args0	125.311	2091.948	11.115616
SumTraits_Args	352.803	743.033	3.948122
Sum128_AdvSimd	442.549	592.351	3.147469
Sum128Traits	213.126	1229.996	6.535611
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	214.534	1221.923	6.492718
SumKernelTraits_Args0	125.061	2096.124	11.137806
SumKernelTraits_Args	366.362	715.532	3.801998
SumKernel128_AdvSimd	281.663	930.700	4.945298
SumKernel128_Arm_Multiply	559.306	468.695	2.490423
SumKernel128Traits	180.041	1456.022	7.736606
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	402.882	650.673
SumBase	405.471	646.518	0.993614
SumTraits	19.957	13135.356	20.187353
SumTraits_Args0	16.661	15734.264	24.181540
SumTraits_Args	45.801	5723.523	8.796319
Sum128_AdvSimd	22.295	11758.135	18.070742
Sum128Traits	16.649	15745.672	24.199072
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	16.821	15584.505	23.951380
SumKernelTraits_Args0	15.667	16731.942	25.714843
SumKernelTraits_Args	45.798	5723.910	8.796913
SumKernel128_AdvSimd	22.297	11756.736	18.068591
SumKernel128Traits	16.645	15748.984	24.204163
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	619.624	423.070
SumBase	619.890	422.888	0.999570
SumTraits	53.086	4938.077	11.672023
SumTraits_Args0	33.343	7862.055	18.583364
SumTraits_Args	88.082	2976.138	7.034631
Sum128_AdvSimd	84.132	3115.859	7.364886
Sum128Traits	52.712	4973.134	11.754885
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	39.927	6565.519	15.518770
SumKernelTraits_Args0	33.403	7847.868	18.549830
SumKernelTraits_Args	91.394	2868.286	6.779704
SumKernel128_AdvSimd	77.391	3387.257	8.006384
SumKernel128Traits	40.040	6547.047	15.475110
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	947.505	276.668
SumBase	930.935	281.592	1.017799
SumTraits	102.340	2561.501	9.258405
SumTraits_Args0	63.773	4110.550	14.857355
SumTraits_Args	176.648	1483.994	5.363814
Sum128_AdvSimd	167.872	1561.574	5.644222
Sum128Traits	106.510	2461.214	8.895923
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	80.975	3237.345	11.701206
SumKernelTraits_Args0	63.498	4128.402	14.921880
SumKernelTraits_Args	183.266	1430.400	5.170100
SumKernel128_AdvSimd	156.471	1675.348	6.055451
SumKernel128Traits	83.356	3144.886	11.367018
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	586.394	447.044
SumBase	573.861	456.808	1.021840
SumTraits	240.581	1089.628	2.437406
SumTraits_Args0	133.219	1967.766	4.401725
SumTraits_Args	351.915	744.908	1.666296
Sum128_AdvSimd	475.532	551.265	1.233133
Sum128Traits	240.340	1090.720	2.439848
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	177.103	1480.182	3.311042
SumKernelTraits_Args0	125.096	2095.536	4.687538
SumKernelTraits_Args	365.333	717.549	1.605097
SumKernel128_AdvSimd	291.937	897.948	2.008634
SumKernel128_Arm_Multiply	531.634	493.091	1.103002
SumKernel128Traits	185.506	1413.132	3.161056
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	397.198	659.984
SumBase	403.817	649.166	0.983609
SumTraits	15.685	16713.009	25.323364
SumTraits_Args0	16.688	15708.758	23.801734
SumTraits_Args	44.067	5948.766	9.013503
Sum128_AdvSimd	22.320	11744.858	17.795677
Sum128Traits	15.675	16723.857	25.339801
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	16.758	15643.225	23.702439
SumKernelTraits_Args0	15.711	16685.534	25.281733
SumKernelTraits_Args	44.054	5950.549	9.016205
SumKernel128_AdvSimd	23.328	11237.339	17.026690
SumKernel128Traits	16.676	15720.302	23.819225
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	498.305	526.071
SumBase	497.736	526.673	1.001144
SumTraits	44.786	5853.245	11.126342
SumTraits_Args0	26.690	9821.786	18.670080
SumTraits_Args	26.833	9769.321	18.570351
Sum128_Bcl	543.507	482.320	0.916834
Sum128_AdvSimd	80.928	3239.207	6.157358
Sum128Traits	44.721	5861.744	11.142498
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	33.162	7904.834	15.026176
SumKernelTraits_Args0	26.652	9835.768	18.696659
SumKernelTraits_Args	26.809	9778.383	18.587576
SumKernel128_AdvSimd	65.652	3992.953	7.590142
SumKernel128Traits	33.148	7908.342	15.032844
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	826.254	317.268
SumBase	828.926	316.245	0.996776
SumTraits	89.994	2912.918	9.181248
SumTraits_Args0	54.651	4796.704	15.118769
SumTraits_Args	54.889	4775.891	15.053168
Sum128_Bcl	863.161	303.702	0.957241
Sum128_AdvSimd	164.794	1590.734	5.013847
Sum128Traits	89.982	2913.303	9.182463
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	67.053	3909.519	12.322444
SumKernelTraits_Args0	54.328	4825.180	15.208522
SumKernelTraits_Args	55.122	4755.708	14.989551
SumKernel128_AdvSimd	131.947	1986.736	6.262010
SumKernel128Traits	67.175	3902.403	12.300014
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	474.449	552.523
SumBase	1204.560	217.626	0.393878
SumTraits	210.972	1242.552	2.248871
SumTraits_Args0	106.312	2465.800	4.462803
SumTraits_Args	106.868	2452.967	4.439578
Sum128_Bcl	368.167	712.025	1.288679
Sum128_AdvSimd	433.118	605.249	1.095428
Sum128Traits	207.855	1261.187	2.282598
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	149.244	1756.478	3.179016
SumKernelTraits_Args0	106.361	2464.674	4.460766
SumKernelTraits_Args	106.675	2457.398	4.447598
SumKernel128_AdvSimd	285.721	917.481	1.660532
SumKernel128_Arm_Multiply	460.718	568.990	1.029805
SumKernel128Traits	149.598	1752.322	3.171494
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	314.351	833.921
SumBase	313.934	835.029	1.001328
SumTraits	13.287	19730.059	23.659380
SumTraits_Args0	13.279	19741.441	23.673029
SumTraits_Args	13.312	19692.665	23.614539
Sum128_Bcl	403.929	648.985	0.778233
Sum128_AdvSimd	19.957	13135.344	15.751300
Sum128Traits	13.257	19773.665	23.711670
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	13.279	19741.523	23.673127
SumKernelTraits_Args0	13.289	19726.599	23.655231
SumKernelTraits_Args	13.317	19685.073	23.605434
SumKernel128_AdvSimd	19.967	13128.541	15.743143
SumKernel128Traits	13.254	19778.235	23.717151
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

