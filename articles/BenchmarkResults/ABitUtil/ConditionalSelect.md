# Benchmark - ConditionalSelect
([← Back](README.md))

See [Group](ConditionalSelect_Group.md)

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	7388.051	248.375
SumConditionalSelect_Min	6894.448	266.157	1.071594
SumConditionalSelect_Min_BitMath	2997.513	612.177	2.464727
SumConditionalSelect_BitMath	2885.999	635.831	2.559963

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	6405.219	286.486
SumConditionalSelect_Min	6432.617	285.266	0.995741
SumConditionalSelect_Min_BitMath	2795.365	656.447	2.291372
SumConditionalSelect_BitMath	2808.432	653.392	2.280710

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	6906.877	265.678
SumConditionalSelect_Min	6931.515	264.734	0.996446
SumConditionalSelect_Min_BitMath	3128.988	586.454	2.207384
SumConditionalSelect_BitMath	3110.612	589.919	2.220424

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	7420.747	247.281
SumConditionalSelect_Min	6588.706	278.508	1.126283
SumConditionalSelect_Min_BitMath	2860.539	641.490	2.594178
SumConditionalSelect_BitMath	2841.670	645.750	2.611404

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	7196.173	254.998
SumConditionalSelect_Min	6862.591	267.393	1.048609
SumConditionalSelect_Min_BitMath	3079.360	595.906	2.336905
SumConditionalSelect_BitMath	3118.348	588.455	2.307687

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	7278.855	252.101
SumConditionalSelect_Min	7263.424	252.637	1.002124
SumConditionalSelect_Min_BitMath	2848.671	644.163	2.555175
SumConditionalSelect_BitMath	2868.016	639.818	2.537940

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	6841.299	268.225
SumConditionalSelect_Min	6857.017	267.610	0.997708
SumConditionalSelect_Min_BitMath	8155.981	224.989	0.838808
SumConditionalSelect_BitMath	8168.538	224.643	0.837518

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	6966.626	263.400
SumConditionalSelect_Min	6524.646	281.243	1.067740
SumConditionalSelect_Min_BitMath	7071.694	259.486	0.985142
SumConditionalSelect_BitMath	7121.921	257.656	0.978195

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	7699.631	238.324
SumConditionalSelect_Min	6956.337	263.789	1.106851
SumConditionalSelect_Min_BitMath	8178.914	224.358	0.941400
SumConditionalSelect_BitMath	8222.378	223.172	0.936424

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	7263.048	252.650
SumConditionalSelect_Min	6522.149	281.350	1.113597
SumConditionalSelect_Min_BitMath	7136.377	257.134	1.017750
SumConditionalSelect_BitMath	7102.101	258.375	1.022662

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	7327.790	250.418
SumConditionalSelect_Min	6852.728	267.778	1.069325
SumConditionalSelect_Min_BitMath	3507.792	523.123	2.089004
SumConditionalSelect_BitMath	3479.431	527.387	2.106031

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	6755.046	271.650
SumConditionalSelect_Min	6571.536	279.236	1.027925
SumConditionalSelect_Min_BitMath	2499.991	734.006	2.702028
SumConditionalSelect_BitMath	2545.477	720.890	2.653745

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	6682.504	274.599
SumConditionalSelect_Min	7350.382	249.648	0.909137
SumConditionalSelect_Min_BitMath	2171.503	845.041	3.077363
SumConditionalSelect_BitMath	2203.464	832.783	3.032727

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	6763.129	271.325
SumConditionalSelect_Min	6413.222	286.129	1.054560
SumConditionalSelect_Min_BitMath	1843.684	995.294	3.668269
SumConditionalSelect_BitMath	1866.047	983.366	3.624307

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	6970.700	263.246
SumConditionalSelect_Min	7062.664	259.818	0.986979
SumConditionalSelect_Min_BitMath	2869.772	639.426	2.429008
SumConditionalSelect_BitMath	2862.507	641.049	2.435173

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	6773.803	270.898
SumConditionalSelect_Min	6818.652	269.116	0.993423
SumConditionalSelect_Min_BitMath	3235.141	567.211	2.093820
SumConditionalSelect_BitMath	3225.562	568.896	2.100038

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	7046.011	260.432
SumConditionalSelect_Min	7092.552	258.723	0.993438
SumConditionalSelect_Min_BitMath	2867.004	640.044	2.457622
SumConditionalSelect_BitMath	2846.703	644.608	2.475148

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	7028.195	261.092
SumConditionalSelect_Min	6926.142	264.939	1.014734
SumConditionalSelect_Min_BitMath	3226.777	568.681	2.178085
SumConditionalSelect_BitMath	3229.004	568.289	2.176583

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	6980.385	262.881
SumConditionalSelect_Min	6927.550	264.886	1.007627
SumConditionalSelect_Min_BitMath	2849.328	644.014	2.449836
SumConditionalSelect_BitMath	2761.744	664.438	2.527528

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	7290.724	251.691
SumConditionalSelect_Min	7268.554	252.458	1.003050
SumConditionalSelect_Min_BitMath	3229.822	568.145	2.257314
SumConditionalSelect_BitMath	3226.418	568.745	2.259696

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	6928.866	264.835
SumConditionalSelect_Min	7110.973	258.053	0.974391
SumConditionalSelect_Min_BitMath	6259.680	293.147	1.106904
SumConditionalSelect_BitMath	6260.436	293.112	1.106771

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	6991.220	262.473
SumConditionalSelect_Min	7091.269	258.770	0.985891
SumConditionalSelect_Min_BitMath	5699.210	321.976	1.226700
SumConditionalSelect_BitMath	5699.778	321.944	1.226578

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	7046.133	260.428
SumConditionalSelect_Min	6958.648	263.702	1.012572
SumConditionalSelect_Min_BitMath	6222.311	294.908	1.132398
SumConditionalSelect_BitMath	6245.505	293.813	1.128193

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	6963.049	263.535
SumConditionalSelect_Min	7005.194	261.950	0.993984
SumConditionalSelect_Min_BitMath	5704.782	321.661	1.220564
SumConditionalSelect_BitMath	5704.609	321.671	1.220601

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	6909.366	265.583
SumConditionalSelect_Min	6660.140	275.521	1.037420
SumConditionalSelect_Min_BitMath	2854.423	642.865	2.420582
SumConditionalSelect_BitMath	2852.039	643.402	2.422606

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	6648.897	275.987
SumConditionalSelect_Min	6568.416	279.368	1.012253
SumConditionalSelect_Min_BitMath	2227.480	823.804	2.984942
SumConditionalSelect_BitMath	2236.764	820.385	2.972552

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	5688.006	322.610
SumConditionalSelect_Min	5554.437	330.368	1.024047
SumConditionalSelect_Min_BitMath	2018.459	909.113	2.817994
SumConditionalSelect_BitMath	2019.264	908.751	2.816871

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	5629.995	325.934
SumConditionalSelect_Min	5647.921	324.900	0.996826
SumConditionalSelect_Min_BitMath	1438.890	1275.294	3.912734
SumConditionalSelect_BitMath	1438.499	1275.641	3.913799

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	4902.740	374.282
SumConditionalSelect_Min	4855.326	377.937	1.009765
SumConditionalSelect_Min_BitMath	1542.184	1189.876	3.179090
SumConditionalSelect_BitMath	1541.878	1190.112	3.179720

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	4837.049	379.365
SumConditionalSelect_Min	4755.248	385.891	1.017202
SumConditionalSelect_Min_BitMath	1150.846	1594.486	4.203037
SumConditionalSelect_BitMath	1149.942	1595.740	4.206343

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	4853.406	378.087
SumConditionalSelect_Min	4862.088	377.411	0.998214
SumConditionalSelect_Min_BitMath	1295.842	1416.073	3.745367
SumConditionalSelect_BitMath	1295.665	1416.267	3.745879

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	4789.187	383.156
SumConditionalSelect_Min	4827.247	380.136	0.992116
SumConditionalSelect_Min_BitMath	1113.337	1648.205	4.301651
SumConditionalSelect_BitMath	1113.339	1648.203	4.301644

