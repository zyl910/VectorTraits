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
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1694.345	154.717
SumNarrow_IfUnrolling4	1639.083	159.933	1.033715
SumNarrow_MinMax	1631.732	160.654	1.038372
SumNarrow_MinMaxUnrolling4	1605.929	163.235	1.055056
SumNarrow_BitMath	1241.988	211.068	1.364220
SumNarrow_BitMathUnrolling4	1257.642	208.441	1.347239
SumNarrowVectorBase	42.802	6124.516	39.585271
SumNarrowVectorTraits	42.798	6125.113	39.589126
SumNarrowVector128Traits	2131.819	122.967	0.794788
SumNarrowVector256Traits	3146.617	83.310	0.538466

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1599.363	163.905
SumNarrow_MinMax	1686.906	155.399	0.948104
SumNarrow_BitMath	1046.052	250.603	1.528952
SumNarrowVectorBase	97.025	2701.810	16.483973
SumNarrowVectorTraits	96.957	2703.709	16.495556
SumNarrowVector128Traits	4045.927	64.792	0.395302
SumNarrowVector256Traits	5970.135	43.909	0.267894

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1618.323	161.985
SumNarrow_MinMax	1699.537	154.244	0.952214
SumNarrow_BitMath	1054.207	248.665	1.535110
SumNarrowVectorBase	365.673	716.880	4.425599
SumNarrowVectorTraits	365.785	716.661	4.424244
SumNarrowVector128Traits	5798.661	45.208	0.279086
SumNarrowVector256Traits	6741.292	38.886	0.240061

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	499.227	525.100
SumNarrow_IfUnrolling4	515.757	508.270	0.967950
SumNarrow_MinMax	496.080	528.430	1.006342
SumNarrow_MinMaxUnrolling4	477.411	549.095	1.045696
SumNarrow_BitMath	797.785	328.590	0.625766
SumNarrow_BitMathUnrolling4	813.462	322.257	0.613706
SumNarrowVectorBase	32.992	7945.777	15.131931
SumNarrowVectorTraits	33.003	7943.115	15.126861
SumNarrowVector128Traits	1352.735	193.788	0.369050
SumNarrowVector256Traits	1857.518	141.126	0.268760

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	481.112	544.871
SumNarrow_MinMax	483.911	541.719	0.994215
SumNarrow_BitMath	709.435	369.511	0.678161
SumNarrowVectorBase	65.510	4001.590	7.344101
SumNarrowVectorTraits	65.229	4018.815	7.375715
SumNarrowVector128Traits	2480.055	105.701	0.193992
SumNarrowVector256Traits	3497.182	74.959	0.137571

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.535	620.408
SumNarrow_MinMax	422.805	620.012	0.999362
SumNarrow_BitMath	672.267	389.940	0.628522
SumNarrowVectorBase	203.047	1291.051	2.080970
SumNarrowVectorTraits	202.585	1293.997	2.085719
SumNarrowVector128Traits	3287.391	79.742	0.128532
SumNarrowVector256Traits	4175.524	62.781	0.101193

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
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1604.804	163.350
SumNarrow_IfUnrolling4	1615.382	162.280	0.993452
SumNarrow_MinMax	1626.909	161.130	0.986413
SumNarrow_MinMaxUnrolling4	1622.368	161.581	0.989174
SumNarrow_BitMath	1583.638	165.533	1.013366
SumNarrow_BitMathUnrolling4	1611.776	162.643	0.995674
SumNarrowVectorBase	50.307	5210.880	31.900185
SumNarrowVectorTraits	19.312	13574.329	83.099898
SumNarrowVector128Traits	19.916	13162.718	80.580081
SumNarrowVector256Traits	3268.582	80.201	0.490979

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1586.347	165.250
SumNarrow_MinMax	1690.608	155.059	0.938329
SumNarrow_BitMath	1348.434	194.406	1.176436
SumNarrowVectorBase	81.429	3219.290	19.481319
SumNarrowVectorTraits	41.570	6306.022	38.160469
SumNarrowVector128Traits	42.539	6162.376	37.291201
SumNarrowVector256Traits	5077.907	51.624	0.312402

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1617.283	162.089
SumNarrow_MinMax	1702.456	153.980	0.949971
SumNarrow_BitMath	1362.689	192.373	1.186832
SumNarrowVectorBase	220.439	1189.192	7.336657
SumNarrowVectorTraits	79.862	3282.455	20.250924
SumNarrowVector128Traits	83.587	3136.169	19.348423
SumNarrowVector256Traits	7704.702	34.024	0.209909

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	494.098	530.550
SumNarrow_IfUnrolling4	515.932	508.098	0.957682
SumNarrow_MinMax	496.950	527.506	0.994261
SumNarrow_MinMaxUnrolling4	485.801	539.612	1.017080
SumNarrow_BitMath	1010.686	259.372	0.488874
SumNarrow_BitMathUnrolling4	1058.267	247.711	0.466894
SumNarrowVectorBase	29.995	8739.615	16.472737
SumNarrowVectorTraits	18.515	14158.586	26.686607
SumNarrowVector128Traits	18.518	14156.330	26.682354
SumNarrowVector256Traits	1730.068	151.522	0.285595

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	485.213	540.266
SumNarrow_MinMax	488.420	536.718	0.993434
SumNarrow_BitMath	918.405	285.434	0.528322
SumNarrowVectorBase	65.169	4022.504	7.445420
SumNarrowVectorTraits	38.411	6824.637	12.632005
SumNarrowVector128Traits	38.463	6815.464	12.615026
SumNarrowVector256Traits	2375.271	110.364	0.204277

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	422.200	620.900
SumNarrow_MinMax	422.945	619.806	0.998238
SumNarrow_BitMath	889.527	294.700	0.474634
SumNarrowVectorBase	140.670	1863.543	3.001357
SumNarrowVectorTraits	81.066	3233.726	5.208124
SumNarrowVector128Traits	81.270	3225.596	5.195030
SumNarrowVector256Traits	3720.313	70.463	0.113485

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
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1664.232	157.517
SumNarrow_IfUnrolling4	1628.646	160.958	1.021850
SumNarrow_MinMax	2412.608	108.656	0.689806
SumNarrow_MinMaxUnrolling4	1775.218	147.669	0.937480
SumNarrow_BitMath	1578.987	166.020	1.053987
SumNarrow_BitMathUnrolling4	1594.236	164.432	1.043905
SumNarrowVectorBase	43.289	6055.721	38.444994
SumNarrowVectorTraits	19.514	13433.471	85.282940
SumNarrowVector128Traits	20.613	12717.414	80.737027
SumNarrowVector256Traits	4430.470	59.168	0.375633

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1634.150	160.416
SumNarrow_MinMax	1647.749	159.092	0.991747
SumNarrow_BitMath	1346.768	194.647	1.213387
SumNarrowVectorBase	94.765	2766.267	17.244319
SumNarrowVectorTraits	42.208	6210.719	38.716303
SumNarrowVector128Traits	42.185	6214.182	38.737889
SumNarrowVector256Traits	5100.212	51.399	0.320408

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1630.200	160.805
SumNarrow_MinMax	1585.400	165.349	1.028258
SumNarrow_BitMath	1360.385	192.698	1.198337
SumNarrowVectorBase	226.645	1156.627	7.192741
SumNarrowVectorTraits	79.825	3283.969	20.422081
SumNarrowVector128Traits	79.727	3288.015	20.447246
SumNarrowVector256Traits	7755.180	33.802	0.210208

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	498.418	525.952
SumNarrow_IfUnrolling4	516.501	507.538	0.964990
SumNarrow_MinMax	486.273	539.088	1.024977
SumNarrow_MinMaxUnrolling4	483.279	542.428	1.031326
SumNarrow_BitMath	1010.398	259.446	0.493289
SumNarrow_BitMathUnrolling4	1049.666	249.740	0.474835
SumNarrowVectorBase	32.991	7945.913	15.107684
SumNarrowVectorTraits	18.505	14166.207	26.934423
SumNarrowVector128Traits	18.525	14150.934	26.905384
SumNarrowVector256Traits	1829.907	143.255	0.272374

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	486.669	538.649
SumNarrow_MinMax	489.286	535.769	0.994652
SumNarrow_BitMath	917.816	285.617	0.530247
SumNarrowVectorBase	66.286	3954.723	7.341923
SumNarrowVectorTraits	40.954	6400.947	11.883324
SumNarrowVector128Traits	38.037	6891.766	12.794529
SumNarrowVector256Traits	2614.252	100.275	0.186160

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	421.402	622.076
SumNarrow_MinMax	421.317	622.201	1.000201
SumNarrow_BitMath	882.303	297.113	0.477616
SumNarrowVectorBase	140.191	1869.904	3.005908
SumNarrowVectorTraits	75.083	3491.369	5.612448
SumNarrowVector128Traits	81.107	3232.074	5.195625
SumNarrowVector256Traits	3629.701	72.222	0.116098

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
Environment.OSVersion:	Unix 5.19.0.1029
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1029-aws #30~22.04.1-Ubuntu SMP Thu Jul 13 17:21:19 UTC 2023
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


[YNarrowSaturateBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	1441.188	181.894
SumNarrow_IfUnrolling4	1406.561	186.372	1.024618
SumNarrow_MinMax	1419.201	184.712	1.015492
SumNarrow_MinMaxUnrolling4	1406.301	186.407	1.024807
SumNarrow_BitMath	1282.035	204.475	1.124141
SumNarrow_BitMathUnrolling4	1274.991	205.605	1.130351
SumNarrowVectorBase	36.584	7165.511	39.393791
SumNarrowVectorTraits	16.904	15507.867	85.257509
SumNarrowVector128Traits	16.919	15494.383	85.183380
SumNarrowVector256Traits	4242.157	61.795	0.339730

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1373.222	190.897
SumNarrow_MinMax	1337.567	195.986	1.026657
SumNarrow_BitMath	1014.959	258.280	1.352983
SumNarrowVectorBase	86.647	3025.432	15.848498
SumNarrowVectorTraits	32.755	8003.142	41.923858
SumNarrowVector128Traits	32.876	7973.790	41.770099
SumNarrowVector256Traits	4538.541	57.760	0.302569

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1276.440	205.371
SumNarrow_MinMax	1330.643	197.005	0.959266
SumNarrow_BitMath	1064.614	246.234	1.198970
SumNarrowVectorBase	213.246	1229.301	5.985756
SumNarrowVectorTraits	66.847	3921.550	19.094944
SumNarrowVector128Traits	65.231	4018.683	19.567910
SumNarrowVector256Traits	4069.181	64.422	0.313685

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	430.487	608.947
SumNarrow_IfUnrolling4	372.718	703.331	1.154996
SumNarrow_MinMax	430.267	609.259	1.000513
SumNarrow_MinMaxUnrolling4	378.186	693.162	1.138296
SumNarrow_BitMath	785.126	333.888	0.548303
SumNarrow_BitMathUnrolling4	786.939	333.118	0.547040
SumNarrowVectorBase	29.400	8916.311	14.642179
SumNarrowVectorTraits	18.977	13814.007	22.685071
SumNarrowVector128Traits	17.998	14565.067	23.918446
SumNarrowVector256Traits	1392.367	188.272	0.309177

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	422.059	621.107
SumNarrow_MinMax	421.851	621.414	1.000494
SumNarrow_BitMath	645.748	405.954	0.653598
SumNarrowVectorBase	59.857	4379.473	7.051077
SumNarrowVectorTraits	38.996	6722.416	10.823284
SumNarrowVector128Traits	39.370	6658.424	10.720255
SumNarrowVector256Traits	1621.123	161.705	0.260350

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	316.249	828.917
SumNarrow_MinMax	316.383	828.565	0.999576
SumNarrow_BitMath	626.708	418.287	0.504619
SumNarrowVectorBase	144.294	1816.732	2.191694
SumNarrowVectorTraits	74.871	3501.256	4.223894
SumNarrowVector128Traits	75.207	3485.648	4.205065
SumNarrowVector256Traits	1746.632	150.085	0.181062

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

