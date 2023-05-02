# Benchmark - sample
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 4.5

```
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.4614.0
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	473.560	553.560
SumYShuffleG4X2VectorTraits	471.810	555.613	1.003709
SumYShuffleG4X2_ConstVectorTraits	472.534	554.762	1.002172

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	592.201	442.661
SumYShuffleG4X2VectorTraits	592.359	442.543	0.999733
SumYShuffleG4X2_ConstVectorTraits	587.910	445.892	1.007299

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	743.887	352.398
SumYShuffleG4X2VectorTraits	764.531	342.882	0.972997
SumYShuffleG4X2_ConstVectorTraits	701.220	373.840	1.060846

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	420.934	622.767
SumYShuffleG4X2VectorTraits	417.341	628.130	1.008610
SumYShuffleG4X2_ConstVectorTraits	409.798	639.691	1.027176

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
```

#### .NET Core 2.1

```
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:	.NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	467.336	560.933
SumYShuffleG4X2VectorTraits	467.876	560.286	0.998846
SumYShuffleG4X2_ConstVectorTraits	471.299	556.216	0.991592

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	584.333	448.621
SumYShuffleG4X2VectorTraits	580.798	451.351	1.006086
SumYShuffleG4X2_ConstVectorTraits	575.554	455.464	1.015254

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	711.610	368.382
SumYShuffleG4X2VectorTraits	715.570	366.343	0.994465
SumYShuffleG4X2_ConstVectorTraits	675.828	387.886	1.052945

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	420.762	623.021
SumYShuffleG4X2VectorTraits	419.748	624.528	1.002418
SumYShuffleG4X2_ConstVectorTraits	411.822	636.546	1.021709

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
```

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	441.765	593.401
SumYShuffleG4X2VectorTraits	25.583	10246.777	17.267879
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	11.622	22556.713	38.012595
SumYShuffleG4X2_ConstVectorTraits	11.846	22128.475	37.290928
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	11.945	21945.582	36.982717

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	520.933	503.220
SumYShuffleG4X2VectorTraits	30.849	8497.619	16.886479
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256_AvxByte	41.152	6370.113	12.658696
SumYShuffleG4X2Vector256_AvxUInt32	41.118	6375.478	12.669357
SumYShuffleG4X2Vector256Traits	30.741	8527.552	16.945961
SumYShuffleG4X2_ConstVectorTraits	24.337	10771.318	21.404777
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	30.252	8665.242	17.219580

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	686.227	382.008
SumYShuffleG4X2VectorTraits	52.072	5034.246	13.178388
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	56.064	4675.807	12.240086
SumYShuffleG4X2_ConstVectorTraits	46.121	5683.797	14.878749
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	47.570	5510.697	14.425616

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	400.728	654.170
SumYShuffleG4X2VectorTraits	7.201	36403.028	55.647648
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	6.905	37964.308	58.034305
SumYShuffleG4X2_ConstVectorTraits	6.683	39226.986	59.964504
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	9.840	26641.102	40.725038

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	438.964	597.188
SumYShuffleG4X2VectorTraits	29.265	8957.714	14.999833
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	18.978	13813.283	23.130560
SumYShuffleG4X2_ConstVectorTraits	13.086	20033.017	33.545602
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	12.407	21129.390	35.381497

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	522.642	501.575
SumYShuffleG4X2VectorTraits	32.514	8062.441	16.074256
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256_AvxByte	42.983	6098.787	12.159279
SumYShuffleG4X2Vector256_AvxUInt32	42.683	6141.614	12.244663
SumYShuffleG4X2Vector256Traits	32.828	7985.343	15.920544
SumYShuffleG4X2_ConstVectorTraits	24.237	10815.865	21.563814
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	22.529	11635.590	23.198117

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	470.593	557.050
SumYShuffleG4X2VectorTraits	60.248	4351.082	7.810931
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	61.412	4268.585	7.662835
SumYShuffleG4X2_ConstVectorTraits	43.897	5971.745	10.720296
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	44.881	5840.824	10.485270

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	404.183	648.578
SumYShuffleG4X2VectorTraits	6.877	38119.667	58.774234
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	7.770	33736.612	52.016287
SumYShuffleG4X2_ConstVectorTraits	8.897	29465.920	45.431586
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	8.976	29204.250	45.028133

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	444.907	589.211
SumYShuffleG4X2VectorTraits	33.084	7923.603	13.447820
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	15.027	17445.395	29.608061
SumYShuffleG4X2_ConstVectorTraits	13.218	19831.888	33.658381
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	12.674	20683.780	35.104199

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	521.282	502.883
SumYShuffleG4X2VectorTraits	24.673	10624.730	21.127619
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256_AvxByte	33.040	7934.037	15.777090
SumYShuffleG4X2Vector256_AvxUInt32	35.125	7463.072	14.840561
SumYShuffleG4X2Vector256Traits	25.083	10450.868	20.781889
SumYShuffleG4X2_ConstVectorTraits	20.723	12649.667	25.154273
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	22.373	11717.218	23.300067

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	472.921	554.308
SumYShuffleG4X2VectorTraits	49.917	5251.640	9.474229
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	72.612	3610.225	6.513032
SumYShuffleG4X2_ConstVectorTraits	71.303	3676.490	6.632576
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	62.189	4215.261	7.604547

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	434.938	602.715
SumYShuffleG4X2VectorTraits	4.624	56696.662	94.068713
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	4.547	57648.001	95.647135
SumYShuffleG4X2_ConstVectorTraits	4.809	54511.481	90.443153
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	5.011	52308.947	86.788801

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	432.511	606.098
SumYShuffleG4VectorTraits	14.928	17560.170	28.972472
SumYShuffleG4X2VectorTraits	11.849	22123.283	36.501139
SumYShuffleG4X2VectorTraits_Tuple	11.843	22134.051	36.518906
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	11.836	22148.130	36.542135
SumYShuffleG4X2_ConstVectorTraits	12.259	21384.393	35.282047
SumYShuffleG4X2_ConstVectorTraits_Tuple	11.332	23133.600	38.168059
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	11.341	23114.023	38.135759

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	588.409	445.513
SumYShuffleG4VectorTraits	27.553	9514.192	21.355581
SumYShuffleG4X2VectorTraits	21.888	11976.424	26.882313
SumYShuffleG4X2VectorTraits_Tuple	23.114	11341.176	25.456434
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256_AvxByte	27.535	9520.384	21.369479
SumYShuffleG4X2Vector256_AvxUInt32	24.223	10822.081	24.291272
SumYShuffleG4X2Vector256Traits	23.795	11016.831	24.728407
SumYShuffleG4X2_ConstVectorTraits	21.287	12315.002	27.642286
SumYShuffleG4X2_ConstVectorTraits_Tuple	21.341	12283.714	27.572056
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	21.268	12325.583	27.666036

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	653.764	400.976
SumYShuffleG4VectorTraits	61.401	4269.371	10.647440
SumYShuffleG4X2VectorTraits	48.123	5447.399	13.585339
SumYShuffleG4X2VectorTraits_Tuple	48.380	5418.421	13.513070
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	48.043	5456.487	13.608004
SumYShuffleG4X2_ConstVectorTraits	43.381	6042.889	15.070438
SumYShuffleG4X2_ConstVectorTraits_Tuple	42.958	6102.354	15.218740
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	43.588	6014.064	14.998553

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	317.898	824.617
SumYShuffleG4VectorTraits	5.206	50359.011	61.069589
SumYShuffleG4X2VectorTraits	4.376	59903.064	72.643513
SumYShuffleG4X2VectorTraits_Tuple	4.338	60432.065	73.285025
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	4.600	56989.590	69.110389
SumYShuffleG4X2_ConstVectorTraits	4.708	55680.518	67.522897
SumYShuffleG4X2_ConstVectorTraits_Tuple	4.755	55133.832	66.859940
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	4.698	55804.149	67.672824

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-21037
SumYShuffleG4X2VectorBase	741.393	353.583
SumYShuffleG4X2VectorTraits	740.347	354.083	1.001413
SumYShuffleG4X2Vector128Traits	1150.124	227.927	0.644620
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	759.560	345.126	0.976081
SumYShuffleG4X2_ConstVector128Traits	1169.781	224.097	0.633788
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	2018061718
SumYShuffleG4X2VectorBase	924.581	283.527
SumYShuffleG4X2VectorTraits	925.893	283.126	0.998584
SumYShuffleG4X2Vector128Traits	1653.976	158.493	0.559005
SumYShuffleG4X2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256_AvxUInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	906.535	289.171	1.019907
SumYShuffleG4X2_ConstVector128Traits	1648.712	158.999	0.560790
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	5878554485936559874
SumYShuffleG4X2VectorBase	1216.895	215.420
SumYShuffleG4X2VectorTraits	1215.325	215.699	1.001291
SumYShuffleG4X2Vector128Traits	1880.386	139.410	0.647152
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	1242.704	210.946	0.979231
SumYShuffleG4X2_ConstVector128Traits	1913.724	136.981	0.635878
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	91
SumYShuffleG4X2VectorBase	601.498	435.818
SumYShuffleG4X2VectorTraits	600.801	436.324	1.001161
SumYShuffleG4X2Vector128Traits	867.560	302.162	0.693322
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	622.845	420.882	0.965728
SumYShuffleG4X2_ConstVector128Traits	884.827	296.266	0.679792
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 5

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-21037
SumYShuffleG4X2VectorBase	742.872	352.879
SumYShuffleG4X2VectorTraits	302.054	867.870	2.459400
SumYShuffleG4X2Vector128_Arm	233.168	1124.273	3.186002
SumYShuffleG4X2Vector128Traits	189.281	1384.944	3.924699
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	270.505	969.093	2.746247
SumYShuffleG4X2_ConstVector128Traits	196.446	1334.436	3.781569
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	2018061718
SumYShuffleG4X2VectorBase	864.284	303.308
SumYShuffleG4X2VectorTraits	550.427	476.256	1.570207
SumYShuffleG4X2Vector128_Arm	465.049	563.691	1.858479
SumYShuffleG4X2Vector128Traits	392.324	668.182	2.202983
SumYShuffleG4X2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256_AvxUInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	544.662	481.296	1.586825
SumYShuffleG4X2_ConstVector128Traits	379.594	690.591	2.276866
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	5878554485936559874
SumYShuffleG4X2VectorBase	1167.622	224.511
SumYShuffleG4X2VectorTraits	1511.781	173.401	0.772349
SumYShuffleG4X2Vector128_Arm	1249.317	209.830	0.934608
SumYShuffleG4X2Vector128Traits	1226.792	213.683	0.951769
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	1511.668	173.414	0.772407
SumYShuffleG4X2_ConstVector128Traits	1224.248	214.127	0.953746
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	91
SumYShuffleG4X2VectorBase	599.795	437.056
SumYShuffleG4X2VectorTraits	139.100	1884.578	4.311983
SumYShuffleG4X2Vector128_Arm	117.849	2224.404	5.089519
SumYShuffleG4X2Vector128Traits	100.461	2609.421	5.970450
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	139.435	1880.050	4.301624
SumYShuffleG4X2_ConstVector128Traits	99.933	2623.206	6.001992
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 6

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-21037
SumYShuffleG4X2VectorBase	744.541	352.088
SumYShuffleG4X2VectorTraits	301.943	868.189	2.465827
SumYShuffleG4X2Vector128_Arm	182.218	1438.631	4.085994
SumYShuffleG4X2Vector128Traits	150.072	1746.792	4.961232
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	230.429	1137.635	3.231107
SumYShuffleG4X2_ConstVector128Traits	143.506	1826.710	5.188215
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	2018061718
SumYShuffleG4X2VectorBase	867.124	302.314
SumYShuffleG4X2VectorTraits	432.013	606.797	2.007172
SumYShuffleG4X2Vector128_Arm	374.172	700.597	2.317445
SumYShuffleG4X2Vector128Traits	291.580	899.045	2.973874
SumYShuffleG4X2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256_AvxUInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	459.672	570.285	1.886396
SumYShuffleG4X2_ConstVector128Traits	294.037	891.535	2.949032
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	5878554485936559874
SumYShuffleG4X2VectorBase	1171.354	223.796
SumYShuffleG4X2VectorTraits	1225.038	213.988	0.956178
SumYShuffleG4X2Vector128_Arm	1099.291	238.466	1.065554
SumYShuffleG4X2Vector128Traits	872.722	300.375	1.342185
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	1220.893	214.715	0.959424
SumYShuffleG4X2_ConstVector128Traits	872.247	300.539	1.342916
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	91
SumYShuffleG4X2VectorBase	600.527	436.523
SumYShuffleG4X2VectorTraits	125.206	2093.701	4.796309
SumYShuffleG4X2Vector128_Arm	101.845	2573.949	5.896473
SumYShuffleG4X2Vector128Traits	84.250	3111.505	7.127920
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	125.788	2084.019	4.774127
SumYShuffleG4X2_ConstVector128Traits	82.673	3170.846	7.263862
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 7

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-21037
SumYShuffleG4X2VectorBase	509.154	514.862
SumYShuffleG4VectorTraits	29.877	8773.970	17.041395
SumYShuffleG4X2VectorTraits	25.077	10453.467	20.303427
SumYShuffleG4X2VectorTraits_Tuple	233.229	1123.975	2.183060
SumYShuffleG4X2Vector128_Arm	45.574	5752.040	11.171999
SumYShuffleG4X2Vector128Traits	25.071	10456.141	20.308620
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	26.555	9871.904	19.173875
SumYShuffleG4X2_ConstVectorTraits_Tuple	238.452	1099.356	2.135243
SumYShuffleG4X2_ConstVector128Traits	26.616	9849.287	19.129947
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	2018061718
SumYShuffleG4X2VectorBase	663.282	395.222
SumYShuffleG4VectorTraits	61.094	4290.805	10.856687
SumYShuffleG4X2VectorTraits	51.889	5052.032	12.782762
SumYShuffleG4X2VectorTraits_Tuple	490.091	534.888	1.353385
SumYShuffleG4X2Vector128_Arm	91.715	2858.249	7.232002
SumYShuffleG4X2Vector128Traits	51.966	5044.526	12.763770
SumYShuffleG4X2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256_AvxUInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	54.802	4783.453	12.103197
SumYShuffleG4X2_ConstVectorTraits_Tuple	475.449	551.361	1.395066
SumYShuffleG4X2_ConstVector128Traits	54.774	4785.912	12.109419
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	5878554485936559874
SumYShuffleG4X2VectorBase	563.374	465.311
SumYShuffleG4VectorTraits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumYShuffleG4X2VectorTraits	173.457	1511.287	3.247910
SumYShuffleG4X2VectorTraits_Tuple	1182.021	221.776	0.476620
SumYShuffleG4X2Vector128_Arm	394.005	665.331	1.429864
SumYShuffleG4X2Vector128Traits	173.347	1512.251	3.249982
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	159.760	1640.858	3.526370
SumYShuffleG4X2_ConstVectorTraits_Tuple	1020.362	256.913	0.552131
SumYShuffleG4X2_ConstVector128Traits	159.904	1639.379	3.523192
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	91
SumYShuffleG4X2VectorBase	410.351	638.829
SumYShuffleG4VectorTraits	14.697	17836.828	27.921112
SumYShuffleG4X2VectorTraits	12.442	21068.455	32.979782
SumYShuffleG4X2VectorTraits_Tuple	109.013	2404.702	3.764232
SumYShuffleG4X2Vector128_Arm	22.669	11563.733	18.101441
SumYShuffleG4X2Vector128Traits	12.450	21055.908	32.960142
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	13.211	19843.259	31.061906
SumYShuffleG4X2_ConstVectorTraits_Tuple	111.462	2351.865	3.681523
SumYShuffleG4X2_ConstVector128Traits	13.221	19827.159	31.036703
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

