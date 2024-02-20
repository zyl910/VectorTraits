# Benchmark - YShuffleG4X2
([← Back](README.md))

See [Group](YShuffleG4X2_Group.md)

## X86

### Intel Core i5-8250U
`Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	464.726	564.083
SumX1Traits	466.379	562.084	0.996457
SumTraits	459.749	570.190	1.010827
SumTraits_Tuple	470.812	556.791	0.987074
Sum_ConstTraits	433.364	604.905	1.072369
Sum_ConstTraits_Tuple	464.600	564.236	1.000272

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	523.880	500.390
SumX1Traits	523.776	500.488	1.000197
SumTraits	524.607	499.696	0.998614
SumTraits_Tuple	587.187	446.441	0.892186
Sum_ConstTraits	521.242	502.921	1.005060
Sum_ConstTraits_Tuple	580.738	451.398	0.902094

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	472.441	554.871
SumX1Traits	471.076	556.479	1.002897
SumTraits	471.641	555.812	1.001695
SumTraits_Tuple	588.127	445.727	0.803297
Sum_ConstTraits	434.802	602.904	1.086564
Sum_ConstTraits_Tuple	557.845	469.922	0.846903

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	394.289	664.852
SumX1Traits	395.356	663.058	0.997301
SumTraits	395.274	663.196	0.997509
SumTraits_Tuple	409.181	640.656	0.963606
Sum_ConstTraits	392.993	667.045	1.003299
Sum_ConstTraits_Tuple	407.531	643.250	0.967508

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	440.233	595.466
SumX1Traits	436.490	600.573	1.008577
SumTraits	439.450	596.527	1.001781
SumTraits_Tuple	472.015	555.372	0.932668
Sum_ConstTraits	436.699	600.286	1.008094
Sum_ConstTraits_Tuple	467.828	560.342	0.941014

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	524.930	499.388
SumX1Traits	520.608	503.535	1.008302
SumTraits	521.611	502.566	1.006364
SumTraits_Tuple	580.831	451.326	0.903758
Sum_ConstTraits	514.852	509.164	1.019575
Sum_ConstTraits_Tuple	575.752	455.307	0.911729

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	468.251	559.836
SumX1Traits	464.339	564.553	1.008426
SumTraits	468.111	560.004	1.000300
SumTraits_Tuple	589.953	444.347	0.793710
Sum_ConstTraits	433.590	604.589	1.079940
Sum_ConstTraits_Tuple	568.379	461.213	0.823836

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	398.163	658.383
SumX1Traits	397.709	659.135	1.001142
SumTraits	397.740	659.083	1.001064
SumTraits_Tuple	412.997	634.735	0.964082
Sum_ConstTraits	395.341	663.083	1.007138
Sum_ConstTraits_Tuple	409.433	640.262	0.972476

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	440.247	595.448
SumX1Traits	20.608	12720.684	21.363220
SumTraits	15.265	17173.037	28.840536
SumTraits_Tuple	15.120	17337.930	29.117459
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	15.246	17194.137	28.875972
Sum_ConstTraits	12.446	21062.692	35.372855
Sum_ConstTraits_Tuple	12.470	21022.447	35.305268
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	11.964	21911.390	36.798165

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	529.163	495.394
SumX1Traits	40.695	6441.608	13.002997
SumTraits	27.955	9377.304	18.928978
SumTraits_Tuple	28.959	9052.144	18.272613
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	40.668	6446.014	13.011891
Sum256Traits	29.041	9026.576	18.221001
Sum_ConstTraits	19.750	13273.002	26.792815
Sum_ConstTraits_Tuple	20.358	12876.465	25.992368
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	23.167	11315.261	22.840930

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	481.528	544.400
SumX1Traits	83.972	3121.799	5.734385
SumTraits	62.147	4218.118	7.748198
SumTraits_Tuple	62.711	4180.170	7.678491
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	64.680	4052.918	7.444745
Sum_ConstTraits	47.791	5485.269	10.075808
Sum_ConstTraits_Tuple	47.758	5488.996	10.082655
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	50.328	5208.663	9.567714

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	407.339	643.552
SumX1Traits	9.784	26793.985	41.634546
SumTraits	7.013	37380.388	58.084509
SumTraits_Tuple	6.974	37589.282	58.409104
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.905	37964.204	58.991688
Sum_ConstTraits	6.833	38366.103	59.616189
Sum_ConstTraits_Tuple	7.218	36315.579	56.429928
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	7.318	35820.451	55.660560

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	443.767	590.724
SumX1Traits	20.634	12704.739	21.507053
SumTraits	15.125	17332.131	29.340474
SumTraits_Tuple	15.412	17008.546	28.792697
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	15.626	16776.250	28.399459
Sum_ConstTraits	12.940	20258.276	34.293962
Sum_ConstTraits_Tuple	12.601	20804.018	35.217813
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	13.213	19839.770	33.585499

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	528.405	496.104
SumX1Traits	40.316	6502.217	13.106563
SumTraits	28.500	9197.947	18.540365
SumTraits_Tuple	28.749	9118.370	18.379962
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	41.546	6309.680	12.718466
Sum256Traits	29.631	8846.974	17.832906
Sum_ConstTraits	21.002	12482.100	25.160254
Sum_ConstTraits_Tuple	20.681	12675.650	25.550395
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	20.960	12506.812	25.210068

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	485.565	539.874
SumX1Traits	82.648	3171.814	5.875104
SumTraits	58.661	4468.820	8.277530
SumTraits_Tuple	59.251	4424.294	8.195055
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	87.202	3006.158	5.568262
Sum_ConstTraits	43.396	6040.733	11.189162
Sum_ConstTraits_Tuple	45.246	5793.733	10.731646
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	43.307	6053.216	11.212284

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	394.237	664.941
SumX1Traits	9.657	27144.762	40.822831
SumTraits	6.483	40436.361	60.811980
SumTraits_Tuple	6.492	40382.168	60.730479
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.398	40971.100	61.616170
Sum_ConstTraits	6.681	39237.910	59.009638
Sum_ConstTraits_Tuple	7.337	35728.004	53.731113
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	6.907	37953.955	57.078706

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	511.138	512.864
SumX1Traits	15.014	17460.290	34.044685
SumTraits	12.672	20686.613	40.335483
SumTraits_Tuple	12.961	20225.145	39.435697
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	13.171	19903.875	38.809274
Sum_ConstTraits	13.046	20093.341	39.178700
Sum_ConstTraits_Tuple	13.192	19871.176	38.745516
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	13.088	20030.044	39.055283

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	655.787	399.739
SumX1Traits	29.471	8895.077	22.252186
SumTraits	22.819	11487.858	28.738364
SumTraits_Tuple	22.758	11518.685	28.815482
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	31.877	8223.636	20.572490
Sum256Traits	24.347	10767.055	26.935184
Sum_ConstTraits	23.834	10998.920	27.515224
Sum_ConstTraits_Tuple	23.588	11113.422	27.801666
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	21.579	12147.891	30.389522

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	788.819	332.325
SumX1Traits	62.824	4172.680	12.556028
SumTraits	52.035	5037.821	15.159329
SumTraits_Tuple	52.629	4980.984	14.988299
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	57.155	4586.584	13.801510
Sum_ConstTraits	43.848	5978.404	17.989640
Sum_ConstTraits_Tuple	44.170	5934.849	17.858578
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	45.523	5758.476	17.327856

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	391.782	669.107
SumX1Traits	6.516	40233.578	60.130298
SumTraits	4.912	53368.288	79.760519
SumTraits_Tuple	4.756	55119.344	82.377526
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4.742	55280.476	82.618342
Sum_ConstTraits	4.724	55488.741	82.929600
Sum_ConstTraits_Tuple	4.815	54438.179	81.359504
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	4.824	54342.496	81.216502

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	366.635	715.001
SumX1Traits	15.482	16932.627	23.681972
SumTraits	12.705	20633.084	28.857432
SumTraits_Tuple	12.313	21290.774	29.777277
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	12.261	21380.298	29.902485
Sum_ConstTraits	12.516	20945.502	29.294379
Sum_ConstTraits_Tuple	12.594	20815.359	29.112362
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	12.304	21305.425	29.797767

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	440.718	594.812
SumX1Traits	25.045	10467.039	17.597237
SumTraits	24.311	10783.041	18.128502
SumTraits_Tuple	24.497	10700.909	17.990421
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	25.101	10443.662	17.557935
Sum256Traits	25.658	10216.877	17.176663
Sum_ConstTraits	37.606	6970.710	11.719192
Sum_ConstTraits_Tuple	22.045	11891.303	19.991716
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	23.804	11012.402	18.514103

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	571.276	458.875
SumX1Traits	67.597	3878.064	8.451251
SumTraits	47.959	5465.986	11.911722
SumTraits_Tuple	51.555	5084.728	11.080867
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	58.330	4494.170	9.793897
Sum_ConstTraits	45.486	5763.214	12.559454
Sum_ConstTraits_Tuple	44.504	5890.342	12.836498
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	43.473	6030.018	13.140886

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	321.408	815.611
SumX1Traits	5.302	49442.499	60.620193
SumTraits	4.849	54060.355	66.282030
SumTraits_Tuple	4.815	54438.547	66.745721
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4.804	54562.553	66.897762
Sum_ConstTraits	4.831	54258.495	66.524964
Sum_ConstTraits_Tuple	4.893	53572.552	65.683946
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	4.905	53443.966	65.526290

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	681.636	384.581
SumX1Traits	685.327	382.509	0.994614
SumTraits	679.396	385.849	1.003296
SumTraits_Tuple	742.581	353.018	0.917928
Sum128Traits	1081.728	242.338	0.630136
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	701.803	373.529	0.971264
Sum_ConstTraits_Tuple	764.091	343.080	0.892087
Sum_Const128Traits	1101.146	238.065	0.619024
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	704.121	372.300
SumX1Traits	700.937	373.991	1.004542
SumTraits	706.476	371.059	0.996666
SumTraits_Tuple	925.998	283.093	0.760391
Sum128Traits	1467.969	178.576	0.479656
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	681.324	384.756	1.033459
Sum_ConstTraits_Tuple	908.635	288.503	0.774922
Sum_Const128Traits	1466.974	178.697	0.479982
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	833.284	314.591
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	835.052	313.926	0.997883
SumTraits_Tuple	1028.268	254.937	0.810376
Sum128Traits	1279.207	204.927	0.651407
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	851.145	307.990	0.979015
Sum_ConstTraits_Tuple	1050.006	249.660	0.793599
Sum_Const128Traits	1279.458	204.887	0.651279
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	569.898	459.984
SumX1Traits	567.554	461.883	1.004130
SumTraits	570.469	459.523	0.998999
SumTraits_Tuple	605.697	432.798	0.940897
Sum128Traits	848.596	308.915	0.671578
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	592.055	442.770	0.962577
Sum_ConstTraits_Tuple	626.541	418.399	0.909594
Sum_Const128Traits	865.534	302.870	0.658436
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	676.166	387.692
SumX1Traits	39.934	6564.384	16.931967
SumTraits	33.744	7768.697	20.038335
SumTraits_Tuple	112.841	2323.129	5.992206
Sum128_AdvSimd	59.358	4416.346	11.391386
Sum128Traits	33.832	7748.439	19.986082
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	33.759	7765.248	20.029438
Sum_ConstTraits_Tuple	106.182	2468.814	6.367982
Sum_Const128Traits	33.837	7747.366	19.983312
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	689.231	380.343
SumX1Traits	80.537	3254.959	8.557964
SumTraits	68.648	3818.691	10.040131
SumTraits_Tuple	230.276	1138.388	2.993059
Sum128_AdvSimd	118.133	2219.063	5.834377
Sum128Traits	68.206	3843.423	10.105156
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	68.399	3832.587	10.076668
Sum_ConstTraits_Tuple	230.759	1136.007	2.986799
Sum_Const128Traits	68.261	3840.331	10.097029
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	770.887	340.055
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	211.271	1240.795	3.648805
SumTraits_Tuple	625.982	418.773	1.231485
Sum128_AdvSimd	472.663	554.611	1.630946
Sum128Traits	211.741	1238.041	3.640708
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	213.964	1225.177	3.602880
Sum_ConstTraits_Tuple	612.650	427.885	1.258283
Sum_Const128Traits	213.807	1226.078	3.605529
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	565.734	463.370
SumX1Traits	18.558	14125.982	30.485328
SumTraits	16.800	15604.242	33.675565
SumTraits_Tuple	54.485	4811.334	10.383356
Sum128_AdvSimd	28.886	9075.087	19.584974
Sum128Traits	16.825	15580.659	33.624671
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	16.791	15612.462	33.693305
Sum_ConstTraits_Tuple	52.846	4960.488	10.705245
Sum_Const128Traits	16.808	15596.408	33.658658
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	674.925	388.405
SumX1Traits	32.375	8097.043	20.846932
SumTraits	30.277	8658.265	22.291874
SumTraits_Tuple	91.071	2878.457	7.410976
Sum128_AdvSimd	49.024	5347.275	13.767283
Sum128Traits	29.987	8741.823	22.507006
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	31.027	8448.968	21.753011
Sum_ConstTraits_Tuple	91.074	2878.354	7.410712
Sum_Const128Traits	30.828	8503.488	21.893378
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	693.196	378.167
SumX1Traits	68.099	3849.454	10.179241
SumTraits	65.705	3989.740	10.550206
SumTraits_Tuple	182.345	1437.628	3.801569
Sum128_AdvSimd	97.913	2677.315	7.079714
Sum128Traits	63.811	4108.155	10.863334
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	65.013	4032.178	10.662425
Sum_ConstTraits_Tuple	182.037	1440.057	3.807992
Sum_Const128Traits	63.741	4112.626	10.875155
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	774.945	338.274
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	170.796	1534.835	4.537250
SumTraits_Tuple	406.671	644.609	1.905582
Sum128_AdvSimd	411.915	636.404	1.881325
Sum128Traits	174.605	1501.356	4.438282
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	175.188	1496.361	4.423513
Sum_ConstTraits_Tuple	411.066	637.717	1.885208
Sum_Const128Traits	175.053	1497.514	4.426924
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	564.929	464.030
SumX1Traits	16.714	15684.232	33.800050
SumTraits	14.911	17580.562	37.886706
SumTraits_Tuple	46.611	5624.091	12.120105
Sum128_AdvSimd	24.131	10863.503	23.411217
Sum128Traits	15.165	17285.738	37.251350
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	14.725	17802.435	38.364849
Sum_ConstTraits_Tuple	45.595	5749.413	12.390180
Sum_Const128Traits	15.103	17356.546	37.403945
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-21037
SumBase	509.115	514.902
SumX1Traits	29.988	8741.548	16.977123
SumTraits	25.125	10433.609	20.263307
SumTraits_Tuple	87.387	2999.818	5.826002
Sum128_AdvSimd	45.617	5746.664	11.160703
Sum128Traits	25.124	10434.019	20.264103
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	26.586	9860.214	19.149706
Sum_ConstTraits_Tuple	87.365	3000.560	5.827444
Sum_Const128Traits	26.593	9857.672	19.144769
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	662.816	395.500
SumX1Traits	61.282	4277.648	10.815785
SumTraits	51.190	5120.962	12.948057
SumTraits_Tuple	182.590	1435.697	3.630078
Sum128_AdvSimd	92.160	2844.455	7.192040
Sum128Traits	51.311	5108.926	12.917623
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	53.910	4862.617	12.294845
Sum_ConstTraits_Tuple	178.938	1464.997	3.704160
Sum_Const128Traits	53.979	4856.366	12.279040
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	563.076	465.557
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	160.113	1637.245	3.516743
SumTraits_Tuple	372.433	703.869	1.511886
Sum128_AdvSimd	361.501	725.155	1.557607
Sum128Traits	160.204	1636.318	3.514753
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	160.277	1635.564	3.513134
Sum_ConstTraits_Tuple	366.665	714.942	1.535671
Sum_Const128Traits	160.169	1636.674	3.515516
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	409.970	639.422
SumX1Traits	14.861	17640.121	27.587600
SumTraits	12.464	21032.648	32.893214
SumTraits_Tuple	43.891	5972.646	9.340694
Sum128_AdvSimd	22.920	11437.349	17.887009
Sum128Traits	12.463	21033.148	32.893996
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	13.233	19809.813	30.980808
Sum_ConstTraits_Tuple	42.895	6111.353	9.557619
Sum_Const128Traits	13.236	19806.095	30.974992
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

