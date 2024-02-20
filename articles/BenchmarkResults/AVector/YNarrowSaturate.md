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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9181.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
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
SumNarrow_If	1241.179	211.206
SumNarrow_IfUnrolling4	1234.330	212.378	1.005548
SumNarrow_MinMax	1297.529	202.033	0.956571
SumNarrow_MinMaxUnrolling4	1281.432	204.571	0.968587
SumNarrow_BitMath	1196.844	219.029	1.037043
SumNarrow_BitMathUnrolling4	841.484	311.526	1.474989
SumNarrowVectorBase	17.721	14793.244	70.041878
SumNarrowVectorTraits	17.733	14782.421	69.990635

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1234.181	212.403
SumNarrow_MinMax	1227.662	213.531	1.005310
SumNarrow_BitMath	600.322	436.672	2.055865
SumNarrowVectorBase	35.769	7328.868	34.504507
SumNarrowVectorTraits	35.762	7330.222	34.510883

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1316.407	199.136
SumNarrow_MinMax	1383.891	189.425	0.951236
SumNarrow_BitMath	778.685	336.650	1.690551
SumNarrowVectorBase	121.608	2155.644	10.824982
SumNarrowVectorTraits	121.903	2150.434	10.798820

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	230.124	1139.144
SumNarrow_IfUnrolling4	241.765	1084.292	0.951848
SumNarrow_MinMax	204.902	1279.363	1.123091
SumNarrow_MinMaxUnrolling4	224.320	1168.619	1.025874
SumNarrow_BitMath	441.604	593.618	0.521108
SumNarrow_BitMathUnrolling4	592.319	442.572	0.388513
SumNarrowVectorBase	18.922	13854.173	12.161914
SumNarrowVectorTraits	16.629	15764.572	13.838962

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	238.258	1100.254
SumNarrow_MinMax	238.804	1097.739	0.997714
SumNarrow_BitMath	507.175	516.870	0.469774
SumNarrowVectorBase	32.036	8182.667	7.437069
SumNarrowVectorTraits	31.928	8210.368	7.462247

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	237.839	1102.191
SumNarrow_MinMax	270.242	970.035	0.880097
SumNarrow_BitMath	365.027	718.150	0.651566
SumNarrowVectorBase	132.800	1973.970	1.790952
SumNarrowVectorTraits	133.254	1967.249	1.784853

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Vector128 type is not supported! Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Vector128 type is not supported! Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

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
SumNarrow_If	1241.006	211.235
SumNarrow_IfUnrolling4	1232.766	212.647	1.006684
SumNarrow_MinMax	1215.786	215.617	1.020744
SumNarrow_MinMaxUnrolling4	1226.750	213.690	1.011621
SumNarrow_BitMath	1196.055	219.174	1.037583
SumNarrow_BitMathUnrolling4	838.909	312.482	1.479310
SumNarrowVectorBase	17.961	14594.956	69.093453
SumNarrowVectorTraits	17.995	14567.667	68.964263

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1237.172	211.890
SumNarrow_MinMax	1223.009	214.344	1.011581
SumNarrow_BitMath	597.808	438.508	2.069513
SumNarrowVectorBase	40.725	6436.945	30.378756
SumNarrowVectorTraits	40.694	6441.769	30.401523

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1355.164	193.441
SumNarrow_MinMax	1346.373	194.704	1.006529
SumNarrow_BitMath	778.158	336.878	1.741502
SumNarrowVectorBase	144.746	1811.065	9.362370
SumNarrowVectorTraits	144.786	1810.563	9.359777

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	223.538	1172.706
SumNarrow_IfUnrolling4	244.494	1072.189	0.914286
SumNarrow_MinMax	206.629	1268.667	1.081828
SumNarrow_MinMaxUnrolling4	227.761	1150.962	0.981458
SumNarrow_BitMath	444.534	589.705	0.502858
SumNarrow_BitMathUnrolling4	552.051	474.855	0.404922
SumNarrowVectorBase	15.282	17153.327	14.627128
SumNarrowVectorTraits	15.259	17179.748	14.649658

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	236.009	1110.737
SumNarrow_MinMax	236.493	1108.466	0.997955
SumNarrow_BitMath	505.345	518.743	0.467025
SumNarrowVectorBase	36.050	7271.608	6.546650
SumNarrowVectorTraits	34.877	7516.248	6.766900

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	238.191	1100.560
SumNarrow_MinMax	278.230	942.185	0.856096
SumNarrow_BitMath	364.029	720.117	0.654319
SumNarrowVectorBase	131.550	1992.738	1.810659
SumNarrowVectorTraits	131.093	1999.682	1.816968

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Vector128 type is not supported! Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Vector128 type is not supported! Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

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
SumNarrow_If	1311.938	199.814
SumNarrow_IfUnrolling4	1258.212	208.346	1.042700
SumNarrow_MinMax	1226.676	213.703	1.069507
SumNarrow_MinMaxUnrolling4	1214.370	215.868	1.080345
SumNarrow_BitMath	1210.796	216.506	1.083533
SumNarrow_BitMathUnrolling4	784.871	333.996	1.671533
SumNarrowVectorBase	20.191	12983.366	64.977139
SumNarrowVectorTraits	9.566	27402.494	137.139750
SumNarrowVector128Traits	13.252	19780.845	98.996102
SumNarrowVector256Traits	10.476	25022.832	125.230389

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1251.864	209.403
SumNarrow_MinMax	1234.810	212.295	1.013812
SumNarrow_BitMath	746.339	351.240	1.677340
SumNarrowVectorBase	41.002	6393.459	30.531861
SumNarrowVectorTraits	20.795	12605.875	60.199151
SumNarrowVector128Traits	26.197	10006.815	47.787383
SumNarrowVector256Traits	21.140	12400.620	59.218963

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1343.204	195.163
SumNarrow_MinMax	1329.448	197.183	1.010347
SumNarrow_BitMath	778.662	336.660	1.725017
SumNarrowVectorBase	131.576	1992.334	10.208556
SumNarrowVectorTraits	99.963	2622.413	13.437031
SumNarrowVector128Traits	237.434	1104.069	5.657158
SumNarrowVector256Traits	97.890	2677.933	13.721509

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	295.475	887.194
SumNarrow_IfUnrolling4	243.765	1075.396	1.212131
SumNarrow_MinMax	245.172	1069.224	1.205175
SumNarrow_MinMaxUnrolling4	231.916	1130.341	1.274063
SumNarrow_BitMath	444.405	589.877	0.664879
SumNarrow_BitMathUnrolling4	535.191	489.814	0.552093
SumNarrowVectorBase	17.481	14995.656	16.902339
SumNarrowVectorTraits	11.461	22872.614	25.780845
SumNarrowVector128Traits	16.893	15517.500	17.490535
SumNarrowVector256Traits	12.592	20817.935	23.464916

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	236.604	1107.943
SumNarrow_MinMax	239.441	1094.819	0.988155
SumNarrow_BitMath	592.981	442.078	0.399008
SumNarrowVectorBase	31.224	8395.651	7.577693
SumNarrowVectorTraits	22.119	11851.530	10.696878
SumNarrowVector128Traits	34.813	7530.084	6.796455
SumNarrowVector256Traits	31.076	8435.503	7.613662

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	270.730	968.287
SumNarrow_MinMax	253.105	1035.713	1.069634
SumNarrow_BitMath	364.616	718.959	0.742506
SumNarrowVectorBase	132.118	1984.173	2.049157
SumNarrowVectorTraits	92.900	2821.784	2.914202
SumNarrowVector128Traits	160.915	1629.080	1.682434
SumNarrowVector256Traits	95.562	2743.174	2.833017

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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
SumNarrow_If	1244.953	210.565
SumNarrow_IfUnrolling4	1259.750	208.092	0.988254
SumNarrow_MinMax	1241.680	211.120	1.002636
SumNarrow_MinMaxUnrolling4	1211.975	216.295	1.027210
SumNarrow_BitMath	1211.218	216.430	1.027852
SumNarrow_BitMathUnrolling4	1139.667	230.018	1.092383
SumNarrowVectorBase	20.178	12991.361	61.697535
SumNarrowVectorTraits	9.303	28177.932	133.820389
SumNarrowVector128Traits	12.519	20940.190	99.447480
SumNarrowVector256Traits	9.373	27967.887	132.822858

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1220.376	214.806
SumNarrow_MinMax	1271.499	206.169	0.959793
SumNarrow_BitMath	1035.367	253.189	1.178689
SumNarrowVectorBase	37.674	6958.181	32.392873
SumNarrowVectorTraits	20.790	12609.236	58.700599
SumNarrowVector128Traits	25.272	10372.773	48.289046
SumNarrowVector256Traits	19.263	13608.797	63.353921

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1341.707	195.381
SumNarrow_MinMax	1347.258	194.576	0.995879
SumNarrow_BitMath	959.799	273.124	1.397904
SumNarrowVectorBase	131.787	1989.150	10.180875
SumNarrowVectorTraits	96.631	2712.830	13.884820
SumNarrowVector128Traits	144.793	1810.473	9.266371
SumNarrowVector256Traits	95.597	2742.175	14.035012

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	244.374	1072.717
SumNarrow_IfUnrolling4	240.780	1088.726	1.014924
SumNarrow_MinMax	290.301	903.006	0.841794
SumNarrow_MinMaxUnrolling4	229.606	1141.715	1.064321
SumNarrow_BitMath	901.825	290.682	0.270977
SumNarrow_BitMathUnrolling4	897.923	291.945	0.272155
SumNarrowVectorBase	15.140	17314.459	16.140757
SumNarrowVectorTraits	10.259	25552.227	23.820108
SumNarrowVector128Traits	15.046	17423.259	16.242182
SumNarrowVector256Traits	10.241	25597.733	23.862530

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	284.149	922.558
SumNarrow_MinMax	285.455	918.338	0.995425
SumNarrow_BitMath	1017.229	257.704	0.279336
SumNarrowVectorBase	32.981	7948.449	8.615664
SumNarrowVectorTraits	25.113	10438.577	11.314820
SumNarrowVector128Traits	31.593	8297.610	8.994134
SumNarrowVector256Traits	26.941	9730.171	10.546949

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	273.946	956.920
SumNarrow_MinMax	309.483	847.039	0.885172
SumNarrow_BitMath	467.259	561.025	0.586282
SumNarrowVectorBase	104.272	2514.030	2.627210
SumNarrowVectorTraits	83.523	3138.589	3.279886
SumNarrowVector128Traits	126.663	2069.612	2.162784
SumNarrowVector256Traits	84.370	3107.071	3.246950

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
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
SumNarrow_If	1317.971	198.900
SumNarrow_IfUnrolling4	1263.131	207.535	1.043416
SumNarrow_MinMax	1292.990	202.743	1.019321
SumNarrow_MinMaxUnrolling4	1324.740	197.883	0.994891
SumNarrow_BitMath	946.226	277.042	1.392872
SumNarrow_BitMathUnrolling4	943.517	277.837	1.396871
SumNarrowVectorBase	20.058	13069.429	65.708675
SumNarrowVectorTraits	9.315	28143.026	141.493630
SumNarrowVector128Traits	13.481	19445.021	97.762997
SumNarrowVector256Traits	9.963	26313.047	132.293113

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1229.358	213.236
SumNarrow_MinMax	1279.623	204.860	0.960719
SumNarrow_BitMath	1043.970	251.103	1.177580
SumNarrowVectorBase	39.021	6717.988	31.504870
SumNarrowVectorTraits	20.147	13011.709	61.020085
SumNarrowVector128Traits	26.854	9761.752	45.778992
SumNarrowVector256Traits	20.406	12846.609	60.245827

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1341.365	195.431
SumNarrow_MinMax	1354.743	193.501	0.990125
SumNarrow_BitMath	958.338	273.540	1.399678
SumNarrowVectorBase	126.495	2072.373	10.604127
SumNarrowVectorTraits	97.531	2687.793	13.753167
SumNarrowVector128Traits	145.309	1804.040	9.231090
SumNarrowVector256Traits	97.668	2684.040	13.733964

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	244.741	1071.106
SumNarrow_IfUnrolling4	239.428	1094.874	1.022191
SumNarrow_MinMax	291.117	900.476	0.840698
SumNarrow_MinMaxUnrolling4	343.354	763.479	0.712795
SumNarrow_BitMath	903.662	290.091	0.270833
SumNarrow_BitMathUnrolling4	898.172	291.864	0.272489
SumNarrowVectorBase	15.059	17408.140	16.252495
SumNarrowVectorTraits	10.579	24779.344	23.134359
SumNarrowVector128Traits	15.090	17371.587	16.218368
SumNarrowVector256Traits	9.956	26331.427	24.583407

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	282.445	928.123
SumNarrow_MinMax	285.299	918.839	0.989997
SumNarrow_BitMath	1014.087	258.503	0.278522
SumNarrowVectorBase	31.755	8255.077	8.894379
SumNarrowVectorTraits	21.394	12252.967	13.201880
SumNarrowVector128Traits	29.111	9004.931	9.702304
SumNarrowVector256Traits	21.111	12417.313	13.378953

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	276.015	949.745
SumNarrow_MinMax	274.122	956.304	1.006907
SumNarrow_BitMath	465.276	563.416	0.593229
SumNarrowVectorBase	100.626	2605.120	2.742968
SumNarrowVectorTraits	75.976	3450.373	3.632947
SumNarrowVector128Traits	140.824	1861.497	1.959997
SumNarrowVector256Traits	79.816	3284.344	3.458133

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
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
SumNarrow_If	1195.324	219.308
SumNarrow_IfUnrolling4	1251.860	209.404	0.954838
SumNarrow_MinMax	1198.523	218.723	0.997330
SumNarrow_MinMaxUnrolling4	1244.248	210.685	0.960679
SumNarrow_BitMath	731.569	358.331	1.633917
SumNarrow_BitMathUnrolling4	782.848	334.859	1.526891
SumNarrowVectorBase	17.221	15222.161	69.409973
SumNarrowVectorTraits	9.768	26837.426	122.373230
SumNarrowVector128Traits	13.549	19348.183	88.223796
SumNarrowVector256Traits	10.423	25150.817	114.682634

[YNarrowSaturateBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	25440
SumNarrow_If	1179.344	222.279
SumNarrow_MinMax	1252.672	209.268	0.941463
SumNarrow_BitMath	608.182	431.029	1.939131
SumNarrowVectorBase	34.823	7527.988	33.867225
SumNarrowVectorTraits	18.826	13924.525	62.644229
SumNarrowVector128Traits	24.943	10509.882	47.282292
SumNarrowVector256Traits	20.357	12877.617	57.934356

[YNarrowSaturateBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	1070749362
SumNarrow_If	1270.552	206.323
SumNarrow_MinMax	1294.248	202.545	0.981692
SumNarrow_BitMath	611.717	428.538	2.077027
SumNarrowVectorBase	98.140	2671.110	12.946257
SumNarrowVectorTraits	109.132	2402.076	11.642313
SumNarrowVector128Traits	179.266	1462.316	7.087510
SumNarrowVector256Traits	113.715	2305.279	11.173160

[YNarrowSaturateBenchmark_UInt16(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	123
SumNarrow_If	244.036	1074.200
SumNarrow_IfUnrolling4	239.471	1094.679	1.019065
SumNarrow_MinMax	331.995	789.603	0.735062
SumNarrow_MinMaxUnrolling4	299.273	875.937	0.815432
SumNarrow_BitMath	446.971	586.490	0.545979
SumNarrow_BitMathUnrolling4	442.770	592.054	0.551158
SumNarrowVectorBase	15.940	16445.564	15.309592
SumNarrowVectorTraits	11.375	23045.907	21.454018
SumNarrowVector128Traits	17.784	14740.467	13.722274
SumNarrowVector256Traits	11.525	22746.312	21.175118

[YNarrowSaturateBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	52166
SumNarrow_If	235.024	1115.390
SumNarrow_MinMax	307.024	853.824	0.765493
SumNarrow_BitMath	389.031	673.838	0.604127
SumNarrowVectorBase	27.062	9686.684	8.684569
SumNarrowVectorTraits	21.065	12444.481	11.157063
SumNarrowVector128Traits	35.942	7293.592	6.539049
SumNarrowVector256Traits	23.280	11260.585	10.095645

[YNarrowSaturateBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumNarrow_If	4294705152
SumNarrow_If	240.880	1088.277
SumNarrow_MinMax	320.961	816.746	0.750494
SumNarrow_BitMath	400.901	653.886	0.600845
SumNarrowVectorBase	80.076	3273.703	3.008151
SumNarrowVectorTraits	84.420	3105.248	2.853361
SumNarrowVector128Traits	161.005	1628.177	1.496105
SumNarrowVector256Traits	111.721	2346.411	2.156078

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(32!=16) !
VectorTraits128Sse: Requires hardware support Sse, Sse2! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

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

