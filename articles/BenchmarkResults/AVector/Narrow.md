# Benchmark - Narrow
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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.6
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.6
SumNarrowScalar	423.249	619.362
SumNarrowBcl	97.447	2690.125	4.343384
SumNarrowVectorBase	86.135	3043.400	4.913769
SumNarrowVectorTraits	77.838	3367.796	5.437528

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	298.990	876.766
SumNarrowBcl	21.816	12015.939	13.704847
SumNarrowVectorBase	19.608	13369.100	15.248202
SumNarrowVectorTraits	21.413	12242.273	13.962993

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	213.896	1225.570
SumNarrowBcl	105.680	2480.547	2.023995
SumNarrowVectorBase	103.240	2539.179	2.071835
SumNarrowVectorTraits	83.473	3140.458	2.562447

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.6
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.6
SumNarrowScalar	310.321	844.751
SumNarrowBcl	49.867	5256.909	6.223027
SumNarrowVectorBase	49.963	5246.737	6.210987
SumNarrowVectorTraits	49.860	5257.627	6.223878

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	155.280	1688.206
SumNarrowBcl	13.310	19695.645	11.666610
SumNarrowVectorBase	13.326	19671.686	11.652417
SumNarrowVectorTraits	13.397	19567.930	11.590958

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	163.935	1599.069
SumNarrowBcl	70.158	3736.462	2.336648
SumNarrowVectorBase	70.132	3737.855	2.337520
SumNarrowVectorTraits	69.968	3746.633	2.343009

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	310.379	844.593
SumNarrowBcl	42.296	6197.911	7.338342
SumNarrowVectorBase	42.791	6126.076	7.253290
SumNarrowVectorTraits	42.563	6158.921	7.292179
SumNarrowVector128Traits	77.822	3368.512	3.988327
SumNarrowVector256Traits	47.373	5533.611	6.551809

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	155.010	1691.146
SumNarrowBcl	14.472	18113.684	10.710896
SumNarrowVectorBase	14.623	17927.318	10.600694
SumNarrowVectorTraits	14.576	17985.114	10.634870
SumNarrowVector128Traits	17.027	15395.765	9.103749
SumNarrowVector256Traits	12.062	21732.424	12.850711

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	163.372	1604.579
SumNarrowBcl	69.281	3783.773	2.358110
SumNarrowVectorBase	69.405	3776.992	2.353884
SumNarrowVectorTraits	43.596	6013.089	3.747457
SumNarrowVector128Traits	61.704	4248.409	2.647679
SumNarrowVector256Traits	45.605	5748.141	3.582337

```

#### .NET 5

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	350.928	747.002
SumNarrowBcl	58.797	4458.440	5.968444
SumNarrowVectorBase	55.342	4736.787	6.341063
SumNarrowVectorTraits	52.519	4991.367	6.681866
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_AdvSimdB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	1353.031	193.746	0.259364
SumNarrowVector256Traits	262.298	999.412	1.337897

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	156.713	1672.760
SumNarrowBcl	14.596	17960.142	10.736834
SumNarrowVectorBase	14.113	18574.971	11.104388
SumNarrowVectorTraits	25.371	10332.393	6.176855
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	355.009	738.415	0.441435
SumNarrowVector256Traits	13.259	19770.730	11.819230

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	174.361	1503.454
SumNarrowBcl	76.228	3438.955	2.287370
SumNarrowVectorBase	77.557	3379.996	2.248154
SumNarrowVectorTraits	50.536	5187.229	3.450209
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	876.771	298.988	0.198867
SumNarrowVector256Traits	48.048	5455.908	3.628916

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	309.924	845.833
SumNarrowBcl	44.620	5875.040	6.945866
SumNarrowVectorBase	45.767	5727.740	6.771719
SumNarrowVectorTraits	46.161	5678.924	6.714005
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	78.051	3358.610	3.970774
SumNarrowVector256Traits	46.211	5672.803	6.706768

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	154.917	1692.158
SumNarrowBcl	14.523	18049.927	10.666807
SumNarrowVectorBase	14.601	17954.423	10.610368
SumNarrowVectorTraits	14.458	18131.247	10.714864
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	15.953	16432.043	9.710700
SumNarrowVector256Traits	13.262	19766.797	11.681411

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	163.322	1605.078
SumNarrowBcl	69.518	3770.889	2.349349
SumNarrowVectorBase	69.793	3756.023	2.340087
SumNarrowVectorTraits	43.440	6034.630	3.759711
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	63.361	4137.322	2.577645
SumNarrowVector256Traits	43.648	6005.803	3.741751

```

