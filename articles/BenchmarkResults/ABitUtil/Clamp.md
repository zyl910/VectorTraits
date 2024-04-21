﻿# Benchmark - Clamp
([← Back](README.md))

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9232.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks/bin/Release/Release/System.Numerics.Vectors.DLL
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
SumClamp_If	6636.150	197.512
SumClamp_IfUnrolling4	6037.909	217.082	1.099081
SumClamp_MinMax	7138.703	183.608	0.929602
SumClamp_MinMaxUnrolling4	6919.643	189.420	0.959031
SumClamp_BitMath	3346.086	391.717	1.983257
SumClamp_BitMathUnrolling4	3502.430	374.232	1.894727

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	5966.297	219.687
SumClamp_IfUnrolling4	5845.057	224.244	1.020742
SumClamp_MinMax	6613.447	198.190	0.902146
SumClamp_MinMaxUnrolling4	6391.809	205.062	0.933429
SumClamp_BitMath	2515.922	520.970	2.371416
SumClamp_BitMathUnrolling4	2532.692	517.520	2.355713

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
SumClamp_If	6160.754	212.753
SumClamp_IfUnrolling4	5861.818	223.603	1.050997
SumClamp_MinMax	6467.861	202.651	0.952518
SumClamp_MinMaxUnrolling4	6350.276	206.404	0.970155
SumClamp_Math	7666.108	170.976	0.803635
SumClamp_MathUnrolling4	7197.620	182.105	0.855943
SumClamp_BitMath	2791.498	469.540	2.206971
SumClamp_BitMathUnrolling4	3349.437	391.325	1.839340

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	5696.271	230.101
SumClamp_IfUnrolling4	5459.618	240.075	1.043346
SumClamp_MinMax	6200.901	211.376	0.918620
SumClamp_MinMaxUnrolling4	6142.313	213.392	0.927382
SumClamp_Math	6796.941	192.840	0.838064
SumClamp_MathUnrolling4	6946.560	188.686	0.820013
SumClamp_BitMath	2029.270	645.907	2.807055
SumClamp_BitMathUnrolling4	1980.364	661.858	2.876376

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
SumClamp_If	6051.456	216.596
SumClamp_IfUnrolling4	5854.498	223.883	1.033642
SumClamp_MinMax	6491.442	201.915	0.932221
SumClamp_MinMaxUnrolling4	6394.931	204.962	0.946289
SumClamp_Math	6623.409	197.892	0.913647
SumClamp_MathUnrolling4	6318.673	207.436	0.957710
SumClamp_BitMath	3327.622	393.891	1.818553
SumClamp_BitMathUnrolling4	2765.165	474.011	2.188461

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6012.268	218.008
SumClamp_IfUnrolling4	5584.480	234.708	1.076603
SumClamp_MinMax	6163.689	212.652	0.975433
SumClamp_MinMaxUnrolling4	6058.613	216.340	0.992351
SumClamp_Math	6305.263	207.877	0.953532
SumClamp_MathUnrolling4	6112.293	214.440	0.983635
SumClamp_BitMath	1992.352	657.876	3.017674
SumClamp_BitMathUnrolling4	1911.162	685.824	3.145871

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
SumClamp_If	6580.930	199.169
SumClamp_IfUnrolling4	6410.269	204.472	1.026623
SumClamp_MinMax	7208.198	181.837	0.912979
SumClamp_MinMaxUnrolling4	7182.915	182.477	0.916192
SumClamp_Math	7087.901	184.924	0.928474
SumClamp_MathUnrolling4	6746.019	194.295	0.975528
SumClamp_BitMath	6804.232	192.633	0.967182
SumClamp_BitMathUnrolling4	5596.932	234.185	1.175810

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6024.221	217.575
SumClamp_IfUnrolling4	5898.482	222.213	1.021317
SumClamp_MinMax	6554.455	199.974	0.919103
SumClamp_MinMaxUnrolling4	6696.734	195.725	0.899576
SumClamp_Math	6595.429	198.732	0.913393
SumClamp_MathUnrolling4	6349.335	206.434	0.948796
SumClamp_BitMath	5454.964	240.280	1.104356
SumClamp_BitMathUnrolling4	4853.721	270.044	1.241155

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.29
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.29\
RuntimeInformation.FrameworkDescription:	.NET 6.0.29
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.29/System.Private.CoreLib.dll
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
SumClamp_If	6806.397	192.572
SumClamp_IfUnrolling4	6424.867	204.007	1.059383
SumClamp_MinMax	7113.624	184.255	0.956811
SumClamp_MinMaxUnrolling4	7065.020	185.522	0.963394
SumClamp_Math	7165.360	182.925	0.949903
SumClamp_MathUnrolling4	6814.141	192.353	0.998864
SumClamp_BitMath	6397.697	204.874	1.063882
SumClamp_BitMathUnrolling4	5387.744	243.278	1.263311

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6917.582	189.477
SumClamp_IfUnrolling4	6139.759	213.481	1.126686
SumClamp_MinMax	7103.246	184.524	0.973862
SumClamp_MinMaxUnrolling4	7027.583	186.511	0.984347
SumClamp_Math	6629.297	197.716	1.043487
SumClamp_MathUnrolling4	6732.225	194.693	1.027533
SumClamp_BitMath	5418.312	241.906	1.276704
SumClamp_BitMathUnrolling4	4768.602	274.865	1.450652

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.18
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.18\
RuntimeInformation.FrameworkDescription:	.NET 7.0.18
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.18/System.Private.CoreLib.dll
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
SumClamp_If	5771.577	227.099
SumClamp_IfUnrolling4	5556.635	235.884	1.038682
SumClamp_MinMax	6445.581	203.352	0.895432
SumClamp_MinMaxUnrolling4	6603.622	198.485	0.874002
SumClamp_Math	6478.686	202.313	0.890856
SumClamp_MathUnrolling4	5938.468	220.717	0.971897
SumClamp_BitMath	3525.115	371.823	1.637273
SumClamp_BitMathUnrolling4	3484.233	376.186	1.656484

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	5607.683	233.736
SumClamp_IfUnrolling4	5264.353	248.980	1.065218
SumClamp_MinMax	6044.594	216.842	0.927719
SumClamp_MinMaxUnrolling4	5909.813	221.787	0.948877
SumClamp_Math	5933.810	220.890	0.945039
SumClamp_MathUnrolling4	5611.541	233.576	0.999313
SumClamp_BitMath	2351.279	557.450	2.384950
SumClamp_BitMathUnrolling4	2328.591	562.881	2.408187

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.4
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.4\
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.4/System.Private.CoreLib.dll
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
SumClamp_If	5821.118	225.166
SumClamp_IfUnrolling4	5585.104	234.681	1.042258
SumClamp_MinMax	6198.299	211.464	0.939148
SumClamp_MinMaxUnrolling4	6187.332	211.839	0.940812
SumClamp_Math	5837.308	224.542	0.997226
SumClamp_MathUnrolling4	5872.685	223.189	0.991219
SumClamp_BitMath	2033.664	644.511	2.862379
SumClamp_BitMathUnrolling4	2014.526	650.635	2.889572

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	5400.621	242.698
SumClamp_IfUnrolling4	5455.419	240.260	0.989955
SumClamp_MinMax	6107.529	214.607	0.884256
SumClamp_MinMaxUnrolling4	6013.231	217.973	0.898123
SumClamp_Math	6165.024	212.606	0.876010
SumClamp_MathUnrolling4	5712.176	229.461	0.945458
SumClamp_BitMath	1475.568	888.281	3.660028
SumClamp_BitMathUnrolling4	1425.584	919.427	3.788358

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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	8431.193	155.461
SumClamp_IfUnrolling4	8319.654	157.545	1.013407
SumClamp_MinMax	9246.616	141.751	0.911814
SumClamp_MinMaxUnrolling4	9357.920	140.065	0.900969
SumClamp_Math	8350.139	156.970	1.009707
SumClamp_MathUnrolling4	8565.720	153.019	0.984295
SumClamp_BitMath	5306.037	247.024	1.588981
SumClamp_BitMathUnrolling4	5339.037	245.497	1.579160

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	7997.246	163.896
SumClamp_IfUnrolling4	7885.756	166.214	1.014138
SumClamp_MinMax	8511.760	153.989	0.939553
SumClamp_MinMaxUnrolling4	8501.579	154.174	0.940678
SumClamp_Math	9088.432	144.218	0.879937
SumClamp_MathUnrolling4	8643.703	151.639	0.925211
SumClamp_BitMath	3958.763	331.093	2.020138
SumClamp_BitMathUnrolling4	4133.795	317.074	1.934602

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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	7738.254	169.382
SumClamp_IfUnrolling4	7532.430	174.010	1.027325
SumClamp_MinMax	11199.799	117.031	0.690928
SumClamp_MinMaxUnrolling4	10148.654	129.152	0.762491
SumClamp_Math	8202.351	159.798	0.943419
SumClamp_MathUnrolling4	8070.123	162.416	0.958877
SumClamp_BitMath	6971.293	188.017	1.110017
SumClamp_BitMathUnrolling4	7150.491	183.305	1.082199

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	7659.706	171.119
SumClamp_IfUnrolling4	7706.364	170.083	0.993945
SumClamp_MinMax	9017.235	145.357	0.849452
SumClamp_MinMaxUnrolling4	8936.581	146.669	0.857118
SumClamp_Math	8251.760	158.841	0.928251
SumClamp_MathUnrolling4	8211.092	159.628	0.932849
SumClamp_BitMath	5452.747	240.378	1.404742
SumClamp_BitMathUnrolling4	5708.417	229.612	1.341827

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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	7994.583	163.951
SumClamp_IfUnrolling4	7768.185	168.729	1.029144
SumClamp_MinMax	8773.997	149.387	0.911168
SumClamp_MinMaxUnrolling4	9780.949	134.007	0.817363
SumClamp_Math	8228.475	159.291	0.971575
SumClamp_MathUnrolling4	8112.601	161.566	0.985452
SumClamp_BitMath	6956.688	188.412	1.149194
SumClamp_BitMathUnrolling4	7169.469	182.820	1.115087

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	7999.279	163.855
SumClamp_IfUnrolling4	7663.561	171.033	1.043807
SumClamp_MinMax	8359.100	156.802	0.956955
SumClamp_MinMaxUnrolling4	10081.031	130.018	0.793498
SumClamp_Math	8286.800	158.170	0.965304
SumClamp_MathUnrolling4	8233.885	159.186	0.971507
SumClamp_BitMath	5445.736	240.687	1.468907
SumClamp_BitMathUnrolling4	5742.796	228.237	1.392924

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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-13446
SumClamp_If	6779.391	193.339
SumClamp_IfUnrolling4	6668.302	196.560	1.016659
SumClamp_MinMax	7661.888	171.070	0.884820
SumClamp_MinMaxUnrolling4	7467.287	175.528	0.907879
SumClamp_Math	7462.095	175.650	0.908510
SumClamp_MathUnrolling4	7077.597	185.193	0.957866
SumClamp_BitMath	5470.553	239.596	1.239252
SumClamp_BitMathUnrolling4	5583.683	234.741	1.214143

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-141291292
SumClamp_If	6513.662	201.226
SumClamp_IfUnrolling4	6191.666	211.691	1.052005
SumClamp_MinMax	7106.689	184.435	0.916554
SumClamp_MinMaxUnrolling4	7241.533	181.000	0.899487
SumClamp_Math	7069.565	185.403	0.921367
SumClamp_MathUnrolling4	6638.336	197.447	0.981219
SumClamp_BitMath	4045.410	324.002	1.610136
SumClamp_BitMathUnrolling4	4027.704	325.426	1.617215

```

