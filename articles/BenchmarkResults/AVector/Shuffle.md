# Benchmark - Shuffle
([← Back](README.md))

See [Group](Shuffle_Group.md)

- `Shuffle[/_Args/_Core]`①: Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<Count)?( vector[indices[i]] ):0`.
- `YShuffleInsert[/_Args/_Core]`: Shuffle and insert (换位并插入). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
  Mnemonic: `rt[i] := (0<=indices[i] && indices[i]<Count)?( vector[indices[i]] ):back[i]`.
- `YShuffleKernel[/_Args/_Core]`: Only shuffle (仅换位). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the IndexMask mask to constrain the parameters (可使用 IndexMask 掩码来约束参数).
  Mnemonic: `rt[i] := vector[indices[i]]`. Conditions: `0<=indices[i] && indices[i]<Count`.

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	211.929	1236.944
SumBase	206.352	1270.376	1.027028
SumTraits	214.688	1221.046	0.987148
SumTraits_Args0	205.016	1278.650	1.033718
SumTraits_Args	208.861	1255.109	1.014686
SumKernelTraits	206.456	1269.733	1.026509
SumKernelTraits_Args0	201.997	1297.765	1.049170
SumKernelTraits_Args	206.274	1270.852	1.027413

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	308.384	850.057
SumBase	316.213	829.011	0.975242
SumTraits	319.145	821.394	0.966281
SumTraits_Args0	303.250	864.447	1.016929
SumTraits_Args	323.568	810.166	0.953073
SumKernelTraits	317.463	825.747	0.971402
SumKernelTraits_Args0	306.238	856.015	1.007009
SumKernelTraits_Args	325.047	806.479	0.948735

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	616.123	425.474
SumBase	559.586	468.461	1.101033
SumTraits	551.992	474.906	1.116181
SumTraits_Args0	618.697	423.703	0.995839
SumTraits_Args	587.425	446.260	1.048854
SumKernelTraits	553.253	473.823	1.113636
SumKernelTraits_Args0	617.524	424.508	0.997730
SumKernelTraits_Args	587.638	446.097	1.048472

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	175.138	1496.783
SumBase	170.446	1537.986	1.027528
SumTraits	177.512	1476.771	0.986630
SumTraits_Args0	188.301	1392.158	0.930100
SumTraits_Args	188.718	1389.074	0.928040
SumKernelTraits	177.528	1476.637	0.986540
SumKernelTraits_Args0	172.062	1523.543	1.017879
SumKernelTraits_Args	187.903	1395.106	0.932070

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	207.408	1263.908
SumBase	216.864	1208.793	0.956393
SumTraits	208.823	1255.341	0.993222
SumTraits_Args0	216.405	1211.361	0.958425
SumTraits_Args	227.004	1154.801	0.913675
SumKernelTraits	219.905	1192.079	0.943170
SumKernelTraits_Args0	218.509	1199.697	0.949196
SumKernelTraits_Args	229.370	1142.885	0.904247

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	315.919	829.782
SumBase	314.959	832.311	1.003047
SumTraits	310.454	844.388	1.017602
SumTraits_Args0	320.453	818.042	0.985851
SumTraits_Args	343.938	762.183	0.918534
SumKernelTraits	311.620	841.229	1.013794
SumKernelTraits_Args0	322.022	814.055	0.981046
SumKernelTraits_Args	342.574	765.218	0.922191

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	609.331	430.216
SumBase	611.807	428.475	0.995953
SumTraits	607.806	431.296	1.002510
SumTraits_Args0	567.825	461.664	1.073097
SumTraits_Args	622.781	420.925	0.978403
SumKernelTraits	615.244	426.081	0.990389
SumKernelTraits_Args0	572.057	458.248	1.065158
SumKernelTraits_Args	611.717	428.538	0.996100

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	186.799	1403.348
SumBase	173.211	1513.440	1.078449
SumTraits	175.448	1494.144	1.064700
SumTraits_Args0	196.940	1331.083	0.948505
SumTraits_Args	202.328	1295.641	0.923250
SumKernelTraits	211.032	1242.198	0.885168
SumKernelTraits_Args0	182.043	1440.011	1.026126
SumKernelTraits_Args	205.612	1274.943	0.908501

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	215.848	1214.484
SumBase	214.636	1221.340	1.005645
SumTraits	32.494	8067.493	6.642731
SumTraits_Args0	11.568	22661.648	18.659479
SumTraits_Args	11.442	22911.649	18.865329
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	31.009	8453.891	6.960889
SumKernelTraits	30.138	8698.117	7.161983
SumKernelTraits_Args0	11.383	23028.564	18.961596
SumKernelTraits_Args	11.267	23265.595	19.156766
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	30.568	8575.866	7.061322
SumKernel256_Avx2_ShiftLane	25.930	10109.809	8.324362
SumKernel256Traits	30.878	8489.587	6.990281
SumKernel256Traits_Args0	10.467	25043.819	20.620946
SumKernel256Traits_Args	10.664	24582.356	20.240980

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	321.250	816.013
SumBase	310.050	845.489	1.036122
SumTraits	24.155	10852.534	13.299465
SumTraits_Args0	20.634	12704.591	15.569107
SumTraits_Args	20.919	12531.310	15.356757
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	36.705	7141.994	8.752307
Sum256Traits	22.607	11595.912	14.210454
SumKernelTraits	18.060	14515.308	17.788089
SumKernelTraits_Args0	17.767	14754.810	18.081592
SumKernelTraits_Args	17.391	15073.768	18.472466
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	15.431	16988.322	20.818696
SumKernel256Traits_Args0	15.782	16610.754	20.355997
SumKernel256Traits_Args	15.227	17216.220	21.097978

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	573.394	457.179
SumBase	615.813	425.688	0.931117
SumTraits	69.180	3789.327	8.288488
SumTraits_Args0	37.557	6979.885	15.267276
SumTraits_Args	39.098	6704.874	14.665738
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	65.127	4025.137	8.804282
SumKernelTraits	53.997	4854.793	10.619009
SumKernelTraits_Args0	33.589	7804.575	17.071140
SumKernelTraits_Args	31.259	8386.279	18.343516
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	53.711	4880.617	10.675494
SumKernel256_Avx2_DuplicateEven	49.681	5276.504	11.541427
SumKernel256_Avx2_Multiply	115.633	2267.039	4.958751
SumKernel256_Avx2_ShiftLane	54.370	4821.492	10.546168
SumKernel256Traits	47.915	5471.014	11.966885
SumKernel256Traits_Args0	29.245	8963.776	19.606690
SumKernel256Traits_Args	33.192	7897.715	17.274867

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	180.956	1448.660
SumBase	200.705	1306.115	0.901602
SumTraits	15.342	17086.314	11.794566
SumTraits_Args0	5.820	45038.802	31.089978
SumTraits_Args	5.602	46794.997	32.302268
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	14.827	17680.705	12.204870
Sum256_Avx2_Add2	15.437	16981.534	11.722237
Sum256_Avx2_Cmp2	13.719	19108.512	13.190475
Sum256_Avx2_EqualAnd	13.065	20064.881	13.850650
Sum256Traits	15.686	16711.858	11.536082
SumKernelTraits	9.480	27650.933	19.087250
SumKernelTraits_Args0	5.897	44451.891	30.684838
SumKernelTraits_Args	6.393	41001.996	28.303399
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	9.497	27602.150	19.053576
SumKernel256Traits_Args0	5.378	48745.607	33.648760
SumKernel256Traits_Args	5.550	47232.647	32.604374

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	205.015	1278.657
SumBase	210.335	1246.319	0.974709
SumTraits	23.955	10943.134	8.558301
SumTraits_Args0	10.335	25363.988	19.836423
SumTraits_Args	10.029	26138.766	20.442354
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	21.114	12415.380	9.709700
SumKernelTraits	21.179	12377.326	9.679940
SumKernelTraits_Args0	10.140	25852.122	20.218179
SumKernelTraits_Args	10.098	25960.405	20.302864
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	19.018	13784.163	10.780185
SumKernel256_Avx2_ShiftLane	18.254	14360.709	11.231085
SumKernel256Traits	19.590	13381.369	10.465173
SumKernel256Traits_Args0	10.848	24164.491	18.898333
SumKernel256Traits_Args	10.193	25719.170	20.114201

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	304.935	859.672
SumBase	306.245	855.995	0.995723
SumTraits	24.199	10832.760	12.601042
SumTraits_Args0	16.432	15953.127	18.557231
SumTraits_Args	17.776	14746.991	17.154212
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	24.270	10800.960	12.564052
Sum256Traits	20.084	13052.644	15.183288
SumKernelTraits	18.195	14407.190	16.758943
SumKernelTraits_Args0	17.616	14880.916	17.309998
SumKernelTraits_Args	17.949	14604.621	16.988602
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	16.884	15526.311	18.060743
SumKernel256Traits_Args0	15.404	17017.951	19.795871
SumKernel256Traits_Args	23.798	11015.375	12.813466

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	527.237	497.203
SumBase	528.144	496.350	0.998283
SumTraits	62.520	4192.951	8.433071
SumTraits_Args0	33.372	7855.241	15.798850
SumTraits_Args	30.484	8599.441	17.295621
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	47.956	5466.388	10.994269
SumKernelTraits	44.716	5862.440	11.790829
SumKernelTraits_Args0	32.330	8108.408	16.308030
SumKernelTraits_Args	28.373	9239.331	18.582599
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	47.923	5470.127	11.001789
SumKernel256_Avx2_DuplicateEven	43.209	6066.870	12.201989
SumKernel256_Avx2_Multiply	92.042	2848.082	5.728203
SumKernel256_Avx2_ShiftLane	43.856	5977.394	12.022030
SumKernel256Traits	42.328	6193.223	12.456116
SumKernel256Traits_Args0	32.648	8029.324	16.148974
SumKernel256Traits_Args	33.563	7810.420	15.708704

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	211.530	1239.277
SumBase	174.737	1500.220	1.210561
SumTraits	10.818	24231.464	19.552910
SumTraits_Args0	5.187	50540.409	40.782185
SumTraits_Args	5.133	51069.265	41.208931
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	9.617	27259.330	21.996162
Sum256_Avx2_Add2	10.658	24595.180	19.846400
Sum256_Avx2_Cmp2	10.201	25697.522	20.735904
Sum256_Avx2_EqualAnd	9.420	27827.353	22.454513
Sum256Traits	9.942	26366.642	21.275832
SumKernelTraits	7.969	32894.218	26.543079
SumKernelTraits_Args0	5.246	49973.813	40.324986
SumKernelTraits_Args	5.236	50067.099	40.400261
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	6.831	38375.073	30.965704
SumKernel256Traits_Args0	5.312	49345.013	39.817593
SumKernel256Traits_Args	5.486	47781.949	38.556322

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	219.333	1195.188
SumBase	216.236	1212.305	1.014322
SumTraits	25.154	10421.696	8.719716
SumTraits_Args0	10.867	24123.555	20.183907
SumTraits_Args	10.569	24804.170	20.753371
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	21.034	12463.128	10.427760
SumKernelTraits	21.896	11972.407	10.017179
SumKernelTraits_Args0	10.412	25176.482	21.064880
SumKernelTraits_Args	12.056	21744.418	18.193311
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	18.982	13809.947	11.554628
SumKernel256_Avx2_ShiftLane	19.119	13711.196	11.472004
SumKernel256Traits	19.739	13280.373	11.111539
SumKernel256Traits_Args0	10.395	25218.816	21.100300
SumKernel256Traits_Args	10.568	24805.980	20.754885

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	320.774	817.223
SumBase	312.814	838.020	1.025448
SumTraits	23.955	10943.342	13.390888
SumTraits_Args0	16.832	15574.554	19.057899
SumTraits_Args	18.558	14125.335	17.284553
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	21.800	12024.807	14.714229
Sum256Traits	18.353	14283.708	17.478348
SumKernelTraits	18.023	14545.131	17.798239
SumKernelTraits_Args0	15.186	17262.390	21.123230
SumKernelTraits_Args	15.421	16999.007	20.800939
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	24.851	10548.803	12.908108
SumKernel256Traits_Args0	16.433	15952.165	19.519965
SumKernel256Traits_Args	19.007	13792.076	16.876758

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	563.624	465.105
SumBase	608.963	430.476	0.925547
SumTraits	61.240	4280.568	9.203448
SumTraits_Args0	30.836	8501.271	18.278183
SumTraits_Args	31.517	8317.550	17.883174
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	49.851	5258.504	11.306063
SumKernelTraits	45.709	5735.074	12.330713
SumKernelTraits_Args0	28.553	9181.086	19.739821
SumKernelTraits_Args	28.498	9198.798	19.777904
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	48.367	5419.855	11.652976
SumKernel256_Avx2_DuplicateEven	42.594	6154.469	13.232435
SumKernel256_Avx2_Multiply	87.822	2984.934	6.417766
SumKernel256_Avx2_ShiftLane	41.911	6254.779	13.448107
SumKernel256Traits	43.694	5999.570	12.899395
SumKernel256Traits_Args0	28.498	9198.774	19.777853
SumKernel256Traits_Args	29.882	8772.684	18.861735

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	178.472	1468.827
SumBase	180.463	1452.622	0.988968
SumTraits	10.878	24097.622	16.406036
SumTraits_Args0	5.340	49090.081	33.421291
SumTraits_Args	5.235	50078.249	34.094051
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	9.735	26928.091	18.333063
Sum256_Avx2_Add2	10.325	25390.338	17.286137
Sum256_Avx2_Cmp2	8.156	32141.792	21.882632
Sum256_Avx2_EqualAnd	9.697	27032.611	18.404222
Sum256Traits	9.097	28817.941	19.619702
SumKernelTraits	8.014	32711.664	22.270609
SumKernelTraits_Args0	5.086	51540.236	35.089394
SumKernelTraits_Args	5.279	49654.805	33.805764
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	7.000	37451.508	25.497569
SumKernel256Traits_Args0	5.143	50973.728	34.703707
SumKernel256Traits_Args	5.224	50184.740	34.166552

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	186.158	1408.179
SumBase	186.350	1406.729	0.998970
SumTraits	18.468	14194.280	10.079880
SumTraits_Args0	9.810	26722.243	18.976447
SumTraits_Args	9.860	26585.684	18.879471
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	243.933	1074.656	0.763153
Sum256Traits	13.162	19916.073	14.143136
SumKernelTraits	14.886	17610.477	12.505847
SumKernelTraits_Args0	10.805	24261.582	17.229041
SumKernelTraits_Args	11.321	23156.078	16.443982
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	13.844	18935.398	13.446722
SumKernel256_Avx2_ShiftLane	19.102	13723.729	9.745724
SumKernel256Traits	13.890	18872.614	13.402137
SumKernel256Traits_Args0	11.349	23099.332	16.403684
SumKernel256Traits_Args	12.777	20517.507	14.570236

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	307.270	853.140
SumBase	303.354	864.152	1.012908
SumTraits	20.648	12695.692	14.881144
SumTraits_Args0	18.215	14391.785	16.869205
SumTraits_Args	19.383	13524.193	15.852265
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	347.066	755.314	0.885334
Sum256_Avx2_Add1	22.406	11699.668	13.713663
Sum256Traits	18.752	13979.190	16.385585
SumKernelTraits	16.106	16276.648	19.078530
SumKernelTraits_Args0	18.307	14319.199	16.784123
SumKernelTraits_Args	16.017	16367.119	19.184576
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	17.649	14853.425	17.410312
SumKernel256Traits_Args0	16.573	15817.259	18.540061
SumKernel256Traits_Args	19.343	13552.579	15.885537

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	606.327	432.348
SumBase	523.201	501.038	1.158879
SumTraits	63.079	4155.819	9.612219
SumTraits_Args0	33.410	7846.303	18.148138
SumTraits_Args	35.849	7312.362	16.913158
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	517.370	506.686	1.171941
Sum256Traits	48.953	5355.022	12.385919
SumKernelTraits	44.142	5938.699	13.735938
SumKernelTraits_Args0	31.342	8364.106	19.345792
SumKernelTraits_Args	31.413	8344.952	19.301491
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	48.409	5415.151	12.524996
SumKernel256_Avx2_DuplicateEven	42.001	6241.420	14.436118
SumKernel256_Avx2_Multiply	96.731	2710.042	6.268203
SumKernel256_Avx2_ShiftLane	41.833	6266.401	14.493897
SumKernel256Traits	41.376	6335.666	14.654105
SumKernel256Traits_Args0	32.001	8191.638	18.946882
SumKernel256Traits_Args	31.240	8391.317	19.408729

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	185.243	1415.139
SumBase	177.767	1474.647	1.042051
SumTraits	8.668	30243.434	21.371348
SumTraits_Args0	5.580	46979.783	33.197992
SumTraits_Args	5.635	46518.750	32.872207
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	290.911	901.114	0.636767
Sum256_Avx2_Add1	8.282	31652.671	22.367177
Sum256_Avx2_Add2	8.777	29868.309	21.106268
Sum256_Avx2_Cmp2	8.132	32237.731	22.780606
Sum256_Avx2_EqualAnd	9.935	26385.226	18.644968
Sum256Traits	8.268	31706.056	22.404901
SumKernelTraits	6.615	39630.939	28.004974
SumKernelTraits_Args0	5.377	48754.502	34.452087
SumKernelTraits_Args	5.711	45904.504	32.438153
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	6.024	43518.592	30.752162
SumKernel256Traits_Args0	5.451	48093.264	33.984827
SumKernel256Traits_Args	5.632	46542.897	32.889270

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
# Sum512_Bcl	-23675
SumScalar	212.200	1235.365
SumBase	207.790	1261.582	1.021222
SumTraits	8.046	32579.746	26.372564
SumTraits_Args0	7.561	34671.910	28.066123
SumTraits_Args	7.902	33172.777	26.852609
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	279.338	938.447	0.759651
Sum256Traits	7.920	33098.630	26.792588
Sum512_Bcl	285.277	918.911	0.743837
Sum512Traits	8.105	32342.977	26.180905
SumKernelTraits	7.357	35632.301	28.843538
SumKernelTraits_Args0	7.135	36741.022	29.741022
SumKernelTraits_Args	7.042	37227.607	30.134901
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	7.162	36602.662	29.629023
SumKernel256_Avx2_ShiftLane	11.332	23133.972	18.726425
SumKernel256Traits	7.228	36266.651	29.357030
SumKernel256Traits_Args0	7.198	36420.461	29.481536
SumKernel256Traits_Args	7.249	36162.413	29.272651

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
# Sum512_Bcl	1243037409
SumScalar	312.926	837.720
SumBase	317.082	826.740	0.986893
SumTraits	17.398	15067.794	17.986680
SumTraits_Args0	16.848	15559.766	18.573955
SumTraits_Args	17.057	15368.528	18.345672
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128_Wasm_CompareGreater	Run fail! Requires hardware support PackedSimd!
Sum128_Wasm_EqualsShift	Run fail! Requires hardware support PackedSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	340.200	770.558	0.919828
Sum256_Avx2_Add1	17.206	15235.520	18.186898
Sum256Traits	16.782	15620.350	18.646275
Sum512_Bcl	281.775	930.330	1.110550
Sum512Traits	17.691	14817.994	17.688489
SumKernelTraits	16.384	15999.993	19.099462
SumKernelTraits_Args0	16.121	16261.174	19.411237
SumKernelTraits_Args	15.963	16422.220	19.603481
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	16.040	16343.393	19.509383
SumKernel256Traits_Args0	16.455	15931.136	19.017266
SumKernel256Traits_Args	16.482	15905.211	18.986318

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
# Sum512_Bcl	3381896767018454368
SumScalar	615.476	425.921
SumBase	612.839	427.753	1.004302
SumTraits	32.082	8171.028	19.184383
SumTraits_Args0	31.975	8198.449	19.248763
SumTraits_Args	31.288	8378.340	19.671122
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	508.504	515.520	1.210365
Sum256Traits	32.403	8089.992	18.994123
Sum512_Bcl	380.530	688.892	1.617417
Sum512Traits	33.897	7733.564	18.157281
SumKernelTraits	30.621	8560.856	20.099643
SumKernelTraits_Args0	30.127	8701.155	20.429044
SumKernelTraits_Args	30.223	8673.715	20.364618
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	29.817	8791.891	20.642080
SumKernel256_Avx2_DuplicateEven	30.170	8688.759	20.399939
SumKernel256_Avx2_Multiply	29.479	8892.630	20.878600
SumKernel256_Avx2_ShiftLane	29.704	8825.284	20.720480
SumKernel256Traits	30.200	8680.147	20.379721
SumKernel256Traits_Args0	30.476	8601.527	20.195132
SumKernel256Traits_Args	30.048	8724.270	20.483314

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
# Sum512_Bcl	67
SumScalar	216.008	1213.582
SumBase	181.880	1441.306	1.187646
SumTraits	4.306	60885.250	50.169866
SumTraits_Args0	4.321	60672.985	49.994958
SumTraits_Args	4.017	65261.554	53.775971
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	256.445	1022.223	0.842319
Sum256_Avx2_Add1	4.769	54966.710	45.292948
Sum256_Avx2_Add2	6.169	42493.502	35.014938
Sum256_Avx2_Cmp2	4.448	58940.683	48.567529
Sum256_Avx2_EqualAnd	4.336	60458.784	49.818455
Sum256Traits	3.913	66988.398	55.198902
Sum512_Bcl	265.025	989.131	0.815051
Sum512Traits	4.069	64432.274	53.092638
SumKernelTraits	3.623	72350.167	59.617037
SumKernelTraits_Args0	3.610	72615.251	59.835468
SumKernelTraits_Args	3.671	71412.964	58.844775
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	3.656	71712.144	59.091301
SumKernel256Traits_Args0	3.647	71875.070	59.225553
SumKernel256Traits_Args	3.577	73291.774	60.392927

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	257.848	1016.659
SumBase	263.215	995.932	0.979612
SumTraits	262.032	1000.426	0.984033
SumTraits_Args0	258.133	1015.537	0.998896
SumTraits_Args	257.761	1017.006	1.000341
SumKernelTraits	263.780	993.796	0.977512
SumKernelTraits_Args0	259.175	1011.454	0.994880
SumKernelTraits_Args	257.648	1017.448	1.000776

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	360.534	727.100
SumBase	369.956	708.582	0.974532
SumTraits	370.369	707.791	0.973444
SumTraits_Args0	360.088	728.000	1.001238
SumTraits_Args	382.509	685.328	0.942550
SumKernelTraits	370.116	708.275	0.974109
SumKernelTraits_Args0	360.788	726.587	0.999295
SumKernelTraits_Args	382.129	686.010	0.943488

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	567.078	462.272
SumBase	591.987	442.821	0.957923
SumTraits	592.116	442.724	0.957713
SumTraits_Args0	559.960	468.147	1.012710
SumTraits_Args	561.333	467.003	1.010234
SumKernelTraits	590.629	443.839	0.960125
SumKernelTraits_Args0	559.729	468.341	1.013129
SumKernelTraits_Args	572.805	457.650	0.990001

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	206.017	1272.437
SumBase	208.615	1256.592	0.987547
SumTraits	208.684	1256.174	0.987219
SumTraits_Args0	205.497	1275.660	1.002533
SumTraits_Args	205.802	1273.766	1.001044
SumKernelTraits	211.703	1238.263	0.973143
SumKernelTraits_Args0	206.070	1272.109	0.999742
SumKernelTraits_Args	206.282	1270.804	0.998716

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	257.346	1018.646
SumBase	257.681	1017.320	0.998699
SumTraits	257.875	1016.556	0.997949
SumTraits_Args0	258.523	1014.005	0.995445
SumTraits_Args	255.462	1026.157	1.007374
SumKernelTraits	258.418	1014.420	0.995851
SumKernelTraits_Args0	258.017	1015.994	0.997397
SumKernelTraits_Args	255.253	1026.997	1.008198

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	359.700	728.785
SumBase	360.183	727.808	0.998658
SumTraits	360.260	727.651	0.998444
SumTraits_Args0	360.194	727.785	0.998627
SumTraits_Args	357.078	734.136	1.007342
SumKernelTraits	359.498	729.196	1.000563
SumKernelTraits_Args0	360.384	727.401	0.998101
SumKernelTraits_Args	357.869	732.514	1.005116

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	566.581	462.677
SumBase	567.256	462.127	0.998810
SumTraits	567.454	461.966	0.998462
SumTraits_Args0	560.967	467.308	1.010008
SumTraits_Args	561.617	466.767	1.008839
SumKernelTraits	566.020	463.136	1.000991
SumKernelTraits_Args0	559.853	468.237	1.012017
SumKernelTraits_Args	562.700	465.868	1.006897

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	206.432	1269.882
SumBase	224.043	1170.061	0.921394
SumTraits	212.984	1230.816	0.969237
SumTraits_Args0	281.312	931.862	0.733818
SumTraits_Args	282.101	929.256	0.731766
SumKernelTraits	264.385	991.523	0.780799
SumKernelTraits_Args0	225.968	1160.091	0.913542
SumKernelTraits_Args	205.705	1274.366	1.003531

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	262.526	998.544
SumBase	258.060	1015.827	1.017308
SumTraits	48.669	5386.285	5.394139
SumTraits_Args0	17.448	15024.499	15.046408
SumTraits_Args	17.390	15074.692	15.096675
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	43.827	5981.363	5.990085
SumKernelTraits	35.699	7343.188	7.353896
SumKernelTraits_Args0	17.268	15180.615	15.202752
SumKernelTraits_Args	17.307	15146.407	15.168495
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	36.118	7257.929	7.268512
SumKernel256_Avx2_ShiftLane	34.109	7685.436	7.696643
SumKernel256Traits	35.615	7360.572	7.371305
SumKernel256Traits_Args0	17.310	15144.047	15.166131
SumKernel256Traits_Args	17.271	15178.488	15.200622

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	369.837	708.810
SumBase	360.405	727.359	1.026169
SumTraits	49.672	5277.491	7.445562
SumTraits_Args0	26.687	9823.001	13.858434
SumTraits_Args	27.202	9637.014	13.596042
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	49.596	5285.603	7.457006
SumKernelTraits	24.176	10843.004	15.297470
SumKernelTraits_Args0	24.638	10639.798	15.010784
SumKernelTraits_Args	24.587	10662.053	15.042181
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	22.356	11726.100	16.543356
SumKernel256Traits_Args0	22.105	11858.779	16.730541
SumKernel256Traits_Args	22.199	11809.072	16.660413

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	591.362	443.289
SumBase	566.134	463.042	1.044562
SumTraits	141.508	1852.505	4.179002
SumTraits_Args0	54.444	4814.927	10.861831
SumTraits_Args	54.396	4819.158	10.871374
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	123.228	2127.309	4.798923
SumKernelTraits	88.437	2964.199	6.686837
SumKernelTraits_Args0	43.184	6070.414	13.694039
SumKernelTraits_Args	43.616	6010.227	13.558267
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	75.184	3486.686	7.865497
SumKernel256_Avx2_DuplicateEven	70.774	3703.945	8.355604
SumKernel256_Avx2_Multiply	140.275	1868.790	4.215740
SumKernel256_Avx2_ShiftLane	72.150	3633.297	8.196231
SumKernel256Traits	69.915	3749.462	8.458284
SumKernel256Traits_Args0	45.976	5701.767	12.862422
SumKernel256Traits_Args	46.502	5637.204	12.716776

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	209.307	1252.439
SumBase	205.840	1273.530	1.016840
SumTraits	19.509	13436.835	10.728537
SumTraits_Args0	7.949	32977.350	26.330510
SumTraits_Args	7.926	33073.034	26.406909
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	19.527	13424.472	10.718666
Sum256_Avx2_Add2	19.605	13371.121	10.676069
Sum256_Avx2_Cmp2	17.244	15202.412	12.138249
Sum256_Avx2_EqualAnd	17.513	14968.139	11.951195
Sum256Traits	17.221	15222.366	12.154181
SumKernelTraits	12.274	21358.336	17.053398
SumKernelTraits_Args0	7.872	33299.207	26.587495
SumKernelTraits_Args	7.860	33352.484	26.630034
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	11.478	22838.503	18.235226
SumKernel256Traits_Args0	7.904	33167.363	26.482225
SumKernel256Traits_Args	7.895	33202.948	26.510637

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	251.663	1041.646
SumBase	251.802	1041.072	0.999449
SumTraits	29.908	8765.158	8.414722
SumTraits_Args0	17.582	14910.111	14.313997
SumTraits_Args	18.012	14553.903	13.972030
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	29.883	8772.257	8.421538
SumKernelTraits	26.901	9744.617	9.355022
SumKernelTraits_Args0	17.824	14707.338	14.119331
SumKernelTraits_Args	29.127	8999.999	8.640174
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	35.679	7347.263	7.053515
SumKernel256_Avx2_ShiftLane	29.365	8927.062	8.570154
SumKernel256Traits	25.656	10217.643	9.809137
SumKernel256Traits_Args0	17.862	14676.348	14.089580
SumKernel256Traits_Args	17.764	14756.944	14.166954

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	348.064	753.148
SumBase	347.745	753.841	1.000920
SumTraits	42.442	6176.523	8.200943
SumTraits_Args0	26.423	9921.083	13.172822
SumTraits_Args	27.602	9497.253	12.610076
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	33.273	7878.696	10.461021
SumKernelTraits	36.072	7267.239	9.649152
SumKernelTraits_Args0	22.744	11525.694	15.303360
SumKernelTraits_Args	25.540	10264.114	13.628284
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	25.489	10284.773	13.655714
SumKernel256Traits_Args0	23.018	11388.775	15.121564
SumKernel256Traits_Args	22.961	11416.831	15.158816

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	543.010	482.761
SumBase	543.806	482.055	0.998538
SumTraits	92.808	2824.585	5.850900
SumTraits_Args0	53.209	4926.681	10.205223
SumTraits_Args	54.264	4830.929	10.006880
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	92.651	2829.362	5.860796
SumKernelTraits	74.936	3498.257	7.246359
SumKernelTraits_Args0	46.046	5693.042	11.792679
SumKernelTraits_Args	45.432	5769.979	11.952049
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	72.343	3623.613	7.506023
SumKernel256_Avx2_DuplicateEven	73.020	3590.006	7.436408
SumKernel256_Avx2_Multiply	110.261	2377.478	4.924754
SumKernel256_Avx2_ShiftLane	73.308	3575.942	7.407276
SumKernel256Traits	72.774	3602.147	7.461558
SumKernel256Traits_Args0	50.971	5143.018	10.653348
SumKernel256Traits_Args	45.621	5746.183	11.902755

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	203.855	1285.935
SumBase	203.710	1286.850	1.000711
SumTraits	12.455	21046.672	16.366823
SumTraits_Args0	7.936	33030.816	25.686224
SumTraits_Args	7.912	33132.757	25.765497
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	13.272	19751.865	15.359924
Sum256_Avx2_Add2	14.305	18325.710	14.250883
Sum256_Avx2_Cmp2	13.323	19676.439	15.301270
Sum256_Avx2_EqualAnd	12.876	20359.118	15.832150
Sum256Traits	12.054	21747.951	16.912168
SumKernelTraits	10.615	24694.833	19.203794
SumKernelTraits_Args0	8.031	32640.109	25.382393
SumKernelTraits_Args	8.118	32291.049	25.110948
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	9.220	28432.728	22.110547
SumKernel256Traits_Args0	7.923	33087.204	25.730074
SumKernel256Traits_Args	8.270	31697.628	24.649477

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	251.431	1042.608
SumBase	251.667	1041.631	0.999063
SumTraits	29.253	8961.145	8.594931
SumTraits_Args0	17.744	14773.976	14.170210
SumTraits_Args	17.408	15058.475	14.443082
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	28.453	9213.382	8.836860
SumKernelTraits	24.771	10582.688	10.150206
SumKernelTraits_Args0	18.533	14144.931	13.566872
SumKernelTraits_Args	18.047	14525.871	13.932243
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	24.480	10708.385	10.270767
SumKernel256_Avx2_ShiftLane	25.202	10401.670	9.976586
SumKernel256Traits	24.481	10707.976	10.270374
SumKernel256Traits_Args0	18.587	14103.424	13.527061
SumKernel256Traits_Args	18.035	14535.652	13.941625

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	354.535	739.401
SumBase	354.325	739.840	1.000593
SumTraits	35.436	7397.582	10.004826
SumTraits_Args0	26.882	9751.553	13.188444
SumTraits_Args	27.631	9487.379	12.831164
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	28.872	9079.384	12.279373
SumKernelTraits	35.900	7302.000	9.875557
SumKernelTraits_Args0	22.811	11492.221	15.542602
SumKernelTraits_Args	22.881	11456.597	15.494423
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	25.826	10150.383	13.727840
SumKernel256Traits_Args0	23.050	11372.807	15.381101
SumKernel256Traits_Args	22.743	11526.468	15.588921

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	567.070	462.278
SumBase	564.848	464.097	1.003935
SumTraits	103.660	2528.873	5.470463
SumTraits_Args0	52.791	4965.695	10.741802
SumTraits_Args	56.200	4664.443	10.090133
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	106.658	2457.798	5.316714
SumKernelTraits	72.856	3598.090	7.783396
SumKernelTraits_Args0	45.505	5760.762	12.461691
SumKernelTraits_Args	45.359	5779.311	12.501818
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	75.282	3482.150	7.532595
SumKernel256_Avx2_DuplicateEven	73.168	3582.747	7.750206
SumKernel256_Avx2_Multiply	107.453	2439.617	5.277384
SumKernel256_Avx2_ShiftLane	72.017	3640.024	7.874107
SumKernel256Traits	71.120	3685.930	7.973411
SumKernel256Traits_Args0	46.348	5656.013	12.235099
SumKernel256Traits_Args	45.911	5709.806	12.351465

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	205.356	1276.537
SumBase	205.424	1276.112	0.999667
SumTraits	11.643	22516.121	17.638434
SumTraits_Args0	7.928	33064.959	25.902068
SumTraits_Args	7.951	32970.692	25.828222
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	12.450	21056.531	16.495036
Sum256_Avx2_Add2	12.840	20415.691	15.993022
Sum256_Avx2_Cmp2	10.832	24199.780	18.957361
Sum256_Avx2_EqualAnd	12.967	20216.444	15.836938
Sum256Traits	11.438	22919.506	17.954434
SumKernelTraits	10.494	24980.435	19.568901
SumKernelTraits_Args0	7.984	32834.769	25.721745
SumKernelTraits_Args	8.005	32749.519	25.654962
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	9.212	28457.570	22.292782
SumKernel256Traits_Args0	8.066	32498.764	25.458528
SumKernel256Traits_Args	7.913	33129.448	25.952587

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	255.751	1024.998
SumBase	258.958	1012.302	0.987614
SumTraits	25.882	10128.301	9.881289
SumTraits_Args0	17.414	15053.609	14.686477
SumTraits_Args	17.767	14754.580	14.394741
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	349.366	750.342	0.732042
Sum256Traits	20.645	12697.956	12.388274
SumKernelTraits	21.480	12204.288	11.906646
SumKernelTraits_Args0	18.059	14516.094	14.162071
SumKernelTraits_Args	17.971	14587.111	14.231356
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	18.770	13965.905	13.625300
SumKernel256_Avx2_ShiftLane	23.875	10979.798	10.712019
SumKernel256Traits	18.717	14005.395	13.663827
SumKernel256Traits_Args0	18.134	14455.921	14.103365
SumKernel256Traits_Args	17.773	14749.937	14.390211

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	357.063	734.168
SumBase	358.194	731.849	0.996841
SumTraits	25.690	10204.153	13.898929
SumTraits_Args0	25.701	10199.869	13.893093
SumTraits_Args	27.456	9547.718	13.004808
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	434.235	603.691	0.822279
Sum256Traits	25.890	10125.224	13.791421
SumKernelTraits	21.782	12034.804	16.392432
SumKernelTraits_Args0	22.401	11702.120	15.939287
SumKernelTraits_Args	22.177	11820.508	16.100542
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	22.023	11903.163	16.213126
SumKernel256Traits_Args0	22.120	11851.050	16.142142
SumKernel256Traits_Args	23.426	11190.310	15.242158

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	565.844	463.280
SumBase	563.781	464.975	1.003658
SumTraits	71.153	3684.254	7.952544
SumTraits_Args0	53.030	4943.292	10.670207
SumTraits_Args	55.093	4758.252	10.270793
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	535.367	489.653	1.056928
Sum256Traits	62.351	4204.358	9.075200
SumKernelTraits	57.439	4563.892	9.851262
SumKernelTraits_Args0	45.125	5809.334	12.539576
SumKernelTraits_Args	46.809	5600.277	12.088323
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	64.360	4073.063	8.791798
SumKernel256_Avx2_DuplicateEven	52.996	4946.453	10.677029
SumKernel256_Avx2_Multiply	109.717	2389.271	5.157295
SumKernel256_Avx2_ShiftLane	55.670	4708.888	10.164239
SumKernel256Traits	57.543	4555.621	9.833410
SumKernel256Traits_Args0	47.205	5553.266	11.986850
SumKernel256Traits_Args	45.281	5789.265	12.496258

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	205.216	1277.403
SumBase	209.968	1248.495	0.977370
SumTraits	10.184	25740.061	20.150308
SumTraits_Args0	7.574	34611.644	27.095324
SumTraits_Args	7.589	34544.193	27.042521
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	281.014	932.852	0.730272
Sum256_Avx2_Add1	9.910	26452.281	20.707861
Sum256_Avx2_Add2	10.042	26104.468	20.435580
Sum256_Avx2_Cmp2	9.899	26482.193	20.731278
Sum256_Avx2_EqualAnd	10.051	26081.512	20.417609
Sum256Traits	8.211	31924.788	24.991950
SumKernelTraits	8.601	30476.824	23.858428
SumKernelTraits_Args0	7.914	33124.708	25.931293
SumKernelTraits_Args	7.640	34311.869	26.860648
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	7.756	33797.896	26.458291
SumKernel256Traits_Args0	7.583	34571.312	27.063751
SumKernel256Traits_Args	7.707	34014.673	26.627992

``` 


