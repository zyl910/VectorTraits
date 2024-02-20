# Benchmark - Widen
([← Back](README.md))

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	176.091	1488.682
SumWidenBcl	49.668	5277.892	3.545346
SumWidenVectorBase	49.426	5303.791	3.562743
SumWidenVectorBase_NRef	345.664	758.378	0.509429
SumWidenVectorBase_NRef2	352.476	743.722	0.499584
SumWidenVectorBase_NRefInc	327.011	801.638	0.538488
SumWidenVectorBase_NRefInc2	354.553	739.365	0.496658
SumWidenVectorBase_Ref	433.083	605.298	0.406600
SumWidenVectorBase_Ref2	450.656	581.694	0.390745
SumWidenVectorBase_RefInc	417.299	628.192	0.421978
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	444.165	590.196	0.396455
SumWidenVectorBase256_Ref2	440.611	594.956	0.399653
SumWidenVectorBase256_RefI	450.524	581.864	0.390859
SumWidenVectorBase256_RefI2	429.787	609.939	0.409718
SumWidenVectorBase256_RefInc	398.827	657.288	0.441523
SumWidenVectorBase256_RefInc2	458.679	571.519	0.383910
SumWidenVectorTraits	94.219	2782.298	1.868968
SumWidenVectorTraits_Ptr	93.733	2796.704	1.878645

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	333.086	787.017
SumWidenBcl	17.595	14898.377	18.930195
SumWidenVectorBase	20.719	12652.168	16.076114
SumWidenVectorTraits	24.594	10658.810	13.543311
SumWidenVectorTraits_Ptr	22.349	11729.631	14.903918

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194
SumWidenScalar	413.158	634.488
SumWidenBcl	72.927	3594.591	5.665340
SumWidenVectorBase	80.868	3241.637	5.109059
SumWidenVectorTraits	68.474	3828.368	6.033789
SumWidenVectorTraits_Ptr	57.097	4591.236	7.236125

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	136.921	1914.571
SumWidenBcl	46.070	5690.177	2.972038
SumWidenVectorBase	46.033	5694.722	2.974412
SumWidenVectorBase_NRef	314.117	834.543	0.435891
SumWidenVectorBase_NRef2	325.029	806.525	0.421256
SumWidenVectorBase_NRefInc	303.695	863.181	0.450848
SumWidenVectorBase_NRefInc2	313.120	837.199	0.437278
SumWidenVectorBase_Ref	342.451	765.494	0.399825
SumWidenVectorBase_Ref2	333.376	786.332	0.410709
SumWidenVectorBase_RefInc	303.949	862.461	0.450472
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	285.383	918.569	0.479778
SumWidenVectorBase256_Ref2	285.188	919.197	0.480106
SumWidenVectorBase256_RefI	286.673	914.435	0.477619
SumWidenVectorBase256_RefI2	287.644	911.349	0.476007
SumWidenVectorBase256_RefInc	288.705	907.999	0.474257
SumWidenVectorBase256_RefInc2	296.124	885.249	0.462375
SumWidenVectorTraits	46.799	5601.481	2.925711
SumWidenVectorTraits_Ptr	46.042	5693.582	2.973816

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	163.549	1602.848
SumWidenBcl	10.812	24245.618	15.126585
SumWidenVectorBase	10.807	24257.284	15.133864
SumWidenVectorTraits	10.694	24512.905	15.293343
SumWidenVectorTraits_Ptr	10.686	24532.131	15.305338

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194
SumWidenScalar	312.076	840.000
SumWidenBcl	42.989	6098.000	7.259528
SumWidenVectorBase	43.725	5995.226	7.137177
SumWidenVectorTraits	42.979	6099.402	7.261197
SumWidenVectorTraits_Ptr	42.929	6106.502	7.269649

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	143.710	1824.120
SumWidenBcl	45.899	5711.283	3.130979
SumWidenVectorBase	46.042	5693.597	3.121283
SumWidenVectorBase_NRef	324.516	807.800	0.442844
SumWidenVectorBase_NRef2	333.585	785.839	0.430804
SumWidenVectorBase_NRefInc	314.685	833.035	0.456678
SumWidenVectorBase_NRefInc2	319.553	820.346	0.449721
SumWidenVectorBase_Ref	349.413	750.241	0.411289
SumWidenVectorBase_Ref2	340.572	769.718	0.421966
SumWidenVectorBase_RefInc	314.691	833.020	0.456670
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	304.991	859.514	0.471193
SumWidenVectorBase256_Ref2	305.852	857.095	0.469867
SumWidenVectorBase256_RefI	314.640	833.154	0.456743
SumWidenVectorBase256_RefI2	315.036	832.108	0.456170
SumWidenVectorBase256_RefInc	315.545	830.766	0.455434
SumWidenVectorBase256_RefInc2	315.228	831.602	0.455892
SumWidenVectorTraits	34.419	7616.240	4.175295
SumWidenVectorTraits_Ptr	34.520	7593.985	4.163094
SumWidenVector128Traits	55.772	4700.274	2.576734
SumWidenVector256Traits	34.774	7538.434	4.132640
SumWidenVector256Avx_ConvertTo	34.409	7618.521	4.176545
SumWidenVector256Avx_Unpack	45.492	5762.401	3.159002

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	163.530	1603.028
SumWidenBcl	10.845	24172.155	15.079055
SumWidenVectorBase	10.819	24228.986	15.114507
SumWidenVectorTraits	10.879	24097.252	15.032329
SumWidenVectorTraits_Ptr	10.846	24170.269	15.077878
SumWidenVector128Traits	13.373	19602.814	12.228612
SumWidenVector256Traits	7.671	34172.219	21.317288
SumWidenVector256Avx_ConvertTo	7.659	34226.865	21.351377
SumWidenVector256Avx_Unpack	10.894	24063.055	15.010996

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	310.895	843.191
SumWidenBcl	42.867	6115.246	7.252502
SumWidenVectorBase	43.008	6095.198	7.228726
SumWidenVectorTraits	42.316	6194.871	7.346935
SumWidenVectorTraits_Ptr	44.044	5951.918	7.058800
SumWidenVector128Traits	77.870	3366.437	3.992495
SumWidenVector256Traits	44.264	5922.261	7.023628

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	164.336	1595.172
SumWidenBcl	62.861	4170.211	2.614271
SumWidenVectorBase	94.242	2781.591	1.743757
SumWidenVectorBase_NRef	389.407	673.187	0.422016
SumWidenVectorBase_NRef2	413.634	633.759	0.397298
SumWidenVectorBase_NRefInc	298.230	878.999	0.551037
SumWidenVectorBase_NRefInc2	309.792	846.194	0.530472
SumWidenVectorBase_Ref	338.540	774.337	0.485426
SumWidenVectorBase_Ref2	327.019	801.616	0.502527
SumWidenVectorBase_RefInc	298.683	877.667	0.550202
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	260.755	1005.326	0.630231
SumWidenVectorBase256_Ref2	271.141	966.818	0.606090
SumWidenVectorBase256_RefI	272.028	963.666	0.604114
SumWidenVectorBase256_RefI2	278.009	942.934	0.591117
SumWidenVectorBase256_RefInc	283.627	924.255	0.579408
SumWidenVectorBase256_RefInc2	287.795	910.871	0.571017
SumWidenVectorTraits	34.411	7617.971	4.775643
SumWidenVectorTraits_Ptr	34.426	7614.725	4.773609
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	55.658	4709.869	2.952578
SumWidenVector256Traits	34.616	7572.857	4.747362
SumWidenVector256Avx_ConvertTo	34.445	7610.558	4.770996
SumWidenVector256Avx_Unpack	45.632	5744.760	3.601343

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	164.022	1598.229
SumWidenBcl	10.768	24344.085	15.231908
SumWidenVectorBase	10.789	24296.294	15.202006
SumWidenVectorTraits	10.903	24043.838	15.044046
SumWidenVectorTraits_Ptr	10.828	24208.835	15.147283
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	13.437	19509.404	12.206885
SumWidenVector256Traits	7.649	34273.834	21.444877
SumWidenVector256Avx_ConvertTo	7.665	34202.248	21.400086
SumWidenVector256Avx_Unpack	10.630	24661.423	15.430464

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	312.351	839.261
SumWidenBcl	42.808	6123.769	7.296618
SumWidenVectorBase	43.064	6087.328	7.253197
SumWidenVectorTraits	42.905	6109.801	7.279975
SumWidenVectorTraits_Ptr	43.487	6028.154	7.182690
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	77.660	3375.541	4.022039
SumWidenVector256Traits	42.855	6116.942	7.288483

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	137.263	1909.800
SumWidenBcl	46.123	5683.556	2.975996
SumWidenVectorBase	46.250	5668.000	2.967850
SumWidenVectorBase_NRef	313.159	837.096	0.438316
SumWidenVectorBase_NRef2	323.741	809.733	0.423988
SumWidenVectorBase_NRefInc	298.797	877.333	0.459385
SumWidenVectorBase_NRefInc2	309.800	846.171	0.443068
SumWidenVectorBase_Ref	339.454	772.252	0.404363
SumWidenVectorBase_Ref2	328.961	796.884	0.417260
SumWidenVectorBase_RefInc	299.414	875.525	0.458438
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	262.152	999.970	0.523600
SumWidenVectorBase256_Ref2	271.813	964.429	0.504989
SumWidenVectorBase256_RefI	272.478	962.075	0.503757
SumWidenVectorBase256_RefI2	278.653	940.756	0.492594
SumWidenVectorBase256_RefInc	282.543	927.801	0.485811
SumWidenVectorBase256_RefInc2	288.201	909.589	0.476274
SumWidenVectorTraits	34.587	7579.159	3.968562
SumWidenVectorTraits_Ptr	34.414	7617.416	3.988594
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	56.143	4669.189	2.444858
SumWidenVector256Traits	34.760	7541.495	3.948840
SumWidenVector256Avx_ConvertTo	34.320	7638.327	3.999543
SumWidenVector256Avx_Unpack	45.311	5785.389	3.029317

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	154.965	1691.638
SumWidenBcl	10.747	24391.974	14.419144
SumWidenVectorBase	10.775	24329.711	14.382338
SumWidenVectorTraits	10.758	24367.657	14.404769
SumWidenVectorTraits_Ptr	10.803	24265.151	14.344173
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	13.428	19522.882	11.540814
SumWidenVector256Traits	7.643	34299.718	20.276038
SumWidenVector256Avx_ConvertTo	7.620	34404.021	20.337695
SumWidenVector256Avx_Unpack	10.668	24572.602	14.525921

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	311.438	841.721
SumWidenBcl	42.867	6115.295	7.265230
SumWidenVectorBase	42.788	6126.545	7.278595
SumWidenVectorTraits	42.484	6170.394	7.330690
SumWidenVectorTraits_Ptr	43.057	6088.241	7.233088
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	77.678	3374.769	4.009369
SumWidenVector256Traits	43.546	6019.948	7.151953

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	154.997	1691.289
SumWidenBcl	32.135	8157.616	4.823314
SumWidenVectorBase	32.039	8181.966	4.837712
SumWidenVectorBase_NRef	286.576	914.744	0.540856
SumWidenVectorBase_NRef2	292.342	896.702	0.530189
SumWidenVectorBase_NRefInc	306.965	853.985	0.504932
SumWidenVectorBase_NRefInc2	315.553	830.746	0.491191
SumWidenVectorBase_Ref	309.569	846.803	0.500685
SumWidenVectorBase_Ref2	293.398	893.476	0.528281
SumWidenVectorBase_RefInc	306.308	855.817	0.506015
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	274.313	955.637	0.565035
SumWidenVectorBase256_Ref2	281.021	932.827	0.551548
SumWidenVectorBase256_RefI	278.846	940.102	0.555849
SumWidenVectorBase256_RefI2	286.850	913.873	0.540341
SumWidenVectorBase256_RefInc	288.038	910.103	0.538112
SumWidenVectorBase256_RefInc2	295.853	886.063	0.523898
SumWidenVectorTraits	32.051	8178.935	4.835920
SumWidenVectorTraits_Ptr	32.084	8170.439	4.830896
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	51.133	5126.681	3.031228
SumWidenVector256Traits	32.044	8180.761	4.836999
SumWidenVector256Avx_ConvertTo	32.064	8175.748	4.834035
SumWidenVector256Avx_Unpack	42.016	6239.180	3.689010

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	155.765	1682.945
SumWidenBcl	7.467	35108.612	20.861411
SumWidenVectorBase	7.462	35129.716	20.873951
SumWidenVectorTraits	7.481	35043.588	20.822774
SumWidenVectorTraits_Ptr	7.551	34715.131	20.627606
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	14.638	17908.484	10.641157
SumWidenVector256Traits	7.460	35140.634	20.880438
SumWidenVector256Avx_ConvertTo	7.461	35136.199	20.877803
SumWidenVector256Avx_Unpack	9.957	26326.472	15.643095

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	311.884	840.517
SumWidenBcl	42.801	6124.735	7.286869
SumWidenVectorBase	43.099	6082.314	7.236399
SumWidenVectorTraits	43.085	6084.322	7.238787
SumWidenVectorTraits_Ptr	42.902	6110.339	7.269742
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	77.586	3378.751	4.019849
SumWidenVector256Traits	42.879	6113.611	7.273635

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	350.673	747.545
SumWidenBcl	80.034	3275.413	4.381562
SumWidenVectorBase	74.290	3528.655	4.720327
SumWidenVectorBase_NPtr	553.162	473.901	0.633943
SumWidenVectorBase_NRef	487.909	537.281	0.718727
SumWidenVectorBase_NRef2	491.072	533.820	0.714098
SumWidenVectorBase_NRefInc	499.411	524.907	0.702174
SumWidenVectorBase_NRefInc2	499.274	525.050	0.702366
SumWidenVectorBase_Ptr	555.679	471.754	0.631072
SumWidenVectorBase_Ref	490.487	534.456	0.714949
SumWidenVectorBase_Ref2	491.527	533.326	0.713437
SumWidenVectorBase_RefInc	871.988	300.628	0.402154
SumWidenVectorBase128_Ptr	550.195	476.456	0.637362
SumWidenVectorBase128_Ref	493.607	531.078	0.710430
SumWidenVectorBase128_Ref2	496.819	527.645	0.705838
SumWidenVectorBase128_RefI	498.996	525.343	0.702758
SumWidenVectorBase128_RefI2	499.592	524.716	0.701919
SumWidenVectorBase128_RefInc	492.322	532.464	0.712284
SumWidenVectorBase128_RefInc2	491.067	533.825	0.714105
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	74.268	3529.716	4.721746
SumWidenVectorTraits_Ptr	74.211	3532.433	4.725380
SumWidenVector128Traits	1173.705	223.347	0.298775
SumWidenVector256Traits	1368.411	191.568	0.256263

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	341.282	768.115
SumWidenBcl	18.274	14345.430	18.676154
SumWidenVectorBase	18.289	14333.083	18.660080
SumWidenVectorTraits	19.830	13219.564	17.210401
SumWidenVectorTraits_Ptr	19.849	13207.038	17.194095
SumWidenVector128Traits	589.657	444.570	0.578781
SumWidenVector256Traits	538.768	486.562	0.633450

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	291.126	900.448
SumWidenBcl	80.402	3260.421	3.620886
SumWidenVectorBase	80.575	3253.398	3.613087
SumWidenVectorTraits	80.437	3259.004	3.619313
SumWidenVectorTraits_Ptr	74.780	3505.519	3.893082
SumWidenVector128Traits	1308.674	200.313	0.222459
SumWidenVector256Traits	1391.062	188.449	0.209283

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	349.356	750.363
SumWidenBcl	83.996	3120.909	4.159198
SumWidenVectorBase	75.855	3455.858	4.605581
SumWidenVectorBase_NPtr	538.688	486.634	0.648532
SumWidenVectorBase_NRef	492.923	531.815	0.708744
SumWidenVectorBase_NRef2	497.116	527.330	0.702766
SumWidenVectorBase_NRefInc	512.768	511.233	0.681314
SumWidenVectorBase_NRefInc2	503.681	520.456	0.693606
SumWidenVectorBase_Ptr	542.737	483.004	0.643694
SumWidenVectorBase_Ref	493.280	531.430	0.708231
SumWidenVectorBase_Ref2	494.127	530.519	0.707016
SumWidenVectorBase_RefInc	511.617	512.384	0.682848
SumWidenVectorBase128_Ptr	545.258	480.771	0.640718
SumWidenVectorBase128_Ref	518.002	506.068	0.674431
SumWidenVectorBase128_Ref2	515.241	508.779	0.678044
SumWidenVectorBase128_RefI	513.844	510.162	0.679887
SumWidenVectorBase128_RefI2	512.260	511.740	0.681990
SumWidenVectorBase128_RefInc	509.427	514.586	0.685783
SumWidenVectorBase128_RefInc2	503.434	520.712	0.693947
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	84.107	3116.778	4.153693
SumWidenVectorTraits_Ptr	76.013	3448.677	4.596010
SumWidenVector128_AdvSimd	88.228	2971.200	3.959682
SumWidenVector128Traits	88.093	2975.763	3.965765
SumWidenVector256Traits	854.042	306.945	0.409062

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	352.812	743.012
SumWidenBcl	20.848	12573.830	16.922777
SumWidenVectorBase	21.189	12371.942	16.651061
SumWidenVectorTraits	18.702	14017.035	18.865146
SumWidenVectorTraits_Ptr	20.149	13009.998	17.509803
SumWidenVector128_AdvSimd	21.900	11970.238	16.110418
SumWidenVector128Traits	21.643	12112.350	16.301683
SumWidenVector256Traits	409.297	640.474	0.861997

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	290.752	901.608
SumWidenBcl	76.838	3411.624	3.783933
SumWidenVectorBase	76.879	3409.835	3.781949
SumWidenVectorTraits	83.139	3153.065	3.497157
SumWidenVectorTraits_Ptr	76.478	3427.690	3.801752
SumWidenVector128_AdvSimd	647.481	404.867	0.449050
SumWidenVector128_AdvSimdB64	90.509	2896.346	3.212423
SumWidenVector128Traits	89.158	2940.233	3.261099
SumWidenVector256Traits	892.728	293.644	0.325689

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	349.740	749.539
SumWidenBcl	84.100	3117.056	4.158632
SumWidenVectorBase	76.598	3422.325	4.565909
SumWidenVectorBase_NPtr	545.671	480.407	0.640937
SumWidenVectorBase_NRef	493.133	531.589	0.709222
SumWidenVectorBase_NRef2	706.852	370.861	0.494786
SumWidenVectorBase_NRefInc	513.335	510.669	0.681311
SumWidenVectorBase_NRefInc2	506.059	518.011	0.691107
SumWidenVectorBase_Ptr	545.640	480.434	0.640973
SumWidenVectorBase_Ref	494.422	530.203	0.707373
SumWidenVectorBase_Ref2	495.792	528.738	0.705418
SumWidenVectorBase_RefInc	513.797	510.209	0.680697
SumWidenVectorBase128_Ptr	538.760	486.569	0.649158
SumWidenVectorBase128_Ref	519.501	504.607	0.673224
SumWidenVectorBase128_Ref2	519.161	504.938	0.673665
SumWidenVectorBase128_RefI	515.641	508.385	0.678264
SumWidenVectorBase128_RefI2	511.220	512.782	0.684130
SumWidenVectorBase128_RefInc	509.043	514.974	0.687055
SumWidenVectorBase128_RefInc2	499.097	525.236	0.700746
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	76.616	3421.535	4.564854
SumWidenVectorTraits_Ptr	84.803	3091.220	4.124164
SumWidenVector128_AdvSimd	88.431	2964.398	3.954963
SumWidenVector128Traits	88.071	2976.512	3.971126
SumWidenVector256Traits	858.303	305.421	0.407479

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	309.364	847.364
SumWidenBcl	18.680	14033.774	16.561687
SumWidenVectorBase	20.875	12557.837	14.819889
SumWidenVectorTraits	18.691	14024.904	16.551220
SumWidenVectorTraits_Ptr	18.898	13871.441	16.370114
SumWidenVector128_AdvSimd	21.812	12018.280	14.183141
SumWidenVector128Traits	21.851	11996.728	14.157707
SumWidenVector256Traits	409.674	639.884	0.755147

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	316.753	827.598
SumWidenBcl	76.679	3418.702	4.130874
SumWidenVectorBase	83.013	3157.879	3.815717
SumWidenVectorTraits	83.883	3125.112	3.776124
SumWidenVectorTraits_Ptr	77.160	3397.429	4.105169
SumWidenVector128_AdvSimd	649.231	403.776	0.487889
SumWidenVector128_AdvSimdB64	89.950	2914.340	3.521445
SumWidenVector128Traits	89.557	2927.117	3.536883
SumWidenVector256Traits	893.955	293.241	0.354327

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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	210.988	1242.461
SumWidenBcl	69.633	3764.642	3.029987
SumWidenVectorBase	69.652	3763.612	3.029158
SumWidenVectorBase_NPtr	694.587	377.410	0.303760
SumWidenVectorBase_NRef	707.146	370.707	0.298365
SumWidenVectorBase_NRef2	477.128	549.421	0.442204
SumWidenVectorBase_NRefInc	480.178	545.930	0.439394
SumWidenVectorBase_NRefInc2	480.847	545.171	0.438783
SumWidenVectorBase_Ptr	480.263	545.834	0.439317
SumWidenVectorBase_Ref	625.166	419.319	0.337490
SumWidenVectorBase_Ref2	475.495	551.308	0.443722
SumWidenVectorBase_RefInc	480.217	545.887	0.439359
SumWidenVectorBase128_Ptr	491.045	533.849	0.429670
SumWidenVectorBase128_Ref	491.789	533.041	0.429021
SumWidenVectorBase128_Ref2	490.784	534.133	0.429899
SumWidenVectorBase128_RefI	488.859	536.236	0.431592
SumWidenVectorBase128_RefI2	489.379	535.667	0.431134
SumWidenVectorBase128_RefInc	487.674	537.539	0.432640
SumWidenVectorBase128_RefInc2	486.533	538.800	0.433655
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	69.519	3770.815	3.034956
SumWidenVectorTraits_Ptr	69.663	3763.011	3.028675
SumWidenVector128_AdvSimd	69.797	3755.802	3.022872
SumWidenVector128Traits	69.894	3750.581	3.018670
SumWidenVector256Traits	2305.560	113.701	0.091513

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	215.225	1218.001
SumWidenBcl	17.111	15320.446	12.578356
SumWidenVectorBase	17.264	15184.279	12.466561
SumWidenVectorTraits	17.118	15314.270	12.573285
SumWidenVectorTraits_Ptr	16.914	15498.275	12.724357
SumWidenVector128_AdvSimd	17.031	15392.120	12.637202
SumWidenVector128Traits	17.156	15280.250	12.545355
SumWidenVector256Traits	1534.270	170.859	0.140278

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	211.092	1241.846
SumWidenBcl	73.359	3573.416	2.877502
SumWidenVectorBase	73.413	3570.790	2.875388
SumWidenVectorTraits	73.414	3570.762	2.875365
SumWidenVectorTraits_Ptr	73.405	3571.221	2.875735
SumWidenVector128_AdvSimd	433.601	604.574	0.486834
SumWidenVector128_AdvSimdB64	73.270	3577.799	2.881031
SumWidenVector128Traits	73.229	3579.760	2.882611
SumWidenVector256Traits	2449.326	107.027	0.086184

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

