# Benchmark - YGroup1ToGroup3
([← Back](README.md))

See [Group](YGroup1ToGroup3_Group.md)

- `YGroup1ToGroup3`: Convert a 1-element group, to a 3-element group. It also converts grayscale pixel data to packed RGB pixel data (将1-元素组, 转为3-元素组. 它还能将 灰度像素数据, 转换为 已打包的RGB像素数据).
  Mnemonic: View for group: `(result0, result1, result2) = YGroup3Zip(x, x, x)`. View for element: `element_ref(i, result0, result1, result2) := x[i/3]`.

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
SumBase_Basic	1302.827	201.212
SumBase_Zip	847.135	309.448	1.537920
SumBase	839.909	312.110	1.551153
SumTraits	860.104	304.782	1.514731

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
SumBase_Basic	1672.810	156.709
SumBase_Zip	1022.148	256.464	1.636563
SumBase	1702.338	153.991	0.982655
SumTraits	1606.558	163.171	1.041238

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
SumBase_Basic	2107.478	124.388
SumBase_Zip	1387.965	188.869	1.518394
SumBase	2080.365	126.009	1.013033
SumTraits	2035.862	128.763	1.035177

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
SumBase_Basic	2964.313	88.433
SumBase	3122.456	83.954	0.949353
SumTraits	3045.918	86.064	0.973208

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
SumBase_Basic	459.978	569.905
SumBase_Zip	485.845	539.563	0.946760
SumBase	493.792	530.879	0.931522
SumTraits	495.829	528.698	0.927696

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
SumBase_Basic	612.511	427.982
SumBase_Zip	603.060	434.690	1.015672
SumBase	607.250	431.691	1.008665
SumTraits	624.792	419.570	0.980344

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
SumBase_Basic	981.573	267.065
SumBase_Zip	938.718	279.257	1.045653
SumBase	956.618	274.032	1.026088
SumTraits	963.415	272.099	1.018847

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
SumBase_Basic	1741.435	150.533
SumBase	1685.352	155.543	1.033276
SumTraits	1733.058	151.261	1.004834

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
SumBase_Basic	468.138	559.971
SumBase_Zip	457.900	572.491	1.022359
SumBase	463.448	565.638	1.010120
SumTraits	12.790	20496.271	36.602365
Sum128Base_Basic	966.900	271.118	0.484164
Sum128Base	997.668	262.757	0.469233
Sum128Sse_Shuffle	19.993	13111.956	23.415411
Sum128Sse_Zip	54.707	4791.792	8.557211
Sum128Traits	20.899	12543.228	22.399773
Sum256Base_Basic	848.344	309.007	0.551826
Sum256Base	836.106	313.530	0.559903
Sum256Avx2_Shuffle	12.692	20655.074	36.885957
Sum256Avx2_Zip	28.205	9294.262	16.597750
Sum256Traits	12.535	20912.985	37.346535

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
SumBase_Basic	587.455	446.237
SumBase_Zip	521.404	502.766	1.126679
SumBase	570.131	459.796	1.030385
SumTraits	24.800	10570.534	23.688163
Sum128Base_Basic	1516.236	172.891	0.387443
Sum128Base	1533.377	170.959	0.383112
Sum128Sse_Shuffle	39.836	6580.527	14.746709
Sum128Sse_Zip	110.069	2381.624	5.337128
Sum128Traits	39.506	6635.593	14.870111
Sum256Base_Basic	1143.483	229.251	0.513742
Sum256Base	1150.463	227.860	0.510624
Sum256Avx2_Shuffle	25.789	10165.003	22.779384
Sum256Avx2_Zip	58.915	4449.502	9.971165
Sum256Traits	25.889	10125.689	22.691282

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
SumBase_Basic	823.729	318.241
SumBase_Zip	725.599	361.279	1.135239
SumBase	851.921	307.709	0.966908
SumTraits	44.341	5912.002	18.577146
Sum128Base_Basic	2628.118	99.746	0.313429
Sum128Base	2607.574	100.532	0.315899
Sum128Sse_Shuffle	83.013	3157.854	9.922849
Sum128Sse_Zip	63.798	4108.937	12.911416
Sum128Traits	41.423	6328.526	19.885978
Sum256Base_Basic	1775.973	147.606	0.463818
Sum256Base	1654.824	158.412	0.497774
Sum256Avx2_Shuffle	50.303	5211.255	16.375204
Sum256Avx2_ShuffleXImm	32.244	8130.001	25.546710
Sum256Avx2_Zip	44.131	5940.092	18.665411
Sum256Traits	42.559	6159.607	19.355189

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
SumBase_Basic	1478.702	177.280
SumBase	1438.145	182.279	1.028201
SumTraits	57.759	4538.574	25.601197
Sum128Base_Basic	4893.699	53.568	0.302165
Sum128Base_Move	4113.034	63.735	0.359516
Sum128Base	4082.454	64.212	0.362209
Sum128Sse_Shuffle	126.493	2072.393	11.689957
Sum128Sse_Zip	80.381	3261.265	18.396151
Sum128Traits	72.991	3591.477	20.258811
Sum256Base_Basic	3132.810	83.677	0.472005
Sum256Base	2911.215	90.046	0.507933
Sum256Avx2_Shuffle	78.294	3348.187	18.886463
Sum256Avx2_ShuffleXImm	57.108	4590.304	25.892996
Sum256Avx2_Zip	62.726	4179.180	23.573925
Sum256Traits	56.178	4666.342	26.321910

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
SumBase_Basic	463.236	565.897
SumBase_Zip	507.391	516.651	0.912976
SumBase	522.626	501.590	0.886362
SumTraits	10.510	24942.998	44.076887
Sum128Base_Basic	979.790	267.551	0.472791
Sum128Base	991.776	264.318	0.467077
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	14.744	17779.785	31.418741
Sum128Sse_Zip	38.562	6798.016	12.012805
Sum128Traits	14.324	18301.469	32.340610
Sum256Base_Basic	912.527	287.273	0.507641
Sum256Base	961.120	272.748	0.481975
Sum256Avx2_Shuffle	9.745	26901.184	47.537207
Sum256Avx2_Zip	22.615	11591.582	20.483537
Sum256Traits	9.557	27429.126	48.470135

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
SumBase_Basic	556.655	470.927
SumBase_Zip	694.854	377.265	0.801111
SumBase	790.083	331.793	0.704552
SumTraits	18.934	13845.445	29.400399
Sum128Base_Basic	1560.057	168.035	0.356817
Sum128Base	1553.576	168.736	0.358306
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	28.930	9061.386	19.241590
Sum128Sse_Zip	76.363	3432.849	7.289555
Sum128Traits	29.043	9026.123	19.166708
Sum256Base_Basic	1223.716	214.220	0.454889
Sum256Base	1330.840	196.976	0.418273
Sum256Avx2_Shuffle	18.501	14169.380	30.088266
Sum256Avx2_Zip	42.789	6126.488	13.009419
Sum256Traits	19.784	13250.631	28.137329

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
SumBase_Basic	880.080	297.864
SumBase_Zip	1151.776	227.600	0.764107
SumBase	1330.928	196.963	0.661253
SumTraits	32.671	8023.815	26.937861
Sum128Base_Basic	2599.921	100.828	0.338503
Sum128Base	2616.508	100.188	0.336357
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	60.553	4329.174	14.534069
Sum128Sse_Zip	63.816	4107.796	13.790851
Sum128Traits	44.788	5852.964	19.649798
Sum256Base_Basic	2073.174	126.446	0.424508
Sum256Base	2134.079	122.837	0.412393
Sum256Avx2_Shuffle	39.045	6713.910	22.540197
Sum256Avx2_ShuffleXImm	33.077	7925.183	26.606730
Sum256Avx2_Zip	44.482	5893.323	19.785291
Sum256Traits	32.423	8085.233	27.144057

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
SumBase_Basic	1545.697	169.596
SumBase	2436.912	107.572	0.634285
SumTraits	55.805	4697.509	27.698236
Sum128Base_Basic	4899.266	53.507	0.315496
Sum128Base_Move	4036.648	64.941	0.382916
Sum128Base	4042.944	64.840	0.382320
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Move	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	90.694	2890.429	17.043028
Sum128Sse_Zip	81.492	3216.820	18.967552
Sum128Traits	73.402	3571.370	21.058105
Sum256Base_Basic	3738.003	70.129	0.413509
Sum256Base	3896.011	67.285	0.396738
Sum256Avx2_Shuffle	62.278	4209.277	24.819441
Sum256Avx2_ShuffleXImm	56.335	4653.342	27.437812
Sum256Avx2_Zip	63.505	4127.939	24.339842
Sum256Traits	55.281	4742.007	27.960612

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
SumBase_Basic	453.609	577.907
SumBase_Zip	461.782	567.679	0.982301
SumBase	471.793	555.634	0.961458
SumTraits	9.762	26852.829	46.465628
Sum128Base_Basic	992.882	264.023	0.456861
Sum128Base	968.339	270.715	0.468440
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	14.079	18619.346	32.218563
Sum128Sse_Zip	38.143	6872.608	11.892231
Sum128Traits	14.855	17646.411	30.535015
Sum256Base_Basic	868.405	301.868	0.522347
Sum256Base	859.439	305.018	0.527797
Sum256Avx2_Shuffle	9.665	27122.757	46.932706
Sum256Avx2_Zip	22.970	11412.567	19.748089
Sum256Traits	9.690	27053.606	46.813047

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
SumBase_Basic	545.724	480.360
SumBase_Zip	538.771	486.560	1.012907
SumBase	542.890	482.868	1.005222
SumTraits	19.093	13729.824	28.582377
Sum128Base_Basic	1589.119	164.962	0.343413
Sum128Base	1583.708	165.525	0.344586
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	29.206	8975.554	18.685066
Sum128Sse_Zip	76.336	3434.066	7.148946
Sum128Traits	30.244	8667.774	18.044336
Sum256Base_Basic	1116.839	234.720	0.488633
Sum256Base	1113.395	235.446	0.490144
Sum256Avx2_Shuffle	19.459	13471.905	28.045447
Sum256Avx2_Zip	46.986	5579.248	11.614727
Sum256Traits	19.374	13530.932	28.168328

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
SumBase_Basic	829.729	315.939
SumBase_Zip	733.178	357.545	1.131688
SumBase	811.099	323.196	1.022969
SumTraits	32.143	8155.602	25.813839
Sum128Base_Basic	2617.598	100.147	0.316981
Sum128Base	2619.095	100.090	0.316800
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	59.331	4418.355	13.984828
Sum128Sse_Zip	63.557	4124.548	13.054882
Sum128Traits	41.826	6267.487	19.837641
Sum256Base_Basic	1658.697	158.042	0.500230
Sum256Base	1624.558	161.363	0.510742
Sum256Avx2_Shuffle	41.437	6326.344	20.023933
Sum256Avx2_ShuffleXImm	33.469	7832.520	24.791232
Sum256Avx2_Zip	44.022	5954.808	18.847958
Sum256Traits	31.387	8352.016	26.435521

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
SumBase_Basic	1490.848	175.835
SumBase	1465.580	178.867	1.017241
SumTraits	56.124	4670.839	26.563692
Sum128Base_Basic	4958.043	52.872	0.300693
Sum128Base_Move	4024.097	65.144	0.370480
Sum128Base	4045.749	64.795	0.368498
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Move	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	90.755	2888.482	16.427188
Sum128Sse_Zip	82.802	3165.896	18.004880
Sum128Traits	75.350	3479.028	19.785704
Sum256Base_Basic	2874.694	91.190	0.518611
Sum256Base	2886.016	90.832	0.516577
Sum256Avx2_Shuffle	63.348	4138.127	23.534088
Sum256Avx2_ShuffleXImm	56.683	4624.727	26.301449
Sum256Avx2_Zip	61.438	4266.810	24.265928
Sum256Traits	57.437	4564.062	25.956440

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
SumBase_Basic	543.969	481.910
SumBase_Zip	164.395	1594.596	3.308910
SumBase	165.713	1581.913	3.282590
SumTraits	9.359	28010.644	58.124239
Sum128Base_Basic	555.849	471.610	0.978628
Sum128Base_Shuffle	767.358	341.619	0.708885
Sum128Base_Zip	128.046	2047.259	4.248221
Sum128Base	125.531	2088.283	4.333347
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	13.762	19048.937	39.528008
Sum128Sse_Zip	32.199	8141.345	16.893917
Sum128Traits	13.439	19505.721	40.475870
Sum256Base_Basic	515.016	509.001	1.056217
Sum256Base_Shuffle	708.981	369.747	0.767254
Sum256Base_Zip	82.543	3175.860	6.590153
Sum256Base	83.297	3147.104	6.530483
Sum256Avx2_Shuffle	9.249	28343.458	58.814853
Sum256Avx2_Zip	21.673	12095.607	25.099313
Sum256Traits	9.916	26436.191	54.857129

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
SumBase_Basic	619.265	423.314
SumBase_Zip	239.359	1095.194	2.587187
SumBase	599.811	437.044	1.032434
SumTraits	18.693	14023.718	33.128370
Sum128Base_Basic	823.475	318.339	0.752015
Sum128Base_Shuffle	1585.823	165.305	0.390501
Sum128Base_Zip	180.143	1455.200	3.437635
Sum128Base	767.777	341.432	0.806569
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	26.338	9953.193	23.512529
Sum128Sse_Zip	65.104	4026.535	9.511925
Sum128Traits	26.340	9952.312	23.510447
Sum256Base_Basic	616.687	425.084	1.004180
Sum256Base_Shuffle	1426.393	183.781	0.434148
Sum256Base_Zip	128.030	2047.525	4.836889
Sum256Base	632.920	414.182	0.978426
Sum256Avx2_Shuffle	19.373	13531.276	31.965071
Sum256Avx2_Zip	43.384	6042.465	14.274175
Sum256Traits	18.700	14018.333	33.115651

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
SumBase_Basic	940.070	278.856
SumBase_Zip	468.977	558.970	2.004514
SumBase	932.458	281.132	1.008164
SumTraits	31.178	8408.023	30.151876
Sum128Base_Basic	1329.038	197.243	0.707331
Sum128Base_Shuffle	3119.497	84.034	0.301353
Sum128Base_Zip	318.809	822.260	2.948693
Sum128Base	1361.834	192.493	0.690297
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	53.265	4921.525	17.649000
Sum128Sse_Zip	62.945	4164.632	14.934720
Sum128Traits	45.413	5772.396	20.700298
Sum256Base_Basic	906.227	289.270	1.037345
Sum256Base_Shuffle	2816.674	93.069	0.333752
Sum256Base_Zip	232.851	1125.801	4.037216
Sum256Base	981.674	267.038	0.957620
Sum256Avx2_Shuffle	39.559	6626.700	23.763904
Sum256Avx2_ShuffleXImm	32.835	7983.594	28.629839
Sum256Avx2_Zip	44.893	5839.314	20.940268
Sum256Traits	30.750	8524.874	30.570915

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
SumBase_Basic	1690.822	155.039
SumBase	1656.600	158.242	1.020658
SumTraits	57.820	4533.808	29.242947
Sum128Base_Basic	2335.608	112.238	0.723932
Sum128Base_Move	1714.968	152.857	0.985921
Sum128Base_Shuffle	4052.339	64.690	0.417246
Sum128Base	1703.876	153.852	0.992339
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Move	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Shuffle	77.055	3402.042	21.943084
Sum128Sse_Zip	86.878	3017.366	19.461937
Sum128Traits	75.644	3465.500	22.352386
Sum256Base_Basic	1649.694	158.905	1.024931
Sum256Base_Shuffle	5670.850	46.227	0.298160
Sum256Base	1654.445	158.448	1.021987
Sum256Avx2_Shuffle	66.614	3935.247	25.382244
Sum256Avx2_ShuffleXImm	57.875	4529.503	29.215178
Sum256Avx2_Zip	65.741	3987.515	25.719372
Sum256Traits	57.861	4530.563	29.222018

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
# Sum512Base_Basic	86
SumBase_Basic	398.532	657.775
SumBase_Zip	154.682	1694.728	2.576456
SumBase	154.431	1697.482	2.580642
SumTraits	7.994	32791.571	49.852273
Sum128Base_Basic	444.117	590.259	0.897357
Sum128Base_Shuffle	760.741	344.590	0.523873
Sum128Base_Zip	381.285	687.528	1.045233
Sum128Base	368.802	710.799	1.080611
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	13.646	19210.301	29.204979
Sum128Sse_Zip	25.536	10265.847	15.606932
Sum128Traits	14.272	18367.247	27.923304
Sum256Base_Basic	403.198	650.162	0.988426
Sum256Base_Shuffle	701.482	373.700	0.568128
Sum256Base_Zip	248.187	1056.238	1.605774
Sum256Base	239.189	1095.968	1.666176
Sum256Avx2_Shuffle	9.066	28915.108	43.958976
Sum256Avx2_ShuffleX	7.518	34870.852	53.013357
Sum256Avx2_Zip	12.522	20934.398	31.826084
Sum256Traits	7.574	34609.174	52.615533
Sum512Base_Basic	422.223	620.867	0.943890
Sum512Base_Shuffle	721.874	363.143	0.552079
Sum512Base_Zip	198.720	1319.164	2.005494
Sum512Base	194.621	1346.947	2.047732
Sum512Avx512_ShuffleX	6.010	43617.870	66.311247
Sum512Avx512_Zip	10.341	25351.085	38.540673
Sum512Traits	6.342	41332.581	62.836974

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
# Sum512Base_Basic	-8306
SumBase_Basic	454.860	576.318
SumBase_Zip	231.356	1133.078	1.966066
SumBase	438.539	597.767	1.037217
SumTraits	16.175	16206.470	28.120725
Sum128Base_Basic	594.382	441.036	0.765266
Sum128Base_Shuffle	1609.655	162.857	0.282583
Sum128Base_Zip	396.806	660.635	1.146304
Sum128Base	589.764	444.489	0.771258
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	28.604	9164.452	15.901739
Sum128Sse_Zip	51.254	5114.630	8.874673
Sum128Traits	28.742	9120.436	15.825363
Sum256Base_Basic	454.608	576.638	1.000555
Sum256Base_Shuffle	1441.552	181.848	0.315535
Sum256Base_Zip	350.861	747.146	1.296413
Sum256Base	456.006	574.870	0.997488
Sum256Avx2_Shuffle	18.112	14473.274	25.113364
Sum256Avx2_ShuffleX	15.956	16429.405	28.507552
Sum256Avx2_Zip	25.463	10295.021	17.863449
Sum256Traits	15.992	16392.557	28.443615
Sum512Base_Basic	446.285	587.391	1.019214
Sum512Base_Shuffle	1496.438	175.179	0.303962
Sum512Base_Zip	306.715	854.684	1.483008
Sum512Base	457.893	572.501	0.993377
Sum512Avx512_ShuffleX	14.031	18683.500	32.418755
Sum512Avx512_Zip	22.819	11488.119	19.933659
Sum512Traits	13.914	18840.425	32.691045

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
# Sum512Base_Basic	-1403265138
SumBase_Basic	648.395	404.297
SumBase_Zip	408.056	642.422	1.588986
SumBase	651.106	402.613	0.995836
SumTraits	33.014	7940.467	19.640198
Sum128Base_Basic	942.063	278.266	0.688272
Sum128Base_Shuffle	3140.957	83.460	0.206432
Sum128Base_Zip	237.636	1103.132	2.728520
Sum128Base	941.572	278.411	0.688630
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	56.056	4676.505	11.567012
Sum128Sse_Zip	66.942	3915.989	9.685929
Sum128Traits	44.714	5862.637	14.500828
Sum256Base_Basic	630.911	415.501	1.027712
Sum256Base_Shuffle	2826.834	92.734	0.229372
Sum256Base_Zip	314.403	833.784	2.062308
Sum256Base	632.127	414.701	1.025735
Sum256Avx2_Shuffle	38.530	6803.587	16.828203
Sum256Avx2_ShuffleX	32.731	8008.941	19.809565
Sum256Avx2_ShuffleXImm	33.988	7712.927	19.077394
Sum256Avx2_Zip	46.446	5644.008	13.960066
Sum256Traits	32.404	8089.788	20.009534
Sum512Base_Basic	533.230	491.615	1.215976
Sum512Base_Shuffle	2745.045	95.497	0.236206
Sum512Base_Zip	385.791	679.497	1.680690
Sum512Base	533.562	491.309	1.215219
Sum512Avx512_ShuffleX	28.734	9123.104	22.565369
Sum512Avx512_ShuffleXImm	37.820	6931.441	17.144440
Sum512Avx512_Zip	48.875	5363.607	13.266511
Sum512Traits	28.859	9083.674	22.467842

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
# Sum512Base_Basic	-715627282993526260
SumBase_Basic	1059.820	247.348
SumBase	1031.095	254.239	1.027859
SumTraits	61.761	4244.514	17.160111
Sum128Base_Basic	1757.189	149.184	0.603134
Sum128Base_Move	939.175	279.122	1.128459
Sum128Base_Shuffle	4086.968	64.141	0.259317
Sum128Base	939.287	279.088	1.128324
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Move	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	81.579	3213.388	12.991383
Sum128Sse_Zip	84.686	3095.483	12.514702
Sum128Traits	78.227	3351.049	13.547929
Sum256Base_Basic	1055.581	248.341	1.004016
Sum256Base_Shuffle	5726.077	45.781	0.185087
Sum256Base	1044.207	251.046	1.014952
Sum256Avx2_Shuffle	61.126	4288.609	17.338383
Sum256Avx2_ShuffleX	64.208	4082.735	16.506056
Sum256Avx2_ShuffleXImm	57.424	4565.062	18.456053
Sum256Avx2_Zip	64.037	4093.651	16.550191
Sum256Traits	61.830	4239.783	17.140987
Sum512Base_Basic	830.798	315.533	1.275665
Sum512Base_Shuffle	5632.219	46.544	0.188171
Sum512Base	836.644	313.328	1.266751
Sum512Avx512_ShuffleX	53.702	4881.449	19.735173
Sum512Avx512_ShuffleXImm	65.773	3985.604	16.113368
Sum512Avx512_Zip	73.513	3565.943	14.416725
Sum512Traits	53.436	4905.752	19.833428

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
SumBase_Basic	368.544	711.295
SumBase_Zip	316.202	829.041	1.165536
SumBase	316.184	829.086	1.165601
SumTraits	9.673	27099.355	38.098594
Sum128Base_Basic	574.955	455.939	0.640998
Sum128Base	574.939	455.951	0.641015
Sum128AdvSimd_Shuffle	18.695	14022.513	19.714049
Sum128AdvSimd_Zip	55.413	4730.770	6.650922
Sum128AdvSimdB64_Shuffle	9.668	27114.430	38.119788
Sum128AdvSimdB64_Zip	21.714	12072.611	16.972711
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.669	27110.833	38.114731
Sum256Base_Basic	589.187	444.925	0.625513
Sum256Base	593.033	442.039	0.621457
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	620.066	422.768	0.594363

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
SumBase_Basic	470.289	557.411
SumBase_Zip	393.917	665.480	1.193878
SumBase	460.138	569.708	1.022061
SumTraits	19.303	13580.473	24.363503
Sum128Base_Basic	675.861	387.867	0.695837
Sum128Base	682.760	383.948	0.688806
Sum128AdvSimd_Shuffle	37.367	7015.349	12.585605
Sum128AdvSimd_Zip	110.822	2365.458	4.243655
Sum128AdvSimdB64_Shuffle	19.308	13576.926	24.357139
Sum128AdvSimdB64_Zip	43.400	6040.252	10.836271
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.348	13548.803	24.306685
Sum256Base_Basic	714.341	366.973	0.658353
Sum256Base	711.985	368.188	0.660532
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	711.358	368.512	0.661114

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
SumBase_Basic	661.072	396.544
SumBase_Zip	469.908	557.862	1.406811
SumBase	661.974	396.004	0.998638
SumTraits	38.580	6794.900	17.135308
Sum128Base_Basic	950.230	275.874	0.695697
Sum128Base	935.989	280.072	0.706282
Sum128AdvSimd_Shuffle	74.696	3509.474	8.850156
Sum128AdvSimd_Zip	144.575	1813.200	4.572509
Sum128AdvSimdB64_Shuffle	38.573	6796.050	17.138208
Sum128AdvSimdB64_Zip	67.486	3884.418	9.795684
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.580	6794.822	17.135111
Sum256Base_Basic	1066.611	245.773	0.619788
Sum256Base	1064.905	246.167	0.620780
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1066.520	245.794	0.619840

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
SumBase_Basic	1437.169	182.403
SumBase	1440.809	181.942	0.997474
SumTraits	78.079	3357.413	18.406564
Sum128Base_Basic	1951.570	134.325	0.736417
Sum128Base_Move	588.030	445.801	2.444042
Sum128Base	588.414	445.509	2.442444
Sum128AdvSimd_Shuffle	115.637	2266.956	12.428280
Sum128AdvSimd_Zip	77.806	3369.214	18.471263
Sum128AdvSimdB64_Move	78.090	3356.965	18.404109
Sum128AdvSimdB64_Shuffle	77.118	3399.278	18.636085
Sum128AdvSimdB64_Zip	77.793	3369.780	18.474365
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.090	3356.962	18.404094
Sum256Base_Basic	1919.081	136.599	0.748884
Sum256Base	1907.376	137.437	0.753480
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1905.102	137.601	0.754379

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
SumBase_Basic	341.444	767.751
SumBase_Zip	99.367	2638.149	3.436206
SumBase	99.377	2637.875	3.435849
SumTraits	9.700	27026.176	35.201762
Sum128Base_Basic	341.472	767.689	0.999919
Sum128Base_Shuffle	389.634	672.796	0.876321
Sum128Base_Zip	81.152	3230.266	4.207441
Sum128Base	81.131	3231.140	4.208579
Sum128AdvSimd_Shuffle	18.311	14316.149	18.646873
Sum128AdvSimd_Zip	54.758	4787.301	6.235489
Sum128AdvSimdB64_Shuffle	9.701	27022.407	35.196853
Sum128AdvSimdB64_Zip	21.719	12070.029	15.721288
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.700	27025.958	35.201478
Sum256Base_Basic	689.932	379.956	0.494895
Sum256Base_Shuffle	1014.049	258.512	0.336714
Sum256Base_Zip	581.023	451.177	0.587660
Sum256Base	690.424	379.686	0.494543
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	691.001	379.368	0.494130

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
SumBase_Basic	420.438	623.502
SumBase_Zip	183.457	1428.912	2.291751
SumBase	419.339	625.137	1.002621
SumTraits	19.378	13527.752	21.696396
Sum128Base_Basic	418.735	626.038	1.004067
Sum128Base_Shuffle	779.328	336.372	0.539488
Sum128Base_Zip	116.988	2240.782	3.593863
Sum128Base	419.393	625.056	1.002491
Sum128AdvSimd_Shuffle	36.587	7165.037	11.491598
Sum128AdvSimd_Zip	109.460	2394.876	3.841006
Sum128AdvSimdB64_Shuffle	19.381	13525.622	21.692981
Sum128AdvSimdB64_Zip	43.402	6039.878	9.687019
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.382	13525.378	21.692589
Sum256Base_Basic	791.260	331.299	0.531352
Sum256Base_Shuffle	1812.604	144.623	0.231952
Sum256Base_Zip	909.293	288.294	0.462379
Sum256Base	796.047	329.307	0.528157
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	796.767	329.009	0.527680

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
SumBase_Basic	602.211	435.302
SumBase_Zip	217.427	1205.663	2.769713
SumBase	602.455	435.126	0.999595
SumTraits	38.731	6768.263	15.548419
Sum128Base_Basic	599.805	437.049	1.004012
Sum128Base_Shuffle	1558.793	168.171	0.386332
Sum128Base_Zip	144.643	1812.350	4.163427
Sum128Base	601.773	435.619	1.000728
Sum128AdvSimd_Shuffle	73.180	3582.178	8.229173
Sum128AdvSimd_Zip	144.647	1812.298	4.163307
Sum128AdvSimdB64_Shuffle	38.726	6769.192	15.550552
Sum128AdvSimdB64_Zip	67.466	3885.557	8.926111
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.732	6768.202	15.548279
Sum256Base_Basic	1022.234	256.442	0.589113
Sum256Base_Shuffle	3324.595	78.850	0.181138
Sum256Base_Zip	1377.362	190.323	0.437221
Sum256Base	1019.827	257.048	0.590503
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1021.523	256.621	0.589523

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
SumBase_Basic	1342.060	195.330
SumBase	1340.702	195.527	1.001014
SumTraits	77.944	3363.223	17.218200
Sum128Base_Basic	1337.074	196.058	1.003730
Sum128Base_Move	77.215	3394.989	17.380828
Sum128Base_Shuffle	2095.958	125.071	0.640309
Sum128Base	77.228	3394.429	17.377962
Sum128AdvSimd_Shuffle	106.887	2452.523	12.555824
Sum128AdvSimd_Zip	77.704	3373.619	17.271424
Sum128AdvSimdB64_Move	77.957	3362.679	17.215416
Sum128AdvSimdB64_Shuffle	77.137	3398.402	17.398301
Sum128AdvSimdB64_Zip	77.704	3373.630	17.271479
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.953	3362.838	17.216231
Sum256Base_Basic	1715.589	152.801	0.782274
Sum256Base_Shuffle	6586.991	39.797	0.203744
Sum256Base	1718.498	152.543	0.780950
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1716.765	152.696	0.781738

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
# Sum512Base_Basic	86
SumBase_Basic	282.822	926.887
SumBase_Zip	100.231	2615.393	2.821696
SumBase	100.257	2614.729	2.820979
SumTraits	9.686	27063.402	29.198172
Sum128Base_Basic	283.013	926.260	0.999324
Sum128Base_Shuffle	389.630	672.803	0.725873
Sum128Base_Zip	139.074	1884.924	2.033608
Sum128Base	137.646	1904.481	2.054707
Sum128AdvSimd_Shuffle	18.321	14308.316	15.436961
Sum128AdvSimd_Zip	30.129	8700.760	9.387079
Sum128AdvSimdB64_Shuffle	9.660	27136.482	29.277017
Sum128AdvSimdB64_Zip	15.681	16717.159	18.035814
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.659	27140.054	29.280871
Sum256Base_Basic	281.854	930.070	1.003434
Sum256Base_Shuffle	772.743	339.238	0.365997
Sum256Base_Zip	151.234	1733.363	1.870091
Sum256Base	284.047	922.888	0.995686
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	284.081	922.780	0.995569
Sum512Base_Basic	312.812	838.023	0.904126
Sum512Base_Shuffle	685.018	382.682	0.412868
Sum512Base_Zip	198.977	1317.458	1.421380
Sum512Base	292.120	897.385	0.968171
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	292.050	897.599	0.968402

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
# Sum512Base_Basic	-8306
SumBase_Basic	301.108	870.597
SumBase_Zip	186.054	1408.964	1.618387
SumBase	299.057	876.568	1.006857
SumTraits	19.361	13539.665	15.552153
Sum128Base_Basic	300.921	871.140	1.000624
Sum128Base_Shuffle	779.244	336.408	0.386410
Sum128Base_Zip	161.931	1618.859	1.859481
Sum128Base	299.048	876.595	1.006889
Sum128AdvSimd_Shuffle	36.629	7156.675	8.220418
Sum128AdvSimd_Zip	60.229	4352.483	4.999421
Sum128AdvSimdB64_Shuffle	19.313	13573.173	15.590642
Sum128AdvSimdB64_Zip	31.336	8365.533	9.608956
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.309	13576.243	15.594169
Sum256Base_Basic	299.191	876.175	1.006407
Sum256Base_Shuffle	855.106	306.563	0.352130
Sum256Base_Zip	327.039	801.567	0.920709
Sum256Base	301.116	870.574	0.999973
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	301.147	870.484	0.999870
Sum512Base_Basic	323.872	809.407	0.929714
Sum512Base_Shuffle	1377.120	190.357	0.218651
Sum512Base_Zip	424.753	617.168	0.708902
Sum512Base	323.227	811.022	0.931569
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	324.574	807.656	0.927704

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
# Sum512Base_Basic	-1403265138
SumBase_Basic	361.478	725.199
SumBase_Zip	221.200	1185.101	1.634173
SumBase	361.483	725.191	0.999988
SumTraits	38.723	6769.722	9.334980
Sum128Base_Basic	361.512	725.133	0.999908
Sum128Base_Shuffle	1558.605	168.191	0.231924
Sum128Base_Zip	136.617	1918.821	2.645922
Sum128Base	361.525	725.107	0.999873
Sum128AdvSimd_Shuffle	73.207	3580.869	4.937772
Sum128AdvSimd_Zip	120.443	2176.490	3.001230
Sum128AdvSimdB64_Shuffle	38.616	6788.508	9.360885
Sum128AdvSimdB64_Zip	62.644	4184.695	5.770406
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.609	6789.677	9.362496
Sum256Base_Basic	333.064	787.068	1.085313
Sum256Base_Shuffle	1711.176	153.195	0.211246
Sum256Base_Zip	515.830	508.199	0.700771
Sum256Base	333.022	787.167	1.085448
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	332.930	787.385	1.085750
Sum512Base_Basic	380.182	689.522	0.950803
Sum512Base_Shuffle	2680.355	97.802	0.134862
Sum512Base_Zip	845.273	310.130	0.427647
Sum512Base	379.462	690.830	0.952607
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	380.507	688.934	0.949992

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
# Sum512Base_Basic	-715627282993526260
SumBase_Basic	444.420	589.856
SumBase	446.195	587.510	0.996023
SumTraits	77.955	3362.746	5.700957
Sum128Base_Basic	444.385	589.903	1.000078
Sum128Base_Move	77.821	3368.530	5.710764
Sum128Base_Shuffle	2095.671	125.088	0.212066
Sum128Base	77.848	3367.402	5.708850
Sum128AdvSimd_Shuffle	106.881	2452.673	4.158085
Sum128AdvSimd_Zip	77.408	3386.520	5.741263
Sum128AdvSimdB64_Move	78.150	3354.361	5.686743
Sum128AdvSimdB64_Shuffle	77.123	3399.037	5.762482
Sum128AdvSimdB64_Zip	77.396	3387.035	5.742136
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	78.141	3354.745	5.687393
Sum256Base_Basic	501.797	522.411	0.885658
Sum256Base_Shuffle	3309.529	79.209	0.134285
Sum256Base	500.140	524.141	0.888592
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	500.026	524.260	0.888793
Sum512Base_Basic	510.450	513.555	0.870644
Sum512Base_Shuffle	5509.611	47.579	0.080663
Sum512Base	510.097	513.910	0.871246
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	516.391	507.647	0.860628

