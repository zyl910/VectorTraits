# Benchmark - YNarrowSaturateUnsigned
([← Back](README.md))

See [Group](YNarrowSaturateUnsigned_Group.md)

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1281.465	204.566
SumNarrow_IfUnrolling4	1225.137	213.971	1.045976
SumNarrow_MinMax	1302.373	201.282	0.983946
SumNarrow_MinMaxUnrolling4	1274.831	205.630	1.005204
SumNarrow_BitMath	1072.399	244.446	1.194952
SumNarrow_BitMathUnrolling4	689.606	380.136	1.858257
SumNarrowVectorBase	11.209	23385.952	114.319875
SumNarrowVectorTraits	10.627	24667.072	120.582502

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1199.540	218.537
SumNarrow_MinMax	1211.474	216.384	0.990149
SumNarrow_BitMath	503.028	521.132	2.384637
SumNarrowVectorBase	23.623	11097.054	50.778815
SumNarrowVectorTraits	24.717	10605.861	48.531174

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	773.257	339.013
SumNarrow_MinMax	732.190	358.027	1.056088
SumNarrow_BitMath	535.543	489.492	1.443875
SumNarrowVectorBase	84.045	3119.099	9.200529
SumNarrowVectorTraits	84.178	3114.160	9.185961

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1279.461	204.886
SumNarrow_IfUnrolling4	1293.999	202.584	0.988765
SumNarrow_MinMax	1320.565	198.509	0.968874
SumNarrow_MinMaxUnrolling4	1230.698	213.004	1.039622
SumNarrow_BitMath	1081.344	242.424	1.183213
SumNarrow_BitMathUnrolling4	705.904	371.359	1.812515
SumNarrowVectorBase	11.716	22375.153	109.207687
SumNarrowVectorTraits	12.065	21727.224	106.045301

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1237.986	211.750
SumNarrow_MinMax	1267.434	206.831	0.976766
SumNarrow_BitMath	520.832	503.318	2.376940
SumNarrowVectorBase	24.689	10617.703	50.142548
SumNarrowVectorTraits	25.809	10157.029	47.966995

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	867.765	302.091
SumNarrow_MinMax	733.646	357.317	1.182812
SumNarrow_BitMath	579.793	452.134	1.496681
SumNarrowVectorBase	89.840	2917.896	9.658996
SumNarrowVectorTraits	90.805	2886.879	9.556321

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1305.123	200.858
SumNarrow_IfUnrolling4	1285.579	203.911	1.015202
SumNarrow_MinMax	1306.880	200.588	0.998655
SumNarrow_MinMaxUnrolling4	1242.205	211.031	1.050650
SumNarrow_BitMath	800.313	327.552	1.630765
SumNarrow_BitMathUnrolling4	663.618	395.023	1.966679
SumNarrowVectorBase	12.343	21237.894	105.736017
SumNarrowVectorTraits	5.697	46012.334	229.079255
SumNarrowVector128Traits	7.899	33188.764	165.235199
SumNarrowVector256Traits	5.984	43806.819	218.098768

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1299.272	201.762
SumNarrow_MinMax	1259.122	208.196	1.031887
SumNarrow_BitMath	550.169	476.479	2.361588
SumNarrowVectorBase	24.992	10489.047	51.987162
SumNarrowVectorTraits	13.196	19865.697	98.460917
SumNarrowVector128Traits	17.472	15003.431	74.361933
SumNarrowVector256Traits	13.241	19797.669	98.123747

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	825.299	317.635
SumNarrow_MinMax	785.507	333.726	1.050658
SumNarrow_BitMath	564.631	464.275	1.461661
SumNarrowVectorBase	88.099	2975.578	9.367912
SumNarrowVectorTraits	50.678	5172.740	16.285165
SumNarrowVector128Traits	140.234	1869.335	5.885166
SumNarrowVector256Traits	52.928	4952.862	15.592931

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1333.598	196.569
SumNarrow_IfUnrolling4	1257.269	208.503	1.060710
SumNarrow_MinMax	1241.716	211.114	1.073996
SumNarrow_MinMaxUnrolling4	1222.955	214.353	1.090472
SumNarrow_BitMath	1334.285	196.468	0.999485
SumNarrow_BitMathUnrolling4	1274.695	205.652	1.046210
SumNarrowVectorBase	11.825	22168.532	112.777383
SumNarrowVectorTraits	5.756	45545.738	231.703619
SumNarrowVector128Traits	7.935	33036.160	168.063976
SumNarrowVector256Traits	5.898	44447.391	226.116025

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1222.630	214.410
SumNarrow_MinMax	1242.884	210.916	0.983704
SumNarrow_BitMath	1244.345	210.668	0.982549
SumNarrowVectorBase	24.013	10916.806	50.915575
SumNarrowVectorTraits	12.723	20603.756	96.095148
SumNarrowVector128Traits	17.333	15124.086	70.538174
SumNarrowVector256Traits	13.063	20067.368	93.593455

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	784.771	334.039
SumNarrow_MinMax	754.484	347.448	1.040143
SumNarrow_BitMath	925.213	283.334	0.848206
SumNarrowVectorBase	84.493	3102.540	9.287962
SumNarrowVectorTraits	49.246	5323.134	15.935675
SumNarrowVector128Traits	88.871	2949.720	8.830471
SumNarrowVector256Traits	48.726	5379.993	16.105891

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1298.578	201.870
SumNarrow_IfUnrolling4	1262.119	207.701	1.028887
SumNarrow_MinMax	1316.659	199.098	0.986267
SumNarrow_MinMaxUnrolling4	1334.312	196.464	0.973219
SumNarrow_BitMath	1282.887	204.339	1.012230
SumNarrow_BitMathUnrolling4	1159.960	225.994	1.119503
SumNarrowVectorBase	11.633	22533.669	111.624596
SumNarrowVectorTraits	5.753	45563.894	225.708969
SumNarrowVector128Traits	8.126	32261.256	159.811950
SumNarrowVector256Traits	5.755	45547.634	225.628424

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1243.682	210.781
SumNarrow_MinMax	1289.054	203.361	0.964802
SumNarrow_BitMath	1246.817	210.251	0.997486
SumNarrowVectorBase	24.833	10556.129	50.081115
SumNarrowVectorTraits	13.697	19138.145	90.796509
SumNarrowVector128Traits	18.956	13829.367	65.610239
SumNarrowVector256Traits	14.621	17929.312	85.061478

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	865.986	302.711
SumNarrow_MinMax	797.264	328.805	1.086198
SumNarrow_BitMath	917.591	285.687	0.943761
SumNarrowVectorBase	83.780	3128.956	10.336428
SumNarrowVectorTraits	50.521	5188.831	17.141174
SumNarrowVector128Traits	87.743	2987.632	9.869567
SumNarrowVector256Traits	48.910	5359.762	17.705842

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1264.871	207.250
SumNarrow_IfUnrolling4	1264.681	207.281	1.000151
SumNarrow_MinMax	1241.380	211.171	1.018924
SumNarrow_MinMaxUnrolling4	1220.899	214.714	1.036016
SumNarrow_BitMath	872.084	300.595	1.450400
SumNarrow_BitMathUnrolling4	871.271	300.875	1.451754
SumNarrowVectorBase	12.126	21617.735	104.307762
SumNarrowVectorTraits	6.134	42736.043	206.205735
SumNarrowVector128Base	17.760	14760.317	71.220023
SumNarrowVector128Traits	8.633	30363.995	146.509350
SumNarrowVector256Traits	6.107	42928.277	207.133284

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1171.030	223.858
SumNarrow_MinMax	1263.991	207.394	0.926455
SumNarrow_BitMath	622.699	420.980	1.880571
SumNarrowVectorBase	24.041	10904.109	48.710038
SumNarrowVectorTraits	13.550	19347.025	86.425612
SumNarrowVector128Base	58.661	4468.766	19.962542
SumNarrowVector128Traits	17.240	15205.261	67.923829
SumNarrowVector256Traits	13.728	19095.417	85.301648

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	765.916	342.262
SumNarrow_MinMax	644.608	406.672	1.188190
SumNarrow_BitMath	720.062	364.057	1.063680
SumNarrowVectorBase	60.744	4315.586	12.609015
SumNarrowVectorTraits	59.216	4426.876	12.934174
SumNarrowVector128Base	109.728	2389.026	6.980111
SumNarrowVector128Traits	109.703	2389.584	6.981740
SumNarrowVector256Traits	61.332	4274.156	12.487967

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1190.214	220.250
SumNarrow_IfUnrolling4	1176.909	222.739	1.011304
SumNarrow_MinMax	1194.828	219.399	0.996138
SumNarrow_MinMaxUnrolling4	1157.147	226.543	1.028576
SumNarrow_BitMath	572.437	457.944	2.079205
SumNarrow_BitMathUnrolling4	550.654	476.060	2.161456
SumNarrowVectorBase	8.793	29813.964	135.364468
SumNarrowVectorTraits	5.541	47311.328	214.807828
SumNarrowVector128Base	15.436	16982.692	77.106591
SumNarrowVector128Traits	7.967	32905.138	149.399342
SumNarrowVector256Traits	5.608	46743.004	212.227464
SumNarrowVector512Base	7.831	33476.107	151.991716
SumNarrowVector512Traits	5.708	45927.865	208.526487
SumNarrowVector512_Convert	5.953	44036.810	199.940518

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1091.615	240.143
SumNarrow_MinMax	1166.919	224.646	0.935468
SumNarrow_BitMath	391.434	669.702	2.788763
SumNarrowVectorBase	19.848	13207.897	55.000089
SumNarrowVectorTraits	13.485	19440.267	80.952812
SumNarrowVector128Base	30.277	8658.311	36.054784
SumNarrowVector128Traits	17.054	15370.970	64.007520
SumNarrowVector256Traits	13.294	19718.755	82.112487
SumNarrowVector512Base	15.621	16781.059	69.879388
SumNarrowVector512Traits	13.136	19956.000	83.100420
SumNarrowVector512_Convert	14.049	18659.807	77.702836

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	731.626	358.303
SumNarrow_MinMax	746.318	351.250	0.980314
SumNarrow_BitMath	441.769	593.395	1.656126
SumNarrowVectorBase	37.990	6900.410	19.258573
SumNarrowVectorTraits	28.502	9197.232	25.668848
SumNarrowVector128Base	66.244	3957.278	11.044492
SumNarrowVector128Traits	39.647	6611.977	18.453578
SumNarrowVector256Traits	29.073	9016.782	25.165224
SumNarrowVector512Base	30.842	8499.564	23.721703
SumNarrowVector512Traits	26.789	9785.347	27.310237
SumNarrowVector512_Clamp	30.728	8531.044	23.809563
SumNarrowVector512_Convert	26.795	9783.303	27.304533

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1246.583	210.290
SumNarrow_IfUnrolling4	1219.788	214.910	1.021967
SumNarrow_MinMax	1261.245	207.845	0.988375
SumNarrow_MinMaxUnrolling4	1620.898	161.728	0.769069
SumNarrow_BitMath	1084.412	241.738	1.149547
SumNarrow_BitMathUnrolling4	681.228	384.811	1.829907
SumNarrowVectorBase	16.920	15493.391	73.676288
SumNarrowVectorTraits	16.900	15511.929	73.764444

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1220.923	214.710
SumNarrow_MinMax	1226.086	213.806	0.995790
SumNarrow_BitMath	511.680	512.320	2.386108
SumNarrowVectorBase	34.743	7545.259	35.141689
SumNarrowVectorTraits	34.719	7550.500	35.166095

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	914.514	286.648
SumNarrow_MinMax	931.788	281.334	0.981461
SumNarrow_BitMath	498.701	525.654	1.833793
SumNarrowVectorBase	115.331	2272.961	7.929440
SumNarrowVectorTraits	116.106	2257.793	7.876524

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1287.951	203.536
SumNarrow_IfUnrolling4	1225.024	213.991	1.051368
SumNarrow_MinMax	1218.342	215.164	1.057134
SumNarrow_MinMaxUnrolling4	1192.816	219.769	1.079757
SumNarrow_BitMath	1088.213	240.894	1.183547
SumNarrow_BitMathUnrolling4	682.762	383.947	1.886385
SumNarrowVectorBase	17.652	14850.977	72.964999
SumNarrowVectorTraits	17.586	14906.325	73.236932

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1214.604	215.827
SumNarrow_MinMax	1217.566	215.302	0.997567
SumNarrow_BitMath	508.584	515.439	2.388208
SumNarrowVectorBase	38.576	6795.446	31.485650
SumNarrowVectorTraits	38.734	6767.870	31.357880

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	916.593	285.998
SumNarrow_MinMax	928.013	282.479	0.987694
SumNarrow_BitMath	497.797	526.609	1.841299
SumNarrowVectorBase	137.086	1912.266	6.686283
SumNarrowVectorTraits	137.041	1912.881	6.688434

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1304.080	201.018
SumNarrow_IfUnrolling4	1328.272	197.357	0.981787
SumNarrow_MinMax	1222.789	214.382	1.066480
SumNarrow_MinMaxUnrolling4	1235.679	212.146	1.055356
SumNarrow_BitMath	730.613	358.800	1.784912
SumNarrow_BitMathUnrolling4	623.148	420.677	2.092730
SumNarrowVectorBase	19.209	13646.959	67.889141
SumNarrowVectorTraits	9.194	28513.211	141.843863
SumNarrowVector128Traits	12.412	21120.153	105.065830
SumNarrowVector256Traits	9.216	28443.815	141.498644

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1220.896	214.714
SumNarrow_MinMax	1231.824	212.810	0.991128
SumNarrow_BitMath	527.627	496.836	2.313939
SumNarrowVectorBase	38.819	6752.904	31.450622
SumNarrowVectorTraits	18.309	14317.622	66.682141
SumNarrowVector128Traits	24.527	10688.056	49.777992
SumNarrowVector256Traits	19.185	13664.211	63.638981

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	810.885	323.281
SumNarrow_MinMax	880.350	297.773	0.921094
SumNarrow_BitMath	516.515	507.524	1.569915
SumNarrowVectorBase	122.617	2137.906	6.613144
SumNarrowVectorTraits	92.800	2824.818	8.737957
SumNarrowVector128Traits	213.330	1228.817	3.801077
SumNarrowVector256Traits	92.888	2822.149	8.729700

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1256.799	208.581
SumNarrow_IfUnrolling4	1329.672	197.149	0.945195
SumNarrow_MinMax	1215.412	215.683	1.034052
SumNarrow_MinMaxUnrolling4	1210.498	216.559	1.038250
SumNarrow_BitMath	1049.040	249.889	1.198047
SumNarrow_BitMathUnrolling4	968.818	270.581	1.297250
SumNarrowVectorBase	19.408	13506.832	64.755907
SumNarrowVectorTraits	10.380	25254.194	121.076373
SumNarrowVector128Traits	13.491	19431.592	93.161027
SumNarrowVector256Traits	9.279	28252.470	135.451029

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1220.955	214.704
SumNarrow_MinMax	1235.110	212.243	0.988539
SumNarrow_BitMath	895.245	292.818	1.363821
SumNarrowVectorBase	35.955	7290.861	33.957709
SumNarrowVectorTraits	18.296	14327.770	66.732620
SumNarrowVector128Traits	26.623	9846.518	45.860865
SumNarrowVector256Traits	20.599	12726.347	59.273877

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	848.198	309.060
SumNarrow_MinMax	924.323	283.607	0.917643
SumNarrow_BitMath	705.034	371.817	1.203060
SumNarrowVectorBase	122.189	2145.397	6.941690
SumNarrowVectorTraits	92.578	2831.598	9.161976
SumNarrowVector128Traits	140.284	1868.665	6.046290
SumNarrowVector256Traits	91.749	2857.186	9.244768

