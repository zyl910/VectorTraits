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
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	350.049	748.878
SumWidenBcl	83.185	3151.349	4.208093
SumWidenVectorBase	84.400	3105.972	4.147500
SumWidenVectorBase_NRef	496.707	527.763	0.704739
SumWidenVectorBase_NRef2	499.253	525.073	0.701146
SumWidenVectorBase_NRefInc	514.406	509.606	0.680492
SumWidenVectorBase_NRefInc2	513.420	510.584	0.681799
SumWidenVectorBase_Ref	499.541	524.769	0.700741
SumWidenVectorBase_Ref2	499.021	525.317	0.701471
SumWidenVectorBase_RefInc	515.252	508.769	0.679375
SumWidenVectorBase128_Ref	502.224	521.967	0.696998
SumWidenVectorBase128_Ref2	503.611	520.529	0.695078
SumWidenVectorBase128_RefI	513.262	510.741	0.682008
SumWidenVectorBase128_RefI2	510.519	513.485	0.685672
SumWidenVectorBase128_RefInc	506.444	517.616	0.691189
SumWidenVectorBase128_RefInc2	498.130	526.256	0.702726
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	83.362	3144.652	4.199150
SumWidenVectorTraits_Ptr	80.971	3237.486	4.323114
SumWidenVector128Traits	1168.993	224.248	0.299445
SumWidenVector256Traits	1486.089	176.399	0.235550
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	353.666	741.218
SumWidenBcl	20.990	12488.862	16.849099
SumWidenVectorBase	20.823	12589.170	16.984427
SumWidenVectorTraits	19.220	13639.421	18.401352
SumWidenVectorTraits_Ptr	18.698	14019.956	18.914744
SumWidenVector128Traits	601.681	435.686	0.587797
SumWidenVector256Traits	588.251	445.633	0.601217
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	290.023	903.872
SumWidenBcl	82.702	3169.730	3.506835
SumWidenVectorBase	76.056	3446.735	3.813299
SumWidenVectorTraits	75.925	3452.662	3.819856
SumWidenVectorTraits_Ptr	80.958	3238.042	3.582411
SumWidenVector128Traits	1316.641	199.101	0.220275
SumWidenVector256Traits	1497.089	175.103	0.193725

