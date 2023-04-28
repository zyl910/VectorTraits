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
SumYShuffleG4X2VectorBase	436.288	600.850
SumYShuffleG4VectorTraits	19.783	13250.943	22.053645
SumYShuffleG4X2VectorTraits	15.205	17240.126	28.692872
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	13.608	19264.372	32.061840
SumYShuffleG4X2_ConstVectorTraits	13.311	19693.943	32.776778
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	14.574	17987.251	29.936318

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	443.616	590.926
SumYShuffleG4VectorTraits	26.242	9989.468	16.904771
SumYShuffleG4X2VectorTraits	26.145	10026.704	16.967783
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256_AvxByte	27.797	9430.618	15.959052
SumYShuffleG4X2Vector256_AvxUInt32	27.719	9457.254	16.004127
SumYShuffleG4X2Vector256Traits	22.899	11448.051	19.373071
SumYShuffleG4X2_ConstVectorTraits	20.778	12616.435	21.350280
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	20.927	12526.652	21.198344

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	453.489	578.061
SumYShuffleG4VectorTraits	73.898	3547.390	6.136707
SumYShuffleG4X2VectorTraits	51.350	5105.006	8.831261
SumYShuffleG4X2VectorTraits_Out	51.940	5047.047	8.730996
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	55.016	4764.906	8.242914
SumYShuffleG4X2_ConstVectorTraits	44.433	5899.792	10.206179
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	43.883	5973.717	10.334063

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	356.091	736.171
SumYShuffleG4VectorTraits	5.236	50061.842	68.002995
SumYShuffleG4X2VectorTraits	4.600	56991.103	77.415563
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	4.425	59245.232	80.477526
SumYShuffleG4X2_ConstVectorTraits	4.534	57818.824	78.539923
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	5.015	52269.525	71.001867

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
SumYShuffleG4X2VectorBase	595.051	440.540
SumYShuffleG4VectorTraits	33.733	7771.105	17.639945
SumYShuffleG4X2VectorTraits	240.912	1088.130	2.469990
SumYShuffleG4X2Vector128_Arm	181.976	1440.539	3.269937
SumYShuffleG4X2Vector128Traits	155.680	1683.865	3.822273
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	237.998	1101.457	2.500241
SumYShuffleG4X2_ConstVector128Traits	157.902	1660.168	3.768483
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	2018061718
SumYShuffleG4X2VectorBase	890.275	294.453
SumYShuffleG4VectorTraits	65.828	3982.237	13.524193
SumYShuffleG4X2VectorTraits	439.437	596.546	2.025947
SumYShuffleG4X2Vector128_Arm	323.215	811.051	2.754435
SumYShuffleG4X2Vector128Traits	292.070	897.537	3.048153
SumYShuffleG4X2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256_AvxUInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	439.036	597.090	2.027795
SumYShuffleG4X2_ConstVector128Traits	291.883	898.113	3.050107
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	5878554485936559874
SumYShuffleG4X2VectorBase	1052.329	249.108
SumYShuffleG4VectorTraits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumYShuffleG4X2VectorTraits	1203.496	217.819	0.874393
SumYShuffleG4X2VectorTraits_Out	173.579	1510.229	6.062537
SumYShuffleG4X2Vector128_Arm	1073.824	244.122	0.979983
SumYShuffleG4X2Vector128Traits	866.479	302.539	1.214489
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	1031.926	254.034	1.019772
SumYShuffleG4X2_ConstVector128Traits	859.161	305.116	1.224833
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	91
SumYShuffleG4X2VectorBase	448.466	584.535
SumYShuffleG4VectorTraits	14.844	17660.103	30.212225
SumYShuffleG4X2VectorTraits	117.185	2237.012	3.826994
SumYShuffleG4X2Vector128_Arm	81.381	3221.195	5.510697
SumYShuffleG4X2Vector128Traits	80.516	3255.784	5.569870
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	114.696	2285.550	3.910032
SumYShuffleG4X2_ConstVector128Traits	80.409	3260.123	5.577294
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

