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
# SumX2Base	-30719
SumX2Base	472.355	554.973
SumTraits	437.582	599.074	1.079466
SumX2Traits	442.131	592.911	1.068360
SumX2Traits_Tuple	473.229	553.948	0.998153
SumX2_ConstTraits	438.804	597.406	1.076460
SumX2_ConstTraits_Tuple	473.764	553.322	0.997025

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	1670557139
SumX2Base	531.222	493.473
SumTraits	521.486	502.686	1.018669
SumX2Traits	526.274	498.113	1.009402
SumX2Traits_Tuple	591.513	443.176	0.898074
SumX2_ConstTraits	522.896	501.331	1.015924
SumX2_ConstTraits_Tuple	588.253	445.631	0.903050

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-7093169134606779633
SumX2Base	480.236	545.865
SumTraits	507.567	516.472	0.946152
SumX2Traits	511.848	512.153	0.938239
SumX2Traits_Tuple	655.267	400.057	0.732885
SumX2_ConstTraits	495.605	528.937	0.968988
SumX2_ConstTraits_Tuple	628.809	416.889	0.763722

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	90
SumX2Base	421.909	621.328
SumTraits	401.109	653.548	1.051856
SumX2Traits	401.706	652.577	1.050294
SumX2Traits_Tuple	420.955	622.737	1.002267
SumX2_ConstTraits	402.340	651.548	1.048637
SumX2_ConstTraits_Tuple	432.408	606.243	0.975721

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
# SumX2Base	-30719
SumX2Base	440.131	595.604
SumTraits	443.144	591.554	0.993200
SumX2Traits	441.721	593.461	0.996401
SumX2Traits_Tuple	527.352	497.095	0.834605
SumX2_ConstTraits	464.473	564.390	0.947592
SumX2_ConstTraits_Tuple	487.006	538.277	0.903749

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	1670557139
SumX2Base	546.487	479.689
SumTraits	564.700	464.218	0.967748
SumX2Traits	609.459	430.126	0.896676
SumX2Traits_Tuple	802.936	326.482	0.680611
SumX2_ConstTraits	633.475	413.819	0.862682
SumX2_ConstTraits_Tuple	593.195	441.919	0.921261

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-7093169134606779633
SumX2Base	506.669	517.387
SumTraits	485.109	540.381	1.044443
SumX2Traits	507.293	516.751	0.998770
SumX2Traits_Tuple	612.546	427.958	0.827153
SumX2_ConstTraits	446.965	586.497	1.133576
SumX2_ConstTraits_Tuple	568.704	460.950	0.890919

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	90
SumX2Base	488.406	536.734
SumTraits	403.959	648.937	1.209047
SumX2Traits	403.028	650.436	1.211841
SumX2Traits_Tuple	418.090	627.003	1.168182
SumX2_ConstTraits	402.349	651.534	1.213885
SumX2_ConstTraits_Tuple	414.406	632.578	1.178568

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-30719
SumX2Base	440.765	594.748
SumTraits	21.963	11935.457	20.068078
SumX2Traits	17.169	15268.543	25.672273
SumX2Traits_Tuple	16.555	15834.545	26.623940
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	16.590	15801.413	26.568232
SumX2_ConstTraits	12.440	21072.647	35.431198
SumX2_ConstTraits_Tuple	18.575	14112.809	23.729043
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	19.914	13163.805	22.133402

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	1670557139
SumX2Base	809.759	323.731
SumTraits	60.918	4303.224	13.292594
SumX2Traits	39.936	6564.061	20.276286
SumX2Traits_Tuple	39.371	6658.317	20.567442
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256_AvxByte	55.183	4750.440	14.674040
SumX2256Traits	37.359	7016.801	21.674795
SumX2_ConstTraits	29.184	8982.600	27.747118
SumX2_ConstTraits_Tuple	27.293	9604.633	29.668570
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	23.919	10959.717	33.854403

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-7093169134606779633
SumX2Base	528.238	496.262
SumTraits	95.719	2738.669	5.518601
SumX2Traits	65.299	4014.525	8.089536
SumX2Traits_Tuple	74.911	3499.386	7.051497
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	78.035	3359.324	6.769262
SumX2_ConstTraits	56.801	4615.119	9.299772
SumX2_ConstTraits_Tuple	57.827	4533.221	9.134742
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	51.967	5044.404	10.164810

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	90
SumX2Base	432.373	606.292
SumTraits	11.743	22322.798	36.818573
SumX2Traits	8.280	31661.445	52.221466
SumX2Traits_Tuple	7.373	35553.600	58.641073
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	7.026	37311.887	61.541142
SumX2_ConstTraits	6.729	38955.916	64.252754
SumX2_ConstTraits_Tuple	6.743	38876.809	64.122278
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	6.910	37937.472	62.572963

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-30719
SumX2Base	436.996	599.878
SumTraits	20.285	12923.007	21.542732
SumX2Traits	13.538	19363.077	32.278369
SumX2Traits_Tuple	13.497	19421.854	32.376351
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	13.826	18960.863	31.607876
SumX2_ConstTraits	12.369	21192.926	35.328739
SumX2_ConstTraits_Tuple	11.468	22859.177	38.106389
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	12.109	21648.945	36.088924

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	1670557139
SumX2Base	519.689	504.424
SumTraits	41.384	6334.474	12.557827
SumX2Traits	30.422	8616.796	17.082436
SumX2Traits_Tuple	30.726	8531.771	16.913876
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256_AvxByte	41.723	6282.983	12.455749
SumX2256Traits	29.777	8803.505	17.452579
SumX2_ConstTraits	19.598	13375.810	26.516981
SumX2_ConstTraits_Tuple	19.866	13195.765	26.160049
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	22.308	11751.343	23.296543

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-7093169134606779633
SumX2Base	470.943	556.636
SumTraits	84.820	3090.583	5.552253
SumX2Traits	58.955	4446.513	7.988189
SumX2Traits_Tuple	60.992	4298.041	7.721459
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	59.925	4374.499	7.858817
SumX2_ConstTraits	46.138	5681.759	10.207318
SumX2_ConstTraits_Tuple	41.835	6266.174	11.257223
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	43.202	6067.937	10.901088

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	90
SumX2Base	395.237	663.258
SumTraits	9.586	27347.950	41.232769
SumX2Traits	6.588	39791.249	59.993651
SumX2Traits_Tuple	6.636	39505.032	59.562118
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	6.456	40605.712	61.221624
SumX2_ConstTraits	6.705	39095.721	58.944997
SumX2_ConstTraits_Tuple	6.688	39198.301	59.099657
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	6.514	40241.375	60.672310

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-30719
SumX2Base	442.294	592.692
SumTraits	16.612	15780.775	26.625590
SumX2Traits	13.127	19969.120	33.692236
SumX2Traits_Tuple	12.119	21630.057	36.494598
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	11.942	21950.891	37.035914
SumX2_ConstTraits	11.489	22817.161	38.497498
SumX2_ConstTraits_Tuple	11.451	22892.122	38.623975
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	11.665	22471.733	37.914688

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	1670557139
SumX2Base	519.096	505.001
SumTraits	28.414	9225.805	18.268877
SumX2Traits	22.540	11630.001	23.029650
SumX2Traits_Tuple	22.492	11655.096	23.079342
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256_AvxByte	28.307	9260.909	18.338389
SumX2256Traits	24.510	10695.347	21.178854
SumX2_ConstTraits	19.453	13475.419	26.683933
SumX2_ConstTraits_Tuple	19.653	13338.318	26.412447
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	19.492	13448.541	26.630710

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-7093169134606779633
SumX2Base	466.058	562.471
SumTraits	67.089	3907.413	6.946867
SumX2Traits	47.576	5509.957	9.795979
SumX2Traits_Tuple	47.735	5491.627	9.763390
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	47.466	5522.825	9.818856
SumX2_ConstTraits	41.685	6288.676	11.180440
SumX2_ConstTraits_Tuple	41.015	6391.396	11.363061
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	39.467	6642.153	11.808874

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	90
SumX2Base	394.671	664.208
SumTraits	9.946	26355.877	39.680149
SumX2Traits	6.564	39933.685	60.122248
SumX2Traits_Tuple	6.559	39968.071	60.174019
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	6.657	39378.373	59.286197
SumX2_ConstTraits	6.687	39202.016	59.020682
SumX2_ConstTraits_Tuple	7.111	36862.994	55.499162
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	6.822	38428.551	57.856190

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-30719
SumX2Base	365.440	717.339
SumTraits	13.942	18802.869	26.211973
SumX2Traits	10.967	23901.939	33.320286
SumX2Traits_Tuple	11.014	23801.542	33.180329
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	12.157	21563.453	30.060341
SumX2_ConstTraits	12.266	21371.629	29.792930
SumX2_ConstTraits_Tuple	12.375	21183.068	29.530068
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	11.844	22132.880	30.854145

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	1670557139
SumX2Base	441.284	594.048
SumTraits	26.413	9924.749	16.706991
SumX2Traits	22.788	11503.657	19.364871
SumX2Traits_Tuple	22.497	11652.494	19.615419
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256_AvxByte	26.361	9944.250	16.739818
SumX2256Traits	22.528	11636.526	19.588539
SumX2_ConstTraits	19.781	13252.346	22.308555
SumX2_ConstTraits_Tuple	19.728	13288.214	22.368935
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	19.718	13294.781	22.379990

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-7093169134606779633
SumX2Base	446.404	587.235
SumTraits	69.758	3757.901	6.399318
SumX2Traits	49.518	5293.880	9.014931
SumX2Traits_Tuple	48.891	5361.837	9.130654
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	49.306	5316.628	9.053669
SumX2_ConstTraits	42.620	6150.739	10.474073
SumX2_ConstTraits_Tuple	42.340	6191.383	10.543286
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	42.076	6230.246	10.609465

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	90
SumX2Base	317.459	825.757
SumTraits	6.247	41961.941	50.816317
SumX2Traits	4.688	55913.909	67.712285
SumX2Traits_Tuple	4.634	56573.159	68.510643
SumX2128_Arm	Run fail! Requires hardware support AdvSimd!
SumX2128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2256Traits	4.802	54592.121	66.111586
SumX2_ConstTraits	4.467	58679.119	71.060981
SumX2_ConstTraits_Tuple	4.610	56869.264	68.869229
SumX2_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumX2_Const256Traits	4.678	56038.270	67.862887

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-21037
SumX2Base	680.136	385.429
SumTraits	683.478	383.544	0.995111
SumX2Traits	679.805	385.616	1.000487
SumX2Traits_Tuple	742.615	353.001	0.915866
SumX2128Traits	1070.777	244.817	0.635180
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	701.852	373.503	0.969060
SumX2_ConstTraits_Tuple	764.678	342.816	0.889441
SumX2_Const128Traits	1093.633	239.700	0.621905
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	2018061718
SumX2Base	701.304	373.795
SumTraits	701.620	373.627	0.999550
SumX2Traits	704.164	372.277	0.995938
SumX2Traits_Tuple	930.739	281.651	0.753491
SumX2128Traits	1462.284	179.270	0.479595
SumX2256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	680.496	385.225	1.030577
SumX2_ConstTraits_Tuple	911.377	287.635	0.769499
SumX2_Const128Traits	1463.106	179.170	0.479325
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	5878554485936559874
SumX2Base	833.491	314.513
SumTraits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumX2Traits	834.838	314.006	0.998386
SumX2Traits_Tuple	1030.663	254.345	0.808694
SumX2128Traits	1272.318	206.037	0.655097
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	851.758	307.768	0.978553
SumX2_ConstTraits_Tuple	1048.478	250.023	0.794954
SumX2_Const128Traits	1285.594	203.909	0.648332
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	91
SumX2Base	570.634	459.391
SumTraits	567.088	462.263	1.006253
SumX2Traits	570.633	459.392	1.000002
SumX2Traits_Tuple	606.012	432.572	0.941621
SumX2128Traits	828.978	316.226	0.688359
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	592.905	442.135	0.962438
SumX2_ConstTraits_Tuple	628.546	417.064	0.907864
SumX2_Const128Traits	846.390	309.720	0.674198
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-21037
SumX2Base	675.367	388.151
SumTraits	38.822	6752.411	17.396364
SumX2Traits	35.942	7293.431	18.790203
SumX2Traits_Tuple	109.895	2385.412	6.145583
SumX2128_Arm	59.331	4418.345	11.383065
SumX2128Traits	35.964	7289.117	18.779089
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	36.873	7109.313	18.315859
SumX2_ConstTraits_Tuple	109.807	2387.306	6.150461
SumX2_Const128Traits	35.919	7298.123	18.802292
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	2018061718
SumX2Base	685.275	382.539
SumTraits	80.448	3258.557	8.518244
SumX2Traits	71.885	3646.733	9.532980
SumX2Traits_Tuple	224.122	1169.647	3.057592
SumX2128_Arm	118.905	2204.650	5.763209
SumX2128Traits	73.731	3555.413	9.294259
SumX2256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	71.896	3646.163	9.531489
SumX2_ConstTraits_Tuple	222.133	1180.122	3.084975
SumX2_Const128Traits	73.687	3557.540	9.299818
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	5878554485936559874
SumX2Base	768.336	341.184
SumTraits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumX2Traits	224.219	1169.141	3.426719
SumX2Traits_Tuple	575.757	455.304	1.334481
SumX2128_Arm	447.423	585.898	1.717250
SumX2128Traits	226.305	1158.365	3.395135
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	201.898	1298.398	3.805567
SumX2_ConstTraits_Tuple	597.013	439.092	1.286967
SumX2_Const128Traits	202.901	1291.983	3.786763
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	91
SumX2Base	565.654	463.435
SumTraits	22.990	11402.293	24.603874
SumX2Traits	19.241	13624.047	29.397975
SumX2Traits_Tuple	60.568	4328.107	9.339192
SumX2128_Arm	35.876	7306.949	15.766938
SumX2128Traits	19.268	13605.495	29.357944
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	19.272	13602.004	29.350410
SumX2_ConstTraits_Tuple	60.416	4338.972	9.362635
SumX2_Const128Traits	19.258	13612.378	29.372797
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-21037
SumX2Base	676.216	387.663
SumTraits	33.786	7758.899	20.014527
SumX2Traits	30.872	8491.318	21.903843
SumX2Traits_Tuple	91.781	2856.180	7.367680
SumX2128_Arm	49.549	5290.618	13.647454
SumX2128Traits	30.850	8497.303	21.919282
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	33.381	7853.114	20.257558
SumX2_ConstTraits_Tuple	91.738	2857.528	7.371159
SumX2_Const128Traits	30.880	8489.047	21.897984
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	2018061718
SumX2Base	690.670	379.550
SumTraits	69.226	3786.768	9.976981
SumX2Traits	62.478	4195.774	11.054588
SumX2Traits_Tuple	182.275	1438.176	3.789157
SumX2128_Arm	99.442	2636.141	6.945430
SumX2128Traits	62.556	4190.532	11.040777
SumX2256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	67.169	3902.741	10.282536
SumX2_ConstTraits_Tuple	182.344	1437.637	3.787737
SumX2_Const128Traits	63.127	4152.621	10.940893
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	5878554485936559874
SumX2Base	768.437	341.139
SumTraits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumX2Traits	199.209	1315.923	3.857436
SumX2Traits_Tuple	382.396	685.531	2.009534
SumX2128_Arm	415.355	631.132	1.850073
SumX2128Traits	199.357	1314.949	3.854582
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	186.281	1407.251	4.125151
SumX2_ConstTraits_Tuple	386.200	678.778	1.989740
SumX2_Const128Traits	186.371	1406.569	4.123152
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	91
SumX2Base	565.568	463.505
SumTraits	16.754	15646.792	33.757520
SumX2Traits	15.180	17269.240	37.257907
SumX2Traits_Tuple	45.400	5774.097	12.457454
SumX2128_Arm	24.558	10674.420	23.029766
SumX2128Traits	15.460	16956.090	36.582295
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	15.459	16957.249	36.584795
SumX2_ConstTraits_Tuple	45.520	5758.898	12.424663
SumX2_Const128Traits	16.603	15789.288	34.064953
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	-21037
SumX2Base	509.417	514.596
SumTraits	30.525	8587.894	16.688621
SumX2Traits	25.028	10473.897	20.353639
SumX2Traits_Tuple	87.298	3002.847	5.835351
SumX2128_Arm	45.381	5776.533	11.225380
SumX2128Traits	25.117	10437.020	20.281978
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	26.550	9873.619	19.187137
SumX2_ConstTraits_Tuple	89.569	2926.724	5.687423
SumX2_Const128Traits	26.579	9863.005	19.166510
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	2018061718
SumX2Base	663.240	395.248
SumTraits	62.354	4204.140	10.636717
SumX2Traits	51.532	5086.975	12.870342
SumX2Traits_Tuple	176.033	1489.175	3.767698
SumX2128_Arm	91.618	2861.286	7.239220
SumX2128Traits	51.540	5086.267	12.868550
SumX2256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	54.226	4834.265	12.230971
SumX2_ConstTraits_Tuple	179.483	1460.548	3.695271
SumX2_Const128Traits	54.364	4822.017	12.199983
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	5878554485936559874
SumX2Base	562.365	466.145
SumTraits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumX2Traits	173.500	1510.915	3.241296
SumX2Traits_Tuple	368.451	711.475	1.526295
SumX2128_Arm	395.143	663.415	1.423194
SumX2128Traits	173.788	1508.414	3.235931
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	160.332	1635.010	3.507510
SumX2_ConstTraits_Tuple	372.770	703.232	1.508612
SumX2_Const128Traits	160.190	1636.459	3.510619
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumX2Base	91
SumX2Base	410.709	638.272
SumTraits	15.290	17144.533	26.860844
SumX2Traits	12.472	21017.961	32.929456
SumX2Traits_Tuple	43.666	6003.333	9.405598
SumX2128_Arm	22.723	11536.516	18.074599
SumX2128Traits	12.450	21056.394	32.989671
SumX2256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumX2_ConstTraits	13.253	19780.605	30.990854
SumX2_ConstTraits_Tuple	42.960	6102.058	9.560273
SumX2_Const128Traits	13.236	19805.106	31.029241
SumX2_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

