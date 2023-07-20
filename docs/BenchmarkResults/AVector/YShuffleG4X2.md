# Benchmark - YShuffleG4X2
([← Back](README.md))
See [Group](YShuffleG4X2_Group.md)

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


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-30719
SumBase	437.912	598.622
SumX1Traits	436.094	601.118	1.004170
SumTraits	438.524	597.787	0.998604
SumTraits_Tuple	465.560	563.073	0.940615
Sum_ConstTraits	433.781	604.323	1.009523
Sum_ConstTraits_Tuple	462.688	566.567	0.946452

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	519.302	504.801
SumX1Traits	519.138	504.960	1.000315
SumTraits	519.337	504.767	0.999933
SumTraits_Tuple	580.862	451.302	0.894019
Sum_ConstTraits	517.340	506.715	1.003792
Sum_ConstTraits_Tuple	575.843	455.235	0.901811

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	468.191	559.908
SumX1Traits	463.759	565.259	1.009558
SumTraits	481.136	544.844	0.973097
SumTraits_Tuple	590.820	443.695	0.792443
Sum_ConstTraits	434.915	602.748	1.076513
Sum_ConstTraits_Tuple	557.202	470.465	0.840254

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	393.825	665.636
SumX1Traits	394.338	664.770	0.998699
SumTraits	420.433	623.510	0.936713
SumTraits_Tuple	409.910	639.516	0.960758
Sum_ConstTraits	393.377	666.395	1.001139
Sum_ConstTraits_Tuple	407.818	642.796	0.965687

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
SumBase	436.351	600.764
SumX1Traits	440.361	595.294	0.990894
SumTraits	441.392	593.902	0.988578
SumTraits_Tuple	473.317	553.844	0.921899
Sum_ConstTraits	439.518	596.436	0.992795
Sum_ConstTraits_Tuple	468.333	559.738	0.931710

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	519.200	504.900
SumX1Traits	529.436	495.138	0.980667
SumTraits	529.566	495.016	0.980425
SumTraits_Tuple	590.155	444.195	0.879769
Sum_ConstTraits	526.120	498.259	0.986848
Sum_ConstTraits_Tuple	584.299	448.647	0.888586

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	511.813	512.187
SumX1Traits	475.626	551.156	1.076083
SumTraits	480.890	545.123	1.064304
SumTraits_Tuple	628.317	417.216	0.814578
Sum_ConstTraits	475.426	551.388	1.076536
Sum_ConstTraits_Tuple	595.525	440.190	0.859432

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	394.091	665.187
SumX1Traits	396.399	661.314	0.994178
SumTraits	395.895	662.155	0.995442
SumTraits_Tuple	411.675	636.774	0.957285
Sum_ConstTraits	395.413	662.963	0.996656
Sum_ConstTraits_Tuple	411.142	637.600	0.958528

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
SumBase	437.182	599.622
SumX1Traits	20.824	12588.475	20.994018
SumTraits	15.545	16864.059	28.124484
SumTraits_Tuple	15.625	16776.692	27.978780
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	15.618	16784.741	27.992203
Sum_ConstTraits	12.532	20918.753	34.886568
Sum_ConstTraits_Tuple	12.224	21444.864	35.763971
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	12.390	21156.872	35.283682

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	519.229	504.872
SumX1Traits	41.214	6360.544	12.598341
SumTraits	28.075	9337.349	18.494504
SumTraits_Tuple	29.655	8839.844	17.509095
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	41.724	6282.844	12.444441
Sum256Traits	33.593	7803.562	15.456529
Sum_ConstTraits	23.765	11030.670	21.848467
Sum_ConstTraits_Tuple	22.861	11467.016	22.712739
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	20.961	12506.535	24.771718

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	511.420	512.581
SumX1Traits	88.454	2963.617	5.781759
SumTraits	64.583	4059.038	7.918828
SumTraits_Tuple	67.252	3897.947	7.604553
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	71.734	3654.396	7.129407
Sum_ConstTraits	50.315	5210.073	10.164396
Sum_ConstTraits_Tuple	43.750	5991.802	11.689482
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	47.754	5489.517	10.709568

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	400.498	654.546
SumX1Traits	9.940	26371.898	40.290384
SumTraits	7.172	36551.741	55.842917
SumTraits_Tuple	7.178	36518.622	55.792318
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	7.191	36451.980	55.690504
Sum_ConstTraits	6.938	37782.714	57.723568
Sum_ConstTraits_Tuple	7.083	37009.229	56.541856
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	7.323	35796.960	54.689779

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
SumBase	434.139	603.825
SumX1Traits	20.472	12805.003	21.206464
SumTraits	14.579	17980.674	29.777934
SumTraits_Tuple	15.102	17358.103	28.746889
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	15.411	17009.850	28.170144
Sum_ConstTraits	13.224	19822.708	32.828540
Sum_ConstTraits_Tuple	12.504	20965.262	34.720732
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	12.457	21044.723	34.852328

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	517.011	507.037
SumX1Traits	40.712	6438.974	12.699210
SumTraits	29.016	9034.602	17.818414
SumTraits_Tuple	32.578	8046.743	15.870118
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	41.877	6259.861	12.345955
Sum256Traits	29.100	9008.328	17.766595
Sum_ConstTraits	21.060	12447.734	24.549933
Sum_ConstTraits_Tuple	20.800	12603.177	24.856505
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	23.952	10944.443	21.585082

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	465.129	563.594
SumX1Traits	83.831	3127.037	5.548385
SumTraits	60.656	4321.786	7.668260
SumTraits_Tuple	60.315	4346.219	7.711612
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	56.921	4605.398	8.171479
Sum_ConstTraits	44.504	5890.333	10.451375
Sum_ConstTraits_Tuple	47.133	5561.813	9.868472
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	44.025	5954.416	10.565078

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	436.055	601.172
SumX1Traits	9.841	26636.607	44.307788
SumTraits	6.704	39103.682	65.045735
SumTraits_Tuple	6.348	41296.723	68.693677
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.622	39584.332	65.845255
Sum_ConstTraits	6.693	39166.800	65.150725
Sum_ConstTraits_Tuple	6.754	38813.429	64.562923
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	6.718	39019.174	64.905162

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
SumBase	444.156	590.206
SumX1Traits	15.270	17166.723	29.085965
SumTraits	13.099	20013.165	33.908756
SumTraits_Tuple	13.013	20144.691	34.131603
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	12.742	20573.701	34.858485
Sum_ConstTraits	13.120	19981.068	33.854374
Sum_ConstTraits_Tuple	13.103	20005.779	33.896241
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	13.218	19832.426	33.602525

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	526.545	497.857
SumX1Traits	30.833	8502.129	17.077454
SumTraits	25.101	10443.459	20.976829
SumTraits_Tuple	24.484	10706.530	21.505235
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	31.734	8260.669	16.592455
Sum256Traits	26.847	9764.434	19.612932
Sum_ConstTraits	20.861	12566.053	25.240291
Sum_ConstTraits_Tuple	20.771	12620.513	25.349680
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	20.855	12569.862	25.247941

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	463.940	565.039
SumX1Traits	64.166	4085.429	7.230351
SumTraits	54.582	4802.722	8.499810
SumTraits_Tuple	57.065	4593.745	8.129964
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	62.872	4169.457	7.379063
Sum_ConstTraits	43.757	5990.971	10.602761
Sum_ConstTraits_Tuple	51.585	5081.794	8.993708
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	44.562	5882.707	10.411156

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	395.023	663.618
SumX1Traits	6.743	38878.061	58.585019
SumTraits	4.998	52453.713	79.042053
SumTraits_Tuple	4.898	53516.263	80.643200
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4.994	52495.306	79.104728
Sum_ConstTraits	5.070	51706.781	77.916507
Sum_ConstTraits_Tuple	5.028	52140.221	78.569655
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	5.066	51744.542	77.973409

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
SumBase	361.277	725.603
SumX1Traits	15.435	16983.903	23.406599
SumTraits	12.125	21619.405	29.795080
SumTraits_Tuple	11.619	22562.252	31.094477
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.810	24249.953	33.420404
Sum_ConstTraits	12.520	20937.951	28.855924
Sum_ConstTraits_Tuple	12.856	20391.096	28.102268
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	16.055	16328.016	22.502679

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	1670557139
SumBase	448.354	584.681
SumX1Traits	28.877	9077.804	15.526079
SumTraits	23.861	10986.285	18.790219
SumTraits_Tuple	23.005	11395.046	19.489337
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	28.781	9108.298	15.578234
Sum256Traits	21.324	12293.576	21.026123
Sum_ConstTraits	30.317	8646.701	14.788749
Sum_ConstTraits_Tuple	20.435	12828.163	21.940445
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	21.366	12269.347	20.984684

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	-7093169134606779633
SumBase	585.043	448.076
SumX1Traits	63.999	4096.083	9.141488
SumTraits	49.780	5266.053	11.752584
SumTraits_Tuple	48.547	5399.786	12.051045
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	48.576	5396.537	12.043794
Sum_ConstTraits	44.458	5896.398	13.159366
Sum_ConstTraits_Tuple	50.543	5186.605	11.575276
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	44.799	5851.555	13.059287

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	90
SumBase	330.690	792.719
SumX1Traits	5.343	49063.776	61.893034
SumTraits	4.572	57334.593	72.326515
SumTraits_Tuple	4.553	57573.095	72.627381
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	4.703	55743.618	70.319531
Sum_ConstTraits	4.658	56283.041	71.000002
Sum_ConstTraits_Tuple	4.884	53676.071	67.711358
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	4.732	55397.453	69.882849

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
SumBase	680.228	385.376
SumX1Traits	683.729	383.403	0.994880
SumTraits	678.912	386.124	1.001939
SumTraits_Tuple	740.613	353.956	0.918467
Sum128Traits	1067.384	245.595	0.637285
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	700.385	374.285	0.971220
Sum_ConstTraits_Tuple	763.411	343.385	0.891039
Sum_Const128Traits	1088.504	240.830	0.624920
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	701.803	373.529
SumX1Traits	703.302	372.733	0.997868
SumTraits	706.665	370.960	0.993120
SumTraits_Tuple	926.620	282.903	0.757379
Sum128Traits	1464.044	179.055	0.479359
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	683.977	383.264	1.026062
Sum_ConstTraits_Tuple	905.949	289.359	0.774661
Sum_Const128Traits	1462.648	179.226	0.479817
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	833.377	314.556
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	833.850	314.378	0.999433
SumTraits_Tuple	1030.128	254.477	0.809003
Sum128Traits	1288.047	203.521	0.647008
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	851.025	308.033	0.979262
Sum_ConstTraits_Tuple	1043.314	251.261	0.798779
Sum_Const128Traits	1275.076	205.591	0.653590
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	570.283	459.674
SumX1Traits	566.460	462.776	1.006749
SumTraits	570.797	459.260	0.999099
SumTraits_Tuple	745.928	351.433	0.764528
Sum128Traits	1021.148	256.715	0.558472
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	728.094	360.042	0.783255
Sum_ConstTraits_Tuple	769.832	340.521	0.740788
Sum_Const128Traits	1032.994	253.771	0.552068
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
SumBase	701.044	373.934
SumX1Traits	42.373	6186.546	16.544491
SumTraits	35.635	7356.283	19.672684
SumTraits_Tuple	121.995	2148.815	5.746512
Sum128_AdvSimd	61.598	4255.694	11.380875
Sum128Traits	35.650	7353.196	19.664430
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	36.154	7250.859	19.390752
Sum_ConstTraits_Tuple	120.663	2172.532	5.809936
Sum_Const128Traits	35.869	7308.348	19.544493
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	703.121	372.829
SumX1Traits	87.680	2989.791	8.019205
SumTraits	75.969	3450.650	9.255317
SumTraits_Tuple	285.958	916.722	2.458828
Sum128_AdvSimd	142.690	1837.160	4.927621
Sum128Traits	75.761	3460.151	9.280801
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	76.697	3417.902	9.167482
Sum_ConstTraits_Tuple	278.951	939.748	2.520587
Sum_Const128Traits	76.111	3444.252	9.238156
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	805.638	325.387
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	204.479	1282.010	3.939956
SumTraits_Tuple	642.540	407.981	1.253833
Sum128_AdvSimd	461.898	567.537	1.744190
Sum128Traits	204.307	1283.091	3.943278
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	209.453	1251.562	3.846382
Sum_ConstTraits_Tuple	617.317	424.651	1.305064
Sum_Const128Traits	207.424	1263.806	3.884009
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	583.794	449.035
SumX1Traits	19.273	13601.501	30.290515
SumTraits	17.570	14920.057	33.226936
SumTraits_Tuple	56.546	4635.947	10.324245
Sum128_AdvSimd	30.337	8641.067	19.243638
Sum128Traits	17.665	14839.860	33.048339
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	17.395	15070.183	33.561266
Sum_ConstTraits_Tuple	57.125	4588.918	10.219511
Sum_Const128Traits	17.422	15047.050	33.509750
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
SumBase	674.908	388.414
SumX1Traits	33.695	7779.923	20.029962
SumTraits	30.740	8527.872	21.955609
SumTraits_Tuple	88.911	2948.397	7.590857
Sum128_AdvSimd	48.741	5378.270	13.846737
Sum128Traits	31.186	8405.720	21.641120
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	30.430	8614.552	22.178775
Sum_ConstTraits_Tuple	91.406	2867.906	7.383628
Sum_Const128Traits	30.250	8665.824	22.310777
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	685.201	382.580
SumX1Traits	67.758	3868.854	10.112542
SumTraits	62.843	4171.416	10.903387
SumTraits_Tuple	191.099	1371.774	3.585590
Sum128_AdvSimd	96.970	2703.353	7.066115
Sum128Traits	61.168	4285.667	11.202021
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	61.145	4287.246	11.206149
Sum_ConstTraits_Tuple	187.546	1397.755	3.653500
Sum_Const128Traits	60.898	4304.607	11.251528
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	767.929	341.365
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	170.799	1534.814	4.496107
SumTraits_Tuple	410.950	637.898	1.868669
Sum128_AdvSimd	411.983	636.298	1.863981
Sum128Traits	170.748	1535.271	4.497447
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	175.281	1495.562	4.381123
Sum_ConstTraits_Tuple	415.833	630.406	1.846722
Sum_Const128Traits	175.423	1494.354	4.377584
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	565.239	463.775
SumX1Traits	16.717	15681.305	33.812300
SumTraits	15.084	17379.516	37.474014
SumTraits_Tuple	46.151	5680.080	12.247487
Sum128_AdvSimd	24.136	10861.045	23.418774
Sum128Traits	15.080	17383.487	37.482576
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	15.399	17023.556	36.706487
Sum_ConstTraits_Tuple	46.280	5664.273	12.213404
Sum_Const128Traits	14.982	17496.875	37.727065
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
SumBase	508.951	515.068
SumX1Traits	29.886	8771.372	17.029549
SumTraits	25.084	10450.586	20.289730
SumTraits_Tuple	88.007	2978.661	5.783046
Sum128_AdvSimd	45.565	5753.145	11.169685
Sum128Traits	25.217	10395.658	20.183088
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	26.592	9857.966	19.139163
Sum_ConstTraits_Tuple	92.851	2823.285	5.481385
Sum_Const128Traits	26.638	9840.875	19.105981
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	2018061718
SumBase	662.552	395.658
SumX1Traits	68.505	3826.650	9.671616
SumTraits	53.227	4925.019	12.447673
SumTraits_Tuple	181.844	1441.584	3.643513
Sum128_AdvSimd	112.031	2339.920	5.913999
Sum128Traits	53.144	4932.728	12.467157
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	54.835	4780.630	12.082741
Sum_ConstTraits_Tuple	182.503	1436.382	3.630365
Sum_Const128Traits	54.738	4789.040	12.103994
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	5878554485936559874
SumBase	613.604	427.220
SumX1Traits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumTraits	160.531	1632.983	3.822345
SumTraits_Tuple	369.191	710.049	1.662021
Sum128_AdvSimd	375.321	698.452	1.634876
Sum128Traits	161.020	1628.026	3.810742
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	160.627	1632.008	3.820062
Sum_ConstTraits_Tuple	367.909	712.523	1.667813
Sum_Const128Traits	160.533	1632.956	3.822281
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase	91
SumBase	411.155	637.579
SumX1Traits	14.952	17532.266	27.498194
SumTraits	12.494	20981.283	32.907748
SumTraits_Tuple	44.797	5851.797	9.178154
Sum128_AdvSimd	23.019	11388.153	17.861561
Sum128Traits	12.464	21032.805	32.988557
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	13.268	19757.971	30.989065
Sum_ConstTraits_Tuple	44.047	5951.434	9.334429
Sum_Const128Traits	13.283	19735.324	30.953543
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

