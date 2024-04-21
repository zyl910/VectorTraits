# Benchmark - Multiply
([← Back](README.md))

See [Group](Multiply_Group.md)

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.6184711382
Check-SumBcl	Check `SumBcl` mismatch. 32712.6184711381!=32712.6184711382
Check-SumTraits	Check `SumTraits` mismatch. 32712.6184711381!=32712.6184711382
SumScalar	117.391	2233.076
SumBcl	29.161	8989.461	4.025595
SumTraits	29.394	8918.183	3.993676

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
SumScalar	168.610	1554.731
SumBcl	4.877	53747.563	34.570322
SumTraits	4.899	53507.146	34.415686

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
SumScalar	119.340	2196.615
SumBcl	10.715	24465.857	11.137980
SumTraits	10.872	24112.508	10.977120

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
SumScalar	168.637	1554.483
SumBcl	219.153	1196.166	0.769494
SumBcl_Widen	229.947	1140.019	0.733375
SumTraits	226.306	1158.363	0.745176

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.88
Check-SumBcl	Check `SumBcl` mismatch. 32717.99!=32717.88
Check-SumTraits	Check `SumTraits` mismatch. 32717.99!=32717.88
SumScalar	117.700	2227.228
SumBcl	14.595	17961.651	8.064578
SumTraits	14.576	17984.895	8.075014

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
SumScalar	119.938	2185.662
SumBcl	330.932	792.138	0.362425
SumTraits	10.647	24620.518	11.264561

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
SumScalar	121.594	2155.890
SumBcl	666.195	393.494	0.182520
SumTraits	660.932	396.628	0.183974

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
SumScalar	116.636	2247.540
SumBcl	29.018	9033.863	4.019445
SumTraits	29.121	9001.905	4.005226

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
SumScalar	168.655	1554.325
SumBcl	4.997	52460.825	33.751522
SumTraits	4.966	52782.833	33.958691

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
SumScalar	122.485	2140.207
SumBcl	10.767	24347.588	11.376280
SumTraits	10.613	24699.595	11.540753

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
SumScalar	169.229	1549.052
SumBcl	208.230	1258.913	0.812699
SumBcl_Widen	205.159	1277.760	0.824866
SumTraits	205.890	1273.225	0.821938

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.88
Check-SumBcl	Check `SumBcl` mismatch. 32717.99!=32717.88
Check-SumTraits	Check `SumTraits` mismatch. 32717.99!=32717.88
SumScalar	118.485	2212.464
SumBcl	14.690	17845.275	8.065793
SumTraits	14.721	17807.568	8.048750

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
SumScalar	120.530	2174.935
SumBcl	252.468	1038.326	0.477405
SumTraits	10.555	24836.345	11.419348

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
SumScalar	120.589	2173.871
SumBcl	447.879	585.301	0.269243
SumTraits	450.050	582.478	0.267945

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
SumScalar	117.726	2226.722
SumBcl	29.138	8996.712	4.040340
SumTraits	29.064	9019.621	4.050628
Sum128Traits	57.628	4548.862	2.042851
Sum256Traits	29.239	8965.430	4.026291

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	170.134	1540.805
SumBcl	5.061	51800.667	33.619229
SumTraits	4.961	52839.420	34.293392
Sum128Traits	6.782	38654.889	25.087468
Sum256Traits	4.985	52587.267	34.129741

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	122.070	2147.482
SumBcl	10.842	24178.823	11.259151
SumTraits	10.703	24492.633	11.405280
Sum128Traits	14.268	18372.816	8.555516
Sum256Traits	10.595	24742.543	11.521654

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	169.764	1544.172
SumBcl	211.963	1236.742	0.800910
SumBcl_Widen	264.219	992.148	0.642512
SumTraits	5.877	44607.361	28.887569
Sum128Traits	8.456	31002.674	20.077222
Sum256Traits	5.809	45126.346	29.223662

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	117.685	2227.515
SumBcl	14.997	17479.312	7.847001
SumTraits	15.004	17471.616	7.843546
Sum128Traits	29.090	9011.527	4.045552
Sum256Traits	14.703	17829.561	8.004238

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	122.902	2132.956
SumBcl	266.675	983.011	0.460868
SumTraits	10.766	24349.831	11.416004
Sum128Traits	14.881	17615.886	8.258908
Sum256Traits	10.743	24402.008	11.440466

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	120.540	2174.754
SumBcl	476.317	550.356	0.253066
SumTraits	36.994	7086.154	3.258371
Sum128Traits	69.774	3757.039	1.727570
Sum256Traits	37.126	7061.012	3.246810
Sum256Avx	37.152	7055.996	3.244504

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
SumScalar	117.047	2239.652
SumBcl	29.569	8865.586	3.958465
SumTraits	29.172	8986.022	4.012240
Sum128Traits	57.683	4544.570	2.029141
Sum256Traits	29.085	9012.898	4.024240

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	168.902	1552.052
SumBcl	4.960	52848.046	34.050430
SumTraits	4.932	53154.555	34.247916
Sum128Traits	6.779	38669.144	24.914847
Sum256Traits	5.055	51858.131	33.412619

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	122.192	2145.339
SumBcl	10.582	24771.714	11.546760
SumTraits	10.558	24829.388	11.573644
Sum128Traits	14.312	18315.938	8.537550
Sum256Traits	10.477	25019.720	11.662363

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	169.242	1548.930
SumBcl	134.799	1944.703	1.255514
SumBcl_Widen	139.053	1885.215	1.217108
SumTraits	5.837	44911.337	28.995063
Sum128Traits	7.572	34619.095	22.350323
Sum256Traits	5.830	44960.972	29.027108

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	117.660	2227.973
SumBcl	14.848	17654.777	7.924143
SumTraits	14.887	17608.997	7.903596
Sum128Traits	28.924	9063.130	4.067882
Sum256Traits	14.759	17762.227	7.972371

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	120.746	2171.037
SumBcl	209.116	1253.582	0.577412
SumTraits	10.364	25294.316	11.650799
Sum128Traits	13.033	20113.299	9.264374
Sum256Traits	10.585	24765.613	11.407273

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	123.600	2120.901
SumBcl	400.677	654.253	0.308479
SumTraits	33.172	7902.661	3.726088
Sum128Traits	63.843	4106.071	1.936004
Sum256Traits	34.030	7703.374	3.632124
Sum256Avx	32.982	7947.985	3.747458

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	116.943	2241.643
SumBcl	29.162	8989.267	4.010125
SumTraits	29.307	8944.904	3.990334
Sum128Traits	57.733	4540.605	2.025570
Sum256Traits	29.168	8987.287	4.009241

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	168.225	1558.295
SumBcl	4.936	53107.987	34.080840
SumTraits	4.906	53436.923	34.291927
Sum128Traits	6.749	38843.149	24.926705
Sum256Traits	4.944	53021.860	34.025570

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	118.994	2202.996
SumBcl	10.300	25451.560	11.553156
SumTraits	10.392	25225.108	11.450364
Sum128Traits	13.914	18840.216	8.552087
Sum256Traits	10.410	25182.968	11.431235

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	169.599	1545.671
SumBcl	135.213	1938.756	1.254313
SumBcl_Widen	8.221	31885.599	20.628972
SumTraits	5.753	45568.063	29.481093
Sum128Traits	7.503	34939.790	22.604937
Sum256Traits	5.754	45555.283	29.472825

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	116.218	2255.623
SumBcl	14.806	17705.423	7.849459
SumTraits	14.629	17919.713	7.944462
Sum128Traits	29.038	9027.599	4.002263
Sum256Traits	14.676	17861.625	7.918709

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	120.590	2173.847
SumBcl	10.361	25300.425	11.638547
SumTraits	10.474	25028.945	11.513662
Sum128Traits	13.011	20147.359	9.268065
Sum256Traits	10.259	25553.265	11.754857

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	120.197	2180.960
SumBcl	265.247	988.303	0.453151
SumTraits	32.195	8142.377	3.733392
Sum128Traits	61.900	4234.932	1.941774
Sum256Traits	32.253	8127.779	3.726698
Sum256Avx	33.108	7917.805	3.630422

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	117.894	2223.557
SumBcl	29.066	9018.803	4.056025
SumTraits	29.064	9019.581	4.056375
Sum128Traits	58.149	4508.141	2.027446
Sum256Traits	29.571	8865.010	3.986860

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	155.203	1689.037
SumBcl	4.877	53746.061	31.820543
SumTraits	4.963	52823.748	31.274484
Sum128Traits	5.072	51683.950	30.599664
Sum256Traits	4.953	52929.592	31.337150

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	92.421	2836.422
SumBcl	10.868	24120.639	8.503897
SumTraits	10.789	24296.791	8.566000
Sum128Traits	12.410	21123.228	7.447139
Sum256Traits	10.940	23961.430	8.447766

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	153.699	1705.568
SumBcl	150.226	1744.998	1.023118
SumBcl_Widen	5.697	46014.532	26.979005
SumTraits	5.729	45754.853	26.826751
Sum128Traits	7.451	35180.985	20.627134
Sum256Traits	5.707	45932.683	26.931015

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	116.001	2259.844
SumBcl	14.561	18002.791	7.966387
SumTraits	14.603	17951.014	7.943475
Sum128Traits	28.966	9050.032	4.004715
Sum256Traits	14.615	17936.843	7.937204

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	93.131	2814.793
SumBcl	11.755	22301.059	7.922807
SumTraits	11.487	22820.971	8.107515
Sum128Traits	15.252	17187.669	6.106194
Sum256Traits	11.608	22582.894	8.022934

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	92.408	2836.802
SumBcl	244.896	1070.431	0.377337
SumTraits	35.559	7372.091	2.598733
Sum128Traits	64.510	4063.604	1.432460
Sum256Traits	35.128	7462.605	2.630640
Sum256Avx	35.324	7421.171	2.616035

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 32718.014184847445!=32712.618471138187
Check-Sum512Traits	Check `Sum512Traits` mismatch. 32718.014184847445!=32712.618471138187
SumScalar	115.394	2271.729
SumBcl	29.175	8985.127	3.955193
SumTraits	29.008	9036.813	3.977945
Sum128Traits	58.155	4507.645	1.984235
Sum256Traits	29.050	9023.983	3.972297
Sum512Bcl	23.256	11272.314	4.961998
Sum512Traits	23.340	11231.736	4.944136

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 20371!=-11701
Check-Sum512Traits	Check `Sum512Traits` mismatch. 20371!=-11701
SumScalar	136.912	1914.695
SumBcl	4.907	53419.775	27.899884
SumTraits	4.927	53203.159	27.786750
Sum128Traits	7.316	35830.693	18.713523
Sum256Traits	4.879	53731.756	28.062824
Sum512Bcl	5.116	51241.525	26.762236
Sum512Traits	5.165	50753.082	26.507133

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -241446325!=-452441065
Check-Sum512Traits	Check `Sum512Traits` mismatch. -241446325!=-452441065
SumScalar	92.960	2819.954
SumBcl	12.079	21702.571	7.696071
SumTraits	12.191	21503.244	7.625387
Sum128Traits	15.401	17021.546	6.036107
Sum256Traits	12.179	21524.819	7.633038
Sum512Bcl	12.090	21682.867	7.689084
Sum512Traits	12.100	21664.802	7.682678

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. -30!=-41
Check-Sum512Traits	Check `Sum512Traits` mismatch. -30!=-41
SumScalar	137.474	1906.858
SumBcl	150.574	1740.959	0.912999
SumBcl_Widen	6.303	41592.869	21.812255
SumTraits	6.266	41832.983	21.938177
Sum128Traits	7.514	34887.998	18.296067
Sum256Traits	6.273	41790.600	21.915950
Sum512Bcl	564.588	464.311	0.243495
Sum512Traits	5.713	45887.293	24.064350

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 32720.705!=32717.883
Check-Sum512Traits	Check `Sum512Traits` mismatch. 32720.705!=32717.883
SumScalar	116.190	2256.169
SumBcl	14.823	17684.550	7.838308
SumTraits	14.589	17968.329	7.964087
Sum128Traits	28.905	9069.108	4.019693
Sum256Traits	14.624	17926.064	7.945354
Sum512Bcl	12.215	21461.316	9.512281
Sum512Traits	12.143	21587.995	9.568429

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 4053520971!=3842526231
Check-Sum512Traits	Check `Sum512Traits` mismatch. 4053520971!=3842526231
SumScalar	93.233	2811.711
SumBcl	11.846	22130.136	7.870702
SumTraits	11.808	22200.939	7.895883
Sum128Traits	13.209	19845.149	7.058034
Sum256Traits	11.704	22398.107	7.966007
Sum512Bcl	11.403	22988.093	8.175839
Sum512Traits	11.439	22917.330	8.150672

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
Check-Sum512Bcl	Check `Sum512Bcl` mismatch. 12814188601957013212!=12001033377966188484
Check-Sum512Traits	Check `Sum512Traits` mismatch. 12814188601957013212!=12001033377966188484
SumScalar	98.716	2655.543
SumBcl	25.488	10284.914	3.872998
SumTraits	25.513	10274.940	3.869242
Sum128Traits	23.632	11092.556	4.177132
Sum256Traits	25.315	10355.200	3.899465
Sum256Avx	25.040	10468.888	3.942277
Sum512Bcl	24.351	10765.148	4.053840
Sum512Traits	24.587	10662.058	4.015019

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	343.379	763.424
SumBcl	69.536	3769.904	4.938151
SumTraits	68.870	3806.349	4.985890
Sum128Traits	583.013	449.636	0.588973
Sum256Traits	1112.262	235.686	0.308722

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	402.700	650.967
SumBcl	19.570	13395.429	20.577746
SumTraits	19.261	13609.858	20.907147
Sum128Traits	447.631	585.626	0.899625
Sum256Traits	444.867	589.264	0.905213

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	380.807	688.391
SumBcl	39.926	6565.727	9.537786
SumTraits	41.187	6364.683	9.245737
Sum128Traits	771.069	339.975	0.493868
Sum256Traits	794.406	329.987	0.479360

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	337.187	777.445
SumBcl	9.666	27119.892	34.883378
SumBcl_Widen	23.602	11106.958	14.286496
SumTraits	9.636	27203.765	34.991260
Sum128Traits	273.036	960.109	1.234955
Sum256Traits	296.485	884.172	1.137279

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	316.218	828.997
SumBcl	39.107	6703.180	8.085890
SumTraits	39.178	6691.137	8.071363
Sum128Traits	748.753	350.108	0.422327
Sum256Traits	752.383	348.418	0.420289

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	363.269	721.626
SumBcl	34.523	7593.352	10.522564
SumTraits	34.733	7547.509	10.459036
Sum128Traits	717.438	365.389	0.506342
Sum256Traits	748.742	350.112	0.485172

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	387.943	675.728
SumBcl	654.336	400.626	0.592881
SumTraits	655.536	399.893	0.591796
Sum128Traits	580.645	451.470	0.668125
Sum256Traits	1150.043	227.943	0.337329
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	342.615	765.126
SumBcl	80.576	3253.392	4.252097
SumTraits	81.210	3227.962	4.218861
Sum128Traits	81.157	3230.078	4.221626
Sum256Traits	638.225	410.739	0.536825

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	402.890	650.659
SumBcl	20.457	12814.704	19.694959
SumTraits	20.342	12886.613	19.805476
Sum128Traits	19.165	13678.358	21.022312
Sum256Traits	307.732	851.857	1.309221

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	363.224	721.714
SumBcl	39.668	6608.494	9.156670
SumTraits	39.672	6607.748	9.155637
Sum128Traits	42.883	6112.944	8.470041
Sum256Traits	483.695	541.961	0.750937

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	337.312	777.156
SumBcl	9.836	26651.910	34.294159
SumBcl_Widen	21.914	11962.671	15.392883
SumTraits	9.763	26850.495	34.549686
Sum128Traits	9.682	27075.211	34.838839
Sum256Traits	228.343	1148.026	1.477215

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	329.124	796.491
SumBcl	39.597	6620.271	8.311799
SumTraits	39.607	6618.630	8.309739
Sum128Traits	42.255	6203.850	7.788979
Sum256Traits	491.531	533.322	0.669589

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	363.510	721.147
SumBcl	35.081	7472.558	10.362042
SumTraits	34.778	7537.725	10.452408
Sum128Traits	40.718	6438.068	8.927536
Sum256Traits	481.379	544.569	0.755142

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	389.842	672.437
SumBcl	368.118	712.119	1.059013
SumTraits	231.047	1134.591	1.687283
Sum128Traits	231.037	1134.643	1.687360
Sum256Traits	666.979	393.032	0.584489
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	343.784	762.525
SumBcl	81.871	3201.917	4.199096
SumTraits	69.556	3768.831	4.942565
Sum128Traits	81.833	3203.410	4.201054
Sum256Traits	639.721	409.779	0.537397

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	405.429	646.584
SumBcl	20.148	13010.650	20.122136
SumTraits	20.190	12983.912	20.080784
Sum128Traits	21.242	12340.626	19.085884
Sum256Traits	309.900	845.898	1.308257

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	366.356	715.545
SumBcl	43.420	6037.449	8.437558
SumTraits	42.585	6155.759	8.602901
Sum128Traits	39.915	6567.627	9.178502
Sum256Traits	482.255	543.579	0.759672

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	337.429	776.886
SumBcl	9.743	26906.960	34.634376
SumBcl_Widen	21.469	12210.182	15.716827
SumTraits	9.785	26791.171	34.485334
Sum128Traits	9.741	26910.153	34.638486
Sum256Traits	229.350	1142.988	1.471244

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	318.821	822.230
SumBcl	42.686	6141.246	7.469014
SumTraits	43.288	6055.760	7.365046
Sum128Traits	42.689	6140.715	7.468369
Sum256Traits	488.505	536.625	0.652646

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	364.753	718.689
SumBcl	41.470	6321.318	8.795618
SumTraits	41.279	6350.618	8.836387
Sum128Traits	35.520	7380.094	10.268822
Sum256Traits	477.366	549.147	0.764094

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	390.729	670.910
SumBcl	265.972	985.607	1.469061
SumTraits	236.309	1109.327	1.653468
Sum128Traits	236.272	1109.502	1.653728
Sum256Traits	672.241	389.955	0.581234
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	238.113	1100.924
SumBcl	71.766	3652.778	3.317920
SumTraits	71.743	3653.950	3.318984
Sum128Traits	72.351	3623.218	3.291070
Sum256Traits	663.701	394.973	0.358765

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	258.095	1015.690
SumBcl	13.643	19214.383	18.917570
SumTraits	13.615	19253.515	18.956097
Sum128Traits	13.670	19176.694	18.880463
Sum256Traits	442.969	591.788	0.582647

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	184.643	1419.733
SumBcl	29.172	8986.036	6.329383
SumTraits	29.197	8978.525	6.324093
Sum128Traits	29.276	8954.145	6.306920
Sum256Traits	557.478	470.232	0.331211

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	220.844	1187.012
SumBcl	6.891	38043.797	32.050047
SumBcl_Widen	21.741	12057.679	10.158008
SumTraits	6.909	37941.684	31.964023
Sum128Traits	6.890	38049.350	32.054726
Sum256Traits	391.240	670.033	0.564470

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	211.393	1240.081
SumBcl	30.095	8710.630	7.024243
SumTraits	30.013	8734.266	7.043303
Sum128Traits	30.000	8738.129	7.046418
Sum256Traits	499.219	525.109	0.423447

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	185.062	1416.517
SumBcl	37.429	7003.693	4.944304
SumTraits	37.564	6978.629	4.926611
Sum128Traits	37.487	6992.844	4.936646
Sum256Traits	551.402	475.413	0.335621

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	237.315	1104.627
SumBcl	235.538	1112.959	1.007543
SumTraits	235.727	1112.067	1.006736
Sum128Traits	235.481	1113.227	1.007785
Sum256Traits	674.342	388.740	0.351920
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

```

