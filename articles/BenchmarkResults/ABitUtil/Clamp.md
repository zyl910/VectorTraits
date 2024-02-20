# Benchmark - Clamp
([← Back](README.md))

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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6311.824	207.661
SumClamp_IfUnrolling4	6113.769	214.388	1.032395
SumClamp_MinMax	6873.932	190.680	0.918226
SumClamp_MinMaxUnrolling4	8021.961	163.391	0.786818
SumClamp_BitMath	3181.015	412.045	1.984217
SumClamp_BitMathUnrolling4	3334.806	393.042	1.892711

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6438.721	203.568
SumClamp_IfUnrolling4	6181.608	212.035	1.041593
SumClamp_MinMax	6386.589	205.230	1.008163
SumClamp_MinMaxUnrolling4	6412.293	204.407	1.004122
SumClamp_BitMath	2256.096	580.968	2.853922
SumClamp_BitMathUnrolling4	2279.486	575.007	2.824638

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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6242.034	209.983
SumClamp_IfUnrolling4	6149.454	213.144	1.015055
SumClamp_MinMax	6637.929	197.459	0.940359
SumClamp_MinMaxUnrolling4	6500.883	201.622	0.960182
SumClamp_Math	9532.058	137.507	0.654846
SumClamp_MathUnrolling4	7971.738	164.421	0.783020
SumClamp_BitMath	3181.520	411.979	1.961966
SumClamp_BitMathUnrolling4	3331.780	393.399	1.873483

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6170.631	212.413
SumClamp_IfUnrolling4	6072.050	215.861	1.016235
SumClamp_MinMax	6523.524	200.922	0.945905
SumClamp_MinMaxUnrolling4	6425.783	203.978	0.960292
SumClamp_Math	9895.439	132.457	0.623583
SumClamp_MathUnrolling4	7690.760	170.428	0.802343
SumClamp_BitMath	2268.149	577.881	2.720558
SumClamp_BitMathUnrolling4	2274.768	576.199	2.712642

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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6408.466	204.529
SumClamp_IfUnrolling4	6132.069	213.748	1.045074
SumClamp_MinMax	6550.322	200.100	0.978344
SumClamp_MinMaxUnrolling4	6497.897	201.714	0.986237
SumClamp_Math	6708.333	195.387	0.955299
SumClamp_MathUnrolling4	6537.034	200.507	0.980332
SumClamp_BitMath	3399.327	385.582	1.885216
SumClamp_BitMathUnrolling4	3044.548	430.514	2.104899

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6368.555	205.811
SumClamp_IfUnrolling4	6164.736	212.616	1.033062
SumClamp_MinMax	6587.074	198.984	0.966826
SumClamp_MinMaxUnrolling4	6480.770	202.248	0.982685
SumClamp_Math	6459.191	202.923	0.985968
SumClamp_MathUnrolling4	6403.458	204.689	0.994549
SumClamp_BitMath	2251.897	582.051	2.828084
SumClamp_BitMathUnrolling4	2222.503	589.749	2.865488

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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6349.780	206.420
SumClamp_IfUnrolling4	6155.708	212.928	1.031527
SumClamp_MinMax	7059.110	185.678	0.899516
SumClamp_MinMaxUnrolling4	8132.241	161.176	0.780816
SumClamp_Math	6669.441	196.526	0.952071
SumClamp_MathUnrolling4	6468.493	202.631	0.981647
SumClamp_BitMath	5265.756	248.914	1.205863
SumClamp_BitMathUnrolling4	3966.038	330.486	1.601039

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6205.464	211.220
SumClamp_IfUnrolling4	6064.688	216.123	1.023212
SumClamp_MinMax	6934.346	189.019	0.894888
SumClamp_MinMaxUnrolling4	6848.905	191.377	0.906052
SumClamp_Math	6668.914	196.542	0.930506
SumClamp_MathUnrolling4	6449.520	203.228	0.962159
SumClamp_BitMath	3627.501	361.329	1.710672
SumClamp_BitMathUnrolling4	3277.850	399.872	1.893150

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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6232.072	210.318
SumClamp_IfUnrolling4	6218.366	210.782	1.002204
SumClamp_MinMax	6972.638	187.981	0.893790
SumClamp_MinMaxUnrolling4	7541.800	173.794	0.826337
SumClamp_Math	6585.328	199.036	0.946357
SumClamp_MathUnrolling4	6490.212	201.953	0.960226
SumClamp_BitMath	4111.664	318.781	1.515706
SumClamp_BitMathUnrolling4	3928.053	333.682	1.586555

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6316.058	207.522
SumClamp_IfUnrolling4	6149.948	213.127	1.027010
SumClamp_MinMax	7063.761	185.556	0.894149
SumClamp_MinMaxUnrolling4	8187.817	160.082	0.771397
SumClamp_Math	6612.351	198.223	0.955191
SumClamp_MathUnrolling4	6443.677	203.412	0.980195
SumClamp_BitMath	3633.441	360.738	1.738313
SumClamp_BitMathUnrolling4	3245.092	403.908	1.946341

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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	5966.851	219.667
SumClamp_IfUnrolling4	5971.799	219.485	0.999171
SumClamp_MinMax	6822.157	192.127	0.874628
SumClamp_MinMaxUnrolling4	7423.168	176.572	0.803815
SumClamp_Math	6519.032	201.061	0.915297
SumClamp_MathUnrolling4	6303.491	207.936	0.946595
SumClamp_BitMath	3080.552	425.482	1.936942
SumClamp_BitMathUnrolling4	3224.091	406.539	1.850708

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	5945.656	220.450
SumClamp_IfUnrolling4	5889.078	222.568	1.009607
SumClamp_MinMax	6953.454	188.499	0.855065
SumClamp_MinMaxUnrolling4	7032.708	186.375	0.845429
SumClamp_Math	6473.057	202.489	0.918524
SumClamp_MathUnrolling4	6139.691	213.483	0.968397
SumClamp_BitMath	2281.124	574.594	2.606459
SumClamp_BitMathUnrolling4	2428.114	539.810	2.448672

```

## Arm

### AWS Arm t4g.small
`AWS Arm t4g.small`

#### .NET Core 3.1

```
```

#### .NET 5.0

```
```

#### .NET 6.0

```
```

#### .NET 7.0

```
```