#### .NET 6

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	318.851	822.151
SumNarrowBcl	47.440	5525.849	6.721209
SumNarrowVectorBase	47.446	5525.085	6.720281
SumNarrowVectorTraits	46.716	5611.390	6.825255
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_AdvSimdB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	1365.727	191.945	0.233467
SumNarrowVector256Traits	260.201	1007.467	1.225404

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	161.469	1623.491
SumNarrowBcl	13.993	18733.836	11.539229
SumNarrowVectorBase	14.275	18364.141	11.311513
SumNarrowVectorTraits	24.497	10700.904	6.591292
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	356.554	735.215	0.452860
SumNarrowVector256Traits	13.047	20092.067	12.375841

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	166.604	1573.460
SumNarrowBcl	77.468	3383.896	2.150609
SumNarrowVectorBase	76.300	3435.694	2.183528
SumNarrowVectorTraits	57.900	4527.496	2.877414
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	874.868	299.638	0.190433
SumNarrowVector256Traits	54.086	4846.844	3.080374

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	309.843	846.054
SumNarrowBcl	44.599	5877.753	6.947257
SumNarrowVectorBase	46.162	5678.753	6.712047
SumNarrowVectorTraits	44.886	5840.209	6.902882
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	78.346	3345.991	3.954821
SumNarrowVector256Traits	47.767	5487.963	6.486541

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	155.054	1690.663
SumNarrowBcl	14.269	18371.895	10.866679
SumNarrowVectorBase	14.279	18358.078	10.858507
SumNarrowVectorTraits	14.807	17703.545	10.471361
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	15.068	17397.164	10.290142
SumNarrowVector256Traits	10.658	24595.464	14.547819

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	163.238	1605.903
SumNarrowBcl	69.069	3795.409	2.363411
SumNarrowVectorBase	69.065	3795.604	2.363532
SumNarrowVectorTraits	43.362	6045.465	3.764526
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	62.331	4205.700	2.618900
SumNarrowVector256Traits	44.176	5934.064	3.695156

