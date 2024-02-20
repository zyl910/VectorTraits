# Benchmark - Multiply
([← Back](README.md))

See [Group](Multiply_Group.md)

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.6184711382
Check-SumBcl	Check `SumBcl` mismatch. 32712.6184711381!=32712.6184711382
Check-SumTraits	Check `SumTraits` mismatch. 32712.6184711381!=32712.6184711382
SumScalar	175.685	1492.126
SumBcl	44.118	5941.887	3.982163
SumTraits	45.916	5709.209	3.826226

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
SumScalar	162.585	1612.348
SumBcl	9.784	26793.489	16.617679
SumTraits	9.759	26862.607	16.660547

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
SumScalar	135.563	1933.743
SumBcl	22.234	11790.288	6.097133
SumTraits	20.016	13096.929	6.772839

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
SumScalar	162.215	1616.026
SumBcl	234.807	1116.424	0.690845
SumBcl_Widen	798.842	328.155	0.203063
SumTraits	640.613	409.208	0.253219

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.88
Check-SumBcl	Check `SumBcl` mismatch. 32717.99!=32717.88
Check-SumTraits	Check `SumTraits` mismatch. 32717.99!=32717.88
SumScalar	190.292	1377.591
SumBcl	25.813	10155.660	7.372041
SumTraits	24.256	10807.551	7.845252

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
SumScalar	135.716	1931.557
SumBcl	459.090	571.008	0.295621
SumTraits	22.763	11516.456	5.962265

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
SumScalar	153.302	1709.986
SumBcl	883.929	296.567	0.173432
SumTraits	856.147	306.190	0.179060

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.6184711382
Check-SumBcl	Check `SumBcl` mismatch. 32712.6184711381!=32712.6184711382
Check-SumTraits	Check `SumTraits` mismatch. 32712.6184711381!=32712.6184711382
SumScalar	176.681	1483.711
SumBcl	45.495	5762.103	3.883574
SumTraits	45.691	5737.376	3.866908

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
SumScalar	161.728	1620.898
SumBcl	9.779	26807.983	16.538968
SumTraits	9.984	26256.253	16.198583

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
SumScalar	140.667	1863.578
SumBcl	20.460	12812.690	6.875316
SumTraits	20.439	12825.532	6.882208

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
SumScalar	157.533	1664.062
SumBcl	202.819	1292.502	0.776715
SumBcl_Widen	261.298	1003.238	0.602885
SumTraits	211.555	1239.127	0.744640

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.88
Check-SumBcl	Check `SumBcl` mismatch. 32717.99!=32717.88
Check-SumTraits	Check `SumTraits` mismatch. 32717.99!=32717.88
SumScalar	163.276	1605.528
SumBcl	20.664	12685.912	7.901396
SumTraits	20.780	12615.140	7.857315

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
SumScalar	136.710	1917.515
SumBcl	338.406	774.643	0.403983
SumTraits	20.720	12651.535	6.597881

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
SumScalar	146.289	1791.961
SumBcl	542.334	483.363	0.269740
SumTraits	538.966	486.383	0.271425

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	161.159	1626.616
SumBcl	41.068	6383.228	3.924237
SumTraits	42.007	6240.481	3.836480
Sum128Traits	79.652	3291.102	2.023281
Sum256Traits	43.137	6076.980	3.735964

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	157.275	1666.784
SumBcl	9.278	28254.982	16.951796
SumTraits	9.997	26222.365	15.732311
Sum128Traits	13.435	19512.067	11.706416
Sum256Traits	9.876	26543.619	15.925050

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	147.987	1771.393
SumBcl	20.622	12712.112	7.176335
SumTraits	20.378	12864.057	7.262112
Sum128Traits	30.270	8660.258	4.888952
Sum256Traits	19.280	13596.595	7.675650

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	156.057	1679.800
SumBcl	207.931	1260.726	0.750522
SumBcl_Widen	345.779	758.126	0.451320
SumTraits	10.798	24276.423	14.451974
Sum128Traits	13.013	20144.159	11.991999
Sum256Traits	10.541	24869.957	14.805310

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	157.739	1661.889
SumBcl	21.584	12145.192	7.308066
SumTraits	22.055	11885.893	7.152039
Sum128Traits	39.233	6681.766	4.020586
Sum256Traits	20.844	12576.546	7.567623

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	147.318	1779.441
SumBcl	461.511	568.013	0.319209
SumTraits	21.095	12426.605	6.983433
Sum128Traits	29.966	8748.023	4.916164
Sum256Traits	22.513	11644.321	6.543809

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	150.349	1743.571
SumBcl	530.718	493.943	0.283294
SumTraits	78.903	3322.379	1.905502
Sum128Traits	112.940	2321.100	1.331233
Sum256Traits	77.832	3368.073	1.931709
Sum256Avx	80.738	3246.847	1.862182

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	161.890	1619.272
SumBcl	41.187	6364.697	3.930592
SumTraits	46.095	5687.049	3.512103
Sum128Traits	80.389	3260.942	2.013832
Sum256Traits	43.950	5964.607	3.683512

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	156.477	1675.283
SumBcl	9.391	27914.878	16.662783
SumTraits	9.928	26403.744	15.760767
Sum128Traits	13.859	18915.079	11.290677
Sum256Traits	10.757	24369.240	14.546342

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	145.713	1799.037
SumBcl	20.428	12832.504	7.132984
SumTraits	21.802	12023.600	6.683352
Sum128Traits	28.440	9217.281	5.123452
Sum256Traits	20.376	12865.515	7.151333

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	158.618	1652.678
SumBcl	154.749	1693.991	1.024998
SumBcl_Widen	195.322	1342.111	0.812083
SumTraits	11.395	23004.444	13.919498
Sum128Traits	12.667	20695.630	12.522484
Sum256Traits	10.914	24020.020	14.534001

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	158.237	1656.654
SumBcl	20.968	12501.941	7.546500
SumTraits	21.229	12348.257	7.453732
Sum128Traits	39.587	6621.917	3.997163
Sum256Traits	21.432	12231.200	7.383074

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	172.916	1516.021
SumBcl	251.312	1043.103	0.688053
SumTraits	20.742	12638.400	8.336560
Sum128Traits	27.458	9546.977	6.297391
Sum256Traits	22.185	11816.245	7.794250

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	153.754	1704.963
SumBcl	393.747	665.768	0.390488
SumTraits	67.197	3901.142	2.288110
Sum128Traits	111.527	2350.494	1.378619
Sum256Traits	75.956	3451.265	2.024247
Sum256Avx	76.103	3444.609	2.020343

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	163.119	1607.067
SumBcl	40.104	6536.578	4.067395
SumTraits	40.229	6516.244	4.054742
Sum128Traits	80.529	3255.283	2.025605
Sum256Traits	43.248	6061.366	3.771694

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	152.102	1723.473
SumBcl	9.503	27585.093	16.005529
SumTraits	9.915	26439.172	15.340638
Sum128Traits	13.436	19510.367	11.320380
Sum256Traits	9.857	26594.337	15.430668

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	163.515	1603.177
SumBcl	22.852	11471.196	7.155290
SumTraits	24.684	10619.888	6.624276
Sum128Traits	30.813	8507.563	5.306690
Sum256Traits	21.165	12385.693	7.725717

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	152.519	1718.762
SumBcl	125.988	2080.714	1.210589
SumBcl_Widen	14.771	17746.765	10.325320
SumTraits	11.514	22766.465	13.245853
Sum128Traits	13.209	19845.787	11.546561
Sum256Traits	11.359	23078.465	13.427379

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	158.880	1649.955
SumBcl	21.102	12422.747	7.529144
SumTraits	20.921	12530.044	7.594174
Sum128Traits	39.306	6669.229	4.042068
Sum256Traits	20.944	12516.246	7.585812

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	146.405	1790.543
SumBcl	21.241	12341.522	6.892615
SumTraits	21.747	12054.160	6.732127
Sum128Traits	30.344	8639.067	4.824832
Sum256Traits	21.562	12157.598	6.789895

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	149.782	1750.166
SumBcl	282.015	929.540	0.531115
SumTraits	69.759	3757.828	2.147127
Sum128Traits	106.641	2458.183	1.404543
Sum256Traits	73.617	3560.936	2.034628
Sum256Avx	73.845	3549.899	2.028321

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.618471138187
Check-SumBcl	Check `SumBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumTraits	Check `SumTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumScalar	162.737	1610.842
SumBcl	40.098	6537.583	4.058489
SumTraits	41.878	6259.765	3.886021
Sum128Traits	79.305	3305.497	2.052031
Sum256Traits	41.458	6323.074	3.925323

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-11701
Check-Sum128Traits	Check `Sum128Traits` mismatch. 19479!=-11701
SumScalar	152.029	1724.307
SumBcl	9.804	26738.006	15.506525
SumTraits	9.533	27498.315	15.947461
Sum128Traits	13.105	20003.526	11.600909
Sum256Traits	9.912	26446.335	15.337372

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-452441065
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=-452441065
SumScalar	119.950	2185.444
SumBcl	19.960	13133.246	6.009417
SumTraits	22.286	11762.905	5.382386
Sum128Traits	29.835	8786.534	4.020480
Sum256Traits	19.735	13283.211	6.078037

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-41
Check-Sum128Traits	Check `Sum128Traits` mismatch. -113!=-41
SumScalar	142.770	1836.132
SumBcl	135.029	1941.387	1.057325
SumBcl_Widen	10.770	24340.482	13.256393
SumTraits	10.786	24303.228	13.236104
Sum128Traits	13.367	19611.256	10.680746
Sum256Traits	10.796	24281.862	13.224468

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32717.883
Check-SumBcl	Check `SumBcl` mismatch. 32717.988!=32717.883
Check-SumTraits	Check `SumTraits` mismatch. 32717.988!=32717.883
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32717.883
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32717.883
SumScalar	157.606	1663.283
SumBcl	20.501	12786.901	7.687748
SumTraits	20.358	12876.805	7.741801
Sum128Traits	39.225	6683.151	4.018048
Sum256Traits	19.735	13283.130	7.986092

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3842526231
Check-Sum128Traits	Check `Sum128Traits` mismatch. 575072105!=3842526231
SumScalar	120.813	2169.835
SumBcl	19.859	13200.520	6.083652
SumTraits	20.691	12669.509	5.838928
Sum128Traits	27.587	9502.356	4.379299
Sum256Traits	20.901	12542.414	5.780355

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12001033377966188484
Check-Sum128Traits	Check `Sum128Traits` mismatch. 12862679336949715101!=12001033377966188484
SumScalar	144.771	1810.749
SumBcl	248.971	1052.908	0.581476
SumTraits	82.371	3182.467	1.757541
Sum128Traits	112.433	2331.559	1.287621
Sum256Traits	81.405	3220.246	1.778405
Sum256Avx	79.647	3291.315	1.817654

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	342.381	765.649
SumBcl	68.388	3833.182	5.006446
SumTraits	68.815	3809.391	4.975372
Sum128Traits	591.957	442.843	0.578388
Sum256Traits	1112.700	235.593	0.307703

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	402.996	650.489
SumBcl	20.570	12744.213	19.591755
SumTraits	20.556	12752.871	19.605066
Sum128Traits	433.235	605.086	0.930202
Sum256Traits	428.804	611.338	0.939814

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	364.179	719.822
SumBcl	40.668	6445.950	8.954919
SumTraits	42.920	6107.703	8.485016
Sum128Traits	741.588	353.490	0.491080
Sum256Traits	756.437	346.551	0.481440

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	337.229	777.348
SumBcl	9.612	27273.217	35.084943
SumBcl_Widen	23.343	11230.083	14.446658
SumTraits	9.576	27374.533	35.215278
Sum128Traits	277.806	943.623	1.213900
Sum256Traits	294.822	889.161	1.143839

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	317.009	826.930
SumBcl	39.621	6616.223	8.000949
SumTraits	39.458	6643.543	8.033986
Sum128Traits	751.635	348.765	0.421759
Sum256Traits	751.444	348.854	0.421866

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	363.906	720.362
SumBcl	35.947	7292.554	10.123463
SumTraits	41.690	6288.001	8.728951
Sum128Traits	717.473	365.371	0.507206
Sum256Traits	761.242	344.363	0.478042

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	796.997	328.914
SumBcl	683.725	383.406	1.165670
SumTraits	683.456	383.557	1.166129
Sum128Traits	589.635	444.587	1.351680
Sum256Traits	1149.235	228.103	0.693502
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	342.211	766.031
SumBcl	68.580	3822.467	4.989966
SumTraits	80.625	3251.397	4.244474
Sum128Traits	68.951	3801.900	4.963117
Sum256Traits	636.699	411.723	0.537476

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	403.053	650.396
SumBcl	20.953	12510.831	19.235717
SumTraits	20.920	12530.809	19.266434
Sum128Traits	19.596	13377.421	20.568121
Sum256Traits	307.415	852.735	1.311102

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	363.984	720.207
SumBcl	43.807	5984.031	8.308766
SumTraits	40.672	6445.327	8.949271
Sum128Traits	42.774	6128.571	8.509458
Sum256Traits	477.553	548.932	0.762186

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	337.289	777.209
SumBcl	9.649	27168.474	34.956451
SumBcl_Widen	21.772	12040.382	15.491816
SumTraits	9.751	26883.131	34.589313
Sum128Traits	9.811	26719.062	34.378212
Sum256Traits	227.408	1152.747	1.483187

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	329.451	795.700
SumBcl	40.277	6508.489	8.179580
SumTraits	43.450	6033.227	7.582292
Sum128Traits	40.653	6448.404	8.104068
Sum256Traits	482.951	542.797	0.682163

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	363.368	721.428
SumBcl	35.992	7283.484	10.095933
SumTraits	41.934	6251.358	8.665261
Sum128Traits	35.956	7290.681	10.105909
Sum256Traits	475.226	551.620	0.764622

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	389.321	673.337
SumBcl	366.407	715.446	1.062538
SumTraits	229.721	1141.141	1.694755
Sum128Traits	229.453	1142.475	1.696736
Sum256Traits	668.973	391.860	0.581968
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	345.543	758.644
SumBcl	82.447	3179.536	4.191077
SumTraits	82.577	3174.551	4.184505
Sum128Traits	82.056	3194.693	4.211056
Sum256Traits	650.797	402.805	0.530953

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	407.597	643.146
SumBcl	21.215	12356.476	19.212559
SumTraits	19.947	13142.016	20.433963
Sum128Traits	21.429	12233.185	19.020861
Sum256Traits	311.343	841.979	1.309158

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	366.540	715.185
SumBcl	43.673	6002.410	8.392809
SumTraits	44.452	5897.187	8.245683
Sum128Traits	43.782	5987.449	8.371890
Sum256Traits	494.490	530.130	0.741249

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	339.734	771.615
SumBcl	10.079	26008.455	33.706513
SumBcl_Widen	21.715	12071.902	15.644978
SumTraits	9.981	26265.614	34.039786
Sum128Traits	10.056	26068.893	33.784839
Sum256Traits	229.472	1142.377	1.480501

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	320.956	816.759
SumBcl	41.183	6365.412	7.793498
SumTraits	40.986	6395.990	7.830937
Sum128Traits	44.026	5954.342	7.290204
Sum256Traits	502.493	521.687	0.638728

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	367.037	714.216
SumBcl	41.585	6303.880	8.826287
SumTraits	42.055	6233.388	8.727590
Sum128Traits	41.647	6294.362	8.812962
Sum256Traits	486.970	538.317	0.753717

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	391.753	669.157
SumBcl	267.893	978.539	1.462346
SumTraits	232.281	1128.562	1.686544
Sum128Traits	231.170	1133.990	1.694654
Sum256Traits	676.206	387.669	0.579339
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

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


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32672.199721873145
Check-SumBcl	Check `SumBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumTraits	Check `SumTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumScalar	258.489	1014.141
SumBcl	71.668	3657.731	3.606728
SumTraits	71.564	3663.085	3.612007
Sum128Traits	71.843	3648.868	3.597989
Sum256Traits	664.570	394.456	0.388956

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	19479
Check-Sum256Traits	Check `Sum256Traits` mismatch. -11701!=19479
SumScalar	257.577	1017.731
SumBcl	13.572	19315.192	18.978688
SumTraits	13.592	19287.033	18.951020
Sum128Traits	13.579	19305.500	18.969165
Sum256Traits	443.022	591.718	0.581409

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. -452441065!=575072105
SumScalar	184.943	1417.429
SumBcl	30.134	8699.250	6.137346
SumTraits	30.216	8675.644	6.120692
Sum128Traits	30.114	8704.930	6.141354
Sum256Traits	554.239	472.980	0.333689

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-113
Check-Sum256Traits	Check `Sum256Traits` mismatch. -41!=-113
SumScalar	221.666	1182.606
SumBcl	6.912	37928.181	32.071710
SumBcl_Widen	21.610	12130.527	10.257459
SumTraits	6.927	37845.492	32.001789
Sum128Traits	6.896	38012.278	32.142822
Sum256Traits	391.486	669.613	0.566219

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	32712.652
Check-SumBcl	Check `SumBcl` mismatch. 32712.596!=32712.652
Check-SumTraits	Check `SumTraits` mismatch. 32712.596!=32712.652
Check-Sum128Traits	Check `Sum128Traits` mismatch. 32712.596!=32712.652
Check-Sum256Traits	Check `Sum256Traits` mismatch. 32717.988!=32712.652
SumScalar	211.276	1240.768
SumBcl	30.680	8544.382	6.886364
SumTraits	30.535	8584.911	6.919028
Sum128Traits	30.499	8595.274	6.927380
Sum256Traits	498.383	525.989	0.423922

[MultiplyBenchmark_UInt32(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	575072105
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3842526231!=575072105
SumScalar	184.730	1419.062
SumBcl	38.044	6890.616	4.855753
SumTraits	37.971	6903.825	4.865062
Sum128Traits	38.035	6892.109	4.856806
Sum256Traits	557.371	470.323	0.331432

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	12862679336949715101
Check-Sum256Traits	Check `Sum256Traits` mismatch. 12001033377966188484!=12862679336949715101
SumScalar	237.072	1105.758
SumBcl	235.272	1114.218	1.007651
SumTraits	235.573	1112.795	1.006364
Sum128Traits	236.017	1110.700	1.004470
Sum256Traits	674.152	388.850	0.351659
Sum256Avx	Run fail! Requires hardware support Avx, Avx2!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !

```

