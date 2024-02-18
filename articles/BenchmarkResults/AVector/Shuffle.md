# Benchmark - Shuffle
([← Back](README.md))

See [Group](Shuffle_Group.md)

## x86

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9181.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
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
SumScalar	260.539	1006.161
SumBase	260.861	1004.919	0.998766
SumTraits	259.001	1012.135	1.005938
SumTraits_Args0	258.821	1012.838	1.006636
SumTraits_Args	256.689	1021.252	1.014999
SumKernelTraits	259.066	1011.881	1.005685
SumKernelTraits_Args0	259.565	1009.936	1.003753
SumKernelTraits_Args	257.096	1019.635	1.013391

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	361.556	725.043
SumBase	361.587	724.982	0.999916
SumTraits	361.454	725.248	1.000282
SumTraits_Args0	362.886	722.387	0.996337
SumTraits_Args	360.164	727.846	1.003866
SumKernelTraits	365.211	717.788	0.989994
SumKernelTraits_Args0	365.158	717.892	0.990137
SumKernelTraits_Args	363.553	721.062	0.994509

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	577.073	454.265
SumBase	576.288	454.884	1.001363
SumTraits	571.536	458.666	1.009688
SumTraits_Args0	563.264	465.401	1.024516
SumTraits_Args	565.853	463.273	1.019830
SumKernelTraits	569.560	460.257	1.013192
SumKernelTraits_Args0	565.967	463.179	1.019623
SumKernelTraits_Args	569.706	460.139	1.012932

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	206.915	1266.919
SumBase	207.798	1261.533	0.995749
SumTraits	207.131	1265.597	0.998957
SumTraits_Args0	207.711	1262.062	0.996166
SumTraits_Args	208.917	1254.775	0.990414
SumKernelTraits	214.672	1221.136	0.963863
SumKernelTraits_Args0	207.973	1260.474	0.994913
SumKernelTraits_Args	217.310	1206.316	0.952165

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Vector128 type is not supported! Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Vector128 type is not supported! Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

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
SumScalar	264.507	991.067
SumBase	263.593	994.502	1.003466
SumTraits	264.340	991.694	1.000632
SumTraits_Args0	259.516	1010.126	1.019231
SumTraits_Args	257.057	1019.791	1.028983
SumKernelTraits	264.331	991.725	1.000664
SumKernelTraits_Args0	259.295	1010.987	1.020099
SumKernelTraits_Args	257.816	1016.789	1.025953

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	371.638	705.375
SumBase	372.061	704.573	0.998864
SumTraits	371.897	704.884	0.999304
SumTraits_Args0	362.440	723.276	1.025378
SumTraits_Args	384.323	682.093	0.966994
SumKernelTraits	372.193	704.322	0.998508
SumKernelTraits_Args0	361.645	724.866	1.027633
SumKernelTraits_Args	385.113	680.694	0.965011

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	596.473	439.490
SumBase	596.920	439.161	0.999250
SumTraits	597.514	438.724	0.998257
SumTraits_Args0	564.130	464.687	1.057332
SumTraits_Args	565.209	463.800	1.055313
SumKernelTraits	597.978	438.384	0.997482
SumKernelTraits_Args0	565.587	463.490	1.054609
SumKernelTraits_Args	569.431	460.361	1.047488

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	210.971	1242.561
SumBase	210.745	1243.890	1.001070
SumTraits	214.567	1221.738	0.983242
SumTraits_Args0	206.917	1266.901	1.019589
SumTraits_Args	207.642	1262.483	1.016034
SumKernelTraits	211.312	1240.552	0.998383
SumKernelTraits_Args0	207.609	1262.681	1.016193
SumKernelTraits_Args	207.964	1260.528	1.014460

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Vector128 type is not supported! Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Vector128 type is not supported! Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

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
SumScalar	258.989	1012.184
SumBase	263.873	993.447	0.981488
SumTraits	44.358	5909.784	5.838647
SumTraits_Args0	17.511	14970.657	14.790454
SumTraits_Args	17.893	14650.891	14.474536
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	47.392	5531.443	5.464861
SumKernelTraits	39.776	6590.516	6.511185
SumKernelTraits_Args0	17.657	14846.064	14.667360
SumKernelTraits_Args	17.582	14910.076	14.730602
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	34.829	7526.536	7.435939
SumKernel256_Avx2_ShiftLane	32.033	8183.523	8.085017
SumKernel256Traits	36.684	7146.040	7.060022
SumKernel256Traits_Args0	17.591	14902.325	14.722944
SumKernel256Traits_Args	17.859	14678.213	14.501529

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	361.761	724.634
SumBase	372.369	703.991	0.971513
SumTraits	51.554	5084.806	7.017071
SumTraits_Args0	28.500	9198.009	12.693324
SumTraits_Args	26.764	9794.512	13.516502
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	50.319	5209.671	7.189386
SumKernelTraits	22.240	11787.085	16.266268
SumKernelTraits_Args0	23.660	11079.628	15.289972
SumKernelTraits_Args	21.914	11962.349	16.508134
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	23.796	11016.122	15.202334
SumKernel256Traits_Args0	24.077	10887.847	15.025312
SumKernel256Traits_Args	24.923	10518.065	14.515011

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	570.066	459.848
SumBase	596.720	439.308	0.955333
SumTraits	134.425	1950.108	4.240765
SumTraits_Args0	59.045	4439.768	9.654856
SumTraits_Args	59.183	4429.402	9.632313
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	133.850	1958.496	4.259006
SumKernelTraits	94.568	2772.029	6.028139
SumKernelTraits_Args0	50.681	5172.457	11.248184
SumKernelTraits_Args	51.736	5066.915	11.018668
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	75.713	3462.356	7.529345
SumKernel256_Avx2_DuplicateEven	67.705	3871.875	8.419898
SumKernel256_Avx2_Multiply	149.368	1755.018	3.816516
SumKernel256_Avx2_ShiftLane	81.438	3218.933	6.999990
SumKernel256Traits	66.857	3920.949	8.526616
SumKernel256Traits_Args0	46.675	5616.366	12.213521
SumKernel256Traits_Args	48.849	5366.364	11.669860

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	207.544	1263.079
SumBase	210.661	1244.388	0.985202
SumTraits	20.209	12971.856	10.270024
SumTraits_Args0	8.176	32063.329	25.385045
SumTraits_Args	8.136	32218.525	25.507916
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	20.982	12493.988	9.891688
Sum256_Avx2_Add2	20.121	13028.494	10.314865
Sum256_Avx2_Cmp2	17.534	14950.892	11.836858
Sum256_Avx2_EqualAnd	17.446	15026.405	11.896643
Sum256Traits	17.844	14690.538	11.630731
SumKernelTraits	13.399	19564.164	15.489259
SumKernelTraits_Args0	8.054	32547.991	25.768760
SumKernelTraits_Args	8.091	32400.241	25.651784
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	13.962	18775.932	14.865203
SumKernel256Traits_Args0	8.002	32759.494	25.936210
SumKernel256Traits_Args	8.025	32665.368	25.861689

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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
SumScalar	258.486	1014.152
SumBase	253.957	1032.239	1.017835
SumTraits	31.934	8208.898	8.094344
SumTraits_Args0	17.705	14806.353	14.599732
SumTraits_Args	18.774	13963.010	13.768157
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	30.436	8613.060	8.492866
SumKernelTraits	27.077	9681.463	9.546360
SumKernelTraits_Args0	18.548	14133.277	13.936049
SumKernelTraits_Args	18.472	14191.424	13.993384
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	23.903	10966.893	10.813851
SumKernel256_Avx2_ShiftLane	25.457	10297.433	10.153733
SumKernel256Traits	25.724	10190.495	10.048288
SumKernel256Traits_Args0	18.673	14038.623	13.842715
SumKernel256Traits_Args	18.777	13960.799	13.765978

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	371.995	704.698
SumBase	350.008	748.965	1.062817
SumTraits	45.223	5796.653	8.225726
SumTraits_Args0	27.715	9458.512	13.422077
SumTraits_Args	29.632	8846.709	12.553900
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	35.473	7389.938	10.486672
SumKernelTraits	37.223	7042.597	9.993779
SumKernelTraits_Args0	25.225	10392.273	14.747127
SumKernelTraits_Args	26.674	9827.635	13.945879
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	23.466	11171.389	15.852731
SumKernel256Traits_Args0	26.554	9872.190	14.009105
SumKernel256Traits_Args	25.661	10215.792	14.496693

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	548.039	478.331
SumBase	547.635	478.684	1.000738
SumTraits	99.533	2633.737	5.506100
SumTraits_Args0	57.667	4545.861	9.503590
SumTraits_Args	60.492	4333.526	9.059683
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	100.097	2618.891	5.475063
SumKernelTraits	79.633	3291.889	6.882033
SumKernelTraits_Args0	51.306	5109.451	10.681835
SumKernelTraits_Args	55.493	4723.944	9.875893
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	78.824	3325.674	6.952664
SumKernel256_Avx2_DuplicateEven	76.989	3404.973	7.118447
SumKernel256_Avx2_Multiply	118.841	2205.840	4.611535
SumKernel256_Avx2_ShiftLane	77.609	3377.771	7.061579
SumKernel256Traits	77.342	3389.419	7.085930
SumKernel256Traits_Args0	47.872	5475.897	11.447926
SumKernel256Traits_Args	48.363	5420.309	11.331714

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	258.653	1013.498
SumBase	204.759	1280.258	1.263206
SumTraits	12.564	20865.138	20.587246
SumTraits_Args0	8.405	31187.251	30.771883
SumTraits_Args	8.539	30699.425	30.290555
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	13.703	19130.998	18.876201
Sum256_Avx2_Add2	13.807	18986.698	18.733824
Sum256_Avx2_Cmp2	13.965	18771.154	18.521150
Sum256_Avx2_EqualAnd	16.922	15491.101	15.284783
Sum256Traits	12.340	21242.696	20.959776
SumKernelTraits	10.719	24456.437	24.130714
SumKernelTraits_Args0	8.129	32247.207	31.817722
SumKernelTraits_Args	8.271	31696.002	31.273859
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	9.729	26944.824	26.585960
SumKernel256Traits_Args0	8.178	32055.663	31.628730
SumKernel256Traits_Args	8.236	31828.286	31.404381

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
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
SumScalar	260.196	1007.489
SumBase	256.699	1021.210	1.013620
SumTraits	31.734	8260.645	8.199245
SumTraits_Args0	20.626	12709.454	12.614986
SumTraits_Args	22.283	11764.498	11.677054
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	31.409	8346.029	8.283994
SumKernelTraits	27.178	9645.427	9.573733
SumKernelTraits_Args0	18.674	14037.800	13.933458
SumKernelTraits_Args	18.785	13955.069	13.851342
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	30.625	8559.762	8.496138
SumKernel256_Avx2_ShiftLane	27.394	9569.339	9.498211
SumKernel256Traits	26.181	10012.695	9.938272
SumKernel256Traits_Args0	17.445	15027.159	14.915463
SumKernel256Traits_Args	18.734	13992.654	13.888648

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	365.728	716.773
SumBase	357.238	733.809	1.023767
SumTraits	39.558	6626.829	9.245363
SumTraits_Args0	29.594	8858.010	12.358177
SumTraits_Args	28.774	9110.320	12.710185
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	30.313	8647.773	12.064867
SumKernelTraits	37.465	6996.997	9.761800
SumKernelTraits_Args0	24.522	10690.334	14.914528
SumKernelTraits_Args	23.379	11212.747	15.643368
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	25.153	10422.075	14.540269
SumKernel256Traits_Args0	24.425	10732.581	14.973468
SumKernel256Traits_Args	25.798	10161.214	14.176331

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	581.114	451.106
SumBase	575.608	455.421	1.009565
SumTraits	109.135	2402.019	5.324734
SumTraits_Args0	59.700	4391.024	9.733910
SumTraits_Args	60.234	4352.073	9.647562
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	96.391	2719.593	6.028724
SumKernelTraits	77.690	3374.221	7.479886
SumKernelTraits_Args0	53.361	4912.615	10.890158
SumKernelTraits_Args	54.003	4854.242	10.760759
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	91.068	2878.562	6.381122
SumKernel256_Avx2_DuplicateEven	79.054	3316.022	7.350871
SumKernel256_Avx2_Multiply	113.604	2307.516	5.115241
SumKernel256_Avx2_ShiftLane	78.118	3355.722	7.438879
SumKernel256Traits	79.124	3313.071	7.344331
SumKernel256Traits_Args0	53.813	4871.359	10.798703
SumKernel256Traits_Args	51.336	5106.469	11.319888

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	213.260	1229.225
SumBase	216.280	1212.060	0.986036
SumTraits	13.153	19929.717	16.213237
SumTraits_Args0	8.076	32460.652	26.407412
SumTraits_Args	8.040	32603.163	26.523348
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	13.692	19145.866	15.575559
Sum256_Avx2_Add2	13.250	19784.878	16.095408
Sum256_Avx2_Cmp2	10.730	24430.113	19.874402
Sum256_Avx2_EqualAnd	12.573	20849.258	16.961303
Sum256Traits	11.777	22258.705	18.107917
SumKernelTraits	10.801	24270.131	19.744254
SumKernelTraits_Args0	8.568	30594.901	24.889585
SumKernelTraits_Args	8.068	32491.589	26.432580
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	9.781	26800.954	21.803131
SumKernel256Traits_Args0	8.154	32151.067	26.155559
SumKernel256Traits_Args	8.138	32212.198	26.205290

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
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
SumScalar	261.340	1003.075
SumBase	260.812	1005.107	1.002027
SumTraits	26.738	9804.195	9.774143
SumTraits_Args0	17.759	14761.122	14.715875
SumTraits_Args	17.563	14925.738	14.879987
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	336.209	779.704	0.777314
Sum256Traits	22.302	11754.418	11.718388
SumKernelTraits	24.275	10798.954	10.765853
SumKernelTraits_Args0	18.877	13887.220	13.844653
SumKernelTraits_Args	18.463	14198.492	14.154970
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	18.177	14422.079	14.377872
SumKernel256_Avx2_ShiftLane	23.866	10983.845	10.950177
SumKernel256Traits	18.950	13833.350	13.790947
SumKernel256Traits_Args0	18.344	14290.465	14.246661
SumKernel256Traits_Args	18.267	14350.829	14.306840

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	352.618	743.423
SumBase	348.832	751.490	1.010851
SumTraits	26.453	9909.691	13.329817
SumTraits_Args0	27.561	9511.275	12.793896
SumTraits_Args	28.090	9332.213	12.553035
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	426.097	615.221	0.827552
Sum256Traits	27.785	9434.578	12.690729
SumKernelTraits	24.691	10616.814	14.280989
SumKernelTraits_Args0	25.518	10272.796	13.818240
SumKernelTraits_Args	25.982	10089.265	13.571367
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	23.661	11079.125	14.902857
SumKernel256Traits_Args0	23.547	11132.643	14.974846
SumKernel256Traits_Args	23.146	11325.758	15.234611

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	586.956	446.616
SumBase	566.302	462.905	1.036472
SumTraits	81.767	3205.985	7.178387
SumTraits_Args0	54.757	4787.368	10.719197
SumTraits_Args	61.363	4272.037	9.565340
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	515.404	508.619	1.138827
Sum256Traits	73.474	3567.844	7.988611
SumKernelTraits	65.671	3991.753	8.937769
SumKernelTraits_Args0	53.639	4887.197	10.942719
SumKernelTraits_Args	53.836	4869.304	10.902655
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	69.535	3769.965	8.441171
SumKernel256_Avx2_DuplicateEven	55.374	4734.096	10.599917
SumKernel256_Avx2_Multiply	110.007	2382.979	5.335628
SumKernel256_Avx2_ShiftLane	58.566	4476.046	10.022128
SumKernel256Traits	57.035	4596.196	10.291152
SumKernel256Traits_Args0	49.555	5289.930	11.844462
SumKernel256Traits_Args	47.500	5518.767	12.356842

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	216.864	1208.795
SumBase	214.814	1220.330	1.009543
SumTraits	10.081	26004.767	21.512975
SumTraits_Args0	7.624	34384.734	28.445474
SumTraits_Args	8.162	32117.686	26.570012
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	281.288	931.941	0.770967
Sum256_Avx2_Add1	10.380	25254.533	20.892329
Sum256_Avx2_Add2	11.453	22889.121	18.935493
Sum256_Avx2_Cmp2	10.919	24008.159	19.861241
Sum256_Avx2_EqualAnd	10.700	24500.101	20.268209
Sum256Traits	8.553	30648.230	25.354374
SumKernelTraits	8.091	32399.369	26.803040
SumKernelTraits_Args0	7.627	34368.848	28.432332
SumKernelTraits_Args	8.335	31451.719	26.019077
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	8.314	31531.864	26.085379
SumKernel256Traits_Args0	8.323	31496.054	26.055754
SumKernel256Traits_Args	8.329	31473.059	26.036731

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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

