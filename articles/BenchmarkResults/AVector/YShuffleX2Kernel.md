# Benchmark - YShuffleX2Kernel
([← Back](README.md))

See [Group](YShuffleX2Kernel_Group.md)

- `YShuffleX2Kernel[/_Args/_Core]`: Only shuffle on 2 vectors (在2个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the IndexMask mask to constrain the parameters (可使用 IndexMask 掩码来约束参数).
  Mnemonic: `rt[i] := element_ref(indices[i], vector0, vector1)`. Conditions: `0<=indices[i] && indices[i]<(Count*2)`.
- `YShuffleX3Kernel[/_Args/_Core]`: Only shuffle on 3 vectors (在3个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的).
  Mnemonic: `rt[i] := element_ref(indices[i], vector0, vector1, vector2)`. Conditions: `0<=indices[i] && indices[i]<(Count*3)`.
- `YShuffleX4Kernel[/_Args/_Core]`: Only shuffle on 4 vectors (在4个向量上进行仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the IndexMask mask to constrain the parameters (可使用 IndexMask 掩码来约束参数).
  Mnemonic: `rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)`. Conditions: `0<=indices[i] && indices[i]<(Count*4)`.

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9241.0
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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
SumBase_Basic	598.824	437.764
SumBase	575.551	455.466	1.040436
SumTraits	588.772	445.239	1.017074
SumTraits_Args	605.623	432.850	0.988774
SumTraits_ArgsT	677.243	387.075	0.884209

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	720.513	363.829
SumBase	740.654	353.936	0.972807
SumTraits	727.174	360.497	0.990840
SumTraits_Args	719.264	364.461	1.001737
SumTraits_ArgsT	879.834	297.947	0.818920

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
SumBase_Basic	1044.445	250.989
SumBase	1054.292	248.645	0.990661
SumTraits	1065.413	246.049	0.980320
SumTraits_Args	1051.464	249.313	0.993325
SumTraits_ArgsT	1306.473	200.650	0.799439

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
SumBase_Basic	1734.249	151.157
SumBase	1711.787	153.141	1.013122
SumTraits	1717.259	152.653	1.009894
SumTraits_Args	1747.939	149.973	0.992168
SumTraits_ArgsT	2265.599	115.706	0.765471

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
SumBase_Basic	643.509	407.366
SumBase	700.596	374.173	0.918516
SumTraits	635.023	412.810	1.013364
SumTraits_Args	633.270	413.953	1.016168
SumTraits_ArgsT	652.827	401.552	0.985726

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	1377.599	190.291
SumBase	1266.522	206.979	1.087702
SumTraits	756.920	346.330	1.820005
SumTraits_Args	738.999	354.728	1.864142
SumTraits_ArgsT	868.154	301.956	1.586815

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
SumBase_Basic	1136.381	230.683
SumBase	1116.072	234.881	1.018197
SumTraits	1143.449	229.257	0.993819
SumTraits_Args	1098.644	238.607	1.034348
SumTraits_ArgsT	1414.276	185.356	0.803507

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
SumBase_Basic	1902.460	137.792
SumBase	1926.418	136.078	0.987564
SumTraits	1942.523	134.950	0.979376
SumTraits_Args	2061.769	127.145	0.922732
SumTraits_ArgsT	2423.748	108.156	0.784925

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
SumBase_Basic	723.288	362.434
SumBase	702.380	373.222	1.029767
SumTraits	687.586	381.253	1.051923
SumTraits_Args	708.942	369.768	1.020235
SumTraits_ArgsT	736.958	355.711	0.981449

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	827.955	316.616
SumBase	806.523	325.030	1.026573
SumTraits	808.317	324.308	1.024295
SumTraits_Args	811.254	323.134	1.020586
SumTraits_ArgsT	910.283	287.981	0.909558

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128PackedSimd: Vector128 type is not supported! Requires hardware support PackedSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Vector128 type is not supported! Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Vector128 type is not supported! Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
VectorTraits512Base: Vector byte size mismatch(32!=64) !
VectorTraits512Avx512: Vector512 type is not supported! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi! Vector byte size mismatch(32!=64) !

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
SumBase_Basic	281.201	932.229
SumBase	286.803	914.020	0.980468
SumTraits	293.431	893.377	0.958323
SumTraits_Args	282.191	928.958	0.996491
SumTraits_ArgsT	349.772	749.471	0.803957

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	388.952	673.975
SumBase	392.509	667.867	0.990937
SumTraits	399.270	656.557	0.974156
SumTraits_Args	386.241	678.705	1.007017
SumTraits_ArgsT	537.749	487.484	0.723297

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
SumBase_Basic	641.402	408.704
SumBase	638.832	410.349	1.004023
SumTraits	639.635	409.834	1.002763
SumTraits_Args	639.555	409.885	1.002889
SumTraits_ArgsT	984.400	266.298	0.651567

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
SumBase_Basic	1219.322	214.992
SumBase	1266.101	207.048	0.963053
SumTraits	1210.266	216.600	1.007483
SumTraits_Args	1189.019	220.471	1.025486
SumTraits_ArgsT	1799.896	145.644	0.677440

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
SumBase_Basic	296.092	885.346
SumBase	292.699	895.608	1.011591
SumTraits	303.556	863.578	0.975412
SumTraits_Args	293.637	892.748	1.008360
SumTraits_ArgsT	354.802	738.846	0.834528

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	423.105	619.572
SumBase	425.917	615.481	0.993397
SumTraits	426.208	615.061	0.992719
SumTraits_Args	414.774	632.016	1.020086
SumTraits_ArgsT	562.909	465.695	0.751640

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
SumBase_Basic	732.112	358.065
SumBase	720.929	363.620	1.015512
SumTraits	729.039	359.575	1.004216
SumTraits_Args	720.424	363.875	1.016224
SumTraits_ArgsT	1013.607	258.625	0.722284

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
SumBase_Basic	1388.158	188.843
SumBase	1389.911	188.605	0.998738
SumTraits	1417.659	184.913	0.979190
SumTraits_Args	1375.533	190.576	1.009178
SumTraits_ArgsT	1910.918	137.182	0.726435

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
SumBase_Basic	311.908	840.452
SumBase	310.788	843.480	1.003604
SumTraits	311.349	841.962	1.001797
SumTraits_Args	312.197	839.675	0.999076
SumTraits_ArgsT	371.240	706.130	0.840180

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	524.101	500.178
SumBase	461.023	568.614	1.136823
SumTraits	465.096	563.634	1.126867
SumTraits_Args	462.427	566.888	1.133372
SumTraits_ArgsT	592.660	442.318	0.884320

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128PackedSimd: Vector128 type is not supported! Requires hardware support PackedSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Vector128 type is not supported! Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Vector128 type is not supported! Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
VectorTraits512Base: Vector byte size mismatch(32!=64) !
VectorTraits512Avx512: Vector512 type is not supported! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi! Vector byte size mismatch(32!=64) !

``` 

#### .NET Core 3.1 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	347.324	754.754
SumBase	357.307	733.665	0.972059
SumTraits	17.813	14716.765	19.498756
SumTraits_Args	11.198	23409.254	31.015738
SumTraits_ArgsT	12.808	20467.204	27.117712
Sum128Base_Basic	620.759	422.296	0.559515
Sum128Base	666.848	393.109	0.520844
Sum128Sse_Combine	84.483	3102.921	4.111168
Sum128Traits	88.654	2956.933	3.917743
Sum128Traits_ArgsT	11.466	22862.399	30.291190
Sum256Base_Basic	508.317	515.710	0.683282
Sum256Base	528.009	496.476	0.657799
Sum256Avx2_Combine	16.592	15799.427	20.933212
Sum256Avx2_Combine2	17.003	15417.327	20.426955
Sum256Avx2_Combine3	16.544	15845.495	20.994249
Sum256Traits	16.219	16163.131	21.415096
Sum256Traits_ArgsT	10.810	24250.747	32.130660

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	440.069	595.689
SumBase	452.722	579.039	0.972050
SumTraits	46.606	5624.724	9.442387
SumTraits_Args	22.936	11429.442	19.186937
SumTraits_ArgsT	30.073	8717.033	14.633537
Sum128Base_Basic	1033.202	253.720	0.425927
Sum128Base	996.473	263.072	0.441626
Sum128Sse_Combine	173.586	1510.170	2.535167
Sum128Traits	175.479	1493.880	2.507820
Sum128Traits_ArgsT	22.927	11433.724	19.194125
Sum256Base_Basic	664.498	394.499	0.662257
Sum256Base	656.958	399.027	0.669858
Sum256Avx2_Combine	34.630	7569.761	12.707578
Sum256Traits	33.816	7752.098	13.013672
Sum256Traits_ArgsT	20.123	13027.007	21.868815

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	597.966	438.393
SumBase	625.660	418.988	0.955737
SumTraits	29.886	8771.406	20.008094
SumTraits_Args	25.821	10152.246	23.157871
SumTraits_ArgsT	46.434	5645.567	12.877870
Sum128Base_Basic	1517.520	172.745	0.394042
Sum128Base	1589.412	164.931	0.376218
Sum128Sse_Combine	318.696	822.551	1.876288
Sum128Traits	257.956	1016.236	2.318094
Sum128Traits_ArgsT	35.973	7287.323	16.622812
Sum256Base_Basic	1012.170	258.992	0.590776
Sum256Base	954.615	274.607	0.626394
Sum256Avx2_Combine	26.348	9949.338	22.695025
Sum256Traits	25.789	10164.929	23.186802
Sum256Traits_ArgsT	34.027	7704.071	17.573440

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1228.349	213.412
SumBase	1173.429	223.400	1.046803
SumTraits	84.350	3107.817	14.562544
SumTraits_Args	51.419	5098.152	23.888815
SumTraits_ArgsT	92.800	2824.836	13.236558
Sum128Base_Basic	2902.426	90.319	0.423215
Sum128Base	3018.291	86.852	0.406968
Sum128Sse_Combine	625.967	418.783	1.962323
Sum128Traits	524.617	499.687	2.341421
Sum128Traits_ArgsT	69.014	3798.443	17.798666
Sum256Base_Basic	1718.605	152.533	0.714736
Sum256Base	1695.883	154.577	0.724312
Sum256Avx2_Combine	72.864	3597.723	16.858136
Sum256Traits	73.921	3546.295	16.617157
Sum256Traits_ArgsT	71.886	3646.659	17.087441

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	307.502	852.495
SumBase	308.381	850.065	0.997149
SumTraits	26.496	9893.734	11.605617
SumTraits_Args	25.098	10444.691	12.251904
SumTraits_ArgsT	20.336	12890.839	15.121302
Sum128Base_Basic	574.755	456.097	0.535014
Sum128Base	555.461	471.939	0.553597
Sum128Sse_Combine	120.607	2173.546	2.549628
Sum128Traits	120.426	2176.800	2.553445
Sum128Traits_ArgsT	13.491	19431.728	22.793941
Sum256Base_Basic	491.339	533.530	0.625845
Sum256Base	541.164	484.408	0.568223
Sum256Avx2_Combine	30.700	8538.974	10.016447
Sum256Traits	29.594	8858.066	10.390750
Sum256Traits_ArgsT	22.008	11911.216	13.972178

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	486.634	538.688
SumBase	491.220	533.659	0.990664
SumTraits	72.595	3611.046	6.703405
SumTraits_Args	57.165	4585.738	8.512785
SumTraits_ArgsT	43.052	6088.998	11.303377
Sum128Base_Basic	987.568	265.444	0.492760
Sum128Base	934.685	280.463	0.520640
Sum128Sse_Combine	246.312	1064.277	1.975682
Sum128Traits	230.998	1134.831	2.106655
Sum128Traits_ArgsT	27.215	9632.418	17.881244
Sum256Base_Basic	669.553	391.521	0.726804
Sum256Base	673.338	389.320	0.722719
Sum256Avx2_Combine	65.235	4018.474	7.459738
Sum256Traits	62.769	4176.362	7.752835
Sum256Traits_ArgsT	38.102	6879.985	12.771735

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	680.379	385.291
SumBase	705.495	371.575	0.964400
SumTraits	44.388	5905.805	15.328160
SumTraits_Args	38.928	6734.047	17.477813
SumTraits_ArgsT	60.519	4331.591	11.242382
Sum128Base_Basic	1645.419	159.317	0.413499
Sum128Base	1619.249	161.892	0.420182
Sum128Sse_Combine	482.055	543.806	1.411415
Sum128Sse_CombineAvx	311.170	842.446	2.186517
Sum128Traits	312.566	838.684	2.176754
Sum128Traits_ArgsT	55.781	4699.513	12.197301
Sum256Base_Basic	996.091	263.173	0.683049
Sum256Base	984.873	266.170	0.690829
Sum256Avx2_Combine	37.108	7064.368	18.335141
Sum256Traits	36.360	7209.742	18.712449
Sum256Traits_ArgsT	42.863	6115.803	15.873197

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1303.757	201.068
SumBase	1293.969	202.589	1.007565
SumTraits	111.519	2350.659	11.690861
SumTraits_Args	76.270	3437.036	17.093888
SumTraits_ArgsT	110.071	2381.594	11.844714
Sum128Base_Basic	3118.604	84.058	0.418058
Sum128Base	3064.139	85.552	0.425489
Sum128Sse_Combine	958.977	273.358	1.359529
Sum128Sse_CombineAvx	672.616	389.738	1.938339
Sum128Traits	685.139	382.615	1.902910
Sum128Traits_ArgsT	115.963	2260.586	11.242888
Sum256Base_Basic	2093.322	125.229	0.622817
Sum256Base	2061.770	127.145	0.632349
Sum256Avx2_Combine	105.045	2495.537	12.411402
Sum256Traits	94.411	2776.613	13.809316
Sum256Traits_ArgsT	85.517	3065.394	15.245551

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	320.133	818.859
SumBase	328.910	797.009	0.973317
SumTraits	35.012	7487.316	9.143595
SumTraits_Args	29.640	8844.270	10.800722
SumTraits_ArgsT	28.133	9318.054	11.379312
Sum128Base_Basic	595.733	440.036	0.537377
Sum128Base	578.129	453.435	0.553740
Sum128Sse_Combine	137.662	1904.252	2.325493
Sum128Traits	137.409	1907.761	2.329780
Sum128Traits_ArgsT	18.287	14335.157	17.506255
Sum256Base_Basic	437.697	598.917	0.731404
Sum256Base	456.938	573.697	0.700606
Sum256Avx2_Combine	35.481	7388.378	9.022771
Sum256Traits	37.183	7050.076	8.609632
Sum256Traits_ArgsT	25.385	10326.801	12.611206

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	511.430	512.570
SumBase	491.405	533.458	1.040751
SumTraits	96.047	2729.321	5.324776
SumTraits_Args	68.629	3819.708	7.452069
SumTraits_ArgsT	63.881	4103.610	8.005947
Sum128Base_Basic	1004.949	260.853	0.508912
Sum128Base	1141.873	229.574	0.447888
Sum128Sse_Combine	290.393	902.722	1.761168
Sum128Traits	296.984	882.688	1.722082
Sum128Traits_ArgsT	36.067	7268.219	14.179948
Sum256Base_Basic	695.820	376.741	0.735004
Sum256Base	671.810	390.206	0.761273
Sum256Avx2_Combine	77.989	3361.288	6.557712
Sum256Traits	80.377	3261.445	6.362924
Sum256Traits_ArgsT	49.812	5262.650	10.267180

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128PackedSimd: Requires hardware support PackedSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
VectorTraits512Base: Vector byte size mismatch(32!=64) !
VectorTraits512Avx512: Vector512 type is not supported! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi! Vector byte size mismatch(32!=64) !

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	252.377	1038.699
SumBase	266.861	982.323	0.945724
SumTraits	13.514	19398.153	18.675429
SumTraits_Args	8.283	31647.408	30.468310
SumTraits_ArgsT	10.155	25815.254	24.853447
Sum128Base_Basic	530.831	493.837	0.475438
Sum128Base	529.781	494.816	0.476380
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	65.022	4031.601	3.881394
Sum128Traits	64.485	4065.216	3.913757
Sum128Traits_ArgsT	10.577	24783.543	23.860174
Sum256Base_Basic	400.664	654.273	0.629897
Sum256Base	394.289	664.853	0.640082
Sum256Avx2_Combine	11.458	22879.273	22.026852
Sum256Avx2_Combine2	10.553	24839.617	23.914159
Sum256Avx2_Combine3	11.084	23650.219	22.769075
Sum256Traits	10.999	23833.790	22.945806
Sum256Traits_ArgsT	10.010	26188.554	25.212838

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	346.382	756.806
SumBase	349.090	750.934	0.992242
SumTraits	34.059	7696.747	10.170038
SumTraits_Args	16.635	15758.136	20.821895
SumTraits_ArgsT	21.786	12032.744	15.899376
Sum128Base_Basic	856.741	305.978	0.404302
Sum128Base	852.276	307.581	0.406420
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	128.837	2034.690	2.688522
Sum128Traits	128.941	2033.051	2.686356
Sum128Traits_ArgsT	21.420	12238.060	16.170669
Sum256Base_Basic	621.340	421.901	0.557476
Sum256Base	619.053	423.460	0.559536
Sum256Avx2_Combine	27.450	9549.850	12.618622
Sum256Traits	26.939	9730.901	12.857853
Sum256Traits_ArgsT	17.153	15282.765	20.193766

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	598.532	437.978
SumBase	614.751	426.423	0.973617
SumTraits	27.557	9512.904	21.720051
SumTraits_Args	20.183	12988.574	29.655769
SumTraits_ArgsT	40.938	6403.451	14.620485
Sum128Base_Basic	1467.765	178.601	0.407785
Sum128Base	1541.310	170.079	0.388327
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	259.838	1008.873	2.303479
Sum128Traits	262.353	999.203	2.281399
Sum128Traits_ArgsT	30.680	8544.346	19.508619
Sum256Base_Basic	911.663	287.545	0.656528
Sum256Base	921.626	284.436	0.649431
Sum256Avx2_Combine	20.459	12813.406	29.255821
Sum256Traits	20.813	12595.278	28.757789
Sum256Traits_ArgsT	34.477	7603.464	17.360380

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1142.515	229.445
SumBase	1174.247	223.244	0.972977
SumTraits	66.247	3957.076	17.246316
SumTraits_Args	37.397	7009.781	30.551068
SumTraits_ArgsT	80.864	3241.780	14.128808
Sum128Base_Basic	2851.768	91.923	0.400634
Sum128Base	2866.058	91.465	0.398636
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	520.975	503.180	2.193032
Sum128Traits	562.469	466.059	2.031249
Sum128Traits_ArgsT	59.586	4399.439	19.174286
Sum256Base_Basic	1725.761	151.900	0.662035
Sum256Base	1730.274	151.504	0.660309
Sum256Avx2_Combine	58.771	4460.416	19.440048
Sum256Traits	58.014	4518.667	19.693925
Sum256Traits_ArgsT	66.896	3918.691	17.079022

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	306.348	855.707
SumBase	277.359	945.142	1.104516
SumTraits	21.415	12240.911	14.305026
SumTraits_Args	17.003	15417.632	18.017419
SumTraits_ArgsT	19.596	13377.535	15.633313
Sum128Base_Basic	536.922	488.235	0.570563
Sum128Base	665.511	393.899	0.460319
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	113.566	2308.289	2.697523
Sum128Traits	113.799	2303.568	2.692005
Sum128Traits_ArgsT	12.473	21016.728	24.560659
Sum256Base_Basic	425.422	616.198	0.720104
Sum256Base	424.112	618.101	0.722327
Sum256Avx2_Combine	24.440	10725.899	12.534546
Sum256Traits	24.286	10793.883	12.613994
Sum256Traits_ArgsT	16.574	15816.606	18.483671

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	385.182	680.571
SumBase	390.595	671.140	0.986142
SumTraits	46.647	5619.709	8.257344
SumTraits_Args	33.826	7749.762	11.387147
SumTraits_ArgsT	37.783	6938.202	10.194677
Sum128Base_Basic	875.870	299.296	0.439771
Sum128Base	868.753	301.747	0.443374
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	231.064	1134.507	1.666993
Sum128Traits	230.800	1135.805	1.668900
Sum128Traits_ArgsT	25.125	10433.567	15.330606
Sum256Base_Basic	655.272	400.054	0.587821
Sum256Base	652.094	402.004	0.590686
Sum256Avx2_Combine	53.776	4874.776	7.162773
Sum256Traits	53.915	4862.179	7.144264
Sum256Traits_ArgsT	32.524	8060.088	11.843125

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	670.064	391.222
SumBase	693.700	377.892	0.965927
SumTraits	43.741	5993.031	15.318733
SumTraits_Args	40.568	6461.829	16.517024
SumTraits_ArgsT	57.310	4574.165	11.691984
Sum128Base_Basic	1561.567	167.872	0.429097
Sum128Base	1541.192	170.092	0.434770
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	458.166	572.160	1.462493
Sum128Sse_CombineAvx	300.011	873.780	2.233462
Sum128Traits	298.889	877.062	2.241850
Sum128Traits_ArgsT	49.781	5265.919	13.460169
Sum256Base_Basic	996.979	262.938	0.672094
Sum256Base	983.626	266.508	0.681218
Sum256Avx2_Combine	27.957	9376.564	23.967353
Sum256Traits	28.141	9315.340	23.810859
Sum256Traits_ArgsT	40.339	6498.468	16.610679

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1294.085	202.571
SumBase	1335.541	196.283	0.968959
SumTraits	108.376	2418.841	11.940706
SumTraits_Args	80.311	3264.111	16.113417
SumTraits_ArgsT	133.931	1957.307	9.662323
Sum128Base_Basic	3446.794	76.054	0.375446
Sum128Base	3449.707	75.990	0.375129
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	1162.172	225.564	1.113506
Sum128Sse_CombineAvx	784.135	334.310	1.650335
Sum128Traits	787.936	332.697	1.642372
Sum128Traits_ArgsT	115.993	2260.003	11.156598
Sum256Base_Basic	2247.296	116.649	0.575841
Sum256Base	2150.197	121.916	0.601845
Sum256Avx2_Combine	95.852	2734.892	13.500907
Sum256Traits	87.788	2986.087	14.740938
Sum256Traits_ArgsT	82.128	3191.893	15.756909

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	328.269	798.566
SumBase	304.893	859.790	1.076668
SumTraits	28.541	9184.786	11.501604
SumTraits_Args	25.161	10418.698	13.046764
SumTraits_ArgsT	30.188	8683.719	10.874145
Sum128Base_Basic	550.183	476.467	0.596653
Sum128Base	547.921	478.434	0.599116
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	129.152	2029.735	2.541726
Sum128Traits	129.086	2030.765	2.543015
Sum128Traits_ArgsT	15.443	16975.265	21.257194
Sum256Base_Basic	423.622	618.815	0.774909
Sum256Base	425.490	616.099	0.771507
Sum256Avx2_Combine	25.409	10316.889	12.919274
Sum256Traits	25.353	10339.960	12.948165
Sum256Traits_ArgsT	24.985	10491.869	13.138392

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	412.387	635.675
SumBase	425.012	616.793	0.970295
SumTraits	62.385	4202.035	6.610348
SumTraits_Args	49.554	5290.086	8.321994
SumTraits_ArgsT	58.090	4512.739	7.099126
Sum128Base_Basic	971.599	269.807	0.424441
Sum128Base	965.551	271.497	0.427100
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	258.026	1015.959	1.598236
Sum128Traits	256.583	1021.672	1.607223
Sum128Traits_ArgsT	30.998	8456.922	13.303840
Sum256Base_Basic	688.876	380.539	0.598637
Sum256Base	674.643	388.567	0.611267
Sum256Avx2_Combine	64.542	4061.585	6.389403
Sum256Traits	64.667	4053.771	6.377110
Sum256Traits_ArgsT	55.395	4732.280	7.444494

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128PackedSimd: Requires hardware support PackedSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
VectorTraits512Base: Vector byte size mismatch(32!=64) !
VectorTraits512Avx512: Vector512 type is not supported! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi! Vector byte size mismatch(32!=64) !

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.30
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.30\
RuntimeInformation.FrameworkDescription:	.NET 6.0.30
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	312.688	838.356
SumBase	296.880	882.996	1.053248
SumTraits	16.931	15483.478	18.468868
SumTraits_Args	10.202	25694.483	30.648672
SumTraits_ArgsT	14.830	17676.259	21.084442
Sum128Base_Basic	643.020	407.676	0.486281
Sum128Base	612.846	427.748	0.510223
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	86.403	3033.978	3.618963
Sum128Traits	85.061	3081.849	3.676065
Sum128Traits_ArgsT	10.813	24242.842	28.917137
Sum256Base_Basic	413.229	634.380	0.756696
Sum256Base	400.275	654.910	0.781184
Sum256Avx2_Combine	11.167	23474.400	28.000531
Sum256Avx2_Combine2	9.917	26434.347	31.531190
Sum256Avx2_Combine3	10.968	23900.675	28.508998
Sum256Traits	11.010	23810.139	28.401005
Sum256Traits_ArgsT	8.068	32490.237	38.754725

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	366.048	716.147
SumBase	353.491	741.587	1.035523
SumTraits	33.879	7737.676	10.804596
SumTraits_Args	16.584	15806.872	22.072113
SumTraits_ArgsT	23.117	11340.032	15.834789
Sum128Base_Basic	853.865	307.009	0.428695
Sum128Base	854.302	306.852	0.428476
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	131.408	1994.888	2.785585
Sum128Traits	128.600	2038.445	2.846407
Sum128Traits_ArgsT	16.977	15441.369	21.561738
Sum256Base_Basic	662.662	395.593	0.552390
Sum256Base	629.842	416.206	0.581174
Sum256Avx2_Combine	27.001	9708.774	13.556961
Sum256Traits	27.057	9688.723	13.528963
Sum256Traits_ArgsT	20.069	13062.334	18.239745

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	576.271	454.897
SumBase	573.601	457.015	1.004656
SumTraits	30.954	8468.849	18.617078
SumTraits_Args	20.666	12684.792	27.884987
SumTraits_ArgsT	45.380	5776.688	12.698897
Sum128Base_Basic	1479.196	177.221	0.389584
Sum128Base	1491.176	175.797	0.386454
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	259.038	1011.989	2.224656
Sum128Traits	275.441	951.724	2.092175
Sum128Traits_ArgsT	39.556	6627.096	14.568351
Sum256Base_Basic	907.327	288.919	0.635131
Sum256Base	904.258	289.899	0.637286
Sum256Avx2_Combine	19.634	13351.664	29.350973
Sum256Traits	20.193	12982.057	28.538466
Sum256Traits_ArgsT	34.302	7642.323	16.800125

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1087.203	241.118
SumBase	1099.305	238.463	0.988991
SumTraits	69.696	3761.273	15.599312
SumTraits_Args	40.703	6440.420	26.710669
SumTraits_ArgsT	90.259	2904.341	12.045317
Sum128Base_Basic	2839.902	92.307	0.382831
Sum128Base	2816.515	93.074	0.386010
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	557.631	470.103	1.949680
Sum128Traits	520.984	503.171	2.086826
Sum128Traits_ArgsT	78.604	3334.982	13.831332
Sum256Base_Basic	1687.474	155.347	0.644278
Sum256Base	1652.670	158.618	0.657846
Sum256Avx2_Combine	58.546	4477.569	18.570041
Sum256Traits	58.463	4483.932	18.596432
Sum256Traits_ArgsT	67.587	3878.620	16.085991

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	269.256	973.585
SumBase	266.112	985.088	1.011815
SumTraits	22.196	11810.300	12.130728
SumTraits_Args	17.156	15280.296	15.694869
SumTraits_ArgsT	21.863	11990.102	12.315408
Sum128Base_Basic	528.124	496.369	0.509836
Sum128Base	529.725	494.868	0.508295
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	117.997	2221.610	2.281885
Sum128Traits	118.369	2214.632	2.274718
Sum128Traits_ArgsT	11.682	22439.577	23.048390
Sum256Base_Basic	405.420	646.598	0.664141
Sum256Base	413.550	633.887	0.651085
Sum256Avx2_Combine	17.023	15399.055	15.816850
Sum256Traits	17.191	15248.536	15.662247
Sum256Traits_ArgsT	15.720	16676.098	17.128540

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	387.116	677.171
SumBase	384.311	682.115	1.007301
SumTraits	47.760	5488.822	8.105520
SumTraits_Args	34.229	7658.604	11.309707
SumTraits_ArgsT	41.030	6389.111	9.435006
Sum128Base_Basic	875.684	299.359	0.442073
Sum128Base	875.591	299.391	0.442120
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	246.237	1064.602	1.572132
Sum128Traits	237.495	1103.787	1.629997
Sum128Traits_ArgsT	23.567	11123.284	16.426111
Sum256Base_Basic	635.245	412.666	0.609397
Sum256Base	640.403	409.342	0.604488
Sum256Avx2_Combine	41.386	6334.176	9.353881
Sum256Traits	41.069	6383.030	9.426026
Sum256Traits_ArgsT	31.642	8284.685	12.234260

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	625.671	418.981
SumBase	629.244	416.601	0.994321
SumTraits	40.276	6508.677	15.534547
SumTraits_Args	30.548	8581.262	20.481278
SumTraits_ArgsT	42.939	6105.054	14.571203
Sum128Base_Basic	1530.707	171.257	0.408746
Sum128Base	1536.236	170.640	0.407275
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	475.906	550.832	1.314694
Sum128Sse_CombineAvx	298.906	877.011	2.093202
Sum128Traits	297.730	880.476	2.101471
Sum128Traits_ArgsT	47.334	5538.220	13.218314
Sum256Base_Basic	954.325	274.691	0.655616
Sum256Base	949.503	276.085	0.658945
Sum256Avx2_Combine	27.749	9447.017	22.547614
Sum256Traits	27.799	9429.956	22.506893
Sum256Traits_ArgsT	31.766	8252.412	19.696398

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1210.198	216.612
SumBase	1203.190	217.874	1.005825
SumTraits	91.987	2849.784	13.156140
SumTraits_Args	63.680	4116.587	19.004389
SumTraits_ArgsT	86.085	3045.165	14.058125
Sum128Base_Basic	2946.459	88.969	0.410730
Sum128Base	2949.247	88.885	0.410341
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	947.745	276.598	1.276924
Sum128Sse_CombineAvx	600.191	436.768	2.016356
Sum128Traits	595.466	440.233	2.032354
Sum128Traits_ArgsT	93.685	2798.141	12.917728
Sum256Base_Basic	1777.048	147.517	0.681016
Sum256Base	1769.955	148.108	0.683745
Sum256Avx2_Combine	81.431	3219.231	14.861705
Sum256Traits	81.188	3228.856	14.906140
Sum256Traits_ArgsT	63.261	4143.877	19.130373

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	300.514	872.318
SumBase	323.455	810.449	0.929076
SumTraits	27.897	9397.016	10.772471
SumTraits_Args	25.200	10402.608	11.925252
SumTraits_ArgsT	28.148	9312.972	10.676125
Sum128Base_Basic	545.629	480.443	0.550767
Sum128Base	556.334	471.199	0.540169
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	133.228	1967.630	2.255635
Sum128Traits	132.601	1976.945	2.266313
Sum128Traits_ArgsT	15.318	17113.483	19.618407
Sum256Base_Basic	426.296	614.934	0.704942
Sum256Base	413.324	634.234	0.727067
Sum256Avx2_Combine	23.657	11081.182	12.703151
Sum256Traits	23.492	11158.947	12.792298
Sum256Traits_ArgsT	23.881	10977.235	12.583989

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	423.407	619.130
SumBase	468.631	559.383	0.903498
SumTraits	86.271	3038.610	4.907870
SumTraits_Args	50.326	5208.956	8.413347
SumTraits_ArgsT	56.852	4611.022	7.447582
Sum128Base_Basic	956.081	274.186	0.442857
Sum128Base	964.962	271.662	0.438781
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	268.433	976.570	1.577326
Sum128Traits	266.031	985.390	1.591572
Sum128Traits_ArgsT	30.967	8465.371	13.673009
Sum256Base_Basic	669.500	391.552	0.632423
Sum256Base	672.599	389.748	0.629509
Sum256Avx2_Combine	56.100	4672.767	7.547311
Sum256Traits	55.663	4709.471	7.606595
Sum256Traits_ArgsT	47.206	5553.242	8.969428

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128PackedSimd: Requires hardware support PackedSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
VectorTraits512Base: Vector byte size mismatch(32!=64) !
VectorTraits512Avx512: Vector512 type is not supported! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi! Vector byte size mismatch(32!=64) !

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.19
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.19\
RuntimeInformation.FrameworkDescription:	.NET 7.0.19
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.19/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	284.232	922.290
SumBase	279.356	938.388	1.017454
SumTraits	11.580	22637.671	24.545069
SumTraits_Args	8.306	31562.486	34.221867
SumTraits_ArgsT	10.145	25840.086	28.017311
Sum128Base_Basic	330.620	792.887	0.859693
Sum128Base	332.331	788.803	0.855266
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	9.107	28783.712	31.208960
Sum128Traits	9.152	28644.417	31.057929
Sum128Traits_ArgsT	10.620	24684.169	26.764000
Sum256Base_Basic	268.020	978.076	1.060486
Sum256Base	280.148	935.735	1.014578
Sum256Avx2_Combine	9.036	29011.467	31.455905
Sum256Avx2_Combine2	10.589	24755.345	26.841172
Sum256Avx2_Combine3	8.978	29197.047	31.657121
Sum256Traits	8.996	29141.518	31.596914
Sum256Traits_ArgsT	10.116	25915.029	28.098569

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	373.785	701.324
SumBase	364.510	719.168	1.025443
SumTraits	27.595	9499.569	13.545199
SumTraits_Args	16.494	15892.924	22.661324
SumTraits_ArgsT	21.489	12198.972	17.394210
Sum128Base_Basic	566.798	462.500	0.659467
Sum128Base	564.301	464.547	0.662386
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	19.791	13245.838	18.886910
Sum128Traits	69.029	3797.610	5.414918
Sum128Traits_ArgsT	20.438	12826.403	18.288849
Sum256Base_Basic	358.249	731.737	1.043365
Sum256Base	366.096	716.052	1.021001
Sum256Avx2_Combine	19.234	13628.918	19.433135
Sum256Traits	19.245	13621.357	19.422354
Sum256Traits_ArgsT	19.700	13307.122	18.974294

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	622.466	421.138
SumBase	613.030	427.620	1.015391
SumTraits	30.177	8686.811	20.626986
SumTraits_Args	18.937	13843.236	32.871008
SumTraits_ArgsT	38.089	6882.427	16.342444
Sum128Base_Basic	971.944	269.711	0.640433
Sum128Base	973.736	269.215	0.639255
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	39.664	6609.034	15.693269
Sum128Traits	26.629	9844.145	23.375096
Sum128Traits_ArgsT	39.421	6649.883	15.790264
Sum256Base_Basic	618.279	423.990	1.006771
Sum256Base	679.948	385.536	0.915461
Sum256Avx2_Combine	19.208	13647.825	32.407001
Sum256Traits	19.491	13449.146	31.935235
Sum256Traits_ArgsT	31.332	8366.744	19.866982

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1148.880	228.174
SumBase	1116.857	234.716	1.028673
SumTraits	61.764	4244.272	18.601070
SumTraits_Args	37.203	7046.298	30.881309
SumTraits_ArgsT	82.196	3189.246	13.977284
Sum128Base_Basic	1950.247	134.416	0.589094
Sum128Base	1952.353	134.271	0.588459
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	94.879	2762.942	12.108951
Sum128Traits	68.157	3846.191	16.856428
Sum128Traits_ArgsT	78.465	3340.888	14.641872
Sum256Base_Basic	1133.860	231.196	1.013247
Sum256Base	1093.577	239.712	1.050571
Sum256Avx2_Combine	48.460	5409.545	23.708031
Sum256Traits	48.058	5454.794	23.906341
Sum256Traits_ArgsT	67.910	3860.173	16.917708

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	278.355	941.762
SumBase	279.631	937.465	0.995438
SumTraits	18.191	14410.843	15.302007
SumTraits_Args	14.434	18161.259	19.284348
SumTraits_ArgsT	17.515	14967.012	15.892570
Sum128Base_Basic	342.566	765.237	0.812560
Sum128Base	350.154	748.653	0.794950
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	14.855	17646.752	18.738024
Sum128Traits	34.567	7583.704	8.052679
Sum128Traits_ArgsT	11.746	22316.944	23.697021
Sum256Base_Basic	282.633	927.508	0.984865
Sum256Base	282.590	927.649	0.985015
Sum256Avx2_Combine	15.515	16896.386	17.941256
Sum256Traits	15.273	17163.630	18.225027
Sum256Traits_ArgsT	14.401	18203.501	19.329202

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	385.473	680.058
SumBase	378.243	693.057	1.019114
SumTraits	41.069	6383.018	9.385985
SumTraits_Args	28.705	9132.323	13.428734
SumTraits_ArgsT	34.743	7545.264	11.095023
Sum128Base_Basic	568.309	461.270	0.678281
Sum128Base	571.026	459.075	0.675053
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	78.660	3332.601	4.900464
Sum128Traits	129.129	2030.089	2.985168
Sum128Traits_ArgsT	23.344	11229.654	16.512780
Sum256Base_Basic	383.775	683.066	1.004423
Sum256Base	375.588	697.957	1.026319
Sum256Avx2_Combine	30.929	8475.714	12.463215
Sum256Traits	31.082	8434.052	12.401953
Sum256Traits_ArgsT	28.568	9176.130	13.493150

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	681.607	384.597
SumBase	642.655	407.908	1.060610
SumTraits	42.878	6113.687	15.896347
SumTraits_Args	30.312	8648.063	22.486038
SumTraits_ArgsT	45.770	5727.476	14.892149
Sum128Base_Basic	1028.184	254.958	0.662923
Sum128Base	1032.855	253.805	0.659925
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	159.347	1645.112	4.277495
Sum128Sse_CombineAvx	50.583	5182.403	13.474893
Sum128Traits	60.566	4328.260	11.254013
Sum128Traits_ArgsT	49.981	5244.849	13.637258
Sum256Base_Basic	686.583	381.810	0.992753
Sum256Base	639.853	409.694	1.065255
Sum256Avx2_Combine	28.028	9352.990	24.318935
Sum256Traits	27.750	9446.798	24.562847
Sum256Traits_ArgsT	31.767	8252.131	21.456565

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1359.033	192.890
SumBase	1234.678	212.318	1.100719
SumTraits	88.924	2947.943	15.283023
SumTraits_Args	60.486	4333.990	22.468708
SumTraits_ArgsT	86.373	3035.012	15.734418
Sum128Base_Basic	1991.888	131.606	0.682284
Sum128Base	1995.502	131.367	0.681048
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	317.174	826.499	4.284821
Sum128Sse_CombineAvx	108.851	2408.277	12.485236
Sum128Traits	279.886	936.608	4.855661
Sum128Traits_ArgsT	93.978	2789.415	14.461168
Sum256Base_Basic	1361.832	192.494	0.997945
Sum256Base	1215.761	215.621	1.117846
Sum256Avx2_Combine	69.975	3746.227	19.421571
Sum256Traits	80.438	3258.955	16.895405
Sum256Traits_ArgsT	63.053	4157.548	21.553979

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	313.579	835.975
SumBase	301.997	868.034	1.038349
SumTraits	25.025	10475.246	12.530571
SumTraits_Args	25.164	10417.370	12.461339
SumTraits_ArgsT	24.487	10705.403	12.805887
Sum128Base_Basic	372.187	704.335	0.842531
Sum128Base	372.223	704.265	0.842448
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	39.632	6614.431	7.912235
Sum128Traits	64.931	4037.268	4.829412
Sum128Traits_ArgsT	15.523	16887.537	20.201004
Sum256Base_Basic	291.307	899.889	1.076455
Sum256Base	287.177	912.830	1.091934
Sum256Avx2_Combine	21.296	12309.309	14.724492
Sum256Traits	21.521	12181.121	14.571152
Sum256Traits_ArgsT	25.647	10221.412	12.226934

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	425.352	616.299
SumBase	418.196	626.845	1.017112
SumTraits	56.502	4639.551	7.528084
SumTraits_Args	50.025	5240.213	8.502710
SumTraits_ArgsT	48.936	5356.835	8.691941
Sum128Base_Basic	629.283	416.576	0.675932
Sum128Base	626.194	418.631	0.679266
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	128.168	2045.308	3.318694
Sum128Traits	128.055	2047.115	3.321626
Sum128Traits_ArgsT	31.047	8443.334	13.700059
Sum256Base_Basic	409.083	640.809	1.039770
Sum256Base	409.193	640.636	1.039489
Sum256Avx2_Combine	43.590	6013.913	9.758108
Sum256Traits	43.943	5965.583	9.679688
Sum256Traits_ArgsT	50.432	5198.018	8.434246

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128PackedSimd: Requires hardware support PackedSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
VectorTraits512Base: Vector byte size mismatch(32!=64) !
VectorTraits512Avx512: Vector512 type is not supported! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi! Vector byte size mismatch(32!=64) !

``` 

#### .NET 8.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.5
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.5\
RuntimeInformation.FrameworkDescription:	.NET 8.0.5
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.5/System.Private.CoreLib.dll
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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
# Sum512Base_Basic	117
SumBase_Basic	216.545	1210.576
SumBase	226.753	1156.079	0.954982
SumTraits	3.055	85801.689	70.876722
SumTraits_Args	3.061	85652.816	70.753745
SumTraits_ArgsT	3.028	86561.324	71.504221
Sum128Base_Basic	270.832	967.923	0.799555
Sum128Base	272.910	960.553	0.793467
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	9.154	28637.430	23.656028
Sum128Traits	5.838	44899.345	37.089228
Sum128Traits_ArgsT	5.790	45278.962	37.402812
Sum256Base_Basic	216.930	1208.427	0.998225
Sum256Base	212.657	1232.710	1.018283
Sum256Avx2_Combine	9.183	28548.036	23.582184
Sum256Avx2_Combine2	10.511	24940.775	20.602396
Sum256Avx2_Combine3	9.233	28391.682	23.453027
Sum256Traits	3.100	84571.884	69.860839
Sum256Traits_ArgsT	3.044	86126.900	71.145364
Sum512Base_Basic	232.442	1127.781	0.931607
Sum512Base	409.600	640.000	0.528674
Sum512Traits	2.661	98496.263	81.363110
Sum512Traits_ArgsT	2.644	99137.727	81.892993

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
# Sum512Base_Basic	-14137
SumBase_Basic	288.680	908.077
SumBase	287.861	910.661	1.002846
SumTraits	5.948	44071.653	48.532964
SumTraits_Args	5.990	43764.227	48.194419
SumTraits_ArgsT	5.926	44237.037	48.715090
Sum128Base_Basic	452.046	579.905	0.638608
Sum128Base	450.110	582.399	0.641355
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	19.818	13227.341	14.566326
Sum128Traits	12.374	21184.440	23.328911
Sum128Traits_ArgsT	12.465	21030.205	23.159063
Sum256Base_Basic	314.151	834.452	0.918922
Sum256Base	296.659	883.655	0.973106
Sum256Avx2_Combine	20.777	12616.944	13.894140
Sum256Traits	5.996	43721.347	48.147198
Sum256Traits_ArgsT	6.060	43260.394	47.639583
Sum512Base_Basic	295.330	887.631	0.977485
Sum512Base	408.118	642.325	0.707346
Sum512Traits	5.362	48887.402	53.836205
Sum512Traits_ArgsT	5.421	48359.538	53.254906

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
# Sum512Base_Basic	-12829441
SumBase_Basic	495.629	528.911
SumBase	493.314	531.394	1.004693
SumTraits	13.234	19809.089	37.452563
SumTraits_Args	13.103	20005.683	37.824258
SumTraits_ArgsT	13.112	19993.213	37.800682
Sum128Base_Basic	794.146	330.095	0.624103
Sum128Base	800.607	327.432	0.619067
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	39.623	6615.926	12.508570
Sum128Traits	24.979	10494.491	19.841679
Sum128Traits_ArgsT	24.985	10492.131	19.837218
Sum256Base_Basic	514.570	509.443	0.963191
Sum256Base	516.969	507.079	0.958721
Sum256Avx2_Combine	21.565	12155.865	22.982799
Sum256Traits	13.000	20164.939	38.125360
Sum256Traits_ArgsT	13.032	20116.161	38.033137
Sum512Base_Basic	490.943	533.961	1.009546
Sum512Base	434.441	603.405	1.140844
Sum512Traits	12.247	21405.561	40.470974
Sum512Traits_ArgsT	11.856	22111.354	41.805401

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
# Sum512Base_Basic	5766085150769386658
SumBase_Basic	953.209	275.012
SumBase	958.540	273.483	0.994438
SumTraits	24.740	10595.995	38.529184
SumTraits_Args	24.562	10672.797	38.808451
SumTraits_ArgsT	24.850	10549.249	38.359204
Sum128Base_Basic	1541.746	170.031	0.618266
Sum128Base	1545.515	169.616	0.616758
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	80.158	3270.350	11.891656
Sum128Traits	50.033	5239.396	19.051505
Sum128Traits_ArgsT	50.115	5230.885	19.020558
Sum256Base_Basic	958.526	273.487	0.994452
Sum256Base	961.274	272.705	0.991610
Sum256Avx2_Combine	41.785	6273.596	22.812067
Sum256Traits	24.702	10612.252	38.588297
Sum256Traits_ArgsT	24.543	10681.157	38.838850
Sum512Base_Basic	903.305	290.205	1.055246
Sum512Base	641.741	408.489	1.485348
Sum512Traits	24.326	10776.324	39.184897
Sum512Traits_ArgsT	24.130	10864.041	39.503854

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
# Sum512Base_Basic	117
SumBase_Basic	224.153	1169.489
SumBase	220.141	1190.803	1.018225
SumTraits	4.924	53241.449	45.525413
SumTraits_Args	4.932	53150.449	45.447601
SumTraits_ArgsT	4.895	53550.693	45.789839
Sum128Base_Basic	292.060	897.569	0.767488
Sum128Base	279.748	937.072	0.801266
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	15.405	17016.828	14.550658
Sum128Sse_Permute	9.469	27683.729	23.671655
Sum128Sse_PermuteLonger	6.206	42240.165	36.118494
Sum128Traits	6.047	43348.647	37.066328
Sum128Traits_ArgsT	6.172	42470.241	36.315226
Sum256Base_Basic	227.167	1153.972	0.986732
Sum256Base	225.003	1165.069	0.996221
Sum256Avx2_Combine	14.447	18145.835	15.516043
Sum256Avx2_Permute	5.084	51562.377	44.089681
Sum256Avx2_PermuteLonger	5.009	52329.585	44.745701
Sum256Traits	4.952	52935.691	45.263967
Sum256Traits_ArgsT	4.967	52774.191	45.125872
Sum512Base_Basic	248.485	1054.970	0.902078
Sum512Base	669.947	391.291	0.334583
Sum512Traits	4.704	55727.845	47.651467
Sum512Traits_ArgsT	3.638	72050.793	61.608806

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
# Sum512Base_Basic	-14137
SumBase_Basic	296.235	884.919
SumBase	298.338	878.681	0.992952
SumTraits	9.757	26867.180	30.361192
SumTraits_Args	9.784	26794.113	30.278622
SumTraits_ArgsT	9.856	26597.609	30.056563
Sum128Base_Basic	457.606	572.860	0.647359
Sum128Base	459.358	570.675	0.644889
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	30.355	8635.843	9.758913
Sum128Sse_Permute	19.546	13411.856	15.156036
Sum128Sse_PermuteLonger	12.599	20807.112	23.513026
Sum128Traits	12.231	21432.634	24.219896
Sum128Traits_ArgsT	12.186	21511.833	24.309395
Sum256Base_Basic	296.627	883.748	0.998678
Sum256Base	297.170	882.135	0.996854
Sum256Avx2_Combine	31.239	8391.430	9.482715
Sum256Avx2_Permute	10.740	24407.474	27.581606
Sum256Avx2_PermuteLonger	9.957	26326.994	29.750755
Sum256Traits	9.923	26416.623	29.852040
Sum256Traits_ArgsT	9.863	26578.020	30.034427
Sum512Base_Basic	308.023	851.054	0.961732
Sum512Base	639.105	410.174	0.463516
Sum512Traits	9.996	26225.800	29.636401
Sum512Traits_ArgsT	7.390	35471.542	40.084529

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
# Sum512Base_Basic	-12829441
SumBase_Basic	544.849	481.131
SumBase	540.178	485.292	1.008648
SumTraits	19.951	13139.245	27.309067
SumTraits_Args	20.129	13023.074	27.067614
SumTraits_ArgsT	19.923	13157.848	27.347733
Sum128Base_Basic	832.630	314.838	0.654371
Sum128Base	832.660	314.827	0.654348
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	61.638	4252.954	8.839488
Sum128Sse_CombineAvx	44.277	5920.605	12.305594
Sum128Sse_Permute	41.150	6370.431	13.240527
Sum128Sse_PermuteLonger	25.171	10414.638	21.646149
Sum128Traits	24.795	10572.574	21.974409
Sum128Traits_ArgsT	25.110	10439.912	21.698679
Sum256Base_Basic	536.355	488.751	1.015837
Sum256Base	539.661	485.757	1.009614
Sum256Avx2_Combine	32.288	8119.007	16.874829
Sum256Avx2_Permute	22.142	11839.314	24.607246
Sum256Avx2_PermuteLonger	19.794	13243.740	27.526253
Sum256Traits	19.891	13179.138	27.391983
Sum256Traits_ArgsT	20.090	13048.541	27.120545
Sum512Base_Basic	523.227	501.014	1.041324
Sum512Base	664.456	394.524	0.819993
Sum512Traits	19.989	13114.343	27.257310
Sum512Traits_ArgsT	15.437	16982.002	35.295988

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
# Sum512Base_Basic	5766085150769386658
SumBase_Basic	1030.653	254.347
SumBase	1028.096	254.980	1.002487
SumTraits	39.176	6691.506	26.308521
SumTraits_Args	39.480	6639.938	26.105774
SumTraits_ArgsT	39.475	6640.773	26.109057
Sum128Base_Basic	1643.637	159.490	0.627056
Sum128Base	1634.653	160.367	0.630503
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	123.680	2119.532	8.333212
Sum128Sse_CombineAvx	95.732	2738.300	10.765979
Sum128Sse_Permute	80.600	3252.403	12.787243
Sum128Sse_PermuteLonger	48.918	5358.797	21.068801
Sum128Traits	49.901	5253.230	20.653751
Sum128Traits_ArgsT	49.768	5267.329	20.709184
Sum256Base_Basic	1018.479	257.388	1.011953
Sum256Base	1016.598	257.864	1.013826
Sum256Avx2_Combine	61.129	4288.361	16.860244
Sum256Avx2_Permute	43.100	6082.162	23.912805
Sum256Avx2_PermuteLonger	39.955	6561.028	25.795528
Sum256Traits	39.518	6633.518	26.080533
Sum256Traits_ArgsT	39.593	6621.031	26.031438
Sum512Base_Basic	1048.442	250.032	0.983033
Sum512Base	964.149	271.892	1.068977
Sum512Traits	37.880	6920.347	27.208239
Sum512Traits_ArgsT	29.978	8744.421	34.379821

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
# Sum512Base_Basic	117
SumBase_Basic	235.215	1114.486
SumBase	243.682	1075.764	0.965256
SumTraits	5.027	52144.394	46.787856
SumTraits_Args	4.944	53020.987	47.574402
SumTraits_ArgsT	5.031	52107.975	46.755179
Sum128Base_Basic	284.476	921.499	0.826838
Sum128Base	282.436	928.152	0.832808
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	19.446	13480.784	12.095969
Sum128Sse_Permute	10.061	26056.172	23.379549
Sum128Sse_PermuteLonger	6.273	41792.373	37.499247
Sum128Traits	6.367	41170.181	36.940971
Sum128Traits_ArgsT	6.126	42789.011	38.393506
Sum256Base_Basic	231.754	1131.129	1.014934
Sum256Base	228.621	1146.629	1.028842
Sum256Avx2_Combine	20.434	12828.651	11.510827
Sum256Avx2_Permute	5.270	49740.974	44.631328
Sum256Avx2_PermuteLonger	4.967	52774.278	47.353035
Sum256Traits	5.046	51946.824	46.610582
Sum256Traits_ArgsT	5.072	51687.263	46.377684
Sum512Base_Basic	251.144	1043.801	0.936576
Sum512Base	771.511	339.780	0.304876
Sum512Traits	4.969	52752.002	47.333047
Sum512Traits_ArgsT	3.983	65815.184	59.054314

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
# Sum512Base_Basic	-14137
SumBase_Basic	317.807	824.854
SumBase	322.870	811.918	0.984317
SumTraits	9.946	26355.726	31.951989
SumTraits_Args	9.982	26260.398	31.836419
SumTraits_ArgsT	9.803	26741.524	32.419705
Sum128Base_Basic	476.426	550.230	0.667064
Sum128Base	470.302	557.395	0.675750
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	39.801	6586.319	7.984830
Sum128Sse_Permute	20.540	12762.358	15.472263
Sum128Sse_PermuteLonger	12.424	21100.057	25.580354
Sum128Traits	12.326	21267.663	25.783548
Sum128Traits_ArgsT	12.124	21622.526	26.213761
Sum256Base_Basic	326.237	803.538	0.974158
Sum256Base	317.030	826.875	1.002450
Sum256Avx2_Combine	41.400	6331.938	7.676434
Sum256Avx2_Permute	10.864	24129.952	29.253603
Sum256Avx2_PermuteLonger	9.835	26655.111	32.314944
Sum256Traits	9.976	26276.300	31.855698
Sum256Traits_ArgsT	10.002	26208.537	31.773547
Sum512Base_Basic	326.081	803.922	0.974623
Sum512Base	820.767	319.389	0.387207
Sum512Traits	10.192	25719.843	31.181085
Sum512Traits_ArgsT	7.749	33830.769	41.014251

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128PackedSimd: Requires hardware support PackedSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
VectorTraits512Base: Vector byte size mismatch(32!=64) !
VectorTraits512Avx512: Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi! Vector byte size mismatch(32!=64) !

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
Environment.OSVersion:	Unix 14.4.1
Environment.Version:	6.0.30
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.30/
RuntimeInformation.FrameworkDescription:	.NET 6.0.30
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 23.4.0 Darwin Kernel Version 23.4.0: Fri Mar 15 00:19:22 PDT 2024; root:xnu-10063.101.17~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.14-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, ArmBase, Crc32
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	258.004	1016.045
SumBase	259.443	1010.411	0.994455
SumTraits	10.876	24102.186	23.721577
SumTraits_Args	9.682	27076.410	26.648834
SumTraits_ArgsT	18.218	14389.214	14.161987
Sum128Base_Basic	326.388	803.167	0.790484
Sum128Base	318.391	823.340	0.810339
Sum128Arm	14.093	18601.222	18.307481
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.379	27949.433	27.508071
Sum128Traits_ArgsT	15.106	17353.659	17.079620
Sum256Base_Basic	310.662	843.823	0.830498
Sum256Base	317.698	825.137	0.812107
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	320.649	817.542	0.804632
Sum256Traits_ArgsT	333.945	784.992	0.772595

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	385.886	679.331
SumBase	385.217	680.509	1.001735
SumTraits	25.325	10351.092	15.237196
SumTraits_Args	19.358	13541.706	19.933899
SumTraits_ArgsT	36.428	7196.310	10.593239
Sum128Base_Basic	461.010	568.630	0.837045
Sum128Base	460.305	569.500	0.838326
Sum128Arm	31.666	8278.361	12.186058
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.286	13592.745	20.009031
Sum128Traits_ArgsT	30.209	8677.574	12.773714
Sum256Base_Basic	472.093	555.280	0.817393
Sum256Base	471.434	556.056	0.818535
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	472.555	554.737	0.816594
Sum256Traits_ArgsT	513.349	510.654	0.751702

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	701.875	373.491
SumBase	703.100	372.840	0.998258
SumTraits	50.627	5177.910	13.863537
SumTraits_Args	38.588	6793.377	18.188851
SumTraits_ArgsT	72.450	3618.298	9.687771
Sum128Base_Basic	887.468	295.384	0.790873
Sum128Base	889.556	294.691	0.789017
Sum128Arm	63.309	4140.705	11.086484
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.587	6793.644	18.189566
Sum128Traits_ArgsT	60.315	4346.238	11.636785
Sum256Base_Basic	706.587	371.001	0.993331
Sum256Base	708.165	370.174	0.991117
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	707.704	370.415	0.991763
Sum256Traits_ArgsT	805.374	325.494	0.871489

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	1346.104	194.743
SumBase	1348.664	194.373	0.998102
SumTraits	106.032	2472.321	12.695315
SumTraits_Args	77.123	3399.029	17.453942
SumTraits_ArgsT	145.217	1805.187	9.269595
Sum128Base_Basic	1656.674	158.235	0.812534
Sum128Base	1654.030	158.488	0.813833
Sum128Arm	131.286	1996.742	10.253226
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	81.937	3199.319	16.428436
Sum128Traits_ArgsT	120.563	2174.334	11.165158
Sum256Base_Basic	1272.865	205.948	1.057539
Sum256Base	1279.994	204.801	1.051648
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1278.482	205.043	1.052893
Sum256Traits_ArgsT	1500.709	174.680	0.896979

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	278.733	940.485
SumBase	278.420	941.541	1.001123
SumTraits	13.887	18877.497	20.072093
SumTraits_Args	12.080	21700.657	23.073907
SumTraits_ArgsT	22.739	11528.336	12.257867
Sum128Base_Basic	343.806	762.475	0.810726
Sum128Base	344.809	760.259	0.808370
Sum128Arm	20.128	13024.136	13.848324
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.671	27106.044	28.821355
Sum128Traits_ArgsT	16.911	15501.782	16.482759
Sum256Base_Basic	330.579	792.983	0.843165
Sum256Base	340.008	770.994	0.819784
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	342.184	766.091	0.814570
Sum256Traits_ArgsT	362.657	722.843	0.768585

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	434.274	603.638
SumBase	427.802	612.770	1.015129
SumTraits	31.374	8355.441	13.841818
SumTraits_Args	24.125	10865.900	18.000702
SumTraits_ArgsT	46.066	5690.628	9.427226
Sum128Base_Basic	496.909	527.549	0.873950
Sum128Base	496.408	528.082	0.874832
Sum128Arm	48.947	5355.648	8.872290
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	24.266	10802.738	17.896067
Sum128Traits_ArgsT	33.777	7761.131	12.857270
Sum256Base_Basic	514.804	509.211	0.843571
Sum256Base	511.189	512.813	0.849538
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	511.681	512.319	0.848720
Sum256Traits_ArgsT	551.306	475.496	0.787718

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	697.119	376.039
SumBase	694.336	377.546	1.004008
SumTraits	68.340	3835.886	10.200762
SumTraits_Args	48.231	5435.217	14.453859
SumTraits_ArgsT	91.881	2853.096	7.587232
Sum128Base_Basic	994.005	263.725	0.701323
Sum128Base	989.271	264.987	0.704679
Sum128Arm	98.122	2671.603	7.104586
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	48.486	5406.620	14.377809
Sum128Traits_ArgsT	67.512	3882.904	10.325795
Sum256Base_Basic	797.378	328.757	0.874264
Sum256Base	792.846	330.637	0.879261
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	795.388	329.580	0.876452
Sum256Traits_ArgsT	901.461	290.799	0.773321

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	1328.594	197.309
SumBase	1326.655	197.598	1.001461
SumTraits	130.132	2014.444	10.209569
SumTraits_Args	96.416	2718.872	13.779739
SumTraits_ArgsT	185.801	1410.886	7.150630
Sum128Base_Basic	1845.011	142.083	0.720101
Sum128Base	1825.876	143.572	0.727647
Sum128Arm	195.562	1340.463	6.793711
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	96.831	2707.240	13.720788
Sum128Traits_ArgsT	134.961	1942.375	9.844313
Sum256Base_Basic	1473.658	177.887	0.901562
Sum256Base	1481.531	176.941	0.896771
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1474.397	177.797	0.901110
Sum256Traits_ArgsT	1706.664	153.600	0.778474

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	298.943	876.904
SumBase	293.069	894.479	1.020042
SumTraits	16.894	15517.154	17.695379
SumTraits_Args	14.487	18095.038	20.635133
SumTraits_ArgsT	28.153	9311.309	10.618387
Sum128Base_Basic	361.129	725.901	0.827800
Sum128Base	361.854	724.447	0.826142
Sum128Arm	28.666	9144.770	10.428469
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	13.279	19740.603	22.511696
Sum128Traits_ArgsT	18.713	14008.313	15.974734
Sum256Base_Basic	347.015	755.425	0.861467
Sum256Base	361.831	724.493	0.826194
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	366.300	715.654	0.816114
Sum256Traits_ArgsT	390.074	672.036	0.766373

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	463.296	565.824
SumBase	461.950	567.473	1.002915
SumTraits	37.352	7018.225	12.403553
SumTraits_Args	28.940	9058.163	16.008805
SumTraits_ArgsT	55.769	4700.519	8.307390
Sum128Base_Basic	528.035	496.452	0.877397
Sum128Base	529.568	495.015	0.874858
Sum128Arm	63.729	4113.422	7.269794
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	31.549	8309.184	14.685110
Sum128Traits_ArgsT	37.384	7012.143	12.392804
Sum256Base_Basic	558.462	469.404	0.829593
Sum256Base	554.501	472.757	0.835519
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	557.279	470.400	0.831354
Sum256Traits_ArgsT	592.190	442.669	0.782343

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits128PackedSimd: Requires hardware support PackedSimd!
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: Requires hardware support Sse, Sse2!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
VectorTraits512Base: Vector byte size mismatch(16!=64) !
VectorTraits512Avx512: Vector512 type is not supported! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi! Vector byte size mismatch(16!=64) !

```

#### .NET 7.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 14.4.1
Environment.Version:	7.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.19/
RuntimeInformation.FrameworkDescription:	.NET 7.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 23.4.0 Darwin Kernel Version 23.4.0: Fri Mar 15 00:19:22 PDT 2024; root:xnu-10063.101.17~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.14-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.19/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	230.411	1137.722
SumBase	230.011	1139.702	1.001741
SumTraits	9.670	27108.536	23.827034
SumTraits_Args	9.652	27159.331	23.871680
SumTraits_ArgsT	9.679	27082.986	23.804576
Sum128Base_Basic	227.497	1152.296	1.012810
Sum128Base	227.178	1153.913	1.014231
Sum128Arm	13.395	19569.599	17.200689
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.646	27176.295	23.886591
Sum128Traits_ArgsT	9.657	27146.071	23.860025
Sum256Base_Basic	330.756	792.560	0.696621
Sum256Base	330.889	792.242	0.696340
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	330.699	792.696	0.696740
Sum256Traits_ArgsT	336.194	779.740	0.685352

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	310.544	844.144
SumBase	309.489	847.021	1.003408
SumTraits	21.708	12075.752	14.305320
SumTraits_Args	19.290	13589.929	16.099063
SumTraits_ArgsT	19.380	13526.606	16.024048
Sum128Base_Basic	305.335	858.545	1.017060
Sum128Base	305.170	859.011	1.017612
Sum128Arm	33.019	7939.105	9.404916
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.324	13565.518	16.070145
Sum128Traits_ArgsT	19.292	13588.290	16.097121
Sum256Base_Basic	408.443	641.813	0.760313
Sum256Base	408.459	641.788	0.760282
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	408.931	641.046	0.759404
Sum256Traits_ArgsT	428.568	611.674	0.724608

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	606.473	432.244
SumBase	606.967	431.892	0.999186
SumTraits	43.393	6041.150	13.976263
SumTraits_Args	38.567	6797.089	15.725136
SumTraits_ArgsT	46.650	5619.363	13.000456
Sum128Base_Basic	609.539	430.069	0.994969
Sum128Base	582.634	449.929	1.040916
Sum128Arm	66.015	3970.990	9.186926
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.562	6797.958	15.727146
Sum128Traits_ArgsT	38.642	6783.959	15.694759
Sum256Base_Basic	595.747	440.025	1.018003
Sum256Base	593.317	441.828	1.022174
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	593.392	441.772	1.022044
Sum256Traits_ArgsT	643.917	407.108	0.941849

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	1177.879	222.556
SumBase	1179.023	222.340	0.999030
SumTraits	91.601	2861.790	12.858747
SumTraits_Args	77.215	3394.974	15.254479
SumTraits_ArgsT	87.755	2987.223	13.422351
Sum128Base_Basic	1177.056	222.712	1.000699
Sum128Base	1135.988	230.763	1.036877
Sum128Arm	137.353	1908.541	8.575560
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.094	3400.298	15.278401
Sum128Traits_ArgsT	77.127	3398.868	15.271974
Sum256Base_Basic	1075.061	243.841	1.095640
Sum256Base	1050.251	249.601	1.121522
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1046.934	250.392	1.125075
Sum256Traits_ArgsT	1193.259	219.687	0.987112

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	239.545	1094.343
SumBase	242.742	1079.929	0.986828
SumTraits	15.199	17247.328	15.760436
SumTraits_Args	11.155	23499.220	21.473353
SumTraits_ArgsT	18.588	14102.784	12.886984
Sum128Base_Basic	240.285	1090.973	0.996920
Sum128Base	241.480	1085.572	0.991985
Sum128Arm	20.695	12667.000	11.574978
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.674	27099.185	24.762965
Sum128Traits_ArgsT	9.663	27127.265	24.788624
Sum256Base_Basic	342.045	766.402	0.700331
Sum256Base	342.114	766.248	0.700189
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	342.035	766.425	0.700352
Sum256Traits_ArgsT	346.888	755.702	0.690553

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	330.535	793.090
SumBase	332.392	788.660	0.994414
SumTraits	28.947	9056.043	11.418683
SumTraits_Args	21.758	12048.224	15.191499
SumTraits_ArgsT	28.897	9071.674	11.438393
Sum128Base_Basic	329.920	794.569	1.001865
Sum128Base	327.533	800.360	1.009167
Sum128Arm	47.130	5562.154	7.013271
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	22.102	11860.744	14.955106
Sum128Traits_ArgsT	19.327	13563.465	17.102052
Sum256Base_Basic	435.402	602.073	0.759149
Sum256Base	436.068	601.154	0.757990
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	435.908	601.375	0.758268
Sum256Traits_ArgsT	458.739	571.444	0.720529

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	597.041	439.072
SumBase	597.243	438.923	0.999662
SumTraits	57.937	4524.676	10.305096
SumTraits_Args	43.551	6019.204	13.708930
SumTraits_ArgsT	60.884	4305.650	9.806257
Sum128Base_Basic	645.335	406.214	0.925165
Sum128Base	569.727	460.123	1.047944
Sum128Arm	94.545	2772.690	6.314891
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	44.138	5939.197	13.526711
Sum128Traits_ArgsT	38.721	6770.102	15.419125
Sum256Base_Basic	654.342	400.623	0.912431
Sum256Base	647.602	404.792	0.921926
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	647.654	404.760	0.921853
Sum256Traits_ArgsT	706.724	370.928	0.844801

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	1168.164	224.407
SumBase	1161.883	225.620	1.005406
SumTraits	120.509	2175.301	9.693561
SumTraits_Args	86.775	3020.966	13.462010
SumTraits_ArgsT	124.761	2101.171	9.363225
Sum128Base_Basic	1211.020	216.465	0.964612
Sum128Base	1098.672	238.601	1.063251
Sum128Arm	185.985	1409.486	6.280944
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	88.192	2972.428	13.245714
Sum128Traits_ArgsT	77.119	3399.221	15.147587
Sum256Base_Basic	1207.508	217.095	0.967417
Sum256Base	1200.791	218.309	0.972829
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1190.969	220.110	0.980852
Sum256Traits_ArgsT	1339.204	195.746	0.872283

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	253.383	1034.575
SumBase	250.339	1047.157	1.012162
SumTraits	17.610	14885.979	14.388503
SumTraits_Args	13.299	19712.185	19.053421
SumTraits_ArgsT	19.545	13412.372	12.964142
Sum128Base_Basic	252.439	1038.443	1.003739
Sum128Base	250.926	1044.708	1.009795
Sum128Arm	27.956	9377.006	9.063634
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	13.286	19730.715	19.071331
Sum128Traits_ArgsT	10.279	25503.518	24.651212
Sum256Base_Basic	355.678	737.027	0.712396
Sum256Base	355.909	736.548	0.711934
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	355.766	736.844	0.712219
Sum256Traits_ArgsT	360.806	726.550	0.702270

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	352.792	743.055
SumBase	352.782	743.077	1.000030
SumTraits	38.076	6884.835	9.265585
SumTraits_Args	26.552	9872.741	13.286697
SumTraits_ArgsT	38.523	6804.932	9.158053
Sum128Base_Basic	351.672	745.423	1.003187
Sum128Base	350.435	748.054	1.006728
Sum128Arm	61.546	4259.317	5.732173
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	29.884	8772.038	11.805376
Sum128Traits_ArgsT	20.564	12747.485	17.155518
Sum256Base_Basic	457.903	572.488	0.770452
Sum256Base	459.696	570.255	0.767447
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	458.458	571.795	0.769520
Sum256Traits_ArgsT	489.854	535.147	0.720199

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits128PackedSimd: Requires hardware support PackedSimd!
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: Requires hardware support Sse, Sse2!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
VectorTraits512Base: Vector byte size mismatch(16!=64) !
VectorTraits512Avx512: Vector512 type is not supported! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi! Vector byte size mismatch(16!=64) !

```

#### .NET 8.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 14.4.1
Environment.Version:	8.0.4
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.4/
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 23.4.0 Darwin Kernel Version 23.4.0: Fri Mar 15 00:19:22 PDT 2024; root:xnu-10063.101.17~1/RELEASE_ARM64_T8112
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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	168.632	1554.534
SumBase	168.609	1554.743	1.000134
SumTraits	9.359	28010.444	18.018549
SumTraits_Args	9.360	28006.377	18.015932
SumTraits_ArgsT	9.369	27979.540	17.998669
Sum128Base_Basic	168.789	1553.086	0.999069
Sum128Base	168.865	1552.391	0.998621
Sum128Arm	9.641	27189.427	17.490405
Sum128Arm_Combine	12.110	21646.983	13.925064
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.628	27227.238	17.514728
Sum128Traits_ArgsT	9.631	27219.635	17.509837
Sum256Base_Basic	163.276	1605.530	1.032805
Sum256Base	163.228	1605.997	1.033105
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	163.222	1606.063	1.033148
Sum256Traits_ArgsT	163.231	1605.973	1.033090
Sum512Base_Basic	173.093	1514.468	0.974227
Sum512Base	172.829	1516.784	0.975716
Sum512Traits	172.927	1515.924	0.975163
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	227.974	1149.885
SumBase	222.920	1175.954	1.022671
SumTraits	19.258	13611.996	11.837707
SumTraits_Args	19.258	13612.277	11.837951
SumTraits_ArgsT	19.256	13613.914	11.839374
Sum128Base_Basic	226.979	1154.927	1.004385
Sum128Base	227.694	1151.299	1.001230
Sum128Arm	19.287	13591.940	11.820265
Sum128Arm_Combine	28.551	9181.500	7.984715
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	18.755	13977.417	12.155496
Sum128Traits_ArgsT	18.730	13996.218	12.171846
Sum256Base_Basic	172.413	1520.439	1.322253
Sum256Base	172.314	1521.315	1.323016
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	172.585	1518.930	1.320941
Sum256Traits_ArgsT	172.405	1520.511	1.322316
Sum512Base_Basic	191.627	1367.990	1.189676
Sum512Base	191.917	1365.921	1.187876
Sum512Traits	191.682	1367.596	1.189333
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	214.542	1221.878
SumBase	214.522	1221.991	1.000092
SumTraits	37.482	6993.893	5.723887
SumTraits_Args	37.485	6993.277	5.723382
SumTraits_ArgsT	37.473	6995.503	5.725204
Sum128Base_Basic	214.485	1222.199	1.000263
Sum128Base	214.461	1222.341	1.000378
Sum128Arm	38.607	6790.129	5.557123
Sum128Arm_Combine	56.983	4600.405	3.765026
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.118	6877.249	5.628423
Sum128Traits_ArgsT	38.534	6802.923	5.567594
Sum256Base_Basic	201.823	1298.882	1.063020
Sum256Base	201.959	1298.008	1.062306
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	201.896	1298.412	1.062636
Sum256Traits_ArgsT	201.518	1300.845	1.064628
Sum512Base_Basic	229.348	1142.996	0.935442
Sum512Base	229.956	1139.972	0.932967
Sum512Traits	229.796	1140.768	0.933618
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	332.780	787.741
SumBase	332.748	787.815	1.000094
SumTraits	77.075	3401.159	4.317613
SumTraits_Args	77.074	3401.215	4.317684
SumTraits_ArgsT	77.078	3401.020	4.317436
Sum128Base_Basic	332.864	787.540	0.999746
Sum128Base	332.697	787.936	1.000248
Sum128Arm	77.135	3398.503	4.314240
Sum128Arm_Combine	113.982	2299.873	2.919582
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.096	3400.231	4.316434
Sum128Traits_ArgsT	76.654	3419.843	4.341331
Sum256Base_Basic	248.508	1054.873	1.339112
Sum256Base	246.229	1064.634	1.351503
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	246.366	1064.043	1.350753
Sum256Traits_ArgsT	246.287	1064.383	1.351184
Sum512Base_Basic	375.734	697.684	0.885677
Sum512Base	376.111	696.985	0.884790
Sum512Traits	378.297	692.959	0.879679
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	168.581	1555.002
SumBase	168.640	1554.459	0.999650
SumTraits	9.629	27225.634	17.508420
SumTraits_Args	9.629	27224.774	17.507867
SumTraits_ArgsT	9.631	27219.890	17.504726
Sum128Base_Basic	168.643	1554.428	0.999631
Sum128Base	168.681	1554.082	0.999408
Sum128Arm	9.645	27177.887	17.477714
Sum128Arm_Combine	19.415	13502.080	8.682996
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Traits	9.636	27204.027	17.494525
Sum128Traits_ArgsT	9.635	27208.005	17.497083
Sum256Base_Basic	165.289	1585.975	1.019918
Sum256Base	165.059	1588.179	1.021336
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi!
Sum256Traits	165.134	1587.459	1.020873
Sum256Traits_ArgsT	165.673	1582.296	1.017552
Sum512Base_Basic	179.788	1458.074	0.937667
Sum512Base	179.855	1457.532	0.937318
Sum512Traits	179.867	1457.436	0.937257
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	212.312	1234.711
SumBase	209.031	1254.094	1.015698
SumTraits	19.312	13573.871	10.993559
SumTraits_Args	19.295	13586.103	11.003465
SumTraits_ArgsT	19.298	13583.752	11.001561
Sum128Base_Basic	209.632	1250.494	1.012782
Sum128Base	207.531	1263.158	1.023039
Sum128Arm	19.495	13446.544	10.890436
Sum128Arm_Combine	41.377	6335.478	5.131141
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Traits	19.268	13604.796	11.018605
Sum128Traits_ArgsT	19.276	13599.351	11.014195
Sum256Base_Basic	175.898	1490.315	1.207015
Sum256Base	176.308	1486.849	1.204208
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512BW!
Sum256Traits	175.942	1489.943	1.206714
Sum256Traits_ArgsT	177.081	1480.364	1.198956
Sum512Base_Basic	205.458	1275.903	1.033361
Sum512Base	205.659	1274.653	1.032349
Sum512Traits	205.481	1275.759	1.033245
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	226.514	1157.298
SumBase	226.531	1157.210	0.999924
SumTraits	38.559	6798.436	5.874402
SumTraits_Args	38.544	6801.217	5.876805
SumTraits_ArgsT	38.541	6801.645	5.877175
Sum128Base_Basic	226.534	1157.193	0.999909
Sum128Base	226.546	1157.135	0.999859
Sum128Arm	40.513	6470.569	5.591098
Sum128Arm_Combine	82.745	3168.083	2.737481
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Traits	38.553	6799.510	5.875330
Sum128Traits_ArgsT	38.540	6801.869	5.877369
Sum256Base_Basic	208.581	1256.797	1.085975
Sum256Base	208.605	1256.650	1.085848
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	208.562	1256.909	1.086071
Sum256Traits_ArgsT	213.996	1224.996	1.058496
Sum512Base_Basic	256.892	1020.446	0.881748
Sum512Base	256.852	1020.604	0.881885
Sum512Traits	257.172	1019.333	0.880787
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	356.630	735.058
SumBase	356.605	735.110	1.000070
SumTraits	77.130	3398.732	4.623759
SumTraits_Args	77.097	3400.187	4.625738
SumTraits_ArgsT	77.097	3400.199	4.625755
Sum128Base_Basic	356.501	735.325	1.000363
Sum128Base	356.683	734.949	0.999851
Sum128Arm	79.865	3282.347	4.465424
Sum128Arm_Combine	165.363	1585.261	2.156647
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum128Traits	77.087	3400.623	4.626332
Sum128Traits_ArgsT	77.084	3400.736	4.626485
Sum256Base_Basic	287.440	911.997	1.240714
Sum256Base	287.531	911.706	1.240318
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	283.823	923.619	1.256524
Sum256Traits_ArgsT	277.931	943.197	1.283159
Sum512Base_Basic	460.956	568.696	0.773675
Sum512Base	461.992	567.421	0.771940
Sum512Traits	462.233	567.126	0.771539
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	171.022	1532.811
SumBase	171.079	1532.302	0.999668
SumTraits	9.640	27192.497	17.740282
SumTraits_Args	9.637	27202.917	17.747080
SumTraits_ArgsT	9.636	27205.125	17.748521
Sum128Base_Basic	171.010	1532.918	1.000070
Sum128Base	171.053	1532.529	0.999816
Sum128Arm	10.466	25047.236	16.340722
Sum128Arm_Combine	26.742	9802.843	6.395338
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Traits	9.639	27195.346	17.742141
Sum128Traits_ArgsT	9.635	27208.729	17.750872
Sum256Base_Basic	167.531	1564.748	1.020836
Sum256Base	167.480	1565.229	1.021149
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi!
Sum256Traits	167.565	1564.432	1.020629
Sum256Traits_ArgsT	168.360	1557.043	1.015809
Sum512Base_Basic	184.343	1422.045	0.927737
Sum512Base	184.464	1421.114	0.927130
Sum512Traits	184.394	1421.650	0.927479
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	198.144	1322.998
SumBase	198.082	1323.410	1.000311
SumTraits	19.278	13598.131	10.278266
SumTraits_Args	19.268	13605.175	10.283590
SumTraits_ArgsT	19.275	13600.445	10.280016
Sum128Base_Basic	199.753	1312.341	0.991945
Sum128Base	199.934	1311.154	0.991047
Sum128Arm	26.631	9843.613	7.440381
Sum128Arm_Combine	57.125	4588.981	3.468622
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Traits	19.292	13588.192	10.270754
Sum128Traits_ArgsT	19.273	13601.308	10.280668
Sum256Base_Basic	180.747	1450.336	1.096249
Sum256Base	180.720	1450.549	1.096410
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512BW!
Sum256Traits	180.694	1450.760	1.096569
Sum256Traits_ArgsT	182.652	1435.214	1.084819
Sum512Base_Basic	214.706	1220.943	0.922860
Sum512Base	214.719	1220.869	0.922804
Sum512Traits	214.759	1220.642	0.922633
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits128PackedSimd: Requires hardware support PackedSimd!
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: Requires hardware support Sse, Sse2!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
VectorTraits512Base: Vector byte size mismatch(16!=64) !
VectorTraits512Avx512: Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi! Vector byte size mismatch(16!=64) !

```


## Wasm

### Wasm - AMD Ryzen 7 7840H
Wasm - `AMD Ryzen 7 7840H w/ Radeon 780M Graphics` - Chrome

#### .NET 8.0 
``` 
VectorTraits.Benchmarks.Wasm


IsRelease:	True
Environment.ProcessorCount:	1
Environment.Is64BitProcess:	False
Environment.OSVersion:	Other 1.0.0.0
Environment.Version:	8.0.5
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/
RuntimeInformation.FrameworkDescription:	.NET 8.0.5
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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	2941.667	89.114
SumBase	2914.323	89.950	1.009383
SumTraits	100.407	2610.817	29.297455
SumTraits_Args	163.184	1606.436	18.026731
SumTraits_ArgsT	176.335	1486.628	16.682297
Sum128Base_Basic	2919.531	89.790	1.007582
Sum128Base	87.712	2988.704	33.537948
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	90.413	2899.393	32.535734
Sum128Traits_ArgsT	160.254	1635.804	18.356287
Sum256Base_Basic	2836.719	92.411	1.036996
Sum256Base	2911.198	90.047	1.010466
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3141.406	83.448	0.936417
Sum256Traits_ArgsT	2920.312	89.766	1.007312
Sum512Base_Basic	2667.708	98.266	1.102694
Sum512Base	2582.292	101.516	1.139169
Sum512Traits	2828.906	92.666	1.039860
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	4852.604	54.021
SumBase	4717.188	55.572	1.028707
SumTraits	425.684	615.819	11.399556
SumTraits_Args	326.628	802.578	14.856687
SumTraits_ArgsT	336.784	778.375	14.408660
Sum128Base_Basic	4710.938	55.646	1.030072
Sum128Base	2203.385	118.973	2.202340
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	424.479	617.566	11.431902
Sum128Traits_ArgsT	324.219	808.541	14.967068
Sum256Base_Basic	4259.896	61.538	1.139137
Sum256Base	4296.875	61.008	1.129333
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4908.854	53.402	0.988541
Sum256Traits_ArgsT	4489.583	58.389	1.080858
Sum512Base_Basic	4111.458	63.759	1.180263
Sum512Base	4143.750	63.263	1.171066
Sum512Traits	4673.438	56.092	1.038337
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	8502.083	30.833
SumBase	8343.750	31.418	1.018976
SumTraits	879.557	298.041	9.666321
SumTraits_Args	973.698	269.225	8.731746
SumTraits_ArgsT	1036.068	253.018	8.206108
Sum128Base_Basic	8373.958	31.305	1.015300
Sum128Base	4075.000	64.330	2.086401
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	4907.292	53.419	1.732541
Sum128Traits_ArgsT	4955.208	52.903	1.715787
Sum256Base_Basic	16847.917	15.559	0.504637
Sum256Base	16489.583	15.898	0.515603
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	18604.167	14.091	0.456999
Sum256Traits_ArgsT	19231.250	13.631	0.442097
Sum512Base_Basic	13846.875	18.932	0.614007
Sum512Base	13623.958	19.241	0.624054
Sum512Traits	14729.167	17.798	0.577228
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	44350.000	5.911
SumBase	45962.500	5.703	0.964917
SumTraits	15725.000	16.671	2.820350
SumTraits_Args	11102.083	23.612	3.994746
SumTraits_ArgsT	12688.542	20.660	3.495280
Sum128Base_Basic	56333.333	4.653	0.787278
Sum128Base	55420.833	4.730	0.800241
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	12134.375	21.603	3.654906
Sum128Traits_ArgsT	9461.458	27.707	4.687438
Sum256Base_Basic	48904.167	5.360	0.906876
Sum256Base	50487.500	5.192	0.878435
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	56904.167	4.607	0.779381
Sum256Traits_ArgsT	57533.334	4.556	0.770857
Sum512Base_Basic	45783.333	5.726	0.968693
Sum512Base	43504.167	6.026	1.019443
Sum512Traits	47825.000	5.481	0.927339
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	9230.208	28.401
SumBase	9578.125	27.369	0.963676
SumTraits	1683.984	155.669	5.481172
SumTraits_Args	1670.964	156.882	5.523884
SumTraits_ArgsT	1826.432	143.528	5.053682
Sum128Base_Basic	9479.167	27.655	0.973736
Sum128Base	1908.854	137.331	4.835471
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Traits	1366.016	191.904	6.757030
Sum128Traits_ArgsT	1506.771	173.977	6.125821
Sum256Base_Basic	8283.333	31.647	1.114311
Sum256Base	8119.792	32.285	1.136754
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi!
Sum256Traits	8738.542	29.999	1.056264
Sum256Traits_ArgsT	8936.458	29.334	1.032871
Sum512Base_Basic	7543.750	34.750	1.223557
Sum512Base	7452.083	35.177	1.238608
Sum512Traits	7844.792	33.416	1.176603
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	13100.000	20.011
SumBase	13562.500	19.329	0.965899
SumTraits	3927.083	66.753	3.335809
SumTraits_Args	3284.115	79.822	3.988899
SumTraits_ArgsT	3516.927	74.538	3.724843
Sum128Base_Basic	13382.292	19.589	0.978906
Sum128Base	3191.927	82.127	4.104104
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Traits	3401.042	77.078	3.851761
Sum128Traits_ArgsT	2928.646	89.510	4.473057
Sum256Base_Basic	11013.542	23.802	1.189445
Sum256Base	10926.042	23.993	1.198970
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512BW!
Sum256Traits	12061.458	21.734	1.086104
Sum256Traits_ArgsT	12678.125	20.677	1.033276
Sum512Base_Basic	9691.667	27.048	1.351677
Sum512Base	9701.042	27.022	1.350370
Sum512Traits	11139.583	23.533	1.175987
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	20810.417	12.597
SumBase	20777.083	12.617	1.001604
SumTraits	7957.292	32.944	2.615264
SumTraits_Args	6969.271	37.614	2.986025
SumTraits_ArgsT	7429.167	35.286	2.801178
Sum128Base_Basic	21466.667	12.212	0.969429
Sum128Base	5454.688	48.058	3.815144
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Traits	6706.771	39.086	3.102897
Sum128Traits_ArgsT	5784.375	45.319	3.597695
Sum256Base_Basic	16260.417	16.122	1.279821
Sum256Base	16527.083	15.861	1.259171
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	18762.500	13.972	1.109149
Sum256Traits_ArgsT	20072.917	13.060	1.036741
Sum512Base_Basic	13673.958	19.171	1.521901
Sum512Base	13745.833	19.071	1.513944
Sum512Traits	15078.125	17.386	1.380173
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	45558.333	5.754
SumBase	47416.667	5.529	0.960808
SumTraits	21362.500	12.271	2.132631
SumTraits_Args	15121.875	17.335	3.012744
SumTraits_ArgsT	17179.167	15.259	2.651952
Sum128Base_Basic	57600.000	4.551	0.790943
Sum128Base	82816.667	3.165	0.550111
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum128Traits	15795.833	16.596	2.884199
Sum128Traits_ArgsT	11489.583	22.816	3.965186
Sum256Base_Basic	47816.667	5.482	0.952771
Sum256Base	48658.333	5.387	0.936290
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	58687.500	4.467	0.776287
Sum256Traits_ArgsT	59033.333	4.441	0.771739
Sum512Base_Basic	44175.000	5.934	1.031315
Sum512Base	44050.000	5.951	1.034241
Sum512Traits	48320.833	5.425	0.942830
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	9623.958	27.239
SumBase	9775.000	26.818	0.984548
SumTraits	2266.667	115.652	4.245864
SumTraits_Args	2248.438	116.589	4.280287
SumTraits_ArgsT	2184.115	120.023	4.406343
Sum128Base_Basic	9645.833	27.177	0.997732
Sum128Base	2520.573	104.002	3.818163
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Traits	2711.979	96.662	3.548684
Sum128Traits_ArgsT	1687.370	155.357	5.703527
Sum256Base_Basic	8461.458	30.981	1.137388
Sum256Base	8238.542	31.819	1.168163
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi!
Sum256Traits	9061.458	28.930	1.062076
Sum256Traits_ArgsT	9238.542	28.375	1.041718
Sum512Base_Basic	7302.083	35.900	1.317974
Sum512Base	7575.000	34.606	1.270490
Sum512Traits	7862.500	33.341	1.224033
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	13660.417	19.190
SumBase	14128.125	18.555	0.966895
SumTraits	4967.708	52.770	2.749843
SumTraits_Args	4377.083	59.890	3.120895
SumTraits_ArgsT	4301.562	60.942	3.175687
Sum128Base_Basic	13809.375	18.983	0.989213
Sum128Base	4230.208	61.970	3.229254
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Traits	4051.042	64.710	3.372075
Sum128Traits_ArgsT	3412.760	76.813	4.002747
Sum256Base_Basic	11175.000	23.458	1.222409
Sum256Base	11276.042	23.248	1.211455
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512BW!
Sum256Traits	12648.958	20.725	1.079964
Sum256Traits_ArgsT	12882.292	20.349	1.060403
Sum512Base_Basic	9604.167	27.295	1.422343
Sum512Base	9593.750	27.324	1.423887
Sum512Traits	10410.417	25.181	1.312187
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
VectorTraits128PackedSimd: OK.
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: Requires hardware support Sse, Sse2!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
VectorTraits512Base: Vector byte size mismatch(16!=64) !
VectorTraits512Avx512: Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi! Vector byte size mismatch(16!=64) !
``` 

