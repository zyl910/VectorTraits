# Benchmark - Multiply
([← Back](README.md))

See [Group](Multiply_Group.md)

- `Multiply`: Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
  Mnemonic: `rt[i] := left[i] * right[i]`.

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.6184711382
Check-SumBcl	Check `SumBcl` mismatch. 32712.6184711381!=32712.6184711382
Check-SumTraits	Check `SumTraits` mismatch. 32712.6184711381!=32712.6184711382
SumScalar	125.768	2084.347
SumBcl	29.822	8790.229	4.217257
SumTraits	29.997	8738.996	4.192677

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
SumScalar	182.497	1436.428
SumBcl	5.325	49229.000	34.271821
SumTraits	5.255	49886.108	34.729281

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
SumScalar	127.744	2052.100
SumBcl	12.207	21475.554	10.465162
SumTraits	11.945	21945.765	10.694298

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
SumScalar	177.077	1480.396
SumBcl	238.388	1099.651	0.742809
SumBcl_Widen	258.386	1014.544	0.685320
SumTraits	248.521	1054.817	0.712524

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.88
Check-SumBcl	Check `SumBcl` mismatch. 32717.99!=32717.88
Check-SumTraits	Check `SumTraits` mismatch. 32717.99!=32717.88
SumScalar	129.625	2022.323
SumBcl	15.470	16945.074	8.379015
SumTraits	15.841	16548.498	8.182916

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
SumScalar	130.236	2012.833
SumBcl	365.766	716.699	0.356065
SumTraits	11.655	22492.114	11.174356

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
SumScalar	130.300	2011.850
SumBcl	683.031	383.795	0.190767
SumTraits	676.060	387.752	0.192734

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.6184711382
Check-SumBcl	Check `SumBcl` mismatch. 32712.6184711381!=32712.6184711382
Check-SumTraits	Check `SumTraits` mismatch. 32712.6184711381!=32712.6184711382
SumScalar	132.416	1979.706
SumBcl	30.724	8532.216	4.309839
SumTraits	30.558	8578.450	4.333193

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
SumScalar	185.365	1414.205
SumBcl	5.443	48159.841	34.054357
SumTraits	5.787	45298.164	32.030833

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
SumScalar	130.748	2004.955
SumBcl	12.348	21228.903	10.588219
SumTraits	12.974	20205.636	10.077850

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
SumScalar	184.463	1421.116
SumBcl	247.391	1059.634	0.745636
SumBcl_Widen	245.082	1069.619	0.752662
SumTraits	236.799	1107.030	0.778986

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.88
Check-SumBcl	Check `SumBcl` mismatch. 32717.99!=32717.88
Check-SumTraits	Check `SumTraits` mismatch. 32717.99!=32717.88
SumScalar	132.090	1984.592
SumBcl	16.256	16125.793	8.125497
SumTraits	15.794	16597.890	8.363378

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
SumScalar	138.901	1887.269
SumBcl	294.029	891.558	0.472406
SumTraits	12.536	20910.897	11.079978

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
SumScalar	135.501	1934.621
SumBcl	518.530	505.552	0.261319
SumTraits	514.461	509.550	0.263385

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	127.954	2048.738
SumBcl	30.814	8507.251	4.152434
SumTraits	30.213	8676.601	4.235095
Sum128Traits	58.366	4491.358	2.192255
Sum256Traits	30.930	8475.437	4.136906

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	187.385	1398.959
SumBcl	5.790	45276.910	32.364714
SumTraits	5.896	44464.317	31.783859
Sum128Traits	7.499	34956.137	24.987248
Sum256Traits	5.418	48385.997	34.587143

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	141.979	1846.355
SumBcl	12.113	21640.942	11.720900
SumTraits	12.576	20845.153	11.289895
Sum128Traits	17.788	14737.449	7.981916
Sum256Traits	11.841	22138.039	11.990131

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	183.367	1429.611
SumBcl	238.672	1098.342	0.768280
SumBcl_Widen	228.243	1148.530	0.803387
SumTraits	6.708	39081.266	27.336991
Sum128Traits	10.177	25758.408	18.017773
Sum256Traits	6.841	38318.001	26.803094

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	134.103	1954.791
SumBcl	15.343	17085.462	8.740300
SumTraits	15.879	16509.202	8.445506
Sum128Traits	30.104	8707.974	4.454682
Sum256Traits	15.479	16934.927	8.663292

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	130.643	2006.574
SumBcl	276.151	949.277	0.473084
SumTraits	12.240	21417.621	10.673726
Sum128Traits	16.666	15728.930	7.838699
Sum256Traits	12.190	21505.580	10.717562

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	137.216	1910.450
SumBcl	463.880	565.112	0.295800
SumTraits	47.871	5476.086	2.866385
Sum128Traits	83.497	3139.554	1.643358
Sum256Traits	44.702	5864.241	3.069560
Sum256Avx	44.672	5868.243	3.071655

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	126.971	2064.593
SumBcl	30.582	8571.916	4.151868
SumTraits	30.623	8560.468	4.146323
Sum128Traits	58.148	4508.237	2.183596
Sum256Traits	30.747	8525.957	4.129607

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	185.806	1410.849
SumBcl	5.423	48341.775	34.264317
SumTraits	5.408	48472.610	34.357052
Sum128Traits	8.708	30102.963	21.336772
Sum256Traits	5.729	45754.232	32.430284

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	136.628	1918.675
SumBcl	12.671	20688.998	10.782962
SumTraits	11.953	21930.934	11.430251
Sum128Traits	17.129	15304.433	7.976565
Sum256Traits	12.095	21674.579	11.296640

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	188.825	1388.293
SumBcl	156.046	1679.916	1.210059
SumBcl_Widen	304.482	860.952	0.620152
SumTraits	6.766	38746.961	27.909784
Sum128Traits	9.329	28100.060	20.240725
Sum256Traits	6.974	37590.236	27.076584

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	124.872	2099.302
SumBcl	15.039	17431.350	8.303401
SumTraits	15.832	16557.859	7.887315
Sum128Traits	30.015	8733.667	4.160271
Sum256Traits	15.707	16689.443	7.949995

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	136.871	1915.261
SumBcl	222.425	1178.573	0.615359
SumTraits	13.303	19705.406	10.288625
Sum128Traits	16.069	16313.589	8.517683
Sum256Traits	12.994	20173.943	10.533259

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	139.963	1872.947
SumBcl	424.633	617.343	0.329611
SumTraits	40.126	6533.029	3.488101
Sum128Traits	78.493	3339.697	1.783124
Sum256Traits	40.343	6497.854	3.469320
Sum256Avx	41.067	6383.361	3.408190

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	128.220	2044.493
SumBcl	30.646	8554.056	4.183950
SumTraits	30.143	8696.698	4.253719
Sum128Traits	58.447	4485.126	2.193760
Sum256Traits	30.420	8617.617	4.215039

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	192.217	1363.792
SumBcl	5.762	45491.933	33.356943
SumTraits	5.717	45853.115	33.621780
Sum128Traits	8.363	31344.399	22.983269
Sum256Traits	5.706	45939.242	33.684932

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	132.007	1985.841
SumBcl	12.794	20489.198	10.317644
SumTraits	13.083	20037.098	10.089982
Sum128Traits	18.996	13799.853	6.949124
Sum256Traits	12.318	21281.227	10.716482

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	188.443	1391.103
SumBcl	151.970	1724.975	1.240005
SumBcl_Widen	9.466	27694.023	19.907966
SumTraits	6.836	38349.649	27.567808
Sum128Traits	9.371	27972.529	20.108171
Sum256Traits	6.807	38508.549	27.682034

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	127.072	2062.948
SumBcl	16.091	16291.449	7.897167
SumTraits	15.493	16920.387	8.202041
Sum128Traits	29.979	8744.379	4.238777
Sum256Traits	15.293	17141.593	8.309269

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	132.785	1974.200
SumBcl	12.585	20830.128	10.551172
SumTraits	13.349	19637.329	9.946978
Sum128Traits	16.481	15905.376	8.056616
Sum256Traits	12.338	21247.541	10.762606

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	133.010	1970.863
SumBcl	260.998	1004.391	0.509620
SumTraits	40.545	6465.510	3.280547
Sum128Traits	75.675	3464.069	1.757641
Sum256Traits	38.193	6863.592	3.482531
Sum256Avx	41.440	6325.806	3.209663

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	129.823	2019.241
SumBcl	30.837	8500.819	4.209908
SumTraits	30.570	8575.102	4.246695
Sum128Bcl	58.201	4504.125	2.230603
Sum128Traits	58.354	4492.297	2.224745
Sum256Traits	30.035	8728.001	4.322416

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 19479!=-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	172.777	1517.240
SumBcl	5.795	45238.397	29.816241
SumTraits	5.307	49392.127	32.553929
Sum128Bcl	6.821	38432.904	25.330799
Sum128Traits	6.680	39242.141	25.864160
Sum256Traits	5.719	45836.078	30.210167

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 575072105!=-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	118.529	2211.639
SumBcl	11.629	22542.242	10.192552
SumTraits	12.456	21044.762	9.515462
Sum128Bcl	15.488	16925.466	7.652908
Sum128Traits	16.003	16380.811	7.406640
Sum256Traits	11.670	22462.552	10.156520

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -113!=-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	171.935	1524.669
SumBcl	163.466	1603.660	1.051808
SumBcl_Widen	6.458	40593.897	26.624723
SumTraits	6.463	40561.133	26.603234
Sum128Bcl	180.347	1453.550	0.953354
Sum128Traits	9.344	28055.212	18.400851
Sum256Traits	6.410	40899.280	26.825017

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32712.596!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	130.586	2007.439
SumBcl	16.053	16329.687	8.134586
SumTraits	15.406	17015.592	8.476267
Sum128Bcl	30.537	8584.507	4.276347
Sum128Traits	30.152	8694.114	4.330948
Sum256Traits	16.421	15963.759	7.952299

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 575072105!=3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	110.234	2378.078
SumBcl	13.523	19385.360	8.151691
SumTraits	12.456	21046.070	8.850032
Sum128Bcl	19.379	13526.887	5.688158
Sum128Traits	18.248	14365.805	6.040930
Sum256Traits	13.054	20081.333	8.444352

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 12862679336949715101!=12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	109.292	2398.560
SumBcl	251.874	1040.773	0.433916
SumTraits	42.147	6219.736	2.593112
Sum128Bcl	454.556	576.704	0.240438
Sum128Traits	77.247	3393.569	1.414836
Sum256Traits	42.055	6233.364	2.598794
Sum256Avx	42.685	6141.416	2.560459

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 32718.014184847445!=32712.618471138187
Check-Sum512Traits	Check `Sum512Traits` mismatch. 32718.014184847445!=32712.618471138187
SumScalar	124.016	2113.784
SumBcl	30.404	8622.142	4.079008
SumTraits	30.296	8652.830	4.093526
Sum128Bcl	58.535	4478.450	2.118689
Sum128Traits	58.293	4497.031	2.127479
Sum256Traits	30.485	8598.977	4.068049
Sum512Bcl	25.116	10437.396	4.937778
Sum512Traits	25.043	10467.655	4.952093

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 19479!=-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 20371!=-11701
Check-Sum512Traits	Check `Sum512Traits` mismatch. 20371!=-11701
SumScalar	162.209	1616.091
SumBcl	5.403	48521.566	30.024038
SumTraits	5.401	48535.343	30.032562
Sum128Bcl	8.389	31250.133	19.336869
Sum128Traits	8.334	31455.471	19.463928
Sum256Traits	5.448	48115.272	29.772632
Sum512Bcl	5.584	46942.778	29.047120
Sum512Traits	5.648	46411.700	28.718500

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 575072105!=-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -241446325!=-452441065
Check-Sum512Traits	Check `Sum512Traits` mismatch. -241446325!=-452441065
SumScalar	116.555	2249.109
SumBcl	13.997	18728.845	8.327228
SumTraits	13.511	19401.954	8.626506
Sum128Bcl	18.334	14298.194	6.357270
Sum128Traits	17.959	14596.494	6.489900
Sum256Traits	13.134	19959.909	8.874584
Sum512Bcl	13.504	19412.502	8.631196
Sum512Traits	13.112	19991.939	8.888826

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -113!=-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -30!=-41
Check-Sum512Traits	Check `Sum512Traits` mismatch. -30!=-41
SumScalar	157.484	1664.571
SumBcl	168.202	1558.507	0.936281
SumBcl_Widen	7.140	36716.434	22.057594
SumTraits	7.035	37260.247	22.384293
Sum128Bcl	224.788	1166.182	0.700590
Sum128_Wasm	Run fail! Requires hardware support PackedSimd!
Sum128_Wasm_SelfWiden	Run fail! Requires hardware support PackedSimd!
Sum128Traits	9.977	26274.548	15.784575
Sum256Traits	7.105	36896.208	22.165594
Sum512Bcl	584.052	448.837	0.269641
Sum512Traits	5.952	44039.380	26.456892

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32712.596!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 32720.705!=32717.883
Check-Sum512Traits	Check `Sum512Traits` mismatch. 32720.705!=32717.883
SumScalar	123.023	2130.849
SumBcl	15.658	16741.570	7.856759
SumTraits	16.255	16126.971	7.568330
Sum128Bcl	30.030	8729.349	4.096652
Sum128Traits	30.083	8714.080	4.089487
Sum256Traits	15.600	16803.748	7.885939
Sum512Bcl	13.461	19474.237	9.139190
Sum512Traits	13.237	19804.337	9.294105

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 575072105!=3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 4053520971!=3842526231
Check-Sum512Traits	Check `Sum512Traits` mismatch. 4053520971!=3842526231
SumScalar	115.384	2271.925
SumBcl	12.850	20400.035	8.979185
SumTraits	12.855	20392.149	8.975714
Sum128Bcl	16.415	15970.163	7.029353
Sum128Traits	16.193	16188.232	7.125337
Sum256Traits	12.775	20519.506	9.031771
Sum512Bcl	12.453	21051.391	9.265883
Sum512Traits	12.317	21283.139	9.367888

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 12862679336949715101!=12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 12814188601957013212!=12001033377966188484
Check-Sum512Traits	Check `Sum512Traits` mismatch. 12814188601957013212!=12001033377966188484
SumScalar	119.493	2193.795
SumBcl	26.769	9792.952	4.463933
SumTraits	27.101	9672.748	4.409140
Sum128Bcl	28.847	9087.381	4.142312
Sum128Traits	31.823	8237.567	3.754940
Sum256Traits	26.762	9795.437	4.465066
Sum256Avx	26.501	9891.858	4.509018
Sum512Bcl	26.357	9945.883	4.533644
Sum512Traits	26.724	9809.406	4.471433

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.6184711382
Check-SumBcl	Check `SumBcl` mismatch. 32712.6184711381!=32712.6184711382
Check-SumTraits	Check `SumTraits` mismatch. 32712.6184711381!=32712.6184711382
SumScalar	243.101	1078.333
SumBcl	47.690	5496.796	5.097496
SumTraits	43.863	5976.484	5.542338

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
SumScalar	227.569	1151.932
SumBcl	12.991	20179.640	17.518082
SumTraits	14.712	17818.666	15.468504

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
SumScalar	260.065	1007.995
SumBcl	35.373	7410.928	7.352146
SumTraits	25.496	10281.822	10.200268

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
SumScalar	233.301	1123.630
SumBcl	519.391	504.714	0.449182
SumBcl_Widen	403.983	648.898	0.577502
SumTraits	302.033	867.932	0.772436

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.88
Check-SumBcl	Check `SumBcl` mismatch. 32717.99!=32717.88
Check-SumTraits	Check `SumTraits` mismatch. 32717.99!=32717.88
SumScalar	202.633	1293.688
SumBcl	30.458	8606.660	6.652807
SumTraits	30.187	8683.924	6.712531

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
SumScalar	213.392	1228.460
SumBcl	590.433	443.986	0.361417
SumTraits	33.151	7907.669	6.437057

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
SumScalar	242.193	1082.378
SumBcl	1079.647	242.805	0.224326
SumTraits	1054.412	248.616	0.229695

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.6184711382
Check-SumBcl	Check `SumBcl` mismatch. 32712.6184711381!=32712.6184711382
Check-SumTraits	Check `SumTraits` mismatch. 32712.6184711381!=32712.6184711382
SumScalar	155.546	1685.320
SumBcl	41.116	6375.782	3.783129
SumTraits	41.101	6377.978	3.784432

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
SumScalar	154.549	1696.188
SumBcl	9.039	29000.696	17.097568
SumTraits	9.118	28750.917	16.950310

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
SumScalar	130.450	2009.544
SumBcl	21.008	12478.401	6.209569
SumTraits	19.147	13691.245	6.813111

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
SumScalar	154.549	1696.184
SumBcl	200.866	1305.068	0.769414
SumBcl_Widen	258.291	1014.916	0.598353
SumTraits	202.786	1292.714	0.762131

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.88
Check-SumBcl	Check `SumBcl` mismatch. 32717.99!=32717.88
Check-SumTraits	Check `SumTraits` mismatch. 32717.99!=32717.88
SumScalar	155.318	1687.790
SumBcl	19.581	13387.536	7.931993
SumTraits	19.578	13389.862	7.933371

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
SumScalar	129.100	2030.551
SumBcl	329.567	795.421	0.391726
SumTraits	20.032	13086.543	6.444822

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
SumScalar	138.677	1890.319
SumBcl	513.714	510.292	0.269950
SumTraits	504.386	519.729	0.274942

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	155.427	1686.605
SumBcl	39.139	6697.700	3.971114
SumTraits	40.738	6434.893	3.815294
Sum128Traits	77.740	3372.079	1.999330
Sum256Traits	39.367	6658.956	3.948142

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	154.540	1696.288
SumBcl	9.026	29043.061	17.121535
SumTraits	9.271	28275.053	16.668777
Sum128Traits	12.639	20740.527	12.227005
Sum256Traits	10.004	26204.716	15.448267

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	142.129	1844.415
SumBcl	18.986	13806.980	7.485832
SumTraits	19.676	13323.108	7.223487
Sum128Traits	32.740	8006.751	4.341079
Sum256Traits	20.105	13038.919	7.069406

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	154.374	1698.106
SumBcl	199.449	1314.342	0.774005
SumBcl_Widen	259.461	1010.340	0.594980
SumTraits	9.977	26274.061	15.472565
Sum128Traits	12.439	21075.164	12.410980
Sum256Traits	10.010	26188.394	15.422117

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	155.270	1688.311
SumBcl	34.291	7644.792	4.528071
SumTraits	33.292	7874.136	4.663913
Sum128Traits	50.514	5189.552	3.073813
Sum256Traits	26.823	9773.110	5.788690

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	145.559	1800.947
SumBcl	346.873	755.735	0.419632
SumTraits	22.788	11503.740	6.387604
Sum128Traits	31.057	8440.801	4.686867
Sum256Traits	19.676	13322.977	7.397760

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	139.156	1883.817
SumBcl	484.273	541.314	0.287350
SumTraits	70.264	3730.869	1.980484
Sum128Traits	101.788	2575.394	1.367115
Sum256Traits	69.271	3784.333	2.008865
Sum256Avx	69.289	3783.353	2.008345

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	155.250	1688.531
SumBcl	39.071	6709.435	3.973534
SumTraits	40.202	6520.616	3.861709
Sum128Traits	77.633	3376.718	1.999796
Sum256Traits	40.757	6431.824	3.809124

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	154.538	1696.311
SumBcl	9.079	28873.222	17.021185
SumTraits	9.218	28439.527	16.765516
Sum128Traits	12.593	20816.183	12.271443
Sum256Traits	9.955	26333.176	15.523791

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	142.072	1845.148
SumBcl	18.624	14075.634	7.628456
SumTraits	19.579	13388.833	7.256236
Sum128Traits	27.805	9427.857	5.109538
Sum256Traits	22.027	11900.870	6.449817

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	154.516	1696.548
SumBcl	145.632	1800.039	1.061001
SumBcl_Widen	189.139	1385.986	0.816945
SumTraits	10.467	25044.052	14.761774
Sum128Traits	12.390	21157.848	12.471119
Sum256Traits	10.459	25063.402	14.773179

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	155.058	1690.624
SumBcl	19.588	13382.921	7.915965
SumTraits	19.628	13355.481	7.899734
Sum128Traits	38.983	6724.612	3.977591
Sum256Traits	19.550	13409.237	7.931531

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	129.900	2018.039
SumBcl	235.818	1111.637	0.550850
SumTraits	18.405	14243.355	7.058019
Sum128Traits	26.563	9868.703	4.890245
Sum256Traits	18.484	14182.570	7.027898

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	139.301	1881.856
SumBcl	388.875	674.108	0.358215
SumTraits	64.924	4037.718	2.145604
Sum128Traits	96.740	2709.792	1.439957
Sum256Traits	64.405	4070.240	2.162885
Sum256Avx	64.439	4068.084	2.161740

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	155.458	1686.273
SumBcl	41.059	6384.581	3.786209
SumTraits	43.054	6088.732	3.610763
Sum128Traits	77.644	3376.243	2.002192
Sum256Traits	40.870	6414.044	3.803681

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	148.451	1765.857
SumBcl	9.568	27398.869	15.515902
SumTraits	10.241	25598.285	14.496236
Sum128Traits	13.530	19374.784	10.971885
Sum256Traits	9.134	28700.028	16.252744

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	142.330	1841.810
SumBcl	18.579	14109.580	7.660713
SumTraits	20.268	12934.094	7.022490
Sum128Traits	27.629	9488.132	5.151526
Sum256Traits	19.655	13337.571	7.241556

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	148.451	1765.863
SumBcl	156.861	1671.186	0.946385
SumBcl_Widen	14.202	18458.271	10.452833
SumTraits	10.494	24981.260	14.146771
Sum128Traits	12.432	21086.235	11.941037
Sum256Traits	10.457	25069.936	14.196988

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	155.393	1686.976
SumBcl	19.539	13416.503	7.952991
SumTraits	19.527	13424.687	7.957843
Sum128Traits	38.884	6741.740	3.996347
Sum256Traits	19.534	13419.859	7.954981

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	129.938	2017.455
SumBcl	18.382	14261.002	7.068806
SumTraits	18.372	14269.037	7.072789
Sum128Traits	26.728	9807.838	4.861489
Sum256Traits	19.643	13345.427	6.614980

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	139.435	1880.042
SumBcl	571.239	458.904	0.244093
SumTraits	64.950	4036.108	2.146818
Sum128Traits	96.855	2706.554	1.439624
Sum256Traits	64.742	4049.053	2.153703
Sum256Avx	64.597	4058.145	2.158539

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	155.164	1689.467
SumBcl	39.220	6683.997	3.956276
SumTraits	39.484	6639.184	3.929752
Sum128Traits	77.766	3370.933	1.995265
Sum256Traits	39.377	6657.328	3.940491

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	146.100	1794.280
SumBcl	8.968	29230.877	16.291141
SumTraits	8.962	29251.442	16.302603
Sum128Traits	12.716	20615.516	11.489573
Sum256Traits	9.942	26367.850	14.695501

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	118.335	2215.279
SumBcl	20.586	12734.256	5.748374
SumTraits	21.436	12229.157	5.520368
Sum128Traits	27.904	9394.611	4.240824
Sum256Traits	21.532	12174.866	5.495860

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	140.853	1861.121
SumBcl	129.874	2018.456	1.084537
SumBcl_Widen	9.876	26543.644	14.262180
SumTraits	9.978	26272.164	14.116311
Sum128Traits	12.323	21273.251	11.430342
Sum256Traits	9.927	26405.971	14.188207

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	155.098	1690.186
SumBcl	19.476	13459.634	7.963403
SumTraits	19.488	13451.617	7.958660
Sum128Traits	38.930	6733.767	3.984039
Sum256Traits	19.844	13210.186	7.815817

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	118.872	2205.257
SumBcl	18.308	14318.887	6.493070
SumTraits	19.424	13495.639	6.119759
Sum128Traits	27.927	9386.747	4.256533
Sum256Traits	20.042	13079.623	5.931112

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	131.499	1993.501
SumBcl	234.271	1118.978	0.561313
SumTraits	70.573	3714.492	1.863301
Sum128Traits	103.952	2521.780	1.265001
Sum256Traits	69.841	3753.445	1.882841
Sum256Avx	70.121	3738.428	1.875308

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	125.319	2091.815
SumBcl	57.794	4535.848	2.168379
SumTraits	57.793	4535.921	2.168414
Sum128Traits	57.812	4534.457	2.167714
Sum256Traits	335.248	781.942	0.373810

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	140.172	1870.161
SumBcl	9.635	27208.103	14.548537
SumTraits	9.635	27206.685	14.547779
Sum128Traits	9.636	27204.478	14.546599
Sum256Traits	121.099	2164.705	1.157497

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	124.425	2106.851
SumBcl	19.272	13602.596	6.456363
SumTraits	19.270	13603.748	6.456909
Sum128Traits	19.277	13598.726	6.454525
Sum256Traits	175.520	1493.532	0.708893

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	116.392	2252.259
SumBcl	4.829	54281.171	24.100768
SumBcl_Widen	5.461	47999.189	21.311576
SumTraits	4.834	54229.689	24.077910
Sum128Traits	4.832	54256.502	24.089815
Sum256Traits	82.696	3169.954	1.407455

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	115.645	2266.805
SumBcl	28.894	9072.484	4.002323
SumTraits	28.888	9074.574	4.003245
Sum128Traits	28.887	9074.850	4.003367
Sum256Traits	208.099	1259.708	0.555720

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	124.477	2105.960
SumBcl	19.275	13600.350	6.458028
SumTraits	19.268	13605.415	6.460433
Sum128Traits	19.272	13602.668	6.459128
Sum256Traits	174.662	1500.863	0.712674

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	130.149	2014.187
SumBcl	91.633	2860.792	1.420321
SumTraits	73.803	3551.955	1.763468
Sum128Traits	73.651	3559.260	1.767095
Sum256Traits	265.811	986.204	0.489629
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	115.449	2270.645
SumBcl	57.687	4544.248	2.001303
SumTraits	57.691	4543.970	2.001181
Sum128Bcl	57.686	4544.303	2.001327
Sum128Traits	57.686	4544.330	2.001339
Sum256Traits	298.219	879.032	0.387129

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	86.574	3027.961
SumBcl	9.608	27282.960	9.010341
SumTraits	9.608	27284.847	9.010965
Sum128Bcl	9.609	27281.148	9.009743
Sum128Traits	9.607	27285.420	9.011154
Sum256Traits	136.990	1913.605	0.631978

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	67.445	3886.801
SumBcl	19.250	13618.045	3.503664
SumTraits	19.260	13610.844	3.501812
Sum128Bcl	19.249	13618.309	3.503732
Sum128Traits	19.256	13613.365	3.502460
Sum256Traits	163.756	1600.820	0.411860

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	89.819	2918.571
SumBcl	4.826	54324.372	18.613344
SumBcl_Widen	5.452	48080.493	16.473982
SumTraits	4.833	54235.529	18.582903
Sum128Bcl	4.826	54316.825	18.610758
Sum128Traits	4.827	54308.731	18.607985
Sum256Traits	124.392	2107.408	0.722068

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	115.594	2267.800
SumBcl	28.870	9080.029	4.003893
SumTraits	28.872	9079.558	4.003685
Sum128Bcl	28.864	9081.897	4.004717
Sum128Traits	28.867	9081.187	4.004404
Sum256Traits	173.629	1509.792	0.665752

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	67.438	3887.201
SumBcl	19.253	13615.947	3.502764
SumTraits	19.252	13616.378	3.502875
Sum128Bcl	19.258	13612.252	3.501813
Sum128Traits	19.255	13614.338	3.502350
Sum256Traits	162.819	1610.030	0.414188

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	77.048	3402.326
SumBcl	71.138	3685.022	1.083089
SumTraits	71.064	3688.830	1.084208
Sum128Bcl	71.298	3676.737	1.080654
Sum128Traits	71.367	3673.181	1.079609
Sum256Traits	244.547	1071.959	0.315067
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 32718.014184847445!=32672.199721873145
Check-Sum512Traits	Check `Sum512Traits` mismatch. 32718.014184847445!=32672.199721873145
SumScalar	115.588	2267.917
SumBcl	57.760	4538.488	2.001170
SumTraits	57.768	4537.900	2.000911
Sum128Bcl	57.761	4538.423	2.001141
Sum128Traits	57.778	4537.106	2.000561
Sum256Traits	28.927	9062.220	3.995834
Sum512Bcl	22.810	11492.508	5.067428
Sum512Traits	22.809	11493.102	5.067690

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 20371!=19479
Check-Sum512Traits	Check `Sum512Traits` mismatch. 20371!=19479
SumScalar	154.142	1700.665
SumBcl	9.620	27249.042	16.022584
SumTraits	9.618	27255.887	16.026609
Sum128Bcl	9.619	27252.921	16.024865
Sum128Traits	9.619	27251.396	16.023968
Sum256Traits	5.856	44763.658	26.321273
Sum512Bcl	5.884	44555.285	26.198748
Sum512Traits	5.883	44559.849	26.201432

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -241446325!=575072105
Check-Sum512Traits	Check `Sum512Traits` mismatch. -241446325!=575072105
SumScalar	65.055	4029.566
SumBcl	19.270	13604.064	3.376062
SumTraits	19.267	13605.639	3.376453
Sum128Bcl	19.263	13608.690	3.377210
Sum128Traits	19.270	13603.895	3.376020
Sum256Traits	11.735	22339.501	5.543897
Sum512Bcl	11.744	22320.873	5.539274
Sum512Traits	11.745	22319.746	5.538995

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -30!=-113
Check-Sum512Traits	Check `Sum512Traits` mismatch. -30!=-113
SumScalar	154.044	1701.743
SumBcl	4.819	54401.328	31.967998
SumBcl_Widen	5.452	48084.920	28.256270
SumTraits	4.826	54315.897	31.917796
Sum128Bcl	4.822	54366.940	31.947790
Sum128_Wasm	Run fail! Requires hardware support PackedSimd!
Sum128_Wasm_SelfWiden	Run fail! Requires hardware support PackedSimd!
Sum128Traits	4.822	54365.110	31.946715
Sum256Traits	2.941	89131.418	52.376534
Sum512Bcl	2.977	88067.109	51.751110
Sum512Traits	2.977	88062.441	51.748367

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 32720.705!=32712.652
Check-Sum512Traits	Check `Sum512Traits` mismatch. 32720.705!=32712.652
SumScalar	115.588	2267.908
SumBcl	28.863	9082.471	4.004780
SumTraits	28.862	9082.585	4.004830
Sum128Bcl	28.874	9078.989	4.003245
Sum128Traits	28.872	9079.647	4.003535
Sum256Traits	14.516	18059.308	7.962982
Sum512Bcl	11.535	22725.225	10.020348
Sum512Traits	11.537	22721.753	10.018817

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 4053520971!=575072105
Check-Sum512Traits	Check `Sum512Traits` mismatch. 4053520971!=575072105
SumScalar	65.041	4030.438
SumBcl	19.250	13617.616	3.378694
SumTraits	19.252	13616.517	3.378421
Sum128Bcl	19.252	13616.688	3.378464
Sum128Traits	19.252	13616.494	3.378416
Sum256Traits	11.431	22931.980	5.689699
Sum512Bcl	11.440	22915.646	5.685647
Sum512Traits	11.439	22915.859	5.685700

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 12814188601957013212!=12862679336949715101
Check-Sum512Traits	Check `Sum512Traits` mismatch. 12814188601957013212!=12862679336949715101
SumScalar	72.282	3626.665
SumBcl	70.633	3711.368	1.023356
SumTraits	344.682	760.538	0.209707
Sum128Bcl	344.555	760.818	0.209785
Sum128Traits	344.471	761.005	0.209836
Sum256Traits	294.662	889.642	0.245306
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!
Sum512Bcl	363.196	721.770	0.199018
Sum512Traits	372.850	703.081	0.193864

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	777.863	337.005
SumBcl	77.121	3399.130	10.086284
SumTraits	77.533	3381.067	10.032685
Sum128Traits	592.634	442.337	1.312552
Sum256Traits	1129.030	232.185	0.688966

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	408.284	642.063
SumBcl	17.015	15406.326	23.995028
SumTraits	17.022	15400.756	23.986352
Sum128Traits	431.829	607.055	0.945475
Sum256Traits	415.776	630.494	0.981981

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	373.736	701.416
SumBcl	41.072	6382.609	9.099609
SumTraits	41.175	6366.615	9.076807
Sum128Traits	691.340	379.183	0.540596
Sum256Traits	713.560	367.375	0.523762

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	346.067	757.496
SumBcl	8.594	30504.090	40.269642
SumBcl_Widen	21.876	11983.202	15.819494
SumTraits	8.646	30320.547	40.027340
Sum128Traits	268.963	974.648	1.286671
Sum256Traits	290.137	903.516	1.192767

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	330.936	792.128
SumBcl	34.766	7540.270	9.519000
SumTraits	34.786	7535.954	9.513552
Sum128Traits	726.863	360.651	0.455294
Sum256Traits	718.326	364.937	0.460705

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	368.580	711.227
SumBcl	42.876	6114.045	8.596469
SumTraits	42.768	6129.403	8.618064
Sum128Traits	704.829	371.926	0.522935
Sum256Traits	732.666	357.795	0.503066

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	395.635	662.591
SumBcl	675.863	387.865	0.585377
SumTraits	670.980	390.688	0.589637
Sum128Traits	564.455	464.420	0.700915
Sum256Traits	1152.113	227.533	0.343399
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	342.601	765.158
SumBcl	67.678	3873.427	5.062261
SumTraits	67.467	3885.530	5.078079
Sum128Traits	67.938	3858.567	5.042839
Sum256Traits	637.064	411.487	0.537781

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	403.243	650.090
SumBcl	18.813	13934.387	21.434548
SumTraits	18.832	13920.383	21.413005
Sum128Traits	18.936	13843.966	21.295457
Sum256Traits	306.792	854.469	1.314385

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	363.464	721.237
SumBcl	42.016	6239.205	8.650698
SumTraits	41.444	6325.248	8.769997
Sum128Traits	39.294	6671.417	9.249962
Sum256Traits	477.272	549.254	0.761545

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	337.715	776.229
SumBcl	9.720	26968.952	34.743569
SumBcl_Widen	21.764	12044.887	15.517190
SumTraits	9.810	26721.472	34.424745
Sum128Traits	9.584	27352.611	35.237829
Sum256Traits	228.136	1149.070	1.480324

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	316.682	827.784
SumBcl	41.139	6372.110	7.697794
SumTraits	41.201	6362.535	7.686227
Sum128Traits	38.537	6802.313	8.217498
Sum256Traits	480.980	545.020	0.658409

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	363.212	721.738
SumBcl	34.560	7585.147	10.509554
SumTraits	34.619	7572.250	10.491684
Sum128Traits	40.422	6485.223	8.985561
Sum256Traits	474.245	552.760	0.765874

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	390.110	671.974
SumBcl	319.152	821.376	1.222332
SumTraits	228.600	1146.735	1.706517
Sum128Traits	229.644	1141.525	1.698764
Sum256Traits	670.943	390.710	0.581436
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	342.590	765.182
SumBcl	67.502	3883.512	5.075279
SumTraits	79.740	3287.472	4.296328
Sum128Traits	67.714	3871.341	5.059373
Sum256Traits	640.323	409.393	0.535028

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	403.416	649.810
SumBcl	20.650	12694.374	19.535512
SumTraits	20.634	12704.512	19.551114
Sum128Traits	19.157	13683.905	21.058313
Sum256Traits	306.117	856.353	1.317852

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	362.852	722.455
SumBcl	39.722	6599.548	9.134897
SumTraits	40.023	6549.784	9.066015
Sum128Traits	42.868	6115.176	8.464444
Sum256Traits	484.280	541.307	0.749261

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	337.829	775.967
SumBcl	9.719	26972.889	34.760358
SumBcl_Widen	21.387	12257.411	15.796305
SumTraits	9.779	26806.408	34.545812
Sum128Traits	9.675	27094.429	34.916989
Sum256Traits	230.861	1135.508	1.463346

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	316.893	827.233
SumBcl	41.950	6248.930	7.554014
SumTraits	42.658	6145.281	7.428717
Sum128Traits	39.422	6649.767	8.038566
Sum256Traits	490.661	534.267	0.645849

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	363.487	721.192
SumBcl	40.851	6417.064	8.897853
SumTraits	41.125	6374.262	8.838504
Sum128Traits	34.896	7512.146	10.416285
Sum256Traits	481.969	543.902	0.754170

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	389.782	672.540
SumBcl	265.103	988.837	1.470303
SumTraits	230.663	1136.482	1.689836
Sum128Traits	229.519	1142.145	1.698255
Sum256Traits	671.698	390.271	0.580294
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	237.365	1104.393
SumBcl	70.616	3712.227	3.361327
SumTraits	70.712	3707.190	3.356766
Sum128Bcl	70.263	3730.914	3.378247
Sum128Traits	70.466	3720.143	3.368495
Sum256Traits	663.419	395.141	0.357790

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	257.588	1017.686
SumBcl	13.548	19348.719	19.012463
SumTraits	13.536	19366.619	19.030053
Sum128Bcl	13.575	19310.373	18.974783
Sum128Traits	13.557	19336.966	19.000915
Sum256Traits	443.947	590.485	0.580223

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	185.054	1416.581
SumBcl	28.420	9223.896	6.511381
SumTraits	28.221	9288.851	6.557234
Sum128Bcl	28.585	9170.571	6.473737
Sum128Traits	28.406	9228.576	6.514685
Sum256Traits	555.013	472.320	0.333423

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	221.324	1184.435
SumBcl	6.889	38055.098	32.129332
SumBcl_Widen	21.717	12070.742	10.191142
SumTraits	6.963	37645.745	31.783723
Sum128Bcl	6.885	38075.235	32.146334
Sum128Traits	6.887	38062.599	32.135665
Sum256Traits	391.894	668.915	0.564755

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	211.139	1241.571
SumBcl	28.923	9063.567	7.300081
SumTraits	29.097	9009.415	7.256465
Sum128Bcl	28.946	9056.348	7.294266
Sum128Traits	28.829	9093.006	7.323792
Sum256Traits	497.002	527.451	0.424825

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	184.568	1420.310
SumBcl	36.522	7177.777	5.053668
SumTraits	36.507	7180.708	5.055732
Sum128Bcl	36.448	7192.343	5.063924
Sum128Traits	36.603	7161.815	5.042430
Sum256Traits	554.449	472.801	0.332885

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	237.331	1104.550
SumBcl	235.095	1115.057	1.009512
SumTraits	235.291	1114.127	1.008670
Sum128Bcl	235.620	1112.570	1.007261
Sum128Traits	235.195	1114.582	1.009083
Sum256Traits	675.961	387.809	0.351102
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 32718.014184847445!=32672.199721873145
Check-Sum512Traits	Check `Sum512Traits` mismatch. 32718.014184847445!=32672.199721873145
SumScalar	237.151	1105.389
SumBcl	57.581	4552.630	4.118576
SumTraits	57.661	4546.313	4.112862
Sum128Bcl	57.810	4534.542	4.102213
Sum128Traits	58.028	4517.567	4.086856
Sum256Traits	54.666	4795.404	4.338204
Sum512Bcl	54.645	4797.190	4.339820
Sum512Traits	54.640	4797.669	4.340253

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 20371!=19479
Check-Sum512Traits	Check `Sum512Traits` mismatch. 20371!=19479
SumScalar	218.974	1197.147
SumBcl	17.894	14649.842	12.237293
SumTraits	17.882	14659.607	12.245449
Sum128Bcl	17.895	14649.238	12.236788
Sum128Traits	17.904	14641.378	12.230222
Sum256Traits	17.785	14739.844	12.312473
Sum512Bcl	17.667	14838.300	12.394715
Sum512Traits	17.659	14844.525	12.399915

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -241446325!=575072105
Check-Sum512Traits	Check `Sum512Traits` mismatch. -241446325!=575072105
SumScalar	179.809	1457.904
SumBcl	36.706	7141.657	4.898578
SumTraits	36.952	7094.265	4.866071
Sum128Bcl	36.852	7113.515	4.879276
Sum128Traits	36.687	7145.406	4.901150
Sum256Traits	36.108	7259.976	4.979735
Sum512Bcl	36.011	7279.466	4.993104
Sum512Traits	35.963	7289.348	4.999882

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -30!=-113
Check-Sum512Traits	Check `Sum512Traits` mismatch. -30!=-113
SumScalar	189.119	1386.130
SumBcl	9.089	28841.714	20.807369
SumBcl_Widen	22.132	11844.513	8.545024
SumTraits	9.137	28689.219	20.697355
Sum128Bcl	9.084	28858.647	20.819586
Sum128_Wasm	Run fail! Requires hardware support PackedSimd!
Sum128_Wasm_SelfWiden	Run fail! Requires hardware support PackedSimd!
Sum128Traits	9.074	28888.561	20.841166
Sum256Traits	9.002	29121.739	21.009389
Sum512Bcl	9.118	28750.208	20.741354
Sum512Traits	9.127	28721.428	20.720591

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 32720.705!=32712.652
Check-Sum512Traits	Check `Sum512Traits` mismatch. 32720.705!=32712.652
SumScalar	204.204	1283.737
SumBcl	36.702	7142.448	5.563794
SumTraits	36.706	7141.715	5.563224
Sum128Bcl	36.689	7145.038	5.565812
Sum128Traits	36.594	7163.629	5.580294
Sum256Traits	36.218	7237.944	5.638184
Sum512Bcl	36.089	7263.834	5.658351
Sum512Traits	36.145	7252.608	5.649607

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 4053520971!=575072105
Check-Sum512Traits	Check `Sum512Traits` mismatch. 4053520971!=575072105
SumScalar	180.874	1449.314
SumBcl	28.638	9153.660	6.315856
SumTraits	28.720	9127.705	6.297947
Sum128Bcl	28.548	9182.463	6.335729
Sum128Traits	28.629	9156.586	6.317874
Sum256Traits	28.575	9173.832	6.329774
Sum512Bcl	28.630	9156.175	6.317591
Sum512Traits	28.469	9208.081	6.353405

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 12814188601957013212!=12862679336949715101
Check-Sum512Traits	Check `Sum512Traits` mismatch. 12814188601957013212!=12862679336949715101
SumScalar	237.215	1105.089
SumBcl	281.929	929.823	0.841401
SumTraits	299.282	875.909	0.792614
Sum128Bcl	300.881	871.256	0.788403
Sum128Traits	305.714	857.482	0.775939
Sum256Traits	272.948	960.416	0.869085
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!
Sum512Bcl	880.010	297.887	0.269560
Sum512Traits	877.964	298.582	0.270188

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 32718.014184847445!=32672.199721873145
Check-Sum512Traits	Check `Sum512Traits` mismatch. 32718.014184847445!=32672.199721873145
SumScalar	2248.438	116.589
SumBcl	5979.167	43.843	0.376045
SumTraits	3414.583	76.772	0.658481
Sum128Bcl	10906.250	24.036	0.206160
Sum128Traits	1190.495	220.198	1.888658
Sum256Traits	23218.750	11.290	0.096837
Sum512Bcl	19768.750	13.261	0.113737
Sum512Traits	19072.917	13.744	0.117886

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 20371!=19479
Check-Sum512Traits	Check `Sum512Traits` mismatch. 20371!=19479
SumScalar	1560.677	167.968
SumBcl	258.464	1014.240	6.038287
SumTraits	282.096	929.271	5.532426
Sum128Bcl	297.786	880.309	5.240927
Sum128Traits	277.018	946.306	5.633843
Sum256Traits	488.021	537.157	3.197972
Sum512Bcl	709.570	369.440	2.199468
Sum512Traits	681.185	384.835	2.291121

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -241446325!=575072105
Check-Sum512Traits	Check `Sum512Traits` mismatch. -241446325!=575072105
SumScalar	1751.042	149.707
SumBcl	593.750	441.506	2.949123
SumTraits	595.508	440.202	2.940418
Sum128Bcl	587.826	445.955	2.978846
Sum128Traits	607.617	431.430	2.881817
Sum256Traits	884.961	296.221	1.978665
Sum512Bcl	1486.979	176.293	1.177583
Sum512Traits	1301.823	201.367	1.345069

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -30!=-113
Check-Sum512Traits	Check `Sum512Traits` mismatch. -30!=-113
SumScalar	1457.812	179.820
SumBcl	281.510	931.205	5.178538
SumBcl_Widen	3162.760	82.885	0.460930
SumTraits	361.784	724.587	4.029512
Sum128Bcl	289.453	905.653	5.036437
Sum128_Wasm	339.876	771.292	4.289244
Sum128_Wasm_SelfWiden	339.648	771.810	4.292122
Sum128Traits	349.056	751.008	4.176443
Sum256Traits	1529.427	171.400	0.953176
Sum512Bcl	464.453	564.414	3.138772
Sum512Traits	1666.406	157.311	0.874824

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 32720.705!=32712.652
Check-Sum512Traits	Check `Sum512Traits` mismatch. 32720.705!=32712.652
SumScalar	1917.057	136.743
SumBcl	581.771	450.597	3.295210
SumTraits	593.099	441.990	3.232272
Sum128Bcl	580.208	451.810	3.304084
Sum128Traits	560.352	467.821	3.421169
Sum256Traits	1053.906	248.736	1.819002
Sum512Bcl	1332.161	196.781	1.439058
Sum512Traits	1363.281	192.289	1.406208

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 4053520971!=575072105
Check-Sum512Traits	Check `Sum512Traits` mismatch. 4053520971!=575072105
SumScalar	1788.281	146.590
SumBcl	616.602	425.143	2.900222
SumTraits	611.003	429.039	2.926798
Sum128Bcl	608.268	430.968	2.939955
Sum128Traits	562.240	466.250	3.180639
Sum256Traits	5498.958	47.672	0.325204
Sum512Bcl	1349.089	194.312	1.325548
Sum512Traits	5921.875	44.267	0.301979

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 12814188601957013212!=12862679336949715101
Check-Sum512Traits	Check `Sum512Traits` mismatch. 12814188601957013212!=12862679336949715101
SumScalar	2264.063	115.785
SumBcl	4440.625	59.033	0.509852
SumTraits	1271.745	206.129	1.780281
Sum128Bcl	9115.625	28.758	0.248372
Sum128Traits	1180.469	222.068	1.917935
Sum256Traits	20245.833	12.948	0.111829
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!
Sum512Bcl	20316.667	12.903	0.111439
Sum512Traits	22668.750	11.564	0.099876

```

