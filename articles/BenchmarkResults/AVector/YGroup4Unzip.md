# Benchmark - YGroup4Unzip
([← Back](README.md))

See [Group](YGroup4Unzip_Group.md)

- `YGroup4Unzip[/_Bit128]`: De-Interleave 4-element groups into 4 vectors. It converts the 4-element groups AoS to SoA. It can also deinterleave packed RGBA pixel data into R,G,B,A planar data (将4-元素组解交织为4个向量. 它能将4元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGBA像素数据, 解交织为 R,G,B,A 平面数据).
  Mnemonic: `x[i] =: element_ref(4*i, data0, data1, data2, data3)`, `y[i] =: element_ref(4*i+1, data0, data1, data2, data3)`, `z[i] =: element_ref(4*i+2, data0, data1, data2, data3)`, `w[i] =: element_ref(4*i+3, data0, data1, data2, data3)`.
- `YGroup4Zip[/_Bit128]`: Interleave 4 vectors into 4-element groups. It converts the 4-element groups SoA to AoS. It can also interleave R,G,B,A planar data into packed RGBA pixel data (将4个向量交织为4-元素组. 它能将4元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B,A 平面数据, 交织为 已打包的RGBA像素数据).
  Mnemonic: `element_ref(i, data0, data1, data2, data3) := (0==(i&3))?( x[i2] ):( (1==(i&3))?( y[i2] ):( (2==(i&3))?( z[i2] ):( w[i2] ) ) )`, `i2 := i/4`.

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

[YGroup4UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	1373.110	190.913
SumBase_Unzip	199.576	1313.504	6.880132
SumBase	200.289	1308.828	6.855639
SumTraits	199.832	1311.822	6.871320

[YGroup4UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	5407.139	48.481
SumBase	5549.405	47.238	0.974364
SumTraits	5847.412	44.831	0.924706
SumTraits_Int128	4304.007	60.907	1.256303

[YGroup4UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	1511.062	173.483
SumBase_Unzip	305.389	858.395	4.947998
SumBase	305.963	856.782	4.938703
SumTraits	305.004	859.478	4.954239

[YGroup4UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
SumBase_Basic	1860.203	140.922
SumBase_Unzip	687.519	381.290	2.705677
SumBase	692.271	378.672	2.687101
SumTraits	689.121	380.403	2.699383

[YGroup4UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	2678.466	97.871
SumBase	2600.014	100.824	1.030174
SumTraits	2422.759	108.201	1.105544

[YGroup4ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	1043.759	251.154
SumBase_Zip	50.782	5162.172	20.553838
SumBase	51.006	5139.426	20.463273
SumTraits	52.139	5027.778	20.018733

[YGroup4ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	5246.663	49.964
SumBase	5291.125	49.544	0.991597
SumTraits	5596.340	46.842	0.937517
SumTraits_Int128	3979.765	65.869	1.318335

[YGroup4ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	1301.028	201.490
SumBase_Zip	105.505	2484.660	12.331439
SumBase	99.820	2626.164	13.033723
SumTraits	100.434	2610.113	12.954061

[YGroup4ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-466837542
SumBase_Basic	1817.821	144.208
SumBase_Zip	4363.660	60.074	0.416582
SumBase	1807.688	145.016	1.005606
SumTraits	1778.714	147.378	1.021986

[YGroup4ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572401668
SumBase_Basic	2756.727	95.092
SumBase	2675.883	97.965	1.030212
SumTraits	2708.778	96.776	1.017701

```

