# Benchmark - Multiply
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 4.5

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.4614.0
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.6184711382
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.6184711381!=32712.6184711382
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.6184711381!=32712.6184711382
SumMultiplyScalar	162.527	1612.928
SumMultiplyBcl	42.258	6203.448	3.846079
SumMultiplyVectorTraits	41.285	6349.673	3.936737

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
SumMultiplyScalar	156.781	1672.036
SumMultiplyBcl	9.456	27723.674	16.580791
SumMultiplyVectorTraits	9.321	28123.490	16.819910

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
SumMultiplyScalar	133.016	1970.772
SumMultiplyBcl	18.640	14063.846	7.136212
SumMultiplyVectorTraits	18.711	14010.361	7.109073

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
SumMultiplyScalar	156.080	1679.551
SumMultiplyBcl	232.688	1126.591	0.670770
SumMultiplyBcl_Widen	318.064	824.186	0.490718
SumMultiplyVectorTraits	231.809	1130.862	0.673312

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.88
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.99!=32717.88
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.99!=32717.88
SumMultiplyScalar	156.284	1677.353
SumMultiplyBcl	20.251	12944.886	7.717447
SumMultiplyVectorTraits	19.985	13117.304	7.820238

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
SumMultiplyScalar	144.083	1819.396
SumMultiplyBcl	825.320	317.627	0.174578
SumMultiplyVectorTraits	817.066	320.836	0.176342

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.6184711382
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.6184711381!=32712.6184711382
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.6184711381!=32712.6184711382
SumMultiplyScalar	159.354	1645.039
SumMultiplyBcl	40.915	6406.962	3.894716
SumMultiplyVectorTraits	41.230	6358.129	3.865032

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
SumMultiplyScalar	156.726	1672.622
SumMultiplyBcl	9.480	27651.485	16.531817
SumMultiplyVectorTraits	9.413	27848.337	16.649508

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
SumMultiplyScalar	130.484	2009.018
SumMultiplyBcl	19.789	13246.692	6.593616
SumMultiplyVectorTraits	20.104	13039.200	6.490336

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
SumMultiplyScalar	160.740	1630.857
SumMultiplyBcl	203.859	1285.908	0.788486
SumMultiplyBcl_Widen	260.657	1005.706	0.616674
SumMultiplyVectorTraits	204.076	1284.541	0.787648

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.88
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.99!=32717.88
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.99!=32717.88
SumMultiplyScalar	159.377	1644.803
SumMultiplyBcl	20.223	12962.610	7.880951
SumMultiplyVectorTraits	20.349	12882.324	7.832139

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
SumMultiplyScalar	144.646	1812.316
SumMultiplyBcl	518.060	506.011	0.279207
SumMultiplyVectorTraits	510.100	513.907	0.283564

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.618471138187
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumMultiplyScalar	163.880	1599.607
SumMultiplyBcl	42.152	6219.025	3.887846
SumMultiplyVectorTraits	40.582	6459.570	4.038224
SumMultiplyVector128Traits	858.902	305.208	0.190802
SumMultiplyVector256Traits	42.376	6186.113	3.867271

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 19479!=-11701
SumMultiplyScalar	155.989	1680.525
SumMultiplyBcl	9.207	28471.121	16.941800
SumMultiplyVectorTraits	9.323	28118.577	16.732018
SumMultiplyVector128Traits	282.273	928.690	0.552619
SumMultiplyVector256Traits	9.476	27664.570	16.461860

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 575072105!=-452441065
SumMultiplyScalar	143.765	1823.420
SumMultiplyBcl	19.203	13651.349	7.486674
SumMultiplyVectorTraits	20.918	12531.695	6.872633
SumMultiplyVector128Traits	479.465	546.743	0.299845
SumMultiplyVector256Traits	21.288	12314.283	6.753400

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! -113!=-41
SumMultiplyScalar	155.411	1686.776
SumMultiplyBcl	214.360	1222.915	0.725001
SumMultiplyBcl_Widen	262.035	1000.416	0.593093
SumMultiplyVectorTraits	18.137	14453.758	8.568864
SumMultiplyVector128Traits	188.431	1391.196	0.824766
SumMultiplyVector256Traits	10.468	25041.314	14.845663

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.883
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.988!=32717.883
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.988!=32717.883
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32717.883
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32717.883
SumMultiplyScalar	156.953	1670.210
SumMultiplyBcl	19.906	13169.059	7.884671
SumMultiplyVectorTraits	20.744	12636.923	7.566067
SumMultiplyVector128Traits	470.306	557.390	0.333724
SumMultiplyVector256Traits	22.152	11833.716	7.085166

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 12862679336949715101!=12001033377966188484
SumMultiplyScalar	158.925	1649.482
SumMultiplyBcl	524.311	499.978	0.303112
SumMultiplyVectorTraits	86.491	3030.896	1.837484
SumMultiplyVector128Traits	807.684	324.563	0.196766
SumMultiplyVector256Traits	84.148	3115.292	1.888649
SumMultiplyVector256Avx	84.554	3100.312	1.879567

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 5

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.618471138187
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumMultiplyScalar	162.322	1614.967
SumMultiplyBcl	51.433	5096.785	3.155968
SumMultiplyVectorTraits	47.011	5576.244	3.452853
SumMultiplyVector128Traits	844.940	310.251	0.192110
SumMultiplyVector256Traits	40.306	6503.870	4.027246

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 19479!=-11701
SumMultiplyScalar	156.555	1674.452
SumMultiplyBcl	9.152	28641.826	17.105197
SumMultiplyVectorTraits	9.131	28709.758	17.145766
SumMultiplyVector128Traits	278.741	940.456	0.561650
SumMultiplyVector256Traits	9.136	28692.611	17.135526

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 575072105!=-452441065
SumMultiplyScalar	131.875	1987.816
SumMultiplyBcl	19.466	13466.942	6.774742
SumMultiplyVectorTraits	20.090	13048.799	6.564389
SumMultiplyVector128Traits	433.051	605.341	0.304526
SumMultiplyVector256Traits	18.699	14019.239	7.052583

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! -113!=-41
SumMultiplyScalar	166.726	1572.304
SumMultiplyBcl	192.531	1361.570	0.865971
SumMultiplyBcl_Widen	193.983	1351.375	0.859488
SumMultiplyVectorTraits	17.866	14673.051	9.332199
SumMultiplyVector128Traits	185.228	1415.251	0.900113
SumMultiplyVector256Traits	10.358	25308.103	16.096192

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.883
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.988!=32717.883
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.988!=32717.883
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32717.883
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32717.883
SumMultiplyScalar	227.096	1154.329
SumMultiplyBcl	34.597	7577.173	6.564137
SumMultiplyVectorTraits	26.982	9715.442	8.416529
SumMultiplyVector128Traits	474.644	552.296	0.478457
SumMultiplyVector256Traits	21.859	11992.426	10.389090

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 12862679336949715101!=12001033377966188484
SumMultiplyScalar	151.221	1733.518
SumMultiplyBcl	685.102	382.635	0.220727
SumMultiplyVectorTraits	73.405	3571.204	2.060091
SumMultiplyVector128Traits	796.860	328.971	0.189771
SumMultiplyVector256Traits	71.479	3667.418	2.115593
SumMultiplyVector256Avx	72.038	3638.966	2.099180

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 6

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.618471138187
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumMultiplyScalar	159.440	1644.158
SumMultiplyBcl	44.793	5852.340	3.559475
SumMultiplyVectorTraits	40.011	6551.731	3.984854
SumMultiplyVector128Traits	838.270	312.720	0.190201
SumMultiplyVector256Traits	40.050	6545.499	3.981063

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 19479!=-11701
SumMultiplyScalar	150.297	1744.177
SumMultiplyBcl	9.836	26650.639	15.279782
SumMultiplyVectorTraits	9.825	26680.685	15.297008
SumMultiplyVector128Traits	277.516	944.607	0.541578
SumMultiplyVector256Traits	9.213	28452.295	16.312736

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 575072105!=-452441065
SumMultiplyScalar	131.359	1995.634
SumMultiplyBcl	18.681	14032.470	7.031586
SumMultiplyVectorTraits	18.664	14045.535	7.038133
SumMultiplyVector128Traits	433.079	605.303	0.303314
SumMultiplyVector256Traits	21.940	11948.114	5.987127

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! -113!=-41
SumMultiplyScalar	160.458	1633.722
SumMultiplyBcl	135.503	1934.596	1.184164
SumMultiplyBcl_Widen	18.038	14533.276	8.895806
SumMultiplyVectorTraits	17.941	14611.751	8.943840
SumMultiplyVector128Traits	183.150	1431.309	0.876103
SumMultiplyVector256Traits	10.435	25121.684	15.376962

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.883
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.988!=32717.883
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.988!=32717.883
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32717.883
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32717.883
SumMultiplyScalar	157.989	1659.254
SumMultiplyBcl	20.563	12748.296	7.683148
SumMultiplyVectorTraits	21.823	12012.049	7.239426
SumMultiplyVector128Traits	459.425	570.592	0.343885
SumMultiplyVector256Traits	19.585	13385.223	8.067011

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 12862679336949715101!=12001033377966188484
SumMultiplyScalar	142.817	1835.528
SumMultiplyBcl	279.018	939.525	0.511855
SumMultiplyVectorTraits	69.869	3751.930	2.044060
SumMultiplyVector128Traits	787.434	332.909	0.181370
SumMultiplyVector256Traits	129.352	2026.596	1.104094
SumMultiplyVector256Avx	140.805	1861.752	1.014287

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 7

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
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.618471138187
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.618471138107!=32712.618471138187
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.618471138107!=32712.618471138187
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32712.618471138187
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32712.618471138187
SumMultiplyScalar	158.054	1658.569
SumMultiplyBcl	40.109	6535.871	3.940670
SumMultiplyVectorTraits	40.749	6433.190	3.878760
SumMultiplyVector128Traits	79.637	3291.724	1.984677
SumMultiplyVector256Traits	41.076	6381.991	3.847890

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-11701
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 19479!=-11701
SumMultiplyScalar	145.873	1797.074
SumMultiplyBcl	9.011	29090.206	16.187542
SumMultiplyVectorTraits	9.366	27988.810	15.574659
SumMultiplyVector128Traits	13.396	19568.921	10.889326
SumMultiplyVector256Traits	9.020	29062.563	16.172160

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-452441065
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 575072105!=-452441065
SumMultiplyScalar	121.159	2163.632
SumMultiplyBcl	20.662	12687.343	5.863910
SumMultiplyVectorTraits	20.724	12649.399	5.846373
SumMultiplyVector128Traits	27.100	9673.360	4.470890
SumMultiplyVector256Traits	19.124	13707.771	6.335538

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-41
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! -113!=-41
SumMultiplyScalar	141.837	1848.211
SumMultiplyBcl	131.816	1988.709	1.076018
SumMultiplyBcl_Widen	10.099	25958.595	14.045254
SumMultiplyVectorTraits	10.112	25924.751	14.026942
SumMultiplyVector128Traits	155.109	1690.064	0.914432
SumMultiplyVector256Traits	10.137	25861.260	13.992589

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32717.883
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32717.988!=32717.883
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32717.988!=32717.883
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32717.883
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32717.883
SumMultiplyScalar	156.242	1677.803
SumMultiplyBcl	19.593	13379.792	7.974590
SumMultiplyVectorTraits	19.586	13384.229	7.977234
SumMultiplyVector128Traits	38.992	6723.024	4.007039
SumMultiplyVector256Traits	19.611	13366.906	7.966909

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12001033377966188484
Check-SumMultiplyVector128Traits	Fail! Check `SumMultiplyVector128Traits` fail! 12862679336949715101!=12001033377966188484
SumMultiplyScalar	141.000	1859.174
SumMultiplyBcl	263.626	994.380	0.534851
SumMultiplyVectorTraits	80.759	3245.992	1.745932
SumMultiplyVector128Traits	406.977	644.125	0.346458
SumMultiplyVector256Traits	80.639	3250.851	1.748546
SumMultiplyVector256Avx	80.592	3252.710	1.749546

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
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	3.1.31
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.31
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32672.199721873145
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumMultiplyScalar	342.262	765.917
SumMultiplyBcl	77.515	3381.840	4.415412
SumMultiplyVectorTraits	77.448	3384.778	4.419248
SumMultiplyVector128Traits	608.232	430.994	0.562716
SumMultiplyVector256Traits	1093.677	239.690	0.312946

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	19479
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -11701!=19479
SumMultiplyScalar	404.274	648.431
SumMultiplyBcl	20.111	13034.645	20.101825
SumMultiplyVectorTraits	20.094	13046.190	20.119629
SumMultiplyVector128Traits	428.063	612.396	0.944427
SumMultiplyVector256Traits	405.753	646.067	0.996355

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	575072105
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -452441065!=575072105
SumMultiplyScalar	365.263	717.686
SumMultiplyBcl	42.212	6210.249	8.653151
SumMultiplyVectorTraits	42.260	6203.062	8.643138
SumMultiplyVector128Traits	723.593	362.281	0.504790
SumMultiplyVector256Traits	708.426	370.037	0.515597

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-113
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -41!=-113
SumMultiplyScalar	337.840	775.941
SumMultiplyBcl	8.478	30921.148	39.849853
SumMultiplyBcl_Widen	22.049	11888.962	15.321986
SumMultiplyVectorTraits	8.482	30904.194	39.828003
SumMultiplyVector128Traits	258.737	1013.169	1.305729
SumMultiplyVector256Traits	272.866	960.707	1.238118

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.652
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.596!=32712.652
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32712.652
SumMultiplyScalar	329.679	795.149
SumMultiplyBcl	36.259	7229.844	9.092439
SumMultiplyVectorTraits	36.257	7230.116	9.092781
SumMultiplyVector128Traits	739.126	354.668	0.446039
SumMultiplyVector256Traits	714.913	366.680	0.461146

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12862679336949715101
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! 12001033377966188484!=12862679336949715101
SumMultiplyScalar	388.901	674.064
SumMultiplyBcl	666.442	393.349	0.583548
SumMultiplyVectorTraits	668.516	392.128	0.581737
SumMultiplyVector128Traits	598.213	438.212	0.650104
SumMultiplyVector256Traits	1128.631	232.267	0.344578
SumMultiplyVector256Avx	Run fail! Requires hardware support Avx, Avx2!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 5

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32672.199721873145
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumMultiplyScalar	342.096	766.287
SumMultiplyBcl	68.464	3828.957	4.996768
SumMultiplyVectorTraits	68.718	3814.761	4.978243
SumMultiplyVector128Traits	80.023	3275.869	4.274991
SumMultiplyVector256Traits	576.807	454.474	0.593086

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	19479
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -11701!=19479
SumMultiplyScalar	402.487	651.310
SumMultiplyBcl	20.473	12804.108	19.659004
SumMultiplyVectorTraits	20.489	12794.538	19.644310
SumMultiplyVector128Traits	19.324	13565.862	20.828576
SumMultiplyVector256Traits	295.153	888.164	1.363658

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	575072105
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -452441065!=575072105
SumMultiplyScalar	364.075	720.027
SumMultiplyBcl	40.508	6471.335	8.987627
SumMultiplyVectorTraits	40.339	6498.464	9.025305
SumMultiplyVector128Traits	43.587	6014.284	8.352857
SumMultiplyVector256Traits	448.734	584.185	0.811338

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-113
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -41!=-113
SumMultiplyScalar	337.262	777.272
SumMultiplyBcl	9.700	27024.719	34.768687
SumMultiplyBcl_Widen	21.811	12018.738	15.462722
SumMultiplyVectorTraits	9.694	27041.556	34.790349
SumMultiplyVector128Traits	9.917	26434.208	34.008964
SumMultiplyVector256Traits	221.420	1183.921	1.523176

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.652
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.596!=32712.652
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32712.652
SumMultiplyScalar	330.468	793.251
SumMultiplyBcl	40.320	6501.557	8.196091
SumMultiplyVectorTraits	40.362	6494.794	8.187565
SumMultiplyVector128Traits	40.422	6485.243	8.175526
SumMultiplyVector256Traits	451.632	580.438	0.731720

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12862679336949715101
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! 12001033377966188484!=12862679336949715101
SumMultiplyScalar	388.716	674.385
SumMultiplyBcl	315.590	830.647	1.231711
SumMultiplyVectorTraits	321.855	814.479	1.207736
SumMultiplyVector128Traits	233.063	1124.776	1.667856
SumMultiplyVector256Traits	607.011	431.860	0.640377
SumMultiplyVector256Avx	Run fail! Requires hardware support Avx, Avx2!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 6

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	6.0.11
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/
RuntimeInformation.FrameworkDescription:	.NET 6.0.11
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32672.199721873145
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumMultiplyScalar	342.675	764.993
SumMultiplyBcl	68.902	3804.582	4.973357
SumMultiplyVectorTraits	81.166	3229.723	4.221900
SumMultiplyVector128Traits	68.751	3812.952	4.984297
SumMultiplyVector256Traits	578.833	452.883	0.592010

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	19479
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -11701!=19479
SumMultiplyScalar	403.968	648.923
SumMultiplyBcl	20.986	12491.657	19.249815
SumMultiplyVectorTraits	21.004	12480.957	19.233326
SumMultiplyVector128Traits	20.685	12673.325	19.529769
SumMultiplyVector256Traits	295.430	887.329	1.367387

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	575072105
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -452441065!=575072105
SumMultiplyScalar	364.427	719.333
SumMultiplyBcl	41.110	6376.593	8.864596
SumMultiplyVectorTraits	41.474	6320.717	8.786918
SumMultiplyVector128Traits	41.214	6360.600	8.842362
SumMultiplyVector256Traits	452.043	579.910	0.806178

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-113
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -41!=-113
SumMultiplyScalar	337.295	777.194
SumMultiplyBcl	9.770	26832.826	34.525242
SumMultiplyBcl_Widen	21.344	12281.754	15.802679
SumMultiplyVectorTraits	9.708	27002.372	34.743393
SumMultiplyVector128Traits	9.749	26888.408	34.596759
SumMultiplyVector256Traits	221.269	1184.732	1.524370

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.652
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.596!=32712.652
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32712.652
SumMultiplyScalar	317.444	825.797
SumMultiplyBcl	43.184	6070.420	7.350981
SumMultiplyVectorTraits	43.084	6084.449	7.367969
SumMultiplyVector128Traits	44.303	5917.094	7.165311
SumMultiplyVector256Traits	456.124	574.721	0.695959

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12862679336949715101
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! 12001033377966188484!=12862679336949715101
SumMultiplyScalar	389.064	673.782
SumMultiplyBcl	266.010	985.468	1.462592
SumMultiplyVectorTraits	265.084	988.908	1.467697
SumMultiplyVector128Traits	231.115	1134.260	1.683423
SumMultiplyVector256Traits	609.361	430.195	0.638478
SumMultiplyVector256Avx	Run fail! Requires hardware support Avx, Avx2!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 7

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	7.0.1
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/
RuntimeInformation.FrameworkDescription:	.NET 7.0.1
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[MultiplyBenchmark_Double(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32672.199721873145
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32672.19972187258!=32672.199721873145
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32712.618471138107!=32672.199721873145
SumMultiplyScalar	237.179	1105.260
SumMultiplyBcl	71.634	3659.470	3.310958
SumMultiplyVectorTraits	72.282	3626.679	3.281290
SumMultiplyVector128Traits	72.580	3611.810	3.267837
SumMultiplyVector256Traits	659.373	397.566	0.359703

[MultiplyBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	19479
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -11701!=19479
SumMultiplyScalar	258.451	1014.287
SumMultiplyBcl	13.765	19044.697	18.776431
SumMultiplyVectorTraits	13.719	19108.256	18.839094
SumMultiplyVector128Traits	13.715	19112.976	18.843748
SumMultiplyVector256Traits	444.028	590.377	0.582060

[MultiplyBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	575072105
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -452441065!=575072105
SumMultiplyScalar	184.635	1419.799
SumMultiplyBcl	29.894	8768.983	6.176217
SumMultiplyVectorTraits	30.125	8701.963	6.129012
SumMultiplyVector128Traits	29.937	8756.661	6.167538
SumMultiplyVector256Traits	558.334	469.511	0.330688

[MultiplyBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	-113
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! -41!=-113
SumMultiplyScalar	222.669	1177.282
SumMultiplyBcl	6.912	37927.645	32.216286
SumMultiplyBcl_Widen	21.794	12028.472	10.217157
SumMultiplyVectorTraits	6.906	37958.061	32.242123
SumMultiplyVector128Traits	6.926	37849.082	32.149554
SumMultiplyVector256Traits	396.575	661.020	0.561480

[MultiplyBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	32712.652
Check-SumMultiplyBcl	Check `SumMultiplyBcl` mismatch. 32712.596!=32712.652
Check-SumMultiplyVectorTraits	Check `SumMultiplyVectorTraits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector128Traits	Check `SumMultiplyVector128Traits` mismatch. 32712.596!=32712.652
Check-SumMultiplyVector256Traits	Check `SumMultiplyVector256Traits` mismatch. 32717.988!=32712.652
SumMultiplyScalar	213.465	1228.043
SumMultiplyBcl	30.863	8493.877	6.916596
SumMultiplyVectorTraits	30.782	8516.256	6.934820
SumMultiplyVector128Traits	30.837	8500.831	6.922259
SumMultiplyVector256Traits	498.258	526.121	0.428422

[MultiplyBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumMultiplyScalar	12862679336949715101
Check-SumMultiplyVector256Traits	Fail! Check `SumMultiplyVector256Traits` fail! 12001033377966188484!=12862679336949715101
SumMultiplyScalar	239.789	1093.229
SumMultiplyBcl	234.986	1115.574	1.020440
SumMultiplyVectorTraits	235.532	1112.987	1.018073
SumMultiplyVector128Traits	234.555	1117.625	1.022316
SumMultiplyVector256Traits	675.829	387.885	0.354807
SumMultiplyVector256Avx	Run fail! Requires hardware support Avx, Avx2!

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

