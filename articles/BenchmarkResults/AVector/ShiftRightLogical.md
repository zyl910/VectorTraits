# Benchmark - ShiftRightLogical
([← Back](README.md))

See [Group](ShiftRightLogical.md)
- `ShiftRightLogical[/_Args/_Core/_Const/_ConstCore/_Fast]`: Shifts (unsigned) each element of a vector right by the specified amount (将向量的每个无符号元素逻辑右移指定量).
  Mnemonic: `rt[i] := value[i] >>> shiftAmount`, `shiftAmount &= (T.BitSize-1)`.

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	244.663	1071.450
SumSRL_Basic	68.275	3839.507	3.583470
SumSRL_Base_Core	67.318	3894.138	3.634458
SumSRLTraits	68.008	3854.585	3.597542
SumSRLTraits_Core	68.003	3854.872	3.597810
SumSRLConstTraits	66.817	3923.294	3.661669
SumSRLConstTraits_Core	66.724	3928.770	3.666780
SumSRLFastTraits	66.088	3966.581	3.702070

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	208.947	1254.596
SumSRL_Basic	136.641	1918.488	1.529168
SumSRL_Base_Core	136.619	1918.802	1.529418
SumSRLTraits	134.558	1948.179	1.552833
SumSRLTraits_Core	136.318	1923.033	1.532791
SumSRLConstTraits	134.509	1948.901	1.553409
SumSRLConstTraits_Core	133.530	1963.184	1.564793
SumSRLFastTraits	133.442	1964.476	1.565823

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	191.632	1367.956
SumSRL_Basic	273.767	957.543	0.699981
SumSRL_Base_Core	272.866	960.705	0.702292
SumSRLTraits	274.768	954.057	0.697433
SumSRLTraits_Core	273.027	960.141	0.701880
SumSRLConstTraits	268.464	976.460	0.713810
SumSRLConstTraits_Core	267.148	981.270	0.717326
SumSRLFastTraits	268.008	978.120	0.715023

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	196.258	1335.712
SumSRL_Basic	548.439	477.982	0.357848
SumSRL_Base_Core	541.805	483.834	0.362230
SumSRLTraits	546.356	479.804	0.359213
SumSRLTraits_Core	545.905	480.201	0.359510
SumSRLConstTraits	510.240	513.766	0.384638
SumSRLConstTraits_Core	511.440	512.561	0.383736
SumSRLFastTraits	509.120	514.896	0.385485

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	257.839	1016.697
SumSRL_Basic	71.373	3672.868	3.612549
SumSRL_Base_Core	71.173	3683.206	3.622717
SumSRLTraits	71.580	3662.265	3.602121
SumSRLTraits_Core	70.896	3697.576	3.636851
SumSRLConstTraits	65.189	4021.272	3.955231
SumSRLConstTraits_Core	65.267	4016.501	3.950539
SumSRLFastTraits	64.908	4038.706	3.972379

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	225.640	1161.779
SumSRL_Basic	142.821	1835.475	1.579883
SumSRL_Base_Core	143.752	1823.582	1.569645
SumSRLTraits	142.225	1843.168	1.586504
SumSRLTraits_Core	141.843	1848.126	1.590772
SumSRLConstTraits	129.752	2020.348	1.739012
SumSRLConstTraits_Core	129.658	2021.805	1.740265
SumSRLFastTraits	130.313	2011.653	1.731528

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	201.469	1301.164
SumSRL_Basic	285.930	916.812	0.704609
SumSRL_Base_Core	285.861	917.034	0.704780
SumSRLTraits	282.618	927.557	0.712867
SumSRLTraits_Core	288.000	910.222	0.699544
SumSRLConstTraits	259.524	1010.097	0.776303
SumSRLConstTraits_Core	258.020	1015.983	0.780827
SumSRLFastTraits	262.246	999.612	0.768245

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	198.556	1320.254
SumSRL_Basic	528.761	495.771	0.375512
SumSRL_Base_Core	532.728	492.078	0.372715
SumSRLTraits	526.896	497.525	0.376841
SumSRLTraits_Core	534.412	490.528	0.371540
SumSRLConstTraits	494.142	530.503	0.401819
SumSRLConstTraits_Core	494.593	530.020	0.401453
SumSRLFastTraits	497.143	527.301	0.399393

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	205.765	1273.997
SumSRL_Basic	64.053	4092.590	3.212403
SumSRL_Base_Core	64.030	4094.072	3.213566
SumSRL_Avx2	9.546	27459.932	21.554165
SumSRLTraits	9.464	27698.459	21.741391
SumSRLTraits_Core	4.826	54318.092	42.635979
SumSRLConstTraits	7.955	32953.039	25.865877
SumSRLConstTraits_Core	4.627	56659.658	44.473947
SumSRL128Traits	18.606	14089.082	11.058963
SumSRL128Traits_Core	7.327	35778.968	28.084038
SumSRL128ConstTraits	15.204	17242.305	13.534027
SumSRL128ConstTraits_Core	7.361	35612.483	27.953358
SumSRLFast_Avx2	7.696	34064.026	26.737926
SumSRLFastTraits	7.708	34009.663	26.695255

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	180.519	1452.172
SumSRL_Basic	128.946	2032.977	1.399956
SumSRL_Base_Core	128.862	2034.294	1.400863
SumSRL_Avx2	10.168	25781.614	17.753826
SumSRLTraits	10.232	25620.862	17.643128
SumSRLTraits_Core	7.391	35468.107	24.424173
SumSRLConstTraits	9.542	27472.547	18.918242
SumSRLConstTraits_Core	8.655	30288.080	20.857084
SumSRL128Traits	19.033	13773.261	9.484591
SumSRL128Traits_Core	14.159	18514.880	12.749781
SumSRL128ConstTraits	18.101	14482.487	9.972981
SumSRL128ConstTraits_Core	13.411	19547.279	13.460716
SumSRLFast_Avx2	9.269	28280.799	19.474823
SumSRLFastTraits	9.109	28777.743	19.817030

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	174.550	1501.828
SumSRL_Basic	259.926	1008.531	0.671536
SumSRL_Base_Core	259.148	1011.560	0.673552
SumSRL_Avx2	20.071	13060.531	8.696420
SumSRLTraits	20.069	13062.138	8.697490
SumSRLTraits_Core	18.203	14401.145	9.589075
SumSRLConstTraits	20.201	12976.550	8.640501
SumSRLConstTraits_Core	16.113	16269.516	10.833139
SumSRL128Traits	36.350	7211.591	4.801874
SumSRL128Traits_Core	28.517	9192.591	6.120933
SumSRL128ConstTraits	38.099	6880.585	4.581472
SumSRL128ConstTraits_Core	25.845	10142.877	6.753685
SumSRLFast_Avx2	20.310	12907.105	8.594261
SumSRLFastTraits	19.429	13492.599	8.984115

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	171.309	1530.239
SumSRL_Basic	501.088	523.150	0.341875
SumSRL_Base_Core	504.291	519.827	0.339703
SumSRL_Avx2	39.239	6680.672	4.365771
SumSRLTraits	37.873	6921.715	4.523291
SumSRLTraits_Core	35.024	7484.619	4.891145
SumSRLConstTraits	39.550	6628.095	4.331413
SumSRLConstTraits_Core	32.660	8026.545	5.245290
SumSRL128Traits	72.101	3635.775	2.375953
SumSRL128Traits_Core	48.646	5388.843	3.521570
SumSRL128ConstTraits	70.614	3712.366	2.426005
SumSRL128ConstTraits_Core	52.234	5018.612	3.279627
SumSRLFast_Avx2	33.019	7939.279	5.188262
SumSRLFastTraits	36.232	7235.105	4.728089

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	206.043	1272.279
SumSRL_Basic	66.941	3916.065	3.077991
SumSRL_Base_Core	67.021	3911.362	3.074295
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	9.889	26508.358	20.835328
SumSRLTraits	9.339	28069.566	22.062422
SumSRLTraits_Core	4.076	64315.896	50.551707
SumSRLConstTraits	4.609	56872.527	44.701287
SumSRLConstTraits_Core	3.936	66593.174	52.341627
SumSRL128Traits	18.567	14118.663	11.097140
SumSRL128Traits_Core	7.252	36145.991	28.410419
SumSRL128ConstTraits	8.319	31510.477	24.766947
SumSRL128ConstTraits_Core	7.616	34420.833	27.054460
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	5.067	51738.033	40.665622
SumSRLFastTraits	5.123	51167.202	40.216954

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	195.706	1339.479
SumSRL_Basic	133.779	1959.531	1.462906
SumSRL_Base_Core	133.991	1956.428	1.460589
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	9.904	26469.444	19.761004
SumSRLTraits	9.254	28328.689	21.149041
SumSRLTraits_Core	6.706	39089.479	29.182607
SumSRLConstTraits	7.017	37360.705	27.891974
SumSRLConstTraits_Core	6.906	37956.778	28.336978
SumSRL128Traits	20.123	13027.141	9.725531
SumSRL128Traits_Core	13.557	19336.784	14.436052
SumSRL128ConstTraits	13.952	18789.528	14.027493
SumSRL128ConstTraits_Core	14.074	18625.629	13.905133
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	6.512	40254.330	30.052237
SumSRLFastTraits	6.931	37820.967	28.235587

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	170.982	1533.168
SumSRL_Basic	268.970	974.623	0.635692
SumSRL_Base_Core	269.986	970.955	0.633300
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	19.806	13235.603	8.632844
SumSRLTraits	20.931	12523.984	8.168695
SumSRLTraits_Core	15.278	17158.387	11.191456
SumSRLConstTraits	15.436	16982.393	11.076665
SumSRLConstTraits_Core	15.503	16909.688	11.029244
SumSRL128Traits	38.097	6880.901	4.488027
SumSRL128Traits_Core	24.812	10565.325	6.891171
SumSRL128ConstTraits	28.698	9134.580	5.957976
SumSRL128ConstTraits_Core	28.013	9357.837	6.103594
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	17.832	14701.111	9.588712
SumSRLFastTraits	15.501	16911.852	11.030655

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	172.169	1522.594
SumSRL_Basic	520.180	503.949	0.330980
SumSRL_Base_Core	522.129	502.068	0.329745
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	38.412	6824.523	4.482170
SumSRLTraits	38.012	6896.360	4.529351
SumSRLTraits_Core	27.431	9556.599	6.276527
SumSRLConstTraits	37.743	6945.512	4.561632
SumSRLConstTraits_Core	29.009	9036.565	5.934982
SumSRL128Traits	73.630	3560.299	2.338312
SumSRL128Traits_Core	53.644	4886.756	3.209495
SumSRL128ConstTraits	68.591	3821.824	2.510075
SumSRL128ConstTraits_Core	49.163	5332.192	3.502046
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	31.747	8257.378	5.423232
SumSRLFastTraits	32.387	8094.199	5.316060

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	190.377	1376.976
SumSRL_Basic	64.104	4089.363	2.969815
SumSRL_Base_Core	64.784	4046.455	2.938654
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	9.279	28252.736	20.517964
SumSRLTraits	9.791	26773.205	19.443485
SumSRLTraits_Core	3.763	69667.070	50.594265
SumSRLConstTraits	4.150	63174.538	45.879198
SumSRLConstTraits_Core	3.710	70656.395	51.312741
SumSRL128Traits	18.689	14026.701	10.186600
SumSRL128Traits_Core	7.034	37267.956	27.065080
SumSRL128ConstTraits	7.619	34407.197	24.987514
SumSRL128ConstTraits_Core	7.550	34720.105	25.214756
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	4.203	62365.889	45.291934
SumSRLFastTraits	4.239	61839.933	44.909969

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	192.990	1358.332
SumSRL_Basic	127.680	2053.127	1.511506
SumSRL_Base_Core	128.421	2041.286	1.502789
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	9.757	26867.839	19.780024
SumSRLTraits	9.731	26938.107	19.831756
SumSRLTraits_Core	7.081	37022.833	27.256101
SumSRLConstTraits	6.970	37608.314	27.687131
SumSRLConstTraits_Core	6.239	42016.713	30.932581
SumSRL128Traits	18.211	14394.549	10.597225
SumSRL128Traits_Core	13.577	19307.874	14.214400
SumSRL128ConstTraits	13.744	19072.700	14.041266
SumSRL128ConstTraits_Core	12.492	20985.247	15.449278
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	7.955	32953.026	24.259922
SumSRLFastTraits	8.159	32129.782	23.653852

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	115.571	2268.257
SumSRL_Basic	258.775	1013.019	0.446607
SumSRL_Base_Core	261.647	1001.900	0.441705
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	21.403	12247.979	5.399733
SumSRLTraits	20.676	12678.623	5.589590
SumSRLTraits_Core	14.973	17508.085	7.718741
SumSRLConstTraits	17.566	14923.617	6.579334
SumSRLConstTraits_Core	15.239	17202.062	7.583826
SumSRL128Traits	39.608	6618.504	2.917882
SumSRL128Traits_Core	26.287	9972.380	4.396496
SumSRL128ConstTraits	25.844	10143.441	4.471911
SumSRL128ConstTraits_Core	26.494	9894.639	4.362222
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	18.316	14312.420	6.309877
SumSRLFastTraits	17.658	14845.286	6.544800

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	168.542	1555.359
SumSRL_Basic	494.734	529.869	0.340673
SumSRL_Base_Core	497.072	527.376	0.339070
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	38.681	6777.002	4.357194
SumSRLTraits	38.372	6831.651	4.392330
SumSRLTraits_Core	27.249	9620.412	6.185330
SumSRLConstTraits	30.212	8676.926	5.578727
SumSRLConstTraits_Core	28.312	9259.167	5.953073
SumSRL128Traits	76.476	3427.809	2.203869
SumSRL128Traits_Core	52.179	5023.916	3.230068
SumSRL128ConstTraits	52.448	4998.155	3.213505
SumSRL128ConstTraits_Core	51.448	5095.346	3.275993
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	31.767	8252.130	5.305610
SumSRLFastTraits	31.645	8283.851	5.326004

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	174.265	1504.284
SumSRLNetBcl	198.930	1317.770	0.876011
SumSRLNetBcl_Const	193.922	1351.804	0.898636
SumSRL_Basic	9.458	27717.606	18.425779
SumSRL_Base_Core	10.653	24606.713	16.357757
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	9.212	28458.224	18.918118
SumSRLTraits	9.430	27799.744	18.480382
SumSRLTraits_Core	3.887	67442.052	44.833322
SumSRLConstTraits	4.318	60709.326	40.357621
SumSRLConstTraits_Core	5.377	48757.214	32.412238
SumSRL128Bcl	230.044	1139.538	0.757529
SumSRL128Traits	18.127	14461.197	9.613342
SumSRL128Traits_Core	7.125	36792.382	24.458400
SumSRL128ConstTraits	8.047	32576.616	21.655894
SumSRL128ConstTraits_Core	9.386	27929.106	18.566378
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	4.089	64115.912	42.622210
SumSRLFastTraits	4.528	57899.087	38.489464

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	178.276	1470.442
SumSRLNetBcl	8.285	31642.174	21.518820
SumSRLNetBcl_Const	7.225	36282.651	24.674659
SumSRL_Basic	8.169	32089.512	21.823041
SumSRL_Base_Core	8.521	30763.957	20.921573
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	9.681	27077.410	18.414472
SumSRLTraits	8.478	30921.940	21.029013
SumSRLTraits_Core	7.197	36421.851	24.769325
SumSRLConstTraits	7.814	33548.043	22.814941
SumSRLConstTraits_Core	7.793	33639.639	22.877232
SumSRL128Bcl	17.038	15385.905	10.463457
SumSRL128Traits	17.954	14601.264	9.929848
SumSRL128Traits_Core	13.693	19143.922	13.019163
SumSRL128ConstTraits	12.092	21678.958	14.743159
SumSRL128ConstTraits_Core	11.389	23017.465	15.653435
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	7.802	33599.601	22.850003
SumSRLFastTraits	7.925	33077.751	22.495110

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	98.013	2674.573
SumSRLNetBcl	17.246	15200.063	5.683175
SumSRLNetBcl_Const	13.584	19297.750	7.215265
SumSRL_Basic	16.244	16137.919	6.033831
SumSRL_Base_Core	15.486	16927.365	6.328998
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	17.313	15141.329	5.661215
SumSRLTraits	15.571	16835.230	6.294550
SumSRLTraits_Core	11.963	21912.344	8.192840
SumSRLConstTraits	13.817	18972.665	7.093718
SumSRLConstTraits_Core	11.763	22286.162	8.332607
SumSRL128Bcl	30.158	8692.401	3.250015
SumSRL128Traits	29.796	8798.034	3.289510
SumSRL128Traits_Core	20.798	12604.248	4.712622
SumSRL128ConstTraits	20.884	12552.657	4.693332
SumSRL128ConstTraits_Core	20.730	12645.572	4.728072
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	15.008	17467.507	6.530953
SumSRLFastTraits	15.120	17338.025	6.482541

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	130.433	2009.797
SumSRLNetBcl	28.278	9270.109	4.612460
SumSRLNetBcl_Const	27.121	9665.721	4.809302
SumSRL_Basic	28.388	9234.295	4.594641
SumSRL_Base_Core	28.614	9161.493	4.558417
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	33.260	7881.587	3.921584
SumSRLTraits	33.411	7846.139	3.903946
SumSRLTraits_Core	27.856	9410.686	4.682406
SumSRLConstTraits	27.472	9542.190	4.747838
SumSRLConstTraits_Core	27.379	9574.697	4.764012
SumSRL128Bcl	60.457	4336.025	2.157444
SumSRL128Traits	63.843	4106.045	2.043015
SumSRL128Traits_Core	44.996	5825.882	2.898742
SumSRL128ConstTraits	44.339	5912.267	2.941723
SumSRL128ConstTraits_Core	43.655	6004.927	2.987827
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	35.443	7396.176	3.680061
SumSRLFastTraits	31.797	8244.283	4.102047

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	167.670	1563.454
SumSRLNetBcl	220.067	1191.199	0.761902
SumSRLNetBcl_Const	203.145	1290.428	0.825370
SumSRL_Basic	9.104	28795.947	18.418157
SumSRL_Base_Core	4.248	61710.711	39.470749
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	4.227	62019.636	39.668340
SumSRLTraits	4.473	58606.409	37.485209
SumSRLTraits_Core	4.427	59215.221	37.874610
SumSRLConstTraits	4.440	59045.413	37.766000
SumSRLConstTraits_Core	4.329	60558.842	38.734003
SumSRL128Bcl	8.374	31304.820	20.022856
SumSRL128Traits	7.751	33820.788	21.632093
SumSRL128Traits_Core	8.092	32395.655	20.720564
SumSRL128ConstTraits	7.456	35159.169	22.488134
SumSRL128ConstTraits_Core	8.074	32469.562	20.767836
SumSRL512Bcl	3.144	83375.675	53.327863
SumSRL512Traits	3.175	82559.438	52.805790
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	4.476	58562.286	37.456987
SumSRLFastTraits	4.292	61081.627	39.068381

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	167.330	1566.632
SumSRLNetBcl	7.392	35464.642	22.637508
SumSRLNetBcl_Const	7.198	36418.354	23.246274
SumSRL_Basic	7.303	35894.516	22.911902
SumSRL_Base_Core	6.958	37675.350	24.048629
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	8.991	29155.023	18.610002
SumSRLTraits	7.233	36243.188	23.134463
SumSRLTraits_Core	7.485	35020.924	22.354277
SumSRLConstTraits	7.087	36989.736	23.610994
SumSRLConstTraits_Core	6.947	37736.310	24.087541
SumSRL128Bcl	13.411	19547.373	12.477323
SumSRL128Traits	13.233	19809.393	12.644574
SumSRL128Traits_Core	14.231	18421.237	11.758497
SumSRL128ConstTraits	12.919	20291.893	12.952560
SumSRL128ConstTraits_Core	13.139	19951.472	12.735265
SumSRL512Bcl	5.922	44264.320	28.254448
SumSRL512Traits	6.464	40553.403	25.885725
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	7.431	35278.477	22.518677
SumSRLFastTraits	7.109	36876.759	23.538879

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	107.415	2440.487
SumSRLNetBcl	16.059	16324.025	6.688840
SumSRLNetBcl_Const	16.284	16097.869	6.596172
SumSRL_Basic	15.860	16528.451	6.772605
SumSRL_Base_Core	15.264	17173.835	7.037054
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	16.684	15712.209	6.438146
SumSRLTraits	15.899	16488.228	6.756123
SumSRLTraits_Core	24.069	10891.195	4.462715
SumSRLConstTraits	16.073	16309.545	6.682907
SumSRLConstTraits_Core	15.413	17007.551	6.968918
SumSRL128Bcl	26.928	9734.959	3.988942
SumSRL128Traits	26.266	9980.375	4.089502
SumSRL128Traits_Core	29.155	8991.265	3.684210
SumSRL128ConstTraits	26.677	9826.581	4.026484
SumSRL128ConstTraits_Core	26.664	9831.511	4.028505
SumSRL512Bcl	13.772	19035.087	7.799710
SumSRL512Traits	13.107	20000.185	8.195163
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	15.520	16891.141	6.921219
SumSRLFastTraits	15.713	16682.732	6.835822

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	110.615	2369.881
SumSRLNetBcl	30.767	8520.374	3.595275
SumSRLNetBcl_Const	31.111	8426.164	3.555522
SumSRL_Basic	30.277	8658.088	3.653385
SumSRL_Base_Core	31.203	8401.351	3.545052
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	34.583	7580.151	3.198537
SumSRLTraits	33.620	7797.205	3.290125
SumSRLTraits_Core	34.386	7623.647	3.216891
SumSRLConstTraits	30.100	8709.090	3.674906
SumSRLConstTraits_Core	31.019	8450.977	3.565992
SumSRL128Bcl	50.374	5204.002	2.195892
SumSRL128Traits	55.880	4691.168	1.979495
SumSRL128Traits_Core	53.047	4941.696	2.085209
SumSRL128ConstTraits	49.579	5287.436	2.231098
SumSRL128ConstTraits_Core	53.053	4941.188	2.084994
SumSRL512Bcl	26.998	9709.909	4.097214
SumSRL512Traits	32.539	8056.250	3.399432
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	31.365	8357.741	3.526651
SumSRLFastTraits	30.392	8625.462	3.639618

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	304.568	860.708
SumSRL_Basic	75.272	3482.636	4.046247
SumSRL_Base_Core	76.107	3444.402	4.001825
SumSRLTraits	74.655	3511.384	4.079648
SumSRLTraits_Core	79.145	3312.182	3.848208
SumSRLConstTraits	71.209	3681.307	4.277070
SumSRLConstTraits_Core	71.239	3679.763	4.275276
SumSRLFastTraits	73.251	3578.692	4.157849

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	311.290	842.123
SumSRL_Basic	150.407	1742.900	2.069651
SumSRL_Base_Core	151.778	1727.160	2.050960
SumSRLTraits	149.076	1758.457	2.088124
SumSRLTraits_Core	155.699	1683.654	1.999298
SumSRLConstTraits	142.320	1841.928	2.187245
SumSRLConstTraits_Core	142.295	1842.261	2.187640
SumSRLFastTraits	146.273	1792.157	2.128143

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	311.990	840.232
SumSRL_Basic	301.227	870.254	1.035730
SumSRL_Base_Core	303.289	864.336	1.028688
SumSRLTraits	302.720	865.963	1.030624
SumSRLTraits_Core	302.619	866.250	1.030966
SumSRLConstTraits	284.747	920.621	1.095675
SumSRLConstTraits_Core	284.532	921.315	1.096501
SumSRLFastTraits	292.514	896.177	1.066583

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	313.226	836.917
SumSRL_Basic	580.882	451.286	0.539224
SumSRL_Base_Core	598.053	438.329	0.523742
SumSRLTraits	581.222	451.022	0.538909
SumSRLTraits_Core	572.955	457.530	0.546685
SumSRLConstTraits	523.659	500.601	0.598149
SumSRLConstTraits_Core	523.574	500.682	0.598246
SumSRLFastTraits	538.652	486.667	0.581500

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	305.108	859.184
SumSRL_Basic	77.288	3391.803	3.947705
SumSRL_Base_Core	75.283	3482.122	4.052826
SumSRLTraits	75.766	3459.909	4.026973
SumSRLTraits_Core	74.638	3512.213	4.087849
SumSRLConstTraits	65.794	3984.333	4.637348
SumSRLConstTraits_Core	65.677	3991.424	4.645600
SumSRLFastTraits	70.623	3711.903	4.320267

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	311.168	842.452
SumSRL_Basic	153.109	1712.144	2.032334
SumSRL_Base_Core	150.400	1742.983	2.068940
SumSRLTraits	151.214	1733.595	2.057796
SumSRLTraits_Core	149.538	1753.028	2.080864
SumSRLConstTraits	130.926	2002.238	2.376678
SumSRLConstTraits_Core	131.049	2000.354	2.374442
SumSRLFastTraits	141.116	1857.651	2.205052

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	311.598	841.290
SumSRL_Basic	303.149	864.736	1.027870
SumSRL_Base_Core	303.441	863.905	1.026882
SumSRLTraits	303.175	864.663	1.027783
SumSRLTraits_Core	303.405	864.007	1.027003
SumSRLConstTraits	262.338	999.262	1.187774
SumSRLConstTraits_Core	261.981	1000.621	1.189390
SumSRLFastTraits	281.373	931.659	1.107417

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	313.218	836.937
SumSRL_Basic	583.872	448.975	0.536450
SumSRL_Base_Core	555.307	472.070	0.564045
SumSRLTraits	554.649	472.630	0.564714
SumSRLTraits_Core	555.518	471.891	0.563831
SumSRLConstTraits	480.786	545.241	0.651472
SumSRLConstTraits_Core	479.622	546.563	0.653052
SumSRLFastTraits	519.577	504.534	0.602834

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	233.169	1124.267
SumSRL_Basic	74.826	3503.398	3.116161
SumSRL_Base_Core	75.917	3453.035	3.071364
SumSRL_Avx2	11.652	22498.329	20.011548
SumSRLTraits	12.232	21430.778	19.061996
SumSRLTraits_Core	6.187	42371.740	37.688315
SumSRLConstTraits	9.806	26732.259	23.777494
SumSRLConstTraits_Core	6.187	42371.681	37.688262
SumSRL128Traits	23.253	11273.585	10.027496
SumSRL128Traits_Core	11.544	22707.966	20.198014
SumSRL128ConstTraits	19.602	13373.228	11.895061
SumSRL128ConstTraits_Core	11.355	23085.285	20.533627
SumSRLFast_Avx2	9.747	26894.410	23.921722
SumSRLFastTraits	9.775	26816.824	23.852712

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	218.927	1197.405
SumSRL_Basic	152.829	1715.282	1.432500
SumSRL_Base_Core	151.368	1731.832	1.446322
SumSRL_Avx2	13.986	18742.928	15.652959
SumSRLTraits	14.349	18269.521	15.257598
SumSRLTraits_Core	13.788	19012.074	15.877734
SumSRLConstTraits	14.149	18526.821	15.472480
SumSRLConstTraits_Core	11.699	22406.662	18.712689
SumSRL128Traits	24.584	10663.254	8.905305
SumSRL128Traits_Core	21.156	12390.775	10.348026
SumSRL128ConstTraits	23.670	11074.842	9.249038
SumSRL128ConstTraits_Core	21.136	12402.444	10.357771
SumSRLFast_Avx2	13.087	20031.053	16.728724
SumSRLFastTraits	13.433	19515.046	16.297786

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	193.806	1352.612
SumSRL_Basic	298.864	877.136	0.648476
SumSRL_Base_Core	298.536	878.099	0.649187
SumSRL_Avx2	27.999	9362.615	6.921875
SumSRLTraits	26.516	9886.217	7.308979
SumSRLTraits_Core	24.354	10763.813	7.957795
SumSRLConstTraits	26.489	9896.420	7.316523
SumSRLConstTraits_Core	21.897	11971.914	8.850957
SumSRL128Traits	48.975	5352.578	3.957215
SumSRL128Traits_Core	40.636	6451.066	4.769338
SumSRL128ConstTraits	47.168	5557.668	4.108840
SumSRL128ConstTraits_Core	40.088	6539.178	4.834480
SumSRLFast_Avx2	24.932	10514.538	7.773504
SumSRLFastTraits	24.953	10505.602	7.766897

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	201.172	1303.085
SumSRL_Basic	535.917	489.150	0.375379
SumSRL_Base_Core	536.844	488.306	0.374731
SumSRL_Avx2	56.574	4633.662	3.555918
SumSRLTraits	56.941	4603.809	3.533008
SumSRLTraits_Core	44.829	5847.583	4.487493
SumSRLConstTraits	57.548	4555.211	3.495714
SumSRLConstTraits_Core	49.274	5320.140	4.082728
SumSRL128Traits	98.196	2669.587	2.048667
SumSRL128Traits_Core	74.418	3522.583	2.703265
SumSRL128ConstTraits	94.232	2781.894	2.134853
SumSRL128ConstTraits_Core	80.538	3254.929	2.497865
SumSRLFast_Avx2	51.984	5042.779	3.869878
SumSRLFastTraits	54.025	4852.310	3.723711

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	233.137	1124.419
SumSRL_Basic	72.918	3595.065	3.197265
SumSRL_Base_Core	72.866	3597.632	3.199548
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	12.390	21158.115	18.816934
SumSRLTraits	11.730	22348.406	19.875517
SumSRLTraits_Core	6.732	38940.425	34.631601
SumSRLConstTraits	8.089	32406.520	28.820683
SumSRLConstTraits_Core	6.734	38927.011	34.619671
SumSRL128Traits	23.233	11283.140	10.034642
SumSRL128Traits_Core	11.341	23114.473	20.556817
SumSRL128ConstTraits	11.632	22537.410	20.043607
SumSRL128ConstTraits_Core	11.380	23034.984	20.486124
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	7.443	35221.999	31.324625
SumSRLFastTraits	7.469	35097.841	31.214206

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	219.776	1192.777
SumSRL_Basic	147.388	1778.594	1.491137
SumSRL_Base_Core	146.542	1788.865	1.499748
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	13.923	18828.496	15.785429
SumSRLTraits	14.050	18657.899	15.642404
SumSRLTraits_Core	11.624	22551.415	18.906648
SumSRLConstTraits	11.761	22290.091	18.687559
SumSRLConstTraits_Core	12.386	21164.821	17.744156
SumSRL128Traits	24.548	10678.717	8.952820
SumSRL128Traits_Core	21.397	12251.695	10.271572
SumSRL128ConstTraits	21.187	12372.903	10.373190
SumSRL128ConstTraits_Core	21.184	12374.374	10.374423
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	11.785	22244.068	18.648975
SumSRLFastTraits	12.147	21581.651	18.093618

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	193.754	1352.975
SumSRL_Basic	290.879	901.214	0.666098
SumSRL_Base_Core	291.124	900.454	0.665537
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	28.470	9207.784	6.805584
SumSRLTraits	28.875	9078.617	6.710115
SumSRLTraits_Core	23.327	11237.730	8.305942
SumSRLConstTraits	25.202	10401.660	7.687992
SumSRLConstTraits_Core	22.726	11534.917	8.525597
SumSRL128Traits	52.201	5021.805	3.711676
SumSRL128Traits_Core	40.008	6552.349	4.842920
SumSRL128ConstTraits	41.956	6248.058	4.618015
SumSRL128ConstTraits_Core	39.136	6698.201	4.950721
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	23.774	11026.398	8.149744
SumSRLFastTraits	25.363	10335.612	7.639175

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	194.437	1348.224
SumSRL_Basic	559.881	468.214	0.347282
SumSRL_Base_Core	560.537	467.666	0.346876
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	55.726	4704.132	3.489133
SumSRLTraits	53.421	4907.109	3.639685
SumSRLTraits_Core	45.290	5788.063	4.293103
SumSRLConstTraits	55.644	4711.067	3.494277
SumSRLConstTraits_Core	46.482	5639.746	4.183094
SumSRL128Traits	99.277	2640.540	1.958533
SumSRL128Traits_Core	81.424	3219.510	2.387965
SumSRL128ConstTraits	94.058	2787.046	2.067198
SumSRL128ConstTraits_Core	79.723	3288.192	2.438907
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	48.789	5372.972	3.985223
SumSRLFastTraits	52.501	4993.147	3.703501

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	187.022	1401.674
SumSRL_Basic	74.558	3515.958	2.508399
SumSRL_Base_Core	74.614	3513.345	2.506535
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	11.722	22363.691	15.954983
SumSRLTraits	11.731	22347.107	15.943152
SumSRLTraits_Core	6.735	38922.939	27.768888
SumSRLConstTraits	6.320	41480.463	29.593508
SumSRLConstTraits_Core	6.726	38976.774	27.807295
SumSRL128Traits	23.145	11326.038	8.080363
SumSRL128Traits_Core	11.346	23105.048	16.483891
SumSRL128ConstTraits	10.921	24004.174	17.125357
SumSRL128ConstTraits_Core	11.379	23037.629	16.435792
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	6.968	37623.123	26.841557
SumSRLFastTraits	6.989	37507.716	26.759222

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	186.577	1405.020
SumSRL_Basic	150.295	1744.197	1.241403
SumSRL_Base_Core	150.572	1740.990	1.239121
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	13.463	19471.763	13.858707
SumSRLTraits	13.493	19427.799	13.827416
SumSRLTraits_Core	11.623	22553.645	16.052186
SumSRLConstTraits	11.123	23567.158	16.773537
SumSRLConstTraits_Core	10.800	24273.169	17.276028
SumSRL128Traits	24.557	10674.785	7.597602
SumSRL128Traits_Core	21.112	12416.879	8.837509
SumSRL128ConstTraits	20.222	12963.102	9.226274
SumSRL128ConstTraits_Core	19.150	13689.134	9.743016
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	13.242	19796.466	14.089809
SumSRLFastTraits	13.528	19377.471	13.791596

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	159.200	1646.634
SumSRL_Basic	297.943	879.845	0.534329
SumSRL_Base_Core	298.492	878.228	0.533347
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	28.490	9201.105	5.587826
SumSRLTraits	28.593	9168.072	5.567765
SumSRLTraits_Core	22.660	11568.403	7.025484
SumSRLConstTraits	24.495	10701.916	6.499268
SumSRLConstTraits_Core	23.287	11257.117	6.836441
SumSRL128Traits	48.946	5355.734	3.252534
SumSRL128Traits_Core	40.013	6551.525	3.978738
SumSRL128ConstTraits	39.988	6555.543	3.981177
SumSRL128ConstTraits_Core	39.928	6565.484	3.987215
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	25.674	10210.506	6.200834
SumSRLFastTraits	25.306	10359.040	6.291039

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	194.012	1351.173
SumSRL_Basic	537.169	488.011	0.361175
SumSRL_Base_Core	534.835	490.140	0.362751
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	53.624	4888.515	3.617979
SumSRLTraits	53.197	4927.812	3.647063
SumSRLTraits_Core	44.433	5899.802	4.366430
SumSRLConstTraits	50.529	5187.960	3.839597
SumSRLConstTraits_Core	49.658	5279.033	3.907000
SumSRL128Traits	98.372	2664.826	1.972232
SumSRL128Traits_Core	76.885	3409.562	2.523409
SumSRL128ConstTraits	80.761	3245.938	2.402312
SumSRL128ConstTraits_Core	81.373	3221.531	2.384247
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	48.854	5365.849	3.971253
SumSRLFastTraits	50.509	5190.052	3.841146

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	161.284	1625.360
SumSRLNetBcl	222.412	1178.641	0.725157
SumSRLNetBcl_Const	222.517	1178.088	0.724816
SumSRL_Basic	11.183	23441.151	14.422126
SumSRL_Base_Core	11.239	23325.467	14.350952
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	10.453	25077.580	15.428936
SumSRLTraits	10.459	25064.421	15.420840
SumSRLTraits_Core	6.760	38779.830	23.859221
SumSRLConstTraits	8.308	31554.277	19.413712
SumSRLConstTraits_Core	6.235	42041.736	25.866103
SumSRL128Traits	19.601	13373.965	8.228308
SumSRL128Traits_Core	12.395	21149.430	13.012149
SumSRL128ConstTraits	12.448	21058.754	12.956361
SumSRL128ConstTraits_Core	12.438	21076.848	12.967493
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	6.943	37755.611	23.229072
SumSRLFastTraits	6.969	37615.945	23.143143

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	160.780	1630.456
SumSRLNetBcl	12.597	20810.187	12.763416
SumSRLNetBcl_Const	11.422	22950.040	14.075843
SumSRL_Basic	12.622	20769.333	12.738360
SumSRL_Base_Core	13.418	19536.778	11.982402
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	14.702	17830.372	10.935820
SumSRLTraits	14.304	18326.875	11.240338
SumSRLTraits_Core	13.460	19476.074	11.945171
SumSRLConstTraits	11.521	22752.658	13.954783
SumSRLConstTraits_Core	11.517	22760.503	13.959595
SumSRL128Traits	23.688	11066.687	6.787480
SumSRL128Traits_Core	22.426	11689.107	7.169226
SumSRL128ConstTraits	21.351	12277.972	7.530392
SumSRL128ConstTraits_Core	20.771	12620.601	7.740535
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	12.752	20557.871	12.608665
SumSRLFastTraits	13.549	19347.959	11.866595

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	116.432	2251.479
SumSRLNetBcl	25.192	10405.918	4.621815
SumSRLNetBcl_Const	22.259	11777.083	5.230821
SumSRL_Basic	27.293	9604.887	4.266035
SumSRL_Base_Core	26.934	9732.781	4.322839
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	29.142	8995.293	3.995282
SumSRLTraits	26.652	9835.703	4.368552
SumSRLTraits_Core	23.333	11234.864	4.989993
SumSRLConstTraits	23.240	11279.942	5.010015
SumSRLConstTraits_Core	22.878	11458.321	5.089242
SumSRL128Traits	46.376	5652.604	2.510618
SumSRL128Traits_Core	42.608	6152.423	2.732614
SumSRL128ConstTraits	42.849	6117.871	2.717268
SumSRL128ConstTraits_Core	42.766	6129.746	2.722542
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	26.135	10030.468	4.455057
SumSRLFastTraits	25.700	10200.001	4.530356

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	155.737	1683.247
SumSRLNetBcl	51.322	5107.877	3.034539
SumSRLNetBcl_Const	45.565	5753.125	3.417874
SumSRL_Basic	53.747	4877.338	2.897577
SumSRL_Base_Core	53.417	4907.489	2.915490
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRL_Avx2	63.475	4129.910	2.453538
SumSRLTraits	60.172	4356.584	2.588203
SumSRLTraits_Core	46.347	5656.123	3.360245
SumSRLConstTraits	51.262	5113.821	3.038070
SumSRLConstTraits_Core	47.007	5576.720	3.313073
SumSRL128Traits	100.824	2600.020	1.544646
SumSRL128Traits_Core	78.521	3338.540	1.983393
SumSRL128ConstTraits	85.348	3071.486	1.824739
SumSRL128ConstTraits_Core	83.607	3135.444	1.862736
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRLFast_Avx2	51.488	5091.406	3.024753
SumSRLFastTraits	52.384	5004.310	2.973010

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	155.241	1688.629
SumSRL_Basic	24.713	10607.474	6.281706
SumSRL_Base_Core	24.718	10605.572	6.280580
SumSRL_AdvSimd	9.650	27166.365	16.087819
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	9.645	27178.127	16.094784
SumSRLTraits_Core	9.622	27242.883	16.133133
SumSRLConstTraits	9.623	27242.336	16.132809
SumSRLConstTraits_Core	9.622	27245.052	16.134417
SumSRL128Traits	9.648	27171.259	16.090717
SumSRL128Traits_Core	9.624	27239.818	16.131317
SumSRL128ConstTraits	9.625	27237.085	16.129699
SumSRL128ConstTraits_Core	9.623	27240.584	16.131771
SumSRLFast_AdvSimd	9.622	27244.526	16.134106
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	9.622	27243.732	16.133635

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	158.063	1658.483
SumSRL_Basic	49.403	5306.264	3.199469
SumSRL_Base_Core	49.415	5304.910	3.198652
SumSRL_AdvSimd	19.286	13592.374	8.195667
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	19.281	13596.215	8.197983
SumSRLTraits_Core	19.260	13610.939	8.206861
SumSRLConstTraits	19.254	13615.291	8.209485
SumSRLConstTraits_Core	19.257	13612.578	8.207849
SumSRL128Traits	19.302	13580.995	8.188806
SumSRL128Traits_Core	19.258	13612.101	8.207561
SumSRL128ConstTraits	19.259	13611.184	8.207009
SumSRL128ConstTraits_Core	19.255	13614.566	8.209048
SumSRLFast_AdvSimd	19.261	13610.269	8.206457
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	19.260	13611.092	8.206953

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	151.397	1731.498
SumSRL_Basic	91.541	2863.675	1.653871
SumSRL_Base_Core	91.537	2863.789	1.653937
SumSRL_AdvSimd	38.541	6801.702	3.928218
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	38.546	6800.823	3.927710
SumSRLTraits_Core	38.515	6806.345	3.930899
SumSRLConstTraits	38.520	6805.334	3.930315
SumSRLConstTraits_Core	38.524	6804.776	3.929993
SumSRL128Traits	38.544	6801.102	3.927871
SumSRL128Traits_Core	38.526	6804.298	3.929717
SumSRL128ConstTraits	38.527	6804.239	3.929683
SumSRL128ConstTraits_Core	38.525	6804.456	3.929808
SumSRLFast_AdvSimd	38.524	6804.706	3.929952
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	38.524	6804.609	3.929896

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	152.389	1720.232
SumSRL_Basic	158.997	1648.737	0.958439
SumSRL_Base_Core	159.022	1648.471	0.958284
SumSRL_AdvSimd	77.103	3399.925	1.976434
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	77.093	3400.360	1.976687
SumSRLTraits_Core	77.067	3401.510	1.977355
SumSRLConstTraits	77.077	3401.076	1.977103
SumSRLConstTraits_Core	77.055	3402.031	1.977658
SumSRL128Traits	77.104	3399.868	1.976400
SumSRL128Traits_Core	77.075	3401.143	1.977142
SumSRL128ConstTraits	77.068	3401.473	1.977333
SumSRL128ConstTraits_Core	77.079	3400.980	1.977047
SumSRLFast_AdvSimd	77.075	3401.142	1.977141
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	77.058	3401.912	1.977589

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	155.069	1690.503
SumSRLNetBcl	9.626	27232.144	16.108901
SumSRLNetBcl_Const	9.624	27239.662	16.113348
SumSRL_Basic	12.070	21719.251	12.847805
SumSRL_Base_Core	12.079	21702.895	12.838129
SumSRL_AdvSimd	9.642	27186.879	16.082125
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	9.640	27192.221	16.085285
SumSRLTraits_Core	9.624	27237.843	16.112272
SumSRLConstTraits	9.623	27240.049	16.113578
SumSRLConstTraits_Core	9.622	27243.736	16.115759
SumSRL128Bcl	9.624	27238.161	16.112461
SumSRL128Traits	9.642	27188.409	16.083030
SumSRL128Traits_Core	9.624	27238.587	16.112712
SumSRL128ConstTraits	9.623	27242.811	16.115211
SumSRL128ConstTraits_Core	9.624	27238.765	16.112818
SumSRLFast_AdvSimd	9.621	27248.202	16.118400
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	9.622	27243.576	16.115664

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	155.091	1690.261
SumSRLNetBcl	19.251	13617.151	8.056243
SumSRLNetBcl_Const	19.251	13617.156	8.056246
SumSRL_Basic	19.252	13616.291	8.055734
SumSRL_Base_Core	19.257	13613.034	8.053808
SumSRL_AdvSimd	19.276	13599.586	8.045852
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	19.256	13613.593	8.054138
SumSRLTraits_Core	19.260	13611.098	8.052662
SumSRLConstTraits	19.256	13613.296	8.053963
SumSRLConstTraits_Core	19.258	13612.304	8.053376
SumSRL128Bcl	19.258	13612.325	8.053388
SumSRL128Traits	19.258	13612.202	8.053315
SumSRL128Traits_Core	19.255	13614.051	8.054409
SumSRL128ConstTraits	19.257	13612.664	8.053589
SumSRL128ConstTraits_Core	19.259	13611.217	8.052733
SumSRLFast_AdvSimd	19.254	13614.752	8.054824
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	19.257	13612.703	8.053612

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	113.981	2299.889
SumSRLNetBcl	38.522	6805.128	2.958894
SumSRLNetBcl_Const	38.525	6804.595	2.958662
SumSRL_Basic	38.517	6805.870	2.959217
SumSRL_Base_Core	38.522	6805.049	2.958860
SumSRL_AdvSimd	38.531	6803.527	2.958198
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	38.526	6804.278	2.958525
SumSRLTraits_Core	38.527	6804.215	2.958497
SumSRLConstTraits	38.519	6805.524	2.959066
SumSRLConstTraits_Core	38.521	6805.142	2.958900
SumSRL128Bcl	38.523	6804.888	2.958790
SumSRL128Traits	38.518	6805.669	2.959129
SumSRL128Traits_Core	38.522	6805.048	2.958859
SumSRL128ConstTraits	38.524	6804.734	2.958723
SumSRL128ConstTraits_Core	38.526	6804.416	2.958585
SumSRLFast_AdvSimd	38.521	6805.135	2.958897
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	38.520	6805.422	2.959022

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	115.976	2260.330
SumSRLNetBcl	77.045	3402.464	1.505295
SumSRLNetBcl_Const	77.064	3401.641	1.504931
SumSRL_Basic	77.064	3401.627	1.504925
SumSRL_Base_Core	77.048	3402.325	1.505234
SumSRL_AdvSimd	77.084	3400.747	1.504535
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	77.076	3401.131	1.504705
SumSRLTraits_Core	77.074	3401.194	1.504733
SumSRLConstTraits	77.061	3401.789	1.504996
SumSRLConstTraits_Core	77.059	3401.876	1.505035
SumSRL128Bcl	77.045	3402.460	1.505293
SumSRL128Traits	77.090	3400.491	1.504422
SumSRL128Traits_Core	77.069	3401.441	1.504842
SumSRL128ConstTraits	77.070	3401.356	1.504805
SumSRL128ConstTraits_Core	77.055	3402.016	1.505097
SumSRLFast_AdvSimd	77.057	3401.942	1.505064
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	77.073	3401.256	1.504760

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	224.766	1166.296
SumSRLNetBcl	9.619	27252.985	23.367135
SumSRLNetBcl_Const	9.620	27250.616	23.365104
SumSRL_Basic	10.860	24137.417	20.695799
SumSRL_Base_Core	9.621	27246.144	23.361270
SumSRL_AdvSimd	9.618	27254.525	23.368456
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	9.620	27250.813	23.365273
SumSRLTraits_Core	9.619	27253.427	23.367514
SumSRLConstTraits	9.618	27255.594	23.369372
SumSRLConstTraits_Core	9.618	27256.646	23.370274
SumSRL128Bcl	9.617	27258.084	23.371507
SumSRL128Traits	9.618	27254.462	23.368402
SumSRL128Traits_Core	9.617	27259.644	23.372845
SumSRL128ConstTraits	9.617	27257.768	23.371236
SumSRL128ConstTraits_Core	9.621	27248.360	23.363170
SumSRL512Bcl	2.901	90350.504	77.467935
SumSRL512Traits	2.902	90322.452	77.443883
SumSRLFast_AdvSimd	9.619	27253.449	23.367533
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	9.619	27253.398	23.367490

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	224.888	1165.666
SumSRLNetBcl	19.250	13617.801	11.682425
SumSRLNetBcl_Const	19.254	13614.849	11.679892
SumSRL_Basic	19.256	13613.890	11.679070
SumSRL_Base_Core	19.250	13618.195	11.682763
SumSRL_AdvSimd	19.250	13617.727	11.682362
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	19.253	13616.084	11.680952
SumSRLTraits_Core	19.254	13614.865	11.679906
SumSRLConstTraits	19.255	13614.417	11.679522
SumSRLConstTraits_Core	19.251	13617.158	11.681873
SumSRL128Bcl	19.255	13614.329	11.679446
SumSRL128Traits	19.252	13616.317	11.681152
SumSRL128Traits_Core	19.254	13614.819	11.679867
SumSRL128ConstTraits	19.252	13616.120	11.680983
SumSRL128ConstTraits_Core	19.248	13619.579	11.683950
SumSRL512Bcl	5.730	45750.202	39.248135
SumSRL512Traits	5.730	45750.860	39.248699
SumSRLFast_AdvSimd	19.253	13615.534	11.680480
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	19.251	13617.139	11.681856

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	150.028	1747.304
SumSRLNetBcl	38.517	6805.915	3.895094
SumSRLNetBcl_Const	38.512	6806.831	3.895619
SumSRL_Basic	38.517	6805.892	3.895082
SumSRL_Base_Core	38.513	6806.686	3.895536
SumSRL_AdvSimd	38.516	6806.153	3.895231
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	38.520	6805.359	3.894777
SumSRLTraits_Core	38.516	6806.141	3.895224
SumSRLConstTraits	38.517	6805.874	3.895071
SumSRLConstTraits_Core	38.519	6805.597	3.894913
SumSRL128Bcl	38.511	6806.950	3.895687
SumSRL128Traits	38.513	6806.608	3.895491
SumSRL128Traits_Core	38.517	6805.854	3.895060
SumSRL128ConstTraits	38.515	6806.359	3.895349
SumSRL128ConstTraits_Core	38.513	6806.647	3.895513
SumSRL512Bcl	11.429	22936.419	13.126747
SumSRL512Traits	11.430	22934.782	13.125810
SumSRLFast_AdvSimd	38.512	6806.769	3.895583
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	38.509	6807.287	3.895880

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	154.223	1699.773
SumSRLNetBcl	77.047	3402.412	2.001686
SumSRLNetBcl_Const	77.059	3401.847	2.001354
SumSRL_Basic	77.070	3401.379	2.001078
SumSRL_Base_Core	77.050	3402.274	2.001604
SumSRL_AdvSimd	77.063	3401.665	2.001246
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	77.050	3402.272	2.001603
SumSRLTraits_Core	77.041	3402.674	2.001840
SumSRLConstTraits	77.060	3401.830	2.001343
SumSRLConstTraits_Core	77.051	3402.213	2.001569
SumSRL128Bcl	77.045	3402.464	2.001716
SumSRL128Traits	77.061	3401.794	2.001322
SumSRL128Traits_Core	77.047	3402.385	2.001670
SumSRL128ConstTraits	77.057	3401.928	2.001401
SumSRL128ConstTraits_Core	77.056	3402.009	2.001449
SumSRL512Bcl	22.788	11503.458	6.767643
SumSRL512Traits	22.786	11504.614	6.768323
SumSRLFast_AdvSimd	77.054	3402.086	2.001494
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	77.073	3401.252	2.001004

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	429.977	609.670
SumSRL_Basic	77.964	3362.391	5.515099
SumSRL_Base_Core	77.984	3361.521	5.513672
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	72.876	3597.117	5.900103
SumSRLTraits_Core	73.212	3580.619	5.873043
SumSRLConstTraits	68.236	3841.700	6.301277
SumSRLConstTraits_Core	68.232	3841.950	6.301686
SumSRL128Traits	572.543	457.859	0.750994
SumSRL128Traits_Core	570.818	459.243	0.753264
SumSRL128ConstTraits	574.534	456.272	0.748392
SumSRL128ConstTraits_Core	573.831	456.831	0.749309
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	68.213	3843.004	6.303415

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	434.110	603.865
SumSRL_Basic	155.051	1690.698	2.799793
SumSRL_Base_Core	154.718	1694.332	2.805812
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	146.210	1792.932	2.969093
SumSRLTraits_Core	146.121	1794.025	2.970903
SumSRLConstTraits	138.725	1889.665	3.129282
SumSRLConstTraits_Core	137.703	1903.697	3.152520
SumSRL128Traits	895.939	292.591	0.484531
SumSRL128Traits_Core	896.698	292.344	0.484121
SumSRL128ConstTraits	908.669	288.492	0.477743
SumSRL128ConstTraits_Core	908.029	288.696	0.478080
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	137.326	1908.924	3.161176

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	350.762	747.355
SumSRL_Basic	288.938	907.266	1.213969
SumSRL_Base_Core	289.547	905.360	1.211419
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	292.542	896.091	1.199017
SumSRLTraits_Core	293.504	893.153	1.195086
SumSRLConstTraits	276.447	948.260	1.268822
SumSRLConstTraits_Core	273.564	958.255	1.282196
SumSRL128Traits	1419.838	184.629	0.247044
SumSRL128Traits_Core	1420.106	184.595	0.246997
SumSRL128ConstTraits	1419.560	184.666	0.247092
SumSRL128ConstTraits_Core	1422.610	184.270	0.246563
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	272.531	961.889	1.287058

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	353.606	741.345
SumSRL_Basic	542.543	483.177	0.651757
SumSRL_Base_Core	1267.902	206.754	0.278891
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	555.923	471.548	0.636071
SumSRLTraits_Core	557.019	470.620	0.634819
SumSRLConstTraits	559.954	468.153	0.631492
SumSRLConstTraits_Core	559.382	468.631	0.632137
SumSRL128Traits	1014.664	258.356	0.348496
SumSRL128Traits_Core	1018.344	257.422	0.347236
SumSRL128ConstTraits	1017.552	257.622	0.347507
SumSRL128ConstTraits_Core	1019.846	257.043	0.346725
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	559.228	468.760	0.632311

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	429.621	610.175
SumSRL_Basic	168.229	1558.260	2.553791
SumSRL_Base_Core	73.585	3562.451	5.838405
SumSRL_AdvSimd	22.265	11773.904	19.295936
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	23.130	11333.426	18.574048
SumSRLTraits_Core	16.632	15761.636	25.831323
SumSRLConstTraits	19.833	13217.814	21.662321
SumSRLConstTraits_Core	16.570	15820.815	25.928310
SumSRL128Traits	22.035	11896.746	19.497259
SumSRL128Traits_Core	16.564	15825.741	25.936384
SumSRL128ConstTraits	16.550	15839.376	25.958729
SumSRL128ConstTraits_Core	16.548	15841.274	25.961841
SumSRLFast_AdvSimd	19.922	13158.627	21.565322
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	19.992	13112.678	21.490017

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	434.683	603.069
SumSRL_Basic	146.475	1789.688	2.967634
SumSRL_Base_Core	147.176	1781.165	2.953502
SumSRL_AdvSimd	46.555	5630.795	9.336901
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	46.212	5672.668	9.406333
SumSRLTraits_Core	30.791	8513.781	14.117425
SumSRLConstTraits	210.201	1247.111	2.067941
SumSRLConstTraits_Core	30.800	8511.141	14.113046
SumSRL128Traits	46.386	5651.354	9.370992
SumSRL128Traits_Core	33.019	7939.185	13.164639
SumSRL128ConstTraits	210.397	1245.949	2.066014
SumSRL128ConstTraits_Core	33.194	7897.276	13.095146
SumSRLFast_AdvSimd	40.008	6552.259	10.864858
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	32.987	7946.934	13.177488

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	349.910	749.175
SumSRL_Basic	267.811	978.839	1.306554
SumSRL_Base_Core	273.271	959.284	1.280452
SumSRL_AdvSimd	80.044	3274.989	4.371458
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	79.737	3287.611	4.388307
SumSRLTraits_Core	62.342	4204.944	5.612762
SumSRLConstTraits	79.595	3293.490	4.396154
SumSRLConstTraits_Core	62.318	4206.585	5.614953
SumSRL128Traits	80.158	3270.360	4.365280
SumSRL128Traits_Core	66.511	3941.342	5.260907
SumSRL128ConstTraits	79.442	3299.800	4.404575
SumSRL128ConstTraits_Core	66.346	3951.191	5.274052
SumSRLFast_AdvSimd	66.845	3921.684	5.234667
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	66.472	3943.682	5.264029

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	354.933	738.573
SumSRL_Basic	542.297	483.396	0.654500
SumSRL_Base_Core	549.194	477.325	0.646279
SumSRL_AdvSimd	187.335	1399.336	1.894648
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	185.290	1414.776	1.915552
SumSRLTraits_Core	123.270	2126.579	2.879307
SumSRLConstTraits	132.025	1985.566	2.688381
SumSRLConstTraits_Core	132.193	1983.033	2.684951
SumSRL128Traits	184.751	1418.901	1.921139
SumSRL128Traits_Core	132.885	1972.717	2.670984
SumSRL128ConstTraits	132.399	1979.961	2.680792
SumSRL128ConstTraits_Core	123.646	2120.115	2.870555
SumSRLFast_AdvSimd	132.607	1976.849	2.676578
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	131.997	1985.988	2.688953

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	388.459	674.831
SumSRL_Basic	164.461	1593.962	2.362016
SumSRL_Base_Core	71.606	3660.920	5.424942
SumSRL_AdvSimd	22.166	11826.627	17.525311
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	23.105	11345.812	16.812814
SumSRLTraits_Core	16.551	15838.977	23.471019
SumSRLConstTraits	16.529	15859.573	23.501540
SumSRLConstTraits_Core	15.433	16985.660	25.170234
SumSRL128Traits	23.126	11335.311	16.797252
SumSRL128Traits_Core	15.445	16972.257	25.150373
SumSRL128ConstTraits	16.561	15829.417	23.456853
SumSRL128ConstTraits_Core	16.540	15848.712	23.485445
SumSRLFast_AdvSimd	16.524	15864.810	23.509300
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	16.530	15858.362	23.499745

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	432.569	606.017
SumSRL_Basic	337.299	777.186	1.282449
SumSRL_Base_Core	145.489	1801.808	2.973196
SumSRL_AdvSimd	44.321	5914.675	9.759914
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	44.039	5952.491	9.822314
SumSRLTraits_Core	32.997	7944.583	13.109503
SumSRLConstTraits	32.967	7951.642	13.121151
SumSRLConstTraits_Core	33.005	7942.467	13.106010
SumSRL128Traits	43.986	5959.758	9.834307
SumSRL128Traits_Core	30.822	8505.116	14.034448
SumSRL128ConstTraits	33.011	7941.172	13.103874
SumSRL128ConstTraits_Core	30.831	8502.726	14.030504
SumSRLFast_AdvSimd	30.816	8506.717	14.037089
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	32.969	7951.346	13.120662

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	351.028	746.788
SumSRL_Basic	268.238	977.281	1.308645
SumSRL_Base_Core	268.518	976.261	1.307279
SumSRL_AdvSimd	80.005	3276.607	4.387598
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	79.341	3304.001	4.424280
SumSRLTraits_Core	61.963	4230.659	5.665137
SumSRLConstTraits	66.344	3951.262	5.291006
SumSRLConstTraits_Core	66.339	3951.556	5.291400
SumSRL128Traits	79.507	3297.130	4.415079
SumSRL128Traits_Core	61.955	4231.167	5.665817
SumSRL128ConstTraits	61.977	4229.725	5.663886
SumSRL128ConstTraits_Core	66.325	3952.438	5.292581
SumSRLFast_AdvSimd	61.946	4231.836	5.666714
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	66.290	3954.499	5.295341

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	353.426	741.723
SumSRL_Basic	540.393	485.099	0.654016
SumSRL_Base_Core	540.166	485.303	0.654291
SumSRL_AdvSimd	177.621	1475.860	1.989771
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	176.100	1488.608	2.006959
SumSRLTraits_Core	132.073	1984.837	2.675980
SumSRLConstTraits	132.128	1984.014	2.674870
SumSRLConstTraits_Core	123.363	2124.977	2.864919
SumSRL128Traits	176.540	1484.903	2.001963
SumSRL128Traits_Core	123.951	2114.908	2.851343
SumSRL128ConstTraits	132.214	1982.723	2.673130
SumSRL128ConstTraits_Core	132.274	1981.827	2.671921
SumSRLFast_AdvSimd	158.519	1653.707	2.229547
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	158.434	1654.599	2.230749

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	295.091	888.349
SumSRLNetBcl	13.380	19591.854	22.054221
SumSRLNetBcl_Const	13.385	19585.260	22.046798
SumSRL_Basic	33.050	7931.659	8.928536
SumSRL_Base_Core	33.141	7910.038	8.904197
SumSRL_AdvSimd	19.944	13144.260	14.796273
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	19.998	13108.813	14.756371
SumSRLTraits_Core	13.411	19546.989	22.003717
SumSRLConstTraits	13.506	19410.088	21.849610
SumSRLConstTraits_Core	13.513	19399.330	21.837500
SumSRL128Bcl	13.391	19575.999	22.036373
SumSRL128Traits	19.927	13155.132	14.808511
SumSRL128Traits_Core	13.387	19581.770	22.042869
SumSRL128ConstTraits	13.512	19400.383	21.838685
SumSRL128ConstTraits_Core	13.502	19415.233	21.855402
SumSRLFast_AdvSimd	13.381	19590.685	22.052905
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	13.382	19589.811	22.051921

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	319.208	821.233
SumSRLNetBcl	26.698	9818.720	11.956072
SumSRLNetBcl_Const	26.706	9816.088	11.952868
SumSRL_Basic	26.674	9827.791	11.967118
SumSRL_Base_Core	26.722	9810.049	11.945514
SumSRL_AdvSimd	39.774	6590.873	8.025583
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	26.701	9817.877	11.955045
SumSRLTraits_Core	26.750	9799.846	11.933090
SumSRLConstTraits	26.875	9754.273	11.877596
SumSRLConstTraits_Core	26.872	9755.341	11.878897
SumSRL128Bcl	26.717	9811.873	11.947735
SumSRL128Traits	26.698	9818.752	11.956111
SumSRL128Traits_Core	26.692	9821.111	11.958984
SumSRL128ConstTraits	26.951	9726.565	11.843857
SumSRL128ConstTraits_Core	26.907	9742.650	11.863443
SumSRLFast_AdvSimd	26.741	9802.989	11.936917
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	26.744	9801.995	11.935707

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	222.640	1177.437
SumSRLNetBcl	53.895	4864.021	4.131025
SumSRLNetBcl_Const	54.068	4848.450	4.117802
SumSRL_Basic	53.961	4858.017	4.125927
SumSRL_Base_Core	54.123	4843.458	4.113561
SumSRL_AdvSimd	79.466	3298.839	2.801713
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	53.937	4860.197	4.127778
SumSRLTraits_Core	53.928	4860.967	4.128432
SumSRLConstTraits	54.320	4825.915	4.098662
SumSRLConstTraits_Core	54.297	4828.003	4.100435
SumSRL128Bcl	54.509	4809.153	4.084427
SumSRL128Traits	53.917	4861.957	4.129273
SumSRL128Traits_Core	54.042	4850.766	4.119768
SumSRL128ConstTraits	54.534	4807.009	4.082606
SumSRL128ConstTraits_Core	54.414	4817.585	4.091588
SumSRLFast_AdvSimd	53.958	4858.301	4.126168
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	53.975	4856.756	4.124856

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	221.818	1181.795
SumSRLNetBcl	107.210	2445.148	2.069012
SumSRLNetBcl_Const	109.738	2388.818	2.021347
SumSRL_Basic	106.994	2450.081	2.073185
SumSRL_Base_Core	107.417	2440.437	2.065025
SumSRL_AdvSimd	159.191	1646.726	1.393410
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	159.280	1645.802	1.392629
SumSRLTraits_Core	107.404	2440.722	2.065266
SumSRLConstTraits	107.453	2439.613	2.064328
SumSRLConstTraits_Core	107.197	2445.451	2.069268
SumSRL128Bcl	107.180	2445.821	2.069581
SumSRL128Traits	158.837	1650.400	1.396520
SumSRL128Traits_Core	107.073	2448.262	2.071647
SumSRL128ConstTraits	107.256	2444.106	2.068130
SumSRL128ConstTraits_Core	107.575	2436.851	2.061991
SumSRLFast_AdvSimd	108.295	2420.647	2.048279
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	108.366	2419.072	2.046946

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	315.680	830.410
SumSRLNetBcl	13.211	19843.063	23.895496
SumSRLNetBcl_Const	13.214	19839.003	23.890608
SumSRL_Basic	26.366	9942.338	11.972803
SumSRL_Base_Core	15.505	16906.827	20.359611
SumSRL_AdvSimd	13.227	19819.532	23.867159
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	13.218	19832.865	23.883215
SumSRLTraits_Core	13.223	19825.349	23.874165
SumSRLConstTraits	13.217	19834.510	23.885197
SumSRLConstTraits_Core	13.220	19829.721	23.879430
SumSRL128Bcl	13.215	19836.369	23.887435
SumSRL128Traits	13.221	19827.874	23.877206
SumSRL128Traits_Core	13.225	19821.830	23.869928
SumSRL128ConstTraits	13.214	19838.864	23.890440
SumSRL128ConstTraits_Core	13.245	19791.258	23.833112
SumSRL512Bcl	8.681	30197.002	36.363960
SumSRL512Traits	8.691	30162.905	36.322900
SumSRLFast_AdvSimd	13.220	19829.887	23.879630
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	13.220	19828.833	23.878361

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	315.732	830.273
SumSRLNetBcl	26.403	9928.701	11.958353
SumSRLNetBcl_Const	26.403	9928.634	11.958272
SumSRL_Basic	26.404	9928.037	11.957554
SumSRL_Base_Core	26.398	9930.594	11.960634
SumSRL_AdvSimd	26.401	9929.409	11.959206
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	26.394	9931.876	11.962177
SumSRLTraits_Core	26.408	9926.691	11.955933
SumSRLConstTraits	26.396	9931.359	11.961555
SumSRLConstTraits_Core	26.400	9929.735	11.959598
SumSRL128Bcl	26.406	9927.582	11.957006
SumSRL128Traits	26.395	9931.620	11.961869
SumSRL128Traits_Core	26.401	9929.405	11.959201
SumSRL128ConstTraits	26.400	9929.538	11.959361
SumSRL128ConstTraits_Core	26.400	9929.605	11.959442
SumSRL512Bcl	16.694	15702.931	18.912967
SumSRL512Traits	16.705	15692.269	18.900126
SumSRLFast_AdvSimd	26.410	9926.063	11.955176
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	26.390	9933.448	11.964070

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	210.851	1243.268
SumSRLNetBcl	53.856	4867.524	3.915103
SumSRLNetBcl_Const	53.330	4915.467	3.953665
SumSRL_Basic	53.387	4910.214	3.949440
SumSRL_Base_Core	53.317	4916.727	3.954679
SumSRL_AdvSimd	53.516	4898.382	3.939923
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	53.461	4903.459	3.944007
SumSRLTraits_Core	53.592	4891.438	3.934338
SumSRLConstTraits	53.335	4915.003	3.953292
SumSRLConstTraits_Core	53.345	4914.166	3.952619
SumSRL128Bcl	53.294	4918.795	3.956342
SumSRL128Traits	53.297	4918.562	3.956154
SumSRL128Traits_Core	53.604	4890.365	3.933475
SumSRL128ConstTraits	53.294	4918.806	3.956351
SumSRL128ConstTraits_Core	53.382	4910.695	3.949827
SumSRL512Bcl	34.619	7572.263	6.090610
SumSRL512Traits	34.686	7557.656	6.078861
SumSRLFast_AdvSimd	53.413	4907.853	3.947541
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	53.407	4908.459	3.948028

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	210.789	1243.630
SumSRLNetBcl	105.951	2474.209	1.989507
SumSRLNetBcl_Const	105.991	2473.276	1.988756
SumSRL_Basic	106.172	2469.050	1.985358
SumSRL_Base_Core	105.991	2473.268	1.988750
SumSRL_AdvSimd	107.136	2446.845	1.967503
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	106.439	2462.860	1.980381
SumSRLTraits_Core	106.360	2464.689	1.981851
SumSRLConstTraits	106.209	2468.182	1.984660
SumSRLConstTraits_Core	106.096	2470.810	1.986773
SumSRL128Bcl	106.006	2472.926	1.988475
SumSRL128Traits	106.487	2461.742	1.979481
SumSRL128Traits_Core	106.189	2468.665	1.985049
SumSRL128ConstTraits	106.032	2472.309	1.987978
SumSRL128ConstTraits_Core	105.989	2473.302	1.988777
SumSRL512Bcl	68.016	3854.176	3.099135
SumSRL512Traits	67.932	3858.902	3.102936
SumSRLFast_AdvSimd	106.183	2468.789	1.985148
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	106.310	2465.848	1.982783

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


[ShiftRightLogicalConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	97
SumSRLScalar	9630.208	27.221
SumSRLNetBcl	789.779	331.921	12.193554
SumSRLNetBcl_Const	864.583	303.203	11.138554
SumSRL_Basic	5697.396	46.011	1.690282
SumSRL_Base_Core	5950.000	44.058	1.618522
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	995.898	263.224	9.669870
SumSRLTraits_Core	1028.060	254.989	9.367361
SumSRLConstTraits	1121.745	233.693	8.585026
SumSRLConstTraits_Core	1087.500	241.052	8.855364
SumSRL128Bcl	815.169	321.582	11.813753
SumSRL128Traits	786.654	333.239	12.241993
SumSRL128Traits_Core	798.958	328.107	12.053455
SumSRL128ConstTraits	847.461	309.329	11.363601
SumSRL128ConstTraits_Core	871.419	300.824	11.051177
SumSRL512Bcl	4106.250	63.840	2.345256
SumSRL512Traits	4505.729	58.180	2.137325
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	1064.974	246.151	9.042670

[ShiftRightLogicalConstBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	20269
SumSRLScalar	9387.500	27.925
SumSRLNetBcl	1547.786	169.367	6.065113
SumSRLNetBcl_Const	1727.604	151.738	5.433826
SumSRL_Basic	1585.156	165.374	5.922129
SumSRL_Base_Core	1531.901	171.123	6.128007
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	1969.010	133.135	4.767623
SumSRLTraits_Core	1995.052	131.397	4.705391
SumSRLConstTraits	2208.854	118.679	4.249941
SumSRLConstTraits_Core	2072.396	126.493	4.529781
SumSRL128Bcl	1618.750	161.942	5.799228
SumSRL128Traits	1572.526	166.702	5.969694
SumSRL128Traits_Core	1544.141	169.767	6.079433
SumSRL128ConstTraits	1661.979	157.730	5.648386
SumSRL128ConstTraits_Core	1700.130	154.191	5.521636
SumSRL512Bcl	8235.417	31.831	1.139894
SumSRL512Traits	8283.333	31.647	1.133300
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	2043.750	128.266	4.593272

[ShiftRightLogicalConstBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	1913540397
SumSRLScalar	8046.354	32.579
SumSRLNetBcl	3199.219	81.940	2.515100
SumSRLNetBcl_Const	3443.229	76.133	2.336863
SumSRL_Basic	3111.198	84.258	2.586256
SumSRL_Base_Core	3203.385	81.833	2.511828
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	4047.396	64.769	1.988032
SumSRLTraits_Core	4134.375	63.406	1.946208
SumSRLConstTraits	4336.979	60.444	1.855290
SumSRLConstTraits_Core	4395.833	59.635	1.830450
SumSRL128Bcl	3063.542	85.569	2.626488
SumSRL128Traits	3161.979	82.905	2.544721
SumSRL128Traits_Core	3114.062	84.181	2.583877
SumSRL128ConstTraits	3378.125	77.600	2.381899
SumSRL128ConstTraits_Core	3293.490	79.595	2.443109
SumSRL512Bcl	15495.833	16.917	0.519259
SumSRL512Traits	16329.167	16.054	0.492760
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	4051.562	64.702	1.985988

[ShiftRightLogicalConstBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRLScalar	2955186131785938676
SumSRLScalar	8334.375	31.453
SumSRLNetBcl	25033.333	10.472	0.332931
SumSRLNetBcl_Const	24700.000	10.613	0.337424
SumSRL_Basic	24200.000	10.832	0.344396
SumSRL_Base_Core	23629.167	11.094	0.352716
SumSRL_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLTraits	12561.458	20.869	0.663488
SumSRLTraits_Core	12361.458	21.207	0.674223
SumSRLConstTraits	12989.583	20.181	0.641620
SumSRLConstTraits_Core	13351.042	19.635	0.624249
SumSRL128Bcl	56766.667	4.618	0.146818
SumSRL128Traits	6172.917	42.467	1.350152
SumSRL128Traits_Core	6215.625	42.175	1.340875
SumSRL128ConstTraits	6857.292	38.229	1.215403
SumSRL128ConstTraits_Core	6927.083	37.843	1.203158
SumSRL512Bcl	78750.000	3.329	0.105833
SumSRL512Traits	37725.000	6.949	0.220924
SumSRLFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSRLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRLFastTraits	27579.167	9.505	0.302198

```

