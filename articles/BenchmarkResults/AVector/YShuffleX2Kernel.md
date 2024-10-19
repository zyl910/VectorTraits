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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
SumBase_Basic	809.151	323.974
SumBase	824.942	317.773	0.980859
SumTraits	830.345	315.705	0.974476
SumTraits_Args	804.848	325.706	1.005346
SumTraits_ArgsT	842.137	311.284	0.960831

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	997.972	262.677
SumBase	1055.579	248.341	0.945426
SumTraits	1095.879	239.209	0.910659
SumTraits_Args	930.854	281.617	1.072103
SumTraits_ArgsT	1001.120	261.851	0.996855

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
SumBase_Basic	1321.880	198.312
SumBase	1370.793	191.235	0.964318
SumTraits	1337.867	195.942	0.988050
SumTraits_Args	1256.613	208.612	1.051939
SumTraits_ArgsT	1632.573	160.571	0.809691

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
SumBase_Basic	2106.570	124.441
SumBase	2106.675	124.435	0.999950
SumTraits	2040.616	128.463	1.032321
SumTraits_Args	2115.352	123.925	0.995849
SumTraits_ArgsT	2687.179	97.554	0.783934

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
SumBase_Basic	733.638	357.321
SumBase	732.236	358.005	1.001914
SumTraits	712.920	367.704	1.029061
SumTraits_Args	712.583	367.878	1.029547
SumTraits_ArgsT	749.435	349.789	0.978922

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	926.767	282.859
SumBase	922.486	284.171	1.004641
SumTraits	961.901	272.527	0.963474
SumTraits_Args	913.618	286.930	1.014392
SumTraits_ArgsT	1073.678	244.155	0.863170

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
SumBase_Basic	1404.922	186.590
SumBase	1303.136	201.164	1.078108
SumTraits	1348.020	194.466	1.042212
SumTraits_Args	1415.083	185.250	0.992819
SumTraits_ArgsT	1745.156	150.212	0.805041

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
SumBase_Basic	2285.934	114.677
SumBase	2295.598	114.194	0.995790
SumTraits	2369.308	110.642	0.964811
SumTraits_Args	2258.370	116.077	1.012205
SumTraits_ArgsT	2981.164	87.933	0.766792

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
SumBase_Basic	761.753	344.132
SumBase	784.076	334.335	0.971530
SumTraits	729.826	359.187	1.043747
SumTraits_Args	738.057	355.181	1.032107
SumTraits_ArgsT	818.877	320.126	0.930241

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	1001.774	261.680
SumBase	1033.924	253.543	0.968905
SumTraits	1061.520	246.951	0.943717
SumTraits_Args	1021.027	256.745	0.981143
SumTraits_ArgsT	1138.872	230.179	0.879620

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
SumBase_Basic	1433.557	182.863
SumBase	1473.461	177.910	0.972918
SumTraits	1532.279	171.081	0.935572
SumTraits_Args	1479.164	177.224	0.969167
SumTraits_ArgsT	1767.594	148.306	0.811022

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
SumBase_Basic	2576.841	101.731
SumBase	2560.242	102.390	1.006483
SumTraits	2398.941	109.275	1.074157
SumTraits_Args	2477.136	105.825	1.040250
SumTraits_ArgsT	3154.885	83.091	0.816778

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
SumBase_Basic	356.924	734.453
SumBase	354.021	740.475	1.008199
SumTraits	359.706	728.772	0.992265
SumTraits_Args	352.098	744.519	1.013705
SumTraits_ArgsT	421.212	622.356	0.847373

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	469.740	558.062
SumBase	484.951	540.558	0.968635
SumTraits	469.696	558.114	1.000094
SumTraits_Args	468.121	559.992	1.003458
SumTraits_ArgsT	638.026	410.867	0.736240

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
SumBase_Basic	752.692	348.275
SumBase	778.843	336.581	0.966422
SumTraits	756.082	346.714	0.995516
SumTraits_Args	742.065	353.263	1.014320
SumTraits_ArgsT	1070.881	244.793	0.702871

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
SumBase_Basic	1391.659	188.368
SumBase	1387.973	188.868	1.002656
SumTraits	1407.117	186.299	0.989015
SumTraits_Args	1408.735	186.085	0.987878
SumTraits_ArgsT	1979.300	132.443	0.703107

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
SumBase_Basic	371.300	706.018
SumBase	381.556	687.039	0.973119
SumTraits	389.427	673.153	0.953451
SumTraits_Args	370.704	707.152	1.001607
SumTraits_ArgsT	424.915	616.933	0.873821

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	505.216	518.875
SumBase	550.847	475.892	0.917161
SumTraits	515.233	508.787	0.980558
SumTraits_Args	509.500	514.512	0.991591
SumTraits_ArgsT	645.009	406.419	0.783270

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
SumBase_Basic	873.248	300.194
SumBase	890.508	294.376	0.980618
SumTraits	889.864	294.589	0.981328
SumTraits_Args	876.897	298.945	0.995839
SumTraits_ArgsT	1164.417	225.129	0.749945

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
SumBase_Basic	1602.546	163.580
SumBase	1596.058	164.245	1.004065
SumTraits	1605.051	163.324	0.998439
SumTraits_Args	1578.341	166.088	1.015335
SumTraits_ArgsT	2118.324	123.751	0.756516

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
SumBase_Basic	401.644	652.677
SumBase	393.398	666.359	1.020962
SumTraits	392.996	667.039	1.022005
SumTraits_Args	396.042	661.909	1.014146
SumTraits_ArgsT	455.143	575.959	0.882457

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
SumBase_Basic	586.452	447.000
SumBase	591.403	443.258	0.991628
SumTraits	576.658	454.592	1.016984
SumTraits_Args	601.077	436.124	0.975669
SumTraits_ArgsT	725.614	361.272	0.808214

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
SumBase_Basic	984.865	266.173
SumBase	1007.712	260.138	0.977328
SumTraits	1007.469	260.201	0.977563
SumTraits_Args	1011.605	259.137	0.973567
SumTraits_ArgsT	1261.728	207.766	0.780568

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
SumBase_Basic	1888.671	138.798
SumBase	1906.032	137.534	0.990891
SumTraits	1896.852	138.200	0.995687
SumTraits_Args	1849.955	141.703	1.020928
SumTraits_ArgsT	2327.589	112.625	0.811428

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	351.748	745.261
SumBase	369.148	710.133	0.952866
SumTraits	18.472	14191.125	19.041829
SumTraits_Args	12.141	21591.461	28.971691
SumTraits_ArgsT	12.797	20485.055	27.487102
Sum128Base_Basic	634.739	412.995	0.554162
Sum128Base	634.760	412.981	0.554143
Sum128Sse_Combine	15.192	17255.779	23.154018
Sum128Traits	17.343	15115.249	20.281829
Sum128Traits_ArgsT	11.990	21864.133	29.337565
Sum256Base_Basic	501.408	522.816	0.701521
Sum256Base	512.876	511.126	0.685835
Sum256Avx2_Combine	17.552	14935.233	20.040282
Sum256Avx2_Combine2	17.120	15311.712	20.545445
Sum256Avx2_Combine3	16.416	15969.205	21.427678
Sum256Traits	16.457	15929.046	21.373792
Sum256Traits_ArgsT	12.325	21269.018	28.539033

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	464.054	564.900
SumBase	471.309	556.204	0.984606
SumTraits	46.121	5683.816	10.061638
SumTraits_Args	22.525	11638.058	20.601993
SumTraits_ArgsT	25.179	10411.032	18.429879
Sum128Base_Basic	1009.358	259.714	0.459752
Sum128Base	1003.644	261.192	0.462369
Sum128Sse_Combine	43.910	5970.014	10.568273
Sum128Traits	48.061	5454.364	9.655456
Sum128Traits_ArgsT	24.466	10714.789	18.967596
Sum256Base_Basic	777.717	337.068	0.596687
Sum256Base	737.653	355.376	0.629095
Sum256Avx2_Combine	44.406	5903.322	10.450214
Sum256Traits	44.775	5854.687	10.364118
Sum256Traits_ArgsT	24.222	10822.763	19.158735

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	742.256	353.172
SumBase	763.976	343.131	0.971569
SumTraits	35.889	7304.367	20.682176
SumTraits_Args	31.024	8449.771	23.925367
SumTraits_ArgsT	38.065	6886.688	19.499525
Sum128Base_Basic	1653.598	158.529	0.448873
Sum128Base	1693.086	154.832	0.438404
Sum128Sse_Combine	94.495	2774.169	7.855008
Sum128Traits	39.621	6616.236	18.733745
Sum128Traits_ArgsT	44.562	5882.643	16.656592
Sum256Base_Basic	1142.044	229.539	0.649936
Sum256Base	1136.548	230.649	0.653079
Sum256Avx2_Combine	37.846	6926.635	19.612635
Sum256Traits	32.496	8067.002	22.841563
Sum256Traits_ArgsT	32.123	8160.522	23.106363

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1370.427	191.286
SumBase	1429.233	183.416	0.958855
SumTraits	93.394	2806.858	14.673591
SumTraits_Args	57.140	4587.777	23.983815
SumTraits_ArgsT	82.290	3185.618	16.653660
Sum128Base_Basic	3222.836	81.340	0.425224
Sum128Base	3224.230	81.304	0.425040
Sum128Sse_Combine	185.763	1411.172	7.377274
Sum128Traits	120.727	2171.371	11.351415
Sum128Traits_ArgsT	85.606	3062.205	16.008486
Sum256Base_Basic	2008.380	130.525	0.682354
Sum256Base	2023.830	129.529	0.677145
Sum256Avx2_Combine	83.669	3133.104	16.379130
Sum256Traits	81.691	3208.982	16.775800
Sum256Traits_ArgsT	64.672	4053.461	21.190537

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	376.673	695.947
SumBase	368.164	712.030	1.023110
SumTraits	30.855	8496.008	12.207844
SumTraits_Args	30.177	8686.846	12.482057
SumTraits_ArgsT	24.789	10575.198	15.195414
Sum128Base_Basic	669.129	391.769	0.562930
Sum128Base	648.296	404.359	0.581020
Sum128Sse_Combine	27.455	9548.154	13.719662
Sum128Traits	26.712	9813.628	14.101120
Sum128Traits_ArgsT	15.996	16387.909	23.547650
Sum256Base_Basic	539.062	486.296	0.698755
Sum256Base	519.165	504.933	0.725535
Sum256Avx2_Combine	35.059	7477.251	10.743999
Sum256Traits	34.214	7661.884	11.009298
Sum256Traits_ArgsT	22.398	11703.982	16.817354

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	476.388	550.274
SumBase	497.356	527.075	0.957842
SumTraits	76.922	3407.932	6.193155
SumTraits_Args	61.647	4252.309	7.727623
SumTraits_ArgsT	50.604	5180.313	9.414062
Sum128Base_Basic	1072.515	244.420	0.444179
Sum128Base	1048.795	249.948	0.454224
Sum128Sse_Combine	69.789	3756.222	6.826095
Sum128Traits	65.372	4010.055	7.287379
Sum128Traits_ArgsT	34.099	7687.726	13.970726
Sum256Base_Basic	819.387	319.927	0.581396
Sum256Base	801.554	327.045	0.594331
Sum256Avx2_Combine	78.865	3323.978	6.040589
Sum256Traits	78.408	3343.343	6.075781
Sum256Traits_ArgsT	45.989	5700.098	10.358655

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	847.660	309.256
SumBase	860.742	304.556	0.984802
SumTraits	51.813	5059.394	16.359892
SumTraits_Args	45.924	5708.252	18.458018
SumTraits_ArgsT	52.480	4995.114	16.152038
Sum128Base_Basic	1781.440	147.153	0.475829
Sum128Base	1775.524	147.643	0.477414
Sum128Sse_Combine	130.034	2015.961	6.518746
Sum128Sse_CombineAvx	72.256	3627.991	11.731355
Sum128Traits	71.611	3660.668	11.837017
Sum128Traits_ArgsT	64.954	4035.831	13.050134
Sum256Base_Basic	1200.651	218.335	0.706001
Sum256Base	1182.776	221.635	0.716670
Sum256Avx2_Combine	45.503	5760.987	18.628540
Sum256Traits	43.441	6034.450	19.512801
Sum256Traits_ArgsT	39.369	6658.647	21.531184

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1529.992	171.337
SumBase	1650.012	158.874	0.927261
SumTraits	135.864	1929.456	11.261183
SumTraits_Args	89.202	2938.772	17.152011
SumTraits_ArgsT	104.544	2507.510	14.634969
Sum128Base_Basic	3425.639	76.524	0.446630
Sum128Base	3446.839	76.053	0.443883
Sum128Sse_Combine	268.214	977.368	5.704364
Sum128Sse_CombineAvx	194.720	1346.260	7.857385
Sum128Traits	193.908	1351.897	7.890289
Sum128Traits_ArgsT	133.816	1958.987	11.433540
Sum256Base_Basic	2224.078	117.866	0.687922
Sum256Base	2211.971	118.511	0.691687
Sum256Avx2_Combine	113.355	2312.584	13.497293
Sum256Traits	112.508	2330.007	13.598983
Sum256Traits_ArgsT	75.225	3484.795	20.338848

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	397.329	659.766
SumBase	376.013	697.167	1.056687
SumTraits	42.305	6196.546	9.392031
SumTraits_Args	36.823	7118.947	10.790103
SumTraits_ArgsT	33.136	7911.217	11.990937
Sum128Base_Basic	674.282	388.775	0.589261
Sum128Base	676.612	387.436	0.587232
Sum128Sse_Combine	35.657	7351.856	11.143122
Sum128Traits	34.515	7595.027	11.511692
Sum128Traits_ArgsT	21.936	11950.398	18.113076
Sum256Base_Basic	559.584	468.462	0.710042
Sum256Base	518.556	505.527	0.766221
Sum256Avx2_Combine	43.258	6059.951	9.184996
Sum256Traits	44.794	5852.198	8.870107
Sum256Traits_ArgsT	29.174	8985.430	13.619110

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	534.771	490.198
SumBase	552.937	474.093	0.967146
SumTraits	98.667	2656.867	5.419985
SumTraits_Args	72.145	3633.566	7.412441
SumTraits_ArgsT	68.252	3840.816	7.835229
Sum128Base_Basic	1135.958	230.769	0.470767
Sum128Base	1115.472	235.007	0.479413
Sum128Sse_Combine	84.983	3084.676	6.292712
Sum128Traits	88.705	2955.229	6.028640
Sum128Traits_ArgsT	45.213	5797.976	11.827818
Sum256Base_Basic	858.496	305.353	0.622917
Sum256Base	865.794	302.779	0.617666
Sum256Avx2_Combine	99.250	2641.254	5.388134
Sum256Traits	100.398	2611.056	5.326530
Sum256Traits_ArgsT	61.961	4230.805	8.630803

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	952.834	275.120
SumBase	917.754	285.636	1.038223
SumTraits	69.219	3787.149	13.765425
SumTraits_Args	61.423	4267.843	15.512638
SumTraits_ArgsT	66.933	3916.539	14.235726
Sum128Base_Basic	1942.211	134.972	0.490592
Sum128Base	1970.961	133.003	0.483436
Sum128Sse_Combine	170.337	1538.969	5.593803
Sum128Sse_CombineAvx	81.097	3232.491	11.749370
Sum128Traits	83.472	3140.510	11.415037
Sum128Traits_ArgsT	83.864	3125.821	11.361647
Sum256Base_Basic	1291.945	202.907	0.737519
Sum256Base	1296.619	202.175	0.734860
Sum256Avx2_Combine	58.549	4477.335	16.274094
Sum256Traits	57.252	4578.812	16.642939
Sum256Traits_ArgsT	52.236	5018.413	18.240790

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1830.278	143.226
SumBase	1792.055	146.281	1.021329
SumTraits	159.893	1639.499	11.446915
SumTraits_Args	122.717	2136.173	14.914666
SumTraits_ArgsT	132.812	1973.799	13.780981
Sum128Base_Basic	3751.875	69.870	0.487830
Sum128Base	3772.703	69.484	0.485137
Sum128Sse_Combine	346.893	755.692	5.276210
Sum128Sse_CombineAvx	209.647	1250.406	8.730283
Sum128Traits	238.868	1097.445	7.662316
Sum128Traits_ArgsT	175.888	1490.399	10.405903
Sum256Base_Basic	2469.281	106.162	0.741219
Sum256Base	2485.002	105.490	0.736530
Sum256Avx2_Combine	137.563	1905.629	13.305018
Sum256Traits	139.226	1882.864	13.146077
Sum256Traits_ArgsT	100.102	2618.767	18.284120

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
SumBase_Basic	340.837	769.117
SumBase	339.305	772.591	1.004517
SumTraits	16.503	15884.949	20.653476
SumTraits_Args	10.054	26073.822	33.900962
SumTraits_ArgsT	12.532	20918.021	27.197434
Sum128Base_Basic	634.251	413.313	0.537386
Sum128Base	632.493	414.461	0.538879
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	11.240	23321.687	30.322659
Sum128Traits	11.522	22750.631	29.580177
Sum128Traits_ArgsT	10.931	23981.001	31.179894
Sum256Base_Basic	499.621	524.686	0.682192
Sum256Base	493.294	531.415	0.690942
Sum256Avx2_Combine	13.891	18871.907	24.537093
Sum256Avx2_Combine2	13.517	19393.189	25.214860
Sum256Avx2_Combine3	13.968	18767.346	24.401144
Sum256Traits	13.584	19297.803	25.090840
Sum256Traits_ArgsT	11.790	22235.191	28.910007

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	436.985	599.893
SumBase	433.120	605.246	1.008924
SumTraits	39.828	6581.965	10.971907
SumTraits_Args	19.801	13238.999	22.068950
SumTraits_ArgsT	26.221	9997.559	16.665583
Sum128Base_Basic	1026.994	255.254	0.425499
Sum128Base	995.315	263.378	0.439042
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	32.680	8021.664	13.371835
Sum128Traits	32.726	8010.160	13.352658
Sum128Traits_ArgsT	22.851	11471.647	19.122836
Sum256Base_Basic	736.681	355.844	0.593180
Sum256Base	735.472	356.430	0.594156
Sum256Avx2_Combine	31.379	8354.045	13.925903
Sum256Traits	32.907	7966.237	13.279439
Sum256Traits_ArgsT	23.934	10952.858	18.258034

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	712.838	367.747
SumBase	711.648	368.362	1.001673
SumTraits	33.242	7885.910	21.443859
SumTraits_Args	24.469	10713.378	29.132488
SumTraits_ArgsT	41.489	6318.448	17.181518
Sum128Base_Basic	1689.667	155.145	0.421881
Sum128Base	1711.213	153.192	0.416569
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	66.104	3965.649	10.783641
Sum128Traits	33.625	7796.037	21.199471
Sum128Traits_ArgsT	40.728	6436.470	17.502452
Sum256Base_Basic	1078.206	243.130	0.661134
Sum256Base	1079.568	242.823	0.660300
Sum256Avx2_Combine	25.249	10382.409	28.232496
Sum256Traits	24.766	10584.855	28.783000
Sum256Traits_ArgsT	33.624	7796.296	21.200174

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1291.248	203.016
SumBase	1367.810	191.652	0.944026
SumTraits	79.340	3304.073	16.274935
SumTraits_Args	47.524	5516.020	27.170364
SumTraits_ArgsT	81.197	3228.487	15.902621
Sum128Base_Basic	3202.016	81.868	0.403261
Sum128Base	3185.189	82.301	0.405391
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	146.707	1786.849	8.801518
Sum128Traits	91.711	2858.358	14.079466
Sum128Traits_ArgsT	72.435	3619.032	17.826336
Sum256Base_Basic	1900.469	137.936	0.679436
Sum256Base	1936.075	135.400	0.666941
Sum256Avx2_Combine	70.397	3723.773	18.342258
Sum256Traits	67.277	3896.466	19.192898
Sum256Traits_ArgsT	67.074	3908.303	19.251203

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	352.446	743.786
SumBase	366.673	714.925	0.961198
SumTraits	25.620	10232.075	13.756750
SumTraits_Args	20.350	12882.002	17.319506
SumTraits_ArgsT	25.095	10446.003	14.044370
Sum128Base_Basic	659.727	397.352	0.534230
Sum128Base	675.520	388.062	0.521740
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	15.995	16389.102	22.034707
Sum128Traits	16.912	15500.432	20.839915
Sum128Traits_ArgsT	15.442	16976.356	22.824254
Sum256Base_Basic	522.685	501.533	0.674298
Sum256Base	508.986	515.032	0.692446
Sum256Avx2_Combine	26.922	9737.137	13.091319
Sum256Traits	26.847	9764.526	13.128143
Sum256Traits_ArgsT	19.441	13484.202	18.129148

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	493.866	530.800
SumBase	491.402	533.462	1.005014
SumTraits	58.484	4482.350	8.444512
SumTraits_Args	40.758	6431.718	12.117019
SumTraits_ArgsT	48.069	5453.453	10.274019
Sum128Base_Basic	1055.826	248.283	0.467753
Sum128Base	1051.448	249.317	0.469700
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	46.731	5609.641	10.568269
Sum128Traits	45.801	5723.565	10.782896
Sum128Traits_ArgsT	29.674	8834.183	16.643138
Sum256Base_Basic	771.811	339.648	0.639879
Sum256Base	779.604	336.253	0.633483
Sum256Avx2_Combine	59.207	4427.601	8.341369
Sum256Traits	57.079	4592.685	8.652379
Sum256Traits_ArgsT	39.136	6698.350	12.619340

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	787.131	333.037
SumBase	803.349	326.314	0.979811
SumTraits	53.099	4936.920	14.823918
SumTraits_Args	39.298	6670.720	20.029936
SumTraits_ArgsT	59.972	4371.074	13.124870
Sum128Base_Basic	1800.618	145.586	0.437145
Sum128Base	1771.280	147.997	0.444385
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	93.091	2816.010	8.455533
Sum128Sse_CombineAvx	59.915	4375.245	13.137396
Sum128Traits	60.718	4317.417	12.963756
Sum128Traits_ArgsT	64.408	4070.040	12.220967
Sum256Base_Basic	1144.635	229.020	0.687670
Sum256Base	1161.437	225.707	0.677721
Sum256Avx2_Combine	36.053	7271.112	21.832713
Sum256Traits	34.589	7578.794	22.756579
Sum256Traits_ArgsT	39.866	6575.630	19.744413

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1509.912	173.615
SumBase	1500.163	174.744	1.006499
SumTraits	117.416	2232.612	12.859525
SumTraits_Args	74.741	3507.383	20.202029
SumTraits_ArgsT	106.211	2468.148	14.216178
Sum128Base_Basic	3452.568	75.927	0.437330
Sum128Base	3403.577	77.020	0.443625
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	201.809	1298.972	7.481891
Sum128Sse_CombineAvx	154.559	1696.075	9.769153
Sum128Traits	151.796	1726.950	9.946989
Sum128Traits_ArgsT	114.892	2281.661	13.142043
Sum256Base_Basic	2126.198	123.292	0.710147
Sum256Base	2109.719	124.255	0.715693
Sum256Avx2_Combine	92.497	2834.084	16.323920
Sum256Traits	96.874	2706.021	15.586293
Sum256Traits_ArgsT	78.304	3347.776	19.282712

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	362.784	722.590
SumBase	374.508	699.968	0.968694
SumTraits	33.291	7874.249	10.897257
SumTraits_Args	30.523	8588.362	11.885525
SumTraits_ArgsT	33.334	7864.167	10.883304
Sum128Base_Basic	676.706	387.383	0.536103
Sum128Base	683.492	383.536	0.530780
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	26.449	9911.458	13.716572
Sum128Traits	26.887	9749.889	13.492974
Sum128Traits_ArgsT	18.744	13985.529	19.354722
Sum256Base_Basic	530.635	494.019	0.683679
Sum256Base	499.324	524.998	0.726550
Sum256Avx2_Combine	29.910	8764.287	12.128990
Sum256Traits	30.510	8592.115	11.890718
Sum256Traits_ArgsT	31.950	8204.797	11.354705

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	543.354	482.455
SumBase	537.303	487.888	1.011262
SumTraits	72.909	3595.484	7.452477
SumTraits_Args	61.447	4266.201	8.842693
SumTraits_ArgsT	68.500	3826.905	7.932151
Sum128Base_Basic	1106.032	237.013	0.491265
Sum128Base	1095.021	239.396	0.496205
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	61.488	4263.349	8.836782
Sum128Traits	58.727	4463.794	9.252252
Sum128Traits_ArgsT	39.504	6635.808	13.754257
Sum256Base_Basic	833.121	314.653	0.652192
Sum256Base	801.222	327.180	0.678157
Sum256Avx2_Combine	67.336	3893.079	8.069312
Sum256Traits	71.161	3683.795	7.635523
Sum256Traits_ArgsT	62.325	4206.049	8.718015

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	880.091	297.860
SumBase	894.716	292.991	0.983654
SumTraits	67.711	3871.522	12.997779
SumTraits_Args	57.308	4574.286	15.357156
SumTraits_ArgsT	67.209	3900.428	13.094824
Sum128Base_Basic	1920.189	136.520	0.458335
Sum128Base	1903.087	137.747	0.462454
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	117.563	2229.810	7.486094
Sum128Sse_CombineAvx	64.302	4076.781	13.686892
Sum128Traits	62.648	4184.402	14.048205
Sum128Traits_ArgsT	78.657	3332.730	11.188904
Sum256Base_Basic	1218.815	215.081	0.722087
Sum256Base	1245.454	210.481	0.706642
Sum256Avx2_Combine	48.455	5410.081	18.163153
Sum256Traits	47.882	5474.792	18.380404
Sum256Traits_ArgsT	50.967	5143.370	17.267730

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1670.647	156.912
SumBase	1710.880	153.222	0.976484
SumTraits	147.146	1781.519	11.353644
SumTraits_Args	109.228	2399.962	15.294990
SumTraits_ArgsT	135.357	1936.689	12.342547
Sum128Base_Basic	3685.840	71.122	0.453261
Sum128Base	3733.873	70.207	0.447430
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	239.250	1095.690	6.982849
Sum128Sse_CombineAvx	165.681	1582.226	10.083545
Sum128Traits	162.900	1609.234	10.255670
Sum128Traits_ArgsT	175.475	1493.907	9.520690
Sum256Base_Basic	2349.815	111.559	0.710970
Sum256Base	2346.385	111.723	0.712009
Sum256Avx2_Combine	121.844	2151.468	13.711335
Sum256Traits	120.223	2180.477	13.896208
Sum256Traits_ArgsT	102.385	2560.372	16.317283

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	324.298	808.343
SumBase	333.284	786.548	0.973038
SumTraits	17.442	15029.381	18.592838
SumTraits_Args	10.071	26028.372	32.199683
SumTraits_ArgsT	15.002	17473.814	21.616844
Sum128Base_Basic	632.616	414.381	0.512630
Sum128Base	619.348	423.258	0.523612
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	11.138	23536.245	29.116674
Sum128Traits	11.349	23098.857	28.575582
Sum128Traits_ArgsT	12.185	21512.873	26.613562
Sum256Base_Basic	474.316	552.678	0.683718
Sum256Base	589.248	444.879	0.550360
Sum256Avx2_Combine	13.198	19862.921	24.572407
Sum256Avx2_Combine2	11.923	21986.058	27.198939
Sum256Avx2_Combine3	13.530	19375.435	23.969339
Sum256Traits	13.711	19119.525	23.652752
Sum256Traits_ArgsT	9.847	26623.054	32.935363

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	448.835	584.054
SumBase	441.683	593.512	1.016194
SumTraits	39.122	6700.738	11.472810
SumTraits_Args	19.353	13545.552	23.192302
SumTraits_ArgsT	27.720	9456.905	16.191838
Sum128Base_Basic	984.664	266.227	0.455826
Sum128Base	996.149	263.157	0.450570
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	33.155	7906.576	13.537409
Sum128Traits	32.548	8053.970	13.789773
Sum128Traits_ArgsT	25.169	10415.313	17.832796
Sum256Base_Basic	749.345	349.831	0.598970
Sum256Base	947.925	276.545	0.473492
Sum256Avx2_Combine	32.886	7971.378	13.648362
Sum256Traits	34.404	7619.494	13.045877
Sum256Traits_ArgsT	19.763	13264.693	22.711422

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	732.710	357.773
SumBase	744.027	352.331	0.984789
SumTraits	37.725	6948.860	19.422527
SumTraits_Args	25.252	10380.918	29.015360
SumTraits_ArgsT	50.113	5231.069	14.621187
Sum128Base_Basic	1683.899	155.677	0.435127
Sum128Base	1665.568	157.390	0.439916
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	66.137	3963.651	11.078671
Sum128Traits	37.217	7043.731	19.687700
Sum128Traits_ArgsT	36.721	7138.754	19.953294
Sum256Base_Basic	1070.078	244.977	0.684726
Sum256Base	1644.808	159.377	0.445469
Sum256Avx2_Combine	23.654	11082.213	30.975526
Sum256Traits	25.967	10095.332	28.217130
Sum256Traits_ArgsT	37.796	6935.821	19.386084

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1374.848	190.671
SumBase	1394.469	187.988	0.985929
SumTraits	84.488	3102.730	16.272664
SumTraits_Args	49.435	5302.754	27.810972
SumTraits_ArgsT	96.725	2710.207	14.214029
Sum128Base_Basic	3246.447	80.748	0.423493
Sum128Base	3221.582	81.371	0.426762
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	127.424	2057.260	10.789560
Sum128Traits	85.845	3053.688	16.015458
Sum128Traits_ArgsT	64.126	4087.951	21.439782
Sum256Base_Basic	1996.408	131.308	0.688661
Sum256Base	3199.005	81.945	0.429774
Sum256Avx2_Combine	69.426	3775.863	19.802994
Sum256Traits	66.371	3949.656	20.714476
Sum256Traits_ArgsT	73.767	3553.676	18.637706

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	494.692	529.914
SumBase	359.919	728.341	1.374452
SumTraits	25.650	10219.968	19.286093
SumTraits_Args	20.517	12776.915	24.111305
SumTraits_ArgsT	23.247	11276.418	21.279718
Sum128Base_Basic	658.251	398.243	0.751524
Sum128Base	623.718	420.293	0.793134
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	16.828	15577.768	29.396792
Sum128Traits	17.051	15374.123	29.012493
Sum128Traits_ArgsT	14.364	18250.228	34.439988
Sum256Base_Basic	594.744	440.768	0.831772
Sum256Base	500.978	523.264	0.987451
Sum256Avx2_Combine	20.840	12578.758	23.737362
Sum256Traits	22.306	11752.379	22.177904
Sum256Traits_ArgsT	20.212	12969.582	24.474885

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	481.285	544.675
SumBase	487.994	537.187	0.986251
SumTraits	56.910	4606.289	8.456943
SumTraits_Args	41.025	6389.786	11.731367
SumTraits_ArgsT	48.781	5373.863	9.866176
Sum128Base_Basic	1048.160	250.099	0.459171
Sum128Base	1031.111	254.234	0.466763
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	46.659	5618.278	10.314912
Sum128Traits	45.829	5719.990	10.501650
Sum128Traits_ArgsT	29.316	8941.891	16.416919
Sum256Base_Basic	1028.738	254.821	0.467840
Sum256Base	795.609	329.489	0.604927
Sum256Avx2_Combine	53.743	4877.778	8.955386
Sum256Traits	50.972	5142.934	9.442201
Sum256Traits_ArgsT	40.389	6490.496	11.916265

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	820.127	319.638
SumBase	829.184	316.147	0.989078
SumTraits	54.049	4850.118	15.173775
SumTraits_Args	40.012	6551.664	20.497126
SumTraits_ArgsT	65.955	3974.575	12.434606
Sum128Base_Basic	1782.776	147.043	0.460028
Sum128Base	1751.903	149.634	0.468135
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	94.080	2786.402	8.717363
Sum128Sse_CombineAvx	60.467	4335.349	13.563301
Sum128Traits	57.497	4559.281	14.263882
Sum128Traits_ArgsT	59.442	4410.070	13.797070
Sum256Base_Basic	1573.546	166.594	0.521197
Sum256Base	1184.557	221.301	0.692349
Sum256Avx2_Combine	34.360	7629.383	23.868811
Sum256Traits	33.616	7798.261	24.397153
Sum256Traits_ArgsT	47.025	5574.601	17.440348

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	2898.749	90.433
SumBase	1636.767	160.160	1.771021
SumTraits	114.774	2284.001	25.256149
SumTraits_Args	75.505	3471.877	38.391496
SumTraits_ArgsT	128.352	2042.380	22.584339
Sum128Base_Basic	3411.875	76.833	0.849606
Sum128Base	3452.417	75.931	0.839629
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	186.772	1403.548	15.520223
Sum128Sse_CombineAvx	138.618	1891.126	20.911792
Sum128Traits	140.839	1861.309	20.582080
Sum128Traits_ArgsT	112.817	2323.630	25.694359
Sum256Base_Basic	3142.820	83.410	0.922340
Sum256Base	2198.767	119.223	1.318352
Sum256Avx2_Combine	95.962	2731.740	30.207181
Sum256Traits	96.008	2730.439	30.192794
Sum256Traits_ArgsT	92.310	2839.833	31.402456

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	498.254	526.126
SumBase	534.809	490.164	0.931648
SumTraits	33.294	7873.712	14.965458
SumTraits_Args	29.413	8912.375	16.939630
SumTraits_ArgsT	34.567	7583.659	14.414158
Sum128Base_Basic	694.085	377.683	0.717856
Sum128Base	678.831	386.170	0.733987
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	22.811	11491.793	21.842296
Sum128Traits	27.082	9679.496	18.397687
Sum128Traits_ArgsT	19.101	13724.254	26.085503
Sum256Base_Basic	611.953	428.373	0.814202
Sum256Base	603.053	434.695	0.826219
Sum256Avx2_Combine	28.133	9318.013	17.710621
Sum256Traits	29.079	9014.806	17.134320
Sum256Traits_ArgsT	28.398	9231.179	17.545577

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	837.759	312.911
SumBase	522.552	501.661	1.603205
SumTraits	74.391	3523.872	11.261577
SumTraits_Args	59.011	4442.298	14.196680
SumTraits_ArgsT	69.456	3774.233	12.061679
Sum128Base_Basic	1118.944	234.278	0.748705
Sum128Base	1124.113	233.201	0.745262
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	58.762	4461.138	14.256889
Sum128Traits	56.791	4615.919	14.751536
Sum128Traits_ArgsT	39.254	6678.087	21.341806
Sum256Base_Basic	1044.397	251.000	0.802146
Sum256Base	1039.130	252.273	0.806212
Sum256Avx2_Combine	65.609	3995.548	12.768958
Sum256Traits	69.758	3757.884	12.009430
Sum256Traits_ArgsT	56.699	4623.433	14.775548

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	1555.475	168.530
SumBase	954.755	274.567	1.629187
SumTraits	67.050	3909.662	23.198622
SumTraits_Args	54.352	4823.093	28.618615
SumTraits_ArgsT	76.931	3407.529	20.219135
Sum128Base_Basic	1900.591	137.928	0.818416
Sum128Base	1896.251	138.243	0.820289
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	118.028	2221.028	13.178837
Sum128Sse_CombineAvx	60.861	4307.285	25.557985
Sum128Traits	73.494	3566.860	21.164548
Sum128Traits_ArgsT	79.244	3308.053	19.628879
Sum256Base_Basic	1687.362	155.357	0.921838
Sum256Base	1765.521	148.480	0.881029
Sum256Avx2_Combine	45.705	5735.580	34.033007
Sum256Traits	46.547	5631.755	33.416945
Sum256Traits_ArgsT	45.111	5811.082	34.481013

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	3121.917	83.969
SumBase	3118.235	84.068	1.001181
SumTraits	143.585	1825.704	21.742609
SumTraits_Args	103.229	2539.453	30.242769
SumTraits_ArgsT	143.135	1831.449	21.811037
Sum128Base_Basic	3512.883	74.624	0.888705
Sum128Base	3526.251	74.341	0.885336
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	263.392	995.263	11.852750
Sum128Sse_CombineAvx	142.046	1845.488	21.978220
Sum128Traits	144.672	1811.993	21.579324
Sum128Traits_ArgsT	153.659	1706.006	20.317112
Sum256Base_Basic	2975.497	88.101	1.049209
Sum256Base	3089.909	84.839	1.010359
Sum256Avx2_Combine	122.345	2142.667	25.517377
Sum256Traits	120.398	2177.315	25.930010
Sum256Traits_ArgsT	93.314	2809.271	33.456076

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	377.559	694.312
SumBase	381.821	686.563	0.988840
SumTraits	14.695	17839.090	25.693193
SumTraits_Args	10.695	24511.025	35.302613
SumTraits_ArgsT	12.730	20592.448	29.658785
Sum128Base_Basic	463.001	566.185	0.815461
Sum128Base	445.263	588.739	0.847946
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	12.275	21356.629	30.759416
Sum128Traits	13.117	19985.482	28.784587
Sum128Traits_ArgsT	12.563	20866.376	30.053317
Sum256Base_Basic	391.878	668.943	0.963462
Sum256Base	380.046	689.769	0.993457
Sum256Avx2_Combine	12.062	21732.634	31.300967
Sum256Avx2_Combine2	13.490	19433.171	27.989108
Sum256Avx2_Combine3	11.839	22142.920	31.891890
Sum256Traits	11.730	22348.708	32.188282
Sum256Traits_ArgsT	12.229	21435.959	30.873672

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	521.473	502.700
SumBase	522.709	501.510	0.997634
SumTraits	34.402	7620.087	15.158332
SumTraits_Args	20.971	12500.398	24.866540
SumTraits_ArgsT	27.865	9407.757	18.714473
Sum128Base_Basic	712.323	368.013	0.732073
Sum128Base	754.583	347.402	0.691074
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	25.609	10236.330	20.362720
Sum128Traits	25.702	10199.553	20.289562
Sum128Traits_ArgsT	24.394	10746.402	21.377386
Sum256Base_Basic	501.963	522.237	1.038866
Sum256Base	507.436	516.605	1.027661
Sum256Avx2_Combine	25.055	10462.788	20.813203
Sum256Traits	23.969	10936.609	21.755756
Sum256Traits_ArgsT	24.560	10673.816	21.232993

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	848.630	308.903
SumBase	829.638	315.974	1.022892
SumTraits	37.203	7046.240	22.810553
SumTraits_Args	24.029	10909.322	35.316378
SumTraits_ArgsT	44.690	5865.793	18.989133
Sum128Base_Basic	1259.630	208.112	0.673714
Sum128Base	1239.696	211.458	0.684547
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	52.777	4967.007	16.079525
Sum128Traits	33.647	7791.102	25.221869
Sum128Traits_ArgsT	45.419	5771.645	18.684351
Sum256Base_Basic	877.836	298.625	0.966730
Sum256Base	818.517	320.267	1.036789
Sum256Avx2_Combine	26.008	10079.300	32.629377
Sum256Traits	25.862	10136.233	32.813684
Sum256Traits_ArgsT	36.477	7186.470	23.264515

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1576.219	166.312
SumBase	1483.699	176.683	1.062358
SumTraits	81.308	3224.097	19.385847
SumTraits_Args	48.050	5455.595	32.803400
SumTraits_ArgsT	89.164	2940.019	17.677743
Sum128Base_Basic	2328.251	112.593	0.676997
Sum128Base	2414.572	108.567	0.652794
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	119.109	2200.869	13.233381
Sum128Traits	85.779	3056.046	18.375392
Sum128Traits_ArgsT	87.714	2988.627	17.970014
Sum256Base_Basic	1453.388	180.368	1.084514
Sum256Base	1465.920	178.826	1.075242
Sum256Avx2_Combine	64.204	4082.992	24.550215
Sum256Traits	61.894	4235.375	25.466460
Sum256Traits_ArgsT	75.247	3483.792	20.947342

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	406.423	645.003
SumBase	413.259	634.334	0.983460
SumTraits	23.959	10941.137	16.962936
SumTraits_Args	18.184	14416.011	22.350316
SumTraits_ArgsT	23.088	11353.926	17.602917
Sum128Base_Basic	482.138	543.711	0.842960
Sum128Base	467.735	560.454	0.868917
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	19.064	13750.518	21.318548
Sum128Traits	19.432	13490.301	20.915113
Sum128Traits_ArgsT	14.913	17577.915	27.252475
Sum256Base_Basic	403.460	649.739	1.007343
Sum256Base	406.009	645.660	1.001020
Sum256Avx2_Combine	19.758	13267.427	20.569573
Sum256Traits	19.092	13730.816	21.288004
Sum256Traits_ArgsT	19.089	13732.954	21.291319

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	544.087	481.806
SumBase	579.033	452.727	0.939646
SumTraits	51.352	5104.850	10.595245
SumTraits_Args	36.074	7266.814	15.082456
SumTraits_ArgsT	46.271	5665.398	11.758677
Sum128Base_Basic	784.650	334.090	0.693413
Sum128Base	823.504	318.327	0.660697
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	39.290	6672.000	13.847906
Sum128Traits	37.075	7070.659	14.675333
Sum128Traits_ArgsT	30.975	8463.181	17.565547
Sum256Base_Basic	530.682	493.975	1.025258
Sum256Base	558.658	469.239	0.973917
Sum256Avx2_Combine	39.280	6673.769	13.851577
Sum256Traits	38.140	6873.163	14.265425
Sum256Traits_ArgsT	38.180	6865.956	14.250466

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	891.490	294.051
SumBase	899.638	291.388	0.990944
SumTraits	59.893	4376.864	14.884686
SumTraits_Args	40.905	6408.569	21.794038
SumTraits_ArgsT	63.193	4148.286	14.107344
Sum128Base_Basic	1341.026	195.480	0.664782
Sum128Base	1335.190	196.335	0.667688
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	76.426	3430.054	11.664807
Sum128Sse_CombineAvx	77.545	3380.519	11.496351
Sum128Traits	64.108	4089.082	13.906006
Sum128Traits_ArgsT	60.730	4316.543	14.679546
Sum256Base_Basic	919.541	285.081	0.969495
Sum256Base	869.165	301.604	1.025686
Sum256Avx2_Combine	39.309	6668.731	22.678786
Sum256Traits	39.816	6583.865	22.390177
Sum256Traits_ArgsT	41.902	6256.168	21.275756

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1709.227	153.370
SumBase	1615.455	162.273	1.058046
SumTraits	117.065	2239.303	14.600662
SumTraits_Args	77.125	3398.971	22.161910
SumTraits_ArgsT	108.544	2415.094	15.746858
Sum128Base_Basic	2600.441	100.808	0.657284
Sum128Base	2592.622	101.112	0.659266
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	180.009	1456.284	9.495239
Sum128Sse_CombineAvx	142.383	1841.121	12.004446
Sum128Traits	141.819	1848.442	12.052178
Sum128Traits_ArgsT	114.905	2281.405	14.875181
Sum256Base_Basic	1742.436	150.447	0.980941
Sum256Base	1614.295	162.389	1.058807
Sum256Avx2_Combine	87.705	2988.915	19.488271
Sum256Traits	96.162	2726.072	17.774487
Sum256Traits_ArgsT	85.573	3063.381	19.973803

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
SumBase_Basic	421.969	621.240
SumBase	432.574	606.010	0.975484
SumTraits	31.829	8236.069	13.257464
SumTraits_Args	30.317	8646.693	13.918440
SumTraits_ArgsT	30.715	8534.736	13.738225
Sum128Base_Basic	527.441	497.011	0.800031
Sum128Base	498.352	526.022	0.846729
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	25.223	10393.215	16.729787
Sum128Traits	24.951	10506.192	16.911644
Sum128Traits_ArgsT	20.440	12825.184	20.644487
Sum256Base_Basic	431.829	607.055	0.977167
Sum256Base	410.691	638.299	1.027460
Sum256Avx2_Combine	27.129	9662.719	15.553919
Sum256Traits	27.798	9430.436	15.180018
Sum256Traits_ArgsT	31.310	8372.617	13.477264

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
SumBase_Basic	610.214	429.594
SumBase	576.809	454.473	1.057914
SumTraits	66.559	3938.514	9.168001
SumTraits_Args	62.659	4183.637	9.738594
SumTraits_ArgsT	62.052	4224.561	9.833855
Sum128Base_Basic	848.694	308.879	0.719003
Sum128Base	850.233	308.320	0.717702
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	47.414	5528.884	12.870035
Sum128Traits	51.220	5118.002	11.913592
Sum128Traits_ArgsT	42.488	6169.876	14.362124
Sum256Base_Basic	624.258	419.929	0.977502
Sum256Base	569.097	460.632	1.072250
Sum256Avx2_Combine	53.784	4873.980	11.345562
Sum256Traits	54.958	4769.892	11.103268
Sum256Traits_ArgsT	61.965	4230.532	9.847754

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
SumBase_Basic	1239.211	211.541
SumBase	1124.128	233.198	1.102376
SumTraits	70.336	3727.002	17.618342
SumTraits_Args	68.643	3818.965	18.053070
SumTraits_ArgsT	79.420	3300.724	15.603233
Sum128Base_Basic	1437.517	182.359	0.862050
Sum128Base	1535.389	170.735	0.807099
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	104.799	2501.408	11.824694
Sum128Sse_CombineAvx	71.763	3652.894	17.268018
Sum128Traits	75.428	3475.437	16.429138
Sum128Traits_ArgsT	81.265	3225.781	15.248962
Sum256Base_Basic	999.721	262.217	1.239557
Sum256Base	975.992	268.592	1.269694
Sum256Avx2_Combine	52.128	5028.805	23.772247
Sum256Traits	52.571	4986.457	23.572055
Sum256Traits_ArgsT	53.308	4917.571	23.246419

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
SumBase_Basic	1857.440	141.132
SumBase	1800.977	145.557	1.031351
SumTraits	151.278	1732.857	12.278280
SumTraits_Args	121.686	2154.269	15.264223
SumTraits_ArgsT	162.983	1608.418	11.396558
Sum128Base_Basic	2795.823	93.763	0.664362
Sum128Base	2809.218	93.316	0.661195
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	224.178	1169.357	8.285563
Sum128Sse_CombineAvx	160.412	1634.188	11.579156
Sum128Traits	150.219	1745.081	12.364896
Sum128Traits_ArgsT	157.311	1666.407	11.807446
Sum256Base_Basic	1851.308	141.599	1.003312
Sum256Base	1815.457	144.396	1.023125
Sum256Avx2_Combine	121.002	2166.441	15.350468
Sum256Traits	122.198	2145.245	15.200288
Sum256Traits_ArgsT	107.476	2439.089	17.282334

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
# Sum512Base_Basic	117
SumBase_Basic	285.630	917.774
SumBase	277.302	945.338	1.030034
SumTraits	3.667	71478.251	77.882213
SumTraits_Args	3.655	71714.983	78.140154
SumTraits_ArgsT	3.739	70119.520	76.401749
Sum128Base_Basic	327.176	801.232	0.873016
Sum128Base	325.690	804.888	0.877000
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	11.308	23182.440	25.259427
Sum128Traits	7.069	37083.467	40.405892
Sum128Traits_ArgsT	6.985	37526.896	40.889048
Sum256Base_Basic	275.702	950.825	1.036012
Sum256Base	260.090	1007.898	1.098199
Sum256Avx2_Combine	11.020	23787.035	25.918191
Sum256Avx2_Combine2	12.656	20713.628	22.569427
Sum256Avx2_Combine3	11.312	23174.267	25.250523
Sum256Traits	3.714	70587.427	76.911577
Sum256Traits_ArgsT	3.710	70666.615	76.997860
Sum512Base_Basic	287.134	912.966	0.994762
Sum512Base	527.482	496.972	0.541497
Sum512Traits	3.079	85135.552	92.763114
Sum512Traits_ArgsT	3.088	84883.398	92.488369

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
# Sum512Base_Basic	-14137
SumBase_Basic	336.273	779.558
SumBase	338.204	775.105	0.994289
SumTraits	7.011	37391.696	47.965274
SumTraits_Args	7.198	36420.577	46.719543
SumTraits_ArgsT	6.930	37826.671	48.523250
Sum128Base_Basic	495.199	529.371	0.679066
Sum128Base	498.417	525.953	0.674682
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	24.722	10603.866	13.602414
Sum128Traits	14.091	18603.729	23.864469
Sum128Traits_ArgsT	14.333	18289.904	23.461901
Sum256Base_Basic	343.302	763.596	0.979525
Sum256Base	336.474	779.092	0.999403
Sum256Avx2_Combine	25.462	10295.303	13.206596
Sum256Traits	7.169	36567.932	46.908566
Sum256Traits_ArgsT	7.019	37349.128	47.910668
Sum512Base_Basic	361.699	724.758	0.929705
Sum512Base	497.115	527.331	0.676449
Sum512Traits	5.756	45542.736	58.421254
Sum512Traits_ArgsT	5.763	45486.067	58.348560

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
# Sum512Base_Basic	-12829441
SumBase_Basic	531.937	492.810
SumBase	505.119	518.975	1.053092
SumTraits	15.777	16615.500	33.715813
SumTraits_Args	16.020	16363.912	33.205295
SumTraits_ArgsT	16.399	15985.566	32.437564
Sum128Base_Basic	845.206	310.154	0.629358
Sum128Base	837.181	313.127	0.635391
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	49.819	5261.967	10.677469
Sum128Traits	28.521	9191.362	18.650911
Sum128Traits_ArgsT	28.062	9341.585	18.955742
Sum256Base_Basic	552.687	474.308	0.962455
Sum256Base	523.902	500.369	1.015337
Sum256Avx2_Combine	25.767	10173.456	20.643756
Sum256Traits	16.228	16154.269	32.779892
Sum256Traits_ArgsT	15.849	16540.374	33.563368
Sum512Base_Basic	549.344	477.194	0.968312
Sum512Base	503.404	520.742	1.056679
Sum512Traits	14.562	18002.034	36.529337
Sum512Traits_ArgsT	14.563	18000.725	36.526680

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
# Sum512Base_Basic	5766085150769386658
SumBase_Basic	1017.273	257.693
SumBase	923.355	283.904	1.101714
SumTraits	29.861	8778.706	34.066543
SumTraits_Args	28.573	9174.376	35.601975
SumTraits_ArgsT	29.051	9023.532	35.016610
Sum128Base_Basic	1623.339	161.484	0.626655
Sum128Base	1615.902	162.228	0.629539
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	99.783	2627.131	10.194813
Sum128Traits	55.554	4718.742	18.311495
Sum128Traits_ArgsT	55.990	4681.940	18.168680
Sum256Base_Basic	1017.401	257.660	0.999874
Sum256Base	916.713	285.961	1.109696
Sum256Avx2_Combine	50.438	5197.336	20.168721
Sum256Traits	28.893	9073.060	35.208809
Sum256Traits_ArgsT	29.009	9036.689	35.067667
Sum512Base_Basic	955.856	274.251	1.064253
Sum512Base	656.306	399.423	1.549998
Sum512Traits	25.885	10127.402	39.300276
Sum512Traits_ArgsT	25.576	10249.481	39.774017

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
# Sum512Base_Basic	117
SumBase_Basic	272.153	963.222
SumBase	283.246	925.499	0.960836
SumTraits	5.330	49180.751	51.058584
SumTraits_Args	5.336	49126.457	51.002217
SumTraits_ArgsT	5.371	48809.890	50.673563
Sum128Base_Basic	334.275	784.216	0.814160
Sum128Base	322.085	813.897	0.844973
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	18.414	14236.355	14.779931
Sum128Sse_Permute	11.826	22166.339	23.012701
Sum128Sse_PermuteLonger	7.947	32986.744	34.246253
Sum128Traits	7.942	33006.004	34.266248
Sum128Traits_ArgsT	7.347	35682.271	37.044701
Sum256Base_Basic	278.903	939.910	0.975798
Sum256Base	284.495	921.435	0.956618
Sum256Avx2_Combine	17.170	15267.895	15.850858
Sum256Avx2_Permute	6.427	40784.863	42.342122
Sum256Avx2_PermuteLonger	5.359	48914.865	50.782546
Sum256Traits	5.357	48933.744	50.802146
Sum256Traits_ArgsT	5.403	48518.382	50.370925
Sum512Base_Basic	306.008	856.658	0.889367
Sum512Base	852.079	307.652	0.319399
Sum512Traits	5.219	50224.626	52.142317
Sum512Traits_ArgsT	3.920	66874.325	69.427739

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
# Sum512Base_Basic	-14137
SumBase_Basic	359.543	729.103
SumBase	350.470	747.978	1.025888
SumTraits	10.544	24862.192	34.099695
SumTraits_Args	10.563	24817.984	34.039062
SumTraits_ArgsT	10.671	24565.671	33.693002
Sum128Base_Basic	505.586	518.496	0.711142
Sum128Base	500.779	523.472	0.717968
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	38.355	6834.621	9.374012
Sum128Sse_Permute	23.461	11173.695	15.325262
Sum128Sse_PermuteLonger	15.075	17389.771	23.850909
Sum128Traits	15.191	17256.252	23.667782
Sum128Traits_ArgsT	15.076	17387.754	23.848142
Sum256Base_Basic	370.411	707.712	0.970660
Sum256Base	361.109	725.942	0.995665
Sum256Avx2_Combine	38.223	6858.239	9.406406
Sum256Avx2_Permute	13.050	20087.774	27.551350
Sum256Avx2_PermuteLonger	10.628	24664.853	33.829035
Sum256Traits	10.791	24293.223	33.319326
Sum256Traits_ArgsT	10.698	24504.767	33.609469
Sum512Base_Basic	383.370	683.788	0.937848
Sum512Base	809.793	323.717	0.443994
Sum512Traits	11.017	23794.633	32.635486
Sum512Traits_ArgsT	7.783	33681.144	46.195313

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
# Sum512Base_Basic	-12829441
SumBase_Basic	575.012	455.893
SumBase	562.770	465.810	1.021754
SumTraits	21.408	12245.165	26.859741
SumTraits_Args	21.317	12297.306	26.974111
SumTraits_ArgsT	21.696	12082.445	26.502815
Sum128Base_Basic	879.389	298.098	0.653877
Sum128Base	879.499	298.061	0.653795
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	74.331	3526.722	7.735856
Sum128Sse_CombineAvx	52.488	4994.314	10.955016
Sum128Sse_Permute	47.910	5471.566	12.001867
Sum128Sse_PermuteLonger	30.289	8654.647	18.983948
Sum128Traits	30.150	8694.716	19.071838
Sum128Traits_ArgsT	29.822	8790.291	19.281481
Sum256Base_Basic	583.563	449.213	0.985348
Sum256Base	551.642	475.206	1.042364
Sum256Avx2_Combine	36.269	7227.763	15.854082
Sum256Avx2_Permute	26.313	9962.650	21.853050
Sum256Avx2_PermuteLonger	21.911	11964.014	26.243036
Sum256Traits	21.438	12227.781	26.821608
Sum256Traits_ArgsT	21.606	12133.006	26.613720
Sum512Base_Basic	612.135	428.245	0.939355
Sum512Base	821.271	319.193	0.700150
Sum512Traits	22.371	11717.801	25.702968
Sum512Traits_ArgsT	16.272	16110.556	35.338466

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
# Sum512Base_Basic	5766085150769386658
SumBase_Basic	1075.909	243.649
SumBase	1055.370	248.391	1.019462
SumTraits	42.279	6200.402	25.448115
SumTraits_Args	42.934	6105.707	25.059462
SumTraits_ArgsT	42.047	6234.605	25.588495
Sum128Base_Basic	1734.874	151.103	0.620166
Sum128Base	1697.988	154.385	0.633638
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	160.746	1630.796	6.693227
Sum128Sse_CombineAvx	119.411	2195.314	9.010157
Sum128Sse_Permute	97.713	2682.787	11.010877
Sum128Sse_PermuteLonger	61.478	4264.060	17.500848
Sum128Traits	59.770	4385.848	18.000699
Sum128Traits_ArgsT	58.542	4477.911	18.378551
Sum256Base_Basic	1072.674	244.384	1.003016
Sum256Base	1048.295	250.067	1.026343
Sum256Avx2_Combine	74.467	3520.286	14.448198
Sum256Avx2_Permute	50.199	5222.066	21.432760
Sum256Avx2_PermuteLonger	42.934	6105.714	25.059488
Sum256Traits	42.400	6182.639	25.375211
Sum256Traits_ArgsT	42.392	6183.783	25.379905
Sum512Base_Basic	1061.361	246.988	1.013707
Sum512Base	992.729	264.064	1.083790
Sum512Traits	41.094	6379.197	26.181939
Sum512Traits_ArgsT	31.147	8416.329	34.542876

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	85
# Sum512Base_Basic	117
SumBase_Basic	294.064	891.452
SumBase	282.731	927.186	1.040085
SumTraits	5.606	46763.811	52.458030
SumTraits_Args	5.553	47204.861	52.952784
SumTraits_ArgsT	5.591	46887.974	52.597311
Sum128Base_Basic	321.597	815.131	0.914386
Sum128Base	329.242	796.205	0.893155
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	22.999	11398.204	12.786113
Sum128Sse_Permute	12.017	21815.131	24.471461
Sum128Sse_PermuteLonger	7.830	33479.321	37.555948
Sum128Traits	7.561	34672.521	38.894438
Sum128Traits_ArgsT	7.556	34693.417	38.917879
Sum256Base_Basic	304.741	860.218	0.964963
Sum256Base	284.641	920.964	1.033106
Sum256Avx2_Combine	23.443	11182.254	12.543867
Sum256Avx2_Permute	6.566	39921.575	44.782645
Sum256Avx2_PermuteLonger	5.643	46452.648	52.108978
Sum256Traits	5.542	47305.600	53.065790
Sum256Traits_ArgsT	5.550	47232.902	52.984240
Sum512Base_Basic	304.118	861.981	0.966941
Sum512Base	945.215	277.338	0.311108
Sum512Traits	5.349	49009.996	54.977722
Sum512Traits_ArgsT	3.940	66532.354	74.633700

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	-19913
# Sum512Base_Basic	-14137
SumBase_Basic	369.449	709.553
SumBase	358.750	730.715	1.029825
SumTraits	10.584	24768.336	34.906952
SumTraits_Args	10.873	24109.187	33.977989
SumTraits_ArgsT	10.777	24324.144	34.280936
Sum128Base_Basic	518.042	506.029	0.713165
Sum128Base	523.750	500.514	0.705393
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	46.952	5583.220	7.868643
Sum128Sse_Permute	26.086	10049.249	14.162786
Sum128Sse_PermuteLonger	16.509	15879.008	22.378886
Sum128Traits	17.516	14965.848	21.091935
Sum128Traits_ArgsT	14.851	17651.997	24.877626
Sum256Base_Basic	372.186	704.335	0.992646
Sum256Base	359.639	728.908	1.027277
Sum256Avx2_Combine	48.686	5384.367	7.588392
Sum256Avx2_Permute	12.786	20502.277	28.894634
Sum256Avx2_PermuteLonger	10.991	23851.373	33.614642
Sum256Traits	10.833	24199.342	34.105047
Sum256Traits_ArgsT	10.616	24693.193	34.801050
Sum512Base_Basic	413.258	634.335	0.893992
Sum512Base	1008.802	259.857	0.366226
Sum512Traits	11.368	23060.200	32.499612
Sum512Traits_ArgsT	7.881	33261.853	46.877187

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21410359
# Sum128Base_Basic	21672503
# Sum256Base_Basic	21410359
# Sum512Base_Basic	-12829441
SumBase_Basic	630.646	415.676
SumBase	611.155	428.932	1.031891
SumTraits	21.624	12122.958	29.164464
SumTraits_Args	23.003	11396.250	27.416205
SumTraits_ArgsT	22.325	11742.099	28.248221
Sum128Base_Basic	968.710	270.611	0.651016
Sum128Base	934.142	280.625	0.675107
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	95.467	2745.922	6.605924
Sum128Sse_CombineAvx	54.949	4770.686	11.476942
Sum128Sse_Permute	52.482	4994.935	12.016423
Sum128Sse_PermuteLonger	31.997	8192.892	19.709819
Sum128Traits	31.021	8450.614	20.329826
Sum128Traits_ArgsT	32.240	8131.090	19.561139
Sum256Base_Basic	638.657	410.461	0.987456
Sum256Base	596.307	439.612	1.057585
Sum256Avx2_Combine	49.414	5305.054	12.762484
Sum256Avx2_Permute	27.111	9669.274	23.261583
Sum256Avx2_PermuteLonger	23.051	11372.471	27.359001
Sum256Traits	21.538	12171.250	29.280641
Sum256Traits_ArgsT	22.697	11549.694	27.785349
Sum512Base_Basic	661.685	396.176	0.953090
Sum512Base	881.699	297.317	0.715262
Sum512Traits	22.608	11595.050	27.894463
Sum512Traits_ArgsT	16.611	15781.247	37.965288

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635317506
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	31817777635317506
# Sum512Base_Basic	5766085150769386658
SumBase_Basic	1184.847	221.247
SumBase	1130.445	231.895	1.048124
SumTraits	43.525	6022.813	27.222099
SumTraits_Args	43.021	6093.442	27.541331
SumTraits_ArgsT	41.803	6270.980	28.343776
Sum128Base_Basic	1801.998	145.474	0.657518
Sum128Base	1851.662	141.572	0.639883
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	193.035	1358.014	6.137996
Sum128Sse_CombineAvx	113.673	2306.123	10.423287
Sum128Sse_Permute	99.709	2629.088	11.883037
Sum128Sse_PermuteLonger	60.569	4328.000	19.561830
Sum128Traits	66.468	3943.918	17.825844
Sum128Traits_ArgsT	63.992	4096.481	18.515406
Sum256Base_Basic	1195.848	219.212	0.990800
Sum256Base	1129.423	232.104	1.049073
Sum256Avx2_Combine	99.445	2636.071	11.914596
Sum256Avx2_Permute	52.648	4979.182	22.505066
Sum256Avx2_PermuteLonger	42.796	6125.421	27.685873
Sum256Traits	44.352	5910.534	26.714617
Sum256Traits_ArgsT	42.655	6145.693	27.777496
Sum512Base_Basic	1166.555	224.716	1.015681
Sum512Base	1202.358	218.025	0.985436
Sum512Traits	42.460	6173.950	27.905213
Sum512Traits_ArgsT	31.667	8278.127	37.415742

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	263.156	996.153
SumBase	262.767	997.631	1.001484
SumTraits	10.871	24114.203	24.207336
SumTraits_Args	9.669	27111.475	27.216184
SumTraits_ArgsT	18.156	14438.208	14.493971
Sum128Base_Basic	326.228	803.560	0.806663
Sum128Base	325.248	805.983	0.809095
Sum128Arm	13.676	19168.034	19.242064
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.641	27191.242	27.296258
Sum128Traits_ArgsT	15.090	17371.642	17.438734
Sum256Base_Basic	309.428	847.189	0.850461
Sum256Base	318.149	823.967	0.827149
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	319.422	820.682	0.823852
Sum256Traits_ArgsT	340.045	770.910	0.773887

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	393.994	665.349
SumBase	393.895	665.517	1.000252
SumTraits	25.330	10348.980	15.554203
SumTraits_Args	19.313	13573.264	20.400203
SumTraits_ArgsT	36.249	7231.713	10.869045
Sum128Base_Basic	460.756	568.944	0.855105
Sum128Base	459.747	570.191	0.856980
Sum128Arm	32.547	8054.294	12.105359
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.298	13584.316	20.416815
Sum128Traits_ArgsT	30.157	8692.589	13.064697
Sum256Base_Basic	469.290	558.597	0.839554
Sum256Base	470.190	557.528	0.837947
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	469.538	558.301	0.839110
Sum256Traits_ArgsT	511.043	512.959	0.770962

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	694.776	377.307
SumBase	681.015	384.931	1.020206
SumTraits	50.615	5179.177	13.726678
SumTraits_Args	38.572	6796.217	18.012413
SumTraits_ArgsT	72.341	3623.730	9.604185
Sum128Base_Basic	905.882	289.380	0.766961
Sum128Base	911.284	287.664	0.762414
Sum128Arm	65.054	4029.660	10.680045
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.566	6797.292	18.015263
Sum128Traits_ArgsT	60.294	4347.777	11.523170
Sum256Base_Basic	702.950	372.920	0.988372
Sum256Base	706.117	371.247	0.983938
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	701.827	373.516	0.989952
Sum256Traits_ArgsT	788.325	332.533	0.881332

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	1344.483	194.978
SumBase	1338.202	195.893	1.004693
SumTraits	106.120	2470.259	12.669450
SumTraits_Args	77.111	3399.551	17.435603
SumTraits_ArgsT	144.704	1811.587	9.291256
Sum128Base_Basic	1711.753	153.144	0.785442
Sum128Base	1714.539	152.895	0.784166
Sum128Arm	134.922	1942.931	9.964895
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	81.930	3199.628	16.410234
Sum128Traits_ArgsT	120.538	2174.780	11.154001
Sum256Base_Basic	1272.933	205.937	1.056209
Sum256Base	1278.685	205.011	1.051458
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1271.370	206.190	1.057508
Sum256Traits_ArgsT	1479.366	177.200	0.908824

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	280.288	935.266
SumBase	279.210	938.877	1.003861
SumTraits	13.882	18884.082	20.191129
SumTraits_Args	12.073	21713.042	23.215893
SumTraits_ArgsT	21.740	12057.989	12.892573
Sum128Base_Basic	345.933	757.788	0.810238
Sum128Base	347.163	755.102	0.807366
Sum128Arm	20.685	12673.084	13.550242
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.669	27112.086	28.988627
Sum128Traits_ArgsT	16.892	15519.250	16.593402
Sum256Base_Basic	328.722	797.465	0.852661
Sum256Base	336.834	778.259	0.832126
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	340.000	771.012	0.824376
Sum256Traits_ArgsT	359.794	728.594	0.779023

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	410.467	638.648
SumBase	419.144	625.428	0.979299
SumTraits	31.343	8363.687	13.095923
SumTraits_Args	24.114	10870.986	17.021870
SumTraits_ArgsT	48.689	5384.030	8.430354
Sum128Base_Basic	487.066	538.210	0.842733
Sum128Base	486.111	539.268	0.844390
Sum128Arm	48.942	5356.172	8.386733
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	24.258	10806.436	16.920798
Sum128Traits_ArgsT	33.761	7764.665	12.157969
Sum256Base_Basic	506.229	517.836	0.810832
Sum256Base	508.401	515.624	0.807368
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	510.464	513.540	0.804105
Sum256Traits_ArgsT	546.129	480.004	0.751593

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	677.170	387.117
SumBase	676.744	387.361	1.000629
SumTraits	62.668	4183.049	10.805640
SumTraits_Args	48.210	5437.536	14.046230
SumTraits_ArgsT	96.109	2727.559	7.045822
Sum128Base_Basic	975.690	268.675	0.694041
Sum128Base	974.965	268.875	0.694558
Sum128Arm	97.777	2681.036	6.925645
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	48.493	5405.846	13.964367
Sum128Traits_ArgsT	67.498	3883.709	10.032387
Sum256Base_Basic	787.546	332.862	0.859848
Sum256Base	788.925	332.280	0.858345
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	789.441	332.063	0.857784
Sum256Traits_ArgsT	879.859	297.939	0.769634

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	1285.335	203.950
SumBase	1283.896	204.179	1.001121
SumTraits	130.078	2015.285	9.881272
SumTraits_Args	96.362	2720.419	13.338659
SumTraits_ArgsT	183.873	1425.678	6.990333
Sum128Base_Basic	1792.859	146.216	0.716919
Sum128Base	1787.539	146.651	0.719053
Sum128Arm	195.566	1340.438	6.572384
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	96.826	2707.372	13.274689
Sum128Traits_ArgsT	134.941	1942.662	9.525190
Sum256Base_Basic	1457.493	179.860	0.881881
Sum256Base	1463.239	179.153	0.878417
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1467.566	178.625	0.875827
Sum256Traits_ArgsT	1678.179	156.207	0.765910

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	287.741	911.042
SumBase	287.380	912.186	1.001255
SumTraits	16.890	15520.669	17.036173
SumTraits_Args	14.485	18098.081	19.865255
SumTraits_ArgsT	27.356	9582.669	10.518362
Sum128Base_Basic	354.952	738.533	0.810647
Sum128Base	356.460	735.410	0.807218
Sum128Arm	29.445	8902.800	9.772107
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	13.277	19744.391	21.672317
Sum128Traits_ArgsT	18.704	14015.342	15.383860
Sum256Base_Basic	342.421	765.561	0.840314
Sum256Base	357.780	732.696	0.804240
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	362.026	724.103	0.794807
Sum256Traits_ArgsT	380.256	689.389	0.756704

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	447.595	585.672
SumBase	446.033	587.723	1.003501
SumTraits	37.368	7015.291	11.978186
SumTraits_Args	28.930	9061.464	15.471902
SumTraits_ArgsT	55.931	4686.885	8.002572
Sum128Base_Basic	511.056	512.946	0.875825
Sum128Base	511.659	512.341	0.874792
Sum128Arm	63.786	4109.760	7.017168
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	31.560	8306.109	14.182180
Sum128Traits_ArgsT	37.374	7014.042	11.976052
Sum256Base_Basic	546.643	479.553	0.818807
Sum256Base	550.742	475.983	0.812713
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	546.677	479.523	0.818756
Sum256Traits_ArgsT	585.741	447.542	0.764152

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	742.008	353.290
SumBase	742.360	353.123	0.999527
SumTraits	74.707	3508.959	9.932240
SumTraits_Args	57.833	4532.738	12.830085
SumTraits_ArgsT	113.595	2307.705	6.532045
Sum128Base_Basic	1040.202	252.013	0.713331
Sum128Base	1033.731	253.590	0.717797
Sum128Arm	127.560	2055.069	5.816949
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	63.042	4158.229	11.770024
Sum128Traits_ArgsT	74.744	3507.228	9.927340
Sum256Base_Basic	915.090	286.468	0.810858
Sum256Base	916.491	286.030	0.809619
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	920.426	284.807	0.806157
Sum256Traits_ArgsT	1012.216	258.980	0.733054

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	1396.879	187.664
SumBase	1395.703	187.822	1.000843
SumTraits	154.164	1700.424	9.060996
SumTraits_Args	115.708	2265.564	12.072440
SumTraits_ArgsT	224.237	1169.047	6.229468
Sum128Base_Basic	1904.669	137.632	0.733397
Sum128Base	1904.272	137.661	0.733550
Sum128Arm	254.413	1030.386	5.490587
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	126.068	2079.381	11.080336
Sum128Traits_ArgsT	149.375	1754.940	9.351496
Sum256Base_Basic	1685.547	155.525	0.828739
Sum256Base	1681.255	155.922	0.830855
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1684.203	155.649	0.829401
Sum256Traits_ArgsT	1903.201	137.738	0.733963

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	231.987	1129.995
SumBase	230.762	1135.991	1.005306
SumTraits	9.668	27113.711	23.994534
SumTraits_Args	9.649	27168.117	24.042682
SumTraits_ArgsT	9.681	27077.600	23.962578
Sum128Base_Basic	230.157	1138.978	1.007949
Sum128Base	231.082	1134.421	1.003916
Sum128Arm	13.390	19577.168	17.325000
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.645	27179.159	24.052453
Sum128Traits_ArgsT	9.649	27168.233	24.042785
Sum256Base_Basic	330.279	793.705	0.702397
Sum256Base	330.441	793.315	0.702052
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	330.384	793.452	0.702172
Sum256Traits_ArgsT	336.357	779.363	0.689705

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	314.500	833.526
SumBase	314.555	833.381	0.999826
SumTraits	21.710	12075.050	14.486712
SumTraits_Args	19.279	13597.671	16.313436
SumTraits_ArgsT	19.357	13542.515	16.247264
Sum128Base_Basic	311.775	840.811	1.008740
Sum128Base	310.588	844.025	1.012596
Sum128Arm	33.074	7926.017	9.509023
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.285	13592.875	16.307681
Sum128Traits_ArgsT	19.287	13591.705	16.306278
Sum256Base_Basic	409.763	639.745	0.767517
Sum256Base	409.095	640.791	0.768771
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	408.821	641.220	0.769286
Sum256Traits_ArgsT	434.940	602.713	0.723089

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	605.535	432.913
SumBase	605.334	433.057	1.000332
SumTraits	43.391	6041.436	13.955309
SumTraits_Args	38.551	6800.007	15.707557
SumTraits_ArgsT	43.662	6003.930	13.868674
Sum128Base_Basic	603.323	434.500	1.003666
Sum128Base	579.321	452.502	1.045250
Sum128Arm	66.099	3965.922	9.161012
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.549	6800.305	15.708246
Sum128Traits_ArgsT	38.553	6799.586	15.706585
Sum256Base_Basic	593.255	441.874	1.020700
Sum256Base	592.071	442.757	1.022740
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	593.788	441.477	1.019783
Sum256Traits_ArgsT	648.335	404.334	0.933985

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	1175.073	223.087
SumBase	1173.191	223.445	1.001605
SumTraits	91.554	2863.275	12.834766
SumTraits_Args	77.084	3400.749	15.244022
SumTraits_ArgsT	77.252	3393.367	15.210930
Sum128Base_Basic	1166.166	224.791	1.007637
Sum128Base	1123.167	233.397	1.046214
Sum128Arm	137.260	1909.832	8.560913
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.077	3401.063	15.245428
Sum128Traits_ArgsT	77.088	3400.570	15.243217
Sum256Base_Basic	1066.530	245.792	1.101773
Sum256Base	1061.418	246.975	1.107079
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1059.501	247.422	1.109082
Sum256Traits_ArgsT	1184.182	221.371	0.992308

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	235.888	1111.308
SumBase	235.869	1111.397	1.000080
SumTraits	13.915	18838.900	16.952005
SumTraits_Args	11.149	23512.053	21.157097
SumTraits_ArgsT	16.760	15640.861	14.074280
Sum128Base_Basic	240.711	1089.040	0.979962
Sum128Base	240.309	1090.864	0.981603
Sum128Arm	20.688	12671.251	11.402105
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.672	27103.436	24.388769
Sum128Traits_ArgsT	9.667	27117.247	24.401197
Sum256Base_Basic	341.973	766.564	0.689785
Sum256Base	342.070	766.346	0.689589
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	341.557	767.497	0.690625
Sum256Traits_ArgsT	347.364	754.666	0.679079

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	333.206	786.732
SumBase	332.591	788.188	1.001850
SumTraits	28.936	9059.348	11.515161
SumTraits_Args	21.709	12075.264	15.348633
SumTraits_ArgsT	31.773	8250.401	10.486923
Sum128Base_Basic	332.531	788.330	1.002031
Sum128Base	331.741	790.207	1.004416
Sum128Arm	47.154	5559.300	7.066318
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	22.141	11839.591	15.049073
Sum128Traits_ArgsT	19.301	13581.638	17.263355
Sum256Base_Basic	430.869	608.407	0.773334
Sum256Base	433.150	605.204	0.769263
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	430.235	609.305	0.774475
Sum256Traits_ArgsT	462.453	566.855	0.720518

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	593.720	441.528
SumBase	588.692	445.299	1.008542
SumTraits	57.840	4532.240	10.264904
SumTraits_Args	43.384	6042.436	13.685292
SumTraits_ArgsT	64.354	4073.442	9.225790
Sum128Base_Basic	639.435	409.962	0.928508
Sum128Base	566.265	462.936	1.048486
Sum128Arm	94.342	2778.671	6.293310
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	44.223	5927.786	13.425626
Sum128Traits_ArgsT	38.569	6796.795	15.393812
Sum256Base_Basic	650.787	402.811	0.912311
Sum256Base	644.622	406.663	0.921037
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	648.419	404.282	0.915643
Sum256Traits_ArgsT	714.981	366.645	0.830400

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	1168.722	224.300
SumBase	1169.317	224.185	0.999491
SumTraits	120.454	2176.292	9.702611
SumTraits_Args	86.730	3022.535	13.475433
SumTraits_ArgsT	115.387	2271.862	10.128691
Sum128Base_Basic	1209.544	216.730	0.966250
Sum128Base	1101.537	237.980	1.060993
Sum128Arm	186.275	1407.293	6.274166
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	88.325	2967.944	13.232049
Sum128Traits_ArgsT	77.108	3399.681	15.156875
Sum256Base_Basic	1209.988	216.650	0.965896
Sum256Base	1189.387	220.403	0.982625
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1190.316	220.231	0.981859
Sum256Traits_ArgsT	1322.738	198.183	0.883563

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	250.846	1045.040
SumBase	249.916	1048.930	1.003723
SumTraits	18.301	14324.216	13.706861
SumTraits_Args	13.850	18927.408	18.111661
SumTraits_ArgsT	19.818	13227.696	12.657599
Sum128Base_Basic	251.719	1041.415	0.996532
Sum128Base	253.688	1033.333	0.988797
Sum128Arm	27.953	9378.023	8.973842
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	13.284	19733.279	18.882800
Sum128Traits_ArgsT	10.279	25503.760	24.404580
Sum256Base_Basic	355.132	738.159	0.706345
Sum256Base	354.142	740.223	0.708320
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	354.662	739.137	0.707281
Sum256Traits_ArgsT	358.895	730.420	0.698939

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	355.739	736.901
SumBase	354.395	739.695	1.003792
SumTraits	38.018	6895.249	9.357094
SumTraits_Args	29.361	8928.241	12.115935
SumTraits_ArgsT	41.665	6291.661	8.538004
Sum128Base_Basic	349.939	749.114	1.016573
Sum128Base	351.796	745.159	1.011207
Sum128Arm	61.610	4254.873	5.774012
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	29.951	8752.558	11.877527
Sum128Traits_ArgsT	20.570	12743.893	17.293908
Sum256Base_Basic	458.862	571.291	0.775262
Sum256Base	461.058	568.570	0.771570
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	460.074	569.787	0.773221
Sum256Traits_ArgsT	489.096	535.977	0.727339

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	615.962	425.585
SumBase	609.034	430.426	1.011375
SumTraits	90.383	2900.380	6.815048
SumTraits_Args	59.837	4380.989	10.294046
SumTraits_ArgsT	82.279	3186.021	7.486220
Sum128Base_Basic	664.879	394.273	0.926427
Sum128Base	631.971	414.804	0.974667
Sum128Arm	123.233	2127.226	4.998361
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	59.833	4381.253	10.294667
Sum128Traits_ArgsT	41.100	6378.258	14.987045
Sum256Base_Basic	705.509	371.567	0.873075
Sum256Base	705.509	371.567	0.873074
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	705.791	371.419	0.872726
Sum256Traits_ArgsT	765.649	342.381	0.804496

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	1129.906	232.005
SumBase	1131.948	231.587	0.998196
SumTraits	149.360	1755.112	7.564970
SumTraits_Args	106.041	2472.091	10.655327
SumTraits_ArgsT	160.861	1629.628	7.024101
Sum128Base_Basic	1258.443	208.308	0.897860
Sum128Base	1196.479	219.096	0.944359
Sum128Arm	246.831	1062.039	4.577652
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	119.726	2189.525	9.437396
Sum128Traits_ArgsT	82.116	3192.350	13.759823
Sum256Base_Basic	1316.597	199.107	0.858202
Sum256Base	1310.158	200.086	0.862419
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1294.006	202.583	0.873184
Sum256Traits_ArgsT	1430.702	183.228	0.789756

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	168.516	1555.604
SumBase	168.536	1555.414	0.999878
SumTraits	9.623	27240.132	17.510966
SumTraits_Args	9.625	27236.197	17.508437
SumTraits_ArgsT	9.623	27242.476	17.512473
Sum128Base_Basic	168.523	1555.540	0.999959
Sum128Base	168.528	1555.495	0.999930
Sum128Arm	9.633	27214.191	17.494291
Sum128Arm_Combine	12.095	21673.223	13.932351
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	9.617	27257.058	17.521847
Sum128Traits_ArgsT	9.620	27250.741	17.517786
Sum256Base_Basic	163.201	1606.266	1.032568
Sum256Base	163.200	1606.271	1.032570
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	163.203	1606.248	1.032556
Sum256Traits_ArgsT	163.208	1606.193	1.032520
Sum512Base_Basic	173.119	1514.242	0.973411
Sum512Base	172.965	1515.588	0.974276
Sum512Traits	172.867	1516.447	0.974828
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	229.146	1144.003
SumBase	228.964	1144.913	1.000796
SumTraits	19.252	13616.487	11.902497
SumTraits_Args	19.248	13619.401	11.905044
SumTraits_ArgsT	19.247	13620.174	11.905720
Sum128Base_Basic	230.848	1135.570	0.992629
Sum128Base	222.079	1180.408	1.031823
Sum128Arm	19.283	13594.638	11.883398
Sum128Arm_Combine	28.509	9195.181	8.037727
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.258	13611.881	11.898470
Sum128Traits_ArgsT	19.251	13617.417	11.903309
Sum256Base_Basic	172.254	1521.842	1.330279
Sum256Base	172.245	1521.927	1.330353
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	172.258	1521.811	1.330251
Sum256Traits_ArgsT	172.262	1521.773	1.330218
Sum512Base_Basic	191.856	1366.357	1.194365
Sum512Base	191.294	1370.370	1.197873
Sum512Traits	191.269	1370.555	1.198034
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	214.423	1222.558
SumBase	214.439	1222.463	0.999922
SumTraits	38.523	6804.914	5.566129
SumTraits_Args	38.524	6804.728	5.565977
SumTraits_ArgsT	38.526	6804.287	5.565617
Sum128Base_Basic	214.416	1222.594	1.000029
Sum128Base	214.389	1222.749	1.000157
Sum128Arm	38.547	6800.644	5.562636
Sum128Arm_Combine	56.992	4599.670	3.762333
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	38.526	6804.267	5.565600
Sum128Traits_ArgsT	38.528	6803.995	5.565378
Sum256Base_Basic	201.741	1299.411	1.062863
Sum256Base	201.676	1299.830	1.063206
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	201.625	1300.153	1.063470
Sum256Traits_ArgsT	201.585	1300.412	1.063681
Sum512Base_Basic	229.211	1143.678	0.935480
Sum512Base	229.634	1141.571	0.933757
Sum512Traits	229.494	1142.269	0.934328
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	332.689	787.954
SumBase	332.586	788.199	1.000311
SumTraits	77.071	3401.351	4.316686
SumTraits_Args	77.059	3401.876	4.317352
SumTraits_ArgsT	77.062	3401.708	4.317139
Sum128Base_Basic	332.649	788.050	1.000121
Sum128Base	332.521	788.353	1.000506
Sum128Arm	77.086	3400.651	4.315798
Sum128Arm_Combine	113.945	2300.615	2.919731
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	77.066	3401.544	4.316931
Sum128Traits_ArgsT	77.056	3402.005	4.317516
Sum256Base_Basic	246.165	1064.911	1.351489
Sum256Base	246.181	1064.844	1.351404
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	246.238	1064.598	1.351091
Sum256Traits_ArgsT	246.288	1064.382	1.350817
Sum512Base_Basic	375.627	697.884	0.885691
Sum512Base	375.816	697.533	0.885246
Sum512Traits	375.704	697.740	0.885509
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	168.537	1555.405
SumBase	168.596	1554.863	0.999651
SumTraits	9.633	27212.259	17.495283
SumTraits_Args	9.632	27215.924	17.497639
SumTraits_ArgsT	9.631	27219.622	17.500016
Sum128Base_Basic	168.623	1554.618	0.999494
Sum128Base	168.615	1554.686	0.999538
Sum128Arm	9.644	27182.585	17.476205
Sum128Arm_Combine	19.400	13512.727	8.687591
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Traits	9.629	27225.121	17.503552
Sum128Traits_ArgsT	9.626	27232.872	17.508535
Sum256Base_Basic	164.973	1589.009	1.021604
Sum256Base	164.974	1589.005	1.021602
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi!
Sum256Traits	164.996	1588.785	1.021461
Sum256Traits_ArgsT	165.570	1583.284	1.017924
Sum512Base_Basic	179.742	1458.449	0.937665
Sum512Base	179.880	1457.326	0.936943
Sum512Traits	179.882	1457.308	0.936931
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	217.247	1206.662
SumBase	215.789	1214.815	1.006757
SumTraits	19.261	13610.408	11.279391
SumTraits_Args	19.266	13606.898	11.276482
SumTraits_ArgsT	19.261	13610.302	11.279303
Sum128Base_Basic	208.552	1256.974	1.041695
Sum128Base	204.918	1279.262	1.060166
Sum128Arm	20.818	12591.950	10.435361
Sum128Arm_Combine	42.490	6169.492	5.112860
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Traits	19.263	13608.502	11.277811
Sum128Traits_ArgsT	19.264	13607.988	11.277385
Sum256Base_Basic	175.874	1490.520	1.235243
Sum256Base	175.834	1490.862	1.235526
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512BW!
Sum256Traits	175.829	1490.904	1.235561
Sum256Traits_ArgsT	177.072	1480.434	1.226884
Sum512Base_Basic	205.400	1276.260	1.057678
Sum512Base	205.278	1277.017	1.058305
Sum512Traits	205.613	1274.939	1.056583
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	226.437	1157.689
SumBase	226.437	1157.689	1.000001
SumTraits	38.531	6803.467	5.876768
SumTraits_Args	38.532	6803.307	5.876629
SumTraits_ArgsT	38.531	6803.532	5.876824
Sum128Base_Basic	226.489	1157.424	0.999771
Sum128Base	226.505	1157.346	0.999704
Sum128Arm	41.872	6260.539	5.407792
Sum128Arm_Combine	84.981	3084.751	2.664577
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Traits	38.531	6803.525	5.876818
Sum128Traits_ArgsT	38.530	6803.684	5.876955
Sum256Base_Basic	208.469	1257.472	1.086192
Sum256Base	208.492	1257.331	1.086070
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	208.490	1257.344	1.086081
Sum256Traits_ArgsT	210.924	1242.838	1.073551
Sum512Base_Basic	256.806	1020.785	0.881744
Sum512Base	256.645	1021.426	0.882298
Sum512Traits	256.613	1021.555	0.882409
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	356.616	735.087
SumBase	356.598	735.125	1.000052
SumTraits	77.072	3401.301	4.627072
SumTraits_Args	77.069	3401.436	4.627255
SumTraits_ArgsT	77.077	3401.085	4.626778
Sum128Base_Basic	356.574	735.174	1.000119
Sum128Base	356.619	735.081	0.999992
Sum128Arm	85.667	3060.041	4.162828
Sum128Arm_Combine	169.918	1542.768	2.098755
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum128Traits	77.073	3401.254	4.627008
Sum128Traits_ArgsT	77.064	3401.648	4.627543
Sum256Base_Basic	291.230	900.128	1.224518
Sum256Base	284.059	922.852	1.255432
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	288.927	907.303	1.234280
Sum256Traits_ArgsT	288.411	908.927	1.236488
Sum512Base_Basic	461.415	568.131	0.772875
Sum512Base	461.438	568.102	0.772836
Sum512Traits	461.149	568.458	0.773320
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	170.995	1533.053
SumBase	171.020	1532.822	0.999850
SumTraits	9.635	27207.207	17.747074
SumTraits_Args	9.635	27208.215	17.747732
SumTraits_ArgsT	9.635	27208.765	17.748091
Sum128Base_Basic	170.979	1533.198	1.000094
Sum128Base	171.000	1533.009	0.999971
Sum128Arm	10.473	25030.790	16.327412
Sum128Arm_Combine	26.720	9810.858	6.399555
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Traits	9.633	27212.208	17.750337
Sum128Traits_ArgsT	9.634	27209.634	17.748658
Sum256Base_Basic	167.423	1565.760	1.021334
Sum256Base	167.381	1566.152	1.021590
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi!
Sum256Traits	167.449	1565.513	1.021174
Sum256Traits_ArgsT	168.303	1557.575	1.015995
Sum512Base_Basic	184.604	1420.034	0.926279
Sum512Base	211.669	1238.464	0.807842
Sum512Traits	184.553	1420.425	0.926533
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	198.105	1323.257
SumBase	198.187	1322.709	0.999586
SumTraits	19.267	13605.531	10.281851
SumTraits_Args	19.267	13605.811	10.282062
SumTraits_ArgsT	19.281	13595.647	10.274381
Sum128Base_Basic	200.311	1308.682	0.988986
Sum128Base	199.948	1311.061	0.990783
Sum128Arm	25.820	10152.615	7.672444
Sum128Arm_Combine	55.852	4693.544	3.546963
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Traits	19.273	13601.863	10.279079
Sum128Traits_ArgsT	19.266	13606.519	10.282597
Sum256Base_Basic	180.661	1451.029	1.096559
Sum256Base	180.685	1450.834	1.096411
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512BW!
Sum256Traits	180.680	1450.875	1.096442
Sum256Traits_ArgsT	182.545	1436.049	1.085238
Sum512Base_Basic	215.143	1218.462	0.920805
Sum512Base	215.133	1218.519	0.920848
Sum512Traits	215.115	1218.622	0.920926
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	233.734	1121.547
SumBase	233.739	1121.526	0.999981
SumTraits	38.537	6802.400	6.065194
SumTraits_Args	38.537	6802.439	6.065229
SumTraits_ArgsT	38.540	6801.862	6.064714
Sum128Base_Basic	233.757	1121.439	0.999903
Sum128Base	233.813	1121.171	0.999665
Sum128Arm	51.975	5043.644	4.497042
Sum128Arm_Combine	111.662	2347.646	2.093221
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Traits	38.536	6802.530	6.065309
Sum128Traits_ArgsT	38.539	6802.078	6.064906
Sum256Base_Basic	219.794	1192.681	1.063425
Sum256Base	220.125	1190.889	1.061827
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	220.940	1186.494	1.057908
Sum256Traits_ArgsT	222.396	1178.727	1.050983
Sum512Base_Basic	288.162	909.711	0.811122
Sum512Base	288.178	909.661	0.811077
Sum512Traits	288.196	909.603	0.811026
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	373.123	702.568
SumBase	373.140	702.535	0.999954
SumTraits	77.072	3401.303	4.841247
SumTraits_Args	77.069	3401.433	4.841432
SumTraits_ArgsT	77.072	3401.286	4.841223
Sum128Base_Basic	372.794	703.188	1.000883
Sum128Base	372.766	703.240	1.000957
Sum128Arm	105.252	2490.638	3.545052
Sum128Arm_Combine	223.327	1173.810	1.670743
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Traits	77.077	3401.045	4.840879
Sum128Traits_ArgsT	77.076	3401.099	4.840956
Sum256Base_Basic	327.447	800.570	1.139492
Sum256Base	327.503	800.432	1.139295
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	327.419	800.638	1.139589
Sum256Traits_ArgsT	330.221	793.844	1.129919
Sum512Base_Basic	544.634	481.321	0.685089
Sum512Base	544.147	481.752	0.685702
Sum512Traits	545.202	480.820	0.684376
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	678.353	386.442
SumBase	683.569	383.493	0.992370
SumTraits	682.349	384.179	0.994144
SumTraits_Args	682.027	384.360	0.994613
SumTraits_ArgsT	709.802	369.320	0.955693
Sum128Base_Basic	952.730	275.150	0.712010
Sum128Base	956.341	274.111	0.709321
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	956.664	274.019	0.709082
Sum128Traits_ArgsT	966.790	271.149	0.701655
Sum256Base_Basic	879.889	297.928	0.770953
Sum256Base	916.169	286.131	0.740424
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1000.770	261.942	0.677831
Sum256Traits_ArgsT	1082.701	242.121	0.626538

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	1044.589	250.954
SumBase	1047.954	250.149	0.996789
SumTraits	1047.772	250.192	0.996962
SumTraits_Args	1047.176	250.334	0.997530
SumTraits_ArgsT	1081.417	242.408	0.965944
Sum128Base_Basic	1428.138	183.557	0.731434
Sum128Base	1436.436	182.496	0.727209
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1444.832	181.436	0.722983
Sum128Traits_ArgsT	1485.796	176.433	0.703050
Sum256Base_Basic	1629.803	160.844	0.640929
Sum256Base	1682.186	155.835	0.620971
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1873.716	139.906	0.557496
Sum256Traits_ArgsT	2046.514	128.093	0.510424

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	1382.011	189.683
SumBase	1353.399	193.693	1.021141
SumTraits	1354.315	193.562	1.020450
SumTraits_Args	1360.902	192.625	1.015512
SumTraits_ArgsT	1446.761	181.194	0.955245
Sum128Base_Basic	2176.616	120.436	0.634936
Sum128Base	2171.375	120.727	0.636468
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2186.284	119.904	0.632128
Sum128Traits_ArgsT	2286.947	114.626	0.604304
Sum256Base_Basic	2642.375	99.208	0.523019
Sum256Base	2726.826	96.135	0.506821
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3111.385	84.253	0.444179
Sum256Traits_ArgsT	3435.960	76.294	0.402220

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	2211.260	118.550
SumBase	2248.319	116.596	0.983517
SumTraits	2220.231	118.071	0.995959
SumTraits_Args	2259.398	116.024	0.978694
SumTraits_ArgsT	2420.781	108.289	0.913449
Sum128Base_Basic	2846.146	92.105	0.776931
Sum128Base	2797.273	93.714	0.790506
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2788.510	94.009	0.792990
Sum128Traits_ArgsT	3040.735	86.211	0.727212
Sum256Base_Basic	4225.261	62.042	0.523343
Sum256Base	4405.700	59.501	0.501909
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	5201.805	50.395	0.425095
Sum256Traits_ArgsT	5894.374	44.474	0.375148

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	714.299	366.995
SumBase	710.005	369.214	1.006048
SumTraits	712.069	368.144	1.003132
SumTraits_Args	717.462	365.377	0.995591
SumTraits_ArgsT	743.654	352.508	0.960526
Sum128Base_Basic	969.232	270.466	0.736974
Sum128Base	973.752	269.210	0.733554
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	976.342	268.496	0.731607
Sum128Traits_ArgsT	999.212	262.351	0.714863
Sum256Base_Basic	924.995	283.400	0.772219
Sum256Base	957.833	273.684	0.745745
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1067.817	245.495	0.668934
Sum256Traits_ArgsT	1168.344	224.372	0.611378

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	1151.068	227.740
SumBase	1134.643	231.036	1.014475
SumTraits	1129.305	232.129	1.019271
SumTraits_Args	1137.102	230.537	1.012282
SumTraits_ArgsT	1153.577	227.244	0.997825
Sum128Base_Basic	1487.649	176.214	0.773749
Sum128Base	1491.011	175.816	0.772005
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1488.791	176.078	0.773156
Sum128Traits_ArgsT	1541.894	170.014	0.746529
Sum256Base_Basic	1777.140	147.509	0.647708
Sum256Base	1860.400	140.907	0.618720
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2091.870	125.316	0.550258
Sum256Traits_ArgsT	2246.057	116.713	0.512484

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	1483.398	176.719
SumBase	1490.706	175.852	0.995097
SumTraits	1499.350	174.838	0.989361
SumTraits_Args	1539.686	170.258	0.963442
SumTraits_ArgsT	1636.193	160.216	0.906616
Sum128Base_Basic	2301.679	113.893	0.644485
Sum128Base	2286.971	114.625	0.648630
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2273.421	115.308	0.652496
Sum128Traits_ArgsT	2343.799	111.846	0.632903
Sum256Base_Basic	2924.576	89.635	0.507218
Sum256Base	3077.373	85.184	0.482034
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3522.722	74.415	0.421094
Sum256Traits_ArgsT	3830.406	68.438	0.387269

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	2459.580	106.581
SumBase	2450.606	106.971	1.003662
SumTraits	2479.655	105.718	0.991904
SumTraits_Args	2491.292	105.224	0.987271
SumTraits_ArgsT	2679.601	97.829	0.917890
Sum128Base_Basic	2973.642	88.156	0.827127
Sum128Base	2978.517	88.012	0.825773
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2984.735	87.828	0.824053
Sum128Traits_ArgsT	3192.813	82.104	0.770349
Sum256Base_Basic	4930.883	53.164	0.498811
Sum256Base	5164.439	50.759	0.476253
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	6060.181	43.257	0.405859
Sum256Traits_ArgsT	6690.140	39.184	0.367643

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	744.935	351.902
SumBase	744.008	352.340	1.001245
SumTraits	740.243	354.132	1.006338
SumTraits_Args	749.984	349.533	0.993268
SumTraits_ArgsT	770.747	340.117	0.966510
Sum128Base_Basic	1008.328	259.979	0.738783
Sum128Base	1016.673	257.845	0.732719
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1013.526	258.645	0.734993
Sum128Traits_ArgsT	1027.645	255.092	0.724895
Sum256Base_Basic	951.703	275.447	0.782739
Sum256Base	1008.955	259.817	0.738323
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1134.266	231.113	0.656755
Sum256Traits_ArgsT	1235.869	212.113	0.602762

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	1177.781	222.574
SumBase	1163.513	225.304	1.012263
SumTraits	1163.357	225.334	1.012399
SumTraits_Args	1165.175	224.983	1.010819
SumTraits_ArgsT	1227.430	213.571	0.959550
Sum128Base_Basic	1583.627	165.534	0.743724
Sum128Base	1587.302	165.151	0.742002
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1583.956	165.500	0.743569
Sum128Traits_ArgsT	1626.912	161.130	0.723937
Sum256Base_Basic	1945.613	134.736	0.605352
Sum256Base	2031.051	129.068	0.579888
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2289.060	114.520	0.514526
Sum256Traits_ArgsT	2515.408	104.215	0.468227

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	1630.491	160.776
SumBase	1614.816	162.337	1.009707
SumTraits	1585.537	165.335	1.028353
SumTraits_Args	1587.821	165.097	1.026873
SumTraits_ArgsT	1700.212	154.183	0.958993
Sum128Base_Basic	2465.566	106.322	0.661305
Sum128Base	2443.208	107.295	0.667357
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	2461.516	106.497	0.662393
Sum128Traits_ArgsT	2641.966	99.223	0.617151
Sum256Base_Basic	3238.173	80.954	0.503522
Sum256Base	3423.975	76.561	0.476198
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3941.175	66.514	0.413707
Sum256Traits_ArgsT	4353.090	60.220	0.374559

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	2830.731	92.606
SumBase	2816.832	93.063	1.004934
SumTraits	2847.055	92.075	0.994266
SumTraits_Args	2851.645	91.927	0.992666
SumTraits_ArgsT	3079.584	85.123	0.919193
Sum128Base_Basic	3327.631	78.778	0.850674
Sum128Base	3370.993	77.765	0.839732
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	3343.346	78.408	0.846676
Sum128Traits_ArgsT	3485.450	75.211	0.812157
Sum256Base_Basic	5522.003	47.473	0.512628
Sum256Base	5951.548	44.046	0.475629
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	6922.008	37.871	0.408946
Sum256Traits_ArgsT	7724.614	33.936	0.366456

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	684.922	382.735
SumBase	687.578	381.257	0.996138
SumTraits	30.632	8557.709	22.359337
SumTraits_Args	26.400	9929.816	25.944339
SumTraits_ArgsT	53.786	4873.877	12.734325
Sum128Base_Basic	951.793	275.421	0.719612
Sum128Base	949.494	276.088	0.721355
Sum128Arm	43.940	5965.898	15.587527
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	22.100	11861.620	30.991700
Sum128Traits_ArgsT	47.389	5531.700	14.453067
Sum256Base_Basic	882.036	297.203	0.776524
Sum256Base	930.968	281.582	0.735710
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	982.095	266.923	0.697409
Sum256Traits_ArgsT	1047.353	250.292	0.653956

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	1087.781	240.990
SumBase	1093.069	239.824	0.995162
SumTraits	81.642	3210.904	13.323827
SumTraits_Args	59.397	4413.405	18.313672
SumTraits_ArgsT	116.450	2251.130	9.341189
Sum128Base_Basic	1447.177	181.142	0.751657
Sum128Base	1439.478	182.110	0.755678
Sum128Arm	143.216	1830.404	7.595363
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	70.280	3729.980	15.477761
Sum128Traits_ArgsT	95.623	2741.429	11.375711
Sum256Base_Basic	1465.388	178.890	0.742316
Sum256Base	1486.516	176.348	0.731765
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1520.672	172.387	0.715329
Sum256Traits_ArgsT	1613.889	162.430	0.674013

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	1498.404	174.949
SumBase	1525.050	171.892	0.982528
SumTraits	145.912	1796.586	10.269208
SumTraits_Args	106.289	2466.335	14.097463
SumTraits_ArgsT	221.022	1186.055	6.779440
Sum128Base_Basic	2149.466	121.958	0.697105
Sum128Base	2145.321	122.193	0.698452
Sum128Arm	285.779	917.296	5.243226
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	125.266	2092.697	11.961766
Sum128Traits_ArgsT	192.022	1365.175	7.803278
Sum256Base_Basic	2301.723	113.890	0.650992
Sum256Base	2337.955	112.125	0.640904
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2346.059	111.738	0.638690
Sum256Traits_ArgsT	2625.863	99.832	0.570633

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	2515.861	104.197
SumBase	2578.394	101.670	0.975747
SumTraits	295.502	887.114	8.513847
SumTraits_Args	212.408	1234.155	11.844491
SumTraits_ArgsT	441.588	593.640	5.697305
Sum128Base_Basic	3014.773	86.953	0.834511
Sum128Base	2998.501	87.425	0.839040
Sum128Arm	589.938	444.359	4.264622
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	269.900	971.263	9.321454
Sum128Traits_ArgsT	383.349	683.826	6.562849
Sum256Base_Basic	3142.491	83.419	0.800594
Sum256Base	3171.414	82.658	0.793293
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3184.098	82.329	0.790133
Sum256Traits_ArgsT	3799.675	68.991	0.662125

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	715.490	366.384
SumBase	728.427	359.877	0.982239
SumTraits	39.573	6624.361	18.080374
SumTraits_Args	33.085	7923.366	21.625847
SumTraits_ArgsT	66.199	3959.946	10.808182
Sum128Base_Basic	990.782	264.583	0.722147
Sum128Base	990.034	264.783	0.722692
Sum128Arm	69.157	3790.584	10.345931
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	30.059	8720.995	23.802878
Sum128Traits_ArgsT	50.477	5193.383	14.174698
Sum256Base_Basic	929.492	282.029	0.769764
Sum256Base	996.009	263.194	0.718357
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1038.540	252.416	0.688938
Sum256Traits_ArgsT	1081.632	242.360	0.661491

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	1147.538	228.440
SumBase	1131.840	231.609	1.013869
SumTraits	96.719	2710.362	11.864636
SumTraits_Args	66.723	3928.863	17.198634
SumTraits_ArgsT	135.507	1934.546	8.468492
Sum128Base_Basic	1476.278	177.571	0.777318
Sum128Base	1489.696	175.971	0.770317
Sum128Arm	197.036	1330.437	5.824000
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	86.320	3036.889	13.294010
Sum128Traits_ArgsT	105.112	2493.940	10.917245
Sum256Base_Basic	1602.209	163.614	0.716222
Sum256Base	1560.146	168.025	0.735532
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1558.063	168.250	0.736516
Sum256Traits_ArgsT	1666.949	157.260	0.688406

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	1642.012	159.648
SumBase	1673.397	156.654	0.981245
SumTraits	207.350	1264.258	7.919031
SumTraits_Args	150.258	1744.623	10.927932
SumTraits_ArgsT	289.822	904.500	5.665587
Sum128Base_Basic	2303.735	113.791	0.712761
Sum128Base	2288.098	114.569	0.717632
Sum128Arm	429.081	610.943	3.826813
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	198.758	1318.912	8.261376
Sum128Traits_ArgsT	210.291	1246.575	7.808273
Sum256Base_Basic	2581.924	101.530	0.635965
Sum256Base	2502.803	104.740	0.656069
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2497.623	104.957	0.657430
Sum256Traits_ArgsT	2749.386	95.346	0.597229

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	2813.105	93.187
SumBase	2867.832	91.408	0.980917
SumTraits	400.012	655.340	7.032550
SumTraits_Args	267.750	979.062	10.506459
SumTraits_ArgsT	542.968	482.798	5.180978
Sum128Base_Basic	3206.925	81.743	0.877197
Sum128Base	3240.153	80.905	0.868201
Sum128Arm	878.726	298.323	3.201344
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	363.063	722.035	7.748257
Sum128Traits_ArgsT	420.123	623.970	6.695912
Sum256Base_Basic	3756.539	69.783	0.748856
Sum256Base	3775.607	69.431	0.745074
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3770.418	69.527	0.746099
Sum256Traits_ArgsT	4242.273	61.793	0.663113

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	753.160	348.059
SumBase	756.779	346.394	0.995218
SumTraits	46.981	5579.822	16.031253
SumTraits_Args	40.986	6395.898	18.375902
SumTraits_ArgsT	79.321	3304.861	9.495118
Sum128Base_Basic	1019.476	257.136	0.738771
Sum128Base	1020.051	256.991	0.738355
Sum128Arm	96.945	2704.058	7.768966
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	42.286	6199.346	17.811194
Sum128Traits_ArgsT	56.292	4656.861	13.379517
Sum256Base_Basic	993.702	263.806	0.757933
Sum256Base	1087.471	241.058	0.692579
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1119.171	234.230	0.672962
Sum256Traits_ArgsT	1161.333	225.727	0.648531

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	1173.655	223.357
SumBase	1166.599	224.708	1.006049
SumTraits	127.685	2053.060	9.191835
SumTraits_Args	82.285	3185.819	14.263353
SumTraits_ArgsT	162.288	1615.303	7.231935
Sum128Base_Basic	1578.058	166.118	0.743734
Sum128Base	1597.968	164.048	0.734467
Sum128Arm	254.045	1031.880	4.619868
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	129.322	2027.071	9.075478
Sum128Traits_ArgsT	116.303	2253.983	10.091397
Sum256Base_Basic	1733.417	151.230	0.677076
Sum256Base	1730.882	151.451	0.678068
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1762.743	148.714	0.665812
Sum256Traits_ArgsT	1844.367	142.132	0.636346

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	1857.458	141.131
SumBase	1864.228	140.618	0.996368
SumTraits	278.881	939.986	6.660402
SumTraits_Args	200.212	1309.331	9.277450
SumTraits_ArgsT	355.755	736.866	5.221167
Sum128Base_Basic	2445.753	107.183	0.759463
Sum128Base	2447.946	107.087	0.758782
Sum128Arm	598.471	438.023	3.103671
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	258.847	1012.739	7.175904
Sum128Traits_ArgsT	233.266	1123.800	7.962838
Sum256Base_Basic	2841.969	92.240	0.653581
Sum256Base	2874.599	91.193	0.646162
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2863.801	91.537	0.648599
Sum256Traits_ArgsT	3103.833	84.458	0.598440

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	3055.143	85.804
SumBase	3038.281	86.280	1.005550
SumTraits	532.906	491.914	5.732982
SumTraits_Args	336.988	777.903	9.066032
SumTraits_ArgsT	646.105	405.730	4.728557
Sum128Base_Basic	3465.323	75.648	0.881633
Sum128Base	3470.614	75.532	0.880289
Sum128Arm	1096.086	239.164	2.787321
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	470.435	557.237	6.494289
Sum128Traits_ArgsT	465.972	562.575	6.556498
Sum256Base_Basic	4453.639	58.861	0.685988
Sum256Base	4449.327	58.918	0.686653
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	4426.142	59.226	0.690250
Sum256Traits_ArgsT	4952.730	52.929	0.616860

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	697.414	375.880
SumBase	701.539	373.670	0.994120
SumTraits	26.604	9853.451	26.214332
SumTraits_Args	23.770	11028.413	29.340225
SumTraits_ArgsT	26.636	9841.672	26.182994
Sum128Base_Basic	693.132	378.202	1.006177
Sum128Base	694.195	377.623	1.004636
Sum128Arm	42.536	6162.826	16.395714
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	19.293	13587.421	36.148265
Sum128Traits_ArgsT	20.046	13077.264	34.791032
Sum256Base_Basic	1032.977	253.775	0.675149
Sum256Base	1034.131	253.492	0.674396
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1036.455	252.924	0.672883
Sum256Traits_ArgsT	1057.144	247.974	0.659715

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	1019.687	257.083
SumBase	1012.943	258.794	1.006658
SumTraits	61.992	4228.682	16.448719
SumTraits_Args	52.717	4972.675	19.342701
SumTraits_ArgsT	52.789	4965.893	19.316320
Sum128Base_Basic	990.959	264.536	1.028990
Sum128Base	987.122	265.564	1.032990
Sum128Arm	149.115	1757.996	6.838248
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	57.171	4585.275	17.835793
Sum128Traits_ArgsT	36.527	7176.723	27.916000
Sum256Base_Basic	1388.828	188.752	0.734207
Sum256Base	1397.370	187.598	0.729719
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1396.130	187.765	0.730367
Sum256Traits_ArgsT	1424.470	184.029	0.715836

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	1495.726	175.262
SumBase	1489.993	175.936	1.003848
SumTraits	123.558	2121.620	12.105411
SumTraits_Args	105.799	2477.755	14.137429
SumTraits_ArgsT	105.848	2476.604	14.130857
Sum128Base_Basic	1476.549	177.538	1.012988
Sum128Base	1466.868	178.710	1.019673
Sum128Arm	297.706	880.547	5.024173
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	114.349	2292.488	13.080342
Sum128Traits_ArgsT	73.161	3583.108	20.444283
Sum256Base_Basic	1849.526	141.736	0.808707
Sum256Base	1872.260	140.015	0.798888
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1872.548	139.993	0.798765
Sum256Traits_ArgsT	2017.849	129.913	0.741248

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	2601.564	100.764
SumBase	2582.819	101.495	1.007258
SumTraits	265.660	986.764	9.792827
SumTraits_Args	186.605	1404.804	13.941530
SumTraits_ArgsT	211.481	1239.561	12.301630
Sum128Base_Basic	2541.486	103.146	1.023639
Sum128Base	2555.126	102.595	1.018175
Sum128Arm	609.939	429.787	4.265283
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	246.984	1061.381	10.533332
Sum128Traits_ArgsT	146.236	1792.615	17.790232
Sum256Base_Basic	2870.429	91.326	0.906333
Sum256Base	2873.591	91.225	0.905336
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2871.613	91.288	0.905959
Sum256Traits_ArgsT	2953.226	88.765	0.880923

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	719.426	364.379
SumBase	722.067	363.047	0.996342
SumTraits	37.345	7019.432	19.264078
SumTraits_Args	31.024	8449.775	23.189501
SumTraits_ArgsT	35.673	7348.598	20.167438
Sum128Base_Basic	718.572	364.812	1.001189
Sum128Base	720.291	363.942	0.998799
Sum128Arm	66.334	3951.851	10.845431
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	29.933	8757.629	24.034373
Sum128Traits_ArgsT	24.368	10757.624	29.523144
Sum256Base_Basic	1086.697	241.230	0.662030
Sum256Base	1089.713	240.562	0.660198
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1090.377	240.416	0.659796
Sum256Traits_ArgsT	1113.534	235.416	0.646075

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	1081.496	242.390
SumBase	1080.336	242.650	1.001073
SumTraits	87.811	2985.313	12.316142
SumTraits_Args	61.288	4277.223	17.646016
SumTraits_ArgsT	70.695	3708.104	15.298070
Sum128Base_Basic	1083.815	241.872	0.997860
Sum128Base	1087.192	241.120	0.994760
Sum128Arm	195.963	1337.721	5.518874
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	84.063	3118.418	12.865277
Sum128Traits_ArgsT	52.747	4969.803	20.503311
Sum256Base_Basic	1488.811	176.076	0.726415
Sum256Base	1494.169	175.445	0.723811
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1496.565	175.164	0.722652
Sum256Traits_ArgsT	1548.411	169.299	0.698455

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	1623.002	161.518
SumBase	1608.522	162.972	1.009002
SumTraits	179.037	1464.187	9.065162
SumTraits_Args	123.301	2126.057	13.162975
SumTraits_ArgsT	141.542	1852.061	11.466593
Sum128Base_Basic	1610.420	162.780	1.007813
Sum128Base	1612.899	162.530	1.006264
Sum128Arm	392.209	668.379	4.138106
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	168.549	1555.300	9.629269
Sum128Traits_ArgsT	105.684	2480.452	15.357125
Sum256Base_Basic	2058.143	127.369	0.788576
Sum256Base	2075.972	126.275	0.781803
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2070.465	126.611	0.783883
Sum256Traits_ArgsT	2180.726	120.210	0.744249

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	3036.582	86.329
SumBase	3028.951	86.546	1.002520
SumTraits	381.314	687.476	7.963475
SumTraits_Args	249.705	1049.816	12.160692
SumTraits_ArgsT	283.346	925.172	10.716866
Sum128Base_Basic	2945.888	88.986	1.030787
Sum128Base	2940.216	89.158	1.032775
Sum128Arm	815.141	321.593	3.725222
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	359.867	728.447	8.438070
Sum128Traits_ArgsT	186.087	1408.715	16.318047
Sum256Base_Basic	3278.970	79.947	0.926078
Sum256Base	3305.982	79.294	0.918512
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3299.691	79.445	0.920263
Sum256Traits_ArgsT	3500.215	74.894	0.867542

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
SumBase_Basic	751.120	349.004
SumBase	752.681	348.280	0.997926
SumTraits	49.227	5325.211	15.258301
SumTraits_Args	38.806	6755.285	19.355885
SumTraits_ArgsT	46.745	5607.999	16.068572
Sum128Base_Basic	741.132	353.708	1.013477
Sum128Base	746.449	351.188	1.006258
Sum128Arm	92.920	2821.190	8.083543
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	40.704	6440.299	18.453358
Sum128Traits_ArgsT	31.024	8449.667	24.210790
Sum256Base_Basic	1121.702	233.702	0.669625
Sum256Base	1126.261	232.756	0.666915
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1125.378	232.939	0.667438
Sum256Traits_ArgsT	1148.754	228.199	0.653856

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
SumBase_Basic	1147.106	228.526
SumBase	1136.129	230.734	1.009662
SumTraits	117.220	2236.339	9.785915
SumTraits_Args	76.176	3441.293	15.058631
SumTraits_ArgsT	91.693	2858.918	12.510235
Sum128Base_Basic	1120.608	233.930	1.023646
Sum128Base	1117.132	234.658	1.026831
Sum128Arm	274.882	953.661	4.173089
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	112.042	2339.704	10.238224
Sum128Traits_ArgsT	61.294	4276.815	18.714759
Sum256Base_Basic	1582.223	165.681	0.724997
Sum256Base	1579.436	165.973	0.726276
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1584.752	165.416	0.723840
Sum256Traits_ArgsT	1641.904	159.659	0.698644

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
SumBase_Basic	1856.852	141.177
SumBase	1812.034	144.668	1.024734
SumTraits	235.932	1111.099	7.870282
SumTraits_Args	155.172	1689.377	11.966412
SumTraits_ArgsT	184.720	1419.144	10.052265
Sum128Base_Basic	1747.444	150.016	1.062611
Sum128Base	1752.972	149.543	1.059260
Sum128Arm	543.567	482.266	3.416048
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	228.468	1147.402	8.127422
Sum128Traits_ArgsT	128.476	2040.408	14.452879
Sum256Base_Basic	2233.337	117.378	0.831425
Sum256Base	2235.282	117.276	0.830702
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2232.253	117.435	0.831829
Sum256Traits_ArgsT	2447.435	107.110	0.758693

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
SumBase_Basic	3327.450	78.782
SumBase	3327.877	78.772	0.999872
SumTraits	495.847	528.679	6.710637
SumTraits_Args	306.928	854.090	10.841142
SumTraits_ArgsT	372.806	703.165	8.925419
Sum128Base_Basic	3187.858	82.232	1.043789
Sum128Base	3191.993	82.126	1.042437
Sum128Arm	1160.976	225.796	2.866079
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	463.010	566.174	7.186564
Sum128Traits_ArgsT	245.531	1067.663	13.552074
Sum256Base_Basic	3592.767	72.964	0.926153
Sum256Base	3601.516	72.787	0.923903
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	3599.257	72.833	0.924483
Sum256Traits_ArgsT	3845.347	68.172	0.865319

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	554.299	472.929
SumBase	554.140	473.065	1.000287
SumTraits	13.255	19777.508	41.819218
SumTraits_Args	13.222	19826.109	41.921985
SumTraits_ArgsT	13.223	19825.366	41.920414
Sum128Base_Basic	554.388	472.853	0.999841
Sum128Base	554.281	472.944	1.000033
Sum128Arm	20.842	12577.890	26.595744
Sum128Arm_Combine	36.624	7157.759	15.134965
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	13.231	19813.211	41.894712
Sum128Traits_ArgsT	13.235	19807.383	41.882388
Sum256Base_Basic	497.183	527.258	1.114879
Sum256Base	497.315	527.119	1.114584
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	497.215	527.224	1.114807
Sum256Traits_ArgsT	497.078	527.370	1.115115
Sum512Base_Basic	503.995	520.132	1.099811
Sum512Base	504.277	519.842	1.099197
Sum512Traits	504.311	519.806	1.099122
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	702.847	372.974
SumBase	704.815	371.933	0.997208
SumTraits	26.933	9733.244	26.096285
SumTraits_Args	26.923	9736.750	26.105685
SumTraits_ArgsT	26.930	9734.258	26.099003
Sum128Base_Basic	702.865	372.965	0.999975
Sum128Base	704.049	372.338	0.998293
Sum128Arm	61.306	4275.993	11.464577
Sum128Arm_Combine	98.267	2667.662	7.152400
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	26.882	9751.556	26.145382
Sum128Traits_ArgsT	26.850	9763.374	26.177068
Sum256Base_Basic	586.379	447.055	1.198623
Sum256Base	588.837	445.189	1.193619
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	588.315	445.584	1.194678
Sum256Traits_ArgsT	586.055	447.302	1.199285
Sum512Base_Basic	599.890	436.986	1.171626
Sum512Base	600.112	436.825	1.171194
Sum512Traits	600.190	436.768	1.171041
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	919.759	285.014
SumBase	920.142	284.895	0.999584
SumTraits	54.820	4781.900	16.777784
SumTraits_Args	54.692	4793.132	16.817190
SumTraits_ArgsT	54.602	4801.014	16.844846
Sum128Base_Basic	919.611	285.060	1.000161
Sum128Base	920.013	284.935	0.999724
Sum128Arm	122.958	2131.975	7.480249
Sum128Arm_Combine	197.617	1326.527	4.654256
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	54.670	4795.014	16.823794
Sum128Traits_ArgsT	55.127	4755.291	16.684422
Sum256Base_Basic	677.164	387.120	1.358251
Sum256Base	678.785	386.196	1.355008
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	677.376	386.999	1.357827
Sum256Traits_ArgsT	682.138	384.298	1.348347
Sum512Base_Basic	739.695	354.395	1.243430
Sum512Base	740.820	353.857	1.241542
Sum512Traits	740.769	353.881	1.241628
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	925.646	283.201
SumBase	926.190	283.035	0.999413
SumTraits	109.785	2387.789	8.431423
SumTraits_Args	108.153	2423.836	8.558706
SumTraits_ArgsT	108.274	2421.120	8.549117
Sum128Base_Basic	929.824	281.929	0.995506
Sum128Base	930.079	281.851	0.995234
Sum128Arm	245.550	1067.580	3.769689
Sum128Arm_Combine	396.870	660.528	2.332364
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	108.090	2425.242	8.563672
Sum128Traits_ArgsT	108.058	2425.949	8.566169
Sum256Base_Basic	678.967	386.092	1.363314
Sum256Base	677.568	386.889	1.366129
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	677.540	386.905	1.366186
Sum256Traits_ArgsT	670.925	390.720	1.379656
Sum512Base_Basic	1017.446	257.649	0.909774
Sum512Base	1016.371	257.921	0.910736
Sum512Traits	1017.043	257.751	0.910135
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	566.160	463.021
SumBase	567.983	461.535	0.996790
SumTraits	16.665	15729.903	33.972335
SumTraits_Args	16.665	15730.552	33.973735
SumTraits_ArgsT	16.682	15714.119	33.938245
Sum128Base_Basic	567.475	461.948	0.997682
Sum128Base	567.662	461.796	0.997354
Sum128Arm	29.882	8772.532	18.946294
Sum128Arm_Combine	62.219	4213.244	9.099466
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Traits	16.659	15736.174	33.985877
Sum128Traits_ArgsT	16.669	15726.714	33.965447
Sum256Base_Basic	500.705	523.550	1.130726
Sum256Base	501.016	523.224	1.130023
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi!
Sum256Traits	500.729	523.525	1.130671
Sum256Traits_ArgsT	503.941	520.188	1.123465
Sum512Base_Basic	526.734	497.678	1.074850
Sum512Base	526.765	497.649	1.074787
Sum512Traits	526.760	497.654	1.074798
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	739.315	354.577
SumBase	739.682	354.401	0.999504
SumTraits	34.494	7599.716	21.433198
SumTraits_Args	34.598	7576.787	21.368532
SumTraits_ArgsT	34.455	7608.203	21.457132
Sum128Base_Basic	739.362	354.554	0.999937
Sum128Base	740.340	354.086	0.998616
Sum128Arm	76.793	3413.637	9.627354
Sum128Arm_Combine	150.992	1736.140	4.896372
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Traits	33.922	7727.751	21.794289
Sum128Traits_ArgsT	33.878	7737.969	21.823107
Sum256Base_Basic	598.225	438.203	1.235847
Sum256Base	598.955	437.669	1.234342
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512BW!
Sum256Traits	598.929	437.688	1.234396
Sum256Traits_ArgsT	598.152	438.256	1.235998
Sum512Base_Basic	653.943	400.867	1.130550
Sum512Base	654.198	400.710	1.130109
Sum512Traits	654.293	400.652	1.129945
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	999.289	262.331
SumBase	1000.057	262.129	0.999232
SumTraits	68.701	3815.715	14.545445
SumTraits_Args	69.003	3799.010	14.481768
SumTraits_ArgsT	68.808	3809.804	14.522912
Sum128Base_Basic	999.291	262.330	0.999998
Sum128Base	1000.200	262.092	0.999089
Sum128Arm	151.783	1727.097	6.583666
Sum128Arm_Combine	305.960	856.791	3.266074
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Traits	68.650	3818.549	14.556250
Sum128Traits_ArgsT	68.571	3822.945	14.573007
Sum256Base_Basic	700.851	374.037	1.425821
Sum256Base	703.884	372.425	1.419677
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	702.029	373.409	1.423430
Sum256Traits_ArgsT	713.067	367.629	1.401395
Sum512Base_Basic	844.568	310.388	1.183195
Sum512Base	844.732	310.328	1.182966
Sum512Traits	845.325	310.110	1.182135
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	985.765	265.930
SumBase	985.883	265.898	0.999881
SumTraits	138.291	1895.599	7.128198
SumTraits_Args	137.290	1909.419	7.180170
SumTraits_ArgsT	138.101	1898.203	7.137994
Sum128Base_Basic	993.157	263.950	0.992556
Sum128Base	985.202	266.081	1.000571
Sum128Arm	304.060	862.145	3.242006
Sum128Arm_Combine	606.012	432.572	1.626641
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum128Traits	137.388	1908.051	7.175025
Sum128Traits_ArgsT	138.121	1897.934	7.136982
Sum256Base_Basic	748.337	350.302	1.317273
Sum256Base	745.725	351.529	1.321887
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	740.896	353.820	1.330503
Sum256Traits_ArgsT	744.907	351.915	1.323339
Sum512Base_Basic	1252.588	209.282	0.786983
Sum512Base	1252.592	209.281	0.786980
Sum512Traits	1252.647	209.272	0.786945
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	573.339	457.224
SumBase	573.500	457.095	0.999719
SumTraits	23.128	11334.310	24.789427
SumTraits_Args	23.125	11336.194	24.793549
SumTraits_ArgsT	23.126	11335.291	24.791574
Sum128Base_Basic	577.984	453.549	0.991963
Sum128Base	576.671	454.582	0.994222
Sum128Arm	39.568	6625.167	14.489994
Sum128Arm_Combine	84.600	3098.624	6.777044
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Traits	23.129	11333.914	24.788562
Sum128Traits_ArgsT	23.133	11331.906	24.784170
Sum256Base_Basic	479.123	547.133	1.196642
Sum256Base	479.192	547.054	1.196469
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi!
Sum256Traits	479.201	547.043	1.196446
Sum256Traits_ArgsT	492.571	532.195	1.163971
Sum512Base_Basic	556.570	470.999	1.030128
Sum512Base	556.361	471.176	1.030515
Sum512Traits	556.481	471.074	1.030293
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	752.719	348.263
SumBase	752.723	348.261	0.999994
SumTraits	46.437	5645.131	16.209392
SumTraits_Args	46.451	5643.424	16.204490
SumTraits_ArgsT	46.440	5644.834	16.208538
Sum128Base_Basic	753.944	347.697	0.998374
Sum128Base	754.760	347.321	0.997296
Sum128Arm	87.016	3012.599	8.650356
Sum128Arm_Combine	203.493	1288.223	3.698994
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Traits	46.472	5640.886	16.197202
Sum128Traits_ArgsT	46.474	5640.599	16.196377
Sum256Base_Basic	567.916	461.590	1.325405
Sum256Base	568.126	461.419	1.324915
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512BW!
Sum256Traits	567.967	461.548	1.325287
Sum256Traits_ArgsT	582.017	450.406	1.293293
Sum512Base_Basic	704.567	372.064	1.068342
Sum512Base	704.754	371.965	1.068058
Sum512Traits	705.323	371.665	1.067196
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	1022.821	256.295
SumBase	1021.724	256.570	1.001074
SumTraits	93.211	2812.365	10.973155
SumTraits_Args	93.131	2814.789	10.982615
SumTraits_ArgsT	93.293	2809.911	10.963580
Sum128Base_Basic	1022.048	256.489	1.000756
Sum128Base	1021.721	256.571	1.001077
Sum128Arm	177.557	1476.396	5.760533
Sum128Arm_Combine	402.170	651.824	2.543258
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Traits	93.177	2813.408	10.977226
Sum128Traits_ArgsT	93.198	2812.774	10.974749
Sum256Base_Basic	628.579	417.042	1.627196
Sum256Base	628.196	417.296	1.628187
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	628.191	417.300	1.628201
Sum256Traits_ArgsT	667.106	392.957	1.533221
Sum512Base_Basic	963.358	272.115	1.061725
Sum512Base	964.022	271.927	1.060993
Sum512Traits	964.003	271.933	1.061015
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	1061.508	246.954
SumBase	1059.269	247.476	1.002114
SumTraits	186.020	1409.227	5.706429
SumTraits_Args	186.037	1409.096	5.705898
SumTraits_ArgsT	186.090	1408.695	5.704276
Sum128Base_Basic	1075.163	243.818	0.987300
Sum128Base	1074.580	243.950	0.987835
Sum128Arm	355.334	737.740	2.987354
Sum128Arm_Combine	813.174	322.371	1.305389
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Traits	186.166	1408.116	5.701932
Sum128Traits_ArgsT	186.122	1408.456	5.703307
Sum256Base_Basic	854.964	306.614	1.241582
Sum256Base	854.741	306.694	1.241906
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	854.538	306.767	1.242201
Sum256Traits_ArgsT	881.804	297.281	1.203792
Sum512Base_Basic	1463.198	179.158	0.725471
Sum512Base	1463.002	179.182	0.725569
Sum512Traits	1469.863	178.346	0.722182
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

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


