# Benchmark - Ceiling
([← Back](README.md))
See [Group](Ceiling_Group.md)

- `Ceiling`: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: `MidpointRounding.ToPositiveInfinity`.
  Mnemonic: `rt[i] := ceiling(value[i])` .
- `Floor`: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: `MidpointRounding.ToNegativeInfinity`.
  Mnemonic: `rt[i] := floor(value[i])` .
- `YRoundToEven`: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: `MidpointRounding.ToEven`.
  Mnemonic: `rt[i] := round_to_even(value[i])` .
- `YRoundToZero`: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: `MidpointRounding.ToZero`.
  Mnemonic: `rt[i] := round_to_zero(value[i])` .

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 
``` 
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9167.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	598.585	437.939
SumBase	325.892	804.388	1.836757
SumBase_Basic	942.492	278.139	0.635109
SumBase_ClearBit	335.725	780.829	1.782961
SumTraits	328.619	797.715	1.821518

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	1324.242	197.958
SumBase	155.653	1684.154	8.507646
SumBase_Basic	1128.858	232.220	1.173081
SumBase_ClearBit	149.707	1751.047	8.845561
SumTraits	152.177	1722.629	8.702006

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	591.563	443.138
SumBase	317.200	826.431	1.864953
SumBase_Basic	911.728	287.524	0.648838
SumBase_ClearBit	333.512	786.011	1.773740
SumTraits	318.058	824.201	1.859921

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	1336.531	196.138
SumBase	154.980	1691.467	8.623878
SumBase_Basic	1128.737	232.245	1.184094
SumBase_ClearBit	154.611	1695.511	8.644498
SumTraits	154.529	1696.407	8.649065

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1305.645	200.777
SumBase	235.814	1111.654	5.536751
SumBase_ClearBit	225.139	1164.366	5.799292
SumTraits	237.887	1101.971	5.488521

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	2085.577	125.694
SumBase	114.770	2284.089	18.171859
SumBase_ClearBit	114.701	2285.460	18.182769
SumTraits	116.597	2248.297	17.887107

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

``` 

#### .NET Core 2.1 
``` 
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	935.628	280.180
SumBase	300.443	872.525	3.114162
SumBase_Basic	530.599	494.053	1.763343
SumBase_ClearBit	297.898	879.979	3.140764
SumTraits	317.407	825.893	2.947725

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639449E+11
# SumBase	-3.639451E+11
SumScalar	934.357	280.561
SumBase	153.961	1702.663	6.068785
SumBase_Basic	572.923	457.556	1.630861
SumBase_ClearBit	152.442	1719.629	6.129254
SumTraits	154.163	1700.433	6.060836

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	932.434	281.139
SumBase	298.862	877.140	3.119949
SumBase_Basic	528.867	495.671	1.763078
SumBase_ClearBit	305.282	858.694	3.054337
SumTraits	305.942	856.841	3.047745

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.639451E+11
# SumBase	-3.639452E+11
SumScalar	931.583	281.396
SumBase	161.625	1621.927	5.763855
SumBase_Basic	571.571	458.638	1.629866
SumBase_ClearBit	154.361	1698.255	6.035103
SumTraits	157.308	1666.442	5.922047

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.56292563727288E+21
# SumBase	-1.56292563727289E+21
SumScalar	1243.903	210.743
SumBase	226.898	1155.338	5.482209
SumBase_ClearBit	228.372	1147.880	5.446822
SumTraits	218.778	1198.220	5.685688

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639451E+11
SumScalar	1420.950	184.485
SumBase	117.947	2222.551	12.047325
SumBase_ClearBit	113.353	2312.626	12.535577
SumTraits	113.375	2312.180	12.533159

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!

``` 

