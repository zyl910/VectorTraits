# Benchmark - Clamp
([← Back](README.md))

See [Group](Clamp_Group.md)

## X86

### AMD Ryzen 7 7840H
`AMD Ryzen 7 7840H w/ Radeon 780M Graphics`

#### .NET Framework

```
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9277.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6525.960	200.847
SumClamp_IfUnrolling4	6117.904	214.243	1.066699
SumClamp_MinMax	7123.185	184.008	0.916158
SumClamp_MinMaxUnrolling4	6796.903	192.841	0.960137
SumClamp_BitMath	3043.319	430.688	2.144356
SumClamp_BitMathUnrolling4	3494.178	375.115	1.867667

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	5939.546	220.677
SumClamp_IfUnrolling4	5619.760	233.234	1.056904
SumClamp_MinMax	6402.801	204.710	0.927648
SumClamp_MinMaxUnrolling4	6356.565	206.199	0.934396
SumClamp_BitMath	2201.963	595.251	2.697387
SumClamp_BitMathUnrolling4	2175.685	602.440	2.729966

```

#### .NET Core 2.1

```
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:	.NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6461.712	202.844
SumClamp_IfUnrolling4	6251.810	209.654	1.033575
SumClamp_MinMax	6852.774	191.269	0.942934
SumClamp_MinMaxUnrolling4	6722.820	194.966	0.961161
SumClamp_Math	7872.820	166.487	0.820762
SumClamp_MathUnrolling4	7662.532	171.056	0.843287
SumClamp_BitMath	3275.642	400.141	1.972655
SumClamp_BitMathUnrolling4	3592.138	364.886	1.798849

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6081.458	215.527
SumClamp_IfUnrolling4	5776.911	226.889	1.052718
SumClamp_MinMax	6511.671	201.288	0.933932
SumClamp_MinMaxUnrolling4	6437.907	203.594	0.944633
SumClamp_Math	7610.356	172.228	0.799103
SumClamp_MathUnrolling4	7405.953	176.982	0.821158
SumClamp_BitMath	2358.603	555.719	2.578416
SumClamp_BitMathUnrolling4	2404.738	545.057	2.528948

```

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6587.070	198.984
SumClamp_IfUnrolling4	6168.111	212.499	1.067923
SumClamp_MinMax	7159.065	183.085	0.920102
SumClamp_MinMaxUnrolling4	6688.293	195.972	0.984866
SumClamp_Math	6928.485	189.178	0.950723
SumClamp_MathUnrolling4	6576.418	199.306	1.001620
SumClamp_BitMath	3592.495	364.850	1.833564
SumClamp_BitMathUnrolling4	3187.272	411.236	2.066680

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6080.054	215.577
SumClamp_IfUnrolling4	5938.524	220.715	1.023832
SumClamp_MinMax	6749.904	194.184	0.900762
SumClamp_MinMaxUnrolling4	6372.068	205.698	0.954173
SumClamp_Math	6488.306	202.013	0.937079
SumClamp_MathUnrolling4	6304.317	207.908	0.964427
SumClamp_BitMath	2375.374	551.795	2.559619
SumClamp_BitMathUnrolling4	2233.354	586.884	2.722387

