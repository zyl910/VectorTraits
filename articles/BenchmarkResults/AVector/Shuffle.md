# Benchmark - Shuffle
([← Back](README.md))

See [Group](Shuffle_Group.md)

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	257.848	1016.659
SumBase	263.215	995.932	0.979612
SumTraits	262.032	1000.426	0.984033
SumTraits_Args0	258.133	1015.537	0.998896
SumTraits_Args	257.761	1017.006	1.000341
SumKernelTraits	263.780	993.796	0.977512
SumKernelTraits_Args0	259.175	1011.454	0.994880
SumKernelTraits_Args	257.648	1017.448	1.000776

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	360.534	727.100
SumBase	369.956	708.582	0.974532
SumTraits	370.369	707.791	0.973444
SumTraits_Args0	360.088	728.000	1.001238
SumTraits_Args	382.509	685.328	0.942550
SumKernelTraits	370.116	708.275	0.974109
SumKernelTraits_Args0	360.788	726.587	0.999295
SumKernelTraits_Args	382.129	686.010	0.943488

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	567.078	462.272
SumBase	591.987	442.821	0.957923
SumTraits	592.116	442.724	0.957713
SumTraits_Args0	559.960	468.147	1.012710
SumTraits_Args	561.333	467.003	1.010234
SumKernelTraits	590.629	443.839	0.960125
SumKernelTraits_Args0	559.729	468.341	1.013129
SumKernelTraits_Args	572.805	457.650	0.990001

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	206.017	1272.437
SumBase	208.615	1256.592	0.987547
SumTraits	208.684	1256.174	0.987219
SumTraits_Args0	205.497	1275.660	1.002533
SumTraits_Args	205.802	1273.766	1.001044
SumKernelTraits	211.703	1238.263	0.973143
SumKernelTraits_Args0	206.070	1272.109	0.999742
SumKernelTraits_Args	206.282	1270.804	0.998716

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	257.346	1018.646
SumBase	257.681	1017.320	0.998699
SumTraits	257.875	1016.556	0.997949
SumTraits_Args0	258.523	1014.005	0.995445
SumTraits_Args	255.462	1026.157	1.007374
SumKernelTraits	258.418	1014.420	0.995851
SumKernelTraits_Args0	258.017	1015.994	0.997397
SumKernelTraits_Args	255.253	1026.997	1.008198

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	359.700	728.785
SumBase	360.183	727.808	0.998658
SumTraits	360.260	727.651	0.998444
SumTraits_Args0	360.194	727.785	0.998627
SumTraits_Args	357.078	734.136	1.007342
SumKernelTraits	359.498	729.196	1.000563
SumKernelTraits_Args0	360.384	727.401	0.998101
SumKernelTraits_Args	357.869	732.514	1.005116

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	566.581	462.677
SumBase	567.256	462.127	0.998810
SumTraits	567.454	461.966	0.998462
SumTraits_Args0	560.967	467.308	1.010008
SumTraits_Args	561.617	466.767	1.008839
SumKernelTraits	566.020	463.136	1.000991
SumKernelTraits_Args0	559.853	468.237	1.012017
SumKernelTraits_Args	562.700	465.868	1.006897

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	206.432	1269.882
SumBase	224.043	1170.061	0.921394
SumTraits	212.984	1230.816	0.969237
SumTraits_Args0	281.312	931.862	0.733818
SumTraits_Args	282.101	929.256	0.731766
SumKernelTraits	264.385	991.523	0.780799
SumKernelTraits_Args0	225.968	1160.091	0.913542
SumKernelTraits_Args	205.705	1274.366	1.003531

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	262.526	998.544
SumBase	258.060	1015.827	1.017308
SumTraits	48.669	5386.285	5.394139
SumTraits_Args0	17.448	15024.499	15.046408
SumTraits_Args	17.390	15074.692	15.096675
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	43.827	5981.363	5.990085
SumKernelTraits	35.699	7343.188	7.353896
SumKernelTraits_Args0	17.268	15180.615	15.202752
SumKernelTraits_Args	17.307	15146.407	15.168495
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	36.118	7257.929	7.268512
SumKernel256_Avx2_ShiftLane	34.109	7685.436	7.696643
SumKernel256Traits	35.615	7360.572	7.371305
SumKernel256Traits_Args0	17.310	15144.047	15.166131
SumKernel256Traits_Args	17.271	15178.488	15.200622

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	369.837	708.810
SumBase	360.405	727.359	1.026169
SumTraits	49.672	5277.491	7.445562
SumTraits_Args0	26.687	9823.001	13.858434
SumTraits_Args	27.202	9637.014	13.596042
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	49.596	5285.603	7.457006
SumKernelTraits	24.176	10843.004	15.297470
SumKernelTraits_Args0	24.638	10639.798	15.010784
SumKernelTraits_Args	24.587	10662.053	15.042181
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	22.356	11726.100	16.543356
SumKernel256Traits_Args0	22.105	11858.779	16.730541
SumKernel256Traits_Args	22.199	11809.072	16.660413

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	591.362	443.289
SumBase	566.134	463.042	1.044562
SumTraits	141.508	1852.505	4.179002
SumTraits_Args0	54.444	4814.927	10.861831
SumTraits_Args	54.396	4819.158	10.871374
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	123.228	2127.309	4.798923
SumKernelTraits	88.437	2964.199	6.686837
SumKernelTraits_Args0	43.184	6070.414	13.694039
SumKernelTraits_Args	43.616	6010.227	13.558267
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	75.184	3486.686	7.865497
SumKernel256_Avx2_DuplicateEven	70.774	3703.945	8.355604
SumKernel256_Avx2_Multiply	140.275	1868.790	4.215740
SumKernel256_Avx2_ShiftLane	72.150	3633.297	8.196231
SumKernel256Traits	69.915	3749.462	8.458284
SumKernel256Traits_Args0	45.976	5701.767	12.862422
SumKernel256Traits_Args	46.502	5637.204	12.716776

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	209.307	1252.439
SumBase	205.840	1273.530	1.016840
SumTraits	19.509	13436.835	10.728537
SumTraits_Args0	7.949	32977.350	26.330510
SumTraits_Args	7.926	33073.034	26.406909
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	19.527	13424.472	10.718666
Sum256_Avx2_Add2	19.605	13371.121	10.676069
Sum256_Avx2_Cmp2	17.244	15202.412	12.138249
Sum256_Avx2_EqualAnd	17.513	14968.139	11.951195
Sum256Traits	17.221	15222.366	12.154181
SumKernelTraits	12.274	21358.336	17.053398
SumKernelTraits_Args0	7.872	33299.207	26.587495
SumKernelTraits_Args	7.860	33352.484	26.630034
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	11.478	22838.503	18.235226
SumKernel256Traits_Args0	7.904	33167.363	26.482225
SumKernel256Traits_Args	7.895	33202.948	26.510637

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	251.663	1041.646
SumBase	251.802	1041.072	0.999449
SumTraits	29.908	8765.158	8.414722
SumTraits_Args0	17.582	14910.111	14.313997
SumTraits_Args	18.012	14553.903	13.972030
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	29.883	8772.257	8.421538
SumKernelTraits	26.901	9744.617	9.355022
SumKernelTraits_Args0	17.824	14707.338	14.119331
SumKernelTraits_Args	29.127	8999.999	8.640174
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	35.679	7347.263	7.053515
SumKernel256_Avx2_ShiftLane	29.365	8927.062	8.570154
SumKernel256Traits	25.656	10217.643	9.809137
SumKernel256Traits_Args0	17.862	14676.348	14.089580
SumKernel256Traits_Args	17.764	14756.944	14.166954

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	348.064	753.148
SumBase	347.745	753.841	1.000920
SumTraits	42.442	6176.523	8.200943
SumTraits_Args0	26.423	9921.083	13.172822
SumTraits_Args	27.602	9497.253	12.610076
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	33.273	7878.696	10.461021
SumKernelTraits	36.072	7267.239	9.649152
SumKernelTraits_Args0	22.744	11525.694	15.303360
SumKernelTraits_Args	25.540	10264.114	13.628284
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	25.489	10284.773	13.655714
SumKernel256Traits_Args0	23.018	11388.775	15.121564
SumKernel256Traits_Args	22.961	11416.831	15.158816

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	543.010	482.761
SumBase	543.806	482.055	0.998538
SumTraits	92.808	2824.585	5.850900
SumTraits_Args0	53.209	4926.681	10.205223
SumTraits_Args	54.264	4830.929	10.006880
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	92.651	2829.362	5.860796
SumKernelTraits	74.936	3498.257	7.246359
SumKernelTraits_Args0	46.046	5693.042	11.792679
SumKernelTraits_Args	45.432	5769.979	11.952049
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	72.343	3623.613	7.506023
SumKernel256_Avx2_DuplicateEven	73.020	3590.006	7.436408
SumKernel256_Avx2_Multiply	110.261	2377.478	4.924754
SumKernel256_Avx2_ShiftLane	73.308	3575.942	7.407276
SumKernel256Traits	72.774	3602.147	7.461558
SumKernel256Traits_Args0	50.971	5143.018	10.653348
SumKernel256Traits_Args	45.621	5746.183	11.902755

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	203.855	1285.935
SumBase	203.710	1286.850	1.000711
SumTraits	12.455	21046.672	16.366823
SumTraits_Args0	7.936	33030.816	25.686224
SumTraits_Args	7.912	33132.757	25.765497
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	13.272	19751.865	15.359924
Sum256_Avx2_Add2	14.305	18325.710	14.250883
Sum256_Avx2_Cmp2	13.323	19676.439	15.301270
Sum256_Avx2_EqualAnd	12.876	20359.118	15.832150
Sum256Traits	12.054	21747.951	16.912168
SumKernelTraits	10.615	24694.833	19.203794
SumKernelTraits_Args0	8.031	32640.109	25.382393
SumKernelTraits_Args	8.118	32291.049	25.110948
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	9.220	28432.728	22.110547
SumKernel256Traits_Args0	7.923	33087.204	25.730074
SumKernel256Traits_Args	8.270	31697.628	24.649477

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	251.431	1042.608
SumBase	251.667	1041.631	0.999063
SumTraits	29.253	8961.145	8.594931
SumTraits_Args0	17.744	14773.976	14.170210
SumTraits_Args	17.408	15058.475	14.443082
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	28.453	9213.382	8.836860
SumKernelTraits	24.771	10582.688	10.150206
SumKernelTraits_Args0	18.533	14144.931	13.566872
SumKernelTraits_Args	18.047	14525.871	13.932243
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	24.480	10708.385	10.270767
SumKernel256_Avx2_ShiftLane	25.202	10401.670	9.976586
SumKernel256Traits	24.481	10707.976	10.270374
SumKernel256Traits_Args0	18.587	14103.424	13.527061
SumKernel256Traits_Args	18.035	14535.652	13.941625

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	354.535	739.401
SumBase	354.325	739.840	1.000593
SumTraits	35.436	7397.582	10.004826
SumTraits_Args0	26.882	9751.553	13.188444
SumTraits_Args	27.631	9487.379	12.831164
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	28.872	9079.384	12.279373
SumKernelTraits	35.900	7302.000	9.875557
SumKernelTraits_Args0	22.811	11492.221	15.542602
SumKernelTraits_Args	22.881	11456.597	15.494423
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	25.826	10150.383	13.727840
SumKernel256Traits_Args0	23.050	11372.807	15.381101
SumKernel256Traits_Args	22.743	11526.468	15.588921

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	567.070	462.278
SumBase	564.848	464.097	1.003935
SumTraits	103.660	2528.873	5.470463
SumTraits_Args0	52.791	4965.695	10.741802
SumTraits_Args	56.200	4664.443	10.090133
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	106.658	2457.798	5.316714
SumKernelTraits	72.856	3598.090	7.783396
SumKernelTraits_Args0	45.505	5760.762	12.461691
SumKernelTraits_Args	45.359	5779.311	12.501818
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	75.282	3482.150	7.532595
SumKernel256_Avx2_DuplicateEven	73.168	3582.747	7.750206
SumKernel256_Avx2_Multiply	107.453	2439.617	5.277384
SumKernel256_Avx2_ShiftLane	72.017	3640.024	7.874107
SumKernel256Traits	71.120	3685.930	7.973411
SumKernel256Traits_Args0	46.348	5656.013	12.235099
SumKernel256Traits_Args	45.911	5709.806	12.351465

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	205.356	1276.537
SumBase	205.424	1276.112	0.999667
SumTraits	11.643	22516.121	17.638434
SumTraits_Args0	7.928	33064.959	25.902068
SumTraits_Args	7.951	32970.692	25.828222
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	12.450	21056.531	16.495036
Sum256_Avx2_Add2	12.840	20415.691	15.993022
Sum256_Avx2_Cmp2	10.832	24199.780	18.957361
Sum256_Avx2_EqualAnd	12.967	20216.444	15.836938
Sum256Traits	11.438	22919.506	17.954434
SumKernelTraits	10.494	24980.435	19.568901
SumKernelTraits_Args0	7.984	32834.769	25.721745
SumKernelTraits_Args	8.005	32749.519	25.654962
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	9.212	28457.570	22.292782
SumKernel256Traits_Args0	8.066	32498.764	25.458528
SumKernel256Traits_Args	7.913	33129.448	25.952587

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	255.751	1024.998
SumBase	258.958	1012.302	0.987614
SumTraits	25.882	10128.301	9.881289
SumTraits_Args0	17.414	15053.609	14.686477
SumTraits_Args	17.767	14754.580	14.394741
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	349.366	750.342	0.732042
Sum256Traits	20.645	12697.956	12.388274
SumKernelTraits	21.480	12204.288	11.906646
SumKernelTraits_Args0	18.059	14516.094	14.162071
SumKernelTraits_Args	17.971	14587.111	14.231356
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	18.770	13965.905	13.625300
SumKernel256_Avx2_ShiftLane	23.875	10979.798	10.712019
SumKernel256Traits	18.717	14005.395	13.663827
SumKernel256Traits_Args0	18.134	14455.921	14.103365
SumKernel256Traits_Args	17.773	14749.937	14.390211

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	357.063	734.168
SumBase	358.194	731.849	0.996841
SumTraits	25.690	10204.153	13.898929
SumTraits_Args0	25.701	10199.869	13.893093
SumTraits_Args	27.456	9547.718	13.004808
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	434.235	603.691	0.822279
Sum256Traits	25.890	10125.224	13.791421
SumKernelTraits	21.782	12034.804	16.392432
SumKernelTraits_Args0	22.401	11702.120	15.939287
SumKernelTraits_Args	22.177	11820.508	16.100542
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	22.023	11903.163	16.213126
SumKernel256Traits_Args0	22.120	11851.050	16.142142
SumKernel256Traits_Args	23.426	11190.310	15.242158

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	565.844	463.280
SumBase	563.781	464.975	1.003658
SumTraits	71.153	3684.254	7.952544
SumTraits_Args0	53.030	4943.292	10.670207
SumTraits_Args	55.093	4758.252	10.270793
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	535.367	489.653	1.056928
Sum256Traits	62.351	4204.358	9.075200
SumKernelTraits	57.439	4563.892	9.851262
SumKernelTraits_Args0	45.125	5809.334	12.539576
SumKernelTraits_Args	46.809	5600.277	12.088323
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	64.360	4073.063	8.791798
SumKernel256_Avx2_DuplicateEven	52.996	4946.453	10.677029
SumKernel256_Avx2_Multiply	109.717	2389.271	5.157295
SumKernel256_Avx2_ShiftLane	55.670	4708.888	10.164239
SumKernel256Traits	57.543	4555.621	9.833410
SumKernel256Traits_Args0	47.205	5553.266	11.986850
SumKernel256Traits_Args	45.281	5789.265	12.496258

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	205.216	1277.403
SumBase	209.968	1248.495	0.977370
SumTraits	10.184	25740.061	20.150308
SumTraits_Args0	7.574	34611.644	27.095324
SumTraits_Args	7.589	34544.193	27.042521
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	281.014	932.852	0.730272
Sum256_Avx2_Add1	9.910	26452.281	20.707861
Sum256_Avx2_Add2	10.042	26104.468	20.435580
Sum256_Avx2_Cmp2	9.899	26482.193	20.731278
Sum256_Avx2_EqualAnd	10.051	26081.512	20.417609
Sum256Traits	8.211	31924.788	24.991950
SumKernelTraits	8.601	30476.824	23.858428
SumKernelTraits_Args0	7.914	33124.708	25.931293
SumKernelTraits_Args	7.640	34311.869	26.860648
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	7.756	33797.896	26.458291
SumKernel256Traits_Args0	7.583	34571.312	27.063751
SumKernel256Traits_Args	7.707	34014.673	26.627992

