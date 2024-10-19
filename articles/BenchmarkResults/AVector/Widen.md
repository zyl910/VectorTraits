# Benchmark - Widen
([← Back](README.md))

See [Group](Widen_Group.md)

- `Widen`: Widens a Vector into two Vector instances (将一个 Vector 扩宽为两个 Vector 实例).
  Mnemonic: `element_ref(i, lower, upper) := widen(source[i])`.

## X86

### AMD Ryzen 7 7840H
`AMD Ryzen 7 7840H w/ Radeon 780M Graphics`

#### .NET Framework

```
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9277.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	116.274	2254.532
SumWidenBcl	29.450	8901.453	3.948249
SumWidenVectorBase	28.399	9230.734	4.094301
SumWidenVectorBase_NRef	314.794	832.749	0.369367
SumWidenVectorBase_NRef2	317.024	826.891	0.366768
SumWidenVectorBase_NRefInc	333.054	787.091	0.349115
SumWidenVectorBase_NRefInc2	326.998	801.669	0.355581
SumWidenVectorBase_Ref	313.051	837.384	0.371423
SumWidenVectorBase_Ref2	326.375	803.198	0.356259
SumWidenVectorBase_RefInc	333.897	785.104	0.348234
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	278.630	940.833	0.417307
SumWidenVectorBase256_Ref2	275.449	951.698	0.422126
SumWidenVectorBase256_RefI	339.582	771.960	0.342404
SumWidenVectorBase256_RefI2	335.387	781.617	0.346687
SumWidenVectorBase256_RefInc	343.325	763.544	0.338671
SumWidenVectorBase256_RefInc2	329.862	794.708	0.352494
SumWidenVectorTraits	29.081	9014.183	3.998250
SumWidenVectorTraits_Ptr	29.336	8935.941	3.963546
SumWidenVectorTraits_Tuple	85.526	3065.080	1.359519

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	175.598	1492.863
SumWidenBcl	7.153	36649.220	24.549618
SumWidenVectorBase	7.131	36763.036	24.625858
SumWidenVectorTraits	7.105	36897.153	24.715697
SumWidenVectorTraits_Ptr	7.228	36267.794	24.294118
SumWidenVectorTraits_Tuple	20.527	12770.732	8.554523

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194
SumWidenScalar	238.029	1101.312
SumWidenBcl	31.769	8251.694	7.492601
SumWidenVectorBase	32.281	8120.703	7.373660
SumWidenVectorTraits	30.875	8490.373	7.709323
SumWidenVectorTraits_Ptr	31.175	8408.776	7.635232
SumWidenVectorTraits_Tuple	83.875	3125.429	2.837914

```

#### .NET Core 2.1

```
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:	.NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	112.334	2333.616
SumWidenBcl	30.857	8495.477	3.640478
SumWidenVectorBase	30.404	8622.161	3.694764
SumWidenVectorBase_NRef	315.647	830.498	0.355885
SumWidenVectorBase_NRef2	318.947	821.905	0.352203
SumWidenVectorBase_NRefInc	313.409	836.429	0.358426
SumWidenVectorBase_NRefInc2	315.064	832.033	0.356542
SumWidenVectorBase_Ref	311.040	842.798	0.361155
SumWidenVectorBase_Ref2	343.031	764.199	0.327474
SumWidenVectorBase_RefInc	315.309	831.387	0.356266
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	270.699	968.398	0.414977
SumWidenVectorBase256_Ref2	271.235	966.483	0.414157
SumWidenVectorBase256_RefI	334.972	782.584	0.335353
SumWidenVectorBase256_RefI2	329.162	796.398	0.341272
SumWidenVectorBase256_RefInc	329.200	796.305	0.341232
SumWidenVectorBase256_RefInc2	319.037	821.672	0.352103
SumWidenVectorTraits	32.000	8192.115	3.510481
SumWidenVectorTraits_Ptr	31.292	8377.396	3.589878
SumWidenVectorTraits_Tuple	86.558	3028.525	1.297782

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	183.751	1426.625
SumWidenBcl	7.577	34597.722	24.251441
SumWidenVectorBase	7.568	34640.379	24.281341
SumWidenVectorTraits	7.563	34662.534	24.296871
SumWidenVectorTraits_Ptr	7.492	34987.598	24.524726
SumWidenVectorTraits_Tuple	21.445	12224.085	8.568532

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194
SumWidenScalar	240.017	1092.188
SumWidenBcl	33.124	7913.950	7.245957
SumWidenVectorBase	32.766	8000.543	7.325241
SumWidenVectorTraits	32.732	8008.741	7.332747
SumWidenVectorTraits_Ptr	32.963	7952.727	7.281461
SumWidenVectorTraits_Tuple	85.292	3073.498	2.814073

```

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	111.965	2341.300
SumWidenBcl	30.374	8630.642	3.686262
SumWidenVectorBase	32.234	8132.605	3.473543
SumWidenVectorBase_NRef	315.535	830.793	0.354843
SumWidenVectorBase_NRef2	316.548	828.135	0.353707
SumWidenVectorBase_NRefInc	315.828	830.023	0.354514
SumWidenVectorBase_NRefInc2	314.021	834.798	0.356553
SumWidenVectorBase_Ref	308.083	850.886	0.363425
SumWidenVectorBase_Ref2	310.147	845.225	0.361007
SumWidenVectorBase_RefInc	314.672	833.070	0.355815
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	274.703	954.283	0.407587
SumWidenVectorBase256_Ref2	270.783	968.096	0.413487
SumWidenVectorBase256_RefI	333.162	786.836	0.336068
SumWidenVectorBase256_RefI2	328.178	798.786	0.341172
SumWidenVectorBase256_RefInc	331.150	791.618	0.338110
SumWidenVectorBase256_RefInc2	318.295	823.588	0.351765
SumWidenVectorTraits	22.574	11612.415	4.959816
SumWidenVectorTraits_Ptr	21.899	11970.531	5.112772
SumWidenVectorTraits_Tuple	22.811	11492.239	4.908487
SumWidenVector128Traits	42.598	6153.964	2.628439
SumWidenVector128Traits_Tuple	43.602	6012.154	2.567870
SumWidenVector256Traits	21.540	12170.002	5.197969
SumWidenVector256Avx_ConvertTo	22.513	11644.099	4.973349
SumWidenVector256Avx_Unpack	29.894	8769.076	3.745388

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	182.791	1434.122
SumWidenBcl	7.439	35241.148	24.573331
SumWidenVectorBase	7.614	34431.268	24.008610
SumWidenVectorTraits	7.729	33918.783	23.651259
SumWidenVectorTraits_Ptr	7.328	35774.898	24.945511
SumWidenVectorTraits_Tuple	7.647	34278.713	23.902234
SumWidenVector128Traits	10.082	26002.149	18.131062
SumWidenVector128Traits_Tuple	9.978	26270.943	18.318489
SumWidenVector256Traits	5.269	49754.472	34.693340
SumWidenVector256Avx_ConvertTo	5.251	49920.569	34.809158
SumWidenVector256Avx_Unpack	7.236	36225.980	25.260046

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	239.758	1093.369
SumWidenBcl	32.440	8080.949	7.390874
SumWidenVectorBase	32.717	8012.472	7.328245
SumWidenVectorTraits	34.353	7630.889	6.979247
SumWidenVectorTraits_Ptr	35.154	7456.988	6.820196
SumWidenVectorTraits_Tuple	34.647	7566.192	6.920075
SumWidenVector128Traits	59.187	4429.080	4.050858
SumWidenVector128Traits_Tuple	58.821	4456.605	4.076032
SumWidenVector256Traits	33.539	7816.010	7.148560

