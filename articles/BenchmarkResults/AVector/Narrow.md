# Benchmark - Narrow
([← Back](README.md))

See [Group](Narrow_Group.md)

- `Narrow`: Narrows two Vector instances into one Vector  (将两个 Vector 实例缩窄为一个 Vector ).
  Mnemonic: `rt[i] := narrow(element_ref(i, lower, upper))`.

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.6
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.6
SumNarrowScalar	237.182	1105.244
SumNarrowBcl	31.254	8387.474	7.588801
SumNarrowVectorBase	31.454	8334.221	7.540619
SumNarrowVectorTraits	31.628	8288.466	7.499221

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	187.017	1401.712
SumNarrowBcl	8.584	30538.533	21.786591
SumNarrowVectorBase	8.294	31606.128	22.548227
SumNarrowVectorTraits	8.567	30600.670	21.830921

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	103.090	2542.873
SumNarrowBcl	37.379	7013.114	2.757949
SumNarrowVectorBase	36.619	7158.687	2.815197
SumNarrowVectorTraits	36.594	7163.507	2.817092

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.6
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.6
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.6
SumNarrowScalar	239.231	1095.776
SumNarrowBcl	33.288	7875.051	7.186733
SumNarrowVectorBase	33.190	7898.365	7.208009
SumNarrowVectorTraits	32.860	7977.546	7.280269

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	192.790	1359.736
SumNarrowBcl	9.130	28712.006	21.115865
SumNarrowVectorBase	8.951	29286.713	21.538525
SumNarrowVectorTraits	8.664	30258.043	22.252877

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	112.836	2323.234
SumNarrowBcl	39.242	6680.120	2.875353
SumNarrowVectorBase	37.542	6982.738	3.005611
SumNarrowVectorTraits	38.924	6734.692	2.898843

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	243.946	1074.597
SumNarrowBcl	33.883	7736.667	7.199597
SumNarrowVectorBase	33.892	7734.585	7.197660
SumNarrowVectorTraits	33.139	7910.472	7.361337
SumNarrowVector128Traits	58.528	4478.952	4.168028
SumNarrowVector256Traits	33.225	7889.978	7.342265

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	191.886	1366.147
SumNarrowBcl	8.433	31086.931	22.755195
SumNarrowVectorBase	9.015	29079.574	21.285838
SumNarrowVectorTraits	8.806	29769.661	21.790972
SumNarrowVector128Traits	12.341	21242.208	15.548996
SumNarrowVector256Traits	8.413	31160.717	22.809205

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	107.666	2434.787
SumNarrowBcl	37.462	6997.547	2.873987
SumNarrowVectorBase	38.444	6818.791	2.800570
SumNarrowVectorTraits	32.340	8105.888	3.329198
SumNarrowVector128Traits	36.567	7168.804	2.944325
SumNarrowVector256Traits	28.298	9263.556	3.804668

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	239.729	1093.501
SumNarrowBcl	33.706	7777.368	7.112358
SumNarrowVectorBase	33.968	7717.462	7.057574
SumNarrowVectorTraits	33.717	7774.895	7.110097
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	58.346	4492.956	4.108782
SumNarrowVector256Traits	33.205	7894.808	7.219756

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	192.604	1361.054
SumNarrowBcl	8.353	31383.954	23.058561
SumNarrowVectorBase	8.940	29323.164	21.544448
SumNarrowVectorTraits	8.904	29440.074	21.630345
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	11.290	23218.999	17.059569
SumNarrowVector256Traits	7.020	37343.374	27.437094

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	120.275	2179.535
SumNarrowBcl	38.474	6813.537	3.126142
SumNarrowVectorBase	37.896	6917.456	3.173821
SumNarrowVectorTraits	28.846	9087.762	4.169586
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	39.308	6669.004	3.059828
SumNarrowVector256Traits	28.717	9128.520	4.188287

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	239.512	1094.494
SumNarrowBcl	33.526	7819.026	7.143967
SumNarrowVectorBase	33.894	7734.129	7.066400
SumNarrowVectorTraits	33.328	7865.675	7.186588
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	58.443	4485.483	4.098227
SumNarrowVector256Traits	34.109	7685.428	7.021904

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	190.686	1374.745
SumNarrowBcl	8.756	29939.307	21.778086
SumNarrowVectorBase	8.615	30427.891	22.133486
SumNarrowVectorTraits	8.710	30098.540	21.893913
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	10.577	24784.093	18.028143
SumNarrowVector256Traits	6.858	38226.301	27.806110

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	108.347	2419.490
SumNarrowBcl	37.848	6926.224	2.862680
SumNarrowVectorBase	38.096	6881.128	2.844041
SumNarrowVectorTraits	29.502	8885.566	3.672496
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	40.335	6499.242	2.686204
SumNarrowVector256Traits	28.994	9041.270	3.736850

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Bcl	Check `SumNarrowVector128Bcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Bcl	Check `SumNarrowVector256Bcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	239.269	1095.603
SumNarrowBcl	31.140	8418.170	7.683597
SumNarrowVectorBase	31.209	8399.660	7.666702
SumNarrowVectorTraits	33.801	7755.512	7.078763
SumNarrowVector128Bcl	58.437	4485.894	4.094453
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	58.671	4468.028	4.078146
SumNarrowVector256Bcl	31.358	8359.645	7.630179
SumNarrowVector256Traits	33.630	7794.893	7.114707

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	162.841	1609.812
SumNarrowBcl	7.816	33541.513	20.835669
SumNarrowVectorBase	8.078	32450.510	20.157948
SumNarrowVectorTraits	7.995	32789.185	20.368329
SumNarrowVector128Bcl	12.316	21285.403	13.222290
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	12.942	20255.367	12.582441
SumNarrowVector256Bcl	8.366	31335.617	19.465387
SumNarrowVector256Traits	7.975	32870.968	20.419133

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	106.756	2455.555
SumNarrowBcl	28.854	9085.121	3.699824
SumNarrowVectorBase	29.073	9016.711	3.671965
SumNarrowVectorTraits	28.880	9076.916	3.696483
SumNarrowVector128Bcl	38.506	6807.863	2.772434
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	37.725	6948.854	2.829851
SumNarrowVector256Bcl	29.310	8943.942	3.642330
SumNarrowVector256Traits	29.499	8886.449	3.618917

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.7!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector128Bcl	Check `SumNarrowVector128Bcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Bcl	Check `SumNarrowVector256Bcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector512Bcl	Check `SumNarrowVector512Bcl` mismatch. 130888.66!=130889.58
Check-SumNarrowVector512Traits	Check `SumNarrowVector512Traits` mismatch. 130888.66!=130889.58
SumNarrowScalar	239.256	1095.661
SumNarrowBcl	31.658	8280.432	7.557473
SumNarrowVectorBase	31.245	8390.016	7.657490
SumNarrowVectorTraits	31.460	8332.526	7.605019
SumNarrowVector128Bcl	58.741	4462.684	4.073050
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	58.779	4459.841	4.070456
SumNarrowVector256Bcl	31.361	8358.960	7.629145
SumNarrowVector256Traits	31.571	8303.373	7.578412
SumNarrowVector512Bcl	25.774	10170.940	9.282923
SumNarrowVector512Traits	26.268	9979.693	9.108373

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	165.595	1583.045
SumNarrowBcl	6.607	39678.462	25.064641
SumNarrowVectorBase	6.492	40382.364	25.509292
SumNarrowVectorTraits	6.196	42305.987	26.724433
SumNarrowVector128Bcl	10.365	25290.580	15.975905
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	10.117	25910.967	16.367799
SumNarrowVector256Bcl	6.302	41593.748	26.274516
SumNarrowVector256Traits	6.726	38977.413	24.621793
SumNarrowVector512Bcl	5.899	44438.699	28.071654
SumNarrowVector512Traits	5.900	44433.205	28.068184

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	108.034	2426.488
SumNarrowBcl	29.573	8864.352	3.653161
SumNarrowVectorBase	28.993	9041.492	3.726164
SumNarrowVectorTraits	29.761	8808.182	3.630013
SumNarrowVector128Bcl	42.057	6233.035	2.568747
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	34.738	7546.344	3.109986
SumNarrowVector256Bcl	29.440	8904.215	3.669590
SumNarrowVector256Traits	29.377	8923.368	3.677483
SumNarrowVector512Bcl	27.901	9395.457	3.872039
SumNarrowVector512Traits	27.764	9442.022	3.891230

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
SumNarrowScalar	231.258	1133.557
SumNarrowBcl	57.802	4535.218	4.000872
SumNarrowVectorBase	57.805	4534.945	4.000632
SumNarrowVectorTraits	57.800	4535.335	4.000976
SumNarrowVector128_AdvSimd	91.923	2851.783	2.515782
SumNarrowVector128_ArmB64	57.793	4535.928	4.001499
SumNarrowVector128Traits	57.793	4535.889	4.001464
SumNarrowVector256Traits	396.553	661.057	0.583170

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	155.255	1688.479
SumNarrowBcl	9.653	27156.135	16.083194
SumNarrowVectorBase	9.651	27162.391	16.086900
SumNarrowVectorTraits	9.657	27146.613	16.077555
SumNarrowVector128_AdvSimd	9.656	27148.426	16.078629
SumNarrowVector128Traits	9.658	27142.585	16.075170
SumNarrowVector256Traits	149.032	1758.976	1.041752

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	146.313	1791.666
SumNarrowBcl	38.593	6792.541	3.791188
SumNarrowVectorBase	38.620	6787.702	3.788487
SumNarrowVectorTraits	38.610	6789.476	3.789477
SumNarrowVector128_AdvSimd	38.605	6790.493	3.790045
SumNarrowVector128Traits	38.608	6789.972	3.789754
SumNarrowVector256Traits	326.607	802.629	0.447979

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Bcl	Check `SumNarrowVector128Bcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_ArmB64	Check `SumNarrowVector128_ArmB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Bcl	Check `SumNarrowVector256Bcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	231.260	1133.548
SumNarrowBcl	57.776	4537.265	4.002712
SumNarrowVectorBase	57.771	4537.645	4.003048
SumNarrowVectorTraits	57.772	4537.569	4.002980
SumNarrowVector128Bcl	57.779	4536.988	4.002468
SumNarrowVector128_AdvSimd	57.773	4537.449	4.002875
SumNarrowVector128_ArmB64	57.783	4536.708	4.002221
SumNarrowVector128Traits	57.780	4536.908	4.002397
SumNarrowVector256Bcl	336.154	779.833	0.687958
SumNarrowVector256Traits	336.103	779.952	0.688063

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	155.125	1689.883
SumNarrowBcl	9.647	27174.645	16.080780
SumNarrowVectorBase	9.646	27177.717	16.082598
SumNarrowVectorTraits	9.646	27176.279	16.081747
SumNarrowVector128Bcl	9.652	27158.192	16.071044
SumNarrowVector128_AdvSimd	9.649	27167.089	16.076309
SumNarrowVector128Traits	9.651	27161.379	16.072930
SumNarrowVector256Bcl	216.891	1208.643	0.715223
SumNarrowVector256Traits	217.008	1207.993	0.714838

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	121.418	2159.016
SumNarrowBcl	38.543	6801.338	3.150202
SumNarrowVectorBase	38.539	6802.068	3.150540
SumNarrowVectorTraits	38.537	6802.444	3.150714
SumNarrowVector128Bcl	38.540	6801.899	3.150462
SumNarrowVector128_AdvSimd	38.543	6801.313	3.150190
SumNarrowVector128Traits	38.543	6801.407	3.150234
SumNarrowVector256Bcl	273.360	958.972	0.444171
SumNarrowVector256Traits	307.726	851.875	0.394566

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Bcl	Check `SumNarrowVector128Bcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_ArmB64	Check `SumNarrowVector128_ArmB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Bcl	Check `SumNarrowVector256Bcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector512Bcl	Check `SumNarrowVector512Bcl` mismatch. 130888.66!=130889.58
Check-SumNarrowVector512Traits	Check `SumNarrowVector512Traits` mismatch. 130888.66!=130889.58
SumNarrowScalar	224.878	1165.717
SumNarrowBcl	57.772	4537.531	3.892483
SumNarrowVectorBase	57.779	4537.034	3.892056
SumNarrowVectorTraits	57.772	4537.527	3.892479
SumNarrowVector128Bcl	57.773	4537.456	3.892418
SumNarrowVector128_AdvSimd	57.781	4536.882	3.891925
SumNarrowVector128_ArmB64	57.767	4537.974	3.892863
SumNarrowVector128Traits	57.774	4537.392	3.892363
SumNarrowVector256Bcl	28.928	9062.032	7.773787
SumNarrowVector256Traits	28.931	9060.945	7.772854
SumNarrowVector512Bcl	22.812	11491.609	9.857978
SumNarrowVector512Traits	22.816	11489.471	9.856145

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	155.139	1689.739
SumNarrowBcl	9.640	27193.896	16.093552
SumNarrowVectorBase	9.641	27190.007	16.091251
SumNarrowVectorTraits	9.641	27191.029	16.091856
SumNarrowVector128Bcl	9.646	27176.664	16.083354
SumNarrowVector128_AdvSimd	9.645	27179.367	16.084954
SumNarrowVector128Traits	9.644	27182.120	16.086583
SumNarrowVector256Bcl	5.871	44650.023	26.424220
SumNarrowVector256Traits	5.871	44649.159	26.423709
SumNarrowVector512Bcl	5.915	44320.057	26.228943
SumNarrowVector512Traits	5.911	44349.406	26.246313

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	121.404	2159.277
SumNarrowBcl	38.531	6803.445	3.150798
SumNarrowVectorBase	38.530	6803.681	3.150908
SumNarrowVectorTraits	38.535	6802.785	3.150493
SumNarrowVector128Bcl	38.534	6802.954	3.150571
SumNarrowVector128_AdvSimd	38.531	6803.422	3.150788
SumNarrowVector128Traits	38.531	6803.471	3.150811
SumNarrowVector256Bcl	22.898	11448.407	5.301964
SumNarrowVector256Traits	22.902	11446.283	5.300981
SumNarrowVector512Bcl	22.912	11441.243	5.298646
SumNarrowVector512Traits	22.913	11440.707	5.298398

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	323.665	809.924
SumNarrowBcl	82.301	3185.195	3.932709
SumNarrowVectorBase	84.327	3108.652	3.838203
SumNarrowVectorTraits	82.677	3170.695	3.914807
SumNarrowVector128Traits	1337.300	196.025	0.242029
SumNarrowVector256Traits	1391.848	188.342	0.232543

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	356.435	735.462
SumNarrowBcl	18.874	13889.161	18.884951
SumNarrowVectorBase	18.707	14013.342	19.053800
SumNarrowVectorTraits	18.826	13924.538	18.933053
SumNarrowVector128Traits	490.596	534.338	0.726533
SumNarrowVector256Traits	515.448	508.575	0.691504

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	313.221	836.930
SumNarrowBcl	74.391	3523.881	4.210483
SumNarrowVectorBase	81.778	3205.560	3.830139
SumNarrowVectorTraits	75.757	3460.327	4.134545
SumNarrowVector128Traits	1269.893	206.430	0.246651
SumNarrowVector256Traits	1366.960	191.771	0.229137

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
SumNarrowScalar	316.076	829.370
SumNarrowBcl	80.348	3262.590	3.933816
SumNarrowVectorBase	75.840	3456.525	4.167650
SumNarrowVectorTraits	81.407	3220.184	3.882685
SumNarrowVector128_AdvSimd	561.016	467.266	0.563399
SumNarrowVector128_ArmB64	80.670	3249.574	3.918122
SumNarrowVector128Traits	74.708	3508.928	4.230834
SumNarrowVector256Traits	906.398	289.215	0.348716

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	347.668	754.007
SumNarrowBcl	20.505	12784.493	16.955396
SumNarrowVectorBase	20.424	12834.948	17.022313
SumNarrowVectorTraits	20.413	12842.043	17.031723
SumNarrowVector128_AdvSimd	20.410	12843.699	17.033918
SumNarrowVector128Traits	20.501	12787.111	16.958868
SumNarrowVector256Traits	409.289	640.487	0.849444

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	312.814	838.020
SumNarrowBcl	82.382	3182.059	3.797117
SumNarrowVectorBase	78.368	3345.044	3.991605
SumNarrowVectorTraits	82.472	3178.596	3.792985
SumNarrowVector128_AdvSimd	82.256	3186.948	3.802951
SumNarrowVector128Traits	78.346	3345.960	3.992698
SumNarrowVector256Traits	907.909	288.734	0.344543

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
SumNarrowScalar	290.476	902.464
SumNarrowBcl	74.843	3502.589	3.881138
SumNarrowVectorBase	80.902	3240.256	3.590454
SumNarrowVectorTraits	74.517	3517.930	3.898137
SumNarrowVector128_AdvSimd	561.934	466.503	0.516922
SumNarrowVector128_ArmB64	80.693	3248.644	3.599748
SumNarrowVector128Traits	75.044	3493.198	3.870732
SumNarrowVector256Traits	916.451	286.042	0.316957

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	347.738	753.855
SumNarrowBcl	19.378	13527.971	17.945050
SumNarrowVectorBase	19.295	13586.305	18.022432
SumNarrowVectorTraits	19.268	13605.273	18.047594
SumNarrowVector128_AdvSimd	20.439	12825.567	17.013302
SumNarrowVector128Traits	20.512	12779.936	16.952772
SumNarrowVector256Traits	406.214	645.335	0.856046

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	313.364	836.548
SumNarrowBcl	78.519	3338.604	3.990930
SumNarrowVectorBase	82.315	3184.654	3.806899
SumNarrowVectorTraits	78.483	3340.149	3.992777
SumNarrowVector128_AdvSimd	78.223	3351.243	4.006039
SumNarrowVector128Traits	82.527	3176.474	3.797121
SumNarrowVector256Traits	915.051	286.480	0.342455

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Bcl	Check `SumNarrowVector128Bcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_ArmB64	Check `SumNarrowVector128_ArmB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Bcl	Check `SumNarrowVector256Bcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
SumNarrowScalar	211.001	1242.381
SumNarrowBcl	77.758	3371.276	2.713559
SumNarrowVectorBase	77.470	3383.833	2.723666
SumNarrowVectorTraits	77.517	3381.780	2.722014
SumNarrowVector128Bcl	79.442	3299.834	2.656055
SumNarrowVector128_AdvSimd	78.548	3337.377	2.686274
SumNarrowVector128_ArmB64	77.935	3363.629	2.707404
SumNarrowVector128Traits	78.059	3358.300	2.703115
SumNarrowVector256Bcl	977.494	268.180	0.215859
SumNarrowVector256Traits	977.214	268.256	0.215921

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	254.212	1031.203
SumNarrowBcl	16.768	15633.603	15.160548
SumNarrowVectorBase	16.772	15629.979	15.157034
SumNarrowVectorTraits	16.787	15615.734	15.143220
SumNarrowVector128Bcl	16.802	15602.249	15.130143
SumNarrowVector128_AdvSimd	16.791	15612.417	15.140004
SumNarrowVector128Traits	16.778	15623.949	15.151186
SumNarrowVector256Bcl	685.577	382.370	0.370800
SumNarrowVector256Traits	684.356	383.052	0.371461

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	226.684	1156.431
SumNarrowBcl	63.217	4146.713	3.585786
SumNarrowVectorBase	63.685	4116.240	3.559435
SumNarrowVectorTraits	63.435	4132.506	3.573501
SumNarrowVector128Bcl	63.454	4131.263	3.572426
SumNarrowVector128_AdvSimd	63.613	4120.930	3.563491
SumNarrowVector128Traits	63.458	4130.996	3.572195
SumNarrowVector256Bcl	919.069	285.228	0.246645
SumNarrowVector256Traits	937.569	279.600	0.241778

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Bcl	Check `SumNarrowVector128Bcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_AdvSimd	Check `SumNarrowVector128_AdvSimd` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128_ArmB64	Check `SumNarrowVector128_ArmB64` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Bcl	Check `SumNarrowVector256Bcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector512Bcl	Check `SumNarrowVector512Bcl` mismatch. 130888.66!=130889.58
Check-SumNarrowVector512Traits	Check `SumNarrowVector512Traits` mismatch. 130888.66!=130889.58
SumNarrowScalar	210.716	1244.061
SumNarrowBcl	64.043	4093.266	3.290244
SumNarrowVectorBase	64.080	4090.859	3.288309
SumNarrowVectorTraits	64.228	4081.457	3.280752
SumNarrowVector128Bcl	64.440	4068.055	3.269979
SumNarrowVector128_AdvSimd	63.965	4098.248	3.294249
SumNarrowVector128_ArmB64	64.243	4080.506	3.279987
SumNarrowVector128Traits	64.228	4081.467	3.280760
SumNarrowVector256Bcl	60.512	4332.121	3.482240
SumNarrowVector256Traits	60.380	4341.566	3.489833
SumNarrowVector512Bcl	63.626	4120.107	3.311820
SumNarrowVector512Traits	63.784	4109.874	3.303594

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	254.272	1030.957
SumNarrowBcl	18.788	13952.787	13.533817
SumNarrowVectorBase	18.781	13958.096	13.538967
SumNarrowVectorTraits	18.803	13941.970	13.523325
SumNarrowVector128Bcl	18.651	14055.366	13.633316
SumNarrowVector128_AdvSimd	18.781	13957.690	13.538573
SumNarrowVector128Traits	18.622	14077.420	13.654708
SumNarrowVector256Bcl	18.212	14393.636	13.961428
SumNarrowVector256Traits	18.210	14395.875	13.963600
SumNarrowVector512Bcl	17.840	14694.235	14.253002
SumNarrowVector512Traits	17.854	14682.275	14.241401

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	226.942	1155.112
SumNarrowBcl	74.448	3521.172	3.048337
SumNarrowVectorBase	74.355	3525.582	3.052155
SumNarrowVectorTraits	74.376	3524.571	3.051279
SumNarrowVector128Bcl	74.679	3510.278	3.038906
SumNarrowVector128_AdvSimd	74.615	3513.308	3.041529
SumNarrowVector128Traits	74.221	3531.940	3.057659
SumNarrowVector256Bcl	71.384	3672.302	3.179173
SumNarrowVector256Traits	71.460	3668.420	3.175812
SumNarrowVector512Bcl	71.129	3685.497	3.190596
SumNarrowVector512Traits	71.239	3679.797	3.185661

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


[NarrowBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	130889.58
Check-SumNarrowBcl	Check `SumNarrowBcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorBase	Check `SumNarrowVectorBase` mismatch. 130888.75!=130889.58
Check-SumNarrowVectorTraits	Check `SumNarrowVectorTraits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Bcl	Check `SumNarrowVector128Bcl` mismatch. 130888.75!=130889.58
Check-SumNarrowVector128Traits	Check `SumNarrowVector128Traits` mismatch. 130888.75!=130889.58
Check-SumNarrowVector256Bcl	Check `SumNarrowVector256Bcl` mismatch. 130888.7!=130889.58
Check-SumNarrowVector256Traits	Check `SumNarrowVector256Traits` mismatch. 130888.7!=130889.58
Check-SumNarrowVector512Bcl	Check `SumNarrowVector512Bcl` mismatch. 130888.66!=130889.58
Check-SumNarrowVector512Traits	Check `SumNarrowVector512Traits` mismatch. 130888.66!=130889.58
SumNarrowScalar	5471.875	47.908
SumNarrowBcl	4934.896	53.120	1.108813
SumNarrowVectorBase	4863.542	53.900	1.125080
SumNarrowVectorTraits	1766.146	148.427	3.098201
SumNarrowVector128Bcl	7021.354	37.335	0.779319
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128_ArmB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
SumNarrowVector128Traits	1716.667	152.705	3.187500
SumNarrowVector256Bcl	8342.708	31.422	0.655887
SumNarrowVector256Traits	17754.167	14.765	0.308202
SumNarrowVector512Bcl	10590.625	24.752	0.516672
SumNarrowVector512Traits	24760.417	10.587	0.220993

[NarrowBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	-38
SumNarrowScalar	6264.583	41.845
SumNarrowBcl	2137.760	122.626	2.930442
SumNarrowVectorBase	1989.323	131.775	3.149103
SumNarrowVectorTraits	318.262	823.674	19.683748
SumNarrowVector128Bcl	2905.729	90.216	2.155942
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	323.340	810.738	19.374610
SumNarrowVector256Bcl	2978.125	88.023	2.103533
SumNarrowVector256Traits	3097.135	84.641	2.022702
SumNarrowVector512Bcl	4374.479	59.926	1.432075
SumNarrowVector512Traits	3785.417	69.251	1.654926

[NarrowBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrowScalar	1552412164
SumNarrowScalar	4840.104	54.161
SumNarrowBcl	3653.385	71.754	1.324827
SumNarrowVectorBase	3440.104	76.202	1.406964
SumNarrowVectorTraits	1382.161	189.662	3.501837
SumNarrowVector128Bcl	5843.229	44.863	0.828327
SumNarrowVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumNarrowVector128Traits	1399.740	187.281	3.457860
SumNarrowVector256Bcl	6267.188	41.828	0.772293
SumNarrowVector256Traits	16758.333	15.643	0.288818
SumNarrowVector512Bcl	8913.542	29.410	0.543006
SumNarrowVector512Traits	19502.083	13.442	0.248184

```

