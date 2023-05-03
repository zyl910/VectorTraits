# Benchmark - sample
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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	472.355	554.973
SumYShuffleG4VectorTraits	437.582	599.074	1.079466
SumYShuffleG4X2VectorTraits	442.131	592.911	1.068360
SumYShuffleG4X2VectorTraits_Tuple	473.229	553.948	0.998153
SumYShuffleG4X2_ConstVectorTraits	438.804	597.406	1.076460
SumYShuffleG4X2_ConstVectorTraits_Tuple	473.764	553.322	0.997025

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	531.222	493.473
SumYShuffleG4VectorTraits	521.486	502.686	1.018669
SumYShuffleG4X2VectorTraits	526.274	498.113	1.009402
SumYShuffleG4X2VectorTraits_Tuple	591.513	443.176	0.898074
SumYShuffleG4X2_ConstVectorTraits	522.896	501.331	1.015924
SumYShuffleG4X2_ConstVectorTraits_Tuple	588.253	445.631	0.903050

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	480.236	545.865
SumYShuffleG4VectorTraits	507.567	516.472	0.946152
SumYShuffleG4X2VectorTraits	511.848	512.153	0.938239
SumYShuffleG4X2VectorTraits_Tuple	655.267	400.057	0.732885
SumYShuffleG4X2_ConstVectorTraits	495.605	528.937	0.968988
SumYShuffleG4X2_ConstVectorTraits_Tuple	628.809	416.889	0.763722

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	421.909	621.328
SumYShuffleG4VectorTraits	401.109	653.548	1.051856
SumYShuffleG4X2VectorTraits	401.706	652.577	1.050294
SumYShuffleG4X2VectorTraits_Tuple	420.955	622.737	1.002267
SumYShuffleG4X2_ConstVectorTraits	402.340	651.548	1.048637
SumYShuffleG4X2_ConstVectorTraits_Tuple	432.408	606.243	0.975721

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	440.131	595.604
SumYShuffleG4VectorTraits	443.144	591.554	0.993200
SumYShuffleG4X2VectorTraits	441.721	593.461	0.996401
SumYShuffleG4X2VectorTraits_Tuple	527.352	497.095	0.834605
SumYShuffleG4X2_ConstVectorTraits	464.473	564.390	0.947592
SumYShuffleG4X2_ConstVectorTraits_Tuple	487.006	538.277	0.903749

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	546.487	479.689
SumYShuffleG4VectorTraits	564.700	464.218	0.967748
SumYShuffleG4X2VectorTraits	609.459	430.126	0.896676
SumYShuffleG4X2VectorTraits_Tuple	802.936	326.482	0.680611
SumYShuffleG4X2_ConstVectorTraits	633.475	413.819	0.862682
SumYShuffleG4X2_ConstVectorTraits_Tuple	593.195	441.919	0.921261

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	506.669	517.387
SumYShuffleG4VectorTraits	485.109	540.381	1.044443
SumYShuffleG4X2VectorTraits	507.293	516.751	0.998770
SumYShuffleG4X2VectorTraits_Tuple	612.546	427.958	0.827153
SumYShuffleG4X2_ConstVectorTraits	446.965	586.497	1.133576
SumYShuffleG4X2_ConstVectorTraits_Tuple	568.704	460.950	0.890919

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	488.406	536.734
SumYShuffleG4VectorTraits	403.959	648.937	1.209047
SumYShuffleG4X2VectorTraits	403.028	650.436	1.211841
SumYShuffleG4X2VectorTraits_Tuple	418.090	627.003	1.168182
SumYShuffleG4X2_ConstVectorTraits	402.349	651.534	1.213885
SumYShuffleG4X2_ConstVectorTraits_Tuple	414.406	632.578	1.178568

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	445.892	587.909
SumYShuffleG4VectorTraits	21.165	12385.656	21.067305
SumYShuffleG4X2VectorTraits	12.370	21192.635	36.047482
SumYShuffleG4X2VectorTraits_Tuple	12.438	21076.015	35.849118
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	11.782	22250.343	37.846583
SumYShuffleG4X2_ConstVectorTraits	11.236	23329.748	39.682591
SumYShuffleG4X2_ConstVectorTraits_Tuple	11.292	23214.130	39.485931
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	11.257	23286.375	39.608816

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	532.004	492.748
SumYShuffleG4VectorTraits	41.447	6324.785	12.835746
SumYShuffleG4X2VectorTraits	38.061	6887.413	13.977563
SumYShuffleG4X2VectorTraits_Tuple	34.522	7593.500	15.410522
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256_AvxByte	45.011	5824.016	11.819467
SumYShuffleG4X2Vector256_AvxUInt32	42.201	6211.731	12.606310
SumYShuffleG4X2Vector256Traits	32.554	8052.664	16.342365
SumYShuffleG4X2_ConstVectorTraits	23.565	11124.317	22.576088
SumYShuffleG4X2_ConstVectorTraits_Tuple	21.189	12371.865	25.107907
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	23.865	10984.509	22.292357

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	478.228	548.157
SumYShuffleG4VectorTraits	63.033	4158.838	7.586944
SumYShuffleG4X2VectorTraits	51.181	5121.929	9.343907
SumYShuffleG4X2VectorTraits_Tuple	51.844	5056.428	9.224413
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	58.191	4504.890	8.218245
SumYShuffleG4X2_ConstVectorTraits	50.801	5160.167	9.413663
SumYShuffleG4X2_ConstVectorTraits_Tuple	104.905	2498.878	4.558690
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	59.908	4375.811	7.982767

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	541.646	483.977
SumYShuffleG4VectorTraits	10.810	24249.893	50.105490
SumYShuffleG4X2VectorTraits	7.455	35163.607	72.655567
SumYShuffleG4X2VectorTraits_Tuple	7.265	36083.753	74.556787
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	7.190	36458.811	75.331737
SumYShuffleG4X2_ConstVectorTraits	7.233	36243.841	74.887563
SumYShuffleG4X2_ConstVectorTraits_Tuple	7.168	36572.053	75.565719
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	7.140	36712.433	75.855774

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	441.317	594.004
SumYShuffleG4VectorTraits	25.316	10354.871	17.432325
SumYShuffleG4X2VectorTraits	13.905	18852.927	31.738718
SumYShuffleG4X2VectorTraits_Tuple	14.404	18199.047	30.637918
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	14.181	18485.654	31.120418
SumYShuffleG4X2_ConstVectorTraits	11.606	22586.489	38.024133
SumYShuffleG4X2_ConstVectorTraits_Tuple	11.763	22285.372	37.517206
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	12.724	20602.944	34.684855

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	542.777	482.968
SumYShuffleG4VectorTraits	42.493	6169.168	12.773446
SumYShuffleG4X2VectorTraits	30.625	8559.817	17.723355
SumYShuffleG4X2VectorTraits_Tuple	39.211	6685.504	13.842535
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256_AvxByte	59.691	4391.710	9.093166
SumYShuffleG4X2Vector256_AvxUInt32	42.766	6129.686	12.691698
SumYShuffleG4X2Vector256Traits	31.986	8195.539	16.969107
SumYShuffleG4X2_ConstVectorTraits	21.257	12332.341	25.534480
SumYShuffleG4X2_ConstVectorTraits_Tuple	21.140	12400.555	25.675718
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	24.060	10895.647	22.559761

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	491.744	533.090
SumYShuffleG4VectorTraits	85.197	3076.907	5.771833
SumYShuffleG4X2VectorTraits	60.790	4312.276	8.089206
SumYShuffleG4X2VectorTraits_Tuple	63.676	4116.825	7.722568
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	64.020	4094.688	7.681044
SumYShuffleG4X2_ConstVectorTraits	49.786	5265.469	9.877258
SumYShuffleG4X2_ConstVectorTraits_Tuple	44.582	5880.068	11.030159
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	43.888	5973.079	11.204633

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	395.954	662.056
SumYShuffleG4VectorTraits	9.641	27191.013	41.070560
SumYShuffleG4X2VectorTraits	9.180	28557.353	43.134343
SumYShuffleG4X2VectorTraits_Tuple	8.885	29505.579	44.566588
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	9.437	27778.956	41.958616
SumYShuffleG4X2_ConstVectorTraits	8.959	29259.141	44.194356
SumYShuffleG4X2_ConstVectorTraits_Tuple	9.313	28148.458	42.516730
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	9.454	27727.483	41.880870

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	515.154	508.865
SumYShuffleG4VectorTraits	25.871	10132.815	19.912564
SumYShuffleG4X2VectorTraits	11.151	23508.024	46.196939
SumYShuffleG4X2VectorTraits_Tuple	11.737	22335.691	43.893122
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	11.154	23503.061	46.187185
SumYShuffleG4X2_ConstVectorTraits	12.022	21805.969	42.852136
SumYShuffleG4X2_ConstVectorTraits_Tuple	11.877	22070.928	43.372821
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	12.027	21796.030	42.832604

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	660.975	396.602
SumYShuffleG4VectorTraits	41.172	6366.987	16.053851
SumYShuffleG4X2VectorTraits	25.566	10253.613	25.853669
SumYShuffleG4X2VectorTraits_Tuple	27.339	9588.768	24.177315
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256_AvxByte	41.234	6357.400	16.029677
SumYShuffleG4X2Vector256_AvxUInt32	30.182	8685.499	21.899793
SumYShuffleG4X2Vector256Traits	25.430	10308.526	25.992126
SumYShuffleG4X2_ConstVectorTraits	22.370	11718.801	29.548024
SumYShuffleG4X2_ConstVectorTraits_Tuple	22.364	11721.551	29.554956
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	22.459	11672.010	29.430042

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	793.588	330.328
SumYShuffleG4VectorTraits	63.457	4131.018	12.505818
SumYShuffleG4X2VectorTraits	49.659	5278.871	15.980707
SumYShuffleG4X2VectorTraits_Tuple	47.170	5557.424	16.823972
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	51.096	5130.386	15.531200
SumYShuffleG4X2_ConstVectorTraits	43.365	6045.086	18.300269
SumYShuffleG4X2_ConstVectorTraits_Tuple	43.537	6021.182	18.227903
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	47.605	5506.690	16.670384

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	398.003	658.649
SumYShuffleG4VectorTraits	6.903	37976.703	57.658483
SumYShuffleG4X2VectorTraits	5.046	51954.244	78.880015
SumYShuffleG4X2VectorTraits_Tuple	4.976	52680.682	79.982936
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	5.047	51944.222	78.864799
SumYShuffleG4X2_ConstVectorTraits	5.018	52235.658	79.307275
SumYShuffleG4X2_ConstVectorTraits_Tuple	4.929	53184.728	80.748209
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	5.213	50287.931	76.350120

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-30719
SumYShuffleG4X2VectorBase	368.423	711.530
SumYShuffleG4VectorTraits	14.044	18665.699	26.233184
SumYShuffleG4X2VectorTraits	11.957	21923.549	30.811839
SumYShuffleG4X2VectorTraits_Tuple	12.126	21618.967	30.383772
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	11.371	23052.914	32.399073
SumYShuffleG4X2_ConstVectorTraits	11.446	22902.073	32.187077
SumYShuffleG4X2_ConstVectorTraits_Tuple	11.688	22428.959	31.522152
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	11.673	22457.839	31.562741

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	1670557139
SumYShuffleG4X2VectorBase	441.202	594.158
SumYShuffleG4VectorTraits	29.256	8960.338	15.080720
SumYShuffleG4X2VectorTraits	26.097	10045.062	16.906367
SumYShuffleG4X2VectorTraits_Tuple	24.946	10508.276	17.685981
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256_AvxByte	28.585	9170.618	15.434633
SumYShuffleG4X2Vector256_AvxUInt32	28.005	9360.738	15.754614
SumYShuffleG4X2Vector256Traits	24.344	10768.316	18.123643
SumYShuffleG4X2_ConstVectorTraits	23.406	11199.840	18.849920
SumYShuffleG4X2_ConstVectorTraits_Tuple	20.782	12613.811	21.229708
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	20.924	12528.153	21.085540

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-7093169134606779633
SumYShuffleG4X2VectorBase	460.664	569.057
SumYShuffleG4VectorTraits	62.066	4223.617	7.422138
SumYShuffleG4X2VectorTraits	47.891	5473.818	9.619110
SumYShuffleG4X2VectorTraits_Tuple	47.669	5499.257	9.663814
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	47.910	5471.628	9.615261
SumYShuffleG4X2_ConstVectorTraits	42.916	6108.323	10.734122
SumYShuffleG4X2_ConstVectorTraits_Tuple	42.224	6208.420	10.910022
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	42.845	6118.364	10.751766

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	90
SumYShuffleG4X2VectorBase	317.975	824.417
SumYShuffleG4VectorTraits	5.133	51069.528	61.946251
SumYShuffleG4X2VectorTraits	4.787	54764.759	66.428488
SumYShuffleG4X2VectorTraits_Tuple	4.631	56604.884	68.660521
SumYShuffleG4X2Vector128_Arm	Run fail! Requires hardware support AdvSimd!
SumYShuffleG4X2Vector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2Vector256Traits	4.701	55767.775	67.645126
SumYShuffleG4X2_ConstVectorTraits	4.706	55703.945	67.567701
SumYShuffleG4X2_ConstVectorTraits_Tuple	4.662	56232.852	68.209254
SumYShuffleG4X2_ConstVector128Traits	Run fail! Vector byte size mismatch(32!=16) !
SumYShuffleG4X2_ConstVector256Traits	4.693	55854.012	67.749728

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-21037
SumYShuffleG4X2VectorBase	677.880	386.712
SumYShuffleG4VectorTraits	677.893	386.704	0.999981
SumYShuffleG4X2VectorTraits	677.737	386.793	1.000211
SumYShuffleG4X2VectorTraits_Tuple	739.167	354.648	0.917086
SumYShuffleG4X2Vector128Traits	1060.763	247.128	0.639050
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	698.688	375.195	0.970219
SumYShuffleG4X2_ConstVectorTraits_Tuple	762.183	343.938	0.889393
SumYShuffleG4X2_ConstVector128Traits	1084.024	241.825	0.625337
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	2018061718
SumYShuffleG4X2VectorBase	707.355	370.598
SumYShuffleG4VectorTraits	700.369	374.294	1.009974
SumYShuffleG4X2VectorTraits	695.903	376.696	1.016456
SumYShuffleG4X2VectorTraits_Tuple	926.265	283.012	0.763663
SumYShuffleG4X2Vector128Traits	1452.288	180.504	0.487062
SumYShuffleG4X2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256_AvxUInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	680.110	385.443	1.040059
SumYShuffleG4X2_ConstVectorTraits_Tuple	904.059	289.963	0.782421
SumYShuffleG4X2_ConstVector128Traits	1450.850	180.683	0.487545
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	5878554485936559874
SumYShuffleG4X2VectorBase	828.246	316.505
SumYShuffleG4VectorTraits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumYShuffleG4X2VectorTraits	828.679	316.339	0.999477
SumYShuffleG4X2VectorTraits_Tuple	1018.418	257.403	0.813267
SumYShuffleG4X2Vector128Traits	1271.088	206.236	0.651604
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	838.373	312.682	0.987921
SumYShuffleG4X2_ConstVectorTraits_Tuple	1038.554	252.412	0.797499
SumYShuffleG4X2_ConstVector128Traits	1275.222	205.567	0.649492
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	91
SumYShuffleG4X2VectorBase	566.352	462.864
SumYShuffleG4VectorTraits	566.294	462.912	1.000103
SumYShuffleG4X2VectorTraits	566.293	462.913	1.000105
SumYShuffleG4X2VectorTraits_Tuple	601.274	435.981	0.941920
SumYShuffleG4X2Vector128Traits	821.351	319.162	0.689537
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	586.150	447.230	0.966224
SumYShuffleG4X2_ConstVectorTraits_Tuple	620.777	422.283	0.912327
SumYShuffleG4X2_ConstVector128Traits	840.032	312.064	0.674203
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-21037
SumYShuffleG4X2VectorBase	675.503	388.072
SumYShuffleG4VectorTraits	86.405	3033.907	7.817896
SumYShuffleG4X2VectorTraits	33.930	7725.973	19.908606
SumYShuffleG4X2VectorTraits_Tuple	109.206	2400.446	6.185569
SumYShuffleG4X2Vector128_Arm	58.127	4509.860	11.621193
SumYShuffleG4X2Vector128Traits	33.963	7718.539	19.889449
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	33.960	7719.147	19.891017
SumYShuffleG4X2_ConstVectorTraits_Tuple	108.592	2414.033	6.220580
SumYShuffleG4X2_ConstVector128Traits	34.000	7710.066	19.867615
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	2018061718
SumYShuffleG4X2VectorBase	685.055	382.661
SumYShuffleG4VectorTraits	75.032	3493.783	9.130229
SumYShuffleG4X2VectorTraits	68.255	3840.669	10.036738
SumYShuffleG4X2VectorTraits_Tuple	224.476	1167.805	3.051801
SumYShuffleG4X2Vector128_Arm	118.086	2219.949	5.801346
SumYShuffleG4X2Vector128Traits	68.181	3844.824	10.047598
SumYShuffleG4X2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256_AvxUInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	68.234	3841.837	10.039790
SumYShuffleG4X2_ConstVectorTraits_Tuple	222.788	1176.655	3.074926
SumYShuffleG4X2_ConstVector128Traits	68.166	3845.648	10.049751
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	5878554485936559874
SumYShuffleG4X2VectorBase	776.974	337.391
SumYShuffleG4VectorTraits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumYShuffleG4X2VectorTraits	235.490	1113.184	3.299388
SumYShuffleG4X2VectorTraits_Tuple	606.102	432.508	1.281919
SumYShuffleG4X2Vector128_Arm	478.688	547.630	1.623131
SumYShuffleG4X2Vector128Traits	234.178	1119.423	3.317879
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	214.950	1219.556	3.614667
SumYShuffleG4X2_ConstVectorTraits_Tuple	620.922	422.185	1.251322
SumYShuffleG4X2_ConstVector128Traits	215.321	1217.454	3.608436
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	91
SumYShuffleG4X2VectorBase	565.504	463.558
SumYShuffleG4VectorTraits	19.898	13174.687	28.420799
SumYShuffleG4X2VectorTraits	16.756	15644.668	33.749111
SumYShuffleG4X2VectorTraits_Tuple	54.610	4800.263	10.355261
SumYShuffleG4X2Vector128_Arm	29.032	9029.548	19.478791
SumYShuffleG4X2Vector128Traits	16.784	15618.742	33.693183
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	16.756	15644.362	33.748451
SumYShuffleG4X2_ConstVectorTraits_Tuple	54.712	4791.337	10.336004
SumYShuffleG4X2_ConstVector128Traits	16.748	15652.555	33.766125
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-21037
SumYShuffleG4X2VectorBase	676.224	387.659
SumYShuffleG4VectorTraits	86.008	3047.887	7.862298
SumYShuffleG4X2VectorTraits	30.913	8480.181	21.875387
SumYShuffleG4X2VectorTraits_Tuple	89.756	2920.615	7.533988
SumYShuffleG4X2Vector128_Arm	49.263	5321.330	13.726849
SumYShuffleG4X2Vector128Traits	29.987	8742.058	22.550923
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	31.296	8376.290	21.607391
SumYShuffleG4X2_ConstVectorTraits_Tuple	90.433	2898.777	7.477655
SumYShuffleG4X2_ConstVector128Traits	30.706	8537.227	22.022542
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	2018061718
SumYShuffleG4X2VectorBase	690.100	379.864
SumYShuffleG4VectorTraits	66.100	3965.876	10.440261
SumYShuffleG4X2VectorTraits	62.403	4200.807	11.058722
SumYShuffleG4X2VectorTraits_Tuple	192.599	1361.085	3.583088
SumYShuffleG4X2Vector128_Arm	98.822	2652.700	6.983294
SumYShuffleG4X2Vector128Traits	61.396	4269.716	11.240126
SumYShuffleG4X2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256_AvxUInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	61.393	4269.955	11.240755
SumYShuffleG4X2_ConstVectorTraits_Tuple	192.397	1362.519	3.586863
SumYShuffleG4X2_ConstVector128Traits	61.486	4263.460	11.223657
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	5878554485936559874
SumYShuffleG4X2VectorBase	773.365	338.965
SumYShuffleG4VectorTraits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumYShuffleG4X2VectorTraits	200.946	1304.552	3.848630
SumYShuffleG4X2VectorTraits_Tuple	414.861	631.884	1.864156
SumYShuffleG4X2Vector128_Arm	434.580	603.213	1.779571
SumYShuffleG4X2Vector128Traits	200.626	1306.633	3.854768
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	175.910	1490.213	4.396358
SumYShuffleG4X2_ConstVectorTraits_Tuple	410.288	638.927	1.884933
SumYShuffleG4X2_ConstVector128Traits	175.976	1489.655	4.394712
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	91
SumYShuffleG4X2VectorBase	566.383	462.839
SumYShuffleG4VectorTraits	16.722	15676.439	33.870172
SumYShuffleG4X2VectorTraits	15.130	17326.510	37.435279
SumYShuffleG4X2VectorTraits_Tuple	47.736	5491.500	11.864815
SumYShuffleG4X2Vector128_Arm	24.355	10763.316	23.254985
SumYShuffleG4X2Vector128Traits	15.075	17389.014	37.570326
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	15.249	17191.104	37.142726
SumYShuffleG4X2_ConstVectorTraits_Tuple	47.719	5493.533	11.869207
SumYShuffleG4X2_ConstVector128Traits	15.542	16866.401	36.441178
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

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
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[YShuffleG4X2Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	-21037
SumYShuffleG4X2VectorBase	508.699	515.322
SumYShuffleG4VectorTraits	29.777	8803.467	17.083417
SumYShuffleG4X2VectorTraits	25.189	10406.896	20.194923
SumYShuffleG4X2VectorTraits_Tuple	92.396	2837.187	5.505654
SumYShuffleG4X2Vector128_Arm	45.824	5720.611	11.101032
SumYShuffleG4X2Vector128Traits	25.125	10433.518	20.246584
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	26.605	9853.050	19.120166
SumYShuffleG4X2_ConstVectorTraits_Tuple	92.127	2845.470	5.521727
SumYShuffleG4X2_ConstVector128Traits	27.092	9676.039	18.776670
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	2018061718
SumYShuffleG4X2VectorBase	684.143	383.171
SumYShuffleG4VectorTraits	65.291	4015.026	10.478414
SumYShuffleG4X2VectorTraits	53.584	4892.226	12.767730
SumYShuffleG4X2VectorTraits_Tuple	181.916	1441.015	3.760760
SumYShuffleG4X2Vector128_Arm	95.751	2737.777	7.145048
SumYShuffleG4X2Vector128Traits	53.699	4881.740	12.740362
SumYShuffleG4X2Vector256_AvxByte	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256_AvxUInt32	Run fail! Requires hardware support Avx, Avx2!
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	56.502	4639.548	12.108290
SumYShuffleG4X2_ConstVectorTraits_Tuple	185.271	1414.922	3.692662
SumYShuffleG4X2_ConstVector128Traits	56.294	4656.698	12.153048
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	5878554485936559874
SumYShuffleG4X2VectorBase	588.820	445.202
SumYShuffleG4VectorTraits	Run fail! The count(2) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.
SumYShuffleG4X2VectorTraits	179.181	1463.016	3.286184
SumYShuffleG4X2VectorTraits_Tuple	360.316	727.539	1.634178
SumYShuffleG4X2Vector128_Arm	374.666	699.673	1.571586
SumYShuffleG4X2Vector128Traits	178.647	1467.385	3.295997
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	163.933	1599.096	3.591843
SumYShuffleG4X2_ConstVectorTraits_Tuple	376.733	695.836	1.562966
SumYShuffleG4X2_ConstVector128Traits	164.627	1592.349	3.576688
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

[YShuffleG4X2Benchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumYShuffleG4X2VectorBase	91
SumYShuffleG4X2VectorBase	425.198	616.522
SumYShuffleG4VectorTraits	15.243	17198.091	27.895355
SumYShuffleG4X2VectorTraits	12.898	20324.954	32.967136
SumYShuffleG4X2VectorTraits_Tuple	45.582	5751.070	9.328253
SumYShuffleG4X2Vector128_Arm	23.572	11121.180	18.038587
SumYShuffleG4X2Vector128Traits	12.747	20565.196	33.356809
SumYShuffleG4X2Vector256Traits	Run fail! Vector byte size mismatch(16!=32) !
SumYShuffleG4X2_ConstVectorTraits	13.570	19318.179	31.334143
SumYShuffleG4X2_ConstVectorTraits_Tuple	46.031	5695.006	9.237317
SumYShuffleG4X2_ConstVector128Traits	13.372	19604.070	31.797859
SumYShuffleG4X2_ConstVector256Traits	Run fail! Vector byte size mismatch(16!=32) !

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

