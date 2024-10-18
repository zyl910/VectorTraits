# Benchmark - YGroup1ToGroup3
([← Back](README.md))

See [Group](YGroup1ToGroup3_Group.md)

- `YGroup1ToGroup3`: Convert a 1-element group, to a 3-element group. It also converts grayscale pixel data to packed RGB pixel data (将1-元素组, 转为3-元素组. 它还能将 灰度像素数据, 转换为 已打包的RGB像素数据).
  Mnemonic: View for group: `(result0, result1, result2) = YGroup3Zip(x, x, x)`. View for element: `element_ref(i, result0, result1, result2) := x[i/3]`.

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

[YGroup1ToGroup3Benchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	86
SumBase_Basic	1302.827	201.212
SumBase_Zip	847.135	309.448	1.537920
SumBase	839.909	312.110	1.551153
SumTraits	860.104	304.782	1.514731

[YGroup1ToGroup3Benchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-8306
SumBase_Basic	1672.810	156.709
SumBase_Zip	1022.148	256.464	1.636563
SumBase	1702.338	153.991	0.982655
SumTraits	1606.558	163.171	1.041238

[YGroup1ToGroup3Benchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-1403265138
SumBase_Basic	2107.478	124.388
SumBase_Zip	1387.965	188.869	1.518394
SumBase	2080.365	126.009	1.013033
SumTraits	2035.862	128.763	1.035177

[YGroup1ToGroup3Benchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-715627282993526260
SumBase_Basic	2964.313	88.433
SumBase	3122.456	83.954	0.949353
SumTraits	3045.918	86.064	0.973208

```

