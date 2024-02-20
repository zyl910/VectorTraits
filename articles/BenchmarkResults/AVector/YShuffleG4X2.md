# Benchmark - YShuffleG4X2
([← Back](README.md))

See [Group](YShuffleG4X2_Group.md)

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	433.749	604.368
SumX1Traits	438.335	598.045	0.989539
SumTraits	446.136	587.588	0.972236
SumTraits_Tuple	467.301	560.975	0.928202
Sum_ConstTraits	435.406	602.068	0.996195
Sum_ConstTraits_Tuple	465.120	563.605	0.932553

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	517.533	506.526
SumX1Traits	526.379	498.014	0.983195
SumTraits	527.264	497.178	0.981545
SumTraits_Tuple	586.212	447.183	0.882844
Sum_ConstTraits	522.304	501.899	0.990865
Sum_ConstTraits_Tuple	586.503	446.961	0.882405

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	504.830	519.272
SumX1Traits	467.843	560.325	1.079058
SumTraits	471.502	555.976	1.070683
SumTraits_Tuple	616.130	425.469	0.819356
Sum_ConstTraits	472.051	555.330	1.069439
Sum_ConstTraits_Tuple	592.837	442.186	0.851549

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	391.507	669.577
SumX1Traits	393.657	665.919	0.994538
SumTraits	393.840	665.610	0.994076
SumTraits_Tuple	409.073	640.824	0.957059
Sum_ConstTraits	392.206	668.384	0.998219
Sum_ConstTraits_Tuple	408.156	642.265	0.959210

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	433.282	605.019
SumX1Traits	433.000	605.413	1.000651
SumTraits	441.044	594.372	0.982403
SumTraits_Tuple	462.849	566.371	0.936121
Sum_ConstTraits	430.272	609.252	1.006997
Sum_ConstTraits_Tuple	460.423	569.355	0.941053

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	517.779	506.285
SumX1Traits	517.125	506.926	1.001266
SumTraits	517.328	506.727	1.000873
SumTraits_Tuple	576.504	454.713	0.898136
Sum_ConstTraits	512.289	511.712	1.010718
Sum_ConstTraits_Tuple	571.990	458.302	0.905225

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	463.847	565.151
SumX1Traits	460.908	568.756	1.006377
SumTraits	464.988	563.765	0.997547
SumTraits_Tuple	586.241	447.161	0.791224
Sum_ConstTraits	429.428	610.450	1.080153
Sum_ConstTraits_Tuple	554.668	472.614	0.836261

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	390.824	670.746
SumX1Traits	391.281	669.964	0.998834
SumTraits	390.808	670.774	1.000041
SumTraits_Tuple	405.995	645.683	0.962634
Sum_ConstTraits	390.601	671.130	1.000572
Sum_ConstTraits_Tuple	404.669	647.798	0.965788

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	433.459	604.772
SumX1Traits	20.274	12930.060	21.380063
SumTraits	13.612	19257.822	31.843119
SumTraits_Tuple	13.581	19302.355	31.916756
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	14.180	18486.745	30.568132
Sum_ConstTraits	12.190	21505.117	35.559059
Sum_ConstTraits_Tuple	11.881	22064.664	36.484278
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	11.480	22835.240	37.758439

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	517.140	506.911
SumX1Traits	40.373	6493.039	12.809027
SumTraits	27.126	9663.801	19.064091
SumTraits_Tuple	28.698	9134.729	18.020374
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	40.654	6448.121	12.720415
Sum256Traits	27.325	9593.401	18.925211
Sum_ConstTraits	19.204	13650.390	26.928563
Sum_ConstTraits_Tuple	19.155	13685.470	26.997768
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	19.274	13600.812	26.830760

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	457.986	572.385
SumX1Traits	79.547	3295.475	5.757446
SumTraits	54.402	4818.673	8.418589
SumTraits_Tuple	53.344	4914.221	8.585519
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	53.337	4914.886	8.586680
Sum_ConstTraits	39.211	6685.522	11.680116
Sum_ConstTraits_Tuple	39.206	6686.245	11.681379
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	38.968	6727.235	11.752992

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	391.835	669.016
SumX1Traits	9.502	27587.913	41.236575
SumTraits	6.594	39753.833	59.421380
SumTraits_Tuple	6.582	39824.855	59.527540
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.583	39821.505	59.522532
Sum_ConstTraits	6.587	39799.662	59.489883
Sum_ConstTraits_Tuple	6.610	39657.481	59.277360
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	6.623	39580.757	59.162678

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	436.040	601.192
SumX1Traits	21.323	12294.010	20.449378
SumTraits	15.714	16682.197	27.748518
SumTraits_Tuple	16.083	16299.193	27.111444
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	16.088	16294.572	27.103758
Sum_ConstTraits	11.785	22244.778	37.001099
Sum_ConstTraits_Tuple	11.432	22931.536	38.143425
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	11.492	22811.077	37.943059

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	523.750	500.513
SumX1Traits	39.865	6575.761	13.138036
SumTraits	26.691	9821.422	19.622701
SumTraits_Tuple	27.346	9586.225	19.152791
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	40.530	6467.938	12.922611
Sum256Traits	27.543	9517.575	19.015632
Sum_ConstTraits	20.204	12974.746	25.922882
Sum_ConstTraits_Tuple	20.203	12975.482	25.924355
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	20.089	13049.137	26.071513

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	481.209	544.761
SumX1Traits	79.489	3297.847	6.053750
SumTraits	53.164	4930.841	9.051384
SumTraits_Tuple	54.350	4823.261	8.853903
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	57.637	4548.164	8.348916
Sum_ConstTraits	40.413	6486.618	11.907274
Sum_ConstTraits_Tuple	40.590	6458.302	11.855295
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	40.320	6501.550	11.934684

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	391.614	669.393
SumX1Traits	9.589	27336.581	40.837840
SumTraits	6.151	42621.456	63.671760
SumTraits_Tuple	6.151	42616.437	63.664263
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.153	42602.583	63.643565
Sum_ConstTraits	6.375	41117.714	61.425336
Sum_ConstTraits_Tuple	6.404	40934.326	61.151374
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	6.289	41680.650	62.266299

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	436.047	601.183
SumX1Traits	13.964	18772.650	31.226194
SumTraits	10.282	25494.812	42.407756
SumTraits_Tuple	10.831	24203.469	40.259752
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.983	23868.968	39.703347
Sum_ConstTraits	11.991	21862.272	36.365435
Sum_ConstTraits_Tuple	11.766	22279.852	37.060032
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	12.425	21098.262	35.094590

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	522.801	501.422
SumX1Traits	27.876	9403.820	18.754301
SumTraits	22.516	11642.613	23.219188
SumTraits_Tuple	22.863	11466.051	22.867067
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	30.504	8593.620	17.138496
Sum256Traits	22.981	11406.760	22.748821
Sum_ConstTraits	20.072	13060.254	26.046430
Sum_ConstTraits_Tuple	19.958	13135.072	26.195642
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	21.043	12457.351	24.844043

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	480.929	545.078
SumX1Traits	55.354	4735.738	8.688182
SumTraits	44.989	5826.852	10.689939
SumTraits_Tuple	46.204	5673.575	10.408738
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	46.953	5583.076	10.242710
Sum_ConstTraits	42.309	6195.988	11.367156
Sum_ConstTraits_Tuple	45.931	5707.375	10.470747
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	40.384	6491.337	11.909004

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	391.959	668.805
SumX1Traits	7.735	33891.346	50.674460
SumTraits	5.169	50719.209	75.835539
SumTraits_Tuple	5.175	50652.042	75.735110
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	5.165	50758.770	75.894691
Sum_ConstTraits	5.219	50227.260	75.099974
Sum_ConstTraits_Tuple	5.485	47794.201	71.462056
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	5.332	49159.909	73.504068

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	362.671	722.814
SumX1Traits	14.077	18621.907	25.763068
SumTraits	10.334	25367.735	35.095797
SumTraits_Tuple	11.489	22816.660	31.566430
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	12.778	20514.835	28.381898
Sum_ConstTraits	12.527	20926.384	28.951269
Sum_ConstTraits_Tuple	12.567	20859.201	28.858323
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	11.966	21906.832	30.307700

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	435.744	601.601
SumX1Traits	25.900	10121.229	16.823812
SumTraits	20.565	12747.287	21.188925
SumTraits_Tuple	21.708	12076.112	20.073276
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	27.931	9385.387	15.600674
Sum256Traits	24.737	10597.180	17.614953
Sum_ConstTraits	21.854	11995.514	19.939304
Sum_ConstTraits_Tuple	21.868	11987.409	19.925833
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	21.464	12213.343	20.301386

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	443.926	590.512
SumX1Traits	55.559	4718.277	7.990142
SumTraits	44.007	5956.913	10.087703
SumTraits_Tuple	44.506	5890.045	9.974468
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	45.571	5752.407	9.741384
Sum_ConstTraits	40.699	6440.999	10.907477
Sum_ConstTraits_Tuple	40.663	6446.679	10.917097
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	40.109	6535.823	11.068056

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	316.303	828.776
SumX1Traits	5.920	44280.087	53.428289
SumTraits	4.292	61080.997	73.700242
SumTraits_Tuple	4.573	57320.647	69.163010
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4.290	61099.128	73.722120
Sum_ConstTraits	4.617	56773.400	68.502702
Sum_ConstTraits_Tuple	4.636	56544.720	68.226777
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	4.871	53815.407	64.933593

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	681.636	384.581
SumX1Traits	685.327	382.509	0.994614
SumTraits	679.396	385.849	1.003296
SumTraits_Tuple	742.581	353.018	0.917928
Sum128Traits	1081.728	242.338	0.630136
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	701.803	373.529	0.971264
Sum_ConstTraits_Tuple	764.091	343.080	0.892087
Sum_Const128Traits	1101.146	238.065	0.619024
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	704.121	372.300
SumX1Traits	700.937	373.991	1.004542
SumTraits	706.476	371.059	0.996666
SumTraits_Tuple	925.998	283.093	0.760391
Sum128Traits	1467.969	178.576	0.479656
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	681.324	384.756	1.033459
Sum_ConstTraits_Tuple	908.635	288.503	0.774922
Sum_Const128Traits	1466.974	178.697	0.479982
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	833.284	314.591
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	835.052	313.926	0.997883
SumTraits_Tuple	1028.268	254.937	0.810376
Sum128Traits	1279.207	204.927	0.651407
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	851.145	307.990	0.979015
Sum_ConstTraits_Tuple	1050.006	249.660	0.793599
Sum_Const128Traits	1279.458	204.887	0.651279
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	569.898	459.984
SumX1Traits	567.554	461.883	1.004130
SumTraits	570.469	459.523	0.998999
SumTraits_Tuple	605.697	432.798	0.940897
Sum128Traits	848.596	308.915	0.671578
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	592.055	442.770	0.962577
Sum_ConstTraits_Tuple	626.541	418.399	0.909594
Sum_Const128Traits	865.534	302.870	0.658436
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	676.166	387.692
SumX1Traits	39.934	6564.384	16.931967
SumTraits	33.744	7768.697	20.038335
SumTraits_Tuple	112.841	2323.129	5.992206
Sum128_AdvSimd	59.358	4416.346	11.391386
Sum128Traits	33.832	7748.439	19.986082
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	33.759	7765.248	20.029438
Sum_ConstTraits_Tuple	106.182	2468.814	6.367982
Sum_Const128Traits	33.837	7747.366	19.983312
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	689.231	380.343
SumX1Traits	80.537	3254.959	8.557964
SumTraits	68.648	3818.691	10.040131
SumTraits_Tuple	230.276	1138.388	2.993059
Sum128_AdvSimd	118.133	2219.063	5.834377
Sum128Traits	68.206	3843.423	10.105156
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	68.399	3832.587	10.076668
Sum_ConstTraits_Tuple	230.759	1136.007	2.986799
Sum_Const128Traits	68.261	3840.331	10.097029
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	770.887	340.055
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	211.271	1240.795	3.648805
SumTraits_Tuple	625.982	418.773	1.231485
Sum128_AdvSimd	472.663	554.611	1.630946
Sum128Traits	211.741	1238.041	3.640708
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	213.964	1225.177	3.602880
Sum_ConstTraits_Tuple	612.650	427.885	1.258283
Sum_Const128Traits	213.807	1226.078	3.605529
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	565.734	463.370
SumX1Traits	18.558	14125.982	30.485328
SumTraits	16.800	15604.242	33.675565
SumTraits_Tuple	54.485	4811.334	10.383356
Sum128_AdvSimd	28.886	9075.087	19.584974
Sum128Traits	16.825	15580.659	33.624671
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	16.791	15612.462	33.693305
Sum_ConstTraits_Tuple	52.846	4960.488	10.705245
Sum_Const128Traits	16.808	15596.408	33.658658
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	674.925	388.405
SumX1Traits	32.375	8097.043	20.846932
SumTraits	30.277	8658.265	22.291874
SumTraits_Tuple	91.071	2878.457	7.410976
Sum128_AdvSimd	49.024	5347.275	13.767283
Sum128Traits	29.987	8741.823	22.507006
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	31.027	8448.968	21.753011
Sum_ConstTraits_Tuple	91.074	2878.354	7.410712
Sum_Const128Traits	30.828	8503.488	21.893378
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	693.196	378.167
SumX1Traits	68.099	3849.454	10.179241
SumTraits	65.705	3989.740	10.550206
SumTraits_Tuple	182.345	1437.628	3.801569
Sum128_AdvSimd	97.913	2677.315	7.079714
Sum128Traits	63.811	4108.155	10.863334
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	65.013	4032.178	10.662425
Sum_ConstTraits_Tuple	182.037	1440.057	3.807992
Sum_Const128Traits	63.741	4112.626	10.875155
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	774.945	338.274
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	170.796	1534.835	4.537250
SumTraits_Tuple	406.671	644.609	1.905582
Sum128_AdvSimd	411.915	636.404	1.881325
Sum128Traits	174.605	1501.356	4.438282
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	175.188	1496.361	4.423513
Sum_ConstTraits_Tuple	411.066	637.717	1.885208
Sum_Const128Traits	175.053	1497.514	4.426924
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	564.929	464.030
SumX1Traits	16.714	15684.232	33.800050
SumTraits	14.911	17580.562	37.886706
SumTraits_Tuple	46.611	5624.091	12.120105
Sum128_AdvSimd	24.131	10863.503	23.411217
Sum128Traits	15.165	17285.738	37.251350
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	14.725	17802.435	38.364849
Sum_ConstTraits_Tuple	45.595	5749.413	12.390180
Sum_Const128Traits	15.103	17356.546	37.403945
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	509.115	514.902
SumX1Traits	29.988	8741.548	16.977123
SumTraits	25.125	10433.609	20.263307
SumTraits_Tuple	87.387	2999.818	5.826002
Sum128_AdvSimd	45.617	5746.664	11.160703
Sum128Traits	25.124	10434.019	20.264103
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	26.586	9860.214	19.149706
Sum_ConstTraits_Tuple	87.365	3000.560	5.827444
Sum_Const128Traits	26.593	9857.672	19.144769
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	662.816	395.500
SumX1Traits	61.282	4277.648	10.815785
SumTraits	51.190	5120.962	12.948057
SumTraits_Tuple	182.590	1435.697	3.630078
Sum128_AdvSimd	92.160	2844.455	7.192040
Sum128Traits	51.311	5108.926	12.917623
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	53.910	4862.617	12.294845
Sum_ConstTraits_Tuple	178.938	1464.997	3.704160
Sum_Const128Traits	53.979	4856.366	12.279040
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	563.076	465.557
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	160.113	1637.245	3.516743
SumTraits_Tuple	372.433	703.869	1.511886
Sum128_AdvSimd	361.501	725.155	1.557607
Sum128Traits	160.204	1636.318	3.514753
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	160.277	1635.564	3.513134
Sum_ConstTraits_Tuple	366.665	714.942	1.535671
Sum_Const128Traits	160.169	1636.674	3.515516
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	409.970	639.422
SumX1Traits	14.861	17640.121	27.587600
SumTraits	12.464	21032.648	32.893214
SumTraits_Tuple	43.891	5972.646	9.340694
Sum128_AdvSimd	22.920	11437.349	17.887009
Sum128Traits	12.463	21033.148	32.893996
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	13.233	19809.813	30.980808
Sum_ConstTraits_Tuple	42.895	6111.353	9.557619
Sum_Const128Traits	13.236	19806.095	30.974992
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