```

### AWS Arm t4g.small
`Neoverse-N1`

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	9705.658	189.066
SumConditionalSelect_Min	9282.385	197.687	1.045600
SumConditionalSelect_Min_BitMath	5380.456	341.051	1.803873
SumConditionalSelect_BitMath	5383.666	340.847	1.802797

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	9364.666	195.950
SumConditionalSelect_Min	9056.659	202.614	1.034009
SumConditionalSelect_Min_BitMath	4254.717	431.288	2.201008
SumConditionalSelect_BitMath	4253.378	431.424	2.201701

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	9023.892	203.350
SumConditionalSelect_Min	9317.974	196.932	0.968439
SumConditionalSelect_Min_BitMath	6755.951	271.614	1.335695
SumConditionalSelect_BitMath	6752.508	271.752	1.336376

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	9002.946	203.823
SumConditionalSelect_Min	9118.456	201.241	0.987332
SumConditionalSelect_Min_BitMath	5725.489	320.498	1.572433
SumConditionalSelect_BitMath	5725.512	320.497	1.572426

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	9251.024	198.357
SumConditionalSelect_Min	9372.394	195.789	0.987050
SumConditionalSelect_Min_BitMath	6755.295	271.640	1.369448
SumConditionalSelect_BitMath	6755.256	271.642	1.369456

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	8903.930	206.090
SumConditionalSelect_Min	9108.936	201.451	0.977494
SumConditionalSelect_Min_BitMath	5733.320	320.060	1.553015
SumConditionalSelect_BitMath	5722.717	320.653	1.555892

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	7639.581	240.197
SumConditionalSelect_Min	7670.911	239.216	0.995916
SumConditionalSelect_Min_BitMath	5049.596	363.397	1.512909
SumConditionalSelect_BitMath	5051.184	363.283	1.512434

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	7241.569	253.399
SumConditionalSelect_Min	7302.881	251.272	0.991604
SumConditionalSelect_Min_BitMath	3804.982	482.265	1.903181
SumConditionalSelect_BitMath	3803.050	482.510	1.904148

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	7979.649	229.961
SumConditionalSelect_Min	7826.883	234.449	1.019518
SumConditionalSelect_Min_BitMath	3487.287	526.199	2.288212
SumConditionalSelect_BitMath	3488.759	525.977	2.287246

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	7095.139	258.629
SumConditionalSelect_Min	7442.737	246.550	0.953297
SumConditionalSelect_Min_BitMath	2679.390	684.860	2.648043
SumConditionalSelect_BitMath	2678.742	685.026	2.648683

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


[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	43275.000	42.403
SumConditionalSelect_Min	43362.500	42.318	0.997982
SumConditionalSelect_Min_BitMath	36387.500	50.430	1.189282
SumConditionalSelect_BitMath	37825.000	48.513	1.144085

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	42075.000	43.613
SumConditionalSelect_Min	43816.667	41.879	0.960251
SumConditionalSelect_Min_BitMath	36445.833	50.349	1.154453
SumConditionalSelect_BitMath	35291.667	51.996	1.192208

```