#### .NET Core 3.1 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	932.420	281.144
SumBase	264.115	992.537	3.530356
SumBase_Basic	555.088	472.256	1.679769
SumBase_ClearBit	262.580	998.340	3.550996
SumTraits	79.550	3295.319	11.721121
Sum128Base_Basic	1640.904	159.756	0.568236
Sum128Base	1640.164	159.828	0.568492
Sum128Traits	1643.770	159.477	0.567245
Sum256Base_Basic	555.827	471.629	1.677538
Sum256Base	556.675	470.911	1.674982
Sum256Traits	79.312	3305.209	11.756299

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	931.701	281.361
SumBase	137.306	1909.194	6.785576
SumBase_Basic	341.144	768.427	2.731111
SumBase_ClearBit	133.405	1965.028	6.984019
SumTraits	39.295	6671.193	23.710464
Sum128Base_Basic	901.062	290.928	1.034003
Sum128Base	900.769	291.023	1.034340
Sum128Traits	899.758	291.350	1.035502
Sum256Base_Basic	316.776	827.536	2.941194
Sum256Base	317.206	826.416	2.937213
Sum256Traits	39.497	6637.068	23.589181

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	938.609	279.290
SumBase	272.988	960.275	3.438273
SumBase_Basic	561.973	466.471	1.670204
SumBase_ClearBit	278.959	939.722	3.364683
SumTraits	80.377	3261.445	11.677627
Sum128Base_Basic	1636.325	160.203	0.573608
Sum128Base	1638.278	160.012	0.572924
Sum128Traits	1636.167	160.218	0.573663
Sum256Base_Basic	559.577	468.468	1.677352
Sum256Base	558.079	469.726	1.681857
Sum256Traits	79.560	3294.906	11.797435

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	938.359	279.364
SumBase	140.354	1867.738	6.685670
SumBase_Basic	344.687	760.528	2.722352
SumBase_ClearBit	137.340	1908.725	6.832385
SumTraits	39.838	6580.292	23.554511
Sum128Base_Basic	899.036	291.584	1.043739
Sum128Base	900.490	291.113	1.042053
Sum128Traits	900.728	291.036	1.041778
Sum256Base_Basic	316.812	827.442	2.961874
Sum256Base	316.625	827.932	2.963627
Sum256Traits	39.226	6682.975	23.922070

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1243.331	210.840
SumBase	213.407	1228.374	5.826094
SumBase_ClearBit	214.491	1222.171	5.796672
SumTraits	79.566	3294.685	15.626468
Sum128Base_Basic	2391.087	109.634	0.519986
Sum128Base	2385.445	109.893	0.521216
Sum128Traits	2395.803	109.418	0.518962
Sum256Base_Basic	1820.540	143.992	0.682946
Sum256Base	1451.937	180.548	0.856326
Sum256Traits	79.704	3288.951	15.599268

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	2588.586	101.269
SumBase	118.546	2211.336	21.836218
SumBase_ClearBit	112.349	2333.298	23.040549
SumTraits	44.276	5920.732	58.465285
Sum128Base_Basic	1966.933	133.275	1.316052
Sum128Base	1797.596	145.830	1.440027
Sum128Traits	1789.517	146.489	1.446528
Sum256Base_Basic	1797.620	145.828	1.440007
Sum256Base	1428.581	183.500	1.811998
Sum256Traits	40.037	6547.546	64.654870

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 5.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	937.607	279.588
SumBcl	79.686	3289.712	11.766271
SumBase	80.016	3276.145	11.717745
SumBase_Basic	556.411	471.133	1.685097
SumBase_ClearBit	273.579	958.203	3.427193
SumTraits	81.740	3207.040	11.470578
Sum128Base_Basic	1647.768	159.090	0.569016
Sum128Base	1656.485	158.253	0.566022
Sum128Traits	1640.002	159.844	0.571711
Sum256Base_Basic	556.059	471.432	1.686164
Sum256Base	556.979	470.654	1.683380
Sum256Traits	79.856	3282.712	11.741235

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	931.032	281.563
SumBcl	39.176	6691.519	23.765641
SumBase	39.191	6688.844	23.756139
SumBase_Basic	340.857	769.074	2.731448
SumBase_ClearBit	124.116	2112.089	7.501309
SumTraits	39.145	6696.696	23.784025
Sum128Base_Basic	899.456	291.447	1.035106
Sum128Base	898.733	291.682	1.035939
Sum128Traits	901.702	290.721	1.032528
Sum256Base_Basic	317.035	826.861	2.936683
Sum256Base	316.781	827.523	2.939036
Sum256Traits	39.201	6687.254	23.750492

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	931.553	281.405
SumBcl	79.650	3291.213	11.695628
SumBase	79.749	3287.118	11.681075
SumBase_Basic	556.932	470.693	1.672649
SumBase_ClearBit	263.730	993.987	3.532226
SumTraits	79.606	3293.035	11.702101
Sum128Base_Basic	1638.075	160.032	0.568688
Sum128Base	1636.180	160.217	0.569346
Sum128Traits	1638.411	159.999	0.568571
Sum256Base_Basic	490.793	534.124	1.898058
Sum256Base	489.116	535.955	1.904564
Sum256Traits	79.792	3285.360	11.674828

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	931.705	281.359
SumBcl	39.187	6689.540	23.775776
SumBase	39.207	6686.146	23.763712
SumBase_Basic	330.951	792.094	2.815238
SumBase_ClearBit	128.984	2032.370	7.223393
SumTraits	39.244	6679.933	23.741632
Sum128Base_Basic	896.051	292.555	1.039790
Sum128Base	896.641	292.362	1.039106
Sum128Traits	897.932	291.942	1.037612
Sum256Base_Basic	295.792	886.245	3.149868
Sum256Base	295.807	886.201	3.149711
Sum256Traits	39.145	6696.712	23.801266

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1324.957	197.851
SumBase	92.252	2841.603	14.362336
SumBase_ClearBit	182.853	1433.636	7.246036
SumTraits	79.842	3283.265	16.594631
Sum128Base_Basic	2385.214	109.904	0.555488
Sum128Base	2384.323	109.945	0.555695
Sum128Traits	2386.735	109.834	0.555134
Sum256Base_Basic	1410.805	185.812	0.939149
Sum256Base	1407.213	186.286	0.941547
Sum256Traits	79.595	3293.474	16.646234

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1355.082	193.453
SumBase	45.175	5802.904	29.996527
SumBase_ClearBit	93.973	2789.575	14.419947
SumTraits	39.237	6681.026	34.535740
Sum128Base_Basic	1642.592	159.592	0.824965
Sum128Base	1643.286	159.524	0.824617
Sum128Traits	1652.112	158.672	0.820212
Sum256Base_Basic	1372.255	191.032	0.987485
Sum256Base	1317.208	199.015	1.028753
Sum256Traits	39.187	6689.535	34.579723

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	932.413	281.146
SumBcl	79.401	3301.517	11.743081
SumBase	79.788	3285.490	11.686074
SumBase_Basic	531.719	493.012	1.753583
SumBase_ClearBit	273.001	960.230	3.415416
SumTraits	79.583	3293.961	11.716205
Sum128Base_Basic	1640.008	159.843	0.568542
Sum128Base	1637.028	160.134	0.569577
Sum128Traits	1635.370	160.296	0.570154
Sum256Base_Basic	489.494	535.541	1.904851
Sum256Base	489.170	535.895	1.906111
Sum256Traits	79.574	3294.343	11.717565

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	931.235	281.501
SumBcl	39.135	6698.463	23.795495
SumBase	39.189	6689.306	23.762966
SumBase_Basic	330.906	792.202	2.814202
SumBase_ClearBit	136.109	1925.987	6.841842
SumTraits	39.200	6687.351	23.756022
Sum128Base_Basic	899.789	291.339	1.034949
Sum128Base	896.828	292.301	1.038366
Sum128Traits	897.614	292.045	1.037457
Sum256Base_Basic	295.460	887.241	3.151817
Sum256Base	295.322	887.655	3.153287
Sum256Traits	39.119	6701.204	23.805232

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	934.460	280.530
SumBcl	79.602	3293.192	11.739176
SumBase	79.343	3303.933	11.777465
SumBase_Basic	529.466	495.110	1.764911
SumBase_ClearBit	264.226	992.121	3.536595
SumTraits	79.479	3298.291	11.757353
Sum128Base_Basic	1638.085	160.031	0.570459
Sum128Base	1633.804	160.450	0.571953
Sum128Traits	1634.198	160.411	0.571815
Sum256Base_Basic	488.782	536.321	1.911814
Sum256Base	488.732	536.376	1.912010
Sum256Traits	94.578	2771.722	9.880305

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	932.927	280.991
SumBcl	39.359	6660.253	23.702742
SumBase	39.222	6683.574	23.785741
SumBase_Basic	331.365	791.103	2.815406
SumBase_ClearBit	137.134	1911.588	6.803027
SumTraits	39.169	6692.609	23.817892
Sum128Base_Basic	897.063	292.225	1.039979
Sum128Base	895.849	292.621	1.041389
Sum128Traits	898.180	291.861	1.038686
Sum256Base_Basic	296.590	883.861	3.145516
Sum256Base	296.539	884.013	3.146056
Sum256Traits	39.240	6680.481	23.774733

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	1234.272	212.388
SumBase	91.254	2872.700	13.525747
SumBase_ClearBit	202.265	1296.045	6.102267
SumTraits	79.736	3287.638	15.479428
Sum128Base_Basic	2406.537	108.930	0.512883
Sum128Base	2405.601	108.972	0.513083
Sum128Traits	2405.972	108.956	0.513003
Sum256Base_Basic	1352.327	193.847	0.912702
Sum256Base	1351.340	193.988	0.913369
Sum256Traits	79.866	3282.308	15.454332

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	1346.512	194.684
SumBase	43.129	6078.189	31.220830
SumBase_ClearBit	98.855	2651.799	13.621059
SumTraits	39.159	6694.338	34.385703
Sum128Base_Basic	1679.950	156.043	0.801519
Sum128Base	1659.055	158.008	0.811614
Sum128Traits	1656.183	158.282	0.813021
Sum256Base_Basic	1331.714	196.847	1.011112
Sum256Base	1320.537	198.513	1.019670
Sum256Traits	39.296	6670.954	34.265588

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	931.690	281.364
SumBcl	79.732	3287.800	11.685218
SumBase	79.264	3307.220	11.754239
SumBase_Basic	527.981	496.503	1.764627
SumBase_ClearBit	257.656	1017.418	3.616021
SumTraits	79.544	3295.596	11.712925
Sum128Bcl	156.794	1671.901	5.942128
Sum128Base_Basic	860.215	304.743	1.083090
Sum128Base	157.439	1665.053	5.917788
Sum128Traits	157.517	1664.226	5.914849
Sum256Bcl	79.063	3315.633	11.784138
Sum256Base_Basic	488.596	536.525	1.906872
Sum256Base	79.615	3292.627	11.702371
Sum256Traits	79.204	3309.726	11.763144

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.6394507E+11
# SumBase	-3.6394507E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639422E+11!=-3.6394507E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639422E+11!=-3.6394507E+11
SumScalar	931.482	281.427
SumBcl	39.241	6680.405	23.737625
SumBase	39.130	6699.316	23.804822
SumBase_Basic	331.271	791.327	2.811840
SumBase_ClearBit	123.256	2126.830	7.557311
SumTraits	39.206	6686.259	23.758427
Sum128Bcl	78.062	3358.148	11.932578
Sum128Base_Basic	468.183	559.918	1.989567
Sum128Base	78.113	3355.967	11.924830
Sum128Traits	78.041	3359.063	11.935828
Sum256Bcl	39.249	6679.058	23.732838
Sum256Base_Basic	282.468	928.048	3.297654
Sum256Base	39.141	6697.418	23.798079
Sum256Traits	39.243	6680.005	23.736202

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.562925637272894E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728656E+21!=-1.562925637272894E+21
SumScalar	934.149	280.623
SumBcl	79.939	3279.289	11.685734
SumBase	79.434	3300.129	11.759997
SumBase_Basic	526.941	497.483	1.772779
SumBase_ClearBit	255.162	1027.363	3.661005
SumTraits	79.414	3300.964	11.762973
Sum128Bcl	157.245	1667.106	5.940727
Sum128Base_Basic	861.437	304.310	1.084408
Sum128Base	157.352	1665.976	5.936700
Sum128Traits	157.802	1661.219	5.919749
Sum256Bcl	79.630	3292.033	11.731149
Sum256Base_Basic	490.543	534.396	1.904318
Sum256Base	79.658	3290.876	11.727025
Sum256Traits	79.638	3291.712	11.730003

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.639452E+11
# SumBase	-3.639452E+11
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.6394235E+11!=-3.639452E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.6394235E+11!=-3.639452E+11
SumScalar	934.380	280.554
SumBcl	39.411	6651.523	23.708530
SumBase	39.238	6680.844	23.813042
SumBase_Basic	331.091	791.759	2.822126
SumBase_ClearBit	126.632	2070.119	7.378684
SumTraits	39.283	6673.188	23.785754
Sum128Bcl	78.117	3355.766	11.961213
Sum128Base_Basic	467.380	560.880	1.999186
Sum128Base	78.217	3351.509	11.946039
Sum128Traits	78.122	3355.589	11.960581
Sum256Bcl	39.240	6680.575	23.812081
Sum256Base_Basic	283.405	924.980	3.296977
Sum256Base	39.418	6650.341	23.704318
Sum256Traits	39.306	6669.260	23.771753

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.562925637272894E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -1.5629256372728653E+21!=-1.562925637272894E+21
SumScalar	934.981	280.374
SumBase	89.403	2932.162	10.458049
SumBase_ClearBit	188.171	1393.118	4.968788
SumTraits	79.501	3297.377	11.760649
Sum128Base_Basic	861.734	304.205	1.084999
Sum128Base	160.587	1632.410	5.822264
Sum128Traits	163.342	1604.875	5.724057
Sum256Base_Basic	490.772	534.146	1.905123
Sum256Base	88.028	2977.960	10.621393
Sum256Traits	79.675	3290.178	11.734974

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394513E+11
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Base	Check `Sum128Base` mismatch. -3.639423E+11!=-3.6394513E+11
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.639423E+11!=-3.6394513E+11
SumScalar	933.820	280.722
SumBase	45.897	5711.620	20.346153
SumBase_ClearBit	95.136	2755.455	9.815588
SumTraits	39.338	6663.835	23.738171
Sum128Base_Basic	468.638	559.374	1.992624
Sum128Base	84.364	3107.297	11.068934
Sum128Traits	84.420	3105.241	11.061609
Sum256Base_Basic	283.415	924.946	3.294879
Sum256Base	45.179	5802.350	20.669357
Sum256Traits	39.188	6689.334	23.829006

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	316.561	828.100
SumBase	1422.793	184.246	0.222492
SumBase_Basic	547.836	478.508	0.577838
SumBase_ClearBit	1422.043	184.343	0.222610
SumTraits	1424.818	183.984	0.222176
Sum128Base_Basic	1157.608	226.453	0.273461
Sum128Base	1145.448	228.857	0.276364
Sum128Traits	1146.429	228.661	0.276128
Sum256Base_Basic	1669.908	156.981	0.189568
Sum256Base	1676.572	156.357	0.188814
Sum256Traits	1673.944	156.603	0.189111

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	316.813	827.440
SumBase	713.579	367.365	0.443978
SumBase_Basic	806.899	324.878	0.392631
SumBase_ClearBit	715.031	366.619	0.443077
SumTraits	709.087	369.692	0.446791
Sum128Base_Basic	1460.205	179.526	0.216965
Sum128Base	1459.386	179.626	0.217087
Sum128Traits	1459.274	179.640	0.217103
Sum256Base_Basic	1239.295	211.527	0.255640
Sum256Base	1250.114	209.696	0.253428
Sum256Traits	1246.543	210.297	0.254154

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	290.514	902.345
SumBase	1423.908	184.102	0.204026
SumBase_Basic	549.571	476.997	0.528619
SumBase_ClearBit	1422.037	184.344	0.204294
SumTraits	1422.477	184.287	0.204231
Sum128Base_Basic	1145.902	228.767	0.253524
Sum128Base	1151.179	227.718	0.252362
Sum128Traits	1146.341	228.679	0.253427
Sum256Base_Basic	1673.662	156.629	0.173580
Sum256Base	1674.099	156.588	0.173535
Sum256Traits	1675.334	156.473	0.173407

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	317.088	826.722
SumBase	701.031	373.940	0.452317
SumBase_Basic	796.309	329.199	0.398198
SumBase_ClearBit	701.123	373.892	0.452258
SumTraits	701.074	373.917	0.452289
Sum128Base_Basic	1460.609	179.476	0.217093
Sum128Base	1461.096	179.416	0.217021
Sum128Traits	1461.232	179.399	0.217001
Sum256Base_Basic	1222.367	214.456	0.259405
Sum256Base	1248.647	209.942	0.253945
Sum256Traits	1249.350	209.824	0.253803

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1618.140	162.003
SumBase	1084.879	241.634	1.491539
SumBase_ClearBit	1086.060	241.372	1.489918
SumTraits	1091.560	240.155	1.482410
Sum128Base_Basic	2205.636	118.852	0.733639
Sum128Base	2199.725	119.171	0.735610
Sum128Traits	2221.165	118.021	0.728510
Sum256Base_Basic	3157.064	83.034	0.512546
Sum256Base	3156.376	83.052	0.512658
Sum256Traits	3150.329	83.212	0.513642

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.639423E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.639423E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.639423E+11
SumScalar	1751.899	149.634
SumBase	541.578	484.037	3.234804
SumBase_ClearBit	542.594	483.131	3.228745
SumTraits	540.961	484.590	3.238496
Sum128Base_Basic	2391.388	109.620	0.732587
Sum128Base	2319.813	113.002	0.755190
Sum128Traits	2363.449	110.916	0.741247
Sum256Base_Basic	2725.599	96.178	0.642758
Sum256Base	2686.136	97.591	0.652200
Sum256Traits	2712.054	96.659	0.645968

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728653E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	315.641	830.514
SumBcl	125.036	2096.545	2.524394
SumBase	124.966	2097.721	2.525810
SumBase_Basic	552.721	474.279	0.571067
SumBase_ClearBit	1042.859	251.370	0.302668
SumTraits	133.035	1970.491	2.372616
Sum128Base_Basic	557.558	470.165	0.566113
Sum128Base	557.502	470.212	0.566170
Sum128Traits	125.075	2095.889	2.523604
Sum256Base_Basic	1075.355	243.774	0.293522
Sum256Base	1078.925	242.968	0.292551
Sum256Traits	1075.120	243.828	0.293587

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	315.931	829.751
SumBcl	62.533	4192.084	5.052220
SumBase	62.475	4195.967	5.056900
SumBase_Basic	797.628	328.655	0.396088
SumBase_ClearBit	513.760	510.246	0.614939
SumTraits	62.471	4196.249	5.057240
Sum128Base_Basic	833.291	314.589	0.379137
Sum128Base	831.904	315.113	0.379769
Sum128Traits	66.555	3938.743	4.746899
Sum256Base_Basic	882.281	297.121	0.358084
Sum256Base	914.734	286.579	0.345380
Sum256Traits	913.458	286.980	0.345863

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	315.838	829.996
SumBcl	133.186	1968.259	2.371407
SumBase	133.198	1968.078	2.371189
SumBase_Basic	551.088	475.684	0.573116
SumBase_ClearBit	1043.481	251.221	0.302677
SumTraits	133.300	1966.567	2.369369
Sum128Base_Basic	558.376	469.476	0.565636
Sum128Base	556.221	471.295	0.567827
Sum128Traits	124.895	2098.923	2.528834
Sum256Base_Basic	1073.186	244.267	0.294299
Sum256Base	1077.728	243.238	0.293059
Sum256Traits	1076.592	243.494	0.293368

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	290.275	903.088
SumBcl	66.630	3934.303	4.356499
SumBase	66.672	3931.837	4.353768
SumBase_Basic	800.080	327.647	0.362808
SumBase_ClearBit	513.315	510.688	0.565491
SumTraits	62.480	4195.644	4.645885
Sum128Base_Basic	831.870	315.126	0.348943
Sum128Base	831.621	315.220	0.349047
Sum128Traits	66.668	3932.098	4.354058
Sum256Base_Basic	883.112	296.841	0.328696
Sum256Base	913.983	286.815	0.317594
Sum256Traits	914.025	286.802	0.317579

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	2217.103	118.237
SumBase	253.039	1035.983	8.761903
SumBase_ClearBit	781.940	335.248	2.835386
SumTraits	124.977	2097.545	17.740143
Sum128Base_Basic	2479.286	105.734	0.894251
Sum128Base	2393.616	109.518	0.926257
Sum128Traits	133.188	1968.228	16.646435
Sum256Base_Basic	2905.143	90.234	0.763165
Sum256Base	2917.296	89.859	0.759985
Sum256Traits	2891.056	90.674	0.766883

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	2199.767	119.169
SumBase	119.252	2198.234	18.446366
SumBase_ClearBit	388.044	675.552	5.668862
SumTraits	66.556	3938.714	33.051506
Sum128Base_Basic	2369.205	110.646	0.928483
Sum128Base	2359.972	111.079	0.932116
Sum128Traits	62.454	4197.405	35.222294
Sum256Base_Basic	2774.264	94.491	0.792919
Sum256Base	2738.909	95.711	0.803155
Sum256Traits	2737.941	95.745	0.803439

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728653E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	290.183	903.374
SumBcl	124.982	2097.457	2.321804
SumBase	124.929	2098.344	2.322786
SumBase_Basic	553.647	473.486	0.524130
SumBase_ClearBit	978.600	267.877	0.296529
SumTraits	133.079	1969.844	2.180542
Sum128Base_Basic	557.387	470.308	0.520613
Sum128Base	557.668	470.072	0.520351
Sum128Traits	133.157	1968.689	2.179262
Sum256Base_Basic	1080.645	242.581	0.268528
Sum256Base	1069.795	245.041	0.271251
Sum256Traits	1076.156	243.593	0.269648

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	316.670	827.815
SumBcl	66.761	3926.627	4.743364
SumBase	66.781	3925.402	4.741884
SumBase_Basic	797.685	328.631	0.396986
SumBase_ClearBit	490.206	534.763	0.645994
SumTraits	62.723	4179.371	5.048678
Sum128Base_Basic	832.509	314.884	0.380380
Sum128Base	832.060	315.054	0.380585
Sum128Traits	62.743	4178.057	5.047090
Sum256Base_Basic	883.157	296.826	0.358566
Sum256Base	911.514	287.592	0.347411
Sum256Traits	913.677	286.911	0.346588

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	316.129	829.232
SumBcl	133.045	1970.341	2.376104
SumBase	133.170	1968.485	2.373866
SumBase_Basic	550.262	476.398	0.574505
SumBase_ClearBit	979.737	267.566	0.322667
SumTraits	124.945	2098.074	2.530142
Sum128Base_Basic	558.156	469.661	0.566381
Sum128Base	559.313	468.689	0.565209
Sum128Traits	125.057	2096.197	2.527878
Sum256Base_Basic	1073.548	244.185	0.294471
Sum256Base	1072.905	244.331	0.294648
Sum256Traits	1070.235	244.941	0.295382

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	316.070	829.386
SumBcl	62.698	4181.067	5.041160
SumBase	62.741	4178.182	5.037681
SumBase_Basic	799.327	327.956	0.395420
SumBase_ClearBit	490.306	534.654	0.644638
SumTraits	66.790	3924.917	4.732318
Sum128Base_Basic	833.276	314.595	0.379310
Sum128Base	832.005	315.075	0.379890
Sum128Traits	66.680	3931.356	4.740081
Sum256Base_Basic	881.624	297.342	0.358509
Sum256Base	914.750	286.575	0.345526
Sum256Traits	913.197	287.062	0.346114

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	1941.239	135.040
SumBase	226.045	1159.698	8.587838
SumBase_ClearBit	785.181	333.865	2.472347
SumTraits	125.147	2094.686	15.511655
Sum128Base_Basic	1996.254	131.318	0.972441
Sum128Base	2019.425	129.811	0.961283
Sum128Traits	125.065	2096.062	15.521837
Sum256Base_Basic	2474.069	105.957	0.784634
Sum256Base	2471.459	106.069	0.785463
Sum256Traits	2431.145	107.827	0.798488

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	1883.674	139.166
SumBase	138.608	1891.261	13.589931
SumBase_ClearBit	373.919	701.072	5.037653
SumTraits	66.872	3920.092	28.168398
Sum128Base_Basic	2121.112	123.588	0.888060
Sum128Base	2097.573	124.975	0.898025
Sum128Traits	66.783	3925.336	28.206078
Sum256Base_Basic	2494.191	105.102	0.755224
Sum256Base	2457.728	106.661	0.766429
Sum256Traits	2449.034	107.040	0.769150

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
Environment.OSVersion:	Unix 5.19.0.1025
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.19.0-1025-aws #26~22.04.1-Ubuntu SMP Mon Apr 24 01:58:03 UTC 2023
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


[CeilingBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728653E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.607	1244.705
SumBcl	106.379	2464.238	1.979777
SumBase	106.327	2465.448	1.980749
SumBase_Basic	548.121	478.259	0.384235
SumBase_ClearBit	906.976	289.031	0.232208
SumTraits	106.226	2467.795	1.982635
Sum128Bcl	106.283	2466.476	1.981575
Sum128Base_Basic	558.668	469.231	0.376982
Sum128Base	106.414	2463.438	1.979134
Sum128Traits	106.193	2468.561	1.983250
Sum256Bcl	969.269	270.455	0.217285
Sum256Base_Basic	1157.408	226.492	0.181965
Sum256Base	1149.978	227.956	0.183140
Sum256Traits	1149.311	228.088	0.183247

[CeilingBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394494E+11
# SumBcl	-3.639422E+11
# SumBase	-3.639422E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394507E+11!=-3.639422E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394507E+11!=-3.639422E+11
SumScalar	211.287	1240.703
SumBcl	55.792	4698.575	3.787028
SumBase	55.860	4692.873	3.782432
SumBase_Basic	801.776	326.954	0.263523
SumBase_ClearBit	462.870	566.344	0.456471
SumTraits	55.959	4684.572	3.775741
Sum128Bcl	56.036	4678.098	3.770523
Sum128Base_Basic	805.699	325.362	0.262240
Sum128Base	55.937	4686.424	3.777234
Sum128Traits	55.906	4689.050	3.779350
Sum256Bcl	900.156	291.221	0.234722
Sum256Base_Basic	1012.849	258.819	0.208606
Sum256Base	938.329	279.373	0.225173
Sum256Traits	938.296	279.383	0.225181

[FloorBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBcl	-1.5629256372728656E+21
# SumBase	-1.5629256372728656E+21
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728656E+21
SumScalar	210.623	1244.614
SumBcl	106.200	2468.407	1.983271
SumBase	106.272	2466.719	1.981915
SumBase_Basic	547.750	478.584	0.384524
SumBase_ClearBit	915.999	286.184	0.229938
SumTraits	106.231	2467.687	1.982693
Sum128Bcl	106.709	2456.614	1.973796
Sum128Base_Basic	558.494	469.377	0.377126
Sum128Base	106.205	2468.281	1.983170
Sum128Traits	106.255	2467.132	1.982247
Sum256Bcl	968.319	270.721	0.217514
Sum256Base_Basic	1153.031	227.352	0.182669
Sum256Base	1148.447	228.260	0.183398
Sum256Traits	1149.211	228.108	0.183276

[FloorBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.6394507E+11
# SumBcl	-3.6394235E+11
# SumBase	-3.6394235E+11
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.639452E+11!=-3.6394235E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.639452E+11!=-3.6394235E+11
SumScalar	211.387	1240.114
SumBcl	55.922	4687.638	3.780005
SumBase	56.011	4680.215	3.774019
SumBase_Basic	799.267	327.981	0.264476
SumBase_ClearBit	466.367	562.098	0.453263
SumTraits	55.940	4686.158	3.778812
Sum128Bcl	55.808	4697.283	3.787782
Sum128Base_Basic	803.148	326.396	0.263198
Sum128Base	55.852	4693.506	3.784737
Sum128Traits	55.914	4688.304	3.780542
Sum256Bcl	899.398	291.466	0.235032
Sum256Base_Basic	1008.833	259.849	0.209536
Sum256Base	937.182	279.715	0.225556
Sum256Traits	936.564	279.900	0.225705

[YRoundToZeroBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1.5629256372728819E+21
# SumBase	-1.5629256372728653E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -1.562925637272894E+21!=-1.5629256372728653E+21
SumScalar	210.637	1244.527
SumBase	217.453	1205.522	0.968658
SumBase_ClearBit	691.076	379.327	0.304796
SumTraits	106.512	2461.167	1.977592
Sum128Base_Basic	557.910	469.868	0.377547
Sum128Base	162.800	1610.220	1.293841
Sum128Traits	106.220	2467.942	1.983035
Sum256Base_Basic	1149.100	228.130	0.183306
Sum256Base	3275.605	80.029	0.064305
Sum256Traits	3276.398	80.010	0.064289

[YRoundToZeroBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.63945E+11
# SumBase	-3.6394228E+11
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Base	Check `Sum256Base` mismatch. -3.6394513E+11!=-3.6394228E+11
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.6394513E+11!=-3.6394228E+11
SumScalar	211.204	1241.188
SumBase	112.744	2325.131	1.873311
SumBase_ClearBit	349.895	749.207	0.603621
SumTraits	55.888	4690.482	3.779027
Sum128Base_Basic	803.389	326.298	0.262891
Sum128Base	94.017	2788.266	2.246450
Sum128Traits	55.819	4696.331	3.783739
Sum256Base_Basic	1009.167	259.763	0.209286
Sum256Base	2250.660	116.474	0.093841
Sum256Traits	2250.566	116.479	0.093845

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

