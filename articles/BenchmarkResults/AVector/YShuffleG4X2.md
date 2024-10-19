# Benchmark - YShuffleG4X2
([← Back](README.md))

See [Group](YShuffleG4X2_Group.md)

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	281.014	932.849
SumX1Traits	288.777	907.773	0.973119
SumTraits	279.570	937.669	1.005167
SumTraits_Tuple	332.512	788.375	0.845126
Sum_ConstTraits	290.921	901.082	0.965946
Sum_ConstTraits_Tuple	350.646	747.602	0.801418

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	370.051	708.401
SumX1Traits	384.196	682.318	0.963182
SumTraits	373.621	701.631	0.990443
SumTraits_Tuple	465.218	563.486	0.795434
Sum_ConstTraits	380.726	688.537	0.971960
Sum_ConstTraits_Tuple	465.125	563.599	0.795594

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	501.280	522.949
SumX1Traits	481.674	544.235	1.040704
SumTraits	480.115	546.002	1.044083
SumTraits_Tuple	690.598	379.590	0.725864
Sum_ConstTraits	474.904	551.994	1.055540
Sum_ConstTraits_Tuple	672.676	389.703	0.745203

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	284.392	921.770
SumX1Traits	283.565	924.459	1.002918
SumTraits	275.374	951.955	1.032748
SumTraits_Tuple	302.403	866.870	0.940441
Sum_ConstTraits	274.008	956.700	1.037895
Sum_ConstTraits_Tuple	307.507	852.483	0.924833

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	305.856	857.083
SumX1Traits	309.763	846.272	0.987387
SumTraits	303.622	863.389	1.007357
SumTraits_Tuple	359.682	728.822	0.850352
Sum_ConstTraits	305.378	858.425	1.001566
Sum_ConstTraits_Tuple	363.953	720.269	0.840372

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	397.873	658.863
SumX1Traits	393.849	665.595	1.010217
SumTraits	382.220	685.846	1.040955
SumTraits_Tuple	474.840	552.068	0.837910
Sum_ConstTraits	381.803	686.595	1.042091
Sum_ConstTraits_Tuple	475.490	551.314	0.836765

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	486.929	538.362
SumX1Traits	505.371	518.716	0.963507
SumTraits	504.318	519.799	0.965520
SumTraits_Tuple	705.975	371.322	0.689725
Sum_ConstTraits	474.689	552.244	1.025785
Sum_ConstTraits_Tuple	700.286	374.339	0.695329

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	300.646	871.936
SumX1Traits	289.283	906.186	1.039280
SumTraits	293.079	894.447	1.025816
SumTraits_Tuple	332.296	788.888	0.904754
Sum_ConstTraits	312.917	837.742	0.960783
Sum_ConstTraits_Tuple	328.462	798.094	0.915313

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
Check-Sum128Base	Check `Sum128Base` mismatch. -21037!=-30719
SumBase	313.236	836.889
SumX1Traits	12.490	20988.970	25.079739
SumTraits	9.020	29062.897	34.727282
SumTraits_Tuple	9.194	28512.432	34.069530
Sum128Base	605.460	432.967	0.517352
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	9.285	28233.307	33.736003
Sum_ConstTraits	6.710	39070.402	46.685258
Sum_ConstTraits_Tuple	6.756	38801.858	46.364375
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	6.736	38917.102	46.502080

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
Check-Sum128Base	Check `Sum128Base` mismatch. 2018061718!=1670557139
SumBase	381.782	686.634
SumX1Traits	19.823	13224.210	19.259487
SumTraits	17.290	15161.528	22.080960
SumTraits_Tuple	16.931	15483.075	22.549254
Sum128Base	877.175	298.850	0.435240
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	19.736	13282.211	19.343959
Sum256Traits	17.310	15143.842	22.055202
Sum_ConstTraits	13.454	19483.800	28.375834
Sum_ConstTraits_Tuple	13.550	19346.964	28.176548
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	13.492	19430.094	28.297618

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
Check-Sum128Base	Check `Sum128Base` mismatch. 5878554485936559874!=-7093169134606779633
SumBase	482.922	542.829
SumX1Traits	48.212	5437.361	10.016703
SumTraits	39.337	6664.104	12.276609
SumTraits_Tuple	39.088	6706.533	12.354771
Sum128Base	1481.779	176.912	0.325907
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	41.772	6275.586	11.560882
Sum_ConstTraits	28.417	9224.785	16.993894
Sum_ConstTraits_Tuple	28.445	9215.734	16.977221
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	29.177	8984.493	16.551229

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
Check-Sum128Base	Check `Sum128Base` mismatch. 91!=90
SumBase	292.425	896.449
SumX1Traits	5.599	46818.160	52.226242
SumTraits	3.977	65921.580	73.536345
SumTraits_Tuple	4.168	62890.216	70.154821
Sum128Base	473.860	553.210	0.617112
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4.114	63720.486	71.080997
Sum_ConstTraits	4.083	64196.544	71.612045
Sum_ConstTraits_Tuple	3.992	65672.111	73.258059
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	4.088	64128.357	71.535982

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
Check-Sum128Base	Check `Sum128Base` mismatch. -21037!=-30719
SumBase	307.976	851.184
SumX1Traits	10.806	24259.678	28.501109
SumTraits	8.525	30749.699	36.125811
SumTraits_Tuple	8.315	31525.252	37.036958
Sum128Base	603.037	434.706	0.510708
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	8.427	31109.392	36.548390
Sum_ConstTraits	6.636	39501.008	46.407151
Sum_ConstTraits_Tuple	6.816	38461.283	45.185647
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	6.764	38756.603	45.532598

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
Check-Sum128Base	Check `Sum128Base` mismatch. 2018061718!=1670557139
SumBase	379.684	690.427
SumX1Traits	25.033	10471.827	15.167182
SumTraits	18.831	13921.015	20.162918
SumTraits_Tuple	20.325	12897.447	18.680402
Sum128Base	881.183	297.491	0.430880
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	25.308	10358.081	15.002436
Sum256Traits	19.032	13773.854	19.949772
Sum_ConstTraits	13.378	19595.733	28.382064
Sum_ConstTraits_Tuple	13.862	18910.901	27.390168
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	14.430	18166.371	26.311805

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
Check-Sum128Base	Check `Sum128Base` mismatch. 5878554485936559874!=-7093169134606779633
SumBase	493.871	530.794
SumX1Traits	48.639	5389.533	10.153716
SumTraits	38.518	6805.716	12.821762
SumTraits_Tuple	37.210	7044.950	13.272470
Sum128Base	1548.235	169.318	0.318990
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	41.398	6332.355	11.929964
Sum_ConstTraits	28.891	9073.656	17.094491
Sum_ConstTraits_Tuple	28.828	9093.494	17.131865
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	28.474	9206.516	17.344796

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
Check-Sum128Base	Check `Sum128Base` mismatch. 91!=90
SumBase	286.803	914.022
SumX1Traits	5.560	47147.269	51.582229
SumTraits	4.085	64169.644	70.205832
SumTraits_Tuple	4.193	62521.063	68.402176
Sum128Base	484.401	541.171	0.592077
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4.161	62994.811	68.920487
Sum_ConstTraits	4.233	61935.418	67.761441
Sum_ConstTraits_Tuple	4.212	62243.783	68.098813
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	4.146	63223.678	69.170883

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
Check-Sum128Base	Check `Sum128Base` mismatch. -21037!=-30719
SumBase	299.101	876.439
SumX1Traits	9.129	28714.463	32.762648
SumTraits	7.533	34800.021	39.706152
SumTraits_Tuple	7.355	35639.518	40.664001
Sum128Base	605.594	432.871	0.493898
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	7.210	36356.234	41.481760
Sum_ConstTraits	6.784	38643.543	44.091535
Sum_ConstTraits_Tuple	6.862	38203.686	43.589668
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	6.953	37700.343	43.015363

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
Check-Sum128Base	Check `Sum128Base` mismatch. 2018061718!=1670557139
SumBase	384.792	681.261
SumX1Traits	22.480	11661.263	17.117163
SumTraits	17.825	14706.853	21.587678
SumTraits_Tuple	17.310	15144.164	22.229592
Sum128Base	880.717	297.649	0.436908
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	22.476	11663.457	17.120383
Sum256Traits	17.394	15070.801	22.121904
Sum_ConstTraits	13.936	18810.468	27.611232
Sum_ConstTraits_Tuple	13.815	18974.978	27.852710
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	13.769	19039.168	27.946933

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
Check-Sum128Base	Check `Sum128Base` mismatch. 5878554485936559874!=-7093169134606779633
SumBase	482.801	542.965
SumX1Traits	37.848	6926.200	12.756259
SumTraits	32.478	8071.543	14.865683
SumTraits_Tuple	31.855	8229.299	15.156228
Sum128Base	1536.452	170.616	0.314231
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	30.723	8532.363	15.714393
Sum_ConstTraits	28.577	9173.119	16.894499
Sum_ConstTraits_Tuple	27.630	9487.618	17.473723
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	28.370	9240.250	17.018137

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
Check-Sum128Base	Check `Sum128Base` mismatch. 91!=90
SumBase	313.722	835.593
SumX1Traits	4.426	59229.988	70.883738
SumTraits	3.728	70322.789	84.159096
SumTraits_Tuple	3.751	69877.752	83.626495
Sum128Base	515.250	508.771	0.608873
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	3.681	71219.755	85.232543
Sum_ConstTraits	4.026	65116.939	77.928971
Sum_ConstTraits_Tuple	3.887	67444.837	80.714893
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	3.877	67611.717	80.914609

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
Check-Sum128Base	Check `Sum128Base` mismatch. -21037!=-30719
SumBase	311.604	841.274
SumX1Traits	9.227	28411.778	33.772333
SumTraits	7.816	33539.357	39.867351
SumTraits_Tuple	7.421	35323.473	41.988084
Sum128Base	532.552	492.241	0.585114
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	7.628	34364.944	40.848705
Sum_ConstTraits	6.961	37657.209	44.762135
Sum_ConstTraits_Tuple	6.846	38293.013	45.517897
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	7.039	37241.789	44.268335

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
Check-Sum128Base	Check `Sum128Base` mismatch. 2018061718!=1670557139
SumBase	378.386	692.795
SumX1Traits	21.258	12331.832	17.800112
SumTraits	16.924	15489.143	22.357463
SumTraits_Tuple	17.180	15258.950	22.025197
Sum128Base	1027.845	255.042	0.368135
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	20.751	12632.545	18.234170
Sum256Traits	16.754	15646.616	22.584764
Sum_ConstTraits	13.664	19184.438	27.691356
Sum_ConstTraits_Tuple	14.197	18464.753	26.652542
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	13.717	19111.498	27.586072

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
Check-Sum128Base	Check `Sum128Base` mismatch. 5878554485936559874!=-7093169134606779633
SumBase	488.614	536.505
SumX1Traits	43.895	5972.114	11.131515
SumTraits	34.276	7647.959	14.255149
SumTraits_Tuple	34.619	7572.252	14.114038
Sum128Base	587.971	445.845	0.831017
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	34.809	7530.993	14.037134
Sum_ConstTraits	28.801	9101.991	16.965341
Sum_ConstTraits_Tuple	28.661	9146.258	17.047851
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	28.607	9163.501	17.079992

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
Check-Sum128Base	Check `Sum128Base` mismatch. 91!=90
SumBase	283.665	924.133
SumX1Traits	4.227	62022.890	67.114652
SumTraits	3.550	73841.190	79.903174
SumTraits_Tuple	3.687	71101.981	76.939090
Sum128Base	268.199	977.423	1.057665
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	3.639	72043.149	77.957523
Sum_ConstTraits	3.644	71932.872	77.838192
Sum_ConstTraits_Tuple	3.577	73284.557	79.300845
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	3.565	73528.369	79.564672

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
Check-Sum128Base	Check `Sum128Base` mismatch. -21037!=-30719
# Sum_Const512Base	-5514
SumBase	303.389	864.052
SumX1Traits	9.884	26522.605	30.695617
SumTraits	7.547	34734.374	40.199408
SumTraits_Tuple	7.465	35114.181	40.638973
Sum128Base	498.419	525.951	0.608703
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	7.449	35189.646	40.726312
Sum_ConstTraits	6.808	38505.508	44.563885
Sum_ConstTraits_Tuple	6.942	37763.698	43.705359
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	6.908	37945.592	43.915872
Sum_Const512Base	297.432	881.357	1.020027
Sum_Const512Traits	5.794	45244.389	52.363047

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
Check-Sum128Base	Check `Sum128Base` mismatch. 2018061718!=1670557139
# Sum_Const512Base	-1720219647
SumBase	373.792	701.310
SumX1Traits	16.310	16072.444	22.917742
SumTraits	15.429	16990.173	24.226335
SumTraits_Tuple	15.304	17129.397	24.424855
Sum128Base	985.613	265.971	0.379248
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	16.268	16113.826	22.976749
Sum256Traits	15.399	17023.002	24.273146
Sum_ConstTraits	14.566	17996.367	25.661070
Sum_ConstTraits_Tuple	14.075	18624.287	26.556423
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	14.334	18287.944	26.076831
Sum_Const512Base	311.030	842.825	1.201786
Sum_Const512Traits	13.406	19554.420	27.882702

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
Check-Sum128Base	Check `Sum128Base` mismatch. 5878554485936559874!=-7093169134606779633
# Sum_Const512Base	1761590862301453205
SumBase	465.803	562.778
SumX1Traits	39.373	6657.890	11.830392
SumTraits	30.721	8533.007	15.162284
SumTraits_Tuple	30.947	8470.704	15.051579
Sum128Base	535.764	489.290	0.869418
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	31.347	8362.667	14.859608
Sum_ConstTraits	28.484	9203.110	16.352990
Sum_ConstTraits_Tuple	28.503	9197.155	16.342408
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	28.593	9168.055	16.290700
Sum_Const512Base	394.454	664.574	1.180880
Sum_Const512Traits	26.254	9984.934	17.742212

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
Check-Sum128Base	Check `Sum128Base` mismatch. 91!=90
# Sum_Const512Base	-47
SumBase	306.148	856.264
SumX1Traits	3.877	67615.594	78.965791
SumTraits	3.498	74944.981	87.525516
SumTraits_Tuple	3.565	73542.098	85.887140
Sum128Base	248.483	1054.977	1.232069
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum128Traits_Tuple	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	3.596	72898.902	85.135975
Sum_ConstTraits	3.483	75253.882	87.886270
Sum_ConstTraits_Tuple	3.446	76071.745	88.841422
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	3.425	76548.870	89.398639
Sum_Const512Base	299.225	876.075	1.023137
Sum_Const512Traits	3.135	83615.534	97.651539

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	433.749	604.368
SumX1Traits	438.335	598.045	0.989539
SumTraits	446.136	587.588	0.972236
SumTraits_Tuple	467.301	560.975	0.928202
Sum_ConstTraits	435.406	602.068	0.996195
Sum_ConstTraits_Tuple	465.120	563.605	0.932553

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	517.533	506.526
SumX1Traits	526.379	498.014	0.983195
SumTraits	527.264	497.178	0.981545
SumTraits_Tuple	586.212	447.183	0.882844
Sum_ConstTraits	522.304	501.899	0.990865
Sum_ConstTraits_Tuple	586.503	446.961	0.882405

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	504.830	519.272
SumX1Traits	467.843	560.325	1.079058
SumTraits	471.502	555.976	1.070683
SumTraits_Tuple	616.130	425.469	0.819356
Sum_ConstTraits	472.051	555.330	1.069439
Sum_ConstTraits_Tuple	592.837	442.186	0.851549

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	391.507	669.577
SumX1Traits	393.657	665.919	0.994538
SumTraits	393.840	665.610	0.994076
SumTraits_Tuple	409.073	640.824	0.957059
Sum_ConstTraits	392.206	668.384	0.998219
Sum_ConstTraits_Tuple	408.156	642.265	0.959210

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	433.282	605.019
SumX1Traits	433.000	605.413	1.000651
SumTraits	441.044	594.372	0.982403
SumTraits_Tuple	462.849	566.371	0.936121
Sum_ConstTraits	430.272	609.252	1.006997
Sum_ConstTraits_Tuple	460.423	569.355	0.941053

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	517.779	506.285
SumX1Traits	517.125	506.926	1.001266
SumTraits	517.328	506.727	1.000873
SumTraits_Tuple	576.504	454.713	0.898136
Sum_ConstTraits	512.289	511.712	1.010718
Sum_ConstTraits_Tuple	571.990	458.302	0.905225

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	463.847	565.151
SumX1Traits	460.908	568.756	1.006377
SumTraits	464.988	563.765	0.997547
SumTraits_Tuple	586.241	447.161	0.791224
Sum_ConstTraits	429.428	610.450	1.080153
Sum_ConstTraits_Tuple	554.668	472.614	0.836261

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	390.824	670.746
SumX1Traits	391.281	669.964	0.998834
SumTraits	390.808	670.774	1.000041
SumTraits_Tuple	405.995	645.683	0.962634
Sum_ConstTraits	390.601	671.130	1.000572
Sum_ConstTraits_Tuple	404.669	647.798	0.965788

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	433.459	604.772
SumX1Traits	20.274	12930.060	21.380063
SumTraits	13.612	19257.822	31.843119
SumTraits_Tuple	13.581	19302.355	31.916756
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	14.180	18486.745	30.568132
Sum_ConstTraits	12.190	21505.117	35.559059
Sum_ConstTraits_Tuple	11.881	22064.664	36.484278
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	11.480	22835.240	37.758439

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	517.140	506.911
SumX1Traits	40.373	6493.039	12.809027
SumTraits	27.126	9663.801	19.064091
SumTraits_Tuple	28.698	9134.729	18.020374
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	40.654	6448.121	12.720415
Sum256Traits	27.325	9593.401	18.925211
Sum_ConstTraits	19.204	13650.390	26.928563
Sum_ConstTraits_Tuple	19.155	13685.470	26.997768
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	19.274	13600.812	26.830760

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	457.986	572.385
SumX1Traits	79.547	3295.475	5.757446
SumTraits	54.402	4818.673	8.418589
SumTraits_Tuple	53.344	4914.221	8.585519
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	53.337	4914.886	8.586680
Sum_ConstTraits	39.211	6685.522	11.680116
Sum_ConstTraits_Tuple	39.206	6686.245	11.681379
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	38.968	6727.235	11.752992

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	391.835	669.016
SumX1Traits	9.502	27587.913	41.236575
SumTraits	6.594	39753.833	59.421380
SumTraits_Tuple	6.582	39824.855	59.527540
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.583	39821.505	59.522532
Sum_ConstTraits	6.587	39799.662	59.489883
Sum_ConstTraits_Tuple	6.610	39657.481	59.277360
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	6.623	39580.757	59.162678

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	436.040	601.192
SumX1Traits	21.323	12294.010	20.449378
SumTraits	15.714	16682.197	27.748518
SumTraits_Tuple	16.083	16299.193	27.111444
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	16.088	16294.572	27.103758
Sum_ConstTraits	11.785	22244.778	37.001099
Sum_ConstTraits_Tuple	11.432	22931.536	38.143425
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	11.492	22811.077	37.943059

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	523.750	500.513
SumX1Traits	39.865	6575.761	13.138036
SumTraits	26.691	9821.422	19.622701
SumTraits_Tuple	27.346	9586.225	19.152791
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	40.530	6467.938	12.922611
Sum256Traits	27.543	9517.575	19.015632
Sum_ConstTraits	20.204	12974.746	25.922882
Sum_ConstTraits_Tuple	20.203	12975.482	25.924355
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	20.089	13049.137	26.071513

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	481.209	544.761
SumX1Traits	79.489	3297.847	6.053750
SumTraits	53.164	4930.841	9.051384
SumTraits_Tuple	54.350	4823.261	8.853903
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	57.637	4548.164	8.348916
Sum_ConstTraits	40.413	6486.618	11.907274
Sum_ConstTraits_Tuple	40.590	6458.302	11.855295
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	40.320	6501.550	11.934684

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	391.614	669.393
SumX1Traits	9.589	27336.581	40.837840
SumTraits	6.151	42621.456	63.671760
SumTraits_Tuple	6.151	42616.437	63.664263
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.153	42602.583	63.643565
Sum_ConstTraits	6.375	41117.714	61.425336
Sum_ConstTraits_Tuple	6.404	40934.326	61.151374
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	6.289	41680.650	62.266299

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	436.047	601.183
SumX1Traits	13.964	18772.650	31.226194
SumTraits	10.282	25494.812	42.407756
SumTraits_Tuple	10.831	24203.469	40.259752
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.983	23868.968	39.703347
Sum_ConstTraits	11.991	21862.272	36.365435
Sum_ConstTraits_Tuple	11.766	22279.852	37.060032
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	12.425	21098.262	35.094590

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	522.801	501.422
SumX1Traits	27.876	9403.820	18.754301
SumTraits	22.516	11642.613	23.219188
SumTraits_Tuple	22.863	11466.051	22.867067
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	30.504	8593.620	17.138496
Sum256Traits	22.981	11406.760	22.748821
Sum_ConstTraits	20.072	13060.254	26.046430
Sum_ConstTraits_Tuple	19.958	13135.072	26.195642
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	21.043	12457.351	24.844043

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	480.929	545.078
SumX1Traits	55.354	4735.738	8.688182
SumTraits	44.989	5826.852	10.689939
SumTraits_Tuple	46.204	5673.575	10.408738
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	46.953	5583.076	10.242710
Sum_ConstTraits	42.309	6195.988	11.367156
Sum_ConstTraits_Tuple	45.931	5707.375	10.470747
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	40.384	6491.337	11.909004

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	391.959	668.805
SumX1Traits	7.735	33891.346	50.674460
SumTraits	5.169	50719.209	75.835539
SumTraits_Tuple	5.175	50652.042	75.735110
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	5.165	50758.770	75.894691
Sum_ConstTraits	5.219	50227.260	75.099974
Sum_ConstTraits_Tuple	5.485	47794.201	71.462056
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	5.332	49159.909	73.504068

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	362.671	722.814
SumX1Traits	14.077	18621.907	25.763068
SumTraits	10.334	25367.735	35.095797
SumTraits_Tuple	11.489	22816.660	31.566430
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	12.778	20514.835	28.381898
Sum_ConstTraits	12.527	20926.384	28.951269
Sum_ConstTraits_Tuple	12.567	20859.201	28.858323
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	11.966	21906.832	30.307700

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	435.744	601.601
SumX1Traits	25.900	10121.229	16.823812
SumTraits	20.565	12747.287	21.188925
SumTraits_Tuple	21.708	12076.112	20.073276
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	27.931	9385.387	15.600674
Sum256Traits	24.737	10597.180	17.614953
Sum_ConstTraits	21.854	11995.514	19.939304
Sum_ConstTraits_Tuple	21.868	11987.409	19.925833
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	21.464	12213.343	20.301386

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	443.926	590.512
SumX1Traits	55.559	4718.277	7.990142
SumTraits	44.007	5956.913	10.087703
SumTraits_Tuple	44.506	5890.045	9.974468
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	45.571	5752.407	9.741384
Sum_ConstTraits	40.699	6440.999	10.907477
Sum_ConstTraits_Tuple	40.663	6446.679	10.917097
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	40.109	6535.823	11.068056

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	316.303	828.776
SumX1Traits	5.920	44280.087	53.428289
SumTraits	4.292	61080.997	73.700242
SumTraits_Tuple	4.573	57320.647	69.163010
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4.290	61099.128	73.722120
Sum_ConstTraits	4.617	56773.400	68.502702
Sum_ConstTraits_Tuple	4.636	56544.720	68.226777
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	4.871	53815.407	64.933593

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	207.041	1266.145
SumX1Traits	11.483	22828.856	18.030201
SumTraits	10.274	25514.693	20.151472
SumTraits_Tuple	21.989	11921.728	9.415765
Sum128Base	247.089	1060.931	0.837922
Sum128_AdvSimd	16.270	16112.361	12.725522
Sum128Traits	10.277	25507.665	20.145921
Sum128Traits_Tuple	22.029	11900.069	9.398660
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	10.279	25503.530	20.142655
Sum_ConstTraits_Tuple	22.062	11881.957	9.384354
Sum_Const128Traits	10.278	25505.617	20.144303
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	80.102	3272.623
SumX1Traits	22.953	11420.907	3.489833
SumTraits	20.536	12765.153	3.900588
SumTraits_Tuple	44.119	5941.773	1.815600
Sum128Base	200.644	1306.510	0.399224
Sum128_AdvSimd	32.538	8056.450	2.461772
Sum128Traits	20.531	12768.117	3.901494
Sum128Traits_Tuple	44.077	5947.472	1.817341
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	20.531	12768.205	3.901521
Sum_ConstTraits_Tuple	44.219	5928.307	1.811485
Sum_Const128Traits	20.533	12767.220	3.901220
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	263.374	995.330
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	60.332	4345.013	4.365399
SumTraits_Tuple	111.896	2342.740	2.353732
Sum128Base	386.786	677.749	0.680929
Sum128_AdvSimd	113.237	2315.011	2.325873
Sum128Traits	60.335	4344.798	4.365183
Sum128Traits_Tuple	111.962	2341.368	2.352353
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	62.711	4180.220	4.199833
Sum_ConstTraits_Tuple	111.953	2341.544	2.352531
Sum_Const128Traits	62.702	4180.824	4.200440
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	188.770	1388.692
SumX1Traits	5.790	45275.217	32.602776
SumTraits	5.177	50639.522	36.465622
SumTraits_Tuple	11.119	23575.785	16.976971
Sum128Base	231.070	1134.480	0.816941
Sum128_AdvSimd	8.152	32155.494	23.155236
Sum128Traits	5.175	50651.126	36.473978
Sum128Traits_Tuple	11.096	23624.743	17.012225
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	5.176	50644.832	36.469446
Sum_ConstTraits_Tuple	11.116	23581.920	16.981389
Sum_Const128Traits	5.176	50648.761	36.472276
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	129.961	2017.094
SumX1Traits	11.146	23518.214	11.659452
SumTraits	9.771	26829.468	13.301048
SumTraits_Tuple	23.045	11375.207	5.639403
Sum128Base	264.910	989.560	0.490587
Sum128_AdvSimd	15.065	17400.628	8.626581
Sum128Traits	9.769	26834.360	13.303473
Sum128Traits_Tuple	23.046	11374.801	5.639202
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	9.773	26823.701	13.298189
Sum_ConstTraits_Tuple	23.014	11390.594	5.647031
Sum_Const128Traits	9.769	26833.371	13.302983
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	74.670	3510.706
SumX1Traits	21.671	12096.314	3.445550
SumTraits	19.332	13560.104	3.862500
SumTraits_Tuple	47.510	5517.619	1.571655
Sum128Base	530.021	494.591	0.140881
Sum128_AdvSimd	30.134	8699.414	2.477967
Sum128Traits	19.328	13562.594	3.863210
Sum128Traits_Tuple	47.506	5518.168	1.571811
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	19.327	13563.960	3.863599
Sum_ConstTraits_Tuple	47.497	5519.171	1.572097
Sum_Const128Traits	19.349	13548.236	3.859120
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	183.735	1426.754
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	59.979	4370.626	3.063335
SumTraits_Tuple	105.709	2479.855	1.738109
Sum128Base	183.850	1425.859	0.999373
Sum128_AdvSimd	108.914	2406.883	1.686964
Sum128Traits	59.978	4370.687	3.063377
Sum128Traits_Tuple	106.119	2470.290	1.731406
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	59.976	4370.805	3.063460
Sum_ConstTraits_Tuple	106.119	2470.290	1.731405
Sum_Const128Traits	59.974	4370.989	3.063589
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	135.374	1936.440
SumX1Traits	5.451	48093.272	24.835920
SumTraits	4.859	53953.917	27.862425
SumTraits_Tuple	11.170	23469.345	12.119840
Sum128Base	132.529	1978.018	1.021471
Sum128_AdvSimd	7.549	34725.077	17.932430
Sum128Traits	4.860	53935.614	27.852973
Sum128Traits_Tuple	11.166	23476.011	12.123283
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	4.859	53953.044	27.861974
Sum_ConstTraits_Tuple	11.165	23478.810	12.124728
Sum_Const128Traits	4.859	53952.223	27.861550
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
# Sum_Const512Base	-5514
SumBase	128.913	2033.488
SumX1Traits	9.741	26910.156	13.233496
SumTraits	9.650	27164.932	13.358786
SumTraits_Tuple	9.652	27160.534	13.356623
Sum128Base	262.552	998.447	0.491002
Sum128_AdvSimd	10.946	23948.554	11.777081
Sum128Traits	9.648	27170.830	13.361686
Sum128Traits_Tuple	9.650	27165.799	13.359212
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	9.654	27154.820	13.353813
Sum_ConstTraits_Tuple	9.650	27165.108	13.358872
Sum_Const128Traits	9.649	27168.774	13.360675
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	148.997	1759.388	0.865207
Sum_Const512Traits	146.265	1792.255	0.881370

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
# Sum_Const512Base	-1720219647
SumBase	74.666	3510.907
SumX1Traits	19.397	13514.691	3.849344
SumTraits	19.321	13568.031	3.864537
SumTraits_Tuple	19.353	13545.642	3.858160
Sum128Base	525.176	499.155	0.142173
Sum128_AdvSimd	21.885	11978.400	3.411768
Sum128Traits	19.322	13567.261	3.864318
Sum128Traits_Tuple	19.322	13567.360	3.864346
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	19.320	13568.443	3.864654
Sum_ConstTraits_Tuple	19.321	13567.871	3.864491
Sum_Const128Traits	19.321	13567.536	3.864396
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	143.037	1832.706	0.522004
Sum_Const512Traits	142.543	1839.055	0.523812

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
# Sum_Const512Base	1761590862301453205
SumBase	117.638	2228.386
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	51.121	5127.943	2.301191
SumTraits_Tuple	51.115	5128.556	2.301466
Sum128Base	118.419	2213.691	0.993406
Sum128_AdvSimd	99.649	2630.674	1.180529
Sum128Traits	51.125	5127.537	2.301009
Sum128Traits_Tuple	51.123	5127.707	2.301085
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	51.129	5127.101	2.300813
Sum_ConstTraits_Tuple	51.123	5127.666	2.301067
Sum_Const128Traits	51.118	5128.206	2.301309
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	171.733	1526.467	0.685010
Sum_Const512Traits	168.990	1551.242	0.696128

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
# Sum_Const512Base	-47
SumBase	134.432	1950.010
SumX1Traits	4.870	53824.371	27.602104
SumTraits	4.843	54129.662	27.758663
SumTraits_Tuple	4.842	54138.762	27.763329
Sum128Base	131.322	1996.198	1.023686
Sum128_AdvSimd	5.488	47766.135	24.495331
Sum128Traits	4.842	54135.497	27.761655
Sum128Traits_Tuple	4.842	54142.845	27.765423
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	4.843	54127.973	27.757796
Sum_ConstTraits_Tuple	4.842	54135.303	27.761555
Sum_Const128Traits	4.841	54145.715	27.766895
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	160.630	1631.974	0.836906
Sum_Const512Traits	168.826	1552.746	0.796276

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	674.633	388.572
SumX1Traits	674.235	388.802	1.000590
SumTraits	673.955	388.963	1.001006
SumTraits_Tuple	736.741	355.816	0.915700
Sum128Base	1067.284	245.618	0.632103
Sum128Traits	1068.192	245.409	0.631566
Sum128Traits_Tuple	1146.249	228.697	0.588558
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	695.531	376.898	0.969955
Sum_ConstTraits_Tuple	760.044	344.906	0.887624
Sum_Const128Traits	1098.042	238.738	0.614397
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	680.143	385.425
SumX1Traits	681.324	384.757	0.998267
SumTraits	678.699	386.245	1.002127
SumTraits_Tuple	867.954	302.025	0.783616
Sum128Base	1423.595	184.142	0.477764
Sum128Traits	1425.370	183.913	0.477169
Sum128Traits_Tuple	1591.565	164.708	0.427342
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	655.805	399.729	1.037111
Sum_ConstTraits_Tuple	841.364	311.570	0.808381
Sum_Const128Traits	1427.606	183.625	0.476422
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	801.857	326.921
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	803.318	326.327	0.998181
SumTraits_Tuple	978.356	267.943	0.819596
Sum128Base	1169.673	224.117	0.685539
Sum128Traits	1167.779	224.481	0.686651
Sum128Traits_Tuple	1476.663	177.525	0.543019
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	822.129	318.860	0.975342
Sum_ConstTraits_Tuple	984.080	266.385	0.814828
Sum_Const128Traits	1170.791	223.903	0.684884
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	564.874	464.075
SumX1Traits	565.626	463.459	0.998671
SumTraits	565.095	463.894	0.999610
SumTraits_Tuple	599.411	437.336	0.942382
Sum128Base	843.335	310.842	0.669810
Sum128Traits	843.256	310.871	0.669873
Sum128Traits_Tuple	882.991	296.882	0.639728
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	586.247	447.156	0.963542
Sum_ConstTraits_Tuple	620.869	422.221	0.909811
Sum_Const128Traits	862.036	304.099	0.655279
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	676.040	387.764
SumX1Traits	44.164	5935.688	15.307476
SumTraits	36.690	7144.903	18.425908
SumTraits_Tuple	121.685	2154.287	5.555666
Sum128_AdvSimd	71.204	3681.616	9.494477
Sum128Traits	36.725	7137.978	18.408047
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	36.598	7162.871	18.472246
Sum_ConstTraits_Tuple	121.800	2152.246	5.550401
Sum_Const128Traits	36.568	7168.684	18.487236
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	687.770	381.151
SumX1Traits	74.135	3536.042	9.277276
SumTraits	67.567	3879.751	10.179041
SumTraits_Tuple	189.965	1379.956	3.620497
Sum128_AdvSimd	117.831	2224.736	5.836891
Sum128Traits	67.643	3875.407	10.167644
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	67.577	3879.192	10.177576
Sum_ConstTraits_Tuple	224.027	1170.146	3.070034
Sum_Const128Traits	67.593	3878.295	10.175222
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	773.857	338.750
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	216.744	1209.464	3.570375
SumTraits_Tuple	610.319	429.520	1.267955
Sum128_AdvSimd	488.214	536.945	1.585079
Sum128Traits	216.673	1209.861	3.571546
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	217.202	1206.914	3.562848
Sum_ConstTraits_Tuple	609.254	430.271	1.270172
Sum_Const128Traits	217.511	1205.197	3.557779
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	565.391	463.651
SumX1Traits	18.679	14034.527	30.269597
SumTraits	16.896	15515.454	33.463654
SumTraits_Tuple	54.397	4819.098	10.393808
Sum128_AdvSimd	29.567	8866.246	19.122675
Sum128Traits	16.931	15483.485	33.394703
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	16.856	15552.141	33.542779
Sum_ConstTraits_Tuple	55.651	4710.493	10.159568
Sum_Const128Traits	16.902	15509.914	33.451706
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	676.581	387.454
SumX1Traits	31.897	8218.359	21.211193
SumTraits	29.992	8740.520	22.558864
SumTraits_Tuple	88.721	2954.695	7.625928
Sum128Base	1069.086	245.204	0.632860
Sum128_AdvSimd	48.384	5417.959	13.983492
Sum128Traits	29.060	9020.751	23.282127
Sum128Traits_Tuple	88.784	2952.599	7.620517
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	29.956	8751.098	22.586164
Sum_ConstTraits_Tuple	92.210	2842.910	7.337416
Sum_Const128Traits	30.175	8687.564	22.422187
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	684.502	382.970
SumX1Traits	65.427	4006.673	10.462094
SumTraits	60.608	4325.246	11.293942
SumTraits_Tuple	191.249	1370.696	3.579117
Sum128Base	1381.746	189.719	0.495389
Sum128_AdvSimd	97.057	2700.939	7.052604
Sum128Traits	60.338	4344.588	11.344448
Sum128Traits_Tuple	191.319	1370.193	3.577805
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	60.408	4339.523	11.331222
Sum_ConstTraits_Tuple	191.154	1371.375	3.580889
Sum_Const128Traits	60.153	4357.983	11.379425
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	770.468	340.240
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	170.686	1535.823	4.513939
SumTraits_Tuple	416.205	629.843	1.851172
Sum128Base	1146.290	228.689	0.672141
Sum128_AdvSimd	405.615	646.288	1.899507
Sum128Traits	174.712	1500.433	4.409924
Sum128Traits_Tuple	416.138	629.945	1.851472
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	175.577	1493.044	4.388208
Sum_ConstTraits_Tuple	415.099	631.521	1.856104
Sum_Const128Traits	175.695	1492.042	4.385262
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	566.370	462.850
SumX1Traits	16.015	16368.976	35.365651
SumTraits	14.548	18019.755	38.932207
SumTraits_Tuple	46.563	5629.911	12.163588
Sum128Base	846.382	309.723	0.669166
Sum128_AdvSimd	24.260	10805.820	23.346289
Sum128Traits	14.561	18003.254	38.896556
Sum128Traits_Tuple	45.646	5742.993	12.407905
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	15.033	17437.562	37.674362
Sum_ConstTraits_Tuple	47.783	5486.175	11.853041
Sum_Const128Traits	14.995	17482.560	37.771582
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	509.817	514.192
SumX1Traits	29.558	8868.754	17.247929
SumTraits	24.814	10564.249	20.545324
SumTraits_Tuple	91.268	2872.239	5.585923
Sum128Base	810.607	323.392	0.628932
Sum128_AdvSimd	45.387	5775.797	11.232754
Sum128Traits	24.845	10551.366	20.520269
Sum128Traits_Tuple	91.793	2855.831	5.554012
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	26.390	9933.533	19.318709
Sum_ConstTraits_Tuple	92.142	2844.992	5.532933
Sum_Const128Traits	26.386	9935.026	19.321613
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	662.892	395.455
SumX1Traits	61.781	4243.097	10.729654
SumTraits	50.775	5162.812	13.055365
SumTraits_Tuple	181.973	1440.568	3.642810
Sum128Base	1626.403	161.180	0.407582
Sum128_AdvSimd	92.331	2839.176	7.179515
Sum128Traits	50.618	5178.832	13.095876
Sum128Traits_Tuple	180.059	1455.882	3.681535
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	53.570	4893.442	12.374201
Sum_ConstTraits_Tuple	181.461	1444.626	3.653072
Sum_Const128Traits	53.564	4894.059	12.375762
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	604.142	433.911
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	158.888	1649.868	3.802315
SumTraits_Tuple	350.061	748.853	1.725820
Sum128Base	555.421	471.974	1.087719
Sum128_AdvSimd	375.946	697.292	1.606993
Sum128Traits	158.941	1649.320	3.801053
Sum128Traits_Tuple	357.440	733.392	1.690189
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	158.859	1650.172	3.803016
Sum_ConstTraits_Tuple	356.321	735.695	1.695496
Sum_Const128Traits	158.937	1649.360	3.801145
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	411.611	636.873
SumX1Traits	15.218	17226.361	27.048327
SumTraits	12.469	21023.719	33.010828
SumTraits_Tuple	42.818	6122.320	9.613088
Sum128Base	406.381	645.069	1.012869
Sum128_AdvSimd	22.970	11412.385	17.919392
Sum128Traits	12.485	20996.548	32.968164
Sum128Traits_Tuple	43.717	5996.400	9.415372
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	13.246	19790.198	31.073988
Sum_ConstTraits_Tuple	42.850	6117.678	9.605799
Sum_Const128Traits	13.250	19784.806	31.065522
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
# Sum_Const512Base	-5514
SumBase	524.405	499.889
SumX1Traits	23.920	10959.278	21.923428
SumTraits	21.332	12289.034	24.583533
SumTraits_Tuple	21.320	12295.928	24.597324
Sum128Base	807.872	324.487	0.649118
Sum128_AdvSimd	37.848	6926.310	13.855701
Sum128Traits	21.327	12291.394	24.588253
Sum128Traits_Tuple	21.312	12300.414	24.606297
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	21.321	12295.206	24.595879
Sum_ConstTraits_Tuple	21.326	12291.962	24.589390
Sum_Const128Traits	21.311	12301.023	24.607515
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	507.803	516.232	1.032694
Sum_Const512Traits	502.746	521.424	1.043080

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
# Sum_Const512Base	-1720219647
SumBase	642.067	408.281
SumX1Traits	48.633	5390.197	13.202168
SumTraits	43.395	6040.819	14.795733
SumTraits_Tuple	43.298	6054.474	14.829177
Sum128Base	1623.566	161.462	0.395467
Sum128_AdvSimd	75.843	3456.390	8.465710
Sum128Traits	43.388	6041.822	14.798188
Sum128Traits_Tuple	43.375	6043.611	14.802571
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	43.264	6059.206	14.840767
Sum_ConstTraits_Tuple	43.230	6063.987	14.852478
Sum_Const128Traits	43.311	6052.588	14.824557
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	477.024	549.540	1.345985
Sum_Const512Traits	458.319	571.969	1.400919

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
# Sum_Const512Base	1761590862301453205
SumBase	437.381	599.349
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	138.587	1891.549	3.156005
SumTraits_Tuple	138.581	1891.635	3.156149
Sum128Base	546.885	479.340	0.799767
Sum128_AdvSimd	348.558	752.081	1.254829
Sum128Traits	138.292	1895.580	3.162731
Sum128Traits_Tuple	138.681	1890.259	3.153854
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	138.789	1888.801	3.151420
Sum_ConstTraits_Tuple	138.883	1887.523	3.149288
Sum_Const128Traits	138.653	1890.652	3.154509
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	517.973	506.096	0.844410
Sum_Const512Traits	465.259	563.436	0.940080

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
# Sum_Const512Base	-47
SumBase	427.018	613.894
SumX1Traits	17.011	15410.569	25.102985
SumTraits	13.556	19338.464	31.501315
SumTraits_Tuple	13.566	19323.959	31.477686
Sum128Base	427.953	612.553	0.997816
Sum128_AdvSimd	22.392	11706.856	19.069837
Sum128Traits	13.562	19329.970	31.487478
Sum128Traits_Tuple	13.569	19318.673	31.469076
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	13.560	19332.312	31.491292
Sum_ConstTraits_Tuple	13.559	19333.869	31.493828
Sum_Const128Traits	13.553	19341.469	31.506209
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	413.629	633.766	1.032370
Sum_Const512Traits	408.869	641.145	1.044390

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
# Sum_Const512Base	-5514
SumBase	23102.083	11.347
SumX1Traits	2734.635	95.861	8.447957
SumTraits	2370.833	110.570	9.744288
SumTraits_Tuple	4038.281	64.915	5.720771
Sum128Base	3505.729	74.776	6.589808
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1860.807	140.876	12.415086
Sum128Traits_Tuple	3582.031	73.183	6.449437
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	2435.417	107.638	9.485885
Sum_ConstTraits_Tuple	3892.188	67.351	5.935501
Sum_Const128Traits	2003.646	130.834	11.530023
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	23377.083	11.214	0.988236
Sum_Const512Traits	24497.917	10.701	0.943022

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
# Sum_Const512Base	-1720219647
SumBase	26425.000	9.920
SumX1Traits	5390.104	48.634	4.902503
SumTraits	4669.792	56.136	5.658711
SumTraits_Tuple	8103.125	32.351	3.261088
Sum128Base	6922.396	37.869	3.817320
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	3841.146	68.246	6.879458
Sum128Traits_Tuple	10977.083	23.881	2.407288
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	5087.500	51.527	5.194103
Sum_ConstTraits_Tuple	8279.167	31.663	3.191746
Sum_Const128Traits	4189.583	62.570	6.307310
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	34966.667	7.497	0.755720
Sum_Const512Traits	34541.667	7.589	0.765018

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
# Sum_Const512Base	1761590862301453205
SumBase	64975.000	4.035
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	40450.000	6.481	1.606304
SumTraits_Tuple	46916.667	5.587	1.384902
Sum128Base	93416.667	2.806	0.695540
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	16970.833	15.447	3.828628
Sum128Traits_Tuple	30175.000	8.687	2.153273
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	42050.000	6.234	1.545184
Sum_ConstTraits_Tuple	44929.167	5.835	1.446165
Sum_Const128Traits	15409.375	17.012	4.216589
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	91841.667	2.854	0.707468
Sum_Const512Traits	48508.333	5.404	1.339461

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
# Sum_Const512Base	-47
SumBase	19247.917	13.619
SumX1Traits	1404.688	186.621	13.702633
SumTraits	1239.583	211.478	15.527731
SumTraits_Tuple	2011.458	130.325	9.569135
Sum128Base	1818.620	144.144	10.583805
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1004.687	260.921	19.158113
Sum128Traits_Tuple	2505.729	104.618	7.681563
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	1263.542	207.468	15.233306
Sum_ConstTraits_Tuple	2120.833	123.604	9.075639
Sum_Const128Traits	1049.219	249.847	18.344999
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_Const512Base	19531.250	13.422	0.985493
Sum_Const512Traits	19852.083	13.205	0.969567

```

