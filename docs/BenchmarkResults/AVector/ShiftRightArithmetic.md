# Benchmark - ShiftRightArithmetic
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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	2130476158	# 0x7EFC7C7E
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	315.306	831.395
SumSRA_Base_Basic	252.141	1039.673	1.250517
SumSRA_Base	168.961	1551.510	1.866153
SumSRA_Base_Core	149.260	1756.290	2.112463
SumSRATraits	168.872	1552.321	1.867129
SumSRATraits_Core	153.906	1703.274	2.048694
SumSRAConstTraits	149.844	1749.451	2.104237
SumSRAConstTraits_Core	141.367	1854.357	2.230417
SumSRAFastTraits	161.735	1620.828	1.949529

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	315.540	830.778
SumSRA_Base_Basic	489.445	535.594	0.644690
SumSRA_Base	352.392	743.898	0.895423
SumSRA_Base_Core	318.899	822.029	0.989469
SumSRATraits	350.751	747.378	0.899613
SumSRATraits_Core	306.388	855.595	1.029872
SumSRAConstTraits	300.202	873.224	1.051092
SumSRAConstTraits_Core	283.573	924.433	1.112732
SumSRAFastTraits	316.792	827.497	0.996050

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	318.004	824.341
SumSRA_Base_Basic	605.251	433.116	0.525409
SumSRA_Base	589.982	444.326	0.539007
SumSRA_Base_Core	645.233	406.278	0.492852
SumSRATraits	589.623	444.596	0.539336
SumSRATraits_Core	623.660	420.331	0.509900
SumSRAConstTraits	485.501	539.946	0.655003
SumSRAConstTraits_Core	568.346	461.240	0.559526
SumSRAFastTraits	526.305	498.084	0.604221

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	312.582	838.640
SumSRA_Base_Basic	206.204	1271.287	1.515890
SumSRA_Base	84.405	3105.804	3.703380
SumSRA_Base_Core	74.695	3509.521	4.184775
SumSRATraits	84.686	3095.495	3.691088
SumSRATraits_Core	76.639	3420.508	4.078635
SumSRAConstTraits	75.032	3493.784	4.166010
SumSRAConstTraits_Core	70.945	3695.034	4.405983
SumSRAFastTraits	79.533	3296.059	3.930241

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
VectorTraitsGlobal.InitCheckSum:	2130476158	# 0x7EFC7C7E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	317.638	825.291
SumSRA_Base_Basic	251.451	1042.527	1.263223
SumSRA_Base	168.746	1553.481	1.882342
SumSRA_Base_Core	148.790	1761.835	2.134804
SumSRATraits	168.820	1552.797	1.881514
SumSRATraits_Core	156.491	1675.133	2.029747
SumSRAConstTraits	150.730	1739.167	2.107337
SumSRAConstTraits_Core	141.708	1849.886	2.241495
SumSRAFastTraits	158.927	1649.465	1.998646

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	314.098	834.594
SumSRA_Base_Basic	488.772	536.331	0.642626
SumSRA_Base	352.839	742.956	0.890201
SumSRA_Base_Core	319.406	820.723	0.983380
SumSRATraits	352.026	744.671	0.892256
SumSRATraits_Core	308.381	850.065	1.018537
SumSRAConstTraits	300.930	871.113	1.043757
SumSRAConstTraits_Core	282.295	928.618	1.112659
SumSRAFastTraits	317.555	825.507	0.989112

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	317.269	826.251
SumSRA_Base_Basic	559.851	468.239	0.566703
SumSRA_Base	560.519	467.681	0.566028
SumSRA_Base_Core	644.041	407.030	0.492622
SumSRATraits	558.733	469.176	0.567837
SumSRATraits_Core	618.864	423.589	0.512664
SumSRAConstTraits	484.957	540.551	0.654221
SumSRAConstTraits_Core	569.689	460.153	0.556916
SumSRAFastTraits	524.830	499.484	0.604518

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	312.600	838.592
SumSRA_Base_Basic	204.888	1279.452	1.525715
SumSRA_Base	84.645	3096.986	3.693079
SumSRA_Base_Core	74.860	3501.772	4.175777
SumSRATraits	84.471	3103.361	3.700681
SumSRATraits_Core	76.854	3410.951	4.067475
SumSRAConstTraits	75.011	3494.747	4.167400
SumSRAConstTraits_Core	70.829	3701.103	4.413473
SumSRAFastTraits	79.380	3302.410	3.938042

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
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	220.963	1186.371
SumSRA_Base_Basic	271.333	966.134	0.814361
SumSRA_Base	175.417	1494.403	1.259643
SumSRA_Base_Core	154.628	1695.321	1.428998
SumSRA_Avx2	14.769	17749.684	14.961329
SumSRATraits	14.813	17697.463	14.917312
SumSRATraits_Core	14.339	18282.060	15.410073
SumSRAConstTraits	14.830	17676.100	14.899304
SumSRAConstTraits_Core	13.667	19180.978	16.167777
SumSRAFast_Avx2	14.693	17840.876	15.038195
SumSRAFastTraits	14.392	18215.047	15.353587

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	196.929	1331.158
SumSRA_Base_Basic	501.086	523.152	0.393005
SumSRA_Base	341.395	767.862	0.576838
SumSRA_Base_Core	309.037	848.261	0.637235
SumSRA_Avx2	32.119	8161.658	6.131246
SumSRATraits	29.135	8997.447	6.759112
SumSRATraits_Core	24.573	10667.783	8.013911
SumSRAConstTraits	31.156	8413.944	6.320770
SumSRAConstTraits_Core	24.601	10655.919	8.004998
SumSRAFast_Avx2	31.077	8435.303	6.336815
SumSRAFastTraits	29.628	8847.752	6.646657

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	200.898	1304.863
SumSRA_Base_Basic	539.958	485.489	0.372062
SumSRA_Base	542.340	483.358	0.370428
SumSRA_Base_Core	621.031	422.111	0.323491
SumSRA_Avx2	112.208	2336.230	1.790403
SumSRATraits	117.580	2229.499	1.708608
SumSRATraits_Core	75.075	3491.771	2.675968
SumSRAConstTraits	107.495	2438.654	1.868897
SumSRAConstTraits_Core	70.490	3718.894	2.850027
SumSRAFast_Avx2	110.542	2371.443	1.817389
SumSRAFastTraits	108.910	2406.983	1.844625

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	235.014	1115.439
SumSRA_Base_Basic	224.281	1168.817	1.047854
SumSRA_Base	87.870	2983.306	2.674557
SumSRA_Base_Core	77.339	3389.525	3.038735
SumSRA_Avx2	17.261	15187.112	13.615362
SumSRATraits	16.571	15819.894	14.182657
SumSRATraits_Core	10.683	24539.183	21.999567
SumSRAConstTraits	12.967	20216.123	18.123910
SumSRAConstTraits_Core	9.070	28901.754	25.910645
SumSRAFast_Avx2	12.318	21280.698	19.078309
SumSRAFastTraits	22.938	11428.157	10.245431

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	365.569	717.085
SumSRA_Base_Basic	447.024	586.420	0.817784
SumSRA_Base	266.248	984.584	1.373037
SumSRA_Base_Core	247.142	1060.700	1.479183
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	24.697	10614.203	14.801875
SumSRATraits	21.509	12187.852	16.996383
SumSRATraits_Core	15.077	17386.455	24.246015
SumSRAConstTraits	15.356	17071.651	23.807010
SumSRAConstTraits_Core	15.899	16487.586	22.992512
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	16.049	16333.993	22.778320
SumSRAFastTraits	15.130	17325.813	24.161447

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	199.081	1316.772
SumSRA_Base_Basic	577.489	453.938	0.344735
SumSRA_Base	380.329	689.256	0.523443
SumSRA_Base_Core	356.914	734.474	0.557784
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	32.398	8091.390	6.144866
SumSRATraits	34.946	7501.443	5.696842
SumSRATraits_Core	27.042	9693.943	7.361898
SumSRAConstTraits	26.384	9935.786	7.545561
SumSRAConstTraits_Core	25.112	10439.092	7.927789
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	28.465	9209.283	6.993832
SumSRAFastTraits	28.748	9118.616	6.924976

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	199.826	1311.859
SumSRA_Base_Basic	591.066	443.510	0.338078
SumSRA_Base	590.777	443.728	0.338243
SumSRA_Base_Core	637.315	411.325	0.313544
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	110.281	2377.066	1.811983
SumSRATraits	111.799	2344.783	1.787374
SumSRATraits_Core	76.560	3424.020	2.610052
SumSRAConstTraits	112.298	2334.351	1.779422
SumSRAConstTraits_Core	77.863	3366.730	2.566381
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	110.572	2370.796	1.807204
SumSRAFastTraits	109.674	2390.220	1.822010

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	241.927	1083.566
SumSRA_Base_Basic	253.100	1035.732	0.955855
SumSRA_Base	82.005	3196.698	2.950165
SumSRA_Base_Core	77.275	3392.347	3.130725
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	16.372	16011.957	14.777098
SumSRATraits	16.482	15904.386	14.677823
SumSRATraits_Core	9.959	26322.594	24.292568
SumSRAConstTraits	10.420	25158.517	23.218266
SumSRAConstTraits_Core	8.455	31004.968	28.613832
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	10.770	24340.956	22.463756
SumSRAFastTraits	10.344	25341.893	23.387500

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	225.794	1160.986
SumSRA_Base_Basic	311.494	841.571	0.724876
SumSRA_Base	193.968	1351.478	1.164078
SumSRA_Base_Core	159.138	1647.273	1.418857
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	15.211	17233.336	14.843711
SumSRATraits	16.154	16227.890	13.977683
SumSRATraits_Core	13.525	19382.840	16.695158
SumSRAConstTraits	13.329	19667.458	16.940310
SumSRAConstTraits_Core	13.316	19685.816	16.956122
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	14.129	18553.536	15.980848
SumSRAFastTraits	13.654	19198.820	16.536654

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	160.175	1636.611
SumSRA_Base_Basic	507.553	516.486	0.315582
SumSRA_Base	339.236	772.747	0.472163
SumSRA_Base_Core	319.987	819.233	0.500567
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	30.536	8584.613	5.245360
SumSRATraits	32.806	7990.775	4.882514
SumSRATraits_Core	22.270	11771.379	7.192534
SumSRAConstTraits	24.919	10519.995	6.427915
SumSRAConstTraits_Core	26.608	9852.050	6.019788
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	26.305	9965.608	6.089174
SumSRAFastTraits	26.168	10017.603	6.120944

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	200.640	1306.540
SumSRA_Base_Basic	560.326	467.842	0.358077
SumSRA_Base	541.974	483.684	0.370202
SumSRA_Base_Core	621.081	422.077	0.323049
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	121.200	2162.907	1.655446
SumSRATraits	120.951	2167.350	1.658846
SumSRATraits_Core	87.969	2979.956	2.280799
SumSRAConstTraits	83.451	3141.279	2.404273
SumSRAConstTraits_Core	72.824	3599.670	2.755116
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	111.270	2355.924	1.803178
SumSRAFastTraits	108.820	2408.959	1.843770

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	195.048	1343.995
SumSRA_Base_Basic	221.584	1183.043	0.880244
SumSRA_Base	84.081	3117.764	2.319774
SumSRA_Base_Core	77.154	3397.651	2.528024
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	16.969	15448.248	11.494279
SumSRATraits	16.230	16151.959	12.017875
SumSRATraits_Core	8.384	31266.900	23.264156
SumSRAConstTraits	8.645	30324.127	22.562685
SumSRAConstTraits_Core	8.381	31277.924	23.272359
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	9.602	27299.860	20.312478
SumSRAFastTraits	9.615	27263.001	20.285053

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
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	171.229	1530.954
SumSRANetBcl	13.976	18756.271	12.251365
SumSRANetBcl_Const	14.569	17993.370	11.753048
SumSRA_Base_Basic	221.648	1182.704	0.772528
SumSRA_Base	14.930	17558.252	11.468834
SumSRA_Base_Core	13.869	18900.966	12.345878
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	16.126	16256.229	10.618369
SumSRATraits	15.697	16700.509	10.908567
SumSRATraits_Core	13.395	19569.672	12.782669
SumSRAConstTraits	12.723	20604.672	13.458718
SumSRAConstTraits_Core	12.689	20659.815	13.494737
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	13.426	19525.249	12.753652
SumSRAFastTraits	13.215	19836.618	12.957034

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	122.952	2132.092
SumSRANetBcl	26.099	10044.358	4.711034
SumSRANetBcl_Const	25.341	10344.479	4.851798
SumSRA_Base_Basic	515.298	508.723	0.238603
SumSRA_Base	26.457	9908.423	4.647278
SumSRA_Base_Core	26.575	9864.151	4.626513
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	29.060	9020.731	4.230930
SumSRATraits	29.264	8958.028	4.201520
SumSRATraits_Core	23.395	11205.294	5.255540
SumSRAConstTraits	24.745	10594.020	4.968838
SumSRAConstTraits_Core	26.119	10036.706	4.707445
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	30.026	8730.452	4.094782
SumSRAFastTraits	25.835	10146.827	4.759095

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	158.911	1649.628
SumSRANetBcl	447.957	585.199	0.354746
SumSRANetBcl_Const	467.341	560.927	0.340032
SumSRA_Base_Basic	541.097	484.468	0.293683
SumSRA_Base	117.641	2228.346	1.350817
SumSRA_Base_Core	92.571	2831.810	1.716636
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	117.518	2230.673	1.352228
SumSRATraits	118.999	2202.901	1.335392
SumSRATraits_Core	69.076	3794.994	2.300515
SumSRAConstTraits	83.184	3151.375	1.910355
SumSRAConstTraits_Core	71.807	3650.650	2.213014
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	107.719	2433.581	1.475230
SumSRAFastTraits	108.759	2410.313	1.461125

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	162.310	1615.084
SumSRANetBcl	229.024	1144.616	0.708704
SumSRANetBcl_Const	229.715	1141.171	0.706570
SumSRA_Base_Basic	211.103	1241.785	0.768867
SumSRA_Base	15.362	17064.554	10.565736
SumSRA_Base_Core	10.237	25607.493	15.855206
SumSRA_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRA_Avx2	14.951	17533.072	10.855825
SumSRATraits	16.101	16280.942	10.080553
SumSRATraits_Core	7.795	33629.810	20.822325
SumSRAConstTraits	9.025	29045.965	17.984179
SumSRAConstTraits_Core	8.123	32270.463	19.980668
SumSRAFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSRAFast_Avx2	9.357	28014.496	17.345532
SumSRAFastTraits	9.433	27790.252	17.206689

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
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	440.527	595.069
SumSRA_Base_Basic	515.625	508.401	0.854357
SumSRA_Base	190.211	1378.172	2.315989
SumSRA_Base_Core	146.550	1788.764	3.005979
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	161.765	1620.520	2.723248
SumSRATraits_Core	143.556	1826.074	3.068678
SumSRAConstTraits	165.796	1581.126	2.657048
SumSRAConstTraits_Core	139.600	1877.828	3.155650
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	143.683	1824.457	3.065960

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	361.992	724.170
SumSRA_Base_Basic	820.484	319.499	0.441193
SumSRA_Base	385.092	680.731	0.940015
SumSRA_Base_Core	296.357	884.554	1.221472
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	328.042	799.116	1.103492
SumSRATraits_Core	715.827	366.212	0.505698
SumSRAConstTraits	333.602	785.799	1.085103
SumSRAConstTraits_Core	284.772	920.541	1.271166
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	293.239	893.961	1.234462

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	364.301	719.580
SumSRA_Base_Basic	564.781	464.151	0.645030
SumSRA_Base	550.317	476.350	0.661984
SumSRA_Base_Core	587.355	446.313	0.620241
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	568.535	461.087	0.640772
SumSRATraits_Core	589.308	444.833	0.618184
SumSRAConstTraits	558.611	469.278	0.652156
SumSRAConstTraits_Core	580.929	451.250	0.627102
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	575.604	455.424	0.632903

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	437.091	599.746
SumSRA_Base_Basic	374.904	699.230	1.165876
SumSRA_Base	96.886	2705.686	4.511383
SumSRA_Base_Core	72.219	3629.869	6.052339
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	82.872	3163.252	5.274315
SumSRATraits_Core	72.758	3602.976	6.007498
SumSRAConstTraits	82.865	3163.517	5.274757
SumSRAConstTraits_Core	70.445	3721.236	6.204682
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	73.117	3585.268	5.977972

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
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
Check-SumSRAConstTraits	Fail! Check `SumSRAConstTraits` fail! -24614!=-12499
SumSRAScalar	432.985	605.434
SumSRA_Base_Basic	501.835	522.371	0.862804
SumSRA_Base	181.695	1442.768	2.383032
SumSRA_Base_Core	135.968	1927.981	3.184462
SumSRA_AdvSimd	53.423	4906.934	8.104824
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	47.104	5565.239	9.192151
SumSRATraits_Core	33.884	7736.523	12.778479
SumSRAConstTraits	34.308	7640.971	12.620654
SumSRAConstTraits_Core	33.913	7729.829	12.767422
SumSRAFast_AdvSimd	40.419	6485.611	10.712337
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	34.219	7660.815	12.653432

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	351.949	744.836
SumSRA_Base_Basic	794.257	330.049	0.443117
SumSRA_Base	363.512	721.143	0.968191
SumSRA_Base_Core	271.902	964.111	1.294394
SumSRA_AdvSimd	93.637	2799.579	3.758654
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	89.382	2932.853	3.937584
SumSRATraits_Core	63.470	4130.188	5.545100
SumSRAConstTraits	80.398	3260.589	4.377596
SumSRAConstTraits_Core	63.593	4122.246	5.534438
SumSRAFast_AdvSimd	68.121	3848.197	5.166506
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	68.026	3853.562	5.173708

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	354.602	739.262
SumSRA_Base_Basic	543.015	482.757	0.653025
SumSRA_Base	543.928	481.946	0.651929
SumSRA_Base_Core	546.070	480.056	0.649372
SumSRA_AdvSimd	213.600	1227.264	1.660119
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	186.463	1405.880	1.901733
SumSRATraits_Core	124.881	2099.154	2.839525
SumSRAConstTraits	134.060	1955.425	2.645104
SumSRAConstTraits_Core	133.476	1963.986	2.656684
SumSRAFast_AdvSimd	134.187	1953.566	2.642588
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	134.620	1947.289	2.634098

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	430.424	609.036
SumSRA_Base_Basic	369.738	709.000	1.164133
SumSRA_Base	91.157	2875.757	4.721815
SumSRA_Base_Core	67.277	3896.489	6.397793
SumSRA_AdvSimd	26.562	9869.057	16.204379
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	26.578	9863.100	16.194598
SumSRATraits_Core	16.620	15772.364	25.897243
SumSRAConstTraits	19.934	13150.335	21.592035
SumSRAConstTraits_Core	16.687	15709.181	25.793501
SumSRAFast_AdvSimd	19.839	13213.692	21.696062
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	19.828	13221.024	21.708102

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
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	432.000	606.815
SumSRA_Base_Basic	499.948	524.343	0.864089
SumSRA_Base	167.707	1563.104	2.575914
SumSRA_Base_Core	326.363	803.228	1.323678
SumSRA_AdvSimd	53.113	4935.630	8.133662
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	52.989	4947.109	8.152578
SumSRATraits_Core	31.295	8376.507	13.804048
SumSRAConstTraits	31.293	8377.006	13.804871
SumSRAConstTraits_Core	31.290	8377.950	13.806427
SumSRAFast_AdvSimd	31.269	8383.421	13.815442
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	33.179	7900.983	13.020410

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	350.678	747.534
SumSRA_Base_Basic	795.128	329.688	0.441034
SumSRA_Base	337.928	775.740	1.037732
SumSRA_Base_Core	270.056	970.704	1.298541
SumSRA_AdvSimd	89.059	2943.503	3.937618
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	93.570	2801.567	3.747745
SumSRATraits_Core	67.339	3892.927	5.207691
SumSRAConstTraits	63.441	4132.061	5.527588
SumSRAConstTraits_Core	63.544	4125.361	5.518627
SumSRAFast_AdvSimd	67.377	3890.686	5.204694
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	63.410	4134.142	5.530373

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	353.349	741.885
SumSRA_Base_Basic	542.853	482.900	0.650910
SumSRA_Base	542.741	483.000	0.651045
SumSRA_Base_Core	540.889	484.654	0.653274
SumSRA_AdvSimd	186.826	1403.145	1.891326
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	212.603	1233.020	1.662010
SumSRATraits_Core	133.301	1966.555	2.650755
SumSRAConstTraits	133.122	1969.201	2.654323
SumSRAConstTraits_Core	124.966	2097.725	2.827562
SumSRAFast_AdvSimd	125.166	2094.376	2.823048
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	125.049	2096.336	2.825690

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	402.421	651.417
SumSRA_Base_Basic	368.989	710.438	1.090604
SumSRA_Base	84.577	3099.473	4.758049
SumSRA_Base_Core	151.061	1735.346	2.663956
SumSRA_AdvSimd	26.543	9876.357	15.161346
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	26.516	9886.169	15.176408
SumSRATraits_Core	16.578	15812.670	24.274270
SumSRAConstTraits	16.574	15816.435	24.280050
SumSRAConstTraits_Core	15.607	16796.769	25.784975
SumSRAFast_AdvSimd	15.572	16833.801	25.841824
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	15.592	16812.338	25.808876

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
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	-2131134082	# 0x80F9797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ShiftRightArithmeticConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-12499
SumSRAScalar	322.555	812.710
SumSRANetBcl	27.242	9622.657	11.840207
SumSRANetBcl_Const	27.256	9617.911	11.834367
SumSRA_Base_Basic	485.797	539.616	0.663971
SumSRA_Base	26.967	9720.837	11.961013
SumSRA_Base_Core	27.265	9614.609	11.830304
SumSRA_AdvSimd	46.962	5581.987	6.868361
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	46.965	5581.673	6.867975
SumSRATraits_Core	27.295	9604.042	11.817302
SumSRAConstTraits	27.314	9597.359	11.809079
SumSRAConstTraits_Core	27.377	9575.299	11.781935
SumSRAFast_AdvSimd	27.131	9662.285	11.888967
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	27.244	9622.087	11.839505

[ShiftRightArithmeticConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	1913540397
SumSRAScalar	226.164	1159.088
SumSRANetBcl	54.839	4780.214	4.124117
SumSRANetBcl_Const	54.392	4819.563	4.158065
SumSRA_Base_Basic	783.223	334.699	0.288761
SumSRA_Base	54.747	4788.298	4.131091
SumSRA_Base_Core	54.731	4789.653	4.132260
SumSRA_AdvSimd	81.118	3231.651	2.788098
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	80.718	3247.648	2.801900
SumSRATraits_Core	54.400	4818.781	4.157390
SumSRAConstTraits	54.709	4791.612	4.133950
SumSRAConstTraits_Core	54.900	4774.969	4.119592
SumSRAFast_AdvSimd	54.907	4774.314	4.119027
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	54.884	4776.308	4.120746

[ShiftRightArithmeticConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	-6268185905068837132
SumSRAScalar	227.788	1150.826
SumSRANetBcl	107.324	2442.540	2.122422
SumSRANetBcl_Const	107.543	2437.570	2.118104
SumSRA_Base_Basic	556.212	471.303	0.409534
SumSRA_Base	320.887	816.935	0.709869
SumSRA_Base_Core	185.975	1409.567	1.224830
SumSRA_AdvSimd	185.902	1410.118	1.225309
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	186.679	1404.248	1.220209
SumSRATraits_Core	106.613	2458.848	2.136593
SumSRAConstTraits	107.784	2432.131	2.113378
SumSRAConstTraits_Core	107.487	2438.851	2.119217
SumSRAFast_AdvSimd	107.604	2436.191	2.116906
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	106.503	2461.377	2.138791

[ShiftRightArithmeticConstBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumSRAScalar	97
SumSRAScalar	295.534	887.017
SumSRANetBcl	13.255	19776.310	22.295299
SumSRANetBcl_Const	13.275	19747.444	22.262756
SumSRA_Base_Basic	348.760	751.645	0.847385
SumSRA_Base	38.286	6846.953	7.719077
SumSRA_Base_Core	23.385	11209.760	12.637594
SumSRA_AdvSimd	23.340	11231.568	12.662179
SumSRA_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRATraits	23.283	11259.137	12.693260
SumSRATraits_Core	13.329	19667.777	22.172942
SumSRAConstTraits	13.250	19784.672	22.304726
SumSRAConstTraits_Core	13.350	19635.698	22.136777
SumSRAFast_AdvSimd	13.309	19697.044	22.205937
SumSRAFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSRAFastTraits	13.386	19583.392	22.077809

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

