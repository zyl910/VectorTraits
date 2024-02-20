# Benchmark - YShuffleG2
([← Back](README.md))

See [Group](YShuffleG2_Group.md)

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	427.146	613.710
SumBase	431.536	607.467	0.989827
SumTraits	431.881	606.983	0.989038

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	524.372	499.920
SumBase	536.235	488.861	0.977878
SumTraits	535.457	489.571	0.979298

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	522.420	501.788
SumBase	547.174	479.088	0.954761
SumTraits	549.163	477.352	0.951302

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	377.958	693.580
SumBase	382.300	685.702	0.988641
SumTraits	380.680	688.620	0.992848

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	426.192	615.084
SumBase	426.291	614.942	0.999769
SumTraits	426.876	614.098	0.998397

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	524.053	500.224
SumBase	525.141	499.188	0.997928
SumTraits	524.561	499.740	0.999031

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	525.398	498.944
SumBase	526.146	498.234	0.998578
SumTraits	525.781	498.580	0.999272

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	378.323	692.910
SumBase	378.828	691.988	0.998669
SumTraits	378.044	693.421	1.000738

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	426.442	614.723
SumBase	426.058	615.277	1.000901
SumTraits	21.733	12062.124	19.622042
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	22.040	11894.025	19.348587

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	523.982	500.292
SumBase	524.343	499.948	0.999312
SumTraits	42.383	6185.124	12.363038
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	42.484	6170.363	12.333534
Sum256Traits	42.421	6179.582	12.351961

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	524.686	499.621
SumBase	523.011	501.221	1.003202
SumTraits	85.518	3065.379	6.135411
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	85.690	3059.214	6.123071

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	378.475	692.633
SumBase	377.942	693.610	1.001410
SumTraits	9.946	26356.467	38.052569
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	9.942	26368.652	38.070161

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	427.652	612.985
SumBase	433.750	604.367	0.985941
SumTraits	21.227	12349.700	20.146826
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	21.264	12327.884	20.111235

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	524.185	500.098
SumBase	533.292	491.558	0.982923
SumTraits	43.571	6016.417	12.030477
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	43.533	6021.792	12.041225
Sum256Traits	43.581	6015.130	12.027902

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	502.400	521.783
SumBase	521.354	502.814	0.963645
SumTraits	85.368	3070.744	5.885094
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	85.367	3070.792	5.885185

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	378.792	692.053
SumBase	381.841	686.527	0.992014
SumTraits	9.979	26269.727	37.959116
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	9.964	26309.214	38.016173

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	427.064	613.828
SumBase	566.309	462.899	0.754118
SumTraits	12.595	20813.621	33.907880
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	13.572	19315.244	31.466845

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	524.020	500.256
SumBase	813.286	322.327	0.644324
SumTraits	27.452	9549.107	19.088450
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	29.452	8900.803	17.792505
Sum256Traits	30.499	8595.103	17.181417

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	503.059	521.100
SumBase	1101.816	237.920	0.456572
SumTraits	50.403	5200.986	9.980786
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	49.613	5283.821	10.139748

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	379.123	691.449
SumBase	448.228	584.845	0.845825
SumTraits	5.846	44842.162	64.852440
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.480	40455.310	58.508008

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


