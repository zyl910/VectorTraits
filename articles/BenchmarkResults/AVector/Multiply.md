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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	342.381	765.649
SumBcl	68.388	3833.182	5.006446
SumTraits	68.815	3809.391	4.975372
Sum128Traits	591.957	442.843	0.578388
Sum256Traits	1112.700	235.593	0.307703

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	402.996	650.489
SumBcl	20.570	12744.213	19.591755
SumTraits	20.556	12752.871	19.605066
Sum128Traits	433.235	605.086	0.930202
Sum256Traits	428.804	611.338	0.939814

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	364.179	719.822
SumBcl	40.668	6445.950	8.954919
SumTraits	42.920	6107.703	8.485016
Sum128Traits	741.588	353.490	0.491080
Sum256Traits	756.437	346.551	0.481440

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	337.229	777.348
SumBcl	9.612	27273.217	35.084943
SumBcl_Widen	23.343	11230.083	14.446658
SumTraits	9.576	27374.533	35.215278
Sum128Traits	277.806	943.623	1.213900
Sum256Traits	294.822	889.161	1.143839

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	317.009	826.930
SumBcl	39.621	6616.223	8.000949
SumTraits	39.458	6643.543	8.033986
Sum128Traits	751.635	348.765	0.421759
Sum256Traits	751.444	348.854	0.421866

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	363.906	720.362
SumBcl	35.947	7292.554	10.123463
SumTraits	41.690	6288.001	8.728951
Sum128Traits	717.473	365.371	0.507206
Sum256Traits	761.242	344.363	0.478042

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	796.997	328.914
SumBcl	683.725	383.406	1.165670
SumTraits	683.456	383.557	1.166129
Sum128Traits	589.635	444.587	1.351680
Sum256Traits	1149.235	228.103	0.693502
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	342.211	766.031
SumBcl	68.580	3822.467	4.989966
SumTraits	80.625	3251.397	4.244474
Sum128Traits	68.951	3801.900	4.963117
Sum256Traits	636.699	411.723	0.537476

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	403.053	650.396
SumBcl	20.953	12510.831	19.235717
SumTraits	20.920	12530.809	19.266434
Sum128Traits	19.596	13377.421	20.568121
Sum256Traits	307.415	852.735	1.311102

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	363.984	720.207
SumBcl	43.807	5984.031	8.308766
SumTraits	40.672	6445.327	8.949271
Sum128Traits	42.774	6128.571	8.509458
Sum256Traits	477.553	548.932	0.762186

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	337.289	777.209
SumBcl	9.649	27168.474	34.956451
SumBcl_Widen	21.772	12040.382	15.491816
SumTraits	9.751	26883.131	34.589313
Sum128Traits	9.811	26719.062	34.378212
Sum256Traits	227.408	1152.747	1.483187

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	329.451	795.700
SumBcl	40.277	6508.489	8.179580
SumTraits	43.450	6033.227	7.582292
Sum128Traits	40.653	6448.404	8.104068
Sum256Traits	482.951	542.797	0.682163

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	363.368	721.428
SumBcl	35.992	7283.484	10.095933
SumTraits	41.934	6251.358	8.665261
Sum128Traits	35.956	7290.681	10.105909
Sum256Traits	475.226	551.620	0.764622

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	389.321	673.337
SumBcl	366.407	715.446	1.062538
SumTraits	229.721	1141.141	1.694755
Sum128Traits	229.453	1142.475	1.696736
Sum256Traits	668.973	391.860	0.581968
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	345.543	758.644
SumBcl	82.447	3179.536	4.191077
SumTraits	82.577	3174.551	4.184505
Sum128Traits	82.056	3194.693	4.211056
Sum256Traits	650.797	402.805	0.530953

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	407.597	643.146
SumBcl	21.215	12356.476	19.212559
SumTraits	19.947	13142.016	20.433963
Sum128Traits	21.429	12233.185	19.020861
Sum256Traits	311.343	841.979	1.309158

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	366.540	715.185
SumBcl	43.673	6002.410	8.392809
SumTraits	44.452	5897.187	8.245683
Sum128Traits	43.782	5987.449	8.371890
Sum256Traits	494.490	530.130	0.741249

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	339.734	771.615
SumBcl	10.079	26008.455	33.706513
SumBcl_Widen	21.715	12071.902	15.644978
SumTraits	9.981	26265.614	34.039786
Sum128Traits	10.056	26068.893	33.784839
Sum256Traits	229.472	1142.377	1.480501

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	320.956	816.759
SumBcl	41.183	6365.412	7.793498
SumTraits	40.986	6395.990	7.830937
Sum128Traits	44.026	5954.342	7.290204
Sum256Traits	502.493	521.687	0.638728

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	367.037	714.216
SumBcl	41.585	6303.880	8.826287
SumTraits	42.055	6233.388	8.727590
Sum128Traits	41.647	6294.362	8.812962
Sum256Traits	486.970	538.317	0.753717

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	391.753	669.157
SumBcl	267.893	978.539	1.462346
SumTraits	232.281	1128.562	1.686544
Sum128Traits	231.170	1133.990	1.694654
Sum256Traits	676.206	387.669	0.579339
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	258.489	1014.141
SumBcl	71.668	3657.731	3.606728
SumTraits	71.564	3663.085	3.612007
Sum128Traits	71.843	3648.868	3.597989
Sum256Traits	664.570	394.456	0.388956

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	257.577	1017.731
SumBcl	13.572	19315.192	18.978688
SumTraits	13.592	19287.033	18.951020
Sum128Traits	13.579	19305.500	18.969165
Sum256Traits	443.022	591.718	0.581409

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	184.943	1417.429
SumBcl	30.134	8699.250	6.137346
SumTraits	30.216	8675.644	6.120692
Sum128Traits	30.114	8704.930	6.141354
Sum256Traits	554.239	472.980	0.333689

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	221.666	1182.606
SumBcl	6.912	37928.181	32.071710
SumBcl_Widen	21.610	12130.527	10.257459
SumTraits	6.927	37845.492	32.001789
Sum128Traits	6.896	38012.278	32.142822
Sum256Traits	391.486	669.613	0.566219

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	211.276	1240.768
SumBcl	30.680	8544.382	6.886364
SumTraits	30.535	8584.911	6.919028
Sum128Traits	30.499	8595.274	6.927380
Sum256Traits	498.383	525.989	0.423922

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	184.730	1419.062
SumBcl	38.044	6890.616	4.855753
SumTraits	37.971	6903.825	4.865062
Sum128Traits	38.035	6892.109	4.856806
Sum256Traits	557.371	470.323	0.331432

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	237.072	1105.758
SumBcl	235.272	1114.218	1.007651
SumTraits	235.573	1112.795	1.006364
Sum128Traits	236.017	1110.700	1.004470
Sum256Traits	674.152	388.850	0.351659
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

