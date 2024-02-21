# Benchmark - Multiply
([← Back](README.md))

See [Group](Multiply_Group.md)

## X86

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