```

#### .NET 5.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	5.0.17
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.17\
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
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
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	103.213	2539.831
SumWidenBcl	33.394	7849.956	3.090740
SumWidenVectorBase	31.569	8303.912	3.269475
SumWidenVectorBase_NRef	288.209	909.563	0.358119
SumWidenVectorBase_NRef2	289.007	907.051	0.357130
SumWidenVectorBase_NRefInc	303.298	864.312	0.340303
SumWidenVectorBase_NRefInc2	290.501	902.386	0.355294
SumWidenVectorBase_Ref	299.492	875.297	0.344628
SumWidenVectorBase_Ref2	298.610	877.880	0.345645
SumWidenVectorBase_RefInc	307.055	853.735	0.336139
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	266.689	982.957	0.387017
SumWidenVectorBase256_Ref2	268.658	975.754	0.384181
SumWidenVectorBase256_RefI	327.362	800.777	0.315287
SumWidenVectorBase256_RefI2	327.566	800.279	0.315091
SumWidenVectorBase256_RefInc	329.112	796.520	0.313611
SumWidenVectorBase256_RefInc2	311.333	842.005	0.331520
SumWidenVectorTraits	21.927	11955.292	4.707121
SumWidenVectorTraits_Ptr	21.843	12001.438	4.725290
SumWidenVectorTraits_Tuple	22.632	11582.847	4.560480
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	42.524	6164.549	2.427149
SumWidenVector128Traits_Tuple	42.692	6140.319	2.417609
SumWidenVector256Traits	21.907	11965.955	4.711320
SumWidenVector256Avx_ConvertTo	21.961	11936.744	4.699818
SumWidenVector256Avx_Unpack	29.410	8913.498	3.509485

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	181.146	1447.139
SumWidenBcl	7.576	34600.498	23.909582
SumWidenVectorBase	7.545	34742.227	24.007520
SumWidenVectorTraits	7.585	34558.728	23.880718
SumWidenVectorTraits_Ptr	7.389	35476.955	24.515230
SumWidenVectorTraits_Tuple	7.836	33455.855	23.118613
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	10.105	25942.320	17.926622
SumWidenVector128Traits_Tuple	10.257	25556.874	17.660271
SumWidenVector256Traits	5.157	50828.126	35.123172
SumWidenVector256Avx_ConvertTo	5.391	48627.285	33.602351
SumWidenVector256Avx_Unpack	7.257	36124.811	24.962911

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	238.301	1100.053
SumWidenBcl	32.120	8161.360	7.419057
SumWidenVectorBase	33.106	7918.373	7.198171
SumWidenVectorTraits	33.835	7747.803	7.043115
SumWidenVectorTraits_Ptr	33.618	7797.809	7.088573
SumWidenVectorTraits_Tuple	33.607	7800.314	7.090850
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	60.237	4351.855	3.956039
SumWidenVector128Traits_Tuple	59.339	4417.706	4.015902
SumWidenVector256Traits	34.000	7710.094	7.008835

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.33
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.33\
RuntimeInformation.FrameworkDescription:	.NET 6.0.33
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.33/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	105.574	2483.047
SumWidenBcl	33.318	7868.034	3.168702
SumWidenVectorBase	31.418	8343.677	3.360258
SumWidenVectorBase_NRef	315.121	831.884	0.335025
SumWidenVectorBase_NRef2	315.071	832.016	0.335079
SumWidenVectorBase_NRefInc	318.355	823.433	0.331622
SumWidenVectorBase_NRefInc2	314.313	834.023	0.335887
SumWidenVectorBase_Ref	314.807	832.714	0.335360
SumWidenVectorBase_Ref2	307.988	851.150	0.342784
SumWidenVectorBase_RefInc	316.815	827.436	0.333234
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	267.879	978.591	0.394109
SumWidenVectorBase256_Ref2	270.935	967.552	0.389663
SumWidenVectorBase256_RefI	332.590	788.191	0.317429
SumWidenVectorBase256_RefI2	330.143	794.031	0.319781
SumWidenVectorBase256_RefInc	330.685	792.729	0.319257
SumWidenVectorBase256_RefInc2	324.032	809.007	0.325812
SumWidenVectorTraits	22.691	11552.556	4.652573
SumWidenVectorTraits_Ptr	22.435	11684.651	4.705772
SumWidenVectorTraits_Tuple	23.218	11290.438	4.547010
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	42.897	6110.993	2.461086
SumWidenVector128Traits_Tuple	42.359	6188.656	2.492364
SumWidenVector256Traits	22.853	11470.935	4.619702
SumWidenVector256Avx_ConvertTo	23.350	11226.810	4.521385
SumWidenVector256Avx_Unpack	29.321	8940.537	3.600632

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	190.642	1375.062
SumWidenBcl	7.386	35492.417	25.811499
SumWidenVectorBase	7.627	34369.078	24.994561
SumWidenVectorTraits	7.528	34821.768	25.323776
SumWidenVectorTraits_Ptr	7.558	34685.544	25.224709
SumWidenVectorTraits_Tuple	7.631	34353.965	24.983571
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	10.323	25393.202	18.466948
SumWidenVector128Traits_Tuple	10.394	25221.824	18.342315
SumWidenVector256Traits	5.261	49829.990	36.238353
SumWidenVector256Avx_ConvertTo	5.223	50193.948	36.503037
SumWidenVector256Avx_Unpack	7.227	36274.033	26.379921

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	239.756	1093.376
SumWidenBcl	32.661	8026.283	7.340824
SumWidenVectorBase	33.342	7862.327	7.190870
SumWidenVectorTraits	33.463	7833.755	7.164738
SumWidenVectorTraits_Ptr	34.637	7568.426	6.922069
SumWidenVectorTraits_Tuple	34.131	7680.428	7.024507
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	60.299	4347.376	3.976103
SumWidenVector128Traits_Tuple	59.171	4430.264	4.051911
SumWidenVector256Traits	33.888	7735.555	7.074925

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.20
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.20\
RuntimeInformation.FrameworkDescription:	.NET 7.0.20
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.20/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	120.186	2181.156
SumWidenBcl	23.633	11092.317	5.085522
SumWidenVectorBase	22.591	11603.759	5.320004
SumWidenVectorBase_NRef	328.753	797.388	0.365580
SumWidenVectorBase_NRef2	333.114	786.949	0.360794
SumWidenVectorBase_NRefInc	305.879	857.018	0.392919
SumWidenVectorBase_NRefInc2	290.770	901.551	0.413336
SumWidenVectorBase_Ref	300.640	871.953	0.399766
SumWidenVectorBase_Ref2	327.581	800.242	0.366889
SumWidenVectorBase_RefInc	307.031	853.803	0.391445
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	264.722	990.262	0.454008
SumWidenVectorBase256_Ref2	265.094	988.872	0.453371
SumWidenVectorBase256_RefI	336.005	780.180	0.357691
SumWidenVectorBase256_RefI2	333.741	785.472	0.360117
SumWidenVectorBase256_RefInc	334.006	784.849	0.359832
SumWidenVectorBase256_RefInc2	312.943	837.674	0.384051
SumWidenVectorTraits	23.376	11214.266	5.141432
SumWidenVectorTraits_Ptr	22.417	11693.881	5.361322
SumWidenVectorTraits_Tuple	22.514	11643.575	5.338258
SumWidenVector128Bcl	41.756	6277.958	2.878271
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	43.351	6046.995	2.772381
SumWidenVector128Traits_Tuple	44.281	5920.061	2.714185
SumWidenVector256Traits	23.691	11065.353	5.073159
SumWidenVector256Avx_ConvertTo	22.440	11682.224	5.355978
SumWidenVector256Avx_Unpack	32.045	8180.578	3.750570

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	167.702	1563.158
SumWidenBcl	5.665	46271.101	29.601041
SumWidenVectorBase	5.259	49842.042	31.885481
SumWidenVectorTraits	6.074	43161.333	27.611626
SumWidenVectorTraits_Ptr	5.411	48446.925	30.992982
SumWidenVectorTraits_Tuple	5.183	50581.458	32.358508
SumWidenVector128Bcl	10.068	26037.456	16.656958
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	9.724	26959.443	17.246782
SumWidenVector128Traits_Tuple	9.869	26563.574	16.993532
SumWidenVector256Traits	5.578	46999.940	30.067301
SumWidenVector256Avx_ConvertTo	5.482	47815.329	30.588931
SumWidenVector256Avx_Unpack	7.656	34241.669	21.905444

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	241.031	1087.595
SumWidenBcl	33.577	7807.261	7.178467
SumWidenVectorBase	34.330	7635.939	7.020943
SumWidenVectorTraits	35.416	7401.778	6.805641
SumWidenVectorTraits_Ptr	34.181	7669.193	7.051518
SumWidenVectorTraits_Tuple	34.464	7606.420	6.993802
SumWidenVector128Bcl	59.534	4403.237	4.048602
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	59.514	4404.759	4.050001
SumWidenVector128Traits_Tuple	59.363	4415.913	4.060257
SumWidenVector256Traits	34.269	7649.611	7.033514

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.8
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.8\
RuntimeInformation.FrameworkDescription:	.NET 8.0.8
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector512.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844161	# 0x8177F7FF
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Avx512BW, Avx512CD, Avx512DQ, Avx512F, Avx512Vbmi, Avx512VL, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2, Avx512VL
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vector512s.Instance:	WVectorTraits512Avx512	// Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi, Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	105.267	2490.283
SumWidenBcl	23.808	11010.849	4.421524
SumWidenVectorBase	23.425	11190.965	4.493852
SumWidenVectorBase_NRef	336.205	779.716	0.313103
SumWidenVectorBase_NRef2	330.521	793.123	0.318487
SumWidenVectorBase_NRefInc	331.996	789.599	0.317072
SumWidenVectorBase_NRefInc2	331.185	791.533	0.317849
SumWidenVectorBase_Ref	334.789	783.012	0.314427
SumWidenVectorBase_Ref2	334.230	784.322	0.314953
SumWidenVectorBase_RefInc	334.218	784.351	0.314964
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	284.021	922.974	0.370630
SumWidenVectorBase256_Ref2	283.238	925.527	0.371655
SumWidenVectorBase256_RefI	334.324	784.102	0.314865
SumWidenVectorBase256_RefI2	331.869	789.902	0.317194
SumWidenVectorBase256_RefInc	336.125	779.901	0.313178
SumWidenVectorBase256_RefInc2	336.506	779.018	0.312823
SumWidenVectorTraits	24.100	10877.148	4.367835
SumWidenVectorTraits_Ptr	23.776	11025.536	4.427422
SumWidenVectorTraits_Tuple	24.435	10728.196	4.308022
SumWidenVector128Bcl	42.098	6227.012	2.500523
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	44.945	5832.495	2.342101
SumWidenVector128Traits_Tuple	44.705	5863.818	2.354679
SumWidenVector256Traits	23.910	10963.784	4.402625
SumWidenVector256Avx_ConvertTo	24.034	10907.020	4.379831
SumWidenVector256Avx_Unpack	34.191	7667.019	3.078774
SumWidenVector512Bcl	18.667	14043.277	5.639228
SumWidenVector512Traits	18.300	14324.904	5.752319

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	167.124	1568.560
SumWidenBcl	5.515	47530.522	30.302009
SumWidenVectorBase	5.581	46969.276	29.944199
SumWidenVectorTraits	5.375	48768.485	31.091244
SumWidenVectorTraits_Ptr	5.692	46052.153	29.359508
SumWidenVectorTraits_Tuple	5.335	49141.174	31.328844
SumWidenVector128Bcl	10.034	26125.447	16.655687
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	9.926	26410.807	16.837612
SumWidenVector128Traits_Tuple	10.074	26021.520	16.589431
SumWidenVector256Traits	5.668	46249.842	29.485540
SumWidenVector256Avx_ConvertTo	5.480	47836.951	30.497366
SumWidenVector256Avx_Unpack	8.088	32412.234	20.663686
SumWidenVector512Bcl	4.123	63574.604	40.530550
SumWidenVector512Traits	4.080	64258.185	40.966352

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	241.345	1086.179
SumWidenBcl	34.728	7548.402	6.949499
SumWidenVectorBase	34.780	7537.233	6.939217
SumWidenVectorTraits	34.241	7655.748	7.048328
SumWidenVectorTraits_Ptr	34.647	7566.118	6.965809
SumWidenVectorTraits_Tuple	34.251	7653.703	7.046445
SumWidenVector128Bcl	59.174	4430.082	4.078592
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	59.331	4418.325	4.067768
SumWidenVector128Traits_Tuple	59.893	4376.894	4.029624
SumWidenVector256Traits	35.314	7423.171	6.834204
SumWidenVector512Bcl	25.888	10125.983	9.322570
SumWidenVector512Traits	25.756	10177.939	9.370404

```

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