[YShuffleX2KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	20350.000	12.882
SumBase	20716.667	12.654	0.982301
SumTraits	2159.245	121.405	9.424591
SumTraits_Args	2432.292	107.777	8.366595
SumTraits_ArgsT	3401.302	77.072	5.983003
Sum128Base_Basic	20429.167	12.832	0.996125
Sum128Base	2839.583	92.318	7.166544
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	1641.016	159.745	12.400857
Sum128Traits_ArgsT	2720.833	96.347	7.479326
Sum256Base_Basic	18091.667	14.490	1.124827
Sum256Base	17856.250	14.681	1.139657
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine2	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Combine3	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	18660.417	14.048	1.090544
Sum256Traits_ArgsT	19668.750	13.328	1.034636
Sum512Base_Basic	15910.417	16.476	1.279036
Sum512Base	15750.000	16.644	1.292063
Sum512Traits	16604.167	15.788	1.225596
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	28425.000	9.222
SumBase	46633.333	5.621	0.609543
SumTraits	8729.167	30.031	3.256325
SumTraits_Args	7586.458	34.554	3.746808
SumTraits_ArgsT	9760.417	26.858	2.912273
Sum128Base_Basic	45729.167	5.733	0.621595
Sum128Base	7518.229	34.868	3.780811
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	7202.604	36.396	3.946489
Sum128Traits_ArgsT	8960.417	29.256	3.172286
Sum256Base_Basic	37404.167	7.008	0.759942
Sum256Base	39283.333	6.673	0.723589
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	42400.000	6.183	0.670401
Sum256Traits_ArgsT	44333.333	5.913	0.641165
Sum512Base_Basic	33637.500	7.793	0.845039
Sum512Base	33760.417	7.765	0.841962
Sum512Traits	36900.000	7.104	0.770325
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	68625.000	3.820
SumBase	70650.000	3.710	0.971338
SumTraits	18239.583	14.372	3.762421
SumTraits_Args	15730.208	16.665	4.362625
SumTraits_ArgsT	20552.083	12.755	3.339078
Sum128Base_Basic	69591.667	3.767	0.986109
Sum128Base	12136.458	21.600	5.654450
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	14051.042	18.657	4.883980
Sum128Traits_ArgsT	16758.333	15.643	4.094978
Sum256Base_Basic	58762.500	4.461	1.167837
Sum256Base	57558.333	4.554	1.192269
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	64016.667	4.095	1.071986
Sum256Traits_ArgsT	70241.667	3.732	0.976984
Sum512Base_Basic	47587.500	5.509	1.442080
Sum512Base	48304.167	5.427	1.420685
Sum512Traits	51408.333	5.099	1.334900
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX2KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	160016.667	1.638
SumBase	153716.666	1.705	1.040984
SumTraits	70716.667	3.707	2.262786
SumTraits_Args	60604.167	4.326	2.640358
SumTraits_ArgsT	71525.000	3.665	2.237213
Sum128Base_Basic	200800.000	1.305	0.796896
Sum128Base	209816.666	1.249	0.762650
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Traits	37108.333	7.064	4.312149
Sum128Traits_ArgsT	32570.833	8.048	4.912882
Sum256Base_Basic	172650.000	1.518	0.926827
Sum256Base	183833.333	1.426	0.870444
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	127983.333	2.048	1.250293
Sum256Traits_ArgsT	134866.667	1.944	1.186480
Sum512Base_Basic	156683.333	1.673	1.021274
Sum512Base	159866.667	1.640	1.000938
Sum512Traits	92675.000	2.829	1.726643
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	33229.167	7.889
SumBase	32829.167	7.985	1.012184
SumTraits	4748.438	55.206	6.997916
SumTraits_Args	5442.188	48.169	6.105847
SumTraits_ArgsT	6136.458	42.719	5.415040
Sum128Base_Basic	33341.667	7.862	0.996626
Sum128Base	6119.792	42.835	5.429787
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Traits	3321.094	78.933	10.005489
Sum128Traits_ArgsT	4742.187	55.279	7.007139
Sum256Base_Basic	28150.000	9.312	1.180432
Sum256Base	28908.333	9.068	1.149467
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi!
Sum256Traits	29935.417	8.757	1.110029
Sum256Traits_ArgsT	30737.500	8.528	1.081063
Sum512Base_Basic	25364.583	10.335	1.310062
Sum512Base	26902.083	9.744	1.235189
Sum512Traits	26991.667	9.712	1.231090
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	47241.667	5.549
SumBase	47745.833	5.490	0.989441
SumTraits	12161.458	21.555	3.884540
SumTraits_Args	11176.042	23.456	4.227048
SumTraits_ArgsT	12459.375	21.040	3.791656
Sum128Base_Basic	47954.167	5.467	0.985142
Sum128Base	9883.333	26.524	4.779933
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Traits	8922.917	29.379	5.294420
Sum128Traits_ArgsT	9367.708	27.984	5.043033
Sum256Base_Basic	39020.833	6.718	1.210678
Sum256Base	40062.500	6.543	1.179199
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512BW!
Sum256Traits	43937.500	5.966	1.075202
Sum256Traits_ArgsT	47808.333	5.483	0.988147
Sum512Base_Basic	34808.333	7.531	1.357194
Sum512Base	35258.333	7.435	1.339872
Sum512Traits	34270.833	7.649	1.378480
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	74675.000	3.510
SumBase	76908.333	3.409	0.970961
SumTraits	22468.750	11.667	3.323505
SumTraits_Args	23066.667	11.365	3.237355
SumTraits_ArgsT	26108.333	10.041	2.860198
Sum128Base_Basic	77166.667	3.397	0.967711
Sum128Base	18668.750	14.042	4.000000
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Traits	19066.667	13.749	3.916521
Sum128Traits_ArgsT	18727.083	13.998	3.987540
Sum256Base_Basic	57650.000	4.547	1.295317
Sum256Base	61262.500	4.279	1.218935
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	70058.333	3.742	1.065897
Sum256Traits_ArgsT	75133.333	3.489	0.993900
Sum512Base_Basic	49787.500	5.265	1.499874
Sum512Base	52050.000	5.036	1.434678
Sum512Traits	54133.333	4.843	1.379464
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX3KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	103950.000	2.522
SumBase	101916.667	2.572	1.019951
SumTraits	55445.833	4.728	1.874803
SumTraits_Args	46679.167	5.616	2.226904
SumTraits_ArgsT	48575.000	5.397	2.139990
Sum128Base_Basic	134566.667	1.948	0.772480
Sum128Base	183816.667	1.426	0.565509
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum128Traits	25862.500	10.136	4.019333
Sum128Traits_ArgsT	22566.667	11.616	4.606352
Sum256Base_Basic	115633.333	2.267	0.898962
Sum256Base	114983.333	2.280	0.904044
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	87083.333	3.010	1.193684
Sum256Traits_ArgsT	95308.333	2.750	1.090671
Sum512Base_Basic	100633.333	2.605	1.032958
Sum512Base	101808.333	2.575	1.021036
Sum512Traits	60975.000	4.299	1.704797
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	85
# Sum128Base_Basic	85
# Sum256Base_Basic	181
# Sum512Base_Basic	55
SumBase_Basic	21447.917	12.222
SumBase	21925.000	11.956	0.978240
SumTraits	4241.667	61.802	5.056483
SumTraits_Args	4528.125	57.892	4.736600
SumTraits_ArgsT	4438.542	59.061	4.832199
Sum128Base_Basic	21912.500	11.963	0.978798
Sum128Base	5314.583	49.325	4.035672
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum128Traits	2986.198	87.785	7.182349
Sum128Traits_ArgsT	3283.854	79.828	6.531324
Sum256Base_Basic	18558.333	14.125	1.155703
Sum256Base	19010.417	13.789	1.128219
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512Vbmi, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512Vbmi!
Sum256Traits	19731.250	13.286	1.087002
Sum256Traits_ArgsT	21741.667	12.057	0.986489
Sum512Base_Basic	16735.417	15.664	1.281588
Sum512Base	16058.333	16.324	1.335625
Sum512Traits	16279.167	16.103	1.317507
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-19913
# Sum128Base_Basic	-19913
# Sum256Base_Basic	15615
# Sum512Base_Basic	3939
SumBase_Basic	30481.250	8.600
SumBase	31520.833	8.317	0.967019
SumTraits	8794.792	29.807	3.465830
SumTraits_Args	8780.208	29.856	3.471586
SumTraits_ArgsT	8883.333	29.510	3.431285
Sum128Base_Basic	30925.000	8.477	0.985651
Sum128Base	7488.021	35.008	4.070668
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum128Traits	7887.500	33.235	3.864501
Sum128Traits_ArgsT	6671.875	39.291	4.568618
Sum256Base_Basic	26131.250	10.032	1.166467
Sum256Base	25027.083	10.474	1.217931
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512BW, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512BW!
Sum256Traits	29547.917	8.872	1.031587
Sum256Traits_ArgsT	30829.167	8.503	0.988715
Sum512Base_Basic	21158.333	12.390	1.440626
Sum512Base	20885.417	12.552	1.459451
Sum512Traits	22795.833	11.500	1.337141
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	21672503
# Sum128Base_Basic	21672503
# Sum256Base_Basic	-1828360657
# Sum512Base_Basic	9831090
SumBase_Basic	48225.000	5.436
SumBase	49837.500	5.260	0.967645
SumTraits	19166.667	13.677	2.516087
SumTraits_Args	17725.000	14.790	2.720733
SumTraits_ArgsT	17881.250	14.660	2.696959
Sum128Base_Basic	49283.333	5.319	0.978526
Sum128Base	12444.792	21.065	3.875115
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Traits	16177.083	16.205	2.981069
Sum128Traits_ArgsT	13864.583	18.907	3.478287
Sum256Base_Basic	38275.000	6.849	1.259961
Sum256Base	38562.500	6.798	1.250567
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	46733.333	5.609	1.031919
Sum256Traits_ArgsT	49579.167	5.287	0.972687
Sum512Base_Basic	31318.750	8.370	1.539812
Sum512Base	31083.333	8.434	1.551475
Sum512Traits	35050.000	7.479	1.375892
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

[YShuffleX4KernelBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	31817777635448578
# Sum128Base_Basic	31817777635448578
# Sum256Base_Basic	-8262573497229888518
# Sum512Base_Basic	6629920282351138082
SumBase_Basic	110525.000	2.372
SumBase	107783.333	2.432	1.025437
SumTraits	59245.833	4.425	1.865532
SumTraits_Args	56662.500	4.626	1.950585
SumTraits_ArgsT	55420.833	4.730	1.994286
Sum128Base_Basic	135816.667	1.930	0.813781
Sum128Base	248200.000	1.056	0.445306
Sum128Arm	Run fail! Requires hardware support AdvSimd!
Sum128Arm_Combine	Run fail! Requires hardware support AdvSimd!
Sum128Sse_Combine	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_CombineAvx	Run fail! Requires hardware support Sse, Sse2!
Sum128Sse_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Sse_PermuteLonger	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum128Traits	32850.000	7.980	3.364536
Sum128Traits_ArgsT	26435.417	9.916	4.180944
Sum256Base_Basic	119533.334	2.193	0.924637
Sum256Base	121200.000	2.163	0.911922
Sum256Avx2_Combine	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Permute	Run fail! Requires hardware support Avx512F, Avx512VL!
Sum256Avx2_PermuteLonger	Run fail! Requires hardware support Avx512F!
Sum256Traits	92933.333	2.821	1.189293
Sum256Traits_ArgsT	97116.667	2.699	1.138064
Sum512Base_Basic	104425.000	2.510	1.058415
Sum512Base	103550.000	2.532	1.067359
Sum512Traits	62250.000	4.211	1.775502
Sum512Traits_ArgsT	Run fail! No hardware acceleration!

```

