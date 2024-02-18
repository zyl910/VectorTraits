# Benchmark - YShuffleG2
([← Back](README.md))

See [Group](YShuffleG2_Group.md)

## x86

### Intel Core i5-8250U
`Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 
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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9167.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	434.328	603.563
SumBase	432.100	606.674	1.005155
SumTraits	438.687	597.564	0.990062
Sum_ConstTraits	431.139	608.027	1.007397

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	527.060	497.370
SumBase	528.789	495.744	0.996730
SumTraits	528.244	496.255	0.997758
Sum_ConstTraits	526.551	497.851	1.000967

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	531.217	493.478
SumBase	529.326	495.242	1.003574
SumTraits	528.985	495.560	1.004219
Sum_ConstTraits	499.466	524.849	1.063571

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	381.422	687.281
SumBase	382.460	685.415	0.997285
SumTraits	398.284	658.184	0.957662
Sum_ConstTraits	380.630	688.711	1.002080

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	428.650	611.557
SumBase	430.392	609.081	0.995951
SumTraits	430.114	609.475	0.996595
Sum_ConstTraits	429.310	610.617	0.998462

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	527.337	497.109
SumBase	534.264	490.663	0.987034
SumTraits	533.460	491.403	0.988523
Sum_ConstTraits	536.596	488.532	0.982747

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	536.988	488.174
SumBase	538.795	486.538	0.996647
SumTraits	541.013	484.543	0.992562
Sum_ConstTraits	503.076	521.083	1.067411

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	382.755	684.887
SumBase	383.261	683.982	0.998679
SumTraits	382.588	685.187	1.000438
Sum_ConstTraits	392.108	668.551	0.976148

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	435.265	602.263
SumBase	431.301	607.799	1.009191
SumTraits	21.473	12207.818	20.269897
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	21.440	12227.133	20.301967
Sum_ConstTraits	21.454	12219.112	20.288648
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	22.046	11890.565	19.743129

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	540.468	485.032
SumBase	528.176	496.319	1.023272
SumTraits	44.157	5936.641	12.239700
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	44.137	5939.308	12.245198
Sum256Traits	44.209	5929.641	12.225268
Sum_ConstTraits	44.595	5878.300	12.119417
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	92.564	2832.045	5.838888
Sum_Const256_AvxImmByte	118.556	2211.134	4.558743
Sum_Const256_AvxImmByteG4	21.964	11934.933	24.606506
Sum_Const256Traits	46.674	5616.497	11.579653

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	554.621	472.655
SumBase	529.481	495.096	1.047479
SumTraits	88.679	2956.109	6.254271
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	89.880	2916.597	6.170674
Sum_ConstTraits	93.149	2814.256	5.954150
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	91.498	2865.033	6.061580

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	383.389	683.754
SumBase	381.181	687.714	1.005792
SumTraits	10.463	25055.009	36.643310
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.372	25274.170	36.963835
Sum_ConstTraits	10.557	24830.939	36.315603
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	10.274	25514.129	37.314780

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
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	429.224	610.740
SumBase	429.910	609.765	0.998403
SumTraits	21.570	12153.266	19.899246
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	21.559	12159.311	19.909144
Sum_ConstTraits	21.714	12072.395	19.766832
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	21.696	12082.761	19.783805

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	527.777	496.694
SumBase	524.376	499.916	1.006487
SumTraits	43.735	5993.975	12.067736
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	43.662	6003.943	12.087805
Sum256Traits	44.164	5935.686	11.950383
Sum_ConstTraits	44.166	5935.378	11.949762
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	116.664	2247.003	4.523916
Sum_Const256_AvxImmByte	105.998	2473.094	4.979108
Sum_Const256_AvxImmByteG4	22.428	11688.258	23.532099
Sum_Const256Traits	46.458	5642.545	11.360198

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	513.438	510.566
SumBase	512.916	511.085	1.001016
SumTraits	92.896	2821.899	5.526997
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	97.224	2696.281	5.280959
Sum_ConstTraits	94.799	2765.271	5.416084
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	95.518	2744.432	5.375270

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	385.939	679.237
SumBase	388.105	675.446	0.994418
SumTraits	10.881	24092.316	35.469682
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.772	24336.080	35.828561
Sum_ConstTraits	10.869	24118.642	35.508439
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	11.143	23525.222	34.634784

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
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.14
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.14\
RuntimeInformation.FrameworkDescription:	.NET 6.0.14
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	437.003	599.868
SumBase	438.883	597.298	0.995717
SumTraits	14.146	18531.389	30.892456
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	15.656	16744.514	27.913674
Sum_ConstTraits	15.702	16694.599	27.830465
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	15.738	16656.231	27.766503

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	528.517	495.999
SumBase	538.090	487.175	0.982210
SumTraits	30.134	8699.256	17.538864
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	30.550	8580.903	17.300250
Sum256Traits	32.014	8188.328	16.508765
Sum_ConstTraits	31.661	8279.822	16.693229
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	98.180	2670.028	5.383134
Sum_Const256_AvxImmByte	109.491	2394.198	4.827024
Sum_Const256_AvxImmByteG4	24.254	10808.298	21.790975
Sum_Const256Traits	31.504	8320.925	16.776098

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	506.624	517.433
SumBase	526.641	497.766	0.961991
SumTraits	58.657	4469.086	8.637031
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	56.460	4642.996	8.973133
Sum_ConstTraits	63.079	4155.818	8.031603
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	65.207	4020.205	7.769515

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	381.342	687.424
SumBase	380.738	688.516	1.001588
SumTraits	6.530	40141.594	58.394223
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.784	38642.844	56.213982
Sum_ConstTraits	7.189	36462.187	53.041766
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	7.032	37278.811	54.229714

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
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.3
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.3\
RuntimeInformation.FrameworkDescription:	.NET 7.0.3
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	351.301	746.208
SumBase	348.994	751.141	1.006610
SumTraits	12.842	20412.731	27.355282
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	15.057	17409.773	23.330992
Sum_ConstTraits	15.109	17350.418	23.251449
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	15.130	17326.438	23.219313

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	450.567	581.809
SumBase	458.882	571.266	0.981880
SumTraits	28.984	9044.568	15.545606
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	33.069	7927.193	13.625086
Sum256Traits	31.477	8327.988	14.313964
Sum_ConstTraits	32.094	8168.093	14.039140
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	105.167	2492.633	4.284284
Sum_Const256_AvxImmByte	97.735	2682.200	4.610107
Sum_Const256_AvxImmByteG4	23.273	11263.914	19.360170
Sum_Const256Traits	31.393	8350.406	14.352495

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	499.618	524.689
SumBase	500.759	523.493	0.997721
SumTraits	59.303	4420.383	8.424771
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	61.562	4258.220	8.115705
Sum_ConstTraits	63.392	4135.294	7.881421
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	64.421	4069.263	7.755573

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	306.846	854.318
SumBase	304.089	862.064	1.009067
SumTraits	5.912	44339.044	51.899908
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	7.173	36544.143	42.775790
Sum_ConstTraits	7.052	37174.087	43.513155
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	7.143	36700.467	42.958772

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	641.147	408.867
SumBase	642.370	408.089	0.998097
SumTraits	642.977	407.703	0.997153
Sum128Traits	1032.773	253.825	0.620801
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	662.836	395.489	0.967279
Sum_Const128Traits	1048.264	250.075	0.611628
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	734.179	357.057
SumBase	736.233	356.061	0.997210
SumTraits	736.612	355.878	0.996698
Sum128Traits	1482.588	176.815	0.495201
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	711.971	368.195	1.031193
Sum_Const128Traits	1484.191	176.624	0.494666
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	702.348	373.239
SumBase	680.468	385.241	1.032154
SumTraits	675.432	388.113	1.039851
Sum128Traits	1265.155	207.203	0.555148
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	674.650	388.563	1.041055
Sum_Const128Traits	2014.728	130.114	0.348607
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	527.228	497.212
SumBase	526.947	497.477	1.000533
SumTraits	527.700	496.767	0.999105
Sum128Traits	795.886	329.374	0.662441
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	547.993	478.371	0.962106
Sum_Const128Traits	809.591	323.798	0.651228
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	632.719	414.314
SumBase	632.393	414.527	1.000516
SumTraits	61.072	4292.406	10.360284
Sum128_AdvSimd	77.850	3367.297	8.127413
Sum128Traits	59.193	4428.609	10.689028
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	61.224	4281.729	10.334512
Sum_Const128Traits	59.176	4429.919	10.692188
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	688.092	380.972
SumBase	680.304	385.334	1.011447
SumTraits	123.179	2128.149	5.586099
Sum128_AdvSimd	156.532	1674.701	4.395859
Sum128Traits	123.032	2130.689	5.592766
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	120.213	2180.661	5.723934
Sum_Const128Traits	120.846	2169.232	5.693935
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	407.702	642.980
SumBase	408.777	641.289	0.997370
SumTraits	242.649	1080.341	1.680209
Sum128_AdvSimd	319.141	821.406	1.277499
Sum128Traits	244.010	1074.316	1.670839
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	244.756	1071.043	1.665749
Sum_Const128Traits	245.296	1068.682	1.662078
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	524.980	499.341
SumBase	525.695	498.662	0.998640
SumTraits	28.722	9127.030	18.278142
Sum128_AdvSimd	39.031	6716.285	13.450292
Sum128Traits	29.821	8790.495	17.604185
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	30.154	8693.426	17.409790
Sum_Const128Traits	30.733	8529.797	17.082101
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	631.863	414.875
SumBase	632.219	414.641	0.999436
SumTraits	46.598	5625.606	13.559764
Sum128_AdvSimd	66.702	3930.065	9.472891
Sum128Traits	46.585	5627.211	13.563632
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	52.850	4960.118	11.955695
Sum_Const128Traits	46.643	5620.166	13.546652
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	681.772	384.504
SumBase	684.484	382.980	0.996037
SumTraits	94.200	2782.839	7.237476
Sum128_AdvSimd	134.586	1947.774	5.065677
Sum128Traits	106.492	2461.635	6.402103
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	94.148	2784.380	7.241483
Sum_Const128Traits	106.586	2459.462	6.396452
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	407.790	642.840
SumBase	407.856	642.737	0.999839
SumTraits	211.148	1241.516	1.931297
Sum128_AdvSimd	266.683	982.979	1.529119
Sum128Traits	186.338	1406.823	2.188449
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	186.073	1408.820	2.191556
Sum_Const128Traits	186.282	1407.240	2.189098
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	525.510	498.837
SumBase	524.890	499.426	1.001182
SumTraits	23.249	11275.733	22.604050
Sum128_AdvSimd	33.311	7869.652	15.776004
Sum128Traits	26.379	9937.638	19.921619
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	26.359	9945.001	19.936380
Sum_Const128Traits	23.250	11275.200	22.602981
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	464.227	564.690
SumBase	466.270	562.215	0.995618
SumTraits	39.637	6613.609	11.711937
Sum128_AdvSimd	58.448	4485.065	7.942532
Sum128Traits	39.558	6626.837	11.735364
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	39.576	6623.755	11.729904
Sum_Const128Traits	39.592	6621.201	11.725382
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	695.247	377.051
SumBase	698.013	375.558	0.996038
SumTraits	79.975	3277.805	8.693258
Sum128_AdvSimd	129.443	2025.177	5.371090
Sum128Traits	79.843	3283.247	8.707690
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	79.920	3280.066	8.699253
Sum_Const128Traits	79.863	3282.427	8.705515
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	358.414	731.401
SumBase	357.971	732.306	1.001237
SumTraits	160.467	1633.636	2.233571
Sum128_AdvSimd	249.916	1048.929	1.434136
Sum128Traits	160.549	1632.801	2.232429
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	160.506	1633.239	2.233029
Sum_Const128Traits	160.776	1630.490	2.229270
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	373.884	701.137
SumBase	374.219	700.510	0.999106
SumTraits	19.874	13190.553	18.813082
Sum128_AdvSimd	31.083	8433.558	12.028398
Sum128Traits	19.832	13218.098	18.852368
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	19.839	13213.780	18.846210
Sum_Const128Traits	19.830	13219.879	18.854909
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