### Apple M2
`Apple M2`

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	6.0.33
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.33/
RuntimeInformation.FrameworkDescription:	.NET 6.0.33
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.15-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.33/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, ArmBase, Crc32
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	151.460	1730.782
SumWidenBcl	38.532	6803.226	3.930724
SumWidenVectorBase	38.544	6801.120	3.929507
SumWidenVectorBase_NRef	121.610	2155.604	1.245451
SumWidenVectorBase_NRef2	111.450	2352.115	1.358990
SumWidenVectorBase_NRefInc	111.160	2358.251	1.362535
SumWidenVectorBase_NRefInc2	120.819	2169.733	1.253614
SumWidenVectorBase_Ref	130.443	2009.639	1.161116
SumWidenVectorBase_Ref2	116.003	2259.802	1.305654
SumWidenVectorBase_RefInc	111.165	2358.161	1.362483
SumWidenVectorBase128_Ref	82.485	3178.062	1.836200
SumWidenVectorBase128_Ref2	81.230	3227.189	1.864585
SumWidenVectorBase128_RefI	80.468	3257.744	1.882238
SumWidenVectorBase128_RefI2	81.063	3233.826	1.868419
SumWidenVectorBase128_RefInc	81.174	3229.408	1.865866
SumWidenVectorBase128_RefInc2	85.709	3058.537	1.767142
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	38.548	6800.379	3.929079
SumWidenVectorTraits_Ptr	38.531	6803.411	3.930831
SumWidenVectorTraits_Tuple	78.039	3359.160	1.940834
SumWidenVector128_AdvSimd	38.548	6800.430	3.929109
SumWidenVector128Traits	38.549	6800.337	3.929055
SumWidenVector128Traits_Tuple	78.040	3359.087	1.940792
SumWidenVector256Traits	368.571	711.244	0.410938
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	155.256	1688.465
SumWidenBcl	9.627	27229.541	16.126806
SumWidenVectorBase	9.634	27209.420	16.114889
SumWidenVectorTraits	9.630	27221.867	16.122261
SumWidenVectorTraits_Ptr	9.630	27222.661	16.122731
SumWidenVectorTraits_Tuple	19.533	13420.688	7.948457
SumWidenVector128_AdvSimd	9.634	27208.961	16.114617
SumWidenVector128Traits	9.624	27239.426	16.132661
SumWidenVector128Traits_Tuple	19.522	13428.271	7.952948
SumWidenVector256Traits	172.068	1523.490	0.902293
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	231.191	1133.883
SumWidenBcl	57.772	4537.542	4.001771
SumWidenVectorBase	57.800	4535.382	3.999866
SumWidenVectorTraits	57.787	4536.357	4.000726
SumWidenVectorTraits_Ptr	57.791	4536.093	4.000493
SumWidenVectorTraits_Tuple	78.002	3360.726	2.963908
SumWidenVector128_AdvSimd	171.536	1528.218	1.347774
SumWidenVector128_ArmB64	57.794	4535.853	4.000282
SumWidenVector128Traits	57.787	4536.361	4.000729
SumWidenVector128Traits_Tuple	74.906	3499.643	3.086422
SumWidenVector256Traits	450.485	581.915	0.513205

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	7.0.20
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.20/
RuntimeInformation.FrameworkDescription:	.NET 7.0.20
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.15-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.20/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	150.040	1747.163
SumWidenBcl	38.533	6803.028	3.893756
SumWidenVectorBase	38.527	6804.076	3.894356
SumWidenVectorBase_NRef	102.092	2567.712	1.469646
SumWidenVectorBase_NRef2	92.503	2833.900	1.622001
SumWidenVectorBase_NRefInc	96.734	2709.955	1.551060
SumWidenVectorBase_NRefInc2	101.561	2581.155	1.477340
SumWidenVectorBase_Ref	102.031	2569.250	1.470526
SumWidenVectorBase_Ref2	97.431	2690.564	1.539961
SumWidenVectorBase_RefInc	96.757	2709.309	1.550690
SumWidenVectorBase128_Ref	79.560	3294.916	1.885866
SumWidenVectorBase128_Ref2	79.602	3293.200	1.884884
SumWidenVectorBase128_RefI	79.095	3314.283	1.896951
SumWidenVectorBase128_RefI2	79.587	3293.809	1.885232
SumWidenVectorBase128_RefInc	79.582	3293.997	1.885340
SumWidenVectorBase128_RefInc2	80.457	3258.196	1.864849
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	38.532	6803.195	3.893852
SumWidenVectorTraits_Ptr	38.530	6803.633	3.894102
SumWidenVectorTraits_Tuple	82.177	3189.992	1.825812
SumWidenVector128Bcl	82.165	3190.474	1.826088
SumWidenVector128_AdvSimd	38.536	6802.587	3.893504
SumWidenVector128Traits	38.540	6801.833	3.893072
SumWidenVector128Traits_Tuple	82.229	3187.982	1.824662
SumWidenVector256Traits	929.332	282.078	0.161449
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	154.993	1691.328
SumWidenBcl	9.632	27216.188	16.091606
SumWidenVectorBase	9.630	27221.954	16.095016
SumWidenVectorTraits	9.630	27222.696	16.095454
SumWidenVectorTraits_Ptr	9.629	27225.615	16.097180
SumWidenVectorTraits_Tuple	20.560	12750.485	7.538741
SumWidenVector128Bcl	20.561	12749.405	7.538103
SumWidenVector128_AdvSimd	9.629	27224.351	16.096433
SumWidenVector128Traits	20.576	12740.490	7.532831
SumWidenVector128Traits_Tuple	43.297	6054.487	3.579723
SumWidenVector256Traits	405.299	646.792	0.382417
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	224.838	1165.922
SumWidenBcl	57.783	4536.672	3.891060
SumWidenVectorBase	57.778	4537.063	3.891396
SumWidenVectorTraits	57.784	4536.623	3.891018
SumWidenVectorTraits_Ptr	57.775	4537.297	3.891596
SumWidenVectorTraits_Tuple	82.414	3180.835	2.728172
SumWidenVector128Bcl	57.779	4537.007	3.891347
SumWidenVector128_AdvSimd	171.009	1532.928	1.314778
SumWidenVector128_ArmB64	57.785	4536.535	3.890942
SumWidenVector128Traits	57.781	4536.837	3.891201
SumWidenVector128Traits_Tuple	80.740	3246.749	2.784706
SumWidenVector256Traits	894.124	293.185	0.251462

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	8.0.4
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.4/
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.4/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844159	# 0x8177F801
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	150.005	1747.574
SumWidenBcl	38.527	6804.250	3.893540
SumWidenVectorBase	38.528	6804.020	3.893409
SumWidenVectorBase_NRef	97.023	2701.874	1.546071
SumWidenVectorBase_NRef2	94.509	2773.761	1.587206
SumWidenVectorBase_NRefInc	83.127	3153.551	1.804530
SumWidenVectorBase_NRefInc2	94.180	2783.450	1.592751
SumWidenVectorBase_Ref	96.849	2706.734	1.548852
SumWidenVectorBase_Ref2	100.409	2610.766	1.493937
SumWidenVectorBase_RefInc	83.174	3151.770	1.803512
SumWidenVectorBase128_Ref	77.212	3395.136	1.942771
SumWidenVectorBase128_Ref2	77.229	3394.358	1.942325
SumWidenVectorBase128_RefI	77.189	3396.126	1.943338
SumWidenVectorBase128_RefI2	77.310	3390.830	1.940307
SumWidenVectorBase128_RefInc	77.610	3377.728	1.932810
SumWidenVectorBase128_RefInc2	77.258	3393.094	1.941602
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	38.528	6803.998	3.893396
SumWidenVectorTraits_Ptr	38.530	6803.699	3.893225
SumWidenVectorTraits_Tuple	38.529	6803.850	3.893311
SumWidenVector128Bcl	38.526	6804.371	3.893609
SumWidenVector128_AdvSimd	38.531	6803.538	3.893133
SumWidenVector128Traits	38.530	6803.583	3.893159
SumWidenVector128Traits_Tuple	38.532	6803.260	3.892974
SumWidenVector256Traits	19.407	13507.372	7.729213
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector512Bcl	19.378	13527.831	7.740920
SumWidenVector512Traits	19.379	13527.071	7.740485

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	154.918	1692.147
SumWidenBcl	9.627	27229.453	16.091661
SumWidenVectorBase	9.627	27229.410	16.091635
SumWidenVectorTraits	9.626	27231.529	16.092887
SumWidenVectorTraits_Ptr	9.627	27229.186	16.091503
SumWidenVectorTraits_Tuple	9.626	27232.954	16.093730
SumWidenVector128Bcl	9.627	27229.658	16.091782
SumWidenVector128_AdvSimd	9.628	27228.620	16.091168
SumWidenVector128Traits	9.624	27238.115	16.096780
SumWidenVector128Traits_Tuple	9.625	27236.399	16.095765
SumWidenVector256Traits	4.849	54065.309	31.950719
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector512Bcl	4.834	54230.681	32.048448
SumWidenVector512Traits	4.832	54247.210	32.058216

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	224.863	1165.793
SumWidenBcl	57.781	4536.819	3.891617
SumWidenVectorBase	57.779	4537.021	3.891790
SumWidenVectorTraits	57.774	4537.396	3.892112
SumWidenVectorTraits_Ptr	57.772	4537.599	3.892286
SumWidenVectorTraits_Tuple	57.780	4536.955	3.891733
SumWidenVector128Bcl	57.775	4537.337	3.892062
SumWidenVector128_AdvSimd	135.930	1928.528	1.654264
SumWidenVector128_ArmB64	57.771	4537.619	3.892303
SumWidenVector128Traits	57.772	4537.559	3.892252
SumWidenVector128Traits_Tuple	57.766	4538.026	3.892652
SumWidenVector256Traits	29.037	9028.034	7.744115
SumWidenVector512Bcl	19.305	13579.285	11.648112
SumWidenVector512Traits	19.306	13578.096	11.647092

