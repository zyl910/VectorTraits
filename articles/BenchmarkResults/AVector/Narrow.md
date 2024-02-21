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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	315.964	829.665
SumNarrowBcl	75.127	3489.327	4.205707
SumNarrowVectorBase	74.988	3495.824	4.213539
SumNarrowVectorTraits	75.389	3477.226	4.191122
SumNarrowVector128Traits	1381.436	189.762	0.228721
SumNarrowVector256Traits	1460.513	179.488	0.216338

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	346.770	755.958
SumNarrowBcl	19.959	13134.205	17.374245
SumNarrowVectorBase	19.898	13174.125	17.427052
SumNarrowVectorTraits	19.933	13151.386	17.396973
SumNarrowVector128Traits	514.318	509.693	0.674234
SumNarrowVector256Traits	541.958	483.698	0.639848

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	312.488	838.892
SumNarrowBcl	79.922	3279.978	3.909893
SumNarrowVectorBase	82.537	3176.087	3.786050
SumNarrowVectorTraits	80.048	3274.845	3.903774
SumNarrowVector128Traits	1388.994	188.729	0.224975
SumNarrowVector256Traits	1496.679	175.150	0.208788

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_ArmB64	Check `SumNarrowVector128_ArmB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	291.365	899.709
SumNarrowBcl	75.549	3469.866	3.856656
SumNarrowVectorBase	81.425	3219.434	3.578308
SumNarrowVectorTraits	76.134	3443.193	3.827010
SumNarrowVector128_AdvSimd	558.248	469.584	0.521929
SumNarrowVector128_ArmB64	75.614	3466.870	3.853326
SumNarrowVector128Traits	81.592	3212.854	3.570994
SumNarrowVector256Traits	917.012	285.867	0.317733

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	349.267	750.554
SumNarrowBcl	20.492	12792.581	17.044183
SumNarrowVectorBase	20.543	12760.590	17.001559
SumNarrowVectorTraits	20.599	12725.949	16.955406
SumNarrowVector128_AdvSimd	20.594	12729.282	16.959846
SumNarrowVector128Traits	20.459	12813.310	17.071801
SumNarrowVector256Traits	405.946	645.761	0.860379

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	312.055	840.058
SumNarrowBcl	79.270	3306.988	3.936617
SumNarrowVectorBase	83.423	3142.330	3.740609
SumNarrowVectorTraits	79.241	3308.205	3.938065
SumNarrowVector128_AdvSimd	79.480	3298.259	3.926226
SumNarrowVector128Traits	83.190	3151.167	3.751128
SumNarrowVector256Traits	913.719	286.898	0.341521

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_ArmB64	Check `SumNarrowVector128_ArmB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	290.400	902.699
SumNarrowBcl	76.385	3431.879	3.801797
SumNarrowVectorBase	81.642	3210.881	3.556978
SumNarrowVectorTraits	76.126	3443.560	3.814737
SumNarrowVector128_AdvSimd	558.164	469.654	0.520277
SumNarrowVector128_ArmB64	82.486	3178.029	3.520585
SumNarrowVector128Traits	75.962	3450.974	3.822950
SumNarrowVector256Traits	915.898	286.215	0.317066

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	349.506	750.041
SumNarrowBcl	21.537	12171.826	16.228219
SumNarrowVectorBase	21.453	12219.703	16.292052
SumNarrowVectorTraits	21.514	12185.043	16.245841
SumNarrowVector128_AdvSimd	21.628	12120.847	16.160251
SumNarrowVector128Traits	21.600	12136.505	16.181127
SumNarrowVector256Traits	409.680	639.875	0.853120

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	314.242	834.212
SumNarrowBcl	84.146	3115.340	3.734473
SumNarrowVectorBase	80.467	3257.777	3.905217
SumNarrowVectorTraits	84.524	3101.402	3.717764
SumNarrowVector128_AdvSimd	84.241	3111.840	3.730277
SumNarrowVector128Traits	79.907	3280.604	3.932581
SumNarrowVector256Traits	919.918	284.964	0.341597

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_ArmB64	Check `SumNarrowVector128_ArmB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	210.669	1244.343
SumNarrowBcl	78.633	3333.759	2.679132
SumNarrowVectorBase	79.078	3314.994	2.664053
SumNarrowVectorTraits	78.736	3329.394	2.675624
SumNarrowVector128_AdvSimd	78.736	3329.413	2.675640
SumNarrowVector128_ArmB64	78.691	3331.304	2.677159
SumNarrowVector128Traits	78.640	3333.457	2.678890
SumNarrowVector256Traits	936.765	279.840	0.224889

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	253.811	1032.831
SumNarrowBcl	16.814	15590.571	15.094993
SumNarrowVectorBase	16.825	15580.813	15.085546
SumNarrowVectorTraits	16.864	15544.734	15.050613
SumNarrowVector128_AdvSimd	16.826	15579.282	15.084063
SumNarrowVector128Traits	16.818	15587.264	15.091791
SumNarrowVector256Traits	690.839	379.457	0.367396

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	224.523	1167.560
SumNarrowBcl	64.938	4036.806	3.457471
SumNarrowVectorBase	64.510	4063.599	3.480419
SumNarrowVectorTraits	65.333	4012.446	3.436607
SumNarrowVector128_AdvSimd	65.471	4003.961	3.429340
SumNarrowVector128Traits	64.797	4045.604	3.465006
SumNarrowVector256Traits	931.005	281.571	0.241162

```