```

#### .NET 5.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	5.0.17
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.17\
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
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
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6363.195	205.985
SumClamp_IfUnrolling4	6183.721	211.963	1.029024
SumClamp_MinMax	6912.799	189.608	0.920495
SumClamp_MinMaxUnrolling4	6902.335	189.895	0.921890
SumClamp_Math	6782.039	193.263	0.938242
SumClamp_MathUnrolling4	6594.018	198.774	0.964995
SumClamp_BitMath	6593.604	198.787	0.965056
SumClamp_BitMathUnrolling4	5522.567	237.339	1.152217

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6310.224	207.714
SumClamp_IfUnrolling4	5951.449	220.235	1.060284
SumClamp_MinMax	6841.248	191.591	0.922379
SumClamp_MinMaxUnrolling4	6706.567	195.438	0.940902
SumClamp_Math	6429.251	203.868	0.981487
SumClamp_MathUnrolling4	6383.038	205.344	0.988593
SumClamp_BitMath	5331.742	245.833	1.183520
SumClamp_BitMathUnrolling4	4633.261	282.894	1.361940

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.33
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.33\
RuntimeInformation.FrameworkDescription:	.NET 6.0.33
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.33/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6344.721	206.584
SumClamp_IfUnrolling4	6154.448	212.971	1.030916
SumClamp_MinMax	7337.908	178.623	0.864650
SumClamp_MinMaxUnrolling4	6851.447	191.306	0.926041
SumClamp_Math	6786.096	193.148	0.934959
SumClamp_MathUnrolling4	6632.620	197.617	0.956593
SumClamp_BitMath	6147.435	213.214	1.032092
SumClamp_BitMathUnrolling4	5259.130	249.228	1.206420

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6616.016	198.113
SumClamp_IfUnrolling4	5843.225	224.314	1.132254
SumClamp_MinMax	6943.124	188.780	0.952887
SumClamp_MinMaxUnrolling4	6643.633	197.290	0.995843
SumClamp_Math	6571.752	199.448	1.006736
SumClamp_MathUnrolling4	6340.283	206.729	1.043489
SumClamp_BitMath	5347.109	245.127	1.237307
SumClamp_BitMathUnrolling4	4591.586	285.461	1.440900

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.20
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.20\
RuntimeInformation.FrameworkDescription:	.NET 7.0.20
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.20/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6144.704	213.309
SumClamp_IfUnrolling4	5805.339	225.778	1.058457
SumClamp_MinMax	6613.260	198.196	0.929149
SumClamp_MinMaxUnrolling4	6703.717	195.521	0.916611
SumClamp_Math	6597.095	198.681	0.931426
SumClamp_MathUnrolling4	6134.498	213.664	1.001664
SumClamp_BitMath	3764.236	348.203	1.632390
SumClamp_BitMathUnrolling4	3761.571	348.450	1.633547

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	5838.830	224.483
SumClamp_IfUnrolling4	5499.829	238.320	1.061638
SumClamp_MinMax	6239.450	210.070	0.935792
SumClamp_MinMaxUnrolling4	6373.527	205.651	0.916107
SumClamp_Math	6436.756	203.631	0.907108
SumClamp_MathUnrolling4	5839.913	224.442	0.999815
SumClamp_BitMath	2718.824	482.091	2.147557
SumClamp_BitMathUnrolling4	2688.711	487.490	2.171609

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.8
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.8\
RuntimeInformation.FrameworkDescription:	.NET 8.0.8
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector512.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844161	# 0x8177F7FF
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Avx512BW, Avx512CD, Avx512DQ, Avx512F, Avx512Vbmi, Avx512VL, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2, Avx512VL
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vector512s.Instance:	WVectorTraits512Avx512	// Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi, Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vectors.BaseInstance:	VectorTraits256Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	5902.928	222.046
SumClamp_IfUnrolling4	6005.248	218.262	0.982962
SumClamp_MinMax	6534.867	200.573	0.903297
SumClamp_MinMaxUnrolling4	6665.010	196.657	0.885659
SumClamp_Math	6815.538	192.314	0.866099
SumClamp_MathUnrolling4	6126.906	213.929	0.963444
SumClamp_BitMath	2500.605	524.161	2.360600
SumClamp_BitMathUnrolling4	2540.442	515.942	2.323582

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	5600.774	234.025
SumClamp_IfUnrolling4	5756.265	227.703	0.972987
SumClamp_MinMax	6988.506	187.554	0.801426
SumClamp_MinMaxUnrolling4	6379.493	205.458	0.877934
SumClamp_Math	5966.148	219.693	0.938759
SumClamp_MathUnrolling4	5711.469	229.489	0.980619
SumClamp_BitMath	1786.346	733.743	3.135323
SumClamp_BitMathUnrolling4	1742.071	752.392	3.215008

```

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