```

### AWS Arm t4g.small
`AWS Arm t4g.small`

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
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
SumWidenScalar	349.878	749.244
SumWidenBcl	73.762	3553.920	4.743340
SumWidenVectorBase	73.988	3543.074	4.728863
SumWidenVectorBase_NRef	491.884	532.938	0.711301
SumWidenVectorBase_NRef2	491.981	532.833	0.711161
SumWidenVectorBase_NRefInc	497.630	526.785	0.703089
SumWidenVectorBase_NRefInc2	492.512	532.259	0.710395
SumWidenVectorBase_Ref	488.256	536.899	0.716587
SumWidenVectorBase_Ref2	490.368	534.587	0.713501
SumWidenVectorBase_RefInc	857.178	305.822	0.408174
SumWidenVectorBase128_Ref	507.969	516.063	0.688778
SumWidenVectorBase128_Ref2	506.723	517.332	0.690471
SumWidenVectorBase128_RefI	506.006	518.065	0.691450
SumWidenVectorBase128_RefI2	503.303	520.847	0.695163
SumWidenVectorBase128_RefInc	500.716	523.538	0.698754
SumWidenVectorBase128_RefInc2	492.430	532.347	0.710512
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	79.644	3291.431	4.393001
SumWidenVectorTraits_Ptr	73.743	3554.814	4.744533
SumWidenVectorTraits_Tuple	354.054	740.407	0.988205
SumWidenVector128Traits	1075.125	243.827	0.325430
SumWidenVector128Traits_Tuple	1564.950	167.510	0.223571
SumWidenVector256Traits	1442.154	181.773	0.242608
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	343.196	763.832
SumWidenBcl	18.370	14270.443	18.682694
SumWidenVectorBase	18.331	14300.698	18.722303
SumWidenVectorTraits	19.847	13208.029	17.291795
SumWidenVectorTraits_Ptr	19.875	13189.526	17.267570
SumWidenVectorTraits_Tuple	85.439	3068.204	4.016857
SumWidenVector128Traits	588.784	445.229	0.582889
SumWidenVector128Traits_Tuple	782.067	335.194	0.438832
SumWidenVector256Traits	569.716	460.131	0.602398
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	290.798	901.465
SumWidenBcl	79.883	3281.583	3.640278
SumWidenVectorBase	73.797	3552.245	3.940525
SumWidenVectorTraits	73.880	3548.242	3.936084
SumWidenVectorTraits_Ptr	79.820	3284.196	3.643176
SumWidenVectorTraits_Tuple	346.517	756.511	0.839202
SumWidenVector128Traits	1227.967	213.478	0.236812
SumWidenVector128Traits_Tuple	1680.348	156.006	0.173058
SumWidenVector256Traits	1442.837	181.686	0.201546

```

