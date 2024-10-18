# Benchmark - YGroup3ToGroup4
([← Back](README.md))

See [Group](YGroup3ToGroup4_Group.md)

- `YGroup3ToGroup4`: Convert a 3-element group, to a 4-element group. It also converts packed RGB pixel data to packed RGBA pixel data (将3-元素组, 转为4-元素组. 它还能将 已打包的RGB像素数据, 转换为 已打包的RGBA像素数据).
  Mnemonic: View for group: `(result0, result1, result2, result3) = YGroup4Zip(YGroup3Unzip(data0, data1, data2), Vector.Zero))`. View for element: `element_ref(i, result0, result1, result2, result3) := (3!=(i%4))?element_ref((i/4)*3+(i%4), data0, data1, data2):0`.
- `YGroup4ToGroup3`: Convert a 4-element group, to a 3-element group. It also converts packed RGBA pixel data to packed RGB pixel data (将4-元素组, 转为3-元素组. 它还能将 已打包的RGBA像素数据, 转换为 已打包的RGB像素数据).
  Mnemonic: View for group: `(result0, result1, result2) = YGroup3Zip(YGroup4Unzip(data0, data1, data2, data3)))`. View for element: `element_ref(i, result0, result1, result2) := element_ref((i/3)*4+(i%3), data0, data1, data2, data3)`.

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

[YGroup3ToGroup4Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	2094.409	125.164
SumBase_Unzip	288.404	908.947	7.262066
SumBase	291.937	897.949	7.174192
SumTraits	286.186	915.993	7.318355

[YGroup3ToGroup4Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	2370.434	110.589
SumBase_Unzip	477.000	549.569	4.969467
SumBase	2368.770	110.667	1.000703
SumTraits	2406.335	108.939	0.985081

[YGroup3ToGroup4Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
SumBase_Basic	3055.041	85.807
SumBase_Unzip	3384.873	77.446	0.902557
SumBase	2947.579	88.935	1.036457
SumTraits	2950.032	88.861	1.035596

[YGroup3ToGroup4Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
SumBase_Basic	4291.844	61.080
SumBase	4202.818	62.373	1.021183
SumTraits	4076.092	64.313	1.052931

[YGroup4ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	182
SumBase_Basic	1895.049	138.331
SumBase_Unzip	968.026	270.803	1.957643
SumBase	970.632	270.076	1.952387
SumTraits	897.806	291.983	2.110755

[YGroup4ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	29252
SumBase_Basic	2387.547	109.796
SumBase_Unzip	1076.768	243.454	2.217327
SumBase	2268.005	115.584	1.052708
SumTraits	2219.549	118.107	1.075690

[YGroup4ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	1809936964
SumBase_Basic	2857.380	91.743
SumBase_Unzip	3047.589	86.017	0.937587
SumBase	2878.131	91.081	0.992790
SumTraits	2752.264	95.247	1.038193

[YGroup4ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-5443202675530370315
SumBase_Basic	3919.710	66.878
SumBase	4023.412	65.155	0.974225
SumTraits	3981.552	65.840	0.984468

```

