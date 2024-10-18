# Benchmark - ConditionalSelect
([← Back](README.md))

See [Group](ConditionalSelect_Group.md)

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

[ConditionalSelectBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	-14742
SumConditionalSelect_If	7388.051	248.375
SumConditionalSelect_Min	6894.448	266.157	1.071594
SumConditionalSelect_Min_BitMath	2997.513	612.177	2.464727
SumConditionalSelect_BitMath	2885.999	635.831	2.559963

[ConditionalSelectBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumConditionalSelect_If	1354956704
SumConditionalSelect_If	6405.219	286.486
SumConditionalSelect_Min	6432.617	285.266	0.995741
SumConditionalSelect_Min_BitMath	2795.365	656.447	2.291372
SumConditionalSelect_BitMath	2808.432	653.392	2.280710
```
