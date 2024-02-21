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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	616.811	424.999
SumBase	615.839	425.670	1.001579
SumTraits	616.356	425.313	1.000739
SumTraits_Args0	617.147	424.768	0.999456
SumTraits_Args	654.385	400.596	0.942581
Sum128Traits	1099.483	238.425	0.561001
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	616.730	425.055	1.000132
SumKernelTraits_Args0	617.168	424.753	0.999421
SumKernelTraits_Args	653.966	400.853	0.943186
SumKernel128Traits	1097.558	238.843	0.561985
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	910.307	287.973
SumBase	910.714	287.844	0.999553
SumTraits	909.823	288.127	1.000533
SumTraits_Args0	912.611	287.246	0.997476
SumTraits_Args	976.044	268.578	0.932649
Sum128Traits	1710.963	153.214	0.532044
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	911.301	287.659	0.998909
SumKernelTraits_Args0	914.994	286.498	0.994878
SumKernelTraits_Args	976.323	268.501	0.932383
SumKernel128Traits	1711.604	153.157	0.531844
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	689.909	379.969
SumBase	691.070	379.331	0.998320
SumTraits	1421.285	184.441	0.485412
SumTraits_Args0	691.955	378.846	0.997043
SumTraits_Args	780.673	335.792	0.883736
Sum128Traits	1263.049	207.549	0.546225
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	1437.279	182.389	0.480010
SumKernelTraits_Args0	1452.005	180.539	0.475142
SumKernelTraits_Args	781.530	335.424	0.882767
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128Traits	1784.680	146.886	0.386573
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
SumScalar	392.752	667.455
SumBase	404.302	648.386	0.971431
SumTraits	392.626	667.668	1.000319
SumTraits_Args0	394.151	665.086	0.996450
SumTraits_Args	418.639	626.181	0.938162
Sum128Traits	655.393	399.980	0.599261
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	404.260	648.453	0.971531
SumKernelTraits_Args0	394.141	665.102	0.996474
SumKernelTraits_Args	419.458	624.959	0.936332
SumKernel128Traits	655.176	400.112	0.599459
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	619.406	423.218
SumBase	620.404	422.538	0.998391
SumTraits	55.779	4699.731	11.104740
SumTraits_Args0	31.097	8429.938	19.918646
SumTraits_Args	88.000	2978.896	7.038671
Sum128_AdvSimd	83.197	3150.881	7.445048
Sum128Traits	52.628	4981.104	11.769581
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	49.647	5280.154	12.476190
SumKernelTraits_Args0	31.086	8432.769	19.925335
SumKernelTraits_Args	88.083	2976.102	7.032070
SumKernel128_AdvSimd	88.447	2963.866	7.003159
SumKernel128Traits	39.994	6554.537	15.487362
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	933.150	280.924
SumBase	932.177	281.217	1.001044
SumTraits	106.972	2450.585	8.723313
SumTraits_Args0	63.143	4151.578	14.778312
SumTraits_Args	176.614	1484.278	5.283563
Sum128_AdvSimd	193.279	1356.297	4.827990
Sum128Traits	99.971	2622.213	9.334254
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	98.790	2653.535	9.445749
SumKernelTraits_Args0	67.029	3910.887	13.921528
SumKernelTraits_Args	176.745	1483.173	5.279628
SumKernel128_AdvSimd	181.766	1442.208	5.133807
SumKernel128Traits	80.434	3259.100	11.601370
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	595.134	440.479
SumBase	637.491	411.212	0.933556
SumTraits	258.837	1012.778	2.299264
SumTraits_Args0	133.487	1963.813	4.458355
SumTraits_Args	365.598	717.028	1.627836
Sum128_AdvSimd	442.494	592.424	1.344953
Sum128Traits	213.462	1228.061	2.788012
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	215.325	1217.434	2.763886
SumKernelTraits_Args0	124.826	2100.070	4.767695
SumKernelTraits_Args	353.480	741.609	1.683642
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	281.394	931.591	2.114950
SumKernel128_Arm_Multiply	559.239	468.751	1.064185
SumKernel128Traits	179.917	1457.029	3.307827
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
SumScalar	396.685	660.836
SumBase	405.632	646.261	0.977945
SumTraits	16.824	15581.384	23.578286
SumTraits_Args0	15.674	16724.814	25.308565
SumTraits_Args	44.125	5940.901	8.989976
Sum128_AdvSimd	22.330	11739.301	17.764314
Sum128Traits	16.642	15752.275	23.836885
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	19.966	13129.238	19.867616
SumKernelTraits_Args0	16.661	15734.005	23.809238
SumKernelTraits_Args	45.762	5728.363	8.668356
SumKernel128_AdvSimd	23.304	11248.646	17.021838
SumKernel128Traits	15.643	16757.494	25.358017
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	625.491	419.101
SumBase	621.037	422.107	1.007173
SumTraits	47.404	5530.044	13.195015
SumTraits_Args0	31.746	8257.430	19.702719
SumTraits_Args	91.421	2867.447	6.841899
Sum128_AdvSimd	84.503	3102.195	7.402021
Sum128Traits	47.420	5528.097	13.190369
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	40.393	6489.835	15.485133
SumKernelTraits_Args0	33.721	7773.929	18.549057
SumKernelTraits_Args	88.040	2977.539	7.104585
SumKernel128_AdvSimd	78.230	3350.936	7.995533
SumKernel128Traits	40.502	6472.303	15.443300
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	931.651	281.376
SumBase	932.271	281.189	0.999335
SumTraits	107.104	2447.558	8.698541
SumTraits_Args0	67.759	3868.791	13.749556
SumTraits_Args	176.148	1488.202	5.289020
Sum128_AdvSimd	168.623	1554.618	5.525063
Sum128Traits	94.959	2760.609	9.811112
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	81.112	3231.874	11.485973
SumKernelTraits_Args0	67.666	3874.060	13.768284
SumKernelTraits_Args	177.073	1480.430	5.261398
SumKernel128_AdvSimd	156.738	1672.496	5.943996
SumKernel128Traits	81.125	3231.342	11.484082
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	591.619	443.096
SumBase	591.790	442.968	0.999711
SumTraits	244.940	1070.236	2.415359
SumTraits_Args0	126.658	2069.707	4.671013
SumTraits_Args	352.933	742.759	1.676294
Sum128_AdvSimd	488.464	536.670	1.211182
Sum128Traits	243.124	1078.230	2.433400
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	186.126	1408.426	3.178603
SumKernelTraits_Args0	134.232	1952.918	4.407438
SumKernelTraits_Args	352.611	743.436	1.677822
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	293.744	892.424	2.014065
SumKernel128_Arm_Multiply	535.941	489.128	1.103888
SumKernel128Traits	177.965	1473.008	3.324355
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
SumScalar	398.195	658.330
SumBase	396.845	660.571	1.003403
SumTraits	15.678	16720.691	25.398634
SumTraits_Args0	16.666	15729.294	23.892707
SumTraits_Args	44.026	5954.235	9.044449
Sum128_AdvSimd	22.357	11725.385	17.810794
Sum128Traits	15.640	16761.213	25.460187
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	15.705	16691.707	25.354607
SumKernelTraits_Args0	16.703	15694.804	23.840318
SumKernelTraits_Args	44.130	5940.288	9.023264
SumKernel128_AdvSimd	22.317	11746.544	17.842934
SumKernel128Traits	15.649	16751.903	25.446045
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	497.144	527.300
SumBase	497.321	527.113	0.999644
SumTraits	44.659	5869.854	11.131896
SumTraits_Args0	26.366	9942.485	18.855445
SumTraits_Args	26.423	9921.169	18.815021
Sum128_Bcl	544.017	481.867	0.913838
Sum128_AdvSimd	84.246	3111.658	5.901110
Sum128Traits	44.596	5878.244	11.147807
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	32.910	7965.363	15.105928
SumKernelTraits_Args0	26.354	9946.938	18.863889
SumKernelTraits_Args	26.431	9918.004	18.809019
SumKernel128_AdvSimd	66.007	3971.472	7.531706
SumKernel128Traits	32.903	7967.252	15.109510
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	828.119	316.554
SumBase	824.842	317.811	1.003972
SumTraits	89.720	2921.792	9.230006
SumTraits_Args0	53.894	4864.057	15.365664
SumTraits_Args	54.316	4826.316	15.246439
Sum128_Bcl	865.478	302.889	0.956834
Sum128_AdvSimd	164.700	1591.645	5.028043
Sum128Traits	89.766	2920.299	9.225291
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	66.926	3916.923	12.373647
SumKernelTraits_Args0	54.153	4840.789	15.292160
SumKernelTraits_Args	54.389	4819.802	15.225861
SumKernel128_AdvSimd	132.338	1980.863	6.257592
SumKernel128Traits	66.776	3925.725	12.401453
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	474.688	552.245
SumBase	474.921	551.973	0.999509
SumTraits	208.920	1254.759	2.272107
SumTraits_Args0	106.400	2463.769	4.461372
SumTraits_Args	106.898	2452.291	4.440588
Sum128_Bcl	368.006	712.337	1.289893
Sum128_AdvSimd	433.577	604.608	1.094819
Sum128Traits	206.984	1266.492	2.293353
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	148.299	1767.667	3.200876
SumKernelTraits_Args0	106.351	2464.893	4.463407
SumKernelTraits_Args	106.966	2450.730	4.437762
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	286.575	914.749	1.656420
SumKernel128_Arm_Multiply	460.697	569.016	1.030370
SumKernel128Traits	148.519	1765.059	3.196154
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
SumScalar	314.410	833.764
SumBase	313.910	835.092	1.001592
SumTraits	13.274	19748.119	23.685489
SumTraits_Args0	13.278	19742.430	23.678666
SumTraits_Args	13.318	19683.036	23.607430
Sum128_Bcl	403.810	649.177	0.778610
Sum128_AdvSimd	19.945	13143.611	15.764178
Sum128Traits	13.254	19779.062	23.722602
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	13.285	19731.858	23.665986
SumKernelTraits_Args0	13.305	19702.186	23.630398
SumKernelTraits_Args	13.327	19669.480	23.591171
SumKernel128_AdvSimd	19.959	13134.187	15.752875
SumKernel128Traits	13.263	19765.379	23.706190
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

```

