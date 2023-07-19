# Benchmark - YShuffleG2
([← Back](README.md))
See [Group](YShuffleG2_Group.md)

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	435.701	601.661
SumBase	429.554	610.271	1.014310
SumTraits	433.186	605.154	1.005805
Sum_ConstTraits	428.180	612.229	1.017565

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	537.889	487.357
SumBase	528.583	495.938	1.017606
SumTraits	526.851	497.567	1.020950
Sum_ConstTraits	525.372	498.969	1.023826

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	551.963	474.930
SumBase	531.018	493.663	1.039444
SumTraits	529.021	495.526	1.043366
Sum_ConstTraits	518.446	505.635	1.064650

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	385.031	680.839
SumBase	381.932	686.362	1.008113
SumTraits	398.644	657.589	0.965850
Sum_ConstTraits	383.028	684.398	1.005228

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	429.319	610.604
SumBase	429.695	610.069	0.999125
SumTraits	429.559	610.264	0.999443
Sum_ConstTraits	430.342	609.153	0.997625

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	528.537	495.980
SumBase	528.419	496.091	1.000223
SumTraits	527.935	496.546	1.001141
Sum_ConstTraits	526.044	498.331	1.004740

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	531.184	493.509
SumBase	530.040	494.574	1.002159
SumTraits	530.963	493.714	1.000416
Sum_ConstTraits	497.495	526.928	1.067718

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	383.030	684.396
SumBase	381.284	687.529	1.004579
SumTraits	381.904	686.413	1.002947
Sum_ConstTraits	392.530	667.831	0.975796

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	430.353	609.137
SumBase	430.511	608.914	0.999634
SumTraits	21.637	12115.302	19.889273
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	21.446	12223.608	20.067076
Sum_ConstTraits	21.430	12232.550	20.081755
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	21.742	12056.756	19.793160

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	527.230	497.210
SumBase	528.336	496.169	0.997908
SumTraits	44.203	5930.524	11.927611
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	44.540	5885.550	11.837159
Sum256Traits	44.505	5890.157	11.846424
Sum_ConstTraits	44.573	5881.220	11.828449
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	113.175	2316.265	4.658528
Sum_Const256_AvxImmByte	96.911	2704.986	5.440332
Sum_Const256_AvxImmByteG4	22.471	11665.863	23.462663
Sum_Const256Traits	45.302	5786.600	11.638148

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	528.733	495.797
SumBase	529.481	495.096	0.998587
SumTraits	88.355	2966.933	5.984174
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	89.458	2930.342	5.910373
Sum_ConstTraits	90.726	2889.393	5.827780
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	97.007	2702.333	5.450487

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	380.235	689.426
SumBase	380.458	689.022	0.999415
SumTraits	10.094	25969.580	37.668428
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.110	25928.280	37.608523
Sum_ConstTraits	10.245	25587.549	37.114298
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	10.304	25440.344	36.900780

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	429.095	610.923
SumBase	434.708	603.034	0.987087
SumTraits	21.607	12132.537	19.859339
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	22.013	11908.610	19.492802
Sum_ConstTraits	22.373	11716.767	19.178780
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	22.376	11715.588	19.176850

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	526.615	497.791
SumBase	537.378	487.820	0.979971
SumTraits	44.969	5829.429	11.710608
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	46.424	5646.748	11.343624
Sum256Traits	46.540	5632.720	11.315442
Sum_ConstTraits	57.465	4561.814	9.164124
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	98.334	2665.846	5.355358
Sum_Const256_AvxImmByte	97.502	2688.603	5.401072
Sum_Const256_AvxImmByteG4	25.157	10420.470	20.933445
Sum_Const256Traits	46.868	5593.286	11.236224

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	506.690	517.366
SumBase	527.284	497.159	0.960944
SumTraits	90.224	2905.467	5.615889
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	102.215	2564.635	4.957104
Sum_ConstTraits	97.194	2697.113	5.213167
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	91.860	2853.727	5.515881

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	381.658	686.856
SumBase	381.611	686.940	1.000122
SumTraits	10.110	25929.590	37.751136
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	10.338	25356.755	36.917141
Sum_ConstTraits	10.670	24567.565	35.768152
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	10.710	24477.325	35.636770

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	436.376	600.729
SumBase	433.865	604.206	1.005788
SumTraits	17.842	14692.144	24.457172
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	16.084	16298.808	27.131694
Sum_ConstTraits	16.496	15891.814	26.454195
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	16.798	15605.467	25.977529

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	530.504	494.142
SumBase	542.097	483.574	0.978614
SumTraits	33.087	7922.891	16.033647
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	34.057	7697.192	15.576898
Sum256Traits	33.733	7771.078	15.726423
Sum_ConstTraits	33.214	7892.578	15.972303
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	99.494	2634.768	5.332010
Sum_Const256_AvxImmByte	113.217	2315.412	4.685727
Sum_Const256_AvxImmByteG4	23.988	10928.142	22.115409
Sum_Const256Traits	32.665	8025.215	16.240723

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	505.631	518.450
SumBase	526.615	497.791	0.960153
SumTraits	65.814	3983.118	7.682748
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	64.558	4060.597	7.832192
Sum_ConstTraits	67.407	3888.951	7.501116
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	70.852	3699.864	7.136400

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	385.959	679.202
SumBase	386.758	677.799	0.997934
SumTraits	7.824	33504.420	49.329074
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	7.780	33694.567	49.609032
Sum_ConstTraits	7.633	34341.574	50.561630
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	7.485	35023.889	51.566213

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	349.329	750.421
SumBase	352.934	742.757	0.989787
SumTraits	14.616	17934.933	23.899828
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	14.644	17900.610	23.854089
Sum_ConstTraits	14.800	17711.836	23.602532
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	15.510	16901.518	22.522714

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	471.362	556.141
SumBase	463.659	565.380	1.016613
SumTraits	31.024	8449.735	15.193501
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	31.596	8296.838	14.918576
Sum256Traits	30.586	8570.734	15.411069
Sum_ConstTraits	31.279	8380.869	15.069672
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256_AvxImm	96.814	2707.700	4.868726
Sum_Const256_AvxImmByte	101.362	2586.209	4.650272
Sum_Const256_AvxImmByteG4	22.899	11447.921	20.584550
Sum_Const256Traits	31.296	8376.151	15.061188

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	501.757	522.452
SumBase	522.742	501.479	0.959856
SumTraits	58.225	4502.237	8.617512
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	59.322	4419.006	8.458202
Sum_ConstTraits	59.515	4404.702	8.430824
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	64.038	4093.564	7.835291

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	307.148	853.476
SumBase	306.981	853.942	1.000546
SumTraits	6.896	38013.166	44.539207
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.945	37748.060	44.228587
Sum_ConstTraits	6.758	38789.379	45.448679
Sum_Const128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum_Const256Traits	6.821	38432.414	45.030430

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	640.698	409.154
SumBase	642.162	408.221	0.997721
SumTraits	641.875	408.404	0.998167
Sum128Traits	1031.169	254.220	0.621332
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	660.252	397.036	0.970384
Sum_Const128Traits	1045.528	250.729	0.612798
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	734.539	356.882
SumBase	735.735	356.302	0.998374
SumTraits	736.021	356.164	0.997986
Sum128Traits	1484.115	176.633	0.494934
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	710.994	368.701	1.033116
Sum_Const128Traits	1482.698	176.802	0.495407
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	676.932	387.253
SumBase	675.198	388.248	1.002569
SumTraits	676.730	387.369	1.000298
Sum128Traits	1262.948	207.565	0.535993
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	680.671	385.126	0.994507
Sum_Const128Traits	1276.459	205.368	0.530320
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	529.038	495.511
SumBase	529.465	495.111	0.999192
SumTraits	528.461	496.051	1.001090
Sum128Traits	797.404	328.747	0.663450
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	550.472	476.216	0.961061
Sum_Const128Traits	815.139	321.594	0.649015
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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	632.172	414.672
SumBase	631.707	414.977	1.000736
SumTraits	60.927	4302.595	10.375906
Sum128_AdvSimd	80.360	3262.138	7.866796
Sum128Traits	61.362	4272.100	10.302367
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	66.092	3966.361	9.565063
Sum_Const128Traits	66.159	3962.327	9.555334
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	684.862	382.769
SumBase	690.991	379.374	0.991129
SumTraits	123.115	2129.258	5.562771
Sum128_AdvSimd	162.151	1616.664	4.223598
Sum128Traits	123.485	2122.873	5.546091
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	123.701	2119.166	5.536406
Sum_Const128Traits	132.764	1974.510	5.158487
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	407.478	643.332
SumBase	405.883	645.861	1.003931
SumTraits	264.097	992.606	1.542914
Sum128_AdvSimd	323.030	811.517	1.261428
Sum128Traits	248.540	1054.736	1.639489
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	246.001	1065.621	1.656409
Sum_Const128Traits	245.407	1068.202	1.660420
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	524.675	499.631
SumBase	525.442	498.902	0.998540
SumTraits	30.106	8707.354	17.427553
Sum128_AdvSimd	40.726	6436.756	12.883008
Sum128Traits	31.267	8384.063	16.780494
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	30.330	8643.008	17.298767
Sum_Const128Traits	30.264	8661.896	17.336570
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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	634.192	413.351
SumBase	634.371	413.235	0.999718
SumTraits	53.269	4921.160	11.905512
Sum128_AdvSimd	73.215	3580.481	8.662075
Sum128Traits	53.159	4931.318	11.930089
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	49.901	5253.318	12.709087
Sum_Const128Traits	53.119	4935.012	11.939025
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	685.317	382.515
SumBase	681.696	384.547	1.005311
SumTraits	106.314	2465.741	6.446128
Sum128_AdvSimd	146.691	1787.049	4.671839
Sum128Traits	100.502	2608.349	6.818944
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	106.571	2459.813	6.430629
Sum_Const128Traits	100.238	2615.225	6.836920
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	408.279	642.071
SumBase	408.196	642.201	1.000202
SumTraits	211.799	1237.701	1.927669
Sum128_AdvSimd	292.518	896.163	1.395738
Sum128Traits	200.318	1308.638	2.038151
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	199.922	1311.234	2.042193
Sum_Const128Traits	200.145	1309.772	2.039917
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	527.236	497.205
SumBase	526.159	498.222	1.002046
SumTraits	24.930	10515.270	21.148781
Sum128_AdvSimd	36.565	7169.175	14.418965
Sum128Traits	25.008	10482.216	21.082303
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	24.936	10512.627	21.143467
Sum_Const128Traits	26.594	9857.265	19.825372
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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-4214
SumScalar	465.576	563.053
SumBase	467.163	561.141	0.996605
SumTraits	39.706	6602.053	11.725463
Sum128_AdvSimd	59.503	4405.554	7.824409
Sum128Traits	39.696	6603.788	11.728545
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	39.686	6605.427	11.731456
Sum_Const128Traits	39.704	6602.437	11.726145
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	695.645	376.836
SumBase	698.914	375.073	0.995324
SumTraits	79.506	3297.153	8.749578
Sum128_AdvSimd	114.428	2290.914	6.079346
Sum128Traits	79.575	3294.304	8.742017
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	79.565	3294.727	8.743140
Sum_Const128Traits	79.506	3297.170	8.749623
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	357.964	732.319
SumBase	358.685	730.847	0.997989
SumTraits	160.643	1631.844	2.228323
Sum128_AdvSimd	251.518	1042.249	1.423217
Sum128Traits	160.501	1633.288	2.230294
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	160.363	1634.691	2.232210
Sum_Const128Traits	160.416	1634.150	2.231471
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	373.597	701.675
SumBase	373.603	701.665	0.999985
SumTraits	19.796	13242.276	18.872374
Sum128_AdvSimd	28.929	9061.620	12.914266
Sum128Traits	19.798	13240.881	18.870385
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	19.809	13233.426	18.859762
Sum_Const128Traits	19.805	13236.416	18.864022
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