[Vectors.Instance: VectorTraits256Avx2]
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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1299.261	201.764
SumNarrow_IfUnrolling4	1281.280	204.595	1.014033
SumNarrow_MinMax	1281.483	204.563	1.013873
SumNarrow_MinMaxUnrolling4	1363.390	192.274	0.952963
SumNarrow_BitMath	855.263	306.507	1.519137
SumNarrow_BitMathUnrolling4	808.367	324.288	1.607266
SumNarrowVectorBase	19.225	13635.746	67.582680
SumNarrowVectorTraits	9.220	28430.918	140.911806
SumNarrowVector128Traits	12.434	21083.352	104.495157
SumNarrowVector256Traits	9.218	28438.840	140.951072

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1233.054	212.597
SumNarrow_MinMax	1215.441	215.678	1.014491
SumNarrow_BitMath	894.924	292.923	1.377831
SumNarrowVectorBase	34.675	7559.980	35.560081
SumNarrowVectorTraits	18.302	14323.482	67.373748
SumNarrowVector128Traits	24.731	10599.796	49.858544
SumNarrowVector256Traits	18.309	14318.085	67.348361

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	818.600	320.234
SumNarrow_MinMax	804.467	325.860	1.017568
SumNarrow_BitMath	705.676	371.479	1.160023
SumNarrowVectorBase	121.246	2162.083	6.751563
SumNarrowVectorTraits	92.144	2844.929	8.883894
SumNarrowVector128Traits	140.676	1863.457	5.819040
SumNarrowVector256Traits	92.371	2837.939	8.862068

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1189.598	220.364
SumNarrow_IfUnrolling4	1263.791	207.427	0.941293
SumNarrow_MinMax	1188.973	220.479	1.000526
SumNarrow_MinMaxUnrolling4	1253.008	209.212	0.949394
SumNarrow_BitMath	653.151	401.353	1.821320
SumNarrow_BitMathUnrolling4	673.158	389.424	1.767191
SumNarrowVectorBase	15.622	16780.535	76.149336
SumNarrowVectorTraits	9.173	28577.130	129.681768
SumNarrowVector128Traits	12.293	21324.347	96.768957
SumNarrowVector256Traits	9.260	28307.930	128.460150

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1175.542	222.998
SumNarrow_MinMax	1260.100	208.034	0.932896
SumNarrow_BitMath	518.986	505.108	2.265076
SumNarrowVectorBase	27.119	9666.440	43.347569
SumNarrowVectorTraits	18.151	14442.278	64.764034
SumNarrowVector128Traits	24.383	10750.941	48.210839
SumNarrowVector256Traits	18.332	14299.886	64.125500

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	796.042	329.309
SumNarrow_MinMax	797.389	328.753	0.998310
SumNarrow_BitMath	572.111	458.205	1.391411
SumNarrowVectorBase	95.012	2759.052	8.378301
SumNarrowVectorTraits	102.058	2568.578	7.799897
SumNarrowVector128Traits	194.470	1347.991	4.093389
SumNarrowVector256Traits	100.936	2597.132	7.886604

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1634.364	160.395
SumNarrow_IfUnrolling4	1647.917	159.076	0.991776
SumNarrow_MinMax	1580.948	165.814	1.033787
SumNarrow_MinMaxUnrolling4	1608.930	162.931	1.015808
SumNarrow_BitMath	1091.329	240.206	1.497590
SumNarrow_BitMathUnrolling4	1106.564	236.899	1.476971
SumNarrowVectorBase	35.438	7397.290	46.119165
SumNarrowVectorTraits	36.421	7197.689	44.874734
SumNarrowVector128Traits	1951.202	134.350	0.837619
SumNarrowVector256Traits	2969.389	88.282	0.550404

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1582.223	165.681
SumNarrow_MinMax	1672.308	156.756	0.946131
SumNarrow_BitMath	905.352	289.549	1.747633
SumNarrowVectorBase	71.141	3684.866	22.240743
SumNarrowVectorTraits	73.050	3588.548	21.659397
SumNarrowVector128Traits	3434.396	76.329	0.460699
SumNarrowVector256Traits	5504.778	47.621	0.287427

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	1080.606	242.590
SumNarrow_MinMax	1511.271	173.459	0.715031
SumNarrow_BitMath	898.216	291.850	1.203058
SumNarrowVectorBase	308.937	848.536	3.497821
SumNarrowVectorTraits	309.000	848.362	3.497105
SumNarrowVector128Traits	4893.934	53.565	0.220805
SumNarrowVector256Traits	6943.508	37.754	0.155628

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1720.420	152.372
SumNarrow_IfUnrolling4	1653.287	158.559	1.040605
SumNarrow_MinMax	1634.514	160.380	1.052558
SumNarrow_MinMaxUnrolling4	1600.674	163.771	1.074810
SumNarrow_BitMath	1436.192	182.527	1.197903
SumNarrow_BitMathUnrolling4	1467.756	178.602	1.172143
SumNarrowVectorBase	36.863	7111.218	46.670071
SumNarrowVectorTraits	19.509	13436.919	88.184892
SumNarrowVector128Traits	20.628	12707.929	83.400618
SumNarrowVector256Traits	3247.986	80.710	0.529688

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1579.413	165.976
SumNarrow_MinMax	1670.547	156.921	0.945447
SumNarrow_BitMath	1202.575	217.986	1.313359
SumNarrowVectorBase	72.873	3597.270	21.673482
SumNarrowVectorTraits	42.541	6162.156	37.126870
SumNarrowVector128Traits	42.930	6106.270	36.790160
SumNarrowVector256Traits	5029.688	52.119	0.314018

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	1091.315	240.209
SumNarrow_MinMax	1211.211	216.431	0.901012
SumNarrow_BitMath	1228.814	213.331	0.888104
SumNarrowVectorBase	192.205	1363.876	5.677867
SumNarrowVectorTraits	84.312	3109.211	12.943763
SumNarrowVector128Traits	83.017	3157.716	13.145692
SumNarrowVector256Traits	8311.447	31.540	0.131303

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1713.531	152.985
SumNarrow_IfUnrolling4	1636.800	160.156	1.046879
SumNarrow_MinMax	1824.774	143.658	0.939037
SumNarrow_MinMaxUnrolling4	1784.589	146.893	0.960182
SumNarrow_BitMath	1442.424	181.738	1.187952
SumNarrow_BitMathUnrolling4	1459.632	179.596	1.173947
SumNarrowVectorBase	35.869	7308.332	47.771647
SumNarrowVectorTraits	20.593	12729.912	83.210346
SumNarrowVector128Traits	20.374	12866.862	84.105536
SumNarrowVector256Traits	4484.999	58.449	0.382058

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1580.290	165.883
SumNarrow_MinMax	1672.019	156.783	0.945139
SumNarrow_BitMath	1203.020	217.905	1.313603
SumNarrowVectorBase	72.852	3598.296	21.691706
SumNarrowVectorTraits	41.854	6263.338	37.757459
SumNarrowVector128Traits	42.202	6211.578	37.445431
SumNarrowVector256Traits	5050.800	51.901	0.312879

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	1083.669	241.904
SumNarrow_MinMax	1078.289	243.111	1.004989
SumNarrow_BitMath	1189.133	220.450	0.911310
SumNarrowVectorBase	194.021	1351.115	5.585333
SumNarrowVectorTraits	79.217	3309.175	13.679700
SumNarrowVector128Traits	78.993	3318.586	13.718604
SumNarrowVector256Traits	8702.196	30.124	0.124528

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1424.876	183.977
SumNarrow_IfUnrolling4	1426.946	183.710	0.998549
SumNarrow_MinMax	1415.969	185.134	1.006290
SumNarrow_MinMaxUnrolling4	1408.358	186.134	1.011728
SumNarrow_BitMath	1168.148	224.410	1.219773
SumNarrow_BitMathUnrolling4	1191.021	220.100	1.196348
SumNarrowVectorBase	33.309	7869.950	42.776870
SumNarrowVectorTraits	16.936	15478.838	84.134746
SumNarrowVector128Base	30.000	8738.074	47.495532
SumNarrowVector128Traits	16.976	15442.255	83.935901
SumNarrowVector256Traits	4139.611	63.326	0.344205

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1368.758	191.520
SumNarrow_MinMax	1330.448	197.034	1.028795
SumNarrow_BitMath	926.378	282.977	1.477537
SumNarrowVectorBase	66.738	3927.945	20.509367
SumNarrowVectorTraits	33.342	7862.189	41.051626
SumNarrowVector128Base	62.991	4161.607	21.729409
SumNarrowVector128Traits	32.578	8046.649	42.014766
SumNarrowVector256Traits	4328.094	60.568	0.316250

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	936.340	279.967
SumNarrow_MinMax	865.470	302.892	1.081887
SumNarrow_BitMath	958.142	273.596	0.977246
SumNarrowVectorBase	176.739	1483.227	5.297870
SumNarrowVectorTraits	64.366	4072.723	14.547176
SumNarrowVector128Base	177.181	1479.529	5.284664
SumNarrowVector128Traits	63.902	4102.271	14.652716
SumNarrowVector256Traits	3585.007	73.122	0.261182

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1347.013	194.611
SumNarrow_IfUnrolling4	1349.445	194.261	0.998198
SumNarrow_MinMax	1319.455	198.676	1.020886
SumNarrow_MinMaxUnrolling4	1294.705	202.474	1.040402
SumNarrow_BitMath	837.159	313.135	1.609029
SumNarrow_BitMathUnrolling4	844.113	310.556	1.595774
SumNarrowVectorBase	30.220	8674.643	44.574200
SumNarrowVectorTraits	19.221	13638.465	70.080538
SumNarrowVector128Base	30.234	8670.476	44.552789
SumNarrowVector128Traits	19.182	13666.103	70.222555
SumNarrowVector256Traits	26.939	9731.132	50.002911
SumNarrowVector512Base	186.945	1402.253	7.205406
SumNarrowVector512Traits	187.075	1401.278	7.200392
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1216.382	215.511
SumNarrow_MinMax	1290.177	203.185	0.942803
SumNarrow_BitMath	591.807	442.955	2.055369
SumNarrowVectorBase	60.058	4364.862	20.253530
SumNarrowVectorTraits	38.844	6748.584	31.314308
SumNarrowVector128Base	59.892	4376.919	20.309475
SumNarrowVector128Traits	39.009	6720.127	31.182268
SumNarrowVector256Traits	55.586	4716.002	21.882865
SumNarrowVector512Base	374.370	700.227	3.249143
SumNarrowVector512Traits	373.776	701.340	3.254309
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	749.188	349.904
SumNarrow_MinMax	866.050	302.689	0.865063
SumNarrow_BitMath	631.133	415.355	1.187053
SumNarrowVectorBase	177.009	1480.964	4.232487
SumNarrowVectorTraits	77.406	3386.608	9.678676
SumNarrowVector128Base	180.470	1452.561	4.151312
SumNarrowVector128Traits	76.564	3423.840	9.785082
SumNarrowVector256Traits	167.892	1561.386	4.462327
SumNarrowVector512Base	831.910	315.111	0.900564
SumNarrowVector512Traits	836.554	313.362	0.895565
SumNarrowVector512_Clamp	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