```

#### .NET 5.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	351.204	746.414
SumWidenBcl	84.395	3106.144	4.161421
SumWidenVectorBase	82.983	3159.025	4.232268
SumWidenVectorBase_NRef	762.268	343.900	0.460736
SumWidenVectorBase_NRef2	497.805	526.600	0.705507
SumWidenVectorBase_NRefInc	513.082	510.920	0.684500
SumWidenVectorBase_NRefInc2	506.626	517.431	0.693222
SumWidenVectorBase_Ref	493.730	530.946	0.711329
SumWidenVectorBase_Ref2	495.004	529.580	0.709499
SumWidenVectorBase_RefInc	512.581	511.420	0.685169
SumWidenVectorBase128_Ref	515.816	508.212	0.680872
SumWidenVectorBase128_Ref2	514.247	509.762	0.682948
SumWidenVectorBase128_RefI	512.897	511.105	0.684747
SumWidenVectorBase128_RefI2	508.806	515.214	0.690252
SumWidenVectorBase128_RefInc	507.942	516.091	0.691427
SumWidenVectorBase128_RefInc2	502.031	522.167	0.699568
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	81.526	3215.462	4.307878
SumWidenVectorTraits_Ptr	75.609	3467.110	4.645021
SumWidenVector128_AdvSimd	88.929	2947.793	3.949272
SumWidenVector128Traits	87.451	2997.604	4.016005
SumWidenVector256Traits	968.809	270.584	0.362511
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	353.260	742.070
SumWidenBcl	20.513	12779.141	17.220928
SumWidenVectorBase	21.014	12474.881	16.810912
SumWidenVectorTraits	19.198	13654.522	18.400574
SumWidenVectorTraits_Ptr	20.163	13001.242	17.520226
SumWidenVector128_AdvSimd	22.136	11842.540	15.958781
SumWidenVector128Traits	21.884	11978.628	16.142171
SumWidenVector256Traits	455.505	575.502	0.775536
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	290.524	902.314
SumWidenBcl	76.668	3419.198	3.789367
SumWidenVectorBase	76.861	3410.643	3.779886
SumWidenVectorTraits	82.020	3196.103	3.542120
SumWidenVectorTraits_Ptr	77.623	3377.161	3.742780
SumWidenVector128_AdvSimd	647.936	404.583	0.448384
SumWidenVector128_ArmB64	90.009	2912.424	3.227729
SumWidenVector128Traits	89.990	2913.034	3.228406
SumWidenVector256Traits	1012.451	258.920	0.286951

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	350.824	747.223
SumWidenBcl	84.391	3106.301	4.157126
SumWidenVectorBase	77.132	3398.650	4.548373
SumWidenVectorBase_NRef	493.980	530.678	0.710200
SumWidenVectorBase_NRef2	501.562	522.655	0.699464
SumWidenVectorBase_NRefInc	516.274	507.761	0.679531
SumWidenVectorBase_NRefInc2	509.304	514.710	0.688831
SumWidenVectorBase_Ref	493.530	531.161	0.710847
SumWidenVectorBase_Ref2	496.474	528.012	0.706632
SumWidenVectorBase_RefInc	516.650	507.392	0.679036
SumWidenVectorBase128_Ref	519.699	504.415	0.675052
SumWidenVectorBase128_Ref2	520.449	503.688	0.674080
SumWidenVectorBase128_RefI	517.864	506.202	0.677445
SumWidenVectorBase128_RefI2	517.390	506.666	0.678066
SumWidenVectorBase128_RefInc	512.158	511.842	0.684992
SumWidenVectorBase128_RefInc2	506.850	517.203	0.692166
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	77.348	3389.136	4.535641
SumWidenVectorTraits_Ptr	84.297	3109.776	4.161777
SumWidenVector128_AdvSimd	89.536	2927.791	3.918228
SumWidenVector128Traits	88.125	2974.678	3.980977
SumWidenVector256Traits	976.980	268.321	0.359091
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	310.290	844.835
SumWidenBcl	20.932	12523.461	14.823564
SumWidenVectorBase	21.272	12323.654	14.587059
SumWidenVectorTraits	19.254	13614.989	16.115566
SumWidenVectorTraits_Ptr	19.124	13707.505	16.225074
SumWidenVector128_AdvSimd	21.881	11980.423	14.180790
SumWidenVector128Traits	22.378	11714.531	13.866063
SumWidenVector256Traits	457.388	573.132	0.678396
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	318.068	824.176
SumWidenBcl	77.715	3373.165	4.092772
SumWidenVectorBase	83.961	3122.194	3.788261
SumWidenVectorTraits	84.008	3120.470	3.786170
SumWidenVectorTraits_Ptr	77.437	3385.251	4.107438
SumWidenVector128_AdvSimd	652.276	401.891	0.487628
SumWidenVector128_ArmB64	90.370	2900.784	3.519617
SumWidenVector128Traits	90.714	2889.800	3.506290
SumWidenVector256Traits	1014.103	258.498	0.313645

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.2.0.1013
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.2.0-1013-aws #13~22.04.1-Ubuntu SMP Fri Sep  8 20:05:18 UTC 2023
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
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


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	211.078	1241.928
SumWidenBcl	69.608	3766.012	3.032392
SumWidenVectorBase	69.415	3776.480	3.040821
SumWidenVectorBase_NRef	479.578	546.614	0.440133
SumWidenVectorBase_NRef2	479.490	546.715	0.440215
SumWidenVectorBase_NRefInc	482.369	543.451	0.437586
SumWidenVectorBase_NRefInc2	622.282	421.262	0.339200
SumWidenVectorBase_Ref	480.229	545.873	0.439537
SumWidenVectorBase_Ref2	477.179	549.362	0.442346
SumWidenVectorBase_RefInc	482.174	543.671	0.437764
SumWidenVectorBase128_Ref	489.913	535.083	0.430848
SumWidenVectorBase128_Ref2	489.476	535.561	0.431234
SumWidenVectorBase128_RefI	489.567	535.461	0.431153
SumWidenVectorBase128_RefI2	490.067	534.915	0.430713
SumWidenVectorBase128_RefInc	488.148	537.017	0.432406
SumWidenVectorBase128_RefInc2	487.315	537.936	0.433146
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	69.452	3774.439	3.039177
SumWidenVectorTraits_Ptr	69.680	3762.101	3.029243
SumWidenVector128_AdvSimd	69.629	3764.889	3.031488
SumWidenVector128Traits	69.431	3775.579	3.040096
SumWidenVector256Traits	2277.621	115.096	0.092675
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	217.259	1206.596
SumWidenBcl	17.076	15351.302	12.722820
SumWidenVectorBase	17.076	15351.487	12.722974
SumWidenVectorTraits	17.102	15328.079	12.703574
SumWidenVectorTraits_Ptr	17.358	15102.111	12.516297
SumWidenVector128_AdvSimd	16.933	15481.658	12.830857
SumWidenVector128Traits	87.010	3012.819	2.496958
SumWidenVector256Traits	1498.802	174.902	0.144955
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	211.475	1239.598
SumWidenBcl	73.535	3564.894	2.875846
SumWidenVectorBase	73.533	3564.978	2.875914
SumWidenVectorTraits	73.549	3564.206	2.875291
SumWidenVectorTraits_Ptr	73.440	3569.484	2.879549
SumWidenVector128_AdvSimd	433.874	604.194	0.487411
SumWidenVector128_ArmB64	73.649	3559.367	2.871387
SumWidenVector128Traits	73.533	3565.001	2.875932
SumWidenVector256Traits	2330.706	112.474	0.090734

```

