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
# SumYShuffleG2Scalar	28917
SumYShuffleG2Scalar	430.798	608.509
SumYShuffleG2VectorBase	435.416	602.053	0.989392
SumYShuffleG2VectorTraits	437.990	598.516	0.983579
SumYShuffleG2_ConstVectorTraits	434.039	603.965	0.992533

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-1234767990
SumYShuffleG2Scalar	526.328	498.062
SumYShuffleG2VectorBase	540.178	485.291	0.974359
SumYShuffleG2VectorTraits	538.207	487.069	0.977929
SumYShuffleG2_ConstVectorTraits	546.573	479.614	0.962960

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-5475020453166212109
SumYShuffleG2Scalar	535.362	489.657
SumYShuffleG2VectorBase	558.439	469.423	0.958676
SumYShuffleG2VectorTraits	569.883	459.996	0.939425
SumYShuffleG2_ConstVectorTraits	574.213	456.528	0.932341

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-47
SumYShuffleG2Scalar	385.243	680.464
SumYShuffleG2VectorBase	389.564	672.916	0.988908
SumYShuffleG2VectorTraits	389.547	672.945	0.988951
SumYShuffleG2_ConstVectorTraits	386.719	677.867	0.996184

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
# SumYShuffleG2Scalar	28917
SumYShuffleG2Scalar	430.758	608.565
SumYShuffleG2VectorBase	433.205	605.127	0.994350
SumYShuffleG2VectorTraits	433.153	605.200	0.994470
SumYShuffleG2_ConstVectorTraits	431.936	606.904	0.997271

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-1234767990
SumYShuffleG2Scalar	589.843	444.430
SumYShuffleG2VectorBase	550.619	476.090	1.071236
SumYShuffleG2VectorTraits	561.466	466.892	1.050541
SumYShuffleG2_ConstVectorTraits	534.071	490.841	1.104429

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-5475020453166212109
SumYShuffleG2Scalar	532.721	492.085
SumYShuffleG2VectorBase	538.875	486.465	0.988579
SumYShuffleG2VectorTraits	553.448	473.656	0.962549
SumYShuffleG2_ConstVectorTraits	502.744	521.426	1.059625

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-47
SumYShuffleG2Scalar	381.043	687.964
SumYShuffleG2VectorBase	385.508	679.997	0.988420
SumYShuffleG2VectorTraits	384.470	681.832	0.991087
SumYShuffleG2_ConstVectorTraits	388.151	675.367	0.981690

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
# SumYShuffleG2Scalar	28917
SumYShuffleG2Scalar	431.628	607.337
SumYShuffleG2VectorBase	477.598	548.880	0.903748
SumYShuffleG2VectorTraits	15.364	17062.597	28.094097
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	17.057	15369.029	25.305584
SumYShuffleG2_ConstVectorTraits	17.159	15276.939	25.153956
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	17.536	14948.660	24.613434

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-1234767990
SumYShuffleG2Scalar	531.855	492.886
SumYShuffleG2VectorBase	529.022	495.526	1.005355
SumYShuffleG2VectorTraits	52.343	5008.234	10.161033
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256_AvxByte	49.079	5341.304	10.836788
SumYShuffleG2Vector256_AvxInt32	57.151	4586.903	9.306210
SumYShuffleG2Vector256Traits	50.736	5166.812	10.482768
SumYShuffleG2_ConstVectorTraits	45.332	5782.725	11.732371
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256_AvxImm	96.269	2723.049	5.524701
SumYShuffleG2_ConstVector256Traits	46.917	5587.444	11.336173

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-5475020453166212109
SumYShuffleG2Scalar	529.742	494.852
SumYShuffleG2VectorBase	529.648	494.940	1.000178
SumYShuffleG2VectorTraits	71.947	3643.553	7.362918
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	82.196	3189.246	6.444850
SumYShuffleG2_ConstVectorTraits	86.378	3034.854	6.132855
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	83.728	3130.908	6.326960

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-47
SumYShuffleG2Scalar	415.067	631.571
SumYShuffleG2VectorBase	398.530	657.777	1.041494
SumYShuffleG2VectorTraits	12.926	20281.052	32.112067
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	17.181	15258.175	24.159080
SumYShuffleG2_ConstVectorTraits	15.855	16533.872	26.178959
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	10.694	24513.606	38.813697

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
# SumYShuffleG2Scalar	28917
SumYShuffleG2Scalar	430.051	609.565
SumYShuffleG2VectorBase	437.426	599.288	0.983141
SumYShuffleG2VectorTraits	35.009	7487.972	12.284133
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	22.019	11905.225	19.530704
SumYShuffleG2_ConstVectorTraits	23.003	11395.950	18.695232
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	22.175	11821.441	19.393257

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-1234767990
SumYShuffleG2Scalar	526.058	498.318
SumYShuffleG2VectorBase	526.544	497.858	0.999077
SumYShuffleG2VectorTraits	44.958	5830.844	11.701055
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256_AvxByte	45.100	5812.449	11.664142
SumYShuffleG2Vector256_AvxInt32	43.376	6043.458	12.127718
SumYShuffleG2Vector256Traits	45.275	5790.020	11.619132
SumYShuffleG2_ConstVectorTraits	46.342	5656.729	11.351649
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256_AvxImm	104.246	2514.662	5.046301
SumYShuffleG2_ConstVector256Traits	46.468	5641.366	11.320820

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-5475020453166212109
SumYShuffleG2Scalar	509.016	515.001
SumYShuffleG2VectorBase	507.876	516.157	1.002245
SumYShuffleG2VectorTraits	94.174	2783.603	5.405043
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	145.233	1804.989	3.504825
SumYShuffleG2_ConstVectorTraits	128.950	2032.911	3.947391
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	103.762	2526.387	4.905595

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-47
SumYShuffleG2Scalar	384.049	682.580
SumYShuffleG2VectorBase	385.769	679.537	0.995542
SumYShuffleG2VectorTraits	10.352	25323.689	37.099977
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	10.227	25632.784	37.552810
SumYShuffleG2_ConstVectorTraits	10.523	24912.218	36.497160
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	10.598	24734.297	36.236500

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
# SumYShuffleG2Scalar	28917
SumYShuffleG2Scalar	438.982	597.164
SumYShuffleG2VectorBase	433.148	605.207	1.013469
SumYShuffleG2VectorTraits	36.453	7191.259	12.042357
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	14.433	18162.644	30.414849
SumYShuffleG2_ConstVectorTraits	15.135	17320.210	29.004124
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	15.396	17026.636	28.512510

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-1234767990
SumYShuffleG2Scalar	537.295	487.896
SumYShuffleG2VectorBase	531.392	493.316	1.011109
SumYShuffleG2VectorTraits	25.375	10330.888	21.174377
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256_AvxByte	28.364	9242.277	18.943140
SumYShuffleG2Vector256_AvxInt32	28.564	9177.363	18.810090
SumYShuffleG2Vector256Traits	29.719	8820.722	18.079113
SumYShuffleG2_ConstVectorTraits	31.785	8247.323	16.903864
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256_AvxImm	117.499	2231.041	4.572781
SumYShuffleG2_ConstVector256Traits	60.063	4364.454	8.945464

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-5475020453166212109
SumYShuffleG2Scalar	813.847	322.105
SumYShuffleG2VectorBase	700.641	374.149	1.161575
SumYShuffleG2VectorTraits	67.815	3865.567	12.000960
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	64.261	4079.334	12.664615
SumYShuffleG2_ConstVectorTraits	73.932	3545.724	11.007980
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	68.473	3828.441	11.885699

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-47
SumYShuffleG2Scalar	537.664	487.561
SumYShuffleG2VectorBase	387.720	676.117	1.386733
SumYShuffleG2VectorTraits	8.208	31937.914	65.505500
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	14.136	18544.573	38.035406
SumYShuffleG2_ConstVectorTraits	9.356	28018.361	57.466395
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	9.087	28846.809	59.165563

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
# SumYShuffleG2Scalar	28917
SumYShuffleG2Scalar	352.905	742.818
SumYShuffleG2VectorBase	348.112	753.045	1.013767
SumYShuffleG2VectorTraits	13.141	19948.681	26.855404
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	14.696	17837.805	24.013691
SumYShuffleG2_ConstVectorTraits	15.003	17473.320	23.523012
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	14.945	17540.619	23.613612

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-1234767990
SumYShuffleG2Scalar	449.696	582.935
SumYShuffleG2VectorBase	460.996	568.647	0.975489
SumYShuffleG2VectorTraits	26.966	9721.452	16.676721
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256_AvxByte	27.745	9448.317	16.208170
SumYShuffleG2Vector256_AvxInt32	31.156	8413.956	14.433770
SumYShuffleG2Vector256Traits	29.767	8806.626	15.107377
SumYShuffleG2_ConstVectorTraits	30.418	8618.127	14.784017
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256_AvxImm	99.162	2643.603	4.534985
SumYShuffleG2_ConstVector256Traits	29.322	8940.305	15.336697

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-5475020453166212109
SumYShuffleG2Scalar	500.734	523.519
SumYShuffleG2VectorBase	527.995	496.489	0.948368
SumYShuffleG2VectorTraits	60.726	4316.827	8.245784
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	61.878	4236.441	8.092236
SumYShuffleG2_ConstVectorTraits	63.792	4109.338	7.849449
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	62.725	4179.272	7.983034

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	-47
SumYShuffleG2Scalar	301.767	868.698
SumYShuffleG2VectorBase	303.769	862.971	0.993407
SumYShuffleG2VectorTraits	6.213	42192.431	48.569753
SumYShuffleG2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2Vector256Traits	7.054	37160.549	42.777309
SumYShuffleG2_ConstVectorTraits	6.687	39204.539	45.130245
SumYShuffleG2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG2_ConstVector256Traits	7.034	37268.123	42.901143

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
# SumYShuffleG2Scalar	-4214
SumYShuffleG2Scalar	640.660	409.178
SumYShuffleG2VectorBase	640.672	409.170	0.999981
SumYShuffleG2VectorTraits	639.120	410.164	1.002410
SumYShuffleG2Vector128Traits	1027.780	255.059	0.623344
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	660.148	397.099	0.970480
SumYShuffleG2_ConstVector128Traits	1040.557	251.927	0.615690
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	1787346957
SumYShuffleG2Scalar	734.224	357.035
SumYShuffleG2VectorBase	733.629	357.325	1.000812
SumYShuffleG2VectorTraits	735.648	356.344	0.998064
SumYShuffleG2Vector128Traits	1470.862	178.225	0.499179
SumYShuffleG2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2Vector256_AvxInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	712.378	367.984	1.030666
SumYShuffleG2_ConstVector128Traits	1471.868	178.103	0.498838
SumYShuffleG2_ConstVector256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	5878554485936559874
SumYShuffleG2Scalar	671.932	390.134
SumYShuffleG2VectorBase	672.547	389.778	0.999086
SumYShuffleG2VectorTraits	672.658	389.714	0.998922
SumYShuffleG2Vector128Traits	1245.331	210.501	0.539561
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	671.489	390.392	1.000660
SumYShuffleG2_ConstVector128Traits	1254.146	209.022	0.535769
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	99
SumYShuffleG2Scalar	527.774	496.698
SumYShuffleG2VectorBase	529.566	495.017	0.996616
SumYShuffleG2VectorTraits	526.740	497.672	1.001963
SumYShuffleG2Vector128Traits	790.822	331.483	0.667373
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	545.916	480.191	0.966768
SumYShuffleG2_ConstVector128Traits	807.605	324.594	0.653505
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
# SumYShuffleG2Scalar	-4214
SumYShuffleG2Scalar	630.597	415.707
SumYShuffleG2VectorBase	631.053	415.408	0.999279
SumYShuffleG2VectorTraits	151.648	1728.633	4.158292
SumYShuffleG2Vector128_Arm	77.405	3386.669	8.146761
SumYShuffleG2Vector128Traits	59.257	4423.813	10.641649
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	60.178	4356.122	10.478816
SumYShuffleG2_ConstVector128Traits	59.023	4441.350	10.683835
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	1787346957
SumYShuffleG2Scalar	679.550	385.761
SumYShuffleG2VectorBase	687.287	381.418	0.988742
SumYShuffleG2VectorTraits	126.250	2076.380	5.382553
SumYShuffleG2Vector128_Arm	155.293	1688.065	4.375932
SumYShuffleG2Vector128Traits	124.490	2105.743	5.458669
SumYShuffleG2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2Vector256_AvxInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	127.534	2055.481	5.328375
SumYShuffleG2_ConstVector128Traits	124.011	2113.871	5.479738
SumYShuffleG2_ConstVector256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	5878554485936559874
SumYShuffleG2Scalar	407.580	643.172
SumYShuffleG2VectorBase	405.683	646.179	1.004676
SumYShuffleG2VectorTraits	248.756	1053.820	1.638473
SumYShuffleG2Vector128_Arm	318.927	821.955	1.277970
SumYShuffleG2Vector128Traits	237.196	1105.177	1.718321
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	244.822	1070.754	1.664801
SumYShuffleG2_ConstVector128Traits	245.053	1069.745	1.663232
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	99
SumYShuffleG2Scalar	524.684	499.623
SumYShuffleG2VectorBase	524.677	499.630	1.000014
SumYShuffleG2VectorTraits	30.134	8699.387	17.411908
SumYShuffleG2Vector128_Arm	38.627	6786.596	13.583437
SumYShuffleG2Vector128Traits	30.523	8588.475	17.189916
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	29.612	8852.539	17.718443
SumYShuffleG2_ConstVector128Traits	30.512	8591.587	17.196144
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
# SumYShuffleG2Scalar	-4214
SumYShuffleG2Scalar	631.331	415.224
SumYShuffleG2VectorBase	630.934	415.486	1.000630
SumYShuffleG2VectorTraits	185.679	1411.812	3.400121
SumYShuffleG2Vector128_Arm	66.758	3926.775	9.457000
SumYShuffleG2Vector128Traits	52.664	4977.700	11.987982
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	52.739	4970.636	11.970970
SumYShuffleG2_ConstVector128Traits	46.458	5642.547	13.589159
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	1787346957
SumYShuffleG2Scalar	683.295	383.647
SumYShuffleG2VectorBase	680.592	385.171	1.003972
SumYShuffleG2VectorTraits	93.054	2817.126	7.343021
SumYShuffleG2Vector128_Arm	133.776	1959.573	5.107755
SumYShuffleG2Vector128Traits	93.154	2814.108	7.335154
SumYShuffleG2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2Vector256_AvxInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	93.322	2809.026	7.321909
SumYShuffleG2_ConstVector128Traits	106.013	2472.765	6.445423
SumYShuffleG2_ConstVector256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	5878554485936559874
SumYShuffleG2Scalar	408.041	642.445
SumYShuffleG2VectorBase	407.153	643.846	1.002181
SumYShuffleG2VectorTraits	211.526	1239.297	1.929033
SumYShuffleG2Vector128_Arm	266.865	982.309	1.529018
SumYShuffleG2Vector128Traits	185.864	1410.405	2.195371
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	186.115	1408.506	2.192415
SumYShuffleG2_ConstVector128Traits	186.104	1408.586	2.192541
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	99
SumYShuffleG2Scalar	525.670	498.685
SumYShuffleG2VectorBase	526.717	497.694	0.998013
SumYShuffleG2VectorTraits	23.261	11269.647	22.598725
SumYShuffleG2Vector128_Arm	33.627	7795.579	15.632267
SumYShuffleG2Vector128Traits	26.404	9928.140	19.908635
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	26.363	9943.456	19.939347
SumYShuffleG2_ConstVector128Traits	23.229	11285.155	22.629822
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
# SumYShuffleG2Scalar	-4214
SumYShuffleG2Scalar	461.911	567.521
SumYShuffleG2VectorBase	466.415	562.040	0.990343
SumYShuffleG2VectorTraits	39.488	6638.622	11.697576
SumYShuffleG2Vector128_Arm	57.367	4569.616	8.051886
SumYShuffleG2Vector128Traits	39.455	6644.072	11.707180
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	39.461	6643.193	11.705631
SumYShuffleG2_ConstVector128Traits	39.464	6642.681	11.704730
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	1787346957
SumYShuffleG2Scalar	695.695	376.809
SumYShuffleG2VectorBase	698.676	375.201	0.995733
SumYShuffleG2VectorTraits	79.629	3292.077	8.736733
SumYShuffleG2Vector128_Arm	126.658	2069.693	5.492689
SumYShuffleG2Vector128Traits	79.468	3298.726	8.754378
SumYShuffleG2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2Vector256_AvxInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	79.461	3299.028	8.755179
SumYShuffleG2_ConstVector128Traits	79.485	3298.015	8.752492
SumYShuffleG2_ConstVector256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	5878554485936559874
SumYShuffleG2Scalar	360.734	726.697
SumYShuffleG2VectorBase	358.302	731.628	1.006785
SumYShuffleG2VectorTraits	158.221	1656.822	2.279935
SumYShuffleG2Vector128_Arm	243.936	1074.643	1.478804
SumYShuffleG2Vector128Traits	158.013	1658.998	2.282929
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	158.023	1658.898	2.282792
SumYShuffleG2_ConstVector128Traits	158.008	1659.060	2.283014
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG2Scalar	99
SumYShuffleG2Scalar	373.445	701.962
SumYShuffleG2VectorBase	373.485	701.886	0.999892
SumYShuffleG2VectorTraits	19.780	13253.277	18.880342
SumYShuffleG2Vector128_Arm	29.261	8958.913	12.762680
SumYShuffleG2Vector128Traits	19.759	13266.772	18.899566
SumYShuffleG2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG2_ConstVectorTraits	19.756	13268.865	18.902548
SumYShuffleG2_ConstVector128Traits	19.761	13266.034	18.898516
SumYShuffleG2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