```

### Apple M2
`Apple M2 @ 3.20 GHz 8 Core`

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	1014.175	258.480
SumNarrow_IfUnrolling4	1009.878	259.580	1.004255
SumNarrow_MinMax	1042.201	251.529	0.973108
SumNarrow_MinMaxUnrolling4	1064.957	246.155	0.952316
SumNarrow_BitMath	426.873	614.103	2.375824
SumNarrow_BitMathUnrolling4	425.985	615.383	2.380774
SumNarrowVectorBase	12.685	20665.236	79.949052
SumNarrowVectorTraits	9.648	27170.537	105.116564
SumNarrowVector128Traits	9.647	27172.855	105.125533
SumNarrowVector256Traits	2049.108	127.931	0.494935

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	1031.085	254.241
SumNarrow_MinMax	1003.270	261.290	1.027724
SumNarrow_BitMath	295.109	888.296	3.493913
SumNarrowVectorBase	25.318	10354.211	40.725966
SumNarrowVectorTraits	19.269	13604.283	53.509398
SumNarrowVector128Traits	19.271	13603.049	53.504542
SumNarrowVector256Traits	2195.621	119.394	0.469610

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	611.276	428.847
SumNarrow_MinMax	561.076	467.216	1.089470
SumNarrow_BitMath	295.658	886.647	2.067512
SumNarrowVectorBase	60.278	4348.938	10.140992
SumNarrowVectorTraits	38.583	6794.318	15.843205
SumNarrowVector128Traits	38.590	6792.998	15.840128
SumNarrowVector256Traits	3922.479	66.831	0.155839

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	840.093	312.042
SumNarrow_IfUnrolling4	831.073	315.428	1.010854
SumNarrow_MinMax	840.487	311.895	0.999532
SumNarrow_MinMaxUnrolling4	843.217	310.886	0.996296
SumNarrow_BitMath	338.087	775.375	2.484845
SumNarrow_BitMathUnrolling4	332.875	787.514	2.523749
SumNarrowVectorBase	12.103	21658.674	69.409590
SumNarrowVectorTraits	9.641	27189.169	87.133176
SumNarrowVector128Base	10.375	25267.009	80.973227
SumNarrowVector128Traits	9.646	27176.156	87.091474
SumNarrowVector256Traits	2532.308	103.520	0.331750

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	870.666	301.085
SumNarrow_MinMax	870.160	301.260	1.000582
SumNarrow_BitMath	237.711	1102.786	3.662711
SumNarrowVectorBase	24.110	10872.741	36.111922
SumNarrowVectorTraits	19.269	13604.371	45.184557
SumNarrowVector128Base	20.535	12765.783	42.399331
SumNarrowVector128Traits	19.261	13610.004	45.203264
SumNarrowVector256Traits	1795.470	146.003	0.484924

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	548.752	477.710
SumNarrow_MinMax	486.555	538.776	1.127832
SumNarrow_BitMath	237.774	1102.491	2.307867
SumNarrowVectorBase	62.630	4185.590	8.761786
SumNarrowVectorTraits	38.528	6803.915	14.242782
SumNarrowVector128Base	62.669	4183.026	8.756418
SumNarrowVector128Traits	38.540	6801.883	14.238528
SumNarrowVector256Traits	1526.381	171.742	0.359512

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	829.168	316.153
SumNarrow_IfUnrolling4	819.942	319.711	1.011252
SumNarrow_MinMax	831.832	315.140	0.996797
SumNarrow_MinMaxUnrolling4	796.223	329.234	1.041376
SumNarrow_BitMath	307.040	853.779	2.700522
SumNarrow_BitMathUnrolling4	304.221	861.691	2.725548
SumNarrowVectorBase	10.366	25288.884	79.989341
SumNarrowVectorTraits	9.641	27189.656	86.001526
SumNarrowVector128Base	10.363	25296.107	80.012186
SumNarrowVector128Traits	9.640	27194.075	86.015506
SumNarrowVector256Traits	9.674	27096.953	85.708305
SumNarrowVector512Base	75.268	3482.798	11.016174
SumNarrowVector512Traits	75.175	3487.108	11.029807
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	817.989	320.474
SumNarrow_MinMax	828.531	316.396	0.987276
SumNarrow_BitMath	208.441	1257.640	3.924315
SumNarrowVectorBase	20.640	12700.998	39.631948
SumNarrowVectorTraits	19.263	13608.357	42.463254
SumNarrowVector128Base	20.631	12706.184	39.648130
SumNarrowVector128Traits	19.265	13607.225	42.459720
SumNarrowVector256Traits	19.227	13634.028	42.543356
SumNarrowVector512Base	149.168	1757.373	5.483672
SumNarrowVector512Traits	149.382	1754.852	5.475807
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	474.947	551.944
SumNarrow_MinMax	540.168	485.301	0.879259
SumNarrow_BitMath	222.089	1180.357	2.138547
SumNarrowVectorBase	60.248	4351.105	7.883243
SumNarrowVectorTraits	38.532	6803.292	12.326066
SumNarrowVector128Base	60.293	4347.833	7.877315
SumNarrowVector128Traits	38.528	6804.021	12.327387
SumNarrowVector256Traits	55.544	4719.562	8.550805
SumNarrowVector512Base	318.856	822.139	1.489534
SumNarrowVector512Traits	319.236	821.161	1.487762
SumNarrowVector512_Clamp	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

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


[YNarrowSaturateUnsignedBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	24
SumNarrow_If	13193.750	19.869
SumNarrow_IfUnrolling4	14184.375	18.481	0.930161
SumNarrow_MinMax	17264.583	15.184	0.764209
SumNarrow_MinMaxUnrolling4	17239.583	15.206	0.765317
SumNarrow_BitMath	30556.250	8.579	0.431786
SumNarrow_BitMathUnrolling4	29466.667	8.896	0.447752
SumNarrowVectorBase	50654.167	5.175	0.260467
SumNarrowVectorTraits	1461.198	179.403	9.029407
SumNarrowVector128Base	57150.000	4.587	0.230862
SumNarrowVector128Traits	1213.151	216.085	10.875604
SumNarrowVector256Traits	68375.000	3.834	0.192962
SumNarrowVector512Base	70775.000	3.704	0.186418
SumNarrowVector512Traits	71125.000	3.686	0.185501
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateUnsignedBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52652
SumNarrow_If	13919.792	18.832
SumNarrow_MinMax	18647.917	14.058	0.746453
SumNarrow_BitMath	26091.667	10.047	0.533496
SumNarrowVectorBase	57637.500	4.548	0.241506
SumNarrowVectorTraits	2923.177	89.678	4.761871
SumNarrowVector128Base	97975.000	2.676	0.142075
SumNarrowVector128Traits	2458.073	106.646	5.662888
SumNarrowVector256Traits	112025.000	2.340	0.124256
SumNarrowVector512Base	118933.333	2.204	0.117039
SumNarrowVector512Traits	121291.667	2.161	0.114763
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

[YNarrowSaturateUnsignedBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294901885
SumNarrow_If	11705.208	22.396
SumNarrow_MinMax	15922.917	16.463	0.735117
SumNarrow_BitMath	26039.583	10.067	0.449516
SumNarrowVectorBase	74008.333	3.542	0.158161
SumNarrowVectorTraits	139433.334	1.880	0.083948
SumNarrowVector128Base	149466.666	1.754	0.078313
SumNarrowVector128Traits	136700.000	1.918	0.085627
SumNarrowVector256Traits	182300.000	1.438	0.064208
SumNarrowVector512Base	195050.000	1.344	0.060011
SumNarrowVector512Traits	195516.667	1.341	0.059868
SumNarrowVector512_Clamp	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!
SumNarrowVector512_Convert	Run fail! Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi!

```

