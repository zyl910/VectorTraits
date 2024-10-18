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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9232.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks/bin/Release/Release/System.Numerics.Vectors.DLL
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
SumWidenScalar	93.252	2811.137
SumWidenBcl	30.244	8667.719	3.083350
SumWidenVectorBase	30.205	8678.694	3.087254
SumWidenVectorBase_NRef	360.108	727.960	0.258956
SumWidenVectorBase_NRef2	371.341	705.938	0.251122
SumWidenVectorBase_NRefInc	364.517	719.154	0.255823
SumWidenVectorBase_NRefInc2	357.199	733.887	0.261064
SumWidenVectorBase_Ref	370.837	706.898	0.251464
SumWidenVectorBase_Ref2	391.246	670.024	0.238346
SumWidenVectorBase_RefInc	360.319	727.533	0.258804
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	294.522	890.065	0.316621
SumWidenVectorBase256_Ref2	295.087	888.362	0.316015
SumWidenVectorBase256_RefI	370.778	707.010	0.251503
SumWidenVectorBase256_RefI2	371.285	706.046	0.251160
SumWidenVectorBase256_RefInc	369.349	709.745	0.252476
SumWidenVectorBase256_RefInc2	368.547	711.290	0.253026
SumWidenVectorTraits	25.103	10442.853	3.714815
SumWidenVectorTraits_Ptr	25.155	10421.103	3.707078

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	162.186	1616.316
SumWidenBcl	6.191	42340.276	26.195537
SumWidenVectorBase	7.468	35101.891	21.717215
SumWidenVectorTraits	7.395	35448.572	21.931704
SumWidenVectorTraits_Ptr	6.245	41973.700	25.968740

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194
SumWidenScalar	230.239	1138.573
SumWidenBcl	29.206	8975.802	7.883375
SumWidenVectorBase	29.256	8960.258	7.869723
SumWidenVectorTraits	29.276	8954.213	7.864414
SumWidenVectorTraits_Ptr	29.283	8952.165	7.862615

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
SumWidenScalar	82.903	3162.071
SumWidenBcl	25.435	10306.513	3.259419
SumWidenVectorBase	25.305	10359.422	3.276151
SumWidenVectorBase_NRef	343.685	762.745	0.241217
SumWidenVectorBase_NRef2	347.149	755.133	0.238810
SumWidenVectorBase_NRefInc	338.755	773.846	0.244728
SumWidenVectorBase_NRefInc2	342.229	765.990	0.242243
SumWidenVectorBase_Ref	293.939	891.832	0.282041
SumWidenVectorBase_Ref2	341.940	766.637	0.242448
SumWidenVectorBase_RefInc	337.733	776.188	0.245468
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	277.920	943.235	0.298297
SumWidenVectorBase256_Ref2	275.868	950.250	0.300515
SumWidenVectorBase256_RefI	338.859	773.608	0.244652
SumWidenVectorBase256_RefI2	340.308	770.313	0.243610
SumWidenVectorBase256_RefInc	344.872	760.120	0.240387
SumWidenVectorBase256_RefInc2	338.400	774.657	0.244984
SumWidenVectorTraits	30.196	8681.449	2.745495
SumWidenVectorTraits_Ptr	25.369	10333.406	3.267924

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	160.790	1630.352
SumWidenBcl	6.209	42221.963	25.897459
SumWidenVectorBase	6.190	42347.742	25.974608
SumWidenVectorTraits	6.251	41937.286	25.722848
SumWidenVectorTraits_Ptr	6.324	41452.949	25.425773

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194
SumWidenScalar	231.043	1134.610
SumWidenBcl	29.251	8961.800	7.898576
SumWidenVectorBase	29.550	8871.159	7.818688
SumWidenVectorTraits	29.444	8903.246	7.846968
SumWidenVectorTraits_Ptr	29.418	8911.029	7.853828

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
SumWidenScalar	98.010	2674.675
SumWidenBcl	25.431	10308.000	3.853927
SumWidenVectorBase	25.280	10369.776	3.877023
SumWidenVectorBase_NRef	341.961	766.590	0.286611
SumWidenVectorBase_NRef2	343.203	763.815	0.285573
SumWidenVectorBase_NRefInc	339.030	773.218	0.289089
SumWidenVectorBase_NRefInc2	340.263	770.415	0.288041
SumWidenVectorBase_Ref	314.516	833.483	0.311620
SumWidenVectorBase_Ref2	341.023	768.698	0.287399
SumWidenVectorBase_RefInc	337.205	777.402	0.290653
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	276.889	946.746	0.353967
SumWidenVectorBase256_Ref2	274.701	954.289	0.356787
SumWidenVectorBase256_RefI	339.528	772.084	0.288665
SumWidenVectorBase256_RefI2	340.105	770.774	0.288175
SumWidenVectorBase256_RefInc	345.221	759.351	0.283904
SumWidenVectorBase256_RefInc2	340.618	769.614	0.287741
SumWidenVectorTraits	17.778	14745.017	5.512826
SumWidenVectorTraits_Ptr	17.659	14844.648	5.550076
SumWidenVector128Traits	34.550	7587.392	2.836753
SumWidenVector256Traits	17.935	14616.422	5.464747
SumWidenVector256Avx_ConvertTo	17.680	14827.007	5.543481
SumWidenVector256Avx_Unpack	24.746	10593.407	3.960634

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	161.888	1619.290
SumWidenBcl	6.189	42354.483	26.156200
SumWidenVectorBase	6.177	42441.825	26.210139
SumWidenVectorTraits	6.203	42261.452	26.098749
SumWidenVectorTraits_Ptr	6.219	42151.696	26.030968
SumWidenVector128Traits	8.477	30922.567	19.096370
SumWidenVector256Traits	4.246	61737.560	38.126306
SumWidenVector256Avx_ConvertTo	4.260	61541.726	38.005368
SumWidenVector256Avx_Unpack	6.097	42998.842	26.554127

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	231.142	1134.125
SumWidenBcl	29.585	8860.711	7.812816
SumWidenVectorBase	29.353	8930.858	7.874667
SumWidenVectorTraits	29.395	8918.060	7.863382
SumWidenVectorTraits_Ptr	29.399	8916.814	7.862284
SumWidenVector128Traits	57.638	4548.111	4.010237
SumWidenVector256Traits	29.634	8845.920	7.799774

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
SumWidenScalar	101.722	2577.063
SumWidenBcl	25.009	10481.901	4.067383
SumWidenVectorBase	25.130	10431.469	4.047814
SumWidenVectorBase_NRef	271.553	965.350	0.374593
SumWidenVectorBase_NRef2	272.760	961.078	0.372936
SumWidenVectorBase_NRefInc	307.768	851.760	0.330516
SumWidenVectorBase_NRefInc2	275.239	952.422	0.369577
SumWidenVectorBase_Ref	282.825	926.878	0.359664
SumWidenVectorBase_Ref2	282.345	928.451	0.360275
SumWidenVectorBase_RefInc	310.802	843.444	0.327289
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	251.343	1042.975	0.404715
SumWidenVectorBase256_Ref2	252.084	1039.908	0.403524
SumWidenVectorBase256_RefI	324.220	808.538	0.313744
SumWidenVectorBase256_RefI2	322.303	813.347	0.315610
SumWidenVectorBase256_RefInc	327.950	799.342	0.310176
SumWidenVectorBase256_RefInc2	312.464	838.957	0.325548
SumWidenVectorTraits	17.759	14761.357	5.727977
SumWidenVectorTraits_Ptr	17.655	14848.314	5.761720
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	34.102	7687.085	2.982887
SumWidenVector256Traits	17.799	14728.120	5.715080
SumWidenVector256Avx_ConvertTo	17.625	14873.468	5.771481
SumWidenVector256Avx_Unpack	24.568	10669.980	4.140365

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	161.329	1624.899
SumWidenBcl	6.249	41952.695	25.818645
SumWidenVectorBase	6.186	42374.186	26.078040
SumWidenVectorTraits	6.233	42056.944	25.882802
SumWidenVectorTraits_Ptr	6.137	42715.967	26.288380
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	8.474	30934.769	19.037962
SumWidenVector256Traits	4.208	62302.261	38.342232
SumWidenVector256Avx_ConvertTo	4.237	61872.077	38.077487
SumWidenVector256Avx_Unpack	6.096	42999.954	26.463152

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	231.197	1133.856
SumWidenBcl	29.201	8977.077	7.917299
SumWidenVectorBase	29.415	8911.978	7.859885
SumWidenVectorTraits	29.502	8885.720	7.836727
SumWidenVectorTraits_Ptr	29.626	8848.573	7.803965
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	57.733	4540.640	4.004600
SumWidenVector256Traits	29.552	8870.572	7.823367

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.29
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.29\
RuntimeInformation.FrameworkDescription:	.NET 6.0.29
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.29/System.Private.CoreLib.dll
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
SumWidenScalar	92.512	2833.623
SumWidenBcl	24.902	10527.026	3.715041
SumWidenVectorBase	24.886	10533.976	3.717493
SumWidenVectorBase_NRef	273.426	958.739	0.338344
SumWidenVectorBase_NRef2	273.288	959.223	0.338515
SumWidenVectorBase_NRefInc	306.586	855.042	0.301749
SumWidenVectorBase_NRefInc2	272.368	962.464	0.339658
SumWidenVectorBase_Ref	283.219	925.587	0.326644
SumWidenVectorBase_Ref2	282.687	927.329	0.327259
SumWidenVectorBase_RefInc	308.315	850.247	0.300057
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	251.452	1042.521	0.367911
SumWidenVectorBase256_Ref2	252.209	1039.393	0.366807
SumWidenVectorBase256_RefI	323.236	810.999	0.286206
SumWidenVectorBase256_RefI2	322.835	812.007	0.286561
SumWidenVectorBase256_RefInc	328.078	799.030	0.281982
SumWidenVectorBase256_RefInc2	314.847	832.607	0.293831
SumWidenVectorTraits	17.496	14982.852	5.287524
SumWidenVectorTraits_Ptr	17.491	14987.428	5.289139
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	34.179	7669.695	2.706674
SumWidenVector256Traits	17.566	14923.775	5.266675
SumWidenVector256Avx_ConvertTo	17.595	14899.142	5.257982
SumWidenVector256Avx_Unpack	24.207	10829.151	3.821662

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	179.910	1457.082
SumWidenBcl	6.148	42641.993	29.265326
SumWidenVectorBase	6.144	42668.194	29.283308
SumWidenVectorTraits	6.144	42667.371	29.282744
SumWidenVectorTraits_Ptr	6.139	42702.362	29.306758
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	8.400	31206.130	21.416860
SumWidenVector256Traits	4.220	62118.732	42.632270
SumWidenVector256Avx_ConvertTo	4.234	61917.597	42.494231
SumWidenVector256Avx_Unpack	5.985	43803.070	30.062177

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	230.043	1139.544
SumWidenBcl	29.224	8970.061	7.871623
SumWidenVectorBase	29.073	9016.800	7.912639
SumWidenVectorTraits	29.050	9023.996	7.918953
SumWidenVectorTraits_Ptr	29.518	8880.725	7.793227
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	57.493	4559.570	4.001224
SumWidenVector256Traits	29.262	8958.543	7.861516

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.18
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.18\
RuntimeInformation.FrameworkDescription:	.NET 7.0.18
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.18/System.Private.CoreLib.dll
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
SumWidenScalar	82.549	3175.634
SumWidenBcl	17.515	14966.898	4.713042
SumWidenVectorBase	17.585	14907.018	4.694186
SumWidenVectorBase_NRef	326.337	803.293	0.252955
SumWidenVectorBase_NRef2	331.725	790.245	0.248846
SumWidenVectorBase_NRefInc	309.604	846.708	0.266627
SumWidenVectorBase_NRefInc2	271.842	964.326	0.303664
SumWidenVectorBase_Ref	290.907	901.125	0.283762
SumWidenVectorBase_Ref2	325.476	805.418	0.253624
SumWidenVectorBase_RefInc	307.105	853.596	0.268796
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	249.983	1048.648	0.330217
SumWidenVectorBase256_Ref2	252.211	1039.383	0.327299
SumWidenVectorBase256_RefI	328.392	798.265	0.251372
SumWidenVectorBase256_RefI2	329.575	795.401	0.250470
SumWidenVectorBase256_RefInc	327.197	801.180	0.252290
SumWidenVectorBase256_RefInc2	317.530	825.572	0.259971
SumWidenVectorTraits	17.829	14703.416	4.630072
SumWidenVectorTraits_Ptr	18.023	14544.951	4.580172
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	33.751	7767.049	2.445826
SumWidenVector256Traits	18.057	14517.797	4.571621
SumWidenVector256Avx_ConvertTo	17.375	15087.456	4.751006
SumWidenVector256Avx_Unpack	24.588	10661.372	3.357242

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	152.904	1714.438
SumWidenBcl	4.224	62053.754	36.194802
SumWidenVectorBase	4.199	62432.136	36.415506
SumWidenVectorTraits	4.195	62489.014	36.448681
SumWidenVectorTraits_Ptr	4.263	61498.642	35.871016
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	7.944	33000.424	19.248535
SumWidenVector256Traits	4.212	62235.974	36.301088
SumWidenVector256Avx_ConvertTo	4.173	62824.434	36.644326
SumWidenVector256Avx_Unpack	6.041	43396.878	25.312593

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	229.637	1141.560
SumWidenBcl	29.292	8949.376	7.839602
SumWidenVectorBase	29.359	8929.041	7.821789
SumWidenVectorTraits	29.192	8980.015	7.866442
SumWidenVectorTraits_Ptr	29.104	9007.059	7.890132
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	57.552	4554.921	3.990085
SumWidenVector256Traits	29.292	8949.369	7.839597

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.4
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.4\
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
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
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.4/System.Private.CoreLib.dll
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
SumWidenScalar	83.137	3153.161
SumWidenBcl	18.116	14469.941	4.589026
SumWidenVectorBase	18.368	14271.703	4.526157
SumWidenVectorBase_NRef	345.711	758.276	0.240481
SumWidenVectorBase_NRef2	345.434	758.882	0.240673
SumWidenVectorBase_NRefInc	344.417	761.125	0.241385
SumWidenVectorBase_NRefInc2	331.732	790.228	0.250615
SumWidenVectorBase_Ref	337.231	777.343	0.246528
SumWidenVectorBase_Ref2	345.937	757.779	0.240323
SumWidenVectorBase_RefInc	343.358	763.472	0.242129
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ref	260.742	1005.376	0.318847
SumWidenVectorBase256_Ref2	261.282	1003.301	0.318189
SumWidenVectorBase256_RefI	329.513	795.551	0.252303
SumWidenVectorBase256_RefI2	327.360	800.783	0.253962
SumWidenVectorBase256_RefInc	345.284	759.213	0.240778
SumWidenVectorBase256_RefInc2	345.613	758.491	0.240549
SumWidenVectorTraits	18.152	14441.459	4.579994
SumWidenVectorTraits_Ptr	18.286	14336.149	4.546595
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	33.609	7799.761	2.473632
SumWidenVector256Traits	18.575	14112.817	4.475768
SumWidenVector256Avx_ConvertTo	18.491	14177.154	4.496171
SumWidenVector256Avx_Unpack	25.313	10356.091	3.284352
SumWidenVector512Bcl	15.653	16747.420	5.311311
SumWidenVector512Traits	15.570	16836.136	5.339446

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
Check-SumWidenVector256Avx_Unpack	Check `SumWidenVector256Avx_Unpack` mismatch. 14873!=6514
SumWidenScalar	152.656	1717.219
SumWidenBcl	4.283	61202.322	35.640362
SumWidenVectorBase	4.234	61915.299	36.055555
SumWidenVectorTraits	4.179	62724.259	36.526641
SumWidenVectorTraits_Ptr	4.253	61636.940	35.893456
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	7.990	32808.183	19.105411
SumWidenVector256Traits	4.181	62695.836	36.510090
SumWidenVector256Avx_ConvertTo	4.277	61288.922	35.690792
SumWidenVector256Avx_Unpack	6.133	42741.890	24.890174
SumWidenVector512Bcl	3.745	70004.821	40.766381
SumWidenVector512Traits	3.761	69699.484	40.588572

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	230.262	1138.458
SumWidenBcl	29.300	8946.802	7.858700
SumWidenVectorBase	29.191	8980.254	7.888083
SumWidenVectorTraits	28.955	9053.650	7.952554
SumWidenVectorTraits_Ptr	29.401	8916.157	7.831782
SumWidenVector128_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	57.654	4546.809	3.993831
SumWidenVector256Traits	29.199	8977.957	7.886066
SumWidenVector512Bcl	23.663	11078.144	9.730830
SumWidenVector512Traits	23.641	11088.613	9.740026

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