[YShuffleG2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	28917
SumScalar	346.753	755.996
SumBase	347.276	754.857	0.998494
SumTraits	13.672	19174.068	25.362670
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	16.196	16185.459	21.409461

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-1234767990
SumScalar	446.989	586.467
SumBase	447.020	586.425	0.999929
SumTraits	26.951	9726.706	16.585266
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256_AvxByte	26.304	9965.984	16.993265
Sum256Traits	28.098	9329.745	15.908398

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-5475020453166212109
SumScalar	499.000	525.338
SumBase	498.637	525.721	1.000729
SumTraits	51.738	5066.715	9.644668
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	53.072	4939.400	9.402320

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-47
SumScalar	299.881	874.159
SumBase	312.870	837.868	0.958484
SumTraits	5.753	45567.330	52.127023
Sum128_AdvSimd	Run fail! Requires hardware support AdvSimd!
Sum128Traits	Run fail! Vector byte size mismatch(32!=16) !
Sum256Traits	6.513	40250.872	46.045229

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
SumScalar	641.147	408.867
SumBase	642.370	408.089	0.998097
SumTraits	642.977	407.703	0.997153
Sum128Traits	1032.773	253.825	0.620801
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	662.836	395.489	0.967279
Sum_Const128Traits	1048.264	250.075	0.611628
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	734.179	357.057
SumBase	736.233	356.061	0.997210
SumTraits	736.612	355.878	0.996698
Sum128Traits	1482.588	176.815	0.495201
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	711.971	368.195	1.031193
Sum_Const128Traits	1484.191	176.624	0.494666
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	702.348	373.239
SumBase	680.468	385.241	1.032154
SumTraits	675.432	388.113	1.039851
Sum128Traits	1265.155	207.203	0.555148
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	674.650	388.563	1.041055
Sum_Const128Traits	2014.728	130.114	0.348607
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	527.228	497.212
SumBase	526.947	497.477	1.000533
SumTraits	527.700	496.767	0.999105
Sum128Traits	795.886	329.374	0.662441
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	547.993	478.371	0.962106
Sum_Const128Traits	809.591	323.798	0.651228
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
SumScalar	632.719	414.314
SumBase	632.393	414.527	1.000516
SumTraits	61.072	4292.406	10.360284
Sum128_AdvSimd	77.850	3367.297	8.127413
Sum128Traits	59.193	4428.609	10.689028
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	61.224	4281.729	10.334512
Sum_Const128Traits	59.176	4429.919	10.692188
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	688.092	380.972
SumBase	680.304	385.334	1.011447
SumTraits	123.179	2128.149	5.586099
Sum128_AdvSimd	156.532	1674.701	4.395859
Sum128Traits	123.032	2130.689	5.592766
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	120.213	2180.661	5.723934
Sum_Const128Traits	120.846	2169.232	5.693935
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	407.702	642.980
SumBase	408.777	641.289	0.997370
SumTraits	242.649	1080.341	1.680209
Sum128_AdvSimd	319.141	821.406	1.277499
Sum128Traits	244.010	1074.316	1.670839
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	244.756	1071.043	1.665749
Sum_Const128Traits	245.296	1068.682	1.662078
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	524.980	499.341
SumBase	525.695	498.662	0.998640
SumTraits	28.722	9127.030	18.278142
Sum128_AdvSimd	39.031	6716.285	13.450292
Sum128Traits	29.821	8790.495	17.604185
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	30.154	8693.426	17.409790
Sum_Const128Traits	30.733	8529.797	17.082101
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
SumScalar	631.863	414.875
SumBase	632.219	414.641	0.999436
SumTraits	46.598	5625.606	13.559764
Sum128_AdvSimd	66.702	3930.065	9.472891
Sum128Traits	46.585	5627.211	13.563632
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	52.850	4960.118	11.955695
Sum_Const128Traits	46.643	5620.166	13.546652
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	681.772	384.504
SumBase	684.484	382.980	0.996037
SumTraits	94.200	2782.839	7.237476
Sum128_AdvSimd	134.586	1947.774	5.065677
Sum128Traits	106.492	2461.635	6.402103
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	94.148	2784.380	7.241483
Sum_Const128Traits	106.586	2459.462	6.396452
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	407.790	642.840
SumBase	407.856	642.737	0.999839
SumTraits	211.148	1241.516	1.931297
Sum128_AdvSimd	266.683	982.979	1.529119
Sum128Traits	186.338	1406.823	2.188449
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	186.073	1408.820	2.191556
Sum_Const128Traits	186.282	1407.240	2.189098
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	525.510	498.837
SumBase	524.890	499.426	1.001182
SumTraits	23.249	11275.733	22.604050
Sum128_AdvSimd	33.311	7869.652	15.776004
Sum128Traits	26.379	9937.638	19.921619
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	26.359	9945.001	19.936380
Sum_Const128Traits	23.250	11275.200	22.602981
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
SumScalar	464.227	564.690
SumBase	466.270	562.215	0.995618
SumTraits	39.637	6613.609	11.711937
Sum128_AdvSimd	58.448	4485.065	7.942532
Sum128Traits	39.558	6626.837	11.735364
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	39.576	6623.755	11.729904
Sum_Const128Traits	39.592	6621.201	11.725382
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	1787346957
SumScalar	695.247	377.051
SumBase	698.013	375.558	0.996038
SumTraits	79.975	3277.805	8.693258
Sum128_AdvSimd	129.443	2025.177	5.371090
Sum128Traits	79.843	3283.247	8.707690
Sum256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	79.920	3280.066	8.699253
Sum_Const128Traits	79.863	3282.427	8.705515
Sum_Const256_AvxImm	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByte	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256_AvxImmByteG4	Run fail! Requires hardware support Avx, Avx2!
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	5878554485936559874
SumScalar	358.414	731.401
SumBase	357.971	732.306	1.001237
SumTraits	160.467	1633.636	2.233571
Sum128_AdvSimd	249.916	1048.929	1.434136
Sum128Traits	160.549	1632.801	2.232429
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	160.506	1633.239	2.233029
Sum_Const128Traits	160.776	1630.490	2.229270
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	99
SumScalar	373.884	701.137
SumBase	374.219	700.510	0.999106
SumTraits	19.874	13190.553	18.813082
Sum128_AdvSimd	31.083	8433.558	12.028398
Sum128Traits	19.832	13218.098	18.852368
Sum256Traits	Run fail! Vector byte size mismatch(16!=32) !
Sum_ConstTraits	19.839	13213.780	18.846210
Sum_Const128Traits	19.830	13219.879	18.854909
Sum_Const256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