### Intel Core i5-8250U - 128 bit
`Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz`
SET COMPlus_EnableAVX2=0

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
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vector128s.Instance:	WVectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.Instance:	VectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.BaseInstance:	VectorTraits128Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	354.130	740.249
SumBase	360.542	727.083	0.982215
SumTraits	75.709	3462.537	4.677533
SumTraits_Args0	21.301	12306.584	16.624935
SumTraits_Args	21.345	12281.000	16.590374
Sum128Traits	69.228	3786.654	5.115383
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	52.994	4946.668	6.682443
SumKernelTraits_Args0	21.220	12353.493	16.688305
SumKernelTraits_Args	21.360	12272.866	16.579387
SumKernel128Traits	41.250	6355.005	8.584962
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	596.163	439.719
SumBase	548.806	477.662	1.086291
SumTraits	134.431	1950.031	4.434725
SumTraits_Args0	42.198	6212.169	14.127601
SumTraits_Args	40.373	6493.041	14.766356
Sum128Traits	123.777	2117.871	4.816423
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	91.296	2871.354	6.529981
SumKernelTraits_Args0	42.706	6138.326	13.959669
SumKernelTraits_Args	42.221	6208.813	14.119970
SumKernel128Traits	84.045	3119.094	7.093385
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	949.546	276.073
SumBase	947.525	276.662	1.002133
SumTraits	315.833	830.008	3.006478
SumTraits_Args0	80.528	3255.313	11.791491
SumTraits_Args	84.247	3111.626	11.271023
Sum128Traits	248.691	1054.096	3.818176
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	180.891	1449.179	5.249257
SumKernelTraits_Args0	95.993	2730.876	9.891858
SumKernelTraits_Args	90.021	2912.020	10.548006
SumKernel128_Sse_DuplicateEven	212.979	1230.846	4.458407
SumKernel128Traits	206.803	1267.601	4.591541
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	272.126	963.320
SumBase	255.178	1027.300	1.066416
SumTraits	24.689	10617.759	11.022046
SumTraits_Args0	9.885	26518.244	27.527965
SumTraits_Args	10.013	26180.253	27.177104
Sum128Traits	24.749	10591.944	10.995248
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	10.162	25796.330	26.778564
SumKernelTraits_Args0	10.043	26101.227	27.095070
SumKernelTraits_Args	10.542	24867.437	25.814301
SumKernel128Traits	10.717	24461.205	25.392602
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

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
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.Instance:	VectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.BaseInstance:	VectorTraits128Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	341.105	768.515
SumBase	342.790	764.736	0.995083
SumTraits	41.903	6255.944	8.140303
SumTraits_Args0	19.640	13347.670	17.368134
SumTraits_Args	20.049	13074.901	17.013205
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	35.378	7409.713	9.641601
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	32.451	8078.267	10.511530
SumKernelTraits_Args0	20.985	12492.054	16.254798
SumKernelTraits_Args	20.047	13076.678	17.015517
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	25.501	10279.712	13.376075
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	526.068	498.308
SumBase	526.121	498.258	0.999900
SumTraits	86.284	3038.154	6.096941
SumTraits_Args0	38.756	6763.988	13.573912
SumTraits_Args	42.042	6235.346	12.513039
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	74.780	3505.560	7.034927
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	66.389	3948.604	7.924025
SumKernelTraits_Args0	48.280	5429.647	10.896168
SumKernelTraits_Args	40.068	6542.452	13.129335
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	60.985	4298.532	8.626256
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	899.126	291.554
SumBase	898.188	291.859	1.001044
SumTraits	188.791	1388.538	4.762537
SumTraits_Args0	78.404	3343.512	11.467888
SumTraits_Args	82.046	3195.081	10.958787
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	181.537	1444.028	4.952862
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	135.012	1941.636	6.659603
SumKernelTraits_Args0	81.805	3204.512	10.991133
SumKernelTraits_Args	78.550	3337.283	11.446524
SumKernel128_Sse_DuplicateEven	152.328	1720.917	5.902562
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	114.464	2290.195	7.855125
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	247.819	1057.803
SumBase	249.187	1051.996	0.994510
SumTraits	16.302	16080.835	15.202106
SumTraits_Args0	10.139	25854.669	24.441854
SumTraits_Args	10.029	26139.450	24.711072
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	13.988	18740.745	17.716666
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	12.103	21659.094	20.475544
SumKernelTraits_Args0	9.597	27315.981	25.823313
SumKernelTraits_Args	9.399	27889.534	26.365524
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	10.402	25201.216	23.824108
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.14
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.14\
RuntimeInformation.FrameworkDescription:	.NET 6.0.14
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.Instance:	VectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.BaseInstance:	VectorTraits128Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	339.232	772.758
SumBase	339.199	772.833	1.000097
SumTraits	37.061	7073.393	9.153439
SumTraits_Args0	19.326	13564.558	17.553435
SumTraits_Args	20.397	12852.249	16.631661
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	36.862	7111.410	9.202635
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	29.535	8875.736	11.485789
SumKernelTraits_Args0	18.763	13971.670	18.080265
SumKernelTraits_Args	18.678	14035.159	18.162424
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	27.586	9502.717	12.297145
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	545.804	480.289
SumBase	550.924	475.826	0.990707
SumTraits	84.634	3097.391	6.449012
SumTraits_Args0	39.607	6618.650	13.780550
SumTraits_Args	38.682	6776.833	14.109900
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	79.035	3316.811	6.905862
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	60.746	4315.436	8.985078
SumKernelTraits_Args0	37.430	7003.559	14.581961
SumKernelTraits_Args	38.737	6767.243	14.089933
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	58.473	4483.136	9.334243
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	936.094	280.040
SumBase	935.590	280.191	1.000538
SumTraits	200.503	1307.429	4.668715
SumTraits_Args0	79.919	3280.135	11.713081
SumTraits_Args	79.550	3295.345	11.767392
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	179.428	1461.001	5.217109
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	121.791	2152.402	7.686043
SumKernelTraits_Args0	79.737	3287.616	11.739792
SumKernelTraits_Args	81.785	3205.269	11.445740
SumKernel128_Sse_DuplicateEven	152.666	1717.103	6.131627
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	119.116	2200.748	7.858681
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	254.800	1028.821
SumBase	254.775	1028.922	1.000098
SumTraits	13.244	19793.764	19.239261
SumTraits_Args0	10.313	25418.389	24.706318
SumTraits_Args	9.547	27457.767	26.688565
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	12.232	21431.121	20.830749
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	11.987	21868.788	21.256155
SumKernelTraits_Args0	9.833	26659.470	25.912631
SumKernelTraits_Args	9.570	27392.049	26.624687
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	9.746	26896.689	26.143205
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.3
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.3\
RuntimeInformation.FrameworkDescription:	.NET 7.0.3
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.Instance:	VectorTraits128Sse	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vectors.BaseInstance:	VectorTraits128Base


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	345.338	759.095
SumBase	347.968	753.356	0.992440
SumTraits	32.362	8100.287	10.670979
SumTraits_Args0	18.009	14556.397	19.175988
SumTraits_Args	18.833	13919.373	18.336799
Sum128_Bcl	421.209	622.361	0.819873
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	26.654	9835.238	12.956531
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	25.414	10315.084	13.588660
SumKernelTraits_Args0	18.747	13982.928	18.420524
SumKernelTraits_Args	18.963	13824.059	18.211236
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	20.046	13077.237	17.227404
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	551.442	475.379
SumBase	554.771	472.526	0.993999
SumTraits	72.087	3636.507	7.649700
SumTraits_Args0	37.420	7005.379	14.736404
SumTraits_Args	37.551	6981.091	14.685313
Sum128_Bcl	489.351	535.698	1.126885
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	53.002	4945.924	10.404169
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	52.057	5035.680	10.592977
SumKernelTraits_Args0	38.451	6817.644	14.341489
SumKernelTraits_Args	37.360	7016.655	14.760124
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	41.215	6360.422	13.379683
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	945.030	277.392
SumBase	944.207	277.634	1.000872
SumTraits	143.821	1822.714	6.570889
SumTraits_Args0	78.615	3334.538	12.021021
SumTraits_Args	78.138	3354.894	12.094403
Sum128_Bcl	869.310	301.554	1.087104
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	141.217	1856.322	6.692047
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	111.055	2360.493	8.509584
SumKernelTraits_Args0	73.657	3558.987	12.830159
SumKernelTraits_Args	73.557	3563.819	12.847578
SumKernel128_Sse_DuplicateEven	121.139	2163.989	7.801187
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	92.240	2841.992	10.245390
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	254.523	1029.944
SumBase	256.476	1022.099	0.992383
SumTraits	13.408	19550.985	18.982572
SumTraits_Args0	9.081	28865.877	28.026649
SumTraits_Args	10.749	24388.763	23.679700
Sum128_Bcl	326.565	802.731	0.779393
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	12.172	21536.321	20.910188
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	10.692	24517.746	23.804933
SumKernelTraits_Args0	9.460	27710.286	26.904654
SumKernelTraits_Args	9.389	27920.304	27.108566
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	9.270	28278.463	27.456312
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits128Avx2: Requires hardware support Avx, Avx2!
VectorTraits128Sse: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	144.543	1813.611
SumBase	144.534	1813.720	1.000060
SumTraits	19.284	13593.983	7.495532
SumTraits_Args0	19.259	13611.708	7.505306
SumTraits_Args	19.307	13577.658	7.486531
Sum128_AdvSimd	22.898	11448.478	6.312531
Sum128Traits	19.272	13602.376	7.500160
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	19.269	13604.116	7.501120
SumKernelTraits_Args0	19.261	13610.012	7.504370
SumKernelTraits_Args	19.306	13578.600	7.487051
SumKernel128_AdvSimd	21.690	12085.817	6.663951
SumKernel128Traits	19.269	13604.367	7.501258
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	163.823	1600.170
SumBase	163.828	1600.118	0.999968
SumTraits	38.559	6798.483	4.248601
SumTraits_Args0	38.536	6802.581	4.251162
SumTraits_Args	38.587	6793.540	4.245511
Sum128_AdvSimd	45.789	5725.075	3.577792
Sum128Traits	38.549	6800.272	4.249719
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	38.559	6798.492	4.248606
SumKernelTraits_Args0	38.533	6803.152	4.251518
SumKernelTraits_Args	38.578	6795.238	4.246573
SumKernel128_AdvSimd	43.592	6013.588	3.758093
SumKernel128Traits	38.542	6801.578	4.250535
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	202.466	1294.758
SumBase	202.500	1294.541	0.999832
SumTraits	77.120	3399.181	2.625341
SumTraits_Args0	77.084	3400.768	2.626566
SumTraits_Args	77.134	3398.536	2.624843
Sum128_AdvSimd	110.826	2365.370	1.826882
Sum128Traits	77.096	3400.241	2.626159
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	77.086	3400.653	2.626478
SumKernelTraits_Args0	77.074	3401.209	2.626907
SumKernelTraits_Args	77.125	3398.930	2.625147
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	86.729	3022.573	2.334470
SumKernel128_Arm_Multiply	168.701	1553.900	1.200147
SumKernel128Traits	77.057	3401.970	2.627495
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	115.649	2266.726
SumBase	115.648	2266.739	1.000006
SumTraits	9.646	27175.969	11.989083
SumTraits_Args0	9.644	27183.317	11.992325
SumTraits_Args	9.685	27066.764	11.940906
Sum128_AdvSimd	9.656	27147.801	11.976657
Sum128Traits	9.637	27202.974	12.000997
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	9.646	27176.436	11.989289
SumKernelTraits_Args0	9.644	27181.156	11.991372
SumKernelTraits_Args	9.686	27065.350	11.940282
SumKernel128_AdvSimd	9.656	27148.573	11.976997
SumKernel128Traits	9.638	27197.911	11.998763
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	114.624	2286.981
SumBase	114.435	2290.775	1.001659
SumTraits	19.270	13603.414	5.948197
SumTraits_Args0	19.265	13607.433	5.949954
SumTraits_Args	19.264	13608.068	5.950232
Sum128_Bcl	138.533	1892.287	0.827417
Sum128_AdvSimd	19.986	13116.280	5.735194
Sum128Traits	19.267	13606.053	5.949351
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	19.259	13611.317	5.951653
SumKernelTraits_Args0	19.258	13612.060	5.951978
SumKernelTraits_Args	19.262	13609.518	5.950866
SumKernel128_AdvSimd	19.284	13593.857	5.944018
SumKernel128Traits	19.259	13611.349	5.951666
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	134.908	1943.129
SumBase	134.922	1942.929	0.999897
SumTraits	38.537	6802.443	3.500767
SumTraits_Args0	38.538	6802.236	3.500661
SumTraits_Args	38.537	6802.317	3.500702
Sum128_Bcl	100.170	2617.002	1.346798
Sum128_AdvSimd	39.947	6562.261	3.377161
Sum128Traits	38.530	6803.618	3.501372
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	38.526	6804.381	3.501765
SumKernelTraits_Args0	38.523	6804.811	3.501986
SumKernelTraits_Args	38.525	6804.500	3.501826
SumKernel128_AdvSimd	38.555	6799.175	3.499085
SumKernel128Traits	38.531	6803.402	3.501261
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	169.014	1551.021
SumBase	169.069	1550.515	0.999673
SumTraits	77.080	3400.917	2.192695
SumTraits_Args0	77.060	3401.830	2.193284
SumTraits_Args	77.071	3401.340	2.192968
Sum128_Bcl	127.537	2055.437	1.325215
Sum128_AdvSimd	94.518	2773.480	1.788164
Sum128Traits	77.059	3401.851	2.193297
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	77.062	3401.744	2.193229
SumKernelTraits_Args0	77.060	3401.822	2.193279
SumKernelTraits_Args	77.051	3402.198	2.193521
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	77.091	3400.468	2.192406
SumKernel128_Arm_Multiply	127.046	2063.375	1.330333
SumKernel128Traits	77.057	3401.930	2.193348
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	95.806	2736.182
SumBase	95.834	2735.397	0.999713
SumTraits	9.650	27165.670	9.928312
SumTraits_Args0	9.651	27163.344	9.927462
SumTraits_Args	9.654	27153.973	9.924037
Sum128_Bcl	131.948	1986.725	0.726094
Sum128_AdvSimd	9.657	27144.258	9.920486
Sum128Traits	9.639	27195.784	9.939318
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	9.650	27166.467	9.928603
SumKernelTraits_Args0	9.650	27163.831	9.927640
SumKernelTraits_Args	9.654	27153.156	9.923739
SumKernel128_AdvSimd	9.660	27135.989	9.917464
SumKernel128Traits	9.639	27196.443	9.939559
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
# Sum512_Bcl	9916
SumScalar	115.609	2267.510
SumBase	115.624	2267.218	0.999871
SumTraits	19.255	13614.059	6.003968
SumTraits_Args0	19.260	13611.140	6.002680
SumTraits_Args	19.257	13613.104	6.003547
Sum128_Bcl	137.309	1909.152	0.841960
Sum128_AdvSimd	19.271	13603.377	5.999257
Sum128Traits	19.255	13614.115	6.003993
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	137.034	1912.983	0.843649
Sum512Traits	137.034	1912.982	0.843648
SumKernelTraits	19.251	13616.924	6.005232
SumKernelTraits_Args0	19.256	13613.942	6.003916
SumKernelTraits_Args	19.251	13616.825	6.005188
SumKernel128_AdvSimd	19.274	13600.748	5.998098
SumKernel128Traits	19.256	13613.471	6.003709
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
# Sum512_Bcl	-1085665694
SumScalar	134.921	1942.939
SumBase	154.187	1700.166	0.875049
SumTraits	38.520	6805.336	3.502600
SumTraits_Args0	38.523	6804.942	3.502397
SumTraits_Args	38.524	6804.719	3.502282
Sum128_Bcl	100.088	2619.142	1.348031
Sum128_AdvSimd	38.538	6802.300	3.501037
Sum128_Wasm_CompareGreater	Run fail! Requires hardware support PackedSimd!
Sum128_Wasm_EqualsShift	Run fail! Requires hardware support PackedSimd!
Sum128Traits	38.519	6805.516	3.502693
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	150.012	1747.491	0.899406
Sum512Traits	149.908	1748.702	0.900030
SumKernelTraits	38.529	6803.818	3.501818
SumKernelTraits_Args0	38.518	6805.694	3.502784
SumKernelTraits_Args	38.535	6802.751	3.501269
SumKernel128_AdvSimd	38.552	6799.723	3.499711
SumKernel128Traits	38.530	6803.696	3.501756
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
# Sum512_Bcl	3280801193489835857
SumScalar	174.181	1505.013
SumBase	173.684	1509.312	1.002857
SumTraits	77.041	3402.669	2.260890
SumTraits_Args0	77.059	3401.864	2.260356
SumTraits_Args	77.052	3402.187	2.260570
Sum128_Bcl	127.313	2059.051	1.368128
Sum128_AdvSimd	77.083	3400.783	2.259638
Sum128Traits	77.050	3402.265	2.260622
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	173.283	1512.807	1.005179
Sum512Traits	173.534	1510.622	1.003727
SumKernelTraits	77.079	3400.987	2.259773
SumKernelTraits_Args0	77.059	3401.855	2.260350
SumKernelTraits_Args	77.051	3402.201	2.260580
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	77.069	3401.420	2.260061
SumKernel128_Arm_Multiply	591.457	443.217	0.294494
SumKernel128Traits	77.053	3402.144	2.260542
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
# Sum512_Bcl	42
SumScalar	96.538	2715.459
SumBase	96.488	2716.850	1.000512
SumTraits	9.640	27193.666	10.014391
SumTraits_Args0	9.637	27200.994	10.017089
SumTraits_Args	9.640	27194.756	10.014792
Sum128_Bcl	131.354	1995.712	0.734945
Sum128_AdvSimd	9.645	27178.830	10.008927
Sum128Traits	9.637	27201.747	10.017366
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	131.190	1998.195	0.735859
Sum512Traits	131.156	1998.720	0.736052
SumKernelTraits	9.638	27199.577	10.016567
SumKernelTraits_Args0	9.638	27199.077	10.016383
SumKernelTraits_Args	9.637	27202.032	10.017471
SumKernel128_AdvSimd	9.643	27183.552	10.010666
SumKernel128Traits	9.635	27206.105	10.018971
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	613.524	427.276
SumBase	615.547	425.871	0.996713
SumTraits	612.084	428.281	1.002352
SumTraits_Args0	611.161	428.928	1.003867
SumTraits_Args	646.412	405.537	0.949122
Sum128Traits	1094.618	239.485	0.560492
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	613.006	427.637	1.000846
SumKernelTraits_Args0	613.091	427.578	1.000707
SumKernelTraits_Args	646.913	405.223	0.948388
SumKernel128Traits	1094.375	239.538	0.560616
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	913.712	286.900
SumBase	911.585	287.569	1.002333
SumTraits	914.681	286.596	0.998940
SumTraits_Args0	910.014	288.066	1.004063
SumTraits_Args	970.009	270.249	0.941962
Sum128Traits	1670.778	156.899	0.546878
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	912.168	287.386	1.001692
SumKernelTraits_Args0	914.273	286.724	0.999386
SumKernelTraits_Args	968.307	270.724	0.943617
SumKernel128Traits	1666.255	157.325	0.548362
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	584.370	448.592
SumBase	616.262	425.377	0.948249
SumTraits	1373.105	190.913	0.425583
SumTraits_Args0	614.194	426.809	0.951442
SumTraits_Args	1460.136	179.534	0.400216
Sum128Traits	1119.122	234.241	0.522168
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	585.058	448.065	0.998824
SumKernelTraits_Args0	582.728	449.857	1.002819
SumKernelTraits_Args	757.911	345.877	0.771028
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128Traits	1117.810	234.516	0.522781
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	393.764	665.739
SumBase	389.884	672.364	1.009951
SumTraits	385.172	680.590	1.022307
SumTraits_Args0	396.830	660.595	0.992273
SumTraits_Args	411.162	637.568	0.957684
Sum128Traits	654.662	400.426	0.601476
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	389.641	672.784	1.010581
SumKernelTraits_Args0	388.226	675.236	1.014264
SumKernelTraits_Args	407.819	642.795	0.965536
SumKernel128Traits	654.133	400.750	0.601962
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	621.360	421.887
SumBase	621.999	421.454	0.998973
SumTraits	53.250	4922.876	11.668703
SumTraits_Args0	33.173	7902.420	18.731122
SumTraits_Args	93.307	2809.483	6.659322
Sum128_AdvSimd	95.993	2730.866	6.472976
Sum128Traits	49.810	5262.847	12.474536
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	46.390	5650.913	13.394369
SumKernelTraits_Args0	33.194	7897.224	18.718806
SumKernelTraits_Args	93.250	2811.195	6.663381
SumKernel128_AdvSimd	75.382	3477.554	8.242854
SumKernel128Traits	40.064	6543.087	15.509093
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	932.344	281.167
SumBase	933.973	280.676	0.998256
SumTraits	113.423	2311.209	8.220070
SumTraits_Args0	62.633	4185.430	14.885945
SumTraits_Args	187.739	1396.323	4.966178
Sum128_AdvSimd	167.927	1561.060	5.552082
Sum128Traits	105.888	2475.662	8.804966
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	97.910	2677.394	9.522449
SumKernelTraits_Args0	66.880	3919.619	13.940561
SumKernelTraits_Args	187.250	1399.968	4.979142
SumKernel128_AdvSimd	163.073	1607.527	5.717348
SumKernel128Traits	80.101	3272.674	11.639627
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	594.758	440.758
SumBase	622.180	421.331	0.955925
SumTraits	260.680	1005.614	2.281559
SumTraits_Args0	125.375	2090.887	4.743847
SumTraits_Args	375.558	698.013	1.583665
Sum128_AdvSimd	521.114	503.046	1.141321
Sum128Traits	214.052	1224.675	2.778568
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	211.875	1237.258	2.807117
SumKernelTraits_Args0	124.747	2101.411	4.767724
SumKernelTraits_Args	373.528	701.805	1.592270
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	281.274	931.986	2.114510
SumKernel128_Arm_Multiply	567.444	461.974	1.048135
SumKernel128Traits	177.469	1477.127	3.351336
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	394.662	664.224
SumBase	397.435	659.589	0.993023
SumTraits	19.894	13176.730	19.837790
SumTraits_Args0	16.692	15704.393	23.643230
SumTraits_Args	46.831	5597.644	8.427348
Sum128_AdvSimd	23.317	11242.569	16.925878
Sum128Traits	15.634	16767.896	25.244352
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	16.799	15604.597	23.492986
SumKernelTraits_Args0	15.679	16718.959	25.170677
SumKernelTraits_Args	47.030	5573.999	8.391751
SumKernel128_AdvSimd	22.314	11748.196	17.687108
SumKernel128Traits	16.677	15719.108	23.665384
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	621.999	421.454
SumBase	619.123	423.412	1.004645
SumTraits	47.185	5555.655	13.182116
SumTraits_Args0	31.146	8416.624	19.970448
SumTraits_Args	93.659	2798.925	6.641117
Sum128_AdvSimd	84.114	3116.533	7.394718
Sum128Traits	47.083	5567.725	13.210756
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	40.080	6540.446	15.518767
SumKernelTraits_Args0	33.217	7891.894	18.725400
SumKernelTraits_Args	93.718	2797.170	6.636952
SumKernel128_AdvSimd	77.716	3373.104	8.003493
SumKernel128Traits	40.015	6551.098	15.544043
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	930.124	281.838
SumBase	931.406	281.450	0.998624
SumTraits	106.020	2472.592	8.773107
SumTraits_Args0	66.727	3928.604	13.939245
SumTraits_Args	187.013	1401.742	4.973580
Sum128_AdvSimd	168.394	1556.727	5.523487
Sum128Traits	94.525	2773.273	9.839966
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	80.717	3247.692	11.523271
SumKernelTraits_Args0	62.675	4182.617	14.840519
SumKernelTraits_Args	187.789	1395.953	4.953040
SumKernel128_AdvSimd	155.994	1680.474	5.962562
SumKernel128Traits	80.639	3250.843	11.534454
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	589.241	444.884
SumBase	587.861	445.929	1.002348
SumTraits	246.226	1064.650	2.393093
SumTraits_Args0	124.799	2100.527	4.721512
SumTraits_Args	374.920	699.200	1.571644
Sum128_AdvSimd	475.899	550.840	1.238163
Sum128Traits	245.398	1068.241	2.401165
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	185.539	1412.876	3.175826
SumKernelTraits_Args0	133.261	1967.152	4.421715
SumKernelTraits_Args	375.160	698.753	1.570640
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	293.018	894.636	2.010940
SumKernel128_Arm_Multiply	533.612	491.264	1.104250
SumKernel128Traits	177.592	1476.100	3.317940
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	398.293	658.168
SumBase	397.757	659.055	1.001348
SumTraits	15.661	16739.161	25.432964
SumTraits_Args0	16.671	15724.340	23.891076
SumTraits_Args	46.788	5602.803	8.512725
Sum128_AdvSimd	22.337	11736.112	17.831486
Sum128Traits	15.675	16723.557	25.409256
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	15.667	16732.629	25.423039
SumKernelTraits_Args0	16.681	15715.512	23.877663
SumKernelTraits_Args	46.827	5598.168	8.505684
SumKernel128_AdvSimd	22.334	11737.578	17.833713
SumKernel128Traits	15.652	16747.893	25.446231
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	497.815	526.589
SumBase	498.192	526.191	0.999244
SumTraits	44.702	5864.193	11.136177
SumTraits_Args0	26.411	9925.441	18.848539
SumTraits_Args	26.531	9880.804	18.763773
Sum128_Bcl	542.846	482.907	0.917046
Sum128_AdvSimd	83.461	3140.910	5.964628
Sum128Traits	44.668	5868.675	11.144689
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	32.944	7957.175	15.110776
SumKernelTraits_Args0	26.400	9929.863	18.856936
SumKernelTraits_Args	26.583	9861.330	18.726791
SumKernel128_AdvSimd	74.782	3505.451	6.656897
SumKernel128Traits	32.971	7950.782	15.098637
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	824.673	317.876
SumBase	829.632	315.976	0.994023
SumTraits	89.857	2917.343	9.177609
SumTraits_Args0	53.124	4934.590	15.523626
SumTraits_Args	53.645	4886.669	15.372871
Sum128_Bcl	861.409	304.320	0.957354
Sum128_AdvSimd	163.364	1604.657	5.048058
Sum128Traits	89.609	2925.412	9.202994
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	66.306	3953.573	12.437465
SumKernelTraits_Args0	53.168	4930.469	15.510660
SumKernelTraits_Args	53.506	4899.359	15.412792
SumKernel128_AdvSimd	149.243	1756.488	5.525700
SumKernel128Traits	66.249	3956.969	12.448146
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	474.846	552.061
SumBase	475.192	551.659	0.999272
SumTraits	208.876	1255.025	2.273343
SumTraits_Args0	105.711	2479.821	4.491932
SumTraits_Args	106.654	2457.898	4.452220
Sum128_Bcl	370.074	708.356	1.283111
Sum128_AdvSimd	433.750	604.367	1.094746
Sum128Traits	208.067	1259.901	2.282176
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	149.501	1753.457	3.176201
SumKernelTraits_Args0	106.172	2469.054	4.472428
SumKernelTraits_Args	106.703	2456.761	4.450160
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	286.300	915.626	1.658559
SumKernel128_Arm_Multiply	499.075	525.260	0.951452
SumKernel128Traits	149.068	1758.550	3.185426
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	314.237	834.224
SumBase	314.243	834.209	0.999981
SumTraits	13.291	19723.567	23.643006
SumTraits_Args0	13.291	19723.852	23.643347
SumTraits_Args	13.371	19605.289	23.501223
Sum128_Bcl	404.695	647.757	0.776478
Sum128_AdvSimd	20.002	13105.897	15.710282
Sum128Traits	13.287	19729.703	23.650360
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	13.312	19692.571	23.605850
SumKernelTraits_Args0	13.287	19729.144	23.649691
SumKernelTraits_Args	13.382	19588.655	23.481283
SumKernel128_AdvSimd	19.963	13131.709	15.741223
SumKernel128Traits	13.277	19744.815	23.668475
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
# Sum512_Bcl	9916
SumScalar	507.742	516.294
SumBase	505.803	518.273	1.003833
SumTraits	26.993	9711.569	18.810158
SumTraits_Args0	26.999	9709.555	18.806258
SumTraits_Args	27.004	9707.490	18.802258
Sum128_Bcl	559.678	468.383	0.907203
Sum128_AdvSimd	49.137	5334.923	10.333113
Sum128Traits	26.675	9827.341	19.034396
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	470.299	557.399	1.079616
Sum512Traits	470.277	557.424	1.079665
SumKernelTraits	26.657	9833.813	19.046932
SumKernelTraits_Args0	26.696	9819.774	19.019739
SumKernelTraits_Args	26.668	9829.822	19.039202
SumKernel128_AdvSimd	48.974	5352.675	10.367498
SumKernel128Traits	26.877	9753.632	18.891630
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
# Sum512_Bcl	-1085665694
SumScalar	847.192	309.427
SumBase	846.334	309.741	1.001014
SumTraits	54.591	4801.979	15.518938
SumTraits_Args0	54.367	4821.784	15.582942
SumTraits_Args	54.535	4806.886	15.534796
Sum128_Bcl	870.268	301.222	0.973484
Sum128_AdvSimd	97.942	2676.530	8.649955
Sum128_Wasm_CompareGreater	Run fail! Requires hardware support PackedSimd!
Sum128_Wasm_EqualsShift	Run fail! Requires hardware support PackedSimd!
Sum128Traits	54.049	4850.125	15.674534
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	508.704	515.317	1.665392
Sum512Traits	508.746	515.275	1.665256
SumKernelTraits	54.090	4846.437	15.662614
SumKernelTraits_Args0	54.019	4852.808	15.683204
SumKernelTraits_Args	54.016	4853.093	15.684125
SumKernel128_AdvSimd	98.038	2673.903	8.641465
SumKernel128Traits	54.546	4805.883	15.531554
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
# Sum512_Bcl	3280801193489835857
SumScalar	490.418	534.531
SumBase	530.092	494.525	0.925156
SumTraits	107.069	2448.365	4.580395
SumTraits_Args0	106.929	2451.574	4.586398
SumTraits_Args	106.936	2451.414	4.586100
Sum128_Bcl	378.458	692.663	1.295831
Sum128_AdvSimd	196.103	1336.768	2.500821
Sum128Traits	107.258	2444.056	4.572333
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	482.095	543.760	1.017265
Sum512Traits	482.277	543.555	1.016881
SumKernelTraits	107.697	2434.096	4.553700
SumKernelTraits_Args0	107.277	2443.626	4.571529
SumKernelTraits_Args	106.924	2451.680	4.586597
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	195.505	1340.858	2.508473
SumKernel128_Arm_Multiply	615.399	425.974	0.796911
SumKernel128Traits	107.512	2438.271	4.561511
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
# Sum512_Bcl	42
SumScalar	326.226	803.566
SumBase	322.670	812.422	1.011021
SumTraits	13.421	19531.685	24.306252
SumTraits_Args0	13.422	19530.241	24.304455
SumTraits_Args	13.424	19527.338	24.300842
Sum128_Bcl	429.572	610.244	0.759420
Sum128_AdvSimd	16.099	16282.896	20.263288
Sum128Traits	13.413	19544.244	24.321880
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	409.375	640.352	0.796888
Sum512Traits	409.324	640.432	0.796987
SumKernelTraits	13.420	19533.892	24.308997
SumKernelTraits_Args0	13.420	19534.508	24.309764
SumKernelTraits_Args	13.417	19538.006	24.314118
SumKernel128_AdvSimd	16.107	16275.599	20.254207
SumKernel128Traits	13.445	19497.899	24.264207
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
# Sum512_Bcl	9916
SumScalar	13277.083	19.744
SumBase	12941.667	20.256	1.025918
SumTraits	4230.208	61.970	3.138636
SumTraits_Args0	3779.687	69.356	3.512746
SumTraits_Args	3736.979	70.149	3.552892
Sum128_Bcl	2267.708	115.599	5.854846
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	3870.312	67.732	3.430494
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	18039.583	14.532	0.735997
Sum512Traits	20158.333	13.004	0.658640
SumKernelTraits	3250.000	80.660	4.085256
SumKernelTraits_Args0	2775.000	94.466	4.784535
SumKernelTraits_Args	3408.333	76.913	3.895477
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	2745.052	95.497	4.836733
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
# Sum512_Bcl	-1085665694
SumScalar	17483.333	14.994
SumBase	17241.667	15.204	1.014016
SumTraits	4807.813	54.525	3.636442
SumTraits_Args0	5980.729	43.831	2.923278
SumTraits_Args	7494.792	34.977	2.332731
Sum128_Bcl	3766.667	69.596	4.641593
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128_Wasm_CompareGreater	8007.812	32.736	2.183285
Sum128_Wasm_EqualsShift	8516.667	30.780	2.052838
Sum128Traits	3914.062	66.975	4.466800
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	24339.583	10.770	0.718309
Sum512Traits	26491.667	9.895	0.659956
SumKernelTraits	4769.792	54.959	3.665429
SumKernelTraits_Args0	6365.625	41.181	2.746523
SumKernelTraits_Args	7468.750	35.099	2.340865
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	3874.479	67.659	4.512434
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
# Sum512_Bcl	3280801193489835857
SumScalar	42975.000	6.100
SumBase	42937.500	6.105	1.000873
SumTraits	42504.167	6.167	1.011077
SumTraits_Args0	32716.667	8.013	1.313551
SumTraits_Args	33493.750	7.827	1.283075
Sum128_Bcl	55408.333	4.731	0.775605
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	20616.667	12.715	2.084479
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	81041.667	3.235	0.530283
Sum512Traits	40829.167	6.421	1.052556
SumKernelTraits	34575.000	7.582	1.242950
SumKernelTraits_Args0	30085.417	8.713	1.428433
SumKernelTraits_Args	31087.500	8.432	1.382388
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	14283.333	18.353	3.008751
SumKernel256_Avx2_AlignRight	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_DuplicateEven	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
# Sum512_Bcl	42
SumScalar	10175.000	25.764
SumBase	9975.000	26.280	1.020050
SumTraits	998.958	262.417	10.185610
SumTraits_Args0	1317.708	198.939	7.721739
SumTraits_Args	1695.964	154.569	5.999539
Sum128_Bcl	1309.375	200.205	7.770883
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	775.326	338.108	13.123520
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum512_Bcl	13973.958	18.759	0.728140
Sum512Traits	14755.208	17.766	0.689587
SumKernelTraits	1024.349	255.913	9.933138
SumKernelTraits_Args0	1418.880	184.754	7.171148
SumKernelTraits_Args	1689.974	155.117	6.020803
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	805.143	325.587	12.637503
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

```