#### .NET 5.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
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
SumWidenScalar	350.760	747.360
SumWidenBcl	82.120	3192.224	4.271332
SumWidenVectorBase	83.423	3142.346	4.204594
SumWidenVectorBase_NRef	490.994	533.904	0.714387
SumWidenVectorBase_NRef2	710.519	368.947	0.493667
SumWidenVectorBase_NRefInc	515.933	508.097	0.679855
SumWidenVectorBase_NRefInc2	503.323	520.827	0.696889
SumWidenVectorBase_Ref	491.626	533.218	0.713468
SumWidenVectorBase_Ref2	493.029	531.701	0.711439
SumWidenVectorBase_RefInc	512.379	511.621	0.684571
SumWidenVectorBase128_Ref	518.689	505.397	0.676243
SumWidenVectorBase128_Ref2	516.451	507.588	0.679174
SumWidenVectorBase128_RefI	515.560	508.464	0.680347
SumWidenVectorBase128_RefI2	512.988	511.014	0.683759
SumWidenVectorBase128_RefInc	509.916	514.092	0.687877
SumWidenVectorBase128_RefInc2	503.598	520.542	0.696508
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	75.324	3480.225	4.656690
SumWidenVectorTraits_Ptr	75.741	3461.064	4.631053
SumWidenVectorTraits_Tuple	352.902	742.823	0.993929
SumWidenVector128_AdvSimd	87.910	2981.951	3.989978
SumWidenVector128Traits	87.422	2998.620	4.012282
SumWidenVector128Traits_Tuple	353.254	742.083	0.992939
SumWidenVector256Traits	969.559	270.374	0.361773
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	351.594	745.586
SumWidenBcl	20.485	12796.934	17.163581
SumWidenVectorBase	20.485	12796.786	17.163382
SumWidenVectorTraits	18.795	13947.906	18.707294
SumWidenVectorTraits_Ptr	20.192	12982.516	17.412488
SumWidenVectorTraits_Tuple	88.033	2977.798	3.993900
SumWidenVector128_AdvSimd	21.928	11954.541	16.033742
SumWidenVector128Traits	22.467	11668.198	15.649691
SumWidenVector128Traits_Tuple	86.014	3047.689	4.087640
SumWidenVector256Traits	457.556	572.922	0.768418
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	317.620	825.338
SumWidenBcl	82.745	3168.093	3.838540
SumWidenVectorBase	83.242	3149.163	3.815605
SumWidenVectorTraits	76.112	3444.203	4.173081
SumWidenVectorTraits_Ptr	80.703	3248.274	3.935689
SumWidenVectorTraits_Tuple	342.309	765.812	0.927876
SumWidenVector128_AdvSimd	646.384	405.555	0.491380
SumWidenVector128_ArmB64	89.546	2927.491	3.547021
SumWidenVector128Traits	90.021	2912.039	3.528299
SumWidenVector128Traits_Tuple	340.974	768.810	0.931509
SumWidenVector256Traits	1011.500	259.164	0.314009

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
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
SumWidenScalar	349.648	749.738
SumWidenBcl	82.123	3192.094	4.257615
SumWidenVectorBase	75.829	3457.053	4.611017
SumWidenVectorBase_NRef	490.174	534.798	0.713313
SumWidenVectorBase_NRef2	496.618	527.858	0.704057
SumWidenVectorBase_NRefInc	511.279	512.722	0.683869
SumWidenVectorBase_NRefInc2	504.423	519.690	0.693163
SumWidenVectorBase_Ref	491.799	533.031	0.710957
SumWidenVectorBase_Ref2	770.126	340.391	0.454014
SumWidenVectorBase_RefInc	512.515	511.485	0.682219
SumWidenVectorBase128_Ref	516.723	507.320	0.676664
SumWidenVectorBase128_Ref2	517.115	506.936	0.676151
SumWidenVectorBase128_RefI	515.056	508.962	0.678853
SumWidenVectorBase128_RefI2	512.929	511.073	0.681669
SumWidenVectorBase128_RefInc	510.179	513.827	0.685343
SumWidenVectorBase128_RefInc2	503.414	520.732	0.694552
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	81.256	3226.132	4.303014
SumWidenVectorTraits_Ptr	83.826	3127.243	4.171117
SumWidenVectorTraits_Tuple	363.579	721.010	0.961683
SumWidenVector128_AdvSimd	88.365	2966.613	3.956869
SumWidenVector128Traits	87.478	2996.682	3.996974
SumWidenVector128Traits_Tuple	367.280	713.744	0.951992
SumWidenVector256Traits	974.353	269.044	0.358851
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	310.366	844.629
SumWidenBcl	20.191	12982.929	15.371160
SumWidenVectorBase	20.170	12996.731	15.387502
SumWidenVectorTraits	19.237	13626.837	16.133516
SumWidenVectorTraits_Ptr	19.117	13712.771	16.235258
SumWidenVectorTraits_Tuple	95.021	2758.807	3.266294
SumWidenVector128_AdvSimd	21.893	11973.719	14.176305
SumWidenVector128Traits	21.866	11988.909	14.194289
SumWidenVector128Traits_Tuple	91.517	2864.418	3.391333
SumWidenVector256Traits	457.784	572.637	0.677974
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	316.641	827.889
SumWidenBcl	75.554	3469.623	4.190927
SumWidenVectorBase	81.945	3199.008	3.864053
SumWidenVectorTraits	82.933	3160.921	3.818049
SumWidenVectorTraits_Ptr	75.701	3462.879	4.182781
SumWidenVectorTraits_Tuple	367.466	713.384	0.861690
SumWidenVector128_AdvSimd	646.604	405.416	0.489699
SumWidenVector128_ArmB64	88.821	2951.373	3.564937
SumWidenVector128Traits	89.500	2928.986	3.537897
SumWidenVector128Traits_Tuple	367.172	713.954	0.862379
SumWidenVector256Traits	1018.208	257.456	0.310979

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
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
SumWidenScalar	211.125	1241.653
SumWidenBcl	68.748	3813.135	3.071016
SumWidenVectorBase	68.682	3816.794	3.073962
SumWidenVectorBase_NRef	478.579	547.755	0.441150
SumWidenVectorBase_NRef2	478.987	547.288	0.440774
SumWidenVectorBase_NRefInc	481.923	543.955	0.438089
SumWidenVectorBase_NRefInc2	635.160	412.721	0.332397
SumWidenVectorBase_Ref	480.484	545.583	0.439401
SumWidenVectorBase_Ref2	476.933	549.645	0.442672
SumWidenVectorBase_RefInc	481.106	544.878	0.438833
SumWidenVectorBase128_Ref	488.977	536.108	0.431769
SumWidenVectorBase128_Ref2	488.571	536.552	0.432127
SumWidenVectorBase128_RefI	489.373	535.673	0.431419
SumWidenVectorBase128_RefI2	489.792	535.215	0.431050
SumWidenVectorBase128_RefInc	487.729	537.479	0.432874
SumWidenVectorBase128_RefInc2	486.865	538.432	0.433642
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	69.127	3792.197	3.054153
SumWidenVectorTraits_Ptr	69.307	3782.360	3.046230
SumWidenVectorTraits_Tuple	342.001	766.501	0.617323
SumWidenVector128Bcl	340.864	769.057	0.619382
SumWidenVector128_AdvSimd	68.871	3806.328	3.065534
SumWidenVector128Traits	68.871	3806.301	3.065512
SumWidenVector128Traits_Tuple	341.336	767.994	0.618526
SumWidenVector256Traits	2278.810	115.035	0.092647
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	218.115	1201.863
SumWidenBcl	17.154	15281.536	12.714876
SumWidenVectorBase	17.146	15289.153	12.721213
SumWidenVectorTraits	17.106	15324.971	12.751015
SumWidenVectorTraits_Ptr	17.335	15121.821	12.581986
SumWidenVectorTraits_Tuple	88.552	2960.328	2.463116
SumWidenVector128Bcl	85.016	3083.452	2.565561
SumWidenVector128_AdvSimd	17.070	15356.639	12.777364
SumWidenVector128Traits	85.013	3083.590	2.565676
SumWidenVector128Traits_Tuple	140.384	1867.340	1.553705
SumWidenVector256Traits	1519.955	172.468	0.143501
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	210.795	1243.598
SumWidenBcl	72.439	3618.807	2.909950
SumWidenVectorBase	72.365	3622.533	2.912946
SumWidenVectorTraits	72.361	3622.737	2.913110
SumWidenVectorTraits_Ptr	72.333	3624.135	2.914234
SumWidenVectorTraits_Tuple	358.318	731.596	0.588290
SumWidenVector128Bcl	72.569	3612.349	2.904757
SumWidenVector128_AdvSimd	441.425	593.858	0.477532
SumWidenVector128_ArmB64	72.373	3622.139	2.912629
SumWidenVector128Traits	72.264	3627.594	2.917015
SumWidenVector128Traits_Tuple	342.231	765.985	0.615943
SumWidenVector256Traits	2364.795	110.853	0.089139

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	8.0.7
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/
RuntimeInformation.FrameworkDescription:	.NET 8.0.7
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Ubuntu 22.04.2 LTS
RuntimeInformation.RuntimeIdentifier:	linux-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844159	# 0x8177F801
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	210.754	1243.836
SumWidenBcl	81.743	3206.932	2.578259
SumWidenVectorBase	82.007	3196.625	2.569973
SumWidenVectorBase_NRef	485.883	539.521	0.433756
SumWidenVectorBase_NRef2	485.693	539.731	0.433925
SumWidenVectorBase_NRefInc	477.231	549.302	0.441620
SumWidenVectorBase_NRefInc2	474.714	552.214	0.443961
SumWidenVectorBase_Ref	485.502	539.944	0.434096
SumWidenVectorBase_Ref2	483.533	542.143	0.435864
SumWidenVectorBase_RefInc	477.526	548.963	0.441347
SumWidenVectorBase128_Ref	477.281	549.244	0.441573
SumWidenVectorBase128_Ref2	477.746	548.710	0.441144
SumWidenVectorBase128_RefI	478.273	548.106	0.440658
SumWidenVectorBase128_RefI2	479.098	547.161	0.439898
SumWidenVectorBase128_RefInc	478.410	547.948	0.440531
SumWidenVectorBase128_RefInc2	479.464	546.744	0.439563
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	80.165	3270.046	2.629001
SumWidenVectorTraits_Ptr	80.079	3273.569	2.631833
SumWidenVectorTraits_Tuple	81.658	3210.275	2.580947
SumWidenVector128Bcl	81.677	3209.519	2.580340
SumWidenVector128_AdvSimd	82.372	3182.450	2.558577
SumWidenVector128Traits	81.629	3211.422	2.581869
SumWidenVector128Traits_Tuple	82.574	3174.646	2.552303
SumWidenVector256Traits	72.731	3604.290	2.897721
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector512Bcl	72.301	3625.745	2.914970
SumWidenVector512Traits	72.265	3627.551	2.916423

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	216.928	1208.435
SumWidenBcl	20.212	12969.867	10.732777
SumWidenVectorBase	20.213	12969.157	10.732190
SumWidenVectorTraits	20.222	12963.049	10.727135
SumWidenVectorTraits_Ptr	20.167	12998.963	10.756855
SumWidenVectorTraits_Tuple	20.191	12982.925	10.743583
SumWidenVector128Bcl	20.205	12974.279	10.736428
SumWidenVector128_AdvSimd	20.233	12956.539	10.721749
SumWidenVector128Traits	20.197	12979.281	10.740568
SumWidenVector128Traits_Tuple	20.191	12983.269	10.743868
SumWidenVector256Traits	18.127	14461.715	11.967306
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector512Bcl	17.706	14805.651	12.251919
SumWidenVector512Traits	17.706	14805.076	12.251443

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	210.744	1243.899
SumWidenBcl	83.587	3136.182	2.521251
SumWidenVectorBase	83.523	3138.588	2.523185
SumWidenVectorTraits	83.584	3136.279	2.521329
SumWidenVectorTraits_Ptr	82.269	3186.439	2.561654
SumWidenVectorTraits_Tuple	83.856	3126.116	2.513159
SumWidenVector128Bcl	83.581	3136.396	2.521423
SumWidenVector128_AdvSimd	310.609	843.967	0.678485
SumWidenVector128_ArmB64	83.952	3122.563	2.510302
SumWidenVector128Traits	83.651	3133.783	2.519322
SumWidenVector128Traits_Tuple	83.521	3138.652	2.523237
SumWidenVector256Traits	75.688	3463.491	2.784382
SumWidenVector512Bcl	72.264	3627.605	2.916317
SumWidenVector512Traits	72.822	3599.776	2.893945