### Apple M2
`Apple M2`

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	6.0.33
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.33/
RuntimeInformation.FrameworkDescription:	.NET 6.0.33
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.15-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.33/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, ArmBase, Crc32
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	4907.773	267.070
SumClamp_IfUnrolling4	4717.896	277.819	1.040246
SumClamp_MinMax	5715.134	229.342	0.858733
SumClamp_MinMaxUnrolling4	5396.101	242.901	0.909504
SumClamp_Math	5486.060	238.918	0.894590
SumClamp_MathUnrolling4	5161.372	253.948	0.950866
SumClamp_BitMath	2021.048	648.535	2.428331
SumClamp_BitMathUnrolling4	2015.749	650.240	2.434715

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	4889.574	268.064
SumClamp_IfUnrolling4	4659.474	281.302	1.049383
SumClamp_MinMax	5575.672	235.078	0.876948
SumClamp_MinMaxUnrolling4	5317.907	246.473	0.919455
SumClamp_Math	5655.775	231.749	0.864528
SumClamp_MathUnrolling4	5093.088	257.353	0.960041
SumClamp_BitMath	1395.342	939.354	3.504212
SumClamp_BitMathUnrolling4	1340.001	978.149	3.648934

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	7.0.20
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.20/
RuntimeInformation.FrameworkDescription:	.NET 7.0.20
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.15-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.20/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	4300.084	304.813
SumClamp_IfUnrolling4	4183.756	313.288	1.027805
SumClamp_MinMax	4965.818	263.948	0.865937
SumClamp_MinMaxUnrolling4	4907.687	267.075	0.876194
SumClamp_Math	4706.018	278.520	0.913742
SumClamp_MathUnrolling4	4562.135	287.304	0.942560
SumClamp_BitMath	1605.508	816.389	2.678332
SumClamp_BitMathUnrolling4	1563.824	838.151	2.749724

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	4222.771	310.393
SumClamp_IfUnrolling4	4198.380	312.197	1.005809
SumClamp_MinMax	4748.910	276.004	0.889208
SumClamp_MinMaxUnrolling4	4711.191	278.214	0.896328
SumClamp_Math	4591.634	285.458	0.919666
SumClamp_MathUnrolling4	4480.732	292.524	0.942429
SumClamp_BitMath	1031.341	1270.889	4.094445
SumClamp_BitMathUnrolling4	1057.625	1239.305	3.992690

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	8.0.4
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.4/
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.4/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844159	# 0x8177F801
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	4126.041	317.670
SumClamp_IfUnrolling4	4224.832	310.242	0.976616
SumClamp_MinMax	4804.546	272.808	0.858779
SumClamp_MinMaxUnrolling4	4865.373	269.398	0.848042
SumClamp_Math	4558.388	287.540	0.905153
SumClamp_MathUnrolling4	4267.812	307.118	0.966781
SumClamp_BitMath	1383.865	947.144	2.981534
SumClamp_BitMathUnrolling4	1365.834	959.648	3.020894

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	4114.090	318.593
SumClamp_IfUnrolling4	4142.870	316.380	0.993053
SumClamp_MinMax	4887.199	268.195	0.841809
SumClamp_MinMaxUnrolling4	4682.087	279.944	0.878687
SumClamp_Math	4539.399	288.743	0.906307
SumClamp_MathUnrolling4	4364.857	300.289	0.942548
SumClamp_BitMath	976.491	1342.275	4.213136
SumClamp_BitMathUnrolling4	993.023	1319.929	4.142995

```

### AWS Arm t4g.small
`AWS Arm t4g.small`

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	7851.308	166.943
SumClamp_IfUnrolling4	7556.821	173.449	1.038970
SumClamp_MinMax	8639.582	151.711	0.908760
SumClamp_MinMaxUnrolling4	8494.139	154.309	0.924321
SumClamp_Math	8155.732	160.712	0.962674
SumClamp_MathUnrolling4	8460.032	154.931	0.928047
SumClamp_BitMath	5292.026	247.678	1.483611
SumClamp_BitMathUnrolling4	5255.392	249.405	1.493953

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	7841.992	167.141
SumClamp_IfUnrolling4	7795.465	168.139	1.005968
SumClamp_MinMax	8531.045	153.641	0.919230
SumClamp_MinMaxUnrolling4	8408.627	155.878	0.932613
SumClamp_Math	8266.193	158.564	0.948682
SumClamp_MathUnrolling4	8122.236	161.374	0.965497
SumClamp_BitMath	4054.303	323.291	1.934239
SumClamp_BitMathUnrolling4	4095.037	320.075	1.914999

```

