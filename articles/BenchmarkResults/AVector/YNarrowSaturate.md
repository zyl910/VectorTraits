# Benchmark - YNarrowSaturate
([← Back](README.md))

See [Group](YNarrowSaturate_Group.md)

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1233.406	212.537
SumNarrow_IfUnrolling4	1221.919	214.535	1.009401
SumNarrow_MinMax	1268.312	206.687	0.972479
SumNarrow_MinMaxUnrolling4	1279.208	204.927	0.964196
SumNarrow_BitMath	1210.385	216.579	1.019020
SumNarrow_BitMathUnrolling4	835.984	313.575	1.475395
SumNarrowVectorBase	17.657	14846.291	69.852870
SumNarrowVectorTraits	17.596	14897.766	70.095060

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1215.114	215.736
SumNarrow_MinMax	1234.663	212.320	0.984167
SumNarrow_BitMath	594.091	441.252	2.045334
SumNarrowVectorBase	35.490	7386.495	34.238576
SumNarrowVectorTraits	35.651	7353.112	34.083833

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1344.172	195.023
SumNarrow_MinMax	1409.034	186.045	0.953967
SumNarrow_BitMath	772.635	339.286	1.739724
SumNarrowVectorBase	118.514	2211.928	11.341907
SumNarrowVectorTraits	117.735	2226.565	11.416958

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	222.227	1179.622
SumNarrow_IfUnrolling4	241.140	1087.103	0.921569
SumNarrow_MinMax	205.417	1276.156	1.081835
SumNarrow_MinMaxUnrolling4	220.004	1191.541	1.010104
SumNarrow_BitMath	439.266	596.777	0.505905
SumNarrow_BitMathUnrolling4	549.718	476.870	0.404257
SumNarrowVectorBase	16.336	16046.720	13.603275
SumNarrowVectorTraits	16.544	15844.787	13.432090

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	233.768	1121.385
SumNarrow_MinMax	233.264	1123.806	1.002159
SumNarrow_BitMath	503.501	520.642	0.464285
SumNarrowVectorBase	31.125	8422.320	7.510641
SumNarrowVectorTraits	31.005	8454.984	7.539769

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	232.956	1125.294
SumNarrow_MinMax	262.025	1000.454	0.889060
SumNarrow_BitMath	360.256	727.660	0.646640
SumNarrowVectorBase	129.449	2025.081	1.799602
SumNarrowVectorTraits	130.745	2005.004	1.781761

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1216.856	215.427
SumNarrow_IfUnrolling4	1227.266	213.600	0.991518
SumNarrow_MinMax	1226.291	213.770	0.992306
SumNarrow_MinMaxUnrolling4	1201.085	218.256	1.013131
SumNarrow_BitMath	1202.933	217.921	1.011574
SumNarrow_BitMathUnrolling4	834.924	313.974	1.457445
SumNarrowVectorBase	18.609	14087.110	65.391487
SumNarrowVectorTraits	18.512	14160.671	65.732951

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1218.156	215.197
SumNarrow_MinMax	1225.654	213.881	0.993883
SumNarrow_BitMath	593.596	441.620	2.052164
SumNarrowVectorBase	38.825	6751.995	31.375820
SumNarrowVectorTraits	38.765	6762.353	31.423953

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1361.171	192.587
SumNarrow_MinMax	1451.883	180.554	0.937521
SumNarrow_BitMath	772.879	339.179	1.761170
SumNarrowVectorBase	137.102	1912.031	9.928133
SumNarrowVectorTraits	137.165	1911.157	9.923596

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	257.910	1016.416
SumNarrow_IfUnrolling4	241.088	1087.338	1.069777
SumNarrow_MinMax	295.911	885.888	0.871581
SumNarrow_MinMaxUnrolling4	218.982	1197.103	1.177770
SumNarrow_BitMath	438.947	597.211	0.587565
SumNarrow_BitMathUnrolling4	548.632	477.814	0.470097
SumNarrowVectorBase	14.634	17912.836	17.623535
SumNarrowVectorTraits	14.353	18264.191	17.969215

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	279.848	936.738
SumNarrow_MinMax	282.625	927.532	0.990173
SumNarrow_BitMath	491.834	532.992	0.568988
SumNarrowVectorBase	34.478	7603.276	8.116758
SumNarrowVectorTraits	34.439	7611.850	8.125912

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	273.240	959.392
SumNarrow_MinMax	295.697	886.529	0.924053
SumNarrow_BitMath	359.546	729.096	0.759957
SumNarrowVectorBase	127.687	2053.017	2.139915
SumNarrowVectorTraits	127.672	2053.259	2.140168

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1246.928	210.232
SumNarrow_IfUnrolling4	1251.392	209.482	0.996432
SumNarrow_MinMax	1219.894	214.891	1.022161
SumNarrow_MinMaxUnrolling4	1230.423	213.052	1.013413
SumNarrow_BitMath	1194.686	219.425	1.043728
SumNarrow_BitMathUnrolling4	779.163	336.443	1.600341
SumNarrowVectorBase	19.464	13468.290	64.063961
SumNarrowVectorTraits	9.221	28429.208	135.227832
SumNarrowVector128Traits	12.327	21265.910	101.154517
SumNarrowVector256Traits	9.231	28397.933	135.079066

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1214.261	215.888
SumNarrow_MinMax	1245.679	210.443	0.974778
SumNarrow_BitMath	739.428	354.523	1.642162
SumNarrowVectorBase	39.494	6637.639	30.745787
SumNarrowVectorTraits	18.743	13986.307	64.785089
SumNarrowVector128Traits	24.614	10650.155	49.331912
SumNarrowVector256Traits	18.334	14297.940	66.228586

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1292.534	202.814
SumNarrow_MinMax	1346.590	194.672	0.959857
SumNarrow_BitMath	773.866	338.746	1.670230
SumNarrowVectorBase	127.261	2059.889	10.156546
SumNarrowVectorTraits	99.874	2624.759	12.941705
SumNarrowVector128Traits	232.718	1126.444	5.554077
SumNarrowVector256Traits	99.727	2628.627	12.960779

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	241.208	1086.797
SumNarrow_IfUnrolling4	241.131	1087.144	1.000319
SumNarrow_MinMax	268.082	977.852	0.899756
SumNarrow_MinMaxUnrolling4	220.929	1186.553	1.091789
SumNarrow_BitMath	439.255	596.792	0.549129
SumNarrow_BitMathUnrolling4	533.319	491.534	0.452277
SumNarrowVectorBase	16.953	15463.393	14.228410
SumNarrowVectorTraits	11.276	23247.067	21.390441
SumNarrowVector128Traits	16.666	15729.433	14.473202
SumNarrowVector256Traits	11.365	23065.049	21.222959

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	304.097	862.041
SumNarrow_MinMax	308.516	849.694	0.985678
SumNarrow_BitMath	588.634	445.343	0.516615
SumNarrowVectorBase	30.446	8610.053	9.987988
SumNarrowVectorTraits	21.113	12416.410	14.403506
SumNarrowVector128Traits	33.328	7865.636	9.124436
SumNarrowVector256Traits	21.424	12236.051	14.194283

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	232.999	1125.086
SumNarrow_MinMax	262.697	997.897	0.886952
SumNarrow_BitMath	363.732	720.707	0.640579
SumNarrowVectorBase	128.179	2045.137	1.817762
SumNarrowVectorTraits	87.581	2993.174	2.660397
SumNarrowVector128Traits	155.978	1680.652	1.493799
SumNarrowVector256Traits	87.930	2981.285	2.649830

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1295.559	202.340
SumNarrow_IfUnrolling4	1239.471	211.497	1.045251
SumNarrow_MinMax	1216.833	215.431	1.064698
SumNarrow_MinMaxUnrolling4	1207.611	217.077	1.072829
SumNarrow_BitMath	1207.504	217.096	1.072923
SumNarrow_BitMathUnrolling4	1135.439	230.875	1.141020
SumNarrowVectorBase	19.993	13111.910	64.801232
SumNarrowVectorTraits	9.319	28128.607	139.016239
SumNarrowVector128Traits	12.311	21293.082	105.233943
SumNarrowVector256Traits	9.216	28445.982	140.584759

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1231.621	212.845
SumNarrow_MinMax	1225.968	213.826	1.004610
SumNarrow_BitMath	1037.425	252.687	1.187190
SumNarrowVectorBase	38.698	6774.121	31.826578
SumNarrowVectorTraits	18.224	14384.912	67.584049
SumNarrowVector128Traits	24.532	10685.906	50.205161
SumNarrowVector256Traits	18.526	14150.012	66.480430

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1329.593	197.161
SumNarrow_MinMax	1318.750	198.782	1.008222
SumNarrow_BitMath	951.124	275.615	1.397917
SumNarrowVectorBase	121.477	2157.975	10.945240
SumNarrowVectorTraits	92.066	2847.360	14.441796
SumNarrowVector128Traits	140.858	1861.054	9.439256
SumNarrowVector256Traits	92.298	2840.202	14.405491

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	294.282	890.792
SumNarrow_IfUnrolling4	239.085	1096.445	1.230865
SumNarrow_MinMax	285.303	918.826	1.031470
SumNarrow_MinMaxUnrolling4	220.642	1188.095	1.333751
SumNarrow_BitMath	897.603	292.049	0.327853
SumNarrow_BitMathUnrolling4	895.225	292.825	0.328724
SumNarrowVectorBase	15.330	17100.289	19.196718
SumNarrowVectorTraits	10.026	26147.027	29.352551
SumNarrowVector128Traits	14.838	17667.422	19.833379
SumNarrowVector256Traits	9.960	26319.795	29.546500

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	283.592	924.369
SumNarrow_MinMax	284.259	922.200	0.997653
SumNarrow_BitMath	1011.144	259.255	0.280467
SumNarrowVectorBase	31.703	8268.696	8.945229
SumNarrowVectorTraits	24.021	10913.129	11.806026
SumNarrowVector128Traits	29.657	8839.065	9.562265
SumNarrowVector256Traits	22.945	11425.101	12.359886

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	306.314	855.803
SumNarrow_MinMax	233.063	1124.778	1.314295
SumNarrow_BitMath	463.772	565.243	0.660483
SumNarrowVectorBase	101.730	2576.865	3.011050
SumNarrowVectorTraits	75.395	3476.921	4.062760
SumNarrowVector128Traits	119.131	2200.474	2.571240
SumNarrowVector256Traits	75.303	3481.194	4.067752

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1218.814	215.081
SumNarrow_IfUnrolling4	1243.584	210.797	0.980082
SumNarrow_MinMax	1273.235	205.888	0.957257
SumNarrow_MinMaxUnrolling4	1290.553	203.125	0.944412
SumNarrow_BitMath	938.341	279.370	1.298902
SumNarrow_BitMathUnrolling4	941.889	278.317	1.294010
SumNarrowVectorBase	19.806	13235.857	61.538863
SumNarrowVectorTraits	9.243	28360.517	131.859535
SumNarrowVector128Traits	12.384	21167.205	98.414911
SumNarrowVector256Traits	9.221	28427.650	132.171662

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1232.513	212.691
SumNarrow_MinMax	1226.518	213.730	1.004887
SumNarrow_BitMath	1037.824	252.590	1.187593
SumNarrowVectorBase	35.259	7434.739	34.955633
SumNarrowVectorTraits	18.297	14327.294	67.362100
SumNarrowVector128Traits	24.515	10693.391	50.276716
SumNarrowVector256Traits	18.265	14351.983	67.478182

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1335.509	196.288
SumNarrow_MinMax	1349.215	194.294	0.989842
SumNarrow_BitMath	951.031	275.642	1.404276
SumNarrowVectorBase	121.324	2160.685	11.007747
SumNarrowVectorTraits	92.089	2846.629	14.502331
SumNarrowVector128Traits	140.805	1861.747	9.484789
SumNarrowVector256Traits	92.084	2846.789	14.503147

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	290.842	901.329
SumNarrow_IfUnrolling4	237.331	1104.548	1.225467
SumNarrow_MinMax	280.957	933.039	1.035182
SumNarrow_MinMaxUnrolling4	335.364	781.670	0.867242
SumNarrow_BitMath	897.762	291.997	0.323963
SumNarrow_BitMathUnrolling4	895.027	292.890	0.324953
SumNarrowVectorBase	15.461	16955.355	18.811508
SumNarrowVectorTraits	10.075	26019.558	28.867994
SumNarrowVector128Traits	14.535	18035.155	20.009516
SumNarrowVector256Traits	9.831	26664.041	29.583031

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	281.518	931.181
SumNarrow_MinMax	282.943	926.491	0.994963
SumNarrow_BitMath	1013.064	258.764	0.277887
SumNarrowVectorBase	31.769	8251.533	8.861359
SumNarrowVectorTraits	23.360	11221.684	12.051018
SumNarrowVector128Traits	29.179	8983.880	9.647829
SumNarrowVector256Traits	23.262	11269.070	12.101906

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	305.206	858.908
SumNarrow_MinMax	286.731	914.250	1.064433
SumNarrow_BitMath	459.916	569.982	0.663612
SumNarrowVectorBase	100.404	2610.890	3.039779
SumNarrowVectorTraits	74.482	3519.585	4.097745
SumNarrowVector128Traits	136.723	1917.330	2.232289
SumNarrowVector256Traits	73.569	3563.263	4.148599

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1202.140	218.064
SumNarrow_IfUnrolling4	1245.522	210.469	0.965170
SumNarrow_MinMax	1190.652	220.168	1.009649
SumNarrow_MinMaxUnrolling4	1235.481	212.180	0.973014
SumNarrow_BitMath	727.422	360.374	1.652603
SumNarrow_BitMathUnrolling4	775.736	337.929	1.549676
SumNarrowVectorBase	16.852	15555.509	71.334462
SumNarrowVectorTraits	9.223	28421.514	130.335395
SumNarrowVector128Traits	12.228	21438.466	98.312530
SumNarrowVector256Traits	9.171	28585.371	131.086812

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1180.523	222.057
SumNarrow_MinMax	1231.503	212.865	0.958603
SumNarrow_BitMath	603.519	434.359	1.956067
SumNarrowVectorBase	29.479	8892.525	40.046058
SumNarrowVectorTraits	18.169	14428.024	64.974290
SumNarrowVector128Traits	25.740	10184.370	45.863674
SumNarrowVector256Traits	20.163	13000.954	58.547708

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1288.992	203.371
SumNarrow_MinMax	1270.539	206.325	1.014524
SumNarrow_BitMath	607.676	431.388	2.121185
SumNarrowVectorBase	94.252	2781.300	13.675970
SumNarrowVectorTraits	103.221	2539.630	12.487652
SumNarrowVector128Traits	174.911	1498.731	7.369430
SumNarrowVector256Traits	103.277	2538.271	12.480970

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	241.527	1085.363
SumNarrow_IfUnrolling4	236.433	1108.743	1.021542
SumNarrow_MinMax	330.083	794.177	0.731716
SumNarrow_MinMaxUnrolling4	297.509	881.130	0.811830
SumNarrow_BitMath	443.038	591.696	0.545160
SumNarrow_BitMathUnrolling4	436.630	600.380	0.553160
SumNarrowVectorBase	12.886	20342.540	18.742614
SumNarrowVectorTraits	10.509	24943.556	22.981763
SumNarrowVector128Traits	16.748	15652.327	14.421283
SumNarrowVector256Traits	10.535	24883.433	22.926369

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	233.157	1124.325
SumNarrow_MinMax	304.401	861.181	0.765954
SumNarrow_BitMath	385.655	679.738	0.604574
SumNarrowVectorBase	25.404	10319.090	9.178032
SumNarrowVectorTraits	21.072	12440.105	11.064511
SumNarrowVector128Traits	33.522	7819.961	6.955251
SumNarrowVector256Traits	20.785	12612.260	11.217629

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	233.192	1124.154
SumNarrow_MinMax	312.998	837.526	0.745028
SumNarrow_BitMath	395.156	663.393	0.590127
SumNarrowVectorBase	76.967	3405.935	3.029777
SumNarrowVectorTraits	77.112	3399.524	3.024074
SumNarrowVector128Traits	120.023	2184.109	1.942891
SumNarrowVector256Traits	77.241	3393.832	3.019010

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1665.282	157.417
SumNarrow_IfUnrolling4	1639.341	159.908	1.015824
SumNarrow_MinMax	1628.664	160.956	1.022483
SumNarrow_MinMaxUnrolling4	1618.041	162.013	1.029196
SumNarrow_BitMath	1241.922	211.079	1.340891
SumNarrow_BitMathUnrolling4	1257.566	208.453	1.324210
SumNarrowVectorBase	43.369	6044.523	38.398109
SumNarrowVectorTraits	43.407	6039.229	38.364477
SumNarrowVector128Traits	2133.136	122.891	0.780673
SumNarrowVector256Traits	3180.455	82.423	0.523599

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1585.783	165.309
SumNarrow_MinMax	1618.084	162.009	0.980037
SumNarrow_BitMath	1045.480	250.740	1.516798
SumNarrowVectorBase	85.351	3071.364	18.579542
SumNarrowVectorTraits	86.920	3015.939	18.244258
SumNarrowVector128Traits	4038.667	64.909	0.392650
SumNarrowVector256Traits	5819.471	45.046	0.272496

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1613.490	162.470
SumNarrow_MinMax	1699.953	154.207	0.949138
SumNarrow_BitMath	1054.083	248.694	1.530704
SumNarrowVectorBase	366.306	715.642	4.404761
SumNarrowVectorTraits	366.621	715.027	4.400972
SumNarrowVector128Traits	5763.494	45.484	0.279950
SumNarrowVector256Traits	6780.334	38.662	0.237966

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	496.304	528.192
SumNarrow_IfUnrolling4	515.684	508.343	0.962420
SumNarrow_MinMax	455.122	575.986	1.090487
SumNarrow_MinMaxUnrolling4	477.216	549.319	1.039998
SumNarrow_BitMath	797.804	328.582	0.622088
SumNarrow_BitMathUnrolling4	813.325	322.312	0.610217
SumNarrowVectorBase	29.943	8754.855	16.575137
SumNarrowVectorTraits	30.420	8617.492	16.315074
SumNarrowVector128Traits	1353.267	193.712	0.366745
SumNarrowVector256Traits	1832.053	143.088	0.270901

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	484.553	541.002
SumNarrow_MinMax	481.064	544.926	1.007252
SumNarrow_BitMath	708.870	369.806	0.683557
SumNarrowVectorBase	66.209	3959.347	7.318542
SumNarrowVectorTraits	66.269	3955.773	7.311934
SumNarrowVector128Traits	2471.507	106.066	0.196056
SumNarrowVector256Traits	3414.190	76.781	0.141923

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.550	620.385
SumNarrow_MinMax	422.780	620.048	0.999456
SumNarrow_BitMath	672.212	389.972	0.628597
SumNarrowVectorBase	203.578	1287.681	2.075614
SumNarrowVectorTraits	203.747	1286.616	2.073898
SumNarrowVector128Traits	3242.981	80.834	0.130297
SumNarrowVector256Traits	4175.752	62.778	0.101191

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1694.624	154.692
SumNarrow_IfUnrolling4	1653.823	158.508	1.024671
SumNarrow_MinMax	1581.722	165.733	1.071379
SumNarrow_MinMaxUnrolling4	1604.437	163.387	1.056211
SumNarrow_BitMath	1583.953	165.500	1.069870
SumNarrow_BitMathUnrolling4	1611.837	162.637	1.051362
SumNarrowVectorBase	42.323	6193.938	40.040580
SumNarrowVectorTraits	19.475	13460.358	87.014196
SumNarrowVector128Traits	19.520	13429.272	86.813246
SumNarrowVector256Traits	3225.966	81.261	0.525307

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1585.374	165.352
SumNarrow_MinMax	1617.984	162.019	0.979845
SumNarrow_BitMath	1345.535	194.825	1.178248
SumNarrowVectorBase	80.193	3268.933	19.769595
SumNarrowVectorTraits	42.823	6121.553	37.021451
SumNarrowVector128Traits	42.813	6122.989	37.030135
SumNarrowVector256Traits	4891.129	53.596	0.324133

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1631.368	160.690
SumNarrow_MinMax	1662.772	157.655	0.981114
SumNarrow_BitMath	1367.111	191.750	1.193296
SumNarrowVectorBase	226.552	1157.104	7.200864
SumNarrowVectorTraits	84.163	3114.720	19.383452
SumNarrowVector128Traits	84.996	3084.209	19.193577
SumNarrowVector256Traits	7963.162	32.920	0.204864

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	508.943	515.076
SumNarrow_IfUnrolling4	515.835	508.194	0.986639
SumNarrow_MinMax	498.933	525.410	1.020063
SumNarrow_MinMaxUnrolling4	481.064	544.925	1.057951
SumNarrow_BitMath	1010.621	259.389	0.503594
SumNarrow_BitMathUnrolling4	1058.937	247.554	0.480617
SumNarrowVectorBase	31.061	8439.577	16.385123
SumNarrowVectorTraits	20.001	13106.613	25.445998
SumNarrowVector128Traits	20.010	13100.479	25.434088
SumNarrowVector256Traits	1760.020	148.944	0.289169

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	490.247	534.718
SumNarrow_MinMax	488.138	537.029	1.004321
SumNarrow_BitMath	917.617	285.679	0.534261
SumNarrowVectorBase	65.191	4021.154	7.520135
SumNarrowVectorTraits	41.341	6340.994	11.858569
SumNarrowVector128Traits	38.236	6855.859	12.821441
SumNarrowVector256Traits	2475.436	105.898	0.198045

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.051	621.120
SumNarrow_MinMax	422.710	620.151	0.998440
SumNarrow_BitMath	882.894	296.914	0.478031
SumNarrowVectorBase	143.938	1821.232	2.932175
SumNarrowVectorTraits	75.128	3489.303	5.617762
SumNarrowVector128Traits	81.051	3234.292	5.207196
SumNarrowVector256Traits	3737.696	70.135	0.112917

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1666.966	157.258
SumNarrow_IfUnrolling4	1617.078	162.110	1.030851
SumNarrow_MinMax	2415.064	108.545	0.690237
SumNarrow_MinMaxUnrolling4	1784.294	146.918	0.934244
SumNarrow_BitMath	1582.041	165.700	1.053681
SumNarrow_BitMathUnrolling4	1596.018	164.249	1.044453
SumNarrowVectorBase	43.837	5979.916	38.026121
SumNarrowVectorTraits	21.748	12053.732	76.649348
SumNarrowVector128Traits	20.709	12658.154	80.492853
SumNarrowVector256Traits	5405.592	48.495	0.308378

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1543.604	169.826
SumNarrow_MinMax	1708.746	153.413	0.903355
SumNarrow_BitMath	1347.186	194.586	1.145799
SumNarrowVectorBase	83.093	3154.830	18.576845
SumNarrowVectorTraits	42.526	6164.284	36.297663
SumNarrowVector128Traits	42.659	6145.077	36.184563
SumNarrowVector256Traits	5167.005	50.734	0.298743

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1633.810	160.450
SumNarrow_MinMax	1580.886	165.821	1.033477
SumNarrow_BitMath	1363.272	192.290	1.198448
SumNarrowVectorBase	230.436	1137.600	7.090080
SumNarrowVectorTraits	84.159	3114.881	19.413462
SumNarrowVector128Traits	84.983	3084.659	19.225108
SumNarrowVector256Traits	7857.028	33.364	0.207942

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	506.249	517.816
SumNarrow_IfUnrolling4	517.110	506.940	0.978997
SumNarrow_MinMax	456.759	573.922	1.108351
SumNarrow_MinMaxUnrolling4	483.596	542.072	1.046842
SumNarrow_BitMath	1012.556	258.893	0.499971
SumNarrow_BitMathUnrolling4	1052.384	249.095	0.481050
SumNarrowVectorBase	33.393	7850.298	15.160391
SumNarrowVectorTraits	19.449	13478.400	26.029307
SumNarrowVector128Traits	19.448	13479.084	26.030629
SumNarrowVector256Traits	1774.820	147.702	0.285240

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	490.806	534.109
SumNarrow_MinMax	494.815	529.782	0.991898
SumNarrow_BitMath	917.871	285.600	0.534722
SumNarrowVectorBase	62.402	4200.870	7.865193
SumNarrowVectorTraits	41.726	6282.575	11.762722
SumNarrowVector128Traits	39.009	6720.106	12.581902
SumNarrowVector256Traits	2495.518	105.046	0.196675

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	423.938	618.355
SumNarrow_MinMax	424.308	617.816	0.999128
SumNarrow_BitMath	884.775	296.283	0.479147
SumNarrowVectorBase	141.352	1854.543	2.999156
SumNarrowVectorTraits	76.146	3442.668	5.567461
SumNarrowVector128Traits	81.842	3203.035	5.179929
SumNarrowVector256Traits	3600.020	72.817	0.117760

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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1440.815	181.941
SumNarrow_IfUnrolling4	1405.700	186.487	1.024981
SumNarrow_MinMax	1419.995	184.609	1.014662
SumNarrow_MinMaxUnrolling4	1406.922	186.324	1.024090
SumNarrow_BitMath	1275.647	205.499	1.129478
SumNarrow_BitMathUnrolling4	1276.037	205.436	1.129133
SumNarrowVectorBase	38.670	6778.968	37.259061
SumNarrowVectorTraits	16.943	15472.104	85.038917
SumNarrowVector128Traits	17.256	15191.105	83.494471
SumNarrowVector256Traits	4282.214	61.217	0.336465

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1371.861	191.086
SumNarrow_MinMax	1337.883	195.939	1.025397
SumNarrow_BitMath	1010.096	259.524	1.358149
SumNarrowVectorBase	74.714	3508.643	18.361550
SumNarrowVectorTraits	33.795	7756.942	40.593890
SumNarrowVector128Traits	34.194	7666.446	40.120301
SumNarrowVector256Traits	4540.156	57.739	0.302162

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1276.641	205.339
SumNarrow_MinMax	1327.646	197.450	0.961582
SumNarrow_BitMath	1065.359	246.062	1.198320
SumNarrowVectorBase	210.741	1243.915	6.057865
SumNarrowVectorTraits	66.228	3958.193	19.276393
SumNarrowVector128Traits	64.843	4042.758	19.688222
SumNarrowVector256Traits	4076.431	64.307	0.313176

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	430.557	608.849
SumNarrow_IfUnrolling4	373.288	702.256	1.153416
SumNarrow_MinMax	430.777	608.538	0.999490
SumNarrow_MinMaxUnrolling4	378.714	692.196	1.136893
SumNarrow_BitMath	785.872	333.571	0.547871
SumNarrow_BitMathUnrolling4	787.055	333.070	0.547048
SumNarrowVectorBase	29.579	8862.558	14.556252
SumNarrowVectorTraits	18.640	14063.862	23.099100
SumNarrowVector128Traits	18.428	14225.569	23.364694
SumNarrowVector256Traits	1387.054	188.993	0.310411

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	422.334	620.704
SumNarrow_MinMax	422.233	620.851	1.000238
SumNarrow_BitMath	645.835	405.899	0.653934
SumNarrowVectorBase	60.954	4300.706	6.928759
SumNarrowVectorTraits	40.177	6524.682	10.511750
SumNarrowVector128Traits	40.294	6505.829	10.481375
SumNarrowVector256Traits	1638.500	159.990	0.257756

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	316.566	828.085
SumNarrow_MinMax	316.668	827.820	0.999679
SumNarrow_BitMath	626.514	418.417	0.505282
SumNarrowVectorBase	144.701	1811.620	2.187721
SumNarrowVectorTraits	75.086	3491.233	4.216030
SumNarrowVector128Traits	75.261	3483.151	4.206271
SumNarrowVector256Traits	1757.176	149.185	0.180156

```

