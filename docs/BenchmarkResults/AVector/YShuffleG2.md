# Benchmark - YShuffleG2
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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	430.798	608.509
SumBase	435.416	602.053	0.989392
SumTraits	437.990	598.516	0.983579
Sum_ConstTraits	434.039	603.965	0.992533

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	526.328	498.062
SumBase	540.178	485.291	0.974359
SumTraits	538.207	487.069	0.977929
Sum_ConstTraits	546.573	479.614	0.962960

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	535.362	489.657
SumBase	558.439	469.423	0.958676
SumTraits	569.883	459.996	0.939425
Sum_ConstTraits	574.213	456.528	0.932341

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	385.243	680.464
SumBase	389.564	672.916	0.988908
SumTraits	389.547	672.945	0.988951
Sum_ConstTraits	386.719	677.867	0.996184

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	430.758	608.565
SumBase	433.205	605.127	0.994350
SumTraits	433.153	605.200	0.994470
Sum_ConstTraits	431.936	606.904	0.997271

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	589.843	444.430
SumBase	550.619	476.090	1.071236
SumTraits	561.466	466.892	1.050541
Sum_ConstTraits	534.071	490.841	1.104429

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	532.721	492.085
SumBase	538.875	486.465	0.988579
SumTraits	553.448	473.656	0.962549
Sum_ConstTraits	502.744	521.426	1.059625

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	381.043	687.964
SumBase	385.508	679.997	0.988420
SumTraits	384.470	681.832	0.991087
Sum_ConstTraits	388.151	675.367	0.981690

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	440.851	594.632
SumBase	431.354	607.723	1.022016
SumTraits	14.720	17808.150	29.948194
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	19.023	13780.350	23.174591
Sum_ConstTraits	24.760	10587.192	17.804616
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	18.141	14450.362	24.301358

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	539.690	485.730
SumBase	527.366	497.082	1.023369
SumTraits	43.288	6055.763	12.467331
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	42.901	6110.387	12.579789
Sum256_AvxInt32	43.984	5959.943	12.270063
Sum256Traits	42.936	6105.449	12.569623
Sum_ConstTraits	43.412	6038.536	12.431866
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	98.396	2664.175	5.484883
Sum_Const256_AvxImmByte	109.304	2398.304	4.937520
Sum_Const256_AvxImmByteG4	25.584	10246.277	21.094574
Sum_Const256Traits	45.278	5789.693	11.919559

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	551.414	475.403
SumBase	531.741	492.992	1.036998
SumTraits	71.720	3655.084	7.688389
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	72.349	3623.312	7.621559
Sum_ConstTraits	75.853	3455.963	7.269543
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	74.956	3497.315	7.356527

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	394.571	664.377
SumBase	381.446	687.238	1.034410
SumTraits	10.776	24327.486	36.616987
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.576	24786.279	37.307549
Sum_ConstTraits	10.889	24074.846	36.236721
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	10.884	24086.006	36.253520

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	430.482	608.954
SumBase	470.396	557.284	0.915149
SumTraits	37.611	6969.829	11.445574
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	22.659	11569.001	18.998149
Sum_ConstTraits	22.993	11401.080	18.722396
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	22.254	11779.643	19.344057

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	527.888	496.590
SumBase	528.135	496.358	0.999532
SumTraits	44.466	5895.394	11.871753
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	45.098	5812.763	11.705356
Sum256_AvxInt32	43.476	6029.602	12.142012
Sum256Traits	46.207	5673.209	11.424331
Sum_ConstTraits	45.052	5818.690	11.717291
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	118.480	2212.566	4.455519
Sum_Const256_AvxImmByte	136.503	1920.426	3.867225
Sum_Const256_AvxImmByteG4	26.870	9756.039	19.646062
Sum_Const256Traits	50.470	5194.092	10.459517

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	540.779	484.752
SumBase	514.094	509.915	1.051907
SumTraits	100.325	2612.943	5.390262
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	90.996	2880.818	5.942865
Sum_ConstTraits	95.609	2741.820	5.656124
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	95.233	2752.663	5.678493

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	384.324	682.091
SumBase	442.211	592.803	0.869097
SumTraits	12.096	21672.670	31.773858
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	11.117	23580.835	34.571380
Sum_ConstTraits	11.871	22081.897	32.373818
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	12.340	21242.581	31.143313

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	436.806	600.139
SumBase	429.787	609.940	1.016331
SumTraits	38.273	6849.321	11.412900
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	15.497	16915.962	28.186761
Sum_ConstTraits	15.639	16762.267	27.930662
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	15.804	16587.324	27.639156

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	526.830	497.587
SumBase	527.865	496.612	0.998039
SumTraits	54.191	4837.393	9.721702
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	31.041	8445.187	16.972281
Sum256_AvxInt32	29.847	8782.981	17.651144
Sum256Traits	32.087	8169.786	16.418808
Sum_ConstTraits	31.917	8213.234	16.506124
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	114.585	2287.765	4.597717
Sum_Const256_AvxImmByte	99.614	2631.604	5.288731
Sum_Const256_AvxImmByteG4	21.591	12141.632	24.401020
Sum_Const256Traits	30.916	8479.137	17.040509

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	505.775	518.301
SumBase	504.961	519.137	1.001612
SumTraits	64.614	4057.054	7.827596
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	61.375	4271.161	8.240690
Sum_ConstTraits	65.425	4006.810	7.730658
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	65.322	4013.077	7.742749

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	380.398	689.131
SumBase	386.162	678.845	0.985074
SumTraits	6.471	40509.926	58.784065
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	7.035	37264.251	54.074257
Sum_ConstTraits	7.131	36762.105	53.345593
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	7.135	36738.159	53.310845

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	352.218	744.265
SumBase	355.298	737.814	0.991332
SumTraits	14.060	18644.205	25.050480
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	14.700	17832.656	23.960078
Sum_ConstTraits	14.769	17750.194	23.849280
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	14.704	17827.513	23.953167

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	449.745	582.873
SumBase	450.072	582.449	0.999273
SumTraits	27.617	9492.012	16.284884
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	27.926	9386.933	16.104608
Sum256_AvxInt32	27.868	9406.607	16.138360
Sum256Traits	26.583	9861.162	16.918213
Sum_ConstTraits	27.698	9464.280	16.237307
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	96.924	2704.632	4.640178
Sum_Const256_AvxImmByte	92.872	2822.631	4.842621
Sum_Const256_AvxImmByteG4	24.021	10913.275	18.723261
Sum_Const256Traits	28.823	9095.020	15.603790

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	499.601	524.707
SumBase	519.391	504.714	0.961897
SumTraits	59.681	4392.433	8.371208
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	59.286	4421.712	8.427009
Sum_ConstTraits	60.471	4335.051	8.261848
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	63.909	4101.815	7.817341

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	305.404	858.351
SumBase	306.024	856.611	0.997973
SumTraits	6.501	40321.043	46.974996
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.913	37919.636	44.177298
Sum_ConstTraits	6.661	39353.248	45.847491
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	7.026	37309.780	43.466801

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	640.660	409.178
SumBase	640.672	409.170	0.999981
SumTraits	639.120	410.164	1.002410
Sum128Traits	1027.780	255.059	0.623344
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	660.148	397.099	0.970480
Sum_Const128Traits	1040.557	251.927	0.615690
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	734.224	357.035
SumBase	733.629	357.325	1.000812
SumTraits	735.648	356.344	0.998064
Sum128Traits	1470.862	178.225	0.499179
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256_AvxInt32	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	712.378	367.984	1.030666
Sum_Const128Traits	1471.868	178.103	0.498838
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	671.932	390.134
SumBase	672.547	389.778	0.999086
SumTraits	672.658	389.714	0.998922
Sum128Traits	1245.331	210.501	0.539561
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	671.489	390.392	1.000660
Sum_Const128Traits	1254.146	209.022	0.535769
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	527.774	496.698
SumBase	529.566	495.017	0.996616
SumTraits	526.740	497.672	1.001963
Sum128Traits	790.822	331.483	0.667373
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	545.916	480.191	0.966768
Sum_Const128Traits	807.605	324.594	0.653505
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	630.597	415.707
SumBase	631.053	415.408	0.999279
SumTraits	151.648	1728.633	4.158292
Sum128_AdvSimd	77.405	3386.669	8.146761
Sum128Traits	59.257	4423.813	10.641649
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	60.178	4356.122	10.478816
Sum_Const128Traits	59.023	4441.350	10.683835
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	679.550	385.761
SumBase	687.287	381.418	0.988742
SumTraits	126.250	2076.380	5.382553
Sum128_AdvSimd	155.293	1688.065	4.375932
Sum128Traits	124.490	2105.743	5.458669
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256_AvxInt32	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	127.534	2055.481	5.328375
Sum_Const128Traits	124.011	2113.871	5.479738
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	407.580	643.172
SumBase	405.683	646.179	1.004676
SumTraits	248.756	1053.820	1.638473
Sum128_AdvSimd	318.927	821.955	1.277970
Sum128Traits	237.196	1105.177	1.718321
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	244.822	1070.754	1.664801
Sum_Const128Traits	245.053	1069.745	1.663232
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	524.684	499.623
SumBase	524.677	499.630	1.000014
SumTraits	30.134	8699.387	17.411908
Sum128_AdvSimd	38.627	6786.596	13.583437
Sum128Traits	30.523	8588.475	17.189916
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	29.612	8852.539	17.718443
Sum_Const128Traits	30.512	8591.587	17.196144
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	631.331	415.224
SumBase	630.934	415.486	1.000630
SumTraits	185.679	1411.812	3.400121
Sum128_AdvSimd	66.758	3926.775	9.457000
Sum128Traits	52.664	4977.700	11.987982
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	52.739	4970.636	11.970970
Sum_Const128Traits	46.458	5642.547	13.589159
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	683.295	383.647
SumBase	680.592	385.171	1.003972
SumTraits	93.054	2817.126	7.343021
Sum128_AdvSimd	133.776	1959.573	5.107755
Sum128Traits	93.154	2814.108	7.335154
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256_AvxInt32	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	93.322	2809.026	7.321909
Sum_Const128Traits	106.013	2472.765	6.445423
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	408.041	642.445
SumBase	407.153	643.846	1.002181
SumTraits	211.526	1239.297	1.929033
Sum128_AdvSimd	266.865	982.309	1.529018
Sum128Traits	185.864	1410.405	2.195371
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	186.115	1408.506	2.192415
Sum_Const128Traits	186.104	1408.586	2.192541
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	525.670	498.685
SumBase	526.717	497.694	0.998013
SumTraits	23.261	11269.647	22.598725
Sum128_AdvSimd	33.627	7795.579	15.632267
Sum128Traits	26.404	9928.140	19.908635
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	26.363	9943.456	19.939347
Sum_Const128Traits	23.229	11285.155	22.629822
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	461.911	567.521
SumBase	466.415	562.040	0.990343
SumTraits	39.488	6638.622	11.697576
Sum128_AdvSimd	57.367	4569.616	8.051886
Sum128Traits	39.455	6644.072	11.707180
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	39.461	6643.193	11.705631
Sum_Const128Traits	39.464	6642.681	11.704730
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	695.695	376.809
SumBase	698.676	375.201	0.995733
SumTraits	79.629	3292.077	8.736733
Sum128_AdvSimd	126.658	2069.693	5.492689
Sum128Traits	79.468	3298.726	8.754378
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256_AvxInt32	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	79.461	3299.028	8.755179
Sum_Const128Traits	79.485	3298.015	8.752492
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	360.734	726.697
SumBase	358.302	731.628	1.006785
SumTraits	158.221	1656.822	2.279935
Sum128_AdvSimd	243.936	1074.643	1.478804
Sum128Traits	158.013	1658.998	2.282929
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	158.023	1658.898	2.282792
Sum_Const128Traits	158.008	1659.060	2.283014
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	373.445	701.962
SumBase	373.485	701.886	0.999892
SumTraits	19.780	13253.277	18.880342
Sum128_AdvSimd	29.261	8958.913	12.762680
Sum128Traits	19.759	13266.772	18.899566
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	19.756	13268.865	18.902548
Sum_Const128Traits	19.761	13266.034	18.898516
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