```

#### .NET 7

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	319.566	820.312
SumNarrowBcl	49.158	5332.672	6.500788
SumNarrowVectorBase	52.182	5023.694	6.124129
SumNarrowVectorTraits	51.093	5130.718	6.254596
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_AdvSimdB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	80.711	3247.950	3.959410
SumNarrowVector256Traits	51.501	5090.033	6.204999

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	155.345	1687.493
SumNarrowBcl	17.718	14795.391	8.767673
SumNarrowVectorBase	11.908	22013.759	13.045241
SumNarrowVectorTraits	10.908	24032.546	14.241564
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	16.704	15693.384	9.299819
SumNarrowVector256Traits	10.979	23877.066	14.149428

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	105.295	2489.626
SumNarrowBcl	45.404	5773.532	2.319035
SumNarrowVectorBase	45.567	5752.873	2.310738
SumNarrowVectorTraits	50.340	5207.492	2.091676
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	64.828	4043.678	1.624211
SumNarrowVector256Traits	52.582	4985.410	2.002473

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	309.923	845.835
SumNarrowBcl	48.374	5419.130	6.406840
SumNarrowVectorBase	48.498	5405.289	6.390476
SumNarrowVectorTraits	46.764	5605.736	6.627457
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	77.857	3366.994	3.980674
SumNarrowVector256Traits	50.444	5196.724	6.143897

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	155.217	1688.882
SumNarrowBcl	17.721	14792.583	8.758801
SumNarrowVectorBase	10.563	24816.524	14.694053
SumNarrowVectorTraits	11.264	23272.226	13.779663
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	17.112	15319.518	9.070804
SumNarrowVector256Traits	11.258	23284.763	13.787086

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	104.401	2510.925
SumNarrowBcl	44.301	5917.367	2.356649
SumNarrowVectorBase	43.695	5999.386	2.389313
SumNarrowVectorTraits	47.188	5555.258	2.212435
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	62.317	4206.640	1.675335
SumNarrowVector256Traits	45.079	5815.240	2.315975

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
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	3.1.31
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.31
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	292.234	897.034
SumNarrowBcl	85.001	3084.003	3.438002
SumNarrowVectorBase	84.631	3097.487	3.453034
SumNarrowVectorTraits	84.811	3090.914	3.445707
SumNarrowVector128Traits	1906.359	137.510	0.153295
SumNarrowVector256Traits	2022.475	129.615	0.144493

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	351.271	746.273
SumNarrowBcl	19.054	13758.104	18.435758
SumNarrowVectorBase	18.948	13834.817	18.538552
SumNarrowVectorTraits	18.951	13832.597	18.535577
SumNarrowVector128Traits	484.517	541.042	0.724992
SumNarrowVector256Traits	520.906	503.247	0.674347

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	314.501	833.523
SumNarrowBcl	75.371	3478.045	4.172703
SumNarrowVectorBase	80.422	3259.603	3.910632
SumNarrowVectorTraits	75.245	3483.857	4.179675
SumNarrowVector128Traits	1384.846	189.295	0.227102
SumNarrowVector256Traits	1387.759	188.897	0.226625

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
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimdB64	Check `SumNarrowVector128_AdvSimdB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	290.354	902.841
SumNarrowBcl	81.007	3236.050	3.584296
SumNarrowVectorBase	75.113	3489.994	3.865568
SumNarrowVectorTraits	81.215	3227.759	3.575112
SumNarrowVector128_AdvSimd	562.115	466.353	0.516539
SumNarrowVector128_AdvSimdB64	82.825	3165.039	3.505643
SumNarrowVector128Traits	579.494	452.367	0.501048
SumNarrowVector256Traits	1304.321	200.981	0.222610

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	348.389	752.447
SumNarrowBcl	20.872	12559.431	16.691461
SumNarrowVectorBase	20.901	12542.386	16.668808
SumNarrowVectorTraits	20.892	12547.789	16.675989
SumNarrowVector128_AdvSimd	20.073	13059.461	17.355999
SumNarrowVector128Traits	19.838	13214.069	17.561473
SumNarrowVector256Traits	391.835	669.017	0.889122

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	312.581	838.644
SumNarrowBcl	79.242	3308.158	3.944651
SumNarrowVectorBase	83.340	3145.471	3.750663
SumNarrowVectorTraits	79.116	3313.423	3.950929
SumNarrowVector128_AdvSimd	79.170	3311.155	3.948224
SumNarrowVector128Traits	83.061	3156.056	3.763284
SumNarrowVector256Traits	880.877	297.594	0.354852

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
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	6.0.11
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/
RuntimeInformation.FrameworkDescription:	.NET 6.0.11
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimdB64	Check `SumNarrowVector128_AdvSimdB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	290.303	903.002
SumNarrowBcl	75.130	3489.223	3.864026
SumNarrowVectorBase	81.086	3232.929	3.580201
SumNarrowVectorTraits	75.071	3491.952	3.867048
SumNarrowVector128_AdvSimd	561.076	467.217	0.517404
SumNarrowVector128_AdvSimdB64	75.248	3483.750	3.857965
SumNarrowVector128Traits	792.276	330.874	0.366416
SumNarrowVector256Traits	1291.282	203.011	0.224818

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	347.281	754.846
SumNarrowBcl	19.662	13332.469	17.662492
SumNarrowVectorBase	19.665	13330.678	17.660121
SumNarrowVectorTraits	19.784	13250.364	17.553722
SumNarrowVector128_AdvSimd	19.803	13237.430	17.536588
SumNarrowVector128Traits	19.587	13383.242	17.729756
SumNarrowVector256Traits	392.386	668.077	0.885050

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	312.726	838.254
SumNarrowBcl	79.271	3306.919	3.945006
SumNarrowVectorBase	82.884	3162.797	3.773076
SumNarrowVectorTraits	82.803	3165.871	3.776743
SumNarrowVector128_AdvSimd	79.086	3314.682	3.954267
SumNarrowVector128Traits	82.753	3167.792	3.779034
SumNarrowVector256Traits	872.872	300.324	0.358273

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
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	7.0.1
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/
RuntimeInformation.FrameworkDescription:	.NET 7.0.1
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimdB64	Check `SumNarrowVector128_AdvSimdB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	210.605	1244.722
SumNarrowBcl	75.298	3481.401	2.796932
SumNarrowVectorBase	75.476	3473.223	2.790362
SumNarrowVectorTraits	74.895	3500.169	2.812009
SumNarrowVector128_AdvSimd	75.439	3474.922	2.791726
SumNarrowVector128_AdvSimdB64	75.376	3477.835	2.794066
SumNarrowVector128Traits	75.593	3467.840	2.786036
SumNarrowVector256Traits	958.777	273.415	0.219660

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	253.988	1032.113
SumNarrowBcl	16.991	15428.521	14.948478
SumNarrowVectorBase	16.972	15445.908	14.965325
SumNarrowVectorTraits	16.981	15437.910	14.957575
SumNarrowVector128_AdvSimd	16.988	15430.867	14.950752
SumNarrowVector128Traits	16.962	15454.345	14.973499
SumNarrowVector256Traits	687.066	381.541	0.369670

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	226.683	1156.432
SumNarrowBcl	64.490	4064.873	3.515011
SumNarrowVectorBase	64.229	4081.370	3.529276
SumNarrowVectorTraits	64.266	4079.025	3.527248
SumNarrowVector128_AdvSimd	64.668	4053.662	3.505317
SumNarrowVector128Traits	64.421	4069.220	3.518770
SumNarrowVector256Traits	933.311	280.875	0.242881

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