```

## Wasm

### Wasm on AMD Ryzen 7 7840H
``

#### .NET 8.0

```
VectorTraits.Benchmarks.Wasm


IsRelease:	True
Environment.ProcessorCount:	1
Environment.Is64BitProcess:	False
Environment.OSVersion:	Other 1.0.0.0
Environment.Version:	8.0.7
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/
RuntimeInformation.FrameworkDescription:	.NET 8.0.7
RuntimeInformation.OSArchitecture:	Wasm
RuntimeInformation.OSDescription:	Browser
RuntimeInformation.RuntimeIdentifier:	browser-wasm
IntPtr.Size:	4
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	False
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844158	# 0x8177F802
VectorEnvironment.CpuModelName:	
VectorEnvironment.SupportedInstructionSets:	PackedSimd
Vector128s.Instance:	WVectorTraits128PackedSimd	// PackedSimd
Vectors.Instance:	VectorTraits128PackedSimd	// PackedSimd
Vectors.BaseInstance:	VectorTraits128Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	5597.396	46.833
SumWidenBcl	42654.167	6.146	0.131227
SumWidenVectorBase	42429.167	6.178	0.131923
SumWidenVectorBase_NRef	32054.167	8.178	0.174623
SumWidenVectorBase_NRef2	32927.083	7.961	0.169994
SumWidenVectorBase_NRefInc	32200.000	8.141	0.173832
SumWidenVectorBase_NRefInc2	35308.333	7.424	0.158529
SumWidenVectorBase_Ref	33716.667	7.775	0.166013
SumWidenVectorBase_Ref2	33420.833	7.844	0.167482
SumWidenVectorBase_RefInc	32045.833	8.180	0.174668
SumWidenVectorBase128_Ref	29125.000	9.001	0.192185
SumWidenVectorBase128_Ref2	28881.250	9.077	0.193807
SumWidenVectorBase128_RefI	28389.583	9.234	0.197164
SumWidenVectorBase128_RefI2	28839.583	9.090	0.194087
SumWidenVectorBase128_RefInc	29531.250	8.877	0.189541
SumWidenVectorBase128_RefInc2	29402.083	8.916	0.190374
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	39787.500	6.589	0.140682
SumWidenVectorTraits_Ptr	37704.167	6.953	0.148456
SumWidenVectorTraits_Tuple	64783.333	4.046	0.086402
SumWidenVector128Bcl	40720.833	6.438	0.137458
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	18560.417	14.124	0.301577
SumWidenVector128Traits_Tuple	40295.833	6.505	0.138908
SumWidenVector256Traits	66433.333	3.946	0.084256
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector512Bcl	104866.667	2.500	0.053376
SumWidenVector512Traits	67491.667	3.884	0.082935

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	5475.000	47.880
SumWidenBcl	11477.083	22.841	0.477038
SumWidenVectorBase	11683.333	22.437	0.468616
SumWidenVectorTraits	13101.042	20.009	0.417906
SumWidenVectorTraits_Ptr	13284.375	19.733	0.412138
SumWidenVectorTraits_Tuple	17316.667	15.138	0.316169
SumWidenVector128Bcl	15525.000	16.885	0.352657
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	19185.417	13.664	0.285373
SumWidenVector128Traits_Tuple	15912.500	16.474	0.344069
SumWidenVector256Traits	20416.667	12.840	0.268163
SumWidenVector256Avx_ConvertTo	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector256Avx_Unpack	Run fail! Requires hardware support Avx, Avx2!
SumWidenVector512Bcl	20435.417	12.828	0.267917
SumWidenVector512Traits	21664.583	12.100	0.252717

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	5648.958	46.406
SumWidenBcl	49683.333	5.276	0.113699
SumWidenVectorBase	51258.333	5.114	0.110206
SumWidenVectorTraits	139233.334	1.883	0.040572
SumWidenVectorTraits_Ptr	142833.334	1.835	0.039549
SumWidenVectorTraits_Tuple	75891.667	3.454	0.074435
SumWidenVector128Bcl	42045.833	6.235	0.134352
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!This process(32bit) is not 64-bit!
SumWidenVector128Traits	100075.000	2.619	0.056447
SumWidenVector128Traits_Tuple	44629.167	5.874	0.126575
SumWidenVector256Traits	70975.000	3.693	0.079591
SumWidenVector512Bcl	111883.333	2.343	0.050490
SumWidenVector512Traits	65883.333	3.979	0.085742

```