```

### AWS Arm t4g.small
`Neoverse-N1`

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
SumBase_Basic	994.723	263.535
SumBase_Zip	939.817	278.931	1.058422
SumBase	940.005	278.875	1.058210
SumTraits	939.400	279.055	1.058892
Sum128Base_Basic	1759.281	149.006	0.565414
Sum128Base	1766.426	148.404	0.563127
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1760.594	148.895	0.564993
Sum256Base_Basic	1722.639	152.176	0.577441
Sum256Base	1736.958	150.921	0.572681
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1999.839	131.083	0.497401

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
SumBase_Basic	1253.973	209.051
SumBase_Zip	1201.734	218.138	1.043470
SumBase	1264.558	207.301	0.991630
SumTraits	1269.326	206.522	0.987905
Sum128Base_Basic	2356.600	111.238	0.532111
Sum128Base	2351.594	111.475	0.533244
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2349.007	111.598	0.533831
Sum256Base_Basic	2593.756	101.067	0.483458
Sum256Base	2634.376	99.509	0.476004
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3206.990	81.741	0.391012

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
SumBase_Basic	1752.227	149.606
SumBase_Zip	1428.363	183.528	1.226737
SumBase	1724.079	152.049	1.016326
SumTraits	1720.515	152.364	1.018431
Sum128Base_Basic	3536.976	74.115	0.495402
Sum128Base	3555.800	73.723	0.492780
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	3534.735	74.162	0.495716
Sum256Base_Basic	4374.709	59.923	0.400536
Sum256Base	4458.124	58.801	0.393041
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	5490.476	47.745	0.319139

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
SumBase_Basic	2514.268	104.263
SumBase	2514.358	104.259	0.999964
SumTraits	2516.864	104.155	0.998969
Sum128Base_Basic	3740.498	70.083	0.672175
Sum128Base_Move	2354.517	111.337	1.067849
Sum128Base	2328.825	112.565	1.079629
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2371.248	110.551	1.060314
Sum256Base_Basic	6860.204	38.212	0.366500
Sum256Base	7084.940	37.000	0.354875
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	9662.105	27.131	0.260219

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
SumBase_Basic	978.019	268.036
SumBase_Zip	934.982	280.373	1.046030
SumBase	932.194	281.212	1.049159
SumTraits	26.652	9835.776	36.695775
Sum128Base_Basic	1745.286	150.201	0.560378
Sum128Base	1745.811	150.156	0.560209
Sum128AdvSimd_Shuffle	72.015	3640.120	13.580729
Sum128AdvSimd_Zip	182.750	1434.441	5.351681
Sum128AdvSimdB64_Shuffle	26.660	9832.696	36.684282
Sum128AdvSimdB64_Zip	77.663	3375.409	12.593134
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	26.939	9731.111	36.305286
Sum256Base_Basic	1655.631	158.335	0.590723
Sum256Base	1664.027	157.536	0.587742
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1714.486	152.899	0.570444

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
SumBase_Basic	1230.903	212.969
SumBase_Zip	1207.559	217.086	1.019332
SumBase	1238.105	211.730	0.994183
SumTraits	54.841	4780.104	22.445087
Sum128Base_Basic	2345.143	111.782	0.524873
Sum128Base	2349.497	111.575	0.523901
Sum128AdvSimd_Shuffle	134.581	1947.854	9.146195
Sum128AdvSimd_Zip	376.852	695.614	3.266273
Sum128AdvSimdB64_Shuffle	55.324	4738.337	22.248971
Sum128AdvSimdB64_Zip	156.392	1676.201	7.870643
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	60.668	4320.930	20.289027
Sum256Base_Basic	2140.031	122.495	0.575180
Sum256Base	2177.130	120.408	0.565379
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2182.556	120.109	0.563973

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
SumBase_Basic	1725.318	151.940
SumBase_Zip	1478.656	177.285	1.166815
SumBase	1720.245	152.388	1.002949
SumTraits	112.953	2320.831	15.274698
Sum128Base_Basic	3558.195	73.673	0.484886
Sum128Base	3567.789	73.475	0.483582
Sum128AdvSimd_Shuffle	253.624	1033.593	6.802657
Sum128AdvSimd_Zip	517.147	506.905	3.336226
Sum128AdvSimdB64_Shuffle	110.077	2381.454	15.673695
Sum128AdvSimdB64_Zip	269.674	972.077	6.397790
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	108.854	2408.217	15.849836
Sum256Base_Basic	3348.411	78.289	0.515265
Sum256Base	3465.589	75.642	0.497843
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3458.839	75.790	0.498814

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
SumBase_Basic	2599.073	100.861
SumBase	2589.660	101.227	1.003635
SumTraits	176.146	1488.224	14.755260
Sum128Base_Basic	3869.585	67.745	0.671667
Sum128Base_Move	1526.428	171.737	1.702715
Sum128Base	1514.898	173.044	1.715675
Sum128AdvSimd_Shuffle	373.223	702.378	6.963853
Sum128AdvSimd_Zip	251.118	1043.906	10.349989
Sum128AdvSimdB64_Move	176.614	1484.275	14.716109
Sum128AdvSimdB64_Shuffle	192.152	1364.253	13.526127
Sum128AdvSimdB64_Zip	253.675	1033.383	10.245660
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	178.063	1472.196	14.596343
Sum256Base_Basic	4736.931	55.340	0.548683
Sum256Base	4851.442	54.034	0.535732
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4883.841	53.676	0.532178

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
SumBase_Basic	989.968	264.801
SumBase_Zip	930.580	281.700	1.063818
SumBase	931.459	281.434	1.062814
SumTraits	26.874	9754.413	36.836833
Sum128Base_Basic	1739.249	150.723	0.569193
Sum128Base	1741.851	150.497	0.568342
Sum128AdvSimd_Shuffle	65.345	4011.689	15.149853
Sum128AdvSimd_Zip	181.111	1447.421	5.466078
Sum128AdvSimdB64_Shuffle	26.819	9774.721	36.913524
Sum128AdvSimdB64_Zip	72.687	3606.464	13.619550
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	26.575	9864.138	37.251199
Sum256Base_Basic	1653.347	158.553	0.598766
Sum256Base	1657.881	158.120	0.597128
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1710.828	153.226	0.578648

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
SumBase_Basic	1224.800	214.030
SumBase_Zip	1195.770	219.226	1.024278
SumBase	1238.154	211.722	0.989215
SumTraits	55.292	4741.043	22.151296
Sum128Base_Basic	2360.043	111.076	0.518974
Sum128Base	2356.763	111.231	0.519696
Sum128AdvSimd_Shuffle	137.254	1909.914	8.923581
Sum128AdvSimd_Zip	371.360	705.902	3.298144
Sum128AdvSimdB64_Shuffle	55.835	4694.937	21.935881
Sum128AdvSimdB64_Zip	143.374	1828.396	8.542707
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	55.532	4720.567	22.055629
Sum256Base_Basic	2209.017	118.670	0.554455
Sum256Base	2198.096	119.260	0.557210
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2192.304	119.575	0.558682

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
SumBase_Basic	1713.321	153.003
SumBase_Zip	1458.431	179.744	1.174769
SumBase	1727.085	151.784	0.992030
SumTraits	112.110	2338.269	15.282454
Sum128Base_Basic	3556.290	73.713	0.481772
Sum128Base	3562.162	73.591	0.480978
Sum128AdvSimd_Shuffle	253.516	1034.034	6.758238
Sum128AdvSimd_Zip	515.113	508.906	3.326106
Sum128AdvSimdB64_Shuffle	113.776	2304.038	15.058729
Sum128AdvSimdB64_Zip	271.423	965.813	6.312359
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	112.659	2326.887	15.208068
Sum256Base_Basic	3371.107	77.762	0.508237
Sum256Base	3377.626	77.612	0.507256
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3374.078	77.694	0.507789

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
SumBase_Basic	2531.586	103.549
SumBase	2539.328	103.234	0.996951
SumTraits	177.662	1475.517	14.249414
Sum128Base_Basic	3627.570	72.264	0.697874
Sum128Base_Move	1587.761	165.103	1.594437
Sum128Base	1575.349	166.404	1.607000
Sum128AdvSimd_Shuffle	369.961	708.572	6.842845
Sum128AdvSimd_Zip	254.897	1028.431	9.931798
Sum128AdvSimdB64_Move	176.019	1489.293	14.382446
Sum128AdvSimdB64_Shuffle	196.422	1334.597	12.888513
Sum128AdvSimdB64_Zip	257.387	1018.483	9.835732
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	179.587	1459.702	14.096686
Sum256Base_Basic	4869.223	53.837	0.519916
Sum256Base	4742.465	55.276	0.533812
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4896.356	53.539	0.517035

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
SumBase_Basic	1019.673	257.086
SumBase_Zip	329.025	796.731	3.099080
SumBase	328.890	797.058	3.100352
SumTraits	26.967	9720.851	37.811635
Sum128Base_Basic	1016.435	257.905	1.003186
Sum128Base_Shuffle	1210.768	216.510	0.842171
Sum128Base_Zip	246.349	1064.116	4.139140
Sum128Base	246.878	1061.837	4.130274
Sum128AdvSimd_Shuffle	54.180	4838.366	18.820013
Sum128AdvSimd_Zip	152.903	1714.445	6.668754
Sum128AdvSimdB64_Shuffle	26.793	9784.189	38.058003
Sum128AdvSimdB64_Zip	64.360	4073.080	15.843244
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	26.942	9729.958	37.847057
Sum256Base_Basic	2094.494	125.159	0.486835
Sum256Base_Shuffle	2853.474	91.868	0.357345
Sum256Base_Zip	1682.116	155.842	0.606185
Sum256Base	2088.104	125.542	0.488325
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2087.690	125.567	0.488422

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
SumBase_Basic	1235.482	212.179
SumBase_Zip	603.655	434.262	2.046671
SumBase	1235.461	212.183	1.000017
SumTraits	52.862	4959.038	23.371902
Sum128Base_Basic	1234.395	212.366	1.000881
Sum128Base_Shuffle	2402.881	109.096	0.514167
Sum128Base_Zip	372.030	704.632	3.320924
Sum128Base	1238.456	211.670	0.997598
Sum128AdvSimd_Shuffle	102.391	2560.228	12.066331
Sum128AdvSimd_Zip	300.434	872.550	4.112320
Sum128AdvSimdB64_Shuffle	53.021	4944.177	23.301861
Sum128AdvSimdB64_Zip	123.803	2117.422	9.979392
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	53.019	4944.316	23.302518
Sum256Base_Basic	2534.887	103.414	0.487391
Sum256Base_Shuffle	5169.483	50.710	0.238995
Sum256Base_Zip	2548.424	102.865	0.484802
Sum256Base	2543.159	103.078	0.485806
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2544.619	103.019	0.485527

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
SumBase_Basic	1754.070	149.449
SumBase_Zip	742.294	353.154	2.363040
SumBase	1746.240	150.119	1.004484
SumTraits	106.076	2471.274	16.535905
Sum128Base_Basic	1743.895	150.321	1.005835
Sum128Base_Shuffle	4816.137	54.430	0.364207
Sum128Base_Zip	485.043	540.456	3.616322
Sum128Base	1746.203	150.122	1.004506
Sum128AdvSimd_Shuffle	206.169	1271.500	8.507917
Sum128AdvSimd_Zip	485.721	539.701	3.611271
Sum128AdvSimdB64_Shuffle	106.054	2471.802	16.539438
Sum128AdvSimdB64_Zip	240.014	1092.202	7.308193
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	106.054	2471.791	16.539360
Sum256Base_Basic	3194.091	82.072	0.549161
Sum256Base_Shuffle	9163.749	28.607	0.191414
Sum256Base_Zip	3652.604	71.769	0.480224
Sum256Base	3192.256	82.119	0.549477
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3198.733	81.952	0.548364

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
SumBase_Basic	2714.774	96.562
SumBase	2729.583	96.038	0.994574
SumTraits	135.338	1936.954	20.059175
Sum128Base_Basic	2723.637	96.248	0.996746
Sum128Base_Move	240.319	1090.819	11.296562
Sum128Base_Shuffle	6473.559	40.495	0.419363
Sum128Base	240.589	1089.591	11.283846
Sum128AdvSimd_Shuffle	304.398	861.187	8.918490
Sum128AdvSimd_Zip	215.401	1217.006	12.603357
Sum128AdvSimdB64_Move	135.255	1938.141	20.071461
Sum128AdvSimdB64_Shuffle	160.773	1630.523	16.885764
Sum128AdvSimdB64_Zip	216.161	1212.726	12.559035
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	135.496	1934.692	20.035748
Sum256Base_Basic	4115.817	63.692	0.659595
Sum256Base_Shuffle	16653.577	15.741	0.163014
Sum256Base	4091.589	64.069	0.663501
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4108.474	63.806	0.660774

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
# Sum512Base_Basic	86
SumBase_Basic	805.999	325.241
SumBase_Zip	325.907	804.353	2.473099
SumBase	325.885	804.406	2.473261
SumTraits	23.413	11196.632	34.425650
Sum128Base_Basic	808.594	324.197	0.996792
Sum128Base_Shuffle	1206.734	217.234	0.667918
Sum128Base_Zip	467.793	560.385	1.722984
Sum128Base	470.680	556.947	1.712413
Sum128AdvSimd_Shuffle	50.292	5212.471	16.026488
Sum128AdvSimd_Zip	128.661	2037.479	6.264522
Sum128AdvSimdB64_Shuffle	23.292	11254.906	34.604820
Sum128AdvSimdB64_Zip	59.511	4404.951	13.543652
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	23.290	11255.776	34.607496
Sum256Base_Basic	790.926	331.439	1.019057
Sum256Base_Shuffle	1965.144	133.397	0.410148
Sum256Base_Zip	406.892	644.259	1.980866
Sum256Base	790.735	331.520	1.019304
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	789.042	332.231	1.021491
Sum512Base_Basic	809.359	323.891	0.995848
Sum512Base_Shuffle	1937.551	135.297	0.415989
Sum512Base_Zip	602.092	435.388	1.338664
Sum512Base	810.565	323.409	0.994368
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	810.490	323.439	0.994459

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
# Sum512Base_Basic	-8306
SumBase_Basic	886.258	295.788
SumBase_Zip	615.425	425.956	1.440075
SumBase	884.099	296.510	1.002441
SumTraits	49.637	5281.192	17.854681
Sum128Base_Basic	886.245	295.792	1.000014
Sum128Base_Shuffle	2436.758	107.579	0.363704
Sum128Base_Zip	593.259	441.871	1.493879
Sum128Base	889.017	294.869	0.996896
Sum128AdvSimd_Shuffle	106.102	2470.682	8.352892
Sum128AdvSimd_Zip	268.085	977.838	3.305879
Sum128AdvSimdB64_Shuffle	49.376	5309.112	17.949071
Sum128AdvSimdB64_Zip	129.569	2023.202	6.840053
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	50.344	5207.055	17.604037
Sum256Base_Basic	864.554	303.213	1.025104
Sum256Base_Shuffle	2631.712	99.610	0.336761
Sum256Base_Zip	875.245	299.509	1.012583
Sum256Base	861.347	304.342	1.028921
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	861.408	304.320	1.028848
Sum512Base_Basic	930.026	281.867	0.952939
Sum512Base_Shuffle	3979.320	65.877	0.222716
Sum512Base_Zip	1183.273	221.542	0.748989
Sum512Base	930.129	281.836	0.952834
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	931.402	281.451	0.951531

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
# Sum512Base_Basic	-1403265138
SumBase_Basic	1127.430	232.515
SumBase_Zip	763.553	343.321	1.476558
SumBase	1120.143	234.027	1.006506
SumTraits	99.915	2623.663	11.283864
Sum128Base_Basic	1120.531	233.946	1.006157
Sum128Base_Shuffle	4882.237	53.693	0.230925
Sum128Base_Zip	473.268	553.902	2.382225
Sum128Base	1129.778	232.032	0.997923
Sum128AdvSimd_Shuffle	212.910	1231.241	5.295331
Sum128AdvSimd_Zip	529.634	494.953	2.128697
Sum128AdvSimdB64_Shuffle	100.345	2612.431	11.235558
Sum128AdvSimdB64_Zip	250.552	1046.267	4.499790
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	100.437	2610.040	11.225277
Sum256Base_Basic	975.508	268.726	1.155736
Sum256Base_Shuffle	5267.125	49.770	0.214050
Sum256Base_Zip	1464.529	178.995	0.769824
Sum256Base	976.897	268.343	1.154093
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	977.130	268.280	1.153818
Sum512Base_Basic	1125.821	232.847	1.001429
Sum512Base_Shuffle	7939.819	33.016	0.141997
Sum512Base_Zip	2176.929	120.419	0.517900
Sum512Base	1128.630	232.267	0.998937
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1123.796	233.267	1.003234

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
# Sum512Base_Basic	-715627282993526260
SumBase_Basic	1244.585	210.628
SumBase	1233.149	212.581	1.009274
SumTraits	161.537	1622.809	7.704633
Sum128Base_Basic	1229.963	213.132	1.011888
Sum128Base_Move	256.100	1023.602	4.859768
Sum128Base_Shuffle	6622.231	39.585	0.187940
Sum128Base	254.288	1030.895	4.894397
Sum128AdvSimd_Shuffle	319.031	821.687	3.901138
Sum128AdvSimd_Zip	246.270	1064.457	5.053738
Sum128AdvSimdB64_Move	158.808	1650.699	7.837047
Sum128AdvSimdB64_Shuffle	164.035	1598.098	7.587312
Sum128AdvSimdB64_Zip	246.324	1064.226	5.052642
Sum128PackedSimd_Shuffle	Run fail! Requires hardware support PackedSimd!
Sum128PackedSimd_Zip	Run fail! Requires hardware support PackedSimd!
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	158.542	1653.470	7.850203
Sum256Base_Basic	1182.144	221.753	1.052820
Sum256Base_Shuffle	10191.708	25.721	0.122117
Sum256Base	1176.697	222.780	1.057694
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1176.898	222.741	1.057513
Sum512Base_Basic	1518.196	172.668	0.819779
Sum512Base_Shuffle	15999.083	16.385	0.077791
Sum512Base	1516.581	172.852	0.820652
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	1520.432	172.414	0.818573

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


[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
# Sum128Base_Basic	86
# Sum256Base_Basic	86
# Sum512Base_Basic	86
SumBase_Basic	61875.000	4.237
SumBase_Zip	24408.333	10.740	2.534995
SumBase	61316.667	4.275	1.009106
SumTraits	2377.344	110.268	26.026947
Sum128Base_Basic	62700.000	4.181	0.986842
Sum128Base_Shuffle	3639.583	72.026	17.000572
Sum128Base_Zip	15729.167	16.666	3.933775
Sum128Base	15328.125	17.102	4.036697
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	1744.401	150.277	35.470628
Sum128PackedSimd_Zip	5092.188	51.480	12.150967
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1704.036	153.837	36.310843
Sum256Base_Basic	64641.667	4.055	0.957200
Sum256Base_Shuffle	40925.000	6.405	1.511912
Sum256Base_Zip	16075.000	16.308	3.849145
Sum256Base	63500.000	4.128	0.974409
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	63633.333	4.120	0.972368
Sum512Base_Basic	64179.167	4.085	0.964098
Sum512Base_Shuffle	42970.833	6.101	1.439930
Sum512Base_Zip	28475.000	9.206	2.172959
Sum512Base	67675.000	3.874	0.914296
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	63966.667	4.098	0.967301

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
# Sum128Base_Basic	-8306
# Sum256Base_Basic	-8306
# Sum512Base_Basic	-8306
SumBase_Basic	71991.667	3.641
SumBase_Zip	33489.583	7.828	2.149673
SumBase	73983.333	3.543	0.973080
SumTraits	4866.146	53.871	14.794392
Sum128Base_Basic	72391.667	3.621	0.994475
Sum128Base_Shuffle	7120.313	36.816	10.110745
Sum128Base_Zip	33637.500	7.793	2.140220
Sum128Base	73358.333	3.573	0.981370
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	3466.667	75.618	20.766827
Sum128PackedSimd_Zip	10370.833	25.277	6.941744
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	3428.906	76.451	20.995519
Sum256Base_Basic	76300.000	3.436	0.943534
Sum256Base_Shuffle	87550.000	2.994	0.822292
Sum256Base_Zip	47645.833	5.502	1.510975
Sum256Base	74691.667	3.510	0.963851
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	79283.333	3.306	0.908030
Sum512Base_Basic	80341.667	3.263	0.896069
Sum512Base_Shuffle	88616.667	2.958	0.812394
Sum512Base_Zip	53904.167	4.863	1.335549
Sum512Base	74533.333	3.517	0.965899
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	78691.666	3.331	0.914858

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
# Sum128Base_Basic	-1403265138
# Sum256Base_Basic	-1403265138
# Sum512Base_Basic	-1403265138
SumBase_Basic	89558.333	2.927
SumBase_Zip	47175.000	5.557	1.898428
SumBase	89733.334	2.921	0.998050
SumTraits	9150.000	28.650	9.787796
Sum128Base_Basic	90600.000	2.893	0.988503
Sum128Base_Shuffle	14319.792	18.306	6.254165
Sum128Base_Zip	47441.667	5.526	1.887757
Sum128Base	92700.000	2.828	0.966109
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	6727.604	38.965	13.312069
Sum128PackedSimd_Zip	20556.250	12.753	4.356745
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	6917.708	37.895	12.946243
Sum256Base_Basic	93000.000	2.819	0.962993
Sum256Base_Shuffle	167233.333	1.568	0.535529
Sum256Base_Zip	74883.333	3.501	1.195972
Sum256Base	93683.333	2.798	0.955969
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	100483.333	2.609	0.891276
Sum512Base_Basic	93008.333	2.819	0.962907
Sum512Base_Shuffle	165666.667	1.582	0.540594
Sum512Base_Zip	96275.000	2.723	0.930235
Sum512Base	94100.000	2.786	0.951736
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	96750.000	2.709	0.925668

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
# Sum128Base_Basic	-715627282993526260
# Sum256Base_Basic	-715627282993526260
# Sum512Base_Basic	-715627282993526260
SumBase_Basic	183500.000	1.429
SumBase	182733.334	1.435	1.004196
SumTraits	80916.666	3.240	2.267765
Sum128Base_Basic	273816.666	0.957	0.670156
Sum128Base_Move	176116.666	1.488	1.041923
Sum128Base_Shuffle	171050.000	1.533	1.072786
Sum128Base	176783.333	1.483	1.037994
Sum128AdvSimd_Shuffle	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Zip	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimdB64_Move	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Shuffle	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128AdvSimdB64_Zip	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
Sum128PackedSimd_Shuffle	11722.917	22.362	15.653101
Sum128PackedSimd_Zip	21727.083	12.065	8.445680
Sum128Sse_Shuffle	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Zip	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	11500.000	22.795	15.956522
Sum256Base_Basic	273266.667	0.959	0.671505
Sum256Base_Shuffle	472650.000	0.555	0.388237
Sum256Base	272183.334	0.963	0.674178
Sum256Avx2_Shuffle	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleX	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_ShuffleXImm	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Zip	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	162066.667	1.618	1.132250
Sum512Base_Basic	264683.333	0.990	0.693281
Sum512Base_Shuffle	494183.334	0.530	0.371320
Sum512Base	275750.000	0.951	0.665458
Sum512Avx512_ShuffleX	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_ShuffleXImm	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Avx512_Zip	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
Sum512Traits	144050.000	1.820	1.273863

```