``` 


### Intel Core i5-8250U - 128 bit
`Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz`
SET COMPlus_EnableAVX2=0

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
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vector128s.Instance:	WVectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.Instance:	VectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.BaseInstance:	VectorTraits128Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	354.130	740.249
SumBase	360.542	727.083	0.982215
SumTraits	75.709	3462.537	4.677533
SumTraits_Args0	21.301	12306.584	16.624935
SumTraits_Args	21.345	12281.000	16.590374
Sum128Traits	69.228	3786.654	5.115383
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	52.994	4946.668	6.682443
SumKernelTraits_Args0	21.220	12353.493	16.688305
SumKernelTraits_Args	21.360	12272.866	16.579387
SumKernel128Traits	41.250	6355.005	8.584962
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	596.163	439.719
SumBase	548.806	477.662	1.086291
SumTraits	134.431	1950.031	4.434725
SumTraits_Args0	42.198	6212.169	14.127601
SumTraits_Args	40.373	6493.041	14.766356
Sum128Traits	123.777	2117.871	4.816423
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	91.296	2871.354	6.529981
SumKernelTraits_Args0	42.706	6138.326	13.959669
SumKernelTraits_Args	42.221	6208.813	14.119970
SumKernel128Traits	84.045	3119.094	7.093385
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	949.546	276.073
SumBase	947.525	276.662	1.002133
SumTraits	315.833	830.008	3.006478
SumTraits_Args0	80.528	3255.313	11.791491
SumTraits_Args	84.247	3111.626	11.271023
Sum128Traits	248.691	1054.096	3.818176
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	180.891	1449.179	5.249257
SumKernelTraits_Args0	95.993	2730.876	9.891858
SumKernelTraits_Args	90.021	2912.020	10.548006
SumKernel128_Sse_DuplicateEven	212.979	1230.846	4.458407
SumKernel128Traits	206.803	1267.601	4.591541
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
SumScalar	272.126	963.320
SumBase	255.178	1027.300	1.066416
SumTraits	24.689	10617.759	11.022046
SumTraits_Args0	9.885	26518.244	27.527965
SumTraits_Args	10.013	26180.253	27.177104
Sum128Traits	24.749	10591.944	10.995248
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	10.162	25796.330	26.778564
SumKernelTraits_Args0	10.043	26101.227	27.095070
SumKernelTraits_Args	10.542	24867.437	25.814301
SumKernel128Traits	10.717	24461.205	25.392602
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

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
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.Instance:	VectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.BaseInstance:	VectorTraits128Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	341.105	768.515
SumBase	342.790	764.736	0.995083
SumTraits	41.903	6255.944	8.140303
SumTraits_Args0	19.640	13347.670	17.368134
SumTraits_Args	20.049	13074.901	17.013205
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	35.378	7409.713	9.641601
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	32.451	8078.267	10.511530
SumKernelTraits_Args0	20.985	12492.054	16.254798
SumKernelTraits_Args	20.047	13076.678	17.015517
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	25.501	10279.712	13.376075
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	526.068	498.308
SumBase	526.121	498.258	0.999900
SumTraits	86.284	3038.154	6.096941
SumTraits_Args0	38.756	6763.988	13.573912
SumTraits_Args	42.042	6235.346	12.513039
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	74.780	3505.560	7.034927
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	66.389	3948.604	7.924025
SumKernelTraits_Args0	48.280	5429.647	10.896168
SumKernelTraits_Args	40.068	6542.452	13.129335
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	60.985	4298.532	8.626256
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	899.126	291.554
SumBase	898.188	291.859	1.001044
SumTraits	188.791	1388.538	4.762537
SumTraits_Args0	78.404	3343.512	11.467888
SumTraits_Args	82.046	3195.081	10.958787
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	181.537	1444.028	4.952862
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	135.012	1941.636	6.659603
SumKernelTraits_Args0	81.805	3204.512	10.991133
SumKernelTraits_Args	78.550	3337.283	11.446524
SumKernel128_Sse_DuplicateEven	152.328	1720.917	5.902562
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	114.464	2290.195	7.855125
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
SumScalar	247.819	1057.803
SumBase	249.187	1051.996	0.994510
SumTraits	16.302	16080.835	15.202106
SumTraits_Args0	10.139	25854.669	24.441854
SumTraits_Args	10.029	26139.450	24.711072
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	13.988	18740.745	17.716666
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	12.103	21659.094	20.475544
SumKernelTraits_Args0	9.597	27315.981	25.823313
SumKernelTraits_Args	9.399	27889.534	26.365524
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	10.402	25201.216	23.824108
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
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
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.Instance:	VectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.BaseInstance:	VectorTraits128Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	339.232	772.758
SumBase	339.199	772.833	1.000097
SumTraits	37.061	7073.393	9.153439
SumTraits_Args0	19.326	13564.558	17.553435
SumTraits_Args	20.397	12852.249	16.631661
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	36.862	7111.410	9.202635
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	29.535	8875.736	11.485789
SumKernelTraits_Args0	18.763	13971.670	18.080265
SumKernelTraits_Args	18.678	14035.159	18.162424
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	27.586	9502.717	12.297145
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	545.804	480.289
SumBase	550.924	475.826	0.990707
SumTraits	84.634	3097.391	6.449012
SumTraits_Args0	39.607	6618.650	13.780550
SumTraits_Args	38.682	6776.833	14.109900
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	79.035	3316.811	6.905862
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	60.746	4315.436	8.985078
SumKernelTraits_Args0	37.430	7003.559	14.581961
SumKernelTraits_Args	38.737	6767.243	14.089933
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	58.473	4483.136	9.334243
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	936.094	280.040
SumBase	935.590	280.191	1.000538
SumTraits	200.503	1307.429	4.668715
SumTraits_Args0	79.919	3280.135	11.713081
SumTraits_Args	79.550	3295.345	11.767392
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	179.428	1461.001	5.217109
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	121.791	2152.402	7.686043
SumKernelTraits_Args0	79.737	3287.616	11.739792
SumKernelTraits_Args	81.785	3205.269	11.445740
SumKernel128_Sse_DuplicateEven	152.666	1717.103	6.131627
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	119.116	2200.748	7.858681
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
SumScalar	254.800	1028.821
SumBase	254.775	1028.922	1.000098
SumTraits	13.244	19793.764	19.239261
SumTraits_Args0	10.313	25418.389	24.706318
SumTraits_Args	9.547	27457.767	26.688565
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	12.232	21431.121	20.830749
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	11.987	21868.788	21.256155
SumKernelTraits_Args0	9.833	26659.470	25.912631
SumKernelTraits_Args	9.570	27392.049	26.624687
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	9.746	26896.689	26.143205
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
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
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.Instance:	VectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.BaseInstance:	VectorTraits128Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	345.338	759.095
SumBase	347.968	753.356	0.992440
SumTraits	32.362	8100.287	10.670979
SumTraits_Args0	18.009	14556.397	19.175988
SumTraits_Args	18.833	13919.373	18.336799
Sum128_Bcl	421.209	622.361	0.819873
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	26.654	9835.238	12.956531
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	25.414	10315.084	13.588660
SumKernelTraits_Args0	18.747	13982.928	18.420524
SumKernelTraits_Args	18.963	13824.059	18.211236
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	20.046	13077.237	17.227404
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	551.442	475.379
SumBase	554.771	472.526	0.993999
SumTraits	72.087	3636.507	7.649700
SumTraits_Args0	37.420	7005.379	14.736404
SumTraits_Args	37.551	6981.091	14.685313
Sum128_Bcl	489.351	535.698	1.126885
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	53.002	4945.924	10.404169
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	52.057	5035.680	10.592977
SumKernelTraits_Args0	38.451	6817.644	14.341489
SumKernelTraits_Args	37.360	7016.655	14.760124
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	41.215	6360.422	13.379683
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	945.030	277.392
SumBase	944.207	277.634	1.000872
SumTraits	143.821	1822.714	6.570889
SumTraits_Args0	78.615	3334.538	12.021021
SumTraits_Args	78.138	3354.894	12.094403
Sum128_Bcl	869.310	301.554	1.087104
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	141.217	1856.322	6.692047
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	111.055	2360.493	8.509584
SumKernelTraits_Args0	73.657	3558.987	12.830159
SumKernelTraits_Args	73.557	3563.819	12.847578
SumKernel128_Sse_DuplicateEven	121.139	2163.989	7.801187
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	92.240	2841.992	10.245390
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
SumScalar	254.523	1029.944
SumBase	256.476	1022.099	0.992383
SumTraits	13.408	19550.985	18.982572
SumTraits_Args0	9.081	28865.877	28.026649
SumTraits_Args	10.749	24388.763	23.679700
Sum128_Bcl	326.565	802.731	0.779393
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	12.172	21536.321	20.910188
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	10.692	24517.746	23.804933
SumKernelTraits_Args0	9.460	27710.286	26.904654
SumKernelTraits_Args	9.389	27920.304	27.108566
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	9.270	28278.463	27.456312
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

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

