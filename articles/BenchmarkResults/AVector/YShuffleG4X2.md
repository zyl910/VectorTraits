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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	679.380	385.858
SumX1Traits	684.400	383.028	0.992665
SumTraits	679.509	385.785	0.999811
SumTraits_Tuple	742.136	353.229	0.915438
Sum128Traits	1080.870	242.531	0.628549
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	700.961	373.978	0.969212
Sum_ConstTraits_Tuple	763.762	343.227	0.889518
Sum_Const128Traits	1099.015	238.526	0.618172
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	701.501	373.690
SumX1Traits	696.890	376.163	1.006617
SumTraits	698.076	375.524	1.004907
SumTraits_Tuple	931.457	281.434	0.753123
Sum128Traits	1466.671	178.734	0.478295
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	680.964	384.960	1.030160
Sum_ConstTraits_Tuple	912.213	287.371	0.769010
Sum_Const128Traits	1463.754	179.090	0.479248
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	833.100	314.661
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	833.272	314.596	0.999794
SumTraits_Tuple	1027.183	255.207	0.811053
Sum128Traits	1275.058	205.594	0.653382
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	842.713	311.072	0.988594
Sum_ConstTraits_Tuple	1033.855	253.560	0.805820
Sum_Const128Traits	1290.687	203.104	0.645471
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	570.402	459.578
SumX1Traits	566.780	462.515	1.006391
SumTraits	569.556	460.261	1.001485
SumTraits_Tuple	605.121	433.209	0.942625
Sum128Traits	845.395	310.085	0.674716
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	592.110	442.729	0.963337
Sum_ConstTraits_Tuple	627.383	417.837	0.909175
Sum_Const128Traits	864.243	303.322	0.660002
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	676.040	387.764
SumX1Traits	44.164	5935.688	15.307476
SumTraits	36.690	7144.903	18.425908
SumTraits_Tuple	121.685	2154.287	5.555666
Sum128_AdvSimd	71.204	3681.616	9.494477
Sum128Traits	36.725	7137.978	18.408047
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	36.598	7162.871	18.472246
Sum_ConstTraits_Tuple	121.800	2152.246	5.550401
Sum_Const128Traits	36.568	7168.684	18.487236
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	687.770	381.151
SumX1Traits	74.135	3536.042	9.277276
SumTraits	67.567	3879.751	10.179041
SumTraits_Tuple	189.965	1379.956	3.620497
Sum128_AdvSimd	117.831	2224.736	5.836891
Sum128Traits	67.643	3875.407	10.167644
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	67.577	3879.192	10.177576
Sum_ConstTraits_Tuple	224.027	1170.146	3.070034
Sum_Const128Traits	67.593	3878.295	10.175222
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	773.857	338.750
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	216.744	1209.464	3.570375
SumTraits_Tuple	610.319	429.520	1.267955
Sum128_AdvSimd	488.214	536.945	1.585079
Sum128Traits	216.673	1209.861	3.571546
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	217.202	1206.914	3.562848
Sum_ConstTraits_Tuple	609.254	430.271	1.270172
Sum_Const128Traits	217.511	1205.197	3.557779
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	565.391	463.651
SumX1Traits	18.679	14034.527	30.269597
SumTraits	16.896	15515.454	33.463654
SumTraits_Tuple	54.397	4819.098	10.393808
Sum128_AdvSimd	29.567	8866.246	19.122675
Sum128Traits	16.931	15483.485	33.394703
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	16.856	15552.141	33.542779
Sum_ConstTraits_Tuple	55.651	4710.493	10.159568
Sum_Const128Traits	16.902	15509.914	33.451706
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	677.351	387.014
SumX1Traits	33.212	7893.089	20.394865
SumTraits	30.976	8462.884	21.867150
SumTraits_Tuple	90.564	2894.568	7.479243
Sum128_AdvSimd	49.410	5305.467	13.708737
Sum128Traits	30.673	8546.491	22.083181
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	31.198	8402.658	21.711534
Sum_ConstTraits_Tuple	88.967	2946.516	7.613468
Sum_Const128Traits	30.744	8526.711	22.032072
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	687.111	381.516
SumX1Traits	67.710	3871.594	10.147917
SumTraits	61.620	4254.200	11.150772
SumTraits_Tuple	183.461	1428.878	3.745262
Sum128_AdvSimd	98.211	2669.193	6.996277
Sum128Traits	62.515	4193.269	10.991065
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	62.304	4207.505	11.028380
Sum_ConstTraits_Tuple	183.481	1428.726	3.744863
Sum_Const128Traits	62.488	4195.113	10.995900
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	770.718	340.130
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	170.605	1536.557	4.517562
SumTraits_Tuple	387.356	676.752	1.989687
Sum128_AdvSimd	388.536	674.696	1.983643
Sum128Traits	174.862	1499.145	4.407570
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	174.647	1500.990	4.412994
Sum_ConstTraits_Tuple	387.488	676.521	1.989010
Sum_Const128Traits	174.940	1498.478	4.405607
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	565.124	463.870
SumX1Traits	18.670	14040.669	30.268571
SumTraits	15.308	17124.365	36.916338
SumTraits_Tuple	46.114	5684.755	12.255072
Sum128_AdvSimd	28.972	9048.188	19.505888
Sum128Traits	15.238	17202.753	37.085325
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	15.468	16947.788	36.535676
Sum_ConstTraits_Tuple	45.335	5782.395	12.465562
Sum_Const128Traits	15.695	16702.273	36.006400
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	507.020	517.029
SumX1Traits	29.587	8859.966	17.136315
SumTraits	24.837	10554.444	20.413654
SumTraits_Tuple	90.110	2909.155	5.626681
Sum128_AdvSimd	45.254	5792.771	11.203965
Sum128Traits	24.821	10561.232	20.426781
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	26.351	9948.207	19.241112
Sum_ConstTraits_Tuple	87.361	3000.704	5.803748
Sum_Const128Traits	26.334	9954.407	19.253104
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	663.884	394.864
SumX1Traits	62.261	4210.424	10.662971
SumTraits	51.306	5109.443	12.939752
SumTraits_Tuple	178.470	1468.844	3.719872
Sum128_AdvSimd	91.262	2872.439	7.274501
Sum128Traits	51.389	5101.200	12.918875
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	54.326	4825.364	12.220318
Sum_ConstTraits_Tuple	179.685	1458.906	3.694703
Sum_Const128Traits	54.180	4838.384	12.253290
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	564.240	464.597
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	160.381	1634.510	3.518124
SumTraits_Tuple	369.103	710.218	1.528676
Sum128_AdvSimd	361.009	726.143	1.562952
Sum128Traits	160.759	1630.660	3.509838
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	160.504	1633.253	3.515420
Sum_ConstTraits_Tuple	369.366	709.713	1.527588
Sum_Const128Traits	160.587	1632.409	3.513602
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	410.688	638.305
SumX1Traits	14.721	17806.962	27.897266
SumTraits	12.443	21066.988	33.004585
SumTraits_Tuple	43.891	5972.603	9.356975
Sum128_AdvSimd	22.729	11533.557	18.069040
Sum128Traits	12.447	21060.724	32.994771
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	13.232	19811.234	31.037258
Sum_ConstTraits_Tuple	43.864	5976.286	9.362745
Sum_Const128Traits	13.234	19807.954	31.032120
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

```

