# Benchmark - Clamp
([← Back](README.md))

## x86

### Intel Core i5-8250U
`Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.4515.0
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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-19177
SumClamp_If	6407.190	204.570
SumClamp_IfUnrolling4	6233.757	210.262	1.027821
SumClamp_MinMax	7154.760	183.196	0.871274
SumClamp_MinMaxUnrolling4	8232.439	159.214	0.757219
SumClamp_BitUtil	4218.192	310.730	1.951651
SumClamp_BitUtilUnrolling4	5280.776	248.206	1.558945

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-361747071
SumClamp_If	6314.984	207.557
SumClamp_IfUnrolling4	6103.007	214.766	1.034733
SumClamp_MinMax	6505.901	201.466	0.938073
SumClamp_MinMaxUnrolling4	6525.337	200.866	0.935278
SumClamp_BitUtil	3688.944	355.310	1.768890
SumClamp_BitUtilUnrolling4	3255.512	402.616	2.004397

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


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-19177
SumClamp_If	6279.642	208.725
SumClamp_IfUnrolling4	6206.148	211.197	1.011842
SumClamp_MinMax	6685.663	196.049	0.928277
SumClamp_MinMaxUnrolling4	6606.031	198.413	0.939467
SumClamp_Math	9910.020	132.262	0.666601
SumClamp_MathUnrolling4	8142.576	160.971	0.811295
SumClamp_BitUtil	4261.506	307.572	1.910727
SumClamp_BitUtilUnrolling4	5340.954	245.409	1.524555

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-361747071
SumClamp_If	6409.106	204.509
SumClamp_IfUnrolling4	6161.552	212.726	1.040177
SumClamp_MinMax	6507.491	201.417	0.946840
SumClamp_MinMaxUnrolling4	6493.988	201.836	0.948809
SumClamp_Math	9676.567	135.453	0.671105
SumClamp_MathUnrolling4	7815.167	167.715	0.830947
SumClamp_BitUtil	3670.981	357.049	2.128904
SumClamp_BitUtilUnrolling4	3257.521	402.367	2.399115

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
```

#### .NET Core 3.1

```
```

#### .NET 5.0

```
```

#### .NET 6.0

```
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
Environment.Version:	7.0.1
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.1\
RuntimeInformation.FrameworkDescription:	.NET 7.0.1
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ClampBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-19177
SumClamp_If	6268.431	209.099
SumClamp_IfUnrolling4	6075.649	215.733	1.031730
SumClamp_MinMax	6993.334	187.424	0.868777
SumClamp_MinMaxUnrolling4	7575.122	173.030	0.802053
SumClamp_Math	7107.040	184.426	1.065862
SumClamp_MathUnrolling4	6370.729	205.741	1.189051
SumClamp_BitUtil	3113.873	420.929	2.045918
SumClamp_BitUtilUnrolling4	3272.762	400.494	1.946591

[ClampBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumClamp_If	-361747071
SumClamp_If	6145.435	213.284
SumClamp_IfUnrolling4	5894.984	222.345	1.042486
SumClamp_MinMax	7065.760	185.503	0.834303
SumClamp_MinMaxUnrolling4	7106.496	184.440	0.829520
SumClamp_Math	6835.153	191.762	1.039698
SumClamp_MathUnrolling4	6412.514	204.400	1.108223
SumClamp_BitUtil	2317.607	565.549	2.766868
SumClamp_BitUtilUnrolling4	2477.605	529.027	2.588190

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
```

#### .NET 5.0

```
```

#### .NET 6.0

```
```

#### .NET 7.0

```
```

