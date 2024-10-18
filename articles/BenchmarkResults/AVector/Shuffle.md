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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9232.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks/bin/Release/Release/System.Numerics.Vectors.DLL
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
SumScalar	184.282	1422.518
SumBase	180.950	1448.711	1.018413
SumTraits	183.092	1431.764	1.006500
SumTraits_Args0	188.892	1387.798	0.975592
SumTraits_Args	208.198	1259.111	0.885128
SumKernelTraits	180.817	1449.777	1.019163
SumKernelTraits_Args0	185.598	1412.428	0.992907
SumKernelTraits_Args	192.359	1362.786	0.958010

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	325.974	804.186
SumBase	312.804	838.046	1.042105
SumTraits	312.046	840.081	1.044635
SumTraits_Args0	326.017	804.082	0.999869
SumTraits_Args	346.433	756.694	0.940943
SumKernelTraits	313.346	836.597	1.040302
SumKernelTraits_Args0	323.685	809.875	1.007073
SumKernelTraits_Args	343.955	762.146	0.947724

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	613.983	426.956
SumBase	586.685	446.823	1.046530
SumTraits	586.862	446.688	1.046215
SumTraits_Args0	613.760	427.112	1.000364
SumTraits_Args	635.167	412.717	0.966648
SumKernelTraits	586.951	446.620	1.046055
SumKernelTraits_Args0	618.060	424.140	0.993405
SumKernelTraits_Args	639.215	410.103	0.960526

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	173.771	1508.563
SumBase	168.040	1560.013	1.034106
SumTraits	151.035	1735.648	1.150531
SumTraits_Args0	166.873	1570.920	1.041335
SumTraits_Args	163.486	1603.469	1.062912
SumKernelTraits	165.731	1581.742	1.048509
SumKernelTraits_Args0	152.832	1715.244	1.137005
SumKernelTraits_Args	170.784	1534.947	1.017490

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
SumScalar	183.932	1425.225
SumBase	182.737	1434.544	1.006539
SumTraits	182.137	1439.271	1.009855
SumTraits_Args0	181.724	1442.537	1.012147
SumTraits_Args	186.815	1403.227	0.984565
SumKernelTraits	183.717	1426.888	1.001167
SumKernelTraits_Args0	178.645	1467.398	1.029590
SumKernelTraits_Args	184.450	1421.216	0.997187

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	293.657	892.687
SumBase	294.128	891.260	0.998401
SumTraits	293.221	894.016	1.001489
SumTraits_Args0	293.023	894.619	1.002165
SumTraits_Args	295.238	887.906	0.994645
SumKernelTraits	293.891	891.977	0.999204
SumKernelTraits_Args0	294.232	890.943	0.998047
SumKernelTraits_Args	294.551	889.978	0.996965

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	532.003	492.749
SumBase	528.312	496.192	1.006988
SumTraits	527.239	497.202	1.009037
SumTraits_Args0	529.388	495.184	1.004941
SumTraits_Args	545.247	480.780	0.975711
SumKernelTraits	529.463	495.113	1.004798
SumKernelTraits_Args0	537.456	487.749	0.989854
SumKernelTraits_Args	545.625	480.447	0.975034

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	150.606	1740.591
SumBase	151.966	1725.023	0.991056
SumTraits	151.784	1727.091	0.992244
SumTraits_Args0	174.586	1501.520	0.862649
SumTraits_Args	172.177	1522.525	0.874717
SumKernelTraits	150.651	1740.075	0.999703
SumKernelTraits_Args0	148.457	1765.794	1.014479
SumKernelTraits_Args	157.645	1662.871	0.955348

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
SumScalar	177.990	1472.803
SumBase	185.139	1415.928	0.961383
SumTraits	26.289	9971.759	6.770600
SumTraits_Args0	8.709	30098.814	20.436417
SumTraits_Args	8.636	30353.501	20.609344
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	25.645	10222.173	6.940625
SumKernelTraits	23.007	11393.934	7.736225
SumKernelTraits_Args0	8.669	30240.761	20.532796
SumKernelTraits_Args	8.550	30660.697	20.817923
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	23.543	11134.530	7.560096
SumKernel256_Avx2_ShiftLane	21.291	12312.515	8.359921
SumKernel256Traits	23.340	11231.536	7.625960
SumKernel256Traits_Args0	8.720	30062.185	20.411547
SumKernel256Traits_Args	8.651	30302.632	20.574805

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	292.960	894.813
SumBase	292.290	896.862	1.002291
SumTraits	19.189	13660.990	15.266869
SumTraits_Args0	13.788	19012.799	21.247796
SumTraits_Args	13.909	18846.835	21.062322
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	30.601	8566.445	9.573449
Sum256Traits	17.917	14630.785	16.350666
SumKernelTraits	14.057	18648.987	20.841216
SumKernelTraits_Args0	12.689	20659.517	23.088089
SumKernelTraits_Args	12.746	20567.294	22.985025
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	13.963	18773.567	20.980441
SumKernel256Traits_Args0	13.961	18776.932	20.984202
SumKernel256Traits_Args	13.879	18888.282	21.108640

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	530.739	493.922
SumBase	531.956	492.793	0.997713
SumTraits	61.917	4233.788	8.571770
SumTraits_Args0	27.680	9470.456	19.173978
SumTraits_Args	26.979	9716.510	19.672142
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	61.148	4287.026	8.679554
SumKernelTraits	51.486	5091.536	10.308374
SumKernelTraits_Args0	24.458	10718.333	21.700443
SumKernelTraits_Args	27.154	9653.985	19.545554
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	45.781	5726.068	11.593054
SumKernel256_Avx2_DuplicateEven	43.330	6049.994	12.248877
SumKernel256_Avx2_Multiply	104.947	2497.863	5.057198
SumKernel256_Avx2_ShiftLane	45.225	5796.478	11.735606
SumKernel256Traits	43.576	6015.722	12.179490
SumKernel256Traits_Args0	24.568	10669.976	21.602538
SumKernel256Traits_Args	24.276	10798.570	21.862890

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	166.550	1573.962
SumBase	167.149	1568.324	0.996418
SumTraits	12.417	21111.471	13.412952
SumTraits_Args0	4.378	59875.540	38.041296
SumTraits_Args	4.389	59733.275	37.950909
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	12.501	20970.513	13.323395
Sum256_Avx2_Add2	12.474	21014.637	13.351429
Sum256_Avx2_Cmp2	11.448	22898.688	14.548441
Sum256_Avx2_EqualAnd	10.970	23895.964	15.182050
Sum256Traits	11.588	22621.901	14.372587
SumKernelTraits	7.827	33493.746	21.279900
SumKernelTraits_Args0	4.422	59278.089	37.661712
SumKernelTraits_Args	4.389	59726.595	37.946665
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	8.038	32611.522	20.719388
SumKernel256Traits_Args0	4.379	59863.092	38.033387
SumKernel256Traits_Args	4.398	59609.252	37.872113

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
SumScalar	177.928	1473.315
SumBase	175.403	1494.525	1.014396
SumTraits	19.758	13268.039	9.005565
SumTraits_Args0	8.666	30250.367	20.532172
SumTraits_Args	8.681	30196.732	20.495768
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	16.857	15551.307	10.555314
SumKernelTraits	17.538	14947.309	10.145355
SumKernelTraits_Args0	8.644	30326.507	20.583851
SumKernelTraits_Args	8.581	30550.198	20.735680
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	15.575	16831.498	11.424232
SumKernel256_Avx2_ShiftLane	15.766	16627.347	11.285666
SumKernel256Traits	15.518	16892.749	11.465805
SumKernel256Traits_Args0	8.634	30362.993	20.608616
SumKernel256Traits_Args	8.567	30599.660	20.769252

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	291.493	899.316
SumBase	290.661	901.891	1.002862
SumTraits	19.123	13707.980	15.242668
SumTraits_Args0	13.696	19140.684	21.283595
SumTraits_Args	13.464	19469.295	21.648995
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	20.043	13078.901	14.543160
Sum256Traits	14.249	18397.923	20.457678
SumKernelTraits	14.759	17761.910	19.750460
SumKernelTraits_Args0	13.799	18997.604	21.124497
SumKernelTraits_Args	12.772	20524.262	22.822073
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	12.671	20687.968	23.004106
SumKernel256Traits_Args0	12.675	20682.753	22.998307
SumKernel256Traits_Args	12.613	20784.445	23.111384

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	505.386	518.700
SumBase	509.338	514.676	0.992241
SumTraits	50.745	5165.905	9.959324
SumTraits_Args0	27.029	9698.777	18.698227
SumTraits_Args	25.966	10095.789	19.463624
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	39.545	6629.039	12.780094
SumKernelTraits	37.005	7083.997	13.657205
SumKernelTraits_Args0	26.685	9823.691	18.939047
SumKernelTraits_Args	24.270	10801.071	20.823334
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	39.267	6675.896	12.870430
SumKernel256_Avx2_DuplicateEven	35.045	7480.263	14.421163
SumKernel256_Avx2_Multiply	76.416	3430.504	6.613653
SumKernel256_Avx2_ShiftLane	35.023	7484.828	14.429965
SumKernel256Traits	35.616	7360.212	14.189718
SumKernel256Traits_Args0	26.657	9833.927	18.958782
SumKernel256Traits_Args	26.438	9915.397	19.115848

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	149.075	1758.471
SumBase	149.065	1758.584	1.000064
SumTraits	8.744	29979.487	17.048613
SumTraits_Args0	4.411	59436.269	33.799975
SumTraits_Args	4.339	60414.526	34.356287
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	7.959	32938.002	18.731049
Sum256_Avx2_Add2	8.444	31046.580	17.655443
Sum256_Avx2_Cmp2	7.333	35747.013	20.328466
Sum256_Avx2_EqualAnd	7.595	34515.098	19.627905
Sum256Traits	8.175	32066.393	18.235386
SumKernelTraits	6.433	40749.480	23.173248
SumKernelTraits_Args0	4.332	60513.059	34.412320
SumKernelTraits_Args	4.365	60057.090	34.153022
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	5.572	47050.810	26.756663
SumKernel256Traits_Args0	4.369	60001.820	34.121591
SumKernel256Traits_Args	4.321	60666.465	34.499558

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.29
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.29\
RuntimeInformation.FrameworkDescription:	.NET 6.0.29
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.29/System.Private.CoreLib.dll
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
SumScalar	176.060	1488.951
SumBase	173.187	1513.646	1.016585
SumTraits	19.355	13544.158	9.096443
SumTraits_Args0	8.572	30582.273	20.539474
SumTraits_Args	8.612	30439.655	20.443690
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	16.502	15885.764	10.669097
SumKernelTraits	17.335	15122.352	10.156379
SumKernelTraits_Args0	8.582	30544.781	20.514294
SumKernelTraits_Args	8.609	30449.549	20.450335
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	14.618	17932.778	12.043900
SumKernel256_Avx2_ShiftLane	15.359	17068.123	11.463185
SumKernel256Traits	15.302	17131.463	11.505725
SumKernel256Traits_Args0	8.634	30363.147	20.392306
SumKernel256Traits_Args	8.672	30229.417	20.302491

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	291.794	898.388
SumBase	290.094	903.653	1.005860
SumTraits	18.905	13866.088	15.434408
SumTraits_Args0	13.381	19590.409	21.806176
SumTraits_Args	13.535	19367.293	21.557824
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	16.568	15822.008	17.611551
Sum256Traits	13.867	18904.131	21.042277
SumKernelTraits	14.513	18062.922	20.105923
SumKernelTraits_Args0	12.330	21259.832	23.664419
SumKernelTraits_Args	12.465	21030.276	23.408899
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	13.582	19301.492	21.484581
SumKernel256Traits_Args0	12.382	21170.547	23.565035
SumKernel256Traits_Args	13.759	19053.240	21.208250

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	505.965	518.107
SumBase	507.094	516.953	0.997773
SumTraits	50.154	5226.817	10.088298
SumTraits_Args0	25.728	10188.867	19.665569
SumTraits_Args	26.020	10074.866	19.445537
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	39.925	6565.947	12.672959
SumKernelTraits	36.962	7092.205	13.688692
SumKernelTraits_Args0	24.303	10786.653	20.819359
SumKernelTraits_Args	24.403	10742.495	20.734129
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	39.266	6676.105	12.885574
SumKernel256_Avx2_DuplicateEven	34.800	7532.930	14.539336
SumKernel256_Avx2_Multiply	70.812	3701.997	7.145238
SumKernel256_Avx2_ShiftLane	34.527	7592.366	14.654055
SumKernel256Traits	35.013	7487.076	14.450834
SumKernel256Traits_Args0	24.036	10906.295	21.050280
SumKernel256Traits_Args	24.097	10878.685	20.996991

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	145.807	1797.883
SumBase	145.740	1798.708	1.000459
SumTraits	8.606	30462.345	16.943451
SumTraits_Args0	4.360	60123.303	33.441164
SumTraits_Args	4.380	59856.021	33.292499
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Avx2_Add1	7.219	36314.551	20.198505
Sum256_Avx2_Add2	8.381	31279.709	17.398077
Sum256_Avx2_Cmp2	6.373	41131.437	22.877704
Sum256_Avx2_EqualAnd	7.490	35001.060	19.467929
Sum256Traits	7.336	35733.263	19.875187
SumKernelTraits	6.290	41676.201	23.180707
SumKernelTraits_Args0	4.299	60979.979	33.917655
SumKernelTraits_Args	4.316	60735.367	33.781599
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	5.498	47680.664	26.520447
SumKernel256Traits_Args0	4.290	61110.314	33.990148
SumKernel256Traits_Args	4.348	60284.974	33.531086

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.18
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.18\
RuntimeInformation.FrameworkDescription:	.NET 7.0.18
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.18/System.Private.CoreLib.dll
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
SumScalar	175.578	1493.037
SumBase	172.346	1521.032	1.018750
SumTraits	16.659	15735.949	10.539557
SumTraits_Args0	8.610	30447.161	20.392771
SumTraits_Args	8.704	30119.309	20.173184
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	216.208	1212.463	0.812078
Sum256Traits	11.955	21928.142	14.686939
SumKernelTraits	13.321	19678.576	13.180234
SumKernelTraits_Args0	8.662	30262.467	20.269067
SumKernelTraits_Args	8.728	30035.773	20.117233
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	10.075	26018.877	17.426814
SumKernel256_Avx2_ShiftLane	14.892	17603.410	11.790337
SumKernel256Traits	9.916	26437.656	17.707302
SumKernel256Traits_Args0	8.630	30377.195	20.345909
SumKernel256Traits_Args	8.626	30390.346	20.354718

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	285.178	919.230
SumBase	285.437	918.395	0.999092
SumTraits	13.960	18778.093	20.428057
SumTraits_Args0	13.453	19486.247	21.198435
SumTraits_Args	13.328	19668.969	21.397212
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	314.895	832.481	0.905628
Sum256_Avx2_Add1	15.983	16401.682	17.842840
Sum256Traits	19.759	13267.158	14.432896
SumKernelTraits	13.291	19723.568	21.456608
SumKernelTraits_Args0	12.725	20600.643	22.410749
SumKernelTraits_Args	13.353	19631.276	21.356207
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	12.517	20943.039	22.783230
SumKernel256Traits_Args0	13.414	19542.475	21.259603
SumKernel256Traits_Args	12.786	20502.156	22.303608

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	636.255	412.011
SumBase	502.139	522.054	1.267089
SumTraits	48.807	5371.010	13.036085
SumTraits_Args0	26.029	10071.276	24.444192
SumTraits_Args	25.884	10127.661	24.581047
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	490.150	534.824	1.298081
Sum256Traits	36.133	7254.956	17.608647
SumKernelTraits	34.682	7558.459	18.345285
SumKernelTraits_Args0	24.249	10810.434	26.238217
SumKernelTraits_Args	24.142	10858.436	26.354723
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	39.321	6666.708	16.180898
SumKernel256_Avx2_DuplicateEven	30.526	8587.629	20.843204
SumKernel256_Avx2_Multiply	74.717	3508.487	8.515518
SumKernel256_Avx2_ShiftLane	30.703	8538.166	20.723151
SumKernel256Traits	31.209	8399.513	20.386624
SumKernel256Traits_Args0	24.205	10830.029	26.285778
SumKernel256Traits_Args	24.517	10692.502	25.951982

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
SumScalar	136.683	1917.897
SumBase	148.741	1762.422	0.918935
SumTraits	6.961	37657.383	19.634731
SumTraits_Args0	4.590	57113.522	29.779250
SumTraits_Args	4.583	57196.261	29.822390
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	197.875	1324.799	0.690756
Sum256_Avx2_Add1	6.354	41259.317	21.512795
Sum256_Avx2_Add2	6.650	39419.532	20.553523
Sum256_Avx2_Cmp2	6.006	43644.527	22.756454
Sum256_Avx2_EqualAnd	7.352	35655.625	18.591005
Sum256Traits	5.908	44371.961	23.135742
SumKernelTraits	5.190	50510.992	26.336661
SumKernelTraits_Args0	4.580	57235.870	29.843043
SumKernelTraits_Args	4.510	58128.548	30.308489
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	4.745	55251.438	28.808351
SumKernel256Traits_Args0	4.599	57000.551	29.720346
SumKernel256Traits_Args	4.534	57817.631	30.146376

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.4
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.4\
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.4/System.Private.CoreLib.dll
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
SumScalar	178.595	1467.810
SumBase	178.458	1468.943	1.000772
SumTraits	6.308	41559.229	28.313760
SumTraits_Args0	6.315	41508.057	28.278896
SumTraits_Args	6.282	41731.523	28.431141
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	218.783	1198.194	0.816314
Sum256Traits	6.330	41415.508	28.215844
Sum512_Bcl	201.580	1300.448	0.885978
Sum512Traits	7.415	35351.213	24.084319
SumKernelTraits	5.832	44948.076	30.622536
SumKernelTraits_Args0	5.866	44689.367	30.446281
SumKernelTraits_Args	5.832	44946.794	30.621663
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_Multiply	5.826	44997.356	30.656111
SumKernel256_Avx2_ShiftLane	8.554	30645.802	20.878584
SumKernel256Traits	5.948	44075.603	30.028132
SumKernel256Traits_Args0	5.957	44008.533	29.982438
SumKernel256Traits_Args	5.932	44192.938	30.108071

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
# Sum512_Bcl	1243037409
SumScalar	305.789	857.271
SumBase	304.205	861.736	1.005209
SumTraits	13.996	18729.386	21.847692
SumTraits_Args0	13.887	18876.261	22.019021
SumTraits_Args	13.801	18994.916	22.157430
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	321.931	814.286	0.949858
Sum256_Avx2_Add1	13.840	18940.789	22.094292
Sum256Traits	13.767	19041.985	22.212336
Sum512_Bcl	230.947	1135.085	1.324068
Sum512Traits	15.450	16967.385	19.792331
SumKernelTraits	13.207	19849.274	23.154033
SumKernelTraits_Args0	13.306	19700.994	22.981065
SumKernelTraits_Args	13.304	19704.538	22.985200
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	13.249	19786.469	23.080771
SumKernel256Traits_Args0	13.206	19850.899	23.155929
SumKernel256Traits_Args	13.291	19724.046	23.007956

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
# Sum512_Bcl	3381896767018454368
SumScalar	535.591	489.448
SumBase	529.207	495.353	1.012063
SumTraits	25.667	10213.164	20.866689
SumTraits_Args0	26.215	9999.683	20.430524
SumTraits_Args	25.621	10231.667	20.904494
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	510.415	513.590	1.049324
Sum256Traits	25.892	10124.575	20.685693
Sum512_Bcl	354.078	740.357	1.512636
Sum512Traits	30.105	8707.517	17.790478
SumKernelTraits	24.616	10649.443	21.758059
SumKernelTraits_Args0	24.478	10709.271	21.880294
SumKernelTraits_Args	24.253	10808.806	22.083656
SumKernel128_Sse_DuplicateEven	Run fail! Vector byte size mismatch(32!=16) !
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128_Arm_Multiply	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256_Avx2_AlignRight	24.451	10721.387	21.905049
SumKernel256_Avx2_DuplicateEven	24.303	10786.676	22.038441
SumKernel256_Avx2_Multiply	24.639	10639.538	21.737822
SumKernel256_Avx2_ShiftLane	24.242	10813.702	22.093659
SumKernel256Traits	24.315	10781.117	22.027084
SumKernel256Traits_Args0	24.178	10842.443	22.152380
SumKernel256Traits_Args	24.320	10779.118	22.023000

[ShuffleBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	114
# Sum512_Bcl	67
SumScalar	163.288	1605.408
SumBase	139.556	1878.416	1.170055
SumTraits	4.904	53450.140	33.293801
SumTraits_Args0	3.275	80050.733	49.863165
SumTraits_Args	3.196	82026.989	51.094164
Sum128_Bcl	Run fail! Vector byte size mismatch(32!=16) !
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_Bcl	198.932	1317.756	0.820823
Sum256_Avx2_Add1	3.429	76458.510	47.625590
Sum256_Avx2_Add2	4.882	53694.122	33.445776
Sum256_Avx2_Cmp2	3.409	76907.231	47.905095
Sum256_Avx2_EqualAnd	3.373	77714.067	48.407669
Sum256Traits	3.219	81435.365	50.725645
Sum512_Bcl	198.246	1322.314	0.823662
Sum512Traits	3.769	69548.002	43.321072
SumKernelTraits	2.959	88600.601	55.188832
SumKernelTraits_Args0	2.990	87674.417	54.611917
SumKernelTraits_Args	2.987	87764.502	54.668031
SumKernel128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumKernel128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumKernel256Traits	2.990	87684.127	54.617965
SumKernel256Traits_Args0	2.947	88950.043	55.406497
SumKernel256Traits_Args	2.982	87894.732	54.749150

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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	616.811	424.999
SumBase	615.839	425.670	1.001579
SumTraits	616.356	425.313	1.000739
SumTraits_Args0	617.147	424.768	0.999456
SumTraits_Args	654.385	400.596	0.942581
Sum128Traits	1099.483	238.425	0.561001
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	616.730	425.055	1.000132
SumKernelTraits_Args0	617.168	424.753	0.999421
SumKernelTraits_Args	653.966	400.853	0.943186
SumKernel128Traits	1097.558	238.843	0.561985
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	910.307	287.973
SumBase	910.714	287.844	0.999553
SumTraits	909.823	288.127	1.000533
SumTraits_Args0	912.611	287.246	0.997476
SumTraits_Args	976.044	268.578	0.932649
Sum128Traits	1710.963	153.214	0.532044
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	911.301	287.659	0.998909
SumKernelTraits_Args0	914.994	286.498	0.994878
SumKernelTraits_Args	976.323	268.501	0.932383
SumKernel128Traits	1711.604	153.157	0.531844
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	689.909	379.969
SumBase	691.070	379.331	0.998320
SumTraits	1421.285	184.441	0.485412
SumTraits_Args0	691.955	378.846	0.997043
SumTraits_Args	780.673	335.792	0.883736
Sum128Traits	1263.049	207.549	0.546225
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	1437.279	182.389	0.480010
SumKernelTraits_Args0	1452.005	180.539	0.475142
SumKernelTraits_Args	781.530	335.424	0.882767
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128Traits	1784.680	146.886	0.386573
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
SumScalar	392.752	667.455
SumBase	404.302	648.386	0.971431
SumTraits	392.626	667.668	1.000319
SumTraits_Args0	394.151	665.086	0.996450
SumTraits_Args	418.639	626.181	0.938162
Sum128Traits	655.393	399.980	0.599261
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	404.260	648.453	0.971531
SumKernelTraits_Args0	394.141	665.102	0.996474
SumKernelTraits_Args	419.458	624.959	0.936332
SumKernel128Traits	655.176	400.112	0.599459
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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	619.406	423.218
SumBase	620.404	422.538	0.998391
SumTraits	55.779	4699.731	11.104740
SumTraits_Args0	31.097	8429.938	19.918646
SumTraits_Args	88.000	2978.896	7.038671
Sum128_AdvSimd	83.197	3150.881	7.445048
Sum128Traits	52.628	4981.104	11.769581
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	49.647	5280.154	12.476190
SumKernelTraits_Args0	31.086	8432.769	19.925335
SumKernelTraits_Args	88.083	2976.102	7.032070
SumKernel128_AdvSimd	88.447	2963.866	7.003159
SumKernel128Traits	39.994	6554.537	15.487362
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	933.150	280.924
SumBase	932.177	281.217	1.001044
SumTraits	106.972	2450.585	8.723313
SumTraits_Args0	63.143	4151.578	14.778312
SumTraits_Args	176.614	1484.278	5.283563
Sum128_AdvSimd	193.279	1356.297	4.827990
Sum128Traits	99.971	2622.213	9.334254
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	98.790	2653.535	9.445749
SumKernelTraits_Args0	67.029	3910.887	13.921528
SumKernelTraits_Args	176.745	1483.173	5.279628
SumKernel128_AdvSimd	181.766	1442.208	5.133807
SumKernel128Traits	80.434	3259.100	11.601370
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	595.134	440.479
SumBase	637.491	411.212	0.933556
SumTraits	258.837	1012.778	2.299264
SumTraits_Args0	133.487	1963.813	4.458355
SumTraits_Args	365.598	717.028	1.627836
Sum128_AdvSimd	442.494	592.424	1.344953
Sum128Traits	213.462	1228.061	2.788012
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	215.325	1217.434	2.763886
SumKernelTraits_Args0	124.826	2100.070	4.767695
SumKernelTraits_Args	353.480	741.609	1.683642
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	281.394	931.591	2.114950
SumKernel128_Arm_Multiply	559.239	468.751	1.064185
SumKernel128Traits	179.917	1457.029	3.307827
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
SumScalar	396.685	660.836
SumBase	405.632	646.261	0.977945
SumTraits	16.824	15581.384	23.578286
SumTraits_Args0	15.674	16724.814	25.308565
SumTraits_Args	44.125	5940.901	8.989976
Sum128_AdvSimd	22.330	11739.301	17.764314
Sum128Traits	16.642	15752.275	23.836885
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	19.966	13129.238	19.867616
SumKernelTraits_Args0	16.661	15734.005	23.809238
SumKernelTraits_Args	45.762	5728.363	8.668356
SumKernel128_AdvSimd	23.304	11248.646	17.021838
SumKernel128Traits	15.643	16757.494	25.358017
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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	625.491	419.101
SumBase	621.037	422.107	1.007173
SumTraits	47.404	5530.044	13.195015
SumTraits_Args0	31.746	8257.430	19.702719
SumTraits_Args	91.421	2867.447	6.841899
Sum128_AdvSimd	84.503	3102.195	7.402021
Sum128Traits	47.420	5528.097	13.190369
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	40.393	6489.835	15.485133
SumKernelTraits_Args0	33.721	7773.929	18.549057
SumKernelTraits_Args	88.040	2977.539	7.104585
SumKernel128_AdvSimd	78.230	3350.936	7.995533
SumKernel128Traits	40.502	6472.303	15.443300
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	931.651	281.376
SumBase	932.271	281.189	0.999335
SumTraits	107.104	2447.558	8.698541
SumTraits_Args0	67.759	3868.791	13.749556
SumTraits_Args	176.148	1488.202	5.289020
Sum128_AdvSimd	168.623	1554.618	5.525063
Sum128Traits	94.959	2760.609	9.811112
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	81.112	3231.874	11.485973
SumKernelTraits_Args0	67.666	3874.060	13.768284
SumKernelTraits_Args	177.073	1480.430	5.261398
SumKernel128_AdvSimd	156.738	1672.496	5.943996
SumKernel128Traits	81.125	3231.342	11.484082
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	591.619	443.096
SumBase	591.790	442.968	0.999711
SumTraits	244.940	1070.236	2.415359
SumTraits_Args0	126.658	2069.707	4.671013
SumTraits_Args	352.933	742.759	1.676294
Sum128_AdvSimd	488.464	536.670	1.211182
Sum128Traits	243.124	1078.230	2.433400
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	186.126	1408.426	3.178603
SumKernelTraits_Args0	134.232	1952.918	4.407438
SumKernelTraits_Args	352.611	743.436	1.677822
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	293.744	892.424	2.014065
SumKernel128_Arm_Multiply	535.941	489.128	1.103888
SumKernel128Traits	177.965	1473.008	3.324355
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
SumScalar	398.195	658.330
SumBase	396.845	660.571	1.003403
SumTraits	15.678	16720.691	25.398634
SumTraits_Args0	16.666	15729.294	23.892707
SumTraits_Args	44.026	5954.235	9.044449
Sum128_AdvSimd	22.357	11725.385	17.810794
Sum128Traits	15.640	16761.213	25.460187
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	15.705	16691.707	25.354607
SumKernelTraits_Args0	16.703	15694.804	23.840318
SumKernelTraits_Args	44.130	5940.288	9.023264
SumKernel128_AdvSimd	22.317	11746.544	17.842934
SumKernel128Traits	15.649	16751.903	25.446045
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


[ShuffleBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-24614
SumScalar	497.144	527.300
SumBase	497.321	527.113	0.999644
SumTraits	44.659	5869.854	11.131896
SumTraits_Args0	26.366	9942.485	18.855445
SumTraits_Args	26.423	9921.169	18.815021
Sum128_Bcl	544.017	481.867	0.913838
Sum128_AdvSimd	84.246	3111.658	5.901110
Sum128Traits	44.596	5878.244	11.147807
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	32.910	7965.363	15.105928
SumKernelTraits_Args0	26.354	9946.938	18.863889
SumKernelTraits_Args	26.431	9918.004	18.809019
SumKernel128_AdvSimd	66.007	3971.472	7.531706
SumKernel128Traits	32.903	7967.252	15.109510
SumKernel256_Avx2_Multiply	Run fail! Requires hardware support Avx, Avx2!
SumKernel256_Avx2_ShiftLane	Run fail! Requires hardware support Avx, Avx2!
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-467755046
SumScalar	828.119	316.554
SumBase	824.842	317.811	1.003972
SumTraits	89.720	2921.792	9.230006
SumTraits_Args0	53.894	4864.057	15.365664
SumTraits_Args	54.316	4826.316	15.246439
Sum128_Bcl	865.478	302.889	0.956834
Sum128_AdvSimd	164.700	1591.645	5.028043
Sum128Traits	89.766	2920.299	9.225291
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	66.926	3916.923	12.373647
SumKernelTraits_Args0	54.153	4840.789	15.292160
SumKernelTraits_Args	54.389	4819.802	15.225861
SumKernel128_AdvSimd	132.338	1980.863	6.257592
SumKernel128Traits	66.776	3925.725	12.401453
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

[ShuffleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5910372263572008452
SumScalar	474.688	552.245
SumBase	474.921	551.973	0.999509
SumTraits	208.920	1254.759	2.272107
SumTraits_Args0	106.400	2463.769	4.461372
SumTraits_Args	106.898	2452.291	4.440588
Sum128_Bcl	368.006	712.337	1.289893
Sum128_AdvSimd	433.577	604.608	1.094819
Sum128Traits	206.984	1266.492	2.293353
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	148.299	1767.667	3.200876
SumKernelTraits_Args0	106.351	2464.893	4.463407
SumKernelTraits_Args	106.966	2450.730	4.437762
SumKernel128_Sse_DuplicateEven	Run fail! Requires hardware support Sse, Sse2!
SumKernel128_AdvSimd	286.575	914.749	1.656420
SumKernel128_Arm_Multiply	460.697	569.016	1.030370
SumKernel128Traits	148.519	1765.059	3.196154
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
SumScalar	314.410	833.764
SumBase	313.910	835.092	1.001592
SumTraits	13.274	19748.119	23.685489
SumTraits_Args0	13.278	19742.430	23.678666
SumTraits_Args	13.318	19683.036	23.607430
Sum128_Bcl	403.810	649.177	0.778610
Sum128_AdvSimd	19.945	13143.611	15.764178
Sum128Traits	13.254	19779.062	23.722602
Sum256_Bcl	Run fail! Vector byte size mismatch(16!=32) !
Sum256_Avx2_Add1	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Add2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_Cmp2	Run fail! Requires hardware support Avx, Avx2!
Sum256_Avx2_EqualAnd	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernelTraits	13.285	19731.858	23.665986
SumKernelTraits_Args0	13.305	19702.186	23.630398
SumKernelTraits_Args	13.327	19669.480	23.591171
SumKernel128_AdvSimd	19.959	13134.187	15.752875
SumKernel128Traits	13.263	19765.379	23.706190
SumKernel256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args0	Run fail! Vector byte size mismatch(16!=32) !
SumKernel256Traits_Args	Run fail! Vector byte size mismatch(16!=32) !

```