#### .NET 5.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	7696.812	170.294
SumClamp_IfUnrolling4	7946.264	164.948	0.968608
SumClamp_MinMax	8430.965	155.465	0.912922
SumClamp_MinMaxUnrolling4	9498.339	137.995	0.810332
SumClamp_Math	8015.646	163.520	0.960223
SumClamp_MathUnrolling4	8312.450	157.682	0.925938
SumClamp_BitMath	6933.126	189.052	1.110150
SumClamp_BitMathUnrolling4	7189.025	182.322	1.070634

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	7568.787	173.174
SumClamp_IfUnrolling4	7612.609	172.177	0.994243
SumClamp_MinMax	10868.024	120.603	0.696427
SumClamp_MinMaxUnrolling4	11060.172	118.508	0.684328
SumClamp_Math	8211.354	159.623	0.921746
SumClamp_MathUnrolling4	8070.213	162.415	0.937867
SumClamp_BitMath	5443.168	240.801	1.390511
SumClamp_BitMathUnrolling4	5733.610	228.603	1.320074

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	7989.851	164.048
SumClamp_IfUnrolling4	7738.241	169.382	1.032515
SumClamp_MinMax	8707.972	150.520	0.917533
SumClamp_MinMaxUnrolling4	9601.919	136.506	0.832110
SumClamp_Math	8294.740	158.018	0.963243
SumClamp_MathUnrolling4	8405.900	155.929	0.950505
SumClamp_BitMath	6940.193	188.859	1.151243
SumClamp_BitMathUnrolling4	7138.842	183.604	1.119208

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	7645.667	171.433
SumClamp_IfUnrolling4	7649.955	171.337	0.999439
SumClamp_MinMax	8786.730	149.170	0.870138
SumClamp_MinMaxUnrolling4	8755.775	149.698	0.873214
SumClamp_Math	8216.534	159.522	0.930522
SumClamp_MathUnrolling4	8086.720	162.083	0.945460
SumClamp_BitMath	5444.736	240.732	1.404231
SumClamp_BitMathUnrolling4	5731.000	228.707	1.334089

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6776.848	193.411
SumClamp_IfUnrolling4	6662.951	196.718	1.017094
SumClamp_MinMax	7677.384	170.725	0.882703
SumClamp_MinMaxUnrolling4	7444.090	176.075	0.910366
SumClamp_Math	7454.675	175.825	0.909074
SumClamp_MathUnrolling4	7076.553	185.220	0.957648
SumClamp_BitMath	5469.794	239.629	1.238958
SumClamp_BitMathUnrolling4	5593.104	234.346	1.211643

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6507.411	201.420
SumClamp_IfUnrolling4	6194.322	211.600	1.050545
SumClamp_MinMax	7117.671	184.150	0.914261
SumClamp_MinMaxUnrolling4	7240.861	181.017	0.898707
SumClamp_Math	7064.808	185.528	0.921102
SumClamp_MathUnrolling4	6637.843	197.462	0.980350
SumClamp_BitMath	4050.669	323.581	1.606503
SumClamp_BitMathUnrolling4	4016.211	326.357	1.620286

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	8.0.7
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/
RuntimeInformation.FrameworkDescription:	.NET 8.0.7
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Ubuntu 22.04.2 LTS
RuntimeInformation.RuntimeIdentifier:	linux-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844159	# 0x8177F801
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6472.839	202.495
SumClamp_IfUnrolling4	6689.152	195.947	0.967662
SumClamp_MinMax	7522.052	174.250	0.860515
SumClamp_MinMaxUnrolling4	7608.415	172.272	0.850747
SumClamp_Math	6620.821	197.969	0.977649
SumClamp_MathUnrolling4	6404.128	204.668	1.010729
SumClamp_BitMath	3738.606	350.591	1.731351
SumClamp_BitMathUnrolling4	3755.713	348.994	1.723464

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6257.078	209.478
SumClamp_IfUnrolling4	6222.490	210.642	1.005558
SumClamp_MinMax	6846.630	191.440	0.913892
SumClamp_MinMaxUnrolling4	7060.640	185.638	0.886191
SumClamp_Math	6078.890	215.618	1.029313
SumClamp_MathUnrolling4	6181.733	212.031	1.012188
SumClamp_BitMath	2666.086	491.627	2.346916
SumClamp_BitMathUnrolling4	2605.895	502.983	2.401124

```

## Wasm

### Wasm on AMD Ryzen 7 7840H
``

#### .NET 8.0

```
VectorTraits.Benchmarks.Wasm


IsRelease:	True
Environment.ProcessorCount:	1
Environment.Is64BitProcess:	False
Environment.OSVersion:	Other 1.0.0.0
Environment.Version:	8.0.7
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/
RuntimeInformation.FrameworkDescription:	.NET 8.0.7
RuntimeInformation.OSArchitecture:	Wasm
RuntimeInformation.OSDescription:	Browser
RuntimeInformation.RuntimeIdentifier:	browser-wasm
IntPtr.Size:	4
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	False
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844158	# 0x8177F802
VectorEnvironment.CpuModelName:	
VectorEnvironment.SupportedInstructionSets:	PackedSimd
Vector128s.Instance:	WVectorTraits128PackedSimd	// PackedSimd
Vectors.Instance:	VectorTraits128PackedSimd	// PackedSimd
Vectors.BaseInstance:	VectorTraits128Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	33158.333	39.529
SumClamp_IfUnrolling4	23500.000	55.775	1.410993
SumClamp_MinMax	35566.667	36.852	0.932287
SumClamp_MinMaxUnrolling4	29425.000	44.544	1.126876
SumClamp_Math	35266.667	37.166	0.940217
SumClamp_MathUnrolling4	28235.417	46.421	1.174353
SumClamp_BitMath	33041.667	39.669	1.003531
SumClamp_BitMathUnrolling4	45108.333	29.057	0.735082

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	31866.667	41.131
SumClamp_IfUnrolling4	21866.667	59.941	1.457317
SumClamp_MinMax	34595.833	37.887	0.921113
SumClamp_MinMaxUnrolling4	28131.250	46.593	1.132785
SumClamp_Math	34920.833	37.534	0.912540
SumClamp_MathUnrolling4	26727.083	49.041	1.192299
SumClamp_BitMath	29733.333	44.083	1.071749
SumClamp_BitMathUnrolling4	36708.333	35.706	0.868104

```

